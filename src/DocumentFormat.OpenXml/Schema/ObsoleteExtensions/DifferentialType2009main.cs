// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Spreadsheet;
using System;

namespace DocumentFormat.OpenXml.Office2010.Excel
{
    public partial class DifferentialType : OpenXmlCompositeElement
    {
        /// <summary>
        /// <para>Gets or sets the legacy ExtensionList property.</para>
        /// <para>Future Extensibility.</para>
        /// <para>Represents the following element tag in the schema: x:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        [ObsoleteAttribute("This property is obsolete and will be removed in a future version. Use the DxfExtensionList property instead.", false)]
        public Spreadsheet.ExtensionList? ExtensionList
        {
            get => DxfExtensionList;
            set
            {
                string outerXml = value is null ? throw new ArgumentNullException(nameof(value)) : value.OuterXml;
                DxfExtensionList = new DxfExtensionList(outerXml);
            }
        }

        /// <summary>Gets or sets the table column extension list.</summary>
        /// <value>The table column extension list.</value>
        public DxfExtensionList? DxfExtensionList
        {
            get => GetElement<DxfExtensionList>();
            set => SetElement((DxfExtensionList?)value);
        }

        /// <summary>
        /// Adds an ExtensionList child element to this element. This adds the element in the correct location according to the schema.
        /// </summary>
        /// <param name="newChild">The ExtensionList element to append.</param>
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

            DxfExtensionList tce = new DxfExtensionList(newChild);
            var wasAdded = Metadata.Particle.Set(this, tce, tce.GetType());

            if (throwOnError && !wasAdded)
            {
                throw new InvalidOperationException(ExceptionMessages.ElementIsNotChild);
            }

            return wasAdded;
        }
    }
}
