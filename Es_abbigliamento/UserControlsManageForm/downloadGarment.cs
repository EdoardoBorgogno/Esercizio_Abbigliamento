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
    /// User control for download garment.
    /// </summary>
    public partial class downloadGarment : UserControl
    {
        //Constuctor
        public downloadGarment()
        {
            InitializeComponent();
        }

        //
        // Manage download click
        //

        //Button clikc
        private void buttonDownload_Click(object sender, EventArgs e)
        {
            bool textIsOk = true;

            try
            {
                Convert.ToInt32(txtId.Text);
            }
            catch
            {
                textIsOk = false;
            }


            if (textIsOk)
            {
                int id = Convert.ToInt32(txtId.Text);
                var dataStock = ClassData.readGarmentDataFromStock();

                Garment garment = dataStock.Where(x => x._garmentId == id).FirstOrDefault();

                bool downloadIsComplete = ManageXml.garmentDataXML(garment);

                if (downloadIsComplete)
                {
                    new CompleteAdviceForm("Dati Scaricati", "Operazione completata con successo").ShowDialog();

                    this.Controls.Clear();
                    this.Controls.Add(new Home());
                }
                else
                {
                    new WarningForm("Attenzione", "Problema con l'operazione!").ShowDialog();
                }
            }
            else
            {
                new WarningForm("Attenzione", "Il valore inserito non è valido!").ShowDialog();
            }
        }
    }
}
