// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Features;

/// <summary>
/// Feature interface that defines the type of a document and allows for changing it.
/// </summary>
/// <typeparam name="T">Type that represents the document type.</typeparam>
public interface IDocumentTypeFeature<T>
    where T : struct
{
    /// <summary>
    /// Gets or sets the type of the document.
    /// </summary>
    T Type { get; set; }

    /// <summary>
    /// Provides logic to change one type to another. Will likely affect <see cref="Type"/>.
    /// </summary>
    /// <param name="newType">Type to change the document to.</param>
    void ChangeDocumentType(T newType);
}
