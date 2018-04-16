// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Reflection;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// A utility to parse the <see cref="EnumStringAttribute"/> and <see cref="OfficeAvailabilityAttribute"/>
    /// attributes on schema related enums. Performance profiling shows that iterating through each of the types
    /// every time this is needed is very detrimental for performance. This creates an instance of a lookup table
    /// and caches it on the initial call
    /// </summary>
    /// <typeparam name="TEnum">The type of the enum</typeparam>
    /// <remarks>
    /// Calls will throw <see cref="ArgumentOutOfRangeException"/> when <typeparamref name="TEnum"/> has the following
    /// characteristics:
    ///   - Does not have <see cref="int"/> as an underlying type
    ///   - Has custom values that are not in the range of [0, {EnumSize}]
    ///   - Does not have an <see cref="EnumStringAttribute"/> for each member
    ///   - Has no members
    /// </remarks>
    internal static class EnumStringLookup<TEnum>
        where TEnum : struct
    {
        private static EnumStringLookupImpl Instance { get; } = new EnumStringLookupImpl();

        public static bool TryParse(string name, out TEnum value) => Instance.TryParse(name, out value);

        public static string ToString(TEnum value) => Instance.ToString(value);

        public static FileFormatVersions GetVersion(TEnum value) => Instance.GetVersion(value);

        public static bool IsDefined(TEnum value) => Instance.IsDefined(value);

        private sealed class EnumStringLookupImpl
        {
            private readonly Dictionary<string, TEnum> _nameLookup;
            private readonly EnumStringInfo[] _enumInfo;

            public bool TryParse(string name, out TEnum value)
            {
                if (_nameLookup == null)
                {
                    throw new ArgumentOutOfRangeException(nameof(TEnum));
                }

                if (name == null)
                {
                    value = default;
                    return false;
                }

                return _nameLookup.TryGetValue(name, out value);
            }

            public string ToString(TEnum value) => Lookup(value).Name;

            public FileFormatVersions GetVersion(TEnum value) => Lookup(value).Versions;

            /// <summary>
            /// Custom implementation of IsDefined to minimize performance impact on many calls
            /// </summary>
            public bool IsDefined(TEnum value) => IsDefined(value, out _);

            private bool IsDefined(TEnum value, out int index)
            {
                if (_enumInfo == null)
                {
                    throw new ArgumentOutOfRangeException(nameof(TEnum));
                }

                index = Convert.ToInt32(value);

                return index >= 0 && index < _enumInfo.Length;
            }

            private EnumStringInfo Lookup(TEnum value)
            {
                if (!IsDefined(value, out var index))
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }

                return _enumInfo[index];
            }

            public EnumStringLookupImpl()
            {
                var enumType = typeof(TEnum).GetTypeInfo();

                if (!enumType.IsEnum)
                {
                    return;
                }

                if (Enum.GetUnderlyingType(typeof(TEnum)) != typeof(int))
                {
                    return;
                }

                var values = Enum.GetValues(typeof(TEnum));

                if (values.Length == 0)
                {
                    return;
                }

                var nameLookup = new Dictionary<string, TEnum>(values.Length, StringComparer.Ordinal);
                var enumInfo = new EnumStringInfo[values.Length];

                foreach (var enumVal in values)
                {
                    var field = enumType.GetDeclaredField(enumVal.ToString());
                    var enumString = field.GetCustomAttribute<EnumStringAttribute>();
                    var officeAvailability = field.GetCustomAttribute<OfficeAvailabilityAttribute>();

                    if (enumString == null)
                    {
                        return;
                    }

                    nameLookup.Add(enumString.Value, (TEnum)enumVal);

                    var versions = officeAvailability?.OfficeVersion ?? FileFormatVersions.Office2007.AndLater();

                    var index = Convert.ToInt32(enumVal);

                    if (index < 0 || index >= enumInfo.Length)
                    {
                        return;
                    }

                    enumInfo[index] = new EnumStringInfo(versions, enumString.Value);
                }

                _nameLookup = nameLookup;
                _enumInfo = enumInfo;
            }
        }

        private readonly struct EnumStringInfo
        {
            public EnumStringInfo(FileFormatVersions versions, string name)
            {
                Versions = versions;
                Name = name;
            }

            public FileFormatVersions Versions { get; }

            public string Name { get; }
        }
    }
}
