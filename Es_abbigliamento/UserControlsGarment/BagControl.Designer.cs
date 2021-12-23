namespace Es_abbigliamento.UserControlsGarment
{
    partial class BagControl
    {
        /// <summary> 
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.bagCmbType = new System.Windows.Forms.ComboBox();
            this.bagLblType = new System.Windows.Forms.Label();
            this.bagCmbSize = new System.Windows.Forms.ComboBox();
            this.bagLblSize = new System.Windows.Forms.Label();
            this.bagCmbTypology = new System.Windows.Forms.ComboBox();
            this.bagLblTypelogy = new System.Windows.Forms.Label();
            this.bagCmbSeason = new System.Windows.Forms.ComboBox();
            this.bagLblSeason = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bagCmbType
            // 
            this.bagCmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bagCmbType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.bagCmbType.FormattingEnabled = true;
            this.bagCmbType.Location = new System.Drawing.Point(46, 371);
            this.bagCmbType.Name = "bagCmbType";
            this.bagCmbType.Size = new System.Drawing.Size(283, 24);
            this.bagCmbType.TabIndex = 31;
            // 
            // bagLblType
            // 
            this.bagLblType.AutoSize = true;
            this.bagLblType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.bagLblType.Location = new System.Drawing.Point(42, 352);
            this.bagLblType.Name = "bagLblType";
            this.bagLblType.Size = new System.Drawing.Size(52, 16);
            this.bagLblType.TabIndex = 30;
            this.bagLblType.Text = "Genere";
            // 
            // bagCmbSize
            // 
            this.bagCmbSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bagCmbSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.bagCmbSize.FormattingEnabled = true;
            this.bagCmbSize.Location = new System.Drawing.Point(441, 189);
            this.bagCmbSize.Name = "bagCmbSize";
            this.bagCmbSize.Size = new System.Drawing.Size(283, 24);
            this.bagCmbSize.TabIndex = 37;
            // 
            // bagLblSize
            // 
            this.bagLblSize.AutoSize = true;
            this.bagLblSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.bagLblSize.Location = new System.Drawing.Point(437, 170);
            this.bagLblSize.Name = "bagLblSize";
            this.bagLblSize.Size = new System.Drawing.Size(46, 16);
            this.bagLblSize.TabIndex = 36;
            this.bagLblSize.Text = "Taglia";
            // 
            // bagCmbTypology
            // 
            this.bagCmbTypology.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bagCmbTypology.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.bagCmbTypology.FormattingEnabled = true;
            this.bagCmbTypology.Location = new System.Drawing.Point(441, 128);
            this.bagCmbTypology.Name = "bagCmbTypology";
            this.bagCmbTypology.Size = new System.Drawing.Size(283, 24);
            this.bagCmbTypology.TabIndex = 35;
            // 
            // bagLblTypelogy
            // 
            this.bagLblTypelogy.AutoSize = true;
            this.bagLblTypelogy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.bagLblTypelogy.Location = new System.Drawing.Point(437, 109);
            this.bagLblTypelogy.Name = "bagLblTypelogy";
            this.bagLblTypelogy.Size = new System.Drawing.Size(35, 16);
            this.bagLblTypelogy.TabIndex = 34;
            this.bagLblTypelogy.Text = "Tipo";
            // 
            // bagCmbSeason
            // 
            this.bagCmbSeason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bagCmbSeason.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.bagCmbSeason.FormattingEnabled = true;
            this.bagCmbSeason.Location = new System.Drawing.Point(441, 249);
            this.bagCmbSeason.Name = "bagCmbSeason";
            this.bagCmbSeason.Size = new System.Drawing.Size(283, 24);
            this.bagCmbSeason.TabIndex = 39;
            // 
            // bagLblSeason
            // 
            this.bagLblSeason.AutoSize = true;
            this.bagLblSeason.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.bagLblSeason.Location = new System.Drawing.Point(437, 230);
            this.bagLblSeason.Name = "bagLblSeason";
            this.bagLblSeason.Size = new System.Drawing.Size(61, 16);
            this.bagLblSeason.TabIndex = 38;
            this.bagLblSeason.Text = "Stagione";
            // 
            // BagControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bagCmbSeason);
            this.Controls.Add(this.bagLblSeason);
            this.Controls.Add(this.bagCmbSize);
            this.Controls.Add(this.bagLblSize);
            this.Controls.Add(this.bagCmbTypology);
            this.Controls.Add(this.bagLblTypelogy);
            this.Controls.Add(this.bagCmbType);
            this.Controls.Add(this.bagLblType);
            this.Name = "BagControl";
            this.Controls.SetChildIndex(this.bagLblType, 0);
            this.Controls.SetChildIndex(this.bagCmbType, 0);
            this.Controls.SetChildIndex(this.bagLblTypelogy, 0);
            this.Controls.SetChildIndex(this.bagCmbTypology, 0);
            this.Controls.SetChildIndex(this.bagLblSize, 0);
            this.Controls.SetChildIndex(this.bagCmbSize, 0);
            this.Controls.SetChildIndex(this.bagLblSeason, 0);
            this.Controls.SetChildIndex(this.bagCmbSeason, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox bagCmbType;
        private System.Windows.Forms.Label bagLblType;
        private System.Windows.Forms.ComboBox bagCmbSize;
        private System.Windows.Forms.Label bagLblSize;
        private System.Windows.Forms.ComboBox bagCmbTypology;
        private System.Windows.Forms.Label bagLblTypelogy;
        private System.Windows.Forms.ComboBox bagCmbSeason;
        private System.Windows.Forms.Label bagLblSeason;
    }
}
