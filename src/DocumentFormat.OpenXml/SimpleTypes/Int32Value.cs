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
    /// Represents the Int32 value for attributes.
    /// </summary>
    [DebuggerDisplay("{InnerText}")]
    public class Int32Value : OpenXmlComparableSimpleValue<int>
    {
        /// <summary>
        /// Initializes a new instance of the Int32Value class.
        /// </summary>
        public Int32Value()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Int32Value class using the supplied Int32 value.
        /// </summary>
        /// <param name="value">The Int32 value.</param>
        public Int32Value(int value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Int32Value by deep copying the supplied Int32Value class.
        /// </summary>
        /// <param name="source">The source Int32Value class.</param>
        public Int32Value(Int32Value source)
            : base(source)
        {
        }

        private protected override string GetText(int input) => XmlConvert.ToString(input);

        private protected override int Parse(string input) => XmlConvert.ToInt32(input);

        /// <summary>
        /// Implicitly converts the specified value to an Int32 value.
        /// </summary>
        /// <param name="xmlAttribute">The Int32Value to convert.</param>
        /// <returns>
        /// The converted Int32 value.
        /// </returns>
        /// <exception cref="InvalidOperationException">Thrown when xmlAttribute is null.</exception>
        public static implicit operator int(Int32Value xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return ToInt32(xmlAttribute);
        }

        /// <summary>
        /// Implicitly converts an Int32 value to a specified Int32Value instance.
        /// </summary>
        /// <param name="value">The specified Int32 value.</param>
        /// <returns>A new Int32Value instance with the value.</returns>
        public static implicit operator Int32Value(int value)
        {
            return FromInt32(value);
        }

        /// <summary>
        /// Returns a new Int32Value object that was created from an Int32 value.
        /// </summary>
        /// <param name="value">An Int32 value to use to create a new Int32Value object.</param>
        /// <returns>An Int32Value that corresponds to the value parameter.</returns>
        public static Int32Value FromInt32(int value)
        {
            return new Int32Value(value);
        }

        /// <summary>
        /// Returns the Int32 representation of an Int32Value object.
        /// </summary>
        /// <param name="xmlAttribute">
        /// An Int32Value object to use to retrieve an Int32 representation.
        /// </param>
        /// <returns>An Int32 value that represents an Int32Value object.</returns>
        public static int ToInt32(Int32Value xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return xmlAttribute.Value;
        }

        private protected override OpenXmlSimpleType CloneImpl() => new Int32Value(this);
    }
}
