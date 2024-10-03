/****************************************************************************

    NewInternalRelationshipDialog.cs

    Dialog for creating a new internal relationship.

------------------------------------------------------------- LICENSE BEGINS HERE--------------------------------------------------------------------------------------

Copyright (c) Microsoft Corporation
All rights reserved. 

Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with the License. You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0 

THIS CODE IS PROVIDED ON AN  *AS IS* BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING WITHOUT LIMITATION ANY IMPLIED WARRANTIES OR CONDITIONS OF TITLE, FITNESS FOR A PARTICULAR PURPOSE, MERCHANTABLITY OR NON-INFRINGEMENT. 

See the Apache Version 2.0 License for specific language governing permissions and limitations under the License.
-------------------------------------------------------------- LICENSE ENDS HERE -----------------------------------------------------------------------------------------
****************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Microsoft.OpenXMLEditor
{
    // [CLSCompliant(false)]
    public partial class NewInternalRelationshipDialog : Form
    {
        public NewInternalRelationshipDialog(Microsoft.OpenXMLEditor.PackageEditorPane main)
        {
            InitializeComponent();

            treeView.ImageList = main.Images;
            treeView.ImageIndex = 1;
            treeView.SelectedImageIndex = 2;
            main.PopulateTree(treeView, false);
        }

        private void NewInternalRelationshipDialog_Load(object sender, EventArgs e)
        {
            this.comboBoxRelType.Items.Clear();
            foreach (string relType in KnownPackageInfo.GetRelationshipTypes().Keys)
                this.comboBoxRelType.Items.Add(relType);

            this.comboBoxKind.Items.Clear();
            comboBoxKind.Items.Add(System.UriKind.Absolute);
            comboBoxKind.Items.Add(System.UriKind.Relative);
            comboBoxKind.SelectedItem = System.UriKind.Relative;
        }

        public string Id
        {
            get
            {
                return textBoxName.Text;
            }
        }

        public string RelType
        {
            get
            {
                return this.comboBoxRelType.Text;
            }
        }

        public DocumentPart Target
        {
            get
            {
                DocumentPart docPart = (DocumentPart)treeView.SelectedNode.Tag;
                return docPart;
            }
        }

        public UriKind TargetKind
        {
            get
            {
                return (UriKind)this.comboBoxKind.SelectedItem;
            }
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (!(e.Node.Tag is DocumentPart))
                return;

            DocumentPart docPart = e.Node.Tag as DocumentPart;

            this.comboBoxRelType.Items.Clear();

            List<PartInfo> list = KnownPackageInfo.GetPartTypesForContentType(docPart.ContentType);
            if (list == null || list.Count == 0)
            {
                foreach (string relType in KnownPackageInfo.GetRelationshipTypes().Keys)
                    this.comboBoxRelType.Items.Add(relType);
                return;
            }

            foreach (PartInfo partInfo in list)
                this.comboBoxRelType.Items.Add(partInfo.m_relType);
            comboBoxRelType.Text = list[0].m_relType;
        }
    }
}