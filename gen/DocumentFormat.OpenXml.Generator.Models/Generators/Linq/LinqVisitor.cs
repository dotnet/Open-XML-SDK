// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Generator.Models;

namespace DocumentFormat.OpenXml.Generator;

internal class LinqVisitor(OpenXmlGeneratorServices services)
{
    private readonly Dictionary<QName, FieldInfo> _fields = [];
    private readonly HashSet<SchemaType> _visitedTypes = [];
    private readonly HashSet<string> _classNames = [];

    public IReadOnlyDictionary<QName, FieldInfo> Visit()
    {
        foreach (var ns in services.DataSource.Namespaces)
        {
            VisitNamespace(ns);
        }

        return _fields;
    }

    public void VisitNamespace(SchemaNamespace ns)
    {
        foreach (var type in ns.Types)
        {
            if (type.IsRootElement)
            {
                VisitType(null, type);
            }
        }
    }

    private FieldInfo GetInfo(QName qname)
    {
        if (!_fields.TryGetValue(qname, out var fieldInfo))
        {
            fieldInfo = new FieldInfo(qname, services);
            _fields.Add(qname, fieldInfo);
        }

        return fieldInfo;
    }

    public void VisitType(SchemaType? parent, SchemaType type)
    {
        var typeField = GetInfo(type.Name.QName);
        typeField.AddElementMetadata(type);
        typeField.AddParentElementMetadata(parent);

        if (_visitedTypes.Add(type))
        {
            foreach (var attribute in type.Attributes)
            {
                var field = VisitAttribute(attribute);

                field.AddAttributeMetadata(type, attribute);
            }

            foreach (var child in type.Children)
            {
                var childType = services.FindType(child.Name);
                VisitType(type, childType);

                typeField.AddChildElementMetadata(childType);
            }

            //var @base = type.BaseClass;

            //while (!string.IsNullOrEmpty(@base))
            //{
            //    if (_classNames.Add(@base!))
            //    {
            //        if (services.DataSource.TypedClasses.FirstOrDefault(t => t.ClassName == type.BaseClass) is { } @class && services.TryFindType(@class.Name, out var found))
            //        {
            //            VisitType(parent, found);
            //            @base = found.BaseClass;
            //            continue;
            //        }
            //    }

            //    @base = null;
            //}
        }
    }

    public FieldInfo VisitAttribute(SchemaAttribute attribute)
    {
        return GetInfo(attribute.QName);
    }
}
