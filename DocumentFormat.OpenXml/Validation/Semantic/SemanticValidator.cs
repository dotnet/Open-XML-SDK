// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Diagnostics;

namespace DocumentFormat.OpenXml.Validation.Semantic
{
    internal class SemanticValidator
    {
        private readonly SemanticConstraintRegistry _curReg;

        public FileFormatVersions FileFormat { get; }

        public ApplicationType AppType { get; }

        public SemanticValidator(FileFormatVersions format, ApplicationType app)
        {
            FileFormat = format;
            AppType = app;

            _curReg = new SemanticConstraintRegistry(format, app);
        }

        public void Validate(ValidationContext validationContext)
        {
            Debug.Assert(validationContext != null);
            Debug.Assert(validationContext.Element != null);

            ValidationTraverser.ValidatingTraverse(validationContext, ValidateElement, OnContextValidationFinished);
        }

        public void ClearConstraintState(SemanticValidationLevel level)
        {
            _curReg.ClearConstraintState(level);
        }

        private void OnContextValidationFinished(ValidationContext context)
        {
            _curReg.ActCallBack(context.Element.ElementTypeId);
        }

        private void ValidateElement(ValidationContext context)
        {
            if (_curReg != null)
            {
                foreach (var error in _curReg.CheckConstraints(context))
                {
                    context.AddError(error);
                }
            }
        }
    }
}
