namespace DeXrm.Win.Tools.FrmNewEntity.View
{
    partial class FrmNewEntity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNewEntity));
            this.gbNewEntity = new System.Windows.Forms.GroupBox();
            this.btnSaveNewEntity = new System.Windows.Forms.Button();
            this.btnCancelNewEntity = new System.Windows.Forms.Button();
            this.lblEditor = new System.Windows.Forms.Label();
            this.lblNombreEntidad = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.c1cEditor = new C1.Win.C1List.C1Combo();
            this.gbNewEntity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1cEditor)).BeginInit();
            this.SuspendLayout();
            // 
            // gbNewEntity
            // 
            this.gbNewEntity.Controls.Add(this.c1cEditor);
            this.gbNewEntity.Controls.Add(this.textBox1);
            this.gbNewEntity.Controls.Add(this.lblNombreEntidad);
            this.gbNewEntity.Controls.Add(this.lblEditor);
            this.gbNewEntity.Controls.Add(this.btnCancelNewEntity);
            this.gbNewEntity.Controls.Add(this.btnSaveNewEntity);
            this.gbNewEntity.Location = new System.Drawing.Point(0, 0);
            this.gbNewEntity.Name = "gbNewEntity";
            this.gbNewEntity.Size = new System.Drawing.Size(441, 249);
            this.gbNewEntity.TabIndex = 0;
            this.gbNewEntity.TabStop = false;
            this.gbNewEntity.Text = "New Entity";
            // 
            // btnSaveNewEntity
            // 
            this.btnSaveNewEntity.Location = new System.Drawing.Point(279, 220);
            this.btnSaveNewEntity.Name = "btnSaveNewEntity";
            this.btnSaveNewEntity.Size = new System.Drawing.Size(75, 23);
            this.btnSaveNewEntity.TabIndex = 0;
            this.btnSaveNewEntity.Text = "Guardar";
            this.btnSaveNewEntity.UseVisualStyleBackColor = true;
            // 
            // btnCancelNewEntity
            // 
            this.btnCancelNewEntity.Location = new System.Drawing.Point(360, 220);
            this.btnCancelNewEntity.Name = "btnCancelNewEntity";
            this.btnCancelNewEntity.Size = new System.Drawing.Size(75, 23);
            this.btnCancelNewEntity.TabIndex = 1;
            this.btnCancelNewEntity.Text = "Cancel";
            this.btnCancelNewEntity.UseVisualStyleBackColor = true;
            // 
            // lblEditor
            // 
            this.lblEditor.AutoSize = true;
            this.lblEditor.Location = new System.Drawing.Point(12, 33);
            this.lblEditor.Name = "lblEditor";
            this.lblEditor.Size = new System.Drawing.Size(34, 13);
            this.lblEditor.TabIndex = 2;
            this.lblEditor.Text = "Editor";
            // 
            // lblNombreEntidad
            // 
            this.lblNombreEntidad.AutoSize = true;
            this.lblNombreEntidad.Location = new System.Drawing.Point(12, 60);
            this.lblNombreEntidad.Name = "lblNombreEntidad";
            this.lblNombreEntidad.Size = new System.Drawing.Size(44, 13);
            this.lblNombreEntidad.TabIndex = 3;
            this.lblNombreEntidad.Text = "Nombre";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(360, 20);
            this.textBox1.TabIndex = 4;
            // 
            // c1cEditor
            // 
            this.c1cEditor.AddItemSeparator = ';';
            this.c1cEditor.Caption = "";
            this.c1cEditor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.c1cEditor.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.c1cEditor.EditorBackColor = System.Drawing.SystemColors.Window;
            this.c1cEditor.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1cEditor.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.c1cEditor.Location = new System.Drawing.Point(75, 30);
            this.c1cEditor.MatchEntryTimeout = ((long)(2000));
            this.c1cEditor.MaxDropDownItems = ((short)(5));
            this.c1cEditor.MaxLength = 32767;
            this.c1cEditor.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.c1cEditor.Name = "c1cEditor";
            this.c1cEditor.PropBag = resources.GetString("c1cEditor.PropBag");
            this.c1cEditor.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.c1cEditor.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.c1cEditor.Size = new System.Drawing.Size(360, 21);
            this.c1cEditor.TabIndex = 5;
            // 
            // FrmNewEntity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 261);
            this.ControlBox = false;
            this.Controls.Add(this.gbNewEntity);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNewEntity";
            this.Text = "New Entity";
            this.gbNewEntity.ResumeLayout(false);
            this.gbNewEntity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1cEditor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNewEntity;
        private System.Windows.Forms.Button btnCancelNewEntity;
        private System.Windows.Forms.Button btnSaveNewEntity;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblNombreEntidad;
        private System.Windows.Forms.Label lblEditor;
        private C1.Win.C1List.C1Combo c1cEditor;
    }
}