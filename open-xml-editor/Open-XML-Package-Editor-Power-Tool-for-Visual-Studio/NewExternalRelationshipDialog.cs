/****************************************************************************

    NewExternalRelationshipDialog.cs

    Dialog for creating a new external relationship.

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
    public partial class NewExternalRelationshipDialog : Form
    {
        public NewExternalRelationshipDialog(Microsoft.OpenXMLEditor.PackageEditorPane main)
        {
            InitializeComponent();

            this.comboBox1.Items.Clear();
            foreach (string relType in KnownPackageInfo.GetRelationshipTypes().Keys)
            {
                this.comboBox1.Items.Add(relType);
            }
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
                return this.comboBox1.Text;
            }
        }

        public string Target
        {
            get
            {
                return textBoxTarget.Text;
            }
        }
    }
}