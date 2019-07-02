// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Diagnostics;

namespace DocumentFormat.OpenXml.Validation.Schema
{
    internal static class XsdAnyExtensions
    {
        /// <summary>
        /// Get corresponding namespace string for Any, Other, Local and TargetNamespace.
        /// </summary>
        /// <param name="value">One of the Any, Other, Local and TargetNamespace.</param>
        /// <returns>##any, ##other, ##local or ##targetNamespace.</returns>
        public static string GetNamespaceString(this XsdAny value)
        {
            switch (value)
            {
                case XsdAny.Any:
                    // Elements from any namespace can be present.
                    return "##any";

                case XsdAny.Local:
                    // Elements that are not qualified with a namespace can be present.
                    return "##local";

                case XsdAny.Other:
                    // Elements from any namespace that is not the target namespace of the parent element containing this element can be present.
                    return "##other";

                case XsdAny.TargetNamespace:
                    return "##targetNamespace";

                default:
                    Debug.Assert(false);
                    return string.Empty;
            }
        }
    }
}
