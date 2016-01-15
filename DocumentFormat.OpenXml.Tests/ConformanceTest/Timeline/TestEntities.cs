// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentFormat.OpenXml.Tests.TimeLine
{
    using DocumentFormat.OpenXml;
    using DocumentFormat.OpenXml.Packaging;
    using DocumentFormat.OpenXml.Spreadsheet;
    using X15 = DocumentFormat.OpenXml.Office2013.Excel;
    using Xdr = DocumentFormat.OpenXml.Drawing.Spreadsheet;
    using Tsle = DocumentFormat.OpenXml.Office2013.Drawing.TimeSlicer;
    using LogUtil;

    public class TestEntities
    {
        #region Setting values
        //TileLine names
        private readonly string TileLine01 = "DeliveryDate 10";
        private readonly string TileLine02 = "DeliveryDate 11";
        private readonly string TileLine03 = "Date";
        private readonly string TileLine04 = "Date 1";
        private readonly string TileLine05 = "DeliveryDate 8";
        private readonly string TileLine06 = "DeliveryDate 9";
        private readonly string TileLine07 = "DeliveryDate 6";
        private readonly string TileLine08 = "DeliveryDate 7";
        private readonly string TileLine09 = "DeliveryDate 16";
        private readonly string TileLine10 = "DeliveryDate 17";
        private readonly string TileLine11 = "DeliveryDate 4";
        private readonly string TileLine12 = "DeliveryDate 5";
        private readonly string TileLine13 = "DeliveryDate 14";
        private readonly string TileLine14 = "DeliveryDate 15";
        private readonly string TileLine15 = "DeliveryDate";
        private readonly string TileLine16 = "DeliveryDate 1";
        private readonly string TileLine17 = "DeliveryDate 2";
        private readonly string TileLine18 = "DeliveryDate 3";
        private readonly string TileLine19 = "DeliveryDate 12";
        private readonly string TileLine20 = "DeliveryDate 13";

        //TimeLine Style Names
        private readonly string timelineStyleName2 = "TimeSlicerStyleLight2";
        private readonly string timelineStyleName3 = "TimeSlicerStyleLight3";
        #endregion

        #region Property
        /// <summary>
        /// URI attribute value of PresentationExtension.(Parent of X15.TimelineStyles elemenet)
        /// </summary>
        private string StylesheetExtensionUri { get; set; }
        #endregion

        /// <summary>
        /// Constructor
        /// Get URI attribute value of StylesheetExtension
        /// </summary>
        /// <param name="filePath">Generated file path</param>
        public TestEntities(string filePath)
        {
            using (SpreadsheetDocument package = SpreadsheetDocument.Open(filePath, false))
            {
                //Get Extension Uri value
                X15.TimelineStyles timelineStyles = package.WorkbookPart.WorkbookStylesPart.Stylesheet.StylesheetExtensionList.Descendants<X15.TimelineStyles>().Single();
                StylesheetExtension stylesheetExtension = (StylesheetExtension)timelineStyles.Parent;
                this.StylesheetExtensionUri = stylesheetExtension.Uri;

                if (string.IsNullOrEmpty(this.StylesheetExtensionUri))
                    throw new Exception("Uri attribute value in Extension element is not set.");
            }
        }

        /// <summary>
        /// Edit TimeLine attributes
        /// </summary>
        /// <param name="filePath">Editing target file path</param>
        /// <param name="log">Logger</param>
        public void EditAttributes(string filePath, VerifiableLog log)
        {
            using (SpreadsheetDocument package = SpreadsheetDocument.Open(filePath, true))
            {
                X15.Timeline timeline = null;

                //ShowTimeLevel
                timeline = GetTimeLine(package.WorkbookPart, this.TileLine01);
                timeline.ShowTimeLevel = true;
                log.Pass("Set \"ShowTimeLevel\" attribute, timeline control name is \"{0}\". set value is true.", timeline.Name);

                timeline = GetTimeLine(package.WorkbookPart, this.TileLine02);
                timeline.ShowTimeLevel = false;
                log.Pass("Set \"ShowTimeLevel\" attribute. timeline control name is \"{0}\". set value is false.", timeline.Name);

                //Cache
                timeline = GetTimeLine(package.WorkbookPart, this.TileLine03);
                timeline.Cache = "NativeTimeline_Date";
                log.Pass("Set \"Cache\" attribute. timeline control name is \"{0}\". set value is \"NativeTimeline_Date\".", timeline.Name);

                timeline = GetTimeLine(package.WorkbookPart, this.TileLine04);
                timeline.Cache = "NativeTimeline_DeliveryDate";
                log.Pass("Set \"Cache\" attribute. timeline control name is \"{0}\". set value is \"NativeTimeline_DeliveryDate\".", timeline.Name);

                //ShowSelectionLabel
                timeline = GetTimeLine(package.WorkbookPart, this.TileLine05);
                timeline.ShowSelectionLabel = true;
                log.Pass("Set \"ShowSelectionLabel\" attribute. timeline control name is \"{0}\". set value is true.", timeline.Name);

                timeline = GetTimeLine(package.WorkbookPart, this.TileLine06);
                timeline.ShowSelectionLabel = false;
                log.Pass("Set \"ShowSelectionLabel\" attribute. timeline control name is \"{0}\". set value is false.", timeline.Name);

                //ShowHeader
                timeline = GetTimeLine(package.WorkbookPart, this.TileLine07);
                timeline.ShowHeader = true;
                log.Pass("Set \"ShowHeader\" attribute. timeline control name is \"{0}\". set value is true.", timeline.Name);

                timeline = GetTimeLine(package.WorkbookPart, this.TileLine08);
                timeline.ShowHeader = false;
                log.Pass("Set \"ShowHeader\" attribute. timeline control name is \"{0}\". set value is false.", timeline.Name);

                //Style
                timeline = GetTimeLine(package.WorkbookPart, this.TileLine09);
                timeline.Style = "TimeSlicerStyleLight2";
                log.Pass("Set \"Style\" attribute. timeline control name is \"{0}\". set value is \"TimeSlicerStyleLight2\".", timeline.Name);

                timeline = GetTimeLine(package.WorkbookPart, this.TileLine10);
                timeline.Style = null;
                log.Pass("Set \"Style\" attribute. timeline control name is \"{0}\". set value is null.", timeline.Name);

                //Caption
                timeline = GetTimeLine(package.WorkbookPart, this.TileLine11);
                timeline.Caption = null;
                log.Pass("Set \"Caption\" attribute. timeline control name is \"{0}\". set value is null.", timeline.Name);

                timeline = GetTimeLine(package.WorkbookPart, this.TileLine12);
                timeline.Caption = "0123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789";
                log.Pass("Set \"Caption\" attribute. timeline control name is \"{0}\". set value is \"0123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789\".", timeline.Name);

                //ScrollPosition
                timeline = GetTimeLine(package.WorkbookPart, this.TileLine13);
                timeline.ScrollPosition = DateTime.Parse("1900-01-01");
                log.Pass("Set \"ScrollPosition\" attribute. timeline control name is \"{0}\". set value is \"1900-01-01\".", timeline.Name);

                timeline = GetTimeLine(package.WorkbookPart, this.TileLine14);
                timeline.ScrollPosition = DateTime.Parse("2010-12-31");
                log.Pass("Set \"ScrollPosition\" attribute. timeline control name is \"{0}\". set value is \"2010-12-31\".", timeline.Name);

                //Level
                timeline = GetTimeLine(package.WorkbookPart, this.TileLine15);
                timeline.Level.Value = 0U;
                log.Pass("Set \"ScrollPosition\" attribute. timeline control name is \"{0}\". set value is 0(Years).", timeline.Name);

                timeline = GetTimeLine(package.WorkbookPart, this.TileLine16);
                timeline.Level.Value = 1U;
                log.Pass("Set \"ScrollPosition\" attribute. timeline control name is \"{0}\". set value is 1(Quarters).", timeline.Name);

                timeline = GetTimeLine(package.WorkbookPart, this.TileLine17);
                timeline.Level.Value = 2U;
                log.Pass("Set \"ScrollPosition\" attribute. timeline control name is \"{0}\". set value is 2(Months).", timeline.Name);

                timeline = GetTimeLine(package.WorkbookPart, this.TileLine18);
                timeline.Level.Value = 3U;
                log.Pass("Set \"ScrollPosition\" attribute. timeline control name is \"{0}\". set value is 3(Days).", timeline.Name);

                //ShowHorizontalScrollbar
                timeline = GetTimeLine(package.WorkbookPart, this.TileLine19);
                timeline.ShowHorizontalScrollbar = true;
                log.Pass("Set \"ShowHorizontalScrollbar\" attribute. timeline control name is \"{0}\". set value is true.", timeline.Name);

                timeline = GetTimeLine(package.WorkbookPart, this.TileLine20);
                timeline.ShowHorizontalScrollbar = false;
                log.Pass("Set \"ShowHorizontalScrollbar\" attribute. timeline control name is \"{0}\". set value is false.", timeline.Name);

                //DefaultTimelineStyle attribute in TimelineStyle element
                X15.TimelineStyles timelineStyles = package.WorkbookPart.WorkbookStylesPart.Stylesheet.StylesheetExtensionList.Descendants<X15.TimelineStyles>().Single();
                timelineStyles.DefaultTimelineStyle.Value = this.timelineStyleName2;

                log.Pass("Set DefaultTimelineStyle attribute value in \"X15.TimelineStyles\" element. Set value is [{0}].", this.timelineStyleName2);
            }
        }

        /// <summary>
        /// Verify the TileLine attributes value.
        /// </summary>
        /// <param name="filePath">Target file path</param>
        /// <param name="log">Logger</param>
        public void VerifyEditedAttribute(string filePath, VerifiableLog log)
        {
            using (SpreadsheetDocument package = SpreadsheetDocument.Open(filePath, false))
            {
                X15.Timeline timeline = null;

                //verify ShowTimeLevel
                timeline = GetTimeLine(package.WorkbookPart, this.TileLine01);
                log.Verify(timeline.ShowTimeLevel == true, "Timeline control in \"ShowTimeLevel\" attribute value is Verify. Name=[{0}],Value=[true].", timeline.Name);

                timeline = GetTimeLine(package.WorkbookPart, this.TileLine02);
                log.Verify(timeline.ShowTimeLevel == false, "Timeline control in \"ShowTimeLevel\" attribute value is Verify. Name=[{0}],Value=[false].", timeline.Name);

                //Verify Cache
                timeline = GetTimeLine(package.WorkbookPart, this.TileLine03);
                log.Verify(timeline.Cache == "NativeTimeline_Date", "Timeline control in Cache attribute value is Verify. Name=[{0}],Value=[{1}].", timeline.Name, timeline.Cache);

                timeline = GetTimeLine(package.WorkbookPart, this.TileLine04);
                log.Verify(timeline.Cache == "NativeTimeline_DeliveryDate", "Timeline control in Cache attribute value is Verify. Name=[{0}],Value=[{1}].", timeline.Name, timeline.Cache);

                //Verify ShowSelectionLabel
                timeline = GetTimeLine(package.WorkbookPart, this.TileLine05);
                log.Verify(timeline.ShowSelectionLabel, "Timeline control in \"ShowSelectionLabel\" attribute value is Verify. Name=[{0}],Value=[true].", timeline.Name);

                timeline = GetTimeLine(package.WorkbookPart, this.TileLine06);
                log.Verify(timeline.ShowSelectionLabel == false, "Timeline control in \"ShowSelectionLabel\" attribute value is Verify. Name=[{0}],Value=[false].", timeline.Name);

                //Verify ShowHeader
                timeline = GetTimeLine(package.WorkbookPart, this.TileLine07);
                log.Verify(timeline.ShowHeader == true, "Timeline control in \"ShowHeader\" attribute value is Verify. Name=[{0}],Value=[true].", timeline.Name);

                timeline = GetTimeLine(package.WorkbookPart, this.TileLine08);
                log.Verify(timeline.ShowHeader == false, "Timeline control in \"ShowHeader\" attribute value is Verify. Name=[{0}],Value=[false].", timeline.Name);

                //Verify Style
                timeline = GetTimeLine(package.WorkbookPart, this.TileLine09);
                log.Verify(timeline.Style == "TimeSlicerStyleLight2", "Timeline control in \"Style\" attribute value is Verify. Name=[{0}],Value=[{1}].", timeline.Name, timeline.Style);

                timeline = GetTimeLine(package.WorkbookPart, this.TileLine10);
                log.Verify(timeline.Style == null, "Timeline control in \"Style\" attribute value is Verify. Name=[{0}],Value=[{1}].", timeline.Name, timeline.Style);

                //Verify Caption
                timeline = GetTimeLine(package.WorkbookPart, this.TileLine11);
                log.Verify(timeline.Caption == null, "Timeline control in \"Caption\" attribute value is Verify. Name=[{0}],Value=[{1}].", timeline.Name, timeline.Caption);

                timeline = GetTimeLine(package.WorkbookPart, this.TileLine12);
                log.Verify(timeline.Caption == "0123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789", "Timeline control in \"Caption\" attribute value is Verify. Name=[{0}],Value=[{1}].", timeline.Name, timeline.Caption);

                //Verify ScrollPosition
                timeline = GetTimeLine(package.WorkbookPart, this.TileLine13);
                log.Verify(timeline.ScrollPosition.Value == DateTime.Parse("1900-01-01"), "Timeline control in \"ScrollPosition\" attribute value is Verify. Name=[{0}],Value=[{1}].", timeline.Name, timeline.ScrollPosition);

                timeline = GetTimeLine(package.WorkbookPart, this.TileLine14);
                log.Verify(timeline.ScrollPosition.Value == DateTime.Parse("2010-12-31"), "Timeline control in \"ScrollPosition\" attribute value is Verify. Name=[{0}],Value=[{1}].", timeline.Name, timeline.ScrollPosition);

                //Verify Level
                timeline = GetTimeLine(package.WorkbookPart, this.TileLine15);
                log.Verify(timeline.Level == 0U, "Timeline control in \"Level\" attribute value is Verify. Name=[{0}],Value=[{1}].", timeline.Name, timeline.Level);

                timeline = GetTimeLine(package.WorkbookPart, this.TileLine16);
                log.Verify(timeline.Level == 1U, "Timeline control in \"Level\" attribute value is Verify. Name=[{0}],Value=[{1}].", timeline.Name, timeline.Level);

                timeline = GetTimeLine(package.WorkbookPart, this.TileLine17);
                log.Verify(timeline.Level == 2U, "Timeline control in \"Level\" attribute value is Verify. Name=[{0}],Value=[{1}].", timeline.Name, timeline.Level);

                timeline = GetTimeLine(package.WorkbookPart, this.TileLine18);
                log.Verify(timeline.Level == 3U, "Timeline control in \"Level\" attribute value is Verify. Name=[{0}],Value=[{1}].", timeline.Name, timeline.Level);

                //Verify ShowHorizontalScrollbar
                timeline = GetTimeLine(package.WorkbookPart, this.TileLine19);
                log.Verify(timeline.ShowHorizontalScrollbar, "Timeline control in \"ShowHorizontalScrollbar\" attribute value is Verify. Name=[{0}],Value=[true].", timeline.Name);

                timeline = GetTimeLine(package.WorkbookPart, this.TileLine20);
                log.Verify(timeline.ShowHorizontalScrollbar == false, "Timeline control in \"ShowHorizontalScrollbar\" attribute value is Verify. Name=[{0}],Value=[false].", timeline.Name);

                //Verify DefaultTimelineStyle attribute in TimelineStyle element
                X15.TimelineStyles timelineStyles = package.WorkbookPart.WorkbookStylesPart.Stylesheet.StylesheetExtensionList.Descendants<X15.TimelineStyles>().Single();
                log.Verify(timelineStyles.DefaultTimelineStyle == this.timelineStyleName2, "Verify \"DefaultTimelineStyle\" attribute. Value=[{0}]", timelineStyles.DefaultTimelineStyle);
            }
        }

        /// <summary>
        /// Delete TimeLine elements and related elements
        /// </summary>
        /// <param name="filePath">Deleting target file path</param>
        /// <param name="log">Logger</param>
        public void DeleteElements(string filePath, VerifiableLog log)
        {
            using (SpreadsheetDocument package = SpreadsheetDocument.Open(filePath, true))
            {
                // 1)TimeLineCacheParts delete
                package.WorkbookPart.DeleteParts<TimeLineCachePart>(package.WorkbookPart.TimeLineCacheParts);
                log.Pass("TimeLineCacheParts delete");

                // 2)"timelineCacheRefs" element inner element is delete(="ext" element delete)
                foreach (X15.TimelineCacheReference timelineCacheReference in package.WorkbookPart.RootElement.Descendants<X15.TimelineCacheReference>())
                {
                    timelineCacheReference.Remove();
                }
                log.Pass("\"timelineCacheRef\" element delete");

                package.WorkbookPart.RootElement.Descendants<X15.TimelineCacheReferences>().Single().Remove();
                log.Pass("\"timelineCacheRefs\" element delete");

                // 3)"timelineRefs" element inner element is delete(="ext" element delete)
                foreach (WorksheetPart worksheetPart in package.WorkbookPart.WorksheetParts)
                {
                    foreach (var timelineReference in worksheetPart.RootElement.Descendants<X15.TimelineReference>().Reverse())
                    {
                        timelineReference.Remove();
                    }
                    foreach (var timelineRefs in worksheetPart.RootElement.Descendants<X15.TimelineReferences>())
                    {
                        timelineRefs.Remove();
                    }
                }
                log.Pass("\"timelineRef\" element delete");
                log.Pass("\"timelineRefs\" element delete");

                // 4)TimeLineParts delete
                foreach (WorksheetPart worksheetPart in package.WorkbookPart.WorksheetParts)
                {
                    if (worksheetPart.TimeLineParts != null)
                    {
                        worksheetPart.DeleteParts<TimeLinePart>(worksheetPart.TimeLineParts);
                    }
                }
                log.Pass("TimeLineParts delete");

                // 5)"timeslicer" element inner element is delete(="twoCellAnchor" element delete)
                foreach (WorksheetPart worksheetPart in package.WorkbookPart.WorksheetParts)
                {
                    if (worksheetPart.DrawingsPart != null)
                    {
                        foreach (Xdr.TwoCellAnchor twoCellAnchor in worksheetPart.DrawingsPart.WorksheetDrawing.Reverse())
                        {
                            var children = twoCellAnchor.Descendants<Tsle.TimeSlicer>();

                            if (children.Count() > 0)
                            {
                                twoCellAnchor.Remove();
                                log.Pass("TimeSlicer element is detected and the parent element is removed");
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Verify Deleted TimeLine elements.
        /// </summary>
        /// <param name="filePath">Target file path</param>
        /// <param name="log">Logger</param>
        public void VerifyDeletedElements(string filePath, VerifiableLog log)
        {
            using (SpreadsheetDocument package = SpreadsheetDocument.Open(filePath, false))
            {
                // 1)Check is TimeLineCacheParts delete
                log.Verify(package.WorkbookPart.TimeLineCacheParts.Count<TimeLineCachePart>() == 0, "TimeLineCacheParts is exist. I'ts contents a TimeLineCachePart count={0}.)", package.WorkbookPart.TimeLineCacheParts.Count<TimeLineCachePart>());

                // 2)Check is timelineCacheRefs element inner element delete
                log.Verify(package.WorkbookPart.RootElement.Descendants<X15.TimelineCacheReference>().Count() == 0, "TimelineCacheRef element is exist.");

                log.Verify(package.WorkbookPart.RootElement.Descendants<X15.TimelineCacheReferences>().Count() == 0, "TimelineCacheRefs element is exist.");

                // 3)Check is timelineRefs element inner element delete(="ext" element delete)
                foreach (WorksheetPart worksheetPart in package.WorkbookPart.WorksheetParts)
                {
                    log.Verify(worksheetPart.RootElement.Descendants<X15.TimelineReference>().Count() == 0, "TimelineRef element is exist.");

                    log.Verify(worksheetPart.RootElement.Descendants<X15.TimelineReferences>().Count() == 0, "TimelineRefs element is exist.");
                }

                // 4)Check is TimeLineParts delete
                foreach (WorksheetPart worksheetPart in package.WorkbookPart.WorksheetParts)
                {
                    log.Verify(worksheetPart.TimeLineParts.Count<TimeLinePart>() == 0, "TimeLinePart is exist.");
                }

                // 5)Check is timeslicer element inner element delete(="ext" element delete)
                foreach (WorksheetPart worksheetPart in package.WorkbookPart.WorksheetParts)
                {
                    if (worksheetPart.DrawingsPart != null)
                    {
                        foreach (Xdr.TwoCellAnchor twoCellAnchor in worksheetPart.DrawingsPart.WorksheetDrawing)
                        {
                            var children = twoCellAnchor.Descendants<Tsle.TimeSlicer>();
                            log.Verify(children.Count() == 0, "TimeSlicer element does not exist");
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Delete X15.TimelineStyles element
        /// </summary>
        /// <param name="filePath">Target file path</param>
        /// <param name="log">Logger</param>
        public void DeleteTimelineStyle(string filePath, VerifiableLog log)
        {
            //Delete TimelineStyle
            using (SpreadsheetDocument package = SpreadsheetDocument.Open(filePath, true))
            {
                X15.TimelineStyles timelineStyles = package.WorkbookPart.WorkbookStylesPart.Stylesheet.StylesheetExtensionList.Descendants<X15.TimelineStyles>().Single();
                StylesheetExtension stylesheetExtension = (StylesheetExtension)timelineStyles.Parent;

                timelineStyles.Remove();
                log.Pass("Deleted X15.TimelineStyles element.");

                stylesheetExtension.Remove();
                log.Pass("Deleted X15.TimelineStyles extension element.");
            }
        }

        /// <summary>
        /// Verify X15.TimelineStyles element Deleted.
        /// </summary>
        /// <param name="filePath">Target file path</param>
        /// <param name="log">Logger</param>
        public void VerifyDeletedTimelineStyle(string filePath, VerifiableLog log)
        {
            //Verify TimelineStyle Deleted
            using (SpreadsheetDocument package = SpreadsheetDocument.Open(filePath, false))
            {
                int stylesheetExtensionCount = package.WorkbookPart.WorkbookStylesPart.Stylesheet.StylesheetExtensionList.Descendants<StylesheetExtension>().Where(e => e.Uri == this.StylesheetExtensionUri).Count();
                log.Verify(stylesheetExtensionCount == 0, "X15.TimelineStyles extension element exist.");

                int timelineStylesCount = package.WorkbookPart.WorkbookStylesPart.Stylesheet.StylesheetExtensionList.Descendants<X15.TimelineStyles>().Count();
                log.Verify(timelineStylesCount == 0, "X15.TimelineStyles extension element exist.");
            }
        }

        /// <summary>
        /// Append TimelineStyle element.
        /// </summary>
        /// <param name="filePath">Target file path</param>
        /// <param name="log">Logger</param>
        public void AddTimelineStyle(string filePath, VerifiableLog log)
        {
            //Add TimelineStyle
            using (SpreadsheetDocument package = SpreadsheetDocument.Open(filePath, true))
            {
                StylesheetExtension stylesheetExtension = new StylesheetExtension() { Uri = this.StylesheetExtensionUri };
                stylesheetExtension.AppendChild<X15.TimelineStyles>(new X15.TimelineStyles() { DefaultTimelineStyle = this.timelineStyleName3 });
                package.WorkbookPart.WorkbookStylesPart.Stylesheet.StylesheetExtensionList.AppendChild<StylesheetExtension>(stylesheetExtension);

                log.Pass("Append TimelineStyle element. DefaultTimelineStyle attribute value=[{0}]", this.timelineStyleName3);
            }
        }

        /// <summary>
        /// Verify TimelineStyle Added.
        /// </summary>
        /// <param name="filePath">Target file path</param>
        /// <param name="log">Logger</param>
        public void VerifyAddedTimelineStyle(string filePath, VerifiableLog log)
        {
            //Verify TimelineStyle added
            using (SpreadsheetDocument package = SpreadsheetDocument.Open(filePath, false))
            {
                int stylesheetExtensionCount = package.WorkbookPart.WorkbookStylesPart.Stylesheet.StylesheetExtensionList.Descendants<StylesheetExtension>().Where(e => e.Uri == this.StylesheetExtensionUri).Count();
                log.Verify(stylesheetExtensionCount != 0, "X15.TimelineStyles extension element exist.");

                X15.TimelineStyles timelineStyles = package.WorkbookPart.WorkbookStylesPart.Stylesheet.StylesheetExtensionList.Descendants<X15.TimelineStyles>().Single();
                log.Verify(timelineStyles.DefaultTimelineStyle.Value == this.timelineStyleName3, "Verify DefaultTimelineStyle attribute value in X15.TimelineStyles element. DefaultTimelineStyle attribute value=[{0}]", timelineStyles.DefaultTimelineStyle.Value);
            }
        }

        /// <summary>
        /// Retrieved by specifying a name from WorkbookPart to X15.Timeline.
        /// </summary>
        /// <param name="workbookPart">Including X15.Timeline in WorkbookPart</param>
        /// <param name="slicerName">Timeline name</param>
        /// <returns>Timeline name match X15.Timeline</returns>
        private X15.Timeline GetTimeLine(WorkbookPart workbookPart, string tileLineName)
        {
            X15.Timeline returnTimeline = null;

            foreach (WorksheetPart worksheetPart in workbookPart.WorksheetParts)
            {
                foreach (TimeLinePart timeLinePart in worksheetPart.TimeLineParts)
                {
                    foreach (X15.Timeline timeline in timeLinePart.Timelines)
                    {
                        if (timeline.Name == tileLineName)
                        {
                            returnTimeline = timeline;
                            break;
                        }
                    }
                    if (returnTimeline != null)
                        break;
                }
                if (returnTimeline != null)
                    break;
            }

            return returnTimeline;
        }
    }
}
