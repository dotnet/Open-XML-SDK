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
    /// Represents the UInt32 value for attributes.
    /// </summary>
    [CLSCompliant(false)]
    [DebuggerDisplay("{InnerText}")]
    public class UInt32Value : OpenXmlComparableSimpleValue<uint>
    {
        /// <summary>
        /// Initializes a new instance of the UInt32Value class.
        /// </summary>
        public UInt32Value()
        {
        }

        /// <summary>
        /// Initializes a new instance of the UInt32Value class using the supplied UInt32 value.
        /// </summary>
        /// <param name="value">The UInt32 value.</param>
        public UInt32Value(uint value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the UInt32Value class by deep copying the supplied UInt32Value class.
        /// </summary>
        /// <param name="source">The source UInt32Value class.</param>
        public UInt32Value(UInt32Value source)
            : base(source)
        {
        }

        private protected override string GetText(uint input) => XmlConvert.ToString(input);

        private protected override uint Parse(string input) => XmlConvert.ToUInt32(input);

        /// <summary>
        /// Implicitly converts the specified UInt32Value class to a UInt32 value.
        /// </summary>
        /// <param name="xmlAttribute">The UInt32Value class to convert.</param>
        /// <returns>The converted UInt32 value.</returns>
        /// <exception cref="InvalidOperationException">Thrown when xmlAttribute is null.</exception>
        public static implicit operator uint(UInt32Value xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return ToUInt32(xmlAttribute);
        }

        /// <summary>
        /// Implicitly converts a specified UInt32 value to a UInt32Value class.
        /// </summary>
        /// <param name="value">The specified value.</param>
        /// <returns>A new UInt32Value instance with the value.</returns>
        public static implicit operator UInt32Value(uint value)
        {
            return FromUInt32(value);
        }

        /// <summary>
        /// Returns a new UInt32Value object created from a UInt32 value.
        /// </summary>
        /// <param name="value">A UInt32 value to use to create a new UInt32Value object.</param>
        /// <returns>A UInt32Value class that corresponds to the value parameter.</returns>
        public static UInt32Value FromUInt32(uint value)
        {
            return new UInt32Value(value);
        }

        /// <summary>
        /// Returns the UInt32 value representation of a UInt32Value object.
        /// </summary>
        /// <param name="xmlAttribute">
        /// A UInt32Value object used to retrieve a UInt32 value representation.
        /// </param>
        /// <returns>A UInt32 value that represents a UInt32Value object.</returns>
        public static uint ToUInt32(UInt32Value xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return xmlAttribute.Value;
        }

        private protected override OpenXmlSimpleType CloneImpl() => new UInt32Value(this);
    }
}
