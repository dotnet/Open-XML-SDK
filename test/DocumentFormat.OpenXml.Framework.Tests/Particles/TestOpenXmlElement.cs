// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

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
