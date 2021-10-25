// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework.Features;
using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Packaging
{
    internal sealed class RootXElementFeature : IPartRootXElementFeature, IDisposable
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

        /// <summary>
        /// Gets or sets the root LINQ to XML element.
        /// </summary>
        [DisallowNull]
        public XElement? Root
        {
            get
            {
                if (_rootXElement is null)
                {
                    if (_part.IsRootElementLoaded)
                    {
                        _rootXElement = XElement.Parse(_part.RootElement.OuterXml);
                    }
                    else
                    {
                        _rootXElement = LoadRootXElementFromStream();
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

        private void OnPartRootChange(FeatureEventArgs<OpenXmlPart> obj)
        {
            if (_part == obj.Argument)
            {
                _rootXElement = null;
            }
        }

        public void Dispose()
        {
            _events.Change -= OnPartRootChange;
        }
    }
}
