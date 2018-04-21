// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Represents the enum value for attributes.
    /// </summary>
    /// <typeparam name="T">Every enum value must be an enum with the EnumStringValueAttribute object.</typeparam>
    [DebuggerDisplay("{InnerText}")]
    public class EnumValue<T> : OpenXmlSimpleValue<T>
        where T : struct
    {
        /// <summary>
        /// Initializes a new instance of the EnumValue class.
        /// </summary>
        public EnumValue()
        {
        }

        /// <summary>
        /// Initializes a new instance of the EnumValue class using the supplied
        /// value of type T.
        /// </summary>
        /// <param name="value">
        /// The value of type T.
        /// </param>
        public EnumValue(T value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the EnumValue by deep copying the supplied
        /// EnumValue class.
        /// </summary>
        /// <param name="source">
        /// The source EnumValue class.
        /// </param>
        public EnumValue(EnumValue<T> source)
            : base(source)
        {
        }

        /// <summary>
        /// Implicitly converts the specified value to an enum.
        /// </summary>
        /// <param name="xmlAttribute">The EnumValue to convert.</param>
        /// <returns>
        /// The converted enum value.
        /// </returns>
        /// <exception cref="InvalidOperationException">Thrown when xmlAttribute is null.</exception>
        public static implicit operator T(EnumValue<T> xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return xmlAttribute.Value;
        }

        /// <summary>
        /// Initializes a new EnumValue class by converting the supplied enum
        /// value.
        /// </summary>
        /// <param name="value">The specified value.</param>
        /// <returns>A new EnumValue instance corresponding to the value.</returns>
        public static implicit operator EnumValue<T>(T value)
        {
            return new EnumValue<T>(value);
        }

        /// <summary>
        /// Implicitly converts the specified value to a String value.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted string.</returns>
        public static implicit operator string(EnumValue<T> value)
        {
            if (value == null)
                return null;

            return value.InnerText;
        }

        private protected override OpenXmlSimpleType CloneImpl() => new EnumValue<T>(this);

        /// <inheritdoc />
        internal override bool IsInVersion(FileFormatVersions fileFormat)
        {
            Debug.Assert(HasValue);

            var supportedVersion = EnumStringLookup<T>.GetVersion(Value);

            return supportedVersion.Includes(fileFormat);
        }

        private protected override bool ShouldParse(string value) => value != null;

        private protected override void ValidateSet(T value)
        {
            if (!EnumStringLookup<T>.IsDefined(value))
            {
                throw new ArgumentOutOfRangeException(nameof(value), ExceptionMessages.InvalidEnumValue);
            }
        }

        private protected override string GetText(T input) => EnumStringLookup<T>.ToString(input);

        private protected override bool TryParse(string input, out T value) => EnumStringLookup<T>.TryParse(input, out value);

        private protected override T Parse(string input)
        {
            if (EnumStringLookup<T>.TryParse(input, out var value))
            {
                return value;
            }

            throw new FormatException(ExceptionMessages.TextIsInvalidEnumValue);
        }
    }
}
