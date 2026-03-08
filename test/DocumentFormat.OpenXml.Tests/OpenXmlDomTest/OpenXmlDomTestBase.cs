// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using Xunit;

namespace DocumentFormat.OpenXml.Tests
{
    /// <summary>
    /// The OpenXmlDom test framework. It contains help methods for testing OpenXmlDom Classes
    /// </summary>
    public class OpenXmlDomTestBase : OpenXmlTestBase
    {
        public OpenXmlDomTestBase(ITestOutputHelper output)
            : base(output)
        {
        }

        #region Delegation ...

        internal delegate OpenXmlPart GetTargetPart(OpenXmlPackage package);

        internal delegate OpenXmlElement GetTargetElement(OpenXmlElement root);

        internal delegate OpenXmlAttribute GetTargetAttribute(OpenXmlElement host);

        internal delegate KeyValuePair<string, string> GetTargetNamespaceDeclaration(OpenXmlElement host);

        internal delegate T PendChild<T>(OpenXmlElement newChild);

        internal delegate T InsertChild<T>(OpenXmlElement newChild, OpenXmlElement refChild);

        #endregion

        #region Retrieve XElement

        /// <summary>
        /// calculate the OpenXml Element path
        /// </summary>
        /// <param name="element">the element need to calculate</param>
        /// <returns>the path of the passed-in element</returns>
        private static string GetElementPath(OpenXmlElement element)
        {
            // Log.Comment("get the current element position path");
            if (element is null)
            {
                throw new ArgumentNullException(nameof(element));
            }

            StringBuilder path = new StringBuilder();

            GetSameLevelPath(element, ref path);
            OpenXmlElement walker = element.Parent;
            while (walker is not null)
            {
                GetSameLevelPath(walker, ref path);
                walker = walker.Parent;
            }

            return path.ToString();
        }

        /// <summary>
        /// calculate the position of the element in the same xml level
        /// </summary>
        /// <param name="element">the element to be calculated</param>
        /// <param name="path">the result element path</param>
        private static void GetSameLevelPath(OpenXmlElement element, ref StringBuilder path)
        {
            if (element is null || path is null)
            {
                throw new ArgumentNullException("element|path");
            }

            int position = 0;

            OpenXmlElement walker = element.PreviousSibling();

            while (walker is not null)
            {
                position++;
                walker = walker.PreviousSibling();
            }

            path.Insert(0, "/" + element.LocalName + "@" + position);
        }

        /// <summary>
        /// retrieve the Xml element from its path
        /// </summary>
        /// <param name="element">the root </param>
        /// <param name="Path">the path used to find the target element</param>
        /// <returns>The <see cref="XElement"/> retrieved from the path</returns>
        private static XElement GetXmlElement(string path, OpenXmlPart part)
        {
            if (part is null)
            {
                throw new ArgumentNullException(nameof(part));
            }

            if (string.IsNullOrEmpty(path))
            {
                throw new ArgumentNullException(nameof(path));
            }

            XElement element = null;
            using (var stream = part.GetStream())
            using (var reader = XmlReader.Create(stream))
            {
                element = XElement.Load(reader);
            }

            if (element is null)
            {
                throw new Exception("Failed to load element from specified part.");
            }

            List<string> elementTypeList = new List<string>();
            List<string> elementPositionList = new List<string>();
            char[] separator = { '/' };

            foreach (string level in path.Split(separator, StringSplitOptions.RemoveEmptyEntries))
            {
                string[] ele = level.Split('@');
                if (ele.Length <= 0 || ele.Length > 2)
                {
                    throw new ArgumentException("The path is invalid!!");
                }

                elementTypeList.Add(ele[0]);
                elementPositionList.Add(ele[1]);
            }

            XElement targetElement = element;

            for (int x = 1; x < elementTypeList.Count; x++)
            {
                targetElement = targetElement.Elements().ElementAt(Convert.ToInt32(elementPositionList[x]));

                if (!targetElement.Name.LocalName.Equals(elementTypeList[x], StringComparison.OrdinalIgnoreCase))
                {
                    throw new ArgumentException("The path contains invalid data");
                }
            }

            return targetElement;
        }

        /// <summary>
        /// covert the OpenXmlElement to an XElement. the OpenXmlElement's path will be calculated first,
        /// then XElement will be retrieved from the path calculated
        /// </summary>
        /// <param name="part">the part that the OpenXmlElement exists in</param>
        /// <param name="element">the OpenXmlElement need to be converted</param>
        /// <returns>the corresponding <see cref="XElement"/></returns>
        internal static XElement ConvertToXElement(OpenXmlPart part, OpenXmlElement element)
        {
            if (part is null || element is null)
            {
                throw new ArgumentNullException("part | element");
            }

            string path = GetElementPath(element);

            return GetXmlElement(path, part);
        }

        #endregion

        #region Find Part

        /// <summary>Gets any reflectable part in given package. </summary>
        internal GetTargetPart GetAnyOpenXmlPart =>
            p => p.DescendantParts()
                .Where(pa => pa.IsReflectable() && pa.ContentType != "application/xml")
                .PickSecond();

        /// <summary>Gets main part of given package. </summary>
        internal GetTargetPart GetMainPart => p => p.MainPart();

        /// <summary>Gets non-main part of given Package. </summary>
        internal GetTargetPart GetNonMainPart =>
            p => p.NonMainParts()
                .Where(pa => pa.IsReflectable() && pa.ContentType != "application/xml")
                .PickSecond();

        /// <summary>Gets the first slide part of given package. </summary>
        internal GetTargetPart GetSlidePart =>
            p => p.MainPart().GetPartsOfType<SlidePart>().FirstOrDefault();

        /// <summary>Gets the first worksheet part of given package. </summary>
        internal GetTargetPart GetFirstSheetPart =>
            p => p.MainPart().GetPartsOfType<WorksheetPart>().FirstOrDefault();

        /// <summary>Gets the last worksheet part of given package. </summary>
        internal GetTargetPart GetLastSheetPart =>
            p => p.MainPart().GetPartsOfType<WorksheetPart>().LastOrDefault();

        #endregion Find Part

        #region Find Element

        /// <summary>Gets body element of the document.</summary>
        internal GetTargetElement GetBody =>
             e => e.Descendants().OfType<Body>().FirstOrDefault();

        /// <summary>Gets part root of current element.</summary>
        internal GetTargetElement GetPartRoot =>
            e => e.Parent is null ? (e is OpenXmlPartRootElement ? e : null) : e.Ancestors<OpenXmlPartRootElement>().FirstOrDefault();

        /// <summary>Gets parent of current element.</summary>
        internal GetTargetElement GetAnyAncestor =>
            e => e.Ancestors().PickSecond();

        /// <summary>Gets root element of current one.</summary>
        internal GetTargetElement GetRootElement =>
            e => e.Parent is null ? e : e.Ancestors().LastOrDefault();

        /// <summary>Gets parent of current element.</summary>
        internal GetTargetElement GetParent =>
            e => e.Parent;

        /// <summary>Gets current element itself.</summary>
        internal GetTargetElement GetSelf =>
            e => e;

        /// <summary>Gets null as return vlaue. Useful for invalid cases.</summary>
        internal GetTargetElement GetNull =>
            e => null;

        /// <summary>Gets descendant of OpenXmlUnknownElement</summary>
        internal GetTargetElement GetUnknownElement =>
            e => e.Descendants<OpenXmlUnknownElement>().FirstOrDefault();

        /// <summary>Gets descendant of OpenXmlMiscNode</summary>
        internal GetTargetElement GetMiscNode =>
            e => e.Descendants<OpenXmlMiscNode>().FirstOrDefault();

        /// <summary>Gets element with parent and sibling. </summary>
        internal GetTargetElement GetElementWithParentAndSibling =>
            e => e.Descendants().Where(d => d.Parent is not null && d.Parent.ChildElements.Count > 1).First();

        /// <summary>Gets element without children</summary>
        internal GetTargetElement GetElementWithoutChildren =>
            e => e.Descendants<OpenXmlCompositeElement>().Where(d => d.ChildElements.Count == 0).FirstOrDefault();

        /// <summary>Gets element with ONE child</summary>
        internal GetTargetElement GetElementWithChild =>
            e => e.Descendants().Where(d => d.ChildElements.Count == 1).FirstOrDefault();

        /// <summary>Gets element with children</summary>
        internal GetTargetElement GetElementWithChildren =>
            e => e.Descendants().Where(d => d.ChildElements.Count > 1).FirstOrDefault();

        /// <summary>Gets element with children</summary>
        internal GetTargetElement GetElementWithAttributesOnly =>
            e => e.Descendants<OpenXmlCompositeElement>().Where(d => d.GetAttributes().Count > 0 && d.ChildElements.Count == 0).FirstOrDefault();

        /// <summary>Gets element with children</summary>
        internal GetTargetElement GetElementWithAttributesAndChildren =>
            e => e.Descendants().Where(d => d.GetAttributes().Count > 0 && d.ChildElements.Count > 0).FirstOrDefault();

        /// <summary>Gets any leaf element in descendants.</summary>
        internal GetTargetElement GetAnyElement =>
            e => e.Descendants<OpenXmlElement>().PickSecond();

        /// <summary>Gets any leaf element in descendants.</summary>
        internal GetTargetElement GetAnyLeaf =>
            e => e.Descendants<OpenXmlLeafElement>().PickSecond();

        /// <summary>Gets any composite element in descendant.</summary>
        internal GetTargetElement GetAnyComposite =>
            e => e.Descendants<OpenXmlCompositeElement>().PickSecond();

        /// <summary>Gets paragraph with text run only.</summary>
        internal GetTargetElement GetTextParagraph =>
            e => e.Descendants<DocumentFormat.OpenXml.Wordprocessing.Paragraph>()
                .Where(p => p.ChildElements.Count(c => !(c is DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties)) == 1)
                .Where(p => p.Descendants<DocumentFormat.OpenXml.Wordprocessing.Text>().Count() == 1)
                .PickSecond();

        /// <summary>Gets descendant element of pass-in OpenXmlElement that has both leaf and composite child elements</summary>
        internal GetTargetElement GetAnyWithLeafAndCompositeChild =>
            e =>
            {
                return e.Descendants()
                    .Where(c => c.ChildElements.Any(d => d is OpenXmlLeafElement)
                        && c.ChildElements.Any(d => d is OpenXmlCompositeElement))
                    .PickSecond();
            };

        /// <summary>Gets descendant element of pass-in OpenXmlElement that has composite child elements</summary>
        internal GetTargetElement GetAnyWithCompositeChild =>
            e =>
            {
                return e.Descendants()
                    .Where(c => c.ChildElements.Any(d => d is OpenXmlCompositeElement))
                    .PickSecond();
            };

        /// <summary>Gets descendant element of pass-in OpenXmlElement that has leaf child elements</summary>
        internal GetTargetElement GetAnyWithLeafChild =>
            e =>
            {
                return e.Descendants()
                    .Where(c => c.ChildElements.Any(d => d is OpenXmlLeafElement))
                    .PickSecond();
            };

        /// <summary>Gets grand child of pass-in OpenXmlElement</summary>
        internal GetTargetElement GetGrandChild =>
            e => e.ChildElements
                .Where(c => c.ChildElements.Count > 0)
                .SelectMany(c => c.ChildElements)
                .PickSecond();

        /// <summary>Gets first child of pass-in OpenXmlElement</summary>
        internal GetTargetElement GetFirstChild =>
            e => e.ChildElements.FirstOrDefault();

        /// <summary>Gets last child of pass-in OpenXmlElement</summary>
        internal GetTargetElement GetLastChild =>
            e => e.ChildElements.LastOrDefault();

        /// <summary>Gets first child of pass-in OpenXmlElement</summary>
        internal GetTargetElement GetAnyChild =>
            e => e.ChildElements.PickSecond();

        /// <summary>Gets any leaf element in child element.</summary>
        internal GetTargetElement GetAnyLeafChild =>
            e => e.ChildElements.OfType<OpenXmlLeafElement>().PickSecond();

        /// <summary>Gets any composite element in child element.</summary>
        internal GetTargetElement GetAnyCompositeChild =>
            e => e.ChildElements.OfType<OpenXmlCompositeElement>().PickSecond();

        /// <summary>Gets first child element which contains OpenXmlLeafTextElement only.</summary>
        internal GetTargetElement GetChildWithLeafTextOnly =>
            e => e.ChildElements
                .Where(c => c.ChildElements.All(cc => cc is OpenXmlLeafTextElement))
                .First();

        /// <summary>Gets first sibling of pass-in OpenXmlElement.</summary>
        internal GetTargetElement GetFirstSibling =>
            e => e.Parent is null ? null : e == e.Parent.First() ? e.NextSibling() : e.Parent.First();

        /// <summary>Gets last sibling of pass-in OpenXmlElement.</summary>
        internal GetTargetElement GetLastSibling =>
            e => e.Parent is null ? null : e == e.Parent.Last() ? e.PreviousSibling() : e.Parent.Last();

        /// <summary>Gets any sibling of pass-in OpenXmlElement.</summary>
        internal GetTargetElement GetAnySibling =>
            e => e.Parent?.ChildElements.Where(s => s != e).PickSecond();

        /// <summary>Gets any TextBody of given slide.</summary>
        internal GetTargetElement GetSlideTextBody =>
            e => e.Descendants<DocumentFormat.OpenXml.Presentation.TextBody>().PickSecond();

