﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Validation.Schema
{
    /// <summary>
    /// All particle validator.
    /// </summary>
    internal class AllParticleValidator : CompositeParticleValidator
    {
        private readonly Dictionary<OpenXmlSchemaType, bool> _childrenParticles;

        /// <summary>
        /// Initializes a new instance of the AllParticleValidator.
        /// </summary>
        /// <param name="particleConstraint"></param>
        internal AllParticleValidator(CompositeParticle particleConstraint)
            : base(particleConstraint)
        {
            Debug.Assert(particleConstraint.ParticleType == ParticleType.All);

            // xsd:all can only contain xsd:element children and maxOccurs of each children can only be 1
#if DEBUG
            foreach (var constraint in particleConstraint.ChildrenParticles)
            {
                Debug.Assert(constraint.ParticleType == ParticleType.Element);

                // all children elements' maxOccurs must be 1
                Debug.Assert(constraint.MaxOccurs == 1);
            }
#endif

            _childrenParticles = new Dictionary<OpenXmlSchemaType, bool>(ParticleConstraint.ChildrenParticles.Length);

            foreach (var childParticle in ParticleConstraint.ChildrenParticles)
            {
                if (childParticle is ElementParticle element)
                {
                    _childrenParticles.Add(element.Type, false);
                }
            }
        }

        /// <summary>
        /// Try match the particle.
        /// </summary>
        /// <param name="particleMatchInfo"></param>
        /// <param name="validationContext">The context information for validation.</param>
        public override void TryMatch(ParticleMatchInfo particleMatchInfo, ValidationContext validationContext)
        {
            // maxOccurs of xsd:any can only be 1
            Debug.Assert(ParticleConstraint.MaxOccurs == 1);

            TryMatchOnce(particleMatchInfo, validationContext);
        }

        /// <summary>
        /// Try match the particle once.
        /// </summary>
        /// <param name="particleMatchInfo"></param>
        /// <param name="validationContext">The context information for validation.</param>
        /// <remarks>
        /// xsd:all can only contain xsd:element children and maxOccurs of each children can only be 1
        /// </remarks>
        public override void TryMatchOnce(ParticleMatchInfo particleMatchInfo, ValidationContext validationContext)
        {
            Debug.Assert(!(particleMatchInfo.StartElement is OpenXmlMiscNode));

            var next = particleMatchInfo.StartElement;

            particleMatchInfo.LastMatchedElement = null;
            particleMatchInfo.Match = ParticleMatch.Nomatch;

            foreach (var childParticle in ParticleConstraint.ChildrenParticles)
            {
                if (childParticle is ElementParticle element)
                {
                    _childrenParticles[element.Type] = false;
                }
            }

            while (next is not null)
            {
                var nextType = next.Metadata.Type;
                if (_childrenParticles.TryGetValue(nextType, out var visited))
                {
                    if (visited)
                    {
                        // error, maxOccurs > 1
                        break;
                    }
                    else
                    {
                        _childrenParticles[nextType] = true;
                    }
                }
                else
                {
                    // error, other child not allowed
                    break;
                }

                particleMatchInfo.LastMatchedElement = next;

                next = validationContext.GetNextChildMc(next);
            }

            if (particleMatchInfo.LastMatchedElement is null)
            {
                Debug.Assert(next == particleMatchInfo.StartElement);
                particleMatchInfo.Match = ParticleMatch.Nomatch;

                foreach (var childParticle in ParticleConstraint.ChildrenParticles)
                {
                    if (childParticle is ElementParticle element)
                    {
                        particleMatchInfo.ExpectedChildren.Add(element.Type);
                    }
                }

                return;
            }
            else
            {
                particleMatchInfo.Match = ParticleMatch.Matched;

                // check if matched
                foreach (var childParticle in ParticleConstraint.ChildrenParticles)
                {
                    if (childParticle is ElementParticle element)
                    {
                        if (!_childrenParticles[element.Type] && childParticle.MinOccurs == 1)
                        {
                            // one of the required children are missed.
                            particleMatchInfo.Match = ParticleMatch.Partial;
                        }
                    }
                }

                // find expected child elements.
                foreach (var childParticle in ParticleConstraint.ChildrenParticles)
                {
                    if (childParticle is ElementParticle element && !_childrenParticles[element.Type])
                    {
                        particleMatchInfo.ExpectedChildren.Add(element.Type);
                    }
                }

                return;
            }
        }

        protected override void EmitInvalidElementError(ValidationContext validationContext, ParticleMatchInfo particleMatchInfo)
        {
            var element = validationContext.Stack.Current?.Element;

            if (element is null)
            {
                return;
            }

            var child = particleMatchInfo.LastMatchedElement is null
                ? validationContext.GetFirstChildMc()
                : validationContext.GetNextChildMc(particleMatchInfo.LastMatchedElement);

            if (child is null)
            {
                return;
            }

            string expectedChildren;
            ValidationErrorInfo errorInfo;

            switch (particleMatchInfo.Match)
            {
                case ParticleMatch.Nomatch:
                    expectedChildren = GetExpectedChildrenMessage(element, GetExpectedElements());
                    errorInfo = validationContext.ComposeSchemaValidationError(element, child, "Sch_InvalidElementContentExpectingComplex", child.XmlQualifiedName.ToString(), expectedChildren);
                    validationContext.AddError(errorInfo);
                    break;

                case ParticleMatch.Partial:
                case ParticleMatch.Matched:
                    if (_childrenParticles.ContainsKey(child.Metadata.Type))
                    {
                        // more than one occurs of a child.
                        errorInfo = validationContext.ComposeSchemaValidationError(element, child, "Sch_AllElement", child.XmlQualifiedName.ToString());
                        validationContext.AddError(errorInfo);
                    }
                    else
                    {
                        expectedChildren = GetExpectedChildrenMessage(element, particleMatchInfo.ExpectedChildren);
                        errorInfo = validationContext.ComposeSchemaValidationError(element, child, "Sch_InvalidElementContentExpectingComplex", child.XmlQualifiedName.ToString(), expectedChildren);
                        validationContext.AddError(errorInfo);
                    }

                    break;
            }
        }
    }
}
