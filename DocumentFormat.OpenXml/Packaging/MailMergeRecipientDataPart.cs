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
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DocumentFormat.OpenXml.OpenXmlPartRootElement _rootEle;

        /// <inheritdoc/>
        internal override OpenXmlPartRootElement _rootElement
        {
            get
            {
                return _rootEle;
            }

            set
            {
                _rootEle = value as DocumentFormat.OpenXml.OpenXmlPartRootElement;
            }
        }

        /// <inheritdoc/>
        internal override OpenXmlPartRootElement PartRootElement
        {
            get
            {
                if (this.Recipients != null)
                {
                    return this.Recipients;
                }
                else
                {
                    return this.MailMergeRecipients;
                }
            }
        }

        /// <summary>
        /// Gets or sets the part's root element when the part's content type is MailMergeRecipientDataPartType.OpenXmlMailMergeRecipientData.
        /// Setting this property will throw InvalidOperationException if the MailMergeRecipients property is not null.
        /// </summary>
        public Wordprocessing.Recipients Recipients
        {
            get
            {
                TryLoadRootElement();
                return _rootEle as DocumentFormat.OpenXml.Wordprocessing.Recipients;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value));
                }
                if (this.MailMergeRecipients != null)
                {
                    throw new InvalidOperationException(string.Format(System.Globalization.CultureInfo.CurrentCulture, ExceptionMessages.PropertyMutualExclusive, "Recipients", "MailMergeRecipients"));
                }
                SetDomTree(value);
            }
        }

        /// <summary>
        /// Gets or sets the part's root element when the part's content type is MailMergeRecipientDataPartType.MsWordMailMergeRecipientData.
        /// Setting this property will throw InvalidOperationException if the Recipients property is not null.
        /// </summary>
        public MailMergeRecipients MailMergeRecipients
        {
            get
            {
                TryLoadRootElement();
                return _rootEle as MailMergeRecipients;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value));
                }
                if (this.Recipients != null)
                {
                    throw new InvalidOperationException(string.Format(System.Globalization.CultureInfo.CurrentCulture, ExceptionMessages.PropertyMutualExclusive, "MailMergeRecipients", "Recipients"));
                }
                SetDomTree(value);
            }
        }

        private void TryLoadRootElement()
        {
            if (_rootEle == null)
            {
                try
                {
                    LoadDomTree<DocumentFormat.OpenXml.Wordprocessing.Recipients>();
                }
                catch (System.IO.InvalidDataException)
                {
                }
                if (_rootEle == null)
                {
                    LoadDomTree<DocumentFormat.OpenXml.Office.Word.MailMergeRecipients>();
                }
            }
        }
    }
}
