// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Generator.Models;

namespace DocumentFormat.OpenXml.Generator.Schematron;

public class SchematronEntry
{
    public QName Context { get; set; } = null!;

    public string Test { get; set; } = string.Empty;

    public OfficeVersion Version { get; set; }

    public OfficeApplication App { get; set; }
}
