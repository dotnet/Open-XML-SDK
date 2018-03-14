// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using LogUtil;
using OxTest;
using System;
using System.IO;
using Xunit.Abstractions;

namespace DocumentFormat.OpenXml.Tests.TaskLibraries
{
    /// <summary>
    /// The OpenXmlDom test framework. It contains help methods for testing OpenXmlDom Classes
    /// </summary>
    public class OpenXmlTestBase
    {
        protected OpenXmlTestBase(ITestOutputHelper output)
        {
            Log = new VerifiableLog(output);
        }

        protected VerifiableLog Log { get; }
    }
}
