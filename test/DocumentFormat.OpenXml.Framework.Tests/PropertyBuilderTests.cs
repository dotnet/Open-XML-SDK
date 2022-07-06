// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
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
            var builder = new ElementMetadata.Builder(typeof(OpenXmlElement), new OpenXmlNamespaceResolver());
            builder.AddElement<SomeElement>()
                .AddAttribute("s", a => a.Str, a =>
                {
                });
            var data = builder.Build();

            var element = new Metadata.ElementState(data);

            ref var str = ref element.Attributes.GetProperty(nameof(SomeElement.Str)).Value;

            Assert.Null(str);

            var tmp = new StringValue();

            str = tmp;

            Assert.NotNull(str);

            var str2 = element.Attributes.GetProperty(nameof(SomeElement.Str)).Value;

            Assert.Same(str, tmp);
        }

        [Fact]
        public void IsRequired()
        {
            var builder = new ElementMetadata.Builder(typeof(OpenXmlElement), new OpenXmlNamespaceResolver());
            builder.AddElement<SomeElement>()
                .AddAttribute("s", a => a.Str, a =>
                {
                    a.AddValidator(new RequiredValidator());
                });
            var data = builder.Build();

            var elementData = Assert.Single(data.Attributes);

            Assert.Collection(
                elementData.Validators,
                v => Assert.IsType<RequiredValidator>(v),
                v => Assert.IsType<StringValidator>(v));
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
