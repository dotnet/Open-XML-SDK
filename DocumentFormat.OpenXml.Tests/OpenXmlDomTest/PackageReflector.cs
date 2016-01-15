// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

using LogUtil;

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;

namespace DocumentFormat.OpenXml.Tests
{

    public class OpenXmlReflector
    {
        public static void Run(string srcDocument, string destDocument)
        {
            if (!File.Exists(srcDocument))
                throw new FileNotFoundException("Specified file does not exist.", srcDocument);

            using (OpenXmlPackage srcPackage = OpenExistingPackage(srcDocument))
            using (OpenXmlPackage destPackage = CreatePackageOn(srcPackage, destDocument))
            {
                (new OpenXmlReflector()).ReflectPackage(srcPackage, destPackage);
            }

        }

        #region Fields
        private OpenXmlPackage _srcPackage = null;
        public OpenXmlPackage SrcPackage
        {
            get
            {
                return _srcPackage;
            }
        }

        private OpenXmlPackage _destPackage = null;
        public OpenXmlPackage DestPackage
        {
            get
            {
                return _destPackage;
            }
        }

        private VerifiableLog _log;
        internal VerifiableLog Log
        {
            get
            {
                return _log;
            }
        }

        // File extensions for OpenXml documents
        private static string[] _wordprocessingExtension = new string[] { ".docx", ".docm", ".dotx", ".dotm" };
        private static string[] _spreadsheetExtension = new string[] { ".xlam", ".xltm", ".xlsm", ".xltx", ".xlsx" };
        private static string[] _presentationExtension = new string[] { ".ppam", ".pptm", ".ppsm", ".potm", ".pptx", ".ppsx", ".potx" };

        // Part-RootElement Map
        private Dictionary<Type, Type> _partRootElementMap = null;
        public Dictionary<Type, Type> PartRootElementMap
        {
            get
            {
                if (null == _partRootElementMap)
                    BuildPartRootElementMap();

                return _partRootElementMap;
            }
        }

        #endregion Fields

        #region Constructors
        public OpenXmlReflector()
        {
            _log = new VerifiableLog("OpenXmlPackageReflector", string.Empty, OxTest.TestUtil.TestResultsDirectory);
        }

        public OpenXmlReflector(string srcfile, string destfile)
        {
            _log = new VerifiableLog("OpenXmlPackageReflector", string.Empty, OxTest.TestUtil.TestResultsDirectory);

            _srcPackage = OpenExistingPackage(srcfile);
            _destPackage = CreatePackageOn(_srcPackage, destfile);
        }

        public OpenXmlReflector(string srcfile, string destfile, VerifiableLog log)
        {
            if (null != log) _log = log;

            _srcPackage = OpenExistingPackage(srcfile);
            _destPackage = CreatePackageOn(_srcPackage, destfile);
        }
        #endregion Constructors

        #region PackageOperations
        /// <summary>
        /// Open an existing OpenXmlPackage at specified location.
        /// </summary>
        /// <param name="file">the file to be opened</param>
        /// <param name="writable">Open package in read/write mode if true, false for readonly.</param>
        /// <returns>OpenXmlPackage instance</returns>
        public static OpenXmlPackage OpenExistingPackage(string filename, bool writable)
        {
            if (!File.Exists(filename))
                throw new FileNotFoundException("Specified file {0} does not exist.", filename);

            string ext = Path.GetExtension(filename);

            OpenXmlPackage srcPackage = null;

            if (_wordprocessingExtension.Contains(ext))
            {
                return srcPackage = WordprocessingDocument.Open(filename, writable);
            }
            else if (_spreadsheetExtension.Contains(ext))
            {
                return srcPackage = SpreadsheetDocument.Open(filename, writable);
            }
            else if (_presentationExtension.Contains(ext))
            {
                return srcPackage = PresentationDocument.Open(filename, writable);
            }
            else
                throw new Exception("Not Supported Document Type!");
        }

        public static OpenXmlPackage OpenExistingPackage(string filename)
        {
            return OpenExistingPackage(filename, false);
        }

        /// <summary>
        /// Create OpenXmlPackage with same type of source package.
        /// </summary>
        /// <param name="srcPackage">source package that has same type as new created package</param>
        /// <param name="destDocument">location of output package</param>
        /// <returns>New created OpenXmlPackage instance with same type of source package</returns>
        public static OpenXmlPackage CreatePackageOn(OpenXmlPackage srcPackage, string destDocument)
        {
            if (null == srcPackage)
                throw new ArgumentNullException("srcPackage");

            OpenXmlPackage destPackage = null;
            if (srcPackage is WordprocessingDocument)
            {
                return destPackage = WordprocessingDocument.Create(destDocument, (srcPackage as WordprocessingDocument).DocumentType);
            }
            else if (srcPackage is SpreadsheetDocument)
            {
                return destPackage = SpreadsheetDocument.Create(destDocument, (srcPackage as SpreadsheetDocument).DocumentType);
            }
            else if (srcPackage is PresentationDocument)
            {
                return destPackage = PresentationDocument.Create(destDocument, (srcPackage as PresentationDocument).DocumentType);
            }
            else
                throw new Exception("Not Supported Document Type!");
        }


        /// <summary>
        /// Build an in-memory Package instance of given type
        /// </summary>
        /// <param name="packageType"></param>
        /// <returns></returns>
        internal OpenXmlPackage BuildPackage(Type packageType)
        {
            OpenXmlPackage package = null;

            Stream stream = new MemoryStream();

            if (packageType == typeof(WordprocessingDocument))
            {
                package = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document);
            }
            else if (packageType == typeof(SpreadsheetDocument))
            {
                package = SpreadsheetDocument.Create(stream, SpreadsheetDocumentType.Workbook);
            }
            else if (packageType == typeof(PresentationDocument))
            {
                package = PresentationDocument.Create(stream, PresentationDocumentType.Presentation);
            }

            return package;
        }

        #endregion PackageOperations

