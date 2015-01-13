// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using DocumentFormat.OpenXml.Validation;

namespace DocumentFormat.OpenXml.Internal.SchemaValidation
{
    /// <summary>
    /// A constraint data item for complex type.
    /// The ParticleType, MinOccurs, MaxOccurs means the constaint of this particle in the parent.
    /// </summary>
    /// <remarks>
    /// </remarks>
    internal abstract class ParticleConstraint
    {
        /// <summary>
        /// Initializes a new instance of the ParticleConstraint.
        /// </summary>
        internal ParticleConstraint()
        {
            // default minOccurs and maxOccurs are 1.
            //this.MaxOccurs = 1;
            //this.MinOccurs = 1;
        }

        /// <summary>
        /// Gets the type of the particle.
        /// </summary>
        internal virtual ParticleType ParticleType
        {
            get { return ParticleType.Invalid; }
            set { throw new InvalidOperationException(); }
        }

        /// <summary>
        /// Gets or sets the minOccurs constraint.
        /// </summary>
        internal int MinOccurs { get; set; }

        /// <summary>
        /// Gets or sets the maxOccurs constraint.
        /// 0 means "unbounded".
        /// </summary>
        internal int MaxOccurs { get; set; }

        /// <summary>
        /// Gets whether the maxOccurs="unbounded".
        /// </summary>
        internal bool UnboundedMaxOccurs
        {
            get { return this.MaxOccurs == 0; }
        }

        /// <summary>
        /// Return true if maxOccurs="unbounded" or maxOccurs > 1
        /// </summary>
        internal bool CanOccursMoreThanOne
        {
            get { return this.UnboundedMaxOccurs || this.MaxOccurs > 1; }
        }

        /// <summary>
        /// Test whether the count is valid.
        /// </summary>
        /// <param name="count">The count of the occurs.</param>
        /// <returns>Returns true if maxOccurs="unbounded" or this.MaxOccurs>count.</returns>
        internal bool MaxOccursGreaterThan(int count)
        {
            return this.UnboundedMaxOccurs || this.MaxOccurs > count;
        }

        /// <summary>
        /// Gets or sets the type ID of the OpenXmlElement if the ParticleType == ParticleType.Element.
        /// </summary>
        /// <remarks>
        /// TODO: change int to ushort?
        /// </remarks>
        internal virtual int ElementId
        {
            get { return SdbData.InvalidId; }
            set { Debug.Assert(value == SdbData.InvalidId); }
        }

        /// <summary>
        /// Gets the children particles.
        /// </summary>
        /// <remarks>
        /// be null if the ParticleType == ParticleType.Element || ParticleType=ParticleType.Any
        /// </remarks>
        internal virtual ParticleConstraint[] ChildrenParticles
        {
            get { return null; }
            set { throw new InvalidOperationException(); }
        }

        /// <summary>
        /// Gets a ParticleValidator for this particle constraint.
        /// </summary>
        internal virtual IParticleValidator ParticleValidator
        {
            get { return null; }
        }

        /// <summary>
        /// Test whether this is a simple particle - the particle conatains only elements as children.
        /// </summary>
        /// <returns></returns>
        internal bool IsSimple()
        {
            bool isSimple = true;

            if (this.ChildrenParticles != null)
            {
                foreach (var constraint in this.ChildrenParticles)
                {
                    if (constraint.ParticleType == ParticleType.All ||
                        constraint.ParticleType == ParticleType.Choice ||
                        constraint.ParticleType == ParticleType.Group ||
                        constraint.ParticleType == ParticleType.Sequence ||
                        constraint.ParticleType == ParticleType.Any ||
                        constraint.ParticleType == ParticleType.AnyWithUri)
                    {
                        // there are sequence particles without any children.
                        // Debug.Assert(constraint.ChildrenParticles != null && constraint.ChildrenParticles.Length > 0);
                        isSimple = false;
                    }
                    else
                    {
                    }
                }
            }

            return isSimple;
        }

