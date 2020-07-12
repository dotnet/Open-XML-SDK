// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.ComponentModel;

namespace DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing
{
    /// <summary>
    /// <para>Defines the IdxXsdunsignedInt Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:idx.</para>
    /// </summary>
    [Obsolete("Please use UnsignedIntegerType as this type will be removed in a future version")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public partial class IdxXsdunsignedInt : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the IdxXsdunsignedInt class.
        /// </summary>
        public IdxXsdunsignedInt() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the IdxXsdunsignedInt class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public IdxXsdunsignedInt(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new UInt32Value { InnerText = text };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<IdxXsdunsignedInt>(deep);
    }
}
