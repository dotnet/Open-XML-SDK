// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;

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
            SaveToPart(openXmlPart);
        }
    }
}
