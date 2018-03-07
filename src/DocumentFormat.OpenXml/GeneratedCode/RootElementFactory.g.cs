// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using DocumentFormat.OpenXml;

namespace DocumentFormat.OpenXml{
internal static partial class RootElementFactory{
internal static OpenXmlElement CreateElement(byte namespaceId, string name){
if( 10 == namespaceId && "theme" == name)
    return new DocumentFormat.OpenXml.Drawing.Theme();
    
if( 10 == namespaceId && "themeOverride" == name)
    return new DocumentFormat.OpenXml.Drawing.ThemeOverride();
    
if( 10 == namespaceId && "tblStyleLst" == name)
    return new DocumentFormat.OpenXml.Drawing.TableStyleList();
    
if( 11 == namespaceId && "chartSpace" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.ChartSpace();
    
if( 11 == namespaceId && "userShapes" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.UserShapes();
    
if( 14 == namespaceId && "colorsDef" == name)
    return new DocumentFormat.OpenXml.Drawing.Diagrams.ColorsDefinition();
    
if( 14 == namespaceId && "dataModel" == name)
    return new DocumentFormat.OpenXml.Drawing.Diagrams.DataModelRoot();
    
if( 14 == namespaceId && "layoutDef" == name)
    return new DocumentFormat.OpenXml.Drawing.Diagrams.LayoutDefinition();
    
if( 14 == namespaceId && "styleDef" == name)
    return new DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinition();
    
if( 18 == namespaceId && "wsDr" == name)
    return new DocumentFormat.OpenXml.Drawing.Spreadsheet.WorksheetDrawing();
    
if( 8 == namespaceId && "additionalCharacteristics" == name)
    return new DocumentFormat.OpenXml.AdditionalCharacteristics.AdditionalCharacteristicsInfo();
    
if( 9 == namespaceId && "Sources" == name)
    return new DocumentFormat.OpenXml.Bibliography.Sources();
    
if( 20 == namespaceId && "datastoreItem" == name)
    return new DocumentFormat.OpenXml.CustomXmlDataProperties.DataStoreItem();
    
if( 4 == namespaceId && "Properties" == name)
    return new DocumentFormat.OpenXml.CustomProperties.Properties();
    
if( 3 == namespaceId && "Properties" == name)
    return new DocumentFormat.OpenXml.ExtendedProperties.Properties();
    
if( 22 == namespaceId && "calcChain" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.CalculationChain();
    
if( 22 == namespaceId && "comments" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.Comments();
    
if( 22 == namespaceId && "MapInfo" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.MapInfo();
    
if( 22 == namespaceId && "connections" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.Connections();
    
if( 22 == namespaceId && "pivotCacheDefinition" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.PivotCacheDefinition();
    
if( 22 == namespaceId && "pivotCacheRecords" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.PivotCacheRecords();
    
if( 22 == namespaceId && "pivotTableDefinition" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.PivotTableDefinition();
    
if( 22 == namespaceId && "queryTable" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.QueryTable();
    
if( 22 == namespaceId && "sst" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.SharedStringTable();
    
if( 22 == namespaceId && "headers" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.Headers();
    
if( 22 == namespaceId && "revisions" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.Revisions();
    
if( 22 == namespaceId && "users" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.Users();
    
if( 22 == namespaceId && "worksheet" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.Worksheet();
    
if( 22 == namespaceId && "chartsheet" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.Chartsheet();
    
if( 22 == namespaceId && "dialogsheet" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.DialogSheet();
    
if( 22 == namespaceId && "metadata" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.Metadata();
    
if( 22 == namespaceId && "singleXmlCells" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.SingleXmlCells();
    
if( 22 == namespaceId && "styleSheet" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.Stylesheet();
    
if( 22 == namespaceId && "externalLink" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.ExternalLink();
    
if( 22 == namespaceId && "table" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.Table();
    
if( 22 == namespaceId && "volTypes" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.VolatileTypes();
    
if( 22 == namespaceId && "workbook" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.Workbook();
    
if( 23 == namespaceId && "recipients" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.Recipients();
    
if( 23 == namespaceId && "comments" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.Comments();
    
if( 23 == namespaceId && "footnotes" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.Footnotes();
    
if( 23 == namespaceId && "endnotes" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.Endnotes();
    
if( 23 == namespaceId && "hdr" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.Header();
    
if( 23 == namespaceId && "ftr" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.Footer();
    
if( 23 == namespaceId && "settings" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.Settings();
    
if( 23 == namespaceId && "webSettings" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.WebSettings();
    
if( 23 == namespaceId && "fonts" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.Fonts();
    
if( 23 == namespaceId && "numbering" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.Numbering();
    
if( 23 == namespaceId && "styles" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.Styles();
    
if( 23 == namespaceId && "document" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.Document();
    
if( 23 == namespaceId && "glossaryDocument" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.GlossaryDocument();
    
if( 24 == namespaceId && "cmAuthorLst" == name)
    return new DocumentFormat.OpenXml.Presentation.CommentAuthorList();
    
if( 24 == namespaceId && "cmLst" == name)
    return new DocumentFormat.OpenXml.Presentation.CommentList();
    
if( 24 == namespaceId && "presentation" == name)
    return new DocumentFormat.OpenXml.Presentation.Presentation();
    
if( 24 == namespaceId && "presentationPr" == name)
    return new DocumentFormat.OpenXml.Presentation.PresentationProperties();
    
if( 24 == namespaceId && "sld" == name)
    return new DocumentFormat.OpenXml.Presentation.Slide();
    
if( 24 == namespaceId && "sldLayout" == name)
    return new DocumentFormat.OpenXml.Presentation.SlideLayout();
    
if( 24 == namespaceId && "sldMaster" == name)
    return new DocumentFormat.OpenXml.Presentation.SlideMaster();
    
if( 24 == namespaceId && "handoutMaster" == name)
    return new DocumentFormat.OpenXml.Presentation.HandoutMaster();
    
if( 24 == namespaceId && "notesMaster" == name)
    return new DocumentFormat.OpenXml.Presentation.NotesMaster();
    
if( 24 == namespaceId && "notes" == name)
    return new DocumentFormat.OpenXml.Presentation.NotesSlide();
    
if( 24 == namespaceId && "sldSyncPr" == name)
    return new DocumentFormat.OpenXml.Presentation.SlideSyncProperties();
    
if( 24 == namespaceId && "tagLst" == name)
    return new DocumentFormat.OpenXml.Presentation.TagList();
    
if( 24 == namespaceId && "viewPr" == name)
    return new DocumentFormat.OpenXml.Presentation.ViewProperties();
    
if( 32 == namespaceId && "macrosheet" == name)
    return new DocumentFormat.OpenXml.Office.Excel.Macrosheet();
    
if( 32 == namespaceId && "worksheetSortMap" == name)
    return new DocumentFormat.OpenXml.Office.Excel.WorksheetSortMap();
    
if( 33 == namespaceId && "tcg" == name)
    return new DocumentFormat.OpenXml.Office.Word.TemplateCommandGroup();
    
if( 33 == namespaceId && "vbaSuppData" == name)
    return new DocumentFormat.OpenXml.Office.Word.VbaSuppData();
    
if( 33 == namespaceId && "recipients" == name)
    return new DocumentFormat.OpenXml.Office.Word.MailMergeRecipients();
    
if( 34 == namespaceId && "customUI" == name)
    return new DocumentFormat.OpenXml.Office.CustomUI.CustomUI();
    
if( 43 == namespaceId && "ink" == name)
    return new DocumentFormat.OpenXml.InkML.Ink();
    
if( 53 == namespaceId && "datastoreItem" == name)
    return new DocumentFormat.OpenXml.Office2010.Excel.DatastoreItem();
    
if( 53 == namespaceId && "formControlPr" == name)
    return new DocumentFormat.OpenXml.Office2010.Excel.FormControlProperties();
    
if( 53 == namespaceId && "slicers" == name)
    return new DocumentFormat.OpenXml.Office2010.Excel.Slicers();
    
if( 53 == namespaceId && "slicerCacheDefinition" == name)
    return new DocumentFormat.OpenXml.Office2010.Excel.SlicerCacheDefinition();
    
if( 56 == namespaceId && "drawing" == name)
    return new DocumentFormat.OpenXml.Office.Drawing.Drawing();
    
if( 57 == namespaceId && "customUI" == name)
    return new DocumentFormat.OpenXml.Office2010.CustomUI.CustomUI();
    
if( 65 == namespaceId && "colorStyle" == name)
    return new DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ColorStyle();
    
if( 65 == namespaceId && "chartStyle" == name)
    return new DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle();
    
if( 66 == namespaceId && "webextension" == name)
    return new DocumentFormat.OpenXml.Office2013.WebExtension.WebExtension();
    
if( 69 == namespaceId && "commentsEx" == name)
    return new DocumentFormat.OpenXml.Office2013.Word.CommentsEx();
    
if( 69 == namespaceId && "people" == name)
    return new DocumentFormat.OpenXml.Office2013.Word.People();
    
if( 70 == namespaceId && "taskpanes" == name)
    return new DocumentFormat.OpenXml.Office2013.WebExtentionPane.Taskpanes();
    
if( 71 == namespaceId && "timelines" == name)
    return new DocumentFormat.OpenXml.Office2013.Excel.Timelines();
    
if( 71 == namespaceId && "timelineCacheDefinition" == name)
    return new DocumentFormat.OpenXml.Office2013.Excel.TimelineCacheDefinition();
    
return null;
}
}
}
