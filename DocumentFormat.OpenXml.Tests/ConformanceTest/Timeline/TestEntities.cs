// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Office2013.Excel;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.IO;
using System.Linq;
using Xunit;

namespace DocumentFormat.OpenXml.Tests.TimeLine
{
    public class TestEntities
    {
        // TimeLine names
        private const string TileLine01 = "DeliveryDate 10";
        private const string TileLine02 = "DeliveryDate 11";
        private const string TileLine03 = "Date";
        private const string TileLine04 = "Date 1";
        private const string TileLine05 = "DeliveryDate 8";
        private const string TileLine06 = "DeliveryDate 9";
        private const string TileLine07 = "DeliveryDate 6";
        private const string TileLine08 = "DeliveryDate 7";
        private const string TileLine09 = "DeliveryDate 16";
        private const string TileLine10 = "DeliveryDate 17";
        private const string TileLine11 = "DeliveryDate 4";
        private const string TileLine12 = "DeliveryDate 5";
        private const string TileLine13 = "DeliveryDate 14";
        private const string TileLine14 = "DeliveryDate 15";
        private const string TileLine15 = "DeliveryDate";
        private const string TileLine16 = "DeliveryDate 1";
        private const string TileLine17 = "DeliveryDate 2";
        private const string TileLine18 = "DeliveryDate 3";
        private const string TileLine19 = "DeliveryDate 12";
        private const string TileLine20 = "DeliveryDate 13";

        // TimeLine Style Names
        private const string timelineStyleName2 = "TimeSlicerStyleLight2";
        private const string timelineStyleName3 = "TimeSlicerStyleLight3";

        /// <summary>
        /// URI attribute value of PresentationExtension.(Parent of TimelineStyles elemenet)
        /// </summary>
        private readonly string _stylesheetExtensionUri;

        public TestEntities(Stream stream)
        {
            using (var package = SpreadsheetDocument.Open(stream, false))
            {
                //Get Extension Uri value
                var timelineStyles = package.WorkbookPart.WorkbookStylesPart.Stylesheet.StylesheetExtensionList.Descendants<TimelineStyles>().Single();
                var stylesheetExtension = (StylesheetExtension)timelineStyles.Parent;

                _stylesheetExtensionUri = stylesheetExtension.Uri;

                Assert.NotNull(_stylesheetExtensionUri);
            }
        }

        /// <summary>
        /// Edit TimeLine attributes
        /// </summary>
        public void EditAttributes(Stream stream)
        {
            using (var package = SpreadsheetDocument.Open(stream, true))
            {
                //ShowTimeLevel
                GetTimeLine(package.WorkbookPart, TileLine01).ShowTimeLevel = true;
                GetTimeLine(package.WorkbookPart, TileLine02).ShowTimeLevel = false;

                //Cache
                GetTimeLine(package.WorkbookPart, TileLine03).Cache = "NativeTimeline_Date";
                GetTimeLine(package.WorkbookPart, TileLine04).Cache = "NativeTimeline_DeliveryDate";

                //ShowSelectionLabel
                GetTimeLine(package.WorkbookPart, TileLine05).ShowSelectionLabel = true;
                GetTimeLine(package.WorkbookPart, TileLine06).ShowSelectionLabel = false;

                //ShowHeader
                GetTimeLine(package.WorkbookPart, TileLine07).ShowHeader = true;
                GetTimeLine(package.WorkbookPart, TileLine08).ShowHeader = false;

                //Style
                GetTimeLine(package.WorkbookPart, TileLine09).Style = "TimeSlicerStyleLight2";
                GetTimeLine(package.WorkbookPart, TileLine10).Style = null;

                //Caption
                GetTimeLine(package.WorkbookPart, TileLine11).Caption = null;
                GetTimeLine(package.WorkbookPart, TileLine12).Caption = "0123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789";

                //ScrollPosition
                GetTimeLine(package.WorkbookPart, TileLine13).ScrollPosition = DateTime.Parse("1900-01-01");
                GetTimeLine(package.WorkbookPart, TileLine14).ScrollPosition = DateTime.Parse("2010-12-31");

                //Level
                GetTimeLine(package.WorkbookPart, TileLine15).Level.Value = 0U;
                GetTimeLine(package.WorkbookPart, TileLine16).Level.Value = 1U;
                GetTimeLine(package.WorkbookPart, TileLine17).Level.Value = 2U;
                GetTimeLine(package.WorkbookPart, TileLine18).Level.Value = 3U;

                //ShowHorizontalScrollbar
                GetTimeLine(package.WorkbookPart, TileLine19).ShowHorizontalScrollbar = true;
                GetTimeLine(package.WorkbookPart, TileLine20).ShowHorizontalScrollbar = false;

                //DefaultTimelineStyle attribute in TimelineStyle element
                var timelineStyles = package.WorkbookPart.WorkbookStylesPart.Stylesheet.StylesheetExtensionList.Descendants<TimelineStyles>().Single();
                timelineStyles.DefaultTimelineStyle.Value = timelineStyleName2;
            }
        }

