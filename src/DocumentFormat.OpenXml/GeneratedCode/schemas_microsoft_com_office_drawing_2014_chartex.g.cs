// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;

namespace DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing
{
/// <summary>
/// <para>Defines the Extension2 Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:ext.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(80, "ext")]
public partial class Extension2 : OpenXmlCompositeElement
{
    
        /// <summary>
    /// <para> uri, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: uri </para>
    /// </summary>
[StringValidator(IsToken = true)]
    [SchemaAttr(0, "uri")]
    [Index(0)]
    public StringValue Uri { get; set; }

    /// <summary>
    /// Initializes a new instance of the Extension2 class.
    /// </summary>
    public Extension2():base(){}
        /// <summary>
    ///Initializes a new instance of the Extension2 class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Extension2(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the Extension2 class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Extension2(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the Extension2 class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Extension2(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new AnyParticle(1, 1)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Extension2>(deep);

}
/// <summary>
/// <para>Defines the ChartStringValue Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:pt.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(80, "pt")]
public partial class ChartStringValue : OpenXmlLeafTextElement
{
    
        /// <summary>
    /// <para> idx, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: idx </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "idx")]
    [Index(0)]
    public UInt32Value Index { get; set; }

    /// <summary>
    /// Initializes a new instance of the ChartStringValue class.
    /// </summary>
    public ChartStringValue():base(){}
    
        /// <summary>
    /// Initializes a new instance of the ChartStringValue class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public ChartStringValue(string text):base(text)
    {
    }
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new StringValue(){ InnerText = text };
    }


    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ChartStringValue>(deep);

}
/// <summary>
/// <para>Defines the NumericValue Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:pt.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(80, "pt")]
public partial class NumericValue : OpenXmlLeafTextElement
{
    
        /// <summary>
    /// <para> idx, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: idx </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "idx")]
    [Index(0)]
    public UInt32Value Idx { get; set; }

    /// <summary>
    /// Initializes a new instance of the NumericValue class.
    /// </summary>
    public NumericValue():base(){}
    
        /// <summary>
    /// Initializes a new instance of the NumericValue class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public NumericValue(string text):base(text)
    {
    }
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new DoubleValue(){ InnerText = text };
    }


    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<NumericValue>(deep);

}
/// <summary>
/// <para>Defines the NumericDimension Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:numDim.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Formula &lt;cx:f></description></item>
///<item><description>NumericLevel &lt;cx:lvl></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Formula), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(NumericLevel), FileFormatVersions.Office2016)]

[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(80, "numDim")]
public partial class NumericDimension : OpenXmlCompositeElement
{
    
        /// <summary>
    /// <para> Dimension data type, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: type </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "type")]
    [Index(0)]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericDimensionType> Type { get; set; }

    /// <summary>
    /// Initializes a new instance of the NumericDimension class.
    /// </summary>
    public NumericDimension():base(){}
        /// <summary>
    ///Initializes a new instance of the NumericDimension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NumericDimension(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the NumericDimension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NumericDimension(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the NumericDimension class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public NumericDimension(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Choice, 1, 1)
{
    new CompositeParticle(ParticleType.Sequence, 1, 1)
    {
        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Formula), 1, 1, version: FileFormatVersions.Office2016),
        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericLevel), 0, 0, version: FileFormatVersions.Office2016)
    }
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<NumericDimension>(deep);

}
/// <summary>
/// <para>Defines the StringDimension Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:strDim.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Formula &lt;cx:f></description></item>
///<item><description>StringLevel &lt;cx:lvl></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Formula), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(StringLevel), FileFormatVersions.Office2016)]

[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(80, "strDim")]
public partial class StringDimension : OpenXmlCompositeElement
{
    
        /// <summary>
    /// <para> Dimension data type, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: type </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "type")]
    [Index(0)]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringDimensionType> Type { get; set; }

    /// <summary>
    /// Initializes a new instance of the StringDimension class.
    /// </summary>
    public StringDimension():base(){}
        /// <summary>
    ///Initializes a new instance of the StringDimension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public StringDimension(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the StringDimension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public StringDimension(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the StringDimension class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public StringDimension(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Choice, 1, 1)
{
    new CompositeParticle(ParticleType.Sequence, 1, 1)
    {
        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Formula), 1, 1, version: FileFormatVersions.Office2016),
        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringLevel), 0, 0, version: FileFormatVersions.Office2016)
    }
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<StringDimension>(deep);

}
/// <summary>
/// <para>Defines the ExtensionList Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:extLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Extension2 &lt;cx:ext></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Extension2), FileFormatVersions.Office2016)]

[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(80, "extLst")]
public partial class ExtensionList : OpenXmlCompositeElement
{
    
    
    /// <summary>
    /// Initializes a new instance of the ExtensionList class.
    /// </summary>
    public ExtensionList():base(){}
        /// <summary>
    ///Initializes a new instance of the ExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ExtensionList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the ExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ExtensionList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the ExtensionList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ExtensionList(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Extension2), 0, 0, version: FileFormatVersions.Office2016)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ExtensionList>(deep);

}
/// <summary>
/// <para>Defines the ExternalData Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:externalData.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(80, "externalData")]
public partial class ExternalData : OpenXmlLeafElement
{
    
        /// <summary>
    /// <para> id, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: r:id </para>
    /// </summary>
///<remark> xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
///</remark>
[RequiredValidator]
    [SchemaAttr(19, "id")]
    [Index(0)]
    public StringValue Id { get; set; }
    /// <summary>
    /// <para> autoUpdate, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: autoUpdate </para>
    /// </summary>
    [SchemaAttr(0, "autoUpdate")]
    [Index(1)]
    public BooleanValue AutoUpdate { get; set; }

    /// <summary>
    /// Initializes a new instance of the ExternalData class.
    /// </summary>
    public ExternalData():base(){}
    
    

    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ExternalData>(deep);

}
/// <summary>
/// <para>Defines the Data Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:data.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>NumericDimension &lt;cx:numDim></description></item>
///<item><description>StringDimension &lt;cx:strDim></description></item>
///<item><description>ExtensionList &lt;cx:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(NumericDimension), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(StringDimension), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(ExtensionList), FileFormatVersions.Office2016)]

[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(80, "data")]
public partial class Data : OpenXmlCompositeElement
{
    
        /// <summary>
    /// <para> id, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "id")]
    [Index(0)]
    public UInt32Value Id { get; set; }

    /// <summary>
    /// Initializes a new instance of the Data class.
    /// </summary>
    public Data():base(){}
        /// <summary>
    ///Initializes a new instance of the Data class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Data(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the Data class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Data(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the Data class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Data(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new CompositeParticle(ParticleType.Choice, 1, 0)
    {
        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericDimension), 1, 1, version: FileFormatVersions.Office2016),
        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringDimension), 1, 1, version: FileFormatVersions.Office2016)
    },
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList), 0, 1, version: FileFormatVersions.Office2016)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Data>(deep);

}
/// <summary>
/// <para>Defines the TextData Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:txData.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Formula &lt;cx:f></description></item>
///<item><description>VXsdstring &lt;cx:v></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Formula), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(VXsdstring), FileFormatVersions.Office2016)]

[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(80, "txData")]
public partial class TextData : OpenXmlCompositeElement
{
    
    
    /// <summary>
    /// Initializes a new instance of the TextData class.
    /// </summary>
    public TextData():base(){}
        /// <summary>
    ///Initializes a new instance of the TextData class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TextData(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the TextData class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TextData(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the TextData class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public TextData(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Choice, 1, 1)
{
    new CompositeParticle(ParticleType.Sequence, 1, 1)
    {
        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Formula), 1, 1, version: FileFormatVersions.Office2016),
        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.VXsdstring), 0, 1, version: FileFormatVersions.Office2016)
    }
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<TextData>(deep);

}
/// <summary>
/// <para>Defines the RichTextBody Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:rich.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.BodyProperties &lt;a:bodyPr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.ListStyle &lt;a:lstStyle></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Paragraph &lt;a:p></description></item>
/// </list>
/// </remarks>

[SchemaAttr(80, "rich")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class RichTextBody : TextBodyType
{
    /// <summary>
    /// Initializes a new instance of the RichTextBody class.
    /// </summary>
    public RichTextBody():base(){}
        /// <summary>
    ///Initializes a new instance of the RichTextBody class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RichTextBody(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the RichTextBody class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RichTextBody(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the RichTextBody class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public RichTextBody(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RichTextBody>(deep);

private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.BodyProperties), 1, 1),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ListStyle), 0, 1),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Paragraph), 1, 0)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
}
/// <summary>
/// <para>Defines the TxPrTextBody Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:txPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.BodyProperties &lt;a:bodyPr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.ListStyle &lt;a:lstStyle></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Paragraph &lt;a:p></description></item>
/// </list>
/// </remarks>

[SchemaAttr(80, "txPr")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class TxPrTextBody : TextBodyType
{
    /// <summary>
    /// Initializes a new instance of the TxPrTextBody class.
    /// </summary>
    public TxPrTextBody():base(){}
        /// <summary>
    ///Initializes a new instance of the TxPrTextBody class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TxPrTextBody(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the TxPrTextBody class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TxPrTextBody(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the TxPrTextBody class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public TxPrTextBody(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<TxPrTextBody>(deep);

private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.BodyProperties), 1, 1),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ListStyle), 0, 1),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Paragraph), 1, 0)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
}
/// <summary>
/// Defines the TextBodyType class.
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.BodyProperties &lt;a:bodyPr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.ListStyle &lt;a:lstStyle></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Paragraph &lt;a:p></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.BodyProperties))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.ListStyle))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Paragraph))]

public abstract partial class TextBodyType : OpenXmlCompositeElement
{
    
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
        /// <summary>
    /// <para> Body Properties.</para>
    /// <para> Represents the following element tag in the schema: a:bodyPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
	[Index(0)]
    public DocumentFormat.OpenXml.Drawing.BodyProperties BodyProperties
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.BodyProperties>(0);
        set => SetElement(0, value);
	}
    /// <summary>
    /// <para> Text List Styles.</para>
    /// <para> Represents the following element tag in the schema: a:lstStyle </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
	[Index(1)]
    public DocumentFormat.OpenXml.Drawing.ListStyle ListStyle
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.ListStyle>(1);
        set => SetElement(1, value);
	}


    /// <summary>
    /// Initializes a new instance of the TextBodyType class.
    /// </summary>
    protected TextBodyType(){}
        /// <summary>
    ///Initializes a new instance of the TextBodyType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected TextBodyType(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the TextBodyType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected TextBodyType(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the TextBodyType class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    protected TextBodyType(string outerXml)
        : base(outerXml)
    {
    }

    
}
/// <summary>
/// <para>Defines the Text Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:tx.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>TextData &lt;cx:txData></description></item>
///<item><description>RichTextBody &lt;cx:rich></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(TextData), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(RichTextBody), FileFormatVersions.Office2016)]

[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(80, "tx")]
public partial class Text : OpenXmlCompositeElement
{
    
    
    /// <summary>
    /// Initializes a new instance of the Text class.
    /// </summary>
    public Text():base(){}
        /// <summary>
    ///Initializes a new instance of the Text class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Text(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the Text class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Text(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the Text class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Text(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new CompositeParticle(ParticleType.Choice, 1, 1)
    {
        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TextData), 1, 1, version: FileFormatVersions.Office2016),
        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.RichTextBody), 1, 1, version: FileFormatVersions.Office2016)
    }
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneChoice;
        /// <summary>
    /// <para> TextData.</para>
    /// <para> Represents the following element tag in the schema: cx:txData </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
	[Index(0)]
    public TextData TextData
	{
        get => GetElement<TextData>(0);
        set => SetElement(0, value);
	}
    /// <summary>
    /// <para> RichTextBody.</para>
    /// <para> Represents the following element tag in the schema: cx:rich </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
	[Index(1)]
    public RichTextBody RichTextBody
	{
        get => GetElement<RichTextBody>(1);
        set => SetElement(1, value);
	}


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Text>(deep);

}
/// <summary>
/// <para>Defines the ShapeProperties Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:spPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Transform2D &lt;a:xfrm></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.CustomGeometry &lt;a:custGeom></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.PresetGeometry &lt;a:prstGeom></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.NoFill &lt;a:noFill></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.SolidFill &lt;a:solidFill></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.GradientFill &lt;a:gradFill></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.BlipFill &lt;a:blipFill></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.PatternFill &lt;a:pattFill></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.GroupFill &lt;a:grpFill></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Outline &lt;a:ln></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.EffectList &lt;a:effectLst></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.EffectDag &lt;a:effectDag></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Scene3DType &lt;a:scene3d></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Shape3DType &lt;a:sp3d></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.ShapePropertiesExtensionList &lt;a:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Transform2D))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.CustomGeometry))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.PresetGeometry))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.NoFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.SolidFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.GradientFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.BlipFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.PatternFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.GroupFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Outline))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.EffectList))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.EffectDag))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Scene3DType))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Shape3DType))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.ShapePropertiesExtensionList))]

