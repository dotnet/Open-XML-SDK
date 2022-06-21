// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace DocumentFormat.OpenXml.Packaging
{
    public partial class PresentationPart
    {
        /// <summary>
        /// Gets the commentParts of the PresentationPart
        /// </summary>
        [Obsolete("This is not a valid Office relationship. Please use the property 'SlidePart.commentParts' as this part always returns null and will be removed in a future version.")]
        [EditorBrowsable(EditorBrowsableState.Never)]
#pragma warning disable SA1300 // Element should begin with upper-case letter
        public static IEnumerable<PowerPointCommentPart>? commentParts => null;
#pragma warning restore SA1300 // Element should begin with upper-case letter
    }
}