        #region PartOperations
        /// <summary>
        /// Check if the pass-in type of part is reflectable or not by checking it's IFixedContentTypePart or main part of package.
        /// </summary>
        /// <param name="partType">type of part</param>
        /// <param name="parent">parent of part</param>
        /// <returns></returns>
        internal bool IsReflectablePart(Type partType, OpenXmlPartContainer parent)
        {
            if ((null != partType.GetInterface("IFixedContentTypePart"))
                && PartRootElementMap.ContainsKey(partType))
                return true;

            if (parent is WordprocessingDocument && partType == typeof(MainDocumentPart))
                return true;

            if (parent is SpreadsheetDocument && partType == typeof(WorkbookPart))
                return true;

            if (parent is PresentationDocument && partType == typeof(PresentationPart))
                return true;

            if (partType == typeof(FontPart))
                return true;

            return false;
        }

        /// <summary>
        /// Build a Part and add it to parent by invoking the generic method
        ///     T OpenXmlPart.AddNewPart[T]()
        /// </summary>
        /// <param name="partType"></param>
        /// <param name="parent"></param>
        /// <returns></returns>
        internal OpenXmlPart BuildPart(IdPartPair srcIdPartPair, OpenXmlPartContainer parent)
        {
            Log.Comment("Building Part {0} for PartContainer {1}", srcIdPartPair.OpenXmlPart.GetType(), parent.GetType());
            Type partType = srcIdPartPair.OpenXmlPart.GetType();
            if (partType.GetInterface("IFixedContentTypePart") != null)
            {
                // public virtual T AddNewPart<T>(string contentType, string id) where T: OpenXmlPart
                var addNewPartMethod = GetAddNewPartMethod(parent.GetType(), partType);
                if (null == addNewPartMethod)
                    throw new Exception(string.Format("AddNewPart() does not exist for {0}.", partType));
                return addNewPartMethod.Invoke(parent, new string[] { srcIdPartPair.OpenXmlPart.ContentType, srcIdPartPair.RelationshipId }) as OpenXmlPart;
            }
            // MainParts
            else if (parent is WordprocessingDocument && partType == typeof(MainDocumentPart))
            {
                return (parent as WordprocessingDocument).AddMainDocumentPart();
            }
            else if (parent is SpreadsheetDocument && partType == typeof(WorkbookPart))
            {
                return (parent as SpreadsheetDocument).AddWorkbookPart();
            }
            else if (parent is PresentationDocument && partType == typeof(PresentationPart))
            {
                return (parent as PresentationDocument).AddPresentationPart();
            }
            else if (srcIdPartPair.OpenXmlPart is ExtendedPart)
            {
                var addExtendedPartMethod = GetAddNewPartMethod(parent.GetType(), partType);
                if (null == addExtendedPartMethod)
                    throw new Exception(string.Format("AddExtendedPart() does not exist for {0}.", partType));
                return addExtendedPartMethod.Invoke(parent, new string[] { srcIdPartPair.OpenXmlPart.ContentType, srcIdPartPair.RelationshipId }) as ExtendedPart;
            }
            else
            {
                var methodPart = GetAddNewPartMethod(parent.GetType(), partType);
                if (null != methodPart)
                {
                    return methodPart.Invoke(parent, new string[] { srcIdPartPair.OpenXmlPart.ContentType, srcIdPartPair.RelationshipId }) as OpenXmlPart;
                }

                // contentType, id: AlternativeFormatImportPart, EmbeddedControlPersistencePart, FontPart, 
                // AudioPart, ImgagePart, VideoPart, ThumbnailPart, 
                // contentType: EmbeddedPackagePart, EmbeddedObjectPart, 
                // none: CoreFilePropertiesPart, DigitalSignatureOriginPart, ExtendedFilePropertiesPart, 
                // try to find and invoke the parent.AddXxxxPart() method that match the partType
                foreach (var method in parent.GetType().GetMethods().Where(m => m.IsPublic))
                {
                    if (method.ReturnParameter.ParameterType == partType &&
                        method.GetParameters().Count() == 1 &&
                        method.GetParameters()[0].ParameterType == typeof(string) &&
                        Regex.IsMatch(method.Name, "Add.*Part"))
                    {
                        string contentType = "anyContent";
                        return method.Invoke(parent, new object[] { contentType }) as OpenXmlPart;
                    }
                }
            }

            return null;
        }

        /// <summary>
        /// Get AddNewPart<T>() MethodInfo by reflection.
        /// public virtual T AddNewPart<T>(string contentType, string id) where T: OpenXmlPart;
        /// </summary>
        /// <param name="parentType">Type of PartContainer where the new part to be attached</param>
        /// <param name="partType">Type of new part to be created</param>
        /// <returns>The MethodInfo instance for specified AddNewPart<T>()</returns>
        public MethodInfo GetAddNewPartMethod(Type parentType, Type partType)
        {
            string prefix = "AddNewPart";
            Predicate<MethodInfo> matchMethod = (m => m.IsGenericMethod);
            Predicate<ParameterInfo> matchReturn = (r => r.ParameterType.IsSubclassOf(typeof(OpenXmlPart)));
            Predicate<ParameterInfo[]> matchParams =
                (ps => ps.Count() == 2 &&
                    ps[0].ParameterType == typeof(string) &&
                    ps[1].ParameterType == typeof(string));

            var mg = GetMethodInfo(parentType, prefix, matchMethod, matchParams, matchReturn);
            if (null == mg)
            {
                Log.Warning("Specifed method: {0} NOT found on {1}", prefix, parentType);
                return null;
            }
            else
            {
                Log.Comment("Subsituting T with {0} on {1}...", partType, parentType);
                return mg.MakeGenericMethod(partType);
            }
        }

