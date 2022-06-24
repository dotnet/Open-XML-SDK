// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.ComponentModel;
using System.Reflection;
using System.Xml;

namespace DocumentFormat.OpenXml.Office2021.Word.CommentsExt
{
    public partial class CommentExtensible
    {
        /// <summary>
        /// Gets or sets the <see cref="CommentExtensibleExtensionList"/> value. It is only available for backwards compatibility
        /// until the next major version change. The <see cref="CommentExtensibleExtensionList"/> property should be used instead.
        /// </summary>
        [Obsolete("Please use the property 'CommentExtensibleExtensionList' as this property will be removed in a future version")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public ExtensionList? ExtensionList
        {
            get
            {
                return (ExtensionList)CopyFromCompositeElement((OpenXmlCompositeElement)CommentExtensibleExtensionList, typeof(ExtensionList));
            }

            set
            {
                CopyToCompositeElement((OpenXmlCompositeElement)value, (OpenXmlCompositeElement)CommentExtensibleExtensionList);
            }
        }
    }
}
