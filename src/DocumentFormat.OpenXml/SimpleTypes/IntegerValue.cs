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
    /// Represents the xsd:integer value for attributes.
    /// </summary>
    /// <remarks>
    /// Integer is derived from decimal by fixing the value of fractionDigits to be 0 and disallowing the trailing decimal point.
    /// The value space of integer is the infinite set {...,-2,-1,0,1,2,...}. The base type of integer is decimal.
    ///
    /// Use Int64 as the internal type for now.
    /// TODO: Should decimal be used as the internal type?
    /// </remarks>
    [DebuggerDisplay("{InnerText}")]
    public class IntegerValue : OpenXmlComparableSimpleValue<long>
    {
        /// <summary>
        /// Initializes a new instance of the IntegerValue class.
        /// </summary>
        public IntegerValue()
        {
        }

        /// <summary>
        /// Initializes a new instance of the IntegerValue class using the supplied Int64 value.
        /// </summary>
        /// <param name="value">The Int64 value.</param>
        public IntegerValue(long value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the IntegerValue class by deep copying the supplied IntegerValue class.
        /// </summary>
        /// <param name="source">The source IntegerValue class.</param>
        public IntegerValue(IntegerValue source)
            : base(source)
        {
        }

        private protected override string GetText(long input) => XmlConvert.ToString(input);

        private protected override long Parse(string input) => XmlConvert.ToInt64(input);

        /// <summary>
        /// Implicitly converts the specified IntegerValue to an Int64 value.
        /// </summary>
        /// <param name="xmlAttribute">The IntegerValue to convert.</param>
        /// <returns>
        /// The converted Int64 value.
        /// </returns>
        /// <exception cref="InvalidOperationException">Thrown when xmlAttribute is null.</exception>
        public static implicit operator long(IntegerValue xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return ToInt64(xmlAttribute);
        }

        /// <summary>
        /// Implicitly converts the specified Int64 value to an IntegerValue class.
        /// </summary>
        /// <param name="value">The specified value.</param>
        /// <returns>A new IntegerValue instance with the value.</returns>
        public static implicit operator IntegerValue(long value)
        {
            return FromInt64(value);
        }

        /// <summary>
        /// Returns a new IntegerValue object created from an Int64 value.
        /// </summary>
        /// <param name="value">An Int64 value to use to create a new IntegerValue object.</param>
        /// <returns>An IntegerValue that corresponds to the value parameter.</returns>
        public static IntegerValue FromInt64(long value)
        {
            return new IntegerValue(value);
        }

        /// <summary>
        /// Returns the Int64 representation of an IntegerValue object.
        /// </summary>
        /// <param name="xmlAttribute">
        /// An IntegerValue object used to retrieve an Int64 representation.
        /// </param>
        /// <returns>An Int64 value that represents an IntegerValue object.</returns>
        public static long ToInt64(IntegerValue xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return xmlAttribute.Value;
        }

        private protected override OpenXmlSimpleType CloneImpl() => new IntegerValue(this);
    }
}
