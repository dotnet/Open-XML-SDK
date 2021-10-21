// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;

namespace DocumentFormat.OpenXml.Features
{
    internal readonly struct PartElementEventArgs
    {
        public PartElementEventArgs(OpenXmlPart part, OpenXmlElement element, OpenXmlElement? parent)
        {
            Part = part;
            Element = element;
            Parent = parent;
        }

        internal PartElementEventArgs(OpenXmlPart part, ElementEventArgs args)
            : this(part, args.Element, args.ParentElement)
        {
        }

        public OpenXmlPart Part { get; }

        public OpenXmlElement Element { get; }

        public OpenXmlElement? Parent { get; }
    }
}
