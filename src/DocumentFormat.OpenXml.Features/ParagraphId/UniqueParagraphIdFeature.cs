// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Features
{
    internal class UniqueParagraphIdFeature : IParagraphIdFeature
    {
        private readonly IRandomNumberGeneratorFeature _randomNumber;

        /// <summary>
        /// Used to keep track of the existing elements
        /// </summary>
        private readonly HashSet<string> _map = new(StringComparer.OrdinalIgnoreCase);

        public UniqueParagraphIdFeature(IRandomNumberGeneratorFeature randomNumber)
        {
            _randomNumber = randomNumber;
        }

        public IEnumerable<string> RegisteredParagraphIds => _map;

        public int Count => _map.Count;

        public bool Contains(string paraId) => _map.Contains(paraId);

        public string CreateUniqueParagraphId()
        {
            var paraId = CreateUniqueParagraphId(_map.Contains, true);
            _map.Add(paraId);
            return paraId;
        }

        internal string CreateUniqueParagraphId(Func<string, bool> contains, bool track)
        {
            var bytes = new byte[] { 0x00, 0x00, 0x00, 0x00 };
            string? str;

            do
            {
                do
                {
                    _randomNumber.GetBytes(bytes);
                } while (bytes[0] >= 0x80 || bytes[0] == 0 && bytes[1] == 0 && bytes[2] == 0 && bytes[3] == 0);

                str = HexStringFactory.Create(bytes);
            } while (contains(str));

            if (track)
            {
                _map.Add(str);
            }

            return str;
        }
    }
}
