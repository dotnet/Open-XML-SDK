// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using System.IO;
using System.IO.Packaging;
using Xunit;

using static DocumentFormat.OpenXml.Tests.TestAssets;

namespace DocumentFormat.OpenXml.Tests
{
    public abstract partial class DocumentTests<T>
        where T : OpenXmlPackage
    {
        [Fact]
        public void CanCreateFlatOpcDocuments1()
        {
            using (var inputStream = GetStream(Path))
            using (var source = Open(inputStream, false))
            {
                var flatOpcDoc = source.ToFlatOpcDocument();

                using (var dest = FromFlatOpcDocument(flatOpcDoc))
                {
                    PackageAssert.Equal(source, dest);
                }
            }
        }

        [Fact]
        public void CanCreateFlatOpcDocuments2()
        {
            using (var inputStream = GetStream(Path))
            using (var source = Open(inputStream, false))
            {
                var flatOpcDoc = source.ToFlatOpcDocument();

                using (var stream = new MemoryStream())
                using (FromFlatOpcDocument(flatOpcDoc, stream, false))
                using (var dest = Open(stream, false))
                {
                    PackageAssert.Equal(source, dest);
                }
            }
        }

        [Fact]
        public void CanCreateFlatOpcDocuments3()
        {
            using (var inputStream = GetStream(Path))
            using (var source = Open(inputStream, false))
            {
                var flatOpcDoc = source.ToFlatOpcDocument();

                using (var tempFile = TemporaryFile.Create())
                using (FromFlatOpcDocument(flatOpcDoc, tempFile.Path, false))
                using (var dest = Open(tempFile.Path, false))
                {
                    PackageAssert.Equal(source, dest);
                }
            }
        }

        [Fact]
        public void CanCreateFlatOpcDocuments4()
        {
            using (var inputStream = GetStream(Path))
            using (var source = Open(inputStream, false))
            {
                var flatOpcDoc = source.ToFlatOpcDocument();

                using (var stream = new MemoryStream())
                using (var package = Package.Open(stream, FileMode.Create, FileAccess.ReadWrite))
                using (var dest = FromFlatOpcDocument(flatOpcDoc, package))
                {
                    PackageAssert.Equal(source, dest);
                }
            }
        }

        [Fact]
        public void CanCreateFlatOpcDocuments5()
        {
            using (var inputStream = GetStream(Path))
            using (var source = Open(inputStream, false))
            {
                var flatOpcString = source.ToFlatOpcString();

                using (var dest = FromFlatOpcString(flatOpcString))
                {
                    PackageAssert.Equal(source, dest);
                }
            }
        }

        [Fact]
        public void CanCreateFlatOpcDocuments6()
        {
            using (var inputStream = GetStream(Path))
            using (var source = Open(inputStream, false))
            {
                var flatOpcString = source.ToFlatOpcString();

                using (var stream = new MemoryStream())
                using (FromFlatOpcString(flatOpcString, stream, false))
                using (var dest = Open(stream, false))
                {
                    PackageAssert.Equal(source, dest);
                }
            }
        }

        [Fact]
        public void CanCreateFlatOpcDocuments7()
        {
            using (var inputStream = GetStream(Path))
            using (var source = Open(inputStream, false))
            {
                var flatOpcString = source.ToFlatOpcString();

                using (var tempFile = TemporaryFile.Create())
                using (FromFlatOpcString(flatOpcString, tempFile.Path, false))
                using (var dest = Open(tempFile.Path, false))
                {
                    PackageAssert.Equal(source, dest);
                }
            }
        }

        [Fact]
        public void CanCreateFlatOpcDocuments8()
        {
            using (var inputStream = GetStream(Path))
            using (var source = Open(inputStream, false))
            {
                var flatOpcString = source.ToFlatOpcString();

                using (var stream = new MemoryStream())
                using (var package = Package.Open(stream, FileMode.Create, FileAccess.ReadWrite))
                using (var dest = FromFlatOpcString(flatOpcString, package))
                {
                    PackageAssert.Equal(source, dest);
                }
            }
        }

        [Fact]
        public void CanCreateFlatOpcDocumentsDynamically()
        {
            using (var stream = new MemoryStream())
            using (var document = Create(stream))
            {
                AddMainPart(document);

                document.Save();

                if (OpenXmlPackage.CanSave)
                {
                    string opc = document.ToFlatOpcString();
                    using (var dest = FromFlatOpcString(opc))
                    {
                        PackageAssert.Equal(document, dest);
                    }
                }
                else
                {
                    Assert.Throws<IOException>(() => document.ToFlatOpcString());
                }
            }
        }
    }
}
