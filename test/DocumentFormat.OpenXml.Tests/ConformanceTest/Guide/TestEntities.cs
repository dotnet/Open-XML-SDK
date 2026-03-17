// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Presentation;
using System;
using System.IO;
using System.Linq;
using Xunit;

using A = DocumentFormat.OpenXml.Drawing;
using P15 = DocumentFormat.OpenXml.Office2013.PowerPoint;

namespace DocumentFormat.OpenXml.Tests.GuideTest
{
    public class TestEntities
    {
        #region Setting values

        // ExtendedGuide RgbColorModelHex values.
        private const string Color1 = "FF0000";
        private const string Color2 = "00FF00";
        private const string Color3 = "0000FF";
        private const string Color4 = "F0F0F0";

        // ExtendedGuide Id values.
        private const uint Id1 = 1;
        private const uint Id2 = 2;
        private const uint Id3 = 3;
        private const uint Id4 = 4;

        // sldGuideLst pos attribute values.
        private readonly int position1 = 1000;
        private readonly int position2 = 2000;
        private readonly int position3 = 3000;
        private readonly int position4 = 4000;

        // sldGuideLst orient attribute values.
        private readonly DirectionValues directionValues1 = DirectionValues.Horizontal;
        private readonly DirectionValues directionValues2 = DirectionValues.Vertical;
        #endregion

        /// <summary>
        /// Gets or sets URI attribute value of PresentationExtension.(Parent of P15.SlideGuideList element)
        /// </summary>
        private string SldExtUri { get; set; }

        /// <summary>
        /// Gets or sets URI attribute value of PresentationExtension.(Parent of P15.NotesGuideList element)
        /// </summary>
        private string NotesExtUri { get; set; }

        /// <summary>
        /// Constructor
        /// Get URI attribute value of PresentationExtension
        /// </summary>
        /// <param name="stream">Generated stream</param>
        public TestEntities(Stream stream)
        {
            using (PresentationDocument package = PresentationDocument.Open(stream, false))
            {
                // Get Extension Uri value. (This element is P15.SlideGuideList parent element.)
                P15.SlideGuideList slideGuideList = package.PresentationPart.RootElement.Descendants<P15.SlideGuideList>().Single();
                PresentationExtension slideGuidePresentationExtension = (PresentationExtension)slideGuideList.Parent;
                SldExtUri = slideGuidePresentationExtension.Uri;
                if (string.IsNullOrEmpty(SldExtUri))
                {
                    throw new Exception("Uri attribute value in Extension element is not set. It element of P15.SlideGuideList parent element.");
                }

                // Get Extension Uri value. (This element is P15.SlideGuideList parent element.)
                P15.NotesGuideList notesGuideList = package.PresentationPart.RootElement.Descendants<P15.NotesGuideList>().Single();
                PresentationExtension notesGuidePresentationExtension = (PresentationExtension)notesGuideList.Parent;
                NotesExtUri = notesGuidePresentationExtension.Uri;
                if (string.IsNullOrEmpty(NotesExtUri))
                {
                    throw new Exception("Uri attribute value in Extension element is not set. It element of P15.SlideGuideList parent element.");
                }
            }
        }

