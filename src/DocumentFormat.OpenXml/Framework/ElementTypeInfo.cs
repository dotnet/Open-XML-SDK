// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Reflection;

namespace DocumentFormat.OpenXml.Framework
{
    internal sealed class ElementTypeInfo
    {
        public ElementTypeInfo(Type type)
        {
#pragma warning disable CS0618 // Type or member is obsolete
            PartClassName = type.Name;
#pragma warning restore CS0618 // Type or member is obsolete
            PartContentType = type.GetTypeInfo().GetCustomAttribute<ContentTypeAttribute>()?.ContentType;
            Availability = type.GetTypeInfo().GetCustomAttribute<OfficeAvailabilityAttribute>()?.OfficeVersion ?? FileFormatVersions.Office2007;
            RelationshipType = type.GetTypeInfo().GetCustomAttribute<RelationshipTypeAttribute>()?.RelationshipType ?? string.Empty;
            Validators = new ValidatorCollection(type);
            Schema = type.GetTypeInfo().GetCustomAttribute<SchemaAttrAttribute>();
        }

        public static ElementTypeInfo Create(Type type) => new ElementTypeInfo(type);

        public string RelationshipType { get; }

        public ValidatorCollection Validators { get; }

        [Obsolete(ObsoleteAttributeMessages.ObsoleteV1ValidationFunctionality, false)]
        public string PartClassName { get; }

        public string PartContentType { get; }

        public SchemaAttrAttribute Schema { get; }

        public FileFormatVersions Availability { get; }
    }
}
