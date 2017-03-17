// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentFormat.OpenXml.Tests.ThreadingInfo
{
    using DocumentFormat.OpenXml.Packaging;
    using DocumentFormat.OpenXml.Presentation;
    using P15 = DocumentFormat.OpenXml.Office2013.PowerPoint;
    using LogUtil;

    public class TestEntities
    {
        #region Setting values
        private readonly int timeZoneBiasValue = 60;
        #endregion

        #region Property
        /// <summary>
        /// URI attribute value of PresentationExtension.(Parent of P15.ThreadingInfo elemenet)
        /// </summary>
        private string ThreadingInfoExtUri { get; set; }
        #endregion

        /// <summary>
        /// Constructor
        /// Get URI attribute value of CommentExtension
        /// </summary>
        /// <param name="filePath">Generated file path</param>
        public TestEntities(string filePath)
        {
            using (PresentationDocument package = PresentationDocument.Open(filePath, false))
            {
                //Get Extension Uri value
                Comment comment = GetComment(package.PresentationPart.SlideParts, 1);
                P15.ThreadingInfo threadingInfo = comment.CommentExtensionList.Descendants<P15.ThreadingInfo>().Single();
                CommentExtension commentExtension = (CommentExtension)threadingInfo.Parent;
                this.ThreadingInfoExtUri = commentExtension.Uri; ;

                if (string.IsNullOrEmpty(ThreadingInfoExtUri))
                    throw new Exception("Uri attribute value in Extension element is not set.");
            }
        }

        /// <summary>
        /// Editing ThreadingInfo element
        /// </summary>
        /// <param name="filePath">Target Excel file path</param>
        /// <param name="log">Logger</param>
        public void EditElements(string filePath, VerifiableLog log)
        {
            using (PresentationDocument package = PresentationDocument.Open(filePath, true))
            {
                Comment comment = GetComment(package.PresentationPart.SlideParts, 1);
                P15.ThreadingInfo threadingInfo = comment.CommentExtensionList.Descendants<P15.ThreadingInfo>().Single();
                threadingInfo.TimeZoneBias.Value = this.timeZoneBiasValue;

                log.Pass("Edited ThreadingInfo value.");
            }
        }

        /// <summary>
        /// Verifying the ThreadingInfo element the existence
        /// </summary>
        /// <param name="filePath">Target Excel faile path</param>
        /// <param name="log">Logger</param>
        public void VerifyElements(string filePath, VerifiableLog log)
        {
            using (PresentationDocument package = PresentationDocument.Open(filePath, false))
            {
                Comment comment = GetComment(package.PresentationPart.SlideParts, 1);
                P15.ThreadingInfo threadingInfo = comment.CommentExtensionList.Descendants<P15.ThreadingInfo>().Single();

                log.Verify(threadingInfo.TimeZoneBias.Value == this.timeZoneBiasValue, "UnChanged in the ThreadingInfo element.");
            }
        }

        /// <summary>
        /// Deleting ThreadingInfo element
        /// </summary>
        /// <param name="filePath">Target Excel faile path</param>
        /// <param name="log">Logger</param>
        public void DeleteElements(string filePath, VerifiableLog log)
        {
            using (PresentationDocument package = PresentationDocument.Open(filePath, true))
            {
                Comment comment = GetComment(package.PresentationPart.SlideParts, 1);
                CommentExtension commentExtension = comment.CommentExtensionList.Descendants<CommentExtension>().Where(e => e.Uri == this.ThreadingInfoExtUri).Single();
                P15.ThreadingInfo threadingInfo = commentExtension.Descendants<P15.ThreadingInfo>().Single();

                threadingInfo.Remove();
                log.Pass("Deleted ThreadingInfo element.");

                commentExtension.Remove();
                log.Pass("Deleted ThreadingInfo extension element.");
            }
        }

        /// <summary>
        /// Verifying the ThreadingInfo element the deleting
        /// </summary>
        /// <param name="filePath">Target Excel file path</param>
        /// <param name="log">Logger</param>
        public void VerifyDeleteElements(string filePath, VerifiableLog log)
        {
            using (PresentationDocument package = PresentationDocument.Open(filePath, false))
            {
                Comment comment = GetComment(package.PresentationPart.SlideParts, 1);

                int threadingInfoExtCount = comment.CommentExtensionList.Descendants<CommentExtension>().Where(e => e.Uri == this.ThreadingInfoExtUri).Count();
                log.Verify(threadingInfoExtCount == 0, "ThreadingInfo extension element is not deleted.");

                int threadingInfoCount = comment.CommentExtensionList.Descendants<P15.ThreadingInfo>().Count();
                log.Verify(threadingInfoCount == 0, "ThreadingInfo element is not deleted.");
            }
        }

        /// <summary>
        /// Append the ThreadingInfo element
        /// </summary>
        /// <param name="filePath">Target excel faile path</param>
        /// <param name="log">Logger</param>
        public void AddElements(string filePath, VerifiableLog log)
        {
            using (PresentationDocument package = PresentationDocument.Open(filePath, true))
            {
                Comment comment = GetComment(package.PresentationPart.SlideParts, 1);
                CommentExtension commentExtension = new CommentExtension() { Uri = this.ThreadingInfoExtUri };
                P15.ThreadingInfo threadingInfo = new P15.ThreadingInfo() { TimeZoneBias = this.timeZoneBiasValue };
                commentExtension.AppendChild<P15.ThreadingInfo>(threadingInfo);
                comment.CommentExtensionList.AppendChild<CommentExtension>(commentExtension);

                log.Pass("Added ThreadingInfo element.");
            }
        }

        /// <summary>
        /// Verifying the workbookPr element the appending
        /// </summary>
        /// <param name="filePath">Target Excel faile path</param>
        /// <param name="log">Logger</param>
        public void VerifyAddElements(string filePath, VerifiableLog log)
        {
            using (PresentationDocument package = PresentationDocument.Open(filePath, false))
            {
                Comment comment = GetComment(package.PresentationPart.SlideParts, 1);

                int threadingInfoExtCount = comment.CommentExtensionList.Descendants<CommentExtension>().Where(e => e.Uri == this.ThreadingInfoExtUri).Count();
                log.Verify(threadingInfoExtCount == 1, "ThreadingInfo element is not added.");

                int threadingInfoCount = comment.CommentExtensionList.Descendants<P15.ThreadingInfo>().Count();
                log.Verify(threadingInfoCount == 1, "ThreadingInfo element is not added.");
            }
        }

        /// <summary>
        /// Get Comment class instance
        /// </summary>
        /// <param name="slideParts">slideParts</param>
        /// <param name="commentId">comment Id</param>
        /// <returns>Comment</returns>
        private Comment GetComment(IEnumerable<SlidePart> slideParts, int commentId)
        {
            Comment returnComment = null;

            foreach (SlidePart slidePart in slideParts)
            {
                foreach (Comment comment in slidePart.SlideCommentsPart.CommentList)
                {
                    if (comment.Index == commentId)
                    {
                        returnComment = comment;
                        break;
                    }
                }
            }

            return returnComment;
        }
    }
}
