// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging.Builder;
using System;

namespace DocumentFormat.OpenXml.Features;

internal interface IRelationshipFilterFeature
{
    void AddFilter(Action<PackageRelationshipBuilder> action);
}
