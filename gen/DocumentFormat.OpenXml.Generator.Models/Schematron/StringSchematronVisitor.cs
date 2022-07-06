// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Generator.Editor;
using DocumentFormat.OpenXml.Generator.Models;
using DocumentFormat.OpenXml.Generator.Schematron.KnownSchematrons;
using System.CodeDom.Compiler;
using System.Text;

namespace DocumentFormat.OpenXml.Generator.Schematron
{
    internal class StringSchematronVisitor : SchematronVisitor<string>
    {
        private static readonly SchematronDataParser Parser = new();

        public static void WriteSchematrons(IndentedTextWriter writer, string paramName, IEnumerable<SchematronEntry> src)
        {
            var visited = new HashSet<string>();

            foreach (var entry in src)
            {
                foreach (var schematron in Parser.Parse(entry))
                {
                    var str = new StringSchematronVisitor().Visit(schematron);

                    if (visited.Add(str))
                    {
                        writer.Write(paramName);
                        writer.Write(".AddConstraint(");
                        writer.Write(str);

                        WriteArgs(writer, entry.App, entry.Version);

                        writer.WriteLine(");");
                    }
                }
            }

            static void WriteArgs(TextWriter writer, OfficeApplication app, OfficeVersion version)
            {
                if (app == OfficeApplication.All && version == OfficeVersion.Office2007)
                {
                    return;
                }

                writer.Write(" { ");

                var addedApp = false;

                if (app != OfficeApplication.All)
                {
                    void CheckAdded(OfficeApplication app)
                    {
                        if (addedApp)
                        {
                            writer.Write(" | ");
                        }
                        else
                        {
                            addedApp = true;

                            writer.Write("Application = ");
                        }

                        writer.Write("ApplicationType.");
                        writer.Write(app.ToString());
                    }

                    if ((app & OfficeApplication.Word) == OfficeApplication.Word)
                    {
                        CheckAdded(OfficeApplication.Word);
                    }

                    if ((app & OfficeApplication.Excel) == OfficeApplication.Excel)
                    {
                        CheckAdded(OfficeApplication.Excel);
                    }

                    if ((app & OfficeApplication.PowerPoint) == OfficeApplication.PowerPoint)
                    {
                        CheckAdded(OfficeApplication.PowerPoint);
                    }
                }

                if (version != OfficeVersion.Office2007)
                {
                    if (addedApp)
                    {
                        writer.Write(", ");
                    }

                    writer.Write("Version = ");
                    writer.WriteItem(version);
                }

                writer.Write(" }");
            }
        }

        private string Literal(object obj)
        {
            if (obj is AttributeReference a)
            {
                return Literal(a);
            }
            else if (obj is string s)
            {
                return $@"@""{s}""";
            }

            throw new InvalidOperationException();
        }

        private string Combine(string name, params object[] args)
        {
            var argStr = string.Join(", ", args.Select(Literal));

            return $"new {name}({argStr})";
        }

        public override string Visit(Schematron1_1 schematron)
        {
            return Combine("AttributeCannotOmitConstraint", schematron.Attribute);
        }

        public override string Visit(Schematron1_2 schematron)
        {
            return Combine("AttributeValuePatternConstraint", schematron.Attribute, schematron.Text);
        }

        public override string Visit(Schematron1_3 schematron)
        {
            return $"new AttributeValueRangeConstraint({Literal(schematron.Attribute)}, true, {Literal(schematron.MinValue)}, {Literal(schematron.MinInclusive)}, {Literal(schematron.MaxValue)}, {Literal(schematron.MaxInclusive)})";
        }

        public override string Visit(Schematron1_4 schematron)
        {
            return $"new AttributeValueSetConstraint({Literal(schematron.Attribute)}, true, {Literal(schematron.Items)})";
        }

        public override string Visit(Schematron1_10 schematron)
        {
            return $"new AttributeValueSetConstraint({Literal(schematron.Attribute)}, false, {Literal(schematron.Items)})";
        }

        public override string Visit(Schematron1_12 schematron)
        {
            return $"new AttributeValueLengthConstraint({Literal(schematron.Attribute)}, {schematron.MinLength}, {Literal(schematron.MaxLength)})";
        }

