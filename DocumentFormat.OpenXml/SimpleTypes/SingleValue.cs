// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;
using System.Xml;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Represents the Single value for attributes.
    /// </summary>
    [DebuggerDisplay("{InnerText}")]
    public class SingleValue : OpenXmlSimpleValue<Single>
    {
        /// <summary>
        /// Initializes a new instance of the SingleValue class.
        /// </summary>
        public SingleValue()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SingleValue class using the supplied Single value.
        /// </summary>
        /// <param name="value">The Single value.</param>
        public SingleValue(Single value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SingleValue class by deep copying the supplied SingleValue class.
        /// </summary>
        /// <param name="source">The source SingleValue class.</param>
        public SingleValue(SingleValue source)
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
#if DEBUG
                    if (this.InnerValue.HasValue && this.TextValue != null)
                    {
                        if (Single.IsPositiveInfinity(this.InnerValue.Value))
                        {
                            Debug.Assert(this.TextValue == "INF" || this.TextValue == "Infinity");
                        }
                        else if (Single.IsNegativeInfinity(this.InnerValue.Value))
                        {
                            Debug.Assert(this.TextValue == "-INF" || this.TextValue == "-Infinity");
                        }
                        else
                        {
                            Debug.Assert(this.TextValue == XmlConvert.ToString(this.InnerValue.Value) ||
                                // special case: signed number like text is "+5", value is 5
                                 this.TextValue != null && this.TextValue == "+" + XmlConvert.ToString(this.InnerValue.Value));
                        }
                    }
                    else
                    {
                        Debug.Assert(this.TextValue == null && !this.InnerValue.HasValue ||
                                     this.TextValue != null && !this.InnerValue.HasValue);
                    }
#endif
                }
                return this.TextValue;
            }
        }

        /// <inheritdoc/>
        internal override void Parse()
        {
            float value = XmlConvert.ToSingle(this.TextValue);
            this.InnerValue = value;
        }

        /// <inheritdoc/>
        internal override bool TryParse()
        {
            this.InnerValue = null;

            try
            {
                Parse();
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
        /// Implicitly converts the specified SingleValue object to a Single value.
        /// </summary>
        /// <param name="xmlAttribute">The SingleValue to convert.</param>
        /// <returns>
        /// The converted Single value.
        /// </returns>
        /// <exception cref="InvalidOperationException">Thrown when xmlAttribute is null.</exception>
        public static implicit operator Single(SingleValue xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }
            return ToSingle(xmlAttribute);
        }

        /// <summary>
        /// Implicitly converts the specified Single value to a SingleValue object.
        /// </summary>
        /// <param name="value">The specified value.</param>
        /// <returns>A new SingleValue instance with the value.</returns>
        public static implicit operator SingleValue(Single value)
        {
            return FromSingle(value);
        }

        /// <summary>
        /// Returns a new SingleValue object that was created from a Single value.
        /// </summary>
        /// <param name="value">A Single value to use to create a new SingleValue object.</param>
        /// <returns>A SingleValue object that corresponds to the value parameter.</returns>
        public static SingleValue FromSingle(Single value)
        {
            return new SingleValue(value);
        }

        /// <summary>
        /// Returns the Single value representation of a SingleValue object.
        /// </summary>
        /// <param name="xmlAttribute">
        /// A SingleValue object used to retrieve a Single value representation.
        /// </param>
        /// <returns>A Single value that represents a SingleValue object.</returns>
        public static Single ToSingle(SingleValue xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return xmlAttribute.Value;
        }

        private protected override OpenXmlSimpleType CloneImpl() => new SingleValue(this);
    }
}
