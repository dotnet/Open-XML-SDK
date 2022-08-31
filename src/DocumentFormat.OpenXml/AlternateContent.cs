// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Represents the mc:AlternateContent element of markup
    /// compatibility.
    /// </summary>
    public class AlternateContent : OpenXmlCompositeElement
    {
        internal static readonly OpenXmlQualifiedName InternalQName = new(@"http://schemas.openxmlformats.org/markup-compatibility/2006", "AlternateContent");

        /// <summary>
        /// Initializes a new instance of the AlternateContent
        /// class.
        /// </summary>
        public AlternateContent()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the AlternateContent
        /// class by using the supplied IEnumerable elements.
        /// </summary>
        /// <param name="childElements">
        /// Represents all child elements.
        /// </param>
        public AlternateContent(IEnumerable<OpenXmlElement> childElements)
            : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AlternateContent
        /// class by using the supplied OpenXmlElement elements.
        /// </summary>
        /// <param name="childElements">
        /// Represents all child elements.
        /// </param>
        public AlternateContent(params OpenXmlElement[] childElements)
            : base(childElements)
        {
        }

        /// <param name="outerXml">The outer XML of the element.
        /// </param>
        /// <summary>
        /// Initializes a new instance of the AlternateContent
        /// class by using the supplied string.
        /// </summary>
        public AlternateContent(string outerXml)
            : base(outerXml)
        {
        }

        /// <summary>
        /// Gets a value that represents the markup compatibility
        /// namespace.
        /// </summary>
        public static string MarkupCompatibilityNamespace => InternalQName.Namespace.Uri;

        /// <summary>
        /// Gets a value that represents the markup compatibility
        /// namespace ID.
        /// </summary>
        [Obsolete("NamespaceId will be removed in later releases.")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static byte MarkupCompatibilityNamespaceId => 0;

        /// <summary>
        /// Gets a value that represents the tag name of the
        /// AlternateContent element.
        /// </summary>
        public static string TagName => InternalQName.Name;

        /// <inheritdoc/>
        public override string LocalName => InternalQName.Name;

        /// <summary>
        /// Appends a new child of type T:DocumentFormat.OpenXml.AlternateContentChoice
        ///  to the current element.
        /// </summary>
        /// <returns>
        /// </returns>
        public AlternateContentChoice AppendNewAlternateContentChoice()
        {
            AlternateContentChoice child = new AlternateContentChoice();
            AppendChild(child);
            return child;
        }

        /// <summary>
        /// Appends a new child of type T:DocumentFormat.OpenXml.AlternateContentFallback
        ///  to the current element.
        /// </summary>
        /// <returns>
        /// </returns>
        public AlternateContentFallback AppendNewAlternateContentFallback()
        {
            AlternateContentFallback child = new AlternateContentFallback();
            AppendChild(child);
            return child;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep)
        {
            return CloneImp<AlternateContent>(deep);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);

            builder.SetSchema(InternalQName);

            builder.AddChild<AlternateContentChoice>();
            builder.AddChild<AlternateContentFallback>();
        }
    }
}
