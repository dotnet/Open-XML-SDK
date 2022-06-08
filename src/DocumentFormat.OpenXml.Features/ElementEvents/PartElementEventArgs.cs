// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

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
