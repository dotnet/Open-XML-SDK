// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.IO;

namespace DocumentFormat.OpenXml.Tests
{
    public interface IFile : IDisposable
    {
        string Path { get; }

        Stream Open();
    }
}
