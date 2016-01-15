// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml.Linq;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation;
using Xunit;

namespace DocumentFormat.OpenXml.Tests
{
    using DocumentFormat.OpenXml.Tests.TaskLibraries;
    using DocumentFormat.OpenXml.Tests.TaskLibraries.DataStorage;

    /// <summary>
    /// Summary description for MarkupCompatibilityTest
    /// </summary>
    
    public class MarkupCompatibilityTest : OpenXmlDomTestBase
    {
        public MarkupCompatibilityTest()
        { }

        #region Private Fields
        internal static string xmlNS = "http://www.w3.org/XML/1998/namespace";
        OpenXmlAttribute xmlSpace = new OpenXmlAttribute("xml", "space", xmlNS, "default"); // two valid value: default, preserve
        OpenXmlAttribute xmlLang = new OpenXmlAttribute("xml", "lang", xmlNS, "en-US");

        internal static string nsUnknown1 = "http://test.openxmlsdk.microsoft.com/unknownns1";
        internal static string prefixUnknown1 = "uns1";
        internal static string a1Unknown1 = "a1uk1";
        internal static string a2Unknown1 = "a2uk1";
        OpenXmlAttribute unknownAttribute11 = new OpenXmlAttribute(prefixUnknown1, a1Unknown1, nsUnknown1, "attribute1 from unknown namespace1.");
        OpenXmlAttribute unknownAttribute12 = new OpenXmlAttribute(prefixUnknown1, a2Unknown1, nsUnknown1, "attribute2 from unknown namespace1.");
        internal static string e1Unknown1 = "e1uk1";
        internal static string e2Unknown1 = "e2uk1";
        OpenXmlElement unknownElement11 = new OpenXmlUnknownElement(prefixUnknown1, e1Unknown1, nsUnknown1);
        OpenXmlElement unknownElement12 = new OpenXmlUnknownElement(prefixUnknown1, e2Unknown1, nsUnknown1);

        internal static string nsUnknown2 = "http://test.openxmlsdk.microsoft.com/unknownns2";
        internal static string prefixUnknown2 = "uns2";
        internal static string a1Unknown2 = "a1uk2";
        internal static string a2Unknown2 = "a2uk2";
        OpenXmlAttribute unknownAttribute21 = new OpenXmlAttribute(prefixUnknown2, a1Unknown2, nsUnknown2, "attribute1 from unknown namespace2.");
        OpenXmlAttribute unknownAttribute22 = new OpenXmlAttribute(prefixUnknown2, a2Unknown2, nsUnknown2, "attribute2 from unknown namespace2.");
        internal static string e1Unknown2 = "e1uk2";
        internal static string e2Unknown2 = "e2uk2";
        OpenXmlElement unknownElement21 = new OpenXmlUnknownElement(prefixUnknown2, e1Unknown2, nsUnknown2);
        OpenXmlElement unknownElement22 = new OpenXmlUnknownElement(prefixUnknown2, e2Unknown2, nsUnknown2);

        OpenXmlAttribute unprefixedAttribute = new OpenXmlAttribute(string.Empty, "name", null, "unprefixed attributes");

        delegate void actionOnElement(OpenXmlElement e);

        #endregion Private Fields

        #region IgnorableTest
        [Fact]
        public void NonIgnored_UnknownAttribute_FullMode()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null, targetPath = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickSecond(),
                e =>
                {
                    Log.Comment("Skipping setting Ignorable @{0} with value: {1}", e.Path(), unknownAttribute11.Prefix);
                    //e.SetIgnorable(unknownAttribute11.Prefix);
                },
                ref targetPath, e => e.Descendants().PickSecond(),
                e =>
                {
                    Log.Comment("Setting attribute {0} @{1}...", unknownAttribute11.GetFullName(), e.Path());
                    e.SetAttribute(unknownAttribute11);
                });
            var expectedAttribute = unknownAttribute11;

