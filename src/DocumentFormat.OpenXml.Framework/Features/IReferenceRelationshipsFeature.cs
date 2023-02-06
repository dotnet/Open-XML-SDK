// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace DocumentFormat.OpenXml.Features;

internal interface IReferenceRelationshipsFeature
{
    bool Remove(string id);

    bool TryGetRelationship(string id, [MaybeNullWhen(false)] out ReferenceRelationship relationship);

    HyperlinkRelationship CreateHyperLink(Uri uri, bool isExternal, string? id = null);

    DataPartReferenceRelationship CreateDataPartRelationship(string relationshipType, DataPart dataPart, string? id = null);

    ExternalRelationship CreateExternalRelationship(string relationshipType, Uri externalUri, string? id = null);

    IEnumerable<ReferenceRelationship> Relationships { get; }
}