[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(80, "spPr")]
public partial class ShapeProperties : OpenXmlCompositeElement
{
    
        /// <summary>
    /// <para> Black and White Mode.</para>
    /// <para>Represents the following attribute in the schema: bwMode </para>
    /// </summary>
[StringValidator(IsToken = true)]
    [SchemaAttr(0, "bwMode")]
    [Index(0)]
    public EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues> BlackWhiteMode { get; set; }

    /// <summary>
    /// Initializes a new instance of the ShapeProperties class.
    /// </summary>
    public ShapeProperties():base(){}
        /// <summary>
    ///Initializes a new instance of the ShapeProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ShapeProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the ShapeProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ShapeProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the ShapeProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ShapeProperties(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Transform2D), 0, 1),
    new CompositeParticle(ParticleType.Group, 0, 1)
    {
        new CompositeParticle(ParticleType.Choice, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.CustomGeometry), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PresetGeometry), 1, 1)
        }
    },
    new CompositeParticle(ParticleType.Group, 0, 1)
    {
        new CompositeParticle(ParticleType.Choice, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.NoFill), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SolidFill), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.GradientFill), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.BlipFill), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PatternFill), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.GroupFill), 1, 1)
        }
    },
    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Outline), 0, 1),
    new CompositeParticle(ParticleType.Group, 0, 1)
    {
        new CompositeParticle(ParticleType.Choice, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.EffectList), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.EffectDag), 1, 1)
        }
    },
    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Scene3DType), 0, 1),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Shape3DType), 0, 1),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ShapePropertiesExtensionList), 0, 1)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
        /// <summary>
    /// <para> 2D Transform for Individual Objects.</para>
    /// <para> Represents the following element tag in the schema: a:xfrm </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
	[Index(0)]
    public DocumentFormat.OpenXml.Drawing.Transform2D Transform2D
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Transform2D>(0);
        set => SetElement(0, value);
	}


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShapeProperties>(deep);

}
/// <summary>
/// <para>Defines the AxisUnitsLabel Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:unitsLabel.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Text &lt;cx:tx></description></item>
///<item><description>ShapeProperties &lt;cx:spPr></description></item>
///<item><description>TxPrTextBody &lt;cx:txPr></description></item>
///<item><description>ExtensionList &lt;cx:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Text), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(ShapeProperties), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(TxPrTextBody), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(ExtensionList), FileFormatVersions.Office2016)]

[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(80, "unitsLabel")]
public partial class AxisUnitsLabel : OpenXmlCompositeElement
{
    
    
    /// <summary>
    /// Initializes a new instance of the AxisUnitsLabel class.
    /// </summary>
    public AxisUnitsLabel():base(){}
        /// <summary>
    ///Initializes a new instance of the AxisUnitsLabel class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public AxisUnitsLabel(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the AxisUnitsLabel class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public AxisUnitsLabel(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the AxisUnitsLabel class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public AxisUnitsLabel(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Text), 0, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties), 0, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody), 0, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList), 0, 1, version: FileFormatVersions.Office2016)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
        /// <summary>
    /// <para> Text.</para>
    /// <para> Represents the following element tag in the schema: cx:tx </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
	[Index(0)]
    public Text Text
	{
        get => GetElement<Text>(0);
        set => SetElement(0, value);
	}
    /// <summary>
    /// <para> ShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: cx:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
	[Index(1)]
    public ShapeProperties ShapeProperties
	{
        get => GetElement<ShapeProperties>(1);
        set => SetElement(1, value);
	}
    /// <summary>
    /// <para> TxPrTextBody.</para>
    /// <para> Represents the following element tag in the schema: cx:txPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
	[Index(2)]
    public TxPrTextBody TxPrTextBody
	{
        get => GetElement<TxPrTextBody>(2);
        set => SetElement(2, value);
	}
    /// <summary>
    /// <para> ExtensionList.</para>
    /// <para> Represents the following element tag in the schema: cx:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
	[Index(3)]
    public ExtensionList ExtensionList
	{
        get => GetElement<ExtensionList>(3);
        set => SetElement(3, value);
	}


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<AxisUnitsLabel>(deep);

}
/// <summary>
/// <para>Defines the CategoryAxisScaling Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:catScaling.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(80, "catScaling")]
public partial class CategoryAxisScaling : OpenXmlLeafElement
{
    
        /// <summary>
    /// <para> gapWidth, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: gapWidth </para>
    /// </summary>
[NumberValidator(MinInclusive = 0, SimpleType = typeof(DoubleValue), UnionId = 0)]
[StringValidator(UnionId = 0)]
    [SchemaAttr(0, "gapWidth")]
    [Index(0)]
    public StringValue GapWidth { get; set; }

    /// <summary>
    /// Initializes a new instance of the CategoryAxisScaling class.
    /// </summary>
    public CategoryAxisScaling():base(){}
    
    

    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<CategoryAxisScaling>(deep);

}
/// <summary>
/// <para>Defines the ValueAxisScaling Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:valScaling.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(80, "valScaling")]
public partial class ValueAxisScaling : OpenXmlLeafElement
{
    
        /// <summary>
    /// <para> max, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: max </para>
    /// </summary>
[NumberValidator(SimpleType = typeof(DoubleValue), UnionId = 0)]
[StringValidator(UnionId = 0)]
    [SchemaAttr(0, "max")]
    [Index(0)]
    public StringValue Max { get; set; }
    /// <summary>
    /// <para> min, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: min </para>
    /// </summary>
[NumberValidator(SimpleType = typeof(DoubleValue), UnionId = 0)]
[StringValidator(UnionId = 0)]
    [SchemaAttr(0, "min")]
    [Index(1)]
    public StringValue Min { get; set; }
    /// <summary>
    /// <para> majorUnit, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: majorUnit </para>
    /// </summary>
[NumberValidator(MinExclusive = 0, SimpleType = typeof(DoubleValue), UnionId = 0)]
[StringValidator(UnionId = 0)]
    [SchemaAttr(0, "majorUnit")]
    [Index(2)]
    public StringValue MajorUnit { get; set; }
    /// <summary>
    /// <para> minorUnit, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: minorUnit </para>
    /// </summary>
[NumberValidator(MinExclusive = 0, SimpleType = typeof(DoubleValue), UnionId = 0)]
[StringValidator(UnionId = 0)]
    [SchemaAttr(0, "minorUnit")]
    [Index(3)]
    public StringValue MinorUnit { get; set; }

    /// <summary>
    /// Initializes a new instance of the ValueAxisScaling class.
    /// </summary>
    public ValueAxisScaling():base(){}
    
    

    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ValueAxisScaling>(deep);

}
/// <summary>
/// <para>Defines the AxisTitle Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:title.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Text &lt;cx:tx></description></item>
///<item><description>ShapeProperties &lt;cx:spPr></description></item>
///<item><description>TxPrTextBody &lt;cx:txPr></description></item>
///<item><description>ExtensionList &lt;cx:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Text), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(ShapeProperties), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(TxPrTextBody), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(ExtensionList), FileFormatVersions.Office2016)]

[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(80, "title")]
public partial class AxisTitle : OpenXmlCompositeElement
{
    
    
    /// <summary>
    /// Initializes a new instance of the AxisTitle class.
    /// </summary>
    public AxisTitle():base(){}
        /// <summary>
    ///Initializes a new instance of the AxisTitle class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public AxisTitle(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the AxisTitle class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public AxisTitle(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the AxisTitle class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public AxisTitle(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Text), 0, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties), 0, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody), 0, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList), 0, 1, version: FileFormatVersions.Office2016)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
        /// <summary>
    /// <para> Text.</para>
    /// <para> Represents the following element tag in the schema: cx:tx </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
	[Index(0)]
    public Text Text
	{
        get => GetElement<Text>(0);
        set => SetElement(0, value);
	}
    /// <summary>
    /// <para> ShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: cx:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
	[Index(1)]
    public ShapeProperties ShapeProperties
	{
        get => GetElement<ShapeProperties>(1);
        set => SetElement(1, value);
	}
    /// <summary>
    /// <para> TxPrTextBody.</para>
    /// <para> Represents the following element tag in the schema: cx:txPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
	[Index(2)]
    public TxPrTextBody TxPrTextBody
	{
        get => GetElement<TxPrTextBody>(2);
        set => SetElement(2, value);
	}
    /// <summary>
    /// <para> ExtensionList.</para>
    /// <para> Represents the following element tag in the schema: cx:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
	[Index(3)]
    public ExtensionList ExtensionList
	{
        get => GetElement<ExtensionList>(3);
        set => SetElement(3, value);
	}


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<AxisTitle>(deep);

}
/// <summary>
/// <para>Defines the AxisUnits Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:units.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>AxisUnitsLabel &lt;cx:unitsLabel></description></item>
///<item><description>ExtensionList &lt;cx:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(AxisUnitsLabel), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(ExtensionList), FileFormatVersions.Office2016)]

[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(80, "units")]
public partial class AxisUnits : OpenXmlCompositeElement
{
    
        /// <summary>
    /// <para> unit, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: unit </para>
    /// </summary>
    [SchemaAttr(0, "unit")]
    [Index(0)]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnit> Unit { get; set; }

    /// <summary>
    /// Initializes a new instance of the AxisUnits class.
    /// </summary>
    public AxisUnits():base(){}
        /// <summary>
    ///Initializes a new instance of the AxisUnits class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public AxisUnits(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the AxisUnits class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public AxisUnits(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the AxisUnits class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public AxisUnits(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnitsLabel), 0, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList), 0, 1, version: FileFormatVersions.Office2016)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
        /// <summary>
    /// <para> AxisUnitsLabel.</para>
    /// <para> Represents the following element tag in the schema: cx:unitsLabel </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
	[Index(0)]
    public AxisUnitsLabel AxisUnitsLabel
	{
        get => GetElement<AxisUnitsLabel>(0);
        set => SetElement(0, value);
	}
    /// <summary>
    /// <para> ExtensionList.</para>
    /// <para> Represents the following element tag in the schema: cx:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
	[Index(1)]
    public ExtensionList ExtensionList
	{
        get => GetElement<ExtensionList>(1);
        set => SetElement(1, value);
	}


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<AxisUnits>(deep);

}
/// <summary>
/// <para>Defines the MajorGridlinesGridlines Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:majorGridlines.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ShapeProperties &lt;cx:spPr></description></item>
///<item><description>ExtensionList &lt;cx:extLst></description></item>
/// </list>
/// </remarks>

[SchemaAttr(80, "majorGridlines")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class MajorGridlinesGridlines : OpenXmlGridlinesElement
{
    /// <summary>
    /// Initializes a new instance of the MajorGridlinesGridlines class.
    /// </summary>
    public MajorGridlinesGridlines():base(){}
        /// <summary>
    ///Initializes a new instance of the MajorGridlinesGridlines class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public MajorGridlinesGridlines(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the MajorGridlinesGridlines class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public MajorGridlinesGridlines(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the MajorGridlinesGridlines class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public MajorGridlinesGridlines(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<MajorGridlinesGridlines>(deep);

private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties), 0, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList), 0, 1, version: FileFormatVersions.Office2016)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
}
/// <summary>
/// <para>Defines the MinorGridlinesGridlines Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:minorGridlines.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ShapeProperties &lt;cx:spPr></description></item>
///<item><description>ExtensionList &lt;cx:extLst></description></item>
/// </list>
/// </remarks>

[SchemaAttr(80, "minorGridlines")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class MinorGridlinesGridlines : OpenXmlGridlinesElement
{
    /// <summary>
    /// Initializes a new instance of the MinorGridlinesGridlines class.
    /// </summary>
    public MinorGridlinesGridlines():base(){}
        /// <summary>
    ///Initializes a new instance of the MinorGridlinesGridlines class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public MinorGridlinesGridlines(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the MinorGridlinesGridlines class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public MinorGridlinesGridlines(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the MinorGridlinesGridlines class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public MinorGridlinesGridlines(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<MinorGridlinesGridlines>(deep);

private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties), 0, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList), 0, 1, version: FileFormatVersions.Office2016)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
}
/// <summary>
/// Defines the OpenXmlGridlinesElement class.
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ShapeProperties &lt;cx:spPr></description></item>
///<item><description>ExtensionList &lt;cx:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ShapeProperties), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(ExtensionList), FileFormatVersions.Office2016)]

