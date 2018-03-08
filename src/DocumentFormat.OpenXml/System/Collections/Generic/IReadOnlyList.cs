// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml
{
    internal interface IReadOnlyList<T> : IReadOnlyCollection<T>
    {
        T this[int index] { get; }
    }
}
