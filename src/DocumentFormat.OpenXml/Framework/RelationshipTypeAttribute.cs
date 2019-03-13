// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml.Framework
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    internal sealed class RelationshipTypeAttribute : Attribute
    {
        public RelationshipTypeAttribute(string relationshipType)
        {
            RelationshipType = relationshipType;
        }

        public string RelationshipType { get; }
    }
}
