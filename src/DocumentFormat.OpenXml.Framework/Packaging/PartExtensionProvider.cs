// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines a provider which maintains a dictionary where the key is the content type and the value is a part extension.
    /// </summary>
    internal sealed class PartExtensionProvider : Dictionary<string, string>, IPartExtensionFeature
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PartExtensionProvider"/> class that is empty.
        /// </summary>
        public PartExtensionProvider()
            : base(StringComparer.Ordinal)
        {
        }

        /// <summary>
        /// Check to make sure the content type and part extension is in the provider. If not, they will be added.
        /// </summary>
        /// <param name="contentType">The content type</param>
        /// <param name="extension">Part Extension (".xml") to be used for the part with the specified content type.</param>
        /// <exception cref="ArgumentNullException">Thrown when either parameter is null.</exception>
        public void Register(string contentType, string extension)
        {
            if (contentType is null)
            {
                throw new ArgumentNullException(nameof(contentType));
            }

            if (extension is null)
            {
                throw new ArgumentNullException(nameof(extension));
            }

            this[contentType] = extension;
        }

        public bool TryGetExtension(string contentType, [MaybeNullWhen(false)] out string extension)
            => TryGetValue(contentType, out extension);
    }
}