            Log.Comment("ReOpening file:{0}...", testfile.FullName);
            using (var package = testfile.OpenPackage(true, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.NoProcess))
            {
                OpenXmlElement host, target;
                locateElements(package, partUri, hostPath, out host, targetPath, out target);

                //verifyMcAttribute(host, "Ignorable", expectedAttribute.Prefix);

                verifyExtendedAttribute(target, expectedAttribute);
            }
        }

        [Fact]
        public void NonIgnored_UnknownAttribute_O12Mode()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null, targetPath = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickSecond(),
                e =>
                {
                    Log.Comment("Skipping setting Ignorable @{0} with value: {1}", e.Path(), unknownAttribute11.Prefix);
                },
                ref targetPath, e => e.Descendants().PickSecond(),
                e =>
                {
                    Log.Comment("Setting attribute {0} @{1}...", unknownAttribute11.GetFullName(), e.Path());
                    e.SetAttribute(unknownAttribute11);
                });
            var expectedAttribute = unknownAttribute11;

            Log.Comment("ReOpening file:{0}...", testfile.FullName);
            using (var package = testfile.OpenPackage(true, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.ProcessAllParts))
            {
                OpenXmlElement host, target;
                locateElements(package, partUri, hostPath, out host, targetPath, out target);

                verifyExtendedAttribute(target, expectedAttribute);
            }
        }

        [Fact]
        public void Validate_NonIgnored_UnknownAttribute()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null, targetPath = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickSecond(),
                e =>
                {
                    Log.Comment("Skipping setting Ignorable @{0} with value: {1}", e.Path(), unknownAttribute11.Prefix);
                },
                ref targetPath, e => e.Descendants().PickSecond(),
                e =>
                {
                    Log.Comment("Setting attribute {0} @{1}...", unknownAttribute11.GetFullName(), e.Path());
                    e.SetAttribute(unknownAttribute11);
                });

            Log.Warning("Validating and Expecting validation error for Non-Ignored unknown attribute...");
            validateMC(testfile, FileFormatVersions.Office2007, hostPath);
        }

        [Fact]
        public void NonIgnored_UnknownElement_FullMode()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null, targetPath = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement),
                e =>
                {
                    Log.Comment("Skipping setting Ignorable @{0} with value: {1}", e.Path(), unknownElement11.Prefix);
                },
                ref targetPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement),
                e =>
                {
                    Log.Comment("Appending element {0} to {1}...", unknownElement11.GetFullName(), e.Path());
                    e.AppendChild(unknownElement11);
                });

            Log.Comment("ReOpening file:{0}...", testfile.FullName);
            using (var package = testfile.OpenPackage(true, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.NoProcess))
            {
                OpenXmlElement host, target;
                locateElements(package, partUri, hostPath, out host, targetPath, out target);

                var expectedElement = unknownElement11.CloneNode(true);

                verifyUnknownElement(target.LastChild, expectedElement);
            }
        }

        [Fact]
        public void NonIgnored_UnknownElement_O12Mode()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null, targetPath = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement),
                e =>
                {
                    Log.Comment("Skipping setting Ignorable @{0} with value: {1}", e.Path(), unknownElement11.Prefix);
                },
                ref targetPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement),
                e =>
                {
                    Log.Comment("Appending element {0} to {1}...", unknownElement11.GetFullName(), e.Path());
                    e.AppendChild(unknownElement11);
                });

            Log.Comment("ReOpening file:{0}...", testfile.FullName);
            using (var package = testfile.OpenPackage(true, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.ProcessAllParts))
            {
                OpenXmlElement host, target;
                locateElements(package, partUri, hostPath, out host, targetPath, out target);

                var expectedElement = unknownElement11.CloneNode(true);

                verifyUnknownElement(target.LastChild, expectedElement);
            }
        }

        [Fact]
        public void Validate_NonIgnored_UnknownElement()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null, targetPath = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement),
                e =>
                {
                    Log.Comment("Skipping setting Ignorable @{0} with value: {1}", e.Path(), unknownElement11.Prefix);
                },
                ref targetPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement),
                e =>
                {
                    Log.Comment("Appending element {0} to {1}...", unknownElement11.GetFullName(), e.Path());
                    e.AppendChild(unknownElement11);
                });

            Log.Warning("Validating and Expecting validation error for Non-Ignored unknown element...");
            validateMC(testfile, FileFormatVersions.Office2007, hostPath);
        }

        [Fact]
        public void Ignored_UnknownAttribute_FullMode()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null, targetPath = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickSecond(),
                e =>
                {
                    e.SetIgnorable(unknownAttribute11.Prefix);
                    e.AddNamespaceDeclaration(unknownAttribute11.Prefix, unknownAttribute11.NamespaceUri);
                },
                ref targetPath, e => e.Descendants().PickSecond(),
                e => e.SetAttribute(unknownAttribute11));
            var expectedAttribute = unknownAttribute11;

            Log.Comment("ReOpening file:{0}...", testfile.FullName);
            using (var package = testfile.OpenPackage(true, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.NoProcess))
            {
                OpenXmlElement host, target;
                locateElements(package, partUri, hostPath, out host, targetPath, out target);

                verifyMcAttribute(host, "Ignorable", expectedAttribute.Prefix);

                verifyExtendedAttribute(target, expectedAttribute);
            }
        }

        [Fact]
        public void Ignored_UnknownAttribute_O12Mode()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null, targetPath = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickSecond(),
                e =>
                {
                    e.SetIgnorable(unknownAttribute11.Prefix);
                    e.AddNamespaceDeclaration(unknownAttribute11.Prefix, unknownAttribute11.NamespaceUri);
                },
                ref targetPath, e => e.Descendants().PickSecond(),
                e => e.SetAttribute(unknownAttribute11));
            var expectedAttribute = unknownAttribute11;

            Log.Comment("ReOpening file:{0}...", testfile.FullName);
            using (var package = testfile.OpenPackage(true, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.ProcessAllParts))
            {
                OpenXmlElement host, target;
                locateElements(package, partUri, hostPath, out host, targetPath, out target);

                verifyNoExtendedAttribute(target, expectedAttribute);
            }
        }

        [Fact]
        public void Validate_Ignored_UnknownAttribute()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null, targetPath = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickSecond(),
                e =>
                {
                    e.SetIgnorable(unknownAttribute11.Prefix);
                    e.AddNamespaceDeclaration(unknownAttribute11.Prefix, unknownAttribute11.NamespaceUri);
                },
                ref targetPath, e => e.Descendants().PickSecond(),
                e => e.SetAttribute(unknownAttribute11));

            Log.Warning("Validating and Expecting NO MC validation error...");
            validateMC(testfile, FileFormatVersions.Office2007);
        }

        [Fact]
        public void Ignored_KnownAttribute_FullMode()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null, targetPath = null;
            OpenXmlAttribute knownAttribute = new OpenXmlAttribute();
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d.HasAttributes && d.ExtendedAttributes.Count() == 0),
                e => e.SetIgnorable(knownAttribute.Prefix),
                ref targetPath, e => e.Descendants().PickFirst(d => d.HasAttributes && d.ExtendedAttributes.Count() == 0),
                e => { knownAttribute = e.GetAttributes().First(); });

            Log.Comment("ReOpening file:{0}...", testfile.FullName);
            using (var package = testfile.OpenPackage(true, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.NoProcess))
            {
                OpenXmlElement host, target;
                locateElements(package, partUri, hostPath, out host, targetPath, out target);

                var expectedAttribute = knownAttribute;
                verifyMcAttribute(host, "Ignorable", expectedAttribute.Prefix);

                verifyKnownAttribute(target, expectedAttribute);
            }
        }

        [Fact]
        public void Ignored_KnownAttribute_O12Mode()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null, targetPath = null;
            OpenXmlAttribute knownAttribute = new OpenXmlAttribute();
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d.HasAttributes && d.ExtendedAttributes.Count() == 0),
                e => e.SetIgnorable(knownAttribute.Prefix),
                ref targetPath, e => e.Descendants().PickFirst(d => d.HasAttributes && d.ExtendedAttributes.Count() == 0),
                e => { knownAttribute = e.GetAttributes().First(); });

            Log.Comment("ReOpening file:{0}...", testfile.FullName);
            using (var package = testfile.OpenPackage(true, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.ProcessAllParts))
            {
                OpenXmlElement host, target;
                locateElements(package, partUri, hostPath, out host, targetPath, out target);

                var expectedAttribute = knownAttribute;

                verifyKnownAttribute(target, expectedAttribute);
            }
        }

        [Fact]
        public void Validate_Ignored_KnownAttribute()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null, targetPath = null;
            OpenXmlAttribute knownAttribute = new OpenXmlAttribute();
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d.HasAttributes && d.ExtendedAttributes.Count() == 0),
                e => e.SetIgnorable(knownAttribute.Prefix),
                ref targetPath, e => e.Descendants().PickFirst(d => d.HasAttributes && d.ExtendedAttributes.Count() == 0),
                e => { knownAttribute = e.GetAttributes().First(); });

            Log.Warning("Validating and Expecting NO MC validation error...");
            validateMC(testfile, FileFormatVersions.Office2007);
        }

        [Fact]
        public void Ignored_UnknownElement_FullMode()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null, targetPath = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement),
                e =>
                {
                    e.SetIgnorable(unknownElement11.Prefix);
                    e.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);
                },
                ref targetPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement),
                e => e.AppendChild(unknownElement11));

            Log.Comment("ReOpening file:{0}...", testfile.FullName);
            using (var package = testfile.OpenPackage(true, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.NoProcess))
            {
                OpenXmlElement host, target;
                locateElements(package, partUri, hostPath, out host, targetPath, out target);

                var expectedElement = unknownElement11.CloneNode(true);
                verifyMcAttribute(host, "Ignorable", expectedElement.Prefix);

                verifyUnknownElement(target.LastChild, expectedElement);
            }
        }

        [Fact]
        public void Ignored_UnknownElement_O12Mode()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null, targetPath = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement),
                e =>
                {
                    e.SetIgnorable(unknownElement11.Prefix);
                    e.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);
                },
                ref targetPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement),
                e => e.AppendChild(unknownElement11));

            Log.Comment("ReOpening file:{0}...", testfile.FullName);
            using (var package = testfile.OpenPackage(true, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.ProcessAllParts))
            {
                OpenXmlElement host, target;
                locateElements(package, partUri, hostPath, out host, targetPath, out target);

                var expectedElement = unknownElement11.CloneNode(true);
                //verifyNoIgnorable(host, expectedElement.Prefix);

                verifyNoUnknownElement(target.LastChild, expectedElement);
            }
        }

        [Fact]
        public void Validate_Ignored_UnknownElement()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null, targetPath = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement),
                e =>
                {
                    e.SetIgnorable(unknownElement11.Prefix);
                    e.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);
                },
                ref targetPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement),
                e => e.AppendChild(unknownElement11));

            Log.Warning("Validating and Expecting NO MC validation error...");
            validateMC(testfile, FileFormatVersions.Office2007);
        }

        [Fact]
        public void Ignored_KnownElement_FullMode()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null, targetPath = null;
            OpenXmlElement knownElement = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d.FirstChild != null && !(d.FirstChild is OpenXmlUnknownElement)),
                e => e.SetIgnorable(knownElement.Prefix),
                ref targetPath, e => e.Descendants().PickFirst(d => d.FirstChild != null && !(d.FirstChild is OpenXmlUnknownElement)),
                e => knownElement = e.FirstChild.CloneNode(true));

            Log.Comment("ReOpening file:{0}...", testfile.FullName);
            using (var package = testfile.OpenPackage(true, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.NoProcess))
            {
                OpenXmlElement host, target;
                locateElements(package, partUri, hostPath, out host, targetPath, out target);

                var expectedElement = knownElement;
                verifyMcAttribute(host, "Ignorable", expectedElement.Prefix);

                verifyKnownElement(target.FirstChild, expectedElement);
            }
        }

        [Fact]
        public void Ignored_KnownElement_O12Mode()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null, targetPath = null;
            OpenXmlElement knownElement = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d.FirstChild != null && !(d.FirstChild is OpenXmlUnknownElement)),
                e => e.SetIgnorable(knownElement.Prefix),
                ref targetPath, e => e.Descendants().PickFirst(d => d.FirstChild != null && !(d.FirstChild is OpenXmlUnknownElement)),
                e => knownElement = e.FirstChild.CloneNode(true));

            Log.Comment("ReOpening file:{0}...", testfile.FullName);
            using (var package = testfile.OpenPackage(true, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.ProcessAllParts))
            {
                OpenXmlElement host, target;
                locateElements(package, partUri, hostPath, out host, targetPath, out target);

                var expectedElement = knownElement;

                verifyKnownElement(target.FirstChild, expectedElement);
            }
        }

        [Fact]
        public void Validate_Ignored_KnownElement()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null, targetPath = null;
            OpenXmlElement knownElement = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d.FirstChild != null && !(d.FirstChild is OpenXmlUnknownElement)),
                e => e.SetIgnorable(knownElement.Prefix),
                ref targetPath, e => e.Descendants().PickFirst(d => d.FirstChild != null && !(d.FirstChild is OpenXmlUnknownElement)),
                e => knownElement = e.FirstChild.CloneNode(true));

            Log.Warning("Validating and Expecting NO MC validation error...");
            validateMC(testfile, FileFormatVersions.Office2007);
        }

        [Fact]
        public void Ignore_Whitespaces_FullMode()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null, targetPath = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement),
                e =>
                {
                    e.SetIgnorable("\x20\x9\xA\xD");
                },
                ref targetPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement),
                e => e.Clone());

            Log.Comment("ReOpening file:{0}...", testfile.FullName);
            using (var package = testfile.OpenPackage(true, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.NoProcess))
            {
                OpenXmlElement host, target;
                locateElements(package, partUri, hostPath, out host, targetPath, out target);

                verifyMcAttribute(host, "Ignorable", "\x20\x9\xA\xD");
            }
        }

        [Fact]
        public void Validate_Ignore_Whitespaces()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null, targetPath = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement),
                e =>
                {
                    e.SetIgnorable("\x20\x9\xA\xD");
                    e.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);
                },
                ref targetPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement),
                e => e.AppendChild(unknownElement11));

            Log.Warning("Validating and Expecting NO MC validation error...");
            validateMC(testfile, FileFormatVersions.Office2007);
        }

        #endregion IgnorableTest

        #region ProcessContent
        // process content (attaching attributes and child element)
        [Fact]
        public void ProcessContent_Ignored_UnknownElement_FullMode()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null, targetPath = null;
            List<OpenXmlElement> children = new List<OpenXmlElement>();
            string pchostPath = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement)),
                e =>
                {
                    Log.Comment("Setting Ignorable @{0} with value: {1}", e.Path(), unknownElement11.Prefix);
                    e.SetIgnorable(unknownElement11.Prefix);
                    e.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);

                    var pchost = e;
                    pchostPath = pchost.Path();
                    Log.Comment("Setting ProcessContent @ {0} with value: {1}", pchost.Path(), unknownElement11.GetFullName());
                    pchost.SetProcessContent(unknownElement11.GetFullName());
                },
                ref targetPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement)),
                e =>
                {
                    wrapChildrenWithElement(e, unknownElement11, children);
                });

            Log.Comment("ReOpening file:{0}...", testfile.FullName);
            using (var package = testfile.OpenPackage(true, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.NoProcess))
            {
                OpenXmlElement host, target, pchost;
                locateElements(package, partUri, hostPath, out host, targetPath, out target);
                locateElements(package, partUri, hostPath, out host, pchostPath, out pchost);

                var expectedElement = unknownElement11;
                verifyMcAttribute(host, "Ignorable", expectedElement.Prefix);

                verifyMcAttribute(pchost, "ProcessContent", expectedElement.GetFullName());

                verifyUnknownElement(target.LastChild, expectedElement);

                verifyUnknownChildren(target.LastChild, children);
            }
        }

        [Fact]
        public void ProcessContent_Ignored_UnknownElement_O12Mode()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null, targetPath = null;
            List<OpenXmlElement> children = new List<OpenXmlElement>();
            XElement original = null;
            string pchostPath = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement)),
                e =>
                {
                    Log.Comment("Setting Ignorable @{0} with value: {1}", e.Path(), unknownElement11.Prefix);
                    e.SetIgnorable(unknownElement11.Prefix);
                    e.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);

                    var pchost = e;
                    pchostPath = pchost.Path();
                    Log.Comment("Setting ProcessContent @ {0} with value: {1}", pchost.Path(), unknownElement11.GetFullName());
                    pchost.SetProcessContent(unknownElement11.GetFullName());
                },
                ref targetPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement)),
                e =>
                {
                    original = e.ToXElement();

                    wrapChildrenWithElement(e, unknownElement11, children);
                });

            Log.Comment("ReOpening file:{0}...", testfile.FullName);
            using (var package = testfile.OpenPackage(true, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.ProcessAllParts))
            {
                OpenXmlElement host, target, pchost;
                locateElements(package, partUri, hostPath, out host, targetPath, out target);
                locateElements(package, partUri, hostPath, out host, pchostPath, out pchost);

                var expectedElement = unknownElement11;

                verifyNoUnkownChild(target, expectedElement.GetFullName());

                verifyKnownChildren(target, children);
            }
        }

        [Fact]
        public void Validate_ProcessContent_Ignored_UnknownElement()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null, targetPath = null;
            List<OpenXmlElement> children = new List<OpenXmlElement>();
            string pchostPath = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement)),
                e =>
                {
                    Log.Comment("Setting Ignorable @{0} with value: {1}", e.Path(), unknownElement11.Prefix);
                    e.SetIgnorable(unknownElement11.Prefix);
                    e.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);

                    var pchost = e;
                    pchostPath = pchost.Path();
                    Log.Comment("Setting ProcessContent @ {0} with value: {1}", pchost.Path(), unknownElement11.GetFullName());
                    pchost.SetProcessContent(unknownElement11.GetFullName());
                },
                ref targetPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement)),
                e =>
                {
                    wrapChildrenWithElement(e, unknownElement11, children);
                });

            validateMC(testfile, FileFormatVersions.Office2007);
        }

        [Fact]
        public void ProcessContent_Ignored_UnknownElement_Wildcard_FullMode()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null, targetPath = null;
            List<OpenXmlElement> children = new List<OpenXmlElement>();
            string pchostPath = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement)),
                e =>
                {
                    Log.Comment("Setting Ignorable @{0} with value: {1}", e.Path(), unknownElement11.Prefix);
                    e.SetIgnorable(unknownElement11.Prefix);
                    e.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);

                    var pchost = e;
                    pchostPath = pchost.Path();
                    Log.Comment("Setting ProcessContent @ {0} with value: {1}", pchost.Path(), "*");
                    pchost.SetProcessContent("*");
                },
                ref targetPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement)),
                e =>
                {
                    wrapChildrenWithElement(e, unknownElement11, children);
                });

            Log.Comment("ReOpening file:{0}...", testfile.FullName);
            using (var package = testfile.OpenPackage(true, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.NoProcess))
            {
                OpenXmlElement host, target, pchost;
                locateElements(package, partUri, hostPath, out host, targetPath, out target);
                locateElements(package, partUri, hostPath, out host, pchostPath, out pchost);

                var expectedElement = unknownElement11;
                verifyMcAttribute(host, "Ignorable", expectedElement.Prefix);

                verifyMcAttribute(pchost, "ProcessContent", "*");

                verifyUnknownElement(target.LastChild, expectedElement);

                verifyUnknownChildren(target.LastChild, children);
            }
        }

        [Fact]
        public void ProcessContent_NonIgnored_UnknownElement_FullMode()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null, targetPath = null;
            List<OpenXmlElement> children = new List<OpenXmlElement>();
            XElement unknownE11 = null;
            string pchostPath = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement),
                e =>
                {
                    Log.Comment("Skip setting Ignorable @{0} with value: {1}", e.Path(), unknownElement11.Prefix);

                    var pchost = e;
                    pchostPath = pchost.Path();
                    Log.Comment("Setting ProcessContent @{0} with value: {1}", pchost.Path(), unknownElement11.GetFullName());
                    pchost.SetProcessContent(unknownElement11.GetFullName());
                    pchost.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);
                },
                ref targetPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement),
                e =>
                {
                    wrapChildrenWithElement(e, unknownElement11, children);

                    unknownE11 = e.LastChild.ToXElement();
                });

            Log.Comment("ReOpening file:{0}...", testfile.FullName);
            using (var package = testfile.OpenPackage(true, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.NoProcess))
            {
                OpenXmlElement host, target, pchost;
                locateElements(package, partUri, hostPath, out host, targetPath, out target);
                locateElements(package, partUri, hostPath, out host, pchostPath, out pchost);

                verifyNoMcAttribute(host, "Ignorable", unknownElement11.Prefix);

                verifyMcAttribute(pchost, "ProcessContent", unknownElement11.GetFullName());

                verifyUnknownElement(target.LastChild, unknownElement11);

                verifyUnknownChildren(target.LastChild, children);
            }
        }

        [Fact]
        public void ProcessContent_NonIgnored_UnknownElement_O12Mode()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null, targetPath = null;
            List<OpenXmlElement> children = new List<OpenXmlElement>();
            XElement original = null;
            string pchostPath = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement),
                e =>
                {
                    Log.Comment("Skip setting Ignorable @{0} with value: {1}", e.Path(), unknownElement11.Prefix);

                    var pchost = e;
                    pchostPath = pchost.Path();
                    Log.Comment("Setting ProcessContent @{0} with value: {1}", pchost.Path(), unknownElement11.GetFullName());
                    pchost.SetProcessContent(unknownElement11.GetFullName());
                    pchost.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);
                },
                ref targetPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement),
                e =>
                {
                    original = e.ToXElement();

                    wrapChildrenWithElement(e, unknownElement11, children);
                });

            Log.Comment("ReOpening file:{0}...", testfile.FullName);
            OpenXmlPackage package = null;
            try
            {
                package = testfile.OpenPackage(true, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.ProcessAllParts);

                OpenXmlElement host, target, pchost;
                locateElements(package, partUri, hostPath, out host, targetPath, out target);
                locateElements(package, partUri, hostPath, out host, pchostPath, out pchost);

                verifyNoMcAttribute(pchost, "ProcessContent", unknownElement11.GetFullName());

                verifyUnknownElement(target.LastChild, unknownElement11);
                verifyUnknownChildren(target.LastChild, children);
            }
            catch (Exception ex)
            {
                Log.Pass("Exception {0} thrown out with message:\n {1}.", ex.GetType().FullName, ex.ToString());
            }
            finally
            {
                if (package != null)
                    package.Close();
            }
        }

        [Fact]
        public void Validate_ProcessContent_NonIgnored_UnknownElement()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null, targetPath = null;
            List<OpenXmlElement> children = new List<OpenXmlElement>();
            XElement original = null;
            string pchostPath = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement),
                e =>
                {
                    Log.Comment("Skip setting @Ignorable on {0}...", e.Path());

                    var pchost = e;
                    pchostPath = pchost.Path();
                    Log.Comment("Setting ProcessContent @{0} with value: {1}", pchost.Path(), unknownElement11.GetFullName());
                    pchost.SetProcessContent(unknownElement11.GetFullName());
                    pchost.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);
                },
                ref targetPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement),
                e =>
                {
                    original = e.ToXElement();

                    wrapChildrenWithElement(e, unknownElement11, children);
                });

            validateMC(testfile, FileFormatVersions.Office2007);
        }

        [Fact]
        public void ProcessContent_Ignored_KnownElement_FullMode()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null, targetPath = null;
            List<OpenXmlElement> children = new List<OpenXmlElement>();
            OpenXmlElement known = null;
            string pchostPath = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !(d.FirstChild is OpenXmlUnknownElement)),
                e =>
                {
                    Log.Comment("Setting Ignorable @{0} with value: {1}", e.Path(), known.Prefix);
                    e.SetIgnorable(known.Prefix);

                    var pchost = e;
                    pchostPath = pchost.Path();
                    Log.Comment("Setting ProcessContent @ {0} with value: {1}", pchost.Path(), known.GetFullName());
                    pchost.SetProcessContent(known.GetFullName());
                },
                ref targetPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !(d.FirstChild is OpenXmlUnknownElement)),
                e =>
                {
                    known = e.FirstChild.CloneNode(true);
                });

            Log.Comment("ReOpening file:{0}...", testfile.FullName);
            using (var package = testfile.OpenPackage(true, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.NoProcess))
            {
                OpenXmlElement host, target, pchost;
                locateElements(package, partUri, hostPath, out host, targetPath, out target);
                locateElements(package, partUri, hostPath, out host, pchostPath, out pchost);

                verifyMcAttribute(host, "Ignorable", known.Prefix);

                verifyMcAttribute(pchost, "ProcessContent", known.GetFullName());

                verifyKnownElement(target.FirstChild, known);
            }
        }

        [Fact]
        public void ProcessContent_Ignored_KnownElement_O12Mode()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null, targetPath = null;
            List<OpenXmlElement> children = new List<OpenXmlElement>();
            OpenXmlElement known = null;
            string pchostPath = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !(d.FirstChild is OpenXmlUnknownElement)),
                e =>
                {
                    Log.Comment("Setting Ignorable @{0} with value: {1}", e.Path(), known.Prefix);
                    e.SetIgnorable(known.Prefix);

                    var pchost = e;
                    pchostPath = pchost.Path();
                    Log.Comment("Setting ProcessContent @ {0} with value: {1}", pchost.Path(), known.GetFullName());
                    pchost.SetProcessContent(known.GetFullName());
                },
                ref targetPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !(d.FirstChild is OpenXmlUnknownElement)),
                e =>
                {
                    known = e.FirstChild.CloneNode(true);
                });

            Log.Comment("ReOpening file:{0}...", testfile.FullName);
            using (var package = testfile.OpenPackage(true, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.ProcessAllParts))
            {
                OpenXmlElement host, target, pchost;
                locateElements(package, partUri, hostPath, out host, targetPath, out target);
                locateElements(package, partUri, hostPath, out host, pchostPath, out pchost);

                verifyKnownElement(target.FirstChild, known);
            }
        }

        [Fact]
        public void Validate_ProcessContent_Ignored_KnownElement()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null, targetPath = null;
            List<OpenXmlElement> children = new List<OpenXmlElement>();
            OpenXmlElement known = null;
            string pchostPath = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !(d.FirstChild is OpenXmlUnknownElement)),
                e =>
                {
                    Log.Comment("Setting Ignorable @{0} with value: {1}", e.Path(), known.Prefix);
                    e.SetIgnorable(known.Prefix);

                    var pchost = e;
                    pchostPath = pchost.Path();
                    Log.Comment("Setting ProcessContent @ {0} with value: {1}", pchost.Path(), known.GetFullName());
                    pchost.SetProcessContent(known.GetFullName());
                },
                ref targetPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !(d.FirstChild is OpenXmlUnknownElement)),
                e =>
                {
                    known = e.FirstChild.CloneNode(true);
                });

            validateMC(testfile, FileFormatVersions.Office2007);
        }

        [Fact]
        public void ProcessContent_xmlSpace_FullMode()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null, targetPath = null;
            List<OpenXmlElement> children = new List<OpenXmlElement>();
            string pchostPath = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement)),
                e =>
                {
                    Log.Comment("Setting Ignorable @{0} with value: {1}", e.Path(), unknownElement11.Prefix);
                    e.SetIgnorable(unknownElement11.Prefix);
                    e.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);

                    var pchost = e;
                    pchostPath = pchost.Path();
                    Log.Comment("Setting ProcessContent @ {0} with value: {1}", pchost.Path(), unknownElement11.GetFullName());
                    pchost.SetProcessContent(unknownElement11.GetFullName());

                    pchost.SetAttribute(xmlSpace);
                },
                ref targetPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement)),
                e =>
                {
                    wrapChildrenWithElement(e, unknownElement11, children);
                });

            Log.Comment("ReOpening file:{0}...", testfile.FullName);
            using (var package = testfile.OpenPackage(true, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.NoProcess))
            {
                OpenXmlElement host, target, pchost;
                locateElements(package, partUri, hostPath, out host, targetPath, out target);
                locateElements(package, partUri, hostPath, out host, pchostPath, out pchost);

                var expectedElement = unknownElement11;
                verifyMcAttribute(host, "Ignorable", expectedElement.Prefix);

                verifyMcAttribute(pchost, "ProcessContent", expectedElement.GetFullName());

                verifyAttribute(pchost, xmlSpace);

                verifyUnknownElement(target.LastChild, expectedElement);

                verifyUnknownChildren(target.LastChild, children);
            }
        }

        [Fact]
        public void ProcessContent_xmlLang_FullMode()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null, targetPath = null;
            List<OpenXmlElement> children = new List<OpenXmlElement>();
            string pchostPath = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement)),
                e =>
                {
                    Log.Comment("Setting Ignorable @{0} with value: {1}", e.Path(), unknownElement11.Prefix);
                    e.SetIgnorable(unknownElement11.Prefix);
                    e.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);

                    var pchost = e;
                    pchostPath = pchost.Path();
                    Log.Comment("Setting ProcessContent @ {0} with value: {1}", pchost.Path(), unknownElement11.GetFullName());
                    pchost.SetProcessContent(unknownElement11.GetFullName());

                    pchost.SetAttribute(xmlLang);
                },
                ref targetPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement)),
                e =>
                {
                    wrapChildrenWithElement(e, unknownElement11, children);
                });

            Log.Comment("ReOpening file:{0}...", testfile.FullName);
            using (var package = testfile.OpenPackage(true, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.NoProcess))
            {
                OpenXmlElement host, target, pchost;
                locateElements(package, partUri, hostPath, out host, targetPath, out target);
                locateElements(package, partUri, hostPath, out host, pchostPath, out pchost);

                var expectedElement = unknownElement11;
                verifyMcAttribute(host, "Ignorable", expectedElement.Prefix);

                verifyMcAttribute(pchost, "ProcessContent", expectedElement.GetFullName());

                verifyAttribute(pchost, xmlLang);

                verifyUnknownElement(target.LastChild, expectedElement);

                verifyUnknownChildren(target.LastChild, children);
            }
        }

        [Fact]
        public void Validate_ProcessContent_xmlLang()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null, targetPath = null;
            List<OpenXmlElement> children = new List<OpenXmlElement>();
            //XElement unknownE11 = null;
            string pchostPath = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement)),
                e =>
                {
                    Log.Comment("Setting Ignorable @{0} with value: {1}", e.Path(), unknownElement11.Prefix);
                    e.SetIgnorable(unknownElement11.Prefix);
                    e.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);

                    var pchost = e;
                    pchostPath = pchost.Path();
                    Log.Comment("Setting ProcessContent @ {0} with value: {1}", pchost.Path(), unknownElement11.GetFullName());
                    pchost.SetProcessContent(unknownElement11.GetFullName());

                    pchost.SetAttribute(xmlLang);
                },
                ref targetPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement)),
                e =>
                {
                    wrapChildrenWithElement(e, unknownElement11, children);
                });

            validateMC(testfile, FileFormatVersions.Office2007);
        }
        #endregion ProcessContent

        #region Preserve Elements & Attributes
        // ignored unknown element along with ignored prefixed attribute, unprefixed attribute, non-ignored unknown attribute.
        [Fact]
        public void Preserve_Ignored_UnknownElement_FullMode()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null, targetPath = null;
            List<OpenXmlElement> children = new List<OpenXmlElement>();
            OpenXmlElement expectedElement = null;
            string pehostPath = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement)),
                e =>
                {
                    Log.Comment("Setting Ignorable @{0} with value: {1}", e.Path(), unknownElement11.Prefix);
                    e.SetIgnorable(unknownElement11.Prefix);
                    e.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);

                    var pehost = e;
                    pehostPath = pehost.Path();

                    Log.Comment("Setting PreserveElements@ {0} with value: {1}", pehost.Path(), unknownElement11.GetFullName());
                    pehost.SetPreserveElements(unknownElement11.GetFullName());

                    Log.Comment("Setting PreserveAttributes@ {0} with value: {1}", pehost.Path(), unknownAttribute11.GetFullName());
                    pehost.SetPreserveAttributes(unknownAttribute11.GetFullName());
                },
                ref targetPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement)),
                e =>
                {
                    foreach (var d in e.ChildElements)
                        children.Add(d.CloneNode(true));
                    e.AppendChild(unknownElement11);
                    unknownElement11.SetAttribute(unknownAttribute11);
                    unknownElement11.SetAttribute(unknownAttribute12);
                    unknownElement11.SetAttribute(unprefixedAttribute);

                    expectedElement = unknownElement11.CloneNode(true);
                });

            Log.Comment("ReOpening file:{0}...", testfile.FullName);
            using (var package = testfile.OpenPackage(true, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.NoProcess))
            {
                OpenXmlElement host, target, pehost;
                locateElements(package, partUri, hostPath, out host, targetPath, out target);
                locateElements(package, partUri, hostPath, out host, pehostPath, out pehost);

                verifyMcAttribute(host, "Ignorable", unknownElement11.Prefix);
                verifyMcAttribute(pehost, "PreserveElements", unknownElement11.GetFullName());
                verifyMcAttribute(pehost, "PreserveAttributes", unknownAttribute11.GetFullName());

                verifyUnknownElement(target.LastChild, expectedElement);
                verifyKnownChildren(target, children);
            }
        }

        [Fact]
        public void Preserve_Ignored_UnknownElement_O12Mode()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null, targetPath = null;
            List<OpenXmlElement> children = new List<OpenXmlElement>();
            OpenXmlElement expectedElement = null;
            string pehostPath = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement)),
                e =>
                {
                    Log.Comment("Setting Ignorable @{0} with value: {1}", e.Path(), unknownElement11.Prefix);
                    e.SetIgnorable(unknownElement11.Prefix);
                    e.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);

                    var pehost = e;
                    pehostPath = pehost.Path();

                    Log.Comment("Setting PreserveElements@ {0} with value: {1}", pehost.Path(), unknownElement11.GetFullName());
                    pehost.SetPreserveElements(unknownElement11.GetFullName());

                    Log.Comment("Setting PreserveAttributes@ {0} with value: {1}", pehost.Path(), unknownAttribute11.GetFullName());
                    pehost.SetPreserveAttributes(unknownAttribute11.GetFullName());
                },
                ref targetPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement)),
                e =>
                {
                    foreach (var d in e.ChildElements)
                        children.Add(d.CloneNode(true));
                    e.AppendChild(unknownElement11);
                    unknownElement11.SetAttribute(unknownAttribute11);
                    unknownElement11.SetAttribute(unprefixedAttribute);

                    // unknownAttribute12 should be ignored as it's not specified with PreserveAttributes. 
                    expectedElement = unknownElement11.CloneNode(true);
                    unknownElement11.SetAttribute(unknownAttribute12);
                });

            Log.Comment("ReOpening file:{0}...", testfile.FullName);
            using (var package = testfile.OpenPackage(true, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.ProcessAllParts))
            {
                OpenXmlElement host, target, pehost;
                locateElements(package, partUri, hostPath, out host, targetPath, out target);
                locateElements(package, partUri, hostPath, out host, pehostPath, out pehost);

                verifyUnknownElement(target.LastChild, expectedElement);

                verifyAttribute(target.LastChild, unknownAttribute11);

                verifyAttribute(target.LastChild, unprefixedAttribute);

                verifyNoAttribute(target.LastChild, unknownAttribute12);

                verifyKnownChildren(target, children);
            }
        }

        [Fact]
        public void Validate_Preserve_Ignored_UnknownElement()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null, targetPath = null;
            List<OpenXmlElement> children = new List<OpenXmlElement>();
            OpenXmlElement expectedElement = null;
            string pehostPath = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement)),
                e =>
                {
                    Log.Comment("Setting Ignorable @{0} with value: {1}", e.Path(), unknownElement11.Prefix);
                    e.SetIgnorable(unknownElement11.Prefix);
                    e.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);

                    var pehost = e;
                    pehostPath = pehost.Path();

                    Log.Comment("Setting PreserveElements@ {0} with value: {1}", pehost.Path(), unknownElement11.GetFullName());
                    pehost.SetPreserveElements(unknownElement11.GetFullName());

                    Log.Comment("Setting PreserveAttributes@ {0} with value: {1}", pehost.Path(), unknownAttribute11.GetFullName());
                    pehost.SetPreserveAttributes(unknownAttribute11.GetFullName());
                },
                ref targetPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement)),
                e =>
                {
                    foreach (var d in e.ChildElements)
                        children.Add(d.CloneNode(true));
                    e.AppendChild(unknownElement11);
                    unknownElement11.SetAttribute(unknownAttribute11);
                    unknownElement11.SetAttribute(unknownAttribute12);
                    unknownElement11.SetAttribute(unprefixedAttribute);

                    expectedElement = unknownElement11.CloneNode(true);
                });

            Log.Warning("Validating and Expecting NO MC validation error...");
            validateMC(testfile, FileFormatVersions.Office2007);
        }

        [Fact]
        public void Preserve_Ignored_UnknownElement_InnerIgnorable_FullMode()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null, targetPath = null;
            List<OpenXmlElement> children = new List<OpenXmlElement>();
            OpenXmlElement expectedElement = null, innerUnknownElement = null;
            string pehostPath = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Elements().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && d.FirstChild is OpenXmlCompositeElement && !d.ChildElements.Any(c => c is OpenXmlUnknownElement)),
                e =>
                {
                    Log.Comment("Setting Ignorable @{0} with value: {1}", e.Path(), unknownElement11.Prefix);
                    e.SetIgnorable(unknownElement11.Prefix);
                    e.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);

                    var pehost = e;
                    pehostPath = pehost.Path();

                    Log.Comment("Setting PreserveElements@ {0} with value: {1}", pehost.Path(), unknownElement11.GetFullName());
                    pehost.SetPreserveElements(unknownElement11.GetFullName());

                    Log.Comment("Setting PreserveAttributes@ {0} with value: {1}", pehost.Path(), unknownAttribute11.GetFullName());
                    pehost.SetPreserveAttributes(unknownAttribute11.GetFullName());
                },
                ref targetPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && d.FirstChild is OpenXmlCompositeElement && !d.ChildElements.Any(c => c is OpenXmlUnknownElement)),
                e =>
                {
                    // append unknown element(with unknown attributes) to first child
                    var firstChild = e.FirstChild;
                    Log.Comment("Setting Inner Ignorable @{0} with value: {1}", firstChild.Path(), unknownElement12.Prefix);
                    firstChild.SetIgnorable(unknownElement12.Prefix);

                    Log.Comment("Appending unknown child element to {0}...", firstChild.Path());
                    firstChild.AppendChild(unknownElement12);
                    unknownElement12.SetAttribute(unknownAttribute11);
                    unknownElement12.SetAttribute(unknownAttribute12);
                    innerUnknownElement = unknownElement12.CloneNode(true);

                    Log.Comment("Appending unknown element(with unknown attributes) to {0}...", e.Path());
                    foreach (var d in e.ChildElements)
                        children.Add(d.CloneNode(true));
                    e.AppendChild(unknownElement11);
                    unknownElement11.SetAttribute(unknownAttribute11);
                    unknownElement11.SetAttribute(unknownAttribute12);
                    unknownElement11.SetAttribute(unprefixedAttribute);

                    expectedElement = unknownElement11.CloneNode(true);
                });

            Log.Comment("ReOpening file:{0}...", testfile.FullName);
            using (var package = testfile.OpenPackage(true, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.NoProcess))
            {
                OpenXmlElement host, target, pehost;
                locateElements(package, partUri, hostPath, out host, targetPath, out target);
                locateElements(package, partUri, hostPath, out host, pehostPath, out pehost);

                verifyMcAttribute(host, "Ignorable", unknownElement11.Prefix);
                verifyMcAttribute(pehost, "PreserveElements", unknownElement11.GetFullName());
                verifyMcAttribute(pehost, "PreserveAttributes", unknownAttribute11.GetFullName());

                verifyUnknownElement(target.LastChild, expectedElement);
                verifyKnownChildren(target, children);

                verifyUnknownElement(target.FirstChild.LastChild, innerUnknownElement);
            }
        }

        [Fact]
        public void Preserve_Ignored_UnknownElement_InnerIgnorable_O12Mode()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null, targetPath = null;
            List<OpenXmlElement> children = new List<OpenXmlElement>();
            OpenXmlElement expectedElement = null;
            string pehostPath = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Elements().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && d.FirstChild is OpenXmlCompositeElement && !d.ChildElements.Any(c => c is OpenXmlUnknownElement)),
                e =>
                {
                    Log.Comment("Setting Ignorable @{0} with value: {1}", e.Path(), unknownElement11.Prefix);
                    e.SetIgnorable(unknownElement11.Prefix);
                    e.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);

                    var pehost = e;
                    pehostPath = pehost.Path();

                    Log.Comment("Setting PreserveElements@ {0} with value: {1}", pehost.Path(), unknownElement11.GetFullName());
                    pehost.SetPreserveElements(unknownElement11.GetFullName());

                    Log.Comment("Setting PreserveAttributes@ {0} with value: {1}", pehost.Path(), unknownAttribute11.GetFullName());
                    pehost.SetPreserveAttributes(unknownAttribute11.GetFullName());
                },
                ref targetPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && d.FirstChild is OpenXmlCompositeElement && !d.ChildElements.Any(c => c is OpenXmlUnknownElement)),
                e =>
                {
                    Log.Comment("Appending unknown element(with unknown attributes) to {0}...", e.Path());
                    foreach (var d in e.ChildElements)
                        children.Add(d.CloneNode(true));
                    e.AppendChild(unknownElement11);
                    unknownElement11.SetAttribute(unknownAttribute11);
                    unknownElement11.SetAttribute(unprefixedAttribute);

                    // unknownAttribute12 should be ignored as it's not specified with PreserveAttributes. 
                    expectedElement = unknownElement11.CloneNode(true);
                    unknownElement11.SetAttribute(unknownAttribute12);

                    var firstChild = e.FirstChild;
                    Log.Comment("Setting Inner Ignorable @{0} with value: {1}", firstChild.Path(), unknownElement12.Prefix);
                    firstChild.SetIgnorable(unknownElement12.Prefix);
                    children[0] = firstChild.CloneNode(true);   // hack to fix a issue - Ignorable will be preserved

                    // append unknown element(with unknown attributes) to first child
                    Log.Comment("Appending unknown child element to {0}...", firstChild.Path());
                    firstChild.AppendChild(unknownElement12);
                    unknownElement12.SetAttribute(unknownAttribute11);
                    unknownElement12.SetAttribute(unknownAttribute12);
                });

            Log.Comment("ReOpening file:{0}...", testfile.FullName);
            using (var package = testfile.OpenPackage(true, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.ProcessAllParts))
            {
                OpenXmlElement host, target, pehost;
                locateElements(package, partUri, hostPath, out host, targetPath, out target);
                locateElements(package, partUri, hostPath, out host, pehostPath, out pehost);

                verifyUnknownElement(target.LastChild, expectedElement);

                verifyAttribute(target.LastChild, unknownAttribute11);

                verifyAttribute(target.LastChild, unprefixedAttribute);

                verifyNoAttribute(target.LastChild, unknownAttribute12);

                verifyKnownChildren(target, children);
            }
        }

        [Fact]
        public void Validate_Preserve_Ignored_UnknownElement_InnerIgnorable()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null, targetPath = null;
            List<OpenXmlElement> children = new List<OpenXmlElement>();
            OpenXmlElement expectedElement = null, innerUnknownElement = null;
            string pehostPath = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Elements().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && d.FirstChild is OpenXmlCompositeElement && !d.ChildElements.Any(c => c is OpenXmlUnknownElement)),
                e =>
                {
                    Log.Comment("Setting Ignorable @{0} with value: {1}", e.Path(), unknownElement11.Prefix);
                    e.SetIgnorable(unknownElement11.Prefix);
                    e.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);

                    var pehost = e;
                    pehostPath = pehost.Path();

                    Log.Comment("Setting PreserveElements@ {0} with value: {1}", pehost.Path(), unknownElement11.GetFullName());
                    pehost.SetPreserveElements(unknownElement11.GetFullName());

                    Log.Comment("Setting PreserveAttributes@ {0} with value: {1}", pehost.Path(), unknownAttribute11.GetFullName());
                    pehost.SetPreserveAttributes(unknownAttribute11.GetFullName());
                },
                ref targetPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && d.FirstChild is OpenXmlCompositeElement && !d.ChildElements.Any(c => c is OpenXmlUnknownElement)),
                e =>
                {
                    // append unknown element(with unknown attributes) to first child
                    var firstChild = e.FirstChild;
                    Log.Comment("Setting Inner Ignorable @{0} with value: {1}", firstChild.Path(), unknownElement12.Prefix);
                    firstChild.SetIgnorable(unknownElement12.Prefix);

                    Log.Comment("Appending unknown child element to {0}...", firstChild.Path());
                    firstChild.AppendChild(unknownElement12);
                    unknownElement12.SetAttribute(unknownAttribute11);
                    unknownElement12.SetAttribute(unknownAttribute12);
                    innerUnknownElement = unknownElement12.CloneNode(true);

                    Log.Comment("Appending unknown element(with unknown attributes) to {0}...", e.Path());
                    foreach (var d in e.ChildElements)
                        children.Add(d.CloneNode(true));
                    e.AppendChild(unknownElement11);
                    unknownElement11.SetAttribute(unknownAttribute11);
                    unknownElement11.SetAttribute(unknownAttribute12);
                    unknownElement11.SetAttribute(unprefixedAttribute);

                    expectedElement = unknownElement11.CloneNode(true);
                });

            Log.Warning("Validating and Expecting NO MC validation error...");
            validateMC(testfile, FileFormatVersions.Office2007);
        }

        [Fact]
        public void Preserve_Ignored_UnknownElement_Wildcard_FullMode()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null, targetPath = null;
            List<OpenXmlElement> children = new List<OpenXmlElement>();
            OpenXmlElement expectedElement = null;
            string pehostPath = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement)),
                e =>
                {
                    Log.Comment("Setting Ignorable @{0} with value: {1}", e.Path(), unknownElement11.Prefix);
                    e.SetIgnorable(unknownElement11.Prefix);
                    e.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);

                    var pehost = e;
                    pehostPath = pehost.Path();

                    Log.Comment("Setting PreserveElements@ {0} with value: {1}", pehost.Path(), "*");
                    pehost.SetPreserveElements("*");

                    Log.Comment("Setting PreserveAttributes@ {0} with value: {1}", pehost.Path(), "*");
                    pehost.SetPreserveAttributes("*");
                },
                ref targetPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement)),
                e =>
                {
                    foreach (var d in e.ChildElements)
                        children.Add(d.CloneNode(true));
                    e.AppendChild(unknownElement11);
                    unknownElement11.SetAttribute(unknownAttribute11);
                    unknownElement11.SetAttribute(unknownAttribute12);
                    unknownElement11.SetAttribute(unprefixedAttribute);

                    expectedElement = unknownElement11.CloneNode(true);
                });

            Log.Comment("ReOpening file:{0}...", testfile.FullName);
            using (var package = testfile.OpenPackage(true, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.NoProcess))
            {
                OpenXmlElement host, target, pehost;
                locateElements(package, partUri, hostPath, out host, targetPath, out target);
                locateElements(package, partUri, hostPath, out host, pehostPath, out pehost);

                verifyMcAttribute(host, "Ignorable", unknownElement11.Prefix);
                verifyMcAttribute(pehost, "PreserveElements", "*");
                verifyMcAttribute(pehost, "PreserveAttributes", "*");

                verifyUnknownElement(target.LastChild, expectedElement);
                verifyKnownChildren(target, children);
            }
        }

        //[Fact]
        public void Preserve_Ignored_UnknownElement_Wildcard_O12Mode()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null, targetPath = null;
            List<OpenXmlElement> children = new List<OpenXmlElement>();
            OpenXmlElement expectedElement = null;
            string pehostPath = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement)),
                e =>
                {
                    Log.Comment("Setting Ignorable @{0} with value: {1}", e.Path(), unknownElement11.Prefix);
                    e.SetIgnorable(unknownElement11.Prefix);
                    e.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);

                    var pehost = e;
                    pehostPath = pehost.Path();

                    Log.Comment("Setting PreserveElements@ {0} with value: {1}", pehost.Path(), "*");
                    pehost.SetPreserveElements("*");

                    Log.Comment("Setting PreserveAttributes@ {0} with value: {1}", pehost.Path(), "*");
                    pehost.SetPreserveAttributes("*");
                },
                ref targetPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement)),
                e =>
                {
                    foreach (var d in e.ChildElements)
                        children.Add(d.CloneNode(true));
                    e.AppendChild(unknownElement11);
                    unknownElement11.SetAttribute(unknownAttribute11);
                    unknownElement11.SetAttribute(unprefixedAttribute);

                    // unknownAttribute12 should be ignored as it's not specified with PreserveAttributes. 
                    expectedElement = unknownElement11.CloneNode(true);
                    unknownElement11.SetAttribute(unknownAttribute12);
                });

            Log.Comment("ReOpening file:{0}...", testfile.FullName);
            using (var package = testfile.OpenPackage(true, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.ProcessAllParts))
            {
                OpenXmlElement host, target, pehost;
                locateElements(package, partUri, hostPath, out host, targetPath, out target);
                locateElements(package, partUri, hostPath, out host, pehostPath, out pehost);

                verifyUnknownElement(target.LastChild, expectedElement);

                verifyAttribute(target.LastChild, unknownAttribute11);

                verifyAttribute(target.LastChild, unprefixedAttribute);

                verifyNoAttribute(target.LastChild, unknownAttribute12);

                verifyKnownChildren(target, children);
            }
        }

        //[Fact]
        public void Validate_Preserve_Ignored_UnknownElement_Wildcard()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null, targetPath = null;
            List<OpenXmlElement> children = new List<OpenXmlElement>();
            OpenXmlElement expectedElement = null;
            string pehostPath = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement)),
                e =>
                {
                    Log.Comment("Setting Ignorable @{0} with value: {1}", e.Path(), unknownElement11.Prefix);
                    e.SetIgnorable(unknownElement11.Prefix);
                    e.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);

                    var pehost = e;
                    pehostPath = pehost.Path();

                    Log.Comment("Setting PreserveElements@ {0} with value: {1}", pehost.Path(), "*");
                    pehost.SetPreserveElements("*");

                    Log.Comment("Setting PreserveAttributes@ {0} with value: {1}", pehost.Path(), "*");
                    pehost.SetPreserveAttributes("*");
                },
                ref targetPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement)),
                e =>
                {
                    foreach (var d in e.ChildElements)
                        children.Add(d.CloneNode(true));
                    e.AppendChild(unknownElement11);
                    unknownElement11.SetAttribute(unknownAttribute11);
                    unknownElement11.SetAttribute(unknownAttribute12);
                    unknownElement11.SetAttribute(unprefixedAttribute);

                    expectedElement = unknownElement11.CloneNode(true);
                });

            Log.Warning("Validating and Expecting NO MC validation error...");
            validateMC(testfile, FileFormatVersions.Office2007);
        }

        [Fact]
        public void Preserve_NonIgnored_UnknownElement_FullMode()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null, targetPath = null;
            List<OpenXmlElement> children = new List<OpenXmlElement>();
            OpenXmlElement expectedElement = null;
            string pehostPath = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement)),
                e =>
                {
                    Log.Comment("Skipping setting Ignorable @{0} with value: {1}", e.Path(), unknownElement11.Prefix);

                    var pehost = e;
                    pehostPath = pehost.Path();

                    Log.Comment("Setting PreserveElements@ {0} with value: {1}", pehost.Path(), unknownElement11.GetFullName());
                    pehost.SetPreserveElements(unknownElement11.GetFullName());
                    pehost.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);

                    Log.Comment("Setting PreserveAttributes@ {0} with value: {1}", pehost.Path(), unknownAttribute11.GetFullName());
                    pehost.SetPreserveAttributes(unknownAttribute11.GetFullName());
                },
                ref targetPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement)),
                e =>
                {
                    foreach (var d in e.ChildElements)
                        children.Add(d.CloneNode(true));
                    e.AppendChild(unknownElement11);
                    unknownElement11.SetAttribute(unknownAttribute11);
                    unknownElement11.SetAttribute(unknownAttribute12);
                    unknownElement11.SetAttribute(unprefixedAttribute);

                    expectedElement = unknownElement11.CloneNode(true);
                });

            Log.Comment("ReOpening file:{0}...", testfile.FullName);
            using (var package = testfile.OpenPackage(true, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.NoProcess))
            {
                OpenXmlElement host, target, pehost;
                locateElements(package, partUri, hostPath, out host, targetPath, out target);
                locateElements(package, partUri, hostPath, out host, pehostPath, out pehost);

                verifyMcAttribute(pehost, "PreserveElements", unknownElement11.GetFullName());
                verifyMcAttribute(pehost, "PreserveAttributes", unknownAttribute11.GetFullName());

                verifyUnknownElement(target.LastChild, expectedElement);
                verifyKnownChildren(target, children);
            }
        }

        [Fact]
        public void Preserve_NonIgnored_UnknownElement_O12Mode()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null, targetPath = null;
            List<OpenXmlElement> children = new List<OpenXmlElement>();
            OpenXmlElement expectedElement = null;
            string pehostPath = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement)),
                e =>
                {
                    Log.Comment("Skipping setting Ignorable @{0} with value: {1}", e.Path(), unknownElement11.Prefix);
                    var pehost = e;
                    pehostPath = pehost.Path();

                    Log.Comment("Setting PreserveElements@ {0} with value: {1}", pehost.Path(), unknownElement11.GetFullName());
                    pehost.SetPreserveElements(unknownElement11.GetFullName());
                    pehost.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);

                    Log.Comment("Setting PreserveAttributes@ {0} with value: {1}", pehost.Path(), unknownAttribute11.GetFullName());
                    pehost.SetPreserveAttributes(unknownAttribute11.GetFullName());
                },
                ref targetPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement)),
                e =>
                {
                    foreach (var d in e.ChildElements)
                        children.Add(d.CloneNode(true));
                    e.AppendChild(unknownElement11);
                    unknownElement11.SetAttribute(unknownAttribute11);
                    unknownElement11.SetAttribute(unknownAttribute12);
                    unknownElement11.SetAttribute(unprefixedAttribute);

                    expectedElement = unknownElement11.CloneNode(true);
                });

            Log.Comment("ReOpening file:{0}...", testfile.FullName);
            OpenXmlPackage package = null;
            try
            {
                package = testfile.OpenPackage(true, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.ProcessAllParts);
                OpenXmlElement host, target, pchost;
                locateElements(package, partUri, hostPath, out host, targetPath, out target);
                locateElements(package, partUri, hostPath, out host, pehostPath, out pchost);

                // This test case originally failed even if it runs with V2.0 RTM build - means the test script itself has a bug.
                // We decided to flip the result to re-use it as a backward compatibility test case.
                Log.Pass("[Known Issue from V2.0] No exception thrown out for Unknown element that's not Ignored but identified by PreserveElements/Attributes.");
            }
            catch (Exception ex)
            {
                Log.Fail("[Known Issue from V2.0] Exception {0} thrown out with message:\n {1}.", ex.GetType().FullName, ex.ToString());
            }
            finally
            {
                if (package != null) package.Close();
            }
        }

        [Fact]
        public void Validate_Preserve_NonIgnored_UnknownElement()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null, targetPath = null;
            List<OpenXmlElement> children = new List<OpenXmlElement>();
            OpenXmlElement expectedElement = null;
            string pehostPath = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement)),
                e =>
                {
                    Log.Comment("Skipping setting Ignorable @{0} with value: {1}", e.Path(), unknownElement11.Prefix);
                    var pehost = e;
                    pehostPath = pehost.Path();

                    Log.Comment("Setting PreserveElements@ {0} with value: {1}", pehost.Path(), unknownElement11.GetFullName());
                    pehost.SetPreserveElements(unknownElement11.GetFullName());
                    pehost.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);

                    Log.Comment("Setting PreserveAttributes@ {0} with value: {1}", pehost.Path(), unknownAttribute11.GetFullName());
                    pehost.SetPreserveAttributes(unknownAttribute11.GetFullName());
                },
                ref targetPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement)),
                e =>
                {
                    foreach (var d in e.ChildElements)
                        children.Add(d.CloneNode(true));
                    e.AppendChild(unknownElement11);
                    unknownElement11.SetAttribute(unknownAttribute11);
                    unknownElement11.SetAttribute(unknownAttribute12);
                    unknownElement11.SetAttribute(unprefixedAttribute);

                    expectedElement = unknownElement11.CloneNode(true);
                });

            Log.Warning("Validating and Expecting validation error for PreserveElements...");
            validateMC(testfile, FileFormatVersions.Office2007);
        }

        [Fact]
        public void Preserve_NonIgnored_UnknownAttribute_FullMode()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null, targetPath = null;
            List<OpenXmlElement> children = new List<OpenXmlElement>();
            OpenXmlElement expectedElement = null;
            string pehostPath = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement)),
                e =>
                {
                    Log.Comment("Skipping setting Ignorable @{0} with value: {1}", e.Path(), unknownElement11.Prefix);
                    var pehost = e;
                    pehostPath = pehost.Path();

                    Log.Comment("Skipping setting PreserveElements@ {0} with value: {1}", pehost.Path(), unknownElement11.GetFullName());

                    Log.Comment("Setting PreserveAttributes@ {0} with value: {1}", pehost.Path(), unknownAttribute11.GetFullName());
                    pehost.SetPreserveAttributes(unknownAttribute11.GetFullName());
                    pehost.AddNamespaceDeclaration(unknownAttribute11.Prefix, unknownAttribute11.NamespaceUri);
                },
                ref targetPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement)),
                e =>
                {
                    foreach (var d in e.ChildElements)
                        children.Add(d.CloneNode(true));
                    e.AppendChild(unknownElement11);
                    unknownElement11.SetAttribute(unknownAttribute11);
                    unknownElement11.SetAttribute(unknownAttribute12);
                    unknownElement11.SetAttribute(unprefixedAttribute);

                    expectedElement = unknownElement11.CloneNode(true);
                });

            Log.Comment("ReOpening file:{0}...", testfile.FullName);
            using (var package = testfile.OpenPackage(true, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.NoProcess))
            {
                OpenXmlElement host, target, pehost;
                locateElements(package, partUri, hostPath, out host, targetPath, out target);
                locateElements(package, partUri, hostPath, out host, pehostPath, out pehost);

                verifyMcAttribute(pehost, "PreserveAttributes", unknownAttribute11.GetFullName());

                verifyUnknownElement(target.LastChild, expectedElement);
                verifyKnownChildren(target, children);
            }
        }

        [Fact]
        public void Preserve_NonIgnored_UnknownAttribute_O12Mode()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null, targetPath = null;
            List<OpenXmlElement> children = new List<OpenXmlElement>();
            OpenXmlElement expectedElement = null;
            string pehostPath = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement)),
                e =>
                {
                    Log.Comment("Skipping setting Ignorable @{0} with value: {1}", e.Path(), unknownElement11.Prefix);
                    var pehost = e;
                    pehostPath = pehost.Path();

                    Log.Comment("Skipping setting PreserveElements@ {0} with value: {1}", pehost.Path(), unknownElement11.GetFullName());

                    Log.Comment("Setting PreserveAttributes@ {0} with value: {1}", pehost.Path(), unknownAttribute11.GetFullName());
                    pehost.SetPreserveAttributes(unknownAttribute11.GetFullName());
                    pehost.AddNamespaceDeclaration(unknownAttribute11.Prefix, unknownAttribute11.NamespaceUri);
                },
                ref targetPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement)),
                e =>
                {
                    foreach (var d in e.ChildElements)
                        children.Add(d.CloneNode(true));
                    e.AppendChild(unknownElement11);
                    unknownElement11.SetAttribute(unknownAttribute11);
                    unknownElement11.SetAttribute(unknownAttribute12);
                    unknownElement11.SetAttribute(unprefixedAttribute);

                    expectedElement = unknownElement11.CloneNode(true);
                });

            Log.Comment("ReOpening file:{0}...", testfile.FullName);
            OpenXmlPackage package = null;
            try
            {
                package = testfile.OpenPackage(true, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.ProcessAllParts);
                OpenXmlElement host, target, pchost;
                locateElements(package, partUri, hostPath, out host, targetPath, out target);
                locateElements(package, partUri, hostPath, out host, pehostPath, out pchost);

                // This test case originally failed even if it runs with V2.0 RTM build - means the test script itself has a bug.
                // We decided to flip the result to re-use it as a backward compatibility test case.
                Log.Pass("[Known Issue from V2.0] No unexpected expected exception thrown out for unknown attribute that's not Ignored but identified by PreserveAttributes.");
            }
            catch (Exception ex)
            {
                Log.Fail("[Known Issue from V2.0] Exception {0} thrown out with message:\n {1}.", ex.GetType().FullName, ex.ToString());
            }
            finally
            {
                if (package != null) package.Close();
            }
        }

        [Fact]
        public void Validate_Preserve_NonIgnored_UnknownAttribute()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null, targetPath = null;
            List<OpenXmlElement> children = new List<OpenXmlElement>();
            OpenXmlElement expectedElement = null;
            string pehostPath = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement)),
                e =>
                {
                    Log.Comment("Skipping setting Ignorable @{0} with value: {1}", e.Path(), unknownElement11.Prefix);
                    var pehost = e;
                    pehostPath = pehost.Path();

                    Log.Comment("Skipping setting PreserveElements@ {0} with value: {1}", pehost.Path(), unknownElement11.GetFullName());

                    Log.Comment("Setting PreserveAttributes@ {0} with value: {1}", pehost.Path(), unknownAttribute11.GetFullName());
                    pehost.SetPreserveAttributes(unknownAttribute11.GetFullName());
                    pehost.AddNamespaceDeclaration(unknownAttribute11.Prefix, unknownAttribute11.NamespaceUri);
                },
                ref targetPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement)),
                e =>
                {
                    foreach (var d in e.ChildElements)
                        children.Add(d.CloneNode(true));
                    e.AppendChild(unknownElement11);
                    unknownElement11.SetAttribute(unknownAttribute11);
                    unknownElement11.SetAttribute(unknownAttribute12);
                    unknownElement11.SetAttribute(unprefixedAttribute);

                    expectedElement = unknownElement11.CloneNode(true);
                });

            Log.Warning("Validating and Expecting validation error for PreserveAttributes...");
            validateMC(testfile, FileFormatVersions.Office2007);
        }

        [Fact]
        public void Preserve_NoElement_UnknownAttribute_FullMode()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null, targetPath = null;
            List<OpenXmlElement> children = new List<OpenXmlElement>();
            OpenXmlElement expectedElement = null;
            string pehostPath = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement)),
                e =>
                {
                    Log.Comment("Ssetting Ignorable @{0} with value: {1}", e.Path(), unknownElement11.Prefix);
                    e.SetIgnorable(unknownElement11.Prefix);
                    e.AddNamespaceDeclaration(unknownAttribute11.Prefix, unknownAttribute11.NamespaceUri);

                    var pehost = e;
                    pehostPath = pehost.Path();

                    Log.Comment("Skipping setting PreserveElements@ {0} with value: {1}", pehost.Path(), unknownElement11.GetFullName());

                    Log.Comment("Setting PreserveAttributes@ {0} with value: {1}", pehost.Path(), unknownAttribute11.GetFullName());
                    pehost.SetPreserveAttributes(unknownAttribute11.GetFullName());
                },
                ref targetPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement)),
                e =>
                {
                    foreach (var d in e.ChildElements)
                        children.Add(d.CloneNode(true));
                    e.AppendChild(unknownElement11);
                    unknownElement11.SetAttribute(unknownAttribute11);
                    unknownElement11.SetAttribute(unknownAttribute12);
                    unknownElement11.SetAttribute(unprefixedAttribute);

                    expectedElement = unknownElement11.CloneNode(true);
                });

            Log.Comment("ReOpening file:{0}...", testfile.FullName);
            using (var package = testfile.OpenPackage(true, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.NoProcess))
            {
                OpenXmlElement host, target, pehost;
                locateElements(package, partUri, hostPath, out host, targetPath, out target);
                locateElements(package, partUri, hostPath, out host, pehostPath, out pehost);

                verifyMcAttribute(host, "Ignorable", unknownElement11.Prefix);
                verifyMcAttribute(pehost, "PreserveAttributes", unknownAttribute11.GetFullName());

                verifyUnknownElement(target.LastChild, expectedElement);
                verifyKnownChildren(target, children);
            }
        }

        [Fact]
        public void Preserve_NoElement_UnknownAttribute_O12Mode()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null, targetPath = null;
            List<OpenXmlElement> children = new List<OpenXmlElement>();
            OpenXmlElement expectedElement = null;
            string pehostPath = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement)),
                e =>
                {
                    Log.Comment("Setting Ignorable @{0} with value: {1}", e.Path(), unknownElement11.Prefix);
                    e.SetIgnorable(unknownElement11.Prefix);
                    e.AddNamespaceDeclaration(unknownAttribute11.Prefix, unknownAttribute11.NamespaceUri);

                    var pehost = e;
                    pehostPath = pehost.Path();

                    Log.Comment("Skipping setting PreserveElements@ {0} with value: {1}", pehost.Path(), unknownElement11.GetFullName());

                    Log.Comment("Setting PreserveAttributes@ {0} with value: {1}", pehost.Path(), unknownAttribute11.GetFullName());
                    pehost.SetPreserveAttributes(unknownAttribute11.GetFullName());
                },
                ref targetPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement)),
                e =>
                {
                    foreach (var d in e.ChildElements)
                        children.Add(d.CloneNode(true));
                    e.AppendChild(unknownElement11);
                    unknownElement11.SetAttribute(unknownAttribute11);
                    unknownElement11.SetAttribute(unknownAttribute12);
                    unknownElement11.SetAttribute(unprefixedAttribute);

                    expectedElement = unknownElement11.CloneNode(true);
                });

            Log.Comment("ReOpening file:{0}...", testfile.FullName);
            OpenXmlPackage package = null;
            try
            {
                package = testfile.OpenPackage(true, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.ProcessAllParts);
                OpenXmlElement host, target, pehost;
                locateElements(package, partUri, hostPath, out host, targetPath, out target);
                locateElements(package, partUri, hostPath, out host, pehostPath, out pehost);

                // This test case originally failed even if it runs with V2.0 RTM build - means the test script itself has a bug.
                // We decided to flip the result to re-use it as a backward compatibility test case.
                Log.Pass("[Known Issue in V2.0] No unexpected expected exception thrown out for Unknown attributes that's Ignored but not identified by PreserveElements.");
            }
            catch (Exception ex)
            {
                Log.Fail("[Known Issue in V2.0] Exception {0} thrown out with message:\n {1}.", ex.GetType().FullName, ex.ToString());
            }
            finally
            {
                if (package != null) package.Close();
            }
        }

        [Fact]
        public void Validate_Preserve_NoElement_UnknownAttribute()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null, targetPath = null;
            List<OpenXmlElement> children = new List<OpenXmlElement>();
            OpenXmlElement expectedElement = null;
            string pehostPath = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement)),
                e =>
                {
                    Log.Comment("Setting Ignorable @{0} with value: {1}", e.Path(), unknownElement11.Prefix);
                    e.SetIgnorable(unknownElement11.Prefix);
                    e.AddNamespaceDeclaration(unknownAttribute11.Prefix, unknownAttribute11.NamespaceUri);

                    var pehost = e;
                    pehostPath = pehost.Path();

                    Log.Comment("Skipping setting PreserveElements@ {0} with value: {1}", pehost.Path(), unknownElement11.GetFullName());

                    Log.Comment("Setting PreserveAttributes@ {0} with value: {1}", pehost.Path(), unknownAttribute11.GetFullName());
                    pehost.SetPreserveAttributes(unknownAttribute11.GetFullName());
                },
                ref targetPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement)),
                e =>
                {
                    foreach (var d in e.ChildElements)
                        children.Add(d.CloneNode(true));
                    e.AppendChild(unknownElement11);
                    unknownElement11.SetAttribute(unknownAttribute11);
                    unknownElement11.SetAttribute(unknownAttribute12);
                    unknownElement11.SetAttribute(unprefixedAttribute);

                    expectedElement = unknownElement11.CloneNode(true);
                });

            Log.Warning("Validating and Expecting MC validation error for PreserveAttributes...");
            validateMC(testfile, FileFormatVersions.Office2007, hostPath);
        }
        #endregion Preserve Elements & Attributes

        #region MustUnderstand

        [Fact]
        public void MustUnderstand_Ignored_UnknownElement_FullMode()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null, targetPath = null;
            List<OpenXmlElement> children = new List<OpenXmlElement>();
            OpenXmlElement expectedElement = null;
            string muhostPath = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren),
                e =>
                {
                    Log.Comment("Setting @Ignorable with value: {0} on {1}...", unknownElement11.Prefix, e.Path());
                    e.SetIgnorable(unknownElement11.Prefix);
                    e.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);
                },
                ref targetPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren),
                e =>
                {
                    wrapChildrenWithElement(e, unknownElement11, children);

                    var muhost = chooseElementBetween(e, hostPath, targetPath);
                    muhostPath = muhost.Path();
                    Log.Comment("Setting @MustUnderstand with value: {0} on {1}", unknownElement11.Prefix, muhostPath);
                    muhost.SetMustUnderstand(unknownElement11.Prefix);

                    expectedElement = unknownElement11.CloneNode(true);
                });

            Log.Comment("ReOpening file:{0}...", testfile.FullName);
            using (var package = testfile.OpenPackage(true, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.NoProcess))
            {
                OpenXmlElement host, target, muhost;
                locateElements(package, partUri, hostPath, out host, targetPath, out target);
                locateElements(package, partUri, hostPath, out host, muhostPath, out muhost);

                verifyMcAttribute(host, "Ignorable", expectedElement.Prefix);

                verifyMcAttribute(muhost, "MustUnderstand", expectedElement.Prefix);

                verifyUnknownElement(target.LastChild, expectedElement);
            }
        }

        [Fact]
        public void MustUnderstand_Ignored_UnknownElement_O12Mode()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null, targetPath = null;
            List<OpenXmlElement> children = new List<OpenXmlElement>();
            OpenXmlElement expectedElement = null;
            string muhostPath = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren),
                e =>
                {
                    Log.Comment("Setting @Ignorable with value: {0} on {1}...", unknownElement11.Prefix, e.Path());
                    e.SetIgnorable(unknownElement11.Prefix);
                    e.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);
                },
                ref targetPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren),
                e =>
                {
                    expectedElement = e.CloneNode(true);

                    wrapChildrenWithElement(e, unknownElement11, children);

                    var muhost = chooseElementBetween(e, hostPath, targetPath);
                    muhostPath = muhost.Path();
                    Log.Comment("Setting @MustUnderstand with value: {0} on {1}", unknownElement11.Prefix, muhostPath);
                    muhost.SetMustUnderstand(unknownElement11.Prefix);
                });

            Log.Comment("ReOpening file:{0}...", testfile.FullName);
            OpenXmlPackage package = null;
            try
            {
                using (package = testfile.OpenPackage(true, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.ProcessAllParts))
                {
                    OpenXmlElement host, target, muhost;
                    locateElements(package, partUri, hostPath, out host, targetPath, out target);
                    locateElements(package, partUri, hostPath, out host, muhostPath, out muhost);

                    // should come here or not?
                    Log.Fail("SHOULD NOT COME HERE. No expected exception caught.");
                    verifyUnknownElement(target.LastChild, expectedElement);
                }
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null && ex.InnerException is NamespaceNotUnderstandException)
                    Log.Pass("Exception {0} thrown out with message:\n {1}.", ex.GetType().FullName, ex.ToString());
                else
                    Log.Fail("Unexpected {0} thrown out with message:\n {1}", ex.GetType().FullName, ex.ToString());
            }
        }

        [Fact]
        public void Validate_MustUnderstand_Ignored_UnknownElement()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null, targetPath = null;
            List<OpenXmlElement> children = new List<OpenXmlElement>();
            OpenXmlElement expectedElement = null;
            string muhostPath = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren),
                e =>
                {
                    Log.Comment("Setting @Ignorable with value: {0} on {1}...", unknownElement11.Prefix, e.Path());
                    e.SetIgnorable(unknownElement11.Prefix);
                    e.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);
                },
                ref targetPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren),
                e =>
                {
                    expectedElement = e.CloneNode(true);

                    wrapChildrenWithElement(e, unknownElement11, children);

                    var muhost = chooseElementBetween(e, hostPath, targetPath);
                    muhostPath = muhost.Path();
                    Log.Comment("Setting @MustUnderstand with value: {0} on {1}", unknownElement11.Prefix, muhostPath);
                    muhost.SetMustUnderstand(unknownElement11.Prefix);
                });

            Log.Warning("Validating and Expecting validation error for MustUnderstand...");
            validateMC(testfile, FileFormatVersions.Office2007, hostPath);
        }

        [Fact]
        public void MustUnderstand_NonIgnored_UnknownElement_FullMode()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null, targetPath = null;
            List<OpenXmlElement> children = new List<OpenXmlElement>();
            OpenXmlElement expectedElement = null;
            string muhostPath = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren),
                e => {},
                ref targetPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren),
                e =>
                {
                    wrapChildrenWithElement(e, unknownElement11, children);

                    var muhost = chooseElementBetween(e, hostPath, targetPath);
                    muhostPath = muhost.Path();
                    Log.Comment("Setting @MustUnderstand with value: {0} on {1}", unknownElement11.Prefix, muhost.Path());
                    muhost.SetMustUnderstand(unknownElement11.Prefix);
                    muhost.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);

                    expectedElement = unknownElement11.CloneNode(true);
                });

            Log.Comment("ReOpening file:{0}...", testfile.FullName);
            using (var package = testfile.OpenPackage(true, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.NoProcess))
            {
                OpenXmlElement host, target, muhost;
                locateElements(package, partUri, hostPath, out host, targetPath, out target);
                locateElements(package, partUri, hostPath, out host, muhostPath, out muhost);

                verifyMcAttribute(muhost, "MustUnderstand", expectedElement.Prefix);

                verifyUnknownElement(target.LastChild, expectedElement);
            }
        }

        [Fact]
        public void MustUnderstand_NonIgnored_UnknownElement_O12Mode()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null, targetPath = null;
            List<OpenXmlElement> children = new List<OpenXmlElement>();
            OpenXmlElement expectedElement = null;
            string muhostPath = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren),
                e =>
                {
                },
                ref targetPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren),
                e =>
                {
                    expectedElement = e.CloneNode(true);

                    wrapChildrenWithElement(e, unknownElement11, children);

                    var muhost = chooseElementBetween(e, hostPath, targetPath);
                    muhostPath = muhost.Path();
                    Log.Comment("Setting @MustUnderstand with value: {0} on {1}", unknownElement11.Prefix, muhost.Path());
                    muhost.SetMustUnderstand(unknownElement11.Prefix);
                    muhost.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);
                });

            Log.Comment("ReOpening file:{0}...", testfile.FullName);
            OpenXmlPackage package = null;
            try
            {
                package = testfile.OpenPackage(true, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.ProcessAllParts);
                OpenXmlElement host, target, muhost;
                locateElements(package, partUri, hostPath, out host, targetPath, out target);
                locateElements(package, partUri, hostPath, out host, muhostPath, out muhost);

                Log.Fail("SHOULD NOT COME HERE. No expected exception caught.");
                verifyUnknownElement(target.LastChild, expectedElement);
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null && ex.InnerException is NamespaceNotUnderstandException)
                    Log.Pass("Exception {0} thrown out with message:\n {1}.", ex.GetType().FullName, ex.ToString());
                else
                    Log.Fail("Unexpected {0} thrown out with message:\n {1}", ex.GetType().FullName, ex.ToString());
            }
        }

        [Fact]
        public void Validate_MustUnderstand_NonIgnored_UnknownElement()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null, targetPath = null;
            List<OpenXmlElement> children = new List<OpenXmlElement>();
            OpenXmlElement expectedElement = null;
            string muhostPath = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren),
                e =>
                {
                },
                ref targetPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren),
                e =>
                {
                    expectedElement = e.CloneNode(true);

                    wrapChildrenWithElement(e, unknownElement11, children);

                    var muhost = chooseElementBetween(e, hostPath, targetPath);
                    muhostPath = muhost.Path();
                    Log.Comment("Setting @MustUnderstand with value: {0} on {1}", unknownElement11.Prefix, muhost.Path());
                    muhost.SetMustUnderstand(unknownElement11.Prefix);
                    muhost.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);
                });

            Log.Warning("Validating and Expecting validation error for MustUnderstand...");
            validateMC(testfile, FileFormatVersions.Office2007, hostPath);
        }
        #endregion MustUnderstand

        #region AlternateContent
        [Fact]
        public void NoChoice_NoFallback_FullMode()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null;
            List<OpenXmlElement> children = new List<OpenXmlElement>();
            AlternateContent expected = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && !d.ChildElements.Any(c => c is OpenXmlUnknownElement)),
                e => { expected = appendEmptyChildACB(e, children).CloneNode(true) as AlternateContent; });

            Log.Comment("ReOpening file:{0}...", testfile.FullName);
            using (var package = testfile.OpenPackage(true, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.NoProcess))
            {
                OpenXmlElement host;
                locateElements(package, partUri, hostPath, out host);

                Log.Comment("Verifying ACB is loaded as AlternateContentElement even no Choice element attached...");
                verifyKnownElement(host.LastChild, expected);

                Log.Comment("Verifying content of host element is kept as original...");
                verifyKnownChildren(host, children);
            }
        }

        [Fact]
        public void NoChoice_NoFallback_O12Mode()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null;
            List<OpenXmlElement> children = new List<OpenXmlElement>();
            AlternateContent expected = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && !d.ChildElements.Any(c => c is OpenXmlUnknownElement)),
                e => { expected = appendEmptyChildACB(e, children).CloneNode(true) as AlternateContent; });


            Log.Comment("ReOpening file:{0}...", testfile.FullName);
            OpenXmlPackage package = null;
            try
            {
                package = testfile.OpenPackage(true, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.ProcessAllParts);
                OpenXmlElement host;
                locateElements(package, partUri, hostPath, out host);

                Log.Comment("Verifying content of host element is kept as original...");
                verifyKnownChildren(host, children);
            }
            catch (Exception ex)
            {
                Log.Pass("Exception {0} thrown out with message.\n {1}", ex.GetType().FullName, ex.ToString());
            }

        }

        [Fact]
        public void Validate_NoChoice_NoFallback()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null;
            List<OpenXmlElement> children = new List<OpenXmlElement>();
            AlternateContent expected = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && !d.ChildElements.Any(c => c is OpenXmlUnknownElement)),
                e => { expected = appendEmptyChildACB(e, children).CloneNode(true) as AlternateContent; });

            Log.Warning("Validating and Expecting validation error for no choice/fallback...");
            validateMC(testfile, FileFormatVersions.Office2007);
        }

        [Fact]
        public void OneChoice_NoFallback_FullMode()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null;
            List<OpenXmlElement> children = new List<OpenXmlElement>();
            OpenXmlElement acb = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren),
                e => { acb = wrapWithChoice(e, children).CloneNode(true); });


            Log.Comment("ReOpening file:{0}...", testfile.FullName);
            using (var package = testfile.OpenPackage(true, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.NoProcess))
            {
                OpenXmlElement host;
                locateElements(package, partUri, hostPath, out host);

                Log.Comment("Verifying ACB is loaded as AlternateContentElement with a Choice element attached...");
                verifyKnownElement(host.LastChild, acb);

                Log.Comment("Verifying content of host element is kept as original...");
                verifyKnownChildren(host.LastChild.LastChild, children); // host.LastChild.LastChild == choice
            }
        }

        [Fact]
        public void OneChoice_NoFallback_O12Mode()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null;
            List<OpenXmlElement> children = new List<OpenXmlElement>();
            OpenXmlElement acb = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren),
                e => { acb = wrapWithChoice(e, children).CloneNode(true); });


            Log.Comment("ReOpening file:{0}...", testfile.FullName);
            using (var package = testfile.OpenPackage(true, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.ProcessAllParts))
            {
                OpenXmlElement host;
                locateElements(package, partUri, hostPath, out host);

                verifyKnownChildren(host, children);
            }
        }

        [Fact]
        public void Validate_OneChoice_NoFallback()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null;
            List<OpenXmlElement> children = new List<OpenXmlElement>();
            OpenXmlElement acb = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren),
                e => { acb = wrapWithChoice(e, children).CloneNode(true); });

            Log.Warning("Validating and Expecting NO validation error for one choice no fallback...");
            validateMC(testfile, FileFormatVersions.Office2007);
        }

        [Fact]
        public void MultipleChoice_NoMatches_NoFallback_FullMode()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null;
            List<OpenXmlElement> children = new List<OpenXmlElement>();
            OpenXmlElement acb = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && d.ChildElements.Count > 1),
                e => { acb = wrapEachChildWithUnselectableChoice_NoFallback(e, children).CloneNode(true); });


            Log.Comment("ReOpening file:{0}...", testfile.FullName);
            using (var package = testfile.OpenPackage(true, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.NoProcess))
            {
                OpenXmlElement host;
                locateElements(package, partUri, hostPath, out host);

                Log.Comment("Verifying ACB is loaded as AlternateContentElement with multiple Choice element attached...");
                verifyKnownElement(host.LastChild, acb);
            }
        }

        [Fact]
        public void MultipleChoice_NoMatches_NoFallback_O12Mode()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null;
            List<OpenXmlElement> children = new List<OpenXmlElement>();
            OpenXmlElement acb = null, expected = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && d.ChildElements.Count > 1),
                e =>
                {
                    acb = wrapEachChildWithUnselectableChoice_NoFallback(e, children).CloneNode(true);
                    expected = e.CloneNode(false);
                });


            Log.Comment("ReOpening file:{0}...", testfile.FullName);
            using (var package = testfile.OpenPackage(true, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.ProcessAllParts))
            {
                OpenXmlElement host;
                locateElements(package, partUri, hostPath, out host);

                verifyKnownElement(host, expected);
            }
        }

        [Fact]
        public void Validate_MultipleChoice_NoMatches_NoFallback()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null;
            List<OpenXmlElement> children = new List<OpenXmlElement>();
            OpenXmlElement acb = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && d.ChildElements.Count > 1),
                e => { acb = wrapEachChildWithUnselectableChoice_NoFallback(e, children).CloneNode(true); });

            Log.Warning("Validating and Expecting NO validation error for multiple unselectable choice no fallback...");
            validateMC(testfile, FileFormatVersions.Office2007);
        }


        [Fact]
        public void MultipleChoice_NoMatches_OneFallback_FullMode()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null;
            List<OpenXmlElement> children = new List<OpenXmlElement>();
            OpenXmlElement acb = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && d.ChildElements.Count > 1),
                e => { acb = wrapEachChildWithUnselectableChoice_OneFallback(e, children).CloneNode(true); });


            Log.Comment("ReOpening file:{0}...", testfile.FullName);
            using (var package = testfile.OpenPackage(true, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.NoProcess))
            {
                OpenXmlElement host;
                locateElements(package, partUri, hostPath, out host);

                Log.Comment("Verifying ACB is loaded as AlternateContentElement with multiple Choice element attached...");
                verifyKnownElement(host.LastChild, acb);
            }
        }

        [Fact]
        public void MultipleChoice_NoMatches_OneFallback_O12Mode()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null;
            List<OpenXmlElement> children = new List<OpenXmlElement>();
            OpenXmlElement acb = null, expected = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && d.ChildElements.Count > 1),
                e =>
                {
                    acb = wrapEachChildWithUnselectableChoice_OneFallback(e, children).CloneNode(true);
                    expected = e.CloneNode(false);
                });


            Log.Comment("ReOpening file:{0}...", testfile.FullName);
            using (var package = testfile.OpenPackage(true, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.ProcessAllParts))
            {
                OpenXmlElement host;
                locateElements(package, partUri, hostPath, out host);

                verifyKnownChildren(host, children);
            }
        }

        [Fact]
        public void Validate_MultipleChoice_NoMatches_OneFallback()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null;
            List<OpenXmlElement> children = new List<OpenXmlElement>();
            OpenXmlElement acb = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && d.ChildElements.Count > 1),
                e => { acb = wrapEachChildWithUnselectableChoice_OneFallback(e, children).CloneNode(true); });

            Log.Warning("Validating and Expecting NO validation error for multiple unselectable choice one fallback...");
            validateMC(testfile, FileFormatVersions.Office2007);
        }

        [Fact]
        public void MultipleChoice_OneFallback_FullMode()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null;
            List<OpenXmlElement> children = new List<OpenXmlElement>();
            OpenXmlElement acb = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren),
                e => { acb = wrapEachChildWithChoice_OneFallback(e, children).CloneNode(true); });

            Log.Comment("ReOpening file:{0}...", testfile.FullName);
            using (var package = testfile.OpenPackage(true, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.NoProcess))
            {
                OpenXmlElement host;
                locateElements(package, partUri, hostPath, out host);

                Log.Comment("Verifying ACB...");
                verifyKnownElement(host.LastChild, acb);
            }
        }

        [Fact]
        public void MultipleChoice_OneFallback_O12Mode()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null;
            List<OpenXmlElement> children = new List<OpenXmlElement>();
            OpenXmlElement acb = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren),
                e => { acb = wrapEachChildWithChoice_OneFallback(e, children).CloneNode(true); });

            Log.Comment("ReOpening file:{0}...", testfile.FullName);
            using (var package = testfile.OpenPackage(true, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.ProcessAllParts))
            {
                OpenXmlElement host;
                locateElements(package, partUri, hostPath, out host);

                Log.Comment("Verifying first choice is selected...");
                verifyKnownElement(host.FirstChild, children[0]);
            }
        }

        [Fact]
        public void Validate_MultipleChoice_OneFallback()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null;
            List<OpenXmlElement> children = new List<OpenXmlElement>();
            OpenXmlElement acb = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren),
                e => { acb = wrapEachChildWithChoice_OneFallback(e, children).CloneNode(true); });

            Log.Warning("Validating and Expecting NO validation error for multiple choice one fallback...");
            validateMC(testfile, FileFormatVersions.Office2007);
        }

        [Fact]
        public void MultipleChoice_LeadingFallback_FullMode()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null;
            List<OpenXmlElement> children = new List<OpenXmlElement>();
            OpenXmlElement acb = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d is DocumentFormat.OpenXml.Wordprocessing.Run && d.HasChildren && d.ChildElements.Count == 1),
                e => { acb = wrapEachChildWithChoice_LeadingFallback(e, children).CloneNode(true); });

            Log.Comment("ReOpening file:{0}...", testfile.FullName);
            using (var package = testfile.OpenPackage(true, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.NoProcess))
            {
                OpenXmlElement host;
                locateElements(package, partUri, hostPath, out host);

                Log.Comment("Verifying ACB...");
                verifyKnownElement(host.LastChild, acb);
            }
        }

        [Fact]
        public void MultipleChoice_LeadingFallback_O12Mode()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null;
            List<OpenXmlElement> children = new List<OpenXmlElement>();
            OpenXmlElement acb = null, expected = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d is DocumentFormat.OpenXml.Wordprocessing.Run && d.HasChildren && d.ChildElements.Count == 1),
                e =>
                {
                    expected = e.CloneNode(true);
                    acb = wrapEachChildWithChoice_LeadingFallback(e, children).CloneNode(true);
                });


            Log.Comment("ReOpening file:{0}...", testfile.FullName);
            OpenXmlPackage package = null;
            try
            {
                package = testfile.OpenPackage(true, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.ProcessAllParts);
                OpenXmlElement host;
                locateElements(package, partUri, hostPath, out host);

                // SDK always try to load content instead of throwing exception
                verifyKnownElement(host, expected);
                verifyKnownChildren(host, children);
            }
            catch (Exception ex)
            {
                Log.Pass("Exception {0} thrown out with message.\n {1}", ex.GetType().FullName, ex.ToString());
            }
        }

        [Fact]
        public void Validate_MultipleChoice_LeadingFallback()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null;
            List<OpenXmlElement> children = new List<OpenXmlElement>();
            OpenXmlElement acb = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d is DocumentFormat.OpenXml.Wordprocessing.Run && d.HasChildren && d.ChildElements.Count == 1),
                e => { acb = wrapEachChildWithChoice_LeadingFallback(e, children).CloneNode(true); });

            Log.Warning("Validating and Expecting validation error for leading fallback...");
            validateMC(testfile, FileFormatVersions.Office2007);
        }

        [Fact]
        public void OneChoice_MultipleFallback_FullMode()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null;
            List<OpenXmlElement> children = new List<OpenXmlElement>();
            OpenXmlElement acb = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && d.ChildElements.Count > 1),
                e => { acb = wrapEachChildWithFallback_OneChoice(e, children).CloneNode(true); });

            Log.Comment("ReOpening file:{0}...", testfile.FullName);
            using (var package = testfile.OpenPackage(true, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.NoProcess))
            {
                OpenXmlElement host;
                locateElements(package, partUri, hostPath, out host);

                Log.Comment("Verifying ACB...");
                verifyKnownElement(host.FirstChild, acb);
            }
        }

        [Fact]
        public void OneChoice_MultipleFallback_O12Mode()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null;
            List<OpenXmlElement> children = new List<OpenXmlElement>();
            OpenXmlElement acb = null, expected = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && d.ChildElements.Count > 1),
                e =>
                {
                    expected = e.CloneNode(true);
                    acb = wrapEachChildWithFallback_OneChoice(e, children).CloneNode(true);
                });

            Log.Comment("ReOpening file:{0}...", testfile.FullName);
            OpenXmlPackage package = null;
            try
            {
                package = testfile.OpenPackage(true, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.ProcessAllParts);
                OpenXmlElement host;
                locateElements(package, partUri, hostPath, out host);

                // SDK always try loading content instead of throwing exception
                verifyKnownElement(host, expected);
                verifyKnownChildren(host, children);
            }
            catch (Exception ex)
            {
                Log.Pass("Exception {0} thrown out with message.\n {1}", ex.GetType().FullName, ex.ToString());
            }
        }

        [Fact]
        public void Validate_OneChoice_MultipleFallback()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null;
            List<OpenXmlElement> children = new List<OpenXmlElement>();
            OpenXmlElement acb = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && d.ChildElements.Count > 1),
                e => { acb = wrapEachChildWithFallback_OneChoice(e, children).CloneNode(true); });

            Log.Warning("Validating and Expecting validation error for multiple fallback...");
            validateMC(testfile, FileFormatVersions.Office2007);
        }

        [Fact]
        public void MustUnderstand_Unselected_FullMode()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null;
            List<OpenXmlElement> children = new List<OpenXmlElement>();
            OpenXmlElement acb = null;
            string mupath = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && d.ChildElements.Count > 1),
                e =>
                {
                    acb = wrapEachChildWithChoice_NoFallback(e, children);
                    AlternateContentChoice firstChoice = acb.FirstOrDefault(c => c is AlternateContentChoice) as AlternateContentChoice;
                    firstChoice.Requires = string.Empty;
                    firstChoice.SetRequires(unknownElement11.Prefix);
                    firstChoice.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);
                    firstChoice.AppendChild(unknownElement11);
                    mupath = firstChoice.Path();
                    acb = acb.CloneNode(true);
                });


            Log.Comment("ReOpening file:{0}...", testfile.FullName);
            using (var package = testfile.OpenPackage(true, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.NoProcess))
            {
                OpenXmlElement host;
                locateElements(package, partUri, hostPath, out host);

                Log.Comment("Verifying ACB...");
                verifyKnownElement(host.LastChild, acb);
            }
        }

        [Fact]
        public void MustUnderstand_Unselected_O12Mode()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null;
            List<OpenXmlElement> children = new List<OpenXmlElement>();
            OpenXmlElement acb = null;
            string mupath = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && d.ChildElements.Count > 1),
                e =>
                {
                    acb = wrapEachChildWithChoice_NoFallback(e, children);
                    AlternateContentChoice firstChoice = acb.FirstOrDefault(c => c is AlternateContentChoice) as AlternateContentChoice;
                    firstChoice.Requires = string.Empty;
                    firstChoice.SetRequires(unknownElement11.Prefix);
                    firstChoice.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);
                    firstChoice.AppendChild(unknownElement11);
                    mupath = firstChoice.Path();
                    acb = acb.CloneNode(true);
                });

            Log.Comment("ReOpening file:{0}...", testfile.FullName);
            OpenXmlPackage package = null;
            try
            {
                package = testfile.OpenPackage(true, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.ProcessAllParts);
                OpenXmlElement host;
                locateElements(package, partUri, hostPath, out host);

                // The 1st choice should be trimmed when processing mc.
                Log.VerifyValue(host.ChildElements.Count, 1, "The child element count is expected 1.");

                Log.Comment("Verifying 2nd choice is selected as 1st choice requires {0}...", unknownElement11.Prefix);
                verifyKnownElement(host.FirstChild, children[1]);

                Log.Pass("The MustUnderstand in unselected Choice is ignored as expected.");
            }
            catch (Exception ex)
            {
                Log.Fail("Exception {0} thrown out with message.\n {1}", ex.GetType().FullName, ex.ToString());
            }
        }

        [Fact]
        public void Validate_MustUnderstand_Unselected()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null;
            List<OpenXmlElement> children = new List<OpenXmlElement>();
            OpenXmlElement acb = null;
            string mupath = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren),
                e =>
                {
                    acb = wrapEachChildWithChoice_NoFallback(e, children);
                    AlternateContentChoice firstChoice = acb.FirstOrDefault(c => c is AlternateContentChoice) as AlternateContentChoice;
                    firstChoice.Requires = string.Empty;
                    firstChoice.SetRequires(unknownElement11.Prefix);
                    firstChoice.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);
                    firstChoice.AppendChild(unknownElement11);
                    mupath = firstChoice.Path();
                    acb = acb.CloneNode(true);
                });

            Log.Warning("Validating and Expecting NO MC validation error for MustUnderstand...");
            validateMC(testfile, FileFormatVersions.Office2007, hostPath);
        }

        [Fact]
        public void MultipleChoice_OneFallback_Ignorable_FullMode()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null;
            List<OpenXmlElement> children = new List<OpenXmlElement>();
            OpenXmlElement acb = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren),
                e =>
                {
                    acb = wrapEachChildWithChoice_OneFallback(e, children);
                    Log.Comment("Setting mc:Ignorable = {0} @{1}...", unknownElement11.Prefix, acb.Path());
                    acb.SetIgnorable(unknownElement11.Prefix);
                    acb.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);
                    acb.SetAttribute(unknownAttribute11);
                    acb.AppendChild(unknownElement11);
                    acb = acb.CloneNode(true);
                });

            Log.Comment("ReOpening file:{0}...", testfile.FullName);
            using (var package = testfile.OpenPackage(true, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.NoProcess))
            {
                OpenXmlElement host;
                locateElements(package, partUri, hostPath, out host);

                Log.Comment("Verifying ACB...");
                verifyKnownElement(host.LastChild, acb);
            }
        }

        [Fact]
        public void MultipleChoice_OneFallback_Ignorable_O12Mode()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null;
            List<OpenXmlElement> children = new List<OpenXmlElement>();
            OpenXmlElement acb = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren),
                e =>
                {
                    acb = wrapEachChildWithChoice_OneFallback(e, children);
                    Log.Comment("Setting mc:Ignorable = {0} @{1}...", unknownElement11.Prefix, acb.Path());
                    acb.SetIgnorable(unknownElement11.Prefix);
                    acb.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);
                    acb = acb.CloneNode(true);
                    acb.SetAttribute(unknownAttribute11);
                    acb.AppendChild(unknownElement11);
                });

            Log.Comment("ReOpening file:{0}...", testfile.FullName);
            using (var package = testfile.OpenPackage(true, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.ProcessAllParts))
            {
                OpenXmlElement host;
                locateElements(package, partUri, hostPath, out host);

                Log.Comment("Verifying first choice is selected...");
                verifyKnownElement(host.FirstChild, children[0]);
            }
        }

        [Fact]
        public void Validate_MultipleChoice_OneFallback_Ignorable()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null;
            List<OpenXmlElement> children = new List<OpenXmlElement>();
            OpenXmlElement acb = null;
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren),
                e =>
                {
                    acb = wrapEachChildWithChoice_OneFallback(e, children);
                    Log.Comment("Setting mc:Ignorable = {0} @{1}...", unknownElement11.Prefix, acb.Path());
                    acb.SetIgnorable(unknownElement11.Prefix);
                    acb.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);
                    acb.SetAttribute(unknownAttribute11);
                    acb.AppendChild(unknownElement11);
                    acb = acb.CloneNode(true);
                });

            Log.Warning("Validating and Expecting NO validation error for ignored unknown element/attribute...");
            validateMC(testfile, FileFormatVersions.Office2007);
        }

        [Fact]
        public void MultipleChoice_OneFallback_UnPrefixedMCAttributes_FullMode()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null;
            List<OpenXmlElement> children = new List<OpenXmlElement>();
            OpenXmlElement acb = null;
            var unPrefixedIgnorable = new OpenXmlAttribute("", "Ignorable", "", unknownElement11.Prefix);
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren),
                e =>
                {
                    acb = wrapEachChildWithChoice_OneFallback(e, children);
                    Log.Comment("Setting Ignorable = {0} @{1}...", unknownElement11.Prefix, acb.Path());
                    acb.SetAttribute(unPrefixedIgnorable);
                    acb.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);
                    acb.SetAttribute(unknownAttribute11);
                    acb.AppendChild(unknownElement11);
                    acb = acb.CloneNode(true);
                });

            Log.Comment("ReOpening file:{0}...", testfile.FullName);
            using (var package = testfile.OpenPackage(true, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.NoProcess))
            {
                OpenXmlElement host;
                locateElements(package, partUri, hostPath, out host);

                Log.Comment("Verifying ACB...");
                verifyKnownElement(host.LastChild, acb);
            }
        }

        [Fact]
        public void MultipleChoice_OneFallback_UnPrefixedMCAttributes_O12Mode()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null;
            List<OpenXmlElement> children = new List<OpenXmlElement>();
            OpenXmlElement acb = null;
            var unPrefixedIgnorable = new OpenXmlAttribute("", "Ignorable", "", unknownElement11.Prefix);
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren),
                e =>
                {
                    acb = wrapEachChildWithChoice_OneFallback(e, children);
                    acb = acb.CloneNode(true);
                    Log.Comment("Setting Ignorable = {0} @{1}...", unknownElement11.Prefix, acb.Path());
                    acb.SetAttribute(unPrefixedIgnorable);
                    acb.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);
                    acb.SetAttribute(unknownAttribute11);
                    acb.AppendChild(unknownElement11);
                });

            Log.Comment("ReOpening file:{0}...", testfile.FullName);
            using (var package = testfile.OpenPackage(true, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.ProcessAllParts))
            {
                OpenXmlElement host;
                locateElements(package, partUri, hostPath, out host);

                Log.Comment("Verifying first choice is selected...");
                verifyKnownElement(host.FirstChild, children[0]);
            }
        }

        [Fact]
        public void Validate_MultipleChoice_OneFallback_UnPrefixedMCAttributes()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault();

            string partUri = null, hostPath = null;
            List<OpenXmlElement> children = new List<OpenXmlElement>();
            OpenXmlElement acb = null;
            var unPrefixedIgnorable = new OpenXmlAttribute("", "Ignorable", "", unknownElement11.Prefix);
            setupElements(testfile,
                ref partUri, pkg => pkg.MainPart(),
                ref hostPath, e => e.Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren),
                e =>
                {
                    acb = wrapEachChildWithChoice_OneFallback(e, children);
                    Log.Comment("Setting Ignorable = {0} @{1}...", unknownElement11.Prefix, acb.Path());
                    acb.SetAttribute(unPrefixedIgnorable);
                    acb.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);
                    acb.SetAttribute(unknownAttribute11);
                    acb.AppendChild(unknownElement11);
                    acb = acb.CloneNode(true);
                });

            Log.Warning("Validating and Expecting validation error for unprefixed Ignorable attribute...");
            validateMC(testfile, FileFormatVersions.Office2007);
        }

        private AlternateContent appendEmptyChildACB(OpenXmlElement e, List<OpenXmlElement> children)
        {
            foreach (var c in e.ChildElements)
                children.Add(c.CloneNode(true));

            Log.Comment("Appending AlaternateContent element without choice and fallback...");
            var acb = new AlternateContent();
            return e.AppendChild(acb);
        }

        private AlternateContent wrapWithChoice(OpenXmlElement e, List<OpenXmlElement> children)
        {
            Log.Comment("Appending child elements to Choice...");
            var choice = new AlternateContentChoice();
            foreach (var prefix in e.ChildElements.Select(c => c.Prefix).Distinct())
                choice.SetRequires(prefix);
            foreach (var c in e.ChildElements)
            {
                children.Add(c.CloneNode(true));
                choice.AppendChild(c.CloneNode(true));
            }
            e.RemoveAllChildren();

            Log.Comment("Appending a choice to AlaternateContent element...");
            var acb = new AlternateContent();
            acb.AppendChild(choice);
            return e.AppendChild(acb);
        }

        private AlternateContent wrapEachChildWithChoice_NoFallback(OpenXmlElement e, List<OpenXmlElement> children)
        {
            var acb = new AlternateContent();
            foreach (var c in e.ChildElements)
            {
                children.Add(c.CloneNode(true));

                Log.Comment("Appending a choice to Alternate Content element...");
                var choice = new AlternateContentChoice();
                var prefix = c.Prefix;
                choice.SetRequires(prefix);
                choice.AppendChild(c.CloneNode(true));
                acb.AppendChild(choice);
            }
            e.RemoveAllChildren();
            return e.AppendChild(acb);
        }

        private AlternateContent wrapEachChildWithUnselectableChoice_NoFallback(OpenXmlElement e, List<OpenXmlElement> children)
        {
            var acb = new AlternateContent();
            foreach (var c in e.ChildElements)
            {
                children.Add(c.CloneNode(true));

                Log.Comment("Appending a choice to Alternate Content element...");
                var choice = new AlternateContentChoice();
                var prefix = c.Prefix;
                choice.SetRequires(prefix);
                choice.AppendChild(c.CloneNode(true));
                choice.SetRequires(unknownElement11.Prefix);    // set unknown prefix to make it unselectable
                acb.AppendChild(choice);
            }
            e.RemoveAllChildren();
            e.SetAttribute(unknownAttribute11);    // append unknown element/attribute to make its ns resolvable
            return e.AppendChild(acb);
        }

        private AlternateContent wrapEachChildWithChoice_OneFallback(OpenXmlElement e, List<OpenXmlElement> children)
        {
            var acb = new AlternateContent();
            var fallback = new AlternateContentFallback();
            foreach (var c in e.ChildElements)
            {
                children.Add(c.CloneNode(true));

                Log.Comment("Appending a choice to Alternate Content element...");
                var choice = new AlternateContentChoice();
                var prefix = c.Prefix;
                choice.SetRequires(prefix);
                choice.AppendChild(c.CloneNode(true));
                acb.AppendChild(choice);

                Log.Comment("Appending same child element as Choice to Fallback...");
                fallback.AppendChild(c.CloneNode(true));
            }
            Log.Comment("Appending fallback to Alternate Content element...");
            acb.AppendChild(fallback);
            e.RemoveAllChildren();
            return e.AppendChild(acb);
        }

        private AlternateContent wrapEachChildWithUnselectableChoice_OneFallback(OpenXmlElement e, List<OpenXmlElement> children)
        {
            var acb = new AlternateContent();
            var fallback = new AlternateContentFallback();
            foreach (var c in e.ChildElements)
            {
                children.Add(c.CloneNode(true));

                Log.Comment("Appending a choice to Alternate Content element...");
                var choice = new AlternateContentChoice();
                var prefix = c.Prefix;
                choice.SetRequires(prefix);
                choice.SetRequires(unknownElement11.Prefix);    // set unknown prefix to make it unselectable
                choice.AppendChild(c.CloneNode(true));
                acb.AppendChild(choice);

                Log.Comment("Appending same child element as Choice to Fallback...");
                fallback.AppendChild(c.CloneNode(true));
            }
            Log.Comment("Appending fallback to Alternate Content element...");
            acb.AppendChild(fallback);
            e.RemoveAllChildren();
            e.SetAttribute(unknownAttribute11);    // append unknown element/attribute to make its ns resolvable
            return e.AppendChild(acb);
        }
        private AlternateContent wrapEachChildWithChoice_LeadingFallback(OpenXmlElement e, List<OpenXmlElement> children)
        {
            var acb = new AlternateContent();
            Log.Comment("Appending fallback to Alternate Content element...");
            var fallback = new AlternateContentFallback();
            acb.AppendChild(fallback);
            foreach (var c in e.ChildElements)
            {
                children.Add(c.CloneNode(true));

                Log.Comment("Appending a choice to Alternate Content element...");
                var choice = new AlternateContentChoice();
                var prefix = c.Prefix;
                choice.SetRequires(prefix);
                choice.AppendChild(c.CloneNode(true));
                acb.AppendChild(choice);

                Log.Comment("Appending same child element as Choice to Fallback...");
                fallback.AppendChild(c.CloneNode(true));
            }
            e.RemoveAllChildren();
            return e.AppendChild(acb);
        }

        private AlternateContent wrapEachChildWithFallback_OneChoice(OpenXmlElement e, List<OpenXmlElement> children)
        {
            var acb = new AlternateContent();
            var choice = new AlternateContentChoice();
            foreach (var prefix in e.ChildElements.Concat(new OpenXmlElement[] { e }).Where(d => !(d is OpenXmlUnknownElement || d is OpenXmlMiscNode)).Select(d => d.Prefix).Distinct())
                choice.SetRequires(prefix);
            Log.Comment("Appending choice element to AlaternateContent element...");
            acb.AppendChild(choice);
            Log.Comment("Current element has {0} child elements.", e.ChildElements.Count);
            foreach (var c in e.ChildElements)
            {
                children.Add(c.CloneNode(true));

                choice.AppendChild(c.CloneNode(true));

                Log.Comment("Appending child element to Fallback element...");
                var fallback = new AlternateContentFallback();
                fallback.AppendChild(c.CloneNode(true));
                Log.Comment("Appending Fallback element to AlternateContent element...");
                acb.AppendChild(fallback);
            }
            e.RemoveAllChildren();
            return e.AppendChild(acb);
        }

        #endregion AlternateContent

        #region Helpers

        private void setupElements(System.IO.FileInfo testfile, ref string partUri, GetTargetPart getPart,
            ref string hostPath, GetTargetElement getHost, actionOnElement actOnHost)
        {
            Log.Comment("Opening file:{0}...", testfile.FullName);
            using (var package = testfile.OpenPackage(true, true))
            {
                var part = getPart(package);
                partUri = part.Uri.ToString();
                Log.Comment("Loading part:{0}...", partUri);
                var dom = part.RootElement();

                var host = getHost(dom);
                if (host == null)
                {
                    host = dom;
                    Log.Warning("NO required host element found. Reset to root element...");
                }
                hostPath = host.Path();
                Log.Comment("Host Element: {0}", hostPath);

                Log.Comment("Executing specified action on target element...");
                actOnHost(host);

                Log.Comment("Closing package...");
            }
        }

        private void setupElements(System.IO.FileInfo testfile, ref string partUri, GetTargetPart getPart,
            ref string hostPath, GetTargetElement getHost, actionOnElement actOnHost,
            ref string targetPath, GetTargetElement getTarget, actionOnElement actOnTarget)
        {
            Log.Comment("Opening file:{0}...", testfile.FullName);
            using (var package = testfile.OpenPackage(true, true))
            {
                var part = getPart(package);
                partUri = part.Uri.ToString();
                Log.Comment("Loading part:{0}...", partUri);
                var dom = part.RootElement();

                var host = getHost(dom);
                if (host == null)
                {
                    host = dom;
                    Log.Warning("NO required host element found. Reset to root element...");
                }
                hostPath = host.Path();
                Log.Comment("Host Element: {0}", hostPath);

                var target = getTarget(host);
                if (target == null)
                {
                    target = host;
                    Log.Warning("NO required target element found. Reset to host element...");
                }
                targetPath = target.Path();
                Log.Comment("Target Element:{0}", targetPath);

                if (host == target)
                    Log.Warning("Host and Target element are SAME.");

                Log.Comment("Executing specified action on host element...");
                actOnTarget(target);

                Log.Comment("Executing specified action on target element...");
                actOnHost(host);

                Log.Comment("Closing package...");
            }
        }

        private void locateElements(OpenXmlPackage package, string partUri,
            string hostPath, out OpenXmlElement host)
        {
            Log.Comment("Looking for part:{0}...", partUri);
            var part = package.DescendantParts().Where(p => p.Uri.ToString() == partUri).FirstOrDefault();
            if (part == null)
                Log.Warning("NO required part found.");
            Log.Comment("Loading part:{0}...", partUri);
            var dom = part.RootElement();
            Log.Comment("Looking for host element:{0}...", hostPath);
            host = dom.Descendants().Where(d => d.Path() == hostPath).FirstOrDefault();
            host = host == null ? dom : host;
            if (host == null)
                Log.Warning("NO required host element found.");
        }

        private void locateElements(OpenXmlPackage package, string partUri,
            string hostPath, out OpenXmlElement host,
            string targetPath, out OpenXmlElement target)
        {
            Log.Comment("Looking for part:{0}...", partUri);
            var part = package.DescendantParts().Where(p => p.Uri.ToString() == partUri).FirstOrDefault();
            if (part == null)
                Log.Warning("NO required part found.");
            Log.Comment("Loading part:{0}...", partUri);
            var dom = part.RootElement();
            Log.Comment("Looking for host element:{0}...", hostPath);
            host = dom.Descendants().Union(new OpenXmlElement[] { dom }).Where(d => d.Path() == hostPath).FirstOrDefault();
            host = host == null ? dom : host;
            if (host == null)
                Log.Warning("NO required host element found.");
            Log.Comment("Looking for target element:{0}...", targetPath);
            target = host.Descendants().Union(new OpenXmlElement[] { host }).Where(d => d.Path() == targetPath).FirstOrDefault();
            target = target == null ? host : target;
            if (target == null)
                Log.Warning("NO required target elemen found.");
        }

        private OpenXmlElement chooseElementBetween(OpenXmlElement target, string startPath, string endPath)
        {
            OpenXmlElement pchost = null;
            if (startPath == endPath)
                pchost = target;
            else
                pchost = target.Ancestors().TakeWhile(a => a.Path().StartsWith(startPath)).Union(new OpenXmlElement[] { target }).PickSecond();
            return pchost;
        }

        private void moveAttributesTo(OpenXmlElement host, OpenXmlElement dest)
        {
            Log.Comment("Moving attributes from {0} to {1}...", host.Path(), dest.Path());
            foreach (var a in host.GetAttributes())
            {
                dest.SetAttribute(a);
            }
        }

        private void wrapChildrenWithElement(OpenXmlElement host, OpenXmlElement wrapper, List<OpenXmlElement> children)
        {
            Log.Comment("Moving child elements from {0} to {1}...", host.Path(), wrapper.Path());
            foreach (var d in host.ChildElements)
            {
                wrapper.AppendChild(d.CloneNode(true));
                children.Add(d.CloneNode(true));
            }
            host.RemoveAllChildren();
            host.AppendChild(wrapper);
        }

        private void validateMC(FileInfo testfile, FileFormatVersions fileformat)
        {
            var validator = new OpenXmlValidator(fileformat);
            IEnumerable<ValidationErrorInfo> errors = null;
            bool unknownErrorDetected = false;

            try
            {
                Log.Comment("Opening Package {0}...", testfile.FullName);
                var package = testfile.OpenPackage(false);
                Log.Comment("Validating file:{0}...", testfile.FullName);
                errors = validator.Validate(package).Where(e => e.ErrorType == ValidationErrorType.MarkupCompatibility);
            }
            catch (Exception ex)
            {
                if (OpenXmlDomTaskLibrary.IsKnownIssue(TestDataStorage.RootFolder, testfile.FullName, ex.Message) == false)
                {
                    Log.Warning("Exception {0} thrown out when validating...", ex.GetType().FullName);
                    Log.Fail(ex.ToString());
                    unknownErrorDetected = true;
                }
                else
                {
                    Log.Warning("[Known] Exception {0} thrown out when validating... {1}", ex.GetType().FullName, ex.ToString());
                }
            }
            
            if (errors != null && errors.FirstOrDefault() != null)
            {
                foreach (var error in errors)
                {
                    if (OpenXmlDomTaskLibrary.IsKnownIssue(TestDataStorage.RootFolder, testfile.FullName, error.Description) == false)
                    {
                        // Disabled OuterXML output since there are too many errors cause Out of Memory exception
                        Log.Error("Error Message: {0}", error.GetErrorString(false));
                        unknownErrorDetected = true;
                    }
                    else
                    {
                        Log.Warning("[Known] Error Message: {0}", error.GetErrorString(false));
                    }
                }
            }
            if (unknownErrorDetected == true)
            {
                Log.Fail("MC validation error found.");
            }
            else
            {
                Log.Pass("No MC validation error found.");
            }
        }

        private void validateMC(FileInfo testfile, FileFormatVersions fileformat, string path)
        {
            var validator = new OpenXmlValidator(fileformat);
            IEnumerable<ValidationErrorInfo> errors = null;
            try
            {
                Log.Comment("Opening Package {0}...", testfile.FullName);
                var package = testfile.OpenPackage(false);
                Log.Comment("Validating file:{0}...", testfile.FullName);
                errors = validator.Validate(package)
                    .Where(e => e.ErrorType == ValidationErrorType.MarkupCompatibility
                        || (e.ErrorType == ValidationErrorType.Schema && e.Node.Path().StartsWith(path)));
            }
            catch (Exception ex)
            {
                Log.Warning("Exception {0} thrown out when validating...", ex.GetType().FullName);
                Log.Fail(ex.ToString());
            }
            
            bool unknownErrorDetected = false;
            if (errors != null && errors.FirstOrDefault() != null)
            {
                foreach (var error in errors)
                {
                    Log.Warning("Error Message: {0}", error.GetErrorString(true)); /*include OuterXml*/
                    if (OpenXmlDomTaskLibrary.IsKnownIssue(TestDataStorage.RootFolder, testfile.FullName, error.Description) == false)
                    {
                        unknownErrorDetected = true;
                    }
                }
            }
            if (unknownErrorDetected == true)
            {
                Log.Fail("MC validation error found.");
            }
            else
            {
                Log.Pass("No MC validation error found.");
            }
        }
        #endregion Helpers

        #region Verify Methods

        private void verifyMcAttribute(OpenXmlElement host, string mcName, string expectedValue)
        {
            Log.Comment("Verifying {0} attribute is set correctly.", mcName);
            var hasAttribute = host.GetAttributes().Where(a => a.LocalName == mcName && a.Value == expectedValue).FirstOrDefault() != default(OpenXmlAttribute);
            if (hasAttribute)
                Log.Pass("{0} is set correctly.", mcName);
            else
                Log.Fail("{0} does NOT exist or is set wrong value.", mcName);
        }

        private void verifyNoMcAttribute(OpenXmlElement host, string mcName, string expectedValue)
        {
            Log.Comment("Verifing {0} attribute is filtered out...", mcName);
            var hasAttribute = host.GetAttributes().Where(a => a.LocalName == "Ignorable" && a.Value == expectedValue).FirstOrDefault() != default(OpenXmlAttribute);
            if (hasAttribute)
                Log.Fail("{0} attribute still exist on host element:{1}", mcName, host.Path());
            else
                Log.Pass("{0} attribute does NOT exist on host element:{1}", mcName, host.Path());
        }

        private void verifyAttribute(OpenXmlElement host, OpenXmlAttribute expectedAttribute)
        {
            Log.Comment("Verifying attribute {0} is preserved as expected...", expectedAttribute.GetFullName());
            var verified = host.GetAttributes().
                Where(a => a.Prefix == expectedAttribute.Prefix && a.LocalName == expectedAttribute.LocalName && a.Value == expectedAttribute.Value)
                .FirstOrDefault() != default(OpenXmlAttribute);
            if (verified)
                Log.Pass("Verified attribute {0} exist with value {1}.", expectedAttribute.GetFullName(), expectedAttribute.Value);
            else
                Log.Fail("Verified Attribute {0} NOT exist with value {1}.", expectedAttribute.GetFullName(), expectedAttribute.Value);
        }

        private void verifyNoAttribute(OpenXmlElement host, OpenXmlAttribute expectedAttribute)
        {
            Log.Comment("Verifying attribute {0} does NOT exist....", expectedAttribute.GetFullName());
            var exist = host.GetAttributes().Any(a => a == expectedAttribute);
            if (exist)
                Log.Fail("Verifyied attribute {0} exist with value {1}.", expectedAttribute.GetFullName(), expectedAttribute.Value);
            else
                Log.Pass("Verified attribute {0} NOT exist with value {1}.", expectedAttribute.GetFullName(), expectedAttribute.Value);
        }

        private void verifyExtendedAttribute(OpenXmlElement host, OpenXmlAttribute expectedAttribute)
        {
            Log.Comment("Verifying unknown attribute is loaded as extended...");
            if (host.ExtendedAttributes.Any(ea => ea == expectedAttribute))
                Log.Pass("Verified attribute {0} from unkown ns is loaded as Extended attribute.", expectedAttribute.GetFullName());
            else
                Log.Fail("Attribute {0} from unknown ns is NOT loaded as Extended attribute.", expectedAttribute.GetFullName());
        }

        private void verifyNoExtendedAttribute(OpenXmlElement host, OpenXmlAttribute expectedAttribute)
        {
            Log.Comment("Verifying unknown attribute is ignored...");
            var verified = !host.ExtendedAttributes.Any(ea => ea == expectedAttribute);
            if (verified)
                Log.Pass("Attribute {0} from unknown ns is NOT loaded as Extended attribute.", expectedAttribute.GetFullName());
            else
                Log.Fail("Attribute {0} from unkown ns is loaded as Extended attribute.", expectedAttribute.GetFullName());
        }

        private void verifyKnownAttribute(OpenXmlElement host, OpenXmlAttribute expectedAttribute)
        {
            Log.Comment("Verifying known attribute is loaded as built-in attribute...");
            var verified = (host.GetAttributes().First() == expectedAttribute) && (host.ExtendedAttributes.All(ea => ea != expectedAttribute));
            if (verified)
                Log.Pass("Verified attribute {0} from kown ns is loaded as built-in attribute.", expectedAttribute.GetFullName());
            else
                Log.Fail("Attribute {0} from known ns is NOT loaded as built-in attribute.", expectedAttribute.GetFullName());
        }

        private void verifyAttributes(OpenXmlElement host, OpenXmlElement expectedElement)
        {
            Log.Comment("Verifying attributes of element {0}...", host.Path());
            foreach (var a in expectedElement.GetAttributes())
            {
                if (host.GetAttributes().Any(at => at == a))
                    Log.Pass("Expected attribute {0} with value {1} exist.", a.GetFullName(), a.Value);
                else
                    Log.Fail("NO expected attribute {0} with value {1} exist.", a.GetFullName(), a.Value);
            }
        }

        private void verifyUnknownElement(OpenXmlElement host, OpenXmlElement expectedElement)
        {
            Log.Comment("Verifying unknown element is loaded as OpenXmlUnkownElement...");
            var verified = (host is OpenXmlUnknownElement) && (host.ToXElement().Compare(expectedElement.ToXElement()));
            if (verified)
                Log.Pass("Verified element {0} from unkown ns is loaded as OpenXmlUnknownElement.", expectedElement.GetFullName());
            else
                Log.Fail("Element {0} from unknown ns is NOT loaded as OpenXmlUnknownElement.", expectedElement.GetFullName());
        }

        private void verifyNoUnknownElement(OpenXmlElement host, OpenXmlElement expectedElement)
        {
            Log.Comment("Verifying unknown element is ignored...");
            var unknown = (host is OpenXmlUnknownElement) && (host.ToXElement().Compare(expectedElement.ToXElement()));
            if (unknown)
                Log.Fail("Element {0} from unkown ns is loaded as OpenXmlUnknownElement.", expectedElement.GetFullName());
            else
                Log.Pass("Element {0} from unknown ns is NOT loaded as OpenXmlUnknownElement.", expectedElement.GetFullName());
        }

        private void verifyKnownElement(OpenXmlElement host, OpenXmlElement expectedElement)
        {
            Log.Comment("Verifying known element is loaded as strongly typed...");
            var known = !(host is OpenXmlUnknownElement) && host.ToXElement().Compare(expectedElement.ToXElement());
            if (known)
                Log.Pass("Verified element {0} from kown ns is loaded as strongly typed {1}.", expectedElement.GetFullName(), host.GetType().FullName);
            else
                Log.Fail("Element {0} from known ns is NOT loaded as strongly typed.", expectedElement.GetFullName());
        }

        private void verifyUnknownChildren(OpenXmlElement host, List<OpenXmlElement> children)
        {
            if (host is OpenXmlUnknownElement)
                Log.Warning("Host element {0} IS OpenXmlUnknownElement.", host.GetFullName());

            Log.Comment("Verifying content of unknown element is loaded as OpenXmlUnkownElement...");
            for (int i = 0; i < children.Count; i++)
                if (!(host.ChildElements[i] is OpenXmlUnknownElement) || !(host.ChildElements[i].ToXElement().Compare(children[i].ToXElement())))
                    Log.Fail("Element {0} under unknown element is NOT loaded as OpenXmlUnknownElement.", host.ChildElements[i].GetFullName());
                else
                    Log.Pass("Verified element {0} under unkown element is loaded as OpenXmlUnknownElement.", host.ChildElements[i].GetFullName());
        }

        private void verifyKnownChildren(OpenXmlElement parent, List<OpenXmlElement> children)
        {
            Log.Comment("Verifying each child element is loaded as strongly typed element...");
            for (int i = 0; i < children.Count; i++)
                if (!(parent.ChildElements[i] is OpenXmlUnknownElement) && parent.ChildElements[i].ToXElement().Compare(children[i].ToXElement()))
                    Log.Pass("Verified child element {0} is loaded as {1}.", parent.ChildElements[i].GetFullName(), parent.ChildElements[i].GetType().FullName);
                else
                    Log.Fail("Child elements {0} is NOT loaded as strongly typed or changed.", parent.ChildElements[i].GetFullName());
        }

        private void verifyNoUnkownChild(OpenXmlElement host, string qualified)
        {
            Log.Comment("Verifying NO unknown child element exist...");
            var hasUnknown = host.ChildElements.Any(c => (c is OpenXmlUnknownElement) && (c.GetFullName() == qualified));
            if (!hasUnknown)
                Log.Pass("Verified NO element {0} from unkown ns exist.", qualified);
            else
                Log.Fail("Element {0} from unknown ns is loaded as OpenXmlUnknownElement.", qualified);
        }

        #endregion Verify Methods
    }
}