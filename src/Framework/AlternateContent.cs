// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Runtime.Serialization;
using System.Diagnostics;


namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Represents the mc:AlternateContent element of markup 
    /// compatibility.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    
    public class AlternateContent : OpenXmlCompositeElement
    {
        private static string _mcNamespace = @"http://schemas.openxmlformats.org/markup-compatibility/2006";
        private static byte _mcNamespaceId = byte.MaxValue;

        private static string tagName = "AlternateContent";


        /// <summary>
        /// Initializes a new instance of the AlternateContent 
        /// class.
        /// </summary>
        public AlternateContent()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the AlternateContent  
        /// class by using the supplied IEnumerable elements.
        /// </summary>
        /// <param name="childElements">
        /// Represents all child elements.
        /// </param>
        public AlternateContent(IEnumerable<OpenXmlElement> childElements)
            : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AlternateContent  
        /// class by using the supplied OpenXmlElement elements.
        /// </summary>
        /// <param name="childElements">
        /// Represents all child elements.
        /// </param>
        public AlternateContent(params OpenXmlElement[] childElements)
            : base(childElements)
        {
        }

        /// <param name="outerXml">The outer XML of the element.
        /// </param>
        /// <summary>
        /// Initializes a new instance of the AlternateContent  
        /// class by using the supplied string.
        /// </summary>
        public AlternateContent(string outerXml)
            : base(outerXml)
        {
        }


        /// <summary>
        /// Gets a value that represents the markup compatibility 
        /// namespace.
        /// </summary>
        public static string MarkupCompatibilityNamespace
        {
            get { return _mcNamespace; }
        }

        /// <summary>
        /// Gets a value that represents the markup compatibility 
        /// namespace ID.
        /// </summary>
        public static byte MarkupCompatibilityNamespaceId
        {
            get
            {
                if (_mcNamespaceId == byte.MaxValue)
                {
                    _mcNamespaceId = NamespaceIdMap.GetNamespaceId(_mcNamespace);
                }

                return _mcNamespaceId;
            }
        }

        /// <summary>
        /// Gets a value that represents the tag name of the 
        /// AlternateContent element.
        /// </summary>
        public static string TagName
        {
            get { return tagName; }
        }

        /// <summary>
        /// Gets a value that represents the local name of the 
        /// AlternateContent element.
        /// </summary>
        public override string LocalName
        {
            get { return tagName; }
        }

        internal override byte NamespaceId
        {
            get { return MarkupCompatibilityNamespaceId; }
        }

        private static string[] attributeTagNames = { };
        private static byte[] attributeNamespaceIds = { };

        internal override string[] AttributeTagNames
        {
            get
            {
                return attributeTagNames;
            }
        }

        internal override byte[] AttributeNamespaceIds
        {
            get
            {
                return attributeNamespaceIds;
            }
        }


        internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
        {
            if (MarkupCompatibilityNamespaceId == namespaceId && AlternateContentChoice.TagName == name)
                return new AlternateContentChoice();

            if (MarkupCompatibilityNamespaceId == namespaceId && AlternateContentFallback.TagName == name)
                return new AlternateContentFallback();

            return null;
        }


        /// <summary>
        /// Appends a new child of type T:DocumentFormat.OpenXml.AlternateContentChoice
        ///  to the current element.
        /// </summary>
        /// <returns>
        /// </returns>
        public AlternateContentChoice AppendNewAlternateContentChoice()
        {
            AlternateContentChoice child = new AlternateContentChoice();
            this.AppendChild(child);
            return child;
        }
        /// <summary>
        /// Appends a new child of type T:DocumentFormat.OpenXml.AlternateContentFallback
        ///  to the current element.
        /// </summary>
        /// <returns>
        /// </returns>
        public AlternateContentFallback AppendNewAlternateContentFallback()
        {
            AlternateContentFallback child = new AlternateContentFallback();
            this.AppendChild(child);
            return child;
        }

        internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
        {

            return null;
        }

        /// <returns>The cloned node. </returns>
        /// <summary>
        /// When a node is overridden in a derived class, 
        /// CloneNode creates a duplicate of the node.
        /// </summary>
        /// <param name="deep">
        /// True to recursively clone the subtree under 
        /// the specified node; False to clone only the node 
        /// itself.
        /// </param>
        public override OpenXmlElement CloneNode(bool deep)
        {
            return CloneImp<AlternateContent>(deep);
        }

        /// <summary>
        /// The type ID of the element. 
        /// </summary>
        internal override int ElementTypeId
        {
            get { return ReservedElementTypeIds.AlternateContentId; }
        }

        /// <summary>
        /// Indicates whether this element is available in a specific version of an Office Application.
        /// Always returns true since AlternateContent is allowed 
        /// in every version.
        /// </summary>
        /// <param name="version">The Office file format version.</param>
        /// <returns>Returns true if the element is defined in the specified version.</returns>
        internal override bool IsInVersion(FileFormatVersions version)
        {
            return true;
        }
    }

    /// <summary>
    /// Defines an mc:Choice element in mc:AlternateContent.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    public class AlternateContentChoice : OpenXmlCompositeElement
    {
        private static string tagName = "Choice";
    
        /// <summary>
        /// Initializes a new instance of the 
        /// AlternateContentChoice class.
        /// </summary>
        public AlternateContentChoice()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the 
        /// AlternateContentChoice class by using the supplied 
        /// IEnumerable elements.
        /// </summary>
        /// <param name="childElements">
        /// Represents all child elements.
        /// </param>
        public AlternateContentChoice(IEnumerable<OpenXmlElement> childElements)
            : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the 
        /// AlternateContentChoice class by using the supplied 
        /// OpenXmlElement elements.
        /// </summary>
        /// <param name="childElements">
        /// Represents all child elements.
        /// </param>
        public AlternateContentChoice(params OpenXmlElement[] childElements)
            : base(childElements)
        {
        }

        /// <param name="outerXml">
        /// The outer XML of the element.
        /// </param>
        /// <summary>
        /// Initializes a new instance of the 
        /// AlternateContentChoice class by using the supplied 
        /// string.
        /// </summary>
        public AlternateContentChoice(string outerXml)
            : base(outerXml)
        {
        }

        /// <summary>
        /// Gets a value that represents the tag name of the 
        /// Choice element.
        /// </summary>
        public static string TagName
        {
            get { return tagName; }
        }
        /// <summary>
        /// Gets the local name of the Choice element.
        /// </summary>
        public override string LocalName
        {
            get { return tagName; }
        }

        internal override byte NamespaceId
        {
            get { return AlternateContent.MarkupCompatibilityNamespaceId; }
        }

        private static string[] attributeTagNames = { "Requires" };
        private static byte[] attributeNamespaceIds = { 0 };

        internal override string[] AttributeTagNames
        {
            get
            {
                return attributeTagNames;
            }
        }

        internal override byte[] AttributeNamespaceIds
        {
            get
            {
                return attributeNamespaceIds;
            }
        }

        internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
        {

            if (0 == namespaceId && "Requires" == name)
                return new StringValue();
            return null;
        }

        /// <summary>
        /// <para>Gets or sets a whitespace-delimited list of namespace prefixes that identify the
        /// namespaces a markup consumer needs in order to understand and select that 
        /// Choice and process the content.</para>
        /// <para> Represents the attribute in a schema. </para>
        /// </summary>
        public StringValue Requires
        {
            get { return (StringValue)Attributes[0]; }
            set { Attributes[0] = value; }
        }

        internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
        {
            OpenXmlElement newElement = null;

            if (this.Parent != null &&
                 this.Parent is AlternateContent)
            {
                OpenXmlElement parentsParentElemnt = this.Parent.Parent;
                if (parentsParentElemnt != null)
                {
                    newElement = parentsParentElemnt.ElementFactory(namespaceId, name);
                    if (newElement == null)
                    {
                        newElement = parentsParentElemnt.AlternateContentElementFactory(namespaceId, name);
                    }
                }
            }

            return newElement;
        }

        /// <returns>The cloned node. </returns>
        /// <summary>
        /// When a node is overridden in a derived class, CloneNode creates a duplicate
        ///  of the node.
        /// </summary>
        /// <param name="deep">
        /// True to recursively clone the subtree under the specified node; False
        ///  to clone only the node itself.
        /// </param>
        public override OpenXmlElement CloneNode(bool deep)
        {
            return CloneImp<AlternateContentChoice>(deep);
        }

        /// <summary>
        /// The type ID of the element. 
        /// </summary>
        internal override int ElementTypeId
        {
            get { return ReservedElementTypeIds.AlternateContentChoiceId; }
        }

        /// <summary>
        /// Indicates whether this element is available in a specific version of an Office Application.
        /// This method always returns true since AlternateContentFallback is available in every version.
        /// </summary>
        /// <param name="version">The Office file format version.</param>
        /// <returns>Returns true if the element is defined in the specified version.</returns>
        internal override bool IsInVersion(FileFormatVersions version)
        {
            return true;
        }

    }

   /// <summary>
    /// Defines a mc:Fallback element in mc:AlternateContent.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    
    public class AlternateContentFallback : OpenXmlCompositeElement
    {
        private static string tagName = "Fallback";
   
        /// <summary>
        /// Initializes a new instance of the AlternateContentFallback class.
        /// </summary>
        public AlternateContentFallback()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the AlternateContentFallback class
        ///  by using the supplied IEnumerable elements.
        /// </summary>
        /// <param name="childElements">
        /// Represents all child elements.
        /// </param>
        public AlternateContentFallback(IEnumerable<OpenXmlElement> childElements)
            : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AlternateContentFallback class
        ///  by using the supplied OpenXmlElement elements.
        /// </summary>
        /// <param name="childElements">
        /// Represents all child elements.
        /// </param>
        public AlternateContentFallback(params OpenXmlElement[] childElements)
            : base(childElements)
        {
        }

        /// <param name="outerXml">The outer XML of the element.</param>
        /// <summary>
        /// Initializes a new instance of the AlternateContentFallback class
        ///  by using the supplied string.
        /// </summary>
        public AlternateContentFallback(string outerXml)
            : base(outerXml)
        {
        }


        /// <summary>
        /// Gets a value that represents the tag name of the AlternateContentFallback element.
        /// </summary>
        public static string TagName
        {
            get { return tagName; }
        }

        /// <summary>
        /// Gets the local name of the element.
        /// </summary>
        public override string LocalName
        {
            get { return tagName; }
        }

        internal override byte NamespaceId
        {
            get { return AlternateContent.MarkupCompatibilityNamespaceId; }
        }

        private static string[] attributeTagNames = { };
        private static byte[] attributeNamespaceIds = { };

        internal override string[] AttributeTagNames
        {
            get
            {
                return attributeTagNames;
            }
        }

        internal override byte[] AttributeNamespaceIds
        {
            get
            {
                return attributeNamespaceIds;
            }
        }

        internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
        {

            return null;
        }

        internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
        {
            OpenXmlElement newElement = null;

            if (this.Parent != null &&
                 this.Parent is AlternateContent)
            {
                OpenXmlElement parentsParentElemnt = this.Parent.Parent;
                if (parentsParentElemnt != null)
                {
                    newElement = parentsParentElemnt.ElementFactory(namespaceId, name);
                }
            }

            return newElement;
        }

        /// <returns>The cloned node. </returns>
        /// <summary>
        /// When a node is overridden in a derived class, CloneNode creates a
        ///  duplicate of the node.
        /// </summary>
        /// <param name="deep">
        /// True to recursively clone the subtree under the specified node; False
        ///  to clone only the node itself.
        /// </param>
        public override OpenXmlElement CloneNode(bool deep)
        {
            return CloneImp<AlternateContentFallback>(deep);
        }

        /// <summary>
        /// The type ID of the element. 
        /// </summary>
        internal override int ElementTypeId
        {
            get { return ReservedElementTypeIds.AlternateContentFallbackId; }
        }

        /// <summary>
        /// Indicates whether this element is available in a specific version of an Office Application.
        /// This method always return true since AlternateContentFallback is available in every version.
        /// </summary>
        /// <param name="version">The Office file format version.</param>
        /// <returns>Returns true if the element is defined in the specified version.</returns>
        internal override bool IsInVersion(FileFormatVersions version)
        {
            return true;
        }
    }

    internal enum ElementAction
    {
        Normal,
        Ignore,
        ProcessContent,
        ACBlock,
    }

    internal enum AttributeAction
    {
        Normal,
        Ignore,
    }

    /// <summary>
    /// Defines the Markup Compatibility Attributes.
    /// </summary>
    public class MarkupCompatibilityAttributes
    {
        internal static string MCPrefix = NamespaceIdMap.GetNamespacePrefix(NamespaceIdMap.GetNamespaceId(AlternateContent.MarkupCompatibilityNamespace));
        /// <summary>
        /// Gets or sets a whitespace-delimited list of prefixes, where each
        ///  prefix identifies an ignorable namespace.
        /// </summary>
        public StringValue Ignorable { get; set; }
        /// <summary>
        /// Gets or sets a whitespace-delimited list of element-qualified names
        ///  that identify the expanded names of elements. The content of the
        ///  elements shall be processed, even if the elements themselves are
        ///  ignored.
        /// </summary>
        public StringValue ProcessContent { get; set; }
        /// <summary>
        /// Gets or sets a whitespace-delimited list of element qualified names
        ///  that identify the expanded names of elements. The elements are suggested
        ///  by a markup producer for preservation by markup editors, even if
        ///  the elements themselves are ignored.
        /// </summary>
        public StringValue PreserveElements { get; set; }
        /// <summary>
        /// Gets or sets a whitespace-delimited list of attribute qualified names
        ///  that identify expanded names of attributes. The attributes were
        ///  suggested by a markup producer for preservation by markup editors.
        /// </summary>
        public StringValue PreserveAttributes { get; set; }
        /// <summary>
        /// Gets or sets a whitespace-delimited list of prefixes that identify
        ///  a set of namespace names.
        /// </summary>
        public StringValue MustUnderstand { get; set; }
    }

    internal class MCConsts
    {
        internal const string Ignorable = "Ignorable";
        internal const string ProcessContent = "ProcessContent";
        internal const string PreserveElements = "PreserveElements";
        internal const string PreserveAttributes = "PreserveAttributes";
        internal const string MustUnderstand = "MustUnderstand";
    }

        
    internal class MCContext
    {
        internal delegate string LookupNamespace(string prefix);


        Stack<string> _currentIgnorable;
        Stack<XmlQualifiedName> _currentPreserveAttr;
        Stack<XmlQualifiedName> _currentPreserveEle;
        Stack<XmlQualifiedName> _currentProcessContent;

        Stack<int> _pushedIgnor;
        Stack<int> _pushedPA;
        Stack<int> _pushedPE;
        Stack<int> _pushedPC;
        bool _noExceptionOnError;

        internal MCContext()
        {
            _currentIgnorable = new Stack<string>();
            _currentPreserveAttr = new Stack<XmlQualifiedName>();
            _currentPreserveEle = new Stack<XmlQualifiedName>();
            _currentProcessContent = new Stack<XmlQualifiedName>();

            _pushedIgnor = new Stack<int>();
            _pushedPA = new Stack<int>();
            _pushedPC = new Stack<int>();
            _pushedPE = new Stack<int>();
        }

        internal MCContext(bool exceptionOnError)
            : this()
        {
            this._noExceptionOnError = ! exceptionOnError;
        }


        internal LookupNamespace LookupNamespaceDelegate { get; set; }

        #region methods to maintain the MC Context
        internal void PushMCAttributes(MarkupCompatibilityAttributes attr)
        {
            _pushedIgnor.Push(PushIgnorable(attr));
            _pushedPA.Push(PushPreserveAttribute(attr));
            _pushedPE.Push(PushPreserveElement(attr));
            _pushedPC.Push(PushProcessContent(attr));
        }

        internal void PopMCAttributes()
        {
            PopIgnorable(_pushedIgnor.Pop());
            PopPreserveAttribute(_pushedPA.Pop());
            PopPreserveElement(_pushedPE.Pop());
            PopProcessContent(_pushedPC.Pop());
        }

        /// <summary>
        /// This method is for MC validation use. Only push Ignorable and ProcessContent.
        /// </summary>
        /// <param name="attr"></param>
        /// <param name="lookupNamespaceDelegate"></param>
        internal void PushMCAttributes2(MarkupCompatibilityAttributes attr, LookupNamespace lookupNamespaceDelegate)
        {
            this.LookupNamespaceDelegate = lookupNamespaceDelegate;

            _pushedIgnor.Push(PushIgnorable(attr));
            _pushedPC.Push(PushProcessContent(attr));
        }

        /// <summary>
        /// This method is for MC validation use only.
        /// </summary>
        internal void PopMCAttributes2()
        {
            PopIgnorable(_pushedIgnor.Pop());
            PopProcessContent(_pushedPC.Pop());
        }

        /// <summary>
        /// This method is called by ParseQNameList() and ParsePrefixList().
        /// </summary>
        /// <param name="value">The value of the attribute.</param>
        /// <returns>True to stop parsing; False to continue.</returns>
        internal delegate bool OnInvalidValue(string value);

        internal IEnumerable<string> ParsePrefixList(string ignorable, OnInvalidValue onInvalidPrefix)
        {
            Debug.Assert(!string.IsNullOrEmpty(ignorable));

            var prefixes = ignorable.Trim().Split(new char[] { ' ' });
            foreach (var prefix in prefixes)
            {
                var ns = LookupNamespaceDelegate(prefix);
                if (string.IsNullOrEmpty(ns))
                {
                    if (onInvalidPrefix(ignorable))
                    {
                        yield break;
                    }
                    else
                    {
                        continue;
                    }
                }

                yield return ns;
            }
        }

        internal IEnumerable<XmlQualifiedName> ParseQNameList(string qnameList, OnInvalidValue onInvalidQName)
        {
            Debug.Assert(!string.IsNullOrEmpty(qnameList));

            var qnames = qnameList.Trim().Split(new char[] { ' ' });
            foreach (var qname in qnames)
            {
                var items = qname.Split(':');
                if (items.Length != 2)
                {
                    if (onInvalidQName(qnameList))
                    {
                        yield break;
                    }
                    else
                    {
                        continue;
                    }
                }
                var ns = LookupNamespaceDelegate(items[0]);
                if (string.IsNullOrEmpty(ns))
                {
                    if (onInvalidQName(qnameList))
                    {
                        yield break;
                    }
                    else
                    {
                        continue;
                    }
                }

                yield return (new XmlQualifiedName(items[1], ns));
            }
        }

        #endregion

        #region Exposed functions
        internal bool HasIgnorable()
        {
            return _currentIgnorable.Count > 0;
        }

        internal bool IsIgnorableNs(byte namespaceId)
        {
            if (_currentIgnorable.Count == 0)
            {
                return false;
            }

            if (_currentIgnorable.Contains(NamespaceIdMap.GetNamespaceUri(namespaceId)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal bool IsIgnorableNs(string ns)
        {
            if (_currentIgnorable.Count == 0)
            {
                return false;
            }

            if (string.IsNullOrEmpty(ns))
            {
                return false;
            }

            if (_currentIgnorable.Contains(ns))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal bool IsPreservedAttribute(string ns, string localName)
        {

            return ContainsQName(localName, ns, _currentPreserveAttr);
        }

        internal bool IsPreservedElement(string ns, string localName)
        {
            return ContainsQName(localName, ns, _currentPreserveEle);
        }

        internal bool IsProcessContent(string ns, string localName)
        {
            return ContainsQName(localName, ns, _currentProcessContent);
        }

        internal bool IsProcessContent(OpenXmlElement element)
        {
            // TODO: performance tuning
            return ContainsQName(element.LocalName, element.NamespaceUri, _currentProcessContent);
        }

        internal AttributeAction GetAttributeAction(string ns, string localName, FileFormatVersions format)
        {
            if (format == (FileFormatVersions.Office2010|FileFormatVersions.Office2007) || format == (FileFormatVersions.Office2010|FileFormatVersions.Office2007|FileFormatVersions.Office2013))
            {
                return AttributeAction.Normal;
            }

            if (string.IsNullOrEmpty(ns))
            {
                return AttributeAction.Normal;
            }

            if (NamespaceIdMap.IsInFileFormat(ns, format))
            {
                return AttributeAction.Normal;
            }

            if (!IsIgnorableNs(ns))
            {
                return AttributeAction.Normal;
            }

            if (IsPreservedAttribute(ns, localName))
            {
                return AttributeAction.Normal;
            }

            return AttributeAction.Ignore;
        }

        internal ElementAction GetElementAction(OpenXmlElement element, FileFormatVersions format)
        {
            if (format == (FileFormatVersions.Office2010 | FileFormatVersions.Office2007) || format == (FileFormatVersions.Office2010 | FileFormatVersions.Office2007 | FileFormatVersions.Office2013))
            {
                return ElementAction.Normal;
            }

            if (element is AlternateContent)
            {
                return ElementAction.ACBlock;
            } 
            
            if (element.IsInVersion(format))
            {
                return ElementAction.Normal;
            }

            if (IsIgnorableNs(element.NamespaceUri))
            {
                if (IsPreservedElement(element.NamespaceUri, element.LocalName))
                {
                    return ElementAction.Normal;
                }
                if (IsProcessContent(element.NamespaceUri, element.LocalName))
                {
                    return ElementAction.ProcessContent;
                }
                return ElementAction.Ignore;
            }

            return ElementAction.Normal;
        }
        #endregion

        #region private methods
        private static bool ContainsQName(string localName, string ns, Stack<XmlQualifiedName> stack)
        {
            XmlQualifiedName qname = new XmlQualifiedName(localName, ns);
            foreach (var qn in stack)
            {
                if (qn == qname ||
                    qn.Name == "*" && qn.Namespace == ns)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// This method is called by ParseIgnorable() and ParseProcessContent().
        /// </summary>
        /// <param name="value">The value of the attribute.</param>
        /// <returns>True to stop parsing; False to continue.</returns>
        private bool OnMcContextError(string value)
        {
            if (this._noExceptionOnError)
            {
                return false;
            }
            else
            {
                var msg = String.Format(System.Globalization.CultureInfo.CurrentUICulture, ExceptionMessages.UnknowMCContent, value);
                throw new InvalidMCContentException(msg);
            }
        }

        private int PushIgnorable(MarkupCompatibilityAttributes attr)
        {
            int ret = 0;
            if (attr != null && attr.Ignorable != null && !string.IsNullOrEmpty(attr.Ignorable.Value))
            {
                foreach (var ns in ParsePrefixList(attr.Ignorable,   OnMcContextError))
                {
                    _currentIgnorable.Push(ns);
                    ret++;
                }
            }
            return ret;
        }

        private int PushQName(Stack<XmlQualifiedName>stack, string value)
        {
            int ret = 0;

            foreach (var qn in ParseQNameList(value, OnMcContextError))
            {
                stack.Push(qn);
                ret++;
            }
            return ret;
        }

        private int PushPreserveAttribute(MarkupCompatibilityAttributes attr)
        {
            int ret = 0;
            if (attr != null && attr.PreserveAttributes != null && !string.IsNullOrEmpty(attr.PreserveAttributes.Value))
            {
                ret = PushQName(_currentPreserveAttr,attr.PreserveAttributes.Value);
            }
            return ret;
        }

        private int PushPreserveElement(MarkupCompatibilityAttributes attr)
        {
            int ret = 0;
            if (attr != null && attr.PreserveElements != null && !string.IsNullOrEmpty(attr.PreserveElements.Value))
            {
                ret = PushQName(_currentPreserveEle, attr.PreserveElements.Value);
            }
            return ret;
        }

        private int PushProcessContent(MarkupCompatibilityAttributes attr)
        {
            int ret = 0;
            if (attr != null && attr.ProcessContent != null && !string.IsNullOrEmpty(attr.ProcessContent.Value))
            {
                ret = PushQName(_currentProcessContent, attr.ProcessContent.Value);
            }
            return ret;
        }

        private void PopIgnorable(int count)
        {
            for (int i = 0; i < count; i++)
            {
                _currentIgnorable.Pop();
            }
        }

        private void PopPreserveAttribute(int count)
        {
            for (int i = 0; i < count; i++)
            {
                _currentPreserveAttr.Pop();
            }
        }

        private void PopPreserveElement(int count)
        {
            for (int i = 0; i < count; i++)
            {
                _currentPreserveEle.Pop();
            }
        }

        private void PopProcessContent(int count)
        {
            for (int i = 0; i < count; i++)
            {
                _currentProcessContent.Pop();
            }
        }
        #endregion

        #region Helper functions
        internal OpenXmlCompositeElement GetContentFromACBlock(AlternateContent acblk, FileFormatVersions format)
        {
            Debug.Assert(format != (FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013));

            foreach (var choice in acblk.ChildElements.OfType<AlternateContentChoice>())
            {
                if(choice.Requires == null)
                {
                    //should we throw exception here?
                    continue;
                }
                string reqs = choice.Requires.InnerText.Trim();
                if (string.IsNullOrEmpty(reqs))
                {
                    //should we throw exception here?
                    continue;
                }

                bool chooce = true;
                foreach (var req in reqs.Split(new char[] { ' ' }))
                {
                    //fix bug 537858
                    //the LookupNamespaceDeleget is from xmlReader
                    //bug when we try to GetContentFromACBlock, the reader has already moved to the next element of ACB
                    //so we should use the element's LookupNamespace function to find it
                    //string ns = LookupNamespaceDelegate(req);
                    string ns = choice.LookupNamespace(req);
                    if (ns == null)
                    {
                        if (this._noExceptionOnError)
                        {
                            chooce = false;
                            break;
                        }
                        else
                        {
                            var msg = String.Format(System.Globalization.CultureInfo.CurrentUICulture, ExceptionMessages.UnknowMCContent, req);
                            throw new InvalidMCContentException(msg);
                        }
                    }
                    if (!NamespaceIdMap.IsInFileFormat(ns, format))
                    {
                        chooce = false;
                        break;
                    }
                }

                if (chooce)
                {
                    return choice;
                }
            }
            var fallback = acblk.GetFirstChild<AlternateContentFallback>();
            if (fallback != null)
            {
                return fallback;
            }
            return null;
        }
        #endregion
    }

    /// <summary>
    /// The exception that is thrown for Markup Compatibility content errors.
    /// </summary>
    [SerializableAttribute]
    public sealed class InvalidMCContentException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the InvalidMCContentException class. 
        /// </summary>
        public InvalidMCContentException()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the InvalidMCContentException class with a specified error message. 
        /// </summary>
        /// <param name="message">The message that describes the error. </param>
        public InvalidMCContentException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the InvalidMCContentException class with serialized data. 
        /// </summary>
        /// <param name="info">The SerializationInfo that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The StreamingContext that contains contextual information about the source or destination.</param>
        private InvalidMCContentException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        /// <summary>
        /// Initializes a new instance of the InvalidMCContentException class with a specified error message and a reference to the inner exception that is the cause of this exception. 
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified.</param>
        public InvalidMCContentException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }

    /// <summary>
    /// The exception that is thrown for Markup Compatibility content errors.
    /// </summary>
    [SerializableAttribute]
    public sealed class  NamespaceNotUnderstandException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the InvalidMCContentException class. 
        /// </summary>
        public NamespaceNotUnderstandException()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the InvalidMCContentException class with a specified error message. 
        /// </summary>
        /// <param name="message">The message that describes the error. </param>
        public NamespaceNotUnderstandException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the InvalidMCContentException class with serialized data. 
        /// </summary>
        /// <param name="info">The SerializationInfo that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The StreamingContext that contains contextual information about the source or destination.</param>
        private NamespaceNotUnderstandException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        /// <summary>
        /// Initializes a new instance of the InvalidMCContentException class with a specified error message and a reference to the inner exception that is the cause of this exception. 
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified.</param>
        public NamespaceNotUnderstandException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }

}
