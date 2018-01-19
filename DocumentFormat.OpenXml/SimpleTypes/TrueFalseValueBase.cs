// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

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

        private protected override bool ShouldParse(string value) => value != null;
    }
}
