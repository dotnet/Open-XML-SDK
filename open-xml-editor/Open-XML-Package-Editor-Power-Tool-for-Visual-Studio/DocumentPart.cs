/****************************************************************************

    DocumentPart.cs

    Wrapper class for Part.

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
using System.Drawing;
using System.ComponentModel;

namespace Microsoft.OpenXMLEditor
{
    public class DocumentPart
    {
        private PackagePart part;
        private Encoding encoding;

        public DocumentPart(PackagePart part)
        {
            this.part = part;
            encoding = Encoding.UTF8;
        }

        [Category("Misc")]
        [DisplayName("Part Name")]
        [Description("The name of this part.")]
        public string Name
        {
            get
            {
                string name = part.Uri.ToString();
                return System.IO.Path.GetFileName(name);
            }
        }

        [Category("Misc")]
        [DisplayName("Full Path")]
        [Description("The full path name of this part.")]
        public string Path
        {
            get
            {
                return part.Uri.ToString();
            }
        }

        [Category("Misc")]
        [DisplayName("Content Type")]
        [Description("The content type of this part.")]
        public string ContentType
        {
            get
            {
                return part.ContentType;
            }
        }

        /* We have to open the stream before we know what the encoding is.
         * The user can always open the part to learn its encoding type.
        [Category("Misc")]
        [DisplayName("Encoding")]
        [Description("The encoding type of this part.")]
        public string Encoding
        {
            get
            {
                return encoding.EncodingName;
            }
        }
        */

        [Category("Misc")]
        [DisplayName("Compression")]
        [Description("The compression option used by this part.")]
        public string CompressionOption
        {
            get
            {
                return part.CompressionOption.ToString();
            }
        }

        [Browsable(false)]
        public string Text
        {
            get
            {
                // Read the stream
                Stream stream = part.GetStream();
                StreamReader reader = new StreamReader(stream);
                encoding = reader.CurrentEncoding;
                System.Diagnostics.Debug.WriteLine(encoding.EncodingName);
                if (reader == null)
                    return null;
                return reader.ReadToEnd();
            }
            set
            {
                // Write to stream
                Stream stream = part.GetStream(System.IO.FileMode.Open, System.IO.FileAccess.ReadWrite);
                stream.Seek(0, SeekOrigin.Begin);
                StreamWriter writer = new StreamWriter(stream, encoding);
                writer.Write(value);
                writer.Flush();
                stream.SetLength(stream.Position);
                stream.Close();
            }
        }

        [Browsable(false)]
        public Image Image
        {
            get
            {
                // Read the stream
                Stream stream = part.GetStream();
                Image image = Image.FromStream(stream);
                stream.Close();
                return image;
            }
        }

        [Browsable(false)]
        public PackagePart Part
        {
            get
            {
                return part;
            }
        }
    }
}
