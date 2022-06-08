// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using DocumentFormat.OpenXml.Packaging;

namespace DocumentFormat.OpenXml.Features
{
    /// <summary>
    /// A feature to track events around parts.
    /// </summary>
    public interface IPartRootEventsFeature : IFeatureEvent<OpenXmlPart>
    {
    }
}
