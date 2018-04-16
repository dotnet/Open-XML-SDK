// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Runtime.Serialization;

namespace DocumentFormat.OpenXml.Validation.Schema.Restrictions
{
    /// <summary>
    /// Class for attributes that have different simple type in Office2007 and Office2010.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [DataContract(Name = "red")]
    internal class RedirectedRestriction : SimpleTypeRestriction
    {
        [DataMember(Name = "tr")]
        public SimpleTypeRestriction TargetRestriction { get; set; }

        /// <summary>
        /// Gets or sets an ID for this type.
        /// </summary>
        [DataMember(Name = "aid")]
        public int AttributeId { get; set; }

        /// <inheritdoc />
        public override XsdType XsdType => XsdType.Redirected;

        /// <inheritdoc />
        public override string ClrTypeName => TargetRestriction.ClrTypeName;

        public OpenXmlSimpleType ConvertValue(OpenXmlSimpleType value)
        {
            var targetValue = UnionHelper.CreateTargetValueObject(this, FileFormat);

            targetValue.InnerText = value.InnerText;

            return targetValue;
        }

        ///// <summary>
        ///// Validating the specified value is valid according the XsdType.
        ///// </summary>
        ///// <param name="attributeValue"></param>
        ///// <returns>False if the specified value is not valid.</returns>
        //public override bool ValidateValueType(OpenXmlSimpleType attributeValue)
        //{
        //    var targetValue = UnionHelper.CreateTargetValueObject(this, this.FileFormat);

        //    targetValue.InnerText = attributeValue.InnerText;

        //    return TargetRestriction.ValidateValueType(targetValue);
        //}

        ///// <summary>
        ///// Validate the value to all the constraints.
        ///// </summary>
        ///// <param name="attributeValue">The value to be validated.</param>
        ///// <returns>An bit flag, a bit is set on if the corresponding constraint is failed.</returns>
        //public override RestrictionField Validate(OpenXmlSimpleType attributeValue)
        //{
        //    var targetValue = UnionHelper.CreateTargetValueObject(this, this.FileFormat);
        //    return TargetRestriction.Validate(targetValue);
        //}
    }
}
