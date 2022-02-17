// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Generator.Models;
using Newtonsoft.Json;

namespace DocumentFormat.OpenXml.Generator.Converters;

internal class QualifiedNameConverter : JsonConverter<QName>
{
    public override QName? ReadJson(JsonReader reader, Type objectType, QName? existingValue, bool hasExistingValue, JsonSerializer serializer)
    {
        if (reader.TokenType != JsonToken.String)
        {
            throw new InvalidOperationException("QName must be encoded as a string");
        }

        var str = serializer.Deserialize<string>(reader) ?? string.Empty;

        return QName.Parse(str);
    }

    public override void WriteJson(JsonWriter writer, QName? value, JsonSerializer serializer)
    {
        throw new NotImplementedException();
    }
}
