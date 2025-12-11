// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Generator.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DocumentFormat.OpenXml.Generator.Converters;

internal class QualifiedNameConverter : JsonConverter<QName>
{
    public override QName? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType != JsonTokenType.String)
        {
            throw new InvalidOperationException("QName must be encoded as a string");
        }

        var str = reader.GetString() ?? string.Empty;

        return QName.Parse(str);
    }

    public override void Write(Utf8JsonWriter writer, QName? value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}