        /// <summary>
        /// Verify the TileLine attributes value.
        /// </summary>
        public void VerifyEditedAttribute(Stream stream)
        {
            using (var package = SpreadsheetDocument.Open(stream, false))
            {
                //verify ShowTimeLevel
                Assert.True(GetTimeLine(package.WorkbookPart, TileLine01).ShowTimeLevel);
                Assert.False(GetTimeLine(package.WorkbookPart, TileLine02).ShowTimeLevel);

                //Verify Cache
                Assert.Equal("NativeTimeline_Date", GetTimeLine(package.WorkbookPart, TileLine03).Cache);
                Assert.Equal("NativeTimeline_DeliveryDate", GetTimeLine(package.WorkbookPart, TileLine04).Cache);

                //Verify ShowSelectionLabel
                Assert.True(GetTimeLine(package.WorkbookPart, TileLine05).ShowSelectionLabel);
                Assert.False(GetTimeLine(package.WorkbookPart, TileLine06).ShowSelectionLabel);

                //Verify ShowHeader
                Assert.True(GetTimeLine(package.WorkbookPart, TileLine07).ShowHeader);
                Assert.False(GetTimeLine(package.WorkbookPart, TileLine08).ShowHeader);

                //Verify Style
                Assert.Equal("TimeSlicerStyleLight2", GetTimeLine(package.WorkbookPart, TileLine09).Style);
                Assert.Null(GetTimeLine(package.WorkbookPart, TileLine10).Style);

                //Verify Caption
                Assert.Null(GetTimeLine(package.WorkbookPart, TileLine11).Caption);
                Assert.Equal("0123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789", GetTimeLine(package.WorkbookPart, TileLine12).Caption);

                //Verify ScrollPosition
                Assert.Equal(DateTime.Parse("1900-01-01"), GetTimeLine(package.WorkbookPart, TileLine13).ScrollPosition.Value);
                Assert.Equal(DateTime.Parse("2010-12-31"), GetTimeLine(package.WorkbookPart, TileLine14).ScrollPosition.Value);

                //Verify Level
                Assert.Equal(0U, GetTimeLine(package.WorkbookPart, TileLine15).Level.Value);
                Assert.Equal(1U, GetTimeLine(package.WorkbookPart, TileLine16).Level.Value);
                Assert.Equal(2U, GetTimeLine(package.WorkbookPart, TileLine17).Level.Value);
                Assert.Equal(3U, GetTimeLine(package.WorkbookPart, TileLine18).Level.Value);

                //Verify ShowHorizontalScrollbar
                Assert.True(GetTimeLine(package.WorkbookPart, TileLine19).ShowHorizontalScrollbar);
                Assert.False(GetTimeLine(package.WorkbookPart, TileLine20).ShowHorizontalScrollbar);

                //Verify DefaultTimelineStyle attribute in TimelineStyle element
                var timelineStyles = package.WorkbookPart.WorkbookStylesPart.Stylesheet.StylesheetExtensionList.Descendants<TimelineStyles>().Single();
                Assert.Equal(timelineStyleName2, timelineStyles.DefaultTimelineStyle);
            }
        }

