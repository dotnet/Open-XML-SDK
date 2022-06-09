﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Diagnostics;

namespace DocumentFormat.OpenXml.Validation.Schema
{
    /// <summary>
    /// Base class for composite particle - sequence, choice, all, group. Defines some common functions.
    /// </summary>
    internal abstract class CompositeParticleValidator : ParticleValidator
    {
        /// <summary>
        /// Gets the constraint to be validated.
        /// </summary>
        protected CompositeParticle ParticleConstraint { get; }

        /// <summary>
        /// Initializes a new instance of the CompositeParticleValidator.
        /// </summary>
        /// <param name="particleConstraint"></param>
        protected CompositeParticleValidator(CompositeParticle particleConstraint)
        {
            ParticleConstraint = particleConstraint;
        }

        /// <summary>
        /// Be called on root particle of complex type.
        /// </summary>
        /// <param name="validationContext"></param>
        internal override void Validate(ValidationContext validationContext)
        {
            if (validationContext.Stack.Current?.Element is not OpenXmlCompositeElement element)
            {
                return;
            }

            var child = validationContext.GetFirstChildMc();
            ValidationErrorInfo errorInfo;

            // no children
            if (child is null)
            {
                if (ParticleConstraint.MinOccurs == 0)
                {
                    // no child, OK
                    return;
                }
                else
                {
                    var requiredElements = GetRequiredElements();

                    if (requiredElements.Count > 0)
                    {
                        errorInfo = validationContext.ComposeSchemaValidationError(element, null, "Sch_IncompleteContentExpectingComplex", GetExpectedChildrenMessage(element, requiredElements));
                        validationContext.AddError(errorInfo);
                    }

                    return;
                }
            }

            var particleMatchInfo = new ParticleMatchInfo(child);

            TryMatch(particleMatchInfo, validationContext);

            switch (particleMatchInfo.Match)
            {
                case ParticleMatch.Nomatch:
                    // error: can not be matched, it is invalid
                    EmitInvalidElementError(validationContext, particleMatchInfo);
                    return;

                case ParticleMatch.Partial:
                    EmitInvalidElementError(validationContext, particleMatchInfo);
                    return;

                case ParticleMatch.Matched:
                    Debug.Assert(particleMatchInfo.LastMatchedElement is not null);
                    child = validationContext.GetNextChildMc(particleMatchInfo.LastMatchedElement);
                    {
                        // Two cases now.
                        // 1. All children be matched.
                        // 2. Too many children ( > maxOccurs ).
                        if (child is not null)
                        {
                            // invalid child
                            EmitInvalidElementError(validationContext, particleMatchInfo);

                            // TODO: how can we tell the user what is the required child? Use reflection in OpenXmlElement.
                        }
                        else
                        {
                            // Debug.Assert(result.Valid == true);
                        }
                    }

                    break;
            }

            return;
        }

        /// <summary>
        /// Try match the particle.
        /// </summary>
        /// <param name="particleMatchInfo"></param>
        /// <param name="validationContext">The context information for validation.</param>
        public override void TryMatch(ParticleMatchInfo particleMatchInfo, ValidationContext validationContext)
        {
            if (ParticleConstraint.MaxOccurs == 1)
            {
                TryMatchOnce(particleMatchInfo, validationContext);
            }
            else
            {
                int matchCount = 0;
                var next = particleMatchInfo.StartElement;

                var childMatchInfo = new ParticleMatchInfo();

                while (next is not null && ParticleConstraint.MaxOccursGreaterThan(matchCount))
                {
                    // Use Reset() instead of new() to avoid heavy memory allocation and GC.
                    childMatchInfo.Reset(next);
                    TryMatchOnce(childMatchInfo, validationContext);

                    // if the _childMatchInfo.StartElement is changed, it means this method of this object is called more than once on the stack.
                    Debug.Assert(childMatchInfo.StartElement == next);

                    if (childMatchInfo.Match == ParticleMatch.Nomatch)
                    {
                        break;
                    }
                    else if (childMatchInfo.Match == ParticleMatch.Matched)
                    {
                        matchCount++;
                        particleMatchInfo.LastMatchedElement = childMatchInfo.LastMatchedElement;
                        next = validationContext.GetNextChildMc(particleMatchInfo.LastMatchedElement);
                    }
                    else
                    {
                        // return error
                        particleMatchInfo.Match = ParticleMatch.Partial;
                        particleMatchInfo.LastMatchedElement = childMatchInfo.LastMatchedElement;
                        if (validationContext.CollectExpectedChildren)
                        {
                            particleMatchInfo.SetExpectedChildren(childMatchInfo.ExpectedChildren);
                        }

                        return;
                    }
                }

                if (matchCount == 0)
                {
                    particleMatchInfo.Match = ParticleMatch.Nomatch;
                    if (validationContext.CollectExpectedChildren)
                    {
                        particleMatchInfo.SetExpectedChildren(GetExpectedElements());
                    }
                }
                else if (matchCount >= ParticleConstraint.MinOccurs)
                {
                    // matched OK
                    particleMatchInfo.Match = ParticleMatch.Matched;
                }
                else
                {
                    if (GetRequiredElements(particleMatchInfo.ExpectedChildren))
                    {
                        // minOccurs failed, incomplete children.
                        particleMatchInfo.Match = ParticleMatch.Partial;
                    }
                    else
                    {
                        // all children elements are optional
                        particleMatchInfo.Match = ParticleMatch.Matched;
                    }
                }
            }

            return;
        }

