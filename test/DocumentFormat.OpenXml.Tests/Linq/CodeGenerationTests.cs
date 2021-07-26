// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Xunit;
using Xunit.Abstractions;

// ReSharper disable FormatStringProblem
namespace DocumentFormat.OpenXml.Tests.Linq
{
    public class CodeGenerationTests
    {
        private const string EmptyNamespace = "NoNamespace";

        public CodeGenerationTests(ITestOutputHelper output)
        {
            Output = output;
        }

        private ITestOutputHelper Output { get; }

        [Fact]
        public void CanGenerateCode()
        {
            DirectoryInfo directoryInfo = Directory.CreateDirectory("Linq\\GeneratedCode");
            Output.WriteLine($"Generating code in {directoryInfo.FullName} ...");

            GenerateCode(directoryInfo.FullName, true);

            Output.WriteLine("Done.");
        }

        private static void GenerateCode(string folderPath, bool emitFieldComments)
        {
            Dictionary<OpenXmlQualifiedName, FieldInfo> fieldInfos = new();
            IReadOnlyCollection<ElementMetadata> elementMetadataCollection = AssembleElementMetadata(fieldInfos);
            AssembleAttributeMetadata(elementMetadataCollection, fieldInfos);

            IEnumerable<IGrouping<string, FieldInfo>> fieldInfoGroupings = fieldInfos.Values
                .GroupBy(fi => fi.Prefix)
                .OrderBy(g => g.Key);

            using var provider = CodeDomProvider.CreateProvider("C#");

            foreach (IGrouping<string, FieldInfo> fieldInfoGrouping in fieldInfoGroupings)
            {
                string prefix = fieldInfoGrouping.Key;
                string namespaceName = fieldInfoGrouping.First().NamespaceName;
                IOrderedEnumerable<FieldInfo> fieldInfoCollection = fieldInfoGrouping.OrderBy(fi => fi.LocalName);

                string className = GetClassName(prefix);
                string fileName = className + ".g.cs";
                using var stream = new FileStream($"{folderPath}\\{fileName}", FileMode.Create);
                using var output = new StreamWriter(stream);

                GenerateClassFilePreamble(emitFieldComments, output);
                GenerateClass(prefix, namespaceName, fieldInfoCollection, provider, emitFieldComments, output);
                GenerateClassFilePostamble(emitFieldComments, output);
            }
        }

        private static string GetClassName(string prefix)
        {
            return string.IsNullOrEmpty(prefix) ? EmptyNamespace : prefix.ToUpperInvariant();
        }

        private static void GenerateClassFilePreamble(bool emitFieldComments, TextWriter output)
        {
            output.WriteLine("// Copyright (c) Microsoft. All rights reserved.");
            output.WriteLine("// Licensed under the MIT license. See LICENSE file in the project root for full license information.");
            output.WriteLine();

            output.WriteLine("using System.Xml.Linq;");
            output.WriteLine();

            if (!emitFieldComments)
            {
                output.WriteLine("#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member");
                output.WriteLine();
            }

            // Begin namespace.
            output.WriteLine("namespace DocumentFormat.OpenXml.Linq");
            output.WriteLine("{");
        }

        private static void GenerateClassFilePostamble(bool emitFieldComments, TextWriter output)
        {
            // End namespace.
            output.WriteLine("}");

            if (!emitFieldComments)
            {
                output.WriteLine();
                output.WriteLine("#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member");
            }
        }

