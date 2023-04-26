// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Generator;

#pragma warning disable SA1313 // Parameter names should begin with lower-case letter

public readonly record struct OpenXmlGeneratorContext(OpenXmlGeneratorServices Services, IDictionary<string, string> Properties);
