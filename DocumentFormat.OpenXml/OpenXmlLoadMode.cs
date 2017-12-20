// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// OpenXmlLoadMode - load mode, default is Lazy
    ///     Full - load all the OpenXmlElements recursively
    ///     Lazy (default) - load N layer descendant elements from the current element, lazy load (cache OuterXml) for others
    ///             default is populate 3 layers
    /// </summary>
    internal enum OpenXmlLoadMode
    {
        /// <summary>
        /// Load all the OpenXmlElements recursively
        /// </summary>
        Full,

        /// <summary>
        /// Load only one layer element, cache OuterXml
        /// </summary>
        Lazy,

        ///// <summary>
        ///// Full populate the top N layers, and then lazy load others.
        ///// </summary>
        //TopLayers
    }
}
