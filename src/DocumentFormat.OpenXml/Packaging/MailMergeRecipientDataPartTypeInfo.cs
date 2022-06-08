// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using System;

namespace DocumentFormat.OpenXml.Packaging
{
    internal static class MailMergeRecipientDataPartTypeInfo
    {
        internal static string GetContentType(MailMergeRecipientDataPartType mailMergeRecipientDataPartType)
            => mailMergeRecipientDataPartType switch
            {
                MailMergeRecipientDataPartType.OpenXmlMailMergeRecipientData => "application/vnd.openxmlformats-officedocument.wordprocessingml.mailMergeRecipientData+xml",
                MailMergeRecipientDataPartType.MsWordMailMergeRecipientData => "application/vnd.ms-word.mailMergeRecipientData+xml",
                _ => throw new ArgumentOutOfRangeException(nameof(mailMergeRecipientDataPartType)),
            };

        internal static string GetTargetExtension(MailMergeRecipientDataPartType mailMergeRecipientDataPartType)
            => ".xml";
    }
}
