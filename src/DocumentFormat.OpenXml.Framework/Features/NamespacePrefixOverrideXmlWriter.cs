// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Xml;

namespace DocumentFormat.OpenXml.Features;

/// <summary>
/// An <see cref="XmlWriter"/> decorator that applies an <see cref="IOpenXmlNamespacePrefixFeature"/>
/// to the elements and namespace declarations written through it.
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
internal sealed class NamespacePrefixOverrideXmlWriter : XmlWriter
{
    private readonly XmlWriter _writer;
    private readonly IOpenXmlNamespacePrefixFeature _feature;
    private readonly IOpenXmlNamespaceResolver _resolver;

    // Namespaces whose supplied prefix has already been checked for a collision.
    private readonly HashSet<string> _validated = new(StringComparer.Ordinal);

    public NamespacePrefixOverrideXmlWriter(XmlWriter writer, IOpenXmlNamespacePrefixFeature feature, IOpenXmlNamespaceResolver resolver)
    {
        _writer = writer;
        _feature = feature;
        _resolver = resolver;
    }

    public override WriteState WriteState => _writer.WriteState;

    public override string? XmlLang => _writer.XmlLang;

    public override XmlSpace XmlSpace => _writer.XmlSpace;

    public override XmlWriterSettings? Settings => _writer.Settings;

    public override void WriteStartElement(string? prefix, string localName, string? ns)
    {
        // The empty namespace is excluded deliberately: a prefix cannot be bound to it, so honoring
        // a feature that answered for it would produce "Cannot use a prefix with an empty namespace".
        var resolved = !string.IsNullOrEmpty(ns) && TryGetPrefix(ns!, out var overridden) ? overridden : prefix;

        _writer.WriteStartElement(resolved, localName, ns);
    }

    public override void WriteStartAttribute(string? prefix, string localName, string? ns)
        => _writer.WriteStartAttribute(prefix, localName, ns);

    public override void WriteEndAttribute() => _writer.WriteEndAttribute();

    public override void WriteString(string? text) => _writer.WriteString(text);

    public override void Flush() => _writer.Flush();

    public override string? LookupPrefix(string ns) => _writer.LookupPrefix(ns);

    public override void WriteBase64(byte[] buffer, int index, int count) => _writer.WriteBase64(buffer, index, count);

    public override void WriteCData(string? text) => _writer.WriteCData(text);

    public override void WriteCharEntity(char ch) => _writer.WriteCharEntity(ch);

    public override void WriteChars(char[] buffer, int index, int count) => _writer.WriteChars(buffer, index, count);

    public override void WriteComment(string? text) => _writer.WriteComment(text);

    public override void WriteDocType(string name, string? pubid, string? sysid, string? subset) => _writer.WriteDocType(name, pubid, sysid, subset);

    public override void WriteEndDocument() => _writer.WriteEndDocument();

    public override void WriteEndElement() => _writer.WriteEndElement();

    public override void WriteEntityRef(string name) => _writer.WriteEntityRef(name);

    public override void WriteFullEndElement() => _writer.WriteFullEndElement();

    public override void WriteProcessingInstruction(string name, string? text) => _writer.WriteProcessingInstruction(name, text);

    public override void WriteRaw(string data) => _writer.WriteRaw(data);

    public override void WriteRaw(char[] buffer, int index, int count) => _writer.WriteRaw(buffer, index, count);

    public override void WriteStartDocument() => _writer.WriteStartDocument();

    public override void WriteStartDocument(bool standalone) => _writer.WriteStartDocument(standalone);

    public override void WriteSurrogateCharEntity(char lowChar, char highChar) => _writer.WriteSurrogateCharEntity(lowChar, highChar);

    public override void WriteWhitespace(string? ws) => _writer.WriteWhitespace(ws);

    /// <summary>
    /// Does nothing. The wrapped writer is owned by the caller and outlives this decorator.
    /// </summary>
    public override void Close()
    {
    }

    protected override void Dispose(bool disposing)
    {
        // The wrapped writer is owned by the caller, so it is deliberately not disposed here.
        base.Dispose(disposing);
    }

    private bool TryGetPrefix(string namespaceUri, out string prefix)
    {
        if (_feature.TryGetPrefix(namespaceUri, out var overridden))
        {
            // Tolerate a third-party feature that reports success with a null prefix.
            prefix = overridden ?? string.Empty;

            if (prefix.Length > 0 && _validated.Add(namespaceUri))
            {
                ThrowIfPrefixIsReserved(namespaceUri, prefix);
            }

            return true;
        }

        prefix = string.Empty;
        return false;
    }

    /// <summary>
    /// Rejects a prefix that another Open XML namespace already owns.
    /// </summary>
    /// <remarks>
    /// Taking such a prefix has no good outcome. When the other namespace is declared on the same
    /// element the writer rejects it outright ("the prefix cannot be redefined"); when it is declared
    /// further out the writer silently rebinds that namespace to a generated prefix, so
    /// <c>r:id</c> ships as <c>p3:id</c> with no error at all. Callers cannot be expected to know
    /// which prefixes a loaded document uses, so this is reported rather than left to the writer.
    /// </remarks>
    private void ThrowIfPrefixIsReserved(string namespaceUri, string prefix)
    {
        var reservedFor = _resolver.LookupNamespace(prefix);

        if (reservedFor is not null && !string.Equals(reservedFor, namespaceUri, StringComparison.Ordinal))
        {
            throw new InvalidOperationException(SR.Format(ExceptionMessages.Fmt_NamespacePrefixIsReserved, prefix, namespaceUri, reservedFor));
        }
    }
}
