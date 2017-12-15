﻿// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

namespace DocumentFormat.OpenXml
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
        /// The target file format.
        /// </summary>
        internal FileFormatVersions FileFormat { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of errors the OpenXmlValidator will return.
        /// Default is 1000.  A zero (0) value means no limitation.
        /// </summary>
        internal int MaxNumberOfErrors
        {
            get;
            set;
        }
   }
}
