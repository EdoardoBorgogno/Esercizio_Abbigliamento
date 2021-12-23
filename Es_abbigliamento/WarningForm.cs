using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Es_abbigliamento
{
    public partial class WarningForm : Es_abbigliamento.BaseInfoForm
    {
        public WarningForm(string titleParam, string txtParam)
        {
            InitializeComponent();

            titleTextBase.Text = titleParam;
            titleTextBase.Image = Properties.Resources.warning;
            titleTextBase.ForeColor = Color.FromArgb(255, 209, 0);

            txtBase.Text = txtParam;
        }
    }
}
