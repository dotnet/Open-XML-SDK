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
    public abstract class OpenXmlSimpleValue<T>
        : OpenXmlSimpleType
        where T : struct
    {
        //can not use System.Nullable<T> _value;
        private T? _value;

        internal T? InnerValue
        {
            get { return this._value; }
            set { this._value = value; }
        }

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

        /// <inheritdoc/>
        public override bool HasValue
        {
            get
            {
                if (!this._value.HasValue)
                {
                    if (!String.IsNullOrEmpty(this.TextValue))
                    {
                        TryParse();
                    }
                }

                return this._value.HasValue;
            }
        }

        /// <summary>
        /// Gets or sets the value of the simple value.
        /// </summary>
        public T Value
        {
            get
            {
                if (!this._value.HasValue)
                {
                    if (!String.IsNullOrEmpty(this.TextValue))
                    {
                        Parse();
                    }
                }
                else
                {
                    // TODO: check that the .TextValue is same as .InnerValue in debug verion.
                }
                return  this._value.Value;
            }

            set
            {
                this._value = value;
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
                this._value = null;
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
