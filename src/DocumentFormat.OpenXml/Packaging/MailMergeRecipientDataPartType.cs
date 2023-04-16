// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines MailMergeRecipientDataPartType - types of MailMergeRecipientDataPart.
    /// </summary>
    public static class MailMergeRecipientDataPartType
    {
        /// <summary>
        /// Defines type information for OpenXmlMailMergeRecipientData mail merge recipient data part.
        /// </summary>
        public static readonly PartTypeInfo OpenXmlMailMergeRecipientData = new("application/vnd.openxmlformats-officedocument.wordprocessingml.mailMergeRecipientData+xml", ".xml");

        /// <summary>
        /// Defines type information for MsWordMailMergeRecipientData mail merge recipient data part.
        /// </summary>
        public static readonly PartTypeInfo MsWordMailMergeRecipientData = new("application/vnd.ms-word.mailMergeRecipientData+xml", ".xml");
    }
}
