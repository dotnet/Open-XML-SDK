// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Represents the string value for attributes.
    /// </summary>
    [DebuggerDisplay("{InnerText}")]
    public class StringValue : OpenXmlComparableSimpleReference<string>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StringValue"/> class.
        /// </summary>
        public StringValue()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StringValue"/> class using the supplied string.
        /// </summary>
        /// <param name="value">The string value.</param>
        public StringValue(string? value)
        {
            TextValue = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StringValue"/> class by deep copying the supplied <see cref="StringValue"/> class.
        /// </summary>
        /// <param name="source">The source <see cref="StringValue"/> class.</param>
        public StringValue(StringValue source)
            : base(source)
        {
        }

        internal override bool IsValid => HasValue;

        internal virtual int Length => InnerText?.Length ?? 0;

        /// <summary>
        /// Gets or sets the string value.
        /// </summary>
        public override string? Value
        {
            get => TextValue;
            set => TextValue = value;
        }

        /// <summary>
        /// Implicitly converts the specified value to a <see cref="string"/> value.
        /// </summary>
        /// <param name="value">The <see cref="StringValue"/> to convert.</param>
        /// <returns>
        /// The converted value. Returns <c>null</c>when <paramref name="value"/> is <c>null</c>.
        /// </returns>
        public static implicit operator string?(StringValue? value)
        {
            if (value is null)
            {
                return null;
            }

            return ToString(value);
        }

        /// <summary>
        /// Implicitly converts the specified <see cref="string"/> value to a <see cref="StringValue"/> object.
        /// </summary>
        /// <param name="value">The specified value.</param>
        /// <returns>A new <see cref="StringValue"/> instance with the value.</returns>
        public static implicit operator StringValue(string? value) => FromString(value);

        /// <summary>
        /// Returns a new <see cref="StringValue"/> object that was created from a <see cref="string"/> value.
        /// </summary>
        /// <param name="value">A <see cref="string"/> value to use to create a new <see cref="StringValue"/> object.</param>
        /// <returns>A <see cref="StringValue"/> that corresponds to the value parameter.</returns>
        public static StringValue FromString(string? value) => new StringValue(value);

        /// <summary>
        /// Returns the <see cref="string"/> value representation of a <see cref="StringValue"/> object.
        /// </summary>
        /// <param name="value">
        /// A <see cref="StringValue"/> object used to retrieve a <see cref="string"/> value representation.
        /// </param>
        /// <returns>A <see cref="string"/> value that represents a <see cref="StringValue"/> object.</returns>
        public static string? ToString(StringValue value)
        {
            if (value is null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return value.Value;
        }

        private protected override OpenXmlSimpleType CloneImpl() => new StringValue(this);
    }
}
