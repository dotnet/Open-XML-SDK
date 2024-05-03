// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Office.Y2022.FeaturePropertyBag;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Linq;
using Xunit;

using static DocumentFormat.OpenXml.Tests.TestAssets;

using ExtensionList = DocumentFormat.OpenXml.Spreadsheet.ExtensionList;

namespace DocumentFormat.OpenXml.Framework.Tests.Particles
{
    public class DxfExtensionListTests2006main
    {
        [Theory]
        [InlineData(TestFiles.Table_With_Checkboxes_new_xlsx)]
        public void GetExtensionListChildren(string name)
        {
            using (var stream = GetStream(name))
            using (SpreadsheetDocument spd = SpreadsheetDocument.Open(stream, false))
            {
                Assert.NotNull(spd);
                Assert.NotNull(spd.WorkbookPart);

                WorksheetPart sheet = (WorksheetPart)spd.WorkbookPart.GetPartById("rId1");
                Assert.NotNull(sheet);

                WorkbookStylesPart stylespart = (WorkbookStylesPart)spd.WorkbookPart.WorkbookStylesPart;
                Assert.NotNull(stylespart);

                DifferentialFormats dxfcoll = stylespart.Stylesheet.Descendants<DifferentialFormats>().FirstOrDefault();
                Assert.NotNull(dxfcoll);

                DifferentialFormat diff = dxfcoll.GetFirstChild<DifferentialFormat>();
                Assert.NotNull(diff);

#pragma warning disable CS0618 // Type or member is obsolete
                Extension e = diff.ExtensionList.GetFirstChild<Extension>();

#pragma warning restore CS0618 // Type or member is obsolete
                DxfExtension e2 = diff.DxfExtensionList.GetFirstChild<DxfExtension>();

                // The goal is to have both of these be valid objects.
                Assert.NotNull(e2);

                Assert.Equal("{0417FA29-78FA-4A13-93AC-8FF0FAFDF519}", e2.Uri);

                DXFComplement complement = e2.GetFirstChild<DXFComplement>();
                Assert.NotNull(complement);

                Assert.NotNull(e);
                Assert.Equal("{0417FA29-78FA-4A13-93AC-8FF0FAFDF519}", e.Uri);
                complement = e.GetFirstChild<DXFComplement>();
                Assert.NotNull(complement);
            }
        }

        [Theory]
        [InlineData(TestFiles.Table_With_Checkboxes_new_xlsx)]
        public void SetExtensionListChildren(string name)
        {
            using (var stream = GetStream(name))
            using (SpreadsheetDocument spd = SpreadsheetDocument.Open(stream, false))
            {
                Assert.NotNull(spd);
                Assert.NotNull(spd.WorkbookPart);

                WorksheetPart sheet = (WorksheetPart)spd.WorkbookPart.GetPartById("rId1");
                Assert.NotNull(sheet);

                WorkbookStylesPart stylespart = (WorkbookStylesPart)spd.WorkbookPart.WorkbookStylesPart;
                Assert.NotNull(stylespart);

                DifferentialFormats dxfcoll = stylespart.Stylesheet.Descendants<DifferentialFormats>().FirstOrDefault();
                Assert.NotNull(dxfcoll);

                DifferentialFormat diff = new DifferentialFormat();

                ExtensionList eList = new ExtensionList(
                    new Extension() { Uri = "{0417FA29-78FA-4A13-93AC-8FF0FAFDF519}" });

                diff.AddChild(eList);
                dxfcoll.AddChild(diff);
#pragma warning disable CS0618 // Type or member is obsolete

                Extension e = diff.ExtensionList.GetFirstChild<Extension>();
#pragma warning restore CS0618 // Type or member is obsolete

                DxfExtension e2 = diff.DxfExtensionList.GetFirstChild<DxfExtension>();

                // The goal is to have both of these be valid objects.
                Assert.NotNull(e2);
                Assert.Equal("{0417FA29-78FA-4A13-93AC-8FF0FAFDF519}", e2.Uri);

                Assert.NotNull(e);
                Assert.Equal("{0417FA29-78FA-4A13-93AC-8FF0FAFDF519}", e.Uri);
            }
        }

        [Theory]
        [InlineData(TestFiles.Table_With_Checkboxes_new_xlsx)]
        public void SetExtensionListProperty(string name)
        {
            using (var stream = GetStream(name))
            using (SpreadsheetDocument spd = SpreadsheetDocument.Open(stream, false))
            {
                Assert.NotNull(spd);
                Assert.NotNull(spd.WorkbookPart);

                WorksheetPart sheet = (WorksheetPart)spd.WorkbookPart.GetPartById("rId1");
                Assert.NotNull(sheet);

                WorkbookStylesPart stylespart = (WorkbookStylesPart)spd.WorkbookPart.WorkbookStylesPart;
                Assert.NotNull(stylespart);

                DifferentialFormats dxfcoll = stylespart.Stylesheet.Descendants<DifferentialFormats>().FirstOrDefault();
                Assert.NotNull(dxfcoll);

                DifferentialFormat diff = new DifferentialFormat();

                ExtensionList eList = new ExtensionList(
                    new Extension() { Uri = "{0417FA29-78FA-4A13-93AC-8FF0FAFDF519}" });

#pragma warning disable CS0618 // Type or member is obsolete
                diff.ExtensionList = eList;

                Extension e = diff.ExtensionList.GetFirstChild<Extension>();
#pragma warning restore CS0618 // Type or member is obsolete

                DxfExtension e2 = diff.DxfExtensionList.GetFirstChild<DxfExtension>();

                // The goal is to have both of these be valid objects.
                Assert.NotNull(e2);
                Assert.Equal("{0417FA29-78FA-4A13-93AC-8FF0FAFDF519}", e2.Uri);

                Assert.NotNull(e);
                Assert.Equal("{0417FA29-78FA-4A13-93AC-8FF0FAFDF519}", e.Uri);
            }
        }

