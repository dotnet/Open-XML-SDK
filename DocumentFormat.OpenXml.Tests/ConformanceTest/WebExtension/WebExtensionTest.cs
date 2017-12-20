// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Tests.WebExtensionClass;
using DocumentFormat.OpenXml.Validation;
using System;
using System.Collections.Generic;
using System.IO;
using Xunit;

using static DocumentFormat.OpenXml.Tests.TestAssets;

using A = DocumentFormat.OpenXml.Drawing;
using We = DocumentFormat.OpenXml.Office2013.WebExtension;
using Wetp = DocumentFormat.OpenXml.Office2013.WebExtentionPane;

namespace DocumentFormat.OpenXml.Tests.WebExtension
{
    public class WebExtensionTest
    {
        [Theory]
        [InlineData(TestDataStorage.O15Conformance.XL.WebExtension.Bing_xlsx)]
        [InlineData(TestDataStorage.O15Conformance.XL.WebExtension.Youtube_xlsx)]
        public void WebExtensionAcceptance(string path)
        {
            using (var stream = GetStream(path, true))
            {
                VerifyReadWebExtension(stream);

                var fixedId = $"OSM Test - {Guid.NewGuid()}";

                VerifyWriteRead<WebExtensionPart>(stream,
                    wep =>
                    {
                        wep.WebExtension.WebExtensionStoreReference.Id = fixedId;
                    },
                    wep =>
                    {
                        Assert.Equal(fixedId, wep.WebExtension.WebExtensionStoreReference.Id.Value);
                    });

                // Verify that OOXML SDK can properly validate WebExtension Features
                VerifyValidator(stream);
            }
        }

        [Fact]
        public void WebExtensionFullyFledgedValidation()
        {
            var seed = 5;

            DoubleValue DoubleValueFixer(DoubleValue iv) => new DoubleValue(seed / 100D);

            DoubleValue DoubleValueChecker(DoubleValue iv)
            {
                Assert.Equal(DoubleValueFixer(0D).Value, iv.Value);

                return iv;
            }

            BooleanValue BooleanValueFixer(BooleanValue iv) => 0 == seed % 2;

            BooleanValue BooleanValueChecker(BooleanValue iv)
            {
                Assert.Equal(0 == seed % 2, iv.Value);

                return iv;
            }

            Int32Value Int32ValueFixer(Int32Value iv)
            {
                int modulo = seed + 13;
                return iv + (modulo - iv % modulo);
            }

            Int32Value Int32ValueChecker(Int32Value iv)
            {
                Assert.Equal(0, iv % (13 + seed));

                return iv;
            }

            StringValue StringValueFixer(StringValue sv) => $"{sv}_{seed}";

            StringValue StringValueChecker(StringValue sv)
            {
                Assert.EndsWith($"_{seed}", sv.Value);

                return sv;
            }

            UInt32Value UInt32ValueFixer(UInt32Value iv) => new UInt32Value((uint)seed);

            UInt32Value UInt32ValueChecker(UInt32Value iv)
            {
                Assert.Equal((uint)seed, iv.Value);

                return iv;
            }

            using (var stream = new MemoryStream())
            {
                WebExtensionData.CreatePackage(stream);

                // make sure the file created is valid
                VerifyValidator(stream);

                // Verify that OOXML SDK can write WebExtension section
                VerifyWriteRead<WebExtensionPart>(stream,
                    wep =>
                    {
                        WalkWep(wep, StringValueFixer, Int32ValueFixer);
                    },
                    wep =>
                    {
                        WalkWep(wep, StringValueChecker, Int32ValueChecker);
                    });

                // Verify that OOXML SDK can write Taskpanes section
                VerifyWriteRead<Wetp.Taskpanes>(stream,
                    tps =>
                    {
                        Walker_WebExtentionPane(tps, StringValueFixer, DoubleValueFixer, UInt32ValueFixer, BooleanValueFixer);
                    },
                    tps =>
                    {
                        Walker_WebExtentionPane(tps, StringValueChecker, DoubleValueChecker, UInt32ValueChecker, BooleanValueChecker);
                    });
            }
        }

        /// <summary>
        /// Walks the children of a Taskpanes element.
        /// </summary>
        /// <param name="tps"></param>
        /// <param name="svCallback"></param>
        /// <param name="dblCallback"></param>
        /// <param name="uint32Callback"></param>
        private void Walker_WebExtentionPane(Wetp.Taskpanes tps,
                                            Func<StringValue, StringValue> svCallback, Func<DoubleValue, DoubleValue> dblCallback,
                                            Func<UInt32Value, UInt32Value> uint32Callback, Func<BooleanValue, BooleanValue> boolCallback)
        {
            foreach (Wetp.WebExtensionTaskpane tp in tps.ChildElements)
            {
                tp.DockState = svCallback(tp.DockState);
                tp.Locked = boolCallback(tp.Locked);
                /// TODO: these are messy, let's do them later:
                /// OfficeArtExtensionList
                /// OsfWebExtensionPartRef
                tp.Row = uint32Callback(tp.Row);
                tp.Visibility = boolCallback(tp.Visibility);
                tp.Width = dblCallback(tp.Width);
            }
        }

