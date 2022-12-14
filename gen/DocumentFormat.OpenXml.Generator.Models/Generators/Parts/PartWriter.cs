// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Generator.Editor;
using DocumentFormat.OpenXml.Generator.Models;
using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Generator.Generators.Parts;

public static class PartWriter
{
    private static readonly HashSet<string> ParameterlessTypes = new()
    {
        "CustomXmlPart",
        "CustomPropertyPart",
        "EmbeddedControlPersistenceBinaryDataPart",
    };

    private static readonly string[] _usings = new[]
    {
        "DocumentFormat.OpenXml.Features",
        "DocumentFormat.OpenXml.Framework",
        "System",
        "System.Collections.Generic",
    };

    private static readonly BlockOptions _options = new()
    {
        IncludeTrailingNewline = false,
    };

    public static void WritePart(this IndentedTextWriter writer, OpenXmlGeneratorServices services, Part type)
    {
        var items = new List<Item>();

        foreach (var @using in _usings)
        {
            writer.Write("using ");
            writer.Write(@using);
            writer.WriteLine(";");
        }

        writer.WriteLine();

        writer.WriteLine("namespace DocumentFormat.OpenXml.Packaging");
        using (writer.AddBlock(_options with { AddNewLineBeforeClosing = true }))
        {
            writer.WriteDocumentationComment($"Defines the {type.Name}");
            writer.Write("public partial class ");
            writer.Write(type.Name);

            if (!type.IsPackage)
            {
                writer.Write(" : ");
                writer.Write(type.Base);
            }

            if (type.HasFixedContent)
            {
                writer.Write(", IFixedContentTypePart");
            }

            writer.WriteLine();
            using (writer.AddBlock(_options with { AddNewLineBeforeClosing = true }))
            {
                if (!type.IsPackage)
                {
                    var newLine = false;

                    foreach (var member in GetMembers(services, type))
                    {
                        if (newLine)
                        {
                            if (member.Type != ItemType.Field)
                            {
                                writer.WriteDoubleLines();
                            }
                            else
                            {
                                writer.WriteLine();
                            }
                        }

                        member.Action(writer);

                        newLine = true;
                    }

                    writer.WriteLine();
                    writer.WriteLine();

                    writer.WriteLine("/// <inheritdoc/>");
                    writer.WriteLine("public override IFeatureCollection Features => _features ??= new GeneratedFeatures(this);");
                    writer.WriteLine();
                }

                var impls = new List<(string, Action<IndentedTextWriter, OpenXmlGeneratorServices, Part>)>();

                if (type.IsPackage)
                {
                    writer.Write("private partial class ");
                    writer.Write(type.Name);
                    writer.Write("Features");
                }
                else
                {
                    impls.Add(("TypedPartFeatureCollection", (writer, _, _) => writer.WriteLine("public GeneratedFeatures(OpenXmlPart part) : base(part) { }")));
                    writer.Write("private sealed class GeneratedFeatures");
                }

                if (!type.IsPackage)
                {
                    impls.Add(("ITargetFeature", WriteTargetPaths));
                }

                if (type.GetPartConstraints().Any())
                {
                    impls.Add(("IPartConstraintFeature", WritePartConstraints));
                }

                if (type.GetDataPartConstraints().Any())
                {
                    impls.Add(("IKnownDataPartFeature", WriteDataPartConstraints));
                }

                var count = 0;
                foreach (var (interfaceName, _) in impls)
                {
                    if (count == 0)
                    {
                        writer.Write(" : ");
                    }
                    else
                    {
                        writer.Write(", ");
                    }

                    writer.Write(interfaceName);

                    count++;
                }

                writer.WriteLine();

                using (writer.AddBlock())
                {
                    if (!type.IsPackage)
                    {
                    }

                    foreach (var (_, a) in impls)
                    {
                        a(writer, services, type);
                    }
                }
            }
        }

        writer.WriteLine();
    }

    private static void WriteDataPartConstraints(this IndentedTextWriter writer, OpenXmlGeneratorServices services, Part part)
    {
        writer.Write("bool IKnownDataPartFeature.IsKnown(string relationshipId) => relationshipId is ");

        var hit = false;
        foreach (var p in part.GetDataPartConstraints())
        {
            if (hit)
            {
                writer.Write(" or ");
            }

            hit = true;

            writer.Write(p.Name);
            writer.Write(".RelationshipTypeConst");
        }

        writer.WriteLine(";");
    }

