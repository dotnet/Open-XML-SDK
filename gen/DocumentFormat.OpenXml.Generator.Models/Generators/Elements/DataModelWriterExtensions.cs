// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Generator.Editor;
using DocumentFormat.OpenXml.Generator.Models;
using DocumentFormat.OpenXml.Generator.Schematron;
using System.CodeDom.Compiler;
using System.Text;

namespace DocumentFormat.OpenXml.Generator.Generators.Elements;

public static class DataModelWriterExtensions
{
    public static bool GetDataModelSyntax(this IndentedTextWriter writer, OpenXmlGeneratorServices services, SchemaNamespace model)
    {
        foreach (var ns in GetNamespaces(model, services).Distinct().OrderBy(n => n))
        {
            writer.Write("using ");
            writer.Write(ns);
            writer.WriteLine(";");
        }

        writer.WriteLine();

        writer.Write("namespace ");
        writer.WriteLine(services.GetNamespaceApi(model.TargetNamespace));

        var delimiter = writer.TrackDelimiter(separator: string.Empty, newLineCount: 2);

        using (writer.AddBlock(new() { AddNewLineBeforeClosing = true, IncludeTrailingNewline = false }))
        {
            foreach (var type in model.Types)
            {
                // TODO: remove them if this line:
                //  <xsd:element name="openxmlsdk_49BECFFA_3B03_4D13_8272_D6CCB22579E3" type="xsd:unsignedInt" />
                // is removed from O16Path_V30.xml
                if (type.Name.QName.Name == "openxmlsdk_49BECFFA_3B03_4D13_8272_D6CCB22579E3")
                {
                    continue;
                }

                delimiter.AddDelimiter();
                writer.WriteType(services, type);
            }

            foreach (var @enum in model.Enums)
            {
                delimiter.AddDelimiter();
                writer.WriteEnumType(@enum);
            }
        }

        return delimiter.Count > 0;
    }

    private static void WriteType(this IndentedTextWriter writer, OpenXmlGeneratorServices services, SchemaType element)
    {
        writer.WriteDocumentationComment(BuildTypeComments(services, element));
        writer.WriteSchemaAttribute(element.Name.QName);
        writer.Write("public ");

        if (element.IsAbstract)
        {
            writer.Write("abstract ");
        }

        var className = services.FindClassName(element.Name, fullyQualified: false);

        writer.Write("partial class ");
        writer.Write(className);
        writer.Write(" : ");
        writer.WriteLine(element.IsPart ? "OpenXmlPartRootElement" : element.BaseClass);

        using (writer.AddBlock(new() { AddNewLineBeforeClosing = true, IncludeTrailingNewline = false }))
        {
            var delimiter = writer.TrackDelimiter(separator: string.Empty, newLineCount: 2);

            delimiter.AddDelimiter();
            writer.WriteDocumentationComment($"Initializes a new instance of the {className} class.");
            writer.Write(element.GetAccessibility());
            writer.Write(" ");
            writer.Write(className);
            writer.WriteLine("() : base()");

            using (writer.AddBlock(new() { IncludeTrailingNewline = false }))
            {
            }

            writer.WriteConstructors(services, element, ref delimiter);

            foreach (var attribute in element.Attributes)
            {
                delimiter.AddDelimiter();
                writer.WriteAttributeProperty(services, attribute);
            }

            delimiter.AddDelimiter();
            writer.WriteMetadata(services, element);

            if (!(element.IsDerived || element.CompositeType == ParticleOrderType.Other))
            {
                foreach (var node in element.Children)
                {
                    writer.WriteElement(services, element, node, ref delimiter);
                }
            }

            if (!element.IsAbstract)
            {
                delimiter.AddDelimiter();
                writer.WriteInheritDoc();
                writer.Write("public override OpenXmlElement CloneNode(bool deep) => CloneImp<");
                writer.Write(className);
                writer.Write(">(deep);");
            }

            if (element.IsPart)
            {
                writer.GetPartLoadMethods(element, className, ref delimiter);
            }
        }

        static DocumentCommentOptions BuildTypeComments(OpenXmlGeneratorServices services, SchemaType element)
        {
            var list = new List<string>();

            foreach (var child in element.KnownChildren)
            {
                var name = services.FindClassName(child);
                list.Add($"<description><see cref=\"{name}\" /> <c>&lt;{child.QName}></c></description>");
            }

            var paragraphs = list.Count == 0 ? null : new Paragraphs
            {
                "The following table lists the possible child types:",
                list,
            };

            return new DocumentCommentOptions
            {
                Summary = new Paragraphs
                {
                    element.Summary,
                    $"This class is available in {element.Version.ToFormattedString()} and above.",
                    $"When the object is serialized out as xml, it's qualified name is {element.Name.QName.Prefix}:{element.Name.QName.Name}.",
                },
                Remarks = paragraphs,
                TrailingNewLineTabs = false,
            };
        }
    }

