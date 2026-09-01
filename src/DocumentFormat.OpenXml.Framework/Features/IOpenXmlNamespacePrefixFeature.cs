// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Features;

/// <summary>
/// A feature that overrides the namespace prefixes used when Open XML elements are written.
/// </summary>
/// <remarks>
/// <para>
/// By default, elements are written with a built-in prefix for their namespace, for example
/// <c>x</c> for SpreadsheetML, so a worksheet is serialized as
/// <c>&lt;x:worksheet xmlns:x="..."&gt;</c>. This is valid, but Office writes the part's own
/// namespace as the default namespace instead, as <c>&lt;worksheet xmlns="..."&gt;</c>.
/// Consumers that parse the XML without a namespace manager can be sensitive to the difference.
/// </para>
/// <para>
/// Register an implementation on <see cref="Packaging.OpenXmlPackage.Features"/> to choose the
/// prefixes instead. When no implementation is registered, the built-in prefixes are used and
/// output is unchanged.
/// </para>
/// <para>
/// This applies when a part's root element is written - <see cref="OpenXmlPartRootElement.Save()"/>
/// and <see cref="OpenXmlPartRootElement.WriteTo(System.Xml.XmlWriter)"/> - and covers everything
/// below it, unknown and extension elements included. It does not affect
/// <see cref="OpenXmlElement.Prefix"/>, which continues to report the built-in prefix so that
/// validation XPaths stay well formed; writing a non-root element directly through
/// <see cref="OpenXmlElement.WriteTo(System.Xml.XmlWriter)"/>; or <see cref="OpenXmlPartWriter"/>,
/// which writes prefixes supplied by its caller.
/// </para>
/// <para>
/// Three limits are worth knowing before relying on this. A part root whose content was supplied as
/// raw XML and never parsed is written verbatim, so the override does not reach it - the alternative,
/// forcing a parse, would turn a byte-for-byte copy into a re-serialization that can fail on content
/// the SDK is able to copy but not re-read. <see cref="OpenXmlElement.OuterXml"/> on a part root does
/// go through the override, so it disagrees with a detached clone of the same element;
/// <see cref="OpenXmlElement.InnerXml"/> does not, because it serializes the children directly.
/// And a part written through the LINQ-to-XML feature - <c>GetXElement</c> and its save path - keeps
/// the built-in prefixes, and reports them or the overridden ones depending on whether the typed
/// root had already been materialized.
/// </para>
/// <para>
/// A namespace-qualified attribute needs a prefix, so when the elements around it no longer carry
/// one the writer declares the built-in prefix on each element that has such an attribute. This is
/// invisible in SpreadsheetML, whose attributes are unqualified, but WordprocessingML uses them
/// heavily - <c>w:rsidR</c>, <c>w:val</c>. Calling
/// <see cref="OpenXmlElement.AddNamespaceDeclaration(string, string)"/> on the part root to declare
/// the prefix once keeps those declarations off the individual elements.
/// </para>
/// <para>
/// A namespace declaration already present on an element is preserved even when it binds a prefix
/// to an overridden namespace, so a round-tripped document keeps whatever it declared. This is
/// deliberate: element names come from the override regardless, a qualified attribute still needs a
/// prefix to resolve against, and removing the declaration would strand any <c>mc:Ignorable</c>
/// value naming it.
/// </para>
/// <para>
/// A prefix that another Open XML namespace already owns - <c>r</c>, <c>mc</c>, <c>a</c> and the
/// rest of the built-in table - is rejected with an <see cref="System.InvalidOperationException"/> naming
/// both namespaces. Taking one has no good outcome: where the other namespace is declared on the
/// same element the writer refuses it, and where it is declared further out the writer silently
/// rebinds that namespace to a generated prefix, so <c>r:id</c> would ship as <c>p3:id</c> with no
/// error at all. Choose a prefix outside that set, or the empty string for the default namespace.
/// The returned prefix must also be a valid XML name; the underlying
/// <see cref="System.Xml.XmlWriter"/> enforces that while saving.
/// </para>
/// <para>
/// Note that a save which throws has already truncated the part, so the package is left incomplete.
/// That is a property of the save path rather than of this feature, but it is worth knowing when
/// experimenting with a resolver against a file you care about.
/// </para>
/// </remarks>
/// <example>
/// The following writes SpreadsheetML as the default namespace for a whole package:
/// <code>
/// using var document = SpreadsheetDocument.Create(path, SpreadsheetDocumentType.Workbook);
///
/// document.Features.SetNamespacePrefixOverride(
///     OpenXmlNamespacePrefix.DefaultFor("http://schemas.openxmlformats.org/spreadsheetml/2006/main"));
/// </code>
/// </example>
public interface IOpenXmlNamespacePrefixFeature
{
    /// <summary>
    /// Attempts to get the prefix used to write elements that belong to <paramref name="namespaceUri"/>.
    /// </summary>
    /// <param name="namespaceUri">The namespace being written.</param>
    /// <param name="prefix">
    /// When this method returns <see langword="true"/>, the prefix to use.
    /// <see cref="string.Empty"/> writes <paramref name="namespaceUri"/> as the default
    /// (unprefixed) namespace.
    /// </param>
    /// <returns>
    /// <see langword="true"/> if this feature supplies a prefix for <paramref name="namespaceUri"/>;
    /// otherwise <see langword="false"/> to fall back to the built-in prefix.
    /// </returns>
    bool TryGetPrefix(string namespaceUri, out string prefix);
}
