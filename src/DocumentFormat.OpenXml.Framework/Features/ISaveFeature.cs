// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using System;

namespace DocumentFormat.OpenXml.Features;

internal interface ISaveFeature
{
    void Save(OpenXmlPartContainer container);

    void Register(Action<OpenXmlPartContainer> container);
}
