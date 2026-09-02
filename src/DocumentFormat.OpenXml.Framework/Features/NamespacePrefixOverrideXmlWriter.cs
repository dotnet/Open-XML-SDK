// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;
using System.Xml;

namespace DocumentFormat.OpenXml.Features;

/// <summary>
/// An <see cref="XmlWriter"/> decorator that applies a <see cref="NamespacePrefixOverride"/> to the
/// elements written through it.
/// </summary>
/// <remarks>
/// <para>
/// The override is applied here rather than while resolving each element's prefix so that it cannot
/// be undone by the writer's own namespace scope. A namespace-qualified attribute forces the
/// underlying writer to declare the built-in prefix on its element - <c>w:rsidR</c> needs a prefix,
/// and an empty one would mean "no namespace" - and from that point
/// <see cref="XmlWriter.LookupPrefix(string)"/> reports that prefix for the namespace. Any decision
/// made from the writer's scope would therefore silently revert to the built-in prefix for the rest
/// of the subtree. Forcing the prefix at the point of writing keeps every element consistent
/// regardless of what is declared around it.
/// </para>
/// <para>
/// Attributes and namespace declarations pass through untouched. An empty prefix on an attribute
/// means "no namespace" rather than "the default namespace", so a qualified attribute must keep a
/// real prefix - and a declaration binding a prefix to an overridden namespace is left in place.
/// Binding both a prefix and the default prefix to one namespace is legal, it does not affect
/// element names once the prefix is forced here, and keeping it is what lets a qualified attribute
/// resolve against the root instead of forcing a fresh declaration onto every element that carries
/// one. Dropping such declarations would also strand any <c>mc:Ignorable</c> or
/// <c>mc:Choice/@Requires</c> value that names the prefix.
/// </para>
/// </remarks>
internal sealed class NamespacePrefixOverrideXmlWriter : ForwardingXmlWriter
{
    private readonly NamespacePrefixOverride _override;

    public NamespacePrefixOverrideXmlWriter(XmlWriter writer, NamespacePrefixOverride @override)
        : base(writer)
    {
        _override = @override;
    }

    /// <summary>
    /// Gets the namespace resolver of the part being saved.
    /// </summary>
    /// <remarks>
    /// Once an overridden namespace is bound as the default namespace, <see cref="XmlWriter.LookupPrefix(string)"/>
    /// answers with the empty prefix, which <see cref="OpenXmlElement.WriteTo(XmlWriter)"/> treats
    /// as "not found" and resolves through the element's features instead. An element's features
    /// are not cached: each lookup walks to the part root and through the feature chain. Every
    /// element written under the override would pay that walk, so they read the resolver from here.
    /// </remarks>
    internal IOpenXmlNamespaceResolver Resolver => _override.Resolver;

    /// <summary>
    /// Gets the namespace declarations the override collected from the tree, keyed by prefix.
    /// </summary>
    internal Dictionary<string, string> DeclaredNamespaces => _override.DeclaredNamespaces;

    public override void WriteStartElement(string? prefix, string localName, string? ns)
    {
        // The empty namespace is excluded deliberately: a prefix cannot be bound to it, so honoring
        // a feature that answered for it would produce "Cannot use a prefix with an empty namespace".
        var resolved = !string.IsNullOrEmpty(ns) && _override.TryGetPrefix(ns!, out var overridden) ? overridden : prefix;

        Inner.WriteStartElement(resolved, localName, ns);
    }

    /// <summary>
    /// Does nothing. The wrapped writer is owned by the caller and outlives this decorator.
    /// </summary>
    public override void Close()
    {
    }
}
