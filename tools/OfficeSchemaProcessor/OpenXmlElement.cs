// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Schema;

namespace OfficeSchemaProcessor
{
    internal class OpenXmlElement
    {
        private static readonly Dictionary<string, string> EmptyDictionary = new Dictionary<string, string>();

        private readonly XmlSchemaElement _element;
        private readonly string _apiName;

        public OpenXmlElement(XmlSchemaElement element)
        {
            if (element.ElementSchemaType is XmlSchemaComplexType complexType)
            {
                Type = new OpenXmlType(complexType);
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(element));
            }

            var unhandled = element.UnhandledAttributes
                ?.ToDictionary(t => t.Name, t => t.Value, StringComparer.Ordinal) ?? EmptyDictionary;

            if (unhandled.TryGetValue("ofapi:apiName", out var apiName))
            {
                _apiName = apiName;
            }

            _element = element;
        }

        public bool MinOccursIsNonZero => _element.MinOccurs != 0;

        public bool MaxOccursGreatThanOne => _element.MaxOccurs > 1;

        public bool GenerateAddMethod => _apiName != null;

        public string ApiName
        {
            get
            {
                var name = _apiName ?? Type.Name;

                if (MaxOccursGreatThanOne && !name.EndsWith('s'))
                {
                    name = name + 's';
                }

                if (_fixupNames.TryGetValue(name, out var result))
                {
                    return result;
                }
                else
                {
                    return name;
                }
            }
        }

        private static readonly Dictionary<string, string> _fixupNames = new Dictionary<string, string>(StringComparer.Ordinal)
        {
            { "XmlSignatueParts", "XmlSignatureParts" },
            { "DiagramLayoutParts", "DiagramPersistLayoutParts" },
            { "PrinterSettingsParts", "WordprocessingPrinterSettingsParts" },
            { "CustomXmlPropertiesParts", "CustomXmlPropertiesPart" }
        };

        public OpenXmlType Type { get; }
    }
}
