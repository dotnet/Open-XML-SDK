// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using System.IO;
using System.Linq;
using Xunit;

namespace DocumentFormat.OpenXml.Tests.Theme
{
    public class TestEntities
    {
        // Theme ID values
        private const string ThemeId1 = "{BBB17459-96FE-44C7-A45E-966A49711E99}";
        private const string ThemeId2 = "{E13D3DE1-D0A1-4459-9464-6F999792E799}";

        /// <summary>
        /// Editing theme id attribute
        /// </summary>
        /// <param name="stream">Target Excel stream</param>
        /// <param name="log">Logger</param>
        internal void EditAttribute(Stream stream, ITestOutputHelper log)
        {
            using (PresentationDocument package = PresentationDocument.Open(stream, true))
            {
                package.PresentationPart.SlideMasterParts.First().ThemePart.Theme.ThemeId.Value = ThemeId2;

                log.WriteLine("Edit theme id attribute. Set value is \"{0}\"", ThemeId2);
            }
        }

        /// <summary>
        /// Verifying the theme id attribute the existence
        /// </summary>
        /// <param name="stream">Target Excel stream</param>
        /// <param name="log">Logger</param>
        internal void VerifyAttribute(Stream stream, ITestOutputHelper log)
        {
            using (PresentationDocument package = PresentationDocument.Open(stream, false))
            {
                Assert.Equal(ThemeId2, package.PresentationPart.SlideMasterParts.First().ThemePart.Theme.ThemeId.Value);
            }
        }

        /// <summary>
        /// Deleting theme id attribute
        /// </summary>
        /// <param name="stream">Target Excel stream</param>
        /// <param name="log">Logger</param>
        internal void DeletAttribute(Stream stream, ITestOutputHelper log)
        {
            using (PresentationDocument package = PresentationDocument.Open(stream, true))
            {
                package.PresentationPart.SlideMasterParts.First().ThemePart.Theme.ThemeId = null;

                log.WriteLine("Delete theme id attribute.");
            }
        }

        /// <summary>
        /// Verifying the theme id attribute of deleting
        /// </summary>
        /// <param name="stream">Target Excel stream</param>
        /// <param name="log">Logger</param>
        internal void VerifyDeletedAttribute(Stream stream, ITestOutputHelper log)
        {
            using (PresentationDocument package = PresentationDocument.Open(stream, false))
            {
                Assert.True(package.PresentationPart.SlideMasterParts.First().ThemePart.Theme.ThemeId is null, string.Format("Theme id attribute is not deleted. ID value=[{0}]", package.PresentationPart.SlideMasterParts.First().ThemePart.Theme.ThemeId));
            }
        }

        /// <summary>
        /// Append the theme id attribute
        /// </summary>
        /// <param name="stream">Target excel stream</param>
        /// <param name="log">Logger</param>
        internal void AddAttribute(Stream stream, ITestOutputHelper log)
        {
            using (PresentationDocument package = PresentationDocument.Open(stream, true))
            {
                package.PresentationPart.SlideMasterParts.First().ThemePart.Theme.ThemeId = ThemeId1;

                log.WriteLine("Add theme id attribute.");
            }
        }

        /// <summary>
        /// Verifying the theme id attribute the appending
        /// </summary>
        /// <param name="stream">Target Excel stream</param>
        /// <param name="log">Logger</param>
        internal void VerifyAddedAttribute(Stream stream, ITestOutputHelper log)
        {
            using (PresentationDocument package = PresentationDocument.Open(stream, false))
            {
                Assert.Equal(ThemeId1, package.PresentationPart.SlideMasterParts.First().ThemePart.Theme.ThemeId.Value);
            }
        }
    }
}
