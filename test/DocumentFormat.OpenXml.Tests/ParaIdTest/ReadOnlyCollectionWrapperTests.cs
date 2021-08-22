// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using Xunit;

namespace DocumentFormat.OpenXml.Wordprocessing
{
    public class ReadOnlyCollectionWrapperTests
    {
        [Fact]
        public void WrappedCollectionsAreReadOnly()
        {
            ICollection<string> source = new HashSet<string> { "12345678" };
            ICollection<string> collection = new ReadOnlyCollectionWrapper<string>(source);

            Assert.Contains("12345678", collection);
            Assert.Single(collection);

            Assert.True(collection.IsReadOnly);
            Assert.Throws<NotSupportedException>(() => collection.Add("ABCDEF"));
            Assert.Throws<NotSupportedException>(() => collection.Clear());
            Assert.Throws<NotSupportedException>(() => collection.Remove("12345678"));
        }
    }
}
