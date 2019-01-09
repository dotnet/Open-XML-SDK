// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Vml;

namespace DocumentFormat.OpenXml.Vml.Office
{
/// <summary>
/// <para>New Shape Defaults.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is o:shapedefaults.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Vml.Fill &lt;v:fill></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.ImageData &lt;v:imagedata></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Stroke &lt;v:stroke></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.TextBox &lt;v:textbox></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Shadow &lt;v:shadow></description></item>
///<item><description>Skew &lt;o:skew></description></item>
///<item><description>Extrusion &lt;o:extrusion></description></item>
///<item><description>Callout &lt;o:callout></description></item>
///<item><description>Lock &lt;o:lock></description></item>
///<item><description>ColorMostRecentlyUsed &lt;o:colormru></description></item>
///<item><description>ColorMenu &lt;o:colormenu></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Fill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.ImageData))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Stroke))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.TextBox))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Shadow))]
    [ChildElementInfo(typeof(Skew))]
    [ChildElementInfo(typeof(Extrusion))]
    [ChildElementInfo(typeof(Callout))]
    [ChildElementInfo(typeof(Lock))]
    [ChildElementInfo(typeof(ColorMostRecentlyUsed))]
    [ChildElementInfo(typeof(ColorMenu))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ShapeDefaults : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12470;
    /// <inheritdoc/>
    public override string LocalName => "shapedefaults";
    internal override byte NamespaceId => 27;
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    
        /// <summary>
    /// <para> VML Extension Handling Behavior.</para>
    /// <para>Represents the following attribute in the schema: v:ext </para>
    /// </summary>
///<remark> xmlns:v=urn:schemas-microsoft-com:vml
///</remark>
    [SchemaAttr(26, "ext")]
	[SchemaIndex(0)]
    public EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues> Extension { get; set;}
    /// <summary>
    /// <para> Shape ID Optional Storage.</para>
    /// <para>Represents the following attribute in the schema: spidmax </para>
    /// </summary>
    [SchemaAttr(0, "spidmax")]
	[SchemaIndex(1)]
    public IntegerValue MaxShapeId { get; set;}
    /// <summary>
    /// <para> style.</para>
    /// <para>Represents the following attribute in the schema: style </para>
    /// </summary>
    [SchemaAttr(0, "style")]
	[SchemaIndex(2)]
    public StringValue Style { get; set;}
    /// <summary>
    /// <para> Shape Fill Toggle.</para>
    /// <para>Represents the following attribute in the schema: fill </para>
    /// </summary>
    [SchemaAttr(0, "fill")]
	[SchemaIndex(3)]
    public TrueFalseValue BeFilled { get; set;}
    /// <summary>
    /// <para> Default Fill Color.</para>
    /// <para>Represents the following attribute in the schema: fillcolor </para>
    /// </summary>
    [SchemaAttr(0, "fillcolor")]
	[SchemaIndex(4)]
    public StringValue FillColor { get; set;}
    /// <summary>
    /// <para> Shape Stroke Toggle.</para>
    /// <para>Represents the following attribute in the schema: stroke </para>
    /// </summary>
    [SchemaAttr(0, "stroke")]
	[SchemaIndex(5)]
    public TrueFalseValue IsStroke { get; set;}
    /// <summary>
    /// <para> Shape Stroke Color.</para>
    /// <para>Represents the following attribute in the schema: strokecolor </para>
    /// </summary>
    [SchemaAttr(0, "strokecolor")]
	[SchemaIndex(6)]
    public StringValue StrokeColor { get; set;}
    /// <summary>
    /// <para> Allow in Table Cell.</para>
    /// <para>Represents the following attribute in the schema: o:allowincell </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "allowincell")]
	[SchemaIndex(7)]
    public TrueFalseValue AllowInCell { get; set;}
    /// <summary>
    /// <para> allowoverlap.</para>
    /// <para>Represents the following attribute in the schema: o:allowoverlap </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "allowoverlap")]
	[SchemaIndex(8)]
    public TrueFalseValue AllowOverlap { get; set;}
    /// <summary>
    /// <para> insetmode.</para>
    /// <para>Represents the following attribute in the schema: o:insetmode </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "insetmode")]
	[SchemaIndex(9)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues> InsetMode { get; set;}

    /// <summary>
    /// Initializes a new instance of the ShapeDefaults class.
    /// </summary>
    public ShapeDefaults():base(){}
        /// <summary>
    ///Initializes a new instance of the ShapeDefaults class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ShapeDefaults(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the ShapeDefaults class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ShapeDefaults(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the ShapeDefaults class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ShapeDefaults(string outerXml)
        : base(outerXml)
    {
    }

    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 26 == namespaceId && "fill" == name)
    return new DocumentFormat.OpenXml.Vml.Fill();
if( 26 == namespaceId && "imagedata" == name)
    return new DocumentFormat.OpenXml.Vml.ImageData();
if( 26 == namespaceId && "stroke" == name)
    return new DocumentFormat.OpenXml.Vml.Stroke();
if( 26 == namespaceId && "textbox" == name)
    return new DocumentFormat.OpenXml.Vml.TextBox();
if( 26 == namespaceId && "shadow" == name)
    return new DocumentFormat.OpenXml.Vml.Shadow();
if( 27 == namespaceId && "skew" == name)
    return new Skew();
if( 27 == namespaceId && "extrusion" == name)
    return new Extrusion();
if( 27 == namespaceId && "callout" == name)
    return new Callout();
if( 27 == namespaceId && "lock" == name)
    return new Lock();
if( 27 == namespaceId && "colormru" == name)
    return new ColorMostRecentlyUsed();
if( 27 == namespaceId && "colormenu" == name)
    return new ColorMenu();

    return null;
}

