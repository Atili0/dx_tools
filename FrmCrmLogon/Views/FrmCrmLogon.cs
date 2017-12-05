namespace DeXrm.Win.Tools
{
    using System;
    using System.Windows.Forms;
    using Controllers;
    using Models;
    using Views;
    //using Microsoft.Crm.Sdk.Helper;

    public partial class FrmCrmLogon : Form, IViewFrmLogon
    {
        private IControllersFrmLogon _controllers;
        Loading frmLoading;

        public FrmCrmLogon()
        {
            InitializeComponent();
            this.Load += FrmCrmLogon_Load; 
            cbUser.Click += cbUser_Click;
            btnRetrieveOrganization.Click += btnRetrieveOrganization_Click;
            btnAceptar.Click += BtnAceptarOnClick;
            cbType.SelectedValueChanged += cbType_Click;
            IsTemplate = true;
            
        }

        #region Events
        private void FrmCrmLogon_Load(object sender, EventArgs e)
        {
            _controllers.GetConfigSaved();
        }

        void cbType_Click(object sender, EventArgs e)
        {
            _controllers.GetUrlServer();
            switch (cbType.Text)
            {
                case "LiveId":
                    this.txtDomio.Enabled = false;
                    break;
                default:

                    break;
            }
        }

        private void BtnAceptarOnClick(object sender, EventArgs eventArgs)
        {
            _controllers.SetConfiguration();
            this.Close();
        }

        public void SetConfiguration(IModelsFrmLogon modelsFrmLogon)
        {
            //this.ServerConnection = modelsFrmLogon.ServerConnection;
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

        private void btnRetrieveOrganization_Click(object sender, EventArgs e)
        {
           
            errorProvider.Clear();

            if (cbUser.Checked)
                if (!CheckField("cbUser"))
                    return;

            if (!CheckField(cbType.Text))
                return;

            if (cbSaveConfig.Checked && !String.IsNullOrEmpty(cbSavedNameConfig.Text))
                IsTemplate = false;

            _controllers.GenerateConfig();
            _controllers.RetrieveOrganization();

        }


        void cbUser_Click(object sender, EventArgs e)
        {
            if (cbUser.Checked)
            {
                _controllers.DisableField();
            }
            else
            {
                _controllers.EnableField();
            }
        }
        #endregion

        #region Private Method

        private Boolean CheckField(String type)
        {
            var bSave = true;

            switch (type)
            {
                case "LiveId":
                    if (String.IsNullOrEmpty(txtPassword.Text))
                    {
                        errorProvider.SetError(txtPassword, "No Nulo");
                        bSave = false;
                    }
                    if (String.IsNullOrEmpty(txtUserName.Text))
                    {
                        errorProvider.SetError(txtUserName, "No Nulo");
                        bSave = false;
                    }
                    if (String.IsNullOrEmpty(cbSavedNameConfig.Text))
                    {
                        errorProvider.SetError(cbSavedNameConfig, "No Nulo");
                        bSave = false;
                    }
                    break;
                //case "cbUser":
                //    if (String.IsNullOrEmpty(txtDomio.Text))
                //    {
                //        errorProvider.SetError(txtDomio, "No Nulo");
                //        bSave = false;
                //    }
                //    if (String.IsNullOrEmpty(txtPassword.Text))
                //    {
                //        errorProvider.SetError(txtPassword, "No Nulo");
                //        bSave = false;
                //    }
                //    if (String.IsNullOrEmpty(txtUserName.Text))
                //    {
                //        errorProvider.SetError(txtUserName, "No Nulo");
                //        bSave = false;
                //    }
                //    if (String.IsNullOrEmpty(cbSavedNameConfig.Text))
                //    {
                //        errorProvider.SetError(cbSavedNameConfig, "No Nulo");
                //        bSave = false;
                //    }
                //    break;
            }
            return bSave;
        }
        #endregion

        #region View

        public void SetOrganization(IModelsFrmLogon modelsFrmLogon)
        {
            cbOrganization.DataSource = modelsFrmLogon.OrganizationObjects;
            cbOrganization.DisplayMember = "FriendlyName";
            cbOrganization.ValueMember = "IdOrganization";
            btnAceptar.Enabled = true;
        }

        public void SetConfigSaved(IModelsFrmLogon modelsFrmLogon)
        {
            cbSavedNameConfig.DataSource = modelsFrmLogon.File ;
            cbSavedNameConfig.DisplayMember = "Name";
            cbSavedNameConfig.ValueMember = "FullPath";
            //cbSavedNameConfig.Items.Add(new ListItem("asdasdasd", "asdasdasd"));

        }

        public void setController(IControllersFrmLogon cont)
        {
            _controllers = cont;
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
            this.txtUrlServer.Enabled = false;
        }

        public void EnableServerField()
        {
            this.txtUrlServer.Enabled = true;
        }
        #endregion

        #region Form Object

        public String UrlServer
        {
            get { return txtUrlServer.Text; }
            set { txtUrlServer.Text = value; }
        }

        public String User
        {
            get { return txtUserName.Text; }
            set { txtUserName.Text = value; }
        }

        public String Domain
        {
            get { return txtDomio.Text; } 
            set { txtDomio.Text = value; } 
            
        }

        public String Password
        {
            get { return txtPassword.Text; }
            set { txtPassword.Text = value; }
        }

        public String TypeUrl
        {
            get { return cmbType.Text; }
            set { cmbType.Text = value; }
        }

        public String TypeConnection {
            get { return cbType.Text ; }
            set { cbType.Text = value ; }
        }

        public Boolean InternalUser
        {
            get { return cbUser.Checked ; }
            set { cbUser.Checked = value; }
        }

        public Boolean IsOnline
        {
            get { return cbIsOnline.Checked; }
            set { cbIsOnline.Checked = value; }
        }

        public String SavedConfig
        {
            get {return cbSavedNameConfig.Text ; }
            set { cbSavedNameConfig.Text = value;  }
        }

        public String Organization
        {
            get { return cbOrganization.Text; }
            set { cbOrganization.Text = value; }
        }

        public Boolean IsTemplate { get; set; }

        /// <summary>
        /// Objeto para poder enviarlo al Main
        /// </summary>
        //public ServerConnection ServerConnection { get; set; }  

        #endregion

    }
}
