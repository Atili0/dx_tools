
using CustomFilters;
using DeXrm.Win.Tools.FrmCrmLogon.Views;

namespace DeXrm.Win.Tools
{
    using C1.Win.C1FlexGrid;
    using Microsoft.Xrm.Tooling.Connector;
    using System.Data;
    using System.IO;
    using System.Drawing;
    using System.Collections.Generic;
    using Object;
    using Models;
    using System;
    using System.Windows.Forms;
    using Controllers;
    using Views;
    using Actions;
    

    public partial class FrmMainOld : Form, IView
    {
        private IControllerFrmMain _controlerFrmMain;
        private IActionMain _action;
        Loading frmLoading;

        public FrmMainOld()
        {
            InitializeComponent();
            //_action = action;
            this.Load += FrmMainOnLoad;
            this.dgwResources.CellContentClick += dgwResources_CellContentClick;
            this.dgwResources.CurrentCellDirtyStateChanged += dgwResources_CurrentCellDirtyStateChanged;
            this.c1_rbbConnectToServer.Click += rbbConnectToServer_Click;
            this.c1_rbbSaveConfiguration.Click += rbbSaveConfiguration_Click;
            this.c1_rbbDisconnectToServer.Click += rbbDisconnectToServer_Click;
            this.c1_rbbOpenConfiguration.Click += rbbOpenConfiguration_Click;
            this.c1_cbSolution.Click += cbSolution_Click;
            this.c1_btnBuscar.Click += btnBuscar_Click;
            this.c1_rbbPublishAll.Click += rbbPublish_Click;
            this.c1_rbbPublishSelected.Click += RbbPublishSelectedOnClick;
            this.rbbConfigTool.Click += rbbConfigTool_Click;
            this.rbbSetup.Click += rbbSetup_Click;
            this.rbbOpen.Click += rbbOpen_Click;
            this.dgvRegistro.CellFormatting += dgvRegistro_CellFormatting;
            this.dgvRegistro.Click += DgvRegistroClick;
            this.dgvRegistro.SelectionChanged += DgvRegistroClick;

            #region Tool
            this.c1_rbbExport.Click += c1_rbbExport_Click;
            this.c1_rbbPublish.Click += c1_rbbPublish_Click;
            
            #endregion

            #region Import
            this.rbbImportConection.Click += rbbImportConection_Click;
            this.cbCrmView.Click += cbCrmView_Click;
            this.rbbBuscarDatosVista.Click += rbbBuscarDatosVista_Click;
            this.rbbTestView.Click += RbbTestViewOnClick;
            this.rbbImportView.Click += rbbImportView_Click;

            rbbTestView.Enabled = false;
            rbbBuscarDatosVista.Enabled = false;
            rbbImportView.Enabled = false;

            #endregion

            #region Intellisense
            this.rbbPreviewScript.Click += rbbPreviewScript_Click;
            this.rbbSaveScript.Click += rbbSaveScript_Click;
            this.btnFolder.Click += btnFolder_Click;
            #endregion

            #region Automatic
            this.auUpdate.ClosingAborted += auUpdate_ClosingAborted;
            auUpdate.ForceCheckForUpdate(true);
            #endregion

            #region Publish
            this.c1_dgwResources.ValidateEdit += c1_dgwResources_ValidateEdit;
            #endregion

            #region Export Plugin
            this.c1_rbbShowPlugin.Click += rbbShowPlugin_Click;
            this.c1_dgwPlugin.AfterRowColChange += c1_dgwPlugin_AfterRowColChange;
            this.c1_dgwPlugin.ValidateEdit += c1_dgwPlugin_ValidateEdit;
            //this.c1_dgwPlugin.CurrentCellDirtyStateChanged += dgwPlugin_CurrentCellDirtyStateChanged;
            //this.c1_dgwPlugin.CellContentClick += dgwPlugin_CellContentClick;
            #endregion

            #region Query

            entitiesToolStripMenuItem.Click += entitiesToolStripMenuItem_Click;
            ExistNode();

            #endregion

            #region Button Tab

            c1_DockingTab.Visible = false;
            c1_rbtAdministration.Visible = false;
            c1_rbtExport.Visible = false;
            c1_rbtImports.Visible = false;
            c1_rbtQuickPublish.Visible = false;

            c1_doc_page_Export.Visible = false;
            c1_doc_page_Import.Visible = false;
            c1_doc_page_publish.Visible = false;

            #endregion



        }

        