    private static void WritePartConstraints(this IndentedTextWriter writer, OpenXmlGeneratorServices services, Part type)
    {
        writer.WriteLine("private static readonly PartConstraints _partConstraints = new ()");

        using (writer.AddBlock(new BlockOptions() { IncludeSemiColon = true }))
        {
            foreach (var c in type.GetPartConstraints())
            {
                var p = services.GetPart(c.Name);

                writer.Write("{ ");
                writer.WriteString(p.RelationshipType);
                writer.Write(", ");
                writer.WriteString(p.Name);
                writer.Write(", ");
                writer.WriteString(p.ContentType);
                writer.Write(", ");
                writer.WriteBool(c.MinOccursIsNonZero);
                writer.Write(", ");
                writer.WriteBool(c.MaxOccursGreatThanOne);
                writer.Write(", ");
                writer.WriteEnum("FileFormatVersions", p.Version);
                writer.WriteLine(" },");
            }
        }

        writer.WriteLine("bool IPartConstraintFeature.TryGetRule(string relationshipId, out PartConstraintRule rule) => _partConstraints.TryGetRule(relationshipId, out rule);");

        writer.WriteLine("IEnumerable<PartConstraintRule> IPartConstraintFeature.Rules => _partConstraints.Rules;");
    }

    private static IEnumerable<Item> GetMembers(OpenXmlGeneratorServices services, Part type)
     => BuildMembers(services, type)
         .SelectMany(i => i)
         .Where(i => i != null)
         .OrderBy(i => i!.Type)
         .ThenBy(i => i!.Name)!;

    private static IEnumerable<IEnumerable<Item?>> BuildMembers(OpenXmlGeneratorServices services, Part type)
    {
        yield return GetConstants(type);
        yield return GetConstructors(type);
        yield return GetStronglyTypedProperties(type);
        yield return GetTypedPartProperties(type);
        yield return GetAddPartMethods(type);
        yield return GetInVersionMethod(type);
        yield return GetSchemaTypedParts(services, type);
    }

    private static IEnumerable<Item> GetConstants(Part type)
    {
        if (type.ContentType is not null)
        {
            yield return new(ItemType.Field, "ContentTypeConstant", writer =>
            {
                writer.Write("internal const string ContentTypeConstant = ");
                writer.WriteItem(type.ContentType);
                writer.Write(";");
            });
        }

        if (type.RelationshipType is not null)
        {
            yield return new(ItemType.Field, "Relationship", writer =>
            {
                writer.Write("internal const string RelationshipTypeConstant = ");
                writer.WriteItem(type.RelationshipType);
                writer.Write(";");
            });
        }
    }

    private static void WriteTargetPaths(IndentedTextWriter writer, OpenXmlGeneratorServices services, Part type)
    {
        if (type.Extension is not null)
        {
            writer.Write("string ITargetFeature.Extension => ");
            writer.WriteString(type.Extension);
            writer.WriteLine(";");
        }

        if (type.Target is not null)
        {
            writer.Write("string ITargetFeature.Name => ");
            writer.WriteString(type.Target);
            writer.WriteLine(";");
        }

        var types = new List<(string, string)>();

        if (type.Paths.Word is { } word)
        {
            types.Add(("Word", word));
        }

        if (type.Paths.Excel is { } excel)
        {
            types.Add(("Excel", excel));
        }

        if (type.Paths.PowerPoint is { } ppt)
        {
            types.Add(("PowerPoint", ppt));
        }

        if (types.Count == 0)
        {
            if (type.Paths.General is { } general && general != ".")
            {
                writer.Write("string ITargetFeature.Path => ");
                writer.WriteString(general);
                writer.WriteLine(";");
            }
        }
        else
        {
            writer.WriteLine("string ITargetFeature.Path => (Get<IApplicationTypeFeature>()?.Type ?? ApplicationType.None) switch");

            using (writer.AddBlock(new() { IncludeSemiColon = true }))
            {
                foreach (var item in types)
                {
                    writer.Write("ApplicationType.");
                    writer.Write(item.Item1);
                    writer.Write(" => ");
                    writer.WriteString(item.Item2);
                    writer.WriteLine(",");
                }

                if (type.Paths.General is { } general)
                {
                    writer.Write("_ => ");
                    writer.WriteString(general);
                    writer.WriteLine(",");
                }
                else
                {
                    writer.Write("_ => \".\",");
                }
            }
        }
    }

    private static IEnumerable<Item> GetStronglyTypedProperties(Part type)
    {
        if (type.ContentType is not null)
        {
            yield return new(ItemType.Property, "ContentTypeConstant", writer =>
            {
                writer.WriteInheritDoc();
                writer.Write("public sealed override string ContentType => ContentTypeConstant;");
            });
        }

        if (type.RelationshipType is not null)
        {
            yield return new(ItemType.Property, "RelationshipType", writer =>
            {
                writer.WriteInheritDoc();
                writer.Write("public sealed override string RelationshipType => RelationshipTypeConstant;");
            });
        }
    }