public abstract partial class OpenXmlGridlinesElement : OpenXmlCompositeElement
{
    
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
        /// <summary>
    /// <para> ShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: cx:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
	[Index(0)]
    public ShapeProperties ShapeProperties
	{
        get => GetElement<ShapeProperties>(0);
        set => SetElement(0, value);
	}
    /// <summary>
    /// <para> ExtensionList.</para>
    /// <para> Represents the following element tag in the schema: cx:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
	[Index(1)]
    public ExtensionList ExtensionList
	{
        get => GetElement<ExtensionList>(1);
        set => SetElement(1, value);
	}


    /// <summary>
    /// Initializes a new instance of the OpenXmlGridlinesElement class.
    /// </summary>
    protected OpenXmlGridlinesElement(){}
        /// <summary>
    ///Initializes a new instance of the OpenXmlGridlinesElement class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected OpenXmlGridlinesElement(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the OpenXmlGridlinesElement class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected OpenXmlGridlinesElement(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the OpenXmlGridlinesElement class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    protected OpenXmlGridlinesElement(string outerXml)
        : base(outerXml)
    {
    }

    
}
/// <summary>
/// <para>Defines the MajorTickMarksTickMarks Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:majorTickMarks.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ExtensionList &lt;cx:extLst></description></item>
/// </list>
/// </remarks>

[SchemaAttr(80, "majorTickMarks")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class MajorTickMarksTickMarks : OpenXmlTickMarksElement
{
    /// <summary>
    /// Initializes a new instance of the MajorTickMarksTickMarks class.
    /// </summary>
    public MajorTickMarksTickMarks():base(){}
        /// <summary>
    ///Initializes a new instance of the MajorTickMarksTickMarks class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public MajorTickMarksTickMarks(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the MajorTickMarksTickMarks class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public MajorTickMarksTickMarks(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the MajorTickMarksTickMarks class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public MajorTickMarksTickMarks(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<MajorTickMarksTickMarks>(deep);

private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList), 0, 1, version: FileFormatVersions.Office2016)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
}
/// <summary>
/// <para>Defines the MinorTickMarksTickMarks Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:minorTickMarks.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ExtensionList &lt;cx:extLst></description></item>
/// </list>
/// </remarks>

[SchemaAttr(80, "minorTickMarks")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class MinorTickMarksTickMarks : OpenXmlTickMarksElement
{
    /// <summary>
    /// Initializes a new instance of the MinorTickMarksTickMarks class.
    /// </summary>
    public MinorTickMarksTickMarks():base(){}
        /// <summary>
    ///Initializes a new instance of the MinorTickMarksTickMarks class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public MinorTickMarksTickMarks(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the MinorTickMarksTickMarks class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public MinorTickMarksTickMarks(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the MinorTickMarksTickMarks class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public MinorTickMarksTickMarks(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<MinorTickMarksTickMarks>(deep);

private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList), 0, 1, version: FileFormatVersions.Office2016)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
}
/// <summary>
/// Defines the OpenXmlTickMarksElement class.
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ExtensionList &lt;cx:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ExtensionList), FileFormatVersions.Office2016)]

public abstract partial class OpenXmlTickMarksElement : OpenXmlCompositeElement
{
    
        /// <summary>
    /// <para> type, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: type </para>
    /// </summary>
    [SchemaAttr(0, "type")]
    [Index(0)]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TickMarksType> Type { get; set; }

    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
        /// <summary>
    /// <para> ExtensionList.</para>
    /// <para> Represents the following element tag in the schema: cx:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
	[Index(0)]
    public ExtensionList ExtensionList
	{
        get => GetElement<ExtensionList>(0);
        set => SetElement(0, value);
	}


    /// <summary>
    /// Initializes a new instance of the OpenXmlTickMarksElement class.
    /// </summary>
    protected OpenXmlTickMarksElement(){}
        /// <summary>
    ///Initializes a new instance of the OpenXmlTickMarksElement class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected OpenXmlTickMarksElement(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the OpenXmlTickMarksElement class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected OpenXmlTickMarksElement(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the OpenXmlTickMarksElement class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    protected OpenXmlTickMarksElement(string outerXml)
        : base(outerXml)
    {
    }

    
}
/// <summary>
/// <para>Defines the TickLabels Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:tickLabels.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ExtensionList &lt;cx:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ExtensionList), FileFormatVersions.Office2016)]

[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(80, "tickLabels")]
public partial class TickLabels : OpenXmlCompositeElement
{
    
    
    /// <summary>
    /// Initializes a new instance of the TickLabels class.
    /// </summary>
    public TickLabels():base(){}
        /// <summary>
    ///Initializes a new instance of the TickLabels class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TickLabels(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the TickLabels class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TickLabels(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the TickLabels class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public TickLabels(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList), 0, 1, version: FileFormatVersions.Office2016)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
        /// <summary>
    /// <para> ExtensionList.</para>
    /// <para> Represents the following element tag in the schema: cx:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
	[Index(0)]
    public ExtensionList ExtensionList
	{
        get => GetElement<ExtensionList>(0);
        set => SetElement(0, value);
	}


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<TickLabels>(deep);

}
/// <summary>
/// <para>Defines the NumberFormat Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:numFmt.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(80, "numFmt")]
public partial class NumberFormat : OpenXmlLeafElement
{
    
        /// <summary>
    /// <para> formatCode, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: formatCode </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "formatCode")]
    [Index(0)]
    public StringValue FormatCode { get; set; }
    /// <summary>
    /// <para> sourceLinked, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: sourceLinked </para>
    /// </summary>
    [SchemaAttr(0, "sourceLinked")]
    [Index(1)]
    public BooleanValue SourceLinked { get; set; }

    /// <summary>
    /// Initializes a new instance of the NumberFormat class.
    /// </summary>
    public NumberFormat():base(){}
    
    

    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<NumberFormat>(deep);

}
/// <summary>
/// <para>Defines the Xsddouble Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:binSize.</para>
/// </summary>

[NumberValidator(SimpleType = typeof(DoubleValue))]

[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(80, "binSize")]
public partial class Xsddouble : OpenXmlLeafTextElement
{
    
    
    /// <summary>
    /// Initializes a new instance of the Xsddouble class.
    /// </summary>
    public Xsddouble():base(){}
    
        /// <summary>
    /// Initializes a new instance of the Xsddouble class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public Xsddouble(string text):base(text)
    {
    }
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new DoubleValue(){ InnerText = text };
    }


    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Xsddouble>(deep);

}
/// <summary>
/// <para>Defines the BinCountXsdunsignedInt Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:binCount.</para>
/// </summary>

[NumberValidator(SimpleType = typeof(UInt32Value))]
[SchemaAttr(80, "binCount")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class BinCountXsdunsignedInt : OpenXmlLeafTextElement
{
    /// <summary>
    /// Initializes a new instance of the BinCountXsdunsignedInt class.
    /// </summary>
    public BinCountXsdunsignedInt():base(){}
    
        /// <summary>
    /// Initializes a new instance of the BinCountXsdunsignedInt class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public BinCountXsdunsignedInt(string text):base(text)
    {
    }
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new UInt32Value(){ InnerText = text };
    }

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<BinCountXsdunsignedInt>(deep);


}
/// <summary>
/// <para>Defines the IdxXsdunsignedInt Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:idx.</para>
/// </summary>

[NumberValidator(SimpleType = typeof(UInt32Value))]
[SchemaAttr(80, "idx")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class IdxXsdunsignedInt : OpenXmlLeafTextElement
{
    /// <summary>
    /// Initializes a new instance of the IdxXsdunsignedInt class.
    /// </summary>
    public IdxXsdunsignedInt():base(){}
    
        /// <summary>
    /// Initializes a new instance of the IdxXsdunsignedInt class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public IdxXsdunsignedInt(string text):base(text)
    {
    }
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new UInt32Value(){ InnerText = text };
    }

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<IdxXsdunsignedInt>(deep);


}
/// <summary>
/// <para>Defines the ParentLabelLayout Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:parentLabelLayout.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(80, "parentLabelLayout")]
public partial class ParentLabelLayout : OpenXmlLeafElement
{
    
        /// <summary>
    /// <para> val, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "val")]
    [Index(0)]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ParentLabelLayoutVal> ParentLabelLayoutVal { get; set; }

    /// <summary>
    /// Initializes a new instance of the ParentLabelLayout class.
    /// </summary>
    public ParentLabelLayout():base(){}
    
    

    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ParentLabelLayout>(deep);

}
/// <summary>
/// <para>Defines the SeriesElementVisibilities Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:visibility.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(80, "visibility")]
public partial class SeriesElementVisibilities : OpenXmlLeafElement
{
    
        /// <summary>
    /// <para> connectorLines, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: connectorLines </para>
    /// </summary>
    [SchemaAttr(0, "connectorLines")]
    [Index(0)]
    public BooleanValue ConnectorLines { get; set; }
    /// <summary>
    /// <para> meanLine, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: meanLine </para>
    /// </summary>
    [SchemaAttr(0, "meanLine")]
    [Index(1)]
    public BooleanValue MeanLine { get; set; }
    /// <summary>
    /// <para> meanMarker, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: meanMarker </para>
    /// </summary>
    [SchemaAttr(0, "meanMarker")]
    [Index(2)]
    public BooleanValue MeanMarker { get; set; }
    /// <summary>
    /// <para> nonoutliers, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: nonoutliers </para>
    /// </summary>
    [SchemaAttr(0, "nonoutliers")]
    [Index(3)]
    public BooleanValue Nonoutliers { get; set; }
    /// <summary>
    /// <para> outliers, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: outliers </para>
    /// </summary>
    [SchemaAttr(0, "outliers")]
    [Index(4)]
    public BooleanValue Outliers { get; set; }

    /// <summary>
    /// Initializes a new instance of the SeriesElementVisibilities class.
    /// </summary>
    public SeriesElementVisibilities():base(){}
    
    

    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SeriesElementVisibilities>(deep);

}
/// <summary>
/// <para>Defines the Aggregation Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:aggregation.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(80, "aggregation")]
public partial class Aggregation : OpenXmlLeafElement
{
    
    
    /// <summary>
    /// Initializes a new instance of the Aggregation class.
    /// </summary>
    public Aggregation():base(){}
    
    

    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Aggregation>(deep);

}
/// <summary>
/// <para>Defines the Binning Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:binning.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Xsddouble &lt;cx:binSize></description></item>
///<item><description>BinCountXsdunsignedInt &lt;cx:binCount></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Xsddouble), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(BinCountXsdunsignedInt), FileFormatVersions.Office2016)]

[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(80, "binning")]
public partial class Binning : OpenXmlCompositeElement
{
    
        /// <summary>
    /// <para> intervalClosed, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: intervalClosed </para>
    /// </summary>
    [SchemaAttr(0, "intervalClosed")]
    [Index(0)]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.IntervalClosedSide> IntervalClosed { get; set; }
    /// <summary>
    /// <para> underflow, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: underflow </para>
    /// </summary>
[NumberValidator(SimpleType = typeof(DoubleValue), UnionId = 0)]
[StringValidator(UnionId = 0)]
    [SchemaAttr(0, "underflow")]
    [Index(1)]
    public StringValue Underflow { get; set; }
    /// <summary>
    /// <para> overflow, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: overflow </para>
    /// </summary>
[NumberValidator(SimpleType = typeof(DoubleValue), UnionId = 0)]
[StringValidator(UnionId = 0)]
    [SchemaAttr(0, "overflow")]
    [Index(2)]
    public StringValue Overflow { get; set; }

    /// <summary>
    /// Initializes a new instance of the Binning class.
    /// </summary>
    public Binning():base(){}
        /// <summary>
    ///Initializes a new instance of the Binning class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Binning(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the Binning class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Binning(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the Binning class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Binning(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Choice, 0, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Xsddouble), 1, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.BinCountXsdunsignedInt), 1, 1, version: FileFormatVersions.Office2016)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneChoice;
        /// <summary>
    /// <para> Xsddouble.</para>
    /// <para> Represents the following element tag in the schema: cx:binSize </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
	[Index(0)]
    public Xsddouble Xsddouble
	{
        get => GetElement<Xsddouble>(0);
        set => SetElement(0, value);
	}
    /// <summary>
    /// <para> BinCountXsdunsignedInt.</para>
    /// <para> Represents the following element tag in the schema: cx:binCount </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
	[Index(1)]
    public BinCountXsdunsignedInt BinCountXsdunsignedInt
	{
        get => GetElement<BinCountXsdunsignedInt>(1);
        set => SetElement(1, value);
	}


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Binning>(deep);

}
/// <summary>
/// <para>Defines the Statistics Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:statistics.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(80, "statistics")]
public partial class Statistics : OpenXmlLeafElement
{
    
