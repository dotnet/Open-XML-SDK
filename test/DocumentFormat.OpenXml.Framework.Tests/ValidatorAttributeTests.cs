// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Validation;
using System;
using System.Xml;
using Xunit;

#pragma warning disable CA1812

namespace DocumentFormat.OpenXml.Framework.Tests
{
    public class ValidatorAttributeTests
    {
        [Fact]
        public void NoValidators()
        {
            var attributes = AttributeCollectionBuilder.Create<NoValidatorsElement>();
            var attribute = Assert.Single(attributes.Raw);

            var single = Assert.Single(attribute.Validators);

            Assert.IsType<StringValidatorAttribute>(single);
        }

        [Fact]
        public void RequiredValidation()
        {
            var attributes = AttributeCollectionBuilder.Create<RequiredValidator>();
            var attribute = Assert.Single(attributes.Raw);

            Assert.Collection(
                attribute.Validators,
                t => Assert.IsType<RequiredValidatorAttribute>(t),
                t => Assert.IsType<StringValidatorAttribute>(t));
        }

        [Fact]
        public void JustUnion()
        {
            var attributes = AttributeCollectionBuilder.Create<JustUnionValidator>();
            var attribute = Assert.Single(attributes.Raw);

            Assert.Collection(
                attribute.Validators,
                t =>
                {
                    var union = Assert.IsType<UnionValidator>(t);

                    Assert.Collection(
                        union.Validators,
                        v => Assert.IsType<StringValidatorAttribute>(v),
                        v => Assert.IsType<StringValidatorAttribute>(v));
                },
                t => Assert.IsType<StringValidatorAttribute>(t));
        }

        private class NoValidatorsElement : BaseElement, IMetadataBuilder
        {
            public StringValue Val { get; set; }

            void IMetadataBuilder.BuildAttributes(ElementBuilder builder) => builder.Add<NoValidatorsElement>()
                .AddAttribute(0, "val", a => a.Val);
        }

        private class RequiredValidator : BaseElement, IMetadataBuilder
        {
            public StringValue Val { get; set; }

            void IMetadataBuilder.BuildAttributes(ElementBuilder builder) => builder.Add<NoValidatorsElement>()
                .AddAttribute(0, "val", a => a.Val, a =>
                {
                    a.IsRequired();
                });
        }

        private class JustUnionValidator : BaseElement, IMetadataBuilder
        {
            public StringValue Val { get; set; }

            void IMetadataBuilder.BuildAttributes(ElementBuilder builder) => builder.Add<NoValidatorsElement>()
                .AddAttribute(0, "val", a => a.Val, a =>
                {
                    a.AddUnion(aa =>
                    {
                        aa.AddValidator(new StringValidatorAttribute { IsId = true });
                        aa.AddValidator(new StringValidatorAttribute { IsNcName = true });
                    });
                });
        }

        private class CustomValidator : Attribute, IOpenXmlSimpleTypeValidator
        {
            public void Validate(ValidationContext context) => throw new NotImplementedException();
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