        /// <summary>
        /// Editing PresentationExtensionList element.
        /// </summary>
        /// <param name="stream">Target stream</param>
        /// <param name="log">Logger</param>
        internal void EditElement(Stream stream, ITestOutputHelper log)
        {
            using (PresentationDocument package = PresentationDocument.Open(stream, true))
            {
                PresentationExtensionList presentationExtensionList = package.PresentationPart.RootElement.Descendants<PresentationExtensionList>().Single();
                PresentationExtension presentationExtension1 = package.PresentationPart.RootElement.Descendants<PresentationExtension>().Where(e => e.Uri == SldExtUri).Single();
                P15.ExtendedGuideList extendedGuideList1 = presentationExtension1.Descendants<P15.SlideGuideList>().Single();

                // Editing Guide(1) element
                P15.ExtendedGuide extendedGuide1 = extendedGuideList1.Descendants<P15.ExtendedGuide>().Where(e => e.Id == Id1).Single();
                extendedGuide1.Position = position1;
                extendedGuide1.Orientation = directionValues1;

                A.RgbColorModelHex rgbColorModelHex1 = extendedGuide1.Descendants<A.RgbColorModelHex>().First();
                rgbColorModelHex1.Val.Value = Color1;

                // Editing Guide(2) element
                P15.ExtendedGuide extendedGuide2 = extendedGuideList1.Descendants<P15.ExtendedGuide>().Where(e => e.Id == Id2).Single();
                extendedGuide2.Position = position2;
                extendedGuide2.Orientation = directionValues2;

                A.RgbColorModelHex rgbColorModelHex2 = extendedGuide2.Descendants<A.RgbColorModelHex>().First();
                rgbColorModelHex2.Val.Value = Color2;

                log.WriteLine("Edited the ExtendedGuideList element.");

                PresentationExtension presentationExtension2 = package.PresentationPart.RootElement.Descendants<PresentationExtension>().Where(e => e.Uri == NotesExtUri).Single();

                P15.NotesGuideList notesGuideList = presentationExtension2.Descendants<P15.NotesGuideList>().Single();

                // Editing Guide(NotesGuide_1) element
                P15.ExtendedGuide extendedGuide3 = notesGuideList.Descendants<P15.ExtendedGuide>().Where(e => e.Id == Id1).Single();
                extendedGuide3.Position = position3;
                extendedGuide3.Orientation = directionValues2;

                A.RgbColorModelHex rgbColorModelHex3 = extendedGuide3.Descendants<A.RgbColorModelHex>().First();
                rgbColorModelHex3.Val.Value = Color3;

                // Editing Guide(NotesGuide_2) element
                P15.ExtendedGuide extendedGuide4 = notesGuideList.Descendants<P15.ExtendedGuide>().Where(e => e.Id == Id2).Single();
                extendedGuide4.Position = position4;
                extendedGuide4.Orientation = directionValues1;

                A.RgbColorModelHex rgbColorModelHex4 = extendedGuide4.Descendants<A.RgbColorModelHex>().First();
                rgbColorModelHex4.Val.Value = Color4;

                log.WriteLine("Edited the NotesGuideList element.");
            }
        }

        /// <summary>
        /// Verifying PresentationExtensionList element.
        /// </summary>
        /// <param name="stream">Target stream</param>
        /// <param name="log">Logger</param>
        internal void VerifyElement(Stream stream, ITestOutputHelper log)
        {
            using (PresentationDocument package = PresentationDocument.Open(stream, false))
            {
                // Verify ExtendedGuideList
                PresentationExtensionList presentationExtensionList = package.PresentationPart.RootElement.Descendants<PresentationExtensionList>().Single();
                PresentationExtension presentationExtension1 = package.PresentationPart.RootElement.Descendants<PresentationExtension>().Where(e => e.Uri == SldExtUri).Single();
                P15.ExtendedGuideList extendedGuideList1 = presentationExtension1.Descendants<P15.SlideGuideList>().Single();

                // Verifying Guide(1) element
                P15.ExtendedGuide extendedGuide1 = extendedGuideList1.Descendants<P15.ExtendedGuide>().Where(e => e.Id == Id1).Single();

                Assert.Equal(position1, extendedGuide1.Position);
                Assert.Equal(directionValues1, extendedGuide1.Orientation);
                A.RgbColorModelHex rgbColorModelHex1 = extendedGuide1.Descendants<A.RgbColorModelHex>().First();
                Assert.Equal(Color1, rgbColorModelHex1.Val.Value);

                // Verifying Guide(2) element
                P15.ExtendedGuide extendedGuide2 = extendedGuideList1.Descendants<P15.ExtendedGuide>().Where(e => e.Id == Id2).Single();

                Assert.Equal(position2, extendedGuide2.Position);
                Assert.Equal(directionValues2, extendedGuide2.Orientation);
                A.RgbColorModelHex rgbColorModelHex2 = extendedGuide2.Descendants<A.RgbColorModelHex>().First();
                Assert.Equal(Color2, rgbColorModelHex2.Val.Value);

                // Verify NotesGuideList
                PresentationExtension presentationExtension2 = package.PresentationPart.RootElement.Descendants<PresentationExtension>().Where(e => e.Uri == NotesExtUri).Single();
                P15.NotesGuideList notesGuideList = presentationExtension2.Descendants<P15.NotesGuideList>().Single();

                // Verifying Guide(1) element
                P15.ExtendedGuide extendedGuide3 = notesGuideList.Descendants<P15.ExtendedGuide>().Where(e => e.Id == Id1).Single();

                Assert.Equal(position3, extendedGuide3.Position);
                Assert.Equal(directionValues2, extendedGuide3.Orientation);
                A.RgbColorModelHex rgbColorModelHex3 = extendedGuide3.Descendants<A.RgbColorModelHex>().First();
                Assert.Equal(Color3, rgbColorModelHex3.Val.Value);

                // Verifying Guide(2) element
                P15.ExtendedGuide extendedGuide4 = notesGuideList.Descendants<P15.ExtendedGuide>().Where(e => e.Id == Id2).Single();

                Assert.Equal(position4, extendedGuide4.Position);
                Assert.Equal(directionValues1, extendedGuide4.Orientation);
                A.RgbColorModelHex rgbColorModelHex4 = extendedGuide4.Descendants<A.RgbColorModelHex>().First();
                Assert.Equal(Color4, rgbColorModelHex4.Val.Value);
            }
        }

