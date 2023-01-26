// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml.Features;

/// <summary>
/// Feature to track items to dispose when the containing package or part is closed.
/// </summary>
public interface IDisposableFeature
{
    /// <summary>
    /// Register an <see cref="IDisposable"/> to be called on package or part close.
    /// </summary>
    /// <param name="disposable">Disposable to be called when a package or part is closed.</param>
    public void Register(IDisposable disposable);
}
