// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Packaging.Builder;
using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Features;

internal static class StrictNamespaceExtensions
{
    internal static void UseTransitionalRelationshipNamespaces(this OpenXmlPackage package, bool save = true)
    {
        var resolver = package.Features.GetNamespaceResolver();

        var foundFeature = new StrictNamespaceFeature(package, package.Features.GetRequired<IPackageSaveFeature>());
        var alteredRelationships = new Dictionary<Uri, List<PackageRelationshipBuilder>>();

        package.Features.Set<IStrictNamespaceFeature>(foundFeature);
        package.Features.Set<IPackageSaveFeature>(foundFeature);

        var relationshipFeature = package.Features.GetRequired<IRelationshipFilterFeature>();
        relationshipFeature.AddFilter(r =>
        {
            var ns = new OpenXmlNamespace(r.RelationshipType);

            if (resolver.TryGetTransitionalRelationship(ns, out var transitionalNamespace))
            {
                if (!alteredRelationships.TryGetValue(r.PartUri, out var existing))
                {
                    existing = new();
                    alteredRelationships.Add(r.PartUri, existing);
                }

                existing.Add(r);

                r.RelationshipType = transitionalNamespace.Uri;
                foundFeature.Found = true;
            }
        });

        if (save)
        {
            package.Features.Set<IPackageSaveFeature>(new UpdateStrictNamespaceFeature(package, foundFeature, alteredRelationships));
        }
    }

    private sealed class UpdateStrictNamespaceFeature : IPackageSaveFeature
    {
        private readonly OpenXmlPackage _package;
        private readonly IPackageSaveFeature _other;
        private readonly Dictionary<Uri, List<PackageRelationshipBuilder>> alteredRelationships;

        public UpdateStrictNamespaceFeature(OpenXmlPackage package, IPackageSaveFeature other, Dictionary<Uri, List<PackageRelationshipBuilder>> relationships)
        {
            _package = package;
            _other = other;
            alteredRelationships = relationships;
        }

        public bool ShouldSave => _other.ShouldSave;

        public void Save()
        {
            if (alteredRelationships.TryGetValue(OpenXmlPackage.Uri, out var list))
            {
                foreach (var toReplace in list)
                {
                    _package.Relationships.Remove(toReplace.Id);
                    _package.Relationships.Create(toReplace.TargetUri, toReplace.TargetMode, toReplace.RelationshipType, toReplace.Id);
                }

                alteredRelationships.Remove(OpenXmlPackage.Uri);
            }

            _other.Save();
        }

        public void Save(OpenXmlPart part)
        {
            if (alteredRelationships.TryGetValue(part.Uri, out var list))
            {
                foreach (var toReplace in list)
                {
                    part.Relationships.Remove(toReplace.Id);
                    part.Relationships.Create(toReplace.TargetUri, toReplace.TargetMode, toReplace.RelationshipType, toReplace.Id);
                }

                alteredRelationships.Remove(part.Uri);
            }

            _other.Save(part);
        }
    }

    private sealed class StrictNamespaceFeature : IStrictNamespaceFeature, IPackageSaveFeature
    {
        private readonly IPackageSaveFeature _otherSave;

        private OpenXmlPackage? _package;

        public StrictNamespaceFeature(OpenXmlPackage package, IPackageSaveFeature otherSave)
        {
            _package = package;
            _otherSave = otherSave;
        }

        bool IStrictNamespaceFeature.Found
        {
            get
            {
                if (_package is { } package)
                {
                    _package = null;
                    package.LoadAllParts();
                }

                return Found;
            }
        }

        public bool Found { get; set; }

        bool IPackageSaveFeature.ShouldSave => _otherSave.ShouldSave;

        void IPackageSaveFeature.Save()
        {
            if (!Found)
            {
                return;
            }

            _otherSave.Save();
        }

        void IPackageSaveFeature.Save(OpenXmlPart part)
        {
            if (Found)
            {
                // For ISO Strict documents, we read and save the part anyway to translate the contents. The contents are translated when PartRootElement is being loaded.
                if (part.PartRootElement is not null)
                {
                    part.PartRootElement.Save();
                }
            }
            else
            {
                _otherSave.Save(part);
            }
        }
    }
}