        private static readonly string[] eleTagNames = { "fill","imagedata","stroke","textbox","shadow","skew","extrusion","callout","lock","colormru","colormenu" };
    private static readonly byte[] eleNamespaceIds = { 26,26,26,26,26,27,27,27,27,27,27 };
    internal override string[] ElementTagNames => eleTagNames;
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneAll;
        /// <summary>
    /// <para> Fill.</para>
    /// <para> Represents the following element tag in the schema: v:fill </para>
    /// </summary>
    /// <remark>
    /// xmlns:v = urn:schemas-microsoft-com:vml
    /// </remark>
    public DocumentFormat.OpenXml.Vml.Fill Fill
    {
        get => GetElement<DocumentFormat.OpenXml.Vml.Fill>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> ImageData.</para>
    /// <para> Represents the following element tag in the schema: v:imagedata </para>
    /// </summary>
    /// <remark>
    /// xmlns:v = urn:schemas-microsoft-com:vml
    /// </remark>
    public DocumentFormat.OpenXml.Vml.ImageData ImageData
    {
        get => GetElement<DocumentFormat.OpenXml.Vml.ImageData>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> Stroke.</para>
    /// <para> Represents the following element tag in the schema: v:stroke </para>
    /// </summary>
    /// <remark>
    /// xmlns:v = urn:schemas-microsoft-com:vml
    /// </remark>
    public DocumentFormat.OpenXml.Vml.Stroke Stroke
    {
        get => GetElement<DocumentFormat.OpenXml.Vml.Stroke>(2);
        set => SetElement(2, value);
    }
    /// <summary>
    /// <para> TextBox.</para>
    /// <para> Represents the following element tag in the schema: v:textbox </para>
    /// </summary>
    /// <remark>
    /// xmlns:v = urn:schemas-microsoft-com:vml
    /// </remark>
    public DocumentFormat.OpenXml.Vml.TextBox TextBox
    {
        get => GetElement<DocumentFormat.OpenXml.Vml.TextBox>(3);
        set => SetElement(3, value);
    }
    /// <summary>
    /// <para> Shadow.</para>
    /// <para> Represents the following element tag in the schema: v:shadow </para>
    /// </summary>
    /// <remark>
    /// xmlns:v = urn:schemas-microsoft-com:vml
    /// </remark>
    public DocumentFormat.OpenXml.Vml.Shadow Shadow
    {
        get => GetElement<DocumentFormat.OpenXml.Vml.Shadow>(4);
        set => SetElement(4, value);
    }
    /// <summary>
    /// <para> Skew.</para>
    /// <para> Represents the following element tag in the schema: o:skew </para>
    /// </summary>
    /// <remark>
    /// xmlns:o = urn:schemas-microsoft-com:office:office
    /// </remark>
    public Skew Skew
    {
        get => GetElement<Skew>(5);
        set => SetElement(5, value);
    }
    /// <summary>
    /// <para> Extrusion.</para>
    /// <para> Represents the following element tag in the schema: o:extrusion </para>
    /// </summary>
    /// <remark>
    /// xmlns:o = urn:schemas-microsoft-com:office:office
    /// </remark>
    public Extrusion Extrusion
    {
        get => GetElement<Extrusion>(6);
        set => SetElement(6, value);
    }
    /// <summary>
    /// <para> Callout.</para>
    /// <para> Represents the following element tag in the schema: o:callout </para>
    /// </summary>
    /// <remark>
    /// xmlns:o = urn:schemas-microsoft-com:office:office
    /// </remark>
    public Callout Callout
    {
        get => GetElement<Callout>(7);
        set => SetElement(7, value);
    }
    /// <summary>
    /// <para> Shape Protections.</para>
    /// <para> Represents the following element tag in the schema: o:lock </para>
    /// </summary>
    /// <remark>
    /// xmlns:o = urn:schemas-microsoft-com:office:office
    /// </remark>
    public Lock Lock
    {
        get => GetElement<Lock>(8);
        set => SetElement(8, value);
    }
    /// <summary>
    /// <para> Most Recently Used Colors.</para>
    /// <para> Represents the following element tag in the schema: o:colormru </para>
    /// </summary>
    /// <remark>
    /// xmlns:o = urn:schemas-microsoft-com:office:office
    /// </remark>
    public ColorMostRecentlyUsed ColorMostRecentlyUsed
    {
        get => GetElement<ColorMostRecentlyUsed>(9);
        set => SetElement(9, value);
    }
    /// <summary>
    /// <para> UI Default Colors.</para>
    /// <para> Represents the following element tag in the schema: o:colormenu </para>
    /// </summary>
    /// <remark>
    /// xmlns:o = urn:schemas-microsoft-com:office:office
    /// </remark>
    public ColorMenu ColorMenu
    {
        get => GetElement<ColorMenu>(10);
        set => SetElement(10, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShapeDefaults>(deep);

}
/// <summary>
/// <para>Shape Layout Properties.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is o:shapelayout.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ShapeIdMap &lt;o:idmap></description></item>
///<item><description>RegroupTable &lt;o:regrouptable></description></item>
///<item><description>Rules &lt;o:rules></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ShapeIdMap))]
    [ChildElementInfo(typeof(RegroupTable))]
    [ChildElementInfo(typeof(Rules))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ShapeLayout : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12471;
    /// <inheritdoc/>
    public override string LocalName => "shapelayout";
    internal override byte NamespaceId => 27;
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    
        /// <summary>
    /// <para> VML Extension Handling Behavior.</para>
    /// <para>Represents the following attribute in the schema: v:ext </para>
    /// </summary>
///<remark> xmlns:v=urn:schemas-microsoft-com:vml
///</remark>
    [SchemaAttr(26, "ext")]
	[SchemaIndex(0)]
    public EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues> Extension { get; set;}

    /// <summary>
    /// Initializes a new instance of the ShapeLayout class.
    /// </summary>
    public ShapeLayout():base(){}
        /// <summary>
    ///Initializes a new instance of the ShapeLayout class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ShapeLayout(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the ShapeLayout class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ShapeLayout(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the ShapeLayout class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ShapeLayout(string outerXml)
        : base(outerXml)
    {
    }

    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 27 == namespaceId && "idmap" == name)
    return new ShapeIdMap();
if( 27 == namespaceId && "regrouptable" == name)
    return new RegroupTable();
if( 27 == namespaceId && "rules" == name)
    return new Rules();

    return null;
}

        private static readonly string[] eleTagNames = { "idmap","regrouptable","rules" };
    private static readonly byte[] eleNamespaceIds = { 27,27,27 };
    internal override string[] ElementTagNames => eleTagNames;
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneAll;
        /// <summary>
    /// <para> Shape ID Map.</para>
    /// <para> Represents the following element tag in the schema: o:idmap </para>
    /// </summary>
    /// <remark>
    /// xmlns:o = urn:schemas-microsoft-com:office:office
    /// </remark>
    public ShapeIdMap ShapeIdMap
    {
        get => GetElement<ShapeIdMap>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Shape Grouping History.</para>
    /// <para> Represents the following element tag in the schema: o:regrouptable </para>
    /// </summary>
    /// <remark>
    /// xmlns:o = urn:schemas-microsoft-com:office:office
    /// </remark>
    public RegroupTable RegroupTable
    {
        get => GetElement<RegroupTable>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> Rule Set.</para>
    /// <para> Represents the following element tag in the schema: o:rules </para>
    /// </summary>
    /// <remark>
    /// xmlns:o = urn:schemas-microsoft-com:office:office
    /// </remark>
    public Rules Rules
    {
        get => GetElement<Rules>(2);
        set => SetElement(2, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShapeLayout>(deep);

}
/// <summary>
/// <para>Digital Signature Line.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is o:signatureline.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class SignatureLine : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12472;
    /// <inheritdoc/>
    public override string LocalName => "signatureline";
    internal override byte NamespaceId => 27;
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    
        /// <summary>
    /// <para> VML Extension Handling Behavior.</para>
    /// <para>Represents the following attribute in the schema: v:ext </para>
    /// </summary>
///<remark> xmlns:v=urn:schemas-microsoft-com:vml
///</remark>
    [SchemaAttr(26, "ext")]
	[SchemaIndex(0)]
    public EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues> Extension { get; set;}
    /// <summary>
    /// <para> Signature Line Flag.</para>
    /// <para>Represents the following attribute in the schema: issignatureline </para>
    /// </summary>
    [SchemaAttr(0, "issignatureline")]
	[SchemaIndex(1)]
    public TrueFalseValue IsSignatureLine { get; set;}
    /// <summary>
    /// <para> Unique ID.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
	[SchemaIndex(2)]
    public StringValue Id { get; set;}
    /// <summary>
    /// <para> Signature Provider ID.</para>
    /// <para>Represents the following attribute in the schema: provid </para>
    /// </summary>
    [SchemaAttr(0, "provid")]
	[SchemaIndex(3)]
    public StringValue ProviderId { get; set;}
    /// <summary>
    /// <para> Use Signing Instructions Flag.</para>
    /// <para>Represents the following attribute in the schema: signinginstructionsset </para>
    /// </summary>
    [SchemaAttr(0, "signinginstructionsset")]
	[SchemaIndex(4)]
    public TrueFalseValue SigningInstructionsSet { get; set;}
    /// <summary>
    /// <para> User-specified Comments Flag.</para>
    /// <para>Represents the following attribute in the schema: allowcomments </para>
    /// </summary>
    [SchemaAttr(0, "allowcomments")]
	[SchemaIndex(5)]
    public TrueFalseValue AllowComments { get; set;}
    /// <summary>
    /// <para> Show Signed Date Flag.</para>
    /// <para>Represents the following attribute in the schema: showsigndate </para>
    /// </summary>
    [SchemaAttr(0, "showsigndate")]
	[SchemaIndex(6)]
    public TrueFalseValue ShowSignDate { get; set;}
    /// <summary>
    /// <para> Suggested Signer Line 1.</para>
    /// <para>Represents the following attribute in the schema: o:suggestedsigner </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "suggestedsigner")]
	[SchemaIndex(7)]
    public StringValue SuggestedSigner { get; set;}
    /// <summary>
    /// <para> Suggested Signer Line 2.</para>
    /// <para>Represents the following attribute in the schema: o:suggestedsigner2 </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "suggestedsigner2")]
	[SchemaIndex(8)]
    public StringValue SuggestedSigner2 { get; set;}
    /// <summary>
    /// <para> Suggested Signer E-mail Address.</para>
    /// <para>Represents the following attribute in the schema: o:suggestedsigneremail </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "suggestedsigneremail")]
	[SchemaIndex(9)]
    public StringValue SuggestedSignerEmail { get; set;}
    /// <summary>
    /// <para> Instructions for Signing.</para>
    /// <para>Represents the following attribute in the schema: signinginstructions </para>
    /// </summary>
    [SchemaAttr(0, "signinginstructions")]
	[SchemaIndex(10)]
    public StringValue SigningInstructions { get; set;}
    /// <summary>
    /// <para> Additional Signature Information.</para>
    /// <para>Represents the following attribute in the schema: addlxml </para>
    /// </summary>
    [SchemaAttr(0, "addlxml")]
	[SchemaIndex(11)]
    public StringValue AdditionalXml { get; set;}
    /// <summary>
    /// <para> Signature Provider Download URL.</para>
    /// <para>Represents the following attribute in the schema: sigprovurl </para>
    /// </summary>
    [SchemaAttr(0, "sigprovurl")]
	[SchemaIndex(12)]
    public StringValue SignatureProviderUrl { get; set;}

    /// <summary>
    /// Initializes a new instance of the SignatureLine class.
    /// </summary>
    public SignatureLine():base(){}
    
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SignatureLine>(deep);

}
/// <summary>
/// <para>Ink.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is o:ink.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Ink : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12473;
    /// <inheritdoc/>
    public override string LocalName => "ink";
    internal override byte NamespaceId => 27;
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    
        /// <summary>
    /// <para> Ink Data.</para>
    /// <para>Represents the following attribute in the schema: i </para>
    /// </summary>
    [SchemaAttr(0, "i")]
	[SchemaIndex(0)]
    public Base64BinaryValue InkData { get; set;}
    /// <summary>
    /// <para> Annotation Flag.</para>
    /// <para>Represents the following attribute in the schema: annotation </para>
    /// </summary>
    [SchemaAttr(0, "annotation")]
	[SchemaIndex(1)]
    public TrueFalseValue AnnotationFlag { get; set;}

    /// <summary>
    /// Initializes a new instance of the Ink class.
    /// </summary>
    public Ink():base(){}
    
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Ink>(deep);

}
/// <summary>
/// <para>VML Diagram.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is o:diagram.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>RelationTable &lt;o:relationtable></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(RelationTable))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Diagram : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12474;
    /// <inheritdoc/>
    public override string LocalName => "diagram";
    internal override byte NamespaceId => 27;
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    
        /// <summary>
    /// <para> VML Extension Handling Behavior.</para>
    /// <para>Represents the following attribute in the schema: v:ext </para>
    /// </summary>
///<remark> xmlns:v=urn:schemas-microsoft-com:vml
///</remark>
    [SchemaAttr(26, "ext")]
	[SchemaIndex(0)]
    public EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues> Extension { get; set;}
    /// <summary>
    /// <para> Diagram Style Options.</para>
    /// <para>Represents the following attribute in the schema: dgmstyle </para>
    /// </summary>
    [SchemaAttr(0, "dgmstyle")]
	[SchemaIndex(1)]
    public IntegerValue Style { get; set;}
    /// <summary>
    /// <para> Diagram Automatic Format.</para>
    /// <para>Represents the following attribute in the schema: autoformat </para>
    /// </summary>
    [SchemaAttr(0, "autoformat")]
	[SchemaIndex(2)]
    public TrueFalseValue AutoFormat { get; set;}
    /// <summary>
    /// <para> Diagram Reverse Direction.</para>
    /// <para>Represents the following attribute in the schema: reverse </para>
    /// </summary>
    [SchemaAttr(0, "reverse")]
	[SchemaIndex(3)]
    public TrueFalseValue Reverse { get; set;}
    /// <summary>
    /// <para> Diagram Automatic Layout.</para>
    /// <para>Represents the following attribute in the schema: autolayout </para>
    /// </summary>
    [SchemaAttr(0, "autolayout")]
	[SchemaIndex(4)]
    public TrueFalseValue AutoLayout { get; set;}
    /// <summary>
    /// <para> Diagram Layout X Scale.</para>
    /// <para>Represents the following attribute in the schema: dgmscalex </para>
    /// </summary>
    [SchemaAttr(0, "dgmscalex")]
	[SchemaIndex(5)]
    public IntegerValue ScaleX { get; set;}
    /// <summary>
    /// <para> Diagram Layout Y Scale.</para>
    /// <para>Represents the following attribute in the schema: dgmscaley </para>
    /// </summary>
    [SchemaAttr(0, "dgmscaley")]
	[SchemaIndex(6)]
    public IntegerValue ScaleY { get; set;}
    /// <summary>
    /// <para> Diagram Font Size.</para>
    /// <para>Represents the following attribute in the schema: dgmfontsize </para>
    /// </summary>
    [SchemaAttr(0, "dgmfontsize")]
	[SchemaIndex(7)]
    public IntegerValue FontSize { get; set;}
    /// <summary>
    /// <para> Diagram Layout Extents.</para>
    /// <para>Represents the following attribute in the schema: constrainbounds </para>
    /// </summary>
    [SchemaAttr(0, "constrainbounds")]
	[SchemaIndex(8)]
    public StringValue ConstrainBounds { get; set;}
    /// <summary>
    /// <para> Diagram Base Font Size.</para>
    /// <para>Represents the following attribute in the schema: dgmbasetextscale </para>
    /// </summary>
    [SchemaAttr(0, "dgmbasetextscale")]
	[SchemaIndex(9)]
    public IntegerValue BaseTextScale { get; set;}

    /// <summary>
    /// Initializes a new instance of the Diagram class.
    /// </summary>
    public Diagram():base(){}
        /// <summary>
    ///Initializes a new instance of the Diagram class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Diagram(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the Diagram class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Diagram(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the Diagram class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Diagram(string outerXml)
        : base(outerXml)
    {
    }

    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 27 == namespaceId && "relationtable" == name)
    return new RelationTable();

    return null;
}

        private static readonly string[] eleTagNames = { "relationtable" };
    private static readonly byte[] eleNamespaceIds = { 27 };
    internal override string[] ElementTagNames => eleTagNames;
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
        /// <summary>
    /// <para> Diagram Relationship Table.</para>
    /// <para> Represents the following element tag in the schema: o:relationtable </para>
    /// </summary>
    /// <remark>
    /// xmlns:o = urn:schemas-microsoft-com:office:office
    /// </remark>
    public RelationTable RelationTable
    {
        get => GetElement<RelationTable>(0);
        set => SetElement(0, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Diagram>(deep);

}
/// <summary>
/// <para>Skew Transform.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is o:skew.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Skew : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12475;
    /// <inheritdoc/>
    public override string LocalName => "skew";
    internal override byte NamespaceId => 27;
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    
        /// <summary>
    /// <para> VML Extension Handling Behavior.</para>
    /// <para>Represents the following attribute in the schema: v:ext </para>
    /// </summary>
///<remark> xmlns:v=urn:schemas-microsoft-com:vml
///</remark>
    [SchemaAttr(26, "ext")]
	[SchemaIndex(0)]
    public EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues> Extension { get; set;}
    /// <summary>
    /// <para> Skew ID.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
	[SchemaIndex(1)]
    public StringValue Id { get; set;}
    /// <summary>
    /// <para> Skew Toggle.</para>
    /// <para>Represents the following attribute in the schema: on </para>
    /// </summary>
    [SchemaAttr(0, "on")]
	[SchemaIndex(2)]
    public TrueFalseValue On { get; set;}
    /// <summary>
    /// <para> Skew Offset.</para>
    /// <para>Represents the following attribute in the schema: offset </para>
    /// </summary>
    [SchemaAttr(0, "offset")]
	[SchemaIndex(3)]
    public StringValue Offset { get; set;}
    /// <summary>
    /// <para> Skew Origin.</para>
    /// <para>Represents the following attribute in the schema: origin </para>
    /// </summary>
    [SchemaAttr(0, "origin")]
	[SchemaIndex(4)]
    public StringValue Origin { get; set;}
    /// <summary>
    /// <para> Skew Perspective Matrix.</para>
    /// <para>Represents the following attribute in the schema: matrix </para>
    /// </summary>
    [SchemaAttr(0, "matrix")]
	[SchemaIndex(5)]
    public StringValue Matrix { get; set;}

    /// <summary>
    /// Initializes a new instance of the Skew class.
    /// </summary>
    public Skew():base(){}
    
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Skew>(deep);

}
/// <summary>
/// <para>3D Extrusion.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is o:extrusion.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Extrusion : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12476;
    /// <inheritdoc/>
    public override string LocalName => "extrusion";
    internal override byte NamespaceId => 27;
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    
        /// <summary>
    /// <para> VML Extension Handling Behavior.</para>
    /// <para>Represents the following attribute in the schema: v:ext </para>
    /// </summary>
///<remark> xmlns:v=urn:schemas-microsoft-com:vml
///</remark>
    [SchemaAttr(26, "ext")]
	[SchemaIndex(0)]
    public EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues> Extension { get; set;}
    /// <summary>
    /// <para> Extrusion Toggle.</para>
    /// <para>Represents the following attribute in the schema: on </para>
    /// </summary>
    [SchemaAttr(0, "on")]
	[SchemaIndex(1)]
    public TrueFalseValue On { get; set;}
    /// <summary>
    /// <para> Extrusion Type.</para>
    /// <para>Represents the following attribute in the schema: type </para>
    /// </summary>
    [SchemaAttr(0, "type")]
	[SchemaIndex(2)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.ExtrusionValues> Type { get; set;}
    /// <summary>
    /// <para> Extrusion Render Mode.</para>
    /// <para>Represents the following attribute in the schema: render </para>
    /// </summary>
    [SchemaAttr(0, "render")]
	[SchemaIndex(3)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.ExtrusionRenderValues> Render { get; set;}
    /// <summary>
    /// <para> Extrusion Viewpoint Origin.</para>
    /// <para>Represents the following attribute in the schema: viewpointorigin </para>
    /// </summary>
    [SchemaAttr(0, "viewpointorigin")]
	[SchemaIndex(4)]
    public StringValue ViewpointOrigin { get; set;}
    /// <summary>
    /// <para> Extrusion Viewpoint.</para>
    /// <para>Represents the following attribute in the schema: viewpoint </para>
    /// </summary>
    [SchemaAttr(0, "viewpoint")]
	[SchemaIndex(5)]
    public StringValue Viewpoint { get; set;}
    /// <summary>
    /// <para> Extrusion Skew Angle.</para>
    /// <para>Represents the following attribute in the schema: skewangle </para>
    /// </summary>
    [SchemaAttr(0, "skewangle")]
	[SchemaIndex(6)]
    public SingleValue SkewAngle { get; set;}
    /// <summary>
    /// <para> Extrusion Skew.</para>
    /// <para>Represents the following attribute in the schema: skewamt </para>
    /// </summary>
    [SchemaAttr(0, "skewamt")]
	[SchemaIndex(7)]
    public StringValue SkewAmount { get; set;}
    /// <summary>
    /// <para> Forward Extrusion.</para>
    /// <para>Represents the following attribute in the schema: foredepth </para>
    /// </summary>
    [SchemaAttr(0, "foredepth")]
	[SchemaIndex(8)]
    public StringValue ForceDepth { get; set;}
    /// <summary>
    /// <para> Backward Extrusion Depth.</para>
    /// <para>Represents the following attribute in the schema: backdepth </para>
    /// </summary>
    [SchemaAttr(0, "backdepth")]
	[SchemaIndex(9)]
    public StringValue BackDepth { get; set;}
    /// <summary>
    /// <para> Rotation Axis.</para>
    /// <para>Represents the following attribute in the schema: orientation </para>
    /// </summary>
    [SchemaAttr(0, "orientation")]
	[SchemaIndex(10)]
    public StringValue Orientation { get; set;}
    /// <summary>
    /// <para> Rotation Around Axis.</para>
    /// <para>Represents the following attribute in the schema: orientationangle </para>
    /// </summary>
    [SchemaAttr(0, "orientationangle")]
	[SchemaIndex(11)]
    public SingleValue OrientationAngle { get; set;}
    /// <summary>
    /// <para> Rotation Toggle.</para>
    /// <para>Represents the following attribute in the schema: lockrotationcenter </para>
    /// </summary>
    [SchemaAttr(0, "lockrotationcenter")]
	[SchemaIndex(12)]
    public TrueFalseValue LockRotationCenter { get; set;}
    /// <summary>
    /// <para> Center of Rotation Toggle.</para>
    /// <para>Represents the following attribute in the schema: autorotationcenter </para>
    /// </summary>
    [SchemaAttr(0, "autorotationcenter")]
	[SchemaIndex(13)]
    public TrueFalseValue AutoRotationCenter { get; set;}
    /// <summary>
    /// <para> Rotation Center.</para>
    /// <para>Represents the following attribute in the schema: rotationcenter </para>
    /// </summary>
    [SchemaAttr(0, "rotationcenter")]
	[SchemaIndex(14)]
    public StringValue RotationCenter { get; set;}
    /// <summary>
    /// <para> X-Y Rotation Angle.</para>
    /// <para>Represents the following attribute in the schema: rotationangle </para>
    /// </summary>
    [SchemaAttr(0, "rotationangle")]
	[SchemaIndex(15)]
    public StringValue RotationAngle { get; set;}
    /// <summary>
    /// <para> Extrusion Color.</para>
    /// <para>Represents the following attribute in the schema: color </para>
    /// </summary>
    [SchemaAttr(0, "color")]
	[SchemaIndex(16)]
    public StringValue Color { get; set;}
    /// <summary>
    /// <para> Shininess.</para>
    /// <para>Represents the following attribute in the schema: shininess </para>
    /// </summary>
    [SchemaAttr(0, "shininess")]
	[SchemaIndex(17)]
    public SingleValue Shininess { get; set;}
    /// <summary>
    /// <para> Specularity.</para>
    /// <para>Represents the following attribute in the schema: specularity </para>
    /// </summary>
    [SchemaAttr(0, "specularity")]
	[SchemaIndex(18)]
    public StringValue Specularity { get; set;}
    /// <summary>
    /// <para> Diffuse Reflection.</para>
    /// <para>Represents the following attribute in the schema: diffusity </para>
    /// </summary>
    [SchemaAttr(0, "diffusity")]
	[SchemaIndex(19)]
    public StringValue Diffusity { get; set;}
    /// <summary>
    /// <para> Metallic Surface Toggle.</para>
    /// <para>Represents the following attribute in the schema: metal </para>
    /// </summary>
    [SchemaAttr(0, "metal")]
	[SchemaIndex(20)]
    public TrueFalseValue Metal { get; set;}
    /// <summary>
    /// <para> Simulated Bevel.</para>
    /// <para>Represents the following attribute in the schema: edge </para>
    /// </summary>
    [SchemaAttr(0, "edge")]
	[SchemaIndex(21)]
    public StringValue Edge { get; set;}
    /// <summary>
    /// <para> Faceting Quality.</para>
    /// <para>Represents the following attribute in the schema: facet </para>
    /// </summary>
    [SchemaAttr(0, "facet")]
	[SchemaIndex(22)]
    public StringValue Facet { get; set;}
    /// <summary>
    /// <para> Shape Face Lighting Toggle.</para>
    /// <para>Represents the following attribute in the schema: lightface </para>
    /// </summary>
    [SchemaAttr(0, "lightface")]
	[SchemaIndex(23)]
    public TrueFalseValue LightFace { get; set;}
    /// <summary>
    /// <para> Brightness.</para>
    /// <para>Represents the following attribute in the schema: brightness </para>
    /// </summary>
    [SchemaAttr(0, "brightness")]
	[SchemaIndex(24)]
    public StringValue Brightness { get; set;}
    /// <summary>
    /// <para> Primary Light Position.</para>
    /// <para>Represents the following attribute in the schema: lightposition </para>
    /// </summary>
    [SchemaAttr(0, "lightposition")]
	[SchemaIndex(25)]
    public StringValue LightPosition { get; set;}
    /// <summary>
    /// <para> Primary Light Intensity.</para>
    /// <para>Represents the following attribute in the schema: lightlevel </para>
    /// </summary>
    [SchemaAttr(0, "lightlevel")]
	[SchemaIndex(26)]
    public StringValue LightLevel { get; set;}
    /// <summary>
    /// <para> Primary Light Harshness Toggle.</para>
    /// <para>Represents the following attribute in the schema: lightharsh </para>
    /// </summary>
    [SchemaAttr(0, "lightharsh")]
	[SchemaIndex(27)]
    public TrueFalseValue LightHarsh { get; set;}
    /// <summary>
    /// <para> Secondary Light Position.</para>
    /// <para>Represents the following attribute in the schema: lightposition2 </para>
    /// </summary>
    [SchemaAttr(0, "lightposition2")]
	[SchemaIndex(28)]
    public StringValue LightPosition2 { get; set;}
    /// <summary>
    /// <para> Secondary Light Intensity.</para>
    /// <para>Represents the following attribute in the schema: lightlevel2 </para>
    /// </summary>
    [SchemaAttr(0, "lightlevel2")]
	[SchemaIndex(29)]
    public StringValue LightLevel2 { get; set;}
    /// <summary>
    /// <para> Secondary Light Harshness Toggle.</para>
    /// <para>Represents the following attribute in the schema: lightharsh2 </para>
    /// </summary>
    [SchemaAttr(0, "lightharsh2")]
	[SchemaIndex(30)]
    public TrueFalseValue LightHarsh2 { get; set;}

    /// <summary>
    /// Initializes a new instance of the Extrusion class.
    /// </summary>
    public Extrusion():base(){}
    
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Extrusion>(deep);

}
/// <summary>
/// <para>Defines the Callout Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is o:callout.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Callout : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12477;
    /// <inheritdoc/>
    public override string LocalName => "callout";
    internal override byte NamespaceId => 27;
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    
        /// <summary>
    /// <para> VML Extension Handling Behavior.</para>
    /// <para>Represents the following attribute in the schema: v:ext </para>
    /// </summary>
///<remark> xmlns:v=urn:schemas-microsoft-com:vml
///</remark>
    [SchemaAttr(26, "ext")]
	[SchemaIndex(0)]
    public EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues> Extension { get; set;}
    /// <summary>
    /// <para> Callout toggle.</para>
    /// <para>Represents the following attribute in the schema: on </para>
    /// </summary>
    [SchemaAttr(0, "on")]
	[SchemaIndex(1)]
    public TrueFalseValue On { get; set;}
    /// <summary>
    /// <para> Callout type.</para>
    /// <para>Represents the following attribute in the schema: type </para>
    /// </summary>
    [SchemaAttr(0, "type")]
	[SchemaIndex(2)]
    public StringValue Type { get; set;}
    /// <summary>
    /// <para> Callout gap.</para>
    /// <para>Represents the following attribute in the schema: gap </para>
    /// </summary>
    [SchemaAttr(0, "gap")]
	[SchemaIndex(3)]
    public StringValue Gap { get; set;}
    /// <summary>
    /// <para> Callout angle.</para>
    /// <para>Represents the following attribute in the schema: angle </para>
    /// </summary>
    [SchemaAttr(0, "angle")]
	[SchemaIndex(4)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.AngleValues> Angle { get; set;}
    /// <summary>
    /// <para> Callout automatic drop toggle.</para>
    /// <para>Represents the following attribute in the schema: dropauto </para>
    /// </summary>
    [SchemaAttr(0, "dropauto")]
	[SchemaIndex(5)]
    public TrueFalseValue DropAuto { get; set;}
    /// <summary>
    /// <para> Callout drop position.</para>
    /// <para>Represents the following attribute in the schema: drop </para>
    /// </summary>
    [SchemaAttr(0, "drop")]
	[SchemaIndex(6)]
    public StringValue Drop { get; set;}
    /// <summary>
    /// <para> Callout drop distance.</para>
    /// <para>Represents the following attribute in the schema: distance </para>
    /// </summary>
    [SchemaAttr(0, "distance")]
	[SchemaIndex(7)]
    public StringValue Distance { get; set;}
    /// <summary>
    /// <para> Callout length toggle.</para>
    /// <para>Represents the following attribute in the schema: lengthspecified </para>
    /// </summary>
    [SchemaAttr(0, "lengthspecified")]
	[SchemaIndex(8)]
    public TrueFalseValue LengthSpecified { get; set;}
    /// <summary>
    /// <para> Callout length.</para>
    /// <para>Represents the following attribute in the schema: length </para>
    /// </summary>
    [SchemaAttr(0, "length")]
	[SchemaIndex(9)]
    public StringValue Length { get; set;}
    /// <summary>
    /// <para> Callout accent bar toggle.</para>
    /// <para>Represents the following attribute in the schema: accentbar </para>
    /// </summary>
    [SchemaAttr(0, "accentbar")]
	[SchemaIndex(10)]
    public TrueFalseValue AccentBar { get; set;}
    /// <summary>
    /// <para> Callout text border toggle.</para>
    /// <para>Represents the following attribute in the schema: textborder </para>
    /// </summary>
    [SchemaAttr(0, "textborder")]
	[SchemaIndex(11)]
    public TrueFalseValue TextBorder { get; set;}
    /// <summary>
    /// <para> Callout flip x.</para>
    /// <para>Represents the following attribute in the schema: minusx </para>
    /// </summary>
    [SchemaAttr(0, "minusx")]
	[SchemaIndex(12)]
    public TrueFalseValue MinusX { get; set;}
    /// <summary>
    /// <para> Callout flip y.</para>
    /// <para>Represents the following attribute in the schema: minusy </para>
    /// </summary>
    [SchemaAttr(0, "minusy")]
	[SchemaIndex(13)]
    public TrueFalseValue MinusY { get; set;}

    /// <summary>
    /// Initializes a new instance of the Callout class.
    /// </summary>
    public Callout():base(){}
    
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Callout>(deep);

}
/// <summary>
/// <para>Defines the Lock Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is o:lock.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Lock : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12478;
    /// <inheritdoc/>
    public override string LocalName => "lock";
    internal override byte NamespaceId => 27;
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    
        /// <summary>
    /// <para> VML Extension Handling Behavior.</para>
    /// <para>Represents the following attribute in the schema: v:ext </para>
    /// </summary>
///<remark> xmlns:v=urn:schemas-microsoft-com:vml
///</remark>
    [SchemaAttr(26, "ext")]
	[SchemaIndex(0)]
    public EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues> Extension { get; set;}
    /// <summary>
    /// <para> Position Lock.</para>
    /// <para>Represents the following attribute in the schema: position </para>
    /// </summary>
    [SchemaAttr(0, "position")]
	[SchemaIndex(1)]
    public TrueFalseValue Position { get; set;}
    /// <summary>
    /// <para> Selection Lock.</para>
    /// <para>Represents the following attribute in the schema: selection </para>
    /// </summary>
    [SchemaAttr(0, "selection")]
	[SchemaIndex(2)]
    public TrueFalseValue Selection { get; set;}
    /// <summary>
    /// <para> Grouping Lock.</para>
    /// <para>Represents the following attribute in the schema: grouping </para>
    /// </summary>
    [SchemaAttr(0, "grouping")]
	[SchemaIndex(3)]
    public TrueFalseValue Grouping { get; set;}
    /// <summary>
    /// <para> Ungrouping Lock.</para>
    /// <para>Represents the following attribute in the schema: ungrouping </para>
    /// </summary>
    [SchemaAttr(0, "ungrouping")]
	[SchemaIndex(4)]
    public TrueFalseValue Ungrouping { get; set;}
    /// <summary>
    /// <para> Rotation Lock.</para>
    /// <para>Represents the following attribute in the schema: rotation </para>
    /// </summary>
    [SchemaAttr(0, "rotation")]
	[SchemaIndex(5)]
    public TrueFalseValue Rotation { get; set;}
    /// <summary>
    /// <para> Cropping Lock.</para>
    /// <para>Represents the following attribute in the schema: cropping </para>
    /// </summary>
    [SchemaAttr(0, "cropping")]
	[SchemaIndex(6)]
    public TrueFalseValue Cropping { get; set;}
    /// <summary>
    /// <para> Vertices Lock.</para>
    /// <para>Represents the following attribute in the schema: verticies </para>
    /// </summary>
    [SchemaAttr(0, "verticies")]
	[SchemaIndex(7)]
    public TrueFalseValue Verticies { get; set;}
    /// <summary>
    /// <para> Handles Lock.</para>
    /// <para>Represents the following attribute in the schema: adjusthandles </para>
    /// </summary>
    [SchemaAttr(0, "adjusthandles")]
	[SchemaIndex(8)]
    public TrueFalseValue AdjustHandles { get; set;}
    /// <summary>
    /// <para> Text Lock.</para>
    /// <para>Represents the following attribute in the schema: text </para>
    /// </summary>
    [SchemaAttr(0, "text")]
	[SchemaIndex(9)]
    public TrueFalseValue TextLock { get; set;}
    /// <summary>
    /// <para> Aspect Ratio Lock.</para>
    /// <para>Represents the following attribute in the schema: aspectratio </para>
    /// </summary>
    [SchemaAttr(0, "aspectratio")]
	[SchemaIndex(10)]
    public TrueFalseValue AspectRatio { get; set;}
    /// <summary>
    /// <para> AutoShape Type Lock.</para>
    /// <para>Represents the following attribute in the schema: shapetype </para>
    /// </summary>
    [SchemaAttr(0, "shapetype")]
	[SchemaIndex(11)]
    public TrueFalseValue ShapeType { get; set;}

    /// <summary>
    /// Initializes a new instance of the Lock class.
    /// </summary>
    public Lock():base(){}
    
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Lock>(deep);

}
/// <summary>
/// <para>Embedded OLE Object.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is o:OLEObject.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>LinkType &lt;o:LinkType></description></item>
///<item><description>LockedField &lt;o:LockedField></description></item>
///<item><description>FieldCodes &lt;o:FieldCodes></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(LinkType))]
    [ChildElementInfo(typeof(LockedField))]
    [ChildElementInfo(typeof(FieldCodes))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class OleObject : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12479;
    /// <inheritdoc/>
    public override string LocalName => "OLEObject";
    internal override byte NamespaceId => 27;
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    
        /// <summary>
    /// <para> OLE Object Type.</para>
    /// <para>Represents the following attribute in the schema: Type </para>
    /// </summary>
    [SchemaAttr(0, "Type")]
	[SchemaIndex(0)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.OleValues> Type { get; set;}
    /// <summary>
    /// <para> OLE Object Application.</para>
    /// <para>Represents the following attribute in the schema: ProgID </para>
    /// </summary>
    [SchemaAttr(0, "ProgID")]
	[SchemaIndex(1)]
    public StringValue ProgId { get; set;}
    /// <summary>
    /// <para> OLE Object Shape.</para>
    /// <para>Represents the following attribute in the schema: ShapeID </para>
    /// </summary>
    [SchemaAttr(0, "ShapeID")]
	[SchemaIndex(2)]
    public StringValue ShapeId { get; set;}
    /// <summary>
    /// <para> OLE Object Representation.</para>
    /// <para>Represents the following attribute in the schema: DrawAspect </para>
    /// </summary>
    [SchemaAttr(0, "DrawAspect")]
	[SchemaIndex(3)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.OleDrawAspectValues> DrawAspect { get; set;}
    /// <summary>
    /// <para> OLE Object Unique ID.</para>
    /// <para>Represents the following attribute in the schema: ObjectID </para>
    /// </summary>
    [SchemaAttr(0, "ObjectID")]
	[SchemaIndex(4)]
    public StringValue ObjectId { get; set;}
    /// <summary>
    /// <para> Relationship.</para>
    /// <para>Represents the following attribute in the schema: r:id </para>
    /// </summary>
///<remark> xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
///</remark>
    [SchemaAttr(19, "id")]
	[SchemaIndex(5)]
    public StringValue Id { get; set;}
    /// <summary>
    /// <para> OLE Update Mode.</para>
    /// <para>Represents the following attribute in the schema: UpdateMode </para>
    /// </summary>
    [SchemaAttr(0, "UpdateMode")]
	[SchemaIndex(6)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.OleUpdateModeValues> UpdateMode { get; set;}

    /// <summary>
    /// Initializes a new instance of the OleObject class.
    /// </summary>
    public OleObject():base(){}
        /// <summary>
    ///Initializes a new instance of the OleObject class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public OleObject(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the OleObject class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public OleObject(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the OleObject class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public OleObject(string outerXml)
        : base(outerXml)
    {
    }

    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 27 == namespaceId && "LinkType" == name)
    return new LinkType();
if( 27 == namespaceId && "LockedField" == name)
    return new LockedField();
if( 27 == namespaceId && "FieldCodes" == name)
    return new FieldCodes();

    return null;
}

        private static readonly string[] eleTagNames = { "LinkType","LockedField","FieldCodes" };
    private static readonly byte[] eleNamespaceIds = { 27,27,27 };
    internal override string[] ElementTagNames => eleTagNames;
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
        /// <summary>
    /// <para> Embedded Object Alternate Image Request.</para>
    /// <para> Represents the following element tag in the schema: o:LinkType </para>
    /// </summary>
    /// <remark>
    /// xmlns:o = urn:schemas-microsoft-com:office:office
    /// </remark>
    public LinkType LinkType
    {
        get => GetElement<LinkType>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Embedded Object Cannot Be Refreshed.</para>
    /// <para> Represents the following element tag in the schema: o:LockedField </para>
    /// </summary>
    /// <remark>
    /// xmlns:o = urn:schemas-microsoft-com:office:office
    /// </remark>
    public LockedField LockedField
    {
        get => GetElement<LockedField>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> WordprocessingML Field Switches.</para>
    /// <para> Represents the following element tag in the schema: o:FieldCodes </para>
    /// </summary>
    /// <remark>
    /// xmlns:o = urn:schemas-microsoft-com:office:office
    /// </remark>
    public FieldCodes FieldCodes
    {
        get => GetElement<FieldCodes>(2);
        set => SetElement(2, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<OleObject>(deep);

}
/// <summary>
/// <para>Complex.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is o:complex.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Complex : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12480;
    /// <inheritdoc/>
    public override string LocalName => "complex";
    internal override byte NamespaceId => 27;
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    
        /// <summary>
    /// <para> VML Extension Handling Behavior.</para>
    /// <para>Represents the following attribute in the schema: v:ext </para>
    /// </summary>
///<remark> xmlns:v=urn:schemas-microsoft-com:vml
///</remark>
    [SchemaAttr(26, "ext")]
	[SchemaIndex(0)]
    public EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues> Extension { get; set;}

    /// <summary>
    /// Initializes a new instance of the Complex class.
    /// </summary>
    public Complex():base(){}
    
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Complex>(deep);

}
/// <summary>
/// <para>Text Box Left Stroke.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is o:left.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class LeftStroke : StrokeChildType
{
    internal const int ElementTypeIdConst = 12481;
    /// <inheritdoc/>
    public override string LocalName => "left";
    internal override byte NamespaceId => 27;
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    /// <summary>
    /// Initializes a new instance of the LeftStroke class.
    /// </summary>
    public LeftStroke():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<LeftStroke>(deep);

}
/// <summary>
/// <para>Text Box Top Stroke.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is o:top.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class TopStroke : StrokeChildType
{
    internal const int ElementTypeIdConst = 12482;
    /// <inheritdoc/>
    public override string LocalName => "top";
    internal override byte NamespaceId => 27;
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    /// <summary>
    /// Initializes a new instance of the TopStroke class.
    /// </summary>
    public TopStroke():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<TopStroke>(deep);

}
/// <summary>
/// <para>Text Box Right Stroke.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is o:right.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class RightStroke : StrokeChildType
{
    internal const int ElementTypeIdConst = 12483;
    /// <inheritdoc/>
    public override string LocalName => "right";
    internal override byte NamespaceId => 27;
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    /// <summary>
    /// Initializes a new instance of the RightStroke class.
    /// </summary>
    public RightStroke():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RightStroke>(deep);

}
/// <summary>
/// <para>Text Box Bottom Stroke.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is o:bottom.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class BottomStroke : StrokeChildType
{
    internal const int ElementTypeIdConst = 12484;
    /// <inheritdoc/>
    public override string LocalName => "bottom";
    internal override byte NamespaceId => 27;
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    /// <summary>
    /// Initializes a new instance of the BottomStroke class.
    /// </summary>
    public BottomStroke():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<BottomStroke>(deep);

}
/// <summary>
/// <para>Text Box Interior Stroke.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is o:column.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ColumnStroke : StrokeChildType
{
    internal const int ElementTypeIdConst = 12485;
    /// <inheritdoc/>
    public override string LocalName => "column";
    internal override byte NamespaceId => 27;
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    /// <summary>
    /// Initializes a new instance of the ColumnStroke class.
    /// </summary>
    public ColumnStroke():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColumnStroke>(deep);

}
/// <summary>
/// Defines the StrokeChildType class.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class StrokeChildType : OpenXmlLeafElement
{
    
        /// <summary>
    /// <para> VML Extension Handling Behavior.</para>
    /// <para>Represents the following attribute in the schema: v:ext </para>
    /// </summary>
///<remark> xmlns:v=urn:schemas-microsoft-com:vml
///</remark>
    [SchemaAttr(26, "ext")]
	[SchemaIndex(0)]
    public EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues> Extension { get; set;}
    /// <summary>
    /// <para> Stroke Toggle.</para>
    /// <para>Represents the following attribute in the schema: on </para>
    /// </summary>
    [SchemaAttr(0, "on")]
	[SchemaIndex(1)]
    public TrueFalseValue On { get; set;}
    /// <summary>
    /// <para> Stroke Weight.</para>
    /// <para>Represents the following attribute in the schema: weight </para>
    /// </summary>
    [SchemaAttr(0, "weight")]
	[SchemaIndex(2)]
    public StringValue Weight { get; set;}
    /// <summary>
    /// <para> Stroke Color.</para>
    /// <para>Represents the following attribute in the schema: color </para>
    /// </summary>
    [SchemaAttr(0, "color")]
	[SchemaIndex(3)]
    public StringValue Color { get; set;}
    /// <summary>
    /// <para> Stroke Alternate Pattern Color.</para>
    /// <para>Represents the following attribute in the schema: color2 </para>
    /// </summary>
    [SchemaAttr(0, "color2")]
	[SchemaIndex(4)]
    public StringValue Color2 { get; set;}
    /// <summary>
    /// <para> Stroke Opacity.</para>
    /// <para>Represents the following attribute in the schema: opacity </para>
    /// </summary>
    [SchemaAttr(0, "opacity")]
	[SchemaIndex(5)]
    public StringValue Opacity { get; set;}
    /// <summary>
    /// <para> Stroke Line Style.</para>
    /// <para>Represents the following attribute in the schema: linestyle </para>
    /// </summary>
    [SchemaAttr(0, "linestyle")]
	[SchemaIndex(6)]
    public EnumValue<DocumentFormat.OpenXml.Vml.StrokeLineStyleValues> LineStyle { get; set;}
    /// <summary>
    /// <para> Miter Joint Limit.</para>
    /// <para>Represents the following attribute in the schema: miterlimit </para>
    /// </summary>
    [SchemaAttr(0, "miterlimit")]
	[SchemaIndex(7)]
    public DecimalValue MiterLimit { get; set;}
    /// <summary>
    /// <para> Line End Join Style).</para>
    /// <para>Represents the following attribute in the schema: joinstyle </para>
    /// </summary>
    [SchemaAttr(0, "joinstyle")]
	[SchemaIndex(8)]
    public EnumValue<DocumentFormat.OpenXml.Vml.StrokeJoinStyleValues> JoinStyle { get; set;}
    /// <summary>
    /// <para> Line End Cap.</para>
    /// <para>Represents the following attribute in the schema: endcap </para>
    /// </summary>
    [SchemaAttr(0, "endcap")]
	[SchemaIndex(9)]
    public EnumValue<DocumentFormat.OpenXml.Vml.StrokeEndCapValues> EndCap { get; set;}
    /// <summary>
    /// <para> Stroke Dash Pattern.</para>
    /// <para>Represents the following attribute in the schema: dashstyle </para>
    /// </summary>
    [SchemaAttr(0, "dashstyle")]
	[SchemaIndex(10)]
    public StringValue DashStyle { get; set;}
    /// <summary>
    /// <para> Inset Border From Path.</para>
    /// <para>Represents the following attribute in the schema: insetpen </para>
    /// </summary>
    [SchemaAttr(0, "insetpen")]
	[SchemaIndex(11)]
    public TrueFalseValue InsetPen { get; set;}
    /// <summary>
    /// <para> Stroke Image Style.</para>
    /// <para>Represents the following attribute in the schema: filltype </para>
    /// </summary>
    [SchemaAttr(0, "filltype")]
	[SchemaIndex(12)]
    public EnumValue<DocumentFormat.OpenXml.Vml.FillTypeValues> FillType { get; set;}
    /// <summary>
    /// <para> Stroke Image Location.</para>
    /// <para>Represents the following attribute in the schema: src </para>
    /// </summary>
    [SchemaAttr(0, "src")]
	[SchemaIndex(13)]
    public StringValue Source { get; set;}
    /// <summary>
    /// <para> Stroke Image Aspect Ratio.</para>
    /// <para>Represents the following attribute in the schema: imageaspect </para>
    /// </summary>
    [SchemaAttr(0, "imageaspect")]
	[SchemaIndex(14)]
    public EnumValue<DocumentFormat.OpenXml.Vml.ImageAspectValues> ImageAspect { get; set;}
    /// <summary>
    /// <para> Stroke Image Size.</para>
    /// <para>Represents the following attribute in the schema: imagesize </para>
    /// </summary>
    [SchemaAttr(0, "imagesize")]
	[SchemaIndex(15)]
    public StringValue ImageSize { get; set;}
    /// <summary>
    /// <para> Stoke Image Alignment.</para>
    /// <para>Represents the following attribute in the schema: imagealignshape </para>
    /// </summary>
    [SchemaAttr(0, "imagealignshape")]
	[SchemaIndex(16)]
    public TrueFalseValue ImageAlignShape { get; set;}
    /// <summary>
    /// <para> Line Start Arrowhead.</para>
    /// <para>Represents the following attribute in the schema: startarrow </para>
    /// </summary>
    [SchemaAttr(0, "startarrow")]
	[SchemaIndex(17)]
    public EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowValues> StartArrow { get; set;}
    /// <summary>
    /// <para> Line Start Arrowhead Width.</para>
    /// <para>Represents the following attribute in the schema: startarrowwidth </para>
    /// </summary>
    [SchemaAttr(0, "startarrowwidth")]
	[SchemaIndex(18)]
    public EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues> StartArrowWidth { get; set;}
    /// <summary>
    /// <para> Line Start Arrowhead Length.</para>
    /// <para>Represents the following attribute in the schema: startarrowlength </para>
    /// </summary>
    [SchemaAttr(0, "startarrowlength")]
	[SchemaIndex(19)]
    public EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues> StartArrowLength { get; set;}
    /// <summary>
    /// <para> Line End Arrowhead.</para>
    /// <para>Represents the following attribute in the schema: endarrow </para>
    /// </summary>
    [SchemaAttr(0, "endarrow")]
	[SchemaIndex(20)]
    public EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowValues> EndArrow { get; set;}
    /// <summary>
    /// <para> Line End Arrowhead Width.</para>
    /// <para>Represents the following attribute in the schema: endarrowwidth </para>
    /// </summary>
    [SchemaAttr(0, "endarrowwidth")]
	[SchemaIndex(21)]
    public EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues> EndArrowWidth { get; set;}
    /// <summary>
    /// <para> Line End Arrowhead Length.</para>
    /// <para>Represents the following attribute in the schema: endarrowlength </para>
    /// </summary>
    [SchemaAttr(0, "endarrowlength")]
	[SchemaIndex(22)]
    public EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues> EndArrowLength { get; set;}
    /// <summary>
    /// <para> Original Image Reference.</para>
    /// <para>Represents the following attribute in the schema: o:href </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "href")]
	[SchemaIndex(23)]
    public StringValue Href { get; set;}
    /// <summary>
    /// <para> Alternate Image Reference.</para>
    /// <para>Represents the following attribute in the schema: o:althref </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "althref")]
	[SchemaIndex(24)]
    public StringValue AlternateImageReference { get; set;}
    /// <summary>
    /// <para> Stroke Title.</para>
    /// <para>Represents the following attribute in the schema: o:title </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "title")]
	[SchemaIndex(25)]
    public StringValue Title { get; set;}
    /// <summary>
    /// <para> Force Dashed Outline.</para>
    /// <para>Represents the following attribute in the schema: o:forcedash </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "forcedash")]
	[SchemaIndex(26)]
    public TrueFalseValue ForceDash { get; set;}

    
    
    /// <summary>
    /// Initializes a new instance of the StrokeChildType class.
    /// </summary>
    protected StrokeChildType(){}
    
    
}
/// <summary>
/// <para>Shape Clipping Path.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is o:clippath.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ClipPath : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12486;
    /// <inheritdoc/>
    public override string LocalName => "clippath";
    internal override byte NamespaceId => 27;
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    
        /// <summary>
    /// <para> Path Definition.</para>
    /// <para>Represents the following attribute in the schema: o:v </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "v")]
	[SchemaIndex(0)]
    public StringValue Value { get; set;}

    /// <summary>
    /// Initializes a new instance of the ClipPath class.
    /// </summary>
    public ClipPath():base(){}
    
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ClipPath>(deep);

}
/// <summary>
/// <para>Shape Fill Extended Properties.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is o:fill.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class FillExtendedProperties : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12487;
    /// <inheritdoc/>
    public override string LocalName => "fill";
    internal override byte NamespaceId => 27;
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    
        /// <summary>
    /// <para> VML Extension Handling Behavior.</para>
    /// <para>Represents the following attribute in the schema: v:ext </para>
    /// </summary>
///<remark> xmlns:v=urn:schemas-microsoft-com:vml
///</remark>
    [SchemaAttr(26, "ext")]
	[SchemaIndex(0)]
    public EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues> Extension { get; set;}
    /// <summary>
    /// <para> Fill Type.</para>
    /// <para>Represents the following attribute in the schema: type </para>
    /// </summary>
    [SchemaAttr(0, "type")]
	[SchemaIndex(1)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.FillValues> Type { get; set;}

    /// <summary>
    /// Initializes a new instance of the FillExtendedProperties class.
    /// </summary>
    public FillExtendedProperties():base(){}
    
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<FillExtendedProperties>(deep);

}
/// <summary>
/// <para>Shape ID Map.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is o:idmap.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ShapeIdMap : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12488;
    /// <inheritdoc/>
    public override string LocalName => "idmap";
    internal override byte NamespaceId => 27;
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    
        /// <summary>
    /// <para> VML Extension Handling Behavior.</para>
    /// <para>Represents the following attribute in the schema: v:ext </para>
    /// </summary>
///<remark> xmlns:v=urn:schemas-microsoft-com:vml
///</remark>
    [SchemaAttr(26, "ext")]
	[SchemaIndex(0)]
    public EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues> Extension { get; set;}
    /// <summary>
    /// <para> Shape IDs.</para>
    /// <para>Represents the following attribute in the schema: data </para>
    /// </summary>
    [SchemaAttr(0, "data")]
	[SchemaIndex(1)]
    public StringValue Data { get; set;}

    /// <summary>
    /// Initializes a new instance of the ShapeIdMap class.
    /// </summary>
    public ShapeIdMap():base(){}
    
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShapeIdMap>(deep);

}
/// <summary>
/// <para>Shape Grouping History.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is o:regrouptable.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Entry &lt;o:entry></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Entry))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class RegroupTable : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12489;
    /// <inheritdoc/>
    public override string LocalName => "regrouptable";
    internal override byte NamespaceId => 27;
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    
        /// <summary>
    /// <para> VML Extension Handling Behavior.</para>
    /// <para>Represents the following attribute in the schema: v:ext </para>
    /// </summary>
///<remark> xmlns:v=urn:schemas-microsoft-com:vml
///</remark>
    [SchemaAttr(26, "ext")]
	[SchemaIndex(0)]
    public EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues> Extension { get; set;}

    /// <summary>
    /// Initializes a new instance of the RegroupTable class.
    /// </summary>
    public RegroupTable():base(){}
        /// <summary>
    ///Initializes a new instance of the RegroupTable class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RegroupTable(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the RegroupTable class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RegroupTable(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the RegroupTable class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public RegroupTable(string outerXml)
        : base(outerXml)
    {
    }

    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 27 == namespaceId && "entry" == name)
    return new Entry();

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RegroupTable>(deep);

}
/// <summary>
/// <para>Rule Set.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is o:rules.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Rule &lt;o:r></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Rule))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Rules : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12490;
    /// <inheritdoc/>
    public override string LocalName => "rules";
    internal override byte NamespaceId => 27;
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    
        /// <summary>
    /// <para> VML Extension Handling Behavior.</para>
    /// <para>Represents the following attribute in the schema: v:ext </para>
    /// </summary>
///<remark> xmlns:v=urn:schemas-microsoft-com:vml
///</remark>
    [SchemaAttr(26, "ext")]
	[SchemaIndex(0)]
    public EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues> Extension { get; set;}

    /// <summary>
    /// Initializes a new instance of the Rules class.
    /// </summary>
    public Rules():base(){}
        /// <summary>
    ///Initializes a new instance of the Rules class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Rules(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the Rules class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Rules(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the Rules class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Rules(string outerXml)
        : base(outerXml)
    {
    }

    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 27 == namespaceId && "r" == name)
    return new Rule();

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Rules>(deep);

}
/// <summary>
/// <para>Regroup Entry.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is o:entry.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Entry : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12491;
    /// <inheritdoc/>
    public override string LocalName => "entry";
    internal override byte NamespaceId => 27;
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    
        /// <summary>
    /// <para> New Group ID.</para>
    /// <para>Represents the following attribute in the schema: new </para>
    /// </summary>
    [SchemaAttr(0, "new")]
	[SchemaIndex(0)]
    public Int32Value New { get; set;}
    /// <summary>
    /// <para> Old Group ID.</para>
    /// <para>Represents the following attribute in the schema: old </para>
    /// </summary>
    [SchemaAttr(0, "old")]
	[SchemaIndex(1)]
    public Int32Value Old { get; set;}

    /// <summary>
    /// Initializes a new instance of the Entry class.
    /// </summary>
    public Entry():base(){}
    
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Entry>(deep);

}
/// <summary>
/// <para>Rule.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is o:r.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Proxy &lt;o:proxy></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Proxy))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Rule : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12492;
    /// <inheritdoc/>
    public override string LocalName => "r";
    internal override byte NamespaceId => 27;
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    
        /// <summary>
    /// <para> Rule ID.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
	[SchemaIndex(0)]
    public StringValue Id { get; set;}
    /// <summary>
    /// <para> Rule Type.</para>
    /// <para>Represents the following attribute in the schema: type </para>
    /// </summary>
    [SchemaAttr(0, "type")]
	[SchemaIndex(1)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.RuleValues> Type { get; set;}
    /// <summary>
    /// <para> Alignment Rule Type.</para>
    /// <para>Represents the following attribute in the schema: how </para>
    /// </summary>
    [SchemaAttr(0, "how")]
	[SchemaIndex(2)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.AlignmentValues> How { get; set;}
    /// <summary>
    /// <para> Rule Shape Reference.</para>
    /// <para>Represents the following attribute in the schema: idref </para>
    /// </summary>
    [SchemaAttr(0, "idref")]
	[SchemaIndex(3)]
    public StringValue ShapeReference { get; set;}

    /// <summary>
    /// Initializes a new instance of the Rule class.
    /// </summary>
    public Rule():base(){}
        /// <summary>
    ///Initializes a new instance of the Rule class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Rule(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the Rule class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Rule(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the Rule class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Rule(string outerXml)
        : base(outerXml)
    {
    }

    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 27 == namespaceId && "proxy" == name)
    return new Proxy();

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Rule>(deep);

}
/// <summary>
/// <para>Diagram Relationship Table.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is o:relationtable.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Relation &lt;o:rel></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Relation))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class RelationTable : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12493;
    /// <inheritdoc/>
    public override string LocalName => "relationtable";
    internal override byte NamespaceId => 27;
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    
        /// <summary>
    /// <para> VML Extension Handling Behavior.</para>
    /// <para>Represents the following attribute in the schema: v:ext </para>
    /// </summary>
