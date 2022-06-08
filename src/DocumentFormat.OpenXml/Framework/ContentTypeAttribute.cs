// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

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
