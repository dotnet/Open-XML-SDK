// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Packaging
{
    internal sealed class OpenXmlPartRootXElementFeature : IOpenXmlPartRootXElementFeature, IDisposable
    {
        private readonly OpenXmlPart _part;
        private readonly IPartRootEventsFeature _events;

        private XDocument? _partXDocument;

        public OpenXmlPartRootXElementFeature(OpenXmlPart part)
        {
            _part = part;
            _events = _part.Features.GetRequired<IPartRootEventsFeature>();

            _events.Change += OnPartRootChange;
        }

        /// <inheritdoc />
        public XDocument Document
        {
            get
            {
                if (_partXDocument is not null)
                {
                    if (_partXDocument.Root is null)
                    {
                        // Add null or the root XElement.
                        _partXDocument.Add(LoadRootXElement());
                    }

                    return _partXDocument;
                }

                _partXDocument = LoadRootXElement() switch
                {
                    // The part is empty.
                    null => new XDocument(new XDeclaration("1.0", "UTF-8", "yes")),

                    // The part has XML content that was loaded from the part stream.
                    { Document: { } } root => root.Document!,

                    // The part has XML content that was loaded from RootElement.OuterXml.
                    var root => new XDocument(new XDeclaration("1.0", "UTF-8", "yes"), root),
                };

                return _partXDocument;
            }

            set
            {
                if (value.Root is null)
                {
                    throw new ArgumentException("Root must not be null.");
                }

                _partXDocument = value;

                Save();
            }
        }

        /// <inheritdoc />
        [DisallowNull]
        public XElement? Root
        {
            get => Document.Root;

            set
            {
                if (value is null)
                {
                    throw new ArgumentNullException(nameof(value));
                }

                if (_partXDocument is null)
                {
                    _partXDocument = new XDocument(new XDeclaration("1.0", "UTF-8", "yes"), value);
                }
                else if (_partXDocument.Root is null)
                {
                    _partXDocument.Add(value);
                }
                else
                {
                    _partXDocument.Root.ReplaceWith(value);
                }

                Save();
            }
        }

        /// <inheritdoc />
        [MemberNotNullWhen(true, nameof(_partXDocument))]
        [MemberNotNullWhen(true, nameof(Root))]
        public bool IsRootXElementLoaded => _partXDocument?.Root is not null;

        private XElement? LoadRootXElement()
        {
            // The XElement.Parse() method will return a non-null XElement that is not associated
            // to an XDocument, i.e., the Document property is null. LoadRootXElementFromStream()
            // returns null or an XElement that is associated to an XDocument.
            return _part.IsRootElementLoaded
                ? XElement.Parse(_part.RootElement.OuterXml)
                : LoadRootXElementFromStream();
        }

        private XElement? LoadRootXElementFromStream()
        {
            using Stream stream = _part.GetStream(FileMode.OpenOrCreate, FileAccess.Read);

            if (stream.Length == 0)
            {
                return null;
            }

            using XmlReader xmlReader = XmlReader.Create(stream);
            XDocument partXDocument = XDocument.Load(xmlReader);

            return partXDocument.Root;
        }

        /// <inheritdoc />
        public bool Save()
        {
            if (!IsRootXElementLoaded)
            {
                return false;
            }

            using (var stream = _part.GetStream(FileMode.Create, FileAccess.Write))
            using (var xmlWriter = XmlWriter.Create(stream))
            {
                _partXDocument.Save(xmlWriter);
            }

            if (_part.IsRootElementLoaded)
            {
                _part.RootElement.Reload();
            }

            return true;
        }

        private void OnPartRootChange(FeatureEventArgs<OpenXmlPart> obj)
        {
            if (_part == obj.Argument && _partXDocument?.Root is not null)
            {
                _partXDocument.Root.Remove();
            }
        }

        /// <inheritdoc />
        public void Dispose()
        {
            _events.Change -= OnPartRootChange;
        }
    }
}
