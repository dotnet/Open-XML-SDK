// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Packaging.Builder;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

    public static void EnableUriHandling(this OpenXmlPackage package)
        => package.Features.EnableUriHandling();

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Reliability", "CA2000:Dispose objects before losing scope", Justification = "Disposable is registered with package")]
    internal static IFeatureCollection EnableUriHandling(this IFeatureCollection features)
    {
        var packageFeature = features.GetRequired<IPackageFeature>();

        if (packageFeature.Capabilities.HasFlagFast(PackageCapabilities.MalformedUri))
        {
            return features;
        }

        if (packageFeature.Package.FileOpenAccess == FileAccess.Read && !features.EnableWriteableStream())
        {
            return features;
        }

        var newFeature = new MalformedUriHandlingPackage(packageFeature);

        features.GetRequired<IRelationshipFilterFeature>().AddFilter(newFeature.Filter);
        features.Set<IPackageFeature>(newFeature);
        features.GetRequired<IDisposableFeature>().Register(newFeature);

        return features;
    }

    private static XDocument? WalkRelationships(IPackagePart part, RewrittenUriCollection uris, bool isDisposing)
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
                if (Update(child, uris, isDisposing))
                {
                    changed = true;
                }
            }
        }

        return changed ? doc : null;
    }

    private static bool Update(XElement child, RewrittenUriCollection uris, bool isDisposing)
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

        if (isDisposing)
        {
            if (uris.TryGetValue(id, out var existing) && string.Equals(existing.Rewritten, target, StringComparison.OrdinalIgnoreCase))
            {
                child.SetAttributeValue(TargetAttributeName, existing.Target);
            }
        }
        else if (target.Length > 0 && Uri.TryCreate(target, UriHelper.RelativeOrAbsolute, out _))
        {
            return false;
        }
        else
        {
            var updated = uris.Register(id, target);

            child.SetAttributeValue(TargetAttributeName, updated.Rewritten);
        }

        return true;
    }

    private sealed class MalformedUriHandlingPackage : DelegatingPackageFeature, IDisposable
    {
        private readonly Dictionary<Uri, RewrittenUriCollection?> _rewritten = new();

        public override PackageCapabilities Capabilities => base.Capabilities | PackageCapabilities.MalformedUri;

        public MalformedUriHandlingPackage(IPackageFeature package)
            : base(package)
        {
        }

        public override IPackagePart GetPart(Uri uriTarget)
             => WrapPartIfNeeded(base.GetPart(uriTarget));

        private IPackagePart WrapPartIfNeeded(IPackagePart part)
        {
            var uriTarget = part.Uri;

            if (_rewritten.ContainsKey(uriTarget))
            {
                return part;
            }

            if (!PackUriHelper.IsRelationshipPartUri(uriTarget) && PackUriHelper.GetRelationshipPartUri(uriTarget) is { } relationshipUri && PartExists(relationshipUri))
            {
                var relationshipPart = base.GetPart(relationshipUri);
                var known = new RewrittenUriCollection();

                if (WalkRelationships(relationshipPart, known, isDisposing: false) is { } doc)
                {
                    WriteStream(relationshipPart, doc);
                    _rewritten[uriTarget] = known;
                    return part;
                }
            }

            _rewritten[uriTarget] = null;
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
                yield return WrapPartIfNeeded(part);
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
                if (malformed.Value is { } uris)
                {
                    var relationshipUri = PackUriHelper.GetRelationshipPartUri(malformed.Key);
                    var relationshipPart = base.GetPart(relationshipUri);

                    if (WalkRelationships(relationshipPart, uris, isDisposing: true) is { } doc)
                    {
                        using var stream = relationshipPart.GetStream(FileMode.Create, FileAccess.Write);
                        stream.SetLength(0);
                        doc.Save(stream);
                    }
                }
            }
        }

        internal void Filter(PackageRelationshipBuilder relationship)
        {
            if (_rewritten.TryGetValue(relationship.PartUri, out var rewritten) && rewritten is not null && rewritten.TryGetValue(relationship.Id, out var known))
            {
                relationship.TargetUri = known;
            }
        }
    }

    private sealed class RewrittenUri : Uri
    {
        public RewrittenUri(string uriString, string original)
            : base(uriString)
        {
            Target = original;
        }

        public string Target { get; }

        public string Rewritten => OriginalString;

        public override string ToString() => Target;
    }

    private class RewrittenUriCollection : Dictionary<string, RewrittenUri>
    {
        public RewrittenUri Register(string id, string target)
        {
            var replacement = new RewrittenUri($"rewritten://{Guid.NewGuid()}", target);
            Add(id, replacement);
            return replacement;
        }
    }
}
