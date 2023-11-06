// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Features;

internal interface IDebugPackageInformation
{
    IEnumerable<OpenXmlQualifiedName> RootElements { get; }

    IEnumerable<string> Relationships { get; }
}
