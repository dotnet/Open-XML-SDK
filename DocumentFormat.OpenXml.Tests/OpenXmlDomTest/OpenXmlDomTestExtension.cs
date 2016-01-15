// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Collections;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.AdditionalCharacteristics;
using DocumentFormat.OpenXml.Validation;
using OxTest;

namespace DocumentFormat.OpenXml.Tests
{

    /// <summary>Extension Class for OpenXml Testing.</summary>
    internal static class OpenXmlDomTestExtension
    {
        #region FileInfo Extensions
        private static string[] _wordprocessingExtension = new string[] { ".docx", ".docm", ".dotx", ".dotm" };
        private static string[] _spreadsheetExtension = new string[] { ".xlam", ".xltm", ".xlsm", ".xltx", ".xlsx" };
        private static string[] _presentationExtension = new string[] { ".ppam", ".pptm", ".ppsm", ".potm", ".pptx", ".ppsx", ".potx" };

        /// <summary> Check if the file is of OpenXml package extension.</summary>
        /// <param name="file">current file</param>
        /// <returns>True if it's with OpenXml package extension, otherwise return false.</returns>
        public static bool IsOpenXmlFile(this FileInfo file)
        {
            return _wordprocessingExtension.Contains(file.Extension.ToLower())
                || _spreadsheetExtension.Contains(file.Extension.ToLower())
                || _presentationExtension.Contains(file.Extension.ToLower());
        }

        /// <summary> Check if the file is of OpenXml Wordprocessing document extension.</summary>
        /// <param name="file">current file</param>
        /// <returns>True if it's with OpenXml Wordprocessing document extension, otherwise return false.</returns>
        public static bool IsWordprocessingFile(this FileInfo file)
        {
            return _wordprocessingExtension.Contains(file.Extension.ToLower());
        }

        /// <summary> Check if the file is of OpenXml Speadsheet document extension.</summary>
        /// <param name="file">current file</param>
        /// <returns>True if it's with OpenXml Speadsheet document extension, otherwise return false.</returns>
        public static bool IsSpreadsheetFile(this FileInfo file)
        {
            return _spreadsheetExtension.Contains(file.Extension.ToLower());
        }

        /// <summary> Check if the file is of OpenXml Presentation document extension.</summary>
        /// <param name="file">current file</param>
        /// <returns>True if it's with OpenXml Presentation document extension, otherwise return false.</returns>
        public static bool IsPresentationFile(this FileInfo file)
        {
            return _presentationExtension.Contains(file.Extension.ToLower());
        }

        /// <summary> Get a copy of pass in file </summary>
        /// <param name="file">File to be copied</param>
        /// <returns>Copy of pass in file</returns>
        public static FileInfo GetCopy(this FileInfo file)
        {
            if (!file.Exists)
                throw new FileNotFoundException(string.Format("Specified file {0} does not exist.", file.Name));

            string copy = System.IO.Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".docx");
            file.CopyTo(copy, true);
            return new FileInfo(copy);
        }

        /// <summary>
        /// Open specified existing OpenXmlPackage.
        /// </summary>
        /// <param name="file">File to be opened</param>
        /// <param name="writable">Open package in read/write mode if true, false for readonly.</param>
        /// <returns>OpenXmlPackage instance for opened package</returns>
        public static OpenXmlPackage OpenPackage(this FileInfo file, bool writable)
        {
            if (!file.Exists)
                throw new FileNotFoundException(string.Format("Specified file {0} does not exist.", file.Name));

            string ext = file.Extension.ToLower();
            OpenXmlPackage srcPackage = null;

            if (_wordprocessingExtension.Contains(ext))
            {
                return srcPackage = WordprocessingDocument.Open(file.FullName, writable);
            }
            else if (_spreadsheetExtension.Contains(ext))
            {
                return srcPackage = SpreadsheetDocument.Open(file.FullName, writable);
            }
            else if (_presentationExtension.Contains(ext))
            {
                return srcPackage = PresentationDocument.Open(file.FullName, writable);
            }
            else
                throw new Exception("Not Supported Document Type!");
        }

        /// <summary>
        /// Open specified exsting package.
        /// </summary>
        /// <param name="file">File to be opened.</param>
        /// <param name="writable">Open package in read/write mode if true, false for readonly.</param>
        /// <param name="autosave">Save changes automatically when closing package.</param>
        /// <returns>OpenXmlPackage instance for opened package</returns>
        public static OpenXmlPackage OpenPackage(this FileInfo file, bool writable, bool autosave)
        {
            if (!file.Exists)
                throw new FileNotFoundException(string.Format("Specified file {0} does not exist.", file.Name));

            string ext = file.Extension.ToLower();
            OpenXmlPackage srcPackage = null;
            if (_wordprocessingExtension.Contains(ext))
            {
                return srcPackage = WordprocessingDocument.Open(file.FullName, writable, new OpenSettings() { AutoSave = autosave });
            }
            else if (_spreadsheetExtension.Contains(ext))
            {
                return srcPackage = SpreadsheetDocument.Open(file.FullName, writable, new OpenSettings() { AutoSave = autosave });
            }
            else if (_presentationExtension.Contains(ext))
            {
                return srcPackage = PresentationDocument.Open(file.FullName, writable, new OpenSettings() { AutoSave = autosave });
            }
            else
                throw new Exception("Not Supported Document Type!");
        }

        /// <summary>
        /// Open specified existing package.
        /// </summary>
        /// <param name="file">File to be opened.</param>
        /// <param name="writable">Open package in read/write mode if true, false for readonly.</param>
        /// <returns>OpenXmlPackage instance for opened package.</returns>
        public static OpenXmlPackage OpenPackage(this FileInfo file, bool writable, FileFormatVersions format, MarkupCompatibilityProcessMode mcProcessMode)
        {
            OpenSettings settings = new OpenSettings();
            settings.MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(mcProcessMode, format);
            return OpenPackage(file, writable, settings);
        }

