namespace Es_abbigliamento.UserControlsManageForm
{
    partial class userControlModGarment
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
            this.modGarment_title = new System.Windows.Forms.Label();
            this.modGarment_txt1 = new System.Windows.Forms.Label();
            this.mod_txtId = new System.Windows.Forms.TextBox();
            this.mod_buttonMod = new System.Windows.Forms.Button();
            this.modGarment_Image = new System.Windows.Forms.PictureBox();
            this.delete_IndumentiPanel = new System.Windows.Forms.Button();
            this.modGarment_txt2 = new System.Windows.Forms.Label();
            this.id__ = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.modGarment_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // modGarment_title
            // 
            this.modGarment_title.AutoSize = true;
            this.modGarment_title.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modGarment_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(0)))));
            this.modGarment_title.Location = new System.Drawing.Point(29, 44);
            this.modGarment_title.Name = "modGarment_title";
            this.modGarment_title.Size = new System.Drawing.Size(403, 27);
            this.modGarment_title.TabIndex = 2;
            this.modGarment_title.Text = "Modifica indumenti nel tuo magazzino";
            // 
            // modGarment_txt1
            // 
            this.modGarment_txt1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modGarment_txt1.Location = new System.Drawing.Point(30, 80);
            this.modGarment_txt1.Name = "modGarment_txt1";
            this.modGarment_txt1.Size = new System.Drawing.Size(320, 67);
            this.modGarment_txt1.TabIndex = 3;
            this.modGarment_txt1.Text = "Modifica indumenti presenti nel tuo magazzino, ridefinisci le caratteristiche dei" +
    " tuoi indumenti preferiti.";
            // 
            // mod_txtId
            // 
            this.mod_txtId.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mod_txtId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.mod_txtId.Location = new System.Drawing.Point(260, 555);
            this.mod_txtId.Name = "mod_txtId";
            this.mod_txtId.Size = new System.Drawing.Size(246, 29);
            this.mod_txtId.TabIndex = 12;
            // 
            // mod_buttonMod
            // 
            this.mod_buttonMod.BackColor = System.Drawing.Color.White;
            this.mod_buttonMod.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.mod_buttonMod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.mod_buttonMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mod_buttonMod.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mod_buttonMod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(0)))));
            this.mod_buttonMod.Location = new System.Drawing.Point(525, 552);
            this.mod_buttonMod.Name = "mod_buttonMod";
            this.mod_buttonMod.Size = new System.Drawing.Size(121, 34);
            this.mod_buttonMod.TabIndex = 11;
            this.mod_buttonMod.Text = "Modifica";
            this.mod_buttonMod.UseVisualStyleBackColor = false;
            this.mod_buttonMod.Click += new System.EventHandler(this.mod_buttonMod_Click);
            // 
            // modGarment_Image
            // 
            this.modGarment_Image.Image = global::Es_abbigliamento.Properties.Resources.design_and_development_process_2040883;
            this.modGarment_Image.Location = new System.Drawing.Point(412, 101);
            this.modGarment_Image.Name = "modGarment_Image";
            this.modGarment_Image.Size = new System.Drawing.Size(431, 318);
            this.modGarment_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.modGarment_Image.TabIndex = 13;
            this.modGarment_Image.TabStop = false;
            // 
            // delete_IndumentiPanel
            // 
            this.delete_IndumentiPanel.BackColor = System.Drawing.Color.White;
            this.delete_IndumentiPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_IndumentiPanel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.delete_IndumentiPanel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.delete_IndumentiPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_IndumentiPanel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_IndumentiPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.delete_IndumentiPanel.Location = new System.Drawing.Point(34, 254);
            this.delete_IndumentiPanel.Name = "delete_IndumentiPanel";
            this.delete_IndumentiPanel.Size = new System.Drawing.Size(195, 40);
            this.delete_IndumentiPanel.TabIndex = 15;
            this.delete_IndumentiPanel.Text = "Apri Indumenti";
            this.delete_IndumentiPanel.UseVisualStyleBackColor = false;
            this.delete_IndumentiPanel.Click += new System.EventHandler(this.delete_IndumentiPanel_Click);
            // 
            // modGarment_txt2
            // 
            this.modGarment_txt2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modGarment_txt2.Location = new System.Drawing.Point(30, 178);
            this.modGarment_txt2.Name = "modGarment_txt2";
            this.modGarment_txt2.Size = new System.Drawing.Size(320, 67);
            this.modGarment_txt2.TabIndex = 14;
            this.modGarment_txt2.Text = "Per ottenere una panoramica completa dell\'indumento da modificare vai al pannello" +
    " indumenti.";
            // 
            // id__
            // 
            this.id__.AutoSize = true;
            this.id__.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id__.Location = new System.Drawing.Point(257, 531);
            this.id__.Name = "id__";
            this.id__.Size = new System.Drawing.Size(20, 19);
            this.id__.TabIndex = 16;
            this.id__.Text = "id";
            // 
            // userControlModGarment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.id__);
            this.Controls.Add(this.delete_IndumentiPanel);
            this.Controls.Add(this.modGarment_txt2);
            this.Controls.Add(this.modGarment_Image);
            this.Controls.Add(this.mod_txtId);
            this.Controls.Add(this.mod_buttonMod);
            this.Controls.Add(this.modGarment_txt1);
            this.Controls.Add(this.modGarment_title);
            this.Name = "userControlModGarment";
            this.Size = new System.Drawing.Size(846, 642);
            ((System.ComponentModel.ISupportInitialize)(this.modGarment_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label modGarment_title;
        private System.Windows.Forms.Label modGarment_txt1;
        private System.Windows.Forms.TextBox mod_txtId;
        private System.Windows.Forms.Button mod_buttonMod;
        private System.Windows.Forms.PictureBox modGarment_Image;
        private System.Windows.Forms.Button delete_IndumentiPanel;
        private System.Windows.Forms.Label modGarment_txt2;
        private System.Windows.Forms.Label id__;
    }
}
