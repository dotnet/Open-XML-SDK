// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Presentation;

namespace DocumentFormat.OpenXml.Office2016.Presentation
{
/// <summary>
/// <para>Defines the DesignElement Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is p16:designElem.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(78, "designElem")]
public partial class DesignElement : OpenXmlLeafElement
{
    
        /// <summary>
    /// <para> val, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    [Index(0)]
    public BooleanValue Val { get; set; }

    /// <summary>
    /// Initializes a new instance of the DesignElement class.
    /// </summary>
    public DesignElement():base(){}
    
    

    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DesignElement>(deep);

}
}
