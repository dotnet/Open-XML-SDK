// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace DocumentFormat.OpenXml.Features;

internal interface IPartRelationshipsFeature : IEnumerable<KeyValuePair<string, OpenXmlPart>>
{
    /// <summary>
    /// Adds a part to the relationship collection. If an <paramref name="id"/> is provided, it will be used, otherwise a random id will be generated.
    /// </summary>
    /// <param name="part">Part to add to relationship collection.</param>
    /// <param name="id">Id of part if supplied.</param>
    void Add(OpenXmlPart part, string? id = null);

    bool Contains(string id);

    bool Contains(OpenXmlPart part);

    int Count { get; }

    IEnumerable<OpenXmlPart> Parts { get; }

    void Remove(string id);

    void Clear();

    bool TryGetPart(string id, [MaybeNullWhen(false)] out OpenXmlPart part);
}
