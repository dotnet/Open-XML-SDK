// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Represents the abstract base class for all simple types that are used in attributes.
    /// </summary>
    public abstract class OpenXmlSimpleType : ICloneable
    {
        /// <summary>
        /// Initializes a new instance of the OpenXmlSimpleType class.
        /// </summary>
        protected OpenXmlSimpleType()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlSimpleType class.
        /// </summary>
        /// <param name="source">The source OpenXmlSimpleType.</param>
        protected OpenXmlSimpleType(OpenXmlSimpleType source)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            TextValue = source.TextValue;
        }

        /// <summary>
        /// Gets or sets the internal raw text value.
        /// DO NOT use this property. Only for OpenXmlSimpleType.cs internal use.
        /// </summary>
        protected string TextValue { get; set; }

        /// <summary>
        /// Gets a value indicating whether the underneath text value is a valid value.
        /// </summary>
        public virtual bool HasValue => TextValue != null;

        /// <summary>
        /// Gets or sets the inner XML text.
        /// </summary>
        public virtual string InnerText
        {
            get => TextValue;

            set => TextValue = value;
        }

        /// <summary>
        /// Returns a String that represents the current value.
        /// </summary>
        /// <returns>A String that represents the current value. </returns>
        public override string ToString()
        {
            return InnerText;
        }

        /// <summary>
        /// Creates a duplicate of the current value.
        /// </summary>
        /// <remarks>
        /// This method is a deep copy clone.
        /// </remarks>
        /// <returns>The cloned value.</returns>
        public object Clone() => CloneImpl();

        private protected abstract OpenXmlSimpleType CloneImpl();

        /// <summary>
        /// Implicitly converts a specified attribute value to a String value.
        /// </summary>
        /// <param name="xmlAttribute">The OpenXmlSimpleType instance.</param>
        /// <returns>The converted string value.</returns>
        public static implicit operator string(OpenXmlSimpleType xmlAttribute)
        {
            return xmlAttribute?.InnerText;
        }

        /// <summary>
        /// Test whether the value is allowed in the specified file format version. Only for EnumValue.
        /// </summary>
        /// <param name="fileFormat">The file format version.</param>
        /// <returns>True if the value is defined in the specified file format version.</returns>
        /// <remarks>
        /// Method to support enum validation in schema validation.
        /// </remarks>
        internal virtual bool IsInVersion(FileFormatVersions fileFormat)
        {
            throw new NotImplementedException();
        }
    }
}
