/****************************************************************************

    PartViewHelper.cs

    View helper object for the Part XML Editor windows.

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
using Microsoft.VisualStudio;
using Microsoft.VisualStudio.TextManager.Interop;
using Microsoft.VisualStudio.Shell.Interop;
using Microsoft.VisualStudio.OLE.Interop;
using System.Runtime.InteropServices;

namespace Microsoft.OpenXMLEditor
{
    class PartViewHelper :    IVsWindowFrameNotify3,
                            IVsTextLinesEvents
    {
        #region Members

        private IVsWindowFrame windowFrame;
        private PackageEditorPane editor;
        private IVsTextLines textLines;

        private uint textLinesEventsCookie;
        // private uint finalTextChangeCommitEventsCookie; // Is this used now?
        private bool justOpened;
        private bool starred;
        
        #endregion Members

        #region Constructors

        public PartViewHelper(PackageEditorPane editor, IVsWindowFrame windowFrame)
        {
            this.windowFrame = windowFrame;
            this.editor = editor;
            justOpened = true;

            object data;
            ErrorHandler.ThrowOnFailure(windowFrame.GetProperty((int)__VSFPROPID.VSFPROPID_DocData, out data));
            textLines = (IVsTextLines)data;

            AdviseTextLinesEvents(true);

        }
        
        #endregion Constructors

        #region Properties

        private string BufferContents
        {
            get
            {
                int lineCount;
                int lengthOfLast;
                string bufferText = string.Empty;

                ErrorHandler.ThrowOnFailure(
                    this.textLines.GetLineCount(out lineCount)
                );

                if (lineCount > 0)
                {
                    ErrorHandler.ThrowOnFailure(
                        this.textLines.GetLengthOfLine(lineCount - 1, out lengthOfLast)
                    );

                    ErrorHandler.ThrowOnFailure(
                        this.textLines.GetLineText(0, 0, lineCount - 1, lengthOfLast, out bufferText)
                    );
                }
                return bufferText;
            }
            set
            {
                int lastLine;
                int lastColumn;
                Microsoft.VisualStudio.ErrorHandler.ThrowOnFailure(
                    textLines.GetLastLineIndex(out lastLine, out lastColumn));

                // Lock the buffer before changing its content.
                Microsoft.VisualStudio.ErrorHandler.ThrowOnFailure(
                    textLines.LockBuffer());
                try
                {
                    GCHandle handle = GCHandle.Alloc(value, GCHandleType.Pinned);
                    try
                    {
                        TextSpan[] span = new TextSpan[1];
                        Microsoft.VisualStudio.ErrorHandler.ThrowOnFailure(
                            textLines.ReplaceLines(0, 0, lastLine, lastColumn, handle.AddrOfPinnedObject(), value.Length, span));
                    }
                    finally
                    {
                        handle.Free();
                    }
                }
                finally
                {
                    Microsoft.VisualStudio.ErrorHandler.ThrowOnFailure(
                        textLines.UnlockBuffer());
                }
            }
        }

        public bool IsModified
        {
            get
            {
                uint flags;
                ErrorHandler.ThrowOnFailure(this.textLines.GetStateFlags(out flags));
                return (flags & (uint)BUFFERSTATEFLAGS.BSF_MODIFIED) != 0;
            }
            set
            {
                uint flags = 0;
                ErrorHandler.ThrowOnFailure(textLines.GetStateFlags(out flags));
                bool fStar = (flags & (uint)BUFFERSTATEFLAGS.BSF_MODIFIED) != 0;
                if (fStar != value)
                {
                    if (value)
                        flags |= (uint)BUFFERSTATEFLAGS.BSF_MODIFIED;
                    else
                        flags &= ~(uint)BUFFERSTATEFLAGS.BSF_MODIFIED;
                    ErrorHandler.ThrowOnFailure(textLines.SetStateFlags(flags));
                    UpdateStar(value);
                }
            }
        }

        private static bool HasToSave(uint pgrfSaveOptions)
        {
            return pgrfSaveOptions == (uint)__FRAMECLOSE.FRAMECLOSE_SaveIfDirty || pgrfSaveOptions == (uint)__FRAMECLOSE.FRAMECLOSE_PromptSave;
        }

        public string PhysicalView
        {
            get
            {
                object obj;
                if (ErrorHandler.Succeeded(this.windowFrame.GetProperty((int)__VSFPROPID.VSFPROPID_pszPhysicalView, out obj)))
                    return obj as string;
                return null;
            }
        }

        public PackageEditorPane Editor
        {
            get
            {
                return editor;
            }
        }
        
        #endregion Properties

        #region Methods

        public void CloseWindow()
        {
            this.windowFrame.CloseFrame((uint)__FRAMECLOSE.FRAMECLOSE_SaveIfDirty);
        }

        public void ReloadView()
        {
            if (!this.editor.PartExits(PhysicalView))
            {
                this.IsModified = false;
                CloseWindow();
                return;
            }
            BufferContents = this.editor.GetXml(PhysicalView);
            this.IsModified = false;
        }

        public void FlushChanges()
        {
            if (!this.IsModified)
                return;
            this.editor.UpdateXml(PhysicalView, BufferContents);
        }

        public void Show()
        {
            ErrorHandler.ThrowOnFailure(
                windowFrame.Show()
            );
        }

        private void Cleanup()
        {
            AdviseTextLinesEvents(false);
        }

        private void AdviseTextLinesEvents(bool subscribe)
        {
            IConnectionPointContainer conPtCont;
            conPtCont = (IConnectionPointContainer)textLines;
            if (conPtCont != null)
            {
                IConnectionPoint conPt;
                Guid iidConPt = typeof(IVsTextLinesEvents).GUID;
                conPtCont.FindConnectionPoint(ref iidConPt, out conPt);
                if (subscribe)
                {
                    conPt.Advise((IVsTextLinesEvents)this, out textLinesEventsCookie);
                }
                else
                {
                    // If the goal is to unsubscribe, but there is no subscription active, exit.
                    if (textLinesEventsCookie == VSConstants.VSCOOKIE_NIL)
                        return;
                    conPt.Unadvise(textLinesEventsCookie);
                    textLinesEventsCookie = VSConstants.VSCOOKIE_NIL;
                }
            }
        }

        private void UpdateStar(bool fStar)
        {
            object editorCaptionObject;
            ErrorHandler.ThrowOnFailure(
                this.windowFrame.GetProperty((int)__VSFPROPID.VSFPROPID_EditorCaption, out editorCaptionObject)
            );

            string editorCaption = (string)editorCaptionObject;
            if (fStar)
            {
                // add dirty star, if not already there.
                if (editorCaption.Length > 0 && '*' != editorCaption[editorCaption.Length - 1])
                {
                    editorCaption += "*";
                    ErrorHandler.ThrowOnFailure(this.windowFrame.SetProperty((int)__VSFPROPID.VSFPROPID_EditorCaption, editorCaption));
                }

                // also dirty the parent editor
                editor.IsModified = true;
            }
            else
            {
                // remove dirty star if it is present
                if (editorCaption.Length > 0 && '*' == editorCaption[editorCaption.Length - 1])
                {
                    editorCaption = editorCaption.Remove(editorCaption.Length - 1);
                    ErrorHandler.ThrowOnFailure(this.windowFrame.SetProperty((int)__VSFPROPID.VSFPROPID_EditorCaption, editorCaption));
                }
            }

            starred = fStar;
        }
        
        #endregion Methods

        #region IVsWindowFrameNotify3

        public int OnDockableChange(int fDockable, int x, int y, int w, int h)
        {
            return VSConstants.S_OK;
        }

        public int OnMove(int x, int y, int w, int h)
        {
            return VSConstants.S_OK;
        }

        public int OnShow(int fShow)
        {
            return VSConstants.S_OK;
        }

        public int OnSize(int x, int y, int w, int h)
        {
            return VSConstants.S_OK;
        }

        public int OnClose(ref uint pgrfSaveOptions)
        {
            //if (HasToSave(pgrfSaveOptions))
            this.FlushChanges();
            this.Cleanup();
            return VSConstants.S_OK;
        }

        #endregion IVsWindowFrameNotify3

        #region IVsTextLinesEvents

        void IVsTextLinesEvents.OnChangeLineAttributes(int iFirstLine, int iLastLine)
        {
        }

        void IVsTextLinesEvents.OnChangeLineText(Microsoft.VisualStudio.TextManager.Interop.TextLineChange[] pTextLineChange, int fLast)
        {
            if (justOpened)
            {
                justOpened = false;
                string buffer;
                if (pTextLineChange.Length == 1 && ErrorHandler.Succeeded(this.textLines.GetLineText(
                        pTextLineChange[0].iStartLine, pTextLineChange[0].iStartIndex,
                        pTextLineChange[0].iNewEndLine, pTextLineChange[0].iNewEndIndex, out buffer)))
                {
                    // Just opening the editor dirties the buffer and triggers this event *if* the 
                    // <?xml encoding=""?> attribute doesn't match the actual encoding of the buffer
                    // (van vary only by case such as "UTF-8" versus "utf-8").
                    try
                    {
                        // test to see if the buffer change was the encoding string
                        Encoding dummy = Encoding.GetEncoding(buffer);
                        // succeeded, so clear the dirty flag
                        IsModified = false;
                        return;
                    }
                    catch
                    {
                        // buffer wasn't an encoding string, so ignore it.
                    }
                }
            }
            bool starred = IsModified;
            if (starred != this.starred)
                UpdateStar(starred);
            // [This code is present in .NET Reflector version from shipping binary]
            this.FlushChanges();
        }

        #endregion

    } // end class
} // end namespace
