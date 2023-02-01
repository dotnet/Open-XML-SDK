﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Packaging.Builder;
using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Features;

internal static class StrictNamespaceExtensions
{
    internal static void ConvertStrictRelationshipToTransitional(this OpenXmlPackage package)
    {
        var resolver = package.Features.GetNamespaceResolver();

        var alteredRelationships = new Dictionary<Uri, List<PackageRelationshipBuilder>>();

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
                package.StrictRelationshipFound = true;
            }
        });

        var packageUri = new Uri("/", UriKind.Relative);

        package.Features.GetRequired<ISaveFeature>().Register(container =>
        {
            if (alteredRelationships.Count == 0)
            {
                return;
            }

            if (container is OpenXmlPackage package)
            {
                if (alteredRelationships.TryGetValue(packageUri, out var list))
                {
                    foreach (var toReplace in list)
                    {
                        package.DeleteRelationship(toReplace.Id);
                        package.CreateRelationship(toReplace.TargetUri, toReplace.TargetMode, toReplace.RelationshipType, toReplace.Id);
                    }

                    alteredRelationships.Remove(packageUri);
                }
            }
            else if (container is OpenXmlPart part)
            {
                if (alteredRelationships.TryGetValue(part.Uri, out var list))
                {
                    foreach (var toReplace in list)
                    {
                        part.DeleteRelationship(toReplace.Id);
                        part.CreateRelationship(toReplace.TargetUri, toReplace.TargetMode, toReplace.RelationshipType, toReplace.Id);
                    }

                    alteredRelationships.Remove(part.Uri);
                }
            }
        });
    }
}
