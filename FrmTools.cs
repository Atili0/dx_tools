using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DeXrm.Win.Tools
{
    public partial class FrmTools : Form
    {
        public FrmTools()
        {
            InitializeComponent();

            btnAceptar.Click += btnAceptar_Click;
            btnCancelar.Click += btnCancelar_Click;
        }

        public List<string> Options { get; set; }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var _options = (from object checkedItem in clbTools.CheckedItems select checkedItem.ToString()).ToList();
            Options = _options;
            Close();
        }
    }
}