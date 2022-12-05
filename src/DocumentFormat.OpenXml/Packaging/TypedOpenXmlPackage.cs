// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using System;
using System.ComponentModel;

namespace DocumentFormat.OpenXml.Packaging;

/// <summary>
/// An implementation of <see cref="OpenXmlPackage"/> that provides strongly-typed services.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public abstract partial class TypedOpenXmlPackage : OpenXmlPackage
{
    [Obsolete(DoNotUseParameterlessConstructor)]
    private protected TypedOpenXmlPackage()
    {
    }

    private protected TypedOpenXmlPackage(in PackageLoader package, OpenSettings settings)
        : base(package, settings)
    {
    }

    private protected abstract partial class TypedPackageFeatureCollection<TDocumentType> :
        PackageFeatureCollection,
        IMainPartFeature,
        IDocumentTypeFeature<TDocumentType>
        where TDocumentType : struct, Enum
    {
        private TDocumentType _documentType;

        protected TypedPackageFeatureCollection(TypedOpenXmlPackage package)
            : base(package, TypedFeatures.Shared)
        {
        }

        string IMainPartFeature.RelationshipType => string.Empty;

        string IMainPartFeature.ContentType
        {
            get => GetContentType(_documentType)!;
            set => _documentType = GetType(value) ?? throw new OpenXmlPackageException(ExceptionMessages.InvalidContentTypePart);
        }

        TDocumentType IDocumentTypeFeature<TDocumentType>.Type
        {
            get => _documentType;
            set => _documentType = value;
        }

        protected abstract string? GetContentType(TDocumentType type);

        protected abstract TDocumentType? GetType(string contentPart);
    }
}
