// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
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
    /// Verify that the sdt element has been deleted
    /// </summary>
    public class VerifyDeletedElement
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
