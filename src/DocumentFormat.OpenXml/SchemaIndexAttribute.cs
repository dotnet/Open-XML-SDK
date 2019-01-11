// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Used to indicate order in a schema definition.
    /// </summary>
    /// <remarks>
    /// This may only be here due to the validation system keying of an index.
    /// </remarks>
    [AttributeUsage(AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
    internal sealed class SchemaIndexAttribute : Attribute
    {
        public SchemaIndexAttribute(int index)
        {
            Index = index;
        }

        public int Index { get; }
    }
}
