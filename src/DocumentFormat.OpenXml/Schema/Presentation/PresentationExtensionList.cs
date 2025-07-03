using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Office.PowerPoint.Y2022.M03.Main;
using DocumentFormat.OpenXml.Office.PowerPoint.Y2022.M08.Main;
using DocumentFormat.OpenXml.Office.PowerPoint.Y2023.M02.Main;
using DocumentFormat.OpenXml.Office2010.Drawing;
using DocumentFormat.OpenXml.Office2010.PowerPoint;
using DocumentFormat.OpenXml.Office2013.PowerPoint;
using DocumentFormat.OpenXml.Office2021.PowerPoint.Comment;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using DocumentFormat.OpenXml.Validation.Semantic;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Presentation;

public class ExtensionList<T> : OpenXmlCompositeElement
{
#pragma warning disable CS0109
    internal static readonly new OpenXmlQualifiedName ElementQName = new("http://schemas.openxmlformats.org/presentationml/2006/main", "extLst");
    internal static readonly new OpenXmlQualifiedName ElementTypeName = new("http://schemas.openxmlformats.org/presentationml/2006/main", "CT_ExtensionList");
    internal static readonly new OpenXmlSchemaType ElementType = new(ElementQName, ElementTypeName);
#pragma warning restore CS0109

    /// <summary>
    /// Initializes a new instance of the ExtensionList class.
    /// </summary>
    public ExtensionList()
        : base()
    {
  
    }

    /// <summary>
    /// Initializes a new instance of the ExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
    public ExtensionList(string outerXml) : base(outerXml)
    {
    }

    internal override void ConfigureMetadata(ElementMetadata.Builder builder)
    {
        base.ConfigureMetadata(builder);
        builder.SetSchema(ElementType);
        builder.AddChild(DocumentFormat.OpenXml.Presentation.Extension.ElementType, static () => new DocumentFormat.OpenXml.Presentation.Extension());
        builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
                    {
                        new ElementParticle(DocumentFormat.OpenXml.Presentation.Extension.ElementType, 0, 0)
                    }
                }
            };
    }

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ExtensionList>(deep);
}

