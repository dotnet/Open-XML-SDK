// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Office2013.PowerPoint.Roaming;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Framework.Metadata
{
    internal class ValidatorBuilder
    {
        protected readonly List<IOpenXmlSimpleTypeValidator> _validators = new List<IOpenXmlSimpleTypeValidator>();

        public void AddValidator(IOpenXmlSimpleTypeValidator validator)
        {
            if (validator is RequiredValidatorAttribute)
            {
                _validators.Insert(0, validator);
            }
            else
            {
                _validators.Add(validator);
            }
        }

        public void InsertValidator(int index, IOpenXmlSimpleTypeValidator validator)
        {
            _validators.Insert(index, validator);
        }
    }
}
