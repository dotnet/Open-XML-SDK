// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Factory to create a new enum value of the specified type.
    /// </summary>
    /// <typeparam name="T">Type to create enum.</typeparam>
    public interface IEnumValueFactory<T>
        where T : IEnumValue
    {
        /// <summary>
        /// Creates an enum value with the supplied value.
        /// </summary>
        /// <param name="value">Value of enum</param>
        /// <returns>Constructed enum.</returns>
        T Create(string value);
    }
}
