// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using Xunit;
using Xunit.Abstractions;

using static DocumentFormat.OpenXml.Tests.TestAssets;

namespace DocumentFormat.OpenXml.Tests
{
    /// <summary>
    /// Summary description for MarkupCompatibilityTest
    /// </summary>
    public class MarkupCompatibilityTest : OpenXmlDomTestBase
    {
        public MarkupCompatibilityTest(ITestOutputHelper output)
            : base(output)
        {
        }

        #region Private Fields
        internal static string xmlNS = "http://www.w3.org/XML/1998/namespace";
        private OpenXmlAttribute xmlSpace = new OpenXmlAttribute("xml", "space", xmlNS, "default"); // two valid value: default, preserve
        private OpenXmlAttribute xmlLang = new OpenXmlAttribute("xml", "lang", xmlNS, "en-US");

        internal static string nsUnknown1 = "http://test.openxmlsdk.microsoft.com/unknownns1";
        internal static string prefixUnknown1 = "uns1";
        internal static string a1Unknown1 = "a1uk1";
        internal static string a2Unknown1 = "a2uk1";
        private OpenXmlAttribute unknownAttribute11 = new OpenXmlAttribute(prefixUnknown1, a1Unknown1, nsUnknown1, "attribute1 from unknown namespace1.");
        private OpenXmlAttribute unknownAttribute12 = new OpenXmlAttribute(prefixUnknown1, a2Unknown1, nsUnknown1, "attribute2 from unknown namespace1.");
        internal static string e1Unknown1 = "e1uk1";
        internal static string e2Unknown1 = "e2uk1";
        private OpenXmlElement unknownElement11 = new OpenXmlUnknownElement(prefixUnknown1, e1Unknown1, nsUnknown1);
        private OpenXmlElement unknownElement12 = new OpenXmlUnknownElement(prefixUnknown1, e2Unknown1, nsUnknown1);

        internal static string nsUnknown2 = "http://test.openxmlsdk.microsoft.com/unknownns2";
        internal static string prefixUnknown2 = "uns2";
        internal static string a1Unknown2 = "a1uk2";
        internal static string a2Unknown2 = "a2uk2";
        private OpenXmlAttribute unknownAttribute21 = new OpenXmlAttribute(prefixUnknown2, a1Unknown2, nsUnknown2, "attribute1 from unknown namespace2.");
        private OpenXmlAttribute unknownAttribute22 = new OpenXmlAttribute(prefixUnknown2, a2Unknown2, nsUnknown2, "attribute2 from unknown namespace2.");
        internal static string e1Unknown2 = "e1uk2";
        internal static string e2Unknown2 = "e2uk2";
        private OpenXmlElement unknownElement21 = new OpenXmlUnknownElement(prefixUnknown2, e1Unknown2, nsUnknown2);
        private OpenXmlElement unknownElement22 = new OpenXmlUnknownElement(prefixUnknown2, e2Unknown2, nsUnknown2);

        private OpenXmlAttribute unprefixedAttribute = new OpenXmlAttribute(string.Empty, "name", null, "unprefixed attributes");

        private delegate void actionOnElement(OpenXmlElement e);

        #endregion Private Fields

        #region IgnorableTest
        [Fact]
        public void NonIgnored_UnknownAttribute_FullMode()
        {
            const string nsUnknown1 = "http://test.openxmlsdk.microsoft.com/unknownns1";
            const string prefixUnknown1 = "uns1";
            const string a1Unknown1 = "a1uk1";
            var unknownAttribute11 = new OpenXmlAttribute(prefixUnknown1, a1Unknown1, nsUnknown1, "attribute1 from unknown namespace1.");

            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            {
                (Uri, string, string) Setup()
                {
                    using (var package = WordprocessingDocument.Open(stream, true))
                    {
                        var part = package.MainPart();
                        var host = part
                            .RootElement()
                            .Descendants()
                            .PickSecond();
                        var target = host
                            .Descendants()
                            .PickSecond();

                        target.SetAttribute(unknownAttribute11);

                        return (part.Uri, host.Path(), target.Path());
                    }
                }

                var (partUri, hostPath, targetPath) = Setup();

                var settings = new OpenSettings
                {
                    MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.NoProcess, FileFormatVersions.Office2007),
                };

                using (var package = WordprocessingDocument.Open(stream, false, settings))
                {
                    var (_, target) = LocateElements(package, partUri, hostPath, targetPath);

                    VerifyExtendedAttribute(target, unknownAttribute11);
                }
            }
        }