        /// <summary>
        /// Walks the WebExtension element, invoking the delegates provided on all the Strings and Int32 values
        /// </summary>
        /// <param name="wep">WebExtensionPart the element to be walked</param>
        /// <param name="svCallback">StringValueFoo delegate to be called for StringValues</param>
        /// <param name="int32Callback">Int32ValueFoo delegate to be called for Int32Values</param>
        private void WalkWep(WebExtensionPart wep, Func<StringValue, StringValue> svCallback, Func<Int32Value, Int32Value> int32Callback)
        {
            var we = wep.WebExtension;

            foreach (var blipKid in we.Snapshot)
            {
                // Actually they say (obj.GetType() == typeof(ClassA)) is faster, but we are not in hurry here anyways
                if (blipKid is A.AlphaBiLevel abl)
                {
                    abl.Threshold = int32Callback(abl.Threshold);
                }
                else if (blipKid is A.AlphaCeiling)
                {
                }
                else if (blipKid is A.AlphaFloor)
                {
                }
                else if (blipKid is A.BlipExtensionList bel)
                {
                    foreach (A.BlipExtension be in bel)
                    {
                        be.Uri = svCallback(be.Uri);
                    }
                    // it's possible to try and access the childs of be, but these are OpenXmlUnknownElement
                    // and it's not possible to modify them in an intelligent way.
                }
            }

            we.Id = svCallback(we.Id);

            foreach (We.WebExtensionBinding binding in we.WebExtensionBindingList)
            {
                binding.AppReference = svCallback(binding.AppReference);
                binding.Id = svCallback(binding.Id);

                // UF: how about the Type?
            }

            foreach (We.WebExtensionProperty prop in we.WebExtensionPropertyBag)
            {
                prop.Name = svCallback(prop.Name);
                prop.Value = svCallback(prop.Value);
            }

            {
                var refr = we.WebExtensionStoreReference;

                refr.Id = svCallback(refr.Id);
                refr.Store = svCallback(refr.Store);
                refr.StoreType = svCallback(refr.StoreType);
                refr.Version = svCallback(refr.Version);
            }

            foreach (We.WebExtensionStoreReference refr in we.WebExtensionReferenceList)
            {
                refr.Id = svCallback(refr.Id);
                refr.Store = svCallback(refr.Store);
                refr.StoreType = svCallback(refr.StoreType);
                refr.Version = svCallback(refr.Version);
            }
        }

        /// <summary>
        /// Verify that OOXML SDK can read OOXML files containing MOE (WebExtension) feature
        /// </summary>
        private void VerifyReadWebExtension(Stream stream)
        {
            using (var package = SpreadsheetDocument.Open(stream, false))
            {
                Assert.NotNull(package);

                foreach (var wsPart in package.WorkbookPart.WorksheetParts)
                {
                    // Try to get WebExtensionPart
                    foreach (var we in wsPart.DrawingsPart.WebExtensionParts)
                    {
                        Assert.Equal("1.0", we.WebExtension.WebExtensionStoreReference.Version.Value);
                        Assert.Equal("webextension", we.WebExtension.LocalName);
                    }
                }
            }
        }

        private void VerifyWriteRead<T>(Stream stream, Action<T> elemFixer, Action<T> elemTester)
            where T : class
        {
            // Open OOXML File with writable mode
            using (var package = SpreadsheetDocument.Open(stream, true))
            {
                foreach (T elem in FetchSections<T>(package))
                {
                    elemFixer(elem);
                }
            }

            // Re-open the file just saved above with read-only mode
            using (var package = SpreadsheetDocument.Open(stream, false))
            {
                foreach (T elem in FetchSections<T>(package))
                {
                    elemTester(elem);
                }
            }
        }

        /// <summary>
        /// Verify that OOXML SDK can properly validate an OOXML file
        /// </summary>
        private void VerifyValidator(Stream stream)
        {
            using (OpenXmlPackage package = SpreadsheetDocument.Open(stream, true))
            {
                var validator = new OpenXmlValidator(FileFormatVersions.Office2013);

                Assert.Empty(validator.Validate(package));
            }
        }

        /// <summary>
        /// The template class to faclilitate the enumeration over the elemnts of different section of a SpreadsheetDocument.
        /// Currently supported types are:
        /// 1. WebExtensionPart
        /// 2. Wetp.Taskpanes
        /// </summary>
        /// <typeparam name="T">one of the types supported</typeparam>
        private IEnumerable<T> FetchSections<T>(SpreadsheetDocument xl)
            where T : class
        {
            if (typeof(T) == typeof(WebExtensionPart))
            {
                foreach (var wsPart in xl.WorkbookPart.WorksheetParts)
                {
                    foreach (var wep in wsPart.DrawingsPart.WebExtensionParts)
                    {
                        yield return wep as T;
                    }
                }
            }

            if (typeof(T) == typeof(Wetp.Taskpanes))
            {
                // technically speaking there is only one Taskpanes section in a document.
                yield return xl.WebExTaskpanesPart.Taskpanes as T;
            }
        }
    }
}
