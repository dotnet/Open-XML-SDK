// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml.Framework
{
    [AttributeUsage(AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
    internal sealed class IndexAttribute : Attribute
    {
        public IndexAttribute(byte index)
        {
            Index = index;
        }

        public byte Index { get; }
    }
}
