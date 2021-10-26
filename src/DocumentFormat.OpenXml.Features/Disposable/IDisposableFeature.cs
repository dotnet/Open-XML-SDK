// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml.Features
{
    /// <summary>
    /// Feature to track items to dispose when a package is disposed.
    /// </summary>
    public interface IDisposableFeature
    {
        /// <summary>
        /// Register a disposable to be tracked.
        /// </summary>
        /// <param name="disposable">Disposable to be tracked and disposed when a package is disposed.</param>
        public void Register(IDisposable disposable);
    }
}
