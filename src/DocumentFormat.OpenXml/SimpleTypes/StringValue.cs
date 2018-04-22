// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;

// See https://github.com/dotnet/roslyn-analyzers/issues/1671
#pragma warning disable CA1036

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Represents the string value for attributes.
    /// </summary>
    [DebuggerDisplay("{InnerText}")]
    public class StringValue : OpenXmlComparableSimpleReference<string>
    {
        /// <summary>
        /// Initializes a new instance of the StringValue class.
        /// </summary>
        public StringValue()
        {
        }

        /// <summary>
        /// Initializes a new instance of the StringValue class using the supplied string.
        /// </summary>
        /// <param name="value">The string value.</param>
        public StringValue(string value)
        {
            TextValue = value;
        }

        /// <summary>
        /// Initializes a new instance of the StringValue class by deep copying the supplied StringValue class.
        /// </summary>
        /// <param name="source">The source StringValue class.</param>
        public StringValue(StringValue source)
            : base(source)
        {
        }

        /// <summary>
        /// Gets or sets the string value.
        /// </summary>
        public override string Value
        {
            get => TextValue;
            set => TextValue = value;
        }

        /// <summary>
        /// Implicitly converts the specified value to a String value.
        /// </summary>
        /// <param name="xmlAttribute">The StringValue to convert.</param>
        /// <returns>
        /// The converted String value. Returns null when xmlAttribute is null.
        /// </returns>
        public static implicit operator string(StringValue xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                return null;
            }

            return ToString(xmlAttribute);
        }

        /// <summary>
        /// Implicitly converts the specified String value to a StringValue object.
        /// </summary>
        /// <param name="value">The specified value.</param>
        /// <returns>A new StringValue instance with the value.</returns>
        public static implicit operator StringValue(string value)
        {
            return FromString(value);
        }

        /// <summary>
        /// Returns a new StringValue object that was created from a String value.
        /// </summary>
        /// <param name="value">A String value to use to create a new StringValue object.</param>
        /// <returns>A StringValue that corresponds to the value parameter.</returns>
        public static StringValue FromString(string value)
        {
            return new StringValue(value);
        }

        /// <summary>
        /// Returns the String value representation of a StringValue object.
        /// </summary>
        /// <param name="xmlAttribute">
        /// A StringValue object used to retrieve a String value representation.
        /// </param>
        /// <returns>A String value that represents a StringValue object.</returns>
        public static string ToString(StringValue xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return xmlAttribute.Value;
        }

        private protected override OpenXmlSimpleType CloneImpl() => new StringValue(this);
    }
}
