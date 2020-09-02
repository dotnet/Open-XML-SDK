// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.IO;
using System.IO.Packaging;
using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// A class that holds information about invalid relationships in <see cref="PackagePart"/> instances.
    /// </summary>
    public abstract class RelationshipErrorHandler
    {
        private const string RelationshipsTagName = "Relationships";
        private const string RelationshipTagName = "Relationship";
        private const string RelationshipNamespaceUri = "http://schemas.openxmlformats.org/package/2006/relationships";
        private const string TargetAttributeName = "Target";
        private const string TargetModeAttributeName = "TargetMode";
        private const string IdAttributeName = "Id";

        /// <summary>
        /// Create a <see cref="RelationshipErrorHandler"/> that simply rewrites the invalid target Uri.
        /// </summary>
        /// <param name="rewriter">The delegate used to rewrite the Uri.</param>
        /// <returns>A factory function for use in <see cref="OpenSettings.RelationshipErrorHandlerFactory"/>.</returns>
        public static Func<OpenXmlPackage, RelationshipErrorHandler> CreateRewriterFactory(Rewriter rewriter)
        {
            var handler = new DelegateRelationshipErrorHandler(rewriter);

            return _ => handler;
        }

        /// <summary>
        /// Delegate to be used for simple rewriting of malformed Uris.
        /// </summary>
        /// <param name="partUri">Uri of the part with the invalid relationship.</param>
        /// <param name="id">Id of relationship</param>
        /// <param name="uri">Invalid <see cref="Uri"/></param>
        /// <returns>Rewritten string if available, otherwise <c>null</c>.</returns>
        public delegate string Rewriter(Uri partUri, string id, string uri);

        /// <summary>
        /// Rewrites an invalid URI with a valid one in order to correctly open a package.
        /// </summary>
        /// <param name="partUri">Uri of the part with the invalid relationship.</param>
        /// <param name="id">Id of relationship</param>
        /// <param name="uri">Invalid <see cref="Uri"/></param>
        /// <returns>Rewritten string if available, otherwise <c>null</c>.</returns>
        public abstract string Rewrite(Uri partUri, string id, string uri);

        /// <summary>
        /// Callback for after a package has been completely loaded and all rewritting has occurred.
        /// </summary>
        public virtual void OnPackageLoaded()
        {
        }

        internal void Handle(Package package)
        {
            if (package is null)
            {
                throw new ArgumentNullException(nameof(package));
            }

            if ((package.FileOpenAccess & FileAccess.ReadWrite) != FileAccess.ReadWrite)
            {
                throw new OpenXmlPackageException(ExceptionMessages.PackageAccessModeIsReadonly);
            }

            foreach (var part in package.GetParts())
            {
                if (part.Uri.OriginalString.EndsWith(".rels", StringComparison.OrdinalIgnoreCase))
                {
                    var doc = WalkRelationships(part);

                    if (doc != null)
                    {
                        using var stream = part.GetStream(FileMode.Open, FileAccess.Write);

                        doc.Save(stream);
                    }
                }
            }
        }

        private XDocument WalkRelationships(PackagePart part)
        {
            using var stream = part.GetStream(FileMode.Open, FileAccess.Read);
            using var reader = new StreamReader(stream);

            var doc = XDocument.Load(reader);
            var changed = false;

            if (string.Equals(RelationshipsTagName, doc.Root.Name.LocalName, StringComparison.Ordinal)
                && string.Equals(RelationshipNamespaceUri, doc.Root.Name.Namespace.NamespaceName, StringComparison.Ordinal))
            {
                foreach (var child in doc.Root.Descendants(XName.Get(RelationshipTagName, RelationshipNamespaceUri)))
                {
                    if (ValidateLink(part, child))
                    {
                        changed = true;
                    }
                }
            }

            return changed ? doc : null;
        }

        private bool ValidateLink(PackagePart part, XElement child)
        {
            if (!EnumHelper.TryParse<TargetMode>(child.Attribute(TargetModeAttributeName)?.Value, out var targetMode))
            {
                return false;
            }

            if (targetMode != TargetMode.External)
            {
                return false;
            }

            var target = child.Attribute(TargetAttributeName)?.Value;

            if (Uri.TryCreate(target, UriHelper.RelativeOrAbsolute, out _))
            {
                return false;
            }

            var id = child.Attribute(IdAttributeName)?.Value;
            var updated = Rewrite(part.Uri, id, target);

            if (updated is null)
            {
                return false;
            }

            if (!Uri.TryCreate(updated, UriHelper.RelativeOrAbsolute, out _))
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidUriProvided);
            }

            child.SetAttributeValue(TargetAttributeName, updated);

            return true;
        }

        private class DelegateRelationshipErrorHandler : RelationshipErrorHandler
        {
            private readonly Rewriter _rewriter;

            public DelegateRelationshipErrorHandler(Rewriter rewriter)
            {
                _rewriter = rewriter;
            }

            public override string Rewrite(Uri partUri, string id, string uri) => _rewriter(partUri, id, uri);
        }
    }
}
