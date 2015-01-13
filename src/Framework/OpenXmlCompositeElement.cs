// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
using System.Diagnostics;
using System.Globalization;
using System.Linq;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Specifies the type of each child element's occurence. 
    /// Used in GetElement() and SetElement() for generated code.
    /// </summary>
    internal enum OpenXmlCompositeType
    {
        Other,

        /// <summary>
        /// xsd:sequence, and maxOccurs=1.
        /// </summary>
        OneSequence,

        /// <summary>
        /// xsd:choice, and maxOccurs=1.
        /// </summary>
        OneChoice,

        /// <summary>
        /// xsd:all.
        /// </summary>
        OneAll
    }

    /// <summary>
    /// Represents the base class for composite elements.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    public abstract class OpenXmlCompositeElement : OpenXmlElement
    {
        private OpenXmlElement _lastChild;

        /// <summary>
        /// Initializes a new instance of the OpenXmlCompositeElement class.
        /// </summary>
        protected OpenXmlCompositeElement()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlCompositeElement class using the supplied outer XML.
        /// </summary>
        /// <param name="outerXml">The outer XML of the element.</param>
        protected OpenXmlCompositeElement(string outerXml)
            : base(outerXml)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlCompositeElement class using the supplied collection of elements.
        /// </summary>
        /// <param name="childrenElements">A collection of elements.</param>
        protected OpenXmlCompositeElement(IEnumerable childrenElements)
            : this( )
        {
            if (childrenElements == null)
            {
                throw new ArgumentNullException("childrenElements");
            }

            foreach (OpenXmlElement child in childrenElements)
            {
                this.AppendChild(child);
            }
        }

        
        /// <summary>
        /// Initializes a new instance of the OpenXmlCompositeElement class using the supplied collection of OpenXmlElement elements.
        /// </summary>
        /// <param name="childrenElements">A collection of OpenXmlElement elements.</param>
        protected OpenXmlCompositeElement(IEnumerable<OpenXmlElement> childrenElements)
            : this()
        {
            if (childrenElements == null)
            {
                throw new ArgumentNullException("childrenElements");
            }

            foreach (OpenXmlElement child in childrenElements)
            {
                this.AppendChild(child);
            }
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlCompositeElement using the supplied array of OpenXmlElement elements.
        /// </summary>
        /// <param name="childrenElements">An array of OpenXmlElement elements.</param>
        protected OpenXmlCompositeElement(params OpenXmlElement[] childrenElements)
            : this()
        {
            if (childrenElements == null)
            {
                throw new ArgumentNullException("childrenElements");
            }

            foreach (OpenXmlElement child in childrenElements)
            {
                this.AppendChild(child);
            }
        }

        #region public properties

        /// <summary>
        /// Gets the first child of the current OpenXmlElement element.
        /// </summary>
        /// <remarks>
        /// Returns null (Nothing in Visual Basic) if there is no such OpenXmlElement element. 
        /// </remarks>
        public override OpenXmlElement FirstChild
        {
            get
            {
                this.MakeSureParsed();

                OpenXmlElement lastChild = this._lastChild;

                if (lastChild != null)
                {
                    return lastChild.next;
                }
                return null;
            }
        }


        /// <summary>
        /// Gets the last child of the current OpenXmlElement element.
        /// Returns null (Nothing in Visual Basic) if there is no such OpenXmlElement element. 
        /// </summary>
        public override OpenXmlElement LastChild
        {
            get
            {
                this.MakeSureParsed();

                return this._lastChild;                
            }
        }

        /// <summary>
        /// Gets a value that indicates whether the current element has any child elements. 
        /// </summary>
        public override bool HasChildren
        {
            get 
            {
                return this.LastChild != null;
            }
        }

        /// <summary>
        /// Gets or sets the concatenated values of the current node and all of its children. 
        /// </summary>
        public override string InnerText
        {
            get
            {
                StringBuilder innerText = new StringBuilder();

                foreach (OpenXmlElement child in this.ChildElements)
                {
                    innerText.Append(child.InnerText);
                }

                return innerText.ToString();
            }
            //set
            //{
            //    throw new InvalidOperationException();
            //}
        }
                
        /// <summary>
        /// Gets or sets the markup that represents only the child nodes of the current node.
        /// </summary>
        public override string InnerXml
        {
            set
            {
                // first, clear all children 
                this.RemoveAllChildren();

                if ( ! String.IsNullOrEmpty(value))
                {
                    // create an outer XML by wrapping the InnerXml with this element.
                    // because XmlReader can not be created on InnerXml ( InnerXml may have several root elements ).

                    StringWriter w = new StringWriter(CultureInfo.InvariantCulture);
                    XmlTextWriter writer2 = new XmlDOMTextWriter(w);
                    try
                    {
                        writer2.WriteStartElement(this.Prefix, this.LocalName, this.NamespaceUri);
                        writer2.WriteRaw(value);
                        writer2.WriteEndElement();
                    }
                    finally
                    {
                        writer2.Close();
                    }

                    // create a temp element to parse the xml.
                    OpenXmlElement newElement = this.CloneNode(false);
                    newElement.OuterXml = w.ToString();

                    OpenXmlElement child = newElement.FirstChild;
                    OpenXmlElement next = null;

                    // then move all children to this element.
                    while (child != null)
                    {
                        next = child.NextSibling();

                        child = newElement.RemoveChild(child);

                        this.AppendChild(child);

                        child = next;
                    }
                }
            }
        }

        #endregion

        #region change children

        /// <summary>
        /// Appends the specified element to the end of the current element's list of child nodes. 
        /// </summary>
        /// <param name="newChild">The OpenXmlElement element to append.</param>
        /// <returns>The OpenXmlElement element that was appended. </returns>
        /// <remarks>Returns null if newChild equals null.</remarks>
        public override T AppendChild<T>(T newChild)
        {
            if (newChild == null)
            {
                // throw new ArgumentNullException("newChild");
                return null;
            }

            if (newChild.Parent != null)
            {
                throw new InvalidOperationException(ExceptionMessages.ElementIsPartOfTree);
            }

            this.ElementInsertingEvent(newChild);

            OpenXmlElement prevNode = this.LastChild;
            OpenXmlElement nextNode = newChild;

            if (prevNode == null)
            {
                nextNode.next = nextNode;
                this._lastChild = nextNode;
            }
            else
            {
                nextNode.next = prevNode.next;
                prevNode.next = nextNode;
                this._lastChild = nextNode;
            } 

            newChild.Parent = this;
            // SetOwner(newChild);

            this.ElementInsertedEvent(newChild);

            return newChild;

        }

        /// <summary>
        /// Inserts the specified element immediately after the specified reference element.
        /// </summary>
        /// <param name="newChild">The OpenXmlElement element to insert.</param>
        /// <param name="refChild">The OpenXmlElement element that is in the reference node.</param>
        /// <returns>The OpenXmlElement element that was inserted.</returns>
        /// <remarks>Returns null if newChild is null. </remarks>
        public override T InsertAfter<T>(T newChild, OpenXmlElement refChild)
        {
            if (newChild == null)
            {
                // throw new ArgumentNullException("newChild");
                return null;
            }

            if (newChild.Parent != null)
            {
                throw new InvalidOperationException(ExceptionMessages.ElementIsPartOfTree);
            }

            if (refChild == null)
            {
                return this.PrependChild(newChild);
            }

            if (refChild.Parent != this)
            {
                throw new InvalidOperationException();
            }

            this.ElementInsertingEvent(newChild);

            OpenXmlElement nextNode = newChild;
            OpenXmlElement prevNode = refChild;

            Debug.Assert(nextNode != null);
            Debug.Assert(prevNode != null);

            if (prevNode == this._lastChild)
            {
                nextNode.next = prevNode.next;
                prevNode.next = nextNode;
                this._lastChild = nextNode;
            }
            else
            {
                OpenXmlElement next = prevNode.next;
                nextNode.next = next;
                prevNode.next = nextNode;
            }

            newChild.Parent = this;
            // SetOwner(newChild);

            this.ElementInsertedEvent(newChild);

            return newChild;
        }

        /// <summary>
        /// Inserts the specified element immediately before the specified reference element.
        /// </summary>
        /// <param name="newChild">The OpenXmlElement to insert.</param>
        /// <param name="refChild">The OpenXmlElement that is in the reference node.</param>
        /// <returns>The OpenXmlElement that was inserted.</returns>
        /// <remarks>Returns null if newChild equals null.</remarks>
        public override T InsertBefore<T>(T newChild, OpenXmlElement refChild)
        {
            if (newChild == null)
            {
                // throw new ArgumentNullException("newChild");
                return null;
            }

            if (newChild.Parent != null)
            {
                throw new InvalidOperationException(ExceptionMessages.ElementIsPartOfTree);
            }

            if (refChild == null)
            {
                return this.AppendChild(newChild);
            }

            if (refChild != null && refChild.Parent != this)
            {
                throw new InvalidOperationException();
            }

            this.ElementInsertingEvent(newChild);

            OpenXmlElement prevNode = newChild;
            OpenXmlElement nextNode = refChild;

            Debug.Assert(nextNode != null);
            Debug.Assert(prevNode != null);

            if (nextNode == this.FirstChild)
            {
                prevNode.next = nextNode;
                this._lastChild.next = prevNode;
            }
            else
            {
                OpenXmlElement previousSibling = nextNode.PreviousSibling();
                prevNode.next = nextNode;
                previousSibling.next = prevNode;
            }

            newChild.Parent = this;
            // SetOwner(newChild);

            this.ElementInsertedEvent(newChild);

            return newChild;
        }

        /// <summary>
        /// Inserts the specified element at the specified index of the current element's children.
        /// </summary>
        /// <param name="newChild">The OpenXmlElement element to insert.</param>
        /// <param name="index">The zero-based index to insert the element to.</param>
        /// <returns>The OpenXmlElement element that was inserted.</returns>
        /// <remarks>Returns null if newChild equals null.</remarks>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when index is less than 0 or is greater than the count of children.</exception>
        public override T InsertAt<T>(T newChild, int index)
        {
            if (newChild == null)
            {
                // throw new ArgumentNullException("newChild");
                return null;
            }

            if (newChild.Parent != null)
            {
                throw new InvalidOperationException(ExceptionMessages.ElementIsPartOfTree);
            }

            if (index < 0 || index > this.ChildElements.Count)
            {
                throw new ArgumentOutOfRangeException("index");
            }
            else if ( index == 0 )
            {
                return this.PrependChild(newChild);
            }
            else if ( index == this.ChildElements.Count )
            {
                return this.AppendChild(newChild);
            }
            else
            {
                OpenXmlElement refChild = this.ChildElements[index];
                return this.InsertBefore(newChild, refChild);
            }
        }

        /// <summary>
        /// Inserts the specified element at the beginning of the current element's list of child nodes. 
        /// </summary>
        /// <param name="newChild">The OpenXmlElement element to add.</param>
        /// <returns>The OpenXmlElement that was added.</returns>
        /// <remarks>Returns null if newChild equals null.</remarks>
        public override T PrependChild<T>(T newChild)
        {
            if (newChild == null)
            {
                //throw new ArgumentNullException("newChild");
                return null;
            }

            if (newChild.Parent != null)
            {
                throw new InvalidOperationException(ExceptionMessages.ElementIsPartOfTree);
            }

            return this.InsertBefore(newChild, this.FirstChild);
        }
        
        /// <summary>
        /// Removes the specified child element. 
        /// </summary>
        /// <param name="oldChild">The element to remove. </param>
        /// <returns>The element that was removed. </returns>
        /// <remarks>Returns null if newChild equals null. </remarks>
        public override T RemoveChild<T>(T oldChild)
        {
            if (oldChild == null)
            {
                // throw new ArgumentNullException("oldChild");
                return null;
            }

            if (oldChild.Parent != this)
            {
                throw new InvalidOperationException(ExceptionMessages.ElementIsNotChild);
            }

            T removedElement = oldChild;
            OpenXmlElement last = this._lastChild;

            this.ElementRemovingEvent(removedElement);

            if (removedElement == this.FirstChild)
            {
                if (removedElement == this._lastChild)
                {
                    this._lastChild = null;
                }
                else
                {
                    OpenXmlElement nextNode = removedElement.next;
                    last.next = nextNode;
                }
            }
            else if (removedElement == this._lastChild)
            {
                OpenXmlElement prevNode = removedElement.PreviousSibling();
                OpenXmlElement next = removedElement.next;
                prevNode.next = next;
                this._lastChild = prevNode;
            }
            else
            {
                OpenXmlElement prevNode = removedElement.PreviousSibling();
                OpenXmlElement next = removedElement.next;

                prevNode.next = next;
            }

            //foreach (OpenXmlElement descendant in removedElement.Descendants())
            //{
            //    descendant.Owner = null;
            //}

            removedElement.next = null;
            removedElement.Parent = null;
            //removedElement.Owner = null;

            this.ElementRemovedEvent(removedElement);

            return removedElement;
        }

        /// <summary>
        /// Removes all of the current element's child elements.
        /// </summary>
        public override void RemoveAllChildren()
        {
            OpenXmlElement element = this.FirstChild;
            while (element != null)
            {
                OpenXmlElement next = element.NextSibling();

                this.RemoveChild(element);

                element = next;
            }

            Debug.Assert(this._lastChild == null);
        }

        /// <summary>
        /// Replaces one of the current element's child elements with another OpenXmlElement element.
        /// </summary>
        /// <param name="newChild">The new OpenXmlElement to put in the child list.</param>
        /// <param name="oldChild">The OpenXmlElement to be replaced in the child list.</param>
        /// <returns>The OpenXmlElement that was replaced.</returns>
        /// <remarks>Returns null if newChild equals null.</remarks>
        public override T ReplaceChild<T>(OpenXmlElement newChild, T oldChild)
        {
            if (oldChild == null)
            {
                //throw new ArgumentNullException("oldChild");
                return null;
            }

            if (newChild == null)
            {
                throw new ArgumentNullException("newChild");
            }

            if (oldChild.Parent != this)
            {
                throw new InvalidOperationException(ExceptionMessages.ElementIsNotChild);
            }

            if (newChild.Parent != null)
            {
                throw new InvalidOperationException(ExceptionMessages.ElementIsPartOfTree);
            }

            OpenXmlElement refChild = oldChild.NextSibling();
            this.RemoveChild(oldChild);
            this.InsertBefore(newChild, refChild);
            return oldChild;
        }

        #endregion

        /// <summary>
        /// Saves all of the current node's children to the specified XmlWriter. 
        /// </summary>
        /// <param name="w">The XmlWriter at which to save the child nodes. </param>
        internal override void WriteContentTo(XmlWriter w)
        {
            if (this.HasChildren)
            {
                foreach (OpenXmlElement childElement in this.ChildElements)
                {
                    childElement.WriteTo(w);
                }
            }
        }

        #region Event mechanism

        /// <summary>
        /// Fires the ElementInserting event.
        /// </summary>
        /// <param name="element">The OpenXmlElement element to insert.</param>
        internal void ElementInsertingEvent(OpenXmlElement element)
        {
            if (this.OpenXmlElementContext != null)
            {
                this.OpenXmlElementContext.ElementInsertingEvent(element, this);
            }
        }

        /// <summary>
        /// Fires the ElementInserted event.
        /// </summary>
        /// <param name="element">The OpenXmlElement element to insert.</param>
        internal void ElementInsertedEvent(OpenXmlElement element)
        {
            if (this.OpenXmlElementContext != null)
            {
                this.OpenXmlElementContext.ElementInsertedEvent(element, this);
            }
        }

        /// <summary>
        /// Fires the ElementRemoving event.
        /// </summary>
        /// <param name="element">The OpenXmlElement element to remove.</param>
        internal void ElementRemovingEvent(OpenXmlElement element)
        {
            if (this.OpenXmlElementContext != null)
            {
                this.OpenXmlElementContext.ElementRemovingEvent(element, this);
            }
        }

        /// <summary>
        /// Fires the ElementRemoved event.
        /// </summary>
        /// <param name="element">The OpenXmlElement element to be removed.</param>
        internal void ElementRemovedEvent(OpenXmlElement element)
        {
            if (this.OpenXmlElementContext != null)
            {
                this.OpenXmlElementContext.ElementRemovedEvent(element, this);
            }
        }

        #endregion

        #region internal methods

        /// <summary>
        /// Populates the XML into a strong typed DOM tree.
        /// </summary>
        /// <param name="xmlReader">The XmlReader to read the XML content.</param>
        /// <param name="loadMode">Specifies a load mode that is either lazy or full.</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        internal override void Populate(XmlReader xmlReader, OpenXmlLoadMode loadMode)
        {
            LoadAttributes(xmlReader);
            
            if (!xmlReader.IsEmptyElement)
            {
                xmlReader.Read(); // read this element 

                while (!xmlReader.EOF)
                {
                    // O15:#3024890, OpenXmlCompositElement ignores the Whitespace NodeType.
                    if (xmlReader.NodeType == XmlNodeType.Whitespace)
                    {
                        xmlReader.Skip();
                        continue;
                    }
                    else if (xmlReader.NodeType == XmlNodeType.EndElement)
                    {
                        Debug.Assert(xmlReader.LocalName.Equals(this.LocalName));
                        xmlReader.Skip(); // move to next node
                        break;
                    }

                    OpenXmlElement element = this.ElementFactory(xmlReader);

                    // set parent before Load( ) call. AlternateContentChoice need parent info on loading.
                    element.Parent = this;

                    bool isACB = element is AlternateContent;
                    if (isACB && element.OpenXmlElementContext != null)
                    {
                        element.OpenXmlElementContext.ACBlockLevel++;
                    }

                    bool mcContextPushed = false;
                    if (!(element is OpenXmlMiscNode))
                    {
                        // push MC context based on the context of the child element to be loaded 
                        mcContextPushed = this.PushMcContext(xmlReader);
                    }
                    
                    //Process the element according to the MC behavior
                    var action = ElementAction.Normal;
                    if (OpenXmlElementContext != null && OpenXmlElementContext.MCSettings.ProcessMode != DocumentFormat.OpenXml.Packaging.MarkupCompatibilityProcessMode.NoProcess)
                    {
                        action = OpenXmlElementContext.MCContext.GetElementAction(element, OpenXmlElementContext.MCSettings.TargetFileFormatVersions);
                    }

                    element.Load(xmlReader, loadMode);

                    if (mcContextPushed)
                    {
                        this.PopMcContext();
                    }

                    if (isACB && element.OpenXmlElementContext != null)
                    {
                        element.OpenXmlElementContext.ACBlockLevel--;
                    }

                    switch (action)
                    {
                        case ElementAction.Normal:
                            {
                                AddANode(element);
                                break;
                            }
                        case ElementAction.Ignore:
                            {
                                element.Parent = null;
                                continue;
                            }
                        case ElementAction.ProcessContent:
                            {
                                element.Parent = null;
                                while(element.ChildElements.Count > 0)
                                {
                                    var node = element.FirstChild;
                                    node.Remove();
                                    OpenXmlElement newnode = null;
                                    //if node is an UnknowElement, we should try to see whether the parent element can load the node as strong typed element
                                    if (node is OpenXmlUnknownElement)
                                    {
                                        newnode = this.ElementFactory(node.Prefix, node.LocalName, node.NamespaceUri);
                                        if (!(newnode is OpenXmlUnknownElement))
                                        {
                                            //the following method will load teh element in MCMode.Full
                                            //since the node is already MC-processed when loading as unknown type, full loading the outerXml is fine
                                            newnode.OuterXml = node.OuterXml;
                                            //unnecessary xmlns attr will be added, remove it.
                                            RemoveUnnecessaryExtAttr(node, newnode);
                                        }
                                        else
                                        {
                                            newnode = null;
                                        }
                                    }
                                    if (newnode != null)
                                    {
                                        AddANode(newnode);
                                    }
                                    else
                                    {
                                        //append the orignal node
                                        AddANode(node);
                                    }
                                }
                                break;
                            }
                        case ElementAction.ACBlock:
                            {
                                var effectiveNode = OpenXmlElementContext.MCContext.GetContentFromACBlock(element as AlternateContent, OpenXmlElementContext.MCSettings.TargetFileFormatVersions);
                                if (effectiveNode == null)
                                {
                                    break;
                                }
                                element.Parent = null;
                                effectiveNode.Parent = null;
                                while(effectiveNode.FirstChild != null)
                                {
                                    var node = effectiveNode.FirstChild;
                                    node.Remove();
                                    AddANode(node);
                                    node.CheckMustUnderstandAttr();
                                }
                                break;
                            }
                    }
                }
            }
            else
            {
                xmlReader.Skip();
            }

            // set raw outer xml to empty to indicate that it is pased
            this.RawOuterXml = string.Empty;
        }

        private static void RemoveUnnecessaryExtAttr(OpenXmlElement node, OpenXmlElement newnode)
        {
            //re-construct the _nsMappings for newnode based on the orignal node
            node.MakeSureParsed();
            if (newnode.NamespaceDeclField != null && node.NamespaceDeclField != null)
            {
                newnode.NamespaceDeclField = new List<KeyValuePair<string, string>>(node.NamespaceDeclField);
            }
        }

        /// <summary>
        /// Gets the tag names of the child elements.
        /// </summary>
        /// <remarks>
        /// This property is overriden in generated classes.
        /// </remarks>
        internal virtual string[] ElementTagNames
        {
            get { return null; }
        }

        /// <summary>
        /// Gets the namespace IDs of the child elements.
        /// </summary>
        /// <remarks>
        /// This property is overriden in generated classes.
        /// </remarks>
        internal virtual byte[] ElementNamespaceIds
        {
            get { return null; }
        }

        private int GetSequenceNumber( OpenXmlElement child )
        {
            for (int i = 0; i < this.ElementNamespaceIds.Length; i++)
            {
                if (this.ElementNamespaceIds[i] == child.NamespaceId && Object.Equals(this.ElementTagNames[i], child.LocalName))
                {
                    return i;
                }
            }

            return -1;
        }

        /// <summary>
        /// Gets the child element that has the specified sequence number.
        /// Sequence numbers are generated by a code generator.
        /// </summary>
        /// <param name="sequenceNumber">The sequence number of the element.</param>
        /// <returns>An element that has the specified sequence number. Returns null (Nothing in Visual Basic) if no element is found having the specified sequence number.</returns>
        /// <remarks>
        /// Returns null if there are invalid children.
        /// </remarks>
        internal T GetElement<T>(int sequenceNumber) where T : OpenXmlElement
        {
            T theChild;
            switch (this.OpenXmlCompositeType)
            {
                case OpenXmlCompositeType.Other:
                    throw new InvalidOperationException();

                case OpenXmlCompositeType.OneAll:
                    foreach (OpenXmlElement child in this.ChildElements)
                    {
                        // skip unknown element and MiscNode
                        if (OpenXmlElement.IsKnownElement(child))
                        {
                            int childSequenceNumber = this.GetSequenceNumber(child);
                            if (childSequenceNumber == sequenceNumber)
                            {
                                theChild = child as T;
                                if (theChild != null)
                                {
                                    return theChild;
                                }
                            }
                        }
                    }

                    // TODO: should we handle error case?
                    //  1: there are more than 1 elements for a type?
                    //  2: there are more than 2 elements?
                    //  3. there are other elements other than allowed children?

                    break;

                case OpenXmlCompositeType.OneChoice:
                    {
                        OpenXmlElement child = this.FirstChild;

                        // skip unknown element and MiscNode
                        while (child != null && !OpenXmlElement.IsKnownElement(child))
                        {
                            child = child.NextSibling();
                        }

                        // There should be only one valide child.
                        if (child != null)
                        {
                            Debug.Assert(OpenXmlElement.IsKnownElement(child));

                            int childSequenceNumber = this.GetSequenceNumber(child);
                            if (childSequenceNumber == sequenceNumber)
                            {
                                theChild = child as T;
                                if (theChild != null)
                                {
                                    return theChild;
                                }
                            }
                        }
                    }

                    // TODO: should we handle error case?
                    //  1: there are more than 1 elements for a type?
                    //  2: there are more than 2 elements?
                    //  3. there are other elements other than allowed children?

                    break;

                case OpenXmlCompositeType.OneSequence:
                    {
                        OpenXmlElement child = this.FirstChild;

                        while (child != null)
                        {
                            if (OpenXmlElement.IsKnownElement(child))
                            {
                                int childSequenceNumber = this.GetSequenceNumber(child);

                                if (childSequenceNumber == sequenceNumber)
                                {
                                    theChild = child as T;
                                    if (theChild != null)
                                    {
                                        return theChild;
                                    }
                                    else
                                    {
                                        // same tag name, but wrong type, see bug 448241
                                        child = child.NextSibling();
                                    }
                                }
                                else if (childSequenceNumber > sequenceNumber)
                                {
                                    return null;
                                }
                                else
                                {
                                    child = child.NextSibling();
                                }
                            }
                            else
                            {
                                // skip unknown element and MiscNode
                                child = child.NextSibling();
                            }
                            
                        }
                    }

                    // TODO: should we handle error case?
                    //  1: there are more than 1 elements for a type?
                    //  2: there are more than 2 elements?
                    //  3. there are other elements other than allowed children?
                    
                    break;

            }
            return null;
        }

        internal void SetElement<T>(int sequenceNumber, T newChild) where T : OpenXmlElement
        {
            switch (this.OpenXmlCompositeType)
            {
                case OpenXmlCompositeType.Other:
                    throw new InvalidOperationException();

                case OpenXmlCompositeType.OneAll:
                    {
                        T child = this.GetElement<T>(sequenceNumber);
                        if (child != null)
                        {
                            // remove the old one
                            this.RemoveChild(child);
                        }
                        if (newChild != null)
                        {
                            this.AppendChild(newChild);
                        }
                    }


                    // TODO: should we handle error case?
                    //  1: there are more than 1 elements for a type?
                    //  2: there are more than 2 elements?
                    //  3. there are other elements other than allowed children?
                    
                    break;

                case OpenXmlCompositeType.OneChoice:
                    {
                        OpenXmlElement child = this.FirstChild;
                        OpenXmlElement previousChild = null;

                        // skip unknown element and MiscNode
                        while (child != null && !OpenXmlElement.IsKnownElement(child))
                        {
                            previousChild = child;
                            child = child.NextSibling();
                        }

                        OpenXmlElement next = null;
                        while (child != null)
                        {
                            next = child.NextSibling();

                            // remove all exist elements
                            if (OpenXmlElement.IsKnownElement(child))
                            {
                                this.RemoveChild(child);
                            }

                            child = next;
                        }

                        if (newChild != null)
                        {
                            this.InsertAfter(newChild, previousChild);
                        }
                    }


                    // TODO: should we handle error case?
                    //  1: there are more than 1 elements for a type?
                    //  2: there are more than 2 elements?
                    //  3. there are other elements other than allowed children?
                    
                    break;

                case OpenXmlCompositeType.OneSequence:
                    {
                        OpenXmlElement child = this.FirstChild;
                        OpenXmlElement prev = null;

                        while (child != null)
                        {
                            if (OpenXmlElement.IsKnownElement(child))
                            {
                                int childSequenceNumber = this.GetSequenceNumber(child);

                                if (childSequenceNumber == sequenceNumber)
                                {
                                    // remove the old one
                                    if (child is T)
                                    {
                                        // insert the new element after the previous.
                                        prev = child.PreviousSibling();
                                        this.RemoveChild(child);
                                        break;
                                    }
                                    else
                                    {
                                        // same tag name, but wrong type, see bug 448241
                                        prev = child;
                                    }
                                }
                                else if (childSequenceNumber > sequenceNumber)
                                {
                                    break;
                                }
                                else
                                {                               
                                    // always insert after the first known element
                                    prev = child;

                                    // continue search
                                }
                            }

                            // continue search
                            child = child.NextSibling();
                        }

                        if (newChild != null)
                        {
                            this.InsertAfter(newChild, prev);
                        }
                    }


                    // TODO: should we handle error case?
                    //  1: there are more than 1 elements for a type?
                    //  2: there are more than 2 elements?
                    //  3. there are other elements other than allowed children?
                    
                    break;

            }
        }

        internal virtual OpenXmlCompositeType OpenXmlCompositeType
        {
            get { return OpenXmlCompositeType.Other; }
        }

        #endregion

        #region private methods
        private void AddANode(OpenXmlElement node)
        {
            node.Parent = this;
            if (this._lastChild == null)
            {
                node.next = node;
                this._lastChild = node;
            }
            else
            {
                node.next = this._lastChild.next;
                this._lastChild.next = node;
                this._lastChild = node;
            }
        }

        //private void SetOwner(OpenXmlElement element)
        //{
        //    element.Owner = this.Owner;

        //    if (element.XmlParsed)
        //    {
        //        foreach (OpenXmlElement child in element.ChildElements)
        //        {
        //            SetOwner(child);
        //        }
        //    }
        //}

        #endregion 
    }
}
