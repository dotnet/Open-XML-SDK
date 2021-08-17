// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Represents the data type for attributes that have enum values that are <see cref="bool"/> values that represent 't' or 'f', or 'true' or 'false'.
    /// </summary>
    [DebuggerDisplay("{InnerText}")]
    public class TrueFalseBlankValue : OpenXmlComparableSimpleValue<bool>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrueFalseBlankValue"/> class.
        /// </summary>
        public TrueFalseBlankValue()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrueFalseBlankValue"/> class using the supplied <see cref="bool"/> value.
        /// </summary>
        /// <param name="value">The <see cref="bool"/> value.</param>
        public TrueFalseBlankValue(bool value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrueFalseBlankValue"/> class using the supplied <see cref="TrueFalseBlankValue"/> class.
        /// </summary>
        /// <param name="source">The source <see cref="TrueFalseBlankValue"/> class.</param>
        public TrueFalseBlankValue(TrueFalseBlankValue source)
            : base(source)
        {
        }

        /// <summary>
        /// Implicitly converts a <see cref="TrueFalseBlankValue"/> object to a <see cref="bool"/> value.
        /// </summary>
        /// <param name="value">The source <see cref="TrueFalseBlankValue"/> to convert.</param>
        /// <returns>The converted <see cref="bool"/> value.</returns>
        public static implicit operator bool(TrueFalseBlankValue value)
        {
            if (value is null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return ToBoolean(value);
        }

        /// <summary>
        /// Implicitly converts a <see cref="bool"/> value to a TrueFalsBlankValue value.
        /// </summary>
        /// <param name="value">The source <see cref="bool"/> value to convert.</param>
        /// <returns>The converted <see cref="TrueFalseBlankValue"/> value.</returns>
        public static implicit operator TrueFalseBlankValue(bool value) => FromBoolean(value);

        /// <summary>
        /// Returns a new <see cref="TrueFalseBlankValue"/> object created from a <see cref="bool"/> value.
        /// </summary>
        /// <param name="value">A <see cref="bool"/> value to create a new <see cref="TrueFalseBlankValue"/> object from.</param>
        /// <returns>A <see cref="TrueFalseBlankValue"/> that corresponds to the value parameter.</returns>
        public static TrueFalseBlankValue FromBoolean(bool value) => new TrueFalseBlankValue(value);

        /// <summary>
        /// Returns the internal <see cref="bool"/> representation of a <see cref="TrueFalseBlankValue"/> object.
        /// </summary>
        /// <param name="value">A <see cref="TrueFalseBlankValue"/> object to retrieve an internal <see cref="bool"/> representation.</param>
        /// <returns>A <see cref="bool"/> value that represents a <see cref="TrueFalseBlankValue"/> object.</returns>
        public static bool ToBoolean(TrueFalseBlankValue value)
        {
            if (value is null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return value.Value;
        }

        private protected override OpenXmlSimpleType CloneImpl() => new TrueFalseBlankValue(this);

        private protected override bool ShouldParse(string? value) => value is not null;

        /// <summary>
        /// Gets the real boolean value of the text value.
        /// </summary>
        /// <param name="textValue">The text value which could be 't', 'f', 'true', 'false', ''.</param>
        /// <returns>True on text value is 't', 'true'; False on text value is 'f', 'false', '' </returns>
        private protected override bool Parse(string? textValue)
            => textValue switch
            {
                "true" or "t" => true,
                "false" or "f" or "" or null => false,
                _ => throw new FormatException(ExceptionMessages.TextIsInvalidTrueFalseBlankValue),
            };

        /// <summary>
        /// Gets the text value.
        /// </summary>
        /// <param name="boolValue">The boolean value.</param>
        /// <returns>"t" for True, "f" for false.</returns>
        private protected override string GetText(bool boolValue) => boolValue ? "true" : "false";
    }
}
