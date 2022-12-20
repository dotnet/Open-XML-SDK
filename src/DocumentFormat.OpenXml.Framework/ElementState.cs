// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml
{
    internal enum ElementState
    {
        Null,
        Start,
        End,
        LeafStart,
        LeafEnd,
        LoadEnd,
        MiscNode,
        EOF,
    }
}
