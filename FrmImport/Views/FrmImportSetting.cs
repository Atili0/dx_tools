using System;
using System.Windows.Forms;
using DeXrm.Win.Tools.Controllers;
using DeXrm.Win.Tools.Models;

//using Microsoft.Crm.Sdk.Helper;

namespace DeXrm.Win.Tools.FrmImport.Views
{
    public partial class FrmImportSetting : Form, IFrmImportSetting
    {
        private IControllersFrmImport _controllers;

        public FrmImportSetting()
        {
            InitializeComponent();
            Load += FrmCrmLogon_Load;
            cbUser.Click += cbUser_Click;
            btnRetrieveOrganization.Click += btnRetrieveOrganization_Click;
            btnAceptar.Click += BtnAceptarOnClick;
            cbType.SelectedValueChanged += cbType_Click;
            IsTemplate = true;
        }

        public void SetController(IControllersFrmImport cont)
        {
            _controllers = cont;
        }

        #region Private Method

        private bool CheckField(string type)
        {
            var bSave = true;

            switch (type)
            {
                case "LiveId":
                    if (string.IsNullOrEmpty(txtPassword.Text))
                    {
                        errorProvider.SetError(txtPassword, "No Nulo");
                        bSave = false;
                    }
                    if (string.IsNullOrEmpty(txtUserName.Text))
                    {
                        errorProvider.SetError(txtUserName, "No Nulo");
                        bSave = false;
                    }
                    if (string.IsNullOrEmpty(cbSavedNameConfig.Text))
                    {
                        errorProvider.SetError(cbSavedNameConfig, "No Nulo");
                        bSave = false;
                    }
                    break;
            }
            return bSave;
        }

        #endregion

        #region Events

        private void FrmCrmLogon_Load(object sender, EventArgs e)
        {
            _controllers.GetConfigSaved();
        }

        private void cbType_Click(object sender, EventArgs e)
        {
            _controllers.GetUrlServer();
            switch (cbType.Text)
            {
                case "LiveId":
                    txtDomio.Enabled = false;
                    break;
                default:

                    break;
            }
        }

        private void BtnAceptarOnClick(object sender, EventArgs eventArgs)
        {
            _controllers.SetConfiguration();
            Close();
        }

        public void SetConfiguration(IModelsFrmImport modelsFrmLogon)
        {
            //this.ServerConnection = modelsFrmLogon.ServerConnection;
        }

        private void btnRetrieveOrganization_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            if (cbUser.Checked)
                if (!CheckField("cbUser"))
                    return;

            if (!CheckField(cbType.Text))
                return;

            if (cbSaveConfig.Checked && !string.IsNullOrEmpty(cbSavedNameConfig.Text))
                IsTemplate = false;

            _controllers.GenerateConfig();
            _controllers.RetrieveOrganization();
        }


        private void cbUser_Click(object sender, EventArgs e)
        {
            if (cbUser.Checked)
                _controllers.DisableField();
            else
                _controllers.EnableField();
        }

        #endregion

        #region View

        public void SetOrganization(IModelsFrmImport modelsFrmLogon)
        {
            cbOrganization.DataSource = modelsFrmLogon.OrganizationObjects;
            cbOrganization.DisplayMember = "FriendlyName";
            cbOrganization.ValueMember = "IdOrganization";
            btnAceptar.Enabled = true;
        }

        public void SetConfigSaved(IModelsFrmImport modelsFrmLogon)
        {
            cbSavedNameConfig.DataSource = modelsFrmLogon.File;
            cbSavedNameConfig.DisplayMember = "Name";
            cbSavedNameConfig.ValueMember = "FullPath";
        }

        public void DisableField()
        {
            txtUserName.Enabled = false;
            txtPassword.Enabled = false;
            txtDomio.Enabled = false;
        }

        public void EnableField()
        {
            txtUserName.Enabled = true;
            txtPassword.Enabled = true;
            txtDomio.Enabled = true;
        }

        public void DisableServerField()
        {
            txtUrlServer.Enabled = false;
        }

        public void EnableServerField()
        {
            txtUrlServer.Enabled = true;
        }

        #endregion

        #region Form Object

        public string UrlServer
        {
            get { return txtUrlServer.Text; }
            set { txtUrlServer.Text = value; }
        }

        public string User
        {
            get { return txtUserName.Text; }
            set { txtUserName.Text = value; }
        }

        public string Domain
        {
            get { return txtDomio.Text; }
            set { txtDomio.Text = value; }
        }

        public string Password
        {
            get { return txtPassword.Text; }
            set { txtPassword.Text = value; }
        }

        public string TypeUrl
        {
            get { return cmbType.Text; }
            set { cmbType.Text = value; }
        }

        public string TypeConnection
        {
            get { return cbType.Text; }
            set { cbType.Text = value; }
        }

        public bool InternalUser
        {
            get { return cbUser.Checked; }
            set { cbUser.Checked = value; }
        }

        public bool IsOnline
        {
            get { return cbIsOnline.Checked; }
            set { cbIsOnline.Checked = value; }
        }

        public string SavedConfig
        {
            get { return cbSavedNameConfig.Text; }
            set { cbSavedNameConfig.Text = value; }
        }

        public string Organization
        {
            get { return cbOrganization.Text; }
            set { cbOrganization.Text = value; }
        }

        public bool IsTemplate { get; set; }

        /// <summary>
        /// Objeto para poder enviarlo al Main
        /// </summary>
        //public ServerConnection ServerConnection { get; set; }

        #endregion
    }
}