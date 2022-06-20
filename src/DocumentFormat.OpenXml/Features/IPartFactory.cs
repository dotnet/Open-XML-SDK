// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;

namespace DocumentFormat.OpenXml.Features;

internal interface IPartFactory
{
    T Create<T>() where T : OpenXmlPart;
}