        public override string Visit(Schematron1_14 schematron)
        {
            return $"new AttributeAbsentConditionToValue({Literal(schematron.Attribute1)}, {Literal(schematron.Attribute2)}, {Literal(schematron.Items, @params: true)})";
        }

        public override string Visit(Schematron1_15 schematron)
        {
            return $"new AttributeAbsentConditionToNonValue({Literal(schematron.Attribute1)}, {Literal(schematron.Attribute2)}, {Literal(schematron.Items, @params: true)})";
        }

        public override string Visit(Schematron1_16 schematron)
        {
            return $"new AttributeMutualExclusive({Literal(schematron.Attributes)})";
        }

        public override string Visit(Schematron1_17 schematron)
        {
            return $"new AttributeValueLessEqualToAnother({Literal(schematron.Attribute1)}, {Literal(schematron.Attribute2)}, {Literal(schematron.CanEqual)})";
        }

        public override string Visit(Schematron1_18 schematron)
        {
            return $"new AttributeRequiredConditionToValue({Literal(schematron.Attribute1)}, {Literal(schematron.Attribute2)} , {Literal(schematron.Items, @params: true)})";
        }

        public override string Visit(Schematron1_19 schematron)
        {
            return $"new AttributeValueConditionToAnother({Literal(schematron.Attribute1)}, {Literal(schematron.Attribute2)}, {Literal(schematron.Items1)}, {Literal(schematron.Items2)})";
        }

        public override string Visit(Schematron2_2 schematron)
        {
            return $"new RelationshipTypeConstraint({Literal(schematron.Attribute)}, \"{schematron.RelationshipType}\")";
        }

        public override string Visit(Schematron2_3 schematron)
        {
            return $"new UniqueAttributeValueConstraint({Literal(schematron.Attribute)}, {Literal(schematron.IsLowerCase)}, {TypeOf(schematron.Parent)})";
        }

        public override string Visit(Schematron2_1 schematron)
        {
            return $"new RelationshipExistConstraint({Literal(schematron.Attribute)})";
        }

        public override string Visit(Schematron3_1 schematron)
        {
            return $"new ReferenceExistConstraint({Literal(schematron.Attribute)}, \"{schematron.Part}\", {TypeOf(schematron.Element)}, \"{schematron.Element}\", {Literal(schematron.ElementAttribute)})";
        }

        public override string Visit(Schematron3_2 schematron)
        {
            return $"new IndexReferenceConstraint({Literal(schematron.Attribute)}, \"{schematron.Part}\", {TypeOf(schematron.Parent)}, {TypeOf(schematron.Element)}, \"{schematron.Element}\", {schematron.Index})";
        }

        public override string Visit(Schematron3_3 schematron)
        {
            return $"new RootAttributeUniqueConstraint({Literal(schematron.Attribute)}, {Literal(schematron.IsCaseSensitive)})";
        }

        private static string Literal(IEnumerable<string> array, bool @params = false)
        {
            var sb = new StringBuilder();

            if (!@params)
            {
                sb.Append("new string[] { \"");
            }
            else
            {
                sb.Append("\"");
            }

            sb.Append(string.Join("\", \"", array));

            if (!@params)
            {
                sb.Append("\" }");
            }
            else
            {
                sb.Append("\"");
            }

            return sb.ToString();
        }

        private static string Literal(IEnumerable<AttributeReference> attributes)
            => string.Join(", ", attributes.Select(a => Literal(a)));

        private static string TypeOf(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return "null";
            }
            else
            {
                return $"typeof({name})";
            }
        }

        private static string TypeOf(ElementReference name) => name is null ? "null" : $"builder.CreateQName(\"{name.Name}\")";

        private static string Literal(AttributeReference a) => $"builder.CreateQName(\"{a.Name}\")";

        private static string Literal(bool b) => b ? "true" : "false";

        private static string Literal(int i)
        {
            if (i == int.MaxValue)
            {
                return "int.MaxValue";
            }

            return i.ToString();
        }

        private static string Literal(double d)
        {
            if (double.IsPositiveInfinity(d))
            {
                return "double.PositiveInfinity";
            }
            else if (double.IsNegativeInfinity(d))
            {
                return "double.NegativeInfinity";
            }

            return d.ToString();
        }
    }
}
