/****************************************************************************

    PartEditorFactory.cs

    A factory class for creating XML editors on Package parts.

------------------------------------------------------------- LICENSE BEGINS HERE--------------------------------------------------------------------------------------

Copyright (c) Microsoft Corporation
All rights reserved. 

Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with the License. You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0 

THIS CODE IS PROVIDED ON AN  *AS IS* BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING WITHOUT LIMITATION ANY IMPLIED WARRANTIES OR CONDITIONS OF TITLE, FITNESS FOR A PARTICULAR PURPOSE, MERCHANTABLITY OR NON-INFRINGEMENT. 

See the Apache Version 2.0 License for specific language governing permissions and limitations under the License.
-------------------------------------------------------------- LICENSE ENDS HERE -----------------------------------------------------------------------------------------
****************************************************************************/
using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio;
using Microsoft.VisualStudio.Shell.Interop;
using Microsoft.VisualStudio.OLE.Interop;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.TextManager.Interop;

using IOleServiceProvider = Microsoft.VisualStudio.OLE.Interop.IServiceProvider;

namespace Microsoft.OpenXMLEditor
{
    [Guid("602f2e8b-7bf0-4bb2-b484-eee8bcfae7a3")]
    // [CLSCompliant(false)]
    public class PartEditorFactory : IVsEditorFactory
    {
        private OpenXMLEditor myPackage;
        private ServiceProvider vsServiceProvider;


        public PartEditorFactory(OpenXMLEditor PackageEditor)
        {
            myPackage = PackageEditor;
        }

        #region IVsEditorFactory Members

        public int SetSite(Microsoft.VisualStudio.OLE.Interop.IServiceProvider psp)
        {
            vsServiceProvider = new ServiceProvider(psp);
            return VSConstants.S_OK;
        }

        public object GetService(Type serviceType)
        {
            return vsServiceProvider.GetService(serviceType);
        }

        // This method is called by the Environment (inside IVsUIShellOpenDocument::
        // OpenStandardEditor and OpenSpecificEditor) to map a LOGICAL view to a 
        // PHYSICAL view. A LOGICAL view identifies the purpose of the view that is
        // desired (e.g. a view appropriate for Debugging [LOGVIEWID_Debugging], or a 
        // view appropriate for text view manipulation as by navigating to a find
        // result [LOGVIEWID_TextView]). A PHYSICAL view identifies an actual type 
        // of view implementation that an IVsEditorFactory can create. 
        //
        // NOTE: Physical views are identified by a string of your choice with the 
        // one constraint that the default/primary physical view for an editor  
        // *MUST* use a NULL string as its physical view name (*pbstrPhysicalView = NULL).
        //
        // NOTE: It is essential that the implementation of MapLogicalView properly
        // validates that the LogicalView desired is actually supported by the editor.
        // If an unsupported LogicalView is requested then E_NOTIMPL must be returned.
        //
        // NOTE: The special Logical Views supported by an Editor Factory must also 
        // be registered in the local registry hive. LOGVIEWID_Primary is implicitly 
        // supported by all editor types and does not need to be registered.
        // For example, an editor that supports a ViewCode/ViewDesigner scenario
        // might register something like the following:
        //      HKLM\Software\Microsoft\VisualStudio\8.0\Editors\
        //          {...guidEditor...}\
        //              LogicalViews\
        //                  {...LOGVIEWID_TextView...} = s ''
        //                  {...LOGVIEWID_Code...} = s ''
        //                  {...LOGVIEWID_Debugging...} = s ''
        //                  {...LOGVIEWID_Designer...} = s 'Form'
        //
        public int MapLogicalView(ref Guid rguidLogicalView, out string pbstrPhysicalView)
        {
            pbstrPhysicalView = null;   // initialize out parameter

            // we support only a single physical view
            if (VSConstants.LOGVIEWID_Primary == rguidLogicalView)
                return VSConstants.S_OK;        // primary view uses NULL as pbstrPhysicalView
            else
                return VSConstants.E_NOTIMPL;   // you must return E_NOTIMPL for any unrecognized rguidLogicalView values
        }

        public int Close()
        {
            return VSConstants.S_OK;
        }

