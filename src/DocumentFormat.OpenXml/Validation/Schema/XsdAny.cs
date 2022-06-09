// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Validation.Schema
{
    internal enum XsdAny
    {
        /// <summary>
        /// ##any - Elements from any namespace can be present.
        /// </summary>
        Any = 0,

        /// <summary>
        /// ##other - Elements from any namespace that is not the target namespace of the parent element containing this element can be present.
        /// </summary>
        Other = 1,

        /// <summary>
        /// #local - Elements that are not qualified with a namespace can be present.
        /// </summary>
        Local = 2,

        /// <summary>
        /// ##targetNamespace - Elements from the target namespace of the parent element containing this element can be present.
        /// </summary>
        TargetNamespace = 3,
    }
}