        void c1_rbbPublish_Click(object sender, EventArgs e)
        {
            this.c1_rbtQuickPublish.Enabled = true;
            this.c1_rbtQuickPublish.Visible = true;
            this.c1Ribbon.TabIndex = 4;
        }

        void c1_rbbExport_Click(object sender, EventArgs e)
        {
            this.c1_rbtExport.Enabled = true;
            GetAllPlugin();
        }


        #region Query
        void entitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var frmEntities = new FrmQuery())
            {
                IModelFrmQuery mdl = new ModelFrmQuery();
                IControllerFrmQuery crt = new ControllerFrmQuery(frmEntities, mdl);
                //frmEntities.ServerConnection = this.ServerConnection;
                frmEntities.ShowDialog();
            }
        }

        private void ExistNode()
        {
            if (trwQuery.Nodes.Count <= 1)
            {
                trwQuery.ContextMenuStrip = cmsQuery;
            }
        }

        #endregion

        void auUpdate_ClosingAborted(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #region Intellisense
        public void SetEntities(IModelFrmMain modelFrmMain)
        {
            clbEntities.DataSource = modelFrmMain.Entities;
            clbEntities.DisplayMember = "EntitySchemaName";
        }

        public void SetPreview(IModelFrmMain _modelFrm)
        {
            txtPreviewScript.Text = _modelFrm.TotalScriptPreview;
        }


        void btnFolder_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                dialog.Description = "Open a folder which contains the js output";
                dialog.ShowNewFolderButton = true;
                dialog.RootFolder = Environment.SpecialFolder.MyComputer;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtPathFolderBox.Text = dialog.SelectedPath;
                }
            }
        }

        void rbbSaveScript_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.PreviewScript))
            {
                OpenLoading();
                _controlerFrmMain.SaveScript();
            }
            else
            {
                MessageBox.Show("Debe de seleccionar una carpeta.");
            }

        }

        void rbbPreviewScript_Click(object sender, EventArgs e)
        {
            OpenLoading();
            _controlerFrmMain.GetPreviewScript();
        }

        private void GetEntities()
        {
            this.Enabled = false;
            OpenLoading();
            _controlerFrmMain.GetEntities();
        }



        #endregion
      
        #region Import
        void rbbImportView_Click(object sender, EventArgs e)
        {
            this.Enabled = true;
            OpenLoading();
            _controlerFrmMain.ImportDataView();
        }

        public void SetImportGrid(IModelFrmMain modelFrmMain)
        {
            var ds = new DataSet();
            ds.ReadXml(new StringReader(modelFrmMain.NewEntityCollectionToImport));
            this.dgwImportedData.DataSource = ds.Tables[0];
        }

        private void RbbTestViewOnClick(object sender, EventArgs eventArgs)
        {
            if (String.IsNullOrEmpty(this.txtInformation.Text))
            {
                MessageBox.Show("No hay fetchXML");
                return;
            }
            this.Enabled = true;
            OpenLoading();
            _controlerFrmMain.ExecuteFetchImport();
        }

        public void SetGridResultFetch(IModelFrmMain model)
        {
            var ds = new DataSet();
            ds.ReadXml(new StringReader(model.EntityCollection));
            this.dgwResultTestFetch.DataSource = ds.Tables[0];
        }

        void rbbBuscarDatosVista_Click(object sender, EventArgs e)
        {
            this.Enabled = true;
            OpenLoading();
            this.GuidViewGuid = Guid.Parse(this.cbCrmView.SelectedValue.ToString());
            _controlerFrmMain.GetViewById();
        }

        private void cbCrmView_Click(object sender, EventArgs e)
        {
            if (cbCrmView.Items.Count > 0) return;
            this.Enabled = true;
            OpenLoading();
            _controlerFrmMain.GetView();
        }

        public void SetFieldForView(IModelFrmMain model)
        {
            this.FetchXmlView = model.ViewObject.FetchXml;
        }

        public void SetView(IModelFrmMain model)
        {
            cbCrmView.DataSource = model.ViewsList;
            cbCrmView.DisplayMember = "Name";
            cbCrmView.ValueMember = "SavedQueryId";
        }

        private void rbbImportConection_Click(object sender, EventArgs e)
        {
            //using (var frmSettingImport = new FrmImportSetting())
            //{
            //    var modelImport = new ModelsFrmImport();
            //    var controllerImport = new ControllersImport(frmSettingImport, modelImport);
            //    var result = frmSettingImport.ShowDialog();
            //    if (result == DialogResult.OK)
            //    {
            //        this.ImportServerConnection = frmSettingImport.ServerConnection;
            //        this.lblServerNameImport.Text = 
            //            this.ImportServerConnection.configurations[0].OrganizationUri.ToString().Substring(0,
            //            this.ImportServerConnection.configurations[0].OrganizationUri.ToString().IndexOf('.'));
            //        rbbTestView.Enabled = true;
            //        rbbBuscarDatosVista.Enabled = true;
            //        rbbImportView.Enabled = true;
            //    }  
            //}
        }

        #endregion

        #region Export Plugin

        private void GetAllPlugin()
        {
            OpenLoading();
            _controlerFrmMain.GetAllPlugin();
        }

        void rbbShowPlugin_Click(object sender, EventArgs e)
        {
            OpenLoading();
          _controlerFrmMain.SavePlugin();
        }

        public void SetListPlugin(IModelFrmMain modelFrmMain)
        {
            this.c1_dgwPlugin.DataSource = modelFrmMain.Plugins;
            //this.dgwPlugin.DataSource = modelFrmMain.Plugins;
        }

        void c1_dgwPlugin_ValidateEdit(object sender, C1.Win.C1FlexGrid.ValidateEditEventArgs e)
        {
            Row boundControl = c1_dgwPlugin.Rows[e.Row];
            if ((CheckEnum) e.Checkbox == CheckEnum.Checked)
            {
                c1_dgwPlugin.Rows[e.Row].StyleNew.BackColor = Color.LightSteelBlue;
                var pluginObject = boundControl.DataSource as PluginObject;
                _controlerFrmMain.PluginObjects.Add(pluginObject);
            }
            else
            {
                c1_dgwPlugin.Rows[e.Row].StyleNew.BackColor = Color.White;
            }
        }

        void dgwPlugin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                var isSelected = dgwPlugin.Rows[e.RowIndex].Cells[0] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(isSelected.Value))
                {
                    var boundControl = dgwPlugin.Rows[e.RowIndex];
                    dgwPlugin.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightSteelBlue;
                    var pluginObject = boundControl.DataBoundItem as PluginObject;
                    _controlerFrmMain.PluginObjects.Add(pluginObject);
                }
                else
                {
                    dgwPlugin.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                }
            }
        }

        void dgwPlugin_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgwPlugin.IsCurrentCellDirty)
            {
                dgwPlugin.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        void c1_dgwPlugin_AfterRowColChange(object sender, C1.Win.C1FlexGrid.RangeEventArgs e)
        {

            var evento = e;
            var objeto = sender;
            //if (e.ColumnIndex == 0)
            //{
            //    var isSelected = dgwPlugin.Rows[e.RowIndex].Cells[0] as DataGridViewCheckBoxCell;
            //    if (Convert.ToBoolean(isSelected.Value))
            //    {
            //        var boundControl = dgwPlugin.Rows[e.RowIndex];
            //        dgwPlugin.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightSteelBlue;
            //        var pluginObject = boundControl.DataBoundItem as PluginObject;
            //        _controlerFrmMain.PluginObjects.Add(pluginObject);
            //    }
            //    else
            //    {
            //        dgwPlugin.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            //    }
            //}
        }


        #endregion

        private void DgvRegistroClick(object sender, EventArgs e)
        {
            if (dgvRegistro.CurrentRow == null) return;
            var dataGridViewCell = dgvRegistro.CurrentRow.Cells[9];
            txtDetail.Text = dataGridViewCell.Value.ToString();
        }

        void dgvRegistro_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvRegistro.Columns[9].Visible = false;
            if (dgvRegistro.Columns[e.ColumnIndex].Name != "Level") return;
            var row = dgvRegistro.Rows[e.RowIndex];
            if (e.Value != null)
                switch (e.Value.ToString())
                {
                    case "Error":
                        row.DefaultCellStyle.BackColor = Color.Firebrick;
                        break;
                    case "Info":
                        row.DefaultCellStyle.BackColor = Color.Gainsboro;
                        break;
                    case "Warning":
                    case "Verbose":
                        row.DefaultCellStyle.BackColor = Color.Khaki;
                        break;
                }
        }

        void rbbOpen_Click(object sender, EventArgs e)
        {
            _controlerFrmMain.GetValueString("CRM_Server_InstallDir", "Software\\Microsoft\\MSCRM");

            var openFile = new OpenFileDialog
            {
                Filter = rsTool.FileType,
                InitialDirectory = this.InitialDirectory

            };
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                if (openFile.FileName == null) return;
                this.FilePath = openFile.FileName;
                dgvRegistro.Columns[0].Visible = true;
                dgvRegistro.Columns[10].Visible = false;
            }
        }

        void rbbSetup_Click(object sender, EventArgs e)
        {
            using (var frmSettingTrae = new FrmTraceSetting())
            {
                var modelTrace = new ModelTrace();
                var controllerTrace = new ControllersFrmTrace(frmSettingTrae, modelTrace);
                var result = frmSettingTrae.ShowDialog();
            }
        }

        public void Message()
        {
            frmLoading.Close();
            this.Enabled = true;
        }
        private async void OpenLoading()
        {
            this.Enabled = false;
            frmLoading = new Loading();
            frmLoading.Show(this);
        }

        #region Events
        #region Publish
        void c1_dgwResources_ValidateEdit(object sender, ValidateEditEventArgs e)
        {
            Row boundControl = c1_dgwResources.Rows[e.Row];
            if ((CheckEnum)e.Checkbox == CheckEnum.Checked)
            {
                c1_dgwResources.Rows[e.Row].StyleNew.BackColor = Color.LightSteelBlue;
                var resourceObject = boundControl.DataSource as WebResourceObject;
                _controlerFrmMain.WebResourceObjects.Add(resourceObject);
            }
            else
            {
                c1_dgwResources.Rows[e.Row].StyleNew.BackColor = Color.White;
            }
        }

        private void RbbPublishSelectedOnClick(object sender, EventArgs eventArgs)
        {
            this.Enabled = false;
            OpenLoading();
            _controlerFrmMain.UpdateResource();
        }
        void rbbPublish_Click(object sender, EventArgs e)
        {
            this.Enabled = true;
            OpenLoading();
            foreach (Row row in c1_dgwResources.Rows)
            {
                var resourceObject = row.DataSource as WebResourceObject;
                _controlerFrmMain.WebResourceObjects.Add(resourceObject);
            }
            _controlerFrmMain.Publish();
        }
        void dgwResources_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgwResources.IsCurrentCellDirty)
            {
                dgwResources.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        private void dgwResources_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                var isSelected = dgwResources.Rows[e.RowIndex].Cells[0] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(isSelected.Value))
                {
                    var boundControl = dgwResources.Rows[e.RowIndex];
                    dgwResources.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightSteelBlue;
                    var resourceObject = boundControl.DataBoundItem as WebResourceObject;
                    _controlerFrmMain.WebResourceObjects.Add(resourceObject);
                }
                else
                {
                    dgwResources.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
            }
            else if (e.ColumnIndex == 5)
            {
                var result = ofdPath.ShowDialog();
                if (result == DialogResult.OK)
                {
                    var fileName = ofdPath.FileName;
                    dgwResources.Rows[e.RowIndex].Cells["Path"].Value = fileName;
                }
            }
        }
        #endregion

        #region Tool
        void rbbConfigTool_Click(object sender, EventArgs e)
        {
            //using (var frmtool = new FrmTools())
            //{
            //    var result = frmtool.ShowDialog();
            //    if (result == DialogResult.OK)
            //    {
            //        foreach (var option in frmtool.Options)
            //        {
            //            switch (option)
            //            {
            //                case "Quick publish":
            //                    //this.rbMain.Tabs.Add(this.rbtQuickPublish);
            //                    this.tbTools.Controls.Add(this.tbPublish);
            //                    this.tbPublish.Focus();
            //                    break;
            //                case "Trace":
            //                    //this.rbMain.Tabs.Add(this.rbtTrace);
            //                    this.tbTools.Controls.Add(this.tbTrace);
            //                    this.tbTrace.Focus();
            //                    break;
            //                case "Import":
            //                    //this.rbMain.Tabs.Add(this.rbtImports);
            //                    this.tbTools.Controls.Add(this.tbImport);
            //                    break;
            //                case "Intellisense":
            //                    //this.rbMain.Tabs.Add(this.rbtIntellisense);
            //                    this.tbTools.Controls.Add(this.tbIntellisense);
            //                    GetEntities();
            //                    break;
            //                case "Export":
            //                    //this.rbMain.Tabs.Add(this.rbExport);
            //                    this.tbTools.Controls.Add(this.tbExport);
            //                    GetAllPlugin();
            //                    break;

            //            }
            //        }
            //    }
            //}
        }

        void rbbOpenConfiguration_Click(object sender, EventArgs e)
        {
            var result = ofdOldPackage.ShowDialog();
            if (result == DialogResult.OK)
            {
                var fileName = ofdOldPackage.FileName;
                _controlerFrmMain.PathPackage = fileName;
                _controlerFrmMain.OpenPackage();
            }
        }

        private void rbbSaveConfiguration_Click(object sender, EventArgs e)
        {
            var quickPublish = new QuickPublish();
            var listObject = new List<WebResourceObject>();

            foreach (var row in dgwResources.Rows)
            {
                var boundControl = row as DataGridViewRow;
                var resourceObject = boundControl.DataBoundItem as WebResourceObject;
                listObject.Add(resourceObject);
            }

            quickPublish.SolutionGuid = new Guid(this.SolutionId);
            quickPublish.SolutionName = c1_cbSolution.Text;
            quickPublish.WebResourceObjects = listObject;

            _controlerFrmMain.QuickPublish = quickPublish;
            _controlerFrmMain.SavePackages();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            _controlerFrmMain.GetWebResource();
        }

        void cbSolution_Click(object sender, EventArgs e)
        {
            if (c1_cbSolution.Items.Count > 0) return;
            OpenLoading();
            _controlerFrmMain.GetSolutions();
        }

        private void FrmMainOnLoad(object sender, EventArgs eventArgs)
        {
            _controlerFrmMain.ChangeTheme();
        }

        void rbbConnectToServer_Click(object sender, EventArgs e)
        {
            _controlerFrmMain.GetFormConfigurationConnection();

        } 
        #endregion
        #endregion

        #region View

        public void FillGridViewTrace(IModelFrmMain modelFrmMain)
        {
            dgvRegistro.DataSource = modelFrmMain.LogObjects;
        }

        public void SetSolution(IModelFrmMain modelFrmMain)
        {
            c1_cbSolution.DataSource = modelFrmMain.SolutionObjects;
            c1_cbSolution.DisplayMember = "FriendlyName";
            c1_cbSolution.ValueMember = "SolutionId";
        }

        public void SetWebResource(IModelFrmMain modelFrmMain)
        {
            this.c1_dgwResources.DataSource = modelFrmMain.WebResourcesObjects;
            //c1_dgwResources.AllowFiltering = true;
            c1_dgwResources.AllowSorting = AllowSortingEnum.MultiColumn;
            //c1_dgwResources.AllowDragging = AllowDraggingEnum.Columns;

            c1_dgwResources.Cols["DisplayName"].Filter = new StringFilter();
            //c1_dgwResources.Cols["WebResource"].Visible = false;
            c1_dgwResources.Cols["WebResourceType"].Visible = false;
            //c1_dgwResources.Cols["SolutionId"].Visible = false;
            
            var col = this.c1_dgwResources.Cols.Add();
            col.Name = "DetailButton";
            col.Caption = "...";
            col.ComboList = "...";
            col.Width = 20;

            this.c1_dgwResources.CellButtonClick += new RowColEventHandler(c1_dgwResources_CellButtonClick);

        }

        void c1_dgwResources_CellButtonClick(object sender, RowColEventArgs e)
        {
            //MessageBox.Show(string.Format("Detail for row {0}", e.Row));
            var result = ofdPath.ShowDialog();
            if (result == DialogResult.OK)
            {
                var fileName = ofdPath.FileName;
                c1_dgwResources[e.Row, "Path"] = fileName;
            }
        }

        public void SetSolutionForId(IModelFrmMain modelFrmMain)
        {
            this.c1_cbSolution.SelectedValue = modelFrmMain.Solution.SolutionId;
        }

        public void setController(IControllerFrmMain cont)
        {
            _controlerFrmMain = cont;
        }

        public void LoadEventArgs()
        {
            _controlerFrmMain.WebResourceObjects = new List<WebResourceObject>();
            _controlerFrmMain.PluginObjects = new List<PluginObject>();
        }

        public void GetFormConfigurationConnection()
        {
            var ctrl = new CRMLoginForm1();
            ctrl.ConnectionToCrmCompleted += ctrl_ConnectionToCrmCompleted;
            ctrl.ShowDialog();

            if (ctrl.CrmConnectionMgr != null && ctrl.CrmConnectionMgr.CrmSvc != null && ctrl.CrmConnectionMgr.CrmSvc.IsReady)
            {
                c1_rbsTools.Enabled = true;
                c1_DockingTab.Visible = true;
                this.ServerConnection = ctrl.CrmConnectionMgr.CrmSvc;
            }
            else
            {
                MessageBox.Show("Cannot connect; try again!", "Connection Status");
            }
        }

        private void ctrl_ConnectionToCrmCompleted(object sender, EventArgs e)
        {
            if (sender is CRMLoginForm1)
            {
                ((CRMLoginForm1)sender).Close();
            }
        }

        void rbbDisconnectToServer_Click(object sender, EventArgs e)
        {
            this.Dispose();

            DialogResult message = MessageBox.Show("Desea cerrar la app?", "alerta", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);
            if (message == DialogResult.OK)
            {
                this.Close();
            }
        }

        #endregion

        #region Properties
        public CrmServiceClient ServerConnection { get; set; }
        //public ServerConnection ImportServerConnection { get; set; }
        public String InitialDirectory { get; set; }
        public String FilePath { get; set; }

        public String PreviewScript
        {
            get
            {
                return txtPreviewScript.Text;
            }
            set { txtPreviewScript.Text = value; }
        }

        public String PathScript {
            get
            {
                return txtPathFolderBox.Text;
            }
            set
            {
                txtPathFolderBox.Text = value;
            }
        }

        public Guid GuidViewGuid { get; set; }

        public String FetchXmlView
        {
            get
            {
                return txtInformation.Text;
            }
            set
            {
                txtInformation.Text = value;
            }
        }

        public String SolutionId
        {
            get
            {
                return c1_cbSolution.SelectedValue.ToString();
            }
            set
            {
                c1_cbSolution.SelectedValue = value;
            }
        }

        public String EntityScript
        {
            get
            {
                return clbEntities.Text;
            }
        }

        #endregion
    }
}
