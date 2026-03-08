// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using System.IO;
using System.Linq;
using Xunit;

using W15 = DocumentFormat.OpenXml.Office2013.Word;

namespace DocumentFormat.OpenXml.Tests.CommentExPeople
{
    public class TestEntities
    {
        private readonly string verifyAuthor = "Masaki Tamura (Pasona Tech)";
        private readonly string verifyProviderId = "AD";
        private readonly string verifyUserId = "S-1-5-21-2146773085-903363285-719344707-1318535";
        private readonly string editAuthor = "Dan Ito";
        private readonly string editProviderId = "LDAP";
        private readonly string editUserId = "S-1-5-21-2146773085-903363285-719344707-75298";

        /// <summary>
        /// Reading of People part element.
        /// </summary>
        internal void ReadElements(Stream stream, ITestOutputHelper log)
        {
            using (WordprocessingDocument package = WordprocessingDocument.Open(stream, true))
            {
                WordprocessingPeoplePart peoplePart = package.MainDocumentPart.WordprocessingPeoplePart;
                W15.Person person = peoplePart.People.Descendants<W15.Person>().First();
                W15.PresenceInfo presenceInfo = person.Descendants<W15.PresenceInfo>().First();

                Assert.Equal(verifyAuthor, person.Author.Value);
                Assert.Equal(verifyProviderId, presenceInfo.ProviderId.Value);
                Assert.Equal(verifyUserId, presenceInfo.UserId.Value);
            }
        }

        /// <summary>
        /// Editing of People part element.
        /// </summary>
        internal void EditElements(Stream stream, ITestOutputHelper log)
        {
            using (WordprocessingDocument package = WordprocessingDocument.Open(stream, true))
            {
                WordprocessingPeoplePart peoplePart = package.MainDocumentPart.WordprocessingPeoplePart;
                W15.Person person = peoplePart.People.Descendants<W15.Person>().First();
                W15.PresenceInfo presenceInfo = person.Descendants<W15.PresenceInfo>().First();

                person.Author.Value = editAuthor;
                presenceInfo.ProviderId.Value = editProviderId;
                presenceInfo.UserId.Value = editUserId;

                log.WriteLine("PresenceInfo in PeoplePart is updated");
            }
        }

        /// <summary>
        /// Verifying of People part element.
        /// </summary>
        internal void VerifyElements(Stream stream, ITestOutputHelper log)
        {
            using (WordprocessingDocument package = WordprocessingDocument.Open(stream, false))
            {
                WordprocessingPeoplePart peoplePart = package.MainDocumentPart.WordprocessingPeoplePart;
                W15.Person person = peoplePart.People.Descendants<W15.Person>().First();
                W15.PresenceInfo presenceInfo = peoplePart.RootElement.Descendants<W15.PresenceInfo>().First();

                Assert.Equal(editAuthor, person.Author.Value);
                Assert.Equal(editProviderId, presenceInfo.ProviderId.Value);
                Assert.Equal(editUserId, presenceInfo.UserId.Value);
            }
        }
    }
}