    private static void WriteMetadata(this IndentedTextWriter writer, OpenXmlGeneratorServices services, SchemaType containingType)
    {
        var attributes = containingType.Attributes;

        writer.WriteLine("internal override void ConfigureMetadata(ElementMetadata.Builder builder)");

        using (writer.AddBlock(new() { IncludeTrailingNewline = false }))
        {
            writer.WriteLine("base.ConfigureMetadata(builder);");

            foreach (var v in containingType.Validators)
            {
                writer.Write("builder.AddValidator");

                if (v.Type is not null)
                {
                    writer.Write("<");
                    writer.Write(services.GetSimpleType(v.Type, v.IsList));
                    writer.Write(">");
                }

                writer.Write("(");
                writer.WriteValidator(v);
                writer.WriteLine(");");
            }

            if (!containingType.Name.QName.IsEmpty)
            {
                writer.Write("builder.SetSchema(");
                writer.WriteItem(containingType.Name.QName);
                writer.WriteLine(");");
            }

            if (!containingType.IsAbstract && containingType.Version > OfficeVersion.Office2007)
            {
                writer.Write("builder.Availability = ");
                writer.WriteItem(containingType.Version);
                writer.WriteLine(";");
            }

            if (!containingType.IsDerived)
            {
                foreach (var child in containingType.KnownChildren)
                {
                    writer.Write("builder.AddChild<");
                    writer.Write(services.FindClassName(child));
                    writer.WriteLine(">();");
                }
            }

            if (attributes.Any())
            {
                var className = services.FindClassName(containingType.Name, fullyQualified: false);

                writer.Write("builder.AddElement<");
                writer.Write(className);
                writer.Write(">()");

                writer.WriteLine();

                using (writer.AddIndent(new() { IncludeTrailingNewline = false }))
                {
                    var delimiter = writer.TrackDelimiter(separator: string.Empty, newLineCount: 1);

                    foreach (var attribute in attributes)
                    {
                        delimiter.AddDelimiter();

                        writer.Write(".AddAttribute(");
                        writer.WriteItem(attribute.QName);
                        writer.Write(", a => a.");
                        writer.Write(attribute.PropertyName);

                        if (attribute.Validators.Any())
                        {
                            writer.WriteLine(", aBuilder =>");

                            using (writer.AddBlock(new() { IncludeTrailingNewline = false }))
                            {
                                var union = attribute.Validators.GroupBy(v => v.UnionId);

                                foreach (var group in union.OrderBy(static u => u.Key))
                                {
                                    if (group.Key is null)
                                    {
                                        WriteUnion(writer, "aBuilder", group);
                                    }
                                    else
                                    {
                                        writer.WriteLine("aBuilder.AddUnion(union =>");
                                        using (writer.AddBlock(new() { IncludeTrailingNewline = false }))
                                        {
                                            WriteUnion(writer, "union", group);
                                        }

                                        writer.WriteLine(");");
                                    }
                                }
                            }

                            void WriteUnion(IndentedTextWriter writer, string name, IEnumerable<Validator> validators)
                            {
                                foreach (var validator in validators)
                                {
                                    writer.Write(name);
                                    writer.Write(".AddValidator");

                                    if (validator.Type is not null)
                                    {
                                        writer.Write("<");
                                        writer.Write(services.GetSimpleType(validator.Type, validator.IsList));
                                        writer.Write(">");
                                    }

                                    writer.Write("(");
                                    writer.WriteValidator(validator);
                                    writer.WriteLine(");");
                                }
                            }
                        }

                        writer.Write(")");
                    }
                }

                writer.WriteLine(";");
            }

            if (containingType.Particle is not null)
            {
                writer.Write("builder.Particle = ");
                writer.WriteParticle(services, containingType, containingType.Particle);
                writer.WriteLine(";");
            }

            StringSchematronVisitor.WriteSchematrons(writer, "builder", services.GetSchematrons(containingType.Name.QName));
        }
    }

