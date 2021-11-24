// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Office2021.DocumentTasks;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace doctaskssample
{
    internal class Program
    {
        private class User
        {
            private string _userId;
            private string _userName;
            private string _directoryProvider;
            private string _mention;
            private string _email;

            public User(string userId, string userName, string directoryProvider, string mention, string email)
            {
                UserId = userId;
                UserName = userName;
                DirectoryProvider = directoryProvider;
                Mention = mention;
                Email = email;
            }

            public string UserId { get => _userId; set => _userId = value; }

            public string UserName { get => _userName; set => _userName = value; }

            public string DirectoryProvider { get => _directoryProvider; set => _directoryProvider = value; }

            public string Mention { get => _mention; set => _mention = value; }

            public string Email { get => _email; set => _email = value; }
        }

        private static void Main(string[] args)
        {
            // Must have one or two arguments.
            if (args.Length < 0)
            {
                ShowHelp();
                return;
            }

            if (!File.Exists(args[0]))
            {
                Console.WriteLine("File {0} does not exist.", args[0]);
                ShowHelp();
                return;
            }

            Console.WriteLine("Processing presentation: {0}", args[0]);

            using (WordprocessingDocument docPackage = WordprocessingDocument.Open(args[0], true))
            {
                StringBuilder newFn = new StringBuilder(args[0]);
                newFn.Replace(".docx", "_new.docx");

                WordprocessingDocument newDocumentPackage = (WordprocessingDocument)docPackage.SaveAs(newFn.ToString());
                MainDocumentPart mdp = newDocumentPackage.MainDocumentPart;

                string strCommentId = "3";
                string comment = " Here's another sentence that is just too long. Shorten it please.";
                string run = "The introduction to this article.";

                // userids, providers and names will have to be programmatically accessed via directory services and must be valid. These are just for example
                User tony = new("S::john.doe@contoso.com::3063813b-f01d-4030-9808-501a178e7963", "John Doe", "AD", "@John Doe", "john.doe@contoso.com");
                User bruce = new("S::jane.doe@contoso.com::ec6240b1-52a3-46dd-9697-ef7bcc7a29e8", "Jane Doe", "AD", "@Jane Doe", "jane.doe@contoso.com");

                RandomParagraphIdGenerator pIdGener = new RandomParagraphIdGenerator(newDocumentPackage);
                AddNewParagraphRunWithComment(mdp, strCommentId, run, pIdGener);

                AddMentionComment(mdp, strCommentId, bruce.Mention, comment, tony, bruce, pIdGener);

                StringBuilder taskStr = new StringBuilder(bruce.Mention + " " + comment);
                AddNewTask(mdp, taskStr.ToString(), bruce, tony, pIdGener);

                newDocumentPackage.Save();
                newDocumentPackage.Close();
                docPackage.Close();
            }
        }

        private static void ShowHelp()
        {
            Console.WriteLine("doctaskssample: ");
            Console.WriteLine("Usage: doctaskssample <filename>");
            Console.WriteLine("Where: <filename> is the file in which to add a document task.");
            Console.WriteLine();
            return;
        }

        private static void AddNewTask(MainDocumentPart mdp, string title, User assignee, User assigner, RandomParagraphIdGenerator pIdGener)
        {
            // TODO: userids, providers and names will have to be programmatically accessed via directory services.
            // These are just examples to show what is expected.
            DocumentTasksPart taskPart = mdp.DocumentTasksPart;
            Tasks taskRoot = taskPart.Tasks;
            string guidEventId = Guid.NewGuid().ToString();
            string guidTaskId = Guid.NewGuid().ToString();

            taskRoot.AppendChild<Task>(
                new Task(
                    new TaskAnchor(
                        new CommentAnchor() { Id = "546836446" }),
                    new TaskHistory(
                        new TaskHistoryEvent(
                            new AttributionTaskUser()
                            { UserId = assigner.UserId, UserProvider = assigner.DirectoryProvider, UserName = assigner.UserName },
                            new TaskAnchor(
                                new CommentAnchor()
                                { Id = "546836446" }),
                            new TaskCreateEventInfo())
                        { Id = guidEventId, Time = DateTime.Now },
                        new TaskHistoryEvent(
                            new AttributionTaskUser()
                            { UserId = assigner.UserId, UserProvider = assigner.DirectoryProvider, UserName = assigner.UserName },
                            new TaskAnchor(
                                new CommentAnchor()
                                { Id = "546836446" }),
                            new AssignTaskUser()
                            { UserId = assignee.UserId, UserProvider = assignee.DirectoryProvider, UserName = assignee.UserName })
                        { Id = guidEventId, Time = DateTime.Now },
                        new TaskHistoryEvent(
                            new AttributionTaskUser() { UserId = assigner.UserId, UserProvider = assigner.DirectoryProvider, UserName = assigner.UserName },
                            new TaskAnchor(
                                new CommentAnchor() { Id = "546836446" }),
                            new TaskTitleEventInfo() { Title = title })
                        { Id = guidEventId, Time = DateTime.Now }))
                { Id = guidTaskId });
        }

        private static void AddNewParagraphRunWithComment(MainDocumentPart mdp, string strCommentId, string strParagraphText, RandomParagraphIdGenerator pIdGener)
        {
            mdp.Document.Body.AppendChild<Paragraph>(
                new Paragraph(

                // This id MUST be unique in the comments part.
                new CommentRangeStart() { Id = strCommentId },
                new Run(
                    new Text(strParagraphText)),
                new CommentRangeEnd() { Id = strCommentId },
                new Run(new CommentReference() { Id = strCommentId }))

                // These ids MUST be unique in the document.
                { ParagraphId = pIdGener.CreateUniqueParagraphId(), TextId = "FFFFFF02" });
        }

        private static void AddMentionComment(MainDocumentPart mdp, string strCommentId, string mention, string commentText, User mentioner, User mentionee, RandomParagraphIdGenerator pIdGener)
        {
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
                    { ParagraphId = pIdGener.CreateUniqueParagraphId(), TextId = "FFFFFF04" })

                // This id MUST be unique in the comments part.
                { Id = strCommentId, Author = mentioner.UserName, Date = DateTime.Now, Initials = mentioner.UserName.Substring(0, 1) + mentioner.UserName.Substring(mentioner.UserName.IndexOf(" ") + 1, 1) });
        }
    }
}
