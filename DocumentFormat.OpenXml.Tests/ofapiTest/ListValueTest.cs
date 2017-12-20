// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Linq;
using Xunit;

namespace DocumentFormat.OpenXml.Tests
{
    /// <summary>
    ///This is a test class for ListValueTest and is intended
    ///to contain all ListValueTest Unit Tests
    ///</summary>
    public class ListValueTest
    {
        ///<summary>
        ///ListValueSanityTest.
        ///</summary>
        [Fact]
        public void ListValueSanityTest()
        {
            ListValue<StringValue> target = new ListValue<StringValue>();
            Assert.Null(target.InnerText);
            Assert.NotNull(target.Items);

            target.Items.Add(new StringValue("Item1"));
            Assert.NotNull(target.Items);
            Assert.NotNull(target.InnerText);
            Assert.Equal("Item1", target.Items.First().ToString());
            Assert.Equal("Item1", (string)target);

            target.Items.Add(new StringValue("Item2"));
            Assert.NotNull(target.Items);
            Assert.NotNull(target.InnerText);
            Assert.Equal("Item2", target.Items.ElementAt(1).ToString());
            Assert.Equal("Item1 Item2", target.ToString());

            target.InnerText = "Item3 Item4";
            Assert.NotNull(target.Items);
            Assert.NotNull(target.InnerText);
            Assert.Equal(2, target.Items.Count);
            Assert.Equal("Item3", target.Items.First().ToString());
            Assert.Equal("Item4", target.Items.ElementAt(1).ToString());

            var target2 = new ListValue<StringValue>(target);
            Assert.NotNull(target2.Items);
            Assert.NotNull(target2.InnerText);
            Assert.Equal(2, target2.Items.Count);
            Assert.Equal("Item3", target2.Items.First().ToString());
            Assert.Equal("Item4", target2.Items.ElementAt(1).ToString());
        }
    }
}
