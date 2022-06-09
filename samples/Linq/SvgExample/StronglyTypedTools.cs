// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Office2016.Drawing;
using DocumentFormat.OpenXml.Office2019.Drawing.SVG;
using DocumentFormat.OpenXml.Packaging;
using System;
using System.IO;
using System.Linq;

using Drawing = DocumentFormat.OpenXml.Drawing;
using Presentation = DocumentFormat.OpenXml.Presentation;

namespace SvgExample
{
    public static class StronglyTypedTools
    {
        public static void AddSvg(Stream stream, string svgPath, double percentageOfCy)
        {
            using PresentationDocument presentationDocument = PresentationDocument.Open(stream, true);
            PresentationPart presentationPart = presentationDocument.PresentationPart ??
                                                throw new InvalidOperationException(@"PresentationDocument is invalid.");

            // Get relationship ID of first slide.
            string sldRelId = presentationPart
                .Presentation
                .SlideIdList?
                .Elements<Presentation.SlideId>()
                .Select(slideId => (string)slideId.RelationshipId!)
                .FirstOrDefault() ?? throw new InvalidOperationException(@"Presentation has no slides.");

            // Get first slide's part.
            var slidePart = (SlidePart)presentationPart.GetPartById(sldRelId);

            // Determine unique relationship IDs for new image parts.
            int partsCount = slidePart.Parts.Count();
            string pngRelId = $"rId{++partsCount}";
            string svgRelId = $"rId{++partsCount}";

            // Add new image part with PNG image to slide part.
            using Stream pngStream = GeneralTools.ReadSvgAsPng(svgPath);
            GeneralTools.AddImagePart(slidePart, ImagePartType.Png, pngRelId, pngStream);

            // Add new image part with SVG image to slide part.
            using Stream svgStream = File.Open(svgPath, FileMode.Open, FileAccess.Read);
            GeneralTools.AddImagePart(slidePart, ImagePartType.Svg, svgRelId, svgStream);

            // Create markup.
            var picture =
                new Presentation.Picture(
                    new Presentation.NonVisualPictureProperties(
                        new Presentation.NonVisualDrawingProperties(
                            new Drawing.NonVisualDrawingPropertiesExtensionList(
                                new Drawing.Extension(
                                    new CreationId
                                    {
                                        Id = GeneralTools.GetNewGuidString(),
                                    }.WithNamespaceDeclaration("a16", "http://schemas.microsoft.com/office/drawing/2014/main"))
                                {
                                    Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}",
                                }))
                        {
                            Id = (uint)++partsCount,
                            Name = "Picture 1",
                        },
                        new Presentation.NonVisualPictureDrawingProperties(
                            new Drawing.PictureLocks
                            {
                                NoChangeAspect = true,
                            }),
                        new Presentation.ApplicationNonVisualDrawingProperties()),
                    new Presentation.BlipFill(
                        new Drawing.Blip(
                            new Drawing.BlipExtensionList(
                                new Drawing.Extension(
                                    new SVGBlip
                                    {
                                        Embed = svgRelId,
                                    })
                                {
                                    Uri = "{96DAC541-7B7A-43D3-8B79-37D633B846F1}",
                                }))
                        {
                            Embed = pngRelId,
                        },
                        new Drawing.Stretch(
                            new Drawing.FillRectangle())),
                    GetShapeProperties(presentationPart, percentageOfCy));

            Presentation.ShapeTree shapeTree = slidePart
                .Slide
                .CommonSlideData?
                .ShapeTree ?? throw new InvalidOperationException();

            shapeTree.AppendChild(picture);
        }

        public static TOpenXmlElement WithNamespaceDeclaration<TOpenXmlElement>(
            this TOpenXmlElement element,
            string prefix,
            string uri)
            where TOpenXmlElement : OpenXmlElement
        {
            element.AddNamespaceDeclaration(prefix, uri);
            return element;
        }

        private static Presentation.ShapeProperties GetShapeProperties(PresentationPart part, double percentageOfCy)
        {
            Presentation.SlideSize slideSize = part.Presentation.SlideSize!;
            var slideCx = (int)slideSize.Cx!;
            var slideCy = (int)slideSize.Cy!;

            var extentSize = (long)(slideCy * percentageOfCy);
            long offsetX = (slideCx / 2) - (extentSize / 2);
            long offsetY = (slideCy / 2) - (extentSize / 2);

            return new Presentation.ShapeProperties(
                new Drawing.Transform2D(
                    new Drawing.Offset
                    {
                        X = offsetX,
                        Y = offsetY,
                    },
                    new Drawing.Extents
                    {
                        Cx = extentSize,
                        Cy = extentSize,
                    }),
                new Drawing.PresetGeometry(
                    new Drawing.AdjustValueList())
                {
                    Preset = Drawing.ShapeTypeValues.Rectangle,
                });
        }
    }
}
