// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "mailMergeRecipientDataPartType")]
        internal static string GetTargetExtension(MailMergeRecipientDataPartType mailMergeRecipientDataPartType)
        {
            return ".xml";
        }
    }
}
