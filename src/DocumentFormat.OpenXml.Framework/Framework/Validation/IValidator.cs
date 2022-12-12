// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Validation;

namespace DocumentFormat.OpenXml.Framework
{
    internal interface IValidator
    {
        void Validate(ValidationContext context);
    }
}