        public int CreateEditorInstance(
            uint grfCreateDoc,
            string pszMkDocument,
            string pszPhysicalView,
            IVsHierarchy pvHier,
            uint itemid,
            IntPtr punkDocDataExisting,
            out IntPtr ppunkDocView,
            out IntPtr ppunkDocData,
            out string pbstrEditorCaption,
            out Guid pguidCmdUI,
            out int pgrfCDW)
        {
            // Initialize to null
            ppunkDocView = IntPtr.Zero;
            ppunkDocData = IntPtr.Zero;
            pbstrEditorCaption = null;
            pguidCmdUI = GuidList.guidPartEditorFactory;
            pgrfCDW = (int)_VSRDTFLAGS.RDT_DontSaveAs;

            try
            {
                // Validate inputs
                if ((grfCreateDoc & (VSConstants.CEF_OPENFILE | VSConstants.CEF_SILENT)) == 0)
                {
                    Debug.Assert(false, "Only Open or Silent is valid");
                    return VSConstants.E_INVALIDARG;
                }

                PackageEditorPane existingPackageEditor = null;
                if (punkDocDataExisting != IntPtr.Zero)
                {
                    existingPackageEditor = Marshal.GetObjectForIUnknown(punkDocDataExisting) as PackageEditorPane;
                    if (existingPackageEditor == null)
                    {
                        // The user is trying to open our editor on an existing DocData which is not our editor.
                        // This editor does not support other editors simultaneously editing the same file.
                        return VSConstants.VS_E_INCOMPATIBLEDOCDATA;
                    }
                }

                if (pszPhysicalView == null)
                {
                    if (punkDocDataExisting != IntPtr.Zero)
                    {
                        // An XML fragment editor was already editing our DocData, and we are trying to open the main editor on it now.
                        // Just return the existing DocData object.
                        ppunkDocView = Marshal.GetIUnknownForObject(existingPackageEditor);
                        ppunkDocData = Marshal.GetIUnknownForObject(existingPackageEditor);
                        pbstrEditorCaption = string.Empty;
                        return VSConstants.S_OK;
                    }
                    // Open the main editor (the normal scenario).
                    PackageEditorPane editor = new PackageEditorPane(myPackage);
                    ppunkDocView = Marshal.GetIUnknownForObject(editor);
                    ppunkDocData = Marshal.GetIUnknownForObject(editor);
                    pbstrEditorCaption = string.Empty;
                    return VSConstants.S_OK;
                }

                // If physical view is non-null, create an editor window on an xml fragment.

                // Verify that the base document is created
                IVsHierarchy hierarchy;
                uint itemIdFindAndLock;
                IntPtr docDataFindAndLock;
                uint docCookieFindAndLock;
                IVsRunningDocumentTable runningDocTable = (IVsRunningDocumentTable)this.GetService(typeof(SVsRunningDocumentTable));

                int hr = runningDocTable.FindAndLockDocument(
                    (uint)_VSRDTFLAGS.RDT_NoLock,
                    pszMkDocument,
                    out hierarchy,
                    out itemIdFindAndLock,
                    out docDataFindAndLock,
                    out docCookieFindAndLock
                );

                string xml = string.Empty;
                if (VSConstants.S_OK != hr) // can't find document in RDT.
                {
                    // We are being asked to open a sub document before the main document is open.
                    // Let's create the main and put it in the RDT with a temporary EditLock that
                    // we will release after the sub document window is created.
                    PackageEditorPane editor = new PackageEditorPane(myPackage);
                    IVsPersistDocData mainDocData = editor;
                    mainDocData.LoadDocData(pszMkDocument);
                    // TODO editor.TemporaryLockDocument(runningDocTable, pvHier, itemid, pszMkDocument);
                    xml = editor.GetXml(pszPhysicalView);
                }
                else
                {
                    // get xml from open editor.
                    if (docDataFindAndLock != IntPtr.Zero)
                    {
                        Marshal.Release(docDataFindAndLock);
                    }
                    if (existingPackageEditor != null)
                    {
                        xml = existingPackageEditor.GetXml(pszPhysicalView);
                    }
                }

                // Use ILocalRegistry to create text buffer and code window
                ILocalRegistry localRegistry = (ILocalRegistry)this.GetService(typeof(ILocalRegistry));
                Debug.Assert(null != localRegistry);

                // Create the document (text buffer)
                IntPtr vsTextLines = IntPtr.Zero;
                Guid guidTextLines = typeof(IVsTextLines).GUID;
                ErrorHandler.ThrowOnFailure(
                    localRegistry.CreateInstance(typeof(VsTextBufferClass).GUID, null, ref guidTextLines, (uint)CLSCTX.CLSCTX_INPROC_SERVER, out vsTextLines)
                );
                IVsTextLines textLines = (IVsTextLines)Marshal.GetObjectForIUnknown(vsTextLines);

                // Create the codewindow (editor)
                IntPtr vsCodeWindow = IntPtr.Zero;
                Guid guidCodeWindow = typeof(IVsCodeWindow).GUID;
                ErrorHandler.ThrowOnFailure(
                    localRegistry.CreateInstance(typeof(VsCodeWindowClass).GUID, null, ref guidCodeWindow, (uint)CLSCTX.CLSCTX_INPROC_SERVER, out vsCodeWindow)
                );
                IVsCodeWindow codeWindow = Marshal.GetObjectForIUnknown(vsCodeWindow) as IVsCodeWindow;

                // Site it, so it can find/query for various services
                IObjectWithSite textLinesWithSite = (IObjectWithSite)textLines;

                // Site the TextBuffer with an IOleServiceProvider 
                IOleServiceProvider pOleSeviceProvider;
                pOleSeviceProvider = (IOleServiceProvider)this.vsServiceProvider.GetService(typeof(IOleServiceProvider));
                textLinesWithSite.SetSite(pOleSeviceProvider);

                ErrorHandler.ThrowOnFailure(
                    textLines.InitializeContent(xml, xml.Length)
                );

                // Attach buffer to code window
                ErrorHandler.ThrowOnFailure(
                    codeWindow.SetBuffer(textLines)
                );

                // Set the language service to the XML language service to get syntax highlighting
                Guid xmlLanguageServiceGuid = new Guid("{f6819a78-a205-47b5-be1c-675b3c7f0b8e}");
                textLines.SetLanguageServiceID(ref xmlLanguageServiceGuid);

                // If the project system has specified the language service clear the auto detect flag to ensure that we use the preferred service
                IVsUserData userData = (IVsUserData)textLines;
                Guid vsBufferDetectLangSIDGuid = new Guid("{17F375AC-C814-11d1-88AD-0000F87579D2}");
                object flagObject = false;
                userData.SetData(ref vsBufferDetectLangSIDGuid, flagObject);

                ppunkDocView = vsCodeWindow; // refcnt from CreateEditorInstance
                ppunkDocData = vsTextLines; // refcnt from CreateEditorInstance
                pbstrEditorCaption = " (" + pszPhysicalView + ")";
                pgrfCDW |= (int)__VSCREATEDOCWIN.CDW_fAltDocData;

                return VSConstants.S_OK;
            }
            catch (Exception error)
            {
                System.Windows.Forms.MessageBox.Show(error.Message);
            }
            return VSConstants.E_INVALIDARG;
        }

        #endregion
    }
}
