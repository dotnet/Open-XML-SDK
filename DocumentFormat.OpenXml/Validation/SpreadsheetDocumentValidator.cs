// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using DocumentFormat.OpenXml.Validation.Semantic;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Validation
{
    /// <summary>
    /// Defines the SpreadsheetDocumentValidator.
    /// </summary>
    internal class SpreadsheetDocumentValidator : DocumentValidator
    {
        private SpreadsheetDocument _spreadsheetDocument;

        /// <summary>
        /// Initializes a new instance of the SpreadsheetDocumentValidator.
        /// </summary>
        /// <param name="settings">The validation settings.</param>
        /// <param name="schemaValidator">The schema validator to be used for schema validation.</param>
        /// <param name="semanticValidator">The semantic validator to be used for semantic validation.</param>
        internal SpreadsheetDocumentValidator(ValidationSettings settings, SchemaValidator schemaValidator, SemanticValidator semanticValidator)
            : base(settings, schemaValidator, semanticValidator)
        {
        }

        /// <summary>
        /// Gets or sets the target document to be validated.
        /// </summary>
        protected override OpenXmlPackage TargetDocument
        {
            get
            {
                return this._spreadsheetDocument;
            }

            set
            {
                this._spreadsheetDocument = (SpreadsheetDocument)value;
            }
        }

        /// <inheritdoc/>
        protected override IEnumerable<OpenXmlPart> PartsToBeValidated
        {
            get
            {
                var workbookPart = this._spreadsheetDocument.WorkbookPart;
                if (workbookPart != null)
                {
                    Dictionary<OpenXmlPart, bool> parts = new Dictionary<OpenXmlPart, bool>();
                    this._spreadsheetDocument.FindAllReachableParts(parts);

                    foreach (var part in parts.Keys)
                    {
                        // Only validate the parts defined in the specified version.
                        // Example: do not validate new Office2010 parts if the FileFormat is Office2007.
                        if (part.IsInVersion(this.ValidationSettings.FileFormat))
                        {
                            yield return part;
                        }
                    }
                }
            }
        }
    }
}
