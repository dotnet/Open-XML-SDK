// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Wordprocessing;

using System.Collections.Generic;

using Xunit;

namespace DocumentFormat.OpenXml.Tests
{
    public class OpenXmlElementEqualityTest
    {
        private static readonly IEqualityComparer<OpenXmlElement> DefaultComparer = OpenXmlElementComparers.Default;
        private static readonly IEqualityComparer<OpenXmlElement> DefaultComparerRequireParsed = OpenXmlElementComparers.GetEqualityComparer(new OpenXmlElementEqualityOptions
        {
            RequireParsed = true,
        });

        private static readonly IEqualityComparer<OpenXmlElement> DefaultComparerMinusMC = OpenXmlElementComparers.GetEqualityComparer(new OpenXmlElementEqualityOptions
        {
            IncludeMCAttributes = false,
        });

        private static readonly IEqualityComparer<OpenXmlElement> DefaulttComparerMinusExtended = OpenXmlElementComparers.GetEqualityComparer(new OpenXmlElementEqualityOptions
        {
            IncludeExtendedAttributes = false,
        });

        [Fact]
        public void NullTest()
        {
            string paragraphOuterXmlrsidP001 = "<w:p w:rsidP=\"001\" xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\"><w:r><w:t>Run Text.</w:t><w:t>Run 2.</w:t></w:r></w:p>";
            Paragraph para = new Paragraph(paragraphOuterXmlrsidP001);

#pragma warning disable xUnit2003 // Do not use equality check to test for null value
            Assert.NotEqual(null, para, DefaultComparer);
#pragma warning restore xUnit2003 // Do not use equality check to test for null value
        }

        [Fact]
        public void ReferenceEqualsTest()
        {
            // C:\src\Open-XML-SDK\data\schemas\schemas_openxmlformats_org_wordprocessingml_2006_main.json :: 13537
            string paragraphOuterXmlrsidP001 = "<w:p w:rsidP=\"001\" xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\"><w:r><w:t>Run Text.</w:t><w:t>Run 2.</w:t></w:r></w:p>";
            Paragraph para = new Paragraph(paragraphOuterXmlrsidP001);

            Assert.Equal(para, para, DefaultComparer);
        }

        [Fact]
        public void AttributeTest()
        {
            // C:\src\Open-XML-SDK\data\schemas\schemas_openxmlformats_org_wordprocessingml_2006_main.json :: 13537
            string paragraphOuterXmlrsidP001 = "<w:p w:rsidP=\"001\" xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\"><w:r><w:t>Run Text.</w:t><w:t>Run 2.</w:t></w:r></w:p>";
            string paragraphOuterXmlrsidP002 = "<w:p w:rsidP=\"002\" xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\"><w:r><w:t>Run Text.</w:t><w:t>Run 2.</w:t></w:r></w:p>";
            Paragraph para = new Paragraph(paragraphOuterXmlrsidP001);
            Paragraph paraDifferentAttributeValue = new Paragraph(paragraphOuterXmlrsidP002);

            Assert.Equal(para, para, DefaultComparer);

            // Different attribute values should not be the same.
            Assert.NotEqual(para, paraDifferentAttributeValue, DefaultComparer);

            para.MakeSureParsed();
            paraDifferentAttributeValue.MakeSureParsed();

            // Different attribute values should not be the same.
            Assert.NotEqual(para, paraDifferentAttributeValue, DefaultComparer);
        }

        /// <summary>
        /// Test that shows extended attributes are considered in equality.
        /// </summary>
        [Fact]
        public void ExtendedAttributeTest()
        {
            // C:\src\Open-XML-SDK\data\schemas\schemas_openxmlformats_org_wordprocessingml_2006_main.json :: 13537
            string paragraphWithFooExtendedAttribute = "<w:p w:rsidP=\"001\" xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\" foo=\"bar\"><w:r><w:t>Run Text.</w:t><w:t>Run 2.</w:t></w:r></w:p>";
            string paragraphWithFooExtendedAttributeDifferent = "<w:p w:rsidP=\"001\" xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\" foo=\"different\"><w:r><w:t>Run Text.</w:t><w:t>Run 2.</w:t></w:r></w:p>";
            string paragraphWithBarExtendedAttribute = "<w:p w:rsidP=\"001\" xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\" bar=\"different\"><w:r><w:t>Run Text.</w:t><w:t>Run 2.</w:t></w:r></w:p>";
            string paragraphWithBarNoExtendedAttribute = "<w:p w:rsidP=\"001\" xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\"><w:r><w:t>Run Text.</w:t><w:t>Run 2.</w:t></w:r></w:p>";
            Paragraph para = new Paragraph(paragraphWithFooExtendedAttribute);
            Paragraph para2 = new Paragraph(paragraphWithFooExtendedAttribute);
            Paragraph paraFooExtendedAttribute = new Paragraph(paragraphWithFooExtendedAttributeDifferent);
            Paragraph paraBarExtendedAttribute = new Paragraph(paragraphWithBarExtendedAttribute);
            Paragraph paraNoExtendedAttribute = new Paragraph(paragraphWithBarNoExtendedAttribute);

            Assert.Equal(para, para, DefaultComparer); // Ref equality should always be equal.
            Assert.Equal(para, para2, DefaultComparer); // Identity equality.

            para.MakeSureParsed();
            para2.MakeSureParsed();
            paraFooExtendedAttribute.MakeSureParsed();
            paraBarExtendedAttribute.MakeSureParsed();
            paraNoExtendedAttribute.MakeSureParsed();

            // Extended attributes with same attribute name but different value.
            Assert.NotEqual(para, paraFooExtendedAttribute, DefaultComparer);

            // Unless extended attributes are not considered.
            Assert.Equal(para, paraFooExtendedAttribute, DefaulttComparerMinusExtended);

            // Extended attribute with different attribute name.
            Assert.NotEqual(para, paraBarExtendedAttribute, DefaultComparer);

            // Unless extended attributes are not considered.
            Assert.Equal(para, paraBarExtendedAttribute, DefaulttComparerMinusExtended);

            // With different amount of extended attributes.
            Assert.NotEqual(para, paraNoExtendedAttribute, DefaultComparer);

            // Unless extended attributes are not considered.
            Assert.Equal(para, paraNoExtendedAttribute, DefaulttComparerMinusExtended);
        }

