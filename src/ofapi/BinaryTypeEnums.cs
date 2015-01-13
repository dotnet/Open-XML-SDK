// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentFormat.OpenXml.Packaging
{
    // data from "dev12\msoutilstat\src\metro.cpp"
    #region ImagePart custom

    // Images
    //L".bin",    L"image/unknown",                 
    //L".bmp",    L"image/bmp",                     
    //L".gif",    L"image/gif",                     
    //L".png",    L"image/png",                     
    //L".tiff",   L"image/tiff",                    
    //L".xbm",    L"image/xbm",                     
    //L".ico",    L"image/x-icon",                  
    //L".pcx",    L"image/x-pcx",                   
    //L".pcz",    L"image/x-pcz",                   
    //// Note: [danjump] EMZ and WMZ should never be used.
    //L".emz",    L"image/x-emz",   
    //L".wmz",    L"image/x-wmz",   
    //// Note: [danjump] Jpeg-Wmf are used by thumbnail.  Don't add between them
    //L".jpeg",   L"image/jpeg",   
    //L".emf",    L"image/x-emf",  
    //L".wmf",    L"image/x-wmf",  

    /// <summary>
    /// Defines ImagePartType - types of ImagePart.
    /// </summary>
    public enum ImagePartType
    {
        /// <summary>
        /// Windows Bitmap Graphics (.bmp).
        /// </summary>
        Bmp,
        /// <summary>
        /// Graphic Interchange Format (.gif).
        /// </summary>
        Gif,
        /// <summary>
        /// Portable (Public) Network Graphic (.png).
        /// </summary>
        Png,
        /// <summary>
        /// Tagged Image Format File (.tiff).
        /// </summary>
        Tiff,
        ///// <summary>
        ///// X Bitmap Graphic (.xbm).
        ///// </summary>
        //Xbm,
        /// <summary>
        /// Windows Icon (.ico).
        /// </summary>
        Icon,
        /// <summary>
        /// PC Paintbrush Bitmap Graphic (.pcx).
        /// </summary>
        Pcx,
        ///// <summary>
        ///// Compressed Macintosh PICT (.pcz).
        ///// </summary>
        //Pcz,
        //Emz,
        //Wmz,
        ///// <summary>
        ///// Macintosh Quickdraw/PICT Drawing (.pict).
        ///// </summary>
        //Pict,
        /// <summary>
        /// JPEG/JIFF Image (.jpeg).
        /// </summary>
        Jpeg,
        /// <summary>
        /// Extended (Enhanced) Windows Metafile Format (.emf).
        /// </summary>
        Emf,
        /// <summary>
        /// Windows Metafile (.wmf).
        /// </summary>
        Wmf
    }

    internal static class ImagePartTypeInfo
    {
        internal static string GetContentType(ImagePartType imageType)
        {
            switch (imageType)
            {
                case ImagePartType.Bmp:
                    return "image/bmp";

                case ImagePartType.Gif:
                    return "image/gif";

                case ImagePartType.Png:
                    return "image/png";

                case ImagePartType.Tiff:
                    return "image/tiff";

                //case ImagePartType.Xbm:
                //    return "image/xbm";

                case ImagePartType.Icon:
                    return "image/x-icon";

                case ImagePartType.Pcx:
                    return "image/x-pcx";

                //case ImagePartType.Pcz:
                //    return "image/x-pcz";

                //case ImagePartType.Pict:
                //    return "image/pict";

                case ImagePartType.Jpeg:
                    return "image/jpeg";

                case ImagePartType.Emf:
                    return "image/x-emf";

                case ImagePartType.Wmf:
                    return "image/x-wmf";

                default:
                    throw new ArgumentOutOfRangeException("imageType");
            }
        }

        internal static string GetTargetExtension(ImagePartType imageType)
        {
            switch (imageType)
            {
                case ImagePartType.Bmp:
                    return ".bmp";

                case ImagePartType.Gif:
                    return ".gif";

                case ImagePartType.Png:
                    return ".png";

                case ImagePartType.Tiff:
                    return ".tiff";

                //case ImagePartType.Xbm:
                //    return ".xbm";

                case ImagePartType.Icon:
                    return ".ico";

                case ImagePartType.Pcx:
                    return ".pcx";

                //case ImagePartType.Pcz:
                //    return ".pcz";

                //case ImagePartType.Pict:
                //    return ".pict";

                case ImagePartType.Jpeg:
                    return ".jpg";

                case ImagePartType.Emf:
                    return ".emf";

                case ImagePartType.Wmf:
                    return ".wmf";

                default:
                    return ".image";
            }
        }
    }

    #endregion

    #region MailMerge Recipient Data Part custom

    /// <summary>
    /// Defines MailMergeRecipientDataPartType - types of MailMergeRecipientDataPart.
    /// </summary>
    public enum MailMergeRecipientDataPartType
    {
        /// <summary>
        /// OpenXml Mail Merge Recipient Data.
        /// </summary>
        OpenXmlMailMergeRecipientData,

        /// <summary>
        /// Microsoft Word Mail Merge Recipient Data.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "Ms")]
        MsWordMailMergeRecipientData,
    }

    internal static class MailMergeRecipientDataPartTypeInfo
    {
        internal static string GetContentType(MailMergeRecipientDataPartType mailMergeRecipientDataPartType)
        {
            switch (mailMergeRecipientDataPartType)
            {
                case MailMergeRecipientDataPartType.OpenXmlMailMergeRecipientData:
                    return "application/vnd.openxmlformats-officedocument.wordprocessingml.mailMergeRecipientData+xml";
                case MailMergeRecipientDataPartType.MsWordMailMergeRecipientData:
                    return "application/vnd.ms-word.mailMergeRecipientData+xml";
                default:
                    throw new ArgumentOutOfRangeException("mailMergeRecipientDataPartType");
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "mailMergeRecipientDataPartType")]
        internal static string GetTargetExtension(MailMergeRecipientDataPartType mailMergeRecipientDataPartType)
        {
            return ".xml";
        }
    }
    #endregion

    #region FontPart custom

    /// <summary>
    /// Defines FontPartType - types of FontPart.
    /// </summary>
    public enum FontPartType
    {
        /// <summary>
        /// Font Data (.fntdata).
        /// </summary>
        FontData,
        /// <summary>
        /// TrueType Font (.ttf).
        /// </summary>
        FontTtf,
        /// <summary>
        /// Obfuscated TTF Font (.odttf).
        /// </summary>
        FontOdttf
    }

    internal static class FontPartTypeInfo
    {
        internal static string GetContentType(FontPartType fontType)
        {
            switch (fontType)
            {
                case FontPartType.FontData:
                    return "application/x-fontdata";

                case FontPartType.FontTtf:
                    return "application/x-font-ttf";

                case FontPartType.FontOdttf:
                    return "application/vnd.openxmlformats-officedocument.obfuscatedFont";

                default:
                    throw new ArgumentOutOfRangeException("fontType");
            }
        }

        internal static string GetTargetExtension(FontPartType fontType)
        {
            switch (fontType)
            {
                case FontPartType.FontData:
                    return ".fntdata";

                case FontPartType.FontTtf:
                    return ".ttf";

                case FontPartType.FontOdttf:
                    return ".odttf";

                default:
                    return ".font";
            }
        }
    }

    #endregion    

    #region CustomPropertyPart

    /// <summary>
    /// Defines CustomPropertyPartType - types of CustomPropertyPart.
    /// </summary>
    public enum CustomPropertyPartType
    {
        /// <summary>
        /// application/vnd.openxmlformats-officedocument.spreadsheetml.customProperty.
        /// </summary>
        Spreadsheet,

        /// <summary>
        /// application/xml.
        /// </summary>
        Xml
    }

    internal static class CustomPropertyPartTypeInfo
    {
        internal static string GetContentType(CustomPropertyPartType partType)
        {
            switch (partType)
            {
                case CustomPropertyPartType.Spreadsheet:
                    return "application/vnd.openxmlformats-officedocument.spreadsheetml.customProperty";

                case CustomPropertyPartType.Xml:
                    return "application/xml";

                default:
                    throw new ArgumentOutOfRangeException("partType");
            }
        }

        internal static string GetTargetExtension(CustomPropertyPartType partType)
        {
            switch (partType)
            {
                case CustomPropertyPartType.Spreadsheet:
                    return ".xml";

                case CustomPropertyPartType.Xml:
                    return ".xml";

                default:
                    return ".xml";
            }
        }
    }

    #endregion

    #region ThumbnailPart custom

    /// <summary>
    /// Defines ThumbnailPartType - types of ThumbnailPart.
    /// </summary>
    public enum ThumbnailPartType
    {
        /// <summary>
        /// JPEG/JIFF Image (.jpeg).
        /// </summary>
        Jpeg,

        /// <summary>
        /// Extended (Enhanced) Windows Metafile Format (.emf).
        /// </summary>
        Emf,

        /// <summary>
        /// Windows Metafile (.wmf).
        /// </summary>
        Wmf
    }

    internal static class ThumbnailPartTypeInfo
    {
        internal static string GetContentType(ThumbnailPartType imageType)
        {
            switch (imageType)
            {
                case ThumbnailPartType.Jpeg:
                    return "image/jpeg";

                case ThumbnailPartType.Emf:
                    return "image/x-emf";

                case ThumbnailPartType.Wmf:
                    return "image/x-wmf";

                default:
                    throw new ArgumentOutOfRangeException("imageType");
            }
        }

        internal static string GetTargetExtension(ThumbnailPartType imageType)
        {
            switch (imageType)
            {
                case ThumbnailPartType.Jpeg:
                    return ".jpg";

                case ThumbnailPartType.Emf:
                    return ".emf";

                case ThumbnailPartType.Wmf:
                    return ".wmf";

                default:
                    return ".image";
            }
        }
    }

    #endregion

    #region EmbeddedControlPart custom

    /// <summary>
    /// Defines EmbeddedControlPersistencePartType - types of EmbeddedControlPart.
    /// </summary>
    public enum EmbeddedControlPersistencePartType
    {
        /// <summary>
        /// ActiveX (.xml).
        /// </summary>
        ActiveX,

        /// <summary>
        /// ActieveX (.bin).
        /// </summary>
        ActiveXBin
    }

    internal static class EmbeddedControlPersistencePartTypeInfo
    {
        internal static string GetContentType(EmbeddedControlPersistencePartType controlType)
        {
            switch (controlType)
            {
                case EmbeddedControlPersistencePartType.ActiveX:
                    return "application/vnd.ms-office.activeX+xml";

                case EmbeddedControlPersistencePartType.ActiveXBin:
                    return "application/vnd.ms-office.activeX";

                default:
                    throw new ArgumentOutOfRangeException("controlType");
            }
        }

        internal static string GetTargetExtension(EmbeddedControlPersistencePartType controlType)
        {
            switch (controlType)
            {
                case EmbeddedControlPersistencePartType.ActiveX:
                    return ".xml";

                case EmbeddedControlPersistencePartType.ActiveXBin:
                    return ".bin";

                default:
                    return ".bin";
            }
        }
    }

    #endregion

    #region EmbeddedControlPersistenceBinaryDataPartType custom

    /// <summary>
    /// Defines EmbeddedControlPersistenceBinaryDataPartType - types of EmbeddedControlPart.
    /// </summary>
    public enum EmbeddedControlPersistenceBinaryDataPartType
    {
        /// <summary>
        /// ActieveX (.bin).
        /// </summary>
        ActiveXBin
    }

    internal static class EmbeddedControlPersistenceBinaryDataPartTypeInfo
    {
        internal static string GetContentType(EmbeddedControlPersistenceBinaryDataPartType controlType)
        {
            switch (controlType)
            {
                case EmbeddedControlPersistenceBinaryDataPartType.ActiveXBin:
                    return "application/vnd.ms-office.activeX";

                default:
                    throw new ArgumentOutOfRangeException("controlType");
            }
        }

        internal static string GetTargetExtension(EmbeddedControlPersistenceBinaryDataPartType controlType)
        {
            switch (controlType)
            {
                case EmbeddedControlPersistenceBinaryDataPartType.ActiveXBin:
                    return ".bin";

                default:
                    return ".bin";
            }
        }
    }

    #endregion

    #region AlternativeFormatImportPart custom

    // Misc
    //L".bin",    L"application/octet-stream",                            },
    //L".txt",    L"application/txt",                                     },
    //L".rtf",    L"application/rtf",                                     },
    //L".htm",    L"application/xhtml+xml",                                     },
    //L".htm",    L"text/html",                                    },
    //L".mht",    L"message/rfc822",                                     }, 
    //L".xml",    L"application/xml",                                     }, 
    //// Don't add between TextXml and TextPlain, in-use by Access
    //L".xml",    L"text/xml",                                            }, 
    //L".txt",    L"text/plain",                                          }, 

    /// <summary>
    /// Defines AlternativeFormatImportPartType - types of AlternativeFormatImportPart.
    /// </summary>
    public enum AlternativeFormatImportPartType
    {
        /// <summary>
        /// Extensible HyperText Markup Language File (.xhtml).
        /// </summary>
        Xhtml,
        
        /// <summary>
        /// MHTML Document (.mht).
        /// </summary>
        Mht,
        
        /// <summary>
        /// application/xml (.xml).
        /// </summary>
        Xml,

        /// <summary>
        /// Text (.txt).
        /// </summary>
        TextPlain,

        /// <summary>
        /// Wordprocessing (.docx).
        /// </summary>
        WordprocessingML, 

        /// <summary>
        /// Office Word Macro Enabled (.docm).
        /// </summary>
        OfficeWordMacroEnabled,

        /// <summary>
        /// Office Word Template (.dotx).
        /// </summary>
        OfficeWordTemplate,

        /// <summary>
        /// Office Word Macro Enabled Template (.dotm).
        /// </summary>
        OfficeWordMacroEnabledTemplate,

        /// <summary>
        /// Rich Text Foramt (.rtf).
        /// </summary>
        Rtf,

        /// <summary>
        /// HyperText Markup Language File (.htm).
        /// </summary>
        Html,
    }

    internal static class AlternativeFormatImportPartTypeInfo
    {
        internal static string GetContentType(AlternativeFormatImportPartType partType)
        {
            switch (partType)
            {
                //case AlternativeFormatImportPartType.Text:
                //    return "application/text/plain";

                case AlternativeFormatImportPartType.Xhtml:
                    return "application/xhtml+xml";

                case AlternativeFormatImportPartType.Mht:
                    return "message/rfc822";

                case AlternativeFormatImportPartType.Xml:
                    return "application/xml";

                //case AlternativeFormatImportPartType.TextXml:
                //    return "text/xml";

                case AlternativeFormatImportPartType.TextPlain:
                    return "text/plain";
                
                case AlternativeFormatImportPartType.WordprocessingML:
                    return "application/vnd.openxmlformats-officedocument.wordprocessingml.document.main+xml";

                case AlternativeFormatImportPartType.OfficeWordMacroEnabled:
                    return "application/vnd.ms-word.document.macroEnabled.main+xml";

                case AlternativeFormatImportPartType.OfficeWordTemplate:
                    return "application/vnd.openxmlformats-officedocument.wordprocessingml.template.main+xml";

                case AlternativeFormatImportPartType.OfficeWordMacroEnabledTemplate:
                    return "application/vnd.ms-word.template.macroEnabledTemplate.main+xml";

                case AlternativeFormatImportPartType.Rtf:
                    return "application/rtf";

                case AlternativeFormatImportPartType.Html:
                    return "text/html";

                default:
                    throw new ArgumentOutOfRangeException("partType");
            }
        }

        internal static string GetTargetExtension(AlternativeFormatImportPartType imageType)
        {
            switch (imageType)
            {
                //case AlternativeFormatImportPartType.Text:
                //    return ".txt";

                case AlternativeFormatImportPartType.Xhtml:
                    return ".xhtml";

                case AlternativeFormatImportPartType.Mht:
                    return ".mht";

                case AlternativeFormatImportPartType.Xml:
                    return ".xml";

                //case AlternativeFormatImportPartType.TextXml:
                //    return ".xml";

                case AlternativeFormatImportPartType.TextPlain:
                    return ".txt";

                case AlternativeFormatImportPartType.WordprocessingML:
                    return ".docx";

                case AlternativeFormatImportPartType.OfficeWordMacroEnabled:
                    return ".docm";

                case AlternativeFormatImportPartType.OfficeWordTemplate:
                    return ".dotx";

                case AlternativeFormatImportPartType.OfficeWordMacroEnabledTemplate:
                    return ".dotm";

                case AlternativeFormatImportPartType.Rtf:
                    return ".rtf";

                case AlternativeFormatImportPartType.Html:
                    return ".htm";

                
                default:
                    return ".dat";
            }
        }
    }

    #endregion
    
    #region CustomXmlPart

    /// <summary>
    /// Defines CustomXmlPartType - types of CustomXmlPart.
    /// </summary>
    public enum CustomXmlPartType
    {
        /// <summary>
        /// Additional characteristics (application/xml).
        /// </summary>
        AdditionalCharacteristics,

        /// <summary>
        /// Bibliography (application/xml).
        /// </summary>
        Bibliography,

        /// <summary>
        /// Custom XML (application/xml).
        /// </summary>
        CustomXml,

        /// <summary>
        /// Ink content (application/inkml+xml).
        /// </summary>
        InkContent
    }

    internal static class CustomXmlPartTypeInfo
    {
        internal static string GetContentType(CustomXmlPartType partType)
        {
            switch (partType)
            {
                case CustomXmlPartType.AdditionalCharacteristics:
                    return "application/xml";

                case CustomXmlPartType.Bibliography:
                    return "application/xml";

                case CustomXmlPartType.CustomXml:
                    return "application/xml";

                case CustomXmlPartType.InkContent:
                    return "application/inkml+xml";

                default:
                    throw new ArgumentOutOfRangeException("partType");
            }
        }

        internal static string GetTargetExtension(CustomXmlPartType partType)
        {
            switch (partType)
            {
                case CustomXmlPartType.AdditionalCharacteristics:
                    return ".xml";

                case CustomXmlPartType.Bibliography:
                    return ".xml";

                case CustomXmlPartType.CustomXml:
                    return ".xml";

                case CustomXmlPartType.InkContent:
                    return ".xml";

                default:
                    return ".xml";
            }
        }
    }

    #endregion

}
