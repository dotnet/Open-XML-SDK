// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml.Framework.Metadata;

internal interface IElementMetadata
{
    Type Type { get; }

    ReadOnlyArray<AttributeMetadata> Attributes { get; }

    FileFormatVersions Availability { get; }

    ElementFactoryCollection Children { get; }

    ReadOnlyArray<IValidator> Constraints { get; }

    CompiledParticle? Particle { get; }

    OpenXmlQualifiedName QName { get; }

    ReadOnlyArray<IValidator> Validators { get; }
}