        private static void GenerateClass(
            string prefix,
            string namespaceName,
            IEnumerable<FieldInfo> fieldInfos,
            CodeDomProvider provider,
            bool emitFieldComments,
            TextWriter output)
        {
            HashSet<string> fieldNames = new();

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

            foreach (FieldInfo info in fieldInfos)
            {
                // Emit field comments, if desired.
                if (emitFieldComments)
                {
                    string qualifiedName = string.IsNullOrEmpty(info.Prefix) ? info.LocalName : info.Prefix + ":" + info.LocalName;

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

                    //output.WriteLine(@"        /// <remarks>");

                    // TODO: Consider providing information on strongly-typed classes.
                    //foreach (string elementTypeName in info.ElementClassNames)
                    //{
                    //    output.WriteLine($"        /// - Strongly-typed Class: {elementTypeName}");
                    //}

                    // TODO: Consider providing information on strongly-typed properties.
                    //foreach (string attributePropertyName in info.AttributePropertyNames)
                    //{
                    //    output.WriteLine($"        /// - Strongly-typed Property: {attributePropertyName}");
                    //}

                    // TODO: Consider providing information on parent elements.
                    //foreach (string parentQualifiedName in info.ParentQualifiedNames)
                    //{
                    //    output.WriteLine($"        /// - Parent Element: {parentQualifiedName}");
                    //}

                    // TODO: Consider providing information on child elements.
                    //foreach (string qualifiedName in info.ChildQualifiedNames)
                    //{
                    //    output.WriteLine($"        /// - Child Element: {qualifiedName}");
                    //}

                    //output.WriteLine(@"        /// </remarks>");
                }

                // Some names contain dashes, which we need to replace.
                string fieldName = info.LocalName.Replace('-', '_');

                // Ensure the field name is not equal to the prefix, which we use for the XNamespace field.
                fieldName = fieldName != prefix ? fieldName : fieldName + "_";

                // Ensure CLS-compliance by making field names unique.
                while (!fieldNames.Add(fieldName.ToLowerInvariant()))
                {
                    fieldName += "_";
                }

                // Finally, ensure the field name is a valid identifier.
                if (!provider.IsValidIdentifier(fieldName))
                {
                    fieldName = '@' + fieldName;
                }

                // Emit field declaration.
                output.WriteLine($"        public static readonly XName {fieldName} = {fieldRhsPrefix}\"{info.LocalName}\";");
            }

            // End class declaration.
            output.WriteLine(@"    }");
        }

        private static IReadOnlyCollection<ElementMetadata> AssembleElementMetadata(
            IDictionary<OpenXmlQualifiedName, FieldInfo> fieldInfos)
        {
            var visitedElementTypes = new HashSet<Type>();
            var elementMetadataCollection = new List<ElementMetadata>();

            foreach (ElementLookup.ElementChild elementChild in ElementLookup.Parts.Elements)
            {
                AssembleElementMetatata(ElementMetadata.None, elementChild, visitedElementTypes, elementMetadataCollection, fieldInfos);
            }

            return elementMetadataCollection;
        }

        private static ElementMetadata AssembleElementMetatata(
            ElementMetadata parentMetadata,
            ElementLookup.ElementChild elementChild,
            ISet<Type> visitedTypes,
            ICollection<ElementMetadata> elementMetadataCollection,
            IDictionary<OpenXmlQualifiedName, FieldInfo> fieldInfos)
        {
            OpenXmlElement element = elementChild.Create();
            var elementMetadata = ElementMetadata.Create(element);
            elementMetadataCollection.Add(elementMetadata);

            if (!fieldInfos.TryGetValue(elementMetadata.QName, out FieldInfo fieldInfo))
            {
                fieldInfo = new FieldInfo(elementMetadata.QName);
                fieldInfos[elementMetadata.QName] = fieldInfo;
            }

            fieldInfo.AddParentElementMetadata(parentMetadata);
            fieldInfo.AddElementMetadata(elementMetadata);

            if (visitedTypes.Add(element.GetType()))
            {
                foreach (ElementLookup.ElementChild child in elementMetadata.Children.Elements)
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
                if (!fieldInfos.TryGetValue(attributeMetadata.QName, out FieldInfo fieldInfo))
                {
                    fieldInfo = new FieldInfo(attributeMetadata.QName);
                    fieldInfos[attributeMetadata.QName] = fieldInfo;
                }

                fieldInfo.AddAttributeMetadata(elementMetadata, attributeMetadata);
            }
        }

        [Flags]
        public enum FieldType
        {
            Unknown = 0x00,
            Element = 0x01,
            Attribute = 0x02,
        }

        internal class FieldInfo : IComparable<FieldInfo>, IEquatable<FieldInfo>
        {
            private readonly HashSet<ElementMetadata> _elementMetadata = new();
            private readonly HashSet<ElementMetadata> _parentMetadata = new();
            private readonly HashSet<ElementMetadata> _childMetadata = new();

