// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Features
{
    /// <summary>
    /// A feature to generate random numbers
    /// </summary>
    public interface IRandomNumberGeneratorFeature
    {
        /// <summary>
        /// Fills the supplied bytes with random values.
        /// </summary>
        /// <param name="bytes">Bytes to fill.</param>
        void GetBytes(byte[] bytes);
    }
}
