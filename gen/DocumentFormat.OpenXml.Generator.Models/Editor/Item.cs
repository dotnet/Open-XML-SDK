// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Generator.Editor;

internal record Item(ItemType Type, string Name, Action<IndentedTextWriter> Action);
