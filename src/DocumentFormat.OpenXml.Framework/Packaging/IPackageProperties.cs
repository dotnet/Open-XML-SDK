// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics.CodeAnalysis;

namespace DocumentFormat.OpenXml.Packaging;

/// <summary>
/// An abstraction of package properties, similar to <see cref="System.IO.Packaging.PackageProperties"/>.
/// </summary>
[Experimental(ExperimentalApis.IPackage, UrlFormat = ExperimentalApis.UrlFormat)]
public interface IPackageProperties
{
    /// <summary>
    /// Gets or sets the title.
    /// </summary>
    string? Title { get; set; }

    /// <summary>
    /// Gets or sets the topic of the contents.
    /// </summary>
    string? Subject { get; set; }

    /// <summary>
    /// Gets or sets the primary creator. The identification is environment-specific and
    /// can consist of a name, email address, employee ID, etc. It is
    /// recommended that this value be only as verbose as necessary to
    /// identify the individual.
    /// </summary>
    string? Creator { get; set; }

    /// <summary>
    /// Gets or sets a delimited set of keywords to support searching and indexing. This
    /// is typically a list of terms that are not available elsewhere in the
    /// properties.
    /// </summary>
    string? Keywords { get; set; }

    /// <summary>
    /// Gets or sets the description or abstract of the contents.
    /// </summary>
    string? Description { get; set; }

    /// <summary>
    /// Gets or sets the user who performed the last modification. The identification is
    /// environment-specific and can consist of a name, email address,
    /// employee ID, etc. It is recommended that this value be only as
    /// verbose as necessary to identify the individual.
    /// </summary>
    string? LastModifiedBy { get; set; }

    /// <summary>
    /// Gets or sets the revision number. This value indicates the number of saves or
    /// revisions. The application is responsible for updating this value
    /// after each revision.
    /// </summary>
    string? Revision { get; set; }

    /// <summary>
    /// Gets or sets the date and time of the last printing.
    /// </summary>
    DateTime? LastPrinted { get; set; }

    /// <summary>
    /// Gets or sets the creation date and time.
    /// </summary>
    DateTime? Created { get; set; }

    /// <summary>
    /// Gets or sets the date and time of the last modification.
    /// </summary>
    DateTime? Modified { get; set; }

    /// <summary>
    /// Gets or sets the category.
    /// </summary>
    string? Category { get; set; }

    /// <summary>
    /// Gets or sets a unique identifier.
    /// </summary>
    string? Identifier { get; set; }

    /// <summary>
    /// Gets or sets the type of content represented, generally defined by a specific
    /// use and intended audience. Example values include "Whitepaper",
    /// "Security Bulletin", and "Exam". (This property is distinct from
    /// MIME content types as defined in RFC 2045.)
    /// </summary>
    string? ContentType { get; set; }

    /// <summary>
    /// Gets or sets the primary language of the package content. The language tag is
    /// composed of one or more parts: A primary language subtag and a
    /// (possibly empty) series of subsequent subtags, for example, "EN-US".
    /// These values MUST follow the convention specified in RFC 3066.
    /// </summary>
    string? Language { get; set; }

    /// <summary>
    /// Gets or sets the version number. This value is set by the user or by the application.
    /// </summary>
    string? Version { get; set; }

    /// <summary>
    /// Gets or sets the status of the content. Example values include "Draft", "Reviewed", and "Final".
    /// </summary>
    string? ContentStatus { get; set; }
}
