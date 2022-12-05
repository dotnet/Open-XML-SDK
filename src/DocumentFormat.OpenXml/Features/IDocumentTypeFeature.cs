// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Features;

internal interface IDocumentTypeFeature<T>
    where T : System.Enum
{
    T Type { get; set; }

    void ChangeDocumentType(T newType);
}
