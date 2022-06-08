// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using LogUtil;
using Xunit.Abstractions;

namespace DocumentFormat.OpenXml.Tests
{
    public class OpenXmlTestBase
    {
        protected OpenXmlTestBase(ITestOutputHelper output)
        {
            Log = new VerifiableLog(output);
        }

        protected VerifiableLog Log { get; }
    }
}
