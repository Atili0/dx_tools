using System;
using System.Windows.Forms;
using DeXrm.Win.Object;
using DeXrm.Win.Tools.Controllers;
using DeXrm.Win.Tools.Views;

namespace DeXrm.Win.Tools
{
    public partial class FrmTraceSetting : Form, IViewTraceSetting
    {
        private IControllersFrmTrace _controllers;

        public FrmTraceSetting()
        {
            InitializeComponent();

            #region Eventos

            btnOpenFolder.Click += BtnOpenFolderClick;
            cbTrace.CheckedChanged += ChbTraceCheckedChanged;
            btnAceptar.Click += btnAceptar_Click;

            #endregion
        }

        public void SetController(IControllersFrmTrace cont)
        {
            _controllers = cont;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //new DeXrmTrace().VerificaEnabledTrace(chbTrace.Checked, this.txtFolderTrace.Text);
            Close();
        }

        private void ChbTraceCheckedChanged(object sender, EventArgs e)
        {
            if (IsAvaibleTrace)
            {
                #region Confgurar Objeto de Trace

                nIconTrace.Visible = true;

                RegeditObject = new RegeditObject
                {
                    TraceCategories = "*:Verbose",
                    TraceDirectory = txtFolderTrace.Text,
                    TraceEnabled = true
                };
                _controllers.ChangeRegedit();

                #endregion
            }
            else
            {
                #region Confgurar Objeto de Trace

                RegeditObject = new RegeditObject
                {
                    TraceEnabled = false
                };
                _controllers.ChangeRegedit();
                nIconTrace.Visible = false;

                #endregion
            }
        }

        private void BtnOpenFolderClick(object sender, EventArgs e)
        {
            fbDialog.ShowNewFolderButton = true;
            fbDialog.RootFolder = Environment.SpecialFolder.MyComputer;
            var result = fbDialog.ShowDialog();
            if (result == DialogResult.OK)
                PathLog = fbDialog.SelectedPath;
        }

        #region View

        public bool IsAvaibleTrace
        {
            get { return cbTrace.Checked; }
            set { cbTrace.Checked = value; }
        }

        public string PathLog
        {
            get { return txtFolderTrace.Text; }
            set { txtFolderTrace.Text = value; }
        }

        public RegeditObject RegeditObject { get; set; }

        #endregion
    }
}