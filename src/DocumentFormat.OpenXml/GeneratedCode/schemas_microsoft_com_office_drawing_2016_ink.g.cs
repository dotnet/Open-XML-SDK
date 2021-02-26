// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office2019.Drawing.Ink
{
    /// <summary>
    /// Defines the ExtendedBrushPropertyName enumeration.
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2019)]
    public enum ExtendedBrushPropertyName
    {
        ///<summary>
        ///inkEffects.
        ///<para>When the item is serialized out as xml, its value is "inkEffects".</para>
        ///</summary>
        [EnumString("inkEffects")]
        InkEffects,
        ///<summary>
        ///anchorX.
        ///<para>When the item is serialized out as xml, its value is "anchorX".</para>
        ///</summary>
        [EnumString("anchorX")]
        AnchorX,
        ///<summary>
        ///anchorY.
        ///<para>When the item is serialized out as xml, its value is "anchorY".</para>
        ///</summary>
        [EnumString("anchorY")]
        AnchorY,
        ///<summary>
        ///scaleFactor.
        ///<para>When the item is serialized out as xml, its value is "scaleFactor".</para>
        ///</summary>
        [EnumString("scaleFactor")]
        ScaleFactor,
    }

    /// <summary>
    /// Defines the InkEffectsType enumeration.
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2019)]
    public enum InkEffectsType
    {
        ///<summary>
        ///none.
        ///<para>When the item is serialized out as xml, its value is "none".</para>
        ///</summary>
        [EnumString("none")]
        None,
        ///<summary>
        ///pencil.
        ///<para>When the item is serialized out as xml, its value is "pencil".</para>
        ///</summary>
        [EnumString("pencil")]
        Pencil,
        ///<summary>
        ///rainbow.
        ///<para>When the item is serialized out as xml, its value is "rainbow".</para>
        ///</summary>
        [EnumString("rainbow")]
        Rainbow,
        ///<summary>
        ///galaxy.
        ///<para>When the item is serialized out as xml, its value is "galaxy".</para>
        ///</summary>
        [EnumString("galaxy")]
        Galaxy,
        ///<summary>
        ///gold.
        ///<para>When the item is serialized out as xml, its value is "gold".</para>
        ///</summary>
        [EnumString("gold")]
        Gold,
        ///<summary>
        ///silver.
        ///<para>When the item is serialized out as xml, its value is "silver".</para>
        ///</summary>
        [EnumString("silver")]
        Silver,
        ///<summary>
        ///lava.
        ///<para>When the item is serialized out as xml, its value is "lava".</para>
        ///</summary>
        [EnumString("lava")]
        Lava,
        ///<summary>
        ///ocean.
        ///<para>When the item is serialized out as xml, its value is "ocean".</para>
        ///</summary>
        [EnumString("ocean")]
        Ocean,
        ///<summary>
        ///rosegold.
        ///<para>When the item is serialized out as xml, its value is "rosegold".</para>
        ///</summary>
        [EnumString("rosegold")]
        Rosegold,
        ///<summary>
        ///bronze.
        ///<para>When the item is serialized out as xml, its value is "bronze".</para>
        ///</summary>
        [EnumString("bronze")]
        Bronze,
    }
}