        /// <summary>
        /// Get AddExtendedPart() MethodInfo by reflection.
        /// public ExtendedPart AddExtendedPart(string relationshipType, string contentType, string targetExt, string rId)
        /// </summary>
        /// <param name="parentType">Type of PartContainer where the new part to be attached</param>
        /// <param name="partType">Type of new part to be created</param>
        /// <returns>The MethodInfo instance for specified AddExtendedPart<T>()</returns>
        public MethodInfo GetAddExtendedPartMethod(Type parentType, Type partType)
        {
            string prefix = "AddExtendedPart";
            Predicate<MethodInfo> matchMethod = (m => m.IsGenericMethod);
            Predicate<ParameterInfo> matchReturn = (r => r.ParameterType == partType);
            Predicate<ParameterInfo[]> matchParams =
                (ps => ps.Count() == 4 &&
                    ps[0].ParameterType == typeof(string) &&
                    ps[1].ParameterType == typeof(string) &&
                    ps[2].ParameterType == typeof(string) &&
                    ps[3].ParameterType == typeof(string));

            var mng = GetMethodInfo(parentType, prefix, matchMethod, matchParams, matchReturn);
            if (null == mng)
            {
                Log.Warning("Specifed method: {0} NOT found on {1}", prefix, parentType);
                return null;
            }
            else
            {
                Log.Comment("Specified method: {0} is not generic.", prefix);
                return mng;
            }
        }

        /// <summary>
        /// Build Part and its PartRootElement type map.
        /// </summary>
        internal void BuildPartRootElementMap()
        {
            Log.Comment("Initialize Part-PartRootElement Map...");
            _partRootElementMap = new Dictionary<Type, Type>();
            var flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.FlattenHierarchy;
            var rootElements = typeof(OpenXmlPart).Assembly.GetTypes()
                .Where(type => type.IsSubclassOf(typeof(OpenXmlPartRootElement)));
            foreach (var rootType in rootElements)
            {
                var method = rootType.GetMethod("Load", flag);      // Find: public void Load(OpenXmlPart openXmlPart)
                if ((null != method)
                    && (method.GetParameters().Count() == 1)
                    && (method.GetParameters()[0].ParameterType.IsSubclassOf(typeof(OpenXmlPart))))
                {
                    PartRootElementMap.Add(method.GetParameters()[0].ParameterType, rootType);
                }
            }
            Log.Comment("Initialized Part-PartRootElement Map Sucessfully.");
        }

        #endregion PartOperations

        #region PackageReflectors
        /// <summary>
        /// Clone source package into destination package.
        /// </summary>
        /// <param name="srcPackage">source package</param>
        /// <param name="destPackage">destination package</param>
        internal void ReflectPackage(OpenXmlPackage srcPackage, OpenXmlPackage destPackage)
        {
            if (null == srcPackage)
                throw new ArgumentNullException("srcPackage");
            if (null == destPackage)
                throw new ArgumentNullException("destPackate");

            Log.Comment("Reflecting {0}...", srcPackage);
            foreach (var pair in srcPackage.Parts)
            {
                Type partType = pair.OpenXmlPart.GetType();

                OpenXmlPart newPart = BuildPart(pair, destPackage);
                ReflectPart(pair.OpenXmlPart, newPart, srcPackage, destPackage);

            }
            Log.Comment("Reflected {0} sucessfully!", srcPackage);
        }

        /// <summary>
        /// Clone source part and insert it to destination parent part or package.
        /// </summary>
        /// <param name="srcPart">source part</param>
        /// <param name="destPart">destination part</param>
        /// <param name="srcParent">parent of source part</param>
        /// <param name="destParent">parent of destination part</param>
        internal void ReflectPart(OpenXmlPart srcPart, OpenXmlPart destPart, OpenXmlPartContainer srcParent, OpenXmlPartContainer destParent)
        {
            if ((null == srcPart) || (null == destPart))
                throw new ArgumentNullException("srcPart/destPart");
            Log.Comment("Reflecting {0}...", srcPart);

            // Reflect nested part in source part
            foreach (IdPartPair pair in srcPart.Parts)
            {
                Log.Comment("Reflecting nested part {0} in {1}", pair.OpenXmlPart, srcPart);
                Type partType = pair.OpenXmlPart.GetType();

                OpenXmlPart newPart = BuildPart(pair, destPart);
                ReflectPart(pair.OpenXmlPart, newPart, srcPart, destPart);
                Log.Comment("Reflected nest part {0} in {1}", pair.OpenXmlPart, srcPart);
            }

            // Reflect external relationships
            foreach (var relationship in srcPart.ExternalRelationships)
            {
                destPart.AddExternalRelationship(relationship.RelationshipType, relationship.Uri, relationship.Id);
            }

            // Reflect elements in part if it's reflectable.
            Type srcPartType = srcPart.GetType();
            if (IsReflectablePart(srcPartType, srcParent))
            {
                Log.Comment("{0} is reflectable.", srcPart);
                Type rootType = PartRootElementMap[srcPartType];
                if (null == rootType)
                    throw new KeyNotFoundException(string.Format("Matched RootElementType: {0} for PartType: {1} Not found!", rootType, srcPartType));

                // Load source part into source root element
                var loader = rootType.GetMethod("Load", new Type[] { srcPartType });
                var ctor = rootType.GetConstructor(new Type[] { });
                OpenXmlElement srcRoot = ctor.Invoke(null) as OpenXmlElement;
                loader.Invoke(srcRoot, new Object[] { srcPart });

                // Construct a new root element for destination part with default constructor
                OpenXmlElement destRoot = ctor.Invoke(null) as OpenXmlElement;

                ReflectElement(srcRoot, destRoot, null, null);

                Log.Comment("Saving {0} by Calling Save() on {1}", destPart, destRoot);
                // Call Save(OpenXmlPart parentPart) to save the changes
                var saver = rootType.GetMethod("Save", new Type[] { srcPartType });
                saver.Invoke(destRoot, new Object[] { destPart });
                Log.Comment("Saved {0} by calling Save() on {1}", destPart, destRoot);
            }
            else
            {// Just feed data with stream of source part when it's NOT reflectable.
                Log.Comment("{0} is NOT reflectable. Feeding data...", srcPart);
                destPart.FeedData(srcPart.GetStream());
                Log.Comment("{0} feed data completely.", srcPart);
            }
            Log.Comment("Reflected {0} sucessfully.", srcPart);
        }

