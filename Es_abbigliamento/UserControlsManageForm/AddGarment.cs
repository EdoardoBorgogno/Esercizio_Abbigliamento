using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Es_abbigliamento.UserControlsGarment;

namespace Es_abbigliamento
{
    /// <summary>
    /// Add Garment user control.
    /// </summary>
    public partial class AddGarment : UserControl
    {
        //Constructor
        public AddGarment()
        {
            InitializeComponent();
        }

        //Manage user add choice. 
        private void addGarment_buttonCreate_Click(object sender, EventArgs e)
        {
            if(addGarment_combo.SelectedIndex == -1) //==> if there isn't nothing
            {
                new WarningForm("Attenzione", "Per continuare seleziona un indumento da inserire").ShowDialog();
            }
            else
            {
                switch (addGarment_combo.SelectedItem)
                {
                    case "T-shirt":
                        SweterControl sweterControl = new SweterControl();
                        this.Controls.Add(sweterControl);
                        sweterControl.BringToFront();
                        break;
                    case "Giacche":
                        JacketControl jacketControl = new JacketControl();
                        this.Controls.Add(jacketControl);
                        jacketControl.BringToFront();
                        break;
                    case "Pantaloni":
                        TrouserControl trouserControl = new TrouserControl();
                        this.Controls.Add(trouserControl);
                        trouserControl.BringToFront();
                        break;
                    case "Scarpe":
                        ShoesControl shoesControl = new ShoesControl();
                        this.Controls.Add(shoesControl);
                        shoesControl.BringToFront();
                        break;
                    case "Borse":
                        BagControl bagControl = new BagControl();
                        this.Controls.Add(bagControl);
                        bagControl.BringToFront();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
