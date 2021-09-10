// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework.Features;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace DocumentFormat.OpenXml.Packaging
{
    internal class PartDictionary
    {
        private readonly OpenXmlPartContainer _container;
        private readonly Dictionary<string, OpenXmlPart> _parts = new(StringComparer.Ordinal);

        private IPartEventsFeature? _events;

        public PartDictionary(OpenXmlPartContainer container)
        {
            _container = container;
        }

        public IPartEventsFeature? Events
        {
            get
            {
                if (_events is null)
                {
                    _events = _container.Features.Get<IPartEventsFeature>();
                }

                return _events;
            }
        }

        public Dictionary<string, OpenXmlPart>.ValueCollection Values => _parts.Values;

        public void Add(string uri, OpenXmlPart part)
        {
            Events?.OnChange(part, EventType.Creating);
            _parts.Add(uri, part);
            Events?.OnChange(part, EventType.Created);
        }

        public void Clear()
        {
            if (Events is null)
            {
                _parts.Clear();
            }
            else
            {
                foreach (var kv in _parts)
                {
                    Events.OnChange(kv.Value, EventType.Removing);
                    Remove(kv.Key);
                    Events.OnChange(kv.Value, EventType.Removed);
                }
            }
        }

        public int Count => _parts.Count;

        public bool ContainsValue(OpenXmlPart part) => _parts.ContainsValue(part);

        public bool ContainsKey(string uri) => _parts.ContainsKey(uri);

        public bool TryGetValue(string uri, [MaybeNullWhen(false)] out OpenXmlPart part) => _parts.TryGetValue(uri, out part);

        public Dictionary<string, OpenXmlPart>.Enumerator GetEnumerator() => _parts.GetEnumerator();

        public void Remove(string uri)
        {
            if (_parts.TryGetValue(uri, out var part))
            {
                Events?.OnChange(part, EventType.Removing);
                _parts.Remove(uri);
                Events?.OnChange(part, EventType.Removed);
            }
        }
    }
}
