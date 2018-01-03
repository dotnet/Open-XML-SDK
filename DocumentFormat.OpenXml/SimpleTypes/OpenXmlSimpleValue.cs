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
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            this.InnerText = source.InnerText;
        }

        private protected virtual bool ShouldParse(string value) => !string.IsNullOrEmpty(value);

        /// <inheritdoc/>
        public override bool HasValue
        {
            get
            {
                if (!this.InnerValue.HasValue && ShouldParse(TextValue))
                {
                    TryParse();
                }

                return this.InnerValue.HasValue;
            }
        }

        /// <summary>
        /// Convert the text to meaningful value.
        /// </summary>
        internal virtual void Parse()
        {
        }

        /// <summary>
        /// Convert the text to meaningful value.
        /// </summary>
        /// <returns></returns>
        internal virtual bool TryParse()
        {
            return true;
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
                    Parse();
                }

                return this.InnerValue.Value;
            }

            set
            {
                this.InnerValue = value;
                this.TextValue = null;
            }
        }

        /// <inheritdoc/>
        public override string InnerText
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                // do not check whether format is ok.

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
