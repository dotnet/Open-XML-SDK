// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using System;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines the interface for tagging a part that can add extensible parts.
    /// </summary>
    /// <typeparam name="TPart">Extensible part type that is supported by the implementing class.</typeparam>
#pragma warning disable CA1040 // Avoid empty interfaces
    public interface ISupportedRelationship<TPart>
#pragma warning restore CA1040 // Avoid empty interfaces
        where TPart : OpenXmlPart
    {
    }
}