        /// <summary>Gets any Paragraph of any TextBody.</summary>
        internal GetTargetElement GetSlideTextParagraph =>
            e => e.Descendants<DocumentFormat.OpenXml.Presentation.TextBody>().PickSecond()
            .Descendants<DocumentFormat.OpenXml.Drawing.Paragraph>().PickSecond();

        /// <summary>Gets any SheetData of given worksheet.</summary>
        internal GetTargetElement GetSheetData =>
            e => e.Descendants<SheetData>().PickSecond();

        /// <summary>Gets any SheetData Row of first worksheet.</summary>
        internal GetTargetElement GetSheetDataRow =>
            e => e.Descendants<SheetData>().FirstOrDefault()
                .Descendants<Row>().PickSecond();

        #endregion Find Element

        #region Append Collection

        internal enum AppendCollectionType
        {
            IEnumerable,
            Array,
        }

        internal void AppendCollectionOnFile(IFile testfile, GetTargetPart getHostPart, GetTargetElement getHostElement,
            IFile sourceFile, GetTargetPart getSrcPart, GetTargetElement getImportee, AppendCollectionType operationType)
        {
            using (var target = testfile.Open(true))
            using (var source = sourceFile.Open(false))
            {
                var hostPart = getHostPart(target);
                var srcHostPart = getSrcPart(source);

                if (!hostPart.IsReflectable() || !srcHostPart.IsReflectable())
                {
                    Output.WriteLine("Warning: Either hostPart or srcHostPart is NOT reflectable.");
                }

                AppendCollection(hostPart, getHostElement, srcHostPart, getImportee, operationType);
            }
        }

        private void AppendCollection(OpenXmlPart hostPart, GetTargetElement getHost,
            OpenXmlPart srcPart, GetTargetElement getImportee, AppendCollectionType operationType)
        {
            Output.WriteLine("Loading root element from hosting part...");
            OpenXmlPartRootElement main = hostPart.RootElement();
            Output.WriteLine("Loading root element from source part...");
            OpenXmlPartRootElement srcMain = srcPart.RootElement();

            Output.WriteLine("Looking for target element in {0}...", hostPart.GetType().Name);
            var hostElement = getHost(main);
            if (hostElement is not null)
            {
                Output.WriteLine("Host element found: {0}", hostElement.Path());

                Output.WriteLine("Looking for importing element in {0}...", srcPart.GetType().Name);
                var importHost = getImportee(srcMain);
                if (importHost is not null)
                {
                    Output.WriteLine("Importing element found: {0}", importHost.Path());

                    XElement xBefore = ConvertToXElement(hostPart, hostElement);

                    Output.WriteLine("Importing {0} elements...", importHost.ChildElements.Count);
                    var originalElementCount = hostElement.ChildElements.Count;
                    var importElementsCount = importHost.ChildElements.Count;
                    var childPosition = originalElementCount;
                    string importElementOuterXml = null;

                    switch (operationType)
                    {
                        case AppendCollectionType.Array:
                            hostElement.Append(importHost.ChildElements.Select(c => c.CloneNode(true)).ToArray<OpenXmlElement>());
                            break;
                        case AppendCollectionType.IEnumerable:
                            hostElement.Append(importHost.ChildElements.Select(c => c.CloneNode(true)).AsEnumerable<OpenXmlElement>());
                            break;
                        default:
                            throw new InvalidOperationException("Invalid Operation Specified!");
                    }

                    Output.WriteLine("Saving changes...");
                    main.Save();

                    XElement xAfter = ConvertToXElement(hostPart, hostElement);

                    Output.WriteLine("Checking if children of current element increased by {0}...", importElementsCount);
                    Assert.True(xBefore.Elements().Count() == xAfter.Elements().Count() - importElementsCount, "Children element NOT increased as expected!");

                    for (int i = 0; i < importElementsCount; i++)
                    {
                        importElementOuterXml = importHost.ChildElements[i].OuterXml;
                        VerifyEqual(xAfter, XElement.Parse(importElementOuterXml), childPosition++);
                    }
                }
                else
                {
                    Output.WriteLine("Warning: Importing element NOT found.");
                }
            }
            else
            {
                Output.WriteLine("Warning: Host element NOT found.");
            }
        }

        #endregion Append Collection

        #region Pend Operations

        internal enum PendType
        {
            Append,
            Prepend,
        }

        private protected void PendTestOnFile(IFile testFile, GetTargetPart getHostPart, GetTargetElement getHostElement,
            IFile sourceFile, GetTargetPart getSourcePart, GetTargetElement getSourceHost, PendType pendType)
        {
            using (var target = testFile.Open(true))
            using (var source = sourceFile.Open(false))
            {
                var hostPart = getHostPart(target);
                var srcHostPart = getSourcePart(source);

                if (!hostPart.IsReflectable() || !srcHostPart.IsReflectable())
                {
                    Assert.Fail("Either hostPart or srcHostPart is NOT reflectable.");
                }

                PendTestBody(hostPart, getHostElement, srcHostPart, getSourceHost, pendType);
            }
        }

        /// <summary>
        /// Ap/Pre- pend OpenXmlElement found through getImportee on srcPart to OpenXmlElement found through getTarget on hostPart.
        /// </summary>
        /// <param name="hostPart">Hosting Part</param>
        /// <param name="getTarget">Delegate method to find specific OpenXmlElement in host part</param>
        /// <param name="srcPart">Source Part to import content from</param>
        /// <param name="getImportee">Delegate method to find specific OpenXmlElment in source part</param>
        /// <param name="operationType">Append or Prepend</param>
        private void PendTestBody(OpenXmlPart hostPart, GetTargetElement getHost,
            OpenXmlPart srcPart, GetTargetElement getImportee, PendType operationType)
        {
            Output.WriteLine("Loading root element from hosting part...");
            OpenXmlPartRootElement main = hostPart.RootElement();
            Output.WriteLine("Loading root element from source part...");
            OpenXmlPartRootElement srcMain = srcPart.RootElement();

            Output.WriteLine("Looking for target element in {0}...", hostPart.GetType().Name);
            var hostElement = getHost(main);
            if (hostElement is not null)
            {
                Output.WriteLine("Host element found: {0}", hostElement.Path());

                Output.WriteLine("Looking for importing element in {0}...", srcPart.GetType().Name);
                var importElement = getImportee(srcMain);
                if (importElement is not null)
                {
                    Output.WriteLine("Importing element found: {0}", importElement.Path());

                    XElement xBefore = ConvertToXElement(hostPart, hostElement);

                    int? childPosition = null;
                    OpenXmlElement result = null;
                    string importElementOuterXml = importElement.OuterXml;

                    switch (operationType)
                    {
                        case PendType.Prepend:
                            childPosition = 0;
                            result = PendOperation(hostElement.PrependChild, importElement.Clone() as OpenXmlElement);
                            break;
                        case PendType.Append:
                            childPosition = hostElement.ChildElements.Count;
                            result = PendOperation(hostElement.AppendChild, importElement.Clone() as OpenXmlElement);
                            break;
                        default:
                            throw new InvalidOperationException("Invalid Operation Specified!");
                    }

                    Output.WriteLine("Saving changes...");
                    main.Save();

                    XElement xAfter = ConvertToXElement(hostPart, hostElement);

                    Output.WriteLine("Checking if children of current element increased by ONE...");
                    Assert.True(xBefore.Elements().Count() == xAfter.Elements().Count() - 1, "Children element NOT increased by ONE!");

                    VerifyEqual(xAfter, XElement.Parse(importElementOuterXml), childPosition);
                }
                else
                {
                    Output.WriteLine("Warning: Importing element NOT found.");
                }
            }
            else
            {
                Output.WriteLine("Warning: Host element NOT found.");
            }
        }

        /// <summary>
        /// Perform pre/append operation.
        /// </summary>
        /// <param name="pendOp">Delegate to PrependChild/AppendChild method on OpenXmlElement</param>
        /// <param name="pendee">The OpenXmlElement to be pended</param>
        /// <returns>Return value of <paramref name="PendOp"/></returns>
        internal OpenXmlElement PendOperation(PendChild<OpenXmlElement> pendOp, OpenXmlElement pendee)
        {
            if (pendOp is null)
            {
                throw new ArgumentNullException(nameof(pendOp));
            }

            Output.WriteLine("Pending child with {0}...", pendOp.GetMethodInfo().Name);
            OpenXmlElement result = pendOp(pendee);

            Output.WriteLine("Checking if returned element is reference equal to pass-in element...");
            Assert.True(object.ReferenceEquals(result, pendee), "Returned element is NOT reference equal to pass-in one!");

            return result;
        }

        #endregion Pend Operations

        #region Insert Before/After

        internal enum InsertType
        {
            Before,
            After,
        }

        private protected void InsertTestOnFile(IFile testfile, GetTargetPart getHostPart, GetTargetElement getHostElement,
                IFile sourceFile, GetTargetPart getSourcePart, GetTargetElement getSourceHost, GetTargetElement getRef, InsertType insertType)
        {
            using (var target = testfile.Open(true))
            using (var source = sourceFile.Open(false))
            {
                var hostPart = getHostPart(target);
                var srcHostPart = getSourcePart(source);

                if (!hostPart.IsReflectable() || !srcHostPart.IsReflectable())
                {
                    Output.WriteLine("Warning: Either hostPart or srcHostPart is NOT reflectable.");
                }

                InsertTest(hostPart, getHostElement, srcHostPart, getSourceHost, getRef, InsertType.Before);
            }
        }

        /// <summary>
        /// Test insert operation
        /// </summary>
        /// <param name="hostPart">host part</param>
        /// <param name="getTarget">delegate to return the target element, which will perform the inserting operation</param>
        /// <param name="srcPart">source part to import element from</param>
        /// <param name="getImportee">delegate to find specific element in source part</param>
        /// <param name="type">the type of inserting to perform</param>
        private void InsertTest(OpenXmlPart hostPart, GetTargetElement getHost,
            OpenXmlPart srcPart, GetTargetElement getImportee, GetTargetElement getRef, InsertType type)
        {
            Output.WriteLine("Loading root element from hosting part...");
            OpenXmlPartRootElement main = hostPart.RootElement();
            Output.WriteLine("Loading root element from source part...");
            OpenXmlPartRootElement srcMain = srcPart.RootElement();

            Output.WriteLine("Looking for target element in {0}...", hostPart.GetType().Name);
            var hostElement = getHost(main);
            if (hostElement is not null)
            {
                Output.WriteLine("Host element found: {0}", hostElement.Path());

                Output.WriteLine("Looking for reference element in {0}...", hostElement.GetType().Name);
                var refElement = getRef(hostElement);
                if (refElement is not null)
                {
                    Output.WriteLine("Reference element found: {0}", refElement.Path());

                    Output.WriteLine("Looking for importing element in {0}...", srcPart.GetType().Name);
                    var importElement = getImportee(srcMain);
                    if (importElement is not null)
                    {
                        Output.WriteLine("Importing element found: {0}", importElement.Path());

                        XElement xbefore = ConvertToXElement(hostPart, hostElement);

                        OpenXmlElement result = null;
                        int? expectPos = null;
                        string insertElement = importElement.OuterXml;

                        switch (type)
                        {
                            case InsertType.Before:
                                expectPos =
                                    refElement is null ? hostElement.ChildElements.Count : refElement.Index();
                                result = InsertOperation(hostElement.InsertBefore, importElement.Clone() as OpenXmlElement, refElement);
                                break;
                            case InsertType.After:
                                expectPos =
                                    refElement is null ? 0 : refElement.Index() + 1;
                                result = InsertOperation(hostElement.InsertAfter, importElement.Clone() as OpenXmlElement, refElement);
                                break;
                            default:
                                throw new InvalidOperationException("Operation specified is invalid!!");
                        }

                        Output.WriteLine("Saving changes...");
                        main.Save();

                        XElement xafter = ConvertToXElement(hostPart, hostElement);

                        Output.WriteLine("Check if the child of  current element increased by ONE...");
                        Assert.True(xbefore.Elements().Count() == xafter.Elements().Count() - 1, "Child element NOT increased by ONE!");

                        Output.WriteLine("Check if specified child inserted as expected...");
                        VerifyEqual(xafter, XElement.Parse(insertElement), expectPos);
                    }
                    else
                    {
                        Output.WriteLine("Warning: Importing element NOT found.");
                    }
                }
                else
                {
                    Output.WriteLine("Warning: Reference element NOT found.");
                }
            }
            else
            {
                Output.WriteLine("Warning: Host element NOT found.");
            }
        }

        /// <summary>
        /// Perform InsertBefore/After operation.
        /// </summary>
        /// <param name="insertOp">Delegate to InsertBefore/After method on OpenXmlElement</param>
        /// <param name="insertee">OpenXmlElement to be inserted</param>
        /// <param name="refChild">Reference child of host element</param>
        /// <returns>Return value of <paramref name="insertOp"/></returns>
        internal OpenXmlElement InsertOperation(InsertChild<OpenXmlElement> insertOp, OpenXmlElement insertee, OpenXmlElement refChild)
        {
            if (insertOp is null || insertee is null)
            {
                throw new ArgumentNullException("insertOp|insertee");
            }

            Output.WriteLine("New child element is {0} the reference child", insertOp.GetMethodInfo().Name);
            OpenXmlElement result = insertOp(insertee, refChild);

            Output.WriteLine("Check if the element inserted is the same as the element inserted");
            Assert.True(object.ReferenceEquals(result, insertee), "two elements are not the same");

            return result;
        }

