// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml
{
    internal ref struct FrameworkHashCode
    {
        private const int Seed = 23;
        private const int Combinator = 37;

        private int _code;

        public FrameworkHashCode()
        {
            this._code = Seed;
        }

        internal void Add(object? value)
        {
            if (value != null)
            {
                unchecked
                {
                    this._code += value.GetHashCode() * Combinator;
                }
            }
        }

        internal readonly int GetHash => this._code;
    }
}
