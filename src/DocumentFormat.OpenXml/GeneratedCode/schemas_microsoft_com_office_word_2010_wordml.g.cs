// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Office2010.Drawing;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using DocumentFormat.OpenXml.Validation.Semantic;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office2010.Word
{
    /// <summary>
    /// <para>Defines the RunConflictInsertion Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w14:conflictIns.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.SdtRun &lt;w:sdt></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.ProofError &lt;w:proofErr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.PermStart &lt;w:permStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.PermEnd &lt;w:permEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.BookmarkStart &lt;w:bookmarkStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd &lt;w:bookmarkEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart &lt;w:commentRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd &lt;w:commentRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart &lt;w:moveFromRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd &lt;w:moveFromRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart &lt;w:moveToRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd &lt;w:moveToRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart &lt;w:customXmlInsRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd &lt;w:customXmlInsRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart &lt;w:customXmlDelRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd &lt;w:customXmlDelRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart &lt;w:customXmlMoveFromRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd &lt;w:customXmlMoveFromRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart &lt;w:customXmlMoveToRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd &lt;w:customXmlMoveToRangeEnd></description></item>
    ///   <item><description>CustomXmlConflictInsertionRangeStart &lt;w14:customXmlConflictInsRangeStart></description></item>
    ///   <item><description>CustomXmlConflictInsertionRangeEnd &lt;w14:customXmlConflictInsRangeEnd></description></item>
    ///   <item><description>CustomXmlConflictDeletionRangeStart &lt;w14:customXmlConflictDelRangeStart></description></item>
    ///   <item><description>CustomXmlConflictDeletionRangeEnd &lt;w14:customXmlConflictDelRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.InsertedRun &lt;w:ins></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.DeletedRun &lt;w:del></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRun &lt;w:moveFrom></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRun &lt;w:moveTo></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.ContentPart &lt;w:contentPart></description></item>
    ///   <item><description>RunConflictInsertion &lt;w14:conflictIns></description></item>
    ///   <item><description>RunConflictDeletion &lt;w14:conflictDel></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Math.Paragraph &lt;m:oMathPara></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Math.OfficeMath &lt;m:oMath></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Math.Accent &lt;m:acc></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Math.Bar &lt;m:bar></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Math.Box &lt;m:box></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Math.BorderBox &lt;m:borderBox></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Math.Delimiter &lt;m:d></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Math.EquationArray &lt;m:eqArr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Math.Fraction &lt;m:f></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Math.MathFunction &lt;m:func></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Math.GroupChar &lt;m:groupChr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Math.LimitLower &lt;m:limLow></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Math.LimitUpper &lt;m:limUpp></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Math.Matrix &lt;m:m></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Math.Nary &lt;m:nary></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Math.Phantom &lt;m:phant></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Math.Radical &lt;m:rad></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Math.PreSubSuper &lt;m:sPre></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Math.Subscript &lt;m:sSub></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Math.SubSuperscript &lt;m:sSubSup></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Math.Superscript &lt;m:sSup></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Math.Run &lt;m:r></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.Run &lt;w:r></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride &lt;w:bdo></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.BidirectionalEmbedding &lt;w:dir></description></item>
    /// </list>
    /// </remark>
    public partial class RunConflictInsertion : RunTrackChangeType
    {
        /// <summary>
        /// Initializes a new instance of the RunConflictInsertion class.
        /// </summary>
        public RunConflictInsertion() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RunConflictInsertion class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RunConflictInsertion(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public RunConflictInsertion(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(52, "conflictIns");
            builder.Availability = FileFormatVersions.Office2010;
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Choice, 0, 0)
                {
                    new CompositeParticle(ParticleType.Group, 1, 1)
                    {
                        new CompositeParticle(ParticleType.Choice, 1, 1)
                        {
                            new CompositeParticle(ParticleType.Group, 0, 0)
                            {
                                new CompositeParticle(ParticleType.Choice, 1, 1)
                                {
                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.SdtRun), 1, 1),
                                    new CompositeParticle(ParticleType.Group, 0, 0)
                                    {
                                        new CompositeParticle(ParticleType.Choice, 1, 1)
                                        {
                                            new CompositeParticle(ParticleType.Group, 0, 0)
                                            {
                                                new CompositeParticle(ParticleType.Choice, 1, 1)
                                                {
                                                    new CompositeParticle(ParticleType.Group, 0, 0)
                                                    {
                                                        new CompositeParticle(ParticleType.Choice, 1, 1)
                                                        {
                                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.ProofError), 0, 1),
                                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.PermStart), 0, 1),
                                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.PermEnd), 0, 1)
                                                        }
                                                    },
                                                    new CompositeParticle(ParticleType.Group, 0, 0)
                                                    {
                                                        new CompositeParticle(ParticleType.Choice, 1, 1)
                                                        {
                                                            new CompositeParticle(ParticleType.Group, 0, 0)
                                                            {
                                                                new CompositeParticle(ParticleType.Choice, 1, 1)
                                                                {
                                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.BookmarkStart), 1, 1),
                                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd), 1, 1),
                                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart), 1, 1),
                                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd), 1, 1)
                                                                }
                                                            },
                                                            new CompositeParticle(ParticleType.Group, 0, 0)
                                                            {
                                                                new CompositeParticle(ParticleType.Choice, 1, 1)
                                                                {
                                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart), 1, 1),
                                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd), 1, 1),
                                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart), 1, 1),
                                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd), 1, 1),
                                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart), 1, 1),
                                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd), 1, 1),
                                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart), 1, 1),
                                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd), 1, 1),
                                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart), 1, 1),
                                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd), 1, 1),
                                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart), 1, 1),
                                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd), 1, 1)
                                                                }
                                                            },
                                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart), 0, 1, version: FileFormatVersions.Office2010),
                                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd), 0, 1, version: FileFormatVersions.Office2010),
                                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart), 0, 1, version: FileFormatVersions.Office2010),
                                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd), 0, 1, version: FileFormatVersions.Office2010)
                                                        }
                                                    },
                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.InsertedRun), 0, 1),
                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.DeletedRun), 0, 1),
                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRun), 1, 1),
                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRun), 1, 1),
                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.ContentPart), 0, 0, version: FileFormatVersions.Office2010),
                                                    new CompositeParticle(ParticleType.Group, 0, 1, version: FileFormatVersions.Office2010)
                                                    {
                                                        new CompositeParticle(ParticleType.Sequence, 1, 1)
                                                        {
                                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion), 0, 1, version: FileFormatVersions.Office2010),
                                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion), 0, 1, version: FileFormatVersions.Office2010)
                                                        }
                                                    }
                                                }
                                            },
                                            new CompositeParticle(ParticleType.Group, 0, 0)
                                            {
                                                new CompositeParticle(ParticleType.Choice, 1, 1)
                                                {
                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Paragraph), 1, 1),
                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Math.OfficeMath), 1, 1),
                                                    new CompositeParticle(ParticleType.Group, 1, 1)
                                                    {
                                                        new CompositeParticle(ParticleType.Choice, 1, 1)
                                                        {
                                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Accent), 1, 1),
                                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Bar), 1, 1),
                                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Box), 1, 1),
                                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Math.BorderBox), 1, 1),
                                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Delimiter), 1, 1),
                                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Math.EquationArray), 1, 1),
                                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Fraction), 1, 1),
                                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Math.MathFunction), 1, 1),
                                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Math.GroupChar), 1, 1),
                                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitLower), 1, 1),
                                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitUpper), 1, 1),
                                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Matrix), 1, 1),
                                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Nary), 1, 1),
                                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Phantom), 1, 1),
                                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Radical), 1, 1),
                                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Math.PreSubSuper), 1, 1),
                                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Subscript), 1, 1),
                                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Math.SubSuperscript), 1, 1),
                                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Superscript), 1, 1),
                                                            new CompositeParticle(ParticleType.Group, 1, 1)
                                                            {
                                                                new CompositeParticle(ParticleType.Choice, 1, 1)
                                                                {
                                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Run), 1, 1)
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            },
                            new CompositeParticle(ParticleType.Group, 1, 1)
                            {
                                new CompositeParticle(ParticleType.Choice, 1, 1)
                                {
                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.Run), 1, 1)
                                }
                            },
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride), 0, 1, version: FileFormatVersions.Office2010),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.BidirectionalEmbedding), 0, 1, version: FileFormatVersions.Office2010)
                        }
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RunConflictInsertion>(deep);
    }

    /// <summary>
    /// <para>Defines the RunConflictDeletion Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w14:conflictDel.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.SdtRun &lt;w:sdt></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.ProofError &lt;w:proofErr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.PermStart &lt;w:permStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.PermEnd &lt;w:permEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.BookmarkStart &lt;w:bookmarkStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd &lt;w:bookmarkEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart &lt;w:commentRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd &lt;w:commentRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart &lt;w:moveFromRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd &lt;w:moveFromRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart &lt;w:moveToRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd &lt;w:moveToRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart &lt;w:customXmlInsRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd &lt;w:customXmlInsRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart &lt;w:customXmlDelRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd &lt;w:customXmlDelRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart &lt;w:customXmlMoveFromRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd &lt;w:customXmlMoveFromRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart &lt;w:customXmlMoveToRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd &lt;w:customXmlMoveToRangeEnd></description></item>
    ///   <item><description>CustomXmlConflictInsertionRangeStart &lt;w14:customXmlConflictInsRangeStart></description></item>
    ///   <item><description>CustomXmlConflictInsertionRangeEnd &lt;w14:customXmlConflictInsRangeEnd></description></item>
    ///   <item><description>CustomXmlConflictDeletionRangeStart &lt;w14:customXmlConflictDelRangeStart></description></item>
    ///   <item><description>CustomXmlConflictDeletionRangeEnd &lt;w14:customXmlConflictDelRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.InsertedRun &lt;w:ins></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.DeletedRun &lt;w:del></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRun &lt;w:moveFrom></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRun &lt;w:moveTo></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.ContentPart &lt;w:contentPart></description></item>
    ///   <item><description>RunConflictInsertion &lt;w14:conflictIns></description></item>
    ///   <item><description>RunConflictDeletion &lt;w14:conflictDel></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Math.Paragraph &lt;m:oMathPara></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Math.OfficeMath &lt;m:oMath></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Math.Accent &lt;m:acc></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Math.Bar &lt;m:bar></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Math.Box &lt;m:box></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Math.BorderBox &lt;m:borderBox></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Math.Delimiter &lt;m:d></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Math.EquationArray &lt;m:eqArr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Math.Fraction &lt;m:f></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Math.MathFunction &lt;m:func></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Math.GroupChar &lt;m:groupChr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Math.LimitLower &lt;m:limLow></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Math.LimitUpper &lt;m:limUpp></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Math.Matrix &lt;m:m></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Math.Nary &lt;m:nary></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Math.Phantom &lt;m:phant></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Math.Radical &lt;m:rad></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Math.PreSubSuper &lt;m:sPre></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Math.Subscript &lt;m:sSub></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Math.SubSuperscript &lt;m:sSubSup></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Math.Superscript &lt;m:sSup></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Math.Run &lt;m:r></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.Run &lt;w:r></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride &lt;w:bdo></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.BidirectionalEmbedding &lt;w:dir></description></item>
    /// </list>
    /// </remark>
    public partial class RunConflictDeletion : RunTrackChangeType
    {
        /// <summary>
        /// Initializes a new instance of the RunConflictDeletion class.
        /// </summary>
        public RunConflictDeletion() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RunConflictDeletion class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RunConflictDeletion(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public RunConflictDeletion(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(52, "conflictDel");
            builder.Availability = FileFormatVersions.Office2010;
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Choice, 0, 0)
                {
                    new CompositeParticle(ParticleType.Group, 1, 1)
                    {
                        new CompositeParticle(ParticleType.Choice, 1, 1)
                        {
                            new CompositeParticle(ParticleType.Group, 0, 0)
                            {
                                new CompositeParticle(ParticleType.Choice, 1, 1)
                                {
                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.SdtRun), 1, 1),
                                    new CompositeParticle(ParticleType.Group, 0, 0)
                                    {
                                        new CompositeParticle(ParticleType.Choice, 1, 1)
                                        {
                                            new CompositeParticle(ParticleType.Group, 0, 0)
                                            {
                                                new CompositeParticle(ParticleType.Choice, 1, 1)
                                                {
                                                    new CompositeParticle(ParticleType.Group, 0, 0)
                                                    {
                                                        new CompositeParticle(ParticleType.Choice, 1, 1)
                                                        {
                                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.ProofError), 0, 1),
                                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.PermStart), 0, 1),
                                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.PermEnd), 0, 1)
                                                        }
                                                    },
                                                    new CompositeParticle(ParticleType.Group, 0, 0)
                                                    {
                                                        new CompositeParticle(ParticleType.Choice, 1, 1)
                                                        {
                                                            new CompositeParticle(ParticleType.Group, 0, 0)
                                                            {
                                                                new CompositeParticle(ParticleType.Choice, 1, 1)
                                                                {
                                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.BookmarkStart), 1, 1),
                                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd), 1, 1),
                                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart), 1, 1),
                                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd), 1, 1)
                                                                }
                                                            },
                                                            new CompositeParticle(ParticleType.Group, 0, 0)
                                                            {
                                                                new CompositeParticle(ParticleType.Choice, 1, 1)
                                                                {
                                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart), 1, 1),
                                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd), 1, 1),
                                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart), 1, 1),
                                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd), 1, 1),
                                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart), 1, 1),
                                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd), 1, 1),
                                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart), 1, 1),
                                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd), 1, 1),
                                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart), 1, 1),
                                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd), 1, 1),
                                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart), 1, 1),
                                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd), 1, 1)
                                                                }
                                                            },
                                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart), 0, 1, version: FileFormatVersions.Office2010),
                                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd), 0, 1, version: FileFormatVersions.Office2010),
                                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart), 0, 1, version: FileFormatVersions.Office2010),
                                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd), 0, 1, version: FileFormatVersions.Office2010)
                                                        }
                                                    },
                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.InsertedRun), 0, 1),
                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.DeletedRun), 0, 1),
                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRun), 1, 1),
                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRun), 1, 1),
                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.ContentPart), 0, 0, version: FileFormatVersions.Office2010),
                                                    new CompositeParticle(ParticleType.Group, 0, 1, version: FileFormatVersions.Office2010)
                                                    {
                                                        new CompositeParticle(ParticleType.Sequence, 1, 1)
                                                        {
                                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion), 0, 1, version: FileFormatVersions.Office2010),
                                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion), 0, 1, version: FileFormatVersions.Office2010)
                                                        }
                                                    }
                                                }
                                            },
                                            new CompositeParticle(ParticleType.Group, 0, 0)
                                            {
                                                new CompositeParticle(ParticleType.Choice, 1, 1)
                                                {
                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Paragraph), 1, 1),
                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Math.OfficeMath), 1, 1),
                                                    new CompositeParticle(ParticleType.Group, 1, 1)
                                                    {
                                                        new CompositeParticle(ParticleType.Choice, 1, 1)
                                                        {
                                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Accent), 1, 1),
                                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Bar), 1, 1),
                                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Box), 1, 1),
                                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Math.BorderBox), 1, 1),
                                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Delimiter), 1, 1),
                                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Math.EquationArray), 1, 1),
                                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Fraction), 1, 1),
                                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Math.MathFunction), 1, 1),
                                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Math.GroupChar), 1, 1),
                                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitLower), 1, 1),
                                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitUpper), 1, 1),
                                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Matrix), 1, 1),
                                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Nary), 1, 1),
                                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Phantom), 1, 1),
                                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Radical), 1, 1),
                                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Math.PreSubSuper), 1, 1),
                                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Subscript), 1, 1),
                                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Math.SubSuperscript), 1, 1),
                                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Superscript), 1, 1),
                                                            new CompositeParticle(ParticleType.Group, 1, 1)
                                                            {
                                                                new CompositeParticle(ParticleType.Choice, 1, 1)
                                                                {
                                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Run), 1, 1)
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            },
                            new CompositeParticle(ParticleType.Group, 1, 1)
                            {
                                new CompositeParticle(ParticleType.Choice, 1, 1)
                                {
                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.Run), 1, 1)
                                }
                            },
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride), 0, 1, version: FileFormatVersions.Office2010),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.BidirectionalEmbedding), 0, 1, version: FileFormatVersions.Office2010)
                        }
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RunConflictDeletion>(deep);
    }

    /// <summary>
    /// <para>Defines the RunTrackChangeType Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.SdtRun &lt;w:sdt></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.ProofError &lt;w:proofErr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.PermStart &lt;w:permStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.PermEnd &lt;w:permEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.BookmarkStart &lt;w:bookmarkStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd &lt;w:bookmarkEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart &lt;w:commentRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd &lt;w:commentRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart &lt;w:moveFromRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd &lt;w:moveFromRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart &lt;w:moveToRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd &lt;w:moveToRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart &lt;w:customXmlInsRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd &lt;w:customXmlInsRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart &lt;w:customXmlDelRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd &lt;w:customXmlDelRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart &lt;w:customXmlMoveFromRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd &lt;w:customXmlMoveFromRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart &lt;w:customXmlMoveToRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd &lt;w:customXmlMoveToRangeEnd></description></item>
    ///   <item><description>CustomXmlConflictInsertionRangeStart &lt;w14:customXmlConflictInsRangeStart></description></item>
    ///   <item><description>CustomXmlConflictInsertionRangeEnd &lt;w14:customXmlConflictInsRangeEnd></description></item>
    ///   <item><description>CustomXmlConflictDeletionRangeStart &lt;w14:customXmlConflictDelRangeStart></description></item>
    ///   <item><description>CustomXmlConflictDeletionRangeEnd &lt;w14:customXmlConflictDelRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.InsertedRun &lt;w:ins></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.DeletedRun &lt;w:del></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRun &lt;w:moveFrom></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRun &lt;w:moveTo></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.ContentPart &lt;w:contentPart></description></item>
    ///   <item><description>RunConflictInsertion &lt;w14:conflictIns></description></item>
    ///   <item><description>RunConflictDeletion &lt;w14:conflictDel></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Math.Paragraph &lt;m:oMathPara></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Math.OfficeMath &lt;m:oMath></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Math.Accent &lt;m:acc></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Math.Bar &lt;m:bar></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Math.Box &lt;m:box></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Math.BorderBox &lt;m:borderBox></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Math.Delimiter &lt;m:d></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Math.EquationArray &lt;m:eqArr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Math.Fraction &lt;m:f></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Math.MathFunction &lt;m:func></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Math.GroupChar &lt;m:groupChr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Math.LimitLower &lt;m:limLow></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Math.LimitUpper &lt;m:limUpp></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Math.Matrix &lt;m:m></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Math.Nary &lt;m:nary></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Math.Phantom &lt;m:phant></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Math.Radical &lt;m:rad></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Math.PreSubSuper &lt;m:sPre></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Math.Subscript &lt;m:sSub></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Math.SubSuperscript &lt;m:sSubSup></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Math.Superscript &lt;m:sSup></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Math.Run &lt;m:r></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.Run &lt;w:r></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride &lt;w:bdo></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.BidirectionalEmbedding &lt;w:dir></description></item>
    /// </list>
    /// </remark>
    public abstract partial class RunTrackChangeType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RunTrackChangeType class.
        /// </summary>
        protected RunTrackChangeType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RunTrackChangeType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected RunTrackChangeType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        protected RunTrackChangeType(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>author</para>
        /// <para>Represents the following attribute in the schema: w:author</para>
        /// </summary>
        /// <remark>
        /// xmlns:w=http://schemas.openxmlformats.org/wordprocessingml/2006/main
        /// </remark>
        public StringValue Author
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>date</para>
        /// <para>Represents the following attribute in the schema: w:date</para>
        /// </summary>
        /// <remark>
        /// xmlns:w=http://schemas.openxmlformats.org/wordprocessingml/2006/main
        /// </remark>
        public DateTimeValue Date
        {
            get => GetAttribute<DateTimeValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Annotation Identifier</para>
        /// <para>Represents the following attribute in the schema: w:id</para>
        /// </summary>
        /// <remark>
        /// xmlns:w=http://schemas.openxmlformats.org/wordprocessingml/2006/main
        /// </remark>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.SdtRun>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.ProofError>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.PermStart>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.PermEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.BookmarkStart>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd>();
            builder.AddChild<CustomXmlConflictInsertionRangeStart>();
            builder.AddChild<CustomXmlConflictInsertionRangeEnd>();
            builder.AddChild<CustomXmlConflictDeletionRangeStart>();
            builder.AddChild<CustomXmlConflictDeletionRangeEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.InsertedRun>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.DeletedRun>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.MoveFromRun>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.MoveToRun>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.ContentPart>();
            builder.AddChild<RunConflictInsertion>();
            builder.AddChild<RunConflictDeletion>();
            builder.AddChild<DocumentFormat.OpenXml.Math.Paragraph>();
            builder.AddChild<DocumentFormat.OpenXml.Math.OfficeMath>();
            builder.AddChild<DocumentFormat.OpenXml.Math.Accent>();
            builder.AddChild<DocumentFormat.OpenXml.Math.Bar>();
            builder.AddChild<DocumentFormat.OpenXml.Math.Box>();
            builder.AddChild<DocumentFormat.OpenXml.Math.BorderBox>();
            builder.AddChild<DocumentFormat.OpenXml.Math.Delimiter>();
            builder.AddChild<DocumentFormat.OpenXml.Math.EquationArray>();
            builder.AddChild<DocumentFormat.OpenXml.Math.Fraction>();
            builder.AddChild<DocumentFormat.OpenXml.Math.MathFunction>();
            builder.AddChild<DocumentFormat.OpenXml.Math.GroupChar>();
            builder.AddChild<DocumentFormat.OpenXml.Math.LimitLower>();
            builder.AddChild<DocumentFormat.OpenXml.Math.LimitUpper>();
            builder.AddChild<DocumentFormat.OpenXml.Math.Matrix>();
            builder.AddChild<DocumentFormat.OpenXml.Math.Nary>();
            builder.AddChild<DocumentFormat.OpenXml.Math.Phantom>();
            builder.AddChild<DocumentFormat.OpenXml.Math.Radical>();
            builder.AddChild<DocumentFormat.OpenXml.Math.PreSubSuper>();
            builder.AddChild<DocumentFormat.OpenXml.Math.Subscript>();
            builder.AddChild<DocumentFormat.OpenXml.Math.SubSuperscript>();
            builder.AddChild<DocumentFormat.OpenXml.Math.Superscript>();
            builder.AddChild<DocumentFormat.OpenXml.Math.Run>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.Run>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.BidirectionalEmbedding>();
            builder.AddElement<RunTrackChangeType>()
.AddAttribute(23, "author", a => a.Author, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { MaxLength = (255L) });
})
.AddAttribute(23, "date", a => a.Date)
.AddAttribute(23, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddUnion(union =>
{
union.AddValidator<Int32Value>(new NumberValidator() { MinInclusive = (0L) });
union.AddValidator<Int32Value>(new NumberValidator() { MaxInclusive = (-2L) });
});
});
        }
    }

    /// <summary>
    /// <para>Defines the ConflictInsertion Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w14:conflictIns.</para>
    /// </summary>
    public partial class ConflictInsertion : TrackChangeType
    {
        /// <summary>
        /// Initializes a new instance of the ConflictInsertion class.
        /// </summary>
        public ConflictInsertion() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(52, "conflictIns");
            builder.Availability = FileFormatVersions.Office2010;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ConflictInsertion>(deep);
    }

    /// <summary>
    /// <para>Defines the ConflictDeletion Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w14:conflictDel.</para>
    /// </summary>
    public partial class ConflictDeletion : TrackChangeType
    {
        /// <summary>
        /// Initializes a new instance of the ConflictDeletion class.
        /// </summary>
        public ConflictDeletion() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(52, "conflictDel");
            builder.Availability = FileFormatVersions.Office2010;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ConflictDeletion>(deep);
    }

    /// <summary>
    /// <para>Defines the CustomXmlConflictInsertionRangeStart Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w14:customXmlConflictInsRangeStart.</para>
    /// </summary>
    public partial class CustomXmlConflictInsertionRangeStart : TrackChangeType
    {
        /// <summary>
        /// Initializes a new instance of the CustomXmlConflictInsertionRangeStart class.
        /// </summary>
        public CustomXmlConflictInsertionRangeStart() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(52, "customXmlConflictInsRangeStart");
            builder.Availability = FileFormatVersions.Office2010;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CustomXmlConflictInsertionRangeStart>(deep);
    }

    /// <summary>
    /// <para>Defines the CustomXmlConflictDeletionRangeStart Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w14:customXmlConflictDelRangeStart.</para>
    /// </summary>
    public partial class CustomXmlConflictDeletionRangeStart : TrackChangeType
    {
        /// <summary>
        /// Initializes a new instance of the CustomXmlConflictDeletionRangeStart class.
        /// </summary>
        public CustomXmlConflictDeletionRangeStart() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(52, "customXmlConflictDelRangeStart");
            builder.Availability = FileFormatVersions.Office2010;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CustomXmlConflictDeletionRangeStart>(deep);
    }

    /// <summary>
    /// <para>Defines the TrackChangeType Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class TrackChangeType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the TrackChangeType class.
        /// </summary>
        protected TrackChangeType() : base()
        {
        }

        /// <summary>
        /// <para>author</para>
        /// <para>Represents the following attribute in the schema: w:author</para>
        /// </summary>
        /// <remark>
        /// xmlns:w=http://schemas.openxmlformats.org/wordprocessingml/2006/main
        /// </remark>
        public StringValue Author
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>date</para>
        /// <para>Represents the following attribute in the schema: w:date</para>
        /// </summary>
        /// <remark>
        /// xmlns:w=http://schemas.openxmlformats.org/wordprocessingml/2006/main
        /// </remark>
        public DateTimeValue Date
        {
            get => GetAttribute<DateTimeValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Annotation Identifier</para>
        /// <para>Represents the following attribute in the schema: w:id</para>
        /// </summary>
        /// <remark>
        /// xmlns:w=http://schemas.openxmlformats.org/wordprocessingml/2006/main
        /// </remark>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<TrackChangeType>()
                           .AddAttribute(23, "author", a => a.Author, aBuilder =>
                           {
                               aBuilder.AddValidator(RequiredValidator.Instance);
                               aBuilder.AddValidator(new StringValidator() { MaxLength = (255L) });
                           })
                           .AddAttribute(23, "date", a => a.Date)
                           .AddAttribute(23, "id", a => a.Id, aBuilder =>
                           {
                               aBuilder.AddValidator(RequiredValidator.Instance);
                               aBuilder.AddUnion(union =>
                               {
                                   union.AddValidator<Int32Value>(new NumberValidator() { MinInclusive = (0L) });
                                   union.AddValidator<Int32Value>(new NumberValidator() { MaxInclusive = (-2L) });
                               });
                           });
        }
    }

    /// <summary>
    /// <para>Defines the Tint Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w14:tint.</para>
    /// </summary>
    public partial class Tint : PositiveFixedPercentageType
    {
        /// <summary>
        /// Initializes a new instance of the Tint class.
        /// </summary>
        public Tint() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(52, "tint");
            builder.Availability = FileFormatVersions.Office2010;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Tint>(deep);
    }

    /// <summary>
    /// <para>Defines the Shade Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w14:shade.</para>
    /// </summary>
    public partial class Shade : PositiveFixedPercentageType
    {
        /// <summary>
        /// Initializes a new instance of the Shade class.
        /// </summary>
        public Shade() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(52, "shade");
            builder.Availability = FileFormatVersions.Office2010;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Shade>(deep);
    }

    /// <summary>
    /// <para>Defines the Alpha Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w14:alpha.</para>
    /// </summary>
    public partial class Alpha : PositiveFixedPercentageType
    {
        /// <summary>
        /// Initializes a new instance of the Alpha class.
        /// </summary>
        public Alpha() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(52, "alpha");
            builder.Availability = FileFormatVersions.Office2010;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Alpha>(deep);
    }

    /// <summary>
    /// <para>Defines the PositiveFixedPercentageType Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class PositiveFixedPercentageType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the PositiveFixedPercentageType class.
        /// </summary>
        protected PositiveFixedPercentageType() : base()
        {
        }

        /// <summary>
        /// <para>val, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w14:val</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public Int32Value Val
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<PositiveFixedPercentageType>()
                           .AddAttribute(52, "val", a => a.Val, aBuilder =>
                           {
                               aBuilder.AddValidator(RequiredValidator.Instance);
                               aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2010));
                               aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
                           });
        }
    }

    /// <summary>
    /// <para>Defines the HueModulation Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w14:hueMod.</para>
    /// </summary>
    public partial class HueModulation : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the HueModulation class.
        /// </summary>
        public HueModulation() : base()
        {
        }

        /// <summary>
        /// <para>val, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w14:val</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public Int32Value Val
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(52, "hueMod");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<HueModulation>()
.AddAttribute(52, "val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2010));
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HueModulation>(deep);
    }

    /// <summary>
    /// <para>Defines the Saturation Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w14:sat.</para>
    /// </summary>
    public partial class Saturation : PercentageType
    {
        /// <summary>
        /// Initializes a new instance of the Saturation class.
        /// </summary>
        public Saturation() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(52, "sat");
            builder.Availability = FileFormatVersions.Office2010;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Saturation>(deep);
    }

    /// <summary>
    /// <para>Defines the SaturationOffset Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w14:satOff.</para>
    /// </summary>
    public partial class SaturationOffset : PercentageType
    {
        /// <summary>
        /// Initializes a new instance of the SaturationOffset class.
        /// </summary>
        public SaturationOffset() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(52, "satOff");
            builder.Availability = FileFormatVersions.Office2010;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SaturationOffset>(deep);
    }

    /// <summary>
    /// <para>Defines the SaturationModulation Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w14:satMod.</para>
    /// </summary>
    public partial class SaturationModulation : PercentageType
    {
        /// <summary>
        /// Initializes a new instance of the SaturationModulation class.
        /// </summary>
        public SaturationModulation() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(52, "satMod");
            builder.Availability = FileFormatVersions.Office2010;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SaturationModulation>(deep);
    }

    /// <summary>
    /// <para>Defines the Luminance Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w14:lum.</para>
    /// </summary>
    public partial class Luminance : PercentageType
    {
        /// <summary>
        /// Initializes a new instance of the Luminance class.
        /// </summary>
        public Luminance() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(52, "lum");
            builder.Availability = FileFormatVersions.Office2010;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Luminance>(deep);
    }

    /// <summary>
    /// <para>Defines the LuminanceOffset Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w14:lumOff.</para>
    /// </summary>
    public partial class LuminanceOffset : PercentageType
    {
        /// <summary>
        /// Initializes a new instance of the LuminanceOffset class.
        /// </summary>
        public LuminanceOffset() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(52, "lumOff");
            builder.Availability = FileFormatVersions.Office2010;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LuminanceOffset>(deep);
    }

    /// <summary>
    /// <para>Defines the LuminanceModulation Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w14:lumMod.</para>
    /// </summary>
    public partial class LuminanceModulation : PercentageType
    {
        /// <summary>
        /// Initializes a new instance of the LuminanceModulation class.
        /// </summary>
        public LuminanceModulation() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(52, "lumMod");
            builder.Availability = FileFormatVersions.Office2010;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LuminanceModulation>(deep);
    }

    /// <summary>
    /// <para>Defines the PercentageType Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class PercentageType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the PercentageType class.
        /// </summary>
        protected PercentageType() : base()
        {
        }

        /// <summary>
        /// <para>val, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w14:val</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public Int32Value Val
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<PercentageType>()
                           .AddAttribute(52, "val", a => a.Val, aBuilder =>
                           {
                               aBuilder.AddValidator(RequiredValidator.Instance);
                               aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2010));
                           });
        }
    }

    /// <summary>
    /// <para>Defines the RgbColorModelHex Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w14:srgbClr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Tint &lt;w14:tint></description></item>
    ///   <item><description>Shade &lt;w14:shade></description></item>
    ///   <item><description>Alpha &lt;w14:alpha></description></item>
    ///   <item><description>HueModulation &lt;w14:hueMod></description></item>
    ///   <item><description>Saturation &lt;w14:sat></description></item>
    ///   <item><description>SaturationOffset &lt;w14:satOff></description></item>
    ///   <item><description>SaturationModulation &lt;w14:satMod></description></item>
    ///   <item><description>Luminance &lt;w14:lum></description></item>
    ///   <item><description>LuminanceOffset &lt;w14:lumOff></description></item>
    ///   <item><description>LuminanceModulation &lt;w14:lumMod></description></item>
    /// </list>
    /// </remark>
    public partial class RgbColorModelHex : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RgbColorModelHex class.
        /// </summary>
        public RgbColorModelHex() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RgbColorModelHex class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RgbColorModelHex(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public RgbColorModelHex(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>val, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w14:val</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public HexBinaryValue Val
        {
            get => GetAttribute<HexBinaryValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(52, "srgbClr");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<Tint>();
            builder.AddChild<Shade>();
            builder.AddChild<Alpha>();
            builder.AddChild<HueModulation>();
            builder.AddChild<Saturation>();
            builder.AddChild<SaturationOffset>();
            builder.AddChild<SaturationModulation>();
            builder.AddChild<Luminance>();
            builder.AddChild<LuminanceOffset>();
            builder.AddChild<LuminanceModulation>();
            builder.AddElement<RgbColorModelHex>()
.AddAttribute(52, "val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2010));
aBuilder.AddValidator(new StringValidator() { Length = (3L) });
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Group, 0, 0, version: FileFormatVersions.Office2010)
                {
                    new CompositeParticle(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.Tint), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.Shade), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.Alpha), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.HueModulation), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.Saturation), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.SaturationOffset), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.SaturationModulation), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.Luminance), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.LuminanceOffset), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.LuminanceModulation), 1, 1, version: FileFormatVersions.Office2010)
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RgbColorModelHex>(deep);
    }

    /// <summary>
    /// <para>Defines the SchemeColor Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w14:schemeClr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Tint &lt;w14:tint></description></item>
    ///   <item><description>Shade &lt;w14:shade></description></item>
    ///   <item><description>Alpha &lt;w14:alpha></description></item>
    ///   <item><description>HueModulation &lt;w14:hueMod></description></item>
    ///   <item><description>Saturation &lt;w14:sat></description></item>
    ///   <item><description>SaturationOffset &lt;w14:satOff></description></item>
    ///   <item><description>SaturationModulation &lt;w14:satMod></description></item>
    ///   <item><description>Luminance &lt;w14:lum></description></item>
    ///   <item><description>LuminanceOffset &lt;w14:lumOff></description></item>
    ///   <item><description>LuminanceModulation &lt;w14:lumMod></description></item>
    /// </list>
    /// </remark>
    public partial class SchemeColor : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SchemeColor class.
        /// </summary>
        public SchemeColor() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SchemeColor class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SchemeColor(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public SchemeColor(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>val, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w14:val</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Office2010.Word.SchemeColorValues> Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.Word.SchemeColorValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(52, "schemeClr");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<Tint>();
            builder.AddChild<Shade>();
            builder.AddChild<Alpha>();
            builder.AddChild<HueModulation>();
            builder.AddChild<Saturation>();
            builder.AddChild<SaturationOffset>();
            builder.AddChild<SaturationModulation>();
            builder.AddChild<Luminance>();
            builder.AddChild<LuminanceOffset>();
            builder.AddChild<LuminanceModulation>();
            builder.AddElement<SchemeColor>()
.AddAttribute(52, "val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2010));
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Group, 0, 0, version: FileFormatVersions.Office2010)
                {
                    new CompositeParticle(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.Tint), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.Shade), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.Alpha), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.HueModulation), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.Saturation), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.SaturationOffset), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.SaturationModulation), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.Luminance), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.LuminanceOffset), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.LuminanceModulation), 1, 1, version: FileFormatVersions.Office2010)
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SchemeColor>(deep);
    }

    /// <summary>
    /// <para>Defines the LinearShadeProperties Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w14:lin.</para>
    /// </summary>
    public partial class LinearShadeProperties : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the LinearShadeProperties class.
        /// </summary>
        public LinearShadeProperties() : base()
        {
        }

        /// <summary>
        /// <para>ang, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w14:ang</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public Int32Value Angle
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>scaled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w14:scaled</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Office2010.Word.OnOffValues> Scaled
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.Word.OnOffValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(52, "lin");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<LinearShadeProperties>()
.AddAttribute(52, "ang", a => a.Angle, aBuilder =>
{
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2010));
aBuilder.AddValidator(new NumberValidator() { MaxExclusive = (21600000L), MinInclusive = (0L) });
})
.AddAttribute(52, "scaled", a => a.Scaled, aBuilder =>
{
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2010));
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LinearShadeProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the PathShadeProperties Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w14:path.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>FillToRectangle &lt;w14:fillToRect></description></item>
    /// </list>
    /// </remark>
    public partial class PathShadeProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PathShadeProperties class.
        /// </summary>
        public PathShadeProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PathShadeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PathShadeProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public PathShadeProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>path, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w14:path</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Office2010.Word.PathShadeTypeValues> Path
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.Word.PathShadeTypeValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(52, "path");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<FillToRectangle>();
            builder.AddElement<PathShadeProperties>()
