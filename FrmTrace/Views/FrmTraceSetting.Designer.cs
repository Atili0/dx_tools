namespace DeXrm.Win.Tools
{
    partial class FrmTraceSetting
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
            this.fbDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbTrace = new System.Windows.Forms.GroupBox();
            this.txtWarning = new System.Windows.Forms.TextBox();
            this.cbTrace = new System.Windows.Forms.CheckBox();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.txtFolderTrace = new System.Windows.Forms.TextBox();
            this.lblDirectorio = new System.Windows.Forms.Label();
            this.nIconTrace = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnAceptar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gbTrace.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbTrace);
            this.panel1.Controls.Add(this.btnOpenFolder);
            this.panel1.Controls.Add(this.txtFolderTrace);
            this.panel1.Controls.Add(this.lblDirectorio);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 146);
            this.panel1.TabIndex = 0;
            // 
            // gbTrace
            // 
            this.gbTrace.Controls.Add(this.txtWarning);
            this.gbTrace.Controls.Add(this.cbTrace);
            this.gbTrace.Location = new System.Drawing.Point(15, 68);
            this.gbTrace.Name = "gbTrace";
            this.gbTrace.Size = new System.Drawing.Size(400, 68);
            this.gbTrace.TabIndex = 4;
            this.gbTrace.TabStop = false;
            this.gbTrace.Text = "Trace";
            // 
            // txtWarning
            // 
            this.txtWarning.BackColor = System.Drawing.SystemColors.Control;
            this.txtWarning.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWarning.Location = new System.Drawing.Point(115, 19);
            this.txtWarning.Multiline = true;
            this.txtWarning.Name = "txtWarning";
            this.txtWarning.ReadOnly = true;
            this.txtWarning.Size = new System.Drawing.Size(279, 37);
            this.txtWarning.TabIndex = 4;
            this.txtWarning.Text = "Esta acción modificará algunas propiedades del Regedit. Asegúrese de tener un bac" +
    "kup actualizado de él.";
            // 
            // cbTrace
            // 
            this.cbTrace.AutoSize = true;
            this.cbTrace.Location = new System.Drawing.Point(6, 31);
            this.cbTrace.Name = "cbTrace";
            this.cbTrace.Size = new System.Drawing.Size(103, 17);
            this.cbTrace.TabIndex = 3;
            this.cbTrace.Text = "¿Permitir Trace?";
            this.cbTrace.UseVisualStyleBackColor = true;
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Location = new System.Drawing.Point(380, 10);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(35, 37);
            this.btnOpenFolder.TabIndex = 2;
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            // 
            // txtFolderTrace
            // 
            this.txtFolderTrace.Enabled = false;
            this.txtFolderTrace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFolderTrace.Location = new System.Drawing.Point(101, 10);
            this.txtFolderTrace.Multiline = true;
            this.txtFolderTrace.Name = "txtFolderTrace";
            this.txtFolderTrace.Size = new System.Drawing.Size(273, 37);
            this.txtFolderTrace.TabIndex = 1;
            // 
            // lblDirectorio
            // 
            this.lblDirectorio.AutoSize = true;
            this.lblDirectorio.Location = new System.Drawing.Point(12, 22);
            this.lblDirectorio.Name = "lblDirectorio";
            this.lblDirectorio.Size = new System.Drawing.Size(83, 13);
            this.lblDirectorio.TabIndex = 0;
            this.lblDirectorio.Text = "Directorio Trace";
            // 
            // nIconTrace
            // 
            this.nIconTrace.Tag = "";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(350, 154);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // FrmTraceSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 179);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTraceSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configurar Trace";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbTrace.ResumeLayout(false);
            this.gbTrace.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog fbDialog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDirectorio;
        private System.Windows.Forms.TextBox txtFolderTrace;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.NotifyIcon nIconTrace;
        private System.Windows.Forms.GroupBox gbTrace;
        private System.Windows.Forms.CheckBox cbTrace;
        private System.Windows.Forms.TextBox txtWarning;
        private System.Windows.Forms.Button btnAceptar;
    }
}