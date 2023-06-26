// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using BenchmarkDotNet.Attributes;
using System.Xml;

namespace DocumentFormat.OpenXml.Benchmarks;

public class ElementTests
{
    [Benchmark]
    public object Construction()
    {
        var element = new TestElement();

        // Force features to be created
        return element.Features;
    }

    private class TestElement : OpenXmlElement
    {
        public override bool HasChildren => throw new System.NotImplementedException();

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
