/****************************************************************************

    OfficePackageInfo.cs

    Content Types and Relationship Types.

    TODO: add XPS ContentTypes and PartTypes

------------------------------------------------------------- LICENSE BEGINS HERE--------------------------------------------------------------------------------------

Copyright (c) Microsoft Corporation
All rights reserved. 

Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with the License. You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0 

THIS CODE IS PROVIDED ON AN  *AS IS* BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING WITHOUT LIMITATION ANY IMPLIED WARRANTIES OR CONDITIONS OF TITLE, FITNESS FOR A PARTICULAR PURPOSE, MERCHANTABLITY OR NON-INFRINGEMENT. 

See the Apache Version 2.0 License for specific language governing permissions and limitations under the License.
-------------------------------------------------------------- LICENSE ENDS HERE -----------------------------------------------------------------------------------------
****************************************************************************/
using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.OpenXMLEditor
{
    // [CLSCompliant(false)]
    public enum ContentType
    {
        // Use default content type value (life is easy when this is zero)
        UseDefault = 0,

        // Misc
        Unknown,
        Text,
        Rtf,
        Html,
        Mht,
        Xml,
        TextXml,
        TextPlain,

        // Office
        CoreProps,
        AppProps,
        CustomProps,
        Chart,
        Comments,
        CommentAuthors,
        VBAProject,
        VBAProjectSignature,
        EmbeddedObject,
        EmbeddedPackage,

        // Office Art
        Drawing,
        LegacyDrawing,
        LegacyDiagramText,
        LegacyDocTextInfo,

        // Styles
        StyleSheet,

        // Fonts
        FontFnt,
        FontTtf,
        FontOdttf,

        // Digital Signatures
        DSigOrigin,
        DSigSignature,

        // ActiveX controls
        ActiveX,
        ActiveXBin,

        // Images
        ImageUnknown,
        ImageStart = ImageUnknown,
        ImageBmp,
        ImageGif,
        ImagePng,
        ImageTiff,
        ImageXbm,
        ImageIcon,
        ImagePcx,
        ImagePcz,
        ImageEmz,
        ImageWmz,
        ImageJpeg,
        ImageEmf,
        ImageWmf,
        ImageEnd = ImageWmf,

        // Audio
        AudioUnknown,
        AudioStart = AudioUnknown,
        AudioAiff,
        AudioBasic,
        AudioMidi,
        AudioMp3,
        AudioMpegUrl,
        AudioWav,
        AudioWAX,
        AudioWMA,
        AudioEnd = AudioWMA,

        // Video
        VideoUnknown,
        VideoStart = VideoUnknown,
        VideoASF,
        VideoASFP,
        VideoAVI,
        VideoIVF,
        VideoMpg,
        VideoMpeg,
        VideoWM,
        VideoWMV,
        VideoWMX,
        VideoWVX,
        VideoEnd = VideoWVX,

        // Main Parts (PPT)
        PptPptx,
        MainStart = PptPptx,
        PptPptm,
        PptPotx,
        PptPotm,
        PptPpsx,
        PptPpsm,
        PptPpam,
        // Main Parts (Word)
        WordXmlDocx,
        WordXmlDocm,
        WordXmlDotx,
        WordXmlDotm,
        // Main Parts (XL)
        XlBin,
        Xlml,
        XlmlM,
        XlmlTX,
        XlmlTM,
        XlmlAM,
        // Main Parts (Themes)
        StyleManager,
        MainEnd = StyleManager,
        // Main Parts (Visio)
        VisioVsdx,
        VisioVsdm,
        VisioVssx,
        VisioVssm,
        VisioVstx,
        VisioVstm,

        // PPT Parts
        PptHandoutMaster,
        PptNotesMaster,
        PptNotes,
        PptPresProps,
        PptSlide,
        PptSlideLayout,
        PptSlideMaster,
        PptSlideSyncInfo,
        PptTableStyles,
        PptTimingInfo,
        PptViewProps,
        PptTags,
        PptSmartTags,

        // Word Parts
        Movie,
        WordComments,
        WordDocParts,
        WordEndnotes,
        WordFonts,
        WordFooter,
        WordFootnotes,
        WordGlossaryDoc,
        WordHeader,
        WordLists,
        WordSettings,
        WordWebSettings,
        WordStyles,
        WordSubDoc,
        WordFrame,
        WordCustomizations,
        WordMacroCache,
        WordAttachedToolbars,
        WordVbaData,

        // XL Parts
        XlAttachedToolbars,
        XlBinIndexMs,
        XlBinIndexWs,
        XlCalcChainXml,
        XlCalcChainBin,
        XlChartsheetXml,
        XlChartsheetBin,
        XlCommentsXml,
        XlCommentsBin,
        XlConnectionsXml,
        XlConnectionsBin,
        XlCustomProperty,
        XlDialogsheetXml,
        XlDialogsheetBin,
        XlExternalReferenceXml,
        XlExternalReferenceBin,
        XlImage,
        XlMacrosheetXml,
        XlMacrosheetBin,
        XlMetadataXml,
        XlMetadataBin,
        XlPivotCacheDefXml,
        XlPivotCacheDefBin,
        XlPivotCacheRecXml,
        XlPivotCacheRecBin,
        XlPivotTableXml,
        XlPivotTableBin,
        XlPrinterSettings,
        XlQueryTableXml,
        XlQueryTableBin,
        XlReserved1Xml,
        XlReserved1Bin,
        XlReserved2Xml,
        XlReserved2Bin,
        XlReserved3Xml,
        XlReserved3Bin,
        XlRevisionHeadersXml,
        XlRevisionHeadersBin,
        XlRevisionLogXml,
        XlRevisionLogBin,
        XlSharedStringsXml,
        XlSharedStringsBin,
        XlStylesXml,
        XlStylesBin,
        XlSxRefXml,
        XlSxRefBin,
        XlTableXml,
        XlTableBin,
        XlTableSingleCellsXml,
        XlTableSingleCellsBin,
        XlUserNamesXml,
        XlUserNamesBin,
        XlVolatileDependenciesXml,
        XlVolatileDependenciesBin,
        XlWorksheetXml,
        XlWorksheetBin,

        // Igx Parts
        Igx,
        IgxData,
        IgxDiagramDefHeader,
        IgxDiagramDef,
        IgxStyleHeader,
        IgxStyle,
        IgxColorTransHeader,
        IgxColorTrans,

        // Chart Parts
        ChartUserShapes,
        ChartLegacyPb,

        // Style Parts
        StyleOverride,

        // Visio Parts
        VisioWindows,
        VisioPages,
        VisioPage,
        VisioMasters,
        VisioMaster,
        VisioConnections,
        VisioRecordsets,
        VisioRecordset,
        VisioValidation,
        VisioSolutions,
        VisioSolution,
        VisioComments,
        VisioExtensions,

        // max + 1
        _Count
    } // enum ContentType

    public enum Comp
    {
        CD,    // compression deflate
        CN,    // compression none
    }

    // [CLSCompliant(false)]
    public struct ContentTypeInfo
    {
        public ContentTypeInfo(ContentType type, Comp comp, string ext, string mime)
        {
            m_type = type;
            m_comp = comp;
            m_ext = ext;
            m_mime = mime;
        }
        public ContentType m_type;
        public Comp m_comp;
        public string m_ext;
        public string m_mime;
    }

    public enum Pri
    {
        PH = 10,
        PMH = 25,
        PM = 50,
        PML = 75,
        PL = 100,
    }

    public enum RelFlags
    {
        RI = 0x00000001, // metroFlagsRelationshipInternal
        RE = 0x00000002, // metroFlagsRelationshipExternal
        RB = 0x00000003, // metroFlagsRelationshipBoth
        RS = 0x00000004, // metroFlagsRelationshipSign
        PR = 0x00000008, // metroFlagsRelativePartName
        EP = 0x00000010, // metroFlagsExtensiblePart
        EO = 0x00000020, // metroFlagsEmbeddedObject
        PQ = 0x00000040, // metroFlagsRequiredPart 
        RX = 0x00000080, // metroFlagsXmlContentTypeOk
    }

    // [CLSCompliant(false)]
    public enum PartType
    {
        // used to initialize variables (-1 so it never changes)
        Invalid = -1,

        // Media Parts
        Image,
        Audio,
        Video,

        // Misc Office Parts
        Comments,
        CommentAuthors,
        Font,
        HtmlPubSaveAs,
        Hyperlink,
        MailMergeSource,
        MailMergeHeaderSource,

        // Styles (Themes) Start Part
        StyleManager,

        // Styles
        StyleOverride,
        StyleSheet,
        StyleAltThumbnail,
        StyleAuxThumbnail,

        // OfficeArt
        Drawing,
        LegacyDrawing,
        LegacyDiagramText,
        LegacyDocTextInfo,

        // OfficeArt - downrev save
        DrsShape,
        DrsConnector,
        DrsPicture,
        DrsGroupShape,
        DrsE2oDoc,
        DrsDownRev,

        // Doc Props
        DocPropsApp,
        DocPropsCore,
        DocPropsCustom,
        Thumbnail,

        // Embedding
        ActiveXControl,
        ActiveXControlBin,
        MetroDocument,
        OleObjectBin,
        OleObjectNative,
        UserXmlData,
        VBAProject,
        VBAProjectSignature,

        // UI customization
        CustomUIExtensibility,
        CustomUIUserCustomization,
        CustomUIProgID,
        CustomUIRibbonID,
        CustomUIImageID,
        CustomUIControlID,
        CustomUIEnabled,
        CustomUIVisible,
        CustomUILabel,
        CustomUITooltip,
        CustomUISupertip,
        CustomUIDescription,
        CustomUIPressed,
        CustomUIText,
        CustomUIButtonSize,
        CustomUIShowImage,
        CustomUIShowLabel,
        CustomUIImageMso,
        CustomUIKeyTip,

        // DataStore
        DataStoreItem,
        DataStoreItemProps,

        // PPT Start Part
        PptStart,

        // PPT Parts
        ContentMaster,
        HandoutMaster,
        MainMaster,
        NotesMaster,
        Notes,
        PresProps,
        Slide,
        SlideSyncInfo,
        SlideSyncUrl,
        TableStyles,
        TimingInfo,
        ViewProps,
        PptTags,
        PptSmartTags,

        // Word Start Parts
        WordDocument,
        WordTemplate,

        // Word Parts
        WordComments,
        WordDocParts,
        WordEmbeddedObject,
        WordEmbeddedPackage,
        WordEndnotes,
        WordFonts,
        WordFooter,
        WordFootnotes,
        WordGlossaryDoc,
        WordGlossaryDocB1TR,
        WordHeader,
        WordLists,
        WordMovie,
        WordSettings,
        WordWebSettings,
        WordStyles,
        WordSubDoc,
        WordFrame,
        WordAFChunk,
        WordCustomizations,
        WordMacroCache,
        WordAttachedToolbars,
        WordVbaData,

        // XL Start Part
        Workbook,
        XlStart = Workbook,

        // XL Parts
        XlAttachedToolbars,
        XlBinIndexMs,
        XlBinIndexWs,
        XlCalcChain,
        XlChartsheet,
        XlComments,
        XlConnections,
        XlCustomProperty,
        XlDataConsolidatePath, // O12Beta1 Only
        XlDialogsheet,
        XlExternalReference,
        XlExternalReferencePath,
        XlExternalReferencePathStart,
        XlExternalReferencePathAltStart,
        XlExternalReferencePathLibrary,
        XlImage,
        XlMacrosheet,
        XlMetadata,
        XlPivotCacheDefinition,
        XlPivotCacheRecords,
        XlPivotCacheReferences, // O12Beta1 Only
        XlPivotTable,
        XlPrinterSettings,
        XlQueryTable,
        XlReserved1,
        XlReserved2,
        XlReserved3,
        XlReserved1Ext,
        XlReserved2Ext,
        XlRevisionHeaders,
        XlRevisionLog,
        XlSharedStrings,
        XlStyles,
        XlSxRef,
        XlTable,
        XlTableSingleCells,
        XlUserNames,
        XlVolatileDependencies,
        XlWorksheet,
        XlXmlMaps,
        XlEnd = XlXmlMaps,

        // Igx
        Igx,
        IgxData,
        IgxDiagramDefHeader,
        IgxDiagramDef,
        IgxStyleHeader,
        IgxStyle,
        IgxColorTransHeader,
        IgxColorTrans,

        // Digital Signatures
        DSigOrigin,
        DSigSignature,

        // Chart
        Chart,
        ChartTemplate,
        ChartUserShapes,
        ChartLegacyPb,

        // Access
        AccessTemplate,
        AccessNavPane,
        AccessObject,
        AccessObjectMetadata,
        AccessRelationships,
        AccessTableData,
        AccessProperties,
        AccessPreviewImage,
        AccessVBARefs,

        // Visio
        VisioDocument,
        VisioWindows,
        VisioPages,
        VisioPage,
        VisioMasters,
        VisioMaster,
        VisioConnections,
        VisioRecordsets,
        VisioRecordset,
        VisioValidation,
        VisioSolutions,
        VisioSolution,
        VisioComments,
        VisioExtensions,

        // max + 1
        _Count
    } // enum PartType

    // [CLSCompliant(false)]
    public struct PartInfo
    {
        public PartInfo(
            PartType type,
            string defPath,
            string relType,
            ContentType ctBegin,
            ContentType ctEnd)
        {
            m_type = type;
            m_defPath = defPath;
            m_relType = relType;
            m_ctBegin = ctBegin;
            m_ctEnd = ctEnd;
        }

        public PartType m_type;
        public string m_defPath;
        public string m_relType;
        public ContentType m_ctBegin;
        public ContentType m_ctEnd;
    }

    // [CLSCompliant(false)]
    public static class KnownPackageInfo
    {
        private static ContentTypeInfo[] m_rgContentTypeInfo = new ContentTypeInfo[]
        {
            // Default (this entry must be first, but the values are not used)
            new ContentTypeInfo(ContentType.UseDefault,          Comp.CN,   "",        ""                                                    ),

            // Misc
            new ContentTypeInfo(ContentType.Unknown,             Comp.CD,   ".bin",    "application/octet-stream"                            ),
            new ContentTypeInfo(ContentType.Text,                Comp.CD,   ".txt",    "application/txt"                                     ),
            new ContentTypeInfo(ContentType.Rtf,                 Comp.CD,   ".rtf",    "application/rtf"                                     ),
            new ContentTypeInfo(ContentType.Html,                Comp.CD,   ".htm",    "application/html"                                    ),
            new ContentTypeInfo(ContentType.Mht,                 Comp.CD,   ".mht",    "application/mht"                                     ), 
            new ContentTypeInfo(ContentType.Xml,                 Comp.CD,   ".xml",    "application/xml"                                     ),
            new ContentTypeInfo(ContentType.TextXml,             Comp.CD,   ".xml",    "text/xml"                                            ), 
            new ContentTypeInfo(ContentType.TextPlain,           Comp.CD,   ".txt",    "text/plain"                                          ), 
            
            // Office 
            new ContentTypeInfo(ContentType.CoreProps,           Comp.CD,   ".xml",    "application/vnd.openxmlformats-package.core-properties+xml"                 ),
            new ContentTypeInfo(ContentType.AppProps,            Comp.CD,   ".xml",    "application/vnd.openxmlformats-officedocument.extended-properties+xml"      ),
            new ContentTypeInfo(ContentType.CustomProps,         Comp.CD,   ".xml",    "application/vnd.openxmlformats-officedocument.custom-properties+xml"        ),

            new ContentTypeInfo(ContentType.Chart,               Comp.CD,   ".xml",    "application/vnd.openxmlformats-officedocument.drawingml.chart+xml"          ),
            new ContentTypeInfo(ContentType.Comments,            Comp.CD,   ".xml",    "application/vnd.ms-office.comments+xml"              ),
            new ContentTypeInfo(ContentType.CommentAuthors,      Comp.CD,   ".xml",    "application/vnd.ms-office.commentAuthors+xml"        ),
            new ContentTypeInfo(ContentType.VBAProject,          Comp.CD,   ".bin",    "application/vnd.ms-office.vbaProject"                ),
            new ContentTypeInfo(ContentType.VBAProjectSignature, Comp.CD,   ".bin",    "application/vnd.ms-office.vbaProjectSignature"       ),
            new ContentTypeInfo(ContentType.EmbeddedObject,      Comp.CD,   ".bin",    "application/vnd.openxmlformats-officedocument.oleObject"                    ),
            new ContentTypeInfo(ContentType.EmbeddedPackage,     Comp.CD,   ".package","application/vnd.openxmlformats-officedocument.package"                      ),

            // Office Art
            new ContentTypeInfo(ContentType.Drawing,             Comp.CD,   ".xml",    "application/vnd.openxmlformats-officedocument.drawing+xml"                  ),
            new ContentTypeInfo(ContentType.LegacyDrawing,       Comp.CD,   ".vml",    "application/vnd.ms-office.legacyDrawing"                 ),
            new ContentTypeInfo(ContentType.LegacyDiagramText,   Comp.CD,   ".bin",    "application/vnd.ms-office.legacyDiagramText"         ),
            new ContentTypeInfo(ContentType.LegacyDocTextInfo,   Comp.CD,   ".bin",    "application/vnd.ms-office.legacyDocTextInfo"         ),

            // Styles
            new ContentTypeInfo(ContentType.StyleSheet,          Comp.CD,   ".xml",    "application/vnd.openxmlformats-officedocument.theme+xml"            ) ,

            // Fonts
            new ContentTypeInfo(ContentType.FontFnt,             Comp.CN,   ".fntdata","application/x-fontdata"                              ),
            new ContentTypeInfo(ContentType.FontTtf,             Comp.CD,   ".ttf",    "application/x-font-ttf"                              ),
            new ContentTypeInfo(ContentType.FontOdttf,           Comp.CD,   ".odttf",  "application/vnd.openxmlformats-officedocument.obfuscatedFont"         ) ,

            // Digital Signatures
            new ContentTypeInfo(ContentType.DSigOrigin,          Comp.CD,   ".sigs",   "application/vnd.openxmlformats-package.digital-signature-origin"                  ),
            new ContentTypeInfo(ContentType.DSigSignature,       Comp.CD,   ".xml",    "application/vnd.openxmlformats-package.digital-signature-xmlsignature+xml"        ) ,

            // ActiveX Controls
            new ContentTypeInfo(ContentType.ActiveX,             Comp.CD,   ".xml",    "application/vnd.openxmlformats-officedocument.activeX+xml"               ) ,
            new ContentTypeInfo(ContentType.ActiveXBin,          Comp.CD,   ".bin",    "application/vnd.openxmlformats-officedocument.activeX"                   ), 

            // Images
            new ContentTypeInfo(ContentType.ImageUnknown,        Comp.CN,   ".bin",    "image/unknown"                                       ),
            new ContentTypeInfo(ContentType.ImageBmp,            Comp.CD,   ".bmp",    "image/bmp"                                           ),
            new ContentTypeInfo(ContentType.ImageGif,            Comp.CN,   ".gif",    "image/gif"                                           ),
            new ContentTypeInfo(ContentType.ImagePng,            Comp.CN,   ".png",    "image/png"                                           ),
            new ContentTypeInfo(ContentType.ImageTiff,           Comp.CN,   ".tiff",   "image/tiff"                                          ),
            new ContentTypeInfo(ContentType.ImageXbm,            Comp.CN,   ".xbm",    "image/xbm"                                           ),
            new ContentTypeInfo(ContentType.ImageIcon,           Comp.CN,   ".ico",    "image/x-icon"                                        ),
            new ContentTypeInfo(ContentType.ImagePcx,            Comp.CD,   ".pcx",    "image/x-pcx"                                         ),
            new ContentTypeInfo(ContentType.ImagePcz,            Comp.CD,   ".pcz",    "image/x-pcz"                                         ),
            new ContentTypeInfo(ContentType.ImageEmz,            Comp.CN,   ".emz",    "image/x-emz"                                         ),
            new ContentTypeInfo(ContentType.ImageWmz,            Comp.CN,   ".wmz",    "image/x-wmz"                                         ),
            new ContentTypeInfo(ContentType.ImageJpeg,           Comp.CN,   ".jpeg",   "image/jpeg"                                          ),
            new ContentTypeInfo(ContentType.ImageEmf,            Comp.CD,   ".emf",    "image/x-emf"                                         ),
            new ContentTypeInfo(ContentType.ImageWmf,            Comp.CD,   ".wmf",    "image/x-wmf"                                         ),

            // Audio
            new ContentTypeInfo(ContentType.AudioUnknown,        Comp.CN,   ".bin",    "audio/unknown"                                       ),
            new ContentTypeInfo(ContentType.AudioAiff,           Comp.CN,   ".aiff",   "audio/aiff"                                          ),
            new ContentTypeInfo(ContentType.AudioBasic,          Comp.CN,   ".au",     "audio/basic"                                         ),
            new ContentTypeInfo(ContentType.AudioMidi,           Comp.CN,   ".mid",    "audio/midi"                                          ),
            new ContentTypeInfo(ContentType.AudioMp3,            Comp.CN,   ".mp3",    "audio/mp3"                                           ),
            new ContentTypeInfo(ContentType.AudioMpegUrl,        Comp.CN,   ".m3u",    "audio/mpegurl"                                       ),
            new ContentTypeInfo(ContentType.AudioWav,            Comp.CD,   ".wav",    "audio/wav"                                           ),
            new ContentTypeInfo(ContentType.AudioWAX,            Comp.CN,   ".wax",    "audio/x-ms-wax"                                      ),
            new ContentTypeInfo(ContentType.AudioWMA,            Comp.CN,   ".wma",    "audio/x-ms-wma"                                      ),

            // Video                                    
            new ContentTypeInfo(ContentType.VideoUnknown,        Comp.CN,   ".bin",    "video/unknown"                                       ),
            new ContentTypeInfo(ContentType.VideoASF,            Comp.CN,   ".asf",    "video/x-ms-asf"                                      ),
            new ContentTypeInfo(ContentType.VideoASFP,           Comp.CN,   ".asx",    "video/x-ms-asf-plugin"                               ),
            new ContentTypeInfo(ContentType.VideoAVI,            Comp.CN,   ".avi",    "video/avi"                                           ),
            new ContentTypeInfo(ContentType.VideoIVF,            Comp.CN,   ".ivf",    "video/x-ivf"                                         ),
            new ContentTypeInfo(ContentType.VideoMpg,            Comp.CN,   ".mpg",    "video/mpg"                                           ),
            new ContentTypeInfo(ContentType.VideoMpeg,           Comp.CN,   ".mpeg",   "video/mpeg"                                          ),
            new ContentTypeInfo(ContentType.VideoWM,             Comp.CN,   ".wm",     "video/x-ms-wm"                                       ),
            new ContentTypeInfo(ContentType.VideoWMV,            Comp.CN,   ".wmv",    "video/x-ms-wmv"                                      ),
            new ContentTypeInfo(ContentType.VideoWMX,            Comp.CN,   ".wmx",    "video/x-ms-wmx"                                      ),
            new ContentTypeInfo(ContentType.VideoWVX,            Comp.CN,   ".wvx",    "video/x-ms-wvx"                                      ),

            // Main Parts (PPT)
            new ContentTypeInfo(ContentType.PptPptx,             Comp.CD,   ".xml",    "application/vnd.openxmlformats-officedocument.presentationml.presentation.main+xml"              ) ,
            new ContentTypeInfo(ContentType.PptPptm,             Comp.CD,   ".xml",    "application/vnd.ms-powerpoint.presentation.macroEnabled.main+xml"),
            new ContentTypeInfo(ContentType.PptPotx,             Comp.CD,   ".xml",    "application/vnd.openxmlformats-officedocument.presentationml.template.main+xml"              ) ,
            new ContentTypeInfo(ContentType.PptPotm,             Comp.CD,   ".xml",    "application/vnd.ms-powerpoint.template.macroEnabled.main+xml") ,
            new ContentTypeInfo(ContentType.PptPpsx,             Comp.CD,   ".xml",    "application/vnd.openxmlformats-officedocument.presentationml.slideshow.main+xml"                 ) ,
            new ContentTypeInfo(ContentType.PptPpsm,             Comp.CD,   ".xml",    "application/vnd.ms-powerpoint.slideshow.macroEnabled.main+xml"    ) ,
            new ContentTypeInfo(ContentType.PptPpam,             Comp.CD,   ".xml",    "application/vnd.ms-powerpoint.addin.macroEnabled.main+xml"        ) ,
            // Main Parts (Word)
            new ContentTypeInfo(ContentType.WordXmlDocx,         Comp.CD,   ".xml",    "application/vnd.openxmlformats-officedocument.wordprocessingml.document.main+xml"                        ),
            new ContentTypeInfo(ContentType.WordXmlDocm,         Comp.CD,   ".xml",    "application/vnd.ms-word.document.macroEnabled.main+xml"           ),
            new ContentTypeInfo(ContentType.WordXmlDotx,         Comp.CD,   ".xml",    "application/vnd.openxmlformats-officedocument.wordprocessingml.template.main+xml"               ),
            new ContentTypeInfo(ContentType.WordXmlDotm,         Comp.CD,   ".xml",    "application/vnd.ms-word.template.macroEnabledTemplate.main+xml"   ),
            // Main Parts (XL)
            new ContentTypeInfo(ContentType.XlBin,               Comp.CD,   ".bin",    "application/vnd.ms-excel.sheet.binary.macroEnabled.main"              ) ,
            new ContentTypeInfo(ContentType.Xlml,                Comp.CD,   ".xml",    "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet.main+xml"                       ) ,
            new ContentTypeInfo(ContentType.XlmlM,               Comp.CD,   ".xml",    "application/vnd.ms-excel.sheet.macroEnabled.main+xml"          ) ,
            new ContentTypeInfo(ContentType.XlmlTX,              Comp.CD,   ".xml",    "application/vnd.openxmlformats-officedocument.spreadsheetml.template.main+xml"              ), 
            new ContentTypeInfo(ContentType.XlmlTM,              Comp.CD,   ".xml",    "application/vnd.ms-excel.template.macroEnabled.main+xml"  ), 
            new ContentTypeInfo(ContentType.XlmlAM,              Comp.CD,   ".xml",    "application/vnd.ms-excel.addin.macroEnabled.main+xml"                 ), 
            // Main Parts (Styles/Themes)
            new ContentTypeInfo(ContentType.StyleManager,        Comp.CD,   ".xml",    "application/vnd.openxmlformats-officedocument.themeManager+xml"          ), 

            // PPT Parts
            new ContentTypeInfo(ContentType.PptHandoutMaster,    Comp.CD,   ".xml",    "application/vnd.openxmlformats-officedocument.presentationml.handoutMaster+xml"               ), 
            new ContentTypeInfo(ContentType.PptNotesMaster,      Comp.CD,   ".xml",    "application/vnd.openxmlformats-officedocument.presentationml.notesMaster+xml"                 ), 
              new ContentTypeInfo(ContentType.PptNotes,            Comp.CD,   ".xml",    "application/vnd.openxmlformats-officedocument.presentationml.notesSlide+xml"                 ), 
              new ContentTypeInfo(ContentType.PptPresProps,        Comp.CD,   ".xml",    "application/vnd.openxmlformats-officedocument.presentationml.presProps+xml"                 ), 
              new ContentTypeInfo(ContentType.PptSlide,            Comp.CD,   ".xml",    "application/vnd.openxmlformats-officedocument.presentationml.slide+xml"                       ), 
              new ContentTypeInfo(ContentType.PptSlideLayout,      Comp.CD,   ".xml",    "application/vnd.openxmlformats-officedocument.presentationml.slideLayout+xml"                 ), 
            new ContentTypeInfo(ContentType.PptSlideMaster,      Comp.CD,   ".xml",    "application/vnd.openxmlformats-officedocument.presentationml.slideMaster+xml"                 ),
            new ContentTypeInfo(ContentType.PptSlideSyncInfo,    Comp.CD,   ".xml",    "application/vnd.openxmlformats-officedocument.presentationml.slideUpdateInfo+xml" ),
            new ContentTypeInfo(ContentType.PptTableStyles,      Comp.CD,   ".xml",    "application/vnd.openxmlformats-officedocument.presentationml.tableStyles+xml" ),
            new ContentTypeInfo(ContentType.PptTimingInfo,       Comp.CD,   ".xml",    "application/vnd.openxmlformats-officedocument.presentationml.timingInfo+xml" ),
            new ContentTypeInfo(ContentType.PptViewProps,        Comp.CD,   ".xml",    "application/vnd.openxmlformats-officedocument.presentationml.viewProps+xml" ),
            new ContentTypeInfo(ContentType.PptTags,             Comp.CD,   ".xml",    "application/vnd.openxmlformats-officedocument.presentationml.tags+xml" ),
            new ContentTypeInfo(ContentType.PptSmartTags,        Comp.CD,   ".bin",    "application/vnd.ms-powerpoint.smartTags" ),

            // Word Parts
            new ContentTypeInfo(ContentType.Movie,               Comp.CD,   ".mov",    "application/movie"                                       ),
            new ContentTypeInfo(ContentType.WordComments,        Comp.CD,   ".xml",    "application/vnd.openxmlformats-officedocument.wordprocessingml.comments+xml"                    ),
            new ContentTypeInfo(ContentType.WordDocParts,        Comp.CD,   ".xml",    "application/vnd.openxmlformats-officedocument.wordprocessingml.documentParts+xml"               ),
            new ContentTypeInfo(ContentType.WordEndnotes,        Comp.CD,   ".xml",    "application/vnd.openxmlformats-officedocument.wordprocessingml.endnotes+xml"                    ),
            new ContentTypeInfo(ContentType.WordFonts,           Comp.CD,   ".xml",    "application/vnd.openxmlformats-officedocument.wordprocessingml.fontTable+xml"                   ),
            new ContentTypeInfo(ContentType.WordFooter,          Comp.CD,   ".xml",    "application/vnd.openxmlformats-officedocument.wordprocessingml.footer+xml"                      ),
            new ContentTypeInfo(ContentType.WordFootnotes,       Comp.CD,   ".xml",    "application/vnd.openxmlformats-officedocument.wordprocessingml.footnotes+xml"                   ),
            new ContentTypeInfo(ContentType.WordGlossaryDoc,     Comp.CD,   ".xml",    "application/vnd.openxmlformats-officedocument.wordprocessingml.document.glossary+xml"           ),
            new ContentTypeInfo(ContentType.WordHeader,          Comp.CD,   ".xml",    "application/vnd.openxmlformats-officedocument.wordprocessingml.header+xml"                      ),
            new ContentTypeInfo(ContentType.WordLists,           Comp.CD,   ".xml",    "application/vnd.openxmlformats-officedocument.wordprocessingml.numbering+xml"                   ),
            new ContentTypeInfo(ContentType.WordSettings,        Comp.CD,   ".xml",    "application/vnd.openxmlformats-officedocument.wordprocessingml.settings+xml"                    ),
            new ContentTypeInfo(ContentType.WordWebSettings,     Comp.CD,   ".xml",    "application/vnd.openxmlformats-officedocument.wordprocessingml.webSettings+xml"                 ),
            new ContentTypeInfo(ContentType.WordStyles,          Comp.CD,   ".xml",    "application/vnd.openxmlformats-officedocument.wordprocessingml.styles+xml"                      ),
            new ContentTypeInfo(ContentType.WordSubDoc,          Comp.CD,   ".xml",    "application/vnd.openxmlformats-officedocument.wordprocessingml.subDoc+xml"                      ),
            new ContentTypeInfo(ContentType.WordFrame,           Comp.CD,   ".xml",    "application/vnd.openxmlformats-officedocument.wordprocessingml.frame+xml"                       ),
            new ContentTypeInfo(ContentType.WordCustomizations,  Comp.CD,   ".xml",    "application/vnd.openxmlformats-officedocument.wordprocessingml.keyMapCustomizations+xml"        ),
            new ContentTypeInfo(ContentType.WordMacroCache,      Comp.CD,   ".xml",    "application/vnd.ms-word.macroCache+xml"                    ),
            new ContentTypeInfo(ContentType.WordAttachedToolbars,Comp.CD,   ".bin",    "application/vnd.ms-word.attachedToolbars"                 ),
            new ContentTypeInfo(ContentType.WordVbaData,         Comp.CD,   ".xml",    "application/vnd.ms-word.vbaData+xml"                    ),

            // XL Parts
            new ContentTypeInfo(ContentType.XlAttachedToolbars,  Comp.CD,   ".bin",    "application/vnd.ms-excel.attachedToolbars"               ),
            new ContentTypeInfo(ContentType.XlBinIndexMs,        Comp.CD,   ".bin",    "application/vnd.ms-excel.binIndexMs"                     ),
            new ContentTypeInfo(ContentType.XlBinIndexWs,        Comp.CD,   ".bin",    "application/vnd.ms-excel.binIndexWs"                     ),
            new ContentTypeInfo(ContentType.XlCalcChainXml,      Comp.CD,   ".xml",    "application/vnd.openxmlformats-officedocument.spreadsheetml.calcChain+xml" ),
            new ContentTypeInfo(ContentType.XlCalcChainBin,      Comp.CD,   ".bin",    "application/vnd.ms-excel.calcChain" ),
            new ContentTypeInfo(ContentType.XlChartsheetXml,     Comp.CD,   ".xml",    "application/vnd.openxmlformats-officedocument.spreadsheetml.chartsheet+xml" ),
            new ContentTypeInfo(ContentType.XlChartsheetBin,     Comp.CD,   ".bin",    "application/vnd.ms-excel.chartsheet" ),
            new ContentTypeInfo(ContentType.XlCommentsXml,       Comp.CD,   ".xml",    "application/vnd.openxmlformats-officedocument.spreadsheetml.comments+xml" ),
            new ContentTypeInfo(ContentType.XlCommentsBin,       Comp.CD,   ".bin",    "application/vnd.ms-excel.comments" ),
            new ContentTypeInfo(ContentType.XlConnectionsXml,    Comp.CD,   ".xml",    "application/vnd.openxmlformats-officedocument.spreadsheetml.connections+xml" ),
            new ContentTypeInfo(ContentType.XlConnectionsBin,    Comp.CD,   ".bin",    "application/vnd.ms-excel.connections" ),
            new ContentTypeInfo(ContentType.XlCustomProperty,    Comp.CD,   ".bin",    "application/vnd.openxmlformats-officedocument.spreadsheetml.customProperty"                 ),
            new ContentTypeInfo(ContentType.XlDialogsheetXml,    Comp.CD,   ".xml",    "application/vnd.openxmlformats-officedocument.spreadsheetml.dialogsheet+xml" ),
            new ContentTypeInfo(ContentType.XlDialogsheetBin,    Comp.CD,   ".bin",    "application/vnd.ms-excel.dialogsheet" ),
            new ContentTypeInfo(ContentType.XlExternalReferenceXml,Comp.CD, ".xml",    "application/vnd.openxmlformats-officedocument.spreadsheetml.externalLink+xml" ), 
            new ContentTypeInfo(ContentType.XlExternalReferenceBin,Comp.CD, ".bin",    "application/vnd.ms-excel.externalLink" ), 
            new ContentTypeInfo(ContentType.XlImage,             Comp.CD,   ".xml",    "application/vnd.openxmlformats-officedocument.spreadsheetml.imageReference+xml"                      ),
            new ContentTypeInfo(ContentType.XlMacrosheetXml,     Comp.CD,   ".xml",    "application/vnd.ms-excel.macrosheet+xml"   ),
            new ContentTypeInfo(ContentType.XlMacrosheetBin,     Comp.CD,   ".bin",    "application/vnd.ms-excel.macrosheet" ),
            new ContentTypeInfo(ContentType.XlMetadataXml,       Comp.CD,   ".xml",    "application/vnd.openxmlformats-officedocument.spreadsheetml.sheetMetadata+xml" ),
            new ContentTypeInfo(ContentType.XlMetadataBin,       Comp.CD,   ".bin",    "application/vnd.ms-excel.sheetMetadata" ),
            new ContentTypeInfo(ContentType.XlPivotCacheDefXml,  Comp.CD,   ".xml",    "application/vnd.openxmlformats-officedocument.spreadsheetml.pivotCacheDefinition+xml" ),
            new ContentTypeInfo(ContentType.XlPivotCacheDefBin,  Comp.CD,   ".bin",    "application/vnd.ms-excel.pivotCacheDefinition" ),
            new ContentTypeInfo(ContentType.XlPivotCacheRecXml,  Comp.CD,   ".xml",    "application/vnd.openxmlformats-officedocument.spreadsheetml.pivotCacheRecords+xml" ), 
            new ContentTypeInfo(ContentType.XlPivotCacheRecBin,  Comp.CD,   ".bin",    "application/vnd.ms-excel.pivotCacheRecords" ), 
            new ContentTypeInfo(ContentType.XlPivotTableXml,     Comp.CD,   ".xml",    "application/vnd.openxmlformats-officedocument.spreadsheetml.pivotTable+xml" ), 
            new ContentTypeInfo(ContentType.XlPivotTableBin,     Comp.CD,   ".bin",    "application/vnd.ms-excel.pivotTable" ), 
            new ContentTypeInfo(ContentType.XlPrinterSettings,   Comp.CD,   ".bin",    "application/vnd.openxmlformats-officedocument.spreadsheetml.printerSettings"                ),
            new ContentTypeInfo(ContentType.XlQueryTableXml,     Comp.CD,   ".xml",    "application/vnd.openxmlformats-officedocument.spreadsheetml.queryTable+xml" ), 
            new ContentTypeInfo(ContentType.XlQueryTableBin,     Comp.CD,   ".bin",    "application/vnd.ms-excel.queryTable" ), 
            new ContentTypeInfo(ContentType.XlReserved1Xml,      Comp.CD,   ".xml",    "application/vnd.openxmlformats-officedocument.spreadsheetml.reserved1+xml" ), 
            new ContentTypeInfo(ContentType.XlReserved1Bin,      Comp.CD,   ".bin",    "application/vnd.ms-excel.reserved1" ), 
            new ContentTypeInfo(ContentType.XlReserved2Xml,      Comp.CD,   ".xml",    "application/vnd.openxmlformats-officedocument.spreadsheetml.reserved2+xml" ), 
            new ContentTypeInfo(ContentType.XlReserved2Bin,      Comp.CD,   ".bin",    "application/vnd.ms-excel.reserved2" ), 
            new ContentTypeInfo(ContentType.XlReserved3Xml,      Comp.CD,   ".xml",    "application/vnd.openxmlformats-officedocument.spreadsheetml.reserved3+xml" ), 
            new ContentTypeInfo(ContentType.XlReserved3Bin,      Comp.CD,   ".bin",    "application/vnd.ms-excel.reserved3" ), 
            new ContentTypeInfo(ContentType.XlRevisionHeadersXml,Comp.CD,   ".xml",    "application/vnd.openxmlformats-officedocument.spreadsheetml.revisionHeaders+xml" ), 
            new ContentTypeInfo(ContentType.XlRevisionHeadersBin,Comp.CD,   ".bin",    "application/vnd.ms-excel.revisionHeaders" ), 
            new ContentTypeInfo(ContentType.XlRevisionLogXml,    Comp.CD,   ".xml",    "application/vnd.openxmlformats-officedocument.spreadsheetml.revisionLog+xml" ), 
            new ContentTypeInfo(ContentType.XlRevisionLogBin,    Comp.CD,   ".bin",    "application/vnd.ms-excel.revisionLog" ), 
            new ContentTypeInfo(ContentType.XlSharedStringsXml,  Comp.CD,   ".xml",    "application/vnd.openxmlformats-officedocument.spreadsheetml.sharedStrings+xml" ),
            new ContentTypeInfo(ContentType.XlSharedStringsBin,  Comp.CD,   ".bin",    "application/vnd.ms-excel.sharedStrings" ),
            new ContentTypeInfo(ContentType.XlStylesXml,         Comp.CD,   ".xml",    "application/vnd.openxmlformats-officedocument.spreadsheetml.styles+xml" ), 
            new ContentTypeInfo(ContentType.XlStylesBin,         Comp.CD,   ".bin",    "application/vnd.ms-excel.styles" ), 
            new ContentTypeInfo(ContentType.XlSxRefXml,          Comp.CD,   ".xml",    "application/vnd.openxmlformats-officedocument.spreadsheetml.sxRef+xml" ), 
            new ContentTypeInfo(ContentType.XlSxRefBin,          Comp.CD,   ".bin",    "application/vnd.ms-excel.sxRef" ), 
            new ContentTypeInfo(ContentType.XlTableXml,          Comp.CD,   ".xml",    "application/vnd.openxmlformats-officedocument.spreadsheetml.table+xml" ), 
            new ContentTypeInfo(ContentType.XlTableBin,          Comp.CD,   ".bin",    "application/vnd.ms-excel.table" ), 
            new ContentTypeInfo(ContentType.XlTableSingleCellsXml,Comp.CD,  ".xml",    "application/vnd.openxmlformats-officedocument.spreadsheetml.tableSingleCells+xml" ), 
            new ContentTypeInfo(ContentType.XlTableSingleCellsBin,Comp.CD,  ".bin",    "application/vnd.ms-excel.tableSingleCells" ), 
            new ContentTypeInfo(ContentType.XlUserNamesXml,      Comp.CD,   ".xml",    "application/vnd.openxmlformats-officedocument.spreadsheetml.userNames+xml" ), 
            new ContentTypeInfo(ContentType.XlUserNamesBin,      Comp.CD,   ".bin",    "application/vnd.ms-excel.userNames" ), 
            new ContentTypeInfo(ContentType.XlVolatileDependenciesXml,Comp.CD,".xml",  "application/vnd.openxmlformats-officedocument.spreadsheetml.volatileDependencies+xml" ), 
            new ContentTypeInfo(ContentType.XlVolatileDependenciesBin,Comp.CD,".bin",  "application/vnd.ms-excel.volatileDependencies" ), 
            new ContentTypeInfo(ContentType.XlWorksheetXml,      Comp.CD,   ".xml",    "application/vnd.openxmlformats-officedocument.spreadsheetml.worksheet+xml" ), 
            new ContentTypeInfo(ContentType.XlWorksheetBin,      Comp.CD,   ".bin",    "application/vnd.ms-excel.worksheet" ), 

            // Igx Parts
            new ContentTypeInfo( ContentType.Igx,                Comp.CD,   ".xml",    "application/vnd.openxmlformats-officedocument.drawingml.diagram+xml" ),
            new ContentTypeInfo( ContentType.IgxData,            Comp.CD,   ".xml",    "application/vnd.openxmlformats-officedocument.drawingml.diagramData+xml" ),
            new ContentTypeInfo( ContentType.IgxDiagramDefHeader,Comp.CD,   ".xml",    "application/vnd.openxmlformats-officedocument.drawingml.diagramLayoutHeader+xml" ),
            new ContentTypeInfo( ContentType.IgxDiagramDef,      Comp.CD,   ".xml",    "application/vnd.openxmlformats-officedocument.drawingml.diagramLayout+xml" ),
            new ContentTypeInfo( ContentType.IgxStyleHeader,     Comp.CD,   ".xml",    "application/vnd.openxmlformats-officedocument.drawingml.diagramStyleHeader+xml" ),
            new ContentTypeInfo( ContentType.IgxStyle,           Comp.CD,   ".xml",    "application/vnd.openxmlformats-officedocument.drawingml.diagramStyle+xml" ),
            new ContentTypeInfo( ContentType.IgxColorTransHeader,Comp.CD,   ".xml",    "application/vnd.openxmlformats-officedocument.drawingml.diagramColorsHeader+xml" ),
            new ContentTypeInfo( ContentType.IgxColorTrans,      Comp.CD,   ".xml",    "application/vnd.openxmlformats-officedocument.drawingml.diagramColors+xml" ),

            // Chart Parts
            new ContentTypeInfo( ContentType.ChartUserShapes,    Comp.CD,   ".xml",    "application/vnd.openxmlformats-officedocument.drawingml.chartshapes+xml"               ),
            new ContentTypeInfo( ContentType.ChartLegacyPb,      Comp.CD,   ".xml",    "application/vnd.ms-office.chartlegacypb+xml"             ),

            // Style Parts
            new ContentTypeInfo( ContentType.StyleOverride,      Comp.CD,   ".xml",    "application/vnd.openxmlformats-officedocument.themeOverride+xml" ),

            // Visio Parts
	        new ContentTypeInfo( ContentType.VisioWindows,        Comp.CD,   ".xml",    "application/vnd.ms-visio.windows+xml"),
	        new ContentTypeInfo( ContentType.VisioPages,          Comp.CD,   ".xml",    "application/vnd.ms-visio.pages+xml"), 
            new ContentTypeInfo( ContentType.VisioPage,           Comp.CD,   ".xml",    "application/vnd.ms-visio.page+xml"), 
	        new ContentTypeInfo( ContentType.VisioMasters,        Comp.CD,   ".xml",    "application/vnd.ms-visio.masters+xml"), 
	        new ContentTypeInfo( ContentType.VisioMaster,         Comp.CD,   ".xml",    "application/vnd.ms-visio.master+xml"), 
	        new ContentTypeInfo( ContentType.VisioConnections,    Comp.CD,   ".xml",    "application/vnd.ms-visio.connections+xml"), 
	        new ContentTypeInfo( ContentType.VisioRecordsets,     Comp.CD,   ".xml",    "application/vnd.ms-visio.recordsets+xml"), 
	        new ContentTypeInfo( ContentType.VisioRecordset,      Comp.CD,   ".xml",    "application/vnd.ms-visio.recordset+xml"), 
	        new ContentTypeInfo( ContentType.VisioValidation,     Comp.CD,   ".xml",    "application/vnd.ms-visio.validation+xml"), 
	        new ContentTypeInfo( ContentType.VisioSolutions,      Comp.CD,   ".xml",    "application/vnd.ms-visio.solutions+xml"), 
	        new ContentTypeInfo( ContentType.VisioSolution,       Comp.CD,   ".xml",    "application/vnd.ms-visio.solution+xml"), 
	        new ContentTypeInfo( ContentType.VisioComments,       Comp.CD,   ".xml",    "application/vnd.ms-visio.comments+xml"), 
	        new ContentTypeInfo( ContentType.VisioExtensions,     Comp.CD,   ".xml",    "application/vnd.ms-visio.extensions+xml")
        }; // ContentTypeInfo[]

        private static PartInfo[] m_rgPartInfo = new PartInfo[]
        {
            // Media
            new PartInfo(PartType.Image,                   "media/image?",                       "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image",                    ContentType.ImageStart, ContentType. ImageEnd), 
            new PartInfo(PartType.Audio,                   "media/audio?",                       "http://schemas.openxmlformats.org/officeDocument/2006/relationships/audio",                    ContentType.AudioStart, ContentType. AudioEnd),
            new PartInfo(PartType.Video,                   "media/video?",                       "http://schemas.openxmlformats.org/officeDocument/2006/relationships/video",                    ContentType.VideoStart, ContentType. VideoEnd),

            // Office
            new PartInfo(PartType.Comments,                "comments/comment?",                  "http://schemas.openxmlformats.org/officeDocument/2006/relationships/comments",                 ContentType.Comments, ContentType.Comments),
            new PartInfo(PartType.CommentAuthors,          "commentAuthors",                     "http://schemas.openxmlformats.org/officeDocument/2006/relationships/commentAuthors",           ContentType.CommentAuthors, ContentType.CommentAuthors),
            new PartInfo(PartType.Font,                    "fonts/font?",                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/font",                     ContentType.FontFnt, ContentType. FontOdttf),
            new PartInfo(PartType.HtmlPubSaveAs,           "NoPartName",                         "http://schemas.openxmlformats.org/officeDocument/2006/relationships/htmlPubSaveAs",            ContentType.Unknown, ContentType.Unknown),
            new PartInfo(PartType.Hyperlink,               "NoPartName",                         "http://schemas.openxmlformats.org/officeDocument/2006/relationships/hyperlink",                ContentType.Unknown, ContentType.Unknown),
            new PartInfo(PartType.MailMergeSource,         "NoPartName",                         "http://schemas.openxmlformats.org/officeDocument/2006/relationships/mailMergeSource",          ContentType.Unknown, ContentType.Unknown),
            new PartInfo(PartType.MailMergeHeaderSource,   "NoPartName",                         "http://schemas.openxmlformats.org/officeDocument/2006/relationships/mailMergeHeaderSource",    ContentType.Unknown, ContentType.Unknown),

            // Styles
            new PartInfo(PartType.StyleManager,            "theme/themeManager",                 "http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument",           ContentType.StyleManager, ContentType.StyleManager),
            new PartInfo(PartType.StyleOverride,           "theme/themeOverride?",               "http://schemas.openxmlformats.org/officeDocument/2006/relationships/themeOverride",            ContentType.StyleOverride, ContentType.StyleOverride),
            new PartInfo(PartType.StyleSheet,              "theme/theme?",                       "http://schemas.openxmlformats.org/officeDocument/2006/relationships/theme",                    ContentType.StyleSheet, ContentType.StyleSheet),
            new PartInfo(PartType.StyleAltThumbnail,       "theme/themeThumbnail",               "http://schemas.openxmlformats.org/package/2006/relationships/metadata/thumbnail",              ContentType.ImageJpeg, ContentType. ImageEmf),
            new PartInfo(PartType.StyleAuxThumbnail,       "theme/auxiliaryThemeThumbnail",      "http://schemas.openxmlformats.org/package/2006/relationships/metadata/auxThumbnail",           ContentType.ImageJpeg, ContentType. ImageEmf),

            // Oart
            new PartInfo(PartType.Drawing,                 "drawings/drawing?",                  "http://schemas.openxmlformats.org/officeDocument/2006/relationships/drawing",                  ContentType.Drawing, ContentType.Drawing),
            new PartInfo(PartType.LegacyDiagramText,       "drawings/legacyDiagramText?",        "http://schemas.microsoft.com/office/2006/relationships/legacyDiagramText",         ContentType.LegacyDiagramText, ContentType.LegacyDiagramText),
            new PartInfo(PartType.LegacyDocTextInfo,       "legacyDocTextInfo",                  "http://schemas.microsoft.com/office/2006/relationships/legacyDocTextInfo",         ContentType.LegacyDocTextInfo, ContentType.LegacyDocTextInfo),

            // Doc Props
            new PartInfo(PartType.DocPropsApp,             "/docProps/app",                      "http://schemas.openxmlformats.org/officeDocument/2006/relationships/extended-properties",      ContentType.AppProps, ContentType.AppProps),
            new PartInfo(PartType.DocPropsCore,            "/docProps/core",                     "http://schemas.openxmlformats.org/package/2006/relationships/metadata/core-properties",        ContentType.CoreProps, ContentType.CoreProps),
            new PartInfo(PartType.DocPropsCustom,          "/docProps/custom",                   "http://schemas.openxmlformats.org/officeDocument/2006/relationships/custom-properties",        ContentType.CustomProps, ContentType.CustomProps),
            new PartInfo(PartType.Thumbnail,               "/docProps/thumbnail",                "http://schemas.openxmlformats.org/package/2006/relationships/metadata/thumbnail",              ContentType.ImageJpeg, ContentType. ImageWmf),

            // Ole
            new PartInfo(PartType.ActiveXControl,          "activeX/activeX?",                   "http://schemas.openxmlformats.org/officeDocument/2006/relationships/activeXControl",           ContentType.ActiveX, ContentType.ActiveX),
            new PartInfo(PartType.ActiveXControlBin,       "activeX/activeX?",                   "http://schemas.openxmlformats.org/officeDocument/2006/relationships/activeXControlBinary",     ContentType.ActiveXBin, ContentType.ActiveXBin),
            new PartInfo(PartType.MetroDocument,           "embeddings/package?",                "http://schemas.openxmlformats.org/officeDocument/2006/relationships/package",                  ContentType.EmbeddedPackage, ContentType.EmbeddedPackage),
            new PartInfo(PartType.OleObjectBin,            "embeddings/oleObject?",              "http://schemas.openxmlformats.org/officeDocument/2006/relationships/oleObject",                ContentType.EmbeddedObject, ContentType.EmbeddedObject),
            new PartInfo(PartType.OleObjectNative,         "embeddings/oleObject?",              "http://schemas.openxmlformats.org/officeDocument/2006/relationships/oleObject",                ContentType.EmbeddedObject, ContentType.EmbeddedObject),
            new PartInfo(PartType.UserXmlData,             "embeddings/userXmlData?",            "http://schemas.microsoft.com/office/2006/relationships/userXmlData",               ContentType.Xml, ContentType.Xml),
            new PartInfo(PartType.VBAProject,              "vbaProject",                         "http://schemas.microsoft.com/office/2006/relationships/vbaProject",                ContentType.VBAProject, ContentType.VBAProject),
            new PartInfo(PartType.VBAProjectSignature,     "vbaProjectSignature",                "http://schemas.microsoft.com/office/2006/relationships/vbaProjectSignature",       ContentType.VBAProjectSignature, ContentType.VBAProjectSignature),

            // UI Customization
            new PartInfo(PartType.CustomUIExtensibility,   "customUI/customUI?",                 "http://schemas.microsoft.com/office/2006/relationships/ui/extensibility",          ContentType.Xml, ContentType.Xml),
            new PartInfo(PartType.CustomUIUserCustomization,"/userCustomization/customUI",       "http://schemas.microsoft.com/office/2006/relationships/ui/userCustomization",      ContentType.Xml, ContentType.Xml),
            new PartInfo(PartType.CustomUIProgID,          "customUI/progID?",                   "http://schemas.microsoft.com/office/2006/relationships/ui/progID",                 ContentType.Text, ContentType.Text),
            new PartInfo(PartType.CustomUIRibbonID,        "customUI/ribbonID?",                 "http://schemas.microsoft.com/office/2006/relationships/ui/ribbonID",               ContentType.Text, ContentType.Text),
            new PartInfo(PartType.CustomUIImageID,         "customUI/imageID?",                  "http://schemas.microsoft.com/office/2006/relationships/ui/imageID",                ContentType.Text, ContentType.Text),
            new PartInfo(PartType.CustomUIControlID,       "customUI/controlID?",                "http://schemas.microsoft.com/office/2006/relationships/ui/controlID",              ContentType.Text, ContentType.Text),
            new PartInfo(PartType.CustomUIEnabled,         "customUI/enabled?",                  "http://schemas.microsoft.com/office/2006/relationships/ui/enabled",                ContentType.Text, ContentType.Text),
            new PartInfo(PartType.CustomUIVisible,         "customUI/visible?",                  "http://schemas.microsoft.com/office/2006/relationships/ui/visible",                ContentType.Text, ContentType.Text),
            new PartInfo(PartType.CustomUILabel,           "customUI/label?",                    "http://schemas.microsoft.com/office/2006/relationships/ui/label",                  ContentType.Text, ContentType.Text),
            new PartInfo(PartType.CustomUITooltip,         "customUI/tooltip?",                  "http://schemas.microsoft.com/office/2006/relationships/ui/tooltip",                ContentType.Text, ContentType.Text),
            new PartInfo(PartType.CustomUISupertip,        "customUI/supertip?",                 "http://schemas.microsoft.com/office/2006/relationships/ui/supertip",               ContentType.Text, ContentType.Text),
            new PartInfo(PartType.CustomUIDescription,     "customUI/description?",              "http://schemas.microsoft.com/office/2006/relationships/ui/description",            ContentType.Text, ContentType.Text),
            new PartInfo(PartType.CustomUIPressed,         "customUI/pressed?",                  "http://schemas.microsoft.com/office/2006/relationships/ui/pressed",                ContentType.Text, ContentType.Text),
            new PartInfo(PartType.CustomUIText,            "customUI/text?",                     "http://schemas.microsoft.com/office/2006/relationships/ui/text",                   ContentType.Text, ContentType.Text),
            new PartInfo(PartType.CustomUIButtonSize,      "customUI/buttonSize?",               "http://schemas.microsoft.com/office/2006/relationships/ui/buttonSize",             ContentType.Text, ContentType.Text),
            new PartInfo(PartType.CustomUIShowImage,       "customUI/showImage?",                "http://schemas.microsoft.com/office/2006/relationships/ui/showImage",              ContentType.Text, ContentType.Text),
            new PartInfo(PartType.CustomUIShowLabel,       "customUI/showLabel?",                "http://schemas.microsoft.com/office/2006/relationships/ui/showLabel",              ContentType.Text, ContentType.Text),
            new PartInfo(PartType.CustomUIImageMso,        "customUI/imageMso?",                 "http://schemas.microsoft.com/office/2006/relationships/ui/imageMso",               ContentType.Text, ContentType.Text),
            new PartInfo(PartType.CustomUIKeyTip,          "customUI/keyTip?",                   "http://schemas.microsoft.com/office/2006/relationships/ui/keyTip",                 ContentType.Text, ContentType.Text),

            // DataStore
            new PartInfo(PartType.DataStoreItem,           "/customXml/item?",                   "http://schemas.openxmlformats.org/officeDocument/2006/relationships/customXml",                ContentType.Xml, ContentType.Xml),
            new PartInfo(PartType.DataStoreItemProps,      "/customXml/itemProps?",              "http://schemas.openxmlformats.org/officeDocument/2006/relationships/customXmlProps",           ContentType.Xml, ContentType.Xml),

            // PPT
            new PartInfo(PartType.PptStart,                "presentation",                       "http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument",           ContentType.PptPptx, ContentType. PptPpam),
            new PartInfo(PartType.ContentMaster,           "slideLayouts/slideLayout?",          "http://schemas.openxmlformats.org/officeDocument/2006/relationships/slideLayout",              ContentType.PptSlideLayout, ContentType.PptSlideLayout),
            new PartInfo(PartType.HandoutMaster,           "handoutMasters/handoutMaster?",      "http://schemas.openxmlformats.org/officeDocument/2006/relationships/handoutMaster",            ContentType.PptHandoutMaster, ContentType.PptHandoutMaster),
            new PartInfo(PartType.MainMaster,              "slideMasters/slideMaster?",          "http://schemas.openxmlformats.org/officeDocument/2006/relationships/slideMaster",              ContentType.PptSlideMaster, ContentType.PptSlideMaster),
            new PartInfo(PartType.NotesMaster,             "notesMasters/notesMaster?",          "http://schemas.openxmlformats.org/officeDocument/2006/relationships/notesMaster",              ContentType.PptNotesMaster, ContentType.PptNotesMaster),
            new PartInfo(PartType.Notes,                   "notesSlides/notesSlide?",            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/notesSlide",               ContentType.PptNotes, ContentType.PptNotes),
            new PartInfo(PartType.PresProps,               "presProps",                          "http://schemas.openxmlformats.org/officeDocument/2006/relationships/presProps",                ContentType.PptPresProps, ContentType.PptPresProps),
            new PartInfo(PartType.Slide,                   "slides/slide?",                      "http://schemas.openxmlformats.org/officeDocument/2006/relationships/slide",                    ContentType.PptSlide, ContentType.PptSlide),
            new PartInfo(PartType.SlideSyncInfo,           "slideUpdateInfo/slideUpdateInfo?",   "http://schemas.openxmlformats.org/officeDocument/2006/relationships/slideUpdateInfo",          ContentType.PptSlideSyncInfo, ContentType.PptSlideSyncInfo),
            new PartInfo(PartType.SlideSyncUrl,            "NoPartName",                         "http://schemas.openxmlformats.org/officeDocument/2006/relationships/slideUpdateUrl",           ContentType.Unknown, ContentType.Unknown),
            new PartInfo(PartType.TableStyles,             "tableStyles",                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/tableStyles",              ContentType.PptTableStyles, ContentType.PptTableStyles),
            new PartInfo(PartType.TimingInfo,              "timingInfo",                         "http://schemas.openxmlformats.org/officeDocument/2006/relationships/timingInfo",               ContentType.PptTimingInfo, ContentType.PptTimingInfo),
            new PartInfo(PartType.ViewProps,               "viewProps",                          "http://schemas.openxmlformats.org/officeDocument/2006/relationships/viewProps",                ContentType.PptViewProps, ContentType.PptViewProps),
            new PartInfo(PartType.PptTags,                 "tags/tag?",                          "http://schemas.openxmlformats.org/officeDocument/2006/relationships/tags",                     ContentType.PptTags, ContentType.PptTags),
            new PartInfo(PartType.PptSmartTags,            "smartTags",                          "http://schemas.microsoft.com/office/2006/relationships/smartTags",                 ContentType.PptSmartTags, ContentType.PptSmartTags),

            // Word
            new PartInfo(PartType.WordDocument,            "document",                           "http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument",           ContentType.WordXmlDocx, ContentType. WordXmlDocm),
            new PartInfo(PartType.WordTemplate,            "document",                           "http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument",           ContentType.WordXmlDotx, ContentType. WordXmlDotm),
            new PartInfo(PartType.WordComments,            "comments",                           "http://schemas.openxmlformats.org/officeDocument/2006/relationships/comments",                 ContentType.WordComments, ContentType.WordComments),
            new PartInfo(PartType.WordDocParts,            "docParts",                           "http://schemas.openxmlformats.org/officeDocument/2006/relationships/documentParts",            ContentType.WordDocParts, ContentType.WordDocParts),
            new PartInfo(PartType.WordEmbeddedObject,      "embeddings/embeddedObject?",         "http://schemas.openxmlformats.org/officeDocument/2006/relationships/oleObject",                ContentType.EmbeddedObject, ContentType.EmbeddedObject),
            new PartInfo(PartType.WordEmbeddedPackage,     "embeddings/embeddedPackage?",        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/package",                  ContentType.EmbeddedPackage, ContentType.EmbeddedPackage),
            new PartInfo(PartType.WordEndnotes,            "endnotes",                           "http://schemas.openxmlformats.org/officeDocument/2006/relationships/endnotes",                 ContentType.WordEndnotes, ContentType.WordEndnotes),
            new PartInfo(PartType.WordFonts,               "fontTable",                          "http://schemas.openxmlformats.org/officeDocument/2006/relationships/fontTable",                ContentType.WordFonts, ContentType.WordFonts),
            new PartInfo(PartType.WordFooter,              "footer?",                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/footer",                   ContentType.WordFooter, ContentType.WordFooter),
            new PartInfo(PartType.WordFootnotes,           "footnotes",                          "http://schemas.openxmlformats.org/officeDocument/2006/relationships/footnotes",                ContentType.WordFootnotes, ContentType.WordFootnotes),
            new PartInfo(PartType.WordGlossaryDoc,         "glossary/document",                  "http://schemas.openxmlformats.org/officeDocument/2006/relationships/glossaryDocument",         ContentType.WordGlossaryDoc, ContentType.WordGlossaryDoc),
            new PartInfo(PartType.WordGlossaryDocB1TR,     "glossary/documentb1tr",              "http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument",           ContentType.WordGlossaryDoc, ContentType.WordGlossaryDoc),
            new PartInfo(PartType.WordHeader,              "header?",                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/header",                   ContentType.WordHeader, ContentType.WordHeader),
            new PartInfo(PartType.WordLists,               "numbering",                          "http://schemas.openxmlformats.org/officeDocument/2006/relationships/numbering",                ContentType.WordLists, ContentType.WordLists),
            new PartInfo(PartType.WordMovie,               "media/video?",                       "http://schemas.openxmlformats.org/officeDocument/2006/relationships/video",                    ContentType.Movie, ContentType.Movie),
            new PartInfo(PartType.WordSettings,            "settings",                           "http://schemas.openxmlformats.org/officeDocument/2006/relationships/settings",                 ContentType.WordSettings, ContentType.WordSettings),
            new PartInfo(PartType.WordWebSettings,         "webSettings",                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/webSettings",              ContentType.WordWebSettings, ContentType.WordWebSettings),
            new PartInfo(PartType.WordStyles,              "styles",                             "http://schemas.openxmlformats.org/officeDocument/2006/relationships/styles",                   ContentType.WordStyles, ContentType.WordStyles),
            new PartInfo(PartType.WordSubDoc,              "subDoc?",                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/subDocument",              ContentType.WordSubDoc, ContentType.WordSubDoc),
            new PartInfo(PartType.WordFrame,               "frame?",                             "http://schemas.openxmlformats.org/officeDocument/2006/relationships/frame",                    ContentType.WordFrame, ContentType.WordFrame),
            new PartInfo(PartType.WordAFChunk,             "afChunk?",                           "http://schemas.openxmlformats.org/officeDocument/2006/relationships/aFChunk",                  ContentType.Text, ContentType. Xml),
            new PartInfo(PartType.WordCustomizations,      "customizations",                     "http://schemas.openxmlformats.org/officeDocument/2006/relationships/keyMapCustomizations",     ContentType.WordCustomizations, ContentType.WordCustomizations),
            new PartInfo(PartType.WordMacroCache,          "macroCache",                         "http://schemas.microsoft.com/office/2006/relationships/macroCache",                ContentType.WordMacroCache, ContentType.WordMacroCache),
            new PartInfo(PartType.WordAttachedToolbars,    "attachedToolbars",                   "http://schemas.microsoft.com/office/2006/relationships/attachedToolbars",          ContentType.WordAttachedToolbars, ContentType.WordAttachedToolbars),
            new PartInfo(PartType.WordVbaData,             "vbaData",                            "http://schemas.microsoft.com/office/2006/relationships/wordVbaData",               ContentType.WordVbaData, ContentType.WordVbaData),

            // XL
            new PartInfo(PartType.Workbook,                "workbook",                           "http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument",           ContentType.XlBin, ContentType. XlmlAM),
            new PartInfo(PartType.XlAttachedToolbars,      "attachedToolbars",                   "http://schemas.microsoft.com/office/2006/relationships/attachedToolbars",          ContentType.XlAttachedToolbars, ContentType.XlAttachedToolbars),
            new PartInfo(PartType.XlBinIndexMs,            "macrosheets/binaryIndex?",           "http://schemas.microsoft.com/office/2006/relationships/xlBinaryIndex",             ContentType.XlBinIndexMs, ContentType.XlBinIndexMs),
            new PartInfo(PartType.XlBinIndexWs,            "worksheets/binaryIndex?",            "http://schemas.microsoft.com/office/2006/relationships/xlBinaryIndex",             ContentType.XlBinIndexWs, ContentType.XlBinIndexWs),
            new PartInfo(PartType.XlCalcChain,             "calcChain",                          "http://schemas.openxmlformats.org/officeDocument/2006/relationships/calcChain",                ContentType.XlCalcChainXml, ContentType.XlCalcChainBin),
            new PartInfo(PartType.XlChartsheet,            "chartsheets/sheet?",                 "http://schemas.openxmlformats.org/officeDocument/2006/relationships/chartsheet",               ContentType.XlChartsheetXml, ContentType.XlChartsheetBin),
            new PartInfo(PartType.XlComments,              "comments?",                          "http://schemas.openxmlformats.org/officeDocument/2006/relationships/comments",                 ContentType.XlCommentsXml, ContentType.XlCommentsBin),
            new PartInfo(PartType.XlConnections,           "connections",                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/connections",              ContentType.XlConnectionsXml, ContentType.XlConnectionsBin),
            new PartInfo(PartType.XlCustomProperty,        "customProperty?",                    "http://schemas.openxmlformats.org/officeDocument/2006/relationships/customProperty",           ContentType.XlCustomProperty, ContentType.XlCustomProperty),
            new PartInfo(PartType.XlDataConsolidatePath,   "NoPartName",                         "http://schemas.openxmlformats.org/officeDocument/2006/relationships/dataConsolidatePath",      ContentType.Unknown, ContentType.Unknown), // O12Beta1 Only
            new PartInfo(PartType.XlDialogsheet,           "dialogsheets/sheet?",                "http://schemas.openxmlformats.org/officeDocument/2006/relationships/dialogsheet",              ContentType.XlDialogsheetXml, ContentType.XlDialogsheetBin),
            new PartInfo(PartType.XlExternalReference,     "externalLinks/externalLink?",        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/externalLink",             ContentType.XlExternalReferenceXml, ContentType.XlExternalReferenceBin),
            new PartInfo(PartType.XlExternalReferencePath,      "NoPartName",                    "http://schemas.openxmlformats.org/officeDocument/2006/relationships/externalLinkPath",         ContentType.Unknown, ContentType.Unknown),
            new PartInfo(PartType.XlExternalReferencePathStart, "NoPartName",                    "http://schemas.microsoft.com/office/2006/relationships/xlExternalLinkPath/xlStartup",          ContentType.Unknown, ContentType.Unknown),
            new PartInfo(PartType.XlExternalReferencePathAltStart,"NoPartName",                  "http://schemas.microsoft.com/office/2006/relationships/xlExternalLinkPath/xlAlternateStartup", ContentType.Unknown, ContentType.Unknown),
            new PartInfo(PartType.XlExternalReferencePathLibrary,"NoPartName",                   "http://schemas.microsoft.com/office/2006/relationships/xlExternalLinkPath/xlLibrary",          ContentType.Unknown, ContentType.Unknown),
            new PartInfo(PartType.XlImage,                 "drawings/imageReference?",           "http://schemas.openxmlformats.org/officeDocument/2006/relationships/imageReference",           ContentType.XlImage, ContentType.XlImage),
            new PartInfo(PartType.XlMacrosheet,            "macrosheets/sheet?",                 "http://schemas.microsoft.com/office/2006/relationships/xlMacrosheet",              ContentType.XlMacrosheetXml, ContentType.XlMacrosheetBin),
            new PartInfo(PartType.XlMetadata,              "metadata",                           "http://schemas.openxmlformats.org/officeDocument/2006/relationships/sheetMetadata",            ContentType.XlMetadataXml, ContentType.XlMetadataBin),
            new PartInfo(PartType.XlPivotCacheDefinition,  "pivotCache/pivotCacheDefinition?",   "http://schemas.openxmlformats.org/officeDocument/2006/relationships/pivotCacheDefinition",     ContentType.XlPivotCacheDefXml, ContentType.XlPivotCacheDefBin),
            new PartInfo(PartType.XlPivotCacheRecords,     "pivotCache/pivotCacheRecords?",      "http://schemas.openxmlformats.org/officeDocument/2006/relationships/pivotCacheRecords",        ContentType.XlPivotCacheRecXml, ContentType.XlPivotCacheRecBin),
            new PartInfo(PartType.XlPivotCacheReferences,  "NoPartName",                         "http://schemas.openxmlformats.org/officeDocument/2006/relationships/pivotCacheReferences",     ContentType.Unknown, ContentType.Unknown), // O12Beta1 Only
            new PartInfo(PartType.XlPivotTable,            "pivotTables/pivotTable?",            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/pivotTable",               ContentType.XlPivotTableXml, ContentType.XlPivotTableBin),
            new PartInfo(PartType.XlPrinterSettings,       "printerSettings/printerSettings?",   "http://schemas.openxmlformats.org/officeDocument/2006/relationships/printerSettings",          ContentType.XlPrinterSettings, ContentType.XlPrinterSettings),
            new PartInfo(PartType.XlQueryTable,            "queryTables/queryTable?",            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/queryTable",               ContentType.XlQueryTableXml, ContentType.XlQueryTableBin),
            new PartInfo(PartType.XlReserved1,             "reserved1/obj?",                     "http://schemas.openxmlformats.org/officeDocument/2006/relationships/reserved1",                ContentType.XlReserved1Xml, ContentType.XlReserved1Bin),
            new PartInfo(PartType.XlReserved2,             "reserved2/obj?",                     "http://schemas.openxmlformats.org/officeDocument/2006/relationships/reserved2",                ContentType.XlReserved2Xml, ContentType.XlReserved2Bin),
            new PartInfo(PartType.XlReserved3,             "reserved3/obj?",                     "http://schemas.openxmlformats.org/officeDocument/2006/relationships/reserved3",                ContentType.XlReserved3Xml, ContentType.XlReserved3Bin),
            new PartInfo(PartType.XlReserved1Ext,          "NoPartName",                         "http://schemas.openxmlformats.org/officeDocument/2006/relationships/reserved1Ext",             ContentType.Unknown, ContentType.Unknown),
            new PartInfo(PartType.XlReserved2Ext,          "NoPartName",                         "http://schemas.openxmlformats.org/officeDocument/2006/relationships/reserved2Ext",             ContentType.Unknown, ContentType.Unknown),
            new PartInfo(PartType.XlRevisionHeaders,       "revisions/revisionHeaders",          "http://schemas.openxmlformats.org/officeDocument/2006/relationships/revisionHeaders",          ContentType.XlRevisionHeadersXml, ContentType.XlRevisionHeadersBin),
            new PartInfo(PartType.XlRevisionLog,           "revisions/revisionLog?",             "http://schemas.openxmlformats.org/officeDocument/2006/relationships/revisionLog",              ContentType.XlRevisionLogXml, ContentType.XlRevisionLogBin),
            new PartInfo(PartType.XlSharedStrings,         "sharedStrings",                      "http://schemas.openxmlformats.org/officeDocument/2006/relationships/sharedStrings",            ContentType.XlSharedStringsXml, ContentType.XlSharedStringsBin),
            new PartInfo(PartType.XlStyles,                "styles",                             "http://schemas.openxmlformats.org/officeDocument/2006/relationships/styles",                   ContentType.XlStylesXml, ContentType.XlStylesBin),
            new PartInfo(PartType.XlSxRef,                 "sxref",                              "http://schemas.openxmlformats.org/officeDocument/2006/relationships/sxref",                    ContentType.XlSxRefXml, ContentType.XlSxRefBin),
            new PartInfo(PartType.XlTable,                 "tables/table?",                      "http://schemas.openxmlformats.org/officeDocument/2006/relationships/table",                    ContentType.XlTableXml, ContentType.XlTableBin),
            new PartInfo(PartType.XlTableSingleCells,      "tables/tableSingleCells?",           "http://schemas.openxmlformats.org/officeDocument/2006/relationships/tableSingleCells",         ContentType.XlTableSingleCellsXml, ContentType.XlTableSingleCellsBin),
            new PartInfo(PartType.XlUserNames,             "revisions/userNames",                "http://schemas.openxmlformats.org/officeDocument/2006/relationships/usernames",                ContentType.XlUserNamesXml, ContentType.XlUserNamesBin),
            new PartInfo(PartType.XlVolatileDependencies,  "volatileDependencies",               "http://schemas.openxmlformats.org/officeDocument/2006/relationships/volatileDependencies",     ContentType.XlVolatileDependenciesXml, ContentType.XlVolatileDependenciesBin),
            new PartInfo(PartType.XlWorksheet,             "worksheets/sheet?",                  "http://schemas.openxmlformats.org/officeDocument/2006/relationships/worksheet",                ContentType.XlWorksheetXml, ContentType.XlWorksheetBin),
            new PartInfo(PartType.XlXmlMaps,               "xmlMaps",                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/xmlMaps",                  ContentType.Xml, ContentType.Xml),

            // Igx
            new PartInfo(PartType.Igx,                     "diagrams/graphic?",                  "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagram",                  ContentType.Igx, ContentType.Igx),
            new PartInfo(PartType.IgxData,                 "diagrams/data?",                     "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramData",              ContentType.IgxData, ContentType.IgxData),
            new PartInfo(PartType.IgxDiagramDefHeader,     "diagrams/layoutHeader?",             "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramLayoutHeader",      ContentType.IgxDiagramDefHeader, ContentType.IgxDiagramDefHeader),
            new PartInfo(PartType.IgxDiagramDef,           "diagrams/layout?",                   "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramLayout",            ContentType.IgxDiagramDef, ContentType.IgxDiagramDef),
            new PartInfo(PartType.IgxStyleHeader,          "diagrams/quickStyleHeader?",         "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramQuickStyleHeader",  ContentType.IgxStyleHeader, ContentType.IgxStyleHeader),
            new PartInfo(PartType.IgxStyle,                "diagrams/quickStyle?",               "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramQuickStyle",        ContentType.IgxStyle, ContentType.IgxStyle),
            new PartInfo(PartType.IgxColorTransHeader,     "diagrams/colorsHeader?",             "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramColorsHeader",      ContentType.IgxColorTransHeader, ContentType.IgxColorTransHeader),
            new PartInfo(PartType.IgxColorTrans,           "diagrams/colors?",                   "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramColors",            ContentType.IgxColorTrans, ContentType.IgxColorTrans),

            // Digital Signature
            new PartInfo(PartType.DSigOrigin,              "/_xmlsignatures/origin",             "http://schemas.openxmlformats.org/package/2006/relationships/digital-signature/origin",                 ContentType.DSigOrigin, ContentType.DSigOrigin),
            new PartInfo(PartType.DSigSignature,           "/_xmlsignatures/sig?",               "http://schemas.openxmlformats.org/package/2006/relationships/digital-signature/signature",              ContentType.DSigSignature, ContentType.DSigSignature),

            // Chart
            new PartInfo(PartType.Chart,                   "charts/chart?",                      "http://schemas.openxmlformats.org/officeDocument/2006/relationships/chart",                    ContentType.Chart, ContentType.Chart),
            new PartInfo(PartType.ChartTemplate,           "chart",                              "http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument",           ContentType.Chart, ContentType.Chart),
            new PartInfo(PartType.ChartUserShapes,         "drawings/drawing?",                  "http://schemas.openxmlformats.org/officeDocument/2006/relationships/chartUserShapes",          ContentType.ChartUserShapes, ContentType.ChartUserShapes),
            new PartInfo(PartType.ChartLegacyPb,           "chartLegacyPb",                      "http://schemas.microsoft.com/office/2006/relationships/chartLegacyPb",             ContentType.ChartLegacyPb, ContentType.ChartLegacyPb),

            // Access
            new PartInfo(PartType.AccessTemplate,          "template",                           "http://schemas.microsoft.com/office/access/2005/04/template/start",                    ContentType.Xml, ContentType.Xml), 
            new PartInfo(PartType.AccessNavPane,           "navPane",                            "http://schemas.microsoft.com/office/access/2005/04/template/nav-pane",                 ContentType.Xml, ContentType.Xml), 
            new PartInfo(PartType.AccessObject,            "object?",                            "http://schemas.microsoft.com/office/access/2005/04/template/object",                   ContentType.TextXml, ContentType. TextPlain), 
            new PartInfo(PartType.AccessObjectMetadata,    "objectMetadata",                     "http://schemas.microsoft.com/office/access/2005/04/template/object-metadata",          ContentType.Xml, ContentType.Xml), 
            new PartInfo(PartType.AccessRelationships,     "relationships",                      "http://schemas.microsoft.com/office/access/2005/04/template/relationships",            ContentType.Xml, ContentType.Xml), 
            new PartInfo(PartType.AccessTableData,         "tableData",                          "http://schemas.microsoft.com/office/access/2005/04/template/table-data",               ContentType.Xml, ContentType.Xml), 
            new PartInfo(PartType.AccessProperties,        "properties",                         "http://schemas.microsoft.com/office/access/2005/04/template/properties",               ContentType.Xml, ContentType.Xml), 
            new PartInfo(PartType.AccessPreviewImage,      "previewImage",                       "http://schemas.microsoft.com/office/access/2005/04/template/preview-image",            ContentType.ImageStart, ContentType. ImageEnd), 
            new PartInfo(PartType.AccessVBARefs,           "vbaRefs",                            "http://schemas.microsoft.com/office/access/2005/04/template/vba-references",           ContentType.Xml, ContentType.Xml), 

        }; // PartInfo[]


        private static Dictionary<string, List<ContentTypeInfo>> m_Ext2ContentTypeInfo = null;

        public static List<ContentTypeInfo> GetContentTypesForExt(string ext)
        {
            if (m_Ext2ContentTypeInfo == null)
            {
                m_Ext2ContentTypeInfo = new Dictionary<string, List<ContentTypeInfo>>();
                foreach (ContentTypeInfo info in m_rgContentTypeInfo)
                {
                    List<ContentTypeInfo> list;
                    if (m_Ext2ContentTypeInfo.ContainsKey(info.m_ext))
                        list = m_Ext2ContentTypeInfo[info.m_ext];
                    else
                    {
                        list = new List<ContentTypeInfo>();
                        m_Ext2ContentTypeInfo.Add(info.m_ext, list);
                    }
                    list.Add(info);
                }
            }
            if (m_Ext2ContentTypeInfo.ContainsKey(ext))
                return m_Ext2ContentTypeInfo[ext];
            return null;
        }

        public static ContentTypeInfo[] GetContentTypes()
        {
            return m_rgContentTypeInfo;
        }

        private static Dictionary<ContentType, ContentTypeInfo> m_ContentType2ContentTypeInfo = null;

        public static ContentTypeInfo GetContentTypeInfo(ContentType ct)
        {
            if (m_ContentType2ContentTypeInfo == null)
            {
                m_ContentType2ContentTypeInfo = new Dictionary<ContentType, ContentTypeInfo>();
                foreach (ContentTypeInfo info in m_rgContentTypeInfo)
                {
                    m_ContentType2ContentTypeInfo.Add(info.m_type, info);
                }
            }
            System.Diagnostics.Debug.Assert(m_ContentType2ContentTypeInfo.ContainsKey(ct));
            return m_ContentType2ContentTypeInfo[ct];
        }

        private static Dictionary<string, PartInfo> m_RelTypes = null;

        public static Dictionary<string, PartInfo> GetRelationshipTypes()
        {
            if (m_RelTypes == null)
            {
                m_RelTypes = new Dictionary<string, PartInfo>();

                foreach (PartInfo pi in m_rgPartInfo)
                {
                    string relType = pi.m_relType;
                    if (!m_RelTypes.ContainsKey(relType))
                        m_RelTypes.Add(relType, pi);
                }
            }
            return m_RelTypes;
        }

        private static Dictionary<string, List<PartInfo>> m_ContentType2PartInfo = null;

        public static List<PartInfo> GetPartTypesForContentType(string contentType)
        {
            if (m_ContentType2PartInfo == null)
            {
                m_ContentType2PartInfo = new Dictionary<string, List<PartInfo>>();
                foreach (PartInfo pi in m_rgPartInfo)
                {
                    List<PartInfo> list;
                    for (ContentType ct = pi.m_ctBegin; ct <= pi.m_ctEnd; ct++)
                    {
                        ContentTypeInfo ctInfo = GetContentTypeInfo(ct);
                        if (m_ContentType2PartInfo.ContainsKey(ctInfo.m_mime))
                            list = m_ContentType2PartInfo[ctInfo.m_mime];
                        else
                        {
                            list = new List<PartInfo>();
                            m_ContentType2PartInfo.Add(ctInfo.m_mime, list);
                        }
                        list.Add(pi);
                    }
                }
            }
            if (m_ContentType2PartInfo.ContainsKey(contentType))
                return m_ContentType2PartInfo[contentType];
            return null;
        }

        public static bool IsXml(string ext)
        {
            return (
                ext == ".xml" ||
                ext == ".rels" ||
                ext == ".xsd" ||
                ext == ".xsl" ||
                ext == ".xslt" ||
                ext == ".vml" ||
                ext == ".dict" ||    // XPS: Remote Resource Dictionary 
                ext == ".fdoc" ||    // XPS: FixedDocument
                ext == ".fdseq" ||    // XPS: FixedDocumentSequence
                ext == ".fpage" ||    // XPS: FixedPage
                ext == ".frag" ||    // XPS: StoryFragments
                ext == ".struct" ||    // XPS: DocumentStructure
                ext == ".vsixmanifest");    // VSIX: manifest file
        }

        public static bool IsText(string ext)
        {
            return (
                IsXml(ext) ||
                ext == ".txt" ||
                ext == ".rtf" ||
                ext == ".htm" ||
                ext == ".mht" ||
                ext == ".vsdir" ||
                ext == ".pkgdef");
        }

        public static bool IsBinary(string ext)
        {
            return !IsText(ext);
        }

        public static bool IsImage(string ext)
        {
            return (
                ext == ".bmp" ||
                ext == ".gif" ||
                ext == ".png" ||
                ext == ".tif" ||
                ext == ".tiff" ||
                ext == ".xbm" ||
                ext == ".ico" ||
                ext == ".pcx" ||
                ext == ".pcz" ||
                ext == ".emz" ||
                ext == ".wmz" ||
                ext == ".jpg" ||
                ext == ".jpeg" ||
                ext == ".emf" ||
                ext == ".wmf");
        }

    }

}
