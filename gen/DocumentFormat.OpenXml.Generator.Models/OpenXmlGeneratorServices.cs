// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Generator.Models;
using DocumentFormat.OpenXml.Generator.Schematron;

namespace DocumentFormat.OpenXml.Generator;

public class OpenXmlGeneratorServices
{
    private readonly Dictionary<string, NamespaceInfo> _namespacesByPrefix;
    private readonly Dictionary<string, NamespaceInfo> _namespacesByUri;
    private readonly Dictionary<string, string> _prefixToApi;
    private readonly Dictionary<TypedQName, StronglyTypedElement> _lookup;
    private readonly Dictionary<(QName Type, string), StronglyTypedElement> _partLookup;
    private readonly Dictionary<QName, (SchemaEnum, string)> _enums;
    private readonly Dictionary<TypedQName, SchemaType> _types;

    public OpenXmlGeneratorServices(OpenXmlGeneratorContext context)
    {
        _prefixToApi = context.TypedNamespaces.ToDictionary(c => c.Prefix, c => c.Namespace);
        _namespacesByPrefix = context.KnownNamespaces.ToDictionary(i => i.Prefix);
        _namespacesByUri = context.KnownNamespaces.ToDictionary(i => i.Uri);
        _lookup = context.TypedClasses.ToDictionary(t => t.Name);

        _types = context.Namespaces
            .SelectMany(t => t.Types)
            .Where(t => !t.IsAbstract)
            .ToDictionary(t => t.Name);
        _partLookup = context.TypedClasses
            .Where(n => n.PartClassName != null)
            .ToLookup(n => (n.Name.Type, n.Name.QName.Name!))
            .Where(n => n.Count() == 1)
            .ToDictionary(n => n.Key, n => n.First());
        _enums = context.Namespaces
            .SelectMany(d => d.Enums.Select(e => (e, GetNamespaceApi(d.TargetNamespace))))
            .ToDictionary(e => e.e.Type);

        Context = context;
    }

    public bool TryGetEnum(QName qname, out SchemaEnum @enum, out string ns)
    {
        if (_enums.TryGetValue(qname, out var result))
        {
            @enum = result.Item1;
            ns = result.Item2;
            return true;
        }

        @enum = default!;
        ns = default!;
        return false;
    }

    public OpenXmlGeneratorContext Context { get; }

    public IEnumerable<SchematronEntry> GetSchematrons(QName qname)
    {
        if (qname.Prefix == "o")
        {
            qname = new("ovml", qname.Name);
        }

        return Context.Schematrons.Where(s => s.Context.Equals(qname));
    }

    public SchemaType FindType(TypedQName type) => _types[type];

    public bool TryGetPartClassName(QName? type, string name, out (string Namespace, string Class) apiName)
    {
        if (type is not null && _partLookup.TryGetValue((type, name), out var result) && _prefixToApi.TryGetValue(result.Name.QName.Prefix, out var ns))
        {
            apiName = (ns, result.ClassName);
            return true;
        }

        apiName = default!;
        return false;
    }

    public NamespaceInfo GetNamespaceInfo(string prefix) => _namespacesByPrefix[prefix];

    public NamespaceInfo GetNamespaceInfoByUri(string uri) => _namespacesByUri[uri];

    public string GetNamespaceApi(string uri) => _prefixToApi[GetNamespaceInfoByUri(uri).Prefix];

    public string? GetNamespaceApiByPrefix(string prefix) => _prefixToApi.TryGetValue(prefix, out var result) ? result : null;

    public string FindClassName(TypedQName name, bool fullyQualified = true)
    {
        var typeInfo = _lookup[name];

        if (fullyQualified)
        {
            var ns = _prefixToApi[string.IsNullOrEmpty(name.QName.Prefix) ? name.Type.Prefix : name.QName.Prefix];
            return $"{ns}.{typeInfo.ClassName}";
        }

        return typeInfo.ClassName;
    }
}
