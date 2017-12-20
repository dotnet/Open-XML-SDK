// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;

namespace DocumentFormat.OpenXml
{
    internal static class OfficeVersions
    {
        /// <summary>
        /// Determines whether the supplied version is within the known set of versions
        /// </summary>
        /// <param name="version">The version to check</param>
        /// <returns>True if a known version, otherwise false</returns>
        public static bool Any(this FileFormatVersions version)
        {
            return version == FileFormatVersions.Office2007
                || version == FileFormatVersions.Office2010
                || version == FileFormatVersions.Office2013
                || version == FileFormatVersions.Office2016;
        }

        /// <summary>
        /// Combines values for the given version and all versions that come after it
        /// </summary>
        /// <param name="version">Version to which all other versions are added</param>
        /// <returns>A version instance with <paramref name="version"/> and all later versions</returns>
        public static FileFormatVersions AndLater(this FileFormatVersions version)
        {
            switch (version)
            {
                case FileFormatVersions.Office2007:
                    return FileFormatVersions.Office2007
                         | FileFormatVersions.Office2010
                         | FileFormatVersions.Office2013
                         | FileFormatVersions.Office2016;
                case FileFormatVersions.Office2010:
                    return FileFormatVersions.Office2010
                         | FileFormatVersions.Office2013
                         | FileFormatVersions.Office2016;
                case FileFormatVersions.Office2013:
                    return FileFormatVersions.Office2013
                         | FileFormatVersions.Office2016;
                case FileFormatVersions.Office2016:
                    return FileFormatVersions.Office2016;
                default:
                    Debug.Assert(false, "This should only be called with a single version");
                    return version;
            }
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
