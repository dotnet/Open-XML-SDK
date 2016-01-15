// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using DocumentFormat.OpenXml.Packaging;
using Xunit;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Validation;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Linq;
using System.IO;
#if WB
using DocumentFormat.OpenXml.WB.Tests;
#endif

namespace DocumentFormat.OpenXml.Tests
{
    
    
    /// <summary>
    ///This is a test class for OpenXmlPartTest and is intended
    ///to contain all OpenXmlPartTest Unit Tests
    ///</summary>
    
    public class OpenXmlPartTest
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

        /// <summary>
        ///A test for RootElement
        ///</summary>
        [Fact]
        public void RootElementTest()
        {
            using (var stream = new System.IO.MemoryStream(TestFileStreams.complex0docx, false))
            {
                using (WordprocessingDocument testDocument = WordprocessingDocument.Open(stream, false))
                {
                    OpenXmlPart target = testDocument.MainDocumentPart;
                    OpenXmlPartRootElement actual;
                    actual = target.RootElement;
                    Assert.IsType(typeof(Document), actual);
                    Assert.Same(testDocument.MainDocumentPart.Document, actual);


                    target = testDocument.MainDocumentPart.WordprocessingCommentsPart;
                    actual = target.RootElement;
                    Assert.IsType(typeof(Comments), actual);
                    Assert.Same(testDocument.MainDocumentPart.WordprocessingCommentsPart.Comments, actual);

                    target = testDocument.MainDocumentPart.ImageParts.First();
                    actual = target.RootElement;
                    Assert.Null(actual);
                }
            }

            using (System.IO.Stream stream = new System.IO.MemoryStream())
            {
                using (var testDocument = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document))
                {
                    var mainPart = testDocument.AddMainDocumentPart();
                    Assert.Null(mainPart.Document);

                    using (var partStream = mainPart.GetStream(FileMode.OpenOrCreate, FileAccess.Write))
                    using (var textWriter = new StreamWriter(partStream))
                    {
                        textWriter.WriteLine(" ");
                    }
                    Assert.Null(mainPart.Document);
                }
            }
        }

        ///<summary>
        ///HyperlinkRelationshipTest.
        ///</summary>
        [Fact]
        public void HyperlinkRelationshipTest()
        {
            using (var stream = new System.IO.MemoryStream(TestFileStreams.May_12_04, false))
            {
                using (WordprocessingDocument testDocument = WordprocessingDocument.Open(stream, false))
                {
                    OpenXmlValidator validator = new OpenXmlValidator();
                    var errors = validator.Validate(testDocument);
                    Assert.Equal(0, errors.Count());

                    var mainPart = testDocument.MainDocumentPart;

                    Assert.Equal(0, mainPart.ExternalRelationships.Count());
                    Assert.Equal(71, mainPart.HyperlinkRelationships.Count());

                    var rid15 = mainPart.GetReferenceRelationship("rId15");
                    Assert.Equal("rId15", rid15.Id);
                    Assert.Equal(new System.Uri("#_THIS_WEEK_IN", System.UriKind.Relative), rid15.Uri);
                    Assert.False(rid15.IsExternal);

                    var rid18 = mainPart.GetReferenceRelationship("rId18");
                    Assert.Equal("rId18", rid18.Id);
                    Assert.Equal(new System.Uri("http://www.iaswresearch.org/"), rid18.Uri);
                    Assert.True(rid18.IsExternal);
                }
            }

            using (System.IO.Stream stream = new System.IO.MemoryStream())
            {
                using (var testDocument = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document))
                {
                    var mainPart = testDocument.AddMainDocumentPart();
                    var paragraph = new DocumentFormat.OpenXml.Wordprocessing.Paragraph(new Body());
                    mainPart.Document = new Document(new Body(paragraph));
                    mainPart.Document.Save();

                    var newUri = new System.Uri("#New", System.UriKind.Relative);
                    var ridnew = mainPart.AddHyperlinkRelationship(newUri, false);
                    var newRel = mainPart.PackagePart.GetRelationship(ridnew.Id);
                    Assert.Equal(System.IO.Packaging.TargetMode.Internal, newRel.TargetMode);
                    Assert.Equal(ridnew.Id, newRel.Id);
                    Assert.Equal(newUri, newRel.TargetUri);
                    Assert.Equal(HyperlinkRelationship.RelationshipTypeConst, newRel.RelationshipType);

                    mainPart.DeleteReferenceRelationship(ridnew);
                    Assert.Equal(0, mainPart.HyperlinkRelationships.Count());

                    newUri = new System.Uri("http://microsoft.com", System.UriKind.Absolute);
                    ridnew = mainPart.AddHyperlinkRelationship(newUri, true, ridnew.Id);
                    newRel = mainPart.PackagePart.GetRelationship(ridnew.Id);
                    Assert.Equal(System.IO.Packaging.TargetMode.External, newRel.TargetMode);
                    Assert.Equal(ridnew.Id, newRel.Id);
                    Assert.Equal(newUri, newRel.TargetUri);
                    Assert.Equal(HyperlinkRelationship.RelationshipTypeConst, newRel.RelationshipType);

                }

                // Test the OpenXmlPartContainer.AddSubPartFromOtherPackage().
                // The method should import all hyperlink relationships.
                stream.Seek(0, System.IO.SeekOrigin.Begin);
                using (var testDocument = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document))
                {
                    using (var sourcestream = new System.IO.MemoryStream(TestFileStreams.May_12_04, false))
                    {
                        using (WordprocessingDocument sourceDocument = WordprocessingDocument.Open(sourcestream, false))
                        {
                            var parts = new System.Collections.Generic.Dictionary<OpenXmlPart, bool>();
                            sourceDocument.MainDocumentPart.FindAllReachableParts(parts);
                            var partCounts = parts.Count;

                            var hyperlinksBefore = sourceDocument.MainDocumentPart.HyperlinkRelationships.ToArray();
                            var externalRelsBefore = sourceDocument.MainDocumentPart.ExternalRelationships.ToArray();

                            testDocument.AddPart(sourceDocument.MainDocumentPart);
                            parts.Clear();
                            testDocument.MainDocumentPart.FindAllReachableParts(parts);

                            // all parts under the main document part should be imported.
                            Assert.Equal(partCounts, parts.Count);

                            var hyperlinksAfter = testDocument.MainDocumentPart.HyperlinkRelationships.ToArray();
                            var externalRelsAfter = testDocument.MainDocumentPart.ExternalRelationships.ToArray();

                            // all hyperlink relationships should be imported.
                            Assert.Equal(hyperlinksBefore.Length, hyperlinksAfter.Length);
                            for (int i = 0; i < hyperlinksBefore.Length; i++)
                            {
                                Assert.Equal(hyperlinksBefore[i].Id, hyperlinksAfter[i].Id);
                                Assert.Equal(hyperlinksBefore[i].IsExternal, hyperlinksAfter[i].IsExternal);
                                Assert.Equal(hyperlinksBefore[i].Uri, hyperlinksAfter[i].Uri);
                            }

                            // all external relationships should be improted.
                            Assert.Equal(externalRelsBefore.Length, externalRelsAfter.Length);
                        }
                    }
                }
            }
        }

        ///<summary>
        ///ChangePartIdTest.
        ///</summary>
        [Fact]
        public void ChangePartIdTest()
        {
            using (Stream stream = new MemoryStream())
            {
                using (var testDocument = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document))
                {
                    var mainDocPart = testDocument.AddMainDocumentPart();
                    var commentsPart = mainDocPart.AddNewPart<WordprocessingCommentsPart>("rId1");
                    var headerPart = mainDocPart.AddNewPart<HeaderPart>("rId2");

                    mainDocPart.ChangeIdOfPart(commentsPart, "rId3");
                    mainDocPart.ChangeIdOfPart(headerPart, "rId1");

                    Assert.Equal(2, mainDocPart.ChildrenParts.Count());
                    Assert.False(mainDocPart.ChildrenParts.ContainsKey("rId2"));
                    Assert.True(mainDocPart.ChildrenParts.ContainsKey("rId3"));

                    var rId = mainDocPart.GetIdOfPart(mainDocPart.WordprocessingCommentsPart);
                    Assert.Equal("rId3", rId);
                    var rId1Part = mainDocPart.GetPartById("rId1");
                    Assert.IsType(typeof(HeaderPart), rId1Part);
                    Assert.Same(headerPart, rId1Part);
                }

                stream.Flush();

                using (WordprocessingDocument loadedDoc = WordprocessingDocument.Open(stream, false))
                {
                    var mainDocPart = loadedDoc.MainDocumentPart;
                    Assert.Equal(2, mainDocPart.ChildrenParts.Count());

                    var rId = mainDocPart.GetIdOfPart(mainDocPart.WordprocessingCommentsPart);
                    Assert.Equal("rId3", rId);
                    var headerPart = mainDocPart.GetPartById("rId1");
                    Assert.IsType(typeof(HeaderPart), headerPart);
                    Assert.Same(mainDocPart.HeaderParts.First(), headerPart);
                }
            }
        }

        ///<summary>
        ///AddPartTest.
        ///</summary>
        [Fact]
        public void AddPartTest()
        {
            using (var stream = new MemoryStream())
            {
                using (var doc = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document))
                {
                    doc.AddMainDocumentPart();
                    var document = doc.MainDocumentPart.Document = new Document();
                    document.Save();
                    var imagePart = doc.MainDocumentPart.AddImagePart(ImagePartType.Jpeg);
                    var extendedSubPart = doc.MainDocumentPart.AddExtendedPart("http://temp", "text/xml", ".xml", "tempId");

                    var extendedPart = doc.AddExtendedPart("http://temp", "text/xml", ".xml", "tempId");

                    // can add parts 
                    OpenXmlPart subPart = extendedPart.AddPart(doc.MainDocumentPart);
                    Assert.Same(subPart, doc.MainDocumentPart);

                    var rId = extendedPart.CreateRelationshipToPart(imagePart);
                    Assert.Same(imagePart, extendedPart.GetPartById(rId));

                    // can add ExtendedPart.
                    subPart = extendedPart.AddPart(extendedSubPart);
                    Assert.Same(extendedSubPart, subPart);

                    // Can create new strong typed part under ExtendedPart.
                    subPart = extendedPart.AddNewPart<CustomXmlPart>("application/xml", "data1");
                    Assert.Same(subPart, extendedPart.GetSubPartOfType<CustomXmlPart>());

                    subPart = extendedPart.AddExtendedPart("http://temp", "text/xml", ".xml", "tempId2");
                    Assert.Same(subPart, extendedPart.GetPartById("tempId2"));

                    extendedPart.DeletePart(subPart);

                    extendedPart.DeletePart(extendedPart.GetSubPartOfType<ImagePart>());
                    Assert.Null(extendedPart.GetSubPartOfType<ImagePart>());

                    extendedPart.DeleteParts(extendedPart.GetPartsOfType<ImagePart>().ToArray());
                    Assert.Null(extendedPart.GetSubPartOfType<ImagePart>());
                }
            }
        }
    }
}
