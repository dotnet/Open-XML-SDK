// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Features;

/// <summary>
/// Feature interface that defines the type of a document and allows for changing it.
/// </summary>
/// <typeparam name="TDocumentType">Type that represents the document type.</typeparam>
public interface IDocumentTypeFeature<TDocumentType>
    where TDocumentType : struct
{
    /// <summary>
    /// Gets or sets the type of the document.
    /// </summary>
    TDocumentType Current { get; set; }

    /// <summary>
    /// Gets the content type for a given document type.
    /// </summary>
    /// <param name="type">Document type.</param>
    /// <returns>The content type if known, otherwise <c>null</c></returns>
    string? GetContentType(TDocumentType type);

    /// <summary>
    /// Gets the document type for a given content type.
    /// </summary>
    /// <param name="contentPart">The content type.</param>
    /// <returns>The document type if known, otherwise <c>null</c></returns>
    TDocumentType? GetDocumentType(string contentPart);

    /// <summary>
    /// Provides logic to change one type to another. Will likely affect <see cref="Current"/>.
    /// </summary>
    /// <param name="newType">Type to change the document to.</param>
    void ChangeDocumentType(TDocumentType newType);
}
