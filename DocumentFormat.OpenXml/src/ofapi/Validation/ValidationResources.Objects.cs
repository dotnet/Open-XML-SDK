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
                default:
                    Debug.Assert(fileFormat == FileFormatVersions.Office2007 || fileFormat == FileFormatVersions.Office2010 || fileFormat == FileFormatVersions.Office2013);
                    return GetEmbeddedResource("O12SchemaConstraintDatas");
            }
        }

        private static Stream GetEmbeddedResource(string name)
        {
            return typeof(ValidationResources).GetTypeInfo().Assembly.GetManifestResourceStream($"DocumentFormat.OpenXml.src.GeneratedCode.{name}.bin");
        }
    }
}
