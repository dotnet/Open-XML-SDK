// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

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
