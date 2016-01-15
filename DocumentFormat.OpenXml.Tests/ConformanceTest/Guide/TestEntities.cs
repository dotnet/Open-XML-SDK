// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentFormat.OpenXml.Tests.GuideTest
{
    using DocumentFormat.OpenXml.Packaging;
    using DocumentFormat.OpenXml.Presentation;
    using P15 = DocumentFormat.OpenXml.Office2013.PowerPoint;
    using A = DocumentFormat.OpenXml.Drawing;
    using LogUtil;

    public class TestEntities
    {
        #region Setting values
        //sldGuideLst pos attribute vallues.
        private readonly int position1 = 1000;
        private readonly int position2 = 2000;
        private readonly int position3 = 3000;
        private readonly int position4 = 4000;
        //sldGuideLst orient attribute vallues.
        private readonly DirectionValues directionValues1 = DirectionValues.Horizontal;
        private readonly DirectionValues directionValues2 = DirectionValues.Vertical;
        //ExtendedGuide RgbColorModelHex vallues.
        private readonly string Color1 = "FF0000";
        private readonly string Color2 = "00FF00";
        private readonly string Color3 = "0000FF";
        private readonly string Color4 = "F0F0F0";
        //ExtendedGuide Id vallues.
        private readonly uint Id1 = 1;
        private readonly uint Id2 = 2;
        private readonly uint Id3 = 3;
        private readonly uint Id4 = 4;
        #endregion

        #region Property
        /// <summary>
        /// URI attribute value of PresentationExtension.(Parent of P15.SlideGuideList elemenet)
        /// </summary>
        private string SldExtUri { get; set; }
        /// <summary>
        /// URI attribute value of PresentationExtension.(Parent of P15.NotesGuideList elemenet)
        /// </summary>
        private string NotesExtUri { get; set; }
        #endregion

        /// <summary>
        /// Constructor
        /// Get URI attribute value of PresentationExtension
        /// </summary>
        /// <param name="filePath">Generated file path</param>
        public TestEntities(string filePath)
        {
            using (PresentationDocument package = PresentationDocument.Open(filePath, false))
            {
                //Get Extension Uri value. (This element is P15.SlideGuideList parrent element.)
                P15.SlideGuideList slideGuideList = package.PresentationPart.RootElement.Descendants<P15.SlideGuideList>().Single();
                PresentationExtension slideGuidePresentationExtension = (PresentationExtension)slideGuideList.Parent;
                this.SldExtUri = slideGuidePresentationExtension.Uri;
                if (string.IsNullOrEmpty(this.SldExtUri))
                    throw new Exception("Uri attribute value in Extension element is not set. It element of P15.SlideGuideList parent element.");

                //Get Extension Uri value. (This element is P15.SlideGuideList parrent element.)
                P15.NotesGuideList notesGuideList = package.PresentationPart.RootElement.Descendants<P15.NotesGuideList>().Single();
                PresentationExtension notesGuidePresentationExtension = (PresentationExtension)notesGuideList.Parent;
                this.NotesExtUri = notesGuidePresentationExtension.Uri;
                if (string.IsNullOrEmpty(this.NotesExtUri))
                    throw new Exception("Uri attribute value in Extension element is not set. It element of P15.SlideGuideList parent element.");
            }
        }

        /// <summary>
        /// Editing PresentationExtensionList element.
        /// </summary>
        /// <param name="filePath">Tartget file path</param>
        /// <param name="log">Logger</param>
        public void EditElement(string filePath, VerifiableLog log)
        {
            using (PresentationDocument package = PresentationDocument.Open(filePath, true))
            {
                PresentationExtensionList presentationExtensionList = package.PresentationPart.RootElement.Descendants<PresentationExtensionList>().Single();
                PresentationExtension PresentationExtension1 = package.PresentationPart.RootElement.Descendants<PresentationExtension>().Where(e => e.Uri == this.SldExtUri).Single();
                P15.ExtendedGuideList extendedGuideList1 = PresentationExtension1.Descendants<P15.SlideGuideList>().Single();

                //Editing Guide(1) element
                P15.ExtendedGuide extendedGuide1 = extendedGuideList1.Descendants<P15.ExtendedGuide>().Where(e => e.Id == this.Id1).Single();
                extendedGuide1.Position = this.position1;
                extendedGuide1.Orientation = this.directionValues1;

                A.RgbColorModelHex rgbColorModelHex1 = extendedGuide1.Descendants<A.RgbColorModelHex>().First();
                rgbColorModelHex1.Val.Value = this.Color1;

                //Editing Guide(2) element
                P15.ExtendedGuide extendedGuide2 = extendedGuideList1.Descendants<P15.ExtendedGuide>().Where(e => e.Id == this.Id2).Single();
                extendedGuide2.Position = this.position2;
                extendedGuide2.Orientation = this.directionValues2;

                A.RgbColorModelHex rgbColorModelHex2 = extendedGuide2.Descendants<A.RgbColorModelHex>().First();
                rgbColorModelHex2.Val.Value = this.Color2;

                log.Pass("Edited the ExtendedGuideList element.");

                PresentationExtension PresentationExtension2 = package.PresentationPart.RootElement.Descendants<PresentationExtension>().Where(e => e.Uri == this.NotesExtUri).Single();

                P15.NotesGuideList notesGuideList = PresentationExtension2.Descendants<P15.NotesGuideList>().Single();

                //Editing Guide(NotesGuide_1) element
                P15.ExtendedGuide extendedGuide3 = notesGuideList.Descendants<P15.ExtendedGuide>().Where(e => e.Id == this.Id1).Single();
                extendedGuide3.Position = this.position3;
                extendedGuide3.Orientation = this.directionValues2;

                A.RgbColorModelHex rgbColorModelHex3 = extendedGuide3.Descendants<A.RgbColorModelHex>().First();
                rgbColorModelHex3.Val.Value = this.Color3;

                //Editing Guide(NotesGuide_2) element
                P15.ExtendedGuide extendedGuide4 = notesGuideList.Descendants<P15.ExtendedGuide>().Where(e => e.Id == this.Id2).Single();
                extendedGuide4.Position = this.position4;
                extendedGuide4.Orientation = this.directionValues1;

                A.RgbColorModelHex rgbColorModelHex4 = extendedGuide4.Descendants<A.RgbColorModelHex>().First();
                rgbColorModelHex4.Val.Value = this.Color4;

                log.Pass("Edited the NotesGuideList element.");
            }
        }

        /// <summary>
        /// Verifying PresentationExtensionList element.
        /// </summary>
        /// <param name="filePath">Tartget file path</param>
        /// <param name="log">Logger</param>
        public void VerifyElement(string filePath, VerifiableLog log)
        {
            using (PresentationDocument package = PresentationDocument.Open(filePath, false))
            {
                //Verify ExtendedGuideList
                PresentationExtensionList presentationExtensionList = package.PresentationPart.RootElement.Descendants<PresentationExtensionList>().Single();
                PresentationExtension PresentationExtension1 = package.PresentationPart.RootElement.Descendants<PresentationExtension>().Where(e => e.Uri == this.SldExtUri).Single();
                P15.ExtendedGuideList extendedGuideList1 = PresentationExtension1.Descendants<P15.SlideGuideList>().Single();

                //Verifying Guide(1) element
                P15.ExtendedGuide extendedGuide1 = extendedGuideList1.Descendants<P15.ExtendedGuide>().Where(e => e.Id == this.Id1).Single();

                log.Verify(extendedGuide1.Position == this.position1, "An incorrect value, Position value of ExtendedGuide. Id=[{0}].", extendedGuide1.Id);
                log.Verify(extendedGuide1.Orientation == this.directionValues1, "An incorrect value, Orientation value of ExtendedGuide. Id=[{0}].", extendedGuide1.Id);
                A.RgbColorModelHex rgbColorModelHex1 = extendedGuide1.Descendants<A.RgbColorModelHex>().First();
                log.Verify(rgbColorModelHex1.Val.Value == this.Color1, "An incorrect value, RgbColorModelHex value. Guide Id=[{0}].", extendedGuide1.Id);

                //Verifying Guide(2) element
                P15.ExtendedGuide extendedGuide2 = extendedGuideList1.Descendants<P15.ExtendedGuide>().Where(e => e.Id == this.Id2).Single();

                log.Verify(extendedGuide2.Position == this.position2, "An incorrect value, Position value of ExtendedGuide. Id=[{0}].", extendedGuide1.Id);
                log.Verify(extendedGuide2.Orientation == this.directionValues2, "An incorrect value, Orientation value of ExtendedGuide. Id=[{0}].", extendedGuide1.Id);
                A.RgbColorModelHex rgbColorModelHex2 = extendedGuide2.Descendants<A.RgbColorModelHex>().First();
                log.Verify(rgbColorModelHex2.Val.Value == this.Color2, "An incorrect value, RgbColorModelHex value. Guide Id=[{0}].", extendedGuide1.Id);


                //Verify NotesGuideList
                PresentationExtension PresentationExtension2 = package.PresentationPart.RootElement.Descendants<PresentationExtension>().Where(e => e.Uri == this.NotesExtUri).Single();
                P15.NotesGuideList notesGuideList = PresentationExtension2.Descendants<P15.NotesGuideList>().Single();

                //Verifying Guide(1) element
                P15.ExtendedGuide extendedGuide3 = notesGuideList.Descendants<P15.ExtendedGuide>().Where(e => e.Id == this.Id1).Single();

                log.Verify(extendedGuide3.Position == this.position3, "An incorrect value, Position value of ExtendedGuide. Id=[{0}].", extendedGuide1.Id);
                log.Verify(extendedGuide3.Orientation == this.directionValues2, "An incorrect value, Orientation value of ExtendedGuide. Id=[{0}].", extendedGuide1.Id);
                A.RgbColorModelHex rgbColorModelHex3 = extendedGuide3.Descendants<A.RgbColorModelHex>().First();
                log.Verify(rgbColorModelHex3.Val.Value == this.Color3, "An incorrect value, RgbColorModelHex value. Guide Id=[{0}].", extendedGuide1.Id);

                //Verifying Guide(2) element
                P15.ExtendedGuide extendedGuide4 = notesGuideList.Descendants<P15.ExtendedGuide>().Where(e => e.Id == this.Id2).Single();

                log.Verify(extendedGuide4.Position == this.position4, "An incorrect value, Position value of ExtendedGuide. Id=[{0}].", extendedGuide1.Id);
                log.Verify(extendedGuide4.Orientation == this.directionValues1, "An incorrect value, Orientation value of ExtendedGuide. Id=[{0}].", extendedGuide1.Id);
                A.RgbColorModelHex rgbColorModelHex4 = extendedGuide4.Descendants<A.RgbColorModelHex>().First();
                log.Verify(rgbColorModelHex4.Val.Value == this.Color4, "An incorrect value, RgbColorModelHex value. Guide Id=[{0}].", extendedGuide1.Id);
            }
        }

        /// <summary>
        /// Deleting PresentationExtensionList element.
        /// </summary>
        /// <param name="filePath">Tartget file path</param>
        /// <param name="log">Logger</param>
        public void DeleteElement(string filePath, VerifiableLog log)
        {
            using (PresentationDocument package = PresentationDocument.Open(filePath, true))
            {
                //Delete RgbColorModelHex element
                foreach (A.RgbColorModelHex rgbColorModelHex in package.PresentationPart.RootElement.Descendants<A.RgbColorModelHex>())
                {
                    rgbColorModelHex.Remove();
                }
                log.Pass("Deleted the RgbColorModelHex element.");

                //Delete ColorType element
                foreach (P15.ColorType colorType in package.PresentationPart.RootElement.Descendants<P15.ColorType>())
                {
                    colorType.Remove();
                }
                log.Pass("Deleted the ColorType element.");

                //Delete ExtendedGuide element
                foreach (P15.ExtendedGuide extendedGuide in package.PresentationPart.RootElement.Descendants<P15.ExtendedGuide>())
                {
                    extendedGuide.Remove();
                }
                log.Pass("Deleted the ExtendedGuide element.");

                //Delete ExtendedGuideList element(P15.ExtendedGuideList = P15.SlideGuideList)
                foreach (P15.ExtendedGuideList extendedGuideList in package.PresentationPart.RootElement.Descendants<P15.SlideGuideList>())
                {
                    extendedGuideList.Remove();
                }
                log.Pass("Deleted the ExtendedGuideList element.");

                //Delete PresentationExtension element
                foreach (PresentationExtension presentationExtension in package.PresentationPart.RootElement.Descendants<PresentationExtension>())
                {
                    presentationExtension.Remove();
                }
                log.Pass("Deleted the PresentationExtension element.");

                //Delete PresentationExtensionList element
                PresentationExtensionList presentationExtensionList = package.PresentationPart.RootElement.Descendants<PresentationExtensionList>().Single();
                presentationExtensionList.Remove();
                log.Pass("Deleted the PresentationExtensionList element.");
            }
        }

        /// <summary>
        /// Verifying PresentationExtensionList element.
        /// </summary>
        /// <param name="filePath">Tartget file path</param>
        /// <param name="log">Logger</param>
        public void VerifyDeletedElement(string filePath, VerifiableLog log)
        {
            using (PresentationDocument package = PresentationDocument.Open(filePath, false))
            {
                log.Verify(package.PresentationPart.RootElement.Descendants<PresentationExtensionList>().Count() == 0, "Exist PresentationExtensionList element.");

                log.Verify(package.PresentationPart.RootElement.Descendants<PresentationExtension>().Count() == 0, "Exist PresentationExtension element.");

                log.Verify(package.PresentationPart.RootElement.Descendants<P15.SlideGuideList>().Count() == 0, "Exist ExtendedGuideList element.");

                log.Verify(package.PresentationPart.RootElement.Descendants<P15.ExtendedGuide>().Count() == 0, "Exist ExtendedGuide element.");

                log.Verify(package.PresentationPart.RootElement.Descendants<P15.ColorType>().Count() == 0, "Exist ColorType element.");

                log.Verify(package.PresentationPart.RootElement.Descendants<A.RgbColorModelHex>().Count() == 0, "Exist RgbColorModelHex element.");
            }
        }

        /// <summary>
        /// Adding PresentationExtensionList element.
        /// </summary>
        /// <param name="filePath">Tartget file path</param>
        /// <param name="log">Logger</param>
        public void AddElement(string filePath, VerifiableLog log)
        {
            using (PresentationDocument package = PresentationDocument.Open(filePath, true))
            {
                //Adding Guide element
                A.RgbColorModelHex rgbColorModelHex1 = new A.RgbColorModelHex() { Val = this.Color3 };
                P15.ColorType colorType1 = new P15.ColorType();
                P15.ExtendedGuide ExtendedGuide1 = new P15.ExtendedGuide() { Id = this.Id3, Position = this.position3, Orientation = this.directionValues2 };
                P15.SlideGuideList slideGuideList = new P15.SlideGuideList();
                PresentationExtension presentationExtension1 = new PresentationExtension() { Uri = this.SldExtUri };
                PresentationExtensionList presentationExtensionList = new PresentationExtensionList();

                colorType1.AppendChild<A.RgbColorModelHex>(rgbColorModelHex1);
                log.Pass("Added RgbColorModelHex element. It SlideGuideList.");

                ExtendedGuide1.AppendChild<P15.ColorType>(colorType1);
                log.Pass("Added ColorType element. It SlideGuideList.");

                slideGuideList.AppendChild<P15.ExtendedGuide>(ExtendedGuide1);
                log.Pass("Added ExtendedGuide element. It SlideGuideList.");

                presentationExtension1.AppendChild<P15.SlideGuideList>(slideGuideList);
                log.Pass("Added SlideGuideList element. It SlideGuideList.");

                presentationExtensionList.AppendChild<PresentationExtension>(presentationExtension1);
                log.Pass("Added PresentationExtension element. It SlideGuideList.");

                //Adding NotesGuide element
                A.RgbColorModelHex rgbColorModelHex2 = new A.RgbColorModelHex() { Val = this.Color4 };
                P15.ColorType colorType2 = new P15.ColorType();
                P15.ExtendedGuide ExtendedGuide2 = new P15.ExtendedGuide() { Id = this.Id4, Position = this.position4, Orientation = this.directionValues2 };
                P15.NotesGuideList NotesGuideList = new P15.NotesGuideList();
                PresentationExtension presentationExtension2 = new PresentationExtension() { Uri = this.NotesExtUri };

                colorType2.AppendChild<A.RgbColorModelHex>(rgbColorModelHex2);
                log.Pass("Added RgbColorModelHex element. It SlideGuideList.");

                ExtendedGuide2.AppendChild<P15.ColorType>(colorType2);
                log.Pass("Added ColorType element. It SlideGuideList.");

                NotesGuideList.AppendChild<P15.ExtendedGuide>(ExtendedGuide2);
                log.Pass("Added ExtendedGuide element. It SlideGuideList.");

                presentationExtension2.AppendChild<P15.NotesGuideList>(NotesGuideList);
                log.Pass("Added SlideGuideList element. It SlideGuideList.");

                presentationExtensionList.AppendChild<PresentationExtension>(presentationExtension2);
                log.Pass("Added PresentationExtension element. It SlideGuideList.");

                package.PresentationPart.Presentation.Append(presentationExtensionList);
                log.Pass("Added PresentationExtensionList element. It SlideGuideList.");
            }
        }

        /// <summary>
        /// Verifying PresentationExtensionList element.
        /// </summary>
        /// <param name="filePath">Tartget file path</param>
        /// <param name="log">Logger</param>
        public void VerifyAddedElemenet(string filePath, VerifiableLog log)
        {
            using (PresentationDocument package = PresentationDocument.Open(filePath, false))
            {
                PresentationExtensionList presentationExtensionList = package.PresentationPart.RootElement.Descendants<PresentationExtensionList>().Single();
                log.Verify(package.PresentationPart.RootElement.Descendants<PresentationExtensionList>().Count() == 1, "PresentationExtensionList element not exist.");

                PresentationExtension PresentationExtension1 = presentationExtensionList.Descendants<PresentationExtension>().Where(e => e.Uri == this.SldExtUri).Single();
                log.Verify(PresentationExtension1.Count() == 1, "PresentationExtension element not exist. By SlideGuide.");

                log.Verify(PresentationExtension1.Descendants<P15.SlideGuideList>().Count() == 1, "SlideGuideList element not exist. By SlideGuide.");
                log.Verify(PresentationExtension1.Descendants<P15.ExtendedGuide>().Count() == 1, "ExtendedGuide element not exist. By SlideGuide.");
                log.Verify(PresentationExtension1.Descendants<P15.ColorType>().Count() == 1, "ColorType element not exist. By SlideGuide.");
                log.Verify(PresentationExtension1.Descendants<A.RgbColorModelHex>().Count() == 1, "RgbColorModelHex element not exist. By SlideGuide.");

                PresentationExtension PresentationExtension2 = presentationExtensionList.Descendants<PresentationExtension>().Where(e => e.Uri == this.NotesExtUri).Single();
                log.Verify(PresentationExtension2.Count() == 1, "PresentationExtension element not exist. By NotesGuide.");

                log.Verify(PresentationExtension2.Descendants<P15.NotesGuideList>().Count() == 1, "SlideGuideList element not exist. By NotesGuide.");
                log.Verify(PresentationExtension2.Descendants<P15.ExtendedGuide>().Count() == 1, "ExtendedGuide element not exist. By NotesGuide.");
                log.Verify(PresentationExtension2.Descendants<P15.ColorType>().Count() == 1, "ColorType element not exist. By NotesGuide.");
                log.Verify(PresentationExtension2.Descendants<A.RgbColorModelHex>().Count() == 1, "RgbColorModelHex element not exist. By NotesGuide.");
            }
        }
    }
}
