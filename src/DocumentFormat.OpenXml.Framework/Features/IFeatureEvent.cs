// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml.Features
{
    /// <summary>
    /// Interface for general feature eventing.
    /// </summary>
    /// <typeparam name="TArg">Type of the argument.</typeparam>
    public interface IFeatureEvent<TArg>
    {
        /// <summary>
        /// Event to register to listen to any changes.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1003:Use generic event handler instances", Justification = "Existing API")]
        event Action<FeatureEventArgs<TArg>> Change;
    }
}
