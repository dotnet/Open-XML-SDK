// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DocumentFormat.OpenXml.Generator.Linq
{
    /// <summary>
    /// TypeScript code generator for the namespace-related Linq-to-Xml classes.
    /// </summary>
    public static class TypeScriptGenerator
    {
        private const string EmptyNamespace = "NoNamespace";

        private static readonly HashSet<string> Prefixes = new(new[]
        {
            "a", "a14", "a15", "a16", "ds", "m", "o", "p", "p14", "p15", "r", "sl", "v",
            "w", "w10", "w14", "w15", "wp", "wpc", "wpg", "wps", "x", "x14", "x15", "xml",
        });

        /// <summary>
        /// Generates the namespace-related classes for the Linq-to-XML feature, taking
        /// one parameter that specifies the absolute path to the folder into which the
        /// generated code is written.
        /// </summary>
        /// <param name="directoryName">The directory name.</param>
        public static int Generate(string directoryName)
        {
            directoryName = Path.GetFullPath(directoryName);

            Console.WriteLine($@"Generating TypeScript code in '{directoryName}' ...");

            var fieldInfos = new Dictionary<OpenXmlQualifiedName, FieldInfo>();
            IEnumerable<ElementMetadata> elementMetadataCollection = AssembleElementMetadata(fieldInfos);
            AssembleAttributeMetadata(elementMetadataCollection, fieldInfos);

            IEnumerable<IGrouping<string, FieldInfo>> fieldInfoGroupings = fieldInfos.Values
                .GroupBy(fi => fi.Prefix)
                .OrderBy(g => g.Key)
                .ToList();

            // Assign and register unique and valid field names.
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
                    if (!IsValidIdentifier(fieldName))
                    {
                        fieldName += "_";
                    }

                    info.FieldName = fieldName;
                }
            }

            // Generate classes.
            Directory.CreateDirectory(directoryName);
            var sb = new StringBuilder();

            foreach (IGrouping<string, FieldInfo> fieldInfoGrouping in fieldInfoGroupings)
            {
                string prefix = fieldInfoGrouping.Key;
                if (!string.IsNullOrEmpty(prefix) && !Prefixes.Contains(prefix))
                {
                    continue;
                }

                string namespaceName = fieldInfoGrouping.First().NamespaceName;
                IEnumerable<FieldInfo> classFieldInfos = fieldInfoGrouping.OrderBy(fi => fi.LocalName);

                string className = GetClassName(prefix);
                string fileName = className + ".ts";
                string path = Path.GetFullPath(Path.Combine(directoryName, fileName));

                Console.WriteLine($@"Generating class {className} ...");

                using var stream = new FileStream(path, FileMode.Create);
                using var output = new StreamWriter(stream);

                GenerateClassFilePreamble(output, namespaceName);
                GenerateClass(output, prefix, namespaceName, classFieldInfos, fieldInfos);

                sb.AppendLine($"export {{ {className} }} from './{className}.js';");
            }

            string indexPath = Path.GetFullPath(Path.Combine(directoryName, "index.ts"));
            File.WriteAllText(indexPath, sb.ToString());

            return 0;
        }

        private static bool IsValidIdentifier(string name)
        {
            return name switch
            {
                "name" => false,
                "length" => false,
                _ => true,
            };
        }

        private static string GetClassName(string prefix)
        {
            return string.IsNullOrEmpty(prefix) ? EmptyNamespace : prefix.ToUpperInvariant();
        }

        private static void GenerateClassFilePreamble(TextWriter output, string namespaceName)
        {
            output.WriteLine("/**");
            output.WriteLine(" * @author Thomas Barnekow");
            output.WriteLine(" * @license MIT");
            output.WriteLine(" */");
            output.WriteLine();

            output.WriteLine(string.IsNullOrEmpty(namespaceName)
                ? "import { XName, XNamespace } from '@openxmldev/linq-to-xml';"
                : "import { XAttribute, XName, XNamespace } from '@openxmldev/linq-to-xml';");

            output.WriteLine();
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
                ? string.IsNullOrEmpty(namespaceName) ? "empty" : $"`xmlns=\"{namespaceName}\"`"
                : $"`xmlns:{prefix}=\"{namespaceName}\"`";

            // Determine what we are declaring in the namespace-related class:
            // - "XNamespace and XName fields" or
            // - "XName fields".
            string theSubjectMatter = xmlnsAttribute != "empty" ? "XNamespace and XName fields" : "XName fields";

            // Derive the class name from the prefix. If the prefix is empty, use
            // "NoNamespace" for compatibility with the Open XML PowerTools.
            string className = GetClassName(prefix);

            // Emit the class comment.
            output.WriteLine(@"/**");
            output.WriteLine($" * Declares {theSubjectMatter} for the {xmlnsAttribute} namespace.");
            output.WriteLine(@" */");

            // Begin the class declaration.
            output.WriteLine($"export class {className} {{");
            output.WriteLine(@"  /** @internal */");
            output.WriteLine(@"  private constructor() {");
            output.WriteLine(@"    // Ignore");
            output.WriteLine(@"  }");

            // Emit the XNamespace field and determine the RHS prefix of the field declaration.
            string fieldRhsPrefix;

            if (!string.IsNullOrEmpty(namespaceName))
            {
                output.WriteLine();
                output.WriteLine(@"  /**");
                output.WriteLine($"   * Defines the XML namespace associated with the `{prefix}` prefix.");
                output.WriteLine(@"   */");

                if (!string.IsNullOrEmpty(prefix))
                {
                    output.WriteLine($"  public static readonly {prefix}: XNamespace = XNamespace.get(");
                    fieldRhsPrefix = $"{className}.{prefix}";
                }
                else
                {
                    output.WriteLine(@"  public static readonly namespace: XNamespace = XNamespace.get(");
                    fieldRhsPrefix = $"{className}.namespace";
                }

                output.WriteLine($"    '{namespaceName}'");
                output.WriteLine(@"  );");
                output.WriteLine();

                output.WriteLine(@"  /**");
                output.WriteLine(@"   * Returns the namespace declaration `XAttribute` for this namespace.");
                output.WriteLine(@"   */");

                if (!string.IsNullOrEmpty(prefix))
                {
                    output.WriteLine(@"  public static get namespaceDeclaration(): XAttribute {");
                    output.WriteLine($"    return new XAttribute(XNamespace.xmlns.getName('{prefix}'), {fieldRhsPrefix}.namespaceName);");
                    output.WriteLine(@"  }");
                }
                else
                {
                    output.WriteLine(@"  public static get namespaceDeclaration(): XAttribute {");
                    output.WriteLine($"    return new XAttribute(XNamespace.none.getName('xmlns'), {fieldRhsPrefix}.namespaceName);");
                    output.WriteLine(@"  }");
                }
            }
            else
            {
                fieldRhsPrefix = "XNamespace.none";
            }

            foreach (FieldInfo info in classFieldInfos)
            {
                string qualifiedName = string.IsNullOrEmpty(info.Prefix) ? info.LocalName : info.Prefix + ":" + info.LocalName;

                List<OpenXmlQualifiedName> parentQualifiedNames = info.ParentQualifiedNames
                    .Where(n => Prefixes.Contains(GetPrefix(n.Namespace)))
                    .ToList();

                List<OpenXmlQualifiedName> childQualifiedNames = info.ChildQualifiedNames
                    .Where(n => Prefixes.Contains(GetPrefix(n.Namespace)))
                    .ToList();

                List<OpenXmlQualifiedName> elementAttributeQualifiedNames = info.ElementAttributeQualifiedNames
                    .Where(n => Prefixes.Contains(GetPrefix(n.Namespace)))
                    .ToList();

                List<OpenXmlQualifiedName> attributeContainerQualifiedNames = info.AttributeContainerQualifiedNames
                    .Where(n => Prefixes.Contains(GetPrefix(n.Namespace)))
                    .ToList();

                List<string> elementClassNames = info.ElementClassNames.ToList();
                string elements = elementClassNames.Count switch
                {
                    0 => string.Empty,
                    1 => "element",
                    _ => "elements",
                };

                string attributes = attributeContainerQualifiedNames.Count switch
                {
                    0 => string.Empty,
                    1 => "attribute",
                    _ => "attributes",
                };

                string elementsAndOrAttributes = elements != string.Empty && attributes != string.Empty
                    ? elements + " and " + attributes
                    : elements == string.Empty && attributes == string.Empty
                        ? "name"
                        : elements + attributes;

                output.WriteLine(string.Empty);
                output.WriteLine(@"  /**");
                output.WriteLine($"   * Represents the `{qualifiedName}` XML {elementsAndOrAttributes}.");

                string See(OpenXmlQualifiedName qName)
                {
                    FieldInfo fieldInfo = fieldInfos[qName];
                    string reference = fieldInfo.Prefix == prefix
                        ? fieldInfo.FieldName
                        : fieldInfo.QualifiedFieldName;
                    string displayName = string.IsNullOrEmpty(prefix)
                        ? fieldInfo.FieldName
                        : $"{fieldInfo.Prefix}:{fieldInfo.FieldName}";

                    return $"{{@linkcode {reference} {displayName}}}";
                }

                bool hasRemarks = elements != string.Empty || attributes != string.Empty;
                if (hasRemarks)
                {
                    output.WriteLine(@"   *");
                    output.WriteLine(@"   * @remarks");
                }

                if (elements != string.Empty)
                {
                    output.WriteLine(@"   * As an XML element, it has the following:");

                    if (parentQualifiedNames.Any())
                    {
                        string csv = string.Join(", ", parentQualifiedNames.Select(See));
                        output.WriteLine($"   * - parent XML elements: {csv}");
                    }

                    if (childQualifiedNames.Any())
                    {
                        string csv = string.Join(", ", childQualifiedNames.Select(See));
                        output.WriteLine($"   * - child XML elements: {csv}");
                    }

                    if (elementAttributeQualifiedNames.Any())
                    {
                        string csv = string.Join(", ", elementAttributeQualifiedNames.Select(See));
                        output.WriteLine($"   * - XML attributes: {csv}");
                    }
                }

                if (attributes != string.Empty)
                {
                    if (elements != string.Empty)
                    {
                        output.WriteLine(@"   *");
                    }

                    if (attributeContainerQualifiedNames.Any())
                    {
                        string csv = string.Join(", ", attributeContainerQualifiedNames.Select(See));
                        output.WriteLine($"   * As an XML attribute, it is contained in the following XML elements: {csv}");
                    }
                }

                output.WriteLine(@"   */");

                // Option 1: Emit field declarations.
                // In a benchmark, this option proved to be more performant than Option 2 below.
                output.WriteLine($"  public static readonly {info.FieldName}: XName = {fieldRhsPrefix}.getName('{info.LocalName}');");

                // Option 2: Emit getters.
                // string name = info.FieldName;
                // output.WriteLine($"  public static get {info.FieldName}(): XName {{");
                // output.WriteLine($"    return this._{name} ? this._{name} : (this._{name} = {fieldRhsPrefix}.getName('{info.LocalName}'));");
                // output.WriteLine(@"  }");
                // output.WriteLine($"  private static _{name}?: XName;");
            }

            // End class declaration.
            output.WriteLine(@"}");
        }

        private static string GetPrefix(OpenXmlNamespace ns)
        {
            return TypedFeatures.Shared.GetNamespaceResolver().LookupPrefix(ns.Uri) ?? string.Empty;
        }

        private static IEnumerable<ElementMetadata> AssembleElementMetadata(
            IDictionary<OpenXmlQualifiedName, FieldInfo> fieldInfos)
        {
            var visitedElementTypes = new HashSet<Type>();
            var elementMetadataCollection = new List<ElementMetadata>();
            var elementFactory = new TypedFeatures().GetRequired<IRootElementFactory>();

            foreach (var elementChild in elementFactory.Collection.Elements)
            {
                AssembleElementMetatata(ElementMetadata.None, elementChild, visitedElementTypes, elementMetadataCollection, fieldInfos);
            }

            return elementMetadataCollection;
        }

        private static ElementMetadata AssembleElementMetatata(
            ElementMetadata parentMetadata,
            ElementFactory elementChild,
            HashSet<Type> visitedTypes,
            ICollection<ElementMetadata> elementMetadataCollection,
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
            IEnumerable<ElementMetadata> elementMetadataCollection,
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
            private readonly HashSet<ElementMetadata> _elementMetadata = new();
            private readonly HashSet<ElementMetadata> _parentMetadata = new();
            private readonly HashSet<ElementMetadata> _childMetadata = new();
            private readonly HashSet<ElementMetadata> _attributeContainerMetadata = new();

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

            private static string GetQualifiedName(ElementMetadata metadata)
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

            public void AddElementMetadata(ElementMetadata element)
            {
                _elementMetadata.Add(element);
            }

            public void AddParentElementMetadata(ElementMetadata parent)
            {
                if (parent != ElementMetadata.None)
                {
                    _parentMetadata.Add(parent);
                }
            }

            public void AddChildElementMetadata(ElementMetadata child)
            {
                _childMetadata.Add(child);
            }

            public void AddAttributeMetadata(ElementMetadata element, AttributeMetadata attribute)
            {
                _attributeContainerMetadata.Add(element);
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
