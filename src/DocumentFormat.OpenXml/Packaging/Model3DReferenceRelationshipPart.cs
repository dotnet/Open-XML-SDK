// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

using DocumentFormat.OpenXml.Framework;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines the Model3DReferenceRelationshipPart
    /// </summary>
    public partial class Model3DReferenceRelationshipPart : OpenXmlPart, IFixedContentTypePart
    {
        /// <summary>
        /// Determines if the content type agrees with this part's constraints.
        /// </summary>
        /// <param name="metroPart"></param>
        /// <returns></returns>
        private protected override bool IsValidContentType(PackagePart metroPart)
        {
            if (IsContentTypeFixed && metroPart.ContentType != ContentType)
            {
                return metroPart.ContentType == "model/gltf.binary";
            }

            return true;
        }
    }
}
