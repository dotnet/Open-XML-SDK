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
    /// Represents the Boolean value for attributes.
    /// </summary>
    [DebuggerDisplay("{InnerText}")]
    public class BooleanValue : OpenXmlComparableSimpleValue<bool>
    {
        /// <summary>
        /// Initializes a new instance of the BooleanValue class.
        /// </summary>
        public BooleanValue()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BooleanValue class using the supplied Boolean value.
        /// </summary>
        /// <param name="value">The Boolean value.</param>
        public BooleanValue(bool value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BooleanValue class by deep copying
        /// the supplied BooleanValue class.
        /// </summary>
        /// <param name="source">
        /// The source BooleanValue class.
        /// </param>
        public BooleanValue(BooleanValue source)
            : base(source)
        {
        }

        private protected override string GetText(bool input) => input ? "1" : "0";

        private protected override bool Parse(string input) => XmlConvert.ToBoolean(input);

        /// <summary>
        /// Implicitly converts the specified value to a Boolean value.
        /// </summary>
        /// <param name="xmlAttribute">The BooleanValue to convert.</param>
        /// <returns>The converted Boolean value.</returns>
        /// <exception cref="InvalidOperationException">Thrown when xmlAttribute is null.</exception>
        public static implicit operator bool(BooleanValue xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return ToBoolean(xmlAttribute);
        }

        /// <summary>
        /// Initializes a new instance of the BooleanValue class by implicitly
        /// converting the supplied Boolean value.
        /// </summary>
        /// <param name="value">The Boolean value.</param>
        /// <returns>A new BooleanValue instance with the value.</returns>
        public static implicit operator BooleanValue(bool value)
        {
            return FromBoolean(value);
        }

        /// <summary>
        /// Returns a new BooleanValue object that was created by using the supplied Boolean value.
        /// </summary>
        /// <param name="value">A Boolean value to use to create a new BooleanValue object.</param>
        /// <returns>A BooleanValue that corresponds to the value parameter.</returns>
        public static BooleanValue FromBoolean(bool value)
        {
            return new BooleanValue(value);
        }

        /// <summary>
        /// Returns the Boolean representation of a BooleanValue object.
        /// </summary>
        /// <param name="xmlAttribute">
        /// A BooleanValue object to retrieve a Boolean representation.
        /// </param>
        /// <returns>A Boolean value that represents a BooleanValue object.</returns>
        public static bool ToBoolean(BooleanValue xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return xmlAttribute.Value;
        }

        private protected override OpenXmlSimpleType CloneImpl() => new BooleanValue(this);
    }
}
