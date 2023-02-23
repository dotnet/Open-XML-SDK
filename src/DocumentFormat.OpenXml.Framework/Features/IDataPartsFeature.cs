// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace DocumentFormat.OpenXml.Features;

internal interface IDataPartsFeature
{
    bool TryGetDataPart(Uri uri, [MaybeNullWhen(false)] out DataPart dataPart);

    void Add(DataPart dataPart);

    int Count { get; }

    bool Remove(DataPart dataPart);

    IEnumerable<DataPart> Parts { get; }
}
