// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Office2021.DocumentTasks;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DocumentTaskSample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Common.ExampleUtilities.ShowHelp(
                new string[]
                {
                    "DocumentTaskSample: ",
                    "Usage: DocumentTaskSample <filename>",
                    "Where: <filename> is the file in which to add a document task.",
                    string.Empty,
                });
            }
            else if (Common.ExampleUtilities.CheckIfFilesExist(args))
            {
                AddDocumentTask(args[0]);
            }
        }

        private static void AddDocumentTask(string filePath)
        {
            Console.WriteLine("Processing presentation: {0}", filePath);

            using WordprocessingDocument docPackage = WordprocessingDocument.Open(filePath, true);
            string newFn = filePath.Replace(".docx", "_new.docx");

            using WordprocessingDocument newDocumentPackage = (WordprocessingDocument)docPackage.SaveAs(newFn.ToString());
            newDocumentPackage.AddParagraphIdFeature();
            MainDocumentPart mdp = newDocumentPackage.MainDocumentPart;

            string strCommentId = "3";
            string comment = " Here's another sentence that is just too long. Shorten it please.";
            string run = "The introduction to this article.";

            // userids, providers and names will have to be programmatically accessed via directory services and must be valid. These are just for example
            User tony = new("S::john.doe@contoso.com::3063813b-f01d-4030-9808-501a178e7963", "John Doe", "AD", "@John Doe", "john.doe@contoso.com");
            User bruce = new("S::jane.doe@contoso.com::ec6240b1-52a3-46dd-9697-ef7bcc7a29e8", "Jane Doe", "AD", "@Jane Doe", "jane.doe@contoso.com");

            AddNewParagraphRunWithComment(mdp, strCommentId, run);

            AddMentionComment(mdp, strCommentId, bruce.Mention, comment, tony, bruce);

            string taskStr = string.Concat(bruce.Mention, " ", comment);
            AddNewTask(mdp, taskStr, bruce, tony);
        }

        private static void AddNewTask(MainDocumentPart mdp, string title, User assignee, User assigner)
        {
            mdp.AddNewPart<DocumentTasksPart>();

            DocumentTasksPart taskPart = mdp.DocumentTasksPart;
            taskPart.Tasks = new Tasks();
            Tasks taskRoot = taskPart.Tasks;
            string guidEventId = Guid.NewGuid().ToString();
            string guidTaskId = Guid.NewGuid().ToString();
            string commonAnchorId = "546836446";

            taskRoot.AppendChild<Task>(
                new Task(
                    new TaskAnchor(
                        new CommentAnchor() { Id = commonAnchorId }),
                    new TaskHistory(
                        new TaskHistoryEvent(
                            new AttributionTaskUser()
                            { UserId = assigner.UserId, UserProvider = assigner.DirectoryProvider, UserName = assigner.UserName },
                            new TaskAnchor(
                                new CommentAnchor()
                                { Id = commonAnchorId }),
                            new TaskCreateEventInfo())
                        { Id = guidEventId, Time = DateTime.Now },
                        new TaskHistoryEvent(
                            new AttributionTaskUser()
                            { UserId = assigner.UserId, UserProvider = assigner.DirectoryProvider, UserName = assigner.UserName },
                            new TaskAnchor(
                                new CommentAnchor()
                                { Id = commonAnchorId }),
                            new AssignTaskUser()
                            { UserId = assignee.UserId, UserProvider = assignee.DirectoryProvider, UserName = assignee.UserName })
                        { Id = guidEventId, Time = DateTime.Now },
                        new TaskHistoryEvent(
                            new AttributionTaskUser() { UserId = assigner.UserId, UserProvider = assigner.DirectoryProvider, UserName = assigner.UserName },
                            new TaskAnchor(
                                new CommentAnchor() { Id = commonAnchorId }),
                            new TaskTitleEventInfo() { Title = title })
                        { Id = guidEventId, Time = DateTime.Now }))
                { Id = guidTaskId });
        }

        private static void AddNewParagraphRunWithComment(MainDocumentPart mdp, string strCommentId, string strParagraphText) => mdp.Document.Body.AppendChild<Paragraph>(
                new Paragraph(
                new CommentRangeStart() { Id = strCommentId }, // This id MUST be unique in the comments part.
                new Run(
                    new Text(strParagraphText)),
                new CommentRangeEnd() { Id = strCommentId },
                new Run(new CommentReference() { Id = strCommentId })));

        private static void AddMentionComment(MainDocumentPart mdp, string strCommentId, string mention, string commentText, User mentioner, User mentionee)
        {
            mdp.AddNewPart<WordprocessingCommentsPart>();
            mdp.WordprocessingCommentsPart.Comments = new Comments();
            Comments comments = mdp.WordprocessingCommentsPart.Comments;

            comments.AppendChild<Comment>(
                new Comment(
                    new Paragraph(
                        new Run(
                            new RunProperties(
                                new Color() { Val = "2B579A" },
                                new Shading() { Val = ShadingPatternValues.Clear, Color = "auto", Fill = "E6E6E6" }),
                            new FieldChar() { FieldCharType = FieldCharValues.Begin }),
                        new Run(
                            new FieldCode(" HYPERLINK \"mailto:" + mentionee.Email + "\"")
                            { Space = SpaceProcessingModeValues.Preserve }),
                        new BookmarkStart() { Id = "2", Name = "_@_0FD9AD1E39C946AB9F9E1352162C9910Z" },
                        new Run(
                            new RunProperties(
                                new Color() { Val = "2B579A" },
                                new Shading() { Val = ShadingPatternValues.Clear, Color = "auto", Fill = "E6E6E6" }),
                            new FieldChar() { FieldCharType = FieldCharValues.Separate }),
                        new BookmarkEnd() { Id = "2" },
                        new Run(
                            new RunProperties(
                                new RunStyle() { Val = "Mention" },
                                new NoProof()),
                            new Text(mention)),
                        new Run(
                            new RunProperties(
                                new Color() { Val = "2B579A" },
                                new Shading() { Val = ShadingPatternValues.Clear, Color = "auto", Fill = "E6E6E6" }),
                            new FieldChar()
                            { FieldCharType = FieldCharValues.End }),
                        new Run(
                            new Text(commentText) { Space = SpaceProcessingModeValues.Preserve }),
                        new Run(
                            new AnnotationReferenceMark()))

                    // These ids MUST be unique in the document.
                    { TextId = "FFFFFF04" })

                // This id MUST be unique in the comments part.
                { Id = strCommentId, Author = mentioner.UserName, Date = DateTime.Now, Initials = mentioner.UserName.Substring(0, 1) + mentioner.UserName.Substring(mentioner.UserName.IndexOf(" ") + 1, 1) });
        }
    }
}
