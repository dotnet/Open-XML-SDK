// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

namespace DocumentFormat.OpenXml.Generator.Models;

public class NamespaceInfo
{
    public string Prefix { get; set; } = null!;

    public string Uri { get; set; } = null!;

    public OfficeVersion Version { get; set; }
}
