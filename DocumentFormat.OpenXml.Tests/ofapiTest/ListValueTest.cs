using DocumentFormat.OpenXml;
using Xunit;
using System.Linq;

namespace DocumentFormat.OpenXml.Tests
{
    
    
    /// <summary>
    ///This is a test class for ListValueTest and is intended
    ///to contain all ListValueTest Unit Tests
    ///</summary>
    
    public class ListValueTest
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
        ///A test for InnerText
        ///</summary>
        public void InnerTextTestHelper<T>()
            where T : OpenXmlSimpleType, new()
        {
            ListValue<T> target = new ListValue<T>(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.InnerText = expected;
            actual = target.InnerText;
            Assert.Equal(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        ///<summary>
        ///ListValueSanityTest.
        ///</summary>
        [Fact]
        public void ListValueSanityTest()
        {
            ListValue<StringValue> target = new ListValue<StringValue>();
            Assert.Null(target.InnerText);
            Assert.NotNull(target.Items);

            target.Items.Add(new StringValue("Item1"));
            Assert.NotNull(target.Items);
            Assert.NotNull(target.InnerText);
            Assert.Equal("Item1", target.Items.First().ToString());
            Assert.Equal("Item1", (string)target);

            target.Items.Add(new StringValue("Item2"));
            Assert.NotNull(target.Items);
            Assert.NotNull(target.InnerText);
            Assert.Equal("Item2", target.Items.ElementAt(1).ToString());
            Assert.Equal("Item1 Item2", target.ToString());

            target.InnerText = "Item3 Item4";
            Assert.NotNull(target.Items);
            Assert.NotNull(target.InnerText);
            Assert.Equal(2, target.Items.Count);
            Assert.Equal("Item3", target.Items.First().ToString());
            Assert.Equal("Item4", target.Items.ElementAt(1).ToString());

            var target2 = new ListValue<StringValue>(target);
            Assert.NotNull(target2.Items);
            Assert.NotNull(target2.InnerText);
            Assert.Equal(2, target2.Items.Count);
            Assert.Equal("Item3", target2.Items.First().ToString());
            Assert.Equal("Item4", target2.Items.ElementAt(1).ToString());
        }
    }
}
