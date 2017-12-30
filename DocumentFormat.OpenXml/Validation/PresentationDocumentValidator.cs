// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using DocumentFormat.OpenXml.Validation.Semantic;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Validation
{
    /// <summary>
    /// Defines the PresentationDocumentValidator.
    /// </summary>
    internal class PresentationDocumentValidator :  DocumentValidator
    {
        private PresentationDocument _presentationDocument;

        /// <summary>
        /// Initializes a new instance of the PresentationDocumentValidator.
        /// </summary>
        /// <param name="settings">The validation settings.</param>
        /// <param name="schemaValidator">The schema validator to be used for schema validation.</param>
        /// <param name="semanticValidator">The semantic validator to be used for semantic validation.</param>
        internal PresentationDocumentValidator(ValidationSettings settings, SchemaValidator schemaValidator, SemanticValidator semanticValidator)
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
                return this._presentationDocument;
            }

            set
            {
                this._presentationDocument = (PresentationDocument)value;
            }
        }

        /// <inheritdoc/>
        protected override IEnumerable<OpenXmlPart> PartsToBeValidated
        {
            get
            {
                var mainPart = this._presentationDocument.PresentationPart;
                if (mainPart != null)
                {
                    Dictionary<OpenXmlPart, bool> parts = new Dictionary<OpenXmlPart, bool>();
                    this._presentationDocument.FindAllReachableParts(parts);

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
