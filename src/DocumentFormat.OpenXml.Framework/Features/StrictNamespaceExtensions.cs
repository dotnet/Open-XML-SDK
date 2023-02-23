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

        var foundFeature = new StrictNamespaceFeature(package);
        var alteredRelationships = new Dictionary<Uri, List<PackageRelationshipBuilder>>();

        package.Features.Set<IStrictNamespaceFeature>(foundFeature);

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
            package.Features.GetRequired<ISaveFeature>().Register(container =>
            {
                if (alteredRelationships.Count == 0)
                {
                    return;
                }

                if (container is OpenXmlPackage package)
                {
                    if (alteredRelationships.TryGetValue(OpenXmlPackage.Uri, out var list))
                    {
                        foreach (var toReplace in list)
                        {
                            package.Relationships.Remove(toReplace.Id);
                            package.Relationships.Create(toReplace.TargetUri, toReplace.TargetMode, toReplace.RelationshipType, toReplace.Id);
                        }

                        alteredRelationships.Remove(OpenXmlPackage.Uri);
                    }
                }
                else if (container is OpenXmlPart part)
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
                }
            });
        }
    }

    private sealed class StrictNamespaceFeature : IStrictNamespaceFeature
    {
        private OpenXmlPackage? _package;

        public StrictNamespaceFeature(OpenXmlPackage package)
        {
            _package = package;
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
    }
}
