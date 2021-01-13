// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace DocumentFormat.OpenXml.Framework
{
    internal static class NamespaceIdMap
    {
        /// <summary>
        /// A list of namespaces, associated prefixes and the version in which it was introduced.
        /// </summary>
        /// <remarks>
        /// CAUTION: Do NOT modify this list except by adding to the end. The index of the entry is tied
        /// directly to an id used extensively throughout the SDK. Ideally, this will be updated to not
        /// have this magic, but that will take time. If any items are updated in the middle of the list,
        /// the strongly typed schema classes and validation data will need to be regenerated.
        /// </remarks>
        private static readonly NamespaceResolver _namespaceResolver = new NamespaceResolver
        {
            { string.Empty, string.Empty, FileFormatVersions.None },
            { "http://www.w3.org/XML/1998/namespace", "xml", FileFormatVersions.Office2007 },
            { "http://schemas.openxmlformats.org/package/2006/metadata/core-properties", "cp", FileFormatVersions.Office2007 },
            { "http://schemas.openxmlformats.org/officeDocument/2006/extended-properties", "ap", FileFormatVersions.Office2007 },
            { "http://schemas.openxmlformats.org/officeDocument/2006/custom-properties", "op", FileFormatVersions.Office2007 },
            { "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes", "vt", FileFormatVersions.Office2007 },
            { "http://purl.org/dc/elements/1.1/", "dc", FileFormatVersions.Office2007 },
            { "http://purl.org/dc/terms/", "dcterms", FileFormatVersions.Office2007 },
            { "http://schemas.openxmlformats.org/officeDocument/2006/characteristics", "ac", FileFormatVersions.Office2007 },
            { "http://schemas.openxmlformats.org/officeDocument/2006/bibliography", "b", FileFormatVersions.Office2007 },
            { "http://schemas.openxmlformats.org/drawingml/2006/main", "a", FileFormatVersions.Office2007 },
            { "http://schemas.openxmlformats.org/drawingml/2006/chart", "c", FileFormatVersions.Office2007 },
            { "http://schemas.openxmlformats.org/drawingml/2006/chartDrawing", "cdr", FileFormatVersions.Office2007 },
            { "http://schemas.openxmlformats.org/drawingml/2006/compatibility", "comp", FileFormatVersions.Office2007 },
            { "http://schemas.openxmlformats.org/drawingml/2006/diagram", "dgm", FileFormatVersions.Office2007 },
            { "http://schemas.openxmlformats.org/drawingml/2006/lockedCanvas", "lc", FileFormatVersions.Office2007 },
            { "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing", "wp", FileFormatVersions.Office2007 },
            { "http://schemas.openxmlformats.org/drawingml/2006/picture", "pic", FileFormatVersions.Office2007 },
            { "http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing", "xdr", FileFormatVersions.Office2007 },
            { "http://schemas.openxmlformats.org/officeDocument/2006/relationships", "r", FileFormatVersions.Office2007 },
            { "http://schemas.openxmlformats.org/officeDocument/2006/customXml", "ds", FileFormatVersions.Office2007 },
            { "http://schemas.openxmlformats.org/officeDocument/2006/math", "m", FileFormatVersions.Office2007 },
            { "http://schemas.openxmlformats.org/spreadsheetml/2006/main", "x", FileFormatVersions.Office2007 },
            { "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w", FileFormatVersions.Office2007 },
            { "http://schemas.openxmlformats.org/presentationml/2006/main", "p", FileFormatVersions.Office2007 },
            { "http://schemas.openxmlformats.org/schemaLibrary/2006/main", "sl", FileFormatVersions.Office2007 },
            { "urn:schemas-microsoft-com:vml", "v", FileFormatVersions.Office2007 },
            { "urn:schemas-microsoft-com:office:office", "o", FileFormatVersions.Office2007 },
            { "urn:schemas-microsoft-com:office:word", "w10", FileFormatVersions.Office2007 },
            { "urn:schemas-microsoft-com:office:excel", "xvml", FileFormatVersions.Office2007 },
            { "urn:schemas-microsoft-com:office:powerpoint", "pvml", FileFormatVersions.Office2007 },
            { "http://schemas.openxmlformats.org/markup-compatibility/2006", "mc", FileFormatVersions.Office2007 },
            { "http://schemas.microsoft.com/office/excel/2006/main", "xne", FileFormatVersions.Office2007 },
            { "http://schemas.microsoft.com/office/word/2006/wordml", "wne", FileFormatVersions.Office2007 },
            { "http://schemas.microsoft.com/office/2006/01/customui", "mso", FileFormatVersions.Office2007 },
            { "http://schemas.microsoft.com/office/2006/activeX", "ax", FileFormatVersions.Office2007 },
            { "http://schemas.microsoft.com/office/2006/coverPageProps", "cppr", FileFormatVersions.Office2007 },
            { "http://schemas.microsoft.com/office/2006/customDocumentInformationPanel", "cdip", FileFormatVersions.Office2007 },
            { "http://schemas.microsoft.com/office/2006/metadata/contentType", "ct", FileFormatVersions.Office2007 },
            { "http://schemas.microsoft.com/office/2006/metadata/customXsn", "ntns", FileFormatVersions.Office2007 },
            { "http://schemas.microsoft.com/office/2006/metadata/longProperties", "lp", FileFormatVersions.Office2007 },
            { "http://schemas.microsoft.com/office/2006/metadata/properties/metaAttributes", "ma", FileFormatVersions.Office2007 },
            { "http://www.w3.org/2001/XMLSchema", "xsd", FileFormatVersions.Office2007 },
            { "http://www.w3.org/2003/InkML", "inkml", FileFormatVersions.Office2007 },
            { "http://www.w3.org/2003/04/emma", "emma", FileFormatVersions.Office2007 },
            { "http://schemas.microsoft.com/ink/2010/main", "msink", FileFormatVersions.Office2007 },
            { "http://schemas.microsoft.com/office/drawing/2007/8/2/chart", "c14", FileFormatVersions.Office2010 },
            { "http://schemas.microsoft.com/office/drawing/2010/chartDrawing", "cdr14", FileFormatVersions.Office2010 },
            { "http://schemas.microsoft.com/office/drawing/2010/main", "a14", FileFormatVersions.Office2010 },
            { "http://schemas.microsoft.com/office/powerpoint/2010/main", "p14", FileFormatVersions.Office2010 },
            { "http://schemas.microsoft.com/office/drawing/2010/picture", "pic14", FileFormatVersions.Office2010 },
            { "http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing", "wp14", FileFormatVersions.Office2010 },
            { "http://schemas.microsoft.com/office/word/2010/wordml", "w14", FileFormatVersions.Office2010 },
            { "http://schemas.microsoft.com/office/spreadsheetml/2009/9/main", "x14", FileFormatVersions.Office2010 },
            { "http://schemas.microsoft.com/office/excel/2010/spreadsheetDrawing", "xdr14", FileFormatVersions.Office2010 },
            { "http://schemas.microsoft.com/office/spreadsheetml/2009/9/ac", "x14ac", FileFormatVersions.Office2010 },
            { "http://schemas.microsoft.com/office/drawing/2008/diagram", "dsp", FileFormatVersions.Office2007 },
            { "http://schemas.microsoft.com/office/2009/07/customui", "mso14", FileFormatVersions.Office2010 },
            { "http://schemas.microsoft.com/office/drawing/2010/diagram", "dgm14", FileFormatVersions.Office2010 },
            { "http://schemas.microsoft.com/office/word/2010/wordprocessingCanvas", "wpc", FileFormatVersions.Office2010 },
            { "http://schemas.microsoft.com/office/word/2010/wordprocessingGroup", "wpg", FileFormatVersions.Office2010 },
            { "http://schemas.microsoft.com/office/word/2010/wordprocessingShape", "wps", FileFormatVersions.Office2010 },
            { "http://schemas.microsoft.com/office/drawing/2010/slicer", "sle", FileFormatVersions.Office2010 },
            { "http://schemas.microsoft.com/office/drawing/2010/compatibility", "com14", FileFormatVersions.Office2010 },
            { "http://schemas.microsoft.com/office/drawing/2012/chart", "c15", FileFormatVersions.Office2013 },
            { "http://schemas.microsoft.com/office/drawing/2012/chartStyle", "cs", FileFormatVersions.Office2013 },
            { "http://schemas.microsoft.com/office/webextensions/webextension/2010/11", "we", FileFormatVersions.Office2013 },
            { "http://schemas.microsoft.com/office/drawing/2012/main", "a15", FileFormatVersions.Office2013 },
            { "http://schemas.microsoft.com/office/powerpoint/2012/main", "p15", FileFormatVersions.Office2013 },
            { "http://schemas.microsoft.com/office/word/2012/wordml", "w15", FileFormatVersions.Office2013 },
            { "http://schemas.microsoft.com/office/webextensions/taskpanes/2010/11", "wetp", FileFormatVersions.Office2013 },
            { "http://schemas.microsoft.com/office/spreadsheetml/2010/11/main", "x15", FileFormatVersions.Office2013 },
            { "http://schemas.microsoft.com/office/spreadsheetml/2011/1/ac", "x12ac", FileFormatVersions.Office2013 },
            { "http://schemas.microsoft.com/office/thememl/2012/main", "thm15", FileFormatVersions.Office2013 },
            { "http://schemas.microsoft.com/office/spreadsheetml/2010/11/ac", "x15ac", FileFormatVersions.Office2013 },
            { "http://schemas.microsoft.com/office/word/2012/wordprocessingDrawing", "wp15", FileFormatVersions.Office2013 },
            { "http://schemas.microsoft.com/office/powerpoint/2012/roamingSettings", "pRoam", FileFormatVersions.Office2013 },
            { "http://schemas.microsoft.com/office/drawing/2012/timeslicer", "tsle", FileFormatVersions.Office2013 },
            { "http://schemas.microsoft.com/office/powerpoint/2015/main", "p16", FileFormatVersions.Office2016 },
            { "http://schemas.microsoft.com/office/drawing/2014/main", "a16", FileFormatVersions.Office2016 },
            { "http://schemas.microsoft.com/office/drawing/2014/chartex", "cx", FileFormatVersions.Office2016 },
            { "http://schemas.microsoft.com/office/drawing/2014/chart/ac", "c16ac", FileFormatVersions.Office2016 },
            { "http://schemas.microsoft.com/office/drawing/2014/chart", "c16", FileFormatVersions.Office2016 },
            { "http://schemas.microsoft.com/office/spreadsheetml/2014/revision", "xr", FileFormatVersions.Office2016 },
            { "http://schemas.microsoft.com/office/spreadsheetml/2014/11/main", "x16", FileFormatVersions.Office2016 },
            { "http://schemas.microsoft.com/office/spreadsheetml/2015/02/main", "x16r2", FileFormatVersions.Office2016 },
            { "http://schemas.microsoft.com/office/word/2015/wordml/symex", "w16se", FileFormatVersions.Office2016 },
        };

        public static int Count => _namespaceResolver.Count;

        public static bool IsInFileFormat(string ns, FileFormatVersions format)
        {
            if (_namespaceResolver.TryGetByNamespace(ns, out var info))
            {
                return info.Version == format;
            }

            return false;
        }

        public static bool TryGetNamespaceId(string namespaceUri, out byte id)
        {
            if (namespaceUri is not null && _namespaceResolver.TryGetByNamespace(NormalizeNamespace(namespaceUri), out var info))
            {
                id = info.Id;
                return true;
            }
            else
            {
                id = byte.MaxValue;
                return false;
            }
        }

        /// <summary>
        /// Gets the namespace URI for the specified namespace ID.
        /// </summary>
        /// <param name="namespaceId">The namespace ID.</param>
        /// <returns></returns>
        public static string GetNamespaceUri(byte namespaceId) => _namespaceResolver[namespaceId].Namespace;

        /// <summary>
        /// Gets the namespace URI for the specified namespace prefix.
        /// </summary>
        /// <param name="prefix">The namespace prefix.</param>
        /// <returns></returns>
        public static string? GetNamespaceUri(string prefix)
        {
            if (prefix is null)
            {
                throw new ArgumentNullException(nameof(prefix));
            }

            if (_namespaceResolver.TryGetByPrefix(prefix, out var info))
            {
                return info.Namespace;
            }

            return null;
        }

        /// <summary>
        /// Gets the default namespace prefix for the specified namespace ID.
        /// </summary>
        /// <param name="namespaceId">The namespace ID.</param>
        /// <returns></returns>
        public static string GetNamespacePrefix(byte namespaceId) => _namespaceResolver[namespaceId].Prefix;

        public static string? GetNamespacePrefix(string namespaceUri) => _namespaceResolver.TryGetByNamespace(namespaceUri, out var info) ? info.Prefix : null;

        private static string NormalizeNamespace(OpenXmlNamespace ns)
        {
            if (ns.TryGetExtendedNamespace(out var result))
            {
                return result.Uri;
            }

            return ns.Uri;
        }

        private class NamespaceResolver : IEnumerable
        {
            private readonly Dictionary<string, NamespaceInfo> _byNamespace = new Dictionary<string, NamespaceInfo>(StringComparer.Ordinal);
            private readonly Dictionary<string, NamespaceInfo> _byPrefix = new Dictionary<string, NamespaceInfo>(StringComparer.Ordinal);
            private readonly List<NamespaceInfo> _info = new List<NamespaceInfo>();

            public int Count => _info.Count;

            public void Add(string @namespace, string prefix, FileFormatVersions version)
            {
                var info = new NamespaceInfo(@namespace, prefix, version, (byte)_info.Count);

                _byNamespace.Add(@namespace, info);
                _byPrefix.Add(prefix, info);
                _info.Add(info);
            }

            public NamespaceInfo this[int id] => _info[id];

            public bool TryGetByNamespace(string ns, [MaybeNullWhen(false)] out NamespaceInfo info) => _byNamespace.TryGetValue(ns, out info);

            public bool TryGetByPrefix(string prefix, [MaybeNullWhen(false)] out NamespaceInfo info) => _byPrefix.TryGetValue(prefix, out info);

            IEnumerator IEnumerable.GetEnumerator() => _info.GetEnumerator();

            public class NamespaceInfo
            {
                public NamespaceInfo(string ns, string prefix, FileFormatVersions version, byte id)
                {
                    Namespace = ns;
                    Prefix = prefix;
                    Version = version;
                    Id = id;
                }

                public string Namespace { get; }

                public string Prefix { get; }

                public FileFormatVersions Version { get; }

                public byte Id { get; }
            }
        }
    }
}
