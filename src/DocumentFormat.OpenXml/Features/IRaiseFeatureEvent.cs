// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

namespace DocumentFormat.OpenXml.Features
{
    /// <summary>
    /// Interface to raise events for <see cref="IFeatureEvent{TArg}"/>.
    /// </summary>
    /// <typeparam name="TArg">Type of argument.</typeparam>
    public interface IRaiseFeatureEvent<TArg>
    {
        /// <summary>
        /// Raise event on underlying event.
        /// </summary>
        /// <param name="type">Type of event.</param>
        /// <param name="arg">Argument of event.</param>
        void OnChange(EventType type, TArg arg);
    }
}
