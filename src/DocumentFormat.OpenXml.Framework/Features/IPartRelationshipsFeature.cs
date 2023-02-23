// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace DocumentFormat.OpenXml.Features;

internal interface IPartRelationshipsFeature : IEnumerable<KeyValuePair<string, OpenXmlPart>>
{
    void Add(string id, OpenXmlPart part);

    bool Contains(string id);

    bool Contains(OpenXmlPart part);

    int Count { get; }

    IEnumerable<OpenXmlPart> Parts { get; }

    void Remove(string id);

    void Clear();

    bool TryGetPart(string id, [MaybeNullWhen(false)] out OpenXmlPart part);
}
