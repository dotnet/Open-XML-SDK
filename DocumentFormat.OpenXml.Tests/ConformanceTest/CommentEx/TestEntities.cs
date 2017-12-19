// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.IO;
using System.Linq;
using Xunit;

using W15 = DocumentFormat.OpenXml.Office2013.Word;

namespace DocumentFormat.OpenXml.Tests.CommentEx
{
    public static class TestEntities
    {
        /// <summary>
        /// Edit Comment and CommentEx
        /// </summary>
        /// <param name="stream">Package stream</param>
        /// <param name="log">Logger</param>
        public static void EditElements(Stream stream)
        {
            using (WordprocessingDocument package = WordprocessingDocument.Open(stream, true))
            {
                WordprocessingCommentsPart commentPart = package.MainDocumentPart.WordprocessingCommentsPart;
                WordprocessingCommentsExPart commentExPart = package.MainDocumentPart.WordprocessingCommentsExPart;
                Comment comment = null;
                W15.CommentEx commentEx = null;

                //2.1 Change comment text
                comment = GetComment(commentPart, CommentIDs.CommentID1);
                Text text = comment.Descendants<Text>().First();
                text.Text = CommentStrings.CommentChangeString1;

                //2.2 Change commnet initials attribute
                comment = GetComment(commentPart, CommentIDs.CommentID1);

                comment.Initials = CommentInitials.Initial2;

                //2.2 Change commnet date attribute
                comment.Date = new DateTimeValue(new DateTime(2015, 12, 24, 12, 34, 56, 77));

                //2.2 Change commnet author attribute
                comment.Author = CommentAuthors.Author2;

                //2.3 Change comment parent-child relationship, Case of parent attribute deleteing.
                commentEx = GetCommentEx(commentPart, commentExPart, CommentIDs.CommentID2);
                commentEx.ParaIdParent = null;

                //2.3 Change comment parent-child relationship, Case of parent attribute appending.
                commentEx = GetCommentEx(commentPart, commentExPart, CommentIDs.CommentID3);
                W15.CommentEx comEx = GetCommentEx(commentPart, commentExPart, CommentIDs.CommentID2);
                commentEx.ParaIdParent = comEx.ParaId;

                //2.4 Change CommnetEx done attribute, Case of value "1" setting.
                GetCommentEx(commentPart, commentExPart, CommentIDs.CommentID1).Done = true;

                //2.4 Change CommnetEx done attribute, Case of value "0" setting.
                GetCommentEx(commentPart, commentExPart, CommentIDs.CommentID3).Done = false;

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
            }
        }

        /// <summary>
        /// Verify Comment and CommentEx
        /// </summary>
        /// <param name="stream">Package stream</param>
        /// <param name="log">Logger</param>
        public static void VerifyElements(Stream stream)
        {
            using (WordprocessingDocument package = WordprocessingDocument.Open(stream, false))
            {
                WordprocessingCommentsPart commentPart = package.MainDocumentPart.WordprocessingCommentsPart;
                WordprocessingCommentsExPart commentExPart = package.MainDocumentPart.WordprocessingCommentsExPart;
                Comment comment = null;
                W15.CommentEx commentEx = null;

                //2.1 Verifying comment text
                comment = GetComment(commentPart, CommentIDs.CommentID1);
                Text text = comment.Descendants<Text>().First();
                Assert.Equal(text.Text, CommentStrings.CommentChangeString1);

                //2.2 Verifying commnet initials attribute
                comment = GetComment(commentPart, CommentIDs.CommentID1);
                Assert.Equal(comment.Initials, CommentInitials.Initial2);

                //2.2 Verifying commnet date attribute
                Assert.Equal(2015, comment.Date.Value.Year);
                Assert.Equal(12, comment.Date.Value.Month);
                Assert.Equal(24, comment.Date.Value.Day);
                Assert.Equal(12, comment.Date.Value.Hour);
                Assert.Equal(34, comment.Date.Value.Minute);
                Assert.Equal(56, comment.Date.Value.Second);
                Assert.Equal(77, comment.Date.Value.Millisecond);

                //2.2 Verifying commnet author attribute
                Assert.Equal(comment.Author, CommentAuthors.Author2);

                //2.3 Verifying comment parent-child relationship, Case of parent attribute deleteing.
                commentEx = GetCommentEx(commentPart, commentExPart, CommentIDs.CommentID2);
                Assert.Null(commentEx.ParaIdParent);

                //2.3 Verifying comment parent-child relationship, Case of parent attribute appending.
                commentEx = GetCommentEx(commentPart, commentExPart, CommentIDs.CommentID3);
                W15.CommentEx comEx = GetCommentEx(commentPart, commentExPart, CommentIDs.CommentID2);
                Assert.Equal(commentEx.ParaIdParent.Value, GetCommentEx(commentPart, commentExPart, CommentIDs.CommentID2).ParaId.Value);

                //2.4 Verifying CommnetEx done attribute, Case of value "1" setting.
                Assert.True(GetCommentEx(commentPart, commentExPart, CommentIDs.CommentID1).Done);

                //2.4 Verifying CommnetEx done attribute, Case of value "0" setting.
                Assert.False(GetCommentEx(commentPart, commentExPart, CommentIDs.CommentID3).Done);

                //2.5 Verifying comment and CommentEx append.
                Assert.NotNull(GetComment(commentPart, CommentIDs.CommentID4));
                Assert.NotNull(GetCommentEx(commentPart, commentExPart, CommentIDs.CommentID4));

                //2.5 Verifying comment and CommentEx append.
                Assert.NotNull(GetComment(commentPart, CommentIDs.CommentID5));
                Assert.NotNull(GetCommentEx(commentPart, commentExPart, CommentIDs.CommentID5));
                Assert.Equal(GetCommentEx(commentPart, commentExPart, CommentIDs.CommentID5).ParaIdParent.Value, GetCommentEx(commentPart, commentExPart, CommentIDs.CommentID4).ParaId.Value);
            }
        }

