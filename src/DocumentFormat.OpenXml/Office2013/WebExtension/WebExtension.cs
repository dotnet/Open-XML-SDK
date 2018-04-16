// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml.Office2013.WebExtension
{
    public partial class WebExtension
    {
        /// <summary>
        /// Gets or sets the <see cref="Frozen"/> value. It is only available for backwards compatibility
        /// until the next major version change. The <see cref="Frozen"/> property should be used instead.
        /// </summary>
        [Obsolete("Please use the property 'Frozen' as this property will be removed in a future version")]
        public BooleanValue Fronzen
        {
            get => Frozen;
            set => Frozen = value;
        }
    }
}
