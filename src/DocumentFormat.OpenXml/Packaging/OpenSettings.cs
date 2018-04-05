// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Represents the settings when opening a document.
    /// </summary>
    public class OpenSettings
    {
        private bool? autoSave;
        private MarkupCompatibilityProcessSettings _mcSettings;

        /// <summary>
        /// Gets or sets a value indicating whether to auto save document modifications.
        /// The default value is true.
        /// </summary>
        public bool AutoSave
        {
            get
            {
                if (autoSave == null)
                {
                    return true;
                }

                return (bool)autoSave;
            }

            set
            {
                autoSave = value;
            }
        }

        /// <summary>
        /// Gets or sets the value of the markup compatibility processing mode.
        /// </summary>
        public MarkupCompatibilityProcessSettings MarkupCompatibilityProcessSettings
        {
            get
            {
                if (_mcSettings == null)
                    _mcSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.NoProcess, FileFormatVersions.Office2007);
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
