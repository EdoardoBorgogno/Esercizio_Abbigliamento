using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using Es_abbigliamento.UserControlsManageForm;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es_abbigliamento.UserControlsGarment
{
    /// <summary>
    /// User control shoes -> user control for insert new shoes
    /// </summary>
    public partial class ShoesControl : BaseControl
    {
        //==> Shoes user control

        //Constructor
        public ShoesControl()
        {
            InitializeComponent();

            //prepare user control
            functionStartShoesControl();
        }

        #region Action on load user control

        //After constructor is called this function set combo box data source;
        private void functionStartShoesControl()
        {

            //Load design part
            _garmentTitle = "Inserisci Scarpe";

            Shoe shoe = new Shoe();

            shoeCmbSole.DataSource = shoe._garmentSoleList;
            shoeCmbType.DataSource = shoe._garmentTypeList;
            shoeCmbOpeningMode.DataSource = shoe._garmentOpeningModeList;
            shoeCmbTypology.DataSource = shoe._garmentTypologyList;
        }

        #endregion

        #region Insert

        //
        // Insert Functions
        //

        //Button insert click
        protected override void garmentBtnInsert_Click(object sender, EventArgs e)
        {
            bool FieldsAreOk = funCheckFields();

            //If all fields are ok save and open UserControl => InsertComplete
            if (FieldsAreOk)
            {
                bool fileIsOk = true;
                TextWriter fileStock = null;

                //Try catch on open file writer
                try
                {
                    fileStock = new StreamWriter(ClassData._fileStockSave, true);
                }
                catch (Exception ex)
                {
                    fileIsOk = false;
                    new WarningForm("Errore", ex.Message);
                }

                //If file is open
                if (fileIsOk)
                {
                    //Manage save action
                    Shoe shoeObject = new Shoe();
                    bool loadIsOk = funLoadShoeData(shoeObject);

                    if (loadIsOk)
                    {
                        fileStock.WriteLine(shoeObject.viewDataOfGfarmentClass());

                        fileStock.Close();
                    }

                    //Manage user controls
                    this.Controls.Clear();
                    this.Controls.Add(new InsertComplete());
                }

            }
        }

        //Function for load data in the object
        private bool funLoadShoeData(Shoe shoeObject)
        {
            bool loadComplete = true;

            try
            {
                shoeObject._garmentId = ClassData.funLastIdInfoFile();
                shoeObject._garmentBrand = _garmentTxtBrand;
                shoeObject._garmentPrice = Convert.ToDouble(_garmentTxtPrice);
                shoeObject._garmentColor = _garmentTxtColor;
                shoeObject._garmentMaterial = _garmentTxtMaterial;
                shoeObject._garmentType = shoeCmbType.SelectedItem.ToString();
                shoeObject._garmentTypology = shoeCmbTypology.SelectedItem.ToString();
                shoeObject._garmentSize = (short)shoeNumSize.Value;
                shoeObject._garmentOpeningMode = shoeCmbOpeningMode.SelectedItem.ToString();
            }
            catch (Exception ex)
            {
                loadComplete = false;
                new WarningForm("Errore", ex.Message);
            }

            return loadComplete;
        }

        #endregion
    }
}
