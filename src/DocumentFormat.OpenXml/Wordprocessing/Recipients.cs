// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

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
            SaveToPart(openXmlPart);
        }
    }
}
