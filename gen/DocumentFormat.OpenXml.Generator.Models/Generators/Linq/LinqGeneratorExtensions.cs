// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Generator.Models;

namespace DocumentFormat.OpenXml.Generator;

/// <summary>
/// Code generator for the namespace-related Linq-to-Xml classes.
/// </summary>
public static class LinqGeneratorExtensions
{
    private const string EmptyNamespace = "NoNamespace";

    public static IEnumerable<(string ClassName, string Contents)> GenerateLinqFiles(this OpenXmlGeneratorServices services)
    {
        var visitor = new LinqVisitor(services);
        var fieldInfos = visitor.Visit();

        IEnumerable<IGrouping<string, FieldInfo>> fieldInfoGroupings = fieldInfos.Values
            .GroupBy(fi => fi.Prefix)
            .OrderBy(g => g.Key)
            .ToList();

        foreach (var fieldInfoGrouping in fieldInfoGroupings)
        {
            var prefix = fieldInfoGrouping.Key;
            var fieldNames = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            foreach (var info in fieldInfoGrouping.OrderBy(fi => fi.LocalName))
            {
                // Some names contain dashes, which we need to replace.
                var fieldName = info.LocalName
                    .Replace('-', '_');

                // Ensure the field name is not equal to the prefix, which we use for the XNamespace field.
                fieldName = fieldName != prefix ? fieldName : fieldName + "_";

                // Ensure CLS-compliance by making field names unique.
                while (!fieldNames.Add(fieldName))
                {
                    fieldName += "_";
                }

                // Finally, ensure the field name is a valid identifier.
                if (!ValidIdentifierHelper.IsValidIdentifier(fieldName))
                {
                    fieldName = '@' + fieldName;
                }

                info.FieldName = fieldName;
            }
        }

        foreach (var fieldInfoGrouping in fieldInfoGroupings)
        {
            var prefix = fieldInfoGrouping.Key;
            var namespaceName = fieldInfoGrouping.First().NamespaceName;
            var classFieldInfos = fieldInfoGrouping.OrderBy(fi => fi.LocalName, StringComparer.OrdinalIgnoreCase);

            var className = GetClassName(prefix);

            using var output = new StringWriter();

            GenerateClassFilePreamble(output);
            GenerateClass(output, prefix, namespaceName, classFieldInfos, fieldInfos);
            GenerateClassFilePostamble(output);

            yield return (className, output.ToString());
        }
    }

    private static string GetClassName(string prefix)
    {
        return string.IsNullOrEmpty(prefix) ? EmptyNamespace : prefix.ToUpperInvariant();
    }

    private static void GenerateClassFilePreamble(TextWriter output)
    {
        output.WriteLine("// Copyright (c) Microsoft. All rights reserved.");
        output.WriteLine("// Licensed under the MIT license. See LICENSE file in the project root for full license information.");
        output.WriteLine();
        output.WriteLine("using System.Xml.Linq;");

        output.WriteLine();
        output.WriteLine("namespace DocumentFormat.OpenXml.Linq");
        output.WriteLine("{");
    }

    private static void GenerateClassFilePostamble(TextWriter output)
    {
        // End namespace.
        output.WriteLine("}");
    }

