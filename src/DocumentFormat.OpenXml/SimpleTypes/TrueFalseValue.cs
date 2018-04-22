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
    public class TrueFalseValue : OpenXmlComparableSimpleValue<bool>
    {
        /// <summary>
        /// Initializes a new instance of <see cref="TrueFalseValue"/> class.
        /// </summary>
        public TrueFalseValue()
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="TrueFalseValue"/> class using the supplied Boolean value.
        /// </summary>
        /// <param name="value">The <see cref="bool"/> value.</param>
        public TrueFalseValue(bool value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrueFalseValue"/> class using the supplied TrueFalseValue class.
        /// </summary>
        /// <param name="source">The source <see cref="TrueFalseValue"/> class.</param>
        public TrueFalseValue(TrueFalseValue source)
            : base(source)
        {
        }

        /// <summary>
        /// Implicitly converts a TrueFalseValue class to a <see cref="bool"/> value.
        /// </summary>
        /// <param name="xmlAttribute">The <see cref="TrueFalseValue"/> to convert.</param>
        /// <returns>The converted <see cref="bool"/> value.</returns>
        public static implicit operator bool(TrueFalseValue xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return ToBoolean(xmlAttribute);
        }

        /// <summary>
        /// Implicitly converts a <see cref="bool"/> value to a TrueFalseValue instance.
        /// </summary>
        /// <param name="value">The <see cref="bool"/> value to convert.</param>
        /// <returns>The converted <see cref="TrueFalseValue"/> value.</returns>
        public static implicit operator TrueFalseValue(bool value)
        {
            return FromBoolean(value);
        }

        /// <summary>
        /// Returns a new TrueFalseValue object that was created from a Boolean value.
        /// </summary>
        /// <param name="value">A Boolean value to use to create a new TrueFalseValue object.</param>
        /// <returns>A TrueFalseValue that corresponds to the value parameter.</returns>
        public static TrueFalseValue FromBoolean(bool value)
        {
            return new TrueFalseValue(value);
        }

        /// <summary>
        /// Returns the internal Boolean representation of a TrueFalseValue object.
        /// </summary>
        /// <param name="xmlAttribute">A TrueFalseValue object to retrieve an internal Boolean representation.</param>
        /// <returns>A Boolean value that represents a TrueFalseValue object.</returns>
        public static bool ToBoolean(TrueFalseValue xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return xmlAttribute.Value;
        }

        private protected override OpenXmlSimpleType CloneImpl() => new TrueFalseValue(this);

        private protected override bool ShouldParse(string value) => value != null;

        /// <summary>
        /// Gets the real boolean value of the text value.
        /// </summary>
        /// <param name="textValue">The text value which could be 't', 'f', 'true', 'false'.</param>
        /// <returns>Ture on text value is 't', 'true'; False on text value is 'f', 'false'.</returns>
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
                else
                {
                    throw new FormatException(ExceptionMessages.TextIsInvalidTrueFalseValue);
                }
            }

            return false;
        }

        /// <summary>
        /// Gets the default text value.
        /// </summary>
        /// <param name="boolValue">The boolean value.</param>
        /// <returns>"t" false true, "f" for false.</returns>
        private protected override string GetText(bool boolValue)
        {
            // TODO : Needs to decide what are the default text values.
            return boolValue ? "true" : "false";
        }
    }
}
