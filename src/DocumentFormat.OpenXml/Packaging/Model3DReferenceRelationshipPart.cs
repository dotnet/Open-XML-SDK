// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using DocumentFormat.OpenXml.Framework;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines the Model3DReferenceRelationshipPart
    /// </summary>
    public partial class Model3DReferenceRelationshipPart
    {
        /// <inheritdoc/>
        private protected override bool IsValidContentType(PackagePart part)
        {
            if (base.IsValidContentType(part))
            {
                return true;
            }

            // model/gltf.binary is an acceptable MIME for this part, PowerPoint writes this on save.
            return part.ContentType == "model/gltf.binary";
        }
    }
}
