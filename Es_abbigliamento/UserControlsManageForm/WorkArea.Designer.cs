namespace Es_abbigliamento
{
    partial class WorkArea
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
            this.workArea_buttonAdd = new System.Windows.Forms.Button();
            this.workArea_buttonDelete = new System.Windows.Forms.Button();
            this.workArea_buttonChanges = new System.Windows.Forms.Button();
            this.workArea_imgBig = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.workArea_imgBig)).BeginInit();
            this.SuspendLayout();
            // 
            // workArea_buttonAdd
            // 
            this.workArea_buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.workArea_buttonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.workArea_buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.workArea_buttonAdd.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workArea_buttonAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.workArea_buttonAdd.Location = new System.Drawing.Point(49, 504);
            this.workArea_buttonAdd.Name = "workArea_buttonAdd";
            this.workArea_buttonAdd.Size = new System.Drawing.Size(199, 43);
            this.workArea_buttonAdd.TabIndex = 1;
            this.workArea_buttonAdd.Text = "Aggiungi ";
            this.workArea_buttonAdd.UseVisualStyleBackColor = true;
            this.workArea_buttonAdd.Click += new System.EventHandler(this.workArea_buttonAdd_Click);
            // 
            // workArea_buttonDelete
            // 
            this.workArea_buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.workArea_buttonDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.workArea_buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.workArea_buttonDelete.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workArea_buttonDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.workArea_buttonDelete.Location = new System.Drawing.Point(332, 504);
            this.workArea_buttonDelete.Name = "workArea_buttonDelete";
            this.workArea_buttonDelete.Size = new System.Drawing.Size(199, 43);
            this.workArea_buttonDelete.TabIndex = 2;
            this.workArea_buttonDelete.Text = "Elimina";
            this.workArea_buttonDelete.UseVisualStyleBackColor = true;
            this.workArea_buttonDelete.Click += new System.EventHandler(this.workArea_buttonDelete_Click);
            // 
            // workArea_buttonChanges
            // 
            this.workArea_buttonChanges.Cursor = System.Windows.Forms.Cursors.Hand;
            this.workArea_buttonChanges.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.workArea_buttonChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.workArea_buttonChanges.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workArea_buttonChanges.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.workArea_buttonChanges.Location = new System.Drawing.Point(602, 504);
            this.workArea_buttonChanges.Name = "workArea_buttonChanges";
            this.workArea_buttonChanges.Size = new System.Drawing.Size(199, 43);
            this.workArea_buttonChanges.TabIndex = 3;
            this.workArea_buttonChanges.Text = "Modifica";
            this.workArea_buttonChanges.UseVisualStyleBackColor = true;
            this.workArea_buttonChanges.Click += new System.EventHandler(this.workArea_buttonChanges_Click);
            // 
            // workArea_imgBig
            // 
            this.workArea_imgBig.Image = global::Es_abbigliamento.Properties.Resources.website_designing_2103528__1_;
            this.workArea_imgBig.Location = new System.Drawing.Point(287, 113);
            this.workArea_imgBig.Name = "workArea_imgBig";
            this.workArea_imgBig.Size = new System.Drawing.Size(284, 286);
            this.workArea_imgBig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.workArea_imgBig.TabIndex = 0;
            this.workArea_imgBig.TabStop = false;
            // 
            // WorkArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.workArea_buttonChanges);
            this.Controls.Add(this.workArea_buttonDelete);
            this.Controls.Add(this.workArea_buttonAdd);
            this.Controls.Add(this.workArea_imgBig);
            this.Name = "WorkArea";
            this.Size = new System.Drawing.Size(846, 642);
            ((System.ComponentModel.ISupportInitialize)(this.workArea_imgBig)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox workArea_imgBig;
        private System.Windows.Forms.Button workArea_buttonAdd;
        private System.Windows.Forms.Button workArea_buttonDelete;
        private System.Windows.Forms.Button workArea_buttonChanges;
    }
}
