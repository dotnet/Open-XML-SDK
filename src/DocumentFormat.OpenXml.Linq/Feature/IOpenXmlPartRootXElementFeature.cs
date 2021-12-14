// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Diagnostics.CodeAnalysis;
using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Feature to allow access to <see cref="XElement"/> representation of a <see cref="OpenXmlPart"/>.
    /// </summary>
    internal interface IOpenXmlPartRootXElementFeature
    {
        /// <summary>
        /// Gets or sets the associated <see cref="XDocument" />. Setting will save the underlying <see cref="OpenXmlPart"/>.
        /// </summary>
        XDocument Document { get; set; }

        /// <summary>
        /// Gets or sets the associated <see cref="XElement"/>. Setting will save the underlying <see cref="OpenXmlPart"/>.
        /// </summary>
        [DisallowNull]
        XElement? Root { get; set; }

        /// <summary>
        /// Gets a value indicating whether the <see cref="Root"/> is loaded from the part or it has been set.
        /// </summary>
        bool IsRootXElementLoaded { get; }

        /// <summary>
        /// Saves the currently loaded, non-null <see cref="Root"/>, if any, to the <see cref="OpenXmlPart"/>.
        /// </summary>
        /// <returns>
        /// <see langword="true"/>, if the currently loaded, non-null <see cref="Root"/> was saved;
        /// <see langword="false"/>, otherwise.
        /// </returns>
        bool Save();
    }
}
