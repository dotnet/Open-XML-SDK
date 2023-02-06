// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using System;
using System.Diagnostics.CodeAnalysis;

namespace DocumentFormat.OpenXml.Features;

internal interface IPartsFeature
{
    bool TryGetPart(Uri uri, [MaybeNullWhen(false)] out OpenXmlPart part);

    void Add(Uri uri, OpenXmlPart part);

    bool Contains(Uri uri);
}
