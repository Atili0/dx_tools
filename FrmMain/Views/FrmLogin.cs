using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Tooling.Connector;
using CancelEventArgs = System.ComponentModel.CancelEventArgs;

namespace DeXrm.Win.Tools
{
    public partial class FrmLogin : Form
    {
        private readonly Conexion _conexion;

        public FrmLogin()
        {
            InitializeComponent();
            _conexion = new Conexion();

            rbLocal.CheckedChanged += RbLocalOnCheckedChanged;
            rbOffice.CheckedChanged += RbLocalOnCheckedChanged;
            txtURL.Validating += TxtURL_Validating;
            txtUser.Validated += TxtUser_Validated;
            c1ComboBox1.SelectedItemChanged += C1ComboBox1OnSelectedItemChanged;

            btnAceptar.Click += BtnAceptar_Click;

            //GetFileOrganization();

            #region set connection

            c1ComboBox1.ItemsDataSource = GetFileOrganization();
            c1ComboBox1.ItemsValueMember = "Path";
            c1ComboBox1.ItemsDisplayMember = "Name";

            #endregion
        }

        public CrmServiceClient ServerConnection { get; set; }

        public Guid SystemUserConnectedGuid { get; set; }

        private void C1ComboBox1OnSelectedItemChanged(object sender, EventArgs eventArgs)
        {
            var result = MessageBox.Show("Do you want with this credentials?", "Warning",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                ServerConnection = new CrmServiceClient(c1ComboBox1.SelectedItem.ToString());
                if (ServerConnection != null)
                {
                    var userid = (WhoAmIResponse) ServerConnection.Execute(new WhoAmIRequest());
                    if (userid.UserId == Guid.Empty)
                        MessageBox.Show("We can not connect to the DYN365", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    else SystemUserConnectedGuid = userid.UserId;
                }
                else
                {
                    MessageBox.Show("We can not connect to the DYN365", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                Close();
            }
        }

        #region Get Connection File

        public List<ConnectionFile> GetFileOrganization()
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(_conexion.FileConfigurationPah);
            var nodeList = xmlDoc.SelectNodes("Connections/dexrm");

            var lstConnectionFile = new List<ConnectionFile>();
            foreach (XmlElement xmlElement in nodeList)
            {
                var _connectionFile = new ConnectionFile();
                _connectionFile.Name = xmlElement.Attributes["name"].Value;
                _connectionFile.Path =
                    Encrypt.DecryptString(xmlElement.Attributes["ConnectionString"].Value, Encrypt.Phase);
                lstConnectionFile.Add(_connectionFile);
            }
            return lstConnectionFile;
        }

        #endregion

        private void TxtUser_Validated(object sender, EventArgs e)
        {
            error_url.SetError(txtURL, "");
        }

        private void TxtURL_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckUrlValid(txtURL.Text))
            {
                e.Cancel = true;
                txtURL.Select(0, txtUser.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                error_url.SetError(txtURL, "Error in URL");
            }
        }

        public static bool CheckUrlValid(string strUrl)
        {
            return Uri.IsWellFormedUriString(strUrl, UriKind.RelativeOrAbsolute);
            ;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (!rbLocal.Checked && !rbOffice.Checked) return;
            if (ValidateBlank()) return;

            _conexion.url = txtURL.Text;
            _conexion.user = txtUser.Text;
            _conexion.password = txtPasword.Text;
            _conexion.domain = txtDominio.Text;

            if (rbLocal.Checked) GetNameOrganization(ConectionType.Local);
            else GetNameOrganization(ConectionType.Office365);

            try
            {
                ServerConnection = new CrmServiceClient(_conexion.ConnectionString);
                var userid = (WhoAmIResponse) ServerConnection.Execute(new WhoAmIRequest());
                if (userid.UserId == Guid.Empty)
                    MessageBox.Show("We can not connect to the DYN365", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                else SystemUserConnectedGuid = userid.UserId;

                if (cbSave.Checked)
                {
                    var result = MessageBox.Show("Are you sure to save this connection?", "Warning",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        var doc = XDocument.Load(_conexion.FileConfigurationPah);
                        var Connections = doc.Element("Connections");
                        Connections.Add(new XElement("dexrm",
                            new XAttribute("name", _conexion.nameOrganization),
                            new XAttribute("ConnectionString",
                                Encrypt.EncryptString(_conexion.ConnectionString, Encrypt.Phase))));
                        doc.Save(_conexion.FileConfigurationPah);
                    }
                }
            }
            catch (Exception ex)
            {
                var tt = ex.Message;
                throw;
            }
            Close();
        }

        private void RbLocalOnCheckedChanged(object sender, EventArgs eventArgs)
        {
            if (rbLocal.Checked)
            {
                _conexion.Type = AuthenticationProviderType.ActiveDirectory;
                txtPuerto.Enabled = true;
                txtDominio.Enabled = true;
                lblURL.Text = "Server";

                if (txtURL.Text != string.Empty)
                    GetNameOrganization(ConectionType.Office365);
            }
            else
            {
                _conexion.Type = AuthenticationProviderType.OnlineFederation;
                txtPuerto.Enabled = false;
                txtDominio.Enabled = false;
                lblURL.Text = "URL";

                if (txtURL.Text != string.Empty)
                    GetNameOrganization(ConectionType.Local);
            }
        }

        private void GetNameOrganization(ConectionType type)
        {
            _conexion.nameOrganization = txtURL.Text.Substring((int) type, txtURL.Text.IndexOf('.') - (int) type);
        }

        private bool ValidateBlank()
        {
            var hasError = false;
            foreach (Control c1 in Controls)
                if (c1 is TextBox)
                    if (rbOffice.Checked)
                    {
                        if (c1.Text == "")
                            if (c1.Name != txtDominio.Name && c1.Name != txtPuerto.Name && c1.Name != c1ComboBox1.Name)
                            {
                                error_blank.SetError(c1, "Please complete the information");
                                hasError = true;
                            }
                    }
                    else
                    {
                        if (c1.Text == "")
                        {
                            error_blank.SetError(c1, "Please complete the information");
                            hasError = true;
                        }
                    }


            return hasError;
        }
    }
}