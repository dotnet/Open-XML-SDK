// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Validation
{
    /// <summary>
    /// Settings for validation.
    /// </summary>
    internal class ValidationSettings
    {
        private const int _defaultMaxNumberOfErrorsReturned = 1000;

        /// <summary>
        /// Initializes a new instance of the ValidationSettings.
        /// </summary>
        /// <param name="fileFormat">The target file format.</param>
        public ValidationSettings(FileFormatVersions fileFormat)
        {
            fileFormat.ThrowExceptionIfFileFormatNotSupported(nameof(fileFormat));

            FileFormat = fileFormat;
            MaxNumberOfErrors = _defaultMaxNumberOfErrorsReturned;
        }

        /// <summary>
        /// Gets the target file format.
        /// </summary>
        public FileFormatVersions FileFormat { get; }

        /// <summary>
        /// Gets or sets the maximum number of errors the OpenXmlValidator will return.
        /// Default is 1000.  A zero (0) value means no limitation.
        /// </summary>
        public int MaxNumberOfErrors { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the validator should verify that the package meets the minimum requirements
        /// for the specified file format. When set to <c>true</c>, the validation process will include checks to ensure
        /// the document structure is sufficient for the target application to open the file.
        /// </summary>
        public bool VerifyMinimumPackage { get; set; }
    }
}
