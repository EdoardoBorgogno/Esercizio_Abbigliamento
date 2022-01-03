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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // garmentPie
            // 
            this.garmentPie.BackColor = System.Drawing.Color.Transparent;
            this.garmentPie.BackColorTransparent = true;
            this.garmentPie.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.garmentPie.ForeColor = System.Drawing.Color.Transparent;
            this.garmentPie.Location = new System.Drawing.Point(3, 0);
            this.garmentPie.Name = "garmentPie";
            this.garmentPie.Size = new System.Drawing.Size(319, 237);
            this.garmentPie.TabIndex = 0;
            this.garmentPie.Text = "garmentPie";
            this.garmentPie.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.garmentPie);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 246);
            this.panel1.TabIndex = 1;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "Report";
            this.Size = new System.Drawing.Size(846, 642);
            this.Load += new System.EventHandler(this.Report_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private LiveCharts.WinForms.PieChart garmentPie;
        private System.Windows.Forms.Panel panel1;
    }
}
