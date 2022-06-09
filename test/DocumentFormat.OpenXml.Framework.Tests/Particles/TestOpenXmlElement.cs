// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml;

namespace DocumentFormat.OpenXml.Framework.Tests
{
    internal class TestOpenXmlElement : OpenXmlElement
    {
        public override bool HasChildren => false;

        public override void RemoveAllChildren()
        {
            throw new System.NotImplementedException();
        }

        internal override void WriteContentTo(XmlWriter w)
        {
            throw new System.NotImplementedException();
        }

        private protected override void Populate(XmlReader xmlReader, OpenXmlLoadMode loadMode)
        {
            throw new System.NotImplementedException();
        }
    }
}
