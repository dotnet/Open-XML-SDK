// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines StylesPart. The StylesPart served as the base class of StylesWithEffectsPart and StyleDefinitionsPart.
    /// </summary>
    public abstract partial class StylesPart : OpenXmlPart
    {
        private Wordprocessing.Styles? _rootEle;

        /// <inheritdoc/>
        private protected override OpenXmlPartRootElement? InternalRootElement
        {
            get => _rootEle;
            set => _rootEle = value as Wordprocessing.Styles;
        }

        /// <summary>
        /// Gets the root element of this part. The DOM tree will be loaded on demand.
        /// </summary>
        internal override OpenXmlPartRootElement? PartRootElement => Styles;

        /// <summary>
        /// Gets or sets the root element of this part.
        /// </summary>
        public Wordprocessing.Styles? Styles
        {
            get
            {
                if (_rootEle is null)
                {
                    LoadDomTree<Wordprocessing.Styles>();
                }

                return _rootEle;
            }

            set
            {
                if (value is null)
                {
                    throw new ArgumentNullException(nameof(value));
                }

                SetDomTree(value);
            }
        }
    }
}
