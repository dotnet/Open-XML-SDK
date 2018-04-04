// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#pragma warning disable SA1623

using System;

namespace DocumentFormat.OpenXml.Office2013.WebExtension
{
    public partial class WebExtension
    {
        /// <summary>
        /// <para> frozen.</para>
        /// <para>Represents the following attribute in the schema: frozen </para>
        /// This property will be removed in a future version and should be replaced with <see cref="Frozen"/>. It is only available
        /// for backwards compatibility until the next major version change.
        /// </summary>
        [SchemaAttr(0, "frozen")]
        [Obsolete("Please use the property 'Frozen' as this property will be removed in a future version")]
        public BooleanValue Fronzen
        {
            get => Frozen;
            set => Frozen = value;
        }
    }
}
