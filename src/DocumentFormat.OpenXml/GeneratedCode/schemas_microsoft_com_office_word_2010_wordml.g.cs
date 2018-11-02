// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Office2010.Drawing;

namespace DocumentFormat.OpenXml.Office2010.Word
{
/// <summary>
/// <para>Defines the RunConflictInsertion Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w14:conflictIns.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Wordprocessing.SdtRun &lt;w:sdt></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.ProofError &lt;w:proofErr></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.PermStart &lt;w:permStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.PermEnd &lt;w:permEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.BookmarkStart &lt;w:bookmarkStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd &lt;w:bookmarkEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart &lt;w:commentRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd &lt;w:commentRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart &lt;w:moveFromRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd &lt;w:moveFromRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart &lt;w:moveToRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd &lt;w:moveToRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart &lt;w:customXmlInsRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd &lt;w:customXmlInsRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart &lt;w:customXmlDelRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd &lt;w:customXmlDelRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart &lt;w:customXmlMoveFromRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd &lt;w:customXmlMoveFromRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart &lt;w:customXmlMoveToRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd &lt;w:customXmlMoveToRangeEnd></description></item>
///<item><description>CustomXmlConflictInsertionRangeStart &lt;w14:customXmlConflictInsRangeStart></description></item>
///<item><description>CustomXmlConflictInsertionRangeEnd &lt;w14:customXmlConflictInsRangeEnd></description></item>
///<item><description>CustomXmlConflictDeletionRangeStart &lt;w14:customXmlConflictDelRangeStart></description></item>
///<item><description>CustomXmlConflictDeletionRangeEnd &lt;w14:customXmlConflictDelRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.InsertedRun &lt;w:ins></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.DeletedRun &lt;w:del></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRun &lt;w:moveFrom></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRun &lt;w:moveTo></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.ContentPart &lt;w:contentPart></description></item>
///<item><description>RunConflictInsertion &lt;w14:conflictIns></description></item>
///<item><description>RunConflictDeletion &lt;w14:conflictDel></description></item>
///<item><description>DocumentFormat.OpenXml.Math.Paragraph &lt;m:oMathPara></description></item>
///<item><description>DocumentFormat.OpenXml.Math.OfficeMath &lt;m:oMath></description></item>
///<item><description>DocumentFormat.OpenXml.Math.Accent &lt;m:acc></description></item>
///<item><description>DocumentFormat.OpenXml.Math.Bar &lt;m:bar></description></item>
///<item><description>DocumentFormat.OpenXml.Math.Box &lt;m:box></description></item>
///<item><description>DocumentFormat.OpenXml.Math.BorderBox &lt;m:borderBox></description></item>
///<item><description>DocumentFormat.OpenXml.Math.Delimiter &lt;m:d></description></item>
///<item><description>DocumentFormat.OpenXml.Math.EquationArray &lt;m:eqArr></description></item>
///<item><description>DocumentFormat.OpenXml.Math.Fraction &lt;m:f></description></item>
///<item><description>DocumentFormat.OpenXml.Math.MathFunction &lt;m:func></description></item>
///<item><description>DocumentFormat.OpenXml.Math.GroupChar &lt;m:groupChr></description></item>
///<item><description>DocumentFormat.OpenXml.Math.LimitLower &lt;m:limLow></description></item>
///<item><description>DocumentFormat.OpenXml.Math.LimitUpper &lt;m:limUpp></description></item>
///<item><description>DocumentFormat.OpenXml.Math.Matrix &lt;m:m></description></item>
///<item><description>DocumentFormat.OpenXml.Math.Nary &lt;m:nary></description></item>
///<item><description>DocumentFormat.OpenXml.Math.Phantom &lt;m:phant></description></item>
///<item><description>DocumentFormat.OpenXml.Math.Radical &lt;m:rad></description></item>
///<item><description>DocumentFormat.OpenXml.Math.PreSubSuper &lt;m:sPre></description></item>
///<item><description>DocumentFormat.OpenXml.Math.Subscript &lt;m:sSub></description></item>
///<item><description>DocumentFormat.OpenXml.Math.SubSuperscript &lt;m:sSubSup></description></item>
///<item><description>DocumentFormat.OpenXml.Math.Superscript &lt;m:sSup></description></item>
///<item><description>DocumentFormat.OpenXml.Math.Run &lt;m:r></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.Run &lt;w:r></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride &lt;w:bdo></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.BidirectionalEmbedding &lt;w:dir></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class RunConflictInsertion : RunTrackChangeType
{
    internal const int ElementTypeIdConst = 12895;
    /// <inheritdoc/>
    public override string LocalName => "conflictIns";
    
    internal override byte NamespaceId => 52;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    /// <summary>
    /// Initializes a new instance of the RunConflictInsertion class.
    /// </summary>
    public RunConflictInsertion():base(){}
        /// <summary>
    ///Initializes a new instance of the RunConflictInsertion class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RunConflictInsertion(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the RunConflictInsertion class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RunConflictInsertion(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the RunConflictInsertion class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public RunConflictInsertion(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RunConflictInsertion>(deep);

}
/// <summary>
/// <para>Defines the RunConflictDeletion Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w14:conflictDel.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Wordprocessing.SdtRun &lt;w:sdt></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.ProofError &lt;w:proofErr></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.PermStart &lt;w:permStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.PermEnd &lt;w:permEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.BookmarkStart &lt;w:bookmarkStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd &lt;w:bookmarkEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart &lt;w:commentRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd &lt;w:commentRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart &lt;w:moveFromRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd &lt;w:moveFromRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart &lt;w:moveToRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd &lt;w:moveToRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart &lt;w:customXmlInsRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd &lt;w:customXmlInsRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart &lt;w:customXmlDelRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd &lt;w:customXmlDelRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart &lt;w:customXmlMoveFromRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd &lt;w:customXmlMoveFromRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart &lt;w:customXmlMoveToRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd &lt;w:customXmlMoveToRangeEnd></description></item>
///<item><description>CustomXmlConflictInsertionRangeStart &lt;w14:customXmlConflictInsRangeStart></description></item>
///<item><description>CustomXmlConflictInsertionRangeEnd &lt;w14:customXmlConflictInsRangeEnd></description></item>
///<item><description>CustomXmlConflictDeletionRangeStart &lt;w14:customXmlConflictDelRangeStart></description></item>
///<item><description>CustomXmlConflictDeletionRangeEnd &lt;w14:customXmlConflictDelRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.InsertedRun &lt;w:ins></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.DeletedRun &lt;w:del></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRun &lt;w:moveFrom></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRun &lt;w:moveTo></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.ContentPart &lt;w:contentPart></description></item>
///<item><description>RunConflictInsertion &lt;w14:conflictIns></description></item>
///<item><description>RunConflictDeletion &lt;w14:conflictDel></description></item>
///<item><description>DocumentFormat.OpenXml.Math.Paragraph &lt;m:oMathPara></description></item>
///<item><description>DocumentFormat.OpenXml.Math.OfficeMath &lt;m:oMath></description></item>
///<item><description>DocumentFormat.OpenXml.Math.Accent &lt;m:acc></description></item>
///<item><description>DocumentFormat.OpenXml.Math.Bar &lt;m:bar></description></item>
///<item><description>DocumentFormat.OpenXml.Math.Box &lt;m:box></description></item>
///<item><description>DocumentFormat.OpenXml.Math.BorderBox &lt;m:borderBox></description></item>
///<item><description>DocumentFormat.OpenXml.Math.Delimiter &lt;m:d></description></item>
///<item><description>DocumentFormat.OpenXml.Math.EquationArray &lt;m:eqArr></description></item>
///<item><description>DocumentFormat.OpenXml.Math.Fraction &lt;m:f></description></item>
///<item><description>DocumentFormat.OpenXml.Math.MathFunction &lt;m:func></description></item>
///<item><description>DocumentFormat.OpenXml.Math.GroupChar &lt;m:groupChr></description></item>
///<item><description>DocumentFormat.OpenXml.Math.LimitLower &lt;m:limLow></description></item>
///<item><description>DocumentFormat.OpenXml.Math.LimitUpper &lt;m:limUpp></description></item>
///<item><description>DocumentFormat.OpenXml.Math.Matrix &lt;m:m></description></item>
///<item><description>DocumentFormat.OpenXml.Math.Nary &lt;m:nary></description></item>
///<item><description>DocumentFormat.OpenXml.Math.Phantom &lt;m:phant></description></item>
///<item><description>DocumentFormat.OpenXml.Math.Radical &lt;m:rad></description></item>
///<item><description>DocumentFormat.OpenXml.Math.PreSubSuper &lt;m:sPre></description></item>
///<item><description>DocumentFormat.OpenXml.Math.Subscript &lt;m:sSub></description></item>
///<item><description>DocumentFormat.OpenXml.Math.SubSuperscript &lt;m:sSubSup></description></item>
///<item><description>DocumentFormat.OpenXml.Math.Superscript &lt;m:sSup></description></item>
///<item><description>DocumentFormat.OpenXml.Math.Run &lt;m:r></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.Run &lt;w:r></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride &lt;w:bdo></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.BidirectionalEmbedding &lt;w:dir></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class RunConflictDeletion : RunTrackChangeType
{
    internal const int ElementTypeIdConst = 12896;
    /// <inheritdoc/>
    public override string LocalName => "conflictDel";
    
    internal override byte NamespaceId => 52;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    /// <summary>
    /// Initializes a new instance of the RunConflictDeletion class.
    /// </summary>
    public RunConflictDeletion():base(){}
        /// <summary>
    ///Initializes a new instance of the RunConflictDeletion class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RunConflictDeletion(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the RunConflictDeletion class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RunConflictDeletion(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the RunConflictDeletion class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public RunConflictDeletion(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RunConflictDeletion>(deep);

}
/// <summary>
/// Defines the RunTrackChangeType class.
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Wordprocessing.SdtRun &lt;w:sdt></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.ProofError &lt;w:proofErr></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.PermStart &lt;w:permStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.PermEnd &lt;w:permEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.BookmarkStart &lt;w:bookmarkStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd &lt;w:bookmarkEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart &lt;w:commentRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd &lt;w:commentRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart &lt;w:moveFromRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd &lt;w:moveFromRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart &lt;w:moveToRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd &lt;w:moveToRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart &lt;w:customXmlInsRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd &lt;w:customXmlInsRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart &lt;w:customXmlDelRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd &lt;w:customXmlDelRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart &lt;w:customXmlMoveFromRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd &lt;w:customXmlMoveFromRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart &lt;w:customXmlMoveToRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd &lt;w:customXmlMoveToRangeEnd></description></item>
///<item><description>CustomXmlConflictInsertionRangeStart &lt;w14:customXmlConflictInsRangeStart></description></item>
///<item><description>CustomXmlConflictInsertionRangeEnd &lt;w14:customXmlConflictInsRangeEnd></description></item>
///<item><description>CustomXmlConflictDeletionRangeStart &lt;w14:customXmlConflictDelRangeStart></description></item>
///<item><description>CustomXmlConflictDeletionRangeEnd &lt;w14:customXmlConflictDelRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.InsertedRun &lt;w:ins></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.DeletedRun &lt;w:del></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRun &lt;w:moveFrom></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRun &lt;w:moveTo></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.ContentPart &lt;w:contentPart></description></item>
///<item><description>RunConflictInsertion &lt;w14:conflictIns></description></item>
///<item><description>RunConflictDeletion &lt;w14:conflictDel></description></item>
///<item><description>DocumentFormat.OpenXml.Math.Paragraph &lt;m:oMathPara></description></item>
///<item><description>DocumentFormat.OpenXml.Math.OfficeMath &lt;m:oMath></description></item>
///<item><description>DocumentFormat.OpenXml.Math.Accent &lt;m:acc></description></item>
///<item><description>DocumentFormat.OpenXml.Math.Bar &lt;m:bar></description></item>
///<item><description>DocumentFormat.OpenXml.Math.Box &lt;m:box></description></item>
///<item><description>DocumentFormat.OpenXml.Math.BorderBox &lt;m:borderBox></description></item>
///<item><description>DocumentFormat.OpenXml.Math.Delimiter &lt;m:d></description></item>
///<item><description>DocumentFormat.OpenXml.Math.EquationArray &lt;m:eqArr></description></item>
///<item><description>DocumentFormat.OpenXml.Math.Fraction &lt;m:f></description></item>
///<item><description>DocumentFormat.OpenXml.Math.MathFunction &lt;m:func></description></item>
///<item><description>DocumentFormat.OpenXml.Math.GroupChar &lt;m:groupChr></description></item>
///<item><description>DocumentFormat.OpenXml.Math.LimitLower &lt;m:limLow></description></item>
///<item><description>DocumentFormat.OpenXml.Math.LimitUpper &lt;m:limUpp></description></item>
///<item><description>DocumentFormat.OpenXml.Math.Matrix &lt;m:m></description></item>
///<item><description>DocumentFormat.OpenXml.Math.Nary &lt;m:nary></description></item>
///<item><description>DocumentFormat.OpenXml.Math.Phantom &lt;m:phant></description></item>
///<item><description>DocumentFormat.OpenXml.Math.Radical &lt;m:rad></description></item>
///<item><description>DocumentFormat.OpenXml.Math.PreSubSuper &lt;m:sPre></description></item>
///<item><description>DocumentFormat.OpenXml.Math.Subscript &lt;m:sSub></description></item>
///<item><description>DocumentFormat.OpenXml.Math.SubSuperscript &lt;m:sSubSup></description></item>
///<item><description>DocumentFormat.OpenXml.Math.Superscript &lt;m:sSup></description></item>
///<item><description>DocumentFormat.OpenXml.Math.Run &lt;m:r></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.Run &lt;w:r></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride &lt;w:bdo></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.BidirectionalEmbedding &lt;w:dir></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.SdtRun))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.ProofError))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.PermStart))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.PermEnd))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.BookmarkStart))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd))]
    [ChildElementInfo(typeof(CustomXmlConflictInsertionRangeStart), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(CustomXmlConflictInsertionRangeEnd), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(CustomXmlConflictDeletionRangeStart), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(CustomXmlConflictDeletionRangeEnd), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.InsertedRun))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.DeletedRun))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRun))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRun))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.ContentPart), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(RunConflictInsertion), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(RunConflictDeletion), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Math.Paragraph))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Math.OfficeMath))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Math.Accent))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Math.Bar))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Math.Box))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Math.BorderBox))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Math.Delimiter))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Math.EquationArray))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Math.Fraction))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Math.MathFunction))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Math.GroupChar))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Math.LimitLower))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Math.LimitUpper))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Math.Matrix))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Math.Nary))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Math.Phantom))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Math.Radical))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Math.PreSubSuper))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Math.Subscript))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Math.SubSuperscript))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Math.Superscript))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Math.Run))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.Run))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.BidirectionalEmbedding), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class RunTrackChangeType : OpenXmlCompositeElement
{
        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(23, "author"),
		AttributeTag.Create<DateTimeValue>(23, "date"),
		AttributeTag.Create<StringValue>(23, "id")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);
    
        /// <summary>
    /// <para> author.</para>
    /// <para>Represents the following attribute in the schema: w:author </para>
    /// </summary>
///<remark> xmlns:w=http://schemas.openxmlformats.org/wordprocessingml/2006/main
///</remark>
    [SchemaAttr(23, "author")]
    public StringValue Author
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> date.</para>
    /// <para>Represents the following attribute in the schema: w:date </para>
    /// </summary>
