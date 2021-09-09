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
        /// Try adding a feature to enable accessing <see cref="XElement"/> representations of parts.
        /// </summary>
        /// <param name="package">Package to enable feature on.</param>
        /// <returns>Whether the feature was added. False if already present.</returns>
        public static bool TrySetPartRootXElementFeature(this OpenXmlPackage package)
        {
            package.TryAddDisposableFeature();
            package.TryAddPartRootEventsFeature();

            return true;
        }

        /// <summary>
        /// Will create or get a cached instance of <see cref="IPartRootXElementFeature"/>.
        /// </summary>
        /// <param name="part">The part to provide an <see cref="XElement"/> instance.</param>
        /// <returns>A <see cref="IPartRootXElementFeature"/>.</returns>
        internal static IPartRootXElementFeature GetPartRootXElementFeature(this OpenXmlPart part)
        {
            var feature = part.Features.Get<IPartRootXElementFeature>();

            if (feature is not null)
            {
                return feature;
            }

            var xelement = new RootXElementFeature(part);

            part.Features.SetDisposable<IPartRootXElementFeature>(xelement);

            return xelement;
        }

        /// <summary>
        /// Gets an <see cref="XElement"/> representation of the <paramref name="part"/>.
        /// </summary>
        /// <param name="part">The part to get the contents of.</param>
        /// <returns>An <see cref="XElement"/>.</returns>
        public static XElement? GetXElement(this OpenXmlPart part)
            => part.GetPartRootXElementFeature().Root;

        /// <summary>
        /// Sets an <see cref="XElement"/> to the part. This will force a save to the underlying stream.
        /// </summary>
        /// <param name="part">The part to set to.</param>
        /// <param name="xElement">The element to set.</param>
        public static void SetXElement(this OpenXmlPart part, XElement? xElement)
            => part.GetPartRootXElementFeature().Root = xElement;

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
                            LoadRootXElementFromStream();
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

            private void LoadRootXElementFromStream()
            {
                using Stream stream = _part.GetStream(FileMode.OpenOrCreate, FileAccess.Read);

                if (stream.Length > 0)
                {
                    using XmlReader xmlReader = XmlReader.Create(stream);
                    XDocument rootXDocument = XDocument.Load(xmlReader);
                    _rootXElement = rootXDocument.Root;

                    // TODO: Consider replacing only attributes and child nodes.
                    // If the user holds on to a reference to _rootXElement, that
                    // reference will be invalidated.
                }
                else
                {
                    _rootXElement = null;
                }
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

                if (_part.RootElement is not null)
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
