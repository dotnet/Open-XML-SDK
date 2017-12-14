// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using DocumentFormat.OpenXml.Packaging;

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
