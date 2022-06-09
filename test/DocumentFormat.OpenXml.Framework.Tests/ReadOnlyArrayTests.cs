// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Xunit;

namespace DocumentFormat.OpenXml.Framework.Tests
{
    public class ReadOnlyArrayTests
    {
        [Fact]
        public void DefaultDoesntThrow()
        {
            var array = default(ReadOnlyArray<object>);

            Assert.True(array.IsNull);
            Assert.Equal(0, array.Length);
            Assert.False(array.Any());

            Assert.False(array.GetEnumerator().MoveNext());
        }
    }
}
