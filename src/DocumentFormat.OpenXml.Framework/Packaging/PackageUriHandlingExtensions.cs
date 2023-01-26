// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Packaging.Builder;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.IO.Packaging;
using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Packaging;

internal static class PackageUriHandlingExtensions
{
    private const string RelationshipsTagName = "Relationships";
    private const string RelationshipTagName = "Relationship";
    private const string RelationshipNamespaceUri = "http://schemas.openxmlformats.org/package/2006/relationships";
    private const string TargetAttributeName = "Target";
    private const string TargetModeAttributeName = "TargetMode";
    private const string IdAttributeName = "Id";

    internal static IFeatureCollection EnableUriHandling(this IFeatureCollection features)
    {
        var feature = features.GetRequired<IPackageFeature>();

        if (feature.Capabilities.HasFlagFast(PackageCapabilities.MalformedUri))
        {
            return features;
        }

        if (feature.Package.FileOpenAccess == FileAccess.Read)
        {
            if (features.EnableWriteableStream())
            {
                // Don't register for disposal as we don't want it to write out to the temporary stream
                features.Set<IPackageFeature>(new MalformedUriHandlingPackage(feature));
            }
        }
        else
        {
            var newFeature = new MalformedUriHandlingPackage(feature);

            features.Set<IPackageFeature>(newFeature);
            features.GetRequired<IDisposableFeature>().Register(newFeature);
        }

        return features;
    }

    private static XDocument? WalkRelationships(IPackagePart part, KnownUris uris)
    {
        using var stream = part.GetStream(FileMode.Open, FileAccess.Read);
        using var reader = new StreamReader(stream);

        var doc = XDocument.Load(reader);
        var changed = false;

        if (doc.Root is null)
        {
            return null;
        }

        if (string.Equals(RelationshipsTagName, doc.Root.Name.LocalName, StringComparison.Ordinal)
            && string.Equals(RelationshipNamespaceUri, doc.Root.Name.Namespace.NamespaceName, StringComparison.Ordinal))
        {
            foreach (var child in doc.Root.Descendants(XName.Get(RelationshipTagName, RelationshipNamespaceUri)))
            {
                if (Update(child, uris))
                {
                    changed = true;
                }
            }
        }

        return changed ? doc : null;
    }

    private static bool Update(XElement child, KnownUris uris)
    {
        if (!EnumHelper.TryParse<TargetMode>(child.Attribute(TargetModeAttributeName)?.Value, out var targetMode))
        {
            return false;
        }

        if (targetMode != TargetMode.External)
        {
            return false;
        }

        var target = child.Attribute(TargetAttributeName)?.Value ?? string.Empty;
        var id = child.Attribute(IdAttributeName)?.Value;

        if (id.IsNullOrEmpty())
        {
            return false;
        }

        // if it already exists, we're writing things back out
        if (uris.TryGetValue(id, out var existing) && string.Equals(existing.Replacement, target, StringComparison.OrdinalIgnoreCase))
        {
            child.SetAttributeValue(TargetAttributeName, existing.Original);
        }
        else if (target.Length > 0 && Uri.TryCreate(target, UriHelper.RelativeOrAbsolute, out _))
        {
            return false;
        }
        else
        {
            var updated = uris.Register(id, target);

            Debug.Assert(Uri.TryCreate(updated, UriHelper.RelativeOrAbsolute, out _));

            child.SetAttributeValue(TargetAttributeName, updated);
        }

        return true;
    }

    private sealed class MalformedUriHandlingPackage : DelegatingPackageFeature, IDisposable
    {
        private readonly Dictionary<Uri, IPackagePart> _rewritten = new();

        public override PackageCapabilities Capabilities => base.Capabilities | PackageCapabilities.MalformedUri;

        public MalformedUriHandlingPackage(IPackageFeature package)
            : base(package)
        {
        }

        public override IPackagePart GetPart(Uri uriTarget)
            => WrapPartIfNeeded(uriTarget);

        private IPackagePart WrapPartIfNeeded(Uri uriTarget, IPackagePart? part = null)
        {
            if (_rewritten.TryGetValue(uriTarget, out var existing))
            {
                return existing;
            }

            if (part is null)
            {
                part = base.GetPart(uriTarget);
            }

            if (!PackUriHelper.IsRelationshipPartUri(uriTarget) && PackUriHelper.GetRelationshipPartUri(uriTarget) is { } relationshipUri && PartExists(relationshipUri))
            {
                var relationshipPart = base.GetPart(relationshipUri);
                var known = new KnownUris();

                if (WalkRelationships(relationshipPart, known) is { } doc)
                {
                    WriteStream(relationshipPart, doc);

                    var handled = new MalformedUriPackagePart(this, part, known);
                    _rewritten[uriTarget] = handled;
                    return handled;
                }
            }

            _rewritten[uriTarget] = part;
            return part;
        }

