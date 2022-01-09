using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Es_abbigliamento.UserControlsGarment;
using System.Windows.Forms;
using Es_abbigliamento.UserControlsManageForm;

namespace Es_abbigliamento.UserControlsGarment
{
    /// <summary>
    /// User control bag mod -> user control for modify bag.
    /// </summary>
    public partial class BagControlMod : Es_abbigliamento.UserControlsGarment.BagControl
    {
        //==> Bags modify user control

        private Bag bagMod;

        //Constructor
        public BagControlMod(Garment paramBag)
        {
            InitializeComponent();

            bagMod = (Bag)paramBag;

            //prepare user control
            functionStartBagModifyControl();
        }

        #region Action on load user control

        //After constructor is called this function set combo box data source;
        private void functionStartBagModifyControl()
        {

            //Load design part
            _garmentTitle = "Modifica Borsa";
            _garmentBtnText = "Modifica";

            Bag bag = new Bag();
            _bagCmbType.DataSource = bag._garmentTypeList;
            _bagCmbTypology.DataSource = bag._garmentTypologyList;
            _bagCmbSize.DataSource = bag._garmentSizeList;
            _bagCmbSeason.DataSource = bag._garmentSeasonList;

            //Set item from param bag
            _bagCmbType.SelectedItem = bagMod._garmentType;
            _bagCmbTypology.SelectedItem = bagMod._garmentTypology;
            _bagCmbSize.SelectedItem = bagMod._garmentSize;
            _bagCmbSeason.SelectedItem = bagMod._garmentSeason;
            _garmentTxtBrand = bagMod._garmentBrand;
            _garmentTxtColor = bagMod._garmentColor;
            _garmentTxtMaterial = bagMod._garmentMaterial;
            _garmentTxtPrice = bagMod._garmentPrice.ToString();
        }

        #endregion

        //Button insert click
        protected override void garmentBtnInsert_Click(object sender, EventArgs e)
        {
            bool FieldsAreOk = funCheckFields();

            if (FieldsAreOk)
            {
                Bag bagObject = new Bag();
                bool loadIsOk = funLoadBagData(bagObject);

                if (loadIsOk)
                {
                    bool modIsCompleted = ClassData.modifyGarmentStock(bagObject);
                }

                this.Controls.Clear();
                this.Controls.Add(new WorkArea());
            }
        }

        //Function for load data in the object
        private bool funLoadBagData(Bag bagObject)
        {
            bool loadComplete = true;

            try
            {
                bagObject._garmentId = bagMod._garmentId;
                bagObject._garmentBrand = _garmentTxtBrand;
                bagObject._garmentPrice = Convert.ToDouble(_garmentTxtPrice);
                bagObject._garmentColor = _garmentTxtColor;
                bagObject._garmentMaterial = _garmentTxtMaterial;
                bagObject._garmentType = _bagCmbType.SelectedItem.ToString();
                bagObject._garmentTypology = _bagCmbTypology.SelectedItem.ToString();
                bagObject._garmentSize = _bagCmbSize.SelectedItem.ToString();
                bagObject._garmentSeason = _bagCmbSeason.SelectedItem.ToString();
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
