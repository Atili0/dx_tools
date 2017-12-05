using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using CustomFilters;
using DeXrm.Win.Object;
using DeXrm.Win.Tools.Controllers;
using DeXrm.Win.Tools.Models;
using DeXrm.Win.Tools.Views;
using Microsoft.Xrm.Tooling.Connector;

namespace DeXrm.Win.Tools
{
    public partial class FrmMain : Form, IView
    {
        private IControllerFrmMain _controlerFrmMain;
        private Loading frmLoading;
        private bool IsCharged;

        public FrmMain()
        {
            InitializeComponent();
            //_action = action;
            Load += FrmMainOnLoad;
            c1_rbbConnectToServer.Click += rbbConnectToServer_Click;
            c1_rbbSaveConfiguration.Click += rbbSaveConfiguration_Click;
            c1_rbbDisconnectToServer.Click += rbbDisconnectToServer_Click;
            c1_rbbOpenConfiguration.Click += rbbOpenConfiguration_Click;

            c1_cbSolution.Click += cbSolution_Click;

            c1_btnBuscar.Click += btnBuscar_Click;
            c1_rbbPublishAll.Click += rbbPublish_Click;
            c1_rbbPublishSelected.Click += RbbPublishSelectedOnClick;
            //this.rbbConfigTool.Click += rbbConfigTool_Click;
            //this.rbbSetup.Click += rbbSetup_Click;
            //this.rbbOpen.Click += rbbOpen_Click;
            c1_cbEntity.Click += c1_cbEntity_Click;

            #region Tool

            c1_rbbExport.Click += c1_rbbExport_Click;
            c1_rbbPublish.Click += c1_rbbPublish_Click;
            c1_rbbAdministration.Click += c1_rbbAdministration_Click;

            #endregion

            #region Import

            //this.rbbTestView.Click += RbbTestViewOnClick;
            //rbbTestView.Enabled = false;

            #endregion

            #region Automatic

            auUpdate.ClosingAborted += auUpdate_ClosingAborted;
            //auUpdate.ForceCheckForUpdate(true);

            #endregion

            #region Publish

            c1_dgwResources.ValidateEdit += c1_dgwResources_ValidateEdit;

            #endregion

            #region Export Plugin

            c1_rbbShowPlugin.Click += rbbShowPlugin_Click;
            c1_dgwPlugin.AfterRowColChange += c1_dgwPlugin_AfterRowColChange;
            c1_dgwPlugin.ValidateEdit += c1_dgwPlugin_ValidateEdit;

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

            #region Import Entity

            rbbImportEntity.Click += rbbImportEntity_Click;
            btn_BuscarEntity.Click += btn_BuscarEntity_Click;

            #endregion

            #region Deploy

            rbbDeploy.Click += RbbDeploy_Click;

            #endregion
        }

        public void Message()
        {
            frmLoading.Close();
            Enabled = true;
        }

