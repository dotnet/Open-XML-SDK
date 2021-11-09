// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Features
{
    internal class ParagraphIdGeneratorFeature : IParagraphIdGeneratorFeature
    {
        private readonly IFeatureCollection _features;
        private readonly IRandomNumberGeneratorFeature _randomNumber;

        public ParagraphIdGeneratorFeature(IFeatureCollection features, IRandomNumberGeneratorFeature randomNumber)
        {
            _features = features;
            _randomNumber = randomNumber;
        }

        public string CreateUniqueParagraphId()
        {
            // Lazily retrieve it as the collection may be updated in the feature collection and we want to react to that change.
            var collection = _features.GetRequired<IParagraphIdCollectionFeature>();

            var bytes = new byte[] { 0x00, 0x00, 0x00, 0x00 };
            string? str;

            do
            {
                do
                {
                    _randomNumber.GetBytes(bytes);
                }
                while (bytes[0] >= 0x80 || (bytes[0] == 0 && bytes[1] == 0 && bytes[2] == 0 && bytes[3] == 0));

                str = HexStringFactory.Create(bytes);
            }
            while (collection.Contains(str));

            return str;
        }
    }
}
