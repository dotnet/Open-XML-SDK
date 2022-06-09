// Copyright (c) Microsoft.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Generator.Schematron
{
    public record ElementReference(string Name)
    {
        public override string ToString() => Name;
    }
}
