// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using Xunit;

namespace DocumentFormat.OpenXml.Framework.Tests
{
    /// <summary>
    /// These tests verify some old behavior in early versions of the SDK that some relied on. An API should be exposed to retrieve the schema info, and then this can be removed in the future.
    /// </summary>
    [Obsolete]
    public class SchemaAttrTests
    {
        [Fact]
        public void SchemaAttrValuesMatch()
        {

        }
    }
}
