// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace DocumentFormat.OpenXml.Features;

/// <summary>
/// Feature to describe the schema elements that have been used.
/// </summary>
[Experimental(ExperimentalApis.AOT, UrlFormat = ExperimentalApis.UrlFormat)]
[Obsolete(ExperimentalApis.Message, DiagnosticId = ExperimentalApis.AOT, UrlFormat = ExperimentalApis.UrlFormat)]
internal interface ISchemaTrackingFeature
{
    /// <summary>
    /// Gets a collection of root elements that have been requested.
    /// </summary>
    ICollection<OpenXmlQualifiedName> RootElements { get; }

    /// <summary>
    /// Gets a collection of relationships that have been requested.
    /// </summary>
    ICollection<string> Relationships { get; }
}