    private static IEnumerable<Item> GetSchemaTypedParts(OpenXmlGeneratorServices services, Part type)
    {
        if (!services.TryGetPartClassName(type.Root, type.RootElement, out var api))
        {
            yield break;
        }

        var apiName = $"{api.Namespace}.{api.Class}";

        yield return new(ItemType.Field, "root", writer =>
        {
            writer.Write("private ");
            writer.Write(apiName);
            writer.Write("? _rootElement;");
        });

        yield return new(ItemType.Property, "InternalRootElement", writer =>
        {
            writer.WriteLine("private protected override OpenXmlPartRootElement? InternalRootElement");
            using (writer.AddBlock(_options))
            {
                using (writer.AddPropertyAccessor("get", _options))
                {
                    writer.WriteLine("return _rootElement;");
                }

                writer.WriteLineNoTabs();
                writer.WriteLine();

                using (writer.AddPropertyAccessor("set", _options))
                {
                    writer.Write("_rootElement = value as ");
                    writer.Write(apiName);
                    writer.WriteLine(";");
                }

                writer.WriteLine();
            }
        });

        yield return new(ItemType.Property, "PartRootElement", writer =>
        {
            writer.Write("internal override OpenXmlPartRootElement? PartRootElement => ");
            writer.Write(api.Class);
            writer.Write(";");
        });

        yield return new(ItemType.Property, api.Class, writer =>
        {
            writer.WriteDocumentationComment("Gets or sets the root element of this part.");
            writer.Write("public ");
            writer.Write(apiName);
            writer.Write(" ");
            writer.WriteLine(api.Class);

            using (writer.AddBlock(_options))
            {
                using (writer.AddPropertyAccessor("get", _options))
                {
                    writer.WriteLine("if (_rootElement is null)");

                    using (writer.AddBlock(_options))
                    {
                        writer.Write("LoadDomTree<");
                        writer.Write(apiName);
                        writer.WriteLine(">();");
                    }

                    writer.WriteLineNoTabs();
                    writer.WriteLine();
                    writer.WriteLine("return _rootElement!;");
                }

                writer.WriteLineNoTabs();
                writer.WriteLine();

                using (writer.AddPropertyAccessor("set", _options))
                {
                    writer.WriteLine("if (value is null)");

                    using (writer.AddBlock(_options))
                    {
                        writer.WriteLine("throw new ArgumentNullException(nameof(value));");
                    }

                    writer.WriteLineNoTabs();
                    writer.WriteLine();
                    writer.WriteLine("SetDomTree(value);");
                }

                writer.WriteLine();
            }
        });
    }

    private static IEnumerable<Item> GetInVersionMethod(Part type)
    {
        if (type.Version == OfficeVersion.Office2007)
        {
            yield break;
        }

        yield return new(ItemType.Method, "IsInVersion", writer =>
        {
            writer.WriteLine("internal override bool IsInVersion(FileFormatVersions version)");

            using (writer.AddBlock(_options))
            {
                writer.Write("return version.AtLeast(FileFormatVersions.");
                writer.Write(type.Version);
                writer.WriteLine(");");
            }
        });
    }

    private static IEnumerable<Item> GetTypedPartProperties(Part type) => type.Children
        .Where(i => !i.IsDataPartReference)
        .Select(p =>
        {
            var (returnType, expression) = p.MaxOccursGreatThanOne
                ? ($"IEnumerable<{p.Name}>", $"GetPartsOfType<{p.Name}>()")
                : (p.Name + "?", $"GetSubPartOfType<{p.Name}>()");

            return new Item(ItemType.Property, p.ApiName, writer =>
            {
                writer.WriteDocumentationComment($"Gets the {p.ApiName} of the {type.Name}");
                writer.Write("public ");
                writer.Write(returnType);
                writer.Write(" ");
                writer.Write(p.ApiName);
                writer.Write(" => ");
                writer.Write(expression);
                writer.Write(";");
            });
        });

    private static IEnumerable<Item> GetConstructors(Part type)
    {
        yield return new(ItemType.Constructor, string.Empty, writer =>
        {
            writer.WriteDocumentationComment($"Creates an instance of the {type.Name} OpenXmlType");
            writer.Write("internal protected ");
            writer.Write(type.Name);
            writer.WriteLine("()");
            writer.WriteLine("{");
            writer.Write("}");
        });
    }

