using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Es_abbigliamento.UserControlsManageForm;

namespace Es_abbigliamento.UserControlsManageForm
{
    /// <summary>
    /// Delete Garment user control.
    /// </summary>
    public partial class DeleteGarmentControls : UserControl
    {
        //Delete Garment

        //Constructor
        public DeleteGarmentControls()
        {
            InitializeComponent();
        }

        //ON LOAD
        private void DeleteGarmentControls_Load(object sender, EventArgs e)
        {

        }

        //
        // Manage delete click
        //

        //Button clikc
        private void delete_buttonDelete_Click(object sender, EventArgs e)
        {
            bool textIsOk = true;

            try
            {
                Convert.ToInt32(delete_txtId.Text);
            }
            catch
            {
                textIsOk = false;
            }

            if(textIsOk)
            {
                bool deleteIsCompleted = ClassData.deleteGarmentFromStock(Convert.ToInt32(delete_txtId.Text));

                if (deleteIsCompleted)
                {
                    new CompleteAdviceForm("Eliminazione", "Eliminazione completata con successo").ShowDialog();

                    this.Controls.Clear();
                    this.Controls.Add(new WorkArea());
                }
                else
                {
                    new WarningForm("Attenzione", "Problema con l'eliminazione!").ShowDialog();
                }
            }
            else
            {
                new WarningForm("Attenzione", "Il valore inserito non è valido!").ShowDialog();
            }
        }

        private void delete_IndumentiPanel_Click_1(object sender, EventArgs e)
        {
            Controls.Clear();
            Controls.Add(new IndumentiPanel());
        }
    }
}
