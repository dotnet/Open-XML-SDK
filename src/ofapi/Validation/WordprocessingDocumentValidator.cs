// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Internal.SchemaValidation;
using DocumentFormat.OpenXml.Internal.SemanticValidation;

namespace DocumentFormat.OpenXml.Validation
{
    /// <summary>
    /// Defines the WordprocessingDocumentValidator.
    /// </summary>
    internal class WordprocessingDocumentValidator :  DocumentValidator
    {
        private WordprocessingDocument _wordprossingDocument;

        /// <summary>
        /// Initializes a new instance of the WordprocessingDocumentValidator.
        /// </summary>
        /// <param name="settings">The validation settings.</param>
        /// <param name="schemaValidator">The schema validator to be used for schema validation.</param>
        /// <param name="semanticValidator">The semantic validator to be used for semantic validation.</param>
        internal WordprocessingDocumentValidator(ValidationSettings settings, SchemaValidator schemaValidator, SemanticValidator semanticValidator)
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
                return this._wordprossingDocument;
            }
            set
            {
                this._wordprossingDocument = (WordprocessingDocument)value;
            }
        }

        /// <summary>
        /// Returns all the parts needs to be validated.
        /// </summary>
        protected override IEnumerable<OpenXmlPart> PartsToBeValidated
        {
            get
            {
                var mainPart = this._wordprossingDocument.MainDocumentPart;
                if (mainPart != null)
                {
                    Dictionary<OpenXmlPart, bool> parts = new Dictionary<OpenXmlPart, bool>();
                    this._wordprossingDocument.FindAllReachableParts(parts);

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
