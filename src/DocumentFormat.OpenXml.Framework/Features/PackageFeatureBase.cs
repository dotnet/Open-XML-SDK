// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Packaging.Builder;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Features;

internal abstract class PackageFeatureBase : IPackage, IPackageFeature, IRelationshipFilterFeature
{
    private RelationshipCollection? _relationships;
    private Action<PackageRelationshipBuilder>? _relationshipFilter;
    private Dictionary<Uri, PackagePart>? _parts;

    protected PackageFeatureBase()
    {
    }

    protected abstract Package Package { get; }

    private IPackagePart GetOrCreatePart(System.IO.Packaging.PackagePart part)
    {
        if (_parts is not null && _parts.TryGetValue(part.Uri, out var existing))
        {
            Debug.Assert(existing.Part == part);
            return existing;
        }

        if (_parts is null)
        {
            _parts = new();
        }

        var newItem = new PackagePart(this, part);
        _parts[part.Uri] = newItem;
        return newItem;
    }

    protected void UpdateCachedItems()
    {
        if (_parts is null)
        {
            return;
        }

#if !NET6_0_OR_GREATER
        List<Uri>? unused = null;
#endif

        foreach (var part in _parts)
        {
            if (Package.PartExists(part.Key))
            {
                part.Value.Part = Package.GetPart(part.Key);
            }
            else
            {
#if NET6_0_OR_GREATER
                _parts.Remove(part.Key);
#else
                (unused ??= new()).Add(part.Key);
#endif
            }

#if !NET6_0_OR_GREATER
            if (unused is not null)
            {
                foreach (var uri in unused)
                {
                    _parts.Remove(uri);
                }
            }
#endif
        }
    }

    FileAccess IPackage.FileOpenAccess => Package.FileOpenAccess;

    public PackageProperties PackageProperties => Package.PackageProperties;

    IEnumerable<IPackagePart> IPackage.GetParts()
    {
        foreach (var part in Package.GetParts())
        {
            yield return GetOrCreatePart(part);
        }
    }

    IPackagePart IPackage.GetPart(Uri uriTarget) => GetOrCreatePart(Package.GetPart(uriTarget));

    bool IPackage.PartExists(Uri partUri) => Package.PartExists(partUri);

    void IPackage.Save() => Package.Flush();

    public IPackagePart CreatePart(Uri partUri, string contentType, CompressionOption compressionOption) => GetOrCreatePart(Package.CreatePart(partUri, contentType, compressionOption));

    public void DeletePart(Uri uri)
    {
        _parts?.Remove(uri);
        Package.DeletePart(uri);
    }

    IPackage IPackageFeature.Package => this;

    public virtual PackageCapabilities Capabilities
    {
        get
        {
            // ZipArchive.Flush only exists on .NET Framework (https://github.com/dotnet/runtime/issues/24149)
#if NETFRAMEWORK
            var canSave = Package.FileOpenAccess.HasFlagFast(FileAccess.Write) ? PackageCapabilities.Save : PackageCapabilities.None;
            var uriSupport = GetSupportsMalformedUri() ? PackageCapabilities.MalformedUri : PackageCapabilities.None;

            return canSave | uriSupport | PackageCapabilities.Cached | PackageCapabilities.LargePartStreams;
#else
            return PackageCapabilities.Cached;
#endif
        }
    }

    IRelationshipCollection IPackage.Relationships => _relationships ??= new PackageRelationshipCollection(this);

#if NETFRAMEWORK
    private static bool GetSupportsMalformedUri()
        => Uri.TryCreate("mailto:one@", UriKind.RelativeOrAbsolute, out _);
#endif

    public virtual void Reload(FileMode? mode = null, FileAccess? access = null)
        => throw new NotSupportedException();

    internal void RunFilter(PackageRelationshipBuilder relationship) => _relationshipFilter?.Invoke(relationship);

    void IRelationshipFilterFeature.AddFilter(Action<PackageRelationshipBuilder> action)
        => _relationshipFilter += action;

    private sealed class PackagePart : IPackagePart
    {
        private readonly PartRelationshipCollection _relationships;

