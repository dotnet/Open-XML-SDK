// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections;

namespace DocumentFormat.OpenXml.Generator;

public sealed record class ParentClass(string Keyword, string Name, string Constraints, ParentClass? Child) : IEnumerable<ParentClass>
{
    public IEnumerator<ParentClass> GetEnumerator()
    {
        ParentClass? child = this;

        while (child is not null)
        {
            yield return child;
            child = child.Child;
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
