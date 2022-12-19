// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Office2019.Excel.RichData;
using DocumentFormat.OpenXml.Office2019.Excel.RichData2;
using DocumentFormat.OpenXml.Office2021.Excel.RichDataWebImage;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;

using NumberingFormat = DocumentFormat.OpenXml.Spreadsheet.NumberingFormat;
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
                InsertRichData(args[0]);
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

                AddRdSupportingPropertyBagPart(workbookPart);

                AddRdRichValueTypesPart(workbookPart);

                AddSheetData(spreadsheetDocument);

                AddMetaDataPart(workbookPart);

                // Save the spreadsheet
                spreadsheetDocument.Save();
            }
        }

        private static void AddRdRichValueWebImagePart(WorkbookPart workbookPart)
        {
            // Add the RdRichValueWebImagePart
            RdRichValueWebImagePart rdRichValueWebImagePart = workbookPart.RdRichValueWebImagePart ?? workbookPart.AddNewPart<RdRichValueWebImagePart>();

            // Add the HyperlinkRelationship for RdRichValueWebImagePart
            HyperlinkRelationship hyperLinkRel1 = rdRichValueWebImagePart.AddHyperlinkRelationship(new Uri("https://www.bing.com/images/search?form=xlimg&amp;q=seattle"), true);
            HyperlinkRelationship hyperLinkRel2 = rdRichValueWebImagePart.AddHyperlinkRelationship(new Uri("https://www.bing.com/th?id=AMMS_348b88a346e44ffe38a8fd278b585309&amp;qlt=95"), true);

            // add the elements for the RdRichValueWebImagePart
            workbookPart.RdRichValueWebImagePart.WebImagesSupportingRichData = new WebImagesSupportingRichData();
            workbookPart.RdRichValueWebImagePart.WebImagesSupportingRichData.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            WebImageSupportingRichData webImageSupportingRichData = workbookPart.RdRichValueWebImagePart.WebImagesSupportingRichData.AppendChild(new WebImageSupportingRichData());
            webImageSupportingRichData.AppendChild(new AddressWebImageSupportingRichDataRelationship() { Id = hyperLinkRel1.Id });
            webImageSupportingRichData.AppendChild(new MoreImagesAddressWebImageSupportingRichDataRelationship() { Id = hyperLinkRel2.Id });
        }

        private static void AddRdRichValuePart(WorkbookPart workbookPart)
        {
            // Add the RdRichValuePart
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
                    new Value("0"),
                    new Value("Image of Seattle"))
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
                    new Value(@"https://www.bing.com/search?q=seattle&amp;form=skydnc"),
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
            // Add the RdRichValueStructurePart
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
        }

        private static void AddRdSupportingPropertyBagStructurePart(WorkbookPart workbookPart)
        {
            RdSupportingPropertyBagStructurePart rdSupportingPropertyBagStructurePart = workbookPart.AddNewPart<RdSupportingPropertyBagStructurePart>();

            rdSupportingPropertyBagStructurePart.SupportingPropertyBagStructures = new SupportingPropertyBagStructures(
                    new SupportingPropertyBagStructure(
                        new SupportingPropertyBagKey() { N = "SourceText", T = SupportingPropertyBagValueType.S },
                        new SupportingPropertyBagKey() { N = "LicenseText", T = SupportingPropertyBagValueType.S },
                        new SupportingPropertyBagKey() { N = "SourceAddress", T = SupportingPropertyBagValueType.S },
                        new SupportingPropertyBagKey() { N = "LicenseAddress", T = SupportingPropertyBagValueType.S }),
                    new SupportingPropertyBagStructure(
                        new SupportingPropertyBagKey() { N = "Area", T = SupportingPropertyBagValueType.Spb },
                        new SupportingPropertyBagKey() { N = "Name", T = SupportingPropertyBagValueType.Spb },
                        new SupportingPropertyBagKey() { N = "Population", T = SupportingPropertyBagValueType.Spb },
                        new SupportingPropertyBagKey() { N = "UniqueName", T = SupportingPropertyBagValueType.Spb },
                        new SupportingPropertyBagKey() { N = "Description", T = SupportingPropertyBagValueType.Spb },
                        new SupportingPropertyBagKey() { N = "Country/region", T = SupportingPropertyBagValueType.Spb },
                        new SupportingPropertyBagKey() { N = "Admin Division 1 (State/province/other)", T = SupportingPropertyBagValueType.Spb },
                        new SupportingPropertyBagKey() { N = "Admin Division 2 (County/district/other)", T = SupportingPropertyBagValueType.Spb }),
                    new SupportingPropertyBagStructure(
                        new SupportingPropertyBagKey() { N = "^Order", T = SupportingPropertyBagValueType.Spb },
                        new SupportingPropertyBagKey() { N = "TitleProperty", T = SupportingPropertyBagValueType.S },
                        new SupportingPropertyBagKey() { N = "SubTitleProperty", T = SupportingPropertyBagValueType.S }),
                    new SupportingPropertyBagStructure(
                        new SupportingPropertyBagKey() { N = "ShowInCardView", T = SupportingPropertyBagValueType.B },
                        new SupportingPropertyBagKey() { N = "ShowInDotNotation", T = SupportingPropertyBagValueType.B },
                        new SupportingPropertyBagKey() { N = "ShowInAutoComplete", T = SupportingPropertyBagValueType.B }),
                    new SupportingPropertyBagStructure(
                        new SupportingPropertyBagKey() { N = "ShowInDotNotation", T = SupportingPropertyBagValueType.B },
                        new SupportingPropertyBagKey() { N = "ShowInAutoComplete", T = SupportingPropertyBagValueType.B }),
                    new SupportingPropertyBagStructure(
                        new SupportingPropertyBagKey() { N = "UniqueName", T = SupportingPropertyBagValueType.Spb },
                        new SupportingPropertyBagKey() { N = "VDPID/VSID", T = SupportingPropertyBagValueType.Spb },
                        new SupportingPropertyBagKey() { N = "Description", T = SupportingPropertyBagValueType.Spb },
                        new SupportingPropertyBagKey() { N = "LearnMoreOnLink", T = SupportingPropertyBagValueType.Spb }),
                    new SupportingPropertyBagStructure(
                        new SupportingPropertyBagKey() { N = "Name", T = SupportingPropertyBagValueType.I },
                        new SupportingPropertyBagKey() { N = "Image", T = SupportingPropertyBagValueType.I },
                        new SupportingPropertyBagKey() { N = "Description", T = SupportingPropertyBagValueType.I }),
                    new SupportingPropertyBagStructure(
                        new SupportingPropertyBagKey() { N = "link", T = SupportingPropertyBagValueType.S },
                        new SupportingPropertyBagKey() { N = "logo", T = SupportingPropertyBagValueType.S },
                        new SupportingPropertyBagKey() { N = "name", T = SupportingPropertyBagValueType.S }),
                    new SupportingPropertyBagStructure(
                        new SupportingPropertyBagKey() { N = "Area", T = SupportingPropertyBagValueType.S },
                        new SupportingPropertyBagKey() { N = "Population", T = SupportingPropertyBagValueType.S }),
                    new SupportingPropertyBagStructure(
                        new SupportingPropertyBagKey() { N = "_Self", T = SupportingPropertyBagValueType.I }))
            { Count = 10 };
        }

        private static void AddRdSupportingPropertyBagPart(WorkbookPart workbookPart)
        {
            RdSupportingPropertyBagPart rdSupportingPropertyBagPart = workbookPart.AddNewPart<RdSupportingPropertyBagPart>();

            rdSupportingPropertyBagPart.SupportingPropertyBags =
                new SupportingPropertyBags(
                    new SupportingPropertyBagArrayData(
                        new SupportingPropertyBagArray(
                            new SupportingPropertyBagArrayValue("%EntityServiceId") { T = SupportingPropertyBagArrayValueType.S },
                            new SupportingPropertyBagArrayValue("%IsRefreshable") { T = SupportingPropertyBagArrayValueType.S },
                            new SupportingPropertyBagArrayValue("%EntityCulture") { T = SupportingPropertyBagArrayValueType.S },
                            new SupportingPropertyBagArrayValue("%EntityId") { T = SupportingPropertyBagArrayValueType.S },
                            new SupportingPropertyBagArrayValue("_Icon") { T = SupportingPropertyBagArrayValueType.S },
                            new SupportingPropertyBagArrayValue("_Provider") { T = SupportingPropertyBagArrayValueType.S },
                            new SupportingPropertyBagArrayValue("_Attribution") { T = SupportingPropertyBagArrayValueType.S },
                            new SupportingPropertyBagArrayValue("_Display") { T = SupportingPropertyBagArrayValueType.S },
                            new SupportingPropertyBagArrayValue("Name") { T = SupportingPropertyBagArrayValueType.S },
                            new SupportingPropertyBagArrayValue("_Format") { T = SupportingPropertyBagArrayValueType.S },
                            new SupportingPropertyBagArrayValue("Admin Division 2 (County/district/other)") { T = SupportingPropertyBagArrayValueType.S },
                            new SupportingPropertyBagArrayValue("Admin Division 1 (State/province/other)") { T = SupportingPropertyBagArrayValueType.S },
                            new SupportingPropertyBagArrayValue("Country/region") { T = SupportingPropertyBagArrayValueType.S },
                            new SupportingPropertyBagArrayValue("Leader(s)") { T = SupportingPropertyBagArrayValueType.S },
                            new SupportingPropertyBagArrayValue("_SubLabel") { T = SupportingPropertyBagArrayValueType.S },
                            new SupportingPropertyBagArrayValue("Population") { T = SupportingPropertyBagArrayValueType.S },
                            new SupportingPropertyBagArrayValue("Area") { T = SupportingPropertyBagArrayValueType.S },
                            new SupportingPropertyBagArrayValue("Latitude") { T = SupportingPropertyBagArrayValueType.S },
                            new SupportingPropertyBagArrayValue("Longitude") { T = SupportingPropertyBagArrayValueType.S },
                            new SupportingPropertyBagArrayValue("Time zone(s)") { T = SupportingPropertyBagArrayValueType.S },
                            new SupportingPropertyBagArrayValue("_Flags") { T = SupportingPropertyBagArrayValueType.S },
                            new SupportingPropertyBagArrayValue("VDPID/VSID") { T = SupportingPropertyBagArrayValueType.S },
                            new SupportingPropertyBagArrayValue("UniqueName") { T = SupportingPropertyBagArrayValueType.S },
                            new SupportingPropertyBagArrayValue("_DisplayString") { T = SupportingPropertyBagArrayValueType.S },
                            new SupportingPropertyBagArrayValue("LearnMoreOnLink") { T = SupportingPropertyBagArrayValueType.S },
                            new SupportingPropertyBagArrayValue("Image") { T = SupportingPropertyBagArrayValueType.S },
                            new SupportingPropertyBagArrayValue("Description") { T = SupportingPropertyBagArrayValueType.S })
                        { Count = 27 })
                    { Count = 1 },
                    new SupportingPropertyBagData(
                        new SupportingPropertyBag(
                            new SupportingPropertyBagArrayValue("Wikipedia	Wikipedia	Wikipedia	Wikipedia	"),
                            new SupportingPropertyBagArrayValue("CC-BY-SA	CC-BY-SA	CC-BY-SA	CC-BY-SA	"),
                            new SupportingPropertyBagArrayValue("http://en.wikipedia.org/wiki/Seattle	http://de.wikipedia.org/wiki/Seattle	http://es.wikipedia.org/wiki/Seattle	http://fr.wikipedia.org/wiki/Seattle	"),
                            new SupportingPropertyBagArrayValue("http://creativecommons.org/licenses/by-sa/3.0/	http://creativecommons.org/licenses/by-sa/3.0/	http://creativecommons.org/licenses/by-sa/3.0/	http://creativecommons.org/licenses/by-sa/3.0/	"))
                        { S = 0 },
                        new SupportingPropertyBag(
                            new SupportingPropertyBagArrayValue("Wikipedia	Sec	"),
                            new SupportingPropertyBagArrayValue("CC-BY-SA		"),
                            new SupportingPropertyBagArrayValue("http://en.wikipedia.org/wiki/Seattle https://www.sec.gov/cgi-bin/browse-edgar?action=getcompany&amp;CIK=0001930189	"),
                            new SupportingPropertyBagArrayValue("http://creativecommons.org/licenses/by-sa/3.0/		"))
                        { S = 0 },
                        new SupportingPropertyBag(
                            new SupportingPropertyBagArrayValue("Wikipedia	"),
                            new SupportingPropertyBagArrayValue("CC-BY-SA	"),
                            new SupportingPropertyBagArrayValue("http://en.wikipedia.org/wiki/Seattle	"),
                            new SupportingPropertyBagArrayValue("http://creativecommons.org/licenses/by-sa/3.0/	"))
                        { S = 0 },
                        new SupportingPropertyBag(
                            new SupportingPropertyBagArrayValue("Wikipedia	Wikipedia	Sec	"),
                            new SupportingPropertyBagArrayValue("CC-BY-SA	CC-BY-SA		"),
                            new SupportingPropertyBagArrayValue("http://en.wikipedia.org/wiki/Seattle https://en.wikipedia.org/wiki/Seattle https://www.sec.gov/cgi-bin/browse-edgar?action=getcompany&amp;CIK=0001930189	"),
                            new SupportingPropertyBagArrayValue("http://creativecommons.org/licenses/by-sa/3.0/	http://creativecommons.org/licenses/by-sa/3.0/		"))
                        { S = 0 },
                        new SupportingPropertyBag(
                            new SupportingPropertyBagArrayValue("Wikipedia	Wikipedia	"),
                            new SupportingPropertyBagArrayValue("CC-BY-SA	CC-BY-SA	"),
                            new SupportingPropertyBagArrayValue("http://en.wikipedia.org/wiki/Seattle	https://en.wikipedia.org/wiki/Seattle	"),
                            new SupportingPropertyBagArrayValue("http://creativecommons.org/licenses/by-sa/3.0/	http://creativecommons.org/licenses/by-sa/3.0/	"))
                        { S = 0 },
                        new SupportingPropertyBag(
                            new SupportingPropertyBagArrayValue("Wikipedia	Wikipedia	"),
                            new SupportingPropertyBagArrayValue("CC-BY-SA	CC-BY-SA	"),
                            new SupportingPropertyBagArrayValue("http://en.wikipedia.org/wiki/Seattle	http://fr.wikipedia.org/wiki/Seattle	"),
                            new SupportingPropertyBagArrayValue("http://creativecommons.org/licenses/by-sa/3.0/	http://creativecommons.org/licenses/by-sa/3.0/	"))
                        { S = 0 },
                        new SupportingPropertyBag(
                            new SupportingPropertyBagArrayValue("0"),
                            new SupportingPropertyBagArrayValue("1"),
                            new SupportingPropertyBagArrayValue("2"),
                            new SupportingPropertyBagArrayValue("1"),
                            new SupportingPropertyBagArrayValue("2"),
                            new SupportingPropertyBagArrayValue("3"),
                            new SupportingPropertyBagArrayValue("4"),
                            new SupportingPropertyBagArrayValue("5"))
                        { S = 1 },
                        new SupportingPropertyBag(
                            new SupportingPropertyBagArrayValue("0"),
                            new SupportingPropertyBagArrayValue("Name"),
                            new SupportingPropertyBagArrayValue("LearnMoreOnLink"))
                        { S = 2 },
                        new SupportingPropertyBag(
                            new SupportingPropertyBagArrayValue("0"),
                            new SupportingPropertyBagArrayValue("0"),
                            new SupportingPropertyBagArrayValue("0"))
                        { S = 3 },
                        new SupportingPropertyBag(
                            new SupportingPropertyBagArrayValue("0"),
                            new SupportingPropertyBagArrayValue("0"))
                        { S = 4 },
                        new SupportingPropertyBag(
                            new SupportingPropertyBagArrayValue("8"),
                            new SupportingPropertyBagArrayValue("8"),
                            new SupportingPropertyBagArrayValue("9"),
                            new SupportingPropertyBagArrayValue("8"))
                        { S = 5 },
                        new SupportingPropertyBag(
                            new SupportingPropertyBagArrayValue("1"),
                            new SupportingPropertyBagArrayValue("2"),
                            new SupportingPropertyBagArrayValue("3"))
                        { S = 6 },
                        new SupportingPropertyBag(
                            new SupportingPropertyBagArrayValue("https://www.bing.com"),
                            new SupportingPropertyBagArrayValue("https://www.bing.com/th?id=Ga%5Cbing_yt.png&amp;w=100&amp;h=40&amp;c=0&amp;pid=0.1"),
                            new SupportingPropertyBagArrayValue("Powered by Bing"))
                        { S = 7 },
                        new SupportingPropertyBag(
                            new SupportingPropertyBagArrayValue("square km"),
                            new SupportingPropertyBagArrayValue("2020"))
                        { S = 8 },
                        new SupportingPropertyBag(
                            new SupportingPropertyBagArrayValue("4"))
                        { S = 9 },
                        new SupportingPropertyBag(
                            new SupportingPropertyBagArrayValue("Wikipedia	"),
                            new SupportingPropertyBagArrayValue("CC BY-SA 3.0	"),
                            new SupportingPropertyBagArrayValue("http://nl.wikipedia.org/wiki/Seattle	"),
                            new SupportingPropertyBagArrayValue("https://creativecommons.org/licenses/by-sa/3.0	"))
                        { S = 0 },
                        new SupportingPropertyBag(
                            new SupportingPropertyBagArrayValue("5"))
                        { S = 9 })
                    { Count = 17 });
        }

        private static void AddRdRichValueTypesPart(WorkbookPart workbookPart)
        {
            RdRichValueTypesPart rdRichValueTypesPart = workbookPart.AddNewPart<RdRichValueTypesPart>();

            rdRichValueTypesPart.RichValueTypesInfo =
                new RichValueTypesInfo(
                    new RichValueGlobalType(
                        new RichValueTypeKeyFlags(
                            new RichValueTypeReservedKey(
                                new RichValueTypeReservedKeyFlag() { Name = "ExcludeFromFile", Value = true },
                                new RichValueTypeReservedKeyFlag() { Name = "ExcludeFromCalcComparison", Value = true })
                            { Name = "_Self" },
                            new RichValueTypeReservedKey(
                                new RichValueTypeReservedKeyFlag() { Name = "ExcludeFromCalcComparison", Value = true })
                            { Name = "_DisplayString" },
                            new RichValueTypeReservedKey(
                                new RichValueTypeReservedKeyFlag() { Name = "ExcludeFromCalcComparison", Value = true })
                            { Name = "_Flags" },
                            new RichValueTypeReservedKey(
                                new RichValueTypeReservedKeyFlag() { Name = "ExcludeFromCalcComparison", Value = true })
                            { Name = "_Format" },
                            new RichValueTypeReservedKey(
                                new RichValueTypeReservedKeyFlag() { Name = "ExcludeFromCalcComparison", Value = true })
                            { Name = "_SubLabel" },
                            new RichValueTypeReservedKey(
                                new RichValueTypeReservedKeyFlag() { Name = "ExcludeFromCalcComparison", Value = true })
                            { Name = "_Attribution" },
                            new RichValueTypeReservedKey(
                                new RichValueTypeReservedKeyFlag() { Name = "ExcludeFromCalcComparison", Value = true })
                            { Name = "_Icon" },
                            new RichValueTypeReservedKey(
                                new RichValueTypeReservedKeyFlag() { Name = "ExcludeFromCalcComparison", Value = true })
                            { Name = "_Display" },
                            new RichValueTypeReservedKey(
                                new RichValueTypeReservedKeyFlag() { Name = "ExcludeFromCalcComparison", Value = true })
                            { Name = "_CanonicalPropertyNames" },
                            new RichValueTypeReservedKey(
                                new RichValueTypeReservedKeyFlag() { Name = "ExcludeFromCalcComparison", Value = true })
                            { Name = "_ClassificationId" })),
                    new RichValueTypes(
                        new RichValueType(
                            new RichValueTypeKeyFlags(
                                new RichValueTypeReservedKey(
                                  new RichValueTypeReservedKeyFlag() { Name = "ShowInCardView", Value = false },
                                  new RichValueTypeReservedKeyFlag() { Name = "ShowInDotNotation", Value = false },
                                  new RichValueTypeReservedKeyFlag() { Name = "ShowInAutoComplete", Value = false })
                                { Name = "%EntityServiceId" },
                                new RichValueTypeReservedKey(
                                  new RichValueTypeReservedKeyFlag() { Name = "ShowInCardView", Value = false },
                                  new RichValueTypeReservedKeyFlag() { Name = "ShowInDotNotation", Value = false },
                                  new RichValueTypeReservedKeyFlag() { Name = "ShowInAutoComplete", Value = false })
                                { Name = "%EntityCulture" },
                                new RichValueTypeReservedKey(
                                  new RichValueTypeReservedKeyFlag() { Name = "ShowInCardView", Value = false },
                                  new RichValueTypeReservedKeyFlag() { Name = "ShowInDotNotation", Value = false },
                                  new RichValueTypeReservedKeyFlag() { Name = "ShowInAutoComplete", Value = false })
                                { Name = "%EntityId" },
                                new RichValueTypeReservedKey(
                                  new RichValueTypeReservedKeyFlag() { Name = "ShowInCardView", Value = false },
                                  new RichValueTypeReservedKeyFlag() { Name = "ShowInDotNotation", Value = false },
                                  new RichValueTypeReservedKeyFlag() { Name = "ShowInAutoComplete", Value = false },
                                  new RichValueTypeReservedKeyFlag() { Name = "ExcludeFromCalcComparison", Value = true })
                                { Name = "%cvi" }))
                        { Name = "_linkedentity2" },
                        new RichValueType(
                            new RichValueTypeKeyFlags(
                                new RichValueTypeReservedKey(
                                    new RichValueTypeReservedKeyFlag() { Name = "ShowInCardView", Value = false },
                                    new RichValueTypeReservedKeyFlag() { Name = "ShowInDotNotation", Value = false },
                                    new RichValueTypeReservedKeyFlag() { Name = "ShowInAutoComplete", Value = false })
                                { Name = "%EntityServiceId" },
                                new RichValueTypeReservedKey(
                                    new RichValueTypeReservedKeyFlag() { Name = "ShowInCardView", Value = false },
                                    new RichValueTypeReservedKeyFlag() { Name = "ShowInDotNotation", Value = false },
                                    new RichValueTypeReservedKeyFlag() { Name = "ShowInAutoComplete", Value = false })
                                { Name = "%EntityCulture" },
                                new RichValueTypeReservedKey(
                                    new RichValueTypeReservedKeyFlag() { Name = "ShowInCardView", Value = false },
                                    new RichValueTypeReservedKeyFlag() { Name = "ShowInDotNotation", Value = false },
                                    new RichValueTypeReservedKeyFlag() { Name = "ShowInAutoComplete", Value = false })
                                { Name = "%EntityId" },
                                new RichValueTypeReservedKey(
                                    new RichValueTypeReservedKeyFlag() { Name = "ShowInCardView", Value = false },
                                    new RichValueTypeReservedKeyFlag() { Name = "ShowInAutoComplete", Value = false },
                                    new RichValueTypeReservedKeyFlag() { Name = "ExcludeFromCalcComparison", Value = true })
                                { Name = "%IsRefreshable" },
                                new RichValueTypeReservedKey(
                                    new RichValueTypeReservedKeyFlag() { Name = "ShowInCardView", Value = false },
                                    new RichValueTypeReservedKeyFlag() { Name = "ShowInDotNotation", Value = false },
                                    new RichValueTypeReservedKeyFlag() { Name = "ShowInAutoComplete", Value = false })
                                { Name = "%ProviderInfo" },
                                new RichValueTypeReservedKey(
                                    new RichValueTypeReservedKeyFlag() { Name = "ShowInCardView", Value = false },
                                    new RichValueTypeReservedKeyFlag() { Name = "ShowInDotNotation", Value = false },
                                    new RichValueTypeReservedKeyFlag() { Name = "ShowInAutoComplete", Value = false })
                                { Name = "%DataProviderExternalLinkLogo" },
                                new RichValueTypeReservedKey(
                                    new RichValueTypeReservedKeyFlag() { Name = "ShowInCardView", Value = false },
                                    new RichValueTypeReservedKeyFlag() { Name = "ShowInDotNotation", Value = false },
                                    new RichValueTypeReservedKeyFlag() { Name = "ShowInAutoComplete", Value = false })
                                { Name = "%DataProviderExternalLink" },
                                new RichValueTypeReservedKey(
                                    new RichValueTypeReservedKeyFlag() { Name = "ShowInCardView", Value = false },
                                    new RichValueTypeReservedKeyFlag() { Name = "ShowInDotNotation", Value = false },
                                    new RichValueTypeReservedKeyFlag() { Name = "ShowInAutoComplete", Value = false },
                                    new RichValueTypeReservedKeyFlag() { Name = "ExcludeFromCalcComparison", Value = true })
                                { Name = "%DataRetrievedTime" },
                                new RichValueTypeReservedKey(
                                    new RichValueTypeReservedKeyFlag() { Name = "ShowInCardView", Value = false },
                                    new RichValueTypeReservedKeyFlag() { Name = "ShowInDotNotation", Value = false },
                                    new RichValueTypeReservedKeyFlag() { Name = "ShowInAutoComplete", Value = false })
                                { Name = "%EntityDomainIdString" },
                                new RichValueTypeReservedKey(
                                    new RichValueTypeReservedKeyFlag() { Name = "ShowInCardView", Value = false },
                                    new RichValueTypeReservedKeyFlag() { Name = "ShowInDotNotation", Value = false },
                                    new RichValueTypeReservedKeyFlag() { Name = "ShowInAutoComplete", Value = false })
                                { Name = "%InfoToolTipLabelNames" },
                                new RichValueTypeReservedKey(
                                    new RichValueTypeReservedKeyFlag() { Name = "ShowInCardView", Value = false },
                                    new RichValueTypeReservedKeyFlag() { Name = "ShowInDotNotation", Value = false },
                                    new RichValueTypeReservedKeyFlag() { Name = "ShowInAutoComplete", Value = false })
                                { Name = "%InfoToolTipLabelValues" },
                                new RichValueTypeReservedKey(
                                    new RichValueTypeReservedKeyFlag() { Name = "ShowInCardView", Value = false },
                                    new RichValueTypeReservedKeyFlag() { Name = "ShowInDotNotation", Value = false },
                                    new RichValueTypeReservedKeyFlag() { Name = "ShowInAutoComplete", Value = false })
                                { Name = "%InfoToolTipLabelValuesType" },
                                new RichValueTypeReservedKey(
                                    new RichValueTypeReservedKeyFlag() { Name = "ShowInCardView", Value = false },
                                    new RichValueTypeReservedKeyFlag() { Name = "ShowInDotNotation", Value = false },
                                    new RichValueTypeReservedKeyFlag() { Name = "ShowInAutoComplete", Value = false })
                                { Name = "%DataProviderString" },
                                new RichValueTypeReservedKey(
                                    new RichValueTypeReservedKeyFlag() { Name = "ShowInCardView", Value = false },
                                    new RichValueTypeReservedKeyFlag() { Name = "ShowInDotNotation", Value = false },
                                    new RichValueTypeReservedKeyFlag() { Name = "ShowInAutoComplete", Value = false })
                                { Name = "%ClassificationId" },
                                new RichValueTypeReservedKey(
                                    new RichValueTypeReservedKeyFlag() { Name = "ShowInCardView", Value = false },
                                    new RichValueTypeReservedKeyFlag() { Name = "ShowInDotNotation", Value = false },
                                    new RichValueTypeReservedKeyFlag() { Name = "ShowInAutoComplete", Value = false },
                                    new RichValueTypeReservedKeyFlag() { Name = "ExcludeFromCalcComparison", Value = true })
                                { Name = "%OutdatedReason" }))
                        { Name = "_linkedentity2core" },
                        new RichValueType(
                            new RichValueTypeKeyFlags(
                                new RichValueTypeReservedKey(
                                    new RichValueTypeReservedKeyFlag() { Name = "ShowInCardView", Value = false })
                                { Name = "WebImageIdentifier" }))
                        { Name = "_webimage" }));

            rdRichValueTypesPart.RichValueTypesInfo.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            rdRichValueTypesPart.RichValueTypesInfo.AddNamespaceDeclaration("x", "http://schemas.openxmlformats.org/spreadsheetml/2006/main");
        }

        private static void AddSheetData(SpreadsheetDocument spreadsheetDocument)
        {
            if (spreadsheetDocument.WorkbookPart.GetPartsOfType<SharedStringTablePart>().Count() == 0)
            {
                SharedStringTablePart shareStringPart = spreadsheetDocument.WorkbookPart.AddNewPart<SharedStringTablePart>();
                shareStringPart.SharedStringTable = new SharedStringTable();
            }

            Worksheet worksheet = spreadsheetDocument.WorkbookPart.WorksheetParts.First().Worksheet;

            if (worksheet is not null)
            {
                List<StringValue> stringValues = new List<StringValue>();
                stringValues.Add("1:1");

                SheetData sheetData = worksheet.GetFirstChild<SheetData>();

                if (sheetData is not null)
                {
                    sheetData.AppendChild(
                        new Row(
                            new Cell(
                                    new Xstring("#VALUE!"))
                            { CellReference = "A1", DataType = CellValues.Error, ValueMetaIndex = 1 })
                        { RowIndex = 1, Spans = new ListValue<StringValue>(stringValues), DyDescent = .25 });
                }
                else
                {
                    worksheet.AppendChild(new SheetData(
                            new Row(
                                    new Cell(
                                            new Value("#VALUE!"))
                                    { CellReference = "A1", DataType = CellValues.Error, ValueMetaIndex = 1 })
                            { RowIndex = 1, Spans = new ListValue<StringValue>(stringValues), DyDescent = .25 }));
                }
            }
        }

        private static void AddMetaDataPart(WorkbookPart workbookPart)
        {
            if (workbookPart.CellMetadataPart is null)
            {
                workbookPart.AddNewPart<CellMetadataPart>();
            }

            workbookPart.CellMetadataPart.Metadata =
                new Metadata(
                    new MetadataTypes(
                        new MetadataType()
                        {
                            Name = "XLRICHVALUE",
                            MinSupportedVersion = 120000,
                            Copy = true,
                            PasteAll = true,
                            PasteValues = true,
                            Merge = true,
                            SplitFirst = true,
                            RowColumnShift = true,
                            ClearFormats = true,
                            ClearComments = true,
                            Assign = true,
                            Coerce = true,
                        })
                    { Count = 1 },
                    new FutureMetadata(
                        new MetadataBlock(
                            new CacheFieldExtensionList(
                                new Extension(
                                    new RichValueBlock() { I = 0 })
                                { Uri = "{3e2802c4-a4d2-4d8b-9148-e3be6c30e623}" })))
                    { Name = "XLRICHVALUE", Count = 1 },
                    new ValueMetadata(
                        new MetadataBlock(
                            new MetadataRecord()
                            { TypeIndex = 1, Val = 0 }))
                    { Count = 1 });
        }
    }
}
