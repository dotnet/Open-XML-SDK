// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Tests.CommentExPeopleClass;
using System.IO;
using Xunit;
using Xunit.Abstractions;

namespace DocumentFormat.OpenXml.Tests.CommentExPeople
{
    /// <summary>
    /// Test for Comment People part.
    /// </summary>
    public class CommentExPeopleTest : OpenXmlTestBase
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public CommentExPeopleTest(ITestOutputHelper output)
            : base(output)
        {
        }

        /// <summary>
        /// Element reading test for "Comment PeoplePart".
        /// </summary>
        [Fact]
        public void CommentExPeople01ReadElement()
        {
            using (var stream = new MemoryStream())
            {
                GeneratedDocument generatedDocument = new GeneratedDocument();
                generatedDocument.CreatePackage(stream);

                TestEntities testEntities = new TestEntities();
                testEntities.ReadElements(stream, Log);
            }
        }

        /// <summary>
        /// Element editing test for "Comment PeoplePart".
        /// </summary>
        [Fact]
        public void CommentExPeople02EditElement()
        {
            using (var stream = new MemoryStream())
            {
                GeneratedDocument generatedDocument = new GeneratedDocument();
                generatedDocument.CreatePackage(stream);

                TestEntities testEntities = new TestEntities();
                testEntities.EditElements(stream, Log);
                testEntities.VerifyElements(stream, Log);
            }
        }
    }
}
