// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// A definition of an OpenXml enum value
    /// </summary>
    public interface IEnumValue
    {
        /// <summary>
        /// Gets a value indicating whether the current value is valid.
        /// </summary>
        bool IsValid { get; }

        /// <summary>
        /// Gets the version this type was introduced in.
        /// </summary>
        FileFormatVersions Version { get; }

        /// <summary>
        /// Gets the value of the enum.
        /// </summary>
        string Value { get; }
    }
}
