// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.IO;

using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Xunit;

using System.Xml;
using System.Xml.Linq;

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;
using Dr = DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;

namespace DocumentFormat.OpenXml.Tests
{
    /// <summary>
    /// Summary description for PackagingIntegrationTest
    /// </summary>

    public class CodeGenSanityTest : OpenXmlDomTestBase
    {
        // Constructors, CloneNode, Load, Save, Properties for attributes, LocalName, Assosicated Part
        [Fact]
        public void ThemeAsPartRootClassTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfile = CopyTestFiles(@"wordprocessing", true, "complex0.docx", f => f.IsWordprocessingFile())
                .FirstOrDefault();

            using (var package = testfile.OpenPackage(true) as WordprocessingDocument)
            {
                ThemePart themePart = package.MainDocumentPart.ThemePart;

                Log.Comment("Constructing Theme...");
                Dr.Theme themeFromPart = themePart.Theme;
                Dr.Theme theme = buildRootElementFromPart(themePart, RootElementConstructors.OuterXml);
                var xThemeFromFile = ConvertToXElement(themePart, themeFromPart);
                var xThemeInMemory = theme.ToXElement();
                var isEqual = xThemeInMemory.Compare(xThemeFromFile);
                Log.VerifyTrue(isEqual, "Theme constructing from file is different from the one in memory.");

                Log.Comment("Attribute Properties...");
                var expectedName = "Office Theme";
                Log.VerifyValue(themeFromPart.Name.ToString(), expectedName, "Name of current element: {0} is different from {1}.", themeFromPart.Name, expectedName);

                Log.Comment("Hallow Clone...");
                var hClone = themeFromPart.CloneNode(false) as Dr.Theme;
                foreach (var ao in themeFromPart.GetAttributes())
                {
                    var ac = hClone.GetAttribute(ao.LocalName, ao.NamespaceUri);
                    Log.VerifyValue(ao.Value, ac.Value,
                        "Attribute: {0} value: {1} NOT cloned as expected {2}", ao.GetFullName(), ac.Value, ao.Value);
                }

                Log.Comment("Deep Clone...");
                var dClone = themeFromPart.CloneNode(true) as Dr.Theme;
                isEqual = xThemeFromFile.Compare(dClone.ToXElement());
                Log.VerifyTrue(isEqual, "Theme Cloned IS different from the original one.");

                Log.Comment("LocalName...");
                Log.VerifyValue(theme.LocalName, "theme", "LocalName of Theme is {0} instead ofexpected a:theme", theme.LocalName);

                Log.Comment("Associating Part...");
                Log.VerifyReference(themePart, themePart.Theme.ThemePart, "Associating Part of Theme is different from Hosting Part!");

                Log.Comment("Saving changes to Theme Part...");
                theme.Save(themePart);
            }
            Log.Pass("Theme as PartRoot Class Testing Passed.");
        }

        private enum RootElementConstructors { defaultCtor, IEnumerable, Params, OuterXml };
        private Dr.Theme buildRootElementFromPart(ThemePart part, RootElementConstructors buildWay)
        {
            Dr.Theme root = null;
            switch (buildWay)
            {
                case RootElementConstructors.defaultCtor:
                    root = new Dr.Theme();
                    root.Load(part);
                    break;
                case RootElementConstructors.IEnumerable:
                    root = new Dr.Theme(part.Theme.Elements().AsEnumerable());
                    break;
                case RootElementConstructors.Params:
                    root = new Dr.Theme(part.Theme.Elements().ToArray());
                    break;
                case RootElementConstructors.OuterXml:
                    root = new Dr.Theme(part.Theme.OuterXml);
                    break;
            }
            return root;
        }

        // Constructors, CloneNode, Properties for attributes, LocalName, Properties for each child element
        [Fact]
        public void ThemeAsClassWithFixedOrderChildTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfile = CopyTestFiles(@"wordprocessing", true, "complex0.docx", f => f.IsWordprocessingFile())
                .Where(f => f.IsWordprocessingFile() || f.IsSpreadsheetFile())
                .FirstOrDefault();

