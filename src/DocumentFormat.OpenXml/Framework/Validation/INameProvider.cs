// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using System.Xml;

namespace DocumentFormat.OpenXml.Framework
{
    internal interface INameProvider
    {
        XmlQualifiedName? QName { get; }
    }
}
