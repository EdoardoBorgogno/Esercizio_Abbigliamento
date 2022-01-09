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
    /// User control sweater mod -> user control for modify sweater.
    /// </summary>
    public partial class SweaterControlMod : Es_abbigliamento.UserControlsGarment.SweterControl
    {
        //==> Shoe modify user control

        private Sweater sweaterMod;
        public SweaterControlMod(Garment paramSweater)
        {
            InitializeComponent();

            sweaterMod = (Sweater)paramSweater;

            //prepare user control
            functionStartSweaterModifyControl();
        }

        #region Action on load user control

        //After constructor is called this function set combo box data source;
        private void functionStartSweaterModifyControl()
        {

            //Load design part
            _garmentTitle = "Modifica Maglia";
            _garmentBtnText = "Modifica";

            Sweater sweater = new Sweater();
            sweaterCmbType.DataSource = sweater._garmentTypeList;
            sweaterCmbTypology.DataSource = sweater._garmentTypologyList;
            sweaterCmbSize.DataSource = sweater._garmentSizeList;
            sweaterCmbSleeve.DataSource = sweater._garmentSleeveList;
            sweaterCmbOpeningMode.DataSource = sweater._garmentOpeningModeList;

            //Set item from param bag
            sweaterCmbType.SelectedItem = sweaterMod._garmentType;
            sweaterCmbTypology.SelectedItem = sweaterMod._garmentTypology;
            sweaterCmbSize.SelectedItem = sweaterMod._garmentSize;
            sweaterCmbOpeningMode.SelectedItem = sweaterMod._garmentOpeningMode;
            sweaterCmbSleeve.SelectedItem = sweaterMod._garmentSleeve;
            _garmentTxtBrand = sweaterMod._garmentBrand;
            _garmentTxtColor = sweaterMod._garmentColor;
            _garmentTxtMaterial = sweaterMod._garmentMaterial;
            _garmentTxtPrice = sweaterMod._garmentPrice.ToString();
        }

        #endregion

        //Button insert click
        protected override void garmentBtnInsert_Click(object sender, EventArgs e)
        {
            bool FieldsAreOk = funCheckFields();

            if (FieldsAreOk)
            {
                Sweater sweaterObject = new Sweater();
                bool loadIsOk = funLoadBagData(sweaterObject);

                if (loadIsOk)
                {
                    bool modIsCompleted = ClassData.modifyGarmentStock(sweaterObject);
                }

                this.Controls.Clear();
                this.Controls.Add(new WorkArea());
            }
        }

        //Function for load data in the object
        private bool funLoadBagData(Sweater sweaterObject)
        {
            bool loadComplete = true;

            try
            {
                sweaterObject._garmentId = sweaterMod._garmentId;
                sweaterObject._garmentBrand = _garmentTxtBrand;
                sweaterObject._garmentPrice = Convert.ToDouble(_garmentTxtPrice);
                sweaterObject._garmentColor = _garmentTxtColor;
                sweaterObject._garmentMaterial = _garmentTxtMaterial;
                sweaterObject._garmentType = sweaterCmbType.SelectedItem.ToString();
                sweaterObject._garmentTypology = sweaterCmbTypology.SelectedItem.ToString();
                sweaterObject._garmentSize = sweaterCmbSize.SelectedItem.ToString();
                sweaterObject._garmentOpeningMode = sweaterCmbOpeningMode.SelectedItem.ToString();
                sweaterObject._garmentSleeve = sweaterCmbSleeve.SelectedItem.ToString();
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
