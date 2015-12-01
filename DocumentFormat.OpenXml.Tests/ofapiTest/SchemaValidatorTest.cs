using DocumentFormat.OpenXml.Internal.SchemaValidation;
using Xunit;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Validation;
using DocumentFormat.OpenXml.Wordprocessing;

namespace DocumentFormat.OpenXml.Tests
{
    
    
    /// <summary>
    ///This is a test class for SchemaValidatorTest and is intended
    ///to contain all SchemaValidatorTest Unit Tests
    ///</summary>
    
    public class SchemaValidatorTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for Validating LeafElement.
        ///</summary>
        [Fact]
        public void LeafElementValidateTest()
        {
            string runOuterXml = "<w:r xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\">" +
            "<w:rPr><w:strike /><w:vanish><!-- comments is ok --></w:vanish><w:webHidden><w:invalidChild /></w:webHidden></w:rPr>" +
            "<w:t>Run Text.</w:t><w:t><!-- comments is ok -->Text 2</w:t><w:t>Text 3.<invalidElement /></w:t></w:r>";

            SchemaValidator target = new SchemaValidator();
            var openxmlElement = new Run(runOuterXml);
            ValidationResult result = target.Validate(openxmlElement);
            Assert.False(result.Valid);
            Assert.Equal(2, result.Errors.Count);

            Assert.Same(openxmlElement.GetFirstChild<RunProperties>().WebHidden, result.Errors[0].Node);
            Assert.Equal("Sch_InvalidChildinLeafElement", result.Errors[0].Id);
            Assert.Equal("The element 'http://schemas.openxmlformats.org/wordprocessingml/2006/main:webHidden' is a leaf element and cannot contain children.", result.Errors[0].Description);

            Assert.Same(openxmlElement.LastChild, result.Errors[1].Node);
            Assert.Equal("Sch_InvalidChildinLeafElement", result.Errors[1].Id);
            Assert.Equal("The element 'http://schemas.openxmlformats.org/wordprocessingml/2006/main:t' is a leaf element and cannot contain children.", result.Errors[1].Description);
        }
    }
}
