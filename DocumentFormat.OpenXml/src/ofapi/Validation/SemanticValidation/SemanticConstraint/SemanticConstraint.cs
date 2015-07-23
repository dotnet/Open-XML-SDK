// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DocumentFormat.OpenXml.Validation;
using DocumentFormat.OpenXml.Packaging;
using System.Diagnostics;
using System.Xml;
using System.Globalization;

namespace DocumentFormat.OpenXml.Internal.SemanticValidation
{
    /// <summary>
    /// OpenXML API will implement a class for each semantic constraint category.
    /// "SemanticConstraint" is base class of all these classes.
    /// A semanticConstraint object will be used to validate a correspoding doc element to see if it meets the constraint or not.
    /// </summary>
    internal abstract partial class SemanticConstraint
    {

        public readonly SemanticValidationLevel SemanticValidationLevel;

#if DEBUG
        private string _constraintId;
#endif

        internal string ConstratintId
        {
            get
            {
                string result = string.Empty;
#if DEBUG
                result = _constraintId;
#endif
                return result;
            }
            set
            {
#if DEBUG
                _constraintId = value;
#endif
            }
        }

        public virtual SemanticValidationLevel StateScope
        {
            get { return SemanticValidationLevel; }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public SemanticConstraint(SemanticValidationLevel level)
        {
            SemanticValidationLevel = level;
        }

        /// <summary>
        /// Some semantic constraint classes will hold state at runtime,
        /// and this method is to remove the state
        /// </summary>
        public virtual void ClearState(ValidationContext context)
        {
            return;
        }

        /// <summary>
        /// Semantic validation logic
        /// </summary>
        /// <param name="context">return null if validation succeed</param>
        /// <returns></returns>
        abstract public ValidationErrorInfo Validate(ValidationContext context);

        protected static OpenXmlPart GetReferencedPart(ValidationContext context, string path)
        {
            if (path == ".")
            {
                return context.Part;
            }

            string[] parts = path.Split('/');

            if (string.IsNullOrEmpty(parts[0]))
            {
                return GetPartThroughPartPath(context.Package.Parts, parts.Skip(1).ToArray()); //absolute path
            }
            else if (parts[0] == "..")
            {
                IEnumerable<OpenXmlPart> iterator = new OpenXmlPackagePartIterator(context.Package);

                IEnumerable<OpenXmlPart> refParts = iterator.Where(p => p.Parts.Select(r => r.OpenXmlPart.PackagePart.Uri)
                                                            .Contains(context.Part.PackagePart.Uri));

                Debug.Assert(refParts.Count() == 1);

                return refParts.First();
            }
            else
            {
                return GetPartThroughPartPath(context.Part.Parts, parts); //relative path
            }
        }

        protected static XmlQualifiedName GetAttributeQualifiedName(OpenXmlElement element, byte attributeID)
        {
            return new XmlQualifiedName(element.AttributeTagNames[attributeID], NamespaceIdMap.GetNamespaceUri(element.AttributeNamespaceIds[attributeID]));
        }

        private static bool CompareBooleanValue(bool value1, string value2)
        {
            bool parsedValue;
            if (bool.TryParse(value2, out parsedValue))
            {
                return value1 == parsedValue;
            }
            else
            {
                return false;
            }
        }

        protected static bool AttributeValueEquals(OpenXmlSimpleType type, string value, bool ignoreCase)
        {
            HexBinaryValue hexValue = type as HexBinaryValue;
            if (hexValue != null)
            {
                if (!hexValue.HasValue)
                {
                    return true;
                }

                return Convert.ToInt64(hexValue.Value, 16) == Convert.ToInt64(value, 16);
            }

            BooleanValue boolValue = type as BooleanValue;
            if (boolValue != null)
            {
                if (!boolValue.HasValue)
                {
                    return false;
                }

                if (CompareBooleanValue(boolValue.Value, value))
                {
                    return true;
                }
            }

            OnOffValue onOffValue = type as OnOffValue;
            if(onOffValue != null)
            {
                if (!onOffValue.HasValue)
                {
                    return false;
                }

                if (CompareBooleanValue(onOffValue.Value, value))
                {
                    return true;
                }
            }

            TrueFalseValue trueFalseValue = type as TrueFalseValue;
            if(trueFalseValue != null)
            {
                if (!trueFalseValue.HasValue)
                {
                    return false;
                }

                if (CompareBooleanValue(trueFalseValue.Value, value))
                {
                    return true;
                }
            }

            TrueFalseBlankValue trueFalseBlankValue = type as TrueFalseBlankValue;
            if (trueFalseBlankValue != null)
            {
                if (!trueFalseBlankValue.HasValue)
                {
                    return false;
                }

                if (CompareBooleanValue(trueFalseBlankValue.Value, value))
                {
                    return true;
                }
            }

            if (ignoreCase)
            {
                return string.Equals(value, type.InnerText, StringComparison.OrdinalIgnoreCase);
            }
            else
            {
                return string.Equals(value, type.InnerText, StringComparison.Ordinal);
            }
        }

        protected static bool GetAttrNumVal(OpenXmlSimpleType attributeValue, out double value)
        {
            HexBinaryValue hexBinaryValue = attributeValue as HexBinaryValue;
            if (hexBinaryValue != null)
            {
                long val;
                bool result = long.TryParse(hexBinaryValue.Value, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out val);
                value = val;
                return result;
            }

            return double.TryParse(attributeValue.InnerText, NumberStyles.AllowDecimalPoint,
                CultureInfo.InvariantCulture, out value);
        }

        private static OpenXmlPart GetPartThroughPartPath(IEnumerable<IdPartPair> pairs, string[] path)
        {
            OpenXmlPart temp = null;
            IEnumerable<IdPartPair> parts = pairs;

            for (int i = 0; i < path.Length; i++)
            {
                IEnumerable<OpenXmlPart> s = parts.Where(p => p.OpenXmlPart.GetType().Name == path[i]).Select(t => t.OpenXmlPart);
                if (s.Count() > 1)
                    throw new System.IO.FileFormatException("Invalid document error: more than one part retrieved for one URI.");
                if (s.Count() == 0)
                {
                    return null;
                }
                temp = s.First();
                parts = temp.Parts;
            }

            return temp;
        }

    }
}
