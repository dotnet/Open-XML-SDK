// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DocumentFormat.OpenXml.Validation;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Internal.SemanticValidation
{
    internal class SemanticValidator : ICancelable
    {
        //Current used registry
        private SemanticConstraintRegistry _curReg;
        private bool _stopValidating;

        public FileFormatVersions FileFormat { get; private set; }
        public ApplicationType AppType { get; private set; }        
        
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

            this._stopValidating = false;

            ValidationTraverser.ValidatingTraverse(validationContext, this.ValidateElement, OnContextValidationFinished, this.StopSignal);
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
                    context.EmitError(error);
                }
            }
        }

        private bool StopSignal(ValidationContext validationContext)
        {
            return this._stopValidating;
        }

        #region ICancelable Members

        /// <summary>
        /// On cancel event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs"></param>
        public void OnCancel(object sender, EventArgs eventArgs)
        {
            this._stopValidating = true;
        }

        #endregion
    }
}
