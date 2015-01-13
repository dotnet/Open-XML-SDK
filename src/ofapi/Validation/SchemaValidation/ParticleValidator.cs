// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Globalization;
using DocumentFormat.OpenXml.Validation;

namespace DocumentFormat.OpenXml.Internal.SchemaValidation
{
    /// <summary>
    /// Particle match result.
    /// </summary>
    internal enum ParticleMatch
    {
        Nomatch,
        Partial, // partial match
        Matched,
    }

#if DEBUG
    /// <summary>
    /// InstanceCounter for performance investigation.
    /// </summary>
    public static class InstanceCounter
    {
        /// <summary>
        /// Count of ParticleMatchInfo instance.
        /// </summary>
        public static long ParticleMatchInfo { get; set; }

        /// <summary>
        /// Count of ExpectedChildren instance.
        /// </summary>
        public static long ExpectedChildren { get; set; }
    }

    internal partial class ExpectedChildren
    {
        static partial void IncressInstanceCount()
        {
            InstanceCounter.ExpectedChildren++;
        }
    }

    internal partial class ParticleMatchInfo
    {
        static partial void IncressInstanceCount()
        {
            InstanceCounter.ParticleMatchInfo++;
        }
    }
#endif

    /// <summary>
    /// Information about particle match.
    /// </summary>
    [DebuggerDisplay("Match={Match}")]
    internal partial class ParticleMatchInfo
    {
        static partial void IncressInstanceCount();

        /// <summary>
        /// Initializes a new instance of the ParticleMatchInfo.
        /// </summary>
        internal ParticleMatchInfo()
        {
            this.Match = ParticleMatch.Nomatch;

            IncressInstanceCount();
        }
        
        /// <summary>
        /// Initializes a new instance of the ParticleMatchInfo.
        /// </summary>
        /// <param name="startElement"></param>
        internal ParticleMatchInfo(OpenXmlElement startElement)
        {
            this.Match = ParticleMatch.Nomatch;
            this.StartElement = startElement;

            IncressInstanceCount();
        }
        
        /// <summary>
        /// Particle match result.
        /// </summary>
        internal ParticleMatch Match { get; set; }

        /// <summary>
        /// The start element to be matched by a particle rule.
        /// </summary>
        internal OpenXmlElement StartElement { get; private set; }

        /// <summary>
        /// The last element matched by the particle match.
        /// </summary>
        internal OpenXmlElement LastMatchedElement { get; set; }

        /// <summary>
        /// On Partial match, return the errors.
        /// </summary>
        /// <remarks>
        /// TODO: how can this be decopled from the validator?
        /// </remarks>
        internal string ErrorMessage { get; set; }

        /// <summary>
        /// The element type ids of expected children.
        /// Fill this field on partial match. 
        /// </summary>
        /// <remarks>
        /// Will be null if matched or not matched.
        /// Will contains the expected child element types if partial match.
        /// </remarks>
        internal ExpectedChildren ExpectedChildren { get; private set; }

        /// <summary>
        /// The .ExpectedChildren will be non-null after this call.
        /// </summary>
        internal void InitExpectedChildren()
        {
            if (this.ExpectedChildren == null)
            {
                this.ExpectedChildren = new ExpectedChildren();
            }
            else
            {
                this.ExpectedChildren.Clear();
            }
        }

        /// <summary>
        /// Purpose: 
        /// Resue this.ExpectedChildren data field.
        /// Avoid this.ExpectedChildren be referenced by more than one object (so "this.ExpectedChildren = other.ExpectedChildren" is not allowed).
        /// </summary>
        /// <param name="expectedChildren"></param>
        internal void SetExpectedChildren(ExpectedChildren expectedChildren)
        {
            if (expectedChildren == null || expectedChildren.Count == 0)
            {
                if (this.ExpectedChildren != null)
                {
                    this.ExpectedChildren.Clear();
                }
                // else, both are null, just return, nothing to do.
            }
            else
            {
                if (this.ExpectedChildren == null)
                {
                    this.ExpectedChildren = new ExpectedChildren();
                }
                this.ExpectedChildren.Clear();
                this.ExpectedChildren.Add(expectedChildren);
            }
        }