        [Fact]
        public void DifferentChildValueTest()
        {
            // C:\src\Open-XML-SDK\data\schemas\schemas_openxmlformats_org_wordprocessingml_2006_main.json :: 13537
            string paraChildRun1Xml = "<w:p w:rsidP=\"001\" xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\"><w:r><w:t>Run Text.</w:t><w:t>Run 1.</w:t></w:r></w:p>";
            string paraChildRun2Xml = "<w:p w:rsidP=\"001\" xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\"><w:r><w:t>Run Text.</w:t><w:t>Run 2.</w:t></w:r></w:p>";
            Paragraph paraChildRun1 = new Paragraph(paraChildRun1Xml);
            Paragraph paraChildRun2 = new Paragraph(paraChildRun2Xml);

            Assert.NotEqual(paraChildRun1, paraChildRun2, DefaultComparer);

            paraChildRun1.MakeSureParsed();
            paraChildRun2.MakeSureParsed();

            Assert.NotEqual(paraChildRun1, paraChildRun2, DefaultComparer);
        }

        /// <summary>
        /// Test that documents the specified order of children matters for unparsed equality checks, but not parse equality checks.
        /// </summary>
        [Fact]
        public void ChildrenOrderingSameButDifferentNamespace()
        {
            string paraXml1 = "<w:p w:rsidP=\"001\" xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\"><m:r xmlns:m=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\"/><w:r/></w:p>";
            string paraXml2 = "<w:p w:rsidP=\"001\" xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\"><w:r/><m:r xmlns:m=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\"/></w:p>";
            Paragraph para1 = new Paragraph(paraXml1);
            Paragraph para2 = new Paragraph(paraXml2);

            Assert.NotEqual(para1, para2, DefaultComparer);

            para1.MakeSureParsed();
            para2.MakeSureParsed();

            Assert.NotEqual(para1, para2, DefaultComparer);
        }

        /// <summary>
        /// Test that documents the specified order of children isn't guaranteed for equality.
        /// </summary>
        [Fact]
        public void ChildrenOrderingDifferentChildren()
        {
            string paraXml1 = "<w:p w:rsidP=\"001\" xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\"><w:sdt/><w:r/></w:p>";
            string paraXml2 = "<w:p w:rsidP=\"001\" xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\"><w:r/><w:sdt/></w:p>";
            Paragraph para1 = new Paragraph(paraXml1);
            Paragraph para2 = new Paragraph(paraXml2);

            Assert.NotEqual(para1, para2, DefaultComparer);

            para1.MakeSureParsed();
            para2.MakeSureParsed();

            Assert.NotEqual(para1, para2, DefaultComparer);
        }

        [Fact]
        public void DifferentAmountOfChildrenTest()
        {
            string paraChildRun1Xml = "<w:p w:rsidP=\"001\" xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\"><w:r/></w:p>";
            string paraChildRun2Xml = "<w:p w:rsidP=\"001\" xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\"><w:r/><w:t/></w:p>";
            Paragraph paraChildRun1 = new Paragraph(paraChildRun1Xml);
            Paragraph paraChildRun2 = new Paragraph(paraChildRun2Xml);

            Assert.NotEqual(paraChildRun1, paraChildRun2, DefaultComparer);

            paraChildRun1.MakeSureParsed();
            paraChildRun2.MakeSureParsed();

            Assert.NotEqual(paraChildRun1, paraChildRun2, DefaultComparer);
        }

