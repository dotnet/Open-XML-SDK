/****************************************************************************

    PartNameEditBox.cs

    Part name edit box class.

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
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Microsoft.OpenXMLEditor
{
    public partial class PartNameEditBox : TextBox
    {
        public PartNameEditBox()
        {
            InitializeComponent();
        }

        protected override void OnTextChanged(EventArgs e)
        {
             base.OnTextChanged(e);

            int pos = this.Text.IndexOfAny(illegalChars);
            if (pos >= 0)
            {
                int start = this.SelectionStart;

                while (pos >= 0)
                {
                    this.Text = this.Text.Remove(pos, 1);
                    pos = this.Text.IndexOfAny(illegalChars);
                }

                this.SelectionStart = start;

                Point pt = new Point(0, this.Height);

                // work-around for a tooltip bug where stem appears below the baloon on first show
                if (toolTip.Tag == null)
                {
                    toolTip.Show("", this, pt, 1);
                    toolTip.Tag = true;
                }

                toolTip.Show(
                    "A name may not contain any of the following characters:\n\t\\ / : * ? \" < > |",
                    this, pt, 5000);
            }
        }

        private char[] illegalChars = new char[]
        {
            '\\', '/', ':', '*', '?', '\"', '<', '>', '|'
        };
    }
}
