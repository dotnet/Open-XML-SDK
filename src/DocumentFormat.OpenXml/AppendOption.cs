// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.ComponentModel;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Options to define how an element should be appeneded.
    /// </summary>
    [Obsolete("This is not used and will be removed in a future version.")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public enum AppendOption
    {
        /// <summary>
        /// Append the item in list order without regard to schema.
        /// </summary>
        List = 0,

        /// <summary>
        /// Append the item in accordance with what the schema defines.
        /// </summary>
        Ordered = 1,
    }
}