        #endregion Insert Before/After

        #region InsertAt

        internal enum InsertAtPosition
        {
            AsFirst,
            NextToFirst,
            AnyValid,
            NextToLast,
            AsLast,
        }

        private protected void InsertAtOnFile(IFile testfile, GetTargetPart getHostPart, GetTargetElement getHost,
                 IFile sourceFile, GetTargetPart getSrcPart, GetTargetElement getImportee, InsertAtPosition posType)
        {
            using (var target = testfile.Open(true))
            using (var source = sourceFile.Open(false))
            {
                var hostPart = getHostPart(target);
                var srcHostPart = getSrcPart(source);

                if (!hostPart.IsReflectable() || !srcHostPart.IsReflectable())
                {
                    Output.WriteLine("Warning: Either hostPart or srcHostPart is NOT reflectable.");
                }

                InsertAt(hostPart, getHost, srcHostPart, getImportee, posType);
            }
        }

        private void InsertAt(OpenXmlPart hostPart, GetTargetElement getHost,
            OpenXmlPart srcPart, GetTargetElement getImportee, InsertAtPosition posType)
        {
            Output.WriteLine("Loading root element from hosting part...");
            OpenXmlPartRootElement main = hostPart.RootElement();
            Output.WriteLine("Loading root element from source part...");
            OpenXmlPartRootElement srcMain = srcPart.RootElement();

            Output.WriteLine("Looking for target element in {0}...", hostPart.GetType().Name);
            var hostElement = getHost(main);
            if (hostElement is not null)
            {
                Output.WriteLine("Host element found: {0}", hostElement.Path());

                Output.WriteLine("Looking for importing element in {0}...", srcPart.GetType().Name);
                var importElement = getImportee(srcMain);
                if (importElement is not null)
                {
                    Output.WriteLine("Importing element found: {0}", importElement.Path());

                    XElement xbefore = ConvertToXElement(hostPart, hostElement);

                    int expectPos;
                    OpenXmlElement result = null;
                    string insertElement = importElement.OuterXml;

                    switch (posType)
                    {
                        case InsertAtPosition.AsFirst:
                            expectPos = 0;
                            break;
                        case InsertAtPosition.NextToFirst:
                            expectPos = 1;
                            break;
                        case InsertAtPosition.AnyValid:
                            // This used to pick a position at random.  Not good idea for test suite.
                            expectPos = hostElement.ChildElements.Count / 2;
                            break;
                        case InsertAtPosition.NextToLast:
                            expectPos = hostElement.ChildElements.Count - 1;
                            break;
                        case InsertAtPosition.AsLast:
                            expectPos = hostElement.ChildElements.Count;
                            break;
                        default:
                            throw new InvalidOperationException("Operation specified is invalid!!");
                    }

                    result = hostElement.InsertAt<OpenXmlElement>(importElement.Clone() as OpenXmlElement, expectPos);

                    Output.WriteLine("Saving changes...");
                    main.Save();

                    XElement xafter = ConvertToXElement(hostPart, hostElement);

                    Output.WriteLine("Check if the child of  current element increased by ONE...");
                    Assert.True(xbefore.Elements().Count() == xafter.Elements().Count() - 1, "Child element NOT increased by ONE!");

                    Output.WriteLine("Check if specified child inserted as expected...");
                    VerifyEqual(xafter, XElement.Parse(insertElement), expectPos);
                }
                else
                {
                    Output.WriteLine("Warning: Importing element NOT found.");
                }
            }
            else
            {
                Output.WriteLine("Warning: Host element NOT found.");
            }
        }

        #endregion InsertAt

        #region Insert Before/After Self

        internal enum InsertRel
        {
            BeforeSelf,
            AfterSelf,
        }

        private protected void InsertRelativeOnFile(IFile testfile, GetTargetPart getHostPart, GetTargetElement getHost,
            IFile sourceFile, GetTargetPart getSrcPart, GetTargetElement getImportee, InsertRel posType)
        {
            using (var target = testfile.Open(true))
            using (var source = sourceFile.Open(false))
            {
                var hostPart = getHostPart(target);
                var srcHostPart = getSrcPart(source);

                if (!hostPart.IsReflectable() || !srcHostPart.IsReflectable())
                {
                    Output.WriteLine("Warning: Either hostPart or srcHostPart is NOT reflectable.");
                }

                InsertRelative(hostPart, getHost, srcHostPart, getImportee, posType);
            }
        }

        private void InsertRelative(OpenXmlPart hostPart, GetTargetElement getHost,
            OpenXmlPart srcPart, GetTargetElement getImportee, InsertRel posType)
        {
            Output.WriteLine("Loading root element from hosting part...");
            OpenXmlPartRootElement main = hostPart.RootElement();
            Output.WriteLine("Loading root element from source part...");
            OpenXmlPartRootElement srcMain = srcPart.RootElement();

            Output.WriteLine("Looking for target element in {0}...", hostPart.GetType().Name);
            var hostElement = getHost(main);
            if (hostElement is not null)
            {
                Output.WriteLine("Host element found: {0}", hostElement.Path());

                Output.WriteLine("Looking for importing element in {0}...", srcPart.GetType().Name);
                var importElement = getImportee(srcMain);
                if (importElement is not null)
                {
                    Output.WriteLine("Importing element found: {0}", importElement.Path());

                    XElement xBefore = ConvertToXElement(hostPart, hostElement.Parent);

                    int expectPos;
                    OpenXmlElement result = null;
                    string insertElement = importElement.OuterXml;

                    switch (posType)
                    {
                        case InsertRel.AfterSelf:
                            expectPos = hostElement.Index() + 1;
                            result = hostElement.InsertAfterSelf<OpenXmlElement>(importElement.Clone() as OpenXmlElement);
                            break;
                        case InsertRel.BeforeSelf:
                            expectPos = hostElement.Index();
                            result = hostElement.InsertBeforeSelf<OpenXmlElement>(importElement.Clone() as OpenXmlElement);
                            break;
                        default:
                            throw new InvalidOperationException("Invalid Operation Specified!");
                    }

                    Output.WriteLine("Saving changes...");
                    main.Save();

                    XElement xAfter = ConvertToXElement(hostPart, hostElement.Parent);

                    Output.WriteLine("Check if the child of  current element increased by ONE...");
                    Assert.True(xBefore.Elements().Count() == xAfter.Elements().Count() - 1, "Child element NOT increased by ONE!");

                    Output.WriteLine("Check if specified element inserted as expected...");
                    VerifyEqual(xAfter, XElement.Parse(insertElement), expectPos);
                }
                else
                {
                    Output.WriteLine("Warning: Importing element NOT found.");
                }
            }
            else
            {
                Output.WriteLine("Warning: Host element NOT found.");
            }
        }

        #endregion Insert Before/After Self

        #region RemoveAllChildren

        private protected void RemoveAllChildrenOnFile(IFile testfile, GetTargetPart getHostPart, GetTargetElement getHost)
        {
            using (OpenXmlPackage target = testfile.Open(true))
            {
                OpenXmlPart hostPart = getHostPart(target);
                RemoveAllChildren(hostPart, getHost);
            }
        }

        private void RemoveAllChildren(OpenXmlPart hostPart, GetTargetElement getHost)
        {
            Output.WriteLine("Loading root element in {0}...", hostPart.GetType().Name);
            OpenXmlPartRootElement main = hostPart.RootElement();

            Output.WriteLine("Looking for host element...");
            OpenXmlElement hostElement = getHost(main);
            if (hostElement is not null)
            {
                Output.WriteLine("Host element found: {0}", hostElement.Path());

                if (hostElement.ChildElements.Count == 0)
                {
                    Output.WriteLine("Warning: The host element has NO children!");
                }

                Output.WriteLine("The host element have {0} children.", hostElement.ChildElements.Count);

                Output.WriteLine("Remove all children from host element...");
                hostElement.RemoveAllChildren();

                Output.WriteLine("Saving changes...");
                main.Save();

                Output.WriteLine("Verifying host element has no children any more...");
                XElement xbefore = ConvertToXElement(hostPart, hostElement);
                VerifyNoChildren(xbefore);
            }
            else
            {
                Output.WriteLine("Warning: Host element NOT found.");
            }
        }

        private protected void RemoveAllTypedChildrenOnFile(IFile testfile, GetTargetPart getHostPart, GetTargetElement getHost, Type deleteType)
        {
            using (OpenXmlPackage target = testfile.Open(true))
            {
                OpenXmlPart hostPart = getHostPart(target);

                RemoveAllTypedChildren(hostPart, getHost, deleteType);
            }
        }

        private void RemoveAllTypedChildren(OpenXmlPart hostPart, GetTargetElement getHost, Type deleteType)
        {
            Output.WriteLine("Loading root element in {0}...", hostPart.GetType().Name);
            OpenXmlPartRootElement main = hostPart.RootElement();

            Output.WriteLine("Looking for host element...");
            OpenXmlElement hostElement = getHost(main);
            if (hostElement is not null)
            {
                Output.WriteLine("Host element found: {0}", hostElement.Path());

                if (hostElement.ChildElements.Count != 0)
                {
                    Func<Type, Type, bool> isOfType =
                        (t, rt) => t == rt || t.IsSubclassOf(rt);

                    var childrenOfType = hostElement.ChildElements
                        .Where(c => isOfType(c.GetType(), deleteType)).ToArray();
                    Output.WriteLine("Host element have {0} children of type {1}.", childrenOfType.Length, deleteType.Name);
                    var childrenPosition = childrenOfType.Select(c => c.Index()).ToArray();

                    XElement xbefore = ConvertToXElement(hostPart, hostElement);

                    Output.WriteLine("Looking for RemoveAllChildren<T>() by reflecting...");
                    var flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.FlattenHierarchy;
                    var removeAll = typeof(OpenXmlElement).GetMethods(flag)
                        .Where(m => m.IsGenericMethod && m.Name.StartsWith("RemoveAllChildren"))
                        .First();
                    Output.WriteLine("Remove all children of {0} from host element...", deleteType.Name);
                    removeAll = removeAll.MakeGenericMethod(deleteType);
                    removeAll.Invoke(hostElement, null);

                    Output.WriteLine("Saving changes...");
                    main.Save();

                    Output.WriteLine("Verifying host element has no specified children element any more...");
                    var childrenOfTypeAfter = hostElement.ChildElements
                        .Where(c => isOfType(c.GetType(), deleteType));
                    Assert.True(!childrenOfTypeAfter.Any(), string.Format("Children of specified {0} still exists.", deleteType));

                    Output.WriteLine("Verifing children of specified type removed...");
                    XElement xAfter = ConvertToXElement(hostPart, hostElement);
                    VerifyRemove(xAfter, xbefore, childrenPosition);
                }
                else
                {
                    Output.WriteLine("Warning: The host element has NO children!");
                }
            }
            else
            {
                Output.WriteLine("Warning: Host element NOT found.");
            }
        }

        #endregion RemoveAllChildren

        #region RemoveChild

        private protected void RemoveChildOnFile(IFile testfile, GetTargetPart getHostPart, GetTargetElement getHost, GetTargetElement getDelete)
        {
            using (OpenXmlPackage target = testfile.Open(true))
            {
                OpenXmlPart hostPart = getHostPart(target);
                RemoveChild(hostPart, getHost, getDelete);
            }
        }

        /// <summary>
        /// Remove specified child element
        /// </summary>
        /// <param name="doc">host part of an existing package</param>
        /// <param name="getTarget">delegate to return target element, which will perform the remove operation</param>
        /// <param name="getDelete">delegate to return the element to be removed</param>
        private void RemoveChild(OpenXmlPart hostPart, GetTargetElement getHost, GetTargetElement getDelete)
        {
            Output.WriteLine("Loading root element of {0}...", hostPart.GetType().Name);
            OpenXmlPartRootElement main = hostPart.RootElement();

            OpenXmlElement hostElement = getHost(main);
            if (hostElement is not null)
            {
                Output.WriteLine("Host element found: {0}", hostElement.Path());

                OpenXmlElement deleteElement = getDelete(hostElement);
                if (deleteElement is not null)
                {
                    Output.WriteLine("Target element found: {0}", deleteElement.Path());

                    int childPosition = deleteElement is null ? -1 : deleteElement.Index();
                    XElement xBefore = ConvertToXElement(hostPart, hostElement);

                    Output.WriteLine("Removing specified child element...");
                    OpenXmlElement result = hostElement.RemoveChild<OpenXmlElement>(deleteElement);

                    Output.WriteLine("Save the changes");
                    main.Save();

                    Output.WriteLine("Verifying child removed as expected...");
                    XElement xAfter = ConvertToXElement(hostPart, hostElement);
                    VerifyRemove(xAfter, xBefore, childPosition);
                }
                else
                {
                    Output.WriteLine("Warning: Target element to remove NOT found.");
                }
            }
            else
            {
                Output.WriteLine("Warning: Host element NOT found.");
            }
        }

        #endregion RemoveChild

        #region Remove

        private protected void RemoveOnFile(IFile testfile, GetTargetPart getHostPart, GetTargetElement getTarget)
        {
            using (OpenXmlPackage target = testfile.Open(true))
            {
                OpenXmlPart hostPart = getHostPart(target);

                Remove(hostPart, getTarget);
            }
        }