        /// <summary>
        /// Get the required elements - elements which minOccurs > 0.
        /// </summary>
        /// <param name="result"></param>
        /// <returns>True if there are required elements in this particle.</returns>
        public override bool GetRequiredElements(ExpectedChildren? result)
        {
            bool requiredElements = false;

            if (ParticleConstraint.MinOccurs > 0)
            {
                foreach (var constraint in ParticleConstraint.ChildrenParticles)
                {
                    if (constraint.ParticleValidator is IParticleValidator validator && validator.GetRequiredElements(result))
                    {
                        requiredElements = true;
                    }
                }
            }

            return requiredElements;
        }

        /// <summary>
        /// Get the expected elements - elements which minOccurs >= 0.
        /// </summary>
        /// <param name="result"></param>
        /// <returns>True if there are expected elements in this particle.</returns>
        public override bool GetExpectedElements(ExpectedChildren result)
        {
            foreach (var constraint in ParticleConstraint.ChildrenParticles)
            {
                if (constraint.ParticleValidator is IParticleValidator validator)
                {
                    validator.GetExpectedElements(result);
                }
            }

            return true;
        }

        protected virtual void EmitInvalidElementError(
            ValidationContext validationContext,
            ParticleMatchInfo particleMatchInfo)
        {
            OpenXmlElement? child;

            // re-validate the element, collect the expected children information
            if (particleMatchInfo.Match != ParticleMatch.Nomatch)
            {
#if DEBUG
                var oldParticleMatchInfo = particleMatchInfo;
                particleMatchInfo = new ParticleMatchInfo();
#endif
                child = validationContext.GetFirstChildMc();
                validationContext.CollectExpectedChildren = true;
                particleMatchInfo.Reset(child);
                particleMatchInfo.ExpectedChildren.Clear();
                TryMatch(particleMatchInfo, validationContext);
                validationContext.CollectExpectedChildren = false;

#if DEBUG
                Debug.Assert(particleMatchInfo.Match == oldParticleMatchInfo.Match);
                Debug.Assert(particleMatchInfo.LastMatchedElement == oldParticleMatchInfo.LastMatchedElement);
#endif
            }

            var element = validationContext.Stack.Current?.Element;

            if (element is null)
            {
                return;
            }

            if (particleMatchInfo.LastMatchedElement is null)
            {
                child = validationContext.GetFirstChildMc();
            }
            else
            {
                child = validationContext.GetNextChildMc(particleMatchInfo.LastMatchedElement);
            }

            ValidationErrorInfo errorInfo;
            string expectedChildren = string.Empty;

            switch (particleMatchInfo.Match)
            {
                case ParticleMatch.Nomatch:
                    expectedChildren = GetExpectedChildrenMessage(element, GetExpectedElements());
                    break;

                case ParticleMatch.Partial:
                    // error: the child can not be matched, it is invalid
                    if (child is null)
                    {
                        // missing child
                        errorInfo = validationContext.ComposeSchemaValidationError(element, null, "Sch_IncompleteContentExpectingComplex", GetExpectedChildrenMessage(element, particleMatchInfo.ExpectedChildren));
                        validationContext.AddError(errorInfo);

                        return;
                    }
                    else
                    {
                        expectedChildren = GetExpectedChildrenMessage(element, particleMatchInfo.ExpectedChildren);
                    }

                    break;

                case ParticleMatch.Matched:
                    if (ParticleConstraint.CanOccursMoreThanOne)
                    {
                        expectedChildren = GetExpectedChildrenMessage(element, GetExpectedElements());
                    }
                    else
                    {
                        expectedChildren = GetExpectedChildrenMessage(element, particleMatchInfo.ExpectedChildren);
                    }

                    break;
            }

            if (child is null)
            {
                return;
            }

            if (element.CanContainChild(child))
            {
                // The child can be contained in the parent, but not follow the schema.
                errorInfo = validationContext.ComposeSchemaValidationError(element, child, "Sch_UnexpectedElementContentExpectingComplex", child.XmlQualifiedName.ToString(), expectedChildren);
            }
            else
            {
                // Same element name, but wrong type. Only occurs when validating memory DOM.
                var validElement = element.TryCreateValidChild(validationContext.FileFormat, child.NamespaceUri, child.LocalName);
                if (validElement is null)
                {
                    errorInfo = validationContext.ComposeSchemaValidationError(element, child, "Sch_InvalidElementContentExpectingComplex", child.XmlQualifiedName.ToString(), expectedChildren);
                }
                else
                {
                    // Parent can contains a different type of element with same name
                    errorInfo = validationContext.ComposeSchemaValidationError(element, child, "Sch_InvalidElementContentWrongType", child.XmlQualifiedName.ToString(), child.GetType().Name);
                }
            }

            validationContext.AddError(errorInfo);
        }
    }

    /**********************************************************************************************
     * Some assumption for schema complex type.
     * 1). A same tag (like 'w:b') only occurs once in the complex type definition in the schema.
     * This assumption is correct for Ecma376.
    **********************************************************************************************/
}
