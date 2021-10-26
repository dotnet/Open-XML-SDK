// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using System.Collections.Generic;
using System.IO;
using Xunit;

namespace DocumentFormat.OpenXml.Features.Tests
{
    public class PackageEventsTests
    {
        [Fact]
        public void PackageEventCalledOnClose()
        {
            var events = new List<EventType>();

            using (var ms = new MemoryStream())
            using (var package = WordprocessingDocument.Create(ms, WordprocessingDocumentType.Document))
            {
                package.AddPackageEventsFeature();
                package.Features.Get<IPackageEventsFeature>().Change += a => events.Add(a.Type);
            }

            Assert.Collection(
                events,
                e => Assert.Equal(EventType.Closing, e),
                e => Assert.Equal(EventType.Closed, e));
        }

        [Fact]
        public void PartIdentifiedOpening()
        {
            var events = new List<EventType>();

            using (var ms = new MemoryStream())
            using (var package = WordprocessingDocument.Create(ms, WordprocessingDocumentType.Document))
            {
                package.AddPartEventsFeature();

                var creating = default(OpenXmlPart);
                var created = default(OpenXmlPart);
                var removing = default(OpenXmlPart);
                var removed = default(OpenXmlPart);
                var deleting = default(OpenXmlPart);
                var deleted = default(OpenXmlPart);

                package.Features.Get<IPartEventsFeature>().Change += a =>
                {
                    events.Add(a.Type);

                    switch (a.Type)
                    {
                        case EventType.Creating:
                            creating = a.Argument;
                            break;
                        case EventType.Created:
                            created = a.Argument;
                            break;
                        case EventType.Removed:
                            removed = a.Argument;
                            break;
                        case EventType.Removing:
                            removing = a.Argument;
                            break;
                        case EventType.Deleting:
                            deleting = a.Argument;
                            break;
                        case EventType.Deleted:
                            deleted = a.Argument;
                            break;
                    }
                };

                var doc = package.AddMainDocumentPart();

                Assert.Same(doc, creating);
                Assert.Same(doc, created);
                Assert.Null(removed);
                Assert.Null(removing);

                package.DeletePart(doc);

                Assert.Same(doc, removed);
                Assert.Same(doc, removing);
                Assert.Same(doc, deleted);
                Assert.Same(doc, deleting);
            }

            Assert.Collection(
                events,
                e => Assert.Equal(EventType.Creating, e),
                e => Assert.Equal(EventType.Created, e),
                e => Assert.Equal(EventType.Deleting, e),
                e => Assert.Equal(EventType.Removing, e),
                e => Assert.Equal(EventType.Removed, e),
                e => Assert.Equal(EventType.Deleted, e));
        }
    }
}
