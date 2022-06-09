// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Generator.Models;

public class Validator
{
    public IEnumerable<Argument> Arguments { get; set; } = Enumerable.Empty<Argument>();

    public QName? Type { get; set; }

    public bool IsList { get; set; }

    public string Name { get; set; } = null!;

    public OfficeVersion? Version { get; set; }

    public int? UnionId { get; set; }

    public bool IsInitialVersion { get; set; }
}
