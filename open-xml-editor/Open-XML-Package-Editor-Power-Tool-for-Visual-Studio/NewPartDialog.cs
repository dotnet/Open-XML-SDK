/****************************************************************************

    NewPartDialog.cs

    Dialog for creating a new part.

------------------------------------------------------------- LICENSE BEGINS HERE--------------------------------------------------------------------------------------

Copyright (c) Microsoft Corporation
All rights reserved. 

Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with the License. You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0 

THIS CODE IS PROVIDED ON AN  *AS IS* BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING WITHOUT LIMITATION ANY IMPLIED WARRANTIES OR CONDITIONS OF TITLE, FITNESS FOR A PARTICULAR PURPOSE, MERCHANTABLITY OR NON-INFRINGEMENT. 

See the Apache Version 2.0 License for specific language governing permissions and limitations under the License.
-------------------------------------------------------------- LICENSE ENDS HERE -----------------------------------------------------------------------------------------
****************************************************************************/
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Microsoft.OpenXMLEditor
{
    public partial class NewPartDialog : Form
    {
        public NewPartDialog(bool disableImport)
        {
            InitializeComponent();

            this.comboBoxContentType.Items.Clear();

            ContentTypeInfo[] types = KnownPackageInfo.GetContentTypes();
            foreach (ContentTypeInfo cti in types)
            {
                this.comboBoxContentType.Items.Add(cti.m_mime);
            }

            if (disableImport)
            {
                this.labelImport.Enabled = false;
                this.textBoxExternalFilename.Enabled = false;
                this.buttonBrowse.Enabled = false;
            }
        }

        public string ImportFile
        {
            get
            {
                return textBoxExternalFilename.Text;
            }
        }

        public string PartName
        {
            get
            {
                return textBoxName.Text;
            }
        }

        public string ContentType
        {
            get
            {
                return this.comboBoxContentType.Text;
            }
        }

        public System.IO.Packaging.CompressionOption Compress
        {
            get
            {
                return (System.IO.Packaging.CompressionOption)this.comboBoxCompression.SelectedItem;
            }
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            ArrayList imageTypes = new ArrayList();
            imageTypes.Add(new string[] { "*.jpg;*.jpeg", "JPEG File Interchange Format" });
            imageTypes.Add(new string[] { "*.gif", "Graphics Interchange Format" });
            imageTypes.Add(new string[] { "*.png", "Portable Network Graphics" });
            imageTypes.Add(new string[] { "*.bmp", "Windows Bitmap" });
            imageTypes.Add(new string[] { "*.ico", "Windows Icon" });
            imageTypes.Add(new string[] { "*.emf", "Windows Enhanced Metafile" });
            imageTypes.Add(new string[] { "*.wmf", "Windows Metafile" });
            imageTypes.Add(new string[] { "*.emz", "Compressed Windows Enhanced Metafile" });
            imageTypes.Add(new string[] { "*.wmz", "Compressed Windows Metafile" });
            imageTypes.Add(new string[] { "*.pcz", "Compressed Macintosh PICT" });
            imageTypes.Add(new string[] { "*.tif;*.tiff", "Tag Image File Format" });
            imageTypes.Add(new string[] { "*.xbm", "X Bitmap Graphic" });
            imageTypes.Add(new string[] { "*.pcx", "PC Paintbrush Bitmap Graphic" });

            string filter = "", allFilters = "";
            foreach (string[] imageType in imageTypes)
            {
                if (filter.Length > 0)
                    filter += "|";
                filter += imageType[1] + " (" + imageType[0] + ")|" + imageType[0];

                if (allFilters.Length > 0)
                    allFilters += ";";
                allFilters += imageType[0];
            }
            openFileDialog.Filter = "All Files (*.*)|*.*|All Pictures (" + allFilters + ")|" + allFilters + "|" + filter;
            openFileDialog.FilterIndex = 2;
            if (openFileDialog.ShowDialog(this) != DialogResult.OK || string.IsNullOrEmpty(openFileDialog.FileName))
                return;

            textBoxExternalFilename.Text = openFileDialog.FileName;

            textBoxName.Text = System.IO.Path.GetFileName(textBoxExternalFilename.Text).ToLower();

            string ext = System.IO.Path.GetExtension(textBoxName.Text);
            if (ext == ".jpg")
                ext = ".jpeg";
            else if (ext == ".tif")
                ext = ".tiff";

            List<ContentTypeInfo> contentTypes = KnownPackageInfo.GetContentTypesForExt(ext);
            if (contentTypes != null && contentTypes.Count > 0)
            {
                comboBoxContentType.Text = contentTypes[0].m_mime;

                comboBoxCompression.SelectedItem = contentTypes[0].m_comp == Comp.CD ? System.IO.Packaging.CompressionOption.SuperFast : System.IO.Packaging.CompressionOption.NotCompressed;
            }
        }

        private void NewPartDialog_Load(object sender, EventArgs e)
        {
            Array names = System.Enum.GetValues(typeof(System.IO.Packaging.CompressionOption));
            foreach (System.IO.Packaging.CompressionOption name in names)
                comboBoxCompression.Items.Add(name);
            comboBoxCompression.SelectedItem = System.IO.Packaging.CompressionOption.SuperFast;
        }
    }
}