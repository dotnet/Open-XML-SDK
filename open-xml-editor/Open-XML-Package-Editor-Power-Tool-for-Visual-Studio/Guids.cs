/****************************************************************************

    Guids.cs

    GUIDs for VS extension package components.

------------------------------------------------------------- LICENSE BEGINS HERE--------------------------------------------------------------------------------------

Copyright (c) Microsoft Corporation
All rights reserved. 

Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with the License. You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0 

THIS CODE IS PROVIDED ON AN  *AS IS* BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING WITHOUT LIMITATION ANY IMPLIED WARRANTIES OR CONDITIONS OF TITLE, FITNESS FOR A PARTICULAR PURPOSE, MERCHANTABLITY OR NON-INFRINGEMENT. 

See the Apache Version 2.0 License for specific language governing permissions and limitations under the License.
-------------------------------------------------------------- LICENSE ENDS HERE -----------------------------------------------------------------------------------------
****************************************************************************/
using System;

namespace Microsoft.OpenXMLEditor
{
    static class GuidList
    {
        public const string guidOpenXMLEditorPkgString = "77809599-42b8-42aa-8c95-f41cf5ca4916";
        public const string guidOpenXMLEditorCmdSetString = "28b472be-003c-4c46-99e0-7b9654bd84e9";
        public const string guidEditorFactoryString = "40212433-d144-4e5e-a730-089a5b843985";
        public const string guidPartEditorFactoryString = "602f2e8b-7bf0-4bb2-b484-eee8bcfae7a3";

        public static readonly Guid guidOpenXMLEditorPkg = new Guid(guidOpenXMLEditorPkgString);
        public static readonly Guid guidOpenXMLEditorCmdSet = new Guid(guidOpenXMLEditorCmdSetString);
        public static readonly Guid guidEditorFactory = new Guid(guidEditorFactoryString);
        public static readonly Guid guidPartEditorFactory = new Guid(guidPartEditorFactoryString);
    };
}