        ///// <summary>
        ///// Returns a flag which indicate whether the ExpectedChildren is empty.
        ///// </summary>
        //internal bool HasExpectedChildren
        //{
        //    get
        //    {
        //        return this.ExpectedChildren != null && this.ExpectedChildren.Count > 0;
        //    }
        //}

        internal void Reset(OpenXmlElement startElement)
        {
            this.StartElement = startElement;
            this.Match = ParticleMatch.Nomatch;
            this.LastMatchedElement = null;
            this.ErrorMessage = null;
            if (this.ExpectedChildren != null)
            {
                this.ExpectedChildren.Clear();
            }
        }
    }

    /// <summary>
    /// Hold expected children for error reporting.
    /// </summary>
    internal partial class ExpectedChildren
    {
        static partial void IncressInstanceCount();

        #region private fields

        private ICollection<int> _elementTypeIds;

        private ICollection<string> _xsdanyNamespaces;

        #endregion

        internal ExpectedChildren()
        {
            IncressInstanceCount();
        }

        /// <summary>
        /// Add ElementTypeId of the child.
        /// </summary>
        /// <param name="elementTypeId"></param>
        internal void Add(int elementTypeId)
        {
            // No lock, not safe for multi-thread
            if ( this._elementTypeIds == null )
            {
                this._elementTypeIds = new List<int>();
            }
            this._elementTypeIds.Add(elementTypeId);
        }

        /// <summary>
        /// Add namespace string of xsd:any child.
        /// </summary>
        /// <param name="namesapceForXsdany"></param>
        internal void Add(string namesapceForXsdany)
        {
            // No lock, not safe for multi-thread
            if (this._xsdanyNamespaces == null)
            {
                this._xsdanyNamespaces = new List<string>();
            }
            this._xsdanyNamespaces.Add(namesapceForXsdany);
        }

        /// <summary>
        /// Add all expected children from another ExpectedChildren.
        /// </summary>
        /// <param name="expectedChildren"></param>
        internal void Add(ExpectedChildren expectedChildren)
        {
            if (expectedChildren._elementTypeIds != null && 
                expectedChildren._elementTypeIds.Count > 0)
            {
                // No lock, not safe for multi-thread
                if (this._elementTypeIds == null)
                {
                    this._elementTypeIds = new List<int>();
                }
                
                foreach (var id in expectedChildren._elementTypeIds)
                {
                    this._elementTypeIds.Add(id);
                }
            }

            if (expectedChildren._xsdanyNamespaces != null &&
                expectedChildren._xsdanyNamespaces.Count > 0)
            {
                // No lock, not safe for multi-thread
                if (this._xsdanyNamespaces == null)
                {
                    this._xsdanyNamespaces = new List<string>();
                }

                foreach (var ns in expectedChildren._xsdanyNamespaces)
                {
                    this._xsdanyNamespaces.Add(ns);
                }
            }
        }

        /// <summary>
        /// Returns the count of required children elements.
        /// </summary>
        internal int Count 
        {
            get
            {
                int count = 0;
                if (this._elementTypeIds != null)
                {
                    count = this._elementTypeIds.Count;
                }
                if (this._xsdanyNamespaces != null)
                {
                    count += this._xsdanyNamespaces.Count;
                }
                return count;
            }
        }

