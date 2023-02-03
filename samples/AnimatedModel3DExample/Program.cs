// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.DrawingML.Y2006.Main;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.PresentationML.Y2006.Main;
using System;
using System.IO;
using System.Linq;

using DML = DocumentFormat.OpenXml.DrawingML.Y2006.Main;
using DML16 = DocumentFormat.OpenXml.Office.Drawing.Y2014.Main;
using DML19 = DocumentFormat.OpenXml.Office.Drawing.Y2018.Animation.Model3D;
using M3D = DocumentFormat.OpenXml.Office.Drawing.Y2017.Model3D;
using PML = DocumentFormat.OpenXml.PresentationML.Y2006.Main;
using PML14 = DocumentFormat.OpenXml.Office.PowerPoint.Y2010.Main;

namespace AnimatedModel3DExample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length < 3)
            {
                Common.ExampleUtilities.ShowHelp(
               new string[]
               {
                    "AnimatedModel3DExample: ",
                    "Usage: AnimatedModel3DExample <OOXML> <png> <glb>",
                    "Where <OOXML> is the file to add the animated model 3d to",
                    "and <png> is the .png file with the image for the Animated Model 3D",
                    "Where <glb> is the .glb file for the animated model 3d",
               });
            }
            else if (Common.ExampleUtilities.CheckIfFilesExist(args))
            {
                InsertAnimatedModel3D(args[0], args[1], args[2]);
            }
        }

        public static void InsertAnimatedModel3D(string pptxPath, string pngPath, string glbPath)
        {
            if (pptxPath == null)
            {
                throw new ArgumentNullException("pptxPath");
            }

            if (pngPath == null)
            {
                throw new ArgumentNullException("pngPath");
            }

            if (glbPath == null)
            {
                throw new ArgumentNullException("glbPath");
            }

            // mc:AternateContent & p:timing
            // Open the presentation document
            using PresentationDocument presentationDocument = PresentationDocument.Open(pptxPath, true);

            // Get the relationship ID of the first slide.
            PresentationPart presentationPart = presentationDocument.PresentationPart;

            // Verify that the presentation part and presentation exist.
            if (presentationPart != null && presentationPart.Presentation != null)
            {
                OpenXmlElementList slideIds = presentationPart.Presentation.SlideIdList.ChildElements;

                if (slideIds.Count > 0)
                {
                    string relId = (slideIds[0] as SlideId).RelationshipId;
                    SlidePart slidePart = (SlidePart)presentationPart.GetPartById(relId);
                    int partsCount = slidePart.Parts.Count();

                    // Add the .png and .glb files for the 3D image
                    using FileStream glbFileStream = new FileStream(glbPath, FileMode.Open, FileAccess.Read);
                    glbFileStream.Seek(0, SeekOrigin.Begin);
                    string glbId = $"rId{++partsCount}";
                    Model3DReferenceRelationshipPart glbImagePart = slidePart.AddNewPart<Model3DReferenceRelationshipPart>(glbId);
                    glbImagePart.FeedData(glbFileStream);

                    using FileStream pngFileStream = new FileStream(pngPath, FileMode.Open, FileAccess.Read);
                    pngFileStream.Seek(0, SeekOrigin.Begin);
                    string pngId = $"rId{++partsCount}";
                    ImagePart pngImagePart = slidePart.AddImagePart(ImagePartType.Png, pngId);
                    pngImagePart.FeedData(pngFileStream);

                    CommonSlideData commonSlideDataPart = slidePart.RootElement.Descendants<CommonSlideData>().FirstOrDefault();

                    // Add an AlternateContent element to the shape tree
                    AlternateContent alternateContent = commonSlideDataPart.ShapeTree.AppendChild(new AlternateContent());

                    // Add mc:Choice element to AlternateContent
                    AlternateContentChoice alternateContentChoice = alternateContent.AppendChild(new AlternateContentChoice());
                    alternateContentChoice.Requires = "am3d";
                    alternateContentChoice.AddNamespaceDeclaration("am3d", "http://schemas.microsoft.com/office/drawing/2017/model3d");

                    // Add mc:Fallback element to AlternateContent
                    AlternateContentFallback alternateContentFallback = alternateContent.AppendChild(new AlternateContentFallback());

                    // Create a creationId with the correct namespace
                    string guidId = "{" + Guid.NewGuid().ToString().ToUpper() + "}";
                    DML16.CreationId creationId = new DML16.CreationId();
                    creationId.AddNamespaceDeclaration("a16", "http://schemas.microsoft.com/office/drawing/2014/main");
                    creationId.Id = guidId;

                    // Clone the creationId
                    DML16.CreationId creationId2 = (DML16.CreationId)creationId.Clone();
                    string creationIdPartenId = guidId;
                    UInt32Value threeDModelId = new UInt32Value(2U);

                    // Create modId in with the correct namespace xmlns:p14="http://schemas.microsoft.com/office/powerpoint/2010/main" val="3636546711"
                    PML14.ModificationId modificationId = new PML14.ModificationId();
                    modificationId.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");
                    modificationId.Val = 3636546711;

                    // Create a aExtension in with the correct attributes
                    DML.Extension aExtension = new DML.Extension();

                    aExtension.SetAttributes(
                        new OpenXmlAttribute[]
                        {
                            new OpenXmlAttribute("cx", string.Empty, "4158691"),
                            new OpenXmlAttribute("cy", string.Empty, "3460830"),
                        });

                    // Create a clone of a:ext for am3d:spPr
                    DML.Extension aExtension2 = (DML.Extension)aExtension.Clone();

                    // Create a a3damin:posterFrame and add the namespace
                    DML19.PosterFrame model3dPosterFrame = new DML19.PosterFrame() { AnimId = 0 };
                    model3dPosterFrame.AddNamespaceDeclaration("a3danim", "http://schemas.microsoft.com/office/drawing/2018/animation/model3d");

                    // Create a clone of a:ext for p:spPr
                    DML.Extension aExtension3 = (DML.Extension)aExtension.Clone();

                    // Create a:off
                    Offset offset = new Offset() { X = 4016654, Y = 1698584 };
                    Offset offset2 = (Offset)offset.Clone();

                    // Create a3danim:embedAnim and assign its namespace
                    DML19.EmbeddedAnimation embeddedAnimation = new DML19.EmbeddedAnimation() { AnimId = 0 };
                    embeddedAnimation.AddNamespaceDeclaration("a3danim", "http://schemas.microsoft.com/office/drawing/2018/animation/model3d");
                    embeddedAnimation.AppendChild(new DML19.AnimationProperties() { Length = "1899", Count = "indefinite" });

                    // Create the mc:AlternateContent element
                    alternateContentChoice.AppendChild(
                        new PML.GraphicFrame(
                            new PML.NonVisualGraphicFrameProperties(
                                new PML.NonVisualDrawingProperties(
                                    new NonVisualDrawingPropertiesExtensionList(
                                        new NonVisualDrawingPropertiesExtension(
                                            creationId)
                                        { Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" }))
                                { Id = threeDModelId, Name = "3D Model 1", Description = "Flying bee" },
                                new PML.NonVisualGraphicFrameDrawingProperties(),
                                new ApplicationNonVisualDrawingProperties(
                                    new ApplicationNonVisualDrawingPropertiesExtensionList(
                                        new ApplicationNonVisualDrawingPropertiesExtension(
                                            modificationId)
                                        { Uri = "{D42A27DB-BD31-4B8C-83A1-F6EECF244321}" }))),
                            new Transform(
                                offset,
                                aExtension),
                            new Graphic(
                                new GraphicData(
                                    new M3D.Model3D(
                                        new M3D.ShapeProperties(
                                            new Transform2D(
                                                new Offset() { X = 0, Y = 0 },
                                                aExtension2),
                                            new PresetGeometry(
                                                new AdjustValueList())
                                            { Preset = ShapeTypeValues.Rectangle }),
                                        new M3D.Model3DCamera(
                                            new M3D.PosPoint3D() { X = 0, Y = 0, Z = 67740115 },
                                            new M3D.UpVector3D() { Dx = 0, Dy = 36000000, Dz = 0 },
                                            new M3D.LookAtPoint3D() { X = 0, Y = 0, Z = 0 },
                                            new M3D.PerspectiveProjection() { Fov = 2700000 }),
                                        new M3D.Model3DTransform(
                                            new M3D.MeterPerModelUnitPositiveRatio() { N = 30569, D = 1000000 },
                                            new M3D.PreTransVector3D() { Dx = -98394, Dy = -14223043, Dz = -1124542 },
                                            new M3D.Scale3D(
                                                new M3D.SxRatio() { Numerator = 1000000, Denominator = 1000000 },
                                                new M3D.SyRatio() { Numerator = 1000000, Denominator = 1000000 },
                                                new M3D.SzRatio() { Numerator = 1000000, Denominator = 1000000 }),
                                            new M3D.Rotate3D(),
                                            new M3D.PostTransVector3D() { Dx = 0, Dy = 0, Dz = 0 }),
                                        new M3D.Model3DRaster(
                                            new M3D.Blip() { Embed = pngId })
                                        { RName = "Office3DRenderer", RVer = "16.0.8326" },
                                        new M3D.Model3DExtensionList(
                                            new DML.Extension(
                                                embeddedAnimation)
                                            { Uri = "{9A65AA19-BECB-4387-8358-8AD5134E1D82}" },
                                            new DML.Extension(
                                                model3dPosterFrame)
                                            { Uri = "{E9DE012E-A134-456F-84FE-255F9AAD75C6}" }),
                                        new M3D.ObjectViewport() { ViewportSz = 5418666 },
                                        new M3D.AmbientLight(
                                            new M3D.ColorType(
                                                new RgbColorModelPercentage() { RedPortion = 50000, GreenPortion = 50000, BluePortion = 50000 }),
                                            new M3D.IlluminancePositiveRatio() { N = 500000, D = 1000000 }),
                                        new M3D.PointLight(
                                            new M3D.ColorType(
                                                new RgbColorModelPercentage() { RedPortion = 100000, GreenPortion = 75000, BluePortion = 50000 }),
                                            new M3D.IntensityPositiveRatio() { N = 9765625, D = 1000000 },
                                            new M3D.PosPoint3D() { X = 21959998, Y = 70920001, Z = 16344003 })
                                        { Rad = 0 },
                                        new M3D.PointLight(
                                            new M3D.ColorType(
                                                new RgbColorModelPercentage() { RedPortion = 40000, GreenPortion = 60000, BluePortion = 95000 }),
                                            new M3D.IntensityPositiveRatio() { N = 12250000, D = 1000000 },
                                            new M3D.PosPoint3D() { X = -37964106, Y = 51130435, Z = 57631972 })
                                        { Rad = 0 },
                                        new M3D.PointLight(
                                            new M3D.ColorType(
                                                new RgbColorModelPercentage() { RedPortion = 86837, GreenPortion = 72700, BluePortion = 100000 }),
                                            new M3D.IntensityPositiveRatio() { N = 3125000, D = 1000000 },
                                            new M3D.PosPoint3D() { X = -37739122, Y = 58056624, Z = -34769649 })
                                        { Rad = 0 })
                                    { Embed = glbId })
                                { Uri = "http://schemas.microsoft.com/office/drawing/2017/model3d" })));

                    // Add children to mc:Fallback
                    alternateContentFallback.AppendChild(
                        new PML.Picture(
                           new PML.NonVisualPictureProperties(
                               new PML.NonVisualDrawingProperties(
                                    new NonVisualDrawingPropertiesExtensionList(
                                        new NonVisualDrawingPropertiesExtension(
                                            creationId2)
                                        { Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" }))
                               { Id = threeDModelId, Name = "3D Model 1", Description = "Flying bee" },
                               new PML.NonVisualPictureDrawingProperties(
                                    new PictureLocks() { NoGrouping = true, NoRotation = true, NoChangeAspect = true, NoMove = true, NoResize = true, NoEditPoints = true, NoAdjustHandles = true, NoChangeArrowheads = true, NoChangeShapeType = true, NoCrop = true }),
                               new ApplicationNonVisualDrawingProperties()),
                           new PML.BlipFill(
                                new Blip() { Embed = pngId },
                                new Stretch(
                                    new FillRectangle())),
                           new PML.ShapeProperties(
                                new Transform2D(
                                    offset2,
                                    aExtension3),
                                new PresetGeometry(
                                    new AdjustValueList())
                                { Preset = ShapeTypeValues.Rectangle })));

                    // PML.AttributeName attributeName = new PML.AttributeName();
                    // attributeName.InnerXml = "embedded1";

                    // Append the p:timing to the p:sld
                    slidePart.RootElement.AppendChild(
                        new Timing(
                            new TimeNodeList(
                                new ParallelTimeNode(
                                    new CommonTimeNode(
                                        new ChildTimeNodeList(
                                            new SequenceTimeNode(
                                                new CommonTimeNode(
                                                    new ChildTimeNodeList(
                                                        new ParallelTimeNode(
                                                            new CommonTimeNode(
                                                                new StartConditionList(
                                                                    new Condition() { Delay = "indefinite" },
                                                                    new Condition(
                                                                        new TimeNode() { Val = 2 })
                                                                    { Event = TriggerEventValues.OnBegin, Delay = "0" }),
                                                                new ChildTimeNodeList(
                                                                    new ParallelTimeNode(
                                                                        new CommonTimeNode(
                                                                            new StartConditionList(
                                                                                    new Condition() { Delay = "0" }),
                                                                            new ChildTimeNodeList(
                                                                                new ParallelTimeNode(
                                                                                    new CommonTimeNode(
                                                                                        new StartConditionList(
                                                                                            new Condition() { Delay = "0" }),
                                                                                        new ChildTimeNodeList(
                                                                                            new Animate(
                                                                                                new CommonBehavior(
                                                                                                    new CommonTimeNode() { Id = 6, Duration = "1900", Fill = TimeNodeFillValues.Hold },
                                                                                                    new TargetElement(
                                                                                                        new ShapeTarget() { ShapeId = "2" }),
                                                                                                    new AttributeNameList(
                                                                                                        new AttributeName("embedded1"))),
                                                                                                new TimeAnimateValueList(
                                                                                                    new TimeAnimateValue(
                                                                                                        new VariantValue(
                                                                                                            new FloatVariantValue() { Val = SingleValue.FromSingle(0) }))
                                                                                                    { Time = "0" },
                                                                                                    new TimeAnimateValue(
                                                                                                        new VariantValue(
                                                                                                            new FloatVariantValue() { Val = SingleValue.FromSingle(1) }))
                                                                                                    { Time = "100000" }))
                                                                                            { CalculationMode = AnimateBehaviorCalculateModeValues.Linear, ValueType = AnimateBehaviorValues.Number }))
                                                                                    { Id = 5, PresetId = 100, PresetClass = TimeNodePresetClassValues.Emphasis, PresetSubtype = 1, RepeatCount = "indefinite", Fill = TimeNodeFillValues.Hold, NodeType = TimeNodeValues.WithEffect })))
                                                                        { Id = 4, Fill = TimeNodeFillValues.Hold })))
                                                            { Id = 3, Fill = TimeNodeFillValues.Hold })))
                                                { Id = 2, Duration = "indefinite", NodeType = TimeNodeValues.MainSequence },
                                                new PreviousConditionList(
                                                    new Condition(
                                                        new TargetElement(
                                                            new SlideTarget()))
                                                    { Event = TriggerEventValues.OnPrevious, Delay = "0" }),
                                                new NextConditionList(
                                                    new Condition(
                                                        new TargetElement(
                                                            new SlideTarget()))
                                                    { Event = TriggerEventValues.OnNext, Delay = "0" }))
                                            { Concurrent = true, NextAction = NextActionValues.Seek }))
                                    { Id = 1, Duration = "indefinite", Restart = TimeNodeRestartValues.Never, NodeType = TimeNodeValues.TmingRoot }))));
                }
            }
        }
    }
}
