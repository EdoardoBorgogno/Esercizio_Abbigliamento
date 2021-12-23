namespace Es_abbigliamento.UserControlsManageForm
{
    partial class DeleteGarmentControls
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
            this.deleteGarment = new System.Windows.Forms.Label();
            this.deleteGarment_title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.delete_buttonDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.delete_IndumentiPanel = new System.Windows.Forms.Button();
            this.delete_txtId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteGarment
            // 
            this.deleteGarment.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteGarment.Location = new System.Drawing.Point(34, 99);
            this.deleteGarment.Name = "deleteGarment";
            this.deleteGarment.Size = new System.Drawing.Size(320, 67);
            this.deleteGarment.TabIndex = 4;
            this.deleteGarment.Text = "Elimina indumenti dal tuo magazzino utilizzando il loro Id. Ricorda: tutte le eli" +
    "minazioni sono definitive.";
            // 
            // deleteGarment_title
            // 
            this.deleteGarment_title.AutoSize = true;
            this.deleteGarment_title.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteGarment_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(0)))));
            this.deleteGarment_title.Location = new System.Drawing.Point(33, 58);
            this.deleteGarment_title.Name = "deleteGarment_title";
            this.deleteGarment_title.Size = new System.Drawing.Size(399, 27);
            this.deleteGarment_title.TabIndex = 3;
            this.deleteGarment_title.Text = "Rimuovi indumenti dal tuo Magazzino";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Es_abbigliamento.Properties.Resources.design_and_development_process_2040883;
            this.pictureBox1.Location = new System.Drawing.Point(482, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(330, 329);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // delete_buttonDelete
            // 
            this.delete_buttonDelete.BackColor = System.Drawing.Color.White;
            this.delete_buttonDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.delete_buttonDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.delete_buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_buttonDelete.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_buttonDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(0)))));
            this.delete_buttonDelete.Location = new System.Drawing.Point(497, 536);
            this.delete_buttonDelete.Name = "delete_buttonDelete";
            this.delete_buttonDelete.Size = new System.Drawing.Size(102, 34);
            this.delete_buttonDelete.TabIndex = 7;
            this.delete_buttonDelete.Text = "Elimina";
            this.delete_buttonDelete.UseVisualStyleBackColor = false;
            this.delete_buttonDelete.Click += new System.EventHandler(this.delete_buttonDelete_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 67);
            this.label1.TabIndex = 8;
            this.label1.Text = "Per ottenere una panoramica completa dell\'indumento da eliminare vai al pannello " +
    "indumenti.";
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
            this.delete_IndumentiPanel.Location = new System.Drawing.Point(38, 274);
            this.delete_IndumentiPanel.Name = "delete_IndumentiPanel";
            this.delete_IndumentiPanel.Size = new System.Drawing.Size(195, 40);
            this.delete_IndumentiPanel.TabIndex = 9;
            this.delete_IndumentiPanel.Text = "Apri Indumenti";
            this.delete_IndumentiPanel.UseVisualStyleBackColor = false;
            // 
            // delete_txtId
            // 
            this.delete_txtId.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_txtId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.delete_txtId.Location = new System.Drawing.Point(232, 539);
            this.delete_txtId.Name = "delete_txtId";
            this.delete_txtId.Size = new System.Drawing.Size(246, 29);
            this.delete_txtId.TabIndex = 10;
            // 
            // DeleteGarmentControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.delete_txtId);
            this.Controls.Add(this.delete_IndumentiPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delete_buttonDelete);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.deleteGarment);
            this.Controls.Add(this.deleteGarment_title);
            this.Name = "DeleteGarmentControls";
            this.Size = new System.Drawing.Size(846, 642);
            this.Load += new System.EventHandler(this.DeleteGarmentControls_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label deleteGarment;
        private System.Windows.Forms.Label deleteGarment_title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button delete_buttonDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button delete_IndumentiPanel;
        private System.Windows.Forms.TextBox delete_txtId;
    }
}
