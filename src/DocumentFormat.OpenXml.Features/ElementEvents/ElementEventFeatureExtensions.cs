﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;

namespace DocumentFormat.OpenXml.Features
{
    internal static class ElementEventFeatureExtensions
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Reliability", "CA2000:Dispose objects before losing scope", Justification = "Regsitered for disposal")]
        public static void AddElementEventFeature(this OpenXmlPackage package)
        {
            if (package.Features.Get<IElementEventFeature>() is null)
            {
                package.AddPartRootEventsFeature();

                var rootEvent = package.Features.GetRequired<IPartRootEventsFeature>();

                package.Features.SetDisposable<IElementEventFeature>(new ElementEventFeature(rootEvent));
            }
        }
    }
}
