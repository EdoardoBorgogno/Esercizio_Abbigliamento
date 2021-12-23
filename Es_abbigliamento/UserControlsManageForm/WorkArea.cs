using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Es_abbigliamento.UserControlsManageForm;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es_abbigliamento
{
    /// <summary>
    /// Work Area user control.
    /// </summary>
    public partial class WorkArea : UserControl
    {
        //Constructor of WorkArea
        public WorkArea()
        {
            InitializeComponent();
        }


        #region Button Action click

        //
        // All button action click
        //
        
        //open add garment usercontrol
        private void workArea_buttonAdd_Click(object sender, EventArgs e)
        {
            AddGarment addGarmentUserControl = new AddGarment();
            this.Controls.Add(addGarmentUserControl);
            addGarmentUserControl.BringToFront();
        }

        //open delete garment usercontrol
        private void workArea_buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteGarmentControls deleteGarmentControls = new DeleteGarmentControls();
            this.Controls.Add(deleteGarmentControls);
            deleteGarmentControls.BringToFront();
        }

        #endregion

    }
}