///<remark> xmlns:v=urn:schemas-microsoft-com:vml
///</remark>
    [SchemaAttr(26, "ext")]
	[SchemaIndex(0)]
    public EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues> Extension { get; set;}

    /// <summary>
    /// Initializes a new instance of the RelationTable class.
    /// </summary>
    public RelationTable():base(){}
        /// <summary>
    ///Initializes a new instance of the RelationTable class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RelationTable(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the RelationTable class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RelationTable(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the RelationTable class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public RelationTable(string outerXml)
        : base(outerXml)
    {
    }

    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 27 == namespaceId && "rel" == name)
    return new Relation();

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RelationTable>(deep);

}
/// <summary>
/// <para>Diagram Relationship.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is o:rel.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Relation : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12494;
    /// <inheritdoc/>
    public override string LocalName => "rel";
    internal override byte NamespaceId => 27;
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    
        /// <summary>
    /// <para> VML Extension Handling Behavior.</para>
    /// <para>Represents the following attribute in the schema: v:ext </para>
    /// </summary>
///<remark> xmlns:v=urn:schemas-microsoft-com:vml
///</remark>
    [SchemaAttr(26, "ext")]
	[SchemaIndex(0)]
    public EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues> Extension { get; set;}
    /// <summary>
    /// <para> Diagram Relationship Source Shape.</para>
    /// <para>Represents the following attribute in the schema: idsrc </para>
    /// </summary>
    [SchemaAttr(0, "idsrc")]
	[SchemaIndex(1)]
    public StringValue SourceId { get; set;}
    /// <summary>
    /// <para> Diagram Relationship Destination Shape.</para>
    /// <para>Represents the following attribute in the schema: iddest </para>
    /// </summary>
    [SchemaAttr(0, "iddest")]
	[SchemaIndex(2)]
    public StringValue DestinationId { get; set;}
    /// <summary>
    /// <para> Diagram Relationship Center Shape.</para>
    /// <para>Represents the following attribute in the schema: idcntr </para>
    /// </summary>
    [SchemaAttr(0, "idcntr")]
	[SchemaIndex(3)]
    public StringValue CenterShapeId { get; set;}

    /// <summary>
    /// Initializes a new instance of the Relation class.
    /// </summary>
    public Relation():base(){}
    
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Relation>(deep);

}
/// <summary>
/// <para>Embedded Object Alternate Image Request.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is o:LinkType.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class LinkType : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 12495;
    /// <inheritdoc/>
    public override string LocalName => "LinkType";
    internal override byte NamespaceId => 27;
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    
    
    /// <summary>
    /// Initializes a new instance of the LinkType class.
    /// </summary>
    public LinkType():base(){}
    
        /// <summary>
    /// Initializes a new instance of the LinkType class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public LinkType(string text):base(text)
    {
    }
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new EnumValue<DocumentFormat.OpenXml.Vml.Office.OleLinkValues>(){ InnerText = text };
    }

    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<LinkType>(deep);

}
/// <summary>
/// <para>Embedded Object Cannot Be Refreshed.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is o:LockedField.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class LockedField : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 12496;
    /// <inheritdoc/>
    public override string LocalName => "LockedField";
    internal override byte NamespaceId => 27;
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    
    
    /// <summary>
    /// Initializes a new instance of the LockedField class.
    /// </summary>
    public LockedField():base(){}
    
        /// <summary>
    /// Initializes a new instance of the LockedField class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public LockedField(string text):base(text)
    {
    }
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new TrueFalseBlankValue(){ InnerText = text };
    }

    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<LockedField>(deep);

}
/// <summary>
/// <para>WordprocessingML Field Switches.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is o:FieldCodes.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class FieldCodes : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 12497;
    /// <inheritdoc/>
    public override string LocalName => "FieldCodes";
    internal override byte NamespaceId => 27;
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    
    
    /// <summary>
    /// Initializes a new instance of the FieldCodes class.
    /// </summary>
    public FieldCodes():base(){}
    
        /// <summary>
    /// Initializes a new instance of the FieldCodes class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public FieldCodes(string text):base(text)
    {
    }
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new StringValue(){ InnerText = text };
    }

    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<FieldCodes>(deep);

}
/// <summary>
/// <para>Shape Reference.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is o:proxy.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Proxy : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12498;
    /// <inheritdoc/>
    public override string LocalName => "proxy";
    internal override byte NamespaceId => 27;
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    
        /// <summary>
    /// <para> Start Point Connection Flag.</para>
    /// <para>Represents the following attribute in the schema: start </para>
    /// </summary>
    [SchemaAttr(0, "start")]
	[SchemaIndex(0)]
    public TrueFalseBlankValue Start { get; set;}
    /// <summary>
    /// <para> End Point Connection Flag.</para>
    /// <para>Represents the following attribute in the schema: end </para>
    /// </summary>
    [SchemaAttr(0, "end")]
	[SchemaIndex(1)]
    public TrueFalseBlankValue End { get; set;}
    /// <summary>
    /// <para> Proxy Shape Reference.</para>
    /// <para>Represents the following attribute in the schema: idref </para>
    /// </summary>
    [SchemaAttr(0, "idref")]
	[SchemaIndex(2)]
    public StringValue ShapeReference { get; set;}
    /// <summary>
    /// <para> Connection Location.</para>
    /// <para>Represents the following attribute in the schema: connectloc </para>
    /// </summary>
    [SchemaAttr(0, "connectloc")]
	[SchemaIndex(3)]
    public Int32Value ConnectionLocation { get; set;}

    /// <summary>
    /// Initializes a new instance of the Proxy class.
    /// </summary>
    public Proxy():base(){}
    
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Proxy>(deep);

}
/// <summary>
/// <para>Most Recently Used Colors.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is o:colormru.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ColorMostRecentlyUsed : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12499;
    /// <inheritdoc/>
    public override string LocalName => "colormru";
    internal override byte NamespaceId => 27;
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    
        /// <summary>
    /// <para> VML Extension Handling Behavior.</para>
    /// <para>Represents the following attribute in the schema: v:ext </para>
    /// </summary>