        /// <summary>
        /// Returns the list of expected children message used in error reporting.
        /// </summary>
        /// <param name="parent">The parent element. Used to map ElementTypeId to element name for child element.</param>
        /// <returns>The Fmt_ListOfPossibleElements sub string to be used in error reporting.</returns>
        internal string GetExpectedChildrenMessage(OpenXmlElement parent)
        {
            Debug.Assert(parent != null);

            if (this._elementTypeIds != null || this._xsdanyNamespaces != null)
            {
                Debug.Assert(this._elementTypeIds != null && this._elementTypeIds.Count > 0 ||
                             this._xsdanyNamespaces != null && this._xsdanyNamespaces.Count > 0);

                string expectedChildren = null;
                StringBuilder childrenNames = new StringBuilder();
                string separator = string.Empty;

                if (this._elementTypeIds != null)
                {
                    foreach (var childElement in parent.CreateChildrenElementsByIds(this._elementTypeIds))
                    {
                        childrenNames.Append(separator);
                        // <namespace:localname>, use InvariantCulture
                        childrenNames.Append(string.Format(CultureInfo.CurrentUICulture, ValidationResources.Fmt_ElementName, childElement.NamespaceUri, childElement.LocalName));

                        separator = ValidationResources.Fmt_ElementNameSeparator;
                    }
                }

                if (this._xsdanyNamespaces != null)
                {
                    foreach (var namespaceForXsdany in this._xsdanyNamespaces)
                    {
                        childrenNames.Append(separator);
                        childrenNames.Append(string.Format(CultureInfo.CurrentUICulture, ValidationResources.Fmt_AnyElementInNamespace, namespaceForXsdany));
                    }
                }

                expectedChildren = string.Format(CultureInfo.CurrentUICulture, ValidationResources.Fmt_ListOfPossibleElements, childrenNames.ToString());

                return expectedChildren;
            }

            return string.Empty;
        }

        internal void Clear()
        {
            if (this._elementTypeIds != null)
            {
                this._elementTypeIds.Clear();
            }

            if (this._xsdanyNamespaces != null)
            {
                this._xsdanyNamespaces.Clear();
            }
        }
    }

    /// <summary>
    /// Defines methods to validate particles.
    /// </summary>
    internal interface IParticleValidator
    {
        /// <summary>
        /// Try match the particle once.
        /// </summary>
        /// <param name="particleMatchInfo"></param>
        /// <param name="validationContext">The context information for validation.</param>
        void TryMatchOnce(ParticleMatchInfo particleMatchInfo, ValidationContext validationContext);

        /// <summary>
        /// Try match the particle,  
        /// </summary>
        /// <param name="particleMatchInfo"></param>
        /// <param name="validationContext">The context information for validation.</param>
        void TryMatch(ParticleMatchInfo particleMatchInfo, ValidationContext validationContext);

        /// <summary>
        /// Get the required elements - elements which minOccurs > 0.
        /// </summary>
        /// <param name="result"></param>
        /// <returns>True if there are required elements in this particle.</returns>
        bool GetRequiredElements(ExpectedChildren result);

        /// <summary>
        /// Get the required elements - elements which minOccurs > 0.
        /// </summary>
        /// <returns>Required elements in this particle.</returns>
        ExpectedChildren GetRequiredElements();

        /// <summary>
        /// Get the expected elements - elements which minOccurs >= 0.
        /// </summary>
        /// <param name="result"></param>
        /// <returns>True if there are expected elements in this particle.</returns>
        bool GetExpectedElements(ExpectedChildren result);

        /// <summary>
        /// Get the expected elements - elements which minOccurs >= 0.
        /// </summary>
        /// <returns>Expected elements in this particle.</returns>
        ExpectedChildren GetExpectedElements();

    }

    /// <summary>
    /// Base class for particle validator.
    /// </summary>
    internal abstract class ParticleValidator : IParticleValidator
    {
        /// <summary>
        /// Initializes a new instance of the ParticleValidator.
        /// </summary>
        internal ParticleValidator()
        {
        }

        /// <summary>
        /// Be called on root particle of complex type.
        /// </summary>
        /// <param name="validationContext"></param>
        internal abstract void Validate(ValidationContext validationContext);

