// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.ComponentModel;

namespace DocumentFormat.OpenXml.Office2013.Word
{
    public partial class Person : OpenXmlCompositeElement
    {
        /// <summary>
        /// Gets or sets the <see cref="Contact"/> value. It is only available for backwards compatibility
        /// until the next major version change. Please discontinue using this property.
        /// </summary>
        [Obsolete("This property will be removed in a future version")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public StringValue? Contact
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }
    }
}
