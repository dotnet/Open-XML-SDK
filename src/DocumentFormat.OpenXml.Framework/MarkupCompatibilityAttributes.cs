// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Defines the Markup Compatibility Attributes.
    /// </summary>
    public class MarkupCompatibilityAttributes : IEquatable<MarkupCompatibilityAttributes>
    {
        /// <summary>
        /// Gets or sets a whitespace-delimited list of prefixes, where each
        ///  prefix identifies an ignorable namespace.
        /// </summary>
        public StringValue? Ignorable { get; set; }

        /// <summary>
        /// Gets or sets a whitespace-delimited list of element-qualified names
        ///  that identify the expanded names of elements. The content of the
        ///  elements shall be processed, even if the elements themselves are
        ///  ignored.
        /// </summary>
        public StringValue? ProcessContent { get; set; }

        /// <summary>
        /// Gets or sets a whitespace-delimited list of element qualified names
        ///  that identify the expanded names of elements. The elements are suggested
        ///  by a markup producer for preservation by markup editors, even if
        ///  the elements themselves are ignored.
        /// </summary>
        public StringValue? PreserveElements { get; set; }

        /// <summary>
        /// Gets or sets a whitespace-delimited list of attribute qualified names
        ///  that identify expanded names of attributes. The attributes were
        ///  suggested by a markup producer for preservation by markup editors.
        /// </summary>
        public StringValue? PreserveAttributes { get; set; }

        /// <summary>
        /// Gets or sets a whitespace-delimited list of prefixes that identify
        ///  a set of namespace names.
        /// </summary>
        public StringValue? MustUnderstand { get; set; }

        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            return this.Equals(obj as MarkupCompatibilityAttributes);
        }

        /// <inheritdoc/>
        public bool Equals(MarkupCompatibilityAttributes? other)
        {
            if (other == null)
            {
                return false;
            }

            if (object.ReferenceEquals(this, other))
            {
                return true;
            }

            return (this.Ignorable == null == (other.Ignorable == null)) &&
                (this.Ignorable == null || this.Ignorable.Equals(other.Ignorable)) &&
                (this.ProcessContent == null == (other.ProcessContent == null)) &&
                (this.ProcessContent == null || this.ProcessContent.Equals(other.ProcessContent)) &&
                (this.PreserveElements == null == (other.PreserveElements == null)) &&
                (this.PreserveElements == null || this.PreserveElements.Equals(other.PreserveElements)) &&
                (this.PreserveAttributes == null == (other.PreserveAttributes == null)) &&
                (this.PreserveAttributes == null || this.PreserveAttributes.Equals(other.PreserveAttributes)) &&
                (this.MustUnderstand == null == (other.MustUnderstand == null)) &&
                (this.MustUnderstand == null || this.MustUnderstand.Equals(other.MustUnderstand));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            var hc = default(FrameworkHashCode);

            hc.Add(this.Ignorable);
            hc.Add(this.ProcessContent);
            hc.Add(this.PreserveElements);
            hc.Add(this.PreserveAttributes);
            hc.Add(this.MustUnderstand);

            return hc.GetHash;
        }
    }
}