        /// <summary>
        /// Clone source element by reflection and insert it to parent element.
        /// </summary>
        /// <param name="srcElement">source element</param>
        /// <param name="destElement">destination element</param>
        /// <param name="srcParent">parent of source element</param>
        /// <param name="destParent">parent of destination element</param>
        internal void ReflectElement(OpenXmlElement srcElement, OpenXmlElement destElement, OpenXmlElement srcParent, OpenXmlElement destParent)
        {
            if ((null == srcElement) || (null == destElement))
                throw new ArgumentNullException("srcElement/destElement");
            Log.Comment("Reflecting {0}...", srcElement);

            // Append non-RootElement to parent
            if ((null != srcParent) && (null != destParent))
            {
                var parentType = srcParent.GetType();
                var inserter = GetInsertChildMethod(srcElement.GetType(), parentType, "AppendChild");
                if (null == inserter)
                    throw new Exception(string.Format("Specified InsertChild method: {0} NOT found for {1}", "AppendChild", parentType));
                inserter.Invoke(destParent, new Object[] { destElement });
            }

            ReflectAttributes(srcElement, destElement);

            if (srcElement is OpenXmlLeafTextElement)
                (destElement as OpenXmlLeafTextElement).Text = (srcElement as OpenXmlLeafTextElement).Text;

            foreach (var srcChild in srcElement.ChildElements)
            {
                // Special treatment for OpenXmlUnknownElement since it does not support manipulate children nor default/innerXml constructor
                if (srcChild is OpenXmlUnknownElement)
                {
                    var childUnknown = srcChild.CloneNode(true) as OpenXmlUnknownElement;
                    destElement.AppendChild<OpenXmlUnknownElement>(childUnknown);
                    continue;
                }

                var ctor = srcChild.GetType().GetConstructor(Type.EmptyTypes);
                var destChild = ctor.Invoke(null) as OpenXmlElement;
                ReflectElement(srcChild, destChild, srcElement, destElement);
            }
            Log.Comment("Reflected {0} sucessfully.", srcElement);
        }

        /// <summary>
        /// Get AppendChild/Prepend/InsertChildAfter/InsertChildBefore MethodInfo on parent element.
        /// </summary>
        /// <param name="srcElementType">type of source element</param>
        /// <param name="srcParentType">type of parent of source element</param>
        /// <param name="methodName">prefix of method name to look for</param>
        /// <returns></returns>
        internal MethodInfo GetInsertChildMethod(Type srcElementType, Type srcParentType, string methodName)
        {
            var flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.FlattenHierarchy;
            foreach (var method in srcParentType.GetMethods(flag).Where(m => m.IsGenericMethod))
            {
                if (method.Name.StartsWith(methodName) && method.GetParameters().Count() == 1)
                    return method.MakeGenericMethod(srcElementType);
            }
            return null;
        }

        /// <summary>
        /// Get attributes value of source element and set them on destination element by calling Attribute Property's setter.
        /// </summary>
        /// <param name="srcElement">source elment</param>
        /// <param name="destElement">destination element</param>
        internal void ReflectAttributes(OpenXmlElement srcElement, OpenXmlElement destElement)
        {
            if ((null == srcElement) || (null == destElement))
                throw new ArgumentNullException("srcElement/destElement");

            Log.Comment("Reflecting attributes of {0}...", srcElement);
            var flag = BindingFlags.InvokeMethod | BindingFlags.FlattenHierarchy | BindingFlags.Instance | BindingFlags.Public;
            var srcElementType = srcElement.GetType();
            foreach (var property in srcElementType.GetProperties(flag)
                .Where(p => p.GetCustomAttributes(typeof(SchemaAttrAttribute), false).Count() > 0))
                if (property.CanRead && property.CanWrite)
                {
                    var val = property.GetValue(srcElement, null);
                    property.SetValue(destElement, val, null);
                }
            Log.Comment("Reflected attributes of {0} sucessfully.", srcElement);
        }
        #endregion PackageReflector

        #region OpenXmlElementOperations

        #region Annotation

        public MethodInfo AddAnnotation(Type hostType)
        {
            var prefix = "AddAnnotation";
            Predicate<ParameterInfo[]> matchParams =
                ps => ps.Count() == 1 && ps[0].ParameterType == typeof(Object);
            return GetMethodInfo(hostType, prefix, null, matchParams, null);
        }

        public MethodInfo AnnotationT(Type hostType)
        {
            var prefix = "Annotation";
            Predicate<MethodInfo> matchMethod =
                m => m.IsGenericMethod;
            Predicate<ParameterInfo[]> matchParams =
                ps => ps.Count() == 1 && ps[0].ParameterType.IsClass;
            Predicate<ParameterInfo> matchReturn =
                r => r.ParameterType.IsClass;
            return GetMethodInfo(hostType, prefix, matchMethod, matchParams, matchReturn);
        }

        public MethodInfo Annotation(Type hostType)
        {
            var prefix = "Annotation";
            Predicate<MethodInfo> matchMethod =
                m => !m.IsGenericMethod;
            Predicate<ParameterInfo[]> matchParams =
                ps => ps.Count() == 1 && ps[0].ParameterType == typeof(Type);
            Predicate<ParameterInfo> matchReturn =
                r => r.ParameterType == typeof(Object);
            return GetMethodInfo(hostType, prefix, matchMethod, matchParams, matchReturn);
        }

        public MethodInfo Annotations(Type hostType)
        {
            var prefix = "Annotations";
            Predicate<MethodInfo> matchMethod =
                m => !m.IsGenericMethod;
            Predicate<ParameterInfo[]> matchParams =
                ps => ps.Count() == 1 && ps[0].ParameterType == typeof(Type);
            Predicate<ParameterInfo> matchReturn = null;
            return GetMethodInfo(hostType, prefix, matchMethod, matchParams, matchReturn);
        }

        public MethodInfo AnnotationsT(Type hostType)
        {
            var prefix = "Annotations";
            Predicate<MethodInfo> matchMethod =
                m => m.IsGenericMethod;
            Predicate<ParameterInfo[]> matchParams =
                ps => ps.Count() == 0;
            Predicate<ParameterInfo> matchReturn = null;
            return GetMethodInfo(hostType, prefix, matchMethod, matchParams, matchReturn);
        }

