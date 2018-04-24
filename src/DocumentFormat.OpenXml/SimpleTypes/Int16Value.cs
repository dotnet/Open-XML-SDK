// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;
using System.Xml;

// See https://github.com/dotnet/roslyn-analyzers/issues/1671
#pragma warning disable CA1036

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Represents the Int16 value for attributes.
    /// </summary>
    [DebuggerDisplay("{InnerText}")]
    public class Int16Value : OpenXmlComparableSimpleValue<short>
    {
        /// <summary>
        /// Initializes a new instance of the Int16Value class.
        /// </summary>
        public Int16Value()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Int16Value class using the supplied Int16 value.
        /// </summary>
        /// <param name="value">The Int16 value.</param>
        public Int16Value(short value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Int16Value by deep copying the supplied IntValue class.
        /// </summary>
        /// <param name="source">The source Int16Value class.</param>
        public Int16Value(Int16Value source)
            : base(source)
        {
        }

        private protected override string GetText(short input) => XmlConvert.ToString(input);

        private protected override short Parse(string input) => XmlConvert.ToInt16(input);

        /// <summary>
        /// Implicitly converts the specified value to an Int16 value.
        /// </summary>
        /// <param name="xmlAttribute">The Int16Value to convert.</param>
        /// <returns>The converted Int16 value.</returns>
        /// <exception cref="InvalidOperationException">Thrown when xmlAttribute is null.</exception>
        public static implicit operator short(Int16Value xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return ToInt16(xmlAttribute);
        }

        /// <summary>
        /// Implicitly converts an Int16 value to a Int16Value instance.
        /// </summary>
        /// <param name="value">The specified value.</param>
        /// <returns>A new Int16Value instance with the value.</returns>
        public static implicit operator Int16Value(short value)
        {
            return FromInt16(value);
        }

        /// <summary>
        /// Returns a new Int16Value object that was created from an Int16 value.
        /// </summary>
        /// <param name="value">An Int16 value to use to create a new Int16Value object.</param>
        /// <returns>An Int16Value that corresponds to the value parameter.</returns>
        public static Int16Value FromInt16(short value)
        {
            return new Int16Value(value);
        }

        /// <summary>
        /// Returns an Int16 representation of an Int16Value object.
        /// </summary>
        /// <param name="xmlAttribute">
        /// An Int16Value object to retrieve an Int16 representation.
        /// </param>
        /// <returns>An Int16 value that represents an Int16Value object.</returns>
        public static short ToInt16(Int16Value xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return xmlAttribute.Value;
        }

        private protected override OpenXmlSimpleType CloneImpl() => new Int16Value(this);
    }
}