    private static IEnumerable<Item> GetAddPartMethods(Part type)
    {
        IEnumerable<Item> CreatePartMethods(PartChild p)
        {
            if (p.IsDataPartReference)
            {
                yield return new Item(ItemType.Method, $"Add{p.Name}", writer => GenerateAddPartMethod(writer, type, p, AddPartParameter.MediaDataPart, false));
                yield return new Item(ItemType.Method, $"Add{p.Name}", writer => GenerateAddPartMethod(writer, type, p, AddPartParameter.MediaDataPart, true));
            }
            else if (p.IsSpecialEmbeddedPart)
            {
                yield return new Item(ItemType.Method, $"Add{p.Name}", writer => GenerateAddPartMethod(writer, type, p, AddPartParameter.ContentType, false));
            }
            else
            {
                yield return new Item(ItemType.Method, $"Add{p.Name}", writer => GenerateAddPartMethod(writer, type, p, AddPartParameter.ContentType, false));
                yield return new Item(ItemType.Method, $"Add{p.Name}", writer => GenerateAddPartMethod(writer, type, p, AddPartParameter.ContentType, true));
                yield return new Item(ItemType.Method, $"Add{p.Name}", writer => GenerateAddPartMethod(writer, type, p, AddPartParameter.PartType, true));
                yield return new Item(ItemType.Method, $"Add{p.Name}", writer => GenerateAddPartMethod(writer, type, p, AddPartParameter.PartType, false));
            }
        }

        return type.Children
            .Where(p => !p.HasFixedContent)
            .SelectMany(CreatePartMethods);
    }

    private enum AddPartParameter
    {
        ContentType,
        PartType,
        MediaDataPart,
    }

    private static void GenerateAddPartMethod(IndentedTextWriter writer, Part type, PartChild p, AddPartParameter partParameter, bool hasId)
    {
        const string ContentTypeParameterName = "contentType";
        const string MediaPartParameterName = "mediaDataPart";
        const string PartTypeParameterName = "partType";
        const string IdParameterName = "id";
        const string ChildPartLocalVariable = "childPart";
        const string PartExtensionLocalVariable = "partExtension";

        writer.WriteDocumentationComment(new DocumentCommentOptions
        {
            Summary = $"Adds a {p.Name} to the {type.Name}",
            Parameters = GetParameters(),
            Return = "The newly added part",
        });

        Parameters GetParameters()
        {
            var parameterComments = new Parameters();

            if (partParameter == AddPartParameter.ContentType)
            {
                parameterComments.Add(ContentTypeParameterName, $"The content type of the {p.Name}");
            }

            if (partParameter == AddPartParameter.MediaDataPart)
            {
                parameterComments.Add(MediaPartParameterName, $"The part type of the {p.Name}");
            }

            if (partParameter == AddPartParameter.PartType)
            {
                parameterComments.Add(PartTypeParameterName, $"The part type of the {p.Name}");
            }

            if (hasId)
            {
                parameterComments.Add(IdParameterName, "The relationship id");
            }

            return parameterComments;
        }

        writer.Write("public ");
        writer.Write(p.Name);
        writer.Write(" Add");
        writer.Write(p.Name);
        writer.Write("(");

        if (partParameter == AddPartParameter.ContentType)
        {
            writer.Write("string " + ContentTypeParameterName);
        }
        else if (partParameter == AddPartParameter.MediaDataPart)
        {
            writer.Write("MediaDataPart " + MediaPartParameterName);
        }
        else if (partParameter == AddPartParameter.PartType)
        {
            writer.Write(p.Name);
            writer.Write("Type " + PartTypeParameterName);
        }

        if (hasId)
        {
            writer.Write(", string " + IdParameterName);
        }

        writer.WriteLine(")");

        using (writer.AddBlock(_options))
        {
            if (partParameter == AddPartParameter.ContentType)
            {
                writer.Write("var " + ChildPartLocalVariable + " = new ");
                writer.Write(p.Name);
                writer.WriteLine("();");

                writer.Write("InitPart(" + ChildPartLocalVariable + ", ");
                writer.Write(ContentTypeParameterName);

                if (hasId)
                {
                    writer.Write(", ");
                    writer.Write(IdParameterName);
                }

                writer.WriteLine(");");

                writer.WriteLine("return " + ChildPartLocalVariable + ";");
            }

            if (partParameter == AddPartParameter.MediaDataPart)
            {
                writer.Write($"return AddDataPartReferenceRelationship<{p.Name}>(");
                writer.Write(MediaPartParameterName);

                if (hasId)
                {
                    writer.Write(", id");
                }

                writer.WriteLine(");");
            }

            if (partParameter == AddPartParameter.PartType)
            {
                writer.WriteLine("var " + ContentTypeParameterName + " = " + $"{p.Name}TypeInfo.GetContentType({PartTypeParameterName});");

                writer.Write("var " + PartExtensionLocalVariable + " = " + $"{p.Name}TypeInfo.GetTargetExtension(");
                if (!ParameterlessTypes.Contains(p.Name))
                {
                    writer.Write(PartTypeParameterName);
                }

                writer.WriteLine(");");

                writer.WriteLine("OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);");
                writer.Write($"return Add{p.Name}({ContentTypeParameterName}");

                if (hasId)
                {
                    writer.Write(", id");
                }

                writer.WriteLine(");");
            }
        }
    }
}
