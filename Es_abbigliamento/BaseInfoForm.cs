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
    /// Base Info form ==> base form for advice user form
    /// </summary>
    public partial class BaseInfoForm : Form
    {
        //Properties
        public Label titleTextBase
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        public Label txtBase
        {
            get
            {
                return txt;
            }
            set
            {
                txt = value;
            }
        }
        
        //Constuctor
        public BaseInfoForm()
        {
            InitializeComponent();
        }

        //On click Button
        private void warningForm_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
