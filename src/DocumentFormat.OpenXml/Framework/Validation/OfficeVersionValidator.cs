// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Validation;

namespace DocumentFormat.OpenXml.Framework
{
    internal class OfficeVersionValidator : IValidator
    {
        /// <summary>
        /// Gets the Office version of the available property.
        /// </summary>
        public FileFormatVersions OfficeVersion { get; }

        /// <summary>
        /// Initializes a new instance of the OfficeAvailabilityAttribute class.
        /// </summary>
        /// <param name="officeVersion">The Office version where this class or property is available.
        /// If there is more than one version, use bitwise OR to specify multiple versions.</param>
        public OfficeVersionValidator(FileFormatVersions officeVersion)
        {
            OfficeVersion = officeVersion;
        }

        public void Validate(ValidationContext context)
        {
            var current = context.Stack.Current;

            if (!context.FileFormat.AtLeast(OfficeVersion) && current.Value?.HasValue == true && !context.McContext.IsIgnorableNs(current.Property.GetQName().Namespace))
            {
                context.CreateError(
                    id: "Sch_UndeclaredAttribute",
                    description: SR.Format(ValidationResources.Sch_UndeclaredAttribute, current.Property.GetQName()),
                    errorType: ValidationErrorType.Schema);
            }
        }
    }
}