        /// <summary>
        /// Open specified existing package.
        /// </summary>
        /// <param name="file">File to be opened.</param>
        /// <param name="writable">Open package in read/write mode if true, false for readonly.</param>
        /// <param name="settings">Settings on AutoSave, MaxCharactersInPart, MarkupCompatibilityProcessSettings and ProcessMCInWholePackage.</param>
        /// <returns>OpenXmlPackage instance for opened package.</returns>
        public static OpenXmlPackage OpenPackage(this FileInfo file, bool writable, OpenSettings settings)
        {
            if (!file.Exists)
                throw new FileNotFoundException(string.Format("Specified file {0} does not exist.", file.Name));

            string ext = file.Extension.ToLower();
            OpenXmlPackage srcPackage = null;
            if (_wordprocessingExtension.Contains(ext))
            {
                return srcPackage = WordprocessingDocument.Open(file.FullName, writable, settings);
            }
            else if (_spreadsheetExtension.Contains(ext))
            {
                return srcPackage = SpreadsheetDocument.Open(file.FullName, writable, settings);
            }
            else if (_presentationExtension.Contains(ext))
            {
                return srcPackage = PresentationDocument.Open(file.FullName, writable, settings);
            }
            else
                throw new Exception("Not Supported Document Type!");
        }

        public static OpenXmlPackage CreatePackage(this FileInfo file, Boolean overwiteIfExist)
        {
            if (file.Exists)
            {
                throw new InvalidOperationException(String.Format("The file {0} exists!!", file.FullName));
            }

            string ext = file.Extension.ToLower();
            OpenXmlPackage srcPackage = null;
            if (_wordprocessingExtension.Contains(ext))
            {
                return srcPackage = WordprocessingDocument.Create(file.FullName, WordprocessingDocumentType.Document);
            }
            else if (_spreadsheetExtension.Contains(ext))
            {
                return srcPackage = SpreadsheetDocument.Create(file.FullName, SpreadsheetDocumentType.Workbook);
            }
            else if (_presentationExtension.Contains(ext))
            {
                return srcPackage = PresentationDocument.Create(file.FullName, PresentationDocumentType.Presentation);
            }
            else
                throw new Exception("Not Supported Document Type!");



        }

        public static void CreateIfNotExist(this DirectoryInfo dir)
        {
            if (dir == null)
                throw new ArgumentNullException();

            if (!dir.Exists)
            {
                dir.Parent.CreateIfNotExist();
                dir.Create();
            }
        }
        #endregion FileInfo Extensions

        #region Package Extensions

        /// <summary>
        /// Get Main Part of current package
        /// </summary>
        /// <param name="package">current package</param>
        /// <returns>Return main part of current package, null if not exist.</returns>
        public static OpenXmlPart MainPart(this OpenXmlPackage package)
        {
            if (null == package)
                throw new ArgumentNullException("package");

            if (package is WordprocessingDocument)
                return (package as WordprocessingDocument).MainDocumentPart;
            else if (package is SpreadsheetDocument)
                return (package as SpreadsheetDocument).WorkbookPart;
            else if (package is PresentationDocument)
                return (package as PresentationDocument).PresentationPart;
            else
                return null;
        }

        /// <summary>
        /// Get Non-Main Part of current package
        /// </summary>
        /// <param name="package">current package</param>
        /// <returns>Return non-main part of current package, null if not exist.</returns>
        public static IEnumerable<OpenXmlPart> NonMainParts(this OpenXmlPackage package)
        {
            return package.DescendantParts()
                .Where(p => p.IsReflectable() && !p.IsMainPart());
        }

        /// <summary>
        /// Get All Parts of the specified package/part in depth-first pre-order.
        /// </summary>
        /// <param name="root">package or part which can contain parts.</param>
        /// <returns>IEnumerable<OpenXmlPart> of parts in the pass-in <paramref name="root"/>.</returns>
        public static IEnumerable<OpenXmlPart> DescendantParts(this OpenXmlPartContainer root)
        {
            if (null == root)
                throw new ArgumentNullException("root");

            IList<OpenXmlPart> parts = new List<OpenXmlPart>();
            List<string> uriList = new List<string>();
            addChildParts(parts, uriList, root);
            return parts;
        }

        public static IEnumerable<IdPartPair> DescendantIdPartPairs(this OpenXmlPartContainer root)
        {
            if (null == root)
                throw new ArgumentException("root");

            IList<IdPartPair> idPartPairs = new List<IdPartPair>();
            addChildIdPartPairs(idPartPairs, root);
            return idPartPairs;
        }

