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
using DocumentFormat.OpenXml.Office2010.Drawing;

namespace DocumentFormat.OpenXml.Office2010.Drawing.Slicer
{
/// <summary>
/// <para>Defines the Slicer Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is sle:slicer.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>OfficeArtExtensionList &lt;sle:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(OfficeArtExtensionList), FileFormatVersions.Office2010)]

[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(62, "slicer")]
public partial class Slicer : OpenXmlCompositeElement
{
    
        /// <summary>
    /// <para> name, this property is only available in Office2010, Office2013, Office2016.</para>
    /// <para>Represents the following attribute in the schema: name </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "name")]
    [Index(0)]
    public StringValue Name { get; set; }

    /// <summary>
    /// Initializes a new instance of the Slicer class.
    /// </summary>
    public Slicer():base(){}
        /// <summary>
    ///Initializes a new instance of the Slicer class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Slicer(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the Slicer class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Slicer(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the Slicer class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Slicer(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.Slicer.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2010)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
        /// <summary>
    /// <para> OfficeArtExtensionList.</para>
    /// <para> Represents the following element tag in the schema: sle:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:sle = http://schemas.microsoft.com/office/drawing/2010/slicer
    /// </remark>
	[Index(0)]
    public OfficeArtExtensionList OfficeArtExtensionList
	{
        get => GetElement<OfficeArtExtensionList>(0);
        set => SetElement(0, value);
	}


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Slicer>(deep);

}
/// <summary>
/// <para>Defines the OfficeArtExtensionList Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is sle:extLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Extension &lt;a:ext></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Extension))]

[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(62, "extLst")]
public partial class OfficeArtExtensionList : OpenXmlCompositeElement
{
    
    
    /// <summary>
    /// Initializes a new instance of the OfficeArtExtensionList class.
    /// </summary>
    public OfficeArtExtensionList():base(){}
        /// <summary>
    ///Initializes a new instance of the OfficeArtExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public OfficeArtExtensionList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the OfficeArtExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public OfficeArtExtensionList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the OfficeArtExtensionList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public OfficeArtExtensionList(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new CompositeParticle(ParticleType.Group, 1, 1)
    {
        new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Extension), 0, 0)
        }
    }
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<OfficeArtExtensionList>(deep);

}
}