        public MethodInfo RemoveAnnotations(Type hostType)
        {
            var prefix = "RemoveAnnotations";
            Predicate<MethodInfo> matchMethod =
                m => !m.IsGenericMethod;
            Predicate<ParameterInfo[]> matchParams =
                ps => ps.Count() == 1 && ps[0].ParameterType == typeof(Type);
            Predicate<ParameterInfo> matchReturn = null;
            return GetMethodInfo(hostType, prefix, matchMethod, matchParams, matchReturn);
        }

        public MethodInfo RemoveAnnotations<T>(Type hostType)
        {
            var prefix = "RemoveAnnotations";
            Predicate<MethodInfo> matchMethod =
                m => m.IsGenericMethod;
            Predicate<ParameterInfo[]> matchParams =
                ps => ps.Count() == 1 && ps[0].ParameterType.IsClass;
            Predicate<ParameterInfo> matchReturn = null;
            return GetMethodInfo(hostType, prefix, matchMethod, matchParams, matchReturn);
        }

        #endregion Annotation

        #region Attributes
        public MethodInfo GetAttributes(Type hostType)
        {
            var prefix = "GetAttributes";
            Predicate<MethodInfo> matchMethod =
                m => !m.IsGenericMethod;
            Predicate<ParameterInfo[]> matchParams =
                ps => ps.Count() == 0;
            Predicate<ParameterInfo> matchReturn = null;
            //r => r.ParameterType.GetInterface("IList`1");
            return GetMethodInfo(hostType, prefix, matchMethod, matchParams, matchReturn);
        }

        public MethodInfo GetAttributesIC(Type hostType)
        {
            var prefix = "GetAttributes";
            Predicate<MethodInfo> matchMethod =
                m => !m.IsGenericMethod;
            Predicate<ParameterInfo[]> matchParams =
                ps => ps.Count() == 1;
            Predicate<ParameterInfo> matchReturn = null;
            return GetMethodInfo(hostType, prefix, matchMethod, matchParams, matchReturn);
        }

        public MethodInfo SetAttribute(Type hostType)
        {
            var prefix = "SetAttribute";
            Predicate<MethodInfo> matchMethod =
                m => !m.IsGenericMethod;
            Predicate<ParameterInfo[]> matchParams =
                ps => ps.Count() == 1 && ps[0].ParameterType == typeof(OpenXmlAttribute);
            Predicate<ParameterInfo> matchReturn = null;
            return GetMethodInfo(hostType, prefix, matchMethod, matchParams, matchReturn);
        }
        public MethodInfo SetAttributes(Type hostType)
        {
            var prefix = "SetAttributes";
            Predicate<MethodInfo> matchMethod =
                m => !m.IsGenericMethod;
            Predicate<ParameterInfo[]> matchParams =
                ps => ps.Count() == 1;
            Predicate<ParameterInfo> matchReturn = null;
            return GetMethodInfo(hostType, prefix, matchMethod, matchParams, matchReturn);
        }
        public MethodInfo ClearAllAttributes(Type hostType)
        {
            var prefix = "ClearAllAttributes";
            Predicate<MethodInfo> matchMethod =
                m => !m.IsGenericMethod;
            Predicate<ParameterInfo[]> matchParams =
                ps => ps.Count() == 0;
            Predicate<ParameterInfo> matchReturn = null;
            return GetMethodInfo(hostType, prefix, matchMethod, matchParams, matchReturn);
        }

        public MethodInfo RemoveAttribute(Type hostType)
        {
            var prefix = "RemoveAttribute";
            Predicate<MethodInfo> matchMethod =
                m => !m.IsGenericMethod;
            Predicate<ParameterInfo[]> matchParams =
                ps => ps.Count() == 1 && ps[0].ParameterType == typeof(OpenXmlAttribute);
            Predicate<ParameterInfo> matchReturn = null;
            return GetMethodInfo(hostType, prefix, matchMethod, matchParams, matchReturn);
        }
        #endregion Attributes

        #region Append/InsertAfter/InsertBefore/Prepend
        public MethodInfo AppendIE(Type hostType)
        {
            var prefix = "Append";
            Predicate<MethodInfo> matchMethod =
                m => !m.IsGenericMethod;
            Predicate<ParameterInfo[]> matchParams =
                ps => ps.Count() == 1 && null != ps[0].ParameterType.GetInterface("IEnumerable`1");
            Predicate<ParameterInfo> matchReturn = null;
            return GetMethodInfo(hostType, prefix, matchMethod, matchParams, matchReturn);
        }

        public MethodInfo AppendParams(Type hostType)
        {
            var prefix = "Append";
            Predicate<MethodInfo> matchMethod =
                m => !m.IsGenericMethod;
            Predicate<ParameterInfo[]> matchParams =
                ps => ps.Count() == 1
                    && ps[0].ParameterType.IsArray;
            Predicate<ParameterInfo> matchReturn = null;
            return GetMethodInfo(hostType, prefix, matchMethod, matchParams, matchReturn);
        }

        public MethodInfo AppendChild<T>(Type hostType)
        {
            var prefix = "AppendChild";
            Predicate<MethodInfo> matchMethod =
                m => m.IsGenericMethod;
            Predicate<ParameterInfo[]> matchParams =
                ps => ps.Count() == 1 && ps[0].ParameterType.IsSubclassOf(typeof(OpenXmlElement));
            Predicate<ParameterInfo> matchReturn =
                r => r.ParameterType.IsSubclassOf(typeof(OpenXmlElement));
            return GetMethodInfo(hostType, prefix, matchMethod, matchParams, matchReturn);
        }

        public MethodInfo InsertAfter<T>(Type hostType)
        {
            var prefix = "InsertAfter";
            Predicate<MethodInfo> matchMethod =
                m => m.IsGenericMethod;
            Predicate<ParameterInfo[]> matchParams =
                ps => ps.Count() == 2
                    && ps[0].ParameterType.IsSubclassOf(typeof(OpenXmlElement))
                    && ps[1].ParameterType == typeof(OpenXmlElement);
            Predicate<ParameterInfo> matchReturn =
                r => r.ParameterType.IsSubclassOf(typeof(OpenXmlElement));
            return GetMethodInfo(hostType, prefix, matchMethod, matchParams, matchReturn);
        }

