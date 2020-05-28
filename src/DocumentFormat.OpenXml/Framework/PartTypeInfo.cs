// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Reflection;

namespace DocumentFormat.OpenXml.Framework
{
    internal sealed class PartTypeInfo
    {
        public PartTypeInfo(Type type)
        {
#pragma warning disable CS0618 // Type or member is obsolete
            PartClassName = type.Name;
#pragma warning restore CS0618 // Type or member is obsolete
            PartContentType = type.GetTypeInfo().GetCustomAttribute<ContentTypeAttribute>()?.ContentType;
            Availability = type.GetTypeInfo().GetCustomAttribute<OfficeAvailabilityAttribute>()?.OfficeVersion ?? FileFormatVersions.Office2007;
            RelationshipType = type.GetTypeInfo().GetCustomAttribute<RelationshipTypeAttribute>()?.RelationshipType ?? string.Empty;
        }

        public static PartTypeInfo Create(Type type) => new PartTypeInfo(type);

        public string RelationshipType { get; }

        [Obsolete(ObsoleteAttributeMessages.ObsoleteV1ValidationFunctionality, false)]
        public string PartClassName { get; }

        public string PartContentType { get; }

        public FileFormatVersions Availability { get; }
    }
}
