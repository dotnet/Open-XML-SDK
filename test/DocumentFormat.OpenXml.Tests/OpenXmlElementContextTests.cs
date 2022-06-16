// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Packaging;
using NSubstitute;
using System.Collections.Generic;
using System.Xml;
using Xunit;

namespace DocumentFormat.OpenXml.Tests
{
    public class OpenXmlElementContextTests
    {
        [Fact]
        public void DefaultMarkupCompatibilitySettings()
        {
            var context = new OpenXmlElementContext(new OpenXmlNamespaceResolver());

            Assert.NotNull(context.MCSettings);
            Assert.Same(context.MCSettings, context.MCSettings);

            Assert.Equal(MarkupCompatibilityProcessMode.NoProcess, context.MCSettings.ProcessMode);
            Assert.Equal(FileFormatVersions.Office2007.AndLater(), context.MCSettings.TargetFileFormatVersions);
        }

        [Fact]
        public void SetMarkupCompatibility()
        {
            var context = new OpenXmlElementContext(new OpenXmlNamespaceResolver());
            var settings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.NoProcess, FileFormatVersions.Office2010);

            context.MCSettings = settings;

            Assert.Same(settings, context.MCSettings);
        }

        [MemberData(nameof(GetXmlReaders))]
        [Theory]
        public void XmlReaderSettingsSet(XmlReaderSettings settings)
        {
#if FEATURE_XML_PROHIBIT_DTD
            Assert.True(xmlReader.ProhibitDtd);
#else
            Assert.Equal(DtdProcessing.Prohibit, settings.DtdProcessing);
#endif

            Assert.False(settings.IgnoreWhitespace);
            Assert.IsType<NameTable>(settings.NameTable);
        }

        [Fact]
        public void LazySteps()
        {
            // This may become a public property at some point
            Assert.Equal(3, OpenXmlElementContext.LazySteps);
        }

        [Fact]
        public void ElementInsertingEventTest()
        {
            var context = new OpenXmlElementContext(new OpenXmlNamespaceResolver());
            var element = Substitute.For<OpenXmlElement>();
            var parent = Substitute.For<OpenXmlElement>();
            var eventFired = false;

            context.ElementInsertingEvent(element, element);

            context.ElementInserting += (s, e) =>
            {
                Assert.Same(context, s);
                Assert.Same(element, e.Element);
                Assert.Same(element, e.ParentElement);

                eventFired = true;
            };

            context.ElementInsertingEvent(element, element);

            Assert.True(eventFired);
        }

        [Fact]
        public void ElementInsertedEventTest()
        {
            var context = new OpenXmlElementContext(new OpenXmlNamespaceResolver());
            var element = Substitute.For<OpenXmlElement>();
            var parent = Substitute.For<OpenXmlElement>();
            var eventFired = false;

            context.ElementInsertedEvent(element, element);

            context.ElementInserted += (s, e) =>
            {
                Assert.Same(context, s);
                Assert.Same(element, e.Element);
                Assert.Same(element, e.ParentElement);

                eventFired = true;
            };

            context.ElementInsertedEvent(element, element);

            Assert.True(eventFired);
        }

        [Fact]
        public void ElementRemovingEventTest()
        {
            var context = new OpenXmlElementContext(new OpenXmlNamespaceResolver());
            var element = Substitute.For<OpenXmlElement>();
            var parent = Substitute.For<OpenXmlElement>();
            var eventFired = false;

            context.ElementRemovingEvent(element, element);

            context.ElementRemoving += (s, e) =>
            {
                Assert.Same(context, s);
                Assert.Same(element, e.Element);
                Assert.Same(element, e.ParentElement);

                eventFired = true;
            };

            context.ElementRemovingEvent(element, element);

            Assert.True(eventFired);
        }

        [Fact]
        public void ElementRemovedEventTest()
        {
            var context = new OpenXmlElementContext(new OpenXmlNamespaceResolver());
            var element = Substitute.For<OpenXmlElement>();
            var parent = Substitute.For<OpenXmlElement>();
            var eventFired = false;

            context.ElementRemovedEvent(element, element);

            context.ElementRemoved += (s, e) =>
            {
                Assert.Same(context, s);
                Assert.Same(element, e.Element);
                Assert.Same(element, e.ParentElement);

                eventFired = true;
            };

            context.ElementRemovedEvent(element, element);

            Assert.True(eventFired);
        }

        public static IEnumerable<object[]> GetXmlReaders()
        {
            yield return new object[] { new OpenXmlElementContext(new OpenXmlNamespaceResolver()).XmlReaderSettings };
            yield return new object[] { OpenXmlElementContext.CreateDefaultXmlReaderSettings() };
        }
    }
}
