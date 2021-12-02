using System.IO;
using System.Drawing;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Office2019.Drawing.SVG;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;

using BlipFill = DocumentFormat.OpenXml.Drawing.BlipFill;
using Extension = DocumentFormat.OpenXml.Drawing.Extension;
using Picture = DocumentFormat.OpenXml.Drawing.Picture;
using System.CodeDom.Compiler;
using System.Text;
using Svg;
using System.Drawing.Imaging;
using Common;

namespace SVGExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Utilities.ShowHelp(new string[] { "SVGExample: ", "Usage: SVGExample <filename> <svg>", "Where: <filename> is the path to the file in which to add the svg.", "Where: <svg> is the path to the svg file to add." });
            }
            else if (Utilities.CheckIfFilesExist(args))
            {
                AddSvg(args[0], args[1]);
            }
        }

        public static void AddSvg(string docPath, string svgPath)
        {
            using (PresentationDocument presentationDocument = PresentationDocument.Open(docPath, true))
            {
                // Verify that the presentation document exists.
                if (presentationDocument == null)
                {
                    throw new ArgumentNullException("presentationDocument");
                }

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

                        // Get count of relationships and increment by one to make next unique id
                        int partsCount = slidePart.Parts.Count();
                        string pngId = $"rId{++partsCount}";
                        string svgId = $"rId{++partsCount}";

                        //var picture = slidePart.Slide.CommonSlideData.ShapeTree.ChildElements.First<DocumentFormat.OpenXml.Presentation.Picture>();
                        var creationId = new DocumentFormat.OpenXml.Office2016.Drawing.CreationId();
                        creationId.AddNamespaceDeclaration("a16", "http://schemas.microsoft.com/office/drawing/2014/main");
                        creationId.Id = "{E36DC281-2F17-44E3-80EA-AB5BFA90E4D7}";


                        var picture = new DocumentFormat.OpenXml.Presentation.Picture();
                        // add non visual properties to picture
                        picture.NonVisualPictureProperties = new DocumentFormat.OpenXml.Presentation.NonVisualPictureProperties();
                        picture.NonVisualPictureProperties.NonVisualDrawingProperties = new DocumentFormat.OpenXml.Presentation.NonVisualDrawingProperties() { Id = new UInt32Value((uint)++partsCount), Name = "Picture 1" };
                        picture.NonVisualPictureProperties.NonVisualDrawingProperties.AppendChild(new DocumentFormat.OpenXml.Drawing.ExtensionList(
                                    new Extension(
                                        creationId
                                    )
                                    { Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" }
                                )
                            );
                        picture.NonVisualPictureProperties.NonVisualPictureDrawingProperties = new DocumentFormat.OpenXml.Presentation.NonVisualPictureDrawingProperties();
                        picture.NonVisualPictureProperties.ApplicationNonVisualDrawingProperties = new ApplicationNonVisualDrawingProperties();
                        picture.NonVisualPictureProperties.NonVisualPictureDrawingProperties.PictureLocks = new PictureLocks() { NoChangeAspect = true };
                        // add blipfill
                        picture.BlipFill = new DocumentFormat.OpenXml.Presentation.BlipFill();
                        picture.BlipFill.Blip = new Blip() { Embed = svgId };
                        picture.BlipFill.AppendChild(new Stretch(
                                new FillRectangle()
                            )
                        );
                        BlipExtensionList blipExtensionList = new BlipExtensionList();
                        Extension ext = blipExtensionList.AppendChild(new Extension());
                        ext.Uri = "";
                        ext.AppendChild(new SVGBlip());
                        picture.BlipFill.Blip.AppendChild(blipExtensionList);
                        picture.ShapeProperties = new DocumentFormat.OpenXml.Presentation.ShapeProperties();
                        picture.ShapeProperties.Transform2D = new Transform2D();
                        picture.ShapeProperties.Transform2D.Offset = new Offset();
                        picture.ShapeProperties.Transform2D.Offset.X = new Int64Value((long)5638800);
                        picture.ShapeProperties.Transform2D.Offset.Y = new Int64Value((long)2971800);
                        picture.ShapeProperties.Transform2D.Extents = new Extents();
                        picture.ShapeProperties.Transform2D.Extents.Cx = new Int64Value((long)914400);
                        picture.ShapeProperties.Transform2D.Extents.Cy = new Int64Value((long)914400);
                        picture.ShapeProperties.AppendChild(new PresetGeometry(
                            new AdjustValueList()
                        )
                        { Preset = ShapeTypeValues.Rectangle });

                        // Create a temporary in memory png file from the svg (inserting svg requires a png copy to be visible)
                        // Using https://www.nuget.org/packages/Svg/ to convert svg to png
                        SvgDocument svgDocument = SvgDocument.Open(svgPath);
                        using System.Drawing.Bitmap bitmap = svgDocument.Draw();
                        string fileName = System.IO.Path.GetTempPath() + Guid.NewGuid().ToString() + ".png";
                        bitmap.Save(fileName, ImageFormat.Png);

                        // Add png to slidePart
                        using FileStream pngFileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                        pngFileStream.Seek(0, SeekOrigin.Begin);
                        ImagePart pngImagePart = slidePart.AddImagePart(ImagePartType.Png, pngId);
                        pngImagePart.FeedData(pngFileStream);
                        picture.BlipFill.Blip.Embed = pngId;

                        // Add image part with new svg id
                        using FileStream svgFileStream = new FileStream(svgPath, FileMode.Open, FileAccess.Read);
                        svgFileStream.Seek(0, SeekOrigin.Begin);
                        ImagePart svgImgPart = slidePart.AddImagePart(ImagePartType.Svg, svgId);
                        svgImgPart.FeedData(svgFileStream);
                        IEnumerable<SVGBlip> sVGBlips = blipExtensionList.Descendants<SVGBlip>();
                        sVGBlips.First().Embed = svgId;
                        slidePart.Slide.CommonSlideData.ShapeTree.AppendChild(picture);

                        slidePart.Slide.Save();
                    }
                }
            }
        }
    }
}
