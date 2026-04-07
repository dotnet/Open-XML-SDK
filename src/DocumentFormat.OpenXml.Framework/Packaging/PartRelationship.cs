// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#if NETSTANDARD || NETCOREAPP

using System;
using System.Diagnostics.CodeAnalysis;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Packaging;

/// <summary>
/// Describes a relationship to be added to a part when using <see cref="OpenXmlPackageWriter.WritePart"/>.
/// </summary>
[Experimental(ExperimentalApis.ForwardOnly, UrlFormat = ExperimentalApis.UrlFormat)]
[Obsolete(ExperimentalApis.Message, DiagnosticId = ExperimentalApis.ForwardOnly, UrlFormat = ExperimentalApis.UrlFormat)]
[System.Diagnostics.CodeAnalysis.SuppressMessage("Performance", "CA1815:Override equals and operator equals on value types", Justification = "Data carrier struct not intended for comparison")]
public readonly struct PartRelationship
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PartRelationship"/> struct.
    /// </summary>
    /// <param name="targetUri">The target URI.</param>
    /// <param name="relationshipType">The relationship type.</param>
    /// <param name="targetMode">The target mode (Internal or External).</param>
    /// <param name="id">Optional explicit relationship ID.</param>
    public PartRelationship(Uri targetUri, string relationshipType, TargetMode targetMode = TargetMode.Internal, string? id = null)
    {
        TargetUri = targetUri;
        RelationshipType = relationshipType;
        TargetMode = targetMode;
        Id = id;
    }

    /// <summary>
    /// Gets the target URI.
    /// </summary>
    public Uri TargetUri { get; }

    /// <summary>
    /// Gets the relationship type.
    /// </summary>
    public string RelationshipType { get; }

    /// <summary>
    /// Gets the target mode.
    /// </summary>
    public TargetMode TargetMode { get; }

    /// <summary>
    /// Gets the optional explicit relationship ID.
    /// </summary>
    public string? Id { get; }
}

#endif
