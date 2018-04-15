// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Runtime.Serialization;

namespace DocumentFormat.OpenXml.Validation.Schema.Restrictions
{
    /// <summary>
    /// Class for all string enum based simple types.
    /// </summary>
    /// <remarks>
    /// We do not save the enums in the database. Instead we reuse the generated enum class in the generated code.
    /// For attributes, the type of the enum is known through the code generated data.
    /// </remarks>
    [DataContract(Name = "e")]
    internal class EnumValueRestriction : SimpleTypeRestriction
    {
        /// <inheritdoc />
        public override XsdType XsdType => XsdType.Enum;

        /// <inheritdoc />
        public override bool IsEnum => true;

        /// <inheritdoc />
        public override bool ValidateValueType(OpenXmlSimpleType attributeValue)
        {
            if (attributeValue.HasValue)
            {
                // Items in the enum are merged from both Office2007 and Office2010.
                // So, we should report error when the item is not defined in the specified version.
                return attributeValue.IsInVersion(FileFormat);
            }

            return false;
        }
    }
}
