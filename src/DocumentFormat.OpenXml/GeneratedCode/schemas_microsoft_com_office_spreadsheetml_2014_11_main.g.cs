// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office2016.ExcelAc
{
    /// <summary>
    /// <para>Defines the ModelTimeGroupings Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x16:modelTimeGroupings.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ModelTimeGrouping &lt;x16:modelTimeGrouping></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(ModelTimeGrouping), FileFormatVersions.Office2016)]
    [SchemaAttr(84, "modelTimeGroupings")]
    [OfficeAvailability(FileFormatVersions.Office2016)]
    public partial class ModelTimeGroupings : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ModelTimeGroupings class.
        /// </summary>
        public ModelTimeGroupings() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ModelTimeGroupings class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ModelTimeGroupings(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ModelTimeGroupings class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ModelTimeGroupings(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ModelTimeGroupings class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ModelTimeGroupings(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.ExcelAc.ModelTimeGrouping), 1, 0, version: FileFormatVersions.Office2016)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ModelTimeGroupings>(deep);
    }

    /// <summary>
    /// <para>Defines the ModelTimeGrouping Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x16:modelTimeGrouping.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>CalculatedTimeColumn &lt;x16:calculatedTimeColumn></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(CalculatedTimeColumn), FileFormatVersions.Office2016)]
    [SchemaAttr(84, "modelTimeGrouping")]
    [OfficeAvailability(FileFormatVersions.Office2016)]
    public partial class ModelTimeGrouping : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ModelTimeGrouping class.
        /// </summary>
        public ModelTimeGrouping() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ModelTimeGrouping class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ModelTimeGrouping(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ModelTimeGrouping class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ModelTimeGrouping(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ModelTimeGrouping class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ModelTimeGrouping(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>tableName, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: tableName</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "tableName")]
        [Index(0)]
        public StringValue TableName { get; set; }

        /// <summary>
        /// <para>columnName, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: columnName</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "columnName")]
        [Index(1)]
        public StringValue ColumnName { get; set; }

        /// <summary>
        /// <para>columnId, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: columnId</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "columnId")]
        [Index(2)]
        public StringValue ColumnId { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.ExcelAc.CalculatedTimeColumn), 1, 0, version: FileFormatVersions.Office2016)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ModelTimeGrouping>(deep);
    }

    /// <summary>
    /// <para>Defines the CalculatedTimeColumn Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x16:calculatedTimeColumn.</para>
    /// </summary>
    [SchemaAttr(84, "calculatedTimeColumn")]
    [OfficeAvailability(FileFormatVersions.Office2016)]
    public partial class CalculatedTimeColumn : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the CalculatedTimeColumn class.
        /// </summary>
        public CalculatedTimeColumn() : base()
        {
        }

        /// <summary>
        /// <para>columnName, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: columnName</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "columnName")]
        [Index(0)]
        public StringValue ColumnName { get; set; }

        /// <summary>
        /// <para>columnId, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: columnId</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "columnId")]
        [Index(1)]
        public StringValue ColumnId { get; set; }

        /// <summary>
        /// <para>contentType, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: contentType</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "contentType")]
        [Index(2)]
        public EnumValue<DocumentFormat.OpenXml.Office2016.ExcelAc.ModelTimeGroupingContentType> ContentType { get; set; }

        /// <summary>
        /// <para>isSelected, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: isSelected</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "isSelected")]
        [Index(3)]
        public BooleanValue IsSelected { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CalculatedTimeColumn>(deep);
    }

    /// <summary>
    /// Defines the ModelTimeGroupingContentType enumeration.
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2016)]
    public enum ModelTimeGroupingContentType
    {
        ///<summary>
        ///years.
        ///<para>When the item is serialized out as xml, its value is "years".</para>
        ///</summary>
        [EnumString("years")]
        Years,
        ///<summary>
        ///quarters.
        ///<para>When the item is serialized out as xml, its value is "quarters".</para>
        ///</summary>
        [EnumString("quarters")]
        Quarters,
        ///<summary>
        ///monthsindex.
        ///<para>When the item is serialized out as xml, its value is "monthsindex".</para>
        ///</summary>
        [EnumString("monthsindex")]
        Monthsindex,
        ///<summary>
        ///months.
        ///<para>When the item is serialized out as xml, its value is "months".</para>
        ///</summary>
        [EnumString("months")]
        Months,
        ///<summary>
        ///daysindex.
        ///<para>When the item is serialized out as xml, its value is "daysindex".</para>
        ///</summary>
        [EnumString("daysindex")]
        Daysindex,
        ///<summary>
        ///days.
        ///<para>When the item is serialized out as xml, its value is "days".</para>
        ///</summary>
        [EnumString("days")]
        Days,
        ///<summary>
        ///hours.
        ///<para>When the item is serialized out as xml, its value is "hours".</para>
        ///</summary>
        [EnumString("hours")]
        Hours,
        ///<summary>
        ///minutes.
        ///<para>When the item is serialized out as xml, its value is "minutes".</para>
        ///</summary>
        [EnumString("minutes")]
        Minutes,
        ///<summary>
        ///seconds.
        ///<para>When the item is serialized out as xml, its value is "seconds".</para>
        ///</summary>
        [EnumString("seconds")]
        Seconds,
    }
}