        /// <summary>
        /// Compare two OpenXmlPackages
        /// </summary>
        /// <param name="sourcePackage">the source package for comparison</param>
        /// <param name="targetPackage">the target package for comparison</param>
        /// <returns>TRUE, if two packages contains the same contents. FALSE, if not</returns>
        public static Boolean Compare(this OpenXmlPackage sourcePackage, OpenXmlPackage targetPackage)
        {
            //if two packages have the same reference, return true
            if (sourcePackage == targetPackage)
                return true;

            // if only one of the them is null, return false
            if ((targetPackage == null && sourcePackage != null) || (sourcePackage == null && targetPackage != null))
                return false;

            // if they contains different number of externalrelationships, return false
            if (sourcePackage.ExternalRelationships.Count() != targetPackage.ExternalRelationships.Count())
                return false;

            // if they contains different number of hyperlinkrelationships, return false
            if (sourcePackage.HyperlinkRelationships.Count() != targetPackage.HyperlinkRelationships.Count())
                return false;

            // if they contains different number of parts, return false
            if (sourcePackage.Parts.Count() != targetPackage.Parts.Count())
                return false;

            // if they contains different number of descendent parts, return false
            if (sourcePackage.DescendantParts().Count() != targetPackage.DescendantParts().Count())
                return false;

            // compare each extenalrelationship
            foreach (var id in sourcePackage.ExternalRelationships)
            {
                if (targetPackage.ExternalRelationships.Where(i => i.Id == id.Id && i.RelationshipType == id.RelationshipType && i.Uri == id.Uri).Count() != 1)
                    return false;
            }
            //compare each hyperlinkrelationship
            foreach (var id in sourcePackage.HyperlinkRelationships)
            {
                if (targetPackage.HyperlinkRelationships.Where(i => i.Id == id.Id && i.IsExternal == id.IsExternal && i.Uri == id.Uri).Count() != 1)
                    return false;
            }

            // compare each parts contains in the package
            foreach (var part in sourcePackage.Parts)
            {
                if (part.OpenXmlPart.IsMainPart())
                {
                    if (!part.OpenXmlPart.Compare(targetPackage.Parts.Single(p => p.OpenXmlPart is MainDocumentPart || p.OpenXmlPart is WorkbookPart || p.OpenXmlPart is PresentationPart).OpenXmlPart))
                        return false;
                }
                else if (part.OpenXmlPart is CoreFilePropertiesPart)
                {
                    var sourcePackPr = sourcePackage.PackageProperties;
                    var targetPackPr = targetPackage.PackageProperties;

                    if (sourcePackPr.Category != targetPackPr.Category)
                        return false;

                    if (sourcePackPr.ContentStatus != targetPackPr.ContentStatus)
                        return false;

                    if (sourcePackPr.ContentType != targetPackPr.ContentType)
                        return false;

                    if (sourcePackPr.Created.HasValue && sourcePackPr.Created.Value.CompareTo(targetPackPr.Created.Value) != 0)
                        return false;

                    if(sourcePackPr.Creator != targetPackPr.Creator)
                    return false;

                    if (sourcePackPr.Description != targetPackPr.Description)
                        return false;

                    if (sourcePackPr.Identifier != targetPackPr.Identifier)
                        return false;

                    if (sourcePackPr.Keywords != targetPackPr.Keywords)
                        return false;

                    if (sourcePackPr.Language != targetPackPr.Language)
                        return false;

                    if (sourcePackPr.LastModifiedBy != targetPackPr.LastModifiedBy)
                        return false;

                    if (sourcePackPr.LastPrinted.HasValue && sourcePackPr.LastPrinted.Value.CompareTo(targetPackPr.LastPrinted.Value) != 0)
                        return false;

                    if (sourcePackPr.Modified.HasValue && sourcePackPr.Modified.Value.CompareTo(targetPackPr.Modified.Value) != 0)
                        return false;

                    if (sourcePackPr.Revision != targetPackPr.Revision)
                        return false;

                    if (sourcePackPr.Subject != targetPackPr.Subject)
                        return false;

                    if (sourcePackPr.Title != targetPackPr.Title)
                        return false;

                    if (sourcePackPr.Version != targetPackPr.Version)
                        return false;
                }
                else if (!part.OpenXmlPart.Compare(targetPackage.Parts.Single(p => p.RelationshipId == part.RelationshipId).OpenXmlPart))
                    return false;
            }
            return true;
        }

        #endregion Package Extensions


        #region Part Extensions

        /// <summary>
        /// Check if current <paramref name="part"/> is main part of the package.
        /// </summary>
        /// <param name="part">Current Part</param>
        /// <returns>Return true if <paramref name="part"/> is main part of the package.</returns>

        public static bool IsMainPart(this OpenXmlPartContainer part)
        {
            if (part is MainDocumentPart || part is WorkbookPart || part is PresentationPart)
                return true;
            return false;
        }

        public static Boolean IsBibliographyPart(this OpenXmlPart part)
        {
            if (part is CustomXmlPart)
            {
                XElement PartRoot = null;
                using (var stream = part.GetStream())
                using (var reader = XmlReader.Create(stream))
                    PartRoot = XElement.Load(reader);

                if (PartRoot.Name.LocalName == "Sources")
                    return true;
            }
            return false;
        }

        public static Boolean IsAdditionalCharacteristicsPart(this OpenXmlPart part)
        {
            if (part is CustomXmlPart)
            {
                XElement PartRoot = null;
                using (var stream = part.GetStream())
                using (var reader = XmlReader.Create(stream))
                    PartRoot = XElement.Load(reader);

                if (PartRoot.Name.LocalName == "additionalCharacteristics")
                    return true;
            }
            return false;
        }

        public static Boolean IsInkPart(this OpenXmlPart part)
        {
            if (part is CustomXmlPart)
            {
                XElement PartRoot = null;
                using (var stream = part.GetStream())
                using (var reader = XmlReader.Create(stream))
                    PartRoot = XElement.Load(reader);

                if (PartRoot.Name.LocalName == "ink")
                    return true;
            }
            return false;


        }
        private static void addChildParts(IList<OpenXmlPart> list, List<string> uriList, OpenXmlPartContainer root)
        {
            foreach (var ip in root.Parts)
            {
                if (!uriList.Contains(ip.OpenXmlPart.Uri.ToString()))
                {
                    list.Add(ip.OpenXmlPart);
                    uriList.Add(ip.OpenXmlPart.Uri.ToString());
                    addChildParts(list, uriList, ip.OpenXmlPart);
                }
            }
        }

        private static void addChildIdPartPairs(IList<IdPartPair> list, OpenXmlPartContainer root)
        {
            foreach (var idPartPair in root.Parts)
            {
                if (list.Where(i => i.RelationshipId == idPartPair.RelationshipId && object.ReferenceEquals(i.OpenXmlPart, idPartPair.OpenXmlPart)).Count() == 0)
                {
                    list.Add(idPartPair);
                    addChildIdPartPairs(list, idPartPair.OpenXmlPart);
                }
            }
        }

