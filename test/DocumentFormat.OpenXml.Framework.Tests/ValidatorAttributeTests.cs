// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework.Metadata;
using System;
using System.Xml;
using Xunit;

namespace DocumentFormat.OpenXml.Framework.Tests
{
    public class ValidatorAttributeTests
    {
        [Fact]
        public void NoValidators()
        {
            var provider = new TypedElementMetadataFactoryFeature();
            var attributes = provider.GetMetadata(new NoValidatorsElement());
            var attribute = Assert.Single(attributes.Attributes);

            var single = Assert.Single(attribute.Validators);

            Assert.IsType<StringValidator>(single);
        }

        [Fact]
        public void RequiredValidation()
        {
            var provider = new TypedElementMetadataFactoryFeature();
            var attributes = provider.GetMetadata(new ContainsRequiredValidator());
            var attribute = Assert.Single(attributes.Attributes);

            Assert.Collection(
                attribute.Validators,
                t => Assert.IsType<RequiredValidator>(t),
                t => Assert.IsType<StringValidator>(t));
        }

        [Fact]
        public void JustUnion()
        {
            var provider = new TypedElementMetadataFactoryFeature();
            var attributes = provider.GetMetadata(new JustUnionValidator());
            var attribute = Assert.Single(attributes.Attributes);

            Assert.Collection(
                attribute.Validators,
                t =>
                {
                    var union = Assert.IsType<UnionValidator>(t);

                    Assert.Collection(
                        union.Validators,
                        v => Assert.IsType<StringValidator>(v),
                        v => Assert.IsType<StringValidator>(v));
                },
                t => Assert.IsType<StringValidator>(t));
        }

        private class NoValidatorsElement : BaseElement
        {
            public StringValue Val { get; set; }

            internal override void ConfigureMetadata(ElementMetadata.Builder builder) => builder.AddElement<NoValidatorsElement>()
                .AddAttribute("val", a => a.Val);
        }

        private class ContainsRequiredValidator : BaseElement
        {
            public StringValue Val { get; set; }

            internal override void ConfigureMetadata(ElementMetadata.Builder builder) => builder.AddElement<NoValidatorsElement>()
                .AddAttribute("val", a => a.Val, a =>
                {
                    a.AddValidator(new RequiredValidator());
                });
        }

        private class JustUnionValidator : BaseElement
        {
            public StringValue Val { get; set; }

            internal override void ConfigureMetadata(ElementMetadata.Builder builder) => builder.AddElement<NoValidatorsElement>()
                .AddAttribute("val", a => a.Val, a =>
                {
                    a.AddUnion(aa =>
                    {
                        aa.AddValidator(new StringValidator { IsId = true });
                        aa.AddValidator(new StringValidator { IsNcName = true });
                    });
                });
        }

        private class BaseElement : OpenXmlElement
        {
            public override bool HasChildren => throw new NotImplementedException();

            public override void RemoveAllChildren() => throw new NotImplementedException();

            internal override void WriteContentTo(XmlWriter w) => throw new NotImplementedException();

            private protected override void Populate(XmlReader xmlReader, OpenXmlLoadMode loadMode) => throw new NotImplementedException();
        }
    }
}
