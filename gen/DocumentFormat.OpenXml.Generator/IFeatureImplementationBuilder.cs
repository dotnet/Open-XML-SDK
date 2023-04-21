// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Generator;

public interface IFeatureImplementationBuilder
{
    void AddFeature(string name, Func<OpenXmlGeneratorContext, bool> isApplicable, Action<IndentedTextWriter, OpenXmlGeneratorContext> action);
}
