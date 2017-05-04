using DocumentFormat.OpenXml.Internal.SchemaValidation;
using SourceCodeSerializer;
using SourceCodeSerializer.Generators;
using System;
using System.Collections.Immutable;
using System.IO;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Office2007Schema", SdbSchemaDatas.GetOffice2007SchemaDatas());
            Write("Office2010Schema", SdbSchemaDatas.GetOffice2010SchemaDatas());
            Write("Office2013Schema", SdbSchemaDatas.GetOffice2013SchemaDatas());
        }

        private static void Write(string name, SdbSchemaDatas data)
        {
            Console.WriteLine($"Serializing {name}");

            var path = Path.Combine(GetRootDirectory(), "DocumentFormat.OpenXml", "src", "GeneratedCode", $"{name}.cs");

            using (var fs = File.Open(path, FileMode.Create, FileAccess.Write))
            using (var writer = new StreamWriter(fs))
            {
                var settings = new SerializerSettings
                {
                    IgnoreDefaultValues = false,
                    ObjectInitializationNewLine = false,
                    Usings = ImmutableArray.Create("DocumentFormat.OpenXml.Internal.SchemaValidation", "DocumentFormat.OpenXml.Validation", "System"),
                    Generator = new ConstructorGenerator("DocumentFormat.OpenXml.Internal.SchemaValidation", name)
                };

                SourceCodeSerializer.SourceCodeSerializer.Serialize(writer, data, settings);
            }
        }

        private static string GetRootDirectory(string path = null)
        {
            if (path == null)
            {
                return GetRootDirectory(Directory.GetCurrentDirectory());
            }

            if (File.Exists(Path.Combine(path, "Open-XML-SDK.sln")))
            {
                return Path.GetFullPath(path);
            }

            return GetRootDirectory(Path.Combine(path, ".."));
        }
    }
}
