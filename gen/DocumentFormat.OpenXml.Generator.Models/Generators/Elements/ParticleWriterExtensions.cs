// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Generator.Editor;
using DocumentFormat.OpenXml.Generator.Models;
using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Generator.Generators.Elements;

internal static class ParticleWriterExtensions
{
    public static void WriteParticle(this IndentedTextWriter writer, OpenXmlGeneratorServices services, SchemaType containingType, Particle particle)
    {
        writer.WriteItemNode(services, containingType, particle);
    }

    private static void WriteArgumentList(this IndentedTextWriter writer, Particle p, ParticleVersion v, Action<IndentedTextWriter>? arg = null)
    {
        var args = writer.TrackDelimiter();

        if (arg != null)
        {
            args.AddDelimiter();
            arg(writer);
        }

        args.AddDelimiter();
        writer.Write(v.Min);

        args.AddDelimiter();
        writer.Write(v.Max);

        if (v.IncludeVersion)
        {
            args.AddDelimiter();
            writer.Write("version: FileFormatVersions.");
            writer.Write(v.Version);
        }
        else if (p.InitialVersion != OfficeVersion.Office2007)
        {
            args.AddDelimiter();
            writer.Write("version: FileFormatVersions.");
            writer.Write(p.InitialVersion);
        }

        if (p.RequireFilter)
        {
            args.AddDelimiter();
            writer.Write("requireFilter: true");
        }
    }

    private static void WriteCompositeObject(this IndentedTextWriter writer, OpenXmlGeneratorServices services, SchemaType containingType, string type, Particle p)
    {
        writer.WriteObject("CompositeParticle.Builder", p, w => w.Write($"ParticleType.{type}"), block: writer =>
        {
            using (writer.AddBlock(new() { IncludeTrailingNewline = false }))
            {
                var list = writer.TrackDelimiter(newLineCount: 1);

                foreach (var item in p.Items)
                {
                    list.AddDelimiter();
                    writer.WriteItemNode(services, containingType, item);
                }

                writer.WriteLine();
            }
        });
    }

    private static void WriteObject(this IndentedTextWriter writer, string name, Particle p, Action<IndentedTextWriter>? arg = null, Action<IndentedTextWriter>? block = null)
    {
        var list = writer.TrackDelimiter(newLineCount: 1);

        foreach (var info in p.Occurs)
        {
            list.AddDelimiter();

            writer.Write("new ");
            writer.Write(name);
            writer.Write("(");
            writer.WriteArgumentList(p, info, arg);
            writer.Write(")");

            if (block is not null)
            {
                writer.WriteLine();
                block(writer);
            }
        }
    }

    private static void WriteItemNode(this IndentedTextWriter writer, OpenXmlGeneratorServices services, SchemaType containingType, Particle particle)
    {
        if (particle.Kind == ParticleType.Element)
        {
            var info = services.FindClassName(particle.Name);
            writer.WriteObject("ElementParticle", particle, w => w.WriteItem(new TypeOf(info)));
        }
        else if (particle.Kind == ParticleType.Any)
        {
            static void WriteNamespace(IndentedTextWriter writer, string ns)
            {
                var xsd = ns switch
                {
                    "##local" => "XsdAny.Local",
                    "##any" => "XsdAny.Any",
                    "##other" => "XsdAny.Other",
                    "##targetNamespace" => "XsdAny.TargetNamespace",
                    _ => null,
                };

                if (xsd is null)
                {
                    writer.WriteItem(ns);
                }
                else
                {
                    writer.Write(xsd);
                }
            }

            if (particle.Namespace is null)
            {
                writer.WriteObject("AnyParticle", particle);
            }
            else
            {
                writer.WriteObject("AnyParticle", particle, arg: writer => WriteNamespace(writer, particle.Namespace));
            }
        }
        else if (particle.Kind == ParticleType.Choice)
        {
            writer.WriteCompositeObject(services, containingType, "Choice", particle);
        }
        else if (particle.Kind == ParticleType.Sequence)
        {
            writer.WriteCompositeObject(services, containingType, "Sequence", particle);
        }
        else if (particle.Kind == ParticleType.All)
        {
            writer.WriteCompositeObject(services, containingType, "All", particle);
        }
        else if (particle.Kind == ParticleType.Group)
        {
            writer.WriteCompositeObject(services, containingType, "Group", particle);
        }
        else
        {
            throw new InvalidOperationException();
        }
    }
}