        /// <summary>
        /// Deleting PresentationExtensionList element.
        /// </summary>
        /// <param name="stream">Target stream</param>
        /// <param name="log">Logger</param>
        internal void DeleteElement(Stream stream, ITestOutputHelper log)
        {
            using (PresentationDocument package = PresentationDocument.Open(stream, true))
            {
                // Delete RgbColorModelHex element
                foreach (A.RgbColorModelHex rgbColorModelHex in package.PresentationPart.RootElement.Descendants<A.RgbColorModelHex>())
                {
                    rgbColorModelHex.Remove();
                }

                log.WriteLine("Deleted the RgbColorModelHex element.");

                // Delete ColorType element
                foreach (P15.ColorType colorType in package.PresentationPart.RootElement.Descendants<P15.ColorType>())
                {
                    colorType.Remove();
                }

                log.WriteLine("Deleted the ColorType element.");

                // Delete ExtendedGuide element
                foreach (P15.ExtendedGuide extendedGuide in package.PresentationPart.RootElement.Descendants<P15.ExtendedGuide>())
                {
                    extendedGuide.Remove();
                }

                log.WriteLine("Deleted the ExtendedGuide element.");

                // Delete ExtendedGuideList element(P15.ExtendedGuideList = P15.SlideGuideList)
                foreach (P15.ExtendedGuideList extendedGuideList in package.PresentationPart.RootElement.Descendants<P15.SlideGuideList>())
                {
                    extendedGuideList.Remove();
                }

                log.WriteLine("Deleted the ExtendedGuideList element.");

                // Delete PresentationExtension element
                foreach (PresentationExtension presentationExtension in package.PresentationPart.RootElement.Descendants<PresentationExtension>())
                {
                    presentationExtension.Remove();
                }

                log.WriteLine("Deleted the PresentationExtension element.");

                // Delete PresentationExtensionList element
                PresentationExtensionList presentationExtensionList = package.PresentationPart.RootElement.Descendants<PresentationExtensionList>().Single();
                presentationExtensionList.Remove();
                log.WriteLine("Deleted the PresentationExtensionList element.");
            }
        }

        /// <summary>
        /// Verifying PresentationExtensionList element.
        /// </summary>
        /// <param name="stream">Target stream</param>
        /// <param name="log">Logger</param>
        internal void VerifyDeletedElement(Stream stream, ITestOutputHelper log)
        {
            using (PresentationDocument package = PresentationDocument.Open(stream, false))
            {
                Assert.True(!package.PresentationPart.RootElement.Descendants<PresentationExtensionList>().Any(), "Exist PresentationExtensionList element.");

                Assert.True(!package.PresentationPart.RootElement.Descendants<PresentationExtension>().Any(), "Exist PresentationExtension element.");

                Assert.True(!package.PresentationPart.RootElement.Descendants<P15.SlideGuideList>().Any(), "Exist ExtendedGuideList element.");

                Assert.True(!package.PresentationPart.RootElement.Descendants<P15.ExtendedGuide>().Any(), "Exist ExtendedGuide element.");

                Assert.True(!package.PresentationPart.RootElement.Descendants<P15.ColorType>().Any(), "Exist ColorType element.");

                Assert.True(!package.PresentationPart.RootElement.Descendants<A.RgbColorModelHex>().Any(), "Exist RgbColorModelHex element.");
            }
        }

