//using DocumentFormat.OpenXml;
//using DocumentFormat.OpenXml.Drawing;
//using DocumentFormat.OpenXml.Framework;
//using DocumentFormat.OpenXml.Framework.Metadata;
//using DocumentFormat.OpenXml.Office.PowerPoint.Y2022.M03.Main;
//using DocumentFormat.OpenXml.Office.PowerPoint.Y2022.M08.Main;
//using DocumentFormat.OpenXml.Office.PowerPoint.Y2023.M02.Main;
//using DocumentFormat.OpenXml.Office2010.Drawing;
//using DocumentFormat.OpenXml.Office2010.PowerPoint;
//using DocumentFormat.OpenXml.Office2013.PowerPoint;
//using DocumentFormat.OpenXml.Office2021.PowerPoint.Comment;
//using DocumentFormat.OpenXml.Packaging;
//using DocumentFormat.OpenXml.Validation.Schema;
//using DocumentFormat.OpenXml.Validation.Semantic;
//using System;
//using System.Collections.Generic;
//using System.IO.Packaging;

//namespace DocumentFormat.OpenXml.Presentation;

//public partial class Extension<T> : OpenXmlCompositeElement
//{
//#pragma warning disable CS0109
//    internal static readonly new OpenXmlQualifiedName ElementQName = new("http://schemas.openxmlformats.org/presentationml/2006/main", "ext");
//    internal static readonly new OpenXmlQualifiedName ElementTypeName = new("http://schemas.openxmlformats.org/presentationml/2006/main", "CT_Extension");
//    internal static readonly new OpenXmlSchemaType ElementType = new(ElementQName, ElementTypeName);
//#pragma warning restore CS0109

//    /// <summary>
//    /// Initializes a new instance of the Extension class.
//    /// </summary>
//    public Extension() : base()
//    {
//    }

//    /// <summary>
//    /// Initializes a new instance of the Extension class with the specified child elements.
//    /// </summary>
//    /// <param name="childElements">Specifies the child elements.</param>
//    public Extension(IEnumerable<OpenXmlElement> childElements) : base(childElements)
//    {
//    }

//    /// <summary>
//    /// Initializes a new instance of the Extension class with the specified child elements.
//    /// </summary>
//    /// <param name="childElements">Specifies the child elements.</param>
//    public Extension(params OpenXmlElement[] childElements) : base(childElements)
//    {
//    }

//    /// <summary>
//    /// Initializes a new instance of the Extension class from outer XML.
//    /// </summary>
//    /// <param name="outerXml">Specifies the outer XML of the element.</param>
//    public Extension(string outerXml) : base(outerXml)
//    {
//    }

//    /// <summary>
//    /// <para>URI</para>
//    /// <para>Represents the following attribute in the schema: uri</para>
//    /// </summary>
//    public StringValue? Uri
//    {
//        get => GetAttribute<StringValue>();
//        set => SetAttribute(value);
//    }

//    internal override void ConfigureMetadata(ElementMetadata.Builder builder)
//    {
//        base.ConfigureMetadata(builder);
//        builder.SetSchema(ElementType);
//        builder.AddElement<Extension>()
//            .AddAttribute("uri", a => a.Uri, aBuilder =>
//            {
//                aBuilder.AddValidator(RequiredValidator.Instance);
//                aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
//            });
//        builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
//            {
//                new AnyParticle(1, 1)
//            };
//    }

//    /// <inheritdoc/>
//    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Extension>(deep);
//}