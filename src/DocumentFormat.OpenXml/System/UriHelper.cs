// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml
{
    internal static class UriHelper
    {
        public static readonly UriKind RelativeOrAbsolute = Type.GetType("Mono.Runtime") == null ? UriKind.RelativeOrAbsolute : (UriKind)300;
    }
}
