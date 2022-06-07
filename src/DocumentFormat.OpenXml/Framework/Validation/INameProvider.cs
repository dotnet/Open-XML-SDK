// Copyright (c) Microsoft.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml;

namespace DocumentFormat.OpenXml.Framework
{
    internal interface INameProvider
    {
        XmlQualifiedName? QName { get; }
    }
}
