using Microsoft.VisualStudio;
using Microsoft.VisualStudio.OLE.Interop;
using Microsoft.VisualStudio.Shell.Interop;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml;
using System.Diagnostics;

namespace Microsoft.Grail
{
	[ComVisible(true), Guid("DDE101F3-D1E4-42ab-A1E9-1DD89994DFC8")]
	public class PropertyPage : 
		Microsoft.VisualStudio.Shell.LocalizableProperties,
		IPropertyPage
	{
		#region fields
		private Panel panel;
		private bool active;
		private bool dirty = false;
		private IPropertyPageSite site;
		private string name;
		#endregion

		#region properties

		[Browsable(false)]
		public string Name
		{
			get 
			{ 
				return this.name; 
			}
			set
			{
				this.name = value;
			}
		}

		protected Panel ThePanel
		{
			get
			{
				return this.panel;
			}
		}
		#endregion

		#region public methods

		#endregion

		#region IPropertyPage methods.
		public virtual void Activate(IntPtr parent, RECT[] pRect, int bModal)
		{
			if (this.panel == null)
			{
				this.panel = new Panel();
				this.panel.Size = new Size(pRect[0].right - pRect[0].left, pRect[0].bottom - pRect[0].top);
				this.panel.Text = "Settings";// TODO localization
				this.panel.Visible = false;
				this.panel.Size = new Size(550, 300);
				this.panel.CreateControl();
				//NativeMethods.SetParent(this.panel.Handle, parent);
			}
		}

		public virtual int Apply()
		{
			return VSConstants.S_OK;
		}

		public virtual void Deactivate()
		{
			this.panel.Dispose();
			this.active = false;
		}

		public virtual void GetPageInfo(PROPPAGEINFO[] arrInfo)
		{
			PROPPAGEINFO info = new PROPPAGEINFO();

			info.cb = (uint)Marshal.SizeOf(typeof(PROPPAGEINFO));
			info.dwHelpContext = 0;
			info.pszDocString = null;
			info.pszHelpFile = null;
			info.pszTitle = this.name;
			info.SIZE.cx = 550;
			info.SIZE.cy = 300;
			arrInfo[0] = info;
		}

		public virtual void Help(string helpDir)
		{
		}

		public virtual int IsPageDirty()
		{
			// Note this returns an HRESULT not a Bool.
			return false ? (int)VSConstants.S_OK : (int)VSConstants.S_FALSE;
		}

		public virtual void Move(RECT[] arrRect)
		{
			RECT r = arrRect[0];

			this.panel.Location = new Point(r.left, r.top);
			this.panel.Size = new Size(r.right - r.left, r.bottom - r.top);
		}

		public virtual void SetObjects(uint count, object[] punk)
		{
		}
		
		public virtual void SetPageSite(IPropertyPageSite theSite)
		{
			this.site = theSite;
		}

		public virtual void Show(uint cmd)
		{
			this.panel.Visible = true; // TODO: pass SW_SHOW* flags through      
			this.panel.Show();
		}

		public virtual int TranslateAccelerator(MSG[] arrMsg)
		{
			MSG msg = arrMsg[0];

			if ((msg.message < NativeMethods.WM_KEYFIRST || msg.message > NativeMethods.WM_KEYLAST) && (msg.message < NativeMethods.WM_MOUSEFIRST || msg.message > NativeMethods.WM_MOUSELAST))
				return 1;

			return (NativeMethods.IsDialogMessageA(this.panel.Handle, ref msg)) ? 0 : 1;
		}

		#endregion

		#region helper methods

		#endregion
	}
}