        public PackagePart(PackageFeatureBase package, System.IO.Packaging.PackagePart part)
        {
            _relationships = new(package, part.Uri);

            Part = part;
        }

        public System.IO.Packaging.PackagePart Part { get; set; }

        IPackage IPackagePart.Package => _relationships.Feature;

        public Uri Uri => Part.Uri;

        public string ContentType => Part.ContentType;

        public IRelationshipCollection Relationships => _relationships;

        public IReadOnlyCollection<IPackageRelationship> GetRelationships() => _relationships;

        public Stream GetStream(FileMode open, FileAccess write)
            => Part.GetStream(open, write);
    }

    private sealed class PackageRelationshipCollection : RelationshipCollection
    {
        public PackageRelationshipCollection(PackageFeatureBase feature)
            : base(feature)
        {
        }

        protected override Uri Uri => OpenXmlPackage.Uri;

        protected override PackageRelationship CreateRelationshipInternal(Uri targetUri, TargetMode targetMode, string relationshipType, string? id = null)
            => Feature.Package.CreateRelationship(targetUri, targetMode, relationshipType, id);

        protected override void Delete(string id)
            => Feature.Package.DeleteRelationship(id);

        protected override IEnumerable<PackageRelationship> GetRelationships()
            => Feature.Package.GetRelationships();
    }

    private sealed class PartRelationshipCollection : RelationshipCollection
    {
        public PartRelationshipCollection(PackageFeatureBase feature, Uri uri)
            : base(feature)
        {
            Uri = uri;
        }

        protected override Uri Uri { get; }

        protected override PackageRelationship CreateRelationshipInternal(Uri targetUri, TargetMode targetMode, string relationshipType, string? id = null)
            => Feature.Package.GetPart(Uri).CreateRelationship(targetUri, targetMode, relationshipType, id);

        protected override void Delete(string id)
            => Feature.Package.GetPart(Uri).DeleteRelationship(id);

        protected override IEnumerable<PackageRelationship> GetRelationships()
            => Feature.Package.GetPart(Uri).GetRelationships();
    }

    private abstract class RelationshipCollection : IRelationshipCollection
    {
        private Dictionary<string, PackageRelationshipBuilder>? _relationships;

        public RelationshipCollection(PackageFeatureBase feature)
        {
            Feature = feature;
        }

        private Dictionary<string, PackageRelationshipBuilder> Relationships
        {
            get
            {
                Load();

                return _relationships;
            }
        }

        [MemberNotNull(nameof(_relationships))]
        private void Load()
        {
            if (_relationships is null)
            {
                _relationships = new Dictionary<string, PackageRelationshipBuilder>();

                foreach (var relationship in GetRelationships())
                {
                    var wrapped = new PackageRelationshipBuilder(Uri, relationship);
                    Feature.RunFilter(wrapped);

                    if (!wrapped.IsRemoved)
                    {
                        _relationships.Add(wrapped.Id, wrapped);
                    }
                }
            }
        }

        protected abstract Uri Uri { get; }

        protected abstract IEnumerable<PackageRelationship> GetRelationships();

        protected abstract void Delete(string id);

        protected abstract PackageRelationship CreateRelationshipInternal(Uri targetUri, TargetMode targetMode, string relationshipType, string? id = null);

        public IPackageRelationship Create(Uri targetUri, TargetMode targetMode, string relationshipType, string? id = null)
        {
            Load();

            var relationship = new PackageRelationshipBuilder(Uri, CreateRelationshipInternal(targetUri, targetMode, relationshipType, id));
            Relationships.Add(relationship.Id, relationship);
            return relationship;
        }

        public void Remove(string id)
        {
            Relationships.Remove(id);
            Delete(id);
        }

        public IPackageRelationship this[string id]
            => Relationships.TryGetValue(id, out var existing) ? existing : throw new InvalidOperationException();

        public bool Contains(string id)
            => Relationships.ContainsKey(id);

        public IEnumerator<IPackageRelationship> GetEnumerator()
        {
            foreach (var item in Relationships.Values)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public PackageFeatureBase Feature { get; }

        public int Count => Relationships.Count;
    }
}