        /// <summary>
        /// Remove specified element itself
        /// </summary>
        /// <param name="hostPart">host part of an existing package</param>
        /// <param name="getTarget">delegate to return target element, which will perform the remove operation</param>
        private void Remove(OpenXmlPart hostPart, GetTargetElement getTarget)
        {
            Output.WriteLine("Loading root element of {0}...", hostPart.GetType().Name);
            OpenXmlPartRootElement main = hostPart.RootElement();

            OpenXmlElement targetElement = getTarget(main);
            if (targetElement is not null)
            {
                Output.WriteLine("Target element found: {0}", targetElement.Path());

                OpenXmlElement parent = targetElement.Parent;
                if (parent is not null)
                {
                    Output.WriteLine("Parent element found: {0}", parent.Path());

                    int targetPosition = targetElement is null ? -1 : targetElement.Index();
                    XElement xBefore = ConvertToXElement(hostPart, parent);

                    Output.WriteLine("Removing current element...");
                    targetElement.Remove();

                    Output.WriteLine("Save the changes");
                    main.Save();

                    Output.WriteLine("Verifying target removed as expected...");
                    XElement xAfter = ConvertToXElement(hostPart, parent);
                    VerifyRemove(xAfter, xBefore, targetPosition);
                }
                else
                {
                    Output.WriteLine("Warning: Parent of target element is NULL.");
                }
            }
            else
            {
                Output.WriteLine("Warning: Target element NOT found.");
            }
        }

        #endregion Remove

        #region ReplaceChild<T>(OpenXmlElement, T)

        private protected void ReplaceChildOnFile(IFile testfile, GetTargetPart getHostPart, GetTargetElement getHost, GetTargetElement getTarget,
            IFile sourceFile, GetTargetPart getSrcPart, GetTargetElement getReplace, Type replaceType)
        {
            using (OpenXmlPackage target = testfile.Open(true))
            using (OpenXmlPackage source = sourceFile.Open(false))
            {
                OpenXmlPart hostPart = getHostPart(target);
                OpenXmlPart srcHostPart = getSrcPart(source);

                if (!hostPart.IsReflectable() || !srcHostPart.IsReflectable())
                {
                    Output.WriteLine("Warning: Either hostPart or srcHostPart is NOT reflectable.");
                }

                ReplaceChild(hostPart, getHost, getTarget, srcHostPart, getReplace, replaceType);
            }
        }

        private void ReplaceChild(OpenXmlPart hostPart, GetTargetElement getHost, GetTargetElement getTarget,
            OpenXmlPart srcPart, GetTargetElement getReplace, Type replaceType)
        {
            Output.WriteLine("Loading root element from hosting part...");
            OpenXmlPartRootElement main = hostPart.RootElement();
            Output.WriteLine("Loading root element from source part...");
            OpenXmlPartRootElement srcMain = srcPart.RootElement();

            Output.WriteLine("Looking for target element in {0}...", hostPart.GetType().Name);
            var hostElement = getHost(main);
            Output.WriteLine("Found host element: {0}", hostElement.Path());
            var targetElement = getTarget(hostElement);
            if (targetElement is not null)
            {
                Output.WriteLine("Target element found: {0}", targetElement.Path());

                int expectPos = targetElement.Index();

                Output.WriteLine("Looking for importing element in {0}...", srcPart.GetType().Name);
                var importElement = getReplace(srcMain);
                if (importElement is not null)
                {
                    Output.WriteLine("Importing element found: {0}", importElement.Path());

                    Output.WriteLine("Looking for ReplaceChild<T>() by reflecting...");
                    var flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.FlattenHierarchy;
                    var replaceChild = hostElement.GetType().GetMethods(flag)
                        .Where(m => m.IsGenericMethod && m.Name.StartsWith("ReplaceChild"))
                        .First();
                    Assert.NotNull(replaceChild);

                    XElement xBefore = ConvertToXElement(hostPart, hostElement);
                    XElement xImport = ConvertToXElement(srcPart, importElement);
                    Output.WriteLine("Replacing child of {0} from host element...", replaceType.Name);
                    replaceChild = replaceChild.MakeGenericMethod(replaceType);
                    var result = replaceChild.Invoke(hostElement, new object[] { importElement.CloneNode(true), targetElement });

                    Output.WriteLine("Saving changes...");
                    main.Save();

                    XElement xAfter = ConvertToXElement(hostPart, hostElement);

                    Output.WriteLine("Check if Count of ChildElement changed...");
                    Assert.True(xBefore.Elements().Count() == xAfter.Elements().Count(), string.Format("ChildElement Count: {0} Changed After Replacing.", xBefore.Elements().Count()));

                    VerifyEqual(xAfter, xImport, expectPos);
                }
                else
                {
                    Output.WriteLine("Warning: Importing element NOT found.");
                }
            }
            else
            {
                Output.WriteLine("Warning: Target element to be replaced NOT found.");
            }
        }

        #endregion ReplaceChild<T>(OpenXmlElement, T)

        #region Find Element with condition on attributes

        internal GetTargetElement GetElementWithMixedAttribute =>
            e => e.Descendants()
                .Where(d => d.ExtendedAttributes.Any())
                .Where(d => d.GetAttributes().Count > d.ExtendedAttributes.Count())
                .FirstOrDefault();

        internal GetTargetElement GetElementWithFixedAttributeOnly =>
            e => e.Descendants()
                .Where(d => !d.ExtendedAttributes.Any() && d.GetAttributes().Count > 0)
                .FirstOrDefault();

        internal GetTargetElement GetElementWithExtendedAttributeOnly =>
            e => e.Descendants()
                .Where(d => d.ExtendedAttributes.Any() && d.GetAttributes().Count == 0)
                .FirstOrDefault();

        internal GetTargetElement GetElementWithAttributes =>
            e => e.Descendants()
                .Where(d => d.GetAttributes().Count > 0)
                .FirstOrDefault();

        internal GetTargetElement GetElementWithoutAttributes =>
            e => e.Descendants()
                .Where(d => d.GetAttributes().Count == 0)
                .FirstOrDefault();

        internal GetTargetElement GetElementWithNamespaceDeclarations =>
            e => e.Descendants().Union(new OpenXmlElement[] { e })
                .Where(d => d.NamespaceDeclarations.Any())
                .FirstOrDefault();

        internal GetTargetElement GetElementWithoutNamespaceDeclarations =>
            e => e.Descendants()
                .Where(d => !d.NamespaceDeclarations.Any())
                .FirstOrDefault();
        #endregion Find Element with condition on attributes

        #region Find Attribute

        internal GetTargetAttribute GetFixedAttribute =>
            e => e.GetFixedAttributes().PickSecond();

        internal GetTargetAttribute GetNonExistingFixedAttribute =>
            e => e.GetFixedAttributes()
                .Where(fa => e.GetAttributes().All(ea => ea.NamespaceUri != fa.NamespaceUri || ea.LocalName != fa.LocalName))
                .FirstOrDefault();

        internal GetTargetAttribute GetExistingAttribute =>
            e => e.GetAttributes().PickSecond();

        internal GetTargetAttribute GetExistingExtendedAttribute =>
            e => e.ExtendedAttributes.PickSecond();

        internal GetTargetAttribute GetExistingFixedAttribute =>
            e =>
            {
                var attributes = e.GetAttributes()
                    .Where(a => e.ExtendedAttributes
                        .All(ex => ex.NamespaceUri != a.NamespaceUri || ex.LocalName != a.LocalName));
                return attributes.PickSecond();
            };

        internal GetTargetNamespaceDeclaration GetNonExistingNamespaceDeclaration =>
            e => e.Ancestors()
                .SelectMany(a => a.NamespaceDeclarations)
                .FirstOrDefault(an => !e.NamespaceDeclarations.Select(en => en.Key).Contains(an.Key));

        internal GetTargetNamespaceDeclaration GetExistingNamespaceDeclaration =>
            e => e.NamespaceDeclarations.PickSecond();

        #endregion Find Attribute

        #region GetAttribute(string localName, string namespaceUri)

        private protected void GetAttributeOnFile(IFile testfile, GetTargetPart getHostPart, GetTargetElement getHost)
        {
            using (OpenXmlPackage target = testfile.Open(true))
            {
                OpenXmlPart hostPart = getHostPart(target);

                if (!hostPart.IsReflectable())
                {
                    Output.WriteLine("Warning: Either hostPart is NOT reflectable.");
                }

                GetAttribute(hostPart, getHost);
            }
        }

        private void GetAttribute(OpenXmlPart hostPart, GetTargetElement getHost)
        {
            Output.WriteLine("Loading root element from hosting part...");
            OpenXmlPartRootElement main = hostPart.RootElement();

            Output.WriteLine("Looking for target element in {0}...", hostPart.GetType().Name);
            var hostElement = getHost(main);
            if (hostElement is not null)
            {
                Output.WriteLine("Host element found: {0}", hostElement.Path());

                XElement xBefore = ConvertToXElement(hostPart, hostElement);
                XAttribute xAttribute = xBefore.Attributes().FirstOrDefault();

                var attribute = hostElement.GetAttribute(xAttribute.Name.LocalName, xAttribute.Name.NamespaceName);

                Output.WriteLine("Checking if attribute: {0} has correct value as XAttribute...", xAttribute.Name);
                Assert.Equal(xAttribute.Value, attribute.Value);
            }
            else
            {
                Output.WriteLine("Warning: Host element NOT found.");
            }
        }

        #endregion GetAttribute

        #region GetAttributes

        private protected void GetAttributesOnFile(IFile testfile, GetTargetPart getHostPart, GetTargetElement getHost)
        {
            using (OpenXmlPackage target = testfile.Open(true))
            {
                OpenXmlPart hostPart = getHostPart(target);

                if (!hostPart.IsReflectable())
                {
                    Output.WriteLine("Warning: Either hostPart is NOT reflectable.");
                }

                GetAttributes(hostPart, getHost);
            }
        }

        private void GetAttributes(OpenXmlPart hostPart, GetTargetElement getHost)
        {
            Output.WriteLine("Loading root element from hosting part...");
            OpenXmlPartRootElement main = hostPart.RootElement();

            Output.WriteLine("Looking for target element in {0}...", hostPart.GetType().Name);
            var hostElement = getHost(main);
            if (hostElement is not null)
            {
                Output.WriteLine("Host element found: {0}", hostElement.Path());

                XElement xBefore = ConvertToXElement(hostPart, hostElement);
                var attributes = hostElement.GetAttributes();

                Output.WriteLine("Checking if attributes count is correct...");
                Assert.Equal(xBefore.Attributes().Where(xa => !xa.IsNamespaceDeclaration).Count(), attributes.Count);

                Output.WriteLine("Checking if attributes returned correctly...");
                foreach (var a in attributes)
                {
                    XAttribute xa = xBefore.Attribute(a.GetXName());
                    if (xa is null)
                    {
                        Assert.Fail(string.Format("Attribute {0} does NOT exist.", a.GetFullName()));
                    }
                    else
                    {
                        Assert.Equal(xa.Value, a.Value);
                    }
                }
            }
            else
            {
                Output.WriteLine("Warning: Host element NOT found.");
            }
        }

        #endregion GetAttributes

        #region SetAttribute(OpenXmlAttribute)

        private protected void SetAttributeOnFile(IFile testfile, GetTargetPart getHostPart, GetTargetElement getHost,
            IFile sourceFile, GetTargetPart getSrcPart, GetTargetElement getImportee, GetTargetAttribute getAttribute)
        {
            using (OpenXmlPackage target = testfile.Open(true))
            using (OpenXmlPackage source = sourceFile.Open(false))
            {
                OpenXmlPart hostPart = getHostPart(target);
                OpenXmlPart srcHostPart = getSrcPart(source);

                if (!hostPart.IsReflectable() || !srcHostPart.IsReflectable())
                {
                    Output.WriteLine("Warning: Either hostPart or srcHostPart is NOT reflectable.");
                }

                SetAttribute(hostPart, getHost, srcHostPart, getImportee, getAttribute);
            }
        }

        private void SetAttribute(OpenXmlPart hostPart, GetTargetElement getHost,
            OpenXmlPart srcPart, GetTargetElement getImportee, GetTargetAttribute getAttribute)
        {
            Output.WriteLine("Loading root element from hosting part...");
            OpenXmlPartRootElement main = hostPart.RootElement();
            Output.WriteLine("Loading root element from source part...");
            OpenXmlPartRootElement srcMain = srcPart.RootElement();

            Output.WriteLine("Looking for target element in {0}...", hostPart.GetType().Name);
            var hostElement = getHost(main);
            if (hostElement is not null)
            {
                Output.WriteLine("Host element found: {0}", hostElement.Path());

                XElement xBefore = ConvertToXElement(hostPart, hostElement);

                Output.WriteLine("Looking for importing element in {0}...", srcPart.GetType().Name);
                var importElement = getImportee(srcMain);
                if (importElement is not null)
                {
                    Output.WriteLine("Importing element found: {0}", importElement.Path());

                    var attribute = getAttribute(importElement);
                    if (attribute != default)
                    {
                        Output.WriteLine("Setting attribute {0} with value {1}...", attribute.GetFullName(), attribute.Value);

                        hostElement.SetAttribute(attribute);

                        Output.WriteLine("Saving changes...");
                        main.Save();

                        XElement xAfter = ConvertToXElement(hostPart, hostElement);
                        Output.WriteLine("Verifying element: {0} was set to expected value: {1}", attribute.GetFullName(), attribute.Value);
                        Assert.Equal(attribute.Value, xAfter.Attribute(attribute.GetXName()).Value);
                    }
                    else
                    {
                        Output.WriteLine("Warning: Setting Null attribute to host element...");
                    }
                }
                else
                {
                    Output.WriteLine("Warning: Importing element NOT found.");
                }
            }
            else
            {
                Output.WriteLine("Warning: Host element NOT found.");
            }
        }

