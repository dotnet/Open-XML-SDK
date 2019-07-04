// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
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

[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(81, "multiLvlStrLit")]
public partial class MultiLvlStrData : OpenXmlCompositeElement
{
    
    
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

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.PointCount), 0, 1),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Level), 0, 0),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ExtensionList), 0, 1)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
        /// <summary>
    /// <para> PointCount.</para>
    /// <para> Represents the following element tag in the schema: c:ptCount </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(0)]
    public DocumentFormat.OpenXml.Drawing.Charts.PointCount PointCount
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.PointCount>(0);
        set => SetElement(0, value);
	}


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<MultiLvlStrData>(deep);

}
}
