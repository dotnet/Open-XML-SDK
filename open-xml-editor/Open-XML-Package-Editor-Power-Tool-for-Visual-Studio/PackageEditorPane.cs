/****************************************************************************

    PackageEditorPane.cs

    The Package Editor class.

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
using System.Diagnostics;
using System.Drawing;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell.Interop;
using Microsoft.VisualStudio.OLE.Interop;
using Microsoft.VisualStudio.TextManager.Interop;
using Microsoft.VisualStudio;
using Microsoft.VisualStudio.Shell;
using System.IO;
using System.IO.Packaging;
using System.Text;

using IServiceProvider = System.IServiceProvider;
using IOleServiceProvider = Microsoft.VisualStudio.OLE.Interop.IServiceProvider;
using VSStd97CmdID = Microsoft.VisualStudio.VSConstants.VSStd97CmdID;
using Packaging = System.IO.Packaging;

namespace Microsoft.OpenXMLEditor
{
    /// <summary>
    /// This control hosts the editor (a TreeView of the Package) and is responsible for
    /// handling the commands targeted to the editor as well as saving and loading
    /// the document. This control also implement the search and replace functionalities.
    /// </summary>
    // [CLSCompliant(false)]
    public sealed partial class PackageEditorPane : System.Windows.Forms.UserControl,
                                IVsPersistDocData,
                                IPersistFileFormat,
                                IOleCommandTarget,
                                IVsWindowPane,
                                IVsFindTarget,
                                IVsDocDataFileChangeControl,
                                IVsFileChangeEvents
    {
        #region File Format List

        struct Format
        {
            public Format(string e, string t) { extension = e; type = t; }
            public string extension;
            public string type;
        };
        private Format[] formats = new Format[]
        {
            // Office Packages
            new Format( ".crtx",    "Chart Template" ),
            new Format( ".docm",    "Word Document Macro Enabled" ),
            new Format( ".docx",    "Word Document" ),
            new Format( ".dotm",    "Word Template Macro Enabled" ),
            new Format( ".dotx",    "Word Template" ),
            new Format( ".eftx",    "Office Style Matrix" ),
            new Format( ".gcsx",    "SmartArt Color Transform" ),
            new Format( ".glox",    "SmartArt Layout Definition" ),
            new Format( ".gqsx",    "SmartArt Quick Style" ),
            new Format( ".potm",    "PowerPoint Template Macro Enabled" ),
            new Format( ".potx",    "PowerPoint Template" ),
            new Format( ".ppam",    "PowerPoint Addin" ),
            new Format( ".ppsm",    "PowerPoint Slide Show Macro Enabled" ),
            new Format( ".ppsx",    "PowerPoint Slide Show" ),
            new Format( ".pptm",    "PowerPoint Show Macro Enabled" ),
            new Format( ".pptx",    "PowerPoint Show" ),
            new Format( ".thmx",    "Office Theme" ),
            new Format( ".xlam",    "Excel AddIn Macro Enabled" ),
            new Format( ".xlsb",    "Excel Sheet Binary Macro Enabled" ),
            new Format( ".xlsm",    "Excel Sheet Macro Enabled" ),
            new Format( ".xlsx",    "Excel Sheet" ),
            new Format( ".xltm",    "Excel Template Macro Enabled" ),
            new Format( ".xltx",    "Excel Template" ),
            new Format( ".vsdx",    "Visio drawing" ),
            new Format( ".vsdm",    "Visio macro-enabled drawing" ),
            new Format( ".vssx",    "Visio stencil" ),
            new Format( ".vssm",    "Visio macro-enabled stencil" ),
            new Format( ".vstx",    "Visio template" ),
            new Format( ".vstm",    "Visio macro-enabled template" ),

            // WinFX Packages
            new Format( ".container","Windows Package" ),
            new Format( ".xps",        "XML Paper Specification  Package" ),
            new Format( ".oxps",        "Open XML Paper Specification Package" ),
            // Visual Studio Packages
            new Format( ".vsix",        "Visual Studio Extension Package" ),

        };

        #endregion

        #region Fields

        private ServiceProvider vsServiceProvider;
        private OpenXMLEditor myPackage;

        // This flag is true when we are asking the QueryEditQuerySave service if we can edit the
        // file. It is used to avoid to have more than one request queued.
        private bool gettingCheckoutStatus;

        // Find and replace related variables
        private object findState = null;
        /*
        private bool passedEndOfFile;
        private bool forceNewSearch;
        private int currentSearchStart;
        private int searchCursorLocation;
        private bool forceCursorWrapAround;
        private bool replaced;
        */

        // Counter of the file system changes to ignore.
        private int changesToIgnore;
        // Cookie for the subscription to the file system notification events.
        private uint fileChangeNotifyCookie;
        // This flag is used to know when the reload procedure is running.
        private bool isFileReloading;

        private IVsRunningDocumentTable runningDocTable;

        private DocumentPackage docPkg = null;
        private bool showXmlRels = false;

        private const int maxHistory = 10;
        private LinkedList<DocumentPart> history = new LinkedList<DocumentPart>();
        private LinkedListNode<DocumentPart> curHistory = null;

        // Track selection service of the Visual Studio
        private ITrackSelection trackSelection;
        // Selection container to pass the data to Properties window
        private SelectionContainer selContainer;

        #endregion

        #region Members

        private PackageEditorPane()
        {
            PrivateInit(null);

            // This call is required by the Windows.Forms Form Designer.
            InitializeComponent();
        }

        public PackageEditorPane(OpenXMLEditor package)
        {
            PrivateInit(package);

            // This call is required by the Windows.Forms Form Designer.
            InitializeComponent();
        }

        private void PrivateInit(OpenXMLEditor package)
        {
            myPackage = package;
            gettingCheckoutStatus = false;
            isFileReloading = false;
            fileChangeNotifyCookie = VSConstants.VSCOOKIE_NIL;
            changesToIgnore = 0;
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                // Unsubscribe from the notification of file system events
                AdviseFileChange(false);
                if (components != null)
                {
                    components.Dispose();
                }
                GC.SuppressFinalize(this);
            }
            base.Dispose(disposing);
        }

        /// <summary> 
        /// Let this control process the mnemonics.
        /// </summary>
        protected override bool ProcessDialogChar(char charCode)
        {
            // If we're the top-level form or control, we need to do the mnemonic handling
            if (charCode != ' ' && ProcessMnemonic(charCode))
            {
                return true;
            }
            return base.ProcessDialogChar(charCode);
        }

        /// <summary>
        /// Retrieves the requested service from the Shell.
        /// </summary>
        /// <param name="serviceType">Service that is being requested</param>
        /// <returns>An object which type is as requested</returns>
        public object GetVsService(Type serviceType)
        {
            return vsServiceProvider.GetService(serviceType);
        }

        private void NotifyDocChanged()
        {

                // Get a reference to the Running Document Table
                if (runningDocTable == null)
                {
                    runningDocTable = (IVsRunningDocumentTable)GetVsService(typeof(SVsRunningDocumentTable));
                }

                // Lock the document
                uint docCookie;
                IVsHierarchy hierarchy;
                uint itemID;
                IntPtr docData = IntPtr.Zero;

                int hr = runningDocTable.FindAndLockDocument(
                    (uint)_VSRDTFLAGS.RDT_ReadLock,
                    docPkg.FilePath,
                    out hierarchy,
                    out itemID,
                    out docData,
                    out docCookie
                );

                    // Release the docData because we don't use it.
                    if (IntPtr.Zero != docData)
                    {
                        Marshal.Release(docData);
                    }
                   ErrorHandler.ThrowOnFailure(hr);



                // Send the notification. Note that we do not throw now in case of error because before
                // we have to unlock the document.
                hr = runningDocTable.NotifyDocumentChanged(docCookie, (uint)__VSRDTATTRIB.RDTA_DocDataReloaded);

                // Unlock the document.
                // Note that we have to unlock the document even if the previous call failed.
                runningDocTable.UnlockDocument((uint)_VSRDTFLAGS.RDT_ReadLock, docCookie);

                // Check if the call to NotifyDocChanged failed.
                ErrorHandler.ThrowOnFailure(hr);


        }

        int Microsoft.VisualStudio.OLE.Interop.IPersist.GetClassID(out Guid pClassID)
        {
            pClassID = GuidList.guidEditorFactory;
            return VSConstants.S_OK;
        }

        uint FormatIndexFromExt(string ext)
        {
            uint ix = 0;
            foreach (Format format in formats)
            {
                if (format.extension == ext)
                {
                    return ix;
                }
                ix++;
            }
            return uint.MaxValue;
        }

        string ExtFromFormatIndex(uint ix)
        {
            if (ix < formats.Length)
                return formats[ix].extension;
            return null;
        }

        private void AdviseFileChange(bool subscribe)
        {
            // Get the VsFileChangeEx service; this service will call us back when a file system
            // event will occur on the file(s) that we register.
            IVsFileChangeEx fileChangeService = (IVsFileChangeEx)GetVsService(typeof(SVsFileChangeEx));
            int hr = VSConstants.S_OK;

            if (!subscribe)
            {
                // If the goal is to unsubscribe, but there is no subscription active, exit.
                if (fileChangeNotifyCookie == VSConstants.VSCOOKIE_NIL)
                    return;

                // Now there is an active subscription, so unsubscribe.
                hr = fileChangeService.UnadviseFileChange(fileChangeNotifyCookie);
                // No more subscription active, so set the cookie to NIL
                fileChangeNotifyCookie = VSConstants.VSCOOKIE_NIL;
                ErrorHandler.ThrowOnFailure(hr);
                return;
            }

            // Here we want to subscribe for notification when the file opened in the editor changes.
            uint eventsToSubscribe = (uint)_VSFILECHANGEFLAGS.VSFILECHG_Size |
                                     (uint)_VSFILECHANGEFLAGS.VSFILECHG_Time;
            hr = fileChangeService.AdviseFileChange(
                docPkg.FilePath,                        // The file to check
                eventsToSubscribe,                // Filter to use for the notification
                (IVsFileChangeEvents)this,        // The callback to call
                out fileChangeNotifyCookie);    // Cookie used to identify this subscription.
            ErrorHandler.ThrowOnFailure(hr);
        }

        /// <summary>
        /// This function asks to the QueryEditQuerySave service if it is possible to
        /// edit the file.
        /// </summary>
        private bool CanEditFile()
        {
            Debug.WriteLine("\t**** CanEditFile called ****");

            // Check the status of the recursion guard
            if (gettingCheckoutStatus)
                return false;

            try
            {
                // Set the recursion guard
                gettingCheckoutStatus = true;

                // Get the QueryEditQuerySave service
                IVsQueryEditQuerySave2 queryEditQuerySave = (IVsQueryEditQuerySave2)GetVsService(typeof(SVsQueryEditQuerySave));

                // Now call the QueryEdit method to find the edit status of this file
                string[] documents = { this.docPkg.FilePath };
                uint result;
                uint outFlags;

                // Note that this function can popup a dialog to ask the user to checkout the file.
                // When this dialog is visible, it is possible to receive other request to change
                // the file and this is the reason for the recursion guard.
                int hr = queryEditQuerySave.QueryEditFiles(
                    0,              // Flags
                    1,              // Number of elements in the array
                    documents,      // Files to edit
                    null,           // Input flags
                    null,           // Input array of VSQEQS_FILE_ATTRIBUTE_DATA
                    out result,     // result of the checkout
                    out outFlags    // Additional flags
                );
                if (ErrorHandler.Succeeded(hr) && (result == (uint)tagVSQueryEditResult.QER_EditOK))
                {
                    // In this case (and only in this case) we can return true from this function.
                    return true;
                }
            }
            finally
            {
                gettingCheckoutStatus = false;
            }
            return false;
        }

        private void reloadTimer_Tick(object sender, System.EventArgs e)
        {
            // Here we want to check if we can process the reload.
            // We don't want to show the reload popup when the shell is not the active window,
            // so as first we check if the shell has the focus.
            // To do so we use the Win32 function GetActiveWindow that will return the handle
            // of the active window in the current application and NULL (0) if no window has
            // the focus.
            if (0 != NativeMethods.GetActiveWindow())
            {
                try
                {
                    // Set the flag about the reload status. 
                    // It is important to avoid that the popup will show multiple times for the same file.
                    isFileReloading = true;

                    // The timer was used only to not run this procedure in syncronously inside the
                    // notification function, so now we can stop end disable it.
                    reloadTimer.Stop();
                    reloadTimer.Enabled = false;

                    // Build the title and message for the popup.
                    string message = docPkg.FileName + "\n\n" + Properties.Resources.OutsideEditorFileChange;
                    string title = AboutForm.AssemblyTitle;
                    // Show the popup
                    System.Windows.Forms.DialogResult res = MessageBox.Show(
                        this,
                        message,
                        title,
                        System.Windows.Forms.MessageBoxButtons.YesNo,
                        System.Windows.Forms.MessageBoxIcon.Question);
                    if (res == System.Windows.Forms.DialogResult.Yes)
                    {
                        // The user wants to reload the data, so let's call the function that will do the job.

                        int hr = ((IVsPersistDocData)this).ReloadDocData(0);
                        // If this fail, this is not fatal, but we should try to understand what went wrong.
                        Debug.Assert(hr >= 0, "Failed to close IVsWindowFrame while disposing of the package");
                    }
                }                
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
                finally
                {
                    // Reset the flag about the reload status.
                    isFileReloading = false;
                }
            }
        }

        #endregion

        #region Properties

        private ITrackSelection TrackSelection
        {
            get
            {
                if (trackSelection == null)
                    trackSelection = GetVsService(typeof(STrackSelection)) as ITrackSelection;

                return trackSelection;
            }
        }

        public string RootTreeNodeText
        {
            get
            {
                if (treeView.Nodes.Count > 0)
                    return treeView.Nodes[0].Text;
                else
                    return null;
            }
            set
            {
                if (treeView.Nodes.Count > 0)
                    treeView.Nodes[0].Text = value;
            }
        }

        #endregion

        #region IOleCommandTarget Members

        /// <summary>
        /// The shell call this function to know if a menu item should be visible and
        /// if it should be enabled/disabled.
        /// Note that this function will only be called when an instance of this editor
        /// is open.
        /// </summary>
        /// <param name="guidCmdGroup">Guid describing which set of command the current command(s) belong to</param>
        /// <param name="cCmds">Number of command which status are being asked for</param>
        /// <param name="prgCmds">Information for each command</param>
        /// <param name="pCmdText">Used to dynamically change the command text</param>
        /// <returns>HRESULT</returns>
        public int QueryStatus(ref Guid guidCmdGroup, uint cCmds, OLECMD[] prgCmds, System.IntPtr pCmdText)
        {
            Debug.Assert(cCmds == 1, "Multiple commands");
            Debug.Assert(prgCmds != null, "NULL argument");

            if ((prgCmds == null))
                return VSConstants.E_INVALIDARG;

            OLECMDF cmdf = OLECMDF.OLECMDF_SUPPORTED;

            if (guidCmdGroup == VSConstants.GUID_VSStandardCommandSet97)
            {
                // Process standard Commands
                switch (prgCmds[0].cmdID)
                {
                    case (uint)VSStd97CmdID.SelectAll:
                        {
                            // Always enabled
                            cmdf = OLECMDF.OLECMDF_SUPPORTED | OLECMDF.OLECMDF_ENABLED;
                            break;
                        }
                    case (uint)VSStd97CmdID.Copy:
                    case (uint)VSStd97CmdID.Cut:
                        {
                            // Enable if something is selected
                            //if (textBox1.SelectionLength > 0)
                            //    cmdf |= OLECMDF.OLECMDF_ENABLED;
                            break;
                        }
                    case (uint)VSStd97CmdID.Paste:
                        {
                            // Enable if clipboard has content we can paste
                            //if (textBox1.CanPaste(DataFormats.GetFormat(DataFormats.Text)))
                            //    cmdf |= OLECMDF.OLECMDF_ENABLED;
                            break;
                        }
                    case (uint)VSStd97CmdID.Redo:
                        {
                            //if (textBox1.CanRedo)
                            //    cmdf |= OLECMDF.OLECMDF_ENABLED;
                            break;
                        }
                    case (uint)VSStd97CmdID.Undo:
                        {
                            //if (textBox1.CanUndo)
                            //    cmdf |= OLECMDF.OLECMDF_ENABLED;
                            break;
                        }
                    default:
                        return (int)(Microsoft.VisualStudio.OLE.Interop.Constants.OLECMDERR_E_NOTSUPPORTED);
                }
            }
            else if (guidCmdGroup == GuidList.guidOpenXMLEditorCmdSet)
            {
                // Process our Commands
                switch (prgCmds[0].cmdID)
                {
                    // if we had commands specific to our editor, they would be processed here
                    default:
                        return (int)(Microsoft.VisualStudio.OLE.Interop.Constants.OLECMDERR_E_NOTSUPPORTED);
                }
            }
            else
                return (int)(Microsoft.VisualStudio.OLE.Interop.Constants.OLECMDERR_E_NOTSUPPORTED);

            prgCmds[0].cmdf = (uint)cmdf;

            return VSConstants.S_OK;
        }

        /// <summary>
        /// Execute a command
        /// Typically, only the first 2 arguments are used (to identify which command should be run)
        /// </summary>
        /// <param name="guidCmdGroup">Guid describing which set of command the current command(s) belong to</param>
        /// <param name="nCmdID">Command that should be executed</param>
        /// <param name="nCmdexecopt">options for the command</param>
        /// <param name="pvaIn">Pointer to input arguments</param>
        /// <param name="pvaOut">Pointer to command output</param>
        /// <returns></returns>
        public int Exec(ref Guid guidCmdGroup, uint nCmdID, uint nCmdexecopt, System.IntPtr pvaIn, System.IntPtr pvaOut)
        {
            Debug.WriteLine(string.Format(CultureInfo.CurrentCulture, "Entering Exec() of: {0}", this.ToString()));

            if (guidCmdGroup == VSConstants.GUID_VSStandardCommandSet97)
            {
                // Process standard Visual Studio Commands
                switch (nCmdID)
                {
                    case (uint)VSStd97CmdID.Copy:
                        {
                            //textBox1.Copy();
                            break;
                        }
                    case (uint)VSStd97CmdID.Cut:
                        {
                            //textBox1.Cut();
                            break;
                        }
                    case (uint)VSStd97CmdID.Paste:
                        {
                            //textBox1.Paste();
                            break;
                        }
                    case (uint)VSStd97CmdID.Redo:
                        {
                            //textBox1.Redo();
                            break;
                        }
                    case (uint)VSStd97CmdID.Undo:
                        {
                            //textBox1.Undo();
                            break;
                        }
                    case (uint)VSStd97CmdID.SelectAll:
                        {
                            //textBox1.SelectAll();
                            break;
                        }
                    default:
                        return (int)(Microsoft.VisualStudio.OLE.Interop.Constants.OLECMDERR_E_NOTSUPPORTED);
                }
            }
            else if (guidCmdGroup == GuidList.guidOpenXMLEditorCmdSet)
            {
                switch (nCmdID)
                {
                    // if we had commands specific to our editor, they would be processed here
                    default:
                        return (int)(Microsoft.VisualStudio.OLE.Interop.Constants.OLECMDERR_E_NOTSUPPORTED);
                }
            }
            else
                return (int)Microsoft.VisualStudio.OLE.Interop.Constants.OLECMDERR_E_UNKNOWNGROUP;

            return VSConstants.S_OK;
        }

        #endregion

        #region IVsWindowPane Members

        public int SetSite(Microsoft.VisualStudio.OLE.Interop.IServiceProvider psp)
        {
            vsServiceProvider = new ServiceProvider(psp);
            return VSConstants.S_OK;
        }

        int Microsoft.VisualStudio.Shell.Interop.IVsWindowPane.TranslateAccelerator(MSG[] lpmsg)
        {
            return VSConstants.S_FALSE;
        }

        int Microsoft.VisualStudio.Shell.Interop.IVsWindowPane.SaveViewState(IStream pStream)
        {
            return VSConstants.S_OK;
        }

        int Microsoft.VisualStudio.Shell.Interop.IVsWindowPane.LoadViewState(IStream pStream)
        {
            return VSConstants.S_OK;
        }

        int Microsoft.VisualStudio.Shell.Interop.IVsWindowPane.GetDefaultSize(SIZE[] size)
        {
            if (size.Length >= 1)
            {
                size[0].cx = Size.Width;
                size[0].cy = Size.Height;
            }

            return VSConstants.S_OK;
        }

        int Microsoft.VisualStudio.Shell.Interop.IVsWindowPane.CreatePaneWindow(System.IntPtr hwndParent, int x, int y, int cx, int cy, out System.IntPtr hwnd)
        {
            Win32Methods.SetParent(Handle, hwndParent);
            hwnd = Handle;

            Size = new System.Drawing.Size(cx - x, cy - y);
            return VSConstants.S_OK;
        }

        public int ClosePane()
        {
            this.Dispose(true);
            return VSConstants.S_OK;
        }

        #endregion

        #region IPersistFileFormat Members

        int IPersistFileFormat.SaveCompleted(string pszFilename)
        {
            return VSConstants.S_OK;
        }

        int IPersistFileFormat.GetCurFile(out string ppszFilename, out uint pnFormatIndex)
        {
            if (string.IsNullOrEmpty(docPkg.FilePath) || docPkg.IsUntitled)
            {
                // unsaved file
                ppszFilename = RootTreeNodeText;
            }
            else
            {
                ppszFilename = docPkg.FilePath;
            }
            string ext = System.IO.Path.GetExtension(ppszFilename);
            pnFormatIndex = FormatIndexFromExt(ext);
            return VSConstants.S_OK;
        }

        int IPersistFileFormat.InitNew(uint nFormatIndex)
        {
            if (nFormatIndex >= formats.Length)
            {
                throw new ArgumentException(Properties.Resources.UnknownFileFormat);
            }
            // until someone change the file, we can consider it not dirty as
            // the user would be annoyed if we prompt her to save an empty file
            return VSConstants.S_OK;
        }

        int IPersistFileFormat.GetClassID(out Guid pClassID)
        {
            ((Microsoft.VisualStudio.OLE.Interop.IPersist)this).GetClassID(out pClassID);
            return VSConstants.S_OK;
        }

        int IPersistFileFormat.GetFormatList(out string ppszFormatList)
        {
            // make an entry for each Package file type
            ppszFormatList = "";
            foreach (Format format in formats)
            {
                ppszFormatList += format.type + " (*" + format.extension + ")\n";
                ppszFormatList += "*" + format.extension + "\n";
            }

            // make an All Package Files entry
            ppszFormatList += "All Package Files (";
            foreach (Format format in formats)
            {
                ppszFormatList += "*" + format.extension + ";";
            }
            ppszFormatList.TrimEnd(';');
            ppszFormatList += ")\n";
            foreach (Format format in formats)
            {
                ppszFormatList += "*" + format.extension + ";";
            }
            ppszFormatList.TrimEnd(';');
            ppszFormatList += "\n";

            // terminate the list
            ppszFormatList += "\n";

            return VSConstants.S_OK;
        }

        int IPersistFileFormat.Load(string pszFilename, uint grfMode, int fReadOnly)
        {
            if ((pszFilename == null) && string.IsNullOrEmpty(docPkg.FilePath))
            {
                throw new ArgumentNullException(Properties.Resources.NullFilename);
            }

            int hr = VSConstants.S_OK;
            try
            {
                bool isReload = false;

                // If the new file name is null, then this operation is a reload
                if (pszFilename == null)
                {
                    isReload = true;
                }

                // Show the wait cursor while loading the file
                IVsUIShell vsUiShell = (IVsUIShell)GetVsService(typeof(SVsUIShell));
                if (vsUiShell != null)
                {
                    // Note: we don't want to throw or exit if this call fails, so
                    // don't check the return code.
                    vsUiShell.SetWaitCursor();
                }

                // Set the new file name
                if (!isReload)
                {
                    // Unsubscribe from the notification of the changes in the previous file.
                    AdviseFileChange(false);
                }
                // Load the file
                // OpenFile(pszFilename);
                bool isOpened = OpenFile(pszFilename);
                if (isOpened)
                {

                    // Subscribe for the notification on file changes.
                    if (!isReload)
                    {
                        AdviseFileChange(true);
                    }

                    // Notify the load or reload
                    NotifyDocChanged();
                }
                else
                {
                        IVsWindowFrame frame = (IVsWindowFrame)GetVsService(typeof(SVsWindowFrame));
                        if (frame != null)
                        {
                            frame.CloseFrame((uint)__FRAMECLOSE.FRAMECLOSE_SaveIfDirty);
                        }
                }
            }
            finally
            {
            }
            return hr;
        }

        int IPersistFileFormat.IsDirty(out int pfIsDirty)
        {
            pfIsDirty = ((docPkg != null) && docPkg.IsDirty) ? 1 : 0;
            return VSConstants.S_OK;
        }

        int IPersistFileFormat.Save(string pszFilename, int remember, uint nFormatIndex)
        {
            // We don't want to be notify for this change of the file.
            AdviseFileChange(false);

            // If file is null or same --> SAVE
            if (pszFilename == null || pszFilename == docPkg.FilePath)
            {
                FlushAllViews(true);
                docPkg.Save();
            }
            // If remember --> SaveAs
            else if (remember != 0)
            {
                FlushAllViews(true);
                docPkg.SaveAs(pszFilename);
            }
            // Else, Save a Copy As
            else
            {
                FlushAllViews(false);
                docPkg.SaveCopyAs(pszFilename);
            }
            // Now that the file is saved (and maybe renamed) we can subscribe again
            // for the file system events.
            AdviseFileChange(true);

            return VSConstants.S_OK;
        }

        #endregion

        #region IVsPersistDocData Members

        int IVsPersistDocData.IsDocDataDirty(out int pfDirty)
        {
            return ((IPersistFileFormat)this).IsDirty(out pfDirty);
        }

        int IVsPersistDocData.SaveDocData(Microsoft.VisualStudio.Shell.Interop.VSSAVEFLAGS dwSave, out string pbstrMkDocumentNew, out int pfSaveCanceled)
        {
            pbstrMkDocumentNew = null;
            pfSaveCanceled = 0;
            int hr = VSConstants.S_OK;

            switch (dwSave)
            {
                case VSSAVEFLAGS.VSSAVE_Save:
                case VSSAVEFLAGS.VSSAVE_SilentSave:
                    {
                        IVsQueryEditQuerySave2 queryEditQuerySave = (IVsQueryEditQuerySave2)GetVsService(typeof(SVsQueryEditQuerySave));

                        // Call QueryEditQuerySave
                        uint result = 0;
                        hr = queryEditQuerySave.QuerySaveFile(
                                            docPkg.FilePath,        // filename
                                            0,    // flags
                                            null,            // file attributes
                                            out result);    // result
                        if (ErrorHandler.Failed(hr))
                            return hr;

                        // Process according to result from QuerySave
                        switch ((tagVSQuerySaveResult)result)
                        {
                            case tagVSQuerySaveResult.QSR_NoSave_Cancel:
                                // Note that this is also case tagVSQuerySaveResult.QSR_NoSave_UserCanceled because these
                                // two tags have the same value.
                                pfSaveCanceled = ~0;
                                break;

                            case tagVSQuerySaveResult.QSR_SaveOK:
                                {
                                    // Call the shell to do the save for us
                                    IVsUIShell uiShell = (IVsUIShell)GetVsService(typeof(SVsUIShell));
                                    hr = uiShell.SaveDocDataToFile(dwSave, (IPersistFileFormat)this, docPkg.FilePath, out pbstrMkDocumentNew, out pfSaveCanceled);
                                    if (ErrorHandler.Failed(hr))
                                        return hr;
                                }
                                break;

                            case tagVSQuerySaveResult.QSR_ForceSaveAs:
                                {
                                    // Call the shell to do the SaveAS for us
                                    IVsUIShell uiShell = (IVsUIShell)GetVsService(typeof(SVsUIShell));
                                    hr = uiShell.SaveDocDataToFile(VSSAVEFLAGS.VSSAVE_SaveAs, (IPersistFileFormat)this, docPkg.FilePath, out pbstrMkDocumentNew, out pfSaveCanceled);
                                    if (ErrorHandler.Failed(hr))
                                        return hr;
                                }
                                break;

                            case tagVSQuerySaveResult.QSR_NoSave_Continue:
                                // In this case there is nothing to do.
                                break;

                            default:
                                throw new COMException(Properties.Resources.SCCError);
                        }
                        break;
                    }
                case VSSAVEFLAGS.VSSAVE_SaveAs:
                case VSSAVEFLAGS.VSSAVE_SaveCopyAs:
                    {
                        // Make sure the file name as the right extension
                        /*
                        string ext = System.IO.Path.GetExtension(docPkg.FilePath);

                        if (ext == null || ext == string.Empty)
                        {
                            fileName += ".container";
                        }
                        */
                        // Call the shell to do the save for us
                        IVsUIShell uiShell = (IVsUIShell)GetVsService(typeof(SVsUIShell));
                        hr = uiShell.SaveDocDataToFile(dwSave, (IPersistFileFormat)this, docPkg.FilePath, out pbstrMkDocumentNew, out pfSaveCanceled);
                        if (ErrorHandler.Failed(hr))
                            return hr;
                        break;
                    }
                default:
                    throw new ArgumentException(Properties.Resources.BadSaveFlags);
            };

            return VSConstants.S_OK;
        }

        int IVsPersistDocData.LoadDocData(string pszMkDocument)
        {
                return ((IPersistFileFormat)this).Load(pszMkDocument, 0, 0);                
        }

        int IVsPersistDocData.SetUntitledDocPath(string pszDocDataPath)
        {
            string ext = System.IO.Path.GetExtension(pszDocDataPath);
            docPkg.UntitledName = pszDocDataPath;
            RootTreeNodeText = pszDocDataPath;
            return ((IPersistFileFormat)this).InitNew(FormatIndexFromExt(ext));
        }

        int IVsPersistDocData.GetGuidEditorType(out Guid pClassID)
        {
            return ((IPersistFileFormat)this).GetClassID(out pClassID);
        }

        int IVsPersistDocData.Close()
        {
            return VSConstants.S_OK;
        }

        int IVsPersistDocData.IsDocDataReloadable(out int pfReloadable)
        {
            // Allow file to be reloaded
            pfReloadable = 1;
            return VSConstants.S_OK;
        }

        int IVsPersistDocData.RenameDocData(uint grfAttribs, IVsHierarchy pHierNew, uint itemidNew, string pszMkDocumentNew)
        {
            RootTreeNodeText = System.IO.Path.GetFileName(pszMkDocumentNew);
            return VSConstants.S_OK;
        }

        int IVsPersistDocData.ReloadDocData(uint grfFlags)
        {
            return ((IPersistFileFormat)this).Load(null, grfFlags, 0);
        }

        int IVsPersistDocData.OnRegisterDocData(uint docCookie, IVsHierarchy pHierNew, uint itemidNew)
        {
            return VSConstants.S_OK;
        }

        #endregion

        #region IVsFindTarget Members

        /// <summary>
        /// Return the object that was requested
        /// </summary>
        /// <param name="propid">Id of the requested object</param>
        /// <param name="pvar">Object returned</param>
        /// <returns>HResult</returns>
        public int GetProperty(uint propid, out object pvar)
        {
            pvar = null;

            switch (propid)
            {
                case (uint)__VSFTPROPID.VSFTPROPID_DocName:
                    {
                        // Return the file name
                        pvar = docPkg.FilePath;
                        break;
                    }
                case (uint)__VSFTPROPID.VSFTPROPID_InitialPattern:
                case (uint)__VSFTPROPID.VSFTPROPID_InitialPatternAggressive:
                    {
                        // Return the selected text
                        //pvar = textBox1.SelectedText;
                        break;
                    }
                case (uint)__VSFTPROPID.VSFTPROPID_WindowFrame:
                    {
                        // Return the Window frame
                        pvar = (IVsWindowFrame)GetVsService(typeof(SVsWindowFrame));
                        break;
                    }
                case (uint)__VSFTPROPID.VSFTPROPID_IsDiskFile:
                    {
                        // We assume the file is on disk
                        pvar = true;
                        break;
                    }
                default:
                    {
                        return VSConstants.E_NOTIMPL;
                    }
            }

            return VSConstants.S_OK;
        }

        /// <summary>
        /// Not implemented.
        /// We don't need this function since we implement Find and Replace
        /// </summary>
        /// <param name="grfOptions"></param>
        /// <param name="ppSpans"></param>
        /// <param name="ppTextImage"></param>
        public int GetSearchImage(uint grfOptions, IVsTextSpanSet[] ppSpans, out IVsTextImage ppTextImage)
        {
            ppTextImage = null;
            return VSConstants.E_NOTIMPL; // "GetSearchImage is not implemented, Find and Replace should be used instead"
        }

        /// <summary>
        /// Retrieve a previously stored object
        /// </summary>
        /// <returns>The object that is being asked</returns>
        public int GetFindState(out object state)
        {
            state = findState;
            return VSConstants.S_OK;
        }

        /// <summary>
        /// Search for the string in the text of our editor.
        /// Options specify how we do the search
        /// </summary>
        /// <param name="pszSearch">Search string</param>
        /// <param name="grfOptions">Search options</param>
        /// <param name="fResetStartPoint">Is this a new search?</param>
        /// <param name="pHelper">We are not using it</param>
        /// <param name="pResult">True if we found the search string</param>
        public int Find(string pszSearch, uint grfOptions, int fResetStartPoint, IVsFindHelper pHelper, out uint pResult)
        {
            pResult = 0;
            /*
            int result = 0;
            bool reverse = false;

            // Transform the VS search options to RTF search options
            RichTextBoxFinds options = RichTextBoxFinds.None;
            if ((grfOptions & (int)__VSFINDOPTIONS.FR_WholeWord) != 0)
                options |= RichTextBoxFinds.WholeWord;
            if ((grfOptions & (int)__VSFINDOPTIONS.FR_MatchCase) != 0)
                options |= RichTextBoxFinds.MatchCase;
            if ((grfOptions & (int)__VSFINDOPTIONS.FR_Backwards) != 0)
            {
                options |= RichTextBoxFinds.Reverse;
                reverse = true;
            }

            // Verify if this is a new search
            if (fResetStartPoint != 0
                || forceNewSearch
                || textBox1.SelectionStart != searchCursorLocation)
            {
                forceNewSearch = false;
                currentSearchStart = textBox1.SelectionStart + textBox1.SelectionLength;
                // If our start location is the end of the file, start at the beginging
                if (currentSearchStart == textBox1.Text.Length)
                    currentSearchStart = 0;
                searchCursorLocation = currentSearchStart;
                // Let replace know we are starting from scratch (in case this find is for a replace)
                replaced = false;
            }
            else
            {
                // Continue search
                // Updated search position
                if (forceCursorWrapAround)
                {
                    forceCursorWrapAround = false;
                    // set location to begining of next part to be searched
                    if (reverse)
                        searchCursorLocation = -1; // -1 = end of file
                    else
                        searchCursorLocation = 0;
                }
                else
                {
                    // increment cursor location so we search past the last found item
                    if (reverse)
                        --searchCursorLocation;
                    else
                        ++searchCursorLocation;
                }
            }


            // Compute search range
            // Note that Start < End, even when doing reverse search (-1 = end of file)
            int searchStart = 0;
            int searchEnd = -1;
            // First we search from cursor location.
            // Once we have reached the end of the file,
            // we search until the original start location
            // (we will be called a second time if we return "passed end of file")
            if (reverse)
            {
                searchEnd = searchCursorLocation;
                if (passedEndOfFile)
                    searchStart = currentSearchStart;
            }
            else
            {
                searchStart = searchCursorLocation;
                if (passedEndOfFile)
                    searchEnd = currentSearchStart;
            }

            // Perform actual search
            Debug.WriteLine(string.Format(CultureInfo.CurrentCulture, "About to search from {0}, to {1}", searchStart, searchEnd));
            if (searchStart != searchEnd)
            {
                result = textBox1.Find(pszSearch, searchStart, searchEnd, options);
            }
            else
            {
                result = -1;
            }

            // Set result value
            if (result != -1)
            {
                // We found the string
                pResult = (uint)__VSFINDRESULT.VSFR_Found;
            }
            else
            {
                // If we searched the whole file or this is not a selection search
                if (passedEndOfFile
                    || (grfOptions & (int)__VSFINDOPTIONS.FR_Selection) != 0)
                {
                    // We did not find anything
                    pResult = (uint)__VSFINDRESULT.VSFR_NotFound;
                    passedEndOfFile = false;
                    // if we did replace something before getting here (then this is a replace)
                    if (replaced)
                    {
                        replaced = false;
                        // adjust cursor final position
                        if ((grfOptions & (int)__VSFINDOPTIONS.FR_Backwards) != 0)
                        {
                            if  (textBox1.SelectionStart > 0)
                                textBox1.SelectionStart -= 1;
                        }
                        else if (textBox1.SelectionStart < (textBox1.Text.Length-1))
                            textBox1.SelectionStart += 1;
                    }
                }
                else
                {
                    // We did not find the string, but we reached the end of the file
                    // Let VS know, and we will get called a second time to search the rest of the document
                    pResult = (uint)__VSFINDRESULT.VSFR_EndOfDoc;
                    passedEndOfFile = true;
                    forceCursorWrapAround = true;
                }
            }

            // Save cursor position for next call
            searchCursorLocation = textBox1.SelectionStart;
             * */
            return VSConstants.S_OK;
        }

        /// <summary>
        /// Bring the focus to a specific position in the document
        /// </summary>
        /// <param name="pts">Location where to move the cursor to</param>
        public int NavigateTo(Microsoft.VisualStudio.TextManager.Interop.TextSpan[] pts)
        {
            int hr = VSConstants.S_OK;
            // Activate the window
            IVsWindowFrame frame = (IVsWindowFrame)GetVsService(typeof(SVsWindowFrame));
            if (frame != null)
            {
                hr = frame.Show();
                if (ErrorHandler.Failed(hr))
                    return hr;
            }
            else
                return VSConstants.E_NOTIMPL;
            /*
            // Now navigate to the specified location (if any)
            if (ErrorHandler.Succeeded(hr) && (pts.Length > 0))
            {
                // first set start location
                int newPosition = textBox1.GetCharIndexOfLine(pts[0].iStartLine);
                newPosition += pts[0].iStartIndex;
                if (newPosition > textBox1.Text.Length)
                    newPosition = textBox1.Text.Length;
                textBox1.SelectionStart = newPosition;

                // now set the length of the selection
                newPosition = textBox1.GetCharIndexOfLine(pts[0].iEndLine);
                newPosition += pts[0].iEndIndex;
                if (newPosition > textBox1.Text.Length)
                    newPosition = textBox1.Text.Length;
                int length = newPosition - textBox1.SelectionStart;
                if (length >= 0)
                    textBox1.SelectionLength = newPosition;
                else
                    textBox1.SelectionLength = 0;
            }
             * */
            return hr;
        }

        /// <summary>
        /// Get current cursor location
        /// </summary>
        /// <param name="pts">Current location</param>
        /// <returns>Hresult</returns>
        public int GetCurrentSpan(Microsoft.VisualStudio.TextManager.Interop.TextSpan[] pts)
        {
            Debug.Assert(pts.Length > 0, "Array should not be empty");
            //pts[0].iStartIndex = textBox1.SelectionStart;
            //pts[0].iEndIndex = textBox1.SelectionStart + textBox1.SelectionLength;
            pts[0].iStartLine = 0;
            pts[0].iEndLine = 0;


            return VSConstants.S_OK;
        }

        public int MarkSpan(Microsoft.VisualStudio.TextManager.Interop.TextSpan[] pts)
        {
            return VSConstants.E_NOTIMPL; //"Only IVsTextImage providers implement this method"
        }

        public int Replace(string pszSearch, string pszReplace, uint grfOptions, int fResetStartPoint, IVsFindHelper pHelper, out int pfReplaced)
        {
            pfReplaced = 0;
            /*
            // If the selection is empty, exit
            if ( textBox1.SelectionLength == 0)
            {
                pfReplaced = 0;
                return VSConstants.S_OK;
            }

            // Get the selection
            string sel = textBox1.SelectedText;
            bool ignoreCase = (grfOptions & (int)__VSFINDOPTIONS.FR_MatchCase) == 0;

            // Check if the selection matchs the search
            if ( string.Compare(sel, pszSearch, ignoreCase, CultureInfo.CurrentCulture) == 0 )
            {
                // Recalculate search start position if we make the text longer/shorter
                if (textBox1.SelectionStart <= currentSearchStart)
                {
                    currentSearchStart += pszReplace.Length - sel.Length;
                }
                // Do the actual replace
                textBox1.SelectedText = pszReplace;
                // Adjust position so the next find is done correctly
                if ((grfOptions & (int)__VSFINDOPTIONS.FR_Backwards) != 0)
                {
                    textBox1.SelectionStart -= (pszReplace.Length);
                }
                else
                {
                    textBox1.SelectionStart -= 1;
                }
                searchCursorLocation = textBox1.SelectionStart;

                pfReplaced = 1;
                replaced = true;
            }
            else
            {
                pfReplaced = 0;
            }
            */
            return VSConstants.S_OK;
        }

        /// <summary>
        /// Store an object that will later be returned
        /// </summary>
        /// <returns>The object that is being stored</returns>
        public int SetFindState(object pUnk)
        {
            findState = pUnk;
            return VSConstants.S_OK;
        }


        /// <summary>
        /// This implementation does not use notification
        /// </summary>
        /// <param name="notification"></param>
        public int NotifyFindTarget(uint notification)
        {
            return VSConstants.S_OK;
        }


        /// <summary>
        /// Specify which search option we support.
        /// </summary>
        /// <param name="pfImage">Do we support IVsTextImage?</param>
        /// <param name="pgrfOptions">Supported options</param>
        public int GetCapabilities(bool[] pfImage, uint[] pgrfOptions)
        {
            // We do not support IVsTextImage
            if (pfImage != null && pfImage.Length > 0)
                pfImage[0] = false;

            if (pgrfOptions != null && pgrfOptions.Length > 0)
            {
                pgrfOptions[0] = (uint)__VSFINDOPTIONS.FR_Backwards;
                pgrfOptions[0] |= (uint)__VSFINDOPTIONS.FR_CommonOptions;
                pgrfOptions[0] |= (uint)__VSFINDOPTIONS.FR_Document;
                pgrfOptions[0] |= (uint)__VSFINDOPTIONS.FR_ActionMask;
                pgrfOptions[0] |= (uint)__VSFINDOPTIONS.FR_Plain;
                pgrfOptions[0] |= (uint)__VSFINDOPTIONS.FR_Project;
                pgrfOptions[0] |= (uint)__VSFINDOPTIONS.FR_Solution;
                // Only support selection if something is selected
                //if (textBox1.SelectionLength == 0)
                //    pgrfOptions[0] &= ~((uint)__VSFINDOPTIONS.FR_Selection);
            }

            return VSConstants.S_OK;
        }

        int Microsoft.VisualStudio.TextManager.Interop.IVsFindTarget.GetMatchRect(RECT[] prc)
        {
            return VSConstants.E_NOTIMPL;
        }

        #endregion

        #region IVsDocDataFileChangeControl

        /// <summary>
        /// Called by the shell to notify if a file change must be ignored.
        /// </summary>
        /// <param name="fIgnore">Flag not zero if the file change must be ignored.</param>
        int IVsDocDataFileChangeControl.IgnoreFileChanges(int fIgnore)
        {
            if (0 != fIgnore)
            {
                // The changes must be ignored, so increase the counter of changes to ignore
                ++changesToIgnore;
            }
            else
            {
                if (changesToIgnore > 0)
                {
                    --changesToIgnore;
                }
            }

            return VSConstants.S_OK;
        }

        #endregion

        #region IVsFileChangeEvents

        /// <summary>
        /// Event called when a directory changes.
        /// </summary>
        /// <param name="pszDirectory">Path if the changed directory.</param>
        int IVsFileChangeEvents.DirectoryChanged(string pszDirectory)
        {
            // Do nothing: we are not interested in this event.
            return VSConstants.S_OK;
        }

        /// <summary>
        /// Event called when there are file changes.
        /// </summary>
        /// <param name="cChanges">Number of files changed.</param>
        /// <param name="rgpszFile">Path of the files.</param>
        /// <param name="rggrfChange">Flags with the kind of changes.</param>
        int IVsFileChangeEvents.FilesChanged(uint cChanges, string[] rgpszFile, uint[] rggrfChange)
        {
            // Check the number of changes.
            if (0 == cChanges)
            {
                // Why this event was called if there is no change???
                return VSConstants.E_UNEXPECTED;
            }

            // If the counter of the changes to ignore (set by IVsDocDataFileChangeControl.IgnoreFileChanges)
            // is zero we can process this set of changes, otherwise ignore it.
            if (0 != changesToIgnore)
                return VSConstants.S_OK;

            // Now scan the list of the changed files to find if the one opened in the editor
            // is one of the changed
            for (int i = 0; i < cChanges; ++i)
            {
                if (string.Compare(docPkg.FilePath, rgpszFile[i], true, CultureInfo.InvariantCulture) == 0)
                {
                    // The file opened in the editor is changed.
                    // The first step now is to find the kind of change.
                    uint contentChange = (uint)_VSFILECHANGEFLAGS.VSFILECHG_Size | (uint)_VSFILECHANGEFLAGS.VSFILECHG_Time;
                    if ((rggrfChange[i] & contentChange) != 0)
                    {
                        // The content of the file is changed outside the editor, so we need to
                        // prompt the user for re-load the file. It is possible to have multiple
                        // notification for this change, but we want to prompt the user and reload
                        // the file only once
                        if (reloadTimer.Enabled || isFileReloading)
                        {
                            // The reload is running, so we don't need to start it again.
                            return VSConstants.S_OK;
                        }

                        // Set the timer timeout and start it
                        reloadTimer.Interval = 500;
                        reloadTimer.Enabled = true;
                        reloadTimer.Start();
                    }
                }
            }

            return VSConstants.S_OK;
        }

        #endregion

        #region Package Editor members

        public void CloseFile()
        {
            // clear the tree view
            treeView.Nodes.Clear();

            // clear history
            history.Clear();
            curHistory = null;

            // update command state
            this.buttonBack.Enabled = false;
            this.buttonForward.Enabled = false;
            this.buttonHistory.Enabled = true;

            // close the document
            if (docPkg == null)
                return;
            docPkg.Close();
            docPkg = null;
        }

        public bool OpenFile(string fileName)
        {
            bool result = true;
            // if fileName is null, then this is a reload
            bool reload = false;
            if (string.IsNullOrEmpty(fileName))
            {
                reload = true;
                fileName = docPkg.FilePath;
            }

            // close current file if any
            CloseFile();

            // open the package
            docPkg = new DocumentPackage();
            if (!docPkg.Open(fileName))
            {
                result = false;
            }
            else
            {

                // update the tree
                RefreshTree();

                // reload any open view
                if (reload)
                {
                    ReloadAllViews();
                    IsModified = false;
                }
            }

            return result;
            
        }

        public void RefreshTree()
        {
            // clear the tree view
            treeView.Nodes.Clear();

            if (docPkg == null)
                return;

            PopulateTree(treeView, true);

            if (treeView.TopNode != null)
                treeView.SelectedNode = treeView.TopNode;
        }


        public void PopulateTree(
            TreeView treeView,
            bool fFull    // true == document, folders, parts and relationships; false == just folders and parts
            )
        {
            // clear the tree view
            treeView.Nodes.Clear();

            TreeNode rootNode = null;
            if (fFull)
            {
                // add the root
                rootNode = treeView.Nodes.Add("/", docPkg.FileName, "file", "file");
                rootNode.Tag = docPkg;
            }

            // add the parts
            foreach (KeyValuePair<string, DocumentPart> pair in docPkg.DocParts)
            {
                string path = pair.Value.Path;
                if (path.EndsWith(".rels") && !showXmlRels)
                    continue;

                string[] names = path.Split(new char[] { '/' });
                Debug.Assert(names.Length >= 2);
                if (names.Length < 2)
                    continue;

                string leaf = names[names.Length - 1];
                TreeNodeCollection curNodes = (rootNode != null) ? rootNode.Nodes : treeView.Nodes;

                // make sure all the folders are created
                string curPath = "";
                for (int i = 1; i < names.Length - 1; i++)
                {
                    string name = names[i];
                    curPath += '/' + name;
                    TreeNode[] test = treeView.Nodes.Find(curPath, true);
                    if (test.Length == 0)
                    {
                        TreeNode newNode = curNodes.Add(curPath, name);
                        curNodes = newNode.Nodes;
                    }
                    else
                    {
                        curNodes = test[0].Nodes;
                    }
                }

                // add the leaf
                TreeNode partNode;
                string ext = System.IO.Path.GetExtension(leaf);
                if (KnownPackageInfo.IsXml(ext))
                    partNode = curNodes.Add(path, leaf, "xml", "xml");
                else if (KnownPackageInfo.IsImage(ext))
                    partNode = curNodes.Add(path, leaf, "img", "img");
                else
                    partNode = curNodes.Add(path, leaf, "file", "file");
                partNode.Tag = pair.Value;

                if (fFull)
                {
                    // add the relationships
                    try
                    {
                        PackageRelationshipCollection rels = pair.Value.Part.GetRelationships();
                        foreach (PackageRelationship rel in rels)
                        {
                            TreeNode relNode;
                            if (rel.TargetMode == TargetMode.Internal)
                                relNode = partNode.Nodes.Add(null, rel.TargetUri.ToString(), "rel", "rel");
                            else
                                relNode = partNode.Nodes.Add(null, rel.TargetUri.ToString(), "external_rel", "external_rel");
                            relNode.Tag = rel;
                        }
                    }
                    catch (Exception)
                    {
                    }
                }
            } // next part

            if (fFull)
            {
                // add the root level relationships
                Packaging.Package package = docPkg.Package;
                PackageRelationshipCollection rootRels = package.GetRelationships();
                foreach (PackageRelationship rel in rootRels)
                {
                    TreeNode relNode;
                    if (rel.TargetMode == TargetMode.Internal)
                        relNode = rootNode.Nodes.Add(null, rel.TargetUri.ToString(), "rel", "rel");
                    else
                        relNode = rootNode.Nodes.Add(null, rel.TargetUri.ToString(), "external_rel", "external_rel");
                    relNode.Tag = rel;
                }

                // expand the root node
                rootNode.Expand();
            }
        }

        public ImageList Images
        {
            get
            {
                return this.imageList;
            }
        }

        private void OpenPartEditor(DocumentPart part)
        {
            uint editorFlags = (uint)__VSSPECIFICEDITORFLAGS.VSSPECIFICEDITOR_UseEditor | (uint)__VSSPECIFICEDITORFLAGS.VSSPECIFICEDITOR_DoOpen;
            Guid editorGuid = GuidList.guidPartEditorFactory;
            string physicalView = part.Path; // unique name of xml fragment (physical view must be a unique name).
            Guid logicalViewGuid = VSConstants.LOGVIEWID_Primary;

            string ext = System.IO.Path.GetExtension(physicalView);
            if (!KnownPackageInfo.IsXml(ext) && !KnownPackageInfo.IsText(ext))
            {
                if (MessageBox.Show(
                    this,
                    "Do you want to export the part to a file and then edit it?",
                    AboutForm.AssemblyTitle,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string fileName = ExportPart();
                    if (string.IsNullOrEmpty(fileName))
                        return;

                    VsShellUtilities.OpenDocument(vsServiceProvider, fileName);
                }

                return;
            }

            IntPtr docDataExisting = Marshal.GetIUnknownForObject(this);
            IVsWindowFrame windowFrame;

            IVsHierarchy hierarchy;
            uint itemIdFindAndLock;
            IntPtr docDataFindAndLock;
            uint docCookieFindAndLock;

            int hr = runningDocTable.FindAndLockDocument(
                (uint)_VSRDTFLAGS.RDT_NoLock,
                docPkg.FilePath,
                out hierarchy,
                out itemIdFindAndLock,
                out docDataFindAndLock,
                out docCookieFindAndLock
            );
            if (hr != VSConstants.S_OK)
            {
                Debug.Assert(false, "Couldn't find the current doc!");
                return;
            }

            IVsProject3 project = hierarchy as IVsProject3;

            hr = project.OpenItemWithSpecific(
                itemIdFindAndLock,
                editorFlags,
                ref editorGuid,
                physicalView,
                ref logicalViewGuid,
                docDataExisting,
                out windowFrame);
            if (hr != VSConstants.S_OK)
            {
                Debug.Assert(false, "Couldn't open the part!");
                return;
            }

            Marshal.Release(docDataExisting);

            if (windowFrame != null)
            {
                // Register the window events to a view helper
                PartViewHelper windowFrameEventsHandler = new PartViewHelper(this, windowFrame);
                ErrorHandler.ThrowOnFailure(windowFrame.SetProperty((int)__VSFPROPID.VSFPROPID_ViewHelper, (IVsWindowFrameNotify3)windowFrameEventsHandler));

                windowFrame.Show();
            }
        }

        public bool PartExits(string physicalView)
        {
            return docPkg.DocParts.ContainsKey(physicalView);
        }

        public string GetXml(string physicalView)
        {
            DocumentPart part = docPkg.DocParts[physicalView];
            return part.Text;
        }

        public void UpdateXml(string physicalView, string xml)
        {
            DocumentPart part = docPkg.DocParts[physicalView];
            part.Text = xml;
            docPkg.IsDirty = true;
        }

        public bool IsModified
        {
            get
            {
                return docPkg.IsDirty;
            }
            set
            {
                docPkg.IsDirty = value;
            }
        }

        private void FlushAllViews(bool fClearDirty)
        {
            IVsUIShell uiShell = GetVsService(typeof(SVsUIShell)) as IVsUIShell;

            IEnumWindowFrames windowFramesEnum;
            ErrorHandler.ThrowOnFailure(uiShell.GetDocumentWindowEnum(out windowFramesEnum));
            IVsWindowFrame[] windowFrames = new IVsWindowFrame[1];
            uint fetched;
            while (windowFramesEnum.Next(1, windowFrames, out fetched) == VSConstants.S_OK && fetched == 1)
            {
                IVsWindowFrame windowFrame = windowFrames[0];
                object data;
                if (ErrorHandler.Succeeded(windowFrame.GetProperty((int)__VSFPROPID.VSFPROPID_ViewHelper, out data)) &&
                    data is PartViewHelper)
                {
                    // one of our windows
                    PartViewHelper helper = data as PartViewHelper;
                    if (helper.Editor == this)
                    {
                        // and belongs to this editor instance
                        helper.FlushChanges();
                        if (fClearDirty)
                            helper.IsModified = false;
                    }
                }
            }
        }

        private void CloseView(string physicalView)
        {
            IVsUIShell uiShell = GetVsService(typeof(SVsUIShell)) as IVsUIShell;

            IEnumWindowFrames windowFramesEnum;
            ErrorHandler.ThrowOnFailure(uiShell.GetDocumentWindowEnum(out windowFramesEnum));
            IVsWindowFrame[] windowFrames = new IVsWindowFrame[1];
            uint fetched;
            while (windowFramesEnum.Next(1, windowFrames, out fetched) == VSConstants.S_OK && fetched == 1)
            {
                IVsWindowFrame windowFrame = windowFrames[0];
                object data;
                if (ErrorHandler.Succeeded(windowFrame.GetProperty((int)__VSFPROPID.VSFPROPID_ViewHelper, out data)) &&
                    data is PartViewHelper)
                {
                    // one of our windows
                    PartViewHelper helper = data as PartViewHelper;
                    if (helper.Editor == this && helper.PhysicalView == physicalView)
                    {
                        // and belongs to this editor instance
                        helper.CloseWindow();
                        return;
                    }
                }
            }
        }

        private void ReloadAllViews()
        {
            IVsUIShell uiShell = GetVsService(typeof(SVsUIShell)) as IVsUIShell;

            IEnumWindowFrames windowFramesEnum;
            ErrorHandler.ThrowOnFailure(uiShell.GetDocumentWindowEnum(out windowFramesEnum));
            IVsWindowFrame[] windowFrames = new IVsWindowFrame[1];
            uint fetched;
            while (windowFramesEnum.Next(1, windowFrames, out fetched) == VSConstants.S_OK && fetched == 1)
            {
                IVsWindowFrame windowFrame = windowFrames[0];
                object data;
                if (ErrorHandler.Succeeded(windowFrame.GetProperty((int)__VSFPROPID.VSFPROPID_ViewHelper, out data)) &&
                    data is PartViewHelper)
                {
                    // one of our windows
                    PartViewHelper helper = data as PartViewHelper;
                    if (helper.Editor == this)
                    {
                        // and belongs to this editor instance
                        helper.ReloadView();
                    }
                }
            }
        }

        #endregion

        #region UI Event Handlers

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            ArrayList properties = new ArrayList();

            if (e.Node.Tag is DocumentPart)
            {
                // get the part
                DocumentPart docPart = (DocumentPart)e.Node.Tag;

                properties.Add(docPart);

                if (curHistory == null)
                {
                    // no history yet
                    curHistory = history.AddLast(docPart);
                }
                else
                {
                    // history exists
                    if (curHistory.Value != docPart)
                    {
                        // new part is *not* the current history position
                        LinkedListNode<DocumentPart> last = history.Last;
                        if (curHistory != last)
                        {
                            // remove items from here to the end
                            while (curHistory != last)
                            {
                                history.RemoveLast();
                                last = history.Last;
                            }
                        }
                        curHistory = history.AddLast(docPart);
                    }
                }
                if (history.Count > maxHistory)
                    history.RemoveFirst();

                // update command state
                this.buttonBack.Enabled = (curHistory != history.First);
                this.buttonForward.Enabled = (curHistory != history.Last);
                this.buttonHistory.Enabled = true;

                this.buttonNewFolder.Enabled = false;
                this.buttonAddXmlPart.Enabled = false;
                this.buttonAddImagePart.Enabled = false;
                this.buttonAddInternalRel.Enabled = true;
                this.buttonAddExternalRel.Enabled = true;
                this.buttonProps.Enabled = true;
                this.buttonImport.Enabled = true;
                this.buttonExport.Enabled = true;
                this.buttonEditPart.Enabled = true;
                this.buttonDeletePart.Enabled = true;

                this.treeView.ContextMenuStrip = this.contextMenuPart;
            }
            else if (e.Node.Tag is PackageRelationship)
            {
                PackageRelationship rel = e.Node.Tag as PackageRelationship;
                DocumentRelationship docRel = new DocumentRelationship(rel);
                properties.Add(docRel);

                // update command state
                this.buttonNewFolder.Enabled = false;
                this.buttonAddXmlPart.Enabled = false;
                this.buttonAddImagePart.Enabled = false;
                this.buttonAddInternalRel.Enabled = false;
                this.buttonAddExternalRel.Enabled = false;
                this.buttonProps.Enabled = true;
                this.buttonImport.Enabled = false;
                this.buttonExport.Enabled = false;
                this.buttonEditPart.Enabled = false;
                this.buttonDeletePart.Enabled = true;

                this.treeView.ContextMenuStrip = this.contextMenuRel;
            }
            else if (e.Node.Tag is DocumentPackage)
            {
                DocumentPackage doc = e.Node.Tag as DocumentPackage;
                properties.Add(doc);

                // update command state
                this.buttonNewFolder.Enabled = true;
                this.buttonAddXmlPart.Enabled = true;
                this.buttonAddImagePart.Enabled = true;
                this.buttonAddInternalRel.Enabled = true;
                this.buttonAddExternalRel.Enabled = true;
                this.buttonProps.Enabled = true;
                this.buttonImport.Enabled = false;
                this.buttonExport.Enabled = false;
                this.buttonEditPart.Enabled = false;
                this.buttonDeletePart.Enabled = false;

                this.treeView.ContextMenuStrip = this.contextMenuDoc;
            }
            else // folder
            {
                // update command state
                this.buttonNewFolder.Enabled = true;
                this.buttonAddXmlPart.Enabled = true;
                this.buttonAddImagePart.Enabled = true;
                this.buttonAddInternalRel.Enabled = false;
                this.buttonAddExternalRel.Enabled = false;
                this.buttonProps.Enabled = false;
                this.buttonImport.Enabled = false;
                this.buttonExport.Enabled = false;
                this.buttonEditPart.Enabled = false;
                this.buttonDeletePart.Enabled = true;

                this.treeView.ContextMenuStrip = this.contextMenuFolder;
            }

            // update the Properties Window
            selContainer = new SelectionContainer(false, false);
            selContainer.SelectableObjects = properties;
            selContainer.SelectedObjects = properties;

            ITrackSelection track = TrackSelection;
            if (track != null)
                track.OnSelectChange((ISelectionContainer)selContainer);
        }

        private bool OpenTreeViewNode(TreeNode curNode, bool toggle)
        {
            if (curNode.Tag is PackageRelationship)
            {
                PackageRelationship rel = (PackageRelationship)curNode.Tag;
                if (rel.TargetMode == TargetMode.Internal)
                {
                    Uri target = System.IO.Packaging.PackUriHelper.ResolvePartUri(rel.SourceUri, rel.TargetUri);
                    DocumentPart docPart = docPkg.DocParts[target.ToString()];
                    Debug.Assert(docPart != null);
                    if (docPart != null)
                    {
                        TreeNode[] nodes = treeView.Nodes.Find(docPart.Path, true);
                        Debug.Assert(nodes.Length == 1);
                        if (nodes.Length > 0)
                        {
                            TreeNode node = nodes[0];
                            treeView.SelectedNode = node;
                        }
                    }
                }
                else
                {
                    // follow external link
                    if (MessageBox.Show(
                        this,
                        "Are you sure you want to follow this external link?",
                        AboutForm.AssemblyTitle,
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start(rel.TargetUri.ToString());
                    }
                }
                return true;
            }
            else if (curNode.Tag is DocumentPart)
            {
                DocumentPart part = (DocumentPart)curNode.Tag;
                OpenPartEditor(part);
                return true;
            }
            else if ((curNode.Tag is DocumentPackage || curNode.Tag == null) && toggle)
            {
                // folder or document
                curNode.Toggle();
                return true;
            }
            return false;
        }

        private void treeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            OpenTreeViewNode(e.Node, false);
        }

        void treeView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Enter pressed
                if (OpenTreeViewNode(treeView.SelectedNode, true))
                    e.Handled = true;
            }
            else if (e.KeyCode == Keys.Delete)
            {
                DeleteNode();
                e.Handled = true;
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (curHistory == null || history.First == curHistory)
            {
                Debug.Assert(true, "buttonBack button shouldn't be enabled");
                return;
            }

            // decrement history
            curHistory = curHistory.Previous;
            DocumentPart docPart = curHistory.Value;

            // select the new part
            TreeNode[] nodes = treeView.Nodes.Find(docPart.Path, true);
            Debug.Assert(nodes.Length == 1);
            if (nodes.Length > 0)
            {
                TreeNode node = nodes[0];
                treeView.SelectedNode = node;
            }

            // update command states
            this.buttonBack.Enabled = (curHistory != history.First);
            this.buttonForward.Enabled = (curHistory != history.Last);
            this.buttonHistory.Enabled = true;
        }

        private void buttonForward_Click(object sender, EventArgs e)
        {
            if (curHistory == null || history.Last == curHistory)
            {
                Debug.Assert(true, "buttonForward button shouldn't be enabled");
                return;
            }

            // increment history
            curHistory = curHistory.Next;
            DocumentPart docPart = curHistory.Value;

            // select the new part
            TreeNode[] nodes = treeView.Nodes.Find(docPart.Path, true);
            Debug.Assert(nodes.Length == 1);
            if (nodes.Length > 0)
            {
                TreeNode node = nodes[0];
                treeView.SelectedNode = node;
            }

            // update command states
            this.buttonBack.Enabled = (curHistory != history.First);
            this.buttonForward.Enabled = (curHistory != history.Last);
            this.buttonHistory.Enabled = true;
        }

        void buttonHistory_DropDownOpening(object sender, System.EventArgs e)
        {
            buttonHistory.DropDownItems.Clear();
            LinkedListNode<DocumentPart> node = history.First;
            while (node != null)
            {
                ToolStripMenuItem menuItem = (ToolStripMenuItem)buttonHistory.DropDownItems.Add(node.Value.Path);
                menuItem.Tag = node;
                if (node == curHistory)
                    menuItem.Checked = true;
                node = node.Next;
            }
        }

        void buttonHistory_DropDownItemClicked(object sender, System.Windows.Forms.ToolStripItemClickedEventArgs e)
        {
            // reposition the history
            curHistory = (LinkedListNode<DocumentPart>)e.ClickedItem.Tag;
            DocumentPart docPart = curHistory.Value;

            // update command state
            this.buttonBack.Enabled = (curHistory != history.First);
            this.buttonForward.Enabled = (curHistory != history.Last);
            this.buttonHistory.Enabled = true;

            // select the new part
            TreeNode[] nodes = treeView.Nodes.Find(docPart.Path, true);
            Debug.Assert(nodes.Length == 1);
            if (nodes.Length > 0)
            {
                TreeNode node = nodes[0];
                treeView.SelectedNode = node;
            }
        }

        private void buttonNewFolder_Click(object sender, EventArgs e)
        {
            NewFolderDialog dialog = new NewFolderDialog();
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                string path;
                if (curHistory == null || curHistory.Value == null)
                    path = "/" + dialog.FolderName;
                else
                    path = curHistory.Value.Path + "/" + dialog.FolderName;
                TreeNode newNode = treeView.SelectedNode.Nodes.Add(path, dialog.FolderName);
                treeView.SelectedNode = newNode;
            }
        }

        private void AddPart(bool disableImport)
        {
            Debug.Assert(
                treeView.SelectedNode.Tag == null || treeView.SelectedNode.Tag is DocumentPackage,
                "Current node must be a folder node or document node");

            NewPartDialog dialog = new NewPartDialog(disableImport);
            if (dialog.ShowDialog(this) != DialogResult.OK)
                return;

            try
            {
                // build the path for the new part
                string path = treeView.SelectedNode.FullPath; // will include root file name
                int ix = path.IndexOf('/');
                if (ix > 0)
                    path = path.Substring(ix) + "/" + dialog.PartName;
                else
                    path = "/" + dialog.PartName;
                Uri fileUri = new Uri(path, UriKind.RelativeOrAbsolute);

                // create the part
                PackagePart part = docPkg.Package.CreatePart(fileUri, dialog.ContentType, dialog.Compress);

                // load the new part's stream
                if (dialog.ImportFile.Length > 0)
                {
                    Stream fileStream = new FileStream(dialog.ImportFile, FileMode.Open, FileAccess.Read);
                    byte[] fileBytes = new byte[fileStream.Length];
                    fileStream.Read(fileBytes, 0, fileBytes.Length);
                    fileStream.Close();

                    Stream partStream = part.GetStream();
                    partStream.Write(fileBytes, 0, fileBytes.Length);
                    partStream.Close();
                }

                // TODO: workaround for a WinFX problem.  Retest with later versions

                // referesh the package and tree
                part = null;
                curHistory = null;
                history.Clear();
                treeView.Nodes.Clear();
                docPkg.ReloadFromMemory();
                RefreshTree();

                // select the newly added tree node
                DocumentPart docPart = docPkg.DocParts[path];
                Debug.Assert(docPart != null);
                if (docPart != null)
                {
                    TreeNode[] nodes = treeView.Nodes.Find(docPart.Path, true);
                    Debug.Assert(nodes.Length == 1);
                    if (nodes.Length > 0)
                    {
                        TreeNode node = nodes[0];
                        treeView.SelectedNode = node;
                    }
                }

                /* should work, but can corrupt the [Content_Types].xml part
                 * 
                DocumentPart docPart = new DocumentPart(part);
                docPkg.DocParts.Add(docPart.Path, docPart);

                // add the leaf
                TreeNode partNode;
                string ext = System.IO.Path.GetExtension(docPart.Name);
                if (OfficePackageInfo.IsXml(ext))
                    partNode = treeView.SelectedNode.Nodes.Add(docPart.Path, docPart.Name, "xml", "xml");
                else if (OfficePackageInfo.IsImage(ext))
                    partNode = treeView.SelectedNode.Nodes.Add(docPart.Path, docPart.Name, "img", "img");
                else
                    partNode = treeView.SelectedNode.Nodes.Add(docPart.Path, docPart.Name, "file", "file");
                partNode.Tag = docPart;

                partNode.EnsureVisible();
                treeView.SelectedNode = partNode;
                */

                docPkg.IsDirty = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(
                    this,
                    "Error adding the new part:\r\n" + e.Message,
                    AboutForm.AssemblyTitle,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void buttonAddXmlPart_Click(object sender, EventArgs e)
        {
            AddPart(true);
        }

        private void buttonAddImagePart_Click(object sender, EventArgs e)
        {
            AddPart(false);
        }

        private void buttonAddInternalRel_Click(object sender, EventArgs e)
        {
            Debug.Assert(
                treeView.SelectedNode.Tag is DocumentPart || treeView.SelectedNode.Tag is DocumentPackage,
                "Current node must be a part or document node");

            NewInternalRelationshipDialog dialog = new NewInternalRelationshipDialog(this);
            if (dialog.ShowDialog(this) != DialogResult.OK)
                return;

            try
            {
                PackageRelationship rel;
                if (treeView.SelectedNode.Tag is DocumentPart)
                {
                    DocumentPart docPart = treeView.SelectedNode.Tag as DocumentPart;

                    Uri targetUri;
                    if (dialog.TargetKind == UriKind.Relative)
                        targetUri = System.IO.Packaging.PackUriHelper.GetRelativeUri(docPart.Part.Uri, dialog.Target.Part.Uri);
                    else
                        targetUri = dialog.Target.Part.Uri;

                    if (dialog.Id.Length > 0)
                        rel = docPart.Part.CreateRelationship(targetUri, TargetMode.Internal, dialog.RelType, dialog.Id);
                    else
                        rel = docPart.Part.CreateRelationship(targetUri, TargetMode.Internal, dialog.RelType); // auto id
                }
                else if (treeView.SelectedNode.Tag is DocumentPackage)
                {
                    DocumentPackage doc = treeView.SelectedNode.Tag as DocumentPackage;

                    Uri targetUri;
                    if (dialog.TargetKind == UriKind.Relative)
                        targetUri = new Uri(dialog.Target.Path.TrimStart('/'), UriKind.Relative);
                    else
                        targetUri = dialog.Target.Part.Uri;

                    if (dialog.Id.Length > 0)
                        rel = doc.Package.CreateRelationship(targetUri, TargetMode.Internal, dialog.RelType, dialog.Id);
                    else
                        rel = doc.Package.CreateRelationship(targetUri, TargetMode.Internal, dialog.RelType); // auto id
                }
                else
                    throw new Exception("You may only add relationships to the document root or to a part.");

                // TODO: workaround for a WinFX problem.  Retest with later versions

                // remember the currently selelcted node.
                string path = treeView.SelectedNode.FullPath; // will include root file name
                int ix = path.IndexOf('/');
                if (ix > 0)
                    path = path.Substring(ix);
                else
                    path = null;

                // referesh the package and tree
                rel = null;
                curHistory = null;
                history.Clear();
                treeView.Nodes.Clear();
                docPkg.ReloadFromMemory();
                RefreshTree();

                // reselect the previously selected tree node
                if (path != null)
                {
                    DocumentPart docPart = docPkg.DocParts[path];
                    Debug.Assert(docPart != null);
                    if (docPart != null)
                    {
                        TreeNode[] nodes = treeView.Nodes.Find(docPart.Path, true);
                        Debug.Assert(nodes.Length == 1);
                        if (nodes.Length > 0)
                        {
                            TreeNode node = nodes[0];
                            treeView.SelectedNode = node;
                            node.Expand();
                        }
                    }
                }

                /* should work, but leaves .rels corrupted
                TreeNode relNode;
                relNode = treeView.SelectedNode.Nodes.Add(null, rel.TargetUri.ToString(), "rel", "rel");
                relNode.Tag = rel;

                relNode.EnsureVisible();
                treeView.SelectedNode = relNode;
                */

                docPkg.IsDirty = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    this,
                    "Error adding the new relationship:\r\n" + ex.Message,
                    AboutForm.AssemblyTitle,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void buttonAddExternalRel_Click(object sender, EventArgs e)
        {
            Debug.Assert(
                treeView.SelectedNode.Tag is DocumentPart || treeView.SelectedNode.Tag is DocumentPackage,
                "Current node must be a part or document node");

            NewExternalRelationshipDialog dialog = new NewExternalRelationshipDialog(this);
            if (dialog.ShowDialog(this) != DialogResult.OK)
                return;

            try
            {
                Uri target = new Uri(dialog.Target, UriKind.RelativeOrAbsolute);
                PackageRelationship rel;
                if (treeView.SelectedNode.Tag is DocumentPart)
                {
                    DocumentPart docPart = treeView.SelectedNode.Tag as DocumentPart;
                    if (dialog.Id.Length > 0)
                        rel = docPart.Part.CreateRelationship(target, TargetMode.External, dialog.RelType, dialog.Id);
                    else
                        rel = docPart.Part.CreateRelationship(target, TargetMode.External, dialog.RelType); // auto id
                }
                else if (treeView.SelectedNode.Tag is DocumentPackage)
                {
                    DocumentPackage doc = treeView.SelectedNode.Tag as DocumentPackage;
                    if (dialog.Id.Length > 0)
                        rel = doc.Package.CreateRelationship(target, TargetMode.External, dialog.RelType, dialog.Id);
                    else
                        rel = doc.Package.CreateRelationship(target, TargetMode.External, dialog.RelType); // auto id
                }
                else
                    throw new Exception("You may only add relationships to the document root or to a part.");

                // TODO: workaround for a WinFX problem.  Retest with later versions

                // remember the currently selelcted node.
                string path = treeView.SelectedNode.FullPath; // will include root file name
                int ix = path.IndexOf('/');
                if (ix > 0)
                    path = path.Substring(ix);
                else
                    path = null;

                // referesh the package and tree
                rel = null;
                curHistory = null;
                history.Clear();
                treeView.Nodes.Clear();
                docPkg.ReloadFromMemory();
                RefreshTree();

                // reselect the previously selected tree node
                if (path != null)
                {
                    DocumentPart docPart = docPkg.DocParts[path];
                    Debug.Assert(docPart != null);
                    if (docPart != null)
                    {
                        TreeNode[] nodes = treeView.Nodes.Find(docPart.Path, true);
                        Debug.Assert(nodes.Length == 1);
                        if (nodes.Length > 0)
                        {
                            TreeNode node = nodes[0];
                            treeView.SelectedNode = node;
                            node.Expand();
                        }
                    }
                }

                /* should work, but leaves .rels corrupted
                TreeNode relNode;
                relNode = treeView.SelectedNode.Nodes.Add(null, rel.TargetUri.ToString(), "external_rel", "external_rel");
                relNode.Tag = rel;

                relNode.EnsureVisible();
                treeView.SelectedNode = relNode;
                */

                docPkg.IsDirty = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    this,
                    "Error adding the new relationship:\r\n" + ex.Message,
                    AboutForm.AssemblyTitle,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void buttonProps_Click(object sender, EventArgs e)
        {
            IVsUIShell vsUIService = (IVsUIShell)GetVsService(typeof(IVsUIShell));

            if (vsUIService != null)
            {
                IVsWindowFrame toolFrame = null;
                Guid propertyBrowserGuid = System.ComponentModel.Design.StandardToolWindows.PropertyBrowser;
                int hr = vsUIService.FindToolWindow(0, ref propertyBrowserGuid,
                    out toolFrame);

                if (toolFrame != null)
                {
                    toolFrame.Show();
                }
                else
                {
                    // FindToolWindow fails sometimes if the property window is collapsed.
                    // Fire the PROPPAGE command key instead.
                    EnvDTE.DTE dte = (EnvDTE.DTE)GetVsService(typeof(EnvDTE._DTE));
                    if (dte != null)
                        dte.ExecuteCommand("View.PropertiesWindow", "");
                }
            }
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            TreeNode node = this.treeView.SelectedNode;
            if (node == null || !(node.Tag is DocumentPart))
                return;

            DocumentPart docPart = node.Tag as DocumentPart;

            if (this.importFileDialog.ShowDialog(this) != DialogResult.OK)
                return;

            try
            {
                // load the new part's stream
                Stream fileStream = new FileStream(this.importFileDialog.FileName, FileMode.Open, FileAccess.Read);
                byte[] fileBytes = new byte[fileStream.Length];
                fileStream.Read(fileBytes, 0, fileBytes.Length);
                fileStream.Close();

                Stream partStream = docPart.Part.GetStream();
                partStream.Seek(0, SeekOrigin.Begin);
                partStream.Write(fileBytes, 0, fileBytes.Length);
                partStream.SetLength(fileBytes.Length);
                partStream.Close();

                docPkg.Package.Flush();
                docPkg.IsDirty = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    this,
                    "Error importing:\r\n" + ex.Message,
                    AboutForm.AssemblyTitle,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private string ExportPart()
        {
            TreeNode node = this.treeView.SelectedNode;
            if (node == null || !(node.Tag is DocumentPart))
                return null;

            DocumentPart docPart = node.Tag as DocumentPart;

            this.exportFileDialog.FileName = docPart.Name;

            if (this.exportFileDialog.ShowDialog(this) != DialogResult.OK)
                return null;

            try
            {
                Stream partStream = docPart.Part.GetStream();
                byte[] fileBytes = new byte[partStream.Length];
                partStream.Read(fileBytes, 0, fileBytes.Length);
                partStream.Close();

                FileStream fileStream = new FileStream(this.exportFileDialog.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                fileStream.Seek(0, SeekOrigin.Begin);
                fileStream.Write(fileBytes, 0, fileBytes.Length);
                fileStream.SetLength(fileBytes.Length);
                fileStream.Flush();
                fileStream.Close();

                return this.exportFileDialog.FileName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    this,
                    "Error exporting:\r\n" + ex.Message,
                    AboutForm.AssemblyTitle,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            return null;
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            ExportPart();
        }

        private void buttonEditPart_Click(object sender, EventArgs e)
        {
            TreeNode node = this.treeView.SelectedNode;
            OpenTreeViewNode(node, false);
        }

        private void DeleteNode()
        {
            TreeNode node = this.treeView.SelectedNode;
            if (node == null)
                return;

            if (node.Nodes.Count > 0)
            {
                MessageBox.Show(
                    this,
                    "Delete all the children of a node before deleting the node",
                    AboutForm.AssemblyTitle,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show(
                this,
                "Are you sure you want to delete this node?",
                AboutForm.AssemblyTitle,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            if (node.Tag is DocumentPart)
            {
                // delete a part
                DocumentPart part = node.Tag as DocumentPart;

                // make sure any open view is closed
                CloseView(part.Path);

                docPkg.Package.DeletePart(part.Part.Uri);

                curHistory = null;
                history.Clear();

                if (node.Parent != null)
                    treeView.SelectedNode = node.Parent;
                node.Remove();
            }
            else if (node.Tag is PackageRelationship)
            {
                // delete a relationshiop
                PackageRelationship rel = node.Tag as PackageRelationship;
                string id = rel.Id;

                if (node.Parent != null)
                    treeView.SelectedNode = node.Parent;
                node.Remove();

                if (treeView.SelectedNode.Tag is DocumentPart)
                {
                    // source is a part
                    DocumentPart docPart = treeView.SelectedNode.Tag as DocumentPart;
                    Debug.Assert(docPart.Part.RelationshipExists(id));
                    docPart.Part.DeleteRelationship(id);
                    Debug.Assert(!docPart.Part.RelationshipExists(id));
                }
                else if (treeView.SelectedNode.Tag is DocumentPackage)
                {
                    // source is the doc
                    Debug.Assert(docPkg.Package.RelationshipExists(id));
                    docPkg.Package.DeleteRelationship(id);
                    Debug.Assert(!docPkg.Package.RelationshipExists(id));
                }
            }
            else if (node.Tag is DocumentPackage)
            {
                // delete the document root.  Not possible.
                Debug.Assert(false, "Should not reach");
                return;
            }
            else
            {
                // delete a folder
                if (node.Parent != null)
                    treeView.SelectedNode = node.Parent;
                node.Remove();
                return;
            }

            // TODO: workaround for a WinFX problem.  Retest with later versions

            // remember the currently selelcted node.
            string path = treeView.SelectedNode.FullPath; // will include root file name
            int ix = path.IndexOf('/');
            if (ix > 0)
                path = path.Substring(ix);
            else
                path = null;

            // referesh the package and tree
            curHistory = null;
            history.Clear();
            treeView.Nodes.Clear();
            docPkg.ReloadFromMemory();
            RefreshTree();

            // reselect the previously selected tree node
            if (path != null)
            {
                if (docPkg.DocParts.ContainsKey(path))
                {
                    DocumentPart docPart = docPkg.DocParts[path];
                    Debug.Assert(docPart != null);
                    if (docPart != null)
                    {
                        TreeNode[] nodes = treeView.Nodes.Find(docPart.Path, true);
                        Debug.Assert(nodes.Length == 1);
                        if (nodes.Length > 0)
                        {
                            node = nodes[0];
                            treeView.SelectedNode = node;
                            node.Expand();
                        }
                    }
                }
            }

            docPkg.IsDirty = true;
        }

        private void buttonDeletePart_Click(object sender, EventArgs e)
        {
            DeleteNode();
        }

        private void buttonShowRels_Click(object sender, EventArgs e)
        {
            showXmlRels = !showXmlRels;
            buttonShowRels.Checked = showXmlRels;
            curHistory = null;
            history.Clear();
            RefreshTree();
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            AboutForm dlg = new AboutForm();
            dlg.ShowDialog(this);
        }

        #endregion

        internal static class NativeMethods
        {
            // We need this Win32 function to find out if the shell has the focus.
            [DllImport("user32.Dll")]
            static public extern int GetActiveWindow();
        }

        private void treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                treeView.SelectedNode = e.Node;
            }
        }
    }
}
