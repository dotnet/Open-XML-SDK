// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using System.ComponentModel;

namespace DocumentFormat.OpenXml.Packaging;

/// <summary>
/// An implementation that is used to provide information for strongly typed <see cref="OpenXmlPart"/>.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public abstract partial class TypedOpenXmlPart : OpenXmlPart
{
    private protected TypedOpenXmlPart()
    {
    }
}