        private void auUpdate_ClosingAborted(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void rbbSetup_Click(object sender, EventArgs e)
        {
            using (var frmSettingTrae = new FrmTraceSetting())
            {
                var modelTrace = new ModelTrace();
                var controllerTrace = new ControllersFrmTrace(frmSettingTrae, modelTrace);
                var result = frmSettingTrae.ShowDialog();
            }
        }

        private async void OpenLoading()
        {
            Enabled = false;
            frmLoading = new Loading();
            frmLoading.Show(this);
        }

        private void c1_dgwPlugin_Click(object sender, EventArgs e)
        {
        }

        #region Deploy

        private void RbbDeploy_Click(object sender, EventArgs e)
        {
            OpenLoading();
            _controlerFrmMain.GetSolutions(ServerConnection, false);
            _controlerFrmMain.GetSolutions(ServerDeployConnection, true);
        }

        public void ShowSolution(IModelFrmMain modelFrmMain)
        {
            cgServerPre.DataSource = modelFrmMain.SolutionObjects;
        }

        public void ShowSolutionPro(IModelFrmMain modelFrmMain)
        {
            cgServerPro.DataSource = modelFrmMain.SolutionObjects;
        }

        #endregion

        #region Importa Entity

        public void SetAttribute(IModelFrmMain modelFrmMain)
        {
            c1_AttributeGrid.DataSource = modelFrmMain.Attribute;
            c1_AttributeGrid.Cols["AttributeType"].Visible = false;
            c1_AttributeGrid.Cols["AttributeId"].Visible = false;
            c1_AttributeGrid.Cols["MaxLength"].Visible = false;
            c1_AttributeGrid.Cols["Target"].Visible = false;
            c1_AttributeGrid.Cols["MaxValue"].Visible = false;
            c1_AttributeGrid.Cols["MinValue"].Visible = false;
            c1_AttributeGrid.Cols["DecimalMaxValue"].Visible = false;
            c1_AttributeGrid.Cols["DecimalMinValue"].Visible = false;
            c1_AttributeGrid.Cols["Precision"].Visible = false;
            c1_AttributeGrid.Cols["MoneyMaxValue"].Visible = false;
            c1_AttributeGrid.Cols["MoneyMinValue"].Visible = false;
            c1_AttributeGrid.Cols["TypeName"].Visible = true;
            c1_AttributeGrid.Cols["Description"].Visible = false;
            c1_AttributeGrid.Cols["SchemaName"].Visible = false;
            c1_AttributeGrid.Cols["DisplayName"].Visible = false;
        }

        private void btn_BuscarEntity_Click(object sender, EventArgs e)
        {
            _controlerFrmMain.GetAttributesByEntity();
        }

        public void SetEntity(IModelFrmMain modelFrmMain)
        {
            c1_cbEntity.DataSource = modelFrmMain.Entities;
            c1_cbEntity.DisplayMember = "EntitySchemaName";
            c1_cbEntity.ValueMember = "EntitySchemaName";
        }

        private void c1_cbEntity_Click(object sender, EventArgs e)
        {
            if (c1_cbEntity.ListCount > 0) return;
            OpenLoading();
            _controlerFrmMain.GetEntities();
        }


        private void rbbImportEntity_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            PathExcel = openFileDialog.FileName;
            _controlerFrmMain.ImportEntity();
        }

        #endregion


        #region Administration

        #endregion

        #region Query

        private void entitiesToolStripMenuItem_Click(object sender, EventArgs e)
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
            //if (trwQuery.Nodes.Count <= 1)
            //{
            //    trwQuery.ContextMenuStrip = cmsQuery;
            //}
        }

        #endregion

        #region Import

        private void rbbImportView_Click(object sender, EventArgs e)
        {
            Enabled = true;
            OpenLoading();
            _controlerFrmMain.ImportDataView();
        }

        public void SetImportGrid(IModelFrmMain modelFrmMain)
        {
            //var ds = new DataSet();
            //ds.ReadXml(new StringReader(modelFrmMain.NewEntityCollectionToImport));
            //this.dgwImportedData.DataSource = ds.Tables[0];
        }

        private void RbbTestViewOnClick(object sender, EventArgs eventArgs)
        {
            //if (String.IsNullOrEmpty(this.txtInformation.Text))
            //{
            //    MessageBox.Show("No hay fetchXML");
            //    return;
            //}
            //this.Enabled = true;
            //OpenLoading();
            //_controlerFrmMain.ExecuteFetchImport();
        }

        public void SetGridResultFetch(IModelFrmMain model)
        {
            //var ds = new DataSet();
            //ds.ReadXml(new StringReader(model.EntityCollection));
            //this.dgwResultTestFetch.DataSource = ds.Tables[0];
        }

        private void rbbBuscarDatosVista_Click(object sender, EventArgs e)
        {
            //this.Enabled = true;
            //OpenLoading();
            //this.GuidViewGuid = Guid.Parse(this.cbCrmView.SelectedValue.ToString());
            //_controlerFrmMain.GetViewById();
        }

