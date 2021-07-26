// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:mso="http://schemas.microsoft.com/office/2006/01/customui" namespace.
    /// </summary>
    public static class MSO
    {
        /// <summary>
        /// Defines the XML namespace associated with the mso prefix.
        /// </summary>
        public static readonly XNamespace mso = "http://schemas.microsoft.com/office/2006/01/customui";

        /// <summary>
        /// Represents the mso:box XML element.
        /// </summary>
        public static readonly XName box = mso + "box";

        /// <summary>
        /// Represents the mso:button XML elements.
        /// </summary>
        public static readonly XName button = mso + "button";

        /// <summary>
        /// Represents the mso:buttonGroup XML element.
        /// </summary>
        public static readonly XName buttonGroup = mso + "buttonGroup";

        /// <summary>
        /// Represents the mso:checkBox XML element.
        /// </summary>
        public static readonly XName checkBox = mso + "checkBox";

        /// <summary>
        /// Represents the mso:comboBox XML element.
        /// </summary>
        public static readonly XName comboBox = mso + "comboBox";

        /// <summary>
        /// Represents the mso:command XML element.
        /// </summary>
        public static readonly XName command = mso + "command";

        /// <summary>
        /// Represents the mso:commands XML element.
        /// </summary>
        public static readonly XName commands = mso + "commands";

        /// <summary>
        /// Represents the mso:contextualTabs XML element.
        /// </summary>
        public static readonly XName contextualTabs = mso + "contextualTabs";

        /// <summary>
        /// Represents the mso:control XML elements.
        /// </summary>
        public static readonly XName control = mso + "control";

        /// <summary>
        /// Represents the mso:customUI XML element.
        /// </summary>
        public static readonly XName customUI = mso + "customUI";

        /// <summary>
        /// Represents the mso:dialogBoxLauncher XML element.
        /// </summary>
        public static readonly XName dialogBoxLauncher = mso + "dialogBoxLauncher";

        /// <summary>
        /// Represents the mso:documentControls XML element.
        /// </summary>
        public static readonly XName documentControls = mso + "documentControls";

        /// <summary>
        /// Represents the mso:dropDown XML element.
        /// </summary>
        public static readonly XName dropDown = mso + "dropDown";

        /// <summary>
        /// Represents the mso:dynamicMenu XML elements.
        /// </summary>
        public static readonly XName dynamicMenu = mso + "dynamicMenu";

        /// <summary>
        /// Represents the mso:editBox XML element.
        /// </summary>
        public static readonly XName editBox = mso + "editBox";

        /// <summary>
        /// Represents the mso:gallery XML elements.
        /// </summary>
        public static readonly XName gallery = mso + "gallery";

        /// <summary>
        /// Represents the mso:group XML element.
        /// </summary>
        public static readonly XName group = mso + "group";

        /// <summary>
        /// Represents the mso:item XML element.
        /// </summary>
        public static readonly XName item = mso + "item";

        /// <summary>
        /// Represents the mso:labelControl XML element.
        /// </summary>
        public static readonly XName labelControl = mso + "labelControl";

        /// <summary>
        /// Represents the mso:menu XML elements.
        /// </summary>
        public static readonly XName menu = mso + "menu";

        /// <summary>
        /// Represents the mso:menuSeparator XML element.
        /// </summary>
        public static readonly XName menuSeparator = mso + "menuSeparator";

        /// <summary>
        /// Represents the mso:officeMenu XML element.
        /// </summary>
        public static readonly XName officeMenu = mso + "officeMenu";

        /// <summary>
        /// Represents the mso:qat XML element.
        /// </summary>
        public static readonly XName qat = mso + "qat";

        /// <summary>
        /// Represents the mso:ribbon XML element.
        /// </summary>
        public static readonly XName ribbon = mso + "ribbon";

        /// <summary>
        /// Represents the mso:separator XML element.
        /// </summary>
        public static readonly XName separator = mso + "separator";

        /// <summary>
        /// Represents the mso:sharedControls XML element.
        /// </summary>
        public static readonly XName sharedControls = mso + "sharedControls";

        /// <summary>
        /// Represents the mso:splitButton XML elements.
        /// </summary>
        public static readonly XName splitButton = mso + "splitButton";

        /// <summary>
        /// Represents the mso:tab XML element.
        /// </summary>
        public static readonly XName tab = mso + "tab";

        /// <summary>
        /// Represents the mso:tabs XML element.
        /// </summary>
        public static readonly XName tabs = mso + "tabs";

        /// <summary>
        /// Represents the mso:tabSet XML element.
        /// </summary>
        public static readonly XName tabSet = mso + "tabSet";

        /// <summary>
        /// Represents the mso:toggleButton XML elements.
        /// </summary>
        public static readonly XName toggleButton = mso + "toggleButton";
    }
}
