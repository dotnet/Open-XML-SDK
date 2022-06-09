// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Generator.Models;

public class ParticleVersion
{
    public int Min { get; set; }

    public int Max { get; set; }

    public bool IncludeVersion { get; set; }

    public OfficeVersion Version { get; set; }
}
