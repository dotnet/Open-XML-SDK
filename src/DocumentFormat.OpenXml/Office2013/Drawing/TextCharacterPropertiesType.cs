// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.ComponentModel;

namespace DocumentFormat.OpenXml.Drawing
{
    public partial class TextCharacterPropertiesType
    {
        /// <summary>
        /// Gets or sets the <see cref="SmartTagClean"/> value. It is only available for backwards compatibility
        /// until the next major version change. The <see cref="SmartTagClean"/> property should be used instead.
        /// </summary>
        [Obsolete("Please use the property 'SmartTagClean' as this property will be removed in a future version")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public BooleanValue SmtClean
        {
            get => SmartTagClean;
            set => SmartTagClean = value;
        }

        /// <summary>
        /// Gets or sets the <see cref="SmartTagId"/> value. It is only available for backwards compatibility
        /// until the next major version change. The <see cref="SmartTagId"/> property should be used instead.
        /// </summary>
        [Obsolete("Please use the property 'SmartTagId' as this property will be removed in a future version")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public UInt32Value SmtId
        {
            get => SmartTagId;
            set => SmartTagId = value;
        }
    }
}