        public MethodInfo InsertBefore<T>(Type hostType)
        {
            var prefix = "InsertBefore";
            Predicate<MethodInfo> matchMethod =
                m => m.IsGenericMethod;
            Predicate<ParameterInfo[]> matchParams =
                ps => ps.Count() == 2
                    && ps[0].ParameterType.IsSubclassOf(typeof(OpenXmlElement))
                    && ps[1].ParameterType == typeof(OpenXmlElement);
            Predicate<ParameterInfo> matchReturn =
                r => r.ParameterType.IsSubclassOf(typeof(OpenXmlElement));
            return GetMethodInfo(hostType, prefix, matchMethod, matchParams, matchReturn);
        }

        public MethodInfo PrependChild<T>(Type hostType)
        {
            var prefix = "PrependChild";
            Predicate<MethodInfo> matchMethod =
                m => m.IsGenericMethod;
            Predicate<ParameterInfo[]> matchParams =
                ps => ps.Count() == 1 && ps[0].ParameterType.IsSubclassOf(typeof(OpenXmlElement));
            Predicate<ParameterInfo> matchReturn =
                r => r.ParameterType.IsSubclassOf(typeof(OpenXmlElement));
            return GetMethodInfo(hostType, prefix, matchMethod, matchParams, matchReturn);
        }
        #endregion Append/InsertAfter/InsertBefore/Prepend

        #region Elements
        public MethodInfo ElementsT(Type hostType)
        {
            var prefix = "Elements";
            Predicate<MethodInfo> matchMethod =
                m => m.IsGenericMethod;
            Predicate<ParameterInfo[]> matchParams =
                ps => ps.Count() == 0;
            Predicate<ParameterInfo> matchReturn =
                r => null != r.ParameterType.GetInterface("IEnumerable`1");
            return GetMethodInfo(hostType, prefix, matchMethod, matchParams, matchReturn);
        }
        #endregion Elements

        #region ChildElements
        public MethodInfo GetFirstChildT(Type hostType)
        {
            var prefix = "GetFirstChild";
            Predicate<MethodInfo> matchMethod =
                m => m.IsGenericMethod;
            Predicate<ParameterInfo[]> matchParams =
                ps => ps.Count() == 0;
            Predicate<ParameterInfo> matchReturn =
                r => r.ParameterType.IsSubclassOf(typeof(OpenXmlElement));
            return GetMethodInfo(hostType, prefix, matchMethod, matchParams, matchReturn);
        }

        public MethodInfo ChildElements(Type hostType)
        {
            var prefix = "ChildElements";
            Predicate<MethodInfo> matchMethod =
                m => !m.IsGenericMethod;
            Predicate<ParameterInfo[]> matchParams =
                ps => ps.Count() == 0;
            Predicate<ParameterInfo> matchReturn =
                r => r.ParameterType == typeof(OpenXmlElementList);
            return GetMethodInfo(hostType, prefix, matchMethod, matchParams, matchReturn);
        }

        public MethodInfo ChildElementsT(Type hostType)
        {
            var prefix = "ChildElements";
            Predicate<MethodInfo> matchMethod =
                m => m.IsGenericMethod;
            Predicate<ParameterInfo[]> matchParams =
                ps => ps.Count() == 0;
            Predicate<ParameterInfo> matchReturn =
                r => null != r.ParameterType.GetInterface("IEnumerable`1");
            return GetMethodInfo(hostType, prefix, matchMethod, matchParams, matchReturn);
        }

        public MethodInfo RemoveAllChildren(Type hostType)
        {
            var prefix = "RemoveAllChildren";
            Predicate<MethodInfo> matchMethod =
                m => !m.IsGenericMethod;
            Predicate<ParameterInfo[]> matchParams =
                ps => ps.Count() == 0;
            Predicate<ParameterInfo> matchReturn = null;
            return GetMethodInfo(hostType, prefix, matchMethod, matchParams, matchReturn);
        }

        public MethodInfo RemoveChildT(Type hostType)
        {
            var prefix = "RemoveChild";
            Predicate<MethodInfo> matchMethod =
                m => !m.IsGenericMethod;
            Predicate<ParameterInfo[]> matchParams =
                ps => ps.Count() == 1 && ps[0].ParameterType.IsSubclassOf(typeof(OpenXmlElement));
            Predicate<ParameterInfo> matchReturn =
                r => r.ParameterType.IsSubclassOf(typeof(OpenXmlElement));
            return GetMethodInfo(hostType, prefix, matchMethod, matchParams, matchReturn);
        }

        #endregion ChildElements

        #region Descendants
        public MethodInfo Descendants(Type hostType)
        {
            var prefix = "Descendants";
            Predicate<MethodInfo> matchMethod =
                m => !m.IsGenericMethod;
            Predicate<ParameterInfo[]> matchParams =
                ps => ps.Count() == 0;
            Predicate<ParameterInfo> matchReturn =
                r => null != r.ParameterType.GetInterface("IEnumerable`1");
            return GetMethodInfo(hostType, prefix, matchMethod, matchParams, matchReturn);
        }

        public MethodInfo DescendantsT(Type hostType)
        {
            var prefix = "Descendants";
            Predicate<MethodInfo> matchMethod =
                m => m.IsGenericMethod;
            Predicate<ParameterInfo[]> matchParams =
                ps => ps.Count() == 0;
            Predicate<ParameterInfo> matchReturn =
                r => null != r.ParameterType.GetInterface("IEnumerable`1");
            return GetMethodInfo(hostType, prefix, matchMethod, matchParams, matchReturn);
        }

        #endregion Descendants

        #region Enumerator
        public MethodInfo GetEnumeratorT(Type hostType)
        {
            var prefix = "GetEnumerator";
            Predicate<MethodInfo> matchMethod =
                m => !m.IsGenericMethod;
            Predicate<ParameterInfo[]> matchParams =
                ps => ps.Count() == 0;
            Predicate<ParameterInfo> matchReturn =
                r => null != r.ParameterType.GetInterface("IEnumerator`1");
            return GetMethodInfo(hostType, prefix, matchMethod, matchParams, matchReturn);
        }