    private static void GenerateClass(
        TextWriter output,
        string prefix,
        string namespaceName,
        IEnumerable<FieldInfo> classFieldInfos,
        IReadOnlyDictionary<QName, FieldInfo> fieldInfos)
    {
        // Determine the namespace identifier for the class comment:
        // - 'empty',
        // - 'xmlns="namespaceName"', or
        // - 'xmlns:prefix="namespaceName"'.
        var xmlnsAttribute = string.IsNullOrEmpty(prefix)
            ? string.IsNullOrEmpty(namespaceName) ? "empty" : $"xmlns=\"{namespaceName}\""
            : $"xmlns:{prefix}=\"{namespaceName}\"";

        // Determine what we are declaring in the namespace-related class:
        // - "XNamespace and XName fields" or
        // - "XName fields".
        var theSubjectMatter = xmlnsAttribute != "empty" ? "XNamespace and XName fields" : "XName fields";

        // Derive the class name from the prefix. If the prefix is empty, use
        // "NoNamespace" for compatibility with the Open XML PowerTools.
        var className = GetClassName(prefix);

        // Emit the class comment.
        output.WriteLine(@"    /// <summary>");
        output.WriteLine($"    /// Declares {theSubjectMatter} for the {xmlnsAttribute} namespace.");
        output.WriteLine(@"    /// </summary>");

        // Begin the class declaration.
        output.WriteLine($"    public static partial class {className}");
        output.WriteLine(@"    {");

        // Emit the XNamespace field and determine the RHS prefix of the field declaration.
        string fieldRhsPrefix;

        if (!string.IsNullOrEmpty(namespaceName))
        {
            output.WriteLine(@"        /// <summary>");
            output.WriteLine($"        /// Defines the XML namespace associated with the {prefix} prefix.");
            output.WriteLine(@"        /// </summary>");

            if (!string.IsNullOrEmpty(prefix))
            {
                output.WriteLine($"        public static readonly XNamespace {prefix} = \"{namespaceName}\";");
                fieldRhsPrefix = $"{prefix} + ";
            }
            else
            {
                output.WriteLine($"        public static readonly XNamespace Namespace = \"{namespaceName}\";");
                fieldRhsPrefix = "Namespace + ";
            }
        }
        else
        {
            fieldRhsPrefix = string.Empty;
        }

        foreach (var info in classFieldInfos)
        {
            var qualifiedName = string.IsNullOrEmpty(info.Prefix) ? info.LocalName : info.Prefix + ":" + info.LocalName;

            var parentQualifiedNames = info.ParentQualifiedNames.ToList();
            var childQualifiedNames = info.ChildQualifiedNames.ToList();
            var elementAttributeQualifiedNames = info.ElementAttributeQualifiedNames.ToList();

            var attributeContainerQualifiedNames = info.AttributeContainerQualifiedNames.ToList();

            var elementClassNames = info.ElementClassNames.ToList();
            var elements = elementClassNames.Count switch
            {
                0 => string.Empty,
                1 => "element",
                _ => "elements",
            };

            var attributePropertyNames = info.AttributePropertyNames.ToList();
            var attributes = attributePropertyNames.Count switch
            {
                0 => string.Empty,
                1 => "attribute",
                _ => "attributes",
            };

            var elementsAndOrAttributes = elements != string.Empty && attributes != string.Empty
                ? elements + " and " + attributes
                : elements + attributes;

            output.WriteLine(string.Empty);
            output.WriteLine(@"        /// <summary>");
            output.WriteLine($"        /// Represents the {qualifiedName} XML {elementsAndOrAttributes}.");
            output.WriteLine(@"        /// </summary>");

            string See(QName qName)
            {
                if (fieldInfos.TryGetValue(qName, out var fieldInfo))
                {
                    var reference = fieldInfo.Prefix == prefix
                        ? fieldInfo.FieldName
                        : fieldInfo.QualifiedFieldName;

                    return $"<see cref=\"{reference}\" />";
                }
                else if (string.IsNullOrEmpty(qName.Prefix))
                {
                    return $"<see cref=\"{EmptyNamespace}.{qName.Name.Trim('_')}\" />";
                }
                else
                {
                    return $"<see cref=\"{qName}\" />";
                }
            }

            var hasRemarks = elements != string.Empty || attributes != string.Empty;
            if (hasRemarks)
            {
                output.WriteLine(@"        /// <remarks>");
            }

            if (elements != string.Empty)
            {
                output.WriteLine(@"        /// <para>As an XML element, it:</para>");
                output.WriteLine(@"        /// <list type=""bullet"">");

                if (parentQualifiedNames.Any())
                {
                    var csv = string.Join(", ", parentQualifiedNames.Select(See));
                    output.WriteLine($"        /// <item><description>has the following parent XML elements: {csv}.</description></item>");
                }

                if (childQualifiedNames.Any())
                {
                    var csv = string.Join(", ", childQualifiedNames.Select(See));
                    output.WriteLine($"        /// <item><description>has the following child XML elements: {csv}.</description></item>");
                }

                if (elementAttributeQualifiedNames.Any())
                {
                    var csv = string.Join(", ", elementAttributeQualifiedNames.Select(See));
                    output.WriteLine($"        /// <item><description>has the following XML attributes: {csv}.</description></item>");
                }

                if (elementClassNames.Any())
                {
                    var csv = string.Join(", ", elementClassNames);
                    output.WriteLine($"        /// <item><description>corresponds to the following strongly-typed classes: {csv}.</description></item>");
                }

                output.WriteLine(@"        /// </list>");
            }

            if (attributes != string.Empty)
            {
                output.WriteLine(@"        /// <para>As an XML attribute, it:</para>");
                output.WriteLine(@"        /// <list type=""bullet"">");

                if (attributeContainerQualifiedNames.Any())
                {
                    var csv = string.Join(", ", attributeContainerQualifiedNames.Select(See));
                    output.WriteLine($"        /// <item><description>is contained in the following XML elements: {csv}.</description></item>");
                }

                if (attributePropertyNames.Any())
                {
                    var csv = string.Join(", ", attributePropertyNames);
                    output.WriteLine($"        /// <item><description>corresponds to the following strongly-typed properties: {csv}.</description></item>");
                }

                output.WriteLine(@"        /// </list>");
            }

            if (hasRemarks)
            {
                output.WriteLine(@"        /// </remarks>");
            }

            // Emit field declaration.
            output.WriteLine($"        public static readonly XName {info.FieldName} = {fieldRhsPrefix}\"{info.LocalName}\";");
        }

        // End class declaration.
        output.WriteLine(@"    }");
    }
}
