/****************************************************************************

    VsPkg.cs

    Implementation of OpenXMLEditor.

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
using System.ComponentModel.Design;
using Microsoft.Win32;
using Microsoft.VisualStudio.Shell.Interop;
using Microsoft.VisualStudio.OLE.Interop;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio;

namespace Microsoft.OpenXMLEditor
{
    /// <summary>
    /// This is the class that implements the package exposed by this assembly.
    ///
    /// The minimum requirement for a class to be considered a valid package for Visual Studio
    /// is to implement the IVsPackage interface and register itself with the shell.
    /// This package uses the helper classes defined inside the Managed Package Framework (MPF)
    /// to do it: it derives from the Package class that provides the implementation of the 
    /// IVsPackage interface and uses the registration attributes defined in the framework to 
    /// register itself and its components with the shell.
    /// </summary>
    // This attribute tells the registration utility (regpkg.exe) that this class needs
    // to be registered as package.
    [PackageRegistration(UseManagedResourcesOnly = true)]
    // A Visual Studio component can be registered under different regitry roots; for instance
    // when you debug your package you want to register it in the experimental hive. This
    // attribute specifies the registry root to use if no one is provided to regpkg.exe with
    // the /root switch.
    [DefaultRegistryRoot("Software\\Microsoft\\VisualStudio\\9.0")]
    // This attribute is used to register the informations needed to show the this package
    // in the Help/About dialog of Visual Studio.
    [InstalledProductRegistration("#100", "#102", "1.0")]
    // [InstalledProductRegistration(null, null, null)]
    // In order be loaded inside Visual Studio in a machine that has not the VS SDK installed, 
    // package needs to have a valid load key (it can be requested at 
    // http://msdn.microsoft.com/vstudio/extend/). This attributes tells the shell that this 
    // package has a load key embedded in its resources.
    [ProvideLoadKey("Standard", "1.0", "OpenXMLEditor", "Microsoft", 101)]
    [ProvideEditorExtension(typeof(PackageEditorFactory), ".crtx", 50,
            ProjectGuid = "{A2FE74E1-B743-11d0-AE1A-00A0C90FFFC3}",
            TemplateDir = ".\\Templates",
            NameResourceID = 109,
            DefaultName = "Package File Template")]
    [ProvideEditorExtension(typeof(PackageEditorFactory), ".docm", 50)]
    [ProvideEditorExtension(typeof(PackageEditorFactory), ".docx", 50)]
    [ProvideEditorExtension(typeof(PackageEditorFactory), ".dotm", 50)]
    [ProvideEditorExtension(typeof(PackageEditorFactory), ".dotx", 50)]
    [ProvideEditorExtension(typeof(PackageEditorFactory), ".eftx", 50)]
    [ProvideEditorExtension(typeof(PackageEditorFactory), ".gcsx", 50)]
    [ProvideEditorExtension(typeof(PackageEditorFactory), ".glox", 50)]
    [ProvideEditorExtension(typeof(PackageEditorFactory), ".gqsx", 50)]
    [ProvideEditorExtension(typeof(PackageEditorFactory), ".potm", 50)]
    [ProvideEditorExtension(typeof(PackageEditorFactory), ".potx", 50)]
    [ProvideEditorExtension(typeof(PackageEditorFactory), ".ppam", 50)]
    [ProvideEditorExtension(typeof(PackageEditorFactory), ".ppsm", 50)]
    [ProvideEditorExtension(typeof(PackageEditorFactory), ".ppsx", 50)]
    [ProvideEditorExtension(typeof(PackageEditorFactory), ".pptm", 50)]
    [ProvideEditorExtension(typeof(PackageEditorFactory), ".pptx", 50)]
    [ProvideEditorExtension(typeof(PackageEditorFactory), ".thmx", 50)]
    [ProvideEditorExtension(typeof(PackageEditorFactory), ".xlam", 50)]
    [ProvideEditorExtension(typeof(PackageEditorFactory), ".xlsb", 50)]
    [ProvideEditorExtension(typeof(PackageEditorFactory), ".xlsm", 50)]
    [ProvideEditorExtension(typeof(PackageEditorFactory), ".xlsx", 50)]
    [ProvideEditorExtension(typeof(PackageEditorFactory), ".xltm", 50)]
    [ProvideEditorExtension(typeof(PackageEditorFactory), ".xltx", 50)]
    [ProvideEditorExtension(typeof(PackageEditorFactory), ".vsdx", 50)]
    [ProvideEditorExtension(typeof(PackageEditorFactory), ".vsdm", 50)]
    [ProvideEditorExtension(typeof(PackageEditorFactory), ".vssx", 50)]
    [ProvideEditorExtension(typeof(PackageEditorFactory), ".vssm", 50)]
    [ProvideEditorExtension(typeof(PackageEditorFactory), ".vstx", 50)]
    [ProvideEditorExtension(typeof(PackageEditorFactory), ".vstm", 50)]
    [ProvideEditorExtension(typeof(PackageEditorFactory), ".container", 50)]
    [ProvideEditorExtension(typeof(PackageEditorFactory), ".xps", 50)]
    [ProvideEditorExtension(typeof(PackageEditorFactory), ".oxps", 50)]
    [ProvideEditorExtension(typeof(PackageEditorFactory), ".vsix", 50)]
    [ProvideEditorLogicalView(typeof(PackageEditorFactory), "{7651a703-06e5-11d1-8ebd-00a0c90f26ea}")]
    [ProvideEditorExtension(typeof(PartEditorFactory), ".dummyPartExtension", 50)] // editor seems to require an extension, but if we use ".xml" it interferes with the standard XML editor.
    [ProvideEditorLogicalView(typeof(PartEditorFactory), "{7651a703-06e5-11d1-8ebd-00a0c90f26ea}")]
//TODO    [ProvideObject(typeof(PropertyPage))]
    [Guid(GuidList.guidOpenXMLEditorPkgString)]
    // [CLSCompliant(false)]
    // todo: replace with AsyncPackage
    public sealed class OpenXMLEditor : Package, IVsInstalledProduct
    {

        private PackageEditorFactory editorFactory;
        private PartEditorFactory partEditorFactory;

        /// <summary>
        /// Default constructor of the package.
        /// Inside this method you can place any initialization code that does not require 
        /// any Visual Studio service because at this point the package object is created but 
        /// not sited yet inside Visual Studio environment. The place to do all the other 
        /// initialization is the Initialize method.
        /// </summary>
        public OpenXMLEditor()
        {
            Debug.WriteLine(string.Format(CultureInfo.CurrentCulture, "Entering constructor for: {0}", this.ToString()));
        }



        /////////////////////////////////////////////////////////////////////////////
        // Overriden Package Implementation
        #region Package Members

        /// <summary>
        /// Initialization of the package; this method is called right after the package is sited, so this is the place
        /// where you can put all the initilaization code that rely on services provided by VisualStudio.
        /// </summary>
        protected override void Initialize()
        {
            Debug.WriteLine (string.Format(CultureInfo.CurrentCulture, "Entering Initialize() of: {0}", this.ToString()));
            base.Initialize();

            //Create Editor Factory
            editorFactory = new PackageEditorFactory(this);
            base.RegisterEditorFactory(editorFactory);

            partEditorFactory = new PartEditorFactory(this);
            base.RegisterEditorFactory(partEditorFactory);
        }

        #endregion

        #region IVsInstalledProduct Members
        /// <summary>
        /// This method is called during Devenv /Setup to get the bitmap to
        /// display on the splash screen for this package.
        /// </summary>
        /// <param name="pIdBmp">The resource id corresponding to the bitmap to display on the splash screen</param>
        /// <returns>HRESULT, indicating success or failure</returns>
        public int IdBmpSplash(out uint pIdBmp)
        {
            pIdBmp = 400;

            return VSConstants.S_OK;
        }

        /// <summary>
        /// This method is called to get the icon that will be displayed in the
        /// Help About dialog when this package is selected.
        /// </summary>
        /// <param name="pIdIco">The resource id corresponding to the icon to display on the Help About dialog</param>
        /// <returns>HRESULT, indicating success or failure</returns>
        public int IdIcoLogoForAboutbox(out uint pIdIco)
        {
            pIdIco = 400;

            return VSConstants.S_OK;
        }

        /// <summary>
        /// This methods provides the product official name, it will be
        /// displayed in the help about dialog.
        /// </summary>
        /// <param name="pbstrName">Out parameter to which to assign the product name</param>
        /// <returns>HRESULT, indicating success or failure</returns>
        public int OfficialName(out string pbstrName)
        {
            pbstrName = GetResourceString("@100");
            return VSConstants.S_OK;
        }

        /// <summary>
        /// This methods provides the product description, it will be
        /// displayed in the help about dialog.
        /// </summary>
        /// <param name="pbstrProductDetails">Out parameter to which to assign the description of the package</param>
        /// <returns>HRESULT, indicating success or failure</returns>
        public int ProductDetails(out string pbstrProductDetails)
        {
            pbstrProductDetails = GetResourceString("@102");
            return VSConstants.S_OK;
        }

        /// <summary>
        /// This methods provides the product version, it will be
        /// displayed in the help about dialog.
        /// </summary>
        /// <param name="pbstrPID">Out parameter to which to assign the version number</param>
        /// <returns>HRESULT, indicating success or failure</returns>
        public int ProductID(out string pbstrPID)
        {
            pbstrPID = GetResourceString("@103");
            return VSConstants.S_OK;
        }

        #endregion

        /// <summary>
        /// This method loads a localized string based on the specified resource.
        /// </summary>
        /// <param name="resourceName">Resource to load</param>
        /// <returns>String loaded for the specified resource</returns>
        public string GetResourceString(string resourceName)
        {
            string resourceValue;
            IVsResourceManager resourceManager = (IVsResourceManager)GetService(typeof(SVsResourceManager));
            if (resourceManager == null)
            {
                throw new InvalidOperationException("Could not get SVsResourceManager service. Make sure the package is Sited before calling this method");
            }
            Guid packageGuid = this.GetType().GUID;
            int hr = resourceManager.LoadResourceString(ref packageGuid, -1, resourceName, out resourceValue);
            Microsoft.VisualStudio.ErrorHandler.ThrowOnFailure(hr);
            return resourceValue;
        }
    }
}