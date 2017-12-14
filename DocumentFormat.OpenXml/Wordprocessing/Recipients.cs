// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using DocumentFormat.OpenXml.Packaging;

namespace DocumentFormat.OpenXml.Wordprocessing
{
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
