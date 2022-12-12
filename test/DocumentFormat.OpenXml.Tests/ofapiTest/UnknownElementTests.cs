// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Packaging;
using NSubstitute;
using System;
using Xunit;

namespace DocumentFormat.OpenXml.Tests;

public class UnknownElementTests
{
    /// <summary>
    /// A test for the OpenXmlUnknownElement.CreateOpenXmlUnknownElement with an outer xml.
    /// </summary>
    [Fact]
    public void CreateOpenXmlUnknownElmenentTest()
    {
        var container = GetContainer();

        // Valid outer xml
        var validOuterXml = "<myElement  xmlns=\"http://schemas.microsoft.com/office/2006/01/customui\"></myElement>";
        var unknown1 = container.CreateUnknownElement(validOuterXml);
        Assert.Equal(validOuterXml, unknown1.OuterXml);

        // Valid outer xml but starting with whitespace.
        var validOuterXmlWithWhitespaces = "   <myElement  xmlns=\"http://schemas.microsoft.com/office/2006/01/customui\"></myElement>";
        var unknown2 = container.CreateUnknownElement(validOuterXmlWithWhitespaces);
        Assert.Equal(validOuterXmlWithWhitespaces, unknown2.OuterXml);

        // Check bug #484153.
        var outerXmlWithXmlDecl = "<?xml version=\"1.0\" encoding=\"utf-8\"?><customUI  xmlns=\"http://schemas.microsoft.com/office/2006/01/customui\"></customUI>";
        var ex1 = Assert.Throws<ArgumentException>(() => container.CreateUnknownElement(outerXmlWithXmlDecl));
        Assert.StartsWith(ExceptionMessages.InvalidOuterXml, ex1.Message);
    }

    [Fact]
    public void Create2()
    {
        var paragraphOuterXml = "<w:p w:rsidP=\"001\" xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\"><w:r><w:t>Run Text.</w:t><w:t>Run 2.</w:t></w:r></w:p>";
        var paragraphInnerXml = "<w:r xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\"><w:t>Run Text.</w:t><w:t>Run 2.</w:t></w:r>";

        var unknownElement = GetContainer().CreateUnknownElement(paragraphOuterXml);
        Assert.Equal(paragraphOuterXml, unknownElement.OuterXml);
        Assert.Equal(paragraphInnerXml, unknownElement.InnerXml);
    }

    [Fact]
    public void TwiceCallsToLoadAttributeOnUnknown()
    {
        var container = GetContainer();

        var rawxml = @"<dgm14:cNvPr xmlns:dgm14=""http://schemas.microsoft.com/officeart/2007/7/20/diagram"" id=""0"" name="""" />";
        var ele = container.CreateUnknownElement(rawxml);

        Assert.Equal(2, ele.GetAttributes().Count);
        Assert.Equal(rawxml, ele.OuterXml);

        var clone = ele.Clone() as OpenXmlUnknownElement;
        Assert.Equal(2, clone.GetAttributes().Count);
        Assert.Equal(rawxml, clone.OuterXml);
    }

    /// <summary>
    /// Test the Clone on OpenXmlUnknownElement.
    /// </summary>
    [Fact]
    public void CloneUnknownElementTest()
    {
        string outerXml = "<a:txBody xmlns:a=\"http://schemas.openxmlformats.org/drawingml/2006/main\"><a:p><a:r><a:t>Text in &lt;drawing&gt;.</a:t></a:r></a:p></a:txBody>";

        var container = GetContainer();

        OpenXmlUnknownElement unknownElement = container.CreateUnknownElement(outerXml);

        Assert.IsType<OpenXmlUnknownElement>(unknownElement.FirstChild);
        Assert.IsType<OpenXmlUnknownElement>(unknownElement.FirstChild.FirstChild);
        Assert.IsType<OpenXmlUnknownElement>(unknownElement.FirstChild.FirstChild.FirstChild);
        Assert.Equal("Text in <drawing>.", (unknownElement.FirstChild.FirstChild.FirstChild as OpenXmlUnknownElement).Text);

        Assert.Equal(outerXml, unknownElement.OuterXml);

        OpenXmlElement clonedElement = unknownElement.CloneNode(true);

        Assert.Equal("txBody", clonedElement.LocalName);
        Assert.Equal("a", clonedElement.Prefix);
        Assert.Equal("http://schemas.openxmlformats.org/drawingml/2006/main", clonedElement.NamespaceUri);
        Assert.IsType<OpenXmlUnknownElement>(clonedElement);

        Assert.IsType<OpenXmlUnknownElement>(clonedElement.FirstChild);
        Assert.IsType<OpenXmlUnknownElement>(clonedElement.FirstChild.FirstChild);
        Assert.IsType<OpenXmlUnknownElement>(clonedElement.FirstChild.FirstChild.FirstChild);
        Assert.Equal("Text in <drawing>.", (clonedElement.FirstChild.FirstChild.FirstChild as OpenXmlUnknownElement).Text);

        Assert.Equal(outerXml, clonedElement.OuterXml);

        clonedElement = unknownElement.CloneNode(false);

        Assert.Equal("txBody", clonedElement.LocalName);
        Assert.Equal("a", clonedElement.Prefix);
        Assert.Equal("http://schemas.openxmlformats.org/drawingml/2006/main", clonedElement.NamespaceUri);
        Assert.Null(clonedElement.FirstChild);
    }

    private OpenXmlPartContainer GetContainer()
    {
        var features = new FeatureCollection();
        var namespaceResolver = Substitute.For<IOpenXmlNamespaceResolver>();
        features.Set(namespaceResolver);

        var container = Substitute.For<OpenXmlPartContainer>();
        container.Features.Returns(features);

        return container;
    }
}
