// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Xunit;

namespace DocumentFormat.OpenXml.Framework.Tests
{
    public class HashCodeTests
    {
        private const int Seed = 23;
        private const int Combinator = 37;

        [Fact]
        public void NoValue()
        {
            Assert.Equal(0, new HashCode().ToHashCode());
        }

        [Fact]
        public void SingleValue()
        {
            var input = 123456;
            var expected = Seed * Combinator + input.GetHashCode();

            var hashCode = new HashCode();
            hashCode.Add(input);

            Assert.Equal(expected, hashCode.ToHashCode());
        }

        [Fact]
        public void DoubleValue()
        {
            var input1 = 123456;
            var input2 = 123456.1234;

            var hashCode = new HashCode();
            hashCode.Add(input1);
            hashCode.Add(input2);
            var result = hashCode.ToHashCode();

            Assert.NotEqual(0, result);

            Assert.Equal(result, HashCode.Combine(input1, input2));
        }

        [Fact]
        public void TripleValue()
        {
            var input1 = 123456;
            var input2 = 123456.1234;
            var input3 = true;

            var hashCode = new HashCode();
            hashCode.Add(input1);
            hashCode.Add(input2);
            hashCode.Add(input3);
            var result = hashCode.ToHashCode();

            Assert.NotEqual(0, result);

            Assert.Equal(result, HashCode.Combine(input1, input2, input3));
        }

        [Fact]
        public void Comparer()
        {
            var comparer = StringComparer.Ordinal;
            var input = "DocumentFormat.OpenXml";

            var expected = Seed * Combinator + comparer.GetHashCode(input);

            var hashCode = new HashCode();
            hashCode.Add(input, comparer);
            var result = hashCode.ToHashCode();

            Assert.Equal(expected, result);
        }

        private class DelegateGetHashCode<T> : IEqualityComparer<T>
        {
            private readonly Func<T, int> _func;

            public DelegateGetHashCode(Func<T, int> func)
            {
                _func = func ?? throw new ArgumentNullException(nameof(func));
            }

            public bool Equals(T x, T y) => throw new NotImplementedException();

            public int GetHashCode(T obj) => _func(obj);
        }
    }
}
