using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Es_abbigliamento.UserControlsGarment;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es_abbigliamento.UserControlsManageForm
{
    /// <summary>
    /// User control for modify garments;
    /// </summary>
    public partial class userControlModGarment : UserControl
    {
        public userControlModGarment()
        {
            InitializeComponent();
        }

        //
        // Manage mod click
        //

        //Button clikc
        private void mod_buttonMod_Click(object sender, EventArgs e)
        {
            bool textIsOk = true;

            try
            {
                Convert.ToInt32(mod_txtId.Text);
            }
            catch
            {
                textIsOk = false;
            }


            if (textIsOk)
            {
                int id = Convert.ToInt32(mod_txtId.Text);
                Garment garmentObj = null;
                bool idIsPresent = false;
                string garmentType = string.Empty;

                List<Garment> listGarment = ClassData.readGarmentDataFromStock();

                foreach(Garment garment in listGarment)
                {
                    if(garment._garmentId == id)
                    {
                        garmentType = garment.garmentClassTypeString;
                        garmentObj = garment;

                        idIsPresent = true;
                        break;
                    }
                }

                if(idIsPresent)
                {
                    switch (garmentType)
                    {
                        case "Bag":
                            this.Controls.Clear();
                            this.Controls.Add(new BagControlMod(garmentObj));
                            break;
                        case "Jackets":
                            this.Controls.Clear();
                            this.Controls.Add(new JacketControlMod(garmentObj));
                            break;
                        case "Shoe":
                            this.Controls.Clear();
                            this.Controls.Add(new ShoesControlMod(garmentObj));
                            break;
                        case "Sweater":
                            this.Controls.Clear();
                            this.Controls.Add(new SweaterControlMod(garmentObj));
                            break;
                        case "Trousers":
                            this.Controls.Clear();
                            this.Controls.Add(new TrousersControlMod(garmentObj));
                            break;
                    }
                }
                else
                {
                    new WarningForm("Attenzione", "Il valore inserito non è presente!").ShowDialog();
                }
            }
            else
            {
                new WarningForm("Attenzione", "Il valore inserito non è valido!").ShowDialog();
            }
        }

        //Btn open indumenti panel
        private void delete_IndumentiPanel_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            Controls.Add(new IndumentiPanel());
        }
    }
}