    private static void WriteElement(this IndentedTextWriter writer, OpenXmlGeneratorServices services, SchemaType parent, SchemaElement element, ref Delimiter delimiter)
    {
        if (string.IsNullOrEmpty(element.PropertyName))
        {
            return;
        }

        var className = services.FindClassName(element.Name);
        var version = services.FindType(element.Name).Version;
        var availabilityComments = version.IfAvailable(parent.Version, true);

        delimiter.AddDelimiter();
        writer.WriteDocumentationComment(new DocumentCommentOptions
        {
            Summary = new Paragraphs
                {
                        $"{element.PropertyComments}{availabilityComments}.",
                        $"Represents the following element tag in the schema: {element.Name.QName.Prefix}:{element.Name.QName.Name}.",
                },
            Remarks = $"xmlns:{element.Name.QName.Prefix} = {services.GetNamespaceInfo(element.Name.QName.Prefix).Uri}",
        });

        writer.Write("public ");
        writer.Write(className);
        writer.Write("? ");
        writer.WriteLine(element.PropertyName);

        using (writer.AddBlock(new() { IncludeTrailingNewline = false }))
        {
            writer.Write("get => GetElement<");
            writer.Write(className);
            writer.WriteLine(">();");

            writer.WriteLine("set => SetElement(value);");
        }
    }

    private static void WriteAttributeProperty(this IndentedTextWriter writer, OpenXmlGeneratorServices services, SchemaAttribute attribute)
    {
        var remarks = default(string);
        var info = services.GetNamespaceInfo(attribute.QName.Prefix);

        if (!string.IsNullOrEmpty(attribute.QName.Prefix))
        {
            remarks = $"xmlns:{attribute.QName.Prefix}={info.Uri}";
        }

        var availability = attribute.Version > OfficeVersion.Office2007
            ? $", this property is only available in {attribute.Version.ToFormattedString()} and later."
            : string.Empty;

        writer.WriteDocumentationComment(new DocumentCommentOptions
        {
            Summary = new Paragraphs
            {
                $"{attribute.PropertyComments}{availability}",
                $"Represents the following attribute in the schema: {attribute.QName}",
            },
            Remarks = remarks,
        });

        writer.WriteSchemaAttribute(attribute.QName);
        writer.Write("public ");
        writer.Write(attribute.Type);
        writer.Write("? ");
        writer.WriteLine(attribute.PropertyName);

        using (writer.AddBlock(new() { IncludeTrailingNewline = false }))
        {
            writer.Write("get => GetAttribute<");
            writer.Write(attribute.Type);
            writer.WriteLine(">();");
            writer.WriteLine("set => SetAttribute(value);");
        }
    }

    private static string? IfAvailable(this OfficeVersion version, OfficeVersion? other = OfficeVersion.Office2007, bool isProperty = false)
    {
        if (version is OfficeVersion.None || other is OfficeVersion.None)
        {
            return null;
        }

        if (version > other)
        {
            var result = new StringBuilder();

            if (isProperty)
            {
                result.Append(", this property");
            }
            else
            {
                result.Append("This item");
            }

            result.Append(" is only available in ");
            result.Append(version.ToFormattedString());
            result.Append(" and later.");

            return result.ToString();
        }

        return null;
    }

