// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#if NET462 || NET

using DocumentFormat.OpenXml.Packaging;
using ObjectLayoutInspector;
using System;
using System.Collections.Generic;
using System.Xml;
using Xunit;
using Xunit.Abstractions;

namespace DocumentFormat.OpenXml.Framework.Tests;

public class ObjectSizeTests
{
    private readonly ITestOutputHelper _output;

    public ObjectSizeTests(ITestOutputHelper output)
    {
        _output = output;
    }

    [InlineData(typeof(TestOpenXmlElement), 64, 80, 0, 6)]
    [InlineData(typeof(TestOpenXmlElement.FeatureCollection), 24, 40, 0, 3)]
    [InlineData(typeof(TestOpenXmlPackage), 24, 40, 3, 5)]
    [InlineData(typeof(TestOpenXmlPackage.FeatureCollection), 88, 104, 0, 10)]
    [InlineData(typeof(TestOpenXmlPart), 32, 48, 7, 5)]
    [InlineData(typeof(TestOpenXmlPart.FeatureCollection), 48, 64, 0, 5)]
    [InlineData(typeof(TestOpenXmlPartContainer), 8, 24, 0, 1)]
    [InlineData(typeof(TestOpenXmlCompositeElement), 72, 88, 0, 7)]
    [InlineData(typeof(TestOpenXmlLeafElement), 72, 88, 0, 7)]
    [InlineData(typeof(TestOpenXmlLeafTextElement), 80, 96, 0, 8)]
    [InlineData(typeof(OpenXmlUnknownElement), 104, 120, 0, 11)]
    [Theory]
    public void VerifySize(Type type, int size, int fullSize, int padding, int fieldCount)
    {
        // Arrange
        var layout = TypeLayout.GetLayout(type);

        _output.WriteLine($"typeof({GetTypeName(type)}), {layout.Size}, {layout.FullSize}, {layout.Paddings}, {layout.Fields.Length}");
        _output.WriteLine(layout.ToString());

        // Assert
        Assert.Equal(size, layout.Size);
        Assert.Equal(fullSize, layout.FullSize);
        Assert.Equal(padding, layout.Paddings);
        Assert.Equal(fieldCount, layout.Fields.Length);
    }

    private static string GetTypeName(Type type)
    {
        return type.FullName.Substring(type.FullName.IndexOf('+') + 1).Replace('+', '.');
    }

    private sealed class TestOpenXmlElement : OpenXmlElement
    {
        public override bool HasChildren => throw new NotImplementedException();

        public override void RemoveAllChildren()
        {
            throw new NotImplementedException();
        }

        internal override void WriteContentTo(XmlWriter w)
        {
            throw new NotImplementedException();
        }

        private protected override void Populate(XmlReader xmlReader, OpenXmlLoadMode loadMode)
        {
            throw new NotImplementedException();
        }

        internal class FeatureCollection : ElementFeatureCollection
        {
            public FeatureCollection()
                : base(null!)
            {
            }
        }
    }

    private sealed class TestOpenXmlPackage : OpenXmlPackage
    {
        internal sealed class FeatureCollection : PackageFeatureCollection
        {
            public FeatureCollection()
                : base(null!)
            {
            }
        }
    }

    private sealed class TestOpenXmlPart : OpenXmlPart
    {
        public override string RelationshipType => throw new NotImplementedException();

        internal sealed class FeatureCollection : PartFeatureCollection
        {
            public FeatureCollection()
                : base(null!)
            {
            }
        }
    }

    private sealed class TestOpenXmlPartContainer : OpenXmlPartContainer
    {
        internal override OpenXmlPackage InternalOpenXmlPackage => throw new NotImplementedException();

        internal override OpenXmlPart ThisOpenXmlPart => throw new NotImplementedException();

        internal override IRelationshipCollection Relationships => throw new NotImplementedException();

        protected override void ThrowIfObjectDisposed()
        {
            throw new NotImplementedException();
        }

        internal override void FindAllReachableParts(IDictionary<OpenXmlPart, bool> reachableParts)
        {
            throw new NotImplementedException();
        }
    }

    private sealed class TestOpenXmlCompositeElement : OpenXmlCompositeElement
    {
    }

    private sealed class TestOpenXmlLeafElement : OpenXmlLeafElement
    {
    }

    private sealed class TestOpenXmlLeafTextElement : OpenXmlLeafTextElement
    {
    }
}

#endif
