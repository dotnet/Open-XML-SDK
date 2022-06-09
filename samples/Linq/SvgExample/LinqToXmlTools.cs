// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Linq;
using DocumentFormat.OpenXml.Packaging;
using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;

#pragma warning disable SA1116 // Split parameters should start on line after declaration

namespace SvgExample
{
    public static class LinqToXmlTools
    {
        public static void AddSvg(Stream stream, string svgPath, double percentageOfCy)
        {
            using PresentationDocument presentationDocument = PresentationDocument.Open(stream, true);
            PresentationPart presentationPart = presentationDocument.PresentationPart ??
                                                throw new InvalidOperationException(@"PresentationDocument is invalid.");

            // Get relationship ID of first slide.
            string sldRelId = presentationPart.GetXDocument()
                .Elements(P.presentation)
                .Elements(P.sldIdLst)
                .Elements(P.sldId)
                .Select(sldId => (string)sldId.Attribute(R.id)!)
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

            var picture =
                new XElement(P.pic,
                    new XElement(P.nvPicPr,
                        new XElement(P.cNvPr,
                            new XAttribute(NoNamespace.id, ++partsCount),
                            new XAttribute(NoNamespace.name, "Picture 1"),
                            new XElement(A.extLst,
                                new XElement(A.ext,
                                    new XAttribute(NoNamespace.uri, "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}"),
                                    new XElement(A16.creationId,
                                        new XAttribute(XNamespace.Xmlns + "a16", A16.a16),
                                        new XAttribute(NoNamespace.id, GeneralTools.GetNewGuidString()))))),
                        new XElement(P.cNvPicPr,
                            new XElement(A.picLocks,
                                new XAttribute(NoNamespace.noChangeAspect, "1"))),
                        new XElement(P.nvPr)),
                    new XElement(P.blipFill,
                        new XElement(A.blip,
                            new XAttribute(R.embed, pngRelId),
                            new XElement(A.extLst,
                                new XElement(A.ext,
                                    new XAttribute(NoNamespace.uri, "{96DAC541-7B7A-43D3-8B79-37D633B846F1}"),
                                    new XElement(ASVG.svgBlip,
                                        new XAttribute(XNamespace.Xmlns + "asvg", ASVG.asvg),
                                        new XAttribute(R.embed, svgRelId))))),
                        new XElement(A.stretch,
                            new XElement(A.fillRect))),
                    GetSpPr(presentationPart, percentageOfCy));

            XElement spTree = slidePart.GetXDocument()
                .Elements(P.sld)
                .Elements(P.cSld)
                .Elements(P.spTree)
                .Single();

            spTree.Add(picture);

            slidePart.SaveXDocument();
        }

        private static XElement GetSpPr(PresentationPart part, double percentageOfCy)
        {
            XElement sldSz = part.GetXDocument()
                .Elements(P.presentation)
                .Elements(P.sldSz)
                .Single();

            var sldCx = (int)sldSz.Attribute(NoNamespace.cx)!;
            var sldCy = (int)sldSz.Attribute(NoNamespace.cy)!;

            var extentSize = (long)(sldCy * percentageOfCy);
            long offsetX = (sldCx / 2) - (extentSize / 2);
            long offsetY = (sldCy / 2) - (extentSize / 2);

            return new XElement(P.spPr,
                new XElement(A.xfrm,
                    new XElement(A.off,
                        new XAttribute(NoNamespace.x, offsetX),
                        new XAttribute(NoNamespace.y, offsetY)),
                    new XElement(A.ext,
                        new XAttribute(NoNamespace.cx, extentSize),
                        new XAttribute(NoNamespace.cy, extentSize))),
                new XElement(A.prstGeom,
                    new XAttribute(NoNamespace.prst, "rect"),
                    new XElement(A.avLst)));
        }
    }
}