        /// <summary>
        /// Check if current part is reflectable (with xml content).
        /// </summary>
        /// <param name="part">Current part</param>
        /// <returns>return true if it has non-null root element, otherwise rturn false.</returns>
        public static bool IsReflectable(this OpenXmlPart part)
        {
            if (null == part)
                throw new ArgumentNullException("part");

            if (part.IsBibliographyPart() || part.IsAdditionalCharacteristicsPart() || part.IsInkPart())
            {
                return true;
            }

            var flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.FlattenHierarchy;
            var property = part.GetType().GetProperties(flag)
                .Where(p => p.PropertyType.IsSubclassOf(typeof(OpenXmlPartRootElement)))
                .FirstOrDefault();
            return null != property;
        }

        /// <summary>
        /// Get RootElement of the current part.
        /// </summary>
        /// <param name="part">Current Part</param>
        /// <returns>Return Root element of the pass-in part</returns>
        public static OpenXmlPartRootElement RootElement(this OpenXmlPart part)
        {
            if (null == part)
                throw new ArgumentNullException("part");

            if (part is CustomXmlPart)
            {
                XmlDocument xmlDoc = new XmlDocument();
                using (var stream = part.GetStream())
                    xmlDoc.Load(stream);
                if (part.IsBibliographyPart())
                    return new Sources(xmlDoc.DocumentElement.OuterXml);

                else if (part.IsInkPart())
                {
                    return new DocumentFormat.OpenXml.InkML.Ink(xmlDoc.DocumentElement.OuterXml);

                }
            }

            var flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.FlattenHierarchy;
            var properties = part.GetType().GetProperties(flag)
                .Where(p => p.PropertyType.IsSubclassOf(typeof(OpenXmlPartRootElement)));

            return null == properties.FirstOrDefault() ?
                null : properties.First().GetValue(part, null) as OpenXmlPartRootElement;
        }

        /// <summary>
        /// compare two OpenXmlParts
        /// </summary>
        /// <param name="sourcePart">the soruce part for comparison</param>
        /// <param name="targetPart">the target part for comparison</param>
        /// <returns>TRUE, if two parts contains the same content. FALSE, if not</returns>
        public static Boolean Compare(this OpenXmlPart sourcePart, OpenXmlPart targetPart)
        {
                HashSet<Uri> ComparedParts = new HashSet<Uri>();

                return sourcePart.CompareDescendentsAndSelf(targetPart, ComparedParts);
        }

        private static Boolean CompareDescendentsAndSelf(this OpenXmlPart sourcePart, OpenXmlPart targetPart, HashSet<Uri> ComparedPart)
        {
            #region compare content of two parts
            // if two parts have the same reference, return true;
            if (sourcePart == targetPart)
                return true;
            // if there is only one part is null, return false
            if ((targetPart == null && sourcePart != null) || (sourcePart == null && targetPart != null))
                return false;
            //if two parts have different contenttype, return false
            if (sourcePart.ContentType != targetPart.ContentType)
                return false;
            //if two parts have different number of externalrelationships, return false
            if (sourcePart.ExternalRelationships.Count() != targetPart.ExternalRelationships.Count())
                return false;
            // if two parts have different number of hyperlinkrelationships, return false
            if (sourcePart.HyperlinkRelationships.Count() != targetPart.HyperlinkRelationships.Count())
                return false;
            // if two parts have diffent relationship type, return false
            if (sourcePart.RelationshipType != targetPart.RelationshipType)
                return false;
            //// if two parts have different URI, return false
            //if (sourcePart.Uri != targetPart.Uri)
            //    return false;
            // if two parts contains different number of parts, return false;
            if (sourcePart.Parts.Count() != targetPart.Parts.Count())
                return false;
            //compare each externalrelationship
            foreach (var id in sourcePart.ExternalRelationships)
            {
                if (targetPart.ExternalRelationships.Where(i => i.Id == id.Id && i.RelationshipType == id.RelationshipType && i.Uri == id.Uri).Count() != 1)
                    return false;
            }
            //compare each hyperlinkrelationship
            foreach (var id in sourcePart.HyperlinkRelationships)
            {
                if (targetPart.HyperlinkRelationships.Where(i => i.Id == id.Id && i.IsExternal == id.IsExternal && i.Uri == id.Uri).Count() != 1)
                    return false;
            }

            if (sourcePart.RootElement == null)
            {
                // if the part is binary part, compare binary
                bool xmlCompareSuccess = false;
                using (var sourceStm = sourcePart.GetStream())
                using (var targetStm = targetPart.GetStream())
                {
                    try
                    {
                        var xsource = XElement.Load(XmlReader.Create(sourceStm));
                        var xtarget = XElement.Load(XmlReader.Create(targetStm));

                        if (xsource.Compare(xtarget) == false)
                            return false;
                        xmlCompareSuccess = true;
                    }
                    catch (XmlException)
                    {
                        xmlCompareSuccess = false;
                    }
                }
                // else need to do binary compare
                if (!xmlCompareSuccess)
                {
                    using (var sourceStm = sourcePart.GetStream())
                    using (var targetStm = targetPart.GetStream())
                    {
                        if (sourceStm.Length != targetStm.Length)
                            return false;

                        int i; int j;

                        do
                        {
                            i = sourceStm.ReadByte();
                            j = targetStm.ReadByte();
                            if (i != j) return false;

                        } while (i != -1 && j != -1);
                    }
                }
            }
            else
            {
                // if the part contains OpenXml Elements, compare their root elements
                if (sourcePart.RootElement.ToXElement().Compare(targetPart.RootElement.ToXElement()) == false)
                    return false;
            }
            #endregion

            ComparedPart.Add(sourcePart.Uri);

            foreach (var part in sourcePart.Parts)
            {
                if (!ComparedPart.Contains(part.OpenXmlPart.Uri))
                {
                    if (part.OpenXmlPart.CompareDescendentsAndSelf(targetPart.Parts.Single(p => p.RelationshipId == part.RelationshipId).OpenXmlPart, ComparedPart) == false)
                        return false;
                }
            }
            return true;
        }

        #endregion Part Extensions

