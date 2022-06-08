// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

namespace DocumentFormat.OpenXml.Features
{
    internal interface IOpenXmlNamespaceIdResolver
    {
        string GetPrefix(byte id);
    }
}
