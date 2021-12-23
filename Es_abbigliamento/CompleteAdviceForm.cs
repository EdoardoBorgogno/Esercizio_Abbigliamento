using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es_abbigliamento
{
    /// <summary>
    /// Complete advice form => good advice for user.
    /// </summary>
    public partial class CompleteAdviceForm : BaseInfoForm
    {
        //Constructor
        public CompleteAdviceForm(string titleParam, string txtParam)
        {
            InitializeComponent();

            titleTextBase.Text = titleParam;
            titleTextBase.ForeColor = Color.FromArgb(53, 255, 0);
            titleTextBase.Image = Properties.Resources.ok;

            txtBase.Text = txtParam;
        }
    }
}
