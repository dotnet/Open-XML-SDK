// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Validation.Schema;
using DocumentFormat.OpenXml.Validation.Semantic;
using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.TableColumnExtensionList" /> <c>&lt;x:extLst></c></description></item>
    /// </list>
    /// </remark>
    public partial class TableColumn : OpenXmlCompositeElement
    {
        /// <summary>
        /// <para>Gets or sets the legacy ExtensionList property.</para>
        /// <para>Future Extensibility.</para>
        /// <para>Represents the following element tag in the schema: x:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        [ObsoleteAttribute("This property is obsolete and will be removed in a future version. Use the TableColumnExtension property instead.", false)]
        public ExtensionList? ExtensionList
        {
            get => TableColumnExtensionList;
            set => TableColumnExtensionList = (TableColumnExtensionList?)value;
        }

        /// <summary>Gets or sets the table column extension list.</summary>
        /// <value>The table column extension list.</value>
        public TableColumnExtensionList? TableColumnExtensionList
        {
            get => GetElement<TableColumnExtensionList>();
            set => SetElement((TableColumnExtensionList?)value);
        }

        /// <summary>
        /// Adds the specified element to the element if it is a known child. This adds the element in the correct location according to the schema.
        /// </summary>
        /// <param name="newChild">The OpenXmlElement element to append.</param>
        /// <param name="throwOnError">A flag to indicate if the method should throw if the child could not be added.</param>
        /// <returns>Success if the element was added, otherwise <c>false</c>.</returns>
        public bool AddChild(ExtensionList newChild, bool throwOnError = true)
        {
            if (newChild is null)
            {
                if (throwOnError)
                {
                    throw new ArgumentNullException(nameof(newChild));
                }

                return false;
            }

            TableColumnExtensionList tce = new TableColumnExtensionList(newChild);
            var wasAdded = Metadata.Particle.Set(this, tce, tce.GetType());


            if (throwOnError && !wasAdded)
            {
                throw new InvalidOperationException(ExceptionMessages.ElementIsNotChild);
            }

            return wasAdded;
        }
    }
}
