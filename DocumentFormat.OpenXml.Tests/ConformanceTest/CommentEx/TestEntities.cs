// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentFormat.OpenXml.Tests.CommentEx
{
    using DocumentFormat.OpenXml;
    using DocumentFormat.OpenXml.Packaging;
    using DocumentFormat.OpenXml.Wordprocessing;
    using W15 = DocumentFormat.OpenXml.Office2013.Word;
    using LogUtil;

    public class TestEntities
    {
        /// <summary>
        /// Edit Comment and CommentEx
        /// </summary>
        /// <param name="filePath">Editing target file path</param>
        /// <param name="log">Logger</param>
        public void EditElements(string filePath, VerifiableLog log)
        {
            using (WordprocessingDocument package = WordprocessingDocument.Open(filePath, true))
            {
                WordprocessingCommentsPart commentPart = package.MainDocumentPart.WordprocessingCommentsPart;
                WordprocessingCommentsExPart commentExPart = package.MainDocumentPart.WordprocessingCommentsExPart;
                Comment comment = null;
                W15.CommentEx commentEx = null;

                //2.1 Change comment text
                comment = GetComment(commentPart, CommentIDs.CommentID1);
                Text text = comment.Descendants<Text>().First();
                text.Text = CommentStrings.CommentChangeString1;

                log.Pass("Edited comment text. comment ID=[{0}]. comment text=[{1}].", CommentIDs.CommentID1, CommentStrings.CommentChangeString1);

                //2.2 Change commnet initials attribute
                comment = GetComment(commentPart, CommentIDs.CommentID1);

                comment.Initials = CommentInitials.Initial2;
                log.Pass("Edited comment attribute of Initials. comment ID=[{0}]. Initials=[{1}].", CommentIDs.CommentID1, CommentInitials.Initial2);

                //2.2 Change commnet date attribute
                comment.Date = new DateTimeValue(new DateTime(2015, 12, 24, 12, 34, 56, 77));
                log.Pass("Edited comment attribute of Date. comment ID=[{0}]. Date=[{1}/{2}/{3}-{4}:{5}:{6}-{7}].", CommentIDs.CommentID1, 12, 24, 2015, 12, 34, 56, 77);

                //2.2 Change commnet author attribute
                comment.Author = CommentAuthors.Author2;
                log.Pass("Edited comment attribute of Author. comment ID=[{0}]. Author=[{1}].", CommentIDs.CommentID1, CommentAuthors.Author2);

                //2.3 Change comment parent-child relationship, Case of parent attribute deleteing.
                commentEx = GetCommentEx(commentPart, commentExPart, CommentIDs.CommentID2);
                commentEx.ParaIdParent = null;
                log.Pass("Edited CommentEx parent-child relationship, Set CommentEx parent id is null. comment ID=[{0}]. CommentEx.ParaIdParent=[null].", CommentIDs.CommentID2);

                //2.3 Change comment parent-child relationship, Case of parent attribute appending.
                commentEx = GetCommentEx(commentPart, commentExPart, CommentIDs.CommentID3);
                W15.CommentEx comEx = GetCommentEx(commentPart, commentExPart, CommentIDs.CommentID2);
                commentEx.ParaIdParent = comEx.ParaId;
                log.Pass("Edited CommentEx parent-child relationship, Set CommentEx parent id is comment(id=1) have id. comment ID=[{0}]. CommentEx.ParaIdParent=[{1}].", CommentIDs.CommentID3, comEx.ParaId.Value);

                //2.4 Change CommnetEx done attribute, Case of value "1" setting. 
                GetCommentEx(commentPart, commentExPart, CommentIDs.CommentID1).Done = true;
                log.Pass("Edited CommentEx attribute of Done. comment ID=[{0}]. Done=[true].", CommentIDs.CommentID1);

                //2.4 Change CommnetEx done attribute, Case of value "0" setting. 
                GetCommentEx(commentPart, commentExPart, CommentIDs.CommentID3).Done = false;
                log.Pass("Edited CommentEx attribute of Done. comment ID=[{0}]. Done=[false].", CommentIDs.CommentID3);

                //2.5 Add comment and CommentEx.
                CommentRangeStart commentRangeStart1 = new CommentRangeStart();
                commentRangeStart1.Id = CommentIDs.CommentID4;
                CommentRangeEnd CommentRangeEnd1 = new CommentRangeEnd();
                CommentRangeEnd1.Id = CommentIDs.CommentID4;

                Paragraph paragraph1 = package.MainDocumentPart.Document.Descendants<Paragraph>().Where(e => e.InnerText == CommentBodyStrings.Comment2).First();
                paragraph1.Descendants<Run>().Where(e => e.InnerText == CommentBodyStrings.Comment2).First().InsertBeforeSelf<CommentRangeStart>(commentRangeStart1);
                paragraph1.Descendants<Run>().Where(e => e.InnerText == CommentBodyStrings.Comment2).First().InsertAfterSelf<CommentRangeEnd>(CommentRangeEnd1);

                CommentReference commentReference1 = new CommentReference();
                commentReference1.Id = CommentIDs.CommentID4;
                Run run1 = new Run();
                run1.AppendChild<CommentReference>(commentReference1);

                paragraph1.AppendChild<Run>(run1);
                Comment comment1 = (Comment)GetComment(commentPart, CommentIDs.CommentID1).Clone();
                comment1.Id = CommentIDs.CommentID4;
                comment1.Descendants<Text>().First().Text = CommentStrings.CommentAppendString1;
                comment1.Descendants<Paragraph>().First().ParagraphId = AppendCommentExIDs.AppendCommentID1;

                commentPart.Comments.AppendChild<Comment>(comment1);

                W15.CommentEx commentEx1 = new W15.CommentEx();
                commentEx1.ParaId = AppendCommentExIDs.AppendCommentID1;
                commentExPart.CommentsEx.AppendChild<W15.CommentEx>(commentEx1);

                log.Pass("Append new comment. comment ID=[{0}]. comment text=[{1}]. CommentEx.ParaIdParent=[null].", CommentIDs.CommentID4, CommentStrings.CommentAppendString1);

                //2.5 Add comment and CommentEx.
                CommentRangeStart commentRangeStart2 = new CommentRangeStart();
                commentRangeStart2.Id = CommentIDs.CommentID5;
                CommentRangeEnd CommentRangeEnd2 = new CommentRangeEnd();
                CommentRangeEnd2.Id = CommentIDs.CommentID5;

                Paragraph paragraph2 = package.MainDocumentPart.Document.Descendants<Paragraph>().Where(e => e.InnerText == CommentBodyStrings.Comment2).First();
                paragraph2.Descendants<Run>().Where(e => e.InnerText == CommentBodyStrings.Comment2).First().InsertBeforeSelf<CommentRangeStart>(commentRangeStart2);
                paragraph2.Descendants<Run>().Where(e => e.InnerText == CommentBodyStrings.Comment2).First().InsertAfterSelf<CommentRangeEnd>(CommentRangeEnd2);

                CommentReference commentReference2 = new CommentReference();
                commentReference2.Id = CommentIDs.CommentID5;
                Run run2 = new Run();
                run2.AppendChild<CommentReference>(commentReference2);

                paragraph2.AppendChild<Run>(run2);
                Comment comment2 = (Comment)GetComment(commentPart, CommentIDs.CommentID2).Clone();
                comment2.Id = CommentIDs.CommentID5;
                comment2.Descendants<Text>().First().Text = CommentStrings.CommentAppendString2;
                comment2.Descendants<Paragraph>().First().ParagraphId = AppendCommentExIDs.AppendCommentID2;

                commentPart.Comments.AppendChild<Comment>(comment2);

                W15.CommentEx commentEx2 = new W15.CommentEx();
                commentEx2.ParaId = AppendCommentExIDs.AppendCommentID2;
                commentEx2.ParaIdParent = AppendCommentExIDs.AppendCommentID1;
                commentExPart.CommentsEx.AppendChild<W15.CommentEx>(commentEx2);

                log.Pass("Append new comment. comment ID=[{0}]. comment text=[{1}]. CommentEx.ParaIdParent=[{2}].", CommentIDs.CommentID5, CommentStrings.CommentAppendString2, AppendCommentExIDs.AppendCommentID1);
            }
        }

        /// <summary>
        /// Verify Comment and CommentEx
        /// </summary>
        /// <param name="filePath">Verifying target file path</param>
        /// <param name="log">Logger</param>
        public void VerifyElements(string filePath, VerifiableLog log)
        {
            using (WordprocessingDocument package = WordprocessingDocument.Open(filePath, false))
            {
                WordprocessingCommentsPart commentPart = package.MainDocumentPart.WordprocessingCommentsPart;
                WordprocessingCommentsExPart commentExPart = package.MainDocumentPart.WordprocessingCommentsExPart;
                Comment comment = null;
                W15.CommentEx commentEx = null;

                //2.1 Verifying comment text
                comment = GetComment(commentPart, CommentIDs.CommentID1);
                Text text = comment.Descendants<Text>().First();
                log.Verify(text.Text == CommentStrings.CommentChangeString1, "Verify comment text.");

                //2.2 Verifying commnet initials attribute
                comment = GetComment(commentPart, CommentIDs.CommentID1);
                log.Verify(comment.Initials == CommentInitials.Initial2, "Verify comment attribute of initials.");

                //2.2 Verifying commnet date attribute
                log.Verify(comment.Date.Value.Year == 2015
                    && comment.Date.Value.Month == 12
                    && comment.Date.Value.Day == 24
                    && comment.Date.Value.Hour == 12
                    && comment.Date.Value.Minute == 34
                    && comment.Date.Value.Second == 56
                    && comment.Date.Value.Millisecond == 77, "Verify comment attribute of date.");

                //2.2 Verifying commnet author attribute
                log.Verify(comment.Author == CommentAuthors.Author2, "Verify comment attribute of author.");

                //2.3 Verifying comment parent-child relationship, Case of parent attribute deleteing.
                commentEx = GetCommentEx(commentPart, commentExPart, CommentIDs.CommentID2);
                log.Verify(commentEx.ParaIdParent == null, "Verify parent-child relationship. Parent is null.");

                //2.3 Verifying comment parent-child relationship, Case of parent attribute appending.
                commentEx = GetCommentEx(commentPart, commentExPart, CommentIDs.CommentID3);
                W15.CommentEx comEx = GetCommentEx(commentPart, commentExPart, CommentIDs.CommentID2);
                log.Verify(commentEx.ParaIdParent.Value == GetCommentEx(commentPart, commentExPart, CommentIDs.CommentID2).ParaId.Value, "Verify parent-child relationship. This ID is [{0}]. Parent ID is [{0}].", commentEx.ParaId, commentEx.ParaIdParent);

                //2.4 Verifying CommnetEx done attribute, Case of value "1" setting. 
                log.Verify(GetCommentEx(commentPart, commentExPart, CommentIDs.CommentID1).Done == true, "Verify CommentEx attribute of done.");

                //2.4 Verifying CommnetEx done attribute, Case of value "0" setting. 
                log.Verify(GetCommentEx(commentPart, commentExPart, CommentIDs.CommentID3).Done == false, "Verify CommentEx attribute of done.");

                //2.5 Verifying comment and CommentEx append.
                log.Verify(GetComment(commentPart, CommentIDs.CommentID4) != null
                    && GetCommentEx(commentPart, commentExPart, CommentIDs.CommentID4) != null, "Verify Comment and CommentEx append.");

                //2.5 Verifying comment and CommentEx append.
                log.Verify(GetComment(commentPart, CommentIDs.CommentID5) != null
                    && GetCommentEx(commentPart, commentExPart, CommentIDs.CommentID5) != null
                    && GetCommentEx(commentPart, commentExPart, CommentIDs.CommentID5).ParaIdParent.Value == GetCommentEx(commentPart, commentExPart, CommentIDs.CommentID4).ParaId.Value,
                    "Verify Comment and CommentEx append, And CommentEx parent-child relationship");
            }
        }

        /// <summary>
        /// Delete Comment and CommentEx
        /// </summary>
        /// <param name="filePath">Deleting target file path</param>
        /// <param name="log">Logger</param>
        public void DeleteElements(string filePath, VerifiableLog log)
        {
            using (WordprocessingDocument package = WordprocessingDocument.Open(filePath, true))
            {
                foreach (CommentRangeStart commentRangeStart in package.MainDocumentPart.Document.Descendants<CommentRangeStart>().Reverse())
                {
                    commentRangeStart.Remove();
                }

                log.Pass("Deleted CommentRangeStart element.");

                foreach (CommentRangeEnd commentRangeEnd in package.MainDocumentPart.Document.Descendants<CommentRangeEnd>().Reverse())
                {
                    commentRangeEnd.Remove();
                }

                log.Pass("Deleted CommentRangeEnd element.");

                foreach (CommentReference commentReference in package.MainDocumentPart.Document.Descendants<CommentReference>().Reverse())
                {
                    commentReference.Ancestors<Run>().First().Remove();
                }

                log.Pass("Deleted CommentReference element.");

                package.MainDocumentPart.DeletePart(package.MainDocumentPart.WordprocessingCommentsPart);

                log.Pass("Deleted WordprocessingCommentsPart.");

                package.MainDocumentPart.DeletePart(package.MainDocumentPart.WordprocessingCommentsExPart);

                log.Pass("Deleted WordprocessingCommentsExPart.");
            }
        }

        /// <summary>
        /// Verify Comment and CommentEx is deleted
        /// </summary>
        /// <param name="filePath">Verifying target file path</param>
        /// <param name="log">Logger</param>
        public void VerifyDeletedElements(string filePath, VerifiableLog log)
        {
            using (WordprocessingDocument package = WordprocessingDocument.Open(filePath, false))
            {
                log.Verify(package.MainDocumentPart.WordprocessingCommentsPart == null, "Verify WordprocessingCommentsPart is deleted.");

                log.Verify(package.MainDocumentPart.WordprocessingCommentsExPart == null, "Verify WordprocessingCommentsExPart is deleted.");

                log.Verify(package.MainDocumentPart.Document.Descendants<CommentRangeStart>().Count() == 0, "Verify CommentRangeStart elements is deleted.");

                log.Verify(package.MainDocumentPart.Document.Descendants<CommentRangeEnd>().Count() == 0, "Verify CommentRangeEnd elements is deleted.");

                log.Verify(package.MainDocumentPart.Document.Descendants<CommentReference>().Count() == 0, "Verify CommentReference elements is deleted.");
            }
        }

        /// <summary>
        /// Comment object, Get support mothod.
        /// </summary>
        /// <param name="commentsPart">Target comment include commentsPart</param>
        /// <param name="commentID">Comment ID</param>
        /// <returns>Comment Object</returns>
        private Comment GetComment(WordprocessingCommentsPart commentsPart, string commentID)
        {
            return commentsPart.Comments.Descendants<Comment>().Where(e => e.Id == commentID).Single();
        }

        /// <summary>
        /// CommentEx object, Get support mothod.
        /// </summary>
        /// <param name="commentsPart">Target comment include commentsPart</param>
        /// <param name="commentsExPart">Target comment include commentsExPart</param>
        /// <param name="commentID">Comment ID</param>
        /// <returns>CommentEx Object</returns>
        private W15.CommentEx GetCommentEx(WordprocessingCommentsPart commentsPart, WordprocessingCommentsExPart commentsExPart, string commentID)
        {
            Comment comment = GetComment(commentsPart, commentID);
            Paragraph p = comment.Descendants<Paragraph>().First();
            W15.CommentEx commentEx = commentsExPart.CommentsEx.Descendants<W15.CommentEx>().Where(e => e.ParaId.Value == p.ParagraphId.Value).Single();

            return commentEx;
        }
    }
}
