// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace DocumentFormat.OpenXml.Validation
{
    internal partial class ValidationResources
    {
        public static Stream GetSchemaStream(FileFormatVersions fileFormat)
        {
            switch (fileFormat)
            {
                case FileFormatVersions.Office2007:
                    return GetEmbeddedResource("O12SchemaConstraintDatas");
                case FileFormatVersions.Office2010:
                    return GetEmbeddedResource("O14SchemaConstraintDatas");
                case FileFormatVersions.Office2013:
                    return GetEmbeddedResource("O15SchemaConstraintDatas");
                case FileFormatVersions.Office2016:
                    return GetEmbeddedResource("O16SchemaConstraintDatas");
                default:
                    Debug.Assert(fileFormat.Any());
                    return GetEmbeddedResource("O12SchemaConstraintDatas");
            }
        }

        private static Stream GetEmbeddedResource(string name)
        {
            return typeof(ValidationResources).GetTypeInfo().Assembly.GetManifestResourceStream($"DocumentFormat.OpenXml.src.GeneratedCode.{name}.bin");
        }
    }
}
