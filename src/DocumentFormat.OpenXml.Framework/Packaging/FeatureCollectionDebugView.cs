// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace DocumentFormat.OpenXml.Packaging;

internal sealed class FeatureCollectionDebugView
{
    private readonly IFeatureCollection _features;

    public FeatureCollectionDebugView(IFeatureCollection features)
    {
        _features = features;
    }

    public bool IsReadOnly => _features.IsReadOnly;

    public int Revision => _features.Revision;

    [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
    public FeatureItem[] Items => _features.Select(pair => new FeatureItem(pair.Key, pair.Value)).ToArray();

    [DebuggerTypeProxy(typeof(FeatureItemDebugView))]
    [DebuggerDisplay("{Value.GetType().ToString(),nq}", Name = "{Type.ToString(),nq}")]
    internal sealed class FeatureItem
    {
        public FeatureItem(Type type, object value)
        {
            Type = type;
            Value = value;
        }

        public Type Type { get; }

        public object Value { get; }
    }

    private sealed class FeatureItemDebugView
    {
        [DebuggerDisplay("{Value}", Name = "{Name,nq}", Type = "{Type.ToString(),nq}")]
        internal readonly struct Member
        {
            public Member(string name, object? value, Type type)
            {
                Name = name;
                Value = value;
                Type = type;
            }

            public string Name { get; }

            public object? Value { get; }

            public Type Type { get; }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly object _target;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly Type _type;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Member[]? _memberList;

        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
        internal Member[] Items => _memberList ??= BuildMemberList().ToArray();

        public FeatureItemDebugView(FeatureItem view)
        {
            _target = view.Value;
            _type = view.Type;
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Trimming", "IL2080:'this' argument does not satisfy 'DynamicallyAccessedMembersAttribute' in call to target method. The source field does not have matching annotations.", Justification = "This is only used for debug views and won't work in IL trimmed scenarios")]
        private List<Member> BuildMemberList()
        {
            var list = new List<Member>();

            if (_target == null)
            {
                return list;
            }

            var flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance;

            foreach (var field in _type.GetFields(flags))
            {
                object? value;
                try
                {
                    value = field.GetValue(_target);
                }
                catch (Exception ex)
                {
                    value = ex;
                }

                list.Add(new Member(field.Name, value, field.FieldType));
            }

            foreach (var prop in _type.GetProperties(flags))
            {
                object? value;
                try
                {
                    value = prop.GetValue(_target, null);
                }
                catch (Exception ex)
                {
                    value = ex;
                }

                list.Add(new Member(prop.Name, value, prop.PropertyType));
            }

            return list;
        }
    }
}
