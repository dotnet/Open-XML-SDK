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
                // Load every relationship before the first container is saved, whichever container that is. Otherwise a
                // relationship that is loaded later in the save is recorded after its container was already saved, and
                // keeps its Strict type.
                foundFeature.EnsureAllPartsLoaded();

                if (alteredRelationships.Count == 0)
                {
                    return;
                }

                if (container is OpenXmlPackage package)
                {
                    if (alteredRelationships.TryGetValue(OpenXmlPackage.Uri, out var list))
                    {
                        ReplaceRelationships(package.Relationships, list);
                        alteredRelationships.Remove(OpenXmlPackage.Uri);
                    }
                }
                else if (container is OpenXmlPart part)
                {
                    if (alteredRelationships.TryGetValue(part.Uri, out var list))
                    {
                        ReplaceRelationships(part.Relationships, list);
                        alteredRelationships.Remove(part.Uri);
                    }
                }
            });
        }
    }

    private static void ReplaceRelationships(IRelationshipCollection relationships, List<PackageRelationshipBuilder> list)
    {
        foreach (var toReplace in list)
        {
            // A relationship hidden by an ignore filter is never in the collection, so it cannot have been removed
            // through it, and it is still in the package. Rewrite it as before.
            //
            // Any other relationship may have been removed since the package was opened (for example, its part was
            // deleted), or its id may now belong to a new relationship. Only rewrite the relationship that was
            // translated on load.
            if (!toReplace.IsRemoved
                && (!relationships.Contains(toReplace.Id) || !ReferenceEquals(relationships[toReplace.Id], toReplace)))
            {
                continue;
            }

            relationships.Remove(toReplace.Id);
            relationships.Create(toReplace.TargetUri, toReplace.TargetMode, toReplace.RelationshipType, toReplace.Id);
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
                EnsureAllPartsLoaded();

                return Found;
            }
        }

        public bool Found { get; set; }

        /// <summary>
        /// Loads every part, and so every relationship, the first time it is called. Later calls do nothing.
        /// </summary>
        public void EnsureAllPartsLoaded()
        {
            if (_package is { } package)
            {
                _package = null;
                package.LoadAllParts();
            }
        }
    }
}
