using DocumentFormat.OpenXml.Builder;
using DocumentFormat.OpenXml.Packaging;
using System.IO;
using Xunit;

namespace DocumentFormat.OpenXml.Tests
{
    public class Class1
    {
        [Fact]
        public void Test()
        {
            var builder = SpreadsheetDocument.CreateDefaultBuilder();

            // Create a single instance
            using var doc1 = builder.Open(Stream.Null, Features.PackageOpenMode.Create);

            using var doc1b = builder.Open(Stream.Null, Features.PackageOpenMode.Create);

            var builder2 = builder.New();

            using var doc2 = builder2.Open(Stream.Null, Features.PackageOpenMode.Create);

            var builder3 = builder.New();

            builder3.Configure((package, next) =>
            {
                next(package);
            });
            using var doc3 = builder3.Open(Stream.Null, Features.PackageOpenMode.Create);
        }
    }
}
