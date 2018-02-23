// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Linq;

using W15 = DocumentFormat.OpenXml.Office2013.Word;

namespace DocumentFormat.OpenXml.Tests.CommentEx
{
    /// <summary>
    /// Comment and CommentEx, Get support class.
    /// </summary>
    public static class Commons
    {
        /// <summary>
        /// Comment object, Get support mothod.
        /// </summary>
        /// <param name="commentsPart">Target comment include commentsPart</param>
        /// <param name="commentID">Comment ID</param>
        /// <returns>Comment Object</returns>
        public static Comment GetComment(WordprocessingCommentsPart commentsPart, string commentID)
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
        public static W15.CommentEx GetCommentEx(WordprocessingCommentsPart commentsPart, WordprocessingCommentsExPart commentsExPart, string commentID)
        {
            Comment comment = GetComment(commentsPart, commentID);
            Paragraph p = comment.Descendants<Paragraph>().First();
            W15.CommentEx commentEx = commentsExPart.CommentsEx.Descendants<W15.CommentEx>().Where(e => e.ParaId.Value == p.ParagraphId.Value).Single();

            return commentEx;
        }
    }
}