        /// <summary>
    /// <para> quartileMethod, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: quartileMethod </para>
    /// </summary>
    [SchemaAttr(0, "quartileMethod")]
    [Index(0)]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.QuartileMethod> QuartileMethod { get; set; }

    /// <summary>
    /// Initializes a new instance of the Statistics class.
    /// </summary>
    public Statistics():base(){}
    
    

    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Statistics>(deep);

}
/// <summary>
/// <para>Defines the Subtotals Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:subtotals.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>IdxXsdunsignedInt &lt;cx:idx></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(IdxXsdunsignedInt), FileFormatVersions.Office2016)]

[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(80, "subtotals")]
public partial class Subtotals : OpenXmlCompositeElement
{
    
    
    /// <summary>
    /// Initializes a new instance of the Subtotals class.
    /// </summary>
    public Subtotals():base(){}
        /// <summary>
    ///Initializes a new instance of the Subtotals class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Subtotals(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the Subtotals class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Subtotals(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the Subtotals class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Subtotals(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.IdxXsdunsignedInt), 0, 0, version: FileFormatVersions.Office2016)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Subtotals>(deep);

}
/// <summary>
/// <para>Defines the DataLabelVisibilities Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:visibility.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(80, "visibility")]
public partial class DataLabelVisibilities : OpenXmlLeafElement
{
    
        /// <summary>
    /// <para> seriesName, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: seriesName </para>
    /// </summary>
    [SchemaAttr(0, "seriesName")]
    [Index(0)]
    public BooleanValue SeriesName { get; set; }
    /// <summary>
    /// <para> categoryName, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: categoryName </para>
    /// </summary>
    [SchemaAttr(0, "categoryName")]
    [Index(1)]
    public BooleanValue CategoryName { get; set; }
    /// <summary>
    /// <para> value, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: value </para>
    /// </summary>
    [SchemaAttr(0, "value")]
    [Index(2)]
    public BooleanValue Value { get; set; }

    /// <summary>
    /// Initializes a new instance of the DataLabelVisibilities class.
    /// </summary>
    public DataLabelVisibilities():base(){}
    
    

    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataLabelVisibilities>(deep);

}
/// <summary>
/// <para>Defines the SeparatorXsdstring Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:separator.</para>
/// </summary>

[SchemaAttr(80, "separator")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class SeparatorXsdstring : OpenXmlLeafTextElement
{
    /// <summary>
    /// Initializes a new instance of the SeparatorXsdstring class.
    /// </summary>
    public SeparatorXsdstring():base(){}
    
        /// <summary>
    /// Initializes a new instance of the SeparatorXsdstring class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public SeparatorXsdstring(string text):base(text)
    {
    }
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new StringValue(){ InnerText = text };
    }

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SeparatorXsdstring>(deep);


}
/// <summary>
/// <para>Defines the OddHeaderXsdstring Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:oddHeader.</para>
/// </summary>

[SchemaAttr(80, "oddHeader")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class OddHeaderXsdstring : OpenXmlLeafTextElement
{
    /// <summary>
    /// Initializes a new instance of the OddHeaderXsdstring class.
    /// </summary>
    public OddHeaderXsdstring():base(){}
    
        /// <summary>
    /// Initializes a new instance of the OddHeaderXsdstring class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public OddHeaderXsdstring(string text):base(text)
    {
    }
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new StringValue(){ InnerText = text };
    }

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<OddHeaderXsdstring>(deep);


}
/// <summary>
/// <para>Defines the OddFooterXsdstring Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:oddFooter.</para>
/// </summary>

[SchemaAttr(80, "oddFooter")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class OddFooterXsdstring : OpenXmlLeafTextElement
{
    /// <summary>
    /// Initializes a new instance of the OddFooterXsdstring class.
    /// </summary>
    public OddFooterXsdstring():base(){}
    
        /// <summary>
    /// Initializes a new instance of the OddFooterXsdstring class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public OddFooterXsdstring(string text):base(text)
    {
    }
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new StringValue(){ InnerText = text };
    }

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<OddFooterXsdstring>(deep);


}
/// <summary>
/// <para>Defines the EvenHeaderXsdstring Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:evenHeader.</para>
/// </summary>

[SchemaAttr(80, "evenHeader")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class EvenHeaderXsdstring : OpenXmlLeafTextElement
{
    /// <summary>
    /// Initializes a new instance of the EvenHeaderXsdstring class.
    /// </summary>
    public EvenHeaderXsdstring():base(){}
    
        /// <summary>
    /// Initializes a new instance of the EvenHeaderXsdstring class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public EvenHeaderXsdstring(string text):base(text)
    {
    }
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new StringValue(){ InnerText = text };
    }

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<EvenHeaderXsdstring>(deep);


}
/// <summary>
/// <para>Defines the EvenFooterXsdstring Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:evenFooter.</para>
/// </summary>

[SchemaAttr(80, "evenFooter")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class EvenFooterXsdstring : OpenXmlLeafTextElement
{
    /// <summary>
    /// Initializes a new instance of the EvenFooterXsdstring class.
    /// </summary>
    public EvenFooterXsdstring():base(){}
    
        /// <summary>
    /// Initializes a new instance of the EvenFooterXsdstring class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public EvenFooterXsdstring(string text):base(text)
    {
    }
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new StringValue(){ InnerText = text };
    }

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<EvenFooterXsdstring>(deep);


}
/// <summary>
/// <para>Defines the FirstHeaderXsdstring Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:firstHeader.</para>
/// </summary>

[SchemaAttr(80, "firstHeader")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class FirstHeaderXsdstring : OpenXmlLeafTextElement
{
    /// <summary>
    /// Initializes a new instance of the FirstHeaderXsdstring class.
    /// </summary>
    public FirstHeaderXsdstring():base(){}
    
        /// <summary>
    /// Initializes a new instance of the FirstHeaderXsdstring class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public FirstHeaderXsdstring(string text):base(text)
    {
    }
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new StringValue(){ InnerText = text };
    }

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<FirstHeaderXsdstring>(deep);


}
/// <summary>
/// <para>Defines the FirstFooterXsdstring Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:firstFooter.</para>
/// </summary>

[SchemaAttr(80, "firstFooter")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class FirstFooterXsdstring : OpenXmlLeafTextElement
{
    /// <summary>
    /// Initializes a new instance of the FirstFooterXsdstring class.
    /// </summary>
    public FirstFooterXsdstring():base(){}
    
        /// <summary>
    /// Initializes a new instance of the FirstFooterXsdstring class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public FirstFooterXsdstring(string text):base(text)
    {
    }
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new StringValue(){ InnerText = text };
    }

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<FirstFooterXsdstring>(deep);


}
/// <summary>
/// <para>Cached text.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:v.</para>
/// </summary>

[SchemaAttr(80, "v")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class VXsdstring : OpenXmlLeafTextElement
{
    /// <summary>
    /// Initializes a new instance of the VXsdstring class.
    /// </summary>
    public VXsdstring():base(){}
    
        /// <summary>
    /// Initializes a new instance of the VXsdstring class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public VXsdstring(string text):base(text)
    {
    }
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new StringValue(){ InnerText = text };
    }

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<VXsdstring>(deep);


}
/// <summary>
/// <para>Defines the DataLabel Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:dataLabel.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>NumberFormat &lt;cx:numFmt></description></item>
///<item><description>ShapeProperties &lt;cx:spPr></description></item>
///<item><description>TxPrTextBody &lt;cx:txPr></description></item>
///<item><description>DataLabelVisibilities &lt;cx:visibility></description></item>
///<item><description>SeparatorXsdstring &lt;cx:separator></description></item>
///<item><description>ExtensionList &lt;cx:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(NumberFormat), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(ShapeProperties), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(TxPrTextBody), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(DataLabelVisibilities), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(SeparatorXsdstring), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(ExtensionList), FileFormatVersions.Office2016)]

[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(80, "dataLabel")]
public partial class DataLabel : OpenXmlCompositeElement
{
    
        /// <summary>
    /// <para> idx, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: idx </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "idx")]
    [Index(0)]
    public UInt32Value Idx { get; set; }
    /// <summary>
    /// <para> pos, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: pos </para>
    /// </summary>
    [SchemaAttr(0, "pos")]
    [Index(1)]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelPos> Pos { get; set; }

    /// <summary>
    /// Initializes a new instance of the DataLabel class.
    /// </summary>
    public DataLabel():base(){}
        /// <summary>
    ///Initializes a new instance of the DataLabel class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataLabel(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the DataLabel class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataLabel(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the DataLabel class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DataLabel(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumberFormat), 0, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties), 0, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody), 0, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelVisibilities), 0, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeparatorXsdstring), 0, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList), 0, 1, version: FileFormatVersions.Office2016)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
        /// <summary>
    /// <para> NumberFormat.</para>
    /// <para> Represents the following element tag in the schema: cx:numFmt </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
	[Index(0)]
    public NumberFormat NumberFormat
	{
        get => GetElement<NumberFormat>(0);
        set => SetElement(0, value);
	}
    /// <summary>
    /// <para> ShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: cx:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
	[Index(1)]
    public ShapeProperties ShapeProperties
	{
        get => GetElement<ShapeProperties>(1);
        set => SetElement(1, value);
	}
    /// <summary>
    /// <para> TxPrTextBody.</para>
    /// <para> Represents the following element tag in the schema: cx:txPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
	[Index(2)]
    public TxPrTextBody TxPrTextBody
	{
        get => GetElement<TxPrTextBody>(2);
        set => SetElement(2, value);
	}
    /// <summary>
    /// <para> DataLabelVisibilities.</para>
    /// <para> Represents the following element tag in the schema: cx:visibility </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
	[Index(3)]
    public DataLabelVisibilities DataLabelVisibilities
	{
        get => GetElement<DataLabelVisibilities>(3);
        set => SetElement(3, value);
	}
    /// <summary>
    /// <para> SeparatorXsdstring.</para>
    /// <para> Represents the following element tag in the schema: cx:separator </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
	[Index(4)]
    public SeparatorXsdstring SeparatorXsdstring
	{
        get => GetElement<SeparatorXsdstring>(4);
        set => SetElement(4, value);
	}
    /// <summary>
    /// <para> ExtensionList.</para>
    /// <para> Represents the following element tag in the schema: cx:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
	[Index(5)]
    public ExtensionList ExtensionList
	{
        get => GetElement<ExtensionList>(5);
        set => SetElement(5, value);
	}


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataLabel>(deep);

}
/// <summary>
/// <para>Defines the DataLabelHidden Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:dataLabelHidden.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(80, "dataLabelHidden")]
public partial class DataLabelHidden : OpenXmlLeafElement
{
    
        /// <summary>
    /// <para> idx, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: idx </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "idx")]
    [Index(0)]
    public UInt32Value Idx { get; set; }

    /// <summary>
    /// Initializes a new instance of the DataLabelHidden class.
    /// </summary>
    public DataLabelHidden():base(){}
    
    

    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataLabelHidden>(deep);

}
/// <summary>
/// <para>Defines the DataPoint Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:dataPt.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ShapeProperties &lt;cx:spPr></description></item>
///<item><description>ExtensionList &lt;cx:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ShapeProperties), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(ExtensionList), FileFormatVersions.Office2016)]

[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(80, "dataPt")]
public partial class DataPoint : OpenXmlCompositeElement
{
    
        /// <summary>
    /// <para> idx, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: idx </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "idx")]
    [Index(0)]
    public UInt32Value Idx { get; set; }

    /// <summary>
    /// Initializes a new instance of the DataPoint class.
    /// </summary>
    public DataPoint():base(){}
        /// <summary>
    ///Initializes a new instance of the DataPoint class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataPoint(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the DataPoint class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataPoint(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the DataPoint class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DataPoint(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties), 0, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList), 0, 1, version: FileFormatVersions.Office2016)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
        /// <summary>
    /// <para> ShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: cx:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
	[Index(0)]
    public ShapeProperties ShapeProperties
	{
        get => GetElement<ShapeProperties>(0);
        set => SetElement(0, value);
	}
    /// <summary>
    /// <para> ExtensionList.</para>
    /// <para> Represents the following element tag in the schema: cx:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
	[Index(1)]
    public ExtensionList ExtensionList
	{
        get => GetElement<ExtensionList>(1);
        set => SetElement(1, value);
	}


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataPoint>(deep);

}
/// <summary>
/// <para>Defines the DataLabels Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:dataLabels.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>NumberFormat &lt;cx:numFmt></description></item>
///<item><description>ShapeProperties &lt;cx:spPr></description></item>
///<item><description>TxPrTextBody &lt;cx:txPr></description></item>
///<item><description>DataLabelVisibilities &lt;cx:visibility></description></item>
///<item><description>SeparatorXsdstring &lt;cx:separator></description></item>
///<item><description>DataLabel &lt;cx:dataLabel></description></item>
///<item><description>DataLabelHidden &lt;cx:dataLabelHidden></description></item>
///<item><description>ExtensionList &lt;cx:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(NumberFormat), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(ShapeProperties), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(TxPrTextBody), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(DataLabelVisibilities), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(SeparatorXsdstring), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(DataLabel), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(DataLabelHidden), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(ExtensionList), FileFormatVersions.Office2016)]

