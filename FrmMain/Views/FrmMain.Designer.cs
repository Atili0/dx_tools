using System.Drawing;

namespace DeXrm.Win.Tools
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.webResourceDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.ofdPath = new System.Windows.Forms.OpenFileDialog();
            this.ofdOldPackage = new System.Windows.Forms.OpenFileDialog();
            this.toolStaTool = new System.Windows.Forms.ToolStripStatusLabel();
            this.staLabelTool = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelStatusTool = new System.Windows.Forms.ToolStripStatusLabel();
            this.auUpdate = new wyDay.Controls.AutomaticUpdater();
            this.cmsQuery = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.entitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.c1_DockingTab = new C1.Win.C1Command.C1DockingTab();
            this.c1_doc_page_Export = new C1.Win.C1Command.C1DockingTabPage();
            this.c1_dgwPlugin = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.c1_doc_page_Import = new C1.Win.C1Command.C1DockingTabPage();
            this.c1_doc_page_publish = new C1.Win.C1Command.C1DockingTabPage();
            this.c1_cbSolution = new C1.Win.C1List.C1Combo();
            this.c1_btnBuscar = new System.Windows.Forms.Button();
            this.c1_dgwResources = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.lbl_Solution = new System.Windows.Forms.Label();
            this.c1DockingTabPage1 = new C1.Win.C1Command.C1DockingTabPage();
            this.cgServerPro = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.cgServerPre = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.c1_doc_page_administration = new C1.Win.C1Command.C1DockingTabPage();
            this.c1SplitContainer2 = new C1.Win.C1SplitContainer.C1SplitContainer();
            this.c1_spOption = new C1.Win.C1SplitContainer.C1SplitterPanel();
            this.btn_BuscarEntity = new System.Windows.Forms.Button();
            this.lblSolution = new System.Windows.Forms.Label();
            this.c1_cbEntity = new C1.Win.C1List.C1Combo();
            this.c1SplitContainer1 = new C1.Win.C1SplitContainer.C1SplitContainer();
            this.c1_spCampos = new C1.Win.C1SplitContainer.C1SplitterPanel();
            this.c1_AttributeGrid = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.c1_spAtributos = new C1.Win.C1SplitContainer.C1SplitterPanel();
            this.ribbonApplicationMenu1 = new C1.Win.C1Ribbon.RibbonApplicationMenu();
            this.ribbonConfigToolBar1 = new C1.Win.C1Ribbon.RibbonConfigToolBar();
            this.ribbonContextualTabGroup1 = new C1.Win.C1Ribbon.RibbonContextualTabGroup();
            this.ribbonQat1 = new C1.Win.C1Ribbon.RibbonQat();
            this.c1_rbtConnection = new C1.Win.C1Ribbon.RibbonTab();
            this.ribbonGroup1 = new C1.Win.C1Ribbon.RibbonGroup();
            this.c1_rbbConnectToServer = new C1.Win.C1Ribbon.RibbonButton();
            this.c1_rbbDisconnectToServer = new C1.Win.C1Ribbon.RibbonButton();
            this.ribbonGroup2 = new C1.Win.C1Ribbon.RibbonGroup();
            this.c1_rbsTools = new C1.Win.C1Ribbon.RibbonSplitButton();
            this.c1_rbbExport = new C1.Win.C1Ribbon.RibbonButton();
            this.c1_rbbImport = new C1.Win.C1Ribbon.RibbonButton();
            this.c1_rbbPublish = new C1.Win.C1Ribbon.RibbonButton();
            this.c1_rbbAdministration = new C1.Win.C1Ribbon.RibbonButton();
            this.c1_rbtExport = new C1.Win.C1Ribbon.RibbonTab();
            this.ribbonGroup3 = new C1.Win.C1Ribbon.RibbonGroup();
            this.c1_rbbShowPlugin = new C1.Win.C1Ribbon.RibbonButton();
            this.c1_rbtImports = new C1.Win.C1Ribbon.RibbonTab();
            this.ribbonGroup4 = new C1.Win.C1Ribbon.RibbonGroup();
            this.c1_rbbImportConection = new C1.Win.C1Ribbon.RibbonButton();
            this.c1_rbbBuscarDatosVista = new C1.Win.C1Ribbon.RibbonButton();
            this.c1_rbbTestView = new C1.Win.C1Ribbon.RibbonButton();
            this.c1_rbbImportView = new C1.Win.C1Ribbon.RibbonButton();
            this.c1_rbtQuickPublish = new C1.Win.C1Ribbon.RibbonTab();
            this.ribbonGroup5 = new C1.Win.C1Ribbon.RibbonGroup();
            this.c1_rbbOpenConfiguration = new C1.Win.C1Ribbon.RibbonButton();
            this.c1_rbbSaveConfiguration = new C1.Win.C1Ribbon.RibbonButton();
            this.ribbonSeparator1 = new C1.Win.C1Ribbon.RibbonSeparator();
            this.c1_rbPublish = new C1.Win.C1Ribbon.RibbonSplitButton();
            this.c1_rbbPublishAll = new C1.Win.C1Ribbon.RibbonButton();
            this.c1_rbbPublishSelected = new C1.Win.C1Ribbon.RibbonButton();
            this.rbbDeploy = new C1.Win.C1Ribbon.RibbonButton();
            this.c1_rbtAdministration = new C1.Win.C1Ribbon.RibbonTab();
            this.ribbonGroup6 = new C1.Win.C1Ribbon.RibbonGroup();
            this.rbbNew = new C1.Win.C1Ribbon.RibbonButton();
            this.ribbonButton1 = new C1.Win.C1Ribbon.RibbonButton();
            this.rbbSaveAdmin = new C1.Win.C1Ribbon.RibbonButton();
            this.ribbonSplitButton1 = new C1.Win.C1Ribbon.RibbonSplitButton();
            this.rbbAqui = new C1.Win.C1Ribbon.RibbonButton();
            this.rbbEnviarCampo = new C1.Win.C1Ribbon.RibbonButton();
            this.rbbImportEntity = new C1.Win.C1Ribbon.RibbonButton();
            this.c1Ribbon1 = new C1.Win.C1Ribbon.C1Ribbon();
            this.ribbonBottomToolBar1 = new C1.Win.C1Ribbon.RibbonBottomToolBar();
            this.ribbonTopToolBar1 = new C1.Win.C1Ribbon.RibbonTopToolBar();
            this.ribbonApplicationMenu2 = new C1.Win.C1Ribbon.RibbonApplicationMenu();
            this.ribbonQat2 = new C1.Win.C1Ribbon.RibbonQat();
            this.ribbonConfigToolBar2 = new C1.Win.C1Ribbon.RibbonConfigToolBar();
            this.ribbonTab1 = new C1.Win.C1Ribbon.RibbonTab();
            this.ribbonGroup7 = new C1.Win.C1Ribbon.RibbonGroup();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.c1CommandHolder1 = new C1.Win.C1Command.C1CommandHolder();
            this.c1StatusBar1 = new C1.Win.C1Ribbon.C1StatusBar();
            this.ribbonUserConnection = new C1.Win.C1Ribbon.RibbonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.webResourceDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.auUpdate)).BeginInit();
            this.cmsQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1_DockingTab)).BeginInit();
            this.c1_DockingTab.SuspendLayout();
            this.c1_doc_page_Export.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1_dgwPlugin)).BeginInit();
            this.c1_doc_page_publish.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1_cbSolution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1_dgwResources)).BeginInit();
            this.c1DockingTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cgServerPro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cgServerPre)).BeginInit();
            this.c1_doc_page_administration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer2)).BeginInit();
            this.c1SplitContainer2.SuspendLayout();
            this.c1_spOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1_cbEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer1)).BeginInit();
            this.c1SplitContainer1.SuspendLayout();
            this.c1_spCampos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1_AttributeGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1StatusBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Size = new System.Drawing.Size(636, 335);
            this.splitContainer2.SplitterDistance = 212;
            this.splitContainer2.TabIndex = 0;
            // 
            // toolStaTool
            // 
            this.toolStaTool.Name = "toolStaTool";
            this.toolStaTool.Size = new System.Drawing.Size(75, 17);
            this.toolStaTool.Text = "Conectado a :";
            // 
            // staLabelTool
            // 
            this.staLabelTool.Name = "staLabelTool";
            this.staLabelTool.Size = new System.Drawing.Size(0, 17);
            // 
            // labelStatusTool
            // 
            this.labelStatusTool.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelStatusTool.Name = "labelStatusTool";
            this.labelStatusTool.Size = new System.Drawing.Size(0, 17);
            // 
            // auUpdate
            // 
            this.auUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.auUpdate.ContainerForm = this;
            this.auUpdate.GUID = "bf3e6035-5ab9-45a9-ae1a-31e8455ba23b";
            this.auUpdate.Location = new System.Drawing.Point(1136, 642);
            this.auUpdate.Name = "auUpdate";
            this.auUpdate.Size = new System.Drawing.Size(16, 16);
            this.auUpdate.TabIndex = 3;
            this.auUpdate.wyUpdateCommandline = null;
            // 
            // cmsQuery
            // 
            this.cmsQuery.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entitiesToolStripMenuItem});
            this.cmsQuery.Name = "cmsQuery";
            this.cmsQuery.Size = new System.Drawing.Size(113, 26);
            // 
            // entitiesToolStripMenuItem
            // 
            this.entitiesToolStripMenuItem.CheckOnClick = true;
            this.entitiesToolStripMenuItem.Name = "entitiesToolStripMenuItem";
            this.entitiesToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.entitiesToolStripMenuItem.Text = "Entities";
            // 
            // c1_DockingTab
            // 
            this.c1_DockingTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c1_DockingTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.c1_DockingTab.CanAutoHide = true;
            this.c1_DockingTab.CanMoveTabs = true;
            this.c1_DockingTab.Controls.Add(this.c1_doc_page_Export);
            this.c1_DockingTab.Controls.Add(this.c1_doc_page_Import);
            this.c1_DockingTab.Controls.Add(this.c1_doc_page_publish);
            this.c1_DockingTab.Controls.Add(this.c1DockingTabPage1);
            this.c1_DockingTab.Controls.Add(this.c1_doc_page_administration);
            this.c1_DockingTab.HotTrack = true;
            this.c1_DockingTab.Location = new System.Drawing.Point(0, 159);
            this.c1_DockingTab.Name = "c1_DockingTab";
            this.c1_DockingTab.SelectedIndex = 4;
            this.c1_DockingTab.ShowSingleTab = false;
            this.c1_DockingTab.ShowTabList = true;
            this.c1_DockingTab.Size = new System.Drawing.Size(1170, 474);
            this.c1_DockingTab.TabAreaBorder = true;
            this.c1_DockingTab.TabIndex = 0;
            this.c1_DockingTab.TabsSpacing = 5;
            this.c1_DockingTab.TabStyle = C1.Win.C1Command.TabStyleEnum.Sloping;
            // 
            // c1_doc_page_Export
            // 
            this.c1_doc_page_Export.Controls.Add(this.c1_dgwPlugin);
            this.c1_doc_page_Export.Location = new System.Drawing.Point(1, 24);
            this.c1_doc_page_Export.Name = "c1_doc_page_Export";
            this.c1_doc_page_Export.Size = new System.Drawing.Size(1168, 449);
            this.c1_doc_page_Export.TabIndex = 0;
            this.c1_doc_page_Export.TabVisible = false;
            this.c1_doc_page_Export.Text = "Export Plugin";
            this.c1_doc_page_Export.Visible = false;
            // 
            // c1_dgwPlugin
            // 
            this.c1_dgwPlugin.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None;
            this.c1_dgwPlugin.ColumnInfo = resources.GetString("c1_dgwPlugin.ColumnInfo");
            this.c1_dgwPlugin.Location = new System.Drawing.Point(3, 4);
            this.c1_dgwPlugin.Name = "c1_dgwPlugin";
            this.c1_dgwPlugin.Rows.DefaultSize = 19;
            this.c1_dgwPlugin.Size = new System.Drawing.Size(1162, 442);
            this.c1_dgwPlugin.TabIndex = 0;
            this.c1_dgwPlugin.Click += new System.EventHandler(this.c1_dgwPlugin_Click);
            // 
            // c1_doc_page_Import
            // 
            this.c1_doc_page_Import.Location = new System.Drawing.Point(1, 24);
            this.c1_doc_page_Import.Name = "c1_doc_page_Import";
            this.c1_doc_page_Import.Size = new System.Drawing.Size(1168, 449);
            this.c1_doc_page_Import.TabIndex = 1;
            this.c1_doc_page_Import.TabVisible = false;
            this.c1_doc_page_Import.Text = "Import";
            this.c1_doc_page_Import.Visible = false;
            // 
            // c1_doc_page_publish
            // 
            this.c1_doc_page_publish.Controls.Add(this.c1_cbSolution);
            this.c1_doc_page_publish.Controls.Add(this.c1_btnBuscar);
            this.c1_doc_page_publish.Controls.Add(this.c1_dgwResources);
            this.c1_doc_page_publish.Controls.Add(this.lbl_Solution);
            this.c1_doc_page_publish.Location = new System.Drawing.Point(1, 24);
            this.c1_doc_page_publish.Name = "c1_doc_page_publish";
            this.c1_doc_page_publish.Size = new System.Drawing.Size(1168, 449);
            this.c1_doc_page_publish.TabIndex = 2;
            this.c1_doc_page_publish.TabVisible = false;
            this.c1_doc_page_publish.Text = "Pusblish";
            this.c1_doc_page_publish.Visible = false;
            // 
            // c1_cbSolution
            // 
            this.c1_cbSolution.AddItemSeparator = ';';
            this.c1_cbSolution.AllowHorizontalSplit = true;
            this.c1_cbSolution.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c1_cbSolution.AutoCompletion = true;
            this.c1_cbSolution.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.c1_cbSolution.Caption = "";
            this.c1_cbSolution.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.c1_cbSolution.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.c1_cbSolution.EditorBackColor = System.Drawing.SystemColors.Window;
            this.c1_cbSolution.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1_cbSolution.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.c1_cbSolution.Images.Add(((System.Drawing.Image)(resources.GetObject("c1_cbSolution.Images"))));
            this.c1_cbSolution.Location = new System.Drawing.Point(68, 10);
            this.c1_cbSolution.MatchEntryTimeout = ((long)(2000));
            this.c1_cbSolution.MaxDropDownItems = ((short)(5));
            this.c1_cbSolution.MaxLength = 32767;
            this.c1_cbSolution.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.c1_cbSolution.Name = "c1_cbSolution";
            this.c1_cbSolution.PropBag = resources.GetString("c1_cbSolution.PropBag");
            this.c1_cbSolution.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.c1_cbSolution.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.c1_cbSolution.Size = new System.Drawing.Size(1027, 19);
            this.c1_cbSolution.TabIndex = 7;
            this.c1_cbSolution.VisualStyle = C1.Win.C1List.VisualStyle.System;
            // 
            // c1_btnBuscar
            // 
            this.c1_btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.c1_btnBuscar.AutoSize = true;
            this.c1_btnBuscar.Location = new System.Drawing.Point(1101, 10);
            this.c1_btnBuscar.Name = "c1_btnBuscar";
            this.c1_btnBuscar.Size = new System.Drawing.Size(50, 23);
            this.c1_btnBuscar.TabIndex = 6;
            this.c1_btnBuscar.Text = "Buscar";
            this.c1_btnBuscar.UseVisualStyleBackColor = true;
            // 
            // c1_dgwResources
            // 
            this.c1_dgwResources.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this.c1_dgwResources.AllowFiltering = true;
            this.c1_dgwResources.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c1_dgwResources.ColumnInfo = resources.GetString("c1_dgwResources.ColumnInfo");
            this.c1_dgwResources.Location = new System.Drawing.Point(11, 37);
            this.c1_dgwResources.Name = "c1_dgwResources";
            this.c1_dgwResources.Rows.DefaultSize = 19;
            this.c1_dgwResources.Size = new System.Drawing.Size(1154, 409);
            this.c1_dgwResources.TabIndex = 5;
            // 
            // lbl_Solution
            // 
            this.lbl_Solution.AutoSize = true;
            this.lbl_Solution.Location = new System.Drawing.Point(11, 15);
            this.lbl_Solution.Name = "lbl_Solution";
            this.lbl_Solution.Size = new System.Drawing.Size(51, 13);
            this.lbl_Solution.TabIndex = 3;
            this.lbl_Solution.Text = "Soluction";
            // 
            // c1DockingTabPage1
            // 
            this.c1DockingTabPage1.Controls.Add(this.cgServerPro);
            this.c1DockingTabPage1.Controls.Add(this.cgServerPre);
            this.c1DockingTabPage1.Location = new System.Drawing.Point(1, 24);
            this.c1DockingTabPage1.Name = "c1DockingTabPage1";
            this.c1DockingTabPage1.Size = new System.Drawing.Size(1168, 449);
            this.c1DockingTabPage1.TabIndex = 4;
            this.c1DockingTabPage1.Text = "Deploy";
            // 
            // cgServerPro
            // 
            this.cgServerPro.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this.cgServerPro.AllowFiltering = true;
            this.cgServerPro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cgServerPro.ColumnInfo = resources.GetString("cgServerPro.ColumnInfo");
            this.cgServerPro.Location = new System.Drawing.Point(585, 3);
            this.cgServerPro.Name = "cgServerPro";
            this.cgServerPro.Rows.DefaultSize = 19;
            this.cgServerPro.Size = new System.Drawing.Size(580, 439);
            this.cgServerPro.TabIndex = 10;
            // 
            // cgServerPre
            // 
            this.cgServerPre.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this.cgServerPre.AllowFiltering = true;
            this.cgServerPre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cgServerPre.ColumnInfo = resources.GetString("cgServerPre.ColumnInfo");
            this.cgServerPre.Location = new System.Drawing.Point(7, 3);
            this.cgServerPre.Name = "cgServerPre";
            this.cgServerPre.Rows.DefaultSize = 19;
            this.cgServerPre.Size = new System.Drawing.Size(572, 439);
            this.cgServerPre.TabIndex = 9;
            // 
            // c1_doc_page_administration
            // 
            this.c1_doc_page_administration.Controls.Add(this.c1SplitContainer2);
            this.c1_doc_page_administration.Controls.Add(this.c1SplitContainer1);
            this.c1_doc_page_administration.Location = new System.Drawing.Point(1, 24);
            this.c1_doc_page_administration.Name = "c1_doc_page_administration";
            this.c1_doc_page_administration.Size = new System.Drawing.Size(1168, 449);
            this.c1_doc_page_administration.TabIndex = 3;
            this.c1_doc_page_administration.TabVisible = false;
            this.c1_doc_page_administration.Text = "Administration";
            this.c1_doc_page_administration.Visible = false;
            // 
            // c1SplitContainer2
            // 
            this.c1SplitContainer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.c1SplitContainer2.CollapsingCueColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(150)))));
            this.c1SplitContainer2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.c1SplitContainer2.Location = new System.Drawing.Point(3, 3);
            this.c1SplitContainer2.Name = "c1SplitContainer2";
            this.c1SplitContainer2.Panels.Add(this.c1_spOption);
            this.c1SplitContainer2.Size = new System.Drawing.Size(1162, 33);
            this.c1SplitContainer2.TabIndex = 1;
            // 
            // c1_spOption
            // 
            this.c1_spOption.Collapsible = true;
            this.c1_spOption.Controls.Add(this.btn_BuscarEntity);
            this.c1_spOption.Controls.Add(this.lblSolution);
            this.c1_spOption.Controls.Add(this.c1_cbEntity);
            this.c1_spOption.Height = 33;
            this.c1_spOption.Location = new System.Drawing.Point(0, 0);
            this.c1_spOption.Name = "c1_spOption";
            this.c1_spOption.Size = new System.Drawing.Size(1162, 33);
            this.c1_spOption.TabIndex = 0;
            // 
            // btn_BuscarEntity
            // 
            this.btn_BuscarEntity.Location = new System.Drawing.Point(1084, 3);
            this.btn_BuscarEntity.Name = "btn_BuscarEntity";
            this.btn_BuscarEntity.Size = new System.Drawing.Size(75, 23);
            this.btn_BuscarEntity.TabIndex = 2;
            this.btn_BuscarEntity.Text = "Buscar";
            this.btn_BuscarEntity.UseVisualStyleBackColor = true;
            // 
            // lblSolution
            // 
            this.lblSolution.AutoSize = true;
            this.lblSolution.Location = new System.Drawing.Point(8, 9);
            this.lblSolution.Name = "lblSolution";
            this.lblSolution.Size = new System.Drawing.Size(43, 13);
            this.lblSolution.TabIndex = 1;
            this.lblSolution.Text = "Entidad";
            // 
            // c1_cbEntity
            // 
            this.c1_cbEntity.AddItemSeparator = ';';
            this.c1_cbEntity.Caption = "";
            this.c1_cbEntity.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.c1_cbEntity.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.c1_cbEntity.EditorBackColor = System.Drawing.SystemColors.Window;
            this.c1_cbEntity.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1_cbEntity.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.c1_cbEntity.Images.Add(((System.Drawing.Image)(resources.GetObject("c1_cbEntity.Images"))));
            this.c1_cbEntity.Location = new System.Drawing.Point(57, 3);
            this.c1_cbEntity.MatchEntryTimeout = ((long)(2000));
            this.c1_cbEntity.MaxDropDownItems = ((short)(5));
            this.c1_cbEntity.MaxLength = 32767;
            this.c1_cbEntity.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.c1_cbEntity.Name = "c1_cbEntity";
            this.c1_cbEntity.PropBag = resources.GetString("c1_cbEntity.PropBag");
            this.c1_cbEntity.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.c1_cbEntity.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.c1_cbEntity.Size = new System.Drawing.Size(1021, 21);
            this.c1_cbEntity.TabIndex = 0;
            // 
            // c1SplitContainer1
            // 
            this.c1SplitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.c1SplitContainer1.CollapsingCueColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(150)))));
            this.c1SplitContainer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.c1SplitContainer1.Location = new System.Drawing.Point(3, 42);
            this.c1SplitContainer1.Name = "c1SplitContainer1";
            this.c1SplitContainer1.Panels.Add(this.c1_spCampos);
            this.c1SplitContainer1.Panels.Add(this.c1_spAtributos);
            this.c1SplitContainer1.Size = new System.Drawing.Size(1162, 404);
            this.c1SplitContainer1.TabIndex = 0;
            this.c1SplitContainer1.UseParentVisualStyle = false;
            // 
            // c1_spCampos
            // 
            this.c1_spCampos.Collapsible = true;
            this.c1_spCampos.Controls.Add(this.c1_AttributeGrid);
            this.c1_spCampos.Dock = C1.Win.C1SplitContainer.PanelDockStyle.Left;
            this.c1_spCampos.Location = new System.Drawing.Point(0, 21);
            this.c1_spCampos.Name = "c1_spCampos";
            this.c1_spCampos.ResizeWhileDragging = true;
            this.c1_spCampos.Size = new System.Drawing.Size(293, 383);
            this.c1_spCampos.SizeRatio = 25.907D;
            this.c1_spCampos.TabIndex = 0;
            this.c1_spCampos.Text = "Campos";
            this.c1_spCampos.Width = 293;
            // 
            // c1_AttributeGrid
            // 
            this.c1_AttributeGrid.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this.c1_AttributeGrid.AllowFiltering = true;
            this.c1_AttributeGrid.ColumnInfo = resources.GetString("c1_AttributeGrid.ColumnInfo");
            this.c1_AttributeGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1_AttributeGrid.Location = new System.Drawing.Point(0, 0);
            this.c1_AttributeGrid.Name = "c1_AttributeGrid";
            this.c1_AttributeGrid.Rows.DefaultSize = 19;
            this.c1_AttributeGrid.Size = new System.Drawing.Size(293, 383);
            this.c1_AttributeGrid.TabIndex = 0;
            // 
            // c1_spAtributos
            // 
            this.c1_spAtributos.Collapsible = true;
            this.c1_spAtributos.Dock = C1.Win.C1SplitContainer.PanelDockStyle.Bottom;
            this.c1_spAtributos.Height = 404;
            this.c1_spAtributos.Location = new System.Drawing.Point(304, 21);
            this.c1_spAtributos.Name = "c1_spAtributos";
            this.c1_spAtributos.ResizeWhileDragging = true;
            this.c1_spAtributos.Size = new System.Drawing.Size(858, 383);
            this.c1_spAtributos.TabIndex = 1;
            this.c1_spAtributos.Text = "Detalle";
            // 
            // ribbonApplicationMenu1
            // 
            this.ribbonApplicationMenu1.Name = "ribbonApplicationMenu1";
            // 
            // ribbonConfigToolBar1
            // 
            this.ribbonConfigToolBar1.Name = "ribbonConfigToolBar1";
            // 
            // ribbonContextualTabGroup1
            // 
            this.ribbonContextualTabGroup1.Color = C1.Win.C1Ribbon.ContextualTabColor.Blue;
            this.ribbonContextualTabGroup1.Name = "ribbonContextualTabGroup1";
            this.ribbonContextualTabGroup1.Text = "DeXrm Tools";
            // 
            // ribbonQat1
            // 
            this.ribbonQat1.Name = "ribbonQat1";
            // 
            // c1_rbtConnection
            // 
            this.c1_rbtConnection.Groups.Add(this.ribbonGroup1);
            this.c1_rbtConnection.Groups.Add(this.ribbonGroup2);
            this.c1_rbtConnection.Name = "c1_rbtConnection";
            this.c1_rbtConnection.Text = "Configuration";
            // 
            // ribbonGroup1
            // 
            this.ribbonGroup1.Items.Add(this.c1_rbbConnectToServer);
            this.ribbonGroup1.Items.Add(this.c1_rbbDisconnectToServer);
            this.ribbonGroup1.Name = "ribbonGroup1";
            this.ribbonGroup1.Text = "Connection";
            // 
            // c1_rbbConnectToServer
            // 
            this.c1_rbbConnectToServer.LargeImage = global::DeXrm.Win.Tools.rsTool.ClientToServer32;
            this.c1_rbbConnectToServer.Name = "c1_rbbConnectToServer";
            this.c1_rbbConnectToServer.SmallImage = ((System.Drawing.Image)(resources.GetObject("c1_rbbConnectToServer.SmallImage")));
            this.c1_rbbConnectToServer.Text = "Connect";
            // 
            // c1_rbbDisconnectToServer
            // 
            this.c1_rbbDisconnectToServer.LargeImage = global::DeXrm.Win.Tools.rsTool.ClientToServer321;
            this.c1_rbbDisconnectToServer.Name = "c1_rbbDisconnectToServer";
            this.c1_rbbDisconnectToServer.SmallImage = ((System.Drawing.Image)(resources.GetObject("c1_rbbDisconnectToServer.SmallImage")));
            this.c1_rbbDisconnectToServer.Text = "Disconnect";
            // 
            // ribbonGroup2
            // 
            this.ribbonGroup2.Items.Add(this.c1_rbsTools);
            this.ribbonGroup2.Name = "ribbonGroup2";
            this.ribbonGroup2.Text = "Tools";
            // 
            // c1_rbsTools
            // 
            this.c1_rbsTools.Enabled = false;
            this.c1_rbsTools.Items.Add(this.c1_rbbExport);
            this.c1_rbsTools.Items.Add(this.c1_rbbImport);
            this.c1_rbsTools.Items.Add(this.c1_rbbPublish);
            this.c1_rbsTools.Items.Add(this.c1_rbbAdministration);
            this.c1_rbsTools.LargeImage = global::DeXrm.Win.Tools.rsTool.Contents_32;
            this.c1_rbsTools.Name = "c1_rbsTools";
            this.c1_rbsTools.SmallImage = ((System.Drawing.Image)(resources.GetObject("c1_rbsTools.SmallImage")));
            this.c1_rbsTools.Text = "Tools";
            // 
            // c1_rbbExport
            // 
            this.c1_rbbExport.Name = "c1_rbbExport";
            this.c1_rbbExport.SmallImage = ((System.Drawing.Image)(resources.GetObject("c1_rbbExport.SmallImage")));
            this.c1_rbbExport.Text = "Export";
            // 
            // c1_rbbImport
            // 
            this.c1_rbbImport.Name = "c1_rbbImport";
            this.c1_rbbImport.SmallImage = ((System.Drawing.Image)(resources.GetObject("c1_rbbImport.SmallImage")));
            this.c1_rbbImport.Text = "Import";
            // 
            // c1_rbbPublish
            // 
            this.c1_rbbPublish.Name = "c1_rbbPublish";
            this.c1_rbbPublish.SmallImage = ((System.Drawing.Image)(resources.GetObject("c1_rbbPublish.SmallImage")));
            this.c1_rbbPublish.Text = "Publish";
            // 
            // c1_rbbAdministration
            // 
            this.c1_rbbAdministration.Name = "c1_rbbAdministration";
            this.c1_rbbAdministration.SmallImage = global::DeXrm.Win.Tools.rsTool.analysis;
            this.c1_rbbAdministration.Text = "Administration (pronto)";
            // 
            // c1_rbtExport
            // 
            this.c1_rbtExport.Groups.Add(this.ribbonGroup3);
            this.c1_rbtExport.Name = "c1_rbtExport";
            this.c1_rbtExport.Text = "Export";
            // 
            // ribbonGroup3
            // 
            this.ribbonGroup3.Items.Add(this.c1_rbbShowPlugin);
            this.ribbonGroup3.Name = "ribbonGroup3";
            this.ribbonGroup3.Text = "Plugin";
            // 
            // c1_rbbShowPlugin
            // 
            this.c1_rbbShowPlugin.Name = "c1_rbbShowPlugin";
            this.c1_rbbShowPlugin.SmallImage = ((System.Drawing.Image)(resources.GetObject("c1_rbbShowPlugin.SmallImage")));
            this.c1_rbbShowPlugin.Text = "Export Plugin";
            // 
            // c1_rbtImports
            // 
            this.c1_rbtImports.Groups.Add(this.ribbonGroup4);
            this.c1_rbtImports.Name = "c1_rbtImports";
            this.c1_rbtImports.Text = "Import";
            // 
            // ribbonGroup4
            // 
            this.ribbonGroup4.Items.Add(this.c1_rbbImportConection);
            this.ribbonGroup4.Items.Add(this.c1_rbbBuscarDatosVista);
            this.ribbonGroup4.Items.Add(this.c1_rbbTestView);
            this.ribbonGroup4.Items.Add(this.c1_rbbImportView);
            this.ribbonGroup4.Name = "ribbonGroup4";
            this.ribbonGroup4.Text = "Connection";
            // 
            // c1_rbbImportConection
            // 
            this.c1_rbbImportConection.Name = "c1_rbbImportConection";
            this.c1_rbbImportConection.SmallImage = ((System.Drawing.Image)(resources.GetObject("c1_rbbImportConection.SmallImage")));
            this.c1_rbbImportConection.Text = "Destination CRM";
            // 
            // c1_rbbBuscarDatosVista
            // 
            this.c1_rbbBuscarDatosVista.Name = "c1_rbbBuscarDatosVista";
            this.c1_rbbBuscarDatosVista.SmallImage = ((System.Drawing.Image)(resources.GetObject("c1_rbbBuscarDatosVista.SmallImage")));
            this.c1_rbbBuscarDatosVista.Text = "Buscar detalle";
            // 
            // c1_rbbTestView
            // 
            this.c1_rbbTestView.Name = "c1_rbbTestView";
            this.c1_rbbTestView.SmallImage = ((System.Drawing.Image)(resources.GetObject("c1_rbbTestView.SmallImage")));
            this.c1_rbbTestView.Text = "Ver data a importar";
            // 
            // c1_rbbImportView
            // 
            this.c1_rbbImportView.Name = "c1_rbbImportView";
            this.c1_rbbImportView.SmallImage = ((System.Drawing.Image)(resources.GetObject("c1_rbbImportView.SmallImage")));
            this.c1_rbbImportView.Text = "Importar";
            // 
            // c1_rbtQuickPublish
            // 
            this.c1_rbtQuickPublish.Groups.Add(this.ribbonGroup5);
            this.c1_rbtQuickPublish.Name = "c1_rbtQuickPublish";
            this.c1_rbtQuickPublish.Text = "Publish";
            // 
            // ribbonGroup5
            // 
            this.ribbonGroup5.Items.Add(this.c1_rbbOpenConfiguration);
            this.ribbonGroup5.Items.Add(this.c1_rbbSaveConfiguration);
            this.ribbonGroup5.Items.Add(this.ribbonSeparator1);
            this.ribbonGroup5.Items.Add(this.c1_rbPublish);
            this.ribbonGroup5.Items.Add(this.rbbDeploy);
            this.ribbonGroup5.Name = "ribbonGroup5";
            this.ribbonGroup5.Text = "Publish";
            // 
            // c1_rbbOpenConfiguration
            // 
            this.c1_rbbOpenConfiguration.LargeImage = global::DeXrm.Win.Tools.rsTool.folder_black_parent;
            this.c1_rbbOpenConfiguration.Name = "c1_rbbOpenConfiguration";
            this.c1_rbbOpenConfiguration.SmallImage = ((System.Drawing.Image)(resources.GetObject("c1_rbbOpenConfiguration.SmallImage")));
            this.c1_rbbOpenConfiguration.Text = "Open";
            // 
            // c1_rbbSaveConfiguration
            // 
            this.c1_rbbSaveConfiguration.LargeImage = global::DeXrm.Win.Tools.rsTool.Save_32;
            this.c1_rbbSaveConfiguration.Name = "c1_rbbSaveConfiguration";
            this.c1_rbbSaveConfiguration.SmallImage = ((System.Drawing.Image)(resources.GetObject("c1_rbbSaveConfiguration.SmallImage")));
            this.c1_rbbSaveConfiguration.Text = "Save";
            // 
            // ribbonSeparator1
            // 
            this.ribbonSeparator1.Name = "ribbonSeparator1";
            // 
            // c1_rbPublish
            // 
            this.c1_rbPublish.Items.Add(this.c1_rbbPublishAll);
            this.c1_rbPublish.Items.Add(this.c1_rbbPublishSelected);
            this.c1_rbPublish.LargeImage = global::DeXrm.Win.Tools.rsTool.PublishAllCustomizations_32;
            this.c1_rbPublish.Name = "c1_rbPublish";
            this.c1_rbPublish.SmallImage = ((System.Drawing.Image)(resources.GetObject("c1_rbPublish.SmallImage")));
            this.c1_rbPublish.Text = "Publish";
            // 
            // c1_rbbPublishAll
            // 
            this.c1_rbbPublishAll.Name = "c1_rbbPublishAll";
            this.c1_rbbPublishAll.SmallImage = global::DeXrm.Win.Tools.rsTool.PublishAllCustomizations_32;
            this.c1_rbbPublishAll.Text = "Publish all";
            // 
            // c1_rbbPublishSelected
            // 
            this.c1_rbbPublishSelected.Name = "c1_rbbPublishSelected";
            this.c1_rbbPublishSelected.SmallImage = global::DeXrm.Win.Tools.rsTool.PublishAllCustomizations_32;
            this.c1_rbbPublishSelected.Text = "Publish selected";
            // 
            // rbbDeploy
            // 
            this.rbbDeploy.Enabled = false;
            this.rbbDeploy.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbbDeploy.LargeImage")));
            this.rbbDeploy.Name = "rbbDeploy";
            this.rbbDeploy.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbbDeploy.SmallImage")));
            this.rbbDeploy.Text = "Deploy";
            // 
            // c1_rbtAdministration
            // 
            this.c1_rbtAdministration.Groups.Add(this.ribbonGroup6);
            this.c1_rbtAdministration.Name = "c1_rbtAdministration";
            this.c1_rbtAdministration.Text = "Administration";
            // 
            // ribbonGroup6
            // 
            this.ribbonGroup6.Items.Add(this.rbbNew);
            this.ribbonGroup6.Items.Add(this.ribbonButton1);
            this.ribbonGroup6.Items.Add(this.rbbSaveAdmin);
            this.ribbonGroup6.Items.Add(this.ribbonSplitButton1);
            this.ribbonGroup6.Items.Add(this.rbbImportEntity);
            this.ribbonGroup6.Name = "ribbonGroup6";
            this.ribbonGroup6.Text = "Options";
            // 
            // rbbNew
            // 
            this.rbbNew.LargeImage = global::DeXrm.Win.Tools.rsTool._new;
            this.rbbNew.Name = "rbbNew";
            this.rbbNew.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbbNew.SmallImage")));
            this.rbbNew.Text = "Nueva Entidad";
            // 
            // ribbonButton1
            // 
            this.ribbonButton1.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.LargeImage")));
            this.ribbonButton1.Name = "ribbonButton1";
            this.ribbonButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.SmallImage")));
            this.ribbonButton1.Text = "Nuevo Campo";
            // 
            // rbbSaveAdmin
            // 
            this.rbbSaveAdmin.LargeImage = global::DeXrm.Win.Tools.rsTool.Save_32;
            this.rbbSaveAdmin.Name = "rbbSaveAdmin";
            this.rbbSaveAdmin.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbbSaveAdmin.SmallImage")));
            this.rbbSaveAdmin.Text = "Guardar";
            // 
            // ribbonSplitButton1
            // 
            this.ribbonSplitButton1.Items.Add(this.rbbAqui);
            this.ribbonSplitButton1.Items.Add(this.rbbEnviarCampo);
            this.ribbonSplitButton1.LargeImage = global::DeXrm.Win.Tools.rsTool.Retweet;
            this.ribbonSplitButton1.Name = "ribbonSplitButton1";
            this.ribbonSplitButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonSplitButton1.SmallImage")));
            this.ribbonSplitButton1.Text = "Duplicar";
            // 
            // rbbAqui
            // 
            this.rbbAqui.Name = "rbbAqui";
            this.rbbAqui.SmallImage = global::DeXrm.Win.Tools.rsTool.bullet_add;
            this.rbbAqui.Text = "Entidad";
            // 
            // rbbEnviarCampo
            // 
            this.rbbEnviarCampo.Name = "rbbEnviarCampo";
            this.rbbEnviarCampo.SmallImage = global::DeXrm.Win.Tools.rsTool.arrow_right;
            this.rbbEnviarCampo.Text = "Campo";
            // 
            // rbbImportEntity
            // 
            this.rbbImportEntity.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbbImportEntity.LargeImage")));
            this.rbbImportEntity.Name = "rbbImportEntity";
            this.rbbImportEntity.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbbImportEntity.SmallImage")));
            this.rbbImportEntity.Text = "Import Entity";
            // 
            // c1Ribbon1
            // 
            this.c1Ribbon1.ApplicationMenuHolder = this.ribbonApplicationMenu1;
            this.c1Ribbon1.BottomToolBarHolder = this.ribbonBottomToolBar1;
            this.c1Ribbon1.ConfigToolBarHolder = this.ribbonConfigToolBar1;
            this.c1Ribbon1.ContextualTabGroups.Add(this.ribbonContextualTabGroup1);
            this.c1Ribbon1.Location = new System.Drawing.Point(0, 0);
            this.c1Ribbon1.Name = "c1Ribbon1";
            this.c1Ribbon1.QatHolder = this.ribbonQat1;
            this.c1Ribbon1.Size = new System.Drawing.Size(1182, 155);
            this.c1Ribbon1.Tabs.Add(this.c1_rbtConnection);
            this.c1Ribbon1.Tabs.Add(this.c1_rbtExport);
            this.c1Ribbon1.Tabs.Add(this.c1_rbtImports);
            this.c1Ribbon1.Tabs.Add(this.c1_rbtQuickPublish);
            this.c1Ribbon1.Tabs.Add(this.c1_rbtAdministration);
            this.c1Ribbon1.TopToolBarHolder = this.ribbonTopToolBar1;
            this.c1Ribbon1.VisualStyle = C1.Win.C1Ribbon.VisualStyle.Office2007Blue;
            // 
            // ribbonBottomToolBar1
            // 
            this.ribbonBottomToolBar1.Name = "ribbonBottomToolBar1";
            // 
            // ribbonTopToolBar1
            // 
            this.ribbonTopToolBar1.Name = "ribbonTopToolBar1";
            // 
            // ribbonApplicationMenu2
            // 
            this.ribbonApplicationMenu2.Name = "ribbonApplicationMenu2";
            // 
            // ribbonQat2
            // 
            this.ribbonQat2.Name = "ribbonQat2";
            // 
            // ribbonConfigToolBar2
            // 
            this.ribbonConfigToolBar2.Name = "ribbonConfigToolBar2";
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Groups.Add(this.ribbonGroup7);
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Text = "Tab";
            // 
            // ribbonGroup7
            // 
            this.ribbonGroup7.Name = "ribbonGroup7";
            this.ribbonGroup7.Text = "Group";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // c1CommandHolder1
            // 
            this.c1CommandHolder1.Owner = this;
            // 
            // c1StatusBar1
            // 
            this.c1StatusBar1.LeftPaneItems.Add(this.ribbonUserConnection);
            this.c1StatusBar1.Location = new System.Drawing.Point(0, 636);
            this.c1StatusBar1.Name = "c1StatusBar1";
            this.c1StatusBar1.Size = new System.Drawing.Size(1182, 22);
            this.c1StatusBar1.VisualStyle = C1.Win.C1Ribbon.VisualStyle.Office2007Blue;
            // 
            // ribbonUserConnection
            // 
            this.ribbonUserConnection.Label = "Connected as :";
            this.ribbonUserConnection.MaxLength = 500;
            this.ribbonUserConnection.Name = "ribbonUserConnection";
            this.ribbonUserConnection.ReadOnly = true;
            this.ribbonUserConnection.TextAreaWidth = 210;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 658);
            this.Controls.Add(this.c1StatusBar1);
            this.Controls.Add(this.c1_DockingTab);
            this.Controls.Add(this.c1Ribbon1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "Dex Tool";
            ((System.ComponentModel.ISupportInitialize)(this.webResourceDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.auUpdate)).EndInit();
            this.cmsQuery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1_DockingTab)).EndInit();
            this.c1_DockingTab.ResumeLayout(false);
            this.c1_doc_page_Export.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1_dgwPlugin)).EndInit();
            this.c1_doc_page_publish.ResumeLayout(false);
            this.c1_doc_page_publish.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1_cbSolution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1_dgwResources)).EndInit();
            this.c1DockingTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cgServerPro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cgServerPre)).EndInit();
            this.c1_doc_page_administration.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer2)).EndInit();
            this.c1SplitContainer2.ResumeLayout(false);
            this.c1_spOption.ResumeLayout(false);
            this.c1_spOption.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1_cbEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer1)).EndInit();
            this.c1SplitContainer1.ResumeLayout(false);
            this.c1_spCampos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1_AttributeGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1StatusBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private System.Windows.Forms.RibbonTab rbtConnection;
        //private System.Windows.Forms.RibbonPanel rbPanel;
        //private System.Windows.Forms.RibbonButton rbbDisconnectToServer;
        //private System.Windows.Forms.RibbonButton rbbPublishSelect;
        //private System.Windows.Forms.RibbonOrbMenuItem rbMenuAbout;
        //private System.Windows.Forms.RibbonButton rbbConnectToServer;
        private System.Windows.Forms.BindingSource webResourceDataBindingSource;
        private System.Windows.Forms.OpenFileDialog ofdPath;
        private System.Windows.Forms.OpenFileDialog ofdOldPackage;
        //private System.Windows.Forms.RibbonPanel rbpTools;
        //private System.Windows.Forms.RibbonButton rbbConfigTool;
        //private System.Windows.Forms.RibbonPanel ribbonPanel1;
        //private System.Windows.Forms.RibbonTab rbtTrace;
        //private System.Windows.Forms.RibbonPanel rbpConfigTrace;
        //private System.Windows.Forms.RibbonButton rbbSetup;
        //private System.Windows.Forms.RibbonButton rbbOpen;
        //private System.Windows.Forms.RibbonButton rbbChart;
        private System.Windows.Forms.DataGridViewTextBoxColumn webResourceIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn displayNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripStatusLabel toolStaTool;
        private System.Windows.Forms.ToolStripStatusLabel staLabelTool;
        private System.Windows.Forms.ToolStripStatusLabel labelStatusTool;
        //private System.Windows.Forms.RibbonTab rbtImports;
        //private System.Windows.Forms.RibbonPanel rbpConection;
        //private System.Windows.Forms.RibbonButton rbbImportConection;
        //private System.Windows.Forms.RibbonButton rbbBuscarDatosVista;
        //private System.Windows.Forms.RibbonButton rbbTestView;
        //private System.Windows.Forms.RibbonButton rbbImportView;
        //private System.Windows.Forms.RibbonTextBox ribbonTextBox1;
        //private System.Windows.Forms.RibbonTab rbtIntellisense;
        //private System.Windows.Forms.RibbonPanel rbPanelIntellisense;
        //private System.Windows.Forms.RibbonButton rbbSaveScript;
        //private System.Windows.Forms.RibbonButton rbbPreviewScript;
        private wyDay.Controls.AutomaticUpdater auUpdate;
        //private System.Windows.Forms.RibbonTab rbExport;
        //private System.Windows.Forms.RibbonPanel rbpExport;
        //private System.Windows.Forms.RibbonButton rbbShowPlugin;
        private System.Windows.Forms.SplitContainer splitContainer2;
        //private System.Windows.Forms.RibbonTab rbtQuery;
        //private System.Windows.Forms.RibbonPanel rbpAction;
        //private System.Windows.Forms.RibbonButton rbbNewQuery;
        //private System.Windows.Forms.RibbonButton rbbOpenQuery;
        //private System.Windows.Forms.RibbonButton rbbSave;
        //private System.Windows.Forms.RibbonPanel rbpQuery;
        //private System.Windows.Forms.RibbonButton rbbExecute;
        private System.Windows.Forms.ContextMenuStrip cmsQuery;
        private System.Windows.Forms.ToolStripMenuItem entitiesToolStripMenuItem;
        //private C1.Win.C1Command.C1DockingTab c1_DockingTab;
        //private C1.Win.C1Command.C1DockingTabPage c1_doc_page_Export;
        private C1.Win.C1FlexGrid.C1FlexGrid c1_dgwPlugin;
        private C1.Win.C1Ribbon.C1Ribbon c1Ribbon1;
        private C1.Win.C1Ribbon.RibbonApplicationMenu ribbonApplicationMenu1;
        private C1.Win.C1Ribbon.RibbonConfigToolBar ribbonConfigToolBar1;
        private C1.Win.C1Ribbon.RibbonContextualTabGroup ribbonContextualTabGroup1;
        private C1.Win.C1Ribbon.RibbonQat ribbonQat1;
        private C1.Win.C1Ribbon.RibbonTab c1_rbtConnection;
        private C1.Win.C1Ribbon.RibbonGroup ribbonGroup1;
        private C1.Win.C1Ribbon.RibbonButton c1_rbbConnectToServer;
        private C1.Win.C1Ribbon.RibbonButton c1_rbbDisconnectToServer;
        private C1.Win.C1Ribbon.RibbonGroup ribbonGroup2;
        private C1.Win.C1Ribbon.RibbonSplitButton c1_rbsTools;
        private C1.Win.C1Ribbon.RibbonButton c1_rbbExport;
        private C1.Win.C1Ribbon.RibbonButton c1_rbbImport;
        private C1.Win.C1Ribbon.RibbonTab c1_rbtExport;
        private C1.Win.C1Ribbon.RibbonGroup ribbonGroup3;
        private C1.Win.C1Ribbon.RibbonButton c1_rbbShowPlugin;
        private C1.Win.C1Ribbon.RibbonTab c1_rbtImports;
        private C1.Win.C1Ribbon.RibbonGroup ribbonGroup4;
        private C1.Win.C1Ribbon.RibbonButton c1_rbbImportConection;
        private C1.Win.C1Ribbon.RibbonButton c1_rbbBuscarDatosVista;
        private C1.Win.C1Ribbon.RibbonButton c1_rbbTestView;
        private C1.Win.C1Ribbon.RibbonButton c1_rbbImportView;
        private C1.Win.C1Ribbon.RibbonTab c1_rbtQuickPublish;
        private C1.Win.C1Ribbon.RibbonGroup ribbonGroup5;
        private C1.Win.C1Ribbon.RibbonButton c1_rbbOpenConfiguration;
        private C1.Win.C1Ribbon.RibbonButton c1_rbbSaveConfiguration;
        private C1.Win.C1Ribbon.RibbonSeparator ribbonSeparator1;
        private C1.Win.C1Ribbon.RibbonSplitButton c1_rbPublish;
        private C1.Win.C1Ribbon.RibbonButton c1_rbbPublishAll;
        private C1.Win.C1Ribbon.RibbonButton c1_rbbPublishSelected;
        private C1.Win.C1Ribbon.RibbonTab c1_rbtAdministration;
        private C1.Win.C1Ribbon.RibbonGroup ribbonGroup6;
        private System.Windows.Forms.Label lbl_Solution;
        private C1.Win.C1Ribbon.RibbonButton c1_rbbPublish;
        //private C1.Win.C1FlexGrid.C1FlexGrid c1_dgwResources;
        private System.Windows.Forms.Button c1_btnBuscar;
        private C1.Win.C1SplitContainer.C1SplitContainer c1SplitContainer2;
        private C1.Win.C1SplitContainer.C1SplitterPanel c1_spOption;
        private System.Windows.Forms.Label lblSolution;
        private C1.Win.C1List.C1Combo c1_cbEntity;
        private C1.Win.C1SplitContainer.C1SplitContainer c1SplitContainer1;
        private C1.Win.C1SplitContainer.C1SplitterPanel c1_spCampos;
        //private C1.Win.C1FlexGrid.C1FlexGrid c1FlexGrid1;
        private C1.Win.C1SplitContainer.C1SplitterPanel c1_spAtributos;
        private C1.Win.C1Ribbon.RibbonButton rbbSaveAdmin;
        private C1.Win.C1Ribbon.RibbonButton rbbNew;
        private C1.Win.C1Ribbon.RibbonSplitButton ribbonSplitButton1;
        private C1.Win.C1Ribbon.RibbonButton rbbAqui;
        private C1.Win.C1Ribbon.RibbonButton rbbEnviarCampo;
        private C1.Win.C1Ribbon.RibbonButton c1_rbbAdministration;
        //private C1.Win.C1Ribbon.C1Ribbon c1Ribbon1;
        private C1.Win.C1Ribbon.RibbonApplicationMenu ribbonApplicationMenu2;
        private C1.Win.C1Ribbon.RibbonConfigToolBar ribbonConfigToolBar2;
        private C1.Win.C1Ribbon.RibbonQat ribbonQat2;
        private C1.Win.C1Ribbon.RibbonTab ribbonTab1;
        private C1.Win.C1Ribbon.RibbonGroup ribbonGroup7;
        private C1.Win.C1FlexGrid.C1FlexGrid c1_dgwResources;
        private C1.Win.C1FlexGrid.C1FlexGrid c1_AttributeGrid;
        //private C1.Win.C1Command.C1DockingTab c1_DockingTab;
        //private C1.Win.C1Command.C1DockingTabPage c1_doc_page_Export;
        //private C1.Win.C1Command.C1DockingTabPage c1_doc_page_Import;
        //private C1.Win.C1Command.C1DockingTabPage c1_doc_page_publish;
        //private C1.Win.C1Command.C1DockingTabPage c1_doc_page_administration;
        private C1.Win.C1Command.C1DockingTab c1_DockingTab;
        private C1.Win.C1Command.C1DockingTabPage c1_doc_page_Export;
        private C1.Win.C1Command.C1DockingTabPage c1_doc_page_Import;
        private C1.Win.C1Command.C1DockingTabPage c1_doc_page_publish;
        private C1.Win.C1Command.C1DockingTabPage c1_doc_page_administration;
        private C1.Win.C1Ribbon.RibbonButton rbbImportEntity;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private C1.Win.C1List.C1Combo c1_cbSolution;
        private System.Windows.Forms.Button btn_BuscarEntity;
        private C1.Win.C1Ribbon.RibbonBottomToolBar ribbonBottomToolBar1;
        private C1.Win.C1Ribbon.RibbonTopToolBar ribbonTopToolBar1;
        private C1.Win.C1Ribbon.RibbonButton ribbonButton1;
        private C1.Win.C1Command.C1DockingTabPage c1DockingTabPage1;
        private C1.Win.C1FlexGrid.C1FlexGrid cgServerPro;
        private C1.Win.C1FlexGrid.C1FlexGrid cgServerPre;
        private C1.Win.C1Ribbon.RibbonButton rbbDeploy;
        private C1.Win.C1Ribbon.C1StatusBar c1StatusBar1;
        private C1.Win.C1Command.C1CommandHolder c1CommandHolder1;
        private C1.Win.C1Ribbon.RibbonTextBox ribbonUserConnection;
        //private C1.Win.C1Command.C1DockingTab c1DockingTab1;
        //private C1.Win.C1Command.C1DockingTabPage c1DockingTabPage1;
        //private C1.Win.C1Command.C1DockingTabPage c1DockingTabPage2;
        //private C1.Win.C1Command.C1DockingTabPage c1DockingTabPage3;
        //private C1.Win.C1Command.C1DockingTabPage c1DockingTabPage4;

    }
}

