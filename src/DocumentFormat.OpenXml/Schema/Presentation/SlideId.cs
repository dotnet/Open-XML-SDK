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

public partial class SlideId : OpenXmlCompositeElement
{
    public DocumentFormat.OpenXml.Presentation.ExtensionList<SlideId>? ExtensionListT
    {
        get => GetElement(DocumentFormat.OpenXml.Presentation.ExtensionList<SlideId>.ElementType) as DocumentFormat.OpenXml.Presentation.ExtensionList<SlideId>;
        set => SetElement(value, DocumentFormat.OpenXml.Presentation.ExtensionList<SlideId>.ElementType);
    }
}
