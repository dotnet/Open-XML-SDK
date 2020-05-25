// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Defines the SpaceProcessingModeValues enumeration.
    /// </summary>
    public enum SpaceProcessingModeValues
    {
        ///<summary>
        ///default.
        ///<para>When the item is serialized out as xml, its value is "default".</para>
        ///</summary>
        [EnumString("default")]
        Default,
        ///<summary>
        ///preserve.
        ///<para>When the item is serialized out as xml, its value is "preserve".</para>
        ///</summary>
        [EnumString("preserve")]
        Preserve,
    }
}