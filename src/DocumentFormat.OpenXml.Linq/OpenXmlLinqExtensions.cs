// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework.Features;
using DocumentFormat.OpenXml.Packaging;
using System;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Extensions to access an <see cref="XElement"/> instance for parts.
    /// </summary>
    public static class OpenXmlLinqExtensions
    {
        /// <summary>
        /// Will create or get a cached instance of <see cref="IPartRootXElementFeature"/>.
        /// </summary>
        /// <param name="part">The part to provide an <see cref="XElement"/> instance.</param>
        /// <returns>A <see cref="IPartRootXElementFeature"/>.</returns>
        public static IPartRootXElementFeature GetPartRootXElementFeature(this OpenXmlPart part)
        {
            var feature = part.Features.Get<IPartRootXElementFeature>();

            if (feature is not null)
            {
                return feature;
            }

            part.TryAddDisposableFeature();
            part.TryAddPartRootEventsFeature();

            var xelement = new RootXElementFeature(part);

            part.Features.SetDisposable<IPartRootXElementFeature>(xelement);

            return xelement;
        }

        /// <summary>
        /// Gets an <see cref="XElement"/> representation of the <paramref name="part"/>.
        /// </summary>
        /// <remarks>
        /// When called with a given <see cref="OpenXmlPart"/> for the first time after having
        /// opened the containing <see cref="OpenXmlPackage"/> or saved the strongly-typed
        /// <see cref="OpenXmlPartRootElement"/> to the OpenXmlPart, deserializes, caches, and
        /// returns the outer XML of an already loaded OpenXmlPartRootElement or the content
        /// of the OpenXmlPart as an <see cref="XElement"/>. In the following calls, directly
        /// returns the cached XElement.
        /// </remarks>
        /// <param name="part">The part to get the contents of.</param>
        /// <returns>An <see cref="XElement"/>.</returns>
        public static XElement? GetXElement(this OpenXmlPart part)
            => part.GetPartRootXElementFeature().Root;

        /// <summary>
        /// Sets the <see cref="OpenXmlPart"/>'s root <see cref="XElement"/> to the given XElement,
        /// serializes and writes the XElement to the OpenXmlPart, and reloads the OpenXmlPart's
        /// <see cref="OpenXmlPartRootElement"/> if it was previously loaded.
        /// </summary>
        /// <param name="part">The <see cref="OpenXmlPart"/>.</param>
        /// <param name="element">The <see cref="XElement"/>.</param>
        public static void SetXElement(this OpenXmlPart part, XElement element)
            => part.GetPartRootXElementFeature().Root = element;

        /// <summary>
        /// Saves the current <see cref="XElement"/> to the part.
        /// </summary>
        /// <param name="part">The part to save to.</param>
        public static void SaveXElement(this OpenXmlPart part)
            => part.GetPartRootXElementFeature().Save();
    }
}
