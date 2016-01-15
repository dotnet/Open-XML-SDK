// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentFormat.OpenXml.Tests.CommentEx
{
    using DocumentFormat.OpenXml.Packaging;
    using DocumentFormat.OpenXml.Wordprocessing;
    using W15 = DocumentFormat.OpenXml.Office2013.Word;

    /// <summary>
    /// Comment and CommentEx, Get support class.
    /// </summary>
    public class Commons
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