        #region Element Extensions
        /// <summary>
        /// Get hosting part of current root element
        /// </summary>
        /// <param name="root">root element</param>
        /// <returns>hosting part</returns>
        public static OpenXmlPart HostPart(this OpenXmlPartRootElement root)
        {
            if (null == root)
                throw new ArgumentNullException("root");

            var flag = BindingFlags.FlattenHierarchy | BindingFlags.Public | BindingFlags.Instance;
            var properties = root.GetType().GetProperties(flag)
                .Where(p => p.PropertyType.IsSubclassOf(typeof(OpenXmlPart)));

            return null == properties.FirstOrDefault() ?
                null : properties.First().GetValue(root, null) as OpenXmlPart;
        }

        /// <summary>
        /// Get PartRootElement of current element
        /// </summary>
        /// <param name="element">current element</param>
        /// <returns>Part root element of current elemen, null if root element is not of OpenXmlPartRootElement.</returns>
        public static OpenXmlPartRootElement PartRootElement(this OpenXmlElement element)
        {
            if (null == element)
                throw new ArgumentNullException("element");

            if (element is OpenXmlPartRootElement)
                return element as OpenXmlPartRootElement;

            return element.Ancestors<OpenXmlPartRootElement>().FirstOrDefault();
        }

        /// <summary>
        /// Get index of specified element in the ChildElement of parent element.
        /// </summary>
        /// <param name="element">element in question</param>
        /// <returns>index of pass-in element, 0 for root/orphan element</returns>
        public static int Index(this OpenXmlElement element)
        {
            if (null == element)
                throw new ArgumentNullException("element");

            if (element.Parent == null)   // root/orphan element itself
                return 0;

            return element.Parent.ChildElements.TakeWhile(c => element != c).Count();
        }

        /// <summary>
        /// Get path to specified element.
        /// </summary>
        /// <param name="element">element in question</param>
        /// <returns>path to specified element</returns>
        public static string Path(this OpenXmlElement element)
        {
            if (null == element)
                throw new ArgumentNullException("element");

            string path = string.Format(@"/{0}@{1}", element.LocalName, element.Index());
            return element.Ancestors().Aggregate(path, (s, a) => string.Format(@"/{0}@{1}", a.LocalName, a.Index()) + s);
        }

        /// <summary>
        /// Get depth of specified element by counting ancestors.
        /// </summary>
        /// <param name="element">element in question</param>
        /// <returns>depth of pass-in element, 0 for root element.</returns>
        public static int Depth(this OpenXmlElement element)
        {
            if (null == element)
                throw new ArgumentNullException("element");

            return element.Ancestors().Count();
        }

        /// <summary>
        /// Get name of element in <w:p> fashion.
        /// </summary>
        /// <param name="element">element in question</param>
        /// <returns>name of element in <w:p> format</returns>
        public static string GetFullName(this OpenXmlElement element)
        {
            if (null == element)
                throw new ArgumentNullException("element");

            if (string.IsNullOrEmpty(element.Prefix))
                return element.LocalName;
            return string.Format("{0}:{1}", element.Prefix, element.LocalName);
        }

        /// <summary>
        /// Retrieve built-in OpenXmlAttributes of the type of pass-in OpenXmlElement 
        /// </summary>
        /// <param name="e">OpenXmlElement or derived classes that has properties with SchemaAttrAttribute</param>
        /// <returns>IEnumerable<OpenXmlAttribute> for fixed attributes of type of pass-in OpenXmlElement</returns>
        public static IEnumerable<OpenXmlAttribute> GetFixedAttributes(this OpenXmlElement e)
        {
            var flag = BindingFlags.FlattenHierarchy | BindingFlags.Instance | BindingFlags.Public;
            var properties = e.GetType().GetProperties(flag)
                .Where(p => p.GetCustomAttributes(typeof(SchemaAttrAttribute), false).Length > 0);
            return properties
                .Select(p => p.GetCustomAttributes(typeof(SchemaAttrAttribute), false).First() as SchemaAttrAttribute)
                .Select(sa => new OpenXmlAttribute(sa.Tag, sa.NamespaceUri, null));
        }

        /// <summary>
        /// Get XName of pass-in OpenXmlElement.
        /// </summary>
        /// <param name="element">element in question</param>
        /// <returns>XName of pass-in OpenXmlElement</returns>
        public static XName GetXName(this OpenXmlElement element)
        {
            if (null == element)
                throw new ArgumentNullException("element");

            XNamespace xns = element.NamespaceUri;
            return xns + element.LocalName;
        }

        /// <summary>
        /// Convert an OpenXmlElement to an XElement using its OuterXml
        /// </summary>
        /// <param name="element">OpenXml element to be converted</param>
        /// <returns>XElement for specified OpenXmlElement</returns>
        public static XElement ToXElement(this OpenXmlElement element)
        {
            if (element == null)
                throw new ArgumentNullException("element");
            return XElement.Load(new StringReader(element.OuterXml));
        }

        public static XElement ToXElement(this OpenXmlElement element, OpenXmlPart part)
        {
            if (element == null)
                throw new ArgumentNullException("element");
            if (part == null)
                throw new ArgumentNullException("part");

            return XElement.Load(new StringReader(element.OuterXml));
        }

        public static void Save(this OpenXmlElement element, OpenXmlPart part)
        {
            if (element is OpenXmlPartRootElement)
            {
                (element as OpenXmlPartRootElement).Save();
            }
            else
            {
                XmlWriter partWriter = XmlWriter.Create(part.GetStream());
                element.WriteTo(partWriter);
                partWriter.Close();
            }
        }

        #endregion Element Extensions

