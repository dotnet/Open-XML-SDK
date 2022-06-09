// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Generator.Models;

internal class StronglyTypedType
{
    public QName Type { get; set; } = null!;

    public IEnumerable<StronglyTypedElement> Elements { get; set; } = Enumerable.Empty<StronglyTypedElement>();
}