        public MethodInfo GetEnumerator(Type hostType)
        {
            var prefix = "GetEnumerator";
            Predicate<MethodInfo> matchMethod =
                m => !m.IsGenericMethod;
            Predicate<ParameterInfo[]> matchParams =
                ps => ps.Count() == 0;
            Predicate<ParameterInfo> matchReturn =
                r => null != r.ParameterType.GetInterface("IEnumerator");
            return GetMethodInfo(hostType, prefix, matchMethod, matchParams, matchReturn);
        }
        #endregion Enumerator

        #region Replace
        public MethodInfo ReplaceChildT(Type hostType)
        {
            var prefix = "ReplaceChild";
            Predicate<MethodInfo> matchMethod =
                m => m.IsGenericMethod;
            Predicate<ParameterInfo[]> matchParams =
                ps => ps.Count() == 2
                && ps[0].ParameterType == typeof(OpenXmlElement)
                && ps[1].ParameterType.IsSubclassOf(typeof(OpenXmlElement));
            Predicate<ParameterInfo> matchReturn =
                r => r.ParameterType.IsSubclassOf(typeof(OpenXmlElement));
            return GetMethodInfo(hostType, prefix, matchMethod, matchParams, matchReturn);
        }
        #endregion Replace

        #region Clone
        public MethodInfo Clone(Type hostType)
        {
            var prefix = "Clone";
            Predicate<MethodInfo> matchMethod =
                m => m.IsGenericMethod;
            Predicate<ParameterInfo[]> matchParams =
                ps => ps.Count() == 0;
            Predicate<ParameterInfo> matchReturn =
                r => r.ParameterType == typeof(Object);
            return GetMethodInfo(hostType, prefix, matchMethod, matchParams, matchReturn);
        }

        public MethodInfo CloneNode(Type hostType)
        {
            var prefix = "CloneNode";
            Predicate<MethodInfo> matchMethod =
                m => m.IsGenericMethod;
            Predicate<ParameterInfo[]> matchParams =
                ps => ps.Count() == 1
                && ps[0].ParameterType == typeof(bool);
            Predicate<ParameterInfo> matchReturn =
                r => r.ParameterType == typeof(OpenXmlElement);
            return GetMethodInfo(hostType, prefix, matchMethod, matchParams, matchReturn);
        }
        #endregion Clone

        #region PartIntegration
        public bool IsPartRootElement(Type hostType)
        {
            return hostType.IsSubclassOf(typeof(OpenXmlPartRootElement));
        }

        public MethodInfo Load(Type hostType)
        {
            var prefix = "Load";
            Predicate<MethodInfo> matchMethod =
                m => !m.IsGenericMethod;
            Predicate<ParameterInfo[]> matchParams =
                ps => ps.Count() == 1 && ps[0].ParameterType.IsSubclassOf(typeof(OpenXmlPart));
            Predicate<ParameterInfo> matchReturn = null;
            return GetMethodInfo(hostType, prefix, matchMethod, matchParams, matchReturn);
        }

        public MethodInfo Reload(Type hostType)
        {
            var prefix = "Reload";
            Predicate<MethodInfo> matchMethod =
                m => !m.IsGenericMethod;
            Predicate<ParameterInfo[]> matchParams =
                ps => ps.Count() == 0;
            Predicate<ParameterInfo> matchReturn = null;
            return GetMethodInfo(hostType, prefix, matchMethod, matchParams, matchReturn);
        }

        public MethodInfo Save(Type hostType)
        {
            var prefix = "Save";
            Predicate<MethodInfo> matchMethod =
                m => !m.IsGenericMethod;
            Predicate<ParameterInfo[]> matchParams =
                ps => ps.Count() == 1 && ps[0].ParameterType.IsSubclassOf(typeof(OpenXmlPart));
            Predicate<ParameterInfo> matchReturn = null;
            return GetMethodInfo(hostType, prefix, matchMethod, matchParams, matchReturn);
        }
        #endregion PartIntegraion

        #region WriteTo
        public MethodInfo WriteTo(Type hostType)
        {
            var prefix = "WriteTo";
            Predicate<MethodInfo> matchMethod =
                m => !m.IsGenericMethod;
            Predicate<ParameterInfo[]> matchParams =
                ps => ps.Count() == 1 && ps[0].ParameterType == typeof(System.Xml.XmlWriter);
            Predicate<ParameterInfo> matchReturn = null;
            return GetMethodInfo(hostType, prefix, matchMethod, matchParams, matchReturn);
        }
        #endregion WriteTo
        #endregion OpenXmlElement Operations

        #region Properties
        /*
        public bool HasAttributes { get; }

        public virtual IList<OpenXmlAttribute> ExtendedAttributes { get; }
        public OpenXmlElement Parent { get; internal set; }
        public abstract bool HasChildren { get; }
        
        public virtual OpenXmlElement FirstChild { get; }
        public virtual OpenXmlElement LastChild { get; }
        public virtual OpenXmlElement NextSibling { get; internal set; }
        public virtual OpenXmlElement PreviousSibling { get; }

        public string OuterXml { get; internal set; }
        public virtual string InnerText { get; protected set; }

        public virtual string Prefix { get; }
        public virtual string LocalName { get; }
        public virtual string NamespaceURI { get; }
        public virtual XmlQualifiedName XmlQualifiedName { get; }

        public OpenXmlElementContext OpenXmlElementContext { get; internal set; }
        */
        #endregion Properties

