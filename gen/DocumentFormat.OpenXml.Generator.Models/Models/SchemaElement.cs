// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

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
