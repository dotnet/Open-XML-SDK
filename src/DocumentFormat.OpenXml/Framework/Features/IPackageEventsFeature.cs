// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using System;

namespace DocumentFormat.OpenXml.Framework.Features
{
    /// <summary>
    /// A feature to track events around the package.
    /// </summary>
    public interface IPackageEventsFeature : IFeatureEvent<OpenXmlPackage>
    {
    }
}
