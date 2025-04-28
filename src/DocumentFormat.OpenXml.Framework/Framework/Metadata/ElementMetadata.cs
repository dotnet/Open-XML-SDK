// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Validation.Schema;
using DocumentFormat.OpenXml.Validation.Semantic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DocumentFormat.OpenXml.Framework.Metadata
{
    internal class ElementMetadata : IElementMetadata
    {
        public static readonly ElementMetadata None = new();

        private readonly Lazy<ElementFactoryCollection>? _children;

        internal ElementMetadata(
            OpenXmlSchemaType type,
            ReadOnlyArray<AttributeMetadata> attributes,
            ReadOnlyArray<IValidator> validators,
            ReadOnlyArray<IValidator> constraints,
            FileFormatVersions version,
            CompiledParticle? particle,
            Lazy<ElementFactoryCollection> lookup)
        {
            Type = type;
            Attributes = attributes;
            Validators = validators;
            Constraints = constraints;
            Availability = version;
            Particle = particle;
            _children = lookup;
        }

        internal ElementMetadata()
        {
        }

        public OpenXmlSchemaType Type { get; }

        public ReadOnlyArray<AttributeMetadata> Attributes { get; }

        public ElementFactoryCollection Children => _children?.Value ?? ElementFactoryCollection.Empty;

        public ReadOnlyArray<IValidator> Validators { get; }

        public ReadOnlyArray<IValidator> Constraints { get; }

        public FileFormatVersions Availability { get; }

        public CompiledParticle? Particle { get; }

        public class Builder : ValidatorBuilder
        {
            private static readonly Lazy<ElementFactoryCollection> _lazy = new Lazy<ElementFactoryCollection>(() => ElementFactoryCollection.Empty, true);

            private readonly IOpenXmlNamespaceResolver _resolver;

            private List<IMetadataBuilder<AttributeMetadata>>? _attributes;
            private List<ElementFactory>? _children;
            private List<IValidator>? _constraints;
            private OpenXmlSchemaType _type;

            public Builder(IOpenXmlNamespaceResolver resolver)
            {
                _resolver = resolver;
            }

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

            public OpenXmlQualifiedName CreateQName(string qname)
                => _resolver.ParseQName(qname);

            public void SetSchema(in OpenXmlSchemaType type)
                => _type = type;

            public void AddChild(in OpenXmlSchemaType type, Func<OpenXmlElement> activator)
            {
                if (_children is null)
                {
                    _children = [];
                }

                _children.Add(new ElementFactory(type, activator));
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
                var lookup = _children is null ? _lazy : new Lazy<ElementFactoryCollection>(() => new ElementFactoryCollection(_children), true);

                return new ElementMetadata(_type, BuildAttributes(), GetValidators(), _constraints?.ToArray(), Availability, Particle.Compile(), lookup);
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
        }

        public class Builder<TElement> : ValidatorBuilder
          where TElement : OpenXmlElement
        {
            private readonly Builder _builder;

            public Builder(Builder builder)
            {
                _builder = builder;
            }

            public Builder<TElement> AddAttribute<TSimpleType>(string name, Expression<Func<TElement, TSimpleType?>> expression, Action<AttributeMetadata.Builder<TSimpleType>>? action = null)
                where TSimpleType : OpenXmlSimpleType, new()
            {
                if (expression.Body is MemberExpression member)
                {
                    var qname = _builder.CreateQName(name);
                    var builder = new AttributeMetadata.Builder<TSimpleType>(qname, member.Member.Name);

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
