// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;

// See https://github.com/dotnet/roslyn-analyzers/issues/1671
#pragma warning disable CA1036

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Represents the data type for attributes that have enum values that are Boolean values that represent 't' or 'f', or 'true' or 'false'.
    /// </summary>
    [DebuggerDisplay("{InnerText}")]
    public class TrueFalseBlankValue : OpenXmlComparableSimpleValue<bool>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrueFalseBlankValue"/> class.
        /// </summary>
        public TrueFalseBlankValue()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrueFalseBlankValue"/> class using the supplied Boolean value.
        /// </summary>
        /// <param name="value">The <see cref="bool"/> value.</param>
        public TrueFalseBlankValue(bool value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrueFalseBlankValue"/> class using the supplied TrueFalseBlankValue class.
        /// </summary>
        /// <param name="source">The source <see cref="TrueFalseBlankValue"/> class.</param>
        public TrueFalseBlankValue(TrueFalseBlankValue source)
            : base(source)
        {
        }

        /// <summary>
        /// Implicitly converts a TrueFalseBlankValue object to a <see cref="bool"/> value.
        /// </summary>
        /// <param name="xmlAttribute">The source <see cref="TrueFalseBlankValue"/> to convert.</param>
        /// <returns>The converted <see cref="bool"/> value.</returns>
        public static implicit operator bool(TrueFalseBlankValue xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return ToBoolean(xmlAttribute);
        }

        /// <summary>
        /// Implicitly converts a <see cref="bool"/> value to a TrueFalsBlankValue value.
        /// </summary>
        /// <param name="value">The source <see cref="bool"/> value to convert.</param>
        /// <returns>The converted <see cref="TrueFalseBlankValue"/> value.</returns>
        public static implicit operator TrueFalseBlankValue(bool value)
        {
            return FromBoolean(value);
        }

        /// <summary>
        /// Returns a new TrueFalseBlankValue object created from a Boolean value.
        /// </summary>
        /// <param name="value">A Boolean value to create a new TrueFalseBlankValue object from.</param>
        /// <returns>A TrueFalseBlankValue that corresponds to the value parameter.</returns>
        public static TrueFalseBlankValue FromBoolean(bool value)
        {
            return new TrueFalseBlankValue(value);
        }

        /// <summary>
        /// Returns the internal Boolean representation of a TrueFalseBlankValue object.
        /// </summary>
        /// <param name="xmlAttribute">A TrueFalseBlankValue object to retrieve an internal Boolean representation.</param>
        /// <returns>A Boolean value that represents a TrueFalseBlankValue object.</returns>
        public static bool ToBoolean(TrueFalseBlankValue xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return xmlAttribute.Value;
        }

        private protected override OpenXmlSimpleType CloneImpl() => new TrueFalseBlankValue(this);

        private protected override bool ShouldParse(string value) => value != null;

        /// <summary>
        /// Gets the real boolean value of the text value.
        /// </summary>
        /// <param name="textValue">The text value which could be 't', 'f', 'true', 'false', ''.</param>
        /// <returns>True on text value is 't', 'true'; False on text value is 'f', 'false', '' </returns>
        private protected override bool Parse(string textValue)
        {
            if (textValue != null)
            {
                if ("true".Equals(textValue))
                {
                    return true;
                }
                else if ("false".Equals(textValue))
                {
                    return false;
                }
                else if ("t".Equals(textValue))
                {
                    return true;
                }
                else if ("f".Equals(textValue))
                {
                    return false;
                }
                else if (textValue.Length == 0)
                {
                    // blank
                    return false;
                }
                else
                {
                    throw new FormatException(ExceptionMessages.TextIsInvalidTrueFalseBlankValue);
                }
            }

            return false;
        }

        /// <summary>
        /// Gets the text value.
        /// </summary>
        /// <param name="boolValue">The boolean value.</param>
        /// <returns>"t" for True, "f" for false.</returns>
        private protected override string GetText(bool boolValue)
        {
            // TODO : Define the default text value.
            return boolValue ? "true" : "false";
        }
    }
}
