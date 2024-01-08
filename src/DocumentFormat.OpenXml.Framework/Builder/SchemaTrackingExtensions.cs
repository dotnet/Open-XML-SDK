// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections.Generic;

using System.Diagnostics.CodeAnalysis;

#if NET6_0_OR_GREATER
using System.Collections.Immutable;
#else
using System.Linq;
#endif

namespace DocumentFormat.OpenXml.Builder;

/// <summary>
/// A collection of extension methods to track schema usage
/// </summary>
[Experimental(ExperimentalApis.AOT, UrlFormat = ExperimentalApis.UrlFormat)]
[Obsolete(ExperimentalApis.Message, DiagnosticId = ExperimentalApis.AOT, UrlFormat = ExperimentalApis.UrlFormat)]
internal static class SchemaTrackingExtensions
{
    private const string Key = "__SchemaTracker";

    /// <summary>
    /// This method enables tracking ability to see what parts and roots are created. In order to better support AOT scenarios,
    /// an empty package with no knowledge of any parts would be constructed and required parts would be added via additional builders.
    /// The debug information gathered with this may be helpful in identifying which parts are required to open packages.
    /// </summary>
    public static IPackageBuilder<T> UseSchemaTracker<T>(this IPackageBuilder<T> builder)
        where T : OpenXmlPackage
    {
        if (builder is null)
        {
            throw new ArgumentNullException(nameof(builder));
        }

        var tracker = builder.GetSchemaTracker();

        builder.Use((package, next) =>
        {
            package.Features.Set<ISchemaTrackingFeature>(tracker);

            var debugFeatures = new PerPackageSchemaTrackingFeature(tracker, package.Features.GetRequired<IRootElementFeature>(), package.Features.GetRequired<IPartFactoryFeature>());

            package.Features.Set<IRootElementFeature>(debugFeatures);
            package.Features.Set<IPartFactoryFeature>(debugFeatures);

            next(package);
        });

        return builder;
    }

    /// <summary>
    /// Gets the shared <see cref="ISchemaTrackingFeature"/> for the builder, or creates a new one if it is not available.
    /// </summary>
    public static ISchemaTrackingFeature GetSchemaTracker<T>(this IPackageBuilder<T> builder)
        where T : OpenXmlPackage
    {
        if (builder is null)
        {
            throw new ArgumentNullException(nameof(builder));
        }

        if (builder.Properties.TryGetValue(Key, out var existing) && existing is ISchemaTrackingFeature feature)
        {
            return feature;
        }

        feature = new SchemaTrackingFeature();
        builder.Properties[Key] = feature;
        return feature;
    }

    private sealed class SchemaTrackingFeature : ISchemaTrackingFeature
    {
        public ICollection<OpenXmlQualifiedName> RootElements { get; } = new ThreadSafeSet<OpenXmlQualifiedName>();

        public ICollection<string> Relationships { get; } = new ThreadSafeSet<string>();
    }

    private sealed class PerPackageSchemaTrackingFeature : IRootElementFeature, IPartFactoryFeature
    {
        private readonly IRootElementFeature _rootElementFeature;
        private readonly IPartFactoryFeature _partFactoryFeature;
        private readonly ISchemaTrackingFeature _info;

        public PerPackageSchemaTrackingFeature(ISchemaTrackingFeature info, IRootElementFeature rootElementFeature, IPartFactoryFeature partFactoryFeature)
        {
            _rootElementFeature = rootElementFeature;
            _partFactoryFeature = partFactoryFeature;
            _info = info;
        }

        OpenXmlPart? IPartFactoryFeature.Create(string relationshipType)
        {
            _info.Relationships.Add(relationshipType);
            return _partFactoryFeature.Create(relationshipType);
        }

        bool IRootElementFeature.TryCreate(in OpenXmlQualifiedName qName, [NotNullWhen(true)] out OpenXmlElement? element)
        {
            _info.RootElements.Add(qName);
            return _rootElementFeature.TryCreate(qName, out element);
        }
    }

#if NET6_0_OR_GREATER
    private sealed class ThreadSafeSet<T> : ICollection<T>
    {
        private ImmutableHashSet<T> _set = ImmutableHashSet.Create<T>();

        public int Count => _set.Count;

        public bool IsReadOnly => false;

        public void Add(T item) => ImmutableInterlocked.Update(ref _set, static (collection, item) => collection.Add(item), item);

        public void Clear() => ImmutableInterlocked.Update(ref _set, static collection => collection.Clear());

        public bool Contains(T item) => _set.Contains(item);

        public void CopyTo(T[] array, int arrayIndex) => ((ICollection<T>)_set).CopyTo(array, arrayIndex);

        public IEnumerator<T> GetEnumerator() => _set.GetEnumerator();

        public bool Remove(T item) => ImmutableInterlocked.Update(ref _set, static (collection, item) => collection.Remove(item), item);

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() => GetEnumerator();
    }
#else
    private sealed class ThreadSafeSet<T> : ICollection<T>
    {
        private readonly HashSet<T> _set = new();

        public int Count
        {
            get
            {
                lock (_set)
                {
                    return _set.Count;
                }
            }
        }

        public bool IsReadOnly => false;

        public void Add(T item)
        {
            lock (_set)
            {
                _set.Add(item);
            }
        }

        public void Clear()
        {
            lock (_set)
            {
                _set.Clear();
            }
        }

        public bool Contains(T item)
        {
            lock (_set)
            {
                return _set.Contains(item);
            }
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            lock (_set)
            {
                _set.CopyTo(array, arrayIndex);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            lock (_set)
            {
                return ((IEnumerable<T>)_set.ToArray()).GetEnumerator();
            }
        }

        public bool Remove(T item)
        {
            lock (_set)
            {
                return _set.Remove(item);
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() => GetEnumerator();
    }
#endif
}