[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(80, "dataLabels")]
public partial class DataLabels : OpenXmlCompositeElement
{
    
        /// <summary>
    /// <para> pos, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: pos </para>
    /// </summary>
    [SchemaAttr(0, "pos")]
    [Index(0)]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelPos> Pos { get; set; }

    /// <summary>
    /// Initializes a new instance of the DataLabels class.
    /// </summary>
    public DataLabels():base(){}
        /// <summary>
    ///Initializes a new instance of the DataLabels class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataLabels(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the DataLabels class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataLabels(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the DataLabels class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DataLabels(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumberFormat), 0, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties), 0, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody), 0, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelVisibilities), 0, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeparatorXsdstring), 0, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabel), 0, 0, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelHidden), 0, 0, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList), 0, 1, version: FileFormatVersions.Office2016)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
        /// <summary>
    /// <para> NumberFormat.</para>
    /// <para> Represents the following element tag in the schema: cx:numFmt </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
	[Index(0)]
    public NumberFormat NumberFormat
	{
        get => GetElement<NumberFormat>(0);
        set => SetElement(0, value);
	}
    /// <summary>
    /// <para> ShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: cx:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
	[Index(1)]
    public ShapeProperties ShapeProperties
	{
        get => GetElement<ShapeProperties>(1);
        set => SetElement(1, value);
	}
    /// <summary>
    /// <para> TxPrTextBody.</para>
    /// <para> Represents the following element tag in the schema: cx:txPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
	[Index(2)]
    public TxPrTextBody TxPrTextBody
	{
        get => GetElement<TxPrTextBody>(2);
        set => SetElement(2, value);
	}
    /// <summary>
    /// <para> DataLabelVisibilities.</para>
    /// <para> Represents the following element tag in the schema: cx:visibility </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
	[Index(3)]
    public DataLabelVisibilities DataLabelVisibilities
	{
        get => GetElement<DataLabelVisibilities>(3);
        set => SetElement(3, value);
	}
    /// <summary>
    /// <para> SeparatorXsdstring.</para>
    /// <para> Represents the following element tag in the schema: cx:separator </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
	[Index(4)]
    public SeparatorXsdstring SeparatorXsdstring
	{
        get => GetElement<SeparatorXsdstring>(4);
        set => SetElement(4, value);
	}


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataLabels>(deep);

}
/// <summary>
/// <para>Defines the DataId Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:dataId.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(80, "dataId")]
public partial class DataId : OpenXmlLeafElement
{
    
        /// <summary>
    /// <para> val, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "val")]
    [Index(0)]
    public UInt32Value Val { get; set; }

    /// <summary>
    /// Initializes a new instance of the DataId class.
    /// </summary>
    public DataId():base(){}
    
    

    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataId>(deep);

}
/// <summary>
/// <para>Defines the SeriesLayoutProperties Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:layoutPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ParentLabelLayout &lt;cx:parentLabelLayout></description></item>
///<item><description>SeriesElementVisibilities &lt;cx:visibility></description></item>
///<item><description>Aggregation &lt;cx:aggregation></description></item>
///<item><description>Binning &lt;cx:binning></description></item>
///<item><description>Statistics &lt;cx:statistics></description></item>
///<item><description>Subtotals &lt;cx:subtotals></description></item>
///<item><description>ExtensionList &lt;cx:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ParentLabelLayout), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(SeriesElementVisibilities), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(Aggregation), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(Binning), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(Statistics), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(Subtotals), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(ExtensionList), FileFormatVersions.Office2016)]

[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(80, "layoutPr")]
public partial class SeriesLayoutProperties : OpenXmlCompositeElement
{
    
    
    /// <summary>
    /// Initializes a new instance of the SeriesLayoutProperties class.
    /// </summary>
    public SeriesLayoutProperties():base(){}
        /// <summary>
    ///Initializes a new instance of the SeriesLayoutProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SeriesLayoutProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the SeriesLayoutProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SeriesLayoutProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the SeriesLayoutProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public SeriesLayoutProperties(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ParentLabelLayout), 0, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesElementVisibilities), 0, 1, version: FileFormatVersions.Office2016),
    new CompositeParticle(ParticleType.Choice, 0, 1)
    {
        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Aggregation), 0, 1, version: FileFormatVersions.Office2016),
        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Binning), 0, 1, version: FileFormatVersions.Office2016)
    },
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Statistics), 0, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Subtotals), 0, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList), 0, 1, version: FileFormatVersions.Office2016)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
        /// <summary>
    /// <para> ParentLabelLayout.</para>
    /// <para> Represents the following element tag in the schema: cx:parentLabelLayout </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
	[Index(0)]
    public ParentLabelLayout ParentLabelLayout
	{
        get => GetElement<ParentLabelLayout>(0);
        set => SetElement(0, value);
	}
    /// <summary>
    /// <para> SeriesElementVisibilities.</para>
    /// <para> Represents the following element tag in the schema: cx:visibility </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
	[Index(1)]
    public SeriesElementVisibilities SeriesElementVisibilities
	{
        get => GetElement<SeriesElementVisibilities>(1);
        set => SetElement(1, value);
	}


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SeriesLayoutProperties>(deep);

}
/// <summary>
/// <para>Defines the AxisId Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:axisId.</para>
/// </summary>

[NumberValidator(SimpleType = typeof(UInt32Value))]

[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(80, "axisId")]
public partial class AxisId : OpenXmlLeafTextElement
{
    
    
    /// <summary>
    /// Initializes a new instance of the AxisId class.
    /// </summary>
    public AxisId():base(){}
    
        /// <summary>
    /// Initializes a new instance of the AxisId class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public AxisId(string text):base(text)
    {
    }
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new UInt32Value(){ InnerText = text };
    }


    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<AxisId>(deep);

}
/// <summary>
/// <para>Defines the PlotSurface Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:plotSurface.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ShapeProperties &lt;cx:spPr></description></item>
///<item><description>ExtensionList &lt;cx:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ShapeProperties), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(ExtensionList), FileFormatVersions.Office2016)]

[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(80, "plotSurface")]
public partial class PlotSurface : OpenXmlCompositeElement
{
    
    
    /// <summary>
    /// Initializes a new instance of the PlotSurface class.
    /// </summary>
    public PlotSurface():base(){}
        /// <summary>
    ///Initializes a new instance of the PlotSurface class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PlotSurface(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the PlotSurface class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PlotSurface(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the PlotSurface class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public PlotSurface(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties), 0, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList), 0, 1, version: FileFormatVersions.Office2016)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
        /// <summary>
    /// <para> ShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: cx:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
	[Index(0)]
    public ShapeProperties ShapeProperties
	{
        get => GetElement<ShapeProperties>(0);
        set => SetElement(0, value);
	}
    /// <summary>
    /// <para> ExtensionList.</para>
    /// <para> Represents the following element tag in the schema: cx:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
	[Index(1)]
    public ExtensionList ExtensionList
	{
        get => GetElement<ExtensionList>(1);
        set => SetElement(1, value);
	}


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PlotSurface>(deep);

}
/// <summary>
/// <para>Defines the Series Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:series.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Text &lt;cx:tx></description></item>
///<item><description>ShapeProperties &lt;cx:spPr></description></item>
///<item><description>DataPoint &lt;cx:dataPt></description></item>
///<item><description>DataLabels &lt;cx:dataLabels></description></item>
///<item><description>DataId &lt;cx:dataId></description></item>
///<item><description>SeriesLayoutProperties &lt;cx:layoutPr></description></item>
///<item><description>AxisId &lt;cx:axisId></description></item>
///<item><description>ExtensionList &lt;cx:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Text), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(ShapeProperties), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(DataPoint), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(DataLabels), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(DataId), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(SeriesLayoutProperties), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(AxisId), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(ExtensionList), FileFormatVersions.Office2016)]

[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(80, "series")]
public partial class Series : OpenXmlCompositeElement
{
    
        /// <summary>
    /// <para> layoutId, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: layoutId </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "layoutId")]
    [Index(0)]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayout> LayoutId { get; set; }
    /// <summary>
    /// <para> hidden, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: hidden </para>
    /// </summary>
    [SchemaAttr(0, "hidden")]
    [Index(1)]
    public BooleanValue Hidden { get; set; }
    /// <summary>
    /// <para> ownerIdx, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: ownerIdx </para>
    /// </summary>
    [SchemaAttr(0, "ownerIdx")]
    [Index(2)]
    public UInt32Value OwnerIdx { get; set; }
    /// <summary>
    /// <para> uniqueId, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: uniqueId </para>
    /// </summary>
    [SchemaAttr(0, "uniqueId")]
    [Index(3)]
    public StringValue UniqueId { get; set; }
    /// <summary>
    /// <para> formatIdx, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: formatIdx </para>
    /// </summary>
    [SchemaAttr(0, "formatIdx")]
    [Index(4)]
    public UInt32Value FormatIdx { get; set; }

    /// <summary>
    /// Initializes a new instance of the Series class.
    /// </summary>
    public Series():base(){}
        /// <summary>
    ///Initializes a new instance of the Series class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Series(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the Series class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Series(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the Series class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Series(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Text), 0, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties), 0, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataPoint), 0, 0, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabels), 0, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataId), 0, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayoutProperties), 0, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisId), 0, 0, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList), 0, 1, version: FileFormatVersions.Office2016)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
        /// <summary>
    /// <para> Text.</para>
    /// <para> Represents the following element tag in the schema: cx:tx </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
	[Index(0)]
    public Text Text
	{
        get => GetElement<Text>(0);
        set => SetElement(0, value);
	}
    /// <summary>
    /// <para> ShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: cx:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
	[Index(1)]
    public ShapeProperties ShapeProperties
	{
        get => GetElement<ShapeProperties>(1);
        set => SetElement(1, value);
	}


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Series>(deep);

}
/// <summary>
/// <para>Defines the PlotAreaRegion Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:plotAreaRegion.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>PlotSurface &lt;cx:plotSurface></description></item>
///<item><description>Series &lt;cx:series></description></item>
///<item><description>ExtensionList &lt;cx:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(PlotSurface), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(Series), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(ExtensionList), FileFormatVersions.Office2016)]

[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(80, "plotAreaRegion")]
public partial class PlotAreaRegion : OpenXmlCompositeElement
{
    
    
    /// <summary>
    /// Initializes a new instance of the PlotAreaRegion class.
    /// </summary>
    public PlotAreaRegion():base(){}
        /// <summary>
    ///Initializes a new instance of the PlotAreaRegion class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PlotAreaRegion(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the PlotAreaRegion class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PlotAreaRegion(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the PlotAreaRegion class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public PlotAreaRegion(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PlotSurface), 0, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series), 0, 0, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList), 0, 1, version: FileFormatVersions.Office2016)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
        /// <summary>
    /// <para> PlotSurface.</para>
    /// <para> Represents the following element tag in the schema: cx:plotSurface </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
	[Index(0)]
    public PlotSurface PlotSurface
	{
        get => GetElement<PlotSurface>(0);
        set => SetElement(0, value);
	}


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PlotAreaRegion>(deep);

}
/// <summary>
/// <para>Defines the Axis Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:axis.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>CategoryAxisScaling &lt;cx:catScaling></description></item>
///<item><description>ValueAxisScaling &lt;cx:valScaling></description></item>
///<item><description>AxisTitle &lt;cx:title></description></item>
///<item><description>AxisUnits &lt;cx:units></description></item>
///<item><description>MajorGridlinesGridlines &lt;cx:majorGridlines></description></item>
///<item><description>MinorGridlinesGridlines &lt;cx:minorGridlines></description></item>
///<item><description>MajorTickMarksTickMarks &lt;cx:majorTickMarks></description></item>
///<item><description>MinorTickMarksTickMarks &lt;cx:minorTickMarks></description></item>
///<item><description>TickLabels &lt;cx:tickLabels></description></item>
///<item><description>NumberFormat &lt;cx:numFmt></description></item>
///<item><description>ShapeProperties &lt;cx:spPr></description></item>
///<item><description>TxPrTextBody &lt;cx:txPr></description></item>
///<item><description>ExtensionList &lt;cx:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(CategoryAxisScaling), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(ValueAxisScaling), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(AxisTitle), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(AxisUnits), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(MajorGridlinesGridlines), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(MinorGridlinesGridlines), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(MajorTickMarksTickMarks), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(MinorTickMarksTickMarks), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(TickLabels), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(NumberFormat), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(ShapeProperties), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(TxPrTextBody), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(ExtensionList), FileFormatVersions.Office2016)]