        private void WriteStream(IPackagePart relationshipPart, XDocument doc)
        {
            var canWrite = Package.FileOpenAccess.HasFlagFast(FileAccess.Write);

            if (!canWrite)
            {
                Reload(access: FileAccess.ReadWrite);
            }

            using (var stream = relationshipPart.GetStream(FileMode.Create, FileAccess.Write))
            {
                stream.SetLength(0);
                doc.Save(stream);
            }

            if (!canWrite)
            {
                Reload();
            }
        }

        public override void DeletePart(Uri uri)
        {
            _rewritten.Remove(uri);
            base.DeletePart(uri);
        }

        public override IEnumerable<IPackagePart> GetParts()
        {
            foreach (var part in base.GetParts())
            {
                yield return WrapPartIfNeeded(part.Uri, part);
            }
        }

        void IDisposable.Dispose()
        {
            if (Package.FileOpenAccess == FileAccess.Read)
            {
                return;
            }

            foreach (var malformed in _rewritten)
            {
                if (malformed.Value is MalformedUriPackagePart part)
                {
                    var relationshipUri = PackUriHelper.GetRelationshipPartUri(malformed.Key);
                    var relationshipPart = base.GetPart(relationshipUri);

                    if (WalkRelationships(relationshipPart, part.Known) is { } doc)
                    {
                        using var stream = relationshipPart.GetStream(FileMode.Create, FileAccess.Write);
                        stream.SetLength(0);
                        doc.Save(stream);
                    }
                }
            }
        }

        private sealed class MalformedUriPackagePart : DelegatingPackagePart
        {
            public MalformedUriPackagePart(IPackage package, IPackagePart part, KnownUris known)
                : base(package, part)
            {
                Known = known;
            }

            public KnownUris Known { get; }

            public override IPackageRelationship GetRelationship(string id)
                => Normalize(base.GetRelationship(id));

            private IPackageRelationship Normalize(IPackageRelationship relationship)
            {
                if (Known.TryGetValue(relationship.Id, out var replaced))
                {
                    return new MalformedRelationship(relationship, replaced.Original);
                }

                return relationship;
            }

            public override IEnumerable<IPackageRelationship> GetRelationships()
            {
                foreach (var relationship in base.GetRelationships())
                {
                    yield return Normalize(relationship);
                }
            }

            private sealed class MalformedUri : Uri
            {
                private readonly string _original;

                public MalformedUri(string uriString, string original)
                    : base(uriString)
                {
                    _original = original;
                }

                public override string ToString() => _original;
            }

            private sealed class MalformedRelationship : IPackageRelationship
            {
                private readonly IPackageRelationship _other;

                public MalformedRelationship(IPackageRelationship other, string actualUri)
                {
                    _other = other;
                    TargetUri = new MalformedUri(other.TargetUri.ToString(), actualUri);
                }

                public string Id => _other.Id;

                public string RelationshipType => _other.RelationshipType;

                public Uri SourceUri => _other.SourceUri;

                public TargetMode TargetMode => _other.TargetMode;

                public Uri TargetUri { get; }
            }
        }
    }

    private class KnownUris : Dictionary<string, ReplacedUri>
    {
        public string Register(string id, string target)
        {
            var registered = new ReplacedUri(target);
            Add(id, registered);
            return registered.Replacement;
        }
    }

    private readonly struct ReplacedUri : IEquatable<ReplacedUri>
    {
        public ReplacedUri(string original)
        {
            Replacement = $"scheme://{Guid.NewGuid()}";
            Original = original;
        }

        public string Original { get; }

        public string Replacement { get; }

        public override int GetHashCode()
        {
            var h = default(HashCode);

            h.Add(Original, StringComparer.OrdinalIgnoreCase);
            h.Add(Replacement, StringComparer.OrdinalIgnoreCase);

            return h.ToHashCode();
        }

        public override bool Equals([NotNullWhen(true)] object? obj)
            => obj is ReplacedUri key && Equals(key);

        public bool Equals(ReplacedUri other)
            => Original.Equals(other.Original) && string.Equals(Replacement, other.Replacement, StringComparison.OrdinalIgnoreCase);
    }
}
