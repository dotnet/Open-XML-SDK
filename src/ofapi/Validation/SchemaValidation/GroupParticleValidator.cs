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
    /// Group particle validator.
    /// </summary>
    internal class GroupParticleValidator : CompositeParticleValidator
    {
        /// <summary>
        /// Initializes a new instance of the ChoiceParticleValidator.
        /// </summary>
        /// <param name="particleConstraint"></param>
        internal GroupParticleValidator(CompositeParticle particleConstraint)
            : base(particleConstraint)
        {
            Debug.Assert(particleConstraint != null);
            Debug.Assert(particleConstraint.ParticleType == ParticleType.Group);
        }

        // ***********************************************************
        //<xsd:group ref="..." /> is valid under <xsd:complexType>
        //<xsd:complexType name="CT_HdrFtr">
        //  <xsd:group ref="EG_BlockLevelElts" minOccurs="1" maxOccurs="unbounded" />
        //</xsd:complexType>
        // ***********************************************************

        ///// <summary>
        ///// Be called on root particle of complex type.
        ///// </summary>
        ///// <param name="validationContext"></param>
        ///// <returns></returns>
        //internal override SchemaValidationResult Validate(ValidationContext validationContext)
        //{
        //    throw new InvalidOperationException();
        //}


        /// <summary>
        /// Try match the particle once.
        /// </summary>
        /// <param name="particleMatchInfo"></param>
        /// <param name="validationContext">The context information for validation.</param>
        public override void TryMatchOnce(ParticleMatchInfo particleMatchInfo, ValidationContext validationContext)
        {
            Debug.Assert(!(particleMatchInfo.StartElement is OpenXmlMiscNode));
            
            // group only contains xsd:all, xsd:choice or xsd:sequence
            Debug.Assert(this.ParticleConstraint.ChildrenParticles.Length == 1);

            var childParticle = this.ParticleConstraint.ChildrenParticles[0];

            Debug.Assert(childParticle.ParticleType == ParticleType.All ||
                        childParticle.ParticleType == ParticleType.Choice ||
                        childParticle.ParticleType == ParticleType.Sequence);

            childParticle.ParticleValidator.TryMatch(particleMatchInfo, validationContext);

            return;
        }
    }

}