        #region XElement Extension
        public static bool Compare(this XElement left, XElement right)
        {

            //Verify NameSpace
            if (left.Name.Namespace != right.Name.Namespace || left.Name.LocalName != right.Name.LocalName)
                return false;

            //Verify Values
            if (left.Value != right.Value)
                return false;

            //verify attributes
            if (right.Attributes().Count(x => x.IsNamespaceDeclaration == false) != left.Attributes().Count(x => x.IsNamespaceDeclaration == false))
                return false;

            foreach (XAttribute attr in left.Attributes().Where(x => x.IsNamespaceDeclaration == false))
            {
                if (right.Attribute(attr.Name) == null || !SpecialAttrValueCompare(attr, right.Attribute(attr.Name)))
                    return false;
            }

            //verify Child Elements
            if (left.HasElements != right.HasElements)
                return false;

            if (left.HasElements)
            {
                if (left.Elements().Count() != right.Elements().Count())
                    return false;

                for (int i = 0; i < left.Elements().Count(); i++)
                {
                    if (!left.Elements().ElementAt(i).Compare(right.Elements().ElementAt(i)))
                        return false;
                }
            }
            return true;
        }

        private static Boolean SpecialAttrValueCompare(XAttribute source, XAttribute target)
        {
            List<String> True = new List<string>() { "1", "TRUE", "ON", "T" };
            List<String> False = new List<string>() { "0", "FALSE", "OFF", "F" };

            Double src = 0;

            if (True.Contains(source.Value.ToUpper()) && True.Contains(target.Value.ToUpper()))
                return true;
            else if (False.Contains(source.Value.ToUpper()) && False.Contains(target.Value.ToUpper()))
                return true;
            else if (Double.TryParse(source.Value, out src))
            {
                Double tgt = Double.Parse(target.Value);
                if (Double.IsNaN(src) && Double.IsNaN(tgt))
                    return true;
                else if (src != tgt)
                    return false;
            }
            else if (source.Name.LocalName == "ole")
            {
                if (source.Value == "" && !(False.Contains(target.Value.ToUpper())) && !(target.Value == ""))
                    return false;
            }
            else if (source.Value + "Z" == target.Value)
                return true;
            else
            {
                return source.Value.Equals(target.Value, StringComparison.OrdinalIgnoreCase);
            }
            return true;
        }

        #endregion XElement Extension

        #region Extensions for Custom Attributes

        public static string GetQualifiedName(this Type hostType)
        {
            if (hostType == null)
                return string.Empty;
            return string.Format("{0}.{1}", hostType.Namespace, hostType.Name);
        }

        // Get concrete derived classes of OpenXmlElement class
        public static IEnumerable<Type> GetConcreteDerivesOfOpenXmlElement()
        {
            return Assembly.GetAssembly(typeof(OpenXmlElement)).GetTypes()
                .Where(t => !t.IsAbstract && t.IsSubclassOf(typeof(OpenXmlElement)));
        }

        // construct an instance of OpenXmlElement derives and return its XmlQualifiedName
        public static XmlQualifiedName GetElementTagName(this Type elementType)
        {
            if (elementType.IsAbstract || !elementType.IsSubclassOf(typeof(OpenXmlElement)))
                return null;

            var element = elementType.GetConstructor(Type.EmptyTypes).Invoke(null) as OpenXmlElement;
            if (null == element)
                return null;
            else
                return element.XmlQualifiedName;
        }

        // Get declared public instance properties of specified hosting hostType
        public static IEnumerable<PropertyInfo> GetDeclaredProperties(this Type hostType)
        {
            // if specified hostType is not derives of OpenXmlElement, just return null.
            if (!hostType.IsSubclassOf(typeof(OpenXmlElement)))
                return null;

            var flag = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public;
            return hostType.GetProperties(flag)
                .Where(pi => pi.DeclaringType != typeof(OpenXmlElement)
                    && pi.DeclaringType != typeof(OpenXmlCompositeElement)
                    && pi.DeclaringType != typeof(OpenXmlLeafElement));
        }

        public static IEnumerable<PropertyInfo> GetAttributeProperties(this Type hostType)
        {
            if (!hostType.IsSubclassOf(typeof(OpenXmlElement)))
                return null;

            var flag = BindingFlags.FlattenHierarchy | BindingFlags.Instance | BindingFlags.Public;
            return hostType.GetProperties(flag)
                .Where(pi => null != pi.GetSchemaAttribute());
        }

        public static OfficeAvailabilityAttribute GetOfficeAvailability(this Type hostType)
        {
            if (!hostType.IsSubclassOf(typeof(OpenXmlElement)))
                return null;

            return hostType.GetCustomAttributes(typeof(OfficeAvailabilityAttribute), true)
                .FirstOrDefault() as OfficeAvailabilityAttribute;
        }

        public static IEnumerable<ChildElementInfoAttribute> GetChildElementInfoAttributes(this Type type)
        {
            if (!type.IsSubclassOf(typeof(OpenXmlElement)))
                return null;

            return type.GetCustomAttributes(typeof(ChildElementInfoAttribute), true)
                .Cast<ChildElementInfoAttribute>();
        }

        public static IEnumerable<Type> GetChildElementTypes(this Type type)
        {
            if (!type.IsSubclassOf(typeof(OpenXmlElement)))
                return null;

            return type.GetCustomAttributes(typeof(ChildElementInfoAttribute), true)
                .Cast<ChildElementInfoAttribute>()
                .Select(cta => cta.ElementType);
        }

        public static IEnumerable<Type> GetParentElementTypes(this Type type)
        {
            if (!type.IsSubclassOf(typeof(OpenXmlElement)))
                return null;

            return type.Assembly.GetExportedTypes()
                .Where(et => !et.IsAbstract && et.IsSubclassOf(typeof(OpenXmlElement)) && et.GetChildElementTypes().Any(ct => ct == type));
        }

        public static SchemaAttrAttribute GetSchemaAttribute(this PropertyInfo propertyInfo)
        {
            return propertyInfo.GetCustomAttributes(typeof(SchemaAttrAttribute), true)
                .FirstOrDefault() as SchemaAttrAttribute;
        }

        public static OfficeAvailabilityAttribute GetOfficeAvailability(this PropertyInfo propertyInfo)
        {
            if (!propertyInfo.ReflectedType.IsSubclassOf(typeof(OpenXmlElement)))
                return null;

            return propertyInfo.GetCustomAttributes(typeof(OfficeAvailabilityAttribute), true)
                .FirstOrDefault() as OfficeAvailabilityAttribute;
        }

