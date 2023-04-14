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
        private const string ExpectedConditionValue = "hello";
        private const string UnexpectedConditionValue = "helloWorld!";

        [Theory]
        [InlineData(null, null)]
        [InlineData(null, UnexpectedConditionValue)]
        [InlineData(RequiredValue, UnexpectedConditionValue)]
        [InlineData(RequiredValue, null)]
        [InlineData(RequiredValue, ExpectedConditionValue)]
        public void NoErrors(string required, string condition)
        {
            var validator = new OpenXmlValidator();
            var element = new TestElement();

            if (required is string)
            {
                element.Required = required;
            }

            if (condition is string)
            {
                element.Condition = condition;
            }

            var results = validator.Validate(element);

            Assert.Empty(results);
        }

        [Fact]
        public void SemanticErrorValue()
        {
            var validator = new OpenXmlValidator();
            var element = new TestElement
            {
                Condition = ExpectedConditionValue,
            };

            var error = Assert.Single(validator.Validate(element));

            Assert.Equal("Sem_AttributeRequiredConditionToValue", error.Id);
            Assert.Equal(ValidationErrorType.Semantic, error.ErrorType);
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
                    .AddAttribute(":required", t => t.Required)
                    .AddAttribute(":condition", t => t.Condition);

                builder.AddConstraint(new AttributeRequiredConditionToValue(builder.CreateQName(":required"), builder.CreateQName(":condition"), ExpectedConditionValue));
            }
        }
    }
}
