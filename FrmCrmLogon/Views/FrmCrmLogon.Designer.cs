namespace DeXrm.Win.Tools
{
    partial class FrmCrmLogon
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.txtUrlServer = new System.Windows.Forms.TextBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSavedNameConfig = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRetrieveOrganization = new System.Windows.Forms.Button();
            this.txtDomio = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbIsOnline = new System.Windows.Forms.CheckBox();
            this.cbSaveConfig = new System.Windows.Forms.CheckBox();
            this.cbUser = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbOrganization = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbType);
            this.groupBox1.Controls.Add(this.txtUrlServer);
            this.groupBox1.Controls.Add(this.cmbType);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbSavedNameConfig);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(662, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "ActiveDirectory",
            "LiveId",
            "Federation",
            "OnlineFederation"});
            this.cbType.Location = new System.Drawing.Point(188, 49);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(96, 21);
            this.cbType.TabIndex = 3;
            // 
            // txtUrlServer
            // 
            this.txtUrlServer.Location = new System.Drawing.Point(290, 49);
            this.txtUrlServer.Name = "txtUrlServer";
            this.txtUrlServer.Size = new System.Drawing.Size(340, 20);
            this.txtUrlServer.TabIndex = 4;
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "http://",
            "https://"});
            this.cmbType.Location = new System.Drawing.Point(94, 49);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(88, 21);
            this.cmbType.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Discovery";
            // 
            // cbSavedNameConfig
            // 
            this.cbSavedNameConfig.FormattingEnabled = true;
            this.cbSavedNameConfig.Location = new System.Drawing.Point(94, 19);
            this.cbSavedNameConfig.Name = "cbSavedNameConfig";
            this.cbSavedNameConfig.Size = new System.Drawing.Size(536, 21);
            this.cbSavedNameConfig.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Existing Profile";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRetrieveOrganization);
            this.groupBox2.Controls.Add(this.txtDomio);
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtUserName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbIsOnline);
            this.groupBox2.Controls.Add(this.cbSaveConfig);
            this.groupBox2.Controls.Add(this.cbUser);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(662, 149);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Credentials";
            // 
            // btnRetrieveOrganization
            // 
            this.btnRetrieveOrganization.Location = new System.Drawing.Point(520, 120);
            this.btnRetrieveOrganization.Name = "btnRetrieveOrganization";
            this.btnRetrieveOrganization.Size = new System.Drawing.Size(110, 23);
            this.btnRetrieveOrganization.TabIndex = 11;
            this.btnRetrieveOrganization.Text = "Retrieve Org.";
            this.btnRetrieveOrganization.UseVisualStyleBackColor = true;
            // 
            // txtDomio
            // 
            this.txtDomio.Location = new System.Drawing.Point(94, 94);
            this.txtDomio.Name = "txtDomio";
            this.txtDomio.Size = new System.Drawing.Size(536, 20);
            this.txtDomio.TabIndex = 10;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(94, 68);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(536, 20);
            this.txtPassword.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Domain";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(94, 42);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(536, 20);
            this.txtUserName.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Password";
            // 
            // cbIsOnline
            // 
            this.cbIsOnline.AutoSize = true;
            this.cbIsOnline.Location = new System.Drawing.Point(316, 19);
            this.cbIsOnline.Name = "cbIsOnline";
            this.cbIsOnline.Size = new System.Drawing.Size(87, 17);
            this.cbIsOnline.TabIndex = 7;
            this.cbIsOnline.Text = "¿Office 365?";
            this.cbIsOnline.UseVisualStyleBackColor = true;
            // 
            // cbSaveConfig
            // 
            this.cbSaveConfig.AutoSize = true;
            this.cbSaveConfig.Checked = true;
            this.cbSaveConfig.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSaveConfig.Location = new System.Drawing.Point(167, 19);
            this.cbSaveConfig.Name = "cbSaveConfig";
            this.cbSaveConfig.Size = new System.Drawing.Size(143, 17);
            this.cbSaveConfig.TabIndex = 6;
            this.cbSaveConfig.Text = "¿Guardar configuración?";
            this.cbSaveConfig.UseVisualStyleBackColor = true;
            // 
            // cbUser
            // 
            this.cbUser.AutoSize = true;
            this.cbUser.Location = new System.Drawing.Point(10, 19);
            this.cbUser.Name = "cbUser";
            this.cbUser.Size = new System.Drawing.Size(151, 17);
            this.cbUser.TabIndex = 5;
            this.cbUser.Text = "¿Usar usuario conectado?";
            this.cbUser.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "User Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbOrganization);
            this.groupBox3.Location = new System.Drawing.Point(12, 273);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(662, 57);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Organizations";
            // 
            // cbOrganization
            // 
            this.cbOrganization.FormattingEnabled = true;
            this.cbOrganization.Location = new System.Drawing.Point(10, 19);
            this.cbOrganization.Name = "cbOrganization";
            this.cbOrganization.Size = new System.Drawing.Size(646, 21);
            this.cbOrganization.TabIndex = 12;
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.Enabled = false;
            this.btnAceptar.Location = new System.Drawing.Point(512, 347);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 13;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(593, 347);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FrmCrmLogon
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(680, 387);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCrmLogon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Crm Logon";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtUrlServer;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSavedNameConfig;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRetrieveOrganization;
        private System.Windows.Forms.TextBox txtDomio;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cbOrganization;
        private System.Windows.Forms.CheckBox cbSaveConfig;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.CheckBox cbIsOnline;
    }
}