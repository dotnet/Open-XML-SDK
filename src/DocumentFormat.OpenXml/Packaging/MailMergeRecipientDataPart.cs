// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Office.Word;
using System;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines MailMergeRecipientDataPart.
    /// </summary>
    public partial class MailMergeRecipientDataPart : OpenXmlPart
    {
        private OpenXmlPartRootElement? _rootEle;

        /// <inheritdoc/>
        private protected override OpenXmlPartRootElement? InternalRootElement
        {
            get => _rootEle;
            set => _rootEle = value;
        }

        /// <inheritdoc/>
        internal override OpenXmlPartRootElement? PartRootElement
        {
            get
            {
                if (Recipients is not null)
                {
                    return Recipients;
                }
                else
                {
                    return MailMergeRecipients;
                }
            }
        }

        /// <summary>
        /// Gets or sets the part's root element when the part's content type is MailMergeRecipientDataPartType.OpenXmlMailMergeRecipientData.
        /// Setting this property will throw InvalidOperationException if the MailMergeRecipients property is not null.
        /// </summary>
        public Wordprocessing.Recipients? Recipients
        {
            get
            {
                TryLoadRootElement();
                return _rootEle as Wordprocessing.Recipients;
            }

            set
            {
                if (value is null)
                {
                    throw new ArgumentNullException(nameof(value));
                }

                if (MailMergeRecipients is not null)
                {
                    throw new InvalidOperationException(SR.Format(ExceptionMessages.PropertyMutualExclusive, "Recipients", "MailMergeRecipients"));
                }

                SetDomTree(value);
            }
        }

        /// <summary>
        /// Gets or sets the part's root element when the part's content type is MailMergeRecipientDataPartType.MsWordMailMergeRecipientData.
        /// Setting this property will throw InvalidOperationException if the Recipients property is not null.
        /// </summary>
        public MailMergeRecipients? MailMergeRecipients
        {
            get
            {
                TryLoadRootElement();
                return _rootEle as MailMergeRecipients;
            }

            set
            {
                if (value is null)
                {
                    throw new ArgumentNullException(nameof(value));
                }

                if (Recipients is not null)
                {
                    throw new InvalidOperationException(SR.Format(ExceptionMessages.PropertyMutualExclusive, "MailMergeRecipients", "Recipients"));
                }

                SetDomTree(value);
            }
        }

        private void TryLoadRootElement()
        {
            if (_rootEle is null)
            {
                try
                {
                    LoadDomTree<Wordprocessing.Recipients>();
                }
                catch (System.IO.InvalidDataException)
                {
                }

                if (_rootEle is null)
                {
                    LoadDomTree<MailMergeRecipients>();
                }
            }
        }
    }
}
