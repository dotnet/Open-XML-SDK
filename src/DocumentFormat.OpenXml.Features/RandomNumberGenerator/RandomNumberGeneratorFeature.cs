// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using System;
using System.Security.Cryptography;

namespace DocumentFormat.OpenXml.Features
{
    /// <summary>
    /// Extensions to add a random number generator to a feature set.
    /// </summary>
    public static class RandomNumberGeneratorFeatureExtensions
    {
        /// <summary>
        /// Add a random number generator to the package.
        /// </summary>
        public static void AddRandomNumberGeneratorFeature(this OpenXmlPackage package)
        {
            if (package.Features.Get<IRandomNumberGeneratorFeature>() is null)
            {
                package.AddDisposableFeature();
                package.Features.SetDisposable<IRandomNumberGeneratorFeature>(new RandomNumberGeneratorFeature());
            }
        }

        private class RandomNumberGeneratorFeature : IRandomNumberGeneratorFeature, IDisposable
        {
            private readonly RandomNumberGenerator _generator = RandomNumberGenerator.Create();

            public void Dispose()
            {
#if NET40_OR_GREATER
                _generator.Dispose();
#endif
            }

            public void GetBytes(byte[] bytes)
            {
                _generator.GetBytes(bytes);
            }
        }
    }
}
