// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Generator.Models;

public class SchemaAttribute
{
    private string? _propertyName;

    public QName QName { get; set; } = null!;

    public string PropertyName
    {
        get
        {
            if (_propertyName is null && QName.Name is not null)
            {
                _propertyName = QName.Name.Substring(0, 1).ToUpper() + QName.Name.Substring(1);
            }

            return _propertyName ?? string.Empty;
        }
        set => _propertyName = value;
    }

    public string Type { get; set; } = null!;

    public OfficeVersion Version { get; set; }

    public string PropertyComments { get; set; } = null!;

    public IEnumerable<Validator> Validators { get; set; } = Enumerable.Empty<Validator>();
}
