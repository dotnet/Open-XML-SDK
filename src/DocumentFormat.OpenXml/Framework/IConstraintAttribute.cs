// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using System;

namespace DocumentFormat.OpenXml.Framework
{
    internal interface IConstraintAttribute
    {
        Type ConstraintType { get; }

        bool MinOccursIsNonZero { get; }

        bool MaxOccursGreatThanOne { get; }
    }
}
