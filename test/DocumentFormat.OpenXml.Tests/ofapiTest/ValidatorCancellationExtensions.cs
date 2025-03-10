// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#if FEATURE_NO_VALIDATOR_CANCELLATIONTOKEN

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Tests;

/// <summary>
/// Used for tests that cross compile and need to pass in a cancellation token. Since this is shadowed currently in the .NET 3.5 builds,
/// we take the token as an object since we don't need to do anything besides compile.
/// </summary>
internal static class ValidatorCancellationExtensions
{
    internal static IEnumerable<ValidationErrorInfo> Validate(this OpenXmlValidator validator, OpenXmlPackage package, object token)
        => validator.Validate(package);

    internal static IEnumerable<ValidationErrorInfo> Validate(this OpenXmlValidator validator, OpenXmlElement element, object token)
        => validator.Validate(element);

    internal static IEnumerable<ValidationErrorInfo> Validate(this OpenXmlValidator validator, OpenXmlPart part, object token)
        => validator.Validate(part);
}

#endif
