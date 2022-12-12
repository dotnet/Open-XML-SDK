// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Packaging
{
    internal struct RelationshipProperty
    {
        internal string Id;
        internal string RelationshipType;
        internal TargetMode TargetMode;
        internal Uri TargetUri;
    }
}
