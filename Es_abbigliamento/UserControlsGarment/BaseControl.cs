using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es_abbigliamento.UserControlsGarment
{
    /// <summary>
    /// Base control for garment control
    /// </summary>
    public partial class BaseControl : UserControl
    {
        //Properties
        public string _garmentTitle { get => garmentTitle.Text; set => garmentTitle.Text = value; }
        public string _garmentTxtBrand { get => garmentTxtBrand.Text; set => garmentTxtBrand.Text = value; }
        public string _garmentTxtPrice { get => garmentTxtPrice.Text; set => garmentTxtPrice.Text = value; }
        public string _garmentTxtColor { get => garmentTxtColor.Text; set => garmentTxtColor.Text = value; }
        public string _garmentTxtMaterial { get => garmentTxtMaterial.Text; set => garmentTxtMaterial.Text = value; }

        //Constructor
        public BaseControl()
        {
            InitializeComponent();
        }

        //Button Function Click
        protected virtual void garmentBtnInsert_Click(object sender, EventArgs e)
        {

        }


        //Function for checks fieds.
        protected bool funCheckFields()
        {
            bool isOk = true;

            if (_garmentTxtBrand == String.Empty)
            {
                isOk = false;
                new WarningForm("Attenzione", "La marca deve essere inserita").ShowDialog();
            }

            if (!Double.TryParse(_garmentTxtPrice, out double n) && isOk)
            {
                isOk = false;
                new WarningForm("Attenzione", "Il prezzo deve essere inserito e deve essere numerico").ShowDialog();
            }

            if (_garmentTxtColor == String.Empty && isOk)
            {
                isOk = false;
                new WarningForm("Attenzione", "Il colore deve essere inserito").ShowDialog();
            }

            if (_garmentTxtMaterial == String.Empty && isOk)
            {
                isOk = false;
                new WarningForm("Attenzione", "Il materiale deve essere inserito").ShowDialog();
            }

            return isOk;
        }
    }
}
