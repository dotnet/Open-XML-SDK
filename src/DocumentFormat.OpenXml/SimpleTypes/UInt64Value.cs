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
    /// Represents the UInt64 value for attributes.
    /// </summary>
    [CLSCompliant(false)]
    [DebuggerDisplay("{InnerText}")]
    public class UInt64Value : OpenXmlComparableSimpleValue<ulong>
    {
        /// <summary>
        /// Initializes a new instance of the UInt64Value class.
        /// </summary>
        public UInt64Value()
        {
        }

        /// <summary>
        /// Initializes a new instance of the UInt64Value class using the supplied UInt64 value.
        /// </summary>
        /// <param name="value">The UInt64 value.</param>
        public UInt64Value(ulong value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the UInt64Value class by deep copying the UInt64Value class.
        /// </summary>
        /// <param name="source">The source UInt64Value class.</param>
        public UInt64Value(UInt64Value source)
            : base(source)
        {
        }

        private protected override string GetText(ulong input) => XmlConvert.ToString(input);

        private protected override ulong Parse(string input) => XmlConvert.ToUInt64(input);

        /// <summary>
        /// Implicitly converts the specified UInt64Value object to a UInt64 value.
        /// </summary>
        /// <param name="xmlAttribute">The UInt64Value object to convert.</param>
        /// <returns>The converted UInt64 value.</returns>
        /// <exception cref="InvalidOperationException">Thrown when xmlAttribute is null.</exception>
        public static implicit operator ulong(UInt64Value xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return ToUInt64(xmlAttribute);
        }

        /// <summary>
        /// Implicitly converts a specified UInt64 value to a UInt64Value class.
        /// </summary>
        /// <param name="value">The specified value.</param>
        /// <returns>A new UInt64Value instance with the value.</returns>
        public static implicit operator UInt64Value(ulong value)
        {
            return FromUInt64(value);
        }

        /// <summary>
        /// Returns a new UInt64Value object created from a UInt64 value.
        /// </summary>
        /// <param name="value">A UInt64 value to use to create a new UInt64Value object.</param>
        /// <returns>A UInt64Value that corresponds to the value parameter.</returns>
        public static UInt64Value FromUInt64(ulong value)
        {
            return new UInt64Value(value);
        }

        /// <summary>
        /// Returns the UInt64 value representation of a UInt64Value object.
        /// </summary>
        /// <param name="xmlAttribute">
        /// A UInt64Value object used to retrieve a UInt64 representation.
        /// </param>
        /// <returns>A UInt64 value that represents a UInt64Value object.</returns>
        public static ulong ToUInt64(UInt64Value xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return xmlAttribute.Value;
        }

        private protected override OpenXmlSimpleType CloneImpl() => new UInt64Value(this);
    }
}
