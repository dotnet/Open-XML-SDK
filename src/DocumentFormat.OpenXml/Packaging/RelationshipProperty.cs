// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

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
