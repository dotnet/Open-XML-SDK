// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines CustomUiPart. The CustomUiPart served as the base class of RibbonExtensibilityPart and QuickAccessToolbarCustomizationsPart.
    /// </summary>
    public abstract partial class CustomUIPart : OpenXmlPart
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private Office.CustomUI.CustomUI _rootEle;

        /// <inheritdoc/>
        private protected override OpenXmlPartRootElement InternalRootElement
        {
            get
            {
                return _rootEle;
            }

            set
            {
                _rootEle = value as Office.CustomUI.CustomUI;
            }
        }

        /// <inheritdoc/>
        internal override OpenXmlPartRootElement PartRootElement
        {
            get
            {
                return CustomUI;
            }
        }

        /// <summary>
        /// Gets or sets the root element of this part.
        /// </summary>
        public Office.CustomUI.CustomUI CustomUI
        {
            get
            {
                if (_rootEle == null)
                {
                    LoadDomTree<Office.CustomUI.CustomUI>();
                }

                return _rootEle;
            }

            set
            {
                if (value == null)
                    throw new ArgumentNullException(nameof(value));
                SetDomTree(value);
            }
        }
    }
}
