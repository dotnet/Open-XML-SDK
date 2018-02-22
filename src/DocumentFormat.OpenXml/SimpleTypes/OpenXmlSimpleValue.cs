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
        private protected T? InnerValue { get; set; }

        /// <summary>
        /// Initializes a new instance of the OpenXmlSimpleValue class.
        /// </summary>
        protected OpenXmlSimpleValue()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlSimpleValue class.
        /// </summary>
        /// <param name="value">The value in type T.</param>
        protected OpenXmlSimpleValue(T value)
            : base()
        {
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlSimpleValue class by deep copying the supplied OpenXmlSimpleValue class.
        /// </summary>
        /// <param name="source">The source OpenXmlSimleValue class.</param>
        protected OpenXmlSimpleValue(OpenXmlSimpleValue<T> source)
            : base(source)
        {
            this.InnerText = source.InnerText;
        }

        private protected virtual bool ShouldParse(string value) => !string.IsNullOrEmpty(value);

        private protected virtual void ValidateSet(T value)
        {
        }

        /// <inheritdoc/>
        public override bool HasValue
        {
            get
            {
                if (!this.InnerValue.HasValue && ShouldParse(TextValue) && TryParse(TextValue, out var parsed))
                {
                    InnerValue = parsed;
                }

                return this.InnerValue.HasValue;
            }
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
        /// Gets or sets the value of the simple value.
        /// </summary>
        public T Value
        {
            get
            {
                if (!this.InnerValue.HasValue && ShouldParse(InnerText))
                {
                    InnerValue = Parse(InnerText);
                }

                return this.InnerValue.Value;
            }

            set
            {
                ValidateSet(value);

                this.InnerValue = value;
                this.TextValue = null;
            }
        }

        /// <inheritdoc/>
        public override string InnerText
        {
            get
            {
                if (this.TextValue == null && this.InnerValue.HasValue)
                {
                    this.TextValue = GetText(this.InnerValue.Value);
                }

                return this.TextValue;
            }

            set
            {
                this.TextValue = value;
                this.InnerValue = null;
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
    }
}
