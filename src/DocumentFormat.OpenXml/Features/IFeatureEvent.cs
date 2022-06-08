// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

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
        event Action<FeatureEventArgs<TArg>> Change;
    }
}
