// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:xvml="urn:schemas-microsoft-com:office:excel" namespace.
    /// </summary>
    public static class XVML
    {
        /// <summary>
        /// Defines the XML namespace associated with the xvml prefix.
        /// </summary>
        public static readonly XNamespace xvml = "urn:schemas-microsoft-com:office:excel";

        /// <summary>
        /// Represents the xvml:Accel XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ClientData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AcceleratorPrimary.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Accel = xvml + "Accel";

        /// <summary>
        /// Represents the xvml:Accel2 XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ClientData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AcceleratorSecondary.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Accel2 = xvml + "Accel2";

        /// <summary>
        /// Represents the xvml:Anchor XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ClientData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Anchor.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Anchor = xvml + "Anchor";

        /// <summary>
        /// Represents the xvml:AutoFill XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ClientData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AutoFill.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName AutoFill = xvml + "AutoFill";

        /// <summary>
        /// Represents the xvml:AutoLine XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ClientData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AutoLine.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName AutoLine = xvml + "AutoLine";

        /// <summary>
        /// Represents the xvml:AutoPict XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ClientData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AutoSizePicture.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName AutoPict = xvml + "AutoPict";

        /// <summary>
        /// Represents the xvml:AutoScale XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ClientData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AutoScaleFont.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName AutoScale = xvml + "AutoScale";

        /// <summary>
        /// Represents the xvml:Camera XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ClientData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CameraObject.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Camera = xvml + "Camera";

        /// <summary>
        /// Represents the xvml:Cancel XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ClientData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CancelButton.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Cancel = xvml + "Cancel";

        /// <summary>
        /// Represents the xvml:CF XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ClientData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ClipboardFormat.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName CF = xvml + "CF";

        /// <summary>
        /// Represents the xvml:Checked XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ClientData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Checked.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Checked = xvml + "Checked";

        /// <summary>
        /// Represents the xvml:ClientData XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="V.arc" />, <see cref="V.curve" />, <see cref="V.group" />, <see cref="V.image" />, <see cref="V.line" />, <see cref="V.oval" />, <see cref="V.polyline" />, <see cref="V.rect" />, <see cref="V.roundrect" />, <see cref="V.shape" />, <see cref="V.shapetype" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="Accel" />, <see cref="Accel2" />, <see cref="Anchor" />, <see cref="AutoFill" />, <see cref="AutoLine" />, <see cref="AutoPict" />, <see cref="AutoScale" />, <see cref="Camera" />, <see cref="Cancel" />, <see cref="CF" />, <see cref="Checked" />, <see cref="ColHidden" />, <see cref="Colored" />, <see cref="Column" />, <see cref="DDE" />, <see cref="Default" />, <see cref="DefaultSize" />, <see cref="Disabled" />, <see cref="Dismiss" />, <see cref="DropLines" />, <see cref="DropStyle" />, <see cref="Dx" />, <see cref="FirstButton" />, <see cref="FmlaGroup" />, <see cref="FmlaLink" />, <see cref="FmlaMacro" />, <see cref="FmlaPict" />, <see cref="FmlaRange" />, <see cref="FmlaTxbx" />, <see cref="Help" />, <see cref="Horiz" />, <see cref="Inc" />, <see cref="JustLastX" />, <see cref="LCT" />, <see cref="ListItem" />, <see cref="Locked" />, <see cref="LockText" />, <see cref="MapOCX" />, <see cref="Max" />, <see cref="Min" />, <see cref="MoveWithCells" />, <see cref="MultiLine" />, <see cref="MultiSel" />, <see cref="NoThreeD" />, <see cref="NoThreeD2" />, <see cref="Page" />, <see cref="PrintObject" />, <see cref="RecalcAlways" />, <see cref="Row" />, <see cref="RowHidden" />, <see cref="ScriptExtended" />, <see cref="ScriptLanguage" />, <see cref="ScriptLocation" />, <see cref="ScriptText" />, <see cref="SecretEdit" />, <see cref="Sel" />, <see cref="SelType" />, <see cref="SizeWithCells" />, <see cref="TextHAlign" />, <see cref="TextVAlign" />, <see cref="UIObj" />, <see cref="Val" />, <see cref="ValidIds" />, <see cref="Visible" />, <see cref="VScroll" />, <see cref="VTEdit" />, <see cref="WidthMin" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.ObjectType_" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ClientData.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ClientData = xvml + "ClientData";

        /// <summary>
        /// Represents the xvml:ColHidden XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ClientData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ColumnHidden.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ColHidden = xvml + "ColHidden";

        /// <summary>
        /// Represents the xvml:Colored XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ClientData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Colored.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Colored = xvml + "Colored";

        /// <summary>
        /// Represents the xvml:Column XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ClientData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CommentColumnTarget.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Column = xvml + "Column";

        /// <summary>
        /// Represents the xvml:DDE XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ClientData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DdeObject.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName DDE = xvml + "DDE";

        /// <summary>
        /// Represents the xvml:Default XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ClientData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DefaultButton.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Default = xvml + "Default";

        /// <summary>
        /// Represents the xvml:DefaultSize XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ClientData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DefaultSize.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName DefaultSize = xvml + "DefaultSize";

        /// <summary>
        /// Represents the xvml:Disabled XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ClientData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Disabled.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Disabled = xvml + "Disabled";

        /// <summary>
        /// Represents the xvml:Dismiss XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ClientData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DismissButton.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Dismiss = xvml + "Dismiss";

        /// <summary>
        /// Represents the xvml:DropLines XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ClientData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DropLines.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName DropLines = xvml + "DropLines";

        /// <summary>
        /// Represents the xvml:DropStyle XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ClientData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DropStyle.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName DropStyle = xvml + "DropStyle";

        /// <summary>
        /// Represents the xvml:Dx XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ClientData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ScrollBarWidth.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Dx = xvml + "Dx";

        /// <summary>
        /// Represents the xvml:FirstButton XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ClientData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FirstButton.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName FirstButton = xvml + "FirstButton";

        /// <summary>
        /// Represents the xvml:FmlaGroup XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ClientData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FormulaGroup.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName FmlaGroup = xvml + "FmlaGroup";

        /// <summary>
        /// Represents the xvml:FmlaLink XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ClientData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FormulaLink.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName FmlaLink = xvml + "FmlaLink";

        /// <summary>
        /// Represents the xvml:FmlaMacro XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ClientData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FormulaMacro.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName FmlaMacro = xvml + "FmlaMacro";

        /// <summary>
        /// Represents the xvml:FmlaPict XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ClientData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FormulaPicture.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName FmlaPict = xvml + "FmlaPict";

        /// <summary>
        /// Represents the xvml:FmlaRange XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ClientData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FormulaRange.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName FmlaRange = xvml + "FmlaRange";

        /// <summary>
        /// Represents the xvml:FmlaTxbx XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ClientData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FormulaTextBox.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName FmlaTxbx = xvml + "FmlaTxbx";

        /// <summary>
        /// Represents the xvml:Help XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ClientData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: HelpButton.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Help = xvml + "Help";

        /// <summary>
        /// Represents the xvml:Horiz XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ClientData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: HorizontalScrollBar.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Horiz = xvml + "Horiz";

        /// <summary>
        /// Represents the xvml:Inc XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ClientData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ScrollBarIncrement.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Inc = xvml + "Inc";

        /// <summary>
        /// Represents the xvml:JustLastX XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ClientData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: JustifyLastLine.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName JustLastX = xvml + "JustLastX";

        /// <summary>
        /// Represents the xvml:LCT XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ClientData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ListBoxCallbackType.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName LCT = xvml + "LCT";

        /// <summary>
        /// Represents the xvml:ListItem XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ClientData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ListItem.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ListItem = xvml + "ListItem";

        /// <summary>
        /// Represents the xvml:Locked XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ClientData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Locked.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Locked = xvml + "Locked";

        /// <summary>
        /// Represents the xvml:LockText XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ClientData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LockText.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName LockText = xvml + "LockText";

        /// <summary>
        /// Represents the xvml:MapOCX XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ClientData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MapOcxControl.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName MapOCX = xvml + "MapOCX";

        /// <summary>
        /// Represents the xvml:Max XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ClientData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ScrollBarMax.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Max = xvml + "Max";

        /// <summary>
        /// Represents the xvml:Min XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ClientData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ScrollBarMin.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Min = xvml + "Min";

        /// <summary>
        /// Represents the xvml:MoveWithCells XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ClientData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MoveWithCells.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName MoveWithCells = xvml + "MoveWithCells";

        /// <summary>
        /// Represents the xvml:MultiLine XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ClientData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MultiLine.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName MultiLine = xvml + "MultiLine";

        /// <summary>
        /// Represents the xvml:MultiSel XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ClientData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MultiSelections.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName MultiSel = xvml + "MultiSel";

        /// <summary>
        /// Represents the xvml:NoThreeD XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ClientData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Disable3D.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName NoThreeD = xvml + "NoThreeD";

        /// <summary>
        /// Represents the xvml:NoThreeD2 XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ClientData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Disable3DForListBoxAndDropDown.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName NoThreeD2 = xvml + "NoThreeD2";

        /// <summary>
        /// Represents the xvml:Page XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ClientData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ScrollBarPageIncrement.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Page = xvml + "Page";

        /// <summary>
        /// Represents the xvml:PrintObject XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ClientData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PrintObject.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName PrintObject = xvml + "PrintObject";

        /// <summary>
        /// Represents the xvml:RecalcAlways XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ClientData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RecalculateAlways.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName RecalcAlways = xvml + "RecalcAlways";

        /// <summary>
        /// Represents the xvml:Row XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ClientData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CommentRowTarget.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Row = xvml + "Row";

        /// <summary>
        /// Represents the xvml:RowHidden XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ClientData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RowHidden.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName RowHidden = xvml + "RowHidden";

        /// <summary>
        /// Represents the xvml:ScriptExtended XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ClientData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ScriptExtended.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ScriptExtended = xvml + "ScriptExtended";

        /// <summary>
        /// Represents the xvml:ScriptLanguage XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ClientData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ScriptLanguage.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ScriptLanguage = xvml + "ScriptLanguage";

        /// <summary>
        /// Represents the xvml:ScriptLocation XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ClientData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ScriptLocation.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ScriptLocation = xvml + "ScriptLocation";

        /// <summary>
        /// Represents the xvml:ScriptText XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ClientData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ScriptText.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ScriptText = xvml + "ScriptText";

        /// <summary>
        /// Represents the xvml:SecretEdit XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ClientData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SecretEdit.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName SecretEdit = xvml + "SecretEdit";

        /// <summary>
        /// Represents the xvml:Sel XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ClientData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SelectionEntry.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Sel = xvml + "Sel";

        /// <summary>
        /// Represents the xvml:SelType XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ClientData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SelectionType.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName SelType = xvml + "SelType";

        /// <summary>
        /// Represents the xvml:SizeWithCells XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ClientData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ResizeWithCells.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName SizeWithCells = xvml + "SizeWithCells";

        /// <summary>
        /// Represents the xvml:TextHAlign XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ClientData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: HorizontalTextAlignment.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName TextHAlign = xvml + "TextHAlign";

        /// <summary>
        /// Represents the xvml:TextVAlign XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ClientData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: VerticalTextAlignment.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName TextVAlign = xvml + "TextVAlign";

        /// <summary>
        /// Represents the xvml:UIObj XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ClientData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: UIObject.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName UIObj = xvml + "UIObj";

        /// <summary>
        /// Represents the xvml:Val XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ClientData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ScrollBarPosition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Val = xvml + "Val";

        /// <summary>
        /// Represents the xvml:ValidIds XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ClientData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ValidIds.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ValidIds = xvml + "ValidIds";

        /// <summary>
        /// Represents the xvml:Visible XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ClientData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Visible.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Visible = xvml + "Visible";

        /// <summary>
        /// Represents the xvml:VScroll XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ClientData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: VerticalScrollBar.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName VScroll = xvml + "VScroll";

        /// <summary>
        /// Represents the xvml:VTEdit XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ClientData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: InputValidationType.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName VTEdit = xvml + "VTEdit";

        /// <summary>
        /// Represents the xvml:WidthMin XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ClientData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MinDropDownWidth.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName WidthMin = xvml + "WidthMin";
    }
}
