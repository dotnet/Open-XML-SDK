// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;
using System.Xml;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Represents the <see cref="short"/> value for attributes.
    /// </summary>
    [DebuggerDisplay("{InnerText}")]
    public class Int16Value : OpenXmlComparableSimpleValue<short>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Int16Value"/> class.
        /// </summary>
        public Int16Value()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Int16Value"/> class using the supplied <see cref="short"/> value.
        /// </summary>
        /// <param name="value">The <see cref="short"/> value.</param>
        public Int16Value(short value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Int16Value"/> by deep copying the supplied IntValue class.
        /// </summary>
        /// <param name="source">The source <see cref="Int16Value"/> class.</param>
        public Int16Value(Int16Value source)
            : base(source)
        {
        }

        private protected override string GetText(short input) => XmlConvert.ToString(input);

        private protected override short Parse(string input) => XmlConvert.ToInt16(input);

        /// <summary>
        /// Implicitly converts the specified value to an <see cref="short"/> value.
        /// </summary>
        /// <param name="value">The <see cref="Int16Value"/> to convert.</param>
        /// <returns>The converted <see cref="short"/> value.</returns>
        /// <exception cref="InvalidOperationException">Thrown when <paramref name="value"/> is <c>null</c>.</exception>
        public static implicit operator short(Int16Value value)
        {
            if (value is null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return ToInt16(value);
        }

        /// <summary>
        /// Implicitly converts an <see cref="short"/> value to a <see cref="Int16Value"/> instance.
        /// </summary>
        /// <param name="value">The specified value.</param>
        /// <returns>A new <see cref="Int16Value"/> instance with the value.</returns>
        public static implicit operator Int16Value(short value) => FromInt16(value);

        /// <summary>
        /// Returns a new <see cref="Int16Value"/> object that was created from an <see cref="short"/> value.
        /// </summary>
        /// <param name="value">An <see cref="short"/> value to use to create a new <see cref="Int16Value"/> object.</param>
        /// <returns>An <see cref="Int16Value"/> that corresponds to the value parameter.</returns>
        public static Int16Value FromInt16(short value) => new Int16Value(value);

        /// <summary>
        /// Returns an <see cref="short"/> representation of an <see cref="Int16Value"/> object.
        /// </summary>
        /// <param name="value">
        /// An <see cref="Int16Value"/> object to retrieve an <see cref="short"/> representation.
        /// </param>
        /// <returns>An <see cref="short"/> value that represents an <see cref="Int16Value"/> object.</returns>
        public static short ToInt16(Int16Value value)
        {
            if (value is null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return value.Value;
        }

        private protected override OpenXmlSimpleType CloneImpl() => new Int16Value(this);
    }
}
