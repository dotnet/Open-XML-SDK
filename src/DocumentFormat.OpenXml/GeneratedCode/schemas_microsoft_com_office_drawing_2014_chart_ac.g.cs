// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing.Charts;

namespace DocumentFormat.OpenXml.Office2016.Drawing.ChartsAc
{
/// <summary>
/// <para>Defines the MultiLvlStrData Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c16ac:multiLvlStrLit.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.PointCount &lt;c:ptCount></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Level &lt;c:lvl></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.PointCount))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Level))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class MultiLvlStrData : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13517;
    /// <inheritdoc/>
    public override string LocalName => "multiLvlStrLit";
    
    internal override byte NamespaceId => 81;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override bool IsInVersion(FileFormatVersions version) => version.AtLeast(FileFormatVersions.Office2016);
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the MultiLvlStrData class.
    /// </summary>
    public MultiLvlStrData():base(){}
    
        /// <summary>
    ///Initializes a new instance of the MultiLvlStrData class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public MultiLvlStrData(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the MultiLvlStrData class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public MultiLvlStrData(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the MultiLvlStrData class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public MultiLvlStrData(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "ptCount" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.PointCount();
    
if( 11 == namespaceId && "lvl" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.Level();
    
if( 11 == namespaceId && "extLst" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "ptCount","lvl","extLst" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> PointCount.</para>
    /// <para> Represents the following element tag in the schema: c:ptCount </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.PointCount PointCount
    {
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.PointCount>(0);
        set => SetElement(0, value);
    }


    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<MultiLvlStrData>(deep);

}
}
 
 
