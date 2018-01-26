// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using LogUtil;
using System.Linq;

namespace DocumentFormat.OpenXml.Tests.ContentControl
{
    /// <summary>
    /// Verify that the sdt element has been deleted
    /// </summary>
    public static class VerifyDeletedElement
    {
        /// <summary>
        /// Verify that the sdt element has been deleted
        /// </summary>
        /// <param name="filePath">Verify file</param>
        /// <param name="log">Logger</param>
        /// <returns>sdt element number</returns>
        public static int DeletedElementVerify(string filePath, VerifiableLog log)
        {
            //Counting "sdt" elements number
            int sdtElementNum = 0;

            using (WordprocessingDocument package = WordprocessingDocument.Open(filePath, true))
            {
                sdtElementNum = package.MainDocumentPart.Document.Descendants<SdtElement>().Count();
            }

            if (sdtElementNum == 0)
            {
                log.Pass("All deleted of \"sdt\" elements.");
            }
            else
            {
                log.Fail(string.Format("Remaining \"sdt\" elements. That number is {0}.", sdtElementNum));
            }

            return sdtElementNum;
        }
    }
}
