// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Defines an OfficeAvailabilityAttribute class to indicate whether the property is available in a specific version of an Office application.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Class | AttributeTargets.Field)]
    public sealed class OfficeAvailabilityAttribute : Attribute
    {
        /// <summary>
        /// Gets the Office version of the available property.
        /// </summary>
        public FileFormatVersions OfficeVersion { get; internal set; }

        /// <summary>
        /// Initializes a new instance of the OfficeAvailabilityAttribute class.
        /// </summary>
        /// <param name="officeVersion">The Office version where this class or property is available.
        /// If there is more than one version, use bitwise OR to specify multiple versions.</param>
        public OfficeAvailabilityAttribute(FileFormatVersions officeVersion)
        {
            OfficeVersion = officeVersion;
        }
    }
}