        /// <summary>
        /// Try match the particle once.
        /// </summary>
        /// <param name="particleMatchInfo"></param>
        /// <param name="validationContext">The context information for validation.</param>
        public virtual void TryMatchOnce(ParticleMatchInfo particleMatchInfo, ValidationContext validationContext)
        {
            particleMatchInfo.Match = ParticleMatch.Nomatch;
            return;
        }

        /// <summary>
        /// Try match the particle.
        /// </summary>
        /// <param name="particleMatchInfo"></param>
        /// <param name="validationContext">The context information for validation.</param>
        public virtual void TryMatch(ParticleMatchInfo particleMatchInfo, ValidationContext validationContext)
        {
            particleMatchInfo.Match = ParticleMatch.Nomatch;
            return;
        }

        /// <summary>
        /// Get the required elements - elements which minOccurs > 0.
        /// </summary>
        /// <param name="result"></param>
        /// <returns>True if there are required elements in this particle.</returns>
        public virtual bool GetRequiredElements(ExpectedChildren result)
        {
            return false;
        }

        /// <summary>
        /// Get the required elements - elements which minOccurs > 0.
        /// </summary>
        /// <returns>Required elements in this particle.</returns>
        public ExpectedChildren GetRequiredElements()
        {
            ExpectedChildren requiredElements = new ExpectedChildren();

            this.GetRequiredElements(requiredElements);

            return requiredElements;
        }

        /// <summary>
        /// Get the expected elements - elements which minOccurs >= 0.
        /// </summary>
        /// <param name="result"></param>
        /// <returns>True if there are expected elements in this particle.</returns>
        public virtual bool GetExpectedElements(ExpectedChildren result)
        {
            return false;
        }

        /// <summary>
        /// Get the expected elements - elements which minOccurs >= 0.
        /// </summary>
        /// <returns>Expected elements in this particle.</returns>
        public ExpectedChildren GetExpectedElements()
        {
            ExpectedChildren expectedElements = new ExpectedChildren();

            this.GetExpectedElements(expectedElements);

            return expectedElements;
        }



        internal static ParticleValidator CreateParticleValidator(ParticleConstraint particleConstraint)
        {
            var compositeParticle = particleConstraint as CompositeParticle;

            switch (particleConstraint.ParticleType)
            {
                case ParticleType.All:
                    return new AllParticleValidator(compositeParticle);

                case ParticleType.Choice:
                    return new ChoiceParticleValidator(compositeParticle);

                case ParticleType.Sequence:
                    return new SequenceParticleValidator(compositeParticle);

                case ParticleType.Group:
                    return new GroupParticleValidator(compositeParticle);

                //case ParticleType.Any:
                //    return new AnyParticleValidator(particleConstraint);

                case ParticleType.Element:
                default:
                    throw new InvalidOperationException();
            }
        }

        internal static string GetExpectedChildrenMessage(OpenXmlElement parent, ExpectedChildren expectedChildrenIds)
        {
            Debug.Assert(parent != null);

            if (expectedChildrenIds != null)
            {
                return expectedChildrenIds.GetExpectedChildrenMessage(parent);
            }

            return string.Empty;
        }

    }

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
        /// - That means this data field will not be overriden in recursive calling when validating one element. 
        /// </summary>
        private ParticleMatchInfo _childMatchInfo = new ParticleMatchInfo();

        /// <summary>
        /// The constraint to be validated.
        /// </summary>
        protected ParticleConstraint ParticleConstraint { get { return this._particleConstraint; } }

