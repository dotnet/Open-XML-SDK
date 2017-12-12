// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System;

namespace DocumentFormat.OpenXml
{
    internal static class OfficeVersions
    {
        /// <summary>
        /// Represents an enum for all office versions.
        /// </summary>
        public const FileFormatVersions All = FileFormatVersions.Office2007
                                            | FileFormatVersions.Office2010
                                            | FileFormatVersions.Office2013;

        /// <summary>
        /// Determines whether the supplied version is within the known set of versions
        /// </summary>
        /// <param name="version">The version to check</param>
        /// <returns>True if a known version, otherwise false</returns>
        public static bool Any(this FileFormatVersions version)
        {
            return version == FileFormatVersions.Office2007
                || version == FileFormatVersions.Office2010
                || version == FileFormatVersions.Office2013;
        }

        /// <summary>
        /// Determines whether the source FileFormatVersions includes the target FileFormatVersions. 
        /// </summary>
        /// <param name="source">The source FileFormatVersions to be tested.</param>
        /// <param name="target">The target FileFormatVersions be tested against.</param>
        /// <returns>Returns true when (source &amp; target) == target.</returns>
        internal static bool Includes(this FileFormatVersions source, FileFormatVersions target)
        {
            return (source & target) == target;
        }

        /// <summary>
        /// Throws an ArgumentOutOfRangeException if the specified FileFormatVersions is not supported.
        /// </summary>
        /// <param name="fileFormat">The specified FileFormatVersions.</param>
        /// <param name="parameterName">The name of the parameter for ArgumentOutOfRangeException.</param>
        /// <remarks>
        /// </remarks>
        internal static void ThrowExceptionIfFileFormatNotSupported(this FileFormatVersions fileFormat, string parameterName)
        {
            if (!fileFormat.Any())
            {
                var message = String.Format(System.Globalization.CultureInfo.CurrentUICulture, ExceptionMessages.FileFormatNotSupported, fileFormat);

                throw new ArgumentOutOfRangeException(parameterName, message);
            }
        }
    }
}
