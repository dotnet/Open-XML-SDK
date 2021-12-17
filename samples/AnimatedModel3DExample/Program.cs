// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Presentation;
using System;
using System.IO;
using System.Linq;

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
                    string guidId = "{" + System.Guid.NewGuid().ToString().ToUpper() + "}";
                    DocumentFormat.OpenXml.Office2016.Drawing.CreationId creationId = new DocumentFormat.OpenXml.Office2016.Drawing.CreationId();
                    creationId.AddNamespaceDeclaration("a16", "http://schemas.microsoft.com/office/drawing/2014/main");
                    creationId.Id = guidId;

                    // Clone the creationId
                    DocumentFormat.OpenXml.Office2016.Drawing.CreationId creationId2 = (DocumentFormat.OpenXml.Office2016.Drawing.CreationId)creationId.Clone();
                    string creationIdPartenId = guidId;
                    UInt32Value threeDModelId = new UInt32Value(2U);

                    // Create modId in with the correct namespace xmlns:p14="http://schemas.microsoft.com/office/powerpoint/2010/main" val="3636546711"
                    DocumentFormat.OpenXml.Office2010.PowerPoint.ModificationId modificationId = new DocumentFormat.OpenXml.Office2010.PowerPoint.ModificationId();
                    modificationId.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");
                    modificationId.Val = 3636546711;

                    // Create a aExtension in with the correct attributes
                    DocumentFormat.OpenXml.Drawing.Extension aExtension = new DocumentFormat.OpenXml.Drawing.Extension();

                    aExtension.SetAttributes(
                        new OpenXmlAttribute[]
                        {
                            new OpenXmlAttribute("cx", string.Empty, "4158691"),
                            new OpenXmlAttribute("cy", string.Empty, "3460830"),
                        });

                    // Create a clone of a:ext for am3d:spPr
                    DocumentFormat.OpenXml.Drawing.Extension aExtension2 = (DocumentFormat.OpenXml.Drawing.Extension)aExtension.Clone();

                    // Create a a3damin:posterFrame and add the namespace
                    DocumentFormat.OpenXml.Office2019.Drawing.Animation.Model3D.PosterFrame model3dPosterFrame = new DocumentFormat.OpenXml.Office2019.Drawing.Animation.Model3D.PosterFrame() { AnimId = 0 };
                    model3dPosterFrame.AddNamespaceDeclaration("a3danim", "http://schemas.microsoft.com/office/drawing/2018/animation/model3d");

                    // Create a clone of a:ext for p:spPr
                    DocumentFormat.OpenXml.Drawing.Extension aExtension3 = (DocumentFormat.OpenXml.Drawing.Extension)aExtension.Clone();

                    // Create a:off
                    DocumentFormat.OpenXml.Drawing.Offset offset = new DocumentFormat.OpenXml.Drawing.Offset() { X = 4016654, Y = 1698584 };
                    DocumentFormat.OpenXml.Drawing.Offset offset2 = (DocumentFormat.OpenXml.Drawing.Offset)offset.Clone();

                    // Create a3danim:embedAnim and assign its namespace
                    DocumentFormat.OpenXml.Office2019.Drawing.Animation.Model3D.EmbeddedAnimation embeddedAnimation = new DocumentFormat.OpenXml.Office2019.Drawing.Animation.Model3D.EmbeddedAnimation() { AnimId = 0 };
                    embeddedAnimation.AddNamespaceDeclaration("a3danim", "http://schemas.microsoft.com/office/drawing/2018/animation/model3d");
                    embeddedAnimation.AppendChild(new DocumentFormat.OpenXml.Office2019.Drawing.Animation.Model3D.AnimationProperties() { Length = "1899", Count = "indefinite" });

                    // Create the mc:AlternateContent element
                    alternateContentChoice.AppendChild(
                        new GraphicFrame(
                            new NonVisualGraphicFrameProperties(
                                new NonVisualDrawingProperties(
                                    new DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList(
                                        new DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtension(
                                            creationId)
                                        { Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" }))
                                { Id = threeDModelId, Name = "3D Model 1", Description = "Flying bee" },
                                new NonVisualGraphicFrameDrawingProperties(),
                                new ApplicationNonVisualDrawingProperties(
                                    new ApplicationNonVisualDrawingPropertiesExtensionList(
                                        new ApplicationNonVisualDrawingPropertiesExtension(
                                            modificationId)
                                        { Uri = "{D42A27DB-BD31-4B8C-83A1-F6EECF244321}" }))),
                            new Transform(
                                offset,
                                aExtension),
                            new DocumentFormat.OpenXml.Drawing.Graphic(
                                new DocumentFormat.OpenXml.Drawing.GraphicData(
                                    new DocumentFormat.OpenXml.Office2019.Drawing.Model3D.Model3D(
                                        new DocumentFormat.OpenXml.Office2019.Drawing.Model3D.ShapeProperties(
                                            new DocumentFormat.OpenXml.Drawing.Transform2D(
                                                new DocumentFormat.OpenXml.Drawing.Offset() { X = 0, Y = 0 },
                                                aExtension2),
                                            new DocumentFormat.OpenXml.Drawing.PresetGeometry(
                                                new DocumentFormat.OpenXml.Drawing.AdjustValueList())
                                            { Preset = DocumentFormat.OpenXml.Drawing.ShapeTypeValues.Rectangle }),
                                        new DocumentFormat.OpenXml.Office2019.Drawing.Model3D.Model3DCamera(
                                            new DocumentFormat.OpenXml.Office2019.Drawing.Model3D.PosPoint3D() { X = 0, Y = 0, Z = 67740115 },
                                            new DocumentFormat.OpenXml.Office2019.Drawing.Model3D.UpVector3D() { Dx = 0, Dy = 36000000, Dz = 0 },
                                            new DocumentFormat.OpenXml.Office2019.Drawing.Model3D.LookAtPoint3D() { X = 0, Y = 0, Z = 0 },
                                            new DocumentFormat.OpenXml.Office2019.Drawing.Model3D.PerspectiveProjection() { Fov = 2700000 }),
                                        new DocumentFormat.OpenXml.Office2019.Drawing.Model3D.Model3DTransform(
                                            new DocumentFormat.OpenXml.Office2019.Drawing.Model3D.MeterPerModelUnitPositiveRatio() { N = 30569, D = 1000000 },
                                            new DocumentFormat.OpenXml.Office2019.Drawing.Model3D.PreTransVector3D() { Dx = -98394, Dy = -14223043, Dz = -1124542 },
                                            new DocumentFormat.OpenXml.Office2019.Drawing.Model3D.Scale3D(
                                                new DocumentFormat.OpenXml.Office2019.Drawing.Model3D.SxRatio() { Numerator = 1000000, Denominator = 1000000 },
                                                new DocumentFormat.OpenXml.Office2019.Drawing.Model3D.SyRatio() { Numerator = 1000000, Denominator = 1000000 },
                                                new DocumentFormat.OpenXml.Office2019.Drawing.Model3D.SzRatio() { Numerator = 1000000, Denominator = 1000000 }),
                                            new DocumentFormat.OpenXml.Office2019.Drawing.Model3D.Rotate3D(),
                                            new DocumentFormat.OpenXml.Office2019.Drawing.Model3D.PostTransVector3D() { Dx = 0, Dy = 0, Dz = 0 }),
                                        new DocumentFormat.OpenXml.Office2019.Drawing.Model3D.Model3DRaster(
                                            new DocumentFormat.OpenXml.Office2019.Drawing.Model3D.Blip() { Embed = pngId })
                                        { RName = "Office3DRenderer", RVer = "16.0.8326" },
                                        new DocumentFormat.OpenXml.Office2019.Drawing.Model3D.Model3DExtensionList(
                                            new DocumentFormat.OpenXml.Drawing.Extension(
                                                embeddedAnimation)
                                            { Uri = "{9A65AA19-BECB-4387-8358-8AD5134E1D82}" },
                                            new DocumentFormat.OpenXml.Drawing.Extension(
                                                model3dPosterFrame)
                                            { Uri = "{E9DE012E-A134-456F-84FE-255F9AAD75C6}" }),
                                        new DocumentFormat.OpenXml.Office2019.Drawing.Model3D.ObjectViewport() { ViewportSz = 5418666 },
                                        new DocumentFormat.OpenXml.Office2019.Drawing.Model3D.AmbientLight(
                                            new DocumentFormat.OpenXml.Office2019.Drawing.Model3D.ColorType(
                                                new DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage() { RedPortion = 50000, GreenPortion = 50000, BluePortion = 50000 }),
                                            new DocumentFormat.OpenXml.Office2019.Drawing.Model3D.IlluminancePositiveRatio() { N = 500000, D = 1000000 }),
                                        new DocumentFormat.OpenXml.Office2019.Drawing.Model3D.PointLight(
                                            new DocumentFormat.OpenXml.Office2019.Drawing.Model3D.ColorType(
                                                new DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage() { RedPortion = 100000, GreenPortion = 75000, BluePortion = 50000 }),
                                            new DocumentFormat.OpenXml.Office2019.Drawing.Model3D.IntensityPositiveRatio() { N = 9765625, D = 1000000 },
                                            new DocumentFormat.OpenXml.Office2019.Drawing.Model3D.PosPoint3D() { X = 21959998, Y = 70920001, Z = 16344003 })
                                        { Rad = 0 },
                                        new DocumentFormat.OpenXml.Office2019.Drawing.Model3D.PointLight(
                                            new DocumentFormat.OpenXml.Office2019.Drawing.Model3D.ColorType(
                                                new DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage() { RedPortion = 40000, GreenPortion = 60000, BluePortion = 95000 }),
                                            new DocumentFormat.OpenXml.Office2019.Drawing.Model3D.IntensityPositiveRatio() { N = 12250000, D = 1000000 },
                                            new DocumentFormat.OpenXml.Office2019.Drawing.Model3D.PosPoint3D() { X = -37964106, Y = 51130435, Z = 57631972 })
                                        { Rad = 0 },
                                        new DocumentFormat.OpenXml.Office2019.Drawing.Model3D.PointLight(
                                            new DocumentFormat.OpenXml.Office2019.Drawing.Model3D.ColorType(
                                                new DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage() { RedPortion = 86837, GreenPortion = 72700, BluePortion = 100000 }),
                                            new DocumentFormat.OpenXml.Office2019.Drawing.Model3D.IntensityPositiveRatio() { N = 3125000, D = 1000000 },
                                            new DocumentFormat.OpenXml.Office2019.Drawing.Model3D.PosPoint3D() { X = -37739122, Y = 58056624, Z = -34769649 })
                                        { Rad = 0 })
                                    { Embed = glbId })
                                { Uri = "http://schemas.microsoft.com/office/drawing/2017/model3d" })));

                    // Add children to mc:Fallback
                    alternateContentFallback.AppendChild(
                        new DocumentFormat.OpenXml.Presentation.Picture(
                           new NonVisualPictureProperties(
                               new NonVisualDrawingProperties(
                                    new DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList(
                                        new DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtension(
                                            creationId2)
                                        { Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" }))
                               { Id = threeDModelId, Name = "3D Model 1", Description = "Flying bee" },
                               new DocumentFormat.OpenXml.Presentation.NonVisualPictureDrawingProperties(
                                    new DocumentFormat.OpenXml.Drawing.PictureLocks() { NoGrouping = true, NoRotation = true, NoChangeAspect = true, NoMove = true, NoResize = true, NoEditPoints = true, NoAdjustHandles = true, NoChangeArrowheads = true, NoChangeShapeType = true, NoCrop = true }),
                               new DocumentFormat.OpenXml.Presentation.ApplicationNonVisualDrawingProperties()),
                           new DocumentFormat.OpenXml.Presentation.BlipFill(
                                new DocumentFormat.OpenXml.Drawing.Blip() { Embed = pngId },
                                new DocumentFormat.OpenXml.Drawing.Stretch(
                                    new DocumentFormat.OpenXml.Drawing.FillRectangle())),
                           new DocumentFormat.OpenXml.Presentation.ShapeProperties(
                                new DocumentFormat.OpenXml.Drawing.Transform2D(
                                    offset2,
                                    aExtension3),
                                new DocumentFormat.OpenXml.Drawing.PresetGeometry(
                                    new DocumentFormat.OpenXml.Drawing.AdjustValueList())
                                { Preset = DocumentFormat.OpenXml.Drawing.ShapeTypeValues.Rectangle })));

                    // DocumentFormat.OpenXml.Presentation.AttributeName attributeName = new DocumentFormat.OpenXml.Presentation.AttributeName();
                    // attributeName.InnerXml = "embedded1";

                    // Append the p:timing to the p:sld
                    slidePart.RootElement.AppendChild(
                        new DocumentFormat.OpenXml.Presentation.Timing(
                            new DocumentFormat.OpenXml.Presentation.TimeNodeList(
                                new DocumentFormat.OpenXml.Presentation.ParallelTimeNode(
                                    new DocumentFormat.OpenXml.Presentation.CommonTimeNode(
                                        new DocumentFormat.OpenXml.Presentation.ChildTimeNodeList(
                                            new DocumentFormat.OpenXml.Presentation.SequenceTimeNode(
                                                new DocumentFormat.OpenXml.Presentation.CommonTimeNode(
                                                    new DocumentFormat.OpenXml.Presentation.ChildTimeNodeList(
                                                        new DocumentFormat.OpenXml.Presentation.ParallelTimeNode(
                                                            new DocumentFormat.OpenXml.Presentation.CommonTimeNode(
                                                                new DocumentFormat.OpenXml.Presentation.StartConditionList(
                                                                    new DocumentFormat.OpenXml.Presentation.Condition() { Delay = "indefinite" },
                                                                    new DocumentFormat.OpenXml.Presentation.Condition(
                                                                        new DocumentFormat.OpenXml.Presentation.TimeNode() { Val = 2 })
                                                                    { Event = DocumentFormat.OpenXml.Presentation.TriggerEventValues.OnBegin, Delay = "0" }),
                                                                new DocumentFormat.OpenXml.Presentation.ChildTimeNodeList(
                                                                    new DocumentFormat.OpenXml.Presentation.ParallelTimeNode(
                                                                        new DocumentFormat.OpenXml.Presentation.CommonTimeNode(
                                                                            new DocumentFormat.OpenXml.Presentation.StartConditionList(
                                                                                    new DocumentFormat.OpenXml.Presentation.Condition() { Delay = "0" }),
                                                                            new DocumentFormat.OpenXml.Presentation.ChildTimeNodeList(
                                                                                new DocumentFormat.OpenXml.Presentation.ParallelTimeNode(
                                                                                    new DocumentFormat.OpenXml.Presentation.CommonTimeNode(
                                                                                        new DocumentFormat.OpenXml.Presentation.StartConditionList(
                                                                                            new DocumentFormat.OpenXml.Presentation.Condition() { Delay = "0" }),
                                                                                        new DocumentFormat.OpenXml.Presentation.ChildTimeNodeList(
                                                                                            new DocumentFormat.OpenXml.Presentation.Animate(
                                                                                                new DocumentFormat.OpenXml.Presentation.CommonBehavior(
                                                                                                    new DocumentFormat.OpenXml.Presentation.CommonTimeNode() { Id = 6, Duration = "1900", Fill = DocumentFormat.OpenXml.Presentation.TimeNodeFillValues.Hold },
                                                                                                    new DocumentFormat.OpenXml.Presentation.TargetElement(
                                                                                                        new DocumentFormat.OpenXml.Presentation.ShapeTarget() { ShapeId = "2" }),
                                                                                                    new DocumentFormat.OpenXml.Presentation.AttributeNameList(
                                                                                                        new DocumentFormat.OpenXml.Presentation.AttributeName("embedded1"))),
                                                                                                new DocumentFormat.OpenXml.Presentation.TimeAnimateValueList(
                                                                                                    new DocumentFormat.OpenXml.Presentation.TimeAnimateValue(
                                                                                                        new DocumentFormat.OpenXml.Presentation.VariantValue(
                                                                                                            new DocumentFormat.OpenXml.Presentation.FloatVariantValue() { Val = DocumentFormat.OpenXml.SingleValue.FromSingle(0) }))
                                                                                                    { Time = "0" },
                                                                                                    new DocumentFormat.OpenXml.Presentation.TimeAnimateValue(
                                                                                                        new DocumentFormat.OpenXml.Presentation.VariantValue(
                                                                                                            new DocumentFormat.OpenXml.Presentation.FloatVariantValue() { Val = DocumentFormat.OpenXml.SingleValue.FromSingle(1) }))
                                                                                                    { Time = "100000" }))
                                                                                            { CalculationMode = DocumentFormat.OpenXml.Presentation.AnimateBehaviorCalculateModeValues.Linear, ValueType = DocumentFormat.OpenXml.Presentation.AnimateBehaviorValues.Number }))
                                                                                    { Id = 5, PresetId = 100, PresetClass = DocumentFormat.OpenXml.Presentation.TimeNodePresetClassValues.Emphasis, PresetSubtype = 1, RepeatCount = "indefinite", Fill = DocumentFormat.OpenXml.Presentation.TimeNodeFillValues.Hold, NodeType = DocumentFormat.OpenXml.Presentation.TimeNodeValues.WithEffect })))
                                                                        { Id = 4, Fill = DocumentFormat.OpenXml.Presentation.TimeNodeFillValues.Hold })))
                                                            { Id = 3, Fill = DocumentFormat.OpenXml.Presentation.TimeNodeFillValues.Hold })))
                                                { Id = 2, Duration = "indefinite", NodeType = DocumentFormat.OpenXml.Presentation.TimeNodeValues.MainSequence },
                                                new DocumentFormat.OpenXml.Presentation.PreviousConditionList(
                                                    new DocumentFormat.OpenXml.Presentation.Condition(
                                                        new DocumentFormat.OpenXml.Presentation.TargetElement(
                                                            new DocumentFormat.OpenXml.Presentation.SlideTarget()))
                                                    { Event = DocumentFormat.OpenXml.Presentation.TriggerEventValues.OnPrevious, Delay = "0" }),
                                                new DocumentFormat.OpenXml.Presentation.NextConditionList(
                                                    new DocumentFormat.OpenXml.Presentation.Condition(
                                                        new DocumentFormat.OpenXml.Presentation.TargetElement(
                                                            new DocumentFormat.OpenXml.Presentation.SlideTarget()))
                                                    { Event = DocumentFormat.OpenXml.Presentation.TriggerEventValues.OnNext, Delay = "0" }))
                                            { Concurrent = true, NextAction = DocumentFormat.OpenXml.Presentation.NextActionValues.Seek }))
                                    { Id = 1, Duration = "indefinite", Restart = DocumentFormat.OpenXml.Presentation.TimeNodeRestartValues.Never, NodeType = DocumentFormat.OpenXml.Presentation.TimeNodeValues.TmingRoot }))));
                }
            }
        }
    }
}