.AddAttribute(52, "path", a => a.Path, aBuilder =>
{
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2010));
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.FillToRectangle), 0, 1, version: FileFormatVersions.Office2010)
            };
        }

        /// <summary>
        /// <para>FillToRectangle.</para>
        /// <para>Represents the following element tag in the schema: w14:fillToRect.</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14 = http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public FillToRectangle FillToRectangle
        {
            get => GetElement<FillToRectangle>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PathShadeProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the NoFillEmpty Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w14:noFill.</para>
    /// </summary>
    public partial class NoFillEmpty : EmptyType
    {
        /// <summary>
        /// Initializes a new instance of the NoFillEmpty class.
        /// </summary>
        public NoFillEmpty() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(52, "noFill");
            builder.Availability = FileFormatVersions.Office2010;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NoFillEmpty>(deep);
    }

    /// <summary>
    /// <para>Defines the RoundEmpty Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w14:round.</para>
    /// </summary>
    public partial class RoundEmpty : EmptyType
    {
        /// <summary>
        /// Initializes a new instance of the RoundEmpty class.
        /// </summary>
        public RoundEmpty() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(52, "round");
            builder.Availability = FileFormatVersions.Office2010;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RoundEmpty>(deep);
    }

    /// <summary>
    /// <para>Defines the BevelEmpty Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w14:bevel.</para>
    /// </summary>
    public partial class BevelEmpty : EmptyType
    {
        /// <summary>
        /// Initializes a new instance of the BevelEmpty class.
        /// </summary>
        public BevelEmpty() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(52, "bevel");
            builder.Availability = FileFormatVersions.Office2010;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BevelEmpty>(deep);
    }

    /// <summary>
    /// <para>Defines the EntityPickerEmpty Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w14:entityPicker.</para>
    /// </summary>
    public partial class EntityPickerEmpty : EmptyType
    {
        /// <summary>
        /// Initializes a new instance of the EntityPickerEmpty class.
        /// </summary>
        public EntityPickerEmpty() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(52, "entityPicker");
            builder.Availability = FileFormatVersions.Office2010;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EntityPickerEmpty>(deep);
    }

    /// <summary>
    /// <para>Defines the EmptyType Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class EmptyType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the EmptyType class.
        /// </summary>
        protected EmptyType() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
        }
    }

    /// <summary>
    /// <para>Defines the SolidColorFillProperties Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w14:solidFill.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>RgbColorModelHex &lt;w14:srgbClr></description></item>
    ///   <item><description>SchemeColor &lt;w14:schemeClr></description></item>
    /// </list>
    /// </remark>
    public partial class SolidColorFillProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SolidColorFillProperties class.
        /// </summary>
        public SolidColorFillProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SolidColorFillProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SolidColorFillProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public SolidColorFillProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(52, "solidFill");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<RgbColorModelHex>();
            builder.AddChild<SchemeColor>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Group, 0, 1, version: FileFormatVersions.Office2010)
                {
                    new CompositeParticle(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.RgbColorModelHex), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.SchemeColor), 1, 1, version: FileFormatVersions.Office2010)
                    }
                }
            };
        }

        /// <summary>
        /// <para>RgbColorModelHex.</para>
        /// <para>Represents the following element tag in the schema: w14:srgbClr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14 = http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public RgbColorModelHex RgbColorModelHex
        {
            get => GetElement<RgbColorModelHex>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>SchemeColor.</para>
        /// <para>Represents the following element tag in the schema: w14:schemeClr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14 = http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public SchemeColor SchemeColor
        {
            get => GetElement<SchemeColor>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SolidColorFillProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the GradientFillProperties Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w14:gradFill.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>GradientStopList &lt;w14:gsLst></description></item>
    ///   <item><description>LinearShadeProperties &lt;w14:lin></description></item>
    ///   <item><description>PathShadeProperties &lt;w14:path></description></item>
    /// </list>
    /// </remark>
    public partial class GradientFillProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the GradientFillProperties class.
        /// </summary>
        public GradientFillProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the GradientFillProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GradientFillProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public GradientFillProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(52, "gradFill");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<GradientStopList>();
            builder.AddChild<LinearShadeProperties>();
            builder.AddChild<PathShadeProperties>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.GradientStopList), 0, 1, version: FileFormatVersions.Office2010),
                new CompositeParticle(ParticleType.Group, 0, 1, version: FileFormatVersions.Office2010)
                {
                    new CompositeParticle(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.LinearShadeProperties), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.PathShadeProperties), 1, 1, version: FileFormatVersions.Office2010)
                    }
                }
            };
        }

        /// <summary>
        /// <para>GradientStopList.</para>
        /// <para>Represents the following element tag in the schema: w14:gsLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14 = http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public GradientStopList GradientStopList
        {
            get => GetElement<GradientStopList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<GradientFillProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the PresetLineDashProperties Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w14:prstDash.</para>
    /// </summary>
    public partial class PresetLineDashProperties : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the PresetLineDashProperties class.
        /// </summary>
        public PresetLineDashProperties() : base()
        {
        }

        /// <summary>
        /// <para>val, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w14:val</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Office2010.Word.PresetLineDashValues> Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.Word.PresetLineDashValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(52, "prstDash");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<PresetLineDashProperties>()
.AddAttribute(52, "val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2010));
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PresetLineDashProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the LineJoinMiterProperties Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w14:miter.</para>
    /// </summary>
    public partial class LineJoinMiterProperties : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the LineJoinMiterProperties class.
        /// </summary>
        public LineJoinMiterProperties() : base()
        {
        }

        /// <summary>
        /// <para>lim, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w14:lim</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public Int32Value Limit
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(52, "miter");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<LineJoinMiterProperties>()
.AddAttribute(52, "lim", a => a.Limit, aBuilder =>
{
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2010));
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LineJoinMiterProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the Glow Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w14:glow.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>RgbColorModelHex &lt;w14:srgbClr></description></item>
    ///   <item><description>SchemeColor &lt;w14:schemeClr></description></item>
    /// </list>
    /// </remark>
    public partial class Glow : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Glow class.
        /// </summary>
        public Glow() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Glow class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Glow(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public Glow(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>rad, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w14:rad</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public Int64Value GlowRadius
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(52, "glow");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<RgbColorModelHex>();
            builder.AddChild<SchemeColor>();
            builder.AddElement<Glow>()
.AddAttribute(52, "rad", a => a.GlowRadius, aBuilder =>
{
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2010));
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (2147483647L) });
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Group, 1, 1, version: FileFormatVersions.Office2010)
                {
                    new CompositeParticle(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.RgbColorModelHex), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.SchemeColor), 1, 1, version: FileFormatVersions.Office2010)
                    }
                }
            };
        }

        /// <summary>
        /// <para>RgbColorModelHex.</para>
        /// <para>Represents the following element tag in the schema: w14:srgbClr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14 = http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public RgbColorModelHex RgbColorModelHex
        {
            get => GetElement<RgbColorModelHex>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>SchemeColor.</para>
        /// <para>Represents the following element tag in the schema: w14:schemeClr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14 = http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public SchemeColor SchemeColor
        {
            get => GetElement<SchemeColor>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Glow>(deep);
    }

    /// <summary>
    /// <para>Defines the Shadow Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w14:shadow.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>RgbColorModelHex &lt;w14:srgbClr></description></item>
    ///   <item><description>SchemeColor &lt;w14:schemeClr></description></item>
    /// </list>
    /// </remark>
    public partial class Shadow : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Shadow class.
        /// </summary>
        public Shadow() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Shadow class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Shadow(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public Shadow(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>blurRad, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w14:blurRad</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public Int64Value BlurRadius
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>dist, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w14:dist</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public Int64Value DistanceFromText
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>dir, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w14:dir</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public Int32Value DirectionAngle
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sx, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w14:sx</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public Int32Value HorizontalScalingFactor
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sy, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w14:sy</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public Int32Value VerticalScalingFactor
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>kx, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w14:kx</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public Int32Value HorizontalSkewAngle
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>ky, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w14:ky</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public Int32Value VerticalSkewAngle
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>algn, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w14:algn</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Office2010.Word.RectangleAlignmentValues> Alignment
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.Word.RectangleAlignmentValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(52, "shadow");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<RgbColorModelHex>();
            builder.AddChild<SchemeColor>();
            builder.AddElement<Shadow>()
.AddAttribute(52, "blurRad", a => a.BlurRadius, aBuilder =>
{
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2010));
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (2147483647L) });
})
.AddAttribute(52, "dist", a => a.DistanceFromText, aBuilder =>
{
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2010));
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (2147483647L) });
})
.AddAttribute(52, "dir", a => a.DirectionAngle, aBuilder =>
{
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2010));
aBuilder.AddValidator(new NumberValidator() { MaxExclusive = (21600000L), MinInclusive = (0L) });
})
.AddAttribute(52, "sx", a => a.HorizontalScalingFactor, aBuilder =>
{
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2010));
})
.AddAttribute(52, "sy", a => a.VerticalScalingFactor, aBuilder =>
{
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2010));
})
.AddAttribute(52, "kx", a => a.HorizontalSkewAngle, aBuilder =>
{
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2010));
aBuilder.AddValidator(new NumberValidator() { MinExclusive = (-5400000L), MaxExclusive = (5400000L) });
})
.AddAttribute(52, "ky", a => a.VerticalSkewAngle, aBuilder =>
{
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2010));
aBuilder.AddValidator(new NumberValidator() { MinExclusive = (-5400000L), MaxExclusive = (5400000L) });
})
.AddAttribute(52, "algn", a => a.Alignment, aBuilder =>
{
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2010));
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Group, 1, 1, version: FileFormatVersions.Office2010)
                {
                    new CompositeParticle(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.RgbColorModelHex), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.SchemeColor), 1, 1, version: FileFormatVersions.Office2010)
                    }
                }
            };
        }

        /// <summary>
        /// <para>RgbColorModelHex.</para>
        /// <para>Represents the following element tag in the schema: w14:srgbClr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14 = http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public RgbColorModelHex RgbColorModelHex
        {
            get => GetElement<RgbColorModelHex>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>SchemeColor.</para>
        /// <para>Represents the following element tag in the schema: w14:schemeClr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14 = http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public SchemeColor SchemeColor
        {
            get => GetElement<SchemeColor>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Shadow>(deep);
    }

    /// <summary>
    /// <para>Defines the Reflection Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w14:reflection.</para>
    /// </summary>
    public partial class Reflection : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Reflection class.
        /// </summary>
        public Reflection() : base()
        {
        }

        /// <summary>
        /// <para>blurRad, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w14:blurRad</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public Int64Value BlurRadius
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>stA, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w14:stA</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public Int32Value StartingOpacity
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>stPos, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w14:stPos</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public Int32Value StartPosition
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>endA, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w14:endA</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public Int32Value EndingOpacity
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>endPos, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w14:endPos</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public Int32Value EndPosition
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>dist, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w14:dist</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public Int64Value DistanceFromText
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>dir, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w14:dir</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public Int32Value DirectionAngle
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>fadeDir, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w14:fadeDir</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public Int32Value FadeDirection
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sx, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w14:sx</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public Int32Value HorizontalScalingFactor
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sy, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w14:sy</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public Int32Value VerticalScalingFactor
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>kx, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w14:kx</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public Int32Value HorizontalSkewAngle
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>ky, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w14:ky</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public Int32Value VerticalSkewAngle
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>algn, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w14:algn</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Office2010.Word.RectangleAlignmentValues> Alignment
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.Word.RectangleAlignmentValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(52, "reflection");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<Reflection>()
.AddAttribute(52, "blurRad", a => a.BlurRadius, aBuilder =>
{
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2010));
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (2147483647L) });
})
.AddAttribute(52, "stA", a => a.StartingOpacity, aBuilder =>
{
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2010));
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
})
.AddAttribute(52, "stPos", a => a.StartPosition, aBuilder =>
{
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2010));
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
})
.AddAttribute(52, "endA", a => a.EndingOpacity, aBuilder =>
{
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2010));
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
})
.AddAttribute(52, "endPos", a => a.EndPosition, aBuilder =>
{
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2010));
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
})
.AddAttribute(52, "dist", a => a.DistanceFromText, aBuilder =>
{
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2010));
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (2147483647L) });
})
.AddAttribute(52, "dir", a => a.DirectionAngle, aBuilder =>
{
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2010));
aBuilder.AddValidator(new NumberValidator() { MaxExclusive = (21600000L), MinInclusive = (0L) });
})
.AddAttribute(52, "fadeDir", a => a.FadeDirection, aBuilder =>
{
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2010));
aBuilder.AddValidator(new NumberValidator() { MaxExclusive = (21600000L), MinInclusive = (0L) });
})
.AddAttribute(52, "sx", a => a.HorizontalScalingFactor, aBuilder =>
{
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2010));
})
.AddAttribute(52, "sy", a => a.VerticalScalingFactor, aBuilder =>
{
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2010));
})
.AddAttribute(52, "kx", a => a.HorizontalSkewAngle, aBuilder =>
{
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2010));
aBuilder.AddValidator(new NumberValidator() { MinExclusive = (-5400000L), MaxExclusive = (5400000L) });
})
.AddAttribute(52, "ky", a => a.VerticalSkewAngle, aBuilder =>
{
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2010));
aBuilder.AddValidator(new NumberValidator() { MinExclusive = (-5400000L), MaxExclusive = (5400000L) });
})
.AddAttribute(52, "algn", a => a.Alignment, aBuilder =>
{
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2010));
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Reflection>(deep);
    }

    /// <summary>
    /// <para>Defines the TextOutlineEffect Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w14:textOutline.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>NoFillEmpty &lt;w14:noFill></description></item>
    ///   <item><description>SolidColorFillProperties &lt;w14:solidFill></description></item>
    ///   <item><description>GradientFillProperties &lt;w14:gradFill></description></item>
    ///   <item><description>PresetLineDashProperties &lt;w14:prstDash></description></item>
    ///   <item><description>RoundEmpty &lt;w14:round></description></item>
    ///   <item><description>BevelEmpty &lt;w14:bevel></description></item>
    ///   <item><description>LineJoinMiterProperties &lt;w14:miter></description></item>
    /// </list>
    /// </remark>
    public partial class TextOutlineEffect : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TextOutlineEffect class.
        /// </summary>
        public TextOutlineEffect() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextOutlineEffect class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextOutlineEffect(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public TextOutlineEffect(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>w, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w14:w</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public Int32Value LineWidth
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>cap, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w14:cap</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Office2010.Word.LineCapValues> CapType
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.Word.LineCapValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>cmpd, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w14:cmpd</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Office2010.Word.CompoundLineValues> Compound
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.Word.CompoundLineValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>algn, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w14:algn</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Office2010.Word.PenAlignmentValues> Alignment
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.Word.PenAlignmentValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(52, "textOutline");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<NoFillEmpty>();
            builder.AddChild<SolidColorFillProperties>();
            builder.AddChild<GradientFillProperties>();
            builder.AddChild<PresetLineDashProperties>();
            builder.AddChild<RoundEmpty>();
            builder.AddChild<BevelEmpty>();
            builder.AddChild<LineJoinMiterProperties>();
            builder.AddElement<TextOutlineEffect>()
.AddAttribute(52, "w", a => a.LineWidth, aBuilder =>
{
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2010));
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (20116800L) });
})
.AddAttribute(52, "cap", a => a.CapType, aBuilder =>
{
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2010));
})
.AddAttribute(52, "cmpd", a => a.Compound, aBuilder =>
{
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2010));
})
.AddAttribute(52, "algn", a => a.Alignment, aBuilder =>
{
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2010));
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Group, 0, 1, version: FileFormatVersions.Office2010)
                {
                    new CompositeParticle(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.NoFillEmpty), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.SolidColorFillProperties), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.GradientFillProperties), 1, 1, version: FileFormatVersions.Office2010)
                    }
                },
                new CompositeParticle(ParticleType.Group, 0, 1, version: FileFormatVersions.Office2010)
                {
                    new CompositeParticle(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.PresetLineDashProperties), 1, 1, version: FileFormatVersions.Office2010)
                    }
                },
                new CompositeParticle(ParticleType.Group, 0, 1, version: FileFormatVersions.Office2010)
                {
                    new CompositeParticle(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.RoundEmpty), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.BevelEmpty), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.LineJoinMiterProperties), 1, 1, version: FileFormatVersions.Office2010)
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TextOutlineEffect>(deep);
    }

    /// <summary>
    /// <para>Defines the FillTextEffect Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w14:textFill.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>NoFillEmpty &lt;w14:noFill></description></item>
    ///   <item><description>SolidColorFillProperties &lt;w14:solidFill></description></item>
    ///   <item><description>GradientFillProperties &lt;w14:gradFill></description></item>
    /// </list>
    /// </remark>
    public partial class FillTextEffect : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the FillTextEffect class.
        /// </summary>
        public FillTextEffect() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the FillTextEffect class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FillTextEffect(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public FillTextEffect(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(52, "textFill");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<NoFillEmpty>();
            builder.AddChild<SolidColorFillProperties>();
            builder.AddChild<GradientFillProperties>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Group, 0, 1, version: FileFormatVersions.Office2010)
                {
                    new CompositeParticle(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.NoFillEmpty), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.SolidColorFillProperties), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.GradientFillProperties), 1, 1, version: FileFormatVersions.Office2010)
                    }
                }
            };
        }

        /// <summary>
        /// <para>NoFillEmpty.</para>
        /// <para>Represents the following element tag in the schema: w14:noFill.</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14 = http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public NoFillEmpty NoFillEmpty
        {
            get => GetElement<NoFillEmpty>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>SolidColorFillProperties.</para>
        /// <para>Represents the following element tag in the schema: w14:solidFill.</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14 = http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public SolidColorFillProperties SolidColorFillProperties
        {
            get => GetElement<SolidColorFillProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>GradientFillProperties.</para>
        /// <para>Represents the following element tag in the schema: w14:gradFill.</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14 = http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public GradientFillProperties GradientFillProperties
        {
            get => GetElement<GradientFillProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FillTextEffect>(deep);
    }

    /// <summary>
    /// <para>Defines the Scene3D Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w14:scene3d.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Camera &lt;w14:camera></description></item>
    ///   <item><description>LightRig &lt;w14:lightRig></description></item>
    /// </list>
    /// </remark>
    public partial class Scene3D : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Scene3D class.
        /// </summary>
        public Scene3D() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Scene3D class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Scene3D(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public Scene3D(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(52, "scene3d");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<Camera>();
            builder.AddChild<LightRig>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.Camera), 1, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.LightRig), 1, 1, version: FileFormatVersions.Office2010)
            };
        }

        /// <summary>
        /// <para>Camera.</para>
        /// <para>Represents the following element tag in the schema: w14:camera.</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14 = http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public Camera Camera
        {
            get => GetElement<Camera>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>LightRig.</para>
        /// <para>Represents the following element tag in the schema: w14:lightRig.</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14 = http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public LightRig LightRig
        {
            get => GetElement<LightRig>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Scene3D>(deep);
    }

    /// <summary>
    /// <para>Defines the Properties3D Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w14:props3d.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>BevelTop &lt;w14:bevelT></description></item>
    ///   <item><description>BevelBottom &lt;w14:bevelB></description></item>
    ///   <item><description>ExtrusionColor &lt;w14:extrusionClr></description></item>
    ///   <item><description>ContourColor &lt;w14:contourClr></description></item>
    /// </list>
    /// </remark>
    public partial class Properties3D : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Properties3D class.
        /// </summary>
        public Properties3D() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Properties3D class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Properties3D(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public Properties3D(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>extrusionH, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w14:extrusionH</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public Int64Value ExtrusionHeight
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>contourW, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w14:contourW</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public Int64Value ContourWidth
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>prstMaterial, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w14:prstMaterial</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Office2010.Word.PresetMaterialTypeValues> PresetMaterialType
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.Word.PresetMaterialTypeValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(52, "props3d");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<BevelTop>();
            builder.AddChild<BevelBottom>();
            builder.AddChild<ExtrusionColor>();
            builder.AddChild<ContourColor>();
            builder.AddElement<Properties3D>()
.AddAttribute(52, "extrusionH", a => a.ExtrusionHeight, aBuilder =>
{
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2010));
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (2147483647L) });
})
.AddAttribute(52, "contourW", a => a.ContourWidth, aBuilder =>
{
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2010));
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (2147483647L) });
})
.AddAttribute(52, "prstMaterial", a => a.PresetMaterialType, aBuilder =>
{
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2010));
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.BevelTop), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.BevelBottom), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.ExtrusionColor), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.ContourColor), 0, 1, version: FileFormatVersions.Office2010)
            };
        }

        /// <summary>
        /// <para>BevelTop.</para>
        /// <para>Represents the following element tag in the schema: w14:bevelT.</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14 = http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public BevelTop BevelTop
        {
            get => GetElement<BevelTop>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>BevelBottom.</para>
        /// <para>Represents the following element tag in the schema: w14:bevelB.</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14 = http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public BevelBottom BevelBottom
        {
            get => GetElement<BevelBottom>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtrusionColor.</para>
        /// <para>Represents the following element tag in the schema: w14:extrusionClr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14 = http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public ExtrusionColor ExtrusionColor
        {
            get => GetElement<ExtrusionColor>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ContourColor.</para>
        /// <para>Represents the following element tag in the schema: w14:contourClr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14 = http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public ContourColor ContourColor
        {
            get => GetElement<ContourColor>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Properties3D>(deep);
    }

    /// <summary>
    /// <para>Defines the Ligatures Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w14:ligatures.</para>
    /// </summary>
    public partial class Ligatures : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Ligatures class.
        /// </summary>
        public Ligatures() : base()
        {
        }

        /// <summary>
        /// <para>val, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w14:val</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Office2010.Word.LigaturesValues> Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.Word.LigaturesValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(52, "ligatures");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<Ligatures>()
.AddAttribute(52, "val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2010));
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Ligatures>(deep);
    }

    /// <summary>
    /// <para>Defines the NumberingFormat Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w14:numForm.</para>
    /// </summary>
    public partial class NumberingFormat : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the NumberingFormat class.
        /// </summary>
        public NumberingFormat() : base()
        {
        }

        /// <summary>
        /// <para>val, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w14:val</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Office2010.Word.NumberFormValues> Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.Word.NumberFormValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(52, "numForm");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<NumberingFormat>()
.AddAttribute(52, "val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2010));
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NumberingFormat>(deep);
    }

    /// <summary>
    /// <para>Defines the NumberSpacing Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w14:numSpacing.</para>
    /// </summary>
    public partial class NumberSpacing : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the NumberSpacing class.
        /// </summary>
        public NumberSpacing() : base()
        {
        }

        /// <summary>
        /// <para>val, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w14:val</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Office2010.Word.NumberSpacingValues> Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.Word.NumberSpacingValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(52, "numSpacing");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<NumberSpacing>()
.AddAttribute(52, "val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2010));
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NumberSpacing>(deep);
    }

    /// <summary>
    /// <para>Defines the StylisticSets Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w14:stylisticSets.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>StyleSet &lt;w14:styleSet></description></item>
    /// </list>
    /// </remark>
    public partial class StylisticSets : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the StylisticSets class.
        /// </summary>
        public StylisticSets() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the StylisticSets class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public StylisticSets(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public StylisticSets(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(52, "stylisticSets");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<StyleSet>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 0, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.StyleSet), 0, 0, version: FileFormatVersions.Office2010)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<StylisticSets>(deep);
    }

    /// <summary>
    /// <para>Defines the ContextualAlternatives Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w14:cntxtAlts.</para>
    /// </summary>
    public partial class ContextualAlternatives : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the ContextualAlternatives class.
        /// </summary>
        public ContextualAlternatives() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(52, "cntxtAlts");
            builder.Availability = FileFormatVersions.Office2010;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ContextualAlternatives>(deep);
    }

    /// <summary>
    /// <para>Defines the ConflictMode Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w14:conflictMode.</para>
    /// </summary>
    public partial class ConflictMode : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the ConflictMode class.
        /// </summary>
        public ConflictMode() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(52, "conflictMode");
            builder.Availability = FileFormatVersions.Office2010;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ConflictMode>(deep);
    }

    /// <summary>
    /// <para>Defines the DiscardImageEditingData Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w14:discardImageEditingData.</para>
    /// </summary>
    public partial class DiscardImageEditingData : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the DiscardImageEditingData class.
        /// </summary>
        public DiscardImageEditingData() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(52, "discardImageEditingData");
            builder.Availability = FileFormatVersions.Office2010;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DiscardImageEditingData>(deep);
    }

    /// <summary>
    /// <para>Defines the Checked Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w14:checked.</para>
    /// </summary>
    public partial class Checked : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the Checked class.
        /// </summary>
        public Checked() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(52, "checked");
            builder.Availability = FileFormatVersions.Office2010;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Checked>(deep);
    }

    /// <summary>
    /// <para>Defines the OnOffType Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class OnOffType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the OnOffType class.
        /// </summary>
        protected OnOffType() : base()
        {
        }

        /// <summary>
        /// <para>val, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w14:val</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Office2010.Word.OnOffValues> Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.Word.OnOffValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<OnOffType>()
                           .AddAttribute(52, "val", a => a.Val, aBuilder =>
                           {
                               aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2010));
                           });
        }
    }

    /// <summary>
    /// <para>Defines the ContentPart Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w14:contentPart.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>WordNonVisualContentPartShapeProperties &lt;w14:nvContentPartPr></description></item>
    ///   <item><description>Transform2D &lt;w14:xfrm></description></item>
    ///   <item><description>OfficeArtExtensionList &lt;w14:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class ContentPart : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ContentPart class.
        /// </summary>
        public ContentPart() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ContentPart class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ContentPart(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public ContentPart(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>bwMode, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w14:bwMode</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues> BlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: r:id</para>
        /// </summary>
        /// <remark>
        /// xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
        /// </remark>
        public StringValue RelationshipId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(52, "contentPart");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<WordNonVisualContentPartShapeProperties>();
            builder.AddChild<Transform2D>();
            builder.AddChild<OfficeArtExtensionList>();
            builder.AddElement<ContentPart>()
.AddAttribute(52, "bwMode", a => a.BlackWhiteMode, aBuilder =>
{
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2010));
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute(19, "id", a => a.RelationshipId, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.WordNonVisualContentPartShapeProperties), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.Transform2D), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2010)
            };
        }

        /// <summary>
        /// <para>WordNonVisualContentPartShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: w14:nvContentPartPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14 = http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public WordNonVisualContentPartShapeProperties WordNonVisualContentPartShapeProperties
        {
            get => GetElement<WordNonVisualContentPartShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Transform2D.</para>
        /// <para>Represents the following element tag in the schema: w14:xfrm.</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14 = http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public Transform2D Transform2D
        {
            get => GetElement<Transform2D>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>OfficeArtExtensionList.</para>
        /// <para>Represents the following element tag in the schema: w14:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14 = http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public OfficeArtExtensionList OfficeArtExtensionList
        {
            get => GetElement<OfficeArtExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ContentPart>(deep);
    }

    /// <summary>
    /// <para>Defines the DocumentId Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w14:docId.</para>
    /// </summary>
    public partial class DocumentId : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the DocumentId class.
        /// </summary>
        public DocumentId() : base()
        {
        }

        /// <summary>
        /// <para>val, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w14:val</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public HexBinaryValue Val
        {
            get => GetAttribute<HexBinaryValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(52, "docId");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<DocumentId>()
.AddAttribute(52, "val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2010));
aBuilder.AddValidator(new StringValidator() { Length = (4L) });
});
            builder.AddConstraint(new AttributeValueRangeConstraint(0 /*w14:val*/, true, 0, false, 2147483648, false) { Version = FileFormatVersions.Office2010 });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DocumentId>(deep);
    }

    /// <summary>
    /// <para>Defines the CustomXmlConflictInsertionRangeEnd Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w14:customXmlConflictInsRangeEnd.</para>
    /// </summary>
    public partial class CustomXmlConflictInsertionRangeEnd : MarkupType
    {
        /// <summary>
        /// Initializes a new instance of the CustomXmlConflictInsertionRangeEnd class.
        /// </summary>
        public CustomXmlConflictInsertionRangeEnd() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(52, "customXmlConflictInsRangeEnd");
            builder.Availability = FileFormatVersions.Office2010;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CustomXmlConflictInsertionRangeEnd>(deep);
    }

    /// <summary>
    /// <para>Defines the CustomXmlConflictDeletionRangeEnd Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w14:customXmlConflictDelRangeEnd.</para>
    /// </summary>
    public partial class CustomXmlConflictDeletionRangeEnd : MarkupType
    {
        /// <summary>
        /// Initializes a new instance of the CustomXmlConflictDeletionRangeEnd class.
        /// </summary>
        public CustomXmlConflictDeletionRangeEnd() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(52, "customXmlConflictDelRangeEnd");
            builder.Availability = FileFormatVersions.Office2010;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CustomXmlConflictDeletionRangeEnd>(deep);
    }

    /// <summary>
    /// <para>Defines the MarkupType Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class MarkupType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the MarkupType class.
        /// </summary>
        protected MarkupType() : base()
        {
        }

        /// <summary>
        /// <para>Annotation Identifier</para>
        /// <para>Represents the following attribute in the schema: w:id</para>
        /// </summary>
        /// <remark>
        /// xmlns:w=http://schemas.openxmlformats.org/wordprocessingml/2006/main
        /// </remark>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<MarkupType>()
                           .AddAttribute(23, "id", a => a.Id, aBuilder =>
                           {
                               aBuilder.AddValidator(RequiredValidator.Instance);
                               aBuilder.AddUnion(union =>
                               {
                                   union.AddValidator<Int32Value>(new NumberValidator() { MinInclusive = (0L) });
                                   union.AddValidator<Int32Value>(new NumberValidator() { MaxInclusive = (-2L) });
                               });
                           });
        }
    }

    /// <summary>
    /// <para>Defines the DefaultImageDpi Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w14:defaultImageDpi.</para>
    /// </summary>
    public partial class DefaultImageDpi : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the DefaultImageDpi class.
        /// </summary>
        public DefaultImageDpi() : base()
        {
        }

        /// <summary>
        /// <para>val, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w14:val</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public Int32Value Val
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(52, "defaultImageDpi");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<DefaultImageDpi>()
.AddAttribute(52, "val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2010));
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DefaultImageDpi>(deep);
    }

    /// <summary>
    /// <para>Defines the SdtContentCheckBox Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w14:checkbox.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Checked &lt;w14:checked></description></item>
    ///   <item><description>CheckedState &lt;w14:checkedState></description></item>
    ///   <item><description>UncheckedState &lt;w14:uncheckedState></description></item>
    /// </list>
    /// </remark>
    public partial class SdtContentCheckBox : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SdtContentCheckBox class.
        /// </summary>
        public SdtContentCheckBox() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SdtContentCheckBox class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SdtContentCheckBox(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public SdtContentCheckBox(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(52, "checkbox");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<Checked>();
            builder.AddChild<CheckedState>();
            builder.AddChild<UncheckedState>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.Checked), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CheckedState), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.UncheckedState), 0, 1, version: FileFormatVersions.Office2010)
            };
        }

        /// <summary>
        /// <para>Checked.</para>
        /// <para>Represents the following element tag in the schema: w14:checked.</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14 = http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public Checked Checked
        {
            get => GetElement<Checked>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>CheckedState.</para>
        /// <para>Represents the following element tag in the schema: w14:checkedState.</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14 = http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public CheckedState CheckedState
        {
            get => GetElement<CheckedState>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>UncheckedState.</para>
        /// <para>Represents the following element tag in the schema: w14:uncheckedState.</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14 = http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public UncheckedState UncheckedState
        {
            get => GetElement<UncheckedState>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SdtContentCheckBox>(deep);
    }

    /// <summary>
    /// <para>Defines the GradientStop Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w14:gs.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>RgbColorModelHex &lt;w14:srgbClr></description></item>
    ///   <item><description>SchemeColor &lt;w14:schemeClr></description></item>
    /// </list>
    /// </remark>
    public partial class GradientStop : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the GradientStop class.
        /// </summary>
        public GradientStop() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the GradientStop class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GradientStop(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public GradientStop(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>pos, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w14:pos</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public Int32Value StopPosition
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(52, "gs");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<RgbColorModelHex>();
            builder.AddChild<SchemeColor>();
            builder.AddElement<GradientStop>()
.AddAttribute(52, "pos", a => a.StopPosition, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2010));
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Group, 1, 1, version: FileFormatVersions.Office2010)
                {
                    new CompositeParticle(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.RgbColorModelHex), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.SchemeColor), 1, 1, version: FileFormatVersions.Office2010)
                    }
                }
            };
        }

        /// <summary>
        /// <para>RgbColorModelHex.</para>
        /// <para>Represents the following element tag in the schema: w14:srgbClr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14 = http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public RgbColorModelHex RgbColorModelHex
        {
            get => GetElement<RgbColorModelHex>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>SchemeColor.</para>
        /// <para>Represents the following element tag in the schema: w14:schemeClr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14 = http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public SchemeColor SchemeColor
        {
            get => GetElement<SchemeColor>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<GradientStop>(deep);
    }

    /// <summary>
    /// <para>Defines the FillToRectangle Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w14:fillToRect.</para>
    /// </summary>
    public partial class FillToRectangle : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the FillToRectangle class.
        /// </summary>
        public FillToRectangle() : base()
        {
        }

        /// <summary>
        /// <para>l, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w14:l</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public Int32Value Left
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>t, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w14:t</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public Int32Value Top
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>r, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w14:r</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public Int32Value Right
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>b, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w14:b</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public Int32Value Bottom
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(52, "fillToRect");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<FillToRectangle>()
.AddAttribute(52, "l", a => a.Left, aBuilder =>
{
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2010));
})
.AddAttribute(52, "t", a => a.Top, aBuilder =>
{
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2010));
})
.AddAttribute(52, "r", a => a.Right, aBuilder =>
{
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2010));
})
.AddAttribute(52, "b", a => a.Bottom, aBuilder =>
{
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2010));
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FillToRectangle>(deep);
    }

    /// <summary>
    /// <para>Defines the GradientStopList Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w14:gsLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>GradientStop &lt;w14:gs></description></item>
    /// </list>
    /// </remark>
    public partial class GradientStopList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the GradientStopList class.
        /// </summary>
        public GradientStopList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the GradientStopList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GradientStopList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public GradientStopList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(52, "gsLst");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<GradientStop>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.GradientStop), 2, 10, version: FileFormatVersions.Office2010)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<GradientStopList>(deep);
    }

    /// <summary>
    /// <para>Defines the SphereCoordinates Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w14:rot.</para>
    /// </summary>
    public partial class SphereCoordinates : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the SphereCoordinates class.
        /// </summary>
        public SphereCoordinates() : base()
        {
        }

        /// <summary>
        /// <para>lat, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w14:lat</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public Int32Value Lattitude
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>lon, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w14:lon</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public Int32Value Longitude
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>rev, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w14:rev</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public Int32Value Revolution
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(52, "rot");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<SphereCoordinates>()
.AddAttribute(52, "lat", a => a.Lattitude, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2010));
aBuilder.AddValidator(new NumberValidator() { MaxExclusive = (21600000L), MinInclusive = (0L) });
})
.AddAttribute(52, "lon", a => a.Longitude, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2010));
aBuilder.AddValidator(new NumberValidator() { MaxExclusive = (21600000L), MinInclusive = (0L) });
})
.AddAttribute(52, "rev", a => a.Revolution, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2010));
aBuilder.AddValidator(new NumberValidator() { MaxExclusive = (21600000L), MinInclusive = (0L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SphereCoordinates>(deep);
    }

    /// <summary>
    /// <para>Defines the Camera Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w14:camera.</para>
    /// </summary>
    public partial class Camera : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Camera class.
        /// </summary>
        public Camera() : base()
        {
        }

        /// <summary>
        /// <para>prst, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w14:prst</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Office2010.Word.PresetCameraTypeValues> PresetCameraType
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.Word.PresetCameraTypeValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(52, "camera");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<Camera>()
.AddAttribute(52, "prst", a => a.PresetCameraType, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2010));
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Camera>(deep);
    }

    /// <summary>
    /// <para>Defines the LightRig Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w14:lightRig.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>SphereCoordinates &lt;w14:rot></description></item>
    /// </list>
    /// </remark>
    public partial class LightRig : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the LightRig class.
        /// </summary>
        public LightRig() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the LightRig class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LightRig(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public LightRig(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>rig, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w14:rig</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Office2010.Word.LightRigTypeValues> LightRigType
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.Word.LightRigTypeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>dir, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w14:dir</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Office2010.Word.LightRigDirectionValues> LightDirectionType
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.Word.LightRigDirectionValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(52, "lightRig");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<SphereCoordinates>();
            builder.AddElement<LightRig>()
.AddAttribute(52, "rig", a => a.LightRigType, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2010));
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute(52, "dir", a => a.LightDirectionType, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2010));
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.SphereCoordinates), 0, 1, version: FileFormatVersions.Office2010)
            };
        }

        /// <summary>
        /// <para>SphereCoordinates.</para>
        /// <para>Represents the following element tag in the schema: w14:rot.</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14 = http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public SphereCoordinates SphereCoordinates
        {
            get => GetElement<SphereCoordinates>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LightRig>(deep);
    }

    /// <summary>
    /// <para>Defines the BevelTop Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w14:bevelT.</para>
    /// </summary>
    public partial class BevelTop : BevelType
    {
        /// <summary>
        /// Initializes a new instance of the BevelTop class.
        /// </summary>
        public BevelTop() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(52, "bevelT");
            builder.Availability = FileFormatVersions.Office2010;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BevelTop>(deep);
    }

    /// <summary>
    /// <para>Defines the BevelBottom Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w14:bevelB.</para>
    /// </summary>
    public partial class BevelBottom : BevelType
    {
        /// <summary>
        /// Initializes a new instance of the BevelBottom class.
        /// </summary>
        public BevelBottom() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(52, "bevelB");
            builder.Availability = FileFormatVersions.Office2010;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BevelBottom>(deep);
    }

    /// <summary>
    /// <para>Defines the BevelType Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class BevelType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the BevelType class.
        /// </summary>
        protected BevelType() : base()
        {
        }

        /// <summary>
        /// <para>w, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w14:w</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public Int64Value Width
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>h, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w14:h</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public Int64Value Height
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>prst, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w14:prst</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Office2010.Word.BevelPresetTypeValues> PresetProfileType
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.Word.BevelPresetTypeValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<BevelType>()
                           .AddAttribute(52, "w", a => a.Width, aBuilder =>
                           {
                               aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2010));
                               aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (2147483647L) });
                           })
                           .AddAttribute(52, "h", a => a.Height, aBuilder =>
                           {
                               aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2010));
                               aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (2147483647L) });
                           })
                           .AddAttribute(52, "prst", a => a.PresetProfileType, aBuilder =>
                           {
                               aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2010));
                               aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
                           });
        }
    }

    /// <summary>
    /// <para>Defines the ExtrusionColor Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w14:extrusionClr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>RgbColorModelHex &lt;w14:srgbClr></description></item>
    ///   <item><description>SchemeColor &lt;w14:schemeClr></description></item>
    /// </list>
    /// </remark>
    public partial class ExtrusionColor : ColorType
    {
        /// <summary>
        /// Initializes a new instance of the ExtrusionColor class.
        /// </summary>
        public ExtrusionColor() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ExtrusionColor class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ExtrusionColor(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public ExtrusionColor(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(52, "extrusionClr");
            builder.Availability = FileFormatVersions.Office2010;
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Group, 1, 1, version: FileFormatVersions.Office2010)
                {
                    new CompositeParticle(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.RgbColorModelHex), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.SchemeColor), 1, 1, version: FileFormatVersions.Office2010)
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ExtrusionColor>(deep);
    }

    /// <summary>
    /// <para>Defines the ContourColor Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w14:contourClr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>RgbColorModelHex &lt;w14:srgbClr></description></item>
    ///   <item><description>SchemeColor &lt;w14:schemeClr></description></item>
    /// </list>
    /// </remark>
    public partial class ContourColor : ColorType
    {
        /// <summary>
        /// Initializes a new instance of the ContourColor class.
        /// </summary>
        public ContourColor() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ContourColor class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ContourColor(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public ContourColor(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(52, "contourClr");
            builder.Availability = FileFormatVersions.Office2010;
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Group, 1, 1, version: FileFormatVersions.Office2010)
                {
                    new CompositeParticle(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.RgbColorModelHex), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.SchemeColor), 1, 1, version: FileFormatVersions.Office2010)
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ContourColor>(deep);
    }

    /// <summary>
    /// <para>Defines the ColorType Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>RgbColorModelHex &lt;w14:srgbClr></description></item>
    ///   <item><description>SchemeColor &lt;w14:schemeClr></description></item>
    /// </list>
    /// </remark>
    public abstract partial class ColorType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ColorType class.
        /// </summary>
        protected ColorType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected ColorType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        protected ColorType(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddChild<RgbColorModelHex>();
            builder.AddChild<SchemeColor>();
        }

        /// <summary>
        /// <para>RgbColorModelHex.</para>
        /// <para>Represents the following element tag in the schema: w14:srgbClr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14 = http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public RgbColorModelHex RgbColorModelHex
        {
            get => GetElement<RgbColorModelHex>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>SchemeColor.</para>
        /// <para>Represents the following element tag in the schema: w14:schemeClr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14 = http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public SchemeColor SchemeColor
        {
            get => GetElement<SchemeColor>();
            set => SetElement(value);
        }
    }

    /// <summary>
    /// <para>Defines the StyleSet Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w14:styleSet.</para>
    /// </summary>
    public partial class StyleSet : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the StyleSet class.
        /// </summary>
        public StyleSet() : base()
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w14:id</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public UInt32Value Id
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>val, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w14:val</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Office2010.Word.OnOffValues> Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.Word.OnOffValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(52, "styleSet");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<StyleSet>()
.AddAttribute(52, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2010));
})
.AddAttribute(52, "val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2010));
});
            builder.AddConstraint(new AttributeValueRangeConstraint(0 /*w14:id*/, true, 1, true, 20, true) { Version = FileFormatVersions.Office2010 });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<StyleSet>(deep);
    }

    /// <summary>
    /// <para>Defines the CheckedState Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w14:checkedState.</para>
    /// </summary>
    public partial class CheckedState : CheckBoxSymbolType
    {
        /// <summary>
        /// Initializes a new instance of the CheckedState class.
        /// </summary>
        public CheckedState() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(52, "checkedState");
            builder.Availability = FileFormatVersions.Office2010;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CheckedState>(deep);
    }

    /// <summary>
    /// <para>Defines the UncheckedState Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w14:uncheckedState.</para>
    /// </summary>
    public partial class UncheckedState : CheckBoxSymbolType
    {
        /// <summary>
        /// Initializes a new instance of the UncheckedState class.
        /// </summary>
        public UncheckedState() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(52, "uncheckedState");
            builder.Availability = FileFormatVersions.Office2010;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<UncheckedState>(deep);
    }

    /// <summary>
    /// <para>Defines the CheckBoxSymbolType Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class CheckBoxSymbolType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the CheckBoxSymbolType class.
        /// </summary>
        protected CheckBoxSymbolType() : base()
        {
        }

        /// <summary>
        /// <para>font, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w14:font</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public StringValue Font
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>val, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w14:val</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public HexBinaryValue Val
        {
            get => GetAttribute<HexBinaryValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<CheckBoxSymbolType>()
                           .AddAttribute(52, "font", a => a.Font, aBuilder =>
                           {
                               aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2010));
                           })
                           .AddAttribute(52, "val", a => a.Val, aBuilder =>
                           {
                               aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2010));
                               aBuilder.AddValidator(new StringValidator() { Length = (2L) });
                           });
        }
    }

    /// <summary>
    /// <para>Defines the NonVisualDrawingProperties Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w14:cNvPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.HyperlinkOnClick &lt;a:hlinkClick></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.HyperlinkOnHover &lt;a:hlinkHover></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList &lt;a:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class NonVisualDrawingProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NonVisualDrawingProperties class.
        /// </summary>
        public NonVisualDrawingProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualDrawingProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualDrawingProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public NonVisualDrawingProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public UInt32Value Id
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>name</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>
        public StringValue Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>descr</para>
        /// <para>Represents the following attribute in the schema: descr</para>
        /// </summary>
        public StringValue Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>hidden</para>
        /// <para>Represents the following attribute in the schema: hidden</para>
        /// </summary>
        public BooleanValue Hidden
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>title</para>
        /// <para>Represents the following attribute in the schema: title</para>
        /// </summary>
        public StringValue Title
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(52, "cNvPr");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.HyperlinkOnClick>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.HyperlinkOnHover>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList>();
            builder.AddElement<NonVisualDrawingProperties>()
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "name", a => a.Name, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "descr", a => a.Description)
.AddAttribute(0, "hidden", a => a.Hidden)
.AddAttribute(0, "title", a => a.Title);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HyperlinkOnClick), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HyperlinkOnHover), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>HyperlinkOnClick.</para>
        /// <para>Represents the following element tag in the schema: a:hlinkClick.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.HyperlinkOnClick HyperlinkOnClick
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.HyperlinkOnClick>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>HyperlinkOnHover.</para>
        /// <para>Represents the following element tag in the schema: a:hlinkHover.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.HyperlinkOnHover HyperlinkOnHover
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.HyperlinkOnHover>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>NonVisualDrawingPropertiesExtensionList.</para>
        /// <para>Represents the following element tag in the schema: a:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList NonVisualDrawingPropertiesExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualDrawingProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the NonVisualInkContentPartProperties Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w14:cNvContentPartPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Drawing.ContentPartLocks &lt;a14:cpLocks></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Drawing.OfficeArtExtensionList &lt;a14:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class NonVisualInkContentPartProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NonVisualInkContentPartProperties class.
        /// </summary>
        public NonVisualInkContentPartProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualInkContentPartProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualInkContentPartProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public NonVisualInkContentPartProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>isComment, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: isComment</para>
        /// </summary>
        public BooleanValue IsComment
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(52, "cNvContentPartPr");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Drawing.ContentPartLocks>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Drawing.OfficeArtExtensionList>();
            builder.AddElement<NonVisualInkContentPartProperties>()