    private static void WriteEnumType(this IndentedTextWriter writer, SchemaEnum som)
    {
        writer.WriteDocumentationComment(som.Summary);
        writer.Write("public enum ");
        writer.WriteLine(som.Name);

        using (writer.AddBlock(new() { AddNewLineBeforeClosing = true, IncludeTrailingNewline = false }))
        {
            var delimiter = writer.TrackDelimiter(newLineCount: 1);

            foreach (var f in som.Facets)
            {
                delimiter.AddDelimiter();
                writer.WriteDocumentationComment(new DocumentCommentOptions()
                {
                    Summary = new(false)
                    {
                        $"{f.Comments}.",
                        $"When the item is serialized out as xml, its value is \"{f.Value}\".",
                        f.Version.IfAvailable(som.Version),
                    },
                });

                writer.Write("[EnumString(");
                writer.WriteItem(f.Value, isConstant: true);
                writer.WriteLine(")]");

                if (f.Version > som.Version)
                {
                    writer.Write("[OfficeAvailability(");
                    writer.WriteItem(som.Version);
                    writer.WriteLine(")]");
                }

                writer.Write(f.Name);
            }
        }
    }

    private static void GetPartLoadMethods(this IndentedTextWriter writer, SchemaType type, string className, ref Delimiter delimiter)
    {
        delimiter.AddDelimiter();

        writer.Write("internal ");
        writer.Write(className);
        writer.Write("(");
        writer.Write(type.Part);
        writer.WriteLine(" ownerPart) : base(ownerPart)");
        using (writer.AddBlock(new() { IncludeTrailingNewline = false }))
        {
        }

        delimiter.AddDelimiter();

        writer.WriteDocumentationComment(new DocumentCommentOptions
        {
            Summary = $"Loads the DOM from the {type.Part}",
            Parameters = new Parameters
            {
                { "openXmlPart", "Specifies the part to be loaded." },
            },
        });
        writer.Write("public void Load(");
        writer.Write(type.Part);
        writer.WriteLine(" openXmlPart)");
        using (writer.AddBlock(new() { IncludeTrailingNewline = false }))
        {
            writer.WriteLine("LoadFromPart(openXmlPart);");
        }

        delimiter.AddDelimiter();

        writer.WriteDocumentationComment(new DocumentCommentOptions
        {
            Summary = $"Saves the DOM into the {type.Part}.",
            Parameters = new Parameters
            {
                { "openXmlPart", "Specifies the part to save to." },
            },
        });
        writer.Write("public void Save(");
        writer.Write(type.Part);
        writer.WriteLine(" openXmlPart)");
        using (writer.AddBlock(new() { IncludeTrailingNewline = false }))
        {
            writer.WriteLine("base.SaveToPart(openXmlPart);");
        }

        delimiter.AddDelimiter();

        writer.WriteDocumentationComment($"Gets the {type.Part} associated with this element.");
        writer.Write("public ");
        writer.Write(type.Part);
        writer.Write("? ");
        writer.WriteLine(type.Part);
        using (writer.AddBlock(new() { IncludeTrailingNewline = false }))
        {
            writer.Write("get => OpenXmlPart as ");
            writer.Write(type.Part);
            writer.WriteLine(";");

            writer.WriteLine("internal set => OpenXmlPart = value;");
        }
    }

    private static void WriteSchemaAttribute(this IndentedTextWriter writer, QName qname)
    {
        if (!qname.IsEmpty)
        {
            writer.Write("[SchemaAttr(");
            writer.WriteItem(qname.ToString());
            writer.WriteLine(")]");
        }
    }

