// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Features;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Packaging;
using System.Linq;

namespace DocumentFormat.OpenXml.Packaging
{
    internal partial class PackageFeatureCollection :
        IFeatureCollection,
        IContainerFeature<OpenXmlPackage>,
        IPartFactoryFeature,
        IApplicationTypeFeature,
        IDisposableFeature,
        IContainerDisposableFeature
    {
        private readonly IFeatureCollection? _parent;

        private Action? _disposable;
        private FeatureContainer _container;

        public PackageFeatureCollection(OpenXmlPackage package, IFeatureCollection? parent)
        {
            Package = package;
            _parent = parent;
        }

        protected OpenXmlPackage Package { get; }

        public bool IsReadOnly => false;

        public int Revision => _container.Revision + (_parent?.Revision ?? 0);

        OpenXmlPackage IContainerFeature<OpenXmlPackage>.Value => Package;

        ApplicationType IApplicationTypeFeature.Type => ApplicationType.None;

        public TFeature? Get<TFeature>()
        {
            if (_container.Get<TFeature>() is { } other)
            {
                return other;
            }

            if (this is TFeature @this)
            {
                return @this;
            }

            if (GetInternal<TFeature>() is { } @internal)
            {
                return @internal;
            }

            if (_parent is { } p && p.Get<TFeature>() is { } parent)
            {
                return parent;
            }

            return default;
        }

        [KnownFeature(typeof(IPartUriFeature), Factory = nameof(CreatePartUri))]
        [KnownFeature(typeof(AnnotationsFeature))]
        [KnownFeature(typeof(IPartExtensionFeature), typeof(PartExtensionProvider))]
        [KnownFeature(typeof(IChildRelationshipPartFeatures), Factory = nameof(CreateChildParts))]
        private partial T? GetInternal<T>();

        private IChildRelationshipPartFeatures CreateChildParts() => new PartDictionary(this);

        private IPartUriFeature CreatePartUri() => new PackagePartUriHelper(this.GetRequired<IPackageFeature>().Package);

        public void Set<TFeature>(TFeature? instance)
            => _container.Set(instance);

        OpenXmlPart? IPartFactoryFeature.Create(string relationshipType) => null;

        void IDisposableFeature.Register(IDisposable disposable) => _disposable = disposable.Dispose + _disposable;

        void IContainerDisposableFeature.Dispose() => _disposable?.Invoke();
    }
}
