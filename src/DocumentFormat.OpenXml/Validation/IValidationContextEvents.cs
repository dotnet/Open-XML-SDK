// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Validation
{
    internal interface IValidationContextEvents
    {
        void OnElementValidationFinished(ValidationContext context);

        void OnElementValidationStarted(ValidationContext context);

        void OnPartValidationStarted(ValidationContext context);
    }
}
