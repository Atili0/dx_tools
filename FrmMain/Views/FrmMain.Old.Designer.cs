using System.Drawing;

namespace DeXrm.Win.Tools
{
    partial class FrmMainOld
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
            this.rbMenuAbout = new System.Windows.Forms.RibbonOrbMenuItem();
            this.rbPanel = new System.Windows.Forms.RibbonPanel();
            this.rbbConnectToServer = new System.Windows.Forms.RibbonButton();
            this.rbbDisconnectToServer = new System.Windows.Forms.RibbonButton();
            this.rbpTools = new System.Windows.Forms.RibbonPanel();
            this.rbbConfigTool = new System.Windows.Forms.RibbonButton();
            this.rbpExport = new System.Windows.Forms.RibbonPanel();
            this.rbbShowPlugin = new System.Windows.Forms.RibbonButton();
            this.rbPanelIntellisense = new System.Windows.Forms.RibbonPanel();
            this.rbbSaveScript = new System.Windows.Forms.RibbonButton();
            this.rbbPreviewScript = new System.Windows.Forms.RibbonButton();
            this.rbpConection = new System.Windows.Forms.RibbonPanel();
            this.rbbImportConection = new System.Windows.Forms.RibbonButton();
            this.rbbBuscarDatosVista = new System.Windows.Forms.RibbonButton();
            this.rbbTestView = new System.Windows.Forms.RibbonButton();
            this.rbbImportView = new System.Windows.Forms.RibbonButton();
            this.rbpConfigTrace = new System.Windows.Forms.RibbonPanel();
            this.rbbSetup = new System.Windows.Forms.RibbonButton();
            this.rbbOpen = new System.Windows.Forms.RibbonButton();
            this.rbbChart = new System.Windows.Forms.RibbonButton();
            this.rbpAction = new System.Windows.Forms.RibbonPanel();
            this.rbbNewQuery = new System.Windows.Forms.RibbonButton();
            this.rbbOpenQuery = new System.Windows.Forms.RibbonButton();
            this.rbbSave = new System.Windows.Forms.RibbonButton();
            this.rbpQuery = new System.Windows.Forms.RibbonPanel();
            this.rbbExecute = new System.Windows.Forms.RibbonButton();
            this.rbbPublishSelect = new System.Windows.Forms.RibbonButton();
            this.tbTools = new System.Windows.Forms.TabControl();
            this.tbExport = new System.Windows.Forms.TabPage();
            this.dgwPlugin = new System.Windows.Forms.DataGridView();
            this.cbPlugin = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tbIntellisense = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.clbEntities = new System.Windows.Forms.CheckedListBox();
            this.btnFolder = new System.Windows.Forms.Button();
            this.txtPathFolderBox = new System.Windows.Forms.TextBox();
            this.txtPreviewScript = new System.Windows.Forms.TextBox();
            this.tbImport = new System.Windows.Forms.TabPage();
            this.split = new System.Windows.Forms.SplitContainer();
            this.dgwResultTestFetch = new System.Windows.Forms.DataGridView();
            this.txtInformation = new System.Windows.Forms.TextBox();
            this.cbCrmView = new System.Windows.Forms.ComboBox();
            this.lblServerNameImport = new System.Windows.Forms.Label();
            this.lblServerImport = new System.Windows.Forms.Label();
            this.dgwImportedData = new System.Windows.Forms.DataGridView();
            this.tbTrace = new System.Windows.Forms.TabPage();
            this.txtDetail = new System.Windows.Forms.TextBox();
            this.dgvRegistro = new System.Windows.Forms.DataGridView();
            this.tbPublish = new System.Windows.Forms.TabPage();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgwResources = new System.Windows.Forms.DataGridView();
            this.cbCheckResource = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPath = new System.Windows.Forms.DataGridViewButtonColumn();
            this.webResourceDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbSolution = new System.Windows.Forms.ComboBox();
            this.lblSolution = new System.Windows.Forms.Label();
            this.tbQuery = new System.Windows.Forms.TabPage();
            this.tbcQuery = new System.Windows.Forms.TabControl();
            this.tbDiseñador = new System.Windows.Forms.TabPage();
            this.trwQuery = new System.Windows.Forms.TreeView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.ofdPath = new System.Windows.Forms.OpenFileDialog();
            this.ofdOldPackage = new System.Windows.Forms.OpenFileDialog();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.toolStaTool = new System.Windows.Forms.ToolStripStatusLabel();
            this.staLabelTool = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelStatusTool = new System.Windows.Forms.ToolStripStatusLabel();
            this.ribbonTextBox1 = new System.Windows.Forms.RibbonTextBox();
            this.auUpdate = new wyDay.Controls.AutomaticUpdater();
            this.cmsQuery = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.entitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staTool = new System.Windows.Forms.StatusStrip();
            this.c1_DockingTab = new C1.Win.C1Command.C1DockingTab();
            this.c1_doc_page_Export = new C1.Win.C1Command.C1DockingTabPage();
            this.c1_dgwPlugin = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.c1_doc_page_Import = new C1.Win.C1Command.C1DockingTabPage();
            this.c1_doc_page_publish = new C1.Win.C1Command.C1DockingTabPage();
            this.c1_btnBuscar = new System.Windows.Forms.Button();
            this.c1_dgwResources = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.lbl_Solution = new System.Windows.Forms.Label();
            this.c1_cbSolution = new System.Windows.Forms.ComboBox();
            this.c1_doc_page_administration = new C1.Win.C1Command.C1DockingTabPage();
            this.c1Ribbon = new C1.Win.C1Ribbon.C1Ribbon();
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
            this.c1_rbtAdministration = new C1.Win.C1Ribbon.RibbonTab();
            this.ribbonGroup6 = new C1.Win.C1Ribbon.RibbonGroup();
            this.tbTools.SuspendLayout();
            this.tbExport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPlugin)).BeginInit();
            this.tbIntellisense.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tbImport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.split)).BeginInit();
            this.split.Panel1.SuspendLayout();
            this.split.Panel2.SuspendLayout();
            this.split.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwResultTestFetch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwImportedData)).BeginInit();
            this.tbTrace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistro)).BeginInit();
            this.tbPublish.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwResources)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webResourceDataBindingSource)).BeginInit();
            this.tbQuery.SuspendLayout();
            this.tbcQuery.SuspendLayout();
            this.tbDiseñador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.auUpdate)).BeginInit();
            this.cmsQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1_DockingTab)).BeginInit();
            this.c1_DockingTab.SuspendLayout();
            this.c1_doc_page_Export.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1_dgwPlugin)).BeginInit();
            this.c1_doc_page_publish.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1_dgwResources)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // rbMenuAbout
            // 
            this.rbMenuAbout.AltKey = null;
            this.rbMenuAbout.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.rbMenuAbout.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbMenuAbout.Image = global::DeXrm.Win.Tools.rsTool.HelpOnThisPage_32;
            this.rbMenuAbout.SmallImage = global::DeXrm.Win.Tools.rsTool.HelpOnThisPage_32;
            this.rbMenuAbout.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbMenuAbout.Tag = null;
            this.rbMenuAbout.Text = "asdasdasdasdasdadasdcadcadacd";
            this.rbMenuAbout.ToolTip = null;
            this.rbMenuAbout.ToolTipImage = null;
            this.rbMenuAbout.ToolTipTitle = null;
            // 
            // rbPanel
            // 
            this.rbPanel.Items.Add(this.rbbConnectToServer);
            this.rbPanel.Items.Add(this.rbbDisconnectToServer);
            this.rbPanel.Tag = null;
            this.rbPanel.Text = "Connection";
            // 
            // rbbConnectToServer
            // 
            this.rbbConnectToServer.AltKey = null;
            this.rbbConnectToServer.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbbConnectToServer.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbbConnectToServer.Image = global::DeXrm.Win.Tools.rsTool.ClientToServer32;
            this.rbbConnectToServer.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbbConnectToServer.SmallImage")));
            this.rbbConnectToServer.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbbConnectToServer.Tag = null;
            this.rbbConnectToServer.Text = "Connect";
            this.rbbConnectToServer.ToolTip = null;
            this.rbbConnectToServer.ToolTipImage = null;
            this.rbbConnectToServer.ToolTipTitle = null;
            // 
            // rbbDisconnectToServer
            // 
            this.rbbDisconnectToServer.AltKey = null;
            this.rbbDisconnectToServer.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbbDisconnectToServer.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbbDisconnectToServer.Image = global::DeXrm.Win.Tools.rsTool.ClientToServer321;
            this.rbbDisconnectToServer.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbbDisconnectToServer.SmallImage")));
            this.rbbDisconnectToServer.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbbDisconnectToServer.Tag = null;
            this.rbbDisconnectToServer.Text = "Disconnect";
            this.rbbDisconnectToServer.ToolTip = null;
            this.rbbDisconnectToServer.ToolTipImage = null;
            this.rbbDisconnectToServer.ToolTipTitle = null;
            // 
            // rbpTools
            // 
            this.rbpTools.Items.Add(this.rbbConfigTool);
            this.rbpTools.Tag = null;
            this.rbpTools.Text = "Tools";
            // 
            // rbbConfigTool
            // 
            this.rbbConfigTool.AltKey = null;
            this.rbbConfigTool.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbbConfigTool.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbbConfigTool.Enabled = false;
            this.rbbConfigTool.Image = global::DeXrm.Win.Tools.rsTool.Contents_32;
            this.rbbConfigTool.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbbConfigTool.SmallImage")));
            this.rbbConfigTool.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbbConfigTool.Tag = null;
            this.rbbConfigTool.Text = "Tools";
            this.rbbConfigTool.ToolTip = null;
            this.rbbConfigTool.ToolTipImage = null;
            this.rbbConfigTool.ToolTipTitle = null;
            // 
            // rbpExport
            // 
            this.rbpExport.Items.Add(this.rbbShowPlugin);
            this.rbpExport.Tag = null;
            this.rbpExport.Text = "Plugin";
            // 
            // rbbShowPlugin
            // 
            this.rbbShowPlugin.AltKey = null;
            this.rbbShowPlugin.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbbShowPlugin.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbbShowPlugin.Image = global::DeXrm.Win.Tools.rsTool.plugin_folder_icon;
            this.rbbShowPlugin.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbbShowPlugin.SmallImage")));
            this.rbbShowPlugin.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbbShowPlugin.Tag = null;
            this.rbbShowPlugin.Text = "Export Plugin";
            this.rbbShowPlugin.ToolTip = null;
            this.rbbShowPlugin.ToolTipImage = null;
            this.rbbShowPlugin.ToolTipTitle = null;
            // 
            // rbPanelIntellisense
            // 
            this.rbPanelIntellisense.Items.Add(this.rbbSaveScript);
            this.rbPanelIntellisense.Items.Add(this.rbbPreviewScript);
            this.rbPanelIntellisense.Tag = null;
            this.rbPanelIntellisense.Text = "Configuración";
            // 
            // rbbSaveScript
            // 
            this.rbbSaveScript.AltKey = null;
            this.rbbSaveScript.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbbSaveScript.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbbSaveScript.Image = global::DeXrm.Win.Tools.rsTool.javascript;
            this.rbbSaveScript.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbbSaveScript.SmallImage")));
            this.rbbSaveScript.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbbSaveScript.Tag = null;
            this.rbbSaveScript.Text = "Save Script";
            this.rbbSaveScript.ToolTip = null;
            this.rbbSaveScript.ToolTipImage = null;
            this.rbbSaveScript.ToolTipTitle = null;
            // 
            // rbbPreviewScript
            // 
            this.rbbPreviewScript.AltKey = null;
            this.rbbPreviewScript.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbbPreviewScript.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbbPreviewScript.Image = global::DeXrm.Win.Tools.rsTool.analysis;
            this.rbbPreviewScript.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbbPreviewScript.SmallImage")));
            this.rbbPreviewScript.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbbPreviewScript.Tag = null;
            this.rbbPreviewScript.Text = "Preview";
            this.rbbPreviewScript.ToolTip = null;
            this.rbbPreviewScript.ToolTipImage = null;
            this.rbbPreviewScript.ToolTipTitle = null;
            // 
            // rbpConection
            // 
            this.rbpConection.Items.Add(this.rbbImportConection);
            this.rbpConection.Items.Add(this.rbbBuscarDatosVista);
            this.rbpConection.Items.Add(this.rbbTestView);
            this.rbpConection.Items.Add(this.rbbImportView);
            this.rbpConection.Tag = null;
            this.rbpConection.Text = "Conection";
            // 
            // rbbImportConection
            // 
            this.rbbImportConection.AltKey = null;
            this.rbbImportConection.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbbImportConection.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbbImportConection.Image = global::DeXrm.Win.Tools.rsTool.Network_connection;
            this.rbbImportConection.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbbImportConection.SmallImage")));
            this.rbbImportConection.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbbImportConection.Tag = null;
            this.rbbImportConection.Text = "Destination CRM";
            this.rbbImportConection.ToolTip = null;
            this.rbbImportConection.ToolTipImage = null;
            this.rbbImportConection.ToolTipTitle = null;
            // 
            // rbbBuscarDatosVista
            // 
            this.rbbBuscarDatosVista.AltKey = null;
            this.rbbBuscarDatosVista.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbbBuscarDatosVista.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbbBuscarDatosVista.Image = global::DeXrm.Win.Tools.rsTool.Search_icon;
            this.rbbBuscarDatosVista.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbbBuscarDatosVista.SmallImage")));
            this.rbbBuscarDatosVista.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbbBuscarDatosVista.Tag = null;
            this.rbbBuscarDatosVista.Text = "Buscar detalle";
            this.rbbBuscarDatosVista.ToolTip = null;
            this.rbbBuscarDatosVista.ToolTipImage = null;
            this.rbbBuscarDatosVista.ToolTipTitle = null;
            // 
            // rbbTestView
            // 
            this.rbbTestView.AltKey = null;
            this.rbbTestView.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbbTestView.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbbTestView.Image = global::DeXrm.Win.Tools.rsTool.Problem;
            this.rbbTestView.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbbTestView.SmallImage")));
            this.rbbTestView.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbbTestView.Tag = null;
            this.rbbTestView.Text = "Ver data a importar";
            this.rbbTestView.ToolTip = null;
            this.rbbTestView.ToolTipImage = null;
            this.rbbTestView.ToolTipTitle = null;
            // 
            // rbbImportView
            // 
            this.rbbImportView.AltKey = null;
            this.rbbImportView.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbbImportView.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbbImportView.Image = global::DeXrm.Win.Tools.rsTool.running_process;
            this.rbbImportView.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbbImportView.SmallImage")));
            this.rbbImportView.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbbImportView.Tag = null;
            this.rbbImportView.Text = "Importar";
            this.rbbImportView.ToolTip = null;
            this.rbbImportView.ToolTipImage = null;
            this.rbbImportView.ToolTipTitle = null;
            // 
            // rbpConfigTrace
            // 
            this.rbpConfigTrace.Items.Add(this.rbbSetup);
            this.rbpConfigTrace.Items.Add(this.rbbOpen);
            this.rbpConfigTrace.Items.Add(this.rbbChart);
            this.rbpConfigTrace.Tag = null;
            this.rbpConfigTrace.Text = "Config Trace";
            // 
            // rbbSetup
            // 
            this.rbbSetup.AltKey = null;
            this.rbbSetup.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbbSetup.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbbSetup.Image = global::DeXrm.Win.Tools.rsTool.Settings_32x32_32;
            this.rbbSetup.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbbSetup.SmallImage")));
            this.rbbSetup.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbbSetup.Tag = null;
            this.rbbSetup.Text = "Setup";
            this.rbbSetup.ToolTip = null;
            this.rbbSetup.ToolTipImage = null;
            this.rbbSetup.ToolTipTitle = null;
            // 
            // rbbOpen
            // 
            this.rbbOpen.AltKey = null;
            this.rbbOpen.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbbOpen.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbbOpen.Image = global::DeXrm.Win.Tools.rsTool.folder_black_parent;
            this.rbbOpen.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbbOpen.SmallImage")));
            this.rbbOpen.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbbOpen.Tag = null;
            this.rbbOpen.Text = "Open File";
            this.rbbOpen.ToolTip = null;
            this.rbbOpen.ToolTipImage = null;
            this.rbbOpen.ToolTipTitle = null;
            // 
            // rbbChart
            // 
            this.rbbChart.AltKey = null;
            this.rbbChart.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbbChart.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbbChart.Image = global::DeXrm.Win.Tools.rsTool.ChartsBarGraph32;
            this.rbbChart.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbbChart.SmallImage")));
            this.rbbChart.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbbChart.Tag = null;
            this.rbbChart.Text = "Chart";
            this.rbbChart.ToolTip = null;
            this.rbbChart.ToolTipImage = null;
            this.rbbChart.ToolTipTitle = null;
            // 
            // rbpAction
            // 
            this.rbpAction.Items.Add(this.rbbNewQuery);
            this.rbpAction.Items.Add(this.rbbOpenQuery);
            this.rbpAction.Items.Add(this.rbbSave);
            this.rbpAction.Tag = null;
            this.rbpAction.Text = "Action";
            // 
            // rbbNewQuery
            // 
            this.rbbNewQuery.AltKey = null;
            this.rbbNewQuery.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbbNewQuery.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbbNewQuery.Image = ((System.Drawing.Image)(resources.GetObject("rbbNewQuery.Image")));
            this.rbbNewQuery.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbbNewQuery.SmallImage")));
            this.rbbNewQuery.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbbNewQuery.Tag = null;
            this.rbbNewQuery.Text = null;
            this.rbbNewQuery.ToolTip = null;
            this.rbbNewQuery.ToolTipImage = null;
            this.rbbNewQuery.ToolTipTitle = null;
            // 
            // rbbOpenQuery
            // 
            this.rbbOpenQuery.AltKey = null;
            this.rbbOpenQuery.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbbOpenQuery.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbbOpenQuery.Image = ((System.Drawing.Image)(resources.GetObject("rbbOpenQuery.Image")));
            this.rbbOpenQuery.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbbOpenQuery.SmallImage")));
            this.rbbOpenQuery.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbbOpenQuery.Tag = null;
            this.rbbOpenQuery.Text = null;
            this.rbbOpenQuery.ToolTip = null;
            this.rbbOpenQuery.ToolTipImage = null;
            this.rbbOpenQuery.ToolTipTitle = null;
            // 
            // rbbSave
            // 
            this.rbbSave.AltKey = null;
            this.rbbSave.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbbSave.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbbSave.Image = ((System.Drawing.Image)(resources.GetObject("rbbSave.Image")));
            this.rbbSave.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbbSave.SmallImage")));
            this.rbbSave.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbbSave.Tag = null;
            this.rbbSave.Text = null;
            this.rbbSave.ToolTip = null;
            this.rbbSave.ToolTipImage = null;
            this.rbbSave.ToolTipTitle = null;
            // 
            // rbpQuery
            // 
            this.rbpQuery.Items.Add(this.rbbExecute);
            this.rbpQuery.Tag = null;
            this.rbpQuery.Text = "Query";
            // 
            // rbbExecute
            // 
            this.rbbExecute.AltKey = null;
            this.rbbExecute.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbbExecute.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbbExecute.Image = ((System.Drawing.Image)(resources.GetObject("rbbExecute.Image")));
            this.rbbExecute.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbbExecute.SmallImage")));
            this.rbbExecute.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbbExecute.Tag = null;
            this.rbbExecute.Text = null;
            this.rbbExecute.ToolTip = null;
            this.rbbExecute.ToolTipImage = null;
            this.rbbExecute.ToolTipTitle = null;
            // 
            // rbbPublishSelect
            // 
            this.rbbPublishSelect.AltKey = null;
            this.rbbPublishSelect.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.rbbPublishSelect.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbbPublishSelect.Image = global::DeXrm.Win.Tools.rsTool.PublishAllCustomizations_32;
            this.rbbPublishSelect.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbbPublishSelect.SmallImage")));
            this.rbbPublishSelect.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbbPublishSelect.Tag = null;
            this.rbbPublishSelect.Text = null;
            this.rbbPublishSelect.ToolTip = null;
            this.rbbPublishSelect.ToolTipImage = null;
            this.rbbPublishSelect.ToolTipTitle = null;
            // 
            // tbTools
            // 
            this.tbTools.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTools.Controls.Add(this.tbExport);
            this.tbTools.Controls.Add(this.tbIntellisense);
            this.tbTools.Controls.Add(this.tbImport);
            this.tbTools.Controls.Add(this.tbTrace);
            this.tbTools.Controls.Add(this.tbPublish);
            this.tbTools.Controls.Add(this.tbQuery);
            this.tbTools.Location = new System.Drawing.Point(539, 159);
            this.tbTools.Name = "tbTools";
            this.tbTools.SelectedIndex = 0;
            this.tbTools.Size = new System.Drawing.Size(643, 474);
            this.tbTools.TabIndex = 1;
            // 
            // tbExport
            // 
            this.tbExport.Controls.Add(this.dgwPlugin);
            this.tbExport.Location = new System.Drawing.Point(4, 22);
            this.tbExport.Name = "tbExport";
            this.tbExport.Padding = new System.Windows.Forms.Padding(3);
            this.tbExport.Size = new System.Drawing.Size(635, 448);
            this.tbExport.TabIndex = 0;
            this.tbExport.Text = "Export Plugin";
            this.tbExport.UseVisualStyleBackColor = true;
            // 
            // dgwPlugin
            // 
            this.dgwPlugin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPlugin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cbPlugin});
            this.dgwPlugin.Location = new System.Drawing.Point(6, 6);
            this.dgwPlugin.Name = "dgwPlugin";
            this.dgwPlugin.Size = new System.Drawing.Size(879, 160);
            this.dgwPlugin.TabIndex = 0;
            // 
            // cbPlugin
            // 
            this.cbPlugin.HeaderText = "";
            this.cbPlugin.Name = "cbPlugin";
            this.cbPlugin.Width = 20;
            // 
            // tbIntellisense
            // 
            this.tbIntellisense.Controls.Add(this.splitContainer1);
            this.tbIntellisense.Location = new System.Drawing.Point(4, 22);
            this.tbIntellisense.Name = "tbIntellisense";
            this.tbIntellisense.Size = new System.Drawing.Size(635, 448);
            this.tbIntellisense.TabIndex = 0;
            this.tbIntellisense.Text = "Intellisense";
            this.tbIntellisense.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.clbEntities);
            this.splitContainer1.Panel1.Controls.Add(this.btnFolder);
            this.splitContainer1.Panel1.Controls.Add(this.txtPathFolderBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtPreviewScript);
            this.splitContainer1.Size = new System.Drawing.Size(635, 448);
            this.splitContainer1.SplitterDistance = 210;
            this.splitContainer1.TabIndex = 0;
            // 
            // clbEntities
            // 
            this.clbEntities.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clbEntities.FormattingEnabled = true;
            this.clbEntities.Location = new System.Drawing.Point(8, 32);
            this.clbEntities.Name = "clbEntities";
            this.clbEntities.Size = new System.Drawing.Size(199, 379);
            this.clbEntities.Sorted = true;
            this.clbEntities.TabIndex = 2;
            // 
            // btnFolder
            // 
            this.btnFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFolder.Location = new System.Drawing.Point(182, 6);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(25, 20);
            this.btnFolder.TabIndex = 1;
            this.btnFolder.Text = "...";
            this.btnFolder.UseVisualStyleBackColor = true;
            // 
            // txtPathFolderBox
            // 
            this.txtPathFolderBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPathFolderBox.Location = new System.Drawing.Point(8, 6);
            this.txtPathFolderBox.Name = "txtPathFolderBox";
            this.txtPathFolderBox.Size = new System.Drawing.Size(168, 20);
            this.txtPathFolderBox.TabIndex = 0;
            // 
            // txtPreviewScript
            // 
            this.txtPreviewScript.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPreviewScript.Location = new System.Drawing.Point(3, 7);
            this.txtPreviewScript.Multiline = true;
            this.txtPreviewScript.Name = "txtPreviewScript";
            this.txtPreviewScript.Size = new System.Drawing.Size(410, 421);
            this.txtPreviewScript.TabIndex = 0;
            // 
            // tbImport
            // 
            this.tbImport.Controls.Add(this.split);
            this.tbImport.Location = new System.Drawing.Point(4, 22);
            this.tbImport.Name = "tbImport";
            this.tbImport.Padding = new System.Windows.Forms.Padding(3);
            this.tbImport.Size = new System.Drawing.Size(635, 448);
            this.tbImport.TabIndex = 2;
            this.tbImport.Text = "Import";
            this.tbImport.UseVisualStyleBackColor = true;
            // 
            // split
            // 
            this.split.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.split.Location = new System.Drawing.Point(0, 0);
            this.split.Name = "split";
            // 
            // split.Panel1
            // 
            this.split.Panel1.Controls.Add(this.dgwResultTestFetch);
            this.split.Panel1.Controls.Add(this.txtInformation);
            this.split.Panel1.Controls.Add(this.cbCrmView);
            // 
            // split.Panel2
            // 
            this.split.Panel2.Controls.Add(this.lblServerNameImport);
            this.split.Panel2.Controls.Add(this.lblServerImport);
            this.split.Panel2.Controls.Add(this.dgwImportedData);
            this.split.Size = new System.Drawing.Size(844, 296);
            this.split.SplitterDistance = 407;
            this.split.TabIndex = 0;
            // 
            // dgwResultTestFetch
            // 
            this.dgwResultTestFetch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwResultTestFetch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwResultTestFetch.Location = new System.Drawing.Point(6, 176);
            this.dgwResultTestFetch.Name = "dgwResultTestFetch";
            this.dgwResultTestFetch.Size = new System.Drawing.Size(398, 114);
            this.dgwResultTestFetch.TabIndex = 2;
            // 
            // txtInformation
            // 
            this.txtInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInformation.Location = new System.Drawing.Point(5, 30);
            this.txtInformation.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.txtInformation.Multiline = true;
            this.txtInformation.Name = "txtInformation";
            this.txtInformation.Size = new System.Drawing.Size(399, 138);
            this.txtInformation.TabIndex = 1;
            // 
            // cbCrmView
            // 
            this.cbCrmView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCrmView.FormattingEnabled = true;
            this.cbCrmView.Location = new System.Drawing.Point(5, 3);
            this.cbCrmView.Name = "cbCrmView";
            this.cbCrmView.Size = new System.Drawing.Size(399, 21);
            this.cbCrmView.TabIndex = 0;
            // 
            // lblServerNameImport
            // 
            this.lblServerNameImport.AutoSize = true;
            this.lblServerNameImport.Location = new System.Drawing.Point(100, 11);
            this.lblServerNameImport.Name = "lblServerNameImport";
            this.lblServerNameImport.Size = new System.Drawing.Size(0, 13);
            this.lblServerNameImport.TabIndex = 3;
            // 
            // lblServerImport
            // 
            this.lblServerImport.AutoSize = true;
            this.lblServerImport.Location = new System.Drawing.Point(4, 11);
            this.lblServerImport.Name = "lblServerImport";
            this.lblServerImport.Size = new System.Drawing.Size(71, 13);
            this.lblServerImport.TabIndex = 2;
            this.lblServerImport.Text = "Conectado a:";
            // 
            // dgwImportedData
            // 
            this.dgwImportedData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwImportedData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwImportedData.Location = new System.Drawing.Point(3, 30);
            this.dgwImportedData.Name = "dgwImportedData";
            this.dgwImportedData.Size = new System.Drawing.Size(425, 263);
            this.dgwImportedData.TabIndex = 0;
            // 
            // tbTrace
            // 
            this.tbTrace.Controls.Add(this.txtDetail);
            this.tbTrace.Controls.Add(this.dgvRegistro);
            this.tbTrace.Location = new System.Drawing.Point(4, 22);
            this.tbTrace.Name = "tbTrace";
            this.tbTrace.Padding = new System.Windows.Forms.Padding(3);
            this.tbTrace.Size = new System.Drawing.Size(635, 448);
            this.tbTrace.TabIndex = 1;
            this.tbTrace.Text = "Trace";
            this.tbTrace.UseVisualStyleBackColor = true;
            // 
            // txtDetail
            // 
            this.txtDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDetail.Location = new System.Drawing.Point(8, 203);
            this.txtDetail.Multiline = true;
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.ReadOnly = true;
            this.txtDetail.Size = new System.Drawing.Size(626, 195);
            this.txtDetail.TabIndex = 3;
            // 
            // dgvRegistro
            // 
            this.dgvRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistro.Location = new System.Drawing.Point(8, 6);
            this.dgvRegistro.MultiSelect = false;
            this.dgvRegistro.Name = "dgvRegistro";
            this.dgvRegistro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvRegistro.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvRegistro.RowHeadersVisible = false;
            this.dgvRegistro.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvRegistro.Size = new System.Drawing.Size(626, 191);
            this.dgvRegistro.TabIndex = 2;
            this.dgvRegistro.VirtualMode = true;
            // 
            // tbPublish
            // 
            this.tbPublish.Controls.Add(this.btnBuscar);
            this.tbPublish.Controls.Add(this.dgwResources);
            this.tbPublish.Controls.Add(this.cbSolution);
            this.tbPublish.Controls.Add(this.lblSolution);
            this.tbPublish.Location = new System.Drawing.Point(4, 22);
            this.tbPublish.Name = "tbPublish";
            this.tbPublish.Padding = new System.Windows.Forms.Padding(3);
            this.tbPublish.Size = new System.Drawing.Size(635, 448);
            this.tbPublish.TabIndex = 0;
            this.tbPublish.Text = "Quick Pusblish";
            this.tbPublish.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.AutoSize = true;
            this.btnBuscar.Location = new System.Drawing.Point(586, 7);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(50, 23);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dgwResources
            // 
            this.dgwResources.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwResources.AutoGenerateColumns = false;
            this.dgwResources.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwResources.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cbCheckResource,
            this.Path,
            this.btnPath});
            this.dgwResources.DataSource = this.webResourceDataBindingSource;
            this.dgwResources.Location = new System.Drawing.Point(8, 36);
            this.dgwResources.Name = "dgwResources";
            this.dgwResources.Size = new System.Drawing.Size(884, 299);
            this.dgwResources.TabIndex = 5;
            // 
            // cbCheckResource
            // 
            this.cbCheckResource.HeaderText = "";
            this.cbCheckResource.Name = "cbCheckResource";
            this.cbCheckResource.Width = 20;
            // 
            // Path
            // 
            this.Path.DataPropertyName = "Path";
            this.Path.HeaderText = "Path";
            this.Path.Name = "Path";
            this.Path.Width = 160;
            // 
            // btnPath
            // 
            this.btnPath.HeaderText = "";
            this.btnPath.Name = "btnPath";
            this.btnPath.Text = "...";
            this.btnPath.Width = 30;
            // 
            // cbSolution
            // 
            this.cbSolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSolution.FormattingEnabled = true;
            this.cbSolution.Location = new System.Drawing.Point(99, 9);
            this.cbSolution.Name = "cbSolution";
            this.cbSolution.Size = new System.Drawing.Size(480, 21);
            this.cbSolution.TabIndex = 4;
            // 
            // lblSolution
            // 
            this.lblSolution.AutoSize = true;
            this.lblSolution.Location = new System.Drawing.Point(19, 12);
            this.lblSolution.Name = "lblSolution";
            this.lblSolution.Size = new System.Drawing.Size(51, 13);
            this.lblSolution.TabIndex = 3;
            this.lblSolution.Text = "Soluction";
            // 
            // tbQuery
            // 
            this.tbQuery.Controls.Add(this.tbcQuery);
            this.tbQuery.Location = new System.Drawing.Point(4, 22);
            this.tbQuery.Name = "tbQuery";
            this.tbQuery.Padding = new System.Windows.Forms.Padding(3);
            this.tbQuery.Size = new System.Drawing.Size(635, 448);
            this.tbQuery.TabIndex = 3;
            this.tbQuery.Text = "Query";
            this.tbQuery.UseVisualStyleBackColor = true;
            // 
            // tbcQuery
            // 
            this.tbcQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcQuery.Controls.Add(this.tbDiseñador);
            this.tbcQuery.Location = new System.Drawing.Point(8, 6);
            this.tbcQuery.Name = "tbcQuery";
            this.tbcQuery.SelectedIndex = 0;
            this.tbcQuery.Size = new System.Drawing.Size(626, 326);
            this.tbcQuery.TabIndex = 0;
            // 
            // tbDiseñador
            // 
            this.tbDiseñador.Controls.Add(this.trwQuery);
            this.tbDiseñador.Location = new System.Drawing.Point(4, 22);
            this.tbDiseñador.Name = "tbDiseñador";
            this.tbDiseñador.Padding = new System.Windows.Forms.Padding(3);
            this.tbDiseñador.Size = new System.Drawing.Size(618, 300);
            this.tbDiseñador.TabIndex = 0;
            this.tbDiseñador.Text = "Diseñador";
            this.tbDiseñador.UseVisualStyleBackColor = true;
            // 
            // trwQuery
            // 
            this.trwQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trwQuery.Location = new System.Drawing.Point(6, 6);
            this.trwQuery.Name = "trwQuery";
            this.trwQuery.Size = new System.Drawing.Size(606, 288);
            this.trwQuery.TabIndex = 0;
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
            // ribbonPanel1
            // 
            this.ribbonPanel1.Tag = null;
            this.ribbonPanel1.Text = null;
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
            // ribbonTextBox1
            // 
            this.ribbonTextBox1.AltKey = null;
            this.ribbonTextBox1.Image = null;
            this.ribbonTextBox1.Tag = null;
            this.ribbonTextBox1.Text = null;
            this.ribbonTextBox1.TextBoxText = null;
            this.ribbonTextBox1.ToolTip = null;
            this.ribbonTextBox1.ToolTipImage = null;
            this.ribbonTextBox1.ToolTipTitle = null;
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
            // staTool
            // 
            this.staTool.Location = new System.Drawing.Point(0, 636);
            this.staTool.Name = "staTool";
            this.staTool.Size = new System.Drawing.Size(1182, 22);
            this.staTool.TabIndex = 2;
            this.staTool.Text = "statusStrip1";
            // 
            // c1_DockingTab
            // 
            this.c1_DockingTab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c1_DockingTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.c1_DockingTab.CanAutoHide = true;
            this.c1_DockingTab.CanMoveTabs = true;
            this.c1_DockingTab.Controls.Add(this.c1_doc_page_Export);
            this.c1_DockingTab.Controls.Add(this.c1_doc_page_Import);
            this.c1_DockingTab.Controls.Add(this.c1_doc_page_publish);
            this.c1_DockingTab.Controls.Add(this.c1_doc_page_administration);
            this.c1_DockingTab.HotTrack = true;
            this.c1_DockingTab.Location = new System.Drawing.Point(0, 159);
            this.c1_DockingTab.Name = "c1_DockingTab";
            this.c1_DockingTab.ShowSingleTab = false;
            this.c1_DockingTab.ShowTabList = true;
            this.c1_DockingTab.Size = new System.Drawing.Size(512, 474);
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
            this.c1_doc_page_Export.Size = new System.Drawing.Size(510, 449);
            this.c1_doc_page_Export.TabIndex = 0;
            this.c1_doc_page_Export.Text = "Export Plugin";
            // 
            // c1_dgwPlugin
            // 
            this.c1_dgwPlugin.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None;
            this.c1_dgwPlugin.ColumnInfo = resources.GetString("c1_dgwPlugin.ColumnInfo");
            this.c1_dgwPlugin.Location = new System.Drawing.Point(3, 4);
            this.c1_dgwPlugin.Name = "c1_dgwPlugin";
            this.c1_dgwPlugin.Rows.DefaultSize = 19;
            this.c1_dgwPlugin.Size = new System.Drawing.Size(504, 442);
            this.c1_dgwPlugin.TabIndex = 0;
            // 
            // c1_doc_page_Import
            // 
            this.c1_doc_page_Import.Location = new System.Drawing.Point(1, 24);
            this.c1_doc_page_Import.Name = "c1_doc_page_Import";
            this.c1_doc_page_Import.Size = new System.Drawing.Size(510, 449);
            this.c1_doc_page_Import.TabIndex = 1;
            this.c1_doc_page_Import.Text = "Import";
            // 
            // c1_doc_page_publish
            // 
            this.c1_doc_page_publish.Controls.Add(this.c1_btnBuscar);
            this.c1_doc_page_publish.Controls.Add(this.c1_dgwResources);
            this.c1_doc_page_publish.Controls.Add(this.lbl_Solution);
            this.c1_doc_page_publish.Controls.Add(this.c1_cbSolution);
            this.c1_doc_page_publish.Location = new System.Drawing.Point(1, 24);
            this.c1_doc_page_publish.Name = "c1_doc_page_publish";
            this.c1_doc_page_publish.Size = new System.Drawing.Size(510, 449);
            this.c1_doc_page_publish.TabIndex = 2;
            this.c1_doc_page_publish.Text = "Pusblish";
            // 
            // c1_btnBuscar
            // 
            this.c1_btnBuscar.AutoSize = true;
            this.c1_btnBuscar.Location = new System.Drawing.Point(457, 10);
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
            this.c1_dgwResources.Size = new System.Drawing.Size(496, 409);
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
            // c1_cbSolution
            // 
            this.c1_cbSolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.c1_cbSolution.FormattingEnabled = true;
            this.c1_cbSolution.Location = new System.Drawing.Point(68, 10);
            this.c1_cbSolution.Name = "c1_cbSolution";
            this.c1_cbSolution.Size = new System.Drawing.Size(384, 21);
            this.c1_cbSolution.TabIndex = 4;
            // 
            // c1_doc_page_administration
            // 
            this.c1_doc_page_administration.Location = new System.Drawing.Point(1, 24);
            this.c1_doc_page_administration.Name = "c1_doc_page_administration";
            this.c1_doc_page_administration.Size = new System.Drawing.Size(510, 449);
            this.c1_doc_page_administration.TabIndex = 3;
            this.c1_doc_page_administration.Text = "Administration";
            // 
            // c1Ribbon
            // 
            this.c1Ribbon.ApplicationMenuHolder = this.ribbonApplicationMenu1;
            this.c1Ribbon.ConfigToolBarHolder = this.ribbonConfigToolBar1;
            this.c1Ribbon.ContextualTabGroups.Add(this.ribbonContextualTabGroup1);
            this.c1Ribbon.Location = new System.Drawing.Point(0, 0);
            this.c1Ribbon.Name = "c1Ribbon";
            this.c1Ribbon.QatHolder = this.ribbonQat1;
            this.c1Ribbon.Size = new System.Drawing.Size(1182, 153);
            this.c1Ribbon.Tabs.Add(this.c1_rbtConnection);
            this.c1Ribbon.Tabs.Add(this.c1_rbtExport);
            this.c1Ribbon.Tabs.Add(this.c1_rbtImports);
            this.c1Ribbon.Tabs.Add(this.c1_rbtQuickPublish);
            this.c1Ribbon.Tabs.Add(this.c1_rbtAdministration);
            this.c1Ribbon.VisualStyle = C1.Win.C1Ribbon.VisualStyle.Office2010Silver;
            // 
            // ribbonApplicationMenu1
            // 
            this.ribbonApplicationMenu1.LargeImage = global::DeXrm.Win.Tools.rsTool.Connected24;
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
            this.c1_rbbShowPlugin.LargeImage = global::DeXrm.Win.Tools.rsTool.plugin_folder_icon;
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
            this.c1_rbbImportConection.LargeImage = global::DeXrm.Win.Tools.rsTool.Network_connection;
            this.c1_rbbImportConection.Name = "c1_rbbImportConection";
            this.c1_rbbImportConection.SmallImage = ((System.Drawing.Image)(resources.GetObject("c1_rbbImportConection.SmallImage")));
            this.c1_rbbImportConection.Text = "Destination CRM";
            // 
            // c1_rbbBuscarDatosVista
            // 
            this.c1_rbbBuscarDatosVista.LargeImage = global::DeXrm.Win.Tools.rsTool.Search_icon;
            this.c1_rbbBuscarDatosVista.Name = "c1_rbbBuscarDatosVista";
            this.c1_rbbBuscarDatosVista.SmallImage = ((System.Drawing.Image)(resources.GetObject("c1_rbbBuscarDatosVista.SmallImage")));
            this.c1_rbbBuscarDatosVista.Text = "Buscar detalle";
            // 
            // c1_rbbTestView
            // 
            this.c1_rbbTestView.LargeImage = global::DeXrm.Win.Tools.rsTool.Problem;
            this.c1_rbbTestView.Name = "c1_rbbTestView";
            this.c1_rbbTestView.SmallImage = ((System.Drawing.Image)(resources.GetObject("c1_rbbTestView.SmallImage")));
            this.c1_rbbTestView.Text = "Ver data a importar";
            // 
            // c1_rbbImportView
            // 
            this.c1_rbbImportView.LargeImage = global::DeXrm.Win.Tools.rsTool.running_process;
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
            this.c1_rbbPublishAll.SmallImage = ((System.Drawing.Image)(resources.GetObject("c1_rbbPublishAll.SmallImage")));
            this.c1_rbbPublishAll.Text = "Publish all";
            // 
            // c1_rbbPublishSelected
            // 
            this.c1_rbbPublishSelected.Name = "c1_rbbPublishSelected";
            this.c1_rbbPublishSelected.SmallImage = ((System.Drawing.Image)(resources.GetObject("c1_rbbPublishSelected.SmallImage")));
            this.c1_rbbPublishSelected.Text = "Publish selected";
            // 
            // c1_rbtAdministration
            // 
            this.c1_rbtAdministration.Groups.Add(this.ribbonGroup6);
            this.c1_rbtAdministration.Name = "c1_rbtAdministration";
            this.c1_rbtAdministration.Text = "Administration";
            // 
            // ribbonGroup6
            // 
            this.ribbonGroup6.Name = "ribbonGroup6";
            this.ribbonGroup6.Text = "Group";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 658);
            this.Controls.Add(this.c1Ribbon);
            this.Controls.Add(this.c1_DockingTab);
            this.Controls.Add(this.auUpdate);
            this.Controls.Add(this.staTool);
            this.Controls.Add(this.tbTools);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "DexPublish";
            this.tbTools.ResumeLayout(false);
            this.tbExport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwPlugin)).EndInit();
            this.tbIntellisense.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tbImport.ResumeLayout(false);
            this.split.Panel1.ResumeLayout(false);
            this.split.Panel1.PerformLayout();
            this.split.Panel2.ResumeLayout(false);
            this.split.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.split)).EndInit();
            this.split.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwResultTestFetch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwImportedData)).EndInit();
            this.tbTrace.ResumeLayout(false);
            this.tbTrace.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistro)).EndInit();
            this.tbPublish.ResumeLayout(false);
            this.tbPublish.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwResources)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webResourceDataBindingSource)).EndInit();
            this.tbQuery.ResumeLayout(false);
            this.tbcQuery.ResumeLayout(false);
            this.tbDiseñador.ResumeLayout(false);
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
            ((System.ComponentModel.ISupportInitialize)(this.c1_dgwResources)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RibbonTab rbtConnection;
        private System.Windows.Forms.RibbonPanel rbPanel;
        private System.Windows.Forms.RibbonButton rbbDisconnectToServer;
        private System.Windows.Forms.RibbonButton rbbPublishSelect;
        private System.Windows.Forms.RibbonOrbMenuItem rbMenuAbout;
        private System.Windows.Forms.RibbonButton rbbConnectToServer;
        private System.Windows.Forms.TabControl tbTools;
        private System.Windows.Forms.TabPage tbPublish;
        private System.Windows.Forms.ComboBox cbSolution;
        private System.Windows.Forms.Label lblSolution;
        private System.Windows.Forms.DataGridView dgwResources;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.BindingSource webResourceDataBindingSource;
        private System.Windows.Forms.OpenFileDialog ofdPath;
        private System.Windows.Forms.OpenFileDialog ofdOldPackage;
        private System.Windows.Forms.RibbonPanel rbpTools;
        private System.Windows.Forms.RibbonButton rbbConfigTool;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonTab rbtTrace;
        private System.Windows.Forms.TabPage tbTrace;
        private System.Windows.Forms.RibbonPanel rbpConfigTrace;
        private System.Windows.Forms.RibbonButton rbbSetup;
        private System.Windows.Forms.RibbonButton rbbOpen;
        private System.Windows.Forms.RibbonButton rbbChart;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cbCheckResource;
        private System.Windows.Forms.DataGridViewTextBoxColumn webResourceIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn displayNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Path;
        private System.Windows.Forms.DataGridViewButtonColumn btnPath;
        private System.Windows.Forms.TextBox txtDetail;
        private System.Windows.Forms.DataGridView dgvRegistro;
        private System.Windows.Forms.ToolStripStatusLabel toolStaTool;
        private System.Windows.Forms.ToolStripStatusLabel staLabelTool;
        private System.Windows.Forms.ToolStripStatusLabel labelStatusTool;
        private System.Windows.Forms.RibbonTab rbtImports;
        private System.Windows.Forms.RibbonPanel rbpConection;
        private System.Windows.Forms.RibbonButton rbbImportConection;
        private System.Windows.Forms.TabPage tbImport;
        private System.Windows.Forms.SplitContainer split;
        private System.Windows.Forms.TextBox txtInformation;
        private System.Windows.Forms.ComboBox cbCrmView;
        private System.Windows.Forms.DataGridView dgwImportedData;
        private System.Windows.Forms.RibbonButton rbbBuscarDatosVista;
        private System.Windows.Forms.RibbonButton rbbTestView;
        private System.Windows.Forms.RibbonButton rbbImportView;
        private System.Windows.Forms.DataGridView dgwResultTestFetch;
        private System.Windows.Forms.RibbonTextBox ribbonTextBox1;
        private System.Windows.Forms.Label lblServerImport;
        private System.Windows.Forms.Label lblServerNameImport;
        private System.Windows.Forms.RibbonTab rbtIntellisense;
        private System.Windows.Forms.RibbonPanel rbPanelIntellisense;
        private System.Windows.Forms.RibbonButton rbbSaveScript;
        private System.Windows.Forms.TabPage tbIntellisense;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckedListBox clbEntities;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.TextBox txtPathFolderBox;
        private System.Windows.Forms.RibbonButton rbbPreviewScript;
        private System.Windows.Forms.TextBox txtPreviewScript;
        private wyDay.Controls.AutomaticUpdater auUpdate;
        private System.Windows.Forms.RibbonTab rbExport;
        private System.Windows.Forms.RibbonPanel rbpExport;
        private System.Windows.Forms.RibbonButton rbbShowPlugin;
        private System.Windows.Forms.TabPage tbExport;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dgwPlugin;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cbPlugin;
        private System.Windows.Forms.RibbonTab rbtQuery;
        private System.Windows.Forms.TabPage tbQuery;
        private System.Windows.Forms.RibbonPanel rbpAction;
        private System.Windows.Forms.RibbonButton rbbNewQuery;
        private System.Windows.Forms.RibbonButton rbbOpenQuery;
        private System.Windows.Forms.RibbonButton rbbSave;
        private System.Windows.Forms.RibbonPanel rbpQuery;
        private System.Windows.Forms.RibbonButton rbbExecute;
        private System.Windows.Forms.TabControl tbcQuery;
        private System.Windows.Forms.TabPage tbDiseñador;
        private System.Windows.Forms.TreeView trwQuery;
        private System.Windows.Forms.ContextMenuStrip cmsQuery;
        private System.Windows.Forms.ToolStripMenuItem entitiesToolStripMenuItem;
        private System.Windows.Forms.StatusStrip staTool;
        private C1.Win.C1Command.C1DockingTab c1_DockingTab;
        private C1.Win.C1Command.C1DockingTabPage c1_doc_page_Export;
        private C1.Win.C1Command.C1DockingTabPage c1_doc_page_Import;
        private C1.Win.C1Command.C1DockingTabPage c1_doc_page_publish;
        private C1.Win.C1Command.C1DockingTabPage c1_doc_page_administration;
        private C1.Win.C1FlexGrid.C1FlexGrid c1_dgwPlugin;
        private C1.Win.C1Ribbon.C1Ribbon c1Ribbon;
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
        private System.Windows.Forms.ComboBox c1_cbSolution;
        private C1.Win.C1Ribbon.RibbonButton c1_rbbPublish;
        private C1.Win.C1FlexGrid.C1FlexGrid c1_dgwResources;
        private System.Windows.Forms.Button c1_btnBuscar;
    }
}

