// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Defines an <see cref="OnOffValue"/> data type for attributes that have enum values that are <see cref="bool"/> values that represent: 'true' or 'false', 'on' or 'off', or '0' or '1'.
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
        /// Initializes a new instance of <see cref="OnOffValue"/> class using the supplied <see cref="bool"/> value.
        /// </summary>
        /// <param name="value">The <see cref="bool"/> value.</param>
        public OnOffValue(bool value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="OnOffValue"/> class using the supplied <see cref="OnOffValue"/> class.
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
        private protected override bool Parse(string? textValue)
            => textValue switch
            {
                "true" or "1" or "on" => true,
                "false" or "0" or "off" or null => false,
                _ => throw new FormatException(ExceptionMessages.TextIsInvalidOnOffValue),
            };

        private protected override bool ShouldParse(string? value) => value is not null;

        /// <summary>
        /// Gets the default text value.
        /// </summary>
        /// <param name="boolValue">The boolean value.</param>
        /// <returns>"1" for <c>true</c>, "0" for <c>false</c>.</returns>
        private protected override string GetText(bool boolValue) => boolValue ? "true" : "false";

        private protected override OpenXmlSimpleType CloneImpl() => new OnOffValue(this);

        /// <summary>
        /// Implicitly converts the specified <see cref="OnOffValue"/> object to a <see cref="bool"/> value.
        /// </summary>
        /// <param name="value">The <see cref="OnOffValue"/> object to convert.</param>
        /// <returns>The converted <see cref="bool"/> value.</returns>
        public static implicit operator bool(OnOffValue value)
        {
            if (value is null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            return ToBoolean(value);
        }

        /// <summary>
        /// Implicitly converts a <see cref="bool"/> value to an <see cref="OnOffValue"/> value.
        /// </summary>
        /// <param name="value">The <see cref="bool"/> value to convert.</param>
        /// <returns>The converted <see cref="OnOffValue"/>.</returns>
        public static implicit operator OnOffValue(bool value) => FromBoolean(value);

        /// <summary>
        /// Returns a new <see cref="OnOffValue"/> object created from a <see cref="bool"/> value.
        /// </summary>
        /// <param name="value">A <see cref="bool"/> value that is used to create a new <see cref="OnOffValue"/> object.</param>
        /// <returns>A <see cref="OnOffValue"/> that corresponds to the value parameter.</returns>
        public static OnOffValue FromBoolean(bool value) => new OnOffValue(value);

        /// <summary>
        /// Returns the internal <see cref="bool"/> representation of a <see cref="OnOffValue"/> object.
        /// </summary>
        /// <param name="value">A <see cref="OnOffValue"/> object to retrieve an internal <see cref="bool"/> representation.</param>
        /// <returns>A <see cref="bool"/> value that represents a <see cref="OnOffValue"/> object.</returns>
        public static bool ToBoolean(OnOffValue value)
        {
            if (value is null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return value.Value;
        }
    }
}
