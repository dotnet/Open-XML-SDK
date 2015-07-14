// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using DocumentFormat.OpenXml.Validation;

namespace DocumentFormat.OpenXml.Internal.SchemaValidation
{
    /// <summary>
    /// All particle validator.
    /// </summary>
    class AllParticleValidator : CompositeParticleValidator
    {
        private  Dictionary<int, bool> _childrenParticles;

        /// <summary>
        /// Initializes a new instance of the AllParticleValidator.
        /// </summary>
        /// <param name="particleConstraint"></param>
        internal AllParticleValidator(CompositeParticle particleConstraint)
            : base(particleConstraint)
        {
            Debug.Assert(particleConstraint != null);
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

            this._childrenParticles = new Dictionary<int, bool>(this.ParticleConstraint.ChildrenParticles.Length);
            foreach (var childParticle in this.ParticleConstraint.ChildrenParticles)
            {
                this._childrenParticles.Add(childParticle.ElementId, false);
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
            Debug.Assert(this.ParticleConstraint.MaxOccurs == 1);
             
            this.TryMatchOnce(particleMatchInfo, validationContext);
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


            foreach (var childParticle in this.ParticleConstraint.ChildrenParticles)
            {
                this._childrenParticles[childParticle.ElementId] = false;
            }

            bool visited;

            while (next != null)
            {
                if (this._childrenParticles.TryGetValue(next.ElementTypeId, out visited))
                {
                    if (visited)
                    {
                        // error, maxOccurs > 1
                        break;
                    }
                    else
                    {
                        this._childrenParticles[next.ElementTypeId] = true;
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

            if (particleMatchInfo.ExpectedChildren == null)
            {
                particleMatchInfo.InitExpectedChildren();
            }

            if (particleMatchInfo.LastMatchedElement == null)
            {
                Debug.Assert(next == particleMatchInfo.StartElement);
                particleMatchInfo.Match = ParticleMatch.Nomatch;

                foreach (var childParticle in this.ParticleConstraint.ChildrenParticles)
                {
                    Debug.Assert(childParticle is ElementParticle);

                    particleMatchInfo.ExpectedChildren.Add(childParticle.ElementId);
                }

                return;
            }
            else
            {
                particleMatchInfo.Match = ParticleMatch.Matched;

                // check if matched 
                foreach (var childParticle in this.ParticleConstraint.ChildrenParticles)
                {
                    Debug.Assert(childParticle is ElementParticle);
                    if (!this._childrenParticles[childParticle.ElementId] && childParticle.MinOccurs == 1)
                    {
                        // one of the required children are missed.
                        particleMatchInfo.Match = ParticleMatch.Partial;
                    }
                }

                // find expected child elements.
                foreach (var childParticle in this.ParticleConstraint.ChildrenParticles)
                {
                    if (!this._childrenParticles[childParticle.ElementId])
                    {
                        particleMatchInfo.ExpectedChildren.Add(childParticle.ElementId);
                    }
                }
                return;
            }

        }

        protected override void EmitInvalidElementError(ValidationContext validationContext,
                                               ParticleMatchInfo particleMatchInfo)
        {
            var element = validationContext.Element;
            OpenXmlElement child;

            if (particleMatchInfo.LastMatchedElement == null)
            {
                child = validationContext.GetFirstChildMc();
            }
            else
            {
                child = validationContext.GetNextChildMc(particleMatchInfo.LastMatchedElement);
            }

            string expectedChildren;
            ValidationErrorInfo errorInfo;

            switch (particleMatchInfo.Match)
            {
                case ParticleMatch.Nomatch:
                    expectedChildren = GetExpectedChildrenMessage(validationContext.Element, this.GetExpectedElements());
                    errorInfo = validationContext.ComposeSchemaValidationError(element, child, "Sch_InvalidElementContentExpectingComplex", child.XmlQualifiedName.ToString(), expectedChildren);
                    validationContext.EmitError(errorInfo);
                    break;

                case ParticleMatch.Partial:
                case ParticleMatch.Matched:
                    if (this._childrenParticles.ContainsKey(child.ElementTypeId))
                    {
                        // more than one occurs of a child.
                        errorInfo = validationContext.ComposeSchemaValidationError(element, child, "Sch_AllElement", child.XmlQualifiedName.ToString());
                        validationContext.EmitError(errorInfo);
                    }
                    else
                    {
                        expectedChildren = GetExpectedChildrenMessage(validationContext.Element, particleMatchInfo.ExpectedChildren);
                        errorInfo = validationContext.ComposeSchemaValidationError(element, child, "Sch_InvalidElementContentExpectingComplex", child.XmlQualifiedName.ToString(), expectedChildren);
                        validationContext.EmitError(errorInfo);
                    }
                    break;
            }
        }
    }
}
