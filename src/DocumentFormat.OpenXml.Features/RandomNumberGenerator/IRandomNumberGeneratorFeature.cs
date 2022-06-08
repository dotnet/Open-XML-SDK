// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

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
