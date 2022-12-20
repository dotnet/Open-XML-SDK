// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace DocumentFormat.OpenXml.Packaging
{
    internal class PartDictionary
    {
        private object? _holder;
        private Dictionary<string, OpenXmlPart>? _parts;

        public PartDictionary(OpenXmlPartContainer container)
        {
            _holder = container;
        }

        private IPartEventsFeature? Events
        {
            get
            {
                if (_holder is IPartEventsFeature events)
                {
                    return events;
                }
                else if (_holder is OpenXmlPartContainer container)
                {
                    var feature = container.Features.Get<IPartEventsFeature>();
                    _holder = feature;
                    return feature;
                }

                return null;
            }
        }

        public Dictionary<string, OpenXmlPart>.ValueCollection Values => Parts.Values;

        public void Add(string uri, OpenXmlPart part)
        {
            Events?.OnChange(part, EventType.Creating);

            Parts.Add(uri, part);

            Events?.OnChange(part, EventType.Created);
        }

        public void Clear()
        {
            if (_parts is null)
            {
                return;
            }

            if (Events is IPartEventsFeature events)
            {
                // On .NET 5.0 and later, we can remove keys while enumerating. Before that, it would throw at runtime.
#if NET5_0_OR_GREATER
                foreach (var kv in _parts)
                {
                    events.OnChange(kv.Value, EventType.Removing);
                    _parts.Remove(kv.Key);
                    events.OnChange(kv.Value, EventType.Removed);
                }
#else
                var parts = _parts;

                foreach (var kv in parts)
                {
                    events.OnChange(kv.Value, EventType.Removing);
                    events.OnChange(kv.Value, EventType.Removed);
                }
#endif
            }

            _parts = null;
        }

        public int Count => _parts is null ? 0 : _parts.Count;

        public bool ContainsValue(OpenXmlPart part) => _parts is null ? false : _parts.ContainsValue(part);

        public bool ContainsKey(string uri) => _parts is null ? false : _parts.ContainsKey(uri);

        public bool TryGetValue(string uri, [MaybeNullWhen(false)] out OpenXmlPart part)
        {
            if (_parts is null)
            {
                part = null;
                return false;
            }

            return _parts.TryGetValue(uri, out part);
        }

        private Dictionary<string, OpenXmlPart> Parts
        {
            get
            {
                if (_parts is null)
                {
                    _parts = new(StringComparer.Ordinal);
                }

                return _parts;
            }
        }

        public Dictionary<string, OpenXmlPart>.Enumerator GetEnumerator() => Parts.GetEnumerator();

        public void Remove(string uri)
        {
            if (_parts is null)
            {
                return;
            }

            if (_parts.TryGetValue(uri, out var part))
            {
                Events?.OnChange(part, EventType.Removing);
                _parts.Remove(uri);
                Events?.OnChange(part, EventType.Removed);
            }
        }
    }
}
