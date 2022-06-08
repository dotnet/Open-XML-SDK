// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

namespace DocumentFormat.OpenXml.Generator.Models;

public class SchemaElement
{
    private string? _propertyComments;

    public TypedQName Name { get; set; } = null!;

    public string PropertyName { get; set; } = null!;

    public string PropertyComments
    {
        get => _propertyComments ?? PropertyName;
        set => _propertyComments = value;
    }
}
