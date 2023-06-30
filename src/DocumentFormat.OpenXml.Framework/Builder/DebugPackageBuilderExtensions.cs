// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Packaging;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

#if NET6_0_OR_GREATER
using System.Collections.Immutable;
#else
using System.Linq;
#endif

namespace DocumentFormat.OpenXml.Builder;

internal static class DebugPackageBuilderExtensions
{
    /// <summary>
    /// This method enables tracking ability to see what parts and roots are created. In order to better support AOT scenarios,
    /// an empty package with no knowledge of any parts would be constructed and required parts would be added via additional builders.
    /// The debug information gathered with this may be helpful in identifying which parts are required to open packages.
    /// </summary>
    public static OpenXmlPackageBuilder<T> UseDebugTracking<T>(this OpenXmlPackageBuilder<T> builder)
        where T : OpenXmlPackage
    {
        var info = new DebugInfo();

        builder.Use((package, next) =>
        {
            package.Features.Set<IDebugPackageInformation>(info);

            var debugFeatures = new DebugFeatures(info, package.Features.GetRequired<IRootElementFeature>(), package.Features.GetRequired<IPartFactoryFeature>());

            package.Features.Set<IRootElementFeature>(debugFeatures);
            package.Features.Set<IPartFactoryFeature>(debugFeatures);
        });

        return builder;
    }

#if NET6_0_OR_GREATER
    private sealed class DebugInfo : IDebugPackageInformation
    {
        private ImmutableHashSet<OpenXmlQualifiedName> _rootElements = ImmutableHashSet.Create<OpenXmlQualifiedName>();
        private ImmutableHashSet<string> _relationships = ImmutableHashSet.Create<string>();

        public void Add(OpenXmlQualifiedName qname) => _rootElements = _rootElements.Add(qname);

        public void Add(string relationship) => _relationships.Add(relationship);

        IEnumerable<OpenXmlQualifiedName> IDebugPackageInformation.RootElements => _rootElements;

        IEnumerable<string> IDebugPackageInformation.Relationships => _relationships;
    }
#else
    private sealed class DebugInfo : IDebugPackageInformation
    {
        private readonly HashSet<OpenXmlQualifiedName> _rootElements = new();
        private readonly HashSet<string> _relationships = new();

        public void Add(OpenXmlQualifiedName qname)
        {
            lock (_rootElements)
            {
                _rootElements.Add(qname);
            }
        }

        public void Add(string relationship)
        {
            lock (_relationships)
            {
                _relationships.Add(relationship);
            }
        }

        IEnumerable<OpenXmlQualifiedName> IDebugPackageInformation.RootElements
        {
            get
            {
                lock (_rootElements)
                {
                    return _rootElements.ToArray();
                }
            }
        }

        IEnumerable<string> IDebugPackageInformation.Relationships 
        {
            get
            {
                lock (_relationships)
                {
                    return _relationships.ToArray();
                }
            }
        }
    }
#endif

    private sealed class DebugFeatures : IRootElementFeature, IPartFactoryFeature
    {
        private readonly IRootElementFeature _rootElementFeature;
        private readonly IPartFactoryFeature _partFactoryFeature;
        private readonly DebugInfo _info;

        public DebugFeatures(DebugInfo info, IRootElementFeature rootElementFeature, IPartFactoryFeature partFactoryFeature)
        {
            _rootElementFeature = rootElementFeature;
            _partFactoryFeature = partFactoryFeature;
            _info = info;
        }

        OpenXmlPart? IPartFactoryFeature.Create(string relationshipType)
        {
            _info.Add(relationshipType);
            return _partFactoryFeature.Create(relationshipType);
        }

        bool IRootElementFeature.TryCreate(in OpenXmlQualifiedName qname, [NotNullWhen(true)] out OpenXmlElement? element)
        {
            _info.Add(qname);
            return _rootElementFeature.TryCreate(qname, out element);
        }
    }
}
