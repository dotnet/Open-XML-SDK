// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

namespace DocumentFormat.OpenXml.Generator.Models;

internal class StronglyTypedType
{
    public QName Type { get; set; } = null!;

    public IEnumerable<StronglyTypedElement> Elements { get; set; } = Enumerable.Empty<StronglyTypedElement>();
}
