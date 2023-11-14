// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#if !NET5_0_OR_GREATER
using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml;

internal static class DictionaryExtensions
{
    public static bool TryAdd<TKey, TValue>(this Dictionary<TKey, TValue> dict, TKey key, TValue value)
    {
        if (dict.ContainsKey(key))
        {
            return false;
        }

        dict.Add(key, value);
        return true;
    }
}
#endif
