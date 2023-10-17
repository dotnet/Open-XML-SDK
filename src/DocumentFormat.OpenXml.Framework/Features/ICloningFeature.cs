// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;

namespace DocumentFormat.OpenXml.Features;

internal interface ICloningFeature<TPackage>
{
    void CopyParts(TPackage destination, OpenSettings? settings = null);
}
