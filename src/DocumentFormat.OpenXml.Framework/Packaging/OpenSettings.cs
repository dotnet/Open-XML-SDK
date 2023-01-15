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
            RelationshipErrorHandlerFactory = other.RelationshipErrorHandlerFactory;
            IgnoreExceptionOnCalcChainPartMissing = other.IgnoreExceptionOnCalcChainPartMissing;
        }

        /// <summary>
        /// Gets or sets a value indicating whether to auto save document modifications.
        /// The default value is true.
        /// </summary>
        public bool AutoSave { get; set; } = true;

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

        /// <summary>
        /// Gets or sets a delegate that is used to create a handler to rewrite relationships that are malformed. On platforms after .NET 4.5, <see cref="Uri"/> parsing will fail on malformed strings.
        /// </summary>
        public Func<OpenXmlPackage, RelationshipErrorHandler>? RelationshipErrorHandlerFactory { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to ignore an exception if the calcChain part is missing.
        /// The default value is false which means missing calcChain part will throw an exception upon package open.
        /// </summary>
        public bool IgnoreExceptionOnCalcChainPartMissing { get; set; }
    }
}