        private protected void SetAttributesOnFile(IFile testfile, GetTargetPart getHostPart, GetTargetElement getHost,
            IFile sourceFile, GetTargetPart getSrcPart, GetTargetElement getImportee)
        {
            using (OpenXmlPackage target = testfile.Open(true))
            using (OpenXmlPackage source = sourceFile.Open(false))
            {
                OpenXmlPart hostPart = getHostPart(target);
                OpenXmlPart srcHostPart = getSrcPart(source);

                if (!hostPart.IsReflectable() || !srcHostPart.IsReflectable())
                {
                    Output.WriteLine("Warning: Either hostPart or srcHostPart is NOT reflectable.");
                }

                SetAttributes(hostPart, getHost, srcHostPart, getImportee);
            }
        }

        private void SetAttributes(OpenXmlPart hostPart, GetTargetElement getHost,
            OpenXmlPart srcPart, GetTargetElement getImportee)
        {
            Output.WriteLine("Loading root element from hosting part...");
            OpenXmlPartRootElement main = hostPart.RootElement();
            Output.WriteLine("Loading root element from source part...");
            OpenXmlPartRootElement srcMain = srcPart.RootElement();

            Output.WriteLine("Looking for target element in {0}...", hostPart.GetType().Name);
            var hostElement = getHost(main);
            if (hostElement is not null)
            {
                Output.WriteLine("Host element found: {0}", hostElement.Path());

                XElement xBefore = ConvertToXElement(hostPart, hostElement);

                Output.WriteLine("Looking for importing element in {0}...", srcPart.GetType().Name);
                var importElement = getImportee(srcMain);
                if (importElement is not null)
                {
                    Output.WriteLine("Importing element found: {0}", importElement.Path());

                    var attributes = importElement.GetAttributes().AsEnumerable();

                    Output.WriteLine("Setting attributes in batch...");
                    hostElement.SetAttributes(attributes);

                    Output.WriteLine("Saving changes...");
                    main.Save();

                    XElement xAfter = ConvertToXElement(hostPart, hostElement);
                    Output.WriteLine("Checking if count of current element attributes is expected value {0}...", xAfter.Attributes().Where(xa => !xa.IsNamespaceDeclaration).Count());
                    Assert.True(hostElement.GetAttributes().Count == xAfter.Attributes().Where(xa => !xa.IsNamespaceDeclaration).Count(), string.Format("Count of element attributes {0} is NOT expected value {1}.", hostElement.GetAttributes().Count, xAfter.Attributes().Where(xa => !xa.IsNamespaceDeclaration).Count()));

                    foreach (var a in attributes)
                    {
                        var xa = xAfter.Attribute(a.GetXName());
                        Assert.NotNull(xa);
                        if (xa is not null)
                        {
                            Assert.Equal(a.Value, xa.Value);
                        }
                    }
                }
                else
                {
                    Output.WriteLine("Warning: Importing element NOT found.");
                }
            }
            else
            {
                Output.WriteLine("Warning: Host element NOT found.");
            }
        }

        #endregion SetAttribute(OpenXmlAttribute)

        #region RemoveAttribute(localName, namespaceUri)

        private protected void RemoveAttributeOnFile(IFile testfile, GetTargetPart getHostPart, GetTargetElement getHost, GetTargetAttribute getRemoveAttribute)
        {
            using (OpenXmlPackage target = testfile.Open(true))
            {
                OpenXmlPart hostPart = getHostPart(target);

                if (!hostPart.IsReflectable())
                {
                    Output.WriteLine("Warning: Either hostPart is NOT reflectable.");
                }

                RemoveAttribute(hostPart, getHost, getRemoveAttribute);
            }
        }

        private void RemoveAttribute(OpenXmlPart hostPart, GetTargetElement getHost, GetTargetAttribute getRemoveAttribute)
        {
            Output.WriteLine("Loading root element from hosting part...");
            OpenXmlPartRootElement main = hostPart.RootElement();

            Output.WriteLine("Looking for target element in {0}...", hostPart.GetType().Name);
            var hostElement = getHost(main);
            if (hostElement is not null)
            {
                Output.WriteLine("Host element found: {0}", hostElement.Path());

                XElement xBefore = ConvertToXElement(hostPart, hostElement);

                var attributes = hostElement.GetAttributes();       // Return non-live source of attributes
                Output.WriteLine("Current host element {0} has {1} attributes.", hostElement.GetFullName(), hostElement.GetAttributes().Count);
                Assert.Equal(hostElement.GetAttributes().Count, xBefore.Attributes().Where(e => !e.IsNamespaceDeclaration).Count());

                Output.WriteLine("Looking for target attribute to remove...");
                OpenXmlAttribute remove = getRemoveAttribute(hostElement);

                if (remove != default)
                {
                    Output.WriteLine("Removing Attribute {0}", remove.GetFullName());

                    hostElement.RemoveAttribute(remove.LocalName, remove.NamespaceUri);

                    Output.WriteLine("Saving changes...");
                    main.Save();

                    XElement xAfter = ConvertToXElement(hostPart, hostElement);
                    Output.WriteLine("Checking attributes count...");
                    Assert.Equal(hostElement.GetAttributes().Count, xAfter.Attributes().Where(xa => !xa.IsNamespaceDeclaration).Count());

                    Output.WriteLine("Checking if attribute removed correctly...");
                    XAttribute a = xAfter.Attribute(remove.GetXName());
                    Assert.Null(a);
                }
                else
                {
                    Output.WriteLine("Warning: Target attribute NOT found.");
                }
            }
            else
            {
                Output.WriteLine("Warning: Host element which attribute to be removed NOT found.");
            }
        }

        #endregion RemoveAttribute(localName, namespaceUri)

        #region ClearAllAttributes

        private protected void ClearAllAttributesOnFile(IFile testfile, GetTargetPart getHostPart, GetTargetElement getHost)
        {
            using (OpenXmlPackage target = testfile.Open(true))
            {
                OpenXmlPart hostPart = getHostPart(target);

                if (!hostPart.IsReflectable())
                {
                    Output.WriteLine("Warning: Either hostPart is NOT reflectable.");
                }

                ClearAllAttributes(hostPart, getHost);
            }
        }

        private void ClearAllAttributes(OpenXmlPart hostPart, GetTargetElement getHost)
        {
            Output.WriteLine("Loading root element from hosting part...");
            OpenXmlPartRootElement main = hostPart.RootElement();

            Output.WriteLine("Looking for target element in {0}...", hostPart.GetType().Name);
            var hostElement = getHost(main);
            if (hostElement is not null)
            {
                Output.WriteLine("Host element found: {0}", hostElement.Path());

                var attributes = hostElement.GetAttributes();
                XElement xBefore = ConvertToXElement(hostPart, hostElement);

                Output.WriteLine("Clearing all attributes...");
                hostElement.ClearAllAttributes();

                Output.WriteLine("Saving changes...");
                main.Save();

                XElement xAfter = ConvertToXElement(hostPart, hostElement);
                Output.WriteLine("Checking if attributes count is ZERO now...");
                Assert.Equal(0, xAfter.Attributes().Where(xa => !xa.IsNamespaceDeclaration).Count());

                Output.WriteLine("Checking if attributes returned correctly...");
                foreach (var a in attributes)
                {
                    XNamespace xns = a.NamespaceUri;
                    Assert.Null(xAfter.Attribute(a.GetXName()));
                }
            }
            else
            {
                Output.WriteLine("Warning: Host element which attributes to be removed NOT found.");
            }
        }

        #endregion ClearAllAttributes

        #region AddNamespaceDeclaration
        private protected void AddNamespaceDeclarationOnFile(IFile testfile, GetTargetPart getHostPart, GetTargetElement getHost,
            IFile sourceFile, GetTargetPart getSrcPart, GetTargetElement getImportee, GetTargetNamespaceDeclaration getNamespaceDeclaration)
        {
            using (OpenXmlPackage target = testfile.Open(true))
            using (OpenXmlPackage source = sourceFile.Open(false))
            {
                OpenXmlPart hostPart = getHostPart(target);
                OpenXmlPart srcHostPart = getSrcPart(source);

                if (!hostPart.IsReflectable() || !srcHostPart.IsReflectable())
                {
                    Output.WriteLine("Warning: Either hostPart or srcHostPart is NOT reflectable.");
                }

                AddNamespaceDeclaration(hostPart, getHost, srcHostPart, getImportee, getNamespaceDeclaration);
            }
        }

        private void AddNamespaceDeclaration(OpenXmlPart hostPart, GetTargetElement getHost,
            OpenXmlPart srcPart, GetTargetElement getImportee, GetTargetNamespaceDeclaration getNamespaceDeclaration)
        {
            Output.WriteLine("Loading root element from hosting part...");
            OpenXmlPartRootElement main = hostPart.RootElement();
            Output.WriteLine("Loading root element from source part...");
            OpenXmlPartRootElement srcMain = srcPart.RootElement();

            Output.WriteLine("Looking for target element in {0}...", hostPart.GetType().Name);
            var hostElement = getHost(main);
            if (hostElement is not null)
            {
                Output.WriteLine("Host element found: {0}", hostElement.Path());

                Output.WriteLine("NamespaceDeclarations returned by SDK before adding...");
                var namespaceDeclarations = hostElement.NamespaceDeclarations;
                foreach (var ns in namespaceDeclarations)
                {
                    Output.WriteLine("xmlns:{0} = {1}", ns.Key, ns.Value);
                }

                XElement xBefore = ConvertToXElement(hostPart, hostElement);
                Output.WriteLine("NamespaceDeclarations returned by XLink on same element...");
                foreach (var xa in xBefore.Attributes().Where(xa => xa.IsNamespaceDeclaration))
                {
                    Output.WriteLine("xmlns:{0} = {1}", xa.Name.LocalName, xa.Value);
                }

                Output.WriteLine("Looking for importing element in {0}...", srcPart.GetType().Name);
                var importElement = getImportee(srcMain);
                if (importElement is not null)
                {
                    Output.WriteLine("Importing element found: {0}", importElement.Path());

                    var newNs = getNamespaceDeclaration(importElement);
                    if (newNs.Key is not null || newNs.Value is not null)
                    {
                        Output.WriteLine("Setting NamespaceDeclaration {0} with value {1}...", newNs.Key, newNs.Value);

                        if (!hostElement.NamespaceDeclarations.Where(e => (e.Key == newNs.Key && e.Value == newNs.Value)).Any())
                        {
                            hostElement.AddNamespaceDeclaration(newNs.Key, newNs.Value);

                            Output.WriteLine("NamespaceDeclarations returned by SDK after adding...");
                            foreach (var ns in hostElement.NamespaceDeclarations)
                            {
                                Output.WriteLine("xmlns:{0} = {1}", ns.Key, ns.Value);
                            }

                            Assert.True(hostElement.NamespaceDeclarations.Where(ns => ns.Key == newNs.Key).Count() == 1, string.Format("NamespaceDeclaration {0} was NOT added as expected.", newNs.Key));
                        }

                        Output.WriteLine("Saving changes...");
                        main.Save();
                    }
                    else
                    {
                        Output.WriteLine("Warning: Setting Null NamespaceDeclaration to host element...");
                    }
                }
                else
                {
                    Output.WriteLine("Warning: Importing element NOT found.");
                }
            }
            else
            {
                Output.WriteLine("Warning: Host element NOT found.");
            }
        }
        #endregion AddNamespaceDeclaration

        #region RemoveNamespaceDeclaration

        private protected void RemoveNamespaceDeclarationOnFile(IFile testfile, GetTargetPart getHostPart, GetTargetElement getHost, GetTargetNamespaceDeclaration getRemoveNS)
        {
            using (OpenXmlPackage target = testfile.Open(true))
            {
                OpenXmlPart hostPart = getHostPart(target);

                if (!hostPart.IsReflectable())
                {
                    Output.WriteLine("Warning: Either hostPart is NOT reflectable.");
                }

                RemoveNamespaceDeclaration(hostPart, getHost, getRemoveNS);
            }
        }

