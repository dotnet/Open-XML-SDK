// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Runtime.Serialization;

namespace DocumentFormat.OpenXml.Validation.Schema.Restrictions
{
    /// <summary>
    /// Class for all list simple types.
    /// </summary>
    [DataContract]
    internal class ListValueRestriction : SimpleTypeRestriction
    {
        /// <inheritdoc />
        public override XsdType XsdType => XsdType.List;

        /// <inheritdoc />
        public override string ClrTypeName => this.ListItemType.ClrTypeName;

        /// <inheritdoc />
        public override bool IsList => true;

        [DataMember]
        public SimpleTypeRestriction ListItemType { get; set; }

        /// <inheritdoc />
        public override bool ValidateValueType(OpenXmlSimpleType attributeValue)
        {
            if (attributeValue.HasValue)
            {
                foreach (var itemValue in attributeValue.GetListItems())
                {
                    if (!this.ListItemType.ValidateValueType(itemValue) ||
                        this.ListItemType.Validate(itemValue) != RestrictionField.None)
                    {
                        return false;
                    }
                }

                return true;
            }
            return false;
        }

        // ************* No length, maxLength, minLength, pattern constraint on list type in current Ecma376.

#if false
        /// <summary>
        /// Gets the maxLength facets.
        /// </summary>
        public int MaxLength
        {
            get;
            set;
        }

        /// <summary>
        /// Gets the minLength facets.
        /// </summary>
        public int MinLength
        {
            get;
            set;
        }

        /// <summary>
        /// Gets the length facets.
        /// </summary>
        public int Length
        {
            get;
            set;
        }

        /// <summary>
        /// Get the lenght of the attribute value according to the xsd type.
        /// </summary>
        /// <param name="attributeValue"></param>
        /// <returns></returns>
        /// <remarks>
        /// A value in a ·value space· is facet-valid with respect to ·length·, determined as follows:
        /// 2 if the {variety} is ·list·, then the length of the value, as measured in list items, ·must· be equal to {value}
        /// </remarks>
        internal int GetValueLength(OpenXmlSimpleType attributeValue)
        {
            Debug.Assert(false);
            return 0;
        }

        /// <summary>
        /// Validate whether the "length" constraint is ok.
        /// </summary>
        /// <param name="attributeValue"></param>
        /// <returns>True if the length of the value is same as defined.</returns>
        /// <remarks>
        /// A value in a ·value space· is facet-valid with respect to ·length·, determined as follows:
        /// 2 if the {variety} is ·list·, then the length of the value, as measured in list items, ·must· be equal to {value}
        /// </remarks>
        public bool IsLengthValid(OpenXmlSimpleType attributeValue)
        {
            Debug.Assert(false);
            return true;
        }

        /// <summary>
        /// Validate whether the "length" constraint is ok.
        /// </summary>
        /// <param name="attributeValue"></param>
        /// <returns>True if the length of the value is same as defined.</returns>
        /// <remarks>
        /// A value in a ·value space· is facet-valid with respect to ·length·, determined as follows:
        /// 2 if the {variety} is ·list·, then the length of the value, as measured in list items, ·must· be equal to {value}
        /// </remarks>
        public bool IsMinLengthValid(OpenXmlSimpleType attributeValue)
        {
            Debug.Assert(false);
            return true;
        }

        /// <summary>
        /// Validate whether the "length" constraint is ok.
        /// </summary>
        /// <param name="attributeValue"></param>
        /// <returns>True if the length of the value is same as defined.</returns>
        /// <remarks>
        /// A value in a ·value space· is facet-valid with respect to ·length·, determined as follows:
        /// 2 if the {variety} is ·list·, then the length of the value, as measured in list items, ·must· be equal to {value}
        /// </remarks>
        public bool IsMaxLengthValid(OpenXmlSimpleType attributeValue)
        {
            Debug.Assert(false);
            return true;
        }
#endif
    }
}
