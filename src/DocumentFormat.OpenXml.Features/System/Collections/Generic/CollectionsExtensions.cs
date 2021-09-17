// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

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
