// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml.Validation
{
    /// <summary>
    /// Implement this interface when the operation is cancelable
    /// </summary>
    internal interface ICancelable
    {
        /// <summary>
        /// On cancel event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs"></param>
        void OnCancel(object sender, EventArgs eventArgs);
    }
}