        /// <summary>
        /// Test that shows namespaces is considered for equality.
        /// </summary>
        [Fact]
        public void NamespaceDifferenceTest()
        {
            // C:\src\Open-XML-SDK\data\schemas\schemas_openxmlformats_org_wordprocessingml_2006_main.json :: 13537
            string paraChildRun1Xml = "<w:p w:rsidP=\"001\" xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\"><w:r><w:t>Run Text.</w:t><w:t>Run 1.</w:t></w:r></w:p>";
            string paraChildRun2Xml = "<q:p q:rsidP=\"001\" xmlns:q=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\"><q:r><q:t>Run Text.</q:t><q:t>Run 1.</q:t></q:r></q:p>";
            Paragraph paraChildRun1 = new Paragraph(paraChildRun1Xml);
            Paragraph paraChildRun2 = new Paragraph(paraChildRun2Xml);

            Assert.NotEqual(paraChildRun1, paraChildRun2, DefaultComparer);

            paraChildRun1.MakeSureParsed();
            paraChildRun2.MakeSureParsed();

            Assert.NotEqual(paraChildRun1, paraChildRun2, DefaultComparer);
        }

        /// <summary>
        /// Test that documents the specified order of attributes matters for unparsed equality checks, but not parse equality checks.
        /// </summary>
        [Fact]
        public void AttributeOrderingTest()
        {
            string paraXml1 = "<w:p w:rsidP=\"001\" xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\" w:rsidR=\"123\"/>";
            string paraXml2 = "<w:p w:rsidR=\"123\" xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\" w:rsidP=\"001\"/>";
            Paragraph para1 = new Paragraph(paraXml1);
            Paragraph para2 = new Paragraph(paraXml2);

            // While unparsed, there is no guarantees for ordering on attributes fpr equality.
            // The order in the input XML doc is used.
            Assert.NotEqual(para1, para2, DefaultComparer);

            para1.MakeSureParsed();
            para2.MakeSureParsed();

            // After parsing the order from schema is used.
            Assert.Equal(para1, para2, DefaultComparer);
        }

        /// <summary>
        /// Test that documents the specified order of extended attributes matters for equality.
        /// </summary>
        [Fact]
        public void ExtendedAttributeOrderingTest()
        {
            string paraChildRun1Xml = "<w:p w:rsidR=\"123\" xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\" foo1=\"bar1\" foo2=\"bar2\"/>";
            string paraChildRun2Xml = "<w:p w:rsidR=\"123\" xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\" foo2=\"bar2\" foo1=\"bar1\" />";
            Paragraph para1 = new Paragraph(paraChildRun1Xml);
            Paragraph para2 = new Paragraph(paraChildRun2Xml);

            Assert.NotEqual(para1, para2, DefaultComparer);

            // Order is still important after parsing, since schema doesn't define order for extended attributes.
            para1.MakeSureParsed();
            para2.MakeSureParsed();

            Assert.NotEqual(para1, para2, DefaultComparer);
        }

        /// <summary>
        /// Test that shows Markup Compatibility Attributes are accounted for for equality.
        /// </summary>
        [Fact]
        public void MarkupAttributeTest()
        {
            string xml = "<w:p w:rsidR=\"123\" xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\"/>";
            Paragraph para1 = new Paragraph(xml);
            Paragraph para2 = new Paragraph(xml);

            Assert.True(DefaultComparer.Equals(para1, para2));

            para2.SetPreserveElements("*");

            Assert.NotEqual(para1, para2, DefaultComparer);

            para1.SetPreserveAttributes("*");

            // Test that different MC attributes are not equal.
            Assert.NotEqual(para1, para2, DefaultComparer);

            // Unless it is selected that it shouldn't be considered in equality tests.
            Assert.Equal(para1, para1, DefaultComparerMinusMC);
        }

        /// <summary>
        /// Test that shows <see cref="OpenXmlElementEqualityOptions.RequireParsed"/> will triggering parsing.
        /// </summary>
        [Fact]
        public void IgnoreParseTest()
        {
            string paraXml1 = "<w:p w:rsidP=\"001\" xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\" w:rsidR=\"123\"/>";
            string paraXml2 = "<w:p w:rsidR=\"123\" xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\" w:rsidP=\"001\"/>";
            Paragraph para1 = new Paragraph(paraXml1);
            Paragraph para2 = new Paragraph(paraXml2);

            // While unparsed, there is no guarantees for ordering on attributes fpr equality.
            // The order in the input XML doc is used. Use Comparer to ensure parsed.
            Assert.NotEqual(para1, para2, DefaultComparer);
            Assert.Equal(para1, para2, DefaultComparerRequireParsed);
        }

        /// <summary>
        /// Test that documents that GetHashCode is stable, allowing for GetHashCode/Equals to be used in dictionary/hashset.
        /// </summary>
        [Fact]
        public void GetHashCodeEqualityTest()
        {
            var hs = new HashSet<OpenXmlElement>(DefaultComparer);

            string paraXml = "<w:p w:rsidP=\"001\" xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\"><w:r><w:t>Run Text.</w:t><w:t>Run 1.</w:t></w:r></w:p>";
            Paragraph para1 = new Paragraph(paraXml);
            Paragraph para2 = new Paragraph(paraXml);

            para1.MakeSureParsed();
            para2.MakeSureParsed();

            hs.Add(para1);

            Assert.Contains(para2, hs);
        }
    }
}
