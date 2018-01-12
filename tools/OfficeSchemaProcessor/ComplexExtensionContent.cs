// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Schema;

namespace OfficeSchemaProcessor
{
    internal class ComplexExtensionContent
    {
        public ComplexExtensionContent(XmlSchemaSequence eles, XmlSchemaObjectCollection attrs)
        {
            Elements = eles;
            Attributes = attrs;
        }

        public XmlSchemaSequence Elements { get; }

        public XmlSchemaObjectCollection Attributes { get; }
    }
}
