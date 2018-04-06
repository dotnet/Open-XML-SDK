// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

/**********************************************************
 * Define data struct for schema constraint binary database
 **********************************************************/

using System.Diagnostics;

using SdbIndex = System.UInt16;

namespace DocumentFormat.OpenXml.Validation.Schema
{
    internal static class XsdAnyPrefidefinedValue
    {
        /// <summary>
        /// ##any - Elements from any namespace can be present.
        /// </summary>
        public const ushort Any = 0;

        /// <summary>
        /// ##other - Elements from any namespace that is not the target namespace of the parent element containing this element can be present.
        /// </summary>
        public const ushort Other = 1;

        /// <summary>
        /// #local - Elements that are not qualified with a namespace can be present.
        /// </summary>
        public const ushort Local = 2;

        /// <summary>
        /// ##targetNamespace - Elements from the target namespace of the parent element containing this element can be present.
        /// </summary>
        public const ushort TargetNamespace = 3;

        /// <summary>
        /// Get corresponding namespace string for Any, Other, Local and TargetNamespace.
        /// </summary>
        /// <param name="value">One of the Any, Other, Local and TargetNamespace.</param>
        /// <returns>##any, ##other, ##local or ##targetNamespace.</returns>
        internal static string GetNamespaceString(ushort value)
        {
            switch (value)
            {
                case XsdAnyPrefidefinedValue.Any:
                    // Elements from any namespace can be present.
                    return "##any";

                case XsdAnyPrefidefinedValue.Local:
                    // Elements that are not qualified with a namespace can be present.
                    return "##local";

                case XsdAnyPrefidefinedValue.Other:
                    // Elements from any namespace that is not the target namespace of the parent element containing this element can be present.
                    return "##other";

                case XsdAnyPrefidefinedValue.TargetNamespace:
                    return "##targetNamespace";

                default:
                    Debug.Assert(false);
                    return string.Empty;
            }
        }
    }
}
