// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml.Framework
{
    [AttributeUsage(AttributeTargets.Class, Inherited = true, AllowMultiple = false)]
    internal sealed class IdAttribute : Attribute
    {
        public IdAttribute(int id)
        {
            Id = id;
        }

        public int Id { get; }
    }
}
