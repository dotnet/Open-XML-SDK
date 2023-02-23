// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using System;
using System.ComponentModel;
using System.IO;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Packaging;

/// <summary>
/// An implementation of <see cref="OpenXmlPackage"/> that provides strongly-typed services.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public abstract partial class TypedOpenXmlPackage : OpenXmlPackage
{
    private protected TypedOpenXmlPackage()
        : base()
    {
    }

    private protected abstract partial class TypedPackageFeatureCollection<TDocumentType, TMainPart> :
        PackageFeatureCollection,
        IMainPartFeature,
        IDocumentTypeFeature<TDocumentType>,
        IKnownDataPartFeature
        where TDocumentType : struct, Enum
        where TMainPart : OpenXmlPart
    {
        private TDocumentType? _documentType;

        protected TypedPackageFeatureCollection(TypedOpenXmlPackage package)
            : base(package, TypedFeatures.Shared)
        {
        }

        string IMainPartFeature.RelationshipType => RelationshipType;

        string IMainPartFeature.ContentType
        {
            get
            {
                if (_documentType is null)
                {
                    var hasRelationships = false;
                    var package = this.GetRequired<IPackageFeature>().Package;

                    foreach (var relationship in package.Relationships)
                    {
                        hasRelationships = true;
                        if (relationship.RelationshipType == RelationshipType)
                        {
                            var uriTarget = PackUriHelper.ResolvePartUri(OpenXmlPackage.Uri, relationship.TargetUri);
                            var metroPart = package.GetPart(uriTarget);

                            _documentType = GetType(metroPart.ContentType);
                            break;
                        }
                    }

                    if (!hasRelationships)
                    {
                        _documentType = default;
                    }

                    if (_documentType is null)
                    {
                        throw new OpenXmlPackageException(ExceptionMessages.NoMainPart);
                    }
                }

                return GetContentType(_documentType.Value)!;
            }
        }

        TDocumentType IDocumentTypeFeature<TDocumentType>.Type
        {
            get => _documentType ?? default;
            set => _documentType = value;
        }

        protected TMainPart? MainPart => Package.GetSubPartOfType<TMainPart>();

        OpenXmlPart? IMainPartFeature.Part => MainPart;

        void IDocumentTypeFeature<TDocumentType>.ChangeDocumentType(TDocumentType newType)
        {
            if (newType.Equals(_documentType))
            {
                // same type, just return
                return;
            }

            if (Package.FileOpenAccess == FileAccess.Read)
            {
                throw new IOException(ExceptionMessages.PackageAccessModeIsReadonly);
            }

            var oldType = _documentType;
            _documentType = newType;

            if (MainPart is null)
            {
                return;
            }

            try
            {
                Package.ChangeDocumentTypeInternal(CreateMainPart());
            }
            catch (OpenXmlPackageException e)
            {
                if (e.Message == ExceptionMessages.CannotChangeDocumentType)
                {
                    _documentType = oldType;
                }

                throw;
            }
        }

        protected abstract string RelationshipType { get; }

        protected abstract string? GetContentType(TDocumentType type);

        protected abstract TDocumentType? GetType(string contentPart);

        protected abstract TMainPart CreateMainPart();

        bool IKnownDataPartFeature.IsKnown(string relationshipId) => false;
    }
}
