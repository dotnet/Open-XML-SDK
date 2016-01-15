// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFormat.OpenXml.Tests
{
    public class TestContext
    {
        public TestContext(string currentTest)
        {
            this.TestName = currentTest;
            this.FullyQualifiedTestClassName = currentTest;
        }

        public string TestName
        {
            get;
            set;
        }

        public string FullyQualifiedTestClassName
        {
            get;
            set;
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static string GetCurrentMethod()
        {
            StackTrace st = new StackTrace();
            StackFrame sf = st.GetFrame(1);

            return sf.GetMethod().Name;
        }
    }
}