    private static void WriteConstructors(this IndentedTextWriter writer, OpenXmlGeneratorServices services, SchemaType element, ref Delimiter delimiter)
    {
        var className = services.FindClassName(element.Name, fullyQualified: false);

        if (element.IsLeafText)
        {
            delimiter.AddDelimiter();
            writer.WriteDocumentationComment(new DocumentCommentOptions
            {
                Summary = $"Initializes a new instance of the {className} class with the specified text content.",
                Parameters = new Parameters
                {
                    { "text", "Specifies the text content of the element." },
                },
            });
            writer.Write(element.GetAccessibility());
            writer.Write(" ");
            writer.Write(className);
            writer.WriteLine("(string text) : base(text)");

            using (writer.AddBlock(new() { IncludeTrailingNewline = false }))
            {
            }

            delimiter.AddDelimiter();
            writer.WriteLine("internal override OpenXmlSimpleType InnerTextToValue(string text)");
            using (writer.AddBlock(new() { IncludeTrailingNewline = false }))
            {
                writer.Write("return new ");
                writer.Write(services.GetSimpleType(element.Name.Type, false));
                writer.Write(" { InnerText = text };");
                writer.WriteLine();
            }
        }
        else if (!element.IsLeafElement)
        {
            var comments = new DocumentCommentOptions
            {
                Summary = $"Initializes a new instance of the {className} class with the specified child elements.",
                Parameters = new Parameters
                {
                    { "childElements", "Specifies the child elements." },
                },
            };

            delimiter.AddDelimiter();
            writer.WriteDocumentationComment(comments);
            writer.Write(element.GetAccessibility());
            writer.Write(" ");
            writer.Write(className);
            writer.WriteLine("(IEnumerable<OpenXmlElement> childElements) : base(childElements)");

            using (writer.AddBlock(new() { IncludeTrailingNewline = false }))
            {
            }

            delimiter.AddDelimiter();
            writer.WriteDocumentationComment(comments);
            writer.Write(element.GetAccessibility());
            writer.Write(" ");
            writer.Write(className);
            writer.WriteLine("(params OpenXmlElement[] childElements) : base(childElements)");

            using (writer.AddBlock(new() { IncludeTrailingNewline = false }))
            {
            }

            delimiter.AddDelimiter();
            writer.WriteDocumentationComment(new DocumentCommentOptions
            {
                Summary = $"Initializes a new instance of the {className} class from outer XML.",
                Parameters = new Parameters
                {
                    { "outerXml", "Specifies the outer XML of the element." },
                },
            });
            writer.Write(element.GetAccessibility());
            writer.Write(" ");
            writer.Write(className);
            writer.WriteLine("(string outerXml) : base(outerXml)");

            using (writer.AddBlock(new() { IncludeTrailingNewline = false }))
            {
            }
        }
    }

    private static string GetAccessibility(this SchemaType element)
        => element.IsAbstract ? "protected" : "public";

    private static IEnumerable<string> GetNamespaces(SchemaNamespace model, OpenXmlGeneratorServices services)
    {
        yield return "System";
        yield return "System.Collections.Generic";
        yield return "System.IO.Packaging";
        yield return "DocumentFormat.OpenXml.Framework";
        yield return "DocumentFormat.OpenXml.Framework.Metadata";
        yield return "DocumentFormat.OpenXml.Packaging";
        yield return "DocumentFormat.OpenXml.Validation.Schema";

        var hasSchematrons = model.Types.SelectMany(t => services.GetSchematrons(t.Name.QName)).Any();

        if (hasSchematrons)
        {
            yield return "DocumentFormat.OpenXml.Validation.Semantic";
        }

        yield return "DocumentFormat.OpenXml";

        var set = new HashSet<string>();

        var prefix = services.GetNamespaceInfoByUri(model.TargetNamespace).Prefix;
        var namespaces = model.Types
            .SelectMany(t => t.Elements)
            .Select(e => e.Name.Type.Prefix)
            .Where(p => p != prefix)
            .Distinct()
            .Select(services.GetNamespaceApiByPrefix);

        foreach (var item in namespaces)
        {
            if (item is not null)
            {
                yield return item;
            }
        }
    }
}
