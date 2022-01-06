namespace Es_abbigliamento.UserControlsManageForm
{
    partial class noGarmentReport
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this._buttonWorkArea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.lblTitle.Location = new System.Drawing.Point(171, 160);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(493, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Nessun indumento nel magazzino";
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.lblDescription.Location = new System.Drawing.Point(244, 218);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(352, 58);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Per visualizzare questa schermata aggiungi indumenti nel tuo stock.";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _buttonWorkArea
            // 
            this._buttonWorkArea.Cursor = System.Windows.Forms.Cursors.Hand;
            this._buttonWorkArea.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._buttonWorkArea.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._buttonWorkArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._buttonWorkArea.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._buttonWorkArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this._buttonWorkArea.Location = new System.Drawing.Point(305, 299);
            this._buttonWorkArea.Name = "_buttonWorkArea";
            this._buttonWorkArea.Size = new System.Drawing.Size(231, 44);
            this._buttonWorkArea.TabIndex = 8;
            this._buttonWorkArea.Text = "Vai a work area";
            this._buttonWorkArea.UseVisualStyleBackColor = true;
            this._buttonWorkArea.Click += new System.EventHandler(this._buttonWorkArea_Click);
            // 
            // noGarmentReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this._buttonWorkArea);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTitle);
            this.Name = "noGarmentReport";
            this.Size = new System.Drawing.Size(846, 642);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button _buttonWorkArea;
    }
}
