// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Reflection;

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Presentation;
using Xunit;

namespace DocumentFormat.OpenXml.Tests
{
    using DocumentFormat.OpenXml.Tests.TaskLibraries;

    /// <summary>
    /// The OpenXmlDom test framework. It contains help methods for testing OpenXmlDom Classes
    /// </summary>
    public class OpenXmlDomTestBase : OpenXmlTestBase
    {
        public OpenXmlDomTestBase()
        {
            // Specify source path which includes test input files
            this.SourcePath = @"v2FxTestFiles";
        }

        #region Delegation ...

        internal delegate FileInfo GetTargetFile(string folder, string filePattern);

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
        private static String GetElementPath(OpenXmlElement element)
        {
            // Log.Comment("get the current element position path");
            if (element == null)
            {
                throw new ArgumentNullException("element");
            }

            StringBuilder path = new StringBuilder();

            GetSameLevelPath(element, ref path);
            OpenXmlElement walker = element.Parent;
            while (walker != null)
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
            if (element == null || path == null)
                throw new ArgumentNullException("element|path");

            int position = 0;

            OpenXmlElement walker = element.PreviousSibling();

            while (walker != null)
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
        /// <returns>the Xelement retrieved from the path</returns>
        private static XElement GetXmlElement(String path, OpenXmlPart part)
        {
            if (part == null)
                throw new ArgumentNullException("part");
            if (String.IsNullOrEmpty(path))
                throw new ArgumentNullException("path");

            XElement element = null;
            using (var stream = part.GetStream())
            using (var reader = XmlReader.Create(stream))
                element = XElement.Load(reader);

            if (element == null)
                throw new Exception("Failed to load element from specified part.");

            List<String> elementTypeList = new List<string>();
            List<String> elementPositionList = new List<string>();
            char[] separator = { '/' };

            foreach (String level in path.Split(separator, StringSplitOptions.RemoveEmptyEntries))
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
        /// <returns>the corresponding Xelement</returns>
        internal static XElement ConvertToXElement(OpenXmlPart part, OpenXmlElement element)
        {
            if (part == null || element == null)
                throw new ArgumentNullException("part | element");

            String path = GetElementPath(element);

            return GetXmlElement(path, part);
        }

        /// <summary>
        /// Convert an OpenXmlElement to an XElement using its OuterXml
        /// </summary>
        /// <param name="element">the element need to be converted</param>
        /// <returns>the converted XElement</returns>
        internal XElement ToXElement(OpenXmlElement element)
        {
            if (element == null)
                throw new ArgumentNullException("element");
            return XElement.Load(new StringReader(element.OuterXml));
        }

        #endregion

        #region Find Part
        /// <summary> get any reflectable part in given package. </summary>
        internal GetTargetPart getAnyOpenXmlPart =
            p => p.DescendantParts()
                .Where(pa => pa.IsReflectable() && pa.ContentType != "application/xml")
                .PickSecond();

        /// <summary> get main part of given package. </summary>
        internal GetTargetPart getMainPart = p => p.MainPart();

        /// <summary> get non-main part of given Package. </summary>
        internal GetTargetPart getNonMainPart =
            p => p.NonMainParts()
                .Where(pa => pa.IsReflectable() && pa.ContentType != "application/xml")
                .PickSecond();

        /// <summary> get the first slide part of given package. </summary>
        internal GetTargetPart getSlidePart =
            p => p.MainPart().GetPartsOfType<SlidePart>().FirstOrDefault();

        /// <summary> get the first worksheet part of given package. </summary>
        internal GetTargetPart getFirstSheetPart =
            p => p.MainPart().GetPartsOfType<WorksheetPart>().FirstOrDefault();

        /// <summary> get the last worksheet part of given package. </summary>
        internal GetTargetPart getLastSheetPart =
            p => p.MainPart().GetPartsOfType<WorksheetPart>().LastOrDefault();

        #endregion Find Part

        #region Find Element

        /// <summary>Get body element of the document.</summary>
        internal GetTargetElement getBody =
             e => e.Descendants().OfType<Body>().FirstOrDefault();

        /// <summary> Get part root of current element.</summary>
        internal GetTargetElement getPartRoot =
            e => e.Parent == null ? (e is OpenXmlPartRootElement ? e : null) : e.Ancestors<OpenXmlPartRootElement>().FirstOrDefault();

        /// <summary> Get parent of current element.</summary>
        internal GetTargetElement getAnyAncestor =
            e => e.Ancestors().PickSecond();

        /// <summary> Get root element of current one.</summary>
        internal GetTargetElement getRootElement =
            e => e.Parent == null ? e : e.Ancestors().LastOrDefault();

        /// <summary> Get parent of current element.</summary>
        internal GetTargetElement getParent =
            e => e.Parent;

        /// <summary> Get current element itself.</summary>
        internal GetTargetElement getSelf =
            e => e;

        /// <summary> Get null as return vlaue. Useful for invalid cases.</summary>
        internal GetTargetElement getNull =
            e => null;

        /// <summary> Get descendant of OpenXmlUnknownElement</summary>
        internal GetTargetElement getUnknownElement =
            e => e.Descendants<OpenXmlUnknownElement>().FirstOrDefault();

        /// <summary> Get descendant of OpenXmlMiscNode</summary>
        internal GetTargetElement getMiscNode =
            e => e.Descendants<OpenXmlMiscNode>().FirstOrDefault();

        /// <summary>Get element with parent and sibling. </summary>
        internal GetTargetElement getElementWithParentAndSibling =
            e => e.Descendants().Where(d => d.Parent != null && d.Parent.ChildElements.Count() > 1).First();

        /// <summary>Get element without children</summary>
        internal GetTargetElement getElementWithoutChildren =
            e => e.Descendants<OpenXmlCompositeElement>().Where(d => d.ChildElements.Count == 0).FirstOrDefault();

        /// <summary>Get element with ONE child</summary>
        internal GetTargetElement getElementWithChild =
            e => e.Descendants().Where(d => d.ChildElements.Count == 1).FirstOrDefault();

        /// <summary>Get element with children</summary>
        internal GetTargetElement getElementWithChildren =
            e => e.Descendants().Where(d => d.ChildElements.Count > 1).FirstOrDefault();

        /// <summary>Get element with children</summary>
        internal GetTargetElement getElementWithAttributesOnly =
            e => e.Descendants<OpenXmlCompositeElement>().Where(d => d.GetAttributes().Count > 0 && d.ChildElements.Count == 0).FirstOrDefault();

        /// <summary>Get element with children</summary>
        internal GetTargetElement getElementWithAttributesAndChildren =
            e => e.Descendants().Where(d => d.GetAttributes().Count > 0 && d.ChildElements.Count > 0).FirstOrDefault();

        /// <summary>Get any leaf element in descendants.</summary>
        internal GetTargetElement getAnyElement =
            e => e.Descendants<OpenXmlElement>().PickSecond();

        /// <summary>Get any leaf element in descendants.</summary>
        internal GetTargetElement getAnyLeaf =
            e => e.Descendants<OpenXmlLeafElement>().PickSecond();

        /// <summary>Get any composite element in descendant.</summary>
        internal GetTargetElement getAnyComposite =
            e => e.Descendants<OpenXmlCompositeElement>().PickSecond();

        /// <summary>Get paragraph with text run only.</summary>
        internal GetTargetElement getTextParagraph =
            e => e.Descendants<DocumentFormat.OpenXml.Wordprocessing.Paragraph>()
                .Where(p => p.ChildElements.Count(c => !(c is DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties)) == 1)
                .Where(p => p.Descendants<DocumentFormat.OpenXml.Wordprocessing.Text>().Count() == 1)
                .PickSecond();

        /// <summary>Get descendant element of pass-in OpenXmlElement that has both leaf and composite child elements</summary>
        internal GetTargetElement getAnyWithLeafAndCompositeChild =
            e =>
            {
                return e.Descendants()
                    .Where(c => c.ChildElements.Any(d => d is OpenXmlLeafElement)
                        && c.ChildElements.Any(d => d is OpenXmlCompositeElement))
                    .PickSecond();
            };

        /// <summary>Get descendant element of pass-in OpenXmlElement that has composite child elements</summary>
        internal GetTargetElement getAnyWithCompositeChild =
            e =>
            {
                return e.Descendants()
                    .Where(c => c.ChildElements.Any(d => d is OpenXmlCompositeElement))
                    .PickSecond();
            };

        /// <summary>Get descendant element of pass-in OpenXmlElement that has leaf child elements</summary>
        internal GetTargetElement getAnyWithLeafChild =
            e =>
            {
                return e.Descendants()
                    .Where(c => c.ChildElements.Any(d => d is OpenXmlLeafElement))
                    .PickSecond();
            };

        /// <summary>Get grand child of pass-in OpenXmlElement</summary>
        internal GetTargetElement getGrandChild =
            e => e.ChildElements
                .Where(c => c.ChildElements.Count > 0)
                .SelectMany(c => c.ChildElements)
                .PickSecond();

        /// <summary>Get first child of pass-in OpenXmlElement</summary>
        internal GetTargetElement getFirstChild =
            e => e.ChildElements.FirstOrDefault();

        /// <summary>Get last child of pass-in OpenXmlElement</summary>
        internal GetTargetElement getLastChild =
            e => e.ChildElements.LastOrDefault();

        /// <summary>Get first child of pass-in OpenXmlElement</summary>
        internal GetTargetElement getAnyChild =
            e => e.ChildElements.PickSecond();

        /// <summary>Get any leaf element in child element.</summary>
        internal GetTargetElement getAnyLeafChild =
            e => e.ChildElements.OfType<OpenXmlLeafElement>().PickSecond();

        /// <summary>Get any composite element in child element.</summary>
        internal GetTargetElement getAnyCompositeChild =
            e => e.ChildElements.OfType<OpenXmlCompositeElement>().PickSecond();

        /// <summary>Get first child element which contains OpenXmlLeafTextElement only.</summary>
        internal GetTargetElement getChildWithLeafTextOnly =
            e => e.ChildElements
                .Where(c => c.ChildElements.All(cc => cc is OpenXmlLeafTextElement))
                .First();

        /// <summary>Get first sibling of pass-in OpenXmlElement.</summary>
        internal GetTargetElement getFirstSibling =
            e => null == e.Parent ? null : e == e.Parent.First() ? e.NextSibling() : e.Parent.First();

        /// <summary>Get last sibling of pass-in OpenXmlElement.</summary>
        internal GetTargetElement getLastSibling =
            e => null == e.Parent ? null : e == e.Parent.Last() ? e.PreviousSibling() : e.Parent.Last();

        /// <summary>Get any sibling of pass-in OpenXmlElement.</summary>
        internal GetTargetElement getAnySibling =
            e => null == e.Parent ? null : e.Parent.ChildElements.Where(s => s != e).PickSecond();

        /// <summary>Get any TextBody of given slide.</summary>
        internal GetTargetElement getSlideTextBody =
            e => e.Descendants<DocumentFormat.OpenXml.Presentation.TextBody>().PickSecond();

        /// <summary>Get any Paragraph of any TextBody.</summary>
        internal GetTargetElement getSlideTextParagraph =
            e => e.Descendants<DocumentFormat.OpenXml.Presentation.TextBody>().PickSecond()
            .Descendants<DocumentFormat.OpenXml.Drawing.Paragraph>().PickSecond();

        /// <summary>Get any SheetData of given worksheet.</summary>
        internal GetTargetElement getSheetData =
            e => e.Descendants<SheetData>().PickSecond();

        /// <summary>Get any SheetData Row of first worksheet.</summary>
        internal GetTargetElement getSheetDataRow =
            e => e.Descendants<SheetData>().FirstOrDefault()
                .Descendants<Row>().PickSecond();

        #endregion Find Element

        #region Contructing
        internal enum ConstructorOptions { Default, OuterXml, IEnumberable, IEnumberableGeneric, Params, Part };

        #endregion Constructing

        #region Append Collection

        internal enum AppendCollectionType { IEnumerable, Array };

        internal void AppendCollectionOnFile(FileInfo testfile, GetTargetPart getHostPart, GetTargetElement getHostElement,
            FileInfo sourceFile, GetTargetPart getSrcPart, GetTargetElement getImportee, AppendCollectionType operationType)
        {
            Log.BeginGroup(testfile.Name);

            using (OpenXmlPackage target = testfile.OpenPackage(true))
            using (OpenXmlPackage source = sourceFile.OpenPackage(false))
            {
                Log.Comment("Loading target Part...");
                OpenXmlPart hostPart = getHostPart(target);
                Log.Comment("Loading source Part...");
                OpenXmlPart srcHostPart = getSrcPart(source);

                if (!hostPart.IsReflectable() || !srcHostPart.IsReflectable())
                    Log.Warning("Either hostPart or srcHostPart is NOT reflectable.");
                AppendCollection(hostPart, getHostElement, srcHostPart, getImportee, operationType);
            }
        }

        private void AppendCollection(OpenXmlPart hostPart, GetTargetElement getHost,
            OpenXmlPart srcPart, GetTargetElement getImportee, AppendCollectionType operationType)
        {
            Log.Comment("Loading root element from hosting part...");
            OpenXmlPartRootElement main = hostPart.RootElement();
            Log.Comment("Loading root element from source part...");
            OpenXmlPartRootElement srcMain = srcPart.RootElement();

            Log.Comment("Looking for target element in {0}...", hostPart.GetType().Name);
            var hostElement = getHost(main);
            if (null != hostElement)
            {
                Log.Comment("Host element found: {0}", hostElement.Path());

                Log.Comment("Looking for importing element in {0}...", srcPart.GetType().Name);
                var importHost = getImportee(srcMain);
                if (null != importHost)
                {
                    Log.Comment("Importing element found: {0}", importHost.Path());

                    XElement XBefore = ConvertToXElement(hostPart, hostElement);

                    Log.Comment("Importing {0} elements...", importHost.ChildElements.Count);
                    var originalElementCount = hostElement.ChildElements.Count;
                    var importElementsCount = importHost.ChildElements.Count;
                    var childPosition = originalElementCount;
                    String importElementOuterXml = null;

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

                    Log.Comment("Saving changes...");
                    main.Save();

                    XElement XAfter = ConvertToXElement(hostPart, hostElement);

                    Log.Comment("Checking if children of current element increased by {0}...", importElementsCount);
                    Log.VerifyTrue(XBefore.Elements().Count() == XAfter.Elements().Count() - importElementsCount, "Children element NOT increased as expected!");

                    for (int i = 0; i < importElementsCount; i++)
                    {
                        importElementOuterXml = importHost.ChildElements[i].OuterXml;
                        VerifyEqual(XAfter, XElement.Load(new StringReader(importElementOuterXml)), childPosition++);
                    }
                }
                else
                {
                    Log.Warning("Importing element NOT found.");
                }
            }
            else
            {
                Log.Warning("Host element NOT found.");
            }
        }

        #endregion Append Collection

        #region Pend Operations

        internal enum PendType { Append, Prepend };

        internal void PendTestOnFile(FileInfo testFile, GetTargetPart getHostPart, GetTargetElement getHostElement,
            FileInfo sourceFile, GetTargetPart getSourcePart, GetTargetElement getSourceHost, PendType pendType)
        {
            Log.BeginGroup(testFile.Name);

            using (OpenXmlPackage target = testFile.OpenPackage(true))
            using (OpenXmlPackage source = sourceFile.OpenPackage(false))
            {
                Log.Comment("Loading target Part...");
                OpenXmlPart hostPart = getHostPart(target);
                Log.Comment("Loading source Part...");
                OpenXmlPart srcHostPart = getSourcePart(source);

                if (!hostPart.IsReflectable() || !srcHostPart.IsReflectable())
                    Log.Warning("Either hostPart or srcHostPart is NOT reflectable.");
                PendTestBody(hostPart, getHostElement, srcHostPart, getSourceHost, pendType);
            }
        }

        /// <summary>
        /// Ap/Pre- pend OpenXmlElement found through getImportee on srcPart to OpenXmlElement found through getTarget on hostPart.
        /// </summary>
        /// <param name="hostPart">Hosting Part</param>
        /// <param name="getTarget">Delegate method to find specifc OpenXmlElement in host part</param>
        /// <param name="srcPart">Source Part to import content from</param>
        /// <param name="getImportee">Delegate method to find specific OpenXmlElment in source part</param>
        /// <param name="operationType">Append or Prepend</param>
        private void PendTestBody(OpenXmlPart hostPart, GetTargetElement getHost,
            OpenXmlPart srcPart, GetTargetElement getImportee, PendType operationType)
        {
            Log.Comment("Loading root element from hosting part...");
            OpenXmlPartRootElement main = hostPart.RootElement();
            Log.Comment("Loading root element from source part...");
            OpenXmlPartRootElement srcMain = srcPart.RootElement();

            Log.Comment("Looking for target element in {0}...", hostPart.GetType().Name);
            var hostElement = getHost(main);
            if (null != hostElement)
            {
                Log.Comment("Host element found: {0}", hostElement.Path());

                Log.Comment("Looking for importing element in {0}...", srcPart.GetType().Name);
                var importElement = getImportee(srcMain);
                if (null != importElement)
                {
                    Log.Comment("Importing element found: {0}", importElement.Path());

                    XElement XBefore = ConvertToXElement(hostPart, hostElement);

                    int? childPosition = null;
                    OpenXmlElement result = null;
                    String importElementOuterXml = importElement.OuterXml;

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

                    Log.Comment("Saving changes...");
                    main.Save();

                    XElement XAfter = ConvertToXElement(hostPart, hostElement);

                    Log.Comment("Checking if children of current element increased by ONE...");
                    Log.VerifyTrue(XBefore.Elements().Count() == XAfter.Elements().Count() - 1, "Children element NOT increased by ONE!");

                    VerifyEqual(XAfter, XElement.Load(new StringReader(importElementOuterXml)), childPosition);
                }
                else
                {
                    Log.Warning("Importing element NOT found.");
                }
            }
            else
            {
                Log.Warning("Host element NOT found.");
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
            if (pendOp == null)
                throw new ArgumentNullException("pender");

            Log.Comment("Pending child with {0}...", pendOp.Method.Name);
            OpenXmlElement result = pendOp(pendee);

            Log.Comment("Checking if returned element is reference equal to pass-in element...");
            Log.VerifyTrue(object.ReferenceEquals(result, pendee), "Returned element is NOT reference equal to pass-in one!");

            return result;
        }

        #endregion Pend Operations

        #region Insert Before/After

        internal enum InsertType { Before, After };

        internal void InsertTestOnFile(FileInfo testfile, GetTargetPart getHostPart, GetTargetElement getHostElement,
            FileInfo sourceFile, GetTargetPart getSourcePart, GetTargetElement getSourceHost, GetTargetElement getRef, InsertType insertType)
        {
            Log.BeginGroup(testfile.Name);

            using (OpenXmlPackage target = testfile.OpenPackage(true))
            using (OpenXmlPackage source = sourceFile.OpenPackage(false))
            {
                Log.Comment("Loading target Part...");
                OpenXmlPart hostPart = getHostPart(target);
                Log.Comment("Loading source Part...");
                OpenXmlPart srcHostPart = getSourcePart(source);

                if (!hostPart.IsReflectable() || !srcHostPart.IsReflectable())
                    Log.Warning("Either hostPart or srcHostPart is NOT reflectable.");

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
            Log.Comment("Loading root element from hosting part...");
            OpenXmlPartRootElement main = hostPart.RootElement();
            Log.Comment("Loading root element from source part...");
            OpenXmlPartRootElement srcMain = srcPart.RootElement();

            Log.Comment("Looking for target element in {0}...", hostPart.GetType().Name);
            var hostElement = getHost(main);
            if (null != hostElement)
            {
                Log.Comment("Host element found: {0}", hostElement.Path());

                Log.Comment("Looking for reference element in {0}...", hostElement.GetType().Name);
                var refElement = getRef(hostElement);
                if (null != refElement)
                {
                    Log.Comment("Reference element found: {0}", refElement.Path());

                    Log.Comment("Looking for importing element in {0}...", srcPart.GetType().Name);
                    var importElement = getImportee(srcMain);
                    if (null != importElement)
                    {
                        Log.Comment("Importing element found: {0}", importElement.Path());

                        XElement Xbefore = ConvertToXElement(hostPart, hostElement);

                        OpenXmlElement result = null;
                        int? expectPos = null;
                        String InsertElement = importElement.OuterXml;

                        switch (type)
                        {
                            case InsertType.Before:
                                expectPos =
                                    refElement == null ? hostElement.ChildElements.Count : refElement.Index();
                                result = InsertOperation(hostElement.InsertBefore, importElement.Clone() as OpenXmlElement, refElement);
                                break;
                            case InsertType.After:
                                expectPos =
                                    refElement == null ? 0 : refElement.Index() + 1;
                                result = InsertOperation(hostElement.InsertAfter, importElement.Clone() as OpenXmlElement, refElement);
                                break;
                            default:
                                throw new InvalidOperationException("Operation specified is invalid!!");
                        }

                        Log.Comment("Saving changes...");
                        main.Save();

                        XElement Xafter = ConvertToXElement(hostPart, hostElement);

                        Log.Comment("Check if the child of  current element increased by ONE...");
                        Log.VerifyTrue(Xbefore.Elements().Count() == Xafter.Elements().Count() - 1, "Child element NOT increased by ONE!");

                        Log.Comment("Check if specified child inserted as expected...");
                        VerifyEqual(Xafter, XElement.Load(new StringReader(InsertElement)), expectPos);
                    }
                    else
                    {
                        Log.Warning("Importing element NOT found.");
                    }
                }
                else
                {
                    Log.Warning("Reference element NOT found.");
                }
            }
            else
            {
                Log.Warning("Host element NOT found.");
            }
        }

        ///<summary>
        /// Perform InsertBefore/After operation.
        /// </summary>
        /// <param name="insertOp">Delegate to InsertBefore/After method on OpenXmlElement</param>
        /// <param name="insertee">OpenXmlElement to be inserted</param>
        /// <param name="refChild">Reference child of host element</param>
        /// <returns>Return value of <paramref name="insertOp"/></returns>
        internal OpenXmlElement InsertOperation(InsertChild<OpenXmlElement> insertOp, OpenXmlElement insertee, OpenXmlElement refChild)
        {
            if (insertOp == null || insertee == null)
                throw new ArgumentNullException("insertOp|insertee");

            Log.Comment("New child element is {0} the reference child", insertOp.Method.Name);
            OpenXmlElement result = insertOp(insertee, refChild);

            Log.Comment("Check if the element inserted is the same as the element inserted");
            Log.VerifyTrue(object.ReferenceEquals(result, insertee), "two elements are not the same");

            return result;
        }

        #endregion Insert Before/After

        #region InsertAt

        internal enum InsertAtPosition { AsFirst, NextToFirst, AnyValid, NextToLast, AsLast };

        internal void InsertAtOnFile(FileInfo testfile, GetTargetPart getHostPart, GetTargetElement getHost,
            FileInfo sourceFile, GetTargetPart getSrcPart, GetTargetElement getImportee, InsertAtPosition posType)
        {
            Log.BeginGroup(testfile.Name);

            using (OpenXmlPackage target = testfile.OpenPackage(true))
            using (OpenXmlPackage source = sourceFile.OpenPackage(false))
            {
                Log.Comment("Loading target Part...");
                OpenXmlPart hostPart = getHostPart(target);
                Log.Comment("Loading source Part...");
                OpenXmlPart srcHostPart = getSrcPart(source);

                if (!hostPart.IsReflectable() || !srcHostPart.IsReflectable())
                    Log.Warning("Either hostPart or srcHostPart is NOT reflectable.");

                InsertAt(hostPart, getHost, srcHostPart, getImportee, posType);
            }
        }

        private void InsertAt(OpenXmlPart hostPart, GetTargetElement getHost,
            OpenXmlPart srcPart, GetTargetElement getImportee, InsertAtPosition posType)
        {
            Log.Comment("Loading root element from hosting part...");
            OpenXmlPartRootElement main = hostPart.RootElement();
            Log.Comment("Loading root element from source part...");
            OpenXmlPartRootElement srcMain = srcPart.RootElement();

            Log.Comment("Looking for target element in {0}...", hostPart.GetType().Name);
            var hostElement = getHost(main);
            if (null != hostElement)
            {
                Log.Comment("Host element found: {0}", hostElement.Path());

                Log.Comment("Looking for importing element in {0}...", srcPart.GetType().Name);
                var importElement = getImportee(srcMain);
                if (null != importElement)
                {
                    Log.Comment("Importing element found: {0}", importElement.Path());

                    XElement Xbefore = ConvertToXElement(hostPart, hostElement);

                    int expectPos;
                    OpenXmlElement result = null;
                    String InsertElement = importElement.OuterXml;

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

                    Log.Comment("Saving changes...");
                    main.Save();

                    XElement Xafter = ConvertToXElement(hostPart, hostElement);

                    Log.Comment("Check if the child of  current element increased by ONE...");
                    Log.VerifyTrue(Xbefore.Elements().Count() == Xafter.Elements().Count() - 1, "Child element NOT increased by ONE!");

                    Log.Comment("Check if specified child inserted as expected...");
                    VerifyEqual(Xafter, XElement.Load(new StringReader(InsertElement)), expectPos);
                }
                else
                {
                    Log.Warning("Importing element NOT found.");
                }
            }
            else
            {
                Log.Warning("Host element NOT found.");
            }
        }

        #endregion InsertAt

        #region Insert Before/After Self

        internal enum InsertRel { BeforeSelf, AfterSelf };

        internal void InsertRelativeOnFile(FileInfo testfile, GetTargetPart getHostPart, GetTargetElement getHost,
            FileInfo sourceFile, GetTargetPart getSrcPart, GetTargetElement getImportee, InsertRel posType)
        {
            Log.BeginGroup(testfile.Name);

            using (OpenXmlPackage target = testfile.OpenPackage(true))
            using (OpenXmlPackage source = sourceFile.OpenPackage(false))
            {
                Log.Comment("Loading target Part...");
                OpenXmlPart hostPart = getHostPart(target);
                Log.Comment("Loading source Part...");
                OpenXmlPart srcHostPart = getSrcPart(source);

                if (!hostPart.IsReflectable() || !srcHostPart.IsReflectable())
                    Log.Warning("Either hostPart or srcHostPart is NOT reflectable.");

                InsertRelative(hostPart, getHost, srcHostPart, getImportee, posType);
            }
        }

        private void InsertRelative(OpenXmlPart hostPart, GetTargetElement getHost,
            OpenXmlPart srcPart, GetTargetElement getImportee, InsertRel posType)
        {
            Log.Comment("Loading root element from hosting part...");
            OpenXmlPartRootElement main = hostPart.RootElement();
            Log.Comment("Loading root element from source part...");
            OpenXmlPartRootElement srcMain = srcPart.RootElement();

            Log.Comment("Looking for target element in {0}...", hostPart.GetType().Name);
            var hostElement = getHost(main);
            if (null != hostElement)
            {
                Log.Comment("Host element found: {0}", hostElement.Path());

                Log.Comment("Looking for importing element in {0}...", srcPart.GetType().Name);
                var importElement = getImportee(srcMain);
                if (null != importElement)
                {
                    Log.Comment("Importing element found: {0}", importElement.Path());

                    XElement xBefore = ConvertToXElement(hostPart, hostElement.Parent);

                    int expectPos;
                    OpenXmlElement result = null;
                    String InsertElement = importElement.OuterXml;

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

                    Log.Comment("Saving changes...");
                    main.Save();

                    XElement xAfter = ConvertToXElement(hostPart, hostElement.Parent);

                    Log.Comment("Check if the child of  current element increased by ONE...");
                    Log.VerifyTrue(xBefore.Elements().Count() == xAfter.Elements().Count() - 1, "Child element NOT increased by ONE!");

                    Log.Comment("Check if specified element inserted as expected...");
                    VerifyEqual(xAfter, XElement.Load(new StringReader(InsertElement)), expectPos);
                }
                else
                {
                    Log.Warning("Importing element NOT found.");
                }
            }
            else
            {
                Log.Warning("Host element NOT found.");
            }
        }

        #endregion Insert Before/After Self

        #region RemoveAllChildren

        internal void RemoveAllChildrenOnFile(FileInfo testfile, GetTargetPart getHostPart, GetTargetElement getHost)
        {
            Log.BeginGroup(testfile.Name);

            using (OpenXmlPackage target = testfile.OpenPackage(true))
            {
                Log.Comment("Loading target part...");
                OpenXmlPart hostPart = getHostPart(target);
                RemoveAllChildren(hostPart, getHost);
            }
        }

        private void RemoveAllChildren(OpenXmlPart hostPart, GetTargetElement getHost)
        {
            Log.Comment("Loading root element in {0}...", hostPart.GetType().Name);
            OpenXmlPartRootElement main = hostPart.RootElement();

            Log.Comment("Looking for host element...");
            OpenXmlElement hostElement = getHost(main);
            if (null != hostElement)
            {
                Log.Comment("Host element found: {0}", hostElement.Path());

                if (hostElement.ChildElements.Count == 0)
                    Log.Warning("The host element has NO children!");
                Log.Comment("The host element have {0} children.", hostElement.ChildElements.Count);

                Log.Comment("Remove all children from host element...");
                hostElement.RemoveAllChildren();

                Log.Comment("Saving changes...");
                main.Save();

                Log.Comment("Verifying host element has no children any more...");
                XElement Xbefore = ConvertToXElement(hostPart, hostElement);
                VerifyNoChildren(Xbefore);
            }
            else
            {
                Log.Warning("Host element NOT found.");
            }
        }

        internal void RemoveAllTypedChildrenOnFile(FileInfo testfile, GetTargetPart getHostPart, GetTargetElement getHost, Type deleteType)
        {
            Log.BeginGroup(testfile.Name);
            using (OpenXmlPackage target = testfile.OpenPackage(true))
            {
                Log.Comment("Loading target part...");
                OpenXmlPart hostPart = getHostPart(target);

                RemoveAllTypedChildren(hostPart, getHost, deleteType);
            }
        }

        private void RemoveAllTypedChildren(OpenXmlPart hostPart, GetTargetElement getHost, Type deleteType)
        {
            Log.Comment("Loading root element in {0}...", hostPart.GetType().Name);
            OpenXmlPartRootElement main = hostPart.RootElement();

            Log.Comment("Looking for host element...");
            OpenXmlElement hostElement = getHost(main);
            if (null != hostElement)
            {
                Log.Comment("Host element found: {0}", hostElement.Path());

                if (hostElement.ChildElements.Count != 0)
                {
                    Func<Type, Type, bool> IsOfType =
                        (t, rt) => t == rt || t.IsSubclassOf(rt);

                    var childrenOfType = hostElement.ChildElements
                        .Where(c => IsOfType(c.GetType(), deleteType)).ToArray();
                    Log.Comment("Host element have {0} children of type {1}.", childrenOfType.Length, deleteType.Name);
                    var childrenPosition = childrenOfType.Select(c => c.Index()).ToArray();

                    XElement Xbefore = ConvertToXElement(hostPart, hostElement);

                    Log.Comment("Looking for RemoveAllChildren<T>() by reflecting...");
                    var flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.FlattenHierarchy;
                    var removeAll = typeof(OpenXmlElement).GetMethods(flag)
                        .Where(m => m.IsGenericMethod && m.Name.StartsWith("RemoveAllChildren"))
                        .First();
                    Log.Comment("Remove all children of {0} from host element...", deleteType.Name);
                    removeAll = removeAll.MakeGenericMethod(deleteType);
                    removeAll.Invoke(hostElement, null);

                    Log.Comment("Saving changes...");
                    main.Save();

                    Log.Comment("Verifying host element has no specified children element any more...");
                    var childrenOfTypeAfter = hostElement.ChildElements
                        .Where(c => IsOfType(c.GetType(), deleteType));
                    Log.VerifyTrue(childrenOfTypeAfter.Count() == 0, "Children of specified {0} still exists.", deleteType);

                    Log.Comment("Verifing children of specified type removed...");
                    XElement XAfter = ConvertToXElement(hostPart, hostElement);
                    VerifyRemove(XAfter, Xbefore, childrenPosition);
                }
                else
                {
                    Log.Warning("The host element has NO children!");
                }
            }
            else
            {
                Log.Warning("Host element NOT found.");
            }
        }

        #endregion RemoveAllChildren

        #region RemoveChild

        internal void RemoveChildOnFile(FileInfo testfile, GetTargetPart getHostPart, GetTargetElement getHost, GetTargetElement getDelete)
        {
            Log.BeginGroup(testfile.Name);

            using (OpenXmlPackage target = testfile.OpenPackage(true))
            {
                Log.Comment("Loading target part...");
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
            Log.Comment("Loading root element of {0}...", hostPart.GetType().Name);
            OpenXmlPartRootElement main = hostPart.RootElement();

            OpenXmlElement hostElement = getHost(main);
            if (null != hostElement)
            {
                Log.Comment("Host element found: {0}", hostElement.Path());

                OpenXmlElement deleteElement = getDelete(hostElement);
                if (null != deleteElement)
                {
                    Log.Comment("Target element found: {0}", deleteElement.Path());

                    int childPosition = (null == deleteElement ? -1 : deleteElement.Index());
                    XElement xBefore = ConvertToXElement(hostPart, hostElement);

                    Log.Comment("Removing specified child element...");
                    OpenXmlElement result = hostElement.RemoveChild<OpenXmlElement>(deleteElement);

                    Log.Comment("Save the changes");
                    main.Save();

                    Log.Comment("Verifying child removed as expected...");
                    XElement xAfter = ConvertToXElement(hostPart, hostElement);
                    VerifyRemove(xAfter, xBefore, childPosition);
                }
                else
                {
                    Log.Warning("Target element to remove NOT found.");
                }
            }
            else
            {
                Log.Warning("Host element NOT found.");
            }
        }

        /// <summary>
        /// perform remove operation
        /// </summary>
        /// <param name="target">the target element that will perform the remove operation</param>
        /// <param name="targetPosition">the child position that need to be removed</param>
        /// <returns>the removed element</returns>
        internal OpenXmlElement RemoveOperation(OpenXmlElement target, int childPosition)
        {
            if (target == null)
                throw new ArgumentNullException("target");

            if (childPosition >= target.ChildElements.Count)
                throw new IndexOutOfRangeException("targetPosition is out of range.");

            Log.Comment("retrieve the child at position {0}", childPosition);
            OpenXmlElement child2Remove = target.ChildElements.ElementAt(childPosition);

            Log.Comment("remove the child at position {0}", childPosition);
            return target.RemoveChild<OpenXmlElement>(child2Remove);
        }

        #endregion RemoveChild

        #region Remove

        internal void RemoveOnFile(FileInfo testfile, GetTargetPart getHostPart, GetTargetElement getTarget)
        {
            Log.BeginGroup(testfile.Name);

            using (OpenXmlPackage target = testfile.OpenPackage(true))
            {
                Log.Comment("Loading target part...");
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
            Log.Comment("Loading root element of {0}...", hostPart.GetType().Name);
            OpenXmlPartRootElement main = hostPart.RootElement();

            OpenXmlElement targetElement = getTarget(main);
            if (null != targetElement)
            {
                Log.Comment("Target element found: {0}", targetElement.Path());

                OpenXmlElement parent = targetElement.Parent;
                if (null != parent)
                {
                    Log.Comment("Parent element found: {0}", parent.Path());

                    int targetPosition = (null == targetElement ? -1 : targetElement.Index());
                    XElement xBefore = ConvertToXElement(hostPart, parent);

                    Log.Comment("Removing current element...");
                    targetElement.Remove();

                    Log.Comment("Save the changes");
                    main.Save();

                    Log.Comment("Verifying target removed as expected...");
                    XElement xAfter = ConvertToXElement(hostPart, parent);
                    VerifyRemove(xAfter, xBefore, targetPosition);
                }
                else
                {
                    Log.Warning("Parent of target element is NULL.");
                }
            }
            else
            {
                Log.Warning("Target element NOT found.");
            }
        }

        #endregion Remove

        #region ReplaceChild<T>(OpenXmlElement, T)

        internal void ReplaceChildOnFile(FileInfo testfile, GetTargetPart getHostPart, GetTargetElement getHost, GetTargetElement getTarget,
            FileInfo sourceFile, GetTargetPart getSrcPart, GetTargetElement getReplace, Type replaceType)
        {
            Log.BeginGroup(testfile.Name);

            using (OpenXmlPackage target = testfile.OpenPackage(true))
            using (OpenXmlPackage source = sourceFile.OpenPackage(false))
            {
                Log.Comment("Loading target Part...");
                OpenXmlPart hostPart = getHostPart(target);
                Log.Comment("Loading source Part...");
                OpenXmlPart srcHostPart = getSrcPart(source);

                if (!hostPart.IsReflectable() || !srcHostPart.IsReflectable())
                    Log.Warning("Either hostPart or srcHostPart is NOT reflectable.");

                ReplaceChild(hostPart, getHost, getTarget, srcHostPart, getReplace, replaceType);
            }
        }

        private void ReplaceChild(OpenXmlPart hostPart, GetTargetElement getHost, GetTargetElement getTarget,
            OpenXmlPart srcPart, GetTargetElement getReplace, Type replaceType)
        {
            Log.Comment("Loading root element from hosting part...");
            OpenXmlPartRootElement main = hostPart.RootElement();
            Log.Comment("Loading root element from source part...");
            OpenXmlPartRootElement srcMain = srcPart.RootElement();

            Log.Comment("Looking for target element in {0}...", hostPart.GetType().Name);
            var hostElement = getHost(main);
            Log.Comment("Found host element: {0}", hostElement.Path());
            var targetElement = getTarget(hostElement);
            if (null != targetElement)
            {
                Log.Comment("Target element found: {0}", targetElement.Path());

                int expectPos = targetElement.Index();

                Log.Comment("Looking for importing element in {0}...", srcPart.GetType().Name);
                var importElement = getReplace(srcMain);
                if (null != importElement)
                {
                    Log.Comment("Importing element found: {0}", importElement.Path());

                    Log.Comment("Looking for ReplaceChild<T>() by reflecting...");
                    var flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.FlattenHierarchy;
                    var replaceChild = hostElement.GetType().GetMethods(flag)
                        .Where(m => m.IsGenericMethod && m.Name.StartsWith("ReplaceChild"))
                        .First();
                    Log.VerifyNotNull(replaceChild, "ReplaceChild<T>() NOT found for {0}!", hostElement.GetFullName());

                    XElement xBefore = ConvertToXElement(hostPart, hostElement);
                    XElement xImport = ConvertToXElement(srcPart, importElement);
                    Log.Comment("Replacing child of {0} from host element...", replaceType.Name);
                    replaceChild = replaceChild.MakeGenericMethod(replaceType);
                    var result = replaceChild.Invoke(hostElement, new object[] { importElement.CloneNode(true), targetElement });

                    Log.Comment("Saving changes...");
                    main.Save();

                    XElement xAfter = ConvertToXElement(hostPart, hostElement);

                    Log.Comment("Check if Count of ChildElement changed...");
                    Log.VerifyTrue(xBefore.Elements().Count() == xAfter.Elements().Count(),
                        "ChildElement Count: {0} Changed After Replacing.", xBefore.Elements().Count());

                    VerifyEqual(xAfter, xImport, expectPos);
                }
                else
                {
                    Log.Warning("Importing element NOT found.");
                }
            }
            else
            {
                Log.Warning("Target element to be replaced NOT found.");
            }
        }

        #endregion ReplaceChild<T>(OpenXmlElement, T)

        #region Find Element with condition on attributes

        internal GetTargetElement getElementWithMixedAttribute =
            e => e.Descendants()
                .Where(d => d.ExtendedAttributes.Count() > 0)
                .Where(d => d.GetAttributes().Count > d.ExtendedAttributes.Count())
                .FirstOrDefault();

        internal GetTargetElement getElementWithFixedAttributeOnly =
            e => e.Descendants()
                .Where(d => d.ExtendedAttributes.Count() == 0 && d.GetAttributes().Count > 0)
                .FirstOrDefault();

        internal GetTargetElement getElementWithExtendedAttributeOnly =
            e => e.Descendants()
                .Where(d => d.ExtendedAttributes.Count() > 0 && d.GetAttributes().Count == 0)
                .FirstOrDefault();

        internal GetTargetElement getElementWithAttributes =
            e => e.Descendants()
                .Where(d => d.GetAttributes().Count > 0)
                .FirstOrDefault();

        internal GetTargetElement getElementWithoutAttributes =
            e => e.Descendants()
                .Where(d => d.GetAttributes().Count == 0)
                .FirstOrDefault();

        internal GetTargetElement getElementWithNamespaceDeclarations =
            e => e.Descendants().Union(new OpenXmlElement[] { e })
                .Where(d => d.NamespaceDeclarations.Count() > 0)
                .FirstOrDefault();

        internal GetTargetElement getElementWithoutNamespaceDeclarations =
            e => e.Descendants()
                .Where(d => d.NamespaceDeclarations.Count() == 0)
                .FirstOrDefault();
        #endregion Find Element with condition on attributes

        #region Find Attribute

        internal GetTargetAttribute getFixedAttribute =
            e => e.GetFixedAttributes().PickSecond();

        internal GetTargetAttribute getNonExistingFixedAttribute =
            e => e.GetFixedAttributes()
                .Where(fa => e.GetAttributes().All(ea => ea.NamespaceUri != fa.NamespaceUri || ea.LocalName != fa.LocalName))
                .FirstOrDefault();


        internal GetTargetAttribute getExistingAttribute =
            e => e.GetAttributes().PickSecond();

        internal GetTargetAttribute getExistingExtendedAttribute =
            e => e.ExtendedAttributes.PickSecond();

        internal GetTargetAttribute getExistingFixedAttribute =
            e =>
            {
                var attributes = e.GetAttributes()
                    .Where(a => e.ExtendedAttributes
                        .All(ex => ex.NamespaceUri != a.NamespaceUri || ex.LocalName != a.LocalName));
                return attributes.PickSecond();
            };
        internal GetTargetNamespaceDeclaration getNonExistingNamespaceDeclaration =
            e => e.Ancestors()
                .SelectMany(a => a.NamespaceDeclarations)
                .FirstOrDefault(an => !(e.NamespaceDeclarations.Select(en => en.Key).Contains(an.Key)));

        internal GetTargetNamespaceDeclaration getExistingNamespaceDeclaration =
            e => e.NamespaceDeclarations.PickSecond();

        #endregion Find Attribute

        #region GetAttribute(string localName, string namespaceUri)

        internal void GetAttributeOnFile(FileInfo testfile, GetTargetPart getHostPart, GetTargetElement getHost)
        {
            Log.BeginGroup(testfile.Name);

            using (OpenXmlPackage target = testfile.OpenPackage(true))
            {
                Log.Comment("Loading target Part...");
                OpenXmlPart hostPart = getHostPart(target);

                if (!hostPart.IsReflectable())
                    Log.Warning("Either hostPart is NOT reflectable.");
                GetAttribute(hostPart, getHost);
            }
        }

        private void GetAttribute(OpenXmlPart hostPart, GetTargetElement getHost)
        {
            Log.Comment("Loading root element from hosting part...");
            OpenXmlPartRootElement main = hostPart.RootElement();

            Log.Comment("Looking for target element in {0}...", hostPart.GetType().Name);
            var hostElement = getHost(main);
            if (null != hostElement)
            {
                Log.Comment("Host element found: {0}", hostElement.Path());

                XElement xBefore = ConvertToXElement(hostPart, hostElement);
                XAttribute xAttribute = xBefore.Attributes().FirstOrDefault();

                var attribute = hostElement.GetAttribute(xAttribute.Name.LocalName, xAttribute.Name.NamespaceName);

                Log.Comment("Checking if attribute: {0} has correct value as XAttribute...", xAttribute.Name);
                if (null == attribute)
                    Log.Fail("Attribute {0} does NOT exist.", xAttribute.Name);
                else
                    Log.VerifyValue(attribute.Value, xAttribute.Value,
                        "Attribute {0} value {1} does NOT match expected value {2}", attribute.GetFullName(), attribute.Value, xAttribute.Value);
            }
            else
            {
                Log.Warning("Host element NOT found.");
            }
        }

        #endregion GetAttribute

        #region GetAttributes

        internal void GetAttributesOnFile(FileInfo testfile, GetTargetPart getHostPart, GetTargetElement getHost)
        {
            Log.BeginGroup(testfile.Name);
            using (OpenXmlPackage target = testfile.OpenPackage(true))
            {
                Log.Comment("Loading target Part...");
                OpenXmlPart hostPart = getHostPart(target);

                if (!hostPart.IsReflectable())
                    Log.Warning("Either hostPart is NOT reflectable.");
                GetAttributes(hostPart, getHost);
            }
        }

        private void GetAttributes(OpenXmlPart hostPart, GetTargetElement getHost)
        {
            Log.Comment("Loading root element from hosting part...");
            OpenXmlPartRootElement main = hostPart.RootElement();

            Log.Comment("Looking for target element in {0}...", hostPart.GetType().Name);
            var hostElement = getHost(main);
            if (null != hostElement)
            {
                Log.Comment("Host element found: {0}", hostElement.Path());

                XElement xBefore = ConvertToXElement(hostPart, hostElement);
                var attributes = hostElement.GetAttributes();

                Log.Comment("Checking if attributes count is correct...");
                Log.VerifyValue(attributes.Count, xBefore.Attributes().Where(xa => !xa.IsNamespaceDeclaration).Count(),
                    "Attributes Count: {0} does NOT match expected value: {1}", attributes.Count, xBefore.Attributes().Where(xa => !xa.IsNamespaceDeclaration).Count());

                Log.Comment("Checking if attributes returned correctly...");
                foreach (var a in attributes)
                {
                    XAttribute xa = xBefore.Attribute(a.GetXName());
                    if (null == xa)
                        Log.Fail("Attribute {0} does NOT exist.", a.GetFullName());
                    else
                        Log.VerifyValue(a.Value, xa.Value,
                            "Attribute {0} value {1} does NOT match expected value {2}", a.GetFullName(), a.Value, xa.Value);
                }
            }
            else
            {
                Log.Warning("Host element NOT found.");
            }
        }

        #endregion GetAttributes

        #region SetAttribute(OpenXmlAttribute)

        internal void SetAttributeOnFile(FileInfo testfile, GetTargetPart getHostPart, GetTargetElement getHost,
            FileInfo sourceFile, GetTargetPart getSrcPart, GetTargetElement getImportee, GetTargetAttribute getAttribute)
        {
            Log.BeginGroup(testfile.Name);
            using (OpenXmlPackage target = testfile.OpenPackage(true))
            using (OpenXmlPackage source = sourceFile.OpenPackage(false))
            {
                Log.Comment("Loading target Part...");
                OpenXmlPart hostPart = getHostPart(target);
                Log.Comment("Loading source Part...");
                OpenXmlPart srcHostPart = getSrcPart(source);

                if (!hostPart.IsReflectable() || !srcHostPart.IsReflectable())
                    Log.Warning("Either hostPart or srcHostPart is NOT reflectable.");

                SetAttribute(hostPart, getHost, srcHostPart, getImportee, getAttribute);
            }
        }

        private void SetAttribute(OpenXmlPart hostPart, GetTargetElement getHost,
            OpenXmlPart srcPart, GetTargetElement getImportee, GetTargetAttribute getAttribute)
        {
            Log.Comment("Loading root element from hosting part...");
            OpenXmlPartRootElement main = hostPart.RootElement();
            Log.Comment("Loading root element from source part...");
            OpenXmlPartRootElement srcMain = srcPart.RootElement();

            Log.Comment("Looking for target element in {0}...", hostPart.GetType().Name);
            var hostElement = getHost(main);
            if (null != hostElement)
            {
                Log.Comment("Host element found: {0}", hostElement.Path());

                XElement XBefore = ConvertToXElement(hostPart, hostElement);

                Log.Comment("Looking for importing element in {0}...", srcPart.GetType().Name);
                var importElement = getImportee(srcMain);
                if (null != importElement)
                {
                    Log.Comment("Importing element found: {0}", importElement.Path());

                    var attribute = getAttribute(importElement);
                    if (null != attribute && default(OpenXmlAttribute) != attribute)
                    {
                        Log.Comment("Setting attribute {0} with value {1}...", attribute.GetFullName(), attribute.Value);

                        hostElement.SetAttribute(attribute);

                        Log.Comment("Saving changes...");
                        main.Save();

                        XElement XAfter = ConvertToXElement(hostPart, hostElement);
                        Log.Comment("Verifying element: {0} was set to exptected value: {1}", attribute.GetFullName(), attribute.Value);
                        Log.VerifyValue(XAfter.Attribute(attribute.GetXName()).Value, attribute.Value,
                            "Attribute {0} was set to {1} instead of exptected value: {2}", attribute.GetFullName(), XAfter.Attribute(attribute.GetXName()).Value, attribute.Value);
                    }
                    else
                    {
                        Log.Warning("Setting Null attribute to host element...");
                    }
                }
                else
                {
                    Log.Warning("Importing element NOT found.");
                }
            }
            else
            {
                Log.Warning("Host element NOT found.");
            }
        }

        internal void SetAttributesOnFile(FileInfo testfile, GetTargetPart getHostPart, GetTargetElement getHost,
            FileInfo sourceFile, GetTargetPart getSrcPart, GetTargetElement getImportee)
        {
            Log.BeginGroup(testfile.Name);
            using (OpenXmlPackage target = testfile.OpenPackage(true))
            using (OpenXmlPackage source = sourceFile.OpenPackage(false))
            {
                Log.Comment("Loading target Part...");
                OpenXmlPart hostPart = getHostPart(target);
                Log.Comment("Loading source Part...");
                OpenXmlPart srcHostPart = getSrcPart(source);

                if (!hostPart.IsReflectable() || !srcHostPart.IsReflectable())
                    Log.Warning("Either hostPart or srcHostPart is NOT reflectable.");

                SetAttributes(hostPart, getHost, srcHostPart, getImportee);
            }
        }

        private void SetAttributes(OpenXmlPart hostPart, GetTargetElement getHost,
            OpenXmlPart srcPart, GetTargetElement getImportee)
        {
            Log.Comment("Loading root element from hosting part...");
            OpenXmlPartRootElement main = hostPart.RootElement();
            Log.Comment("Loading root element from source part...");
            OpenXmlPartRootElement srcMain = srcPart.RootElement();

            Log.Comment("Looking for target element in {0}...", hostPart.GetType().Name);
            var hostElement = getHost(main);
            if (null != hostElement)
            {
                Log.Comment("Host element found: {0}", hostElement.Path());

                XElement xBefore = ConvertToXElement(hostPart, hostElement);

                Log.Comment("Looking for importing element in {0}...", srcPart.GetType().Name);
                var importElement = getImportee(srcMain);
                if (null != importElement)
                {
                    Log.Comment("Importing element found: {0}", importElement.Path());

                    var attributes = importElement.GetAttributes().AsEnumerable();

                    Log.Comment("Setting attributes in batch...");
                    hostElement.SetAttributes(attributes);

                    Log.Comment("Saving changes...");
                    main.Save();

                    XElement xAfter = ConvertToXElement(hostPart, hostElement);
                    Log.Comment("Checking if count of current element attributes is expected value {0}...", xAfter.Attributes().Where(xa => !xa.IsNamespaceDeclaration).Count());
                    Log.VerifyTrue(hostElement.GetAttributes().Count == xAfter.Attributes().Where(xa => !xa.IsNamespaceDeclaration).Count(),
                        "Count of element attributes {0} is NOT expected value {1}.", hostElement.GetAttributes().Count, xAfter.Attributes().Where(xa => !xa.IsNamespaceDeclaration).Count());

                    foreach (var a in attributes)
                    {
                        var xa = xAfter.Attribute(a.GetXName());
                        Log.VerifyNotNull(xa, "Attribute {0} was NOT set correctly.", a.GetFullName());
                        if (null != xa)
                            Log.VerifyValue(xa.Value, a.Value,
                                "Attribute {0}={1} was NOT set to expected {2}", a.GetFullName(), xa.Value, a.Value);
                    }
                }
                else
                {
                    Log.Warning("Importing element NOT found.");
                }
            }
            else
            {
                Log.Warning("Host element NOT found.");
            }
        }

        #endregion SetAttribute(OpenXmlAttribute)

        #region RemoveAttribute(localName, namespaceUri)

        internal void RemoveAttributeOnFile(FileInfo testfile, GetTargetPart getHostPart, GetTargetElement getHost, GetTargetAttribute getRemoveAttribute)
        {
            Log.BeginGroup(testfile.Name);
            using (OpenXmlPackage target = testfile.OpenPackage(true))
            {
                Log.Comment("Loading target Part...");
                OpenXmlPart hostPart = getHostPart(target);

                if (!hostPart.IsReflectable())
                    Log.Warning("Either hostPart is NOT reflectable.");
                RemoveAttribute(hostPart, getHost, getRemoveAttribute);
            }
        }

        private void RemoveAttribute(OpenXmlPart hostPart, GetTargetElement getHost, GetTargetAttribute getRemoveAttribute)
        {
            Log.Comment("Loading root element from hosting part...");
            OpenXmlPartRootElement main = hostPart.RootElement();

            Log.Comment("Looking for target element in {0}...", hostPart.GetType().Name);
            var hostElement = getHost(main);
            if (null != hostElement)
            {
                Log.Comment("Host element found: {0}", hostElement.Path());

                XElement xBefore = ConvertToXElement(hostPart, hostElement);

                var attributes = hostElement.GetAttributes();       // Return non-live source of attributes
                Log.Comment("Current host element {0} has {1} attributes.", hostElement.GetFullName(), hostElement.GetAttributes().Count);
                Log.VerifyValue(xBefore.Attributes().Where(e => !e.IsNamespaceDeclaration).Count(), hostElement.GetAttributes().Count,
                    "Different element count by (XAttribute vs OpenXmlAttribute): ({0}:{1})",
                    xBefore.Attributes().Where(xa => !xa.IsNamespaceDeclaration).Count(), hostElement.GetAttributes().Count);

                Log.Comment("Looking for target attribute to remove...");
                OpenXmlAttribute remove = getRemoveAttribute(hostElement);

                if (null != remove && default(OpenXmlAttribute) != remove)
                {
                    Log.Comment("Removing Attribute {0}", remove.GetFullName());


                    hostElement.RemoveAttribute(remove.LocalName, remove.NamespaceUri);

                    Log.Comment("Saving changes...");
                    main.Save();

                    XElement xAfter = ConvertToXElement(hostPart, hostElement);
                    Log.Comment("Checking attributes count...");
                    Log.VerifyValue(xAfter.Attributes().Where(xa => !xa.IsNamespaceDeclaration).Count(), hostElement.GetAttributes().Count,
                        "Different attributes count by (XAttribute vs OpenXmlAttribute): ({0}:{1})",
                        xAfter.Attributes().Where(xa => !xa.IsNamespaceDeclaration).Count(), hostElement.GetAttributes().Count);

                    Log.Comment("Checking if attribute removed correctly...");
                    XAttribute a = xAfter.Attribute(remove.GetXName());
                    Log.VerifyNull(a, "Attribute {0} was NOT removed as expected.", remove.GetFullName());
                }
                else
                {
                    Log.Warning("Target attribute NOT found.");

                }
            }
            else
            {
                Log.Warning("Host element which attribute to be removed NOT found.");
            }
        }

        #endregion RemoveAttribute(localName, namespaceUri)

        #region ClearAllAttributes

        internal void ClearAllAttributesOnFile(FileInfo testfile, GetTargetPart getHostPart, GetTargetElement getHost)
        {
            Log.BeginGroup(testfile.Name);
            using (OpenXmlPackage target = testfile.OpenPackage(true))
            {
                Log.Comment("Loading target Part...");
                OpenXmlPart hostPart = getHostPart(target);

                if (!hostPart.IsReflectable())
                    Log.Warning("Either hostPart is NOT reflectable.");
                ClearAllAttributes(hostPart, getHost);
            }
        }

        private void ClearAllAttributes(OpenXmlPart hostPart, GetTargetElement getHost)
        {
            Log.Comment("Loading root element from hosting part...");
            OpenXmlPartRootElement main = hostPart.RootElement();

            Log.Comment("Looking for target element in {0}...", hostPart.GetType().Name);
            var hostElement = getHost(main);
            if (null != hostElement)
            {
                Log.Comment("Host element found: {0}", hostElement.Path());

                var attributes = hostElement.GetAttributes();
                XElement xBefore = ConvertToXElement(hostPart, hostElement);

                Log.Comment("Clearing all attributes...");
                hostElement.ClearAllAttributes();

                Log.Comment("Saving changes...");
                main.Save();

                XElement xAfter = ConvertToXElement(hostPart, hostElement);
                Log.Comment("Checking if attributes count is ZERO now...");
                Log.VerifyValue(xAfter.Attributes().Where(xa => !xa.IsNamespaceDeclaration).Count(), 0,
                    "Attributes Count: {0} does NOT match expected value: {1}", xAfter.Attributes().Where(xa => !xa.IsNamespaceDeclaration).Count(), 0);

                Log.Comment("Checking if attributes returned correctly...");
                foreach (var a in attributes)
                {
                    XNamespace xns = a.NamespaceUri;
                    Log.VerifyNull(xAfter.Attribute(a.GetXName()),
                        "Attribute {0} is NOT removed as expected!", a.GetFullName());
                }
            }
            else
            {
                Log.Warning("Host element which attributes to be removed NOT found.");
            }
        }

        #endregion ClearAllAttributes

        #region AddNamespaceDeclaration
        internal void AddNamespaceDeclarationOnFile(FileInfo testfile, GetTargetPart getHostPart, GetTargetElement getHost,
            FileInfo sourceFile, GetTargetPart getSrcPart, GetTargetElement getImportee, GetTargetNamespaceDeclaration getNamespaceDeclaration)
        {
            Log.BeginGroup(testfile.Name);
            using (OpenXmlPackage target = testfile.OpenPackage(true))
            using (OpenXmlPackage source = sourceFile.OpenPackage(false))
            {
                Log.Comment("Loading target Part...");
                OpenXmlPart hostPart = getHostPart(target);
                Log.Comment("Loading source Part...");
                OpenXmlPart srcHostPart = getSrcPart(source);

                if (!hostPart.IsReflectable() || !srcHostPart.IsReflectable())
                    Log.Warning("Either hostPart or srcHostPart is NOT reflectable.");

                AddNamespaceDeclaration(hostPart, getHost, srcHostPart, getImportee, getNamespaceDeclaration);
            }
        }

        private void AddNamespaceDeclaration(OpenXmlPart hostPart, GetTargetElement getHost,
            OpenXmlPart srcPart, GetTargetElement getImportee, GetTargetNamespaceDeclaration getNamespaceDeclaration)
        {
            Log.Comment("Loading root element from hosting part...");
            OpenXmlPartRootElement main = hostPart.RootElement();
            Log.Comment("Loading root element from source part...");
            OpenXmlPartRootElement srcMain = srcPart.RootElement();

            Log.Comment("Looking for target element in {0}...", hostPart.GetType().Name);
            var hostElement = getHost(main);
            if (null != hostElement)
            {
                Log.Comment("Host element found: {0}", hostElement.Path());

                Log.Comment("NamespaceDeclarations returned by SDK before adding...");
                var namespaceDeclarations = hostElement.NamespaceDeclarations;
                foreach (var ns in namespaceDeclarations)
                    Log.Comment("xmlns:{0} = {1}", ns.Key, ns.Value);

                XElement xBefore = ConvertToXElement(hostPart, hostElement);
                Log.Comment("NamespaceDeclarations returned by XLink on same element...");
                foreach (var xa in xBefore.Attributes().Where(xa => xa.IsNamespaceDeclaration))
                    Log.Comment("xmlns:{0} = {1}", xa.Name.LocalName, xa.Value);

                Log.Comment("Looking for importing element in {0}...", srcPart.GetType().Name);
                var importElement = getImportee(srcMain);
                if (null != importElement)
                {
                    Log.Comment("Importing element found: {0}", importElement.Path());

                    var newNs = getNamespaceDeclaration(importElement);
                    if (newNs.Key != null || newNs.Value != null)
                    {
                        Log.Comment("Setting NamespaceDeclaration {0} with value {1}...", newNs.Key, newNs.Value);

                        if (hostElement.NamespaceDeclarations.Where(e => (e.Key == newNs.Key && e.Value == newNs.Value)).Count() == 0)
                        {
                            hostElement.AddNamespaceDeclaration(newNs.Key, newNs.Value);

                            Log.Comment("NamespaceDeclarations returned by SDK after adding...");
                            foreach (var ns in hostElement.NamespaceDeclarations)
                                Log.Comment("xmlns:{0} = {1}", ns.Key, ns.Value);

                            Log.VerifyTrue(hostElement.NamespaceDeclarations.Where(ns => ns.Key == newNs.Key).Count() == 1,
                                "NamespaceDeclaration {0} was NOT added as expected.", newNs.Key);
                        }

                        Log.Comment("Saving changes...");
                        main.Save();
                    }
                    else
                    {
                        Log.Warning("Setting Null NamespaceDeclaration to host element...");
                    }
                }
                else
                {
                    Log.Warning("Importing element NOT found.");
                }
            }
            else
            {
                Log.Warning("Host element NOT found.");
            }
        }
        #endregion AddNamespaceDeclaration

        #region RemoveNamespaceDeclaration

        internal void RemoveNamespaceDeclarationOnFile(FileInfo testfile, GetTargetPart getHostPart, GetTargetElement getHost, GetTargetNamespaceDeclaration getRemoveNS)
        {
            Log.BeginGroup(testfile.Name);

            using (OpenXmlPackage target = testfile.OpenPackage(true))
            {
                Log.Comment("Loading target Part...");
                OpenXmlPart hostPart = getHostPart(target);

                if (!hostPart.IsReflectable())
                    Log.Warning("Either hostPart is NOT reflectable.");
                RemoveNamespaceDeclaration(hostPart, getHost, getRemoveNS);
            }
        }

        private void RemoveNamespaceDeclaration(OpenXmlPart hostPart, GetTargetElement getHost, GetTargetNamespaceDeclaration getRemoveNS)
        {
            Log.Comment("Loading root element from hosting part...");
            OpenXmlPartRootElement main = hostPart.RootElement();

            Log.Comment("Looking for target element in {0}...", hostPart.GetType().Name);
            var hostElement = getHost(main);
            if (null != hostElement)
            {
                Log.Comment("Host element found: {0}", hostElement.Path());

                Log.Comment("NamespaceDeclarations returned by SDK before removing...");
                var namespaceDeclarations = hostElement.NamespaceDeclarations;
                foreach (var ns in namespaceDeclarations)
                    Log.Comment("xmlns:{0} = {1}", ns.Key, ns.Value);

                XElement xBefore = ConvertToXElement(hostPart, hostElement);
                Log.Comment("NamespaceDeclarations returned by XLink on same element...");
                foreach (var xa in xBefore.Attributes().Where(xa => xa.IsNamespaceDeclaration))
                    Log.Comment("xmlns:{0} = {1}", xa.Name.LocalName, xa.Value);

                var nss = hostElement.NamespaceDeclarations;       // Return non-live source of NamespaceDeclaration
                Log.Comment("Current host element {0} has {1} NamespaceDeclarations.", hostElement.GetFullName(), nss.Count());
                Log.VerifyValue(xBefore.Attributes().Where(xa => xa.IsNamespaceDeclaration && xa.Name != "xmlns").Count(), hostElement.NamespaceDeclarations.Count(),
                    "Different NamespaceDeclaration count by (XElement vs OpenXmlElement): ({0}:{1})", xBefore.Attributes().Where(xa => xa.IsNamespaceDeclaration && xa.Name != "xmlns").Count(), hostElement.NamespaceDeclarations.Count());

                Log.Comment("Looking for target NamespaceDeclaration to remove...");
                var remove = getRemoveNS(hostElement);
                if (null != remove.Key || null != remove.Value)
                {
                    Log.Comment("Removing NamespaceDeclaration {0}:{1}", remove.Key, remove.Value);

                    hostElement.RemoveNamespaceDeclaration(remove.Key);

                    Log.Comment("NamespaceDeclarations returned by SDK after removing...");
                    foreach (var ns in hostElement.NamespaceDeclarations)
                        Log.Comment("xmlns:{0} = {1}", ns.Key, ns.Value);

                    Log.VerifyTrue(hostElement.NamespaceDeclarations.Where(ns => ns.Key == remove.Key).Count() == 0,
                        "NamespaceDeclaration {0} was NOT removed as expected.", remove.Key);

                    Log.Comment("Saving changes...");
                    main.Save();
                }
                else
                {
                    Log.Warning("Target NamespaceDeclaration NOT found.");
                }
            }
            else
            {
                Log.Warning("Host element which NamespaceDeclaration to be removed NOT found.");
            }
        }
        #endregion RemoveNamespaceDeclaration

        #region NamespaceDeclarations

        internal void NamespaceDeclarationsOnFile(FileInfo testfile, GetTargetPart getHostPart, GetTargetElement getHost)
        {
            Log.BeginGroup(testfile.Name);

            using (OpenXmlPackage target = testfile.OpenPackage(true))
            {
                Log.Comment("Loading target Part...");
                OpenXmlPart hostPart = getHostPart(target);

                if (!hostPart.IsReflectable())
                    Log.Warning("Either hostPart is NOT reflectable.");
                NamespaceDeclarations(hostPart, getHost);
            }
        }

        private void NamespaceDeclarations(OpenXmlPart hostPart, GetTargetElement getHost)
        {
            Log.Comment("Loading root element from hosting part...");
            OpenXmlPartRootElement main = hostPart.RootElement();

            Log.Comment("Looking for target element in {0}...", hostPart.GetType().Name);
            var hostElement = getHost(main);
            if (null != hostElement)
            {
                Log.Comment("Host element found: {0}", hostElement.Path());

                Log.Comment("NamespaceDeclarations returned by SDK on the element...");
                var namespaceDeclarations = hostElement.NamespaceDeclarations;
                foreach (var ns in namespaceDeclarations)
                    Log.Comment("xmlns:{0} = {1}", ns.Key, ns.Value);

                XElement xBefore = ConvertToXElement(hostPart, hostElement);
                Log.Comment("NamespaceDeclarations returned by XLink on same element...");
                foreach (var xa in xBefore.Attributes().Where(xa => xa.IsNamespaceDeclaration && xa.Name.LocalName != "xmlns"))
                    Log.Comment("xmlns:{0} = {1}", xa.Name.LocalName, xa.Value);

                Log.Comment("Checking if NamespaceDeclarations count is correct...");
                Log.VerifyValue(namespaceDeclarations.Count(), xBefore.Attributes().Where(a => a.IsNamespaceDeclaration && a.Name.LocalName != "xmlns").Count(),
                    "NamespaceDeclarations Count: {0} does NOT match expected value: {1}", namespaceDeclarations.Count(), xBefore.Attributes().Where(a => a.IsNamespaceDeclaration).Count());

                Log.Comment("Checking if NamespaceDeclarations returned correctly...");
                foreach (var ns in namespaceDeclarations)
                {
                    var nsUri = xBefore.GetNamespaceOfPrefix(ns.Key).NamespaceName;
                    if (null == nsUri)
                        Log.Fail("NamespaceDeclaration {0} does NOT exist.", ns.Key);
                    else
                        Log.VerifyValue(ns.Value, nsUri,
                            "NamespaceDeclaration {0} value {1} does NOT match expected value {2}", ns.Key, ns.Value, nsUri);
                }
            }
            else
            {
                Log.Warning("Host element NOT found.");
            }
        }
        #endregion NamespaceDeclarations

        #region OuterXml

        internal void GetOuterXmlOnFile(FileInfo testfile, GetTargetPart getHostPart, GetTargetElement getHost)
        {
            Log.BeginGroup(testfile.Name);
            using (OpenXmlPackage target = testfile.OpenPackage(true))
            {
                Log.Comment("Loading target Part...");
                OpenXmlPart hostPart = getHostPart(target);

                if (!hostPart.IsReflectable())
                    Log.Warning("Current HostPart is NOT reflectable.");
                GetOuterXml(hostPart, getHost);
            }
        }

        private void GetOuterXml(OpenXmlPart hostPart, GetTargetElement getHost)
        {
            Log.Comment("Loading root element from hosting part...");
            OpenXmlPartRootElement main = hostPart.RootElement();

            Log.Comment("Looking for target element in {0}...", hostPart.GetType().Name);
            var hostElement = getHost(main);
            if (null != hostElement)
            {
                Log.Comment("Host element found: {0}", hostElement.Path());

                XElement xBefore = ConvertToXElement(hostPart, hostElement);
                string outerXml = hostElement.OuterXml;

                Log.Comment("Checking if XElement count vs OpenXmlElement Children Count...");
                Log.VerifyTrue(hostElement.ChildElements.Count == xBefore.Elements().Count(),
                    "Children element returned by OpenXmlElement {0} is different from XElement {1}", hostElement.ChildElements.Count, xBefore.Elements().Count());

                var result = xBefore.Compare(XElement.Load(new StringReader(outerXml)));
                Log.VerifyTrue(result, "OuterXml is not returned as expected.");
            }
            else
            {
                Log.Warning("Host element NOT found.");
            }
        }

        #endregion OuterXml

        #region Clone

        internal void CloneOnFile(FileInfo testfile, GetTargetPart getHostPart, GetTargetElement getHost)
        {
            Log.BeginGroup(testfile.Name);
            using (OpenXmlPackage target = testfile.OpenPackage(true))
            {
                Log.Comment("Loading target Part...");
                OpenXmlPart hostPart = getHostPart(target);

                if (!hostPart.IsReflectable())
                    Log.Warning("Current hostPart is NOT reflectable.");
                Clone(hostPart, getHost);
            }
        }

        private void Clone(OpenXmlPart hostPart, GetTargetElement getHost)
        {
            Log.Comment("Loading root element from hosting part...");
            OpenXmlPartRootElement main = hostPart.RootElement();

            Log.Comment("Looking for target element in {0}...", hostPart.GetType().Name);
            var hostElement = getHost(main);
            if (null != hostElement)
            {
                Log.Comment("Host element found: {0}", hostElement.Path());

                XElement xBefore = ConvertToXElement(hostPart, hostElement);

                // Clone() behaves as CloneNode(true) except it return object instead of OpenXmlElement
                Log.Comment("Deep Clone ...");
                var clone = hostElement.Clone() as OpenXmlElement;
                string outerXml = clone.OuterXml;
                var xAfter = XElement.Load(new StringReader(outerXml));

                Log.Comment("Checking if XElement count vs OpenXmlElement Children Count...");
                Log.VerifyTrue(hostElement.ChildElements.Count == xBefore.Elements().Count(),
                    "Children element returned by OpenXmlElement {0} is different from XElement {1}", hostElement.ChildElements.Count, xBefore.Elements().Count());

                var result = xBefore.Compare(XElement.Load(new StringReader(outerXml)));
                Log.VerifyTrue(result, "Pass-in element is not cloned as expected.");
            }
            else
            {
                Log.Warning("Host element NOT found.");
            }
        }

        internal void CloneNodeFalseOnFile(FileInfo testfile, GetTargetPart getHostPart, GetTargetElement getHost)
        {
            Log.BeginGroup(testfile.Name);
            using (OpenXmlPackage target = testfile.OpenPackage(true))
            {
                Log.Comment("Loading target Part...");
                OpenXmlPart hostPart = getHostPart(target);

                if (!hostPart.IsReflectable())
                    Log.Warning("Current hostPart is NOT reflectable.");
                CloneNodeFalse(hostPart, getHost);
            }
        }

        private void CloneNodeFalse(OpenXmlPart hostPart, GetTargetElement getHost)
        {
            Log.Comment("Loading root element from hosting part...");
            OpenXmlPartRootElement main = hostPart.RootElement();

            Log.Comment("Looking for target element in {0}...", hostPart.GetType().Name);
            var hostElement = getHost(main);
            if (null != hostElement)
            {
                Log.Comment("Host element found: {0}", hostElement.Path());

                var attributes = hostElement.GetAttributes();
                XElement xBefore = ConvertToXElement(hostPart, hostElement);

                // CloneNode(false) returns tag and attributes of current element
                Log.Comment("Shallow Clone ...");
                var clone = hostElement.CloneNode(false);

                Log.VerifyValue(clone.ChildElements.Count, 0,
                    "Shallow cloned node contains {0} Child Elements!", clone.ChildElements.Count);
                Log.VerifyValue(clone.GetFullName(), hostElement.GetFullName(),
                    "Shallow cloned node: {0} contains wrong name: {1}", hostElement.GetFullName(), clone.GetFullName());
                Log.Comment("Verifying attributes cloned exactly...");
                foreach (var ca in clone.GetAttributes())
                {
                    var result = attributes.Any(a => a.GetFullName() == ca.GetFullName() && a.Value == ca.Value);
                    if (result)
                        Log.Comment("Verified same attribute {0}={1}", ca.GetFullName(), ca.Value);
                    else
                        Log.Fail("attriute {0} not found with expected value {1}", ca.GetFullName(), ca.Value);
                }
            }
            else
            {
                Log.Warning("Host element NOT found.");
            }
        }

        #endregion Clone

        #region InnerXml

        internal void GetInnerXmlOnFile(FileInfo testfile, GetTargetPart getHostPart, GetTargetElement getHost)
        {
            Log.BeginGroup(testfile.Name);
            using (OpenXmlPackage target = testfile.OpenPackage(true))
            {
                Log.Comment("Loading target Part...");
                OpenXmlPart hostPart = getHostPart(target);

                if (!hostPart.IsReflectable())
                    Log.Warning("Current hostPart is NOT reflectable.");
                GetInnerXml(hostPart, getHost);
            }
        }

        private void GetInnerXml(OpenXmlPart hostPart, GetTargetElement getHost)
        {
            Log.Comment("Loading root element from hosting part...");
            OpenXmlPartRootElement main = hostPart.RootElement();

            Log.Comment("Looking for target element in {0}...", hostPart.GetType().Name);
            var hostElement = getHost(main);
            if (null != hostElement)
            {
                Log.Comment("Host element found: {0}", hostElement.Path());

                Log.Comment("Accumulating child elements' OuterXml...");
                var elementsXml = string.Empty;
                if (hostElement.HasChildren)
                    elementsXml = hostElement.ChildElements.Aggregate(elementsXml, (cs, e) => cs + e.OuterXml);
                else
                    elementsXml = hostElement is OpenXmlLeafTextElement ? hostElement.InnerText : string.Empty;

                Log.Comment("Verifying InnerXml with accumulated child elements' OuterXml...");
                string innerXml = hostElement.InnerXml;
                Log.VerifyValue(innerXml, elementsXml,
                    "InnerXml is different from accumulated child elements' OuterXml.");
            }
            else
            {
                Log.Warning("Host element NOT found.");
            }
        }

        internal void SetInnerXmlOnFile(FileInfo testfile, GetTargetPart getHostPart, GetTargetElement getHost,
            FileInfo sourceFile, GetTargetPart getSrcPart, GetTargetElement getImportee)
        {
            Log.BeginGroup(testfile.Name);
            using (OpenXmlPackage target = testfile.OpenPackage(true))
            using (OpenXmlPackage source = sourceFile.OpenPackage(false))
            {
                Log.Comment("Loading target Part...");
                OpenXmlPart hostPart = getHostPart(target);
                Log.Comment("Loading source Part...");
                OpenXmlPart srcHostPart = getSrcPart(source);

                if (!hostPart.IsReflectable() || !srcHostPart.IsReflectable())
                    Log.Warning("Either hostPart or srcHostPart is NOT reflectable.");
                SetInnerXml(hostPart, getHost, srcHostPart, getImportee);
            }
        }

        private void SetInnerXml(OpenXmlPart hostPart, GetTargetElement getHost,
            OpenXmlPart srcPart, GetTargetElement getImportee)
        {
            Log.Comment("Loading root element from hosting part...");
            OpenXmlPartRootElement main = hostPart.RootElement();
            Log.Comment("Loading root element from source part...");
            OpenXmlPartRootElement srcMain = srcPart.RootElement();

            Log.Comment("Looking for target element in {0}...", hostPart.GetType().Name);
            var hostElement = getHost(main);
            if (null != hostElement)
            {
                Log.Comment("Host element found: {0}.", hostElement.Path());

                Log.Comment("Looking for importing element in {0}...", srcPart.GetType().Name);
                var importHost = getImportee(srcMain);
                if (null != importHost)
                {
                    Log.Comment("Importing element found: {0}.", importHost.Path());

                    XElement XBefore = ConvertToXElement(hostPart, hostElement);
                    var fullName = hostElement.GetFullName();
                    var attributes = hostElement.GetAttributes();

                    Log.Comment("Accumulating {0} child elements' OuterXml of {1}...", importHost.ChildElements.Count, importHost.GetFullName());
                    var elementsXml = string.Empty;
                    elementsXml = importHost.ChildElements.Aggregate(elementsXml, (cs, e) => cs + e.OuterXml);

                    Log.Comment("Setting InnerXml...");
                    hostElement.InnerXml = elementsXml;

                    Log.Comment("Saving changes...");
                    main.Save();

                    XElement XAfter = ConvertToXElement(hostPart, hostElement);

                    Log.VerifyValue(hostElement.GetFullName(), fullName,
                        "Tag Name change from {0} to {1}", fullName, hostElement.GetFullName());
                    Log.Comment("Verifying attributes are kept exactly...");
                    foreach (var ca in hostElement.GetAttributes())
                    {
                        var result = attributes.Any(a => a.GetFullName() == ca.GetFullName() && a.Value == ca.Value);
                        if (result)
                            Log.Comment("Verified same attribute {0}={1}", ca.GetFullName(), ca.Value);
                        else
                            Log.Fail("attriute {0} not found with expected value {1}", ca.GetFullName(), ca.Value);
                    }

                    Log.Comment("Checking if children element are set onto host...");
                    Log.VerifyValue(XAfter.Elements().Count(), importHost.ChildElements.Count,
                        "Children element count {0} is different from expected {1}!", XAfter.Elements().Count(), importHost.ChildElements.Count);
                    for (int i = 0; i < importHost.ChildElements.Count; i++)
                    {
                        var importElementOuterXml = importHost.ChildElements[i].OuterXml;
                        VerifyEqual(XAfter, XElement.Load(new StringReader(importElementOuterXml)), i);
                    }
                }
                else
                {
                    Log.Warning("No Expected Element found");
                }
            }
            else
            {
                Log.Warning("Host element NOT found.");
            }
        }

        #endregion InnerXml

        #region WriteTo

        internal void WriteToOnFile(FileInfo testfile, GetTargetPart getHostPart, GetTargetElement getHost)
        {
            Log.BeginGroup(testfile.Name);
            using (OpenXmlPackage target = testfile.OpenPackage(true))
            {
                Log.Comment("Loading target Part...");
                OpenXmlPart hostPart = getHostPart(target);

                if (!hostPart.IsReflectable())
                    Log.Warning("Either hostPart is NOT reflectable.");
                WriteTo(hostPart, getHost);
            }
        }

        private void WriteTo(OpenXmlPart hostPart, GetTargetElement getHost)
        {
            Log.Comment("Loading root element from hosting part...");
            OpenXmlPartRootElement main = hostPart.RootElement();

            Log.Comment("Looking for target element in {0}...", hostPart.GetType().Name);
            var hostElement = getHost(main);
            if (null != hostElement)
            {
                Log.Comment("Host element found with path: {0}.", hostElement.Path());

                XElement xBefore = ConvertToXElement(hostPart, hostElement);

                Log.Comment("Writ content To cache...");
                StringBuilder sb = new StringBuilder();
                using (var writer = XmlWriter.Create(sb))
                    hostElement.WriteTo(writer);
                string outerXml = sb.ToString();

                XElement xAfter = XElement.Load(new StringReader(outerXml));
                Log.Comment("Checking if element count not changed...");
                Log.VerifyTrue(xAfter.Elements().Count() == xBefore.Elements().Count(),
                    "Children element in written out {0} is different from original {1}", xAfter.Elements().Count(), xBefore.Elements().Count());

                Log.Comment("Comparing element content...");
                var result = xBefore.Compare(xAfter);
                Log.VerifyTrue(result, "WriteTo returned different content from expected.");
            }
            else
            {
                Log.Warning("Host element NOT found.");
            }
        }

        #endregion WriteTo

        #region EventHandlers

        internal OpenXmlElement validReplaceEventHandler(OpenXmlElement hostElement)
        {
            hostElement.OpenXmlElementContext.ElementInserting += new EventHandler<ElementEventArgs>(expectedElementInserting);
            hostElement.OpenXmlElementContext.ElementInserted += new EventHandler<ElementEventArgs>(expectedElementInserted);
            hostElement.OpenXmlElementContext.ElementRemoving += new EventHandler<ElementEventArgs>(expectedElementRemoving);
            hostElement.OpenXmlElementContext.ElementRemoved += new EventHandler<ElementEventArgs>(expectedElementRemoved);
            return hostElement;
        }
        internal OpenXmlElement validInsertEventHandler(OpenXmlElement hostElement)
        {
            hostElement.OpenXmlElementContext.ElementInserting += new EventHandler<ElementEventArgs>(expectedElementInserting);
            hostElement.OpenXmlElementContext.ElementInserted += new EventHandler<ElementEventArgs>(expectedElementInserted);
            hostElement.OpenXmlElementContext.ElementRemoving += new EventHandler<ElementEventArgs>(surprisingElementRemoving);
            hostElement.OpenXmlElementContext.ElementRemoved += new EventHandler<ElementEventArgs>(surprisingElementRemoved);
            return hostElement;
        }
        internal OpenXmlElement validRemoveEventHandler(OpenXmlElement hostElement)
        {
            hostElement.OpenXmlElementContext.ElementInserting += new EventHandler<ElementEventArgs>(surprisingElementInserting);
            hostElement.OpenXmlElementContext.ElementInserted += new EventHandler<ElementEventArgs>(surprisingElementInserted);
            hostElement.OpenXmlElementContext.ElementRemoving += new EventHandler<ElementEventArgs>(expectedElementRemoving);
            hostElement.OpenXmlElementContext.ElementRemoved += new EventHandler<ElementEventArgs>(expectedElementRemoved);
            return hostElement;
        }

        internal OpenXmlElement invalidEventHandler(OpenXmlElement hostElement)
        {
            hostElement.OpenXmlElementContext.ElementInserting += new EventHandler<ElementEventArgs>(surprisingElementInserting);
            hostElement.OpenXmlElementContext.ElementInserted += new EventHandler<ElementEventArgs>(surprisingElementInserted);
            hostElement.OpenXmlElementContext.ElementRemoving += new EventHandler<ElementEventArgs>(surprisingElementRemoving);
            hostElement.OpenXmlElementContext.ElementRemoved += new EventHandler<ElementEventArgs>(surprisingElementRemoved);
            return hostElement;
        }

        void expectedElementInserting(object sender, ElementEventArgs args)
        {
            Log.Pass("ElementInserting event caught.");
            Log.Comment("[ElementInserting] Inserting {0} to {1}...", args.Element.GetFullName(), args.ParentElement.GetFullName());
            Log.VerifyNull(args.Element.Parent, "New child element has Non-Null parent before inserting.");
            Log.VerifyNotNull(args.ParentElement, "ParentElement is Null before inserting.");

            Log.VerifyTrue(sender is OpenXmlElementContext, "Sender is {0}, NOT OpenXmlElementContext!", sender.GetType().Name);
            Log.VerifyReference(args.ParentElement.OpenXmlElementContext, sender, "ParentElement has different OpenXmlElementContext before inserting!");
            Log.VerifyNotReference(args.Element.OpenXmlElementContext, sender, "New element has same OpenXmlElementContext before inserting!");
        }

        void surprisingElementInserting(object sender, ElementEventArgs args)
        {
            Log.Fail("ElementInserting event caught.");
            Log.Comment("[ElementInserting] Inserting {0} to {1}...", args.Element.GetFullName(), args.ParentElement.GetFullName());
            Log.VerifyNull(args.Element.Parent, "New child element has Non-Null parent before inserting.");
            Log.VerifyNotNull(args.ParentElement, "ParentElement is Null before inserting.");

            Log.VerifyTrue(sender is OpenXmlElementContext, "Sender is {0}, NOT OpenXmlElementContext!", sender.GetType().Name);
            Log.VerifyReference(args.ParentElement.OpenXmlElementContext, sender, "ParentElement has different OpenXmlElementContext before inserting!");
            Log.VerifyNotReference(args.Element.OpenXmlElementContext, sender, "New element has same OpenXmlElementContext before inserting!");
        }

        void expectedElementInserted(object sender, ElementEventArgs args)
        {
            Log.Pass("ElementInserted event caught.");
            Log.Comment("[ElementInserted] Inserted {0} to {1}...", args.Element.GetFullName(), args.ParentElement.GetFullName());
            Log.VerifyNotNull(args.Element.Parent, "New child element has Null parent after been inserted.");
            Log.Verify(args.ParentElement == args.Element.Parent,
                "Element inserted {0} has different parent from expected {1}.", args.Element.GetFullName(), args.ParentElement.GetFullName());

            Log.VerifyTrue(sender is OpenXmlElementContext, "Sender is {0}, NOT OpenXmlElementContext!", sender.GetType().Name);
            Log.VerifyReference(args.ParentElement.OpenXmlElementContext, sender, "ParentElement has different OpenXmlElementContext after inserting!");
            Log.VerifyReference(args.Element.OpenXmlElementContext, sender, "New child element still has different OpenXmlElementContext after been inserted!");
        }

        void surprisingElementInserted(object sender, ElementEventArgs args)
        {
            Log.Fail("ElementInserted event caught.");
            Log.Comment("[ElementInserted] Inserted {0} to {1}...", args.Element.GetFullName(), args.ParentElement.GetFullName());
            Log.VerifyNotNull(args.Element.Parent, "New child element has Null parent after been inserted.");
            Log.Verify(args.ParentElement == args.Element.Parent,
                "Element inserted {0} has different parent from expected {1}.", args.Element.GetFullName(), args.ParentElement.GetFullName());

            Log.VerifyTrue(sender is OpenXmlElementContext, "Sender is {0}, NOT OpenXmlElementContext!", sender.GetType().Name);
            Log.VerifyReference(args.ParentElement.OpenXmlElementContext, sender, "ParentElement has different OpenXmlElementContext after inserting!");
            Log.VerifyReference(args.Element.OpenXmlElementContext, sender, "New child element still has different OpenXmlElementContext after been inserted!");
        }

        void expectedElementRemoving(object sender, ElementEventArgs args)
        {
            Log.Pass("ElementRemoving event caught.");
            Log.Comment("[ElementRemoving] Removing {0} from {1}...", args.Element.GetFullName(), args.ParentElement.GetFullName());
            Log.VerifyNotNull(args.Element.Parent, "Child element has Null parent before removing.");
            Log.VerifyNotNull(args.ParentElement, "Parent element is Null before removing.");
            Log.Verify(args.ParentElement == args.Element.Parent,
                "Element to be removed {0} has different parent from expected {1}.", args.Element.GetFullName(), args.ParentElement.GetFullName());

            Log.VerifyTrue(sender is OpenXmlElementContext, "Sender is {0}, NOT OpenXmlElementContext!", sender.GetType().Name);
            Log.VerifyReference(args.ParentElement.OpenXmlElementContext, sender, "ParentElement has different OpenXmlElementContext before removing!");
            Log.VerifyReference(args.Element.OpenXmlElementContext, sender, "Child element has different OpenXmlElementContext before removing!");
        }

        void surprisingElementRemoving(object sender, ElementEventArgs args)
        {
            Log.Fail("ElementRemoving event caught.");
            Log.Comment("[ElementRemoving] Removing {0} from {1}...", args.Element.GetFullName(), args.ParentElement.GetFullName());
            Log.VerifyNotNull(args.Element.Parent, "Child element has Null parent before removing.");
            Log.VerifyNotNull(args.ParentElement, "Parent element is Null before removing.");
            Log.Verify(args.ParentElement == args.Element.Parent,
                "Element to be removed {0} has different parent from expected {1}.", args.Element.GetFullName(), args.ParentElement.GetFullName());

            Log.VerifyTrue(sender is OpenXmlElementContext, "Sender is {0}, NOT OpenXmlElementContext!", sender.GetType().Name);
            Log.VerifyReference(args.ParentElement.OpenXmlElementContext, sender, "ParentElement has different OpenXmlElementContext before removing!");
            Log.VerifyReference(args.Element.OpenXmlElementContext, sender, "Child element has different OpenXmlElementContext before removing!");
        }

        void expectedElementRemoved(object sender, ElementEventArgs args)
        {
            Log.Pass("ElementRemoved event caught.");
            Log.Comment("[ElementRemoved] Removed {0} from {1}...", args.Element.GetFullName(), args.ParentElement.GetFullName());
            Log.VerifyNull(args.Element.Parent, "Child element to be removed has Non-Null parent after removing.");
            Log.VerifyNotNull(args.ParentElement, "Parent element is Null after removing.");

            Log.VerifyTrue(sender is OpenXmlElementContext, "Sender is {0}, NOT OpenXmlElementContext!", sender.GetType().Name);
            Log.VerifyReference(args.ParentElement.OpenXmlElementContext, sender, "ParentElement has different OpenXmlElementContext after removing!");
            Log.VerifyNotReference(args.Element.OpenXmlElementContext, sender, "Child element still has same OpenXmlElementContext after removing!");
        }

        void surprisingElementRemoved(object sender, ElementEventArgs args)
        {
            Log.Fail("ElementRemoved event caught.");
            Log.Comment("[ElementRemoved] Removed {0} from {1}...", args.Element.GetFullName(), args.ParentElement.GetFullName());
            Log.VerifyNull(args.Element.Parent, "Child element to be removed has Non-Null parent after removing.");
            Log.VerifyNotNull(args.ParentElement, "Parent element is Null after removing.");

            Log.VerifyTrue(sender is OpenXmlElementContext, "Sender is {0}, NOT OpenXmlElementContext!", sender.GetType().Name);
            Log.VerifyReference(args.ParentElement.OpenXmlElementContext, sender, "ParentElement has different OpenXmlElementContext after removing!");
            Log.VerifyNotReference(args.Element.OpenXmlElementContext, sender, "Child element still has same OpenXmlElementContext after removing!");
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
            Log.Comment("Loading root element from hosting part...");
            OpenXmlPartRootElement main = hostPart.RootElement();

            Log.Comment("Looking for target element in {0}...", hostPart.GetType().Name);
            var hostElement = getHost(main);

            Log.Comment("Removing all annotations for setup...");
            hostElement.RemoveAnnotations(typeof(object));
            var results = hostElement.Annotations(typeof(object));
            if (null == results || results.Count() == 0)
                Log.Pass("Removed all annotations.");

            Log.Comment("Adding annotations...");
            var annotation = hostElement.FirstChild;
            hostElement.AddAnnotation(annotation);

            Log.Comment("Retrieving annotations...");
            var result = hostElement.Annotation(annotation.GetType());
            if (annotation == result)
                Log.Pass("Annotation retrieved is exactly same one as added.");
            else
                Log.Fail("Annotation retrieved is different from the one added.");

            Log.Comment("Retrieving annotations...");
            results = hostElement.Annotations(annotation.GetType());
            Log.VerifyValue(results.Count(), 1, "Annotations count differs from expected vlaue: ONE.");
            if (results.First() == result)
                Log.Pass("Annotation retrieved is exactly same one as added.");
            else
                Log.Fail("Annotation retrieved is different from the one added.");

            Log.Comment("Removing annotations for cleanup...");
            hostElement.RemoveAnnotations(annotation.GetType());
            results = hostElement.Annotations(annotation.GetType());
            if (null == results || results.Count() == 0)
                Log.Pass("Removed all annotations.");
        }

        internal void AnnotationT(OpenXmlPart hostPart, GetTargetElement getHost)
        {
            Log.Comment("Loading root element from hosting part...");
            OpenXmlPartRootElement main = hostPart.RootElement();

            Log.Comment("Looking for target element in {0}...", hostPart.GetType().Name);
            var hostElement = getHost(main);

            Log.Comment("Removing all annotations for setup...");
            hostElement.RemoveAnnotations<object>();
            var results = hostElement.Annotations<object>();
            if (null == results || results.Count() == 0)
                Log.Pass("Removed all annotations.");

            Log.Comment("Adding annotations...");
            var annotation = hostElement.FirstChild;
            hostElement.AddAnnotation(annotation);

            Log.Comment("Retrieving annotations...");
            var result = hostElement.Annotation<OpenXmlElement>();
            if (annotation == result)
                Log.Pass("Annotation retrieved is exactly same one as added.");
            else
                Log.Fail("Annotation retrieved is different from the one added.");

            Log.Comment("Retrieving annotations...");
            var oResults = hostElement.Annotations<OpenXmlElement>();
            Log.VerifyValue(oResults.Count(), 1, "Annotations count differs from expected vlaue: ONE.");
            if (oResults.First() == result)
                Log.Pass("Annotation retrieved is exactly same one as added.");
            else
                Log.Fail("Annotation retrieved is different from the one added.");

            Log.Comment("Removing annotations for cleanup...");
            hostElement.RemoveAnnotations<OpenXmlElement>();
            results = hostElement.Annotations(annotation.GetType());
            if (null == results || results.Count() == 0)
                Log.Pass("Removed all annotations.");
        }

        internal void AnnotationArray(OpenXmlPart hostPart, GetTargetElement getHost)
        {
            Log.Comment("Loading root element from hosting part...");
            OpenXmlPartRootElement main = hostPart.RootElement();

            Log.Comment("Looking for target element in {0}...", hostPart.GetType().Name);
            var hostElement = getHost(main);

            Log.Comment("Removing all annotations for setup...");
            hostElement.RemoveAnnotations(typeof(object));
            var results = hostElement.Annotations(typeof(object));
            if (null == results || results.Count() == 0)
                Log.Pass("Removed all annotations.");

            Log.Comment("Adding first child as annotation...");
            var annotation = hostElement.FirstChild;
            hostElement.AddAnnotation(annotation);

            Log.Comment("Adding annotations...");
            var annotations = hostElement.Elements().ToArray();
            hostElement.AddAnnotation(annotations);

            Log.Comment("Adding last child as annotation...");
            annotation = hostElement.LastChild;
            hostElement.AddAnnotation(annotation);

            Log.Comment("Retrieving annotation...");
            var result = hostElement.Annotation(typeof(OpenXmlElement));
            if (result == hostElement.FirstChild)
                Log.Pass("Annotation retrieved is exactly same one as added.");
            else
                Log.Fail("Annotation retrieved is different from the one added.");

            Log.Comment("Retrieving annotation of array...");
            var resultArray = hostElement.Annotation(typeof(OpenXmlElement[])) as OpenXmlElement[];
            if (resultArray.SequenceEqual(hostElement.Elements()))
                Log.Pass("Annotation of array retrieved is exactly same one as added.");
            else
                Log.Fail("Annotation of array retrieved is different from the one added.");

            int index = 0;
            var expected = new OpenXmlElement[2];
            expected[index++] = hostElement.FirstChild;
            expected[index++] = hostElement.LastChild;

            Log.Comment("Retrieving annotations of OpenXmlElement...");
            results = hostElement.Annotations(typeof(OpenXmlElement));
            Log.VerifyValue(results.Count(), expected.Length, "Annotations counts differ from expected vlaue: {0}.", expected.Length);
            if (results.SequenceEqual(expected))
                Log.Pass("Annotations retrieved are exactly same ones as added.");
            else
                Log.Fail("Annotations retrieved are different from the ones added.");

            Log.Comment("Removing annotations of OpenXmlElement...");
            hostElement.RemoveAnnotations(typeof(OpenXmlElement));
            results = hostElement.Annotations(typeof(OpenXmlElement));
            if (null == results || results.Count() == 0)
                Log.Pass("Removed all annotations.");

            Log.Comment("Removing annotations for cleanup...");
            hostElement.RemoveAnnotations(typeof(object));
            results = hostElement.Annotations(typeof(object));
            if (null == results || results.Count() == 0)
                Log.Pass("Removed all annotations.");
        }

        internal void AnnotationCollection(OpenXmlPart hostPart, GetTargetElement getHost)
        {
            Log.Comment("Loading root element from hosting part...");
            OpenXmlPartRootElement main = hostPart.RootElement();

            Log.Comment("Looking for target element in {0}...", hostPart.GetType().Name);
            var hostElement = getHost(main);

            Log.Comment("Removing all annotations for setup...");
            hostElement.RemoveAnnotations(typeof(object));
            var results = hostElement.Annotations(typeof(object));
            if (null == results || results.Count() == 0)
                Log.Pass("Removed all annotations.");

            Log.Comment("Adding collection annotations...");
            var annotations = hostElement.Elements();
            hostElement.AddAnnotation(annotations);

            Log.Comment("Retrieving annotations...");
            var result = hostElement.Annotation(annotations.GetType());
            if (annotations == result)
                Log.Pass("Annotation retrieved is exactly same one as added.");
            else
                Log.Fail("Annotation retrieved is different from the one added.");

            Log.Comment("Retrieving annotations...");
            results = hostElement.Annotations(annotations.GetType());
            Log.VerifyValue(results.Count(), 1, "Annotations count differs from expected vlaue: ONE.");
            if (results.First() == result)
                Log.Pass("Annotation retrieved is exactly same one as added.");
            else
                Log.Fail("Annotation retrieved is different from the one added.");

            Log.Comment("Removing annotations for cleanup...");
            hostElement.RemoveAnnotations(annotations.GetType());
            results = hostElement.Annotations(annotations.GetType());
            if (null == results || results.Count() == 0)
                Log.Pass("Removed all annotations.");
        }

        #endregion Annotation

        #region VerifyResult ...

        /// <summary>
        /// verify if the specified element has no child element.
        /// </summary>
        /// <param name="targetElement">the element to be checked</param>
        internal void VerifyNoChildren(XElement targetElement)
        {
            if (targetElement == null)
                throw new ArgumentNullException("targetElement");

            Log.Comment("check if the current element has no children");
            Log.VerifyFalse(targetElement.HasElements, "Not all children are removed");
        }

        /// <summary>
        /// verify if <paramref name="originalElement"/> euqals to <paramref name="resultElement"/>'s child at <paramref name="targetPosition"/>.
        /// </summary>
        /// <param name="resultElement">the element after modifying</param>
        /// <param name="originalElement">the element before modifying</param>
        /// <param name="targetPosition">If null, compare these two elements. Otherwise, compare the originalElement with resultElement's targetPosition-th child</param>
        internal void VerifyEqual(XElement resultElement, XElement originalElement, int? childPosition)
        {

            if (resultElement == null || originalElement == null)
                throw new ArgumentNullException("one of the arguments passed in is NULL");

            if (childPosition.HasValue && (childPosition.Value < 0 || childPosition.Value >= resultElement.Elements().Count()))
                throw new IndexOutOfRangeException("the child position is out of range");


            XElement targetElement = null;

            if (childPosition != null)
            {
                Log.Comment("retrieve the child element of resultElement at position {0} to compare with originalElement", childPosition);
                targetElement = resultElement.Elements().ElementAt(childPosition.Value);
            }
            else
            {
                Log.Comment("Compare the resultElement with the originalElement");
                targetElement = resultElement;
            }

            Log.VerifyTrue(targetElement.Compare(originalElement), "Two elements are not same");

        }

        internal void VerifyEqual(XElement Xelement, OpenXmlElement Oelement, OpenXmlPart part)
        {
            VerifyEqual(Xelement, ConvertToXElement(part, Oelement), null);
        }

        internal void VerifyEqual<T>(IEnumerable<XElement> XElement, IEnumerable<T> OElement, OpenXmlPart part) where T : OpenXmlElement
        {
            if (XElement == null || OElement == null)
                throw new ArgumentNullException("one of the arguments passed in is NULL");

            bool pass = true;

            if (XElement.Count() != OElement.Count())
            {
                Log.Fail("Two List of elements have different count");
                pass = false;
            }
            else if (XElement.Count() == 0)
                Log.Warning("0 element is encounted");

            if (pass)
            {
                for (int i = 0; i < OElement.Count(); i++)
                {
                    if (!XElement.ElementAt(i).Compare(ConvertToXElement(part, OElement.ElementAt(i))))
                    {
                        Log.Fail("the Elements at position {0} are different", i);
                        pass = false;
                        break;
                    }
                }
            }

            if (pass)
                Log.Pass("the two list of elements are the same");
        }

        /// <summary>
        /// verify if an element is removed successfully
        /// </summary>
        /// <param name="resultElement">the element after child is removed</param>
        /// <param name="originalElement">the element before child is removed</param>
        /// <param name="targetPosition">the original position of the removed child</param>
        internal void VerifyRemove(XElement resultElement, XElement originalElement, int childPosition)
        {
            if (resultElement == null || originalElement == null)
                throw new ArgumentNullException("resultElement|originalElement");

            if (childPosition < 0 || childPosition >= originalElement.Elements().Count())
                throw new IndexOutOfRangeException("the child position is out of range");

            Log.Comment("check if the targetElement's children is decreased by 1");
            Log.VerifyTrue(originalElement.Elements().Count() == resultElement.Elements().Count() + 1, "the target's children is not decreased by 1");

            Log.Comment("check if all other child elements are matched, except the removed one");

            for (int i = 0; i < childPosition; i++)
            {
                Log.Comment("check child elements at position {0}", i);
                Log.VerifyTrue(resultElement.Elements().ElementAt(i).Compare(originalElement.Elements().ElementAt(i)),
                                "the child elements at position {0} are not same", i);
            }

            if (childPosition < resultElement.Elements().Count())
            {
                for (int i = childPosition; i < resultElement.Elements().Count(); i++)
                {
                    Log.Comment("check child elements at position {0}", i);
                    Log.VerifyTrue(resultElement.Elements().ElementAt(i).Compare(originalElement.Elements().ElementAt(i + 1)),
                                   "the child elements at position {0} are not same", i);
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
            if (resultElement == null || originalElement == null)
                throw new ArgumentNullException("resultElement|originalElement");
            if (childrenPosition == null)
                throw new ArgumentNullException("childrenPosition");

            if (childrenPosition.Min() < 0 || childrenPosition.Max() >= originalElement.Elements().Count())
                throw new IndexOutOfRangeException("Child position is out of range");

            Log.Comment("check if the targetElement's children is decreased as expected");
            Log.VerifyTrue(originalElement.Elements().Count() == resultElement.Elements().Count() + childrenPosition.Count(),
                "Target's children is not decreased as expected.");

            Log.Comment("check if all other child elements are matched, except the removed one");
            for (int i = 0; i < originalElement.Elements().Count(); i++)
            {
                if (childrenPosition.Contains(i))
                    continue;

                int expectPos = i - childrenPosition.Count(j => j < i);
                Log.Comment("Verifying child element at position ({0}:{1})...", i, expectPos);
                Log.VerifyTrue(resultElement.Elements().ElementAt(expectPos).Compare(originalElement.Elements().ElementAt(i)),
                    "Child element at position ({0}:{1}) is NOT same.", i, expectPos);
            }
        }
        #endregion

    }
}


/// <summary>
/// XElement Extension Class
/// </summary>
internal static class XElementExtension
{
    /// <summary>
    /// extension method to compare two XElements contains the same structures, ignoring Namespace declaration
    /// </summary>
    /// <param name="A">the base XElement</param>
    /// <param name="B">the target XElement</param>
    /// <returns>TRUE, if two elements are the same. FALSE, if they are not the same</returns>
    internal static bool Compare(this XElement A, XElement B)
    {
        //Verify NameSpace
        if (A.Name.Namespace != B.Name.Namespace || A.Name.LocalName != B.Name.LocalName)
            return false;

        //Verify Values
        if (A.Value != B.Value)
            return false;

        //verify attributes
        if (B.Attributes().Count(x => x.IsNamespaceDeclaration == false) != A.Attributes().Count(x => x.IsNamespaceDeclaration == false))
            return false;

        foreach (XAttribute attr in A.Attributes().Where(x => x.IsNamespaceDeclaration == false))
        {

            if (B.Attribute(attr.Name) == null || B.Attribute(attr.Name).Value != attr.Value)
                return false;
        }

        //verify Child Elements
        if (A.HasElements != B.HasElements)
            return false;

        if (A.HasElements)
        {
            if (A.Elements().Count() != B.Elements().Count())
                return false;

            for (int i = 0; i < A.Elements().Count(); i++)
            {
                if (!A.Elements().ElementAt(i).Compare(B.Elements().ElementAt(i)))
                    return false;
            }
        }

        return true;
    }

}