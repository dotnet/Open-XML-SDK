// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Validation;
using DocumentFormat.OpenXml.Validation.Semantic;
using Xunit;

namespace DocumentFormat.OpenXml.Tests.Validation.Semantic
{
    public class AttributeRequiredConditionToValueTests
    {
        private const string RequiredValue = "requiredValue";
        private const string ExpectedValue = "hello";
        private const string UnexpectedValue = "helloWorld!";

        [Theory]
        [InlineData(null, null)]
        [InlineData(null, UnexpectedValue)]
        [InlineData(RequiredValue, UnexpectedValue)]
        [InlineData(RequiredValue, null)]
        [InlineData(RequiredValue, ExpectedValue)]
        public void NoErrors(string required, string condition)
        {
            var validator = new OpenXmlValidator();
            var element = new TestElement
            {
                Required = required,
                Condition = condition,
            };

            var results = validator.Validate(element);

            Assert.Empty(results);
        }

        [Fact]
        public void SemanticErrorValue()
        {
            var validator = new OpenXmlValidator();
            var element = new TestElement
            {
                Condition = ExpectedValue,
            };

            var error = Assert.Single(validator.Validate(element));
        }

        private class TestElement : OpenXmlCompositeElement
        {
            public StringValue Required
            {
                get => GetAttribute<StringValue>();
                set => SetAttribute(value);
            }

            public StringValue Condition
            {
                get => GetAttribute<StringValue>();
                set => SetAttribute(value);
            }

            internal override void ConfigureMetadata(ElementMetadata.Builder builder)
            {
                builder.AddElement<TestElement>()
                    .AddAttribute(0, "required", t => t.Required)
                    .AddAttribute(0, "condition", t => t.Condition);
            }

            internal override ISemanticConstraint[] SemanticConstraints { get; } = new[]
            {
                new AttributeRequiredConditionToValue(0, 1, ExpectedValue),
            };
        }
    }
}
