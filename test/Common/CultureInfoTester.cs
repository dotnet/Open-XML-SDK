// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Globalization;
using System.Threading;

namespace DocumentFormat.OpenXml.Tests
{
    internal readonly struct CultureInfoTester : IDisposable
    {
        private readonly CultureInfo _old;

        public CultureInfoTester(string desired)
        {
            _old = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = new CultureInfo(desired);
        }

        public void Dispose()
        {
            Thread.CurrentThread.CurrentCulture = _old;
        }
    }
}
