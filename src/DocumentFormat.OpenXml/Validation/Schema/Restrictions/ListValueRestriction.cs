// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;
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
            if (attributeValue.HasValue && attributeValue is IEnumerable<OpenXmlSimpleType> value)
            {
                foreach (var itemValue in value)
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
    }
}