        /// <summary>
        /// Delete TimelineStyles element
        /// </summary>
        public void DeleteTimelineStyle(Stream stream)
        {
            //Delete TimelineStyle
            using (var package = SpreadsheetDocument.Open(stream, true))
            {
                var timelineStyles = package.WorkbookPart.WorkbookStylesPart.Stylesheet.StylesheetExtensionList.Descendants<TimelineStyles>().Single();
                var stylesheetExtension = (StylesheetExtension)timelineStyles.Parent;

                timelineStyles.Remove();
                stylesheetExtension.Remove();
            }
        }

        /// <summary>
        /// Verify TimelineStyles element Deleted.
        /// </summary>
        public void VerifyDeletedTimelineStyle(Stream stream)
        {
            //Verify TimelineStyle Deleted
            using (var package = SpreadsheetDocument.Open(stream, false))
            {
                var stylesheetExtensions = package.WorkbookPart.WorkbookStylesPart.Stylesheet.StylesheetExtensionList.Descendants<StylesheetExtension>().Where(e => e.Uri == _stylesheetExtensionUri);
                Assert.Empty(stylesheetExtensions);

                var timelineStyles = package.WorkbookPart.WorkbookStylesPart.Stylesheet.StylesheetExtensionList.Descendants<TimelineStyles>();
                Assert.Empty(timelineStyles);
            }
        }

        /// <summary>
        /// Append TimelineStyle element.
        /// </summary>
        public void AddTimelineStyle(Stream stream)
        {
            //Add TimelineStyle
            using (var package = SpreadsheetDocument.Open(stream, true))
            {
                var stylesheetExtension = new StylesheetExtension() { Uri = _stylesheetExtensionUri };
                stylesheetExtension.AppendChild(new TimelineStyles() { DefaultTimelineStyle = timelineStyleName3 });
                package.WorkbookPart.WorkbookStylesPart.Stylesheet.StylesheetExtensionList.AppendChild<StylesheetExtension>(stylesheetExtension);
            }
        }

        /// <summary>
        /// Verify TimelineStyle Added.
        /// </summary>
        public void VerifyAddedTimelineStyle(Stream stream)
        {
            //Verify TimelineStyle added
            using (var package = SpreadsheetDocument.Open(stream, false))
            {
                var stylesheetExtensions = package.WorkbookPart.WorkbookStylesPart.Stylesheet.StylesheetExtensionList.Descendants<StylesheetExtension>().Where(e => e.Uri == _stylesheetExtensionUri);
                Assert.NotEmpty(stylesheetExtensions);

                var timelineStyles = package.WorkbookPart.WorkbookStylesPart.Stylesheet.StylesheetExtensionList.Descendants<TimelineStyles>().Single();
                Assert.Equal(timelineStyleName3, timelineStyles.DefaultTimelineStyle.Value);
            }
        }

        /// <summary>
        /// Retrieved by specifying a name from WorkbookPart to Timeline.
        /// </summary>
        /// <param name="workbookPart">Including Timeline in WorkbookPart</param>
        /// <param name="slicerName">Timeline name</param>
        /// <returns>Timeline name match Timeline</returns>
        private Timeline GetTimeLine(WorkbookPart workbookPart, string tileLineName)
        {
            foreach (var worksheetPart in workbookPart.WorksheetParts)
            {
                foreach (var timeLinePart in worksheetPart.TimeLineParts)
                {
                    foreach (Timeline timeline in timeLinePart.Timelines)
                    {
                        if (timeline.Name == tileLineName)
                        {
                            return timeline;
                        }
                    }
                }
            }

            return null;
        }
    }
}
