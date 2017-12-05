using System;
using System.Windows.Forms;
using DeXrm.Win.Tools.FrmNewEntity.Controllers;

namespace DeXrm.Win.Tools.FrmNewEntity.View
{
    public partial class FrmNewEntity : Form, IFrmNewEntity
    {
        private IControllerNewEntity _controllers;

        public FrmNewEntity()
        {
            InitializeComponent();

            #region Eventos

            btnCancelNewEntity.Click += BtnCancelNewEntityOnClick;
            btnSaveNewEntity.Click += BtnSaveNewEntityOnClick;

            #endregion
        }

        public void SetController(IControllerNewEntity cont)
        {
            _controllers = cont;
        }

        private void BtnSaveNewEntityOnClick(object sender, EventArgs eventArgs)
        {
        }

        private void BtnCancelNewEntityOnClick(object sender, EventArgs eventArgs)
        {
            Close();
        }
    }
}