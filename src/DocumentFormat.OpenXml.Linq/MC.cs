// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006" namespace.
    /// </summary>
    public static class MC
    {
#pragma warning disable SA1307 // Accessible fields should begin with upper-case letter
#pragma warning disable SA1311 // Static readonly fields should begin with upper-case letter
        public static readonly XNamespace mc = "http://schemas.openxmlformats.org/markup-compatibility/2006";
#pragma warning restore SA1311 // Static readonly fields should begin with upper-case letter
#pragma warning restore SA1307 // Accessible fields should begin with upper-case letter

        public static readonly XName AlternateContent = mc + "AlternateContent";
        public static readonly XName Choice = mc + "Choice";
        public static readonly XName Fallback = mc + "Fallback";
        public static readonly XName Ignorable = mc + "Ignorable";
        public static readonly XName PreserveAttributes = mc + "PreserveAttributes";
    }
}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
