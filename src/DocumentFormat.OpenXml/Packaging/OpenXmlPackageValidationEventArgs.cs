// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Represents the Open XML package validation events.
    /// </summary>
    [Serializable]
    [Obsolete(ObsoleteAttributeMessages.ObsoleteV1ValidationFunctionality, false)]
    public sealed class OpenXmlPackageValidationEventArgs : EventArgs
    {
        private string _message;
        private string _partClassName;

        [NonSerialized]
        private OpenXmlPart _childPart;

        [NonSerialized]
        private OpenXmlPart _parentPart;

        internal OpenXmlPackageValidationEventArgs()
        {
        }

        /// <summary>
        /// Gets or sets the message string of the event.
        /// </summary>
        public string Message
        {
            get
            {
                if (this._message == null && this.MessageId != null)
                {
                    return ExceptionMessages.ResourceManager.GetString(this.MessageId);
                }
                else
                {
                    return this._message;
                }
            }

            set
            {
                this._message = value;
            }
        }

        /// <summary>
        /// Gets the class name of the part.
        /// </summary>
        public string PartClassName
        {
            get { return _partClassName; }
            internal set { _partClassName = value; }
        }

        /// <summary>
        /// Gets the part that caused the event.
        /// </summary>
        public OpenXmlPart SubPart
        {
            get { return _childPart; }
            internal set { _childPart = value; }
        }

        /// <summary>
        /// Gets the part in which to process the validation.
        /// </summary>
        public OpenXmlPart Part
        {
            get { return _parentPart; }
            internal set { _parentPart = value; }
        }

        internal string MessageId { get; set; }

        /// <summary>
        /// Gets or sets the DataPartReferenceRelationship that caused the event.
        /// </summary>
        internal DataPartReferenceRelationship DataPartReferenceRelationship { get; set; }
    }
}