[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(80, "axis")]
public partial class Axis : OpenXmlCompositeElement
{
    
        /// <summary>
    /// <para> id, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "id")]
    [Index(0)]
    public UInt32Value Id { get; set; }
    /// <summary>
    /// <para> hidden, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: hidden </para>
    /// </summary>
    [SchemaAttr(0, "hidden")]
    [Index(1)]
    public BooleanValue Hidden { get; set; }

    /// <summary>
    /// Initializes a new instance of the Axis class.
    /// </summary>
    public Axis():base(){}
        /// <summary>
    ///Initializes a new instance of the Axis class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Axis(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the Axis class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Axis(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the Axis class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Axis(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new CompositeParticle(ParticleType.Choice, 1, 1)
    {
        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.CategoryAxisScaling), 1, 1, version: FileFormatVersions.Office2016),
        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueAxisScaling), 1, 1, version: FileFormatVersions.Office2016)
    },
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisTitle), 0, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnits), 0, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MajorGridlinesGridlines), 0, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MinorGridlinesGridlines), 0, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MajorTickMarksTickMarks), 0, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MinorTickMarksTickMarks), 0, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TickLabels), 0, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumberFormat), 0, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties), 0, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody), 0, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList), 0, 1, version: FileFormatVersions.Office2016)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Axis>(deep);

}
/// <summary>
/// <para>Defines the ChartTitle Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:title.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Text &lt;cx:tx></description></item>
///<item><description>ShapeProperties &lt;cx:spPr></description></item>
///<item><description>TxPrTextBody &lt;cx:txPr></description></item>
///<item><description>ExtensionList &lt;cx:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Text), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(ShapeProperties), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(TxPrTextBody), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(ExtensionList), FileFormatVersions.Office2016)]

[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(80, "title")]
public partial class ChartTitle : OpenXmlCompositeElement
{
    
        /// <summary>
    /// <para> pos, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: pos </para>
    /// </summary>
    [SchemaAttr(0, "pos")]
    [Index(0)]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SidePos> Pos { get; set; }
    /// <summary>
    /// <para> align, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: align </para>
    /// </summary>
    [SchemaAttr(0, "align")]
    [Index(1)]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PosAlign> Align { get; set; }
    /// <summary>
    /// <para> overlay, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: overlay </para>
    /// </summary>
    [SchemaAttr(0, "overlay")]
    [Index(2)]
    public BooleanValue Overlay { get; set; }

    /// <summary>
    /// Initializes a new instance of the ChartTitle class.
    /// </summary>
    public ChartTitle():base(){}
        /// <summary>
    ///Initializes a new instance of the ChartTitle class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ChartTitle(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the ChartTitle class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ChartTitle(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the ChartTitle class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ChartTitle(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Text), 0, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties), 0, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody), 0, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList), 0, 1, version: FileFormatVersions.Office2016)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
        /// <summary>
    /// <para> Text.</para>
    /// <para> Represents the following element tag in the schema: cx:tx </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
	[Index(0)]
    public Text Text
	{
        get => GetElement<Text>(0);
        set => SetElement(0, value);
	}
    /// <summary>
    /// <para> ShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: cx:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
	[Index(1)]
    public ShapeProperties ShapeProperties
	{
        get => GetElement<ShapeProperties>(1);
        set => SetElement(1, value);
	}
    /// <summary>
    /// <para> TxPrTextBody.</para>
    /// <para> Represents the following element tag in the schema: cx:txPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
	[Index(2)]
    public TxPrTextBody TxPrTextBody
	{
        get => GetElement<TxPrTextBody>(2);
        set => SetElement(2, value);
	}
    /// <summary>
    /// <para> ExtensionList.</para>
    /// <para> Represents the following element tag in the schema: cx:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
	[Index(3)]
    public ExtensionList ExtensionList
	{
        get => GetElement<ExtensionList>(3);
        set => SetElement(3, value);
	}


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ChartTitle>(deep);

}
/// <summary>
/// <para>Defines the PlotArea Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:plotArea.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>PlotAreaRegion &lt;cx:plotAreaRegion></description></item>
///<item><description>Axis &lt;cx:axis></description></item>
///<item><description>ShapeProperties &lt;cx:spPr></description></item>
///<item><description>ExtensionList &lt;cx:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(PlotAreaRegion), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(Axis), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(ShapeProperties), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(ExtensionList), FileFormatVersions.Office2016)]

[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(80, "plotArea")]
public partial class PlotArea : OpenXmlCompositeElement
{
    
    
    /// <summary>
    /// Initializes a new instance of the PlotArea class.
    /// </summary>
    public PlotArea():base(){}
        /// <summary>
    ///Initializes a new instance of the PlotArea class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PlotArea(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the PlotArea class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PlotArea(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the PlotArea class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public PlotArea(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PlotAreaRegion), 1, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Axis), 0, 0, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties), 0, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList), 0, 1, version: FileFormatVersions.Office2016)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
        /// <summary>
    /// <para> PlotAreaRegion.</para>
    /// <para> Represents the following element tag in the schema: cx:plotAreaRegion </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
	[Index(0)]
    public PlotAreaRegion PlotAreaRegion
	{
        get => GetElement<PlotAreaRegion>(0);
        set => SetElement(0, value);
	}


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PlotArea>(deep);

}
/// <summary>
/// <para>Defines the Legend Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:legend.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ShapeProperties &lt;cx:spPr></description></item>
///<item><description>TxPrTextBody &lt;cx:txPr></description></item>
///<item><description>ExtensionList &lt;cx:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ShapeProperties), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(TxPrTextBody), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(ExtensionList), FileFormatVersions.Office2016)]

[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(80, "legend")]
public partial class Legend : OpenXmlCompositeElement
{
    
        /// <summary>
    /// <para> pos, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: pos </para>
    /// </summary>
    [SchemaAttr(0, "pos")]
    [Index(0)]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SidePos> Pos { get; set; }
    /// <summary>
    /// <para> align, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: align </para>
    /// </summary>
    [SchemaAttr(0, "align")]
    [Index(1)]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PosAlign> Align { get; set; }
    /// <summary>
    /// <para> overlay, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: overlay </para>
    /// </summary>
    [SchemaAttr(0, "overlay")]
    [Index(2)]
    public BooleanValue Overlay { get; set; }

    /// <summary>
    /// Initializes a new instance of the Legend class.
    /// </summary>
    public Legend():base(){}
        /// <summary>
    ///Initializes a new instance of the Legend class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Legend(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the Legend class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Legend(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the Legend class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Legend(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties), 0, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody), 0, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList), 0, 1, version: FileFormatVersions.Office2016)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
        /// <summary>
    /// <para> ShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: cx:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
	[Index(0)]
    public ShapeProperties ShapeProperties
	{
        get => GetElement<ShapeProperties>(0);
        set => SetElement(0, value);
	}
    /// <summary>
    /// <para> TxPrTextBody.</para>
    /// <para> Represents the following element tag in the schema: cx:txPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
	[Index(1)]
    public TxPrTextBody TxPrTextBody
	{
        get => GetElement<TxPrTextBody>(1);
        set => SetElement(1, value);
	}
    /// <summary>
    /// <para> ExtensionList.</para>
    /// <para> Represents the following element tag in the schema: cx:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
	[Index(2)]
    public ExtensionList ExtensionList
	{
        get => GetElement<ExtensionList>(2);
        set => SetElement(2, value);
	}


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Legend>(deep);

}
/// <summary>
/// <para>Defines the HeaderFooter Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:headerFooter.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>OddHeaderXsdstring &lt;cx:oddHeader></description></item>
///<item><description>OddFooterXsdstring &lt;cx:oddFooter></description></item>
///<item><description>EvenHeaderXsdstring &lt;cx:evenHeader></description></item>
///<item><description>EvenFooterXsdstring &lt;cx:evenFooter></description></item>
///<item><description>FirstHeaderXsdstring &lt;cx:firstHeader></description></item>
///<item><description>FirstFooterXsdstring &lt;cx:firstFooter></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(OddHeaderXsdstring), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(OddFooterXsdstring), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(EvenHeaderXsdstring), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(EvenFooterXsdstring), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(FirstHeaderXsdstring), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(FirstFooterXsdstring), FileFormatVersions.Office2016)]

[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(80, "headerFooter")]
public partial class HeaderFooter : OpenXmlCompositeElement
{
    
        /// <summary>
    /// <para> alignWithMargins, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: alignWithMargins </para>
    /// </summary>
    [SchemaAttr(0, "alignWithMargins")]
    [Index(0)]
    public BooleanValue AlignWithMargins { get; set; }
    /// <summary>
    /// <para> differentOddEven, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: differentOddEven </para>
    /// </summary>
    [SchemaAttr(0, "differentOddEven")]
    [Index(1)]
    public BooleanValue DifferentOddEven { get; set; }
    /// <summary>
    /// <para> differentFirst, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: differentFirst </para>
    /// </summary>
    [SchemaAttr(0, "differentFirst")]
    [Index(2)]
    public BooleanValue DifferentFirst { get; set; }

    /// <summary>
    /// Initializes a new instance of the HeaderFooter class.
    /// </summary>
    public HeaderFooter():base(){}
        /// <summary>
    ///Initializes a new instance of the HeaderFooter class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public HeaderFooter(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the HeaderFooter class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public HeaderFooter(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the HeaderFooter class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public HeaderFooter(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OddHeaderXsdstring), 0, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OddFooterXsdstring), 0, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EvenHeaderXsdstring), 0, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EvenFooterXsdstring), 0, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.FirstHeaderXsdstring), 0, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.FirstFooterXsdstring), 0, 1, version: FileFormatVersions.Office2016)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
        /// <summary>
    /// <para> OddHeaderXsdstring.</para>
    /// <para> Represents the following element tag in the schema: cx:oddHeader </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
	[Index(0)]
    public OddHeaderXsdstring OddHeaderXsdstring
	{
        get => GetElement<OddHeaderXsdstring>(0);
        set => SetElement(0, value);
	}
    /// <summary>
    /// <para> OddFooterXsdstring.</para>
    /// <para> Represents the following element tag in the schema: cx:oddFooter </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
	[Index(1)]
    public OddFooterXsdstring OddFooterXsdstring
	{
        get => GetElement<OddFooterXsdstring>(1);
        set => SetElement(1, value);
	}
    /// <summary>
    /// <para> EvenHeaderXsdstring.</para>
    /// <para> Represents the following element tag in the schema: cx:evenHeader </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
	[Index(2)]
    public EvenHeaderXsdstring EvenHeaderXsdstring
	{
        get => GetElement<EvenHeaderXsdstring>(2);
        set => SetElement(2, value);
	}
    /// <summary>
    /// <para> EvenFooterXsdstring.</para>
    /// <para> Represents the following element tag in the schema: cx:evenFooter </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
	[Index(3)]
    public EvenFooterXsdstring EvenFooterXsdstring
	{
        get => GetElement<EvenFooterXsdstring>(3);
        set => SetElement(3, value);
	}
    /// <summary>
    /// <para> FirstHeaderXsdstring.</para>
    /// <para> Represents the following element tag in the schema: cx:firstHeader </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
	[Index(4)]
    public FirstHeaderXsdstring FirstHeaderXsdstring
	{
        get => GetElement<FirstHeaderXsdstring>(4);
        set => SetElement(4, value);
	}
    /// <summary>
    /// <para> FirstFooterXsdstring.</para>
    /// <para> Represents the following element tag in the schema: cx:firstFooter </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
	[Index(5)]
    public FirstFooterXsdstring FirstFooterXsdstring
	{
        get => GetElement<FirstFooterXsdstring>(5);
        set => SetElement(5, value);
	}


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<HeaderFooter>(deep);

}
/// <summary>
/// <para>Defines the PageMargins Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:pageMargins.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(80, "pageMargins")]
public partial class PageMargins : OpenXmlLeafElement
{
    
