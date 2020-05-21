// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework.Metadata;
using System;
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
            var data = ElementBuilder.Create()
                .Add<SomeElement>()
                .AddAttribute(0, "s", a => a.Str, a =>
                {
                })
                .Build();
            var element = new AttributeCollection(data);

            ref var str = ref element.GetProperty(nameof(SomeElement.Str));

            Assert.Null(str);

            var tmp = new StringValue();

            str = tmp;

            Assert.NotNull(str);

            var str2 = element.GetProperty(nameof(SomeElement.Str));

            Assert.Same(str, tmp);
        }

        [Fact]
        public void IsRequired()
        {
            var data = ElementBuilder.Create()
                .Add<SomeElement>()
                .AddAttribute(0, "s", a => a.Str, a =>
                {
                    a.IsRequired();
                })
                .Build();

            var elementData = Assert.Single(data);

            Assert.Collection(
                elementData.Validators,
                v => Assert.IsType<RequiredValidatorAttribute>(v),
                v => Assert.IsType<StringValidatorAttribute>(v));
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
