// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using System;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Provides extension methods for reading and writing <see cref="XDocument" />
    /// and <see cref="XElement" /> instances from and to <see cref="OpenXmlPart"/>
    /// instances.
    /// </summary>
    public static class LinqExtensions
    {
        internal static readonly XDeclaration XDeclaration = new("1.0", "UTF-8", "yes");

        /// <summary>
        /// Gets the given <see cref="OpenXmlPart" />'s root <see cref="XDocument" />.
        /// </summary>
        /// <param name="part">The <see cref="OpenXmlPart" />.</param>
        /// <returns>The root <see cref="XDocument" />.</returns>
        public static XDocument GetXDocument(this OpenXmlPart part)
        {
            var rootDocument = part.Annotation<XDocument>();
            if (rootDocument != null)
            {
                return rootDocument;
            }

            using Stream stream = part.GetStream();
            if (stream.Length > 0)
            {
                using XmlReader xmlReader = XmlReader.Create(stream);
                rootDocument = XDocument.Load(xmlReader);
            }
            else
            {
                if (LinqUtility.OpenXmlPartInfos.TryGetValue(part.GetType(), out OpenXmlPartInfo? partInfo))
                {
                    var rootElement = new XElement(partInfo.RootName, partInfo.RootNamespaceAttribute);
                    rootDocument = new XDocument(XDeclaration, rootElement);
                }
                else
                {
                    rootDocument = new XDocument(XDeclaration);
                }
            }

            part.AddAnnotation(rootDocument);
            return rootDocument;
        }

        /// <summary>
        /// Gets the given <see cref="OpenXmlPart" />'s root <see cref="XElement" />.
        /// </summary>
        /// <param name="part">The <see cref="OpenXmlPart" />.</param>
        /// <returns>The root <see cref="XElement" />.</returns>
        public static XElement GetXElement(this OpenXmlPart part)
        {
            return part.GetXDocument().Root ?? throw new ArgumentException("Part does not contain a root element.");
        }

        /// <summary>
        /// Saves the cached <see cref="XDocument" /> to the the given <see cref="OpenXmlPart" />.
        /// </summary>
        /// <param name="part">The <see cref="OpenXmlPart" />.</param>
        public static void PutXDocument(this OpenXmlPart part)
        {
            XDocument rootDocument = part.GetXDocument();
            using Stream stream = part.GetStream(FileMode.Create, FileAccess.Write);
            using XmlWriter xmlWriter = XmlWriter.Create(stream);
            rootDocument.Save(xmlWriter);
        }

        /// <summary>
        /// Saves the given <see cref="XDocument" /> to the the given <see cref="OpenXmlPart" />
        /// and caches the <see cref="XDocument" /> as an annotation to the <see cref="OpenXmlPart" />.
        /// </summary>
        /// <param name="part">The <see cref="OpenXmlPart" />.</param>
        /// <param name="document">The <see cref="XDocument" />.</param>
        public static void PutXDocument(this OpenXmlPart part, XDocument document)
        {
            using Stream stream = part.GetStream(FileMode.Create, FileAccess.Write);
            using XmlWriter xmlWriter = XmlWriter.Create(stream);
            document.Save(xmlWriter);

            part.RemoveAnnotations<XDocument>();
            part.AddAnnotation(document);
        }

        /// <summary>
        /// Writes the cached root <see cref="XElement" /> to the given <see cref="OpenXmlPart" />.
        /// </summary>
        /// <param name="part">The <see cref="OpenXmlPart" />.</param>
        public static void PutXElement(this OpenXmlPart part)
        {
            part.PutXDocument();
        }

        /// <summary>
        /// Writes the given root <see cref="XElement" /> to the given <see cref="OpenXmlPart" />
        /// and caches the <see cref="XElement" /> as an annotation to the <see cref="OpenXmlPart" />.
        /// </summary>
        /// <param name="part">The <see cref="OpenXmlPart" />.</param>
        /// <param name="root">The root <see cref="XElement" />.</param>
        public static void PutXElement(this OpenXmlPart part, XElement root)
        {
            part.PutXDocument(new XDocument(XDeclaration, root));
        }
    }
}
