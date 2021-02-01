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
    public class TrueFalseValue : OpenXmlComparableSimpleValue<bool>
    {
        /// <summary>
        /// Initializes a new instance of <see cref="TrueFalseValue"/> class.
        /// </summary>
        public TrueFalseValue()
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="TrueFalseValue"/> class using the supplied <see cref="bool"/> value.
        /// </summary>
        /// <param name="value">The <see cref="bool"/> value.</param>
        public TrueFalseValue(bool value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrueFalseValue"/> class using the supplied <see cref="TrueFalseValue"/> class.
        /// </summary>
        /// <param name="source">The source <see cref="TrueFalseValue"/> class.</param>
        public TrueFalseValue(TrueFalseValue source)
            : base(source)
        {
        }

        /// <summary>
        /// Implicitly converts a <see cref="TrueFalseValue"/> class to a <see cref="bool"/> value.
        /// </summary>
        /// <param name="value">The <see cref="TrueFalseValue"/> to convert.</param>
        /// <returns>The converted <see cref="bool"/> value.</returns>
        public static implicit operator bool(TrueFalseValue value)
        {
            if (value is null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return ToBoolean(value);
        }

        /// <summary>
        /// Implicitly converts a <see cref="bool"/> value to a <see cref="TrueFalseValue"/> instance.
        /// </summary>
        /// <param name="value">The <see cref="bool"/> value to convert.</param>
        /// <returns>The converted <see cref="TrueFalseValue"/> value.</returns>
        public static implicit operator TrueFalseValue(bool value) => FromBoolean(value);

        /// <summary>
        /// Returns a new <see cref="TrueFalseValue"/> object that was created from a <see cref="bool"/> value.
        /// </summary>
        /// <param name="value">A <see cref="bool"/> value to use to create a new <see cref="TrueFalseValue"/> object.</param>
        /// <returns>A <see cref="TrueFalseValue"/> that corresponds to the value parameter.</returns>
        public static TrueFalseValue FromBoolean(bool value) => new TrueFalseValue(value);

        /// <summary>
        /// Returns the internal <see cref="bool"/> representation of a <see cref="TrueFalseValue"/> object.
        /// </summary>
        /// <param name="value">A <see cref="TrueFalseValue"/> object to retrieve an internal <see cref="bool"/> representation.</param>
        /// <returns>A <see cref="bool"/> value that represents a <see cref="TrueFalseValue"/> object.</returns>
        public static bool ToBoolean(TrueFalseValue value)
        {
            if (value is null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return value.Value;
        }

        private protected override OpenXmlSimpleType CloneImpl() => new TrueFalseValue(this);

        private protected override bool ShouldParse(string? value) => value is not null;

        /// <summary>
        /// Gets the real boolean value of the text value.
        /// </summary>
        /// <param name="textValue">The text value which could be 't', 'f', 'true', 'false'.</param>
        /// <returns>True on text value is 't', 'true'; False on text value is 'f', 'false'.</returns>
        private protected override bool Parse(string? textValue)
            => textValue switch
            {
                "true" or "t" => true,
                "false" or "f" or null => false,
                _ => throw new FormatException(ExceptionMessages.TextIsInvalidTrueFalseValue),
            };

        /// <summary>
        /// Gets the default text value.
        /// </summary>
        /// <param name="boolValue">The boolean value.</param>
        /// <returns>"t" false true, "f" for false.</returns>
        private protected override string GetText(bool boolValue) => boolValue ? "true" : "false";
    }
}