        private void cbCrmView_Click(object sender, EventArgs e)
        {
            //if (cbCrmView.Items.Count > 0) return;
            //this.Enabled = true;
            //OpenLoading();
            //_controlerFrmMain.GetView();
        }

        public void SetFieldForView(IModelFrmMain model)
        {
            //this.FetchXmlView = model.ViewObject.FetchXml;
        }

        public void SetView(IModelFrmMain model)
        {
            //cbCrmView.DataSource = model.ViewsList;
            //cbCrmView.DisplayMember = "Name";
            //cbCrmView.ValueMember = "SavedQueryId";
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

        private void rbbShowPlugin_Click(object sender, EventArgs e)
        {
            OpenLoading();
            _controlerFrmMain.SavePlugin();
        }

        public void SetListPlugin(IModelFrmMain modelFrmMain)
        {
            c1_dgwPlugin.DataSource = modelFrmMain.Plugins;
        }

        private void c1_dgwPlugin_ValidateEdit(object sender, ValidateEditEventArgs e)
        {
            var boundControl = c1_dgwPlugin.Rows[e.Row];
            if (e.Checkbox == CheckEnum.Checked)
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


        private void c1_dgwPlugin_AfterRowColChange(object sender, RangeEventArgs e)
        {
            var evento = e;
            var objeto = sender;
        }

        #endregion

        #region Events

        #region Publish

        private void c1_dgwResources_ValidateEdit(object sender, ValidateEditEventArgs e)
        {
            var boundControl = c1_dgwResources.Rows[e.Row];
            if (e.Checkbox == CheckEnum.Checked)
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
            Enabled = false;
            OpenLoading();
            _controlerFrmMain.UpdateResource();
        }

        private void rbbPublish_Click(object sender, EventArgs e)
        {
            Enabled = true;
            OpenLoading();
            foreach (Row row in c1_dgwResources.Rows)
            {
                var resourceObject = row.DataSource as WebResourceObject;
                _controlerFrmMain.WebResourceObjects.Add(resourceObject);
            }
            _controlerFrmMain.Publish();
        }

        #endregion

        #region Tool

        private void c1_rbbAdministration_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("No no");
            c1_rbtAdministration.Enabled = true;
            c1_rbtAdministration.Visible = true;
            c1_doc_page_administration.Visible = true;
            c1_doc_page_administration.TabVisible = true;
        }

        private void c1_rbbPublish_Click(object sender, EventArgs e)
        {
            c1_DockingTab.Visible = true;
            c1_doc_page_publish.TabVisible = true;
            c1_doc_page_publish.Visible = true;
            c1_rbtQuickPublish.Enabled = true;
            c1_rbtQuickPublish.Visible = true;
            c1Ribbon1.TabIndex = 3;
        }

        private void c1_rbbExport_Click(object sender, EventArgs e)
        {
            c1_rbtExport.Visible = true;
            c1_doc_page_Export.TabVisible = true;
            c1_doc_page_Export.Visible = true;
            GetAllPlugin();
        }

        private void rbbConfigTool_Click(object sender, EventArgs e)
        {
        }

        private void rbbOpenConfiguration_Click(object sender, EventArgs e)
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

            foreach (Row row in c1_dgwResources.Rows)
            {
                var boundControl = row.DataSource as WebResourceObject;
                listObject.Add(boundControl);
            }

            quickPublish.SolutionGuid = new Guid(SolutionId);
            quickPublish.SolutionName = c1_cbSolution.Text;
            quickPublish.WebResourceObjects = listObject;

            _controlerFrmMain.QuickPublish = quickPublish;
            _controlerFrmMain.SavePackages();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            _controlerFrmMain.GetWebResource();
        }

        private void cbSolution_Click(object sender, EventArgs e)
        {
            if (c1_cbSolution.ListCount > 0) return;
            OpenLoading();
            _controlerFrmMain.GetSolutions();
        }

        private void FrmMainOnLoad(object sender, EventArgs eventArgs)
        {
            _controlerFrmMain.ChangeTheme();
        }

        private void rbbConnectToServer_Click(object sender, EventArgs e)
        {
            _controlerFrmMain.GetFormConfigurationConnection();
        }

