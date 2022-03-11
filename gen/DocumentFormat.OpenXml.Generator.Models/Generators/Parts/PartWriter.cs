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
            writer.WriteClassAttributes(type);
            writer.Write("public partial class ");
            writer.Write(type.Name);
            writer.Write(" : ");
            writer.Write(type.Base);

            if (type.HasFixedContent)
            {
                writer.Write(", IFixedContentTypePart");
            }

            writer.WriteLine();
            using (writer.AddBlock(_options with { AddNewLineBeforeClosing = true }))
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
            }
        }

        writer.WriteLine();
    }

    private static void WriteClassAttributes(this IndentedTextWriter writer, Part type)
    {
        if (type.Version != OfficeVersion.Office2007)
        {
            writer.Write("[OfficeAvailability(FileFormatVersions.");
            writer.Write(type.Version);
            writer.WriteLine(")]");
        }

        if (type.HasFixedContent)
        {
            writer.WriteLine("[ContentType(ContentTypeConstant)]");
        }

        writer.WriteLine("[RelationshipTypeAttribute(RelationshipTypeConstant)]");

        foreach (var constraint in type.GetPartConstraints())
        {
            writer.Write("[PartConstraint(");
            writer.WriteItem(new TypeOf(constraint.Name));
            writer.Write(", ");
            writer.WriteItem(constraint.MinOccursIsNonZero);
            writer.Write(", ");
            writer.WriteItem(constraint.MaxOccursGreatThanOne);
            writer.WriteLine(")]");
        }

        foreach (var constraint in type.GetDataPartConstraints())
        {
            writer.Write("[DataPartConstraint(");
            writer.WriteItem(new TypeOf(constraint.Name));
            writer.Write(", ");
            writer.WriteItem(constraint.MinOccursIsNonZero);
            writer.Write(", ");
            writer.WriteItem(constraint.MaxOccursGreatThanOne);
            writer.WriteLine(")]");
        }
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
        yield return new[] { GetCreatePartCoreMethod(type) };
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

        if (type.Extension is not null)
        {
            yield return new(ItemType.Property, "TargetFileExtension", writer =>
            {
                writer.WriteInheritDoc();
                writer.Write("internal sealed override string TargetFileExtension => ");
                writer.WriteItem(type.Extension);
                writer.Write(";");
            });
        }

        if (type.Name is not null)
        {
            yield return new(ItemType.Property, "TargetName", writer =>
            {
                writer.WriteInheritDoc();
                writer.Write("internal sealed override string TargetName => ");
                writer.WriteItem(type.Target);
                writer.Write(";");
            });
        }

        if (type.Paths.General is not null)
        {
            yield return new(ItemType.Property, "TargetPath", writer =>
            {
                writer.WriteInheritDoc();
                writer.Write("internal sealed override string TargetPath => ");
                writer.WriteItem(type.Paths.General);
                writer.Write(";");
            });
        }

        if (type.Paths.Excel is not null)
        {
            yield return new(ItemType.Property, "TargetPathOfExcel", writer =>
            {
                writer.WriteInheritDoc();
                writer.Write("internal sealed override string TargetPathOfExcel => ");
                writer.WriteItem(type.Paths.Excel);
                writer.Write(";");
            });
        }

        if (type.Paths.PowerPoint is not null)
        {
            yield return new(ItemType.Property, "TargetPathOfPPT", writer =>
            {
                writer.WriteInheritDoc();
                writer.Write("internal sealed override string TargetPathOfPPT => ");
                writer.WriteItem(type.Paths.PowerPoint);
                writer.Write(";");
            });
        }

        if (type.Paths.Word is not null)
        {
            yield return new(ItemType.Property, "TargetPathOfWord", writer =>
            {
                writer.WriteInheritDoc();
                writer.Write("internal sealed override string TargetPathOfWord => ");
                writer.WriteItem(type.Paths.Word);
                writer.Write(";");
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

    private static Item? GetCreatePartCoreMethod(Part type)
    {
        if (!type.Children.Any(d => !d.IsDataPartReference))
        {
            return null;
        }

        return new(ItemType.Method, "CreatepartCore", writer =>
        {
            writer.WriteInheritDoc();
            writer.WriteLine("internal sealed override OpenXmlPart CreatePartCore(string relationshipType)");

            using (writer.AddBlock(_options))
            {
                writer.WriteLine("ThrowIfObjectDisposed();");
                writer.WriteLine("if (relationshipType is null)");

                using (writer.AddBlock(_options))
                {
                    writer.WriteLine("throw new ArgumentNullException(nameof(relationshipType));");
                }

                writer.WriteLineNoTabs();
                writer.WriteLine();

                writer.WriteLine("switch (relationshipType)");
                using (writer.AddBlock(_options))
                {
                    foreach (var child in type.Children)
                    {
                        if (!child.IsDataPartReference)
                        {
                            writer.Write("case ");
                            writer.Write(child.Name);
                            writer.Write(".RelationshipTypeConstant:");
                            writer.Indent++;
                            writer.WriteLine();
                            writer.Write("return new ");
                            writer.Write(child.Name);
                            writer.Write("();");
                            writer.Indent--;
                            writer.WriteLine();
                        }
                    }
                }

                writer.WriteLineNoTabs();
                writer.WriteLine();

                writer.WriteLine("throw new ArgumentOutOfRangeException(nameof(relationshipType));");
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

    private static string GetConstantName(string name) => $"{name}Constant";
}
