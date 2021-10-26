// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Features
{
    /// <summary>
    /// Extension methods to add retrieve disposable features.
    /// </summary>
    public static class DisposableFeatureExtensions
    {
        /// <summary>
        /// Adds disposable feature.
        /// </summary>
        /// <param name="package">Package to add disposable feature to.</param>
        public static bool TryAddDisposableFeature(this OpenXmlPackage package)
        {
            package.TryAddPartEventsFeature();
            package.TryAddPackageEventsFeature();

            if (package.Features.TryAddDisposableFeature())
            {
                // Add feature to all parts already created
                foreach (var part in package.GetAllParts())
                {
                    part.Features.Set<IDisposableFeature>(new DisposableFeature());
                }

                return true;
            }

            return false;
        }

        /// <summary>
        /// Adds disposable feature to the package a part is contained in.
        /// </summary>
        /// <param name="part">Part to add disposable feature to.</param>
        public static bool TryAddDisposableFeature(this OpenXmlPart part)
        {
            if (part.Features.Get<IDisposableFeature>() is null)
            {
                return part.OpenXmlPackage.TryAddDisposableFeature();
            }

            return false;
        }

        /// <summary>
        /// Adds disposable feature.
        /// </summary>
        /// <param name="features">Features collection to add disposable feature to.</param>
        public static bool TryAddDisposableFeature(this IFeatureCollection features)
        {
            if (features.Get<IDisposableFeature>() is not null)
            {
                return false;
            }

            var feature = new DisposableFeature();

            features.Set<IDisposableFeature>(feature);

            var packageEvents = features.GetRequired<IPackageEventsFeature>();
            packageEvents.Change += PackageChanged;

            // Add events to add to any new events
            var events = features.GetRequired<IPartEventsFeature>();

            events.Change += PartChanged;

            feature.Register(new DelegateDisposable(() =>
            {
                events.Change -= PartChanged;
                packageEvents.Change -= PackageChanged;
            }));

            return true;

            static void PackageChanged(FeatureEventArgs<OpenXmlPackage> arg)
            {
                if (arg.Type == EventType.Closed)
                {
                    arg.Argument.Features.Dispose();
                }
            }

            static void PartChanged(FeatureEventArgs<OpenXmlPart> arg)
            {
                if (arg.Type == EventType.Created)
                {
                    arg.Argument.Features.Set<IDisposableFeature>(new DisposableFeature());
                }
                else if (arg.Type == EventType.Removed)
                {
                    arg.Argument.Features.Dispose();
                }
            }
        }

        private class DelegateDisposable : IDisposable
        {
            private readonly Action _action;

            public DelegateDisposable(Action action)
            {
                _action = action;
            }

            public void Dispose() => _action();
        }

        /// <summary>
        /// Register a feature into the collection and to be disposed.
        /// </summary>
        /// <typeparam name="TFeature">Type of feature.</typeparam>
        /// <param name="features">Feature collection.</param>
        /// <param name="feature">Feature to register.</param>
        public static void SetDisposable<TFeature>(this IFeatureCollection features, TFeature feature)
        {
            var disposable = features.GetRequired<IDisposableFeature>();

            if (feature is IDisposable d)
            {
                disposable.Register(d);
            }

            features.Set(feature);
        }

        internal static void Dispose(this IFeatureCollection features)
        {
            if (features.Get<IDisposableFeature>() is IDisposable feature)
            {
                feature.Dispose();
            }
        }

        private sealed class DisposableFeature : IDisposableFeature, IDisposable
        {
            private List<IDisposable>? _list;

            public void Dispose()
            {
                if (_list is null)
                {
                    return;
                }

                foreach (var item in _list)
                {
                    item.Dispose();
                }

                _list = null;
            }

            public void Register(IDisposable disposable)
            {
                if (_list is null)
                {
                    _list = new();
                }

                _list.Add(disposable);
            }
        }
    }
}
