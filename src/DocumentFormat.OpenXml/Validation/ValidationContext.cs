// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Validation
{
    /// <summary>
    /// Validation context.
    /// </summary>
    internal class ValidationContext
    {
        private readonly List<ValidationErrorInfo> _errors;

        public ValidationContext()
        {
            _errors = new List<ValidationErrorInfo>();

            McContext = new MCContext(false);
            FileFormat = FileFormatVersions.Office2007;
        }

        public List<ValidationErrorInfo> Errors => _errors;

        /// <summary>
        /// Gets or sets target file format.
        /// </summary>
        public FileFormatVersions FileFormat { get; set; }

        public bool Valid => _errors.Count == 0;

        public bool IsCancelled => MaxNumberOfErrors > 0 && Errors.Count >= MaxNumberOfErrors;

        public void Clear() => _errors.Clear();

        /// <summary>
        /// Gets or sets the target OpenXmlPackage.
        /// </summary>
        internal OpenXmlPackage Package { get; set; }

        /// <summary>
        /// Gets or sets the target OpenXmlPart
        /// </summary>
        internal OpenXmlPart Part { get; set; }

        /// <summary>
        /// Gets or sets the target element.
        /// </summary>
        internal OpenXmlElement Element { get; set; }

        /// <summary>
        /// Gets or sets used to track MC context.
        /// </summary>
        internal MCContext McContext { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether collect ExpectedChildren or not.
        /// </summary>
        internal bool CollectExpectedChildren { get; set; }

        /// <summary>
        /// Get the first child of this.Element according to the MC Mode.
        /// </summary>
        /// <returns>The first child in the MC mode.</returns>
        internal OpenXmlElement GetFirstChildMc()
        {
            return Element.GetFirstChildMc(McContext, FileFormat);
        }

        /// <summary>
        /// Get the next child of this.Element according to the MC Mode.
        /// </summary>
        /// <param name="child">The child after which the next child going to be retrieved.</param>
        /// <returns>The next child after the specified child in the MC mode.</returns>
        internal OpenXmlElement GetNextChildMc(OpenXmlElement child)
        {
            return Element.GetNextChildMc(child, McContext, FileFormat);
        }

        /// <summary>
        /// Gets or sets the maximum number of errors. A zero (0) value means no limitation.
        /// When the errors >= MaxNumberOfErrors, errors will not be recorded, and MaxNumberOfErrorsEvent will be fired.
        /// </summary>
        public int MaxNumberOfErrors { get; set; }

        public void AddError(ValidationErrorInfo error)
        {
            if (error != null && !IsCancelled)
            {
                _errors.Add(error);
            }
        }
    }
}
