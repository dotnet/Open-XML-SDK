// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Text;
using DocumentFormat.OpenXml.Packaging;
using System.Xml;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Office.Word;
using System.IO;
using DocumentFormat.OpenXml.Wordprocessing;

namespace DocumentFormat.OpenXml.Bibliography
{
    /// <summary>
    /// Defines Sources.
    /// </summary>
    public partial class Sources : OpenXmlPartRootElement
    {
        /// <summary>
        /// Sources constructor.
        /// </summary>
        /// <param name="ownerPart">The owner part of the Sources.</param>
        internal Sources(CustomXmlPart ownerPart)
            : base(ownerPart)
        {
            
        }

        /// <summary>
        /// Loads the DOM from an OpenXML part.
        /// </summary>
        /// <param name="openXmlPart">The part to be loaded.</param>
        public void Load(CustomXmlPart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }
 
        /// <summary>
        /// Saves the DOM into the OpenXML part.
        /// </summary>
        /// <param name="openXmlPart">The part to be saved to.</param>
        public void Save(CustomXmlPart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }
    }
}

namespace DocumentFormat.OpenXml.AdditionalCharacteristics
{
    /// <summary>
    /// Defines AdditionalCharacteristics.
    /// </summary>
    public partial class AdditionalCharacteristicsInfo : OpenXmlPartRootElement
    {
        /// <summary>
        /// AdditionalCharacteristics constructor.
        /// </summary>
        /// <param name="ownerPart">The owner part of the AdditionalCharacteristics.</param>
        internal AdditionalCharacteristicsInfo(CustomXmlPart ownerPart)
            : base(ownerPart)
        {
            
        }

        /// <summary>
        /// Loads the DOM from an OpenXML part.
        /// </summary>
        /// <param name="openXmlPart">The part to be loaded.</param>
        public void Load(CustomXmlPart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }
 
        /// <summary>
        /// Saves the DOM into the OpenXML part.
        /// </summary>
        /// <param name="openXmlPart">The part to be saved to.</param>
        public void Save(CustomXmlPart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }
    }
}

namespace DocumentFormat.OpenXml.Office.CustomUI
{
    /// <summary>
    /// Defines CustomUI.
    /// </summary>
    public partial class CustomUI : OpenXmlPartRootElement
    {
        /// <summary>
        /// CustomUI constructor.
        /// </summary>
        /// <param name="ownerPart">The owner part of the CustomUI.</param>
        internal CustomUI(CustomUIPart ownerPart)
            : base(ownerPart)
        {
            
        }

        /// <summary>
        /// Loads the DOM from an OpenXML part.
        /// </summary>
        /// <param name="openXmlPart">The part to be loaded.</param>
        public void Load(CustomUIPart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }
 
        /// <summary>
        /// Saves the DOM into the OpenXML part.
        /// </summary>
        /// <param name="openXmlPart">The part to be saved to.</param>
        public void Save(CustomUIPart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the CustomUIPart associated with this element, it could either be a QuickAccessToolbarCustomizationsPart or a RibbonExtensibilityPart.
        /// </summary>
        public CustomUIPart CustomUIPart
        {
            get
            {
                return OpenXmlPart as CustomUIPart;
            }
            internal set
            {
                OpenXmlPart = value;
            }
        }
    }
}

namespace DocumentFormat.OpenXml.InkML
{
    /// <summary>
    /// Defines Ink.
    /// </summary>
    public partial class Ink : OpenXmlPartRootElement
    {
        /// <summary>
        /// Ink constructor.
        /// </summary>
        /// <param name="ownerPart">The owner part of the Ink.</param>
        internal Ink(CustomXmlPart ownerPart)
            : base(ownerPart)
        {
            
        }

        /// <summary>
        /// Loads the DOM from an OpenXML part.
        /// </summary>
        /// <param name="openXmlPart">The part to be loaded.</param>
        public void Load(CustomXmlPart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }
 
        /// <summary>
        /// Saves the DOM into the OpenXML part.
        /// </summary>
        /// <param name="openXmlPart">The part to be saved to.</param>
        public void Save(CustomXmlPart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }
    }
}
namespace DocumentFormat.OpenXml.Wordprocessing
{
    /// <summary>
    /// Defines Styles.
    /// </summary>
    public partial class Styles : OpenXmlPartRootElement
    {
        /// <summary>
        /// Styles constructor.
        /// </summary>
        /// <param name="ownerPart">The owner part of the Styles.</param>
        internal Styles(StylesPart ownerPart)
            : base(ownerPart)
        {

        }

