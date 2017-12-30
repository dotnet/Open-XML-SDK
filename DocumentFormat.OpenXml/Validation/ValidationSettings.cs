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
        internal ValidationSettings()
        {
            this.FileFormat = FileFormatVersions.Office2007;
            this.MaxNumberOfErrors = _defaultMaxNumberOfErrorsReturned;
        }

        /// <summary>
        /// Initializes a new instance of the ValidationSettings.
        /// </summary>
        /// <param name="fileFormat">The target file format.</param>
        internal ValidationSettings(FileFormatVersions fileFormat)
        {
            fileFormat.ThrowExceptionIfFileFormatNotSupported(nameof(fileFormat));
            this.FileFormat = fileFormat;

            this.MaxNumberOfErrors = _defaultMaxNumberOfErrorsReturned;
        }

        /// <summary>
        /// Gets or sets the target file format.
        /// </summary>
        internal FileFormatVersions FileFormat { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of errors the OpenXmlValidator will return.
        /// Default is 1000.  A zero (0) value means no limitation.
        /// </summary>
        internal int MaxNumberOfErrors { get; set; }
   }
}
