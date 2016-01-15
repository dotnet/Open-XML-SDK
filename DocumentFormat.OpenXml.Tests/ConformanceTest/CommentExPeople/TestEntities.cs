// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentFormat.OpenXml.Tests.CommentExPeople
{
    using DocumentFormat.OpenXml;
    using DocumentFormat.OpenXml.Packaging;
    using W15 = DocumentFormat.OpenXml.Office2013.Word;
    using LogUtil;

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

                log.VerifyValue(person.Author.Value, this.verifyAuthor, "Person Author attribute is matched. Author={0}", person.Author);
                log.VerifyValue(presenceInfo.ProviderId.Value, this.verifyProviderId, "PresenceInfo ProviderId attribute is matched. ProviderId={0}", presenceInfo.ProviderId);
                log.VerifyValue(presenceInfo.UserId.Value, this.verifyUserId, "PresenceInfo UserId attribute is matched. UserId={0}", presenceInfo.UserId);
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

                person.Author.Value = this.editAuthor;
                presenceInfo.ProviderId.Value = this.editProviderId;
                presenceInfo.UserId.Value = this.editUserId;

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

                log.VerifyValue(person.Author.Value, this.editAuthor, "Person Author attribute is matched. Author={0}", person.Author);
                log.VerifyValue(presenceInfo.ProviderId.Value, this.editProviderId, "PresenceInfo ProviderId attribute is matched. ProviderId={0}", presenceInfo.ProviderId);
                log.VerifyValue(presenceInfo.UserId.Value, this.editUserId, "PresenceInfo UserId attribute is matched. UserId={0}", presenceInfo.UserId);
            }
        }
    }
}