        public static IEnumerable<Type> GetEnumTypes()
        {
            return typeof(OpenXmlElement).Assembly.GetTypes().Where(t => t.IsEnum);
        }

        public static IEnumerable<FieldInfo> GetEnumStringFields(this Type enumType)
        {
            if (!enumType.IsEnum)
                return null;

            return enumType.GetFields()
                .Where(fi => fi.GetCustomAttributes(typeof(EnumStringAttribute), false).Length > 0);
        }

        public static EnumStringAttribute GetEnumString(this FieldInfo enumField)
        {
            return enumField.GetCustomAttributes(typeof(EnumStringAttribute), false)
                .FirstOrDefault() as EnumStringAttribute;
        }

        public static OfficeAvailabilityAttribute GetOfficeAvailability(this FieldInfo enumField)
        {
            if (!enumField.ReflectedType.IsEnum)
                return null;

            return enumField.GetCustomAttributes(typeof(OfficeAvailabilityAttribute), false)
                .FirstOrDefault() as OfficeAvailabilityAttribute;
        }

        public static bool IsInVersion(this Type hostType, FileFormatVersions version)
        {
            if (hostType.IsAbstract || !hostType.IsSubclassOf(typeof(OpenXmlElement)))
                return false;

            var oa = hostType.GetOfficeAvailability();
            if (oa == null || (oa.OfficeVersion & version) == version)
                return true;
            return false;
        }

        public static bool IsInVersion(this PropertyInfo propertyInfo, FileFormatVersions version)
        {
            var hostType = propertyInfo.ReflectedType;
            if (hostType.IsInVersion(version))
            {
                var oa = propertyInfo.GetOfficeAvailability();
                if (oa == null || (oa.OfficeVersion & version) == version)
                    return true;
            }
            return false;
        }

        #endregion Extensions for Custom Attributes

        #region Attribute Extensions
        /// <summary>
        /// Get XName of pass-in OpenXmlAttribute.
        /// </summary>
        /// <param name="attribute">attribute in question</param>
        /// <returns>XName of pass-in OpenXmlAttribute</returns>
        public static XName GetXName(this OpenXmlAttribute attribute)
        {
            if (null == attribute)
                throw new ArgumentNullException("attribute");

            XNamespace xns = attribute.NamespaceUri;
            return xns + attribute.LocalName;
        }

        /// <summary>
        /// Get name of attribute in <w:p> fashion.
        /// </summary>
        /// <param name="attribute">attribute in question</param>
        /// <returns>name of attribute in <w:p> format</returns>
        public static string GetFullName(this OpenXmlAttribute attribute)
        {
            if (null == attribute)
                throw new ArgumentNullException("attribute");

            if (string.IsNullOrEmpty(attribute.Prefix))
                return attribute.LocalName;
            return string.Format("{0}:{1}", attribute.Prefix, attribute.LocalName);
        }
        #endregion Attribute Extensions

        #region IEnumerable Extensions
        /// <summary>Pick the second element from source collection.  If only one, then return the first.</summary>
        /// <typeparam name="TSource">Type of collection content</typeparam>
        /// <param name="source">source collection</param>
        /// <returns>chosen element of source collection</returns>
        public static TSource PickSecond<TSource>(this IEnumerable<TSource> source)
        {
            var chosenElement = source.Skip(1).FirstOrDefault();
            if (chosenElement != null)
                return chosenElement;
            chosenElement = source.FirstOrDefault();
            return chosenElement;
            // This used to return a random element.  Bad idea for a test suite.
            //int index = new Random ().Next(source.Count());
            //return source.ElementAtOrDefault(index);
        }

