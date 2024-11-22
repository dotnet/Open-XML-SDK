// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Generator.Models;

namespace DocumentFormat.OpenXml.Generator;

/// <summary>
/// Represents an XName field.
/// </summary>
internal class FieldInfo : IComparable<FieldInfo>, IEquatable<FieldInfo>
{
    private const string EmptyNamespace = "NoNamespace";

    private readonly OpenXmlGeneratorServices _services;

    private readonly HashSet<SchemaType> _elementMetadata = new();
    private readonly HashSet<SchemaType> _parentMetadata = new();
    private readonly HashSet<SchemaType> _childMetadata = new();

    private readonly HashSet<SchemaType> _attributeContainerMetadata = new();
    private readonly HashSet<SchemaAttribute> _attributeMetadata = new();

    private readonly SortedSet<string> _attributePropertyNames = new();

    /// <summary>
    /// Initializes a new instance with the given <see cref="QName" />.
    /// </summary>
    /// <param name="qName">The <see cref="QName" />.</param>
    public FieldInfo(QName qName, OpenXmlGeneratorServices services)
    {
        QName = qName;
        FieldName = qName.Name;
        _services = services;
    }

    /// <summary>
    /// Gets the <see cref="QName" />.
    /// </summary>
    public QName QName { get; }

    /// <summary>
    /// Gets or sets the field name, e.g., "document".
    /// </summary>
    public string FieldName { get; set; }

    /// <summary>
    /// Gets the qualified field name, e.g., "W.document".
    /// </summary>
    public string QualifiedFieldName =>
        Prefix != string.Empty
            ? Prefix.ToUpperInvariant() + "." + FieldName
            : EmptyNamespace + "." + FieldName;

    /// <summary>
    /// Gets the XML prefix, e.g., "w".
    /// </summary>
    public string Prefix => QName.Prefix;

    /// <summary>
    /// Gets the XML namespace name, e.g., "http://schemas.openxmlformats.org/wordprocessingml/2006/main".
    /// </summary>
    public string NamespaceName => _services.GetNamespaceInfo(QName.Prefix).Uri;

    /// <summary>
    ///  Gets the XML local name, e.g., "document".
    /// </summary>
    public string LocalName => QName.Name;

    /// <summary>
    /// Gets the XML qualified name, e.g., "w:document".
    /// </summary>
    public string QualifiedName => string.IsNullOrEmpty(Prefix) ? LocalName : Prefix + ":" + LocalName;

    public IEnumerable<QName> ParentQualifiedNames =>
        _parentMetadata
            .OrderBy(GetQualifiedName)
            .Select(em => em.Name.QName)
            .Distinct();

    public IEnumerable<QName> ChildQualifiedNames =>
        _childMetadata
            .OrderBy(GetQualifiedName)
            .Select(em => em.Name.QName)
            .Distinct();

    public IEnumerable<QName> AttributeContainerQualifiedNames =>
        _attributeContainerMetadata
            .OrderBy(GetQualifiedName)
            .Select(em => em.Name.QName)
            .Distinct();

    public IEnumerable<QName> ElementAttributeQualifiedNames =>
        _elementMetadata
            .SelectMany(em => em.Attributes)
            .OrderBy(GetQualifiedName)
            .Select(am => am.QName)
            .Distinct();

    public IEnumerable<string> ElementClassNames =>
       _elementMetadata
            .Select(e => _services.FindClassName(e.Name, fullyQualified: false))
            .Distinct()
            .OrderBy(name => name);

    public IEnumerable<string> AttributePropertyNames => _attributePropertyNames;

    private static string GetQualifiedName(SchemaType metadata)
    {
        return GetQualifiedName(metadata.Name.QName);
    }

    private static string GetQualifiedName(SchemaAttribute metadata)
    {
        return GetQualifiedName(metadata.QName);
    }

    private static string GetQualifiedName(QName qName)
        => qName.ToString();

    public void AddElementMetadata(SchemaType element)
    {
        _elementMetadata.Add(element);
    }

    public void AddParentElementMetadata(SchemaType? parent)
    {
        if (parent is not null)
        {
            _parentMetadata.Add(parent);
        }
    }

    public void AddChildElementMetadata(SchemaType child)
    {
        _childMetadata.Add(child);
    }

    public void AddAttributeMetadata(SchemaType element, SchemaAttribute attribute)
    {
        _attributeContainerMetadata.Add(element);
        _attributeMetadata.Add(attribute);

        var className = _services.FindClassName(element.Name, fullyQualified: false);
        _attributePropertyNames.Add(className + "." + attribute.PropertyName);
    }

    /// <inheritdoc />
    public int CompareTo(FieldInfo? other)
    {
        return other is null ? 1 : QName.CompareTo(other.QName);
    }

    /// <inheritdoc />
    public bool Equals(FieldInfo? other)
        => other is not null && QName.Equals(other.QName);

    /// <inheritdoc />
    public override bool Equals(object? obj)
    {
        if (obj is null)
        {
            return false;
        }

        if (ReferenceEquals(this, obj))
        {
            return true;
        }

        return obj.GetType() == GetType() && Equals((FieldInfo)obj);
    }

    /// <inheritdoc />
    public override int GetHashCode()
    {
        return QName.GetHashCode();
    }

    public static bool operator ==(FieldInfo? left, FieldInfo? right)
    {
        return Equals(left, right);
    }

    public static bool operator !=(FieldInfo? left, FieldInfo? right)
    {
        return !Equals(left, right);
    }
}
