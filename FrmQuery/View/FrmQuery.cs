//using Microsoft.Crm.Sdk.Helper;

using System;
using System.Windows.Forms;

namespace DeXrm.Win.Tools.Views
{
    public partial class FrmQuery : Form, IFrmQuery
    {
        private IControllerFrmQuery _controlerFrmMain;
        private Loading frmLoading;

        public FrmQuery()
        {
            InitializeComponent();
            Load += FrmQuery_Load;
        }

        public void setController(IControllerFrmQuery cont)
        {
            _controlerFrmMain = cont;
        }

        public void SetEntities(IModelFrmQuery model)
        {
            dtgEntities.DataSource = model.Entities;
        }

        public void Message()
        {
            frmLoading.Close();
            Enabled = true;
        }

        private void FrmQuery_Load(object sender, EventArgs e)
        {
            OpenLoading();
            _controlerFrmMain.GetEntities();
        }

        private async void OpenLoading()
        {
            Enabled = false;
            frmLoading = new Loading();
            frmLoading.Show(this);
        }

        #region Attributes

        //public ServerConnection ServerConnection { get; set; }

        #endregion
    }
}