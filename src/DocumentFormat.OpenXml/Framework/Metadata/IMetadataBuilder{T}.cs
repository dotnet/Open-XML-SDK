// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

namespace DocumentFormat.OpenXml.Framework.Metadata
{
    internal interface IMetadataBuilder<T>
    {
        T Build();
    }
}