        [Theory]
        [InlineData(TestFiles.Table_With_Checkboxes_new_xlsx)]
        public void SetDxfExtensionListChildren(string name)
        {
            using (var stream = GetStream(name))
            using (SpreadsheetDocument spd = SpreadsheetDocument.Open(stream, false))
            {
                Assert.NotNull(spd);
                Assert.NotNull(spd.WorkbookPart);

                WorksheetPart sheet = (WorksheetPart)spd.WorkbookPart.GetPartById("rId1");
                Assert.NotNull(sheet);

                WorkbookStylesPart stylespart = (WorkbookStylesPart)spd.WorkbookPart.WorkbookStylesPart;
                Assert.NotNull(stylespart);

                DifferentialFormats dxfcoll = stylespart.Stylesheet.Descendants<DifferentialFormats>().FirstOrDefault();
                Assert.NotNull(dxfcoll);

                DifferentialFormat diff = new DifferentialFormat();

                DxfExtensionList dxfeList = new DxfExtensionList(
                    new DxfExtension(new DXFComplement() { I = 0 }) { Uri = "{0417FA29-78FA-4A13-93AC-8FF0FAFDF519}" });

                diff.AddChild(dxfeList);

#pragma warning disable CS0618 // Type or member is obsolete
                Extension e = diff.ExtensionList.GetFirstChild<Extension>();
#pragma warning restore CS0618 // Type or member is obsolete

                DxfExtension e2 = diff.DxfExtensionList.GetFirstChild<DxfExtension>();

                // The goal is to have both of these be valid objects.
                Assert.NotNull(e2);

                Assert.Equal("{0417FA29-78FA-4A13-93AC-8FF0FAFDF519}", e2.Uri);

                DXFComplement complement = e2.GetFirstChild<DXFComplement>();
                Assert.NotNull(complement);

                Assert.NotNull(e);
                Assert.Equal("{0417FA29-78FA-4A13-93AC-8FF0FAFDF519}", e.Uri);
                complement = e.GetFirstChild<DXFComplement>();
                Assert.NotNull(complement);
            }
        }

        [Theory]
        [InlineData(TestFiles.Table_With_Checkboxes_new_xlsx)]
        public void SetDxfExtensionListProperty(string name)
        {
            using (var stream = GetStream(name))
            using (SpreadsheetDocument spd = SpreadsheetDocument.Open(stream, false))
            {
                Assert.NotNull(spd);
                Assert.NotNull(spd.WorkbookPart);

                WorksheetPart sheet = (WorksheetPart)spd.WorkbookPart.GetPartById("rId1");
                Assert.NotNull(sheet);

                WorkbookStylesPart stylespart = (WorkbookStylesPart)spd.WorkbookPart.WorkbookStylesPart;
                Assert.NotNull(stylespart);

                DifferentialFormats dxfcoll = stylespart.Stylesheet.Descendants<DifferentialFormats>().FirstOrDefault();
                Assert.NotNull(dxfcoll);

                DifferentialFormat diff = new DifferentialFormat();

                DxfExtensionList dxfeList = new DxfExtensionList(
                    new DxfExtension(new DXFComplement() { I = 0 }) { Uri = "{0417FA29-78FA-4A13-93AC-8FF0FAFDF519}" });

                diff.DxfExtensionList = dxfeList;

#pragma warning disable CS0618 // Type or member is obsolete
                Extension e = diff.ExtensionList.GetFirstChild<Extension>();
#pragma warning restore CS0618 // Type or member is obsolete

                DxfExtension e2 = diff.DxfExtensionList.GetFirstChild<DxfExtension>();

                // The goal is to have both of these be valid objects.
                Assert.NotNull(e2);

                Assert.Equal("{0417FA29-78FA-4A13-93AC-8FF0FAFDF519}", e2.Uri);

                DXFComplement complement = e2.GetFirstChild<DXFComplement>();
                Assert.NotNull(complement);

                Assert.NotNull(e);
                Assert.Equal("{0417FA29-78FA-4A13-93AC-8FF0FAFDF519}", e.Uri);
                complement = e.GetFirstChild<DXFComplement>();
                Assert.NotNull(complement);
            }
        }
    }
}
