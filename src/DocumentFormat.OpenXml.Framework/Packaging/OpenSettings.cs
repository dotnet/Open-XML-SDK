// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Represents the settings when opening a document.
    /// </summary>
    public class OpenSettings
    {
        private MarkupCompatibilityProcessSettings? _mcSettings;
        private CompatibilityLevel _compatibilityLevel;

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenSettings"/> class.
        /// </summary>
        public OpenSettings()
        {
        }

        internal OpenSettings(OpenSettings? other)
        {
            if (other is null)
            {
                return;
            }

            AutoSave = other.AutoSave;
            MarkupCompatibilityProcessSettings.ProcessMode = other.MarkupCompatibilityProcessSettings.ProcessMode;
            MarkupCompatibilityProcessSettings.TargetFileFormatVersions = other.MarkupCompatibilityProcessSettings.TargetFileFormatVersions;
            MaxCharactersInPart = other.MaxCharactersInPart;
            CompatibilityLevel = other.CompatibilityLevel;
        }

        /// <summary>
        /// Gets or sets a value indicating whether to auto save document modifications.
        /// The default value is true.
        /// </summary>
        public bool AutoSave { get; set; } = true;

        /// <summary>
        /// Gets or sets a version to keep compat to
        /// </summary>
        public CompatibilityLevel CompatibilityLevel
        {
            get => _compatibilityLevel == CompatibilityLevel.Default ? CompatibilityLevel.Version_3_0 : _compatibilityLevel;
            set => _compatibilityLevel = value;
        }

        /// <summary>
        /// Gets or sets the value of the markup compatibility processing mode.
        /// </summary>
        public MarkupCompatibilityProcessSettings MarkupCompatibilityProcessSettings
        {
            get
            {
                _mcSettings ??= new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.NoProcess, FileFormatVersions.Office2007);

                return _mcSettings;
            }

            set
            {
                _mcSettings = value;
            }
        }

        /// <summary>
        /// Gets or sets a value that indicates the maximum number of allowable characters in an Open XML part. A zero (0) value indicates that there are no limits on the size of the part. A non-zero value specifies the maximum size, in characters.
        /// </summary>
        /// <remarks>
        /// This property allows you to mitigate denial of service attacks where the attacker submits a package with an extremely large Open XML part. By limiting the size of the part, you can detect the attack and recover reliably.
        /// </remarks>
        public long MaxCharactersInPart { get; set; }
    }
}
