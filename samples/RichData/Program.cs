// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Office2019.Excel.RichData;
using DocumentFormat.OpenXml.Office2019.Excel.RichData2;
using DocumentFormat.OpenXml.Office2021.Excel.RichDataWebImage;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System;

using Value = DocumentFormat.OpenXml.Office2019.Excel.RichData.Value;

namespace RichData
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Common.ExampleUtilities.ShowHelp(new string[]
                {
                    "RichData: ",
                    "Usage: RichData <filename>",
                    "Where: <filename> is the .xlsx file in which to add rich data.",
                });
            }
            else if (Common.ExampleUtilities.CheckIfFilesExist(args))
            {
                // InsertRichData(args[0]);
                InsertRichData(@"C:\source\deleteThis\test2\bar.xlsx");
            }
        }

        public static void InsertRichData(string xlsxPath)
        {
            if (xlsxPath == null)
            {
                throw new ArgumentNullException(nameof(xlsxPath));
            }

            using (SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.Open(xlsxPath, true))
            {
                WorkbookPart workbookPart = spreadsheetDocument.WorkbookPart;

                AddRdRichValueWebImagePart(workbookPart);

                AddRdRichValuePart(workbookPart);

                AddRdRichValueStructurePart(workbookPart);

                AddRdArrayPart(workbookPart);

                AddRichStylesPart(workbookPart);

                AddRdSupportingPropertyBagStructurePart(workbookPart);

                // Close and save the spreadsheet
                spreadsheetDocument.Close();
            }
        }

        private static void AddRdRichValueWebImagePart(WorkbookPart workbookPart)
        {
            // Add the rdRichValueWebImage part
            RdRichValueWebImagePart rdRichValueWebImagePart = workbookPart.RdRichValueWebImagePart ?? workbookPart.AddNewPart<RdRichValueWebImagePart>();

            // Add the hyperlink relationships for rdRichValueWebImagePart
            HyperlinkRelationship hyperLinkRel1 = rdRichValueWebImagePart.AddHyperlinkRelationship(new Uri("https://www.bing.com/images/search?form=xlimg&amp;q=seattle"), true);
            HyperlinkRelationship hyperLinkRel2 = rdRichValueWebImagePart.AddHyperlinkRelationship(new Uri("https://www.bing.com/th?id=AMMS_348b88a346e44ffe38a8fd278b585309&amp;qlt=95"), true);

            // add the elements for the rdRichValueWebImage part
            workbookPart.RdRichValueWebImagePart.WebImagesSupportingRichData = new WebImagesSupportingRichData();
            workbookPart.RdRichValueWebImagePart.WebImagesSupportingRichData.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            WebImageSupportingRichData webImageSupportingRichData = workbookPart.RdRichValueWebImagePart.WebImagesSupportingRichData.AppendChild(new WebImageSupportingRichData());
            webImageSupportingRichData.AppendChild(new AddressWebImageSupportingRichDataRelationship() { Id = hyperLinkRel1.Id });
            webImageSupportingRichData.AppendChild(new MoreImagesAddressWebImageSupportingRichDataRelationship() { Id = hyperLinkRel2.Id });
        }

        private static void AddRdRichValuePart(WorkbookPart workbookPart)
        {
            // Add the rdrichvalue part
            RdRichValuePart rdRichValuePart = workbookPart.AddNewPart<RdRichValuePart>();

            rdRichValuePart.RichValueData = new RichValueData(
                new RichValue(
                    new Value("536870912"),
                    new Value("Seattle"),
                    new Value("5fbba6b8-85e1-4d41-9444-d9055436e473"),
                    new Value("en-US"),
                    new Value("Map"))
                { S = 0 },
                new RichValue(
                    new Value("536870912"),
                    new Value("Washington"),
                    new Value("982ad551-fd5d-45df-bd70-bf704dd576e4"),
                    new Value("en-US"),
                    new Value("Map"))
                { S = 0 },
                new RichValue(
                    new Value("536870912"),
                    new Value("King County"),
                    new Value("54389684-d1e7-09ad-33b0-d0587d219a6e"),
                    new Value("en-US"),
                    new Value("Map"))
                { S = 0 },
                new RichValue(
                    new RichValueFallback("369.2"),
                    new Value("14"))
                { S = 1 },
                new RichValue(
                    new Value("536870912"),
                    new Value("United States"),
                    new Value("5232ed96-85b1-2edb-12c6-63e6c597a1de"),
                    new Value("en-US"),
                    new Value("Map"))
                { S = 0 },
                new RichValue(
                    new Value("0"),
                    new Value("12"),
                    new Value("15"),
                    new Value("6"),
                    new Value("0"))
                { S = 2 },
                new RichValue(
                    new RichValueFallback("47.603228999999999"),
                    new Value("16"))
                { S = 1 },
                new RichValue(
                    new Value("805306368"),
                    new Value("Bruce Harrell (Mayor)"),
                    new Value("a3002d35-4b06-4b03-40c7-10b98d6e23f2"),
                    new Value("en-US"),
                    new Value("Generic"))
                { S = 0 },
                new RichValue(
                    new Value("0"))
                { S = 3 },
                new RichValue(
                    new Value("https://www.bing.com/search?q=seattle&amp;form=skydnc"),
                    new Value("Learn more on Bing"))
                { S = 4 },
                new RichValue(
                    new RichValueFallback("-122.33028"),
                    new Value("16"))
                { S = 1 },
                new RichValue(
                    new RichValueFallback("737015"),
                    new Value("14"))
                { S = 1 },
                new RichValue(
                    new Value("1"))
                { S = 3 },
                new RichValue(
                    new Value("#VALUE!"),
                    new Value("en-US"),
                    new Value("5fbba6b8-85e1-4d41-9444-d9055436e473"),
                    new Value("536870912"),
                    new Value("1"),
                    new Value("6"),
                    new Value("7"),
                    new Value("Seattle"),
                    new Value("10"),
                    new Value("11"),
                    new Value("Map"),
                    new Value("12"),
                    new Value("13"),
                    new Value("1"),
                    new Value("2"),
                    new Value("3"),
                    new Value("4"),
                    new Value("Seattle is a seaport city on the West Coast of the United States. It is the seat of King County, Washington. With a 2020 population of 737,015, it is the largest city in both the state of Washington and the Pacific Northwest region of North America. The Seattle metropolitan area's population is 4.02 million, making it the 15th-largest in the United States. Its growth rate of 21.1% between 2010 and 2020 makes it one of the nation's fastest-growing large cities."),
                    new Value("5"),
                    new Value("6"),
                    new Value("8"),
                    new Value("9"),
                    new Value("10"),
                    new Value("Seattle"),
                    new Value("11"),
                    new Value("12"),
                    new Value("Seattle"),
                    new Value("mdp/vdpid/4860655131336638465"))
                { S = 5 })
            { Count = 14 };
        }

        private static void AddRdRichValueStructurePart(WorkbookPart workbookPart)
        {
            // Add the rdrichvaluestructure part
            RdRichValueStructurePart rdRichValueStructurePart = workbookPart.AddNewPart<RdRichValueStructurePart>();
            rdRichValueStructurePart.RichValueStructures = new RichValueStructures(
                new RichValueStructure(
                    new Key() { N = "%EntityServiceId", T = RichValueValueType.I },
                    new Key() { N = "_DisplayString", T = RichValueValueType.S },
                    new Key() { N = "%EntityId", T = RichValueValueType.S },
                    new Key() { N = "%EntityCulture", T = RichValueValueType.S },
                    new Key() { N = "_Icon", T = RichValueValueType.S })
                { T = "_linkedentity2" },
                new RichValueStructure(
                    new Key() { N = "_Format", T = RichValueValueType.Spb })
                { T = "_formattednumber" },
                new RichValueStructure(
                    new Key() { N = "WebImageIdentifier", T = RichValueValueType.I },
                    new Key() { N = "_Provider", T = RichValueValueType.Spb },
                    new Key() { N = "Attribution", T = RichValueValueType.Spb },
                    new Key() { N = "CalcOrigin", T = RichValueValueType.I },
                    new Key() { N = "ComputedImage", T = RichValueValueType.B },
                    new Key() { N = "Text", T = RichValueValueType.S })
                { T = "_webimage" },
                new RichValueStructure(
                    new Key() { N = "array", T = RichValueValueType.A })
                { T = "_array" },
                new RichValueStructure(
                    new Key() { N = "Address", T = RichValueValueType.S },
                    new Key() { N = "Text", T = RichValueValueType.S })
                { T = "_hyperlink" },
                new RichValueStructure(
                    new Key() { N = "_CRID", T = RichValueValueType.E },
                    new Key() { N = "%EntityCulture", T = RichValueValueType.S },
                    new Key() { N = "%EntityId", T = RichValueValueType.S },
                    new Key() { N = "%EntityServiceId", T = RichValueValueType.I },
                    new Key() { N = "%IsRefreshable", T = RichValueValueType.B },
                    new Key() { N = "_Attribution", T = RichValueValueType.Spb },
                    new Key() { N = "_Display", T = RichValueValueType.Spb },
                    new Key() { N = "_DisplayString", T = RichValueValueType.S },
                    new Key() { N = "_Flags", T = RichValueValueType.Spb },
                    new Key() { N = "_Format", T = RichValueValueType.Spb },
                    new Key() { N = "_Icon", T = RichValueValueType.S },
                    new Key() { N = "_Provider", T = RichValueValueType.Spb },
                    new Key() { N = "_SubLabel", T = RichValueValueType.Spb },
                    new Key() { N = "Admin Division 1 (State/province/other)", T = RichValueValueType.R },
                    new Key() { N = "Admin Division 2 (County/district/other)", T = RichValueValueType.R },
                    new Key() { N = "Area", T = RichValueValueType.R },
                    new Key() { N = "Country/region", T = RichValueValueType.R },
                    new Key() { N = "Description", T = RichValueValueType.S },
                    new Key() { N = "Image", T = RichValueValueType.R },
                    new Key() { N = "Latitude", T = RichValueValueType.R },
                    new Key() { N = "Leader(s)", T = RichValueValueType.R },
                    new Key() { N = "LearnMoreOnLink", T = RichValueValueType.R },
                    new Key() { N = "Longitude", T = RichValueValueType.R },
                    new Key() { N = "Name", T = RichValueValueType.S },
                    new Key() { N = "Population", T = RichValueValueType.R },
                    new Key() { N = "Time zone(s)", T = RichValueValueType.R },
                    new Key() { N = "UniqueName", T = RichValueValueType.S },
                    new Key() { N = "VDPID/VSID", T = RichValueValueType.S })
                { T = "_linkedentity2core" })
            { Count = 6 };
        }

        private static void AddRdArrayPart(WorkbookPart workbookPart)
        {
            RdArrayPart rdArrayPart = workbookPart.AddNewPart<RdArrayPart>();

            rdArrayPart.ArrayData = new ArrayData(
                new DocumentFormat.OpenXml.Office2019.Excel.RichData2.Array(
                    new ArrayValue("7") { T = ArrayValueType.R })
                { R = 1 },
                new DocumentFormat.OpenXml.Office2019.Excel.RichData2.Array(
                    new ArrayValue("Pacific Time Zone") { T = ArrayValueType.S })
                { R = 1 })
            { Count = 2 };
        }

        private static void AddRichStylesPart(WorkbookPart workbookPart)
        {
            RichStylesPart richStylesPart = workbookPart.AddNewPart<RichStylesPart>();

            if (richStylesPart.RichStylesheet is null)
            {
                richStylesPart.RichStylesheet = new RichStylesheet();
            }

            richStylesPart.RichStylesheet.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            richStylesPart.RichStylesheet.AddNamespaceDeclaration("x", "http://schemas.openxmlformats.org/spreadsheetml/2006/main");

            richStylesPart.RichStylesheet = new RichStylesheet(
                new Dxfs(
                    new DifferentialFormat(
                        new NumberingFormat() { NumberFormatId = 3, FormatCode = "#,##0" }),
                    new DifferentialFormat(
                        new NumberingFormat() { NumberFormatId = 0, FormatCode = "General" }))
                { Count = 2 },
                new RichFormatProperties(
                    new RichFormatProperty() { N = "IsTitleField", T = RichFormatPropertyType.B },
                    new RichFormatProperty() { N = "IsHeroField", T = RichFormatPropertyType.B },
                    new RichFormatProperty() { N = "RequiresInlineAttribution", T = RichFormatPropertyType.B },
                    new RichFormatProperty() { N = "NumberFormat", T = RichFormatPropertyType.S }),
                new RichStyles(
                    new RichStyle(
                        new RichStylePropertyValue("1") { I = 0 }),
                    new RichStyle(
                        new RichStylePropertyValue("1") { I = 1 }),
                    new RichStyle(
                        new RichStylePropertyValue("1") { I = 2 }),
                    new RichStyle(
                        new RichStylePropertyValue("#,##0") { I = 3 })
                    { Dxfid = 0 },
                    new RichStyle(
                        new RichStylePropertyValue("0.0000") { I = 3 })
                    { Dxfid = 1 }));


            // does mc:Ignorable="x" need to be set here?
            // richStylesPart.RichStylesheet.SetAttribute(new DocumentFormat.OpenXml.OpenXmlAttribute())
        }

        private static void AddRdSupportingPropertyBagStructurePart(WorkbookPart workbookPart)
        {
            RdSupportingPropertyBagStructurePart rdSupportingPropertyBagStructurePart = workbookPart.AddNewPart<RdSupportingPropertyBagStructurePart>();

            rdSupportingPropertyBagStructurePart.SupportingPropertyBagStructures = new SupportingPropertyBagStructures(
                    new SupportingPropertyBagStructure(
                        new Key() { N = "SourceText", T = RichValueValueType.S },
                        new Key() { N = "LicenseText", T = RichValueValueType.S },
                        new Key() { N = "SourceAddress", T = RichValueValueType.S },
                        new Key() { N = "LicenseAddress", T = RichValueValueType.S }),
                    new SupportingPropertyBagStructure(
                        new Key() { N = "Area", T = RichValueValueType.Spb },
                        new Key() { N = "Name", T = RichValueValueType.Spb },
                        new Key() { N = "Population", T = RichValueValueType.Spb },
                        new Key() { N = "UniqueName", T = RichValueValueType.Spb },
                        new Key() { N = "Description", T = RichValueValueType.Spb },
                        new Key() { N = "Country/region", T = RichValueValueType.Spb },
                        new Key() { N = "Admin Division 1 (State/province/other)", T = RichValueValueType.Spb },
                        new Key() { N = "Admin Division 2 (County/district/other)", T = RichValueValueType.Spb }),
                    new SupportingPropertyBagStructure(
                        new Key() { N = "^Order", T = RichValueValueType.Spb },
                        new Key() { N = "TitleProperty", T = RichValueValueType.S },
                        new Key() { N = "SubTitleProperty", T = RichValueValueType.S }),
                    new SupportingPropertyBagStructure(
                        new Key() { N = "ShowInCardView", T = RichValueValueType.B },
                        new Key() { N = "ShowInDotNotation", T = RichValueValueType.B },
                        new Key() { N = "ShowInAutoComplete", T = RichValueValueType.B }),
                    new SupportingPropertyBagStructure(
                        new Key() { N = "ShowInDotNotation", T = RichValueValueType.B },
                        new Key() { N = "ShowInAutoComplete", T = RichValueValueType.B }),
                    new SupportingPropertyBagStructure(
                        new Key() { N = "UniqueName", T = RichValueValueType.Spb },
                        new Key() { N = "VDPID/VSID", T = RichValueValueType.Spb },
                        new Key() { N = "Description", T = RichValueValueType.Spb },
                        new Key() { N = "LearnMoreOnLink", T = RichValueValueType.Spb }),
                    new SupportingPropertyBagStructure(
                        new Key() { N = "Name", T = RichValueValueType.I },
                        new Key() { N = "Image", T = RichValueValueType.I },
                        new Key() { N = "Description", T = RichValueValueType.I }),
                    new SupportingPropertyBagStructure(
                        new Key() { N = "link", T = RichValueValueType.S },
                        new Key() { N = "logo", T = RichValueValueType.S },
                        new Key() { N = "name", T = RichValueValueType.S }),
                    new SupportingPropertyBagStructure(
                        new Key() { N = "Area", T = RichValueValueType.S },
                        new Key() { N = "Population", T = RichValueValueType.S }),
                    new SupportingPropertyBagStructure(
                        new Key() { N = "_Self", T = RichValueValueType.I }))
            { Count = 10 };
        }
    }
}
