// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;
using System.Xml;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Represents the <see cref="DateTime"/> value for attributes.
    /// </summary>
    [DebuggerDisplay("{InnerText}")]
    public class DateTimeValue : OpenXmlComparableSimpleValue<DateTime>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DateTimeValue"/> class.
        /// </summary>
        public DateTimeValue()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DateTimeValue"/> class using the supplied
        /// <see cref="DateTime"/> value.
        /// </summary>
        /// <param name="value">The <see cref="DateTime"/> value.</param>
        public DateTimeValue(DateTime value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DateTimeValue"/> class by deep copying the
        /// supplied <see cref="DateTimeValue"/> class.
        /// </summary>
        /// <param name="source">
        /// The source <see cref="DateTimeValue"/> class.
        /// </param>
        public DateTimeValue(DateTimeValue source)
            : base(source)
        {
        }

        private protected override string GetText(DateTime input) => XmlConvert.ToString(input, XmlDateTimeSerializationMode.RoundtripKind);

        /// <summary>
        /// Convert the text to meaningful value.
        /// </summary>
        private protected override DateTime Parse(string input) => XmlConvert.ToDateTime(input, XmlDateTimeSerializationMode.Utc);

        /// <summary>
        /// Implicitly converts the specified value to a <see cref="DateTime"/> value.
        /// </summary>
        /// <param name="value">
        /// The <see cref="DateTimeValue"/> object to convert.
        /// </param>
        /// <returns>
        /// The converted <see cref="DateTime"/> value.
        /// </returns>
        /// <exception cref="InvalidOperationException">Thrown when <paramref name="value"/> is <c>null</c>.</exception>
        public static implicit operator DateTime(DateTimeValue value)
        {
            if (value is null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return ToDateTime(value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DateTimeValue"/> class by implicitly
        /// converting the supplied <see cref="DateTime"/> value.
        /// </summary>
        /// <param name="value">
        /// The <see cref="DateTime"/> value.
        /// </param>
        /// <returns>A new <see cref="DateTimeValue"/> instance with the value.</returns>
        public static implicit operator DateTimeValue(DateTime value) => FromDateTime(value);

        /// <summary>
        /// Returns a new <see cref="DateTimeValue"/> object that was created from a <see cref="DateTime"/> value.
        /// </summary>
        /// <param name="value">A <see cref="DateTime"/> value to use to create a new <see cref="DateTimeValue"/> object.</param>
        /// <returns>A <see cref="DateTimeValue"/> object that corresponds to the value parameter.</returns>
        public static DateTimeValue FromDateTime(DateTime value) => new DateTimeValue(value);

        /// <summary>
        /// Returns the <see cref="DateTime"/> value representation of a <see cref="DateTimeValue"/> object.
        /// </summary>
        /// <param name="value">
        /// A <see cref="DateTimeValue"/> object used to retrieve a <see cref="DateTime"/> value representation.
        /// </param>
        /// <returns>A <see cref="DateTime"/> value that represents a <see cref="DateTimeValue"/> object.</returns>
        public static DateTime ToDateTime(DateTimeValue value)
        {
            if (value is null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return value.Value;
        }

        private protected override OpenXmlSimpleType CloneImpl() => new DateTimeValue(this);
    }
}