        /// <summary>
    /// <para> l, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: l </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "l")]
    [Index(0)]
    public DoubleValue L { get; set; }
    /// <summary>
    /// <para> r, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: r </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "r")]
    [Index(1)]
    public DoubleValue R { get; set; }
    /// <summary>
    /// <para> t, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: t </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "t")]
    [Index(2)]
    public DoubleValue T { get; set; }
    /// <summary>
    /// <para> b, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: b </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "b")]
    [Index(3)]
    public DoubleValue B { get; set; }
    /// <summary>
    /// <para> header, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: header </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "header")]
    [Index(4)]
    public DoubleValue Header { get; set; }
    /// <summary>
    /// <para> footer, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: footer </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "footer")]
    [Index(5)]
    public DoubleValue Footer { get; set; }

    /// <summary>
    /// Initializes a new instance of the PageMargins class.
    /// </summary>
    public PageMargins():base(){}
    
    

    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PageMargins>(deep);

}
/// <summary>
/// <para>Defines the PageSetup Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:pageSetup.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(80, "pageSetup")]
public partial class PageSetup : OpenXmlLeafElement
{
    
        /// <summary>
    /// <para> paperSize, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: paperSize </para>
    /// </summary>
    [SchemaAttr(0, "paperSize")]
    [Index(0)]
    public UInt32Value PaperSize { get; set; }
    /// <summary>
    /// <para> firstPageNumber, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: firstPageNumber </para>
    /// </summary>
    [SchemaAttr(0, "firstPageNumber")]
    [Index(1)]
    public UInt32Value FirstPageNumber { get; set; }
    /// <summary>
    /// <para> orientation, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: orientation </para>
    /// </summary>
    [SchemaAttr(0, "orientation")]
    [Index(2)]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageOrientation> Orientation { get; set; }
    /// <summary>
    /// <para> blackAndWhite, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: blackAndWhite </para>
    /// </summary>
    [SchemaAttr(0, "blackAndWhite")]
    [Index(3)]
    public BooleanValue BlackAndWhite { get; set; }
    /// <summary>
    /// <para> draft, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: draft </para>
    /// </summary>
    [SchemaAttr(0, "draft")]
    [Index(4)]
    public BooleanValue Draft { get; set; }
    /// <summary>
    /// <para> useFirstPageNumber, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: useFirstPageNumber </para>
    /// </summary>
    [SchemaAttr(0, "useFirstPageNumber")]
    [Index(5)]
    public BooleanValue UseFirstPageNumber { get; set; }
    /// <summary>
    /// <para> horizontalDpi, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: horizontalDpi </para>
    /// </summary>
    [SchemaAttr(0, "horizontalDpi")]
    [Index(6)]
    public Int32Value HorizontalDpi { get; set; }
    /// <summary>
    /// <para> verticalDpi, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: verticalDpi </para>
    /// </summary>
    [SchemaAttr(0, "verticalDpi")]
    [Index(7)]
    public Int32Value VerticalDpi { get; set; }
    /// <summary>
    /// <para> copies, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: copies </para>
    /// </summary>
    [SchemaAttr(0, "copies")]
    [Index(8)]
    public UInt32Value Copies { get; set; }

    /// <summary>
    /// Initializes a new instance of the PageSetup class.
    /// </summary>
    public PageSetup():base(){}
    
    

    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PageSetup>(deep);

}
/// <summary>
/// <para>Defines the ChartData Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:chartData.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ExternalData &lt;cx:externalData></description></item>
///<item><description>Data &lt;cx:data></description></item>
///<item><description>ExtensionList &lt;cx:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ExternalData), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(Data), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(ExtensionList), FileFormatVersions.Office2016)]

[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(80, "chartData")]
public partial class ChartData : OpenXmlCompositeElement
{
    
    
    /// <summary>
    /// Initializes a new instance of the ChartData class.
    /// </summary>
    public ChartData():base(){}
        /// <summary>
    ///Initializes a new instance of the ChartData class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ChartData(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the ChartData class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ChartData(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the ChartData class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ChartData(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExternalData), 0, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Data), 1, 0, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList), 0, 1, version: FileFormatVersions.Office2016)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
        /// <summary>
    /// <para> ExternalData.</para>
    /// <para> Represents the following element tag in the schema: cx:externalData </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
	[Index(0)]
    public ExternalData ExternalData
	{
        get => GetElement<ExternalData>(0);
        set => SetElement(0, value);
	}


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ChartData>(deep);

}
/// <summary>
/// <para>Defines the Chart Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:chart.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ChartTitle &lt;cx:title></description></item>
///<item><description>PlotArea &lt;cx:plotArea></description></item>
///<item><description>Legend &lt;cx:legend></description></item>
///<item><description>ExtensionList &lt;cx:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ChartTitle), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(PlotArea), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(Legend), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(ExtensionList), FileFormatVersions.Office2016)]

[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(80, "chart")]
public partial class Chart : OpenXmlCompositeElement
{
    
    
    /// <summary>
    /// Initializes a new instance of the Chart class.
    /// </summary>
    public Chart():base(){}
        /// <summary>
    ///Initializes a new instance of the Chart class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Chart(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the Chart class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Chart(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the Chart class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Chart(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartTitle), 0, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PlotArea), 1, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Legend), 0, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList), 0, 1, version: FileFormatVersions.Office2016)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
        /// <summary>
    /// <para> ChartTitle.</para>
    /// <para> Represents the following element tag in the schema: cx:title </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
	[Index(0)]
    public ChartTitle ChartTitle
	{
        get => GetElement<ChartTitle>(0);
        set => SetElement(0, value);
	}
    /// <summary>
    /// <para> PlotArea.</para>
    /// <para> Represents the following element tag in the schema: cx:plotArea </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
	[Index(1)]
    public PlotArea PlotArea
	{
        get => GetElement<PlotArea>(1);
        set => SetElement(1, value);
	}
    /// <summary>
    /// <para> Legend.</para>
    /// <para> Represents the following element tag in the schema: cx:legend </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
	[Index(2)]
    public Legend Legend
	{
        get => GetElement<Legend>(2);
        set => SetElement(2, value);
	}
    /// <summary>
    /// <para> ExtensionList.</para>
    /// <para> Represents the following element tag in the schema: cx:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
	[Index(3)]
    public ExtensionList ExtensionList
	{
        get => GetElement<ExtensionList>(3);
        set => SetElement(3, value);
	}


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Chart>(deep);

}
/// <summary>
/// <para>Defines the ColorMappingType Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:clrMapOvr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.ExtensionList &lt;a:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList))]

[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(80, "clrMapOvr")]
public partial class ColorMappingType : OpenXmlCompositeElement
{
    
        /// <summary>
    /// <para> Background 1.</para>
    /// <para>Represents the following attribute in the schema: bg1 </para>
    /// </summary>
[RequiredValidator]
[StringValidator(IsToken = true)]
    [SchemaAttr(0, "bg1")]
    [Index(0)]
    public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues> Background1 { get; set; }
    /// <summary>
    /// <para> Text 1.</para>
    /// <para>Represents the following attribute in the schema: tx1 </para>
    /// </summary>
[RequiredValidator]
[StringValidator(IsToken = true)]
    [SchemaAttr(0, "tx1")]
    [Index(1)]
    public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues> Text1 { get; set; }
    /// <summary>
    /// <para> Background 2.</para>
    /// <para>Represents the following attribute in the schema: bg2 </para>
    /// </summary>
[RequiredValidator]
[StringValidator(IsToken = true)]
    [SchemaAttr(0, "bg2")]
    [Index(2)]
    public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues> Background2 { get; set; }
    /// <summary>
    /// <para> Text 2.</para>
    /// <para>Represents the following attribute in the schema: tx2 </para>
    /// </summary>
[RequiredValidator]
[StringValidator(IsToken = true)]
    [SchemaAttr(0, "tx2")]
    [Index(3)]
    public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues> Text2 { get; set; }
    /// <summary>
    /// <para> Accent 1.</para>
    /// <para>Represents the following attribute in the schema: accent1 </para>
    /// </summary>
[RequiredValidator]
[StringValidator(IsToken = true)]
    [SchemaAttr(0, "accent1")]
    [Index(4)]
    public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues> Accent1 { get; set; }
    /// <summary>
    /// <para> Accent 2.</para>
    /// <para>Represents the following attribute in the schema: accent2 </para>
    /// </summary>
[RequiredValidator]
[StringValidator(IsToken = true)]
    [SchemaAttr(0, "accent2")]
    [Index(5)]
    public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues> Accent2 { get; set; }
    /// <summary>
    /// <para> Accent 3.</para>
    /// <para>Represents the following attribute in the schema: accent3 </para>
    /// </summary>
[RequiredValidator]
[StringValidator(IsToken = true)]
    [SchemaAttr(0, "accent3")]
    [Index(6)]
    public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues> Accent3 { get; set; }
    /// <summary>
    /// <para> Accent 4.</para>
    /// <para>Represents the following attribute in the schema: accent4 </para>
    /// </summary>
[RequiredValidator]
[StringValidator(IsToken = true)]
    [SchemaAttr(0, "accent4")]
    [Index(7)]
    public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues> Accent4 { get; set; }
    /// <summary>
    /// <para> Accent 5.</para>
    /// <para>Represents the following attribute in the schema: accent5 </para>
    /// </summary>
[RequiredValidator]
[StringValidator(IsToken = true)]
    [SchemaAttr(0, "accent5")]
    [Index(8)]
    public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues> Accent5 { get; set; }
    /// <summary>
    /// <para> Accent 6.</para>
    /// <para>Represents the following attribute in the schema: accent6 </para>
    /// </summary>
[RequiredValidator]
[StringValidator(IsToken = true)]
    [SchemaAttr(0, "accent6")]
    [Index(9)]
    public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues> Accent6 { get; set; }
    /// <summary>
    /// <para> Hyperlink.</para>
    /// <para>Represents the following attribute in the schema: hlink </para>
    /// </summary>
[RequiredValidator]
[StringValidator(IsToken = true)]
    [SchemaAttr(0, "hlink")]
    [Index(10)]
    public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues> Hyperlink { get; set; }
    /// <summary>
    /// <para> Followed Hyperlink.</para>
    /// <para>Represents the following attribute in the schema: folHlink </para>
    /// </summary>
[RequiredValidator]
[StringValidator(IsToken = true)]
    [SchemaAttr(0, "folHlink")]
    [Index(11)]
    public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues> FollowedHyperlink { get; set; }

    /// <summary>
    /// Initializes a new instance of the ColorMappingType class.
    /// </summary>
    public ColorMappingType():base(){}
        /// <summary>
    ///Initializes a new instance of the ColorMappingType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ColorMappingType(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the ColorMappingType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ColorMappingType(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the ColorMappingType class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ColorMappingType(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList), 0, 1)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
        /// <summary>
    /// <para> ExtensionList.</para>
    /// <para> Represents the following element tag in the schema: a:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
	[Index(0)]
    public DocumentFormat.OpenXml.Drawing.ExtensionList ExtensionList
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.ExtensionList>(0);
        set => SetElement(0, value);
	}


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColorMappingType>(deep);

}
/// <summary>
/// <para>Defines the PrintSettings Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:printSettings.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>HeaderFooter &lt;cx:headerFooter></description></item>
///<item><description>PageMargins &lt;cx:pageMargins></description></item>
///<item><description>PageSetup &lt;cx:pageSetup></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(HeaderFooter), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(PageMargins), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(PageSetup), FileFormatVersions.Office2016)]

[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(80, "printSettings")]
public partial class PrintSettings : OpenXmlCompositeElement
{
    
    
    /// <summary>
    /// Initializes a new instance of the PrintSettings class.
    /// </summary>
    public PrintSettings():base(){}
        /// <summary>
    ///Initializes a new instance of the PrintSettings class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PrintSettings(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the PrintSettings class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PrintSettings(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the PrintSettings class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public PrintSettings(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.HeaderFooter), 0, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageMargins), 0, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageSetup), 0, 1, version: FileFormatVersions.Office2016)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
        /// <summary>
    /// <para> HeaderFooter.</para>
    /// <para> Represents the following element tag in the schema: cx:headerFooter </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
	[Index(0)]
    public HeaderFooter HeaderFooter
	{
        get => GetElement<HeaderFooter>(0);
        set => SetElement(0, value);
	}
    /// <summary>
    /// <para> PageMargins.</para>
    /// <para> Represents the following element tag in the schema: cx:pageMargins </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
	[Index(1)]
    public PageMargins PageMargins
	{
        get => GetElement<PageMargins>(1);
        set => SetElement(1, value);
	}
    /// <summary>
    /// <para> PageSetup.</para>
    /// <para> Represents the following element tag in the schema: cx:pageSetup </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
	[Index(2)]
    public PageSetup PageSetup
	{
        get => GetElement<PageSetup>(2);
        set => SetElement(2, value);
	}


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PrintSettings>(deep);

}
/// <summary>
/// <para>Data reference.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:f.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(80, "f")]
public partial class Formula : OpenXmlLeafTextElement
{
    
