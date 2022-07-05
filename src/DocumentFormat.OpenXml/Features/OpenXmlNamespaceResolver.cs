// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using System.Collections.Generic;
using System.Xml;

namespace DocumentFormat.OpenXml.Features;

internal partial class OpenXmlNamespaceResolver : IOpenXmlNamespaceResolver
{
    // The namespaces listed here are somewhat obsolete ones that we need to support. Before we try to get the index of a namespace,
    // we check if it's in this list to rename to the expected correct namespace.
    private readonly Dictionary<OpenXmlNamespace, OpenXmlNamespace> _extendedNamespaces;

    // This dictionary contains the Strict and Transitional namespaces pairs to be interpreted equivalent.
    private readonly Dictionary<OpenXmlNamespace, OpenXmlNamespace> _strictTransitionalNamespaces;

    // This dictionary contains the Strict and Transitional relationship pairs to be interpreted equivalent.
    private readonly Dictionary<OpenXmlNamespace, OpenXmlNamespace> _strictTransitionalRelationshipPairs;

    public OpenXmlNamespaceResolver()
    {
        _extendedNamespaces = new()
        {
            { "http://schemas.openxmlformats.org/wordprocessingml/2006/3/main", "http://schemas.openxmlformats.org/wordprocessingml/2006/main" },
            { "http://schemas.openxmlformats.org/wordprocessingml/2006/5/main", "http://schemas.openxmlformats.org/wordprocessingml/2006/main" },
            { "http://schemas.openxmlformats.org/wordprocessingml/2006/6/main", "http://schemas.openxmlformats.org/wordprocessingml/2006/main" },
            { "http://schemas.openxmlformats.org/spreadsheetml/2006/5/main", "http://schemas.openxmlformats.org/spreadsheetml/2006/main" },
            { "http://schemas.openxmlformats.org/spreadsheetml/2006/7/main", "http://schemas.openxmlformats.org/spreadsheetml/2006/main" },
            { "http://schemas.openxmlformats.org/presentationml/2006/3/main", "http://schemas.openxmlformats.org/presentationml/2006/main" },
            { "http://schemas.openxmlformats.org/drawingml/2006/3/main", "http://schemas.openxmlformats.org/drawingml/2006/main" },
            { "http://schemas.microsoft.com/office/word/2010/11/wordml", "http://schemas.microsoft.com/office/word/2012/wordml" },
        };

        _strictTransitionalNamespaces = new()
        {
            // Namespaces
            { "http://purl.oclc.org/ooxml/descriptions/base", "http://descriptions.openxmlformats.org/description/base" },
            { "http://purl.oclc.org/ooxml/descriptions/full", "http://descriptions.openxmlformats.org/description/full" },
            { "http://purl.oclc.org/ooxml/drawingml/chart", "http://schemas.openxmlformats.org/drawingml/2006/chart" },
            { "http://purl.oclc.org/ooxml/drawingml/chartDrawing", "http://schemas.openxmlformats.org/drawingml/2006/chartDrawing" },
            { "http://purl.oclc.org/ooxml/drawingml/diagram", "http://schemas.openxmlformats.org/drawingml/2006/diagram" },
            { "http://purl.oclc.org/ooxml/drawingml/main", "http://schemas.openxmlformats.org/drawingml/2006/main" },
            { "http://purl.oclc.org/ooxml/drawingml/picture", "http://schemas.openxmlformats.org/drawingml/2006/picture" },
            { "http://purl.oclc.org/ooxml/drawingml/spreadsheetDrawing", "http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing" },
            { "http://purl.oclc.org/ooxml/drawingml/wordprocessingDrawing", "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing" },
            { "http://purl.oclc.org/ooxml/officeDocument/bibliography", "http://schemas.openxmlformats.org/officeDocument/2006/bibliography" },
            { "http://purl.oclc.org/ooxml/officeDocument/customProperties", "http://schemas.openxmlformats.org/officeDocument/2006/custom-properties" },
            { "http://purl.oclc.org/ooxml/officeDocument/customXml", "http://schemas.openxmlformats.org/officeDocument/2006/customXml" },
            { "http://purl.oclc.org/ooxml/officeDocument/customXmlDataProps", "http://schemas.openxmlformats.org/officeDocument/2006/customXmlDataProps" },
            { "http://purl.oclc.org/ooxml/officeDocument/docPropsVTypes", "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes" },
            { "http://purl.oclc.org/ooxml/officeDocument/extendedProperties", "http://schemas.openxmlformats.org/officeDocument/2006/extended-properties" },
            { "http://purl.oclc.org/ooxml/officeDocument/math", "http://schemas.openxmlformats.org/officeDocument/2006/math" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships", "http://schemas.openxmlformats.org/officeDocument/2006/relationships" },
            { "http://purl.oclc.org/ooxml/presentationml/main", "http://schemas.openxmlformats.org/presentationml/2006/main" },
            { "http://purl.oclc.org/ooxml/schemaLibrary/main", "http://schemas.openxmlformats.org/schemaLibrary/2006/main" },
            { "http://purl.oclc.org/ooxml/spreadsheetml/main", "http://schemas.openxmlformats.org/spreadsheetml/2006/main" },
            { "http://purl.oclc.org/ooxml/wordprocessingml/main", "http://schemas.openxmlformats.org/wordprocessingml/2006/main" },
            { "http://purl.org/dc/dcmitype/", "http://purl.org/dc/dcmitype/" },
            { "http://purl.org/dc/elements/1.1/", "http://purl.org/dc/elements/1.1/" },
            { "http://purl.org/dc/terms/", "http://purl.org/dc/terms/" },
            { "http://www.w3.org/2001/XMLSchema", "http://www.w3.org/2001/XMLSchema" },
            { "http://www.w3.org/2001/XMLSchema-instance", "http://www.w3.org/2001/XMLSchema-instance" },
            { "http://purl.oclc.org/ooxml/drawingml/lockedCanvas", "http://schemas.openxmlformats.org/drawingml/2006/lockedCanvas" },
            { "http://purl.oclc.org/ooxml/drawingml/compatibility", "http://schemas.openxmlformats.org/drawingml/2006/compatibility" },
            { "http://purl.oclc.org/ooxml/officeDocument/sharedTypes", "http://schemas.openxmlformats.org/officeDocument/2006/sharedTypes" },

            // This is a namespace conversion. Workaround for a bug in ISO spec. https://www.assembla.com/code/IS29500/subversion/changesets/160
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/customXml", "http://schemas.openxmlformats.org/officeDocument/2006/customXml" },
        };

        _strictTransitionalRelationshipPairs = new()
        {
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/aFChunk", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/aFChunk" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/attachedTemplate", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/attachedTemplate" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/audio", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/audio" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/calcChain", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/calcChain" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/chart", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/chart" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/chartsheet", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/chartsheet" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/chartUserShapes", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/chartUserShapes" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/commentAuthors", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/commentAuthors" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/comments", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/comments" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/connections", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/connections" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/control", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/control" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/customProperties", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/custom-properties" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/customProperty", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/customProperty" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/customXml", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/customXml" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/customXmlProps", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/customXmlProps" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/diagramColors", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramColors" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/diagramData", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramData" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/diagramLayout", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramLayout" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/diagramQuickStyle", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramQuickStyle" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/dialogsheet", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/dialogsheet" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/drawing", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/drawing" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/endnotes", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/endnotes" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/extendedProperties", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/extended-properties" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/externalLink", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/externalLink" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/externalLinkPath", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/externalLinkPath" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/font", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/font" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/fontTable", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/fontTable" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/footer", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/footer" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/footnotes", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/footnotes" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/frame", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/frame" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/glossaryDocument", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/glossaryDocument" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/handoutMaster", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/handoutMaster" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/header", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/header" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/htmlPubSaveAs", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/htmlPubSaveAs" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/hyperlink", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/hyperlink" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/image", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/mailMergeHeaderSource", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/mailMergeHeaderSource" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/mailMergeRecipientData", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/mailMergeRecipientData" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/mailMergeSource", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/mailMergeSource" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/metadata/thumbnail", "http://schemas.openxmlformats.org/package/2006/relationships/metadata/thumbnail" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/movie", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/movie" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/notesMaster", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/notesMaster" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/notesSlide", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/notesSlide" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/numbering", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/numbering" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/officeDocument", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/oleObject", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/oleObject" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/package", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/package" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/pivotCacheDefinition", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/pivotCacheDefinition" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/pivotCacheRecords", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/pivotCacheRecords" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/pivotTable", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/pivotTable" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/presProps", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/presProps" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/printerSettings", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/printerSettings" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/queryTable", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/queryTable" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/revisionHeaders", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/revisionHeaders" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/revisionLog", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/revisionLog" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/settings", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/settings" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/sharedStrings", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/sharedStrings" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/sheetMetadata", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/sheetMetadata" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/slide", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/slide" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/slideLayout", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/slideLayout" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/slideMaster", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/slideMaster" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/slideUpdateInfo", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/slideUpdateInfo" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/slideUpdateUrl", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/slideUpdateUrl" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/styles", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/styles" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/subDocument", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/subDocument" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/table", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/table" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/tableSingleCells", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/tableSingleCells" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/tableStyles", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/tableStyles" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/tags", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/tags" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/theme", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/theme" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/themeOverride", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/themeOverride" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/transform", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/transform" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/usernames", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/usernames" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/video", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/video" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/viewProps", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/viewProps" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/volatileDependencies", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/volatileDependencies" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/webSettings", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/webSettings" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/worksheet", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/worksheet" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/xmlMaps", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/xmlMaps" },
        };
    }

    private string NormalizeNamespace(in OpenXmlNamespace ns)
    {
        if (TryGetExtendedNamespace(ns, out var result))
        {
            return result.Uri;
        }

        return ns.Uri;
    }

    public IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope) => _urlToPrefix;