        /// <summary> Pick an element from source collection randomly. </summary>
        /// <typeparam name="TSource">Type of collection content</typeparam>
        /// <param name="source">source collection</param>
        /// <param name="predicate">predicate on collection element</param>
        /// <returns>chosen element of source collection</returns>
        public static TSource PickFirst<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            return source.Where(predicate).FirstOrDefault();
        }

        /// <summary> Conduct specified action on each member of current collection. </summary>
        /// <typeparam name="TSource">Type of collection content</typeparam>
        /// <param name="source">source collection</param>
        /// <param name="action">action to be executed on the collection</param>
        public static void ForEach<TSource>(this IEnumerable<TSource> source, Action<TSource> action)
        {
            if (null == source)
                throw new ArgumentNullException("source");
            foreach (TSource s in source)
                action(s);
        }
        #endregion IEnumerable Extensions

        #region Event Extension
        /// <summary> Set event handler on pass-in element's OpenXmlElementContext.</summary>
        /// <param name="e">current element</param>
        /// <param name="handler">event handler to be hooked on</param>
        /// <returns>current element with event handlers hooked</returns>
        public static OpenXmlElement SetEventHandler(this OpenXmlElement e, Func<OpenXmlElement, OpenXmlElement> attachHandlerTo)
        {
            if (null == e) return e;

            return attachHandlerTo(e);
        }
        #endregion Event Extension

        #region MC Extensions

        public static OpenXmlElement SetIgnorable(this OpenXmlElement element, string prefix)
        {
            if (element == null)
                throw new ArgumentNullException("element");

            var mc = element.MCAttributes;
            if (mc == null)
                mc = new MarkupCompatibilityAttributes();
            if (mc.Ignorable == null)
                mc.Ignorable = prefix;
            else
                mc.Ignorable = string.Join(" ", new string[] { mc.Ignorable, prefix });
            element.MCAttributes = mc;
            return element;
        }

        public static OpenXmlElement SetMustUnderstand(this OpenXmlElement element, string prefix)
        {
            if (element == null)
                throw new ArgumentNullException("element");

            var mc = element.MCAttributes;
            if (mc == null)
                mc = new MarkupCompatibilityAttributes();
            if (mc.MustUnderstand == null)
                mc.MustUnderstand = prefix;
            else
                mc.MustUnderstand = string.Join(" ", new string[] { mc.MustUnderstand, prefix });
            element.MCAttributes = mc;
            return element;
        }

        public static OpenXmlElement SetPreserveAttributes(this OpenXmlElement element, string qualified)
        {
            if (element == null)
                throw new ArgumentNullException("element");

            var mc = element.MCAttributes;
            if (mc == null)
                mc = new MarkupCompatibilityAttributes();
            if (mc.PreserveAttributes == null)
                mc.PreserveAttributes = qualified;
            else
                mc.PreserveAttributes = string.Join(" ", new string[] { mc.PreserveAttributes, qualified });
            element.MCAttributes = mc;
            return element;
        }

        public static OpenXmlElement SetPreserveElements(this OpenXmlElement element, string qualified)
        {
            if (element == null)
                throw new ArgumentNullException("element");

            var mc = element.MCAttributes;
            if (mc == null)
                mc = new MarkupCompatibilityAttributes();
            if (mc.PreserveElements == null)
                mc.PreserveElements = qualified;
            else
                mc.PreserveElements = string.Join(" ", new string[] { mc.PreserveElements, qualified });
            element.MCAttributes = mc;
            return element;
        }

        public static OpenXmlElement SetProcessContent(this OpenXmlElement element, string qualified)
        {
            if (element == null)
                throw new ArgumentNullException("element");

            var mc = element.MCAttributes;
            if (mc == null)
                mc = new MarkupCompatibilityAttributes();
            if (mc.ProcessContent == null)
                mc.ProcessContent = qualified;
            else
                mc.ProcessContent = string.Join(" ", new string[] { mc.ProcessContent, qualified });
            element.MCAttributes = mc;
            return element;
        }

        public static AlternateContentChoice SetRequires(this AlternateContentChoice choice, string prefix)
        {
            if (choice == null)
                throw new ArgumentNullException("element");

            if (choice.Requires == null)
                choice.Requires = prefix;
            else
                choice.Requires = string.Join(" ", new string[] { choice.Requires, prefix });
            return choice;
        }

        #endregion MC Extensions

        #region ValidationErrorInfo

        public static string GetErrorString(this ValidationErrorInfo error, bool includeOuterXml)
        {
            if (error == null)
                throw new ArgumentNullException("error");

            StringBuilder message = new StringBuilder();
            message.AppendFormat("Type: {0}", error.ErrorType);
            message.AppendLine();
            message.AppendFormat("Id: {0}", error.Id);
            message.AppendLine();
            message.AppendFormat("Description: {0}", error.Description);
            message.AppendLine();
            message.AppendFormat("Path: {0}:{1}", error.Path.PartUri, error.Path.XPath);
            message.AppendLine();
            message.AppendFormat("RelatedNode: {0}:{1}",
                error.RelatedPart == null ? string.Empty : error.RelatedPart.Uri.ToString(),
                error.RelatedNode == null ? string.Empty : error.RelatedNode.Path());
            message.AppendLine();
            var pi = typeof(ValidationErrorInfo).GetProperty("SemanticConstraintId");
            string SemanticConstraintId = pi == null ? string.Empty : pi.GetValue(error, null) as string;
            message.AppendFormat("SemanticConstraintId: {0}", SemanticConstraintId);
            message.AppendLine();
            if (includeOuterXml)
            {
                message.AppendFormat("OuterXml: {0}", error.Node == null ? string.Empty : error.Node.OuterXml);
                message.AppendLine();
            }
            return message.ToString();
        }

        #endregion

        #region Extensions for Custom Attributes

        // Get declared public instance properties of specified hosting type
        public static IEnumerable<PropertyInfo> DeclaredProperties(this Type hostType)
        {
            // if specified type is not derives of OpenXmlElement, just return null.
            if (!hostType.IsSubclassOf(typeof(OpenXmlElement)))
                return null;

            var flag = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public;
            return hostType.GetProperties(flag)
                .Where(pi => pi.DeclaringType != typeof(OpenXmlElement)
                    && pi.DeclaringType != typeof(OpenXmlCompositeElement)
                    && pi.DeclaringType != typeof(OpenXmlLeafElement));
        }

        public static IEnumerable<PropertyInfo> getAttributeProperties(this Type hostType)
        {
            if (!hostType.IsSubclassOf(typeof(OpenXmlElement)))
                return null;

            var flag = BindingFlags.FlattenHierarchy | BindingFlags.Instance | BindingFlags.Public;
            return hostType.GetProperties(flag)
                .Where(pi => null != pi.getSchemaAttribute());
        }

        public static IEnumerable<ChildElementInfoAttribute> getChildElementTypeAttributes(this Type type)
        {
            if (!type.IsSubclassOf(typeof(OpenXmlElement)))
                return null;

            return type.GetCustomAttributes(typeof(ChildElementInfoAttribute), true)
                .Cast<ChildElementInfoAttribute>();
        }

        public static SchemaAttrAttribute getSchemaAttribute(this PropertyInfo propertyInfo)
        {
            return propertyInfo.GetCustomAttributes(typeof(SchemaAttrAttribute), true)
                .FirstOrDefault() as SchemaAttrAttribute;
        }

        public static IEnumerable<EnumStringAttribute> getEnumStrings(this Type enumType)
        {
            if (!enumType.IsEnum)
                return null;

            return enumType.GetFields()
                .Where(fi => fi.GetCustomAttributes(typeof(EnumStringAttribute), false).Length > 0)
                .SelectMany(fi => fi.GetCustomAttributes(typeof(EnumStringAttribute), true))
                .Cast<EnumStringAttribute>();
        }

        public static EnumStringAttribute getEnumString(this FieldInfo enumField)
        {
            return enumField.GetCustomAttributes(typeof(EnumStringAttribute), true)
                .FirstOrDefault() as EnumStringAttribute;
        }
        #endregion Extensions for Custom Attributes

    }
}