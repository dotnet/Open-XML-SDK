// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;

// See https://github.com/dotnet/roslyn-analyzers/issues/1671
#pragma warning disable CA1036

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Defines an OnOffValue data type for attributes that have enum values that are Boolean values that represent: 'true' or 'false', 'on' or 'off', or '0' or '1'.
    /// </summary>
    [DebuggerDisplay("{InnerText}")]
    public class OnOffValue : OpenXmlComparableSimpleValue<bool>
    {
        /// <summary>
        /// Initializes a new instance of <see cref="OnOffValue"/> class.
        /// </summary>
        public OnOffValue()
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="OnOffValue"/> class using the supplied Boolean value.
        /// </summary>
        /// <param name="value">The <see cref="bool"/> value.</param>
        public OnOffValue(bool value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="OnOffValue"/> class using the supplied OnOffValue class.
        /// </summary>
        /// <param name="source">The source <see cref="OnOffValue"/> class.</param>
        public OnOffValue(OnOffValue source)
            : base(source)
        {
        }

        /// <summary>
        /// Gets the real text value of the text value.
        /// </summary>
        /// <param name="textValue">The text value which could be 'true', 'false', 'on', 'off', '0', or '1'.</param>
        /// <returns>True for 'true', 'on', '0', or '1'.</returns>
        private protected override bool Parse(string textValue)
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

        private protected override bool ShouldParse(string value) => value != null;

        /// <summary>
        /// Gets the default text value.
        /// </summary>
        /// <param name="boolValue">The boolean value.</param>
        /// <returns>"1" for True, "0" for False.</returns>
        private protected override string GetText(bool boolValue)
        {
            // TODO : Defines the default text values.
            return boolValue ? "true" : "false";
        }

        private protected override OpenXmlSimpleType CloneImpl() => new OnOffValue(this);

        /// <summary>
        /// Implicitly converts the specified OnOffValue object to a <see cref="bool"/> value.
        /// </summary>
        /// <param name="xmlAttribute">The <see cref="OnOffValue"/> object to convert.</param>
        /// <returns>The converted <see cref="bool"/> value.</returns>
        public static implicit operator bool(OnOffValue xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new ArgumentNullException(nameof(xmlAttribute));
            }

            return ToBoolean(xmlAttribute);
        }

        /// <summary>
        /// Implicitly converts a <see cref="bool"/> value to an <see cref="OnOffValue"/> value.
        /// </summary>
        /// <param name="value">The <see cref="bool"/> value to convert.</param>
        /// <returns>The converted <see cref="OnOffValue"/>.</returns>
        public static implicit operator OnOffValue(bool value)
        {
            return FromBoolean(value);
        }

        /// <summary>
        /// Returns a new OnOffValue object created from a Boolean value.
        /// </summary>
        /// <param name="value">A Boolean value that is used to create a new OnOffValue object.</param>
        /// <returns>A OnOffValue that corresponds to the value parameter.</returns>
        public static OnOffValue FromBoolean(bool value)
        {
            return new OnOffValue(value);
        }

        /// <summary>
        /// Returns the internal Boolean representation of a OnOffValue object.
        /// </summary>
        /// <param name="xmlAttribute">A OnOffValue object to retrieve an internal Boolean representation.</param>
        /// <returns>A Boolean value that represents a OnOffValue object.</returns>
        public static bool ToBoolean(OnOffValue xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return xmlAttribute.Value;
        }
    }
}
