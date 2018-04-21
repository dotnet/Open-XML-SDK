// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Represents a generic value for simple value types (Int32, UInt32, Byte, struct, etc).
    /// </summary>
    /// <typeparam name="T">The type of the value.</typeparam>
    [DebuggerDisplay("{InnerText}")]
    public abstract class OpenXmlSimpleValue<T> : OpenXmlSimpleType
        where T : struct
    {
        /// <summary>
        /// Initializes a new instance of the OpenXmlSimpleValue class.
        /// </summary>
        protected OpenXmlSimpleValue()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlSimpleValue class.
        /// </summary>
        /// <param name="value">The value in type T.</param>
        protected OpenXmlSimpleValue(T value)
        {
            Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlSimpleValue class by deep copying the supplied OpenXmlSimpleValue class.
        /// </summary>
        /// <param name="source">The source OpenXmlSimleValue class.</param>
        protected OpenXmlSimpleValue(OpenXmlSimpleValue<T> source)
            : base(source)
        {
            InnerText = source.InnerText;
        }

        private protected T? InnerValue { get; set; }

        /// <inheritdoc />
        public override bool HasValue
        {
            get
            {
                if (!InnerValue.HasValue && ShouldParse(TextValue) && TryParse(TextValue, out var parsed))
                {
                    InnerValue = parsed;
                }

                return InnerValue.HasValue;
            }
        }

        /// <summary>
        /// Gets or sets the value of the simple value.
        /// </summary>
        public T Value
        {
            get
            {
                if (!InnerValue.HasValue && ShouldParse(InnerText))
                {
                    InnerValue = Parse(InnerText);
                }

                return InnerValue.Value;
            }

            set
            {
                ValidateSet(value);

                InnerValue = value;
                TextValue = null;
            }
        }

        /// <inheritdoc />
        public override string InnerText
        {
            get
            {
                if (TextValue == null && InnerValue.HasValue)
                {
                    TextValue = GetText(InnerValue.Value);
                }

                return TextValue;
            }

            set
            {
                TextValue = value;
                InnerValue = null;
            }
        }

        private protected virtual bool ShouldParse(string value)
        {
            return !string.IsNullOrEmpty(value);
        }

        private protected virtual void ValidateSet(T value)
        {
        }

        private protected abstract string GetText(T input);

        /// <summary>
        /// Convert the text to meaningful value.
        /// </summary>
        private protected abstract T Parse(string input);

        /// <summary>
        /// Convert the text to meaningful value with no exceptions
        /// </summary>
        private protected virtual bool TryParse(string input, out T value)
        {
            try
            {
                value = Parse(input);
                return true;
            }
            catch (Exception)
            {
                value = default;
                return false;
            }
        }

        /// <summary>
        /// Implicitly converts the specified value to T.
        /// </summary>
        /// <param name="xmlAttribute">The OpenXmlSimpleValue instance.</param>
        /// <returns>The internal value in the OpenXmlSimpleValue class.</returns>
        /// <exception cref="InvalidOperationException">Thrown when xmlAttribute is null.</exception>
        public static implicit operator T(OpenXmlSimpleValue<T> xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return xmlAttribute.Value;
        }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (obj is OpenXmlSimpleValue<T> openXmlSimpleValue)
            {
                return Value.Equals(openXmlSimpleValue.Value);
            }

            if (obj is T value)
            {
                return Value.Equals(value);
            }

            return false;
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }
}
