// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml.Framework
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    internal sealed class ContentTypeAttribute : Attribute
    {
        public ContentTypeAttribute(string contentType)
        {
            ContentType = contentType;
        }

        public string ContentType { get; }
    }
}