        private void RemoveNamespaceDeclaration(OpenXmlPart hostPart, GetTargetElement getHost, GetTargetNamespaceDeclaration getRemoveNS)
        {
            Output.WriteLine("Loading root element from hosting part...");
            OpenXmlPartRootElement main = hostPart.RootElement();

            Output.WriteLine("Looking for target element in {0}...", hostPart.GetType().Name);
            var hostElement = getHost(main);
            if (hostElement is not null)
            {
                Output.WriteLine("Host element found: {0}", hostElement.Path());

                Output.WriteLine("NamespaceDeclarations returned by SDK before removing...");
                var namespaceDeclarations = hostElement.NamespaceDeclarations;
                foreach (var ns in namespaceDeclarations)
                {
                    Output.WriteLine("xmlns:{0} = {1}", ns.Key, ns.Value);
                }

                XElement xBefore = ConvertToXElement(hostPart, hostElement);
                Output.WriteLine("NamespaceDeclarations returned by XLink on same element...");
                foreach (var xa in xBefore.Attributes().Where(xa => xa.IsNamespaceDeclaration))
                {
                    Output.WriteLine("xmlns:{0} = {1}", xa.Name.LocalName, xa.Value);
                }

                var nss = hostElement.NamespaceDeclarations;       // Return non-live source of NamespaceDeclaration
                Output.WriteLine("Current host element {0} has {1} NamespaceDeclarations.", hostElement.GetFullName(), nss.Count());
                Assert.Equal(hostElement.NamespaceDeclarations.Count(), xBefore.Attributes().Where(xa => xa.IsNamespaceDeclaration && xa.Name != "xmlns").Count());

                Output.WriteLine("Looking for target NamespaceDeclaration to remove...");
                var remove = getRemoveNS(hostElement);
                if (remove.Key is not null || remove.Value is not null)
                {
                    Output.WriteLine("Removing NamespaceDeclaration {0}:{1}", remove.Key, remove.Value);

                    hostElement.RemoveNamespaceDeclaration(remove.Key);

                    Output.WriteLine("NamespaceDeclarations returned by SDK after removing...");
                    foreach (var ns in hostElement.NamespaceDeclarations)
                    {
                        Output.WriteLine("xmlns:{0} = {1}", ns.Key, ns.Value);
                    }

                    Assert.True(!hostElement.NamespaceDeclarations.Where(ns => ns.Key == remove.Key).Any(), string.Format("NamespaceDeclaration {0} was NOT removed as expected.", remove.Key));

                    Output.WriteLine("Saving changes...");
                    main.Save();
                }
                else
                {
                    Output.WriteLine("Warning: Target NamespaceDeclaration NOT found.");
                }
            }
            else
            {
                Output.WriteLine("Warning: Host element which NamespaceDeclaration to be removed NOT found.");
            }
        }
        #endregion RemoveNamespaceDeclaration

        #region NamespaceDeclarations

        private protected void NamespaceDeclarationsOnFile(IFile testfile, GetTargetPart getHostPart, GetTargetElement getHost)
        {
            using (OpenXmlPackage target = testfile.Open(true))
            {
                OpenXmlPart hostPart = getHostPart(target);

                if (!hostPart.IsReflectable())
                {
                    Output.WriteLine("Warning: Either hostPart is NOT reflectable.");
                }

                NamespaceDeclarations(hostPart, getHost);
            }
        }

        private void NamespaceDeclarations(OpenXmlPart hostPart, GetTargetElement getHost)
        {
            Output.WriteLine("Loading root element from hosting part...");
            OpenXmlPartRootElement main = hostPart.RootElement();

            Output.WriteLine("Looking for target element in {0}...", hostPart.GetType().Name);
            var hostElement = getHost(main);
            if (hostElement is not null)
            {
                Output.WriteLine("Host element found: {0}", hostElement.Path());

                Output.WriteLine("NamespaceDeclarations returned by SDK on the element...");
                var namespaceDeclarations = hostElement.NamespaceDeclarations;
                foreach (var ns in namespaceDeclarations)
                {
                    Output.WriteLine("xmlns:{0} = {1}", ns.Key, ns.Value);
                }

                XElement xBefore = ConvertToXElement(hostPart, hostElement);
                Output.WriteLine("NamespaceDeclarations returned by XLink on same element...");
                foreach (var xa in xBefore.Attributes().Where(xa => xa.IsNamespaceDeclaration && xa.Name.LocalName != "xmlns"))
                {
                    Output.WriteLine("xmlns:{0} = {1}", xa.Name.LocalName, xa.Value);
                }

                Output.WriteLine("Checking if NamespaceDeclarations count is correct...");
                Assert.Equal(xBefore.Attributes().Where(a => a.IsNamespaceDeclaration && a.Name.LocalName != "xmlns").Count(), namespaceDeclarations.Count());

                Output.WriteLine("Checking if NamespaceDeclarations returned correctly...");
                foreach (var ns in namespaceDeclarations)
                {
                    var nsUri = xBefore.GetNamespaceOfPrefix(ns.Key).NamespaceName;
                    if (nsUri is null)
                    {
                        Assert.Fail(string.Format("NamespaceDeclaration {0} does NOT exist.", ns.Key));
                    }
                    else
                    {
                        Assert.Equal(nsUri, ns.Value);
                    }
                }
            }
            else
            {
                Output.WriteLine("Warning: Host element NOT found.");
            }
        }
        #endregion NamespaceDeclarations

        #region OuterXml

        private protected void GetOuterXmlOnFile(IFile testfile, GetTargetPart getHostPart, GetTargetElement getHost)
        {
            using (OpenXmlPackage target = testfile.Open(true))
            {
                OpenXmlPart hostPart = getHostPart(target);

                if (!hostPart.IsReflectable())
                {
                    Output.WriteLine("Warning: Current HostPart is NOT reflectable.");
                }

                GetOuterXml(hostPart, getHost);
            }
        }

        private void GetOuterXml(OpenXmlPart hostPart, GetTargetElement getHost)
        {
            Output.WriteLine("Loading root element from hosting part...");
            OpenXmlPartRootElement main = hostPart.RootElement();

            Output.WriteLine("Looking for target element in {0}...", hostPart.GetType().Name);
            var hostElement = getHost(main);
            if (hostElement is not null)
            {
                Output.WriteLine("Host element found: {0}", hostElement.Path());

                XElement xBefore = ConvertToXElement(hostPart, hostElement);
                string outerXml = hostElement.OuterXml;

                Output.WriteLine("Checking if XElement count vs OpenXmlElement Children Count...");
                Assert.True(hostElement.ChildElements.Count == xBefore.Elements().Count(), string.Format("Children element returned by OpenXmlElement {0} is different from XElement {1}", hostElement.ChildElements.Count, xBefore.Elements().Count()));

                var result = xBefore.Compare(XElement.Parse(outerXml));
                Assert.True(result, "OuterXml is not returned as expected.");
            }
            else
            {
                Output.WriteLine("Warning: Host element NOT found.");
            }
        }

        #endregion OuterXml

        #region Clone

        private protected void CloneOnFile(IFile testfile, GetTargetPart getHostPart, GetTargetElement getHost)
        {
            using (OpenXmlPackage target = testfile.Open(true))
            {
                OpenXmlPart hostPart = getHostPart(target);

                if (!hostPart.IsReflectable())
                {
                    Output.WriteLine("Warning: Current hostPart is NOT reflectable.");
                }

                Clone(hostPart, getHost);
            }
        }

        private void Clone(OpenXmlPart hostPart, GetTargetElement getHost)
        {
            Output.WriteLine("Loading root element from hosting part...");
            OpenXmlPartRootElement main = hostPart.RootElement();

            Output.WriteLine("Looking for target element in {0}...", hostPart.GetType().Name);
            var hostElement = getHost(main);
            if (hostElement is not null)
            {
                Output.WriteLine("Host element found: {0}", hostElement.Path());

                XElement xBefore = ConvertToXElement(hostPart, hostElement);

                // Clone() behaves as CloneNode(true) except it return object instead of OpenXmlElement
                Output.WriteLine("Deep Clone ...");
                var clone = hostElement.Clone() as OpenXmlElement;
                string outerXml = clone.OuterXml;
                var xAfter = XElement.Parse(outerXml);

                Output.WriteLine("Checking if XElement count vs OpenXmlElement Children Count...");
                Assert.True(hostElement.ChildElements.Count == xBefore.Elements().Count(), string.Format("Children element returned by OpenXmlElement {0} is different from XElement {1}", hostElement.ChildElements.Count, xBefore.Elements().Count()));

                var result = xBefore.Compare(XElement.Parse(outerXml));
                Assert.True(result, "Pass-in element is not cloned as expected.");
            }
            else
            {
                Output.WriteLine("Warning: Host element NOT found.");
            }
        }

        private protected void CloneNodeFalseOnFile(IFile testfile, GetTargetPart getHostPart, GetTargetElement getHost)
        {
            using (OpenXmlPackage target = testfile.Open(true))
            {
                OpenXmlPart hostPart = getHostPart(target);

                if (!hostPart.IsReflectable())
                {
                    Output.WriteLine("Warning: Current hostPart is NOT reflectable.");
                }

                CloneNodeFalse(hostPart, getHost);
            }
        }

        private void CloneNodeFalse(OpenXmlPart hostPart, GetTargetElement getHost)
        {
            Output.WriteLine("Loading root element from hosting part...");
            OpenXmlPartRootElement main = hostPart.RootElement();

            Output.WriteLine("Looking for target element in {0}...", hostPart.GetType().Name);
            var hostElement = getHost(main);
            if (hostElement is not null)
            {
                Output.WriteLine("Host element found: {0}", hostElement.Path());

                var attributes = hostElement.GetAttributes();
                XElement xBefore = ConvertToXElement(hostPart, hostElement);

                // CloneNode(false) returns tag and attributes of current element
                Output.WriteLine("Shallow Clone ...");
                var clone = hostElement.CloneNode(false);

                Assert.Equal(0, clone.ChildElements.Count);
                Assert.Equal(hostElement.GetFullName(), clone.GetFullName());
                Output.WriteLine("Verifying attributes cloned exactly...");
                foreach (var ca in clone.GetAttributes())
                {
                    var result = attributes.Any(a => a.GetFullName() == ca.GetFullName() && a.Value == ca.Value);
                    if (result)
                    {
                        Output.WriteLine("Verified same attribute {0}={1}", ca.GetFullName(), ca.Value);
                    }
                    else
                    {
                        Assert.Fail(string.Format("attribute {0} not found with expected value {1}", ca.GetFullName(), ca.Value));
                    }
                }
            }
            else
            {
                Output.WriteLine("Warning: Host element NOT found.");
            }
        }

        #endregion Clone

        #region InnerXml

        private protected void GetInnerXmlOnFile(IFile testfile, GetTargetPart getHostPart, GetTargetElement getHost)
        {
            using (OpenXmlPackage target = testfile.Open(true))
            {
                OpenXmlPart hostPart = getHostPart(target);

                if (!hostPart.IsReflectable())
                {
                    Output.WriteLine("Warning: Current hostPart is NOT reflectable.");
                }

                GetInnerXml(hostPart, getHost);
            }
        }

        private void GetInnerXml(OpenXmlPart hostPart, GetTargetElement getHost)
        {
            Output.WriteLine("Loading root element from hosting part...");
            OpenXmlPartRootElement main = hostPart.RootElement();

            Output.WriteLine("Looking for target element in {0}...", hostPart.GetType().Name);
            var hostElement = getHost(main);
            if (hostElement is not null)
            {
                Output.WriteLine("Host element found: {0}", hostElement.Path());

                Output.WriteLine("Accumulating child elements' OuterXml...");
                var elementsXml = string.Empty;
                if (hostElement.HasChildren)
                {
                    elementsXml = hostElement.ChildElements.Aggregate(elementsXml, (cs, e) => cs + e.OuterXml);
                }
                else
                {
                    elementsXml = hostElement is OpenXmlLeafTextElement ? hostElement.InnerText : string.Empty;
                }

                Output.WriteLine("Verifying InnerXml with accumulated child elements' OuterXml...");
                string innerXml = hostElement.InnerXml;
                Assert.Equal(elementsXml, innerXml);
            }
            else
            {
                Output.WriteLine("Warning: Host element NOT found.");
            }
        }

        private protected void SetInnerXmlOnFile(IFile testfile, GetTargetPart getHostPart, GetTargetElement getHost,
            IFile sourceFile, GetTargetPart getSrcPart, GetTargetElement getImportee)
        {
            using (OpenXmlPackage target = testfile.Open(true))
            using (OpenXmlPackage source = sourceFile.Open(false))
            {
                OpenXmlPart hostPart = getHostPart(target);
                OpenXmlPart srcHostPart = getSrcPart(source);

                if (!hostPart.IsReflectable() || !srcHostPart.IsReflectable())
                {
                    Output.WriteLine("Warning: Either hostPart or srcHostPart is NOT reflectable.");
                }

                SetInnerXml(hostPart, getHost, srcHostPart, getImportee);
            }
        }

