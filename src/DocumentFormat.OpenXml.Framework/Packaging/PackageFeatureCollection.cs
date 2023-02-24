// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace DocumentFormat.OpenXml.Packaging;

internal partial class PackageFeatureCollection :
    IFeatureCollection,
    IPartFactoryFeature,
    IApplicationTypeFeature,
    IDisposableFeature,
    IContainerDisposableFeature,
    ISaveFeature,
    IDataPartsFeature,
    IPartsFeature
{
    private readonly IFeatureCollection? _parent;

    private Action<OpenXmlPartContainer>? _save;
    private Action? _disposable;
    private FeatureContainer _container;
    private LinkedList<DataPart>? _dataParts;
    private Dictionary<Uri, OpenXmlPart>? _parts;

    public PackageFeatureCollection(OpenXmlPackage package, IFeatureCollection? parent)
    {
        Package = package;
        _parent = parent;
    }

    protected OpenXmlPackage Package { get; }

    public bool IsReadOnly => false;

    public int Revision => _container.Revision + (_parent?.Revision ?? 0);

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
    private partial T? GetInternal<T>();

    private IPartUriFeature CreatePartUri() => new PackagePartUriHelper(this.GetRequired<IPackageFeature>().Package);

    public void Set<TFeature>(TFeature? instance)
        => _container.Set(instance);

    OpenXmlPart? IPartFactoryFeature.Create(string relationshipType) => null;

    void IDisposableFeature.Register(IDisposable disposable) => _disposable = disposable.Dispose + _disposable;

    void IContainerDisposableFeature.Dispose() => _disposable?.Invoke();

    void ISaveFeature.Save(OpenXmlPartContainer container)
        => _save?.Invoke(container);

    void ISaveFeature.Register(Action<OpenXmlPartContainer> container)
        => _save += container;

    bool IDataPartsFeature.TryGetDataPart(Uri uri, [MaybeNullWhen(false)] out DataPart dataPart)
    {
        if (_dataParts is not null)
        {
            foreach (var part in _dataParts)
            {
                if (part.Uri == uri)
                {
                    dataPart = part;
                    return true;
                }
            }
        }

        dataPart = null;
        return false;
    }

    IEnumerable<DataPart> IDataPartsFeature.Parts => _dataParts ?? Enumerable.Empty<DataPart>();

    int IDataPartsFeature.Count => _dataParts?.Count ?? 0;

    void IDataPartsFeature.Add(DataPart dataPart)
        => (_dataParts ??= new()).AddLast(dataPart);

    bool IPartsFeature.TryGetPart(Uri uri, [MaybeNullWhen(false)] out OpenXmlPart part)
    {
        if (_parts is null)
        {
            part = null;
            return false;
        }

        return _parts.TryGetValue(uri, out part);
    }

    void IPartsFeature.Add(Uri uri, OpenXmlPart part)
        => (_parts ??= new()).Add(uri, part);

    bool IDataPartsFeature.Remove(DataPart dataPart)
    {
        if (_dataParts is null)
        {
            return false;
        }

        return _dataParts.Remove(dataPart);
    }

    bool IPartsFeature.Contains(Uri uri)
        => _parts?.ContainsKey(uri) ?? false;
}
