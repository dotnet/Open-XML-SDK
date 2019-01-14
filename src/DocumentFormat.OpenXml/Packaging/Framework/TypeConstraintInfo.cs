// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Reflection;

namespace DocumentFormat.OpenXml.Packaging
{
    internal sealed class TypeConstraintInfo
    {
#if FEATURE_NO_CONDITIONAL_WEAK_TABLE
        private static readonly LockingDictionary<Type, TypeConstraintInfo> _constraintLookup = new LockingDictionary<Type, TypeConstraintInfo>();
#else
        private static readonly System.Runtime.CompilerServices.ConditionalWeakTable<Type, TypeConstraintInfo> _constraintLookup = new System.Runtime.CompilerServices.ConditionalWeakTable<Type, TypeConstraintInfo>();
#endif

        private TypeConstraintInfo(Type type)
        {
            PartClassName = type.Name;
            PartContentType = type.GetTypeInfo().GetCustomAttribute<ContentTypeAttribute>()?.ContentType;
            Availability = type.GetTypeInfo().GetCustomAttribute<OfficeAvailabilityAttribute>()?.OfficeVersion ?? FileFormatVersions.Office2007;
            RelationshipType = type.GetTypeInfo().GetCustomAttribute<RelationshipTypeAttribute>()?.RelationshipType ?? string.Empty;
        }

        public static TypeConstraintInfo Get(Type type) => _constraintLookup.GetValue(type, Create);

        private static TypeConstraintInfo Create(Type type) => new TypeConstraintInfo(type);

        public string RelationshipType { get; }

        public string PartClassName { get; }

        public string PartContentType { get; }

        public FileFormatVersions Availability { get; }
    }
}
