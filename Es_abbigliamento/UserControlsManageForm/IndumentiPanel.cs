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
    /// <summary>
    /// IndumentiPanel => panel with info about function of IDUMENTI.
    /// </summary>
    public partial class IndumentiPanel : UserControl
    {

        //Constructor
        public IndumentiPanel()
        {
            InitializeComponent();
        }

        //
        // Button function
        //

        //Button open Indumenti
        private void panelIndumenti_buttonOpen_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(new IndumentiView());
        }

        //Button work area
        private void panelIndumenti_buttonWorkArea_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(new WorkArea());
        }
    }
}