            using (var package = testfile.OpenPackage(true) as WordprocessingDocument)
            {
                ThemePart themePart = package.MainDocumentPart.ThemePart;

                Log.Comment("Constructing Theme...");
                Dr.Theme theme = buildRootElementFromPart(themePart, RootElementConstructors.defaultCtor);
                var xThemeFromFile = ConvertToXElement(themePart, theme);

                Log.Comment("Child Element Properties...");
                XElement xTheme = ConvertToXElement(themePart, theme);
                // doc.CustomColorList
                CustomColorList ccl = theme.CustomColorList;
                if (null != ccl)
                {
                    XElement xccl = xTheme.Element(ccl.GetXName());
                    var isEqual = xccl.Compare(ccl.ToXElement());
                    Log.VerifyTrue(isEqual, "CustomColorList property is different from expectation.");
                }

                // doc.ExtensionList;
                var el = theme.OfficeStyleSheetExtensionList;
                if (null != el)
                {
                    XElement xel = xTheme.Element(el.GetXName());
                    var isEqual = xel.Compare(el.ToXElement());
                    Log.VerifyTrue(isEqual, "ExtensionList property is different from expectation.");
                }

                //doc.ExtraColorSchemeList;
                var ecsl = theme.ExtraColorSchemeList;
                if (null != ecsl)
                {
                    XElement xecsl = xTheme.Element(ecsl.GetXName());
                    var isEqual = xecsl.Compare(ecsl.ToXElement());
                    Log.VerifyTrue(isEqual, "ExtraColorSchemeList property is different from expectation.");
                }

                //doc.ObjectDefaults;
                var od = theme.ObjectDefaults;
                if (null != od)
                {
                    XElement xod = xTheme.Element(od.GetXName());
                    var isEqual = xod.Compare(od.ToXElement());
                    Log.VerifyTrue(isEqual, "ObjectDefaults property is different from expectation.");
                }

                //doc.ThemeElements;
                var te = theme.ThemeElements;
                if (null != te)
                {
                    XElement xte = xTheme.Element(te.GetXName());
                    var isEqual = xte.Compare(te.ToXElement());
                    Log.VerifyTrue(isEqual, "ThemeElements property is different from expectation.");
                }
                Log.Comment("Saving changes to Theme...");
                theme.Save(themePart);
            }
            Log.Pass("Theme as Class With Fixed Order Children Testing Passed.");
        }

        // Constructors, CloneNode, Properties for attributes, LocalName
        [Fact]
        public void ColorAsLeafElementTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfile = CopyTestFiles(@"wordprocessing", true, "complex0.docx", f => f.IsWordprocessingFile())
                .FirstOrDefault();

            using (var package = testfile.OpenPackage(true) as WordprocessingDocument)
            {
                MainDocumentPart mainPart = package.MainDocumentPart;

                Log.Comment("Constructing Document...");
                var doc = mainPart.Document;

                var colors = doc.Descendants<DocumentFormat.OpenXml.Wordprocessing.Color>();
                foreach (var color in colors)
                {
                    Log.VerifyNotNull(color, "No Color exists in the document.");
                    Log.Comment("Attribute Properties...");
                    if (null != color.ThemeColor)
                        Log.Comment("Color.ThemeColor: {0}", color.ThemeColor.Value);
                    if (null != color.ThemeShade)
                        Log.Comment("Color.ThemeShade: {0}", color.ThemeShade.Value);
                    if (null != color.ThemeTint)
                        Log.Comment("Color.ThemeTint: {0}", color.ThemeTint.Value);
                    Log.Comment("Color.Val: {0}", color.Val);

                    Log.Comment("Child Element Properties...");
                    Log.Comment("Color as OpenXmlLeafElement has NOT children at all.");
                    Log.VerifyValue(color.ChildElements.Count, 0, "Child elements exist for Color.");

                    Log.Comment("Clone...");
                    var xColor = ConvertToXElement(mainPart, color);
                    var hClone = color.CloneNode(false).ToXElement();
                    var dClone = color.CloneNode(true).ToXElement();
                    var isEqual = xColor.Compare(hClone);
                    Log.VerifyTrue(isEqual, "Hallow Clone returned different content from original one.");
                    isEqual = hClone.Compare(dClone);
                    Log.VerifyTrue(isEqual, "Deep Clone returned different content from hallow clone.");

                    Log.Comment("LocalName...");
                    Log.VerifyValue(color.LocalName, "color", "LocalName of Color is NOT w:color");
                }

                Log.Comment("Saving changes to Theme...");
                doc.Save(mainPart);
            }
            Log.Pass("Color as Leaf Element Testing Passed.");
        }

        // Constructors, CloneNode, Properties for attributes, LocalName, Text
        [Fact]
        public void FieldCodeAsLeafTextElement()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfile = CopyTestFiles(@"wordprocessing", true, "complex0.docx", f => f.IsWordprocessingFile())
                .FirstOrDefault();

            using (var package = testfile.OpenPackage(true) as WordprocessingDocument)
            {
                MainDocumentPart mainPart = package.MainDocumentPart;

                Log.Comment("Loading Document element...");
                Document doc = mainPart.Document;
                var xDoc = ConvertToXElement(mainPart, doc);
                var fields = doc.Descendants<FieldCode>();

                foreach (var field in fields)
                {
                    Log.VerifyNotNull(field, "No FieldCode exists in the document.");
                    Log.Comment("OuterXml: {0}", field.OuterXml);
                    var xField = ConvertToXElement(mainPart, field);
                    Log.Comment("Text...");
                    Log.Comment("InnerText: {0}", field.InnerText);
                    Log.Comment("Text: {0}", field.Text);
                    Log.VerifyValue(field.Text, xField.Value,
                        "FieldCode's Text: {0} is different from XElement: {1}", field.Text, xField.Value);

                    Log.Comment("Attribute Properties...");
                    //Log.Comment("PreserveSpace: {0}", field.PreserveSpace);
                    Log.Comment("Contains significant space: ", (string)field.Space);

                    Log.Comment("Child Element Properties...");
                    Log.Comment("FieldCode should has NO child as LeafTextElement.");
                    Log.VerifyValue(field.ChildElements.Count, 0, "Child elements exist for FieldCode!");

                    Log.Comment("Clone...");
                    var hClone = field.CloneNode(false).ToXElement();
                    var dClone = field.CloneNode(true).ToXElement();
                    var isEqual = xField.Compare(hClone);
                    Log.VerifyTrue(isEqual, "Hallow Clone returned different content from original one.");
                    isEqual = hClone.Compare(dClone);
                    Log.VerifyTrue(isEqual, "Deep Clone returned different content from hallow clone.");

                    Log.Comment("LocalName...");
                    Log.VerifyValue(field.LocalName, "instrText", "LocalName of FieldCode is NOT w:instrText");
                }

                Log.Comment("Saving changes to Document...");
                doc.Save(mainPart);
            }
            Log.Pass("FieldCode as Leaf Text Element Testing Passed.");
        }

        [Fact]
        public void Bug225919_MitigateNamespaceIssue()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            //var testfiles = GetTestfile(@"wordprocessing", MethodInfo.GetCurrentMethod().Name)
            //    .Where(f => f.IsWordprocessingFile());
            //var testfiles = GetTestfile(@"spreadsheet", MethodInfo.GetCurrentMethod().Name)
            //    .Where(f => f.IsSpreadsheetFile());
            var testfiles = CopyTestFiles(@"presentation")
                .Where(f => f.IsPresentationFile())
                .Take(20);

            //var testfile = testfiles.FirstOrDefault();
            foreach (var testfile in testfiles)
            {
                //if (testfile.Name == "Open xml api testing.ppam")
                //    Console.WriteLine();
                Log.BeginGroup(testfile.FullName);
                try
                {
                    Log.Comment("Opening Package {0}...", testfile.FullName);
                    using (var package = testfile.OpenPackage(true))
                    {
                        var parts = package.DescendantParts().Where(p => p.IsReflectable())
                            //.Where(p => p is CustomXmlPart || p is ExtendedFilePropertiesPart)
                            .OrderBy(p => p.Uri.ToString())
                            .ToList();
                        var l = parts.Select(p => p.Uri).Aggregate("", (s, i) => s + i + Environment.NewLine);
                        parts.ForEach(p =>
                        {
                            Log.Comment("Loading and saving {0}@{1}...", p.GetType().Name, p.Uri);
                            var rootElement = p.RootElement;
                            if (rootElement != null)
                            {
                                rootElement.Save();
                                Log.Comment("{0} saved.", p.GetType().Name);
                            }
                        });
                        Log.Pass("Package {0} Parts save complete.", testfile.FullName);
                    }
                }
                catch (Exception e)
                {
                    if (TaskLibraries.OpenXmlDomTaskLibrary.IsKnownIssue(TaskLibraries.DataStorage.TestDataStorage.RootFolder, testfile.FullName, e.Message) == true)
                    {
                        Log.Warning(e.ToString());
                    }
                    else
                    {
                        Log.Fail(e.Message);
                    }
                }
                finally
                {
                    Log.EndGroup(testfile.FullName);
                }
            }
        }

        // Looking for testfiles that contains specified content - Internal Use Only
        public void Looking4Testfiles()
        {
            var testfiles = CopyTestFiles(@"wordprocessing")
                .Where(f => f.IsWordprocessingFile() || f.IsSpreadsheetFile());

            foreach (var testfile in testfiles)
            {
                Log.BeginGroup(testfile.FullName);

                using (var package = testfile.OpenPackage(false))
                {
                    var parts = package.DescendantParts().Where(p => p.IsReflectable());
                    var themes = parts.Select(
                        p => p.RootElement()).OfType<DocumentFormat.OpenXml.Drawing.Theme>();
                    var borderPropertiesTypes = parts.SelectMany(
                        p => p.RootElement().Descendants<DocumentFormat.OpenXml.Spreadsheet.BorderPropertiesType>());
                    var leftBorders = parts.SelectMany(
                        p => p.RootElement().Descendants<DocumentFormat.OpenXml.Spreadsheet.LeftBorder>());
                    var colors = parts.SelectMany(
                        p => p.RootElement().Descendants<DocumentFormat.OpenXml.Wordprocessing.Color>());
                    var uniqueTags = parts
                        .Where(p => p is DocumentFormat.OpenXml.Packaging.MainDocumentPart)
                        .SelectMany(
                        p => p.RootElement().Descendants<DocumentFormat.OpenXml.OpenXmlLeafTextElement>())
                        .Where(e => !(e is DocumentFormat.OpenXml.Wordprocessing.Text));

                    themes.ForEach(e =>
                    {
                        Log.Comment(e.Path());
                        Log.Comment(e.HostPart().ToString());
                    });
                    borderPropertiesTypes.ForEach(e =>
                    {
                        Log.Comment(e.Path());
                        Log.Comment(e.PartRootElement().HostPart().ToString());
                    });
                    leftBorders.ForEach(e =>
                    {
                        Log.Comment(e.Path());
                        Log.Comment(e.PartRootElement().HostPart().ToString());
                    });
                    colors.ForEach(e =>
                    {
                        Log.Comment(e.Path());
                        Log.Comment(e.PartRootElement().HostPart().ToString());
                    });
                    uniqueTags.ForEach(e =>
                    {
                        Log.Comment(e.Path());
                        Log.Comment(e.ToString());
                        Log.Comment(e.PartRootElement().HostPart().ToString());
                    });
                }
            }
        }
    }
}