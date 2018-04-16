// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Diagnostics;

namespace DocumentFormat.OpenXml.Validation.Schema
{
    /// <summary>
    /// Base class for composite particle - sequence, choice, all, group. Defines some common functions.
    /// </summary>
    internal abstract class CompositeParticleValidator : ParticleValidator
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ParticleConstraint _particleConstraint;

        private ParticleMatchInfo _particleMatchInfo;

        /// <summary>
        /// This data field is moved from TryMatchOnce.
        /// Base on the following point.
        /// - The TryMatchOnce() method will NOT be called more than once with same ChoiceParticleValidator instance on the stack when validating one element.
        /// - That means this data field will not be overridden in recursive calling when validating one element.
        /// </summary>
        private ParticleMatchInfo _childMatchInfo = new ParticleMatchInfo();

        /// <summary>
        /// Gets the constraint to be validated.
        /// </summary>
        protected ParticleConstraint ParticleConstraint { get { return _particleConstraint; } }

        /// <summary>
        /// Initializes a new instance of the CompositeParticleValidator.
        /// </summary>
        /// <param name="particleConstraint"></param>
        internal CompositeParticleValidator(ParticleConstraint particleConstraint)
        {
            _particleConstraint = particleConstraint;
        }

        /// <summary>
        /// Be called on root particle of complex type.
        /// </summary>
        /// <param name="validationContext"></param>
        /// <returns></returns>
        internal override void Validate(ValidationContext validationContext)
        {
            Debug.Assert(validationContext != null);

            OpenXmlCompositeElement element = validationContext.Element as OpenXmlCompositeElement;
            Debug.Assert(element != null);

            var child = validationContext.GetFirstChildMc();
            ValidationErrorInfo errorInfo;

            // no children
            if (child == null)
            {
                if (ParticleConstraint.MinOccurs == 0)
                {
                    // no child, OK
                    return;
                }
                else
                {
                    var requiredElements = GetRequiredElements();

                    if ( requiredElements.Count > 0 )
                    {
                        errorInfo = validationContext.ComposeSchemaValidationError(element, null, "Sch_IncompleteContentExpectingComplex", GetExpectedChildrenMessage(element, requiredElements));
                        validationContext.AddError(errorInfo);
                    }

                    return;
                }
            }

            if (_particleMatchInfo == null)
            {
                _particleMatchInfo = new ParticleMatchInfo(child);
            }
            else
            {
                _particleMatchInfo.Reset(child);
            }

            TryMatch(_particleMatchInfo, validationContext);

            switch (_particleMatchInfo.Match)
            {
                case ParticleMatch.Nomatch:
                    // error: can not be matched, it is invalid
                    EmitInvalidElementError(validationContext, _particleMatchInfo);
                    return;

                case ParticleMatch.Partial:
                    EmitInvalidElementError(validationContext, _particleMatchInfo);
                    return;

                case ParticleMatch.Matched:
                    Debug.Assert(_particleMatchInfo.LastMatchedElement != null);
                    child = validationContext.GetNextChildMc(_particleMatchInfo.LastMatchedElement);
                    {
                        // Two cases now.
                        // 1. All children be matched.
                        // 2. Too many children ( > maxOccurs ).
                        if (child != null)
                        {
                            // invalid child
                            EmitInvalidElementError(validationContext, _particleMatchInfo);

                            // TODO: how can we tell the user what is the required child? Use reflection in OpenXmlElement.
                        }
                        else
                        {
                            //Debug.Assert(result.Valid == true);
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

                while (next != null && ParticleConstraint.MaxOccursGreaterThan(matchCount))
                {
                    // Use Reset() instead of new() to avoid heavy memory allocation and GC.
                    _childMatchInfo.Reset(next);
                    TryMatchOnce(_childMatchInfo, validationContext);

                    // if the _childMatchInfo.StartElement is changed, it means this method of this object is called more than once on the stack.
                    Debug.Assert(_childMatchInfo.StartElement == next);

                    if (_childMatchInfo.Match == ParticleMatch.Nomatch)
                    {
                        break;
                    }
                    else if (_childMatchInfo.Match == ParticleMatch.Matched)
                    {
                        matchCount++;
                        particleMatchInfo.LastMatchedElement = _childMatchInfo.LastMatchedElement;
                        next = validationContext.GetNextChildMc(particleMatchInfo.LastMatchedElement);
                    }
                    else
                    {
                        // return error
                        particleMatchInfo.Match = ParticleMatch.Partial;
                        particleMatchInfo.LastMatchedElement = _childMatchInfo.LastMatchedElement;
                        if (validationContext.CollectExpectedChildren)
                        {
                            particleMatchInfo.SetExpectedChildren(_childMatchInfo.ExpectedChildren);
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
        public override bool GetRequiredElements(ExpectedChildren result)
        {
            bool requiredElements = false;

            if (_particleConstraint.MinOccurs > 0)
            {
                foreach (var constraint in _particleConstraint.ChildrenParticles)
                {
                    if (constraint.ParticleValidator.GetRequiredElements(result))
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
                constraint.ParticleValidator.GetExpectedElements(result);
            }

            return true;
        }

        protected virtual void EmitInvalidElementError(ValidationContext validationContext,
                                                       ParticleMatchInfo particleMatchInfo)
        {
            OpenXmlElement child;

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
                particleMatchInfo.InitExpectedChildren();
                TryMatch(particleMatchInfo, validationContext);
                validationContext.CollectExpectedChildren = false;

#if DEBUG
                Debug.Assert(particleMatchInfo.Match == oldParticleMatchInfo.Match);
                Debug.Assert(particleMatchInfo.LastMatchedElement == oldParticleMatchInfo.LastMatchedElement);
#endif
            }

            var element = validationContext.Element;
            if (particleMatchInfo.LastMatchedElement == null)
            {
                child = validationContext.GetFirstChildMc();
            }
            else
            {
                child = validationContext.GetNextChildMc(particleMatchInfo.LastMatchedElement);
            }

            ValidationErrorInfo errorInfo;
            string expectedChildren = null;

            switch (particleMatchInfo.Match)
            {
                case ParticleMatch.Nomatch:
                    expectedChildren = GetExpectedChildrenMessage(validationContext.Element, GetExpectedElements());
                    break;

                case ParticleMatch.Partial:
                    // error: the child can not be matched, it is invalid
                    if (child == null)
                    {
                        // missing child
                        errorInfo = validationContext.ComposeSchemaValidationError(element, null, "Sch_IncompleteContentExpectingComplex", GetExpectedChildrenMessage(element, particleMatchInfo.ExpectedChildren));
                        validationContext.AddError(errorInfo);

                        return;
                    }
                    else
                    {
                        expectedChildren = GetExpectedChildrenMessage(validationContext.Element, particleMatchInfo.ExpectedChildren);
                    }

                    break;

                case ParticleMatch.Matched:
                    if (ParticleConstraint.CanOccursMoreThanOne)
                    {
                        expectedChildren = GetExpectedChildrenMessage(validationContext.Element, GetExpectedElements());
                    }
                    else
                    {
                        expectedChildren = GetExpectedChildrenMessage(validationContext.Element, particleMatchInfo.ExpectedChildren);
                    }

                    break;
            }

            if (validationContext.Element.CanContainsChild(child))
            {
                // The child can be contained in the parent, but not follow the schema.
                errorInfo = validationContext.ComposeSchemaValidationError(element, child, "Sch_UnexpectedElementContentExpectingComplex", child.XmlQualifiedName.ToString(), expectedChildren);
            }
            else
            {
                // Same element name, but wrong type. Only occurs when validating memory DOM.
                var validElement = element.TryCreateValidChild(validationContext.FileFormat, child.NamespaceUri, child.LocalName);
                if (validElement == null)
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
