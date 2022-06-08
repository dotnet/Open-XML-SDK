// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using System;
using System.Xml;

namespace DocumentFormat.OpenXml.Tests
{
    internal class MockedOpenXmlElement : OpenXmlElement
    {
        public override bool HasChildren => throw new NotImplementedException();

        public override void RemoveAllChildren() => throw new NotImplementedException();

        internal override void WriteContentTo(XmlWriter w) => throw new NotImplementedException();

        private protected override void Populate(XmlReader xmlReader, OpenXmlLoadMode loadMode) => throw new NotImplementedException();
    }
}