        #endregion

        #endregion

        #region View

        public void FillGridViewTrace(IModelFrmMain modelFrmMain)
        {
            //dgvRegistro.DataSource = modelFrmMain.LogObjects;
        }

        public void SetSolution(IModelFrmMain modelFrmMain)
        {
            c1_cbSolution.DataSource = modelFrmMain.SolutionObjects;
            c1_cbSolution.Splits[0].DisplayColumns["SolutionId"].Visible = false;
            c1_cbSolution.Splits[0].DisplayColumns["UniqueName"].Visible = false;
            c1_cbSolution.Splits[0].DisplayColumns["IsManaged"].Visible = false;
            c1_cbSolution.Splits[0].DisplayColumns["Description"].Visible = false;

            c1_cbSolution.Columns[1].Caption = "Friendly Name";

            c1_cbSolution.DisplayMember = "FriendlyName";
            c1_cbSolution.ValueMember = "SolutionId";
        }

        public void SetWebResource(IModelFrmMain modelFrmMain)
        {
            c1_dgwResources.DataSource = modelFrmMain.WebResourcesObjects;
            c1_dgwResources.AllowSorting = AllowSortingEnum.MultiColumn;

            c1_dgwResources.Cols["DisplayName"].Filter = new StringFilter();
            c1_dgwResources.Cols["WebResourceType"].Visible = false;
            c1_dgwResources.Cols["WebResourceId"].Visible = false;

            var col = c1_dgwResources.Cols.Add();
            col.Name = "DetailButton";
            col.Caption = "...";
            col.ComboList = "...";
            col.Width = 20;

            c1_dgwResources.Cols["DetailButton"].AllowResizing = false;

            if (IsCharged) return;
            c1_dgwResources.CellButtonClick += c1_dgwResources_CellButtonClick;
            IsCharged = true;
        }

        private void c1_dgwResources_CellButtonClick(object sender, RowColEventArgs e)
        {
            var result = ofdPath.ShowDialog();
            if (result == DialogResult.OK)
            {
                var fileName = ofdPath.FileName;
                c1_dgwResources[e.Row, "Path"] = fileName;
            }
        }

        public void SetSolutionForId(IModelFrmMain modelFrmMain)
        {
            c1_cbSolution.SelectedValue = modelFrmMain.Solution.SolutionId;
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
            var ctrl = new FrmLogin();

            ctrl.ShowDialog();
            ServerDeployConnection = ctrl.ServerConnection;
            SystemUserConnectedGuid = ctrl.SystemUserConnectedGuid;

            if (ctrl.ServerConnection != null && ctrl.ServerConnection.IsReady)
            {
                c1_rbsTools.Enabled = true;
                _controlerFrmMain.SetConnectionName();
            }
            else
            {
                MessageBox.Show("Cannot connect; try again!", "Connection Status");
            }
        }

        public void SetConnectionName(IModelFrmMain modelFrmMain)
        {
            ribbonUserConnection.Text = modelFrmMain.GetConnectionName();
        }


        private void rbbDisconnectToServer_Click(object sender, EventArgs e)
        {
            Dispose();

            var message = MessageBox.Show("Desea cerrar la app?", "alerta", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);
            if (message == DialogResult.OK)
                Close();
        }

        #endregion

        #region Properties

        public CrmServiceClient ServerConnection { get; set; }

        public CrmServiceClient ServerDeployConnection { get; set; }

        public Guid SystemUserConnectedGuid { get; set; }

        public string InitialDirectory { get; set; }
        public string FilePath { get; set; }

        public Guid GuidViewGuid { get; set; }

        public string SolutionId
        {
            get { return c1_cbSolution.SelectedValue.ToString(); }
            set { c1_cbSolution.SelectedValue = value; }
        }

        public string PathExcel { get; set; }

        public string EntityId
        {
            get { return c1_cbEntity.SelectedValue.ToString(); }
            set { c1_cbEntity.SelectedValue = value; }
        }

        #endregion
    }
}