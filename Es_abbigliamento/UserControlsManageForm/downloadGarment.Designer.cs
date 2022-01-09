namespace Es_abbigliamento.UserControlsManageForm
{
    partial class downloadGarment
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblText1 = new System.Windows.Forms.Label();
            this.id__ = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.buttonDownload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(59, 88);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(248, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Download Indumenti";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Es_abbigliamento.Properties.Resources.website_designing_2103528__1_;
            this.pictureBox1.Location = new System.Drawing.Point(436, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(312, 293);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblText1
            // 
            this.lblText1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText1.Location = new System.Drawing.Point(60, 133);
            this.lblText1.Name = "lblText1";
            this.lblText1.Size = new System.Drawing.Size(320, 67);
            this.lblText1.TabIndex = 4;
            this.lblText1.Text = "Scarica i dati di un indumento in formato XML. Inserisci l\'id indumento per scari" +
    "care i dati desiderati.";
            // 
            // id__
            // 
            this.id__.AutoSize = true;
            this.id__.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id__.Location = new System.Drawing.Point(232, 508);
            this.id__.Name = "id__";
            this.id__.Size = new System.Drawing.Size(20, 19);
            this.id__.TabIndex = 21;
            this.id__.Text = "id";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.txtId.Location = new System.Drawing.Point(236, 530);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(246, 29);
            this.txtId.TabIndex = 20;
            // 
            // buttonDownload
            // 
            this.buttonDownload.BackColor = System.Drawing.Color.White;
            this.buttonDownload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonDownload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDownload.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDownload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(0)))));
            this.buttonDownload.Location = new System.Drawing.Point(501, 527);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(148, 34);
            this.buttonDownload.TabIndex = 19;
            this.buttonDownload.Text = "Download";
            this.buttonDownload.UseVisualStyleBackColor = false;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // downloadGarment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.id__);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.buttonDownload);
            this.Controls.Add(this.lblText1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitle);
            this.Name = "downloadGarment";
            this.Size = new System.Drawing.Size(846, 642);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblText1;
        private System.Windows.Forms.Label id__;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button buttonDownload;
    }
}