        private void SetInnerXml(OpenXmlPart hostPart, GetTargetElement getHost,
            OpenXmlPart srcPart, GetTargetElement getImportee)
        {
            Output.WriteLine("Loading root element from hosting part...");
            OpenXmlPartRootElement main = hostPart.RootElement();
            Output.WriteLine("Loading root element from source part...");
            OpenXmlPartRootElement srcMain = srcPart.RootElement();

            Output.WriteLine("Looking for target element in {0}...", hostPart.GetType().Name);
            var hostElement = getHost(main);
            if (hostElement is not null)
            {
                Output.WriteLine("Host element found: {0}.", hostElement.Path());

                Output.WriteLine("Looking for importing element in {0}...", srcPart.GetType().Name);
                var importHost = getImportee(srcMain);
                if (importHost is not null)
                {
                    Output.WriteLine("Importing element found: {0}.", importHost.Path());

                    XElement xBefore = ConvertToXElement(hostPart, hostElement);
                    var fullName = hostElement.GetFullName();
                    var attributes = hostElement.GetAttributes();

                    Output.WriteLine("Accumulating {0} child elements' OuterXml of {1}...", importHost.ChildElements.Count, importHost.GetFullName());
                    var elementsXml = string.Empty;
                    elementsXml = importHost.ChildElements.Aggregate(elementsXml, (cs, e) => cs + e.OuterXml);

                    Output.WriteLine("Setting InnerXml...");
                    hostElement.InnerXml = elementsXml;

                    Output.WriteLine("Saving changes...");
                    main.Save();

                    XElement xAfter = ConvertToXElement(hostPart, hostElement);

                    Assert.Equal(fullName, hostElement.GetFullName());
                    Output.WriteLine("Verifying attributes are kept exactly...");
                    foreach (var ca in hostElement.GetAttributes())
                    {
                        var result = attributes.Any(a => a.GetFullName() == ca.GetFullName() && a.Value == ca.Value);
                        if (result)
                        {
                            Output.WriteLine("Verified same attribute {0}={1}", ca.GetFullName(), ca.Value);
                        }
                        else
                        {
                            Assert.Fail(string.Format("attribute {0} not found with expected value {1}", ca.GetFullName(), ca.Value));
                        }
                    }

                    Output.WriteLine("Checking if children element are set onto host...");
                    Assert.Equal(importHost.ChildElements.Count, xAfter.Elements().Count());
                    for (int i = 0; i < importHost.ChildElements.Count; i++)
                    {
                        var importElementOuterXml = importHost.ChildElements[i].OuterXml;
                        VerifyEqual(xAfter, XElement.Parse(importElementOuterXml), i);
                    }
                }
                else
                {
                    Output.WriteLine("Warning: No Expected Element found");
                }
            }
            else
            {
                Output.WriteLine("Warning: Host element NOT found.");
            }
        }

        #endregion InnerXml

        #region WriteTo

        private protected void WriteToOnFile(IFile testfile, GetTargetPart getHostPart, GetTargetElement getHost)
        {
            using (OpenXmlPackage target = testfile.Open(true))
            {
                OpenXmlPart hostPart = getHostPart(target);

                if (!hostPart.IsReflectable())
                {
                    Output.WriteLine("Warning: Either hostPart is NOT reflectable.");
                }

                WriteTo(hostPart, getHost);
            }
        }

        private void WriteTo(OpenXmlPart hostPart, GetTargetElement getHost)
        {
            Output.WriteLine("Loading root element from hosting part...");
            OpenXmlPartRootElement main = hostPart.RootElement();

            Output.WriteLine("Looking for target element in {0}...", hostPart.GetType().Name);
            var hostElement = getHost(main);
            if (hostElement is not null)
            {
                Output.WriteLine("Host element found with path: {0}.", hostElement.Path());

                XElement xBefore = ConvertToXElement(hostPart, hostElement);

                Output.WriteLine("Writ content To cache...");
                StringBuilder sb = new StringBuilder();
                using (var writer = XmlWriter.Create(sb))
                {
                    hostElement.WriteTo(writer);
                }

                string outerXml = sb.ToString();

                XElement xAfter = XElement.Parse(outerXml);
                Output.WriteLine("Checking if element count not changed...");
                Assert.True(xAfter.Elements().Count() == xBefore.Elements().Count(), string.Format("Children element in written out {0} is different from original {1}", xAfter.Elements().Count(), xBefore.Elements().Count()));

                Output.WriteLine("Comparing element content...");
                var result = xBefore.Compare(xAfter);
                Assert.True(result, "WriteTo returned different content from expected.");
            }
            else
            {
                Output.WriteLine("Warning: Host element NOT found.");
            }
        }

        #endregion WriteTo

        #region EventHandlers

        internal OpenXmlElement ValidReplaceEventHandler(OpenXmlElement hostElement)
        {
            hostElement.OpenXmlElementContext.ElementInserting += new EventHandler<ElementEventArgs>(ExpectedElementInserting);
            hostElement.OpenXmlElementContext.ElementInserted += new EventHandler<ElementEventArgs>(ExpectedElementInserted);
            hostElement.OpenXmlElementContext.ElementRemoving += new EventHandler<ElementEventArgs>(ExpectedElementRemoving);
            hostElement.OpenXmlElementContext.ElementRemoved += new EventHandler<ElementEventArgs>(ExpectedElementRemoved);
            return hostElement;
        }

        internal OpenXmlElement ValidInsertEventHandler(OpenXmlElement hostElement)
        {
            hostElement.OpenXmlElementContext.ElementInserting += new EventHandler<ElementEventArgs>(ExpectedElementInserting);
            hostElement.OpenXmlElementContext.ElementInserted += new EventHandler<ElementEventArgs>(ExpectedElementInserted);
            hostElement.OpenXmlElementContext.ElementRemoving += new EventHandler<ElementEventArgs>(SurprisingElementRemoving);
            hostElement.OpenXmlElementContext.ElementRemoved += new EventHandler<ElementEventArgs>(SurprisingElementRemoved);
            return hostElement;
        }

        internal OpenXmlElement ValidRemoveEventHandler(OpenXmlElement hostElement)
        {
            hostElement.OpenXmlElementContext.ElementInserting += new EventHandler<ElementEventArgs>(SurprisingElementInserting);
            hostElement.OpenXmlElementContext.ElementInserted += new EventHandler<ElementEventArgs>(SurprisingElementInserted);
            hostElement.OpenXmlElementContext.ElementRemoving += new EventHandler<ElementEventArgs>(ExpectedElementRemoving);
            hostElement.OpenXmlElementContext.ElementRemoved += new EventHandler<ElementEventArgs>(ExpectedElementRemoved);
            return hostElement;
        }

        internal OpenXmlElement InvalidEventHandler(OpenXmlElement hostElement)
        {
            hostElement.OpenXmlElementContext.ElementInserting += new EventHandler<ElementEventArgs>(SurprisingElementInserting);
            hostElement.OpenXmlElementContext.ElementInserted += new EventHandler<ElementEventArgs>(SurprisingElementInserted);
            hostElement.OpenXmlElementContext.ElementRemoving += new EventHandler<ElementEventArgs>(SurprisingElementRemoving);
            hostElement.OpenXmlElementContext.ElementRemoved += new EventHandler<ElementEventArgs>(SurprisingElementRemoved);
            return hostElement;
        }

        private void ExpectedElementInserting(object sender, ElementEventArgs args)
        {
            Output.WriteLine("ElementInserting event caught.");
            Output.WriteLine("[ElementInserting] Inserting {0} to {1}...", args.Element.GetFullName(), args.ParentElement.GetFullName());
            Assert.Null(args.Element.Parent);
            Assert.NotNull(args.ParentElement);

            Assert.True(sender is OpenXmlElementContext, string.Format("Sender is {0}, NOT OpenXmlElementContext!", sender.GetType().Name));
            Assert.Same(sender, args.ParentElement.OpenXmlElementContext);
            Assert.NotSame(sender, args.Element.OpenXmlElementContext);
        }

        private void SurprisingElementInserting(object sender, ElementEventArgs args)
        {
            Assert.Fail("ElementInserting event caught.");
            Output.WriteLine("[ElementInserting] Inserting {0} to {1}...", args.Element.GetFullName(), args.ParentElement.GetFullName());
            Assert.Null(args.Element.Parent);
            Assert.NotNull(args.ParentElement);

            Assert.True(sender is OpenXmlElementContext, string.Format("Sender is {0}, NOT OpenXmlElementContext!", sender.GetType().Name));
            Assert.Same(sender, args.ParentElement.OpenXmlElementContext);
            Assert.NotSame(sender, args.Element.OpenXmlElementContext);
        }

        private void ExpectedElementInserted(object sender, ElementEventArgs args)
        {
            Output.WriteLine("ElementInserted event caught.");
            Output.WriteLine("[ElementInserted] Inserted {0} to {1}...", args.Element.GetFullName(), args.ParentElement.GetFullName());
            Assert.NotNull(args.Element.Parent);
            Assert.True(args.ParentElement == args.Element.Parent, string.Format("Element inserted {0} has different parent from expected {1}.", args.Element.GetFullName(), args.ParentElement.GetFullName()));

            Assert.True(sender is OpenXmlElementContext, string.Format("Sender is {0}, NOT OpenXmlElementContext!", sender.GetType().Name));
            Assert.Same(sender, args.ParentElement.OpenXmlElementContext);
            Assert.Same(sender, args.Element.OpenXmlElementContext);
        }

        private void SurprisingElementInserted(object sender, ElementEventArgs args)
        {
            Assert.Fail("ElementInserted event caught.");
            Output.WriteLine("[ElementInserted] Inserted {0} to {1}...", args.Element.GetFullName(), args.ParentElement.GetFullName());
            Assert.NotNull(args.Element.Parent);
            Assert.True(args.ParentElement == args.Element.Parent, string.Format("Element inserted {0} has different parent from expected {1}.", args.Element.GetFullName(), args.ParentElement.GetFullName()));

            Assert.True(sender is OpenXmlElementContext, string.Format("Sender is {0}, NOT OpenXmlElementContext!", sender.GetType().Name));
            Assert.Same(sender, args.ParentElement.OpenXmlElementContext);
            Assert.Same(sender, args.Element.OpenXmlElementContext);
        }

        private void ExpectedElementRemoving(object sender, ElementEventArgs args)
        {
            Output.WriteLine("ElementRemoving event caught.");
            Output.WriteLine("[ElementRemoving] Removing {0} from {1}...", args.Element.GetFullName(), args.ParentElement.GetFullName());
            Assert.NotNull(args.Element.Parent);
            Assert.NotNull(args.ParentElement);
            Assert.True(args.ParentElement == args.Element.Parent, string.Format("Element to be removed {0} has different parent from expected {1}.", args.Element.GetFullName(), args.ParentElement.GetFullName()));

            Assert.True(sender is OpenXmlElementContext, string.Format("Sender is {0}, NOT OpenXmlElementContext!", sender.GetType().Name));
            Assert.Same(sender, args.ParentElement.OpenXmlElementContext);
            Assert.Same(sender, args.Element.OpenXmlElementContext);
        }

        private void SurprisingElementRemoving(object sender, ElementEventArgs args)
        {
            Assert.Fail("ElementRemoving event caught.");
            Output.WriteLine("[ElementRemoving] Removing {0} from {1}...", args.Element.GetFullName(), args.ParentElement.GetFullName());
            Assert.NotNull(args.Element.Parent);
            Assert.NotNull(args.ParentElement);
            Assert.True(args.ParentElement == args.Element.Parent, string.Format("Element to be removed {0} has different parent from expected {1}.", args.Element.GetFullName(), args.ParentElement.GetFullName()));

            Assert.True(sender is OpenXmlElementContext, string.Format("Sender is {0}, NOT OpenXmlElementContext!", sender.GetType().Name));
            Assert.Same(sender, args.ParentElement.OpenXmlElementContext);
            Assert.Same(sender, args.Element.OpenXmlElementContext);
        }

        private void ExpectedElementRemoved(object sender, ElementEventArgs args)
        {
            Output.WriteLine("ElementRemoved event caught.");
            Output.WriteLine("[ElementRemoved] Removed {0} from {1}...", args.Element.GetFullName(), args.ParentElement.GetFullName());
            Assert.Null(args.Element.Parent);
            Assert.NotNull(args.ParentElement);

            Assert.True(sender is OpenXmlElementContext, string.Format("Sender is {0}, NOT OpenXmlElementContext!", sender.GetType().Name));
            Assert.Same(sender, args.ParentElement.OpenXmlElementContext);
            Assert.NotSame(sender, args.Element.OpenXmlElementContext);
        }

        private void SurprisingElementRemoved(object sender, ElementEventArgs args)
        {
            Assert.Fail("ElementRemoved event caught.");
            Output.WriteLine("[ElementRemoved] Removed {0} from {1}...", args.Element.GetFullName(), args.ParentElement.GetFullName());
            Assert.Null(args.Element.Parent);
            Assert.NotNull(args.ParentElement);

            Assert.True(sender is OpenXmlElementContext, string.Format("Sender is {0}, NOT OpenXmlElementContext!", sender.GetType().Name));
            Assert.Same(sender, args.ParentElement.OpenXmlElementContext);
            Assert.NotSame(sender, args.Element.OpenXmlElementContext);
        }

        #endregion EventHandlers

        #region Annotation

