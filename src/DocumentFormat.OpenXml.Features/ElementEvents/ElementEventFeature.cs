// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Features
{
    internal class ElementEventFeature : IDisposable, IElementEventFeature
    {
        private readonly Dictionary<OpenXmlPart, ElementContextHolder> _rootElements = new();
        private readonly IPartRootEventsFeature _rootEvents;

        public ElementEventFeature(IPartRootEventsFeature rootEvents)
        {
            _rootEvents = rootEvents;

            _rootEvents.Change += RootEventsChange;
        }

        public event Action<FeatureEventArgs<PartElementEventArgs>>? Change;

        private void RootEventsChange(FeatureEventArgs<OpenXmlPart> obj)
        {
            if (obj.Type == EventType.Created)
            {
                Register(obj.Argument);
            }
            else if (obj.Type == EventType.Removed)
            {
                if (_rootElements.Remove(obj.Argument, out var existing))
                {
                    // Unregister events
                    existing.Dispose();
                }
            }
        }

        private void Register(OpenXmlPart part)
        {
            if (part.RootElement?.OpenXmlElementContext is not OpenXmlElementContext context)
            {
                return;
            }

            if (_rootElements.TryGetValue(part, out var existing))
            {
                if (ReferenceEquals(existing.Context, context))
                {
                    return;
                }

                // Unregister events
                existing.Dispose();

                _rootElements.Remove(part);
            }

            context.ElementInserting += ContextElementInserting;
            context.ElementInserted += ContextElementInserted;
            context.ElementRemoved += ContextElementRemoved;
            context.ElementRemoving += ContextElementRemoving;

            _rootElements.Add(part, new(context, Dispose));

            RaiseOnLoad(part);

            void ContextElementInserting(object? sender, ElementEventArgs e)
            {
                Change?.Invoke(new FeatureEventArgs<PartElementEventArgs>(EventType.Adding, new PartElementEventArgs(part, e)));
            }

            void ContextElementInserted(object? sender, ElementEventArgs e)
            {
                Change?.Invoke(new FeatureEventArgs<PartElementEventArgs>(EventType.Added, new PartElementEventArgs(part, e)));
            }

            void ContextElementRemoved(object? sender, ElementEventArgs e)
            {
                Change?.Invoke(new FeatureEventArgs<PartElementEventArgs>(EventType.Removed, new PartElementEventArgs(part, e)));
            }

            void ContextElementRemoving(object? sender, ElementEventArgs e)
            {
                Change?.Invoke(new FeatureEventArgs<PartElementEventArgs>(EventType.Removing, new PartElementEventArgs(part, e)));
            }

            void Dispose()
            {
                context.ElementInserting -= ContextElementInserting;
                context.ElementInserted -= ContextElementInserted;
                context.ElementRemoved -= ContextElementRemoved;
                context.ElementRemoving -= ContextElementRemoving;
            }
        }

        private void RaiseOnLoad(OpenXmlPart part)
        {
            if (part.RootElement is not null && Change is Action<FeatureEventArgs<PartElementEventArgs>> onChange)
            {
                foreach (var element in part.RootElement.Descendants())
                {
                    onChange(new FeatureEventArgs<PartElementEventArgs>(EventType.Reloading, new PartElementEventArgs(part, element, null)));
                }
            }
        }

        public void Dispose()
        {
            _rootEvents.Change -= RootEventsChange;
        }

        private readonly struct ElementContextHolder
        {
            private readonly Action _action;

            public ElementContextHolder(OpenXmlElementContext context, Action action)
            {
                Context = context;
                _action = action;
            }

            public OpenXmlElementContext Context { get; }

            public void Dispose() => _action();
        }
    }
}
