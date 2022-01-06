using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es_abbigliamento.UserControlsManageForm
{
    public partial class noGarmentReport : UserControl
    {
        public noGarmentReport()
        {
            InitializeComponent();
        }

        //Open work area
        private void _buttonWorkArea_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            Controls.Add(new WorkArea());
        }
    }
}
