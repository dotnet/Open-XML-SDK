﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DocumentFormat.OpenXml.Tests.Common
{
    internal readonly struct CultureInfoTester : IDisposable
    {
        private readonly CultureInfo _old;

        public CultureInfoTester(CultureInfo desired)
        {
            _old = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = desired;
        }

        public void Dispose()
        {
            Thread.CurrentThread.CurrentCulture = _old;
        }
    }
}