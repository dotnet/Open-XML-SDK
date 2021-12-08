// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Extensions to access the <see cref="XElement"/> representation of an <see cref="OpenXmlPart"/>'s
    /// root element, either directly or via the containing <see cref="XDocument"/>.
    /// </summary>
    public static class OpenXmlPartRootXElementExtensions
    {
        /// <summary>
        /// Will create or get a cached instance of <see cref="IOpenXmlPartRootXElementFeature"/>.
        /// </summary>
        /// <param name="part">The part to provide an <see cref="XElement"/> instance.</param>
        /// <returns>A <see cref="IOpenXmlPartRootXElementFeature"/>.</returns>
        internal static IOpenXmlPartRootXElementFeature GetOpenXmlPartRootXElementFeature(this OpenXmlPart part)
        {
            var feature = part.Features.Get<IOpenXmlPartRootXElementFeature>();

            if (feature is not null)
            {
                return feature;
            }

            part.AddDisposableFeature();
            part.AddPartRootEventsFeature();

            feature = new OpenXmlPartRootXElementFeature(part);

            part.Features.SetDisposable(feature);

            return feature;
        }

        /// <summary>
        /// Gets an <see cref="XDocument"/> representation of the <paramref name="part"/>.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This method always returns the same <see cref="XDocument"/> instance, unless that
        /// instance is changed via <see cref="SetXDocument"/>. Calling this method has the same
        /// effect as calling <c>part.GetXElement().Document</c>.
        /// </para>
        /// <para>
        /// When called with a given <see cref="OpenXmlPart"/> for the first time after having
        /// opened the containing <see cref="OpenXmlPackage"/> or saved the strongly-typed
        /// <see cref="OpenXmlPartRootElement"/> to the OpenXmlPart, deserializes, caches, and
        /// returns the outer XML of an already loaded OpenXmlPartRootElement or the content
        /// of the OpenXmlPart as an <see cref="XDocument"/>. In the following calls, directly
        /// returns the cached XDocument.
        /// </para>
        /// </remarks>
        /// <param name="part">The part to get the contents of.</param>
        /// <returns>An <see cref="XDocument"/>.</returns>
        /// <seealso cref="GetXElement"/>
        /// <seealso cref="SetXDocument"/>
        /// <seealso cref="SaveXDocument"/>
        public static XDocument GetXDocument(this OpenXmlPart part)
            => part.GetOpenXmlPartRootXElementFeature().Document;

        /// <summary>
        /// Gets an <see cref="XElement"/> representation of the <paramref name="part"/>.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Calling this method has same effect as calling <c>part.GetXDocument().Root</c>.
        /// </para>
        /// <para>
        /// When called with a given <see cref="OpenXmlPart"/> for the first time after having
        /// opened the containing <see cref="OpenXmlPackage"/> or saved the strongly-typed
        /// <see cref="OpenXmlPartRootElement"/> to the OpenXmlPart, deserializes, caches, and
        /// returns the outer XML of an already loaded OpenXmlPartRootElement or the content
        /// of the OpenXmlPart as an <see cref="XElement"/>. In the following calls, directly
        /// returns the cached XElement.
        /// </para>
        /// </remarks>
        /// <param name="part">The part to get the contents of.</param>
        /// <returns>An <see cref="XElement"/>.</returns>
        /// <seealso cref="GetXDocument"/>
        /// <seealso cref="SetXElement"/>
        /// <seealso cref="SaveXElement"/>
        public static XElement? GetXElement(this OpenXmlPart part)
            => part.GetOpenXmlPartRootXElementFeature().Root;

        /// <summary>
        /// Gets a value indicating whether the root <see cref="XElement"/> is loaded from the part
        /// or it has been set.
        /// </summary>
        /// <param name="part">The <see cref="OpenXmlPart"/>.</param>
        /// <returns>
        /// <see langword="true"/>, if the current root <see cref="XElement"/> is loaded from the part or it has been set;
        /// <see langword="false"/>, otherwise.
        /// </returns>
        public static bool IsRootXElementLoaded(this OpenXmlPart part)
            => part.GetOpenXmlPartRootXElementFeature().IsRootXElementLoaded;

        /// <summary>
        /// Sets the <see cref="OpenXmlPart"/>'s <see cref="XDocument"/> to the given XDocument,
        /// serializes and writes the XDocument to the OpenXmlPart, and reloads the OpenXmlPart's
        /// <see cref="OpenXmlPartRootElement"/> if it was previously loaded.
        /// </summary>
        /// <param name="part">The <see cref="OpenXmlPart"/>.</param>
        /// <param name="document">The <see cref="XDocument"/>.</param>
        /// <seealso cref="GetXDocument"/>
        /// <seealso cref="SaveXDocument"/>
        public static void SetXDocument(this OpenXmlPart part, XDocument document)
            => part.GetOpenXmlPartRootXElementFeature().Document = document;

        /// <summary>
        /// Sets the <see cref="OpenXmlPart"/>'s root <see cref="XElement"/> to the given XElement,
        /// serializes and writes the XElement to the OpenXmlPart, and reloads the OpenXmlPart's
        /// <see cref="OpenXmlPartRootElement"/> if it was previously loaded.
        /// </summary>
        /// <remarks>
        /// Effectively sets the <see cref="XDocument.Root"/> property of the <see cref="XDocument"/>
        /// returned by <see cref="GetXDocument"/>.
        /// </remarks>
        /// <param name="part">The <see cref="OpenXmlPart"/>.</param>
        /// <param name="element">The <see cref="XElement"/>.</param>
        /// <seealso cref="GetXElement"/>
        /// <seealso cref="SaveXElement"/>
        public static void SetXElement(this OpenXmlPart part, XElement element)
            => part.GetOpenXmlPartRootXElementFeature().Root = element;

        /// <summary>
        /// Saves the current <see cref="XDocument"/> to the part if it and its <see cref="XDocument.Root"/>
        /// element is not <see langword="null"/>.
        /// </summary>
        /// <remarks>
        /// Calling this method has the same effect as calling <seealso cref="SaveXElement"/>.
        /// This method is provided for naming consistency with <see cref="GetXDocument"/> and
        /// <see cref="SetXDocument"/>.
        /// </remarks>
        /// <param name="part">The part to save to.</param>
        /// <returns>
        /// <see langword="true"/>, if the current <see cref="XDocument"/> was saved to the part;
        /// <see langword="false"/>, otherwise.
        /// </returns>
        public static bool SaveXDocument(this OpenXmlPart part)
            => part.GetOpenXmlPartRootXElementFeature().Save();

        /// <summary>
        /// Saves the current <see cref="XDocument"/> to the part if it and its <see cref="XDocument.Root"/>
        /// element is not <see langword="null"/>.
        /// </summary>
        /// <remarks>
        /// Calling this method has the same effect as calling <see cref="SaveXDocument"/>.
        /// This method is provided for naming consistency with <see cref="GetXElement"/> and
        /// <see cref="SetXElement"/>.
        /// </remarks>
        /// <param name="part">The part to save to.</param>
        /// <returns>
        /// <see langword="true"/>, if the current <see cref="XDocument"/> was saved to the part;
        /// <see langword="false"/>, otherwise.
        /// </returns>
        public static bool SaveXElement(this OpenXmlPart part)
            => part.GetOpenXmlPartRootXElementFeature().Save();
    }
}