        // AddAnnotation
        // Annotation(Type)
        // Annotation<T>()
        // Annotations(Type)
        // Annotations<T>()
        // RemoveAnnotations(Type)
        // RemoveAnnotations<T>()
        internal void AnnotationType(OpenXmlPart hostPart, GetTargetElement getHost)
        {
            Output.WriteLine("Loading root element from hosting part...");
            OpenXmlPartRootElement main = hostPart.RootElement();

            Output.WriteLine("Looking for target element in {0}...", hostPart.GetType().Name);
            var hostElement = getHost(main);

            Output.WriteLine("Removing all annotations for setup...");
            hostElement.RemoveAnnotations(typeof(object));
            var results = hostElement.Annotations(typeof(object));
            if (results is null || !results.Any())
            {
                Output.WriteLine("Removed all annotations.");
            }

            Output.WriteLine("Adding annotations...");
            var annotation = hostElement.FirstChild;
            hostElement.AddAnnotation(annotation);

            Output.WriteLine("Retrieving annotations...");
            var result = hostElement.Annotation(annotation.GetType());
            if (annotation == result)
            {
                Output.WriteLine("Annotation retrieved is exactly same one as added.");
            }
            else
            {
                Assert.Fail("Annotation retrieved is different from the one added.");
            }

            Output.WriteLine("Retrieving annotations...");
            results = hostElement.Annotations(annotation.GetType());
            Assert.Equal(1, results.Count());
            if (results.First() == result)
            {
                Output.WriteLine("Annotation retrieved is exactly same one as added.");
            }
            else
            {
                Assert.Fail("Annotation retrieved is different from the one added.");
            }

            Output.WriteLine("Removing annotations for cleanup...");
            hostElement.RemoveAnnotations(annotation.GetType());
            results = hostElement.Annotations(annotation.GetType());
            if (results is null || !results.Any())
            {
                Output.WriteLine("Removed all annotations.");
            }
        }

        internal void AnnotationT(OpenXmlPart hostPart, GetTargetElement getHost)
        {
            Output.WriteLine("Loading root element from hosting part...");
            OpenXmlPartRootElement main = hostPart.RootElement();

            Output.WriteLine("Looking for target element in {0}...", hostPart.GetType().Name);
            var hostElement = getHost(main);

            Output.WriteLine("Removing all annotations for setup...");
            hostElement.RemoveAnnotations<object>();
            var results = hostElement.Annotations<object>();
            if (results is null || !results.Any())
            {
                Output.WriteLine("Removed all annotations.");
            }

            Output.WriteLine("Adding annotations...");
            var annotation = hostElement.FirstChild;
            hostElement.AddAnnotation(annotation);

            Output.WriteLine("Retrieving annotations...");
            var result = hostElement.Annotation<OpenXmlElement>();
            if (annotation == result)
            {
                Output.WriteLine("Annotation retrieved is exactly same one as added.");
            }
            else
            {
                Assert.Fail("Annotation retrieved is different from the one added.");
            }

            Output.WriteLine("Retrieving annotations...");
            var oResults = hostElement.Annotations<OpenXmlElement>();
            Assert.Equal(1, oResults.Count());
            if (oResults.First() == result)
            {
                Output.WriteLine("Annotation retrieved is exactly same one as added.");
            }
            else
            {
                Assert.Fail("Annotation retrieved is different from the one added.");
            }

            Output.WriteLine("Removing annotations for cleanup...");
            hostElement.RemoveAnnotations<OpenXmlElement>();
            results = hostElement.Annotations(annotation.GetType());
            if (results is null || !results.Any())
            {
                Output.WriteLine("Removed all annotations.");
            }
        }

        internal void AnnotationArray(OpenXmlPart hostPart, GetTargetElement getHost)
        {
            Output.WriteLine("Loading root element from hosting part...");
            OpenXmlPartRootElement main = hostPart.RootElement();

            Output.WriteLine("Looking for target element in {0}...", hostPart.GetType().Name);
            var hostElement = getHost(main);

            Output.WriteLine("Removing all annotations for setup...");
            hostElement.RemoveAnnotations(typeof(object));
            var results = hostElement.Annotations(typeof(object));
            if (results is null || !results.Any())
            {
                Output.WriteLine("Removed all annotations.");
            }

            Output.WriteLine("Adding first child as annotation...");
            var annotation = hostElement.FirstChild;
            hostElement.AddAnnotation(annotation);

            Output.WriteLine("Adding annotations...");
            var annotations = hostElement.Elements().ToArray();
            hostElement.AddAnnotation(annotations);

            Output.WriteLine("Adding last child as annotation...");
            annotation = hostElement.LastChild;
            hostElement.AddAnnotation(annotation);

            Output.WriteLine("Retrieving annotation...");
            var result = hostElement.Annotation(typeof(OpenXmlElement));
            if (result == hostElement.FirstChild)
            {
                Output.WriteLine("Annotation retrieved is exactly same one as added.");
            }
            else
            {
                Assert.Fail("Annotation retrieved is different from the one added.");
            }

            Output.WriteLine("Retrieving annotation of array...");
            var resultArray = hostElement.Annotation(typeof(OpenXmlElement[])) as OpenXmlElement[];
            if (resultArray.SequenceEqual(hostElement.Elements()))
            {
                Output.WriteLine("Annotation of array retrieved is exactly same one as added.");
            }
            else
            {
                Assert.Fail("Annotation of array retrieved is different from the one added.");
            }

            int index = 0;
            var expected = new OpenXmlElement[2];
            expected[index++] = hostElement.FirstChild;
            expected[index++] = hostElement.LastChild;

            Output.WriteLine("Retrieving annotations of OpenXmlElement...");
            results = hostElement.Annotations(typeof(OpenXmlElement));
            Assert.Equal(expected.Length, results.Count());
            if (results.SequenceEqual(expected))
            {
                Output.WriteLine("Annotations retrieved are exactly same ones as added.");
            }
            else
            {
                Assert.Fail("Annotations retrieved are different from the ones added.");
            }

            Output.WriteLine("Removing annotations of OpenXmlElement...");
            hostElement.RemoveAnnotations(typeof(OpenXmlElement));
            results = hostElement.Annotations(typeof(OpenXmlElement));
            if (results is null || !results.Any())
            {
                Output.WriteLine("Removed all annotations.");
            }

            Output.WriteLine("Removing annotations for cleanup...");
            hostElement.RemoveAnnotations(typeof(object));
            results = hostElement.Annotations(typeof(object));
            if (results is null || !results.Any())
            {
                Output.WriteLine("Removed all annotations.");
            }
        }

        internal void AnnotationCollection(OpenXmlPart hostPart, GetTargetElement getHost)
        {
            Output.WriteLine("Loading root element from hosting part...");
            OpenXmlPartRootElement main = hostPart.RootElement();

            Output.WriteLine("Looking for target element in {0}...", hostPart.GetType().Name);
            var hostElement = getHost(main);

            Output.WriteLine("Removing all annotations for setup...");
            hostElement.RemoveAnnotations(typeof(object));
            var results = hostElement.Annotations(typeof(object));
            if (results is null || !results.Any())
            {
                Output.WriteLine("Removed all annotations.");
            }

            Output.WriteLine("Adding collection annotations...");
            var annotations = hostElement.Elements();
            hostElement.AddAnnotation(annotations);

            Output.WriteLine("Retrieving annotations...");
            var result = hostElement.Annotation(annotations.GetType());
            if (annotations == result)
            {
                Output.WriteLine("Annotation retrieved is exactly same one as added.");
            }
            else
            {
                Assert.Fail("Annotation retrieved is different from the one added.");
            }

            Output.WriteLine("Retrieving annotations...");
            results = hostElement.Annotations(annotations.GetType());
            Assert.Equal(1, results.Count());
            if (results.First() == result)
            {
                Output.WriteLine("Annotation retrieved is exactly same one as added.");
            }
            else
            {
                Assert.Fail("Annotation retrieved is different from the one added.");
            }

            Output.WriteLine("Removing annotations for cleanup...");
            hostElement.RemoveAnnotations(annotations.GetType());
            results = hostElement.Annotations(annotations.GetType());
            if (results is null || !results.Any())
            {
                Output.WriteLine("Removed all annotations.");
            }
        }

        #endregion Annotation

        #region VerifyResult ...

        /// <summary>
        /// verify if the specified element has no child element.
        /// </summary>
        /// <param name="targetElement">the element to be checked</param>
        internal void VerifyNoChildren(XElement targetElement)
        {
            if (targetElement is null)
            {
                throw new ArgumentNullException(nameof(targetElement));
            }

            Output.WriteLine("check if the current element has no children");
            Assert.False(targetElement.HasElements, "Not all children are removed");
        }

        /// <summary>
        /// verify if <paramref name="originalElement"/> equals to <paramref name="resultElement"/>'s child at <paramref name="targetPosition"/>.
        /// </summary>
        /// <param name="resultElement">the element after modifying</param>
        /// <param name="originalElement">the element before modifying</param>
        /// <param name="targetPosition">If null, compare these two elements. Otherwise, compare the originalElement with resultElement's targetPosition-th child</param>
        internal void VerifyEqual(XElement resultElement, XElement originalElement, int? childPosition)
        {
            if (resultElement is null || originalElement is null)
            {
                throw new ArgumentNullException("one of the arguments passed in is NULL");
            }

            if (childPosition.HasValue && (childPosition.Value < 0 || childPosition.Value >= resultElement.Elements().Count()))
            {
                throw new IndexOutOfRangeException("the child position is out of range");
            }

            XElement targetElement = null;

            if (childPosition is not null)
            {
                Output.WriteLine("retrieve the child element of resultElement at position {0} to compare with originalElement", childPosition);
                targetElement = resultElement.Elements().ElementAt(childPosition.Value);
            }
            else
            {
                Output.WriteLine("Compare the resultElement with the originalElement");
                targetElement = resultElement;
            }

            Assert.True(targetElement.Compare(originalElement), "Two elements are not same");
        }

        internal void VerifyEqual(XElement xelement, OpenXmlElement oelement, OpenXmlPart part)
        {
            VerifyEqual(xelement, ConvertToXElement(part, oelement), null);
        }

        internal void VerifyEqual<T>(IEnumerable<XElement> xElement, IEnumerable<T> oElement, OpenXmlPart part)
            where T : OpenXmlElement
        {
            if (xElement is null || oElement is null)
            {
                throw new ArgumentNullException("one of the arguments passed in is NULL");
            }

            bool pass = true;

            if (xElement.Count() != oElement.Count())
            {
                Assert.Fail("Two List of elements have different count");
                pass = false;
            }
            else if (!xElement.Any())
            {
                Output.WriteLine("Warning: 0 element is encountered");
            }

            if (pass)
            {
                for (int i = 0; i < oElement.Count(); i++)
                {
                    if (!xElement.ElementAt(i).Compare(ConvertToXElement(part, oElement.ElementAt(i))))
                    {
                        Assert.Fail(string.Format("the Elements at position {0} are different", i));
                        pass = false;
                        break;
                    }
                }
            }

            if (pass)
            {
                Output.WriteLine("the two list of elements are the same");
            }
        }

        /// <summary>
        /// verify if an element is removed successfully
        /// </summary>
        /// <param name="resultElement">the element after child is removed</param>
        /// <param name="originalElement">the element before child is removed</param>
        /// <param name="targetPosition">the original position of the removed child</param>
        internal void VerifyRemove(XElement resultElement, XElement originalElement, int childPosition)
        {
            if (resultElement is null || originalElement is null)
            {
                throw new ArgumentNullException("resultElement|originalElement");
            }

            if (childPosition < 0 || childPosition >= originalElement.Elements().Count())
            {
                throw new IndexOutOfRangeException("the child position is out of range");
            }

            Output.WriteLine("check if the targetElement's children is decreased by 1");
            Assert.True(originalElement.Elements().Count() == resultElement.Elements().Count() + 1, "the target's children is not decreased by 1");

            Output.WriteLine("check if all other child elements are matched, except the removed one");

            for (int i = 0; i < childPosition; i++)
            {
                Output.WriteLine("check child elements at position {0}", i);
                Assert.True(resultElement.Elements().ElementAt(i).Compare(originalElement.Elements().ElementAt(i)), string.Format("the child elements at position {0} are not same", i));
            }

            if (childPosition < resultElement.Elements().Count())
            {
                for (int i = childPosition; i < resultElement.Elements().Count(); i++)
                {
                    Output.WriteLine("check child elements at position {0}", i);
                    Assert.True(resultElement.Elements().ElementAt(i).Compare(originalElement.Elements().ElementAt(i + 1)), string.Format("the child elements at position {0} are not same", i));
                }
            }
        }

        /// <summary>
        /// verify if an source of element are removed successfully
        /// </summary>
        /// <param name="resultElement">the element after child is removed</param>
        /// <param name="originalElement">the element before child is removed</param>
        /// <param name="targetPosition">original position of removed children</param>
        internal void VerifyRemove(XElement resultElement, XElement originalElement, IEnumerable<int> childrenPosition)
        {
            if (resultElement is null || originalElement is null)
            {
                throw new ArgumentNullException("resultElement|originalElement");
            }

            if (childrenPosition is null)
            {
                throw new ArgumentNullException(nameof(childrenPosition));
            }

            if (childrenPosition.Min() < 0 || childrenPosition.Max() >= originalElement.Elements().Count())
            {
                throw new IndexOutOfRangeException("Child position is out of range");
            }

            Output.WriteLine("check if the targetElement's children is decreased as expected");
            Assert.True(originalElement.Elements().Count() == resultElement.Elements().Count() + childrenPosition.Count(), "Target's children is not decreased as expected.");

            Output.WriteLine("check if all other child elements are matched, except the removed one");
            for (int i = 0; i < originalElement.Elements().Count(); i++)
            {
                if (childrenPosition.Contains(i))
                {
                    continue;
                }

                int expectPos = i - childrenPosition.Count(j => j < i);
                Output.WriteLine("Verifying child element at position ({0}:{1})...", i, expectPos);
                Assert.True(resultElement.Elements().ElementAt(expectPos).Compare(originalElement.Elements().ElementAt(i)), string.Format("Child element at position ({0}:{1}) is NOT same.", i, expectPos));
            }
        }
        #endregion

    }
}
