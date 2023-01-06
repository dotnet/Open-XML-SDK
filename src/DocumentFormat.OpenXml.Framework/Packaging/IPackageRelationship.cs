// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.IO.Packaging;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable SA1649 // File name should match first type name
#pragma warning disable SA1402 // File may only contain a single type

namespace DocumentFormat.OpenXml.Packaging
{
    public interface IPackageRelationship
    {
        public string Id { get; }

        public IPackage Package { get; }

        public string RelationshipType { get; }

        public Uri SourceUri { get; }

        public TargetMode TargetMode { get; }

        public Uri TargetUri { get; }
    }
}
