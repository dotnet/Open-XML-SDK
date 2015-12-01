using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentFormat.OpenXml.Tests.ContentControl
{
    using DocumentFormat.OpenXml.Packaging;
    using DocumentFormat.OpenXml.Wordprocessing;
    using LogUtil;

    /// <summary>
    /// Delete all of the std element
    /// </summary>
    public class DeleteElement
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
