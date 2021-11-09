// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Validation;
using Xunit;

using static DocumentFormat.OpenXml.Tests.TestAssets;

namespace DocumentFormat.OpenXml.Tests
{
    /// <summary>
    /// Test for ISO Strict file format on Open XML SDK
    /// </summary>
    public class IsoStrictTest
    {
        /// <summary>
        /// Office15TCM: 41257: OOXML SDK: ISO Strict Namespace / Relationship Mapping - Readability
        /// </summary>
        [Theory]
        [InlineData(TestDataStorage.O14ISOStrict.Word.AbbreviatedCaseNumber_Abbreviated_Case_Number_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.ArgSz_Argument_Size_Sub_Superscript_Function_Superscript_val__2_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.Bdr_Text_Border_themeColor_text1_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.BookAuthor_Book_Author_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.Bottom_Bottom_Border_themeColor_dark1_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.File4_6_10_bg_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.AlgnDist_mainLvl2ppr_AlignmentLevel2Distributed_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.AlgnJustLow_mainLvl1ppr_AlignmentLevel1JustifiedLow_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.AlgnJust_mainLvl1ppr_AlignmentLevel1Justified_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.AlgnR_mainLvl2ppr_AlignmentLevel2Right_pptx)]
        public void TestISOStrictNamespace(string path)
        {
            using (var file = OpenFile(path, false))
            using (var document = file.Open(false))
            {
                Assert.True(document.StrictRelationshipFound);
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
        [InlineData(TestDataStorage.O14ISOStrict.Graphics.AlgnDist_mainLvl5ppr_AlignmentLevel5Distributed_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.Graphics.AlgnJustLow_mainLvl4ppr_AlignmentLevel4JustifiedLow_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.Graphics.AlgnJust_mainLvl4ppr_AlignmentLevel4Justified_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.Graphics.AlgnR_mainLvl5ppr_AlignmentLevel5Right_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.Graphics.AlgnThaiDist_mainLvl5ppr_AlignmentLevel5ThaiDistributed_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.Graphics.AnchorModified_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.Graphics.AudioCdModifiedAndReSaved_pptx)]

        // Excel documents
        [InlineData(TestDataStorage.O14ISOStrict.Excel.File2D_Rotation_O12_XL_OartEffects_xlsx)]
        [InlineData(TestDataStorage.O14ISOStrict.Excel.Contrast_O12_XL_PictureProperties_xlsx)]
        [InlineData(TestDataStorage.O14ISOStrict.Excel.Filter_type_xlsx)]
        [InlineData(TestDataStorage.O14ISOStrict.Excel.Hyperlinks_on_OArt_Objects_O12_XL_Hyperlinks_xlsx)]
        [InlineData(TestDataStorage.O14ISOStrict.Excel.OLE_O12_XL_OLE_xlsx)]
        [InlineData(TestDataStorage.O14ISOStrict.Excel.Photo_Formats___CGM_O12_XL_Pictures_xlsx)]
        [InlineData(TestDataStorage.O14ISOStrict.Excel.RecolorGraphics_mode_O12_XL_PictureProperties_xlsx)]
        [InlineData(TestDataStorage.O14ISOStrict.Excel.Xl8galry_xlsx)]

        // Word documents
        [InlineData(TestDataStorage.O14ISOStrict.Word.AbbreviatedCaseNumber_Abbreviated_Case_Number_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.ArgSz_Argument_Size_Sub_Superscript_Function_Superscript_val__2_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.Bdr_Text_Border_themeColor_text1_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.BookAuthor_Book_Author_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.Bottom_Bottom_Border_themeColor_dark1_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.Bottom_Bottom_Border_val_holly_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.Bottom_Bottom_Border_val_zigZagStitch_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.Bottom_Table_Cell_Bottom_Border_val_double_docx_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.City_City_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.ClrSchemeMapping_theme_color_w_bg2_background2_light1_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.CommentRangeStart_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.CustomXmlDelRangeStart_Custom_XML_Markup_Deletion_Start_val_author_special_chars_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.Document___HexColor___RGB___Document_Background_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.EastAsianLayout_East_Asian_Typography_Settings_vert_1_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.FldSimple_Field_Definitions_GreetingLine_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.FldSimple_FormulasAndExpressions_Bookmark_GeneralFormat_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.Ftr___Footer___bookmarkStart___Bookmark_Start_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.Highlight_Text_Highlighting_val_blue_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.InsideH_Table_Inside_Horizontal_Edges_Border_val_thinThickThinSmallGap_docx_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.InstrText_Field_Definitions_EQ_Array_AlignLeft_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.InstrText_Field_Definitions_NextIf_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.IsLgl_Display_All_Levels_Using_Arabic_Numerals_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.Lang_Languages_for_Run_Content_val_moh_CA_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.Left_Left_Border_sz_24_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.Left_Left_Border_val_gems_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.Left_Left_Border_val_weavingAngles_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.Left_Table_Left_Border_themeColor_background1_docx_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.Lid_Merge_Field_Name_Language_ID_val_es_CR_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.Lid_Merge_Field_Name_Language_ID_val_th_TH_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.MailSubject_Merged_E_mail_or_Fax_Subject_Line_val_test_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.Name_Data_Source_Name_for_Column_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.NumFmt_Endnote_Numbering_Format_val_40_none_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.NumFmt_Numbering_Format_val_decimalEnclosedFullstop_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.PaperSrc_Paper_Source_Information_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.PgNumType_Page_Numbering_Settings_fmt_thaiNumbers_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.ProofErr_Proofing_Error_Anchor___gramStart_and_gramEnd_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.RFonts_Run_Fonts_hAnsiTheme_majorHAnsi_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.Right_Right_Border_val_cakeSlice_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.Right_Right_Border_val_peopleHats_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.Right_Right_Paragraph_Border_val_threeDEmboss_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.RPr_bdr_Text_Border_valdotDash_colorauto_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.RSp_Row_Spacing_Equation_Array_Function_val_1080_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.SectPr_Previous_Section_Properties_rsidSelect_004B4C75_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.Shd_Run_Shading_val_pct15_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.Shd_Table_Shading_val_pct5_docx_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.Spacing_Spacing_Between_Lines_and_AboveBelow_Paragraph_line_1_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.SummaryLength_Percentage_of_Document_to_Use_When_Generating_Summary_val_100_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.TblLayout_Table_Layout_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.TextDirection_Paragraph_Text_Flow_Direction_val_tbRl_docx)]
        [InlineData(TestDataStorage.O14ISOStrict.Word.Top_Table_Top_Border_sz_255_docx)]

        // Powerpoint documents
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.File4_6_10_bg_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.AlgnDist_mainLvl2ppr_AlignmentLevel2Distributed_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.AlgnJustLow_mainLvl1ppr_AlignmentLevel1JustifiedLow_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.AlgnJust_mainLvl1ppr_AlignmentLevel1Justified_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.AlgnR_mainLvl2ppr_AlignmentLevel2Right_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.AlgnThaiDist_mainLvl2ppr_AlignmentLevel2ThaiDistributed_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.AltLang_mainEndParaRpr_AlternateLanguage_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.Bg_Background_bwmode_invgray_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.Bldlst_Build_Graphics_bldgraphic_uiexpand_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.Browse_BrowseSlideShowMode_showScrollBar_0_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.CmpdThickThin_mainUln_UnderlineStrokeCompoundLineTypeThickThin_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.Dbl_endParaRprU_EndofParagraphUnderlineDouble_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.Err_mainEndParaRpr_SpellingError_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.FontAlgnB_mainLvl1ppr_FontAlignmentLevel1Bottom_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.FontAlgnCtr_mainLvl1ppr_FontAlignmentLevel1Center_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.FontAlgnT_mainLvl1ppr_FontAlignementLevel1Top_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.FontScale100000_mainNormAutofit_FontScaleMaximum_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.Indent_51206400_mainLvl2ppr_IndentLevel2Minimum_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.Indent51206400_mainLvl1ppr_IndentLevel1Maximum_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.Kern0_mainEndParaRpr_KerningMinimum_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.Lvl0_mainLvl3prr_Level0_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.Lvl8_mainLvl4prr_Level8_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.Main_bodyPr_anchor_dist_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.Main_bodyPr_rtlCol_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.Main_buautonum_type_alphaLcPeriod_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.Main_buautonum_type_arabicPeriod_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.Main_buautonum_type_ea1jpnkorperiod_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.Main_buautonum_type_romanUCParenBoth_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.Main_bufont_panose_10_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.Main_cs_panose_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.Main_defppr_ealnbrk_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.Main_defppr_indent_51206400_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.Main_defppr_marR_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.Main_ppr_algn_dist_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.Main_ppr_fontalgn_t_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.Main_rpr_strike_dblstrike_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.Main_rpr_u_dotdash_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.Main_rpr_u_wavydbl_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.MarL0_mainLvl8ppr_MarginLeftMinimum_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.MarL51206400_mainPpr_LeftMarginMaximum_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.MarR51206400_mainLvl2ppr_MarginRightLevel2Maximum_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.None_endParaRprU_EndOfParagraphUnderlineNone_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.NormAutoFit_mainbodyPr_NoAutoFit_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.Photo_Album3_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.Presentation_Zoom_of_the_embedded_OLE_Object_Server_Zoom_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.RIns_bodyPr_RightMargin_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.Sldsz_Slide_Size_type_b4iso_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.Sldsz_Slide_Size_type_screen16x9_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.Spc_400000_rPr_CharacterSpacingMinimum_pptx)]
        [InlineData(TestDataStorage.O14ISOStrict.PowerPoint.StrikeNoStrike_mainDefRPr_StrikethroughDefaultNoStrike_pptx)]
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
