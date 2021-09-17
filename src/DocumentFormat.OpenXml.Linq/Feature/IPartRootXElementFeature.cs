// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Diagnostics.CodeAnalysis;
using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Feature to allow access to <see cref="XElement"/> representation of a <see cref="OpenXmlPart"/>.
    /// </summary>
    public interface IPartRootXElementFeature
    {
        /// <summary>
        /// Gets or sets the associated <see cref="XElement"/>. Setting will save the underlying <see cref="OpenXmlPart"/>.
        /// </summary>
        [DisallowNull]
        XElement? Root { get; set; }

        /// <summary>
        /// Save the current <see cref="Root"/> to the <see cref="OpenXmlPart"/>.
        /// </summary>
        void Save();
    }
}