        /// <summary>
        /// Create a ParticleConstraint for the specified ParticleType.
        /// </summary>
        /// <param name="particleType"></param>
        /// <returns></returns>
        internal static ParticleConstraint CreateParticleConstraint(ParticleType particleType)
        {
            switch (particleType)
            {
                case ParticleType.Element:
                    return new ElementParticle();

                case ParticleType.Any:
                    return new AnyParticle();

                case ParticleType.AnyWithUri:
                    return new NsAnyParticle();

                case ParticleType.Invalid:
                    Debug.Assert(particleType != ParticleType.Invalid);
                    return null;

                default:
                    return new CompositeParticle();
            }
        }
    }

    /// <summary>
    /// Particle constraint data for particle which type is ParticleType.Element.
    /// </summary>
    [DebuggerDisplay("ElementId={ElementId}")]
    internal class ElementParticle : ParticleConstraint, IParticleValidator
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int _elementId;     
       
        /// <summary>
        /// Initializes a new instance of the ElementParticle.
        /// </summary>
        internal ElementParticle()
            : base()
        {
        }

        /// <summary>
        /// Gets the type of the particle.
        /// </summary>
        internal override ParticleType ParticleType
        {
            get { return ParticleType.Element; }
            set { Debug.Assert(value == ParticleType.Element); }
        }

        /// <summary>
        /// Gets or sets the type ID of the OpenXmlElement if the ParticleType == ParticleType.Element.
        /// </summary>
        internal override int ElementId
        {
            get { return this._elementId; }
            set { this._elementId = value; }
        }

        /// <summary>
        /// Gets a ParticleValidator for this particle constraint.
        /// </summary>
        internal override IParticleValidator ParticleValidator
        {
            get { return this; }
        }

        #region IParticleValidator Members

        /// <summary>
        /// Try match this element once.
        /// </summary>
        /// <param name="particleMatchInfo"></param>
        /// <param name="validationContext"></param>
        public void TryMatchOnce(ParticleMatchInfo particleMatchInfo, ValidationContext validationContext)
        {
            Debug.Assert(particleMatchInfo != null);
            Debug.Assert(particleMatchInfo.StartElement != null);
            
            if (particleMatchInfo.StartElement.ElementTypeId == this.ElementId)
            {
                particleMatchInfo.Match = ParticleMatch.Matched;
                particleMatchInfo.LastMatchedElement = particleMatchInfo.StartElement;
            }
            else
            {
                particleMatchInfo.Match = ParticleMatch.Nomatch;
            }
            return;
        }

