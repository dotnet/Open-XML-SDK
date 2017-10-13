// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
// This source file is machine generated.  Please do not change the code manually.
using System;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Packaging
{
/// <summary>
/// Defines the CoreFilePropertiesPart.
/// </summary>
public partial class CoreFilePropertiesPart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of CoreFilePropertiesPart
    /// </summary>
    internal protected CoreFilePropertiesPart()
            : base()
    {
    }
    
    

   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/package/2006/relationships/metadata/core-properties";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.openxmlformats-package.core-properties+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@"docProps";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"core";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    



    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the ExtendedFilePropertiesPart.
/// </summary>
public partial class ExtendedFilePropertiesPart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of ExtendedFilePropertiesPart
    /// </summary>
    internal protected ExtendedFilePropertiesPart()
            : base()
    {
    }
    
    

   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/officeDocument/2006/relationships/extended-properties";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.openxmlformats-officedocument.extended-properties+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@"docProps";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"app";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    



    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the CustomFilePropertiesPart.
/// </summary>
public partial class CustomFilePropertiesPart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of CustomFilePropertiesPart
    /// </summary>
    internal protected CustomFilePropertiesPart()
            : base()
    {
    }
    
    

   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/officeDocument/2006/relationships/custom-properties";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.openxmlformats-officedocument.custom-properties+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@"docProps";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"custom";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    



    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the ThumbnailPart.
/// </summary>
public partial class ThumbnailPart : OpenXmlPart 
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of ThumbnailPart
    /// </summary>
    internal protected ThumbnailPart()
            : base()
    {
    }
    
    

   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/package/2006/relationships/metadata/thumbnail";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@"docProps";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"thumbnail";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetFileExtension
    /// </summary>
    internal const System.String TargetFileExtensionConstant =@".bin";
    /// <summary>
    /// Gets the TargetFileExtension.
    /// </summary>
    internal sealed override string TargetFileExtension
    {
       get { return TargetFileExtensionConstant; }
    } 
    



    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return false; }
    }
}
/// <summary>
/// Defines the DigitalSignatureOriginPart.
/// </summary>
public partial class DigitalSignatureOriginPart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            tempData.Add("http://schemas.openxmlformats.org/package/2006/relationships/digital-signature/signature", new PartConstraintRule("XmlSignaturePart", XmlSignaturePart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));

            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of DigitalSignatureOriginPart
    /// </summary>
    internal protected DigitalSignatureOriginPart()
            : base()
    {
    }
    
    
    /// <summary>
    /// Create an instance of OpenXmlPart according to the given relationship type
    /// </summary>
    /// <param name="relationshipType">Relationship type</param>
    /// <returns>An instance of OpenXmlPart</returns>
    internal sealed override OpenXmlPart CreatePartCore(string relationshipType)
    {
        this.ThrowIfObjectDisposed();

        if ( relationshipType == null )
        {
            throw new ArgumentNullException("relationshipType");
        }
        switch (relationshipType)
        {
        case XmlSignaturePart.RelationshipTypeConstant:
                    return new XmlSignaturePart();        
            

        }
        throw new ArgumentOutOfRangeException("relationshipType");
    }
    

     
    
    
   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/package/2006/relationships/digital-signature/origin";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.openxmlformats-package.digital-signature-origin";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@"_xmlsignatures";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"origin";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetFileExtension
    /// </summary>
    internal const System.String TargetFileExtensionConstant =@".sigs";
    /// <summary>
    /// Gets the TargetFileExtension.
    /// </summary>
    internal sealed override string TargetFileExtension
    {
       get { return TargetFileExtensionConstant; }
    } 
    

        /// <summary>
        /// Gets the XmlSignatureParts of the DigitalSignatureOriginPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<XmlSignaturePart> XmlSignatureParts
        {
            get{
                    return this.GetPartsOfType<XmlSignaturePart>();
                }
        }
                


    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the XmlSignaturePart.
/// </summary>
public partial class XmlSignaturePart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of XmlSignaturePart
    /// </summary>
    internal protected XmlSignaturePart()
            : base()
    {
    }
    
    

   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/package/2006/relationships/digital-signature/signature";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.openxmlformats-package.digital-signature-xmlsignature+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@"_xmlsignatures";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"sig";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    



    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the MainDocumentPart.
/// </summary>
public partial class MainDocumentPart : OpenXmlPart 
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/customXml", new PartConstraintRule("CustomXmlPart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/glossaryDocument", new PartConstraintRule("GlossaryDocumentPart", GlossaryDocumentPart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/theme", new PartConstraintRule("ThemePart", ThemePart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/package/2006/relationships/metadata/thumbnail", new PartConstraintRule("ThumbnailPart", null, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/comments", new PartConstraintRule("WordprocessingCommentsPart", WordprocessingCommentsPart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/settings", new PartConstraintRule("DocumentSettingsPart", DocumentSettingsPart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/endnotes", new PartConstraintRule("EndnotesPart", EndnotesPart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/fontTable", new PartConstraintRule("FontTablePart", FontTablePart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/footnotes", new PartConstraintRule("FootnotesPart", FootnotesPart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/numbering", new PartConstraintRule("NumberingDefinitionsPart", NumberingDefinitionsPart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/styles", new PartConstraintRule("StyleDefinitionsPart", StyleDefinitionsPart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.microsoft.com/office/2007/relationships/stylesWithEffects", new PartConstraintRule("StylesWithEffectsPart", StylesWithEffectsPart.ContentTypeConstant, false, false,(FileFormatVersions)2 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/webSettings", new PartConstraintRule("WebSettingsPart", WebSettingsPart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/footer", new PartConstraintRule("FooterPart", FooterPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/header", new PartConstraintRule("HeaderPart", HeaderPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/printerSettings", new PartConstraintRule("WordprocessingPrinterSettingsPart", WordprocessingPrinterSettingsPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.microsoft.com/office/2006/relationships/keyMapCustomizations", new PartConstraintRule("CustomizationPart", CustomizationPart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.microsoft.com/office/2006/relationships/vbaProject", new PartConstraintRule("VbaProjectPart", VbaProjectPart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.microsoft.com/office/2011/relationships/commentsExtended", new PartConstraintRule("WordprocessingCommentsExPart", WordprocessingCommentsExPart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.microsoft.com/office/2011/relationships/people", new PartConstraintRule("WordprocessingPeoplePart", WordprocessingPeoplePart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/aFChunk", new PartConstraintRule("AlternativeFormatImportPart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/chart", new PartConstraintRule("ChartPart", ChartPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramColors", new PartConstraintRule("DiagramColorsPart", DiagramColorsPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramData", new PartConstraintRule("DiagramDataPart", DiagramDataPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.microsoft.com/office/2007/relationships/diagramDrawing", new PartConstraintRule("DiagramPersistLayoutPart", DiagramPersistLayoutPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramLayout", new PartConstraintRule("DiagramLayoutDefinitionPart", DiagramLayoutDefinitionPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramQuickStyle", new PartConstraintRule("DiagramStylePart", DiagramStylePart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/control", new PartConstraintRule("EmbeddedControlPersistencePart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/oleObject", new PartConstraintRule("EmbeddedObjectPart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/package", new PartConstraintRule("EmbeddedPackagePart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/image", new PartConstraintRule("ImagePart", null, false, true,(FileFormatVersions)7 ));

            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/video", new PartConstraintRule("VideoReferenceRelationship", null, false, true,(FileFormatVersions)7 ));

            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of MainDocumentPart
    /// </summary>
    internal protected MainDocumentPart()
            : base()
    {
    }
    
    
    /// <summary>
    /// Create an instance of OpenXmlPart according to the given relationship type
    /// </summary>
    /// <param name="relationshipType">Relationship type</param>
    /// <returns>An instance of OpenXmlPart</returns>
    internal sealed override OpenXmlPart CreatePartCore(string relationshipType)
    {
        this.ThrowIfObjectDisposed();

        if ( relationshipType == null )
        {
            throw new ArgumentNullException("relationshipType");
        }
        switch (relationshipType)
        {
        case CustomXmlPart.RelationshipTypeConstant:
                    return new CustomXmlPart();
            
        case GlossaryDocumentPart.RelationshipTypeConstant:
                    return new GlossaryDocumentPart();        
            
        case ThemePart.RelationshipTypeConstant:
                    return new ThemePart();        
            
        case ThumbnailPart.RelationshipTypeConstant:
                    return new ThumbnailPart();
            
        case WordprocessingCommentsPart.RelationshipTypeConstant:
                    return new WordprocessingCommentsPart();        
            
        case DocumentSettingsPart.RelationshipTypeConstant:
                    return new DocumentSettingsPart();        
            
        case EndnotesPart.RelationshipTypeConstant:
                    return new EndnotesPart();        
            
        case FontTablePart.RelationshipTypeConstant:
                    return new FontTablePart();        
            
        case FootnotesPart.RelationshipTypeConstant:
                    return new FootnotesPart();        
            
        case NumberingDefinitionsPart.RelationshipTypeConstant:
                    return new NumberingDefinitionsPart();        
            
        case StyleDefinitionsPart.RelationshipTypeConstant:
                    return new StyleDefinitionsPart();        
            
        case StylesWithEffectsPart.RelationshipTypeConstant:
                    return new StylesWithEffectsPart();        
            
        case WebSettingsPart.RelationshipTypeConstant:
                    return new WebSettingsPart();        
            
        case FooterPart.RelationshipTypeConstant:
                    return new FooterPart();        
            
        case HeaderPart.RelationshipTypeConstant:
                    return new HeaderPart();        
            
        case WordprocessingPrinterSettingsPart.RelationshipTypeConstant:
                    return new WordprocessingPrinterSettingsPart();        
            
        case CustomizationPart.RelationshipTypeConstant:
                    return new CustomizationPart();        
            
        case VbaProjectPart.RelationshipTypeConstant:
                    return new VbaProjectPart();        
            
        case WordprocessingCommentsExPart.RelationshipTypeConstant:
                    return new WordprocessingCommentsExPart();        
            
        case WordprocessingPeoplePart.RelationshipTypeConstant:
                    return new WordprocessingPeoplePart();        
            
        case AlternativeFormatImportPart.RelationshipTypeConstant:
                    return new AlternativeFormatImportPart();
            
        case ChartPart.RelationshipTypeConstant:
                    return new ChartPart();        
            
        case DiagramColorsPart.RelationshipTypeConstant:
                    return new DiagramColorsPart();        
            
        case DiagramDataPart.RelationshipTypeConstant:
                    return new DiagramDataPart();        
            
        case DiagramPersistLayoutPart.RelationshipTypeConstant:
                    return new DiagramPersistLayoutPart();        
            
        case DiagramLayoutDefinitionPart.RelationshipTypeConstant:
                    return new DiagramLayoutDefinitionPart();        
            
        case DiagramStylePart.RelationshipTypeConstant:
                    return new DiagramStylePart();        
            
        case EmbeddedControlPersistencePart.RelationshipTypeConstant:
                    return new EmbeddedControlPersistencePart();
            
        case EmbeddedObjectPart.RelationshipTypeConstant:
                    return new EmbeddedObjectPart();
            
        case EmbeddedPackagePart.RelationshipTypeConstant:
                    return new EmbeddedPackagePart();
            
        case ImagePart.RelationshipTypeConstant:
                    return new ImagePart();
            

        }
        throw new ArgumentOutOfRangeException("relationshipType");
    }
    

        /// <summary>
    /// Adds a CustomXmlPart to the MainDocumentPart.
    /// </summary>
    /// <param name="contentType">the content type of the CustomXmlPart.</param>
    /// <returns>The newly added part.</returns>
    public CustomXmlPart AddCustomXmlPart(string contentType)
    {
        CustomXmlPart childPart = new CustomXmlPart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a CustomXmlPart to the MainDocumentPart.
    /// </summary>
    /// <param name="partType">The part type of the CustomXmlPart.</param>
    /// <returns>The newly added part.</returns>
     public CustomXmlPart AddCustomXmlPart(CustomXmlPartType partType)
    {
        string contentType = CustomXmlPartTypeInfo.GetContentType(partType);
        string partExtension = CustomXmlPartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddCustomXmlPart(contentType);
    }
    
    /// <summary>
    /// Adds a CustomXmlPart to the MainDocumentPart.
    /// </summary>
    /// <param name="contentType">the content type of the CustomXmlPart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public CustomXmlPart AddCustomXmlPart(string contentType, string id)
    {
        CustomXmlPart childPart = new CustomXmlPart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a CustomXmlPart to the MainDocumentPart.
    /// </summary>
    /// <param name="partType">The part type of the CustomXmlPart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public CustomXmlPart AddCustomXmlPart(CustomXmlPartType partType, string id)
    {
        string contentType = CustomXmlPartTypeInfo.GetContentType(partType);
        string partExtension = CustomXmlPartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddCustomXmlPart(contentType, id);
    }
    /// <summary>
    /// Adds a ThumbnailPart to the MainDocumentPart.
    /// </summary>
    /// <param name="contentType">the content type of the ThumbnailPart.</param>
    /// <returns>The newly added part.</returns>
    public ThumbnailPart AddThumbnailPart(string contentType)
    {
        ThumbnailPart childPart = new ThumbnailPart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a ThumbnailPart to the MainDocumentPart.
    /// </summary>
    /// <param name="partType">The part type of the ThumbnailPart.</param>
    /// <returns>The newly added part.</returns>
     public ThumbnailPart AddThumbnailPart(ThumbnailPartType partType)
    {
        string contentType = ThumbnailPartTypeInfo.GetContentType(partType);
        string partExtension = ThumbnailPartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddThumbnailPart(contentType);
    }
    
    /// <summary>
    /// Adds a ThumbnailPart to the MainDocumentPart.
    /// </summary>
    /// <param name="contentType">the content type of the ThumbnailPart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public ThumbnailPart AddThumbnailPart(string contentType, string id)
    {
        ThumbnailPart childPart = new ThumbnailPart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a ThumbnailPart to the MainDocumentPart.
    /// </summary>
    /// <param name="partType">The part type of the ThumbnailPart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public ThumbnailPart AddThumbnailPart(ThumbnailPartType partType, string id)
    {
        string contentType = ThumbnailPartTypeInfo.GetContentType(partType);
        string partExtension = ThumbnailPartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddThumbnailPart(contentType, id);
    }
    /// <summary>
    /// Adds a AlternativeFormatImportPart to the MainDocumentPart.
    /// </summary>
    /// <param name="contentType">the content type of the AlternativeFormatImportPart.</param>
    /// <returns>The newly added part.</returns>
    public AlternativeFormatImportPart AddAlternativeFormatImportPart(string contentType)
    {
        AlternativeFormatImportPart childPart = new AlternativeFormatImportPart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a AlternativeFormatImportPart to the MainDocumentPart.
    /// </summary>
    /// <param name="partType">The part type of the AlternativeFormatImportPart.</param>
    /// <returns>The newly added part.</returns>
     public AlternativeFormatImportPart AddAlternativeFormatImportPart(AlternativeFormatImportPartType partType)
    {
        string contentType = AlternativeFormatImportPartTypeInfo.GetContentType(partType);
        string partExtension = AlternativeFormatImportPartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddAlternativeFormatImportPart(contentType);
    }
    
    /// <summary>
    /// Adds a AlternativeFormatImportPart to the MainDocumentPart.
    /// </summary>
    /// <param name="contentType">the content type of the AlternativeFormatImportPart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public AlternativeFormatImportPart AddAlternativeFormatImportPart(string contentType, string id)
    {
        AlternativeFormatImportPart childPart = new AlternativeFormatImportPart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a AlternativeFormatImportPart to the MainDocumentPart.
    /// </summary>
    /// <param name="partType">The part type of the AlternativeFormatImportPart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public AlternativeFormatImportPart AddAlternativeFormatImportPart(AlternativeFormatImportPartType partType, string id)
    {
        string contentType = AlternativeFormatImportPartTypeInfo.GetContentType(partType);
        string partExtension = AlternativeFormatImportPartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddAlternativeFormatImportPart(contentType, id);
    }
    /// <summary>
    /// Adds a EmbeddedControlPersistencePart to the MainDocumentPart.
    /// </summary>
    /// <param name="contentType">the content type of the EmbeddedControlPersistencePart.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(string contentType)
    {
        EmbeddedControlPersistencePart childPart = new EmbeddedControlPersistencePart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a EmbeddedControlPersistencePart to the MainDocumentPart.
    /// </summary>
    /// <param name="partType">The part type of the EmbeddedControlPersistencePart.</param>
    /// <returns>The newly added part.</returns>
     public EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(EmbeddedControlPersistencePartType partType)
    {
        string contentType = EmbeddedControlPersistencePartTypeInfo.GetContentType(partType);
        string partExtension = EmbeddedControlPersistencePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddEmbeddedControlPersistencePart(contentType);
    }
    
    /// <summary>
    /// Adds a EmbeddedControlPersistencePart to the MainDocumentPart.
    /// </summary>
    /// <param name="contentType">the content type of the EmbeddedControlPersistencePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(string contentType, string id)
    {
        EmbeddedControlPersistencePart childPart = new EmbeddedControlPersistencePart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a EmbeddedControlPersistencePart to the MainDocumentPart.
    /// </summary>
    /// <param name="partType">The part type of the EmbeddedControlPersistencePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(EmbeddedControlPersistencePartType partType, string id)
    {
        string contentType = EmbeddedControlPersistencePartTypeInfo.GetContentType(partType);
        string partExtension = EmbeddedControlPersistencePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddEmbeddedControlPersistencePart(contentType, id);
    }
	/// <summary>
    /// Adds a EmbeddedObjectPart to the MainDocumentPart.
    /// </summary>
    /// <param name="contentType">The content type of the EmbeddedObjectPart.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedObjectPart AddEmbeddedObjectPart(string contentType)
    {
        EmbeddedObjectPart childPart = new EmbeddedObjectPart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
	/// <summary>
    /// Adds a EmbeddedPackagePart to the MainDocumentPart.
    /// </summary>
    /// <param name="contentType">The content type of the EmbeddedPackagePart.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedPackagePart AddEmbeddedPackagePart(string contentType)
    {
        EmbeddedPackagePart childPart = new EmbeddedPackagePart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a ImagePart to the MainDocumentPart.
    /// </summary>
    /// <param name="contentType">the content type of the ImagePart.</param>
    /// <returns>The newly added part.</returns>
    public ImagePart AddImagePart(string contentType)
    {
        ImagePart childPart = new ImagePart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a ImagePart to the MainDocumentPart.
    /// </summary>
    /// <param name="partType">The part type of the ImagePart.</param>
    /// <returns>The newly added part.</returns>
     public ImagePart AddImagePart(ImagePartType partType)
    {
        string contentType = ImagePartTypeInfo.GetContentType(partType);
        string partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddImagePart(contentType);
    }
    
    /// <summary>
    /// Adds a ImagePart to the MainDocumentPart.
    /// </summary>
    /// <param name="contentType">the content type of the ImagePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public ImagePart AddImagePart(string contentType, string id)
    {
        ImagePart childPart = new ImagePart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a ImagePart to the MainDocumentPart.
    /// </summary>
    /// <param name="partType">The part type of the ImagePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public ImagePart AddImagePart(ImagePartType partType, string id)
    {
        string contentType = ImagePartTypeInfo.GetContentType(partType);
        string partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddImagePart(contentType, id);
    }
    /// <summary>
    /// Adds a new <see cref="VideoReferenceRelationship"/> to the specified <see cref="MediaDataPart"/>.
    /// </summary>
    /// <param name="mediaDataPart">The specified target <see cref="MediaDataPart"/>.</param>
    /// <returns>The new <see cref="VideoReferenceRelationship"/>.</returns>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="mediaDataPart"/> is null.</exception>
    /// <exception cref="InvalidOperationException">Thrown when the specified <paramref name="mediaDataPart"/> is not in this document.</exception>
    public VideoReferenceRelationship AddVideoReferenceRelationship(MediaDataPart mediaDataPart)
    {
            return AddDataPartReferenceRelationship<VideoReferenceRelationship>(mediaDataPart);
    }
    /// <summary>
    /// Adds a new <see cref="VideoReferenceRelationship"/> to the specified <see cref="MediaDataPart"/>.
    /// </summary>
    /// <param name="mediaDataPart">The specified target <see cref="MediaDataPart"/>.</param>
    /// <param name="id">The desired relationship ID. </param>
    /// <returns>The new <see cref="VideoReferenceRelationship"/>.</returns>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="mediaDataPart"/> is null.</exception>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="id"/> is null.</exception>
    /// <exception cref="InvalidOperationException">Thrown when the specified <paramref name="mediaDataPart"/> is not in this document.</exception>
    public VideoReferenceRelationship AddVideoReferenceRelationship(MediaDataPart mediaDataPart, string id)
    {
            return AddDataPartReferenceRelationship<VideoReferenceRelationship>(mediaDataPart, id);
    }
 
    
    
   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@"word";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"document";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    

        /// <summary>
        /// Gets the CustomXmlParts of the MainDocumentPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<CustomXmlPart> CustomXmlParts
        {
            get{
                    return this.GetPartsOfType<CustomXmlPart>();
                }
        }
                
        /// <summary>
        /// Gets the GlossaryDocumentPart of the MainDocumentPart.
        /// </summary>
        public GlossaryDocumentPart GlossaryDocumentPart
        {
            get {return GetSubPartOfType<GlossaryDocumentPart>(); }
        }
        /// <summary>
        /// Gets the ThemePart of the MainDocumentPart.
        /// </summary>
        public ThemePart ThemePart
        {
            get {return GetSubPartOfType<ThemePart>(); }
        }
        /// <summary>
        /// Gets the ThumbnailPart of the MainDocumentPart.
        /// </summary>
        public ThumbnailPart ThumbnailPart
        {
            get {return GetSubPartOfType<ThumbnailPart>(); }
        }
        /// <summary>
        /// Gets the WordprocessingCommentsPart of the MainDocumentPart.
        /// </summary>
        public WordprocessingCommentsPart WordprocessingCommentsPart
        {
            get {return GetSubPartOfType<WordprocessingCommentsPart>(); }
        }
        /// <summary>
        /// Gets the DocumentSettingsPart of the MainDocumentPart.
        /// </summary>
        public DocumentSettingsPart DocumentSettingsPart
        {
            get {return GetSubPartOfType<DocumentSettingsPart>(); }
        }
        /// <summary>
        /// Gets the EndnotesPart of the MainDocumentPart.
        /// </summary>
        public EndnotesPart EndnotesPart
        {
            get {return GetSubPartOfType<EndnotesPart>(); }
        }
        /// <summary>
        /// Gets the FontTablePart of the MainDocumentPart.
        /// </summary>
        public FontTablePart FontTablePart
        {
            get {return GetSubPartOfType<FontTablePart>(); }
        }
        /// <summary>
        /// Gets the FootnotesPart of the MainDocumentPart.
        /// </summary>
        public FootnotesPart FootnotesPart
        {
            get {return GetSubPartOfType<FootnotesPart>(); }
        }
        /// <summary>
        /// Gets the NumberingDefinitionsPart of the MainDocumentPart.
        /// </summary>
        public NumberingDefinitionsPart NumberingDefinitionsPart
        {
            get {return GetSubPartOfType<NumberingDefinitionsPart>(); }
        }
        /// <summary>
        /// Gets the StyleDefinitionsPart of the MainDocumentPart.
        /// </summary>
        public StyleDefinitionsPart StyleDefinitionsPart
        {
            get {return GetSubPartOfType<StyleDefinitionsPart>(); }
        }
        /// <summary>
        /// Gets the StylesWithEffectsPart of the MainDocumentPart., only available in Office2010
        /// </summary>
[OfficeAvailability(FileFormatVersions.Office2010)]
        public StylesWithEffectsPart StylesWithEffectsPart
        {
            get {return GetSubPartOfType<StylesWithEffectsPart>(); }
        }
        /// <summary>
        /// Gets the WebSettingsPart of the MainDocumentPart.
        /// </summary>
        public WebSettingsPart WebSettingsPart
        {
            get {return GetSubPartOfType<WebSettingsPart>(); }
        }
        /// <summary>
        /// Gets the FooterParts of the MainDocumentPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<FooterPart> FooterParts
        {
            get{
                    return this.GetPartsOfType<FooterPart>();
                }
        }
                
        /// <summary>
        /// Gets the HeaderParts of the MainDocumentPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<HeaderPart> HeaderParts
        {
            get{
                    return this.GetPartsOfType<HeaderPart>();
                }
        }
                
        /// <summary>
        /// Gets the WordprocessingPrinterSettingsParts of the MainDocumentPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<WordprocessingPrinterSettingsPart> WordprocessingPrinterSettingsParts
        {
            get{
                    return this.GetPartsOfType<WordprocessingPrinterSettingsPart>();
                }
        }
                
        /// <summary>
        /// Gets the CustomizationPart of the MainDocumentPart.
        /// </summary>
        public CustomizationPart CustomizationPart
        {
            get {return GetSubPartOfType<CustomizationPart>(); }
        }
        /// <summary>
        /// Gets the VbaProjectPart of the MainDocumentPart.
        /// </summary>
        public VbaProjectPart VbaProjectPart
        {
            get {return GetSubPartOfType<VbaProjectPart>(); }
        }
        /// <summary>
        /// Gets the WordprocessingCommentsExPart of the MainDocumentPart.
        /// </summary>
        public WordprocessingCommentsExPart WordprocessingCommentsExPart
        {
            get {return GetSubPartOfType<WordprocessingCommentsExPart>(); }
        }
        /// <summary>
        /// Gets the WordprocessingPeoplePart of the MainDocumentPart.
        /// </summary>
        public WordprocessingPeoplePart WordprocessingPeoplePart
        {
            get {return GetSubPartOfType<WordprocessingPeoplePart>(); }
        }
        /// <summary>
        /// Gets the AlternativeFormatImportParts of the MainDocumentPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<AlternativeFormatImportPart> AlternativeFormatImportParts
        {
            get{
                    return this.GetPartsOfType<AlternativeFormatImportPart>();
                }
        }
                
        /// <summary>
        /// Gets the ChartParts of the MainDocumentPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<ChartPart> ChartParts
        {
            get{
                    return this.GetPartsOfType<ChartPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramColorsParts of the MainDocumentPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramColorsPart> DiagramColorsParts
        {
            get{
                    return this.GetPartsOfType<DiagramColorsPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramDataParts of the MainDocumentPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramDataPart> DiagramDataParts
        {
            get{
                    return this.GetPartsOfType<DiagramDataPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramPersistLayoutParts of the MainDocumentPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramPersistLayoutPart> DiagramPersistLayoutParts
        {
            get{
                    return this.GetPartsOfType<DiagramPersistLayoutPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramLayoutDefinitionParts of the MainDocumentPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramLayoutDefinitionPart> DiagramLayoutDefinitionParts
        {
            get{
                    return this.GetPartsOfType<DiagramLayoutDefinitionPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramStyleParts of the MainDocumentPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramStylePart> DiagramStyleParts
        {
            get{
                    return this.GetPartsOfType<DiagramStylePart>();
                }
        }
                
        /// <summary>
        /// Gets the EmbeddedControlPersistenceParts of the MainDocumentPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<EmbeddedControlPersistencePart> EmbeddedControlPersistenceParts
        {
            get{
                    return this.GetPartsOfType<EmbeddedControlPersistencePart>();
                }
        }
                
        /// <summary>
        /// Gets the EmbeddedObjectParts of the MainDocumentPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<EmbeddedObjectPart> EmbeddedObjectParts
        {
            get{
                    return this.GetPartsOfType<EmbeddedObjectPart>();
                }
        }
                
        /// <summary>
        /// Gets the EmbeddedPackageParts of the MainDocumentPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<EmbeddedPackagePart> EmbeddedPackageParts
        {
            get{
                    return this.GetPartsOfType<EmbeddedPackagePart>();
                }
        }
                
        /// <summary>
        /// Gets the ImageParts of the MainDocumentPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<ImagePart> ImageParts
        {
            get{
                    return this.GetPartsOfType<ImagePart>();
                }
        }
                


    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return false; }
    }
}
/// <summary>
/// Defines the CustomizationPart.
/// </summary>
public partial class CustomizationPart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            tempData.Add("http://schemas.microsoft.com/office/2006/relationships/attachedToolbars", new PartConstraintRule("WordAttachedToolbarsPart", WordAttachedToolbarsPart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));

            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of CustomizationPart
    /// </summary>
    internal protected CustomizationPart()
            : base()
    {
    }
    
    
    /// <summary>
    /// Create an instance of OpenXmlPart according to the given relationship type
    /// </summary>
    /// <param name="relationshipType">Relationship type</param>
    /// <returns>An instance of OpenXmlPart</returns>
    internal sealed override OpenXmlPart CreatePartCore(string relationshipType)
    {
        this.ThrowIfObjectDisposed();

        if ( relationshipType == null )
        {
            throw new ArgumentNullException("relationshipType");
        }
        switch (relationshipType)
        {
        case WordAttachedToolbarsPart.RelationshipTypeConstant:
                    return new WordAttachedToolbarsPart();        
            

        }
        throw new ArgumentOutOfRangeException("relationshipType");
    }
    

     
    
    
   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.microsoft.com/office/2006/relationships/keyMapCustomizations";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.ms-word.keyMapCustomizations+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@".";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"customizations";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    

        /// <summary>
        /// Gets the WordAttachedToolbarsPart of the CustomizationPart.
        /// </summary>
        public WordAttachedToolbarsPart WordAttachedToolbarsPart
        {
            get {return GetSubPartOfType<WordAttachedToolbarsPart>(); }
        }


    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the WordAttachedToolbarsPart.
/// </summary>
public partial class WordAttachedToolbarsPart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of WordAttachedToolbarsPart
    /// </summary>
    internal protected WordAttachedToolbarsPart()
            : base()
    {
    }
    
    

   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.microsoft.com/office/2006/relationships/attachedToolbars";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.ms-word.attachedToolbars";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@".";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"attachedToolbars";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetFileExtension
    /// </summary>
    internal const System.String TargetFileExtensionConstant =@".bin";
    /// <summary>
    /// Gets the TargetFileExtension.
    /// </summary>
    internal sealed override string TargetFileExtension
    {
       get { return TargetFileExtensionConstant; }
    } 
    



    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the AlternativeFormatImportPart.
/// </summary>
public partial class AlternativeFormatImportPart : OpenXmlPart 
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of AlternativeFormatImportPart
    /// </summary>
    internal protected AlternativeFormatImportPart()
            : base()
    {
    }
    
    

   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/officeDocument/2006/relationships/aFChunk";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@".";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"afchunk";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetFileExtension
    /// </summary>
    internal const System.String TargetFileExtensionConstant =@".dat";
    /// <summary>
    /// Gets the TargetFileExtension.
    /// </summary>
    internal sealed override string TargetFileExtension
    {
       get { return TargetFileExtensionConstant; }
    } 
    



    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return false; }
    }
}
/// <summary>
/// Defines the WordprocessingCommentsPart.
/// </summary>
public partial class WordprocessingCommentsPart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/aFChunk", new PartConstraintRule("AlternativeFormatImportPart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/chart", new PartConstraintRule("ChartPart", ChartPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramColors", new PartConstraintRule("DiagramColorsPart", DiagramColorsPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramData", new PartConstraintRule("DiagramDataPart", DiagramDataPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.microsoft.com/office/2007/relationships/diagramDrawing", new PartConstraintRule("DiagramPersistLayoutPart", DiagramPersistLayoutPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramLayout", new PartConstraintRule("DiagramLayoutDefinitionPart", DiagramLayoutDefinitionPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramQuickStyle", new PartConstraintRule("DiagramStylePart", DiagramStylePart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/control", new PartConstraintRule("EmbeddedControlPersistencePart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/oleObject", new PartConstraintRule("EmbeddedObjectPart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/package", new PartConstraintRule("EmbeddedPackagePart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/image", new PartConstraintRule("ImagePart", null, false, true,(FileFormatVersions)7 ));

            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/video", new PartConstraintRule("VideoReferenceRelationship", null, false, true,(FileFormatVersions)7 ));

            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of WordprocessingCommentsPart
    /// </summary>
    internal protected WordprocessingCommentsPart()
            : base()
    {
    }
    
    
    /// <summary>
    /// Create an instance of OpenXmlPart according to the given relationship type
    /// </summary>
    /// <param name="relationshipType">Relationship type</param>
    /// <returns>An instance of OpenXmlPart</returns>
    internal sealed override OpenXmlPart CreatePartCore(string relationshipType)
    {
        this.ThrowIfObjectDisposed();

        if ( relationshipType == null )
        {
            throw new ArgumentNullException("relationshipType");
        }
        switch (relationshipType)
        {
        case AlternativeFormatImportPart.RelationshipTypeConstant:
                    return new AlternativeFormatImportPart();
            
        case ChartPart.RelationshipTypeConstant:
                    return new ChartPart();        
            
        case DiagramColorsPart.RelationshipTypeConstant:
                    return new DiagramColorsPart();        
            
        case DiagramDataPart.RelationshipTypeConstant:
                    return new DiagramDataPart();        
            
        case DiagramPersistLayoutPart.RelationshipTypeConstant:
                    return new DiagramPersistLayoutPart();        
            
        case DiagramLayoutDefinitionPart.RelationshipTypeConstant:
                    return new DiagramLayoutDefinitionPart();        
            
        case DiagramStylePart.RelationshipTypeConstant:
                    return new DiagramStylePart();        
            
        case EmbeddedControlPersistencePart.RelationshipTypeConstant:
                    return new EmbeddedControlPersistencePart();
            
        case EmbeddedObjectPart.RelationshipTypeConstant:
                    return new EmbeddedObjectPart();
            
        case EmbeddedPackagePart.RelationshipTypeConstant:
                    return new EmbeddedPackagePart();
            
        case ImagePart.RelationshipTypeConstant:
                    return new ImagePart();
            

        }
        throw new ArgumentOutOfRangeException("relationshipType");
    }
    

        /// <summary>
    /// Adds a AlternativeFormatImportPart to the WordprocessingCommentsPart.
    /// </summary>
    /// <param name="contentType">the content type of the AlternativeFormatImportPart.</param>
    /// <returns>The newly added part.</returns>
    public AlternativeFormatImportPart AddAlternativeFormatImportPart(string contentType)
    {
        AlternativeFormatImportPart childPart = new AlternativeFormatImportPart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a AlternativeFormatImportPart to the WordprocessingCommentsPart.
    /// </summary>
    /// <param name="partType">The part type of the AlternativeFormatImportPart.</param>
    /// <returns>The newly added part.</returns>
     public AlternativeFormatImportPart AddAlternativeFormatImportPart(AlternativeFormatImportPartType partType)
    {
        string contentType = AlternativeFormatImportPartTypeInfo.GetContentType(partType);
        string partExtension = AlternativeFormatImportPartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddAlternativeFormatImportPart(contentType);
    }
    
    /// <summary>
    /// Adds a AlternativeFormatImportPart to the WordprocessingCommentsPart.
    /// </summary>
    /// <param name="contentType">the content type of the AlternativeFormatImportPart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public AlternativeFormatImportPart AddAlternativeFormatImportPart(string contentType, string id)
    {
        AlternativeFormatImportPart childPart = new AlternativeFormatImportPart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a AlternativeFormatImportPart to the WordprocessingCommentsPart.
    /// </summary>
    /// <param name="partType">The part type of the AlternativeFormatImportPart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public AlternativeFormatImportPart AddAlternativeFormatImportPart(AlternativeFormatImportPartType partType, string id)
    {
        string contentType = AlternativeFormatImportPartTypeInfo.GetContentType(partType);
        string partExtension = AlternativeFormatImportPartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddAlternativeFormatImportPart(contentType, id);
    }
    /// <summary>
    /// Adds a EmbeddedControlPersistencePart to the WordprocessingCommentsPart.
    /// </summary>
    /// <param name="contentType">the content type of the EmbeddedControlPersistencePart.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(string contentType)
    {
        EmbeddedControlPersistencePart childPart = new EmbeddedControlPersistencePart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a EmbeddedControlPersistencePart to the WordprocessingCommentsPart.
    /// </summary>
    /// <param name="partType">The part type of the EmbeddedControlPersistencePart.</param>
    /// <returns>The newly added part.</returns>
     public EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(EmbeddedControlPersistencePartType partType)
    {
        string contentType = EmbeddedControlPersistencePartTypeInfo.GetContentType(partType);
        string partExtension = EmbeddedControlPersistencePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddEmbeddedControlPersistencePart(contentType);
    }
    
    /// <summary>
    /// Adds a EmbeddedControlPersistencePart to the WordprocessingCommentsPart.
    /// </summary>
    /// <param name="contentType">the content type of the EmbeddedControlPersistencePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(string contentType, string id)
    {
        EmbeddedControlPersistencePart childPart = new EmbeddedControlPersistencePart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a EmbeddedControlPersistencePart to the WordprocessingCommentsPart.
    /// </summary>
    /// <param name="partType">The part type of the EmbeddedControlPersistencePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(EmbeddedControlPersistencePartType partType, string id)
    {
        string contentType = EmbeddedControlPersistencePartTypeInfo.GetContentType(partType);
        string partExtension = EmbeddedControlPersistencePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddEmbeddedControlPersistencePart(contentType, id);
    }
	/// <summary>
    /// Adds a EmbeddedObjectPart to the WordprocessingCommentsPart.
    /// </summary>
    /// <param name="contentType">The content type of the EmbeddedObjectPart.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedObjectPart AddEmbeddedObjectPart(string contentType)
    {
        EmbeddedObjectPart childPart = new EmbeddedObjectPart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
	/// <summary>
    /// Adds a EmbeddedPackagePart to the WordprocessingCommentsPart.
    /// </summary>
    /// <param name="contentType">The content type of the EmbeddedPackagePart.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedPackagePart AddEmbeddedPackagePart(string contentType)
    {
        EmbeddedPackagePart childPart = new EmbeddedPackagePart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a ImagePart to the WordprocessingCommentsPart.
    /// </summary>
    /// <param name="contentType">the content type of the ImagePart.</param>
    /// <returns>The newly added part.</returns>
    public ImagePart AddImagePart(string contentType)
    {
        ImagePart childPart = new ImagePart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a ImagePart to the WordprocessingCommentsPart.
    /// </summary>
    /// <param name="partType">The part type of the ImagePart.</param>
    /// <returns>The newly added part.</returns>
     public ImagePart AddImagePart(ImagePartType partType)
    {
        string contentType = ImagePartTypeInfo.GetContentType(partType);
        string partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddImagePart(contentType);
    }
    
    /// <summary>
    /// Adds a ImagePart to the WordprocessingCommentsPart.
    /// </summary>
    /// <param name="contentType">the content type of the ImagePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public ImagePart AddImagePart(string contentType, string id)
    {
        ImagePart childPart = new ImagePart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a ImagePart to the WordprocessingCommentsPart.
    /// </summary>
    /// <param name="partType">The part type of the ImagePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public ImagePart AddImagePart(ImagePartType partType, string id)
    {
        string contentType = ImagePartTypeInfo.GetContentType(partType);
        string partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddImagePart(contentType, id);
    }
    /// <summary>
    /// Adds a new <see cref="VideoReferenceRelationship"/> to the specified <see cref="MediaDataPart"/>.
    /// </summary>
    /// <param name="mediaDataPart">The specified target <see cref="MediaDataPart"/>.</param>
    /// <returns>The new <see cref="VideoReferenceRelationship"/>.</returns>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="mediaDataPart"/> is null.</exception>
    /// <exception cref="InvalidOperationException">Thrown when the specified <paramref name="mediaDataPart"/> is not in this document.</exception>
    public VideoReferenceRelationship AddVideoReferenceRelationship(MediaDataPart mediaDataPart)
    {
            return AddDataPartReferenceRelationship<VideoReferenceRelationship>(mediaDataPart);
    }
    /// <summary>
    /// Adds a new <see cref="VideoReferenceRelationship"/> to the specified <see cref="MediaDataPart"/>.
    /// </summary>
    /// <param name="mediaDataPart">The specified target <see cref="MediaDataPart"/>.</param>
    /// <param name="id">The desired relationship ID. </param>
    /// <returns>The new <see cref="VideoReferenceRelationship"/>.</returns>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="mediaDataPart"/> is null.</exception>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="id"/> is null.</exception>
    /// <exception cref="InvalidOperationException">Thrown when the specified <paramref name="mediaDataPart"/> is not in this document.</exception>
    public VideoReferenceRelationship AddVideoReferenceRelationship(MediaDataPart mediaDataPart, string id)
    {
            return AddDataPartReferenceRelationship<VideoReferenceRelationship>(mediaDataPart, id);
    }
 
    
    
   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/officeDocument/2006/relationships/comments";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.openxmlformats-officedocument.wordprocessingml.comments+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@".";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"comments";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    

        /// <summary>
        /// Gets the AlternativeFormatImportParts of the WordprocessingCommentsPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<AlternativeFormatImportPart> AlternativeFormatImportParts
        {
            get{
                    return this.GetPartsOfType<AlternativeFormatImportPart>();
                }
        }
                
        /// <summary>
        /// Gets the ChartParts of the WordprocessingCommentsPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<ChartPart> ChartParts
        {
            get{
                    return this.GetPartsOfType<ChartPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramColorsParts of the WordprocessingCommentsPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramColorsPart> DiagramColorsParts
        {
            get{
                    return this.GetPartsOfType<DiagramColorsPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramDataParts of the WordprocessingCommentsPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramDataPart> DiagramDataParts
        {
            get{
                    return this.GetPartsOfType<DiagramDataPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramPersistLayoutParts of the WordprocessingCommentsPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramPersistLayoutPart> DiagramPersistLayoutParts
        {
            get{
                    return this.GetPartsOfType<DiagramPersistLayoutPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramLayoutDefinitionParts of the WordprocessingCommentsPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramLayoutDefinitionPart> DiagramLayoutDefinitionParts
        {
            get{
                    return this.GetPartsOfType<DiagramLayoutDefinitionPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramStyleParts of the WordprocessingCommentsPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramStylePart> DiagramStyleParts
        {
            get{
                    return this.GetPartsOfType<DiagramStylePart>();
                }
        }
                
        /// <summary>
        /// Gets the EmbeddedControlPersistenceParts of the WordprocessingCommentsPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<EmbeddedControlPersistencePart> EmbeddedControlPersistenceParts
        {
            get{
                    return this.GetPartsOfType<EmbeddedControlPersistencePart>();
                }
        }
                
        /// <summary>
        /// Gets the EmbeddedObjectParts of the WordprocessingCommentsPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<EmbeddedObjectPart> EmbeddedObjectParts
        {
            get{
                    return this.GetPartsOfType<EmbeddedObjectPart>();
                }
        }
                
        /// <summary>
        /// Gets the EmbeddedPackageParts of the WordprocessingCommentsPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<EmbeddedPackagePart> EmbeddedPackageParts
        {
            get{
                    return this.GetPartsOfType<EmbeddedPackagePart>();
                }
        }
                
        /// <summary>
        /// Gets the ImageParts of the WordprocessingCommentsPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<ImagePart> ImageParts
        {
            get{
                    return this.GetPartsOfType<ImagePart>();
                }
        }
                


    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the DocumentSettingsPart.
/// </summary>
public partial class DocumentSettingsPart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/recipientData", new PartConstraintRule("MailMergeRecipientDataPart", null, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/image", new PartConstraintRule("ImagePart", null, false, true,(FileFormatVersions)7 ));

            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of DocumentSettingsPart
    /// </summary>
    internal protected DocumentSettingsPart()
            : base()
    {
    }
    
    
    /// <summary>
    /// Create an instance of OpenXmlPart according to the given relationship type
    /// </summary>
    /// <param name="relationshipType">Relationship type</param>
    /// <returns>An instance of OpenXmlPart</returns>
    internal sealed override OpenXmlPart CreatePartCore(string relationshipType)
    {
        this.ThrowIfObjectDisposed();

        if ( relationshipType == null )
        {
            throw new ArgumentNullException("relationshipType");
        }
        switch (relationshipType)
        {
        case MailMergeRecipientDataPart.RelationshipTypeConstant:
                    return new MailMergeRecipientDataPart();
            
        case ImagePart.RelationshipTypeConstant:
                    return new ImagePart();
            

        }
        throw new ArgumentOutOfRangeException("relationshipType");
    }
    

        /// <summary>
    /// Adds a MailMergeRecipientDataPart to the DocumentSettingsPart.
    /// </summary>
    /// <param name="contentType">the content type of the MailMergeRecipientDataPart.</param>
    /// <returns>The newly added part.</returns>
    public MailMergeRecipientDataPart AddMailMergeRecipientDataPart(string contentType)
    {
        MailMergeRecipientDataPart childPart = new MailMergeRecipientDataPart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a MailMergeRecipientDataPart to the DocumentSettingsPart.
    /// </summary>
    /// <param name="partType">The part type of the MailMergeRecipientDataPart.</param>
    /// <returns>The newly added part.</returns>
     public MailMergeRecipientDataPart AddMailMergeRecipientDataPart(MailMergeRecipientDataPartType partType)
    {
        string contentType = MailMergeRecipientDataPartTypeInfo.GetContentType(partType);
        string partExtension = MailMergeRecipientDataPartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddMailMergeRecipientDataPart(contentType);
    }
    
    /// <summary>
    /// Adds a MailMergeRecipientDataPart to the DocumentSettingsPart.
    /// </summary>
    /// <param name="contentType">the content type of the MailMergeRecipientDataPart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public MailMergeRecipientDataPart AddMailMergeRecipientDataPart(string contentType, string id)
    {
        MailMergeRecipientDataPart childPart = new MailMergeRecipientDataPart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a MailMergeRecipientDataPart to the DocumentSettingsPart.
    /// </summary>
    /// <param name="partType">The part type of the MailMergeRecipientDataPart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public MailMergeRecipientDataPart AddMailMergeRecipientDataPart(MailMergeRecipientDataPartType partType, string id)
    {
        string contentType = MailMergeRecipientDataPartTypeInfo.GetContentType(partType);
        string partExtension = MailMergeRecipientDataPartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddMailMergeRecipientDataPart(contentType, id);
    }
    /// <summary>
    /// Adds a ImagePart to the DocumentSettingsPart.
    /// </summary>
    /// <param name="contentType">the content type of the ImagePart.</param>
    /// <returns>The newly added part.</returns>
    public ImagePart AddImagePart(string contentType)
    {
        ImagePart childPart = new ImagePart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a ImagePart to the DocumentSettingsPart.
    /// </summary>
    /// <param name="partType">The part type of the ImagePart.</param>
    /// <returns>The newly added part.</returns>
     public ImagePart AddImagePart(ImagePartType partType)
    {
        string contentType = ImagePartTypeInfo.GetContentType(partType);
        string partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddImagePart(contentType);
    }
    
    /// <summary>
    /// Adds a ImagePart to the DocumentSettingsPart.
    /// </summary>
    /// <param name="contentType">the content type of the ImagePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public ImagePart AddImagePart(string contentType, string id)
    {
        ImagePart childPart = new ImagePart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a ImagePart to the DocumentSettingsPart.
    /// </summary>
    /// <param name="partType">The part type of the ImagePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public ImagePart AddImagePart(ImagePartType partType, string id)
    {
        string contentType = ImagePartTypeInfo.GetContentType(partType);
        string partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddImagePart(contentType, id);
    }
 
    
    
   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/officeDocument/2006/relationships/settings";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.openxmlformats-officedocument.wordprocessingml.settings+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@".";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"settings";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    

        /// <summary>
        /// Gets the MailMergeRecipientDataPart of the DocumentSettingsPart.
        /// </summary>
        public MailMergeRecipientDataPart MailMergeRecipientDataPart
        {
            get {return GetSubPartOfType<MailMergeRecipientDataPart>(); }
        }
        /// <summary>
        /// Gets the ImageParts of the DocumentSettingsPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<ImagePart> ImageParts
        {
            get{
                    return this.GetPartsOfType<ImagePart>();
                }
        }
                


    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the EndnotesPart.
/// </summary>
public partial class EndnotesPart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/aFChunk", new PartConstraintRule("AlternativeFormatImportPart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/chart", new PartConstraintRule("ChartPart", ChartPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramColors", new PartConstraintRule("DiagramColorsPart", DiagramColorsPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramData", new PartConstraintRule("DiagramDataPart", DiagramDataPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.microsoft.com/office/2007/relationships/diagramDrawing", new PartConstraintRule("DiagramPersistLayoutPart", DiagramPersistLayoutPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramLayout", new PartConstraintRule("DiagramLayoutDefinitionPart", DiagramLayoutDefinitionPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramQuickStyle", new PartConstraintRule("DiagramStylePart", DiagramStylePart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/control", new PartConstraintRule("EmbeddedControlPersistencePart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/oleObject", new PartConstraintRule("EmbeddedObjectPart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/package", new PartConstraintRule("EmbeddedPackagePart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/image", new PartConstraintRule("ImagePart", null, false, true,(FileFormatVersions)7 ));

            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/video", new PartConstraintRule("VideoReferenceRelationship", null, false, true,(FileFormatVersions)7 ));

            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of EndnotesPart
    /// </summary>
    internal protected EndnotesPart()
            : base()
    {
    }
    
    
    /// <summary>
    /// Create an instance of OpenXmlPart according to the given relationship type
    /// </summary>
    /// <param name="relationshipType">Relationship type</param>
    /// <returns>An instance of OpenXmlPart</returns>
    internal sealed override OpenXmlPart CreatePartCore(string relationshipType)
    {
        this.ThrowIfObjectDisposed();

        if ( relationshipType == null )
        {
            throw new ArgumentNullException("relationshipType");
        }
        switch (relationshipType)
        {
        case AlternativeFormatImportPart.RelationshipTypeConstant:
                    return new AlternativeFormatImportPart();
            
        case ChartPart.RelationshipTypeConstant:
                    return new ChartPart();        
            
        case DiagramColorsPart.RelationshipTypeConstant:
                    return new DiagramColorsPart();        
            
        case DiagramDataPart.RelationshipTypeConstant:
                    return new DiagramDataPart();        
            
        case DiagramPersistLayoutPart.RelationshipTypeConstant:
                    return new DiagramPersistLayoutPart();        
            
        case DiagramLayoutDefinitionPart.RelationshipTypeConstant:
                    return new DiagramLayoutDefinitionPart();        
            
        case DiagramStylePart.RelationshipTypeConstant:
                    return new DiagramStylePart();        
            
        case EmbeddedControlPersistencePart.RelationshipTypeConstant:
                    return new EmbeddedControlPersistencePart();
            
        case EmbeddedObjectPart.RelationshipTypeConstant:
                    return new EmbeddedObjectPart();
            
        case EmbeddedPackagePart.RelationshipTypeConstant:
                    return new EmbeddedPackagePart();
            
        case ImagePart.RelationshipTypeConstant:
                    return new ImagePart();
            

        }
        throw new ArgumentOutOfRangeException("relationshipType");
    }
    

        /// <summary>
    /// Adds a AlternativeFormatImportPart to the EndnotesPart.
    /// </summary>
    /// <param name="contentType">the content type of the AlternativeFormatImportPart.</param>
    /// <returns>The newly added part.</returns>
    public AlternativeFormatImportPart AddAlternativeFormatImportPart(string contentType)
    {
        AlternativeFormatImportPart childPart = new AlternativeFormatImportPart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a AlternativeFormatImportPart to the EndnotesPart.
    /// </summary>
    /// <param name="partType">The part type of the AlternativeFormatImportPart.</param>
    /// <returns>The newly added part.</returns>
     public AlternativeFormatImportPart AddAlternativeFormatImportPart(AlternativeFormatImportPartType partType)
    {
        string contentType = AlternativeFormatImportPartTypeInfo.GetContentType(partType);
        string partExtension = AlternativeFormatImportPartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddAlternativeFormatImportPart(contentType);
    }
    
    /// <summary>
    /// Adds a AlternativeFormatImportPart to the EndnotesPart.
    /// </summary>
    /// <param name="contentType">the content type of the AlternativeFormatImportPart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public AlternativeFormatImportPart AddAlternativeFormatImportPart(string contentType, string id)
    {
        AlternativeFormatImportPart childPart = new AlternativeFormatImportPart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a AlternativeFormatImportPart to the EndnotesPart.
    /// </summary>
    /// <param name="partType">The part type of the AlternativeFormatImportPart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public AlternativeFormatImportPart AddAlternativeFormatImportPart(AlternativeFormatImportPartType partType, string id)
    {
        string contentType = AlternativeFormatImportPartTypeInfo.GetContentType(partType);
        string partExtension = AlternativeFormatImportPartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddAlternativeFormatImportPart(contentType, id);
    }
    /// <summary>
    /// Adds a EmbeddedControlPersistencePart to the EndnotesPart.
    /// </summary>
    /// <param name="contentType">the content type of the EmbeddedControlPersistencePart.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(string contentType)
    {
        EmbeddedControlPersistencePart childPart = new EmbeddedControlPersistencePart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a EmbeddedControlPersistencePart to the EndnotesPart.
    /// </summary>
    /// <param name="partType">The part type of the EmbeddedControlPersistencePart.</param>
    /// <returns>The newly added part.</returns>
     public EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(EmbeddedControlPersistencePartType partType)
    {
        string contentType = EmbeddedControlPersistencePartTypeInfo.GetContentType(partType);
        string partExtension = EmbeddedControlPersistencePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddEmbeddedControlPersistencePart(contentType);
    }
    
    /// <summary>
    /// Adds a EmbeddedControlPersistencePart to the EndnotesPart.
    /// </summary>
    /// <param name="contentType">the content type of the EmbeddedControlPersistencePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(string contentType, string id)
    {
        EmbeddedControlPersistencePart childPart = new EmbeddedControlPersistencePart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a EmbeddedControlPersistencePart to the EndnotesPart.
    /// </summary>
    /// <param name="partType">The part type of the EmbeddedControlPersistencePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(EmbeddedControlPersistencePartType partType, string id)
    {
        string contentType = EmbeddedControlPersistencePartTypeInfo.GetContentType(partType);
        string partExtension = EmbeddedControlPersistencePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddEmbeddedControlPersistencePart(contentType, id);
    }
	/// <summary>
    /// Adds a EmbeddedObjectPart to the EndnotesPart.
    /// </summary>
    /// <param name="contentType">The content type of the EmbeddedObjectPart.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedObjectPart AddEmbeddedObjectPart(string contentType)
    {
        EmbeddedObjectPart childPart = new EmbeddedObjectPart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
	/// <summary>
    /// Adds a EmbeddedPackagePart to the EndnotesPart.
    /// </summary>
    /// <param name="contentType">The content type of the EmbeddedPackagePart.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedPackagePart AddEmbeddedPackagePart(string contentType)
    {
        EmbeddedPackagePart childPart = new EmbeddedPackagePart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a ImagePart to the EndnotesPart.
    /// </summary>
    /// <param name="contentType">the content type of the ImagePart.</param>
    /// <returns>The newly added part.</returns>
    public ImagePart AddImagePart(string contentType)
    {
        ImagePart childPart = new ImagePart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a ImagePart to the EndnotesPart.
    /// </summary>
    /// <param name="partType">The part type of the ImagePart.</param>
    /// <returns>The newly added part.</returns>
     public ImagePart AddImagePart(ImagePartType partType)
    {
        string contentType = ImagePartTypeInfo.GetContentType(partType);
        string partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddImagePart(contentType);
    }
    
    /// <summary>
    /// Adds a ImagePart to the EndnotesPart.
    /// </summary>
    /// <param name="contentType">the content type of the ImagePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public ImagePart AddImagePart(string contentType, string id)
    {
        ImagePart childPart = new ImagePart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a ImagePart to the EndnotesPart.
    /// </summary>
    /// <param name="partType">The part type of the ImagePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public ImagePart AddImagePart(ImagePartType partType, string id)
    {
        string contentType = ImagePartTypeInfo.GetContentType(partType);
        string partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddImagePart(contentType, id);
    }
    /// <summary>
    /// Adds a new <see cref="VideoReferenceRelationship"/> to the specified <see cref="MediaDataPart"/>.
    /// </summary>
    /// <param name="mediaDataPart">The specified target <see cref="MediaDataPart"/>.</param>
    /// <returns>The new <see cref="VideoReferenceRelationship"/>.</returns>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="mediaDataPart"/> is null.</exception>
    /// <exception cref="InvalidOperationException">Thrown when the specified <paramref name="mediaDataPart"/> is not in this document.</exception>
    public VideoReferenceRelationship AddVideoReferenceRelationship(MediaDataPart mediaDataPart)
    {
            return AddDataPartReferenceRelationship<VideoReferenceRelationship>(mediaDataPart);
    }
    /// <summary>
    /// Adds a new <see cref="VideoReferenceRelationship"/> to the specified <see cref="MediaDataPart"/>.
    /// </summary>
    /// <param name="mediaDataPart">The specified target <see cref="MediaDataPart"/>.</param>
    /// <param name="id">The desired relationship ID. </param>
    /// <returns>The new <see cref="VideoReferenceRelationship"/>.</returns>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="mediaDataPart"/> is null.</exception>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="id"/> is null.</exception>
    /// <exception cref="InvalidOperationException">Thrown when the specified <paramref name="mediaDataPart"/> is not in this document.</exception>
    public VideoReferenceRelationship AddVideoReferenceRelationship(MediaDataPart mediaDataPart, string id)
    {
            return AddDataPartReferenceRelationship<VideoReferenceRelationship>(mediaDataPart, id);
    }
 
    
    
   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/officeDocument/2006/relationships/endnotes";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.openxmlformats-officedocument.wordprocessingml.endnotes+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@".";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"endnotes";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    

        /// <summary>
        /// Gets the AlternativeFormatImportParts of the EndnotesPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<AlternativeFormatImportPart> AlternativeFormatImportParts
        {
            get{
                    return this.GetPartsOfType<AlternativeFormatImportPart>();
                }
        }
                
        /// <summary>
        /// Gets the ChartParts of the EndnotesPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<ChartPart> ChartParts
        {
            get{
                    return this.GetPartsOfType<ChartPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramColorsParts of the EndnotesPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramColorsPart> DiagramColorsParts
        {
            get{
                    return this.GetPartsOfType<DiagramColorsPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramDataParts of the EndnotesPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramDataPart> DiagramDataParts
        {
            get{
                    return this.GetPartsOfType<DiagramDataPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramPersistLayoutParts of the EndnotesPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramPersistLayoutPart> DiagramPersistLayoutParts
        {
            get{
                    return this.GetPartsOfType<DiagramPersistLayoutPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramLayoutDefinitionParts of the EndnotesPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramLayoutDefinitionPart> DiagramLayoutDefinitionParts
        {
            get{
                    return this.GetPartsOfType<DiagramLayoutDefinitionPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramStyleParts of the EndnotesPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramStylePart> DiagramStyleParts
        {
            get{
                    return this.GetPartsOfType<DiagramStylePart>();
                }
        }
                
        /// <summary>
        /// Gets the EmbeddedControlPersistenceParts of the EndnotesPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<EmbeddedControlPersistencePart> EmbeddedControlPersistenceParts
        {
            get{
                    return this.GetPartsOfType<EmbeddedControlPersistencePart>();
                }
        }
                
        /// <summary>
        /// Gets the EmbeddedObjectParts of the EndnotesPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<EmbeddedObjectPart> EmbeddedObjectParts
        {
            get{
                    return this.GetPartsOfType<EmbeddedObjectPart>();
                }
        }
                
        /// <summary>
        /// Gets the EmbeddedPackageParts of the EndnotesPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<EmbeddedPackagePart> EmbeddedPackageParts
        {
            get{
                    return this.GetPartsOfType<EmbeddedPackagePart>();
                }
        }
                
        /// <summary>
        /// Gets the ImageParts of the EndnotesPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<ImagePart> ImageParts
        {
            get{
                    return this.GetPartsOfType<ImagePart>();
                }
        }
                


    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the FontTablePart.
/// </summary>
public partial class FontTablePart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/font", new PartConstraintRule("FontPart", null, false, true,(FileFormatVersions)7 ));

            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of FontTablePart
    /// </summary>
    internal protected FontTablePart()
            : base()
    {
    }
    
    
    /// <summary>
    /// Create an instance of OpenXmlPart according to the given relationship type
    /// </summary>
    /// <param name="relationshipType">Relationship type</param>
    /// <returns>An instance of OpenXmlPart</returns>
    internal sealed override OpenXmlPart CreatePartCore(string relationshipType)
    {
        this.ThrowIfObjectDisposed();

        if ( relationshipType == null )
        {
            throw new ArgumentNullException("relationshipType");
        }
        switch (relationshipType)
        {
        case FontPart.RelationshipTypeConstant:
                    return new FontPart();
            

        }
        throw new ArgumentOutOfRangeException("relationshipType");
    }
    

        /// <summary>
    /// Adds a FontPart to the FontTablePart.
    /// </summary>
    /// <param name="contentType">the content type of the FontPart.</param>
    /// <returns>The newly added part.</returns>
    public FontPart AddFontPart(string contentType)
    {
        FontPart childPart = new FontPart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a FontPart to the FontTablePart.
    /// </summary>
    /// <param name="partType">The part type of the FontPart.</param>
    /// <returns>The newly added part.</returns>
     public FontPart AddFontPart(FontPartType partType)
    {
        string contentType = FontPartTypeInfo.GetContentType(partType);
        string partExtension = FontPartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddFontPart(contentType);
    }
    
    /// <summary>
    /// Adds a FontPart to the FontTablePart.
    /// </summary>
    /// <param name="contentType">the content type of the FontPart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public FontPart AddFontPart(string contentType, string id)
    {
        FontPart childPart = new FontPart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a FontPart to the FontTablePart.
    /// </summary>
    /// <param name="partType">The part type of the FontPart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public FontPart AddFontPart(FontPartType partType, string id)
    {
        string contentType = FontPartTypeInfo.GetContentType(partType);
        string partExtension = FontPartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddFontPart(contentType, id);
    }
 
    
    
   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/officeDocument/2006/relationships/fontTable";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.openxmlformats-officedocument.wordprocessingml.fontTable+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@".";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"fontTable";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    

        /// <summary>
        /// Gets the FontParts of the FontTablePart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<FontPart> FontParts
        {
            get{
                    return this.GetPartsOfType<FontPart>();
                }
        }
                


    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the FooterPart.
/// </summary>
public partial class FooterPart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/aFChunk", new PartConstraintRule("AlternativeFormatImportPart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/chart", new PartConstraintRule("ChartPart", ChartPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramColors", new PartConstraintRule("DiagramColorsPart", DiagramColorsPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramData", new PartConstraintRule("DiagramDataPart", DiagramDataPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.microsoft.com/office/2007/relationships/diagramDrawing", new PartConstraintRule("DiagramPersistLayoutPart", DiagramPersistLayoutPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramLayout", new PartConstraintRule("DiagramLayoutDefinitionPart", DiagramLayoutDefinitionPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramQuickStyle", new PartConstraintRule("DiagramStylePart", DiagramStylePart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/control", new PartConstraintRule("EmbeddedControlPersistencePart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/oleObject", new PartConstraintRule("EmbeddedObjectPart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/package", new PartConstraintRule("EmbeddedPackagePart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/image", new PartConstraintRule("ImagePart", null, false, true,(FileFormatVersions)7 ));

            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/video", new PartConstraintRule("VideoReferenceRelationship", null, false, true,(FileFormatVersions)7 ));

            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of FooterPart
    /// </summary>
    internal protected FooterPart()
            : base()
    {
    }
    
    
    /// <summary>
    /// Create an instance of OpenXmlPart according to the given relationship type
    /// </summary>
    /// <param name="relationshipType">Relationship type</param>
    /// <returns>An instance of OpenXmlPart</returns>
    internal sealed override OpenXmlPart CreatePartCore(string relationshipType)
    {
        this.ThrowIfObjectDisposed();

        if ( relationshipType == null )
        {
            throw new ArgumentNullException("relationshipType");
        }
        switch (relationshipType)
        {
        case AlternativeFormatImportPart.RelationshipTypeConstant:
                    return new AlternativeFormatImportPart();
            
        case ChartPart.RelationshipTypeConstant:
                    return new ChartPart();        
            
        case DiagramColorsPart.RelationshipTypeConstant:
                    return new DiagramColorsPart();        
            
        case DiagramDataPart.RelationshipTypeConstant:
                    return new DiagramDataPart();        
            
        case DiagramPersistLayoutPart.RelationshipTypeConstant:
                    return new DiagramPersistLayoutPart();        
            
        case DiagramLayoutDefinitionPart.RelationshipTypeConstant:
                    return new DiagramLayoutDefinitionPart();        
            
        case DiagramStylePart.RelationshipTypeConstant:
                    return new DiagramStylePart();        
            
        case EmbeddedControlPersistencePart.RelationshipTypeConstant:
                    return new EmbeddedControlPersistencePart();
            
        case EmbeddedObjectPart.RelationshipTypeConstant:
                    return new EmbeddedObjectPart();
            
        case EmbeddedPackagePart.RelationshipTypeConstant:
                    return new EmbeddedPackagePart();
            
        case ImagePart.RelationshipTypeConstant:
                    return new ImagePart();
            

        }
        throw new ArgumentOutOfRangeException("relationshipType");
    }
    

        /// <summary>
    /// Adds a AlternativeFormatImportPart to the FooterPart.
    /// </summary>
    /// <param name="contentType">the content type of the AlternativeFormatImportPart.</param>
    /// <returns>The newly added part.</returns>
    public AlternativeFormatImportPart AddAlternativeFormatImportPart(string contentType)
    {
        AlternativeFormatImportPart childPart = new AlternativeFormatImportPart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a AlternativeFormatImportPart to the FooterPart.
    /// </summary>
    /// <param name="partType">The part type of the AlternativeFormatImportPart.</param>
    /// <returns>The newly added part.</returns>
     public AlternativeFormatImportPart AddAlternativeFormatImportPart(AlternativeFormatImportPartType partType)
    {
        string contentType = AlternativeFormatImportPartTypeInfo.GetContentType(partType);
        string partExtension = AlternativeFormatImportPartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddAlternativeFormatImportPart(contentType);
    }
    
    /// <summary>
    /// Adds a AlternativeFormatImportPart to the FooterPart.
    /// </summary>
    /// <param name="contentType">the content type of the AlternativeFormatImportPart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public AlternativeFormatImportPart AddAlternativeFormatImportPart(string contentType, string id)
    {
        AlternativeFormatImportPart childPart = new AlternativeFormatImportPart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a AlternativeFormatImportPart to the FooterPart.
    /// </summary>
    /// <param name="partType">The part type of the AlternativeFormatImportPart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public AlternativeFormatImportPart AddAlternativeFormatImportPart(AlternativeFormatImportPartType partType, string id)
    {
        string contentType = AlternativeFormatImportPartTypeInfo.GetContentType(partType);
        string partExtension = AlternativeFormatImportPartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddAlternativeFormatImportPart(contentType, id);
    }
    /// <summary>
    /// Adds a EmbeddedControlPersistencePart to the FooterPart.
    /// </summary>
    /// <param name="contentType">the content type of the EmbeddedControlPersistencePart.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(string contentType)
    {
        EmbeddedControlPersistencePart childPart = new EmbeddedControlPersistencePart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a EmbeddedControlPersistencePart to the FooterPart.
    /// </summary>
    /// <param name="partType">The part type of the EmbeddedControlPersistencePart.</param>
    /// <returns>The newly added part.</returns>
     public EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(EmbeddedControlPersistencePartType partType)
    {
        string contentType = EmbeddedControlPersistencePartTypeInfo.GetContentType(partType);
        string partExtension = EmbeddedControlPersistencePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddEmbeddedControlPersistencePart(contentType);
    }
    
    /// <summary>
    /// Adds a EmbeddedControlPersistencePart to the FooterPart.
    /// </summary>
    /// <param name="contentType">the content type of the EmbeddedControlPersistencePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(string contentType, string id)
    {
        EmbeddedControlPersistencePart childPart = new EmbeddedControlPersistencePart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a EmbeddedControlPersistencePart to the FooterPart.
    /// </summary>
    /// <param name="partType">The part type of the EmbeddedControlPersistencePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(EmbeddedControlPersistencePartType partType, string id)
    {
        string contentType = EmbeddedControlPersistencePartTypeInfo.GetContentType(partType);
        string partExtension = EmbeddedControlPersistencePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddEmbeddedControlPersistencePart(contentType, id);
    }
	/// <summary>
    /// Adds a EmbeddedObjectPart to the FooterPart.
    /// </summary>
    /// <param name="contentType">The content type of the EmbeddedObjectPart.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedObjectPart AddEmbeddedObjectPart(string contentType)
    {
        EmbeddedObjectPart childPart = new EmbeddedObjectPart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
	/// <summary>
    /// Adds a EmbeddedPackagePart to the FooterPart.
    /// </summary>
    /// <param name="contentType">The content type of the EmbeddedPackagePart.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedPackagePart AddEmbeddedPackagePart(string contentType)
    {
        EmbeddedPackagePart childPart = new EmbeddedPackagePart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a ImagePart to the FooterPart.
    /// </summary>
    /// <param name="contentType">the content type of the ImagePart.</param>
    /// <returns>The newly added part.</returns>
    public ImagePart AddImagePart(string contentType)
    {
        ImagePart childPart = new ImagePart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a ImagePart to the FooterPart.
    /// </summary>
    /// <param name="partType">The part type of the ImagePart.</param>
    /// <returns>The newly added part.</returns>
     public ImagePart AddImagePart(ImagePartType partType)
    {
        string contentType = ImagePartTypeInfo.GetContentType(partType);
        string partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddImagePart(contentType);
    }
    
    /// <summary>
    /// Adds a ImagePart to the FooterPart.
    /// </summary>
    /// <param name="contentType">the content type of the ImagePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public ImagePart AddImagePart(string contentType, string id)
    {
        ImagePart childPart = new ImagePart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a ImagePart to the FooterPart.
    /// </summary>
    /// <param name="partType">The part type of the ImagePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public ImagePart AddImagePart(ImagePartType partType, string id)
    {
        string contentType = ImagePartTypeInfo.GetContentType(partType);
        string partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddImagePart(contentType, id);
    }
    /// <summary>
    /// Adds a new <see cref="VideoReferenceRelationship"/> to the specified <see cref="MediaDataPart"/>.
    /// </summary>
    /// <param name="mediaDataPart">The specified target <see cref="MediaDataPart"/>.</param>
    /// <returns>The new <see cref="VideoReferenceRelationship"/>.</returns>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="mediaDataPart"/> is null.</exception>
    /// <exception cref="InvalidOperationException">Thrown when the specified <paramref name="mediaDataPart"/> is not in this document.</exception>
    public VideoReferenceRelationship AddVideoReferenceRelationship(MediaDataPart mediaDataPart)
    {
            return AddDataPartReferenceRelationship<VideoReferenceRelationship>(mediaDataPart);
    }
    /// <summary>
    /// Adds a new <see cref="VideoReferenceRelationship"/> to the specified <see cref="MediaDataPart"/>.
    /// </summary>
    /// <param name="mediaDataPart">The specified target <see cref="MediaDataPart"/>.</param>
    /// <param name="id">The desired relationship ID. </param>
    /// <returns>The new <see cref="VideoReferenceRelationship"/>.</returns>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="mediaDataPart"/> is null.</exception>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="id"/> is null.</exception>
    /// <exception cref="InvalidOperationException">Thrown when the specified <paramref name="mediaDataPart"/> is not in this document.</exception>
    public VideoReferenceRelationship AddVideoReferenceRelationship(MediaDataPart mediaDataPart, string id)
    {
            return AddDataPartReferenceRelationship<VideoReferenceRelationship>(mediaDataPart, id);
    }
 
    
    
   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/officeDocument/2006/relationships/footer";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.openxmlformats-officedocument.wordprocessingml.footer+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@".";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"footer";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    

        /// <summary>
        /// Gets the AlternativeFormatImportParts of the FooterPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<AlternativeFormatImportPart> AlternativeFormatImportParts
        {
            get{
                    return this.GetPartsOfType<AlternativeFormatImportPart>();
                }
        }
                
        /// <summary>
        /// Gets the ChartParts of the FooterPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<ChartPart> ChartParts
        {
            get{
                    return this.GetPartsOfType<ChartPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramColorsParts of the FooterPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramColorsPart> DiagramColorsParts
        {
            get{
                    return this.GetPartsOfType<DiagramColorsPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramDataParts of the FooterPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramDataPart> DiagramDataParts
        {
            get{
                    return this.GetPartsOfType<DiagramDataPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramPersistLayoutParts of the FooterPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramPersistLayoutPart> DiagramPersistLayoutParts
        {
            get{
                    return this.GetPartsOfType<DiagramPersistLayoutPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramLayoutDefinitionParts of the FooterPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramLayoutDefinitionPart> DiagramLayoutDefinitionParts
        {
            get{
                    return this.GetPartsOfType<DiagramLayoutDefinitionPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramStyleParts of the FooterPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramStylePart> DiagramStyleParts
        {
            get{
                    return this.GetPartsOfType<DiagramStylePart>();
                }
        }
                
        /// <summary>
        /// Gets the EmbeddedControlPersistenceParts of the FooterPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<EmbeddedControlPersistencePart> EmbeddedControlPersistenceParts
        {
            get{
                    return this.GetPartsOfType<EmbeddedControlPersistencePart>();
                }
        }
                
        /// <summary>
        /// Gets the EmbeddedObjectParts of the FooterPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<EmbeddedObjectPart> EmbeddedObjectParts
        {
            get{
                    return this.GetPartsOfType<EmbeddedObjectPart>();
                }
        }
                
        /// <summary>
        /// Gets the EmbeddedPackageParts of the FooterPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<EmbeddedPackagePart> EmbeddedPackageParts
        {
            get{
                    return this.GetPartsOfType<EmbeddedPackagePart>();
                }
        }
                
        /// <summary>
        /// Gets the ImageParts of the FooterPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<ImagePart> ImageParts
        {
            get{
                    return this.GetPartsOfType<ImagePart>();
                }
        }
                


    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the FootnotesPart.
/// </summary>
public partial class FootnotesPart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/aFChunk", new PartConstraintRule("AlternativeFormatImportPart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/chart", new PartConstraintRule("ChartPart", ChartPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramColors", new PartConstraintRule("DiagramColorsPart", DiagramColorsPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramData", new PartConstraintRule("DiagramDataPart", DiagramDataPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.microsoft.com/office/2007/relationships/diagramDrawing", new PartConstraintRule("DiagramPersistLayoutPart", DiagramPersistLayoutPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramLayout", new PartConstraintRule("DiagramLayoutDefinitionPart", DiagramLayoutDefinitionPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramQuickStyle", new PartConstraintRule("DiagramStylePart", DiagramStylePart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/control", new PartConstraintRule("EmbeddedControlPersistencePart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/oleObject", new PartConstraintRule("EmbeddedObjectPart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/package", new PartConstraintRule("EmbeddedPackagePart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/image", new PartConstraintRule("ImagePart", null, false, true,(FileFormatVersions)7 ));

            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/video", new PartConstraintRule("VideoReferenceRelationship", null, false, true,(FileFormatVersions)7 ));

            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of FootnotesPart
    /// </summary>
    internal protected FootnotesPart()
            : base()
    {
    }
    
    
    /// <summary>
    /// Create an instance of OpenXmlPart according to the given relationship type
    /// </summary>
    /// <param name="relationshipType">Relationship type</param>
    /// <returns>An instance of OpenXmlPart</returns>
    internal sealed override OpenXmlPart CreatePartCore(string relationshipType)
    {
        this.ThrowIfObjectDisposed();

        if ( relationshipType == null )
        {
            throw new ArgumentNullException("relationshipType");
        }
        switch (relationshipType)
        {
        case AlternativeFormatImportPart.RelationshipTypeConstant:
                    return new AlternativeFormatImportPart();
            
        case ChartPart.RelationshipTypeConstant:
                    return new ChartPart();        
            
        case DiagramColorsPart.RelationshipTypeConstant:
                    return new DiagramColorsPart();        
            
        case DiagramDataPart.RelationshipTypeConstant:
                    return new DiagramDataPart();        
            
        case DiagramPersistLayoutPart.RelationshipTypeConstant:
                    return new DiagramPersistLayoutPart();        
            
        case DiagramLayoutDefinitionPart.RelationshipTypeConstant:
                    return new DiagramLayoutDefinitionPart();        
            
        case DiagramStylePart.RelationshipTypeConstant:
                    return new DiagramStylePart();        
            
        case EmbeddedControlPersistencePart.RelationshipTypeConstant:
                    return new EmbeddedControlPersistencePart();
            
        case EmbeddedObjectPart.RelationshipTypeConstant:
                    return new EmbeddedObjectPart();
            
        case EmbeddedPackagePart.RelationshipTypeConstant:
                    return new EmbeddedPackagePart();
            
        case ImagePart.RelationshipTypeConstant:
                    return new ImagePart();
            

        }
        throw new ArgumentOutOfRangeException("relationshipType");
    }
    

        /// <summary>
    /// Adds a AlternativeFormatImportPart to the FootnotesPart.
    /// </summary>
    /// <param name="contentType">the content type of the AlternativeFormatImportPart.</param>
    /// <returns>The newly added part.</returns>
    public AlternativeFormatImportPart AddAlternativeFormatImportPart(string contentType)
    {
        AlternativeFormatImportPart childPart = new AlternativeFormatImportPart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a AlternativeFormatImportPart to the FootnotesPart.
    /// </summary>
    /// <param name="partType">The part type of the AlternativeFormatImportPart.</param>
    /// <returns>The newly added part.</returns>
     public AlternativeFormatImportPart AddAlternativeFormatImportPart(AlternativeFormatImportPartType partType)
    {
        string contentType = AlternativeFormatImportPartTypeInfo.GetContentType(partType);
        string partExtension = AlternativeFormatImportPartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddAlternativeFormatImportPart(contentType);
    }
    
    /// <summary>
    /// Adds a AlternativeFormatImportPart to the FootnotesPart.
    /// </summary>
    /// <param name="contentType">the content type of the AlternativeFormatImportPart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public AlternativeFormatImportPart AddAlternativeFormatImportPart(string contentType, string id)
    {
        AlternativeFormatImportPart childPart = new AlternativeFormatImportPart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a AlternativeFormatImportPart to the FootnotesPart.
    /// </summary>
    /// <param name="partType">The part type of the AlternativeFormatImportPart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public AlternativeFormatImportPart AddAlternativeFormatImportPart(AlternativeFormatImportPartType partType, string id)
    {
        string contentType = AlternativeFormatImportPartTypeInfo.GetContentType(partType);
        string partExtension = AlternativeFormatImportPartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddAlternativeFormatImportPart(contentType, id);
    }
    /// <summary>
    /// Adds a EmbeddedControlPersistencePart to the FootnotesPart.
    /// </summary>
    /// <param name="contentType">the content type of the EmbeddedControlPersistencePart.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(string contentType)
    {
        EmbeddedControlPersistencePart childPart = new EmbeddedControlPersistencePart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a EmbeddedControlPersistencePart to the FootnotesPart.
    /// </summary>
    /// <param name="partType">The part type of the EmbeddedControlPersistencePart.</param>
    /// <returns>The newly added part.</returns>
     public EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(EmbeddedControlPersistencePartType partType)
    {
        string contentType = EmbeddedControlPersistencePartTypeInfo.GetContentType(partType);
        string partExtension = EmbeddedControlPersistencePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddEmbeddedControlPersistencePart(contentType);
    }
    
    /// <summary>
    /// Adds a EmbeddedControlPersistencePart to the FootnotesPart.
    /// </summary>
    /// <param name="contentType">the content type of the EmbeddedControlPersistencePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(string contentType, string id)
    {
        EmbeddedControlPersistencePart childPart = new EmbeddedControlPersistencePart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a EmbeddedControlPersistencePart to the FootnotesPart.
    /// </summary>
    /// <param name="partType">The part type of the EmbeddedControlPersistencePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(EmbeddedControlPersistencePartType partType, string id)
    {
        string contentType = EmbeddedControlPersistencePartTypeInfo.GetContentType(partType);
        string partExtension = EmbeddedControlPersistencePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddEmbeddedControlPersistencePart(contentType, id);
    }
	/// <summary>
    /// Adds a EmbeddedObjectPart to the FootnotesPart.
    /// </summary>
    /// <param name="contentType">The content type of the EmbeddedObjectPart.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedObjectPart AddEmbeddedObjectPart(string contentType)
    {
        EmbeddedObjectPart childPart = new EmbeddedObjectPart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
	/// <summary>
    /// Adds a EmbeddedPackagePart to the FootnotesPart.
    /// </summary>
    /// <param name="contentType">The content type of the EmbeddedPackagePart.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedPackagePart AddEmbeddedPackagePart(string contentType)
    {
        EmbeddedPackagePart childPart = new EmbeddedPackagePart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a ImagePart to the FootnotesPart.
    /// </summary>
    /// <param name="contentType">the content type of the ImagePart.</param>
    /// <returns>The newly added part.</returns>
    public ImagePart AddImagePart(string contentType)
    {
        ImagePart childPart = new ImagePart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a ImagePart to the FootnotesPart.
    /// </summary>
    /// <param name="partType">The part type of the ImagePart.</param>
    /// <returns>The newly added part.</returns>
     public ImagePart AddImagePart(ImagePartType partType)
    {
        string contentType = ImagePartTypeInfo.GetContentType(partType);
        string partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddImagePart(contentType);
    }
    
    /// <summary>
    /// Adds a ImagePart to the FootnotesPart.
    /// </summary>
    /// <param name="contentType">the content type of the ImagePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public ImagePart AddImagePart(string contentType, string id)
    {
        ImagePart childPart = new ImagePart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a ImagePart to the FootnotesPart.
    /// </summary>
    /// <param name="partType">The part type of the ImagePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public ImagePart AddImagePart(ImagePartType partType, string id)
    {
        string contentType = ImagePartTypeInfo.GetContentType(partType);
        string partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddImagePart(contentType, id);
    }
    /// <summary>
    /// Adds a new <see cref="VideoReferenceRelationship"/> to the specified <see cref="MediaDataPart"/>.
    /// </summary>
    /// <param name="mediaDataPart">The specified target <see cref="MediaDataPart"/>.</param>
    /// <returns>The new <see cref="VideoReferenceRelationship"/>.</returns>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="mediaDataPart"/> is null.</exception>
    /// <exception cref="InvalidOperationException">Thrown when the specified <paramref name="mediaDataPart"/> is not in this document.</exception>
    public VideoReferenceRelationship AddVideoReferenceRelationship(MediaDataPart mediaDataPart)
    {
            return AddDataPartReferenceRelationship<VideoReferenceRelationship>(mediaDataPart);
    }
    /// <summary>
    /// Adds a new <see cref="VideoReferenceRelationship"/> to the specified <see cref="MediaDataPart"/>.
    /// </summary>
    /// <param name="mediaDataPart">The specified target <see cref="MediaDataPart"/>.</param>
    /// <param name="id">The desired relationship ID. </param>
    /// <returns>The new <see cref="VideoReferenceRelationship"/>.</returns>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="mediaDataPart"/> is null.</exception>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="id"/> is null.</exception>
    /// <exception cref="InvalidOperationException">Thrown when the specified <paramref name="mediaDataPart"/> is not in this document.</exception>
    public VideoReferenceRelationship AddVideoReferenceRelationship(MediaDataPart mediaDataPart, string id)
    {
            return AddDataPartReferenceRelationship<VideoReferenceRelationship>(mediaDataPart, id);
    }
 
    
    
   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/officeDocument/2006/relationships/footnotes";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.openxmlformats-officedocument.wordprocessingml.footnotes+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@".";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"footnotes";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    

        /// <summary>
        /// Gets the AlternativeFormatImportParts of the FootnotesPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<AlternativeFormatImportPart> AlternativeFormatImportParts
        {
            get{
                    return this.GetPartsOfType<AlternativeFormatImportPart>();
                }
        }
                
        /// <summary>
        /// Gets the ChartParts of the FootnotesPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<ChartPart> ChartParts
        {
            get{
                    return this.GetPartsOfType<ChartPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramColorsParts of the FootnotesPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramColorsPart> DiagramColorsParts
        {
            get{
                    return this.GetPartsOfType<DiagramColorsPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramDataParts of the FootnotesPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramDataPart> DiagramDataParts
        {
            get{
                    return this.GetPartsOfType<DiagramDataPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramPersistLayoutParts of the FootnotesPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramPersistLayoutPart> DiagramPersistLayoutParts
        {
            get{
                    return this.GetPartsOfType<DiagramPersistLayoutPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramLayoutDefinitionParts of the FootnotesPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramLayoutDefinitionPart> DiagramLayoutDefinitionParts
        {
            get{
                    return this.GetPartsOfType<DiagramLayoutDefinitionPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramStyleParts of the FootnotesPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramStylePart> DiagramStyleParts
        {
            get{
                    return this.GetPartsOfType<DiagramStylePart>();
                }
        }
                
        /// <summary>
        /// Gets the EmbeddedControlPersistenceParts of the FootnotesPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<EmbeddedControlPersistencePart> EmbeddedControlPersistenceParts
        {
            get{
                    return this.GetPartsOfType<EmbeddedControlPersistencePart>();
                }
        }
                
        /// <summary>
        /// Gets the EmbeddedObjectParts of the FootnotesPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<EmbeddedObjectPart> EmbeddedObjectParts
        {
            get{
                    return this.GetPartsOfType<EmbeddedObjectPart>();
                }
        }
                
        /// <summary>
        /// Gets the EmbeddedPackageParts of the FootnotesPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<EmbeddedPackagePart> EmbeddedPackageParts
        {
            get{
                    return this.GetPartsOfType<EmbeddedPackagePart>();
                }
        }
                
        /// <summary>
        /// Gets the ImageParts of the FootnotesPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<ImagePart> ImageParts
        {
            get{
                    return this.GetPartsOfType<ImagePart>();
                }
        }
                


    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the GlossaryDocumentPart.
/// </summary>
public partial class GlossaryDocumentPart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/comments", new PartConstraintRule("WordprocessingCommentsPart", WordprocessingCommentsPart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/settings", new PartConstraintRule("DocumentSettingsPart", DocumentSettingsPart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/endnotes", new PartConstraintRule("EndnotesPart", EndnotesPart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/fontTable", new PartConstraintRule("FontTablePart", FontTablePart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/footnotes", new PartConstraintRule("FootnotesPart", FootnotesPart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/numbering", new PartConstraintRule("NumberingDefinitionsPart", NumberingDefinitionsPart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/styles", new PartConstraintRule("StyleDefinitionsPart", StyleDefinitionsPart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.microsoft.com/office/2007/relationships/stylesWithEffects", new PartConstraintRule("StylesWithEffectsPart", StylesWithEffectsPart.ContentTypeConstant, false, false,(FileFormatVersions)2 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/webSettings", new PartConstraintRule("WebSettingsPart", WebSettingsPart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/footer", new PartConstraintRule("FooterPart", FooterPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/header", new PartConstraintRule("HeaderPart", HeaderPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/printerSettings", new PartConstraintRule("WordprocessingPrinterSettingsPart", WordprocessingPrinterSettingsPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.microsoft.com/office/2006/relationships/keyMapCustomizations", new PartConstraintRule("CustomizationPart", CustomizationPart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.microsoft.com/office/2006/relationships/vbaProject", new PartConstraintRule("VbaProjectPart", VbaProjectPart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.microsoft.com/office/2011/relationships/commentsExtended", new PartConstraintRule("WordprocessingCommentsExPart", WordprocessingCommentsExPart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.microsoft.com/office/2011/relationships/people", new PartConstraintRule("WordprocessingPeoplePart", WordprocessingPeoplePart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/aFChunk", new PartConstraintRule("AlternativeFormatImportPart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/chart", new PartConstraintRule("ChartPart", ChartPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramColors", new PartConstraintRule("DiagramColorsPart", DiagramColorsPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramData", new PartConstraintRule("DiagramDataPart", DiagramDataPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.microsoft.com/office/2007/relationships/diagramDrawing", new PartConstraintRule("DiagramPersistLayoutPart", DiagramPersistLayoutPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramLayout", new PartConstraintRule("DiagramLayoutDefinitionPart", DiagramLayoutDefinitionPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramQuickStyle", new PartConstraintRule("DiagramStylePart", DiagramStylePart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/control", new PartConstraintRule("EmbeddedControlPersistencePart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/oleObject", new PartConstraintRule("EmbeddedObjectPart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/package", new PartConstraintRule("EmbeddedPackagePart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/image", new PartConstraintRule("ImagePart", null, false, true,(FileFormatVersions)7 ));

            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/video", new PartConstraintRule("VideoReferenceRelationship", null, false, true,(FileFormatVersions)7 ));

            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of GlossaryDocumentPart
    /// </summary>
    internal protected GlossaryDocumentPart()
            : base()
    {
    }
    
    
    /// <summary>
    /// Create an instance of OpenXmlPart according to the given relationship type
    /// </summary>
    /// <param name="relationshipType">Relationship type</param>
    /// <returns>An instance of OpenXmlPart</returns>
    internal sealed override OpenXmlPart CreatePartCore(string relationshipType)
    {
        this.ThrowIfObjectDisposed();

        if ( relationshipType == null )
        {
            throw new ArgumentNullException("relationshipType");
        }
        switch (relationshipType)
        {
        case WordprocessingCommentsPart.RelationshipTypeConstant:
                    return new WordprocessingCommentsPart();        
            
        case DocumentSettingsPart.RelationshipTypeConstant:
                    return new DocumentSettingsPart();        
            
        case EndnotesPart.RelationshipTypeConstant:
                    return new EndnotesPart();        
            
        case FontTablePart.RelationshipTypeConstant:
                    return new FontTablePart();        
            
        case FootnotesPart.RelationshipTypeConstant:
                    return new FootnotesPart();        
            
        case NumberingDefinitionsPart.RelationshipTypeConstant:
                    return new NumberingDefinitionsPart();        
            
        case StyleDefinitionsPart.RelationshipTypeConstant:
                    return new StyleDefinitionsPart();        
            
        case StylesWithEffectsPart.RelationshipTypeConstant:
                    return new StylesWithEffectsPart();        
            
        case WebSettingsPart.RelationshipTypeConstant:
                    return new WebSettingsPart();        
            
        case FooterPart.RelationshipTypeConstant:
                    return new FooterPart();        
            
        case HeaderPart.RelationshipTypeConstant:
                    return new HeaderPart();        
            
        case WordprocessingPrinterSettingsPart.RelationshipTypeConstant:
                    return new WordprocessingPrinterSettingsPart();        
            
        case CustomizationPart.RelationshipTypeConstant:
                    return new CustomizationPart();        
            
        case VbaProjectPart.RelationshipTypeConstant:
                    return new VbaProjectPart();        
            
        case WordprocessingCommentsExPart.RelationshipTypeConstant:
                    return new WordprocessingCommentsExPart();        
            
        case WordprocessingPeoplePart.RelationshipTypeConstant:
                    return new WordprocessingPeoplePart();        
            
        case AlternativeFormatImportPart.RelationshipTypeConstant:
                    return new AlternativeFormatImportPart();
            
        case ChartPart.RelationshipTypeConstant:
                    return new ChartPart();        
            
        case DiagramColorsPart.RelationshipTypeConstant:
                    return new DiagramColorsPart();        
            
        case DiagramDataPart.RelationshipTypeConstant:
                    return new DiagramDataPart();        
            
        case DiagramPersistLayoutPart.RelationshipTypeConstant:
                    return new DiagramPersistLayoutPart();        
            
        case DiagramLayoutDefinitionPart.RelationshipTypeConstant:
                    return new DiagramLayoutDefinitionPart();        
            
        case DiagramStylePart.RelationshipTypeConstant:
                    return new DiagramStylePart();        
            
        case EmbeddedControlPersistencePart.RelationshipTypeConstant:
                    return new EmbeddedControlPersistencePart();
            
        case EmbeddedObjectPart.RelationshipTypeConstant:
                    return new EmbeddedObjectPart();
            
        case EmbeddedPackagePart.RelationshipTypeConstant:
                    return new EmbeddedPackagePart();
            
        case ImagePart.RelationshipTypeConstant:
                    return new ImagePart();
            

        }
        throw new ArgumentOutOfRangeException("relationshipType");
    }
    

        /// <summary>
    /// Adds a AlternativeFormatImportPart to the GlossaryDocumentPart.
    /// </summary>
    /// <param name="contentType">the content type of the AlternativeFormatImportPart.</param>
    /// <returns>The newly added part.</returns>
    public AlternativeFormatImportPart AddAlternativeFormatImportPart(string contentType)
    {
        AlternativeFormatImportPart childPart = new AlternativeFormatImportPart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a AlternativeFormatImportPart to the GlossaryDocumentPart.
    /// </summary>
    /// <param name="partType">The part type of the AlternativeFormatImportPart.</param>
    /// <returns>The newly added part.</returns>
     public AlternativeFormatImportPart AddAlternativeFormatImportPart(AlternativeFormatImportPartType partType)
    {
        string contentType = AlternativeFormatImportPartTypeInfo.GetContentType(partType);
        string partExtension = AlternativeFormatImportPartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddAlternativeFormatImportPart(contentType);
    }
    
    /// <summary>
    /// Adds a AlternativeFormatImportPart to the GlossaryDocumentPart.
    /// </summary>
    /// <param name="contentType">the content type of the AlternativeFormatImportPart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public AlternativeFormatImportPart AddAlternativeFormatImportPart(string contentType, string id)
    {
        AlternativeFormatImportPart childPart = new AlternativeFormatImportPart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a AlternativeFormatImportPart to the GlossaryDocumentPart.
    /// </summary>
    /// <param name="partType">The part type of the AlternativeFormatImportPart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public AlternativeFormatImportPart AddAlternativeFormatImportPart(AlternativeFormatImportPartType partType, string id)
    {
        string contentType = AlternativeFormatImportPartTypeInfo.GetContentType(partType);
        string partExtension = AlternativeFormatImportPartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddAlternativeFormatImportPart(contentType, id);
    }
    /// <summary>
    /// Adds a EmbeddedControlPersistencePart to the GlossaryDocumentPart.
    /// </summary>
    /// <param name="contentType">the content type of the EmbeddedControlPersistencePart.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(string contentType)
    {
        EmbeddedControlPersistencePart childPart = new EmbeddedControlPersistencePart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a EmbeddedControlPersistencePart to the GlossaryDocumentPart.
    /// </summary>
    /// <param name="partType">The part type of the EmbeddedControlPersistencePart.</param>
    /// <returns>The newly added part.</returns>
     public EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(EmbeddedControlPersistencePartType partType)
    {
        string contentType = EmbeddedControlPersistencePartTypeInfo.GetContentType(partType);
        string partExtension = EmbeddedControlPersistencePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddEmbeddedControlPersistencePart(contentType);
    }
    
    /// <summary>
    /// Adds a EmbeddedControlPersistencePart to the GlossaryDocumentPart.
    /// </summary>
    /// <param name="contentType">the content type of the EmbeddedControlPersistencePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(string contentType, string id)
    {
        EmbeddedControlPersistencePart childPart = new EmbeddedControlPersistencePart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a EmbeddedControlPersistencePart to the GlossaryDocumentPart.
    /// </summary>
    /// <param name="partType">The part type of the EmbeddedControlPersistencePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(EmbeddedControlPersistencePartType partType, string id)
    {
        string contentType = EmbeddedControlPersistencePartTypeInfo.GetContentType(partType);
        string partExtension = EmbeddedControlPersistencePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddEmbeddedControlPersistencePart(contentType, id);
    }
	/// <summary>
    /// Adds a EmbeddedObjectPart to the GlossaryDocumentPart.
    /// </summary>
    /// <param name="contentType">The content type of the EmbeddedObjectPart.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedObjectPart AddEmbeddedObjectPart(string contentType)
    {
        EmbeddedObjectPart childPart = new EmbeddedObjectPart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
	/// <summary>
    /// Adds a EmbeddedPackagePart to the GlossaryDocumentPart.
    /// </summary>
    /// <param name="contentType">The content type of the EmbeddedPackagePart.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedPackagePart AddEmbeddedPackagePart(string contentType)
    {
        EmbeddedPackagePart childPart = new EmbeddedPackagePart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a ImagePart to the GlossaryDocumentPart.
    /// </summary>
    /// <param name="contentType">the content type of the ImagePart.</param>
    /// <returns>The newly added part.</returns>
    public ImagePart AddImagePart(string contentType)
    {
        ImagePart childPart = new ImagePart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a ImagePart to the GlossaryDocumentPart.
    /// </summary>
    /// <param name="partType">The part type of the ImagePart.</param>
    /// <returns>The newly added part.</returns>
     public ImagePart AddImagePart(ImagePartType partType)
    {
        string contentType = ImagePartTypeInfo.GetContentType(partType);
        string partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddImagePart(contentType);
    }
    
    /// <summary>
    /// Adds a ImagePart to the GlossaryDocumentPart.
    /// </summary>
    /// <param name="contentType">the content type of the ImagePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public ImagePart AddImagePart(string contentType, string id)
    {
        ImagePart childPart = new ImagePart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a ImagePart to the GlossaryDocumentPart.
    /// </summary>
    /// <param name="partType">The part type of the ImagePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public ImagePart AddImagePart(ImagePartType partType, string id)
    {
        string contentType = ImagePartTypeInfo.GetContentType(partType);
        string partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddImagePart(contentType, id);
    }
    /// <summary>
    /// Adds a new <see cref="VideoReferenceRelationship"/> to the specified <see cref="MediaDataPart"/>.
    /// </summary>
    /// <param name="mediaDataPart">The specified target <see cref="MediaDataPart"/>.</param>
    /// <returns>The new <see cref="VideoReferenceRelationship"/>.</returns>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="mediaDataPart"/> is null.</exception>
    /// <exception cref="InvalidOperationException">Thrown when the specified <paramref name="mediaDataPart"/> is not in this document.</exception>
    public VideoReferenceRelationship AddVideoReferenceRelationship(MediaDataPart mediaDataPart)
    {
            return AddDataPartReferenceRelationship<VideoReferenceRelationship>(mediaDataPart);
    }
    /// <summary>
    /// Adds a new <see cref="VideoReferenceRelationship"/> to the specified <see cref="MediaDataPart"/>.
    /// </summary>
    /// <param name="mediaDataPart">The specified target <see cref="MediaDataPart"/>.</param>
    /// <param name="id">The desired relationship ID. </param>
    /// <returns>The new <see cref="VideoReferenceRelationship"/>.</returns>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="mediaDataPart"/> is null.</exception>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="id"/> is null.</exception>
    /// <exception cref="InvalidOperationException">Thrown when the specified <paramref name="mediaDataPart"/> is not in this document.</exception>
    public VideoReferenceRelationship AddVideoReferenceRelationship(MediaDataPart mediaDataPart, string id)
    {
            return AddDataPartReferenceRelationship<VideoReferenceRelationship>(mediaDataPart, id);
    }
 
    
    
   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/officeDocument/2006/relationships/glossaryDocument";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.openxmlformats-officedocument.wordprocessingml.document.glossary+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@"glossary";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"document";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    

        /// <summary>
        /// Gets the WordprocessingCommentsPart of the GlossaryDocumentPart.
        /// </summary>
        public WordprocessingCommentsPart WordprocessingCommentsPart
        {
            get {return GetSubPartOfType<WordprocessingCommentsPart>(); }
        }
        /// <summary>
        /// Gets the DocumentSettingsPart of the GlossaryDocumentPart.
        /// </summary>
        public DocumentSettingsPart DocumentSettingsPart
        {
            get {return GetSubPartOfType<DocumentSettingsPart>(); }
        }
        /// <summary>
        /// Gets the EndnotesPart of the GlossaryDocumentPart.
        /// </summary>
        public EndnotesPart EndnotesPart
        {
            get {return GetSubPartOfType<EndnotesPart>(); }
        }
        /// <summary>
        /// Gets the FontTablePart of the GlossaryDocumentPart.
        /// </summary>
        public FontTablePart FontTablePart
        {
            get {return GetSubPartOfType<FontTablePart>(); }
        }
        /// <summary>
        /// Gets the FootnotesPart of the GlossaryDocumentPart.
        /// </summary>
        public FootnotesPart FootnotesPart
        {
            get {return GetSubPartOfType<FootnotesPart>(); }
        }
        /// <summary>
        /// Gets the NumberingDefinitionsPart of the GlossaryDocumentPart.
        /// </summary>
        public NumberingDefinitionsPart NumberingDefinitionsPart
        {
            get {return GetSubPartOfType<NumberingDefinitionsPart>(); }
        }
        /// <summary>
        /// Gets the StyleDefinitionsPart of the GlossaryDocumentPart.
        /// </summary>
        public StyleDefinitionsPart StyleDefinitionsPart
        {
            get {return GetSubPartOfType<StyleDefinitionsPart>(); }
        }
        /// <summary>
        /// Gets the StylesWithEffectsPart of the GlossaryDocumentPart., only available in Office2010
        /// </summary>
[OfficeAvailability(FileFormatVersions.Office2010)]
        public StylesWithEffectsPart StylesWithEffectsPart
        {
            get {return GetSubPartOfType<StylesWithEffectsPart>(); }
        }
        /// <summary>
        /// Gets the WebSettingsPart of the GlossaryDocumentPart.
        /// </summary>
        public WebSettingsPart WebSettingsPart
        {
            get {return GetSubPartOfType<WebSettingsPart>(); }
        }
        /// <summary>
        /// Gets the FooterParts of the GlossaryDocumentPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<FooterPart> FooterParts
        {
            get{
                    return this.GetPartsOfType<FooterPart>();
                }
        }
                
        /// <summary>
        /// Gets the HeaderParts of the GlossaryDocumentPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<HeaderPart> HeaderParts
        {
            get{
                    return this.GetPartsOfType<HeaderPart>();
                }
        }
                
        /// <summary>
        /// Gets the WordprocessingPrinterSettingsParts of the GlossaryDocumentPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<WordprocessingPrinterSettingsPart> WordprocessingPrinterSettingsParts
        {
            get{
                    return this.GetPartsOfType<WordprocessingPrinterSettingsPart>();
                }
        }
                
        /// <summary>
        /// Gets the CustomizationPart of the GlossaryDocumentPart.
        /// </summary>
        public CustomizationPart CustomizationPart
        {
            get {return GetSubPartOfType<CustomizationPart>(); }
        }
        /// <summary>
        /// Gets the VbaProjectPart of the GlossaryDocumentPart.
        /// </summary>
        public VbaProjectPart VbaProjectPart
        {
            get {return GetSubPartOfType<VbaProjectPart>(); }
        }
        /// <summary>
        /// Gets the WordprocessingCommentsExPart of the GlossaryDocumentPart.
        /// </summary>
        public WordprocessingCommentsExPart WordprocessingCommentsExPart
        {
            get {return GetSubPartOfType<WordprocessingCommentsExPart>(); }
        }
        /// <summary>
        /// Gets the WordprocessingPeoplePart of the GlossaryDocumentPart.
        /// </summary>
        public WordprocessingPeoplePart WordprocessingPeoplePart
        {
            get {return GetSubPartOfType<WordprocessingPeoplePart>(); }
        }
        /// <summary>
        /// Gets the AlternativeFormatImportParts of the GlossaryDocumentPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<AlternativeFormatImportPart> AlternativeFormatImportParts
        {
            get{
                    return this.GetPartsOfType<AlternativeFormatImportPart>();
                }
        }
                
        /// <summary>
        /// Gets the ChartParts of the GlossaryDocumentPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<ChartPart> ChartParts
        {
            get{
                    return this.GetPartsOfType<ChartPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramColorsParts of the GlossaryDocumentPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramColorsPart> DiagramColorsParts
        {
            get{
                    return this.GetPartsOfType<DiagramColorsPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramDataParts of the GlossaryDocumentPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramDataPart> DiagramDataParts
        {
            get{
                    return this.GetPartsOfType<DiagramDataPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramPersistLayoutParts of the GlossaryDocumentPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramPersistLayoutPart> DiagramPersistLayoutParts
        {
            get{
                    return this.GetPartsOfType<DiagramPersistLayoutPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramLayoutDefinitionParts of the GlossaryDocumentPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramLayoutDefinitionPart> DiagramLayoutDefinitionParts
        {
            get{
                    return this.GetPartsOfType<DiagramLayoutDefinitionPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramStyleParts of the GlossaryDocumentPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramStylePart> DiagramStyleParts
        {
            get{
                    return this.GetPartsOfType<DiagramStylePart>();
                }
        }
                
        /// <summary>
        /// Gets the EmbeddedControlPersistenceParts of the GlossaryDocumentPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<EmbeddedControlPersistencePart> EmbeddedControlPersistenceParts
        {
            get{
                    return this.GetPartsOfType<EmbeddedControlPersistencePart>();
                }
        }
                
        /// <summary>
        /// Gets the EmbeddedObjectParts of the GlossaryDocumentPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<EmbeddedObjectPart> EmbeddedObjectParts
        {
            get{
                    return this.GetPartsOfType<EmbeddedObjectPart>();
                }
        }
                
        /// <summary>
        /// Gets the EmbeddedPackageParts of the GlossaryDocumentPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<EmbeddedPackagePart> EmbeddedPackageParts
        {
            get{
                    return this.GetPartsOfType<EmbeddedPackagePart>();
                }
        }
                
        /// <summary>
        /// Gets the ImageParts of the GlossaryDocumentPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<ImagePart> ImageParts
        {
            get{
                    return this.GetPartsOfType<ImagePart>();
                }
        }
                


    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the HeaderPart.
/// </summary>
public partial class HeaderPart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/aFChunk", new PartConstraintRule("AlternativeFormatImportPart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/chart", new PartConstraintRule("ChartPart", ChartPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramColors", new PartConstraintRule("DiagramColorsPart", DiagramColorsPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramData", new PartConstraintRule("DiagramDataPart", DiagramDataPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.microsoft.com/office/2007/relationships/diagramDrawing", new PartConstraintRule("DiagramPersistLayoutPart", DiagramPersistLayoutPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramLayout", new PartConstraintRule("DiagramLayoutDefinitionPart", DiagramLayoutDefinitionPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramQuickStyle", new PartConstraintRule("DiagramStylePart", DiagramStylePart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/control", new PartConstraintRule("EmbeddedControlPersistencePart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/oleObject", new PartConstraintRule("EmbeddedObjectPart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/package", new PartConstraintRule("EmbeddedPackagePart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/image", new PartConstraintRule("ImagePart", null, false, true,(FileFormatVersions)7 ));

            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/video", new PartConstraintRule("VideoReferenceRelationship", null, false, true,(FileFormatVersions)7 ));

            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of HeaderPart
    /// </summary>
    internal protected HeaderPart()
            : base()
    {
    }
    
    
    /// <summary>
    /// Create an instance of OpenXmlPart according to the given relationship type
    /// </summary>
    /// <param name="relationshipType">Relationship type</param>
    /// <returns>An instance of OpenXmlPart</returns>
    internal sealed override OpenXmlPart CreatePartCore(string relationshipType)
    {
        this.ThrowIfObjectDisposed();

        if ( relationshipType == null )
        {
            throw new ArgumentNullException("relationshipType");
        }
        switch (relationshipType)
        {
        case AlternativeFormatImportPart.RelationshipTypeConstant:
                    return new AlternativeFormatImportPart();
            
        case ChartPart.RelationshipTypeConstant:
                    return new ChartPart();        
            
        case DiagramColorsPart.RelationshipTypeConstant:
                    return new DiagramColorsPart();        
            
        case DiagramDataPart.RelationshipTypeConstant:
                    return new DiagramDataPart();        
            
        case DiagramPersistLayoutPart.RelationshipTypeConstant:
                    return new DiagramPersistLayoutPart();        
            
        case DiagramLayoutDefinitionPart.RelationshipTypeConstant:
                    return new DiagramLayoutDefinitionPart();        
            
        case DiagramStylePart.RelationshipTypeConstant:
                    return new DiagramStylePart();        
            
        case EmbeddedControlPersistencePart.RelationshipTypeConstant:
                    return new EmbeddedControlPersistencePart();
            
        case EmbeddedObjectPart.RelationshipTypeConstant:
                    return new EmbeddedObjectPart();
            
        case EmbeddedPackagePart.RelationshipTypeConstant:
                    return new EmbeddedPackagePart();
            
        case ImagePart.RelationshipTypeConstant:
                    return new ImagePart();
            

        }
        throw new ArgumentOutOfRangeException("relationshipType");
    }
    

        /// <summary>
    /// Adds a AlternativeFormatImportPart to the HeaderPart.
    /// </summary>
    /// <param name="contentType">the content type of the AlternativeFormatImportPart.</param>
    /// <returns>The newly added part.</returns>
    public AlternativeFormatImportPart AddAlternativeFormatImportPart(string contentType)
    {
        AlternativeFormatImportPart childPart = new AlternativeFormatImportPart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a AlternativeFormatImportPart to the HeaderPart.
    /// </summary>
    /// <param name="partType">The part type of the AlternativeFormatImportPart.</param>
    /// <returns>The newly added part.</returns>
     public AlternativeFormatImportPart AddAlternativeFormatImportPart(AlternativeFormatImportPartType partType)
    {
        string contentType = AlternativeFormatImportPartTypeInfo.GetContentType(partType);
        string partExtension = AlternativeFormatImportPartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddAlternativeFormatImportPart(contentType);
    }
    
    /// <summary>
    /// Adds a AlternativeFormatImportPart to the HeaderPart.
    /// </summary>
    /// <param name="contentType">the content type of the AlternativeFormatImportPart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public AlternativeFormatImportPart AddAlternativeFormatImportPart(string contentType, string id)
    {
        AlternativeFormatImportPart childPart = new AlternativeFormatImportPart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a AlternativeFormatImportPart to the HeaderPart.
    /// </summary>
    /// <param name="partType">The part type of the AlternativeFormatImportPart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public AlternativeFormatImportPart AddAlternativeFormatImportPart(AlternativeFormatImportPartType partType, string id)
    {
        string contentType = AlternativeFormatImportPartTypeInfo.GetContentType(partType);
        string partExtension = AlternativeFormatImportPartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddAlternativeFormatImportPart(contentType, id);
    }
    /// <summary>
    /// Adds a EmbeddedControlPersistencePart to the HeaderPart.
    /// </summary>
    /// <param name="contentType">the content type of the EmbeddedControlPersistencePart.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(string contentType)
    {
        EmbeddedControlPersistencePart childPart = new EmbeddedControlPersistencePart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a EmbeddedControlPersistencePart to the HeaderPart.
    /// </summary>
    /// <param name="partType">The part type of the EmbeddedControlPersistencePart.</param>
    /// <returns>The newly added part.</returns>
     public EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(EmbeddedControlPersistencePartType partType)
    {
        string contentType = EmbeddedControlPersistencePartTypeInfo.GetContentType(partType);
        string partExtension = EmbeddedControlPersistencePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddEmbeddedControlPersistencePart(contentType);
    }
    
    /// <summary>
    /// Adds a EmbeddedControlPersistencePart to the HeaderPart.
    /// </summary>
    /// <param name="contentType">the content type of the EmbeddedControlPersistencePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(string contentType, string id)
    {
        EmbeddedControlPersistencePart childPart = new EmbeddedControlPersistencePart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a EmbeddedControlPersistencePart to the HeaderPart.
    /// </summary>
    /// <param name="partType">The part type of the EmbeddedControlPersistencePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(EmbeddedControlPersistencePartType partType, string id)
    {
        string contentType = EmbeddedControlPersistencePartTypeInfo.GetContentType(partType);
        string partExtension = EmbeddedControlPersistencePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddEmbeddedControlPersistencePart(contentType, id);
    }
	/// <summary>
    /// Adds a EmbeddedObjectPart to the HeaderPart.
    /// </summary>
    /// <param name="contentType">The content type of the EmbeddedObjectPart.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedObjectPart AddEmbeddedObjectPart(string contentType)
    {
        EmbeddedObjectPart childPart = new EmbeddedObjectPart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
	/// <summary>
    /// Adds a EmbeddedPackagePart to the HeaderPart.
    /// </summary>
    /// <param name="contentType">The content type of the EmbeddedPackagePart.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedPackagePart AddEmbeddedPackagePart(string contentType)
    {
        EmbeddedPackagePart childPart = new EmbeddedPackagePart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a ImagePart to the HeaderPart.
    /// </summary>
    /// <param name="contentType">the content type of the ImagePart.</param>
    /// <returns>The newly added part.</returns>
    public ImagePart AddImagePart(string contentType)
    {
        ImagePart childPart = new ImagePart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a ImagePart to the HeaderPart.
    /// </summary>
    /// <param name="partType">The part type of the ImagePart.</param>
    /// <returns>The newly added part.</returns>
     public ImagePart AddImagePart(ImagePartType partType)
    {
        string contentType = ImagePartTypeInfo.GetContentType(partType);
        string partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddImagePart(contentType);
    }
    
    /// <summary>
    /// Adds a ImagePart to the HeaderPart.
    /// </summary>
    /// <param name="contentType">the content type of the ImagePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public ImagePart AddImagePart(string contentType, string id)
    {
        ImagePart childPart = new ImagePart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a ImagePart to the HeaderPart.
    /// </summary>
    /// <param name="partType">The part type of the ImagePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public ImagePart AddImagePart(ImagePartType partType, string id)
    {
        string contentType = ImagePartTypeInfo.GetContentType(partType);
        string partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddImagePart(contentType, id);
    }
    /// <summary>
    /// Adds a new <see cref="VideoReferenceRelationship"/> to the specified <see cref="MediaDataPart"/>.
    /// </summary>
    /// <param name="mediaDataPart">The specified target <see cref="MediaDataPart"/>.</param>
    /// <returns>The new <see cref="VideoReferenceRelationship"/>.</returns>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="mediaDataPart"/> is null.</exception>
    /// <exception cref="InvalidOperationException">Thrown when the specified <paramref name="mediaDataPart"/> is not in this document.</exception>
    public VideoReferenceRelationship AddVideoReferenceRelationship(MediaDataPart mediaDataPart)
    {
            return AddDataPartReferenceRelationship<VideoReferenceRelationship>(mediaDataPart);
    }
    /// <summary>
    /// Adds a new <see cref="VideoReferenceRelationship"/> to the specified <see cref="MediaDataPart"/>.
    /// </summary>
    /// <param name="mediaDataPart">The specified target <see cref="MediaDataPart"/>.</param>
    /// <param name="id">The desired relationship ID. </param>
    /// <returns>The new <see cref="VideoReferenceRelationship"/>.</returns>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="mediaDataPart"/> is null.</exception>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="id"/> is null.</exception>
    /// <exception cref="InvalidOperationException">Thrown when the specified <paramref name="mediaDataPart"/> is not in this document.</exception>
    public VideoReferenceRelationship AddVideoReferenceRelationship(MediaDataPart mediaDataPart, string id)
    {
            return AddDataPartReferenceRelationship<VideoReferenceRelationship>(mediaDataPart, id);
    }
 
    
    
   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/officeDocument/2006/relationships/header";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.openxmlformats-officedocument.wordprocessingml.header+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@".";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"header";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    

        /// <summary>
        /// Gets the AlternativeFormatImportParts of the HeaderPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<AlternativeFormatImportPart> AlternativeFormatImportParts
        {
            get{
                    return this.GetPartsOfType<AlternativeFormatImportPart>();
                }
        }
                
        /// <summary>
        /// Gets the ChartParts of the HeaderPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<ChartPart> ChartParts
        {
            get{
                    return this.GetPartsOfType<ChartPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramColorsParts of the HeaderPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramColorsPart> DiagramColorsParts
        {
            get{
                    return this.GetPartsOfType<DiagramColorsPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramDataParts of the HeaderPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramDataPart> DiagramDataParts
        {
            get{
                    return this.GetPartsOfType<DiagramDataPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramPersistLayoutParts of the HeaderPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramPersistLayoutPart> DiagramPersistLayoutParts
        {
            get{
                    return this.GetPartsOfType<DiagramPersistLayoutPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramLayoutDefinitionParts of the HeaderPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramLayoutDefinitionPart> DiagramLayoutDefinitionParts
        {
            get{
                    return this.GetPartsOfType<DiagramLayoutDefinitionPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramStyleParts of the HeaderPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramStylePart> DiagramStyleParts
        {
            get{
                    return this.GetPartsOfType<DiagramStylePart>();
                }
        }
                
        /// <summary>
        /// Gets the EmbeddedControlPersistenceParts of the HeaderPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<EmbeddedControlPersistencePart> EmbeddedControlPersistenceParts
        {
            get{
                    return this.GetPartsOfType<EmbeddedControlPersistencePart>();
                }
        }
                
        /// <summary>
        /// Gets the EmbeddedObjectParts of the HeaderPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<EmbeddedObjectPart> EmbeddedObjectParts
        {
            get{
                    return this.GetPartsOfType<EmbeddedObjectPart>();
                }
        }
                
        /// <summary>
        /// Gets the EmbeddedPackageParts of the HeaderPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<EmbeddedPackagePart> EmbeddedPackageParts
        {
            get{
                    return this.GetPartsOfType<EmbeddedPackagePart>();
                }
        }
                
        /// <summary>
        /// Gets the ImageParts of the HeaderPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<ImagePart> ImageParts
        {
            get{
                    return this.GetPartsOfType<ImagePart>();
                }
        }
                


    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the NumberingDefinitionsPart.
/// </summary>
public partial class NumberingDefinitionsPart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/image", new PartConstraintRule("ImagePart", null, false, true,(FileFormatVersions)7 ));

            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of NumberingDefinitionsPart
    /// </summary>
    internal protected NumberingDefinitionsPart()
            : base()
    {
    }
    
    
    /// <summary>
    /// Create an instance of OpenXmlPart according to the given relationship type
    /// </summary>
    /// <param name="relationshipType">Relationship type</param>
    /// <returns>An instance of OpenXmlPart</returns>
    internal sealed override OpenXmlPart CreatePartCore(string relationshipType)
    {
        this.ThrowIfObjectDisposed();

        if ( relationshipType == null )
        {
            throw new ArgumentNullException("relationshipType");
        }
        switch (relationshipType)
        {
        case ImagePart.RelationshipTypeConstant:
                    return new ImagePart();
            

        }
        throw new ArgumentOutOfRangeException("relationshipType");
    }
    

        /// <summary>
    /// Adds a ImagePart to the NumberingDefinitionsPart.
    /// </summary>
    /// <param name="contentType">the content type of the ImagePart.</param>
    /// <returns>The newly added part.</returns>
    public ImagePart AddImagePart(string contentType)
    {
        ImagePart childPart = new ImagePart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a ImagePart to the NumberingDefinitionsPart.
    /// </summary>
    /// <param name="partType">The part type of the ImagePart.</param>
    /// <returns>The newly added part.</returns>
     public ImagePart AddImagePart(ImagePartType partType)
    {
        string contentType = ImagePartTypeInfo.GetContentType(partType);
        string partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddImagePart(contentType);
    }
    
    /// <summary>
    /// Adds a ImagePart to the NumberingDefinitionsPart.
    /// </summary>
    /// <param name="contentType">the content type of the ImagePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public ImagePart AddImagePart(string contentType, string id)
    {
        ImagePart childPart = new ImagePart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a ImagePart to the NumberingDefinitionsPart.
    /// </summary>
    /// <param name="partType">The part type of the ImagePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public ImagePart AddImagePart(ImagePartType partType, string id)
    {
        string contentType = ImagePartTypeInfo.GetContentType(partType);
        string partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddImagePart(contentType, id);
    }
 
    
    
   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/officeDocument/2006/relationships/numbering";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.openxmlformats-officedocument.wordprocessingml.numbering+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@".";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"numbering";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    

        /// <summary>
        /// Gets the ImageParts of the NumberingDefinitionsPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<ImagePart> ImageParts
        {
            get{
                    return this.GetPartsOfType<ImagePart>();
                }
        }
                


    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the StyleDefinitionsPart.
/// </summary>
public partial class StyleDefinitionsPart : StylesPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of StyleDefinitionsPart
    /// </summary>
    internal protected StyleDefinitionsPart()
            : base()
    {
    }
    
    

   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/officeDocument/2006/relationships/styles";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.openxmlformats-officedocument.wordprocessingml.styles+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@".";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"styles";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    



    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the WebSettingsPart.
/// </summary>
public partial class WebSettingsPart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of WebSettingsPart
    /// </summary>
    internal protected WebSettingsPart()
            : base()
    {
    }
    
    

   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/officeDocument/2006/relationships/webSettings";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.openxmlformats-officedocument.wordprocessingml.webSettings+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@".";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"webSettings";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    



    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the MailMergeRecipientDataPart.
/// </summary>
public partial class MailMergeRecipientDataPart : OpenXmlPart 
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of MailMergeRecipientDataPart
    /// </summary>
    internal protected MailMergeRecipientDataPart()
            : base()
    {
    }
    
    

   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/officeDocument/2006/relationships/recipientData";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@".";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"recipients";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    



    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return false; }
    }
}
/// <summary>
/// Defines the WorkbookPart.
/// </summary>
public partial class WorkbookPart : OpenXmlPart 
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/customXml", new PartConstraintRule("CustomXmlPart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/calcChain", new PartConstraintRule("CalculationChainPart", CalculationChainPart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/sheetMetadata", new PartConstraintRule("CellMetadataPart", CellMetadataPart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/connections", new PartConstraintRule("ConnectionsPart", ConnectionsPart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/xmlMaps", new PartConstraintRule("CustomXmlMappingsPart", CustomXmlMappingsPart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/sharedStrings", new PartConstraintRule("SharedStringTablePart", SharedStringTablePart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/revisionHeaders", new PartConstraintRule("WorkbookRevisionHeaderPart", WorkbookRevisionHeaderPart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/usernames", new PartConstraintRule("WorkbookUserDataPart", WorkbookUserDataPart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/styles", new PartConstraintRule("WorkbookStylesPart", WorkbookStylesPart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/theme", new PartConstraintRule("ThemePart", ThemePart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/package/2006/relationships/metadata/thumbnail", new PartConstraintRule("ThumbnailPart", null, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/volatileDependencies", new PartConstraintRule("VolatileDependenciesPart", VolatileDependenciesPart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/chartsheet", new PartConstraintRule("ChartsheetPart", ChartsheetPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/dialogsheet", new PartConstraintRule("DialogsheetPart", DialogsheetPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/externalLink", new PartConstraintRule("ExternalWorkbookPart", ExternalWorkbookPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/pivotCacheDefinition", new PartConstraintRule("PivotTableCacheDefinitionPart", PivotTableCacheDefinitionPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/worksheet", new PartConstraintRule("WorksheetPart", WorksheetPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.microsoft.com/office/2006/relationships/attachedToolbars", new PartConstraintRule("ExcelAttachedToolbarsPart", ExcelAttachedToolbarsPart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.microsoft.com/office/2006/relationships/vbaProject", new PartConstraintRule("VbaProjectPart", VbaProjectPart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.microsoft.com/office/2006/relationships/xlMacrosheet", new PartConstraintRule("MacroSheetPart", MacroSheetPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.microsoft.com/office/2006/relationships/xlIntlMacrosheet", new PartConstraintRule("InternationalMacroSheetPart", InternationalMacroSheetPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.microsoft.com/office/2007/relationships/customDataProps", new PartConstraintRule("CustomDataPropertiesPart", CustomDataPropertiesPart.ContentTypeConstant, false, true,(FileFormatVersions)2 ));
tempData.Add("http://schemas.microsoft.com/office/2007/relationships/slicerCache", new PartConstraintRule("SlicerCachePart", SlicerCachePart.ContentTypeConstant, false, true,(FileFormatVersions)2 ));
tempData.Add("http://schemas.microsoft.com/office/2011/relationships/timelineCache", new PartConstraintRule("TimeLineCachePart", TimeLineCachePart.ContentTypeConstant, false, true,(FileFormatVersions)4 ));

            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of WorkbookPart
    /// </summary>
    internal protected WorkbookPart()
            : base()
    {
    }
    
    
    /// <summary>
    /// Create an instance of OpenXmlPart according to the given relationship type
    /// </summary>
    /// <param name="relationshipType">Relationship type</param>
    /// <returns>An instance of OpenXmlPart</returns>
    internal sealed override OpenXmlPart CreatePartCore(string relationshipType)
    {
        this.ThrowIfObjectDisposed();

        if ( relationshipType == null )
        {
            throw new ArgumentNullException("relationshipType");
        }
        switch (relationshipType)
        {
        case CustomXmlPart.RelationshipTypeConstant:
                    return new CustomXmlPart();
            
        case CalculationChainPart.RelationshipTypeConstant:
                    return new CalculationChainPart();        
            
        case CellMetadataPart.RelationshipTypeConstant:
                    return new CellMetadataPart();        
            
        case ConnectionsPart.RelationshipTypeConstant:
                    return new ConnectionsPart();        
            
        case CustomXmlMappingsPart.RelationshipTypeConstant:
                    return new CustomXmlMappingsPart();        
            
        case SharedStringTablePart.RelationshipTypeConstant:
                    return new SharedStringTablePart();        
            
        case WorkbookRevisionHeaderPart.RelationshipTypeConstant:
                    return new WorkbookRevisionHeaderPart();        
            
        case WorkbookUserDataPart.RelationshipTypeConstant:
                    return new WorkbookUserDataPart();        
            
        case WorkbookStylesPart.RelationshipTypeConstant:
                    return new WorkbookStylesPart();        
            
        case ThemePart.RelationshipTypeConstant:
                    return new ThemePart();        
            
        case ThumbnailPart.RelationshipTypeConstant:
                    return new ThumbnailPart();
            
        case VolatileDependenciesPart.RelationshipTypeConstant:
                    return new VolatileDependenciesPart();        
            
        case ChartsheetPart.RelationshipTypeConstant:
                    return new ChartsheetPart();        
            
        case DialogsheetPart.RelationshipTypeConstant:
                    return new DialogsheetPart();        
            
        case ExternalWorkbookPart.RelationshipTypeConstant:
                    return new ExternalWorkbookPart();        
            
        case PivotTableCacheDefinitionPart.RelationshipTypeConstant:
                    return new PivotTableCacheDefinitionPart();        
            
        case WorksheetPart.RelationshipTypeConstant:
                    return new WorksheetPart();        
            
        case ExcelAttachedToolbarsPart.RelationshipTypeConstant:
                    return new ExcelAttachedToolbarsPart();        
            
        case VbaProjectPart.RelationshipTypeConstant:
                    return new VbaProjectPart();        
            
        case MacroSheetPart.RelationshipTypeConstant:
                    return new MacroSheetPart();        
            
        case InternationalMacroSheetPart.RelationshipTypeConstant:
                    return new InternationalMacroSheetPart();        
            
        case CustomDataPropertiesPart.RelationshipTypeConstant:
                    return new CustomDataPropertiesPart();        
            
        case SlicerCachePart.RelationshipTypeConstant:
                    return new SlicerCachePart();        
            
        case TimeLineCachePart.RelationshipTypeConstant:
                    return new TimeLineCachePart();        
            

        }
        throw new ArgumentOutOfRangeException("relationshipType");
    }
    

        /// <summary>
    /// Adds a CustomXmlPart to the WorkbookPart.
    /// </summary>
    /// <param name="contentType">the content type of the CustomXmlPart.</param>
    /// <returns>The newly added part.</returns>
    public CustomXmlPart AddCustomXmlPart(string contentType)
    {
        CustomXmlPart childPart = new CustomXmlPart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a CustomXmlPart to the WorkbookPart.
    /// </summary>
    /// <param name="partType">The part type of the CustomXmlPart.</param>
    /// <returns>The newly added part.</returns>
     public CustomXmlPart AddCustomXmlPart(CustomXmlPartType partType)
    {
        string contentType = CustomXmlPartTypeInfo.GetContentType(partType);
        string partExtension = CustomXmlPartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddCustomXmlPart(contentType);
    }
    
    /// <summary>
    /// Adds a CustomXmlPart to the WorkbookPart.
    /// </summary>
    /// <param name="contentType">the content type of the CustomXmlPart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public CustomXmlPart AddCustomXmlPart(string contentType, string id)
    {
        CustomXmlPart childPart = new CustomXmlPart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a CustomXmlPart to the WorkbookPart.
    /// </summary>
    /// <param name="partType">The part type of the CustomXmlPart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public CustomXmlPart AddCustomXmlPart(CustomXmlPartType partType, string id)
    {
        string contentType = CustomXmlPartTypeInfo.GetContentType(partType);
        string partExtension = CustomXmlPartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddCustomXmlPart(contentType, id);
    }
    /// <summary>
    /// Adds a ThumbnailPart to the WorkbookPart.
    /// </summary>
    /// <param name="contentType">the content type of the ThumbnailPart.</param>
    /// <returns>The newly added part.</returns>
    public ThumbnailPart AddThumbnailPart(string contentType)
    {
        ThumbnailPart childPart = new ThumbnailPart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a ThumbnailPart to the WorkbookPart.
    /// </summary>
    /// <param name="partType">The part type of the ThumbnailPart.</param>
    /// <returns>The newly added part.</returns>
     public ThumbnailPart AddThumbnailPart(ThumbnailPartType partType)
    {
        string contentType = ThumbnailPartTypeInfo.GetContentType(partType);
        string partExtension = ThumbnailPartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddThumbnailPart(contentType);
    }
    
    /// <summary>
    /// Adds a ThumbnailPart to the WorkbookPart.
    /// </summary>
    /// <param name="contentType">the content type of the ThumbnailPart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public ThumbnailPart AddThumbnailPart(string contentType, string id)
    {
        ThumbnailPart childPart = new ThumbnailPart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a ThumbnailPart to the WorkbookPart.
    /// </summary>
    /// <param name="partType">The part type of the ThumbnailPart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public ThumbnailPart AddThumbnailPart(ThumbnailPartType partType, string id)
    {
        string contentType = ThumbnailPartTypeInfo.GetContentType(partType);
        string partExtension = ThumbnailPartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddThumbnailPart(contentType, id);
    }
 
    
    
   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@"xl";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"workbook";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    

        /// <summary>
        /// Gets the CustomXmlParts of the WorkbookPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<CustomXmlPart> CustomXmlParts
        {
            get{
                    return this.GetPartsOfType<CustomXmlPart>();
                }
        }
                
        /// <summary>
        /// Gets the CalculationChainPart of the WorkbookPart.
        /// </summary>
        public CalculationChainPart CalculationChainPart
        {
            get {return GetSubPartOfType<CalculationChainPart>(); }
        }
        /// <summary>
        /// Gets the CellMetadataPart of the WorkbookPart.
        /// </summary>
        public CellMetadataPart CellMetadataPart
        {
            get {return GetSubPartOfType<CellMetadataPart>(); }
        }
        /// <summary>
        /// Gets the ConnectionsPart of the WorkbookPart.
        /// </summary>
        public ConnectionsPart ConnectionsPart
        {
            get {return GetSubPartOfType<ConnectionsPart>(); }
        }
        /// <summary>
        /// Gets the CustomXmlMappingsPart of the WorkbookPart.
        /// </summary>
        public CustomXmlMappingsPart CustomXmlMappingsPart
        {
            get {return GetSubPartOfType<CustomXmlMappingsPart>(); }
        }
        /// <summary>
        /// Gets the SharedStringTablePart of the WorkbookPart.
        /// </summary>
        public SharedStringTablePart SharedStringTablePart
        {
            get {return GetSubPartOfType<SharedStringTablePart>(); }
        }
        /// <summary>
        /// Gets the WorkbookRevisionHeaderPart of the WorkbookPart.
        /// </summary>
        public WorkbookRevisionHeaderPart WorkbookRevisionHeaderPart
        {
            get {return GetSubPartOfType<WorkbookRevisionHeaderPart>(); }
        }
        /// <summary>
        /// Gets the WorkbookUserDataPart of the WorkbookPart.
        /// </summary>
        public WorkbookUserDataPart WorkbookUserDataPart
        {
            get {return GetSubPartOfType<WorkbookUserDataPart>(); }
        }
        /// <summary>
        /// Gets the WorkbookStylesPart of the WorkbookPart.
        /// </summary>
        public WorkbookStylesPart WorkbookStylesPart
        {
            get {return GetSubPartOfType<WorkbookStylesPart>(); }
        }
        /// <summary>
        /// Gets the ThemePart of the WorkbookPart.
        /// </summary>
        public ThemePart ThemePart
        {
            get {return GetSubPartOfType<ThemePart>(); }
        }
        /// <summary>
        /// Gets the ThumbnailPart of the WorkbookPart.
        /// </summary>
        public ThumbnailPart ThumbnailPart
        {
            get {return GetSubPartOfType<ThumbnailPart>(); }
        }
        /// <summary>
        /// Gets the VolatileDependenciesPart of the WorkbookPart.
        /// </summary>
        public VolatileDependenciesPart VolatileDependenciesPart
        {
            get {return GetSubPartOfType<VolatileDependenciesPart>(); }
        }
        /// <summary>
        /// Gets the ChartsheetParts of the WorkbookPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<ChartsheetPart> ChartsheetParts
        {
            get{
                    return this.GetPartsOfType<ChartsheetPart>();
                }
        }
                
        /// <summary>
        /// Gets the DialogsheetParts of the WorkbookPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DialogsheetPart> DialogsheetParts
        {
            get{
                    return this.GetPartsOfType<DialogsheetPart>();
                }
        }
                
        /// <summary>
        /// Gets the ExternalWorkbookParts of the WorkbookPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<ExternalWorkbookPart> ExternalWorkbookParts
        {
            get{
                    return this.GetPartsOfType<ExternalWorkbookPart>();
                }
        }
                
        /// <summary>
        /// Gets the PivotTableCacheDefinitionParts of the WorkbookPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<PivotTableCacheDefinitionPart> PivotTableCacheDefinitionParts
        {
            get{
                    return this.GetPartsOfType<PivotTableCacheDefinitionPart>();
                }
        }
                
        /// <summary>
        /// Gets the WorksheetParts of the WorkbookPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<WorksheetPart> WorksheetParts
        {
            get{
                    return this.GetPartsOfType<WorksheetPart>();
                }
        }
                
        /// <summary>
        /// Gets the ExcelAttachedToolbarsPart of the WorkbookPart.
        /// </summary>
        public ExcelAttachedToolbarsPart ExcelAttachedToolbarsPart
        {
            get {return GetSubPartOfType<ExcelAttachedToolbarsPart>(); }
        }
        /// <summary>
        /// Gets the VbaProjectPart of the WorkbookPart.
        /// </summary>
        public VbaProjectPart VbaProjectPart
        {
            get {return GetSubPartOfType<VbaProjectPart>(); }
        }
        /// <summary>
        /// Gets the MacroSheetParts of the WorkbookPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<MacroSheetPart> MacroSheetParts
        {
            get{
                    return this.GetPartsOfType<MacroSheetPart>();
                }
        }
                
        /// <summary>
        /// Gets the InternationalMacroSheetParts of the WorkbookPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<InternationalMacroSheetPart> InternationalMacroSheetParts
        {
            get{
                    return this.GetPartsOfType<InternationalMacroSheetPart>();
                }
        }
                
        /// <summary>
        /// Gets the CustomDataPropertiesParts of the WorkbookPart., only available in Office2010
        /// </summary>
[OfficeAvailability(FileFormatVersions.Office2010)]
        public System.Collections.Generic.IEnumerable<CustomDataPropertiesPart> CustomDataPropertiesParts
        {
            get{
                    return this.GetPartsOfType<CustomDataPropertiesPart>();
                }
        }
                
        /// <summary>
        /// Gets the SlicerCacheParts of the WorkbookPart., only available in Office2010
        /// </summary>
[OfficeAvailability(FileFormatVersions.Office2010)]
        public System.Collections.Generic.IEnumerable<SlicerCachePart> SlicerCacheParts
        {
            get{
                    return this.GetPartsOfType<SlicerCachePart>();
                }
        }
                
        /// <summary>
        /// Gets the TimeLineCacheParts of the WorkbookPart., only available in Office2013
        /// </summary>
[OfficeAvailability(FileFormatVersions.Office2013)]
        public System.Collections.Generic.IEnumerable<TimeLineCachePart> TimeLineCacheParts
        {
            get{
                    return this.GetPartsOfType<TimeLineCachePart>();
                }
        }
                


    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return false; }
    }
}
/// <summary>
/// Defines the CalculationChainPart.
/// </summary>
public partial class CalculationChainPart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of CalculationChainPart
    /// </summary>
    internal protected CalculationChainPart()
            : base()
    {
    }
    
    

   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/officeDocument/2006/relationships/calcChain";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.openxmlformats-officedocument.spreadsheetml.calcChain+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@".";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"calcChain";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    



    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the ChartsheetPart.
/// </summary>
public partial class ChartsheetPart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/printerSettings", new PartConstraintRule("SpreadsheetPrinterSettingsPart", SpreadsheetPrinterSettingsPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/drawing", new PartConstraintRule("DrawingsPart", DrawingsPart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/vmlDrawing", new PartConstraintRule("VmlDrawingPart", VmlDrawingPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/image", new PartConstraintRule("ImagePart", null, false, true,(FileFormatVersions)7 ));

            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of ChartsheetPart
    /// </summary>
    internal protected ChartsheetPart()
            : base()
    {
    }
    
    
    /// <summary>
    /// Create an instance of OpenXmlPart according to the given relationship type
    /// </summary>
    /// <param name="relationshipType">Relationship type</param>
    /// <returns>An instance of OpenXmlPart</returns>
    internal sealed override OpenXmlPart CreatePartCore(string relationshipType)
    {
        this.ThrowIfObjectDisposed();

        if ( relationshipType == null )
        {
            throw new ArgumentNullException("relationshipType");
        }
        switch (relationshipType)
        {
        case SpreadsheetPrinterSettingsPart.RelationshipTypeConstant:
                    return new SpreadsheetPrinterSettingsPart();        
            
        case DrawingsPart.RelationshipTypeConstant:
                    return new DrawingsPart();        
            
        case VmlDrawingPart.RelationshipTypeConstant:
                    return new VmlDrawingPart();        
            
        case ImagePart.RelationshipTypeConstant:
                    return new ImagePart();
            

        }
        throw new ArgumentOutOfRangeException("relationshipType");
    }
    

        /// <summary>
    /// Adds a ImagePart to the ChartsheetPart.
    /// </summary>
    /// <param name="contentType">the content type of the ImagePart.</param>
    /// <returns>The newly added part.</returns>
    public ImagePart AddImagePart(string contentType)
    {
        ImagePart childPart = new ImagePart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a ImagePart to the ChartsheetPart.
    /// </summary>
    /// <param name="partType">The part type of the ImagePart.</param>
    /// <returns>The newly added part.</returns>
     public ImagePart AddImagePart(ImagePartType partType)
    {
        string contentType = ImagePartTypeInfo.GetContentType(partType);
        string partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddImagePart(contentType);
    }
    
    /// <summary>
    /// Adds a ImagePart to the ChartsheetPart.
    /// </summary>
    /// <param name="contentType">the content type of the ImagePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public ImagePart AddImagePart(string contentType, string id)
    {
        ImagePart childPart = new ImagePart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a ImagePart to the ChartsheetPart.
    /// </summary>
    /// <param name="partType">The part type of the ImagePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public ImagePart AddImagePart(ImagePartType partType, string id)
    {
        string contentType = ImagePartTypeInfo.GetContentType(partType);
        string partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddImagePart(contentType, id);
    }
 
    
    
   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/officeDocument/2006/relationships/chartsheet";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.openxmlformats-officedocument.spreadsheetml.chartsheet+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@"chartsheets";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"sheet";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    

        /// <summary>
        /// Gets the SpreadsheetPrinterSettingsParts of the ChartsheetPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<SpreadsheetPrinterSettingsPart> SpreadsheetPrinterSettingsParts
        {
            get{
                    return this.GetPartsOfType<SpreadsheetPrinterSettingsPart>();
                }
        }
                
        /// <summary>
        /// Gets the DrawingsPart of the ChartsheetPart.
        /// </summary>
        public DrawingsPart DrawingsPart
        {
            get {return GetSubPartOfType<DrawingsPart>(); }
        }
        /// <summary>
        /// Gets the VmlDrawingParts of the ChartsheetPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<VmlDrawingPart> VmlDrawingParts
        {
            get{
                    return this.GetPartsOfType<VmlDrawingPart>();
                }
        }
                
        /// <summary>
        /// Gets the ImageParts of the ChartsheetPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<ImagePart> ImageParts
        {
            get{
                    return this.GetPartsOfType<ImagePart>();
                }
        }
                


    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the WorksheetCommentsPart.
/// </summary>
public partial class WorksheetCommentsPart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of WorksheetCommentsPart
    /// </summary>
    internal protected WorksheetCommentsPart()
            : base()
    {
    }
    
    

   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/officeDocument/2006/relationships/comments";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.openxmlformats-officedocument.spreadsheetml.comments+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@"..";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"comments";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    



    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the ConnectionsPart.
/// </summary>
public partial class ConnectionsPart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of ConnectionsPart
    /// </summary>
    internal protected ConnectionsPart()
            : base()
    {
    }
    
    

   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/officeDocument/2006/relationships/connections";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.openxmlformats-officedocument.spreadsheetml.connections+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@".";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"connections";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    



    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the CustomPropertyPart.
/// </summary>
public partial class CustomPropertyPart : OpenXmlPart 
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of CustomPropertyPart
    /// </summary>
    internal protected CustomPropertyPart()
            : base()
    {
    }
    
    

   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/officeDocument/2006/relationships/customProperty";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@".";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"CustomProperty";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetFileExtension
    /// </summary>
    internal const System.String TargetFileExtensionConstant =@".bin";
    /// <summary>
    /// Gets the TargetFileExtension.
    /// </summary>
    internal sealed override string TargetFileExtension
    {
       get { return TargetFileExtensionConstant; }
    } 
    



    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return false; }
    }
}
/// <summary>
/// Defines the CustomXmlMappingsPart.
/// </summary>
public partial class CustomXmlMappingsPart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of CustomXmlMappingsPart
    /// </summary>
    internal protected CustomXmlMappingsPart()
            : base()
    {
    }
    
    

   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/officeDocument/2006/relationships/xmlMaps";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@".";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"xmlMaps";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    



    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the DialogsheetPart.
/// </summary>
public partial class DialogsheetPart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/printerSettings", new PartConstraintRule("SpreadsheetPrinterSettingsPart", SpreadsheetPrinterSettingsPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/drawing", new PartConstraintRule("DrawingsPart", DrawingsPart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/vmlDrawing", new PartConstraintRule("VmlDrawingPart", VmlDrawingPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/oleObject", new PartConstraintRule("EmbeddedObjectPart", null, false, true,(FileFormatVersions)7 ));

            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of DialogsheetPart
    /// </summary>
    internal protected DialogsheetPart()
            : base()
    {
    }
    
    
    /// <summary>
    /// Create an instance of OpenXmlPart according to the given relationship type
    /// </summary>
    /// <param name="relationshipType">Relationship type</param>
    /// <returns>An instance of OpenXmlPart</returns>
    internal sealed override OpenXmlPart CreatePartCore(string relationshipType)
    {
        this.ThrowIfObjectDisposed();

        if ( relationshipType == null )
        {
            throw new ArgumentNullException("relationshipType");
        }
        switch (relationshipType)
        {
        case SpreadsheetPrinterSettingsPart.RelationshipTypeConstant:
                    return new SpreadsheetPrinterSettingsPart();        
            
        case DrawingsPart.RelationshipTypeConstant:
                    return new DrawingsPart();        
            
        case VmlDrawingPart.RelationshipTypeConstant:
                    return new VmlDrawingPart();        
            
        case EmbeddedObjectPart.RelationshipTypeConstant:
                    return new EmbeddedObjectPart();
            

        }
        throw new ArgumentOutOfRangeException("relationshipType");
    }
    

    	/// <summary>
    /// Adds a EmbeddedObjectPart to the DialogsheetPart.
    /// </summary>
    /// <param name="contentType">The content type of the EmbeddedObjectPart.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedObjectPart AddEmbeddedObjectPart(string contentType)
    {
        EmbeddedObjectPart childPart = new EmbeddedObjectPart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
 
    
    
   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/officeDocument/2006/relationships/dialogsheet";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.openxmlformats-officedocument.spreadsheetml.dialogsheet+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@"dialogsheets";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"sheet";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    

        /// <summary>
        /// Gets the SpreadsheetPrinterSettingsParts of the DialogsheetPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<SpreadsheetPrinterSettingsPart> SpreadsheetPrinterSettingsParts
        {
            get{
                    return this.GetPartsOfType<SpreadsheetPrinterSettingsPart>();
                }
        }
                
        /// <summary>
        /// Gets the DrawingsPart of the DialogsheetPart.
        /// </summary>
        public DrawingsPart DrawingsPart
        {
            get {return GetSubPartOfType<DrawingsPart>(); }
        }
        /// <summary>
        /// Gets the VmlDrawingParts of the DialogsheetPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<VmlDrawingPart> VmlDrawingParts
        {
            get{
                    return this.GetPartsOfType<VmlDrawingPart>();
                }
        }
                
        /// <summary>
        /// Gets the EmbeddedObjectParts of the DialogsheetPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<EmbeddedObjectPart> EmbeddedObjectParts
        {
            get{
                    return this.GetPartsOfType<EmbeddedObjectPart>();
                }
        }
                


    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the DrawingsPart.
/// </summary>
public partial class DrawingsPart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/chart", new PartConstraintRule("ChartPart", ChartPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramColors", new PartConstraintRule("DiagramColorsPart", DiagramColorsPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramData", new PartConstraintRule("DiagramDataPart", DiagramDataPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.microsoft.com/office/2007/relationships/diagramDrawing", new PartConstraintRule("DiagramPersistLayoutPart", DiagramPersistLayoutPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramLayout", new PartConstraintRule("DiagramLayoutDefinitionPart", DiagramLayoutDefinitionPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramQuickStyle", new PartConstraintRule("DiagramStylePart", DiagramStylePart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/image", new PartConstraintRule("ImagePart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/customXml", new PartConstraintRule("CustomXmlPart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.microsoft.com/office/2011/relationships/webextension", new PartConstraintRule("WebExtensionPart", WebExtensionPart.ContentTypeConstant, false, true,(FileFormatVersions)4 ));

            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of DrawingsPart
    /// </summary>
    internal protected DrawingsPart()
            : base()
    {
    }
    
    
    /// <summary>
    /// Create an instance of OpenXmlPart according to the given relationship type
    /// </summary>
    /// <param name="relationshipType">Relationship type</param>
    /// <returns>An instance of OpenXmlPart</returns>
    internal sealed override OpenXmlPart CreatePartCore(string relationshipType)
    {
        this.ThrowIfObjectDisposed();

        if ( relationshipType == null )
        {
            throw new ArgumentNullException("relationshipType");
        }
        switch (relationshipType)
        {
        case ChartPart.RelationshipTypeConstant:
                    return new ChartPart();        
            
        case DiagramColorsPart.RelationshipTypeConstant:
                    return new DiagramColorsPart();        
            
        case DiagramDataPart.RelationshipTypeConstant:
                    return new DiagramDataPart();        
            
        case DiagramPersistLayoutPart.RelationshipTypeConstant:
                    return new DiagramPersistLayoutPart();        
            
        case DiagramLayoutDefinitionPart.RelationshipTypeConstant:
                    return new DiagramLayoutDefinitionPart();        
            
        case DiagramStylePart.RelationshipTypeConstant:
                    return new DiagramStylePart();        
            
        case ImagePart.RelationshipTypeConstant:
                    return new ImagePart();
            
        case CustomXmlPart.RelationshipTypeConstant:
                    return new CustomXmlPart();
            
        case WebExtensionPart.RelationshipTypeConstant:
                    return new WebExtensionPart();        
            

        }
        throw new ArgumentOutOfRangeException("relationshipType");
    }
    

        /// <summary>
    /// Adds a ImagePart to the DrawingsPart.
    /// </summary>
    /// <param name="contentType">the content type of the ImagePart.</param>
    /// <returns>The newly added part.</returns>
    public ImagePart AddImagePart(string contentType)
    {
        ImagePart childPart = new ImagePart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a ImagePart to the DrawingsPart.
    /// </summary>
    /// <param name="partType">The part type of the ImagePart.</param>
    /// <returns>The newly added part.</returns>
     public ImagePart AddImagePart(ImagePartType partType)
    {
        string contentType = ImagePartTypeInfo.GetContentType(partType);
        string partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddImagePart(contentType);
    }
    
    /// <summary>
    /// Adds a ImagePart to the DrawingsPart.
    /// </summary>
    /// <param name="contentType">the content type of the ImagePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public ImagePart AddImagePart(string contentType, string id)
    {
        ImagePart childPart = new ImagePart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a ImagePart to the DrawingsPart.
    /// </summary>
    /// <param name="partType">The part type of the ImagePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public ImagePart AddImagePart(ImagePartType partType, string id)
    {
        string contentType = ImagePartTypeInfo.GetContentType(partType);
        string partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddImagePart(contentType, id);
    }
    /// <summary>
    /// Adds a CustomXmlPart to the DrawingsPart.
    /// </summary>
    /// <param name="contentType">the content type of the CustomXmlPart.</param>
    /// <returns>The newly added part.</returns>
    public CustomXmlPart AddCustomXmlPart(string contentType)
    {
        CustomXmlPart childPart = new CustomXmlPart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a CustomXmlPart to the DrawingsPart.
    /// </summary>
    /// <param name="partType">The part type of the CustomXmlPart.</param>
    /// <returns>The newly added part.</returns>
     public CustomXmlPart AddCustomXmlPart(CustomXmlPartType partType)
    {
        string contentType = CustomXmlPartTypeInfo.GetContentType(partType);
        string partExtension = CustomXmlPartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddCustomXmlPart(contentType);
    }
    
    /// <summary>
    /// Adds a CustomXmlPart to the DrawingsPart.
    /// </summary>
    /// <param name="contentType">the content type of the CustomXmlPart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public CustomXmlPart AddCustomXmlPart(string contentType, string id)
    {
        CustomXmlPart childPart = new CustomXmlPart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a CustomXmlPart to the DrawingsPart.
    /// </summary>
    /// <param name="partType">The part type of the CustomXmlPart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public CustomXmlPart AddCustomXmlPart(CustomXmlPartType partType, string id)
    {
        string contentType = CustomXmlPartTypeInfo.GetContentType(partType);
        string partExtension = CustomXmlPartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddCustomXmlPart(contentType, id);
    }
 
    
    
   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/officeDocument/2006/relationships/drawing";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.openxmlformats-officedocument.drawing+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@"../drawings";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"drawing";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    

        /// <summary>
        /// Gets the ChartParts of the DrawingsPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<ChartPart> ChartParts
        {
            get{
                    return this.GetPartsOfType<ChartPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramColorsParts of the DrawingsPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramColorsPart> DiagramColorsParts
        {
            get{
                    return this.GetPartsOfType<DiagramColorsPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramDataParts of the DrawingsPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramDataPart> DiagramDataParts
        {
            get{
                    return this.GetPartsOfType<DiagramDataPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramPersistLayoutParts of the DrawingsPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramPersistLayoutPart> DiagramPersistLayoutParts
        {
            get{
                    return this.GetPartsOfType<DiagramPersistLayoutPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramLayoutDefinitionParts of the DrawingsPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramLayoutDefinitionPart> DiagramLayoutDefinitionParts
        {
            get{
                    return this.GetPartsOfType<DiagramLayoutDefinitionPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramStyleParts of the DrawingsPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramStylePart> DiagramStyleParts
        {
            get{
                    return this.GetPartsOfType<DiagramStylePart>();
                }
        }
                
        /// <summary>
        /// Gets the ImageParts of the DrawingsPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<ImagePart> ImageParts
        {
            get{
                    return this.GetPartsOfType<ImagePart>();
                }
        }
                
        /// <summary>
        /// Gets the CustomXmlParts of the DrawingsPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<CustomXmlPart> CustomXmlParts
        {
            get{
                    return this.GetPartsOfType<CustomXmlPart>();
                }
        }
                
        /// <summary>
        /// Gets the WebExtensionParts of the DrawingsPart., only available in Office2013
        /// </summary>
[OfficeAvailability(FileFormatVersions.Office2013)]
        public System.Collections.Generic.IEnumerable<WebExtensionPart> WebExtensionParts
        {
            get{
                    return this.GetPartsOfType<WebExtensionPart>();
                }
        }
                


    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the ExternalWorkbookPart.
/// </summary>
public partial class ExternalWorkbookPart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of ExternalWorkbookPart
    /// </summary>
    internal protected ExternalWorkbookPart()
            : base()
    {
    }
    
    

   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/officeDocument/2006/relationships/externalLink";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.openxmlformats-officedocument.spreadsheetml.externalLink+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@"externalReferences";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"externalReference";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    



    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the CellMetadataPart.
/// </summary>
public partial class CellMetadataPart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of CellMetadataPart
    /// </summary>
    internal protected CellMetadataPart()
            : base()
    {
    }
    
    

   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/officeDocument/2006/relationships/sheetMetadata";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.openxmlformats-officedocument.spreadsheetml.sheetMetadata+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@".";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"metadata";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    



    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the PivotTablePart.
/// </summary>
public partial class PivotTablePart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/pivotCacheDefinition", new PartConstraintRule("PivotTableCacheDefinitionPart", PivotTableCacheDefinitionPart.ContentTypeConstant, true, false,(FileFormatVersions)7 ));

            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of PivotTablePart
    /// </summary>
    internal protected PivotTablePart()
            : base()
    {
    }
    
    
    /// <summary>
    /// Create an instance of OpenXmlPart according to the given relationship type
    /// </summary>
    /// <param name="relationshipType">Relationship type</param>
    /// <returns>An instance of OpenXmlPart</returns>
    internal sealed override OpenXmlPart CreatePartCore(string relationshipType)
    {
        this.ThrowIfObjectDisposed();

        if ( relationshipType == null )
        {
            throw new ArgumentNullException("relationshipType");
        }
        switch (relationshipType)
        {
        case PivotTableCacheDefinitionPart.RelationshipTypeConstant:
                    return new PivotTableCacheDefinitionPart();        
            

        }
        throw new ArgumentOutOfRangeException("relationshipType");
    }
    

     
    
    
   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/officeDocument/2006/relationships/pivotTable";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.openxmlformats-officedocument.spreadsheetml.pivotTable+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@"../pivotTables";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"pivotTable";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    

        /// <summary>
        /// Gets the PivotTableCacheDefinitionPart of the PivotTablePart.
        /// </summary>
        public PivotTableCacheDefinitionPart PivotTableCacheDefinitionPart
        {
            get {return GetSubPartOfType<PivotTableCacheDefinitionPart>(); }
        }


    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the PivotTableCacheDefinitionPart.
/// </summary>
public partial class PivotTableCacheDefinitionPart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/pivotCacheRecords", new PartConstraintRule("PivotTableCacheRecordsPart", PivotTableCacheRecordsPart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));

            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of PivotTableCacheDefinitionPart
    /// </summary>
    internal protected PivotTableCacheDefinitionPart()
            : base()
    {
    }
    
    
    /// <summary>
    /// Create an instance of OpenXmlPart according to the given relationship type
    /// </summary>
    /// <param name="relationshipType">Relationship type</param>
    /// <returns>An instance of OpenXmlPart</returns>
    internal sealed override OpenXmlPart CreatePartCore(string relationshipType)
    {
        this.ThrowIfObjectDisposed();

        if ( relationshipType == null )
        {
            throw new ArgumentNullException("relationshipType");
        }
        switch (relationshipType)
        {
        case PivotTableCacheRecordsPart.RelationshipTypeConstant:
                    return new PivotTableCacheRecordsPart();        
            

        }
        throw new ArgumentOutOfRangeException("relationshipType");
    }
    

     
    
    
   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/officeDocument/2006/relationships/pivotCacheDefinition";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.openxmlformats-officedocument.spreadsheetml.pivotCacheDefinition+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@"../pivotCache";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"pivotCacheDefinition";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    

        /// <summary>
        /// Gets the PivotTableCacheRecordsPart of the PivotTableCacheDefinitionPart.
        /// </summary>
        public PivotTableCacheRecordsPart PivotTableCacheRecordsPart
        {
            get {return GetSubPartOfType<PivotTableCacheRecordsPart>(); }
        }


    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the PivotTableCacheRecordsPart.
/// </summary>
public partial class PivotTableCacheRecordsPart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of PivotTableCacheRecordsPart
    /// </summary>
    internal protected PivotTableCacheRecordsPart()
            : base()
    {
    }
    
    

   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/officeDocument/2006/relationships/pivotCacheRecords";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.openxmlformats-officedocument.spreadsheetml.pivotCacheRecords+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@".";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"pivotCacheRecords";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    



    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the QueryTablePart.
/// </summary>
public partial class QueryTablePart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of QueryTablePart
    /// </summary>
    internal protected QueryTablePart()
            : base()
    {
    }
    
    

   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/officeDocument/2006/relationships/queryTable";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.openxmlformats-officedocument.spreadsheetml.queryTable+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@"../queryTables";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"queryTable";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    



    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the SharedStringTablePart.
/// </summary>
public partial class SharedStringTablePart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of SharedStringTablePart
    /// </summary>
    internal protected SharedStringTablePart()
            : base()
    {
    }
    
    

   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/officeDocument/2006/relationships/sharedStrings";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.openxmlformats-officedocument.spreadsheetml.sharedStrings+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@".";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"sharedStrings";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    



    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the WorkbookRevisionHeaderPart.
/// </summary>
public partial class WorkbookRevisionHeaderPart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/revisionLog", new PartConstraintRule("WorkbookRevisionLogPart", WorkbookRevisionLogPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));

            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of WorkbookRevisionHeaderPart
    /// </summary>
    internal protected WorkbookRevisionHeaderPart()
            : base()
    {
    }
    
    
    /// <summary>
    /// Create an instance of OpenXmlPart according to the given relationship type
    /// </summary>
    /// <param name="relationshipType">Relationship type</param>
    /// <returns>An instance of OpenXmlPart</returns>
    internal sealed override OpenXmlPart CreatePartCore(string relationshipType)
    {
        this.ThrowIfObjectDisposed();

        if ( relationshipType == null )
        {
            throw new ArgumentNullException("relationshipType");
        }
        switch (relationshipType)
        {
        case WorkbookRevisionLogPart.RelationshipTypeConstant:
                    return new WorkbookRevisionLogPart();        
            

        }
        throw new ArgumentOutOfRangeException("relationshipType");
    }
    

     
    
    
   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/officeDocument/2006/relationships/revisionHeaders";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.openxmlformats-officedocument.spreadsheetml.revisionHeaders+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@"revisions";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"revisionHeaders";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    

        /// <summary>
        /// Gets the WorkbookRevisionLogParts of the WorkbookRevisionHeaderPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<WorkbookRevisionLogPart> WorkbookRevisionLogParts
        {
            get{
                    return this.GetPartsOfType<WorkbookRevisionLogPart>();
                }
        }
                


    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the WorkbookRevisionLogPart.
/// </summary>
public partial class WorkbookRevisionLogPart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of WorkbookRevisionLogPart
    /// </summary>
    internal protected WorkbookRevisionLogPart()
            : base()
    {
    }
    
    

   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/officeDocument/2006/relationships/revisionLog";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.openxmlformats-officedocument.spreadsheetml.revisionLog+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@".";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"revisionLog";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    



    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the WorkbookUserDataPart.
/// </summary>
public partial class WorkbookUserDataPart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of WorkbookUserDataPart
    /// </summary>
    internal protected WorkbookUserDataPart()
            : base()
    {
    }
    
    

   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/officeDocument/2006/relationships/usernames";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.openxmlformats-officedocument.spreadsheetml.userNames+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@"revisions";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"userNames";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    



    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the SingleCellTablePart.
/// </summary>
public partial class SingleCellTablePart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of SingleCellTablePart
    /// </summary>
    internal protected SingleCellTablePart()
            : base()
    {
    }
    
    

   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/officeDocument/2006/relationships/tableSingleCells";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.openxmlformats-officedocument.spreadsheetml.tableSingleCells+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@"../tables";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"tableSingleCells";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    



    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the WorkbookStylesPart.
/// </summary>
public partial class WorkbookStylesPart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of WorkbookStylesPart
    /// </summary>
    internal protected WorkbookStylesPart()
            : base()
    {
    }
    
    

   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/officeDocument/2006/relationships/styles";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.openxmlformats-officedocument.spreadsheetml.styles+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@".";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"styles";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    



    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the TableDefinitionPart.
/// </summary>
public partial class TableDefinitionPart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/queryTable", new PartConstraintRule("QueryTablePart", QueryTablePart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));

            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of TableDefinitionPart
    /// </summary>
    internal protected TableDefinitionPart()
            : base()
    {
    }
    
    
    /// <summary>
    /// Create an instance of OpenXmlPart according to the given relationship type
    /// </summary>
    /// <param name="relationshipType">Relationship type</param>
    /// <returns>An instance of OpenXmlPart</returns>
    internal sealed override OpenXmlPart CreatePartCore(string relationshipType)
    {
        this.ThrowIfObjectDisposed();

        if ( relationshipType == null )
        {
            throw new ArgumentNullException("relationshipType");
        }
        switch (relationshipType)
        {
        case QueryTablePart.RelationshipTypeConstant:
                    return new QueryTablePart();        
            

        }
        throw new ArgumentOutOfRangeException("relationshipType");
    }
    

     
    
    
   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/officeDocument/2006/relationships/table";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.openxmlformats-officedocument.spreadsheetml.table+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@"../tables";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"table";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    

        /// <summary>
        /// Gets the QueryTableParts of the TableDefinitionPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<QueryTablePart> QueryTableParts
        {
            get{
                    return this.GetPartsOfType<QueryTablePart>();
                }
        }
                


    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the VolatileDependenciesPart.
/// </summary>
public partial class VolatileDependenciesPart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of VolatileDependenciesPart
    /// </summary>
    internal protected VolatileDependenciesPart()
            : base()
    {
    }
    
    

   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/officeDocument/2006/relationships/volatileDependencies";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.openxmlformats-officedocument.spreadsheetml.volatileDependencies+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@".";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"volatileDependencies";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    



    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the WorksheetPart.
/// </summary>
public partial class WorksheetPart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/printerSettings", new PartConstraintRule("SpreadsheetPrinterSettingsPart", SpreadsheetPrinterSettingsPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/drawing", new PartConstraintRule("DrawingsPart", DrawingsPart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/vmlDrawing", new PartConstraintRule("VmlDrawingPart", VmlDrawingPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/comments", new PartConstraintRule("WorksheetCommentsPart", WorksheetCommentsPart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/pivotTable", new PartConstraintRule("PivotTablePart", PivotTablePart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/tableSingleCells", new PartConstraintRule("SingleCellTablePart", SingleCellTablePart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/table", new PartConstraintRule("TableDefinitionPart", TableDefinitionPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/control", new PartConstraintRule("EmbeddedControlPersistencePart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/ctrlProp", new PartConstraintRule("ControlPropertiesPart", ControlPropertiesPart.ContentTypeConstant, false, true,(FileFormatVersions)2 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/oleObject", new PartConstraintRule("EmbeddedObjectPart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/package", new PartConstraintRule("EmbeddedPackagePart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/image", new PartConstraintRule("ImagePart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/customProperty", new PartConstraintRule("CustomPropertyPart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.microsoft.com/office/2006/relationships/wsSortMap", new PartConstraintRule("WorksheetSortMapPart", WorksheetSortMapPart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/queryTable", new PartConstraintRule("QueryTablePart", QueryTablePart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.microsoft.com/office/2006/relationships/activeXControlBinary", new PartConstraintRule("EmbeddedControlPersistenceBinaryDataPart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.microsoft.com/office/2007/relationships/slicer", new PartConstraintRule("SlicersPart", SlicersPart.ContentTypeConstant, false, true,(FileFormatVersions)2 ));
tempData.Add("http://schemas.microsoft.com/office/2011/relationships/timeline", new PartConstraintRule("TimeLinePart", TimeLinePart.ContentTypeConstant, false, true,(FileFormatVersions)4 ));

            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of WorksheetPart
    /// </summary>
    internal protected WorksheetPart()
            : base()
    {
    }
    
    
    /// <summary>
    /// Create an instance of OpenXmlPart according to the given relationship type
    /// </summary>
    /// <param name="relationshipType">Relationship type</param>
    /// <returns>An instance of OpenXmlPart</returns>
    internal sealed override OpenXmlPart CreatePartCore(string relationshipType)
    {
        this.ThrowIfObjectDisposed();

        if ( relationshipType == null )
        {
            throw new ArgumentNullException("relationshipType");
        }
        switch (relationshipType)
        {
        case SpreadsheetPrinterSettingsPart.RelationshipTypeConstant:
                    return new SpreadsheetPrinterSettingsPart();        
            
        case DrawingsPart.RelationshipTypeConstant:
                    return new DrawingsPart();        
            
        case VmlDrawingPart.RelationshipTypeConstant:
                    return new VmlDrawingPart();        
            
        case WorksheetCommentsPart.RelationshipTypeConstant:
                    return new WorksheetCommentsPart();        
            
        case PivotTablePart.RelationshipTypeConstant:
                    return new PivotTablePart();        
            
        case SingleCellTablePart.RelationshipTypeConstant:
                    return new SingleCellTablePart();        
            
        case TableDefinitionPart.RelationshipTypeConstant:
                    return new TableDefinitionPart();        
            
        case EmbeddedControlPersistencePart.RelationshipTypeConstant:
                    return new EmbeddedControlPersistencePart();
            
        case ControlPropertiesPart.RelationshipTypeConstant:
                    return new ControlPropertiesPart();        
            
        case EmbeddedObjectPart.RelationshipTypeConstant:
                    return new EmbeddedObjectPart();
            
        case EmbeddedPackagePart.RelationshipTypeConstant:
                    return new EmbeddedPackagePart();
            
        case ImagePart.RelationshipTypeConstant:
                    return new ImagePart();
            
        case CustomPropertyPart.RelationshipTypeConstant:
                    return new CustomPropertyPart();
            
        case WorksheetSortMapPart.RelationshipTypeConstant:
                    return new WorksheetSortMapPart();        
            
        case QueryTablePart.RelationshipTypeConstant:
                    return new QueryTablePart();        
            
        case EmbeddedControlPersistenceBinaryDataPart.RelationshipTypeConstant:
                    return new EmbeddedControlPersistenceBinaryDataPart();
            
        case SlicersPart.RelationshipTypeConstant:
                    return new SlicersPart();        
            
        case TimeLinePart.RelationshipTypeConstant:
                    return new TimeLinePart();        
            

        }
        throw new ArgumentOutOfRangeException("relationshipType");
    }
    

        /// <summary>
    /// Adds a EmbeddedControlPersistencePart to the WorksheetPart.
    /// </summary>
    /// <param name="contentType">the content type of the EmbeddedControlPersistencePart.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(string contentType)
    {
        EmbeddedControlPersistencePart childPart = new EmbeddedControlPersistencePart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a EmbeddedControlPersistencePart to the WorksheetPart.
    /// </summary>
    /// <param name="partType">The part type of the EmbeddedControlPersistencePart.</param>
    /// <returns>The newly added part.</returns>
     public EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(EmbeddedControlPersistencePartType partType)
    {
        string contentType = EmbeddedControlPersistencePartTypeInfo.GetContentType(partType);
        string partExtension = EmbeddedControlPersistencePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddEmbeddedControlPersistencePart(contentType);
    }
    
    /// <summary>
    /// Adds a EmbeddedControlPersistencePart to the WorksheetPart.
    /// </summary>
    /// <param name="contentType">the content type of the EmbeddedControlPersistencePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(string contentType, string id)
    {
        EmbeddedControlPersistencePart childPart = new EmbeddedControlPersistencePart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a EmbeddedControlPersistencePart to the WorksheetPart.
    /// </summary>
    /// <param name="partType">The part type of the EmbeddedControlPersistencePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(EmbeddedControlPersistencePartType partType, string id)
    {
        string contentType = EmbeddedControlPersistencePartTypeInfo.GetContentType(partType);
        string partExtension = EmbeddedControlPersistencePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddEmbeddedControlPersistencePart(contentType, id);
    }
	/// <summary>
    /// Adds a EmbeddedObjectPart to the WorksheetPart.
    /// </summary>
    /// <param name="contentType">The content type of the EmbeddedObjectPart.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedObjectPart AddEmbeddedObjectPart(string contentType)
    {
        EmbeddedObjectPart childPart = new EmbeddedObjectPart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
	/// <summary>
    /// Adds a EmbeddedPackagePart to the WorksheetPart.
    /// </summary>
    /// <param name="contentType">The content type of the EmbeddedPackagePart.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedPackagePart AddEmbeddedPackagePart(string contentType)
    {
        EmbeddedPackagePart childPart = new EmbeddedPackagePart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a ImagePart to the WorksheetPart.
    /// </summary>
    /// <param name="contentType">the content type of the ImagePart.</param>
    /// <returns>The newly added part.</returns>
    public ImagePart AddImagePart(string contentType)
    {
        ImagePart childPart = new ImagePart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a ImagePart to the WorksheetPart.
    /// </summary>
    /// <param name="partType">The part type of the ImagePart.</param>
    /// <returns>The newly added part.</returns>
     public ImagePart AddImagePart(ImagePartType partType)
    {
        string contentType = ImagePartTypeInfo.GetContentType(partType);
        string partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddImagePart(contentType);
    }
    
    /// <summary>
    /// Adds a ImagePart to the WorksheetPart.
    /// </summary>
    /// <param name="contentType">the content type of the ImagePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public ImagePart AddImagePart(string contentType, string id)
    {
        ImagePart childPart = new ImagePart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a ImagePart to the WorksheetPart.
    /// </summary>
    /// <param name="partType">The part type of the ImagePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public ImagePart AddImagePart(ImagePartType partType, string id)
    {
        string contentType = ImagePartTypeInfo.GetContentType(partType);
        string partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddImagePart(contentType, id);
    }
    /// <summary>
    /// Adds a CustomPropertyPart to the WorksheetPart.
    /// </summary>
    /// <param name="contentType">the content type of the CustomPropertyPart.</param>
    /// <returns>The newly added part.</returns>
    public CustomPropertyPart AddCustomPropertyPart(string contentType)
    {
        CustomPropertyPart childPart = new CustomPropertyPart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a CustomPropertyPart to the WorksheetPart.
    /// </summary>
    /// <param name="partType">The part type of the CustomPropertyPart.</param>
    /// <returns>The newly added part.</returns>
     public CustomPropertyPart AddCustomPropertyPart(CustomPropertyPartType partType)
    {
        string contentType = CustomPropertyPartTypeInfo.GetContentType(partType);
        string partExtension = CustomPropertyPartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddCustomPropertyPart(contentType);
    }
    
    /// <summary>
    /// Adds a CustomPropertyPart to the WorksheetPart.
    /// </summary>
    /// <param name="contentType">the content type of the CustomPropertyPart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public CustomPropertyPart AddCustomPropertyPart(string contentType, string id)
    {
        CustomPropertyPart childPart = new CustomPropertyPart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a CustomPropertyPart to the WorksheetPart.
    /// </summary>
    /// <param name="partType">The part type of the CustomPropertyPart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public CustomPropertyPart AddCustomPropertyPart(CustomPropertyPartType partType, string id)
    {
        string contentType = CustomPropertyPartTypeInfo.GetContentType(partType);
        string partExtension = CustomPropertyPartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddCustomPropertyPart(contentType, id);
    }
    /// <summary>
    /// Adds a EmbeddedControlPersistenceBinaryDataPart to the WorksheetPart.
    /// </summary>
    /// <param name="contentType">the content type of the EmbeddedControlPersistenceBinaryDataPart.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedControlPersistenceBinaryDataPart AddEmbeddedControlPersistenceBinaryDataPart(string contentType)
    {
        EmbeddedControlPersistenceBinaryDataPart childPart = new EmbeddedControlPersistenceBinaryDataPart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a EmbeddedControlPersistenceBinaryDataPart to the WorksheetPart.
    /// </summary>
    /// <param name="partType">The part type of the EmbeddedControlPersistenceBinaryDataPart.</param>
    /// <returns>The newly added part.</returns>
     public EmbeddedControlPersistenceBinaryDataPart AddEmbeddedControlPersistenceBinaryDataPart(EmbeddedControlPersistenceBinaryDataPartType partType)
    {
        string contentType = EmbeddedControlPersistenceBinaryDataPartTypeInfo.GetContentType(partType);
        string partExtension = EmbeddedControlPersistenceBinaryDataPartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddEmbeddedControlPersistenceBinaryDataPart(contentType);
    }
    
    /// <summary>
    /// Adds a EmbeddedControlPersistenceBinaryDataPart to the WorksheetPart.
    /// </summary>
    /// <param name="contentType">the content type of the EmbeddedControlPersistenceBinaryDataPart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedControlPersistenceBinaryDataPart AddEmbeddedControlPersistenceBinaryDataPart(string contentType, string id)
    {
        EmbeddedControlPersistenceBinaryDataPart childPart = new EmbeddedControlPersistenceBinaryDataPart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a EmbeddedControlPersistenceBinaryDataPart to the WorksheetPart.
    /// </summary>
    /// <param name="partType">The part type of the EmbeddedControlPersistenceBinaryDataPart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public EmbeddedControlPersistenceBinaryDataPart AddEmbeddedControlPersistenceBinaryDataPart(EmbeddedControlPersistenceBinaryDataPartType partType, string id)
    {
        string contentType = EmbeddedControlPersistenceBinaryDataPartTypeInfo.GetContentType(partType);
        string partExtension = EmbeddedControlPersistenceBinaryDataPartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddEmbeddedControlPersistenceBinaryDataPart(contentType, id);
    }
 
    
    
   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/officeDocument/2006/relationships/worksheet";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.openxmlformats-officedocument.spreadsheetml.worksheet+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@"worksheets";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"sheet";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    

        /// <summary>
        /// Gets the SpreadsheetPrinterSettingsParts of the WorksheetPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<SpreadsheetPrinterSettingsPart> SpreadsheetPrinterSettingsParts
        {
            get{
                    return this.GetPartsOfType<SpreadsheetPrinterSettingsPart>();
                }
        }
                
        /// <summary>
        /// Gets the DrawingsPart of the WorksheetPart.
        /// </summary>
        public DrawingsPart DrawingsPart
        {
            get {return GetSubPartOfType<DrawingsPart>(); }
        }
        /// <summary>
        /// Gets the VmlDrawingParts of the WorksheetPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<VmlDrawingPart> VmlDrawingParts
        {
            get{
                    return this.GetPartsOfType<VmlDrawingPart>();
                }
        }
                
        /// <summary>
        /// Gets the WorksheetCommentsPart of the WorksheetPart.
        /// </summary>
        public WorksheetCommentsPart WorksheetCommentsPart
        {
            get {return GetSubPartOfType<WorksheetCommentsPart>(); }
        }
        /// <summary>
        /// Gets the PivotTableParts of the WorksheetPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<PivotTablePart> PivotTableParts
        {
            get{
                    return this.GetPartsOfType<PivotTablePart>();
                }
        }
                
        /// <summary>
        /// Gets the SingleCellTablePart of the WorksheetPart.
        /// </summary>
        public SingleCellTablePart SingleCellTablePart
        {
            get {return GetSubPartOfType<SingleCellTablePart>(); }
        }
        /// <summary>
        /// Gets the TableDefinitionParts of the WorksheetPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<TableDefinitionPart> TableDefinitionParts
        {
            get{
                    return this.GetPartsOfType<TableDefinitionPart>();
                }
        }
                
        /// <summary>
        /// Gets the EmbeddedControlPersistenceParts of the WorksheetPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<EmbeddedControlPersistencePart> EmbeddedControlPersistenceParts
        {
            get{
                    return this.GetPartsOfType<EmbeddedControlPersistencePart>();
                }
        }
                
        /// <summary>
        /// Gets the ControlPropertiesParts of the WorksheetPart., only available in Office2010
        /// </summary>
[OfficeAvailability(FileFormatVersions.Office2010)]
        public System.Collections.Generic.IEnumerable<ControlPropertiesPart> ControlPropertiesParts
        {
            get{
                    return this.GetPartsOfType<ControlPropertiesPart>();
                }
        }
                
        /// <summary>
        /// Gets the EmbeddedObjectParts of the WorksheetPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<EmbeddedObjectPart> EmbeddedObjectParts
        {
            get{
                    return this.GetPartsOfType<EmbeddedObjectPart>();
                }
        }
                
        /// <summary>
        /// Gets the EmbeddedPackageParts of the WorksheetPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<EmbeddedPackagePart> EmbeddedPackageParts
        {
            get{
                    return this.GetPartsOfType<EmbeddedPackagePart>();
                }
        }
                
        /// <summary>
        /// Gets the ImageParts of the WorksheetPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<ImagePart> ImageParts
        {
            get{
                    return this.GetPartsOfType<ImagePart>();
                }
        }
                
        /// <summary>
        /// Gets the CustomPropertyParts of the WorksheetPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<CustomPropertyPart> CustomPropertyParts
        {
            get{
                    return this.GetPartsOfType<CustomPropertyPart>();
                }
        }
                
        /// <summary>
        /// Gets the WorksheetSortMapPart of the WorksheetPart.
        /// </summary>
        public WorksheetSortMapPart WorksheetSortMapPart
        {
            get {return GetSubPartOfType<WorksheetSortMapPart>(); }
        }
        /// <summary>
        /// Gets the QueryTableParts of the WorksheetPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<QueryTablePart> QueryTableParts
        {
            get{
                    return this.GetPartsOfType<QueryTablePart>();
                }
        }
                
        /// <summary>
        /// Gets the EmbeddedControlPersistenceBinaryDataParts of the WorksheetPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<EmbeddedControlPersistenceBinaryDataPart> EmbeddedControlPersistenceBinaryDataParts
        {
            get{
                    return this.GetPartsOfType<EmbeddedControlPersistenceBinaryDataPart>();
                }
        }
                
        /// <summary>
        /// Gets the SlicersParts of the WorksheetPart., only available in Office2010
        /// </summary>
[OfficeAvailability(FileFormatVersions.Office2010)]
        public System.Collections.Generic.IEnumerable<SlicersPart> SlicersParts
        {
            get{
                    return this.GetPartsOfType<SlicersPart>();
                }
        }
                
        /// <summary>
        /// Gets the TimeLineParts of the WorksheetPart., only available in Office2013
        /// </summary>
[OfficeAvailability(FileFormatVersions.Office2013)]
        public System.Collections.Generic.IEnumerable<TimeLinePart> TimeLineParts
        {
            get{
                    return this.GetPartsOfType<TimeLinePart>();
                }
        }
                


    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the ExcelAttachedToolbarsPart.
/// </summary>
public partial class ExcelAttachedToolbarsPart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of ExcelAttachedToolbarsPart
    /// </summary>
    internal protected ExcelAttachedToolbarsPart()
            : base()
    {
    }
    
    

   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.microsoft.com/office/2006/relationships/attachedToolbars";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.ms-excel.attachedToolbars";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@".";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"attachedToolbars";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetFileExtension
    /// </summary>
    internal const System.String TargetFileExtensionConstant =@".bin";
    /// <summary>
    /// Gets the TargetFileExtension.
    /// </summary>
    internal sealed override string TargetFileExtension
    {
       get { return TargetFileExtensionConstant; }
    } 
    



    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the WorksheetSortMapPart.
/// </summary>
public partial class WorksheetSortMapPart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of WorksheetSortMapPart
    /// </summary>
    internal protected WorksheetSortMapPart()
            : base()
    {
    }
    
    

   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.microsoft.com/office/2006/relationships/wsSortMap";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.ms-excel.wsSortMap+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@".";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"wsSortMap";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    



    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the PresentationPart.
/// </summary>
public partial class PresentationPart : OpenXmlPart 
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/customXml", new PartConstraintRule("CustomXmlPart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/font", new PartConstraintRule("FontPart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/presProps", new PartConstraintRule("PresentationPropertiesPart", PresentationPropertiesPart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/tableStyles", new PartConstraintRule("TableStylesPart", TableStylesPart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/theme", new PartConstraintRule("ThemePart", ThemePart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/viewProps", new PartConstraintRule("ViewPropertiesPart", ViewPropertiesPart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/notesMaster", new PartConstraintRule("NotesMasterPart", NotesMasterPart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/slide", new PartConstraintRule("SlidePart", SlidePart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/slideMaster", new PartConstraintRule("SlideMasterPart", SlideMasterPart.ContentTypeConstant, true, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/tags", new PartConstraintRule("UserDefinedTagsPart", UserDefinedTagsPart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/commentAuthors", new PartConstraintRule("CommentAuthorsPart", CommentAuthorsPart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/handoutMaster", new PartConstraintRule("HandoutMasterPart", HandoutMasterPart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.microsoft.com/office/2006/relationships/legacyDocTextInfo", new PartConstraintRule("LegacyDiagramTextInfoPart", LegacyDiagramTextInfoPart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.microsoft.com/office/2006/relationships/vbaProject", new PartConstraintRule("VbaProjectPart", VbaProjectPart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));

            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of PresentationPart
    /// </summary>
    internal protected PresentationPart()
            : base()
    {
    }
    
    
    /// <summary>
    /// Create an instance of OpenXmlPart according to the given relationship type
    /// </summary>
    /// <param name="relationshipType">Relationship type</param>
    /// <returns>An instance of OpenXmlPart</returns>
    internal sealed override OpenXmlPart CreatePartCore(string relationshipType)
    {
        this.ThrowIfObjectDisposed();

        if ( relationshipType == null )
        {
            throw new ArgumentNullException("relationshipType");
        }
        switch (relationshipType)
        {
        case CustomXmlPart.RelationshipTypeConstant:
                    return new CustomXmlPart();
            
        case FontPart.RelationshipTypeConstant:
                    return new FontPart();
            
        case PresentationPropertiesPart.RelationshipTypeConstant:
                    return new PresentationPropertiesPart();        
            
        case TableStylesPart.RelationshipTypeConstant:
                    return new TableStylesPart();        
            
        case ThemePart.RelationshipTypeConstant:
                    return new ThemePart();        
            
        case ViewPropertiesPart.RelationshipTypeConstant:
                    return new ViewPropertiesPart();        
            
        case NotesMasterPart.RelationshipTypeConstant:
                    return new NotesMasterPart();        
            
        case SlidePart.RelationshipTypeConstant:
                    return new SlidePart();        
            
        case SlideMasterPart.RelationshipTypeConstant:
                    return new SlideMasterPart();        
            
        case UserDefinedTagsPart.RelationshipTypeConstant:
                    return new UserDefinedTagsPart();        
            
        case CommentAuthorsPart.RelationshipTypeConstant:
                    return new CommentAuthorsPart();        
            
        case HandoutMasterPart.RelationshipTypeConstant:
                    return new HandoutMasterPart();        
            
        case LegacyDiagramTextInfoPart.RelationshipTypeConstant:
                    return new LegacyDiagramTextInfoPart();        
            
        case VbaProjectPart.RelationshipTypeConstant:
                    return new VbaProjectPart();        
            

        }
        throw new ArgumentOutOfRangeException("relationshipType");
    }
    

        /// <summary>
    /// Adds a CustomXmlPart to the PresentationPart.
    /// </summary>
    /// <param name="contentType">the content type of the CustomXmlPart.</param>
    /// <returns>The newly added part.</returns>
    public CustomXmlPart AddCustomXmlPart(string contentType)
    {
        CustomXmlPart childPart = new CustomXmlPart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a CustomXmlPart to the PresentationPart.
    /// </summary>
    /// <param name="partType">The part type of the CustomXmlPart.</param>
    /// <returns>The newly added part.</returns>
     public CustomXmlPart AddCustomXmlPart(CustomXmlPartType partType)
    {
        string contentType = CustomXmlPartTypeInfo.GetContentType(partType);
        string partExtension = CustomXmlPartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddCustomXmlPart(contentType);
    }
    
    /// <summary>
    /// Adds a CustomXmlPart to the PresentationPart.
    /// </summary>
    /// <param name="contentType">the content type of the CustomXmlPart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public CustomXmlPart AddCustomXmlPart(string contentType, string id)
    {
        CustomXmlPart childPart = new CustomXmlPart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a CustomXmlPart to the PresentationPart.
    /// </summary>
    /// <param name="partType">The part type of the CustomXmlPart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public CustomXmlPart AddCustomXmlPart(CustomXmlPartType partType, string id)
    {
        string contentType = CustomXmlPartTypeInfo.GetContentType(partType);
        string partExtension = CustomXmlPartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddCustomXmlPart(contentType, id);
    }
    /// <summary>
    /// Adds a FontPart to the PresentationPart.
    /// </summary>
    /// <param name="contentType">the content type of the FontPart.</param>
    /// <returns>The newly added part.</returns>
    public FontPart AddFontPart(string contentType)
    {
        FontPart childPart = new FontPart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a FontPart to the PresentationPart.
    /// </summary>
    /// <param name="partType">The part type of the FontPart.</param>
    /// <returns>The newly added part.</returns>
     public FontPart AddFontPart(FontPartType partType)
    {
        string contentType = FontPartTypeInfo.GetContentType(partType);
        string partExtension = FontPartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddFontPart(contentType);
    }
    
    /// <summary>
    /// Adds a FontPart to the PresentationPart.
    /// </summary>
    /// <param name="contentType">the content type of the FontPart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public FontPart AddFontPart(string contentType, string id)
    {
        FontPart childPart = new FontPart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a FontPart to the PresentationPart.
    /// </summary>
    /// <param name="partType">The part type of the FontPart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public FontPart AddFontPart(FontPartType partType, string id)
    {
        string contentType = FontPartTypeInfo.GetContentType(partType);
        string partExtension = FontPartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddFontPart(contentType, id);
    }
 
    
    
   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@"ppt";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"presentation";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    

        /// <summary>
        /// Gets the CustomXmlParts of the PresentationPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<CustomXmlPart> CustomXmlParts
        {
            get{
                    return this.GetPartsOfType<CustomXmlPart>();
                }
        }
                
        /// <summary>
        /// Gets the FontParts of the PresentationPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<FontPart> FontParts
        {
            get{
                    return this.GetPartsOfType<FontPart>();
                }
        }
                
        /// <summary>
        /// Gets the PresentationPropertiesPart of the PresentationPart.
        /// </summary>
        public PresentationPropertiesPart PresentationPropertiesPart
        {
            get {return GetSubPartOfType<PresentationPropertiesPart>(); }
        }
        /// <summary>
        /// Gets the TableStylesPart of the PresentationPart.
        /// </summary>
        public TableStylesPart TableStylesPart
        {
            get {return GetSubPartOfType<TableStylesPart>(); }
        }
        /// <summary>
        /// Gets the ThemePart of the PresentationPart.
        /// </summary>
        public ThemePart ThemePart
        {
            get {return GetSubPartOfType<ThemePart>(); }
        }
        /// <summary>
        /// Gets the ViewPropertiesPart of the PresentationPart.
        /// </summary>
        public ViewPropertiesPart ViewPropertiesPart
        {
            get {return GetSubPartOfType<ViewPropertiesPart>(); }
        }
        /// <summary>
        /// Gets the NotesMasterPart of the PresentationPart.
        /// </summary>
        public NotesMasterPart NotesMasterPart
        {
            get {return GetSubPartOfType<NotesMasterPart>(); }
        }
        /// <summary>
        /// Gets the SlideParts of the PresentationPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<SlidePart> SlideParts
        {
            get{
                    return this.GetPartsOfType<SlidePart>();
                }
        }
                
        /// <summary>
        /// Gets the SlideMasterParts of the PresentationPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<SlideMasterPart> SlideMasterParts
        {
            get{
                    return this.GetPartsOfType<SlideMasterPart>();
                }
        }
                
        /// <summary>
        /// Gets the UserDefinedTagsPart of the PresentationPart.
        /// </summary>
        public UserDefinedTagsPart UserDefinedTagsPart
        {
            get {return GetSubPartOfType<UserDefinedTagsPart>(); }
        }
        /// <summary>
        /// Gets the CommentAuthorsPart of the PresentationPart.
        /// </summary>
        public CommentAuthorsPart CommentAuthorsPart
        {
            get {return GetSubPartOfType<CommentAuthorsPart>(); }
        }
        /// <summary>
        /// Gets the HandoutMasterPart of the PresentationPart.
        /// </summary>
        public HandoutMasterPart HandoutMasterPart
        {
            get {return GetSubPartOfType<HandoutMasterPart>(); }
        }
        /// <summary>
        /// Gets the LegacyDiagramTextInfoPart of the PresentationPart.
        /// </summary>
        public LegacyDiagramTextInfoPart LegacyDiagramTextInfoPart
        {
            get {return GetSubPartOfType<LegacyDiagramTextInfoPart>(); }
        }
        /// <summary>
        /// Gets the VbaProjectPart of the PresentationPart.
        /// </summary>
        public VbaProjectPart VbaProjectPart
        {
            get {return GetSubPartOfType<VbaProjectPart>(); }
        }


    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return false; }
    }
}
/// <summary>
/// Defines the CommentAuthorsPart.
/// </summary>
public partial class CommentAuthorsPart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of CommentAuthorsPart
    /// </summary>
    internal protected CommentAuthorsPart()
            : base()
    {
    }
    
    

   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/officeDocument/2006/relationships/commentAuthors";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.openxmlformats-officedocument.presentationml.commentAuthors+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@".";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"commentAuthors";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    



    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the SlideCommentsPart.
/// </summary>
public partial class SlideCommentsPart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of SlideCommentsPart
    /// </summary>
    internal protected SlideCommentsPart()
            : base()
    {
    }
    
    

   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/officeDocument/2006/relationships/comments";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.openxmlformats-officedocument.presentationml.comments+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@"../comments";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"comment";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    



    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the HandoutMasterPart.
/// </summary>
public partial class HandoutMasterPart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/customXml", new PartConstraintRule("CustomXmlPart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/chart", new PartConstraintRule("ChartPart", ChartPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramColors", new PartConstraintRule("DiagramColorsPart", DiagramColorsPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramData", new PartConstraintRule("DiagramDataPart", DiagramDataPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.microsoft.com/office/2007/relationships/diagramDrawing", new PartConstraintRule("DiagramPersistLayoutPart", DiagramPersistLayoutPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramLayout", new PartConstraintRule("DiagramLayoutDefinitionPart", DiagramLayoutDefinitionPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramQuickStyle", new PartConstraintRule("DiagramStylePart", DiagramStylePart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/oleObject", new PartConstraintRule("EmbeddedObjectPart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/package", new PartConstraintRule("EmbeddedPackagePart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/image", new PartConstraintRule("ImagePart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/vmlDrawing", new PartConstraintRule("VmlDrawingPart", VmlDrawingPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.microsoft.com/office/2006/relationships/activeXControlBinary", new PartConstraintRule("EmbeddedControlPersistenceBinaryDataPart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/theme", new PartConstraintRule("ThemePart", ThemePart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/tags", new PartConstraintRule("UserDefinedTagsPart", UserDefinedTagsPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/slide", new PartConstraintRule("SlidePart", SlidePart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));

            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/audio", new PartConstraintRule("AudioReferenceRelationship", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/video", new PartConstraintRule("VideoReferenceRelationship", null, false, true,(FileFormatVersions)7 ));

            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of HandoutMasterPart
    /// </summary>
    internal protected HandoutMasterPart()
            : base()
    {
    }
    
    
    /// <summary>
    /// Create an instance of OpenXmlPart according to the given relationship type
    /// </summary>
    /// <param name="relationshipType">Relationship type</param>
    /// <returns>An instance of OpenXmlPart</returns>
    internal sealed override OpenXmlPart CreatePartCore(string relationshipType)
    {
        this.ThrowIfObjectDisposed();

        if ( relationshipType == null )
        {
            throw new ArgumentNullException("relationshipType");
        }
        switch (relationshipType)
        {
        case CustomXmlPart.RelationshipTypeConstant:
                    return new CustomXmlPart();
            
        case ChartPart.RelationshipTypeConstant:
                    return new ChartPart();        
            
        case DiagramColorsPart.RelationshipTypeConstant:
                    return new DiagramColorsPart();        
            
        case DiagramDataPart.RelationshipTypeConstant:
                    return new DiagramDataPart();        
            
        case DiagramPersistLayoutPart.RelationshipTypeConstant:
                    return new DiagramPersistLayoutPart();        
            
        case DiagramLayoutDefinitionPart.RelationshipTypeConstant:
                    return new DiagramLayoutDefinitionPart();        
            
        case DiagramStylePart.RelationshipTypeConstant:
                    return new DiagramStylePart();        
            
        case EmbeddedObjectPart.RelationshipTypeConstant:
                    return new EmbeddedObjectPart();
            
        case EmbeddedPackagePart.RelationshipTypeConstant:
                    return new EmbeddedPackagePart();
            
        case ImagePart.RelationshipTypeConstant:
                    return new ImagePart();
            
        case VmlDrawingPart.RelationshipTypeConstant:
                    return new VmlDrawingPart();        
            
        case EmbeddedControlPersistenceBinaryDataPart.RelationshipTypeConstant:
                    return new EmbeddedControlPersistenceBinaryDataPart();
            
        case ThemePart.RelationshipTypeConstant:
                    return new ThemePart();        
            
        case UserDefinedTagsPart.RelationshipTypeConstant:
                    return new UserDefinedTagsPart();        
            
        case SlidePart.RelationshipTypeConstant:
                    return new SlidePart();        
            

        }
        throw new ArgumentOutOfRangeException("relationshipType");
    }
    

        /// <summary>
    /// Adds a CustomXmlPart to the HandoutMasterPart.
    /// </summary>
    /// <param name="contentType">the content type of the CustomXmlPart.</param>
    /// <returns>The newly added part.</returns>
    public CustomXmlPart AddCustomXmlPart(string contentType)
    {
        CustomXmlPart childPart = new CustomXmlPart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a CustomXmlPart to the HandoutMasterPart.
    /// </summary>
    /// <param name="partType">The part type of the CustomXmlPart.</param>
    /// <returns>The newly added part.</returns>
     public CustomXmlPart AddCustomXmlPart(CustomXmlPartType partType)
    {
        string contentType = CustomXmlPartTypeInfo.GetContentType(partType);
        string partExtension = CustomXmlPartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddCustomXmlPart(contentType);
    }
    
    /// <summary>
    /// Adds a CustomXmlPart to the HandoutMasterPart.
    /// </summary>
    /// <param name="contentType">the content type of the CustomXmlPart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public CustomXmlPart AddCustomXmlPart(string contentType, string id)
    {
        CustomXmlPart childPart = new CustomXmlPart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a CustomXmlPart to the HandoutMasterPart.
    /// </summary>
    /// <param name="partType">The part type of the CustomXmlPart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public CustomXmlPart AddCustomXmlPart(CustomXmlPartType partType, string id)
    {
        string contentType = CustomXmlPartTypeInfo.GetContentType(partType);
        string partExtension = CustomXmlPartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddCustomXmlPart(contentType, id);
    }
    /// <summary>
    /// Adds a new <see cref="AudioReferenceRelationship"/> to the specified <see cref="MediaDataPart"/>.
    /// </summary>
    /// <param name="mediaDataPart">The specified target <see cref="MediaDataPart"/>.</param>
    /// <returns>The new <see cref="AudioReferenceRelationship"/>.</returns>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="mediaDataPart"/> is null.</exception>
    /// <exception cref="InvalidOperationException">Thrown when the specified <paramref name="mediaDataPart"/> is not in this document.</exception>
    public AudioReferenceRelationship AddAudioReferenceRelationship(MediaDataPart mediaDataPart)
    {
            return AddDataPartReferenceRelationship<AudioReferenceRelationship>(mediaDataPart);
    }
    /// <summary>
    /// Adds a new <see cref="AudioReferenceRelationship"/> to the specified <see cref="MediaDataPart"/>.
    /// </summary>
    /// <param name="mediaDataPart">The specified target <see cref="MediaDataPart"/>.</param>
    /// <param name="id">The desired relationship ID. </param>
    /// <returns>The new <see cref="AudioReferenceRelationship"/>.</returns>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="mediaDataPart"/> is null.</exception>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="id"/> is null.</exception>
    /// <exception cref="InvalidOperationException">Thrown when the specified <paramref name="mediaDataPart"/> is not in this document.</exception>
    public AudioReferenceRelationship AddAudioReferenceRelationship(MediaDataPart mediaDataPart, string id)
    {
            return AddDataPartReferenceRelationship<AudioReferenceRelationship>(mediaDataPart, id);
    }
	/// <summary>
    /// Adds a EmbeddedObjectPart to the HandoutMasterPart.
    /// </summary>
    /// <param name="contentType">The content type of the EmbeddedObjectPart.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedObjectPart AddEmbeddedObjectPart(string contentType)
    {
        EmbeddedObjectPart childPart = new EmbeddedObjectPart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
	/// <summary>
    /// Adds a EmbeddedPackagePart to the HandoutMasterPart.
    /// </summary>
    /// <param name="contentType">The content type of the EmbeddedPackagePart.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedPackagePart AddEmbeddedPackagePart(string contentType)
    {
        EmbeddedPackagePart childPart = new EmbeddedPackagePart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a ImagePart to the HandoutMasterPart.
    /// </summary>
    /// <param name="contentType">the content type of the ImagePart.</param>
    /// <returns>The newly added part.</returns>
    public ImagePart AddImagePart(string contentType)
    {
        ImagePart childPart = new ImagePart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a ImagePart to the HandoutMasterPart.
    /// </summary>
    /// <param name="partType">The part type of the ImagePart.</param>
    /// <returns>The newly added part.</returns>
     public ImagePart AddImagePart(ImagePartType partType)
    {
        string contentType = ImagePartTypeInfo.GetContentType(partType);
        string partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddImagePart(contentType);
    }
    
    /// <summary>
    /// Adds a ImagePart to the HandoutMasterPart.
    /// </summary>
    /// <param name="contentType">the content type of the ImagePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public ImagePart AddImagePart(string contentType, string id)
    {
        ImagePart childPart = new ImagePart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a ImagePart to the HandoutMasterPart.
    /// </summary>
    /// <param name="partType">The part type of the ImagePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public ImagePart AddImagePart(ImagePartType partType, string id)
    {
        string contentType = ImagePartTypeInfo.GetContentType(partType);
        string partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddImagePart(contentType, id);
    }
    /// <summary>
    /// Adds a new <see cref="VideoReferenceRelationship"/> to the specified <see cref="MediaDataPart"/>.
    /// </summary>
    /// <param name="mediaDataPart">The specified target <see cref="MediaDataPart"/>.</param>
    /// <returns>The new <see cref="VideoReferenceRelationship"/>.</returns>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="mediaDataPart"/> is null.</exception>
    /// <exception cref="InvalidOperationException">Thrown when the specified <paramref name="mediaDataPart"/> is not in this document.</exception>
    public VideoReferenceRelationship AddVideoReferenceRelationship(MediaDataPart mediaDataPart)
    {
            return AddDataPartReferenceRelationship<VideoReferenceRelationship>(mediaDataPart);
    }
    /// <summary>
    /// Adds a new <see cref="VideoReferenceRelationship"/> to the specified <see cref="MediaDataPart"/>.
    /// </summary>
    /// <param name="mediaDataPart">The specified target <see cref="MediaDataPart"/>.</param>
    /// <param name="id">The desired relationship ID. </param>
    /// <returns>The new <see cref="VideoReferenceRelationship"/>.</returns>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="mediaDataPart"/> is null.</exception>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="id"/> is null.</exception>
    /// <exception cref="InvalidOperationException">Thrown when the specified <paramref name="mediaDataPart"/> is not in this document.</exception>
    public VideoReferenceRelationship AddVideoReferenceRelationship(MediaDataPart mediaDataPart, string id)
    {
            return AddDataPartReferenceRelationship<VideoReferenceRelationship>(mediaDataPart, id);
    }
    /// <summary>
    /// Adds a EmbeddedControlPersistenceBinaryDataPart to the HandoutMasterPart.
    /// </summary>
    /// <param name="contentType">the content type of the EmbeddedControlPersistenceBinaryDataPart.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedControlPersistenceBinaryDataPart AddEmbeddedControlPersistenceBinaryDataPart(string contentType)
    {
        EmbeddedControlPersistenceBinaryDataPart childPart = new EmbeddedControlPersistenceBinaryDataPart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a EmbeddedControlPersistenceBinaryDataPart to the HandoutMasterPart.
    /// </summary>
    /// <param name="partType">The part type of the EmbeddedControlPersistenceBinaryDataPart.</param>
    /// <returns>The newly added part.</returns>
     public EmbeddedControlPersistenceBinaryDataPart AddEmbeddedControlPersistenceBinaryDataPart(EmbeddedControlPersistenceBinaryDataPartType partType)
    {
        string contentType = EmbeddedControlPersistenceBinaryDataPartTypeInfo.GetContentType(partType);
        string partExtension = EmbeddedControlPersistenceBinaryDataPartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddEmbeddedControlPersistenceBinaryDataPart(contentType);
    }
    
    /// <summary>
    /// Adds a EmbeddedControlPersistenceBinaryDataPart to the HandoutMasterPart.
    /// </summary>
    /// <param name="contentType">the content type of the EmbeddedControlPersistenceBinaryDataPart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedControlPersistenceBinaryDataPart AddEmbeddedControlPersistenceBinaryDataPart(string contentType, string id)
    {
        EmbeddedControlPersistenceBinaryDataPart childPart = new EmbeddedControlPersistenceBinaryDataPart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a EmbeddedControlPersistenceBinaryDataPart to the HandoutMasterPart.
    /// </summary>
    /// <param name="partType">The part type of the EmbeddedControlPersistenceBinaryDataPart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public EmbeddedControlPersistenceBinaryDataPart AddEmbeddedControlPersistenceBinaryDataPart(EmbeddedControlPersistenceBinaryDataPartType partType, string id)
    {
        string contentType = EmbeddedControlPersistenceBinaryDataPartTypeInfo.GetContentType(partType);
        string partExtension = EmbeddedControlPersistenceBinaryDataPartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddEmbeddedControlPersistenceBinaryDataPart(contentType, id);
    }
 
    
    
   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/officeDocument/2006/relationships/handoutMaster";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.openxmlformats-officedocument.presentationml.handoutMaster+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@"handoutMasters";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"handoutMaster";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    

        /// <summary>
        /// Gets the CustomXmlParts of the HandoutMasterPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<CustomXmlPart> CustomXmlParts
        {
            get{
                    return this.GetPartsOfType<CustomXmlPart>();
                }
        }
                
        /// <summary>
        /// Gets the ChartParts of the HandoutMasterPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<ChartPart> ChartParts
        {
            get{
                    return this.GetPartsOfType<ChartPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramColorsParts of the HandoutMasterPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramColorsPart> DiagramColorsParts
        {
            get{
                    return this.GetPartsOfType<DiagramColorsPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramDataParts of the HandoutMasterPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramDataPart> DiagramDataParts
        {
            get{
                    return this.GetPartsOfType<DiagramDataPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramPersistLayoutParts of the HandoutMasterPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramPersistLayoutPart> DiagramPersistLayoutParts
        {
            get{
                    return this.GetPartsOfType<DiagramPersistLayoutPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramLayoutDefinitionParts of the HandoutMasterPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramLayoutDefinitionPart> DiagramLayoutDefinitionParts
        {
            get{
                    return this.GetPartsOfType<DiagramLayoutDefinitionPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramStyleParts of the HandoutMasterPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramStylePart> DiagramStyleParts
        {
            get{
                    return this.GetPartsOfType<DiagramStylePart>();
                }
        }
                
        /// <summary>
        /// Gets the EmbeddedObjectParts of the HandoutMasterPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<EmbeddedObjectPart> EmbeddedObjectParts
        {
            get{
                    return this.GetPartsOfType<EmbeddedObjectPart>();
                }
        }
                
        /// <summary>
        /// Gets the EmbeddedPackageParts of the HandoutMasterPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<EmbeddedPackagePart> EmbeddedPackageParts
        {
            get{
                    return this.GetPartsOfType<EmbeddedPackagePart>();
                }
        }
                
        /// <summary>
        /// Gets the ImageParts of the HandoutMasterPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<ImagePart> ImageParts
        {
            get{
                    return this.GetPartsOfType<ImagePart>();
                }
        }
                
        /// <summary>
        /// Gets the VmlDrawingParts of the HandoutMasterPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<VmlDrawingPart> VmlDrawingParts
        {
            get{
                    return this.GetPartsOfType<VmlDrawingPart>();
                }
        }
                
        /// <summary>
        /// Gets the EmbeddedControlPersistenceBinaryDataParts of the HandoutMasterPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<EmbeddedControlPersistenceBinaryDataPart> EmbeddedControlPersistenceBinaryDataParts
        {
            get{
                    return this.GetPartsOfType<EmbeddedControlPersistenceBinaryDataPart>();
                }
        }
                
        /// <summary>
        /// Gets the ThemePart of the HandoutMasterPart.
        /// </summary>
        public ThemePart ThemePart
        {
            get {return GetSubPartOfType<ThemePart>(); }
        }
        /// <summary>
        /// Gets the UserDefinedTagsParts of the HandoutMasterPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<UserDefinedTagsPart> UserDefinedTagsParts
        {
            get{
                    return this.GetPartsOfType<UserDefinedTagsPart>();
                }
        }
                
        /// <summary>
        /// Gets the SlidePart of the HandoutMasterPart.
        /// </summary>
        public SlidePart SlidePart
        {
            get {return GetSubPartOfType<SlidePart>(); }
        }


    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the NotesMasterPart.
/// </summary>
public partial class NotesMasterPart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/customXml", new PartConstraintRule("CustomXmlPart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/chart", new PartConstraintRule("ChartPart", ChartPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramColors", new PartConstraintRule("DiagramColorsPart", DiagramColorsPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramData", new PartConstraintRule("DiagramDataPart", DiagramDataPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.microsoft.com/office/2007/relationships/diagramDrawing", new PartConstraintRule("DiagramPersistLayoutPart", DiagramPersistLayoutPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramLayout", new PartConstraintRule("DiagramLayoutDefinitionPart", DiagramLayoutDefinitionPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramQuickStyle", new PartConstraintRule("DiagramStylePart", DiagramStylePart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/oleObject", new PartConstraintRule("EmbeddedObjectPart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/package", new PartConstraintRule("EmbeddedPackagePart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/image", new PartConstraintRule("ImagePart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/vmlDrawing", new PartConstraintRule("VmlDrawingPart", VmlDrawingPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.microsoft.com/office/2006/relationships/activeXControlBinary", new PartConstraintRule("EmbeddedControlPersistenceBinaryDataPart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/theme", new PartConstraintRule("ThemePart", ThemePart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/tags", new PartConstraintRule("UserDefinedTagsPart", UserDefinedTagsPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/slide", new PartConstraintRule("SlidePart", SlidePart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));

            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/audio", new PartConstraintRule("AudioReferenceRelationship", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/video", new PartConstraintRule("VideoReferenceRelationship", null, false, true,(FileFormatVersions)7 ));

            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of NotesMasterPart
    /// </summary>
    internal protected NotesMasterPart()
            : base()
    {
    }
    
    
    /// <summary>
    /// Create an instance of OpenXmlPart according to the given relationship type
    /// </summary>
    /// <param name="relationshipType">Relationship type</param>
    /// <returns>An instance of OpenXmlPart</returns>
    internal sealed override OpenXmlPart CreatePartCore(string relationshipType)
    {
        this.ThrowIfObjectDisposed();

        if ( relationshipType == null )
        {
            throw new ArgumentNullException("relationshipType");
        }
        switch (relationshipType)
        {
        case CustomXmlPart.RelationshipTypeConstant:
                    return new CustomXmlPart();
            
        case ChartPart.RelationshipTypeConstant:
                    return new ChartPart();        
            
        case DiagramColorsPart.RelationshipTypeConstant:
                    return new DiagramColorsPart();        
            
        case DiagramDataPart.RelationshipTypeConstant:
                    return new DiagramDataPart();        
            
        case DiagramPersistLayoutPart.RelationshipTypeConstant:
                    return new DiagramPersistLayoutPart();        
            
        case DiagramLayoutDefinitionPart.RelationshipTypeConstant:
                    return new DiagramLayoutDefinitionPart();        
            
        case DiagramStylePart.RelationshipTypeConstant:
                    return new DiagramStylePart();        
            
        case EmbeddedObjectPart.RelationshipTypeConstant:
                    return new EmbeddedObjectPart();
            
        case EmbeddedPackagePart.RelationshipTypeConstant:
                    return new EmbeddedPackagePart();
            
        case ImagePart.RelationshipTypeConstant:
                    return new ImagePart();
            
        case VmlDrawingPart.RelationshipTypeConstant:
                    return new VmlDrawingPart();        
            
        case EmbeddedControlPersistenceBinaryDataPart.RelationshipTypeConstant:
                    return new EmbeddedControlPersistenceBinaryDataPart();
            
        case ThemePart.RelationshipTypeConstant:
                    return new ThemePart();        
            
        case UserDefinedTagsPart.RelationshipTypeConstant:
                    return new UserDefinedTagsPart();        
            
        case SlidePart.RelationshipTypeConstant:
                    return new SlidePart();        
            

        }
        throw new ArgumentOutOfRangeException("relationshipType");
    }
    

        /// <summary>
    /// Adds a CustomXmlPart to the NotesMasterPart.
    /// </summary>
    /// <param name="contentType">the content type of the CustomXmlPart.</param>
    /// <returns>The newly added part.</returns>
    public CustomXmlPart AddCustomXmlPart(string contentType)
    {
        CustomXmlPart childPart = new CustomXmlPart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a CustomXmlPart to the NotesMasterPart.
    /// </summary>
    /// <param name="partType">The part type of the CustomXmlPart.</param>
    /// <returns>The newly added part.</returns>
     public CustomXmlPart AddCustomXmlPart(CustomXmlPartType partType)
    {
        string contentType = CustomXmlPartTypeInfo.GetContentType(partType);
        string partExtension = CustomXmlPartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddCustomXmlPart(contentType);
    }
    
    /// <summary>
    /// Adds a CustomXmlPart to the NotesMasterPart.
    /// </summary>
    /// <param name="contentType">the content type of the CustomXmlPart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public CustomXmlPart AddCustomXmlPart(string contentType, string id)
    {
        CustomXmlPart childPart = new CustomXmlPart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a CustomXmlPart to the NotesMasterPart.
    /// </summary>
    /// <param name="partType">The part type of the CustomXmlPart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public CustomXmlPart AddCustomXmlPart(CustomXmlPartType partType, string id)
    {
        string contentType = CustomXmlPartTypeInfo.GetContentType(partType);
        string partExtension = CustomXmlPartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddCustomXmlPart(contentType, id);
    }
    /// <summary>
    /// Adds a new <see cref="AudioReferenceRelationship"/> to the specified <see cref="MediaDataPart"/>.
    /// </summary>
    /// <param name="mediaDataPart">The specified target <see cref="MediaDataPart"/>.</param>
    /// <returns>The new <see cref="AudioReferenceRelationship"/>.</returns>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="mediaDataPart"/> is null.</exception>
    /// <exception cref="InvalidOperationException">Thrown when the specified <paramref name="mediaDataPart"/> is not in this document.</exception>
    public AudioReferenceRelationship AddAudioReferenceRelationship(MediaDataPart mediaDataPart)
    {
            return AddDataPartReferenceRelationship<AudioReferenceRelationship>(mediaDataPart);
    }
    /// <summary>
    /// Adds a new <see cref="AudioReferenceRelationship"/> to the specified <see cref="MediaDataPart"/>.
    /// </summary>
    /// <param name="mediaDataPart">The specified target <see cref="MediaDataPart"/>.</param>
    /// <param name="id">The desired relationship ID. </param>
    /// <returns>The new <see cref="AudioReferenceRelationship"/>.</returns>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="mediaDataPart"/> is null.</exception>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="id"/> is null.</exception>
    /// <exception cref="InvalidOperationException">Thrown when the specified <paramref name="mediaDataPart"/> is not in this document.</exception>
    public AudioReferenceRelationship AddAudioReferenceRelationship(MediaDataPart mediaDataPart, string id)
    {
            return AddDataPartReferenceRelationship<AudioReferenceRelationship>(mediaDataPart, id);
    }
	/// <summary>
    /// Adds a EmbeddedObjectPart to the NotesMasterPart.
    /// </summary>
    /// <param name="contentType">The content type of the EmbeddedObjectPart.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedObjectPart AddEmbeddedObjectPart(string contentType)
    {
        EmbeddedObjectPart childPart = new EmbeddedObjectPart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
	/// <summary>
    /// Adds a EmbeddedPackagePart to the NotesMasterPart.
    /// </summary>
    /// <param name="contentType">The content type of the EmbeddedPackagePart.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedPackagePart AddEmbeddedPackagePart(string contentType)
    {
        EmbeddedPackagePart childPart = new EmbeddedPackagePart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a ImagePart to the NotesMasterPart.
    /// </summary>
    /// <param name="contentType">the content type of the ImagePart.</param>
    /// <returns>The newly added part.</returns>
    public ImagePart AddImagePart(string contentType)
    {
        ImagePart childPart = new ImagePart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a ImagePart to the NotesMasterPart.
    /// </summary>
    /// <param name="partType">The part type of the ImagePart.</param>
    /// <returns>The newly added part.</returns>
     public ImagePart AddImagePart(ImagePartType partType)
    {
        string contentType = ImagePartTypeInfo.GetContentType(partType);
        string partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddImagePart(contentType);
    }
    
    /// <summary>
    /// Adds a ImagePart to the NotesMasterPart.
    /// </summary>
    /// <param name="contentType">the content type of the ImagePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public ImagePart AddImagePart(string contentType, string id)
    {
        ImagePart childPart = new ImagePart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a ImagePart to the NotesMasterPart.
    /// </summary>
    /// <param name="partType">The part type of the ImagePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public ImagePart AddImagePart(ImagePartType partType, string id)
    {
        string contentType = ImagePartTypeInfo.GetContentType(partType);
        string partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddImagePart(contentType, id);
    }
    /// <summary>
    /// Adds a new <see cref="VideoReferenceRelationship"/> to the specified <see cref="MediaDataPart"/>.
    /// </summary>
    /// <param name="mediaDataPart">The specified target <see cref="MediaDataPart"/>.</param>
    /// <returns>The new <see cref="VideoReferenceRelationship"/>.</returns>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="mediaDataPart"/> is null.</exception>
    /// <exception cref="InvalidOperationException">Thrown when the specified <paramref name="mediaDataPart"/> is not in this document.</exception>
    public VideoReferenceRelationship AddVideoReferenceRelationship(MediaDataPart mediaDataPart)
    {
            return AddDataPartReferenceRelationship<VideoReferenceRelationship>(mediaDataPart);
    }
    /// <summary>
    /// Adds a new <see cref="VideoReferenceRelationship"/> to the specified <see cref="MediaDataPart"/>.
    /// </summary>
    /// <param name="mediaDataPart">The specified target <see cref="MediaDataPart"/>.</param>
    /// <param name="id">The desired relationship ID. </param>
    /// <returns>The new <see cref="VideoReferenceRelationship"/>.</returns>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="mediaDataPart"/> is null.</exception>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="id"/> is null.</exception>
    /// <exception cref="InvalidOperationException">Thrown when the specified <paramref name="mediaDataPart"/> is not in this document.</exception>
    public VideoReferenceRelationship AddVideoReferenceRelationship(MediaDataPart mediaDataPart, string id)
    {
            return AddDataPartReferenceRelationship<VideoReferenceRelationship>(mediaDataPart, id);
    }
    /// <summary>
    /// Adds a EmbeddedControlPersistenceBinaryDataPart to the NotesMasterPart.
    /// </summary>
    /// <param name="contentType">the content type of the EmbeddedControlPersistenceBinaryDataPart.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedControlPersistenceBinaryDataPart AddEmbeddedControlPersistenceBinaryDataPart(string contentType)
    {
        EmbeddedControlPersistenceBinaryDataPart childPart = new EmbeddedControlPersistenceBinaryDataPart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a EmbeddedControlPersistenceBinaryDataPart to the NotesMasterPart.
    /// </summary>
    /// <param name="partType">The part type of the EmbeddedControlPersistenceBinaryDataPart.</param>
    /// <returns>The newly added part.</returns>
     public EmbeddedControlPersistenceBinaryDataPart AddEmbeddedControlPersistenceBinaryDataPart(EmbeddedControlPersistenceBinaryDataPartType partType)
    {
        string contentType = EmbeddedControlPersistenceBinaryDataPartTypeInfo.GetContentType(partType);
        string partExtension = EmbeddedControlPersistenceBinaryDataPartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddEmbeddedControlPersistenceBinaryDataPart(contentType);
    }
    
    /// <summary>
    /// Adds a EmbeddedControlPersistenceBinaryDataPart to the NotesMasterPart.
    /// </summary>
    /// <param name="contentType">the content type of the EmbeddedControlPersistenceBinaryDataPart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedControlPersistenceBinaryDataPart AddEmbeddedControlPersistenceBinaryDataPart(string contentType, string id)
    {
        EmbeddedControlPersistenceBinaryDataPart childPart = new EmbeddedControlPersistenceBinaryDataPart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a EmbeddedControlPersistenceBinaryDataPart to the NotesMasterPart.
    /// </summary>
    /// <param name="partType">The part type of the EmbeddedControlPersistenceBinaryDataPart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public EmbeddedControlPersistenceBinaryDataPart AddEmbeddedControlPersistenceBinaryDataPart(EmbeddedControlPersistenceBinaryDataPartType partType, string id)
    {
        string contentType = EmbeddedControlPersistenceBinaryDataPartTypeInfo.GetContentType(partType);
        string partExtension = EmbeddedControlPersistenceBinaryDataPartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddEmbeddedControlPersistenceBinaryDataPart(contentType, id);
    }
 
    
    
   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/officeDocument/2006/relationships/notesMaster";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.openxmlformats-officedocument.presentationml.notesMaster+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@"notesMasters";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"notesMaster";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    

        /// <summary>
        /// Gets the CustomXmlParts of the NotesMasterPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<CustomXmlPart> CustomXmlParts
        {
            get{
                    return this.GetPartsOfType<CustomXmlPart>();
                }
        }
                
        /// <summary>
        /// Gets the ChartParts of the NotesMasterPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<ChartPart> ChartParts
        {
            get{
                    return this.GetPartsOfType<ChartPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramColorsParts of the NotesMasterPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramColorsPart> DiagramColorsParts
        {
            get{
                    return this.GetPartsOfType<DiagramColorsPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramDataParts of the NotesMasterPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramDataPart> DiagramDataParts
        {
            get{
                    return this.GetPartsOfType<DiagramDataPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramPersistLayoutParts of the NotesMasterPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramPersistLayoutPart> DiagramPersistLayoutParts
        {
            get{
                    return this.GetPartsOfType<DiagramPersistLayoutPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramLayoutDefinitionParts of the NotesMasterPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramLayoutDefinitionPart> DiagramLayoutDefinitionParts
        {
            get{
                    return this.GetPartsOfType<DiagramLayoutDefinitionPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramStyleParts of the NotesMasterPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramStylePart> DiagramStyleParts
        {
            get{
                    return this.GetPartsOfType<DiagramStylePart>();
                }
        }
                
        /// <summary>
        /// Gets the EmbeddedObjectParts of the NotesMasterPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<EmbeddedObjectPart> EmbeddedObjectParts
        {
            get{
                    return this.GetPartsOfType<EmbeddedObjectPart>();
                }
        }
                
        /// <summary>
        /// Gets the EmbeddedPackageParts of the NotesMasterPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<EmbeddedPackagePart> EmbeddedPackageParts
        {
            get{
                    return this.GetPartsOfType<EmbeddedPackagePart>();
                }
        }
                
        /// <summary>
        /// Gets the ImageParts of the NotesMasterPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<ImagePart> ImageParts
        {
            get{
                    return this.GetPartsOfType<ImagePart>();
                }
        }
                
        /// <summary>
        /// Gets the VmlDrawingParts of the NotesMasterPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<VmlDrawingPart> VmlDrawingParts
        {
            get{
                    return this.GetPartsOfType<VmlDrawingPart>();
                }
        }
                
        /// <summary>
        /// Gets the EmbeddedControlPersistenceBinaryDataParts of the NotesMasterPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<EmbeddedControlPersistenceBinaryDataPart> EmbeddedControlPersistenceBinaryDataParts
        {
            get{
                    return this.GetPartsOfType<EmbeddedControlPersistenceBinaryDataPart>();
                }
        }
                
        /// <summary>
        /// Gets the ThemePart of the NotesMasterPart.
        /// </summary>
        public ThemePart ThemePart
        {
            get {return GetSubPartOfType<ThemePart>(); }
        }
        /// <summary>
        /// Gets the UserDefinedTagsParts of the NotesMasterPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<UserDefinedTagsPart> UserDefinedTagsParts
        {
            get{
                    return this.GetPartsOfType<UserDefinedTagsPart>();
                }
        }
                
        /// <summary>
        /// Gets the SlidePart of the NotesMasterPart.
        /// </summary>
        public SlidePart SlidePart
        {
            get {return GetSubPartOfType<SlidePart>(); }
        }


    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the NotesSlidePart.
/// </summary>
public partial class NotesSlidePart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/customXml", new PartConstraintRule("CustomXmlPart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/chart", new PartConstraintRule("ChartPart", ChartPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramColors", new PartConstraintRule("DiagramColorsPart", DiagramColorsPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramData", new PartConstraintRule("DiagramDataPart", DiagramDataPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.microsoft.com/office/2007/relationships/diagramDrawing", new PartConstraintRule("DiagramPersistLayoutPart", DiagramPersistLayoutPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramLayout", new PartConstraintRule("DiagramLayoutDefinitionPart", DiagramLayoutDefinitionPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramQuickStyle", new PartConstraintRule("DiagramStylePart", DiagramStylePart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/oleObject", new PartConstraintRule("EmbeddedObjectPart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/package", new PartConstraintRule("EmbeddedPackagePart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/image", new PartConstraintRule("ImagePart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/vmlDrawing", new PartConstraintRule("VmlDrawingPart", VmlDrawingPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.microsoft.com/office/2006/relationships/activeXControlBinary", new PartConstraintRule("EmbeddedControlPersistenceBinaryDataPart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/notesMaster", new PartConstraintRule("NotesMasterPart", NotesMasterPart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/themeOverride", new PartConstraintRule("ThemeOverridePart", ThemeOverridePart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/slide", new PartConstraintRule("SlidePart", SlidePart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/tags", new PartConstraintRule("UserDefinedTagsPart", UserDefinedTagsPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));

            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/audio", new PartConstraintRule("AudioReferenceRelationship", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/video", new PartConstraintRule("VideoReferenceRelationship", null, false, true,(FileFormatVersions)7 ));

            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of NotesSlidePart
    /// </summary>
    internal protected NotesSlidePart()
            : base()
    {
    }
    
    
    /// <summary>
    /// Create an instance of OpenXmlPart according to the given relationship type
    /// </summary>
    /// <param name="relationshipType">Relationship type</param>
    /// <returns>An instance of OpenXmlPart</returns>
    internal sealed override OpenXmlPart CreatePartCore(string relationshipType)
    {
        this.ThrowIfObjectDisposed();

        if ( relationshipType == null )
        {
            throw new ArgumentNullException("relationshipType");
        }
        switch (relationshipType)
        {
        case CustomXmlPart.RelationshipTypeConstant:
                    return new CustomXmlPart();
            
        case ChartPart.RelationshipTypeConstant:
                    return new ChartPart();        
            
        case DiagramColorsPart.RelationshipTypeConstant:
                    return new DiagramColorsPart();        
            
        case DiagramDataPart.RelationshipTypeConstant:
                    return new DiagramDataPart();        
            
        case DiagramPersistLayoutPart.RelationshipTypeConstant:
                    return new DiagramPersistLayoutPart();        
            
        case DiagramLayoutDefinitionPart.RelationshipTypeConstant:
                    return new DiagramLayoutDefinitionPart();        
            
        case DiagramStylePart.RelationshipTypeConstant:
                    return new DiagramStylePart();        
            
        case EmbeddedObjectPart.RelationshipTypeConstant:
                    return new EmbeddedObjectPart();
            
        case EmbeddedPackagePart.RelationshipTypeConstant:
                    return new EmbeddedPackagePart();
            
        case ImagePart.RelationshipTypeConstant:
                    return new ImagePart();
            
        case VmlDrawingPart.RelationshipTypeConstant:
                    return new VmlDrawingPart();        
            
        case EmbeddedControlPersistenceBinaryDataPart.RelationshipTypeConstant:
                    return new EmbeddedControlPersistenceBinaryDataPart();
            
        case NotesMasterPart.RelationshipTypeConstant:
                    return new NotesMasterPart();        
            
        case ThemeOverridePart.RelationshipTypeConstant:
                    return new ThemeOverridePart();        
            
        case SlidePart.RelationshipTypeConstant:
                    return new SlidePart();        
            
        case UserDefinedTagsPart.RelationshipTypeConstant:
                    return new UserDefinedTagsPart();        
            

        }
        throw new ArgumentOutOfRangeException("relationshipType");
    }
    

        /// <summary>
    /// Adds a CustomXmlPart to the NotesSlidePart.
    /// </summary>
    /// <param name="contentType">the content type of the CustomXmlPart.</param>
    /// <returns>The newly added part.</returns>
    public CustomXmlPart AddCustomXmlPart(string contentType)
    {
        CustomXmlPart childPart = new CustomXmlPart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a CustomXmlPart to the NotesSlidePart.
    /// </summary>
    /// <param name="partType">The part type of the CustomXmlPart.</param>
    /// <returns>The newly added part.</returns>
     public CustomXmlPart AddCustomXmlPart(CustomXmlPartType partType)
    {
        string contentType = CustomXmlPartTypeInfo.GetContentType(partType);
        string partExtension = CustomXmlPartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddCustomXmlPart(contentType);
    }
    
    /// <summary>
    /// Adds a CustomXmlPart to the NotesSlidePart.
    /// </summary>
    /// <param name="contentType">the content type of the CustomXmlPart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public CustomXmlPart AddCustomXmlPart(string contentType, string id)
    {
        CustomXmlPart childPart = new CustomXmlPart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a CustomXmlPart to the NotesSlidePart.
    /// </summary>
    /// <param name="partType">The part type of the CustomXmlPart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public CustomXmlPart AddCustomXmlPart(CustomXmlPartType partType, string id)
    {
        string contentType = CustomXmlPartTypeInfo.GetContentType(partType);
        string partExtension = CustomXmlPartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddCustomXmlPart(contentType, id);
    }
    /// <summary>
    /// Adds a new <see cref="AudioReferenceRelationship"/> to the specified <see cref="MediaDataPart"/>.
    /// </summary>
    /// <param name="mediaDataPart">The specified target <see cref="MediaDataPart"/>.</param>
    /// <returns>The new <see cref="AudioReferenceRelationship"/>.</returns>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="mediaDataPart"/> is null.</exception>
    /// <exception cref="InvalidOperationException">Thrown when the specified <paramref name="mediaDataPart"/> is not in this document.</exception>
    public AudioReferenceRelationship AddAudioReferenceRelationship(MediaDataPart mediaDataPart)
    {
            return AddDataPartReferenceRelationship<AudioReferenceRelationship>(mediaDataPart);
    }
    /// <summary>
    /// Adds a new <see cref="AudioReferenceRelationship"/> to the specified <see cref="MediaDataPart"/>.
    /// </summary>
    /// <param name="mediaDataPart">The specified target <see cref="MediaDataPart"/>.</param>
    /// <param name="id">The desired relationship ID. </param>
    /// <returns>The new <see cref="AudioReferenceRelationship"/>.</returns>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="mediaDataPart"/> is null.</exception>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="id"/> is null.</exception>
    /// <exception cref="InvalidOperationException">Thrown when the specified <paramref name="mediaDataPart"/> is not in this document.</exception>
    public AudioReferenceRelationship AddAudioReferenceRelationship(MediaDataPart mediaDataPart, string id)
    {
            return AddDataPartReferenceRelationship<AudioReferenceRelationship>(mediaDataPart, id);
    }
	/// <summary>
    /// Adds a EmbeddedObjectPart to the NotesSlidePart.
    /// </summary>
    /// <param name="contentType">The content type of the EmbeddedObjectPart.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedObjectPart AddEmbeddedObjectPart(string contentType)
    {
        EmbeddedObjectPart childPart = new EmbeddedObjectPart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
	/// <summary>
    /// Adds a EmbeddedPackagePart to the NotesSlidePart.
    /// </summary>
    /// <param name="contentType">The content type of the EmbeddedPackagePart.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedPackagePart AddEmbeddedPackagePart(string contentType)
    {
        EmbeddedPackagePart childPart = new EmbeddedPackagePart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a ImagePart to the NotesSlidePart.
    /// </summary>
    /// <param name="contentType">the content type of the ImagePart.</param>
    /// <returns>The newly added part.</returns>
    public ImagePart AddImagePart(string contentType)
    {
        ImagePart childPart = new ImagePart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a ImagePart to the NotesSlidePart.
    /// </summary>
    /// <param name="partType">The part type of the ImagePart.</param>
    /// <returns>The newly added part.</returns>
     public ImagePart AddImagePart(ImagePartType partType)
    {
        string contentType = ImagePartTypeInfo.GetContentType(partType);
        string partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddImagePart(contentType);
    }
    
    /// <summary>
    /// Adds a ImagePart to the NotesSlidePart.
    /// </summary>
    /// <param name="contentType">the content type of the ImagePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public ImagePart AddImagePart(string contentType, string id)
    {
        ImagePart childPart = new ImagePart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a ImagePart to the NotesSlidePart.
    /// </summary>
    /// <param name="partType">The part type of the ImagePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public ImagePart AddImagePart(ImagePartType partType, string id)
    {
        string contentType = ImagePartTypeInfo.GetContentType(partType);
        string partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddImagePart(contentType, id);
    }
    /// <summary>
    /// Adds a new <see cref="VideoReferenceRelationship"/> to the specified <see cref="MediaDataPart"/>.
    /// </summary>
    /// <param name="mediaDataPart">The specified target <see cref="MediaDataPart"/>.</param>
    /// <returns>The new <see cref="VideoReferenceRelationship"/>.</returns>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="mediaDataPart"/> is null.</exception>
    /// <exception cref="InvalidOperationException">Thrown when the specified <paramref name="mediaDataPart"/> is not in this document.</exception>
    public VideoReferenceRelationship AddVideoReferenceRelationship(MediaDataPart mediaDataPart)
    {
            return AddDataPartReferenceRelationship<VideoReferenceRelationship>(mediaDataPart);
    }
    /// <summary>
    /// Adds a new <see cref="VideoReferenceRelationship"/> to the specified <see cref="MediaDataPart"/>.
    /// </summary>
    /// <param name="mediaDataPart">The specified target <see cref="MediaDataPart"/>.</param>
    /// <param name="id">The desired relationship ID. </param>
    /// <returns>The new <see cref="VideoReferenceRelationship"/>.</returns>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="mediaDataPart"/> is null.</exception>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="id"/> is null.</exception>
    /// <exception cref="InvalidOperationException">Thrown when the specified <paramref name="mediaDataPart"/> is not in this document.</exception>
    public VideoReferenceRelationship AddVideoReferenceRelationship(MediaDataPart mediaDataPart, string id)
    {
            return AddDataPartReferenceRelationship<VideoReferenceRelationship>(mediaDataPart, id);
    }
    /// <summary>
    /// Adds a EmbeddedControlPersistenceBinaryDataPart to the NotesSlidePart.
    /// </summary>
    /// <param name="contentType">the content type of the EmbeddedControlPersistenceBinaryDataPart.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedControlPersistenceBinaryDataPart AddEmbeddedControlPersistenceBinaryDataPart(string contentType)
    {
        EmbeddedControlPersistenceBinaryDataPart childPart = new EmbeddedControlPersistenceBinaryDataPart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a EmbeddedControlPersistenceBinaryDataPart to the NotesSlidePart.
    /// </summary>
    /// <param name="partType">The part type of the EmbeddedControlPersistenceBinaryDataPart.</param>
    /// <returns>The newly added part.</returns>
     public EmbeddedControlPersistenceBinaryDataPart AddEmbeddedControlPersistenceBinaryDataPart(EmbeddedControlPersistenceBinaryDataPartType partType)
    {
        string contentType = EmbeddedControlPersistenceBinaryDataPartTypeInfo.GetContentType(partType);
        string partExtension = EmbeddedControlPersistenceBinaryDataPartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddEmbeddedControlPersistenceBinaryDataPart(contentType);
    }
    
    /// <summary>
    /// Adds a EmbeddedControlPersistenceBinaryDataPart to the NotesSlidePart.
    /// </summary>
    /// <param name="contentType">the content type of the EmbeddedControlPersistenceBinaryDataPart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedControlPersistenceBinaryDataPart AddEmbeddedControlPersistenceBinaryDataPart(string contentType, string id)
    {
        EmbeddedControlPersistenceBinaryDataPart childPart = new EmbeddedControlPersistenceBinaryDataPart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a EmbeddedControlPersistenceBinaryDataPart to the NotesSlidePart.
    /// </summary>
    /// <param name="partType">The part type of the EmbeddedControlPersistenceBinaryDataPart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public EmbeddedControlPersistenceBinaryDataPart AddEmbeddedControlPersistenceBinaryDataPart(EmbeddedControlPersistenceBinaryDataPartType partType, string id)
    {
        string contentType = EmbeddedControlPersistenceBinaryDataPartTypeInfo.GetContentType(partType);
        string partExtension = EmbeddedControlPersistenceBinaryDataPartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddEmbeddedControlPersistenceBinaryDataPart(contentType, id);
    }
 
    
    
   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/officeDocument/2006/relationships/notesSlide";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.openxmlformats-officedocument.presentationml.notesSlide+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@"../notesSlides";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"notesSlide";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    

        /// <summary>
        /// Gets the CustomXmlParts of the NotesSlidePart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<CustomXmlPart> CustomXmlParts
        {
            get{
                    return this.GetPartsOfType<CustomXmlPart>();
                }
        }
                
        /// <summary>
        /// Gets the ChartParts of the NotesSlidePart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<ChartPart> ChartParts
        {
            get{
                    return this.GetPartsOfType<ChartPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramColorsParts of the NotesSlidePart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramColorsPart> DiagramColorsParts
        {
            get{
                    return this.GetPartsOfType<DiagramColorsPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramDataParts of the NotesSlidePart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramDataPart> DiagramDataParts
        {
            get{
                    return this.GetPartsOfType<DiagramDataPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramPersistLayoutParts of the NotesSlidePart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramPersistLayoutPart> DiagramPersistLayoutParts
        {
            get{
                    return this.GetPartsOfType<DiagramPersistLayoutPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramLayoutDefinitionParts of the NotesSlidePart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramLayoutDefinitionPart> DiagramLayoutDefinitionParts
        {
            get{
                    return this.GetPartsOfType<DiagramLayoutDefinitionPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramStyleParts of the NotesSlidePart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramStylePart> DiagramStyleParts
        {
            get{
                    return this.GetPartsOfType<DiagramStylePart>();
                }
        }
                
        /// <summary>
        /// Gets the EmbeddedObjectParts of the NotesSlidePart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<EmbeddedObjectPart> EmbeddedObjectParts
        {
            get{
                    return this.GetPartsOfType<EmbeddedObjectPart>();
                }
        }
                
        /// <summary>
        /// Gets the EmbeddedPackageParts of the NotesSlidePart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<EmbeddedPackagePart> EmbeddedPackageParts
        {
            get{
                    return this.GetPartsOfType<EmbeddedPackagePart>();
                }
        }
                
        /// <summary>
        /// Gets the ImageParts of the NotesSlidePart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<ImagePart> ImageParts
        {
            get{
                    return this.GetPartsOfType<ImagePart>();
                }
        }
                
        /// <summary>
        /// Gets the VmlDrawingParts of the NotesSlidePart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<VmlDrawingPart> VmlDrawingParts
        {
            get{
                    return this.GetPartsOfType<VmlDrawingPart>();
                }
        }
                
        /// <summary>
        /// Gets the EmbeddedControlPersistenceBinaryDataParts of the NotesSlidePart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<EmbeddedControlPersistenceBinaryDataPart> EmbeddedControlPersistenceBinaryDataParts
        {
            get{
                    return this.GetPartsOfType<EmbeddedControlPersistenceBinaryDataPart>();
                }
        }
                
        /// <summary>
        /// Gets the NotesMasterPart of the NotesSlidePart.
        /// </summary>
        public NotesMasterPart NotesMasterPart
        {
            get {return GetSubPartOfType<NotesMasterPart>(); }
        }
        /// <summary>
        /// Gets the ThemeOverridePart of the NotesSlidePart.
        /// </summary>
        public ThemeOverridePart ThemeOverridePart
        {
            get {return GetSubPartOfType<ThemeOverridePart>(); }
        }
        /// <summary>
        /// Gets the SlidePart of the NotesSlidePart.
        /// </summary>
        public SlidePart SlidePart
        {
            get {return GetSubPartOfType<SlidePart>(); }
        }
        /// <summary>
        /// Gets the UserDefinedTagsParts of the NotesSlidePart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<UserDefinedTagsPart> UserDefinedTagsParts
        {
            get{
                    return this.GetPartsOfType<UserDefinedTagsPart>();
                }
        }
                


    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the PresentationPropertiesPart.
/// </summary>
public partial class PresentationPropertiesPart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of PresentationPropertiesPart
    /// </summary>
    internal protected PresentationPropertiesPart()
            : base()
    {
    }
    
    

   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/officeDocument/2006/relationships/presProps";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.openxmlformats-officedocument.presentationml.presProps+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@".";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"presProps";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    



    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the SlidePart.
/// </summary>
public partial class SlidePart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/customXml", new PartConstraintRule("CustomXmlPart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/chart", new PartConstraintRule("ChartPart", ChartPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramColors", new PartConstraintRule("DiagramColorsPart", DiagramColorsPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramData", new PartConstraintRule("DiagramDataPart", DiagramDataPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.microsoft.com/office/2007/relationships/diagramDrawing", new PartConstraintRule("DiagramPersistLayoutPart", DiagramPersistLayoutPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramLayout", new PartConstraintRule("DiagramLayoutDefinitionPart", DiagramLayoutDefinitionPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramQuickStyle", new PartConstraintRule("DiagramStylePart", DiagramStylePart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/oleObject", new PartConstraintRule("EmbeddedObjectPart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/package", new PartConstraintRule("EmbeddedPackagePart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/image", new PartConstraintRule("ImagePart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/vmlDrawing", new PartConstraintRule("VmlDrawingPart", VmlDrawingPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.microsoft.com/office/2006/relationships/activeXControlBinary", new PartConstraintRule("EmbeddedControlPersistenceBinaryDataPart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/comments", new PartConstraintRule("SlideCommentsPart", SlideCommentsPart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/notesSlide", new PartConstraintRule("NotesSlidePart", NotesSlidePart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/themeOverride", new PartConstraintRule("ThemeOverridePart", ThemeOverridePart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/slideLayout", new PartConstraintRule("SlideLayoutPart", SlideLayoutPart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/slideUpdateInfo", new PartConstraintRule("SlideSyncDataPart", SlideSyncDataPart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/tags", new PartConstraintRule("UserDefinedTagsPart", UserDefinedTagsPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/slide", new PartConstraintRule("SlidePart", SlidePart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/control", new PartConstraintRule("EmbeddedControlPersistencePart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.microsoft.com/office/2011/relationships/webextension", new PartConstraintRule("WebExtensionPart", WebExtensionPart.ContentTypeConstant, false, true,(FileFormatVersions)4 ));

            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/audio", new PartConstraintRule("AudioReferenceRelationship", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/video", new PartConstraintRule("VideoReferenceRelationship", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.microsoft.com/office/2007/relationships/media", new PartConstraintRule("MediaReferenceRelationship", null, false, true,(FileFormatVersions)7 ));

            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of SlidePart
    /// </summary>
    internal protected SlidePart()
            : base()
    {
    }
    
    
    /// <summary>
    /// Create an instance of OpenXmlPart according to the given relationship type
    /// </summary>
    /// <param name="relationshipType">Relationship type</param>
    /// <returns>An instance of OpenXmlPart</returns>
    internal sealed override OpenXmlPart CreatePartCore(string relationshipType)
    {
        this.ThrowIfObjectDisposed();

        if ( relationshipType == null )
        {
            throw new ArgumentNullException("relationshipType");
        }
        switch (relationshipType)
        {
        case CustomXmlPart.RelationshipTypeConstant:
                    return new CustomXmlPart();
            
        case ChartPart.RelationshipTypeConstant:
                    return new ChartPart();        
            
        case DiagramColorsPart.RelationshipTypeConstant:
                    return new DiagramColorsPart();        
            
        case DiagramDataPart.RelationshipTypeConstant:
                    return new DiagramDataPart();        
            
        case DiagramPersistLayoutPart.RelationshipTypeConstant:
                    return new DiagramPersistLayoutPart();        
            
        case DiagramLayoutDefinitionPart.RelationshipTypeConstant:
                    return new DiagramLayoutDefinitionPart();        
            
        case DiagramStylePart.RelationshipTypeConstant:
                    return new DiagramStylePart();        
            
        case EmbeddedObjectPart.RelationshipTypeConstant:
                    return new EmbeddedObjectPart();
            
        case EmbeddedPackagePart.RelationshipTypeConstant:
                    return new EmbeddedPackagePart();
            
        case ImagePart.RelationshipTypeConstant:
                    return new ImagePart();
            
        case VmlDrawingPart.RelationshipTypeConstant:
                    return new VmlDrawingPart();        
            
        case EmbeddedControlPersistenceBinaryDataPart.RelationshipTypeConstant:
                    return new EmbeddedControlPersistenceBinaryDataPart();
            
        case SlideCommentsPart.RelationshipTypeConstant:
                    return new SlideCommentsPart();        
            
        case NotesSlidePart.RelationshipTypeConstant:
                    return new NotesSlidePart();        
            
        case ThemeOverridePart.RelationshipTypeConstant:
                    return new ThemeOverridePart();        
            
        case SlideLayoutPart.RelationshipTypeConstant:
                    return new SlideLayoutPart();        
            
        case SlideSyncDataPart.RelationshipTypeConstant:
                    return new SlideSyncDataPart();        
            
        case UserDefinedTagsPart.RelationshipTypeConstant:
                    return new UserDefinedTagsPart();        
            
        case SlidePart.RelationshipTypeConstant:
                    return new SlidePart();        
            
        case EmbeddedControlPersistencePart.RelationshipTypeConstant:
                    return new EmbeddedControlPersistencePart();
            
        case WebExtensionPart.RelationshipTypeConstant:
                    return new WebExtensionPart();        
            

        }
        throw new ArgumentOutOfRangeException("relationshipType");
    }
    

        /// <summary>
    /// Adds a CustomXmlPart to the SlidePart.
    /// </summary>
    /// <param name="contentType">the content type of the CustomXmlPart.</param>
    /// <returns>The newly added part.</returns>
    public CustomXmlPart AddCustomXmlPart(string contentType)
    {
        CustomXmlPart childPart = new CustomXmlPart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a CustomXmlPart to the SlidePart.
    /// </summary>
    /// <param name="partType">The part type of the CustomXmlPart.</param>
    /// <returns>The newly added part.</returns>
     public CustomXmlPart AddCustomXmlPart(CustomXmlPartType partType)
    {
        string contentType = CustomXmlPartTypeInfo.GetContentType(partType);
        string partExtension = CustomXmlPartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddCustomXmlPart(contentType);
    }
    
    /// <summary>
    /// Adds a CustomXmlPart to the SlidePart.
    /// </summary>
    /// <param name="contentType">the content type of the CustomXmlPart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public CustomXmlPart AddCustomXmlPart(string contentType, string id)
    {
        CustomXmlPart childPart = new CustomXmlPart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a CustomXmlPart to the SlidePart.
    /// </summary>
    /// <param name="partType">The part type of the CustomXmlPart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public CustomXmlPart AddCustomXmlPart(CustomXmlPartType partType, string id)
    {
        string contentType = CustomXmlPartTypeInfo.GetContentType(partType);
        string partExtension = CustomXmlPartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddCustomXmlPart(contentType, id);
    }
    /// <summary>
    /// Adds a new <see cref="AudioReferenceRelationship"/> to the specified <see cref="MediaDataPart"/>.
    /// </summary>
    /// <param name="mediaDataPart">The specified target <see cref="MediaDataPart"/>.</param>
    /// <returns>The new <see cref="AudioReferenceRelationship"/>.</returns>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="mediaDataPart"/> is null.</exception>
    /// <exception cref="InvalidOperationException">Thrown when the specified <paramref name="mediaDataPart"/> is not in this document.</exception>
    public AudioReferenceRelationship AddAudioReferenceRelationship(MediaDataPart mediaDataPart)
    {
            return AddDataPartReferenceRelationship<AudioReferenceRelationship>(mediaDataPart);
    }
    /// <summary>
    /// Adds a new <see cref="AudioReferenceRelationship"/> to the specified <see cref="MediaDataPart"/>.
    /// </summary>
    /// <param name="mediaDataPart">The specified target <see cref="MediaDataPart"/>.</param>
    /// <param name="id">The desired relationship ID. </param>
    /// <returns>The new <see cref="AudioReferenceRelationship"/>.</returns>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="mediaDataPart"/> is null.</exception>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="id"/> is null.</exception>
    /// <exception cref="InvalidOperationException">Thrown when the specified <paramref name="mediaDataPart"/> is not in this document.</exception>
    public AudioReferenceRelationship AddAudioReferenceRelationship(MediaDataPart mediaDataPart, string id)
    {
            return AddDataPartReferenceRelationship<AudioReferenceRelationship>(mediaDataPart, id);
    }
	/// <summary>
    /// Adds a EmbeddedObjectPart to the SlidePart.
    /// </summary>
    /// <param name="contentType">The content type of the EmbeddedObjectPart.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedObjectPart AddEmbeddedObjectPart(string contentType)
    {
        EmbeddedObjectPart childPart = new EmbeddedObjectPart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
	/// <summary>
    /// Adds a EmbeddedPackagePart to the SlidePart.
    /// </summary>
    /// <param name="contentType">The content type of the EmbeddedPackagePart.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedPackagePart AddEmbeddedPackagePart(string contentType)
    {
        EmbeddedPackagePart childPart = new EmbeddedPackagePart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a ImagePart to the SlidePart.
    /// </summary>
    /// <param name="contentType">the content type of the ImagePart.</param>
    /// <returns>The newly added part.</returns>
    public ImagePart AddImagePart(string contentType)
    {
        ImagePart childPart = new ImagePart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a ImagePart to the SlidePart.
    /// </summary>
    /// <param name="partType">The part type of the ImagePart.</param>
    /// <returns>The newly added part.</returns>
     public ImagePart AddImagePart(ImagePartType partType)
    {
        string contentType = ImagePartTypeInfo.GetContentType(partType);
        string partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddImagePart(contentType);
    }
    
    /// <summary>
    /// Adds a ImagePart to the SlidePart.
    /// </summary>
    /// <param name="contentType">the content type of the ImagePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public ImagePart AddImagePart(string contentType, string id)
    {
        ImagePart childPart = new ImagePart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a ImagePart to the SlidePart.
    /// </summary>
    /// <param name="partType">The part type of the ImagePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public ImagePart AddImagePart(ImagePartType partType, string id)
    {
        string contentType = ImagePartTypeInfo.GetContentType(partType);
        string partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddImagePart(contentType, id);
    }
    /// <summary>
    /// Adds a new <see cref="VideoReferenceRelationship"/> to the specified <see cref="MediaDataPart"/>.
    /// </summary>
    /// <param name="mediaDataPart">The specified target <see cref="MediaDataPart"/>.</param>
    /// <returns>The new <see cref="VideoReferenceRelationship"/>.</returns>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="mediaDataPart"/> is null.</exception>
    /// <exception cref="InvalidOperationException">Thrown when the specified <paramref name="mediaDataPart"/> is not in this document.</exception>
    public VideoReferenceRelationship AddVideoReferenceRelationship(MediaDataPart mediaDataPart)
    {
            return AddDataPartReferenceRelationship<VideoReferenceRelationship>(mediaDataPart);
    }
    /// <summary>
    /// Adds a new <see cref="VideoReferenceRelationship"/> to the specified <see cref="MediaDataPart"/>.
    /// </summary>
    /// <param name="mediaDataPart">The specified target <see cref="MediaDataPart"/>.</param>
    /// <param name="id">The desired relationship ID. </param>
    /// <returns>The new <see cref="VideoReferenceRelationship"/>.</returns>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="mediaDataPart"/> is null.</exception>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="id"/> is null.</exception>
    /// <exception cref="InvalidOperationException">Thrown when the specified <paramref name="mediaDataPart"/> is not in this document.</exception>
    public VideoReferenceRelationship AddVideoReferenceRelationship(MediaDataPart mediaDataPart, string id)
    {
            return AddDataPartReferenceRelationship<VideoReferenceRelationship>(mediaDataPart, id);
    }
    /// <summary>
    /// Adds a EmbeddedControlPersistenceBinaryDataPart to the SlidePart.
    /// </summary>
    /// <param name="contentType">the content type of the EmbeddedControlPersistenceBinaryDataPart.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedControlPersistenceBinaryDataPart AddEmbeddedControlPersistenceBinaryDataPart(string contentType)
    {
        EmbeddedControlPersistenceBinaryDataPart childPart = new EmbeddedControlPersistenceBinaryDataPart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a EmbeddedControlPersistenceBinaryDataPart to the SlidePart.
    /// </summary>
    /// <param name="partType">The part type of the EmbeddedControlPersistenceBinaryDataPart.</param>
    /// <returns>The newly added part.</returns>
     public EmbeddedControlPersistenceBinaryDataPart AddEmbeddedControlPersistenceBinaryDataPart(EmbeddedControlPersistenceBinaryDataPartType partType)
    {
        string contentType = EmbeddedControlPersistenceBinaryDataPartTypeInfo.GetContentType(partType);
        string partExtension = EmbeddedControlPersistenceBinaryDataPartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddEmbeddedControlPersistenceBinaryDataPart(contentType);
    }
    
    /// <summary>
    /// Adds a EmbeddedControlPersistenceBinaryDataPart to the SlidePart.
    /// </summary>
    /// <param name="contentType">the content type of the EmbeddedControlPersistenceBinaryDataPart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedControlPersistenceBinaryDataPart AddEmbeddedControlPersistenceBinaryDataPart(string contentType, string id)
    {
        EmbeddedControlPersistenceBinaryDataPart childPart = new EmbeddedControlPersistenceBinaryDataPart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a EmbeddedControlPersistenceBinaryDataPart to the SlidePart.
    /// </summary>
    /// <param name="partType">The part type of the EmbeddedControlPersistenceBinaryDataPart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public EmbeddedControlPersistenceBinaryDataPart AddEmbeddedControlPersistenceBinaryDataPart(EmbeddedControlPersistenceBinaryDataPartType partType, string id)
    {
        string contentType = EmbeddedControlPersistenceBinaryDataPartTypeInfo.GetContentType(partType);
        string partExtension = EmbeddedControlPersistenceBinaryDataPartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddEmbeddedControlPersistenceBinaryDataPart(contentType, id);
    }
    /// <summary>
    /// Adds a EmbeddedControlPersistencePart to the SlidePart.
    /// </summary>
    /// <param name="contentType">the content type of the EmbeddedControlPersistencePart.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(string contentType)
    {
        EmbeddedControlPersistencePart childPart = new EmbeddedControlPersistencePart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a EmbeddedControlPersistencePart to the SlidePart.
    /// </summary>
    /// <param name="partType">The part type of the EmbeddedControlPersistencePart.</param>
    /// <returns>The newly added part.</returns>
     public EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(EmbeddedControlPersistencePartType partType)
    {
        string contentType = EmbeddedControlPersistencePartTypeInfo.GetContentType(partType);
        string partExtension = EmbeddedControlPersistencePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddEmbeddedControlPersistencePart(contentType);
    }
    
    /// <summary>
    /// Adds a EmbeddedControlPersistencePart to the SlidePart.
    /// </summary>
    /// <param name="contentType">the content type of the EmbeddedControlPersistencePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(string contentType, string id)
    {
        EmbeddedControlPersistencePart childPart = new EmbeddedControlPersistencePart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a EmbeddedControlPersistencePart to the SlidePart.
    /// </summary>
    /// <param name="partType">The part type of the EmbeddedControlPersistencePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(EmbeddedControlPersistencePartType partType, string id)
    {
        string contentType = EmbeddedControlPersistencePartTypeInfo.GetContentType(partType);
        string partExtension = EmbeddedControlPersistencePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddEmbeddedControlPersistencePart(contentType, id);
    }
    /// <summary>
    /// Adds a new <see cref="MediaReferenceRelationship"/> to the specified <see cref="MediaDataPart"/>.
    /// </summary>
    /// <param name="mediaDataPart">The specified target <see cref="MediaDataPart"/>.</param>
    /// <returns>The new <see cref="MediaReferenceRelationship"/>.</returns>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="mediaDataPart"/> is null.</exception>
    /// <exception cref="InvalidOperationException">Thrown when the specified <paramref name="mediaDataPart"/> is not in this document.</exception>
    public MediaReferenceRelationship AddMediaReferenceRelationship(MediaDataPart mediaDataPart)
    {
            return AddDataPartReferenceRelationship<MediaReferenceRelationship>(mediaDataPart);
    }
    /// <summary>
    /// Adds a new <see cref="MediaReferenceRelationship"/> to the specified <see cref="MediaDataPart"/>.
    /// </summary>
    /// <param name="mediaDataPart">The specified target <see cref="MediaDataPart"/>.</param>
    /// <param name="id">The desired relationship ID. </param>
    /// <returns>The new <see cref="MediaReferenceRelationship"/>.</returns>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="mediaDataPart"/> is null.</exception>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="id"/> is null.</exception>
    /// <exception cref="InvalidOperationException">Thrown when the specified <paramref name="mediaDataPart"/> is not in this document.</exception>
    public MediaReferenceRelationship AddMediaReferenceRelationship(MediaDataPart mediaDataPart, string id)
    {
            return AddDataPartReferenceRelationship<MediaReferenceRelationship>(mediaDataPart, id);
    }
 
    
    
   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/officeDocument/2006/relationships/slide";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.openxmlformats-officedocument.presentationml.slide+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@"slides";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"slide";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    

        /// <summary>
        /// Gets the CustomXmlParts of the SlidePart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<CustomXmlPart> CustomXmlParts
        {
            get{
                    return this.GetPartsOfType<CustomXmlPart>();
                }
        }
                
        /// <summary>
        /// Gets the ChartParts of the SlidePart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<ChartPart> ChartParts
        {
            get{
                    return this.GetPartsOfType<ChartPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramColorsParts of the SlidePart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramColorsPart> DiagramColorsParts
        {
            get{
                    return this.GetPartsOfType<DiagramColorsPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramDataParts of the SlidePart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramDataPart> DiagramDataParts
        {
            get{
                    return this.GetPartsOfType<DiagramDataPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramPersistLayoutParts of the SlidePart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramPersistLayoutPart> DiagramPersistLayoutParts
        {
            get{
                    return this.GetPartsOfType<DiagramPersistLayoutPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramLayoutDefinitionParts of the SlidePart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramLayoutDefinitionPart> DiagramLayoutDefinitionParts
        {
            get{
                    return this.GetPartsOfType<DiagramLayoutDefinitionPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramStyleParts of the SlidePart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramStylePart> DiagramStyleParts
        {
            get{
                    return this.GetPartsOfType<DiagramStylePart>();
                }
        }
                
        /// <summary>
        /// Gets the EmbeddedObjectParts of the SlidePart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<EmbeddedObjectPart> EmbeddedObjectParts
        {
            get{
                    return this.GetPartsOfType<EmbeddedObjectPart>();
                }
        }
                
        /// <summary>
        /// Gets the EmbeddedPackageParts of the SlidePart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<EmbeddedPackagePart> EmbeddedPackageParts
        {
            get{
                    return this.GetPartsOfType<EmbeddedPackagePart>();
                }
        }
                
        /// <summary>
        /// Gets the ImageParts of the SlidePart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<ImagePart> ImageParts
        {
            get{
                    return this.GetPartsOfType<ImagePart>();
                }
        }
                
        /// <summary>
        /// Gets the VmlDrawingParts of the SlidePart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<VmlDrawingPart> VmlDrawingParts
        {
            get{
                    return this.GetPartsOfType<VmlDrawingPart>();
                }
        }
                
        /// <summary>
        /// Gets the EmbeddedControlPersistenceBinaryDataParts of the SlidePart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<EmbeddedControlPersistenceBinaryDataPart> EmbeddedControlPersistenceBinaryDataParts
        {
            get{
                    return this.GetPartsOfType<EmbeddedControlPersistenceBinaryDataPart>();
                }
        }
                
        /// <summary>
        /// Gets the SlideCommentsPart of the SlidePart.
        /// </summary>
        public SlideCommentsPart SlideCommentsPart
        {
            get {return GetSubPartOfType<SlideCommentsPart>(); }
        }
        /// <summary>
        /// Gets the NotesSlidePart of the SlidePart.
        /// </summary>
        public NotesSlidePart NotesSlidePart
        {
            get {return GetSubPartOfType<NotesSlidePart>(); }
        }
        /// <summary>
        /// Gets the ThemeOverridePart of the SlidePart.
        /// </summary>
        public ThemeOverridePart ThemeOverridePart
        {
            get {return GetSubPartOfType<ThemeOverridePart>(); }
        }
        /// <summary>
        /// Gets the SlideLayoutPart of the SlidePart.
        /// </summary>
        public SlideLayoutPart SlideLayoutPart
        {
            get {return GetSubPartOfType<SlideLayoutPart>(); }
        }
        /// <summary>
        /// Gets the SlideSyncDataPart of the SlidePart.
        /// </summary>
        public SlideSyncDataPart SlideSyncDataPart
        {
            get {return GetSubPartOfType<SlideSyncDataPart>(); }
        }
        /// <summary>
        /// Gets the UserDefinedTagsParts of the SlidePart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<UserDefinedTagsPart> UserDefinedTagsParts
        {
            get{
                    return this.GetPartsOfType<UserDefinedTagsPart>();
                }
        }
                
        /// <summary>
        /// Gets the SlideParts of the SlidePart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<SlidePart> SlideParts
        {
            get{
                    return this.GetPartsOfType<SlidePart>();
                }
        }
                
        /// <summary>
        /// Gets the EmbeddedControlPersistenceParts of the SlidePart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<EmbeddedControlPersistencePart> EmbeddedControlPersistenceParts
        {
            get{
                    return this.GetPartsOfType<EmbeddedControlPersistencePart>();
                }
        }
                
        /// <summary>
        /// Gets the WebExtensionParts of the SlidePart., only available in Office2013
        /// </summary>
[OfficeAvailability(FileFormatVersions.Office2013)]
        public System.Collections.Generic.IEnumerable<WebExtensionPart> WebExtensionParts
        {
            get{
                    return this.GetPartsOfType<WebExtensionPart>();
                }
        }
                


    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the SlideLayoutPart.
/// </summary>
public partial class SlideLayoutPart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/customXml", new PartConstraintRule("CustomXmlPart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/chart", new PartConstraintRule("ChartPart", ChartPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramColors", new PartConstraintRule("DiagramColorsPart", DiagramColorsPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramData", new PartConstraintRule("DiagramDataPart", DiagramDataPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.microsoft.com/office/2007/relationships/diagramDrawing", new PartConstraintRule("DiagramPersistLayoutPart", DiagramPersistLayoutPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramLayout", new PartConstraintRule("DiagramLayoutDefinitionPart", DiagramLayoutDefinitionPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramQuickStyle", new PartConstraintRule("DiagramStylePart", DiagramStylePart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/oleObject", new PartConstraintRule("EmbeddedObjectPart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/package", new PartConstraintRule("EmbeddedPackagePart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/image", new PartConstraintRule("ImagePart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/vmlDrawing", new PartConstraintRule("VmlDrawingPart", VmlDrawingPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.microsoft.com/office/2006/relationships/activeXControlBinary", new PartConstraintRule("EmbeddedControlPersistenceBinaryDataPart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/slide", new PartConstraintRule("SlidePart", SlidePart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/slideMaster", new PartConstraintRule("SlideMasterPart", SlideMasterPart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/themeOverride", new PartConstraintRule("ThemeOverridePart", ThemeOverridePart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/tags", new PartConstraintRule("UserDefinedTagsPart", UserDefinedTagsPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/control", new PartConstraintRule("EmbeddedControlPersistencePart", null, false, true,(FileFormatVersions)7 ));

            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/audio", new PartConstraintRule("AudioReferenceRelationship", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/video", new PartConstraintRule("VideoReferenceRelationship", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.microsoft.com/office/2007/relationships/media", new PartConstraintRule("MediaReferenceRelationship", null, false, true,(FileFormatVersions)7 ));

            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of SlideLayoutPart
    /// </summary>
    internal protected SlideLayoutPart()
            : base()
    {
    }
    
    
    /// <summary>
    /// Create an instance of OpenXmlPart according to the given relationship type
    /// </summary>
    /// <param name="relationshipType">Relationship type</param>
    /// <returns>An instance of OpenXmlPart</returns>
    internal sealed override OpenXmlPart CreatePartCore(string relationshipType)
    {
        this.ThrowIfObjectDisposed();

        if ( relationshipType == null )
        {
            throw new ArgumentNullException("relationshipType");
        }
        switch (relationshipType)
        {
        case CustomXmlPart.RelationshipTypeConstant:
                    return new CustomXmlPart();
            
        case ChartPart.RelationshipTypeConstant:
                    return new ChartPart();        
            
        case DiagramColorsPart.RelationshipTypeConstant:
                    return new DiagramColorsPart();        
            
        case DiagramDataPart.RelationshipTypeConstant:
                    return new DiagramDataPart();        
            
        case DiagramPersistLayoutPart.RelationshipTypeConstant:
                    return new DiagramPersistLayoutPart();        
            
        case DiagramLayoutDefinitionPart.RelationshipTypeConstant:
                    return new DiagramLayoutDefinitionPart();        
            
        case DiagramStylePart.RelationshipTypeConstant:
                    return new DiagramStylePart();        
            
        case EmbeddedObjectPart.RelationshipTypeConstant:
                    return new EmbeddedObjectPart();
            
        case EmbeddedPackagePart.RelationshipTypeConstant:
                    return new EmbeddedPackagePart();
            
        case ImagePart.RelationshipTypeConstant:
                    return new ImagePart();
            
        case VmlDrawingPart.RelationshipTypeConstant:
                    return new VmlDrawingPart();        
            
        case EmbeddedControlPersistenceBinaryDataPart.RelationshipTypeConstant:
                    return new EmbeddedControlPersistenceBinaryDataPart();
            
        case SlidePart.RelationshipTypeConstant:
                    return new SlidePart();        
            
        case SlideMasterPart.RelationshipTypeConstant:
                    return new SlideMasterPart();        
            
        case ThemeOverridePart.RelationshipTypeConstant:
                    return new ThemeOverridePart();        
            
        case UserDefinedTagsPart.RelationshipTypeConstant:
                    return new UserDefinedTagsPart();        
            
        case EmbeddedControlPersistencePart.RelationshipTypeConstant:
                    return new EmbeddedControlPersistencePart();
            

        }
        throw new ArgumentOutOfRangeException("relationshipType");
    }
    

        /// <summary>
    /// Adds a CustomXmlPart to the SlideLayoutPart.
    /// </summary>
    /// <param name="contentType">the content type of the CustomXmlPart.</param>
    /// <returns>The newly added part.</returns>
    public CustomXmlPart AddCustomXmlPart(string contentType)
    {
        CustomXmlPart childPart = new CustomXmlPart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a CustomXmlPart to the SlideLayoutPart.
    /// </summary>
    /// <param name="partType">The part type of the CustomXmlPart.</param>
    /// <returns>The newly added part.</returns>
     public CustomXmlPart AddCustomXmlPart(CustomXmlPartType partType)
    {
        string contentType = CustomXmlPartTypeInfo.GetContentType(partType);
        string partExtension = CustomXmlPartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddCustomXmlPart(contentType);
    }
    
    /// <summary>
    /// Adds a CustomXmlPart to the SlideLayoutPart.
    /// </summary>
    /// <param name="contentType">the content type of the CustomXmlPart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public CustomXmlPart AddCustomXmlPart(string contentType, string id)
    {
        CustomXmlPart childPart = new CustomXmlPart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a CustomXmlPart to the SlideLayoutPart.
    /// </summary>
    /// <param name="partType">The part type of the CustomXmlPart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public CustomXmlPart AddCustomXmlPart(CustomXmlPartType partType, string id)
    {
        string contentType = CustomXmlPartTypeInfo.GetContentType(partType);
        string partExtension = CustomXmlPartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddCustomXmlPart(contentType, id);
    }
    /// <summary>
    /// Adds a new <see cref="AudioReferenceRelationship"/> to the specified <see cref="MediaDataPart"/>.
    /// </summary>
    /// <param name="mediaDataPart">The specified target <see cref="MediaDataPart"/>.</param>
    /// <returns>The new <see cref="AudioReferenceRelationship"/>.</returns>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="mediaDataPart"/> is null.</exception>
    /// <exception cref="InvalidOperationException">Thrown when the specified <paramref name="mediaDataPart"/> is not in this document.</exception>
    public AudioReferenceRelationship AddAudioReferenceRelationship(MediaDataPart mediaDataPart)
    {
            return AddDataPartReferenceRelationship<AudioReferenceRelationship>(mediaDataPart);
    }
    /// <summary>
    /// Adds a new <see cref="AudioReferenceRelationship"/> to the specified <see cref="MediaDataPart"/>.
    /// </summary>
    /// <param name="mediaDataPart">The specified target <see cref="MediaDataPart"/>.</param>
    /// <param name="id">The desired relationship ID. </param>
    /// <returns>The new <see cref="AudioReferenceRelationship"/>.</returns>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="mediaDataPart"/> is null.</exception>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="id"/> is null.</exception>
    /// <exception cref="InvalidOperationException">Thrown when the specified <paramref name="mediaDataPart"/> is not in this document.</exception>
    public AudioReferenceRelationship AddAudioReferenceRelationship(MediaDataPart mediaDataPart, string id)
    {
            return AddDataPartReferenceRelationship<AudioReferenceRelationship>(mediaDataPart, id);
    }
	/// <summary>
    /// Adds a EmbeddedObjectPart to the SlideLayoutPart.
    /// </summary>
    /// <param name="contentType">The content type of the EmbeddedObjectPart.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedObjectPart AddEmbeddedObjectPart(string contentType)
    {
        EmbeddedObjectPart childPart = new EmbeddedObjectPart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
	/// <summary>
    /// Adds a EmbeddedPackagePart to the SlideLayoutPart.
    /// </summary>
    /// <param name="contentType">The content type of the EmbeddedPackagePart.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedPackagePart AddEmbeddedPackagePart(string contentType)
    {
        EmbeddedPackagePart childPart = new EmbeddedPackagePart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a ImagePart to the SlideLayoutPart.
    /// </summary>
    /// <param name="contentType">the content type of the ImagePart.</param>
    /// <returns>The newly added part.</returns>
    public ImagePart AddImagePart(string contentType)
    {
        ImagePart childPart = new ImagePart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a ImagePart to the SlideLayoutPart.
    /// </summary>
    /// <param name="partType">The part type of the ImagePart.</param>
    /// <returns>The newly added part.</returns>
     public ImagePart AddImagePart(ImagePartType partType)
    {
        string contentType = ImagePartTypeInfo.GetContentType(partType);
        string partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddImagePart(contentType);
    }
    
    /// <summary>
    /// Adds a ImagePart to the SlideLayoutPart.
    /// </summary>
    /// <param name="contentType">the content type of the ImagePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public ImagePart AddImagePart(string contentType, string id)
    {
        ImagePart childPart = new ImagePart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a ImagePart to the SlideLayoutPart.
    /// </summary>
    /// <param name="partType">The part type of the ImagePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public ImagePart AddImagePart(ImagePartType partType, string id)
    {
        string contentType = ImagePartTypeInfo.GetContentType(partType);
        string partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddImagePart(contentType, id);
    }
    /// <summary>
    /// Adds a new <see cref="VideoReferenceRelationship"/> to the specified <see cref="MediaDataPart"/>.
    /// </summary>
    /// <param name="mediaDataPart">The specified target <see cref="MediaDataPart"/>.</param>
    /// <returns>The new <see cref="VideoReferenceRelationship"/>.</returns>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="mediaDataPart"/> is null.</exception>
    /// <exception cref="InvalidOperationException">Thrown when the specified <paramref name="mediaDataPart"/> is not in this document.</exception>
    public VideoReferenceRelationship AddVideoReferenceRelationship(MediaDataPart mediaDataPart)
    {
            return AddDataPartReferenceRelationship<VideoReferenceRelationship>(mediaDataPart);
    }
    /// <summary>
    /// Adds a new <see cref="VideoReferenceRelationship"/> to the specified <see cref="MediaDataPart"/>.
    /// </summary>
    /// <param name="mediaDataPart">The specified target <see cref="MediaDataPart"/>.</param>
    /// <param name="id">The desired relationship ID. </param>
    /// <returns>The new <see cref="VideoReferenceRelationship"/>.</returns>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="mediaDataPart"/> is null.</exception>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="id"/> is null.</exception>
    /// <exception cref="InvalidOperationException">Thrown when the specified <paramref name="mediaDataPart"/> is not in this document.</exception>
    public VideoReferenceRelationship AddVideoReferenceRelationship(MediaDataPart mediaDataPart, string id)
    {
            return AddDataPartReferenceRelationship<VideoReferenceRelationship>(mediaDataPart, id);
    }
    /// <summary>
    /// Adds a EmbeddedControlPersistenceBinaryDataPart to the SlideLayoutPart.
    /// </summary>
    /// <param name="contentType">the content type of the EmbeddedControlPersistenceBinaryDataPart.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedControlPersistenceBinaryDataPart AddEmbeddedControlPersistenceBinaryDataPart(string contentType)
    {
        EmbeddedControlPersistenceBinaryDataPart childPart = new EmbeddedControlPersistenceBinaryDataPart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a EmbeddedControlPersistenceBinaryDataPart to the SlideLayoutPart.
    /// </summary>
    /// <param name="partType">The part type of the EmbeddedControlPersistenceBinaryDataPart.</param>
    /// <returns>The newly added part.</returns>
     public EmbeddedControlPersistenceBinaryDataPart AddEmbeddedControlPersistenceBinaryDataPart(EmbeddedControlPersistenceBinaryDataPartType partType)
    {
        string contentType = EmbeddedControlPersistenceBinaryDataPartTypeInfo.GetContentType(partType);
        string partExtension = EmbeddedControlPersistenceBinaryDataPartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddEmbeddedControlPersistenceBinaryDataPart(contentType);
    }
    
    /// <summary>
    /// Adds a EmbeddedControlPersistenceBinaryDataPart to the SlideLayoutPart.
    /// </summary>
    /// <param name="contentType">the content type of the EmbeddedControlPersistenceBinaryDataPart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedControlPersistenceBinaryDataPart AddEmbeddedControlPersistenceBinaryDataPart(string contentType, string id)
    {
        EmbeddedControlPersistenceBinaryDataPart childPart = new EmbeddedControlPersistenceBinaryDataPart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a EmbeddedControlPersistenceBinaryDataPart to the SlideLayoutPart.
    /// </summary>
    /// <param name="partType">The part type of the EmbeddedControlPersistenceBinaryDataPart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public EmbeddedControlPersistenceBinaryDataPart AddEmbeddedControlPersistenceBinaryDataPart(EmbeddedControlPersistenceBinaryDataPartType partType, string id)
    {
        string contentType = EmbeddedControlPersistenceBinaryDataPartTypeInfo.GetContentType(partType);
        string partExtension = EmbeddedControlPersistenceBinaryDataPartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddEmbeddedControlPersistenceBinaryDataPart(contentType, id);
    }
    /// <summary>
    /// Adds a EmbeddedControlPersistencePart to the SlideLayoutPart.
    /// </summary>
    /// <param name="contentType">the content type of the EmbeddedControlPersistencePart.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(string contentType)
    {
        EmbeddedControlPersistencePart childPart = new EmbeddedControlPersistencePart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a EmbeddedControlPersistencePart to the SlideLayoutPart.
    /// </summary>
    /// <param name="partType">The part type of the EmbeddedControlPersistencePart.</param>
    /// <returns>The newly added part.</returns>
     public EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(EmbeddedControlPersistencePartType partType)
    {
        string contentType = EmbeddedControlPersistencePartTypeInfo.GetContentType(partType);
        string partExtension = EmbeddedControlPersistencePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddEmbeddedControlPersistencePart(contentType);
    }
    
    /// <summary>
    /// Adds a EmbeddedControlPersistencePart to the SlideLayoutPart.
    /// </summary>
    /// <param name="contentType">the content type of the EmbeddedControlPersistencePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(string contentType, string id)
    {
        EmbeddedControlPersistencePart childPart = new EmbeddedControlPersistencePart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a EmbeddedControlPersistencePart to the SlideLayoutPart.
    /// </summary>
    /// <param name="partType">The part type of the EmbeddedControlPersistencePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(EmbeddedControlPersistencePartType partType, string id)
    {
        string contentType = EmbeddedControlPersistencePartTypeInfo.GetContentType(partType);
        string partExtension = EmbeddedControlPersistencePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddEmbeddedControlPersistencePart(contentType, id);
    }
    /// <summary>
    /// Adds a new <see cref="MediaReferenceRelationship"/> to the specified <see cref="MediaDataPart"/>.
    /// </summary>
    /// <param name="mediaDataPart">The specified target <see cref="MediaDataPart"/>.</param>
    /// <returns>The new <see cref="MediaReferenceRelationship"/>.</returns>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="mediaDataPart"/> is null.</exception>
    /// <exception cref="InvalidOperationException">Thrown when the specified <paramref name="mediaDataPart"/> is not in this document.</exception>
    public MediaReferenceRelationship AddMediaReferenceRelationship(MediaDataPart mediaDataPart)
    {
            return AddDataPartReferenceRelationship<MediaReferenceRelationship>(mediaDataPart);
    }
    /// <summary>
    /// Adds a new <see cref="MediaReferenceRelationship"/> to the specified <see cref="MediaDataPart"/>.
    /// </summary>
    /// <param name="mediaDataPart">The specified target <see cref="MediaDataPart"/>.</param>
    /// <param name="id">The desired relationship ID. </param>
    /// <returns>The new <see cref="MediaReferenceRelationship"/>.</returns>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="mediaDataPart"/> is null.</exception>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="id"/> is null.</exception>
    /// <exception cref="InvalidOperationException">Thrown when the specified <paramref name="mediaDataPart"/> is not in this document.</exception>
    public MediaReferenceRelationship AddMediaReferenceRelationship(MediaDataPart mediaDataPart, string id)
    {
            return AddDataPartReferenceRelationship<MediaReferenceRelationship>(mediaDataPart, id);
    }
 
    
    
   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/officeDocument/2006/relationships/slideLayout";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.openxmlformats-officedocument.presentationml.slideLayout+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@"../slideLayouts";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"slideLayout";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    

        /// <summary>
        /// Gets the CustomXmlParts of the SlideLayoutPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<CustomXmlPart> CustomXmlParts
        {
            get{
                    return this.GetPartsOfType<CustomXmlPart>();
                }
        }
                
        /// <summary>
        /// Gets the ChartParts of the SlideLayoutPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<ChartPart> ChartParts
        {
            get{
                    return this.GetPartsOfType<ChartPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramColorsParts of the SlideLayoutPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramColorsPart> DiagramColorsParts
        {
            get{
                    return this.GetPartsOfType<DiagramColorsPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramDataParts of the SlideLayoutPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramDataPart> DiagramDataParts
        {
            get{
                    return this.GetPartsOfType<DiagramDataPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramPersistLayoutParts of the SlideLayoutPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramPersistLayoutPart> DiagramPersistLayoutParts
        {
            get{
                    return this.GetPartsOfType<DiagramPersistLayoutPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramLayoutDefinitionParts of the SlideLayoutPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramLayoutDefinitionPart> DiagramLayoutDefinitionParts
        {
            get{
                    return this.GetPartsOfType<DiagramLayoutDefinitionPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramStyleParts of the SlideLayoutPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramStylePart> DiagramStyleParts
        {
            get{
                    return this.GetPartsOfType<DiagramStylePart>();
                }
        }
                
        /// <summary>
        /// Gets the EmbeddedObjectParts of the SlideLayoutPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<EmbeddedObjectPart> EmbeddedObjectParts
        {
            get{
                    return this.GetPartsOfType<EmbeddedObjectPart>();
                }
        }
                
        /// <summary>
        /// Gets the EmbeddedPackageParts of the SlideLayoutPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<EmbeddedPackagePart> EmbeddedPackageParts
        {
            get{
                    return this.GetPartsOfType<EmbeddedPackagePart>();
                }
        }
                
        /// <summary>
        /// Gets the ImageParts of the SlideLayoutPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<ImagePart> ImageParts
        {
            get{
                    return this.GetPartsOfType<ImagePart>();
                }
        }
                
        /// <summary>
        /// Gets the VmlDrawingParts of the SlideLayoutPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<VmlDrawingPart> VmlDrawingParts
        {
            get{
                    return this.GetPartsOfType<VmlDrawingPart>();
                }
        }
                
        /// <summary>
        /// Gets the EmbeddedControlPersistenceBinaryDataParts of the SlideLayoutPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<EmbeddedControlPersistenceBinaryDataPart> EmbeddedControlPersistenceBinaryDataParts
        {
            get{
                    return this.GetPartsOfType<EmbeddedControlPersistenceBinaryDataPart>();
                }
        }
                
        /// <summary>
        /// Gets the SlideParts of the SlideLayoutPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<SlidePart> SlideParts
        {
            get{
                    return this.GetPartsOfType<SlidePart>();
                }
        }
                
        /// <summary>
        /// Gets the SlideMasterPart of the SlideLayoutPart.
        /// </summary>
        public SlideMasterPart SlideMasterPart
        {
            get {return GetSubPartOfType<SlideMasterPart>(); }
        }
        /// <summary>
        /// Gets the ThemeOverridePart of the SlideLayoutPart.
        /// </summary>
        public ThemeOverridePart ThemeOverridePart
        {
            get {return GetSubPartOfType<ThemeOverridePart>(); }
        }
        /// <summary>
        /// Gets the UserDefinedTagsParts of the SlideLayoutPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<UserDefinedTagsPart> UserDefinedTagsParts
        {
            get{
                    return this.GetPartsOfType<UserDefinedTagsPart>();
                }
        }
                
        /// <summary>
        /// Gets the EmbeddedControlPersistenceParts of the SlideLayoutPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<EmbeddedControlPersistencePart> EmbeddedControlPersistenceParts
        {
            get{
                    return this.GetPartsOfType<EmbeddedControlPersistencePart>();
                }
        }
                


    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the SlideMasterPart.
/// </summary>
public partial class SlideMasterPart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/customXml", new PartConstraintRule("CustomXmlPart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/chart", new PartConstraintRule("ChartPart", ChartPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramColors", new PartConstraintRule("DiagramColorsPart", DiagramColorsPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramData", new PartConstraintRule("DiagramDataPart", DiagramDataPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.microsoft.com/office/2007/relationships/diagramDrawing", new PartConstraintRule("DiagramPersistLayoutPart", DiagramPersistLayoutPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramLayout", new PartConstraintRule("DiagramLayoutDefinitionPart", DiagramLayoutDefinitionPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramQuickStyle", new PartConstraintRule("DiagramStylePart", DiagramStylePart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/oleObject", new PartConstraintRule("EmbeddedObjectPart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/package", new PartConstraintRule("EmbeddedPackagePart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/image", new PartConstraintRule("ImagePart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/vmlDrawing", new PartConstraintRule("VmlDrawingPart", VmlDrawingPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.microsoft.com/office/2006/relationships/activeXControlBinary", new PartConstraintRule("EmbeddedControlPersistenceBinaryDataPart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/theme", new PartConstraintRule("ThemePart", ThemePart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/slide", new PartConstraintRule("SlidePart", SlidePart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/slideLayout", new PartConstraintRule("SlideLayoutPart", SlideLayoutPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/control", new PartConstraintRule("EmbeddedControlPersistencePart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/tags", new PartConstraintRule("UserDefinedTagsPart", UserDefinedTagsPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));

            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/audio", new PartConstraintRule("AudioReferenceRelationship", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/video", new PartConstraintRule("VideoReferenceRelationship", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.microsoft.com/office/2007/relationships/media", new PartConstraintRule("MediaReferenceRelationship", null, false, true,(FileFormatVersions)7 ));

            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of SlideMasterPart
    /// </summary>
    internal protected SlideMasterPart()
            : base()
    {
    }
    
    
    /// <summary>
    /// Create an instance of OpenXmlPart according to the given relationship type
    /// </summary>
    /// <param name="relationshipType">Relationship type</param>
    /// <returns>An instance of OpenXmlPart</returns>
    internal sealed override OpenXmlPart CreatePartCore(string relationshipType)
    {
        this.ThrowIfObjectDisposed();

        if ( relationshipType == null )
        {
            throw new ArgumentNullException("relationshipType");
        }
        switch (relationshipType)
        {
        case CustomXmlPart.RelationshipTypeConstant:
                    return new CustomXmlPart();
            
        case ChartPart.RelationshipTypeConstant:
                    return new ChartPart();        
            
        case DiagramColorsPart.RelationshipTypeConstant:
                    return new DiagramColorsPart();        
            
        case DiagramDataPart.RelationshipTypeConstant:
                    return new DiagramDataPart();        
            
        case DiagramPersistLayoutPart.RelationshipTypeConstant:
                    return new DiagramPersistLayoutPart();        
            
        case DiagramLayoutDefinitionPart.RelationshipTypeConstant:
                    return new DiagramLayoutDefinitionPart();        
            
        case DiagramStylePart.RelationshipTypeConstant:
                    return new DiagramStylePart();        
            
        case EmbeddedObjectPart.RelationshipTypeConstant:
                    return new EmbeddedObjectPart();
            
        case EmbeddedPackagePart.RelationshipTypeConstant:
                    return new EmbeddedPackagePart();
            
        case ImagePart.RelationshipTypeConstant:
                    return new ImagePart();
            
        case VmlDrawingPart.RelationshipTypeConstant:
                    return new VmlDrawingPart();        
            
        case EmbeddedControlPersistenceBinaryDataPart.RelationshipTypeConstant:
                    return new EmbeddedControlPersistenceBinaryDataPart();
            
        case ThemePart.RelationshipTypeConstant:
                    return new ThemePart();        
            
        case SlidePart.RelationshipTypeConstant:
                    return new SlidePart();        
            
        case SlideLayoutPart.RelationshipTypeConstant:
                    return new SlideLayoutPart();        
            
        case EmbeddedControlPersistencePart.RelationshipTypeConstant:
                    return new EmbeddedControlPersistencePart();
            
        case UserDefinedTagsPart.RelationshipTypeConstant:
                    return new UserDefinedTagsPart();        
            

        }
        throw new ArgumentOutOfRangeException("relationshipType");
    }
    

        /// <summary>
    /// Adds a CustomXmlPart to the SlideMasterPart.
    /// </summary>
    /// <param name="contentType">the content type of the CustomXmlPart.</param>
    /// <returns>The newly added part.</returns>
    public CustomXmlPart AddCustomXmlPart(string contentType)
    {
        CustomXmlPart childPart = new CustomXmlPart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a CustomXmlPart to the SlideMasterPart.
    /// </summary>
    /// <param name="partType">The part type of the CustomXmlPart.</param>
    /// <returns>The newly added part.</returns>
     public CustomXmlPart AddCustomXmlPart(CustomXmlPartType partType)
    {
        string contentType = CustomXmlPartTypeInfo.GetContentType(partType);
        string partExtension = CustomXmlPartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddCustomXmlPart(contentType);
    }
    
    /// <summary>
    /// Adds a CustomXmlPart to the SlideMasterPart.
    /// </summary>
    /// <param name="contentType">the content type of the CustomXmlPart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public CustomXmlPart AddCustomXmlPart(string contentType, string id)
    {
        CustomXmlPart childPart = new CustomXmlPart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a CustomXmlPart to the SlideMasterPart.
    /// </summary>
    /// <param name="partType">The part type of the CustomXmlPart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public CustomXmlPart AddCustomXmlPart(CustomXmlPartType partType, string id)
    {
        string contentType = CustomXmlPartTypeInfo.GetContentType(partType);
        string partExtension = CustomXmlPartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddCustomXmlPart(contentType, id);
    }
    /// <summary>
    /// Adds a new <see cref="AudioReferenceRelationship"/> to the specified <see cref="MediaDataPart"/>.
    /// </summary>
    /// <param name="mediaDataPart">The specified target <see cref="MediaDataPart"/>.</param>
    /// <returns>The new <see cref="AudioReferenceRelationship"/>.</returns>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="mediaDataPart"/> is null.</exception>
    /// <exception cref="InvalidOperationException">Thrown when the specified <paramref name="mediaDataPart"/> is not in this document.</exception>
    public AudioReferenceRelationship AddAudioReferenceRelationship(MediaDataPart mediaDataPart)
    {
            return AddDataPartReferenceRelationship<AudioReferenceRelationship>(mediaDataPart);
    }
    /// <summary>
    /// Adds a new <see cref="AudioReferenceRelationship"/> to the specified <see cref="MediaDataPart"/>.
    /// </summary>
    /// <param name="mediaDataPart">The specified target <see cref="MediaDataPart"/>.</param>
    /// <param name="id">The desired relationship ID. </param>
    /// <returns>The new <see cref="AudioReferenceRelationship"/>.</returns>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="mediaDataPart"/> is null.</exception>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="id"/> is null.</exception>
    /// <exception cref="InvalidOperationException">Thrown when the specified <paramref name="mediaDataPart"/> is not in this document.</exception>
    public AudioReferenceRelationship AddAudioReferenceRelationship(MediaDataPart mediaDataPart, string id)
    {
            return AddDataPartReferenceRelationship<AudioReferenceRelationship>(mediaDataPart, id);
    }
	/// <summary>
    /// Adds a EmbeddedObjectPart to the SlideMasterPart.
    /// </summary>
    /// <param name="contentType">The content type of the EmbeddedObjectPart.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedObjectPart AddEmbeddedObjectPart(string contentType)
    {
        EmbeddedObjectPart childPart = new EmbeddedObjectPart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
	/// <summary>
    /// Adds a EmbeddedPackagePart to the SlideMasterPart.
    /// </summary>
    /// <param name="contentType">The content type of the EmbeddedPackagePart.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedPackagePart AddEmbeddedPackagePart(string contentType)
    {
        EmbeddedPackagePart childPart = new EmbeddedPackagePart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a ImagePart to the SlideMasterPart.
    /// </summary>
    /// <param name="contentType">the content type of the ImagePart.</param>
    /// <returns>The newly added part.</returns>
    public ImagePart AddImagePart(string contentType)
    {
        ImagePart childPart = new ImagePart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a ImagePart to the SlideMasterPart.
    /// </summary>
    /// <param name="partType">The part type of the ImagePart.</param>
    /// <returns>The newly added part.</returns>
     public ImagePart AddImagePart(ImagePartType partType)
    {
        string contentType = ImagePartTypeInfo.GetContentType(partType);
        string partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddImagePart(contentType);
    }
    
    /// <summary>
    /// Adds a ImagePart to the SlideMasterPart.
    /// </summary>
    /// <param name="contentType">the content type of the ImagePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public ImagePart AddImagePart(string contentType, string id)
    {
        ImagePart childPart = new ImagePart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a ImagePart to the SlideMasterPart.
    /// </summary>
    /// <param name="partType">The part type of the ImagePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public ImagePart AddImagePart(ImagePartType partType, string id)
    {
        string contentType = ImagePartTypeInfo.GetContentType(partType);
        string partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddImagePart(contentType, id);
    }
    /// <summary>
    /// Adds a new <see cref="VideoReferenceRelationship"/> to the specified <see cref="MediaDataPart"/>.
    /// </summary>
    /// <param name="mediaDataPart">The specified target <see cref="MediaDataPart"/>.</param>
    /// <returns>The new <see cref="VideoReferenceRelationship"/>.</returns>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="mediaDataPart"/> is null.</exception>
    /// <exception cref="InvalidOperationException">Thrown when the specified <paramref name="mediaDataPart"/> is not in this document.</exception>
    public VideoReferenceRelationship AddVideoReferenceRelationship(MediaDataPart mediaDataPart)
    {
            return AddDataPartReferenceRelationship<VideoReferenceRelationship>(mediaDataPart);
    }
    /// <summary>
    /// Adds a new <see cref="VideoReferenceRelationship"/> to the specified <see cref="MediaDataPart"/>.
    /// </summary>
    /// <param name="mediaDataPart">The specified target <see cref="MediaDataPart"/>.</param>
    /// <param name="id">The desired relationship ID. </param>
    /// <returns>The new <see cref="VideoReferenceRelationship"/>.</returns>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="mediaDataPart"/> is null.</exception>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="id"/> is null.</exception>
    /// <exception cref="InvalidOperationException">Thrown when the specified <paramref name="mediaDataPart"/> is not in this document.</exception>
    public VideoReferenceRelationship AddVideoReferenceRelationship(MediaDataPart mediaDataPart, string id)
    {
            return AddDataPartReferenceRelationship<VideoReferenceRelationship>(mediaDataPart, id);
    }
    /// <summary>
    /// Adds a EmbeddedControlPersistenceBinaryDataPart to the SlideMasterPart.
    /// </summary>
    /// <param name="contentType">the content type of the EmbeddedControlPersistenceBinaryDataPart.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedControlPersistenceBinaryDataPart AddEmbeddedControlPersistenceBinaryDataPart(string contentType)
    {
        EmbeddedControlPersistenceBinaryDataPart childPart = new EmbeddedControlPersistenceBinaryDataPart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a EmbeddedControlPersistenceBinaryDataPart to the SlideMasterPart.
    /// </summary>
    /// <param name="partType">The part type of the EmbeddedControlPersistenceBinaryDataPart.</param>
    /// <returns>The newly added part.</returns>
     public EmbeddedControlPersistenceBinaryDataPart AddEmbeddedControlPersistenceBinaryDataPart(EmbeddedControlPersistenceBinaryDataPartType partType)
    {
        string contentType = EmbeddedControlPersistenceBinaryDataPartTypeInfo.GetContentType(partType);
        string partExtension = EmbeddedControlPersistenceBinaryDataPartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddEmbeddedControlPersistenceBinaryDataPart(contentType);
    }
    
    /// <summary>
    /// Adds a EmbeddedControlPersistenceBinaryDataPart to the SlideMasterPart.
    /// </summary>
    /// <param name="contentType">the content type of the EmbeddedControlPersistenceBinaryDataPart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedControlPersistenceBinaryDataPart AddEmbeddedControlPersistenceBinaryDataPart(string contentType, string id)
    {
        EmbeddedControlPersistenceBinaryDataPart childPart = new EmbeddedControlPersistenceBinaryDataPart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a EmbeddedControlPersistenceBinaryDataPart to the SlideMasterPart.
    /// </summary>
    /// <param name="partType">The part type of the EmbeddedControlPersistenceBinaryDataPart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public EmbeddedControlPersistenceBinaryDataPart AddEmbeddedControlPersistenceBinaryDataPart(EmbeddedControlPersistenceBinaryDataPartType partType, string id)
    {
        string contentType = EmbeddedControlPersistenceBinaryDataPartTypeInfo.GetContentType(partType);
        string partExtension = EmbeddedControlPersistenceBinaryDataPartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddEmbeddedControlPersistenceBinaryDataPart(contentType, id);
    }
    /// <summary>
    /// Adds a EmbeddedControlPersistencePart to the SlideMasterPart.
    /// </summary>
    /// <param name="contentType">the content type of the EmbeddedControlPersistencePart.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(string contentType)
    {
        EmbeddedControlPersistencePart childPart = new EmbeddedControlPersistencePart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a EmbeddedControlPersistencePart to the SlideMasterPart.
    /// </summary>
    /// <param name="partType">The part type of the EmbeddedControlPersistencePart.</param>
    /// <returns>The newly added part.</returns>
     public EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(EmbeddedControlPersistencePartType partType)
    {
        string contentType = EmbeddedControlPersistencePartTypeInfo.GetContentType(partType);
        string partExtension = EmbeddedControlPersistencePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddEmbeddedControlPersistencePart(contentType);
    }
    
    /// <summary>
    /// Adds a EmbeddedControlPersistencePart to the SlideMasterPart.
    /// </summary>
    /// <param name="contentType">the content type of the EmbeddedControlPersistencePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(string contentType, string id)
    {
        EmbeddedControlPersistencePart childPart = new EmbeddedControlPersistencePart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a EmbeddedControlPersistencePart to the SlideMasterPart.
    /// </summary>
    /// <param name="partType">The part type of the EmbeddedControlPersistencePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(EmbeddedControlPersistencePartType partType, string id)
    {
        string contentType = EmbeddedControlPersistencePartTypeInfo.GetContentType(partType);
        string partExtension = EmbeddedControlPersistencePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddEmbeddedControlPersistencePart(contentType, id);
    }
    /// <summary>
    /// Adds a new <see cref="MediaReferenceRelationship"/> to the specified <see cref="MediaDataPart"/>.
    /// </summary>
    /// <param name="mediaDataPart">The specified target <see cref="MediaDataPart"/>.</param>
    /// <returns>The new <see cref="MediaReferenceRelationship"/>.</returns>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="mediaDataPart"/> is null.</exception>
    /// <exception cref="InvalidOperationException">Thrown when the specified <paramref name="mediaDataPart"/> is not in this document.</exception>
    public MediaReferenceRelationship AddMediaReferenceRelationship(MediaDataPart mediaDataPart)
    {
            return AddDataPartReferenceRelationship<MediaReferenceRelationship>(mediaDataPart);
    }
    /// <summary>
    /// Adds a new <see cref="MediaReferenceRelationship"/> to the specified <see cref="MediaDataPart"/>.
    /// </summary>
    /// <param name="mediaDataPart">The specified target <see cref="MediaDataPart"/>.</param>
    /// <param name="id">The desired relationship ID. </param>
    /// <returns>The new <see cref="MediaReferenceRelationship"/>.</returns>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="mediaDataPart"/> is null.</exception>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="id"/> is null.</exception>
    /// <exception cref="InvalidOperationException">Thrown when the specified <paramref name="mediaDataPart"/> is not in this document.</exception>
    public MediaReferenceRelationship AddMediaReferenceRelationship(MediaDataPart mediaDataPart, string id)
    {
            return AddDataPartReferenceRelationship<MediaReferenceRelationship>(mediaDataPart, id);
    }
 
    
    
   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/officeDocument/2006/relationships/slideMaster";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.openxmlformats-officedocument.presentationml.slideMaster+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@"slideMasters";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"slideMaster";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    

        /// <summary>
        /// Gets the CustomXmlParts of the SlideMasterPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<CustomXmlPart> CustomXmlParts
        {
            get{
                    return this.GetPartsOfType<CustomXmlPart>();
                }
        }
                
        /// <summary>
        /// Gets the ChartParts of the SlideMasterPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<ChartPart> ChartParts
        {
            get{
                    return this.GetPartsOfType<ChartPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramColorsParts of the SlideMasterPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramColorsPart> DiagramColorsParts
        {
            get{
                    return this.GetPartsOfType<DiagramColorsPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramDataParts of the SlideMasterPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramDataPart> DiagramDataParts
        {
            get{
                    return this.GetPartsOfType<DiagramDataPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramPersistLayoutParts of the SlideMasterPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramPersistLayoutPart> DiagramPersistLayoutParts
        {
            get{
                    return this.GetPartsOfType<DiagramPersistLayoutPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramLayoutDefinitionParts of the SlideMasterPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramLayoutDefinitionPart> DiagramLayoutDefinitionParts
        {
            get{
                    return this.GetPartsOfType<DiagramLayoutDefinitionPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramStyleParts of the SlideMasterPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramStylePart> DiagramStyleParts
        {
            get{
                    return this.GetPartsOfType<DiagramStylePart>();
                }
        }
                
        /// <summary>
        /// Gets the EmbeddedObjectParts of the SlideMasterPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<EmbeddedObjectPart> EmbeddedObjectParts
        {
            get{
                    return this.GetPartsOfType<EmbeddedObjectPart>();
                }
        }
                
        /// <summary>
        /// Gets the EmbeddedPackageParts of the SlideMasterPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<EmbeddedPackagePart> EmbeddedPackageParts
        {
            get{
                    return this.GetPartsOfType<EmbeddedPackagePart>();
                }
        }
                
        /// <summary>
        /// Gets the ImageParts of the SlideMasterPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<ImagePart> ImageParts
        {
            get{
                    return this.GetPartsOfType<ImagePart>();
                }
        }
                
        /// <summary>
        /// Gets the VmlDrawingParts of the SlideMasterPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<VmlDrawingPart> VmlDrawingParts
        {
            get{
                    return this.GetPartsOfType<VmlDrawingPart>();
                }
        }
                
        /// <summary>
        /// Gets the EmbeddedControlPersistenceBinaryDataParts of the SlideMasterPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<EmbeddedControlPersistenceBinaryDataPart> EmbeddedControlPersistenceBinaryDataParts
        {
            get{
                    return this.GetPartsOfType<EmbeddedControlPersistenceBinaryDataPart>();
                }
        }
                
        /// <summary>
        /// Gets the ThemePart of the SlideMasterPart.
        /// </summary>
        public ThemePart ThemePart
        {
            get {return GetSubPartOfType<ThemePart>(); }
        }
        /// <summary>
        /// Gets the SlideParts of the SlideMasterPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<SlidePart> SlideParts
        {
            get{
                    return this.GetPartsOfType<SlidePart>();
                }
        }
                
        /// <summary>
        /// Gets the SlideLayoutParts of the SlideMasterPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<SlideLayoutPart> SlideLayoutParts
        {
            get{
                    return this.GetPartsOfType<SlideLayoutPart>();
                }
        }
                
        /// <summary>
        /// Gets the EmbeddedControlPersistenceParts of the SlideMasterPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<EmbeddedControlPersistencePart> EmbeddedControlPersistenceParts
        {
            get{
                    return this.GetPartsOfType<EmbeddedControlPersistencePart>();
                }
        }
                
        /// <summary>
        /// Gets the UserDefinedTagsParts of the SlideMasterPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<UserDefinedTagsPart> UserDefinedTagsParts
        {
            get{
                    return this.GetPartsOfType<UserDefinedTagsPart>();
                }
        }
                


    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the SlideSyncDataPart.
/// </summary>
public partial class SlideSyncDataPart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of SlideSyncDataPart
    /// </summary>
    internal protected SlideSyncDataPart()
            : base()
    {
    }
    
    

   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/officeDocument/2006/relationships/slideUpdateInfo";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.openxmlformats-officedocument.presentationml.slideUpdateInfo+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@"slideUpdateInfo";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"slideUpdateInfo";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    



    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the UserDefinedTagsPart.
/// </summary>
public partial class UserDefinedTagsPart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of UserDefinedTagsPart
    /// </summary>
    internal protected UserDefinedTagsPart()
            : base()
    {
    }
    
    

   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/officeDocument/2006/relationships/tags";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.openxmlformats-officedocument.presentationml.tags+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@"tags";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"tag";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    



    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the ViewPropertiesPart.
/// </summary>
public partial class ViewPropertiesPart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/slide", new PartConstraintRule("SlidePart", SlidePart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));

            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of ViewPropertiesPart
    /// </summary>
    internal protected ViewPropertiesPart()
            : base()
    {
    }
    
    
    /// <summary>
    /// Create an instance of OpenXmlPart according to the given relationship type
    /// </summary>
    /// <param name="relationshipType">Relationship type</param>
    /// <returns>An instance of OpenXmlPart</returns>
    internal sealed override OpenXmlPart CreatePartCore(string relationshipType)
    {
        this.ThrowIfObjectDisposed();

        if ( relationshipType == null )
        {
            throw new ArgumentNullException("relationshipType");
        }
        switch (relationshipType)
        {
        case SlidePart.RelationshipTypeConstant:
                    return new SlidePart();        
            

        }
        throw new ArgumentOutOfRangeException("relationshipType");
    }
    

     
    
    
   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/officeDocument/2006/relationships/viewProps";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.openxmlformats-officedocument.presentationml.viewProps+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@".";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"viewProps";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    

        /// <summary>
        /// Gets the SlideParts of the ViewPropertiesPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<SlidePart> SlideParts
        {
            get{
                    return this.GetPartsOfType<SlidePart>();
                }
        }
                


    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the LegacyDiagramTextInfoPart.
/// </summary>
public partial class LegacyDiagramTextInfoPart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of LegacyDiagramTextInfoPart
    /// </summary>
    internal protected LegacyDiagramTextInfoPart()
            : base()
    {
    }
    
    

   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.microsoft.com/office/2006/relationships/legacyDocTextInfo";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.ms-office.legacyDocTextInfo";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@".";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"legacyDocTextInfo";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetFileExtension
    /// </summary>
    internal const System.String TargetFileExtensionConstant =@".bin";
    /// <summary>
    /// Gets the TargetFileExtension.
    /// </summary>
    internal sealed override string TargetFileExtension
    {
       get { return TargetFileExtensionConstant; }
    } 
    



    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the LegacyDiagramTextPart.
/// </summary>
public partial class LegacyDiagramTextPart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of LegacyDiagramTextPart
    /// </summary>
    internal protected LegacyDiagramTextPart()
            : base()
    {
    }
    
    

   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.microsoft.com/office/2006/relationships/legacyDiagramText";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.ms-office.legacyDiagramText";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@".";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"legacyDiagramText";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetFileExtension
    /// </summary>
    internal const System.String TargetFileExtensionConstant =@".bin";
    /// <summary>
    /// Gets the TargetFileExtension.
    /// </summary>
    internal sealed override string TargetFileExtension
    {
       get { return TargetFileExtensionConstant; }
    } 
    



    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the ChartPart.
/// </summary>
public partial class ChartPart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/chartUserShapes", new PartConstraintRule("ChartDrawingPart", ChartDrawingPart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/package", new PartConstraintRule("EmbeddedPackagePart", null, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/image", new PartConstraintRule("ImagePart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/themeOverride", new PartConstraintRule("ThemeOverridePart", ThemeOverridePart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.microsoft.com/office/2011/relationships/chartStyle", new PartConstraintRule("ChartStylePart", ChartStylePart.ContentTypeConstant, false, true,(FileFormatVersions)4 ));
tempData.Add("http://schemas.microsoft.com/office/2011/relationships/chartColorStyle", new PartConstraintRule("ChartColorStylePart", ChartColorStylePart.ContentTypeConstant, false, true,(FileFormatVersions)4 ));

            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of ChartPart
    /// </summary>
    internal protected ChartPart()
            : base()
    {
    }
    
    
    /// <summary>
    /// Create an instance of OpenXmlPart according to the given relationship type
    /// </summary>
    /// <param name="relationshipType">Relationship type</param>
    /// <returns>An instance of OpenXmlPart</returns>
    internal sealed override OpenXmlPart CreatePartCore(string relationshipType)
    {
        this.ThrowIfObjectDisposed();

        if ( relationshipType == null )
        {
            throw new ArgumentNullException("relationshipType");
        }
        switch (relationshipType)
        {
        case ChartDrawingPart.RelationshipTypeConstant:
                    return new ChartDrawingPart();        
            
        case EmbeddedPackagePart.RelationshipTypeConstant:
                    return new EmbeddedPackagePart();
            
        case ImagePart.RelationshipTypeConstant:
                    return new ImagePart();
            
        case ThemeOverridePart.RelationshipTypeConstant:
                    return new ThemeOverridePart();        
            
        case ChartStylePart.RelationshipTypeConstant:
                    return new ChartStylePart();        
            
        case ChartColorStylePart.RelationshipTypeConstant:
                    return new ChartColorStylePart();        
            

        }
        throw new ArgumentOutOfRangeException("relationshipType");
    }
    

    	/// <summary>
    /// Adds a EmbeddedPackagePart to the ChartPart.
    /// </summary>
    /// <param name="contentType">The content type of the EmbeddedPackagePart.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedPackagePart AddEmbeddedPackagePart(string contentType)
    {
        EmbeddedPackagePart childPart = new EmbeddedPackagePart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a ImagePart to the ChartPart.
    /// </summary>
    /// <param name="contentType">the content type of the ImagePart.</param>
    /// <returns>The newly added part.</returns>
    public ImagePart AddImagePart(string contentType)
    {
        ImagePart childPart = new ImagePart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a ImagePart to the ChartPart.
    /// </summary>
    /// <param name="partType">The part type of the ImagePart.</param>
    /// <returns>The newly added part.</returns>
     public ImagePart AddImagePart(ImagePartType partType)
    {
        string contentType = ImagePartTypeInfo.GetContentType(partType);
        string partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddImagePart(contentType);
    }
    
    /// <summary>
    /// Adds a ImagePart to the ChartPart.
    /// </summary>
    /// <param name="contentType">the content type of the ImagePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public ImagePart AddImagePart(string contentType, string id)
    {
        ImagePart childPart = new ImagePart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a ImagePart to the ChartPart.
    /// </summary>
    /// <param name="partType">The part type of the ImagePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public ImagePart AddImagePart(ImagePartType partType, string id)
    {
        string contentType = ImagePartTypeInfo.GetContentType(partType);
        string partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddImagePart(contentType, id);
    }
 
    
    
   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/officeDocument/2006/relationships/chart";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.openxmlformats-officedocument.drawingml.chart+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@"charts";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"chart";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    

        /// <summary>
        /// Gets the ChartDrawingPart of the ChartPart.
        /// </summary>
        public ChartDrawingPart ChartDrawingPart
        {
            get {return GetSubPartOfType<ChartDrawingPart>(); }
        }
        /// <summary>
        /// Gets the EmbeddedPackagePart of the ChartPart.
        /// </summary>
        public EmbeddedPackagePart EmbeddedPackagePart
        {
            get {return GetSubPartOfType<EmbeddedPackagePart>(); }
        }
        /// <summary>
        /// Gets the ImageParts of the ChartPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<ImagePart> ImageParts
        {
            get{
                    return this.GetPartsOfType<ImagePart>();
                }
        }
                
        /// <summary>
        /// Gets the ThemeOverridePart of the ChartPart.
        /// </summary>
        public ThemeOverridePart ThemeOverridePart
        {
            get {return GetSubPartOfType<ThemeOverridePart>(); }
        }
        /// <summary>
        /// Gets the ChartStyleParts of the ChartPart., only available in Office2013
        /// </summary>
[OfficeAvailability(FileFormatVersions.Office2013)]
        public System.Collections.Generic.IEnumerable<ChartStylePart> ChartStyleParts
        {
            get{
                    return this.GetPartsOfType<ChartStylePart>();
                }
        }
                
        /// <summary>
        /// Gets the ChartColorStyleParts of the ChartPart., only available in Office2013
        /// </summary>
[OfficeAvailability(FileFormatVersions.Office2013)]
        public System.Collections.Generic.IEnumerable<ChartColorStylePart> ChartColorStyleParts
        {
            get{
                    return this.GetPartsOfType<ChartColorStylePart>();
                }
        }
                


    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the ChartDrawingPart.
/// </summary>
public partial class ChartDrawingPart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/chart", new PartConstraintRule("ChartPart", ChartPart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/image", new PartConstraintRule("ImagePart", null, false, true,(FileFormatVersions)7 ));

            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of ChartDrawingPart
    /// </summary>
    internal protected ChartDrawingPart()
            : base()
    {
    }
    
    
    /// <summary>
    /// Create an instance of OpenXmlPart according to the given relationship type
    /// </summary>
    /// <param name="relationshipType">Relationship type</param>
    /// <returns>An instance of OpenXmlPart</returns>
    internal sealed override OpenXmlPart CreatePartCore(string relationshipType)
    {
        this.ThrowIfObjectDisposed();

        if ( relationshipType == null )
        {
            throw new ArgumentNullException("relationshipType");
        }
        switch (relationshipType)
        {
        case ChartPart.RelationshipTypeConstant:
                    return new ChartPart();        
            
        case ImagePart.RelationshipTypeConstant:
                    return new ImagePart();
            

        }
        throw new ArgumentOutOfRangeException("relationshipType");
    }
    

        /// <summary>
    /// Adds a ImagePart to the ChartDrawingPart.
    /// </summary>
    /// <param name="contentType">the content type of the ImagePart.</param>
    /// <returns>The newly added part.</returns>
    public ImagePart AddImagePart(string contentType)
    {
        ImagePart childPart = new ImagePart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a ImagePart to the ChartDrawingPart.
    /// </summary>
    /// <param name="partType">The part type of the ImagePart.</param>
    /// <returns>The newly added part.</returns>
     public ImagePart AddImagePart(ImagePartType partType)
    {
        string contentType = ImagePartTypeInfo.GetContentType(partType);
        string partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddImagePart(contentType);
    }
    
    /// <summary>
    /// Adds a ImagePart to the ChartDrawingPart.
    /// </summary>
    /// <param name="contentType">the content type of the ImagePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public ImagePart AddImagePart(string contentType, string id)
    {
        ImagePart childPart = new ImagePart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a ImagePart to the ChartDrawingPart.
    /// </summary>
    /// <param name="partType">The part type of the ImagePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public ImagePart AddImagePart(ImagePartType partType, string id)
    {
        string contentType = ImagePartTypeInfo.GetContentType(partType);
        string partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddImagePart(contentType, id);
    }
 
    
    
   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/officeDocument/2006/relationships/chartUserShapes";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.openxmlformats-officedocument.drawingml.chartshapes+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@"../drawings";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"drawing";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    

        /// <summary>
        /// Gets the ChartPart of the ChartDrawingPart.
        /// </summary>
        public ChartPart ChartPart
        {
            get {return GetSubPartOfType<ChartPart>(); }
        }
        /// <summary>
        /// Gets the ImageParts of the ChartDrawingPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<ImagePart> ImageParts
        {
            get{
                    return this.GetPartsOfType<ImagePart>();
                }
        }
                


    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the DiagramColorsPart.
/// </summary>
public partial class DiagramColorsPart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of DiagramColorsPart
    /// </summary>
    internal protected DiagramColorsPart()
            : base()
    {
    }
    
    

   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramColors";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.openxmlformats-officedocument.drawingml.diagramColors+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@"../graphics";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"colors";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    



    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the DiagramDataPart.
/// </summary>
public partial class DiagramDataPart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/image", new PartConstraintRule("ImagePart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/slide", new PartConstraintRule("SlidePart", SlidePart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/worksheet", new PartConstraintRule("WorksheetPart", WorksheetPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));

            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of DiagramDataPart
    /// </summary>
    internal protected DiagramDataPart()
            : base()
    {
    }
    
    
    /// <summary>
    /// Create an instance of OpenXmlPart according to the given relationship type
    /// </summary>
    /// <param name="relationshipType">Relationship type</param>
    /// <returns>An instance of OpenXmlPart</returns>
    internal sealed override OpenXmlPart CreatePartCore(string relationshipType)
    {
        this.ThrowIfObjectDisposed();

        if ( relationshipType == null )
        {
            throw new ArgumentNullException("relationshipType");
        }
        switch (relationshipType)
        {
        case ImagePart.RelationshipTypeConstant:
                    return new ImagePart();
            
        case SlidePart.RelationshipTypeConstant:
                    return new SlidePart();        
            
        case WorksheetPart.RelationshipTypeConstant:
                    return new WorksheetPart();        
            

        }
        throw new ArgumentOutOfRangeException("relationshipType");
    }
    

        /// <summary>
    /// Adds a ImagePart to the DiagramDataPart.
    /// </summary>
    /// <param name="contentType">the content type of the ImagePart.</param>
    /// <returns>The newly added part.</returns>
    public ImagePart AddImagePart(string contentType)
    {
        ImagePart childPart = new ImagePart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a ImagePart to the DiagramDataPart.
    /// </summary>
    /// <param name="partType">The part type of the ImagePart.</param>
    /// <returns>The newly added part.</returns>
     public ImagePart AddImagePart(ImagePartType partType)
    {
        string contentType = ImagePartTypeInfo.GetContentType(partType);
        string partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddImagePart(contentType);
    }
    
    /// <summary>
    /// Adds a ImagePart to the DiagramDataPart.
    /// </summary>
    /// <param name="contentType">the content type of the ImagePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public ImagePart AddImagePart(string contentType, string id)
    {
        ImagePart childPart = new ImagePart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a ImagePart to the DiagramDataPart.
    /// </summary>
    /// <param name="partType">The part type of the ImagePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public ImagePart AddImagePart(ImagePartType partType, string id)
    {
        string contentType = ImagePartTypeInfo.GetContentType(partType);
        string partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddImagePart(contentType, id);
    }
 
    
    
   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramData";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.openxmlformats-officedocument.drawingml.diagramData+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@"../graphics";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"data";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    

        /// <summary>
        /// Gets the ImageParts of the DiagramDataPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<ImagePart> ImageParts
        {
            get{
                    return this.GetPartsOfType<ImagePart>();
                }
        }
                
        /// <summary>
        /// Gets the SlideParts of the DiagramDataPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<SlidePart> SlideParts
        {
            get{
                    return this.GetPartsOfType<SlidePart>();
                }
        }
                
        /// <summary>
        /// Gets the WorksheetParts of the DiagramDataPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<WorksheetPart> WorksheetParts
        {
            get{
                    return this.GetPartsOfType<WorksheetPart>();
                }
        }
                


    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the DiagramLayoutDefinitionPart.
/// </summary>
public partial class DiagramLayoutDefinitionPart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/image", new PartConstraintRule("ImagePart", null, false, true,(FileFormatVersions)7 ));

            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of DiagramLayoutDefinitionPart
    /// </summary>
    internal protected DiagramLayoutDefinitionPart()
            : base()
    {
    }
    
    
    /// <summary>
    /// Create an instance of OpenXmlPart according to the given relationship type
    /// </summary>
    /// <param name="relationshipType">Relationship type</param>
    /// <returns>An instance of OpenXmlPart</returns>
    internal sealed override OpenXmlPart CreatePartCore(string relationshipType)
    {
        this.ThrowIfObjectDisposed();

        if ( relationshipType == null )
        {
            throw new ArgumentNullException("relationshipType");
        }
        switch (relationshipType)
        {
        case ImagePart.RelationshipTypeConstant:
                    return new ImagePart();
            

        }
        throw new ArgumentOutOfRangeException("relationshipType");
    }
    

        /// <summary>
    /// Adds a ImagePart to the DiagramLayoutDefinitionPart.
    /// </summary>
    /// <param name="contentType">the content type of the ImagePart.</param>
    /// <returns>The newly added part.</returns>
    public ImagePart AddImagePart(string contentType)
    {
        ImagePart childPart = new ImagePart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a ImagePart to the DiagramLayoutDefinitionPart.
    /// </summary>
    /// <param name="partType">The part type of the ImagePart.</param>
    /// <returns>The newly added part.</returns>
     public ImagePart AddImagePart(ImagePartType partType)
    {
        string contentType = ImagePartTypeInfo.GetContentType(partType);
        string partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddImagePart(contentType);
    }
    
    /// <summary>
    /// Adds a ImagePart to the DiagramLayoutDefinitionPart.
    /// </summary>
    /// <param name="contentType">the content type of the ImagePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public ImagePart AddImagePart(string contentType, string id)
    {
        ImagePart childPart = new ImagePart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a ImagePart to the DiagramLayoutDefinitionPart.
    /// </summary>
    /// <param name="partType">The part type of the ImagePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public ImagePart AddImagePart(ImagePartType partType, string id)
    {
        string contentType = ImagePartTypeInfo.GetContentType(partType);
        string partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddImagePart(contentType, id);
    }
 
    
    
   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramLayout";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.openxmlformats-officedocument.drawingml.diagramLayout+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@"../graphics";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"layout";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    

        /// <summary>
        /// Gets the ImageParts of the DiagramLayoutDefinitionPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<ImagePart> ImageParts
        {
            get{
                    return this.GetPartsOfType<ImagePart>();
                }
        }
                


    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the DiagramStylePart.
/// </summary>
public partial class DiagramStylePart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of DiagramStylePart
    /// </summary>
    internal protected DiagramStylePart()
            : base()
    {
    }
    
    

   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramQuickStyle";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.openxmlformats-officedocument.drawingml.diagramStyle+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@"../graphics";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"quickStyle";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    



    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the ThemePart.
/// </summary>
public partial class ThemePart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/image", new PartConstraintRule("ImagePart", null, false, true,(FileFormatVersions)7 ));

            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of ThemePart
    /// </summary>
    internal protected ThemePart()
            : base()
    {
    }
    
    
    /// <summary>
    /// Create an instance of OpenXmlPart according to the given relationship type
    /// </summary>
    /// <param name="relationshipType">Relationship type</param>
    /// <returns>An instance of OpenXmlPart</returns>
    internal sealed override OpenXmlPart CreatePartCore(string relationshipType)
    {
        this.ThrowIfObjectDisposed();

        if ( relationshipType == null )
        {
            throw new ArgumentNullException("relationshipType");
        }
        switch (relationshipType)
        {
        case ImagePart.RelationshipTypeConstant:
                    return new ImagePart();
            

        }
        throw new ArgumentOutOfRangeException("relationshipType");
    }
    

        /// <summary>
    /// Adds a ImagePart to the ThemePart.
    /// </summary>
    /// <param name="contentType">the content type of the ImagePart.</param>
    /// <returns>The newly added part.</returns>
    public ImagePart AddImagePart(string contentType)
    {
        ImagePart childPart = new ImagePart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a ImagePart to the ThemePart.
    /// </summary>
    /// <param name="partType">The part type of the ImagePart.</param>
    /// <returns>The newly added part.</returns>
     public ImagePart AddImagePart(ImagePartType partType)
    {
        string contentType = ImagePartTypeInfo.GetContentType(partType);
        string partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddImagePart(contentType);
    }
    
    /// <summary>
    /// Adds a ImagePart to the ThemePart.
    /// </summary>
    /// <param name="contentType">the content type of the ImagePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public ImagePart AddImagePart(string contentType, string id)
    {
        ImagePart childPart = new ImagePart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a ImagePart to the ThemePart.
    /// </summary>
    /// <param name="partType">The part type of the ImagePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public ImagePart AddImagePart(ImagePartType partType, string id)
    {
        string contentType = ImagePartTypeInfo.GetContentType(partType);
        string partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddImagePart(contentType, id);
    }
 
    
    
   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/officeDocument/2006/relationships/theme";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.openxmlformats-officedocument.theme+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@"theme";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"theme";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    

        /// <summary>
        /// Gets the ImageParts of the ThemePart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<ImagePart> ImageParts
        {
            get{
                    return this.GetPartsOfType<ImagePart>();
                }
        }
                


    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the ThemeOverridePart.
/// </summary>
public partial class ThemeOverridePart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/image", new PartConstraintRule("ImagePart", null, false, true,(FileFormatVersions)7 ));

            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of ThemeOverridePart
    /// </summary>
    internal protected ThemeOverridePart()
            : base()
    {
    }
    
    
    /// <summary>
    /// Create an instance of OpenXmlPart according to the given relationship type
    /// </summary>
    /// <param name="relationshipType">Relationship type</param>
    /// <returns>An instance of OpenXmlPart</returns>
    internal sealed override OpenXmlPart CreatePartCore(string relationshipType)
    {
        this.ThrowIfObjectDisposed();

        if ( relationshipType == null )
        {
            throw new ArgumentNullException("relationshipType");
        }
        switch (relationshipType)
        {
        case ImagePart.RelationshipTypeConstant:
                    return new ImagePart();
            

        }
        throw new ArgumentOutOfRangeException("relationshipType");
    }
    

        /// <summary>
    /// Adds a ImagePart to the ThemeOverridePart.
    /// </summary>
    /// <param name="contentType">the content type of the ImagePart.</param>
    /// <returns>The newly added part.</returns>
    public ImagePart AddImagePart(string contentType)
    {
        ImagePart childPart = new ImagePart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a ImagePart to the ThemeOverridePart.
    /// </summary>
    /// <param name="partType">The part type of the ImagePart.</param>
    /// <returns>The newly added part.</returns>
     public ImagePart AddImagePart(ImagePartType partType)
    {
        string contentType = ImagePartTypeInfo.GetContentType(partType);
        string partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddImagePart(contentType);
    }
    
    /// <summary>
    /// Adds a ImagePart to the ThemeOverridePart.
    /// </summary>
    /// <param name="contentType">the content type of the ImagePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public ImagePart AddImagePart(string contentType, string id)
    {
        ImagePart childPart = new ImagePart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a ImagePart to the ThemeOverridePart.
    /// </summary>
    /// <param name="partType">The part type of the ImagePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public ImagePart AddImagePart(ImagePartType partType, string id)
    {
        string contentType = ImagePartTypeInfo.GetContentType(partType);
        string partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddImagePart(contentType, id);
    }
 
    
    
   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/officeDocument/2006/relationships/themeOverride";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.openxmlformats-officedocument.themeOverride+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@"theme";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"themeoverride";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    

        /// <summary>
        /// Gets the ImageParts of the ThemeOverridePart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<ImagePart> ImageParts
        {
            get{
                    return this.GetPartsOfType<ImagePart>();
                }
        }
                


    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the TableStylesPart.
/// </summary>
public partial class TableStylesPart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of TableStylesPart
    /// </summary>
    internal protected TableStylesPart()
            : base()
    {
    }
    
    

   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/officeDocument/2006/relationships/tableStyles";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.openxmlformats-officedocument.presentationml.tableStyles+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@".";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"tableStyles";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    



    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the CustomXmlPart.
/// </summary>
public partial class CustomXmlPart : OpenXmlPart 
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/customXmlProps", new PartConstraintRule("CustomXmlPropertiesPart", CustomXmlPropertiesPart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));

            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of CustomXmlPart
    /// </summary>
    internal protected CustomXmlPart()
            : base()
    {
    }
    
    
    /// <summary>
    /// Create an instance of OpenXmlPart according to the given relationship type
    /// </summary>
    /// <param name="relationshipType">Relationship type</param>
    /// <returns>An instance of OpenXmlPart</returns>
    internal sealed override OpenXmlPart CreatePartCore(string relationshipType)
    {
        this.ThrowIfObjectDisposed();

        if ( relationshipType == null )
        {
            throw new ArgumentNullException("relationshipType");
        }
        switch (relationshipType)
        {
        case CustomXmlPropertiesPart.RelationshipTypeConstant:
                    return new CustomXmlPropertiesPart();        
            

        }
        throw new ArgumentOutOfRangeException("relationshipType");
    }
    

     
    
    
   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/officeDocument/2006/relationships/customXml";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@"../customXML";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"item";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    

        /// <summary>
        /// Gets the CustomXmlPropertiesPart of the CustomXmlPart.
        /// </summary>
        public CustomXmlPropertiesPart CustomXmlPropertiesPart
        {
            get {return GetSubPartOfType<CustomXmlPropertiesPart>(); }
        }


    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return false; }
    }
}
/// <summary>
/// Defines the CustomXmlPropertiesPart.
/// </summary>
public partial class CustomXmlPropertiesPart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of CustomXmlPropertiesPart
    /// </summary>
    internal protected CustomXmlPropertiesPart()
            : base()
    {
    }
    
    

   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/officeDocument/2006/relationships/customXmlProps";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.openxmlformats-officedocument.customXmlProperties+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@".";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"itemProps";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    



    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the EmbeddedControlPersistencePart.
/// </summary>
public partial class EmbeddedControlPersistencePart : OpenXmlPart 
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            tempData.Add("http://schemas.microsoft.com/office/2006/relationships/activeXControlBinary", new PartConstraintRule("EmbeddedControlPersistenceBinaryDataPart", null, false, true,(FileFormatVersions)7 ));

            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of EmbeddedControlPersistencePart
    /// </summary>
    internal protected EmbeddedControlPersistencePart()
            : base()
    {
    }
    
    
    /// <summary>
    /// Create an instance of OpenXmlPart according to the given relationship type
    /// </summary>
    /// <param name="relationshipType">Relationship type</param>
    /// <returns>An instance of OpenXmlPart</returns>
    internal sealed override OpenXmlPart CreatePartCore(string relationshipType)
    {
        this.ThrowIfObjectDisposed();

        if ( relationshipType == null )
        {
            throw new ArgumentNullException("relationshipType");
        }
        switch (relationshipType)
        {
        case EmbeddedControlPersistenceBinaryDataPart.RelationshipTypeConstant:
                    return new EmbeddedControlPersistenceBinaryDataPart();
            

        }
        throw new ArgumentOutOfRangeException("relationshipType");
    }
    

        /// <summary>
    /// Adds a EmbeddedControlPersistenceBinaryDataPart to the EmbeddedControlPersistencePart.
    /// </summary>
    /// <param name="contentType">the content type of the EmbeddedControlPersistenceBinaryDataPart.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedControlPersistenceBinaryDataPart AddEmbeddedControlPersistenceBinaryDataPart(string contentType)
    {
        EmbeddedControlPersistenceBinaryDataPart childPart = new EmbeddedControlPersistenceBinaryDataPart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a EmbeddedControlPersistenceBinaryDataPart to the EmbeddedControlPersistencePart.
    /// </summary>
    /// <param name="partType">The part type of the EmbeddedControlPersistenceBinaryDataPart.</param>
    /// <returns>The newly added part.</returns>
     public EmbeddedControlPersistenceBinaryDataPart AddEmbeddedControlPersistenceBinaryDataPart(EmbeddedControlPersistenceBinaryDataPartType partType)
    {
        string contentType = EmbeddedControlPersistenceBinaryDataPartTypeInfo.GetContentType(partType);
        string partExtension = EmbeddedControlPersistenceBinaryDataPartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddEmbeddedControlPersistenceBinaryDataPart(contentType);
    }
    
    /// <summary>
    /// Adds a EmbeddedControlPersistenceBinaryDataPart to the EmbeddedControlPersistencePart.
    /// </summary>
    /// <param name="contentType">the content type of the EmbeddedControlPersistenceBinaryDataPart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedControlPersistenceBinaryDataPart AddEmbeddedControlPersistenceBinaryDataPart(string contentType, string id)
    {
        EmbeddedControlPersistenceBinaryDataPart childPart = new EmbeddedControlPersistenceBinaryDataPart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a EmbeddedControlPersistenceBinaryDataPart to the EmbeddedControlPersistencePart.
    /// </summary>
    /// <param name="partType">The part type of the EmbeddedControlPersistenceBinaryDataPart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public EmbeddedControlPersistenceBinaryDataPart AddEmbeddedControlPersistenceBinaryDataPart(EmbeddedControlPersistenceBinaryDataPartType partType, string id)
    {
        string contentType = EmbeddedControlPersistenceBinaryDataPartTypeInfo.GetContentType(partType);
        string partExtension = EmbeddedControlPersistenceBinaryDataPartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddEmbeddedControlPersistenceBinaryDataPart(contentType, id);
    }
 
    
    
   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/officeDocument/2006/relationships/control";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@"embeddings";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"control";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetFileExtension
    /// </summary>
    internal const System.String TargetFileExtensionConstant =@".bin";
    /// <summary>
    /// Gets the TargetFileExtension.
    /// </summary>
    internal sealed override string TargetFileExtension
    {
       get { return TargetFileExtensionConstant; }
    } 
    

        /// <summary>
        /// Gets the EmbeddedControlPersistenceBinaryDataParts of the EmbeddedControlPersistencePart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<EmbeddedControlPersistenceBinaryDataPart> EmbeddedControlPersistenceBinaryDataParts
        {
            get{
                    return this.GetPartsOfType<EmbeddedControlPersistenceBinaryDataPart>();
                }
        }
                


    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return false; }
    }
}
/// <summary>
/// Defines the EmbeddedObjectPart.
/// </summary>
public partial class EmbeddedObjectPart : OpenXmlPart 
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of EmbeddedObjectPart
    /// </summary>
    internal protected EmbeddedObjectPart()
            : base()
    {
    }
    
    

   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/officeDocument/2006/relationships/oleObject";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@"embeddings";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"embeddedObject";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetFileExtension
    /// </summary>
    internal const System.String TargetFileExtensionConstant =@".bin";
    /// <summary>
    /// Gets the TargetFileExtension.
    /// </summary>
    internal sealed override string TargetFileExtension
    {
       get { return TargetFileExtensionConstant; }
    } 
    



    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return false; }
    }
}
/// <summary>
/// Defines the EmbeddedPackagePart.
/// </summary>
public partial class EmbeddedPackagePart : OpenXmlPart 
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of EmbeddedPackagePart
    /// </summary>
    internal protected EmbeddedPackagePart()
            : base()
    {
    }
    
    

   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/officeDocument/2006/relationships/package";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@"embeddings";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"package";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetFileExtension
    /// </summary>
    internal const System.String TargetFileExtensionConstant =@".bin";
    /// <summary>
    /// Gets the TargetFileExtension.
    /// </summary>
    internal sealed override string TargetFileExtension
    {
       get { return TargetFileExtensionConstant; }
    } 
    



    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return false; }
    }
}
/// <summary>
/// Defines the FontPart.
/// </summary>
public partial class FontPart : OpenXmlPart 
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of FontPart
    /// </summary>
    internal protected FontPart()
            : base()
    {
    }
    
    

   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/officeDocument/2006/relationships/font";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@"fonts";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"font";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetFileExtension
    /// </summary>
    internal const System.String TargetFileExtensionConstant =@".dat";
    /// <summary>
    /// Gets the TargetFileExtension.
    /// </summary>
    internal sealed override string TargetFileExtension
    {
       get { return TargetFileExtensionConstant; }
    } 
    



    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return false; }
    }
}
/// <summary>
/// Defines the SpreadsheetPrinterSettingsPart.
/// </summary>
public partial class SpreadsheetPrinterSettingsPart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of SpreadsheetPrinterSettingsPart
    /// </summary>
    internal protected SpreadsheetPrinterSettingsPart()
            : base()
    {
    }
    
    

   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/officeDocument/2006/relationships/printerSettings";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.openxmlformats-officedocument.spreadsheetml.printerSettings";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@"../printerSettings";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"printerSettings";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetFileExtension
    /// </summary>
    internal const System.String TargetFileExtensionConstant =@".bin";
    /// <summary>
    /// Gets the TargetFileExtension.
    /// </summary>
    internal sealed override string TargetFileExtension
    {
       get { return TargetFileExtensionConstant; }
    } 
    



    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the WordprocessingPrinterSettingsPart.
/// </summary>
public partial class WordprocessingPrinterSettingsPart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of WordprocessingPrinterSettingsPart
    /// </summary>
    internal protected WordprocessingPrinterSettingsPart()
            : base()
    {
    }
    
    

   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/officeDocument/2006/relationships/printerSettings";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.openxmlformats-officedocument.wordprocessingml.printerSettings";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@"../printerSettings";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"printerSettings";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetFileExtension
    /// </summary>
    internal const System.String TargetFileExtensionConstant =@".bin";
    /// <summary>
    /// Gets the TargetFileExtension.
    /// </summary>
    internal sealed override string TargetFileExtension
    {
       get { return TargetFileExtensionConstant; }
    } 
    



    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the ImagePart.
/// </summary>
public partial class ImagePart : OpenXmlPart 
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of ImagePart
    /// </summary>
    internal protected ImagePart()
            : base()
    {
    }
    
    

   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/officeDocument/2006/relationships/image";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@"../media";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"image";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetFileExtension
    /// </summary>
    internal const System.String TargetFileExtensionConstant =@".bin";
    /// <summary>
    /// Gets the TargetFileExtension.
    /// </summary>
    internal sealed override string TargetFileExtension
    {
       get { return TargetFileExtensionConstant; }
    } 
    



    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return false; }
    }
}
/// <summary>
/// Defines the VmlDrawingPart.
/// </summary>
public partial class VmlDrawingPart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/image", new PartConstraintRule("ImagePart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.microsoft.com/office/2006/relationships/legacyDiagramText", new PartConstraintRule("LegacyDiagramTextPart", LegacyDiagramTextPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));

            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of VmlDrawingPart
    /// </summary>
    internal protected VmlDrawingPart()
            : base()
    {
    }
    
    
    /// <summary>
    /// Create an instance of OpenXmlPart according to the given relationship type
    /// </summary>
    /// <param name="relationshipType">Relationship type</param>
    /// <returns>An instance of OpenXmlPart</returns>
    internal sealed override OpenXmlPart CreatePartCore(string relationshipType)
    {
        this.ThrowIfObjectDisposed();

        if ( relationshipType == null )
        {
            throw new ArgumentNullException("relationshipType");
        }
        switch (relationshipType)
        {
        case ImagePart.RelationshipTypeConstant:
                    return new ImagePart();
            
        case LegacyDiagramTextPart.RelationshipTypeConstant:
                    return new LegacyDiagramTextPart();        
            

        }
        throw new ArgumentOutOfRangeException("relationshipType");
    }
    

        /// <summary>
    /// Adds a ImagePart to the VmlDrawingPart.
    /// </summary>
    /// <param name="contentType">the content type of the ImagePart.</param>
    /// <returns>The newly added part.</returns>
    public ImagePart AddImagePart(string contentType)
    {
        ImagePart childPart = new ImagePart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a ImagePart to the VmlDrawingPart.
    /// </summary>
    /// <param name="partType">The part type of the ImagePart.</param>
    /// <returns>The newly added part.</returns>
     public ImagePart AddImagePart(ImagePartType partType)
    {
        string contentType = ImagePartTypeInfo.GetContentType(partType);
        string partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddImagePart(contentType);
    }
    
    /// <summary>
    /// Adds a ImagePart to the VmlDrawingPart.
    /// </summary>
    /// <param name="contentType">the content type of the ImagePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public ImagePart AddImagePart(string contentType, string id)
    {
        ImagePart childPart = new ImagePart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a ImagePart to the VmlDrawingPart.
    /// </summary>
    /// <param name="partType">The part type of the ImagePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public ImagePart AddImagePart(ImagePartType partType, string id)
    {
        string contentType = ImagePartTypeInfo.GetContentType(partType);
        string partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddImagePart(contentType, id);
    }
 
    
    
   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/officeDocument/2006/relationships/vmlDrawing";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.openxmlformats-officedocument.vmlDrawing";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@"../drawings";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"vmldrawing";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetFileExtension
    /// </summary>
    internal const System.String TargetFileExtensionConstant =@".vml";
    /// <summary>
    /// Gets the TargetFileExtension.
    /// </summary>
    internal sealed override string TargetFileExtension
    {
       get { return TargetFileExtensionConstant; }
    } 
    

        /// <summary>
        /// Gets the ImageParts of the VmlDrawingPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<ImagePart> ImageParts
        {
            get{
                    return this.GetPartsOfType<ImagePart>();
                }
        }
                
        /// <summary>
        /// Gets the LegacyDiagramTextParts of the VmlDrawingPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<LegacyDiagramTextPart> LegacyDiagramTextParts
        {
            get{
                    return this.GetPartsOfType<LegacyDiagramTextPart>();
                }
        }
                


    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the EmbeddedControlPersistenceBinaryDataPart.
/// </summary>
public partial class EmbeddedControlPersistenceBinaryDataPart : OpenXmlPart 
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of EmbeddedControlPersistenceBinaryDataPart
    /// </summary>
    internal protected EmbeddedControlPersistenceBinaryDataPart()
            : base()
    {
    }
    
    

   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.microsoft.com/office/2006/relationships/activeXControlBinary";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@".";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"ActiveXControl";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetFileExtension
    /// </summary>
    internal const System.String TargetFileExtensionConstant =@".bin";
    /// <summary>
    /// Gets the TargetFileExtension.
    /// </summary>
    internal sealed override string TargetFileExtension
    {
       get { return TargetFileExtensionConstant; }
    } 
    



    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return false; }
    }
}
/// <summary>
/// Defines the QuickAccessToolbarCustomizationsPart.
/// </summary>
public partial class QuickAccessToolbarCustomizationsPart : CustomUIPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of QuickAccessToolbarCustomizationsPart
    /// </summary>
    internal protected QuickAccessToolbarCustomizationsPart()
            : base()
    {
    }
    
    

   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.microsoft.com/office/2006/relationships/ui/userCustomization";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@"userCustomization";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"customUI";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    



    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the RibbonExtensibilityPart.
/// </summary>
public partial class RibbonExtensibilityPart : CustomUIPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/image", new PartConstraintRule("ImagePart", null, false, true,(FileFormatVersions)7 ));

            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of RibbonExtensibilityPart
    /// </summary>
    internal protected RibbonExtensibilityPart()
            : base()
    {
    }
    
    
    /// <summary>
    /// Create an instance of OpenXmlPart according to the given relationship type
    /// </summary>
    /// <param name="relationshipType">Relationship type</param>
    /// <returns>An instance of OpenXmlPart</returns>
    internal sealed override OpenXmlPart CreatePartCore(string relationshipType)
    {
        this.ThrowIfObjectDisposed();

        if ( relationshipType == null )
        {
            throw new ArgumentNullException("relationshipType");
        }
        switch (relationshipType)
        {
        case ImagePart.RelationshipTypeConstant:
                    return new ImagePart();
            

        }
        throw new ArgumentOutOfRangeException("relationshipType");
    }
    

        /// <summary>
    /// Adds a ImagePart to the RibbonExtensibilityPart.
    /// </summary>
    /// <param name="contentType">the content type of the ImagePart.</param>
    /// <returns>The newly added part.</returns>
    public ImagePart AddImagePart(string contentType)
    {
        ImagePart childPart = new ImagePart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a ImagePart to the RibbonExtensibilityPart.
    /// </summary>
    /// <param name="partType">The part type of the ImagePart.</param>
    /// <returns>The newly added part.</returns>
     public ImagePart AddImagePart(ImagePartType partType)
    {
        string contentType = ImagePartTypeInfo.GetContentType(partType);
        string partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddImagePart(contentType);
    }
    
    /// <summary>
    /// Adds a ImagePart to the RibbonExtensibilityPart.
    /// </summary>
    /// <param name="contentType">the content type of the ImagePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public ImagePart AddImagePart(string contentType, string id)
    {
        ImagePart childPart = new ImagePart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a ImagePart to the RibbonExtensibilityPart.
    /// </summary>
    /// <param name="partType">The part type of the ImagePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public ImagePart AddImagePart(ImagePartType partType, string id)
    {
        string contentType = ImagePartTypeInfo.GetContentType(partType);
        string partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddImagePart(contentType, id);
    }
 
    
    
   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.microsoft.com/office/2006/relationships/ui/extensibility";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@"customUI";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"customUI";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    

        /// <summary>
        /// Gets the ImageParts of the RibbonExtensibilityPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<ImagePart> ImageParts
        {
            get{
                    return this.GetPartsOfType<ImagePart>();
                }
        }
                


    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the VbaProjectPart.
/// </summary>
public partial class VbaProjectPart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            tempData.Add("http://schemas.microsoft.com/office/2006/relationships/wordVbaData", new PartConstraintRule("VbaDataPart", VbaDataPart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));

            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of VbaProjectPart
    /// </summary>
    internal protected VbaProjectPart()
            : base()
    {
    }
    
    
    /// <summary>
    /// Create an instance of OpenXmlPart according to the given relationship type
    /// </summary>
    /// <param name="relationshipType">Relationship type</param>
    /// <returns>An instance of OpenXmlPart</returns>
    internal sealed override OpenXmlPart CreatePartCore(string relationshipType)
    {
        this.ThrowIfObjectDisposed();

        if ( relationshipType == null )
        {
            throw new ArgumentNullException("relationshipType");
        }
        switch (relationshipType)
        {
        case VbaDataPart.RelationshipTypeConstant:
                    return new VbaDataPart();        
            

        }
        throw new ArgumentOutOfRangeException("relationshipType");
    }
    

     
    
    
   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.microsoft.com/office/2006/relationships/vbaProject";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.ms-office.vbaProject";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@".";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"vbaProject";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    

        /// <summary>
        /// Gets the VbaDataPart of the VbaProjectPart.
        /// </summary>
        public VbaDataPart VbaDataPart
        {
            get {return GetSubPartOfType<VbaDataPart>(); }
        }


    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the VbaDataPart.
/// </summary>
public partial class VbaDataPart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of VbaDataPart
    /// </summary>
    internal protected VbaDataPart()
            : base()
    {
    }
    
    

   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.microsoft.com/office/2006/relationships/wordVbaData";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.ms-word.vbaData+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@".";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"vbaData";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    



    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the MacroSheetPart.
/// </summary>
public partial class MacroSheetPart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/printerSettings", new PartConstraintRule("SpreadsheetPrinterSettingsPart", SpreadsheetPrinterSettingsPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/drawing", new PartConstraintRule("DrawingsPart", DrawingsPart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/vmlDrawing", new PartConstraintRule("VmlDrawingPart", VmlDrawingPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/comments", new PartConstraintRule("WorksheetCommentsPart", WorksheetCommentsPart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/customProperty", new PartConstraintRule("CustomPropertyPart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/oleObject", new PartConstraintRule("EmbeddedObjectPart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/package", new PartConstraintRule("EmbeddedPackagePart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/image", new PartConstraintRule("ImagePart", null, false, true,(FileFormatVersions)7 ));

            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of MacroSheetPart
    /// </summary>
    internal protected MacroSheetPart()
            : base()
    {
    }
    
    
    /// <summary>
    /// Create an instance of OpenXmlPart according to the given relationship type
    /// </summary>
    /// <param name="relationshipType">Relationship type</param>
    /// <returns>An instance of OpenXmlPart</returns>
    internal sealed override OpenXmlPart CreatePartCore(string relationshipType)
    {
        this.ThrowIfObjectDisposed();

        if ( relationshipType == null )
        {
            throw new ArgumentNullException("relationshipType");
        }
        switch (relationshipType)
        {
        case SpreadsheetPrinterSettingsPart.RelationshipTypeConstant:
                    return new SpreadsheetPrinterSettingsPart();        
            
        case DrawingsPart.RelationshipTypeConstant:
                    return new DrawingsPart();        
            
        case VmlDrawingPart.RelationshipTypeConstant:
                    return new VmlDrawingPart();        
            
        case WorksheetCommentsPart.RelationshipTypeConstant:
                    return new WorksheetCommentsPart();        
            
        case CustomPropertyPart.RelationshipTypeConstant:
                    return new CustomPropertyPart();
            
        case EmbeddedObjectPart.RelationshipTypeConstant:
                    return new EmbeddedObjectPart();
            
        case EmbeddedPackagePart.RelationshipTypeConstant:
                    return new EmbeddedPackagePart();
            
        case ImagePart.RelationshipTypeConstant:
                    return new ImagePart();
            

        }
        throw new ArgumentOutOfRangeException("relationshipType");
    }
    

        /// <summary>
    /// Adds a CustomPropertyPart to the MacroSheetPart.
    /// </summary>
    /// <param name="contentType">the content type of the CustomPropertyPart.</param>
    /// <returns>The newly added part.</returns>
    public CustomPropertyPart AddCustomPropertyPart(string contentType)
    {
        CustomPropertyPart childPart = new CustomPropertyPart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a CustomPropertyPart to the MacroSheetPart.
    /// </summary>
    /// <param name="partType">The part type of the CustomPropertyPart.</param>
    /// <returns>The newly added part.</returns>
     public CustomPropertyPart AddCustomPropertyPart(CustomPropertyPartType partType)
    {
        string contentType = CustomPropertyPartTypeInfo.GetContentType(partType);
        string partExtension = CustomPropertyPartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddCustomPropertyPart(contentType);
    }
    
    /// <summary>
    /// Adds a CustomPropertyPart to the MacroSheetPart.
    /// </summary>
    /// <param name="contentType">the content type of the CustomPropertyPart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public CustomPropertyPart AddCustomPropertyPart(string contentType, string id)
    {
        CustomPropertyPart childPart = new CustomPropertyPart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a CustomPropertyPart to the MacroSheetPart.
    /// </summary>
    /// <param name="partType">The part type of the CustomPropertyPart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public CustomPropertyPart AddCustomPropertyPart(CustomPropertyPartType partType, string id)
    {
        string contentType = CustomPropertyPartTypeInfo.GetContentType(partType);
        string partExtension = CustomPropertyPartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddCustomPropertyPart(contentType, id);
    }
	/// <summary>
    /// Adds a EmbeddedObjectPart to the MacroSheetPart.
    /// </summary>
    /// <param name="contentType">The content type of the EmbeddedObjectPart.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedObjectPart AddEmbeddedObjectPart(string contentType)
    {
        EmbeddedObjectPart childPart = new EmbeddedObjectPart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
	/// <summary>
    /// Adds a EmbeddedPackagePart to the MacroSheetPart.
    /// </summary>
    /// <param name="contentType">The content type of the EmbeddedPackagePart.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedPackagePart AddEmbeddedPackagePart(string contentType)
    {
        EmbeddedPackagePart childPart = new EmbeddedPackagePart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a ImagePart to the MacroSheetPart.
    /// </summary>
    /// <param name="contentType">the content type of the ImagePart.</param>
    /// <returns>The newly added part.</returns>
    public ImagePart AddImagePart(string contentType)
    {
        ImagePart childPart = new ImagePart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a ImagePart to the MacroSheetPart.
    /// </summary>
    /// <param name="partType">The part type of the ImagePart.</param>
    /// <returns>The newly added part.</returns>
     public ImagePart AddImagePart(ImagePartType partType)
    {
        string contentType = ImagePartTypeInfo.GetContentType(partType);
        string partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddImagePart(contentType);
    }
    
    /// <summary>
    /// Adds a ImagePart to the MacroSheetPart.
    /// </summary>
    /// <param name="contentType">the content type of the ImagePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public ImagePart AddImagePart(string contentType, string id)
    {
        ImagePart childPart = new ImagePart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a ImagePart to the MacroSheetPart.
    /// </summary>
    /// <param name="partType">The part type of the ImagePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public ImagePart AddImagePart(ImagePartType partType, string id)
    {
        string contentType = ImagePartTypeInfo.GetContentType(partType);
        string partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddImagePart(contentType, id);
    }
 
    
    
   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.microsoft.com/office/2006/relationships/xlMacrosheet";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.ms-excel.macrosheet+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@"macrosheets";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"sheet";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    

        /// <summary>
        /// Gets the SpreadsheetPrinterSettingsParts of the MacroSheetPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<SpreadsheetPrinterSettingsPart> SpreadsheetPrinterSettingsParts
        {
            get{
                    return this.GetPartsOfType<SpreadsheetPrinterSettingsPart>();
                }
        }
                
        /// <summary>
        /// Gets the DrawingsPart of the MacroSheetPart.
        /// </summary>
        public DrawingsPart DrawingsPart
        {
            get {return GetSubPartOfType<DrawingsPart>(); }
        }
        /// <summary>
        /// Gets the VmlDrawingParts of the MacroSheetPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<VmlDrawingPart> VmlDrawingParts
        {
            get{
                    return this.GetPartsOfType<VmlDrawingPart>();
                }
        }
                
        /// <summary>
        /// Gets the WorksheetCommentsPart of the MacroSheetPart.
        /// </summary>
        public WorksheetCommentsPart WorksheetCommentsPart
        {
            get {return GetSubPartOfType<WorksheetCommentsPart>(); }
        }
        /// <summary>
        /// Gets the CustomPropertyParts of the MacroSheetPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<CustomPropertyPart> CustomPropertyParts
        {
            get{
                    return this.GetPartsOfType<CustomPropertyPart>();
                }
        }
                
        /// <summary>
        /// Gets the EmbeddedObjectParts of the MacroSheetPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<EmbeddedObjectPart> EmbeddedObjectParts
        {
            get{
                    return this.GetPartsOfType<EmbeddedObjectPart>();
                }
        }
                
        /// <summary>
        /// Gets the EmbeddedPackageParts of the MacroSheetPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<EmbeddedPackagePart> EmbeddedPackageParts
        {
            get{
                    return this.GetPartsOfType<EmbeddedPackagePart>();
                }
        }
                
        /// <summary>
        /// Gets the ImageParts of the MacroSheetPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<ImagePart> ImageParts
        {
            get{
                    return this.GetPartsOfType<ImagePart>();
                }
        }
                


    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the InternationalMacroSheetPart.
/// </summary>
public partial class InternationalMacroSheetPart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/printerSettings", new PartConstraintRule("SpreadsheetPrinterSettingsPart", SpreadsheetPrinterSettingsPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/drawing", new PartConstraintRule("DrawingsPart", DrawingsPart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/vmlDrawing", new PartConstraintRule("VmlDrawingPart", VmlDrawingPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/comments", new PartConstraintRule("WorksheetCommentsPart", WorksheetCommentsPart.ContentTypeConstant, false, false,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/customProperty", new PartConstraintRule("CustomPropertyPart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/oleObject", new PartConstraintRule("EmbeddedObjectPart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/package", new PartConstraintRule("EmbeddedPackagePart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/image", new PartConstraintRule("ImagePart", null, false, true,(FileFormatVersions)7 ));

            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of InternationalMacroSheetPart
    /// </summary>
    internal protected InternationalMacroSheetPart()
            : base()
    {
    }
    
    
    /// <summary>
    /// Create an instance of OpenXmlPart according to the given relationship type
    /// </summary>
    /// <param name="relationshipType">Relationship type</param>
    /// <returns>An instance of OpenXmlPart</returns>
    internal sealed override OpenXmlPart CreatePartCore(string relationshipType)
    {
        this.ThrowIfObjectDisposed();

        if ( relationshipType == null )
        {
            throw new ArgumentNullException("relationshipType");
        }
        switch (relationshipType)
        {
        case SpreadsheetPrinterSettingsPart.RelationshipTypeConstant:
                    return new SpreadsheetPrinterSettingsPart();        
            
        case DrawingsPart.RelationshipTypeConstant:
                    return new DrawingsPart();        
            
        case VmlDrawingPart.RelationshipTypeConstant:
                    return new VmlDrawingPart();        
            
        case WorksheetCommentsPart.RelationshipTypeConstant:
                    return new WorksheetCommentsPart();        
            
        case CustomPropertyPart.RelationshipTypeConstant:
                    return new CustomPropertyPart();
            
        case EmbeddedObjectPart.RelationshipTypeConstant:
                    return new EmbeddedObjectPart();
            
        case EmbeddedPackagePart.RelationshipTypeConstant:
                    return new EmbeddedPackagePart();
            
        case ImagePart.RelationshipTypeConstant:
                    return new ImagePart();
            

        }
        throw new ArgumentOutOfRangeException("relationshipType");
    }
    

        /// <summary>
    /// Adds a CustomPropertyPart to the InternationalMacroSheetPart.
    /// </summary>
    /// <param name="contentType">the content type of the CustomPropertyPart.</param>
    /// <returns>The newly added part.</returns>
    public CustomPropertyPart AddCustomPropertyPart(string contentType)
    {
        CustomPropertyPart childPart = new CustomPropertyPart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a CustomPropertyPart to the InternationalMacroSheetPart.
    /// </summary>
    /// <param name="partType">The part type of the CustomPropertyPart.</param>
    /// <returns>The newly added part.</returns>
     public CustomPropertyPart AddCustomPropertyPart(CustomPropertyPartType partType)
    {
        string contentType = CustomPropertyPartTypeInfo.GetContentType(partType);
        string partExtension = CustomPropertyPartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddCustomPropertyPart(contentType);
    }
    
    /// <summary>
    /// Adds a CustomPropertyPart to the InternationalMacroSheetPart.
    /// </summary>
    /// <param name="contentType">the content type of the CustomPropertyPart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public CustomPropertyPart AddCustomPropertyPart(string contentType, string id)
    {
        CustomPropertyPart childPart = new CustomPropertyPart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a CustomPropertyPart to the InternationalMacroSheetPart.
    /// </summary>
    /// <param name="partType">The part type of the CustomPropertyPart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public CustomPropertyPart AddCustomPropertyPart(CustomPropertyPartType partType, string id)
    {
        string contentType = CustomPropertyPartTypeInfo.GetContentType(partType);
        string partExtension = CustomPropertyPartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddCustomPropertyPart(contentType, id);
    }
	/// <summary>
    /// Adds a EmbeddedObjectPart to the InternationalMacroSheetPart.
    /// </summary>
    /// <param name="contentType">The content type of the EmbeddedObjectPart.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedObjectPart AddEmbeddedObjectPart(string contentType)
    {
        EmbeddedObjectPart childPart = new EmbeddedObjectPart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
	/// <summary>
    /// Adds a EmbeddedPackagePart to the InternationalMacroSheetPart.
    /// </summary>
    /// <param name="contentType">The content type of the EmbeddedPackagePart.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedPackagePart AddEmbeddedPackagePart(string contentType)
    {
        EmbeddedPackagePart childPart = new EmbeddedPackagePart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a ImagePart to the InternationalMacroSheetPart.
    /// </summary>
    /// <param name="contentType">the content type of the ImagePart.</param>
    /// <returns>The newly added part.</returns>
    public ImagePart AddImagePart(string contentType)
    {
        ImagePart childPart = new ImagePart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a ImagePart to the InternationalMacroSheetPart.
    /// </summary>
    /// <param name="partType">The part type of the ImagePart.</param>
    /// <returns>The newly added part.</returns>
     public ImagePart AddImagePart(ImagePartType partType)
    {
        string contentType = ImagePartTypeInfo.GetContentType(partType);
        string partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddImagePart(contentType);
    }
    
    /// <summary>
    /// Adds a ImagePart to the InternationalMacroSheetPart.
    /// </summary>
    /// <param name="contentType">the content type of the ImagePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public ImagePart AddImagePart(string contentType, string id)
    {
        ImagePart childPart = new ImagePart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a ImagePart to the InternationalMacroSheetPart.
    /// </summary>
    /// <param name="partType">The part type of the ImagePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public ImagePart AddImagePart(ImagePartType partType, string id)
    {
        string contentType = ImagePartTypeInfo.GetContentType(partType);
        string partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddImagePart(contentType, id);
    }
 
    
    
   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.microsoft.com/office/2006/relationships/xlIntlMacrosheet";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.ms-excel.intlmacrosheet+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@"macrosheets";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"intlsheet";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    

        /// <summary>
        /// Gets the SpreadsheetPrinterSettingsParts of the InternationalMacroSheetPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<SpreadsheetPrinterSettingsPart> SpreadsheetPrinterSettingsParts
        {
            get{
                    return this.GetPartsOfType<SpreadsheetPrinterSettingsPart>();
                }
        }
                
        /// <summary>
        /// Gets the DrawingsPart of the InternationalMacroSheetPart.
        /// </summary>
        public DrawingsPart DrawingsPart
        {
            get {return GetSubPartOfType<DrawingsPart>(); }
        }
        /// <summary>
        /// Gets the VmlDrawingParts of the InternationalMacroSheetPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<VmlDrawingPart> VmlDrawingParts
        {
            get{
                    return this.GetPartsOfType<VmlDrawingPart>();
                }
        }
                
        /// <summary>
        /// Gets the WorksheetCommentsPart of the InternationalMacroSheetPart.
        /// </summary>
        public WorksheetCommentsPart WorksheetCommentsPart
        {
            get {return GetSubPartOfType<WorksheetCommentsPart>(); }
        }
        /// <summary>
        /// Gets the CustomPropertyParts of the InternationalMacroSheetPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<CustomPropertyPart> CustomPropertyParts
        {
            get{
                    return this.GetPartsOfType<CustomPropertyPart>();
                }
        }
                
        /// <summary>
        /// Gets the EmbeddedObjectParts of the InternationalMacroSheetPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<EmbeddedObjectPart> EmbeddedObjectParts
        {
            get{
                    return this.GetPartsOfType<EmbeddedObjectPart>();
                }
        }
                
        /// <summary>
        /// Gets the EmbeddedPackageParts of the InternationalMacroSheetPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<EmbeddedPackagePart> EmbeddedPackageParts
        {
            get{
                    return this.GetPartsOfType<EmbeddedPackagePart>();
                }
        }
                
        /// <summary>
        /// Gets the ImageParts of the InternationalMacroSheetPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<ImagePart> ImageParts
        {
            get{
                    return this.GetPartsOfType<ImagePart>();
                }
        }
                


    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the DiagramPersistLayoutPart.
/// </summary>
public partial class DiagramPersistLayoutPart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/image", new PartConstraintRule("ImagePart", null, false, true,(FileFormatVersions)7 ));

            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of DiagramPersistLayoutPart
    /// </summary>
    internal protected DiagramPersistLayoutPart()
            : base()
    {
    }
    
    
    /// <summary>
    /// Create an instance of OpenXmlPart according to the given relationship type
    /// </summary>
    /// <param name="relationshipType">Relationship type</param>
    /// <returns>An instance of OpenXmlPart</returns>
    internal sealed override OpenXmlPart CreatePartCore(string relationshipType)
    {
        this.ThrowIfObjectDisposed();

        if ( relationshipType == null )
        {
            throw new ArgumentNullException("relationshipType");
        }
        switch (relationshipType)
        {
        case ImagePart.RelationshipTypeConstant:
                    return new ImagePart();
            

        }
        throw new ArgumentOutOfRangeException("relationshipType");
    }
    

        /// <summary>
    /// Adds a ImagePart to the DiagramPersistLayoutPart.
    /// </summary>
    /// <param name="contentType">the content type of the ImagePart.</param>
    /// <returns>The newly added part.</returns>
    public ImagePart AddImagePart(string contentType)
    {
        ImagePart childPart = new ImagePart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a ImagePart to the DiagramPersistLayoutPart.
    /// </summary>
    /// <param name="partType">The part type of the ImagePart.</param>
    /// <returns>The newly added part.</returns>
     public ImagePart AddImagePart(ImagePartType partType)
    {
        string contentType = ImagePartTypeInfo.GetContentType(partType);
        string partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddImagePart(contentType);
    }
    
    /// <summary>
    /// Adds a ImagePart to the DiagramPersistLayoutPart.
    /// </summary>
    /// <param name="contentType">the content type of the ImagePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public ImagePart AddImagePart(string contentType, string id)
    {
        ImagePart childPart = new ImagePart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a ImagePart to the DiagramPersistLayoutPart.
    /// </summary>
    /// <param name="partType">The part type of the ImagePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public ImagePart AddImagePart(ImagePartType partType, string id)
    {
        string contentType = ImagePartTypeInfo.GetContentType(partType);
        string partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddImagePart(contentType, id);
    }
 
    
    
   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.microsoft.com/office/2007/relationships/diagramDrawing";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.ms-office.drawingml.diagramDrawing+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@"../diagrams";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"drawing";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    

        /// <summary>
        /// Gets the ImageParts of the DiagramPersistLayoutPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<ImagePart> ImageParts
        {
            get{
                    return this.GetPartsOfType<ImagePart>();
                }
        }
                


    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the StylesWithEffectsPart, this part is only available in Office2010.
/// </summary>
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class StylesWithEffectsPart : StylesPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of StylesWithEffectsPart
    /// </summary>
    internal protected StylesWithEffectsPart()
            : base()
    {
    }
    
    

   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.microsoft.com/office/2007/relationships/stylesWithEffects";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.ms-word.stylesWithEffects+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@".";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"stylesWithEffects";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    


    /// <summary>
    /// Whether this part is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the part is defined in the specified version.</returns>
    internal override bool IsInVersion(DocumentFormat.OpenXml.FileFormatVersions version)
    {
		if(version == FileFormatVersions.Office2010)
		{
			return true;
		}
		return false;
    }

    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the RibbonAndBackstageCustomizationsPart, this part is only available in Office2010.
/// </summary>
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class RibbonAndBackstageCustomizationsPart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/image", new PartConstraintRule("ImagePart", null, false, true,(FileFormatVersions)7 ));

            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of RibbonAndBackstageCustomizationsPart
    /// </summary>
    internal protected RibbonAndBackstageCustomizationsPart()
            : base()
    {
    }
    
    
    /// <summary>
    /// Create an instance of OpenXmlPart according to the given relationship type
    /// </summary>
    /// <param name="relationshipType">Relationship type</param>
    /// <returns>An instance of OpenXmlPart</returns>
    internal sealed override OpenXmlPart CreatePartCore(string relationshipType)
    {
        this.ThrowIfObjectDisposed();

        if ( relationshipType == null )
        {
            throw new ArgumentNullException("relationshipType");
        }
        switch (relationshipType)
        {
        case ImagePart.RelationshipTypeConstant:
                    return new ImagePart();
            

        }
        throw new ArgumentOutOfRangeException("relationshipType");
    }
    

        /// <summary>
    /// Adds a ImagePart to the RibbonAndBackstageCustomizationsPart.
    /// </summary>
    /// <param name="contentType">the content type of the ImagePart.</param>
    /// <returns>The newly added part.</returns>
    public ImagePart AddImagePart(string contentType)
    {
        ImagePart childPart = new ImagePart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a ImagePart to the RibbonAndBackstageCustomizationsPart.
    /// </summary>
    /// <param name="partType">The part type of the ImagePart.</param>
    /// <returns>The newly added part.</returns>
     public ImagePart AddImagePart(ImagePartType partType)
    {
        string contentType = ImagePartTypeInfo.GetContentType(partType);
        string partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddImagePart(contentType);
    }
    
    /// <summary>
    /// Adds a ImagePart to the RibbonAndBackstageCustomizationsPart.
    /// </summary>
    /// <param name="contentType">the content type of the ImagePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public ImagePart AddImagePart(string contentType, string id)
    {
        ImagePart childPart = new ImagePart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a ImagePart to the RibbonAndBackstageCustomizationsPart.
    /// </summary>
    /// <param name="partType">The part type of the ImagePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public ImagePart AddImagePart(ImagePartType partType, string id)
    {
        string contentType = ImagePartTypeInfo.GetContentType(partType);
        string partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddImagePart(contentType, id);
    }
 
    
    
   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.microsoft.com/office/2007/relationships/ui/extensibility";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@"customUI";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"customUI";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    

        /// <summary>
        /// Gets the ImageParts of the RibbonAndBackstageCustomizationsPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<ImagePart> ImageParts
        {
            get{
                    return this.GetPartsOfType<ImagePart>();
                }
        }
                

    /// <summary>
    /// Whether this part is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the part is defined in the specified version.</returns>
    internal override bool IsInVersion(DocumentFormat.OpenXml.FileFormatVersions version)
    {
		if(version == FileFormatVersions.Office2010)
		{
			return true;
		}
		return false;
    }

    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the ControlPropertiesPart, this part is only available in Office2010.
/// </summary>
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ControlPropertiesPart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of ControlPropertiesPart
    /// </summary>
    internal protected ControlPropertiesPart()
            : base()
    {
    }
    
    

   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.openxmlformats.org/officeDocument/2006/relationships/ctrlProp";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.ms-excel.controlproperties+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@"../ctrlProps";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"ctrlProp";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    


    /// <summary>
    /// Whether this part is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the part is defined in the specified version.</returns>
    internal override bool IsInVersion(DocumentFormat.OpenXml.FileFormatVersions version)
    {
		if(version == FileFormatVersions.Office2010)
		{
			return true;
		}
		return false;
    }

    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the CustomDataPropertiesPart, this part is only available in Office2010.
/// </summary>
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class CustomDataPropertiesPart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            tempData.Add("http://schemas.microsoft.com/office/2007/relationships/customData", new PartConstraintRule("CustomDataPart", CustomDataPart.ContentTypeConstant, false, false,(FileFormatVersions)2 ));

            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of CustomDataPropertiesPart
    /// </summary>
    internal protected CustomDataPropertiesPart()
            : base()
    {
    }
    
    
    /// <summary>
    /// Create an instance of OpenXmlPart according to the given relationship type
    /// </summary>
    /// <param name="relationshipType">Relationship type</param>
    /// <returns>An instance of OpenXmlPart</returns>
    internal sealed override OpenXmlPart CreatePartCore(string relationshipType)
    {
        this.ThrowIfObjectDisposed();

        if ( relationshipType == null )
        {
            throw new ArgumentNullException("relationshipType");
        }
        switch (relationshipType)
        {
        case CustomDataPart.RelationshipTypeConstant:
                    return new CustomDataPart();        
            

        }
        throw new ArgumentOutOfRangeException("relationshipType");
    }
    

     
    
    
   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.microsoft.com/office/2007/relationships/customDataProps";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.ms-excel.customDataProperties+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@"customData";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"customDataProps";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    

        /// <summary>
        /// Gets the CustomDataPart of the CustomDataPropertiesPart., only available in Office2010
        /// </summary>
[OfficeAvailability(FileFormatVersions.Office2010)]
        public CustomDataPart CustomDataPart
        {
            get {return GetSubPartOfType<CustomDataPart>(); }
        }

    /// <summary>
    /// Whether this part is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the part is defined in the specified version.</returns>
    internal override bool IsInVersion(DocumentFormat.OpenXml.FileFormatVersions version)
    {
		if(version == FileFormatVersions.Office2010)
		{
			return true;
		}
		return false;
    }

    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the CustomDataPart, this part is only available in Office2010.
/// </summary>
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class CustomDataPart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of CustomDataPart
    /// </summary>
    internal protected CustomDataPart()
            : base()
    {
    }
    
    

   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.microsoft.com/office/2007/relationships/customData";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/binary";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@"customData";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"customData";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    


    /// <summary>
    /// Whether this part is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the part is defined in the specified version.</returns>
    internal override bool IsInVersion(DocumentFormat.OpenXml.FileFormatVersions version)
    {
		if(version == FileFormatVersions.Office2010)
		{
			return true;
		}
		return false;
    }

    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the SlicerCachePart, this part is only available in Office2010.
/// </summary>
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class SlicerCachePart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of SlicerCachePart
    /// </summary>
    internal protected SlicerCachePart()
            : base()
    {
    }
    
    

   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.microsoft.com/office/2007/relationships/slicerCache";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.ms-excel.slicerCache+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@"slicerCaches";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"slicerCache";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    


    /// <summary>
    /// Whether this part is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the part is defined in the specified version.</returns>
    internal override bool IsInVersion(DocumentFormat.OpenXml.FileFormatVersions version)
    {
		if(version == FileFormatVersions.Office2010)
		{
			return true;
		}
		return false;
    }

    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the SlicersPart, this part is only available in Office2010.
/// </summary>
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class SlicersPart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of SlicersPart
    /// </summary>
    internal protected SlicersPart()
            : base()
    {
    }
    
    

   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.microsoft.com/office/2007/relationships/slicer";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.ms-excel.slicer+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@"../slicers";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"slicer";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    


    /// <summary>
    /// Whether this part is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the part is defined in the specified version.</returns>
    internal override bool IsInVersion(DocumentFormat.OpenXml.FileFormatVersions version)
    {
		if(version == FileFormatVersions.Office2010)
		{
			return true;
		}
		return false;
    }

    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the WebExtensionPart, this part is only available in Office2013.
/// </summary>
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class WebExtensionPart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/image", new PartConstraintRule("ImagePart", null, false, true,(FileFormatVersions)7 ));

            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of WebExtensionPart
    /// </summary>
    internal protected WebExtensionPart()
            : base()
    {
    }
    
    
    /// <summary>
    /// Create an instance of OpenXmlPart according to the given relationship type
    /// </summary>
    /// <param name="relationshipType">Relationship type</param>
    /// <returns>An instance of OpenXmlPart</returns>
    internal sealed override OpenXmlPart CreatePartCore(string relationshipType)
    {
        this.ThrowIfObjectDisposed();

        if ( relationshipType == null )
        {
            throw new ArgumentNullException("relationshipType");
        }
        switch (relationshipType)
        {
        case ImagePart.RelationshipTypeConstant:
                    return new ImagePart();
            

        }
        throw new ArgumentOutOfRangeException("relationshipType");
    }
    

        /// <summary>
    /// Adds a ImagePart to the WebExtensionPart.
    /// </summary>
    /// <param name="contentType">the content type of the ImagePart.</param>
    /// <returns>The newly added part.</returns>
    public ImagePart AddImagePart(string contentType)
    {
        ImagePart childPart = new ImagePart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a ImagePart to the WebExtensionPart.
    /// </summary>
    /// <param name="partType">The part type of the ImagePart.</param>
    /// <returns>The newly added part.</returns>
     public ImagePart AddImagePart(ImagePartType partType)
    {
        string contentType = ImagePartTypeInfo.GetContentType(partType);
        string partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddImagePart(contentType);
    }
    
    /// <summary>
    /// Adds a ImagePart to the WebExtensionPart.
    /// </summary>
    /// <param name="contentType">the content type of the ImagePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public ImagePart AddImagePart(string contentType, string id)
    {
        ImagePart childPart = new ImagePart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a ImagePart to the WebExtensionPart.
    /// </summary>
    /// <param name="partType">The part type of the ImagePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public ImagePart AddImagePart(ImagePartType partType, string id)
    {
        string contentType = ImagePartTypeInfo.GetContentType(partType);
        string partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddImagePart(contentType, id);
    }
 
    
    
   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.microsoft.com/office/2011/relationships/webextension";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.ms-office.webextension+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@"../webextensions";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"webextension";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    

        /// <summary>
        /// Gets the ImageParts of the WebExtensionPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<ImagePart> ImageParts
        {
            get{
                    return this.GetPartsOfType<ImagePart>();
                }
        }
                

    /// <summary>
    /// Whether this part is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the part is defined in the specified version.</returns>
    internal override bool IsInVersion(DocumentFormat.OpenXml.FileFormatVersions version)
    {
		if(version == FileFormatVersions.Office2013)
		{
			return true;
		}
		return false;
    }

    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the WebExTaskpanesPart, this part is only available in Office2013.
/// </summary>
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class WebExTaskpanesPart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            tempData.Add("http://schemas.microsoft.com/office/2011/relationships/webextension", new PartConstraintRule("WebExtensionPart", WebExtensionPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));

            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of WebExTaskpanesPart
    /// </summary>
    internal protected WebExTaskpanesPart()
            : base()
    {
    }
    
    
    /// <summary>
    /// Create an instance of OpenXmlPart according to the given relationship type
    /// </summary>
    /// <param name="relationshipType">Relationship type</param>
    /// <returns>An instance of OpenXmlPart</returns>
    internal sealed override OpenXmlPart CreatePartCore(string relationshipType)
    {
        this.ThrowIfObjectDisposed();

        if ( relationshipType == null )
        {
            throw new ArgumentNullException("relationshipType");
        }
        switch (relationshipType)
        {
        case WebExtensionPart.RelationshipTypeConstant:
                    return new WebExtensionPart();        
            

        }
        throw new ArgumentOutOfRangeException("relationshipType");
    }
    

     
    
    
   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.microsoft.com/office/2011/relationships/webextensiontaskpanes";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.ms-office.webextensiontaskpanes+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@"../webextensions";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPathOfWord
    /// </summary>
    internal const System.String TargetPathOfWordConstant =@"word/webextensions";
    /// <summary>
    /// Gets the TargetPathOfWord.
    /// </summary>
    internal sealed override string TargetPathOfWord
    {
       get { return TargetPathOfWordConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPathOfExcel
    /// </summary>
    internal const System.String TargetPathOfExcelConstant =@"xl/webextensions";
    /// <summary>
    /// Gets the TargetPathOfExcel.
    /// </summary>
    internal sealed override string TargetPathOfExcel
    {
       get { return TargetPathOfExcelConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPathOfPPT
    /// </summary>
    internal const System.String TargetPathOfPPTConstant =@"ppt/webextensions";
    /// <summary>
    /// Gets the TargetPathOfPPT.
    /// </summary>
    internal sealed override string TargetPathOfPPT
    {
       get { return TargetPathOfPPTConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"taskpanes";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    

        /// <summary>
        /// Gets the WebExtensionParts of the WebExTaskpanesPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<WebExtensionPart> WebExtensionParts
        {
            get{
                    return this.GetPartsOfType<WebExtensionPart>();
                }
        }
                

    /// <summary>
    /// Whether this part is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the part is defined in the specified version.</returns>
    internal override bool IsInVersion(DocumentFormat.OpenXml.FileFormatVersions version)
    {
		if(version == FileFormatVersions.Office2013)
		{
			return true;
		}
		return false;
    }

    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the WordprocessingCommentsExPart, this part is only available in Office2013.
/// </summary>
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class WordprocessingCommentsExPart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/aFChunk", new PartConstraintRule("AlternativeFormatImportPart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/chart", new PartConstraintRule("ChartPart", ChartPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramColors", new PartConstraintRule("DiagramColorsPart", DiagramColorsPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramData", new PartConstraintRule("DiagramDataPart", DiagramDataPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.microsoft.com/office/2007/relationships/diagramDrawing", new PartConstraintRule("DiagramPersistLayoutPart", DiagramPersistLayoutPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramLayout", new PartConstraintRule("DiagramLayoutDefinitionPart", DiagramLayoutDefinitionPart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramQuickStyle", new PartConstraintRule("DiagramStylePart", DiagramStylePart.ContentTypeConstant, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/control", new PartConstraintRule("EmbeddedControlPersistencePart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/oleObject", new PartConstraintRule("EmbeddedObjectPart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/package", new PartConstraintRule("EmbeddedPackagePart", null, false, true,(FileFormatVersions)7 ));
tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/image", new PartConstraintRule("ImagePart", null, false, true,(FileFormatVersions)7 ));

            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/video", new PartConstraintRule("VideoReferenceRelationship", null, false, true,(FileFormatVersions)7 ));

            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of WordprocessingCommentsExPart
    /// </summary>
    internal protected WordprocessingCommentsExPart()
            : base()
    {
    }
    
    
    /// <summary>
    /// Create an instance of OpenXmlPart according to the given relationship type
    /// </summary>
    /// <param name="relationshipType">Relationship type</param>
    /// <returns>An instance of OpenXmlPart</returns>
    internal sealed override OpenXmlPart CreatePartCore(string relationshipType)
    {
        this.ThrowIfObjectDisposed();

        if ( relationshipType == null )
        {
            throw new ArgumentNullException("relationshipType");
        }
        switch (relationshipType)
        {
        case AlternativeFormatImportPart.RelationshipTypeConstant:
                    return new AlternativeFormatImportPart();
            
        case ChartPart.RelationshipTypeConstant:
                    return new ChartPart();        
            
        case DiagramColorsPart.RelationshipTypeConstant:
                    return new DiagramColorsPart();        
            
        case DiagramDataPart.RelationshipTypeConstant:
                    return new DiagramDataPart();        
            
        case DiagramPersistLayoutPart.RelationshipTypeConstant:
                    return new DiagramPersistLayoutPart();        
            
        case DiagramLayoutDefinitionPart.RelationshipTypeConstant:
                    return new DiagramLayoutDefinitionPart();        
            
        case DiagramStylePart.RelationshipTypeConstant:
                    return new DiagramStylePart();        
            
        case EmbeddedControlPersistencePart.RelationshipTypeConstant:
                    return new EmbeddedControlPersistencePart();
            
        case EmbeddedObjectPart.RelationshipTypeConstant:
                    return new EmbeddedObjectPart();
            
        case EmbeddedPackagePart.RelationshipTypeConstant:
                    return new EmbeddedPackagePart();
            
        case ImagePart.RelationshipTypeConstant:
                    return new ImagePart();
            

        }
        throw new ArgumentOutOfRangeException("relationshipType");
    }
    

        /// <summary>
    /// Adds a AlternativeFormatImportPart to the WordprocessingCommentsExPart.
    /// </summary>
    /// <param name="contentType">the content type of the AlternativeFormatImportPart.</param>
    /// <returns>The newly added part.</returns>
    public AlternativeFormatImportPart AddAlternativeFormatImportPart(string contentType)
    {
        AlternativeFormatImportPart childPart = new AlternativeFormatImportPart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a AlternativeFormatImportPart to the WordprocessingCommentsExPart.
    /// </summary>
    /// <param name="partType">The part type of the AlternativeFormatImportPart.</param>
    /// <returns>The newly added part.</returns>
     public AlternativeFormatImportPart AddAlternativeFormatImportPart(AlternativeFormatImportPartType partType)
    {
        string contentType = AlternativeFormatImportPartTypeInfo.GetContentType(partType);
        string partExtension = AlternativeFormatImportPartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddAlternativeFormatImportPart(contentType);
    }
    
    /// <summary>
    /// Adds a AlternativeFormatImportPart to the WordprocessingCommentsExPart.
    /// </summary>
    /// <param name="contentType">the content type of the AlternativeFormatImportPart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public AlternativeFormatImportPart AddAlternativeFormatImportPart(string contentType, string id)
    {
        AlternativeFormatImportPart childPart = new AlternativeFormatImportPart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a AlternativeFormatImportPart to the WordprocessingCommentsExPart.
    /// </summary>
    /// <param name="partType">The part type of the AlternativeFormatImportPart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public AlternativeFormatImportPart AddAlternativeFormatImportPart(AlternativeFormatImportPartType partType, string id)
    {
        string contentType = AlternativeFormatImportPartTypeInfo.GetContentType(partType);
        string partExtension = AlternativeFormatImportPartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddAlternativeFormatImportPart(contentType, id);
    }
    /// <summary>
    /// Adds a EmbeddedControlPersistencePart to the WordprocessingCommentsExPart.
    /// </summary>
    /// <param name="contentType">the content type of the EmbeddedControlPersistencePart.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(string contentType)
    {
        EmbeddedControlPersistencePart childPart = new EmbeddedControlPersistencePart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a EmbeddedControlPersistencePart to the WordprocessingCommentsExPart.
    /// </summary>
    /// <param name="partType">The part type of the EmbeddedControlPersistencePart.</param>
    /// <returns>The newly added part.</returns>
     public EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(EmbeddedControlPersistencePartType partType)
    {
        string contentType = EmbeddedControlPersistencePartTypeInfo.GetContentType(partType);
        string partExtension = EmbeddedControlPersistencePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddEmbeddedControlPersistencePart(contentType);
    }
    
    /// <summary>
    /// Adds a EmbeddedControlPersistencePart to the WordprocessingCommentsExPart.
    /// </summary>
    /// <param name="contentType">the content type of the EmbeddedControlPersistencePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(string contentType, string id)
    {
        EmbeddedControlPersistencePart childPart = new EmbeddedControlPersistencePart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a EmbeddedControlPersistencePart to the WordprocessingCommentsExPart.
    /// </summary>
    /// <param name="partType">The part type of the EmbeddedControlPersistencePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(EmbeddedControlPersistencePartType partType, string id)
    {
        string contentType = EmbeddedControlPersistencePartTypeInfo.GetContentType(partType);
        string partExtension = EmbeddedControlPersistencePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddEmbeddedControlPersistencePart(contentType, id);
    }
	/// <summary>
    /// Adds a EmbeddedObjectPart to the WordprocessingCommentsExPart.
    /// </summary>
    /// <param name="contentType">The content type of the EmbeddedObjectPart.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedObjectPart AddEmbeddedObjectPart(string contentType)
    {
        EmbeddedObjectPart childPart = new EmbeddedObjectPart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
	/// <summary>
    /// Adds a EmbeddedPackagePart to the WordprocessingCommentsExPart.
    /// </summary>
    /// <param name="contentType">The content type of the EmbeddedPackagePart.</param>
    /// <returns>The newly added part.</returns>
    public EmbeddedPackagePart AddEmbeddedPackagePart(string contentType)
    {
        EmbeddedPackagePart childPart = new EmbeddedPackagePart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a ImagePart to the WordprocessingCommentsExPart.
    /// </summary>
    /// <param name="contentType">the content type of the ImagePart.</param>
    /// <returns>The newly added part.</returns>
    public ImagePart AddImagePart(string contentType)
    {
        ImagePart childPart = new ImagePart();
        this.InitPart(childPart, contentType);
        return childPart;
    }
    /// <summary>
    /// Adds a ImagePart to the WordprocessingCommentsExPart.
    /// </summary>
    /// <param name="partType">The part type of the ImagePart.</param>
    /// <returns>The newly added part.</returns>
     public ImagePart AddImagePart(ImagePartType partType)
    {
        string contentType = ImagePartTypeInfo.GetContentType(partType);
        string partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddImagePart(contentType);
    }
    
    /// <summary>
    /// Adds a ImagePart to the WordprocessingCommentsExPart.
    /// </summary>
    /// <param name="contentType">the content type of the ImagePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
    public ImagePart AddImagePart(string contentType, string id)
    {
        ImagePart childPart = new ImagePart();
        this.InitPart(childPart, contentType, id);
        return childPart;
    }
    
    /// <summary>
    /// Adds a ImagePart to the WordprocessingCommentsExPart.
    /// </summary>
    /// <param name="partType">The part type of the ImagePart.</param>
    /// <param name="id">The relationship id.</param>
    /// <returns>The newly added part.</returns>
     public ImagePart AddImagePart(ImagePartType partType, string id)
    {
        string contentType = ImagePartTypeInfo.GetContentType(partType);
        string partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
        OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
    
        return AddImagePart(contentType, id);
    }
    /// <summary>
    /// Adds a new <see cref="VideoReferenceRelationship"/> to the specified <see cref="MediaDataPart"/>.
    /// </summary>
    /// <param name="mediaDataPart">The specified target <see cref="MediaDataPart"/>.</param>
    /// <returns>The new <see cref="VideoReferenceRelationship"/>.</returns>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="mediaDataPart"/> is null.</exception>
    /// <exception cref="InvalidOperationException">Thrown when the specified <paramref name="mediaDataPart"/> is not in this document.</exception>
    public VideoReferenceRelationship AddVideoReferenceRelationship(MediaDataPart mediaDataPart)
    {
            return AddDataPartReferenceRelationship<VideoReferenceRelationship>(mediaDataPart);
    }
    /// <summary>
    /// Adds a new <see cref="VideoReferenceRelationship"/> to the specified <see cref="MediaDataPart"/>.
    /// </summary>
    /// <param name="mediaDataPart">The specified target <see cref="MediaDataPart"/>.</param>
    /// <param name="id">The desired relationship ID. </param>
    /// <returns>The new <see cref="VideoReferenceRelationship"/>.</returns>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="mediaDataPart"/> is null.</exception>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="id"/> is null.</exception>
    /// <exception cref="InvalidOperationException">Thrown when the specified <paramref name="mediaDataPart"/> is not in this document.</exception>
    public VideoReferenceRelationship AddVideoReferenceRelationship(MediaDataPart mediaDataPart, string id)
    {
            return AddDataPartReferenceRelationship<VideoReferenceRelationship>(mediaDataPart, id);
    }
 
    
    
   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.microsoft.com/office/2011/relationships/commentsExtended";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.openxmlformats-officedocument.wordprocessingml.commentsExtended+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@".";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"commentsExtended";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    

        /// <summary>
        /// Gets the AlternativeFormatImportParts of the WordprocessingCommentsExPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<AlternativeFormatImportPart> AlternativeFormatImportParts
        {
            get{
                    return this.GetPartsOfType<AlternativeFormatImportPart>();
                }
        }
                
        /// <summary>
        /// Gets the ChartParts of the WordprocessingCommentsExPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<ChartPart> ChartParts
        {
            get{
                    return this.GetPartsOfType<ChartPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramColorsParts of the WordprocessingCommentsExPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramColorsPart> DiagramColorsParts
        {
            get{
                    return this.GetPartsOfType<DiagramColorsPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramDataParts of the WordprocessingCommentsExPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramDataPart> DiagramDataParts
        {
            get{
                    return this.GetPartsOfType<DiagramDataPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramPersistLayoutParts of the WordprocessingCommentsExPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramPersistLayoutPart> DiagramPersistLayoutParts
        {
            get{
                    return this.GetPartsOfType<DiagramPersistLayoutPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramLayoutDefinitionParts of the WordprocessingCommentsExPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramLayoutDefinitionPart> DiagramLayoutDefinitionParts
        {
            get{
                    return this.GetPartsOfType<DiagramLayoutDefinitionPart>();
                }
        }
                
        /// <summary>
        /// Gets the DiagramStyleParts of the WordprocessingCommentsExPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<DiagramStylePart> DiagramStyleParts
        {
            get{
                    return this.GetPartsOfType<DiagramStylePart>();
                }
        }
                
        /// <summary>
        /// Gets the EmbeddedControlPersistenceParts of the WordprocessingCommentsExPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<EmbeddedControlPersistencePart> EmbeddedControlPersistenceParts
        {
            get{
                    return this.GetPartsOfType<EmbeddedControlPersistencePart>();
                }
        }
                
        /// <summary>
        /// Gets the EmbeddedObjectParts of the WordprocessingCommentsExPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<EmbeddedObjectPart> EmbeddedObjectParts
        {
            get{
                    return this.GetPartsOfType<EmbeddedObjectPart>();
                }
        }
                
        /// <summary>
        /// Gets the EmbeddedPackageParts of the WordprocessingCommentsExPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<EmbeddedPackagePart> EmbeddedPackageParts
        {
            get{
                    return this.GetPartsOfType<EmbeddedPackagePart>();
                }
        }
                
        /// <summary>
        /// Gets the ImageParts of the WordprocessingCommentsExPart.
        /// </summary>
        public System.Collections.Generic.IEnumerable<ImagePart> ImageParts
        {
            get{
                    return this.GetPartsOfType<ImagePart>();
                }
        }
                

    /// <summary>
    /// Whether this part is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the part is defined in the specified version.</returns>
    internal override bool IsInVersion(DocumentFormat.OpenXml.FileFormatVersions version)
    {
		if(version == FileFormatVersions.Office2013)
		{
			return true;
		}
		return false;
    }

    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the ChartStylePart, this part is only available in Office2013.
/// </summary>
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class ChartStylePart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of ChartStylePart
    /// </summary>
    internal protected ChartStylePart()
            : base()
    {
    }
    
    

   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.microsoft.com/office/2011/relationships/chartStyle";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.ms-office.chartstyle+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@".";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"style";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    


    /// <summary>
    /// Whether this part is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the part is defined in the specified version.</returns>
    internal override bool IsInVersion(DocumentFormat.OpenXml.FileFormatVersions version)
    {
		if(version == FileFormatVersions.Office2013)
		{
			return true;
		}
		return false;
    }

    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the ChartColorStylePart, this part is only available in Office2013.
/// </summary>
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class ChartColorStylePart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of ChartColorStylePart
    /// </summary>
    internal protected ChartColorStylePart()
            : base()
    {
    }
    
    

   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.microsoft.com/office/2011/relationships/chartColorStyle";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.ms-office.chartcolorstyle+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@".";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"colors";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    


    /// <summary>
    /// Whether this part is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the part is defined in the specified version.</returns>
    internal override bool IsInVersion(DocumentFormat.OpenXml.FileFormatVersions version)
    {
		if(version == FileFormatVersions.Office2013)
		{
			return true;
		}
		return false;
    }

    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the TimeLinePart, this part is only available in Office2013.
/// </summary>
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class TimeLinePart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of TimeLinePart
    /// </summary>
    internal protected TimeLinePart()
            : base()
    {
    }
    
    

   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.microsoft.com/office/2011/relationships/timeline";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.ms-excel.timeline+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@"../timelines";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"timeline";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    


    /// <summary>
    /// Whether this part is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the part is defined in the specified version.</returns>
    internal override bool IsInVersion(DocumentFormat.OpenXml.FileFormatVersions version)
    {
		if(version == FileFormatVersions.Office2013)
		{
			return true;
		}
		return false;
    }

    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the TimeLineCachePart, this part is only available in Office2013.
/// </summary>
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class TimeLineCachePart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of TimeLineCachePart
    /// </summary>
    internal protected TimeLineCachePart()
            : base()
    {
    }
    
    

   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.microsoft.com/office/2011/relationships/timelineCache";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.ms-excel.timelineCache+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@"timelineCaches";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"timelineCache";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    


    /// <summary>
    /// Whether this part is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the part is defined in the specified version.</returns>
    internal override bool IsInVersion(DocumentFormat.OpenXml.FileFormatVersions version)
    {
		if(version == FileFormatVersions.Office2013)
		{
			return true;
		}
		return false;
    }

    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
/// <summary>
/// Defines the WordprocessingPeoplePart, this part is only available in Office2013.
/// </summary>
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class WordprocessingPeoplePart : OpenXmlPart , IFixedContentTypePart
{
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
    private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    
    /// <summary>
    /// Get Part constraint data
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
        if (_partConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _partConstraint = tempData;
        }
        return _partConstraint;
    }
    
    /// <summary>
    /// Get the constraint rule of DataPartReferenceRelationship.
    /// </summary>
    /// <returns>Part constraint data</returns>
    internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
        if (_dataPartReferenceConstraint == null)
        {
            System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string,PartConstraintRule> ();
            
            _dataPartReferenceConstraint = tempData;
        }
        return _dataPartReferenceConstraint;
    }
    
    /// <summary>
    /// Construtor of WordprocessingPeoplePart
    /// </summary>
    internal protected WordprocessingPeoplePart()
            : base()
    {
    }
    
    

   
    /// <summary>
    /// The fixed value of the RelationshipType
    /// </summary>
    internal const System.String RelationshipTypeConstant =@"http://schemas.microsoft.com/office/2011/relationships/people";
    /// <summary>
    /// Gets the RelationshipType.
    /// </summary>
    public sealed override string RelationshipType
    {
       get { return RelationshipTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the ContentType
    /// </summary>
    internal const System.String ContentTypeConstant =@"application/vnd.openxmlformats-officedocument.wordprocessingml.people+xml";
    /// <summary>
    /// Gets the ContentType.
    /// </summary>
    public sealed override string ContentType
    {
       get { return ContentTypeConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetPath
    /// </summary>
    internal const System.String TargetPathConstant =@".";
    /// <summary>
    /// Gets the TargetPath.
    /// </summary>
    internal sealed override string TargetPath
    {
       get { return TargetPathConstant; }
    } 
    
    /// <summary>
    /// The fixed value of the TargetName
    /// </summary>
    internal const System.String TargetNameConstant =@"people";
    /// <summary>
    /// Gets the TargetName.
    /// </summary>
    internal sealed override string TargetName
    {
       get { return TargetNameConstant; }
    } 
    


    /// <summary>
    /// Whether this part is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the part is defined in the specified version.</returns>
    internal override bool IsInVersion(DocumentFormat.OpenXml.FileFormatVersions version)
    {
		if(version == FileFormatVersions.Office2013)
		{
			return true;
		}
		return false;
    }

    /// <summary>
    /// Is the ContentType for this part fixed? 
    /// </summary>
    internal sealed override bool IsContentTypeFixed
    {
        get { return true; }
    }
}
	/// <summary>
    /// Global OpenXmlPart factory to create strong typed OpenXmlPart based on the relationship type.
    /// </summary>
    internal static partial class GlobalPartFactory
    {
        /// <summary>
        /// Create an instance of OpenXmlPart according to the given relationship type.
        /// </summary>
        /// <param name="openXmlPackage">The container OpenXmlPackage.</param>
        /// <param name="relationshipType">The relationship type of the target part.</param>
        /// <param name="openXmlPart">The created instance of OpenXmlPart.</param>
        /// <remarks>This partial method will be generated by code generaotr.</remarks>
        static partial void CreatePartCore(OpenXmlPackage openXmlPackage, string relationshipType, ref OpenXmlPart openXmlPart)
        {
            if (openXmlPackage == null)
            {
				throw new ArgumentNullException("openXmlPackage");
            }
            if (relationshipType == null)
            {
                throw new ArgumentNullException("relationshipType");
            }
            
            if (openXmlPackage is WordprocessingDocument)
            {
                switch (relationshipType)
                {
					case MainDocumentPart.RelationshipTypeConstant:
	openXmlPart = new MainDocumentPart();
	return;
case CustomXmlPart.RelationshipTypeConstant:
	openXmlPart = new CustomXmlPart();
	return;
case CustomXmlPropertiesPart.RelationshipTypeConstant:
	openXmlPart = new CustomXmlPropertiesPart();
	return;
case GlossaryDocumentPart.RelationshipTypeConstant:
	openXmlPart = new GlossaryDocumentPart();
	return;
case WordprocessingCommentsPart.RelationshipTypeConstant:
	openXmlPart = new WordprocessingCommentsPart();
	return;
case AlternativeFormatImportPart.RelationshipTypeConstant:
	openXmlPart = new AlternativeFormatImportPart();
	return;
case ChartPart.RelationshipTypeConstant:
	openXmlPart = new ChartPart();
	return;
case ChartDrawingPart.RelationshipTypeConstant:
	openXmlPart = new ChartDrawingPart();
	return;
case ImagePart.RelationshipTypeConstant:
	openXmlPart = new ImagePart();
	return;
case EmbeddedPackagePart.RelationshipTypeConstant:
	openXmlPart = new EmbeddedPackagePart();
	return;
case ThemeOverridePart.RelationshipTypeConstant:
	openXmlPart = new ThemeOverridePart();
	return;
case ChartStylePart.RelationshipTypeConstant:
	openXmlPart = new ChartStylePart();
	return;
case ChartColorStylePart.RelationshipTypeConstant:
	openXmlPart = new ChartColorStylePart();
	return;
case DiagramColorsPart.RelationshipTypeConstant:
	openXmlPart = new DiagramColorsPart();
	return;
case DiagramDataPart.RelationshipTypeConstant:
	openXmlPart = new DiagramDataPart();
	return;
case SlidePart.RelationshipTypeConstant:
	openXmlPart = new SlidePart();
	return;
case DiagramPersistLayoutPart.RelationshipTypeConstant:
	openXmlPart = new DiagramPersistLayoutPart();
	return;
case DiagramLayoutDefinitionPart.RelationshipTypeConstant:
	openXmlPart = new DiagramLayoutDefinitionPart();
	return;
case DiagramStylePart.RelationshipTypeConstant:
	openXmlPart = new DiagramStylePart();
	return;
case EmbeddedObjectPart.RelationshipTypeConstant:
	openXmlPart = new EmbeddedObjectPart();
	return;
case VmlDrawingPart.RelationshipTypeConstant:
	openXmlPart = new VmlDrawingPart();
	return;
case LegacyDiagramTextPart.RelationshipTypeConstant:
	openXmlPart = new LegacyDiagramTextPart();
	return;
case EmbeddedControlPersistenceBinaryDataPart.RelationshipTypeConstant:
	openXmlPart = new EmbeddedControlPersistenceBinaryDataPart();
	return;
case NotesSlidePart.RelationshipTypeConstant:
	openXmlPart = new NotesSlidePart();
	return;
case NotesMasterPart.RelationshipTypeConstant:
	openXmlPart = new NotesMasterPart();
	return;
case ThemePart.RelationshipTypeConstant:
	openXmlPart = new ThemePart();
	return;
case UserDefinedTagsPart.RelationshipTypeConstant:
	openXmlPart = new UserDefinedTagsPart();
	return;
case SlideLayoutPart.RelationshipTypeConstant:
	openXmlPart = new SlideLayoutPart();
	return;
case SlideMasterPart.RelationshipTypeConstant:
	openXmlPart = new SlideMasterPart();
	return;
case EmbeddedControlPersistencePart.RelationshipTypeConstant:
	openXmlPart = new EmbeddedControlPersistencePart();
	return;
case SlideSyncDataPart.RelationshipTypeConstant:
	openXmlPart = new SlideSyncDataPart();
	return;
case WebExtensionPart.RelationshipTypeConstant:
	openXmlPart = new WebExtensionPart();
	return;
case WorksheetPart.RelationshipTypeConstant:
	openXmlPart = new WorksheetPart();
	return;
case DrawingsPart.RelationshipTypeConstant:
	openXmlPart = new DrawingsPart();
	return;
case PivotTablePart.RelationshipTypeConstant:
	openXmlPart = new PivotTablePart();
	return;
case PivotTableCacheDefinitionPart.RelationshipTypeConstant:
	openXmlPart = new PivotTableCacheDefinitionPart();
	return;
case PivotTableCacheRecordsPart.RelationshipTypeConstant:
	openXmlPart = new PivotTableCacheRecordsPart();
	return;
case SingleCellTablePart.RelationshipTypeConstant:
	openXmlPart = new SingleCellTablePart();
	return;
case TableDefinitionPart.RelationshipTypeConstant:
	openXmlPart = new TableDefinitionPart();
	return;
case QueryTablePart.RelationshipTypeConstant:
	openXmlPart = new QueryTablePart();
	return;
case ControlPropertiesPart.RelationshipTypeConstant:
	openXmlPart = new ControlPropertiesPart();
	return;
case CustomPropertyPart.RelationshipTypeConstant:
	openXmlPart = new CustomPropertyPart();
	return;
case WorksheetSortMapPart.RelationshipTypeConstant:
	openXmlPart = new WorksheetSortMapPart();
	return;
case SlicersPart.RelationshipTypeConstant:
	openXmlPart = new SlicersPart();
	return;
case TimeLinePart.RelationshipTypeConstant:
	openXmlPart = new TimeLinePart();
	return;
case DocumentSettingsPart.RelationshipTypeConstant:
	openXmlPart = new DocumentSettingsPart();
	return;
case MailMergeRecipientDataPart.RelationshipTypeConstant:
	openXmlPart = new MailMergeRecipientDataPart();
	return;
case EndnotesPart.RelationshipTypeConstant:
	openXmlPart = new EndnotesPart();
	return;
case FontTablePart.RelationshipTypeConstant:
	openXmlPart = new FontTablePart();
	return;
case FontPart.RelationshipTypeConstant:
	openXmlPart = new FontPart();
	return;
case FootnotesPart.RelationshipTypeConstant:
	openXmlPart = new FootnotesPart();
	return;
case NumberingDefinitionsPart.RelationshipTypeConstant:
	openXmlPart = new NumberingDefinitionsPart();
	return;
case StyleDefinitionsPart.RelationshipTypeConstant:
	openXmlPart = new StyleDefinitionsPart();
	return;
case StylesWithEffectsPart.RelationshipTypeConstant:
	openXmlPart = new StylesWithEffectsPart();
	return;
case WebSettingsPart.RelationshipTypeConstant:
	openXmlPart = new WebSettingsPart();
	return;
case FooterPart.RelationshipTypeConstant:
	openXmlPart = new FooterPart();
	return;
case HeaderPart.RelationshipTypeConstant:
	openXmlPart = new HeaderPart();
	return;
case WordprocessingPrinterSettingsPart.RelationshipTypeConstant:
	openXmlPart = new WordprocessingPrinterSettingsPart();
	return;
case CustomizationPart.RelationshipTypeConstant:
	openXmlPart = new CustomizationPart();
	return;
case WordAttachedToolbarsPart.RelationshipTypeConstant:
	openXmlPart = new WordAttachedToolbarsPart();
	return;
case VbaProjectPart.RelationshipTypeConstant:
	openXmlPart = new VbaProjectPart();
	return;
case VbaDataPart.RelationshipTypeConstant:
	openXmlPart = new VbaDataPart();
	return;
case WordprocessingCommentsExPart.RelationshipTypeConstant:
	openXmlPart = new WordprocessingCommentsExPart();
	return;
case WordprocessingPeoplePart.RelationshipTypeConstant:
	openXmlPart = new WordprocessingPeoplePart();
	return;
case ThumbnailPart.RelationshipTypeConstant:
	openXmlPart = new ThumbnailPart();
	return;
case CoreFilePropertiesPart.RelationshipTypeConstant:
	openXmlPart = new CoreFilePropertiesPart();
	return;
case ExtendedFilePropertiesPart.RelationshipTypeConstant:
	openXmlPart = new ExtendedFilePropertiesPart();
	return;
case CustomFilePropertiesPart.RelationshipTypeConstant:
	openXmlPart = new CustomFilePropertiesPart();
	return;
case DigitalSignatureOriginPart.RelationshipTypeConstant:
	openXmlPart = new DigitalSignatureOriginPart();
	return;
case XmlSignaturePart.RelationshipTypeConstant:
	openXmlPart = new XmlSignaturePart();
	return;
case QuickAccessToolbarCustomizationsPart.RelationshipTypeConstant:
	openXmlPart = new QuickAccessToolbarCustomizationsPart();
	return;
case RibbonExtensibilityPart.RelationshipTypeConstant:
	openXmlPart = new RibbonExtensibilityPart();
	return;
case RibbonAndBackstageCustomizationsPart.RelationshipTypeConstant:
	openXmlPart = new RibbonAndBackstageCustomizationsPart();
	return;
case WebExTaskpanesPart.RelationshipTypeConstant:
	openXmlPart = new WebExTaskpanesPart();
	return;

				}
            }
            else if (openXmlPackage is SpreadsheetDocument)
            {
                switch (relationshipType)
                {
					case WorkbookPart.RelationshipTypeConstant:
	openXmlPart = new WorkbookPart();
	return;
case CustomXmlPart.RelationshipTypeConstant:
	openXmlPart = new CustomXmlPart();
	return;
case CustomXmlPropertiesPart.RelationshipTypeConstant:
	openXmlPart = new CustomXmlPropertiesPart();
	return;
case CalculationChainPart.RelationshipTypeConstant:
	openXmlPart = new CalculationChainPart();
	return;
case CellMetadataPart.RelationshipTypeConstant:
	openXmlPart = new CellMetadataPart();
	return;
case ConnectionsPart.RelationshipTypeConstant:
	openXmlPart = new ConnectionsPart();
	return;
case CustomXmlMappingsPart.RelationshipTypeConstant:
	openXmlPart = new CustomXmlMappingsPart();
	return;
case SharedStringTablePart.RelationshipTypeConstant:
	openXmlPart = new SharedStringTablePart();
	return;
case WorkbookRevisionHeaderPart.RelationshipTypeConstant:
	openXmlPart = new WorkbookRevisionHeaderPart();
	return;
case WorkbookRevisionLogPart.RelationshipTypeConstant:
	openXmlPart = new WorkbookRevisionLogPart();
	return;
case WorkbookUserDataPart.RelationshipTypeConstant:
	openXmlPart = new WorkbookUserDataPart();
	return;
case WorkbookStylesPart.RelationshipTypeConstant:
	openXmlPart = new WorkbookStylesPart();
	return;
case ThemePart.RelationshipTypeConstant:
	openXmlPart = new ThemePart();
	return;
case ImagePart.RelationshipTypeConstant:
	openXmlPart = new ImagePart();
	return;
case ThumbnailPart.RelationshipTypeConstant:
	openXmlPart = new ThumbnailPart();
	return;
case VolatileDependenciesPart.RelationshipTypeConstant:
	openXmlPart = new VolatileDependenciesPart();
	return;
case ChartsheetPart.RelationshipTypeConstant:
	openXmlPart = new ChartsheetPart();
	return;
case SpreadsheetPrinterSettingsPart.RelationshipTypeConstant:
	openXmlPart = new SpreadsheetPrinterSettingsPart();
	return;
case DrawingsPart.RelationshipTypeConstant:
	openXmlPart = new DrawingsPart();
	return;
case ChartPart.RelationshipTypeConstant:
	openXmlPart = new ChartPart();
	return;
case ChartDrawingPart.RelationshipTypeConstant:
	openXmlPart = new ChartDrawingPart();
	return;
case EmbeddedPackagePart.RelationshipTypeConstant:
	openXmlPart = new EmbeddedPackagePart();
	return;
case ThemeOverridePart.RelationshipTypeConstant:
	openXmlPart = new ThemeOverridePart();
	return;
case ChartStylePart.RelationshipTypeConstant:
	openXmlPart = new ChartStylePart();
	return;
case ChartColorStylePart.RelationshipTypeConstant:
	openXmlPart = new ChartColorStylePart();
	return;
case DiagramColorsPart.RelationshipTypeConstant:
	openXmlPart = new DiagramColorsPart();
	return;
case DiagramDataPart.RelationshipTypeConstant:
	openXmlPart = new DiagramDataPart();
	return;
case SlidePart.RelationshipTypeConstant:
	openXmlPart = new SlidePart();
	return;
case DiagramPersistLayoutPart.RelationshipTypeConstant:
	openXmlPart = new DiagramPersistLayoutPart();
	return;
case DiagramLayoutDefinitionPart.RelationshipTypeConstant:
	openXmlPart = new DiagramLayoutDefinitionPart();
	return;
case DiagramStylePart.RelationshipTypeConstant:
	openXmlPart = new DiagramStylePart();
	return;
case EmbeddedObjectPart.RelationshipTypeConstant:
	openXmlPart = new EmbeddedObjectPart();
	return;
case VmlDrawingPart.RelationshipTypeConstant:
	openXmlPart = new VmlDrawingPart();
	return;
case LegacyDiagramTextPart.RelationshipTypeConstant:
	openXmlPart = new LegacyDiagramTextPart();
	return;
case EmbeddedControlPersistenceBinaryDataPart.RelationshipTypeConstant:
	openXmlPart = new EmbeddedControlPersistenceBinaryDataPart();
	return;
case NotesSlidePart.RelationshipTypeConstant:
	openXmlPart = new NotesSlidePart();
	return;
case NotesMasterPart.RelationshipTypeConstant:
	openXmlPart = new NotesMasterPart();
	return;
case UserDefinedTagsPart.RelationshipTypeConstant:
	openXmlPart = new UserDefinedTagsPart();
	return;
case SlideLayoutPart.RelationshipTypeConstant:
	openXmlPart = new SlideLayoutPart();
	return;
case SlideMasterPart.RelationshipTypeConstant:
	openXmlPart = new SlideMasterPart();
	return;
case EmbeddedControlPersistencePart.RelationshipTypeConstant:
	openXmlPart = new EmbeddedControlPersistencePart();
	return;
case SlideSyncDataPart.RelationshipTypeConstant:
	openXmlPart = new SlideSyncDataPart();
	return;
case WebExtensionPart.RelationshipTypeConstant:
	openXmlPart = new WebExtensionPart();
	return;
case WorksheetPart.RelationshipTypeConstant:
	openXmlPart = new WorksheetPart();
	return;
case WorksheetCommentsPart.RelationshipTypeConstant:
	openXmlPart = new WorksheetCommentsPart();
	return;
case PivotTablePart.RelationshipTypeConstant:
	openXmlPart = new PivotTablePart();
	return;
case PivotTableCacheDefinitionPart.RelationshipTypeConstant:
	openXmlPart = new PivotTableCacheDefinitionPart();
	return;
case PivotTableCacheRecordsPart.RelationshipTypeConstant:
	openXmlPart = new PivotTableCacheRecordsPart();
	return;
case SingleCellTablePart.RelationshipTypeConstant:
	openXmlPart = new SingleCellTablePart();
	return;
case TableDefinitionPart.RelationshipTypeConstant:
	openXmlPart = new TableDefinitionPart();
	return;
case QueryTablePart.RelationshipTypeConstant:
	openXmlPart = new QueryTablePart();
	return;
case ControlPropertiesPart.RelationshipTypeConstant:
	openXmlPart = new ControlPropertiesPart();
	return;
case CustomPropertyPart.RelationshipTypeConstant:
	openXmlPart = new CustomPropertyPart();
	return;
case WorksheetSortMapPart.RelationshipTypeConstant:
	openXmlPart = new WorksheetSortMapPart();
	return;
case SlicersPart.RelationshipTypeConstant:
	openXmlPart = new SlicersPart();
	return;
case TimeLinePart.RelationshipTypeConstant:
	openXmlPart = new TimeLinePart();
	return;
case DialogsheetPart.RelationshipTypeConstant:
	openXmlPart = new DialogsheetPart();
	return;
case ExternalWorkbookPart.RelationshipTypeConstant:
	openXmlPart = new ExternalWorkbookPart();
	return;
case ExcelAttachedToolbarsPart.RelationshipTypeConstant:
	openXmlPart = new ExcelAttachedToolbarsPart();
	return;
case VbaProjectPart.RelationshipTypeConstant:
	openXmlPart = new VbaProjectPart();
	return;
case VbaDataPart.RelationshipTypeConstant:
	openXmlPart = new VbaDataPart();
	return;
case MacroSheetPart.RelationshipTypeConstant:
	openXmlPart = new MacroSheetPart();
	return;
case InternationalMacroSheetPart.RelationshipTypeConstant:
	openXmlPart = new InternationalMacroSheetPart();
	return;
case CustomDataPropertiesPart.RelationshipTypeConstant:
	openXmlPart = new CustomDataPropertiesPart();
	return;
case CustomDataPart.RelationshipTypeConstant:
	openXmlPart = new CustomDataPart();
	return;
case SlicerCachePart.RelationshipTypeConstant:
	openXmlPart = new SlicerCachePart();
	return;
case TimeLineCachePart.RelationshipTypeConstant:
	openXmlPart = new TimeLineCachePart();
	return;
case CoreFilePropertiesPart.RelationshipTypeConstant:
	openXmlPart = new CoreFilePropertiesPart();
	return;
case ExtendedFilePropertiesPart.RelationshipTypeConstant:
	openXmlPart = new ExtendedFilePropertiesPart();
	return;
case CustomFilePropertiesPart.RelationshipTypeConstant:
	openXmlPart = new CustomFilePropertiesPart();
	return;
case DigitalSignatureOriginPart.RelationshipTypeConstant:
	openXmlPart = new DigitalSignatureOriginPart();
	return;
case XmlSignaturePart.RelationshipTypeConstant:
	openXmlPart = new XmlSignaturePart();
	return;
case QuickAccessToolbarCustomizationsPart.RelationshipTypeConstant:
	openXmlPart = new QuickAccessToolbarCustomizationsPart();
	return;
case RibbonExtensibilityPart.RelationshipTypeConstant:
	openXmlPart = new RibbonExtensibilityPart();
	return;
case RibbonAndBackstageCustomizationsPart.RelationshipTypeConstant:
	openXmlPart = new RibbonAndBackstageCustomizationsPart();
	return;
case WebExTaskpanesPart.RelationshipTypeConstant:
	openXmlPart = new WebExTaskpanesPart();
	return;

                }
            }
            else if (openXmlPackage is PresentationDocument)
            {
                switch (relationshipType)
                {
					case PresentationPart.RelationshipTypeConstant:
	openXmlPart = new PresentationPart();
	return;
case CustomXmlPart.RelationshipTypeConstant:
	openXmlPart = new CustomXmlPart();
	return;
case CustomXmlPropertiesPart.RelationshipTypeConstant:
	openXmlPart = new CustomXmlPropertiesPart();
	return;
case FontPart.RelationshipTypeConstant:
	openXmlPart = new FontPart();
	return;
case PresentationPropertiesPart.RelationshipTypeConstant:
	openXmlPart = new PresentationPropertiesPart();
	return;
case TableStylesPart.RelationshipTypeConstant:
	openXmlPart = new TableStylesPart();
	return;
case ThemePart.RelationshipTypeConstant:
	openXmlPart = new ThemePart();
	return;
case ImagePart.RelationshipTypeConstant:
	openXmlPart = new ImagePart();
	return;
case ViewPropertiesPart.RelationshipTypeConstant:
	openXmlPart = new ViewPropertiesPart();
	return;
case SlidePart.RelationshipTypeConstant:
	openXmlPart = new SlidePart();
	return;
case ChartPart.RelationshipTypeConstant:
	openXmlPart = new ChartPart();
	return;
case ChartDrawingPart.RelationshipTypeConstant:
	openXmlPart = new ChartDrawingPart();
	return;
case EmbeddedPackagePart.RelationshipTypeConstant:
	openXmlPart = new EmbeddedPackagePart();
	return;
case ThemeOverridePart.RelationshipTypeConstant:
	openXmlPart = new ThemeOverridePart();
	return;
case ChartStylePart.RelationshipTypeConstant:
	openXmlPart = new ChartStylePart();
	return;
case ChartColorStylePart.RelationshipTypeConstant:
	openXmlPart = new ChartColorStylePart();
	return;
case DiagramColorsPart.RelationshipTypeConstant:
	openXmlPart = new DiagramColorsPart();
	return;
case DiagramDataPart.RelationshipTypeConstant:
	openXmlPart = new DiagramDataPart();
	return;
case WorksheetPart.RelationshipTypeConstant:
	openXmlPart = new WorksheetPart();
	return;
case DrawingsPart.RelationshipTypeConstant:
	openXmlPart = new DrawingsPart();
	return;
case DiagramPersistLayoutPart.RelationshipTypeConstant:
	openXmlPart = new DiagramPersistLayoutPart();
	return;
case DiagramLayoutDefinitionPart.RelationshipTypeConstant:
	openXmlPart = new DiagramLayoutDefinitionPart();
	return;
case DiagramStylePart.RelationshipTypeConstant:
	openXmlPart = new DiagramStylePart();
	return;
case WebExtensionPart.RelationshipTypeConstant:
	openXmlPart = new WebExtensionPart();
	return;
case VmlDrawingPart.RelationshipTypeConstant:
	openXmlPart = new VmlDrawingPart();
	return;
case LegacyDiagramTextPart.RelationshipTypeConstant:
	openXmlPart = new LegacyDiagramTextPart();
	return;
case PivotTablePart.RelationshipTypeConstant:
	openXmlPart = new PivotTablePart();
	return;
case PivotTableCacheDefinitionPart.RelationshipTypeConstant:
	openXmlPart = new PivotTableCacheDefinitionPart();
	return;
case PivotTableCacheRecordsPart.RelationshipTypeConstant:
	openXmlPart = new PivotTableCacheRecordsPart();
	return;
case SingleCellTablePart.RelationshipTypeConstant:
	openXmlPart = new SingleCellTablePart();
	return;
case TableDefinitionPart.RelationshipTypeConstant:
	openXmlPart = new TableDefinitionPart();
	return;
case QueryTablePart.RelationshipTypeConstant:
	openXmlPart = new QueryTablePart();
	return;
case EmbeddedControlPersistencePart.RelationshipTypeConstant:
	openXmlPart = new EmbeddedControlPersistencePart();
	return;
case EmbeddedControlPersistenceBinaryDataPart.RelationshipTypeConstant:
	openXmlPart = new EmbeddedControlPersistenceBinaryDataPart();
	return;
case ControlPropertiesPart.RelationshipTypeConstant:
	openXmlPart = new ControlPropertiesPart();
	return;
case EmbeddedObjectPart.RelationshipTypeConstant:
	openXmlPart = new EmbeddedObjectPart();
	return;
case CustomPropertyPart.RelationshipTypeConstant:
	openXmlPart = new CustomPropertyPart();
	return;
case WorksheetSortMapPart.RelationshipTypeConstant:
	openXmlPart = new WorksheetSortMapPart();
	return;
case SlicersPart.RelationshipTypeConstant:
	openXmlPart = new SlicersPart();
	return;
case TimeLinePart.RelationshipTypeConstant:
	openXmlPart = new TimeLinePart();
	return;
case SlideCommentsPart.RelationshipTypeConstant:
	openXmlPart = new SlideCommentsPart();
	return;
case NotesSlidePart.RelationshipTypeConstant:
	openXmlPart = new NotesSlidePart();
	return;
case NotesMasterPart.RelationshipTypeConstant:
	openXmlPart = new NotesMasterPart();
	return;
case UserDefinedTagsPart.RelationshipTypeConstant:
	openXmlPart = new UserDefinedTagsPart();
	return;
case SlideLayoutPart.RelationshipTypeConstant:
	openXmlPart = new SlideLayoutPart();
	return;
case SlideMasterPart.RelationshipTypeConstant:
	openXmlPart = new SlideMasterPart();
	return;
case SlideSyncDataPart.RelationshipTypeConstant:
	openXmlPart = new SlideSyncDataPart();
	return;
case CommentAuthorsPart.RelationshipTypeConstant:
	openXmlPart = new CommentAuthorsPart();
	return;
case HandoutMasterPart.RelationshipTypeConstant:
	openXmlPart = new HandoutMasterPart();
	return;
case LegacyDiagramTextInfoPart.RelationshipTypeConstant:
	openXmlPart = new LegacyDiagramTextInfoPart();
	return;
case VbaProjectPart.RelationshipTypeConstant:
	openXmlPart = new VbaProjectPart();
	return;
case VbaDataPart.RelationshipTypeConstant:
	openXmlPart = new VbaDataPart();
	return;
case CoreFilePropertiesPart.RelationshipTypeConstant:
	openXmlPart = new CoreFilePropertiesPart();
	return;
case ExtendedFilePropertiesPart.RelationshipTypeConstant:
	openXmlPart = new ExtendedFilePropertiesPart();
	return;
case CustomFilePropertiesPart.RelationshipTypeConstant:
	openXmlPart = new CustomFilePropertiesPart();
	return;
case ThumbnailPart.RelationshipTypeConstant:
	openXmlPart = new ThumbnailPart();
	return;
case DigitalSignatureOriginPart.RelationshipTypeConstant:
	openXmlPart = new DigitalSignatureOriginPart();
	return;
case XmlSignaturePart.RelationshipTypeConstant:
	openXmlPart = new XmlSignaturePart();
	return;
case QuickAccessToolbarCustomizationsPart.RelationshipTypeConstant:
	openXmlPart = new QuickAccessToolbarCustomizationsPart();
	return;
case RibbonExtensibilityPart.RelationshipTypeConstant:
	openXmlPart = new RibbonExtensibilityPart();
	return;
case RibbonAndBackstageCustomizationsPart.RelationshipTypeConstant:
	openXmlPart = new RibbonAndBackstageCustomizationsPart();
	return;
case WebExTaskpanesPart.RelationshipTypeConstant:
	openXmlPart = new WebExTaskpanesPart();
	return;

                }
            }
            else
            {
                System.Diagnostics.Debug.Assert(false);				
            }
            return;
        }
    }
    
}
 
 
