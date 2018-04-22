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
    /// Represents the Single value for attributes.
    /// </summary>
    [DebuggerDisplay("{InnerText}")]
    public class SingleValue : OpenXmlComparableSimpleValue<float>
    {
        /// <summary>
        /// Initializes a new instance of the SingleValue class.
        /// </summary>
        public SingleValue()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SingleValue class using the supplied Single value.
        /// </summary>
        /// <param name="value">The Single value.</param>
        public SingleValue(float value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SingleValue class by deep copying the supplied SingleValue class.
        /// </summary>
        /// <param name="source">The source SingleValue class.</param>
        public SingleValue(SingleValue source)
            : base(source)
        {
        }

        private protected override string GetText(float input) => XmlConvert.ToString(input);

        private protected override float Parse(string input) => XmlConvert.ToSingle(input);

        /// <summary>
        /// Implicitly converts the specified SingleValue object to a Single value.
        /// </summary>
        /// <param name="xmlAttribute">The SingleValue to convert.</param>
        /// <returns>
        /// The converted Single value.
        /// </returns>
        /// <exception cref="InvalidOperationException">Thrown when xmlAttribute is null.</exception>
        public static implicit operator float(SingleValue xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return ToSingle(xmlAttribute);
        }

        /// <summary>
        /// Implicitly converts the specified Single value to a SingleValue object.
        /// </summary>
        /// <param name="value">The specified value.</param>
        /// <returns>A new SingleValue instance with the value.</returns>
        public static implicit operator SingleValue(float value)
        {
            return FromSingle(value);
        }

        /// <summary>
        /// Returns a new SingleValue object that was created from a Single value.
        /// </summary>
        /// <param name="value">A Single value to use to create a new SingleValue object.</param>
        /// <returns>A SingleValue object that corresponds to the value parameter.</returns>
        public static SingleValue FromSingle(float value)
        {
            return new SingleValue(value);
        }

        /// <summary>
        /// Returns the Single value representation of a SingleValue object.
        /// </summary>
        /// <param name="xmlAttribute">
        /// A SingleValue object used to retrieve a Single value representation.
        /// </param>
        /// <returns>A Single value that represents a SingleValue object.</returns>
        public static float ToSingle(SingleValue xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return xmlAttribute.Value;
        }

        private protected override OpenXmlSimpleType CloneImpl() => new SingleValue(this);
    }
}