        [Fact]
        public void NonIgnored_UnknownAttribute_O12Mode()
        {
            const string nsUnknown1 = "http://test.openxmlsdk.microsoft.com/unknownns1";
            const string prefixUnknown1 = "uns1";
            const string a1Unknown1 = "a1uk1";
            var unknownAttribute11 = new OpenXmlAttribute(prefixUnknown1, a1Unknown1, nsUnknown1, "attribute1 from unknown namespace1.");

            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            {
                (Uri, string, string) Setup()
                {
                    using (var package = WordprocessingDocument.Open(stream, true))
                    {
                        var part = package.MainPart();
                        var host = part
                            .RootElement()
                            .Descendants()
                            .PickSecond();
                        var target = host
                            .Descendants()
                            .PickSecond();

                        target.SetAttribute(unknownAttribute11);

                        return (part.Uri, host.Path(), target.Path());
                    }
                }

                var (partUri, hostPath, targetPath) = Setup();

                var settings = new OpenSettings
                {
                    MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessAllParts, FileFormatVersions.Office2007),
                };

                using (var package = WordprocessingDocument.Open(stream, false, settings))
                {
                    var (_, target) = LocateElements(package, partUri, hostPath, targetPath);

                    VerifyExtendedAttribute(target, unknownAttribute11);
                }
            }
        }

        [Fact]
        public void Validate_NonIgnored_UnknownAttribute()
        {
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            {
                string Setup()
                {
                    using (var package = WordprocessingDocument.Open(stream, true))
                    {
                        var part = package.MainPart();
                        var host = part
                            .RootElement()
                            .Descendants()
                            .PickSecond();
                        var target = host
                            .Descendants()
                            .PickSecond();

                        target.SetAttribute(unknownAttribute11);

                        return host.Path();
                    }
                }

                var hostPath = Setup();

                using (var package = WordprocessingDocument.Open(stream, false))
                {
                    ValidateMarkupCompatibility(package, FileFormatVersions.Office2007, hostPath, 1);
                }
            }
        }

        [Fact]
        public void NonIgnored_UnknownElement_FullMode()
        {
            const string nsUnknown1 = "http://test.openxmlsdk.microsoft.com/unknownns1";
            const string prefixUnknown1 = "uns1";
            const string e1Unknown1 = "e1uk1";
            var unknownElement11 = new OpenXmlUnknownElement(prefixUnknown1, e1Unknown1, nsUnknown1);

            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            {
                (Uri, string, string) Setup()
                {
                    using (var package = WordprocessingDocument.Open(stream, true))
                    {
                        var part = package.MainPart();
                        var host = part
                            .RootElement()
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement);
                        var target = host
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement);

                        target.AppendChild(unknownElement11);

                        return (part.Uri, host.Path(), target.Path());
                    }
                }

                var (partUri, hostPath, targetPath) = Setup();

                var settings = new OpenSettings
                {
                    MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.NoProcess, FileFormatVersions.Office2007),
                };

                using (var package = WordprocessingDocument.Open(stream, false, settings))
                {
                    var (_, target) = LocateElements(package, partUri, hostPath, targetPath);

                    VerifyUnknownElement(target.LastChild, unknownElement11);
                }
            }
        }

        [Fact]
        public void NonIgnored_UnknownElement_O12Mode()
        {
            const string nsUnknown1 = "http://test.openxmlsdk.microsoft.com/unknownns1";
            const string prefixUnknown1 = "uns1";
            const string e1Unknown1 = "e1uk1";
            var unknownElement11 = new OpenXmlUnknownElement(prefixUnknown1, e1Unknown1, nsUnknown1);

            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            {
                (Uri, string, string) Setup()
                {
                    using (var package = WordprocessingDocument.Open(stream, true))
                    {
                        var part = package.MainPart();
                        var host = part
                            .RootElement()
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement);
                        var target = host
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement);

                        target.AppendChild(unknownElement11);

                        return (part.Uri, host.Path(), target.Path());
                    }
                }

                var (partUri, hostPath, targetPath) = Setup();

                var settings = new OpenSettings
                {
                    MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessAllParts, FileFormatVersions.Office2007),
                };

                using (var package = WordprocessingDocument.Open(stream, false, settings))
                {
                    var (_, target) = LocateElements(package, partUri, hostPath, targetPath);

                    VerifyUnknownElement(target.LastChild, unknownElement11);
                }
            }
        }

        [Fact]
        public void Validate_NonIgnored_UnknownElement()
        {
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm))
            {
                using (var package = WordprocessingDocument.Open(stream, false))
                {
                    var part = package.MainPart();
                    var host = part
                        .RootElement()
                        .Descendants()
                        .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement));
                    var target = host
                        .Descendants()
                        .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement));

                    var unknownElement = new OpenXmlUnknownElement(prefixUnknown1, e1Unknown1, nsUnknown1);

                    target.AppendChild(unknownElement);

                    ValidateMarkupCompatibility(package, FileFormatVersions.Office2007, host.Path(), 2);
                }
            }
        }

        [Fact]
        public void Ignored_UnknownAttribute_FullMode()
        {
            const string nsUnknown1 = "http://test.openxmlsdk.microsoft.com/unknownns1";
            const string prefixUnknown1 = "uns1";
            const string a1Unknown1 = "a1uk1";
            var unknownAttribute11 = new OpenXmlAttribute(prefixUnknown1, a1Unknown1, nsUnknown1, "attribute1 from unknown namespace1.");

            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            {
                (Uri, string, string) Setup()
                {
                    using (var package = WordprocessingDocument.Open(stream, true))
                    {
                        var part = package.MainPart();
                        var host = part
                            .RootElement()
                            .Descendants()
                            .PickSecond();
                        var target = host
                            .Descendants()
                            .PickSecond();

                        target.SetAttribute(unknownAttribute11);

                        host.SetIgnorable(unknownAttribute11.Prefix);
                        host.AddNamespaceDeclaration(unknownAttribute11.Prefix, unknownAttribute11.NamespaceUri);

                        return (part.Uri, host.Path(), target.Path());
                    }
                }

                var (partUri, hostPath, targetPath) = Setup();

                var settings = new OpenSettings
                {
                    MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.NoProcess, FileFormatVersions.Office2007),
                };

                using (var package = WordprocessingDocument.Open(stream, false, settings))
                {
                    var (host, target) = LocateElements(package, partUri, hostPath, targetPath);

                    VerifyMcAttribute(host, "Ignorable", unknownAttribute11.Prefix);
                    VerifyExtendedAttribute(target, unknownAttribute11);
                }
            }
        }

        [Fact]
        public void Ignored_UnknownAttribute_O12Mode()
        {
            const string nsUnknown1 = "http://test.openxmlsdk.microsoft.com/unknownns1";
            const string prefixUnknown1 = "uns1";
            const string a1Unknown1 = "a1uk1";
            var unknownAttribute11 = new OpenXmlAttribute(prefixUnknown1, a1Unknown1, nsUnknown1, "attribute1 from unknown namespace1.");

            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            {
                (Uri, string, string) Setup()
                {
                    using (var package = WordprocessingDocument.Open(stream, true))
                    {
                        var part = package.MainPart();
                        var host = part
                            .RootElement()
                            .Descendants()
                            .PickSecond();
                        var target = host
                            .Descendants()
                            .PickSecond();

                        target.SetAttribute(unknownAttribute11);

                        host.SetIgnorable(unknownAttribute11.Prefix);
                        host.AddNamespaceDeclaration(unknownAttribute11.Prefix, unknownAttribute11.NamespaceUri);

                        return (part.Uri, host.Path(), target.Path());
                    }
                }

                var (partUri, hostPath, targetPath) = Setup();

                var settings = new OpenSettings
                {
                    MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessAllParts, FileFormatVersions.Office2007),
                };

                using (var package = WordprocessingDocument.Open(stream, false, settings))
                {
                    var (_, target) = LocateElements(package, partUri, hostPath, targetPath);

                    VerifyNoExtendedAttribute(target, unknownAttribute11);
                }
            }
        }

        [Fact]
        public void Validate_Ignored_UnknownAttribute()
        {
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm))
            using (var package = WordprocessingDocument.Open(stream, false))
            {
                var part = package.MainPart();
                var dom = part.RootElement();
                var host = dom
                    .Descendants()
                    .PickSecond();
                var target = host
                    .Descendants()
                    .PickSecond();
                var unknownAttribute11 = new OpenXmlAttribute(prefixUnknown1, a1Unknown1, nsUnknown1, "attribute1 from unknown namespace1.");

                target.SetAttribute(unknownAttribute11);

                host.SetIgnorable(unknownAttribute11.Prefix);
                host.AddNamespaceDeclaration(unknownAttribute11.Prefix, unknownAttribute11.NamespaceUri);

                ValidateMarkupCompatibility(package, FileFormatVersions.Office2007, 0);
            }
        }

        [Fact]
        public void Ignored_KnownAttribute_FullMode()
        {
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            {
                (OpenXmlAttribute, Uri, string) Setup()
                {
                    using (var package = WordprocessingDocument.Open(stream, true))
                    {
                        var part = package.MainPart();
                        var host = part
                            .RootElement()
                            .Descendants()
                            .PickFirst(d => d.HasAttributes && d.ExtendedAttributes.Count() == 0);

                        var knownAttribute = host.GetAttributes().First();

                        host.SetIgnorable(knownAttribute.Prefix);

                        return (knownAttribute, part.Uri, host.Path());
                    }
                }

                var (known, uriPart, hostPath) = Setup();
                var settings = new OpenSettings
                {
                    MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.NoProcess, FileFormatVersions.Office2007),
                };

                using (var package = WordprocessingDocument.Open(stream, true, settings))
                {
                    var host = LocateElements(package, uriPart, hostPath);

                    VerifyMcAttribute(host, "Ignorable", known.Prefix);
                    VerifyKnownAttribute(host, known);
                }
            }
        }

        [Fact]
        public void Ignored_KnownAttribute_O12Mode()
        {
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            {
                (Uri, string, OpenXmlAttribute) Setup()
                {
                    using (var package = WordprocessingDocument.Open(stream, true))
                    {
                        var part = package.MainPart();
                        var dom = part.RootElement();
                        var host = dom
                            .Descendants()
                            .PickFirst(d => d.HasAttributes && d.ExtendedAttributes.Count() == 0);

                        var knownAttribute = host.GetAttributes().First();
                        host.SetIgnorable(knownAttribute.Prefix);

                        return (part.Uri, host.Path(), knownAttribute);
                    }
                }

                var (partUri, hostPath, known) = Setup();

                var settings = new OpenSettings
                {
                    MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessAllParts, FileFormatVersions.Office2007),
                };

                using (var package = WordprocessingDocument.Open(stream, false))
                {
                    var host = LocateElements(package, partUri, hostPath);

                    VerifyKnownAttribute(host, known);
                }
            }
        }

        [Fact]
        public void Validate_Ignored_KnownAttribute()
        {
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm))
            using (var package = WordprocessingDocument.Open(stream, false))
            {
                var part = package.MainPart();
                var dom = part.RootElement();
                var host = dom
                    .Descendants()
                    .PickFirst(d => d.HasAttributes && d.ExtendedAttributes.Count() == 0);

                var knownAttribute2 = host.GetAttributes().First();
                host.SetIgnorable(knownAttribute2.Prefix);

                ValidateMarkupCompatibility(package, FileFormatVersions.Office2007, 0);
            }
        }

        [Fact]
        public void Ignored_UnknownElement_FullMode()
        {
            const string prefixUnknown1 = "uns1";
            const string e1Unknown1 = "e1uk1";
            const string nsUnknown1 = "http://test.openxmlsdk.microsoft.com/unknownns1";
            var unknownElement11 = new OpenXmlUnknownElement(prefixUnknown1, e1Unknown1, nsUnknown1);

            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            {
                (Uri, string, string) Setup()
                {
                    using (var package = WordprocessingDocument.Open(stream, true))
                    {
                        var part = package.MainPart();
                        var dom = part.RootElement();
                        var host = dom
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement);
                        var target = host
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement);

                        target.AppendChild(unknownElement11);

                        host.SetIgnorable(unknownElement11.Prefix);
                        host.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);

                        return (part.Uri, host.Path(), target.Path());
                    }
                }

                var (partUri, hostPath, targetPath) = Setup();

                var settings = new OpenSettings
                {
                    MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.NoProcess, FileFormatVersions.Office2007),
                };

                using (var package = WordprocessingDocument.Open(stream, false))
                {
                    var (host, target) = LocateElements(package, partUri, hostPath, targetPath);

                    VerifyMcAttribute(host, "Ignorable", unknownElement11.Prefix);
                    VerifyUnknownElement(target.LastChild, unknownElement11);
                }
            }
        }

        [Fact]
        public void Ignored_UnknownElement_O12Mode()
        {
            const string prefixUnknown1 = "uns1";
            const string e1Unknown1 = "e1uk1";
            const string nsUnknown1 = "http://test.openxmlsdk.microsoft.com/unknownns1";
            var unknownElement11 = new OpenXmlUnknownElement(prefixUnknown1, e1Unknown1, nsUnknown1);

            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            {
                (Uri, string, string) Setup()
                {
                    using (var package = WordprocessingDocument.Open(stream, true))
                    {
                        var part = package.MainPart();
                        var dom = part.RootElement();
                        var host = dom
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement);
                        var target = host
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement);

                        target.AppendChild(unknownElement11);

                        host.SetIgnorable(unknownElement11.Prefix);
                        host.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);

                        return (part.Uri, host.Path(), target.Path());
                    }
                }

                var (partUri, hostPath, targetPath) = Setup();

                var settings = new OpenSettings
                {
                    MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessAllParts, FileFormatVersions.Office2007),
                };

                using (var package = WordprocessingDocument.Open(stream, false))
                {
                    var (_, target) = LocateElements(package, partUri, hostPath, targetPath);

                    VerifyUnknownElement(target.LastChild, unknownElement11);
                }
            }
        }

        [Fact]
        public void Validate_Ignored_UnknownElement()
        {
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm))
            using (var package = WordprocessingDocument.Open(stream, false))
            {
                var part = package.MainPart();
                var dom = part.RootElement();
                var host = dom
                    .Descendants()
                    .PickFirst(d => d is OpenXmlCompositeElement);
                var target = host
                    .Descendants()
                    .PickFirst(d => d is OpenXmlCompositeElement);

                var unknownElement11 = new OpenXmlUnknownElement(prefixUnknown1, e1Unknown1, nsUnknown1);

                target.AppendChild(unknownElement11);
                host.SetIgnorable(unknownElement11.Prefix);
                host.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);

                ValidateMarkupCompatibility(package, FileFormatVersions.Office2007, 0);
            }
        }

        [Fact]
        public void Ignored_KnownElement_FullMode()
        {
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            {
                (Uri, string, string, OpenXmlElement) Setup()
                {
                    using (var package = WordprocessingDocument.Open(stream, true))
                    {
                        var part = package.MainPart();
                        var dom = part.RootElement();
                        var host = dom
                            .Descendants()
                            .PickFirst(d => d.FirstChild != null && !(d.FirstChild is OpenXmlUnknownElement));
                        var target = host
                            .Descendants()
                            .PickFirst(d => d.FirstChild != null && !(d.FirstChild is OpenXmlUnknownElement));

                        var knownElement = target.FirstChild;
                        host.SetIgnorable(knownElement.Prefix);

                        return (part.Uri, host.Path(), target.Path(), knownElement);
                    }
                }

                var (partUri, hostPath, targetPath, known) = Setup();

                var settings = new OpenSettings
                {
                    MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.NoProcess, FileFormatVersions.Office2007),
                };

                using (var package = WordprocessingDocument.Open(stream, false))
                {
                    var (host, target) = LocateElements(package, partUri, hostPath, targetPath);

                    VerifyMcAttribute(host, "Ignorable", known.Prefix);
                    VerifyKnownElement(target.FirstChild, known);
                }
            }
        }

        [Fact]
        public void Ignored_KnownElement_O12Mode()
        {
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            {
                (Uri, string, string, OpenXmlElement) Setup()
                {
                    using (var package = WordprocessingDocument.Open(stream, true))
                    {
                        var part = package.MainPart();
                        var dom = part.RootElement();
                        var host = dom
                            .Descendants()
                            .PickFirst(d => d.FirstChild != null && !(d.FirstChild is OpenXmlUnknownElement));
                        var target = host
                            .Descendants()
                            .PickFirst(d => d.FirstChild != null && !(d.FirstChild is OpenXmlUnknownElement));

                        var knownElement = target.FirstChild;
                        host.SetIgnorable(knownElement.Prefix);

                        return (part.Uri, host.Path(), target.Path(), knownElement);
                    }
                }

                var (partUri, hostPath, targetPath, known) = Setup();

                var settings = new OpenSettings
                {
                    MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessAllParts, FileFormatVersions.Office2007),
                };

                using (var package = WordprocessingDocument.Open(stream, false))
                {
                    var (_, target) = LocateElements(package, partUri, hostPath, targetPath);

                    VerifyKnownElement(target.FirstChild, known);
                }
            }
        }

        [Fact]
        public void Validate_Ignored_KnownElement()
        {
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm))
            using (var package = WordprocessingDocument.Open(stream, false))
            {
                var part = package.MainPart();
                var dom = part.RootElement();
                var host = dom
                    .Descendants()
                    .PickFirst(d => d.FirstChild != null && !(d.FirstChild is OpenXmlUnknownElement));
                var target = host
                    .Descendants()
                    .PickFirst(d => d.FirstChild != null && !(d.FirstChild is OpenXmlUnknownElement));

                host.SetIgnorable(target.FirstChild.Prefix);

                ValidateMarkupCompatibility(package, FileFormatVersions.Office2007, 0);
            }
        }

        [Fact]
        public void Ignore_Whitespaces_FullMode()
        {
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            {
                (Uri, string) Setup()
                {
                    using (var package = WordprocessingDocument.Open(stream, true))
                    {
                        var part = package.MainPart();
                        var dom = part.RootElement();
                        var host = dom.Descendants().PickFirst(d => d is OpenXmlCompositeElement);

                        host.SetIgnorable("\x20\x9\xA\xD");

                        return (part.Uri, host.Path());
                    }
                }

                var (partUri, hostPath) = Setup();

                var openSettings = new OpenSettings
                {
                    MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.NoProcess, FileFormatVersions.Office2007),
                };

                using (var package = WordprocessingDocument.Open(stream, false, openSettings))
                {
                    var host = LocateElements(package, partUri, hostPath);

                    VerifyMcAttribute(host, "Ignorable", "\x20\x9\xA\xD");
                }
            }
        }

        [Fact]
        public void Validate_Ignore_Whitespaces()
        {
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm))
            using (var package = WordprocessingDocument.Open(stream, false))
            {
                var part = package.MainPart();
                var dom = part.RootElement();
                var host = dom
                    .Descendants()
                    .PickFirst(d => d is OpenXmlCompositeElement);
                var target = host
                    .Descendants()
                    .PickFirst(d => d is OpenXmlCompositeElement);

                var unknownElement11 = new OpenXmlUnknownElement(prefixUnknown1, e1Unknown1, nsUnknown1);

                target.AppendChild(unknownElement11);

                host.SetIgnorable("\x20\x9\xA\xD");
                host.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);

                ValidateMarkupCompatibility(package, FileFormatVersions.Office2007, 0);
            }
        }

        #endregion IgnorableTest

        #region ProcessContent

        // process content (attaching attributes and child element)
        [Fact]
        public void ProcessContent_Ignored_UnknownElement_FullMode()
        {
            const string prefixUnknown1 = "uns1";
            const string e1Unknown1 = "e1uk1";
            const string nsUnknown1 = "http://test.openxmlsdk.microsoft.com/unknownns1";
            var unknownElement11 = new OpenXmlUnknownElement(prefixUnknown1, e1Unknown1, nsUnknown1);

            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            {
                (Uri, string, string, List<OpenXmlElement>) Setup()
                {
                    using (var package = WordprocessingDocument.Open(stream, true))
                    {
                        var part = package.MainPart();
                        var dom = part.RootElement();
                        var host = dom
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement));
                        var target = host
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement));

                        var children = new List<OpenXmlElement>();
                        WrapChildrenWithElement(target, unknownElement11, children);

                        host.SetIgnorable(unknownElement11.Prefix);
                        host.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);
                        host.SetProcessContent(unknownElement11.GetFullName());

                        return (part.Uri, host.Path(), target.Path(), children);
                    }
                }

                var (partUri, hostPath, targetPath, expected) = Setup();

                var openSettings = new OpenSettings
                {
                    MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.NoProcess, FileFormatVersions.Office2007),
                };

                using (var package = WordprocessingDocument.Open(stream, false, openSettings))
                {
                    var (host, target) = LocateElements(package, partUri, hostPath, targetPath);

                    VerifyMcAttribute(host, "Ignorable", unknownElement11.Prefix);
                    VerifyMcAttribute(host, "ProcessContent", unknownElement11.GetFullName());
                    VerifyUnknownElement(target.LastChild, unknownElement11);
                    VerifyUnknownChildren(target.LastChild, expected);
                }
            }
        }

        [Fact]
        public void ProcessContent_Ignored_UnknownElement_O12Mode()
        {
            const string prefixUnknown1 = "uns1";
            const string e1Unknown1 = "e1uk1";
            const string nsUnknown1 = "http://test.openxmlsdk.microsoft.com/unknownns1";
            var unknownElement11 = new OpenXmlUnknownElement(prefixUnknown1, e1Unknown1, nsUnknown1);

            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            {
                (Uri, string, string, List<OpenXmlElement>) Setup()
                {
                    using (var package = WordprocessingDocument.Open(stream, true))
                    {
                        var part = package.MainPart();
                        var dom = part.RootElement();
                        var host = dom
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement));
                        var target = host
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement));

                        var children = new List<OpenXmlElement>();
                        WrapChildrenWithElement(target, unknownElement11, children);

                        host.SetIgnorable(unknownElement11.Prefix);
                        host.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);
                        host.SetProcessContent(unknownElement11.GetFullName());

                        return (part.Uri, host.Path(), target.Path(), children);
                    }
                }

                var (partUri, hostPath, targetPath, expected) = Setup();

                var openSettings = new OpenSettings
                {
                    MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessAllParts, FileFormatVersions.Office2007),
                };

                using (var package = WordprocessingDocument.Open(stream, false, openSettings))
                {
                    var (_, target) = LocateElements(package, partUri, hostPath, targetPath);

                    VerifyNoUnkownChild(target, unknownElement11.GetFullName());
                    VerifyKnownChildren(target, expected);
                }
            }
        }

        [Fact]
        public void Validate_ProcessContent_Ignored_UnknownElement()
        {
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm))
            using (var package = WordprocessingDocument.Open(stream, false))
            {
                var part = package.MainPart();
                var dom = part.RootElement();
                var host = dom
                    .Descendants()
                    .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement));
                var target = host
                    .Descendants()
                    .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement));

                var unknownElement11 = new OpenXmlUnknownElement(prefixUnknown1, e1Unknown1, nsUnknown1);

                var children = new List<OpenXmlElement>();
                WrapChildrenWithElement(target, unknownElement11, children);

                host.SetIgnorable(unknownElement11.Prefix);
                host.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);
                host.SetProcessContent(unknownElement11.GetFullName());

                ValidateMarkupCompatibility(package, FileFormatVersions.Office2007, 0);
            }
        }

        [Fact]
        public void ProcessContent_Ignored_UnknownElement_Wildcard_FullMode()
        {
            const string prefixUnknown1 = "uns1";
            const string e1Unknown1 = "e1uk1";
            const string nsUnknown1 = "http://test.openxmlsdk.microsoft.com/unknownns1";
            var unknownElement11 = new OpenXmlUnknownElement(prefixUnknown1, e1Unknown1, nsUnknown1);

            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            {
                (Uri, string, string, List<OpenXmlElement>) Setup()
                {
                    using (var package = WordprocessingDocument.Open(stream, true))
                    {
                        var part = package.MainPart();
                        var dom = part.RootElement();
                        var host = dom
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement));
                        var target = host
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement));

                        var children = new List<OpenXmlElement>();
                        WrapChildrenWithElement(target, unknownElement11, children);

                        host.SetIgnorable(unknownElement11.Prefix);
                        host.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);
                        host.SetProcessContent("*");

                        return (part.Uri, host.Path(), target.Path(), children);
                    }
                }

                var (partUri, hostPath, targetPath, expected) = Setup();

                var openSettings = new OpenSettings
                {
                    MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.NoProcess, FileFormatVersions.Office2007),
                };

                using (var package = WordprocessingDocument.Open(stream, false, openSettings))
                {
                    var (host, target) = LocateElements(package, partUri, hostPath, targetPath);

                    VerifyMcAttribute(host, "Ignorable", unknownElement11.Prefix);
                    VerifyMcAttribute(host, "ProcessContent", "*");
                    VerifyUnknownElement(target.LastChild, unknownElement11);
                    VerifyUnknownChildren(target.LastChild, expected);
                }
            }
        }

        [Fact]
        public void ProcessContent_NonIgnored_UnknownElement_FullMode()
        {
            const string prefixUnknown1 = "uns1";
            const string e1Unknown1 = "e1uk1";
            const string nsUnknown1 = "http://test.openxmlsdk.microsoft.com/unknownns1";
            var unknownElement11 = new OpenXmlUnknownElement(prefixUnknown1, e1Unknown1, nsUnknown1);

            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            {
                (Uri, string, string, List<OpenXmlElement>) Setup()
                {
                    using (var package = WordprocessingDocument.Open(stream, true))
                    {
                        var part = package.MainPart();
                        var dom = part.RootElement();
                        var host = dom
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement));
                        var target = host
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement));

                        var children = new List<OpenXmlElement>();
                        WrapChildrenWithElement(target, unknownElement11, children);

                        host.SetProcessContent(unknownElement11.GetFullName());
                        host.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);

                        return (part.Uri, host.Path(), target.Path(), children);
                    }
                }

                var (partUri, hostPath, targetPath, expected) = Setup();

                var openSettings = new OpenSettings
                {
                    MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.NoProcess, FileFormatVersions.Office2007),
                };

                using (var package = WordprocessingDocument.Open(stream, false, openSettings))
                {
                    var (host, target) = LocateElements(package, partUri, hostPath, targetPath);

                    VerifyNoMcAttribute(host, "Ignorable", unknownElement11.Prefix);
                    VerifyMcAttribute(host, "ProcessContent", unknownElement11.GetFullName());
                    VerifyUnknownElement(target.LastChild, unknownElement11);
                    VerifyUnknownChildren(target.LastChild, expected);
                }
            }
        }

        [Fact]
        public void ProcessContent_NonIgnored_UnknownElement_O12Mode()
        {
            const string prefixUnknown1 = "uns1";
            const string e1Unknown1 = "e1uk1";
            const string nsUnknown1 = "http://test.openxmlsdk.microsoft.com/unknownns1";
            var unknownElement11 = new OpenXmlUnknownElement(prefixUnknown1, e1Unknown1, nsUnknown1);

            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            {
                (Uri, string, string, List<OpenXmlElement>) Setup()
                {
                    using (var package = WordprocessingDocument.Open(stream, true))
                    {
                        var part = package.MainPart();
                        var dom = part.RootElement();
                        var host = dom
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement);
                        var target = host
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement);

                        var children = new List<OpenXmlElement>();
                        WrapChildrenWithElement(target, unknownElement11, children);

                        host.SetProcessContent(unknownElement11.GetFullName());
                        host.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);

                        return (part.Uri, host.Path(), target.Path(), children);
                    }
                }

                var (partUri, hostPath, targetPath, expected) = Setup();

                var openSettings = new OpenSettings
                {
                    MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessAllParts, FileFormatVersions.Office2007),
                };

                using (var package = WordprocessingDocument.Open(stream, false, openSettings))
                {
                    var (host, target) = LocateElements(package, partUri, hostPath, targetPath);

                    VerifyNoMcAttribute(host, "ProcessContent", unknownElement11.GetFullName());
                    VerifyUnknownElement(target.LastChild, unknownElement11);
                    VerifyUnknownChildren(target.LastChild, expected);
                }
            }
        }

        [Fact]
        public void Validate_ProcessContent_NonIgnored_UnknownElement()
        {
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            {
                using (var package = WordprocessingDocument.Open(stream, true))
                {
                    var part = package.MainPart();
                    var dom = part.RootElement();
                    var host = dom
                        .Descendants()
                        .PickFirst(d => d is OpenXmlCompositeElement);
                    var target = host
                        .Descendants()
                        .PickFirst(d => d is OpenXmlCompositeElement);

                    var unknownElement11 = new OpenXmlUnknownElement(prefixUnknown1, e1Unknown1, nsUnknown1);

                    var children = new List<OpenXmlElement>();
                    WrapChildrenWithElement(target, unknownElement11, children);

                    host.SetProcessContent(unknownElement11.GetFullName());
                    host.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);
                }

                using (var package = WordprocessingDocument.Open(stream, true))
                {
                    ValidateMarkupCompatibility(package, FileFormatVersions.Office2007, 1);
                }
            }
        }

        [Fact]
        public void ProcessContent_Ignored_KnownElement_FullMode()
        {
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            {
                (Uri, string, string, OpenXmlElement) Setup()
                {
                    using (var package = WordprocessingDocument.Open(stream, true))
                    {
                        var part = package.MainPart();
                        var dom = part.RootElement();
                        var host = dom
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !(d.FirstChild is OpenXmlUnknownElement));
                        var target = host
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !(d.FirstChild is OpenXmlUnknownElement));

                        host.SetIgnorable(target.FirstChild.Prefix);
                        host.SetProcessContent(target.FirstChild.GetFullName());

                        return (part.Uri, host.Path(), target.Path(), target.FirstChild);
                    }
                }

                var (partUri, hostPath, targetPath, known) = Setup();

                var openSettings = new OpenSettings
                {
                    MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.NoProcess, FileFormatVersions.Office2007),
                };

                using (var package = WordprocessingDocument.Open(stream, false, openSettings))
                {
                    var (host, target) = LocateElements(package, partUri, hostPath, targetPath);

                    VerifyMcAttribute(host, "Ignorable", known.Prefix);
                    VerifyMcAttribute(host, "ProcessContent", known.GetFullName());
                    VerifyKnownElement(target.FirstChild, known);
                }
            }
        }

        [Fact]
        public void ProcessContent_Ignored_KnownElement_O12Mode()
        {
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            {
                (Uri, string, string, OpenXmlElement) Setup()
                {
                    using (var package = WordprocessingDocument.Open(stream, false))
                    {
                        var part = package.MainPart();
                        var host = part
                            .RootElement()
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !(d.FirstChild is OpenXmlUnknownElement));
                        var target = host
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !(d.FirstChild is OpenXmlUnknownElement));

                        var known = target.FirstChild.CloneNode(true);
                        host.SetIgnorable(known.Prefix);
                        host.SetProcessContent(known.GetFullName());

                        return (part.Uri, host.Path(), target.Path(), known);
                    }
                }

                var (partUri, hostPath, targetPath, expected) = Setup();

                using (var package = WordprocessingDocument.Open(stream, false))
                {
                    var (_, target) = LocateElements(package, partUri, hostPath, targetPath);

                    VerifyKnownElement(target.FirstChild, expected);
                }
            }
        }

        [Fact]
        public void Validate_ProcessContent_Ignored_KnownElement()
        {
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm))
            using (var package = WordprocessingDocument.Open(stream, false))
            {
                var part = package.MainPart();
                var dom = part.RootElement();
                var host = dom
                    .Descendants()
                    .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !(d.FirstChild is OpenXmlUnknownElement));
                var target = host
                    .Descendants()
                    .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !(d.FirstChild is OpenXmlUnknownElement));

                host.SetIgnorable(target.FirstChild.Prefix);
                host.SetProcessContent(target.FirstChild.GetFullName());

                ValidateMarkupCompatibility(package, FileFormatVersions.Office2007, 0);
            }
        }

        [Fact]
        public void ProcessContent_xmlSpace_FullMode()
        {
            const string prefixUnknown1 = "uns1";
            const string e1Unknown1 = "e1uk1";
            const string nsUnknown1 = "http://test.openxmlsdk.microsoft.com/unknownns1";
            var unknownElement11 = new OpenXmlUnknownElement(prefixUnknown1, e1Unknown1, nsUnknown1);
            var xmlSpace = new OpenXmlAttribute("xml", "space", xmlNS, "default");

            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            {
                (Uri, string, string, List<OpenXmlElement>) Setup()
                {
                    using (var package = WordprocessingDocument.Open(stream, true))
                    {
                        var part = package.MainPart();
                        var dom = part.RootElement();
                        var host = dom
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement));
                        var target = host
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement));

                        var children = new List<OpenXmlElement>();
                        WrapChildrenWithElement(target, unknownElement11, children);

                        host.SetIgnorable(unknownElement11.Prefix);
                        host.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);
                        host.SetProcessContent(unknownElement11.GetFullName());
                        host.SetAttribute(xmlSpace);

                        return (part.Uri, host.Path(), target.Path(), children);
                    }
                }

                var (partUri, hostPath, targetPath, expected) = Setup();

                var openSettings = new OpenSettings
                {
                    MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.NoProcess, FileFormatVersions.Office2007),
                };

                using (var package = WordprocessingDocument.Open(stream, false, openSettings))
                {
                    var (host, target) = LocateElements(package, partUri, hostPath, targetPath);

                    VerifyMcAttribute(host, "Ignorable", unknownElement11.Prefix);
                    VerifyMcAttribute(host, "ProcessContent", unknownElement11.GetFullName());
                    VerifyAttribute(host, xmlSpace);
                    VerifyUnknownElement(target.LastChild, unknownElement11);
                    VerifyUnknownChildren(target.LastChild, expected);
                }
            }
        }

        [Fact]
        public void ProcessContent_xmlLang_FullMode()
        {
            const string prefixUnknown1 = "uns1";
            const string e1Unknown1 = "e1uk1";
            const string nsUnknown1 = "http://test.openxmlsdk.microsoft.com/unknownns1";
            var unknownElement11 = new OpenXmlUnknownElement(prefixUnknown1, e1Unknown1, nsUnknown1);
            var xmlLang = new OpenXmlAttribute("xml", "lang", xmlNS, "en-US");

            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            {
                (Uri, string, string, List<OpenXmlElement>) Setup()
                {
                    using (var package = WordprocessingDocument.Open(stream, true))
                    {
                        var part = package.MainPart();
                        var dom = part.RootElement();
                        var host = dom
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement));
                        var target = host
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement));

                        var children = new List<OpenXmlElement>();
                        WrapChildrenWithElement(target, unknownElement11, children);

                        host.SetIgnorable(unknownElement11.Prefix);
                        host.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);
                        host.SetProcessContent(unknownElement11.GetFullName());
                        host.SetAttribute(xmlLang);

                        return (part.Uri, host.Path(), target.Path(), children);
                    }
                }

                var (partUri, hostPath, targetPath, expected) = Setup();

                var openSettings = new OpenSettings
                {
                    MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.NoProcess, FileFormatVersions.Office2007),
                };

                using (var package = WordprocessingDocument.Open(stream, false, openSettings))
                {
                    var (host, target) = LocateElements(package, partUri, hostPath, targetPath);

                    VerifyMcAttribute(host, "Ignorable", unknownElement11.Prefix);
                    VerifyMcAttribute(host, "ProcessContent", unknownElement11.GetFullName());
                    VerifyAttribute(host, xmlLang);
                    VerifyUnknownElement(target.LastChild, unknownElement11);
                    VerifyUnknownChildren(target.LastChild, expected);
                }
            }
        }

        [Fact]
        public void Validate_ProcessContent_xmlLang()
        {
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            {
                using (var package = WordprocessingDocument.Open(stream, true))
                {
                    var part = package.MainPart();
                    var host = part
                        .RootElement()
                        .Descendants()
                        .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement));
                    var target = host
                        .Descendants()
                        .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement));

                    var unknownElement = new OpenXmlUnknownElement(prefixUnknown1, e1Unknown1, nsUnknown1);
                    var xmlLang = new OpenXmlAttribute("xml", "lang", xmlNS, "en-US");

                    var children = new List<OpenXmlElement>();
                    WrapChildrenWithElement(target, unknownElement, children);

                    host.SetIgnorable(unknownElement.Prefix);
                    host.AddNamespaceDeclaration(unknownElement.Prefix, unknownElement.NamespaceUri);
                    host.SetProcessContent(unknownElement.GetFullName());
                    host.SetAttribute(xmlLang);
                }

                using (var package = WordprocessingDocument.Open(stream, true))
                {
                    ValidateMarkupCompatibility(package, FileFormatVersions.Office2007, 1);
                }
            }
        }
        #endregion ProcessContent

        #region Preserve Elements & Attributes

        // ignored unknown element along with ignored prefixed attribute, unprefixed attribute, non-ignored unknown attribute.
        [Fact]
        public void Preserve_Ignored_UnknownElement_FullMode()
        {
            const string prefixUnknown1 = "uns1";
            const string e1Unknown1 = "e1uk1";
            const string nsUnknown1 = "http://test.openxmlsdk.microsoft.com/unknownns1";
            var unknownElement11 = new OpenXmlUnknownElement(prefixUnknown1, e1Unknown1, nsUnknown1);

            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            {
                (Uri, string, string, List<OpenXmlElement>) Setup()
                {
                    using (var package = WordprocessingDocument.Open(stream, true))
                    {
                        var part = package.MainPart();
                        var dom = part.RootElement();
                        var host = dom
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement));
                        var target = host
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement));

                        var children = new List<OpenXmlElement>();

                        foreach (var d in target.ChildElements)
                        {
                            children.Add(d.CloneNode(true));
                        }

                        target.AppendChild(unknownElement11);
                        unknownElement11.SetAttribute(unknownAttribute11);
                        unknownElement11.SetAttribute(unknownAttribute12);
                        unknownElement11.SetAttribute(unprefixedAttribute);

                        host.SetIgnorable(unknownElement11.Prefix);
                        host.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);
                        host.SetPreserveElements(unknownElement11.GetFullName());
                        host.SetPreserveAttributes(unknownAttribute11.GetFullName());

                        return (part.Uri, host.Path(), target.Path(), children);
                    }
                }

                var (partUri, hostPath, targetPath, expected) = Setup();

                var openSettings = new OpenSettings
                {
                    MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.NoProcess, FileFormatVersions.Office2007),
                };

                using (var package = WordprocessingDocument.Open(stream, false, openSettings))
                {
                    var (host, target) = LocateElements(package, partUri, hostPath, targetPath);
                    VerifyMcAttribute(host, "Ignorable", unknownElement11.Prefix);
                    VerifyMcAttribute(host, "PreserveElements", unknownElement11.GetFullName());
                    VerifyMcAttribute(host, "PreserveAttributes", unknownAttribute11.GetFullName());

                    VerifyUnknownElement(target.LastChild, unknownElement11);
                    VerifyKnownChildren(target, expected);
                }
            }
        }

        [Fact]
        public void Preserve_Ignored_UnknownElement_O12Mode()
        {
            var unknownElement = new OpenXmlUnknownElement(prefixUnknown1, e1Unknown1, nsUnknown1);
            var unknownAttribute1 = new OpenXmlAttribute(prefixUnknown1, a1Unknown1, nsUnknown1, "attribute1 from unknown namespace1.");
            var unknownAttribute2 = new OpenXmlAttribute(prefixUnknown1, a2Unknown1, nsUnknown1, "attribute2 from unknown namespace1.");
            var unprefixedAttribute = new OpenXmlAttribute(string.Empty, "name", null, "unprefixed attributes");

            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            {
                (Uri part, string host, string target, List<OpenXmlElement> children, OpenXmlElement expected) Setup()
                {
                    using (var package = WordprocessingDocument.Open(stream, true))
                    {
                        var part = package.MainPart();
                        var host = part
                            .RootElement()
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement));
                        var target = host
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement));

                        var children = new List<OpenXmlElement>();
                        foreach (var d in target.ChildElements)
                        {
                            children.Add(d.CloneNode(true));
                        }

                        target.AppendChild(unknownElement);
                        unknownElement.SetAttribute(unknownAttribute1);
                        unknownElement.SetAttribute(unprefixedAttribute);

                        var expectedElement = unknownElement.CloneNode(true);

                        unknownElement.SetAttribute(unknownAttribute2);

                        host.SetIgnorable(unknownElement.Prefix);
                        host.AddNamespaceDeclaration(unknownElement.Prefix, unknownElement.NamespaceUri);
                        host.SetPreserveElements(unknownElement.GetFullName());
                        host.SetPreserveAttributes(unknownAttribute1.GetFullName());

                        return (part.Uri, host.Path(), target.Path(), children, expectedElement);
                    }
                }

                var (partUri, hostPath, targetPath, expectedChildren, element) = Setup();

                var settings = new OpenSettings()
                {
                    MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessAllParts, FileFormatVersions.Office2007),
                };

                using (var package = WordprocessingDocument.Open(stream, false, settings))
                {
                    var (_, target) = LocateElements(package, partUri, hostPath, targetPath);

                    VerifyUnknownElement(target.LastChild, element);
                    VerifyAttribute(target.LastChild, unknownAttribute1);
                    VerifyAttribute(target.LastChild, unprefixedAttribute);
                    VerifyNoAttribute(target.LastChild, unknownAttribute2);
                    VerifyKnownChildren(target, expectedChildren);
                }
            }
        }

        [Fact]
        public void Validate_Preserve_Ignored_UnknownElement()
        {
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            {
                using (var package = WordprocessingDocument.Open(stream, true))
                {
                    var part = package.MainPart();
                    var dom = part.RootElement();
                    var host = dom
                        .Descendants()
                        .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement));
                    var target = host
                        .Descendants()
                        .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement));

                    var unknownElement11 = new OpenXmlUnknownElement(prefixUnknown1, e1Unknown1, nsUnknown1);
                    var unknownAttribute11 = new OpenXmlAttribute(prefixUnknown1, a1Unknown1, nsUnknown1, "attribute1 from unknown namespace1.");
                    var unknownAttribute12 = new OpenXmlAttribute(prefixUnknown1, a2Unknown1, nsUnknown1, "attribute2 from unknown namespace1.");
                    var unprefixedAttribute = new OpenXmlAttribute(string.Empty, "name", null, "unprefixed attributes");

                    target.AppendChild(unknownElement11);
                    unknownElement11.SetAttribute(unknownAttribute11);
                    unknownElement11.SetAttribute(unknownAttribute12);
                    unknownElement11.SetAttribute(unprefixedAttribute);

                    host.SetIgnorable(unknownElement11.Prefix);
                    host.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);
                    host.SetPreserveElements(unknownElement11.GetFullName());
                    host.SetPreserveAttributes(unknownAttribute11.GetFullName());
                }

                using (var package = WordprocessingDocument.Open(stream, false))
                {
                    ValidateMarkupCompatibility(package, FileFormatVersions.Office2007, 0);
                }
            }
        }

        [Fact]
        public void Preserve_Ignored_UnknownElement_InnerIgnorable_FullMode()
        {
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            {
                (Uri, string, string, List<OpenXmlElement>) Setup()
                {
                    using (var package = WordprocessingDocument.Open(stream, true))
                    {
                        var part = package.MainPart();
                        var dom = part.RootElement();
                        var host = dom
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement));
                        var target = host
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement));

                        // append unknown element(with unknown attributes) to first child
                        var firstChild = target.FirstChild;
                        target.SetIgnorable(unknownElement12.Prefix);
                        firstChild.AppendChild(unknownElement12);
                        unknownElement12.SetAttribute(unknownAttribute11);
                        unknownElement12.SetAttribute(unknownAttribute12);

                        var children = new List<OpenXmlElement>();

                        foreach (var d in target.ChildElements)
                        {
                            children.Add(d.CloneNode(true));
                        }

                        target.AppendChild(unknownElement11);
                        unknownElement11.SetAttribute(unknownAttribute11);
                        unknownElement11.SetAttribute(unknownAttribute12);
                        unknownElement11.SetAttribute(unprefixedAttribute);

                        host.SetIgnorable(unknownElement11.Prefix);
                        host.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);
                        host.SetPreserveElements(unknownElement11.GetFullName());
                        host.SetPreserveAttributes(unknownAttribute11.GetFullName());

                        return (part.Uri, host.Path(), target.Path(), children);
                    }
                }

                var (partUri, hostPath, targetPath, expected) = Setup();

                var settings = new OpenSettings()
                {
                    MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.NoProcess, FileFormatVersions.Office2007),
                };

                using (var package = WordprocessingDocument.Open(stream, false, settings))
                {
                    var (host, target) = LocateElements(package, partUri, hostPath, targetPath);

                    VerifyMcAttribute(host, "Ignorable", unknownElement11.Prefix);
                    VerifyMcAttribute(host, "PreserveElements", unknownElement11.GetFullName());
                    VerifyMcAttribute(host, "PreserveAttributes", unknownAttribute11.GetFullName());

                    VerifyUnknownElement(target.LastChild, unknownElement11);
                    VerifyKnownChildren(target, expected);
                    VerifyUnknownElement(target.FirstChild.LastChild, unknownElement12);
                }
            }
        }

        [Fact]
        public void Preserve_Ignored_UnknownElement_InnerIgnorable_O12Mode()
        {
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            {
                (Uri, string, string, List<OpenXmlElement>, OpenXmlElement) Setup()
                {
                    using (var package = WordprocessingDocument.Open(stream, true))
                    {
                        var part = package.MainPart();
                        var dom = part.RootElement();
                        var host = dom
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement));
                        var target = host
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement));

                        var children = new List<OpenXmlElement>();

                        foreach (var d in target.ChildElements)
                        {
                            children.Add(d.CloneNode(true));
                        }

                        target.AppendChild(unknownElement11);
                        unknownElement11.SetAttribute(unknownAttribute11);
                        unknownElement11.SetAttribute(unprefixedAttribute);

                        var originalUnknownElement11 = unknownElement11.CloneNode(true);

                        // unknownAttribute12 should be ignored as it's not specified with PreserveAttributes.
                        unknownElement11.SetAttribute(unknownAttribute12);

                        target.FirstChild.SetIgnorable(unknownElement12.Prefix);
                        children[0] = target.FirstChild.CloneNode(true);   // hack to fix a issue - Ignorable will be preserved

                        // append unknown element(with unknown attributes) to first child
                        target.FirstChild.AppendChild(unknownElement12);
                        unknownElement12.SetAttribute(unknownAttribute11);
                        unknownElement12.SetAttribute(unknownAttribute12);

                        host.SetIgnorable(unknownElement11.Prefix);
                        host.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);
                        host.SetPreserveElements(unknownElement11.GetFullName());
                        host.SetPreserveAttributes(unknownAttribute11.GetFullName());

                        return (part.Uri, host.Path(), target.Path(), children, originalUnknownElement11);
                    }
                }

                var (partUri, hostPath, targetPath, expected, originalUnknownElement) = Setup();

                var settings = new OpenSettings()
                {
                    MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessAllParts, FileFormatVersions.Office2007),
                };

                using (var package = WordprocessingDocument.Open(stream, false, settings))
                {
                    var (_, target) = LocateElements(package, partUri, hostPath, targetPath);

                    VerifyUnknownElement(target.LastChild, originalUnknownElement);
                    VerifyAttribute(target.LastChild, unknownAttribute11);
                    VerifyAttribute(target.LastChild, unprefixedAttribute);
                    VerifyNoAttribute(target.LastChild, unknownAttribute12);
                    VerifyKnownChildren(target, expected);
                }
            }
        }

        [Fact]
        public void Validate_Preserve_Ignored_UnknownElement_InnerIgnorable()
        {
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            {
                using (var package = WordprocessingDocument.Open(stream, true))
                {
                    var part = package.MainPart();
                    var dom = part.RootElement();
                    var host = dom
                        .Elements()
                        .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && d.FirstChild is OpenXmlCompositeElement && !d.ChildElements.Any(c => c is OpenXmlUnknownElement));
                    var target = host
                        .Descendants()
                        .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && d.FirstChild is OpenXmlCompositeElement && !d.ChildElements.Any(c => c is OpenXmlUnknownElement));

                    // append unknown element(with unknown attributes) to first child
                    var firstChild = target.FirstChild;
                    firstChild.SetIgnorable(unknownElement12.Prefix);
                    firstChild.AppendChild(unknownElement12);

                    unknownElement12.SetAttribute(unknownAttribute11);
                    unknownElement12.SetAttribute(unknownAttribute12);

                    target.AppendChild(unknownElement11);
                    unknownElement11.SetAttribute(unknownAttribute11);
                    unknownElement11.SetAttribute(unknownAttribute12);
                    unknownElement11.SetAttribute(unprefixedAttribute);

                    host.SetIgnorable(unknownElement11.Prefix);
                    host.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);
                    host.SetPreserveElements(unknownElement11.GetFullName());
                    host.SetPreserveAttributes(unknownAttribute11.GetFullName());
                }

                using (var package = WordprocessingDocument.Open(stream, false))
                {
                    ValidateMarkupCompatibility(package, FileFormatVersions.Office2007, 0);
                }
            }
        }

        [Fact]
        public void Preserve_Ignored_UnknownElement_Wildcard_FullMode()
        {
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            {
                (Uri, string, string, List<OpenXmlElement>) Setup()
                {
                    using (var package = WordprocessingDocument.Open(stream, true))
                    {
                        var part = package.MainPart();
                        var dom = part.RootElement();
                        var host = dom
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement));
                        var target = host
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement));

                        var children = new List<OpenXmlElement>();

                        foreach (var d in target.ChildElements)
                        {
                            children.Add(d.CloneNode(true));
                        }

                        target.AppendChild(unknownElement11);
                        unknownElement11.SetAttribute(unknownAttribute11);
                        unknownElement11.SetAttribute(unknownAttribute12);
                        unknownElement11.SetAttribute(unprefixedAttribute);

                        host.SetIgnorable(unknownElement11.Prefix);
                        host.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);
                        host.SetPreserveElements("*");
                        host.SetPreserveAttributes("*");

                        return (part.Uri, host.Path(), target.Path(), children);
                    }
                }

                var (partUri, hostPath, targetPath, expected) = Setup();

                var settings = new OpenSettings()
                {
                    MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.NoProcess, FileFormatVersions.Office2007),
                };

                using (var package = WordprocessingDocument.Open(stream, false, settings))
                {
                    var (host, target) = LocateElements(package, partUri, hostPath, targetPath);

                    VerifyMcAttribute(host, "Ignorable", unknownElement11.Prefix);
                    VerifyMcAttribute(host, "PreserveElements", "*");
                    VerifyMcAttribute(host, "PreserveAttributes", "*");

                    VerifyUnknownElement(target.LastChild, unknownElement11);
                    VerifyKnownChildren(target, expected);
                }
            }
        }

        [Fact(Skip = "Currently failing")]
        public void Preserve_Ignored_UnknownElement_Wildcard_O12Mode()
        {
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            {
                (Uri, string, string, List<OpenXmlElement>, OpenXmlElement) Setup()
                {
                    using (var package = WordprocessingDocument.Open(stream, true))
                    {
                        var part = package.MainPart();
                        var dom = part.RootElement();
                        var host = dom
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement));
                        var target = host
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement));

                        var children = new List<OpenXmlElement>();

                        foreach (var d in target.ChildElements)
                        {
                            children.Add(d.CloneNode(true));
                        }

                        target.AppendChild(unknownElement11);
                        unknownElement11.SetAttribute(unknownAttribute11);
                        unknownElement11.SetAttribute(unprefixedAttribute);

                        // unknownAttribute12 should be ignored as it's not specified with PreserveAttributes.
                        var unknownCopy = unknownElement11.CloneNode(true);
                        unknownElement11.SetAttribute(unknownAttribute12);

                        host.SetIgnorable(unknownElement11.Prefix);
                        host.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);
                        host.SetPreserveElements("*");
                        host.SetPreserveAttributes("*");

                        return (part.Uri, host.Path(), target.Path(), children, unknownCopy);
                    }
                }

                var (partUri, hostPath, targetPath, expected, expectedElement) = Setup();

                var settings = new OpenSettings()
                {
                    MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.NoProcess, FileFormatVersions.Office2007),
                };

                using (var package = WordprocessingDocument.Open(stream, false, settings))
                {
                    var (host, target) = LocateElements(package, partUri, hostPath, targetPath);

                    VerifyUnknownElement(target.LastChild, expectedElement);
                    VerifyAttribute(target.LastChild, unknownAttribute11);
                    VerifyAttribute(target.LastChild, unprefixedAttribute);
                    VerifyNoAttribute(target.LastChild, unknownAttribute12);
                    VerifyKnownChildren(target, expected);
                }
            }
        }

        [Fact(Skip = "Found two unexpected validation errors")]
        public void Validate_Preserve_Ignored_UnknownElement_Wildcard()
        {
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            {
                using (var package = WordprocessingDocument.Open(stream, true))
                {
                    var part = package.MainPart();
                    var dom = part.RootElement();
                    var host = dom
                        .Descendants()
                        .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement));
                    var target = host
                        .Descendants()
                        .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement));

                    var unknownElement11 = new OpenXmlUnknownElement(prefixUnknown1, e1Unknown1, nsUnknown1);
                    var unknownAttribute11 = new OpenXmlAttribute(prefixUnknown1, a1Unknown1, nsUnknown1, "attribute1 from unknown namespace1.");
                    var unknownAttribute12 = new OpenXmlAttribute(prefixUnknown1, a2Unknown1, nsUnknown1, "attribute2 from unknown namespace1.");
                    var unprefixedAttribute = new OpenXmlAttribute(string.Empty, "name", null, "unprefixed attributes");

                    target.AppendChild(unknownElement11);
                    unknownElement11.SetAttribute(unknownAttribute11);
                    unknownElement11.SetAttribute(unknownAttribute12);
                    unknownElement11.SetAttribute(unprefixedAttribute);

                    host.SetIgnorable(unknownElement11.Prefix);
                    host.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);
                    host.SetPreserveElements("*");
                    host.SetPreserveAttributes("*");
                }

                using (var package = WordprocessingDocument.Open(stream, false))
                {
                    ValidateMarkupCompatibility(package, FileFormatVersions.Office2007, 0);
                }
            }
        }

        [Fact]
        public void Preserve_NonIgnored_UnknownElement_FullMode()
        {
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            {
                (Uri, string, string, List<OpenXmlElement>) Setup()
                {
                    using (var package = WordprocessingDocument.Open(stream, true))
                    {
                        var part = package.MainPart();
                        var dom = part.RootElement();
                        var host = dom
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement));
                        var target = host
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement));

                        var children = new List<OpenXmlElement>();

                        foreach (var d in target.ChildElements)
                        {
                            children.Add(d.CloneNode(true));
                        }

                        target.AppendChild(unknownElement11);
                        unknownElement11.SetAttribute(unknownAttribute11);
                        unknownElement11.SetAttribute(unknownAttribute12);
                        unknownElement11.SetAttribute(unprefixedAttribute);

                        host.SetPreserveElements(unknownElement11.GetFullName());
                        host.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);
                        host.SetPreserveAttributes(unknownAttribute11.GetFullName());

                        return (part.Uri, host.Path(), target.Path(), children);
                    }
                }

                var (partUri, hostPath, targetPath, expected) = Setup();

                var settings = new OpenSettings()
                {
                    MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.NoProcess, FileFormatVersions.Office2007),
                };

                using (var package = WordprocessingDocument.Open(stream, false, settings))
                {
                    var (host, target) = LocateElements(package, partUri, hostPath, targetPath);

                    VerifyMcAttribute(host, "PreserveElements", unknownElement11.GetFullName());
                    VerifyMcAttribute(host, "PreserveAttributes", unknownAttribute11.GetFullName());

                    VerifyUnknownElement(target.LastChild, unknownElement11);
                    VerifyKnownChildren(target, expected);
                }
            }
        }

        [Fact]
        public void Preserve_NonIgnored_UnknownElement_O12Mode()
        {
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            {
                (Uri part, string host, string target) Setup()
                {
                    using (var package = WordprocessingDocument.Open(stream, true))
                    {
                        var part = package.MainPart();
                        var host = part
                            .RootElement()
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement));
                        var target = host
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement));

                        var unknownElement = new OpenXmlUnknownElement(prefixUnknown1, e1Unknown1, nsUnknown1);
                        var unknownAttribute1 = new OpenXmlAttribute(prefixUnknown1, a1Unknown1, nsUnknown1, "attribute1 from unknown namespace1.");
                        var unknownAttribute2 = new OpenXmlAttribute(prefixUnknown1, a2Unknown1, nsUnknown1, "attribute2 from unknown namespace1.");
                        var unprefixedAttribute = new OpenXmlAttribute(string.Empty, "name", null, "unprefixed attributes");

                        target.AppendChild(unknownElement);
                        unknownElement.SetAttribute(unknownAttribute1);
                        unknownElement.SetAttribute(unknownAttribute2);
                        unknownElement.SetAttribute(unprefixedAttribute);

                        host.SetPreserveElements(unknownElement.GetFullName());
                        host.AddNamespaceDeclaration(unknownElement.Prefix, unknownElement.NamespaceUri);
                        host.SetPreserveAttributes(unknownAttribute1.GetFullName());

                        return (part.Uri, host.Path(), target.Path());
                    }
                }

                var result = Setup();
                var settings = new OpenSettings
                {
                    MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessAllParts, FileFormatVersions.Office2007),
                };

                using (var package = WordprocessingDocument.Open(stream, false, settings))
                {
                    var (host, target) = LocateElements(package, result.part, result.host, result.target);

                    Assert.NotNull(host);
                    Assert.NotNull(target);
                }
            }
        }

        [Fact]
        public void Validate_Preserve_NonIgnored_UnknownElement()
        {
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm))
            {
                using (var package = WordprocessingDocument.Open(stream, false))
                {
                    var part = package.MainPart();
                    var host = part
                        .RootElement()
                        .Descendants()
                        .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement));
                    var target = host
                        .Descendants()
                        .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement));

                    var unknownElement = new OpenXmlUnknownElement(prefixUnknown1, e1Unknown1, nsUnknown1);
                    var unknownAttribute1 = new OpenXmlAttribute(prefixUnknown1, a1Unknown1, nsUnknown1, "attribute1 from unknown namespace1.");
                    var unknownAttribute2 = new OpenXmlAttribute(prefixUnknown1, a2Unknown1, nsUnknown1, "attribute2 from unknown namespace1.");
                    var unprefixedAttribute = new OpenXmlAttribute(string.Empty, "name", null, "unprefixed attributes");

                    target.AppendChild(unknownElement);
                    unknownElement.SetAttribute(unknownAttribute1);
                    unknownElement.SetAttribute(unknownAttribute2);
                    unknownElement.SetAttribute(unprefixedAttribute);

                    host.SetPreserveElements(unknownElement.GetFullName());
                    host.AddNamespaceDeclaration(unknownElement.Prefix, unknownElement.NamespaceUri);
                    host.SetPreserveAttributes(unknownAttribute1.GetFullName());

                    ValidateMarkupCompatibility(package, FileFormatVersions.Office2007, 2);
                }
            }
        }

        [Fact]
        public void Preserve_NonIgnored_UnknownAttribute_FullMode()
        {
            var unknownElement = new OpenXmlUnknownElement(prefixUnknown1, e1Unknown1, nsUnknown1);
            var unknownAttribute = new OpenXmlAttribute(prefixUnknown1, a1Unknown1, nsUnknown1, "attribute1 from unknown namespace1.");

            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm))
            using (var package = WordprocessingDocument.Open(stream, false))
            {
                var part = package.MainPart();
                var host = part
                    .RootElement()
                    .Descendants()
                    .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement));
                var target = host
                    .Descendants()
                    .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement));

                host.SetPreserveAttributes(unknownAttribute.GetFullName());
                host.AddNamespaceDeclaration(unknownAttribute.Prefix, unknownAttribute.NamespaceUri);

                var children = target.ChildElements.Select(t => t.CloneNode(true)).ToList();
                target.AppendChild(unknownElement);

                unknownElement.SetAttribute(unknownAttribute);
                unknownElement.SetAttribute(unknownAttribute12);
                unknownElement.SetAttribute(unprefixedAttribute);

                var expectedElement = unknownElement.CloneNode(true);
                VerifyMcAttribute(host, "PreserveAttributes", unknownAttribute.GetFullName());

                VerifyUnknownElement(target.LastChild, expectedElement);
                VerifyKnownChildren(target, children);
            }
        }

        [Fact]
        public void Preserve_NonIgnored_UnknownAttribute_O12Mode()
        {
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            {
                (Uri, string, string, List<OpenXmlElement>) Setup()
                {
                    using (var package = WordprocessingDocument.Open(stream, true))
                    {
                        var part = package.MainPart();
                        var dom = part.RootElement();
                        var host = dom
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement));
                        var target = host
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement));

                        var children = new List<OpenXmlElement>();

                        foreach (var d in target.ChildElements)
                        {
                            children.Add(d.CloneNode(true));
                        }

                        target.AppendChild(unknownElement11);
                        unknownElement11.SetAttribute(unknownAttribute11);
                        unknownElement11.SetAttribute(unknownAttribute12);
                        unknownElement11.SetAttribute(unprefixedAttribute);

                        host.SetPreserveAttributes(unknownAttribute11.GetFullName());
                        host.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);

                        return (part.Uri, host.Path(), target.Path(), children);
                    }
                }

                var (partUri, hostPath, targetPath, expected) = Setup();

                var settings = new OpenSettings()
                {
                    MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessAllParts, FileFormatVersions.Office2007),
                };

                using (var package = WordprocessingDocument.Open(stream, false, settings))
                {
                    var (host, target) = LocateElements(package, partUri, hostPath, targetPath);

                    VerifyNoMcAttribute(host, "PreserveElements", unknownElement11.GetFullName());
                    VerifyMcAttribute(host, "PreserveAttributes", unknownAttribute11.GetFullName());

                    VerifyUnknownElement(target.LastChild, unknownElement11);
                    VerifyKnownChildren(target, expected);
                }
            }
        }

        [Fact]
        public void Validate_Preserve_NonIgnored_UnknownAttribute()
        {
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            {
                using (var package = WordprocessingDocument.Open(stream, true))
                {
                    var part = package.MainPart();
                    var dom = part.RootElement();
                    var host = dom
                        .Descendants()
                        .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement));
                    var target = host
                        .Descendants()
                        .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement));

                    var unknownElement = new OpenXmlUnknownElement(prefixUnknown1, e1Unknown1, nsUnknown1);
                    var unknownAttribute1 = new OpenXmlAttribute(prefixUnknown1, a1Unknown1, nsUnknown1, "attribute1 from unknown namespace1.");
                    var unknownAttribute2 = new OpenXmlAttribute(prefixUnknown1, a2Unknown1, nsUnknown1, "attribute2 from unknown namespace1.");
                    var unprefixedAttribute = new OpenXmlAttribute(string.Empty, "name", null, "unprefixed attributes");

                    target.AppendChild(unknownElement);
                    unknownElement.SetAttribute(unknownAttribute1);
                    unknownElement.SetAttribute(unknownAttribute2);
                    unknownElement.SetAttribute(unprefixedAttribute);

                    host.SetPreserveAttributes(unknownAttribute1.GetFullName());
                    host.AddNamespaceDeclaration(unknownAttribute1.Prefix, unknownAttribute1.NamespaceUri);
                }

                using (var package = WordprocessingDocument.Open(stream, true))
                {
                    ValidateMarkupCompatibility(package, FileFormatVersions.Office2007, 1);
                }
            }
        }

        [Fact]
        public void Preserve_NoElement_UnknownAttribute_FullMode()
        {
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            {
                (Uri, string, string, List<OpenXmlElement>) Setup()
                {
                    using (var package = WordprocessingDocument.Open(stream, true))
                    {
                        var part = package.MainPart();
                        var dom = part.RootElement();
                        var host = dom
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement));
                        var target = host
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement));

                        var children = new List<OpenXmlElement>();

                        foreach (var d in target.ChildElements)
                        {
                            children.Add(d.CloneNode(true));
                        }

                        target.AppendChild(unknownElement11);
                        unknownElement11.SetAttribute(unknownAttribute11);
                        unknownElement11.SetAttribute(unknownAttribute12);
                        unknownElement11.SetAttribute(unprefixedAttribute);

                        host.SetIgnorable(unknownElement11.Prefix);
                        host.AddNamespaceDeclaration(unknownAttribute11.Prefix, unknownAttribute11.NamespaceUri);
                        host.SetPreserveAttributes(unknownAttribute11.GetFullName());

                        return (part.Uri, host.Path(), target.Path(), children);
                    }
                }

                var (partUri, hostPath, targetPath, expected) = Setup();

                var settings = new OpenSettings()
                {
                    MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.NoProcess, FileFormatVersions.Office2007),
                };

                using (var package = WordprocessingDocument.Open(stream, false, settings))
                {
                    var (host, target) = LocateElements(package, partUri, hostPath, targetPath);

                    VerifyMcAttribute(host, "Ignorable", unknownElement11.Prefix);
                    VerifyMcAttribute(host, "PreserveAttributes", unknownAttribute11.GetFullName());

                    VerifyUnknownElement(target.LastChild, unknownElement11);
                    VerifyKnownChildren(target, expected);
                }
            }
        }

        [Fact]
        public void Preserve_NoElement_UnknownAttribute_O12Mode()
        {
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm))
            {
                (Uri part, string host, string target) Setup()
                {
                    using (var package = WordprocessingDocument.Open(stream, false))
                    {
                        var part = package.MainPart();
                        var host = part
                            .RootElement()
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement));
                        var target = host
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement));

                        var unknownElement = new OpenXmlUnknownElement(prefixUnknown1, e1Unknown1, nsUnknown1);
                        var unknownAttribute1 = new OpenXmlAttribute(prefixUnknown1, a1Unknown1, nsUnknown1, "attribute1 from unknown namespace1.");
                        var unknownAttribute2 = new OpenXmlAttribute(prefixUnknown1, a2Unknown1, nsUnknown1, "attribute2 from unknown namespace1.");
                        var unprefixedAttribute = new OpenXmlAttribute(string.Empty, "name", null, "unprefixed attributes");

                        target.AppendChild(unknownElement);
                        unknownElement.SetAttribute(unknownAttribute1);
                        unknownElement.SetAttribute(unknownAttribute2);
                        unknownElement.SetAttribute(unprefixedAttribute);

                        var expectedElement = unknownElement.CloneNode(true);

                        host.SetIgnorable(unknownElement.Prefix);
                        host.AddNamespaceDeclaration(unknownAttribute1.Prefix, unknownAttribute1.NamespaceUri);
                        host.SetPreserveAttributes(unknownAttribute1.GetFullName());

                        return (part.Uri, host.Path(), target.Path());
                    }
                }

                var paths = Setup();

                var settings = new OpenSettings()
                {
                    MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessAllParts, FileFormatVersions.Office2007),
                };

                using (var package = WordprocessingDocument.Open(stream, false, settings))
                {
                    LocateElements(package, paths.part, paths.host, paths.target);
                }
            }
        }

        [Fact]
        public void Validate_Preserve_NoElement_UnknownAttribute()
        {
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm))
            using (var package = WordprocessingDocument.Open(stream, false))
            {
                var part = package.MainPart();
                var host = part
                    .RootElement()
                    .Descendants()
                    .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement));
                var target = host
                    .Descendants()
                    .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && !d.ChildElements.Any(c => c is OpenXmlUnknownElement));

                var unknownElement = new OpenXmlUnknownElement(prefixUnknown1, e1Unknown1, nsUnknown1);
                var unknownAttribute1 = new OpenXmlAttribute(prefixUnknown1, a1Unknown1, nsUnknown1, "attribute1 from unknown namespace1.");
                var unknownAttribute2 = new OpenXmlAttribute(prefixUnknown1, a2Unknown1, nsUnknown1, "attribute2 from unknown namespace1.");
                var unprefixedAttribute = new OpenXmlAttribute(string.Empty, "name", null, "unprefixed attributes");

                target.AppendChild(unknownElement11);
                unknownElement.SetAttribute(unknownAttribute1);
                unknownElement.SetAttribute(unknownAttribute2);
                unknownElement.SetAttribute(unprefixedAttribute);

                host.SetIgnorable(unknownElement.Prefix);
                host.AddNamespaceDeclaration(unknownAttribute1.Prefix, unknownAttribute1.NamespaceUri);

                host.SetPreserveAttributes(unknownAttribute1.GetFullName());

                ValidateMarkupCompatibility(package, FileFormatVersions.Office2007, host.Path(), 1);
            }
        }
        #endregion Preserve Elements & Attributes

        #region MustUnderstand

        [Fact]
        public void MustUnderstand_Ignored_UnknownElement_FullMode()
        {
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            {
                (Uri, string, string, string) Setup()
                {
                    using (var package = WordprocessingDocument.Open(stream, true))
                    {
                        var part = package.MainPart();
                        var dom = part.RootElement();
                        var host = dom
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren);
                        var target = host
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren);

                        var children = new List<OpenXmlElement>();

                        WrapChildrenWithElement(target, unknownElement11, children);

                        var muhost = ChooseElementBetween(target, host.Path(), target.Path());
                        muhost.SetMustUnderstand(unknownElement11.Prefix);

                        host.SetIgnorable(unknownElement11.Prefix);
                        host.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);

                        return (part.Uri, host.Path(), target.Path(), muhost.Path());
                    }
                }

                var (partUri, hostPath, targetPath, muhostPath) = Setup();

                var settings = new OpenSettings()
                {
                    MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.NoProcess, FileFormatVersions.Office2007),
                };

                using (var package = WordprocessingDocument.Open(stream, false, settings))
                {
                    var (host, muhost) = LocateElements(package, partUri, hostPath, muhostPath);
                    var (_, target) = LocateElements(package, partUri, hostPath, targetPath);

                    VerifyMcAttribute(host, "Ignorable", unknownElement11.Prefix);
                    VerifyMcAttribute(muhost, "MustUnderstand", unknownElement11.Prefix);
                    VerifyUnknownElement(target.LastChild, unknownElement11);
                }
            }
        }

        [Fact]
        public void MustUnderstand_Ignored_UnknownElement_O12Mode()
        {
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            {
                (Uri, string, string, string) Setup()
                {
                    using (var package = WordprocessingDocument.Open(stream, true))
                    {
                        var part = package.MainPart();
                        var dom = part.RootElement();
                        var host = dom
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren);
                        var target = host
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren);

                        var children = new List<OpenXmlElement>();

                        WrapChildrenWithElement(target, unknownElement11, children);

                        var muhost = ChooseElementBetween(target, host.Path(), target.Path());
                        muhost.SetMustUnderstand(unknownElement11.Prefix);

                        host.SetIgnorable(unknownElement11.Prefix);
                        host.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);

                        return (part.Uri, host.Path(), target.Path(), muhost.Path());
                    }
                }

                var (partUri, hostPath, targetPath, muhostPath) = Setup();

                var settings = new OpenSettings()
                {
                    MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessAllParts, FileFormatVersions.Office2007),
                };

                using (var package = WordprocessingDocument.Open(stream, false, settings))
                {
                    var part = package
                        .DescendantParts()
                        .FirstOrDefault(p => p.Uri == partUri);

                    Assert.NotNull(part);
                    Assert.Throws<NamespaceNotUnderstandException>(() => part.RootElement());
                }
            }
        }

        [Fact]
        public void Validate_MustUnderstand_Ignored_UnknownElement()
        {
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            {
                string Setup()
                {
                    using (var package = WordprocessingDocument.Open(stream, true))
                    {
                        var part = package.MainPart();
                        var partUri = part.Uri.ToString();
                        var host = part
                            .RootElement()
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren);
                        var target = host
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren);

                        host.SetIgnorable(unknownElement11.Prefix);
                        host.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);

                        var children = new List<OpenXmlElement>();
                        WrapChildrenWithElement(target, unknownElement11, children);

                        var muhost = ChooseElementBetween(target, host.Path(), target.Path());
                        Log.Comment("Setting @MustUnderstand with value: {0} on {1}", unknownElement11.Prefix, muhost.Path());
                        muhost.SetMustUnderstand(unknownElement11.Prefix);

                        return host.Path();
                    }
                }

                var hostPath = Setup();

                using (var package = WordprocessingDocument.Open(stream, false))
                {
                    ValidateMarkupCompatibility(package, FileFormatVersions.Office2007, hostPath, 1);
                }
            }
        }

        [Fact]
        public void MustUnderstand_NonIgnored_UnknownElement_FullMode()
        {
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            {
                (Uri, string, string, string) Setup()
                {
                    using (var package = WordprocessingDocument.Open(stream, true))
                    {
                        var part = package.MainPart();
                        var dom = part.RootElement();
                        var host = dom
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren);
                        var target = host
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren);

                        var children = new List<OpenXmlElement>();

                        WrapChildrenWithElement(target, unknownElement11, children);

                        var muhost = ChooseElementBetween(target, host.Path(), target.Path());

                        muhost.SetMustUnderstand(unknownElement11.Prefix);
                        muhost.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);

                        return (part.Uri, host.Path(), target.Path(), muhost.Path());
                    }
                }

                var (partUri, hostPath, targetPath, muhostPath) = Setup();

                var settings = new OpenSettings()
                {
                    MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.NoProcess, FileFormatVersions.Office2007),
                };

                using (var package = WordprocessingDocument.Open(stream, false, settings))
                {
                    var (_, target) = LocateElements(package, partUri, hostPath, targetPath);
                    var (_, muhost) = LocateElements(package, partUri, hostPath, muhostPath);

                    VerifyMcAttribute(muhost, "MustUnderstand", unknownElement11.Prefix);
                    VerifyUnknownElement(target.LastChild, unknownElement11);
                }
            }
        }

        [Fact]
        public void MustUnderstand_NonIgnored_UnknownElement_O12Mode()
        {
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            {
                Uri Setup()
                {
                    using (var package = WordprocessingDocument.Open(stream, true))
                    {
                        var part = package.MainPart();
                        var dom = part.RootElement();
                        var host = dom
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren);
                        var target = host
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren);

                        var children = new List<OpenXmlElement>();

                        WrapChildrenWithElement(target, unknownElement11, children);

                        var muhost = ChooseElementBetween(target, host.Path(), target.Path());
                        muhost.SetMustUnderstand(unknownElement11.Prefix);
                        muhost.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);

                        return part.Uri;
                    }
                }

                var partUri = Setup();

                var settings = new OpenSettings()
                {
                    MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessAllParts, FileFormatVersions.Office2007),
                };

                using (var package = WordprocessingDocument.Open(stream, false, settings))
                {
                    var part = package
                        .DescendantParts()
                        .FirstOrDefault(p => p.Uri == partUri);

                    Assert.NotNull(part);
                    Assert.Throws<NamespaceNotUnderstandException>(() => part.RootElement());
                }
            }
        }

        [Fact]
        public void Validate_MustUnderstand_NonIgnored_UnknownElement()
        {
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm))
            {
                string hostPath = null;

                using (var package = WordprocessingDocument.Open(stream, false))
                {
                    var part = package.MainPart();
                    var dom = part.RootElement();
                    var host = dom
                        .Descendants()
                        .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren);
                    var target = host
                        .Descendants()
                        .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren);

                    var children = new List<OpenXmlElement>();
                    var expectedElement = target.CloneNode(true);

                    WrapChildrenWithElement(target, unknownElement11, children);

                    var muhost = ChooseElementBetween(target, host.Path(), target.Path());
                    muhost.SetMustUnderstand(unknownElement11.Prefix);
                    muhost.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);

                    hostPath = host.Path();
                }

                using (var package = WordprocessingDocument.Open(stream, false))
                {
                    ValidateMarkupCompatibility(package, FileFormatVersions.Office2007, hostPath, 1);
                }
            }
        }
        #endregion MustUnderstand

        #region AlternateContent
        [Fact]
        public void NoChoice_NoFallback_FullMode()
        {
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            {
                (Uri, string, AlternateContent, List<OpenXmlElement>) Setup()
                {
                    using (var package = WordprocessingDocument.Open(stream, true))
                    {
                        var part = package.MainPart();
                        var dom = part.RootElement();
                        var host = dom
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement && !d.ChildElements.Any(c => c is OpenXmlUnknownElement));

                        var children = new List<OpenXmlElement>();
                        var alternativeContent = appendEmptyChildACB(host, children).CloneNode(true) as AlternateContent;

                        return (part.Uri, host.Path(), alternativeContent, children);
                    }
                }

                var (partUri, hostPath, abc, expected) = Setup();

                var settings = new OpenSettings()
                {
                    MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.NoProcess, FileFormatVersions.Office2007),
                };

                using (var package = WordprocessingDocument.Open(stream, false, settings))
                {
                    var host = LocateElements(package, partUri, hostPath);

                    VerifyKnownElement(host.LastChild, abc);
                    VerifyKnownChildren(host, expected);
                }
            }
        }

        [Fact]
        public void NoChoice_NoFallback_O12Mode()
        {
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            {
                (Uri, string, AlternateContent, List<OpenXmlElement>) Setup()
                {
                    using (var package = WordprocessingDocument.Open(stream, true))
                    {
                        var part = package.MainPart();
                        var dom = part.RootElement();
                        var host = dom
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement && !d.ChildElements.Any(c => c is OpenXmlUnknownElement));

                        var children = new List<OpenXmlElement>();
                        var alternativeContent = appendEmptyChildACB(host, children).CloneNode(true) as AlternateContent;

                        return (part.Uri, host.Path(), alternativeContent, children);
                    }
                }

                var (partUri, hostPath, abc, expected) = Setup();

                var settings = new OpenSettings()
                {
                    MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessAllParts, FileFormatVersions.Office2007),
                };

                using (var package = WordprocessingDocument.Open(stream, false, settings))
                {
                    var host = LocateElements(package, partUri, hostPath);

                    VerifyKnownChildren(host, expected);
                }
            }
        }

        [Fact]
        public void Validate_NoChoice_NoFallback()
        {
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            {
                using (var package = WordprocessingDocument.Open(stream, true))
                {
                    var part = package.MainPart();
                    var dom = part.RootElement();
                    var host = dom
                        .Descendants()
                        .PickFirst(d => d is OpenXmlCompositeElement && !d.ChildElements.Any(c => c is OpenXmlUnknownElement));

                    var children = new List<OpenXmlElement>();
                    appendEmptyChildACB(host, children);
                }

                using (var package = WordprocessingDocument.Open(stream, false))
                {
                    ValidateMarkupCompatibility(package, FileFormatVersions.Office2007, 1);
                }
            }
        }

        [Fact]
        public void OneChoice_NoFallback_FullMode()
        {
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            {
                (Uri, string, OpenXmlElement, List<OpenXmlElement>) Setup()
                {
                    using (var package = WordprocessingDocument.Open(stream, true))
                    {
                        var part = package.MainPart();
                        var dom = part.RootElement();
                        var host = dom
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren);

                        var children = new List<OpenXmlElement>();
                        var alternateContent = wrapWithChoice(host, children).CloneNode(true);

                        return (part.Uri, host.Path(), alternateContent, children);
                    }
                }

                var (partUri, hostPath, acb, expected) = Setup();

                var settings = new OpenSettings()
                {
                    MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.NoProcess, FileFormatVersions.Office2007),
                };

                using (var package = WordprocessingDocument.Open(stream, false, settings))
                {
                    var host = LocateElements(package, partUri, hostPath);

                    VerifyKnownElement(host.LastChild, acb);
                    VerifyKnownChildren(host.LastChild.LastChild, expected);
                }
            }
        }

        [Fact]
        public void OneChoice_NoFallback_O12Mode()
        {
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            {
                (Uri, string, List<OpenXmlElement>) Setup()
                {
                    using (var package = WordprocessingDocument.Open(stream, true))
                    {
                        var part = package.MainPart();
                        var dom = part.RootElement();
                        var host = dom
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren);

                        var children = new List<OpenXmlElement>();
                        wrapWithChoice(host, children);

                        return (part.Uri, host.Path(), children);
                    }
                }

                var (partUri, hostPath, expected) = Setup();

                var settings = new OpenSettings()
                {
                    MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessAllParts, FileFormatVersions.Office2007),
                };

                using (var package = WordprocessingDocument.Open(stream, false, settings))
                {
                    var host = LocateElements(package, partUri, hostPath);

                    VerifyKnownChildren(host, expected);
                }
            }
        }

        [Fact]
        public void Validate_OneChoice_NoFallback()
        {
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            {
                using (var package = WordprocessingDocument.Open(stream, true))
                {
                    var part = package.MainPart();
                    var dom = part.RootElement();
                    var host = dom
                        .Descendants()
                        .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren);

                    var children = new List<OpenXmlElement>();
                    wrapWithChoice(host, children);
                }

                using (var package = WordprocessingDocument.Open(stream, true))
                {
                    ValidateMarkupCompatibility(package, FileFormatVersions.Office2007, 0);
                }
            }
        }

        [Fact]
        public void MultipleChoice_NoMatches_NoFallback_FullMode()
        {
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            {
                (Uri, string, OpenXmlElement) Setup()
                {
                    using (var package = WordprocessingDocument.Open(stream, true))
                    {
                        var part = package.MainPart();
                        var dom = part.RootElement();
                        var host = dom
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && d.ChildElements.Count > 1);

                        var children = new List<OpenXmlElement>();
                        var acb = wrapEachChildWithUnselectableChoice_NoFallback(host, children).CloneNode(true);

                        return (part.Uri, host.Path(), acb);
                    }
                }

                var (partUri, hostPath, expected) = Setup();

                var settings = new OpenSettings()
                {
                    MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.NoProcess, FileFormatVersions.Office2007),
                };

                using (var package = WordprocessingDocument.Open(stream, false, settings))
                {
                    var host = LocateElements(package, partUri, hostPath);

                    VerifyKnownElement(host.LastChild, expected);
                }
            }
        }

        [Fact]
        public void MultipleChoice_NoMatches_NoFallback_O12Mode()
        {
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            {
                (Uri, string, OpenXmlElement) Setup()
                {
                    using (var package = WordprocessingDocument.Open(stream, true))
                    {
                        var part = package.MainPart();
                        var dom = part.RootElement();
                        var host = dom
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && d.ChildElements.Count > 1);

                        var children = new List<OpenXmlElement>();
                        wrapEachChildWithUnselectableChoice_NoFallback(host, children);

                        return (part.Uri, host.Path(), host.CloneNode(false));
                    }
                }

                var (partUri, hostPath, expected) = Setup();

                var settings = new OpenSettings()
                {
                    MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessAllParts, FileFormatVersions.Office2007),
                };

                using (var package = WordprocessingDocument.Open(stream, false, settings))
                {
                    var host = LocateElements(package, partUri, hostPath);

                    VerifyKnownElement(host, expected);
                }
            }
        }

        [Fact]
        public void Validate_MultipleChoice_NoMatches_NoFallback()
        {
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            {
                using (var package = WordprocessingDocument.Open(stream, true))
                {
                    var part = package.MainPart();
                    var dom = part.RootElement();
                    var host = dom
                        .Descendants()
                        .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && d.ChildElements.Count > 1);

                    var children = new List<OpenXmlElement>();
                    wrapEachChildWithUnselectableChoice_NoFallback(host, children);
                }

                using (var package = WordprocessingDocument.Open(stream, false))
                {
                    ValidateMarkupCompatibility(package, FileFormatVersions.Office2007, 0);
                }
            }
        }

        [Fact]
        public void MultipleChoice_NoMatches_OneFallback_FullMode()
        {
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            {
                (Uri, string, OpenXmlElement) Setup()
                {
                    using (var package = WordprocessingDocument.Open(stream, true))
                    {
                        var part = package.MainPart();
                        var dom = part.RootElement();
                        var host = dom
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && d.ChildElements.Count > 1);

                        var children = new List<OpenXmlElement>();
                        var acb = wrapEachChildWithUnselectableChoice_OneFallback(host, children).CloneNode(true);

                        return (part.Uri, host.Path(), acb);
                    }
                }

                var (partUri, hostPath, expected) = Setup();

                var settings = new OpenSettings()
                {
                    MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.NoProcess, FileFormatVersions.Office2007),
                };

                using (var package = WordprocessingDocument.Open(stream, false, settings))
                {
                    var host = LocateElements(package, partUri, hostPath);

                    VerifyKnownElement(host.LastChild, expected);
                }
            }
        }

        [Fact]
        public void MultipleChoice_NoMatches_OneFallback_O12Mode()
        {
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            {
                (Uri, string, List<OpenXmlElement>) Setup()
                {
                    using (var package = WordprocessingDocument.Open(stream, true))
                    {
                        var part = package.MainPart();
                        var dom = part.RootElement();
                        var host = dom
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && d.ChildElements.Count > 1);

                        var children = new List<OpenXmlElement>();
                        wrapEachChildWithUnselectableChoice_OneFallback(host, children).CloneNode(true);

                        return (part.Uri, host.Path(), children);
                    }
                }

                var (partUri, hostPath, expected) = Setup();

                var settings = new OpenSettings()
                {
                    MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessAllParts, FileFormatVersions.Office2007),
                };

                using (var package = WordprocessingDocument.Open(stream, false, settings))
                {
                    var host = LocateElements(package, partUri, hostPath);

                    VerifyKnownChildren(host, expected);
                }
            }
        }

        [Fact]
        public void Validate_MultipleChoice_NoMatches_OneFallback()
        {
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            {
                using (var package = WordprocessingDocument.Open(stream, true))
                {
                    var part = package.MainPart();
                    var dom = part.RootElement();
                    var host = dom
                        .Descendants()
                        .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && d.ChildElements.Count > 1);

                    var children = new List<OpenXmlElement>();
                    wrapEachChildWithUnselectableChoice_OneFallback(host, children);
                }

                using (var package = WordprocessingDocument.Open(stream, false))
                {
                    ValidateMarkupCompatibility(package, FileFormatVersions.Office2007, 0);
                }
            }
        }

        [Fact]
        public void MultipleChoice_OneFallback_FullMode()
        {
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            {
                (Uri, string, OpenXmlElement) Setup()
                {
                    using (var package = WordprocessingDocument.Open(stream, true))
                    {
                        var part = package.MainPart();
                        var dom = part.RootElement();
                        var host = dom
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren);

                        var children = new List<OpenXmlElement>();
                        var acb = wrapEachChildWithChoice_OneFallback(host, children).CloneNode(true);

                        return (part.Uri, host.Path(), acb);
                    }
                }

                var (partUri, hostPath, expected) = Setup();

                var settings = new OpenSettings()
                {
                    MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.NoProcess, FileFormatVersions.Office2007),
                };

                using (var package = WordprocessingDocument.Open(stream, false, settings))
                {
                    var host = LocateElements(package, partUri, hostPath);

                    VerifyKnownElement(host.LastChild, expected);
                }
            }
        }

        [Fact]
        public void MultipleChoice_OneFallback_O12Mode()
        {
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            {
                (Uri part, string host, OpenXmlElement expected) Setup()
                {
                    using (var package = WordprocessingDocument.Open(stream, true))
                    {
                        var part = package.MainPart();
                        var host = part
                            .RootElement()
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren);

                        var children = new List<OpenXmlElement>();
                        wrapEachChildWithChoice_OneFallback(host, children);

                        return (part.Uri, host.Path(), children[0]);
                    }
                }

                var result = Setup();

                var settings = new OpenSettings
                {
                    MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessAllParts, FileFormatVersions.Office2007),
                };

                using (var package = WordprocessingDocument.Open(stream, false, settings))
                {
                    var host = LocateElements(package, result.part, result.host);

                    VerifyKnownElement(host.FirstChild, result.expected);
                }
            }
        }

        [Fact]
        public void Validate_MultipleChoice_OneFallback()
        {
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            {
                using (var package = WordprocessingDocument.Open(stream, true))
                {
                    var part = package.MainPart();
                    var dom = part.RootElement();
                    var host = dom
                        .Descendants()
                        .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren);

                    var children = new List<OpenXmlElement>();
                    wrapEachChildWithChoice_OneFallback(host, children);
                }

                using (var package = WordprocessingDocument.Open(stream, false))
                {
                    ValidateMarkupCompatibility(package, FileFormatVersions.Office2007, 0);
                }
            }
        }

        [Fact]
        public void MultipleChoice_LeadingFallback_FullMode()
        {
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            {
                (Uri, string, OpenXmlElement) Setup()
                {
                    using (var package = WordprocessingDocument.Open(stream, true))
                    {
                        var part = package.MainPart();
                        var host = part
                            .RootElement()
                            .Descendants()
                            .PickFirst(d => d is Wordprocessing.Run && d.HasChildren && d.ChildElements.Count == 1);

                        var children = new List<OpenXmlElement>();
                        var acb = wrapEachChildWithChoice_LeadingFallback(host, children).CloneNode(true);

                        return (part.Uri, host.Path(), acb);
                    }
                }

                var (partUri, hostPath, expected) = Setup();

                var settings = new OpenSettings
                {
                    MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.NoProcess, FileFormatVersions.Office2007),
                };

                using (var package = WordprocessingDocument.Open(stream, false, settings))
                {
                    var host = LocateElements(package, partUri, hostPath);

                    VerifyKnownElement(host.FirstChild, expected);
                }
            }
        }

        [Fact]
        public void MultipleChoice_LeadingFallback_O12Mode()
        {
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            {
                (Uri, string, OpenXmlElement, List<OpenXmlElement>) Setup()
                {
                    using (var package = WordprocessingDocument.Open(stream, true))
                    {
                        var part = package.MainPart();
                        var host = part
                            .RootElement()
                            .Descendants()
                            .PickFirst(d => d is Wordprocessing.Run && d.HasChildren && d.ChildElements.Count == 1);

                        var childrenList = new List<OpenXmlElement>();
                        var acb = wrapEachChildWithChoice_LeadingFallback(host, childrenList).CloneNode(true);

                        return (part.Uri, host.Path(), acb, childrenList);
                    }
                }

                var (partUri, hostPath, expected, children) = Setup();

                var settings = new OpenSettings
                {
                    MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessAllParts, FileFormatVersions.Office2007),
                };

                using (var package = WordprocessingDocument.Open(stream, false, settings))
                {
                    var host = LocateElements(package, partUri, hostPath);

                    Assert.ThrowsAny<Exception>(() => VerifyKnownElement(host, expected));
                    VerifyKnownChildren(host, children);
                }
            }
        }

        [Fact]
        public void Validate_MultipleChoice_LeadingFallback()
        {
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm))
            using (var package = WordprocessingDocument.Open(stream, false))
            {
                var part = package.MainPart();
                var dom = part.RootElement();
                var host = dom
                    .Descendants()
                    .OfType<Wordprocessing.Run>()
                    .FirstOrDefault(d => d.HasChildren && d.ChildElements.Count == 1);
                var children = new List<OpenXmlElement>();

                wrapEachChildWithChoice_LeadingFallback(host, children);

                ValidateMarkupCompatibility(package, FileFormatVersions.Office2007, 1);
            }
        }

        [Fact]
        public void OneChoice_MultipleFallback_FullMode()
        {
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            {
                (Uri, string, OpenXmlElement) Setup()
                {
                    using (var package = WordprocessingDocument.Open(stream, true))
                    {
                        var part = package.MainPart();
                        var dom = part.RootElement();
                        var host = dom
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && d.ChildElements.Count > 1);

                        var acb = WrapEachChildWithFallback_OneChoice(host);

                        return (part.Uri, host.Path(), acb);
                    }
                }

                var (partUri, hostPath, expected) = Setup();

                using (var package = WordprocessingDocument.Open(stream, false))
                {
                    var host = LocateElements(package, partUri, hostPath);

                    VerifyKnownElement(host.FirstChild, expected);
                }
            }
        }

        [Fact]
        public void OneChoice_MultipleFallback_O12Mode()
        {
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            {
                (Uri, string, OpenXmlElement) Setup()
                {
                    using (var package = WordprocessingDocument.Open(stream, true))
                    {
                        var part = package.MainPart();
                        var host = part
                            .RootElement()
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && d.ChildElements.Count > 1);

                        var original = host.CloneNode(true);
                        WrapEachChildWithFallback_OneChoice(host);

                        return (part.Uri, host.Path(), original);
                    }
                }

                var (partUri, hostPath, expected) = Setup();

                var settings = new OpenSettings
                {
                    MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessAllParts, FileFormatVersions.Office2007),
                };

                using (var package = WordprocessingDocument.Open(stream, false, settings))
                {
                    var host = LocateElements(package, partUri, hostPath);

                    VerifyKnownElement(host, expected);
                }
            }
        }

        [Fact]
        public void Validate_OneChoice_MultipleFallback()
        {
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm))
            using (var package = WordprocessingDocument.Open(stream, false))
            {
                var host = package
                    .MainPart()
                    .RootElement()
                    .Descendants().PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && d.ChildElements.Any());

                WrapEachChildWithFallback_OneChoice(host);

                ValidateMarkupCompatibility(package, FileFormatVersions.Office2007, 1000);
            }
        }

        [Fact]
        public void MustUnderstand_Unselected_FullMode()
        {
            const string nsUnknown1 = "http://test.openxmlsdk.microsoft.com/unknownns1";
            const string prefixUnknown1 = "uns1";
            const string e1Unknown1 = "e1uk1";
            var unknownElement11 = new OpenXmlUnknownElement(prefixUnknown1, e1Unknown1, nsUnknown1);

            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            {
                (Uri, string, OpenXmlElement) Setup()
                {
                    using (var package = WordprocessingDocument.Open(stream, true))
                    {
                        var part = package.MainPart();
                        var host = part
                            .RootElement()
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && d.ChildElements.Count > 1);

                        var children = new List<OpenXmlElement>();
                        var acb = wrapEachChildWithChoice_NoFallback(host, children);
                        var firstChoice = acb.FirstOrDefault(c => c is AlternateContentChoice) as AlternateContentChoice;
                        firstChoice.Requires = string.Empty;
                        firstChoice.SetRequires(unknownElement11.Prefix);
                        firstChoice.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);
                        firstChoice.AppendChild(unknownElement11);

                        return (part.Uri, host.Path(), acb);
                    }
                }

                var (partUri, hostPath, expected) = Setup();

                var settings = new OpenSettings
                {
                    MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.NoProcess, FileFormatVersions.Office2007),
                };

                using (var package = WordprocessingDocument.Open(stream, false, settings))
                {
                    var host = LocateElements(package, partUri, hostPath);

                    VerifyKnownElement(host.LastChild, expected);
                }
            }
        }

        [Fact]
        public void MustUnderstand_Unselected_O12Mode()
        {
            const string nsUnknown1 = "http://test.openxmlsdk.microsoft.com/unknownns1";
            const string prefixUnknown1 = "uns1";
            const string e1Unknown1 = "e1uk1";
            var unknownElement11 = new OpenXmlUnknownElement(prefixUnknown1, e1Unknown1, nsUnknown1);

            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            {
                (Uri, string, OpenXmlElement) Setup()
                {
                    using (var package = WordprocessingDocument.Open(stream, true))
                    {
                        var part = package.MainPart();
                        var host = part
                            .RootElement()
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren && d.ChildElements.Count > 1);

                        var children = new List<OpenXmlElement>();
                        var acb = wrapEachChildWithChoice_NoFallback(host, children);
                        var firstChoice = acb.FirstOrDefault(c => c is AlternateContentChoice) as AlternateContentChoice;
                        firstChoice.Requires = string.Empty;
                        firstChoice.SetRequires(unknownElement11.Prefix);
                        firstChoice.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);
                        firstChoice.AppendChild(unknownElement11);

                        return (part.Uri, host.Path(), children[1]);
                    }
                }

                var (partUri, hostPath, expected) = Setup();

                var settings = new OpenSettings
                {
                    MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessAllParts, FileFormatVersions.Office2007),
                };

                using (var package = WordprocessingDocument.Open(stream, false, settings))
                {
                    var host = LocateElements(package, partUri, hostPath);

                    Assert.Single(host.ChildElements);

                    VerifyKnownElement(host.LastChild, expected);
                }
            }
        }

        [Fact]
        public void Validate_MustUnderstand_Unselected()
        {
            const string nsUnknown1 = "http://test.openxmlsdk.microsoft.com/unknownns1";
            const string prefixUnknown1 = "uns1";
            const string e1Unknown1 = "e1uk1";

            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            {
                string hostPath = null;

                using (var package = WordprocessingDocument.Open(stream, true))
                {
                    var part = package.MainPart();
                    var dom = part.RootElement();
                    var host = dom
                        .Descendants()
                        .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren);

                    hostPath = host.Path();

                    var unknownElement11 = new OpenXmlUnknownElement(prefixUnknown1, e1Unknown1, nsUnknown1);

                    var children = new List<OpenXmlElement>();
                    var acb = wrapEachChildWithChoice_NoFallback(host, children);
                    var firstChoice = acb.OfType<AlternateContentChoice>().First();

                    firstChoice.Requires = string.Empty;
                    firstChoice.SetRequires(unknownElement11.Prefix);
                    firstChoice.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);
                    firstChoice.AppendChild(unknownElement11);
                }

                using (var package = WordprocessingDocument.Open(stream, false))
                {
                    ValidateMarkupCompatibility(package, FileFormatVersions.Office2007, hostPath, 0);
                }
            }
        }

        [Fact]
        public void MultipleChoice_OneFallback_Ignorable_FullMode()
        {
            const string nsUnknown1 = "http://test.openxmlsdk.microsoft.com/unknownns1";
            const string prefixUnknown1 = "uns1";
            const string e1Unknown1 = "e1uk1";
            var unknownElement11 = new OpenXmlUnknownElement(prefixUnknown1, e1Unknown1, nsUnknown1);

            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            {
                (Uri, string, OpenXmlElement) Setup()
                {
                    using (var package = WordprocessingDocument.Open(stream, true))
                    {
                        var part = package.MainPart();
                        var host = part
                            .RootElement()
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren);

                        var children = new List<OpenXmlElement>();
                        var acb = wrapEachChildWithChoice_OneFallback(host, children);

                        acb.SetIgnorable(unknownElement11.Prefix);
                        acb.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);
                        acb.SetAttribute(unknownAttribute11);
                        acb.AppendChild(unknownElement11);

                        return (part.Uri, host.Path(), acb);
                    }
                }

                var (partUri, hostPath, expected) = Setup();

                var settings = new OpenSettings
                {
                    MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.NoProcess, FileFormatVersions.Office2007),
                };

                using (var package = WordprocessingDocument.Open(stream, false, settings))
                {
                    var host = LocateElements(package, partUri, hostPath);

                    VerifyKnownElement(host.LastChild, expected);
                }
            }
        }

        [Fact]
        public void MultipleChoice_OneFallback_Ignorable_O12Mode()
        {
            const string nsUnknown1 = "http://test.openxmlsdk.microsoft.com/unknownns1";
            const string prefixUnknown1 = "uns1";
            const string e1Unknown1 = "e1uk1";
            var unknownElement11 = new OpenXmlUnknownElement(prefixUnknown1, e1Unknown1, nsUnknown1);

            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            {
                (Uri, string, OpenXmlElement) Setup()
                {
                    using (var package = WordprocessingDocument.Open(stream, true))
                    {
                        var part = package.MainPart();
                        var host = part
                            .RootElement()
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren);

                        var children = new List<OpenXmlElement>();
                        var acb = wrapEachChildWithChoice_OneFallback(host, children);

                        acb.SetIgnorable(unknownElement11.Prefix);
                        acb.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);
                        acb.SetAttribute(unknownAttribute11);
                        acb.AppendChild(unknownElement11);

                        return (part.Uri, host.Path(), children[0]);
                    }
                }

                var (partUri, hostPath, expected) = Setup();

                var settings = new OpenSettings
                {
                    MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessAllParts, FileFormatVersions.Office2007),
                };

                using (var package = WordprocessingDocument.Open(stream, false, settings))
                {
                    var host = LocateElements(package, partUri, hostPath);

                    VerifyKnownElement(host.FirstChild, expected);
                }
            }
        }

        [Fact]
        public void Validate_MultipleChoice_OneFallback_Ignorable()
        {
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            {
                using (var package = WordprocessingDocument.Open(stream, true))
                {
                    var part = package.MainPart();
                    var dom = part.RootElement();
                    var host = dom
                        .Descendants()
                        .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren);

                    var unknownElement11 = new OpenXmlUnknownElement(prefixUnknown1, e1Unknown1, nsUnknown1);
                    var unknownAttribute11 = new OpenXmlAttribute(prefixUnknown1, a1Unknown1, nsUnknown1, "attribute1 from unknown namespace1.");

                    var children = new List<OpenXmlElement>();
                    var acb = wrapEachChildWithChoice_OneFallback(host, children);
                    Log.Comment("Setting mc:Ignorable = {0} @{1}...", unknownElement11.Prefix, acb.Path());
                    acb.SetIgnorable(unknownElement11.Prefix);
                    acb.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);
                    acb.SetAttribute(unknownAttribute11);
                    acb.AppendChild(unknownElement11);
                }

                using (var package = WordprocessingDocument.Open(stream, false))
                {
                    ValidateMarkupCompatibility(package, FileFormatVersions.Office2007, 1);
                }
            }
        }

        [Fact]
        public void MultipleChoice_OneFallback_UnPrefixedMCAttributes_FullMode()
        {
            const string nsUnknown1 = "http://test.openxmlsdk.microsoft.com/unknownns1";
            const string prefixUnknown1 = "uns1";
            const string e1Unknown1 = "e1uk1";
            var unknownElement11 = new OpenXmlUnknownElement(prefixUnknown1, e1Unknown1, nsUnknown1);

            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            {
                (Uri, string, OpenXmlElement) Setup()
                {
                    using (var package = WordprocessingDocument.Open(stream, true))
                    {
                        var part = package.MainPart();
                        var host = part
                            .RootElement()
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren);

                        var unPrefixedIgnorable = new OpenXmlAttribute(string.Empty, "Ignorable", string.Empty, unknownElement11.Prefix);

                        var children = new List<OpenXmlElement>();
                        var acb = wrapEachChildWithChoice_OneFallback(host, children);

                        acb.SetAttribute(unPrefixedIgnorable);
                        acb.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);
                        acb.SetAttribute(unknownAttribute11);
                        acb.AppendChild(unknownElement11);

                        return (part.Uri, host.Path(), acb);
                    }
                }

                var (partUri, hostPath, expected) = Setup();

                var settings = new OpenSettings
                {
                    MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.NoProcess, FileFormatVersions.Office2007),
                };

                using (var package = WordprocessingDocument.Open(stream, false, settings))
                {
                    var host = LocateElements(package, partUri, hostPath);

                    VerifyKnownElement(host.LastChild, expected);
                }
            }
        }

        [Fact]
        public void MultipleChoice_OneFallback_UnPrefixedMCAttributes_O12Mode()
        {
            const string nsUnknown1 = "http://test.openxmlsdk.microsoft.com/unknownns1";
            const string prefixUnknown1 = "uns1";
            const string e1Unknown1 = "e1uk1";
            var unknownElement11 = new OpenXmlUnknownElement(prefixUnknown1, e1Unknown1, nsUnknown1);

            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            {
                (Uri, string, OpenXmlElement) Setup()
                {
                    using (var package = WordprocessingDocument.Open(stream, true))
                    {
                        var part = package.MainPart();
                        var host = part
                            .RootElement()
                            .Descendants()
                            .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren);

                        var unPrefixedIgnorable = new OpenXmlAttribute(string.Empty, "Ignorable", string.Empty, unknownElement11.Prefix);

                        var children = new List<OpenXmlElement>();
                        var acb = wrapEachChildWithChoice_OneFallback(host, children);

                        acb.SetAttribute(unPrefixedIgnorable);
                        acb.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);
                        acb.SetAttribute(unknownAttribute11);
                        acb.AppendChild(unknownElement11);

                        return (part.Uri, host.Path(), children[0]);
                    }
                }

                var (partUri, hostPath, expected) = Setup();

                var settings = new OpenSettings
                {
                    MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessAllParts, FileFormatVersions.Office2007),
                };

                using (var package = WordprocessingDocument.Open(stream, false, settings))
                {
                    var host = LocateElements(package, partUri, hostPath);

                    VerifyKnownElement(host.FirstChild, expected);
                }
            }
        }

        [Fact(Skip = "Fails with an argument null in schema validator")]
        public void Validate_MultipleChoice_OneFallback_UnPrefixedMCAttributes()
        {
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm))
            using (var package = WordprocessingDocument.Open(stream, false))
            {
                var part = package.MainPart();
                var dom = part.RootElement();
                var host = dom
                    .Descendants()
                    .PickFirst(d => d is OpenXmlCompositeElement && d.HasChildren);

                var unknownElement11 = new OpenXmlUnknownElement(prefixUnknown1, e1Unknown1, nsUnknown1);
                var unPrefixedIgnorable = new OpenXmlAttribute(string.Empty, "Ignorable", string.Empty, unknownElement11.Prefix);
                var unknownAttribute11 = new OpenXmlAttribute(prefixUnknown1, a1Unknown1, nsUnknown1, "attribute1 from unknown namespace1.");

                var children = new List<OpenXmlElement>();
                var acb = wrapEachChildWithChoice_OneFallback(host, children);
                acb.SetAttribute(unPrefixedIgnorable);
                acb.AddNamespaceDeclaration(unknownElement11.Prefix, unknownElement11.NamespaceUri);
                acb.SetAttribute(unknownAttribute11);
                acb.AppendChild(unknownElement11);

                ValidateMarkupCompatibility(package, FileFormatVersions.Office2007, 0);
            }
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

        private AlternateContent WrapEachChildWithFallback_OneChoice(OpenXmlElement e)
        {
            var acb = new AlternateContent();
            var choice = new AlternateContentChoice();
            var elements = e.ChildElements.Concat(new OpenXmlElement[] { e })
                .Where(d => !(d is OpenXmlUnknownElement || d is OpenXmlMiscNode))
                .Select(d => d.Prefix)
                .Distinct();

            foreach (var prefix in elements)
            {
                choice.SetRequires(prefix);
            }

            acb.AppendChild(choice);

            foreach (var c in e.ChildElements)
            {
                var fallback = new AlternateContentFallback();

                choice.AppendChild(c.CloneNode(true));
                fallback.AppendChild(c.CloneNode(true));

                acb.AppendChild(fallback);
            }

            e.RemoveAllChildren();
            return e.AppendChild(acb);
        }

        #endregion AlternateContent

        #region Helpers

        private OpenXmlElement LocateElements(OpenXmlPackage package, Uri partUri, string hostPath)
        {
            return LocateElements(package, partUri, hostPath, null).host;
        }

        private (OpenXmlElement host, OpenXmlElement target) LocateElements(OpenXmlPackage package, Uri partUri, string hostPath, string targetPath)
        {
            var part = package
                .DescendantParts()
                .FirstOrDefault(p => p.Uri == partUri);

            Assert.NotNull(part);

            var dom = part.RootElement();

            Assert.NotNull(dom);

            var host = dom
                .Descendants()
                .Union(new OpenXmlElement[] { dom })
                .FirstOrDefault(d => d.Path() == hostPath);

            Assert.NotNull(host);

            if (targetPath == null)
            {
                return (host, null);
            }

            var target = host
                .Descendants()
                .Union(new OpenXmlElement[] { host })
                .FirstOrDefault(d => d.Path() == targetPath);

            Assert.NotNull(target);

            return (host, target);
        }

        private OpenXmlElement ChooseElementBetween(OpenXmlElement target, string startPath, string endPath)
        {
            OpenXmlElement pchost = null;
            if (startPath == endPath)
                pchost = target;
            else
                pchost = target.Ancestors().TakeWhile(a => a.Path().StartsWith(startPath)).Union(new OpenXmlElement[] { target }).PickSecond();
            return pchost;
        }

        private void WrapChildrenWithElement(OpenXmlElement host, OpenXmlElement wrapper, List<OpenXmlElement> children)
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

        private void ValidateMarkupCompatibility(OpenXmlPackage package, FileFormatVersions fileformat, int expectedErrors)
        {
            var validator = new OpenXmlValidator(fileformat);
            var errors = validator.Validate(package)
                .Where(e => e.ErrorType == ValidationErrorType.MarkupCompatibility)
                .ToList();

            Assert.Equal(expectedErrors, errors.Count);
        }

        private void ValidateMarkupCompatibility(OpenXmlPackage package, FileFormatVersions fileformat, string path, int expectedCount)
        {
            var validator = new OpenXmlValidator(fileformat);
            var errors = validator.Validate(package)
                .Where(e => e.ErrorType == ValidationErrorType.MarkupCompatibility || (e.ErrorType == ValidationErrorType.Schema && e.Node.Path().StartsWith(path)));

            Assert.Equal(expectedCount, errors.Count());
        }

        #endregion Helpers

        #region Verify Methods

        private void VerifyMcAttribute(OpenXmlElement host, string mcName, string expectedValue)
        {
            Log.Comment("Verifying {0} attribute is set correctly.", mcName);
            var hasAttribute = host.GetAttributes().Where(a => a.LocalName == mcName && a.Value == expectedValue).FirstOrDefault() != default(OpenXmlAttribute);
            if (hasAttribute)
                Log.Pass("{0} is set correctly.", mcName);
            else
                Log.Fail("{0} does NOT exist or is set wrong value.", mcName);
        }

        private void VerifyNoMcAttribute(OpenXmlElement host, string mcName, string expectedValue)
        {
            Log.Comment("Verifing {0} attribute is filtered out...", mcName);
            var hasAttribute = host.GetAttributes().Where(a => a.LocalName == "Ignorable" && a.Value == expectedValue).FirstOrDefault() != default(OpenXmlAttribute);
            if (hasAttribute)
                Log.Fail("{0} attribute still exist on host element:{1}", mcName, host.Path());
            else
                Log.Pass("{0} attribute does NOT exist on host element:{1}", mcName, host.Path());
        }

        private void VerifyAttribute(OpenXmlElement host, OpenXmlAttribute expectedAttribute)
        {
            var verified = host
                .GetAttributes()
                .Where(a => a.Prefix == expectedAttribute.Prefix && a.LocalName == expectedAttribute.LocalName && a.Value == expectedAttribute.Value)
                .FirstOrDefault();

            Assert.True(verified != default(OpenXmlAttribute));
        }

        private void VerifyNoAttribute(OpenXmlElement host, OpenXmlAttribute expectedAttribute)
        {
            Log.Comment("Verifying attribute {0} does NOT exist....", expectedAttribute.GetFullName());
            var exist = host.GetAttributes().Any(a => a == expectedAttribute);
            if (exist)
                Log.Fail("Verifyied attribute {0} exist with value {1}.", expectedAttribute.GetFullName(), expectedAttribute.Value);
            else
                Log.Pass("Verified attribute {0} NOT exist with value {1}.", expectedAttribute.GetFullName(), expectedAttribute.Value);
        }

        private void VerifyExtendedAttribute(OpenXmlElement host, OpenXmlAttribute expectedAttribute)
        {
            Log.Comment("Verifying unknown attribute is loaded as extended...");
            if (host.ExtendedAttributes.Any(ea => ea == expectedAttribute))
                Log.Pass("Verified attribute {0} from unknown ns is loaded as Extended attribute.", expectedAttribute.GetFullName());
            else
                Log.Fail("Attribute {0} from unknown ns is NOT loaded as Extended attribute.", expectedAttribute.GetFullName());
        }

        private void VerifyNoExtendedAttribute(OpenXmlElement host, OpenXmlAttribute expectedAttribute)
        {
            Log.Comment("Verifying unknown attribute is ignored...");
            var verified = !host.ExtendedAttributes.Any(ea => ea == expectedAttribute);
            if (verified)
                Log.Pass("Attribute {0} from unknown ns is NOT loaded as Extended attribute.", expectedAttribute.GetFullName());
            else
                Log.Fail("Attribute {0} from unknown ns is loaded as Extended attribute.", expectedAttribute.GetFullName());
        }

        private void VerifyKnownAttribute(OpenXmlElement host, OpenXmlAttribute expectedAttribute)
        {
            Log.Comment("Verifying known attribute is loaded as built-in attribute...");
            var verified = (host.GetAttributes().First() == expectedAttribute) && host.ExtendedAttributes.All(ea => ea != expectedAttribute);
            if (verified)
                Log.Pass("Verified attribute {0} from kown ns is loaded as built-in attribute.", expectedAttribute.GetFullName());
            else
                Log.Fail("Attribute {0} from known ns is NOT loaded as built-in attribute.", expectedAttribute.GetFullName());
        }

        private void VerifyUnknownElement(OpenXmlElement host, OpenXmlElement expectedElement)
        {
            Assert.IsType<OpenXmlUnknownElement>(host);
            Assert.True(host.ToXElement().Compare(expectedElement.ToXElement()));
        }

        private void VerifyNoUnknownElement(OpenXmlElement host, OpenXmlElement expectedElement)
        {
            Log.Comment("Verifying unknown element is ignored...");
            var unknown = (host is OpenXmlUnknownElement) && host.ToXElement().Compare(expectedElement.ToXElement());
            if (unknown)
                Log.Fail("Element {0} from unknown ns is loaded as OpenXmlUnknownElement.", expectedElement.GetFullName());
            else
                Log.Pass("Element {0} from unknown ns is NOT loaded as OpenXmlUnknownElement.", expectedElement.GetFullName());
        }

        private void VerifyKnownElement(OpenXmlElement host, OpenXmlElement expectedElement)
        {
            Log.Comment("Verifying known element is loaded as strongly typed...");
            var known = !(host is OpenXmlUnknownElement) && host.ToXElement().Compare(expectedElement.ToXElement());
            if (known)
                Log.Pass("Verified element {0} from kown ns is loaded as strongly typed {1}.", expectedElement.GetFullName(), host.GetType().FullName);
            else
                Log.Fail("Element {0} from known ns is NOT loaded as strongly typed.", expectedElement.GetFullName());
        }

        private void VerifyUnknownChildren(OpenXmlElement host, List<OpenXmlElement> children)
        {
            if (host is OpenXmlUnknownElement)
                Log.Warning("Host element {0} IS OpenXmlUnknownElement.", host.GetFullName());

            Log.Comment("Verifying content of unknown element is loaded as OpenXmlUnkownElement...");
            for (int i = 0; i < children.Count; i++)
                if (!(host.ChildElements[i] is OpenXmlUnknownElement) || !host.ChildElements[i].ToXElement().Compare(children[i].ToXElement()))
                    Log.Fail("Element {0} under unknown element is NOT loaded as OpenXmlUnknownElement.", host.ChildElements[i].GetFullName());
                else
                    Log.Pass("Verified element {0} under unknown element is loaded as OpenXmlUnknownElement.", host.ChildElements[i].GetFullName());
        }

        private void VerifyKnownChildren(OpenXmlElement parent, List<OpenXmlElement> children)
        {
            Log.Comment("Verifying each child element is loaded as strongly typed element...");
            for (int i = 0; i < children.Count; i++)
                if (!(parent.ChildElements[i] is OpenXmlUnknownElement) && parent.ChildElements[i].ToXElement().Compare(children[i].ToXElement()))
                    Log.Pass("Verified child element {0} is loaded as {1}.", parent.ChildElements[i].GetFullName(), parent.ChildElements[i].GetType().FullName);
                else
                    Log.Fail("Child elements {0} is NOT loaded as strongly typed or changed.", parent.ChildElements[i].GetFullName());
        }

        private void VerifyNoUnkownChild(OpenXmlElement host, string qualified)
        {
            Log.Comment("Verifying NO unknown child element exist...");
            var hasUnknown = host.ChildElements.Any(c => (c is OpenXmlUnknownElement) && (c.GetFullName() == qualified));
            if (!hasUnknown)
                Log.Pass("Verified NO element {0} from unknown ns exist.", qualified);
            else
                Log.Fail("Element {0} from unknown ns is loaded as OpenXmlUnknownElement.", qualified);
        }

        #endregion Verify Methods
    }
}
