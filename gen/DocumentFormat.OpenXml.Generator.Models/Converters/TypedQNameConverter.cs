// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Generator.Models;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DocumentFormat.OpenXml.Generator.Converters;

internal class TypedQNameConverter : JsonConverter<TypedQName>
{
    public override TypedQName? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType != JsonTokenType.String)
        {
            throw new InvalidOperationException("TypedQName must be encoded as a string");
        }

        var str = reader.GetString() ?? string.Empty;
        var split = str.Split('/');

        if (split.Length != 2)
        {
            throw new InvalidOperationException("TypedQName must be encoded with two parts.");
        }

        return new TypedQName(QName.Parse(split[0]), QName.Parse(split[1]));
    }

    public override void Write(Utf8JsonWriter writer, TypedQName value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}
