// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace DocumentFormat.OpenXml.Features;

internal interface IChildPartFeatures : IEnumerable<KeyValuePair<string, OpenXmlPart>>
{
    void Add(string uri, OpenXmlPart part);

    bool Contains(string uri);

    bool Contains(OpenXmlPart part);

    int Count { get; }

    IEnumerable<OpenXmlPart> Parts { get; }

    void Remove(string uri);

    void Clear();

    bool TryGetPart(string uri, [MaybeNullWhen(false)] out OpenXmlPart part);
}
