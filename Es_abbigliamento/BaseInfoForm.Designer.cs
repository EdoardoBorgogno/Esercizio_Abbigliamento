namespace Es_abbigliamento
{
    partial class BaseInfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.warningForm_Button = new System.Windows.Forms.Button();
            this.txt = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // warningForm_Button
            // 
            this.warningForm_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.warningForm_Button.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningForm_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.warningForm_Button.Location = new System.Drawing.Point(165, 288);
            this.warningForm_Button.Name = "warningForm_Button";
            this.warningForm_Button.Size = new System.Drawing.Size(220, 40);
            this.warningForm_Button.TabIndex = 3;
            this.warningForm_Button.Text = "Ok";
            this.warningForm_Button.UseVisualStyleBackColor = true;
            this.warningForm_Button.Click += new System.EventHandler(this.warningForm_Button_Click);
            // 
            // txt
            // 
            this.txt.BackColor = System.Drawing.Color.Transparent;
            this.txt.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.Location = new System.Drawing.Point(49, 104);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(443, 128);
            this.txt.TabIndex = 4;
            this.txt.Text = "txt";
            this.txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.title.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.title.Location = new System.Drawing.Point(121, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(298, 58);
            this.title.TabIndex = 5;
            this.title.Text = "ErrorTitle";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BaseInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(522, 363);
            this.ControlBox = false;
            this.Controls.Add(this.title);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.warningForm_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximumSize = new System.Drawing.Size(540, 410);
            this.MinimumSize = new System.Drawing.Size(540, 410);
            this.Name = "BaseInfoForm";
            this.Text = "Messaggio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button warningForm_Button;
        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.Label title;
    }
}