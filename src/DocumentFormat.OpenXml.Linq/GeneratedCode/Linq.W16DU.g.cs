// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:w16du="http://schemas.microsoft.com/office/word/2023/wordml/word16du" namespace.
    /// </summary>
    public static class W16DU
    {
        /// <summary>
        /// Defines the XML namespace associated with the w16du prefix.
        /// </summary>
        public static readonly XNamespace w16du = "http://schemas.microsoft.com/office/word/2023/wordml/word16du";

        /// <summary>
        /// Represents the w16du:dateUtc XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="W.cellMerge" />, <see cref="W.comment" />, <see cref="W.del" />, <see cref="W.ins" />, <see cref="W.numberingChange" />, <see cref="W.pPrChange" />, <see cref="W.rPrChange" />, <see cref="W.sectPrChange" />, <see cref="W.tblPrChange" />, <see cref="W.tblPrExChange" />, <see cref="W.tcPrChange" />, <see cref="W.trPrChange" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: CellMerge.DateUtc, Comment.DateUtc, DeletedMathControl.DateUtc, InsertedMathControl.DateUtc, NumberingChange.DateUtc, ParagraphMarkRunPropertiesChange.DateUtc, ParagraphPropertiesChange.DateUtc, RunPropertiesChange.DateUtc, SectionPropertiesChange.DateUtc, TableCellPropertiesChange.DateUtc, TablePropertiesChange.DateUtc, TablePropertyExceptionsChange.DateUtc, TableRowPropertiesChange.DateUtc.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dateUtc = w16du + "dateUtc";
    }
}
