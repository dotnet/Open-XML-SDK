// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Generator.Models;

public class NamespaceInfo
{
    public string Prefix { get; set; } = null!;

    public string Uri { get; set; } = null!;

    public OfficeVersion Version { get; set; }
}