        /// <summary>
        /// Try match this element.
        /// </summary>
        /// <param name="particleMatchInfo"></param>
        /// <param name="validationContext"></param>
        public void TryMatch(ParticleMatchInfo particleMatchInfo, ValidationContext validationContext)
        {
            Debug.Assert(particleMatchInfo != null);
            Debug.Assert(particleMatchInfo.StartElement != null);

            if (this.ElementId != particleMatchInfo.StartElement.ElementTypeId)
            {
                particleMatchInfo.Match = ParticleMatch.Nomatch;
            }
            else if (this.MaxOccurs == 1)
            {
                // matched element once.
                particleMatchInfo.Match = ParticleMatch.Matched;
                particleMatchInfo.LastMatchedElement = particleMatchInfo.StartElement;
            }
            else
            {
                // try to match multiple elements.
                var element = particleMatchInfo.StartElement;
                int count = 0;

                while (element != null &&
                    this.MaxOccursGreaterThan(count) &&
                    element.ElementTypeId == this.ElementId)
                {
                    count++;
                    particleMatchInfo.LastMatchedElement = element;
                    element = validationContext.GetNextChildMc(element);
                }

                if (count >= this.MinOccurs)
                {
                    particleMatchInfo.Match = ParticleMatch.Matched;
                }
                else
                {
                    particleMatchInfo.Match = ParticleMatch.Partial;
                    if (validationContext.CollectExpectedChildren)
                    {
                        if (particleMatchInfo.ExpectedChildren == null)
                        {
                            particleMatchInfo.InitExpectedChildren();
                        }
                        particleMatchInfo.ExpectedChildren.Add(this.ElementId);
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
        public bool GetRequiredElements(ExpectedChildren result)
        {
            if (this.MinOccurs > 0)
            {
                if (result != null)
                {
                    result.Add(this.ElementId);
                }
                return true;
            }
            return false;
        }
        
        /// <summary>
        /// Get the required elements - elements which minOccurs > 0.
        /// </summary>
        /// <returns>Required elements in this particle.</returns>
        public ExpectedChildren GetRequiredElements()
        {
            ExpectedChildren requiredElements = new ExpectedChildren();

            if (this.MinOccurs > 0)
            {
                requiredElements.Add(this.ElementId);
            }

            return requiredElements;
        }

        /// <summary>
        /// Get the expected elements - elements which minOccurs >= 0.
        /// </summary>
        /// <param name="result"></param>
        /// <returns>True if there are expected elements in this particle.</returns>
        public bool GetExpectedElements(ExpectedChildren result)
        {
            result.Add(this.ElementId);
            return true;
        }

        /// <summary>
        /// Get the expected elements - elements which minOccurs >= 0.
        /// </summary>
        /// <returns>Expected elements in this particle.</returns>
        public ExpectedChildren GetExpectedElements()
        {
            ExpectedChildren expectedElements = new ExpectedChildren();

            expectedElements.Add(this.ElementId);

            return expectedElements;
        }

        #endregion
    }

    /// <summary>
    /// Particle constraint data for particle which type is ParticleType.Any.
    /// </summary>
    /// <remarks>
    /// xsd:any can contains only one namespace. 
    /// If there are multiple namespace in the original xsd, it will be splitted into multiple xsd:any in binary database.
    /// </remarks>
    [DebuggerDisplay("NamespaceValue={NamespaceValue}")]
    internal class AnyParticle : ParticleConstraint
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ushort _xsdAnyValue;
        private IParticleValidator _particleValidator;

        /// <summary>
        /// Initializes a new instance of the AnyParticle.
        /// </summary>
        internal AnyParticle()
            : base()
        {
            _particleValidator = new AnyParticleValidator(this);
        }

        /// <summary>
        /// Gets the type of the particle.
        /// </summary>
        internal override ParticleType ParticleType
        {
            get { return ParticleType.Any; }
            set { Debug.Assert(value == ParticleType.Any); }
        }

        /// <summary>
        /// This field is actually the value of the xsd:any.
        /// </summary>
        internal override int ElementId
        {
            set 
            {
                Debug.Assert( value == XsdAnyPrefidefinedValue.Any ||
                            value == XsdAnyPrefidefinedValue.Local ||
                            value == XsdAnyPrefidefinedValue.Other ||
                            value == XsdAnyPrefidefinedValue.TargetNamespace);

                this._xsdAnyValue = (ushort)value; 
            }
        }

        /// <summary>
        /// The value of the xsd:any@namespace.
        /// </summary>
        internal ushort NamespaceValue
        {
            get { return this._xsdAnyValue; }
        }


        /// <summary>
        /// Gets a ParticleValidator for this particle constraint.
        /// </summary>
        internal override IParticleValidator ParticleValidator
        {
            get { return this._particleValidator; }
        }
    }

    /// <summary>
    /// Particle constraint data for particle which type is ParticleType.AnyWithUri.
    /// </summary>
    /// <remarks>
    /// xsd:any can contains only one namespace. 
    /// If there are multiple namespace in the original xsd, it will be splitted into multiple xsd:any in binary database.
    /// </remarks>
    [DebuggerDisplay("NamespaceId={NamespaceId}")]
    internal class NsAnyParticle : ParticleConstraint
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte _namespaceId;
        private IParticleValidator _particleValidator;

        /// <summary>
        /// Initializes a new instance of the NsAnyParticle.
        /// </summary>
        internal NsAnyParticle()
            : base()
        {
            _particleValidator = new NsAnyParticleValidator(this);
        }
        
        /// <summary>
        /// Gets the type of the particle.
        /// </summary>
        internal override ParticleType ParticleType
        {
            get { return ParticleType.AnyWithUri; }
            set { Debug.Assert(value == ParticleType.AnyWithUri); }
        }

        /// <summary>
        /// This field is actually the namespace ID of the xsd:any.
        /// </summary>
        internal override int ElementId
        {
            set
            {
                this._namespaceId = (byte)value;
            }
        }

        /// <summary>
        /// The namespace ID of the the namespace in the xsd:any@namespace.
        /// </summary>
        internal byte NamespaceId
        {
            get { return this._namespaceId; }
        }


        /// <summary>
        /// Gets a ParticleValidator for this particle constraint.
        /// </summary>
        internal override IParticleValidator ParticleValidator
        {
            get { return this._particleValidator;  }
        }
    }

    /// <summary>
    /// Particle constraint for sequence, choice, all, and group.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [DebuggerDisplay("ParticleType={ParticleType}")]
    internal class CompositeParticle : ParticleConstraint
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ParticleType _particleType;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ParticleConstraint[] _childrenParticles;

        private IParticleValidator _particleValidator;
        
        /// <summary>
        /// Initializes a new instance of the CompositeParticle.
        /// </summary>
        internal CompositeParticle()
            : base()
        {
        }
    
               
        /// <summary>
        /// Gets the type of the particle.
        /// </summary>
        internal override ParticleType ParticleType
        {
            get { return this._particleType; }
            set { this._particleType = value; }
        }

        /// <summary>
        /// Gets the children particles.
        /// </summary>
        internal override ParticleConstraint[] ChildrenParticles
        {
            get { return this._childrenParticles; }
            set { this._childrenParticles = value; }
        }

        /// <summary>
        /// Gets a ParticleValidator for this particle constraint.
        /// </summary>
        internal override IParticleValidator ParticleValidator
        {
            get
            {
                if (this._particleValidator == null)
                {
                    this._particleValidator = SchemaValidation.ParticleValidator.CreateParticleValidator(this);
                }
                return this._particleValidator;
            }
        }

        //internal CompositeParticle NormalizeParticle(CompositeParticle compositeParticle)
        //{
        //    // TODO: do some normalization for the children.
        //    // 1). Remove the group when minOccurs=1 and maxOccurs=1 for the group.
        //    // 2). Merge sequence when minOccurs=1 and maxOccurs=1 for a child sequence.
        //    // 3). Merge choice when minOccurs=1 and maxOccurs=1 for a child choice.
        //    throw new NotImplementedException();
        //}
    }

#if false
    /// <summary>
    /// Particle constraint data for particle which type is ParticleType.All
    /// </summary>
    internal class AllParticle : CompositeParticle
    {
        internal AllParticle() : base()
        {
        }
    }

    /// <summary>
    /// Particle constraint data for particle which type is ParticleType.Choice
    /// </summary>
    internal class ChoiceParticle : CompositeParticle
    {
        internal ChoiceParticle()
            : base()
        {
        }
    }

    /// <summary>
    /// Particle constraint data for particle which type is ParticleType.Sequence
    /// </summary>
    internal class SequenceParticle : CompositeParticle
    {
        internal SequenceParticle()
            : base()
        {
        }
    }

    /// <summary>
    /// Particle constraint data for particle which type is ParticleType.Group
    /// </summary>
    internal class GroupParticle : CompositeParticle
    {
        internal GroupParticle()
            : base()
        {
        }
    }
#endif

}
