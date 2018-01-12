// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Schema;

namespace OfficeSchemaProcessor
{
    internal class OpenXmlType
    {
        private readonly Dictionary<string, XmlSchemaAttribute> _attributes;
        private readonly XmlSchemaComplexType _type;
        private readonly string _available;

        public OpenXmlType(XmlSchemaComplexType type)
        {
            var unhandled = type.UnhandledAttributes
                .ToDictionary(t => t.Name, StringComparer.Ordinal);

            _attributes = type.AttributeUses
                .Values
                .OfType<XmlSchemaAttribute>()
                .ToDictionary(a => a.Name, StringComparer.OrdinalIgnoreCase);
            _type = type;

            var @base = unhandled["ofapi:apiBase"];

            Name = unhandled["ofapi:apiType"].Value;
            Base = @base.Value;
            IsDataPartReference = string.Equals("DataPartReferenceRelationship", @base.InnerXml, StringComparison.Ordinal);

            if (unhandled.TryGetValue("ofapi:available", out var available))
            {
                _available = available.Value;
            }
        }

        public string Name { get; }

        public string Base { get; }

        public bool IsDataPartReference { get; }

        public bool HasFixedContent => ContentType != null;

        public string ContentType => GetValue();

        public string RelationshipType => GetValue();

        public string RootElement => GetValue();

        public string RootNamespace => GetValue();

        public string TargetName => GetValue();

        public string TargetPath => GetValue();

        public bool AvailableInAllVersions => string.Equals("Office2007", FileFormatVersion, StringComparison.Ordinal);

        public string FileFormatVersion
        {
            get
            {
                switch (_available)
                {
                    case "o12":
                    case null:
                        return "Office2007";
                    case "o14":
                        return "Office2010";
                    case "o15":
                        return "Office2013";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(_available));
                }
            }
        }

        public IEnumerable<OpenXmlElement> GetSubElements()
        {
            if (_type.ContentTypeParticle is XmlSchemaSequence sequence)
            {
                foreach (var element in sequence.Items.OfType<XmlSchemaElement>())
                {
                    yield return new OpenXmlElement(element);
                }
            }
        }

        public bool IsSpecialEmbeddedPart
        {
            get
            {
                return string.Equals("CT_EmbeddedObjectPart", _type.QualifiedName.Name, StringComparison.Ordinal)
                    || string.Equals("CT_EmbeddedPackagePart", _type.QualifiedName.Name, StringComparison.Ordinal);
            }
        }

        public bool ShouldGenerate
        {
            get
            {
                return !(_type.UnhandledAttributes == null || _type.UnhandledAttributes.GetLength(0) == 0);
            }
        }

        private static string TitleCase(string input)
        {
            return input.Substring(0, 1).ToUpper() + input.Substring(1);
        }

        private static readonly HashSet<string> PublicFields = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            "RelationshipType",
            "ContentType",
        };

        private static readonly HashSet<string> SkippedFields = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            "RootElement",
            "RootNamespace",
        };

        public IEnumerable<(string name, object value, bool @public, bool createConstant)> GetFields()
        {
            foreach (var attribute in _attributes)
            {
                if (SkippedFields.Contains(attribute.Key))
                {
                    continue;
                }

                var value = GetValue(attribute.Key);

                if (value != null)
                {
                    var isPublic = PublicFields.Contains(attribute.Key);

                    yield return (TitleCase(attribute.Key), GetValue(attribute.Key), isPublic, isPublic);
                }
            }

            yield return ("IsContentTypeFixed", HasFixedContent, false, false);
        }

        private string GetValue([CallerMemberName]string name = null)
        {
            if (_attributes.TryGetValue(name, out var value))
            {
                return value.FixedValue;
            }
            else
            {
                return null;
            }
        }
    }
}
