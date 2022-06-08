// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using System;

namespace DocumentFormat.OpenXml.Framework
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    internal sealed class PartConstraintAttribute : Attribute, IConstraintAttribute
    {
        public PartConstraintAttribute(Type constraintType, bool minOccursIsNonZero, bool maxOccursGreatThanOne)
        {
            ConstraintType = constraintType;
            MinOccursIsNonZero = minOccursIsNonZero;
            MaxOccursGreatThanOne = maxOccursGreatThanOne;
        }

        public Type ConstraintType { get; }

        public bool MinOccursIsNonZero { get; }

        public bool MaxOccursGreatThanOne { get; }
    }
}
