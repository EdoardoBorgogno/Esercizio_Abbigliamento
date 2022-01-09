using Es_abbigliamento.UserControlsManageForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Es_abbigliamento.UserControlsGarment
{
    /// <summary>
    /// User control shoe mod -> user control for modify shoe.
    /// </summary>
    public partial class ShoesControlMod : Es_abbigliamento.UserControlsGarment.ShoesControl
    {
        //==> Shoe modify user control

        private Shoe shoeMod;

        public ShoesControlMod(Garment paramShoe)
        {
            InitializeComponent();

            shoeMod = (Shoe)paramShoe;

            //prepare user control
            functionStartShoeModifyControl();
        }

        #region Action on load user control

        //After constructor is called this function set combo box data source;
        private void functionStartShoeModifyControl()
        {

            //Load design part
            _garmentTitle = "Modifica Scarpe";
            _garmentBtnText = "Modifica";

            Shoe shoe = new Shoe();
            shoeCmbType.DataSource = shoe._garmentTypeList;
            shoeCmbTypology.DataSource = shoe._garmentTypologyList;
            shoeCmbSole.DataSource = shoe._garmentSoleList;
            shoeCmbOpeningMode.DataSource = shoe._garmentOpeningModeList;

            //Set item from param bag
            shoeCmbType.SelectedItem = shoeMod._garmentType;
            shoeCmbTypology.SelectedItem = shoeMod._garmentTypology;
            shoeNumSize.Value = shoeMod._garmentSize;
            shoeCmbOpeningMode.SelectedItem = shoeMod._garmentOpeningMode;
            _garmentTxtBrand = shoeMod._garmentBrand;
            _garmentTxtColor = shoeMod._garmentColor;
            _garmentTxtMaterial = shoeMod._garmentMaterial;
            _garmentTxtPrice = shoeMod._garmentPrice.ToString();
        }

        #endregion

        //Button insert click
        protected override void garmentBtnInsert_Click(object sender, EventArgs e)
        {
            bool FieldsAreOk = funCheckFields();

            if (FieldsAreOk)
            {
                Shoe shoeObject = new Shoe();
                bool loadIsOk = funLoadBagData(shoeObject);

                if (loadIsOk)
                {
                    bool modIsCompleted = ClassData.modifyGarmentStock(shoeObject);
                }

                this.Controls.Clear();
                this.Controls.Add(new WorkArea());
            }
        }

        //Function for load data in the object
        private bool funLoadBagData(Shoe shoeObject)
        {
            bool loadComplete = true;

            try
            {
                shoeObject._garmentId = shoeMod._garmentId;
                shoeObject._garmentBrand = _garmentTxtBrand;
                shoeObject._garmentPrice = Convert.ToDouble(_garmentTxtPrice);
                shoeObject._garmentColor = _garmentTxtColor;
                shoeObject._garmentMaterial = _garmentTxtMaterial;
                shoeObject._garmentType = shoeCmbType.SelectedItem.ToString();
                shoeObject._garmentTypology = shoeCmbTypology.SelectedItem.ToString();
                shoeObject._garmentSize = Convert.ToInt16(shoeNumSize.Value);
                shoeObject._garmentOpeningMode = shoeCmbOpeningMode.SelectedItem.ToString();
                shoeObject._garmentSole = shoeCmbSole.SelectedItem.ToString();
            }
            catch (Exception ex)
            {
                loadComplete = false;
                new WarningForm("Errore", ex.Message);
            }

            return loadComplete;
        }
    }
}
