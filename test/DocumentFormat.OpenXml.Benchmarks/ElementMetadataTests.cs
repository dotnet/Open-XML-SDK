using BenchmarkDotNet.Attributes;
using DocumentFormat.OpenXml.Framework.Metadata;

namespace DocumentFormat.OpenXml.Benchmarks
{
    public class ElementMetadataTests
    {
        [GlobalSetup]
        public void Setup()
        {
            _element = new AlternateContent();
        }

        [Benchmark]
        public void CreateWithInstance()
        {
            _ = ElementMetadata.Create(_element);
        }

        [Benchmark]
        public void CreateWithGeneric()
        {
            _ = ElementMetadata.Create<AlternateContent>();
        }

        private OpenXmlElement _element;
    }
}
