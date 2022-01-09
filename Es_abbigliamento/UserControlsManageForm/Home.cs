using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Es_abbigliamento.UserControlsManageForm;
using System.Windows.Forms;
using Es_abbigliamento.Properties;

namespace Es_abbigliamento
{
    /// <summary>
    /// Home user control.
    /// </summary>
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }

        //When load read last element from stock and put in datagridview.
        private void Home_Load(object sender, EventArgs e)
        {

            // Work on datagridview
            if(ClassData.funLastIdStockFile() != -1)
            {
                manageDataGridView();
            }
            else
            {
                home_dataGridLastElement.Visible = false;

                home_noGarmentPanel.Visible = true;
            }

            //work on garment report panel
            string textOfNum = " Indumenti";
            home_lblGarmentNumber.Text = ClassData.getNumberOfGarment().ToString() + textOfNum;

        }

        //Add columns to data grid view and bind properties.
        private void manageDataGridView()
        {
            //Get last element from stock and set the data source
            home_dataGridLastElement.DataSource = ClassData.readLastGarmentFromStock(10);

            //
            // Work on columns
            //

            //Columns Properties
            home_dataGridLastElement.AutoGenerateColumns = false;
            home_dataGridLastElement.Columns.Clear();

            //Add columns
            home_dataGridLastElement.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tipo", DataPropertyName = "garmentClassTypeString", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill});
            home_dataGridLastElement.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Brand", DataPropertyName = "_garmentBrand", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill});
            home_dataGridLastElement.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Prezzo", DataPropertyName = "_garmentPrice", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill});

        }

        //If there is no garment show panel with this button
        private void home_buttonWorkArea_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(new WorkArea());
        }

        //Open report control
        private void btnGoToReport_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(new Report());
        }

        #region

        //Open report
        private void yourStock_panelReport_DoubleClick(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(new Report());
        }

        //Open 
        private void yourStock_panelWork_DoubleClick(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(new WorkArea());
        }
        #endregion
    }
}
