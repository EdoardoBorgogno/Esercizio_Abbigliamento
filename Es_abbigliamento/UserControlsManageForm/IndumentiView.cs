﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Es_abbigliamento.UserControlsManageForm
{
    /// <summary>
    /// Indumenti view with datagridview and filter for stock.
    /// </summary>
    public partial class IndumentiView : UserControl
    {
        //==> Indumenti view

        
        private List<Garment> listGarmentStock;
        private List<Garment> listGarmnetFiltred = new List<Garment>();


        //Constructor
        public IndumentiView()
        {
            InitializeComponent();
        }

        //manage data grid view for display garments info.
        private void IndumentiView_Load(object sender, EventArgs e)
        {
            listGarmentStock = ClassData.readGarmentDataFromStock();
            viewIndumenti_dataGrid.DataSource = listGarmentStock;

            manageDatagridDesign();
        }

        //Set colums name and data grid design properties
        private void manageDatagridDesign()
        {
            //
            //columns style
            //

            //1
            viewIndumenti_dataGrid.Columns[0].HeaderText = "Id";
            viewIndumenti_dataGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            //2
            viewIndumenti_dataGrid.Columns[1].HeaderText = "Tipo";
            viewIndumenti_dataGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            //2
            viewIndumenti_dataGrid.Columns[2].HeaderText = "Marca";
            viewIndumenti_dataGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            //3
            viewIndumenti_dataGrid.Columns[3].HeaderText = "Prezzo";
            viewIndumenti_dataGrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            //4
            viewIndumenti_dataGrid.Columns[4].HeaderText = "Genere";
            viewIndumenti_dataGrid.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        /// <summary>
        /// Create filtred list based on text of txtSearch.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSearchIndumenti_TextChanged(object sender, EventArgs e)
        {
            viewIndumenti_dataGrid.DataSource = null;
            listGarmnetFiltred.Clear();

            if(txtSearchIndumenti.Text == String.Empty)
            {
                viewIndumenti_dataGrid.DataSource = listGarmentStock;
            }
            else
            {
                bool isInsert = false;

                foreach(Garment item in listGarmentStock)
                {
                    if (item._garmentId.ToString().StartsWith(txtSearchIndumenti.Text)) 
                    {
                        listGarmnetFiltred.Add((Garment)item);
                        isInsert = true;
                    }

                    if(item._garmentBrand.StartsWith(txtSearchIndumenti.Text) && isInsert == false)
                    {
                        listGarmnetFiltred.Add((Garment)item);
                        isInsert = true;
                    }

                    if (item.garmentClassTypeString.StartsWith(txtSearchIndumenti.Text) && isInsert == false)
                    {
                        listGarmnetFiltred.Add((Garment)item);
                        isInsert = true;
                    }

                    if (item._garmentPrice.ToString().StartsWith(txtSearchIndumenti.Text) && isInsert == false)
                    {
                        listGarmnetFiltred.Add((Garment)item);
                        isInsert = true;
                    }

                    if (item._garmentType.ToString().StartsWith(txtSearchIndumenti.Text) && isInsert == false)
                    {
                        listGarmnetFiltred.Add((Garment)item);
                        isInsert = true;
                    }

                    isInsert = false;
                }

                viewIndumenti_dataGrid.DataSource = listGarmnetFiltred;

                foreach (DataGridViewRow row in viewIndumenti_dataGrid.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if(cell.Value.ToString().StartsWith(txtSearchIndumenti.Text))
                        {
                            cell.Style.ForeColor = Color.FromArgb(255, 209, 0);
                        }
                    }
                }
            }

            manageDatagridDesign();

            viewIndumenti_dataGrid.ClearSelection();

        }
    }
}
