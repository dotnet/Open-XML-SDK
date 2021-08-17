// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;
using System.Xml;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Represents the <see cref="int"/> value for attributes.
    /// </summary>
    [DebuggerDisplay("{InnerText}")]
    public class Int32Value : OpenXmlComparableSimpleValue<int>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Int32Value"/> class.
        /// </summary>
        public Int32Value()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Int32Value"/> class using the supplied <see cref="int"/> value.
        /// </summary>
        /// <param name="value">The <see cref="int"/> value.</param>
        public Int32Value(int value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Int32Value"/> by deep copying the supplied <see cref="Int32Value"/> class.
        /// </summary>
        /// <param name="source">The source <see cref="Int32Value"/> class.</param>
        public Int32Value(Int32Value source)
            : base(source)
        {
        }

        private protected override string GetText(int input) => XmlConvert.ToString(input);

        private protected override int Parse(string input) => XmlConvert.ToInt32(input);

        /// <summary>
        /// Implicitly converts the specified value to an <see cref="int"/> value.
        /// </summary>
        /// <param name="value">The <see cref="Int32Value"/> to convert.</param>
        /// <returns>
        /// The converted <see cref="int"/> value.
        /// </returns>
        /// <exception cref="InvalidOperationException">Thrown when <paramref name="value"/> is <c>null</c>.</exception>
        public static implicit operator int(Int32Value value)
        {
            if (value is null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return ToInt32(value);
        }

        /// <summary>
        /// Implicitly converts an <see cref="int"/> value to a specified <see cref="Int32Value"/> instance.
        /// </summary>
        /// <param name="value">The specified <see cref="int"/> value.</param>
        /// <returns>A new <see cref="Int32Value"/> instance with the value.</returns>
        public static implicit operator Int32Value(int value) => FromInt32(value);

        /// <summary>
        /// Returns a new <see cref="Int32Value"/> object that was created from an <see cref="int"/> value.
        /// </summary>
        /// <param name="value">An <see cref="int"/> value to use to create a new <see cref="Int32Value"/> object.</param>
        /// <returns>An <see cref="Int32Value"/> that corresponds to the value parameter.</returns>
        public static Int32Value FromInt32(int value) => new Int32Value(value);

        /// <summary>
        /// Returns the <see cref="int"/> representation of an <see cref="Int32Value"/> object.
        /// </summary>
        /// <param name="value">
        /// An <see cref="Int32Value"/> object to use to retrieve an <see cref="int"/> representation.
        /// </param>
        /// <returns>An <see cref="int"/> value that represents an <see cref="Int32Value"/> object.</returns>
        public static int ToInt32(Int32Value value)
        {
            if (value is null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return value.Value;
        }

        private protected override OpenXmlSimpleType CloneImpl() => new Int32Value(this);
    }
}
