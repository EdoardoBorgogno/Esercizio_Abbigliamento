namespace Es_abbigliamento
{
    partial class AddGarment
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
            this.addGarment_Image = new System.Windows.Forms.PictureBox();
            this.addGarment_title = new System.Windows.Forms.Label();
            this.addGarment_txt1 = new System.Windows.Forms.Label();
            this.addGarment_txt2 = new System.Windows.Forms.Label();
            this.addGarment_title2 = new System.Windows.Forms.Label();
            this.addGarment_combo = new System.Windows.Forms.ComboBox();
            this.addGarment_buttonCreate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.addGarment_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // addGarment_Image
            // 
            this.addGarment_Image.Image = global::Es_abbigliamento.Properties.Resources.success_2103905;
            this.addGarment_Image.Location = new System.Drawing.Point(381, 25);
            this.addGarment_Image.Name = "addGarment_Image";
            this.addGarment_Image.Size = new System.Drawing.Size(462, 347);
            this.addGarment_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addGarment_Image.TabIndex = 0;
            this.addGarment_Image.TabStop = false;
            // 
            // addGarment_title
            // 
            this.addGarment_title.AutoSize = true;
            this.addGarment_title.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGarment_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(0)))));
            this.addGarment_title.Location = new System.Drawing.Point(33, 72);
            this.addGarment_title.Name = "addGarment_title";
            this.addGarment_title.Size = new System.Drawing.Size(414, 27);
            this.addGarment_title.TabIndex = 1;
            this.addGarment_title.Text = "Aggiungi nuovi vestiti al tuo magazzino";
            // 
            // addGarment_txt1
            // 
            this.addGarment_txt1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGarment_txt1.Location = new System.Drawing.Point(34, 113);
            this.addGarment_txt1.Name = "addGarment_txt1";
            this.addGarment_txt1.Size = new System.Drawing.Size(320, 67);
            this.addGarment_txt1.TabIndex = 2;
            this.addGarment_txt1.Text = "Inserisci nuovissimi indumenti al tuo magazzino,  gestisci decine di scelta diver" +
    "se per creare il tuo stock perfetto.";
            // 
            // addGarment_txt2
            // 
            this.addGarment_txt2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGarment_txt2.Location = new System.Drawing.Point(34, 369);
            this.addGarment_txt2.Name = "addGarment_txt2";
            this.addGarment_txt2.Size = new System.Drawing.Size(320, 67);
            this.addGarment_txt2.TabIndex = 3;
            this.addGarment_txt2.Text = "Inserisci nel tuo magazzino 5 tipologie differenti di vestiti, scegli tra giacche" +
    ", scarpe, borse, pantaloni e t-shirt.";
            // 
            // addGarment_title2
            // 
            this.addGarment_title2.AutoSize = true;
            this.addGarment_title2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGarment_title2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(0)))));
            this.addGarment_title2.Location = new System.Drawing.Point(33, 332);
            this.addGarment_title2.Name = "addGarment_title2";
            this.addGarment_title2.Size = new System.Drawing.Size(297, 27);
            this.addGarment_title2.TabIndex = 4;
            this.addGarment_title2.Text = "Scegli tra 5 tipi di indumenti";
            // 
            // addGarment_combo
            // 
            this.addGarment_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addGarment_combo.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGarment_combo.FormattingEnabled = true;
            this.addGarment_combo.Items.AddRange(new object[] {
            "T-shirt",
            "Giacche",
            "Pantaloni",
            "Scarpe",
            "Borse"});
            this.addGarment_combo.Location = new System.Drawing.Point(251, 514);
            this.addGarment_combo.Name = "addGarment_combo";
            this.addGarment_combo.Size = new System.Drawing.Size(225, 28);
            this.addGarment_combo.TabIndex = 5;
            // 
            // addGarment_buttonCreate
            // 
            this.addGarment_buttonCreate.BackColor = System.Drawing.Color.White;
            this.addGarment_buttonCreate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.addGarment_buttonCreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.addGarment_buttonCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addGarment_buttonCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(0)))));
            this.addGarment_buttonCreate.Location = new System.Drawing.Point(490, 514);
            this.addGarment_buttonCreate.Name = "addGarment_buttonCreate";
            this.addGarment_buttonCreate.Size = new System.Drawing.Size(102, 28);
            this.addGarment_buttonCreate.TabIndex = 6;
            this.addGarment_buttonCreate.Text = "Inserisci";
            this.addGarment_buttonCreate.UseVisualStyleBackColor = false;
            this.addGarment_buttonCreate.Click += new System.EventHandler(this.addGarment_buttonCreate_Click);
            // 
            // AddGarment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.addGarment_buttonCreate);
            this.Controls.Add(this.addGarment_combo);
            this.Controls.Add(this.addGarment_title2);
            this.Controls.Add(this.addGarment_txt2);
            this.Controls.Add(this.addGarment_txt1);
            this.Controls.Add(this.addGarment_title);
            this.Controls.Add(this.addGarment_Image);
            this.Name = "AddGarment";
            this.Size = new System.Drawing.Size(846, 642);
            ((System.ComponentModel.ISupportInitialize)(this.addGarment_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox addGarment_Image;
        private System.Windows.Forms.Label addGarment_title;
        private System.Windows.Forms.Label addGarment_txt1;
        private System.Windows.Forms.Label addGarment_txt2;
        private System.Windows.Forms.Label addGarment_title2;
        private System.Windows.Forms.ComboBox addGarment_combo;
        private System.Windows.Forms.Button addGarment_buttonCreate;
    }
}
