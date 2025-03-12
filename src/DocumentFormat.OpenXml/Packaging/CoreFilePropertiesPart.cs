// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines the CoreFilePropertiesPart
    /// </summary>
    public partial class CoreFilePropertiesPart : OpenXmlPart,
        IFixedContentTypePart
    {
        /// <summary>
        /// Gets the package (core.xml) properties.
        /// </summary>
        public IPackageProperties CoreFileProperties => OpenXmlPackage.PackageProperties;
    }
}
