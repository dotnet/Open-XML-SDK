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
        public static void AddDisposableFeature(this OpenXmlPackage package)
        {
            if (package.Features.Get<IDisposableFeature>() is not null)
            {
                return;
            }

            package.AddPartEventsFeature();
            package.AddPackageEventsFeature();
            package.Features.AddDisposableFeature();

            // Add feature to all parts already created
            foreach (var part in package.GetAllParts())
            {
                part.Features.AddDisposableFeature();
            }
        }

        /// <summary>
        /// Adds disposable feature to the package a part is contained in.
        /// </summary>
        /// <param name="part">Part to add disposable feature to.</param>
        public static void AddDisposableFeature(this OpenXmlPart part)
        {
            if (part.Features.Get<IDisposableFeature>() is null)
            {
                part.OpenXmlPackage.AddDisposableFeature();
            }
        }

        /// <summary>
        /// Adds disposable feature.
        /// </summary>
        /// <param name="features">Features collection to add disposable feature to.</param>
        public static void AddDisposableFeature(this IFeatureCollection features)
        {
            if (features.Get<IDisposableFeature>() is null)
            {
                features.Set<IDisposableFeature>(new DisposableFeature());

                AddPackageEvents(features);
                AddPartEvents(features);
            }
        }

        private static void AddPackageEvents(this IFeatureCollection features)
        {
            var packageEvents = features.GetRequired<IPackageEventsFeature>();

            packageEvents.Change += PackageChanged;

            features.SetDisposable(new DelegateDisposable(() =>
            {
                packageEvents.Change -= PackageChanged;
            }));

            static void PackageChanged(FeatureEventArgs<OpenXmlPackage> arg)
            {
                if (arg.Type == EventType.Closed)
                {
                    arg.Argument.Features.Dispose();
                }
            }
        }

        private static void AddPartEvents(this IFeatureCollection features)
        {
            var partEvents = features.GetRequired<IPartEventsFeature>();

            partEvents.Change += PartChanged;

            features.SetDisposable(new DelegateDisposable(() =>
            {
                partEvents.Change -= PartChanged;
            }));

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

        private class DelegateDisposable : IDisposable
        {
            private readonly Action _action;

            public DelegateDisposable(Action action)
            {
                _action = action;
            }

            public void Dispose() => _action();
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
