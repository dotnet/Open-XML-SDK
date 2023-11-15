// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml;

internal static class ExperimentalApis
{
    internal const string UrlFormat = "https://aka.ms/openxmlsdk-diagnostics#{0}";

    internal static class PackageApis
    {
        public const string DiagnosticId = "OOXML0001";
        public const string Message = "IPackage related APIs are currently experimental. Future versions may (or may not) change their shape before stabilizing.";
    }
}
