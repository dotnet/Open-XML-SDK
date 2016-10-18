using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace DocumentFormat.OpenXml.Validation
{
    internal partial class ValidationResources
    {
        private static byte[] GetEmbeddedResource([CallerMemberName]string name = null)
        {
            var names = typeof(ValidationResources).GetTypeInfo().Assembly.GetManifestResourceNames();
            using (var stream = typeof(ValidationResources).GetTypeInfo().Assembly.GetManifestResourceStream($"DocumentFormat.OpenXml.src.GeneratedCode.{name}.bin"))
            using (var ms = new MemoryStream())
            {
                stream.CopyTo(ms);

                return ms.ToArray();
            }
        }

        internal static byte[] O12SchemaConstraintDatas => GetEmbeddedResource();

        internal static byte[] O14SchemaConstraintDatas => GetEmbeddedResource();

        internal static byte[] O15SchemaConstraintDatas => GetEmbeddedResource();
    }
}
