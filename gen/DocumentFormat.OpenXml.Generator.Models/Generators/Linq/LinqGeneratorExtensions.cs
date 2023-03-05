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
        var fieldInfos = new Dictionary<QName, FieldInfo>();
        var elementMetadataCollection = AssembleElementMetadata(fieldInfos, services);
        AssembleAttributeMetadata(elementMetadataCollection, fieldInfos, services);

        IEnumerable<IGrouping<string, FieldInfo>> fieldInfoGroupings = fieldInfos.Values
            .GroupBy(fi => fi.Prefix)
            .OrderBy(g => g.Key)
            .ToList();

        foreach (IGrouping<string, FieldInfo> fieldInfoGrouping in fieldInfoGroupings)
        {
            string prefix = fieldInfoGrouping.Key;
            var fieldNames = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            foreach (FieldInfo info in fieldInfoGrouping.OrderBy(fi => fi.LocalName))
            {
                // Some names contain dashes, which we need to replace.
                string fieldName = info.LocalName
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

        foreach (IGrouping<string, FieldInfo> fieldInfoGrouping in fieldInfoGroupings)
        {
            var prefix = fieldInfoGrouping.Key;
            var namespaceName = fieldInfoGrouping.First().NamespaceName;
            var classFieldInfos = fieldInfoGrouping.OrderBy(fi => fi.LocalName);

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
        IDictionary<QName, FieldInfo> fieldInfos)
    {
        // Determine the namespace identifier for the class comment:
        // - 'empty',
        // - 'xmlns="namespaceName"', or
        // - 'xmlns:prefix="namespaceName"'.
        string xmlnsAttribute = string.IsNullOrEmpty(prefix)
            ? string.IsNullOrEmpty(namespaceName) ? "empty" : $"xmlns=\"{namespaceName}\""
            : $"xmlns:{prefix}=\"{namespaceName}\"";

        // Determine what we are declaring in the namespace-related class:
        // - "XNamespace and XName fields" or
        // - "XName fields".
        string theSubjectMatter = xmlnsAttribute != "empty" ? "XNamespace and XName fields" : "XName fields";

        // Derive the class name from the prefix. If the prefix is empty, use
        // "NoNamespace" for compatibility with the Open XML PowerTools.
        string className = GetClassName(prefix);

        // Emit the class comment.
        output.WriteLine(@"    /// <summary>");
        output.WriteLine($"    /// Declares {theSubjectMatter} for the {xmlnsAttribute} namespace.");
        output.WriteLine(@"    /// </summary>");

        // Begin the class declaration.
        output.WriteLine($"    public static class {className}");
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

        foreach (FieldInfo info in classFieldInfos)
        {
            string qualifiedName = string.IsNullOrEmpty(info.Prefix) ? info.LocalName : info.Prefix + ":" + info.LocalName;

            List<QName> parentQualifiedNames = info.ParentQualifiedNames.ToList();
            List<QName> childQualifiedNames = info.ChildQualifiedNames.ToList();
            List<QName> elementAttributeQualifiedNames = info.ElementAttributeQualifiedNames.ToList();

            List<QName> attributeContainerQualifiedNames = info.AttributeContainerQualifiedNames.ToList();

            List<string> elementClassNames = info.ElementClassNames.ToList();
            string elements = elementClassNames.Count switch
            {
                0 => string.Empty,
                1 => "element",
                _ => "elements",
            };

            List<string> attributePropertyNames = info.AttributePropertyNames.ToList();
            string attributes = attributePropertyNames.Count switch
            {
                0 => string.Empty,
                1 => "attribute",
                _ => "attributes",
            };

            string elementsAndOrAttributes = elements != string.Empty && attributes != string.Empty
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
                    string reference = fieldInfo.Prefix == prefix
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

            bool hasRemarks = elements != string.Empty || attributes != string.Empty;
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
                    string csv = string.Join(", ", parentQualifiedNames.Select(See));
                    output.WriteLine($"        /// <item><description>has the following parent XML elements: {csv}.</description></item>");
                }

                if (childQualifiedNames.Any())
                {
                    string csv = string.Join(", ", childQualifiedNames.Select(See));
                    output.WriteLine($"        /// <item><description>has the following child XML elements: {csv}.</description></item>");
                }

                if (elementAttributeQualifiedNames.Any())
                {
                    string csv = string.Join(", ", elementAttributeQualifiedNames.Select(See));
                    output.WriteLine($"        /// <item><description>has the following XML attributes: {csv}.</description></item>");
                }

                if (elementClassNames.Any())
                {
                    string csv = string.Join(", ", elementClassNames);
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
                    string csv = string.Join(", ", attributeContainerQualifiedNames.Select(See));
                    output.WriteLine($"        /// <item><description>is contained in the following XML elements: {csv}.</description></item>");
                }

                if (attributePropertyNames.Any())
                {
                    string csv = string.Join(", ", attributePropertyNames);
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

    private static IEnumerable<SchemaType> AssembleElementMetadata(IDictionary<QName, FieldInfo> fieldInfos, OpenXmlGeneratorServices services)
    {
        var visitedElementTypes = new HashSet<SchemaType>();
        var elementMetadataCollection = new List<SchemaType>();

        foreach (var model in services.Context.Namespaces)
        {
            foreach (var type in model.Types)
            {
                if (type.IsRootElement)
                {
                    AssembleElementMetatata(null, type, services, visitedElementTypes, elementMetadataCollection, fieldInfos);
                }
            }
        }

        return elementMetadataCollection;
    }

    private static SchemaType AssembleElementMetatata(
        SchemaType? parentMetadata,
        SchemaType type,
        OpenXmlGeneratorServices services,
        HashSet<SchemaType> visitedTypes,
        ICollection<SchemaType> elementMetadataCollection,
        IDictionary<QName, FieldInfo> fieldInfos)
    {
        elementMetadataCollection.Add(type);

        if (!fieldInfos.TryGetValue(type.Name.QName, out FieldInfo? fieldInfo))
        {
            fieldInfo = new FieldInfo(type.Name.QName, services);
            fieldInfos[type.Name.QName] = fieldInfo;
        }

        fieldInfo.AddParentElementMetadata(parentMetadata);
        fieldInfo.AddElementMetadata(type);

        if (visitedTypes.Add(type))
        {
            foreach (var child in type.Children)
            {
                fieldInfo.AddChildElementMetadata(
                    AssembleElementMetatata(type, services.FindType(child.Name), services, visitedTypes, elementMetadataCollection, fieldInfos));
            }
        }

        return type;
    }

    private static void AssembleAttributeMetadata(
        IEnumerable<SchemaType> elementMetadataCollection,
        IDictionary<QName, FieldInfo> fieldInfos,
        OpenXmlGeneratorServices services)
    {
        foreach (var elementMetadata in elementMetadataCollection)
        {
            AssembleAttributeMetadata(elementMetadata, fieldInfos, services);
        }
    }

    private static void AssembleAttributeMetadata(
        SchemaType elementMetadata,
        IDictionary<QName, FieldInfo> fieldInfos,
        OpenXmlGeneratorServices services)
    {
        foreach (var attributeMetadata in elementMetadata.Attributes)
        {
            if (!fieldInfos.TryGetValue(attributeMetadata.QName, out FieldInfo? fieldInfo))
            {
                fieldInfo = new FieldInfo(attributeMetadata.QName, services);
                fieldInfos[attributeMetadata.QName] = fieldInfo;
            }

            fieldInfo.AddAttributeMetadata(elementMetadata, attributeMetadata);
        }
    }

    /// <summary>
    /// Represents an XName field.
    /// </summary>
    internal class FieldInfo : IComparable<FieldInfo>, IEquatable<FieldInfo>
    {
        private readonly OpenXmlGeneratorServices _services;

        private readonly HashSet<SchemaType> _elementMetadata = new();
        private readonly HashSet<SchemaType> _parentMetadata = new();
        private readonly HashSet<SchemaType> _childMetadata = new();

        private readonly HashSet<SchemaType> _attributeContainerMetadata = new();
        private readonly HashSet<SchemaAttribute> _attributeMetadata = new();

        private readonly SortedSet<string> _attributePropertyNames = new();

        /// <summary>
        /// Initializes a new instance with the given <see cref="QName" />.
        /// </summary>
        /// <param name="qName">The <see cref="QName" />.</param>
        public FieldInfo(QName qName, OpenXmlGeneratorServices services)
        {
            QName = qName;
            FieldName = qName.Name;
            _services = services;
        }

        /// <summary>
        /// Gets the <see cref="QName" />.
        /// </summary>
        public QName QName { get; }

        /// <summary>
        /// Gets or sets the field name, e.g., "document".
        /// </summary>
        public string FieldName { get; set; }

        /// <summary>
        /// Gets the qualified field name, e.g., "W.document".
        /// </summary>
        public string QualifiedFieldName =>
            Prefix != string.Empty
                ? Prefix.ToUpperInvariant() + "." + FieldName
                : EmptyNamespace + "." + FieldName;

        /// <summary>
        /// Gets the XML prefix, e.g., "w".
        /// </summary>
        public string Prefix => QName.Prefix;

        /// <summary>
        /// Gets the XML namespace name, e.g., "http://schemas.openxmlformats.org/wordprocessingml/2006/main".
        /// </summary>
        public string NamespaceName => _services.GetNamespaceInfo(QName.Prefix).Uri;

        /// <summary>
        ///  Gets the XML local name, e.g., "document".
        /// </summary>
        public string LocalName => QName.Name;

        /// <summary>
        /// Gets the XML qualified name, e.g., "w:document".
        /// </summary>
        public string QualifiedName => string.IsNullOrEmpty(Prefix) ? LocalName : Prefix + ":" + LocalName;

        private IEnumerable<SchemaType> GetHierarchy()
        {
            foreach (var e in _elementMetadata)
            {
                var current = e;

                while (current is not null)
                {
                    yield return current;
                    current = _services.GetTypeFromClassName(current.Name.Type.Prefix, current.BaseClass);
                }
            }
        }

        public IEnumerable<QName> ParentQualifiedNames =>
            _parentMetadata
                .OrderBy(GetQualifiedName)
                .Select(em => em.Name.QName)
                .Distinct();

        public IEnumerable<QName> ChildQualifiedNames =>
            _childMetadata
                .OrderBy(GetQualifiedName)
                .Select(em => em.Name.QName)
                .Distinct();

        public IEnumerable<QName> AttributeContainerQualifiedNames =>
            _attributeContainerMetadata
                .OrderBy(GetQualifiedName)
                .Select(em => em.Name.QName)
                .Distinct();

        public IEnumerable<QName> ElementAttributeQualifiedNames =>
            GetHierarchy()
                .SelectMany(em => em.Attributes)
                .OrderBy(GetQualifiedName)
                .Select(am => am.QName)
                .Distinct();

        public IEnumerable<string> ElementClassNames =>
           _elementMetadata
                .Select(e => _services.FindClassName(e.Name, fullyQualified: false))
                .Distinct()
                .OrderBy(name => name);

        public IEnumerable<string> AttributePropertyNames => _attributePropertyNames;

        private static string GetQualifiedName(SchemaType metadata)
        {
            return GetQualifiedName(metadata.Name.QName);
        }

        private static string GetQualifiedName(SchemaAttribute metadata)
        {
            return GetQualifiedName(metadata.QName);
        }

        private static string GetQualifiedName(QName qName)
            => qName.ToString();

        public void AddElementMetadata(SchemaType element)
        {
            _elementMetadata.Add(element);
        }

        public void AddParentElementMetadata(SchemaType? parent)
        {
            if (parent is not null)
            {
                _parentMetadata.Add(parent);
            }
        }

        public void AddChildElementMetadata(SchemaType child)
        {
            _childMetadata.Add(child);
        }

        public void AddAttributeMetadata(SchemaType element, SchemaAttribute attribute)
        {
            _attributeContainerMetadata.Add(element);
            _attributeMetadata.Add(attribute);

            var className = _services.FindClassName(element.Name, fullyQualified: false);
            _attributePropertyNames.Add(className + "." + attribute.PropertyName);
        }

        /// <inheritdoc />
        public int CompareTo(FieldInfo? other)
        {
            return other is null ? 1 : QName.CompareTo(other.QName);
        }

        /// <inheritdoc />
        public bool Equals(FieldInfo? other)
            => other is not null && QName.Equals(other.QName);

        /// <inheritdoc />
        public override bool Equals(object? obj)
        {
            if (obj is null)
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            return obj.GetType() == GetType() && Equals((FieldInfo)obj);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            return QName.GetHashCode();
        }

        public static bool operator ==(FieldInfo? left, FieldInfo? right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(FieldInfo? left, FieldInfo? right)
        {
            return !Equals(left, right);
        }
    }
}
