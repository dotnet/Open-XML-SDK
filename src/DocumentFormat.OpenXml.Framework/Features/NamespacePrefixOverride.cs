// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Xml;

namespace DocumentFormat.OpenXml.Features;

/// <summary>
/// The prefix decisions for one save of a part: asks the registered
/// <see cref="IOpenXmlNamespacePrefixFeature"/> and checks each answer against the prefixes that
/// are already taken, by the built-in table or by a declaration somewhere in the tree.
/// </summary>
/// <remarks>
/// <para>
/// Taking a prefix that is bound to another namespace has no good outcome. Where the other
/// namespace is declared on the same element the writer rejects it outright ("the prefix cannot be
/// redefined"); where it is declared further out the writer silently rebinds that namespace to a
/// generated prefix, so <c>r:id</c> ships as <c>p3:id</c> with no error at all. Callers cannot be
/// expected to know which prefixes a loaded document uses, so this is reported here rather than
/// left to the writer.
/// </para>
/// <para>
/// <see cref="Create"/> walks the tree once and checks every namespace it uses up front, so that a
/// prefix the feature cannot be given is reported before the part is opened for writing - opening
/// truncates it. Each answer is checked again as elements are written, because nothing in the
/// contract requires a feature to answer the same prefix for a namespace every time.
/// </para>
/// </remarks>
internal sealed class NamespacePrefixOverride
{
    private readonly IOpenXmlNamespacePrefixFeature _feature;
    private readonly IOpenXmlNamespaceResolver _resolver;

    // Prefixes the tree declares itself, keyed by prefix.
    private readonly Dictionary<string, string> _declared;

    // The prefix already checked for each namespace. Keyed by namespace and compared by prefix, so
    // that a changed answer is checked afresh rather than waved through.
    private readonly Dictionary<string, string> _validated = new(StringComparer.Ordinal);

    private NamespacePrefixOverride(IOpenXmlNamespacePrefixFeature feature, IOpenXmlNamespaceResolver resolver, Dictionary<string, string> declared)
    {
        _feature = feature;
        _resolver = resolver;
        _declared = declared;
    }

    /// <summary>
    /// Gets the namespace resolver of the part being saved.
    /// </summary>
    public IOpenXmlNamespaceResolver Resolver => _resolver;

    /// <summary>
    /// Gets the namespace declarations found in the tree, keyed by prefix. Where a prefix is declared
    /// more than once the declaration nearest the root wins.
    /// </summary>
    /// <remarks>
    /// Collected while checking prefixes, and exposed so that the root does not walk the tree a
    /// second time to hoist declarations onto itself.
    /// </remarks>
    public Dictionary<string, string> DeclaredNamespaces => _declared;

    /// <summary>
    /// Creates the override for the tree under <paramref name="root"/>, checking the prefix supplied
    /// for every namespace the tree uses before anything is written.
    /// </summary>
    /// <exception cref="InvalidOperationException">A supplied prefix is already bound to another namespace.</exception>
    /// <exception cref="XmlException">A supplied prefix is not a valid XML name.</exception>
    public static NamespacePrefixOverride Create(OpenXmlElement root, IOpenXmlNamespacePrefixFeature feature, IOpenXmlNamespaceResolver resolver)
    {
        var declared = new Dictionary<string, string>(StringComparer.Ordinal);
        var namespaces = new HashSet<string>(StringComparer.Ordinal);

        // Consecutive elements almost always share one namespace string instance, so a reference
        // check skips hashing the URI for the vast majority of the tree.
        string? previous = null;

        Collect(root, declared, namespaces, ref previous);

        foreach (var element in root.Descendants())
        {
            Collect(element, declared, namespaces, ref previous);
        }

        var result = new NamespacePrefixOverride(feature, resolver, declared);

        foreach (var namespaceUri in namespaces)
        {
            result.TryGetPrefix(namespaceUri, out _);
        }

        return result;
    }

    /// <summary>
    /// Attempts to get the prefix the feature supplies for <paramref name="namespaceUri"/>.
    /// </summary>
    /// <exception cref="InvalidOperationException">The supplied prefix is already bound to another namespace.</exception>
    /// <exception cref="XmlException">The supplied prefix is not a valid XML name.</exception>
    public bool TryGetPrefix(string namespaceUri, out string prefix)
    {
        if (_feature.TryGetPrefix(namespaceUri, out var overridden))
        {
            // Tolerate a third-party feature that reports success with a null prefix.
            prefix = overridden ?? string.Empty;

            if (prefix.Length > 0)
            {
                EnsureAvailable(namespaceUri, prefix);
            }

            return true;
        }

        prefix = string.Empty;
        return false;
    }

    private static void Collect(OpenXmlElement element, Dictionary<string, string> declared, HashSet<string> namespaces, ref string? previous)
    {
        if (element.NamespaceDeclField is not null)
        {
            foreach (var declaration in element.NamespaceDeclField)
            {
                if (declaration.Key.Length > 0 && !declared.ContainsKey(declaration.Key))
                {
                    declared.Add(declaration.Key, declaration.Value);
                }
            }
        }

        var namespaceUri = element.NamespaceUri;

        if (!ReferenceEquals(namespaceUri, previous) && !string.IsNullOrEmpty(namespaceUri))
        {
            namespaces.Add(namespaceUri);
            previous = namespaceUri;
        }
    }

    private void EnsureAvailable(string namespaceUri, string prefix)
    {
        if (_validated.TryGetValue(namespaceUri, out var checkedPrefix) && string.Equals(checkedPrefix, prefix, StringComparison.Ordinal))
        {
            return;
        }

        XmlConvert.VerifyNCName(prefix);

        var boundTo = _resolver.LookupNamespace(prefix);

        if (boundTo is null)
        {
            _declared.TryGetValue(prefix, out boundTo);
        }

        if (boundTo is not null && !string.Equals(boundTo, namespaceUri, StringComparison.Ordinal))
        {
            throw new InvalidOperationException(SR.Format(ExceptionMessages.Fmt_NamespacePrefixIsReserved, prefix, namespaceUri, boundTo));
        }

        _validated[namespaceUri] = prefix;
    }
}
