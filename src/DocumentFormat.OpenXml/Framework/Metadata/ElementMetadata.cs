// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Validation.Schema;
using DocumentFormat.OpenXml.Validation.Semantic;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DocumentFormat.OpenXml.Framework.Metadata
{
    internal class ElementMetadata
    {
        private static readonly ConcurrentDictionary<Type, ElementMetadata> _lookup = new ConcurrentDictionary<Type, ElementMetadata>(new[]
        {
            new KeyValuePair<Type, ElementMetadata>(typeof(OpenXmlUnknownElement), new ElementMetadata()),
            new KeyValuePair<Type, ElementMetadata>(typeof(OpenXmlMiscNode), new ElementMetadata()),
        });

        private readonly Lazy<ElementLookup>? _children;

        internal ElementMetadata(
            ReadOnlyArray<AttributeMetadata> attributes,
            ReadOnlyArray<IValidator> validators,
            ReadOnlyArray<IValidator> constraints,
            FileFormatVersions version,
            OpenXmlQualifiedName qname,
            CompiledParticle? particle,
            Lazy<ElementLookup> lookup)
        {
            Attributes = attributes;
            Validators = validators;
            Constraints = constraints;
            Availability = version;
            QName = qname;
            Particle = particle;
            _children = lookup;
        }

        private ElementMetadata()
        {
        }

        public ReadOnlyArray<AttributeMetadata> Attributes { get; }

        public ElementLookup Children => _children?.Value ?? ElementLookup.Empty;

        public ReadOnlyArray<IValidator> Validators { get; }

        public ReadOnlyArray<IValidator> Constraints { get; }

        public FileFormatVersions Availability { get; }

        public CompiledParticle? Particle { get; }

        public OpenXmlQualifiedName QName { get; }

        public static ElementMetadata Create(OpenXmlElement element)
        {
            var type = element.GetType();

            // Use TryGetValue first for the common case of already existing types to limit number of allocations
            if (_lookup.TryGetValue(type, out var result))
            {
                return result;
            }

            var metadata = CreateInternal(element);

            _lookup.TryAdd(type, metadata);

            return metadata;
        }

        public static ElementMetadata Create<TElement>()
            where TElement : OpenXmlElement, new()
            => _lookup.GetOrAdd(typeof(TElement), t => CreateInternal(new TElement()));

        private static ElementMetadata CreateInternal(OpenXmlElement element)
        {
            var builder = new Builder();

            element.ConfigureMetadata(builder);

            return builder.Build();
        }

        public class Builder : ValidatorBuilder
        {
            private static readonly Lazy<ElementLookup> _lazy = new Lazy<ElementLookup>(() => ElementLookup.Empty, true);

            private List<IMetadataBuilder<AttributeMetadata>>? _attributes;
            private HashSet<IMetadataBuilder<ElementLookup.ElementChild>>? _children;
            private List<IValidator>? _constraints;
            private OpenXmlQualifiedName _qname;

            public Builder<TElement> AddElement<TElement>()
                where TElement : OpenXmlElement
            {
                return new Builder<TElement>(this);
            }

            public void AddConstraint(SemanticConstraint constraint)
            {
                if (_constraints is null)
                {
                    _constraints = new List<IValidator>();
                }

                _constraints.Add(constraint);
            }

            public CompositeParticle? Particle { get; set; }

            public void SetSchema(in OpenXmlQualifiedName qname)
                => _qname = qname;

            public void SetSchema(string ns, string localName)
                => SetSchema(new OpenXmlQualifiedName(ns, localName));

            public void SetSchema(byte nsId, string localName)
                => SetSchema(new OpenXmlQualifiedName(new OpenXmlNamespace(nsId), localName));

            public void AddChild<T>()
                where T : OpenXmlElement, new()
            {
                if (_children is null)
                {
                    _children = new HashSet<IMetadataBuilder<ElementLookup.ElementChild>>();
                }

                _children.Add(new KnownChild<T>());
            }

            public FileFormatVersions Availability { get; set; } = FileFormatVersions.Office2007;

            public void Add(IMetadataBuilder<AttributeMetadata> builder)
            {
                if (_attributes is null)
                {
                    _attributes = new List<IMetadataBuilder<AttributeMetadata>>();
                }

                _attributes.Add(builder);
            }

            public ElementMetadata Build()
            {
                var lookup = _children is null ? _lazy : new Lazy<ElementLookup>(() => new ElementLookup(_children.Select(c => c.Build())), true);

                return new ElementMetadata(BuildAttributes(), GetValidators(), _constraints?.ToArray(), Availability, _qname, Particle.Compile(), lookup);
            }

            private AttributeMetadata[]? BuildAttributes()
            {
                if (_attributes is null)
                {
                    return default;
                }

                var attributes = new AttributeMetadata[_attributes.Count];

                for (int i = 0; i < attributes.Length; i++)
                {
                    attributes[i] = _attributes[i].Build();
                }

                return attributes;
            }

            private class KnownChild<T> : IMetadataBuilder<ElementLookup.ElementChild>
                where T : OpenXmlElement, new()
            {
                public ElementLookup.ElementChild Build() => new ElementChild2(ElementMetadata.Create<T>());

                private class ElementChild2 : ElementLookup.ElementChild
                {
                    public ElementChild2(ElementMetadata metadata)
                        : base(typeof(T), metadata.QName)
                    {
                    }

                    public override OpenXmlElement Create() => new T();
                }
            }
        }

        public class Builder<TElement> : ValidatorBuilder
          where TElement : OpenXmlElement
        {
            private readonly Builder _builder;

            public Builder(Builder builder)
            {
                _builder = builder;
            }

            public Builder<TElement> AddAttribute<TSimpleType>(byte nsId, string localName, Expression<Func<TElement, TSimpleType?>> expression, Action<AttributeMetadata.Builder<TSimpleType>>? action = null)
                where TSimpleType : OpenXmlSimpleType, new()
            {
                if (expression.Body is MemberExpression member)
                {
                    var builder = new AttributeMetadata.Builder<TSimpleType>(new OpenXmlQualifiedName(new OpenXmlNamespace(nsId), localName), member.Member.Name);

                    action?.Invoke(builder);

                    _builder.Add(builder);

                    return this;
                }
                else
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}
