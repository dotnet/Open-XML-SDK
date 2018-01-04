// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;
using System.Xml;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Represents the Int32 value for attributes.
    /// </summary>
    [DebuggerDisplay("{InnerText}")]
    public class Int32Value : OpenXmlSimpleValue<Int32>
    {
        /// <summary>
        /// Initializes a new instance of the Int32Value class.
        /// </summary>
        public Int32Value()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Int32Value class using the supplied Int32 value.
        /// </summary>
        /// <param name="value">The Int32 value.</param>
        public Int32Value(Int32 value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Int32Value by deep copying the supplied Int32Value class.
        /// </summary>
        /// <param name="source">The source Int32Value class.</param>
        public Int32Value(Int32Value source)
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
                    // this.TextValue = this._value.ToString();
                    this.TextValue = XmlConvert.ToString(this.InnerValue.Value);
                }
                else
                {
                    //Debug.Assert(this.TextValue == null && !this.InnerValue.HasValue ||
                    //             this.TextValue != null && !this.InnerValue.HasValue ||
                    //             this.TextValue != null && this.TextValue == this.InnerValue.ToString() ||
                    //    // special case: signed number like text is "+5", value is 5
                    //             this.TextValue != null && this.TextValue == "+" + this.InnerValue.ToString());
                    bool assertVal = this.TextValue == null && !this.InnerValue.HasValue ||
                                 this.TextValue != null && !this.InnerValue.HasValue ||
                                 this.TextValue != null && this.TextValue == this.InnerValue.ToString() ||
								 // special case: signed number like text is "+5", value is 5
                                 this.TextValue != null && this.TextValue == "+" + this.InnerValue.ToString();
                    if (assertVal)
                        return this.TextValue;
                    // special case: number formatted like "00000", value is 0
                    // at this point, we know that this.TextValue != null
                    int iTextValue;
                    if (!int.TryParse(this.TextValue, out iTextValue))
                        throw new FormatException("Inner text formatting error");
                    int iValue;
                    if (!int.TryParse(this.InnerValue.ToString(), out iValue))
                        throw new FormatException("Inner text formatting error");
                    if (iTextValue == iValue)
                        return this.TextValue;
        			throw new FormatException("Inner text formatting error");
                }
                return this.TextValue;
            }
        }

        /// <inheritdoc/>
        internal override void Parse()
        {
            this.InnerValue = XmlConvert.ToInt32(this.TextValue);
        }

        /// <inheritdoc/>
        internal override bool TryParse()
        {
            Int32 value;
            this.InnerValue = null;

            try
            {
                value = XmlConvert.ToInt32(this.TextValue);
                this.InnerValue = value;
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
            catch (OverflowException)
            {
                return false;
            }
        }

        /// <summary>
        /// Implicitly converts the specified value to an Int32 value.
        /// </summary>
        /// <param name="xmlAttribute">The Int32Value to convert.</param>
        /// <returns>
        /// The converted Int32 value.
        /// </returns>
        /// <exception cref="InvalidOperationException">Thrown when xmlAttribute is null.</exception>
        public static implicit operator Int32(Int32Value xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }
            return ToInt32(xmlAttribute);
        }

        /// <summary>
        /// Implicitly converts an Int32 value to a specified Int32Value instance.
        /// </summary>
        /// <param name="value">The specified Int32 value.</param>
        /// <returns>A new Int32Value instance with the value.</returns>
        public static implicit operator Int32Value(Int32 value)
        {
            return FromInt32(value);
        }

        /// <summary>
        /// Returns a new Int32Value object that was created from an Int32 value.
        /// </summary>
        /// <param name="value">An Int32 value to use to create a new Int32Value object.</param>
        /// <returns>An Int32Value that corresponds to the value parameter.</returns>
        public static Int32Value FromInt32(Int32 value)
        {
            return new Int32Value(value);
        }

        /// <summary>
        /// Returns the Int32 representation of an Int32Value object.
        /// </summary>
        /// <param name="xmlAttribute">
        /// An Int32Value object to use to retrieve an Int32 representation.
        /// </param>
        /// <returns>An Int32 value that represents an Int32Value object.</returns>
        public static Int32 ToInt32(Int32Value xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return xmlAttribute.Value;
        }

        private protected override OpenXmlSimpleType CloneImpl() => new Int32Value(this);
    }
}
