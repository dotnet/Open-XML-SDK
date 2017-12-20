// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Validation.Schema
{
    /// <summary>
    /// xsd:use type.
    /// </summary>
    /// <remarks>
    /// Same as XmlSchemaUse.
    /// </remarks>
    internal enum XsdAttributeUse : byte
    {
        None = 0,
        Optional,
        Prohibited,
        Required,
    }
}
