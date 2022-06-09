// Copyright (c) Microsoft.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Framework.Metadata
{
    internal interface IMetadataBuilder<T>
    {
        T Build();
    }
}
