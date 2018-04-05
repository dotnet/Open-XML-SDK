// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml.Validation
{
    /// <summary>
    /// An implementation of <see cref="EventArgs"/> for validation error event.
    /// </summary>
    internal class ValidationErrorEventArgs : EventArgs
    {
        internal ValidationErrorEventArgs(ValidationErrorInfo validatoinError)
        {
            ValidationErrorInfo = validatoinError;
        }

        /// <summary>
        /// Gets or sets the validation error.
        /// </summary>
        internal ValidationErrorInfo ValidationErrorInfo { get; set; }
    }
}
