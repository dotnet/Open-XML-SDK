// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;

// See https://github.com/dotnet/roslyn-analyzers/issues/1671
#pragma warning disable CA1036

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Represents the xsd:base64Binary value for attributes.
    /// </summary>
    [DebuggerDisplay("{InnerText}")]
    public class Base64BinaryValue : OpenXmlComparableSimpleReference<string>
    {
        /// <summary>
        /// Initializes a new instance of the Base64BinaryValue class.
        /// </summary>
        public Base64BinaryValue()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Base64BinaryValue class by deep copying
        /// the supplied String value.
        /// </summary>
        /// <param name="base64Binary">
        /// The String value.
        /// </param>
        public Base64BinaryValue(string base64Binary)
        {
            TextValue = base64Binary;
        }

        /// <summary>
        /// Initializes a new instance of the Base64BinaryValue class by deep copying
        /// the supplied Base64BinaryValue class.
        /// </summary>
        /// <param name="source">
        /// The source Base64BinaryValue class.
        /// </param>
        public Base64BinaryValue(Base64BinaryValue source)
            : base(source)
        {
        }

        /// <summary>
        /// Gets or sets the Base64 binary string value.
        /// </summary>
        public override string Value
        {
            get => TextValue;
            set => TextValue = value;
        }

        /// <summary>
        /// Implicitly converts the specified value to a String value.
        /// </summary>
        /// <param name="xmlAttribute">The Base64BinaryValue object to convert.</param>
        /// <returns>The base64Binary string. Returns null when xmlAttribute is null.</returns>
        public static implicit operator string(Base64BinaryValue xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                return null;
            }

            return ToString(xmlAttribute);
        }

        /// <summary>
        /// Initializes a new instance of a Base64BinaryValue class using the
        /// supplied string.
        /// </summary>
        /// <param name="value">The specified base64Binary value.</param>
        /// <returns>A new Base64BinaryValue instance with the value.</returns>
        public static implicit operator Base64BinaryValue(string value)
        {
            return FromString(value);
        }

        /// <summary>
        /// Returns a new Base64BinaryValue object that was created from a String value.
        /// </summary>
        /// <param name="value">A String value to use to create a new Base64BinaryValue object.</param>
        /// <returns>A Base64BinaryValue that corresponds to the value parameter.</returns>
        public static Base64BinaryValue FromString(string value)
        {
            return new Base64BinaryValue(value);
        }

        /// <summary>
        /// Returns the String value representation of a Base64BinaryValue object.
        /// </summary>
        /// <param name="xmlAttribute">
        /// A Base64BinaryValue object used to retrieve a String value representation.
        /// </param>
        /// <returns>A String value that represents a Base64BinaryValue object.</returns>
        public static string ToString(Base64BinaryValue xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return xmlAttribute.Value;
        }

        private protected override OpenXmlSimpleType CloneImpl() => new Base64BinaryValue(this);
    }
}
