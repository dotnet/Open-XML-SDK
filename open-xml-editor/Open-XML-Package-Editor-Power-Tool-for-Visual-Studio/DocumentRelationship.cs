/****************************************************************************

    DocumentRelationship.cs

    Wrapper class for Relationship.

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
using System.IO.Packaging;
using System.ComponentModel;

namespace Microsoft.OpenXMLEditor
{
    class DocumentRelationship
    {
        private PackageRelationship rel;

        public DocumentRelationship(PackageRelationship rel)
        {
            this.rel = rel;
        }

        [Category("Misc")]
        [DisplayName("ID")]
        [Description("The ID of this relationship.")]
        public string ID
        {
            get
            {
                return rel.Id;
            }
        }

        [Category("Misc")]
        [DisplayName("Type")]
        [Description("The qualified type name of this relationship.")]
        public string Type
        {
            get
            {
                return rel.RelationshipType;
            }
        }

        [Category("Misc")]
        [DisplayName("Source")]
        [Description("The source URI of this relationship.")]
        public string Source
        {
            get
            {
                return rel.SourceUri.ToString();
            }
        }

        [Category("Misc")]
        [DisplayName("Target")]
        [Description("The target URI of this relationship.")]
        public string Target
        {
            get
            {
                return rel.TargetUri.ToString();
            }
        }

        [Category("Misc")]
        [DisplayName("Target Mode")]
        [Description("The target mode of this relationship.")]
        public string TargetMode
        {
            get
            {
                return rel.TargetMode.ToString();
            }
        }
    }
}
