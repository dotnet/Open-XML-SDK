// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Defines the base class implementing the common logic of
    /// <see cref="TrueFalseValue"/>, <see cref="TrueFalseBlankValue"/> and <see cref="OnOffValue"/>
    /// </summary>
    internal class TrueFalseValueImpl : OpenXmlSimpleType
    {
        // The method to convert text value to boolean value.
        private Func<string, Boolean> _getBooleanValueMethod;

        // The method to convert boolean value to default text value.
        private Func<Boolean, string> _getDefaultTextValueMethod;

        // The inner boolean value.
        private bool? _innerValue;

        /// <summary>
        /// Initializes a new instance of the <see cref="TrueFalseValueImpl"/> class using the supplied callbacks.
        /// </summary>
        /// <param name="getBooleanValueMethod">The method to convert text value to boolean value.</param>
        /// <param name="getDefaultTextMethod">The method to convert boolean value to default text value.</param>
        public TrueFalseValueImpl(Func<string, Boolean> getBooleanValueMethod, Func<Boolean, string> getDefaultTextMethod)
            : base()
        {
            Debug.Assert(getBooleanValueMethod != null);
            Debug.Assert(getDefaultTextMethod != null);

            this._getBooleanValueMethod = getBooleanValueMethod;
            this._getDefaultTextValueMethod = getDefaultTextMethod;
        }

        /// <inheritdoc/>
        public override string InnerText
        {
            get
            {
                // it returns the real inner text such as "t", "f", "on", "off", etc,
                // rather than the Boolean.ToString() which is "True"/"False"
                if (this.TextValue == null && this._innerValue.HasValue)
                {
                    this.TextValue = _getDefaultTextValueMethod(this._innerValue.Value);
                }
                return this.TextValue;
            }

            set
            {
                this.TextValue = value;
                this._innerValue = null;
            }
        }

        /// <inheritdoc/>
        public override bool HasValue
        {
            get
            {
                if (!this._innerValue.HasValue)
                {
                    // Because it means when the text value is empty,
                    // so use this.TextValue != null rather than
                    // if (!String.IsNullOrEmpty(this.TextValue))
                    if (this.TextValue != null)
                    {
                        TryParse();
                    }
                }

                return this._innerValue.HasValue;
            }
        }

#pragma warning disable SA1623 // Property summary documentation should match accessors
                              /// <summary>
                              /// Gets or sets the boolean value
                              /// </summary>
        public bool Value
#pragma warning restore SA1623 // Property summary documentation should match accessors
        {
            get
            {
                if (!this._innerValue.HasValue)
                {
                    // Because TrueFalseBlankValue allows text value to emtpy string,
                    // here it has to user TextValue != null rather than
                    // if (!String.IsNullOrEmpty(this.TextValue))
                    if (this.TextValue != null)
                    {
                        Parse();
                    }
                }
                else
                {
                    Debug.Assert(this.TextValue == null ||
                                 _getBooleanValueMethod(this.TextValue) == this._innerValue.Value);
                }
                return this._innerValue.Value;
            }

            set
            {
                this._innerValue = value;
                this.TextValue = null;
            }
        }

        internal override void Parse()
        {
            this._innerValue = _getBooleanValueMethod(this.TextValue);
        }

        internal override bool TryParse()
        {
            Boolean value;
            this._innerValue = null;

            try
            {
                value = _getBooleanValueMethod(this.TextValue);
                this._innerValue = value;
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        /// <summary>
        /// Not implemented by <see cref="TrueFalseValueImpl"/>.
        /// </summary>
        /// <returns></returns>
        private protected override OpenXmlSimpleType CloneImpl() => throw new NotImplementedException();
    }
}
