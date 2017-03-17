using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace DocumentFormat.OpenXml.Validation
{
    internal partial class ValidationResources
    {
        public static Stream GetSchemaStream(FileFormatVersions fileFormat)
        {
            switch (fileFormat)
            {
                case FileFormatVersions.Office2007:
                    return O12SchemaConstraintDatas;
                case FileFormatVersions.Office2010:
                    return O14SchemaConstraintDatas;
                case FileFormatVersions.Office2013:
                    return O15SchemaConstraintDatas;
                default:
                    Debug.Assert(fileFormat == FileFormatVersions.Office2007 || fileFormat == FileFormatVersions.Office2010 || fileFormat == FileFormatVersions.Office2013);
                    return O12SchemaConstraintDatas;
            }
        }

        private static Stream GetEmbeddedResource([CallerMemberName]string name = null)
        {
            return typeof(ValidationResources).GetTypeInfo().Assembly.GetManifestResourceStream($"DocumentFormat.OpenXml.src.GeneratedCode.{name}.bin");
        }

        private static Stream O12SchemaConstraintDatas => GetEmbeddedResource();

        private static Stream O14SchemaConstraintDatas => GetEmbeddedResource();

        private static Stream O15SchemaConstraintDatas => GetEmbeddedResource();
    }
}
