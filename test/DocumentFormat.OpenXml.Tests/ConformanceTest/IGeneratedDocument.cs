// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using System.IO;

namespace DocumentFormat.OpenXml.Tests
{
    public interface IGeneratedDocument
    {
        void CreatePackage(Stream stream);
    }
}
