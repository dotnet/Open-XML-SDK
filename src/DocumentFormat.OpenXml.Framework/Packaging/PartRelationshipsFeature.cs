// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Packaging;

internal sealed class PartRelationshipsFeature :
    IPartRelationshipsFeature,
    IReferenceRelationshipsFeature
{
    private readonly OpenXmlPartContainer _owner;

    private Dictionary<string, OpenXmlPart>? _parts;
    private Dictionary<string, ReferenceRelationship>? _referenceRelationships;

    public PartRelationshipsFeature(OpenXmlPartContainer owner)
    {
        _owner = owner;
    }

    private IPartEventsFeature? Events => _owner.Features.Get<IPartEventsFeature>();

    IEnumerable<OpenXmlPart> IPartRelationshipsFeature.Parts => RelationshipMap.Values;

    private IDataPartsFeature LoadedDataParts => _owner.Features.GetRequired<IDataPartsFeature>();

    private IPartsFeature LoadedParts => _owner.Features.GetRequired<IPartsFeature>();

    void IPartRelationshipsFeature.Add(OpenXmlPart part, string? id)
    {
        var loaded = LoadedParts;

        if (!loaded.Contains(part.Uri))
        {
            loaded.Add(part.Uri, part);
        }

        if (id is null || !_owner.Relationships.Contains(id))
        {
            var relationship = _owner.Relationships.Create(part.Uri, TargetMode.Internal, part.RelationshipType, id);
            id = relationship.Id;
        }

        Events?.OnChange(part, EventType.Creating);

        RelationshipMap[id] = part;

        Events?.OnChange(part, EventType.Created);
    }

    private void Add(Dictionary<string, OpenXmlPart> parts, string uri, OpenXmlPart part)
    {
        Events?.OnChange(part, EventType.Creating);

        parts.Add(uri, part);

        Events?.OnChange(part, EventType.Created);
    }

    void IPartRelationshipsFeature.Clear()
    {
        if (Events is IPartEventsFeature events)
        {
            // On .NET 5.0 and later, we can remove keys while enumerating. Before that, it would throw at runtime.
#if NET5_0_OR_GREATER
            foreach (var kv in RelationshipMap)
            {
                events.OnChange(kv.Value, EventType.Removing);
                RelationshipMap.Remove(kv.Key);
                events.OnChange(kv.Value, EventType.Removed);
            }
#else
            var parts = RelationshipMap;

            foreach (var kv in parts)
            {
                events.OnChange(kv.Value, EventType.Removing);
                events.OnChange(kv.Value, EventType.Removed);
            }
#endif
        }

        RelationshipMap.Clear();
    }

    int IPartRelationshipsFeature.Count => RelationshipMap.Count;

    bool IPartRelationshipsFeature.Contains(OpenXmlPart part) => RelationshipMap.ContainsValue(part);

    bool IPartRelationshipsFeature.Contains(string id) => RelationshipMap.ContainsKey(id);

    bool IPartRelationshipsFeature.TryGetPart(string id, [MaybeNullWhen(false)] out OpenXmlPart part)
        => RelationshipMap.TryGetValue(id, out part);

    private Dictionary<string, OpenXmlPart> RelationshipMap
    {
        get
        {
            if (_parts is null)
            {
                LoadReferencedPartsAndRelationships();
            }

            return _parts;
        }
    }

    public IEnumerator<KeyValuePair<string, OpenXmlPart>> GetEnumerator() => RelationshipMap.GetEnumerator();

    void IPartRelationshipsFeature.Remove(string id)
    {
        if (RelationshipMap.TryGetValue(id, out var part))
        {
            _owner.Relationships.Remove(id);

            Events?.OnChange(part, EventType.Removing);
            RelationshipMap.Remove(id);
            Events?.OnChange(part, EventType.Removed);
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    [MemberNotNull(nameof(_parts))]
    [MemberNotNull(nameof(_referenceRelationships))]
    internal void LoadReferencedPartsAndRelationships()
    {
        if (_referenceRelationships is not null && _parts is not null)
        {
            return;
        }

        var openXmlPackage = _owner.InternalOpenXmlPackage;
        var sourcePart = _owner as OpenXmlPart;
        var partLookup = LoadedParts;

        _referenceRelationships = new(StringComparer.Ordinal);
        _parts = new(StringComparer.Ordinal);

        var relationships = sourcePart?.Relationships ?? openXmlPackage.Relationships;

        foreach (var relationship in relationships)
        {
            if (relationship.RelationshipType == HyperlinkRelationship.RelationshipTypeConst)
            {
                // Fix bug #517956 - both internal and external hyperlinks should be loaded as HyperlinkRelationship.
                _referenceRelationships.Add(relationship.Id, new HyperlinkRelationship(relationship.TargetUri, relationship.TargetMode == TargetMode.External ? true : false, relationship.Id) { Container = _owner });
            }
            else
            {
                if (relationship.TargetMode == TargetMode.Internal)
                {
                    if (!relationship.TargetUri.ToString().Equals("NULL", StringComparison.OrdinalIgnoreCase))
                    {
                        // Resolve the Relationship Target Uri
                        //   so the Document Part can be retrieved.

                        // when sourcePart is null, use the package root as sourceUri.
                        var sourceUri = sourcePart is null ? new Uri("/", UriKind.Relative) : sourcePart.Uri;
                        var uriTarget = PackUriHelper.ResolvePartUri(sourceUri, relationship.TargetUri);

                        if (partLookup.TryGetPart(uriTarget, out var child))
                        {
                            // shared part, already loaded

                            // shared part should have same relationship type
                            if (child.RelationshipType != relationship.RelationshipType)
                            {
                                throw new OpenXmlPackageException(ExceptionMessages.SamePartWithDifferentRelationshipType);
                            }

                            Add(_parts, relationship.Id, child);
                        }
                        else if (DataPartReferenceRelationship.IsDataPartReferenceRelationship(relationship.RelationshipType))
                        {
                            var loaded = LoadedDataParts;

                            if (!loaded.TryGetDataPart(uriTarget, out var dataPart))
                            {
                                // Load the part as MediaDataPart.
                                var packagePart = openXmlPackage.Package.GetPart(uriTarget);
                                dataPart = new MediaDataPart(openXmlPackage, packagePart);
                                loaded.Add(dataPart);
                            }

                            // Already loaded data part. Create reference relationship.
                            var referenceRelationship = DataPartReferenceRelationship.Create(_owner, dataPart, relationship.RelationshipType, relationship.Id);
                            _referenceRelationships.Add(relationship.Id, referenceRelationship);
                        }
                        else
                        {
                            child = CreateOpenXmlPart(relationship.RelationshipType);
                            child.MCSettings = openXmlPackage.MarkupCompatibilityProcessSettings;

                            // add it to loaded part list
                            partLookup.Add(uriTarget, child);

                            child.Load(openXmlPackage, sourcePart, uriTarget, relationship.Id);

                            Add(_parts, relationship.Id, child);
                        }
                    }
                }
                else
                {
                    _referenceRelationships.Add(relationship.Id, new ExternalRelationship(relationship.TargetUri, relationship.RelationshipType, relationship.Id) { Container = _owner });
                }
            }
        }
    }

    private OpenXmlPart CreateOpenXmlPart(string relationshipType)
        => _owner.Features.GetRequired<IPartFactoryFeature>().Create(relationshipType) ?? new ExtendedPart(relationshipType);

    private Dictionary<string, ReferenceRelationship> ReferenceRelationships
    {
        get
        {
            if (_referenceRelationships is null)
            {
                LoadReferencedPartsAndRelationships();
            }

            return _referenceRelationships;
        }
    }

    bool IReferenceRelationshipsFeature.Remove(string id)
        => DeleteRelationship(id);

    bool IReferenceRelationshipsFeature.TryGetRelationship(string id, [MaybeNullWhen(false)] out ReferenceRelationship relationship)
        => ReferenceRelationships.TryGetValue(id, out relationship);

    HyperlinkRelationship IReferenceRelationshipsFeature.CreateHyperLink(Uri uri, bool isExternal, string? id)
    {
        LoadReferencedPartsAndRelationships();

        var relationship = CreateRelationship(HyperlinkRelationship.RelationshipTypeConst, uri, isExternal ? TargetMode.External : TargetMode.Internal, id);
        var hyperlink = new HyperlinkRelationship(relationship.TargetUri, isExternal, relationship.Id)
        {
            Container = _owner,
        };
        _referenceRelationships.Add(hyperlink.Id, hyperlink);
        return hyperlink;
    }

    IEnumerable<ReferenceRelationship> IReferenceRelationshipsFeature.Relationships => ReferenceRelationships.Values;

    ExternalRelationship IReferenceRelationshipsFeature.CreateExternalRelationship(string relationshipType, Uri externalUri, string? id)
    {
        LoadReferencedPartsAndRelationships();

        var relationship = CreateRelationship(relationshipType, externalUri, TargetMode.External, id);
        var external = new ExternalRelationship(relationship.TargetUri, relationship.RelationshipType, relationship.Id)
        {
            Container = _owner,
        };

        _referenceRelationships.Add(external.Id, external);
        return external;
    }

    private IPackageRelationship CreateRelationship(string relationshipType, Uri externalUri, TargetMode mode, string? id)
    {
        if (_owner is OpenXmlPart part)
        {
            return part.Features.GetRequired<IPackagePartFeature>().Part.Relationships.Create(externalUri, mode, relationshipType, id);
        }
        else if (_owner is OpenXmlPackage package)
        {
            return package.Features.GetRequired<IPackageFeature>().Package.Relationships.Create(externalUri, mode, relationshipType, id);
        }
        else
        {
            throw new InvalidOperationException();
        }
    }

    private bool DeleteRelationship(string id)
    {
        if (ReferenceRelationships.TryGetValue(id, out var existing))
        {
            ReferenceRelationships.Remove(id);
            existing.Container = null;

            if (_owner is OpenXmlPart part)
            {
                part.Features.GetRequired<IPackagePartFeature>().Part.Relationships.Remove(id);
                return true;
            }
            else if (_owner is OpenXmlPackage package)
            {
                package.Features.GetRequired<IPackageFeature>().Package.Relationships.Remove(id);
                return true;
            }
        }

        return false;
    }

    DataPartReferenceRelationship IReferenceRelationshipsFeature.CreateDataPartRelationship(string relationshipType, DataPart dataPart, string? id)
    {
        LoadReferencedPartsAndRelationships();

        var relationship = CreateRelationship(relationshipType, dataPart.Uri, TargetMode.Internal, id);
        var dataPartRelationship = DataPartReferenceRelationship.Create(_owner, dataPart, relationshipType, relationship.Id);
        _referenceRelationships.Add(dataPartRelationship.Id, dataPartRelationship);
        return dataPartRelationship;
    }
}
