// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using LogUtil;
using System.IO;
using System.Linq;

namespace DocumentFormat.OpenXml.Tests.Theme
{
    public class TestEntities
    {
        //Theme ID values
        private readonly string ThemeId1 = "{BBB17459-96FE-44C7-A45E-966A49711E99}";
        private readonly string ThemeId2 = "{E13D3DE1-D0A1-4459-9464-6F999792E799}";

        /// <summary>
        /// Editing theme id attribute
        /// </summary>
        /// <param name="stream">Target Excel stream</param>
        /// <param name="log">Logger</param>
        public void EditAttribute(Stream stream, VerifiableLog log)
        {
            using (PresentationDocument package = PresentationDocument.Open(stream, true))
            {
                package.PresentationPart.SlideMasterParts.First().ThemePart.Theme.ThemeId.Value = ThemeId2;

                log.Pass("Edit theme id attribute. Set value is \"{0}\"", ThemeId2);
            }
        }

        /// <summary>
        /// Verifying the theme id attribute the existence
        /// </summary>
        /// <param name="stream">Target Excel stream</param>
        /// <param name="log">Logger</param>
        public void VerifyAttribute(Stream stream, VerifiableLog log)
        {
            using (PresentationDocument package = PresentationDocument.Open(stream, false))
            {
                log.Verify(package.PresentationPart.SlideMasterParts.First().ThemePart.Theme.ThemeId.Value == ThemeId2,
                    "UnChanged in the id attribute value on theme element. ID value=[{0}]", package.PresentationPart.SlideMasterParts.First().ThemePart.Theme.ThemeId.Value);
            }
        }

        /// <summary>
        /// Deleting theme id attribute
        /// </summary>
        /// <param name="stream">Target Excel stream</param>
        /// <param name="log">Logger</param>
        public void DeletAttribute(Stream stream, VerifiableLog log)
        {
            using (PresentationDocument package = PresentationDocument.Open(stream, true))
            {
                package.PresentationPart.SlideMasterParts.First().ThemePart.Theme.ThemeId = null;

                log.Pass("Delete theme id attribute.");
            }
        }

        /// <summary>
        /// Verifying the theme id attribute of deleting
        /// </summary>
        /// <param name="stream">Target Excel stream</param>
        /// <param name="log">Logger</param>
        public void VerifyDeletedAttribute(Stream stream, VerifiableLog log)
        {
            using (PresentationDocument package = PresentationDocument.Open(stream, false))
            {
                log.Verify(package.PresentationPart.SlideMasterParts.First().ThemePart.Theme.ThemeId == null,
                    "Theme id attribute is not deleted. ID value=[{0}]", package.PresentationPart.SlideMasterParts.First().ThemePart.Theme.ThemeId);
            }
        }

        /// <summary>
        /// Append the theme id attribute
        /// </summary>
        /// <param name="stream">Target excel stream</param>
        /// <param name="log">Logger</param>
        public void AddAttribute(Stream stream, VerifiableLog log)
        {
            using (PresentationDocument package = PresentationDocument.Open(stream, true))
            {
                package.PresentationPart.SlideMasterParts.First().ThemePart.Theme.ThemeId = ThemeId1;

                log.Pass("Add theme id attribute.");
            }
        }

        /// <summary>
        /// Verifying the theme id attribute the appending
        /// </summary>
        /// <param name="stream">Target Excel stream</param>
        /// <param name="log">Logger</param>
        public void VerifyAddedAttribute(Stream stream, VerifiableLog log)
        {
            using (PresentationDocument package = PresentationDocument.Open(stream, false))
            {
                log.Verify(package.PresentationPart.SlideMasterParts.First().ThemePart.Theme.ThemeId.Value == ThemeId1,
                    "UnChanged in the id attribute value on theme element. ID value=[{0}]", package.PresentationPart.SlideMasterParts.First().ThemePart.Theme.ThemeId.Value);
            }
        }
    }
}
