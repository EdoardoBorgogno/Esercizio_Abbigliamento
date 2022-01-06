namespace Es_abbigliamento.UserControlsManageForm
{
    partial class Report
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
            this.garmentPie = new LiveCharts.WinForms.PieChart();
            this.garmentPie_panel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numberGarment_panel = new System.Windows.Forms.Panel();
            this.numberGarment_pic = new System.Windows.Forms.PictureBox();
            this.numberGarment_lblDescription = new System.Windows.Forms.Label();
            this.numberGarment_lblNum = new System.Windows.Forms.Label();
            this.mediumPrice_panel = new System.Windows.Forms.Panel();
            this.mediumPrice_pic = new System.Windows.Forms.PictureBox();
            this.mediumPrice_lblDescription = new System.Windows.Forms.Label();
            this.mediumPrice_lblNum = new System.Windows.Forms.Label();
            this.bestBrand_panel = new System.Windows.Forms.Panel();
            this.bestBrand_pic = new System.Windows.Forms.PictureBox();
            this.bestBrand_lblDescription = new System.Windows.Forms.Label();
            this.bestBrand_lblNum = new System.Windows.Forms.Label();
            this.solidGauge = new LiveCharts.WinForms.SolidGauge();
            this.garmentPie_panelSolid = new System.Windows.Forms.Panel();
            this.cmbTypeSolidGauge = new System.Windows.Forms.ComboBox();
            this.lblDescriptionSolidGauge = new System.Windows.Forms.Label();
            this.lblTitleSolidGaugePanel = new System.Windows.Forms.Label();
            this.garmentPie_panel.SuspendLayout();
            this.numberGarment_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberGarment_pic)).BeginInit();
            this.mediumPrice_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mediumPrice_pic)).BeginInit();
            this.bestBrand_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bestBrand_pic)).BeginInit();
            this.garmentPie_panelSolid.SuspendLayout();
            this.SuspendLayout();
            // 
            // garmentPie
            // 
            this.garmentPie.BackColor = System.Drawing.Color.Transparent;
            this.garmentPie.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.garmentPie.ForeColor = System.Drawing.Color.Transparent;
            this.garmentPie.Location = new System.Drawing.Point(8, 6);
            this.garmentPie.Name = "garmentPie";
            this.garmentPie.Size = new System.Drawing.Size(447, 237);
            this.garmentPie.TabIndex = 0;
            this.garmentPie.Text = "garmentPie";
            this.garmentPie.Visible = false;
            // 
            // garmentPie_panel
            // 
            this.garmentPie_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.garmentPie_panel.Controls.Add(this.panel1);
            this.garmentPie_panel.Controls.Add(this.garmentPie);
            this.garmentPie_panel.Location = new System.Drawing.Point(14, 184);
            this.garmentPie_panel.Name = "garmentPie_panel";
            this.garmentPie_panel.Size = new System.Drawing.Size(458, 249);
            this.garmentPie_panel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.panel1.Location = new System.Drawing.Point(488, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 455);
            this.panel1.TabIndex = 2;
            // 
            // numberGarment_panel
            // 
            this.numberGarment_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.numberGarment_panel.Controls.Add(this.numberGarment_pic);
            this.numberGarment_panel.Controls.Add(this.numberGarment_lblDescription);
            this.numberGarment_panel.Controls.Add(this.numberGarment_lblNum);
            this.numberGarment_panel.Location = new System.Drawing.Point(23, 34);
            this.numberGarment_panel.Name = "numberGarment_panel";
            this.numberGarment_panel.Size = new System.Drawing.Size(260, 108);
            this.numberGarment_panel.TabIndex = 2;
            // 
            // numberGarment_pic
            // 
            this.numberGarment_pic.Image = global::Es_abbigliamento.Properties.Resources.garment__1_;
            this.numberGarment_pic.Location = new System.Drawing.Point(172, 34);
            this.numberGarment_pic.Name = "numberGarment_pic";
            this.numberGarment_pic.Size = new System.Drawing.Size(52, 52);
            this.numberGarment_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.numberGarment_pic.TabIndex = 4;
            this.numberGarment_pic.TabStop = false;
            // 
            // numberGarment_lblDescription
            // 
            this.numberGarment_lblDescription.AutoSize = true;
            this.numberGarment_lblDescription.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberGarment_lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.numberGarment_lblDescription.Location = new System.Drawing.Point(11, 67);
            this.numberGarment_lblDescription.Name = "numberGarment_lblDescription";
            this.numberGarment_lblDescription.Size = new System.Drawing.Size(72, 19);
            this.numberGarment_lblDescription.TabIndex = 1;
            this.numberGarment_lblDescription.Text = "Indumenti";
            // 
            // numberGarment_lblNum
            // 
            this.numberGarment_lblNum.AutoSize = true;
            this.numberGarment_lblNum.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberGarment_lblNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(0)))));
            this.numberGarment_lblNum.Location = new System.Drawing.Point(10, 42);
            this.numberGarment_lblNum.Name = "numberGarment_lblNum";
            this.numberGarment_lblNum.Size = new System.Drawing.Size(60, 25);
            this.numberGarment_lblNum.TabIndex = 0;
            this.numberGarment_lblNum.Text = "NUM";
            // 
            // mediumPrice_panel
            // 
            this.mediumPrice_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.mediumPrice_panel.Controls.Add(this.mediumPrice_pic);
            this.mediumPrice_panel.Controls.Add(this.mediumPrice_lblDescription);
            this.mediumPrice_panel.Controls.Add(this.mediumPrice_lblNum);
            this.mediumPrice_panel.Location = new System.Drawing.Point(303, 34);
            this.mediumPrice_panel.Name = "mediumPrice_panel";
            this.mediumPrice_panel.Size = new System.Drawing.Size(252, 108);
            this.mediumPrice_panel.TabIndex = 3;
            // 
            // mediumPrice_pic
            // 
            this.mediumPrice_pic.Image = global::Es_abbigliamento.Properties.Resources.price;
            this.mediumPrice_pic.Location = new System.Drawing.Point(170, 34);
            this.mediumPrice_pic.Name = "mediumPrice_pic";
            this.mediumPrice_pic.Size = new System.Drawing.Size(52, 52);
            this.mediumPrice_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mediumPrice_pic.TabIndex = 2;
            this.mediumPrice_pic.TabStop = false;
            // 
            // mediumPrice_lblDescription
            // 
            this.mediumPrice_lblDescription.AutoSize = true;
            this.mediumPrice_lblDescription.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediumPrice_lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.mediumPrice_lblDescription.Location = new System.Drawing.Point(18, 67);
            this.mediumPrice_lblDescription.Name = "mediumPrice_lblDescription";
            this.mediumPrice_lblDescription.Size = new System.Drawing.Size(91, 19);
            this.mediumPrice_lblDescription.TabIndex = 3;
            this.mediumPrice_lblDescription.Text = "Prezzo medio";
            // 
            // mediumPrice_lblNum
            // 
            this.mediumPrice_lblNum.AutoSize = true;
            this.mediumPrice_lblNum.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediumPrice_lblNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(0)))));
            this.mediumPrice_lblNum.Location = new System.Drawing.Point(17, 42);
            this.mediumPrice_lblNum.Name = "mediumPrice_lblNum";
            this.mediumPrice_lblNum.Size = new System.Drawing.Size(60, 25);
            this.mediumPrice_lblNum.TabIndex = 2;
            this.mediumPrice_lblNum.Text = "NUM";
            // 
            // bestBrand_panel
            // 
            this.bestBrand_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.bestBrand_panel.Controls.Add(this.bestBrand_pic);
            this.bestBrand_panel.Controls.Add(this.bestBrand_lblDescription);
            this.bestBrand_panel.Controls.Add(this.bestBrand_lblNum);
            this.bestBrand_panel.Location = new System.Drawing.Point(572, 34);
            this.bestBrand_panel.Name = "bestBrand_panel";
            this.bestBrand_panel.Size = new System.Drawing.Size(250, 108);
            this.bestBrand_panel.TabIndex = 3;
            // 
            // bestBrand_pic
            // 
            this.bestBrand_pic.Image = global::Es_abbigliamento.Properties.Resources.logo_adidas;
            this.bestBrand_pic.Location = new System.Drawing.Point(178, 34);
            this.bestBrand_pic.Name = "bestBrand_pic";
            this.bestBrand_pic.Size = new System.Drawing.Size(52, 52);
            this.bestBrand_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bestBrand_pic.TabIndex = 4;
            this.bestBrand_pic.TabStop = false;
            // 
            // bestBrand_lblDescription
            // 
            this.bestBrand_lblDescription.AutoSize = true;
            this.bestBrand_lblDescription.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bestBrand_lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.bestBrand_lblDescription.Location = new System.Drawing.Point(14, 67);
            this.bestBrand_lblDescription.Name = "bestBrand_lblDescription";
            this.bestBrand_lblDescription.Size = new System.Drawing.Size(125, 19);
            this.bestBrand_lblDescription.TabIndex = 5;
            this.bestBrand_lblDescription.Text = "Brand più presente";
            // 
            // bestBrand_lblNum
            // 
            this.bestBrand_lblNum.AutoSize = true;
            this.bestBrand_lblNum.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bestBrand_lblNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(0)))));
            this.bestBrand_lblNum.Location = new System.Drawing.Point(13, 42);
            this.bestBrand_lblNum.Name = "bestBrand_lblNum";
            this.bestBrand_lblNum.Size = new System.Drawing.Size(60, 25);
            this.bestBrand_lblNum.TabIndex = 4;
            this.bestBrand_lblNum.Text = "NUM";
            // 
            // solidGauge
            // 
            this.solidGauge.Location = new System.Drawing.Point(35, 22);
            this.solidGauge.Name = "solidGauge";
            this.solidGauge.Size = new System.Drawing.Size(274, 161);
            this.solidGauge.TabIndex = 4;
            this.solidGauge.Visible = false;
            // 
            // garmentPie_panelSolid
            // 
            this.garmentPie_panelSolid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.garmentPie_panelSolid.Controls.Add(this.cmbTypeSolidGauge);
            this.garmentPie_panelSolid.Controls.Add(this.lblDescriptionSolidGauge);
            this.garmentPie_panelSolid.Controls.Add(this.lblTitleSolidGaugePanel);
            this.garmentPie_panelSolid.Controls.Add(this.solidGauge);
            this.garmentPie_panelSolid.Location = new System.Drawing.Point(493, 184);
            this.garmentPie_panelSolid.Name = "garmentPie_panelSolid";
            this.garmentPie_panelSolid.Size = new System.Drawing.Size(339, 434);
            this.garmentPie_panelSolid.TabIndex = 5;
            // 
            // cmbTypeSolidGauge
            // 
            this.cmbTypeSolidGauge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.cmbTypeSolidGauge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypeSolidGauge.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTypeSolidGauge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.cmbTypeSolidGauge.FormattingEnabled = true;
            this.cmbTypeSolidGauge.Items.AddRange(new object[] {
            "Bag",
            "Jackets",
            "Shoe",
            "Sweater",
            "Trousers"});
            this.cmbTypeSolidGauge.Location = new System.Drawing.Point(68, 333);
            this.cmbTypeSolidGauge.Name = "cmbTypeSolidGauge";
            this.cmbTypeSolidGauge.Size = new System.Drawing.Size(208, 31);
            this.cmbTypeSolidGauge.TabIndex = 7;
            this.cmbTypeSolidGauge.SelectedIndexChanged += new System.EventHandler(this.cmbTypeSolidGauge_SelectedIndexChanged);
            // 
            // lblDescriptionSolidGauge
            // 
            this.lblDescriptionSolidGauge.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescriptionSolidGauge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.lblDescriptionSolidGauge.Location = new System.Drawing.Point(9, 259);
            this.lblDescriptionSolidGauge.Name = "lblDescriptionSolidGauge";
            this.lblDescriptionSolidGauge.Size = new System.Drawing.Size(322, 58);
            this.lblDescriptionSolidGauge.TabIndex = 6;
            this.lblDescriptionSolidGauge.Text = "Visualizza il prezzo medio per ogni tipologia di indumenti.";
            this.lblDescriptionSolidGauge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitleSolidGaugePanel
            // 
            this.lblTitleSolidGaugePanel.AutoSize = true;
            this.lblTitleSolidGaugePanel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleSolidGaugePanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.lblTitleSolidGaugePanel.Location = new System.Drawing.Point(63, 224);
            this.lblTitleSolidGaugePanel.Name = "lblTitleSolidGaugePanel";
            this.lblTitleSolidGaugePanel.Size = new System.Drawing.Size(214, 25);
            this.lblTitleSolidGaugePanel.TabIndex = 5;
            this.lblTitleSolidGaugePanel.Text = "Prezzo medio per Tipo";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.garmentPie_panelSolid);
            this.Controls.Add(this.bestBrand_panel);
            this.Controls.Add(this.mediumPrice_panel);
            this.Controls.Add(this.numberGarment_panel);
            this.Controls.Add(this.garmentPie_panel);
            this.Name = "Report";
            this.Size = new System.Drawing.Size(846, 642);
            this.Load += new System.EventHandler(this.Report_Load);
            this.garmentPie_panel.ResumeLayout(false);
            this.numberGarment_panel.ResumeLayout(false);
            this.numberGarment_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberGarment_pic)).EndInit();
            this.mediumPrice_panel.ResumeLayout(false);
            this.mediumPrice_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mediumPrice_pic)).EndInit();
            this.bestBrand_panel.ResumeLayout(false);
            this.bestBrand_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bestBrand_pic)).EndInit();
            this.garmentPie_panelSolid.ResumeLayout(false);
            this.garmentPie_panelSolid.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private LiveCharts.WinForms.PieChart garmentPie;
        private System.Windows.Forms.Panel garmentPie_panel;
        private System.Windows.Forms.Panel numberGarment_panel;
        private System.Windows.Forms.Panel mediumPrice_panel;
        private System.Windows.Forms.Panel bestBrand_panel;
        private System.Windows.Forms.Label numberGarment_lblDescription;
        private System.Windows.Forms.Label numberGarment_lblNum;
        private System.Windows.Forms.Label mediumPrice_lblDescription;
        private System.Windows.Forms.Label mediumPrice_lblNum;
        private System.Windows.Forms.Label bestBrand_lblDescription;
        private System.Windows.Forms.Label bestBrand_lblNum;
        private System.Windows.Forms.PictureBox mediumPrice_pic;
        private System.Windows.Forms.PictureBox numberGarment_pic;
        private System.Windows.Forms.PictureBox bestBrand_pic;
        private LiveCharts.WinForms.SolidGauge solidGauge;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel garmentPie_panelSolid;
        private System.Windows.Forms.Label lblTitleSolidGaugePanel;
        private System.Windows.Forms.Label lblDescriptionSolidGauge;
        private System.Windows.Forms.ComboBox cmbTypeSolidGauge;
    }
}
