// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentFormat.OpenXml.Packaging;

public interface IExtensionChildrenParent<T>
    where T : IExtensionChildrenParent<T>
{
#if NET8_0_OR_GREATER
    public static abstract IEnumerable<OpenXmlSchemaType> ExtensionChildren { get; }

    public IEnumerable<OpenXmlSchemaType> GetExtensionChildren()
        => T.ExtensionChildren;
#endif
}
