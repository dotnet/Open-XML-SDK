// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

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
