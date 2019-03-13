// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

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
