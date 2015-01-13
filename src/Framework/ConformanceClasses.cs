// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Schema;
using System.Xml;
using System.Diagnostics;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Defines the Office Open XML file format version.
    /// </summary>
    [Flags]
    public enum FileFormatVersions
    {
        /// <summary>
        /// Represents an invalid value which will cause an exception.
        /// </summary>
        None = 0,

        /// <summary>
        /// Represents Microsoft Office 2007.
        /// </summary>
        Office2007 = 0x1,

        /// <summary>
        /// Represents Microsoft Office 2010.
        /// </summary>
        Office2010 = 0x2, 

        /// <summary>
        /// Represents Microsoft Office 2013.
        /// </summary>
        Office2013 = 0x4, 
    }

    internal static class FileFormatExtension
    {
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
            if (! (fileFormat == FileFormatVersions.Office2007 || fileFormat == FileFormatVersions.Office2010 || fileFormat == FileFormatVersions.Office2013))
            {
                string message = String.Format(System.Globalization.CultureInfo.CurrentUICulture,
                                                    ExceptionMessages.FileFormatNotSupported,
                                                    fileFormat);
                throw new ArgumentOutOfRangeException(parameterName, message);
            }
        }
    }

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
