// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml.Packaging
{
    internal static class MailMergeRecipientDataPartTypeInfo
    {
        internal static string GetContentType(MailMergeRecipientDataPartType mailMergeRecipientDataPartType)
        {
            switch (mailMergeRecipientDataPartType)
            {
                case MailMergeRecipientDataPartType.OpenXmlMailMergeRecipientData:
                    return "application/vnd.openxmlformats-officedocument.wordprocessingml.mailMergeRecipientData+xml";
                case MailMergeRecipientDataPartType.MsWordMailMergeRecipientData:
                    return "application/vnd.ms-word.mailMergeRecipientData+xml";
                default:
                    throw new ArgumentOutOfRangeException(nameof(mailMergeRecipientDataPartType));
            }
        }

        internal static string GetTargetExtension(MailMergeRecipientDataPartType mailMergeRecipientDataPartType)
        {
            return ".xml";
        }
    }
}