        /// <summary>
        /// Adding PresentationExtensionList element.
        /// </summary>
        /// <param name="stream">Target stream</param>
        /// <param name="log">Logger</param>
        internal void AddElement(Stream stream, ITestOutputHelper log)
        {
            using (PresentationDocument package = PresentationDocument.Open(stream, true))
            {
                // Adding Guide element
                A.RgbColorModelHex rgbColorModelHex1 = new A.RgbColorModelHex() { Val = Color3 };
                P15.ColorType colorType1 = new P15.ColorType();
                P15.ExtendedGuide extendedGuide1 = new P15.ExtendedGuide() { Id = Id3, Position = position3, Orientation = directionValues2 };
                P15.SlideGuideList slideGuideList = new P15.SlideGuideList();
                PresentationExtension presentationExtension1 = new PresentationExtension() { Uri = SldExtUri };
                PresentationExtensionList presentationExtensionList = new PresentationExtensionList();

                colorType1.AppendChild<A.RgbColorModelHex>(rgbColorModelHex1);
                log.WriteLine("Added RgbColorModelHex element. It SlideGuideList.");

                extendedGuide1.AppendChild<P15.ColorType>(colorType1);
                log.WriteLine("Added ColorType element. It SlideGuideList.");

                slideGuideList.AppendChild<P15.ExtendedGuide>(extendedGuide1);
                log.WriteLine("Added ExtendedGuide element. It SlideGuideList.");

                presentationExtension1.AppendChild<P15.SlideGuideList>(slideGuideList);
                log.WriteLine("Added SlideGuideList element. It SlideGuideList.");

                presentationExtensionList.AppendChild<PresentationExtension>(presentationExtension1);
                log.WriteLine("Added PresentationExtension element. It SlideGuideList.");

                // Adding NotesGuide element
                A.RgbColorModelHex rgbColorModelHex2 = new A.RgbColorModelHex() { Val = Color4 };
                P15.ColorType colorType2 = new P15.ColorType();
                P15.ExtendedGuide extendedGuide2 = new P15.ExtendedGuide() { Id = Id4, Position = position4, Orientation = directionValues2 };
                P15.NotesGuideList notesGuideList = new P15.NotesGuideList();
                PresentationExtension presentationExtension2 = new PresentationExtension() { Uri = NotesExtUri };

                colorType2.AppendChild<A.RgbColorModelHex>(rgbColorModelHex2);
                log.WriteLine("Added RgbColorModelHex element. It SlideGuideList.");

                extendedGuide2.AppendChild<P15.ColorType>(colorType2);
                log.WriteLine("Added ColorType element. It SlideGuideList.");

                notesGuideList.AppendChild<P15.ExtendedGuide>(extendedGuide2);
                log.WriteLine("Added ExtendedGuide element. It SlideGuideList.");

                presentationExtension2.AppendChild<P15.NotesGuideList>(notesGuideList);
                log.WriteLine("Added SlideGuideList element. It SlideGuideList.");

                presentationExtensionList.AppendChild<PresentationExtension>(presentationExtension2);
                log.WriteLine("Added PresentationExtension element. It SlideGuideList.");

                package.PresentationPart.Presentation.Append(presentationExtensionList);
                log.WriteLine("Added PresentationExtensionList element. It SlideGuideList.");
            }
        }

        /// <summary>
        /// Verifying PresentationExtensionList element.
        /// </summary>
        /// <param name="stream">Target stream</param>
        /// <param name="log">Logger</param>
        internal void VerifyAddedElemenet(Stream stream, ITestOutputHelper log)
        {
            using (PresentationDocument package = PresentationDocument.Open(stream, false))
            {
                PresentationExtensionList presentationExtensionList = package.PresentationPart.RootElement.Descendants<PresentationExtensionList>().Single();
                Assert.Equal(1, package.PresentationPart.RootElement.Descendants<PresentationExtensionList>().Count());

                PresentationExtension presentationExtension1 = presentationExtensionList.Descendants<PresentationExtension>().Where(e => e.Uri == SldExtUri).Single();
                Assert.Equal(1, presentationExtension1.Count());

                Assert.Equal(1, presentationExtension1.Descendants<P15.SlideGuideList>().Count());
                Assert.Equal(1, presentationExtension1.Descendants<P15.ExtendedGuide>().Count());
                Assert.Equal(1, presentationExtension1.Descendants<P15.ColorType>().Count());
                Assert.Equal(1, presentationExtension1.Descendants<A.RgbColorModelHex>().Count());

                PresentationExtension presentationExtension2 = presentationExtensionList.Descendants<PresentationExtension>().Where(e => e.Uri == NotesExtUri).Single();
                Assert.Equal(1, presentationExtension2.Count());

                Assert.Equal(1, presentationExtension2.Descendants<P15.NotesGuideList>().Count());
                Assert.Equal(1, presentationExtension2.Descendants<P15.ExtendedGuide>().Count());
                Assert.Equal(1, presentationExtension2.Descendants<P15.ColorType>().Count());
                Assert.Equal(1, presentationExtension2.Descendants<A.RgbColorModelHex>().Count());
            }
        }
    }
}