        /// <summary>
        /// Loads the DOM from an OpenXML part.
        /// </summary>
        /// <param name="openXmlPart">The part to be loaded.</param>
        public void Load(StylesPart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the OpenXML part.
        /// </summary>
        /// <param name="openXmlPart">The part to be saved to.</param>
        public void Save(StylesPart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the StylesPart associated with this element, it could either be a StyleDefinitionsPart or a StylesWithEffectsPart.
        /// </summary>
        public StylesPart StylesPart
        {
            get
            {   
                return OpenXmlPart as StylesPart;
            }
            internal set
            {
                OpenXmlPart = value;
            }
        }
    }

    /// <summary>
    /// Defines SdtElement - the base class for the sdt elements.
    /// </summary>
    public abstract class SdtElement : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SdtElement class.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected SdtElement(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements) : base(childElements) 
        { 
        }

        /// <summary>
        /// Initializes a new instance of the SdtElement class.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected SdtElement(params OpenXmlElement[] childElements)
            : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SdtElement class.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        protected SdtElement(string outerXml)
            : base(outerXml)
        {
        }

        /// <summary>
        /// Gets/Sets the SdtProperties.
        /// </summary>
        public SdtProperties SdtProperties
        {
            get
            {
                return GetElement<SdtProperties>(0);
            }
            set
            {
                this.SetElement(0, value);
            }
        }

        /// <summary>
        /// Gets/Sets the SdtEndCharProperties.
        /// </summary>
        public SdtEndCharProperties SdtEndCharProperties
        {
            get
            {
                return GetElement<SdtEndCharProperties>(1);
            }
            set
            {
                this.SetElement(1, value);
            }
        }
    }

    /// <summary>
    /// Defines CustomXmlElement - the base class for the customXml elements.
    /// </summary>
    public abstract class CustomXmlElement : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the CustomXmlElement class with the speicified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected CustomXmlElement(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
            : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CustomXmlElement class with the speicified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected CustomXmlElement(params OpenXmlElement[] childElements)
            : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CustomXmlBlock class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        protected CustomXmlElement(string outerXml)
            : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Custom XML Markup Namespace. </para>
        /// <para>Represents the attribte in schema: w:uri.</para>
        /// </summary>
        /// <remark>
        /// xmlns:w=http://schemas.openxmlformats.org/wordprocessingml/2006/main.
        /// </remark>
        [SchemaAttr(23, "uri")]
        public StringValue Uri
        {
            get { return (StringValue)Attributes[0]; }
            set { Attributes[0] = value; }
        }

        /// <summary>
        /// <para>Element name. </para>
        /// <para>Represents the attribte in schema: w:element.</para>
        /// </summary>
        /// <remark>
        /// xmlns:w=http://schemas.openxmlformats.org/wordprocessingml/2006/main.
        /// </remark>
        [SchemaAttr(23, "element")]
        public StringValue Element
        {
            get { return (StringValue)Attributes[1]; }
            set { Attributes[1] = value; }
        }

        internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
        {
            if (23 == namespaceId && "uri" == name)
                return new StringValue();

            if (23 == namespaceId && "element" == name)
                return new StringValue();

            return null;
        }

        /// <summary>
        /// <para>CustomXmlProperties.</para>
        /// <para>Represents the element tag in schema: w:customXmlPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:w = http://schemas.openxmlformats.org/wordprocessingml/2006/main.
        /// </remark>
        public CustomXmlProperties CustomXmlProperties
        {
            get
            {
                return GetElement<CustomXmlProperties>(0);
            }
            set
            {
                SetElement(0, value);
            }
        }
    }

    /// <summary>
    /// Defines Recipients.
    /// </summary>
    public partial class Recipients : OpenXmlPartRootElement
    {
        /// <summary>
        /// Recipients constructor.
        /// </summary>
        /// <param name="ownerPart">The owner part of the Recipients.</param>
        internal Recipients(MailMergeRecipientDataPart ownerPart)
            : base(ownerPart)
        {
            
        }

