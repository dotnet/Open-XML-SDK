// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office2019.Excel.PivotDefaultLayout
{
    /// <summary>
    /// <para>Defines the PivotTableDefinition16 Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xpdl:pivotTableDefinition16.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(88, "pivotTableDefinition16")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class PivotTableDefinition16 : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the PivotTableDefinition16 class.
        /// </summary>
        public PivotTableDefinition16() : base()
        {
        }

        /// <summary>
        /// <para>EnabledSubtotalsDefault, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: EnabledSubtotalsDefault</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "EnabledSubtotalsDefault")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? EnabledSubtotalsDefault
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>SubtotalsOnTopDefault, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: SubtotalsOnTopDefault</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "SubtotalsOnTopDefault")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? SubtotalsOnTopDefault
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>InsertBlankRowDefault, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: InsertBlankRowDefault</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "InsertBlankRowDefault")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? InsertBlankRowDefault
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(88, "pivotTableDefinition16");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddElement<PivotTableDefinition16>()
.AddAttribute(0, "EnabledSubtotalsDefault", a => a.EnabledSubtotalsDefault)
.AddAttribute(0, "SubtotalsOnTopDefault", a => a.SubtotalsOnTopDefault)
.AddAttribute(0, "InsertBlankRowDefault", a => a.InsertBlankRowDefault);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotTableDefinition16>(deep);
    }
}