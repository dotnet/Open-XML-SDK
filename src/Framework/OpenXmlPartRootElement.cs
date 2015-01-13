// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml;
using System.Diagnostics;
using DocumentFormat.OpenXml.Packaging;


namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Represents a base class for all root elements.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    public abstract class OpenXmlPartRootElement : OpenXmlCompositeElement
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private OpenXmlElementContext _elementContext;
        // private object _owner;

        private bool? _standaloneDeclaration = null;

        ///// <summary>
        ///// The OpenXmlPart which the DOM is loaded from.
        ///// </summary>
        //public OpenXmlPart OpenXmlPart
        //{
        //    get
        //    {
        //        return this.OpenXmlOwner.OwnerPart;
        //    }
        //}

        /// <summary>
        /// Initializes a new instance of the OpenXmlPartRootElement class.
        /// </summary>
        protected OpenXmlPartRootElement()
        {
            this._elementContext = new OpenXmlElementContext();
        }


        /// <summary>
        /// Initializes a new instance of the OpenXmlPartRootElement class using the supplied OpenXmlPart.
        /// </summary>
        /// <param name="openXmlPart">The OpenXmlPart class.</param>
        protected OpenXmlPartRootElement(OpenXmlPart openXmlPart)
        {
            if (openXmlPart == null)
            {
                throw new ArgumentNullException("openXmlPart");
            }

            this._elementContext = new OpenXmlElementContext();
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlPartRootElement class using the supplied outer XML.
        /// </summary>
        /// <param name="outerXml">The outer XML of the element.</param>
        protected OpenXmlPartRootElement(string outerXml)
            : base(outerXml)
        {
            this._elementContext = new OpenXmlElementContext();
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlPartRootElement class using the supplied list of child elements.
        /// </summary>
        /// <param name="childElements">All child elements.</param>
        protected OpenXmlPartRootElement(IEnumerable<OpenXmlElement> childElements)
            : base(childElements)
        {
            this._elementContext = new OpenXmlElementContext();
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlPartRootElement class using the supplied array of child elements.
        /// </summary>
        /// <param name="childElements">All child elements</param>
        protected OpenXmlPartRootElement(params OpenXmlElement[] childElements)
            : base(childElements)
        {
            this._elementContext = new OpenXmlElementContext();
        }

        /// <summary>
        /// Gets the OpenXmlEementContext.
        /// </summary>
        internal override OpenXmlElementContext RootElementContext
        {
            get { return this._elementContext; }
        }

        /// <summary>
        /// Load the DOM tree from the Open XML part.
        /// </summary>
        /// <param name="openXmlPart">The part this root element to be loaded from.</param>
        /// <exception cref="InvalidDataException">Thrown when the part contains an incorrect root element.</exception>
        internal void LoadFromPart(OpenXmlPart openXmlPart)
        {
            using (Stream partStream = openXmlPart.GetStream(FileMode.Open))
            {
                this.LoadFromPart(openXmlPart, partStream);
            }
        }

        /// <summary>
        /// Load the DOM tree from the Open XML part.
        /// </summary>
        /// <param name="openXmlPart">The part this root element to be loaded from.</param>
        /// <param name="partStream">The stream of the part.</param>
        /// <returns>
        /// Returns true when the part stream is loaded successfully into this root element.
        /// Returns false when the part stream does not contain any xml element.
        /// </returns>
        /// <exception cref="InvalidDataException">Thrown when the part stream contains an incorrect root element.</exception>
        internal bool LoadFromPart(OpenXmlPart openXmlPart, Stream partStream)
        {
            Profiler.CommentMarkProfile(Profiler.MarkId.OpenXmlPartRootElement_LoadFromPart_In);

            if (partStream.Length < 4)
            {
                // The XmlReader.Read() method requires at least four bytes from the data stream in order to begin parsing. 
                return false;
            }

            // set MaxCharactersInDocument to limit the part size on loading DOM.
            this.OpenXmlElementContext.XmlReaderSettings.MaxCharactersInDocument = openXmlPart.MaxCharactersInPart;
            this.OpenXmlElementContext.XmlReaderSettings.DtdProcessing = DtdProcessing.Prohibit; // set true explicitly for security fix

            using (XmlReader xmlReader = XmlConvertingReaderFactory.Create(partStream, this.OpenXmlElementContext.XmlReaderSettings, openXmlPart.OpenXmlPackage.StrictTranslation))
            {
                this.OpenXmlElementContext.MCSettings = openXmlPart.MCSettings;


                xmlReader.Read();

                if (xmlReader.NodeType == XmlNodeType.XmlDeclaration)
                {
                    string standaloneAttribute = xmlReader.GetAttribute("standalone");
                    if (standaloneAttribute != null)
                    {
                        this._standaloneDeclaration = standaloneAttribute.Equals("yes", StringComparison.OrdinalIgnoreCase);
                    }
                }

                if (!xmlReader.EOF)
                {
                    xmlReader.MoveToContent();
                }

                if (xmlReader.EOF ||
                    XmlNodeType.Element != xmlReader.NodeType ||
                    !xmlReader.IsStartElement())
                {
                    //the stream does NOT contains any xml element.
                    return false;
                }

                byte nsId;

                if (!NamespaceIdMap.TryGetNamespaceId(xmlReader.NamespaceURI, out nsId) ||
                    nsId != this.NamespaceId ||
                    xmlReader.LocalName != this.LocalName)
                {
                    string elementQName = new XmlQualifiedName(xmlReader.LocalName, xmlReader.NamespaceURI).ToString();
                    string msg = String.Format(System.Globalization.CultureInfo.CurrentUICulture, ExceptionMessages.Fmt_PartRootIsInvalid, elementQName, this.XmlQualifiedName.ToString());
                    throw new InvalidDataException(msg);
                }

                // remove all children and clear all attributes
                this.OuterXml = string.Empty;
                var mcContextPushed = this.PushMcContext(xmlReader);
                this.Load(xmlReader, this.OpenXmlElementContext.LoadMode);
                if (mcContextPushed)
                {
                    this.PopMcContext();
                }
            }

            Profiler.CommentMarkProfile(Profiler.MarkId.OpenXmlPartRootElement_LoadFromPart_Out);

            return true;
        }

        internal void LoadFromPart(OpenXmlPart openXmlPart, OpenXmlLoadMode loadMode)
        {
            this.OpenXmlElementContext.LoadMode = loadMode;
            this.LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Save the DOM into the OpenXML part.
        /// </summary>
        internal void SaveToPart(OpenXmlPart openXmlPart)
        {
            if (openXmlPart == null)
            {
                throw new ArgumentNullException("openXmlPart");
            }

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.CloseOutput = true;
            // default is UTF8, Indent=false, OmitXmlDeclaration=false, NewLineOnAttributes=false
            // settings.Indent = false;
            // settings.Encoding = Encoding.UTF8;
            // settings.OmitXmlDeclaration = false;
            // settings.NewLineOnAttributes = false;

            using (Stream partStream = openXmlPart.GetStream(FileMode.Create))
            using (XmlWriter xmlWriter = XmlWriter.Create(partStream, settings))
            {
                if (this._standaloneDeclaration != null)
                {
                    xmlWriter.WriteStartDocument(this._standaloneDeclaration.Value);
                }

                this.WriteTo(xmlWriter);

                // fix bug #242463.
                // Do not call WriteEndDocument if this root element is not parsed.
                // In that case, the WriteTo() just call WriteRaw() with the raw xml, so no WriteStartElement() be called.
                // So, the XmlWriter still on document start state. Call WriteEndDocument() will cause exception.

                if (this.XmlParsed)
                {
                    xmlWriter.WriteEndDocument();
                }
            }
        }

        /// <summary>
        /// Saves the DOM tree to the specified stream.
        /// </summary>
        /// <param name="stream">
        /// The stream to which to save the XML.
        /// </param>
        public void Save(Stream stream)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.CloseOutput = true;

            using (XmlWriter xmlWriter = XmlWriter.Create(stream, settings))
            {
                if (this._standaloneDeclaration != null)
                {
                    xmlWriter.WriteStartDocument(this._standaloneDeclaration.Value);
                }

                this.WriteTo(xmlWriter);

                // fix bug #242463.
                // Do not call WriteEndDocument if this root element is not parsed.
                // In that case, the WriteTo() just call WriteRaw() with the raw xml, so no WriteStartElement() be called.
                // So, the XmlWriter still on document start state. Call WriteEndDocument() will cause exception.

                if (this.XmlParsed)
                {
                    xmlWriter.WriteEndDocument();
                }
            }
        }

        /// <summary>
        /// Get / set the part that is associated with the DOM tree.
        /// It returns null when the DOM tree is not associated with a part.
        /// </summary>
        internal OpenXmlPart OpenXmlPart
        {
            get;
            set;
        }

        /// <summary>
        /// Saves the data in the DOM tree back to the part. This method can
        /// be called multiple times and each time it is called, the stream
        /// will be flushed.
        /// </summary>
        /// <remarks>
        /// Call this method explicitly to save the changes in the DOM tree.
        /// </remarks>
        /// <exception cref="InvalidOperationException">Thrown when the tree is not associated with a part.</exception>
        public void Save()
        {
            if (this.OpenXmlPart == null)
            {
                throw new InvalidOperationException(ExceptionMessages.CannotSaveDomTreeWithoutAssociatedPart);
            }

            this.SaveToPart(this.OpenXmlPart);
        }

        /// <summary>
        /// Reloads the part content into an Open XML DOM tree. This method can
        /// be called multiple times and each time it is called, the tree will
        /// be reloaded and previous changes on the tree are abandoned.
        /// </summary>
        /// <exception cref="InvalidOperationException">Thrown when the tree is not associated with a part.</exception>
        public void Reload()
        {
            if (this.OpenXmlPart == null)
            {
                throw new InvalidOperationException(ExceptionMessages.CannotReloadDomTreeWithoutAssociatedPart);
            }

            this.LoadFromPart(this.OpenXmlPart);
        }

        /// <summary>
        /// Saves the current node to the specified XmlWriter. 
        /// </summary>
        /// <param name="xmlWriter">
        /// The XmlWriter to which to save the current node.
        /// </param>
        public override void WriteTo(XmlWriter xmlWriter)
        {
            if (xmlWriter == null)
            {
                throw new ArgumentNullException("xmlWriter");
            }

            if (this.XmlParsed)
            {
                //check the namespace mapping defined in this node first. because till now xmlWriter don't know the mapping defined in the current node.
                string prefix = LookupNamespaceLocal(this.NamespaceUri);
                
                //if not defined in the current node, try the xmlWriter
                if (this.Parent != null && string.IsNullOrEmpty(prefix))
                {
                    prefix = xmlWriter.LookupPrefix(this.NamespaceUri);
                }
                //if xmlWriter didn't find it, it means the node is constructed by user and is not in the tree yet
                //in this case, we use the predefined prefix
                if (string.IsNullOrEmpty(prefix))
                {
                    prefix = NamespaceIdMap.GetNamespacePrefix(this.NamespaceId);
                }

                xmlWriter.WriteStartElement(prefix, this.LocalName, this.NamespaceUri);
                // fix bug #225919, write out all namespace into to root 
                WriteNamespaceAtributes(xmlWriter);
                this.WriteAttributesTo(xmlWriter);

                if (this.HasChildren || !string.IsNullOrEmpty(this.InnerText))
                {
                    this.WriteContentTo(xmlWriter);
                    xmlWriter.WriteFullEndElement();
                }
                else
                {
                    xmlWriter.WriteEndElement();
                }
            }
            else
            {
                xmlWriter.WriteRaw(this.RawOuterXml);
            }
        }

        private void WriteNamespaceAtributes(XmlWriter xmlWrite)
        {
            if (WriteAllNamespaceOnRoot)
            {
                Dictionary<string, string> namespaces = new Dictionary<string, string>();

                foreach (OpenXmlElement element in this.Descendants())
                {
                    if (element.NamespaceDeclField != null)
                    {
                        foreach (var item in element.NamespaceDeclField)
                        {
                            if (!namespaces.ContainsKey(item.Key))
                            {
                                namespaces.Add(item.Key, item.Value);
                            }
                        }
                    }
                }

                foreach (var namespacePair in namespaces)
                {
                    if (!String.IsNullOrEmpty(namespacePair.Key))
                    {
                        if (NamespaceDeclField != null && 
                            string.IsNullOrEmpty(this.LookupPrefixLocal(namespacePair.Value)) &&
                            string.IsNullOrEmpty(this.LookupNamespaceLocal(namespacePair.Key))) 
                        {
                            xmlWrite.WriteAttributeString(OpenXmlElementContext.xmlnsPrefix, namespacePair.Key, OpenXmlElementContext.xmlnsUri, namespacePair.Value);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// If this property is true, then the Save method will try write all namespace declation on the root element.
        /// </summary>
        internal virtual bool WriteAllNamespaceOnRoot
        {
            get { return true; }
        }
    }
}
