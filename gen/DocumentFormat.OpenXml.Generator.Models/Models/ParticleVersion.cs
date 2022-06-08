// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

namespace DocumentFormat.OpenXml.Generator.Models;

public class ParticleVersion
{
    public int Min { get; set; }

    public int Max { get; set; }

    public bool IncludeVersion { get; set; }

    public OfficeVersion Version { get; set; }
}
