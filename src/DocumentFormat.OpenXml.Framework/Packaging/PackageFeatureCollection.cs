// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace DocumentFormat.OpenXml.Packaging;

internal partial class PackageFeatureCollection :
    FeatureCollectionBase,
    IFeatureCollection,
    IPartFactoryFeature,
    IApplicationTypeFeature,
    IDisposableFeature,
    IContainerDisposableFeature,
    ISaveFeature,
    IDataPartsFeature,
    IPartsFeature
{
    private Action<OpenXmlPartContainer>? _save;
    private Action? _disposable;
    private LinkedList<DataPart>? _dataParts;
    private Dictionary<Uri, OpenXmlPart>? _parts;

    private IPartUriFeature? _partUriFeature;
    private AnnotationsFeature? _annotationFeature;
    private IPartExtensionFeature? _partExtensionFeature;

    private static readonly Type[] _known = new[] { typeof(IPartUriFeature), typeof(AnnotationsFeature), typeof(IPartExtensionFeature) };

    public PackageFeatureCollection(OpenXmlPackage package)
        : base(FeatureCollection.Default)
    {
        Package = package;
    }

    protected OpenXmlPackage Package { get; }

    ApplicationType IApplicationTypeFeature.Type => ApplicationType.None;

    protected override object? GetKnown(Type key)
    {
        if (key == typeof(IPartUriFeature))
        {
            return _partUriFeature ??= new PackagePartUriHelper(this.GetRequired<IPackageFeature>().Package);
        }

        if (key == typeof(AnnotationsFeature))
        {
            return _annotationFeature ??= new();
        }

        if (key == typeof(IPartExtensionFeature))
        {
            return _partExtensionFeature ??= new PartExtensionProvider();
        }

        return null;
    }

    protected override IEnumerable<Type> KnownTypes => _known;

    OpenXmlPart? IPartFactoryFeature.Create(string relationshipType) => null;

    void IDisposableFeature.Register(Action disposable) => _disposable = disposable + _disposable;

    void IContainerDisposableFeature.Dispose()
    {
        _disposable?.Invoke();
        _disposable = null;
    }

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