    public string? LookupNamespace(string prefix) => _prefixToUrl.TryGetValue(prefix, out var result) ? result : null;

    public string? LookupPrefix(string namespaceName) => _urlToPrefix.TryGetValue(namespaceName, out var result) ? result : null;

    /// <inheritdoc />
    public bool TryGetTransitionalNamespace(OpenXmlNamespace ns, out OpenXmlNamespace transitionalNamespace)
        => _strictTransitionalNamespaces.TryGetValue(ns, out transitionalNamespace);

    /// <inheritdoc />
    public bool TryGetTransitionalRelationship(OpenXmlNamespace ns, out OpenXmlNamespace transitionalRelationship)
        => _strictTransitionalRelationshipPairs.TryGetValue(ns, out transitionalRelationship);

    /// <inheritdoc />
    public bool TryGetExtendedNamespace(OpenXmlNamespace ns, out OpenXmlNamespace extNamespaceUri)
        => _extendedNamespaces.TryGetValue(ns, out extNamespaceUri);

    /// <inheritdoc />
    public FileFormatVersions GetVersion(OpenXmlNamespace ns)
    {
        var normalized = NormalizeNamespace(ns);

        if (_urlToPrefix.TryGetValue(normalized, out var prefix) && _prefixToVersion.TryGetValue(prefix, out var version))
        {
            return version;
        }

        return FileFormatVersions.None;
    }
}
