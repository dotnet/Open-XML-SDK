// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Text;
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
            var attribute = Assert.Single(Parse(typeof(NoValidatorsElement)).RawAttributes);

            var single = Assert.Single(attribute.Validators);

            Assert.IsType<StringValidatorAttribute>(single);
        }

        [Fact]
        public void RequiredValidation()
        {
            var attribute = Assert.Single(Parse(typeof(RequiredValidator)).RawAttributes);

            Assert.Collection(attribute.Validators,
                t => Assert.IsType<RequiredValidatorAttribute>(t),
                t => Assert.IsType<StringValidatorAttribute>(t));
        }

        [Fact]
        public void JustUnion()
        {
            var attribute = Assert.Single(Parse(typeof(JustUnionValidator)).RawAttributes);

            Assert.Collection(attribute.Validators,
                t => Assert.IsType<StringValidatorAttribute>(t),
                t =>
                {
                    var union = Assert.IsType<UnionValidator>(t);

                    Assert.Equal(0, union.Id);
                    Assert.Collection(union.Validators,
                        v => Assert.IsType<StringValidatorAttribute>(v),
                        v => Assert.IsType<StringValidatorAttribute>(v));
                });
        }

        private static OpenXmlElementData Parse(Type type) => new OpenXmlElementData(type, new PackageCache());

        private class NoValidatorsElement : BaseElement
        {
            [Index(0)]
            [SchemaAttr(0, "val")]
            public StringValue Val { get; set; }
        }

        private class RequiredValidator : BaseElement
        {
            [RequiredValidator]
            [Index(0)]
            [SchemaAttr(0, "val")]
            public StringValue Val { get; set; }
        }

        private class JustUnionValidator : BaseElement
        {
            [StringValidator(IsId = true, UnionId = 0)]
            [StringValidator(IsNcName = true, UnionId = 0)]
            [Index(0)]
            [SchemaAttr(0, "val")]
            public StringValue Val { get; set; }
        }

        private class CustomValidator : Attribute, IOpenXmlSimpleTypeValidator
        {
            public void Validate(ValidatorContext context) => throw new NotImplementedException();
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
