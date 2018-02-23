// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using LogUtil;
using System;
using System.Linq;

namespace DocumentFormat.OpenXml.Tests.ContentControl
{
    /// <summary>
    /// Delete all of the std element
    /// </summary>
    public static class DeleteElement
    {
        /// <summary>
        /// Delete all of the std element
        /// </summary>
        /// <param name="filePath">Delete file</param>
        /// <param name="log">Logger</param>
        public static void DeleteContentControlElements(string filePath, VerifiableLog log)
        {
            try
            {
                using (WordprocessingDocument package = WordprocessingDocument.Open(filePath, true))
                {
                    foreach (SdtElement sdtElement in package.MainDocumentPart.Document.Descendants<SdtElement>().Reverse())
                    {
                        sdtElement.Remove();
                    }
                }

                log.Pass("Delete is <Sdt> element and <Sdt> child element.");
            }
            catch(Exception e)
            {
                log.Fail(e.Message);
            }
        }
    }
}
