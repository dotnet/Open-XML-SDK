// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;

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
 
 
