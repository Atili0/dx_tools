namespace DeXrm.Win.Tools
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
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
        private void InitializeComponent ()
        {
            this.components = new System.ComponentModel.Container();
            this.rbLocal = new System.Windows.Forms.RadioButton();
            this.rbOffice = new System.Windows.Forms.RadioButton();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPasword = new System.Windows.Forms.TextBox();
            this.lblURL = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.lblPuerto = new System.Windows.Forms.Label();
            this.txtPuerto = new System.Windows.Forms.TextBox();
            this.lblDomain = new System.Windows.Forms.Label();
            this.txtDominio = new System.Windows.Forms.TextBox();
            this.cbSave = new System.Windows.Forms.CheckBox();
            this.error_url = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_blank = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbl_CurrentConection = new System.Windows.Forms.Label();
            this.c1ComboBox1 = new C1.Win.C1Input.C1ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.error_url)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_blank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ComboBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbLocal
            // 
            this.rbLocal.AutoSize = true;
            this.rbLocal.Location = new System.Drawing.Point(12, 12);
            this.rbLocal.Name = "rbLocal";
            this.rbLocal.Size = new System.Drawing.Size(51, 17);
            this.rbLocal.TabIndex = 0;
            this.rbLocal.Text = "Local";
            this.rbLocal.UseVisualStyleBackColor = true;
            // 
            // rbOffice
            // 
            this.rbOffice.AutoSize = true;
            this.rbOffice.Location = new System.Drawing.Point(79, 12);
            this.rbOffice.Name = "rbOffice";
            this.rbOffice.Size = new System.Drawing.Size(77, 17);
            this.rbOffice.TabIndex = 0;
            this.rbOffice.Text = "Office 365.";
            this.rbOffice.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(232, 208);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(313, 208);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(14, 126);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(14, 152);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(79, 119);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(309, 20);
            this.txtUser.TabIndex = 4;
            // 
            // txtPasword
            // 
            this.txtPasword.Location = new System.Drawing.Point(79, 145);
            this.txtPasword.Name = "txtPasword";
            this.txtPasword.PasswordChar = '-';
            this.txtPasword.Size = new System.Drawing.Size(309, 20);
            this.txtPasword.TabIndex = 5;
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(14, 45);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(20, 13);
            this.lblURL.TabIndex = 3;
            this.lblURL.Text = "Url";
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(79, 38);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(309, 20);
            this.txtURL.TabIndex = 1;
            // 
            // lblPuerto
            // 
            this.lblPuerto.AutoSize = true;
            this.lblPuerto.Location = new System.Drawing.Point(14, 100);
            this.lblPuerto.Name = "lblPuerto";
            this.lblPuerto.Size = new System.Drawing.Size(38, 13);
            this.lblPuerto.TabIndex = 3;
            this.lblPuerto.Text = "Puerto";
            // 
            // txtPuerto
            // 
            this.txtPuerto.Enabled = false;
            this.txtPuerto.Location = new System.Drawing.Point(79, 93);
            this.txtPuerto.Name = "txtPuerto";
            this.txtPuerto.Size = new System.Drawing.Size(309, 20);
            this.txtPuerto.TabIndex = 3;
            // 
            // lblDomain
            // 
            this.lblDomain.AutoSize = true;
            this.lblDomain.Location = new System.Drawing.Point(14, 74);
            this.lblDomain.Name = "lblDomain";
            this.lblDomain.Size = new System.Drawing.Size(45, 13);
            this.lblDomain.TabIndex = 3;
            this.lblDomain.Text = "Dominio";
            // 
            // txtDominio
            // 
            this.txtDominio.Enabled = false;
            this.txtDominio.Location = new System.Drawing.Point(79, 67);
            this.txtDominio.Name = "txtDominio";
            this.txtDominio.Size = new System.Drawing.Size(309, 20);
            this.txtDominio.TabIndex = 2;
            // 
            // cbSave
            // 
            this.cbSave.AutoSize = true;
            this.cbSave.Location = new System.Drawing.Point(12, 208);
            this.cbSave.Name = "cbSave";
            this.cbSave.Size = new System.Drawing.Size(107, 17);
            this.cbSave.TabIndex = 6;
            this.cbSave.Text = "Save connection";
            this.cbSave.UseVisualStyleBackColor = true;
            // 
            // error_url
            // 
            this.error_url.ContainerControl = this;
            // 
            // error_blank
            // 
            this.error_blank.ContainerControl = this;
            // 
            // lbl_CurrentConection
            // 
            this.lbl_CurrentConection.AutoSize = true;
            this.lbl_CurrentConection.Location = new System.Drawing.Point(14, 176);
            this.lbl_CurrentConection.Name = "lbl_CurrentConection";
            this.lbl_CurrentConection.Size = new System.Drawing.Size(66, 13);
            this.lbl_CurrentConection.TabIndex = 3;
            this.lbl_CurrentConection.Text = "Connections";
            // 
            // c1ComboBox1
            // 
            this.c1ComboBox1.AllowSpinLoop = false;
            this.c1ComboBox1.GapHeight = 0;
            this.c1ComboBox1.ImagePadding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.c1ComboBox1.ItemsDisplayMember = "";
            this.c1ComboBox1.ItemsValueMember = "";
            this.c1ComboBox1.Location = new System.Drawing.Point(79, 173);
            this.c1ComboBox1.Name = "c1ComboBox1";
            this.c1ComboBox1.Size = new System.Drawing.Size(309, 18);
            this.c1ComboBox1.TabIndex = 9;
            this.c1ComboBox1.Tag = null;
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(410, 243);
            this.ControlBox = false;
            this.Controls.Add(this.c1ComboBox1);
            this.Controls.Add(this.cbSave);
            this.Controls.Add(this.txtPasword);
            this.Controls.Add(this.txtDominio);
            this.Controls.Add(this.txtPuerto);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.lblDomain);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblPuerto);
            this.Controls.Add(this.lbl_CurrentConection);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblURL);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.rbOffice);
            this.Controls.Add(this.rbLocal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.error_url)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_blank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ComboBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbLocal;
        private System.Windows.Forms.RadioButton rbOffice;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPasword;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label lblPuerto;
        private System.Windows.Forms.TextBox txtPuerto;
        private System.Windows.Forms.Label lblDomain;
        private System.Windows.Forms.TextBox txtDominio;
        private System.Windows.Forms.CheckBox cbSave;
        private System.Windows.Forms.ErrorProvider error_url;
        private System.Windows.Forms.ErrorProvider error_blank;
        private System.Windows.Forms.Label lbl_CurrentConection;
        private C1.Win.C1Input.C1ComboBox c1ComboBox1;
    }
}