// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Generator.Models;
using Newtonsoft.Json;

namespace DocumentFormat.OpenXml.Generator.Converters;

internal class TypedQNameConverter : JsonConverter<TypedQName>
{
    public override TypedQName? ReadJson(JsonReader reader, Type objectType, TypedQName? existingValue, bool hasExistingValue, JsonSerializer serializer)
    {
        if (reader.TokenType != JsonToken.String)
        {
            throw new InvalidOperationException("TypedQName must be encoded as a string");
        }

        var str = serializer.Deserialize<string>(reader) ?? string.Empty;
        var split = str.Split('/');

        if (split.Length != 2)
        {
            throw new InvalidOperationException("TypedQName must be encoded with two parts.");
        }

        return new TypedQName(QName.Parse(split[0]), QName.Parse(split[1]));
    }

    public override void WriteJson(JsonWriter writer, TypedQName? value, JsonSerializer serializer)
    {
        throw new NotImplementedException();
    }
}
