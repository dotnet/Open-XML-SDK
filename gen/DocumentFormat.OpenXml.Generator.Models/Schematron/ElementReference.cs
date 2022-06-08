// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

namespace DocumentFormat.OpenXml.Generator.Schematron
{
    public record ElementReference(string Name)
    {
        public override string ToString() => Name;
    }
}