        #region Refelction Helpers
        /// <summary>
        /// Get MethodInfo that meet specified conditions by reflection.
        /// </summary>
        /// <param name="hostType">host type that the calling happen on it</param>
        /// <param name="prefix">the prefix of the method name</param>
        /// <param name="matchMethod">condition on method itself like IsGeneric etc.</param>
        /// <param name="matchParams">condition on parameters of the method</param>
        /// <param name="matchReturn">condition on return parameter of the method</param>
        /// <returns>MethodInfo that match all the conditions on host type, null if not found.</returns>
        public MethodInfo GetMethodInfo(Type hostType, string prefix, Predicate<MethodInfo> matchMethod, Predicate<ParameterInfo[]> matchParams, Predicate<ParameterInfo> matchReturn)
        {
            var flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.FlattenHierarchy;
            var methods = hostType.GetMethods(flag).Where(m => m.Name.StartsWith(prefix) && matchMethod(m));

            if (methods.Count() > 0)
                Log.Comment("Found {0} {1} on {2}.", methods.Count(), prefix, hostType);
            foreach (var m in methods)
            {
                if (((null != matchParams) && matchParams(m.GetParameters()))
                    && ((null != matchReturn) && matchReturn(m.ReturnParameter)))
                {
                    Log.Comment("Found matched method {0} on {1}", prefix, hostType);
                    return m;
                }
            }
            Log.Comment("Specified method: {0} NOT found on {1}.", prefix, hostType);
            return null;
        }

        /// <summary>
        /// Gte PropertyInfo that start with specified prefix.
        /// </summary>
        /// <param name="hostType">host type that get/set value happen on it</param>
        /// <param name="prefix">prefix of the property name</param>
        /// <returns>PropertyInfo for specified property member of host type</returns>
        public PropertyInfo GetProperty(Type hostType, string prefix)
        {
            var flag = BindingFlags.FlattenHierarchy | BindingFlags.Instance | BindingFlags.Public;
            var properties = hostType.GetProperties(flag).Where(p => p.Name.StartsWith(prefix));

            if (properties.Count() > 1)
            {
                Log.Warning("Found {0} Property:{1} on {2}. Please Doubel Check IT!", properties.Count(), prefix, hostType);
                return properties.First();
            }
            else if (properties.Count() == 0)
            {
                Log.Comment("Found exactly matched Property: {0} on {1}", prefix, hostType);
                return properties.First();
            }

            Log.Comment("Specified Property: {0} NOT found on {1}.", prefix, hostType);
            return null;
        }

        /// <summary>
        /// Retrieve Properties with SchemaAttrAttribute on specified OpenXmlElement.
        /// </summary>
        /// <param name="hostType">Type of OpenXmlElement or derived classes that has properties with SchemaAttrAttribute</param>
        /// <returns>IEnumberable<PropertyInfo> of property has SchemaAttrAttribute</returns>
        public static IEnumerable<PropertyInfo> GetAttributeProperties(Type hostType)
        {
            var flag = BindingFlags.FlattenHierarchy | BindingFlags.Instance | BindingFlags.Public;
            var properties = hostType.GetProperties(flag)
                .Where(p => p.GetCustomAttributes(typeof(SchemaAttrAttribute), false).Length > 0);
            return properties;
        }

        /// <summary>
        /// Retrieve built-in OpenXmlAttributes of the pass-in type of OpenXmlElement 
        /// </summary>
        /// <param name="hostType">Type of OpenXmlElement or derived classes that has properties with SchemaAttrAttribute</param>
        /// <returns>IEnumerable<OpenXmlAttribute> for fixed attributes of pass-in type of OpenXmlElement</returns>
        public static IEnumerable<OpenXmlAttribute> GetFixedAttributes(Type hostType)
        {
            var flag = BindingFlags.FlattenHierarchy | BindingFlags.Instance | BindingFlags.Public;
            var properties = hostType.GetProperties(flag)
                .Where(p => p.GetCustomAttributes(typeof(SchemaAttrAttribute), false).Length > 0);
            return properties
                .Select(p => p.GetCustomAttributes(typeof(SchemaAttrAttribute), false).First() as SchemaAttrAttribute)
                .Select(sa => new OpenXmlAttribute(sa.Tag, sa.NamespaceUri, null));
        }

        /// <summary>
        /// Retrieve Properties which is type of enum and border of the enum has EnumStringAttribute.
        /// </summary>
        /// <param name="hostType">Type of OpenXmlElement or derived classes that has OpenXml enum properties</param>
        /// <returns>IEnumberable<PropertyInfo> for property is type of enum and each enum border has EnumStringAttribute</returns>
        public static IEnumerable<PropertyInfo> GetEnumProperties(Type hostType)
        {
            var flag = BindingFlags.FlattenHierarchy | BindingFlags.Instance | BindingFlags.Public;
            Func<FieldInfo, bool> hasEnumString =
                fi => fi.GetCustomAttributes(typeof(EnumStringAttribute), false).Length > 0;

            return hostType.GetProperties(flag)
                .Where(p => p.PropertyType.IsEnum && p.PropertyType.GetFields(flag).Any(hasEnumString));
        }

        public static IEnumerable<Type> ListEnums()
        {
            return typeof(OpenXmlElement).Assembly.GetTypes()
                .Where(t => t.IsEnum && t.GetFields().Any(f => f.GetCustomAttributes(typeof(EnumStringAttribute), false).Length > 0));
        }

        /// <summary>
        /// Retrieve ChildElementTypes for specified OpenXmlElement or derived classes.
        /// </summary>
        /// <param name="hostType">Type of OpenXmlElement or derived classes that has ChildElementTypeAttribute</param>
        /// <returns>IEnumerable<Type> represent valid child element type for specified type of OpenXmlElement</returns>
        public static IEnumerable<Type> GetChildElementTypes(Type hostType)
        {
            return hostType.GetCustomAttributes(typeof(ChildElementInfoAttribute), false)
                .Select(ca => (ca as ChildElementInfoAttribute).ElementType);
        }

        /// <summary>
        /// Check if pass-in type is OpenXmlCompositeElement
        /// </summary>
        /// <param name="hostType">Type to be checked</param>
        /// <returns>true if it's OpenXmlCompositeElement, false if not.</returns>
        public static bool IsCompositeElement(Type hostType)
        {
            return hostType.IsSubclassOf(typeof(OpenXmlCompositeElement));
        }

        /// <summary>
        /// Check if pass-in type is OpenXmlLeafElement
        /// </summary>
        /// <param name="hostType">Type to be checked</param>
        /// <returns>true if it's OpenXmlLeafElement, false if not.</returns>
        public static bool IsLeafElement(Type hostType)
        {
            return hostType.IsSubclassOf(typeof(OpenXmlLeafElement));
        }

        #endregion Reflection Helpers
    }

}