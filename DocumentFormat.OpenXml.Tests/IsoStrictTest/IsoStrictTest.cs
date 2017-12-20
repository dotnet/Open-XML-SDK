// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Validation;
using Xunit;

using static DocumentFormat.OpenXml.Tests.TestAssets;

namespace DocumentFormat.OpenXml.Tests
{
    /// <summary>
    /// Test for ISO Strict fileformat on Open XML SDK
    /// </summary>
    public class IsoStrictTest
    {
        /// <summary>
        /// Office15TCM: 41257: OOXML SDK: ISO Strict Namespace / Relationship Mapping - Readability
        /// </summary>
        [Theory]
        [InlineData(TestDataStorage.O14ISOStrict.Word.AbbreviatedCaseNumber_Abbreviated_Case_Number_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.argSz_Argument_Size_Sub_Superscript_Function_Superscript_val__2_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.bdr_Text_Border_themeColor_text1_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.BookAuthor_Book_Author_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.bottom_Bottom_Border_themeColor_dark1_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.File4_6_10_bg_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.algnDist_mainLvl2ppr_AlignmentLevel2Distributed_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.algnJustLow_mainLvl1ppr_AlignmentLevel1JustifiedLow_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.algnJust_mainLvl1ppr_AlignmentLevel1Justified_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.algnR_mainLvl2ppr_AlignmentLevel2Right_pptx)]
        public void TestISOStrictNamespace(string path)
        {
            using (var file = OpenFile(path, false))
            using (var document = file.Open(false))
            {
                Assert.True(document.StrictTranslation);
            }
        }

        /// <summary>
        /// Office15TCM: 41263: OOXML SDK: File Validation - OOXML ISO Strict Files (DrawingML)
        /// </summary>
        [Theory]

        // Graphics documents
        [InlineData(TestDataStorage.O14ISOStrict.Graphics.File2D_Column_O12_Word_Charts_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Graphics.AllShadows_O12_Word_OartTextEffects_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Graphics.AlphaMod___Parent_Cont___Enum_tree_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Graphics.File2D_Rotation_O12_XL_OartEffects_xlsx)]
        [InlineData(TestDataStorage.O14ISOStrict.Graphics.File3D_Bar_O12_XL_Charts_xlsx)]
        [InlineData(TestDataStorage.O14ISOStrict.Graphics.File3D_RotationParallel_O12_XL_OartEffects_xlsx)]
        [InlineData(TestDataStorage.O14ISOStrict.Graphics.File3DRotation_O12_XL_OartTextEffects_xlsx)]
        [InlineData(TestDataStorage.O14ISOStrict.Graphics.ActiveXControls_O12_XL_Controls_xlsx)]
        [InlineData(TestDataStorage.O14ISOStrict.Graphics.Axis_Title_O12_XL_ChartProperties_xlsx)]
        [InlineData(TestDataStorage.O14ISOStrict.Graphics.Bevel_O12_XL_OartEffects_xlsx)]
        [InlineData(TestDataStorage.O14ISOStrict.Graphics.File2D_Area_O12_PPT_Charts_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.Graphics.File3D_Pie_O12_PPT_Charts_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.Graphics.File5_9_3_7unfinished_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.Graphics.Accent1sysClr_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.Graphics.algnDist_mainLvl5ppr_AlignmentLevel5Distributed_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.Graphics.algnJustLow_mainLvl4ppr_AlignmentLevel4JustifiedLow_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.Graphics.algnJust_mainLvl4ppr_AlignmentLevel4Justified_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.Graphics.algnR_mainLvl5ppr_AlignmentLevel5Right_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.Graphics.algnThaiDist_mainLvl5ppr_AlignmentLevel5ThaiDistributed_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.Graphics.anchorModified_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.Graphics.audioCdModifiedAndReSaved_pptx)]

        // Excel documents
        [InlineData(TestDataStorage.O14ISOStrict.Excel.File2D_Rotation_O12_XL_OartEffects_xlsx)]
        [InlineData(TestDataStorage.O14ISOStrict.Excel.Contrast_O12_XL_PictureProperties_xlsx)]
        [InlineData(TestDataStorage.O14ISOStrict.Excel.filter_type_xlsx)]
        [InlineData(TestDataStorage.O14ISOStrict.Excel.Hyperlinks_on_OArt_Objects_O12_XL_Hyperlinks_xlsx)]
        [InlineData(TestDataStorage.O14ISOStrict.Excel.OLE_O12_XL_OLE_xlsx)]
        [InlineData(TestDataStorage.O14ISOStrict.Excel.Photo_Formats___CGM_O12_XL_Pictures_xlsx)]
        [InlineData(TestDataStorage.O14ISOStrict.Excel.RecolorGraphics_mode_O12_XL_PictureProperties_xlsx)]
        [InlineData(TestDataStorage.O14ISOStrict.Excel.xl8galry_xlsx)]