///<remark> xmlns:w=http://schemas.openxmlformats.org/wordprocessingml/2006/main
///</remark>
    [SchemaAttr(23, "date")]
    public DateTimeValue Date
    {
        get { return (DateTimeValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> Annotation Identifier.</para>
    /// <para>Represents the following attribute in the schema: w:id </para>
    /// </summary>
///<remark> xmlns:w=http://schemas.openxmlformats.org/wordprocessingml/2006/main
///</remark>
    [SchemaAttr(23, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 23 == namespaceId && "sdt" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.SdtRun();
    
if( 23 == namespaceId && "proofErr" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.ProofError();
    
if( 23 == namespaceId && "permStart" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.PermStart();
    
if( 23 == namespaceId && "permEnd" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.PermEnd();
    
if( 23 == namespaceId && "bookmarkStart" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.BookmarkStart();
    
if( 23 == namespaceId && "bookmarkEnd" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd();
    
if( 23 == namespaceId && "commentRangeStart" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart();
    
if( 23 == namespaceId && "commentRangeEnd" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd();
    
if( 23 == namespaceId && "moveFromRangeStart" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart();
    
if( 23 == namespaceId && "moveFromRangeEnd" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd();
    
if( 23 == namespaceId && "moveToRangeStart" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart();
    
if( 23 == namespaceId && "moveToRangeEnd" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd();
    
if( 23 == namespaceId && "customXmlInsRangeStart" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart();
    
if( 23 == namespaceId && "customXmlInsRangeEnd" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd();
    
if( 23 == namespaceId && "customXmlDelRangeStart" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart();
    
if( 23 == namespaceId && "customXmlDelRangeEnd" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd();
    
if( 23 == namespaceId && "customXmlMoveFromRangeStart" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart();
    
if( 23 == namespaceId && "customXmlMoveFromRangeEnd" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd();
    
if( 23 == namespaceId && "customXmlMoveToRangeStart" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart();
    
if( 23 == namespaceId && "customXmlMoveToRangeEnd" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd();
    
if( 52 == namespaceId && "customXmlConflictInsRangeStart" == name)
    return new CustomXmlConflictInsertionRangeStart();
    
if( 52 == namespaceId && "customXmlConflictInsRangeEnd" == name)
    return new CustomXmlConflictInsertionRangeEnd();
    
if( 52 == namespaceId && "customXmlConflictDelRangeStart" == name)
    return new CustomXmlConflictDeletionRangeStart();
    
if( 52 == namespaceId && "customXmlConflictDelRangeEnd" == name)
    return new CustomXmlConflictDeletionRangeEnd();
    
if( 23 == namespaceId && "ins" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.InsertedRun();
    
if( 23 == namespaceId && "del" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.DeletedRun();
    
if( 23 == namespaceId && "moveFrom" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.MoveFromRun();
    
if( 23 == namespaceId && "moveTo" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.MoveToRun();
    
if( 23 == namespaceId && "contentPart" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.ContentPart();
    
if( 52 == namespaceId && "conflictIns" == name)
    return new RunConflictInsertion();
    
if( 52 == namespaceId && "conflictDel" == name)
    return new RunConflictDeletion();
    
if( 21 == namespaceId && "oMathPara" == name)
    return new DocumentFormat.OpenXml.Math.Paragraph();
    
if( 21 == namespaceId && "oMath" == name)
    return new DocumentFormat.OpenXml.Math.OfficeMath();
    
if( 21 == namespaceId && "acc" == name)
    return new DocumentFormat.OpenXml.Math.Accent();
    
if( 21 == namespaceId && "bar" == name)
    return new DocumentFormat.OpenXml.Math.Bar();
    
if( 21 == namespaceId && "box" == name)
    return new DocumentFormat.OpenXml.Math.Box();
    
if( 21 == namespaceId && "borderBox" == name)
    return new DocumentFormat.OpenXml.Math.BorderBox();
    
if( 21 == namespaceId && "d" == name)
    return new DocumentFormat.OpenXml.Math.Delimiter();
    
if( 21 == namespaceId && "eqArr" == name)
    return new DocumentFormat.OpenXml.Math.EquationArray();
    
if( 21 == namespaceId && "f" == name)
    return new DocumentFormat.OpenXml.Math.Fraction();
    
if( 21 == namespaceId && "func" == name)
    return new DocumentFormat.OpenXml.Math.MathFunction();
    
if( 21 == namespaceId && "groupChr" == name)
    return new DocumentFormat.OpenXml.Math.GroupChar();
    
if( 21 == namespaceId && "limLow" == name)
    return new DocumentFormat.OpenXml.Math.LimitLower();
    
if( 21 == namespaceId && "limUpp" == name)
    return new DocumentFormat.OpenXml.Math.LimitUpper();
    
if( 21 == namespaceId && "m" == name)
    return new DocumentFormat.OpenXml.Math.Matrix();
    
if( 21 == namespaceId && "nary" == name)
    return new DocumentFormat.OpenXml.Math.Nary();
    
if( 21 == namespaceId && "phant" == name)
    return new DocumentFormat.OpenXml.Math.Phantom();
    
if( 21 == namespaceId && "rad" == name)
    return new DocumentFormat.OpenXml.Math.Radical();
    
if( 21 == namespaceId && "sPre" == name)
    return new DocumentFormat.OpenXml.Math.PreSubSuper();
    
if( 21 == namespaceId && "sSub" == name)
    return new DocumentFormat.OpenXml.Math.Subscript();
    
if( 21 == namespaceId && "sSubSup" == name)
    return new DocumentFormat.OpenXml.Math.SubSuperscript();
    
if( 21 == namespaceId && "sSup" == name)
    return new DocumentFormat.OpenXml.Math.Superscript();
    
if( 21 == namespaceId && "r" == name)
    return new DocumentFormat.OpenXml.Math.Run();
    
if( 23 == namespaceId && "r" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.Run();
    
if( 23 == namespaceId && "bdo" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride();
    
if( 23 == namespaceId && "dir" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.BidirectionalEmbedding();
    

    return null;
}

    
    
    /// <summary>
    /// Initializes a new instance of the RunTrackChangeType class.
    /// </summary>
    protected RunTrackChangeType(){}
    
        /// <summary>
    ///Initializes a new instance of the RunTrackChangeType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected RunTrackChangeType(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the RunTrackChangeType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected RunTrackChangeType(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the RunTrackChangeType class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    protected RunTrackChangeType(string outerXml)
        : base(outerXml)
    {
    }

    
}
/// <summary>
/// <para>Defines the ConflictInsertion Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w14:conflictIns.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ConflictInsertion : TrackChangeType
{
    internal const int ElementTypeIdConst = 12897;
    /// <inheritdoc/>
    public override string LocalName => "conflictIns";
    
    internal override byte NamespaceId => 52;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    /// <summary>
    /// Initializes a new instance of the ConflictInsertion class.
    /// </summary>
    public ConflictInsertion():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ConflictInsertion>(deep);

}
/// <summary>
/// <para>Defines the ConflictDeletion Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w14:conflictDel.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ConflictDeletion : TrackChangeType
{
    internal const int ElementTypeIdConst = 12898;
    /// <inheritdoc/>
    public override string LocalName => "conflictDel";
    
    internal override byte NamespaceId => 52;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    /// <summary>
    /// Initializes a new instance of the ConflictDeletion class.
    /// </summary>
    public ConflictDeletion():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ConflictDeletion>(deep);

}
/// <summary>
/// <para>Defines the CustomXmlConflictInsertionRangeStart Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w14:customXmlConflictInsRangeStart.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class CustomXmlConflictInsertionRangeStart : TrackChangeType
{
    internal const int ElementTypeIdConst = 12935;
    /// <inheritdoc/>
    public override string LocalName => "customXmlConflictInsRangeStart";
    
    internal override byte NamespaceId => 52;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    /// <summary>
    /// Initializes a new instance of the CustomXmlConflictInsertionRangeStart class.
    /// </summary>
    public CustomXmlConflictInsertionRangeStart():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<CustomXmlConflictInsertionRangeStart>(deep);

}
/// <summary>
/// <para>Defines the CustomXmlConflictDeletionRangeStart Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w14:customXmlConflictDelRangeStart.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class CustomXmlConflictDeletionRangeStart : TrackChangeType
{
    internal const int ElementTypeIdConst = 12937;
    /// <inheritdoc/>
    public override string LocalName => "customXmlConflictDelRangeStart";
    
    internal override byte NamespaceId => 52;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    /// <summary>
    /// Initializes a new instance of the CustomXmlConflictDeletionRangeStart class.
    /// </summary>
    public CustomXmlConflictDeletionRangeStart():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<CustomXmlConflictDeletionRangeStart>(deep);

}
/// <summary>
/// Defines the TrackChangeType class.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class TrackChangeType : OpenXmlLeafElement
{
        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(23, "author"),
		AttributeTag.Create<DateTimeValue>(23, "date"),
		AttributeTag.Create<StringValue>(23, "id")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);
    
        /// <summary>
    /// <para> author.</para>
    /// <para>Represents the following attribute in the schema: w:author </para>
    /// </summary>
///<remark> xmlns:w=http://schemas.openxmlformats.org/wordprocessingml/2006/main
///</remark>
    [SchemaAttr(23, "author")]
    public StringValue Author
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> date.</para>
    /// <para>Represents the following attribute in the schema: w:date </para>
    /// </summary>
///<remark> xmlns:w=http://schemas.openxmlformats.org/wordprocessingml/2006/main
///</remark>
    [SchemaAttr(23, "date")]
    public DateTimeValue Date
    {
        get { return (DateTimeValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> Annotation Identifier.</para>
    /// <para>Represents the following attribute in the schema: w:id </para>
    /// </summary>
///<remark> xmlns:w=http://schemas.openxmlformats.org/wordprocessingml/2006/main
///</remark>
    [SchemaAttr(23, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the TrackChangeType class.
    /// </summary>
    protected TrackChangeType(){}
    
    
    
}
/// <summary>
/// <para>Defines the Tint Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w14:tint.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class Tint : PositiveFixedPercentageType
{
    internal const int ElementTypeIdConst = 12899;
    /// <inheritdoc/>
    public override string LocalName => "tint";
    
    internal override byte NamespaceId => 52;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    /// <summary>
    /// Initializes a new instance of the Tint class.
    /// </summary>
    public Tint():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Tint>(deep);

}
/// <summary>
/// <para>Defines the Shade Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w14:shade.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class Shade : PositiveFixedPercentageType
{
    internal const int ElementTypeIdConst = 12900;
    /// <inheritdoc/>
    public override string LocalName => "shade";
    
    internal override byte NamespaceId => 52;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    /// <summary>
    /// Initializes a new instance of the Shade class.
    /// </summary>
    public Shade():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Shade>(deep);

}
/// <summary>
/// <para>Defines the Alpha Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w14:alpha.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class Alpha : PositiveFixedPercentageType
{
    internal const int ElementTypeIdConst = 12901;
    /// <inheritdoc/>
    public override string LocalName => "alpha";
    
    internal override byte NamespaceId => 52;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    /// <summary>
    /// Initializes a new instance of the Alpha class.
    /// </summary>
    public Alpha():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Alpha>(deep);

}
/// <summary>
/// Defines the PositiveFixedPercentageType class.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class PositiveFixedPercentageType : OpenXmlLeafElement
{
        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<Int32Value>(52, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);
    
        /// <summary>
    /// <para> val.</para>
    /// <para>Represents the following attribute in the schema: w14:val </para>
    /// </summary>
///<remark> xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
///</remark>
    [SchemaAttr(52, "val")]
    public Int32Value Val
    {
        get { return (Int32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the PositiveFixedPercentageType class.
    /// </summary>
    protected PositiveFixedPercentageType(){}
    
    
    
}
/// <summary>
/// <para>Defines the HueModulation Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w14:hueMod.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class HueModulation : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12902;
    /// <inheritdoc/>
    public override string LocalName => "hueMod";
    
    internal override byte NamespaceId => 52;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<Int32Value>(52, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> val.</para>
    /// <para>Represents the following attribute in the schema: w14:val </para>
    /// </summary>
///<remark> xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
///</remark>
    [SchemaAttr(52, "val")]
    public Int32Value Val
    {
        get { return (Int32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the HueModulation class.
    /// </summary>
    public HueModulation():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<HueModulation>(deep);

}
/// <summary>
/// <para>Defines the Saturation Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w14:sat.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class Saturation : PercentageType
{
    internal const int ElementTypeIdConst = 12903;
    /// <inheritdoc/>
    public override string LocalName => "sat";
    
    internal override byte NamespaceId => 52;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    /// <summary>
    /// Initializes a new instance of the Saturation class.
    /// </summary>
    public Saturation():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Saturation>(deep);

}
/// <summary>
/// <para>Defines the SaturationOffset Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w14:satOff.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class SaturationOffset : PercentageType
{
    internal const int ElementTypeIdConst = 12904;
    /// <inheritdoc/>
    public override string LocalName => "satOff";
    
    internal override byte NamespaceId => 52;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    /// <summary>
    /// Initializes a new instance of the SaturationOffset class.
    /// </summary>
    public SaturationOffset():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SaturationOffset>(deep);

}
/// <summary>
/// <para>Defines the SaturationModulation Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w14:satMod.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class SaturationModulation : PercentageType
{
    internal const int ElementTypeIdConst = 12905;
    /// <inheritdoc/>
    public override string LocalName => "satMod";
    
    internal override byte NamespaceId => 52;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    /// <summary>
    /// Initializes a new instance of the SaturationModulation class.
    /// </summary>
    public SaturationModulation():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SaturationModulation>(deep);

}
/// <summary>
/// <para>Defines the Luminance Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w14:lum.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class Luminance : PercentageType
{
    internal const int ElementTypeIdConst = 12906;
    /// <inheritdoc/>
    public override string LocalName => "lum";
    
    internal override byte NamespaceId => 52;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    /// <summary>
    /// Initializes a new instance of the Luminance class.
    /// </summary>
    public Luminance():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Luminance>(deep);

}
/// <summary>
/// <para>Defines the LuminanceOffset Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w14:lumOff.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class LuminanceOffset : PercentageType
{
    internal const int ElementTypeIdConst = 12907;
    /// <inheritdoc/>
    public override string LocalName => "lumOff";
    
    internal override byte NamespaceId => 52;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    /// <summary>
    /// Initializes a new instance of the LuminanceOffset class.
    /// </summary>
    public LuminanceOffset():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<LuminanceOffset>(deep);

}
/// <summary>
/// <para>Defines the LuminanceModulation Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w14:lumMod.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class LuminanceModulation : PercentageType
{
    internal const int ElementTypeIdConst = 12908;
    /// <inheritdoc/>
    public override string LocalName => "lumMod";
    
    internal override byte NamespaceId => 52;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    /// <summary>
    /// Initializes a new instance of the LuminanceModulation class.
    /// </summary>
    public LuminanceModulation():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<LuminanceModulation>(deep);

}
/// <summary>
/// Defines the PercentageType class.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class PercentageType : OpenXmlLeafElement
{
        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<Int32Value>(52, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);
    
        /// <summary>
    /// <para> val.</para>
    /// <para>Represents the following attribute in the schema: w14:val </para>
    /// </summary>
///<remark> xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
///</remark>
    [SchemaAttr(52, "val")]
    public Int32Value Val
    {
        get { return (Int32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the PercentageType class.
    /// </summary>
    protected PercentageType(){}
    
    
    
}
/// <summary>
/// <para>Defines the RgbColorModelHex Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w14:srgbClr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Tint &lt;w14:tint></description></item>
///<item><description>Shade &lt;w14:shade></description></item>
///<item><description>Alpha &lt;w14:alpha></description></item>
///<item><description>HueModulation &lt;w14:hueMod></description></item>
///<item><description>Saturation &lt;w14:sat></description></item>
///<item><description>SaturationOffset &lt;w14:satOff></description></item>
///<item><description>SaturationModulation &lt;w14:satMod></description></item>
///<item><description>Luminance &lt;w14:lum></description></item>
///<item><description>LuminanceOffset &lt;w14:lumOff></description></item>
///<item><description>LuminanceModulation &lt;w14:lumMod></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Tint), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(Shade), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(Alpha), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(HueModulation), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(Saturation), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(SaturationOffset), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(SaturationModulation), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(Luminance), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(LuminanceOffset), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(LuminanceModulation), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class RgbColorModelHex : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12909;
    /// <inheritdoc/>
    public override string LocalName => "srgbClr";
    
    internal override byte NamespaceId => 52;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<HexBinaryValue>(52, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> val.</para>
    /// <para>Represents the following attribute in the schema: w14:val </para>
    /// </summary>
///<remark> xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
///</remark>
    [SchemaAttr(52, "val")]
    public HexBinaryValue Val
    {
        get { return (HexBinaryValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the RgbColorModelHex class.
    /// </summary>
    public RgbColorModelHex():base(){}
    
        /// <summary>
    ///Initializes a new instance of the RgbColorModelHex class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RgbColorModelHex(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the RgbColorModelHex class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RgbColorModelHex(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the RgbColorModelHex class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public RgbColorModelHex(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 52 == namespaceId && "tint" == name)
    return new Tint();
    
if( 52 == namespaceId && "shade" == name)
    return new Shade();
    
if( 52 == namespaceId && "alpha" == name)
    return new Alpha();
    
if( 52 == namespaceId && "hueMod" == name)
    return new HueModulation();
    
if( 52 == namespaceId && "sat" == name)
    return new Saturation();
    
if( 52 == namespaceId && "satOff" == name)
    return new SaturationOffset();
    
if( 52 == namespaceId && "satMod" == name)
    return new SaturationModulation();
    
if( 52 == namespaceId && "lum" == name)
    return new Luminance();
    
if( 52 == namespaceId && "lumOff" == name)
    return new LuminanceOffset();
    
if( 52 == namespaceId && "lumMod" == name)
    return new LuminanceModulation();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RgbColorModelHex>(deep);

}
/// <summary>
/// <para>Defines the SchemeColor Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w14:schemeClr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Tint &lt;w14:tint></description></item>
///<item><description>Shade &lt;w14:shade></description></item>
///<item><description>Alpha &lt;w14:alpha></description></item>
///<item><description>HueModulation &lt;w14:hueMod></description></item>
///<item><description>Saturation &lt;w14:sat></description></item>
///<item><description>SaturationOffset &lt;w14:satOff></description></item>
///<item><description>SaturationModulation &lt;w14:satMod></description></item>
///<item><description>Luminance &lt;w14:lum></description></item>
///<item><description>LuminanceOffset &lt;w14:lumOff></description></item>
///<item><description>LuminanceModulation &lt;w14:lumMod></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Tint), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(Shade), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(Alpha), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(HueModulation), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(Saturation), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(SaturationOffset), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(SaturationModulation), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(Luminance), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(LuminanceOffset), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(LuminanceModulation), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class SchemeColor : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12910;
    /// <inheritdoc/>
    public override string LocalName => "schemeClr";
    
    internal override byte NamespaceId => 52;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.Word.SchemeColorValues>>(52, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> val.</para>
    /// <para>Represents the following attribute in the schema: w14:val </para>
    /// </summary>
///<remark> xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
///</remark>
    [SchemaAttr(52, "val")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.Word.SchemeColorValues> Val
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.Word.SchemeColorValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the SchemeColor class.
    /// </summary>
    public SchemeColor():base(){}
    
        /// <summary>
    ///Initializes a new instance of the SchemeColor class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SchemeColor(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the SchemeColor class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SchemeColor(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the SchemeColor class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public SchemeColor(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 52 == namespaceId && "tint" == name)
    return new Tint();
    
if( 52 == namespaceId && "shade" == name)
    return new Shade();
    
if( 52 == namespaceId && "alpha" == name)
    return new Alpha();
    
if( 52 == namespaceId && "hueMod" == name)
    return new HueModulation();
    
if( 52 == namespaceId && "sat" == name)
    return new Saturation();
    
if( 52 == namespaceId && "satOff" == name)
    return new SaturationOffset();
    
if( 52 == namespaceId && "satMod" == name)
    return new SaturationModulation();
    
if( 52 == namespaceId && "lum" == name)
    return new Luminance();
    
if( 52 == namespaceId && "lumOff" == name)
    return new LuminanceOffset();
    
if( 52 == namespaceId && "lumMod" == name)
    return new LuminanceModulation();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SchemeColor>(deep);

}
/// <summary>
/// <para>Defines the LinearShadeProperties Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w14:lin.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class LinearShadeProperties : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12911;
    /// <inheritdoc/>
    public override string LocalName => "lin";
    
    internal override byte NamespaceId => 52;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<Int32Value>(52, "ang"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.Word.OnOffValues>>(52, "scaled")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> ang.</para>
    /// <para>Represents the following attribute in the schema: w14:ang </para>
    /// </summary>
///<remark> xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
///</remark>
    [SchemaAttr(52, "ang")]
    public Int32Value Angle
    {
        get { return (Int32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> scaled.</para>
    /// <para>Represents the following attribute in the schema: w14:scaled </para>
    /// </summary>
///<remark> xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
///</remark>
    [SchemaAttr(52, "scaled")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.Word.OnOffValues> Scaled
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.Word.OnOffValues>)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the LinearShadeProperties class.
    /// </summary>
    public LinearShadeProperties():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<LinearShadeProperties>(deep);

}
/// <summary>
/// <para>Defines the PathShadeProperties Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w14:path.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>FillToRectangle &lt;w14:fillToRect></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(FillToRectangle), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class PathShadeProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12912;
    /// <inheritdoc/>
    public override string LocalName => "path";
    
    internal override byte NamespaceId => 52;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.Word.PathShadeTypeValues>>(52, "path")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> path.</para>
    /// <para>Represents the following attribute in the schema: w14:path </para>
    /// </summary>
///<remark> xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
///</remark>
    [SchemaAttr(52, "path")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.Word.PathShadeTypeValues> Path
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.Word.PathShadeTypeValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the PathShadeProperties class.
    /// </summary>
    public PathShadeProperties():base(){}
    
        /// <summary>
    ///Initializes a new instance of the PathShadeProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PathShadeProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the PathShadeProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PathShadeProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the PathShadeProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public PathShadeProperties(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 52 == namespaceId && "fillToRect" == name)
    return new FillToRectangle();
    

    return null;
}

        private static readonly string[] eleTagNames = { "fillToRect" };
    private static readonly byte[] eleNamespaceIds = { 52 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> FillToRectangle.</para>
    /// <para> Represents the following element tag in the schema: w14:fillToRect </para>
    /// </summary>
    /// <remark>
    /// xmlns:w14 = http://schemas.microsoft.com/office/word/2010/wordml
    /// </remark>
    public FillToRectangle FillToRectangle
    {
        get => GetElement<FillToRectangle>(0);
        set => SetElement(0, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PathShadeProperties>(deep);

}
/// <summary>
/// <para>Defines the NoFillEmpty Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w14:noFill.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class NoFillEmpty : EmptyType
{
    internal const int ElementTypeIdConst = 12913;
    /// <inheritdoc/>
    public override string LocalName => "noFill";
    
    internal override byte NamespaceId => 52;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    /// <summary>
    /// Initializes a new instance of the NoFillEmpty class.
    /// </summary>
    public NoFillEmpty():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<NoFillEmpty>(deep);

}
/// <summary>
/// <para>Defines the RoundEmpty Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w14:round.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class RoundEmpty : EmptyType
{
    internal const int ElementTypeIdConst = 12917;
    /// <inheritdoc/>
    public override string LocalName => "round";
    
    internal override byte NamespaceId => 52;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    /// <summary>
    /// Initializes a new instance of the RoundEmpty class.
    /// </summary>
    public RoundEmpty():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RoundEmpty>(deep);

}
/// <summary>
/// <para>Defines the BevelEmpty Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w14:bevel.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class BevelEmpty : EmptyType
{
    internal const int ElementTypeIdConst = 12918;
    /// <inheritdoc/>
    public override string LocalName => "bevel";
    
    internal override byte NamespaceId => 52;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    /// <summary>
    /// Initializes a new instance of the BevelEmpty class.
    /// </summary>
    public BevelEmpty():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<BevelEmpty>(deep);

}
/// <summary>
/// <para>Defines the EntityPickerEmpty Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w14:entityPicker.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class EntityPickerEmpty : EmptyType
{
    internal const int ElementTypeIdConst = 12941;
    /// <inheritdoc/>
    public override string LocalName => "entityPicker";
    
    internal override byte NamespaceId => 52;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    /// <summary>
    /// Initializes a new instance of the EntityPickerEmpty class.
    /// </summary>
    public EntityPickerEmpty():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<EntityPickerEmpty>(deep);

}
/// <summary>
/// Defines the EmptyType class.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class EmptyType : OpenXmlLeafElement
{
        
    
    
    
    
    /// <summary>
    /// Initializes a new instance of the EmptyType class.
    /// </summary>
    protected EmptyType(){}
    
    
    
}
/// <summary>
/// <para>Defines the SolidColorFillProperties Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w14:solidFill.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>RgbColorModelHex &lt;w14:srgbClr></description></item>
///<item><description>SchemeColor &lt;w14:schemeClr></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(RgbColorModelHex), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(SchemeColor), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class SolidColorFillProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12914;
    /// <inheritdoc/>
    public override string LocalName => "solidFill";
    
    internal override byte NamespaceId => 52;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the SolidColorFillProperties class.
    /// </summary>
    public SolidColorFillProperties():base(){}
    
        /// <summary>
    ///Initializes a new instance of the SolidColorFillProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SolidColorFillProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the SolidColorFillProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SolidColorFillProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the SolidColorFillProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public SolidColorFillProperties(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 52 == namespaceId && "srgbClr" == name)
    return new RgbColorModelHex();
    
if( 52 == namespaceId && "schemeClr" == name)
    return new SchemeColor();
    

    return null;
}

        private static readonly string[] eleTagNames = { "srgbClr","schemeClr" };
    private static readonly byte[] eleNamespaceIds = { 52,52 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneChoice;
    
        /// <summary>
    /// <para> RgbColorModelHex.</para>
    /// <para> Represents the following element tag in the schema: w14:srgbClr </para>
    /// </summary>
    /// <remark>
    /// xmlns:w14 = http://schemas.microsoft.com/office/word/2010/wordml
    /// </remark>
    public RgbColorModelHex RgbColorModelHex
    {
        get => GetElement<RgbColorModelHex>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> SchemeColor.</para>
    /// <para> Represents the following element tag in the schema: w14:schemeClr </para>
    /// </summary>
    /// <remark>
    /// xmlns:w14 = http://schemas.microsoft.com/office/word/2010/wordml
    /// </remark>
    public SchemeColor SchemeColor
    {
        get => GetElement<SchemeColor>(1);
        set => SetElement(1, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SolidColorFillProperties>(deep);

}
/// <summary>
/// <para>Defines the GradientFillProperties Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w14:gradFill.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>GradientStopList &lt;w14:gsLst></description></item>
///<item><description>LinearShadeProperties &lt;w14:lin></description></item>
///<item><description>PathShadeProperties &lt;w14:path></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(GradientStopList), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(LinearShadeProperties), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(PathShadeProperties), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class GradientFillProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12915;
    /// <inheritdoc/>
    public override string LocalName => "gradFill";
    
    internal override byte NamespaceId => 52;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the GradientFillProperties class.
    /// </summary>
    public GradientFillProperties():base(){}
    
        /// <summary>
    ///Initializes a new instance of the GradientFillProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public GradientFillProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the GradientFillProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public GradientFillProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the GradientFillProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public GradientFillProperties(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 52 == namespaceId && "gsLst" == name)
    return new GradientStopList();
    
if( 52 == namespaceId && "lin" == name)
    return new LinearShadeProperties();
    
if( 52 == namespaceId && "path" == name)
    return new PathShadeProperties();
    

    return null;
}

        private static readonly string[] eleTagNames = { "gsLst","lin","path" };
    private static readonly byte[] eleNamespaceIds = { 52,52,52 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> GradientStopList.</para>
    /// <para> Represents the following element tag in the schema: w14:gsLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:w14 = http://schemas.microsoft.com/office/word/2010/wordml
    /// </remark>
    public GradientStopList GradientStopList
    {
        get => GetElement<GradientStopList>(0);
        set => SetElement(0, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<GradientFillProperties>(deep);

}
/// <summary>
/// <para>Defines the PresetLineDashProperties Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w14:prstDash.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class PresetLineDashProperties : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12916;
    /// <inheritdoc/>
    public override string LocalName => "prstDash";
    
    internal override byte NamespaceId => 52;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.Word.PresetLineDashValues>>(52, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> val.</para>
    /// <para>Represents the following attribute in the schema: w14:val </para>
    /// </summary>
///<remark> xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
///</remark>
    [SchemaAttr(52, "val")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.Word.PresetLineDashValues> Val
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.Word.PresetLineDashValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the PresetLineDashProperties class.
    /// </summary>
    public PresetLineDashProperties():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PresetLineDashProperties>(deep);

}
/// <summary>
/// <para>Defines the LineJoinMiterProperties Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w14:miter.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class LineJoinMiterProperties : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12919;
    /// <inheritdoc/>
    public override string LocalName => "miter";
    
    internal override byte NamespaceId => 52;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<Int32Value>(52, "lim")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> lim.</para>
    /// <para>Represents the following attribute in the schema: w14:lim </para>
    /// </summary>
///<remark> xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
///</remark>
    [SchemaAttr(52, "lim")]
    public Int32Value Limit
    {
        get { return (Int32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the LineJoinMiterProperties class.
    /// </summary>
    public LineJoinMiterProperties():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<LineJoinMiterProperties>(deep);

}
/// <summary>
/// <para>Defines the Glow Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w14:glow.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>RgbColorModelHex &lt;w14:srgbClr></description></item>
///<item><description>SchemeColor &lt;w14:schemeClr></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(RgbColorModelHex), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(SchemeColor), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class Glow : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12920;
    /// <inheritdoc/>
    public override string LocalName => "glow";
    
    internal override byte NamespaceId => 52;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<Int64Value>(52, "rad")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> rad.</para>
    /// <para>Represents the following attribute in the schema: w14:rad </para>
    /// </summary>
///<remark> xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
///</remark>
    [SchemaAttr(52, "rad")]
    public Int64Value GlowRadius
    {
        get { return (Int64Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Glow class.
    /// </summary>
    public Glow():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Glow class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Glow(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Glow class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Glow(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Glow class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Glow(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 52 == namespaceId && "srgbClr" == name)
    return new RgbColorModelHex();
    
if( 52 == namespaceId && "schemeClr" == name)
    return new SchemeColor();
    

    return null;
}

        private static readonly string[] eleTagNames = { "srgbClr","schemeClr" };
    private static readonly byte[] eleNamespaceIds = { 52,52 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneChoice;
    
        /// <summary>
    /// <para> RgbColorModelHex.</para>
    /// <para> Represents the following element tag in the schema: w14:srgbClr </para>
    /// </summary>
    /// <remark>
    /// xmlns:w14 = http://schemas.microsoft.com/office/word/2010/wordml
    /// </remark>
    public RgbColorModelHex RgbColorModelHex
    {
        get => GetElement<RgbColorModelHex>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> SchemeColor.</para>
    /// <para> Represents the following element tag in the schema: w14:schemeClr </para>
    /// </summary>
    /// <remark>
    /// xmlns:w14 = http://schemas.microsoft.com/office/word/2010/wordml
    /// </remark>
    public SchemeColor SchemeColor
    {
        get => GetElement<SchemeColor>(1);
        set => SetElement(1, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Glow>(deep);

}
/// <summary>
/// <para>Defines the Shadow Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w14:shadow.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>RgbColorModelHex &lt;w14:srgbClr></description></item>
///<item><description>SchemeColor &lt;w14:schemeClr></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(RgbColorModelHex), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(SchemeColor), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class Shadow : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12921;
    /// <inheritdoc/>
    public override string LocalName => "shadow";
    
    internal override byte NamespaceId => 52;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<Int64Value>(52, "blurRad"),
		AttributeTag.Create<Int64Value>(52, "dist"),
		AttributeTag.Create<Int32Value>(52, "dir"),
		AttributeTag.Create<Int32Value>(52, "sx"),
		AttributeTag.Create<Int32Value>(52, "sy"),
		AttributeTag.Create<Int32Value>(52, "kx"),
		AttributeTag.Create<Int32Value>(52, "ky"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.Word.RectangleAlignmentValues>>(52, "algn")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> blurRad.</para>
    /// <para>Represents the following attribute in the schema: w14:blurRad </para>
    /// </summary>
///<remark> xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
///</remark>
    [SchemaAttr(52, "blurRad")]
    public Int64Value BlurRadius
    {
        get { return (Int64Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> dist.</para>
    /// <para>Represents the following attribute in the schema: w14:dist </para>
    /// </summary>
///<remark> xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
///</remark>
    [SchemaAttr(52, "dist")]
    public Int64Value DistanceFromText
    {
        get { return (Int64Value)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> dir.</para>
    /// <para>Represents the following attribute in the schema: w14:dir </para>
    /// </summary>
///<remark> xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
///</remark>
    [SchemaAttr(52, "dir")]
    public Int32Value DirectionAngle
    {
        get { return (Int32Value)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> sx.</para>
    /// <para>Represents the following attribute in the schema: w14:sx </para>
    /// </summary>
///<remark> xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
///</remark>
    [SchemaAttr(52, "sx")]
    public Int32Value HorizontalScalingFactor
    {
        get { return (Int32Value)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> sy.</para>
    /// <para>Represents the following attribute in the schema: w14:sy </para>
    /// </summary>
///<remark> xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
///</remark>
    [SchemaAttr(52, "sy")]
    public Int32Value VerticalScalingFactor
    {
        get { return (Int32Value)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> kx.</para>
    /// <para>Represents the following attribute in the schema: w14:kx </para>
    /// </summary>
///<remark> xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
///</remark>
    [SchemaAttr(52, "kx")]
    public Int32Value HorizontalSkewAngle
    {
        get { return (Int32Value)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> ky.</para>
    /// <para>Represents the following attribute in the schema: w14:ky </para>
    /// </summary>
///<remark> xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
///</remark>
    [SchemaAttr(52, "ky")]
    public Int32Value VerticalSkewAngle
    {
        get { return (Int32Value)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> algn.</para>
    /// <para>Represents the following attribute in the schema: w14:algn </para>
    /// </summary>
///<remark> xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
///</remark>
    [SchemaAttr(52, "algn")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.Word.RectangleAlignmentValues> Alignment
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.Word.RectangleAlignmentValues>)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Shadow class.
    /// </summary>
    public Shadow():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Shadow class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Shadow(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Shadow class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Shadow(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Shadow class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Shadow(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 52 == namespaceId && "srgbClr" == name)
    return new RgbColorModelHex();
    
if( 52 == namespaceId && "schemeClr" == name)
    return new SchemeColor();
    

    return null;
}

        private static readonly string[] eleTagNames = { "srgbClr","schemeClr" };
    private static readonly byte[] eleNamespaceIds = { 52,52 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneChoice;
    
        /// <summary>
    /// <para> RgbColorModelHex.</para>
    /// <para> Represents the following element tag in the schema: w14:srgbClr </para>
    /// </summary>
    /// <remark>
    /// xmlns:w14 = http://schemas.microsoft.com/office/word/2010/wordml
    /// </remark>
    public RgbColorModelHex RgbColorModelHex
    {
        get => GetElement<RgbColorModelHex>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> SchemeColor.</para>
    /// <para> Represents the following element tag in the schema: w14:schemeClr </para>
    /// </summary>
    /// <remark>
    /// xmlns:w14 = http://schemas.microsoft.com/office/word/2010/wordml
    /// </remark>
    public SchemeColor SchemeColor
    {
        get => GetElement<SchemeColor>(1);
        set => SetElement(1, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Shadow>(deep);

}
/// <summary>
/// <para>Defines the Reflection Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w14:reflection.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class Reflection : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12922;
    /// <inheritdoc/>
    public override string LocalName => "reflection";
    
    internal override byte NamespaceId => 52;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<Int64Value>(52, "blurRad"),
		AttributeTag.Create<Int32Value>(52, "stA"),
		AttributeTag.Create<Int32Value>(52, "stPos"),
		AttributeTag.Create<Int32Value>(52, "endA"),
		AttributeTag.Create<Int32Value>(52, "endPos"),
		AttributeTag.Create<Int64Value>(52, "dist"),
		AttributeTag.Create<Int32Value>(52, "dir"),
		AttributeTag.Create<Int32Value>(52, "fadeDir"),
		AttributeTag.Create<Int32Value>(52, "sx"),
		AttributeTag.Create<Int32Value>(52, "sy"),
		AttributeTag.Create<Int32Value>(52, "kx"),
		AttributeTag.Create<Int32Value>(52, "ky"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.Word.RectangleAlignmentValues>>(52, "algn")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> blurRad.</para>
    /// <para>Represents the following attribute in the schema: w14:blurRad </para>
    /// </summary>
///<remark> xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
///</remark>
    [SchemaAttr(52, "blurRad")]
    public Int64Value BlurRadius
    {
        get { return (Int64Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> stA.</para>
    /// <para>Represents the following attribute in the schema: w14:stA </para>
    /// </summary>
///<remark> xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
///</remark>
    [SchemaAttr(52, "stA")]
    public Int32Value StartingOpacity
    {
        get { return (Int32Value)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> stPos.</para>
    /// <para>Represents the following attribute in the schema: w14:stPos </para>
    /// </summary>
///<remark> xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
///</remark>
    [SchemaAttr(52, "stPos")]
    public Int32Value StartPosition
    {
        get { return (Int32Value)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> endA.</para>
    /// <para>Represents the following attribute in the schema: w14:endA </para>
    /// </summary>
///<remark> xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
///</remark>
    [SchemaAttr(52, "endA")]
    public Int32Value EndingOpacity
    {
        get { return (Int32Value)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> endPos.</para>
    /// <para>Represents the following attribute in the schema: w14:endPos </para>
    /// </summary>
///<remark> xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
///</remark>
    [SchemaAttr(52, "endPos")]
    public Int32Value EndPosition
    {
        get { return (Int32Value)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> dist.</para>
    /// <para>Represents the following attribute in the schema: w14:dist </para>
    /// </summary>
///<remark> xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
///</remark>
    [SchemaAttr(52, "dist")]
    public Int64Value DistanceFromText
    {
        get { return (Int64Value)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> dir.</para>
    /// <para>Represents the following attribute in the schema: w14:dir </para>
    /// </summary>
///<remark> xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
///</remark>
    [SchemaAttr(52, "dir")]
    public Int32Value DirectionAngle
    {
        get { return (Int32Value)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> fadeDir.</para>
    /// <para>Represents the following attribute in the schema: w14:fadeDir </para>
    /// </summary>
///<remark> xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
///</remark>
    [SchemaAttr(52, "fadeDir")]
    public Int32Value FadeDirection
    {
        get { return (Int32Value)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> sx.</para>
    /// <para>Represents the following attribute in the schema: w14:sx </para>
    /// </summary>
///<remark> xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
///</remark>
    [SchemaAttr(52, "sx")]
    public Int32Value HorizontalScalingFactor
    {
        get { return (Int32Value)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> sy.</para>
    /// <para>Represents the following attribute in the schema: w14:sy </para>
    /// </summary>
///<remark> xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
///</remark>
    [SchemaAttr(52, "sy")]
    public Int32Value VerticalScalingFactor
    {
        get { return (Int32Value)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> kx.</para>
    /// <para>Represents the following attribute in the schema: w14:kx </para>
    /// </summary>
///<remark> xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
///</remark>
    [SchemaAttr(52, "kx")]
    public Int32Value HorizontalSkewAngle
    {
        get { return (Int32Value)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    
    /// <summary>
    /// <para> ky.</para>
    /// <para>Represents the following attribute in the schema: w14:ky </para>
    /// </summary>
///<remark> xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
///</remark>
    [SchemaAttr(52, "ky")]
    public Int32Value VerticalSkewAngle
    {
        get { return (Int32Value)Attributes[11].Value; }
        set { Attributes[11].Value = value; }
    }
    
    /// <summary>
    /// <para> algn.</para>
    /// <para>Represents the following attribute in the schema: w14:algn </para>
    /// </summary>
///<remark> xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
///</remark>
    [SchemaAttr(52, "algn")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.Word.RectangleAlignmentValues> Alignment
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.Word.RectangleAlignmentValues>)Attributes[12].Value; }
        set { Attributes[12].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Reflection class.
    /// </summary>
    public Reflection():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Reflection>(deep);

}
/// <summary>
/// <para>Defines the TextOutlineEffect Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w14:textOutline.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>NoFillEmpty &lt;w14:noFill></description></item>
///<item><description>SolidColorFillProperties &lt;w14:solidFill></description></item>
///<item><description>GradientFillProperties &lt;w14:gradFill></description></item>
///<item><description>PresetLineDashProperties &lt;w14:prstDash></description></item>
///<item><description>RoundEmpty &lt;w14:round></description></item>
///<item><description>BevelEmpty &lt;w14:bevel></description></item>
///<item><description>LineJoinMiterProperties &lt;w14:miter></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(NoFillEmpty), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(SolidColorFillProperties), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(GradientFillProperties), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(PresetLineDashProperties), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(RoundEmpty), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(BevelEmpty), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(LineJoinMiterProperties), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class TextOutlineEffect : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12923;
    /// <inheritdoc/>
    public override string LocalName => "textOutline";
    
    internal override byte NamespaceId => 52;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<Int32Value>(52, "w"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.Word.LineCapValues>>(52, "cap"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.Word.CompoundLineValues>>(52, "cmpd"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.Word.PenAlignmentValues>>(52, "algn")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> w.</para>
    /// <para>Represents the following attribute in the schema: w14:w </para>
    /// </summary>
///<remark> xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
///</remark>
    [SchemaAttr(52, "w")]
    public Int32Value LineWidth
    {
        get { return (Int32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> cap.</para>
    /// <para>Represents the following attribute in the schema: w14:cap </para>
    /// </summary>
///<remark> xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
///</remark>
    [SchemaAttr(52, "cap")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.Word.LineCapValues> CapType
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.Word.LineCapValues>)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> cmpd.</para>
    /// <para>Represents the following attribute in the schema: w14:cmpd </para>
    /// </summary>
///<remark> xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
///</remark>
    [SchemaAttr(52, "cmpd")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.Word.CompoundLineValues> Compound
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.Word.CompoundLineValues>)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> algn.</para>
    /// <para>Represents the following attribute in the schema: w14:algn </para>
    /// </summary>
///<remark> xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
///</remark>
    [SchemaAttr(52, "algn")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.Word.PenAlignmentValues> Alignment
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.Word.PenAlignmentValues>)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the TextOutlineEffect class.
    /// </summary>
    public TextOutlineEffect():base(){}
    
        /// <summary>
    ///Initializes a new instance of the TextOutlineEffect class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TextOutlineEffect(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the TextOutlineEffect class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TextOutlineEffect(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the TextOutlineEffect class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public TextOutlineEffect(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 52 == namespaceId && "noFill" == name)
    return new NoFillEmpty();
    
if( 52 == namespaceId && "solidFill" == name)
    return new SolidColorFillProperties();
    
if( 52 == namespaceId && "gradFill" == name)
    return new GradientFillProperties();
    
if( 52 == namespaceId && "prstDash" == name)
    return new PresetLineDashProperties();
    
if( 52 == namespaceId && "round" == name)
    return new RoundEmpty();
    
if( 52 == namespaceId && "bevel" == name)
    return new BevelEmpty();
    
if( 52 == namespaceId && "miter" == name)
    return new LineJoinMiterProperties();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<TextOutlineEffect>(deep);

}
/// <summary>
/// <para>Defines the FillTextEffect Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w14:textFill.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>NoFillEmpty &lt;w14:noFill></description></item>
///<item><description>SolidColorFillProperties &lt;w14:solidFill></description></item>
///<item><description>GradientFillProperties &lt;w14:gradFill></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(NoFillEmpty), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(SolidColorFillProperties), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(GradientFillProperties), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class FillTextEffect : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12924;
    /// <inheritdoc/>
    public override string LocalName => "textFill";
    
    internal override byte NamespaceId => 52;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the FillTextEffect class.
    /// </summary>
    public FillTextEffect():base(){}
    
        /// <summary>
    ///Initializes a new instance of the FillTextEffect class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public FillTextEffect(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the FillTextEffect class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public FillTextEffect(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the FillTextEffect class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public FillTextEffect(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 52 == namespaceId && "noFill" == name)
    return new NoFillEmpty();
    
if( 52 == namespaceId && "solidFill" == name)
    return new SolidColorFillProperties();
    
if( 52 == namespaceId && "gradFill" == name)
    return new GradientFillProperties();
    

    return null;
}

        private static readonly string[] eleTagNames = { "noFill","solidFill","gradFill" };
    private static readonly byte[] eleNamespaceIds = { 52,52,52 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneChoice;
    
        /// <summary>
    /// <para> NoFillEmpty.</para>
    /// <para> Represents the following element tag in the schema: w14:noFill </para>
    /// </summary>
    /// <remark>
    /// xmlns:w14 = http://schemas.microsoft.com/office/word/2010/wordml
    /// </remark>
    public NoFillEmpty NoFillEmpty
    {
        get => GetElement<NoFillEmpty>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> SolidColorFillProperties.</para>
    /// <para> Represents the following element tag in the schema: w14:solidFill </para>
    /// </summary>
    /// <remark>
    /// xmlns:w14 = http://schemas.microsoft.com/office/word/2010/wordml
    /// </remark>
    public SolidColorFillProperties SolidColorFillProperties
    {
        get => GetElement<SolidColorFillProperties>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> GradientFillProperties.</para>
    /// <para> Represents the following element tag in the schema: w14:gradFill </para>
    /// </summary>
    /// <remark>
    /// xmlns:w14 = http://schemas.microsoft.com/office/word/2010/wordml
    /// </remark>
    public GradientFillProperties GradientFillProperties
    {
        get => GetElement<GradientFillProperties>(2);
        set => SetElement(2, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<FillTextEffect>(deep);

}
/// <summary>
/// <para>Defines the Scene3D Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w14:scene3d.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Camera &lt;w14:camera></description></item>
///<item><description>LightRig &lt;w14:lightRig></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Camera), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(LightRig), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class Scene3D : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12925;
    /// <inheritdoc/>
    public override string LocalName => "scene3d";
    
    internal override byte NamespaceId => 52;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the Scene3D class.
    /// </summary>
    public Scene3D():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Scene3D class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Scene3D(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Scene3D class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Scene3D(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Scene3D class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Scene3D(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 52 == namespaceId && "camera" == name)
    return new Camera();
    
if( 52 == namespaceId && "lightRig" == name)
    return new LightRig();
    

    return null;
}

        private static readonly string[] eleTagNames = { "camera","lightRig" };
    private static readonly byte[] eleNamespaceIds = { 52,52 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Camera.</para>
    /// <para> Represents the following element tag in the schema: w14:camera </para>
    /// </summary>
    /// <remark>
    /// xmlns:w14 = http://schemas.microsoft.com/office/word/2010/wordml
    /// </remark>
    public Camera Camera
    {
        get => GetElement<Camera>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> LightRig.</para>
    /// <para> Represents the following element tag in the schema: w14:lightRig </para>
    /// </summary>
    /// <remark>
    /// xmlns:w14 = http://schemas.microsoft.com/office/word/2010/wordml
    /// </remark>
    public LightRig LightRig
    {
        get => GetElement<LightRig>(1);
        set => SetElement(1, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Scene3D>(deep);

}
/// <summary>
/// <para>Defines the Properties3D Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w14:props3d.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>BevelTop &lt;w14:bevelT></description></item>
///<item><description>BevelBottom &lt;w14:bevelB></description></item>
///<item><description>ExtrusionColor &lt;w14:extrusionClr></description></item>
///<item><description>ContourColor &lt;w14:contourClr></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(BevelTop), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(BevelBottom), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ExtrusionColor), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ContourColor), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class Properties3D : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12926;
    /// <inheritdoc/>
    public override string LocalName => "props3d";
    
    internal override byte NamespaceId => 52;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<Int64Value>(52, "extrusionH"),
		AttributeTag.Create<Int64Value>(52, "contourW"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.Word.PresetMaterialTypeValues>>(52, "prstMaterial")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> extrusionH.</para>
    /// <para>Represents the following attribute in the schema: w14:extrusionH </para>
    /// </summary>
///<remark> xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
///</remark>
    [SchemaAttr(52, "extrusionH")]
    public Int64Value ExtrusionHeight
    {
        get { return (Int64Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> contourW.</para>
    /// <para>Represents the following attribute in the schema: w14:contourW </para>
    /// </summary>
///<remark> xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
///</remark>
    [SchemaAttr(52, "contourW")]
    public Int64Value ContourWidth
    {
        get { return (Int64Value)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> prstMaterial.</para>
    /// <para>Represents the following attribute in the schema: w14:prstMaterial </para>
    /// </summary>
///<remark> xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
///</remark>
    [SchemaAttr(52, "prstMaterial")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.Word.PresetMaterialTypeValues> PresetMaterialType
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.Word.PresetMaterialTypeValues>)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Properties3D class.
    /// </summary>
    public Properties3D():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Properties3D class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Properties3D(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Properties3D class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Properties3D(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Properties3D class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Properties3D(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 52 == namespaceId && "bevelT" == name)
    return new BevelTop();
    
if( 52 == namespaceId && "bevelB" == name)
    return new BevelBottom();
    
if( 52 == namespaceId && "extrusionClr" == name)
    return new ExtrusionColor();
    
if( 52 == namespaceId && "contourClr" == name)
    return new ContourColor();
    

    return null;
}

        private static readonly string[] eleTagNames = { "bevelT","bevelB","extrusionClr","contourClr" };
    private static readonly byte[] eleNamespaceIds = { 52,52,52,52 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> BevelTop.</para>
    /// <para> Represents the following element tag in the schema: w14:bevelT </para>
    /// </summary>
    /// <remark>
    /// xmlns:w14 = http://schemas.microsoft.com/office/word/2010/wordml
    /// </remark>
    public BevelTop BevelTop
    {
        get => GetElement<BevelTop>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> BevelBottom.</para>
    /// <para> Represents the following element tag in the schema: w14:bevelB </para>
    /// </summary>
    /// <remark>
    /// xmlns:w14 = http://schemas.microsoft.com/office/word/2010/wordml
    /// </remark>
    public BevelBottom BevelBottom
    {
        get => GetElement<BevelBottom>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> ExtrusionColor.</para>
    /// <para> Represents the following element tag in the schema: w14:extrusionClr </para>
    /// </summary>
    /// <remark>
    /// xmlns:w14 = http://schemas.microsoft.com/office/word/2010/wordml
    /// </remark>
    public ExtrusionColor ExtrusionColor
    {
        get => GetElement<ExtrusionColor>(2);
        set => SetElement(2, value);
    }
    /// <summary>
    /// <para> ContourColor.</para>
    /// <para> Represents the following element tag in the schema: w14:contourClr </para>
    /// </summary>
    /// <remark>
    /// xmlns:w14 = http://schemas.microsoft.com/office/word/2010/wordml
    /// </remark>
    public ContourColor ContourColor
    {
        get => GetElement<ContourColor>(3);
        set => SetElement(3, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Properties3D>(deep);

}
/// <summary>
/// <para>Defines the Ligatures Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w14:ligatures.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class Ligatures : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12927;
    /// <inheritdoc/>
    public override string LocalName => "ligatures";
    
    internal override byte NamespaceId => 52;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.Word.LigaturesValues>>(52, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> val.</para>
    /// <para>Represents the following attribute in the schema: w14:val </para>
    /// </summary>
///<remark> xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
///</remark>
    [SchemaAttr(52, "val")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.Word.LigaturesValues> Val
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.Word.LigaturesValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Ligatures class.
    /// </summary>
    public Ligatures():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Ligatures>(deep);

}
/// <summary>
/// <para>Defines the NumberingFormat Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w14:numForm.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class NumberingFormat : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12928;
    /// <inheritdoc/>
    public override string LocalName => "numForm";
    
    internal override byte NamespaceId => 52;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.Word.NumberFormValues>>(52, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> val.</para>
    /// <para>Represents the following attribute in the schema: w14:val </para>
    /// </summary>
///<remark> xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
///</remark>
    [SchemaAttr(52, "val")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.Word.NumberFormValues> Val
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.Word.NumberFormValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the NumberingFormat class.
    /// </summary>
    public NumberingFormat():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<NumberingFormat>(deep);

}
/// <summary>
/// <para>Defines the NumberSpacing Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w14:numSpacing.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class NumberSpacing : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12929;
    /// <inheritdoc/>
    public override string LocalName => "numSpacing";
    
    internal override byte NamespaceId => 52;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.Word.NumberSpacingValues>>(52, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> val.</para>
    /// <para>Represents the following attribute in the schema: w14:val </para>
    /// </summary>
///<remark> xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
///</remark>
    [SchemaAttr(52, "val")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.Word.NumberSpacingValues> Val
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.Word.NumberSpacingValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the NumberSpacing class.
    /// </summary>
    public NumberSpacing():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<NumberSpacing>(deep);

}
/// <summary>
/// <para>Defines the StylisticSets Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w14:stylisticSets.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>StyleSet &lt;w14:styleSet></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(StyleSet), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class StylisticSets : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12930;
    /// <inheritdoc/>
    public override string LocalName => "stylisticSets";
    
    internal override byte NamespaceId => 52;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the StylisticSets class.
    /// </summary>
    public StylisticSets():base(){}
    
        /// <summary>
    ///Initializes a new instance of the StylisticSets class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public StylisticSets(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the StylisticSets class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public StylisticSets(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the StylisticSets class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public StylisticSets(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 52 == namespaceId && "styleSet" == name)
    return new StyleSet();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<StylisticSets>(deep);

}
/// <summary>
/// <para>Defines the ContextualAlternatives Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w14:cntxtAlts.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ContextualAlternatives : OnOffType
{
    internal const int ElementTypeIdConst = 12931;
    /// <inheritdoc/>
    public override string LocalName => "cntxtAlts";
    
    internal override byte NamespaceId => 52;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    /// <summary>
    /// Initializes a new instance of the ContextualAlternatives class.
    /// </summary>
    public ContextualAlternatives():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ContextualAlternatives>(deep);

}
/// <summary>
/// <para>Defines the ConflictMode Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w14:conflictMode.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ConflictMode : OnOffType
{
    internal const int ElementTypeIdConst = 12934;
    /// <inheritdoc/>
    public override string LocalName => "conflictMode";
    
    internal override byte NamespaceId => 52;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    /// <summary>
    /// Initializes a new instance of the ConflictMode class.
    /// </summary>
    public ConflictMode():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ConflictMode>(deep);

}
/// <summary>
/// <para>Defines the DiscardImageEditingData Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w14:discardImageEditingData.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class DiscardImageEditingData : OnOffType
{
    internal const int ElementTypeIdConst = 12939;
    /// <inheritdoc/>
    public override string LocalName => "discardImageEditingData";
    
    internal override byte NamespaceId => 52;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    /// <summary>
    /// Initializes a new instance of the DiscardImageEditingData class.
    /// </summary>
    public DiscardImageEditingData():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DiscardImageEditingData>(deep);

}
/// <summary>
/// <para>Defines the Checked Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w14:checked.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class Checked : OnOffType
{
    internal const int ElementTypeIdConst = 12954;
    /// <inheritdoc/>
    public override string LocalName => "checked";
    
    internal override byte NamespaceId => 52;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    /// <summary>
    /// Initializes a new instance of the Checked class.
    /// </summary>
    public Checked():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Checked>(deep);

}
/// <summary>
/// Defines the OnOffType class.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class OnOffType : OpenXmlLeafElement
{
        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.Word.OnOffValues>>(52, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);
    
        /// <summary>
    /// <para> val.</para>
    /// <para>Represents the following attribute in the schema: w14:val </para>
    /// </summary>
///<remark> xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
///</remark>
    [SchemaAttr(52, "val")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.Word.OnOffValues> Val
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.Word.OnOffValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the OnOffType class.
    /// </summary>
    protected OnOffType(){}
    
    
    
}
/// <summary>
/// <para>Defines the ContentPart Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w14:contentPart.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>WordNonVisualContentPartShapeProperties &lt;w14:nvContentPartPr></description></item>
///<item><description>Transform2D &lt;w14:xfrm></description></item>
///<item><description>OfficeArtExtensionList &lt;w14:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(WordNonVisualContentPartShapeProperties), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(Transform2D), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(OfficeArtExtensionList), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ContentPart : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12932;
    /// <inheritdoc/>
    public override string LocalName => "contentPart";
    
    internal override byte NamespaceId => 52;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>>(52, "bwMode"),
		AttributeTag.Create<StringValue>(19, "id")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> bwMode.</para>
    /// <para>Represents the following attribute in the schema: w14:bwMode </para>
    /// </summary>
///<remark> xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
///</remark>
    [SchemaAttr(52, "bwMode")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues> BlackWhiteMode
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: r:id </para>
    /// </summary>
///<remark> xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
///</remark>
    [SchemaAttr(19, "id")]
    public StringValue RelationshipId
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ContentPart class.
    /// </summary>
    public ContentPart():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ContentPart class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ContentPart(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ContentPart class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ContentPart(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ContentPart class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ContentPart(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 52 == namespaceId && "nvContentPartPr" == name)
    return new WordNonVisualContentPartShapeProperties();
    
if( 52 == namespaceId && "xfrm" == name)
    return new Transform2D();
    
if( 52 == namespaceId && "extLst" == name)
    return new OfficeArtExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "nvContentPartPr","xfrm","extLst" };
    private static readonly byte[] eleNamespaceIds = { 52,52,52 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> WordNonVisualContentPartShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: w14:nvContentPartPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:w14 = http://schemas.microsoft.com/office/word/2010/wordml
    /// </remark>
    public WordNonVisualContentPartShapeProperties WordNonVisualContentPartShapeProperties
    {
        get => GetElement<WordNonVisualContentPartShapeProperties>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Transform2D.</para>
    /// <para> Represents the following element tag in the schema: w14:xfrm </para>
    /// </summary>
    /// <remark>
    /// xmlns:w14 = http://schemas.microsoft.com/office/word/2010/wordml
    /// </remark>
    public Transform2D Transform2D
    {
        get => GetElement<Transform2D>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> OfficeArtExtensionList.</para>
    /// <para> Represents the following element tag in the schema: w14:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:w14 = http://schemas.microsoft.com/office/word/2010/wordml
    /// </remark>
    public OfficeArtExtensionList OfficeArtExtensionList
    {
        get => GetElement<OfficeArtExtensionList>(2);
        set => SetElement(2, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ContentPart>(deep);

}
/// <summary>
/// <para>Defines the DocumentId Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w14:docId.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class DocumentId : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12933;
    /// <inheritdoc/>
    public override string LocalName => "docId";
    
    internal override byte NamespaceId => 52;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<HexBinaryValue>(52, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> val.</para>
    /// <para>Represents the following attribute in the schema: w14:val </para>
    /// </summary>
///<remark> xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
///</remark>
    [SchemaAttr(52, "val")]
    public HexBinaryValue Val
    {
        get { return (HexBinaryValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the DocumentId class.
    /// </summary>
    public DocumentId():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DocumentId>(deep);

}
/// <summary>
/// <para>Defines the CustomXmlConflictInsertionRangeEnd Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w14:customXmlConflictInsRangeEnd.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class CustomXmlConflictInsertionRangeEnd : MarkupType
{
    internal const int ElementTypeIdConst = 12936;
    /// <inheritdoc/>
    public override string LocalName => "customXmlConflictInsRangeEnd";
    
    internal override byte NamespaceId => 52;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    /// <summary>
    /// Initializes a new instance of the CustomXmlConflictInsertionRangeEnd class.
    /// </summary>
    public CustomXmlConflictInsertionRangeEnd():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<CustomXmlConflictInsertionRangeEnd>(deep);

}
/// <summary>
/// <para>Defines the CustomXmlConflictDeletionRangeEnd Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w14:customXmlConflictDelRangeEnd.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class CustomXmlConflictDeletionRangeEnd : MarkupType
{
    internal const int ElementTypeIdConst = 12938;
    /// <inheritdoc/>
    public override string LocalName => "customXmlConflictDelRangeEnd";
    
    internal override byte NamespaceId => 52;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    /// <summary>
    /// Initializes a new instance of the CustomXmlConflictDeletionRangeEnd class.
    /// </summary>
    public CustomXmlConflictDeletionRangeEnd():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<CustomXmlConflictDeletionRangeEnd>(deep);

}
/// <summary>
/// Defines the MarkupType class.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class MarkupType : OpenXmlLeafElement
{
        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(23, "id")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);
    
        /// <summary>
    /// <para> Annotation Identifier.</para>
    /// <para>Represents the following attribute in the schema: w:id </para>
    /// </summary>
///<remark> xmlns:w=http://schemas.openxmlformats.org/wordprocessingml/2006/main
///</remark>
    [SchemaAttr(23, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the MarkupType class.
    /// </summary>
    protected MarkupType(){}
    
    
    
}
/// <summary>
/// <para>Defines the DefaultImageDpi Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w14:defaultImageDpi.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class DefaultImageDpi : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12940;
    /// <inheritdoc/>
    public override string LocalName => "defaultImageDpi";
    
    internal override byte NamespaceId => 52;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<Int32Value>(52, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> val.</para>
    /// <para>Represents the following attribute in the schema: w14:val </para>
    /// </summary>
///<remark> xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
///</remark>
    [SchemaAttr(52, "val")]
    public Int32Value Val
    {
        get { return (Int32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the DefaultImageDpi class.
    /// </summary>
    public DefaultImageDpi():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DefaultImageDpi>(deep);

}
/// <summary>
/// <para>Defines the SdtContentCheckBox Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w14:checkbox.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Checked &lt;w14:checked></description></item>
///<item><description>CheckedState &lt;w14:checkedState></description></item>
///<item><description>UncheckedState &lt;w14:uncheckedState></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Checked), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(CheckedState), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(UncheckedState), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class SdtContentCheckBox : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12942;
    /// <inheritdoc/>
    public override string LocalName => "checkbox";
    
    internal override byte NamespaceId => 52;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the SdtContentCheckBox class.
    /// </summary>
    public SdtContentCheckBox():base(){}
    
        /// <summary>
    ///Initializes a new instance of the SdtContentCheckBox class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SdtContentCheckBox(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the SdtContentCheckBox class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SdtContentCheckBox(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the SdtContentCheckBox class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public SdtContentCheckBox(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 52 == namespaceId && "checked" == name)
    return new Checked();
    
if( 52 == namespaceId && "checkedState" == name)
    return new CheckedState();
    
if( 52 == namespaceId && "uncheckedState" == name)
    return new UncheckedState();
    

    return null;
}

        private static readonly string[] eleTagNames = { "checked","checkedState","uncheckedState" };
    private static readonly byte[] eleNamespaceIds = { 52,52,52 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Checked.</para>
    /// <para> Represents the following element tag in the schema: w14:checked </para>
    /// </summary>
    /// <remark>
    /// xmlns:w14 = http://schemas.microsoft.com/office/word/2010/wordml
    /// </remark>
    public Checked Checked
    {
        get => GetElement<Checked>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> CheckedState.</para>
    /// <para> Represents the following element tag in the schema: w14:checkedState </para>
    /// </summary>
    /// <remark>
    /// xmlns:w14 = http://schemas.microsoft.com/office/word/2010/wordml
    /// </remark>
    public CheckedState CheckedState
    {
        get => GetElement<CheckedState>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> UncheckedState.</para>
    /// <para> Represents the following element tag in the schema: w14:uncheckedState </para>
    /// </summary>
    /// <remark>
    /// xmlns:w14 = http://schemas.microsoft.com/office/word/2010/wordml
    /// </remark>
    public UncheckedState UncheckedState
    {
        get => GetElement<UncheckedState>(2);
        set => SetElement(2, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SdtContentCheckBox>(deep);

}
/// <summary>
/// <para>Defines the GradientStop Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w14:gs.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>RgbColorModelHex &lt;w14:srgbClr></description></item>
///<item><description>SchemeColor &lt;w14:schemeClr></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(RgbColorModelHex), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(SchemeColor), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class GradientStop : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12943;
    /// <inheritdoc/>
    public override string LocalName => "gs";
    
    internal override byte NamespaceId => 52;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<Int32Value>(52, "pos")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> pos.</para>
    /// <para>Represents the following attribute in the schema: w14:pos </para>
    /// </summary>
///<remark> xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
///</remark>
    [SchemaAttr(52, "pos")]
    public Int32Value StopPosition
    {
        get { return (Int32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the GradientStop class.
    /// </summary>
    public GradientStop():base(){}
    
        /// <summary>
    ///Initializes a new instance of the GradientStop class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public GradientStop(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the GradientStop class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public GradientStop(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the GradientStop class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public GradientStop(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 52 == namespaceId && "srgbClr" == name)
    return new RgbColorModelHex();
    
if( 52 == namespaceId && "schemeClr" == name)
    return new SchemeColor();
    

    return null;
}

        private static readonly string[] eleTagNames = { "srgbClr","schemeClr" };
    private static readonly byte[] eleNamespaceIds = { 52,52 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneChoice;
    
        /// <summary>
    /// <para> RgbColorModelHex.</para>
    /// <para> Represents the following element tag in the schema: w14:srgbClr </para>
    /// </summary>
    /// <remark>
    /// xmlns:w14 = http://schemas.microsoft.com/office/word/2010/wordml
    /// </remark>
    public RgbColorModelHex RgbColorModelHex
    {
        get => GetElement<RgbColorModelHex>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> SchemeColor.</para>
    /// <para> Represents the following element tag in the schema: w14:schemeClr </para>
    /// </summary>
    /// <remark>
    /// xmlns:w14 = http://schemas.microsoft.com/office/word/2010/wordml
    /// </remark>
    public SchemeColor SchemeColor
    {
        get => GetElement<SchemeColor>(1);
        set => SetElement(1, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<GradientStop>(deep);

}
/// <summary>
/// <para>Defines the FillToRectangle Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w14:fillToRect.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class FillToRectangle : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12944;
    /// <inheritdoc/>
    public override string LocalName => "fillToRect";
    
    internal override byte NamespaceId => 52;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<Int32Value>(52, "l"),
		AttributeTag.Create<Int32Value>(52, "t"),
		AttributeTag.Create<Int32Value>(52, "r"),
		AttributeTag.Create<Int32Value>(52, "b")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> l.</para>
    /// <para>Represents the following attribute in the schema: w14:l </para>
    /// </summary>
///<remark> xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
///</remark>
    [SchemaAttr(52, "l")]
    public Int32Value Left
    {
        get { return (Int32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> t.</para>
    /// <para>Represents the following attribute in the schema: w14:t </para>
    /// </summary>
///<remark> xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
///</remark>
    [SchemaAttr(52, "t")]
    public Int32Value Top
    {
        get { return (Int32Value)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> r.</para>
    /// <para>Represents the following attribute in the schema: w14:r </para>
    /// </summary>
///<remark> xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
///</remark>
    [SchemaAttr(52, "r")]
    public Int32Value Right
    {
        get { return (Int32Value)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> b.</para>
    /// <para>Represents the following attribute in the schema: w14:b </para>
    /// </summary>
///<remark> xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
///</remark>
    [SchemaAttr(52, "b")]
    public Int32Value Bottom
    {
        get { return (Int32Value)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the FillToRectangle class.
    /// </summary>
    public FillToRectangle():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<FillToRectangle>(deep);

}
/// <summary>
/// <para>Defines the GradientStopList Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w14:gsLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>GradientStop &lt;w14:gs></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(GradientStop), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class GradientStopList : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12945;
    /// <inheritdoc/>
    public override string LocalName => "gsLst";
    
    internal override byte NamespaceId => 52;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the GradientStopList class.
    /// </summary>
    public GradientStopList():base(){}
    
        /// <summary>
    ///Initializes a new instance of the GradientStopList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public GradientStopList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the GradientStopList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public GradientStopList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the GradientStopList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public GradientStopList(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 52 == namespaceId && "gs" == name)
    return new GradientStop();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<GradientStopList>(deep);

}
/// <summary>
/// <para>Defines the SphereCoordinates Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w14:rot.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class SphereCoordinates : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12946;
    /// <inheritdoc/>
    public override string LocalName => "rot";
    
    internal override byte NamespaceId => 52;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<Int32Value>(52, "lat"),
		AttributeTag.Create<Int32Value>(52, "lon"),
		AttributeTag.Create<Int32Value>(52, "rev")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> lat.</para>
    /// <para>Represents the following attribute in the schema: w14:lat </para>
    /// </summary>
///<remark> xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
///</remark>
    [SchemaAttr(52, "lat")]
    public Int32Value Lattitude
    {
        get { return (Int32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> lon.</para>
    /// <para>Represents the following attribute in the schema: w14:lon </para>
    /// </summary>
///<remark> xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
///</remark>
    [SchemaAttr(52, "lon")]
    public Int32Value Longitude
    {
        get { return (Int32Value)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> rev.</para>
    /// <para>Represents the following attribute in the schema: w14:rev </para>
    /// </summary>
///<remark> xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
///</remark>
    [SchemaAttr(52, "rev")]
    public Int32Value Revolution
    {
        get { return (Int32Value)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the SphereCoordinates class.
    /// </summary>
    public SphereCoordinates():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SphereCoordinates>(deep);

}
/// <summary>
/// <para>Defines the Camera Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w14:camera.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class Camera : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12947;
    /// <inheritdoc/>
    public override string LocalName => "camera";
    
    internal override byte NamespaceId => 52;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.Word.PresetCameraTypeValues>>(52, "prst")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> prst.</para>
    /// <para>Represents the following attribute in the schema: w14:prst </para>
    /// </summary>
///<remark> xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
///</remark>
    [SchemaAttr(52, "prst")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.Word.PresetCameraTypeValues> PresetCameraType
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.Word.PresetCameraTypeValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Camera class.
    /// </summary>
    public Camera():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Camera>(deep);

}
/// <summary>
/// <para>Defines the LightRig Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w14:lightRig.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>SphereCoordinates &lt;w14:rot></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(SphereCoordinates), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class LightRig : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12948;
    /// <inheritdoc/>
    public override string LocalName => "lightRig";
    
    internal override byte NamespaceId => 52;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.Word.LightRigTypeValues>>(52, "rig"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.Word.LightRigDirectionValues>>(52, "dir")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> rig.</para>
    /// <para>Represents the following attribute in the schema: w14:rig </para>
    /// </summary>
///<remark> xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
///</remark>
    [SchemaAttr(52, "rig")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.Word.LightRigTypeValues> LightRigType
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.Word.LightRigTypeValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> dir.</para>
    /// <para>Represents the following attribute in the schema: w14:dir </para>
    /// </summary>
///<remark> xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
///</remark>
    [SchemaAttr(52, "dir")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.Word.LightRigDirectionValues> LightDirectionType
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.Word.LightRigDirectionValues>)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the LightRig class.
    /// </summary>
    public LightRig():base(){}
    
        /// <summary>
    ///Initializes a new instance of the LightRig class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public LightRig(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the LightRig class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public LightRig(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the LightRig class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public LightRig(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 52 == namespaceId && "rot" == name)
    return new SphereCoordinates();
    

    return null;
}

        private static readonly string[] eleTagNames = { "rot" };
    private static readonly byte[] eleNamespaceIds = { 52 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> SphereCoordinates.</para>
    /// <para> Represents the following element tag in the schema: w14:rot </para>
    /// </summary>
    /// <remark>
    /// xmlns:w14 = http://schemas.microsoft.com/office/word/2010/wordml
    /// </remark>
    public SphereCoordinates SphereCoordinates
    {
        get => GetElement<SphereCoordinates>(0);
        set => SetElement(0, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<LightRig>(deep);

}
/// <summary>
/// <para>Defines the BevelTop Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w14:bevelT.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class BevelTop : BevelType
{
    internal const int ElementTypeIdConst = 12949;
    /// <inheritdoc/>
    public override string LocalName => "bevelT";
    
    internal override byte NamespaceId => 52;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    /// <summary>
    /// Initializes a new instance of the BevelTop class.
    /// </summary>
    public BevelTop():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<BevelTop>(deep);

}
/// <summary>
/// <para>Defines the BevelBottom Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w14:bevelB.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class BevelBottom : BevelType
{
    internal const int ElementTypeIdConst = 12950;
    /// <inheritdoc/>
    public override string LocalName => "bevelB";
    
    internal override byte NamespaceId => 52;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    /// <summary>
    /// Initializes a new instance of the BevelBottom class.
    /// </summary>
    public BevelBottom():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<BevelBottom>(deep);

}
/// <summary>
/// Defines the BevelType class.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class BevelType : OpenXmlLeafElement
{
        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<Int64Value>(52, "w"),
		AttributeTag.Create<Int64Value>(52, "h"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.Word.BevelPresetTypeValues>>(52, "prst")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);
    
        /// <summary>
    /// <para> w.</para>
    /// <para>Represents the following attribute in the schema: w14:w </para>
    /// </summary>
///<remark> xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
///</remark>
    [SchemaAttr(52, "w")]
    public Int64Value Width
    {
        get { return (Int64Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> h.</para>
    /// <para>Represents the following attribute in the schema: w14:h </para>
    /// </summary>
///<remark> xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
///</remark>
    [SchemaAttr(52, "h")]
    public Int64Value Height
    {
        get { return (Int64Value)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> prst.</para>
    /// <para>Represents the following attribute in the schema: w14:prst </para>
    /// </summary>
///<remark> xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
///</remark>
    [SchemaAttr(52, "prst")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.Word.BevelPresetTypeValues> PresetProfileType
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.Word.BevelPresetTypeValues>)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the BevelType class.
    /// </summary>
    protected BevelType(){}
    
    
    
}
/// <summary>
/// <para>Defines the ExtrusionColor Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w14:extrusionClr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>RgbColorModelHex &lt;w14:srgbClr></description></item>
///<item><description>SchemeColor &lt;w14:schemeClr></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ExtrusionColor : ColorType
{
    internal const int ElementTypeIdConst = 12951;
    /// <inheritdoc/>
    public override string LocalName => "extrusionClr";
    
    internal override byte NamespaceId => 52;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    /// <summary>
    /// Initializes a new instance of the ExtrusionColor class.
    /// </summary>
    public ExtrusionColor():base(){}
        /// <summary>
    ///Initializes a new instance of the ExtrusionColor class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ExtrusionColor(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ExtrusionColor class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ExtrusionColor(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ExtrusionColor class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ExtrusionColor(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ExtrusionColor>(deep);

}
/// <summary>
/// <para>Defines the ContourColor Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w14:contourClr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>RgbColorModelHex &lt;w14:srgbClr></description></item>
///<item><description>SchemeColor &lt;w14:schemeClr></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ContourColor : ColorType
{
    internal const int ElementTypeIdConst = 12952;
    /// <inheritdoc/>
    public override string LocalName => "contourClr";
    
    internal override byte NamespaceId => 52;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    /// <summary>
    /// Initializes a new instance of the ContourColor class.
    /// </summary>
    public ContourColor():base(){}
        /// <summary>
    ///Initializes a new instance of the ContourColor class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ContourColor(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ContourColor class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ContourColor(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ContourColor class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ContourColor(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ContourColor>(deep);

}
/// <summary>
/// Defines the ColorType class.
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>RgbColorModelHex &lt;w14:srgbClr></description></item>
///<item><description>SchemeColor &lt;w14:schemeClr></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(RgbColorModelHex), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(SchemeColor), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class ColorType : OpenXmlCompositeElement
{
        
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 52 == namespaceId && "srgbClr" == name)
    return new RgbColorModelHex();
    
if( 52 == namespaceId && "schemeClr" == name)
    return new SchemeColor();
    

    return null;
}

        private static readonly string[] eleTagNames = { "srgbClr","schemeClr" };
    private static readonly byte[] eleNamespaceIds = { 52,52 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneChoice;
    
        /// <summary>
    /// <para> RgbColorModelHex.</para>
    /// <para> Represents the following element tag in the schema: w14:srgbClr </para>
    /// </summary>
    /// <remark>
    /// xmlns:w14 = http://schemas.microsoft.com/office/word/2010/wordml
    /// </remark>
    public RgbColorModelHex RgbColorModelHex
    {
        get => GetElement<RgbColorModelHex>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> SchemeColor.</para>
    /// <para> Represents the following element tag in the schema: w14:schemeClr </para>
    /// </summary>
    /// <remark>
    /// xmlns:w14 = http://schemas.microsoft.com/office/word/2010/wordml
    /// </remark>
    public SchemeColor SchemeColor
    {
        get => GetElement<SchemeColor>(1);
        set => SetElement(1, value);
    }


    
    /// <summary>
    /// Initializes a new instance of the ColorType class.
    /// </summary>
    protected ColorType(){}
    
        /// <summary>
    ///Initializes a new instance of the ColorType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected ColorType(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ColorType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected ColorType(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ColorType class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    protected ColorType(string outerXml)
        : base(outerXml)
    {
    }

    
}
/// <summary>
/// <para>Defines the StyleSet Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w14:styleSet.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class StyleSet : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12953;
    /// <inheritdoc/>
    public override string LocalName => "styleSet";
    
    internal override byte NamespaceId => 52;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<UInt32Value>(52, "id"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.Word.OnOffValues>>(52, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: w14:id </para>
    /// </summary>
///<remark> xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
///</remark>
    [SchemaAttr(52, "id")]
    public UInt32Value Id
    {
        get { return (UInt32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> val.</para>
    /// <para>Represents the following attribute in the schema: w14:val </para>
    /// </summary>
///<remark> xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
///</remark>
    [SchemaAttr(52, "val")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.Word.OnOffValues> Val
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.Word.OnOffValues>)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the StyleSet class.
    /// </summary>
    public StyleSet():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<StyleSet>(deep);

}
/// <summary>
/// <para>Defines the CheckedState Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w14:checkedState.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class CheckedState : CheckBoxSymbolType
{
    internal const int ElementTypeIdConst = 12955;
    /// <inheritdoc/>
    public override string LocalName => "checkedState";
    
    internal override byte NamespaceId => 52;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    /// <summary>
    /// Initializes a new instance of the CheckedState class.
    /// </summary>
    public CheckedState():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<CheckedState>(deep);

}
/// <summary>
/// <para>Defines the UncheckedState Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w14:uncheckedState.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class UncheckedState : CheckBoxSymbolType
{
    internal const int ElementTypeIdConst = 12956;
    /// <inheritdoc/>
    public override string LocalName => "uncheckedState";
    
    internal override byte NamespaceId => 52;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    /// <summary>
    /// Initializes a new instance of the UncheckedState class.
    /// </summary>
    public UncheckedState():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<UncheckedState>(deep);

}
/// <summary>
/// Defines the CheckBoxSymbolType class.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class CheckBoxSymbolType : OpenXmlLeafElement
{
        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(52, "font"),
		AttributeTag.Create<HexBinaryValue>(52, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);
    
        /// <summary>
    /// <para> font.</para>
    /// <para>Represents the following attribute in the schema: w14:font </para>
    /// </summary>
///<remark> xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
///</remark>
    [SchemaAttr(52, "font")]
    public StringValue Font
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> val.</para>
    /// <para>Represents the following attribute in the schema: w14:val </para>
    /// </summary>
///<remark> xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
///</remark>
    [SchemaAttr(52, "val")]
    public HexBinaryValue Val
    {
        get { return (HexBinaryValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the CheckBoxSymbolType class.
    /// </summary>
    protected CheckBoxSymbolType(){}
    
    
    
}
/// <summary>
/// <para>Defines the NonVisualDrawingProperties Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w14:cNvPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.HyperlinkOnClick &lt;a:hlinkClick></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.HyperlinkOnHover &lt;a:hlinkHover></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList &lt;a:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.HyperlinkOnClick))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.HyperlinkOnHover))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class NonVisualDrawingProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12957;
    /// <inheritdoc/>
    public override string LocalName => "cNvPr";
    
    internal override byte NamespaceId => 52;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<UInt32Value>(0, "id"),
		AttributeTag.Create<StringValue>(0, "name"),
		AttributeTag.Create<StringValue>(0, "descr"),
		AttributeTag.Create<BooleanValue>(0, "hidden"),
		AttributeTag.Create<StringValue>(0, "title")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public UInt32Value Id
    {
        get { return (UInt32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> name.</para>
    /// <para>Represents the following attribute in the schema: name </para>
    /// </summary>
    [SchemaAttr(0, "name")]
    public StringValue Name
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> descr.</para>
    /// <para>Represents the following attribute in the schema: descr </para>
    /// </summary>
    [SchemaAttr(0, "descr")]
    public StringValue Description
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> hidden.</para>
    /// <para>Represents the following attribute in the schema: hidden </para>
    /// </summary>
    [SchemaAttr(0, "hidden")]
    public BooleanValue Hidden
    {
        get { return (BooleanValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> title.</para>
    /// <para>Represents the following attribute in the schema: title </para>
    /// </summary>
    [SchemaAttr(0, "title")]
    public StringValue Title
    {
        get { return (StringValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the NonVisualDrawingProperties class.
    /// </summary>
    public NonVisualDrawingProperties():base(){}
    
        /// <summary>
    ///Initializes a new instance of the NonVisualDrawingProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NonVisualDrawingProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the NonVisualDrawingProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NonVisualDrawingProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the NonVisualDrawingProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public NonVisualDrawingProperties(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 10 == namespaceId && "hlinkClick" == name)
    return new DocumentFormat.OpenXml.Drawing.HyperlinkOnClick();
    
if( 10 == namespaceId && "hlinkHover" == name)
    return new DocumentFormat.OpenXml.Drawing.HyperlinkOnHover();
    
if( 10 == namespaceId && "extLst" == name)
    return new DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "hlinkClick","hlinkHover","extLst" };
    private static readonly byte[] eleNamespaceIds = { 10,10,10 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> HyperlinkOnClick.</para>
    /// <para> Represents the following element tag in the schema: a:hlinkClick </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.HyperlinkOnClick HyperlinkOnClick
    {
        get => GetElement<DocumentFormat.OpenXml.Drawing.HyperlinkOnClick>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> HyperlinkOnHover.</para>
    /// <para> Represents the following element tag in the schema: a:hlinkHover </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.HyperlinkOnHover HyperlinkOnHover
    {
        get => GetElement<DocumentFormat.OpenXml.Drawing.HyperlinkOnHover>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> NonVisualDrawingPropertiesExtensionList.</para>
    /// <para> Represents the following element tag in the schema: a:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList NonVisualDrawingPropertiesExtensionList
    {
        get => GetElement<DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList>(2);
        set => SetElement(2, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualDrawingProperties>(deep);

}
/// <summary>
/// <para>Defines the NonVisualInkContentPartProperties Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w14:cNvContentPartPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Office2010.Drawing.ContentPartLocks &lt;a14:cpLocks></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Drawing.OfficeArtExtensionList &lt;a14:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Drawing.ContentPartLocks), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Drawing.OfficeArtExtensionList), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class NonVisualInkContentPartProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12958;
    /// <inheritdoc/>
    public override string LocalName => "cNvContentPartPr";
    
    internal override byte NamespaceId => 52;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<BooleanValue>(0, "isComment")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> isComment.</para>
    /// <para>Represents the following attribute in the schema: isComment </para>
    /// </summary>
    [SchemaAttr(0, "isComment")]
    public BooleanValue IsComment
    {
        get { return (BooleanValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the NonVisualInkContentPartProperties class.
    /// </summary>
    public NonVisualInkContentPartProperties():base(){}
    
        /// <summary>
    ///Initializes a new instance of the NonVisualInkContentPartProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NonVisualInkContentPartProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the NonVisualInkContentPartProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NonVisualInkContentPartProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the NonVisualInkContentPartProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public NonVisualInkContentPartProperties(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 48 == namespaceId && "cpLocks" == name)
    return new DocumentFormat.OpenXml.Office2010.Drawing.ContentPartLocks();
    
if( 48 == namespaceId && "extLst" == name)
    return new DocumentFormat.OpenXml.Office2010.Drawing.OfficeArtExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "cpLocks","extLst" };
    private static readonly byte[] eleNamespaceIds = { 48,48 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> ContentPartLocks.</para>
    /// <para> Represents the following element tag in the schema: a14:cpLocks </para>
    /// </summary>
    /// <remark>
    /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
    /// </remark>
    public DocumentFormat.OpenXml.Office2010.Drawing.ContentPartLocks ContentPartLocks
    {
        get => GetElement<DocumentFormat.OpenXml.Office2010.Drawing.ContentPartLocks>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> OfficeArtExtensionList.</para>
    /// <para> Represents the following element tag in the schema: a14:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
    /// </remark>
    public DocumentFormat.OpenXml.Office2010.Drawing.OfficeArtExtensionList OfficeArtExtensionList
    {
        get => GetElement<DocumentFormat.OpenXml.Office2010.Drawing.OfficeArtExtensionList>(1);
        set => SetElement(1, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualInkContentPartProperties>(deep);

}
/// <summary>
/// <para>Defines the WordNonVisualContentPartShapeProperties Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w14:nvContentPartPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>NonVisualDrawingProperties &lt;w14:cNvPr></description></item>
///<item><description>NonVisualInkContentPartProperties &lt;w14:cNvContentPartPr></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(NonVisualDrawingProperties), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(NonVisualInkContentPartProperties), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class WordNonVisualContentPartShapeProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12959;
    /// <inheritdoc/>
    public override string LocalName => "nvContentPartPr";
    
    internal override byte NamespaceId => 52;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the WordNonVisualContentPartShapeProperties class.
    /// </summary>
    public WordNonVisualContentPartShapeProperties():base(){}
    
        /// <summary>
    ///Initializes a new instance of the WordNonVisualContentPartShapeProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public WordNonVisualContentPartShapeProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the WordNonVisualContentPartShapeProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public WordNonVisualContentPartShapeProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the WordNonVisualContentPartShapeProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public WordNonVisualContentPartShapeProperties(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 52 == namespaceId && "cNvPr" == name)
    return new NonVisualDrawingProperties();
    
if( 52 == namespaceId && "cNvContentPartPr" == name)
    return new NonVisualInkContentPartProperties();
    

    return null;
}

        private static readonly string[] eleTagNames = { "cNvPr","cNvContentPartPr" };
    private static readonly byte[] eleNamespaceIds = { 52,52 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> NonVisualDrawingProperties.</para>
    /// <para> Represents the following element tag in the schema: w14:cNvPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:w14 = http://schemas.microsoft.com/office/word/2010/wordml
    /// </remark>
    public NonVisualDrawingProperties NonVisualDrawingProperties
    {
        get => GetElement<NonVisualDrawingProperties>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> NonVisualInkContentPartProperties.</para>
    /// <para> Represents the following element tag in the schema: w14:cNvContentPartPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:w14 = http://schemas.microsoft.com/office/word/2010/wordml
    /// </remark>
    public NonVisualInkContentPartProperties NonVisualInkContentPartProperties
    {
        get => GetElement<NonVisualInkContentPartProperties>(1);
        set => SetElement(1, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<WordNonVisualContentPartShapeProperties>(deep);

}
/// <summary>
/// <para>Defines the Transform2D Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w14:xfrm.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Offset &lt;a:off></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Extents &lt;a:ext></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Offset))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Extents))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class Transform2D : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12960;
    /// <inheritdoc/>
    public override string LocalName => "xfrm";
    
    internal override byte NamespaceId => 52;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<Int32Value>(0, "rot"),
		AttributeTag.Create<BooleanValue>(0, "flipH"),
		AttributeTag.Create<BooleanValue>(0, "flipV")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Rotation.</para>
    /// <para>Represents the following attribute in the schema: rot </para>
    /// </summary>
    [SchemaAttr(0, "rot")]
    public Int32Value Rotation
    {
        get { return (Int32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> Horizontal Flip.</para>
    /// <para>Represents the following attribute in the schema: flipH </para>
    /// </summary>
    [SchemaAttr(0, "flipH")]
    public BooleanValue HorizontalFlip
    {
        get { return (BooleanValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> Vertical Flip.</para>
    /// <para>Represents the following attribute in the schema: flipV </para>
    /// </summary>
    [SchemaAttr(0, "flipV")]
    public BooleanValue VerticalFlip
    {
        get { return (BooleanValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Transform2D class.
    /// </summary>
    public Transform2D():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Transform2D class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Transform2D(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Transform2D class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Transform2D(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Transform2D class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Transform2D(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 10 == namespaceId && "off" == name)
    return new DocumentFormat.OpenXml.Drawing.Offset();
    
if( 10 == namespaceId && "ext" == name)
    return new DocumentFormat.OpenXml.Drawing.Extents();
    

    return null;
}

        private static readonly string[] eleTagNames = { "off","ext" };
    private static readonly byte[] eleNamespaceIds = { 10,10 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Offset.</para>
    /// <para> Represents the following element tag in the schema: a:off </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Offset Offset
    {
        get => GetElement<DocumentFormat.OpenXml.Drawing.Offset>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Extents.</para>
    /// <para> Represents the following element tag in the schema: a:ext </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Extents Extents
    {
        get => GetElement<DocumentFormat.OpenXml.Drawing.Extents>(1);
        set => SetElement(1, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Transform2D>(deep);

}
/// <summary>
/// <para>Defines the OfficeArtExtensionList Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w14:extLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Extension &lt;a:ext></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Extension))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class OfficeArtExtensionList : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12961;
    /// <inheritdoc/>
    public override string LocalName => "extLst";
    
    internal override byte NamespaceId => 52;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the OfficeArtExtensionList class.
    /// </summary>
    public OfficeArtExtensionList():base(){}
    
        /// <summary>
    ///Initializes a new instance of the OfficeArtExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public OfficeArtExtensionList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the OfficeArtExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public OfficeArtExtensionList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the OfficeArtExtensionList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public OfficeArtExtensionList(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 10 == namespaceId && "ext" == name)
    return new DocumentFormat.OpenXml.Drawing.Extension();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<OfficeArtExtensionList>(deep);

}
/// <summary>
/// Defines the OnOffValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum OnOffValues
{  
	///<summary>
///true.
///<para>When the item is serialized out as xml, its value is "true".</para>
///</summary>
[EnumString("true")]
True,
///<summary>
///false.
///<para>When the item is serialized out as xml, its value is "false".</para>
///</summary>
[EnumString("false")]
False,
///<summary>
///0.
///<para>When the item is serialized out as xml, its value is "0".</para>
///</summary>
[EnumString("0")]
Zero,
///<summary>
///1.
///<para>When the item is serialized out as xml, its value is "1".</para>
///</summary>
[EnumString("1")]
One,
 
}
/// <summary>
/// Defines the SchemeColorValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum SchemeColorValues
{  
	///<summary>
///bg1.
///<para>When the item is serialized out as xml, its value is "bg1".</para>
///</summary>
[EnumString("bg1")]
BackgroundColor,
///<summary>
///tx1.
///<para>When the item is serialized out as xml, its value is "tx1".</para>
///</summary>
[EnumString("tx1")]
TextColor,
///<summary>
///bg2.
///<para>When the item is serialized out as xml, its value is "bg2".</para>
///</summary>
[EnumString("bg2")]
AdditionalBackgroundColor,
///<summary>
///tx2.
///<para>When the item is serialized out as xml, its value is "tx2".</para>
///</summary>
[EnumString("tx2")]
AdditionalTextColor,
///<summary>
///accent1.
///<para>When the item is serialized out as xml, its value is "accent1".</para>
///</summary>
[EnumString("accent1")]
ExtraSchemeColor1,
///<summary>
///accent2.
///<para>When the item is serialized out as xml, its value is "accent2".</para>
///</summary>
[EnumString("accent2")]
ExtraSchemeColor2,
///<summary>
///accent3.
///<para>When the item is serialized out as xml, its value is "accent3".</para>
///</summary>
[EnumString("accent3")]
ExtraSchemeColor3,
///<summary>
///accent4.
///<para>When the item is serialized out as xml, its value is "accent4".</para>
///</summary>
[EnumString("accent4")]
ExtraSchemeColor4,
///<summary>
///accent5.
///<para>When the item is serialized out as xml, its value is "accent5".</para>
///</summary>
[EnumString("accent5")]
ExtraSchemeColor5,
///<summary>
///accent6.
///<para>When the item is serialized out as xml, its value is "accent6".</para>
///</summary>
[EnumString("accent6")]
ExtraSchemeColor6,
///<summary>
///hlink.
///<para>When the item is serialized out as xml, its value is "hlink".</para>
///</summary>
[EnumString("hlink")]
HyperlinkColor,
///<summary>
///folHlink.
///<para>When the item is serialized out as xml, its value is "folHlink".</para>
///</summary>
[EnumString("folHlink")]
FollowedHyperlinkColor,
///<summary>
///dk1.
///<para>When the item is serialized out as xml, its value is "dk1".</para>
///</summary>
[EnumString("dk1")]
MainDarkColor1,
///<summary>
///lt1.
///<para>When the item is serialized out as xml, its value is "lt1".</para>
///</summary>
[EnumString("lt1")]
MainLightColor1,
///<summary>
///dk2.
///<para>When the item is serialized out as xml, its value is "dk2".</para>
///</summary>
[EnumString("dk2")]
MainDarkColor2,
///<summary>
///lt2.
///<para>When the item is serialized out as xml, its value is "lt2".</para>
///</summary>
[EnumString("lt2")]
MainLightColor2,
///<summary>
///phClr.
///<para>When the item is serialized out as xml, its value is "phClr".</para>
///</summary>
[EnumString("phClr")]
AutoColor,
 
}
/// <summary>
/// Defines the RectangleAlignmentValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum RectangleAlignmentValues
{  
	///<summary>
///none.
///<para>When the item is serialized out as xml, its value is "none".</para>
///</summary>
[EnumString("none")]
None,
///<summary>
///tl.
///<para>When the item is serialized out as xml, its value is "tl".</para>
///</summary>
[EnumString("tl")]
TopLeft,
///<summary>
///t.
///<para>When the item is serialized out as xml, its value is "t".</para>
///</summary>
[EnumString("t")]
Top,
///<summary>
///tr.
///<para>When the item is serialized out as xml, its value is "tr".</para>
///</summary>
[EnumString("tr")]
TopRight,
///<summary>
///l.
///<para>When the item is serialized out as xml, its value is "l".</para>
///</summary>
[EnumString("l")]
Left,
///<summary>
///ctr.
///<para>When the item is serialized out as xml, its value is "ctr".</para>
///</summary>
[EnumString("ctr")]
Center,
///<summary>
///r.
///<para>When the item is serialized out as xml, its value is "r".</para>
///</summary>
[EnumString("r")]
Right,
///<summary>
///bl.
///<para>When the item is serialized out as xml, its value is "bl".</para>
///</summary>
[EnumString("bl")]
BottomLeft,
///<summary>
///b.
///<para>When the item is serialized out as xml, its value is "b".</para>
///</summary>
[EnumString("b")]
Bottom,
///<summary>
///br.
///<para>When the item is serialized out as xml, its value is "br".</para>
///</summary>
[EnumString("br")]
BottomRight,
 
}
/// <summary>
/// Defines the PathShadeTypeValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum PathShadeTypeValues
{  
	///<summary>
///shape.
///<para>When the item is serialized out as xml, its value is "shape".</para>
///</summary>
[EnumString("shape")]
Shape,
///<summary>
///circle.
///<para>When the item is serialized out as xml, its value is "circle".</para>
///</summary>
[EnumString("circle")]
Circle,
///<summary>
///rect.
///<para>When the item is serialized out as xml, its value is "rect".</para>
///</summary>
[EnumString("rect")]
Rect,
 
}
/// <summary>
/// Defines the LineCapValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum LineCapValues
{  
	///<summary>
///rnd.
///<para>When the item is serialized out as xml, its value is "rnd".</para>
///</summary>
[EnumString("rnd")]
Round,
///<summary>
///sq.
///<para>When the item is serialized out as xml, its value is "sq".</para>
///</summary>
[EnumString("sq")]
Square,
///<summary>
///flat.
///<para>When the item is serialized out as xml, its value is "flat".</para>
///</summary>
[EnumString("flat")]
Flat,
 
}
/// <summary>
/// Defines the PresetLineDashValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum PresetLineDashValues
{  
	///<summary>
///solid.
///<para>When the item is serialized out as xml, its value is "solid".</para>
///</summary>
[EnumString("solid")]
Solid,
///<summary>
///dot.
///<para>When the item is serialized out as xml, its value is "dot".</para>
///</summary>
[EnumString("dot")]
Dot,
///<summary>
///sysDot.
///<para>When the item is serialized out as xml, its value is "sysDot".</para>
///</summary>
[EnumString("sysDot")]
SysDot,
///<summary>
///dash.
///<para>When the item is serialized out as xml, its value is "dash".</para>
///</summary>
[EnumString("dash")]
Dash,
///<summary>
///sysDash.
///<para>When the item is serialized out as xml, its value is "sysDash".</para>
///</summary>
[EnumString("sysDash")]
SysDash,
///<summary>
///lgDash.
///<para>When the item is serialized out as xml, its value is "lgDash".</para>
///</summary>
[EnumString("lgDash")]
LongDash,
///<summary>
///dashDot.
///<para>When the item is serialized out as xml, its value is "dashDot".</para>
///</summary>
[EnumString("dashDot")]
DashDot,
///<summary>
///sysDashDot.
///<para>When the item is serialized out as xml, its value is "sysDashDot".</para>
///</summary>
[EnumString("sysDashDot")]
SystemDashDot,
///<summary>
///lgDashDot.
///<para>When the item is serialized out as xml, its value is "lgDashDot".</para>
///</summary>
[EnumString("lgDashDot")]
LongDashDot,
///<summary>
///lgDashDotDot.
///<para>When the item is serialized out as xml, its value is "lgDashDotDot".</para>
///</summary>
[EnumString("lgDashDotDot")]
LongDashDotDot,
///<summary>
///sysDashDotDot.
///<para>When the item is serialized out as xml, its value is "sysDashDotDot".</para>
///</summary>
[EnumString("sysDashDotDot")]
SystemDashDotDot,
 
}
/// <summary>
/// Defines the PenAlignmentValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum PenAlignmentValues
{  
	///<summary>
///ctr.
///<para>When the item is serialized out as xml, its value is "ctr".</para>
///</summary>
[EnumString("ctr")]
Center,
///<summary>
///in.
///<para>When the item is serialized out as xml, its value is "in".</para>
///</summary>
[EnumString("in")]
Inset,
 
}
/// <summary>
/// Defines the CompoundLineValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum CompoundLineValues
{  
	///<summary>
///sng.
///<para>When the item is serialized out as xml, its value is "sng".</para>
///</summary>
[EnumString("sng")]
Simple,
///<summary>
///dbl.
///<para>When the item is serialized out as xml, its value is "dbl".</para>
///</summary>
[EnumString("dbl")]
Double,
///<summary>
///thickThin.
///<para>When the item is serialized out as xml, its value is "thickThin".</para>
///</summary>
[EnumString("thickThin")]
ThickThin,
///<summary>
///thinThick.
///<para>When the item is serialized out as xml, its value is "thinThick".</para>
///</summary>
[EnumString("thinThick")]
ThinThick,
///<summary>
///tri.
///<para>When the item is serialized out as xml, its value is "tri".</para>
///</summary>
[EnumString("tri")]
Triple,
 
}
/// <summary>
/// Defines the PresetCameraTypeValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum PresetCameraTypeValues
{  
	///<summary>
///legacyObliqueTopLeft.
///<para>When the item is serialized out as xml, its value is "legacyObliqueTopLeft".</para>
///</summary>
[EnumString("legacyObliqueTopLeft")]
LegacyObliqueTopLeft,
///<summary>
///legacyObliqueTop.
///<para>When the item is serialized out as xml, its value is "legacyObliqueTop".</para>
///</summary>
[EnumString("legacyObliqueTop")]
LegacyObliqueTop,
///<summary>
///legacyObliqueTopRight.
///<para>When the item is serialized out as xml, its value is "legacyObliqueTopRight".</para>
///</summary>
[EnumString("legacyObliqueTopRight")]
LegacyObliqueTopRight,
///<summary>
///legacyObliqueLeft.
///<para>When the item is serialized out as xml, its value is "legacyObliqueLeft".</para>
///</summary>
[EnumString("legacyObliqueLeft")]
LegacyObliqueLeft,
///<summary>
///legacyObliqueFront.
///<para>When the item is serialized out as xml, its value is "legacyObliqueFront".</para>
///</summary>
[EnumString("legacyObliqueFront")]
LegacyObliqueFront,
///<summary>
///legacyObliqueRight.
///<para>When the item is serialized out as xml, its value is "legacyObliqueRight".</para>
///</summary>
[EnumString("legacyObliqueRight")]
LegacyObliqueRight,
///<summary>
///legacyObliqueBottomLeft.
///<para>When the item is serialized out as xml, its value is "legacyObliqueBottomLeft".</para>
///</summary>
[EnumString("legacyObliqueBottomLeft")]
LegacyObliqueBottomLeft,
///<summary>
///legacyObliqueBottom.
///<para>When the item is serialized out as xml, its value is "legacyObliqueBottom".</para>
///</summary>
[EnumString("legacyObliqueBottom")]
LegacyObliqueBottom,
///<summary>
///legacyObliqueBottomRight.
///<para>When the item is serialized out as xml, its value is "legacyObliqueBottomRight".</para>
///</summary>
[EnumString("legacyObliqueBottomRight")]
LegacyObliqueBottomRight,
///<summary>
///legacyPerspectiveTopLeft.
///<para>When the item is serialized out as xml, its value is "legacyPerspectiveTopLeft".</para>
///</summary>
[EnumString("legacyPerspectiveTopLeft")]
LegacyPerspectiveTopLeft,
///<summary>
///legacyPerspectiveTop.
///<para>When the item is serialized out as xml, its value is "legacyPerspectiveTop".</para>
///</summary>
[EnumString("legacyPerspectiveTop")]
LegacyPerspectiveTop,
///<summary>
///legacyPerspectiveTopRight.
///<para>When the item is serialized out as xml, its value is "legacyPerspectiveTopRight".</para>
///</summary>
[EnumString("legacyPerspectiveTopRight")]
LegacyPerspectiveTopRight,
///<summary>
///legacyPerspectiveLeft.
///<para>When the item is serialized out as xml, its value is "legacyPerspectiveLeft".</para>
///</summary>
[EnumString("legacyPerspectiveLeft")]
LegacyPerspectiveLeft,
///<summary>
///legacyPerspectiveFront.
///<para>When the item is serialized out as xml, its value is "legacyPerspectiveFront".</para>
///</summary>
[EnumString("legacyPerspectiveFront")]
LegacyPerspectiveFront,
///<summary>
///legacyPerspectiveRight.
///<para>When the item is serialized out as xml, its value is "legacyPerspectiveRight".</para>
///</summary>
[EnumString("legacyPerspectiveRight")]
LegacyPerspectiveRight,
///<summary>
///legacyPerspectiveBottomLeft.
///<para>When the item is serialized out as xml, its value is "legacyPerspectiveBottomLeft".</para>
///</summary>
[EnumString("legacyPerspectiveBottomLeft")]
LegacyPerspectiveBottomLeft,
///<summary>
///legacyPerspectiveBottom.
///<para>When the item is serialized out as xml, its value is "legacyPerspectiveBottom".</para>
///</summary>
[EnumString("legacyPerspectiveBottom")]
LegacyPerspectiveBottom,
///<summary>
///legacyPerspectiveBottomRight.
///<para>When the item is serialized out as xml, its value is "legacyPerspectiveBottomRight".</para>
///</summary>
[EnumString("legacyPerspectiveBottomRight")]
LegacyPerspectiveBottomRight,
///<summary>
///orthographicFront.
///<para>When the item is serialized out as xml, its value is "orthographicFront".</para>
///</summary>
[EnumString("orthographicFront")]
OrthographicFront,
///<summary>
///isometricTopUp.
///<para>When the item is serialized out as xml, its value is "isometricTopUp".</para>
///</summary>
[EnumString("isometricTopUp")]
IsometricTopUp,
///<summary>
///isometricTopDown.
///<para>When the item is serialized out as xml, its value is "isometricTopDown".</para>
///</summary>
[EnumString("isometricTopDown")]
IsometricTopDown,
///<summary>
///isometricBottomUp.
///<para>When the item is serialized out as xml, its value is "isometricBottomUp".</para>
///</summary>
[EnumString("isometricBottomUp")]
IsometricBottomUp,
///<summary>
///isometricBottomDown.
///<para>When the item is serialized out as xml, its value is "isometricBottomDown".</para>
///</summary>
[EnumString("isometricBottomDown")]
IsometricBottomDown,
///<summary>
///isometricLeftUp.
///<para>When the item is serialized out as xml, its value is "isometricLeftUp".</para>
///</summary>
[EnumString("isometricLeftUp")]
IsometricLeftUp,
///<summary>
///isometricLeftDown.
///<para>When the item is serialized out as xml, its value is "isometricLeftDown".</para>
///</summary>
[EnumString("isometricLeftDown")]
IsometricLeftDown,
///<summary>
///isometricRightUp.
///<para>When the item is serialized out as xml, its value is "isometricRightUp".</para>
///</summary>
[EnumString("isometricRightUp")]
IsometricRightUp,
///<summary>
///isometricRightDown.
///<para>When the item is serialized out as xml, its value is "isometricRightDown".</para>
///</summary>
[EnumString("isometricRightDown")]
IsometricRightDown,
///<summary>
///isometricOffAxis1Left.
///<para>When the item is serialized out as xml, its value is "isometricOffAxis1Left".</para>
///</summary>
[EnumString("isometricOffAxis1Left")]
IsometricOffAxis1Left,
///<summary>
///isometricOffAxis1Right.
///<para>When the item is serialized out as xml, its value is "isometricOffAxis1Right".</para>
///</summary>
[EnumString("isometricOffAxis1Right")]
IsometricOffAxis1Right,
///<summary>
///isometricOffAxis1Top.
///<para>When the item is serialized out as xml, its value is "isometricOffAxis1Top".</para>
///</summary>
[EnumString("isometricOffAxis1Top")]
IsometricOffAxis1Top,
///<summary>
///isometricOffAxis2Left.
///<para>When the item is serialized out as xml, its value is "isometricOffAxis2Left".</para>
///</summary>
[EnumString("isometricOffAxis2Left")]
IsometricOffAxis2Left,
///<summary>
///isometricOffAxis2Right.
///<para>When the item is serialized out as xml, its value is "isometricOffAxis2Right".</para>
///</summary>
[EnumString("isometricOffAxis2Right")]
IsometricOffAxis2Right,
///<summary>
///isometricOffAxis2Top.
///<para>When the item is serialized out as xml, its value is "isometricOffAxis2Top".</para>
///</summary>
[EnumString("isometricOffAxis2Top")]
IsometricOffAxis2Top,
///<summary>
///isometricOffAxis3Left.
///<para>When the item is serialized out as xml, its value is "isometricOffAxis3Left".</para>
///</summary>
[EnumString("isometricOffAxis3Left")]
IsometricOffAxis3Left,
///<summary>
///isometricOffAxis3Right.
///<para>When the item is serialized out as xml, its value is "isometricOffAxis3Right".</para>
///</summary>
[EnumString("isometricOffAxis3Right")]
IsometricOffAxis3Right,
///<summary>
///isometricOffAxis3Bottom.
///<para>When the item is serialized out as xml, its value is "isometricOffAxis3Bottom".</para>
///</summary>
[EnumString("isometricOffAxis3Bottom")]
IsometricOffAxis3Bottom,
///<summary>
///isometricOffAxis4Left.
///<para>When the item is serialized out as xml, its value is "isometricOffAxis4Left".</para>
///</summary>
[EnumString("isometricOffAxis4Left")]
IsometricOffAxis4Left,
///<summary>
///isometricOffAxis4Right.
///<para>When the item is serialized out as xml, its value is "isometricOffAxis4Right".</para>
///</summary>
[EnumString("isometricOffAxis4Right")]
IsometricOffAxis4Right,
///<summary>
///isometricOffAxis4Bottom.
///<para>When the item is serialized out as xml, its value is "isometricOffAxis4Bottom".</para>
///</summary>
[EnumString("isometricOffAxis4Bottom")]
IsometricOffAxis4Bottom,
///<summary>
///obliqueTopLeft.
///<para>When the item is serialized out as xml, its value is "obliqueTopLeft".</para>
///</summary>
[EnumString("obliqueTopLeft")]
ObliqueTopLeft,
///<summary>
///obliqueTop.
///<para>When the item is serialized out as xml, its value is "obliqueTop".</para>
///</summary>
[EnumString("obliqueTop")]
ObliqueTop,
///<summary>
///obliqueTopRight.
///<para>When the item is serialized out as xml, its value is "obliqueTopRight".</para>
///</summary>
[EnumString("obliqueTopRight")]
ObliqueTopRight,
///<summary>
///obliqueLeft.
///<para>When the item is serialized out as xml, its value is "obliqueLeft".</para>
///</summary>
[EnumString("obliqueLeft")]
ObliqueLeft,
///<summary>
///obliqueRight.
///<para>When the item is serialized out as xml, its value is "obliqueRight".</para>
///</summary>
[EnumString("obliqueRight")]
ObliqueRight,
///<summary>
///obliqueBottomLeft.
///<para>When the item is serialized out as xml, its value is "obliqueBottomLeft".</para>
///</summary>
[EnumString("obliqueBottomLeft")]
ObliqueBottomLeft,
///<summary>
///obliqueBottom.
///<para>When the item is serialized out as xml, its value is "obliqueBottom".</para>
///</summary>
[EnumString("obliqueBottom")]
ObliqueBottom,
///<summary>
///obliqueBottomRight.
///<para>When the item is serialized out as xml, its value is "obliqueBottomRight".</para>
///</summary>
[EnumString("obliqueBottomRight")]
ObliqueBottomRight,
///<summary>
///perspectiveFront.
///<para>When the item is serialized out as xml, its value is "perspectiveFront".</para>
///</summary>
[EnumString("perspectiveFront")]
PerspectiveFront,
///<summary>
///perspectiveLeft.
///<para>When the item is serialized out as xml, its value is "perspectiveLeft".</para>
///</summary>
[EnumString("perspectiveLeft")]
PerspectiveLeft,
///<summary>
///perspectiveRight.
///<para>When the item is serialized out as xml, its value is "perspectiveRight".</para>
///</summary>
[EnumString("perspectiveRight")]
PerspectiveRight,
///<summary>
///perspectiveAbove.
///<para>When the item is serialized out as xml, its value is "perspectiveAbove".</para>
///</summary>
[EnumString("perspectiveAbove")]
PerspectiveAbove,
///<summary>
///perspectiveBelow.
///<para>When the item is serialized out as xml, its value is "perspectiveBelow".</para>
///</summary>
[EnumString("perspectiveBelow")]
PerspectiveBelow,
///<summary>
///perspectiveAboveLeftFacing.
///<para>When the item is serialized out as xml, its value is "perspectiveAboveLeftFacing".</para>
///</summary>
[EnumString("perspectiveAboveLeftFacing")]
PerspectiveAboveLeftFacing,
///<summary>
///perspectiveAboveRightFacing.
///<para>When the item is serialized out as xml, its value is "perspectiveAboveRightFacing".</para>
///</summary>
[EnumString("perspectiveAboveRightFacing")]
PerspectiveAboveRightFacing,
///<summary>
///perspectiveContrastingLeftFacing.
///<para>When the item is serialized out as xml, its value is "perspectiveContrastingLeftFacing".</para>
///</summary>
[EnumString("perspectiveContrastingLeftFacing")]
PerspectiveContrastingLeftFacing,
///<summary>
///perspectiveContrastingRightFacing.
///<para>When the item is serialized out as xml, its value is "perspectiveContrastingRightFacing".</para>
///</summary>
[EnumString("perspectiveContrastingRightFacing")]
PerspectiveContrastingRightFacing,
///<summary>
///perspectiveHeroicLeftFacing.
///<para>When the item is serialized out as xml, its value is "perspectiveHeroicLeftFacing".</para>
///</summary>
[EnumString("perspectiveHeroicLeftFacing")]
PerspectiveHeroicLeftFacing,
///<summary>
///perspectiveHeroicRightFacing.
///<para>When the item is serialized out as xml, its value is "perspectiveHeroicRightFacing".</para>
///</summary>
[EnumString("perspectiveHeroicRightFacing")]
PerspectiveHeroicRightFacing,
///<summary>
///perspectiveHeroicExtremeLeftFacing.
///<para>When the item is serialized out as xml, its value is "perspectiveHeroicExtremeLeftFacing".</para>
///</summary>
[EnumString("perspectiveHeroicExtremeLeftFacing")]
PerspectiveHeroicExtremeLeftFacing,
///<summary>
///perspectiveHeroicExtremeRightFacing.
///<para>When the item is serialized out as xml, its value is "perspectiveHeroicExtremeRightFacing".</para>
///</summary>
[EnumString("perspectiveHeroicExtremeRightFacing")]
PerspectiveHeroicExtremeRightFacing,
///<summary>
///perspectiveRelaxed.
///<para>When the item is serialized out as xml, its value is "perspectiveRelaxed".</para>
///</summary>
[EnumString("perspectiveRelaxed")]
PerspectiveRelaxed,
///<summary>
///perspectiveRelaxedModerately.
///<para>When the item is serialized out as xml, its value is "perspectiveRelaxedModerately".</para>
///</summary>
[EnumString("perspectiveRelaxedModerately")]
PerspectiveRelaxedModerately,
 
}
/// <summary>
/// Defines the LightRigTypeValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum LightRigTypeValues
{  
	///<summary>
///legacyFlat1.
///<para>When the item is serialized out as xml, its value is "legacyFlat1".</para>
///</summary>
[EnumString("legacyFlat1")]
LegacyFlat1,
///<summary>
///legacyFlat2.
///<para>When the item is serialized out as xml, its value is "legacyFlat2".</para>
///</summary>
[EnumString("legacyFlat2")]
LegacyFlat2,
///<summary>
///legacyFlat3.
///<para>When the item is serialized out as xml, its value is "legacyFlat3".</para>
///</summary>
[EnumString("legacyFlat3")]
LegacyFlat3,
///<summary>
///legacyFlat4.
///<para>When the item is serialized out as xml, its value is "legacyFlat4".</para>
///</summary>
[EnumString("legacyFlat4")]
LegacyFlat4,
///<summary>
///legacyNormal1.
///<para>When the item is serialized out as xml, its value is "legacyNormal1".</para>
///</summary>
[EnumString("legacyNormal1")]
LegacyNormal1,
///<summary>
///legacyNormal2.
///<para>When the item is serialized out as xml, its value is "legacyNormal2".</para>
///</summary>
[EnumString("legacyNormal2")]
LegacyNormal2,
///<summary>
///legacyNormal3.
///<para>When the item is serialized out as xml, its value is "legacyNormal3".</para>
///</summary>
[EnumString("legacyNormal3")]
LegacyNormal3,
///<summary>
///legacyNormal4.
///<para>When the item is serialized out as xml, its value is "legacyNormal4".</para>
///</summary>
[EnumString("legacyNormal4")]
LegacyNormal4,
///<summary>
///legacyHarsh1.
///<para>When the item is serialized out as xml, its value is "legacyHarsh1".</para>
///</summary>
[EnumString("legacyHarsh1")]
LegacyHarsh1,
///<summary>
///legacyHarsh2.
///<para>When the item is serialized out as xml, its value is "legacyHarsh2".</para>
///</summary>
[EnumString("legacyHarsh2")]
LegacyHarsh2,
///<summary>
///legacyHarsh3.
///<para>When the item is serialized out as xml, its value is "legacyHarsh3".</para>
///</summary>
[EnumString("legacyHarsh3")]
LegacyHarsh3,
///<summary>
///legacyHarsh4.
///<para>When the item is serialized out as xml, its value is "legacyHarsh4".</para>
///</summary>
[EnumString("legacyHarsh4")]
LegacyHarsh4,
///<summary>
///threePt.
///<para>When the item is serialized out as xml, its value is "threePt".</para>
///</summary>
[EnumString("threePt")]
ThreePoint,
///<summary>
///balanced.
///<para>When the item is serialized out as xml, its value is "balanced".</para>
///</summary>
[EnumString("balanced")]
Balanced,
///<summary>
///soft.
///<para>When the item is serialized out as xml, its value is "soft".</para>
///</summary>
[EnumString("soft")]
Soft,
///<summary>
///harsh.
///<para>When the item is serialized out as xml, its value is "harsh".</para>
///</summary>
[EnumString("harsh")]
Harsh,
///<summary>
///flood.
///<para>When the item is serialized out as xml, its value is "flood".</para>
///</summary>
[EnumString("flood")]
Flood,
///<summary>
///contrasting.
///<para>When the item is serialized out as xml, its value is "contrasting".</para>
///</summary>
[EnumString("contrasting")]
Contrasting,
///<summary>
///morning.
///<para>When the item is serialized out as xml, its value is "morning".</para>
///</summary>
[EnumString("morning")]
Morning,
///<summary>
///sunrise.
///<para>When the item is serialized out as xml, its value is "sunrise".</para>
///</summary>
[EnumString("sunrise")]
Sunrise,
///<summary>
///sunset.
///<para>When the item is serialized out as xml, its value is "sunset".</para>
///</summary>
[EnumString("sunset")]
Sunset,
///<summary>
///chilly.
///<para>When the item is serialized out as xml, its value is "chilly".</para>
///</summary>
[EnumString("chilly")]
Chilly,
///<summary>
///freezing.
///<para>When the item is serialized out as xml, its value is "freezing".</para>
///</summary>
[EnumString("freezing")]
Freezing,
///<summary>
///flat.
///<para>When the item is serialized out as xml, its value is "flat".</para>
///</summary>
[EnumString("flat")]
Flat,
///<summary>
///twoPt.
///<para>When the item is serialized out as xml, its value is "twoPt".</para>
///</summary>
[EnumString("twoPt")]
TwoPoint,
///<summary>
///glow.
///<para>When the item is serialized out as xml, its value is "glow".</para>
///</summary>
[EnumString("glow")]
Glow,
///<summary>
///brightRoom.
///<para>When the item is serialized out as xml, its value is "brightRoom".</para>
///</summary>
[EnumString("brightRoom")]
BrightRoom,
 
}
/// <summary>
/// Defines the LightRigDirectionValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum LightRigDirectionValues
{  
	///<summary>
///tl.
///<para>When the item is serialized out as xml, its value is "tl".</para>
///</summary>
[EnumString("tl")]
TopLeft,
///<summary>
///t.
///<para>When the item is serialized out as xml, its value is "t".</para>
///</summary>
[EnumString("t")]
Top,
///<summary>
///tr.
///<para>When the item is serialized out as xml, its value is "tr".</para>
///</summary>
[EnumString("tr")]
TopRight,
///<summary>
///l.
///<para>When the item is serialized out as xml, its value is "l".</para>
///</summary>
[EnumString("l")]
Left,
///<summary>
///r.
///<para>When the item is serialized out as xml, its value is "r".</para>
///</summary>
[EnumString("r")]
Right,
///<summary>
///bl.
///<para>When the item is serialized out as xml, its value is "bl".</para>
///</summary>
[EnumString("bl")]
BottomLeft,
///<summary>
///b.
///<para>When the item is serialized out as xml, its value is "b".</para>
///</summary>
[EnumString("b")]
Bottom,
///<summary>
///br.
///<para>When the item is serialized out as xml, its value is "br".</para>
///</summary>
[EnumString("br")]
BottomRight,
 
}
/// <summary>
/// Defines the BevelPresetTypeValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum BevelPresetTypeValues
{  
	///<summary>
///relaxedInset.
///<para>When the item is serialized out as xml, its value is "relaxedInset".</para>
///</summary>
[EnumString("relaxedInset")]
RelaxedInset,
///<summary>
///circle.
///<para>When the item is serialized out as xml, its value is "circle".</para>
///</summary>
[EnumString("circle")]
Circle,
///<summary>
///slope.
///<para>When the item is serialized out as xml, its value is "slope".</para>
///</summary>
[EnumString("slope")]
Slope,
///<summary>
///cross.
///<para>When the item is serialized out as xml, its value is "cross".</para>
///</summary>
[EnumString("cross")]
Cross,
///<summary>
///angle.
///<para>When the item is serialized out as xml, its value is "angle".</para>
///</summary>
[EnumString("angle")]
Angle,
///<summary>
///softRound.
///<para>When the item is serialized out as xml, its value is "softRound".</para>
///</summary>
[EnumString("softRound")]
SoftRound,
///<summary>
///convex.
///<para>When the item is serialized out as xml, its value is "convex".</para>
///</summary>
[EnumString("convex")]
Convex,
///<summary>
///coolSlant.
///<para>When the item is serialized out as xml, its value is "coolSlant".</para>
///</summary>
[EnumString("coolSlant")]
CoolSlant,
///<summary>
///divot.
///<para>When the item is serialized out as xml, its value is "divot".</para>
///</summary>
[EnumString("divot")]
Divot,
///<summary>
///riblet.
///<para>When the item is serialized out as xml, its value is "riblet".</para>
///</summary>
[EnumString("riblet")]
Riblet,
///<summary>
///hardEdge.
///<para>When the item is serialized out as xml, its value is "hardEdge".</para>
///</summary>
[EnumString("hardEdge")]
HardEdge,
///<summary>
///artDeco.
///<para>When the item is serialized out as xml, its value is "artDeco".</para>
///</summary>
[EnumString("artDeco")]
ArtDeco,
 
}
/// <summary>
/// Defines the PresetMaterialTypeValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum PresetMaterialTypeValues
{  
	///<summary>
///legacyMatte.
///<para>When the item is serialized out as xml, its value is "legacyMatte".</para>
///</summary>
[EnumString("legacyMatte")]
LegacyMatte,
///<summary>
///legacyPlastic.
///<para>When the item is serialized out as xml, its value is "legacyPlastic".</para>
///</summary>
[EnumString("legacyPlastic")]
LegacyPlastic,
///<summary>
///legacyMetal.
///<para>When the item is serialized out as xml, its value is "legacyMetal".</para>
///</summary>
[EnumString("legacyMetal")]
LegacyMetal,
///<summary>
///legacyWireframe.
///<para>When the item is serialized out as xml, its value is "legacyWireframe".</para>
///</summary>
[EnumString("legacyWireframe")]
LegacyWireframe,
///<summary>
///matte.
///<para>When the item is serialized out as xml, its value is "matte".</para>
///</summary>
[EnumString("matte")]
Matte,
///<summary>
///plastic.
///<para>When the item is serialized out as xml, its value is "plastic".</para>
///</summary>
[EnumString("plastic")]
Plastic,
///<summary>
///metal.
///<para>When the item is serialized out as xml, its value is "metal".</para>
///</summary>
[EnumString("metal")]
Metal,
///<summary>
///warmMatte.
///<para>When the item is serialized out as xml, its value is "warmMatte".</para>
///</summary>
[EnumString("warmMatte")]
WarmMatte,
///<summary>
///translucentPowder.
///<para>When the item is serialized out as xml, its value is "translucentPowder".</para>
///</summary>
[EnumString("translucentPowder")]
TranslucentPowder,
///<summary>
///powder.
///<para>When the item is serialized out as xml, its value is "powder".</para>
///</summary>
[EnumString("powder")]
Powder,
///<summary>
///dkEdge.
///<para>When the item is serialized out as xml, its value is "dkEdge".</para>
///</summary>
[EnumString("dkEdge")]
DarkEdge,
///<summary>
///softEdge.
///<para>When the item is serialized out as xml, its value is "softEdge".</para>
///</summary>
[EnumString("softEdge")]
SoftEdge,
///<summary>
///clear.
///<para>When the item is serialized out as xml, its value is "clear".</para>
///</summary>
[EnumString("clear")]
Clear,
///<summary>
///flat.
///<para>When the item is serialized out as xml, its value is "flat".</para>
///</summary>
[EnumString("flat")]
Flat,
///<summary>
///softmetal.
///<para>When the item is serialized out as xml, its value is "softmetal".</para>
///</summary>
[EnumString("softmetal")]
SoftMetal,
///<summary>
///none.
///<para>When the item is serialized out as xml, its value is "none".</para>
///</summary>
[EnumString("none")]
None,
 
}
/// <summary>
/// Defines the LigaturesValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum LigaturesValues
{  
	///<summary>
///none.
///<para>When the item is serialized out as xml, its value is "none".</para>
///</summary>
[EnumString("none")]
None,
///<summary>
///standard.
///<para>When the item is serialized out as xml, its value is "standard".</para>
///</summary>
[EnumString("standard")]
Standard,
///<summary>
///contextual.
///<para>When the item is serialized out as xml, its value is "contextual".</para>
///</summary>
[EnumString("contextual")]
Contextual,
///<summary>
///historical.
///<para>When the item is serialized out as xml, its value is "historical".</para>
///</summary>
[EnumString("historical")]
Historical,
///<summary>
///discretional.
///<para>When the item is serialized out as xml, its value is "discretional".</para>
///</summary>
[EnumString("discretional")]
Discretional,
///<summary>
///standardContextual.
///<para>When the item is serialized out as xml, its value is "standardContextual".</para>
///</summary>
[EnumString("standardContextual")]
StandardContextual,
///<summary>
///standardHistorical.
///<para>When the item is serialized out as xml, its value is "standardHistorical".</para>
///</summary>
[EnumString("standardHistorical")]
StandardHistorical,
///<summary>
///contextualHistorical.
///<para>When the item is serialized out as xml, its value is "contextualHistorical".</para>
///</summary>
[EnumString("contextualHistorical")]
ContextualHistorical,
///<summary>
///standardDiscretional.
///<para>When the item is serialized out as xml, its value is "standardDiscretional".</para>
///</summary>
[EnumString("standardDiscretional")]
StandardDiscretional,
///<summary>
///contextualDiscretional.
///<para>When the item is serialized out as xml, its value is "contextualDiscretional".</para>
///</summary>
[EnumString("contextualDiscretional")]
ContextualDiscretional,
///<summary>
///historicalDiscretional.
///<para>When the item is serialized out as xml, its value is "historicalDiscretional".</para>
///</summary>
[EnumString("historicalDiscretional")]
HistoricalDiscretional,
///<summary>
///standardContextualHistorical.
///<para>When the item is serialized out as xml, its value is "standardContextualHistorical".</para>
///</summary>
[EnumString("standardContextualHistorical")]
StandardContextualHistorical,
///<summary>
///standardContextualDiscretional.
///<para>When the item is serialized out as xml, its value is "standardContextualDiscretional".</para>
///</summary>
[EnumString("standardContextualDiscretional")]
StandardContextualDiscretional,
///<summary>
///standardHistoricalDiscretional.
///<para>When the item is serialized out as xml, its value is "standardHistoricalDiscretional".</para>
///</summary>
[EnumString("standardHistoricalDiscretional")]
StandardHistoricalDiscretional,
///<summary>
///contextualHistoricalDiscretional.
///<para>When the item is serialized out as xml, its value is "contextualHistoricalDiscretional".</para>
///</summary>
[EnumString("contextualHistoricalDiscretional")]
ContextualHistoricalDiscretional,
///<summary>
///all.
///<para>When the item is serialized out as xml, its value is "all".</para>
///</summary>
[EnumString("all")]
All,
 
}
/// <summary>
/// Defines the NumberFormValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum NumberFormValues
{  
	///<summary>
///default.
///<para>When the item is serialized out as xml, its value is "default".</para>
///</summary>
[EnumString("default")]
Default,
///<summary>
///lining.
///<para>When the item is serialized out as xml, its value is "lining".</para>
///</summary>
[EnumString("lining")]
Lining,
///<summary>
///oldStyle.
///<para>When the item is serialized out as xml, its value is "oldStyle".</para>
///</summary>
[EnumString("oldStyle")]
OldStyle,
 
}
/// <summary>
/// Defines the NumberSpacingValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum NumberSpacingValues
{  
	///<summary>
///default.
///<para>When the item is serialized out as xml, its value is "default".</para>
///</summary>
[EnumString("default")]
Default,
///<summary>
///proportional.
///<para>When the item is serialized out as xml, its value is "proportional".</para>
///</summary>
[EnumString("proportional")]
Proportional,
///<summary>
///tabular.
///<para>When the item is serialized out as xml, its value is "tabular".</para>
///</summary>
[EnumString("tabular")]
Tabular,
 
}
}
 
 
