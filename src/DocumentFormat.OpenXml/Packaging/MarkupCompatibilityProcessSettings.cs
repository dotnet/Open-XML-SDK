// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Represents markup compatibility processing settings.
    /// </summary>
    public class MarkupCompatibilityProcessSettings
    {
        /// <summary>
        /// Gets the markup compatibility process mode.
        /// </summary>
        public MarkupCompatibilityProcessMode ProcessMode { get; internal set; }

        /// <summary>
        /// Gets the target file format versions.
        /// </summary>
        public FileFormatVersions TargetFileFormatVersions { get; internal set; }

        /// <summary>
        /// Creates a MarkupCompatibilityProcessSettings object using the supplied process mode and file format versions.
        /// </summary>
        /// <param name="processMode">The process mode.</param>
        /// <param name="targetFileFormatVersions">The file format versions. This parameter is ignored if the value is NoProcess.</param>
        public MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode processMode, FileFormatVersions targetFileFormatVersions)
        {
            ProcessMode = processMode;
            TargetFileFormatVersions = targetFileFormatVersions;
        }

        private MarkupCompatibilityProcessSettings()
        {
            ProcessMode = MarkupCompatibilityProcessMode.NoProcess;
            TargetFileFormatVersions = FileFormatVersions.Office2007;
        }
    }
}