///<remark> xmlns:v=urn:schemas-microsoft-com:vml
///</remark>
    [SchemaAttr(26, "ext")]
	[SchemaIndex(0)]
    public EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues> Extension { get; set;}
    /// <summary>
    /// <para> Recent colors.</para>
    /// <para>Represents the following attribute in the schema: colors </para>
    /// </summary>
    [SchemaAttr(0, "colors")]
	[SchemaIndex(1)]
    public StringValue Colors { get; set;}

    /// <summary>
    /// Initializes a new instance of the ColorMostRecentlyUsed class.
    /// </summary>
    public ColorMostRecentlyUsed():base(){}
    
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColorMostRecentlyUsed>(deep);

}
/// <summary>
/// <para>UI Default Colors.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is o:colormenu.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ColorMenu : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12500;
    /// <inheritdoc/>
    public override string LocalName => "colormenu";
    internal override byte NamespaceId => 27;
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    
        /// <summary>
    /// <para> VML Extension Handling Behavior.</para>
    /// <para>Represents the following attribute in the schema: v:ext </para>
    /// </summary>
///<remark> xmlns:v=urn:schemas-microsoft-com:vml
///</remark>
    [SchemaAttr(26, "ext")]
	[SchemaIndex(0)]
    public EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues> Extension { get; set;}
    /// <summary>
    /// <para> Default stroke color.</para>
    /// <para>Represents the following attribute in the schema: strokecolor </para>
    /// </summary>
    [SchemaAttr(0, "strokecolor")]
	[SchemaIndex(1)]
    public StringValue StrokeColor { get; set;}
    /// <summary>
    /// <para> Default fill color.</para>
    /// <para>Represents the following attribute in the schema: fillcolor </para>
    /// </summary>
    [SchemaAttr(0, "fillcolor")]
	[SchemaIndex(2)]
    public StringValue FillColor { get; set;}
    /// <summary>
    /// <para> Default shadow color.</para>
    /// <para>Represents the following attribute in the schema: shadowcolor </para>
    /// </summary>
    [SchemaAttr(0, "shadowcolor")]
	[SchemaIndex(3)]
    public StringValue ShadowColor { get; set;}
    /// <summary>
    /// <para> Default extrusion color.</para>
    /// <para>Represents the following attribute in the schema: extrusioncolor </para>
    /// </summary>
    [SchemaAttr(0, "extrusioncolor")]
	[SchemaIndex(4)]
    public StringValue ExtrusionColor { get; set;}

    /// <summary>
    /// Initializes a new instance of the ColorMenu class.
    /// </summary>
    public ColorMenu():base(){}
    
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColorMenu>(deep);

}
/// <summary>
/// Alignment Type
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum AlignmentValues
{
	///<summary>
///Top Alignment.
///<para>When the item is serialized out as xml, its value is "top".</para>
///</summary>
[EnumString("top")]
Top,
///<summary>
///Middle Alignment.
///<para>When the item is serialized out as xml, its value is "middle".</para>
///</summary>
[EnumString("middle")]
Middle,
///<summary>
///Bottom Alignment.
///<para>When the item is serialized out as xml, its value is "bottom".</para>
///</summary>
[EnumString("bottom")]
Bottom,
///<summary>
///Left Alignment.
///<para>When the item is serialized out as xml, its value is "left".</para>
///</summary>
[EnumString("left")]
Left,
///<summary>
///Center Alignment.
///<para>When the item is serialized out as xml, its value is "center".</para>
///</summary>
[EnumString("center")]
Center,
///<summary>
///Right Alignment.
///<para>When the item is serialized out as xml, its value is "right".</para>
///</summary>
[EnumString("right")]
Right,

}
/// <summary>
/// Screen Sizes Type
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum ScreenSizeValues
{
	///<summary>
///544x376 pixels.
///<para>When the item is serialized out as xml, its value is "544,376".</para>
///</summary>
[EnumString("544,376")]
Sz544x376,
///<summary>
///640x480 pixels.
///<para>When the item is serialized out as xml, its value is "640,480".</para>
///</summary>
[EnumString("640,480")]
Sz640x480,
///<summary>
///720x512 pixels.
///<para>When the item is serialized out as xml, its value is "720,512".</para>
///</summary>
[EnumString("720,512")]
Sz720x512,
///<summary>
///800x600 pixels.
///<para>When the item is serialized out as xml, its value is "800,600".</para>
///</summary>
[EnumString("800,600")]
Sz800x600,
///<summary>
///1024x768 pixels.
///<para>When the item is serialized out as xml, its value is "1024,768".</para>
///</summary>
[EnumString("1024,768")]
Sz1024x768,
///<summary>
///1152x862 pixels.
///<para>When the item is serialized out as xml, its value is "1152,862".</para>
///</summary>
[EnumString("1152,862")]
Sz1152x862,

}
/// <summary>
/// Inset Margin Type
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum InsetMarginValues
{
	///<summary>
///Automatic Margins.
///<para>When the item is serialized out as xml, its value is "auto".</para>
///</summary>
[EnumString("auto")]
Auto,
///<summary>
///Custom Margins.
///<para>When the item is serialized out as xml, its value is "custom".</para>
///</summary>
[EnumString("custom")]
Custom,

}
/// <summary>
/// Extrusion Color Types
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum ColorModeValues
{
	///<summary>
///Use Shape Fill Color.
///<para>When the item is serialized out as xml, its value is "auto".</para>
///</summary>
[EnumString("auto")]
Auto,
///<summary>
///Use Custom Color.
///<para>When the item is serialized out as xml, its value is "custom".</para>
///</summary>
[EnumString("custom")]
Custom,

}
/// <summary>
/// Extrusion Type
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum ExtrusionValues
{
	///<summary>
///Perspective Projection.
///<para>When the item is serialized out as xml, its value is "perspective".</para>
///</summary>
[EnumString("perspective")]
Perspective,
///<summary>
///Parallel Projection.
///<para>When the item is serialized out as xml, its value is "parallel".</para>
///</summary>
[EnumString("parallel")]
Parallel,

}
/// <summary>
/// Extrusion Rendering Types
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum ExtrusionRenderValues
{
	///<summary>
///Solid.
///<para>When the item is serialized out as xml, its value is "solid".</para>
///</summary>
[EnumString("solid")]
Solid,
///<summary>
///Wireframe.
///<para>When the item is serialized out as xml, its value is "wireFrame".</para>
///</summary>
[EnumString("wireFrame")]
WireFrame,
///<summary>
///Bounding Cube.
///<para>When the item is serialized out as xml, its value is "boundingCube".</para>
///</summary>
[EnumString("boundingCube")]
BoundingCube,

}
/// <summary>
/// Extrusion Planes
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum ExtrusionPlaneValues
{
	///<summary>
///XY Plane.
///<para>When the item is serialized out as xml, its value is "XY".</para>
///</summary>
[EnumString("XY")]
XY,
///<summary>
///ZX Plane.
///<para>When the item is serialized out as xml, its value is "ZX".</para>
///</summary>
[EnumString("ZX")]
ZX,
///<summary>
///YZ Plane.
///<para>When the item is serialized out as xml, its value is "YZ".</para>
///</summary>
[EnumString("YZ")]
YZ,

}
/// <summary>
/// Callout Angles
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum AngleValues
{
	///<summary>
///Any Angle.
///<para>When the item is serialized out as xml, its value is "any".</para>
///</summary>
[EnumString("any")]
Any,
///<summary>
///30 degrees.
///<para>When the item is serialized out as xml, its value is "30".</para>
///</summary>
[EnumString("30")]
Degree30,
///<summary>
///45 degrees.
///<para>When the item is serialized out as xml, its value is "45".</para>
///</summary>
[EnumString("45")]
Degree45,
///<summary>
///60 degrees.
///<para>When the item is serialized out as xml, its value is "60".</para>
///</summary>
[EnumString("60")]
Degree60,
///<summary>
///90 degrees.
///<para>When the item is serialized out as xml, its value is "90".</para>
///</summary>
[EnumString("90")]
Degree90,
///<summary>
///Automatic Angle.
///<para>When the item is serialized out as xml, its value is "auto".</para>
///</summary>
[EnumString("auto")]
Auto,

}
/// <summary>
/// Callout Placement
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum CalloutPlacementValues
{
	///<summary>
///Top placement.
///<para>When the item is serialized out as xml, its value is "top".</para>
///</summary>
[EnumString("top")]
Top,
///<summary>
///Center placement.
///<para>When the item is serialized out as xml, its value is "center".</para>
///</summary>
[EnumString("center")]
Center,
///<summary>
///Bottom placement.
///<para>When the item is serialized out as xml, its value is "bottom".</para>
///</summary>
[EnumString("bottom")]
Bottom,
///<summary>
///User-defined placement.
///<para>When the item is serialized out as xml, its value is "user".</para>
///</summary>
[EnumString("user")]
User,

}
/// <summary>
/// Connector Type
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum ConnectorValues
{
	///<summary>
///No Connector.
///<para>When the item is serialized out as xml, its value is "none".</para>
///</summary>
[EnumString("none")]
None,
///<summary>
///Straight Connector.
///<para>When the item is serialized out as xml, its value is "straight".</para>
///</summary>
[EnumString("straight")]
Straight,
///<summary>
///Elbow Connector.
///<para>When the item is serialized out as xml, its value is "elbow".</para>
///</summary>
[EnumString("elbow")]
Elbow,
///<summary>
///Curved Connector.
///<para>When the item is serialized out as xml, its value is "curved".</para>
///</summary>
[EnumString("curved")]
Curved,

}
/// <summary>
/// Alignment Type
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum HorizontalRuleAlignmentValues
{
	///<summary>
///Left Alignment.
///<para>When the item is serialized out as xml, its value is "left".</para>
///</summary>
[EnumString("left")]
Left,
///<summary>
///Right Alignment.
///<para>When the item is serialized out as xml, its value is "right".</para>
///</summary>
[EnumString("right")]
Right,
///<summary>
///Center Alignment.
///<para>When the item is serialized out as xml, its value is "center".</para>
///</summary>
[EnumString("center")]
Center,

}
/// <summary>
/// Connection Locations Type
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum ConnectValues
{
	///<summary>
///No.
///<para>When the item is serialized out as xml, its value is "none".</para>
///</summary>
[EnumString("none")]
None,
///<summary>
///Four Connections.
///<para>When the item is serialized out as xml, its value is "rect".</para>
///</summary>
[EnumString("rect")]
Rectangle,
///<summary>
///Edit Point Connections.
///<para>When the item is serialized out as xml, its value is "segments".</para>
///</summary>
[EnumString("segments")]
Segments,
///<summary>
///Custom Connections.
///<para>When the item is serialized out as xml, its value is "custom".</para>
///</summary>
[EnumString("custom")]
Custom,

}
/// <summary>
/// Embedded Object Alternate Image Request Types
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum OleLinkValues
{
	///<summary>
///Other Image.
///<para>When the item is serialized out as xml, its value is "Picture".</para>
///</summary>
[EnumString("Picture")]
Picture,
///<summary>
///Bitmap Image.
///<para>When the item is serialized out as xml, its value is "Bitmap".</para>
///</summary>
[EnumString("Bitmap")]
Bitmap,
///<summary>
///Enhanced Metafile Image.
///<para>When the item is serialized out as xml, its value is "EnhancedMetaFile".</para>
///</summary>
[EnumString("EnhancedMetaFile")]
EnhancedMetaFile,

}
/// <summary>
/// OLE Connection Type
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum OleValues
{
	///<summary>
///Embedded Object.
///<para>When the item is serialized out as xml, its value is "Embed".</para>
///</summary>
[EnumString("Embed")]
Embed,
///<summary>
///Linked Object.
///<para>When the item is serialized out as xml, its value is "Link".</para>
///</summary>
[EnumString("Link")]
Link,

}
/// <summary>
/// OLE Object Representations
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum OleDrawAspectValues
{
	///<summary>
///Snapshot.
///<para>When the item is serialized out as xml, its value is "Content".</para>
///</summary>
[EnumString("Content")]
Content,
///<summary>
///Icon.
///<para>When the item is serialized out as xml, its value is "Icon".</para>
///</summary>
[EnumString("Icon")]
Icon,

}
/// <summary>
/// OLE Update Method Type
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum OleUpdateModeValues
{
	///<summary>
///Server Application Update.
///<para>When the item is serialized out as xml, its value is "Always".</para>
///</summary>
[EnumString("Always")]
Always,
///<summary>
///User Update.
///<para>When the item is serialized out as xml, its value is "OnCall".</para>
///</summary>
[EnumString("OnCall")]
OnCall,

}
/// <summary>
/// Shape Fill Type
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum FillValues
{
	///<summary>
///Centered Radial Gradient.
///<para>When the item is serialized out as xml, its value is "gradientCenter".</para>
///</summary>
[EnumString("gradientCenter")]
GradientCenter,
///<summary>
///Solid Fill.
///<para>When the item is serialized out as xml, its value is "solid".</para>
///</summary>
[EnumString("solid")]
Solid,
///<summary>
///Image Pattern.
///<para>When the item is serialized out as xml, its value is "pattern".</para>
///</summary>
[EnumString("pattern")]
Pattern,
///<summary>
///Tiled Image.
///<para>When the item is serialized out as xml, its value is "tile".</para>
///</summary>
[EnumString("tile")]
Tile,
///<summary>
///Stretch Image to Fit.
///<para>When the item is serialized out as xml, its value is "frame".</para>
///</summary>
[EnumString("frame")]
Frame,
///<summary>
///Unscaled Gradient.
///<para>When the item is serialized out as xml, its value is "gradientUnscaled".</para>
///</summary>
[EnumString("gradientUnscaled")]
GradientUnscaled,
///<summary>
///Radial Gradient.
///<para>When the item is serialized out as xml, its value is "gradientRadial".</para>
///</summary>
[EnumString("gradientRadial")]
GradientRadial,
///<summary>
///Linear Gradient.
///<para>When the item is serialized out as xml, its value is "gradient".</para>
///</summary>
[EnumString("gradient")]
Gradient,
///<summary>
///Use Background Fill.
///<para>When the item is serialized out as xml, its value is "background".</para>
///</summary>
[EnumString("background")]
Background,

}
/// <summary>
/// Rule Type
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum RuleValues
{
	///<summary>
///Arc Rule.
///<para>When the item is serialized out as xml, its value is "arc".</para>
///</summary>
[EnumString("arc")]
Arc,
///<summary>
///Callout Rule.
///<para>When the item is serialized out as xml, its value is "callout".</para>
///</summary>
[EnumString("callout")]
Callout,
///<summary>
///Connector Rule.
///<para>When the item is serialized out as xml, its value is "connector".</para>
///</summary>
[EnumString("connector")]
Connector,

}
/// <summary>
/// Black And White Modes
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum BlackAndWhiteModeValues
{
	///<summary>
///Color.
///<para>When the item is serialized out as xml, its value is "color".</para>
///</summary>
[EnumString("color")]
Color,
///<summary>
///Automatic.
///<para>When the item is serialized out as xml, its value is "auto".</para>
///</summary>
[EnumString("auto")]
Auto,
///<summary>
///Grayscale.
///<para>When the item is serialized out as xml, its value is "grayScale".</para>
///</summary>
[EnumString("grayScale")]
GrayScale,
///<summary>
///Light grayscale.
///<para>When the item is serialized out as xml, its value is "lightGrayScale".</para>
///</summary>
[EnumString("lightGrayScale")]
LightGrayScale,
///<summary>
///Inverse Grayscale.
///<para>When the item is serialized out as xml, its value is "inverseGray".</para>
///</summary>
[EnumString("inverseGray")]
InverseGray,
///<summary>
///Gray Outlines.
///<para>When the item is serialized out as xml, its value is "grayOutline".</para>
///</summary>
[EnumString("grayOutline")]
GrayOutline,
///<summary>
///Black And White.
///<para>When the item is serialized out as xml, its value is "highContrast".</para>
///</summary>
[EnumString("highContrast")]
HighContrast,
///<summary>
///Black.
///<para>When the item is serialized out as xml, its value is "black".</para>
///</summary>
[EnumString("black")]
Black,
///<summary>
///White.
///<para>When the item is serialized out as xml, its value is "white".</para>
///</summary>
[EnumString("white")]
White,
///<summary>
///Do Not Show.
///<para>When the item is serialized out as xml, its value is "undrawn".</para>
///</summary>
[EnumString("undrawn")]
Undrawn,
///<summary>
///Black Text And Lines.
///<para>When the item is serialized out as xml, its value is "blackTextAndLines".</para>
///</summary>
[EnumString("blackTextAndLines")]
BlackTextAndLines,

}
}
