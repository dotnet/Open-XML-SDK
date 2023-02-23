﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;

namespace DocumentFormat.OpenXml.Features;

internal interface IMainPartFeature
{
    string RelationshipType { get; }

    string ContentType { get; }

    OpenXmlPart? Part { get; }
}
