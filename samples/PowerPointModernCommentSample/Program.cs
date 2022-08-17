// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Common;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Office2016.Presentation.Command;
using DocumentFormat.OpenXml.Office2021.PowerPoint.Comment;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Presentation;
using System;
using System.IO;
using System.Linq;

using Comment = DocumentFormat.OpenXml.Office2021.PowerPoint.Comment.Comment;
using CommentList = DocumentFormat.OpenXml.Office2021.PowerPoint.Comment.CommentList;
using Text = DocumentFormat.OpenXml.Drawing.Text;

namespace PowerPointModernCommentSample
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                if (args.Length == 0)
                {
                    Console.WriteLine("Usage: PowerPointModernCommentSample.exe <filepath>");
                    return;
                }

                FileInfo fileInfo = new FileInfo(args[0]);

                if (fileInfo.Exists)
                {
                    fileInfo.Delete();
                }

                // Create a presentation
                PresentationDocument presentationDocument = PowerPointUtils.CreatePresentation(fileInfo.FullName);

                // create missing PowerPointAuthorsPart if it is null
                if (presentationDocument?.PresentationPart?.authorsPart is null)
                {
                    presentationDocument?.PresentationPart.AddNewPart<PowerPointAuthorsPart>();
                }

                // Add missing AuthorList if it is null
                if (presentationDocument?.PresentationPart?.authorsPart?.AuthorList is null)
                {
                    presentationDocument.PresentationPart.authorsPart.AuthorList = new AuthorList();
                }

                // In production you will need to retrieve actual user information
                string authorId = string.Concat("{", Guid.NewGuid(), "}");
                presentationDocument.PresentationPart.authorsPart.AuthorList.AddChild(new Author()
                { Id = authorId, Name = "Jose Contoso", Initials = "JC", UserId = "jose@contosot.com::9ed1aa81-8d9b-4a15-b989-8cbbfd4c4b3e", ProviderId = "AD" });

                // Get the Id of the slide to add the comment to
                SlideId slideId = presentationDocument.PresentationPart.Presentation.SlideIdList.Elements<SlideId>().First();

                Random ran = new Random();
                UInt32Value cid = Convert.ToUInt32(ran.Next(100000000, 999999999));

                // Add a comment to the slide
                PowerPointCommentPart powerPointCommentPart = presentationDocument.PresentationPart.SlideParts.First().AddNewPart<PowerPointCommentPart>();

                powerPointCommentPart.CommentList = new CommentList(
                    new Comment(
                        new SlideMonikerList(
                            new DocumentMoniker(),
                            new SlideMoniker()
                            {
                                CId = cid,
                                SldId = slideId.Id,
                            }),
                        new TextBodyType(
                            new BodyProperties(),
                            new ListStyle(),
                            new Paragraph(new Run(new Text("Hello World!")))))
                    {
                        Id = string.Concat("{", Guid.NewGuid(), "}"),
                        AuthorId = authorId,
                        Created = DateTime.Now,
                    });

                SlidePart slidePart = presentationDocument.PresentationPart.SlideParts.First();
                Slide slide = slidePart.Slide;

                slide.AppendChild(
                    new PresentationExtensionList(
                        new PresentationExtension(
                            new CommentRelationship()
                            { Id = slidePart.GetIdOfPart(powerPointCommentPart) })
                        { Uri = "{6950BFC3-D8DA-4A85-94F7-54DA5524770B}" }));

                presentationDocument.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
