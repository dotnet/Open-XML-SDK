namespace Microsoft.OpenXMLEditor
{
    partial class PackageEditorPane
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support.
        /// normally you would not modify the contents of this method with the code editor and instead
        /// manipulate it with the design view instead.  In the case where you are creating a new VS
        /// editor and no longer need use of the wizard-generated controls, you can feel free to edit
        /// this code in the code view or in the design view.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PackageEditorPane));
            this.reloadTimer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.partsToolStrip = new System.Windows.Forms.ToolStrip();
            this.buttonBack = new System.Windows.Forms.ToolStripButton();
            this.buttonForward = new System.Windows.Forms.ToolStripButton();
            this.buttonHistory = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonNewFolder = new System.Windows.Forms.ToolStripButton();
            this.buttonAddXmlPart = new System.Windows.Forms.ToolStripButton();
            this.buttonAddImagePart = new System.Windows.Forms.ToolStripButton();
            this.buttonAddInternalRel = new System.Windows.Forms.ToolStripButton();
            this.buttonAddExternalRel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonProps = new System.Windows.Forms.ToolStripButton();
            this.buttonImport = new System.Windows.Forms.ToolStripButton();
            this.buttonExport = new System.Windows.Forms.ToolStripButton();
            this.buttonEditPart = new System.Windows.Forms.ToolStripButton();
            this.buttonDeletePart = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonShowRels = new System.Windows.Forms.ToolStripButton();
            this.buttonAbout = new System.Windows.Forms.ToolStripButton();
            this.treeView = new System.Windows.Forms.TreeView();
            this.contextMenuDoc = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewPartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importNewPartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addInternalRelationshipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addExternalRelationshipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.importFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.exportFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.contextMenuFolder = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuPart = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem16 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem17 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem18 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem19 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem20 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuRel = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem21 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem22 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem30 = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel.SuspendLayout();
            this.partsToolStrip.SuspendLayout();
            this.contextMenuDoc.SuspendLayout();
            this.contextMenuFolder.SuspendLayout();
            this.contextMenuPart.SuspendLayout();
            this.contextMenuRel.SuspendLayout();
            this.SuspendLayout();
            // 
            // reloadTimer
            // 
            this.reloadTimer.Tick += new System.EventHandler(this.reloadTimer_Tick);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.partsToolStrip, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.treeView, 0, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(431, 274);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // partsToolStrip
            // 
            this.partsToolStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.partsToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.partsToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonBack,
            this.buttonForward,
            this.buttonHistory,
            this.toolStripSeparator8,
            this.buttonNewFolder,
            this.buttonAddXmlPart,
            this.buttonAddImagePart,
            this.buttonAddInternalRel,
            this.buttonAddExternalRel,
            this.toolStripSeparator10,
            this.buttonProps,
            this.buttonImport,
            this.buttonExport,
            this.buttonEditPart,
            this.buttonDeletePart,
            this.toolStripSeparator1,
            this.buttonShowRels,
            this.buttonAbout});
            this.partsToolStrip.Location = new System.Drawing.Point(0, 0);
            this.partsToolStrip.Name = "partsToolStrip";
            this.partsToolStrip.Size = new System.Drawing.Size(431, 25);
            this.partsToolStrip.TabIndex = 0;
            // 
            // buttonBack
            // 
            this.buttonBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonBack.Enabled = false;
            this.buttonBack.Image = ((System.Drawing.Image)(resources.GetObject("buttonBack.Image")));
            this.buttonBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(23, 22);
            this.buttonBack.Text = "Back";
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonForward
            // 
            this.buttonForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonForward.Enabled = false;
            this.buttonForward.Image = ((System.Drawing.Image)(resources.GetObject("buttonForward.Image")));
            this.buttonForward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonForward.Name = "buttonForward";
            this.buttonForward.Size = new System.Drawing.Size(23, 22);
            this.buttonForward.Text = "Forward";
            this.buttonForward.Click += new System.EventHandler(this.buttonForward_Click);
            // 
            // buttonHistory
            // 
            this.buttonHistory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.buttonHistory.Image = ((System.Drawing.Image)(resources.GetObject("buttonHistory.Image")));
            this.buttonHistory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonHistory.Name = "buttonHistory";
            this.buttonHistory.Size = new System.Drawing.Size(13, 22);
            this.buttonHistory.Text = "History";
            this.buttonHistory.DropDownOpening += new System.EventHandler(this.buttonHistory_DropDownOpening);
            this.buttonHistory.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.buttonHistory_DropDownItemClicked);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // buttonNewFolder
            // 
            this.buttonNewFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonNewFolder.Enabled = false;
            this.buttonNewFolder.Image = ((System.Drawing.Image)(resources.GetObject("buttonNewFolder.Image")));
            this.buttonNewFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonNewFolder.Name = "buttonNewFolder";
            this.buttonNewFolder.Size = new System.Drawing.Size(23, 22);
            this.buttonNewFolder.Text = "New Folder";
            this.buttonNewFolder.Click += new System.EventHandler(this.buttonNewFolder_Click);
            // 
            // buttonAddXmlPart
            // 
            this.buttonAddXmlPart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonAddXmlPart.Enabled = false;
            this.buttonAddXmlPart.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddXmlPart.Image")));
            this.buttonAddXmlPart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonAddXmlPart.Name = "buttonAddXmlPart";
            this.buttonAddXmlPart.Size = new System.Drawing.Size(23, 22);
            this.buttonAddXmlPart.Text = "Add New Part";
            this.buttonAddXmlPart.Click += new System.EventHandler(this.buttonAddXmlPart_Click);
            // 
            // buttonAddImagePart
            // 
            this.buttonAddImagePart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonAddImagePart.Enabled = false;
            this.buttonAddImagePart.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddImagePart.Image")));
            this.buttonAddImagePart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonAddImagePart.Name = "buttonAddImagePart";
            this.buttonAddImagePart.Size = new System.Drawing.Size(23, 22);
            this.buttonAddImagePart.Text = "Import New Part";
            this.buttonAddImagePart.Click += new System.EventHandler(this.buttonAddImagePart_Click);
            // 
            // buttonAddInternalRel
            // 
            this.buttonAddInternalRel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonAddInternalRel.Enabled = false;
            this.buttonAddInternalRel.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddInternalRel.Image")));
            this.buttonAddInternalRel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonAddInternalRel.Name = "buttonAddInternalRel";
            this.buttonAddInternalRel.Size = new System.Drawing.Size(23, 22);
            this.buttonAddInternalRel.Text = "Add Internal Relationship";
            this.buttonAddInternalRel.Click += new System.EventHandler(this.buttonAddInternalRel_Click);
            // 
            // buttonAddExternalRel
            // 
            this.buttonAddExternalRel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonAddExternalRel.Enabled = false;
            this.buttonAddExternalRel.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddExternalRel.Image")));
            this.buttonAddExternalRel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonAddExternalRel.Name = "buttonAddExternalRel";
            this.buttonAddExternalRel.Size = new System.Drawing.Size(23, 22);
            this.buttonAddExternalRel.Text = "Add External Relationship";
            this.buttonAddExternalRel.Click += new System.EventHandler(this.buttonAddExternalRel_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 25);
            // 
            // buttonProps
            // 
            this.buttonProps.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonProps.Enabled = false;
            this.buttonProps.Image = ((System.Drawing.Image)(resources.GetObject("buttonProps.Image")));
            this.buttonProps.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonProps.Name = "buttonProps";
            this.buttonProps.Size = new System.Drawing.Size(23, 22);
            this.buttonProps.Text = "Show Properties";
            this.buttonProps.Click += new System.EventHandler(this.buttonProps_Click);
            // 
            // buttonImport
            // 
            this.buttonImport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonImport.Enabled = false;
            this.buttonImport.Image = ((System.Drawing.Image)(resources.GetObject("buttonImport.Image")));
            this.buttonImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(23, 22);
            this.buttonImport.Text = "Import File to Part";
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // buttonExport
            // 
            this.buttonExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonExport.Enabled = false;
            this.buttonExport.Image = ((System.Drawing.Image)(resources.GetObject("buttonExport.Image")));
            this.buttonExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(23, 22);
            this.buttonExport.Text = "Export Part to File";
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // buttonEditPart
            // 
            this.buttonEditPart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonEditPart.Enabled = false;
            this.buttonEditPart.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditPart.Image")));
            this.buttonEditPart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonEditPart.Name = "buttonEditPart";
            this.buttonEditPart.Size = new System.Drawing.Size(23, 22);
            this.buttonEditPart.Text = "Edit Part";
            this.buttonEditPart.Click += new System.EventHandler(this.buttonEditPart_Click);
            // 
            // buttonDeletePart
            // 
            this.buttonDeletePart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonDeletePart.Enabled = false;
            this.buttonDeletePart.Image = ((System.Drawing.Image)(resources.GetObject("buttonDeletePart.Image")));
            this.buttonDeletePart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonDeletePart.Name = "buttonDeletePart";
            this.buttonDeletePart.Size = new System.Drawing.Size(23, 22);
            this.buttonDeletePart.Text = "Delete";
            this.buttonDeletePart.Click += new System.EventHandler(this.buttonDeletePart_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // buttonShowRels
            // 
            this.buttonShowRels.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonShowRels.Image = ((System.Drawing.Image)(resources.GetObject("buttonShowRels.Image")));
            this.buttonShowRels.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonShowRels.Name = "buttonShowRels";
            this.buttonShowRels.Size = new System.Drawing.Size(23, 22);
            this.buttonShowRels.Text = "Show _rels Folders";
            this.buttonShowRels.Click += new System.EventHandler(this.buttonShowRels_Click);
            // 
            // buttonAbout
            // 
            this.buttonAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.buttonAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonAbout.Image = ((System.Drawing.Image)(resources.GetObject("buttonAbout.Image")));
            this.buttonAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(23, 22);
            this.buttonAbout.Text = "About OpenXMLEditor";
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // treeView
            // 
            this.treeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView.ContextMenuStrip = this.contextMenuDoc;
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.HideSelection = false;
            this.treeView.ImageIndex = 1;
            this.treeView.ImageList = this.imageList;
            this.treeView.Location = new System.Drawing.Point(0, 25);
            this.treeView.Margin = new System.Windows.Forms.Padding(0);
            this.treeView.Name = "treeView";
            this.treeView.PathSeparator = "/";
            this.treeView.SelectedImageIndex = 2;
            this.treeView.ShowLines = false;
            this.treeView.ShowRootLines = false;
            this.treeView.Size = new System.Drawing.Size(431, 249);
            this.treeView.TabIndex = 1;
            this.treeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseDoubleClick);
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            this.treeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseClick);
            this.treeView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treeView_KeyDown);
            // 
            // contextMenuDoc
            // 
            this.contextMenuDoc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFolderToolStripMenuItem,
            this.addNewPartToolStripMenuItem,
            this.importNewPartToolStripMenuItem,
            this.addInternalRelationshipToolStripMenuItem,
            this.addExternalRelationshipToolStripMenuItem,
            this.toolStripSeparator4,
            this.propertiesToolStripMenuItem});
            this.contextMenuDoc.Name = "contextMenuStrip";
            this.contextMenuDoc.Size = new System.Drawing.Size(221, 142);
            // 
            // newFolderToolStripMenuItem
            // 
            this.newFolderToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newFolderToolStripMenuItem.Image")));
            this.newFolderToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.newFolderToolStripMenuItem.Name = "newFolderToolStripMenuItem";
            this.newFolderToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.newFolderToolStripMenuItem.Text = "New &Folder...";
            this.newFolderToolStripMenuItem.Click += new System.EventHandler(this.buttonNewFolder_Click);
            // 
            // addNewPartToolStripMenuItem
            // 
            this.addNewPartToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addNewPartToolStripMenuItem.Image")));
            this.addNewPartToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.addNewPartToolStripMenuItem.Name = "addNewPartToolStripMenuItem";
            this.addNewPartToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.addNewPartToolStripMenuItem.Text = "Add New &Part...";
            this.addNewPartToolStripMenuItem.Click += new System.EventHandler(this.buttonAddXmlPart_Click);
            // 
            // importNewPartToolStripMenuItem
            // 
            this.importNewPartToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("importNewPartToolStripMenuItem.Image")));
            this.importNewPartToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.importNewPartToolStripMenuItem.Name = "importNewPartToolStripMenuItem";
            this.importNewPartToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.importNewPartToolStripMenuItem.Text = "Import &New Part...";
            this.importNewPartToolStripMenuItem.Click += new System.EventHandler(this.buttonAddImagePart_Click);
            // 
            // addInternalRelationshipToolStripMenuItem
            // 
            this.addInternalRelationshipToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addInternalRelationshipToolStripMenuItem.Image")));
            this.addInternalRelationshipToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.addInternalRelationshipToolStripMenuItem.Name = "addInternalRelationshipToolStripMenuItem";
            this.addInternalRelationshipToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.addInternalRelationshipToolStripMenuItem.Text = "Add &Internal Relationship...";
            this.addInternalRelationshipToolStripMenuItem.Click += new System.EventHandler(this.buttonAddInternalRel_Click);
            // 
            // addExternalRelationshipToolStripMenuItem
            // 
            this.addExternalRelationshipToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addExternalRelationshipToolStripMenuItem.Image")));
            this.addExternalRelationshipToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.addExternalRelationshipToolStripMenuItem.Name = "addExternalRelationshipToolStripMenuItem";
            this.addExternalRelationshipToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.addExternalRelationshipToolStripMenuItem.Text = "Add &External Relationship...";
            this.addExternalRelationshipToolStripMenuItem.Click += new System.EventHandler(this.buttonAddExternalRel_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(217, 6);
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("propertiesToolStripMenuItem.Image")));
            this.propertiesToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.propertiesToolStripMenuItem.Text = "P&roperties";
            this.propertiesToolStripMenuItem.Click += new System.EventHandler(this.buttonProps_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "");
            this.imageList.Images.SetKeyName(1, "folder_close");
            this.imageList.Images.SetKeyName(2, "folder_open");
            this.imageList.Images.SetKeyName(3, "img");
            this.imageList.Images.SetKeyName(4, "xml");
            this.imageList.Images.SetKeyName(5, "");
            this.imageList.Images.SetKeyName(6, "");
            this.imageList.Images.SetKeyName(7, "rel");
            this.imageList.Images.SetKeyName(8, "external_rel");
            this.imageList.Images.SetKeyName(9, "file");
            // 
            // importFileDialog
            // 
            this.importFileDialog.Title = "Import File";
            // 
            // exportFileDialog
            // 
            this.exportFileDialog.Title = "Export File";
            // 
            // contextMenuFolder
            // 
            this.contextMenuFolder.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripSeparator5,
            this.toolStripMenuItem1,
            this.toolStripSeparator7,
            this.toolStripMenuItem10});
            this.contextMenuFolder.Name = "contextMenuStrip";
            this.contextMenuFolder.Size = new System.Drawing.Size(177, 148);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(176, 22);
            this.toolStripMenuItem1.Text = "&Delete";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.buttonDeletePart_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(173, 6);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem3.Image")));
            this.toolStripMenuItem3.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(176, 22);
            this.toolStripMenuItem3.Text = "New &Folder...";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.buttonNewFolder_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem4.Image")));
            this.toolStripMenuItem4.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(176, 22);
            this.toolStripMenuItem4.Text = "Add New &Part...";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.buttonAddXmlPart_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem5.Image")));
            this.toolStripMenuItem5.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(176, 22);
            this.toolStripMenuItem5.Text = "Import &New Part...";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.buttonAddImagePart_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(173, 6);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem10.Image")));
            this.toolStripMenuItem10.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(176, 22);
            this.toolStripMenuItem10.Text = "P&roperties";
            this.toolStripMenuItem10.Click += new System.EventHandler(this.buttonProps_Click);
            // 
            // contextMenuPart
            // 
            this.contextMenuPart.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem12,
            this.toolStripSeparator11,
            this.toolStripMenuItem16,
            this.toolStripMenuItem17,
            this.toolStripMenuItem18,
            this.toolStripMenuItem19,
            this.toolStripSeparator9,
            this.toolStripMenuItem11,
            this.toolStripSeparator12,
            this.toolStripMenuItem20});
            this.contextMenuPart.Name = "contextMenuStrip";
            this.contextMenuPart.Size = new System.Drawing.Size(221, 176);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem11.Image")));
            this.toolStripMenuItem11.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(220, 22);
            this.toolStripMenuItem11.Text = "&Delete";
            this.toolStripMenuItem11.Click += new System.EventHandler(this.buttonDeletePart_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(217, 6);
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItem12.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem12.Image")));
            this.toolStripMenuItem12.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(220, 22);
            this.toolStripMenuItem12.Text = "&Open";
            this.toolStripMenuItem12.Click += new System.EventHandler(this.buttonEditPart_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(217, 6);
            // 
            // toolStripMenuItem16
            // 
            this.toolStripMenuItem16.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem16.Image")));
            this.toolStripMenuItem16.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.toolStripMenuItem16.Name = "toolStripMenuItem16";
            this.toolStripMenuItem16.Size = new System.Drawing.Size(220, 22);
            this.toolStripMenuItem16.Text = "Add &Internal Relationship...";
            this.toolStripMenuItem16.Click += new System.EventHandler(this.buttonAddInternalRel_Click);
            // 
            // toolStripMenuItem17
            // 
            this.toolStripMenuItem17.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem17.Image")));
            this.toolStripMenuItem17.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.toolStripMenuItem17.Name = "toolStripMenuItem17";
            this.toolStripMenuItem17.Size = new System.Drawing.Size(220, 22);
            this.toolStripMenuItem17.Text = "Add &External Relationship...";
            this.toolStripMenuItem17.Click += new System.EventHandler(this.buttonAddExternalRel_Click);
            // 
            // toolStripMenuItem18
            // 
            this.toolStripMenuItem18.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem18.Image")));
            this.toolStripMenuItem18.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.toolStripMenuItem18.Name = "toolStripMenuItem18";
            this.toolStripMenuItem18.Size = new System.Drawing.Size(220, 22);
            this.toolStripMenuItem18.Text = "I&mport...";
            this.toolStripMenuItem18.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // toolStripMenuItem19
            // 
            this.toolStripMenuItem19.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem19.Image")));
            this.toolStripMenuItem19.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.toolStripMenuItem19.Name = "toolStripMenuItem19";
            this.toolStripMenuItem19.Size = new System.Drawing.Size(220, 22);
            this.toolStripMenuItem19.Text = "E&xport...";
            this.toolStripMenuItem19.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(217, 6);
            // 
            // toolStripMenuItem20
            // 
            this.toolStripMenuItem20.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem20.Image")));
            this.toolStripMenuItem20.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.toolStripMenuItem20.Name = "toolStripMenuItem20";
            this.toolStripMenuItem20.Size = new System.Drawing.Size(220, 22);
            this.toolStripMenuItem20.Text = "P&roperties";
            this.toolStripMenuItem20.Click += new System.EventHandler(this.buttonProps_Click);
            // 
            // contextMenuRel
            // 
            this.contextMenuRel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem22,
            this.toolStripSeparator13,
            this.toolStripMenuItem21,
            this.toolStripSeparator14,
            this.toolStripMenuItem30});
            this.contextMenuRel.Name = "contextMenuStrip";
            this.contextMenuRel.Size = new System.Drawing.Size(135, 82);
            // 
            // toolStripMenuItem21
            // 
            this.toolStripMenuItem21.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem21.Image")));
            this.toolStripMenuItem21.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.toolStripMenuItem21.Name = "toolStripMenuItem21";
            this.toolStripMenuItem21.Size = new System.Drawing.Size(134, 22);
            this.toolStripMenuItem21.Text = "&Delete";
            this.toolStripMenuItem21.Click += new System.EventHandler(this.buttonDeletePart_Click);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(131, 6);
            // 
            // toolStripMenuItem22
            // 
            this.toolStripMenuItem22.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItem22.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem22.Image")));
            this.toolStripMenuItem22.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.toolStripMenuItem22.Name = "toolStripMenuItem22";
            this.toolStripMenuItem22.Size = new System.Drawing.Size(134, 22);
            this.toolStripMenuItem22.Text = "&Open";
            this.toolStripMenuItem22.Click += new System.EventHandler(this.buttonEditPart_Click);
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(131, 6);
            // 
            // toolStripMenuItem30
            // 
            this.toolStripMenuItem30.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem30.Image")));
            this.toolStripMenuItem30.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.toolStripMenuItem30.Name = "toolStripMenuItem30";
            this.toolStripMenuItem30.Size = new System.Drawing.Size(134, 22);
            this.toolStripMenuItem30.Text = "P&roperties";
            this.toolStripMenuItem30.Click += new System.EventHandler(this.buttonProps_Click);
            // 
            // PackageEditorPane
            // 
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "PackageEditorPane";
            this.Size = new System.Drawing.Size(431, 274);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.partsToolStrip.ResumeLayout(false);
            this.partsToolStrip.PerformLayout();
            this.contextMenuDoc.ResumeLayout(false);
            this.contextMenuFolder.ResumeLayout(false);
            this.contextMenuPart.ResumeLayout(false);
            this.contextMenuRel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.ToolStrip partsToolStrip;
        private System.Windows.Forms.ToolStripButton buttonBack;
        private System.Windows.Forms.ToolStripButton buttonForward;
        private System.Windows.Forms.ToolStripDropDownButton buttonHistory;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton buttonNewFolder;
        private System.Windows.Forms.ToolStripButton buttonAddXmlPart;
        private System.Windows.Forms.ToolStripButton buttonAddImagePart;
        private System.Windows.Forms.ToolStripButton buttonAddInternalRel;
        private System.Windows.Forms.ToolStripButton buttonAddExternalRel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripButton buttonEditPart;
        private System.Windows.Forms.ToolStripButton buttonDeletePart;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton buttonShowRels;
        private System.Windows.Forms.ToolStripButton buttonAbout;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ToolStripButton buttonProps;
        private System.Windows.Forms.ToolStripButton buttonImport;
        private System.Windows.Forms.ToolStripButton buttonExport;
        private System.Windows.Forms.OpenFileDialog importFileDialog;
        private System.Windows.Forms.SaveFileDialog exportFileDialog;
        private System.Windows.Forms.Timer reloadTimer;
        private System.Windows.Forms.ContextMenuStrip contextMenuDoc;
        private System.Windows.Forms.ToolStripMenuItem newFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importNewPartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addInternalRelationshipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addExternalRelationshipToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuFolder;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ContextMenuStrip contextMenuPart;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem16;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem17;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem18;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem19;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem20;
        private System.Windows.Forms.ContextMenuStrip contextMenuRel;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem21;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem22;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem30;
        private System.Windows.Forms.ToolStripMenuItem addNewPartToolStripMenuItem;
    }
}