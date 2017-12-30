// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Schema;

namespace OfficeSchemaProcessor
{
    internal class PackageProcessor
    {
        private readonly XmlSchemaSet _schemaSet;

        public PackageProcessor(string packageSchemaPath)
        {
            _schemaSet = GetSchemaSet(packageSchemaPath);
        }

        public void Process(string outputDirectory)
        {
            var schema = _schemaSet.Schemas().OfType<XmlSchema>().First();
            var preprocess = new PackageSchemaPreProcessor(schema);
            preprocess.PreProcessSom();

            schema.Flatten();

            var skippedBaseClass = new HashSet<string>(StringComparer.Ordinal)
            {
                "OpenXmlPackage",
                "DataPartReferenceRelationship"
            };

            var entries = schema
                .SchemaTypes
                .Values
                .OfType<XmlSchemaComplexType>()
                .Where(t => string.Equals(t.QualifiedName.Namespace, schema.TargetNamespace, StringComparison.Ordinal))
                .Select(t => new OpenXmlType(t))
                .Where(e => !skippedBaseClass.Contains(e.Base));

            using (var builder = new PackageDocumentBuilder(outputDirectory))
            {
                entries.AsParallel().ForAll(builder.WriteFile);
            }
        }

        public static XmlSchemaSet GetSchemaSet(string packageSchemaPath)
        {
            void ValidationCallback(object sender, ValidationEventArgs e)
            {
            }

            using (var fs = File.OpenRead(packageSchemaPath))
            {
                var schema = XmlSchema.Read(fs, ValidationCallback);

                var set = new XmlSchemaSet();
                set.Add(schema);

                set.Compile();

                return set;
            }
        }
    }
}
