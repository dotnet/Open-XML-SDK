// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections.Concurrent;

namespace DocumentFormat.OpenXml.Framework
{
    internal class CachedPartMetadataProvider : IPartMetadataFeature
    {
        private readonly ConcurrentDictionary<Type, OpenXmlPartData> _partData = new();

        /// <summary>
        /// Extract the part constraints from a given container.
        /// </summary>
        public OpenXmlPartData Parse(OpenXmlPartContainer part) => _partData.GetOrAdd(part.GetType(), CreatePartData);

        private OpenXmlPartData CreatePartData(Type type) => new OpenXmlPartData(type);
    }
}
