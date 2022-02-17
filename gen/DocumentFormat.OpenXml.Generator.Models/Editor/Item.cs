// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Generator.Editor;

internal record Item(ItemType Type, string Name, Action<IndentedTextWriter> Action);