.AddAttribute(0, "isComment", a => a.IsComment);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.ContentPartLocks), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2010)
            };
        }

        /// <summary>
        /// <para>ContentPartLocks.</para>
        /// <para>Represents the following element tag in the schema: a14:cpLocks.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Drawing.ContentPartLocks ContentPartLocks
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Drawing.ContentPartLocks>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>OfficeArtExtensionList.</para>
        /// <para>Represents the following element tag in the schema: a14:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Drawing.OfficeArtExtensionList OfficeArtExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Drawing.OfficeArtExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualInkContentPartProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the WordNonVisualContentPartShapeProperties Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w14:nvContentPartPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>NonVisualDrawingProperties &lt;w14:cNvPr></description></item>
    ///   <item><description>NonVisualInkContentPartProperties &lt;w14:cNvContentPartPr></description></item>
    /// </list>
    /// </remark>
    public partial class WordNonVisualContentPartShapeProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the WordNonVisualContentPartShapeProperties class.
        /// </summary>
        public WordNonVisualContentPartShapeProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the WordNonVisualContentPartShapeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public WordNonVisualContentPartShapeProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public WordNonVisualContentPartShapeProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(52, "nvContentPartPr");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<NonVisualDrawingProperties>();
            builder.AddChild<NonVisualInkContentPartProperties>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.NonVisualDrawingProperties), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.NonVisualInkContentPartProperties), 0, 1, version: FileFormatVersions.Office2010)
            };
        }

        /// <summary>
        /// <para>NonVisualDrawingProperties.</para>
        /// <para>Represents the following element tag in the schema: w14:cNvPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14 = http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public NonVisualDrawingProperties NonVisualDrawingProperties
        {
            get => GetElement<NonVisualDrawingProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>NonVisualInkContentPartProperties.</para>
        /// <para>Represents the following element tag in the schema: w14:cNvContentPartPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14 = http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        public NonVisualInkContentPartProperties NonVisualInkContentPartProperties
        {
            get => GetElement<NonVisualInkContentPartProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<WordNonVisualContentPartShapeProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the Transform2D Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w14:xfrm.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Offset &lt;a:off></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Extents &lt;a:ext></description></item>
    /// </list>
    /// </remark>
    public partial class Transform2D : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Transform2D class.
        /// </summary>
        public Transform2D() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Transform2D class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Transform2D(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public Transform2D(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Rotation</para>
        /// <para>Represents the following attribute in the schema: rot</para>
        /// </summary>
        public Int32Value Rotation
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Flip</para>
        /// <para>Represents the following attribute in the schema: flipH</para>
        /// </summary>
        public BooleanValue HorizontalFlip
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Vertical Flip</para>
        /// <para>Represents the following attribute in the schema: flipV</para>
        /// </summary>
        public BooleanValue VerticalFlip
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(52, "xfrm");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Offset>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Extents>();
            builder.AddElement<Transform2D>()
.AddAttribute(0, "rot", a => a.Rotation)
.AddAttribute(0, "flipH", a => a.HorizontalFlip)
.AddAttribute(0, "flipV", a => a.VerticalFlip);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Offset), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Extents), 0, 1)
            };
        }

        /// <summary>
        /// <para>Offset.</para>
        /// <para>Represents the following element tag in the schema: a:off.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Offset Offset
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Offset>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Extents.</para>
        /// <para>Represents the following element tag in the schema: a:ext.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Extents Extents
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Extents>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Transform2D>(deep);
    }

    /// <summary>
    /// <para>Defines the OfficeArtExtensionList Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w14:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Extension &lt;a:ext></description></item>
    /// </list>
    /// </remark>
    public partial class OfficeArtExtensionList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the OfficeArtExtensionList class.
        /// </summary>
        public OfficeArtExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OfficeArtExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OfficeArtExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public OfficeArtExtensionList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(52, "extLst");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Extension>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Group, 1, 1)
                {
                    new CompositeParticle(ParticleType.Sequence, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Extension), 0, 0)
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<OfficeArtExtensionList>(deep);
    }

    /// <summary>
    /// Defines the OnOffValues enumeration.
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2010)]
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
    [OfficeAvailability(FileFormatVersions.Office2010)]
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
    [OfficeAvailability(FileFormatVersions.Office2010)]
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
    [OfficeAvailability(FileFormatVersions.Office2010)]
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
    [OfficeAvailability(FileFormatVersions.Office2010)]
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
    [OfficeAvailability(FileFormatVersions.Office2010)]
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
    [OfficeAvailability(FileFormatVersions.Office2010)]
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
    [OfficeAvailability(FileFormatVersions.Office2010)]
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
    [OfficeAvailability(FileFormatVersions.Office2010)]
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
    [OfficeAvailability(FileFormatVersions.Office2010)]
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
    [OfficeAvailability(FileFormatVersions.Office2010)]
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
    [OfficeAvailability(FileFormatVersions.Office2010)]
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
    [OfficeAvailability(FileFormatVersions.Office2010)]
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
    [OfficeAvailability(FileFormatVersions.Office2010)]
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
    [OfficeAvailability(FileFormatVersions.Office2010)]
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
    [OfficeAvailability(FileFormatVersions.Office2010)]
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