            private readonly HashSet<AttributeMetadata> _attributeMetadata = new();

            private readonly SortedSet<string> _attributePropertyNames = new();

            public FieldInfo(OpenXmlQualifiedName qName)
            {
                QName = qName;
                FieldType = FieldType.Unknown;
            }

            public FieldType FieldType { get; private set; }

            public OpenXmlQualifiedName QName { get; }

            public string Prefix => QName.Namespace.Prefix;

            public string NamespaceName => QName.Namespace.Uri;

            public string LocalName => QName.Name;

            public string QualifiedName => string.IsNullOrEmpty(Prefix) ? LocalName : Prefix + ":" + LocalName;

            public IReadOnlyCollection<ElementMetadata> ElementMetadataCollection => _elementMetadata;

            public IReadOnlyCollection<ElementMetadata> ParentMetadataCollection => _parentMetadata;

            public IReadOnlyCollection<ElementMetadata> ChildMetadataCollection => _childMetadata;

            public IReadOnlyCollection<AttributeMetadata> AttributeMetadataCollection => _attributeMetadata;

            public IEnumerable<string> ElementClassNames =>
                _elementMetadata
                    .Select(e => e.Type.FullName ?? e.Type.Name)
                    .Distinct()
                    .OrderBy(name => name);

            public IEnumerable<string> AttributePropertyNames => _attributePropertyNames;

            public IEnumerable<string> ParentQualifiedNames =>
                _parentMetadata
                    .Select(GetQualifiedName)
                    .Distinct()
                    .OrderBy(name => name);

            public IEnumerable<string> ChildQualifiedNames =>
                _childMetadata
                    .Select(GetQualifiedName)
                    .Distinct()
                    .OrderBy(name => name);

            private static string GetQualifiedName(ElementMetadata metadata)
            {
                return GetQualifiedName(metadata.QName);
            }

            private static string GetQualifiedName(OpenXmlQualifiedName qName)
            {
                string prefix = qName.Namespace.Prefix;
                return string.IsNullOrEmpty(prefix) ? qName.Name : prefix + ":" + qName.Name;
            }

            public void AddElementMetadata(ElementMetadata element)
            {
                _elementMetadata.Add(element);
                FieldType &= FieldType.Element;
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
                string elementTypeFullName = element.Type.FullName ?? element.Type.Name;
                _attributePropertyNames.Add(elementTypeFullName + "." + attribute.PropertyName);

                _attributeMetadata.Add(attribute);
                FieldType &= FieldType.Attribute;
            }

            /// <inheritdoc />
            public int CompareTo(FieldInfo other)
            {
                return QName.CompareTo(other.QName);
            }

            /// <inheritdoc />
            public bool Equals(FieldInfo other)
            {
                return QName.Equals(other.QName);
            }

            /// <inheritdoc />
            public override bool Equals(object obj)
            {
                if (obj is null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                return obj.GetType() == GetType() && Equals((FieldInfo) obj);
            }

            /// <inheritdoc />
            public override int GetHashCode()
            {
                return QName.GetHashCode();
            }

            public static bool operator ==(FieldInfo left, FieldInfo right)
            {
                return Equals(left, right);
            }

            public static bool operator !=(FieldInfo left, FieldInfo right)
            {
                return !Equals(left, right);
            }
        }

        public class TestOutputTextWriter : TextWriter
        {
            private readonly ITestOutputHelper _output;

            private string _currentLine = string.Empty;

            public TestOutputTextWriter(ITestOutputHelper output)
            {
                _output = output;
            }

            public override Encoding Encoding { get; } = Encoding.UTF8;

            public override void Write(char value)
            {
                if (value == '\n')
                {
                    WriteCurrentLine();
                }
                else if (value != '\r')
                {
                    _currentLine += value;
                }
            }

            private void WriteCurrentLine()
            {
                _output.WriteLine(_currentLine);
                _currentLine = string.Empty;
            }

            protected override void Dispose(bool disposing)
            {
                if (!string.IsNullOrEmpty(_currentLine))
                {
                    WriteCurrentLine();
                }

                base.Dispose(disposing);
            }
        }
    }
}