        /// <summary>
        /// Delete Comment and CommentEx
        /// </summary>
        /// <param name="stream">Package stream</param>
        /// <param name="log">Logger</param>
        public static void DeleteElements(Stream stream)
        {
            using (WordprocessingDocument package = WordprocessingDocument.Open(stream, true))
            {
                foreach (CommentRangeStart commentRangeStart in package.MainDocumentPart.Document.Descendants<CommentRangeStart>().Reverse())
                {
                    commentRangeStart.Remove();
                }

                foreach (CommentRangeEnd commentRangeEnd in package.MainDocumentPart.Document.Descendants<CommentRangeEnd>().Reverse())
                {
                    commentRangeEnd.Remove();
                }

                foreach (CommentReference commentReference in package.MainDocumentPart.Document.Descendants<CommentReference>().Reverse())
                {
                    commentReference.Ancestors<Run>().First().Remove();
                }

                package.MainDocumentPart.DeletePart(package.MainDocumentPart.WordprocessingCommentsPart);
                package.MainDocumentPart.DeletePart(package.MainDocumentPart.WordprocessingCommentsExPart);
            }
        }

        /// <summary>
        /// Verify Comment and CommentEx is deleted
        /// </summary>
        /// <param name="stream">Package stream</param>
        /// <param name="log">Logger</param>
        public static void VerifyDeletedElements(Stream stream)
        {
            using (WordprocessingDocument package = WordprocessingDocument.Open(stream, false))
            {
                Assert.Null(package.MainDocumentPart.WordprocessingCommentsPart);
                Assert.Null(package.MainDocumentPart.WordprocessingCommentsExPart );
                Assert.Empty(package.MainDocumentPart.Document.Descendants<CommentRangeStart>());
                Assert.Empty(package.MainDocumentPart.Document.Descendants<CommentRangeEnd>());
                Assert.Empty(package.MainDocumentPart.Document.Descendants<CommentReference>());
            }
        }

        /// <summary>
        /// Comment object, Get support mothod.
        /// </summary>
        /// <param name="commentsPart">Target comment include commentsPart</param>
        /// <param name="commentID">Comment ID</param>
        /// <returns>Comment Object</returns>
        private static Comment GetComment(WordprocessingCommentsPart commentsPart, string commentID)
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
        private static W15.CommentEx GetCommentEx(WordprocessingCommentsPart commentsPart, WordprocessingCommentsExPart commentsExPart, string commentID)
        {
            Comment comment = GetComment(commentsPart, commentID);
            Paragraph p = comment.Descendants<Paragraph>().First();
            W15.CommentEx commentEx = commentsExPart.CommentsEx.Descendants<W15.CommentEx>().Where(e => e.ParaId.Value == p.ParagraphId.Value).Single();

            return commentEx;
        }
    }
}