        /// <summary>
    /// <para> dir, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: dir </para>
    /// </summary>
    [SchemaAttr(0, "dir")]
    [Index(0)]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.FormulaDirection> Dir { get; set; }

    /// <summary>
    /// Initializes a new instance of the Formula class.
    /// </summary>
    public Formula():base(){}
    
        /// <summary>
    /// Initializes a new instance of the Formula class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public Formula(string text):base(text)
    {
    }
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new StringValue(){ InnerText = text };
    }


    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Formula>(deep);

}
/// <summary>
/// <para>Optional cached data.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:lvl.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ChartStringValue &lt;cx:pt></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ChartStringValue), FileFormatVersions.Office2016)]

[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(80, "lvl")]
public partial class StringLevel : OpenXmlCompositeElement
{
    
        /// <summary>
    /// <para> ptCount, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: ptCount </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "ptCount")]
    [Index(0)]
    public UInt32Value PtCount { get; set; }

    /// <summary>
    /// Initializes a new instance of the StringLevel class.
    /// </summary>
    public StringLevel():base(){}
        /// <summary>
    ///Initializes a new instance of the StringLevel class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public StringLevel(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the StringLevel class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public StringLevel(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the StringLevel class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public StringLevel(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartStringValue), 0, 0, version: FileFormatVersions.Office2016)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<StringLevel>(deep);

}
/// <summary>
/// <para>Optional cached data.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:lvl.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>NumericValue &lt;cx:pt></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(NumericValue), FileFormatVersions.Office2016)]

[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(80, "lvl")]
public partial class NumericLevel : OpenXmlCompositeElement
{
    
        /// <summary>
    /// <para> ptCount, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: ptCount </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "ptCount")]
    [Index(0)]
    public UInt32Value PtCount { get; set; }
    /// <summary>
    /// <para> formatCode, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: formatCode </para>
    /// </summary>
    [SchemaAttr(0, "formatCode")]
    [Index(1)]
    public StringValue FormatCode { get; set; }

    /// <summary>
    /// Initializes a new instance of the NumericLevel class.
    /// </summary>
    public NumericLevel():base(){}
        /// <summary>
    ///Initializes a new instance of the NumericLevel class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NumericLevel(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the NumericLevel class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NumericLevel(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the NumericLevel class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public NumericLevel(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericValue), 0, 0, version: FileFormatVersions.Office2016)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<NumericLevel>(deep);

}
/// <summary>
/// Defines the FormulaDirection enumeration.
/// </summary>
public enum FormulaDirection
{
	///<summary>
///col.
///<para>When the item is serialized out as xml, its value is "col".</para>
///</summary>
[EnumString("col")]
Col,
///<summary>
///row.
///<para>When the item is serialized out as xml, its value is "row".</para>
///</summary>
[EnumString("row")]
Row,

}
/// <summary>
/// Defines the StringDimensionType enumeration.
/// </summary>
public enum StringDimensionType
{
	///<summary>
///cat.
///<para>When the item is serialized out as xml, its value is "cat".</para>
///</summary>
[EnumString("cat")]
Cat,

}
/// <summary>
/// Defines the NumericDimensionType enumeration.
/// </summary>
public enum NumericDimensionType
{
	///<summary>
///val.
///<para>When the item is serialized out as xml, its value is "val".</para>
///</summary>
[EnumString("val")]
Val,
///<summary>
///x.
///<para>When the item is serialized out as xml, its value is "x".</para>
///</summary>
[EnumString("x")]
X,
///<summary>
///y.
///<para>When the item is serialized out as xml, its value is "y".</para>
///</summary>
[EnumString("y")]
Y,
///<summary>
///size.
///<para>When the item is serialized out as xml, its value is "size".</para>
///</summary>
[EnumString("size")]
Size,

}
/// <summary>
/// Defines the SidePos enumeration.
/// </summary>
public enum SidePos
{
	///<summary>
///l.
///<para>When the item is serialized out as xml, its value is "l".</para>
///</summary>
[EnumString("l")]
L,
///<summary>
///t.
///<para>When the item is serialized out as xml, its value is "t".</para>
///</summary>
[EnumString("t")]
T,
///<summary>
///r.
///<para>When the item is serialized out as xml, its value is "r".</para>
///</summary>
[EnumString("r")]
R,
///<summary>
///b.
///<para>When the item is serialized out as xml, its value is "b".</para>
///</summary>
[EnumString("b")]
B,

}
/// <summary>
/// Defines the PosAlign enumeration.
/// </summary>
public enum PosAlign
{
	///<summary>
///min.
///<para>When the item is serialized out as xml, its value is "min".</para>
///</summary>
[EnumString("min")]
Min,
///<summary>
///ctr.
///<para>When the item is serialized out as xml, its value is "ctr".</para>
///</summary>
[EnumString("ctr")]
Ctr,
///<summary>
///max.
///<para>When the item is serialized out as xml, its value is "max".</para>
///</summary>
[EnumString("max")]
Max,

}
/// <summary>
/// Defines the AxisUnit enumeration.
/// </summary>
public enum AxisUnit
{
	///<summary>
///hundreds.
///<para>When the item is serialized out as xml, its value is "hundreds".</para>
///</summary>
[EnumString("hundreds")]
Hundreds,
///<summary>
///thousands.
///<para>When the item is serialized out as xml, its value is "thousands".</para>
///</summary>
[EnumString("thousands")]
Thousands,
///<summary>
///tenThousands.
///<para>When the item is serialized out as xml, its value is "tenThousands".</para>
///</summary>
[EnumString("tenThousands")]
TenThousands,
///<summary>
///hundredThousands.
///<para>When the item is serialized out as xml, its value is "hundredThousands".</para>
///</summary>
[EnumString("hundredThousands")]
HundredThousands,
///<summary>
///millions.
///<para>When the item is serialized out as xml, its value is "millions".</para>
///</summary>
[EnumString("millions")]
Millions,
///<summary>
///tenMillions.
///<para>When the item is serialized out as xml, its value is "tenMillions".</para>
///</summary>
[EnumString("tenMillions")]
TenMillions,
///<summary>
///hundredMillions.
///<para>When the item is serialized out as xml, its value is "hundredMillions".</para>
///</summary>
[EnumString("hundredMillions")]
HundredMillions,
///<summary>
///billions.
///<para>When the item is serialized out as xml, its value is "billions".</para>
///</summary>
[EnumString("billions")]
Billions,
///<summary>
///trillions.
///<para>When the item is serialized out as xml, its value is "trillions".</para>
///</summary>
[EnumString("trillions")]
Trillions,
///<summary>
///percentage.
///<para>When the item is serialized out as xml, its value is "percentage".</para>
///</summary>
[EnumString("percentage")]
Percentage,

}
/// <summary>
/// Defines the TickMarksType enumeration.
/// </summary>
public enum TickMarksType
{
	///<summary>
///in.
///<para>When the item is serialized out as xml, its value is "in".</para>
///</summary>
[EnumString("in")]
In,
///<summary>
///out.
///<para>When the item is serialized out as xml, its value is "out".</para>
///</summary>
[EnumString("out")]
Out,
///<summary>
///cross.
///<para>When the item is serialized out as xml, its value is "cross".</para>
///</summary>
[EnumString("cross")]
Cross,
///<summary>
///none.
///<para>When the item is serialized out as xml, its value is "none".</para>
///</summary>
[EnumString("none")]
None,

}
/// <summary>
/// Defines the SeriesLayout enumeration.
/// </summary>
public enum SeriesLayout
{
	///<summary>
///boxWhisker.
///<para>When the item is serialized out as xml, its value is "boxWhisker".</para>
///</summary>
[EnumString("boxWhisker")]
BoxWhisker,
///<summary>
///clusteredColumn.
///<para>When the item is serialized out as xml, its value is "clusteredColumn".</para>
///</summary>
[EnumString("clusteredColumn")]
ClusteredColumn,
///<summary>
///paretoLine.
///<para>When the item is serialized out as xml, its value is "paretoLine".</para>
///</summary>
[EnumString("paretoLine")]
ParetoLine,
///<summary>
///sunburst.
///<para>When the item is serialized out as xml, its value is "sunburst".</para>
///</summary>
[EnumString("sunburst")]
Sunburst,
///<summary>
///treemap.
///<para>When the item is serialized out as xml, its value is "treemap".</para>
///</summary>
[EnumString("treemap")]
Treemap,
///<summary>
///waterfall.
///<para>When the item is serialized out as xml, its value is "waterfall".</para>
///</summary>
[EnumString("waterfall")]
Waterfall,

}
/// <summary>
/// Defines the ParentLabelLayoutVal enumeration.
/// </summary>
public enum ParentLabelLayoutVal
{
	///<summary>
///none.
///<para>When the item is serialized out as xml, its value is "none".</para>
///</summary>
[EnumString("none")]
None,
///<summary>
///banner.
///<para>When the item is serialized out as xml, its value is "banner".</para>
///</summary>
[EnumString("banner")]
Banner,
///<summary>
///overlapping.
///<para>When the item is serialized out as xml, its value is "overlapping".</para>
///</summary>
[EnumString("overlapping")]
Overlapping,

}
/// <summary>
/// Defines the IntervalClosedSide enumeration.
/// </summary>
public enum IntervalClosedSide
{
	///<summary>
///l.
///<para>When the item is serialized out as xml, its value is "l".</para>
///</summary>
[EnumString("l")]
L,
///<summary>
///r.
///<para>When the item is serialized out as xml, its value is "r".</para>
///</summary>
[EnumString("r")]
R,

}
/// <summary>
/// Defines the QuartileMethod enumeration.
/// </summary>
public enum QuartileMethod
{
	///<summary>
///inclusive.
///<para>When the item is serialized out as xml, its value is "inclusive".</para>
///</summary>
[EnumString("inclusive")]
Inclusive,
///<summary>
///exclusive.
///<para>When the item is serialized out as xml, its value is "exclusive".</para>
///</summary>
[EnumString("exclusive")]
Exclusive,

}
/// <summary>
/// Defines the DataLabelPos enumeration.
/// </summary>
public enum DataLabelPos
{
	///<summary>
///bestFit.
///<para>When the item is serialized out as xml, its value is "bestFit".</para>
///</summary>
[EnumString("bestFit")]
BestFit,
///<summary>
///b.
///<para>When the item is serialized out as xml, its value is "b".</para>
///</summary>
[EnumString("b")]
B,
///<summary>
///ctr.
///<para>When the item is serialized out as xml, its value is "ctr".</para>
///</summary>
[EnumString("ctr")]
Ctr,
///<summary>
///inBase.
///<para>When the item is serialized out as xml, its value is "inBase".</para>
///</summary>
[EnumString("inBase")]
InBase,
///<summary>
///inEnd.
///<para>When the item is serialized out as xml, its value is "inEnd".</para>
///</summary>
[EnumString("inEnd")]
InEnd,
///<summary>
///l.
///<para>When the item is serialized out as xml, its value is "l".</para>
///</summary>
[EnumString("l")]
L,
///<summary>
///outEnd.
///<para>When the item is serialized out as xml, its value is "outEnd".</para>
///</summary>
[EnumString("outEnd")]
OutEnd,
///<summary>
///r.
///<para>When the item is serialized out as xml, its value is "r".</para>
///</summary>
[EnumString("r")]
R,
///<summary>
///t.
///<para>When the item is serialized out as xml, its value is "t".</para>
///</summary>
[EnumString("t")]
T,

}
/// <summary>
/// Defines the PageOrientation enumeration.
/// </summary>
public enum PageOrientation
{
	///<summary>
///default.
///<para>When the item is serialized out as xml, its value is "default".</para>
///</summary>
[EnumString("default")]
Default,
///<summary>
///portrait.
///<para>When the item is serialized out as xml, its value is "portrait".</para>
///</summary>
[EnumString("portrait")]
Portrait,
///<summary>
///landscape.
///<para>When the item is serialized out as xml, its value is "landscape".</para>
///</summary>
[EnumString("landscape")]
Landscape,

}
}
