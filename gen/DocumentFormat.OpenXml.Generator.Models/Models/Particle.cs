// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Generator.Models;

public class Particle
{
    private static readonly IEnumerable<ParticleVersion> _defaultOccurs = new[]
    {
        new ParticleVersion() { Max = 1, Min = 1 },
    };

    public bool RequireFilter { get; set; }

    public TypedQName Name { get; set; } = null!;

    public ParticleType Kind { get; set; }

    public string Namespace { get; set; } = null!;

    public IEnumerable<ParticleVersion> Occurs { get; set; } = _defaultOccurs;

    public OfficeVersion InitialVersion { get; set; }

    public IEnumerable<Particle> Items { get; set; } = Enumerable.Empty<Particle>();
}
