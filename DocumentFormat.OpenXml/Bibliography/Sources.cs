// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using DocumentFormat.OpenXml.Packaging;

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
