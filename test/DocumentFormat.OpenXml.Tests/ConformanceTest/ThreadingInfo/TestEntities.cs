// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Presentation;
using LogUtil;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using P15 = DocumentFormat.OpenXml.Office2013.PowerPoint;

namespace DocumentFormat.OpenXml.Tests.ThreadingInfo
{
    public class TestEntities
    {
        #region Setting values
        private readonly int timeZoneBiasValue = 60;
        #endregion

        #region Property

        /// <summary>
        /// URI attribute value of PresentationExtension.(Parent of P15.ThreadingInfo element)
        /// </summary>
        private string ThreadingInfoExtUri { get; set; }
        #endregion

        /// <summary>
        /// Constructor
        /// Get URI attribute value of CommentExtension
        /// </summary>
        public TestEntities(Stream stream)
        {
            using (PresentationDocument package = PresentationDocument.Open(stream, false))
            {
                //Get Extension Uri value
                Comment comment = GetComment(package.PresentationPart.SlideParts, 1);
                P15.ThreadingInfo threadingInfo = comment.CommentExtensionList.Descendants<P15.ThreadingInfo>().Single();
                CommentExtension commentExtension = (CommentExtension)threadingInfo.Parent;
                ThreadingInfoExtUri = commentExtension.Uri;

                if (string.IsNullOrEmpty(ThreadingInfoExtUri))
                    throw new Exception("Uri attribute value in Extension element is not set.");
            }
        }

        /// <summary>
        /// Editing ThreadingInfo element
        /// </summary>
        public void EditElements(Stream stream, VerifiableLog log)
        {
            using (PresentationDocument package = PresentationDocument.Open(stream, true))
            {
                Comment comment = GetComment(package.PresentationPart.SlideParts, 1);
                P15.ThreadingInfo threadingInfo = comment.CommentExtensionList.Descendants<P15.ThreadingInfo>().Single();
                threadingInfo.TimeZoneBias.Value = timeZoneBiasValue;

                log.Pass("Edited ThreadingInfo value.");
            }
        }

        /// <summary>
        /// Verifying the ThreadingInfo element the existence
        /// </summary>
        public void VerifyElements(Stream stream, VerifiableLog log)
        {
            using (PresentationDocument package = PresentationDocument.Open(stream, false))
            {
                Comment comment = GetComment(package.PresentationPart.SlideParts, 1);
                P15.ThreadingInfo threadingInfo = comment.CommentExtensionList.Descendants<P15.ThreadingInfo>().Single();

                log.Verify(threadingInfo.TimeZoneBias.Value == timeZoneBiasValue, "UnChanged in the ThreadingInfo element.");
            }
        }

        /// <summary>
        /// Deleting ThreadingInfo element
        /// </summary>
        public void DeleteElements(Stream stream, VerifiableLog log)
        {
            using (PresentationDocument package = PresentationDocument.Open(stream, true))
            {
                Comment comment = GetComment(package.PresentationPart.SlideParts, 1);
                CommentExtension commentExtension = comment.CommentExtensionList.Descendants<CommentExtension>().Where(e => e.Uri == ThreadingInfoExtUri).Single();
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
        public void VerifyDeleteElements(Stream stream, VerifiableLog log)
        {
            using (PresentationDocument package = PresentationDocument.Open(stream, false))
            {
                Comment comment = GetComment(package.PresentationPart.SlideParts, 1);

                int threadingInfoExtCount = comment.CommentExtensionList.Descendants<CommentExtension>().Where(e => e.Uri == ThreadingInfoExtUri).Count();
                log.Verify(threadingInfoExtCount == 0, "ThreadingInfo extension element is not deleted.");

                int threadingInfoCount = comment.CommentExtensionList.Descendants<P15.ThreadingInfo>().Count();
                log.Verify(threadingInfoCount == 0, "ThreadingInfo element is not deleted.");
            }
        }

        /// <summary>
        /// Append the ThreadingInfo element
        /// </summary>
        public void AddElements(Stream stream, VerifiableLog log)
        {
            using (PresentationDocument package = PresentationDocument.Open(stream, true))
            {
                Comment comment = GetComment(package.PresentationPart.SlideParts, 1);
                CommentExtension commentExtension = new CommentExtension() { Uri = ThreadingInfoExtUri };
                P15.ThreadingInfo threadingInfo = new P15.ThreadingInfo() { TimeZoneBias = timeZoneBiasValue };
                commentExtension.AppendChild<P15.ThreadingInfo>(threadingInfo);
                comment.CommentExtensionList.AppendChild<CommentExtension>(commentExtension);

                log.Pass("Added ThreadingInfo element.");
            }
        }

        /// <summary>
        /// Verifying the workbookPr element the appending
        /// </summary>
        public void VerifyAddElements(Stream stream, VerifiableLog log)
        {
            using (PresentationDocument package = PresentationDocument.Open(stream, false))
            {
                Comment comment = GetComment(package.PresentationPart.SlideParts, 1);

                int threadingInfoExtCount = comment.CommentExtensionList.Descendants<CommentExtension>().Where(e => e.Uri == ThreadingInfoExtUri).Count();
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
