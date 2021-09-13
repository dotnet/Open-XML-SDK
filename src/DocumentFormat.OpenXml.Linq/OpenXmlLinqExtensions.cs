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

        private sealed class RootXElementFeature : IPartRootXElementFeature, IDisposable
        {
            private readonly OpenXmlPart _part;
            private readonly IPartRootEventsFeature _events;

            private XElement? _rootXElement;

            public RootXElementFeature(OpenXmlPart part)
            {
                _part = part;
                _events = _part.Features.GetRequired<IPartRootEventsFeature>();

                _events.Change += OnPartRootChange;
            }

            private void OnPartRootChange(FeatureEventArgs<OpenXmlPart> obj)
            {
                if (_part == obj.Argument)
                {
                    _rootXElement = null;
                }
            }

            /// <summary>
            /// Gets or sets the root LINQ to XML element.
            /// </summary>
            public XElement? Root
            {
                get
                {
                    if (_rootXElement is null)
                    {
                        if (_part.RootElement is null)
                        {
                            _rootXElement = LoadRootXElementFromStream();
                        }
                        else
                        {
                            _rootXElement = XElement.Parse(_part.RootElement.OuterXml);
                        }
                    }

                    return _rootXElement;
                }

                set
                {
                    _rootXElement = value ?? throw new ArgumentNullException(nameof(value));

                    Save();
                }
            }

            private XElement? LoadRootXElementFromStream()
            {
                using Stream stream = _part.GetStream(FileMode.OpenOrCreate, FileAccess.Read);

                if (stream.Length > 0)
                {
                    using XmlReader xmlReader = XmlReader.Create(stream);
                    XDocument rootXDocument = XDocument.Load(xmlReader);

                    // TODO: Consider replacing only attributes and child nodes.
                    // If the user holds on to a reference to _rootXElement, that
                    // reference will be invalidated.
                    return rootXDocument.Root;
                }

                return null;
            }

            public void Save()
            {
                if (_rootXElement is null)
                {
                    return;
                }

                using (var stream = _part.GetStream(FileMode.Create, FileAccess.Write))
                using (var xmlWriter = XmlWriter.Create(stream))
                {
                    XDocument document = CreateRootXDocument();
                    document.Save(xmlWriter);
                }

                if (_part.IsRootElementLoaded)
                {
                    _part.RootElement.Reload();
                }
            }

            private XDocument CreateRootXDocument()
            {
                return _rootXElement is not null
                    ? new XDocument(new XDeclaration("1.0", "UTF-8", "yes"), _rootXElement)
                    : new XDocument(new XDeclaration("1.0", "UTF-8", "yes"));
            }

            public void Dispose()
            {
                _events.Change -= OnPartRootChange;
            }
        }
    }
}
