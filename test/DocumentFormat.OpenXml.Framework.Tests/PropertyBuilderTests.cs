// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Validation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using Xunit;

#pragma warning disable CA1812

namespace DocumentFormat.OpenXml.Framework.Tests
{

    public class PropertyBuilderTests
    {
        [Fact]
        public void Sanity()
        {
            var builder = PropertyBuilder<SomeElement>.Create()
                            .AddAttribute(0, "s", a => a.Str, a =>
                             {
                             })
                            .Build();

            ref var str = ref builder.GetAttributeValue(nameof(SomeElement.Str));

            Assert.Null(str);

            var tmp = new StringValue();

            str = tmp;

            Assert.NotNull(str);

            var str2 = builder.GetAttributeValue(nameof(SomeElement.Str));

            Assert.Same(str, tmp);
        }

        private class SomeElement : OpenXmlElement
        {
            public StringValue Str { get; set; }

            public override bool HasChildren => throw new NotImplementedException();

            public override void RemoveAllChildren() => throw new NotImplementedException();

            internal override void WriteContentTo(XmlWriter w) => throw new NotImplementedException();

            private protected override void Populate(XmlReader xmlReader, OpenXmlLoadMode loadMode) => throw new NotImplementedException();
        }
    }
}