        /// <summary>
        /// Initializes a new instance of the CompositeParticleValidator.
        /// </summary>
        /// <param name="particleConstraint"></param>
        internal CompositeParticleValidator(ParticleConstraint particleConstraint)
        {
            this._particleConstraint = particleConstraint;
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
                if (this.ParticleConstraint.MinOccurs == 0)
                {
                    // no child, ok
                    return;
                }
                else
                {
                    var requiredElements = this.GetRequiredElements();

                    if ( requiredElements.Count > 0 )
                    {
                        errorInfo = validationContext.ComposeSchemaValidationError(element, null, "Sch_IncompleteContentExpectingComplex", GetExpectedChildrenMessage(element, requiredElements));
                        validationContext.EmitError(errorInfo);
                    }
                    return;
                }
            }

            if (this._particleMatchInfo == null)
            {
                this._particleMatchInfo = new ParticleMatchInfo(child);
            }
            else
            {
                _particleMatchInfo.Reset(child);
            }


            this.TryMatch(_particleMatchInfo, validationContext);

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
            if (this.ParticleConstraint.MaxOccurs == 1)
            {
                this.TryMatchOnce(particleMatchInfo, validationContext);
            }
            else
            {
                int matchCount = 0;
                var next = particleMatchInfo.StartElement;

                while (next != null && this.ParticleConstraint.MaxOccursGreaterThan(matchCount))
                {
                    // Use Reset() instead of new() to avoid heavy memory alloction and GC.
                    _childMatchInfo.Reset(next);
                    this.TryMatchOnce(_childMatchInfo, validationContext);

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
                        particleMatchInfo.SetExpectedChildren(this.GetExpectedElements());
                    }
                }
                else if (matchCount >= this.ParticleConstraint.MinOccurs)
                {
                    // matched ok
                    particleMatchInfo.Match = ParticleMatch.Matched;
                }
                else
                {
                    if (this.GetRequiredElements(particleMatchInfo.ExpectedChildren))
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

            if (this._particleConstraint.MinOccurs > 0)
            {
                foreach (var constraint in this._particleConstraint.ChildrenParticles)
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
            foreach (var constraint in this.ParticleConstraint.ChildrenParticles)
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
                this.TryMatch(particleMatchInfo, validationContext);
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
                    expectedChildren = GetExpectedChildrenMessage(validationContext.Element, this.GetExpectedElements());
                    break;

                case ParticleMatch.Partial:
                    // error: the child can not be matched, it is invalid
                    if (child == null)
                    {
                        // missing child
                        errorInfo = validationContext.ComposeSchemaValidationError(element, null, "Sch_IncompleteContentExpectingComplex", GetExpectedChildrenMessage(element, particleMatchInfo.ExpectedChildren));
                        validationContext.EmitError(errorInfo);

                        return;
                    }
                    else
                    {
                        expectedChildren = GetExpectedChildrenMessage(validationContext.Element, particleMatchInfo.ExpectedChildren);
                    }
                    break;

                case ParticleMatch.Matched:
                    if (this.ParticleConstraint.CanOccursMoreThanOne)
                    {
                        expectedChildren = GetExpectedChildrenMessage(validationContext.Element, this.GetExpectedElements());
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
                //Fix bug #448264, specifal case: same element name, but wrong type. Only occurs when validating memory DOM.
                var validElement = element.TryCreateValidChild(validationContext.FileFormat, child.NamespaceUri, child.LocalName);
                if (validElement == null)
                {
                    errorInfo = validationContext.ComposeSchemaValidationError(element, child, "Sch_InvalidElementContentExpectingComplex", child.XmlQualifiedName.ToString(), expectedChildren);
                }
                else
                {
                    // parent can contains a different type of element with same name
                    errorInfo = validationContext.ComposeSchemaValidationError(element, child, "Sch_InvalidElementContentWrongType", child.XmlQualifiedName.ToString(), child.GetType().Name);
                }
            }
            validationContext.EmitError(errorInfo);
        }
    }


    /**********************************************************************************************
     * Some assumption for schema complex type.
     * 1). A same tag (like 'w:b') only occurs once in the complext type defination in the schema.
     * This assumption is correct for Ecma376.
    **********************************************************************************************/
}
