// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;
using System.Xml;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Represents the <see cref="bool"/> value for attributes.
    /// </summary>
    [DebuggerDisplay("{InnerText}")]
    public class BooleanValue : OpenXmlComparableSimpleValue<bool>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BooleanValue"/> class.
        /// </summary>
        public BooleanValue()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BooleanValue"/> class using the supplied <see cref="bool"/> value.
        /// </summary>
        /// <param name="value">The <see cref="bool"/> value.</param>
        public BooleanValue(bool value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BooleanValue"/> class by deep copying
        /// the supplied <see cref="BooleanValue"/> class.
        /// </summary>
        /// <param name="source">
        /// The source <see cref="BooleanValue"/> class.
        /// </param>
        public BooleanValue(BooleanValue source)
            : base(source)
        {
        }

        private protected override string GetText(bool input) => input ? "1" : "0";

        private protected override bool Parse(string input) => XmlConvert.ToBoolean(input);

        /// <summary>
        /// Implicitly converts the specified value to a <see cref="bool"/> value.
        /// </summary>
        /// <param name="value">The <see cref="BooleanValue"/> to convert.</param>
        /// <returns>The converted <see cref="bool"/> value.</returns>
        /// <exception cref="InvalidOperationException">Thrown when <paramref name="value"/> is null.</exception>
        public static implicit operator bool(BooleanValue value)
        {
            if (value is null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return ToBoolean(value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BooleanValue"/> class by implicitly
        /// converting the supplied <see cref="bool"/> value.
        /// </summary>
        /// <param name="value">The <see cref="bool"/> value.</param>
        /// <returns>A new <see cref="BooleanValue"/> instance with the value.</returns>
        public static implicit operator BooleanValue(bool value) => FromBoolean(value);

        /// <summary>
        /// Returns a new <see cref="BooleanValue"/> object that was created by using the supplied <see cref="bool"/> value.
        /// </summary>
        /// <param name="value">A <see cref="bool"/> value to use to create a new <see cref="BooleanValue"/> object.</param>
        /// <returns>A <see cref="BooleanValue"/> that corresponds to the value parameter.</returns>
        public static BooleanValue FromBoolean(bool value) => new BooleanValue(value);

        /// <summary>
        /// Returns the <see cref="bool"/> representation of a <see cref="BooleanValue"/> object.
        /// </summary>
        /// <param name="value">
        /// A <see cref="BooleanValue"/> object to retrieve a <see cref="bool"/> representation.
        /// </param>
        /// <returns>A <see cref="bool"/> value that represents a <see cref="BooleanValue"/> object.</returns>
        public static bool ToBoolean(BooleanValue value)
        {
            if (value is null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return value.Value;
        }

        private protected override OpenXmlSimpleType CloneImpl() => new BooleanValue(this);
    }
}
