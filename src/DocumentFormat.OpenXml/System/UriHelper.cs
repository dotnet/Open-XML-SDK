// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using System;

namespace DocumentFormat.OpenXml
{
    internal static class UriHelper
    {
        public static readonly UriKind RelativeOrAbsolute = Type.GetType("Mono.Runtime") is null ? UriKind.RelativeOrAbsolute : (UriKind)300;
    }
}
