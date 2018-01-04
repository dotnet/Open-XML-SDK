// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Defines an OnOffValue datatype for attributes that have enum values that are Boolean values that represent: 'true' or 'false', 'on' or 'off', or '0' or '1'.
    /// </summary>
    [DebuggerDisplay("{InnerText}")]
    public class OnOffValue : OpenXmlSimpleType
    {
        private TrueFalseValueImpl _impl;

        /// <summary>
        /// Initializes a new instance of <see cref="OnOffValue"/> class.
        /// </summary>
        public OnOffValue()
            : base()
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of <see cref="OnOffValue"/> class using the supplied Boolean value.
        /// </summary>
        /// <param name="value">The <see cref="Boolean"/> value.</param>
        public OnOffValue(Boolean value)
            : base()
        {
            Initialize();
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of <see cref="OnOffValue"/> class using the supplied OnOffValue class.
        /// </summary>
        /// <param name="source">The source <see cref="OnOffValue"/> class.</param>
        public OnOffValue(OnOffValue source)
            : base(source)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }
            Initialize();
            _impl.InnerText = source.InnerText;
        }

        private void Initialize()
        {
            _impl = new TrueFalseValueImpl(
                GetBooleanValue,
                GetDefaultTextValue);
        }

        /// <inheritdoc/>
        public override bool HasValue
        {
            get
            {
                return _impl.HasValue;
            }
        }

#pragma warning disable SA1623 // Property summary documentation should match accessor
                              /// <summary>
                              /// Gets or sets the value.
                              /// </summary>
        public bool Value
#pragma warning restore SA1623 // Property summary documentation should match accessors
        {
            get
            {
                return _impl.Value;
            }

            set
            {
                _impl.Value = value;
            }
        }

        /// <inheritdoc/>
        public override string InnerText
        {
            get
            {
                return _impl.InnerText;
            }

            set
            {
                _impl.InnerText = value;
            }
        }

        /// <summary>
        /// Gets the real text value of the text value.
        /// </summary>
        /// <param name="textValue">The text value which could be 'true', 'false', 'on', 'off', '0', or '1'.</param>
        /// <returns>True for 'true', 'on', '0', or '1'.</returns>
        private bool GetBooleanValue(string textValue)
        {
            if (textValue != null)
            {
                if ("true".Equals(textValue))
                {
                    return true;
                }
                else if ("false".Equals(textValue))
                {
                    return false;
                }
                else if ("on".Equals(textValue))
                {
                    return true;
                }
                else if ("off".Equals(textValue))
                {
                    return false;
                }
                else if ("1".Equals(textValue))
                {
                    return true;
                }
                else if ("0".Equals(textValue))
                {
                    return false;
                }
                else
                {
                    throw new FormatException(ExceptionMessages.TextIsInvalidOnOffValue);
                }
            }

            return false;
        }

        /// <summary>
        /// Gets the default text value.
        /// </summary>
        /// <param name="boolValue">The boolean value.</param>
        /// <returns>"1" for True, "0" for False.</returns>
        private string GetDefaultTextValue(Boolean boolValue)
        {
            // TODO : Defines the default text values.
            return boolValue ? "true" : "false";
        }

        private protected override OpenXmlSimpleType CloneImpl() => new OnOffValue(this);

        /// <summary>
        /// Implicitly converts the specified OnOffValue object to a <see cref="Boolean"/> value.
        /// </summary>
        /// <param name="xmlAttribute">The <see cref="OnOffValue"/> object to convert.</param>
        /// <returns>The converted <see cref="Boolean"/> value.</returns>
        public static implicit operator Boolean(OnOffValue xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new ArgumentNullException(nameof(xmlAttribute));
            }

            return ToBoolean(xmlAttribute);
        }

        /// <summary>
        /// Implicitly converts a <see cref="Boolean"/> value to an <see cref="OnOffValue"/> value.
        /// </summary>
        /// <param name="value">The <see cref="Boolean"/> value to convert.</param>
        /// <returns>The converted <see cref="OnOffValue"/>.</returns>
        public static implicit operator OnOffValue(Boolean value)
        {
            return FromBoolean(value);
        }

        /// <summary>
        /// Returns a new OnOffValue object created from a Boolean value.
        /// </summary>
        /// <param name="value">A Boolean value that is used to create a new OnOffValue object.</param>
        /// <returns>A OnOffValue that corresponds to the value parameter.</returns>
        public static OnOffValue FromBoolean(Boolean value)
        {
            return new OnOffValue(value);
        }

        /// <summary>
        /// Returns the internal Boolean representation of a OnOffValue object.
        /// </summary>
        /// <param name="xmlAttribute">A OnOffValue object to retrieve an internal Boolean representation.</param>
        /// <returns>A Boolean value that represents a OnOffValue object.</returns>
        public static Boolean ToBoolean(OnOffValue xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return xmlAttribute.Value;
        }
    }
}
