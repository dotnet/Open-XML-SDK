// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Options to define how an element should be appeneded.
    /// </summary>
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
