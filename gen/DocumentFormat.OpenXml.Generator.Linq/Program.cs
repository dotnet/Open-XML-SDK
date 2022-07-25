// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DocumentFormat.OpenXml.Generator.Linq
{
    /// <summary>
    /// Code generator for the namespace-related Linq-to-Xml classes.
    /// </summary>
    public static class Program
    {
        private const string EmptyNamespace = "NoNamespace";

        /// <summary>
        /// Generates the namespace-related classes for the Linq-to-XML feature, taking
        /// one optional parameter that specifies the absolute or relative path to the
        /// folder into which the generated code is written.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static int Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Please supply a directory");
                return 1;
            }

            string directoryName = args[0];
            directoryName = Path.GetFullPath(directoryName);

            Console.WriteLine($@"Generating code in '{directoryName}' ...");

            var fieldInfos = new Dictionary<OpenXmlQualifiedName, FieldInfo>();
            var elementMetadataCollection = AssembleElementMetadata(fieldInfos);
            AssembleAttributeMetadata(elementMetadataCollection, fieldInfos);

            IEnumerable<IGrouping<string, FieldInfo>> fieldInfoGroupings = fieldInfos.Values
                .GroupBy(fi => fi.Prefix)
                .OrderBy(g => g.Key)
                .ToList();

            // Assign and register unique and valid field names.
            using var provider = CodeDomProvider.CreateProvider("C#");

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
                    if (!provider.IsValidIdentifier(fieldName))
                    {
                        fieldName = '@' + fieldName;
                    }

                    info.FieldName = fieldName;
                }
            }

            // Generate classes.
            Directory.CreateDirectory(directoryName);

            foreach (IGrouping<string, FieldInfo> fieldInfoGrouping in fieldInfoGroupings)
            {
                string prefix = fieldInfoGrouping.Key;
                string namespaceName = fieldInfoGrouping.First().NamespaceName;
                IEnumerable<FieldInfo> classFieldInfos = fieldInfoGrouping.OrderBy(fi => fi.LocalName);

                string className = GetClassName(prefix);
                string fileName = className + ".g.cs";
                string path = Path.GetFullPath(Path.Combine(directoryName, fileName));

                Console.WriteLine($@"Generating class {className} ...");

                using var stream = new FileStream(path, FileMode.Create);
                using var output = new StreamWriter(stream);

                GenerateClassFilePreamble(output);
                GenerateClass(output, prefix, namespaceName, classFieldInfos, fieldInfos);
                GenerateClassFilePostamble(output);
            }

            return 0;
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
            IDictionary<OpenXmlQualifiedName, FieldInfo> fieldInfos)
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

                List<OpenXmlQualifiedName> parentQualifiedNames = info.ParentQualifiedNames.ToList();
                List<OpenXmlQualifiedName> childQualifiedNames = info.ChildQualifiedNames.ToList();
                List<OpenXmlQualifiedName> elementAttributeQualifiedNames = info.ElementAttributeQualifiedNames.ToList();

                List<OpenXmlQualifiedName> attributeContainerQualifiedNames = info.AttributeContainerQualifiedNames.ToList();

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

                string See(OpenXmlQualifiedName qName)
                {
                    FieldInfo fieldInfo = fieldInfos[qName];
                    string reference = fieldInfo.Prefix == prefix
                        ? fieldInfo.FieldName
                        : fieldInfo.QualifiedFieldName;

                    return $"<see cref=\"{reference}\" />";
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

        private static IEnumerable<IElementMetadata> AssembleElementMetadata(
            IDictionary<OpenXmlQualifiedName, FieldInfo> fieldInfos)
        {
            var visitedElementTypes = new HashSet<Type>();
            var elementMetadataCollection = new List<IElementMetadata>();
            var elementFactory = new TypedFeatures().GetRequired<IRootElementFactory>();

            foreach (var elementChild in elementFactory.Collection.Elements)
            {
                AssembleElementMetatata(ElementMetadata.None, elementChild, visitedElementTypes, elementMetadataCollection, fieldInfos);
            }

            return elementMetadataCollection;
        }

        private static IElementMetadata AssembleElementMetatata(
            IElementMetadata parentMetadata,
            ElementFactory elementChild,
            HashSet<Type> visitedTypes,
            ICollection<IElementMetadata> elementMetadataCollection,
            IDictionary<OpenXmlQualifiedName, FieldInfo> fieldInfos)
        {
            OpenXmlElement element = elementChild.Create();
            var elementMetadata = element.Metadata;
            elementMetadataCollection.Add(elementMetadata);

            if (!fieldInfos.TryGetValue(elementMetadata.QName, out FieldInfo? fieldInfo))
            {
                fieldInfo = new FieldInfo(elementMetadata.QName);
                fieldInfos[elementMetadata.QName] = fieldInfo;
            }

            fieldInfo.AddParentElementMetadata(parentMetadata);
            fieldInfo.AddElementMetadata(elementMetadata);

            if (visitedTypes.Add(element.GetType()))
            {
                foreach (var child in elementMetadata.Children.Elements)
                {
                    fieldInfo.AddChildElementMetadata(
                        AssembleElementMetatata(elementMetadata, child, visitedTypes, elementMetadataCollection, fieldInfos));
                }
            }

            return elementMetadata;
        }

        private static void AssembleAttributeMetadata(
            IEnumerable<IElementMetadata> elementMetadataCollection,
            IDictionary<OpenXmlQualifiedName, FieldInfo> fieldInfos)
        {
            foreach (ElementMetadata elementMetadata in elementMetadataCollection)
            {
                AssembleAttributeMetadata(elementMetadata, fieldInfos);
            }
        }

        private static void AssembleAttributeMetadata(
            ElementMetadata elementMetadata,
            IDictionary<OpenXmlQualifiedName, FieldInfo> fieldInfos)
        {
            foreach (AttributeMetadata attributeMetadata in elementMetadata.Attributes)
            {
                if (!fieldInfos.TryGetValue(attributeMetadata.QName, out FieldInfo? fieldInfo))
                {
                    fieldInfo = new FieldInfo(attributeMetadata.QName);
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
            private readonly HashSet<IElementMetadata> _elementMetadata = new();
            private readonly HashSet<IElementMetadata> _parentMetadata = new();
            private readonly HashSet<IElementMetadata> _childMetadata = new();

            private readonly HashSet<IElementMetadata> _attributeContainerMetadata = new();
            private readonly HashSet<AttributeMetadata> _attributeMetadata = new();

            private readonly SortedSet<string> _attributePropertyNames = new();

            /// <summary>
            /// Initializes a new instance with the given <see cref="OpenXmlQualifiedName" />.
            /// </summary>
            /// <param name="qName">The <see cref="OpenXmlQualifiedName" />.</param>
            public FieldInfo(OpenXmlQualifiedName qName)
            {
                QName = qName;
                FieldName = qName.Name;
            }

            /// <summary>
            /// Gets the <see cref="OpenXmlQualifiedName" />.
            /// </summary>
            public OpenXmlQualifiedName QName { get; }

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
            public string Prefix => TypedFeatures.Shared.GetNamespaceResolver().LookupPrefix(QName.Namespace.Uri) ?? string.Empty;

            /// <summary>
            /// Gets the XML namespace name, e.g., "http://schemas.openxmlformats.org/wordprocessingml/2006/main".
            /// </summary>
            public string NamespaceName => QName.Namespace.Uri;

            /// <summary>
            ///  Gets the XML local name, e.g., "document".
            /// </summary>
            public string LocalName => QName.Name;

            /// <summary>
            /// Gets the XML qualified name, e.g., "w:document".
            /// </summary>
            public string QualifiedName => string.IsNullOrEmpty(Prefix) ? LocalName : Prefix + ":" + LocalName;

            public IEnumerable<OpenXmlQualifiedName> ParentQualifiedNames =>
                _parentMetadata
                    .OrderBy(GetQualifiedName)
                    .Select(em => em.QName)
                    .Distinct();

            public IEnumerable<OpenXmlQualifiedName> ChildQualifiedNames =>
                _childMetadata
                    .OrderBy(GetQualifiedName)
                    .Select(em => em.QName)
                    .Distinct();

            public IEnumerable<OpenXmlQualifiedName> AttributeContainerQualifiedNames =>
                _attributeContainerMetadata
                    .OrderBy(GetQualifiedName)
                    .Select(em => em.QName)
                    .Distinct();

            public IEnumerable<OpenXmlQualifiedName> ElementAttributeQualifiedNames =>
                _elementMetadata
                    .SelectMany(em => em.Attributes)
                    .OrderBy(GetQualifiedName)
                    .Select(am => am.QName)
                    .Distinct();

            public IEnumerable<string> ElementClassNames =>
                _elementMetadata
                    .Select(e => e.Type.Name)
                    .Distinct()
                    .OrderBy(name => name);

            public IEnumerable<string> AttributePropertyNames => _attributePropertyNames;

            private static string GetQualifiedName(IElementMetadata metadata)
            {
                return GetQualifiedName(metadata.QName);
            }

            private static string GetQualifiedName(AttributeMetadata metadata)
            {
                return GetQualifiedName(metadata.QName);
            }

            private static string GetQualifiedName(OpenXmlQualifiedName qName)
            {
                string prefix = TypedFeatures.Shared.GetNamespaceResolver().LookupPrefix(qName.Namespace.Uri) ?? string.Empty;
                return string.IsNullOrEmpty(prefix) ? qName.Name : prefix + ":" + qName.Name;
            }

            public void AddElementMetadata(IElementMetadata element)
            {
                _elementMetadata.Add(element);
            }

            public void AddParentElementMetadata(IElementMetadata parent)
            {
                if (parent != ElementMetadata.None)
                {
                    _parentMetadata.Add(parent);
                }
            }

            public void AddChildElementMetadata(IElementMetadata child)
            {
                _childMetadata.Add(child);
            }

            public void AddAttributeMetadata(ElementMetadata element, AttributeMetadata attribute)
            {
                _attributeContainerMetadata.Add(element);
                _attributeMetadata.Add(attribute);

                _attributePropertyNames.Add(element.Type.Name + "." + attribute.PropertyName);
            }

            /// <inheritdoc />
            public int CompareTo(FieldInfo? other)
            {
                return other is null ? 1 : QName.CompareTo(other.QName);
            }

            /// <inheritdoc />
            public bool Equals(FieldInfo? other)
            {
                return QName.Equals(other?.QName);
            }

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
}
