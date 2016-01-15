// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using DocumentFormat.OpenXml.Packaging;
using Ap = DocumentFormat.OpenXml.ExtendedProperties;
using Vt = DocumentFormat.OpenXml.VariantTypes;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Wordprocessing;
using W15 = DocumentFormat.OpenXml.Office2013.Word;
using M = DocumentFormat.OpenXml.Math;
using Ovml = DocumentFormat.OpenXml.Vml.Office;
using V = DocumentFormat.OpenXml.Vml;
using A = DocumentFormat.OpenXml.Drawing;

namespace DocumentFormat.OpenXml.Tests.ContentControlClass
{
    public class GeneratedDocument
    {
        // Creates a WordprocessingDocument.
        public void CreatePackage(string filePath)
        {
            using(WordprocessingDocument package = WordprocessingDocument.Create(filePath, WordprocessingDocumentType.Document))
            {
                CreateParts(package);
            }
        }

        // Adds child parts and generates content of the specified part.
        private void CreateParts(WordprocessingDocument document)
        {
            ExtendedFilePropertiesPart extendedFilePropertiesPart1 = document.AddNewPart<ExtendedFilePropertiesPart>("rId3");
            GenerateExtendedFilePropertiesPart1Content(extendedFilePropertiesPart1);

            MainDocumentPart mainDocumentPart1 = document.AddMainDocumentPart();
            GenerateMainDocumentPart1Content(mainDocumentPart1);

            GlossaryDocumentPart glossaryDocumentPart1 = mainDocumentPart1.AddNewPart<GlossaryDocumentPart>("rId8");
            GenerateGlossaryDocumentPart1Content(glossaryDocumentPart1);

            DocumentSettingsPart documentSettingsPart1 = glossaryDocumentPart1.AddNewPart<DocumentSettingsPart>("rId3");
            GenerateDocumentSettingsPart1Content(documentSettingsPart1);

            StylesWithEffectsPart stylesWithEffectsPart1 = glossaryDocumentPart1.AddNewPart<StylesWithEffectsPart>("rId2");
            GenerateStylesWithEffectsPart1Content(stylesWithEffectsPart1);

            StyleDefinitionsPart styleDefinitionsPart1 = glossaryDocumentPart1.AddNewPart<StyleDefinitionsPart>("rId1");
            GenerateStyleDefinitionsPart1Content(styleDefinitionsPart1);

            FontTablePart fontTablePart1 = glossaryDocumentPart1.AddNewPart<FontTablePart>("rId5");
            GenerateFontTablePart1Content(fontTablePart1);

            WebSettingsPart webSettingsPart1 = glossaryDocumentPart1.AddNewPart<WebSettingsPart>("rId4");
            GenerateWebSettingsPart1Content(webSettingsPart1);

            DocumentSettingsPart documentSettingsPart2 = mainDocumentPart1.AddNewPart<DocumentSettingsPart>("rId3");
            GenerateDocumentSettingsPart2Content(documentSettingsPart2);

            FontTablePart fontTablePart2 = mainDocumentPart1.AddNewPart<FontTablePart>("rId7");
            GenerateFontTablePart2Content(fontTablePart2);

            StylesWithEffectsPart stylesWithEffectsPart2 = mainDocumentPart1.AddNewPart<StylesWithEffectsPart>("rId2");
            GenerateStylesWithEffectsPart2Content(stylesWithEffectsPart2);

            StyleDefinitionsPart styleDefinitionsPart2 = mainDocumentPart1.AddNewPart<StyleDefinitionsPart>("rId1");
            GenerateStyleDefinitionsPart2Content(styleDefinitionsPart2);

            EndnotesPart endnotesPart1 = mainDocumentPart1.AddNewPart<EndnotesPart>("rId6");
            GenerateEndnotesPart1Content(endnotesPart1);

            FootnotesPart footnotesPart1 = mainDocumentPart1.AddNewPart<FootnotesPart>("rId5");
            GenerateFootnotesPart1Content(footnotesPart1);

            WebSettingsPart webSettingsPart2 = mainDocumentPart1.AddNewPart<WebSettingsPart>("rId4");
            GenerateWebSettingsPart2Content(webSettingsPart2);

            ThemePart themePart1 = mainDocumentPart1.AddNewPart<ThemePart>("rId9");
            GenerateThemePart1Content(themePart1);

            SetPackageProperties(document);
        }

        // Generates content of extendedFilePropertiesPart1.
        private void GenerateExtendedFilePropertiesPart1Content(ExtendedFilePropertiesPart extendedFilePropertiesPart1)
        {
            Ap.Properties properties1 = new Ap.Properties();
            properties1.AddNamespaceDeclaration("vt", "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes");
            Ap.Template template1 = new Ap.Template();
            template1.Text = "Normal.dotm";
            Ap.TotalTime totalTime1 = new Ap.TotalTime();
            totalTime1.Text = "52";
            Ap.Pages pages1 = new Ap.Pages();
            pages1.Text = "1";
            Ap.Words words1 = new Ap.Words();
            words1.Text = "76";
            Ap.Characters characters1 = new Ap.Characters();
            characters1.Text = "439";
            Ap.Application application1 = new Ap.Application();
            application1.Text = "Microsoft Office Word";
            Ap.DocumentSecurity documentSecurity1 = new Ap.DocumentSecurity();
            documentSecurity1.Text = "0";
            Ap.Lines lines1 = new Ap.Lines();
            lines1.Text = "3";
            Ap.Paragraphs paragraphs1 = new Ap.Paragraphs();
            paragraphs1.Text = "1";
            Ap.ScaleCrop scaleCrop1 = new Ap.ScaleCrop();
            scaleCrop1.Text = "false";

            Ap.HeadingPairs headingPairs1 = new Ap.HeadingPairs();

            Vt.VTVector vTVector1 = new Vt.VTVector(){ BaseType = Vt.VectorBaseValues.Variant, Size = (UInt32Value)2U };

            Vt.Variant variant1 = new Vt.Variant();
            Vt.VTLPSTR vTLPSTR1 = new Vt.VTLPSTR();
            vTLPSTR1.Text = "Title";

            variant1.Append(vTLPSTR1);

            Vt.Variant variant2 = new Vt.Variant();
            Vt.VTInt32 vTInt321 = new Vt.VTInt32();
            vTInt321.Text = "1";

            variant2.Append(vTInt321);

            vTVector1.Append(variant1);
            vTVector1.Append(variant2);

            headingPairs1.Append(vTVector1);

            Ap.TitlesOfParts titlesOfParts1 = new Ap.TitlesOfParts();

            Vt.VTVector vTVector2 = new Vt.VTVector(){ BaseType = Vt.VectorBaseValues.Lpstr, Size = (UInt32Value)1U };
            Vt.VTLPSTR vTLPSTR2 = new Vt.VTLPSTR();
            vTLPSTR2.Text = "";

            vTVector2.Append(vTLPSTR2);

            titlesOfParts1.Append(vTVector2);
            Ap.Company company1 = new Ap.Company();
            company1.Text = "";
            Ap.LinksUpToDate linksUpToDate1 = new Ap.LinksUpToDate();
            linksUpToDate1.Text = "false";
            Ap.CharactersWithSpaces charactersWithSpaces1 = new Ap.CharactersWithSpaces();
            charactersWithSpaces1.Text = "514";
            Ap.SharedDocument sharedDocument1 = new Ap.SharedDocument();
            sharedDocument1.Text = "false";
            Ap.HyperlinksChanged hyperlinksChanged1 = new Ap.HyperlinksChanged();
            hyperlinksChanged1.Text = "false";
            Ap.ApplicationVersion applicationVersion1 = new Ap.ApplicationVersion();
            applicationVersion1.Text = "15.0000";

            properties1.Append(template1);
            properties1.Append(totalTime1);
            properties1.Append(pages1);
            properties1.Append(words1);
            properties1.Append(characters1);
            properties1.Append(application1);
            properties1.Append(documentSecurity1);
            properties1.Append(lines1);
            properties1.Append(paragraphs1);
            properties1.Append(scaleCrop1);
            properties1.Append(headingPairs1);
            properties1.Append(titlesOfParts1);
            properties1.Append(company1);
            properties1.Append(linksUpToDate1);
            properties1.Append(charactersWithSpaces1);
            properties1.Append(sharedDocument1);
            properties1.Append(hyperlinksChanged1);
            properties1.Append(applicationVersion1);

            extendedFilePropertiesPart1.Properties = properties1;
        }

