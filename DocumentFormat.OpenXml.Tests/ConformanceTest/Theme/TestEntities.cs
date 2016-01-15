// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentFormat.OpenXml.Tests.Theme
{
    using DocumentFormat.OpenXml.Packaging;
    using LogUtil;

    public class TestEntities
    {
        //Theme ID values
        private readonly string ThemeId1 = "{BBB17459-96FE-44C7-A45E-966A49711E99}";
        private readonly string ThemeId2 = "{E13D3DE1-D0A1-4459-9464-6F999792E799}";

        /// <summary>
        /// Editing theme id attribute
        /// </summary>
        /// <param name="filePath">Target Excel faile path</param>
        /// <param name="log">Logger</param>
        public void EditAttribute(string filePath, VerifiableLog log)
        {
            using (PresentationDocument package = PresentationDocument.Open(filePath, true))
            {
                package.PresentationPart.SlideMasterParts.First().ThemePart.Theme.ThemeId.Value = this.ThemeId2;

                log.Pass("Edit theme id attribute. Set value is \"{0}\"", this.ThemeId2);
            }
        }

        /// <summary>
        /// Verifying the theme id attribute the existence
        /// </summary>
        /// <param name="filePath">Target Excel faile path</param>
        /// <param name="log">Logger</param>
        public void VerifyAttribute(string filePath, VerifiableLog log)
        {
            using (PresentationDocument package = PresentationDocument.Open(filePath, false))
            {
                log.Verify(package.PresentationPart.SlideMasterParts.First().ThemePart.Theme.ThemeId.Value == this.ThemeId2,
                    "UnChanged in the id attribute value on theme element. ID value=[{0}]", package.PresentationPart.SlideMasterParts.First().ThemePart.Theme.ThemeId.Value);
            }
        }

        /// <summary>
        /// Deleting theme id attribute
        /// </summary>
        /// <param name="filePath">Target Excel faile path</param>
        /// <param name="log">Logger</param>
        public void DeletAttribute(string filePath, VerifiableLog log)
        {
            using (PresentationDocument package = PresentationDocument.Open(filePath, true))
            {
                package.PresentationPart.SlideMasterParts.First().ThemePart.Theme.ThemeId = null;

                log.Pass("Delete theme id attribute.");
            }
        }

        /// <summary>
        /// Verifying the theme id attribute of deleting
        /// </summary>
        /// <param name="filePath">Target Excel file path</param>
        /// <param name="log">Logger</param>
        public void VerifyDeletedAttribute(string filePath, VerifiableLog log)
        {
            using (PresentationDocument package = PresentationDocument.Open(filePath, false))
            {
                log.Verify(package.PresentationPart.SlideMasterParts.First().ThemePart.Theme.ThemeId == null,
                    "Theme id attribute is not deleted. ID value=[{0}]", package.PresentationPart.SlideMasterParts.First().ThemePart.Theme.ThemeId);
            }
        }

        /// <summary>
        /// Append the theme id attribute
        /// </summary>
        /// <param name="filePath">Target excel faile path</param>
        /// <param name="log">Logger</param>
        public void AddAttribute(string filePath, VerifiableLog log)
        {
            using (PresentationDocument package = PresentationDocument.Open(filePath, true))
            {
                package.PresentationPart.SlideMasterParts.First().ThemePart.Theme.ThemeId = this.ThemeId1;

                log.Pass("Add theme id attribute.");
            }
        }

        /// <summary>
        /// Verifying the theme id attribute the appending
        /// </summary>
        /// <param name="filePath">Target Excel faile path</param>
        /// <param name="log">Logger</param>
        public void VerifyAddedAttribute(string filePath, VerifiableLog log)
        {
            using (PresentationDocument package = PresentationDocument.Open(filePath, false))
            {
                log.Verify(package.PresentationPart.SlideMasterParts.First().ThemePart.Theme.ThemeId.Value == this.ThemeId1,
                    "UnChanged in the id attribute value on theme element. ID value=[{0}]", package.PresentationPart.SlideMasterParts.First().ThemePart.Theme.ThemeId.Value);
            }
        }
    }
}
