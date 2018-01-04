// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Represents a customizable value for simple boolean types
    /// </summary>
    public abstract class TrueFalseValueBase : OpenXmlSimpleValue<bool>
    {
        private protected TrueFalseValueBase()
        {
        }

        private protected TrueFalseValueBase(bool value)
            : base(value)
        {
        }

        private protected TrueFalseValueBase(TrueFalseValueBase value)
            : base(value)
        {
        }

        /// <inheritdoc/>
        public override string InnerText
        {
            get
            {
                // it returns the real inner text such as "t", "f", "on", "off", etc,
                // rather than the Boolean.ToString() which is "True"/"False"
                if (this.TextValue == null && this.InnerValue.HasValue)
                {
                    this.TextValue = GetDefaultTextValue(this.InnerValue.Value);
                }
                return this.TextValue;
            }

            set
            {
                this.TextValue = value;
                this.InnerValue = null;
            }
        }

        private protected abstract string GetDefaultTextValue(bool input);

        private protected override bool ShouldParse(string value) => value != null;
    }
}
