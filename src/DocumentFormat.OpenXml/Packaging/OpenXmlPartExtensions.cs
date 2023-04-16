// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using System;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines information used in creating a new part.
    /// </summary>
    public readonly record struct PartTypeInfo
    {
        /// <summary>
        /// Ctor - assign content type and extention.
        /// </summary>
        public PartTypeInfo(string contentType, string extension)
        {
            ContentType = contentType;
            Extension = extension;
        }

        /// <summary>
        /// Gets content type for the part.
        /// </summary>
        public string ContentType { get; }

        /// <summary>
        /// Gets the file extension for the part.
        /// </summary>
        public string Extension { get; }
    }

    internal static class OpenXmlPartExtensions
    {
        internal static OpenXmlPart InitPart(this OpenXmlPartContainer parent, OpenXmlPart childPart, PartTypeInfo partType, string? contentType = null, string? relId = null)
        {
            if (parent == null)
            {
                throw new ArgumentNullException(message: "Parent part MUST be provided.", paramName: nameof(parent));
            }

            contentType ??= partType.ContentType ?? throw new InvalidOperationException("No content type specified");

            var partExtension = partType.Extension;
            parent.Features.GetRequired<IPartExtensionFeature>().Register(contentType, partExtension);

            if (relId == null || relId.Length == 0)
            {
                relId = null;
            }

            parent.InitPart(childPart, contentType, relId);
            return childPart;
        }
    }
}
