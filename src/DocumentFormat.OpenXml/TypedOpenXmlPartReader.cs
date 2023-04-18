// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Packaging;
using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;

namespace DocumentFormat.OpenXml;

/// <summary>
/// Represents an implementation of <see cref="OpenXmlPartReader"/> that is aware of the strongly typed classes.
/// </summary>
public sealed class TypedOpenXmlPartReader : OpenXmlPartReader
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TypedOpenXmlPartReader"/> class.
    /// </summary>
    /// <param name="partStream">The stream of the part contents.</param>
    /// <param name="options">Options for how to read the part stream.</param>
    public TypedOpenXmlPartReader(Stream partStream, OpenXmlPartReaderOptions options = default)
        : base(partStream, new TypedFeatures(), options)
    {
    }

    private sealed class TypedFeatures : IFeatureCollection, IRootElementFeature
    {
        private readonly IRootElementFeature[] _features;

        public TypedFeatures()
        {
            using var word = new WordprocessingDocument();
            using var excel = new SpreadsheetDocument();
            using var ppt = new PresentationDocument();

            _features = new[]
            {
                word.Features.GetRequired<IRootElementFeature>(),
                excel.Features.GetRequired<IRootElementFeature>(),
                ppt.Features.GetRequired<IRootElementFeature>(),
            };
        }

        bool IFeatureCollection.IsReadOnly => true;

        int IFeatureCollection.Revision => 0;

        public bool TryCreate(in OpenXmlQualifiedName qname, [NotNullWhen(true)] out OpenXmlElement? element)
        {
            foreach (var f in _features)
            {
                if (f.TryCreate(qname, out element))
                {
                    return true;
                }
            }

            element = null;
            return false;
        }

        public TFeature? Get<TFeature>()
        {
            if (typeof(TFeature) == typeof(IRootElementFeature))
            {
                return (TFeature?)(object)this;
            }

            return FeatureCollection.Default.Get<TFeature>();
        }

        void IFeatureCollection.Set<TFeature>(TFeature? instance) where TFeature : default
        {
            throw new NotSupportedException();
        }
    }
}