        // Word documents
        [InlineData(TestDataStorage.O14ISOStrict.Word.AbbreviatedCaseNumber_Abbreviated_Case_Number_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.argSz_Argument_Size_Sub_Superscript_Function_Superscript_val__2_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.bdr_Text_Border_themeColor_text1_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.BookAuthor_Book_Author_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.bottom_Bottom_Border_themeColor_dark1_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.bottom_Bottom_Border_val_holly_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.bottom_Bottom_Border_val_zigZagStitch_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.bottom_Table_Cell_Bottom_Border_val_double_docx_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.City_City_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.clrSchemeMapping_theme_color_w_bg2_background2_light1_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.CommentRangeStart_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.customXmlDelRangeStart_Custom_XML_Markup_Deletion_Start_val_author_special_chars_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.document___HexColor___RGB___Document_Background_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.eastAsianLayout_East_Asian_Typography_Settings_vert_1_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.fldSimple_Field_Definitions_GreetingLine_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.fldSimple_FormulasAndExpressions_Bookmark_GeneralFormat_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.ftr___Footer___bookmarkStart___Bookmark_Start_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.highlight_Text_Highlighting_val_blue_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.insideH_Table_Inside_Horizontal_Edges_Border_val_thinThickThinSmallGap_docx_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.instrText_Field_Definitions_EQ_Array_AlignLeft_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.instrText_Field_Definitions_NextIf_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.isLgl_Display_All_Levels_Using_Arabic_Numerals_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.lang_Languages_for_Run_Content_val_moh_CA_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.left_Left_Border_sz_24_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.left_Left_Border_val_gems_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.left_Left_Border_val_weavingAngles_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.left_Table_Left_Border_themeColor_background1_docx_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.lid_Merge_Field_Name_Language_ID_val_es_CR_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.lid_Merge_Field_Name_Language_ID_val_th_TH_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.mailSubject_Merged_E_mail_or_Fax_Subject_Line_val_test_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.name_Data_Source_Name_for_Column_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.numFmt_Endnote_Numbering_Format_val_40_none_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.numFmt_Numbering_Format_val_decimalEnclosedFullstop_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.paperSrc_Paper_Source_Information_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.pgNumType_Page_Numbering_Settings_fmt_thaiNumbers_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.proofErr_Proofing_Error_Anchor___gramStart_and_gramEnd_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.rFonts_Run_Fonts_hAnsiTheme_majorHAnsi_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.right_Right_Border_val_cakeSlice_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.right_Right_Border_val_peopleHats_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.right_Right_Paragraph_Border_val_threeDEmboss_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.rPr_bdr_Text_Border_valdotDash_colorauto_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.rSp_Row_Spacing_Equation_Array_Function_val_1080_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.sectPr_Previous_Section_Properties_rsidSelect_004B4C75_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.shd_Run_Shading_val_pct15_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.shd_Table_Shading_val_pct5_docx_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.spacing_Spacing_Between_Lines_and_AboveBelow_Paragraph_line_1_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.summaryLength_Percentage_of_Document_to_Use_When_Generating_Summary_val_100_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.tblLayout_Table_Layout_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.textDirection_Paragraph_Text_Flow_Direction_val_tbRl_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.top_Table_Top_Border_sz_255_docx)]

        // Powerpoint documents
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.File4_6_10_bg_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.algnDist_mainLvl2ppr_AlignmentLevel2Distributed_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.algnJustLow_mainLvl1ppr_AlignmentLevel1JustifiedLow_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.algnJust_mainLvl1ppr_AlignmentLevel1Justified_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.algnR_mainLvl2ppr_AlignmentLevel2Right_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.algnThaiDist_mainLvl2ppr_AlignmentLevel2ThaiDistributed_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.altLang_mainEndParaRpr_AlternateLanguage_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.bg_Background_bwmode_invgray_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.bldlst_Build_Graphics_bldgraphic_uiexpand_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.browse_BrowseSlideShowMode_showScrollBar_0_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.cmpdThickThin_mainUln_UnderlineStrokeCompoundLineTypeThickThin_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.dbl_endParaRprU_EndofParagraphUnderlineDouble_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.err_mainEndParaRpr_SpellingError_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.fontAlgnB_mainLvl1ppr_FontAlignmentLevel1Bottom_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.fontAlgnCtr_mainLvl1ppr_FontAlignmentLevel1Center_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.fontAlgnT_mainLvl1ppr_FontAlignementLevel1Top_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.fontScale100000_mainNormAutofit_FontScaleMaximum_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.indent_51206400_mainLvl2ppr_IndentLevel2Minimum_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.indent51206400_mainLvl1ppr_IndentLevel1Maximum_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.kern0_mainEndParaRpr_KerningMinimum_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.lvl0_mainLvl3prr_Level0_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.lvl8_mainLvl4prr_Level8_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.main_bodyPr_anchor_dist_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.main_bodyPr_rtlCol_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.main_buautonum_type_alphaLcPeriod_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.main_buautonum_type_arabicPeriod_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.main_buautonum_type_ea1jpnkorperiod_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.main_buautonum_type_romanUCParenBoth_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.main_bufont_panose_10_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.main_cs_panose_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.main_defppr_ealnbrk_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.main_defppr_indent_51206400_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.main_defppr_marR_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.main_ppr_algn_dist_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.main_ppr_fontalgn_t_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.main_rpr_strike_dblstrike_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.main_rpr_u_dotdash_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.main_rpr_u_wavydbl_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.marL0_mainLvl8ppr_MarginLeftMinimum_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.marL51206400_mainPpr_LeftMarginMaximum_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.marR51206400_mainLvl2ppr_MarginRightLevel2Maximum_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.none_endParaRprU_EndOfParagraphUnderlineNone_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.normAutoFit_mainbodyPr_NoAutoFit_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.Photo_Album3_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.presentation_Zoom_of_the_embedded_OLE_Object_Server_Zoom_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.rIns_bodyPr_RightMargin_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.sldsz_Slide_Size_type_b4iso_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.sldsz_Slide_Size_type_screen16x9_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.spc_400000_rPr_CharacterSpacingMinimum_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.strikeNoStrike_mainDefRPr_StrikethroughDefaultNoStrike_pptx)]
        public void ValidateISOStrictNamespace(string path)
        {
            using (var file = OpenFile(path, false))
            using (var document = file.Open(false))
            {
                var isoValidator = new OpenXmlValidator(FileFormatVersions.Office2010);
                var errorList = isoValidator.Validate(document);

                Assert.NotNull(errorList);
            }
        }
    }
}
