// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

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
