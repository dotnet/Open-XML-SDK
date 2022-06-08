// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

internal static class CollectionsExtensions
{
    public static bool Remove<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey key, [MaybeNullWhen(false)] out TValue existing)
        where TKey : notnull
    {
        if (dictionary.TryGetValue(key, out existing))
        {
            dictionary.Remove(key);
            return true;
        }

        return false;
    }
}
