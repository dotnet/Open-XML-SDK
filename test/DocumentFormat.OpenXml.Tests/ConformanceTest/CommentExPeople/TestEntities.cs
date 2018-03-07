// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using LogUtil;
using System.Linq;

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
        /// <param name="filePath">Target file path.</param>
        /// <param name="log">Logger.</param>
        public void ReadElements(string filePath, VerifiableLog log)
        {
            using (WordprocessingDocument package = WordprocessingDocument.Open(filePath, true))
            {
                WordprocessingPeoplePart peoplePart = package.MainDocumentPart.WordprocessingPeoplePart;
                W15.Person person = peoplePart.People.Descendants<W15.Person>().First();
                W15.PresenceInfo presenceInfo = person.Descendants<W15.PresenceInfo>().First();

                log.VerifyValue(person.Author.Value, verifyAuthor, "Person Author attribute is matched. Author={0}", person.Author);
                log.VerifyValue(presenceInfo.ProviderId.Value, verifyProviderId, "PresenceInfo ProviderId attribute is matched. ProviderId={0}", presenceInfo.ProviderId);
                log.VerifyValue(presenceInfo.UserId.Value, verifyUserId, "PresenceInfo UserId attribute is matched. UserId={0}", presenceInfo.UserId);
            }
        }

        /// <summary>
        /// Editing of People part element.
        /// </summary>
        /// <param name="filePath">Target file path.</param>
        /// <param name="log">Logger.</param>
        public void EditElements(string filePath, VerifiableLog log)
        {
            using (WordprocessingDocument package = WordprocessingDocument.Open(filePath, true))
            {
                WordprocessingPeoplePart peoplePart = package.MainDocumentPart.WordprocessingPeoplePart;
                W15.Person person = peoplePart.People.Descendants<W15.Person>().First();
                W15.PresenceInfo presenceInfo = person.Descendants<W15.PresenceInfo>().First();

                person.Author.Value = editAuthor;
                presenceInfo.ProviderId.Value = editProviderId;
                presenceInfo.UserId.Value = editUserId;

                log.Pass("PresenceInfo in PeoplePart is updated");
            }
        }

        /// <summary>
        /// Verifying of People part element.
        /// </summary>
        /// <param name="filePath">Target file path.</param>
        /// <param name="log">Logger.</param>
        public void VerifyElements(string filePath, VerifiableLog log)
        {
            using (WordprocessingDocument package = WordprocessingDocument.Open(filePath, false))
            {
                WordprocessingPeoplePart peoplePart = package.MainDocumentPart.WordprocessingPeoplePart;
                W15.Person person = peoplePart.People.Descendants<W15.Person>().First();
                W15.PresenceInfo presenceInfo = peoplePart.RootElement.Descendants<W15.PresenceInfo>().First();

                log.VerifyValue(person.Author.Value, editAuthor, "Person Author attribute is matched. Author={0}", person.Author);
                log.VerifyValue(presenceInfo.ProviderId.Value, editProviderId, "PresenceInfo ProviderId attribute is matched. ProviderId={0}", presenceInfo.ProviderId);
                log.VerifyValue(presenceInfo.UserId.Value, editUserId, "PresenceInfo UserId attribute is matched. UserId={0}", presenceInfo.UserId);
            }
        }
    }
}
