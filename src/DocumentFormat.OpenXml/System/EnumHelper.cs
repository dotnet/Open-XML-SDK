// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using System;

namespace DocumentFormat.OpenXml
{
    internal static class EnumHelper
    {
#if NET35
        public static bool TryParse<TEnum>(string? value, out TEnum result)
            where TEnum : struct
        {
            try
            {
                result = (TEnum)Enum.Parse(typeof(TEnum), value);
                return true;
            }
            catch (Exception)
            {
                result = default;
                return false;
            }
        }
#else
        public static bool TryParse<TEnum>(string? value, out TEnum result)
            where TEnum : struct
            => Enum.TryParse(value, out result);
#endif
    }
}
