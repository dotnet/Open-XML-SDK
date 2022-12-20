// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;
using System.Xml;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Represents the <see cref="float"/> value for attributes.
    /// </summary>
    [DebuggerDisplay("{InnerText}")]
    public class SingleValue : OpenXmlComparableSimpleValue<float>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SingleValue"/> class.
        /// </summary>
        public SingleValue()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SingleValue"/> class using the supplied <see cref="float"/> value.
        /// </summary>
        /// <param name="value">The <see cref="float"/> value.</param>
        public SingleValue(float value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SingleValue"/> class by deep copying the supplied <see cref="SingleValue"/> class.
        /// </summary>
        /// <param name="source">The source <see cref="SingleValue"/> class.</param>
        public SingleValue(SingleValue source)
            : base(source)
        {
        }

        private protected override string GetText(float input) => XmlConvert.ToString(input);

        private protected override float Parse(string input) => XmlConvert.ToSingle(input);

        /// <summary>
        /// Implicitly converts the specified <see cref="SingleValue"/> object to a <see cref="float"/> value.
        /// </summary>
        /// <param name="value">The <see cref="SingleValue"/> to convert.</param>
        /// <returns>
        /// The converted <see cref="float"/> value.
        /// </returns>
        /// <exception cref="InvalidOperationException">Thrown when <paramref name="value"/> is <c>null</c>.</exception>
        public static implicit operator float(SingleValue value)
        {
            if (value is null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return ToSingle(value);
        }

        /// <summary>
        /// Implicitly converts the specified <see cref="float"/> value to a <see cref="SingleValue"/> object.
        /// </summary>
        /// <param name="value">The specified value.</param>
        /// <returns>A new <see cref="SingleValue"/> instance with the value.</returns>
        public static implicit operator SingleValue(float value) => FromSingle(value);

        /// <summary>
        /// Returns a new <see cref="SingleValue"/> object that was created from a <see cref="float"/> value.
        /// </summary>
        /// <param name="value">A <see cref="float"/> value to use to create a new <see cref="SingleValue"/> object.</param>
        /// <returns>A <see cref="SingleValue"/> object that corresponds to the value parameter.</returns>
        public static SingleValue FromSingle(float value) => new SingleValue(value);

        /// <summary>
        /// Returns the <see cref="float"/> value representation of a <see cref="SingleValue"/> object.
        /// </summary>
        /// <param name="value">
        /// A <see cref="SingleValue"/> object used to retrieve a <see cref="float"/> value representation.
        /// </param>
        /// <returns>A <see cref="float"/> value that represents a <see cref="SingleValue"/> object.</returns>
        public static float ToSingle(SingleValue value)
        {
            if (value is null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return value.Value;
        }

        private protected override OpenXmlSimpleType CloneImpl() => new SingleValue(this);
    }
}
