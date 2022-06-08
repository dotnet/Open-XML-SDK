// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using System;
using System.Globalization;
using System.Threading;

namespace DocumentFormat.OpenXml.Tests.Common
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
