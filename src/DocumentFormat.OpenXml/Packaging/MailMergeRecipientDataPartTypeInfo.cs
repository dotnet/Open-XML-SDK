// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Globalization;

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

        internal static MailMergeRecipientDataPartType GetMailMergeRecipientDataPartTypeFromContentType(string contenttype)
            => contenttype.ToLower(CultureInfo.CurrentCulture) switch
            {
                "application/vnd.openxmlformats-officedocument.wordprocessingml.mailMergeRecipientData+xml" => MailMergeRecipientDataPartType.OpenXmlMailMergeRecipientData,
                "application/vnd.ms-word.mailMergeRecipientData+xml" => MailMergeRecipientDataPartType.MsWordMailMergeRecipientData,
                _ => throw new NotSupportedException($"{contenttype} is not supported"),
            };

        internal static bool TryGetMailMergeRecipientDataPartTypeFromContentType(string contentType)
        {
            try
            {
                _ = GetMailMergeRecipientDataPartTypeFromContentType(contentType);
                return true;
            }
            catch (NotSupportedException)
            {
            }

            return false;
        }

        internal static bool TryGetContentType(MailMergeRecipientDataPartType partType)
        {
            try
            {
                _ = GetContentType(partType);
                return true;
            }
            catch (NotSupportedException)
            {
            }

            return false;
        }
    }
}
