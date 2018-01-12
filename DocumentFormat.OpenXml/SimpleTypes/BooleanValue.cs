// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;
using System.Xml;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Represents the Boolean value for attributes.
    /// </summary>
    [DebuggerDisplay("{InnerText}")]
    public class BooleanValue : OpenXmlSimpleValue<Boolean>
    {
        /// <summary>
        /// Initializes a new instance of the BooleanValue class.
        /// </summary>
        public BooleanValue()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BooleanValue class using the supplied Boolean value.
        /// </summary>
        /// <param name="value">The Boolean value.</param>
        public BooleanValue(Boolean value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BooleanValue class by deep copying
        /// the supplied BooleanValue class.
        /// </summary>
        /// <param name="source">
        /// The source BooleanValue class.
        /// </param>
        public BooleanValue(BooleanValue source)
            : base(source)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }
        }

        /// <inheritdoc/>
        public override string InnerText
        {
            get
            {
                if (this.TextValue == null && this.InnerValue.HasValue)
                {
                    // Word use "1", "0"
                    this.TextValue = this.InnerValue.Value ? "1" : "0";
                }
                return this.TextValue;
            }
        }

        /// <inheritdoc/>
        internal override void Parse()
        {
            this.InnerValue = XmlConvert.ToBoolean(this.TextValue);
        }

        /// <inheritdoc/>
        internal override bool TryParse()
        {
            Boolean value;
            this.InnerValue = null;

            try
            {
                value = XmlConvert.ToBoolean(this.TextValue);
                this.InnerValue = value;
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        /// <summary>
        /// Implicitly converts the specified value to a Boolean value.
        /// </summary>
        /// <param name="xmlAttribute">The BooleanValue to convert.</param>
        /// <returns>The converted Boolean value.</returns>
        /// <exception cref="InvalidOperationException">Thrown when xmlAttribute is null.</exception>
        public static implicit operator Boolean(BooleanValue xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return ToBoolean(xmlAttribute);
        }

        /// <summary>
        /// Initializes a new instance of the BooleanValue class by implicitly
        /// converting the supplied Boolean value.
        /// </summary>
        /// <param name="value">The Boolean value.</param>
        /// <returns>A new BooleanValue instance with the value.</returns>
        public static implicit operator BooleanValue(Boolean value)
        {
            return FromBoolean(value);
        }

        /// <summary>
        /// Returns a new BooleanValue object that was created by using the supplied Boolean value.
        /// </summary>
        /// <param name="value">A Boolean value to use to create a new BooleanValue object.</param>
        /// <returns>A BooleanValue that corresponds to the value parameter.</returns>
        public static BooleanValue FromBoolean(Boolean value)
        {
            return new BooleanValue(value);
        }

        /// <summary>
        /// Returns the Boolean representation of a BooleanValue object.
        /// </summary>
        /// <param name="xmlAttribute">
        /// A BooleanValue object to retrieve a Boolean representation.
        /// </param>
        /// <returns>A Boolean value that represents a BooleanValue object.</returns>
        public static Boolean ToBoolean(BooleanValue xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return xmlAttribute.Value;
        }

        private protected override OpenXmlSimpleType CloneImpl() => new BooleanValue(this);
    }
}
