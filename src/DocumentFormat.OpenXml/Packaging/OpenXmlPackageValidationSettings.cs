// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Specifies event handlers that will handle OpenXmlPackage validation events and the OpenXmlPackageValidationEventArgs.
    /// </summary>
    [Obsolete(ObsoleteAttributeMessages.ObsoleteV1ValidationFunctionality, false)]
    public class OpenXmlPackageValidationSettings
    {
        private EventHandler<OpenXmlPackageValidationEventArgs> valEventHandler;

        /// <summary>
        /// Gets the event handler.
        /// </summary>
        /// <returns></returns>
        internal EventHandler<OpenXmlPackageValidationEventArgs> GetEventHandler()
        {
            return valEventHandler;
        }

        /// <summary>
        /// Represents the callback method that will handle OpenXmlPackage validation events and the OpenXmlPackageValidationEventArgs.
        /// </summary>
        public event EventHandler<OpenXmlPackageValidationEventArgs> EventHandler
        {
            add
            {
                valEventHandler = (EventHandler<OpenXmlPackageValidationEventArgs>)Delegate.Combine(valEventHandler, value);
            }

            remove
            {
                valEventHandler = (EventHandler<OpenXmlPackageValidationEventArgs>)Delegate.Remove(valEventHandler, value);
            }
        }

        /// <summary>
        /// Gets or sets the file format version that the validation is targeting.
        /// </summary>
        internal FileFormatVersions FileFormat
        {
            get;
            set;
        }
    }
}
