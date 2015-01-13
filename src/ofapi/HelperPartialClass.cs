// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Text;
using System.IO;
using System.Diagnostics;
using DocumentFormat.OpenXml;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines CustomUiPart. The CustomUiPart served as the base class of RibbonExtensibilityPart and QuickAccessToolbarCustomizationsPart.
    /// </summary>
    public abstract partial class CustomUIPart : OpenXmlPart 
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DocumentFormat.OpenXml.Office.CustomUI.CustomUI _rootEle;

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
                _rootEle = value as DocumentFormat.OpenXml.Office.CustomUI.CustomUI;
            }
        }

        /// <summary>
        /// Gets the root element of this part. The DOM tree will be loaded on demand.
        /// </summary>
        internal override OpenXmlPartRootElement PartRootElement
        {
            get
            {
                return this.CustomUI;
            }
        }

        /// <summary>
        /// Gets/Sets the root element of this part.
        /// </summary>
        public DocumentFormat.OpenXml.Office.CustomUI.CustomUI CustomUI
        {
            get
            {
                if (_rootEle == null)
                {
                    LoadDomTree<DocumentFormat.OpenXml.Office.CustomUI.CustomUI>();
                }
                return _rootEle;
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value");
                SetDomTree(value);
            }
        }
    }

    /// <summary>
    /// Defines StylesPart. The StylesPart served as the base class of StylesWithEffectsPart and StyleDefinitionsPart.
    /// </summary>
    public abstract partial class StylesPart : OpenXmlPart
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DocumentFormat.OpenXml.Wordprocessing.Styles _rootEle;

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
                _rootEle = value as DocumentFormat.OpenXml.Wordprocessing.Styles;
            }
        }

        /// <summary>
        /// Gets the root element of this part. The DOM tree will be loaded on demand.
        /// </summary>
        internal override OpenXmlPartRootElement PartRootElement
        {
            get
            {
                return this.Styles;
            }
        }

        /// <summary>
        /// Gets/Sets the root element of this part.
        /// </summary>
        public DocumentFormat.OpenXml.Wordprocessing.Styles Styles
        {
            get
            {
                if (_rootEle == null)
                {
                    LoadDomTree<DocumentFormat.OpenXml.Wordprocessing.Styles>();
                }
                return _rootEle;
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value");
                SetDomTree(value);
            }
        }
    }
}