        // Generates content of mainDocumentPart1.
        private void GenerateMainDocumentPart1Content(MainDocumentPart mainDocumentPart1)
        {
            Document document1 = new Document(){ MCAttributes = new MarkupCompatibilityAttributes(){ Ignorable = "w14 w15 wp14" }  };
            document1.AddNamespaceDeclaration("wpc", "http://schemas.microsoft.com/office/word/2010/wordprocessingCanvas");
            document1.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            document1.AddNamespaceDeclaration("o", "urn:schemas-microsoft-com:office:office");
            document1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            document1.AddNamespaceDeclaration("m", "http://schemas.openxmlformats.org/officeDocument/2006/math");
            document1.AddNamespaceDeclaration("v", "urn:schemas-microsoft-com:vml");
            document1.AddNamespaceDeclaration("wp14", "http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing");
            document1.AddNamespaceDeclaration("wp", "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing");
            document1.AddNamespaceDeclaration("w10", "urn:schemas-microsoft-com:office:word");
            document1.AddNamespaceDeclaration("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main");
            document1.AddNamespaceDeclaration("w14", "http://schemas.microsoft.com/office/word/2010/wordml");
            document1.AddNamespaceDeclaration("w15", "http://schemas.microsoft.com/office/word/2010/11/wordml");
            document1.AddNamespaceDeclaration("wpg", "http://schemas.microsoft.com/office/word/2010/wordprocessingGroup");
            document1.AddNamespaceDeclaration("wpi", "http://schemas.microsoft.com/office/word/2010/wordprocessingInk");
            document1.AddNamespaceDeclaration("wne", "http://schemas.microsoft.com/office/word/2006/wordml");
            document1.AddNamespaceDeclaration("wps", "http://schemas.microsoft.com/office/word/2010/wordprocessingShape");

            Body body1 = new Body();

            SdtBlock sdtBlock1 = new SdtBlock();

            SdtProperties sdtProperties1 = new SdtProperties();

            RunProperties runProperties1 = new RunProperties();
            RunFonts runFonts1 = new RunFonts(){ Hint = FontTypeHintValues.EastAsia };

            runProperties1.Append(runFonts1);
            SdtAlias sdtAlias1 = new SdtAlias(){ Val = "Test1.1.1" };
            Tag tag1 = new Tag(){ Val = "Test1.1.1" };
            SdtId sdtId1 = new SdtId(){ Val = -1832063964 };

            SdtPlaceholder sdtPlaceholder1 = new SdtPlaceholder();
            DocPartReference docPartReference1 = new DocPartReference(){ Val = "DefaultPlaceholder_1081868558" };

            sdtPlaceholder1.Append(docPartReference1);
            ShowingPlaceholder showingPlaceholder1 = new ShowingPlaceholder();
            SdtContentText sdtContentText1 = new SdtContentText();

            sdtProperties1.Append(runProperties1);
            sdtProperties1.Append(sdtAlias1);
            sdtProperties1.Append(tag1);
            sdtProperties1.Append(sdtId1);
            sdtProperties1.Append(sdtPlaceholder1);
            sdtProperties1.Append(showingPlaceholder1);
            sdtProperties1.Append(sdtContentText1);
            SdtEndCharProperties sdtEndCharProperties1 = new SdtEndCharProperties();

            SdtContentBlock sdtContentBlock1 = new SdtContentBlock();

            Paragraph paragraph1 = new Paragraph(){ RsidParagraphAddition = "00535C5E", RsidRunAdditionDefault = "000010BA" };

            Run run1 = new Run(){ RsidRunProperties = "003E0DED" };

            RunProperties runProperties2 = new RunProperties();
            RunStyle runStyle1 = new RunStyle(){ Val = "PlaceholderText" };

            runProperties2.Append(runStyle1);
            Text text1 = new Text();
            text1.Text = "Click here to enter text.";

            run1.Append(runProperties2);
            run1.Append(text1);

            paragraph1.Append(run1);

            sdtContentBlock1.Append(paragraph1);

            sdtBlock1.Append(sdtProperties1);
            sdtBlock1.Append(sdtEndCharProperties1);
            sdtBlock1.Append(sdtContentBlock1);

            SdtBlock sdtBlock2 = new SdtBlock();

            SdtProperties sdtProperties2 = new SdtProperties();

            RunProperties runProperties3 = new RunProperties();
            RunFonts runFonts2 = new RunFonts(){ Hint = FontTypeHintValues.EastAsia };

            runProperties3.Append(runFonts2);
            SdtAlias sdtAlias2 = new SdtAlias(){ Val = "Test1.1.2" };
            Tag tag2 = new Tag(){ Val = "Test1.1.2" };
            SdtId sdtId2 = new SdtId(){ Val = -2043657734 };

            SdtPlaceholder sdtPlaceholder2 = new SdtPlaceholder();
            DocPartReference docPartReference2 = new DocPartReference(){ Val = "DefaultPlaceholder_1081868558" };

            sdtPlaceholder2.Append(docPartReference2);
            SdtContentText sdtContentText2 = new SdtContentText();

            sdtProperties2.Append(runProperties3);
            sdtProperties2.Append(sdtAlias2);
            sdtProperties2.Append(tag2);
            sdtProperties2.Append(sdtId2);
            sdtProperties2.Append(sdtPlaceholder2);
            sdtProperties2.Append(sdtContentText2);
            SdtEndCharProperties sdtEndCharProperties2 = new SdtEndCharProperties();

            SdtContentBlock sdtContentBlock2 = new SdtContentBlock();

            Paragraph paragraph2 = new Paragraph(){ RsidParagraphAddition = "000010BA", RsidRunAdditionDefault = "000010BA" };

            Run run2 = new Run();

            RunProperties runProperties4 = new RunProperties();
            RunFonts runFonts3 = new RunFonts(){ Hint = FontTypeHintValues.EastAsia };

            runProperties4.Append(runFonts3);
            Text text2 = new Text();
            text2.Text = "Test string";

            run2.Append(runProperties4);
            run2.Append(text2);

            paragraph2.Append(run2);

            sdtContentBlock2.Append(paragraph2);

            sdtBlock2.Append(sdtProperties2);
            sdtBlock2.Append(sdtEndCharProperties2);
            sdtBlock2.Append(sdtContentBlock2);

            SdtBlock sdtBlock3 = new SdtBlock();

            SdtProperties sdtProperties3 = new SdtProperties();

            RunProperties runProperties5 = new RunProperties();
            RunFonts runFonts4 = new RunFonts(){ Hint = FontTypeHintValues.EastAsia };

            runProperties5.Append(runFonts4);
            SdtAlias sdtAlias3 = new SdtAlias(){ Val = "Test1.2.1" };
            Tag tag3 = new Tag(){ Val = "Test1.2.1" };
            SdtId sdtId3 = new SdtId(){ Val = 401180698 };

            SdtPlaceholder sdtPlaceholder3 = new SdtPlaceholder();
            DocPartReference docPartReference3 = new DocPartReference(){ Val = "DefaultPlaceholder_1081868558" };

            sdtPlaceholder3.Append(docPartReference3);
            SdtContentText sdtContentText3 = new SdtContentText();

            sdtProperties3.Append(runProperties5);
            sdtProperties3.Append(sdtAlias3);
            sdtProperties3.Append(tag3);
            sdtProperties3.Append(sdtId3);
            sdtProperties3.Append(sdtPlaceholder3);
            sdtProperties3.Append(sdtContentText3);
            SdtEndCharProperties sdtEndCharProperties3 = new SdtEndCharProperties();

            SdtContentBlock sdtContentBlock3 = new SdtContentBlock();

            Paragraph paragraph3 = new Paragraph(){ RsidParagraphAddition = "000010BA", RsidRunAdditionDefault = "000010BA" };

            Run run3 = new Run();

            RunProperties runProperties6 = new RunProperties();
            RunFonts runFonts5 = new RunFonts(){ Hint = FontTypeHintValues.EastAsia };

            runProperties6.Append(runFonts5);
            Text text3 = new Text();
            text3.Text = "Appearance1";

            run3.Append(runProperties6);
            run3.Append(text3);

            paragraph3.Append(run3);

            sdtContentBlock3.Append(paragraph3);

            sdtBlock3.Append(sdtProperties3);
            sdtBlock3.Append(sdtEndCharProperties3);
            sdtBlock3.Append(sdtContentBlock3);

            SdtBlock sdtBlock4 = new SdtBlock();

            SdtProperties sdtProperties4 = new SdtProperties();

            RunProperties runProperties7 = new RunProperties();
            RunFonts runFonts6 = new RunFonts(){ Hint = FontTypeHintValues.EastAsia };

            runProperties7.Append(runFonts6);
            SdtAlias sdtAlias4 = new SdtAlias(){ Val = "Test1.2.2" };
            Tag tag4 = new Tag(){ Val = "Test1.2.2" };
            SdtId sdtId4 = new SdtId(){ Val = 2096980748 };

            SdtPlaceholder sdtPlaceholder4 = new SdtPlaceholder();
            DocPartReference docPartReference4 = new DocPartReference(){ Val = "DefaultPlaceholder_1081868558" };

            sdtPlaceholder4.Append(docPartReference4);
            W15.Appearance appearance1 = new W15.Appearance(){ Val = W15.SdtAppearance.Tags };
            SdtContentText sdtContentText4 = new SdtContentText();

            sdtProperties4.Append(runProperties7);
            sdtProperties4.Append(sdtAlias4);
            sdtProperties4.Append(tag4);
            sdtProperties4.Append(sdtId4);
            sdtProperties4.Append(sdtPlaceholder4);
            sdtProperties4.Append(appearance1);
            sdtProperties4.Append(sdtContentText4);
            SdtEndCharProperties sdtEndCharProperties4 = new SdtEndCharProperties();

            SdtContentBlock sdtContentBlock4 = new SdtContentBlock();

            Paragraph paragraph4 = new Paragraph(){ RsidParagraphAddition = "000010BA", RsidRunAdditionDefault = "000010BA" };

            Run run4 = new Run();

            RunProperties runProperties8 = new RunProperties();
            RunFonts runFonts7 = new RunFonts(){ Hint = FontTypeHintValues.EastAsia };

            runProperties8.Append(runFonts7);
            Text text4 = new Text();
            text4.Text = "Appearance2";

            run4.Append(runProperties8);
            run4.Append(text4);

            paragraph4.Append(run4);

            sdtContentBlock4.Append(paragraph4);

            sdtBlock4.Append(sdtProperties4);
            sdtBlock4.Append(sdtEndCharProperties4);
            sdtBlock4.Append(sdtContentBlock4);

            SdtBlock sdtBlock5 = new SdtBlock();

            SdtProperties sdtProperties5 = new SdtProperties();

            RunProperties runProperties9 = new RunProperties();
            RunFonts runFonts8 = new RunFonts(){ Hint = FontTypeHintValues.EastAsia };

            runProperties9.Append(runFonts8);
            SdtAlias sdtAlias5 = new SdtAlias(){ Val = "Test1.2.3" };
            Tag tag5 = new Tag(){ Val = "Test1.2.3" };
            SdtId sdtId5 = new SdtId(){ Val = -343394056 };

            SdtPlaceholder sdtPlaceholder5 = new SdtPlaceholder();
            DocPartReference docPartReference5 = new DocPartReference(){ Val = "DefaultPlaceholder_1081868558" };

            sdtPlaceholder5.Append(docPartReference5);
            W15.Appearance appearance2 = new W15.Appearance(){ Val = W15.SdtAppearance.Hidden };
            SdtContentText sdtContentText5 = new SdtContentText();

            sdtProperties5.Append(runProperties9);
            sdtProperties5.Append(sdtAlias5);
            sdtProperties5.Append(tag5);
            sdtProperties5.Append(sdtId5);
            sdtProperties5.Append(sdtPlaceholder5);
            sdtProperties5.Append(appearance2);
            sdtProperties5.Append(sdtContentText5);
            SdtEndCharProperties sdtEndCharProperties5 = new SdtEndCharProperties();

            SdtContentBlock sdtContentBlock5 = new SdtContentBlock();

            Paragraph paragraph5 = new Paragraph(){ RsidParagraphAddition = "000010BA", RsidRunAdditionDefault = "000010BA" };

            Run run5 = new Run();

            RunProperties runProperties10 = new RunProperties();
            RunFonts runFonts9 = new RunFonts(){ Hint = FontTypeHintValues.EastAsia };

            runProperties10.Append(runFonts9);
            Text text5 = new Text();
            text5.Text = "Appearance3";

            run5.Append(runProperties10);
            run5.Append(text5);

            paragraph5.Append(run5);

            sdtContentBlock5.Append(paragraph5);

            sdtBlock5.Append(sdtProperties5);
            sdtBlock5.Append(sdtEndCharProperties5);
            sdtBlock5.Append(sdtContentBlock5);

            SdtBlock sdtBlock6 = new SdtBlock();

            SdtProperties sdtProperties6 = new SdtProperties();

            RunProperties runProperties11 = new RunProperties();
            RunFonts runFonts10 = new RunFonts(){ Hint = FontTypeHintValues.EastAsia };

            runProperties11.Append(runFonts10);
            SdtAlias sdtAlias6 = new SdtAlias(){ Val = "Test1.3.1" };
            Tag tag6 = new Tag(){ Val = "Test1.3.1" };
            SdtId sdtId6 = new SdtId(){ Val = 1119424041 };

            SdtPlaceholder sdtPlaceholder6 = new SdtPlaceholder();
            DocPartReference docPartReference6 = new DocPartReference(){ Val = "DefaultPlaceholder_1081868558" };

            sdtPlaceholder6.Append(docPartReference6);
            SdtContentText sdtContentText6 = new SdtContentText();

            sdtProperties6.Append(runProperties11);
            sdtProperties6.Append(sdtAlias6);
            sdtProperties6.Append(tag6);
            sdtProperties6.Append(sdtId6);
            sdtProperties6.Append(sdtPlaceholder6);
            sdtProperties6.Append(sdtContentText6);
            SdtEndCharProperties sdtEndCharProperties6 = new SdtEndCharProperties();

            SdtContentBlock sdtContentBlock6 = new SdtContentBlock();

            Paragraph paragraph6 = new Paragraph(){ RsidParagraphAddition = "000010BA", RsidRunAdditionDefault = "000010BA" };

            Run run6 = new Run();

            RunProperties runProperties12 = new RunProperties();
            RunFonts runFonts11 = new RunFonts(){ Hint = FontTypeHintValues.EastAsia };

            runProperties12.Append(runFonts11);
            Text text6 = new Text();
            text6.Text = "Color Content Control1";

            run6.Append(runProperties12);
            run6.Append(text6);

            paragraph6.Append(run6);

            sdtContentBlock6.Append(paragraph6);

            sdtBlock6.Append(sdtProperties6);
            sdtBlock6.Append(sdtEndCharProperties6);
            sdtBlock6.Append(sdtContentBlock6);

            SdtBlock sdtBlock7 = new SdtBlock();

            SdtProperties sdtProperties7 = new SdtProperties();

            RunProperties runProperties13 = new RunProperties();
            RunFonts runFonts12 = new RunFonts(){ Hint = FontTypeHintValues.EastAsia };

            runProperties13.Append(runFonts12);
            SdtAlias sdtAlias7 = new SdtAlias(){ Val = "Test1.3.2" };
            Tag tag7 = new Tag(){ Val = "Test1.3.2" };
            SdtId sdtId7 = new SdtId(){ Val = 550972260 };

            SdtPlaceholder sdtPlaceholder7 = new SdtPlaceholder();
            DocPartReference docPartReference7 = new DocPartReference(){ Val = "DefaultPlaceholder_1081868558" };

            sdtPlaceholder7.Append(docPartReference7);
            W15.Color color1 = new W15.Color(){ Val = "0000FF" };
            SdtContentText sdtContentText7 = new SdtContentText();

            sdtProperties7.Append(runProperties13);
            sdtProperties7.Append(sdtAlias7);
            sdtProperties7.Append(tag7);
            sdtProperties7.Append(sdtId7);
            sdtProperties7.Append(sdtPlaceholder7);
            sdtProperties7.Append(color1);
            sdtProperties7.Append(sdtContentText7);
            SdtEndCharProperties sdtEndCharProperties7 = new SdtEndCharProperties();

            SdtContentBlock sdtContentBlock7 = new SdtContentBlock();

            Paragraph paragraph7 = new Paragraph(){ RsidParagraphAddition = "000010BA", RsidRunAdditionDefault = "000010BA" };

            Run run7 = new Run();

            RunProperties runProperties14 = new RunProperties();
            RunFonts runFonts13 = new RunFonts(){ Hint = FontTypeHintValues.EastAsia };

            runProperties14.Append(runFonts13);
            Text text7 = new Text();
            text7.Text = "Color Content Control2";

            run7.Append(runProperties14);
            run7.Append(text7);

            paragraph7.Append(run7);

            sdtContentBlock7.Append(paragraph7);

            sdtBlock7.Append(sdtProperties7);
            sdtBlock7.Append(sdtEndCharProperties7);
            sdtBlock7.Append(sdtContentBlock7);

            SdtBlock sdtBlock8 = new SdtBlock();

            SdtProperties sdtProperties8 = new SdtProperties();

            RunProperties runProperties15 = new RunProperties();
            RunFonts runFonts14 = new RunFonts(){ Hint = FontTypeHintValues.EastAsia };

            runProperties15.Append(runFonts14);
            SdtAlias sdtAlias8 = new SdtAlias(){ Val = "Test1.4.1" };
            Tag tag8 = new Tag(){ Val = "Test1.4.1" };
            SdtId sdtId8 = new SdtId(){ Val = 1758249604 };
            W15.SdtRepeatedSection sdtRepeatedSection1 = new W15.SdtRepeatedSection();

            sdtProperties8.Append(runProperties15);
            sdtProperties8.Append(sdtAlias8);
            sdtProperties8.Append(tag8);
            sdtProperties8.Append(sdtId8);
            sdtProperties8.Append(sdtRepeatedSection1);
            SdtEndCharProperties sdtEndCharProperties8 = new SdtEndCharProperties();

            SdtContentBlock sdtContentBlock8 = new SdtContentBlock();

            SdtBlock sdtBlock9 = new SdtBlock();

            SdtProperties sdtProperties9 = new SdtProperties();

            RunProperties runProperties16 = new RunProperties();
            RunFonts runFonts15 = new RunFonts(){ Hint = FontTypeHintValues.EastAsia };

            runProperties16.Append(runFonts15);
            SdtId sdtId9 = new SdtId(){ Val = 481433089 };

            SdtPlaceholder sdtPlaceholder8 = new SdtPlaceholder();
            DocPartReference docPartReference8 = new DocPartReference(){ Val = "DefaultPlaceholder_1081868562" };

            sdtPlaceholder8.Append(docPartReference8);
            ShowingPlaceholder showingPlaceholder2 = new ShowingPlaceholder();
            W15.SdtRepeatedSectionItem sdtRepeatedSectionItem1 = new W15.SdtRepeatedSectionItem();

            sdtProperties9.Append(runProperties16);
            sdtProperties9.Append(sdtId9);
            sdtProperties9.Append(sdtPlaceholder8);
            sdtProperties9.Append(showingPlaceholder2);
            sdtProperties9.Append(sdtRepeatedSectionItem1);
            SdtEndCharProperties sdtEndCharProperties9 = new SdtEndCharProperties();

            SdtContentBlock sdtContentBlock9 = new SdtContentBlock();

            Paragraph paragraph8 = new Paragraph(){ RsidParagraphAddition = "000010BA", RsidRunAdditionDefault = "000010BA" };

            Run run8 = new Run(){ RsidRunProperties = "003E0DED" };

            RunProperties runProperties17 = new RunProperties();
            RunStyle runStyle2 = new RunStyle(){ Val = "PlaceholderText" };

            runProperties17.Append(runStyle2);
            Text text8 = new Text();
            text8.Text = "Enter any content that you want to repeat, including other content controls. You can also insert this control around table rows in order to repeat parts of a table.";

            run8.Append(runProperties17);
            run8.Append(text8);

            paragraph8.Append(run8);

            sdtContentBlock9.Append(paragraph8);

            sdtBlock9.Append(sdtProperties9);
            sdtBlock9.Append(sdtEndCharProperties9);
            sdtBlock9.Append(sdtContentBlock9);

            sdtContentBlock8.Append(sdtBlock9);

            sdtBlock8.Append(sdtProperties8);
            sdtBlock8.Append(sdtEndCharProperties8);
            sdtBlock8.Append(sdtContentBlock8);

            SdtBlock sdtBlock10 = new SdtBlock();

            SdtProperties sdtProperties10 = new SdtProperties();

            RunProperties runProperties18 = new RunProperties();
            RunFonts runFonts16 = new RunFonts(){ Hint = FontTypeHintValues.EastAsia };

            runProperties18.Append(runFonts16);
            SdtAlias sdtAlias9 = new SdtAlias(){ Val = "Test1.4.2" };
            Tag tag9 = new Tag(){ Val = "Test1.4.2" };
            SdtId sdtId10 = new SdtId(){ Val = -78606169 };
            W15.SdtRepeatedSection sdtRepeatedSection2 = new W15.SdtRepeatedSection();

            sdtProperties10.Append(runProperties18);
            sdtProperties10.Append(sdtAlias9);
            sdtProperties10.Append(tag9);
            sdtProperties10.Append(sdtId10);
            sdtProperties10.Append(sdtRepeatedSection2);
            SdtEndCharProperties sdtEndCharProperties10 = new SdtEndCharProperties();

            SdtContentBlock sdtContentBlock10 = new SdtContentBlock();

            SdtBlock sdtBlock11 = new SdtBlock();

            SdtProperties sdtProperties11 = new SdtProperties();

            RunProperties runProperties19 = new RunProperties();
            RunFonts runFonts17 = new RunFonts(){ Hint = FontTypeHintValues.EastAsia };

            runProperties19.Append(runFonts17);
            SdtId sdtId11 = new SdtId(){ Val = -1356270719 };

            SdtPlaceholder sdtPlaceholder9 = new SdtPlaceholder();
            DocPartReference docPartReference9 = new DocPartReference(){ Val = "DefaultPlaceholder_1081868562" };

            sdtPlaceholder9.Append(docPartReference9);
            W15.SdtRepeatedSectionItem sdtRepeatedSectionItem2 = new W15.SdtRepeatedSectionItem();

            sdtProperties11.Append(runProperties19);
            sdtProperties11.Append(sdtId11);
            sdtProperties11.Append(sdtPlaceholder9);
            sdtProperties11.Append(sdtRepeatedSectionItem2);
            SdtEndCharProperties sdtEndCharProperties11 = new SdtEndCharProperties();

            SdtContentBlock sdtContentBlock11 = new SdtContentBlock();

            Paragraph paragraph9 = new Paragraph(){ RsidParagraphAddition = "000010BA", RsidRunAdditionDefault = "000010BA" };
            ProofError proofError1 = new ProofError(){ Type = ProofingErrorValues.SpellStart };
            ProofError proofError2 = new ProofError(){ Type = ProofingErrorValues.GrammarStart };

            Run run9 = new Run();

            RunProperties runProperties20 = new RunProperties();
            RunFonts runFonts18 = new RunFonts(){ Hint = FontTypeHintValues.EastAsia };

            runProperties20.Append(runFonts18);
            Text text9 = new Text();
            text9.Text = "repeatingSectionItem";

            run9.Append(runProperties20);
            run9.Append(text9);
            ProofError proofError3 = new ProofError(){ Type = ProofingErrorValues.SpellEnd };
            ProofError proofError4 = new ProofError(){ Type = ProofingErrorValues.GrammarEnd };

            paragraph9.Append(proofError1);
            paragraph9.Append(proofError2);
            paragraph9.Append(run9);
            paragraph9.Append(proofError3);
            paragraph9.Append(proofError4);

            sdtContentBlock11.Append(paragraph9);

            sdtBlock11.Append(sdtProperties11);
            sdtBlock11.Append(sdtEndCharProperties11);
            sdtBlock11.Append(sdtContentBlock11);

            sdtContentBlock10.Append(sdtBlock11);

            sdtBlock10.Append(sdtProperties10);
            sdtBlock10.Append(sdtEndCharProperties10);
            sdtBlock10.Append(sdtContentBlock10);

            SdtBlock sdtBlock12 = new SdtBlock();

            SdtProperties sdtProperties12 = new SdtProperties();

            RunProperties runProperties21 = new RunProperties();
            RunFonts runFonts19 = new RunFonts(){ Hint = FontTypeHintValues.EastAsia };

            runProperties21.Append(runFonts19);
            SdtAlias sdtAlias10 = new SdtAlias(){ Val = "Test1.4.3" };
            Tag tag10 = new Tag(){ Val = "Test1.4.3" };
            SdtId sdtId12 = new SdtId(){ Val = -294221661 };

            W15.SdtRepeatedSection sdtRepeatedSection3 = new W15.SdtRepeatedSection();
            W15.DoNotAllowInsertDeleteSection doNotAllowInsertDeleteSection1 = new W15.DoNotAllowInsertDeleteSection(){ Val = true };

            sdtRepeatedSection3.Append(doNotAllowInsertDeleteSection1);

            sdtProperties12.Append(runProperties21);
            sdtProperties12.Append(sdtAlias10);
            sdtProperties12.Append(tag10);
            sdtProperties12.Append(sdtId12);
            sdtProperties12.Append(sdtRepeatedSection3);
            SdtEndCharProperties sdtEndCharProperties12 = new SdtEndCharProperties();

            SdtContentBlock sdtContentBlock12 = new SdtContentBlock();

            SdtBlock sdtBlock13 = new SdtBlock();

            SdtProperties sdtProperties13 = new SdtProperties();

            RunProperties runProperties22 = new RunProperties();
            RunFonts runFonts20 = new RunFonts(){ Hint = FontTypeHintValues.EastAsia };

            runProperties22.Append(runFonts20);
            SdtId sdtId13 = new SdtId(){ Val = 2112001363 };
            Lock lock1 = new Lock(){ Val = LockingValues.SdtLocked };

            SdtPlaceholder sdtPlaceholder10 = new SdtPlaceholder();
            DocPartReference docPartReference10 = new DocPartReference(){ Val = "DefaultPlaceholder_1081868562" };

            sdtPlaceholder10.Append(docPartReference10);
            W15.SdtRepeatedSectionItem sdtRepeatedSectionItem3 = new W15.SdtRepeatedSectionItem();

            sdtProperties13.Append(runProperties22);
            sdtProperties13.Append(sdtId13);
            sdtProperties13.Append(lock1);
            sdtProperties13.Append(sdtPlaceholder10);
            sdtProperties13.Append(sdtRepeatedSectionItem3);
            SdtEndCharProperties sdtEndCharProperties13 = new SdtEndCharProperties();

            SdtContentBlock sdtContentBlock13 = new SdtContentBlock();

            Paragraph paragraph10 = new Paragraph(){ RsidParagraphAddition = "000010BA", RsidRunAdditionDefault = "000010BA" };
            ProofError proofError5 = new ProofError(){ Type = ProofingErrorValues.SpellStart };
            ProofError proofError6 = new ProofError(){ Type = ProofingErrorValues.GrammarStart };

            Run run10 = new Run();

            RunProperties runProperties23 = new RunProperties();
            RunFonts runFonts21 = new RunFonts(){ Hint = FontTypeHintValues.EastAsia };

            runProperties23.Append(runFonts21);
            Text text10 = new Text();
            text10.Text = "doNotAllowInsertDeleteSection";

            run10.Append(runProperties23);
            run10.Append(text10);
            ProofError proofError7 = new ProofError(){ Type = ProofingErrorValues.SpellEnd };
            ProofError proofError8 = new ProofError(){ Type = ProofingErrorValues.GrammarEnd };

            paragraph10.Append(proofError5);
            paragraph10.Append(proofError6);
            paragraph10.Append(run10);
            paragraph10.Append(proofError7);
            paragraph10.Append(proofError8);

            sdtContentBlock13.Append(paragraph10);

            sdtBlock13.Append(sdtProperties13);
            sdtBlock13.Append(sdtEndCharProperties13);
            sdtBlock13.Append(sdtContentBlock13);

            sdtContentBlock12.Append(sdtBlock13);

            sdtBlock12.Append(sdtProperties12);
            sdtBlock12.Append(sdtEndCharProperties12);
            sdtBlock12.Append(sdtContentBlock12);

            SdtBlock sdtBlock14 = new SdtBlock();

            SdtProperties sdtProperties14 = new SdtProperties();

            RunProperties runProperties24 = new RunProperties();
            RunFonts runFonts22 = new RunFonts(){ Hint = FontTypeHintValues.EastAsia };

            runProperties24.Append(runFonts22);
            SdtAlias sdtAlias11 = new SdtAlias(){ Val = "Test1.4.4" };
            Tag tag11 = new Tag(){ Val = "Test1.4.4" };
            SdtId sdtId14 = new SdtId(){ Val = -248501389 };

            W15.SdtRepeatedSection sdtRepeatedSection4 = new W15.SdtRepeatedSection();
            W15.SectionTitle sectionTitle1 = new W15.SectionTitle(){ Val = "Section title string" };

            sdtRepeatedSection4.Append(sectionTitle1);

            sdtProperties14.Append(runProperties24);
            sdtProperties14.Append(sdtAlias11);
            sdtProperties14.Append(tag11);
            sdtProperties14.Append(sdtId14);
            sdtProperties14.Append(sdtRepeatedSection4);
            SdtEndCharProperties sdtEndCharProperties14 = new SdtEndCharProperties();

            SdtContentBlock sdtContentBlock14 = new SdtContentBlock();

            SdtBlock sdtBlock15 = new SdtBlock();

            SdtProperties sdtProperties15 = new SdtProperties();

            RunProperties runProperties25 = new RunProperties();
            RunFonts runFonts23 = new RunFonts(){ Hint = FontTypeHintValues.EastAsia };

            runProperties25.Append(runFonts23);
            SdtId sdtId15 = new SdtId(){ Val = 1971018620 };

            SdtPlaceholder sdtPlaceholder11 = new SdtPlaceholder();
            DocPartReference docPartReference11 = new DocPartReference(){ Val = "DefaultPlaceholder_1081868562" };

            sdtPlaceholder11.Append(docPartReference11);
            W15.SdtRepeatedSectionItem sdtRepeatedSectionItem4 = new W15.SdtRepeatedSectionItem();

            sdtProperties15.Append(runProperties25);
            sdtProperties15.Append(sdtId15);
            sdtProperties15.Append(sdtPlaceholder11);
            sdtProperties15.Append(sdtRepeatedSectionItem4);
            SdtEndCharProperties sdtEndCharProperties15 = new SdtEndCharProperties();

            SdtContentBlock sdtContentBlock15 = new SdtContentBlock();

            Paragraph paragraph11 = new Paragraph(){ RsidParagraphAddition = "000010BA", RsidRunAdditionDefault = "000010BA" };
            ProofError proofError9 = new ProofError(){ Type = ProofingErrorValues.SpellStart };
            ProofError proofError10 = new ProofError(){ Type = ProofingErrorValues.GrammarStart };

            Run run11 = new Run();

            RunProperties runProperties26 = new RunProperties();
            RunFonts runFonts24 = new RunFonts(){ Hint = FontTypeHintValues.EastAsia };

            runProperties26.Append(runFonts24);
            Text text11 = new Text();
            text11.Text = "sectionTitle";

            run11.Append(runProperties26);
            run11.Append(text11);
            ProofError proofError11 = new ProofError(){ Type = ProofingErrorValues.SpellEnd };
            ProofError proofError12 = new ProofError(){ Type = ProofingErrorValues.GrammarEnd };

            paragraph11.Append(proofError9);
            paragraph11.Append(proofError10);
            paragraph11.Append(run11);
            paragraph11.Append(proofError11);
            paragraph11.Append(proofError12);

            sdtContentBlock15.Append(paragraph11);

            sdtBlock15.Append(sdtProperties15);
            sdtBlock15.Append(sdtEndCharProperties15);
            sdtBlock15.Append(sdtContentBlock15);

            sdtContentBlock14.Append(sdtBlock15);

            sdtBlock14.Append(sdtProperties14);
            sdtBlock14.Append(sdtEndCharProperties14);
            sdtBlock14.Append(sdtContentBlock14);

            Table table1 = new Table();

            TableProperties tableProperties1 = new TableProperties();
            TableWidth tableWidth1 = new TableWidth(){ Width = "0", Type = TableWidthUnitValues.Auto };

            TableBorders tableBorders1 = new TableBorders();
            TopBorder topBorder1 = new TopBorder(){ Val = BorderValues.Double, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            LeftBorder leftBorder1 = new LeftBorder(){ Val = BorderValues.Double, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder1 = new BottomBorder(){ Val = BorderValues.Double, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            RightBorder rightBorder1 = new RightBorder(){ Val = BorderValues.Double, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            InsideHorizontalBorder insideHorizontalBorder1 = new InsideHorizontalBorder(){ Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            InsideVerticalBorder insideVerticalBorder1 = new InsideVerticalBorder(){ Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };

            tableBorders1.Append(topBorder1);
            tableBorders1.Append(leftBorder1);
            tableBorders1.Append(bottomBorder1);
            tableBorders1.Append(rightBorder1);
            tableBorders1.Append(insideHorizontalBorder1);
            tableBorders1.Append(insideVerticalBorder1);
            TableLayout tableLayout1 = new TableLayout(){ Type = TableLayoutValues.Fixed };
            TableLook tableLook1 = new TableLook(){ Val = "0000" };

            tableProperties1.Append(tableWidth1);
            tableProperties1.Append(tableBorders1);
            tableProperties1.Append(tableLayout1);
            tableProperties1.Append(tableLook1);

            TableGrid tableGrid1 = new TableGrid();
            GridColumn gridColumn1 = new GridColumn(){ Width = "4788" };
            GridColumn gridColumn2 = new GridColumn(){ Width = "4788" };

            tableGrid1.Append(gridColumn1);
            tableGrid1.Append(gridColumn2);

            SdtRow sdtRow1 = new SdtRow();

            SdtProperties sdtProperties16 = new SdtProperties();
            SdtId sdtId16 = new SdtId(){ Val = 1391384564 };

            SdtPlaceholder sdtPlaceholder12 = new SdtPlaceholder();
            DocPartReference docPartReference12 = new DocPartReference(){ Val = "B207B2DF6D0E4E13956E6616811860CA" };

            sdtPlaceholder12.Append(docPartReference12);
            W15.DataBinding dataBinding1 = new W15.DataBinding(){ XPath = "/books[1]/book", StoreItemId = "{F6DB09CA-2A79-464E-B71A-D37E08A01059}" };
            W15.Appearance appearance3 = new W15.Appearance(){ Val = W15.SdtAppearance.Tags };
            W15.SdtRepeatedSection sdtRepeatedSection5 = new W15.SdtRepeatedSection();

            sdtProperties16.Append(sdtId16);
            sdtProperties16.Append(sdtPlaceholder12);
            sdtProperties16.Append(dataBinding1);
            sdtProperties16.Append(appearance3);
            sdtProperties16.Append(sdtRepeatedSection5);
            SdtEndCharProperties sdtEndCharProperties16 = new SdtEndCharProperties();

            SdtContentRow sdtContentRow1 = new SdtContentRow();

            SdtRow sdtRow2 = new SdtRow();

            SdtProperties sdtProperties17 = new SdtProperties();
            SdtId sdtId17 = new SdtId(){ Val = 1787311118 };
            W15.Appearance appearance4 = new W15.Appearance(){ Val = W15.SdtAppearance.Tags };
            W15.SdtRepeatedSectionItem sdtRepeatedSectionItem5 = new W15.SdtRepeatedSectionItem();

            sdtProperties17.Append(sdtId17);
            sdtProperties17.Append(appearance4);
            sdtProperties17.Append(sdtRepeatedSectionItem5);
            SdtEndCharProperties sdtEndCharProperties17 = new SdtEndCharProperties();

            SdtContentRow sdtContentRow2 = new SdtContentRow();

            TableRow tableRow1 = new TableRow(){ RsidTableRowAddition = "00E930A2", RsidTableRowProperties = "00242789" };

            SdtCell sdtCell1 = new SdtCell();

            SdtProperties sdtProperties18 = new SdtProperties();
            SdtAlias sdtAlias12 = new SdtAlias(){ Val = "Test1.5.1_1" };
            Tag tag12 = new Tag(){ Val = "Test1.5.1_1" };
            SdtId sdtId18 = new SdtId(){ Val = -1276551752 };

            SdtPlaceholder sdtPlaceholder13 = new SdtPlaceholder();
            DocPartReference docPartReference13 = new DocPartReference(){ Val = "B207B2DF6D0E4E13956E6616811860CA" };

            sdtPlaceholder13.Append(docPartReference13);
            DataBinding dataBinding2 = new DataBinding(){ XPath = "/books[1]/book[1]/title[1]", StoreItemId = "{F6DB09CA-2A79-464E-B71A-D37E08A01059}" };
            SdtContentText sdtContentText8 = new SdtContentText();

            sdtProperties18.Append(sdtAlias12);
            sdtProperties18.Append(tag12);
            sdtProperties18.Append(sdtId18);
            sdtProperties18.Append(sdtPlaceholder13);
            sdtProperties18.Append(dataBinding2);
            sdtProperties18.Append(sdtContentText8);
            SdtEndCharProperties sdtEndCharProperties18 = new SdtEndCharProperties();

            SdtContentCell sdtContentCell1 = new SdtContentCell();

            TableCell tableCell1 = new TableCell();

            TableCellProperties tableCellProperties1 = new TableCellProperties();
            TableCellWidth tableCellWidth1 = new TableCellWidth(){ Width = "4788", Type = TableWidthUnitValues.Dxa };
            Shading shading1 = new Shading(){ Val = ShadingPatternValues.Clear, Color = "auto", Fill = "auto" };

            tableCellProperties1.Append(tableCellWidth1);
            tableCellProperties1.Append(shading1);

            Paragraph paragraph12 = new Paragraph(){ RsidParagraphAddition = "00E930A2", RsidParagraphProperties = "00E86739", RsidRunAdditionDefault = "00E930A2" };

            Run run12 = new Run();

            RunProperties runProperties27 = new RunProperties();
            RunFonts runFonts25 = new RunFonts(){ Hint = FontTypeHintValues.EastAsia };

            runProperties27.Append(runFonts25);
            Text text12 = new Text();
            text12.Text = "Repeating Section,Row1";

            run12.Append(runProperties27);
            run12.Append(text12);

            Run run13 = new Run(){ RsidRunAddition = "00E86739" };

            RunProperties runProperties28 = new RunProperties();
            RunFonts runFonts26 = new RunFonts(){ Hint = FontTypeHintValues.EastAsia };

            runProperties28.Append(runFonts26);
            Text text13 = new Text();
            text13.Text = ",Cell1";

            run13.Append(runProperties28);
            run13.Append(text13);

            paragraph12.Append(run12);
            paragraph12.Append(run13);

            tableCell1.Append(tableCellProperties1);
            tableCell1.Append(paragraph12);

            sdtContentCell1.Append(tableCell1);

            sdtCell1.Append(sdtProperties18);
            sdtCell1.Append(sdtEndCharProperties18);
            sdtCell1.Append(sdtContentCell1);

            SdtCell sdtCell2 = new SdtCell();

            SdtProperties sdtProperties19 = new SdtProperties();

            RunProperties runProperties29 = new RunProperties();
            Kern kern1 = new Kern(){ Val = (UInt32Value)0U };

            runProperties29.Append(kern1);
            SdtAlias sdtAlias13 = new SdtAlias(){ Val = "Test1.5.1_2" };
            Tag tag13 = new Tag(){ Val = "Test1.5.1_2" };
            SdtId sdtId19 = new SdtId(){ Val = -1317331761 };

            SdtPlaceholder sdtPlaceholder14 = new SdtPlaceholder();
            DocPartReference docPartReference14 = new DocPartReference(){ Val = "B207B2DF6D0E4E13956E6616811860CA" };

            sdtPlaceholder14.Append(docPartReference14);
            DataBinding dataBinding3 = new DataBinding(){ XPath = "/books[1]/book[1]/author[1]", StoreItemId = "{F6DB09CA-2A79-464E-B71A-D37E08A01059}" };
            SdtContentText sdtContentText9 = new SdtContentText();

            sdtProperties19.Append(runProperties29);
            sdtProperties19.Append(sdtAlias13);
            sdtProperties19.Append(tag13);
            sdtProperties19.Append(sdtId19);
            sdtProperties19.Append(sdtPlaceholder14);
            sdtProperties19.Append(dataBinding3);
            sdtProperties19.Append(sdtContentText9);
            SdtEndCharProperties sdtEndCharProperties19 = new SdtEndCharProperties();

            SdtContentCell sdtContentCell2 = new SdtContentCell();

            TableCell tableCell2 = new TableCell();

            TableCellProperties tableCellProperties2 = new TableCellProperties();
            TableCellWidth tableCellWidth2 = new TableCellWidth(){ Width = "4788", Type = TableWidthUnitValues.Dxa };
            Shading shading2 = new Shading(){ Val = ShadingPatternValues.Clear, Color = "auto", Fill = "auto" };

            tableCellProperties2.Append(tableCellWidth2);
            tableCellProperties2.Append(shading2);

            Paragraph paragraph13 = new Paragraph(){ RsidParagraphAddition = "00E930A2", RsidParagraphProperties = "00E86739", RsidRunAdditionDefault = "00E930A2" };

            Run run14 = new Run();

            RunProperties runProperties30 = new RunProperties();
            Kern kern2 = new Kern(){ Val = (UInt32Value)0U };

            runProperties30.Append(kern2);
            Text text14 = new Text();
            text14.Text = "Repeating Section";

            run14.Append(runProperties30);
            run14.Append(text14);

            Run run15 = new Run(){ RsidRunAddition = "00E86739" };

            RunProperties runProperties31 = new RunProperties();
            RunFonts runFonts27 = new RunFonts(){ Hint = FontTypeHintValues.EastAsia };
            Kern kern3 = new Kern(){ Val = (UInt32Value)0U };

            runProperties31.Append(runFonts27);
            runProperties31.Append(kern3);
            Text text15 = new Text();
            text15.Text = ",";

            run15.Append(runProperties31);
            run15.Append(text15);

            Run run16 = new Run();

            RunProperties runProperties32 = new RunProperties();
            Kern kern4 = new Kern(){ Val = (UInt32Value)0U };

            runProperties32.Append(kern4);
            Text text16 = new Text();
            text16.Text = "Row1";

            run16.Append(runProperties32);
            run16.Append(text16);

            Run run17 = new Run(){ RsidRunAddition = "00E86739" };

            RunProperties runProperties33 = new RunProperties();
            RunFonts runFonts28 = new RunFonts(){ Hint = FontTypeHintValues.EastAsia };
            Kern kern5 = new Kern(){ Val = (UInt32Value)0U };

            runProperties33.Append(runFonts28);
            runProperties33.Append(kern5);
            Text text17 = new Text();
            text17.Text = ",Cell2";

            run17.Append(runProperties33);
            run17.Append(text17);

            paragraph13.Append(run14);
            paragraph13.Append(run15);
            paragraph13.Append(run16);
            paragraph13.Append(run17);

            tableCell2.Append(tableCellProperties2);
            tableCell2.Append(paragraph13);

            sdtContentCell2.Append(tableCell2);

            sdtCell2.Append(sdtProperties19);
            sdtCell2.Append(sdtEndCharProperties19);
            sdtCell2.Append(sdtContentCell2);

            tableRow1.Append(sdtCell1);
            tableRow1.Append(sdtCell2);

            sdtContentRow2.Append(tableRow1);

            sdtRow2.Append(sdtProperties17);
            sdtRow2.Append(sdtEndCharProperties17);
            sdtRow2.Append(sdtContentRow2);

            SdtRow sdtRow3 = new SdtRow();

            SdtProperties sdtProperties20 = new SdtProperties();
            SdtId sdtId20 = new SdtId(){ Val = 689805002 };
            W15.Appearance appearance5 = new W15.Appearance(){ Val = W15.SdtAppearance.Tags };
            W15.SdtRepeatedSectionItem sdtRepeatedSectionItem6 = new W15.SdtRepeatedSectionItem();

            sdtProperties20.Append(sdtId20);
            sdtProperties20.Append(appearance5);
            sdtProperties20.Append(sdtRepeatedSectionItem6);
            SdtEndCharProperties sdtEndCharProperties20 = new SdtEndCharProperties();

            SdtContentRow sdtContentRow3 = new SdtContentRow();

            TableRow tableRow2 = new TableRow(){ RsidTableRowAddition = "00E930A2", RsidTableRowProperties = "00242789" };

            SdtCell sdtCell3 = new SdtCell();

            SdtProperties sdtProperties21 = new SdtProperties();
            SdtAlias sdtAlias14 = new SdtAlias(){ Val = "Test1.5.1_3" };
            Tag tag14 = new Tag(){ Val = "Test1.5.1_3" };
            SdtId sdtId21 = new SdtId(){ Val = 880594776 };

            SdtPlaceholder sdtPlaceholder15 = new SdtPlaceholder();
            DocPartReference docPartReference15 = new DocPartReference(){ Val = "4B632797D8B1461898B8F461443A20E0" };

            sdtPlaceholder15.Append(docPartReference15);
            DataBinding dataBinding4 = new DataBinding(){ XPath = "/books[1]/book[4]/title[1]", StoreItemId = "{F6DB09CA-2A79-464E-B71A-D37E08A01059}" };
            SdtContentText sdtContentText10 = new SdtContentText();

            sdtProperties21.Append(sdtAlias14);
            sdtProperties21.Append(tag14);
            sdtProperties21.Append(sdtId21);
            sdtProperties21.Append(sdtPlaceholder15);
            sdtProperties21.Append(dataBinding4);
            sdtProperties21.Append(sdtContentText10);

            SdtEndCharProperties sdtEndCharProperties21 = new SdtEndCharProperties();

            RunProperties runProperties34 = new RunProperties();
            Kern kern6 = new Kern(){ Val = (UInt32Value)0U };

            runProperties34.Append(kern6);

            sdtEndCharProperties21.Append(runProperties34);

            SdtContentCell sdtContentCell3 = new SdtContentCell();

            TableCell tableCell3 = new TableCell();

            TableCellProperties tableCellProperties3 = new TableCellProperties();
            TableCellWidth tableCellWidth3 = new TableCellWidth(){ Width = "4788", Type = TableWidthUnitValues.Dxa };
            Shading shading3 = new Shading(){ Val = ShadingPatternValues.Clear, Color = "auto", Fill = "auto" };

            tableCellProperties3.Append(tableCellWidth3);
            tableCellProperties3.Append(shading3);

            Paragraph paragraph14 = new Paragraph(){ RsidParagraphAddition = "00E930A2", RsidParagraphProperties = "00E86739", RsidRunAdditionDefault = "00E930A2" };

            Run run18 = new Run();

            RunProperties runProperties35 = new RunProperties();
            Kern kern7 = new Kern(){ Val = (UInt32Value)0U };

            runProperties35.Append(kern7);
            Text text18 = new Text();
            text18.Text = "Repeating Section";

            run18.Append(runProperties35);
            run18.Append(text18);

            Run run19 = new Run(){ RsidRunAddition = "00E86739" };

            RunProperties runProperties36 = new RunProperties();
            RunFonts runFonts29 = new RunFonts(){ Hint = FontTypeHintValues.EastAsia };
            Kern kern8 = new Kern(){ Val = (UInt32Value)0U };

            runProperties36.Append(runFonts29);
            runProperties36.Append(kern8);
            Text text19 = new Text();
            text19.Text = ",";

            run19.Append(runProperties36);
            run19.Append(text19);

            Run run20 = new Run();

            RunProperties runProperties37 = new RunProperties();
            Kern kern9 = new Kern(){ Val = (UInt32Value)0U };

            runProperties37.Append(kern9);
            Text text20 = new Text();
            text20.Text = "Row";

            run20.Append(runProperties37);
            run20.Append(text20);

            Run run21 = new Run();

            RunProperties runProperties38 = new RunProperties();
            RunFonts runFonts30 = new RunFonts(){ Hint = FontTypeHintValues.EastAsia };
            Kern kern10 = new Kern(){ Val = (UInt32Value)0U };

            runProperties38.Append(runFonts30);
            runProperties38.Append(kern10);
            Text text21 = new Text();
            text21.Text = "2";

            run21.Append(runProperties38);
            run21.Append(text21);

            Run run22 = new Run(){ RsidRunAddition = "00E86739" };

            RunProperties runProperties39 = new RunProperties();
            RunFonts runFonts31 = new RunFonts(){ Hint = FontTypeHintValues.EastAsia };
            Kern kern11 = new Kern(){ Val = (UInt32Value)0U };

            runProperties39.Append(runFonts31);
            runProperties39.Append(kern11);
            Text text22 = new Text();
            text22.Text = ",Cell1";

            run22.Append(runProperties39);
            run22.Append(text22);

            paragraph14.Append(run18);
            paragraph14.Append(run19);
            paragraph14.Append(run20);
            paragraph14.Append(run21);
            paragraph14.Append(run22);

            tableCell3.Append(tableCellProperties3);
            tableCell3.Append(paragraph14);

            sdtContentCell3.Append(tableCell3);

            sdtCell3.Append(sdtProperties21);
            sdtCell3.Append(sdtEndCharProperties21);
            sdtCell3.Append(sdtContentCell3);

            SdtCell sdtCell4 = new SdtCell();

            SdtProperties sdtProperties22 = new SdtProperties();

            RunProperties runProperties40 = new RunProperties();
            Kern kern12 = new Kern(){ Val = (UInt32Value)0U };

            runProperties40.Append(kern12);
            SdtAlias sdtAlias15 = new SdtAlias(){ Val = "Test1.5.1_4" };
            Tag tag15 = new Tag(){ Val = "Test1.5.1_4" };
            SdtId sdtId22 = new SdtId(){ Val = -1022928317 };

            SdtPlaceholder sdtPlaceholder16 = new SdtPlaceholder();
            DocPartReference docPartReference16 = new DocPartReference(){ Val = "4B632797D8B1461898B8F461443A20E0" };

            sdtPlaceholder16.Append(docPartReference16);
            DataBinding dataBinding5 = new DataBinding(){ XPath = "/books[1]/book[4]/author[1]", StoreItemId = "{F6DB09CA-2A79-464E-B71A-D37E08A01059}" };
            SdtContentText sdtContentText11 = new SdtContentText();

            sdtProperties22.Append(runProperties40);
            sdtProperties22.Append(sdtAlias15);
            sdtProperties22.Append(tag15);
            sdtProperties22.Append(sdtId22);
            sdtProperties22.Append(sdtPlaceholder16);
            sdtProperties22.Append(dataBinding5);
            sdtProperties22.Append(sdtContentText11);
            SdtEndCharProperties sdtEndCharProperties22 = new SdtEndCharProperties();

            SdtContentCell sdtContentCell4 = new SdtContentCell();

            TableCell tableCell4 = new TableCell();

            TableCellProperties tableCellProperties4 = new TableCellProperties();
            TableCellWidth tableCellWidth4 = new TableCellWidth(){ Width = "4788", Type = TableWidthUnitValues.Dxa };
            Shading shading4 = new Shading(){ Val = ShadingPatternValues.Clear, Color = "auto", Fill = "auto" };

            tableCellProperties4.Append(tableCellWidth4);
            tableCellProperties4.Append(shading4);

            Paragraph paragraph15 = new Paragraph(){ RsidParagraphAddition = "00E930A2", RsidParagraphProperties = "00E86739", RsidRunAdditionDefault = "009651D6" };

            Run run23 = new Run();

            RunProperties runProperties41 = new RunProperties();
            Kern kern13 = new Kern(){ Val = (UInt32Value)0U };

            runProperties41.Append(kern13);
            Text text23 = new Text();
            text23.Text = "Repeating Section";

            run23.Append(runProperties41);
            run23.Append(text23);

            Run run24 = new Run(){ RsidRunAddition = "00E86739" };

            RunProperties runProperties42 = new RunProperties();
            RunFonts runFonts32 = new RunFonts(){ Hint = FontTypeHintValues.EastAsia };
            Kern kern14 = new Kern(){ Val = (UInt32Value)0U };

            runProperties42.Append(runFonts32);
            runProperties42.Append(kern14);
            Text text24 = new Text();
            text24.Text = ",Row2,Cell2";

            run24.Append(runProperties42);
            run24.Append(text24);

            paragraph15.Append(run23);
            paragraph15.Append(run24);

            tableCell4.Append(tableCellProperties4);
            tableCell4.Append(paragraph15);

            sdtContentCell4.Append(tableCell4);

            sdtCell4.Append(sdtProperties22);
            sdtCell4.Append(sdtEndCharProperties22);
            sdtCell4.Append(sdtContentCell4);

            tableRow2.Append(sdtCell3);
            tableRow2.Append(sdtCell4);

            sdtContentRow3.Append(tableRow2);

            sdtRow3.Append(sdtProperties20);
            sdtRow3.Append(sdtEndCharProperties20);
            sdtRow3.Append(sdtContentRow3);

            sdtContentRow1.Append(sdtRow2);
            sdtContentRow1.Append(sdtRow3);

            sdtRow1.Append(sdtProperties16);
            sdtRow1.Append(sdtEndCharProperties16);
            sdtRow1.Append(sdtContentRow1);

            TableRow tableRow3 = new TableRow(){ RsidTableRowAddition = "00E930A2", RsidTableRowProperties = "00242789" };

            TableCell tableCell5 = new TableCell();

            TableCellProperties tableCellProperties5 = new TableCellProperties();
            TableCellWidth tableCellWidth5 = new TableCellWidth(){ Width = "4788", Type = TableWidthUnitValues.Dxa };
            Shading shading5 = new Shading(){ Val = ShadingPatternValues.Clear, Color = "auto", Fill = "auto" };

            tableCellProperties5.Append(tableCellWidth5);
            tableCellProperties5.Append(shading5);
            Paragraph paragraph16 = new Paragraph(){ RsidParagraphAddition = "00E930A2", RsidParagraphProperties = "00242789", RsidRunAdditionDefault = "00E930A2" };

            tableCell5.Append(tableCellProperties5);
            tableCell5.Append(paragraph16);

            TableCell tableCell6 = new TableCell();

            TableCellProperties tableCellProperties6 = new TableCellProperties();
            TableCellWidth tableCellWidth6 = new TableCellWidth(){ Width = "4788", Type = TableWidthUnitValues.Dxa };
            Shading shading6 = new Shading(){ Val = ShadingPatternValues.Clear, Color = "auto", Fill = "auto" };

            tableCellProperties6.Append(tableCellWidth6);
            tableCellProperties6.Append(shading6);
            Paragraph paragraph17 = new Paragraph(){ RsidParagraphAddition = "00E930A2", RsidParagraphProperties = "00242789", RsidRunAdditionDefault = "00E930A2" };

            tableCell6.Append(tableCellProperties6);
            tableCell6.Append(paragraph17);

            tableRow3.Append(tableCell5);
            tableRow3.Append(tableCell6);

            table1.Append(tableProperties1);
            table1.Append(tableGrid1);
            table1.Append(sdtRow1);
            table1.Append(tableRow3);
            Paragraph paragraph18 = new Paragraph(){ RsidParagraphAddition = "00E930A2", RsidRunAdditionDefault = "00E930A2" };

            SectionProperties sectionProperties1 = new SectionProperties(){ RsidR = "00E930A2" };
            PageSize pageSize1 = new PageSize(){ Width = (UInt32Value)11906U, Height = (UInt32Value)16838U };
            PageMargin pageMargin1 = new PageMargin(){ Top = 1985, Right = (UInt32Value)1701U, Bottom = 1701, Left = (UInt32Value)1701U, Header = (UInt32Value)851U, Footer = (UInt32Value)992U, Gutter = (UInt32Value)0U };
            Columns columns1 = new Columns(){ Space = "425" };
            DocGrid docGrid1 = new DocGrid(){ Type = DocGridValues.Lines, LinePitch = 360 };

            sectionProperties1.Append(pageSize1);
            sectionProperties1.Append(pageMargin1);
            sectionProperties1.Append(columns1);
            sectionProperties1.Append(docGrid1);

            body1.Append(sdtBlock1);
            body1.Append(sdtBlock2);
            body1.Append(sdtBlock3);
            body1.Append(sdtBlock4);
            body1.Append(sdtBlock5);
            body1.Append(sdtBlock6);
            body1.Append(sdtBlock7);
            body1.Append(sdtBlock8);
            body1.Append(sdtBlock10);
            body1.Append(sdtBlock12);
            body1.Append(sdtBlock14);
            body1.Append(table1);
            body1.Append(paragraph18);
            body1.Append(sectionProperties1);

            document1.Append(body1);

            mainDocumentPart1.Document = document1;
        }

        // Generates content of glossaryDocumentPart1.
        private void GenerateGlossaryDocumentPart1Content(GlossaryDocumentPart glossaryDocumentPart1)
        {
            GlossaryDocument glossaryDocument1 = new GlossaryDocument(){ MCAttributes = new MarkupCompatibilityAttributes(){ Ignorable = "w14 w15 wp14" }  };
            glossaryDocument1.AddNamespaceDeclaration("wpc", "http://schemas.microsoft.com/office/word/2010/wordprocessingCanvas");
            glossaryDocument1.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            glossaryDocument1.AddNamespaceDeclaration("o", "urn:schemas-microsoft-com:office:office");
            glossaryDocument1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            glossaryDocument1.AddNamespaceDeclaration("m", "http://schemas.openxmlformats.org/officeDocument/2006/math");
            glossaryDocument1.AddNamespaceDeclaration("v", "urn:schemas-microsoft-com:vml");
            glossaryDocument1.AddNamespaceDeclaration("wp14", "http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing");
            glossaryDocument1.AddNamespaceDeclaration("wp", "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing");
            glossaryDocument1.AddNamespaceDeclaration("w10", "urn:schemas-microsoft-com:office:word");
            glossaryDocument1.AddNamespaceDeclaration("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main");
            glossaryDocument1.AddNamespaceDeclaration("w14", "http://schemas.microsoft.com/office/word/2010/wordml");
            glossaryDocument1.AddNamespaceDeclaration("w15", "http://schemas.microsoft.com/office/word/2010/11/wordml");
            glossaryDocument1.AddNamespaceDeclaration("wpg", "http://schemas.microsoft.com/office/word/2010/wordprocessingGroup");
            glossaryDocument1.AddNamespaceDeclaration("wpi", "http://schemas.microsoft.com/office/word/2010/wordprocessingInk");
            glossaryDocument1.AddNamespaceDeclaration("wne", "http://schemas.microsoft.com/office/word/2006/wordml");
            glossaryDocument1.AddNamespaceDeclaration("wps", "http://schemas.microsoft.com/office/word/2010/wordprocessingShape");

            DocParts docParts1 = new DocParts();

            DocPart docPart1 = new DocPart();

            DocPartProperties docPartProperties1 = new DocPartProperties();
            DocPartName docPartName1 = new DocPartName(){ Val = "DefaultPlaceholder_1081868558" };

            Category category1 = new Category();
            Name name1 = new Name(){ Val = "General" };
            Gallery gallery1 = new Gallery(){ Val = DocPartGalleryValues.Placeholder };

            category1.Append(name1);
            category1.Append(gallery1);

            DocPartTypes docPartTypes1 = new DocPartTypes();
            DocPartType docPartType1 = new DocPartType(){ Val = DocPartValues.SdtPlaceholder };

            docPartTypes1.Append(docPartType1);

            Behaviors behaviors1 = new Behaviors();
            Behavior behavior1 = new Behavior(){ Val = DocPartBehaviorValues.Content };

            behaviors1.Append(behavior1);
            DocPartId docPartId1 = new DocPartId(){ Val = "{F039DA22-FC7F-4FBD-92C2-651CCBF1B274}" };

            docPartProperties1.Append(docPartName1);
            docPartProperties1.Append(category1);
            docPartProperties1.Append(docPartTypes1);
            docPartProperties1.Append(behaviors1);
            docPartProperties1.Append(docPartId1);

            DocPartBody docPartBody1 = new DocPartBody();

            Paragraph paragraph19 = new Paragraph(){ RsidParagraphAddition = "00930812", RsidRunAdditionDefault = "00B75576" };

            Run run25 = new Run(){ RsidRunProperties = "003E0DED" };

            RunProperties runProperties43 = new RunProperties();
            RunStyle runStyle3 = new RunStyle(){ Val = "PlaceholderText" };

            runProperties43.Append(runStyle3);
            Text text25 = new Text();
            text25.Text = "Click here to enter text.";

            run25.Append(runProperties43);
            run25.Append(text25);

            paragraph19.Append(run25);

            docPartBody1.Append(paragraph19);

            docPart1.Append(docPartProperties1);
            docPart1.Append(docPartBody1);

            DocPart docPart2 = new DocPart();

            DocPartProperties docPartProperties2 = new DocPartProperties();
            DocPartName docPartName2 = new DocPartName(){ Val = "DefaultPlaceholder_1081868562" };

            Category category2 = new Category();
            Name name2 = new Name(){ Val = "General" };
            Gallery gallery2 = new Gallery(){ Val = DocPartGalleryValues.Placeholder };

            category2.Append(name2);
            category2.Append(gallery2);

            DocPartTypes docPartTypes2 = new DocPartTypes();
            DocPartType docPartType2 = new DocPartType(){ Val = DocPartValues.SdtPlaceholder };

            docPartTypes2.Append(docPartType2);

            Behaviors behaviors2 = new Behaviors();
            Behavior behavior2 = new Behavior(){ Val = DocPartBehaviorValues.Content };

            behaviors2.Append(behavior2);
            DocPartId docPartId2 = new DocPartId(){ Val = "{00F3F2EC-0290-443B-9815-66648EE1ADF9}" };

            docPartProperties2.Append(docPartName2);
            docPartProperties2.Append(category2);
            docPartProperties2.Append(docPartTypes2);
            docPartProperties2.Append(behaviors2);
            docPartProperties2.Append(docPartId2);

            DocPartBody docPartBody2 = new DocPartBody();

            Paragraph paragraph20 = new Paragraph(){ RsidParagraphAddition = "00930812", RsidRunAdditionDefault = "00B75576" };

            Run run26 = new Run(){ RsidRunProperties = "003E0DED" };

            RunProperties runProperties44 = new RunProperties();
            RunStyle runStyle4 = new RunStyle(){ Val = "PlaceholderText" };

            runProperties44.Append(runStyle4);
            Text text26 = new Text();
            text26.Text = "Enter any content that you want to repeat, including other content controls. You can also insert this control around table rows in order to repeat parts of a table.";

            run26.Append(runProperties44);
            run26.Append(text26);

            paragraph20.Append(run26);

            docPartBody2.Append(paragraph20);

            docPart2.Append(docPartProperties2);
            docPart2.Append(docPartBody2);

            DocPart docPart3 = new DocPart();

            DocPartProperties docPartProperties3 = new DocPartProperties();
            DocPartName docPartName3 = new DocPartName(){ Val = "B207B2DF6D0E4E13956E6616811860CA" };

            Category category3 = new Category();
            Name name3 = new Name(){ Val = "General" };
            Gallery gallery3 = new Gallery(){ Val = DocPartGalleryValues.Placeholder };

            category3.Append(name3);
            category3.Append(gallery3);

            DocPartTypes docPartTypes3 = new DocPartTypes();
            DocPartType docPartType3 = new DocPartType(){ Val = DocPartValues.SdtPlaceholder };

            docPartTypes3.Append(docPartType3);

            Behaviors behaviors3 = new Behaviors();
            Behavior behavior3 = new Behavior(){ Val = DocPartBehaviorValues.Content };

            behaviors3.Append(behavior3);
            DocPartId docPartId3 = new DocPartId(){ Val = "{1631777A-52D9-4CE4-A42F-C87B6FA35F21}" };

            docPartProperties3.Append(docPartName3);
            docPartProperties3.Append(category3);
            docPartProperties3.Append(docPartTypes3);
            docPartProperties3.Append(behaviors3);
            docPartProperties3.Append(docPartId3);

            DocPartBody docPartBody3 = new DocPartBody();

            Paragraph paragraph21 = new Paragraph(){ RsidParagraphAddition = "00EF189C", RsidParagraphProperties = "00930812", RsidRunAdditionDefault = "00930812" };

            ParagraphProperties paragraphProperties1 = new ParagraphProperties();
            ParagraphStyleId paragraphStyleId1 = new ParagraphStyleId(){ Val = "B207B2DF6D0E4E13956E6616811860CA" };

            paragraphProperties1.Append(paragraphStyleId1);

            Run run27 = new Run(){ RsidRunProperties = "00D27A45" };

            RunProperties runProperties45 = new RunProperties();
            RunStyle runStyle5 = new RunStyle(){ Val = "PlaceholderText" };

            runProperties45.Append(runStyle5);
            Text text27 = new Text();
            text27.Text = "Click here to enter text.";

            run27.Append(runProperties45);
            run27.Append(text27);

            paragraph21.Append(paragraphProperties1);
            paragraph21.Append(run27);

            docPartBody3.Append(paragraph21);

            docPart3.Append(docPartProperties3);
            docPart3.Append(docPartBody3);

            DocPart docPart4 = new DocPart();

            DocPartProperties docPartProperties4 = new DocPartProperties();
            DocPartName docPartName4 = new DocPartName(){ Val = "4B632797D8B1461898B8F461443A20E0" };

            Category category4 = new Category();
            Name name4 = new Name(){ Val = "General" };
            Gallery gallery4 = new Gallery(){ Val = DocPartGalleryValues.Placeholder };

            category4.Append(name4);
            category4.Append(gallery4);

            DocPartTypes docPartTypes4 = new DocPartTypes();
            DocPartType docPartType4 = new DocPartType(){ Val = DocPartValues.SdtPlaceholder };

            docPartTypes4.Append(docPartType4);

            Behaviors behaviors4 = new Behaviors();
            Behavior behavior4 = new Behavior(){ Val = DocPartBehaviorValues.Content };

            behaviors4.Append(behavior4);
            DocPartId docPartId4 = new DocPartId(){ Val = "{4829C634-4047-4182-9E1A-7F28677ACBC2}" };

            docPartProperties4.Append(docPartName4);
            docPartProperties4.Append(category4);
            docPartProperties4.Append(docPartTypes4);
            docPartProperties4.Append(behaviors4);
            docPartProperties4.Append(docPartId4);

            DocPartBody docPartBody4 = new DocPartBody();

            Paragraph paragraph22 = new Paragraph(){ RsidParagraphAddition = "00EF189C", RsidParagraphProperties = "00930812", RsidRunAdditionDefault = "00930812" };

            ParagraphProperties paragraphProperties2 = new ParagraphProperties();
            ParagraphStyleId paragraphStyleId2 = new ParagraphStyleId(){ Val = "4B632797D8B1461898B8F461443A20E0" };

            paragraphProperties2.Append(paragraphStyleId2);

            Run run28 = new Run(){ RsidRunProperties = "00D27A45" };

            RunProperties runProperties46 = new RunProperties();
            RunStyle runStyle6 = new RunStyle(){ Val = "PlaceholderText" };

            runProperties46.Append(runStyle6);
            Text text28 = new Text();
            text28.Text = "Click here to enter text.";

            run28.Append(runProperties46);
            run28.Append(text28);

            paragraph22.Append(paragraphProperties2);
            paragraph22.Append(run28);

            docPartBody4.Append(paragraph22);

            docPart4.Append(docPartProperties4);
            docPart4.Append(docPartBody4);

            docParts1.Append(docPart1);
            docParts1.Append(docPart2);
            docParts1.Append(docPart3);
            docParts1.Append(docPart4);

            glossaryDocument1.Append(docParts1);

            glossaryDocumentPart1.GlossaryDocument = glossaryDocument1;
        }

        // Generates content of documentSettingsPart1.
        private void GenerateDocumentSettingsPart1Content(DocumentSettingsPart documentSettingsPart1)
        {
            Settings settings1 = new Settings(){ MCAttributes = new MarkupCompatibilityAttributes(){ Ignorable = "w14 w15" }  };
            settings1.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            settings1.AddNamespaceDeclaration("o", "urn:schemas-microsoft-com:office:office");
            settings1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            settings1.AddNamespaceDeclaration("m", "http://schemas.openxmlformats.org/officeDocument/2006/math");
            settings1.AddNamespaceDeclaration("v", "urn:schemas-microsoft-com:vml");
            settings1.AddNamespaceDeclaration("w10", "urn:schemas-microsoft-com:office:word");
            settings1.AddNamespaceDeclaration("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main");
            settings1.AddNamespaceDeclaration("w14", "http://schemas.microsoft.com/office/word/2010/wordml");
            settings1.AddNamespaceDeclaration("w15", "http://schemas.microsoft.com/office/word/2010/11/wordml");
            settings1.AddNamespaceDeclaration("sl", "http://schemas.openxmlformats.org/schemaLibrary/2006/main");
            View view1 = new View(){ Val = ViewValues.Normal };
            BordersDoNotSurroundHeader bordersDoNotSurroundHeader1 = new BordersDoNotSurroundHeader();
            BordersDoNotSurroundFooter bordersDoNotSurroundFooter1 = new BordersDoNotSurroundFooter();
            DefaultTabStop defaultTabStop1 = new DefaultTabStop(){ Val = 840 };
            DisplayHorizontalDrawingGrid displayHorizontalDrawingGrid1 = new DisplayHorizontalDrawingGrid(){ Val = 0 };
            DisplayVerticalDrawingGrid displayVerticalDrawingGrid1 = new DisplayVerticalDrawingGrid(){ Val = 2 };
            CharacterSpacingControl characterSpacingControl1 = new CharacterSpacingControl(){ Val = CharacterSpacingValues.CompressPunctuation };

            Compatibility compatibility1 = new Compatibility();
            SpaceForUnderline spaceForUnderline1 = new SpaceForUnderline();
            BalanceSingleByteDoubleByteWidth balanceSingleByteDoubleByteWidth1 = new BalanceSingleByteDoubleByteWidth();
            DoNotLeaveBackslashAlone doNotLeaveBackslashAlone1 = new DoNotLeaveBackslashAlone();
            UnderlineTrailingSpaces underlineTrailingSpaces1 = new UnderlineTrailingSpaces();
            DoNotExpandShiftReturn doNotExpandShiftReturn1 = new DoNotExpandShiftReturn();
            AdjustLineHeightInTable adjustLineHeightInTable1 = new AdjustLineHeightInTable();
            UseFarEastLayout useFarEastLayout1 = new UseFarEastLayout();
            CompatibilitySetting compatibilitySetting1 = new CompatibilitySetting(){ Name = CompatSettingNameValues.CompatibilityMode, Uri = "http://schemas.microsoft.com/office/word", Val = "15" };
            CompatibilitySetting compatibilitySetting2 = new CompatibilitySetting(){ Name = CompatSettingNameValues.OverrideTableStyleFontSizeAndJustification, Uri = "http://schemas.microsoft.com/office/word", Val = "1" };
            CompatibilitySetting compatibilitySetting3 = new CompatibilitySetting(){ Name = CompatSettingNameValues.EnableOpenTypeFeatures, Uri = "http://schemas.microsoft.com/office/word", Val = "1" };
            CompatibilitySetting compatibilitySetting4 = new CompatibilitySetting(){ Name = CompatSettingNameValues.DoNotFlipMirrorIndents, Uri = "http://schemas.microsoft.com/office/word", Val = "1" };
            CompatibilitySetting compatibilitySetting5 = new CompatibilitySetting(){ Name = CompatSettingNameValues.DifferentiateMultirowTableHeaders, Uri = "http://schemas.microsoft.com/office/word", Val = "1" };

            compatibility1.Append(spaceForUnderline1);
            compatibility1.Append(balanceSingleByteDoubleByteWidth1);
            compatibility1.Append(doNotLeaveBackslashAlone1);
            compatibility1.Append(underlineTrailingSpaces1);
            compatibility1.Append(doNotExpandShiftReturn1);
            compatibility1.Append(adjustLineHeightInTable1);
            compatibility1.Append(useFarEastLayout1);
            compatibility1.Append(compatibilitySetting1);
            compatibility1.Append(compatibilitySetting2);
            compatibility1.Append(compatibilitySetting3);
            compatibility1.Append(compatibilitySetting4);
            compatibility1.Append(compatibilitySetting5);

            Rsids rsids1 = new Rsids();
            RsidRoot rsidRoot1 = new RsidRoot(){ Val = "00B75576" };
            Rsid rsid1 = new Rsid(){ Val = "00307267" };
            Rsid rsid2 = new Rsid(){ Val = "005E156B" };
            Rsid rsid3 = new Rsid(){ Val = "006415BA" };
            Rsid rsid4 = new Rsid(){ Val = "0066476A" };
            Rsid rsid5 = new Rsid(){ Val = "00930812" };
            Rsid rsid6 = new Rsid(){ Val = "00B75576" };
            Rsid rsid7 = new Rsid(){ Val = "00BA303C" };
            Rsid rsid8 = new Rsid(){ Val = "00EF189C" };

            rsids1.Append(rsidRoot1);
            rsids1.Append(rsid1);
            rsids1.Append(rsid2);
            rsids1.Append(rsid3);
            rsids1.Append(rsid4);
            rsids1.Append(rsid5);
            rsids1.Append(rsid6);
            rsids1.Append(rsid7);
            rsids1.Append(rsid8);

            M.MathProperties mathProperties1 = new M.MathProperties();
            M.MathFont mathFont1 = new M.MathFont(){ Val = "Cambria Math" };
            M.BreakBinary breakBinary1 = new M.BreakBinary(){ Val = M.BreakBinaryOperatorValues.Before };
            M.BreakBinarySubtraction breakBinarySubtraction1 = new M.BreakBinarySubtraction(){ Val = M.BreakBinarySubtractionValues.MinusMinus };
            M.SmallFraction smallFraction1 = new M.SmallFraction(){ Val = M.BooleanValues.Zero };
            M.DisplayDefaults displayDefaults1 = new M.DisplayDefaults();
            M.LeftMargin leftMargin1 = new M.LeftMargin(){ Val = (UInt32Value)0U };
            M.RightMargin rightMargin1 = new M.RightMargin(){ Val = (UInt32Value)0U };
            M.DefaultJustification defaultJustification1 = new M.DefaultJustification(){ Val = M.JustificationValues.CenterGroup };
            M.WrapIndent wrapIndent1 = new M.WrapIndent(){ Val = (UInt32Value)1440U };
            M.IntegralLimitLocation integralLimitLocation1 = new M.IntegralLimitLocation(){ Val = M.LimitLocationValues.SubscriptSuperscript };
            M.NaryLimitLocation naryLimitLocation1 = new M.NaryLimitLocation(){ Val = M.LimitLocationValues.UnderOver };

            mathProperties1.Append(mathFont1);
            mathProperties1.Append(breakBinary1);
            mathProperties1.Append(breakBinarySubtraction1);
            mathProperties1.Append(smallFraction1);
            mathProperties1.Append(displayDefaults1);
            mathProperties1.Append(leftMargin1);
            mathProperties1.Append(rightMargin1);
            mathProperties1.Append(defaultJustification1);
            mathProperties1.Append(wrapIndent1);
            mathProperties1.Append(integralLimitLocation1);
            mathProperties1.Append(naryLimitLocation1);
            ThemeFontLanguages themeFontLanguages1 = new ThemeFontLanguages(){ Val = "en-US", EastAsia = "ja-JP" };
            ColorSchemeMapping colorSchemeMapping1 = new ColorSchemeMapping(){ Background1 = ColorSchemeIndexValues.Light1, Text1 = ColorSchemeIndexValues.Dark1, Background2 = ColorSchemeIndexValues.Light2, Text2 = ColorSchemeIndexValues.Dark2, Accent1 = ColorSchemeIndexValues.Accent1, Accent2 = ColorSchemeIndexValues.Accent2, Accent3 = ColorSchemeIndexValues.Accent3, Accent4 = ColorSchemeIndexValues.Accent4, Accent5 = ColorSchemeIndexValues.Accent5, Accent6 = ColorSchemeIndexValues.Accent6, Hyperlink = ColorSchemeIndexValues.Hyperlink, FollowedHyperlink = ColorSchemeIndexValues.FollowedHyperlink };
            DecimalSymbol decimalSymbol1 = new DecimalSymbol(){ Val = "." };
            ListSeparator listSeparator1 = new ListSeparator(){ Val = "," };
            W15.ChartTrackingRefBased chartTrackingRefBased1 = new W15.ChartTrackingRefBased();

            settings1.Append(view1);
            settings1.Append(bordersDoNotSurroundHeader1);
            settings1.Append(bordersDoNotSurroundFooter1);
            settings1.Append(defaultTabStop1);
            settings1.Append(displayHorizontalDrawingGrid1);
            settings1.Append(displayVerticalDrawingGrid1);
            settings1.Append(characterSpacingControl1);
            settings1.Append(compatibility1);
            settings1.Append(rsids1);
            settings1.Append(mathProperties1);
            settings1.Append(themeFontLanguages1);
            settings1.Append(colorSchemeMapping1);
            settings1.Append(decimalSymbol1);
            settings1.Append(listSeparator1);
            settings1.Append(chartTrackingRefBased1);

            documentSettingsPart1.Settings = settings1;
        }

        // Generates content of stylesWithEffectsPart1.
        private void GenerateStylesWithEffectsPart1Content(StylesWithEffectsPart stylesWithEffectsPart1)
        {
            Styles styles1 = new Styles(){ MCAttributes = new MarkupCompatibilityAttributes(){ Ignorable = "w14 w15 wp14" }  };
            styles1.AddNamespaceDeclaration("wpc", "http://schemas.microsoft.com/office/word/2010/wordprocessingCanvas");
            styles1.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            styles1.AddNamespaceDeclaration("o", "urn:schemas-microsoft-com:office:office");
            styles1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            styles1.AddNamespaceDeclaration("m", "http://schemas.openxmlformats.org/officeDocument/2006/math");
            styles1.AddNamespaceDeclaration("v", "urn:schemas-microsoft-com:vml");
            styles1.AddNamespaceDeclaration("wp14", "http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing");
            styles1.AddNamespaceDeclaration("wp", "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing");
            styles1.AddNamespaceDeclaration("w10", "urn:schemas-microsoft-com:office:word");
            styles1.AddNamespaceDeclaration("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main");
            styles1.AddNamespaceDeclaration("w14", "http://schemas.microsoft.com/office/word/2010/wordml");
            styles1.AddNamespaceDeclaration("w15", "http://schemas.microsoft.com/office/word/2010/11/wordml");
            styles1.AddNamespaceDeclaration("wpg", "http://schemas.microsoft.com/office/word/2010/wordprocessingGroup");
            styles1.AddNamespaceDeclaration("wpi", "http://schemas.microsoft.com/office/word/2010/wordprocessingInk");
            styles1.AddNamespaceDeclaration("wne", "http://schemas.microsoft.com/office/word/2006/wordml");
            styles1.AddNamespaceDeclaration("wps", "http://schemas.microsoft.com/office/word/2010/wordprocessingShape");

            DocDefaults docDefaults1 = new DocDefaults();

            RunPropertiesDefault runPropertiesDefault1 = new RunPropertiesDefault();

            RunPropertiesBaseStyle runPropertiesBaseStyle1 = new RunPropertiesBaseStyle();
            RunFonts runFonts33 = new RunFonts(){ AsciiTheme = ThemeFontValues.MinorHighAnsi, HighAnsiTheme = ThemeFontValues.MinorHighAnsi, EastAsiaTheme = ThemeFontValues.MinorEastAsia, ComplexScriptTheme = ThemeFontValues.MinorBidi };
            Kern kern15 = new Kern(){ Val = (UInt32Value)2U };
            FontSize fontSize1 = new FontSize(){ Val = "21" };
            FontSizeComplexScript fontSizeComplexScript1 = new FontSizeComplexScript(){ Val = "22" };
            Languages languages1 = new Languages(){ Val = "en-US", EastAsia = "ja-JP", Bidi = "ar-SA" };

            runPropertiesBaseStyle1.Append(runFonts33);
            runPropertiesBaseStyle1.Append(kern15);
            runPropertiesBaseStyle1.Append(fontSize1);
            runPropertiesBaseStyle1.Append(fontSizeComplexScript1);
            runPropertiesBaseStyle1.Append(languages1);

            runPropertiesDefault1.Append(runPropertiesBaseStyle1);
            ParagraphPropertiesDefault paragraphPropertiesDefault1 = new ParagraphPropertiesDefault();

            docDefaults1.Append(runPropertiesDefault1);
            docDefaults1.Append(paragraphPropertiesDefault1);

            LatentStyles latentStyles1 = new LatentStyles(){ DefaultLockedState = false, DefaultUiPriority = 99, DefaultSemiHidden = true, DefaultUnhideWhenUsed = true, DefaultPrimaryStyle = false, Count = 267 };
            LatentStyleExceptionInfo latentStyleExceptionInfo1 = new LatentStyleExceptionInfo(){ Name = "Normal", UiPriority = 0, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo2 = new LatentStyleExceptionInfo(){ Name = "heading 1", UiPriority = 9, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo3 = new LatentStyleExceptionInfo(){ Name = "heading 2", UiPriority = 9, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo4 = new LatentStyleExceptionInfo(){ Name = "heading 3", UiPriority = 9, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo5 = new LatentStyleExceptionInfo(){ Name = "heading 4", UiPriority = 9, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo6 = new LatentStyleExceptionInfo(){ Name = "heading 5", UiPriority = 9, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo7 = new LatentStyleExceptionInfo(){ Name = "heading 6", UiPriority = 9, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo8 = new LatentStyleExceptionInfo(){ Name = "heading 7", UiPriority = 9, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo9 = new LatentStyleExceptionInfo(){ Name = "heading 8", UiPriority = 9, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo10 = new LatentStyleExceptionInfo(){ Name = "heading 9", UiPriority = 9, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo11 = new LatentStyleExceptionInfo(){ Name = "toc 1", UiPriority = 39 };
            LatentStyleExceptionInfo latentStyleExceptionInfo12 = new LatentStyleExceptionInfo(){ Name = "toc 2", UiPriority = 39 };
            LatentStyleExceptionInfo latentStyleExceptionInfo13 = new LatentStyleExceptionInfo(){ Name = "toc 3", UiPriority = 39 };
            LatentStyleExceptionInfo latentStyleExceptionInfo14 = new LatentStyleExceptionInfo(){ Name = "toc 4", UiPriority = 39 };
            LatentStyleExceptionInfo latentStyleExceptionInfo15 = new LatentStyleExceptionInfo(){ Name = "toc 5", UiPriority = 39 };
            LatentStyleExceptionInfo latentStyleExceptionInfo16 = new LatentStyleExceptionInfo(){ Name = "toc 6", UiPriority = 39 };
            LatentStyleExceptionInfo latentStyleExceptionInfo17 = new LatentStyleExceptionInfo(){ Name = "toc 7", UiPriority = 39 };
            LatentStyleExceptionInfo latentStyleExceptionInfo18 = new LatentStyleExceptionInfo(){ Name = "toc 8", UiPriority = 39 };
            LatentStyleExceptionInfo latentStyleExceptionInfo19 = new LatentStyleExceptionInfo(){ Name = "toc 9", UiPriority = 39 };
            LatentStyleExceptionInfo latentStyleExceptionInfo20 = new LatentStyleExceptionInfo(){ Name = "caption", UiPriority = 35, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo21 = new LatentStyleExceptionInfo(){ Name = "Title", UiPriority = 10, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo22 = new LatentStyleExceptionInfo(){ Name = "Default Paragraph Font", UiPriority = 1 };
            LatentStyleExceptionInfo latentStyleExceptionInfo23 = new LatentStyleExceptionInfo(){ Name = "Subtitle", UiPriority = 11, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo24 = new LatentStyleExceptionInfo(){ Name = "Strong", UiPriority = 22, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo25 = new LatentStyleExceptionInfo(){ Name = "Emphasis", UiPriority = 20, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo26 = new LatentStyleExceptionInfo(){ Name = "Table Grid", UiPriority = 59, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo27 = new LatentStyleExceptionInfo(){ Name = "Placeholder Text", UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo28 = new LatentStyleExceptionInfo(){ Name = "No Spacing", UiPriority = 36, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo29 = new LatentStyleExceptionInfo(){ Name = "Light Shading", UiPriority = 60, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo30 = new LatentStyleExceptionInfo(){ Name = "Light List", UiPriority = 61, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo31 = new LatentStyleExceptionInfo(){ Name = "Light Grid", UiPriority = 62, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo32 = new LatentStyleExceptionInfo(){ Name = "Medium Shading 1", UiPriority = 63, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo33 = new LatentStyleExceptionInfo(){ Name = "Medium Shading 2", UiPriority = 64, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo34 = new LatentStyleExceptionInfo(){ Name = "Medium List 1", UiPriority = 65, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo35 = new LatentStyleExceptionInfo(){ Name = "Medium List 2", UiPriority = 66, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo36 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 1", UiPriority = 67, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo37 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 2", UiPriority = 68, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo38 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 3", UiPriority = 69, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo39 = new LatentStyleExceptionInfo(){ Name = "Dark List", UiPriority = 70, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo40 = new LatentStyleExceptionInfo(){ Name = "Colorful Shading", UiPriority = 71, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo41 = new LatentStyleExceptionInfo(){ Name = "Colorful List", UiPriority = 72, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo42 = new LatentStyleExceptionInfo(){ Name = "Colorful Grid", UiPriority = 73, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo43 = new LatentStyleExceptionInfo(){ Name = "Light Shading Accent 1", UiPriority = 60, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo44 = new LatentStyleExceptionInfo(){ Name = "Light List Accent 1", UiPriority = 61, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo45 = new LatentStyleExceptionInfo(){ Name = "Light Grid Accent 1", UiPriority = 62, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo46 = new LatentStyleExceptionInfo(){ Name = "Medium Shading 1 Accent 1", UiPriority = 63, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo47 = new LatentStyleExceptionInfo(){ Name = "Medium Shading 2 Accent 1", UiPriority = 64, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo48 = new LatentStyleExceptionInfo(){ Name = "Medium List 1 Accent 1", UiPriority = 65, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo49 = new LatentStyleExceptionInfo(){ Name = "Revision", UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo50 = new LatentStyleExceptionInfo(){ Name = "List Paragraph", UiPriority = 34, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo51 = new LatentStyleExceptionInfo(){ Name = "Quote", UiPriority = 29, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo52 = new LatentStyleExceptionInfo(){ Name = "Intense Quote", UiPriority = 30, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo53 = new LatentStyleExceptionInfo(){ Name = "Medium List 2 Accent 1", UiPriority = 66, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo54 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 1 Accent 1", UiPriority = 67, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo55 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 2 Accent 1", UiPriority = 68, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo56 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 3 Accent 1", UiPriority = 69, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo57 = new LatentStyleExceptionInfo(){ Name = "Dark List Accent 1", UiPriority = 70, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo58 = new LatentStyleExceptionInfo(){ Name = "Colorful Shading Accent 1", UiPriority = 71, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo59 = new LatentStyleExceptionInfo(){ Name = "Colorful List Accent 1", UiPriority = 72, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo60 = new LatentStyleExceptionInfo(){ Name = "Colorful Grid Accent 1", UiPriority = 73, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo61 = new LatentStyleExceptionInfo(){ Name = "Light Shading Accent 2", UiPriority = 60, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo62 = new LatentStyleExceptionInfo(){ Name = "Light List Accent 2", UiPriority = 61, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo63 = new LatentStyleExceptionInfo(){ Name = "Light Grid Accent 2", UiPriority = 62, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo64 = new LatentStyleExceptionInfo(){ Name = "Medium Shading 1 Accent 2", UiPriority = 63, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo65 = new LatentStyleExceptionInfo(){ Name = "Medium Shading 2 Accent 2", UiPriority = 64, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo66 = new LatentStyleExceptionInfo(){ Name = "Medium List 1 Accent 2", UiPriority = 65, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo67 = new LatentStyleExceptionInfo(){ Name = "Medium List 2 Accent 2", UiPriority = 66, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo68 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 1 Accent 2", UiPriority = 67, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo69 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 2 Accent 2", UiPriority = 68, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo70 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 3 Accent 2", UiPriority = 69, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo71 = new LatentStyleExceptionInfo(){ Name = "Dark List Accent 2", UiPriority = 70, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo72 = new LatentStyleExceptionInfo(){ Name = "Colorful Shading Accent 2", UiPriority = 71, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo73 = new LatentStyleExceptionInfo(){ Name = "Colorful List Accent 2", UiPriority = 72, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo74 = new LatentStyleExceptionInfo(){ Name = "Colorful Grid Accent 2", UiPriority = 73, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo75 = new LatentStyleExceptionInfo(){ Name = "Light Shading Accent 3", UiPriority = 60, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo76 = new LatentStyleExceptionInfo(){ Name = "Light List Accent 3", UiPriority = 61, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo77 = new LatentStyleExceptionInfo(){ Name = "Light Grid Accent 3", UiPriority = 62, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo78 = new LatentStyleExceptionInfo(){ Name = "Medium Shading 1 Accent 3", UiPriority = 63, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo79 = new LatentStyleExceptionInfo(){ Name = "Medium Shading 2 Accent 3", UiPriority = 64, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo80 = new LatentStyleExceptionInfo(){ Name = "Medium List 1 Accent 3", UiPriority = 65, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo81 = new LatentStyleExceptionInfo(){ Name = "Medium List 2 Accent 3", UiPriority = 66, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo82 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 1 Accent 3", UiPriority = 67, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo83 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 2 Accent 3", UiPriority = 68, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo84 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 3 Accent 3", UiPriority = 69, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo85 = new LatentStyleExceptionInfo(){ Name = "Dark List Accent 3", UiPriority = 70, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo86 = new LatentStyleExceptionInfo(){ Name = "Colorful Shading Accent 3", UiPriority = 71, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo87 = new LatentStyleExceptionInfo(){ Name = "Colorful List Accent 3", UiPriority = 72, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo88 = new LatentStyleExceptionInfo(){ Name = "Colorful Grid Accent 3", UiPriority = 73, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo89 = new LatentStyleExceptionInfo(){ Name = "Light Shading Accent 4", UiPriority = 60, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo90 = new LatentStyleExceptionInfo(){ Name = "Light List Accent 4", UiPriority = 61, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo91 = new LatentStyleExceptionInfo(){ Name = "Light Grid Accent 4", UiPriority = 62, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo92 = new LatentStyleExceptionInfo(){ Name = "Medium Shading 1 Accent 4", UiPriority = 63, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo93 = new LatentStyleExceptionInfo(){ Name = "Medium Shading 2 Accent 4", UiPriority = 64, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo94 = new LatentStyleExceptionInfo(){ Name = "Medium List 1 Accent 4", UiPriority = 65, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo95 = new LatentStyleExceptionInfo(){ Name = "Medium List 2 Accent 4", UiPriority = 66, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo96 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 1 Accent 4", UiPriority = 67, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo97 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 2 Accent 4", UiPriority = 68, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo98 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 3 Accent 4", UiPriority = 69, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo99 = new LatentStyleExceptionInfo(){ Name = "Dark List Accent 4", UiPriority = 70, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo100 = new LatentStyleExceptionInfo(){ Name = "Colorful Shading Accent 4", UiPriority = 71, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo101 = new LatentStyleExceptionInfo(){ Name = "Colorful List Accent 4", UiPriority = 72, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo102 = new LatentStyleExceptionInfo(){ Name = "Colorful Grid Accent 4", UiPriority = 73, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo103 = new LatentStyleExceptionInfo(){ Name = "Light Shading Accent 5", UiPriority = 60, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo104 = new LatentStyleExceptionInfo(){ Name = "Light List Accent 5", UiPriority = 61, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo105 = new LatentStyleExceptionInfo(){ Name = "Light Grid Accent 5", UiPriority = 62, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo106 = new LatentStyleExceptionInfo(){ Name = "Medium Shading 1 Accent 5", UiPriority = 63, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo107 = new LatentStyleExceptionInfo(){ Name = "Medium Shading 2 Accent 5", UiPriority = 64, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo108 = new LatentStyleExceptionInfo(){ Name = "Medium List 1 Accent 5", UiPriority = 65, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo109 = new LatentStyleExceptionInfo(){ Name = "Medium List 2 Accent 5", UiPriority = 66, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo110 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 1 Accent 5", UiPriority = 67, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo111 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 2 Accent 5", UiPriority = 68, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo112 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 3 Accent 5", UiPriority = 69, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo113 = new LatentStyleExceptionInfo(){ Name = "Dark List Accent 5", UiPriority = 70, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo114 = new LatentStyleExceptionInfo(){ Name = "Colorful Shading Accent 5", UiPriority = 71, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo115 = new LatentStyleExceptionInfo(){ Name = "Colorful List Accent 5", UiPriority = 72, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo116 = new LatentStyleExceptionInfo(){ Name = "Colorful Grid Accent 5", UiPriority = 73, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo117 = new LatentStyleExceptionInfo(){ Name = "Light Shading Accent 6", UiPriority = 60, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo118 = new LatentStyleExceptionInfo(){ Name = "Light List Accent 6", UiPriority = 61, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo119 = new LatentStyleExceptionInfo(){ Name = "Light Grid Accent 6", UiPriority = 62, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo120 = new LatentStyleExceptionInfo(){ Name = "Medium Shading 1 Accent 6", UiPriority = 63, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo121 = new LatentStyleExceptionInfo(){ Name = "Medium Shading 2 Accent 6", UiPriority = 64, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo122 = new LatentStyleExceptionInfo(){ Name = "Medium List 1 Accent 6", UiPriority = 65, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo123 = new LatentStyleExceptionInfo(){ Name = "Medium List 2 Accent 6", UiPriority = 66, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo124 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 1 Accent 6", UiPriority = 67, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo125 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 2 Accent 6", UiPriority = 68, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo126 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 3 Accent 6", UiPriority = 69, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo127 = new LatentStyleExceptionInfo(){ Name = "Dark List Accent 6", UiPriority = 70, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo128 = new LatentStyleExceptionInfo(){ Name = "Colorful Shading Accent 6", UiPriority = 71, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo129 = new LatentStyleExceptionInfo(){ Name = "Colorful List Accent 6", UiPriority = 72, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo130 = new LatentStyleExceptionInfo(){ Name = "Colorful Grid Accent 6", UiPriority = 73, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo131 = new LatentStyleExceptionInfo(){ Name = "Subtle Emphasis", UiPriority = 19, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo132 = new LatentStyleExceptionInfo(){ Name = "Intense Emphasis", UiPriority = 21, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo133 = new LatentStyleExceptionInfo(){ Name = "Subtle Reference", UiPriority = 31, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo134 = new LatentStyleExceptionInfo(){ Name = "Intense Reference", UiPriority = 32, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo135 = new LatentStyleExceptionInfo(){ Name = "Book Title", UiPriority = 33, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo136 = new LatentStyleExceptionInfo(){ Name = "Bibliography", UiPriority = 37 };
            LatentStyleExceptionInfo latentStyleExceptionInfo137 = new LatentStyleExceptionInfo(){ Name = "TOC Heading", UiPriority = 39, PrimaryStyle = true };

            latentStyles1.Append(latentStyleExceptionInfo1);
            latentStyles1.Append(latentStyleExceptionInfo2);
            latentStyles1.Append(latentStyleExceptionInfo3);
            latentStyles1.Append(latentStyleExceptionInfo4);
            latentStyles1.Append(latentStyleExceptionInfo5);
            latentStyles1.Append(latentStyleExceptionInfo6);
            latentStyles1.Append(latentStyleExceptionInfo7);
            latentStyles1.Append(latentStyleExceptionInfo8);
            latentStyles1.Append(latentStyleExceptionInfo9);
            latentStyles1.Append(latentStyleExceptionInfo10);
            latentStyles1.Append(latentStyleExceptionInfo11);
            latentStyles1.Append(latentStyleExceptionInfo12);
            latentStyles1.Append(latentStyleExceptionInfo13);
            latentStyles1.Append(latentStyleExceptionInfo14);
            latentStyles1.Append(latentStyleExceptionInfo15);
            latentStyles1.Append(latentStyleExceptionInfo16);
            latentStyles1.Append(latentStyleExceptionInfo17);
            latentStyles1.Append(latentStyleExceptionInfo18);
            latentStyles1.Append(latentStyleExceptionInfo19);
            latentStyles1.Append(latentStyleExceptionInfo20);
            latentStyles1.Append(latentStyleExceptionInfo21);
            latentStyles1.Append(latentStyleExceptionInfo22);
            latentStyles1.Append(latentStyleExceptionInfo23);
            latentStyles1.Append(latentStyleExceptionInfo24);
            latentStyles1.Append(latentStyleExceptionInfo25);
            latentStyles1.Append(latentStyleExceptionInfo26);
            latentStyles1.Append(latentStyleExceptionInfo27);
            latentStyles1.Append(latentStyleExceptionInfo28);
            latentStyles1.Append(latentStyleExceptionInfo29);
            latentStyles1.Append(latentStyleExceptionInfo30);
            latentStyles1.Append(latentStyleExceptionInfo31);
            latentStyles1.Append(latentStyleExceptionInfo32);
            latentStyles1.Append(latentStyleExceptionInfo33);
            latentStyles1.Append(latentStyleExceptionInfo34);
            latentStyles1.Append(latentStyleExceptionInfo35);
            latentStyles1.Append(latentStyleExceptionInfo36);
            latentStyles1.Append(latentStyleExceptionInfo37);
            latentStyles1.Append(latentStyleExceptionInfo38);
            latentStyles1.Append(latentStyleExceptionInfo39);
            latentStyles1.Append(latentStyleExceptionInfo40);
            latentStyles1.Append(latentStyleExceptionInfo41);
            latentStyles1.Append(latentStyleExceptionInfo42);
            latentStyles1.Append(latentStyleExceptionInfo43);
            latentStyles1.Append(latentStyleExceptionInfo44);
            latentStyles1.Append(latentStyleExceptionInfo45);
            latentStyles1.Append(latentStyleExceptionInfo46);
            latentStyles1.Append(latentStyleExceptionInfo47);
            latentStyles1.Append(latentStyleExceptionInfo48);
            latentStyles1.Append(latentStyleExceptionInfo49);
            latentStyles1.Append(latentStyleExceptionInfo50);
            latentStyles1.Append(latentStyleExceptionInfo51);
            latentStyles1.Append(latentStyleExceptionInfo52);
            latentStyles1.Append(latentStyleExceptionInfo53);
            latentStyles1.Append(latentStyleExceptionInfo54);
            latentStyles1.Append(latentStyleExceptionInfo55);
            latentStyles1.Append(latentStyleExceptionInfo56);
            latentStyles1.Append(latentStyleExceptionInfo57);
            latentStyles1.Append(latentStyleExceptionInfo58);
            latentStyles1.Append(latentStyleExceptionInfo59);
            latentStyles1.Append(latentStyleExceptionInfo60);
            latentStyles1.Append(latentStyleExceptionInfo61);
            latentStyles1.Append(latentStyleExceptionInfo62);
            latentStyles1.Append(latentStyleExceptionInfo63);
            latentStyles1.Append(latentStyleExceptionInfo64);
            latentStyles1.Append(latentStyleExceptionInfo65);
            latentStyles1.Append(latentStyleExceptionInfo66);
            latentStyles1.Append(latentStyleExceptionInfo67);
            latentStyles1.Append(latentStyleExceptionInfo68);
            latentStyles1.Append(latentStyleExceptionInfo69);
            latentStyles1.Append(latentStyleExceptionInfo70);
            latentStyles1.Append(latentStyleExceptionInfo71);
            latentStyles1.Append(latentStyleExceptionInfo72);
            latentStyles1.Append(latentStyleExceptionInfo73);
            latentStyles1.Append(latentStyleExceptionInfo74);
            latentStyles1.Append(latentStyleExceptionInfo75);
            latentStyles1.Append(latentStyleExceptionInfo76);
            latentStyles1.Append(latentStyleExceptionInfo77);
            latentStyles1.Append(latentStyleExceptionInfo78);
            latentStyles1.Append(latentStyleExceptionInfo79);
            latentStyles1.Append(latentStyleExceptionInfo80);
            latentStyles1.Append(latentStyleExceptionInfo81);
            latentStyles1.Append(latentStyleExceptionInfo82);
            latentStyles1.Append(latentStyleExceptionInfo83);
            latentStyles1.Append(latentStyleExceptionInfo84);
            latentStyles1.Append(latentStyleExceptionInfo85);
            latentStyles1.Append(latentStyleExceptionInfo86);
            latentStyles1.Append(latentStyleExceptionInfo87);
            latentStyles1.Append(latentStyleExceptionInfo88);
            latentStyles1.Append(latentStyleExceptionInfo89);
            latentStyles1.Append(latentStyleExceptionInfo90);
            latentStyles1.Append(latentStyleExceptionInfo91);
            latentStyles1.Append(latentStyleExceptionInfo92);
            latentStyles1.Append(latentStyleExceptionInfo93);
            latentStyles1.Append(latentStyleExceptionInfo94);
            latentStyles1.Append(latentStyleExceptionInfo95);
            latentStyles1.Append(latentStyleExceptionInfo96);
            latentStyles1.Append(latentStyleExceptionInfo97);
            latentStyles1.Append(latentStyleExceptionInfo98);
            latentStyles1.Append(latentStyleExceptionInfo99);
            latentStyles1.Append(latentStyleExceptionInfo100);
            latentStyles1.Append(latentStyleExceptionInfo101);
            latentStyles1.Append(latentStyleExceptionInfo102);
            latentStyles1.Append(latentStyleExceptionInfo103);
            latentStyles1.Append(latentStyleExceptionInfo104);
            latentStyles1.Append(latentStyleExceptionInfo105);
            latentStyles1.Append(latentStyleExceptionInfo106);
            latentStyles1.Append(latentStyleExceptionInfo107);
            latentStyles1.Append(latentStyleExceptionInfo108);
            latentStyles1.Append(latentStyleExceptionInfo109);
            latentStyles1.Append(latentStyleExceptionInfo110);
            latentStyles1.Append(latentStyleExceptionInfo111);
            latentStyles1.Append(latentStyleExceptionInfo112);
            latentStyles1.Append(latentStyleExceptionInfo113);
            latentStyles1.Append(latentStyleExceptionInfo114);
            latentStyles1.Append(latentStyleExceptionInfo115);
            latentStyles1.Append(latentStyleExceptionInfo116);
            latentStyles1.Append(latentStyleExceptionInfo117);
            latentStyles1.Append(latentStyleExceptionInfo118);
            latentStyles1.Append(latentStyleExceptionInfo119);
            latentStyles1.Append(latentStyleExceptionInfo120);
            latentStyles1.Append(latentStyleExceptionInfo121);
            latentStyles1.Append(latentStyleExceptionInfo122);
            latentStyles1.Append(latentStyleExceptionInfo123);
            latentStyles1.Append(latentStyleExceptionInfo124);
            latentStyles1.Append(latentStyleExceptionInfo125);
            latentStyles1.Append(latentStyleExceptionInfo126);
            latentStyles1.Append(latentStyleExceptionInfo127);
            latentStyles1.Append(latentStyleExceptionInfo128);
            latentStyles1.Append(latentStyleExceptionInfo129);
            latentStyles1.Append(latentStyleExceptionInfo130);
            latentStyles1.Append(latentStyleExceptionInfo131);
            latentStyles1.Append(latentStyleExceptionInfo132);
            latentStyles1.Append(latentStyleExceptionInfo133);
            latentStyles1.Append(latentStyleExceptionInfo134);
            latentStyles1.Append(latentStyleExceptionInfo135);
            latentStyles1.Append(latentStyleExceptionInfo136);
            latentStyles1.Append(latentStyleExceptionInfo137);

            Style style1 = new Style(){ Type = StyleValues.Paragraph, StyleId = "Normal", Default = true };
            StyleName styleName1 = new StyleName(){ Val = "Normal" };
            PrimaryStyle primaryStyle1 = new PrimaryStyle();

            StyleParagraphProperties styleParagraphProperties1 = new StyleParagraphProperties();
            WidowControl widowControl1 = new WidowControl(){ Val = false };
            Justification justification1 = new Justification(){ Val = JustificationValues.Both };

            styleParagraphProperties1.Append(widowControl1);
            styleParagraphProperties1.Append(justification1);

            style1.Append(styleName1);
            style1.Append(primaryStyle1);
            style1.Append(styleParagraphProperties1);

            Style style2 = new Style(){ Type = StyleValues.Character, StyleId = "DefaultParagraphFont", Default = true };
            StyleName styleName2 = new StyleName(){ Val = "Default Paragraph Font" };
            UIPriority uIPriority1 = new UIPriority(){ Val = 1 };
            SemiHidden semiHidden1 = new SemiHidden();
            UnhideWhenUsed unhideWhenUsed1 = new UnhideWhenUsed();

            style2.Append(styleName2);
            style2.Append(uIPriority1);
            style2.Append(semiHidden1);
            style2.Append(unhideWhenUsed1);

            Style style3 = new Style(){ Type = StyleValues.Table, StyleId = "TableNormal", Default = true };
            StyleName styleName3 = new StyleName(){ Val = "Normal Table" };
            UIPriority uIPriority2 = new UIPriority(){ Val = 99 };
            SemiHidden semiHidden2 = new SemiHidden();
            UnhideWhenUsed unhideWhenUsed2 = new UnhideWhenUsed();

            StyleTableProperties styleTableProperties1 = new StyleTableProperties();
            TableIndentation tableIndentation1 = new TableIndentation(){ Width = 0, Type = TableWidthUnitValues.Dxa };

            TableCellMarginDefault tableCellMarginDefault1 = new TableCellMarginDefault();
            TopMargin topMargin1 = new TopMargin(){ Width = "0", Type = TableWidthUnitValues.Dxa };
            TableCellLeftMargin tableCellLeftMargin1 = new TableCellLeftMargin(){ Width = 108, Type = TableWidthValues.Dxa };
            BottomMargin bottomMargin1 = new BottomMargin(){ Width = "0", Type = TableWidthUnitValues.Dxa };
            TableCellRightMargin tableCellRightMargin1 = new TableCellRightMargin(){ Width = 108, Type = TableWidthValues.Dxa };

            tableCellMarginDefault1.Append(topMargin1);
            tableCellMarginDefault1.Append(tableCellLeftMargin1);
            tableCellMarginDefault1.Append(bottomMargin1);
            tableCellMarginDefault1.Append(tableCellRightMargin1);

            styleTableProperties1.Append(tableIndentation1);
            styleTableProperties1.Append(tableCellMarginDefault1);

            style3.Append(styleName3);
            style3.Append(uIPriority2);
            style3.Append(semiHidden2);
            style3.Append(unhideWhenUsed2);
            style3.Append(styleTableProperties1);

            Style style4 = new Style(){ Type = StyleValues.Numbering, StyleId = "NoList", Default = true };
            StyleName styleName4 = new StyleName(){ Val = "No List" };
            UIPriority uIPriority3 = new UIPriority(){ Val = 99 };
            SemiHidden semiHidden3 = new SemiHidden();
            UnhideWhenUsed unhideWhenUsed3 = new UnhideWhenUsed();

            style4.Append(styleName4);
            style4.Append(uIPriority3);
            style4.Append(semiHidden3);
            style4.Append(unhideWhenUsed3);

            Style style5 = new Style(){ Type = StyleValues.Character, StyleId = "PlaceholderText" };
            StyleName styleName5 = new StyleName(){ Val = "Placeholder Text" };
            BasedOn basedOn1 = new BasedOn(){ Val = "DefaultParagraphFont" };
            UIPriority uIPriority4 = new UIPriority(){ Val = 99 };
            SemiHidden semiHidden4 = new SemiHidden();
            Rsid rsid9 = new Rsid(){ Val = "00930812" };

            StyleRunProperties styleRunProperties1 = new StyleRunProperties();
            Color color2 = new Color(){ Val = "808080" };

            styleRunProperties1.Append(color2);

            style5.Append(styleName5);
            style5.Append(basedOn1);
            style5.Append(uIPriority4);
            style5.Append(semiHidden4);
            style5.Append(rsid9);
            style5.Append(styleRunProperties1);

            Style style6 = new Style(){ Type = StyleValues.Paragraph, StyleId = "B207B2DF6D0E4E13956E6616811860CA", CustomStyle = true };
            StyleName styleName6 = new StyleName(){ Val = "B207B2DF6D0E4E13956E6616811860CA" };
            Rsid rsid10 = new Rsid(){ Val = "00930812" };

            StyleParagraphProperties styleParagraphProperties2 = new StyleParagraphProperties();
            WidowControl widowControl2 = new WidowControl(){ Val = false };
            Justification justification2 = new Justification(){ Val = JustificationValues.Both };

            styleParagraphProperties2.Append(widowControl2);
            styleParagraphProperties2.Append(justification2);

            style6.Append(styleName6);
            style6.Append(rsid10);
            style6.Append(styleParagraphProperties2);

            Style style7 = new Style(){ Type = StyleValues.Paragraph, StyleId = "D4883C3CFFC34F409428ADC3628C6570", CustomStyle = true };
            StyleName styleName7 = new StyleName(){ Val = "D4883C3CFFC34F409428ADC3628C6570" };
            Rsid rsid11 = new Rsid(){ Val = "00930812" };

            StyleParagraphProperties styleParagraphProperties3 = new StyleParagraphProperties();
            WidowControl widowControl3 = new WidowControl(){ Val = false };
            Justification justification3 = new Justification(){ Val = JustificationValues.Both };

            styleParagraphProperties3.Append(widowControl3);
            styleParagraphProperties3.Append(justification3);

            style7.Append(styleName7);
            style7.Append(rsid11);
            style7.Append(styleParagraphProperties3);

            Style style8 = new Style(){ Type = StyleValues.Paragraph, StyleId = "133ECC909A29476B8F1E90DE917BAC44", CustomStyle = true };
            StyleName styleName8 = new StyleName(){ Val = "133ECC909A29476B8F1E90DE917BAC44" };
            Rsid rsid12 = new Rsid(){ Val = "00930812" };

            StyleParagraphProperties styleParagraphProperties4 = new StyleParagraphProperties();
            WidowControl widowControl4 = new WidowControl(){ Val = false };
            Justification justification4 = new Justification(){ Val = JustificationValues.Both };

            styleParagraphProperties4.Append(widowControl4);
            styleParagraphProperties4.Append(justification4);

            style8.Append(styleName8);
            style8.Append(rsid12);
            style8.Append(styleParagraphProperties4);

            Style style9 = new Style(){ Type = StyleValues.Paragraph, StyleId = "4B632797D8B1461898B8F461443A20E0", CustomStyle = true };
            StyleName styleName9 = new StyleName(){ Val = "4B632797D8B1461898B8F461443A20E0" };
            Rsid rsid13 = new Rsid(){ Val = "00930812" };

            StyleParagraphProperties styleParagraphProperties5 = new StyleParagraphProperties();
            WidowControl widowControl5 = new WidowControl(){ Val = false };
            Justification justification5 = new Justification(){ Val = JustificationValues.Both };

            styleParagraphProperties5.Append(widowControl5);
            styleParagraphProperties5.Append(justification5);

            style9.Append(styleName9);
            style9.Append(rsid13);
            style9.Append(styleParagraphProperties5);

            Style style10 = new Style(){ Type = StyleValues.Paragraph, StyleId = "8E3192E882304BDA9D0B4E69A021C365", CustomStyle = true };
            StyleName styleName10 = new StyleName(){ Val = "8E3192E882304BDA9D0B4E69A021C365" };
            Rsid rsid14 = new Rsid(){ Val = "00930812" };

            StyleParagraphProperties styleParagraphProperties6 = new StyleParagraphProperties();
            WidowControl widowControl6 = new WidowControl(){ Val = false };
            Justification justification6 = new Justification(){ Val = JustificationValues.Both };

            styleParagraphProperties6.Append(widowControl6);
            styleParagraphProperties6.Append(justification6);

            style10.Append(styleName10);
            style10.Append(rsid14);
            style10.Append(styleParagraphProperties6);

            styles1.Append(docDefaults1);
            styles1.Append(latentStyles1);
            styles1.Append(style1);
            styles1.Append(style2);
            styles1.Append(style3);
            styles1.Append(style4);
            styles1.Append(style5);
            styles1.Append(style6);
            styles1.Append(style7);
            styles1.Append(style8);
            styles1.Append(style9);
            styles1.Append(style10);

            stylesWithEffectsPart1.Styles = styles1;
        }

        // Generates content of styleDefinitionsPart1.
        private void GenerateStyleDefinitionsPart1Content(StyleDefinitionsPart styleDefinitionsPart1)
        {
            Styles styles2 = new Styles(){ MCAttributes = new MarkupCompatibilityAttributes(){ Ignorable = "w14 w15" }  };
            styles2.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            styles2.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            styles2.AddNamespaceDeclaration("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main");
            styles2.AddNamespaceDeclaration("w14", "http://schemas.microsoft.com/office/word/2010/wordml");
            styles2.AddNamespaceDeclaration("w15", "http://schemas.microsoft.com/office/word/2010/11/wordml");

            DocDefaults docDefaults2 = new DocDefaults();

            RunPropertiesDefault runPropertiesDefault2 = new RunPropertiesDefault();

            RunPropertiesBaseStyle runPropertiesBaseStyle2 = new RunPropertiesBaseStyle();
            RunFonts runFonts34 = new RunFonts(){ AsciiTheme = ThemeFontValues.MinorHighAnsi, HighAnsiTheme = ThemeFontValues.MinorHighAnsi, EastAsiaTheme = ThemeFontValues.MinorEastAsia, ComplexScriptTheme = ThemeFontValues.MinorBidi };
            Kern kern16 = new Kern(){ Val = (UInt32Value)2U };
            FontSize fontSize2 = new FontSize(){ Val = "21" };
            FontSizeComplexScript fontSizeComplexScript2 = new FontSizeComplexScript(){ Val = "22" };
            Languages languages2 = new Languages(){ Val = "en-US", EastAsia = "ja-JP", Bidi = "ar-SA" };

            runPropertiesBaseStyle2.Append(runFonts34);
            runPropertiesBaseStyle2.Append(kern16);
            runPropertiesBaseStyle2.Append(fontSize2);
            runPropertiesBaseStyle2.Append(fontSizeComplexScript2);
            runPropertiesBaseStyle2.Append(languages2);

            runPropertiesDefault2.Append(runPropertiesBaseStyle2);
            ParagraphPropertiesDefault paragraphPropertiesDefault2 = new ParagraphPropertiesDefault();

            docDefaults2.Append(runPropertiesDefault2);
            docDefaults2.Append(paragraphPropertiesDefault2);

            LatentStyles latentStyles2 = new LatentStyles(){ DefaultLockedState = false, DefaultUiPriority = 99, DefaultSemiHidden = true, DefaultUnhideWhenUsed = true, DefaultPrimaryStyle = false, Count = 267 };
            LatentStyleExceptionInfo latentStyleExceptionInfo138 = new LatentStyleExceptionInfo(){ Name = "Normal", UiPriority = 0, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo139 = new LatentStyleExceptionInfo(){ Name = "heading 1", UiPriority = 9, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo140 = new LatentStyleExceptionInfo(){ Name = "heading 2", UiPriority = 9, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo141 = new LatentStyleExceptionInfo(){ Name = "heading 3", UiPriority = 9, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo142 = new LatentStyleExceptionInfo(){ Name = "heading 4", UiPriority = 9, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo143 = new LatentStyleExceptionInfo(){ Name = "heading 5", UiPriority = 9, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo144 = new LatentStyleExceptionInfo(){ Name = "heading 6", UiPriority = 9, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo145 = new LatentStyleExceptionInfo(){ Name = "heading 7", UiPriority = 9, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo146 = new LatentStyleExceptionInfo(){ Name = "heading 8", UiPriority = 9, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo147 = new LatentStyleExceptionInfo(){ Name = "heading 9", UiPriority = 9, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo148 = new LatentStyleExceptionInfo(){ Name = "toc 1", UiPriority = 39 };
            LatentStyleExceptionInfo latentStyleExceptionInfo149 = new LatentStyleExceptionInfo(){ Name = "toc 2", UiPriority = 39 };
            LatentStyleExceptionInfo latentStyleExceptionInfo150 = new LatentStyleExceptionInfo(){ Name = "toc 3", UiPriority = 39 };
            LatentStyleExceptionInfo latentStyleExceptionInfo151 = new LatentStyleExceptionInfo(){ Name = "toc 4", UiPriority = 39 };
            LatentStyleExceptionInfo latentStyleExceptionInfo152 = new LatentStyleExceptionInfo(){ Name = "toc 5", UiPriority = 39 };
            LatentStyleExceptionInfo latentStyleExceptionInfo153 = new LatentStyleExceptionInfo(){ Name = "toc 6", UiPriority = 39 };
            LatentStyleExceptionInfo latentStyleExceptionInfo154 = new LatentStyleExceptionInfo(){ Name = "toc 7", UiPriority = 39 };
            LatentStyleExceptionInfo latentStyleExceptionInfo155 = new LatentStyleExceptionInfo(){ Name = "toc 8", UiPriority = 39 };
            LatentStyleExceptionInfo latentStyleExceptionInfo156 = new LatentStyleExceptionInfo(){ Name = "toc 9", UiPriority = 39 };
            LatentStyleExceptionInfo latentStyleExceptionInfo157 = new LatentStyleExceptionInfo(){ Name = "caption", UiPriority = 35, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo158 = new LatentStyleExceptionInfo(){ Name = "Title", UiPriority = 10, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo159 = new LatentStyleExceptionInfo(){ Name = "Default Paragraph Font", UiPriority = 1 };
            LatentStyleExceptionInfo latentStyleExceptionInfo160 = new LatentStyleExceptionInfo(){ Name = "Subtitle", UiPriority = 11, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo161 = new LatentStyleExceptionInfo(){ Name = "Strong", UiPriority = 22, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo162 = new LatentStyleExceptionInfo(){ Name = "Emphasis", UiPriority = 20, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo163 = new LatentStyleExceptionInfo(){ Name = "Table Grid", UiPriority = 59, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo164 = new LatentStyleExceptionInfo(){ Name = "Placeholder Text", UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo165 = new LatentStyleExceptionInfo(){ Name = "No Spacing", UiPriority = 36, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo166 = new LatentStyleExceptionInfo(){ Name = "Light Shading", UiPriority = 60, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo167 = new LatentStyleExceptionInfo(){ Name = "Light List", UiPriority = 61, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo168 = new LatentStyleExceptionInfo(){ Name = "Light Grid", UiPriority = 62, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo169 = new LatentStyleExceptionInfo(){ Name = "Medium Shading 1", UiPriority = 63, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo170 = new LatentStyleExceptionInfo(){ Name = "Medium Shading 2", UiPriority = 64, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo171 = new LatentStyleExceptionInfo(){ Name = "Medium List 1", UiPriority = 65, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo172 = new LatentStyleExceptionInfo(){ Name = "Medium List 2", UiPriority = 66, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo173 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 1", UiPriority = 67, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo174 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 2", UiPriority = 68, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo175 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 3", UiPriority = 69, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo176 = new LatentStyleExceptionInfo(){ Name = "Dark List", UiPriority = 70, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo177 = new LatentStyleExceptionInfo(){ Name = "Colorful Shading", UiPriority = 71, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo178 = new LatentStyleExceptionInfo(){ Name = "Colorful List", UiPriority = 72, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo179 = new LatentStyleExceptionInfo(){ Name = "Colorful Grid", UiPriority = 73, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo180 = new LatentStyleExceptionInfo(){ Name = "Light Shading Accent 1", UiPriority = 60, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo181 = new LatentStyleExceptionInfo(){ Name = "Light List Accent 1", UiPriority = 61, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo182 = new LatentStyleExceptionInfo(){ Name = "Light Grid Accent 1", UiPriority = 62, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo183 = new LatentStyleExceptionInfo(){ Name = "Medium Shading 1 Accent 1", UiPriority = 63, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo184 = new LatentStyleExceptionInfo(){ Name = "Medium Shading 2 Accent 1", UiPriority = 64, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo185 = new LatentStyleExceptionInfo(){ Name = "Medium List 1 Accent 1", UiPriority = 65, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo186 = new LatentStyleExceptionInfo(){ Name = "Revision", UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo187 = new LatentStyleExceptionInfo(){ Name = "List Paragraph", UiPriority = 34, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo188 = new LatentStyleExceptionInfo(){ Name = "Quote", UiPriority = 29, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo189 = new LatentStyleExceptionInfo(){ Name = "Intense Quote", UiPriority = 30, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo190 = new LatentStyleExceptionInfo(){ Name = "Medium List 2 Accent 1", UiPriority = 66, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo191 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 1 Accent 1", UiPriority = 67, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo192 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 2 Accent 1", UiPriority = 68, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo193 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 3 Accent 1", UiPriority = 69, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo194 = new LatentStyleExceptionInfo(){ Name = "Dark List Accent 1", UiPriority = 70, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo195 = new LatentStyleExceptionInfo(){ Name = "Colorful Shading Accent 1", UiPriority = 71, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo196 = new LatentStyleExceptionInfo(){ Name = "Colorful List Accent 1", UiPriority = 72, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo197 = new LatentStyleExceptionInfo(){ Name = "Colorful Grid Accent 1", UiPriority = 73, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo198 = new LatentStyleExceptionInfo(){ Name = "Light Shading Accent 2", UiPriority = 60, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo199 = new LatentStyleExceptionInfo(){ Name = "Light List Accent 2", UiPriority = 61, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo200 = new LatentStyleExceptionInfo(){ Name = "Light Grid Accent 2", UiPriority = 62, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo201 = new LatentStyleExceptionInfo(){ Name = "Medium Shading 1 Accent 2", UiPriority = 63, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo202 = new LatentStyleExceptionInfo(){ Name = "Medium Shading 2 Accent 2", UiPriority = 64, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo203 = new LatentStyleExceptionInfo(){ Name = "Medium List 1 Accent 2", UiPriority = 65, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo204 = new LatentStyleExceptionInfo(){ Name = "Medium List 2 Accent 2", UiPriority = 66, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo205 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 1 Accent 2", UiPriority = 67, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo206 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 2 Accent 2", UiPriority = 68, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo207 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 3 Accent 2", UiPriority = 69, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo208 = new LatentStyleExceptionInfo(){ Name = "Dark List Accent 2", UiPriority = 70, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo209 = new LatentStyleExceptionInfo(){ Name = "Colorful Shading Accent 2", UiPriority = 71, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo210 = new LatentStyleExceptionInfo(){ Name = "Colorful List Accent 2", UiPriority = 72, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo211 = new LatentStyleExceptionInfo(){ Name = "Colorful Grid Accent 2", UiPriority = 73, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo212 = new LatentStyleExceptionInfo(){ Name = "Light Shading Accent 3", UiPriority = 60, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo213 = new LatentStyleExceptionInfo(){ Name = "Light List Accent 3", UiPriority = 61, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo214 = new LatentStyleExceptionInfo(){ Name = "Light Grid Accent 3", UiPriority = 62, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo215 = new LatentStyleExceptionInfo(){ Name = "Medium Shading 1 Accent 3", UiPriority = 63, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo216 = new LatentStyleExceptionInfo(){ Name = "Medium Shading 2 Accent 3", UiPriority = 64, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo217 = new LatentStyleExceptionInfo(){ Name = "Medium List 1 Accent 3", UiPriority = 65, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo218 = new LatentStyleExceptionInfo(){ Name = "Medium List 2 Accent 3", UiPriority = 66, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo219 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 1 Accent 3", UiPriority = 67, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo220 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 2 Accent 3", UiPriority = 68, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo221 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 3 Accent 3", UiPriority = 69, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo222 = new LatentStyleExceptionInfo(){ Name = "Dark List Accent 3", UiPriority = 70, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo223 = new LatentStyleExceptionInfo(){ Name = "Colorful Shading Accent 3", UiPriority = 71, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo224 = new LatentStyleExceptionInfo(){ Name = "Colorful List Accent 3", UiPriority = 72, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo225 = new LatentStyleExceptionInfo(){ Name = "Colorful Grid Accent 3", UiPriority = 73, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo226 = new LatentStyleExceptionInfo(){ Name = "Light Shading Accent 4", UiPriority = 60, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo227 = new LatentStyleExceptionInfo(){ Name = "Light List Accent 4", UiPriority = 61, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo228 = new LatentStyleExceptionInfo(){ Name = "Light Grid Accent 4", UiPriority = 62, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo229 = new LatentStyleExceptionInfo(){ Name = "Medium Shading 1 Accent 4", UiPriority = 63, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo230 = new LatentStyleExceptionInfo(){ Name = "Medium Shading 2 Accent 4", UiPriority = 64, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo231 = new LatentStyleExceptionInfo(){ Name = "Medium List 1 Accent 4", UiPriority = 65, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo232 = new LatentStyleExceptionInfo(){ Name = "Medium List 2 Accent 4", UiPriority = 66, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo233 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 1 Accent 4", UiPriority = 67, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo234 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 2 Accent 4", UiPriority = 68, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo235 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 3 Accent 4", UiPriority = 69, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo236 = new LatentStyleExceptionInfo(){ Name = "Dark List Accent 4", UiPriority = 70, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo237 = new LatentStyleExceptionInfo(){ Name = "Colorful Shading Accent 4", UiPriority = 71, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo238 = new LatentStyleExceptionInfo(){ Name = "Colorful List Accent 4", UiPriority = 72, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo239 = new LatentStyleExceptionInfo(){ Name = "Colorful Grid Accent 4", UiPriority = 73, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo240 = new LatentStyleExceptionInfo(){ Name = "Light Shading Accent 5", UiPriority = 60, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo241 = new LatentStyleExceptionInfo(){ Name = "Light List Accent 5", UiPriority = 61, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo242 = new LatentStyleExceptionInfo(){ Name = "Light Grid Accent 5", UiPriority = 62, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo243 = new LatentStyleExceptionInfo(){ Name = "Medium Shading 1 Accent 5", UiPriority = 63, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo244 = new LatentStyleExceptionInfo(){ Name = "Medium Shading 2 Accent 5", UiPriority = 64, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo245 = new LatentStyleExceptionInfo(){ Name = "Medium List 1 Accent 5", UiPriority = 65, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo246 = new LatentStyleExceptionInfo(){ Name = "Medium List 2 Accent 5", UiPriority = 66, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo247 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 1 Accent 5", UiPriority = 67, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo248 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 2 Accent 5", UiPriority = 68, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo249 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 3 Accent 5", UiPriority = 69, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo250 = new LatentStyleExceptionInfo(){ Name = "Dark List Accent 5", UiPriority = 70, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo251 = new LatentStyleExceptionInfo(){ Name = "Colorful Shading Accent 5", UiPriority = 71, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo252 = new LatentStyleExceptionInfo(){ Name = "Colorful List Accent 5", UiPriority = 72, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo253 = new LatentStyleExceptionInfo(){ Name = "Colorful Grid Accent 5", UiPriority = 73, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo254 = new LatentStyleExceptionInfo(){ Name = "Light Shading Accent 6", UiPriority = 60, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo255 = new LatentStyleExceptionInfo(){ Name = "Light List Accent 6", UiPriority = 61, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo256 = new LatentStyleExceptionInfo(){ Name = "Light Grid Accent 6", UiPriority = 62, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo257 = new LatentStyleExceptionInfo(){ Name = "Medium Shading 1 Accent 6", UiPriority = 63, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo258 = new LatentStyleExceptionInfo(){ Name = "Medium Shading 2 Accent 6", UiPriority = 64, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo259 = new LatentStyleExceptionInfo(){ Name = "Medium List 1 Accent 6", UiPriority = 65, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo260 = new LatentStyleExceptionInfo(){ Name = "Medium List 2 Accent 6", UiPriority = 66, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo261 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 1 Accent 6", UiPriority = 67, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo262 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 2 Accent 6", UiPriority = 68, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo263 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 3 Accent 6", UiPriority = 69, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo264 = new LatentStyleExceptionInfo(){ Name = "Dark List Accent 6", UiPriority = 70, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo265 = new LatentStyleExceptionInfo(){ Name = "Colorful Shading Accent 6", UiPriority = 71, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo266 = new LatentStyleExceptionInfo(){ Name = "Colorful List Accent 6", UiPriority = 72, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo267 = new LatentStyleExceptionInfo(){ Name = "Colorful Grid Accent 6", UiPriority = 73, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo268 = new LatentStyleExceptionInfo(){ Name = "Subtle Emphasis", UiPriority = 19, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo269 = new LatentStyleExceptionInfo(){ Name = "Intense Emphasis", UiPriority = 21, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo270 = new LatentStyleExceptionInfo(){ Name = "Subtle Reference", UiPriority = 31, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo271 = new LatentStyleExceptionInfo(){ Name = "Intense Reference", UiPriority = 32, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo272 = new LatentStyleExceptionInfo(){ Name = "Book Title", UiPriority = 33, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo273 = new LatentStyleExceptionInfo(){ Name = "Bibliography", UiPriority = 37 };
            LatentStyleExceptionInfo latentStyleExceptionInfo274 = new LatentStyleExceptionInfo(){ Name = "TOC Heading", UiPriority = 39, PrimaryStyle = true };

            latentStyles2.Append(latentStyleExceptionInfo138);
            latentStyles2.Append(latentStyleExceptionInfo139);
            latentStyles2.Append(latentStyleExceptionInfo140);
            latentStyles2.Append(latentStyleExceptionInfo141);
            latentStyles2.Append(latentStyleExceptionInfo142);
            latentStyles2.Append(latentStyleExceptionInfo143);
            latentStyles2.Append(latentStyleExceptionInfo144);
            latentStyles2.Append(latentStyleExceptionInfo145);
            latentStyles2.Append(latentStyleExceptionInfo146);
            latentStyles2.Append(latentStyleExceptionInfo147);
            latentStyles2.Append(latentStyleExceptionInfo148);
            latentStyles2.Append(latentStyleExceptionInfo149);
            latentStyles2.Append(latentStyleExceptionInfo150);
            latentStyles2.Append(latentStyleExceptionInfo151);
            latentStyles2.Append(latentStyleExceptionInfo152);
            latentStyles2.Append(latentStyleExceptionInfo153);
            latentStyles2.Append(latentStyleExceptionInfo154);
            latentStyles2.Append(latentStyleExceptionInfo155);
            latentStyles2.Append(latentStyleExceptionInfo156);
            latentStyles2.Append(latentStyleExceptionInfo157);
            latentStyles2.Append(latentStyleExceptionInfo158);
            latentStyles2.Append(latentStyleExceptionInfo159);
            latentStyles2.Append(latentStyleExceptionInfo160);
            latentStyles2.Append(latentStyleExceptionInfo161);
            latentStyles2.Append(latentStyleExceptionInfo162);
            latentStyles2.Append(latentStyleExceptionInfo163);
            latentStyles2.Append(latentStyleExceptionInfo164);
            latentStyles2.Append(latentStyleExceptionInfo165);
            latentStyles2.Append(latentStyleExceptionInfo166);
            latentStyles2.Append(latentStyleExceptionInfo167);
            latentStyles2.Append(latentStyleExceptionInfo168);
            latentStyles2.Append(latentStyleExceptionInfo169);
            latentStyles2.Append(latentStyleExceptionInfo170);
            latentStyles2.Append(latentStyleExceptionInfo171);
            latentStyles2.Append(latentStyleExceptionInfo172);
            latentStyles2.Append(latentStyleExceptionInfo173);
            latentStyles2.Append(latentStyleExceptionInfo174);
            latentStyles2.Append(latentStyleExceptionInfo175);
            latentStyles2.Append(latentStyleExceptionInfo176);
            latentStyles2.Append(latentStyleExceptionInfo177);
            latentStyles2.Append(latentStyleExceptionInfo178);
            latentStyles2.Append(latentStyleExceptionInfo179);
            latentStyles2.Append(latentStyleExceptionInfo180);
            latentStyles2.Append(latentStyleExceptionInfo181);
            latentStyles2.Append(latentStyleExceptionInfo182);
            latentStyles2.Append(latentStyleExceptionInfo183);
            latentStyles2.Append(latentStyleExceptionInfo184);
            latentStyles2.Append(latentStyleExceptionInfo185);
            latentStyles2.Append(latentStyleExceptionInfo186);
            latentStyles2.Append(latentStyleExceptionInfo187);
            latentStyles2.Append(latentStyleExceptionInfo188);
            latentStyles2.Append(latentStyleExceptionInfo189);
            latentStyles2.Append(latentStyleExceptionInfo190);
            latentStyles2.Append(latentStyleExceptionInfo191);
            latentStyles2.Append(latentStyleExceptionInfo192);
            latentStyles2.Append(latentStyleExceptionInfo193);
            latentStyles2.Append(latentStyleExceptionInfo194);
            latentStyles2.Append(latentStyleExceptionInfo195);
            latentStyles2.Append(latentStyleExceptionInfo196);
            latentStyles2.Append(latentStyleExceptionInfo197);
            latentStyles2.Append(latentStyleExceptionInfo198);
            latentStyles2.Append(latentStyleExceptionInfo199);
            latentStyles2.Append(latentStyleExceptionInfo200);
            latentStyles2.Append(latentStyleExceptionInfo201);
            latentStyles2.Append(latentStyleExceptionInfo202);
            latentStyles2.Append(latentStyleExceptionInfo203);
            latentStyles2.Append(latentStyleExceptionInfo204);
            latentStyles2.Append(latentStyleExceptionInfo205);
            latentStyles2.Append(latentStyleExceptionInfo206);
            latentStyles2.Append(latentStyleExceptionInfo207);
            latentStyles2.Append(latentStyleExceptionInfo208);
            latentStyles2.Append(latentStyleExceptionInfo209);
            latentStyles2.Append(latentStyleExceptionInfo210);
            latentStyles2.Append(latentStyleExceptionInfo211);
            latentStyles2.Append(latentStyleExceptionInfo212);
            latentStyles2.Append(latentStyleExceptionInfo213);
            latentStyles2.Append(latentStyleExceptionInfo214);
            latentStyles2.Append(latentStyleExceptionInfo215);
            latentStyles2.Append(latentStyleExceptionInfo216);
            latentStyles2.Append(latentStyleExceptionInfo217);
            latentStyles2.Append(latentStyleExceptionInfo218);
            latentStyles2.Append(latentStyleExceptionInfo219);
            latentStyles2.Append(latentStyleExceptionInfo220);
            latentStyles2.Append(latentStyleExceptionInfo221);
            latentStyles2.Append(latentStyleExceptionInfo222);
            latentStyles2.Append(latentStyleExceptionInfo223);
            latentStyles2.Append(latentStyleExceptionInfo224);
            latentStyles2.Append(latentStyleExceptionInfo225);
            latentStyles2.Append(latentStyleExceptionInfo226);
            latentStyles2.Append(latentStyleExceptionInfo227);
            latentStyles2.Append(latentStyleExceptionInfo228);
            latentStyles2.Append(latentStyleExceptionInfo229);
            latentStyles2.Append(latentStyleExceptionInfo230);
            latentStyles2.Append(latentStyleExceptionInfo231);
            latentStyles2.Append(latentStyleExceptionInfo232);
            latentStyles2.Append(latentStyleExceptionInfo233);
            latentStyles2.Append(latentStyleExceptionInfo234);
            latentStyles2.Append(latentStyleExceptionInfo235);
            latentStyles2.Append(latentStyleExceptionInfo236);
            latentStyles2.Append(latentStyleExceptionInfo237);
            latentStyles2.Append(latentStyleExceptionInfo238);
            latentStyles2.Append(latentStyleExceptionInfo239);
            latentStyles2.Append(latentStyleExceptionInfo240);
            latentStyles2.Append(latentStyleExceptionInfo241);
            latentStyles2.Append(latentStyleExceptionInfo242);
            latentStyles2.Append(latentStyleExceptionInfo243);
            latentStyles2.Append(latentStyleExceptionInfo244);
            latentStyles2.Append(latentStyleExceptionInfo245);
            latentStyles2.Append(latentStyleExceptionInfo246);
            latentStyles2.Append(latentStyleExceptionInfo247);
            latentStyles2.Append(latentStyleExceptionInfo248);
            latentStyles2.Append(latentStyleExceptionInfo249);
            latentStyles2.Append(latentStyleExceptionInfo250);
            latentStyles2.Append(latentStyleExceptionInfo251);
            latentStyles2.Append(latentStyleExceptionInfo252);
            latentStyles2.Append(latentStyleExceptionInfo253);
            latentStyles2.Append(latentStyleExceptionInfo254);
            latentStyles2.Append(latentStyleExceptionInfo255);
            latentStyles2.Append(latentStyleExceptionInfo256);
            latentStyles2.Append(latentStyleExceptionInfo257);
            latentStyles2.Append(latentStyleExceptionInfo258);
            latentStyles2.Append(latentStyleExceptionInfo259);
            latentStyles2.Append(latentStyleExceptionInfo260);
            latentStyles2.Append(latentStyleExceptionInfo261);
            latentStyles2.Append(latentStyleExceptionInfo262);
            latentStyles2.Append(latentStyleExceptionInfo263);
            latentStyles2.Append(latentStyleExceptionInfo264);
            latentStyles2.Append(latentStyleExceptionInfo265);
            latentStyles2.Append(latentStyleExceptionInfo266);
            latentStyles2.Append(latentStyleExceptionInfo267);
            latentStyles2.Append(latentStyleExceptionInfo268);
            latentStyles2.Append(latentStyleExceptionInfo269);
            latentStyles2.Append(latentStyleExceptionInfo270);
            latentStyles2.Append(latentStyleExceptionInfo271);
            latentStyles2.Append(latentStyleExceptionInfo272);
            latentStyles2.Append(latentStyleExceptionInfo273);
            latentStyles2.Append(latentStyleExceptionInfo274);

            Style style11 = new Style(){ Type = StyleValues.Paragraph, StyleId = "Normal", Default = true };
            StyleName styleName11 = new StyleName(){ Val = "Normal" };
            PrimaryStyle primaryStyle2 = new PrimaryStyle();

            StyleParagraphProperties styleParagraphProperties7 = new StyleParagraphProperties();
            WidowControl widowControl7 = new WidowControl(){ Val = false };
            Justification justification7 = new Justification(){ Val = JustificationValues.Both };

            styleParagraphProperties7.Append(widowControl7);
            styleParagraphProperties7.Append(justification7);

            style11.Append(styleName11);
            style11.Append(primaryStyle2);
            style11.Append(styleParagraphProperties7);

            Style style12 = new Style(){ Type = StyleValues.Character, StyleId = "DefaultParagraphFont", Default = true };
            StyleName styleName12 = new StyleName(){ Val = "Default Paragraph Font" };
            UIPriority uIPriority5 = new UIPriority(){ Val = 1 };
            SemiHidden semiHidden5 = new SemiHidden();
            UnhideWhenUsed unhideWhenUsed4 = new UnhideWhenUsed();

            style12.Append(styleName12);
            style12.Append(uIPriority5);
            style12.Append(semiHidden5);
            style12.Append(unhideWhenUsed4);

            Style style13 = new Style(){ Type = StyleValues.Table, StyleId = "TableNormal", Default = true };
            StyleName styleName13 = new StyleName(){ Val = "Normal Table" };
            UIPriority uIPriority6 = new UIPriority(){ Val = 99 };
            SemiHidden semiHidden6 = new SemiHidden();
            UnhideWhenUsed unhideWhenUsed5 = new UnhideWhenUsed();

            StyleTableProperties styleTableProperties2 = new StyleTableProperties();
            TableIndentation tableIndentation2 = new TableIndentation(){ Width = 0, Type = TableWidthUnitValues.Dxa };

            TableCellMarginDefault tableCellMarginDefault2 = new TableCellMarginDefault();
            TopMargin topMargin2 = new TopMargin(){ Width = "0", Type = TableWidthUnitValues.Dxa };
            TableCellLeftMargin tableCellLeftMargin2 = new TableCellLeftMargin(){ Width = 108, Type = TableWidthValues.Dxa };
            BottomMargin bottomMargin2 = new BottomMargin(){ Width = "0", Type = TableWidthUnitValues.Dxa };
            TableCellRightMargin tableCellRightMargin2 = new TableCellRightMargin(){ Width = 108, Type = TableWidthValues.Dxa };

            tableCellMarginDefault2.Append(topMargin2);
            tableCellMarginDefault2.Append(tableCellLeftMargin2);
            tableCellMarginDefault2.Append(bottomMargin2);
            tableCellMarginDefault2.Append(tableCellRightMargin2);

            styleTableProperties2.Append(tableIndentation2);
            styleTableProperties2.Append(tableCellMarginDefault2);

            style13.Append(styleName13);
            style13.Append(uIPriority6);
            style13.Append(semiHidden6);
            style13.Append(unhideWhenUsed5);
            style13.Append(styleTableProperties2);

            Style style14 = new Style(){ Type = StyleValues.Numbering, StyleId = "NoList", Default = true };
            StyleName styleName14 = new StyleName(){ Val = "No List" };
            UIPriority uIPriority7 = new UIPriority(){ Val = 99 };
            SemiHidden semiHidden7 = new SemiHidden();
            UnhideWhenUsed unhideWhenUsed6 = new UnhideWhenUsed();

            style14.Append(styleName14);
            style14.Append(uIPriority7);
            style14.Append(semiHidden7);
            style14.Append(unhideWhenUsed6);

            Style style15 = new Style(){ Type = StyleValues.Character, StyleId = "PlaceholderText" };
            StyleName styleName15 = new StyleName(){ Val = "Placeholder Text" };
            BasedOn basedOn2 = new BasedOn(){ Val = "DefaultParagraphFont" };
            UIPriority uIPriority8 = new UIPriority(){ Val = 99 };
            SemiHidden semiHidden8 = new SemiHidden();
            Rsid rsid15 = new Rsid(){ Val = "00930812" };

            StyleRunProperties styleRunProperties2 = new StyleRunProperties();
            Color color3 = new Color(){ Val = "808080" };

            styleRunProperties2.Append(color3);

            style15.Append(styleName15);
            style15.Append(basedOn2);
            style15.Append(uIPriority8);
            style15.Append(semiHidden8);
            style15.Append(rsid15);
            style15.Append(styleRunProperties2);

            Style style16 = new Style(){ Type = StyleValues.Paragraph, StyleId = "B207B2DF6D0E4E13956E6616811860CA", CustomStyle = true };
            StyleName styleName16 = new StyleName(){ Val = "B207B2DF6D0E4E13956E6616811860CA" };
            Rsid rsid16 = new Rsid(){ Val = "00930812" };

            StyleParagraphProperties styleParagraphProperties8 = new StyleParagraphProperties();
            WidowControl widowControl8 = new WidowControl(){ Val = false };
            Justification justification8 = new Justification(){ Val = JustificationValues.Both };

            styleParagraphProperties8.Append(widowControl8);
            styleParagraphProperties8.Append(justification8);

            style16.Append(styleName16);
            style16.Append(rsid16);
            style16.Append(styleParagraphProperties8);

            Style style17 = new Style(){ Type = StyleValues.Paragraph, StyleId = "D4883C3CFFC34F409428ADC3628C6570", CustomStyle = true };
            StyleName styleName17 = new StyleName(){ Val = "D4883C3CFFC34F409428ADC3628C6570" };
            Rsid rsid17 = new Rsid(){ Val = "00930812" };

            StyleParagraphProperties styleParagraphProperties9 = new StyleParagraphProperties();
            WidowControl widowControl9 = new WidowControl(){ Val = false };
            Justification justification9 = new Justification(){ Val = JustificationValues.Both };

            styleParagraphProperties9.Append(widowControl9);
            styleParagraphProperties9.Append(justification9);

            style17.Append(styleName17);
            style17.Append(rsid17);
            style17.Append(styleParagraphProperties9);

            Style style18 = new Style(){ Type = StyleValues.Paragraph, StyleId = "133ECC909A29476B8F1E90DE917BAC44", CustomStyle = true };
            StyleName styleName18 = new StyleName(){ Val = "133ECC909A29476B8F1E90DE917BAC44" };
            Rsid rsid18 = new Rsid(){ Val = "00930812" };

            StyleParagraphProperties styleParagraphProperties10 = new StyleParagraphProperties();
            WidowControl widowControl10 = new WidowControl(){ Val = false };
            Justification justification10 = new Justification(){ Val = JustificationValues.Both };

            styleParagraphProperties10.Append(widowControl10);
            styleParagraphProperties10.Append(justification10);

            style18.Append(styleName18);
            style18.Append(rsid18);
            style18.Append(styleParagraphProperties10);

            Style style19 = new Style(){ Type = StyleValues.Paragraph, StyleId = "4B632797D8B1461898B8F461443A20E0", CustomStyle = true };
            StyleName styleName19 = new StyleName(){ Val = "4B632797D8B1461898B8F461443A20E0" };
            Rsid rsid19 = new Rsid(){ Val = "00930812" };

            StyleParagraphProperties styleParagraphProperties11 = new StyleParagraphProperties();
            WidowControl widowControl11 = new WidowControl(){ Val = false };
            Justification justification11 = new Justification(){ Val = JustificationValues.Both };

            styleParagraphProperties11.Append(widowControl11);
            styleParagraphProperties11.Append(justification11);

            style19.Append(styleName19);
            style19.Append(rsid19);
            style19.Append(styleParagraphProperties11);

            Style style20 = new Style(){ Type = StyleValues.Paragraph, StyleId = "8E3192E882304BDA9D0B4E69A021C365", CustomStyle = true };
            StyleName styleName20 = new StyleName(){ Val = "8E3192E882304BDA9D0B4E69A021C365" };
            Rsid rsid20 = new Rsid(){ Val = "00930812" };

            StyleParagraphProperties styleParagraphProperties12 = new StyleParagraphProperties();
            WidowControl widowControl12 = new WidowControl(){ Val = false };
            Justification justification12 = new Justification(){ Val = JustificationValues.Both };

            styleParagraphProperties12.Append(widowControl12);
            styleParagraphProperties12.Append(justification12);

            style20.Append(styleName20);
            style20.Append(rsid20);
            style20.Append(styleParagraphProperties12);

            styles2.Append(docDefaults2);
            styles2.Append(latentStyles2);
            styles2.Append(style11);
            styles2.Append(style12);
            styles2.Append(style13);
            styles2.Append(style14);
            styles2.Append(style15);
            styles2.Append(style16);
            styles2.Append(style17);
            styles2.Append(style18);
            styles2.Append(style19);
            styles2.Append(style20);

            styleDefinitionsPart1.Styles = styles2;
        }

        // Generates content of fontTablePart1.
        private void GenerateFontTablePart1Content(FontTablePart fontTablePart1)
        {
            Fonts fonts1 = new Fonts(){ MCAttributes = new MarkupCompatibilityAttributes(){ Ignorable = "w14 w15" }  };
            fonts1.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            fonts1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            fonts1.AddNamespaceDeclaration("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main");
            fonts1.AddNamespaceDeclaration("w14", "http://schemas.microsoft.com/office/word/2010/wordml");
            fonts1.AddNamespaceDeclaration("w15", "http://schemas.microsoft.com/office/word/2010/11/wordml");

            Font font1 = new Font(){ Name = "Century" };
            Panose1Number panose1Number1 = new Panose1Number(){ Val = "02040604050505020304" };
            FontCharSet fontCharSet1 = new FontCharSet(){ Val = "00" };
            FontFamily fontFamily1 = new FontFamily(){ Val = FontFamilyValues.Roman };
            Pitch pitch1 = new Pitch(){ Val = FontPitchValues.Variable };
            FontSignature fontSignature1 = new FontSignature(){ UnicodeSignature0 = "00000287", UnicodeSignature1 = "00000000", UnicodeSignature2 = "00000000", UnicodeSignature3 = "00000000", CodePageSignature0 = "0000009F", CodePageSignature1 = "00000000" };

            font1.Append(panose1Number1);
            font1.Append(fontCharSet1);
            font1.Append(fontFamily1);
            font1.Append(pitch1);
            font1.Append(fontSignature1);

            Font font2 = new Font(){ Name = "ＭＳ 明朝" };
            AltName altName1 = new AltName(){ Val = "MS Mincho" };
            Panose1Number panose1Number2 = new Panose1Number(){ Val = "02020609040205080304" };
            FontCharSet fontCharSet2 = new FontCharSet(){ Val = "80" };
            FontFamily fontFamily2 = new FontFamily(){ Val = FontFamilyValues.Roman };
            Pitch pitch2 = new Pitch(){ Val = FontPitchValues.Fixed };
            FontSignature fontSignature2 = new FontSignature(){ UnicodeSignature0 = "E00002FF", UnicodeSignature1 = "6AC7FDFB", UnicodeSignature2 = "00000012", UnicodeSignature3 = "00000000", CodePageSignature0 = "0002009F", CodePageSignature1 = "00000000" };

            font2.Append(altName1);
            font2.Append(panose1Number2);
            font2.Append(fontCharSet2);
            font2.Append(fontFamily2);
            font2.Append(pitch2);
            font2.Append(fontSignature2);

            Font font3 = new Font(){ Name = "Times New Roman" };
            Panose1Number panose1Number3 = new Panose1Number(){ Val = "02020603050405020304" };
            FontCharSet fontCharSet3 = new FontCharSet(){ Val = "00" };
            FontFamily fontFamily3 = new FontFamily(){ Val = FontFamilyValues.Roman };
            Pitch pitch3 = new Pitch(){ Val = FontPitchValues.Variable };
            FontSignature fontSignature3 = new FontSignature(){ UnicodeSignature0 = "E0002AFF", UnicodeSignature1 = "C0007841", UnicodeSignature2 = "00000009", UnicodeSignature3 = "00000000", CodePageSignature0 = "000001FF", CodePageSignature1 = "00000000" };

            font3.Append(panose1Number3);
            font3.Append(fontCharSet3);
            font3.Append(fontFamily3);
            font3.Append(pitch3);
            font3.Append(fontSignature3);

            Font font4 = new Font(){ Name = "ＭＳ ゴシック" };
            AltName altName2 = new AltName(){ Val = "MS Gothic" };
            Panose1Number panose1Number4 = new Panose1Number(){ Val = "020B0609070205080204" };
            FontCharSet fontCharSet4 = new FontCharSet(){ Val = "80" };
            FontFamily fontFamily4 = new FontFamily(){ Val = FontFamilyValues.Modern };
            Pitch pitch4 = new Pitch(){ Val = FontPitchValues.Fixed };
            FontSignature fontSignature4 = new FontSignature(){ UnicodeSignature0 = "E00002FF", UnicodeSignature1 = "6AC7FDFB", UnicodeSignature2 = "00000012", UnicodeSignature3 = "00000000", CodePageSignature0 = "0002009F", CodePageSignature1 = "00000000" };

            font4.Append(altName2);
            font4.Append(panose1Number4);
            font4.Append(fontCharSet4);
            font4.Append(fontFamily4);
            font4.Append(pitch4);
            font4.Append(fontSignature4);

            Font font5 = new Font(){ Name = "Arial" };
            Panose1Number panose1Number5 = new Panose1Number(){ Val = "020B0604020202020204" };
            FontCharSet fontCharSet5 = new FontCharSet(){ Val = "00" };
            FontFamily fontFamily5 = new FontFamily(){ Val = FontFamilyValues.Swiss };
            Pitch pitch5 = new Pitch(){ Val = FontPitchValues.Variable };
            FontSignature fontSignature5 = new FontSignature(){ UnicodeSignature0 = "E0002AFF", UnicodeSignature1 = "C0007843", UnicodeSignature2 = "00000009", UnicodeSignature3 = "00000000", CodePageSignature0 = "000001FF", CodePageSignature1 = "00000000" };

            font5.Append(panose1Number5);
            font5.Append(fontCharSet5);
            font5.Append(fontFamily5);
            font5.Append(pitch5);
            font5.Append(fontSignature5);

            fonts1.Append(font1);
            fonts1.Append(font2);
            fonts1.Append(font3);
            fonts1.Append(font4);
            fonts1.Append(font5);

            fontTablePart1.Fonts = fonts1;
        }

        // Generates content of webSettingsPart1.
        private void GenerateWebSettingsPart1Content(WebSettingsPart webSettingsPart1)
        {
            WebSettings webSettings1 = new WebSettings(){ MCAttributes = new MarkupCompatibilityAttributes(){ Ignorable = "w14 w15" }  };
            webSettings1.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            webSettings1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            webSettings1.AddNamespaceDeclaration("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main");
            webSettings1.AddNamespaceDeclaration("w14", "http://schemas.microsoft.com/office/word/2010/wordml");
            webSettings1.AddNamespaceDeclaration("w15", "http://schemas.microsoft.com/office/word/2010/11/wordml");
            OptimizeForBrowser optimizeForBrowser1 = new OptimizeForBrowser();
            AllowPNG allowPNG1 = new AllowPNG();

            webSettings1.Append(optimizeForBrowser1);
            webSettings1.Append(allowPNG1);

            webSettingsPart1.WebSettings = webSettings1;
        }

        // Generates content of documentSettingsPart2.
        private void GenerateDocumentSettingsPart2Content(DocumentSettingsPart documentSettingsPart2)
        {
            Settings settings2 = new Settings(){ MCAttributes = new MarkupCompatibilityAttributes(){ Ignorable = "w14 w15" }  };
            settings2.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            settings2.AddNamespaceDeclaration("o", "urn:schemas-microsoft-com:office:office");
            settings2.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            settings2.AddNamespaceDeclaration("m", "http://schemas.openxmlformats.org/officeDocument/2006/math");
            settings2.AddNamespaceDeclaration("v", "urn:schemas-microsoft-com:vml");
            settings2.AddNamespaceDeclaration("w10", "urn:schemas-microsoft-com:office:word");
            settings2.AddNamespaceDeclaration("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main");
            settings2.AddNamespaceDeclaration("w14", "http://schemas.microsoft.com/office/word/2010/wordml");
            settings2.AddNamespaceDeclaration("w15", "http://schemas.microsoft.com/office/word/2010/11/wordml");
            settings2.AddNamespaceDeclaration("sl", "http://schemas.openxmlformats.org/schemaLibrary/2006/main");
            Zoom zoom1 = new Zoom(){ Percent = "100" };
            BordersDoNotSurroundHeader bordersDoNotSurroundHeader2 = new BordersDoNotSurroundHeader();
            BordersDoNotSurroundFooter bordersDoNotSurroundFooter2 = new BordersDoNotSurroundFooter();
            ProofState proofState1 = new ProofState(){ Spelling = ProofingStateValues.Clean, Grammar = ProofingStateValues.Clean };
            DefaultTabStop defaultTabStop2 = new DefaultTabStop(){ Val = 840 };
            DisplayHorizontalDrawingGrid displayHorizontalDrawingGrid2 = new DisplayHorizontalDrawingGrid(){ Val = 0 };
            DisplayVerticalDrawingGrid displayVerticalDrawingGrid2 = new DisplayVerticalDrawingGrid(){ Val = 2 };
            CharacterSpacingControl characterSpacingControl2 = new CharacterSpacingControl(){ Val = CharacterSpacingValues.CompressPunctuation };

            HeaderShapeDefaults headerShapeDefaults1 = new HeaderShapeDefaults();

            Ovml.ShapeDefaults shapeDefaults1 = new Ovml.ShapeDefaults(){ Extension = V.ExtensionHandlingBehaviorValues.Edit, MaxShapeId = 2049 };
            V.TextBox textBox1 = new V.TextBox(){ Inset = "5.85pt,.7pt,5.85pt,.7pt" };

            shapeDefaults1.Append(textBox1);

            headerShapeDefaults1.Append(shapeDefaults1);

            FootnoteDocumentWideProperties footnoteDocumentWideProperties1 = new FootnoteDocumentWideProperties();
            FootnoteSpecialReference footnoteSpecialReference1 = new FootnoteSpecialReference(){ Id = -1 };
            FootnoteSpecialReference footnoteSpecialReference2 = new FootnoteSpecialReference(){ Id = 0 };

            footnoteDocumentWideProperties1.Append(footnoteSpecialReference1);
            footnoteDocumentWideProperties1.Append(footnoteSpecialReference2);

            EndnoteDocumentWideProperties endnoteDocumentWideProperties1 = new EndnoteDocumentWideProperties();
            EndnoteSpecialReference endnoteSpecialReference1 = new EndnoteSpecialReference(){ Id = -1 };
            EndnoteSpecialReference endnoteSpecialReference2 = new EndnoteSpecialReference(){ Id = 0 };

            endnoteDocumentWideProperties1.Append(endnoteSpecialReference1);
            endnoteDocumentWideProperties1.Append(endnoteSpecialReference2);

            Compatibility compatibility2 = new Compatibility();
            SpaceForUnderline spaceForUnderline2 = new SpaceForUnderline();
            BalanceSingleByteDoubleByteWidth balanceSingleByteDoubleByteWidth2 = new BalanceSingleByteDoubleByteWidth();
            DoNotLeaveBackslashAlone doNotLeaveBackslashAlone2 = new DoNotLeaveBackslashAlone();
            UnderlineTrailingSpaces underlineTrailingSpaces2 = new UnderlineTrailingSpaces();
            DoNotExpandShiftReturn doNotExpandShiftReturn2 = new DoNotExpandShiftReturn();
            AdjustLineHeightInTable adjustLineHeightInTable2 = new AdjustLineHeightInTable();
            UseFarEastLayout useFarEastLayout2 = new UseFarEastLayout();
            CompatibilitySetting compatibilitySetting6 = new CompatibilitySetting(){ Name = CompatSettingNameValues.CompatibilityMode, Uri = "http://schemas.microsoft.com/office/word", Val = "15" };
            CompatibilitySetting compatibilitySetting7 = new CompatibilitySetting(){ Name = CompatSettingNameValues.OverrideTableStyleFontSizeAndJustification, Uri = "http://schemas.microsoft.com/office/word", Val = "1" };
            CompatibilitySetting compatibilitySetting8 = new CompatibilitySetting(){ Name = CompatSettingNameValues.EnableOpenTypeFeatures, Uri = "http://schemas.microsoft.com/office/word", Val = "1" };
            CompatibilitySetting compatibilitySetting9 = new CompatibilitySetting(){ Name = CompatSettingNameValues.DoNotFlipMirrorIndents, Uri = "http://schemas.microsoft.com/office/word", Val = "1" };
            CompatibilitySetting compatibilitySetting10 = new CompatibilitySetting(){ Name = CompatSettingNameValues.DifferentiateMultirowTableHeaders, Uri = "http://schemas.microsoft.com/office/word", Val = "1" };

            compatibility2.Append(spaceForUnderline2);
            compatibility2.Append(balanceSingleByteDoubleByteWidth2);
            compatibility2.Append(doNotLeaveBackslashAlone2);
            compatibility2.Append(underlineTrailingSpaces2);
            compatibility2.Append(doNotExpandShiftReturn2);
            compatibility2.Append(adjustLineHeightInTable2);
            compatibility2.Append(useFarEastLayout2);
            compatibility2.Append(compatibilitySetting6);
            compatibility2.Append(compatibilitySetting7);
            compatibility2.Append(compatibilitySetting8);
            compatibility2.Append(compatibilitySetting9);
            compatibility2.Append(compatibilitySetting10);

            Rsids rsids2 = new Rsids();
            RsidRoot rsidRoot2 = new RsidRoot(){ Val = "000010BA" };
            Rsid rsid21 = new Rsid(){ Val = "000010BA" };
            Rsid rsid22 = new Rsid(){ Val = "000C1702" };
            Rsid rsid23 = new Rsid(){ Val = "00221A5E" };
            Rsid rsid24 = new Rsid(){ Val = "00535C5E" };
            Rsid rsid25 = new Rsid(){ Val = "005A792B" };
            Rsid rsid26 = new Rsid(){ Val = "006D4DFB" };
            Rsid rsid27 = new Rsid(){ Val = "009651D6" };
            Rsid rsid28 = new Rsid(){ Val = "00A215C1" };
            Rsid rsid29 = new Rsid(){ Val = "00CC7467" };
            Rsid rsid30 = new Rsid(){ Val = "00DC649D" };
            Rsid rsid31 = new Rsid(){ Val = "00E86739" };
            Rsid rsid32 = new Rsid(){ Val = "00E90381" };
            Rsid rsid33 = new Rsid(){ Val = "00E930A2" };

            rsids2.Append(rsidRoot2);
            rsids2.Append(rsid21);
            rsids2.Append(rsid22);
            rsids2.Append(rsid23);
            rsids2.Append(rsid24);
            rsids2.Append(rsid25);
            rsids2.Append(rsid26);
            rsids2.Append(rsid27);
            rsids2.Append(rsid28);
            rsids2.Append(rsid29);
            rsids2.Append(rsid30);
            rsids2.Append(rsid31);
            rsids2.Append(rsid32);
            rsids2.Append(rsid33);

            M.MathProperties mathProperties2 = new M.MathProperties();
            M.MathFont mathFont2 = new M.MathFont(){ Val = "Cambria Math" };
            M.BreakBinary breakBinary2 = new M.BreakBinary(){ Val = M.BreakBinaryOperatorValues.Before };
            M.BreakBinarySubtraction breakBinarySubtraction2 = new M.BreakBinarySubtraction(){ Val = M.BreakBinarySubtractionValues.MinusMinus };
            M.SmallFraction smallFraction2 = new M.SmallFraction(){ Val = M.BooleanValues.Zero };
            M.DisplayDefaults displayDefaults2 = new M.DisplayDefaults();
            M.LeftMargin leftMargin2 = new M.LeftMargin(){ Val = (UInt32Value)0U };
            M.RightMargin rightMargin2 = new M.RightMargin(){ Val = (UInt32Value)0U };
            M.DefaultJustification defaultJustification2 = new M.DefaultJustification(){ Val = M.JustificationValues.CenterGroup };
            M.WrapIndent wrapIndent2 = new M.WrapIndent(){ Val = (UInt32Value)1440U };
            M.IntegralLimitLocation integralLimitLocation2 = new M.IntegralLimitLocation(){ Val = M.LimitLocationValues.SubscriptSuperscript };
            M.NaryLimitLocation naryLimitLocation2 = new M.NaryLimitLocation(){ Val = M.LimitLocationValues.UnderOver };

            mathProperties2.Append(mathFont2);
            mathProperties2.Append(breakBinary2);
            mathProperties2.Append(breakBinarySubtraction2);
            mathProperties2.Append(smallFraction2);
            mathProperties2.Append(displayDefaults2);
            mathProperties2.Append(leftMargin2);
            mathProperties2.Append(rightMargin2);
            mathProperties2.Append(defaultJustification2);
            mathProperties2.Append(wrapIndent2);
            mathProperties2.Append(integralLimitLocation2);
            mathProperties2.Append(naryLimitLocation2);
            ThemeFontLanguages themeFontLanguages2 = new ThemeFontLanguages(){ Val = "en-US", EastAsia = "ja-JP" };
            ColorSchemeMapping colorSchemeMapping2 = new ColorSchemeMapping(){ Background1 = ColorSchemeIndexValues.Light1, Text1 = ColorSchemeIndexValues.Dark1, Background2 = ColorSchemeIndexValues.Light2, Text2 = ColorSchemeIndexValues.Dark2, Accent1 = ColorSchemeIndexValues.Accent1, Accent2 = ColorSchemeIndexValues.Accent2, Accent3 = ColorSchemeIndexValues.Accent3, Accent4 = ColorSchemeIndexValues.Accent4, Accent5 = ColorSchemeIndexValues.Accent5, Accent6 = ColorSchemeIndexValues.Accent6, Hyperlink = ColorSchemeIndexValues.Hyperlink, FollowedHyperlink = ColorSchemeIndexValues.FollowedHyperlink };

            ShapeDefaults shapeDefaults2 = new ShapeDefaults();

            Ovml.ShapeDefaults shapeDefaults3 = new Ovml.ShapeDefaults(){ Extension = V.ExtensionHandlingBehaviorValues.Edit, MaxShapeId = 2049 };
            V.TextBox textBox2 = new V.TextBox(){ Inset = "5.85pt,.7pt,5.85pt,.7pt" };

            shapeDefaults3.Append(textBox2);

            Ovml.ShapeLayout shapeLayout1 = new Ovml.ShapeLayout(){ Extension = V.ExtensionHandlingBehaviorValues.Edit };
            Ovml.ShapeIdMap shapeIdMap1 = new Ovml.ShapeIdMap(){ Extension = V.ExtensionHandlingBehaviorValues.Edit, Data = "1" };

            shapeLayout1.Append(shapeIdMap1);

            shapeDefaults2.Append(shapeDefaults3);
            shapeDefaults2.Append(shapeLayout1);
            DecimalSymbol decimalSymbol2 = new DecimalSymbol(){ Val = "." };
            ListSeparator listSeparator2 = new ListSeparator(){ Val = "," };
            W15.ChartTrackingRefBased chartTrackingRefBased2 = new W15.ChartTrackingRefBased();
            W15.PersistentDocumentId persistentDocumentId1 = new W15.PersistentDocumentId(){ Val = "{855411F9-778F-4476-A693-CE4F6511E7CE}" };

            settings2.Append(zoom1);
            settings2.Append(bordersDoNotSurroundHeader2);
            settings2.Append(bordersDoNotSurroundFooter2);
            settings2.Append(proofState1);
            settings2.Append(defaultTabStop2);
            settings2.Append(displayHorizontalDrawingGrid2);
            settings2.Append(displayVerticalDrawingGrid2);
            settings2.Append(characterSpacingControl2);
            settings2.Append(headerShapeDefaults1);
            settings2.Append(footnoteDocumentWideProperties1);
            settings2.Append(endnoteDocumentWideProperties1);
            settings2.Append(compatibility2);
            settings2.Append(rsids2);
            settings2.Append(mathProperties2);
            settings2.Append(themeFontLanguages2);
            settings2.Append(colorSchemeMapping2);
            settings2.Append(shapeDefaults2);
            settings2.Append(decimalSymbol2);
            settings2.Append(listSeparator2);
            settings2.Append(chartTrackingRefBased2);
            settings2.Append(persistentDocumentId1);

            documentSettingsPart2.Settings = settings2;
        }

        // Generates content of fontTablePart2.
        private void GenerateFontTablePart2Content(FontTablePart fontTablePart2)
        {
            Fonts fonts2 = new Fonts(){ MCAttributes = new MarkupCompatibilityAttributes(){ Ignorable = "w14 w15" }  };
            fonts2.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            fonts2.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            fonts2.AddNamespaceDeclaration("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main");
            fonts2.AddNamespaceDeclaration("w14", "http://schemas.microsoft.com/office/word/2010/wordml");
            fonts2.AddNamespaceDeclaration("w15", "http://schemas.microsoft.com/office/word/2010/11/wordml");

            Font font6 = new Font(){ Name = "Century" };
            Panose1Number panose1Number6 = new Panose1Number(){ Val = "02040604050505020304" };
            FontCharSet fontCharSet6 = new FontCharSet(){ Val = "00" };
            FontFamily fontFamily6 = new FontFamily(){ Val = FontFamilyValues.Roman };
            Pitch pitch6 = new Pitch(){ Val = FontPitchValues.Variable };
            FontSignature fontSignature6 = new FontSignature(){ UnicodeSignature0 = "00000287", UnicodeSignature1 = "00000000", UnicodeSignature2 = "00000000", UnicodeSignature3 = "00000000", CodePageSignature0 = "0000009F", CodePageSignature1 = "00000000" };

            font6.Append(panose1Number6);
            font6.Append(fontCharSet6);
            font6.Append(fontFamily6);
            font6.Append(pitch6);
            font6.Append(fontSignature6);

            Font font7 = new Font(){ Name = "ＭＳ 明朝" };
            AltName altName3 = new AltName(){ Val = "MS Mincho" };
            Panose1Number panose1Number7 = new Panose1Number(){ Val = "02020609040205080304" };
            FontCharSet fontCharSet7 = new FontCharSet(){ Val = "80" };
            FontFamily fontFamily7 = new FontFamily(){ Val = FontFamilyValues.Roman };
            Pitch pitch7 = new Pitch(){ Val = FontPitchValues.Fixed };
            FontSignature fontSignature7 = new FontSignature(){ UnicodeSignature0 = "E00002FF", UnicodeSignature1 = "6AC7FDFB", UnicodeSignature2 = "00000012", UnicodeSignature3 = "00000000", CodePageSignature0 = "0002009F", CodePageSignature1 = "00000000" };

            font7.Append(altName3);
            font7.Append(panose1Number7);
            font7.Append(fontCharSet7);
            font7.Append(fontFamily7);
            font7.Append(pitch7);
            font7.Append(fontSignature7);

            Font font8 = new Font(){ Name = "Times New Roman" };
            Panose1Number panose1Number8 = new Panose1Number(){ Val = "02020603050405020304" };
            FontCharSet fontCharSet8 = new FontCharSet(){ Val = "00" };
            FontFamily fontFamily8 = new FontFamily(){ Val = FontFamilyValues.Roman };
            Pitch pitch8 = new Pitch(){ Val = FontPitchValues.Variable };
            FontSignature fontSignature8 = new FontSignature(){ UnicodeSignature0 = "E0002AFF", UnicodeSignature1 = "C0007841", UnicodeSignature2 = "00000009", UnicodeSignature3 = "00000000", CodePageSignature0 = "000001FF", CodePageSignature1 = "00000000" };

            font8.Append(panose1Number8);
            font8.Append(fontCharSet8);
            font8.Append(fontFamily8);
            font8.Append(pitch8);
            font8.Append(fontSignature8);

            Font font9 = new Font(){ Name = "ＭＳ ゴシック" };
            AltName altName4 = new AltName(){ Val = "MS Gothic" };
            Panose1Number panose1Number9 = new Panose1Number(){ Val = "020B0609070205080204" };
            FontCharSet fontCharSet9 = new FontCharSet(){ Val = "80" };
            FontFamily fontFamily9 = new FontFamily(){ Val = FontFamilyValues.Modern };
            Pitch pitch9 = new Pitch(){ Val = FontPitchValues.Fixed };
            FontSignature fontSignature9 = new FontSignature(){ UnicodeSignature0 = "E00002FF", UnicodeSignature1 = "6AC7FDFB", UnicodeSignature2 = "00000012", UnicodeSignature3 = "00000000", CodePageSignature0 = "0002009F", CodePageSignature1 = "00000000" };

            font9.Append(altName4);
            font9.Append(panose1Number9);
            font9.Append(fontCharSet9);
            font9.Append(fontFamily9);
            font9.Append(pitch9);
            font9.Append(fontSignature9);

            Font font10 = new Font(){ Name = "Arial" };
            Panose1Number panose1Number10 = new Panose1Number(){ Val = "020B0604020202020204" };
            FontCharSet fontCharSet10 = new FontCharSet(){ Val = "00" };
            FontFamily fontFamily10 = new FontFamily(){ Val = FontFamilyValues.Swiss };
            Pitch pitch10 = new Pitch(){ Val = FontPitchValues.Variable };
            FontSignature fontSignature10 = new FontSignature(){ UnicodeSignature0 = "E0002AFF", UnicodeSignature1 = "C0007843", UnicodeSignature2 = "00000009", UnicodeSignature3 = "00000000", CodePageSignature0 = "000001FF", CodePageSignature1 = "00000000" };

            font10.Append(panose1Number10);
            font10.Append(fontCharSet10);
            font10.Append(fontFamily10);
            font10.Append(pitch10);
            font10.Append(fontSignature10);

            fonts2.Append(font6);
            fonts2.Append(font7);
            fonts2.Append(font8);
            fonts2.Append(font9);
            fonts2.Append(font10);

            fontTablePart2.Fonts = fonts2;
        }

        // Generates content of stylesWithEffectsPart2.
        private void GenerateStylesWithEffectsPart2Content(StylesWithEffectsPart stylesWithEffectsPart2)
        {
            Styles styles3 = new Styles(){ MCAttributes = new MarkupCompatibilityAttributes(){ Ignorable = "w14 w15 wp14" }  };
            styles3.AddNamespaceDeclaration("wpc", "http://schemas.microsoft.com/office/word/2010/wordprocessingCanvas");
            styles3.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            styles3.AddNamespaceDeclaration("o", "urn:schemas-microsoft-com:office:office");
            styles3.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            styles3.AddNamespaceDeclaration("m", "http://schemas.openxmlformats.org/officeDocument/2006/math");
            styles3.AddNamespaceDeclaration("v", "urn:schemas-microsoft-com:vml");
            styles3.AddNamespaceDeclaration("wp14", "http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing");
            styles3.AddNamespaceDeclaration("wp", "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing");
            styles3.AddNamespaceDeclaration("w10", "urn:schemas-microsoft-com:office:word");
            styles3.AddNamespaceDeclaration("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main");
            styles3.AddNamespaceDeclaration("w14", "http://schemas.microsoft.com/office/word/2010/wordml");
            styles3.AddNamespaceDeclaration("w15", "http://schemas.microsoft.com/office/word/2010/11/wordml");
            styles3.AddNamespaceDeclaration("wpg", "http://schemas.microsoft.com/office/word/2010/wordprocessingGroup");
            styles3.AddNamespaceDeclaration("wpi", "http://schemas.microsoft.com/office/word/2010/wordprocessingInk");
            styles3.AddNamespaceDeclaration("wne", "http://schemas.microsoft.com/office/word/2006/wordml");
            styles3.AddNamespaceDeclaration("wps", "http://schemas.microsoft.com/office/word/2010/wordprocessingShape");

            DocDefaults docDefaults3 = new DocDefaults();

            RunPropertiesDefault runPropertiesDefault3 = new RunPropertiesDefault();

            RunPropertiesBaseStyle runPropertiesBaseStyle3 = new RunPropertiesBaseStyle();
            RunFonts runFonts35 = new RunFonts(){ AsciiTheme = ThemeFontValues.MinorHighAnsi, HighAnsiTheme = ThemeFontValues.MinorHighAnsi, EastAsiaTheme = ThemeFontValues.MinorEastAsia, ComplexScriptTheme = ThemeFontValues.MinorBidi };
            Kern kern17 = new Kern(){ Val = (UInt32Value)2U };
            FontSize fontSize3 = new FontSize(){ Val = "21" };
            FontSizeComplexScript fontSizeComplexScript3 = new FontSizeComplexScript(){ Val = "22" };
            Languages languages3 = new Languages(){ Val = "en-US", EastAsia = "ja-JP", Bidi = "ar-SA" };

            runPropertiesBaseStyle3.Append(runFonts35);
            runPropertiesBaseStyle3.Append(kern17);
            runPropertiesBaseStyle3.Append(fontSize3);
            runPropertiesBaseStyle3.Append(fontSizeComplexScript3);
            runPropertiesBaseStyle3.Append(languages3);

            runPropertiesDefault3.Append(runPropertiesBaseStyle3);
            ParagraphPropertiesDefault paragraphPropertiesDefault3 = new ParagraphPropertiesDefault();

            docDefaults3.Append(runPropertiesDefault3);
            docDefaults3.Append(paragraphPropertiesDefault3);

            LatentStyles latentStyles3 = new LatentStyles(){ DefaultLockedState = false, DefaultUiPriority = 99, DefaultSemiHidden = true, DefaultUnhideWhenUsed = true, DefaultPrimaryStyle = false, Count = 267 };
            LatentStyleExceptionInfo latentStyleExceptionInfo275 = new LatentStyleExceptionInfo(){ Name = "Normal", UiPriority = 0, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo276 = new LatentStyleExceptionInfo(){ Name = "heading 1", UiPriority = 9, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo277 = new LatentStyleExceptionInfo(){ Name = "heading 2", UiPriority = 9, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo278 = new LatentStyleExceptionInfo(){ Name = "heading 3", UiPriority = 9, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo279 = new LatentStyleExceptionInfo(){ Name = "heading 4", UiPriority = 9, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo280 = new LatentStyleExceptionInfo(){ Name = "heading 5", UiPriority = 9, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo281 = new LatentStyleExceptionInfo(){ Name = "heading 6", UiPriority = 9, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo282 = new LatentStyleExceptionInfo(){ Name = "heading 7", UiPriority = 9, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo283 = new LatentStyleExceptionInfo(){ Name = "heading 8", UiPriority = 9, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo284 = new LatentStyleExceptionInfo(){ Name = "heading 9", UiPriority = 9, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo285 = new LatentStyleExceptionInfo(){ Name = "toc 1", UiPriority = 39 };
            LatentStyleExceptionInfo latentStyleExceptionInfo286 = new LatentStyleExceptionInfo(){ Name = "toc 2", UiPriority = 39 };
            LatentStyleExceptionInfo latentStyleExceptionInfo287 = new LatentStyleExceptionInfo(){ Name = "toc 3", UiPriority = 39 };
            LatentStyleExceptionInfo latentStyleExceptionInfo288 = new LatentStyleExceptionInfo(){ Name = "toc 4", UiPriority = 39 };
            LatentStyleExceptionInfo latentStyleExceptionInfo289 = new LatentStyleExceptionInfo(){ Name = "toc 5", UiPriority = 39 };
            LatentStyleExceptionInfo latentStyleExceptionInfo290 = new LatentStyleExceptionInfo(){ Name = "toc 6", UiPriority = 39 };
            LatentStyleExceptionInfo latentStyleExceptionInfo291 = new LatentStyleExceptionInfo(){ Name = "toc 7", UiPriority = 39 };
            LatentStyleExceptionInfo latentStyleExceptionInfo292 = new LatentStyleExceptionInfo(){ Name = "toc 8", UiPriority = 39 };
            LatentStyleExceptionInfo latentStyleExceptionInfo293 = new LatentStyleExceptionInfo(){ Name = "toc 9", UiPriority = 39 };
            LatentStyleExceptionInfo latentStyleExceptionInfo294 = new LatentStyleExceptionInfo(){ Name = "caption", UiPriority = 35, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo295 = new LatentStyleExceptionInfo(){ Name = "Title", UiPriority = 10, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo296 = new LatentStyleExceptionInfo(){ Name = "Default Paragraph Font", UiPriority = 1 };
            LatentStyleExceptionInfo latentStyleExceptionInfo297 = new LatentStyleExceptionInfo(){ Name = "Subtitle", UiPriority = 11, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo298 = new LatentStyleExceptionInfo(){ Name = "Strong", UiPriority = 22, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo299 = new LatentStyleExceptionInfo(){ Name = "Emphasis", UiPriority = 20, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo300 = new LatentStyleExceptionInfo(){ Name = "Table Grid", UiPriority = 59, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo301 = new LatentStyleExceptionInfo(){ Name = "Placeholder Text", UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo302 = new LatentStyleExceptionInfo(){ Name = "No Spacing", UiPriority = 36, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo303 = new LatentStyleExceptionInfo(){ Name = "Light Shading", UiPriority = 60, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo304 = new LatentStyleExceptionInfo(){ Name = "Light List", UiPriority = 61, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo305 = new LatentStyleExceptionInfo(){ Name = "Light Grid", UiPriority = 62, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo306 = new LatentStyleExceptionInfo(){ Name = "Medium Shading 1", UiPriority = 63, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo307 = new LatentStyleExceptionInfo(){ Name = "Medium Shading 2", UiPriority = 64, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo308 = new LatentStyleExceptionInfo(){ Name = "Medium List 1", UiPriority = 65, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo309 = new LatentStyleExceptionInfo(){ Name = "Medium List 2", UiPriority = 66, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo310 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 1", UiPriority = 67, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo311 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 2", UiPriority = 68, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo312 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 3", UiPriority = 69, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo313 = new LatentStyleExceptionInfo(){ Name = "Dark List", UiPriority = 70, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo314 = new LatentStyleExceptionInfo(){ Name = "Colorful Shading", UiPriority = 71, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo315 = new LatentStyleExceptionInfo(){ Name = "Colorful List", UiPriority = 72, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo316 = new LatentStyleExceptionInfo(){ Name = "Colorful Grid", UiPriority = 73, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo317 = new LatentStyleExceptionInfo(){ Name = "Light Shading Accent 1", UiPriority = 60, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo318 = new LatentStyleExceptionInfo(){ Name = "Light List Accent 1", UiPriority = 61, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo319 = new LatentStyleExceptionInfo(){ Name = "Light Grid Accent 1", UiPriority = 62, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo320 = new LatentStyleExceptionInfo(){ Name = "Medium Shading 1 Accent 1", UiPriority = 63, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo321 = new LatentStyleExceptionInfo(){ Name = "Medium Shading 2 Accent 1", UiPriority = 64, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo322 = new LatentStyleExceptionInfo(){ Name = "Medium List 1 Accent 1", UiPriority = 65, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo323 = new LatentStyleExceptionInfo(){ Name = "Revision", UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo324 = new LatentStyleExceptionInfo(){ Name = "List Paragraph", UiPriority = 34, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo325 = new LatentStyleExceptionInfo(){ Name = "Quote", UiPriority = 29, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo326 = new LatentStyleExceptionInfo(){ Name = "Intense Quote", UiPriority = 30, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo327 = new LatentStyleExceptionInfo(){ Name = "Medium List 2 Accent 1", UiPriority = 66, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo328 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 1 Accent 1", UiPriority = 67, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo329 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 2 Accent 1", UiPriority = 68, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo330 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 3 Accent 1", UiPriority = 69, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo331 = new LatentStyleExceptionInfo(){ Name = "Dark List Accent 1", UiPriority = 70, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo332 = new LatentStyleExceptionInfo(){ Name = "Colorful Shading Accent 1", UiPriority = 71, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo333 = new LatentStyleExceptionInfo(){ Name = "Colorful List Accent 1", UiPriority = 72, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo334 = new LatentStyleExceptionInfo(){ Name = "Colorful Grid Accent 1", UiPriority = 73, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo335 = new LatentStyleExceptionInfo(){ Name = "Light Shading Accent 2", UiPriority = 60, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo336 = new LatentStyleExceptionInfo(){ Name = "Light List Accent 2", UiPriority = 61, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo337 = new LatentStyleExceptionInfo(){ Name = "Light Grid Accent 2", UiPriority = 62, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo338 = new LatentStyleExceptionInfo(){ Name = "Medium Shading 1 Accent 2", UiPriority = 63, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo339 = new LatentStyleExceptionInfo(){ Name = "Medium Shading 2 Accent 2", UiPriority = 64, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo340 = new LatentStyleExceptionInfo(){ Name = "Medium List 1 Accent 2", UiPriority = 65, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo341 = new LatentStyleExceptionInfo(){ Name = "Medium List 2 Accent 2", UiPriority = 66, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo342 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 1 Accent 2", UiPriority = 67, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo343 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 2 Accent 2", UiPriority = 68, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo344 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 3 Accent 2", UiPriority = 69, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo345 = new LatentStyleExceptionInfo(){ Name = "Dark List Accent 2", UiPriority = 70, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo346 = new LatentStyleExceptionInfo(){ Name = "Colorful Shading Accent 2", UiPriority = 71, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo347 = new LatentStyleExceptionInfo(){ Name = "Colorful List Accent 2", UiPriority = 72, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo348 = new LatentStyleExceptionInfo(){ Name = "Colorful Grid Accent 2", UiPriority = 73, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo349 = new LatentStyleExceptionInfo(){ Name = "Light Shading Accent 3", UiPriority = 60, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo350 = new LatentStyleExceptionInfo(){ Name = "Light List Accent 3", UiPriority = 61, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo351 = new LatentStyleExceptionInfo(){ Name = "Light Grid Accent 3", UiPriority = 62, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo352 = new LatentStyleExceptionInfo(){ Name = "Medium Shading 1 Accent 3", UiPriority = 63, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo353 = new LatentStyleExceptionInfo(){ Name = "Medium Shading 2 Accent 3", UiPriority = 64, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo354 = new LatentStyleExceptionInfo(){ Name = "Medium List 1 Accent 3", UiPriority = 65, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo355 = new LatentStyleExceptionInfo(){ Name = "Medium List 2 Accent 3", UiPriority = 66, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo356 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 1 Accent 3", UiPriority = 67, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo357 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 2 Accent 3", UiPriority = 68, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo358 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 3 Accent 3", UiPriority = 69, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo359 = new LatentStyleExceptionInfo(){ Name = "Dark List Accent 3", UiPriority = 70, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo360 = new LatentStyleExceptionInfo(){ Name = "Colorful Shading Accent 3", UiPriority = 71, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo361 = new LatentStyleExceptionInfo(){ Name = "Colorful List Accent 3", UiPriority = 72, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo362 = new LatentStyleExceptionInfo(){ Name = "Colorful Grid Accent 3", UiPriority = 73, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo363 = new LatentStyleExceptionInfo(){ Name = "Light Shading Accent 4", UiPriority = 60, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo364 = new LatentStyleExceptionInfo(){ Name = "Light List Accent 4", UiPriority = 61, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo365 = new LatentStyleExceptionInfo(){ Name = "Light Grid Accent 4", UiPriority = 62, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo366 = new LatentStyleExceptionInfo(){ Name = "Medium Shading 1 Accent 4", UiPriority = 63, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo367 = new LatentStyleExceptionInfo(){ Name = "Medium Shading 2 Accent 4", UiPriority = 64, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo368 = new LatentStyleExceptionInfo(){ Name = "Medium List 1 Accent 4", UiPriority = 65, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo369 = new LatentStyleExceptionInfo(){ Name = "Medium List 2 Accent 4", UiPriority = 66, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo370 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 1 Accent 4", UiPriority = 67, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo371 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 2 Accent 4", UiPriority = 68, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo372 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 3 Accent 4", UiPriority = 69, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo373 = new LatentStyleExceptionInfo(){ Name = "Dark List Accent 4", UiPriority = 70, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo374 = new LatentStyleExceptionInfo(){ Name = "Colorful Shading Accent 4", UiPriority = 71, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo375 = new LatentStyleExceptionInfo(){ Name = "Colorful List Accent 4", UiPriority = 72, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo376 = new LatentStyleExceptionInfo(){ Name = "Colorful Grid Accent 4", UiPriority = 73, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo377 = new LatentStyleExceptionInfo(){ Name = "Light Shading Accent 5", UiPriority = 60, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo378 = new LatentStyleExceptionInfo(){ Name = "Light List Accent 5", UiPriority = 61, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo379 = new LatentStyleExceptionInfo(){ Name = "Light Grid Accent 5", UiPriority = 62, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo380 = new LatentStyleExceptionInfo(){ Name = "Medium Shading 1 Accent 5", UiPriority = 63, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo381 = new LatentStyleExceptionInfo(){ Name = "Medium Shading 2 Accent 5", UiPriority = 64, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo382 = new LatentStyleExceptionInfo(){ Name = "Medium List 1 Accent 5", UiPriority = 65, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo383 = new LatentStyleExceptionInfo(){ Name = "Medium List 2 Accent 5", UiPriority = 66, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo384 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 1 Accent 5", UiPriority = 67, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo385 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 2 Accent 5", UiPriority = 68, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo386 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 3 Accent 5", UiPriority = 69, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo387 = new LatentStyleExceptionInfo(){ Name = "Dark List Accent 5", UiPriority = 70, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo388 = new LatentStyleExceptionInfo(){ Name = "Colorful Shading Accent 5", UiPriority = 71, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo389 = new LatentStyleExceptionInfo(){ Name = "Colorful List Accent 5", UiPriority = 72, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo390 = new LatentStyleExceptionInfo(){ Name = "Colorful Grid Accent 5", UiPriority = 73, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo391 = new LatentStyleExceptionInfo(){ Name = "Light Shading Accent 6", UiPriority = 60, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo392 = new LatentStyleExceptionInfo(){ Name = "Light List Accent 6", UiPriority = 61, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo393 = new LatentStyleExceptionInfo(){ Name = "Light Grid Accent 6", UiPriority = 62, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo394 = new LatentStyleExceptionInfo(){ Name = "Medium Shading 1 Accent 6", UiPriority = 63, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo395 = new LatentStyleExceptionInfo(){ Name = "Medium Shading 2 Accent 6", UiPriority = 64, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo396 = new LatentStyleExceptionInfo(){ Name = "Medium List 1 Accent 6", UiPriority = 65, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo397 = new LatentStyleExceptionInfo(){ Name = "Medium List 2 Accent 6", UiPriority = 66, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo398 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 1 Accent 6", UiPriority = 67, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo399 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 2 Accent 6", UiPriority = 68, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo400 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 3 Accent 6", UiPriority = 69, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo401 = new LatentStyleExceptionInfo(){ Name = "Dark List Accent 6", UiPriority = 70, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo402 = new LatentStyleExceptionInfo(){ Name = "Colorful Shading Accent 6", UiPriority = 71, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo403 = new LatentStyleExceptionInfo(){ Name = "Colorful List Accent 6", UiPriority = 72, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo404 = new LatentStyleExceptionInfo(){ Name = "Colorful Grid Accent 6", UiPriority = 73, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo405 = new LatentStyleExceptionInfo(){ Name = "Subtle Emphasis", UiPriority = 19, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo406 = new LatentStyleExceptionInfo(){ Name = "Intense Emphasis", UiPriority = 21, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo407 = new LatentStyleExceptionInfo(){ Name = "Subtle Reference", UiPriority = 31, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo408 = new LatentStyleExceptionInfo(){ Name = "Intense Reference", UiPriority = 32, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo409 = new LatentStyleExceptionInfo(){ Name = "Book Title", UiPriority = 33, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo410 = new LatentStyleExceptionInfo(){ Name = "Bibliography", UiPriority = 37 };
            LatentStyleExceptionInfo latentStyleExceptionInfo411 = new LatentStyleExceptionInfo(){ Name = "TOC Heading", UiPriority = 39, PrimaryStyle = true };

            latentStyles3.Append(latentStyleExceptionInfo275);
            latentStyles3.Append(latentStyleExceptionInfo276);
            latentStyles3.Append(latentStyleExceptionInfo277);
            latentStyles3.Append(latentStyleExceptionInfo278);
            latentStyles3.Append(latentStyleExceptionInfo279);
            latentStyles3.Append(latentStyleExceptionInfo280);
            latentStyles3.Append(latentStyleExceptionInfo281);
            latentStyles3.Append(latentStyleExceptionInfo282);
            latentStyles3.Append(latentStyleExceptionInfo283);
            latentStyles3.Append(latentStyleExceptionInfo284);
            latentStyles3.Append(latentStyleExceptionInfo285);
            latentStyles3.Append(latentStyleExceptionInfo286);
            latentStyles3.Append(latentStyleExceptionInfo287);
            latentStyles3.Append(latentStyleExceptionInfo288);
            latentStyles3.Append(latentStyleExceptionInfo289);
            latentStyles3.Append(latentStyleExceptionInfo290);
            latentStyles3.Append(latentStyleExceptionInfo291);
            latentStyles3.Append(latentStyleExceptionInfo292);
            latentStyles3.Append(latentStyleExceptionInfo293);
            latentStyles3.Append(latentStyleExceptionInfo294);
            latentStyles3.Append(latentStyleExceptionInfo295);
            latentStyles3.Append(latentStyleExceptionInfo296);
            latentStyles3.Append(latentStyleExceptionInfo297);
            latentStyles3.Append(latentStyleExceptionInfo298);
            latentStyles3.Append(latentStyleExceptionInfo299);
            latentStyles3.Append(latentStyleExceptionInfo300);
            latentStyles3.Append(latentStyleExceptionInfo301);
            latentStyles3.Append(latentStyleExceptionInfo302);
            latentStyles3.Append(latentStyleExceptionInfo303);
            latentStyles3.Append(latentStyleExceptionInfo304);
            latentStyles3.Append(latentStyleExceptionInfo305);
            latentStyles3.Append(latentStyleExceptionInfo306);
            latentStyles3.Append(latentStyleExceptionInfo307);
            latentStyles3.Append(latentStyleExceptionInfo308);
            latentStyles3.Append(latentStyleExceptionInfo309);
            latentStyles3.Append(latentStyleExceptionInfo310);
            latentStyles3.Append(latentStyleExceptionInfo311);
            latentStyles3.Append(latentStyleExceptionInfo312);
            latentStyles3.Append(latentStyleExceptionInfo313);
            latentStyles3.Append(latentStyleExceptionInfo314);
            latentStyles3.Append(latentStyleExceptionInfo315);
            latentStyles3.Append(latentStyleExceptionInfo316);
            latentStyles3.Append(latentStyleExceptionInfo317);
            latentStyles3.Append(latentStyleExceptionInfo318);
            latentStyles3.Append(latentStyleExceptionInfo319);
            latentStyles3.Append(latentStyleExceptionInfo320);
            latentStyles3.Append(latentStyleExceptionInfo321);
            latentStyles3.Append(latentStyleExceptionInfo322);
            latentStyles3.Append(latentStyleExceptionInfo323);
            latentStyles3.Append(latentStyleExceptionInfo324);
            latentStyles3.Append(latentStyleExceptionInfo325);
            latentStyles3.Append(latentStyleExceptionInfo326);
            latentStyles3.Append(latentStyleExceptionInfo327);
            latentStyles3.Append(latentStyleExceptionInfo328);
            latentStyles3.Append(latentStyleExceptionInfo329);
            latentStyles3.Append(latentStyleExceptionInfo330);
            latentStyles3.Append(latentStyleExceptionInfo331);
            latentStyles3.Append(latentStyleExceptionInfo332);
            latentStyles3.Append(latentStyleExceptionInfo333);
            latentStyles3.Append(latentStyleExceptionInfo334);
            latentStyles3.Append(latentStyleExceptionInfo335);
            latentStyles3.Append(latentStyleExceptionInfo336);
            latentStyles3.Append(latentStyleExceptionInfo337);
            latentStyles3.Append(latentStyleExceptionInfo338);
            latentStyles3.Append(latentStyleExceptionInfo339);
            latentStyles3.Append(latentStyleExceptionInfo340);
            latentStyles3.Append(latentStyleExceptionInfo341);
            latentStyles3.Append(latentStyleExceptionInfo342);
            latentStyles3.Append(latentStyleExceptionInfo343);
            latentStyles3.Append(latentStyleExceptionInfo344);
            latentStyles3.Append(latentStyleExceptionInfo345);
            latentStyles3.Append(latentStyleExceptionInfo346);
            latentStyles3.Append(latentStyleExceptionInfo347);
            latentStyles3.Append(latentStyleExceptionInfo348);
            latentStyles3.Append(latentStyleExceptionInfo349);
            latentStyles3.Append(latentStyleExceptionInfo350);
            latentStyles3.Append(latentStyleExceptionInfo351);
            latentStyles3.Append(latentStyleExceptionInfo352);
            latentStyles3.Append(latentStyleExceptionInfo353);
            latentStyles3.Append(latentStyleExceptionInfo354);
            latentStyles3.Append(latentStyleExceptionInfo355);
            latentStyles3.Append(latentStyleExceptionInfo356);
            latentStyles3.Append(latentStyleExceptionInfo357);
            latentStyles3.Append(latentStyleExceptionInfo358);
            latentStyles3.Append(latentStyleExceptionInfo359);
            latentStyles3.Append(latentStyleExceptionInfo360);
            latentStyles3.Append(latentStyleExceptionInfo361);
            latentStyles3.Append(latentStyleExceptionInfo362);
            latentStyles3.Append(latentStyleExceptionInfo363);
            latentStyles3.Append(latentStyleExceptionInfo364);
            latentStyles3.Append(latentStyleExceptionInfo365);
            latentStyles3.Append(latentStyleExceptionInfo366);
            latentStyles3.Append(latentStyleExceptionInfo367);
            latentStyles3.Append(latentStyleExceptionInfo368);
            latentStyles3.Append(latentStyleExceptionInfo369);
            latentStyles3.Append(latentStyleExceptionInfo370);
            latentStyles3.Append(latentStyleExceptionInfo371);
            latentStyles3.Append(latentStyleExceptionInfo372);
            latentStyles3.Append(latentStyleExceptionInfo373);
            latentStyles3.Append(latentStyleExceptionInfo374);
            latentStyles3.Append(latentStyleExceptionInfo375);
            latentStyles3.Append(latentStyleExceptionInfo376);
            latentStyles3.Append(latentStyleExceptionInfo377);
            latentStyles3.Append(latentStyleExceptionInfo378);
            latentStyles3.Append(latentStyleExceptionInfo379);
            latentStyles3.Append(latentStyleExceptionInfo380);
            latentStyles3.Append(latentStyleExceptionInfo381);
            latentStyles3.Append(latentStyleExceptionInfo382);
            latentStyles3.Append(latentStyleExceptionInfo383);
            latentStyles3.Append(latentStyleExceptionInfo384);
            latentStyles3.Append(latentStyleExceptionInfo385);
            latentStyles3.Append(latentStyleExceptionInfo386);
            latentStyles3.Append(latentStyleExceptionInfo387);
            latentStyles3.Append(latentStyleExceptionInfo388);
            latentStyles3.Append(latentStyleExceptionInfo389);
            latentStyles3.Append(latentStyleExceptionInfo390);
            latentStyles3.Append(latentStyleExceptionInfo391);
            latentStyles3.Append(latentStyleExceptionInfo392);
            latentStyles3.Append(latentStyleExceptionInfo393);
            latentStyles3.Append(latentStyleExceptionInfo394);
            latentStyles3.Append(latentStyleExceptionInfo395);
            latentStyles3.Append(latentStyleExceptionInfo396);
            latentStyles3.Append(latentStyleExceptionInfo397);
            latentStyles3.Append(latentStyleExceptionInfo398);
            latentStyles3.Append(latentStyleExceptionInfo399);
            latentStyles3.Append(latentStyleExceptionInfo400);
            latentStyles3.Append(latentStyleExceptionInfo401);
            latentStyles3.Append(latentStyleExceptionInfo402);
            latentStyles3.Append(latentStyleExceptionInfo403);
            latentStyles3.Append(latentStyleExceptionInfo404);
            latentStyles3.Append(latentStyleExceptionInfo405);
            latentStyles3.Append(latentStyleExceptionInfo406);
            latentStyles3.Append(latentStyleExceptionInfo407);
            latentStyles3.Append(latentStyleExceptionInfo408);
            latentStyles3.Append(latentStyleExceptionInfo409);
            latentStyles3.Append(latentStyleExceptionInfo410);
            latentStyles3.Append(latentStyleExceptionInfo411);

            Style style21 = new Style(){ Type = StyleValues.Paragraph, StyleId = "Normal", Default = true };
            StyleName styleName21 = new StyleName(){ Val = "Normal" };
            PrimaryStyle primaryStyle3 = new PrimaryStyle();

            StyleParagraphProperties styleParagraphProperties13 = new StyleParagraphProperties();
            WidowControl widowControl13 = new WidowControl(){ Val = false };
            Justification justification13 = new Justification(){ Val = JustificationValues.Both };

            styleParagraphProperties13.Append(widowControl13);
            styleParagraphProperties13.Append(justification13);

            style21.Append(styleName21);
            style21.Append(primaryStyle3);
            style21.Append(styleParagraphProperties13);

            Style style22 = new Style(){ Type = StyleValues.Character, StyleId = "DefaultParagraphFont", Default = true };
            StyleName styleName22 = new StyleName(){ Val = "Default Paragraph Font" };
            UIPriority uIPriority9 = new UIPriority(){ Val = 1 };
            SemiHidden semiHidden9 = new SemiHidden();
            UnhideWhenUsed unhideWhenUsed7 = new UnhideWhenUsed();

            style22.Append(styleName22);
            style22.Append(uIPriority9);
            style22.Append(semiHidden9);
            style22.Append(unhideWhenUsed7);

            Style style23 = new Style(){ Type = StyleValues.Table, StyleId = "TableNormal", Default = true };
            StyleName styleName23 = new StyleName(){ Val = "Normal Table" };
            UIPriority uIPriority10 = new UIPriority(){ Val = 99 };
            SemiHidden semiHidden10 = new SemiHidden();
            UnhideWhenUsed unhideWhenUsed8 = new UnhideWhenUsed();

            StyleTableProperties styleTableProperties3 = new StyleTableProperties();
            TableIndentation tableIndentation3 = new TableIndentation(){ Width = 0, Type = TableWidthUnitValues.Dxa };

            TableCellMarginDefault tableCellMarginDefault3 = new TableCellMarginDefault();
            TopMargin topMargin3 = new TopMargin(){ Width = "0", Type = TableWidthUnitValues.Dxa };
            TableCellLeftMargin tableCellLeftMargin3 = new TableCellLeftMargin(){ Width = 108, Type = TableWidthValues.Dxa };
            BottomMargin bottomMargin3 = new BottomMargin(){ Width = "0", Type = TableWidthUnitValues.Dxa };
            TableCellRightMargin tableCellRightMargin3 = new TableCellRightMargin(){ Width = 108, Type = TableWidthValues.Dxa };

            tableCellMarginDefault3.Append(topMargin3);
            tableCellMarginDefault3.Append(tableCellLeftMargin3);
            tableCellMarginDefault3.Append(bottomMargin3);
            tableCellMarginDefault3.Append(tableCellRightMargin3);

            styleTableProperties3.Append(tableIndentation3);
            styleTableProperties3.Append(tableCellMarginDefault3);

            style23.Append(styleName23);
            style23.Append(uIPriority10);
            style23.Append(semiHidden10);
            style23.Append(unhideWhenUsed8);
            style23.Append(styleTableProperties3);

            Style style24 = new Style(){ Type = StyleValues.Numbering, StyleId = "NoList", Default = true };
            StyleName styleName24 = new StyleName(){ Val = "No List" };
            UIPriority uIPriority11 = new UIPriority(){ Val = 99 };
            SemiHidden semiHidden11 = new SemiHidden();
            UnhideWhenUsed unhideWhenUsed9 = new UnhideWhenUsed();

            style24.Append(styleName24);
            style24.Append(uIPriority11);
            style24.Append(semiHidden11);
            style24.Append(unhideWhenUsed9);

            Style style25 = new Style(){ Type = StyleValues.Character, StyleId = "PlaceholderText" };
            StyleName styleName25 = new StyleName(){ Val = "Placeholder Text" };
            BasedOn basedOn3 = new BasedOn(){ Val = "DefaultParagraphFont" };
            UIPriority uIPriority12 = new UIPriority(){ Val = 99 };
            SemiHidden semiHidden12 = new SemiHidden();
            Rsid rsid34 = new Rsid(){ Val = "000010BA" };

            StyleRunProperties styleRunProperties3 = new StyleRunProperties();
            Color color4 = new Color(){ Val = "808080" };

            styleRunProperties3.Append(color4);

            style25.Append(styleName25);
            style25.Append(basedOn3);
            style25.Append(uIPriority12);
            style25.Append(semiHidden12);
            style25.Append(rsid34);
            style25.Append(styleRunProperties3);

            Style style26 = new Style(){ Type = StyleValues.Paragraph, StyleId = "Header" };
            StyleName styleName26 = new StyleName(){ Val = "header" };
            BasedOn basedOn4 = new BasedOn(){ Val = "Normal" };
            LinkedStyle linkedStyle1 = new LinkedStyle(){ Val = "HeaderChar" };
            UIPriority uIPriority13 = new UIPriority(){ Val = 99 };
            UnhideWhenUsed unhideWhenUsed10 = new UnhideWhenUsed();
            Rsid rsid35 = new Rsid(){ Val = "00E930A2" };

            StyleParagraphProperties styleParagraphProperties14 = new StyleParagraphProperties();

            Tabs tabs1 = new Tabs();
            TabStop tabStop1 = new TabStop(){ Val = TabStopValues.Center, Position = 4252 };
            TabStop tabStop2 = new TabStop(){ Val = TabStopValues.Right, Position = 8504 };

            tabs1.Append(tabStop1);
            tabs1.Append(tabStop2);
            SnapToGrid snapToGrid1 = new SnapToGrid(){ Val = false };

            styleParagraphProperties14.Append(tabs1);
            styleParagraphProperties14.Append(snapToGrid1);

            style26.Append(styleName26);
            style26.Append(basedOn4);
            style26.Append(linkedStyle1);
            style26.Append(uIPriority13);
            style26.Append(unhideWhenUsed10);
            style26.Append(rsid35);
            style26.Append(styleParagraphProperties14);

            Style style27 = new Style(){ Type = StyleValues.Character, StyleId = "HeaderChar", CustomStyle = true };
            StyleName styleName27 = new StyleName(){ Val = "Header Char" };
            BasedOn basedOn5 = new BasedOn(){ Val = "DefaultParagraphFont" };
            LinkedStyle linkedStyle2 = new LinkedStyle(){ Val = "Header" };
            UIPriority uIPriority14 = new UIPriority(){ Val = 99 };
            Rsid rsid36 = new Rsid(){ Val = "00E930A2" };

            style27.Append(styleName27);
            style27.Append(basedOn5);
            style27.Append(linkedStyle2);
            style27.Append(uIPriority14);
            style27.Append(rsid36);

            Style style28 = new Style(){ Type = StyleValues.Paragraph, StyleId = "Footer" };
            StyleName styleName28 = new StyleName(){ Val = "footer" };
            BasedOn basedOn6 = new BasedOn(){ Val = "Normal" };
            LinkedStyle linkedStyle3 = new LinkedStyle(){ Val = "FooterChar" };
            UIPriority uIPriority15 = new UIPriority(){ Val = 99 };
            UnhideWhenUsed unhideWhenUsed11 = new UnhideWhenUsed();
            Rsid rsid37 = new Rsid(){ Val = "00E930A2" };

            StyleParagraphProperties styleParagraphProperties15 = new StyleParagraphProperties();

            Tabs tabs2 = new Tabs();
            TabStop tabStop3 = new TabStop(){ Val = TabStopValues.Center, Position = 4252 };
            TabStop tabStop4 = new TabStop(){ Val = TabStopValues.Right, Position = 8504 };

            tabs2.Append(tabStop3);
            tabs2.Append(tabStop4);
            SnapToGrid snapToGrid2 = new SnapToGrid(){ Val = false };

            styleParagraphProperties15.Append(tabs2);
            styleParagraphProperties15.Append(snapToGrid2);

            style28.Append(styleName28);
            style28.Append(basedOn6);
            style28.Append(linkedStyle3);
            style28.Append(uIPriority15);
            style28.Append(unhideWhenUsed11);
            style28.Append(rsid37);
            style28.Append(styleParagraphProperties15);

            Style style29 = new Style(){ Type = StyleValues.Character, StyleId = "FooterChar", CustomStyle = true };
            StyleName styleName29 = new StyleName(){ Val = "Footer Char" };
            BasedOn basedOn7 = new BasedOn(){ Val = "DefaultParagraphFont" };
            LinkedStyle linkedStyle4 = new LinkedStyle(){ Val = "Footer" };
            UIPriority uIPriority16 = new UIPriority(){ Val = 99 };
            Rsid rsid38 = new Rsid(){ Val = "00E930A2" };

            style29.Append(styleName29);
            style29.Append(basedOn7);
            style29.Append(linkedStyle4);
            style29.Append(uIPriority16);
            style29.Append(rsid38);

            styles3.Append(docDefaults3);
            styles3.Append(latentStyles3);
            styles3.Append(style21);
            styles3.Append(style22);
            styles3.Append(style23);
            styles3.Append(style24);
            styles3.Append(style25);
            styles3.Append(style26);
            styles3.Append(style27);
            styles3.Append(style28);
            styles3.Append(style29);

            stylesWithEffectsPart2.Styles = styles3;
        }

        // Generates content of styleDefinitionsPart2.
        private void GenerateStyleDefinitionsPart2Content(StyleDefinitionsPart styleDefinitionsPart2)
        {
            Styles styles4 = new Styles(){ MCAttributes = new MarkupCompatibilityAttributes(){ Ignorable = "w14 w15" }  };
            styles4.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            styles4.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            styles4.AddNamespaceDeclaration("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main");
            styles4.AddNamespaceDeclaration("w14", "http://schemas.microsoft.com/office/word/2010/wordml");
            styles4.AddNamespaceDeclaration("w15", "http://schemas.microsoft.com/office/word/2010/11/wordml");

            DocDefaults docDefaults4 = new DocDefaults();

            RunPropertiesDefault runPropertiesDefault4 = new RunPropertiesDefault();

            RunPropertiesBaseStyle runPropertiesBaseStyle4 = new RunPropertiesBaseStyle();
            RunFonts runFonts36 = new RunFonts(){ AsciiTheme = ThemeFontValues.MinorHighAnsi, HighAnsiTheme = ThemeFontValues.MinorHighAnsi, EastAsiaTheme = ThemeFontValues.MinorEastAsia, ComplexScriptTheme = ThemeFontValues.MinorBidi };
            Kern kern18 = new Kern(){ Val = (UInt32Value)2U };
            FontSize fontSize4 = new FontSize(){ Val = "21" };
            FontSizeComplexScript fontSizeComplexScript4 = new FontSizeComplexScript(){ Val = "22" };
            Languages languages4 = new Languages(){ Val = "en-US", EastAsia = "ja-JP", Bidi = "ar-SA" };

            runPropertiesBaseStyle4.Append(runFonts36);
            runPropertiesBaseStyle4.Append(kern18);
            runPropertiesBaseStyle4.Append(fontSize4);
            runPropertiesBaseStyle4.Append(fontSizeComplexScript4);
            runPropertiesBaseStyle4.Append(languages4);

            runPropertiesDefault4.Append(runPropertiesBaseStyle4);
            ParagraphPropertiesDefault paragraphPropertiesDefault4 = new ParagraphPropertiesDefault();

            docDefaults4.Append(runPropertiesDefault4);
            docDefaults4.Append(paragraphPropertiesDefault4);

            LatentStyles latentStyles4 = new LatentStyles(){ DefaultLockedState = false, DefaultUiPriority = 99, DefaultSemiHidden = true, DefaultUnhideWhenUsed = true, DefaultPrimaryStyle = false, Count = 267 };
            LatentStyleExceptionInfo latentStyleExceptionInfo412 = new LatentStyleExceptionInfo(){ Name = "Normal", UiPriority = 0, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo413 = new LatentStyleExceptionInfo(){ Name = "heading 1", UiPriority = 9, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo414 = new LatentStyleExceptionInfo(){ Name = "heading 2", UiPriority = 9, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo415 = new LatentStyleExceptionInfo(){ Name = "heading 3", UiPriority = 9, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo416 = new LatentStyleExceptionInfo(){ Name = "heading 4", UiPriority = 9, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo417 = new LatentStyleExceptionInfo(){ Name = "heading 5", UiPriority = 9, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo418 = new LatentStyleExceptionInfo(){ Name = "heading 6", UiPriority = 9, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo419 = new LatentStyleExceptionInfo(){ Name = "heading 7", UiPriority = 9, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo420 = new LatentStyleExceptionInfo(){ Name = "heading 8", UiPriority = 9, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo421 = new LatentStyleExceptionInfo(){ Name = "heading 9", UiPriority = 9, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo422 = new LatentStyleExceptionInfo(){ Name = "toc 1", UiPriority = 39 };
            LatentStyleExceptionInfo latentStyleExceptionInfo423 = new LatentStyleExceptionInfo(){ Name = "toc 2", UiPriority = 39 };
            LatentStyleExceptionInfo latentStyleExceptionInfo424 = new LatentStyleExceptionInfo(){ Name = "toc 3", UiPriority = 39 };
            LatentStyleExceptionInfo latentStyleExceptionInfo425 = new LatentStyleExceptionInfo(){ Name = "toc 4", UiPriority = 39 };
            LatentStyleExceptionInfo latentStyleExceptionInfo426 = new LatentStyleExceptionInfo(){ Name = "toc 5", UiPriority = 39 };
            LatentStyleExceptionInfo latentStyleExceptionInfo427 = new LatentStyleExceptionInfo(){ Name = "toc 6", UiPriority = 39 };
            LatentStyleExceptionInfo latentStyleExceptionInfo428 = new LatentStyleExceptionInfo(){ Name = "toc 7", UiPriority = 39 };
            LatentStyleExceptionInfo latentStyleExceptionInfo429 = new LatentStyleExceptionInfo(){ Name = "toc 8", UiPriority = 39 };
            LatentStyleExceptionInfo latentStyleExceptionInfo430 = new LatentStyleExceptionInfo(){ Name = "toc 9", UiPriority = 39 };
            LatentStyleExceptionInfo latentStyleExceptionInfo431 = new LatentStyleExceptionInfo(){ Name = "caption", UiPriority = 35, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo432 = new LatentStyleExceptionInfo(){ Name = "Title", UiPriority = 10, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo433 = new LatentStyleExceptionInfo(){ Name = "Default Paragraph Font", UiPriority = 1 };
            LatentStyleExceptionInfo latentStyleExceptionInfo434 = new LatentStyleExceptionInfo(){ Name = "Subtitle", UiPriority = 11, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo435 = new LatentStyleExceptionInfo(){ Name = "Strong", UiPriority = 22, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo436 = new LatentStyleExceptionInfo(){ Name = "Emphasis", UiPriority = 20, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo437 = new LatentStyleExceptionInfo(){ Name = "Table Grid", UiPriority = 59, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo438 = new LatentStyleExceptionInfo(){ Name = "Placeholder Text", UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo439 = new LatentStyleExceptionInfo(){ Name = "No Spacing", UiPriority = 36, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo440 = new LatentStyleExceptionInfo(){ Name = "Light Shading", UiPriority = 60, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo441 = new LatentStyleExceptionInfo(){ Name = "Light List", UiPriority = 61, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo442 = new LatentStyleExceptionInfo(){ Name = "Light Grid", UiPriority = 62, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo443 = new LatentStyleExceptionInfo(){ Name = "Medium Shading 1", UiPriority = 63, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo444 = new LatentStyleExceptionInfo(){ Name = "Medium Shading 2", UiPriority = 64, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo445 = new LatentStyleExceptionInfo(){ Name = "Medium List 1", UiPriority = 65, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo446 = new LatentStyleExceptionInfo(){ Name = "Medium List 2", UiPriority = 66, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo447 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 1", UiPriority = 67, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo448 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 2", UiPriority = 68, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo449 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 3", UiPriority = 69, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo450 = new LatentStyleExceptionInfo(){ Name = "Dark List", UiPriority = 70, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo451 = new LatentStyleExceptionInfo(){ Name = "Colorful Shading", UiPriority = 71, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo452 = new LatentStyleExceptionInfo(){ Name = "Colorful List", UiPriority = 72, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo453 = new LatentStyleExceptionInfo(){ Name = "Colorful Grid", UiPriority = 73, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo454 = new LatentStyleExceptionInfo(){ Name = "Light Shading Accent 1", UiPriority = 60, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo455 = new LatentStyleExceptionInfo(){ Name = "Light List Accent 1", UiPriority = 61, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo456 = new LatentStyleExceptionInfo(){ Name = "Light Grid Accent 1", UiPriority = 62, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo457 = new LatentStyleExceptionInfo(){ Name = "Medium Shading 1 Accent 1", UiPriority = 63, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo458 = new LatentStyleExceptionInfo(){ Name = "Medium Shading 2 Accent 1", UiPriority = 64, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo459 = new LatentStyleExceptionInfo(){ Name = "Medium List 1 Accent 1", UiPriority = 65, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo460 = new LatentStyleExceptionInfo(){ Name = "Revision", UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo461 = new LatentStyleExceptionInfo(){ Name = "List Paragraph", UiPriority = 34, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo462 = new LatentStyleExceptionInfo(){ Name = "Quote", UiPriority = 29, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo463 = new LatentStyleExceptionInfo(){ Name = "Intense Quote", UiPriority = 30, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo464 = new LatentStyleExceptionInfo(){ Name = "Medium List 2 Accent 1", UiPriority = 66, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo465 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 1 Accent 1", UiPriority = 67, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo466 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 2 Accent 1", UiPriority = 68, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo467 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 3 Accent 1", UiPriority = 69, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo468 = new LatentStyleExceptionInfo(){ Name = "Dark List Accent 1", UiPriority = 70, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo469 = new LatentStyleExceptionInfo(){ Name = "Colorful Shading Accent 1", UiPriority = 71, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo470 = new LatentStyleExceptionInfo(){ Name = "Colorful List Accent 1", UiPriority = 72, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo471 = new LatentStyleExceptionInfo(){ Name = "Colorful Grid Accent 1", UiPriority = 73, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo472 = new LatentStyleExceptionInfo(){ Name = "Light Shading Accent 2", UiPriority = 60, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo473 = new LatentStyleExceptionInfo(){ Name = "Light List Accent 2", UiPriority = 61, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo474 = new LatentStyleExceptionInfo(){ Name = "Light Grid Accent 2", UiPriority = 62, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo475 = new LatentStyleExceptionInfo(){ Name = "Medium Shading 1 Accent 2", UiPriority = 63, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo476 = new LatentStyleExceptionInfo(){ Name = "Medium Shading 2 Accent 2", UiPriority = 64, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo477 = new LatentStyleExceptionInfo(){ Name = "Medium List 1 Accent 2", UiPriority = 65, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo478 = new LatentStyleExceptionInfo(){ Name = "Medium List 2 Accent 2", UiPriority = 66, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo479 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 1 Accent 2", UiPriority = 67, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo480 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 2 Accent 2", UiPriority = 68, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo481 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 3 Accent 2", UiPriority = 69, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo482 = new LatentStyleExceptionInfo(){ Name = "Dark List Accent 2", UiPriority = 70, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo483 = new LatentStyleExceptionInfo(){ Name = "Colorful Shading Accent 2", UiPriority = 71, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo484 = new LatentStyleExceptionInfo(){ Name = "Colorful List Accent 2", UiPriority = 72, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo485 = new LatentStyleExceptionInfo(){ Name = "Colorful Grid Accent 2", UiPriority = 73, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo486 = new LatentStyleExceptionInfo(){ Name = "Light Shading Accent 3", UiPriority = 60, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo487 = new LatentStyleExceptionInfo(){ Name = "Light List Accent 3", UiPriority = 61, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo488 = new LatentStyleExceptionInfo(){ Name = "Light Grid Accent 3", UiPriority = 62, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo489 = new LatentStyleExceptionInfo(){ Name = "Medium Shading 1 Accent 3", UiPriority = 63, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo490 = new LatentStyleExceptionInfo(){ Name = "Medium Shading 2 Accent 3", UiPriority = 64, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo491 = new LatentStyleExceptionInfo(){ Name = "Medium List 1 Accent 3", UiPriority = 65, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo492 = new LatentStyleExceptionInfo(){ Name = "Medium List 2 Accent 3", UiPriority = 66, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo493 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 1 Accent 3", UiPriority = 67, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo494 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 2 Accent 3", UiPriority = 68, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo495 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 3 Accent 3", UiPriority = 69, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo496 = new LatentStyleExceptionInfo(){ Name = "Dark List Accent 3", UiPriority = 70, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo497 = new LatentStyleExceptionInfo(){ Name = "Colorful Shading Accent 3", UiPriority = 71, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo498 = new LatentStyleExceptionInfo(){ Name = "Colorful List Accent 3", UiPriority = 72, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo499 = new LatentStyleExceptionInfo(){ Name = "Colorful Grid Accent 3", UiPriority = 73, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo500 = new LatentStyleExceptionInfo(){ Name = "Light Shading Accent 4", UiPriority = 60, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo501 = new LatentStyleExceptionInfo(){ Name = "Light List Accent 4", UiPriority = 61, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo502 = new LatentStyleExceptionInfo(){ Name = "Light Grid Accent 4", UiPriority = 62, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo503 = new LatentStyleExceptionInfo(){ Name = "Medium Shading 1 Accent 4", UiPriority = 63, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo504 = new LatentStyleExceptionInfo(){ Name = "Medium Shading 2 Accent 4", UiPriority = 64, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo505 = new LatentStyleExceptionInfo(){ Name = "Medium List 1 Accent 4", UiPriority = 65, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo506 = new LatentStyleExceptionInfo(){ Name = "Medium List 2 Accent 4", UiPriority = 66, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo507 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 1 Accent 4", UiPriority = 67, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo508 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 2 Accent 4", UiPriority = 68, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo509 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 3 Accent 4", UiPriority = 69, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo510 = new LatentStyleExceptionInfo(){ Name = "Dark List Accent 4", UiPriority = 70, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo511 = new LatentStyleExceptionInfo(){ Name = "Colorful Shading Accent 4", UiPriority = 71, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo512 = new LatentStyleExceptionInfo(){ Name = "Colorful List Accent 4", UiPriority = 72, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo513 = new LatentStyleExceptionInfo(){ Name = "Colorful Grid Accent 4", UiPriority = 73, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo514 = new LatentStyleExceptionInfo(){ Name = "Light Shading Accent 5", UiPriority = 60, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo515 = new LatentStyleExceptionInfo(){ Name = "Light List Accent 5", UiPriority = 61, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo516 = new LatentStyleExceptionInfo(){ Name = "Light Grid Accent 5", UiPriority = 62, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo517 = new LatentStyleExceptionInfo(){ Name = "Medium Shading 1 Accent 5", UiPriority = 63, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo518 = new LatentStyleExceptionInfo(){ Name = "Medium Shading 2 Accent 5", UiPriority = 64, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo519 = new LatentStyleExceptionInfo(){ Name = "Medium List 1 Accent 5", UiPriority = 65, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo520 = new LatentStyleExceptionInfo(){ Name = "Medium List 2 Accent 5", UiPriority = 66, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo521 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 1 Accent 5", UiPriority = 67, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo522 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 2 Accent 5", UiPriority = 68, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo523 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 3 Accent 5", UiPriority = 69, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo524 = new LatentStyleExceptionInfo(){ Name = "Dark List Accent 5", UiPriority = 70, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo525 = new LatentStyleExceptionInfo(){ Name = "Colorful Shading Accent 5", UiPriority = 71, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo526 = new LatentStyleExceptionInfo(){ Name = "Colorful List Accent 5", UiPriority = 72, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo527 = new LatentStyleExceptionInfo(){ Name = "Colorful Grid Accent 5", UiPriority = 73, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo528 = new LatentStyleExceptionInfo(){ Name = "Light Shading Accent 6", UiPriority = 60, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo529 = new LatentStyleExceptionInfo(){ Name = "Light List Accent 6", UiPriority = 61, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo530 = new LatentStyleExceptionInfo(){ Name = "Light Grid Accent 6", UiPriority = 62, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo531 = new LatentStyleExceptionInfo(){ Name = "Medium Shading 1 Accent 6", UiPriority = 63, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo532 = new LatentStyleExceptionInfo(){ Name = "Medium Shading 2 Accent 6", UiPriority = 64, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo533 = new LatentStyleExceptionInfo(){ Name = "Medium List 1 Accent 6", UiPriority = 65, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo534 = new LatentStyleExceptionInfo(){ Name = "Medium List 2 Accent 6", UiPriority = 66, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo535 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 1 Accent 6", UiPriority = 67, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo536 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 2 Accent 6", UiPriority = 68, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo537 = new LatentStyleExceptionInfo(){ Name = "Medium Grid 3 Accent 6", UiPriority = 69, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo538 = new LatentStyleExceptionInfo(){ Name = "Dark List Accent 6", UiPriority = 70, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo539 = new LatentStyleExceptionInfo(){ Name = "Colorful Shading Accent 6", UiPriority = 71, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo540 = new LatentStyleExceptionInfo(){ Name = "Colorful List Accent 6", UiPriority = 72, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo541 = new LatentStyleExceptionInfo(){ Name = "Colorful Grid Accent 6", UiPriority = 73, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo542 = new LatentStyleExceptionInfo(){ Name = "Subtle Emphasis", UiPriority = 19, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo543 = new LatentStyleExceptionInfo(){ Name = "Intense Emphasis", UiPriority = 21, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo544 = new LatentStyleExceptionInfo(){ Name = "Subtle Reference", UiPriority = 31, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo545 = new LatentStyleExceptionInfo(){ Name = "Intense Reference", UiPriority = 32, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo546 = new LatentStyleExceptionInfo(){ Name = "Book Title", UiPriority = 33, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo547 = new LatentStyleExceptionInfo(){ Name = "Bibliography", UiPriority = 37 };
            LatentStyleExceptionInfo latentStyleExceptionInfo548 = new LatentStyleExceptionInfo(){ Name = "TOC Heading", UiPriority = 39, PrimaryStyle = true };

            latentStyles4.Append(latentStyleExceptionInfo412);
            latentStyles4.Append(latentStyleExceptionInfo413);
            latentStyles4.Append(latentStyleExceptionInfo414);
            latentStyles4.Append(latentStyleExceptionInfo415);
            latentStyles4.Append(latentStyleExceptionInfo416);
            latentStyles4.Append(latentStyleExceptionInfo417);
            latentStyles4.Append(latentStyleExceptionInfo418);
            latentStyles4.Append(latentStyleExceptionInfo419);
            latentStyles4.Append(latentStyleExceptionInfo420);
            latentStyles4.Append(latentStyleExceptionInfo421);
            latentStyles4.Append(latentStyleExceptionInfo422);
            latentStyles4.Append(latentStyleExceptionInfo423);
            latentStyles4.Append(latentStyleExceptionInfo424);
            latentStyles4.Append(latentStyleExceptionInfo425);
            latentStyles4.Append(latentStyleExceptionInfo426);
            latentStyles4.Append(latentStyleExceptionInfo427);
            latentStyles4.Append(latentStyleExceptionInfo428);
            latentStyles4.Append(latentStyleExceptionInfo429);
            latentStyles4.Append(latentStyleExceptionInfo430);
            latentStyles4.Append(latentStyleExceptionInfo431);
            latentStyles4.Append(latentStyleExceptionInfo432);
            latentStyles4.Append(latentStyleExceptionInfo433);
            latentStyles4.Append(latentStyleExceptionInfo434);
            latentStyles4.Append(latentStyleExceptionInfo435);
            latentStyles4.Append(latentStyleExceptionInfo436);
            latentStyles4.Append(latentStyleExceptionInfo437);
            latentStyles4.Append(latentStyleExceptionInfo438);
            latentStyles4.Append(latentStyleExceptionInfo439);
            latentStyles4.Append(latentStyleExceptionInfo440);
            latentStyles4.Append(latentStyleExceptionInfo441);
            latentStyles4.Append(latentStyleExceptionInfo442);
            latentStyles4.Append(latentStyleExceptionInfo443);
            latentStyles4.Append(latentStyleExceptionInfo444);
            latentStyles4.Append(latentStyleExceptionInfo445);
            latentStyles4.Append(latentStyleExceptionInfo446);
            latentStyles4.Append(latentStyleExceptionInfo447);
            latentStyles4.Append(latentStyleExceptionInfo448);
            latentStyles4.Append(latentStyleExceptionInfo449);
            latentStyles4.Append(latentStyleExceptionInfo450);
            latentStyles4.Append(latentStyleExceptionInfo451);
            latentStyles4.Append(latentStyleExceptionInfo452);
            latentStyles4.Append(latentStyleExceptionInfo453);
            latentStyles4.Append(latentStyleExceptionInfo454);
            latentStyles4.Append(latentStyleExceptionInfo455);
            latentStyles4.Append(latentStyleExceptionInfo456);
            latentStyles4.Append(latentStyleExceptionInfo457);
            latentStyles4.Append(latentStyleExceptionInfo458);
            latentStyles4.Append(latentStyleExceptionInfo459);
            latentStyles4.Append(latentStyleExceptionInfo460);
            latentStyles4.Append(latentStyleExceptionInfo461);
            latentStyles4.Append(latentStyleExceptionInfo462);
            latentStyles4.Append(latentStyleExceptionInfo463);
            latentStyles4.Append(latentStyleExceptionInfo464);
            latentStyles4.Append(latentStyleExceptionInfo465);
            latentStyles4.Append(latentStyleExceptionInfo466);
            latentStyles4.Append(latentStyleExceptionInfo467);
            latentStyles4.Append(latentStyleExceptionInfo468);
            latentStyles4.Append(latentStyleExceptionInfo469);
            latentStyles4.Append(latentStyleExceptionInfo470);
            latentStyles4.Append(latentStyleExceptionInfo471);
            latentStyles4.Append(latentStyleExceptionInfo472);
            latentStyles4.Append(latentStyleExceptionInfo473);
            latentStyles4.Append(latentStyleExceptionInfo474);
            latentStyles4.Append(latentStyleExceptionInfo475);
            latentStyles4.Append(latentStyleExceptionInfo476);
            latentStyles4.Append(latentStyleExceptionInfo477);
            latentStyles4.Append(latentStyleExceptionInfo478);
            latentStyles4.Append(latentStyleExceptionInfo479);
            latentStyles4.Append(latentStyleExceptionInfo480);
            latentStyles4.Append(latentStyleExceptionInfo481);
            latentStyles4.Append(latentStyleExceptionInfo482);
            latentStyles4.Append(latentStyleExceptionInfo483);
            latentStyles4.Append(latentStyleExceptionInfo484);
            latentStyles4.Append(latentStyleExceptionInfo485);
            latentStyles4.Append(latentStyleExceptionInfo486);
            latentStyles4.Append(latentStyleExceptionInfo487);
            latentStyles4.Append(latentStyleExceptionInfo488);
            latentStyles4.Append(latentStyleExceptionInfo489);
            latentStyles4.Append(latentStyleExceptionInfo490);
            latentStyles4.Append(latentStyleExceptionInfo491);
            latentStyles4.Append(latentStyleExceptionInfo492);
            latentStyles4.Append(latentStyleExceptionInfo493);
            latentStyles4.Append(latentStyleExceptionInfo494);
            latentStyles4.Append(latentStyleExceptionInfo495);
            latentStyles4.Append(latentStyleExceptionInfo496);
            latentStyles4.Append(latentStyleExceptionInfo497);
            latentStyles4.Append(latentStyleExceptionInfo498);
            latentStyles4.Append(latentStyleExceptionInfo499);
            latentStyles4.Append(latentStyleExceptionInfo500);
            latentStyles4.Append(latentStyleExceptionInfo501);
            latentStyles4.Append(latentStyleExceptionInfo502);
            latentStyles4.Append(latentStyleExceptionInfo503);
            latentStyles4.Append(latentStyleExceptionInfo504);
            latentStyles4.Append(latentStyleExceptionInfo505);
            latentStyles4.Append(latentStyleExceptionInfo506);
            latentStyles4.Append(latentStyleExceptionInfo507);
            latentStyles4.Append(latentStyleExceptionInfo508);
            latentStyles4.Append(latentStyleExceptionInfo509);
            latentStyles4.Append(latentStyleExceptionInfo510);
            latentStyles4.Append(latentStyleExceptionInfo511);
            latentStyles4.Append(latentStyleExceptionInfo512);
            latentStyles4.Append(latentStyleExceptionInfo513);
            latentStyles4.Append(latentStyleExceptionInfo514);
            latentStyles4.Append(latentStyleExceptionInfo515);
            latentStyles4.Append(latentStyleExceptionInfo516);
            latentStyles4.Append(latentStyleExceptionInfo517);
            latentStyles4.Append(latentStyleExceptionInfo518);
            latentStyles4.Append(latentStyleExceptionInfo519);
            latentStyles4.Append(latentStyleExceptionInfo520);
            latentStyles4.Append(latentStyleExceptionInfo521);
            latentStyles4.Append(latentStyleExceptionInfo522);
            latentStyles4.Append(latentStyleExceptionInfo523);
            latentStyles4.Append(latentStyleExceptionInfo524);
            latentStyles4.Append(latentStyleExceptionInfo525);
            latentStyles4.Append(latentStyleExceptionInfo526);
            latentStyles4.Append(latentStyleExceptionInfo527);
            latentStyles4.Append(latentStyleExceptionInfo528);
            latentStyles4.Append(latentStyleExceptionInfo529);
            latentStyles4.Append(latentStyleExceptionInfo530);
            latentStyles4.Append(latentStyleExceptionInfo531);
            latentStyles4.Append(latentStyleExceptionInfo532);
            latentStyles4.Append(latentStyleExceptionInfo533);
            latentStyles4.Append(latentStyleExceptionInfo534);
            latentStyles4.Append(latentStyleExceptionInfo535);
            latentStyles4.Append(latentStyleExceptionInfo536);
            latentStyles4.Append(latentStyleExceptionInfo537);
            latentStyles4.Append(latentStyleExceptionInfo538);
            latentStyles4.Append(latentStyleExceptionInfo539);
            latentStyles4.Append(latentStyleExceptionInfo540);
            latentStyles4.Append(latentStyleExceptionInfo541);
            latentStyles4.Append(latentStyleExceptionInfo542);
            latentStyles4.Append(latentStyleExceptionInfo543);
            latentStyles4.Append(latentStyleExceptionInfo544);
            latentStyles4.Append(latentStyleExceptionInfo545);
            latentStyles4.Append(latentStyleExceptionInfo546);
            latentStyles4.Append(latentStyleExceptionInfo547);
            latentStyles4.Append(latentStyleExceptionInfo548);

            Style style30 = new Style(){ Type = StyleValues.Paragraph, StyleId = "Normal", Default = true };
            StyleName styleName30 = new StyleName(){ Val = "Normal" };
            PrimaryStyle primaryStyle4 = new PrimaryStyle();

            StyleParagraphProperties styleParagraphProperties16 = new StyleParagraphProperties();
            WidowControl widowControl14 = new WidowControl(){ Val = false };
            Justification justification14 = new Justification(){ Val = JustificationValues.Both };

            styleParagraphProperties16.Append(widowControl14);
            styleParagraphProperties16.Append(justification14);

            style30.Append(styleName30);
            style30.Append(primaryStyle4);
            style30.Append(styleParagraphProperties16);

            Style style31 = new Style(){ Type = StyleValues.Character, StyleId = "DefaultParagraphFont", Default = true };
            StyleName styleName31 = new StyleName(){ Val = "Default Paragraph Font" };
            UIPriority uIPriority17 = new UIPriority(){ Val = 1 };
            SemiHidden semiHidden13 = new SemiHidden();
            UnhideWhenUsed unhideWhenUsed12 = new UnhideWhenUsed();

            style31.Append(styleName31);
            style31.Append(uIPriority17);
            style31.Append(semiHidden13);
            style31.Append(unhideWhenUsed12);

            Style style32 = new Style(){ Type = StyleValues.Table, StyleId = "TableNormal", Default = true };
            StyleName styleName32 = new StyleName(){ Val = "Normal Table" };
            UIPriority uIPriority18 = new UIPriority(){ Val = 99 };
            SemiHidden semiHidden14 = new SemiHidden();
            UnhideWhenUsed unhideWhenUsed13 = new UnhideWhenUsed();

            StyleTableProperties styleTableProperties4 = new StyleTableProperties();
            TableIndentation tableIndentation4 = new TableIndentation(){ Width = 0, Type = TableWidthUnitValues.Dxa };

            TableCellMarginDefault tableCellMarginDefault4 = new TableCellMarginDefault();
            TopMargin topMargin4 = new TopMargin(){ Width = "0", Type = TableWidthUnitValues.Dxa };
            TableCellLeftMargin tableCellLeftMargin4 = new TableCellLeftMargin(){ Width = 108, Type = TableWidthValues.Dxa };
            BottomMargin bottomMargin4 = new BottomMargin(){ Width = "0", Type = TableWidthUnitValues.Dxa };
            TableCellRightMargin tableCellRightMargin4 = new TableCellRightMargin(){ Width = 108, Type = TableWidthValues.Dxa };

            tableCellMarginDefault4.Append(topMargin4);
            tableCellMarginDefault4.Append(tableCellLeftMargin4);
            tableCellMarginDefault4.Append(bottomMargin4);
            tableCellMarginDefault4.Append(tableCellRightMargin4);

            styleTableProperties4.Append(tableIndentation4);
            styleTableProperties4.Append(tableCellMarginDefault4);

            style32.Append(styleName32);
            style32.Append(uIPriority18);
            style32.Append(semiHidden14);
            style32.Append(unhideWhenUsed13);
            style32.Append(styleTableProperties4);

            Style style33 = new Style(){ Type = StyleValues.Numbering, StyleId = "NoList", Default = true };
            StyleName styleName33 = new StyleName(){ Val = "No List" };
            UIPriority uIPriority19 = new UIPriority(){ Val = 99 };
            SemiHidden semiHidden15 = new SemiHidden();
            UnhideWhenUsed unhideWhenUsed14 = new UnhideWhenUsed();

            style33.Append(styleName33);
            style33.Append(uIPriority19);
            style33.Append(semiHidden15);
            style33.Append(unhideWhenUsed14);

            Style style34 = new Style(){ Type = StyleValues.Character, StyleId = "PlaceholderText" };
            StyleName styleName34 = new StyleName(){ Val = "Placeholder Text" };
            BasedOn basedOn8 = new BasedOn(){ Val = "DefaultParagraphFont" };
            UIPriority uIPriority20 = new UIPriority(){ Val = 99 };
            SemiHidden semiHidden16 = new SemiHidden();
            Rsid rsid39 = new Rsid(){ Val = "000010BA" };

            StyleRunProperties styleRunProperties4 = new StyleRunProperties();
            Color color5 = new Color(){ Val = "808080" };

            styleRunProperties4.Append(color5);

            style34.Append(styleName34);
            style34.Append(basedOn8);
            style34.Append(uIPriority20);
            style34.Append(semiHidden16);
            style34.Append(rsid39);
            style34.Append(styleRunProperties4);

            Style style35 = new Style(){ Type = StyleValues.Paragraph, StyleId = "Header" };
            StyleName styleName35 = new StyleName(){ Val = "header" };
            BasedOn basedOn9 = new BasedOn(){ Val = "Normal" };
            LinkedStyle linkedStyle5 = new LinkedStyle(){ Val = "HeaderChar" };
            UIPriority uIPriority21 = new UIPriority(){ Val = 99 };
            UnhideWhenUsed unhideWhenUsed15 = new UnhideWhenUsed();
            Rsid rsid40 = new Rsid(){ Val = "00E930A2" };

            StyleParagraphProperties styleParagraphProperties17 = new StyleParagraphProperties();

            Tabs tabs3 = new Tabs();
            TabStop tabStop5 = new TabStop(){ Val = TabStopValues.Center, Position = 4252 };
            TabStop tabStop6 = new TabStop(){ Val = TabStopValues.Right, Position = 8504 };

            tabs3.Append(tabStop5);
            tabs3.Append(tabStop6);
            SnapToGrid snapToGrid3 = new SnapToGrid(){ Val = false };

            styleParagraphProperties17.Append(tabs3);
            styleParagraphProperties17.Append(snapToGrid3);

            style35.Append(styleName35);
            style35.Append(basedOn9);
            style35.Append(linkedStyle5);
            style35.Append(uIPriority21);
            style35.Append(unhideWhenUsed15);
            style35.Append(rsid40);
            style35.Append(styleParagraphProperties17);

            Style style36 = new Style(){ Type = StyleValues.Character, StyleId = "HeaderChar", CustomStyle = true };
            StyleName styleName36 = new StyleName(){ Val = "Header Char" };
            BasedOn basedOn10 = new BasedOn(){ Val = "DefaultParagraphFont" };
            LinkedStyle linkedStyle6 = new LinkedStyle(){ Val = "Header" };
            UIPriority uIPriority22 = new UIPriority(){ Val = 99 };
            Rsid rsid41 = new Rsid(){ Val = "00E930A2" };

            style36.Append(styleName36);
            style36.Append(basedOn10);
            style36.Append(linkedStyle6);
            style36.Append(uIPriority22);
            style36.Append(rsid41);

            Style style37 = new Style(){ Type = StyleValues.Paragraph, StyleId = "Footer" };
            StyleName styleName37 = new StyleName(){ Val = "footer" };
            BasedOn basedOn11 = new BasedOn(){ Val = "Normal" };
            LinkedStyle linkedStyle7 = new LinkedStyle(){ Val = "FooterChar" };
            UIPriority uIPriority23 = new UIPriority(){ Val = 99 };
            UnhideWhenUsed unhideWhenUsed16 = new UnhideWhenUsed();
            Rsid rsid42 = new Rsid(){ Val = "00E930A2" };

            StyleParagraphProperties styleParagraphProperties18 = new StyleParagraphProperties();

            Tabs tabs4 = new Tabs();
            TabStop tabStop7 = new TabStop(){ Val = TabStopValues.Center, Position = 4252 };
            TabStop tabStop8 = new TabStop(){ Val = TabStopValues.Right, Position = 8504 };

            tabs4.Append(tabStop7);
            tabs4.Append(tabStop8);
            SnapToGrid snapToGrid4 = new SnapToGrid(){ Val = false };

            styleParagraphProperties18.Append(tabs4);
            styleParagraphProperties18.Append(snapToGrid4);

            style37.Append(styleName37);
            style37.Append(basedOn11);
            style37.Append(linkedStyle7);
            style37.Append(uIPriority23);
            style37.Append(unhideWhenUsed16);
            style37.Append(rsid42);
            style37.Append(styleParagraphProperties18);

            Style style38 = new Style(){ Type = StyleValues.Character, StyleId = "FooterChar", CustomStyle = true };
            StyleName styleName38 = new StyleName(){ Val = "Footer Char" };
            BasedOn basedOn12 = new BasedOn(){ Val = "DefaultParagraphFont" };
            LinkedStyle linkedStyle8 = new LinkedStyle(){ Val = "Footer" };
            UIPriority uIPriority24 = new UIPriority(){ Val = 99 };
            Rsid rsid43 = new Rsid(){ Val = "00E930A2" };

            style38.Append(styleName38);
            style38.Append(basedOn12);
            style38.Append(linkedStyle8);
            style38.Append(uIPriority24);
            style38.Append(rsid43);

            styles4.Append(docDefaults4);
            styles4.Append(latentStyles4);
            styles4.Append(style30);
            styles4.Append(style31);
            styles4.Append(style32);
            styles4.Append(style33);
            styles4.Append(style34);
            styles4.Append(style35);
            styles4.Append(style36);
            styles4.Append(style37);
            styles4.Append(style38);

            styleDefinitionsPart2.Styles = styles4;
        }

        // Generates content of endnotesPart1.
        private void GenerateEndnotesPart1Content(EndnotesPart endnotesPart1)
        {
            Endnotes endnotes1 = new Endnotes(){ MCAttributes = new MarkupCompatibilityAttributes(){ Ignorable = "w14 w15 wp14" }  };
            endnotes1.AddNamespaceDeclaration("wpc", "http://schemas.microsoft.com/office/word/2010/wordprocessingCanvas");
            endnotes1.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            endnotes1.AddNamespaceDeclaration("o", "urn:schemas-microsoft-com:office:office");
            endnotes1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            endnotes1.AddNamespaceDeclaration("m", "http://schemas.openxmlformats.org/officeDocument/2006/math");
            endnotes1.AddNamespaceDeclaration("v", "urn:schemas-microsoft-com:vml");
            endnotes1.AddNamespaceDeclaration("wp14", "http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing");
            endnotes1.AddNamespaceDeclaration("wp", "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing");
            endnotes1.AddNamespaceDeclaration("w10", "urn:schemas-microsoft-com:office:word");
            endnotes1.AddNamespaceDeclaration("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main");
            endnotes1.AddNamespaceDeclaration("w14", "http://schemas.microsoft.com/office/word/2010/wordml");
            endnotes1.AddNamespaceDeclaration("w15", "http://schemas.microsoft.com/office/word/2010/11/wordml");
            endnotes1.AddNamespaceDeclaration("wpg", "http://schemas.microsoft.com/office/word/2010/wordprocessingGroup");
            endnotes1.AddNamespaceDeclaration("wpi", "http://schemas.microsoft.com/office/word/2010/wordprocessingInk");
            endnotes1.AddNamespaceDeclaration("wne", "http://schemas.microsoft.com/office/word/2006/wordml");
            endnotes1.AddNamespaceDeclaration("wps", "http://schemas.microsoft.com/office/word/2010/wordprocessingShape");

            Endnote endnote1 = new Endnote(){ Type = FootnoteEndnoteValues.Separator, Id = -1 };

            Paragraph paragraph23 = new Paragraph(){ RsidParagraphAddition = "00DC649D", RsidParagraphProperties = "00E930A2", RsidRunAdditionDefault = "00DC649D" };

            Run run29 = new Run();
            SeparatorMark separatorMark1 = new SeparatorMark();

            run29.Append(separatorMark1);

            paragraph23.Append(run29);

            endnote1.Append(paragraph23);

            Endnote endnote2 = new Endnote(){ Type = FootnoteEndnoteValues.ContinuationSeparator, Id = 0 };

            Paragraph paragraph24 = new Paragraph(){ RsidParagraphAddition = "00DC649D", RsidParagraphProperties = "00E930A2", RsidRunAdditionDefault = "00DC649D" };

            Run run30 = new Run();
            ContinuationSeparatorMark continuationSeparatorMark1 = new ContinuationSeparatorMark();

            run30.Append(continuationSeparatorMark1);

            paragraph24.Append(run30);

            endnote2.Append(paragraph24);

            endnotes1.Append(endnote1);
            endnotes1.Append(endnote2);

            endnotesPart1.Endnotes = endnotes1;
        }

        // Generates content of footnotesPart1.
        private void GenerateFootnotesPart1Content(FootnotesPart footnotesPart1)
        {
            Footnotes footnotes1 = new Footnotes(){ MCAttributes = new MarkupCompatibilityAttributes(){ Ignorable = "w14 w15 wp14" }  };
            footnotes1.AddNamespaceDeclaration("wpc", "http://schemas.microsoft.com/office/word/2010/wordprocessingCanvas");
            footnotes1.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            footnotes1.AddNamespaceDeclaration("o", "urn:schemas-microsoft-com:office:office");
            footnotes1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            footnotes1.AddNamespaceDeclaration("m", "http://schemas.openxmlformats.org/officeDocument/2006/math");
            footnotes1.AddNamespaceDeclaration("v", "urn:schemas-microsoft-com:vml");
            footnotes1.AddNamespaceDeclaration("wp14", "http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing");
            footnotes1.AddNamespaceDeclaration("wp", "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing");
            footnotes1.AddNamespaceDeclaration("w10", "urn:schemas-microsoft-com:office:word");
            footnotes1.AddNamespaceDeclaration("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main");
            footnotes1.AddNamespaceDeclaration("w14", "http://schemas.microsoft.com/office/word/2010/wordml");
            footnotes1.AddNamespaceDeclaration("w15", "http://schemas.microsoft.com/office/word/2010/11/wordml");
            footnotes1.AddNamespaceDeclaration("wpg", "http://schemas.microsoft.com/office/word/2010/wordprocessingGroup");
            footnotes1.AddNamespaceDeclaration("wpi", "http://schemas.microsoft.com/office/word/2010/wordprocessingInk");
            footnotes1.AddNamespaceDeclaration("wne", "http://schemas.microsoft.com/office/word/2006/wordml");
            footnotes1.AddNamespaceDeclaration("wps", "http://schemas.microsoft.com/office/word/2010/wordprocessingShape");

            Footnote footnote1 = new Footnote(){ Type = FootnoteEndnoteValues.Separator, Id = -1 };

            Paragraph paragraph25 = new Paragraph(){ RsidParagraphAddition = "00DC649D", RsidParagraphProperties = "00E930A2", RsidRunAdditionDefault = "00DC649D" };

            Run run31 = new Run();
            SeparatorMark separatorMark2 = new SeparatorMark();

            run31.Append(separatorMark2);

            paragraph25.Append(run31);

            footnote1.Append(paragraph25);

            Footnote footnote2 = new Footnote(){ Type = FootnoteEndnoteValues.ContinuationSeparator, Id = 0 };

            Paragraph paragraph26 = new Paragraph(){ RsidParagraphAddition = "00DC649D", RsidParagraphProperties = "00E930A2", RsidRunAdditionDefault = "00DC649D" };

            Run run32 = new Run();
            ContinuationSeparatorMark continuationSeparatorMark2 = new ContinuationSeparatorMark();

            run32.Append(continuationSeparatorMark2);

            paragraph26.Append(run32);

            footnote2.Append(paragraph26);

            footnotes1.Append(footnote1);
            footnotes1.Append(footnote2);

            footnotesPart1.Footnotes = footnotes1;
        }

        // Generates content of webSettingsPart2.
        private void GenerateWebSettingsPart2Content(WebSettingsPart webSettingsPart2)
        {
            WebSettings webSettings2 = new WebSettings(){ MCAttributes = new MarkupCompatibilityAttributes(){ Ignorable = "w14 w15" }  };
            webSettings2.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            webSettings2.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            webSettings2.AddNamespaceDeclaration("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main");
            webSettings2.AddNamespaceDeclaration("w14", "http://schemas.microsoft.com/office/word/2010/wordml");
            webSettings2.AddNamespaceDeclaration("w15", "http://schemas.microsoft.com/office/word/2010/11/wordml");
            OptimizeForBrowser optimizeForBrowser2 = new OptimizeForBrowser();
            AllowPNG allowPNG2 = new AllowPNG();

            webSettings2.Append(optimizeForBrowser2);
            webSettings2.Append(allowPNG2);

            webSettingsPart2.WebSettings = webSettings2;
        }

        // Generates content of themePart1.
        private void GenerateThemePart1Content(ThemePart themePart1)
        {
            A.Theme theme1 = new A.Theme(){ Name = "Office Theme", ThemeId = "{62F939B6-93AF-4DB8-9C6B-D6C7DFDC589F}", MCAttributes = new MarkupCompatibilityAttributes(){ Ignorable = "thm15" }  };
            theme1.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");
            theme1.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            theme1.AddNamespaceDeclaration("thm15", "http://schemas.microsoft.com/office/thememl/2012/main");

            A.ThemeElements themeElements1 = new A.ThemeElements();

            A.ColorScheme colorScheme1 = new A.ColorScheme(){ Name = "Office" };

            A.Dark1Color dark1Color1 = new A.Dark1Color();
            A.SystemColor systemColor1 = new A.SystemColor(){ Val = A.SystemColorValues.WindowText, LastColor = "000000" };

            dark1Color1.Append(systemColor1);

            A.Light1Color light1Color1 = new A.Light1Color();
            A.SystemColor systemColor2 = new A.SystemColor(){ Val = A.SystemColorValues.Window, LastColor = "FFFFFF" };

            light1Color1.Append(systemColor2);

            A.Dark2Color dark2Color1 = new A.Dark2Color();
            A.RgbColorModelHex rgbColorModelHex1 = new A.RgbColorModelHex(){ Val = "6E747A" };

            dark2Color1.Append(rgbColorModelHex1);

            A.Light2Color light2Color1 = new A.Light2Color();
            A.RgbColorModelHex rgbColorModelHex2 = new A.RgbColorModelHex(){ Val = "E7E6E6" };

            light2Color1.Append(rgbColorModelHex2);

            A.Accent1Color accent1Color1 = new A.Accent1Color();
            A.RgbColorModelHex rgbColorModelHex3 = new A.RgbColorModelHex(){ Val = "5B9BD5" };

            accent1Color1.Append(rgbColorModelHex3);

            A.Accent2Color accent2Color1 = new A.Accent2Color();
            A.RgbColorModelHex rgbColorModelHex4 = new A.RgbColorModelHex(){ Val = "ED7D31" };

            accent2Color1.Append(rgbColorModelHex4);

            A.Accent3Color accent3Color1 = new A.Accent3Color();
            A.RgbColorModelHex rgbColorModelHex5 = new A.RgbColorModelHex(){ Val = "A5A5A5" };

            accent3Color1.Append(rgbColorModelHex5);

            A.Accent4Color accent4Color1 = new A.Accent4Color();
            A.RgbColorModelHex rgbColorModelHex6 = new A.RgbColorModelHex(){ Val = "FFC000" };

            accent4Color1.Append(rgbColorModelHex6);

            A.Accent5Color accent5Color1 = new A.Accent5Color();
            A.RgbColorModelHex rgbColorModelHex7 = new A.RgbColorModelHex(){ Val = "4472C4" };

            accent5Color1.Append(rgbColorModelHex7);

            A.Accent6Color accent6Color1 = new A.Accent6Color();
            A.RgbColorModelHex rgbColorModelHex8 = new A.RgbColorModelHex(){ Val = "70AD47" };

            accent6Color1.Append(rgbColorModelHex8);

            A.Hyperlink hyperlink1 = new A.Hyperlink();
            A.RgbColorModelHex rgbColorModelHex9 = new A.RgbColorModelHex(){ Val = "085296" };

            hyperlink1.Append(rgbColorModelHex9);

            A.FollowedHyperlinkColor followedHyperlinkColor1 = new A.FollowedHyperlinkColor();
            A.RgbColorModelHex rgbColorModelHex10 = new A.RgbColorModelHex(){ Val = "993366" };

            followedHyperlinkColor1.Append(rgbColorModelHex10);

            colorScheme1.Append(dark1Color1);
            colorScheme1.Append(light1Color1);
            colorScheme1.Append(dark2Color1);
            colorScheme1.Append(light2Color1);
            colorScheme1.Append(accent1Color1);
            colorScheme1.Append(accent2Color1);
            colorScheme1.Append(accent3Color1);
            colorScheme1.Append(accent4Color1);
            colorScheme1.Append(accent5Color1);
            colorScheme1.Append(accent6Color1);
            colorScheme1.Append(hyperlink1);
            colorScheme1.Append(followedHyperlinkColor1);

            A.FontScheme fontScheme1 = new A.FontScheme(){ Name = "Office" };

            A.MajorFont majorFont1 = new A.MajorFont();
            A.LatinFont latinFont1 = new A.LatinFont(){ Typeface = "Arial" };
            A.EastAsianFont eastAsianFont1 = new A.EastAsianFont(){ Typeface = "" };
            A.ComplexScriptFont complexScriptFont1 = new A.ComplexScriptFont(){ Typeface = "" };
            A.SupplementalFont supplementalFont1 = new A.SupplementalFont(){ Script = "Jpan", Typeface = "ＭＳ ゴシック" };
            A.SupplementalFont supplementalFont2 = new A.SupplementalFont(){ Script = "Hang", Typeface = "맑은 고딕" };
            A.SupplementalFont supplementalFont3 = new A.SupplementalFont(){ Script = "Hans", Typeface = "宋体" };
            A.SupplementalFont supplementalFont4 = new A.SupplementalFont(){ Script = "Hant", Typeface = "新細明體" };
            A.SupplementalFont supplementalFont5 = new A.SupplementalFont(){ Script = "Arab", Typeface = "Times New Roman" };
            A.SupplementalFont supplementalFont6 = new A.SupplementalFont(){ Script = "Hebr", Typeface = "Times New Roman" };
            A.SupplementalFont supplementalFont7 = new A.SupplementalFont(){ Script = "Thai", Typeface = "Angsana New" };
            A.SupplementalFont supplementalFont8 = new A.SupplementalFont(){ Script = "Ethi", Typeface = "Nyala" };
            A.SupplementalFont supplementalFont9 = new A.SupplementalFont(){ Script = "Beng", Typeface = "Vrinda" };
            A.SupplementalFont supplementalFont10 = new A.SupplementalFont(){ Script = "Gujr", Typeface = "Shruti" };
            A.SupplementalFont supplementalFont11 = new A.SupplementalFont(){ Script = "Khmr", Typeface = "MoolBoran" };
            A.SupplementalFont supplementalFont12 = new A.SupplementalFont(){ Script = "Knda", Typeface = "Tunga" };
            A.SupplementalFont supplementalFont13 = new A.SupplementalFont(){ Script = "Guru", Typeface = "Raavi" };
            A.SupplementalFont supplementalFont14 = new A.SupplementalFont(){ Script = "Cans", Typeface = "Euphemia" };
            A.SupplementalFont supplementalFont15 = new A.SupplementalFont(){ Script = "Cher", Typeface = "Plantagenet Cherokee" };
            A.SupplementalFont supplementalFont16 = new A.SupplementalFont(){ Script = "Yiii", Typeface = "Microsoft Yi Baiti" };
            A.SupplementalFont supplementalFont17 = new A.SupplementalFont(){ Script = "Tibt", Typeface = "Microsoft Himalaya" };
            A.SupplementalFont supplementalFont18 = new A.SupplementalFont(){ Script = "Thaa", Typeface = "MV Boli" };
            A.SupplementalFont supplementalFont19 = new A.SupplementalFont(){ Script = "Deva", Typeface = "Mangal" };
            A.SupplementalFont supplementalFont20 = new A.SupplementalFont(){ Script = "Telu", Typeface = "Gautami" };
            A.SupplementalFont supplementalFont21 = new A.SupplementalFont(){ Script = "Taml", Typeface = "Latha" };
            A.SupplementalFont supplementalFont22 = new A.SupplementalFont(){ Script = "Syrc", Typeface = "Estrangelo Edessa" };
            A.SupplementalFont supplementalFont23 = new A.SupplementalFont(){ Script = "Orya", Typeface = "Kalinga" };
            A.SupplementalFont supplementalFont24 = new A.SupplementalFont(){ Script = "Mlym", Typeface = "Kartika" };
            A.SupplementalFont supplementalFont25 = new A.SupplementalFont(){ Script = "Laoo", Typeface = "DokChampa" };
            A.SupplementalFont supplementalFont26 = new A.SupplementalFont(){ Script = "Sinh", Typeface = "Iskoola Pota" };
            A.SupplementalFont supplementalFont27 = new A.SupplementalFont(){ Script = "Mong", Typeface = "Mongolian Baiti" };
            A.SupplementalFont supplementalFont28 = new A.SupplementalFont(){ Script = "Viet", Typeface = "Times New Roman" };
            A.SupplementalFont supplementalFont29 = new A.SupplementalFont(){ Script = "Uigh", Typeface = "Microsoft Uighur" };
            A.SupplementalFont supplementalFont30 = new A.SupplementalFont(){ Script = "Geor", Typeface = "Sylfaen" };

            majorFont1.Append(latinFont1);
            majorFont1.Append(eastAsianFont1);
            majorFont1.Append(complexScriptFont1);
            majorFont1.Append(supplementalFont1);
            majorFont1.Append(supplementalFont2);
            majorFont1.Append(supplementalFont3);
            majorFont1.Append(supplementalFont4);
            majorFont1.Append(supplementalFont5);
            majorFont1.Append(supplementalFont6);
            majorFont1.Append(supplementalFont7);
            majorFont1.Append(supplementalFont8);
            majorFont1.Append(supplementalFont9);
            majorFont1.Append(supplementalFont10);
            majorFont1.Append(supplementalFont11);
            majorFont1.Append(supplementalFont12);
            majorFont1.Append(supplementalFont13);
            majorFont1.Append(supplementalFont14);
            majorFont1.Append(supplementalFont15);
            majorFont1.Append(supplementalFont16);
            majorFont1.Append(supplementalFont17);
            majorFont1.Append(supplementalFont18);
            majorFont1.Append(supplementalFont19);
            majorFont1.Append(supplementalFont20);
            majorFont1.Append(supplementalFont21);
            majorFont1.Append(supplementalFont22);
            majorFont1.Append(supplementalFont23);
            majorFont1.Append(supplementalFont24);
            majorFont1.Append(supplementalFont25);
            majorFont1.Append(supplementalFont26);
            majorFont1.Append(supplementalFont27);
            majorFont1.Append(supplementalFont28);
            majorFont1.Append(supplementalFont29);
            majorFont1.Append(supplementalFont30);

            A.MinorFont minorFont1 = new A.MinorFont();
            A.LatinFont latinFont2 = new A.LatinFont(){ Typeface = "Century" };
            A.EastAsianFont eastAsianFont2 = new A.EastAsianFont(){ Typeface = "" };
            A.ComplexScriptFont complexScriptFont2 = new A.ComplexScriptFont(){ Typeface = "" };
            A.SupplementalFont supplementalFont31 = new A.SupplementalFont(){ Script = "Jpan", Typeface = "ＭＳ 明朝" };
            A.SupplementalFont supplementalFont32 = new A.SupplementalFont(){ Script = "Hang", Typeface = "맑은 고딕" };
            A.SupplementalFont supplementalFont33 = new A.SupplementalFont(){ Script = "Hans", Typeface = "宋体" };
            A.SupplementalFont supplementalFont34 = new A.SupplementalFont(){ Script = "Hant", Typeface = "新細明體" };
            A.SupplementalFont supplementalFont35 = new A.SupplementalFont(){ Script = "Arab", Typeface = "Arial" };
            A.SupplementalFont supplementalFont36 = new A.SupplementalFont(){ Script = "Hebr", Typeface = "Arial" };
            A.SupplementalFont supplementalFont37 = new A.SupplementalFont(){ Script = "Thai", Typeface = "Cordia New" };
            A.SupplementalFont supplementalFont38 = new A.SupplementalFont(){ Script = "Ethi", Typeface = "Nyala" };
            A.SupplementalFont supplementalFont39 = new A.SupplementalFont(){ Script = "Beng", Typeface = "Vrinda" };
            A.SupplementalFont supplementalFont40 = new A.SupplementalFont(){ Script = "Gujr", Typeface = "Shruti" };
            A.SupplementalFont supplementalFont41 = new A.SupplementalFont(){ Script = "Khmr", Typeface = "DaunPenh" };
            A.SupplementalFont supplementalFont42 = new A.SupplementalFont(){ Script = "Knda", Typeface = "Tunga" };
            A.SupplementalFont supplementalFont43 = new A.SupplementalFont(){ Script = "Guru", Typeface = "Raavi" };
            A.SupplementalFont supplementalFont44 = new A.SupplementalFont(){ Script = "Cans", Typeface = "Euphemia" };
            A.SupplementalFont supplementalFont45 = new A.SupplementalFont(){ Script = "Cher", Typeface = "Plantagenet Cherokee" };
            A.SupplementalFont supplementalFont46 = new A.SupplementalFont(){ Script = "Yiii", Typeface = "Microsoft Yi Baiti" };
            A.SupplementalFont supplementalFont47 = new A.SupplementalFont(){ Script = "Tibt", Typeface = "Microsoft Himalaya" };
            A.SupplementalFont supplementalFont48 = new A.SupplementalFont(){ Script = "Thaa", Typeface = "MV Boli" };
            A.SupplementalFont supplementalFont49 = new A.SupplementalFont(){ Script = "Deva", Typeface = "Mangal" };
            A.SupplementalFont supplementalFont50 = new A.SupplementalFont(){ Script = "Telu", Typeface = "Gautami" };
            A.SupplementalFont supplementalFont51 = new A.SupplementalFont(){ Script = "Taml", Typeface = "Latha" };
            A.SupplementalFont supplementalFont52 = new A.SupplementalFont(){ Script = "Syrc", Typeface = "Estrangelo Edessa" };
            A.SupplementalFont supplementalFont53 = new A.SupplementalFont(){ Script = "Orya", Typeface = "Kalinga" };
            A.SupplementalFont supplementalFont54 = new A.SupplementalFont(){ Script = "Mlym", Typeface = "Kartika" };
            A.SupplementalFont supplementalFont55 = new A.SupplementalFont(){ Script = "Laoo", Typeface = "DokChampa" };
            A.SupplementalFont supplementalFont56 = new A.SupplementalFont(){ Script = "Sinh", Typeface = "Iskoola Pota" };
            A.SupplementalFont supplementalFont57 = new A.SupplementalFont(){ Script = "Mong", Typeface = "Mongolian Baiti" };
            A.SupplementalFont supplementalFont58 = new A.SupplementalFont(){ Script = "Viet", Typeface = "Arial" };
            A.SupplementalFont supplementalFont59 = new A.SupplementalFont(){ Script = "Uigh", Typeface = "Microsoft Uighur" };
            A.SupplementalFont supplementalFont60 = new A.SupplementalFont(){ Script = "Geor", Typeface = "Sylfaen" };

            minorFont1.Append(latinFont2);
            minorFont1.Append(eastAsianFont2);
            minorFont1.Append(complexScriptFont2);
            minorFont1.Append(supplementalFont31);
            minorFont1.Append(supplementalFont32);
            minorFont1.Append(supplementalFont33);
            minorFont1.Append(supplementalFont34);
            minorFont1.Append(supplementalFont35);
            minorFont1.Append(supplementalFont36);
            minorFont1.Append(supplementalFont37);
            minorFont1.Append(supplementalFont38);
            minorFont1.Append(supplementalFont39);
            minorFont1.Append(supplementalFont40);
            minorFont1.Append(supplementalFont41);
            minorFont1.Append(supplementalFont42);
            minorFont1.Append(supplementalFont43);
            minorFont1.Append(supplementalFont44);
            minorFont1.Append(supplementalFont45);
            minorFont1.Append(supplementalFont46);
            minorFont1.Append(supplementalFont47);
            minorFont1.Append(supplementalFont48);
            minorFont1.Append(supplementalFont49);
            minorFont1.Append(supplementalFont50);
            minorFont1.Append(supplementalFont51);
            minorFont1.Append(supplementalFont52);
            minorFont1.Append(supplementalFont53);
            minorFont1.Append(supplementalFont54);
            minorFont1.Append(supplementalFont55);
            minorFont1.Append(supplementalFont56);
            minorFont1.Append(supplementalFont57);
            minorFont1.Append(supplementalFont58);
            minorFont1.Append(supplementalFont59);
            minorFont1.Append(supplementalFont60);

            fontScheme1.Append(majorFont1);
            fontScheme1.Append(minorFont1);

            A.FormatScheme formatScheme1 = new A.FormatScheme(){ Name = "Office" };

            A.FillStyleList fillStyleList1 = new A.FillStyleList();

            A.SolidFill solidFill1 = new A.SolidFill();
            A.SchemeColor schemeColor1 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };

            solidFill1.Append(schemeColor1);

            A.GradientFill gradientFill1 = new A.GradientFill(){ RotateWithShape = true };

            A.GradientStopList gradientStopList1 = new A.GradientStopList();

            A.GradientStop gradientStop1 = new A.GradientStop(){ Position = 0 };

            A.SchemeColor schemeColor2 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.LuminanceModulation luminanceModulation1 = new A.LuminanceModulation(){ Val = 157000 };
            A.SaturationModulation saturationModulation1 = new A.SaturationModulation(){ Val = 101000 };

            schemeColor2.Append(luminanceModulation1);
            schemeColor2.Append(saturationModulation1);

            gradientStop1.Append(schemeColor2);

            A.GradientStop gradientStop2 = new A.GradientStop(){ Position = 50000 };

            A.SchemeColor schemeColor3 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.LuminanceModulation luminanceModulation2 = new A.LuminanceModulation(){ Val = 137000 };
            A.SaturationModulation saturationModulation2 = new A.SaturationModulation(){ Val = 103000 };

            schemeColor3.Append(luminanceModulation2);
            schemeColor3.Append(saturationModulation2);

            gradientStop2.Append(schemeColor3);

            A.GradientStop gradientStop3 = new A.GradientStop(){ Position = 100000 };

            A.SchemeColor schemeColor4 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.LuminanceModulation luminanceModulation3 = new A.LuminanceModulation(){ Val = 115000 };
            A.SaturationModulation saturationModulation3 = new A.SaturationModulation(){ Val = 109000 };

            schemeColor4.Append(luminanceModulation3);
            schemeColor4.Append(saturationModulation3);

            gradientStop3.Append(schemeColor4);

            gradientStopList1.Append(gradientStop1);
            gradientStopList1.Append(gradientStop2);
            gradientStopList1.Append(gradientStop3);
            A.LinearGradientFill linearGradientFill1 = new A.LinearGradientFill(){ Angle = 5400000, Scaled = false };

            gradientFill1.Append(gradientStopList1);
            gradientFill1.Append(linearGradientFill1);

            A.GradientFill gradientFill2 = new A.GradientFill(){ RotateWithShape = true };

            A.GradientStopList gradientStopList2 = new A.GradientStopList();

            A.GradientStop gradientStop4 = new A.GradientStop(){ Position = 0 };

            A.SchemeColor schemeColor5 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.SaturationModulation saturationModulation4 = new A.SaturationModulation(){ Val = 103000 };
            A.LuminanceModulation luminanceModulation4 = new A.LuminanceModulation(){ Val = 118000 };

            schemeColor5.Append(saturationModulation4);
            schemeColor5.Append(luminanceModulation4);

            gradientStop4.Append(schemeColor5);

            A.GradientStop gradientStop5 = new A.GradientStop(){ Position = 50000 };

            A.SchemeColor schemeColor6 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.SaturationModulation saturationModulation5 = new A.SaturationModulation(){ Val = 89000 };
            A.LuminanceModulation luminanceModulation5 = new A.LuminanceModulation(){ Val = 91000 };

            schemeColor6.Append(saturationModulation5);
            schemeColor6.Append(luminanceModulation5);

            gradientStop5.Append(schemeColor6);

            A.GradientStop gradientStop6 = new A.GradientStop(){ Position = 100000 };

            A.SchemeColor schemeColor7 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.LuminanceModulation luminanceModulation6 = new A.LuminanceModulation(){ Val = 69000 };

            schemeColor7.Append(luminanceModulation6);

            gradientStop6.Append(schemeColor7);

            gradientStopList2.Append(gradientStop4);
            gradientStopList2.Append(gradientStop5);
            gradientStopList2.Append(gradientStop6);
            A.LinearGradientFill linearGradientFill2 = new A.LinearGradientFill(){ Angle = 5400000, Scaled = false };

            gradientFill2.Append(gradientStopList2);
            gradientFill2.Append(linearGradientFill2);

            fillStyleList1.Append(solidFill1);
            fillStyleList1.Append(gradientFill1);
            fillStyleList1.Append(gradientFill2);

            A.LineStyleList lineStyleList1 = new A.LineStyleList();

            A.Outline outline1 = new A.Outline(){ Width = 6350, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            A.SolidFill solidFill2 = new A.SolidFill();
            A.SchemeColor schemeColor8 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };

            solidFill2.Append(schemeColor8);
            A.PresetDash presetDash1 = new A.PresetDash(){ Val = A.PresetLineDashValues.Solid };

            outline1.Append(solidFill2);
            outline1.Append(presetDash1);

            A.Outline outline2 = new A.Outline(){ Width = 12700, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            A.SolidFill solidFill3 = new A.SolidFill();
            A.SchemeColor schemeColor9 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };

            solidFill3.Append(schemeColor9);
            A.PresetDash presetDash2 = new A.PresetDash(){ Val = A.PresetLineDashValues.Solid };

            outline2.Append(solidFill3);
            outline2.Append(presetDash2);

            A.Outline outline3 = new A.Outline(){ Width = 19050, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            A.SolidFill solidFill4 = new A.SolidFill();
            A.SchemeColor schemeColor10 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };

            solidFill4.Append(schemeColor10);
            A.PresetDash presetDash3 = new A.PresetDash(){ Val = A.PresetLineDashValues.Solid };

            outline3.Append(solidFill4);
            outline3.Append(presetDash3);

            lineStyleList1.Append(outline1);
            lineStyleList1.Append(outline2);
            lineStyleList1.Append(outline3);

            A.EffectStyleList effectStyleList1 = new A.EffectStyleList();

            A.EffectStyle effectStyle1 = new A.EffectStyle();
            A.EffectList effectList1 = new A.EffectList();

            effectStyle1.Append(effectList1);

            A.EffectStyle effectStyle2 = new A.EffectStyle();
            A.EffectList effectList2 = new A.EffectList();

            effectStyle2.Append(effectList2);

            A.EffectStyle effectStyle3 = new A.EffectStyle();

            A.EffectList effectList3 = new A.EffectList();

            A.OuterShadow outerShadow1 = new A.OuterShadow(){ BlurRadius = 57150L, Distance = 19050L, Direction = 5400000, Alignment = A.RectangleAlignmentValues.Center, RotateWithShape = false };

            A.RgbColorModelHex rgbColorModelHex11 = new A.RgbColorModelHex(){ Val = "000000" };
            A.Alpha alpha1 = new A.Alpha(){ Val = 63000 };

            rgbColorModelHex11.Append(alpha1);

            outerShadow1.Append(rgbColorModelHex11);

            effectList3.Append(outerShadow1);

            effectStyle3.Append(effectList3);

            effectStyleList1.Append(effectStyle1);
            effectStyleList1.Append(effectStyle2);
            effectStyleList1.Append(effectStyle3);

            A.BackgroundFillStyleList backgroundFillStyleList1 = new A.BackgroundFillStyleList();

            A.SolidFill solidFill5 = new A.SolidFill();
            A.SchemeColor schemeColor11 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };

            solidFill5.Append(schemeColor11);

            A.GradientFill gradientFill3 = new A.GradientFill(){ RotateWithShape = true };

            A.GradientStopList gradientStopList3 = new A.GradientStopList();

            A.GradientStop gradientStop7 = new A.GradientStop(){ Position = 0 };

            A.SchemeColor schemeColor12 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.Tint tint1 = new A.Tint(){ Val = 100000 };
            A.SaturationModulation saturationModulation6 = new A.SaturationModulation(){ Val = 100000 };
            A.Shade shade1 = new A.Shade(){ Val = 0 };

            schemeColor12.Append(tint1);
            schemeColor12.Append(saturationModulation6);
            schemeColor12.Append(shade1);

            gradientStop7.Append(schemeColor12);

            A.GradientStop gradientStop8 = new A.GradientStop(){ Position = 0 };
            A.RgbColorModelPercentage rgbColorModelPercentage1 = new A.RgbColorModelPercentage(){ RedPortion = 0, GreenPortion = 0, BluePortion = 0 };

            gradientStop8.Append(rgbColorModelPercentage1);

            A.GradientStop gradientStop9 = new A.GradientStop(){ Position = 100000 };

            A.SchemeColor schemeColor13 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.Shade shade2 = new A.Shade(){ Val = 100000 };
            A.SaturationModulation saturationModulation7 = new A.SaturationModulation(){ Val = 100000 };

            schemeColor13.Append(shade2);
            schemeColor13.Append(saturationModulation7);

            gradientStop9.Append(schemeColor13);

            gradientStopList3.Append(gradientStop7);
            gradientStopList3.Append(gradientStop8);
            gradientStopList3.Append(gradientStop9);
            A.LinearGradientFill linearGradientFill3 = new A.LinearGradientFill(){ Angle = 5400000, Scaled = false };

            gradientFill3.Append(gradientStopList3);
            gradientFill3.Append(linearGradientFill3);

            A.GradientFill gradientFill4 = new A.GradientFill(){ RotateWithShape = true };

            A.GradientStopList gradientStopList4 = new A.GradientStopList();

            A.GradientStop gradientStop10 = new A.GradientStop(){ Position = 0 };

            A.SchemeColor schemeColor14 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.Tint tint2 = new A.Tint(){ Val = 80000 };
            A.SaturationModulation saturationModulation8 = new A.SaturationModulation(){ Val = 300000 };

            schemeColor14.Append(tint2);
            schemeColor14.Append(saturationModulation8);

            gradientStop10.Append(schemeColor14);

            A.GradientStop gradientStop11 = new A.GradientStop(){ Position = 100000 };

            A.SchemeColor schemeColor15 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.Shade shade3 = new A.Shade(){ Val = 30000 };
            A.SaturationModulation saturationModulation9 = new A.SaturationModulation(){ Val = 200000 };

            schemeColor15.Append(shade3);
            schemeColor15.Append(saturationModulation9);

            gradientStop11.Append(schemeColor15);

            gradientStopList4.Append(gradientStop10);
            gradientStopList4.Append(gradientStop11);

            A.PathGradientFill pathGradientFill1 = new A.PathGradientFill(){ Path = A.PathShadeValues.Circle };
            A.FillToRectangle fillToRectangle1 = new A.FillToRectangle(){ Left = 50000, Top = 50000, Right = 50000, Bottom = 50000 };

            pathGradientFill1.Append(fillToRectangle1);

            gradientFill4.Append(gradientStopList4);
            gradientFill4.Append(pathGradientFill1);

            backgroundFillStyleList1.Append(solidFill5);
            backgroundFillStyleList1.Append(gradientFill3);
            backgroundFillStyleList1.Append(gradientFill4);

            formatScheme1.Append(fillStyleList1);
            formatScheme1.Append(lineStyleList1);
            formatScheme1.Append(effectStyleList1);
            formatScheme1.Append(backgroundFillStyleList1);

            themeElements1.Append(colorScheme1);
            themeElements1.Append(fontScheme1);
            themeElements1.Append(formatScheme1);
            A.ObjectDefaults objectDefaults1 = new A.ObjectDefaults();
            A.ExtraColorSchemeList extraColorSchemeList1 = new A.ExtraColorSchemeList();

            theme1.Append(themeElements1);
            theme1.Append(objectDefaults1);
            theme1.Append(extraColorSchemeList1);

            themePart1.Theme = theme1;
        }

        private void SetPackageProperties(OpenXmlPackage document)
        {
            document.PackageProperties.Creator = "Masaki Tamura (Pasona Tech)";
            document.PackageProperties.Revision = "5";
            document.PackageProperties.Created = System.Xml.XmlConvert.ToDateTime("2012-01-11T07:24:00Z", System.Xml.XmlDateTimeSerializationMode.RoundtripKind);
            document.PackageProperties.Modified = System.Xml.XmlConvert.ToDateTime("2012-01-12T04:45:00Z", System.Xml.XmlDateTimeSerializationMode.RoundtripKind);
            document.PackageProperties.LastModifiedBy = "Masaki Tamura (Pasona Tech)";
        }


    }
}
