// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Generator.Models;

public class SchemaType
{
    public TypedQName Name { get; set; } = null!;

    public string Summary { get; set; } = null!;

    public bool IsPart => !string.IsNullOrEmpty(Part);

    public string Part { get; set; } = null!;

    public ParticleOrderType CompositeType { get; set; }

    public string BaseClass { get; set; } = null!;

    public bool IsAbstract { get; set; }

    public bool IsDerived { get; set; }

    public bool IsLeafText { get; set; }

    public bool IsLeafElement { get; set; }

    public OfficeVersion Version { get; set; }

    public IEnumerable<SchemaAttribute> Attributes { get; set; } = Enumerable.Empty<SchemaAttribute>();

    public IEnumerable<SchemaElement> Children { get; set; } = Enumerable.Empty<SchemaElement>();

    public IEnumerable<TypedQName> AdditionalElements { get; set; } = Enumerable.Empty<TypedQName>();

    public IEnumerable<TypedQName> KnownChildren => Elements
        .Select(e => e.Name)
        .Concat(AdditionalElements)
        .Distinct()
        .OrderBy(e => e.Type.Prefix)
        .ThenBy(e => e.Type.Name);

    public IEnumerable<Particle> Elements
    {
        get
        {
            var result = new List<Particle>();
            Fill(Particle, result);
            return result;

            static void Fill(Particle? p, List<Particle> list)
            {
                if (p is null)
                {
                    return;
                }

                foreach (var item in p.Items)
                {
                    if (item.Kind == ParticleType.Element)
                    {
                        list.Add(item);
                    }

                    Fill(item, list);
                }
            }
        }
    }

    public IEnumerable<Validator> Validators { get; set; } = Enumerable.Empty<Validator>();

    public Particle? Particle { get; set; }
}
