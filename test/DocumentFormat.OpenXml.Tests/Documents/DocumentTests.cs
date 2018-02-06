// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using System.IO;
using System.IO.Packaging;
using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Tests
{
    public abstract partial class DocumentTests<T>
        where T : OpenXmlPackage
    {
        protected abstract string Path { get; }

        protected abstract T Create(Stream stream, bool autosave);

        protected abstract T Create(Stream stream);

        protected abstract T Open(Stream stream, bool isEditable);

        protected abstract T Open(Package package);

        protected abstract T Open(string path, bool isEditable);

        protected abstract void AddMainPart(T source);

        protected abstract void DuplicateMainPart(T source, T result);

        protected abstract T FromFlatOpcDocument(XDocument document);

        protected abstract T FromFlatOpcDocument(XDocument document, Stream stream, bool isEditable);

        protected abstract T FromFlatOpcDocument(XDocument document, string path, bool isEditable);

        protected abstract T FromFlatOpcDocument(XDocument document, Package package);

        protected abstract T FromFlatOpcString(string text);

        protected abstract T FromFlatOpcString(string text, Stream stream, bool isEditable);

        protected abstract T FromFlatOpcString(string text, string path, bool isEditable);

        protected abstract T FromFlatOpcString(string text, Package package);
    }
}
