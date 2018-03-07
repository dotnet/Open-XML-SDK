// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;

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
            SaveToPart(openXmlPart);
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
}
