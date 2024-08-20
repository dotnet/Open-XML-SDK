/****************************************************************************

    DocumentPackage.cs

    Wrapper class for a Package, its storage, and its meta data.

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
using System.Text;
using System.IO;
using System.IO.Packaging;
using System.ComponentModel;
using System.Diagnostics;

namespace Microsoft.OpenXMLEditor
{
    // [CLSCompliant(false)]
    public class DocumentPackage
    {
        private string untitledName;
        private string filePath;
        private MemoryStream memStream;
        private Package package;
        private bool dirty;

        private Dictionary<string, DocumentPart> docParts;

        public void Close()
        {
            if (package == null)
                return;
            docParts.Clear();
            package.Close();
            package = null;
            memStream.Close();
            memStream = null;
            filePath = null;
            dirty = false;
        }

        public bool Open(string path)
        {
            try
            {
                FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                byte[] buffer = new byte[fs.Length];
                fs.Read(buffer, 0, (int)fs.Length);
                memStream = new MemoryStream();
                memStream.Write(buffer, 0, (int)fs.Length);
                buffer = null;
                fs.Close();

                package = Package.Open(memStream, FileMode.Open, FileAccess.ReadWrite);

                docParts = new Dictionary<string, DocumentPart>();
                PackagePartCollection parts = package.GetParts();
                foreach (PackagePart part in parts)
                {
                    DocumentPart docPart = new DocumentPart(part);
                    docParts.Add(part.Uri.ToString(), docPart);
                }

                filePath = path;
                dirty = false;
                                
                return true;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                return false;
            }
        }

        public bool Save()
        {
            if (string.IsNullOrEmpty(filePath) || IsUntitled)
                return false;
            return SaveAs(filePath);
        }

        public bool SaveAs(string path)
        {
            if (SaveCopyAs(path))
            {
                filePath = path;
                untitledName = null;
                return true;
            }
            return false;
        }

        public bool SaveCopyAs(string path)
        {
            try
            {
                package.Flush();
                memStream.Flush();
                FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
                fs.Seek(0, SeekOrigin.Begin);
                fs.SetLength(0);
                memStream.WriteTo(fs);
                fs.Close();
                dirty = false;
                return true;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                return false;
            }
        }

        public void ReloadFromMemory()
        {
            Debug.Assert(memStream != null);

            this.docParts = null;
            package.Close();
            package = null;
            package = Package.Open(memStream, FileMode.Open, FileAccess.ReadWrite);

            docParts = new Dictionary<string, DocumentPart>();
            PackagePartCollection parts = package.GetParts();
            foreach (PackagePart part in parts)
            {
                DocumentPart docPart = new DocumentPart(part);
                docParts.Add(part.Uri.ToString(), docPart);
            }
        }

        [Browsable(false)]
        public string UntitledName
        {
            get
            {
                return untitledName;
            }
            set
            {
                untitledName = value;
            }
        }

        [Browsable(false)]
        public bool IsUntitled
        {
            get
            {
                return !string.IsNullOrEmpty(untitledName);
            }
        }

        [Category("Misc")]
        [DisplayName("Full Path")]
        [Description("Location of the file.")]
        public string _FilePath
        {
            get
            {
                if (IsUntitled)
                    return null;
                return filePath;
            }
        }

        [Browsable(false)]
        public string FilePath
        {
            get
            {
                return filePath;
            }
        }

        [Category("Misc")]
        [DisplayName("File Name")]
        [Description("Name of the file.")]
        public string FileName
        {
            get
            {
                if (IsUntitled)
                    return untitledName;
                return System.IO.Path.GetFileName(filePath);
            }
        }

        [Browsable(false)]
        public Dictionary<string, DocumentPart> DocParts
        {
            get
            {
                return docParts;
            }
        }

        [Browsable(false)]
        public Package Package
        {
            get
            {
                return package;
            }
        }

        [Browsable(false)]
        public bool IsDirty
        {
            get
            {
                return dirty;
            }
            set
            {
                dirty = value;
            }
        }

        [Category("Document Properties")]
        [DisplayName("Category")]
        [Description("Category of the document.")]
        public string Category
        {
            get
            {
                return package.PackageProperties.Category;
            }
        }

        [Category("Document Properties")]
        [DisplayName("Content Status")]
        [Description("Content status of the document.")]
        public string ContentStatus
        {
            get
            {
                return package.PackageProperties.ContentStatus;
            }
        }

        [Category("Document Properties")]
        [DisplayName("Content Type")]
        [Description("Content type of the document.")]
        public string ContentType
        {
            get
            {
                return package.PackageProperties.ContentType;
            }
        }

        [Category("Document Properties")]
        [DisplayName("Created")]
        [Description("Date and time the document was created.")]
        public DateTime? Created
        {
            get
            {
                return package.PackageProperties.Created;
            }
        }

        [Category("Document Properties")]
        [DisplayName("Creator")]
        [Description("Creator of the document.")]
        public string Creator
        {
            get
            {
                return package.PackageProperties.Creator;
            }
        }

        [Category("Document Properties")]
        [DisplayName("Description")]
        [Description("Description of the document.")]
        public string Description
        {
            get
            {
                return package.PackageProperties.Description;
            }
        }

        [Category("Document Properties")]
        [DisplayName("Identifier")]
        [Description("Identifier of the document.")]
        public string Identifier
        {
            get
            {
                return package.PackageProperties.Identifier;
            }
        }

        [Category("Document Properties")]
        [DisplayName("Keywords")]
        [Description("Keywords of the document.")]
        public string Keywords
        {
            get
            {
                return package.PackageProperties.Keywords;
            }
        }

        [Category("Document Properties")]
        [DisplayName("Language")]
        [Description("Language of the document.")]
        public string Language
        {
            get
            {
                return package.PackageProperties.Language;
            }
        }

        [Category("Document Properties")]
        [DisplayName("Last Modified By")]
        [Description("Author of the last modification to the document.")]
        public string LastModifiedBy
        {
            get
            {
                return package.PackageProperties.LastModifiedBy;
            }
        }

        [Category("Document Properties")]
        [DisplayName("Last Printed")]
        [Description("Date and time the document was last printed.")]
        public DateTime? LastPrinted
        {
            get
            {
                return package.PackageProperties.LastPrinted;
            }
        }

        [Category("Document Properties")]
        [DisplayName("Modified")]
        [Description("Date and time the document was last modified.")]
        public DateTime? Modified
        {
            get
            {
                return package.PackageProperties.Modified;
            }
        }

        [Category("Document Properties")]
        [DisplayName("Revision")]
        [Description("Revision number of the document.")]
        public string Revision
        {
            get
            {
                return package.PackageProperties.Revision;
            }
        }

        [Category("Document Properties")]
        [DisplayName("Subject")]
        [Description("Subject of the document.")]
        public string Subject
        {
            get
            {
                return package.PackageProperties.Subject;
            }
        }

        [Category("Document Properties")]
        [DisplayName("Title")]
        [Description("Title of the document.")]
        public string Title
        {
            get
            {
                return package.PackageProperties.Title;
            }
        }

        [Category("Document Properties")]
        [DisplayName("Version")]
        [Description("Version of the document.")]
        public string Version
        {
            get
            {
                return package.PackageProperties.Version;
            }
        }
    }
}
