namespace Es_abbigliamento.UserControlsManageForm
{
    partial class InsertComplete
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
            this.insertComplete_image = new System.Windows.Forms.PictureBox();
            this.insertComplete_lblTitle = new System.Windows.Forms.Label();
            this.insertComplete_buttonHome = new System.Windows.Forms.Button();
            this.insertComplete_buttonWorkArea = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.insertComplete_image)).BeginInit();
            this.SuspendLayout();
            // 
            // insertComplete_image
            // 
            this.insertComplete_image.Image = global::Es_abbigliamento.Properties.Resources.downloading_data_4085810;
            this.insertComplete_image.Location = new System.Drawing.Point(264, 63);
            this.insertComplete_image.Name = "insertComplete_image";
            this.insertComplete_image.Size = new System.Drawing.Size(320, 320);
            this.insertComplete_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.insertComplete_image.TabIndex = 0;
            this.insertComplete_image.TabStop = false;
            // 
            // insertComplete_lblTitle
            // 
            this.insertComplete_lblTitle.AutoSize = true;
            this.insertComplete_lblTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertComplete_lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(0)))));
            this.insertComplete_lblTitle.Location = new System.Drawing.Point(212, 410);
            this.insertComplete_lblTitle.Name = "insertComplete_lblTitle";
            this.insertComplete_lblTitle.Size = new System.Drawing.Size(424, 31);
            this.insertComplete_lblTitle.TabIndex = 1;
            this.insertComplete_lblTitle.Text = "Inserimento Eseguito con successo!";
            // 
            // insertComplete_buttonHome
            // 
            this.insertComplete_buttonHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insertComplete_buttonHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.insertComplete_buttonHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.insertComplete_buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertComplete_buttonHome.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertComplete_buttonHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.insertComplete_buttonHome.Location = new System.Drawing.Point(161, 511);
            this.insertComplete_buttonHome.Name = "insertComplete_buttonHome";
            this.insertComplete_buttonHome.Size = new System.Drawing.Size(209, 46);
            this.insertComplete_buttonHome.TabIndex = 2;
            this.insertComplete_buttonHome.Text = "Home";
            this.insertComplete_buttonHome.UseVisualStyleBackColor = true;
            this.insertComplete_buttonHome.Click += new System.EventHandler(this.insertComplete_buttonHome_Click);
            // 
            // insertComplete_buttonWorkArea
            // 
            this.insertComplete_buttonWorkArea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insertComplete_buttonWorkArea.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.insertComplete_buttonWorkArea.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.insertComplete_buttonWorkArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertComplete_buttonWorkArea.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertComplete_buttonWorkArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.insertComplete_buttonWorkArea.Location = new System.Drawing.Point(495, 511);
            this.insertComplete_buttonWorkArea.Name = "insertComplete_buttonWorkArea";
            this.insertComplete_buttonWorkArea.Size = new System.Drawing.Size(209, 46);
            this.insertComplete_buttonWorkArea.TabIndex = 3;
            this.insertComplete_buttonWorkArea.Text = "Work Area";
            this.insertComplete_buttonWorkArea.UseVisualStyleBackColor = true;
            this.insertComplete_buttonWorkArea.Click += new System.EventHandler(this.insertComplete_buttonWorkArea_Click);
            // 
            // InsertComplete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.insertComplete_buttonWorkArea);
            this.Controls.Add(this.insertComplete_buttonHome);
            this.Controls.Add(this.insertComplete_lblTitle);
            this.Controls.Add(this.insertComplete_image);
            this.Name = "InsertComplete";
            this.Size = new System.Drawing.Size(846, 642);
            ((System.ComponentModel.ISupportInitialize)(this.insertComplete_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox insertComplete_image;
        private System.Windows.Forms.Label insertComplete_lblTitle;
        private System.Windows.Forms.Button insertComplete_buttonHome;
        private System.Windows.Forms.Button insertComplete_buttonWorkArea;
    }
}
