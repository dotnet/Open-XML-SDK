// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#pragma warning disable CA1822

namespace System.Threading
{
    internal readonly struct CancellationToken
    {
        public void ThrowIfCancellationRequested()
        {
        }
    }
}
