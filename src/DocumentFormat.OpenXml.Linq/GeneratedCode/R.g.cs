// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:r="http://schemas.openxmlformats.org/officeDocument/2006/relationships" namespace.
    /// </summary>
    public static class R
    {
        /// <summary>
        /// Defines the XML namespace associated with the r prefix.
        /// </summary>
        public static readonly XNamespace r = "http://schemas.openxmlformats.org/officeDocument/2006/relationships";

        /// <summary>
        /// Represents the r:blip XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="DGM.shape" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Shape.Blip.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName blip = r + "blip";

        /// <summary>
        /// Represents the r:cs XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="DGM.relIds" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: RelationshipIds.ColorPart.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cs = r + "cs";

        /// <summary>
        /// Represents the r:dm XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="DGM.relIds" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: RelationshipIds.DataPart.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dm = r + "dm";

        /// <summary>
        /// Represents the r:embed XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="A.blip" />, <see cref="A.snd" />, <see cref="A.wavAudioFile" />, <see cref="A14.imgLayer" />, <see cref="ASVG.svgBlip" />, <see cref="P.snd" />, <see cref="P.sndTgt" />, <see cref="P14.media" />, <see cref="WE.snapshot" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Blip.Embed, HyperlinkSound.Embed, ImageLayer.Embed, Media.Embed, Snapshot.Embed, Sound.Embed, SoundTarget.Embed, SVGBlip.Embed, WaveAudioFile.Embed.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName embed = r + "embed";

        /// <summary>
        /// Represents the r:href XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="V.imagedata" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: ImageData.RelHref.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName href = r + "href";

        /// <summary>
        /// Represents the r:id XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="A.hlinkClick" />, <see cref="A.hlinkHover" />, <see cref="A.hlinkMouseOver" />, <see cref="A14.contentPart" />, <see cref="A1611.picAttrSrcUrl" />, <see cref="C.chart" />, <see cref="C.externalData" />, <see cref="C.legacyDrawingHF" />, <see cref="C.userShapes" />, <see cref="CDR14.contentPart" />, <see cref="CX.externalData" />, <see cref="O.OLEObject" />, <see cref="P.bold" />, <see cref="P.boldItalic" />, <see cref="P.contentPart" />, <see cref="P.control" />, <see cref="P.custData" />, <see cref="P.handoutMasterId" />, <see cref="P.htmlPubPr" />, <see cref="P.italic" />, <see cref="P.notesMasterId" />, <see cref="P.oleObj" />, <see cref="P.regular" />, <see cref="P.sld" />, <see cref="P.sldId" />, <see cref="P.sldLayoutId" />, <see cref="P.sldMasterId" />, <see cref="P.tags" />, <see cref="V.fill" />, <see cref="V.imagedata" />, <see cref="V.stroke" />, <see cref="W.altChunk" />, <see cref="W.attachedTemplate" />, <see cref="W.contentPart" />, <see cref="W.control" />, <see cref="W.dataSource" />, <see cref="W.embedBold" />, <see cref="W.embedBoldItalic" />, <see cref="W.embedItalic" />, <see cref="W.embedRegular" />, <see cref="W.footerReference" />, <see cref="W.headerReference" />, <see cref="W.headerSource" />, <see cref="W.hyperlink" />, <see cref="W.movie" />, <see cref="W.objectEmbed" />, <see cref="W.objectLink" />, <see cref="W.printerSettings" />, <see cref="W.recipientData" />, <see cref="W.saveThroughXslt" />, <see cref="W.sourceFileName" />, <see cref="W.src" />, <see cref="W.subDoc" />, <see cref="W14.contentPart" />, <see cref="WE.webextensionref" />, <see cref="WETP.webextensionref" />, <see cref="WNE.toolbarData" />, <see cref="X.control" />, <see cref="X.controlPr" />, <see cref="X.customPr" />, <see cref="X.dataRef" />, <see cref="X.drawing" />, <see cref="X.drawingHF" />, <see cref="X.externalBook" />, <see cref="X.externalReference" />, <see cref="X.header" />, <see cref="X.hyperlink" />, <see cref="X.legacyDrawing" />, <see cref="X.legacyDrawingHF" />, <see cref="X.objectPr" />, <see cref="X.oleLink" />, <see cref="X.oleObject" />, <see cref="X.pageSetup" />, <see cref="X.picture" />, <see cref="X.pivotCache" />, <see cref="X.pivotCacheDefinition" />, <see cref="X.pivotSelection" />, <see cref="X.rangeSet" />, <see cref="X.sheet" />, <see cref="X.tablePart" />, <see cref="X.worksheetSource" />, <see cref="X14.slicer" />, <see cref="X14.slicerCache" />, <see cref="X15.pivotTableReference" />, <see cref="X15.timelineCacheRef" />, <see cref="X15.timelineRef" />, <see cref="XDR.contentPart" />, <see cref="XDR14.contentPart" />, <see cref="XLRDWI.address" />, <see cref="XLRDWI.blip" />, <see cref="XLRDWI.moreImagesAddress" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: AddressWebImageSupportingRichDataRelationship.Id, AltChunk.Id, AttachedTemplate.Id, BlipWebImageSupportingRichDataRelationship.Id, BoldFont.Id, BoldItalicFont.Id, ChartReference.Id, ChartSheetPageSetup.Id, ContentPart.Id, ContentPart.RelationshipId, Control.Id, ControlProperties.Id, CustomerData.Id, CustomerDataTags.Id, CustomProperty.Id, DataReference.Id, DataSourceReference.Id, Drawing.Id, DrawingHeaderFooter.Id, EmbedBoldFont.Id, EmbedBoldItalicFont.Id, EmbeddedObjectProperties.Id, EmbedItalicFont.Id, EmbedRegularFont.Id, ExternalBook.Id, ExternalData.Id, ExternalReference.Id, Fill.RelationshipId, FooterReference.Id, GvmlContentPart.RelationshipId, HandoutMasterId.Id, Header.Id, HeaderReference.Id, HeaderSource.Id, HtmlPublishProperties.Id, Hyperlink.Id, HyperlinkOnClick.Id, HyperlinkOnHover.Id, HyperlinkOnMouseOver.Id, HyperlinkRuby.Id, ImageData.RelationshipId, ItalicFont.Id, LegacyDrawing.Id, LegacyDrawingHeaderFooter.Id, MoreImagesAddressWebImageSupportingRichDataRelationship.Id, MovieReference.Id, NotesMasterId.Id, ObjectEmbed.Id, ObjectLink.Id, OleLink.Id, OleObject.Id, OutlineViewSlideListEntry.Id, PageSetup.Id, Picture.Id, PictureAttributionSourceURL.Id, PivotCache.Id, PivotCacheDefinition.Id, PivotSelection.Id, PivotTableReference.Id, PrinterSettingsReference.Id, RangeSet.Id, RecipientDataReference.Id, RegularFont.Id, SaveThroughXslt.Id, Sheet.Id, SlicerCache.Id, SlicerRef.Id, SlideId.RelationshipId, SlideLayoutId.RelationshipId, SlideListEntry.Id, SlideMasterId.RelationshipId, SourceFileReference.Id, SourceReference.Id, Stroke.RelationshipId, SubDocumentReference.Id, TablePart.Id, TimelineCacheReference.Id, TimelineReference.Id, ToolbarData.Id, UserShapesReference.Id, WebExtensionPartReference.Id, WebExtensionReference.Id, WorksheetSource.Id.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName id = r + "id";

        /// <summary>
        /// Represents the r:link XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="A.audioFile" />, <see cref="A.blip" />, <see cref="A.quickTimeFile" />, <see cref="A.videoFile" />, <see cref="ASVG.svgBlip" />, <see cref="P14.media" />, <see cref="WE.snapshot" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: AudioFromFile.Link, Blip.Link, Media.Link, QuickTimeFromFile.Link, Snapshot.Link, SVGBlip.Link, VideoFromFile.Link.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName link = r + "link";

        /// <summary>
        /// Represents the r:lo XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="DGM.relIds" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: RelationshipIds.LayoutPart.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName lo = r + "lo";

        /// <summary>
        /// Represents the r:pict XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="V.imagedata" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: ImageData.Picture.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pict = r + "pict";

        /// <summary>
        /// Represents the r:qs XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="DGM.relIds" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: RelationshipIds.StylePart.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName qs = r + "qs";
    }
}
