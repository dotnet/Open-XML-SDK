// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Xunit;

namespace DocumentFormat.OpenXml.Tests
{
    public class OpenXmlTestBase
    {
        protected OpenXmlTestBase(ITestOutputHelper output)
        {
            Output = output;
        }

        private protected ITestOutputHelper Output { get; }
    }
}