        /// <summary>
        /// Loads the DOM from an OpenXML part.
        /// </summary>
        /// <param name="openXmlPart">The part to be loaded.</param>
        public void Load(MailMergeRecipientDataPart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }
 
        /// <summary>
        /// Saves the DOM into the OpenXML part.
        /// </summary>
        /// <param name="openXmlPart">The part to be saved to.</param>
        public void Save(MailMergeRecipientDataPart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }
    }
}

namespace DocumentFormat.OpenXml.Office.Word
{
    /// <summary>
    /// Defines MailMergeRecipients.
    /// </summary>
    public partial class MailMergeRecipients : OpenXmlPartRootElement
    {
        /// <summary>
        /// MailMergeRecipients constructor.
        /// </summary>
        /// <param name="ownerPart">The owner part of the MailMergeRecipients.</param>
        internal MailMergeRecipients(MailMergeRecipientDataPart ownerPart)
            : base(ownerPart)
        {
            
        }

        /// <summary>
        /// Loads the DOM from an OpenXML part.
        /// </summary>
        /// <param name="openXmlPart">The part to be loaded.</param>
        public void Load(MailMergeRecipientDataPart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }
 
        /// <summary>
        /// Saves the DOM into the OpenXML part.
        /// </summary>
        /// <param name="openXmlPart">The part to be saved to.</param>
        public void Save(MailMergeRecipientDataPart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }
    }
}

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines MailMergeRecipientDataPart.
    /// </summary>
    public partial class MailMergeRecipientDataPart : OpenXmlPart
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DocumentFormat.OpenXml.OpenXmlPartRootElement _rootEle;

        /// <summary>
        /// Only for OpenXmlPart derived classes.
        /// </summary>
        internal override OpenXmlPartRootElement _rootElement
        {
            get
            {
                return _rootEle;
            }
            set
            {
                _rootEle = value as DocumentFormat.OpenXml.OpenXmlPartRootElement;
            }
        }

        /// <summary>
        /// Gets the root element of this part. The DOM tree will be loaded on demand.
        /// </summary>
        internal override OpenXmlPartRootElement PartRootElement
        {
            get
            {
                if (this.Recipients != null)
                {
                    return this.Recipients;
                }
                else
                {
                    return this.MailMergeRecipients;
                }
            }
        }

        /// <summary>
        /// Gets/Sets the part's root element when the part's content type is MailMergeRecipientDataPartType.OpenXmlMailMergeRecipientData. 
        /// Setting this property will throw InvalidOperationException if the MailMergeRecipients property is not null.
        /// </summary>
        public DocumentFormat.OpenXml.Wordprocessing.Recipients Recipients
        {
            get
            {
                TryLoadRootElement();
                return _rootEle as DocumentFormat.OpenXml.Wordprocessing.Recipients;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }
                if (this.MailMergeRecipients != null)
                {
                    throw new InvalidOperationException(string.Format(System.Globalization.CultureInfo.CurrentCulture, ExceptionMessages.PropertyMutualExclusive, "Recipients", "MailMergeRecipients"));
                }
                SetDomTree(value);
            }
        }

        /// <summary>
        /// Gets/Sets the part's root element when the part's content type is MailMergeRecipientDataPartType.MsWordMailMergeRecipientData. 
        /// Setting this property will throw InvalidOperationException if the Recipients property is not null.
        /// </summary>
        public DocumentFormat.OpenXml.Office.Word.MailMergeRecipients MailMergeRecipients
        {
            get
            {
                TryLoadRootElement();
                return _rootEle as MailMergeRecipients;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }
                if (this.Recipients != null)
                {
                    throw new InvalidOperationException(string.Format(System.Globalization.CultureInfo.CurrentCulture, ExceptionMessages.PropertyMutualExclusive, "MailMergeRecipients", "Recipients"));
                }
                SetDomTree(value);
            }
        }

        private void TryLoadRootElement()
        {
            if (_rootEle == null)
            {
                try
                {
                    LoadDomTree<DocumentFormat.OpenXml.Wordprocessing.Recipients>();
                }
                catch (System.IO.InvalidDataException)
                {
                }
                if (_rootEle == null)
                {
                    LoadDomTree<DocumentFormat.OpenXml.Office.Word.MailMergeRecipients>();
                }
            }
        }
    }
}