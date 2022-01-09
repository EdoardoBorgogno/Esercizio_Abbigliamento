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
    /// User control trouser mod -> user control for modify trouser.
    /// </summary>
    public partial class TrousersControlMod : Es_abbigliamento.UserControlsGarment.TrouserControl
    {
        //==> trouser modify user control

        private Trousers trouserMod;
        public TrousersControlMod(Garment paramTrouser)
        {
            InitializeComponent();

            trouserMod = (Trousers)paramTrouser;

            //prepare user control
            functionStartTrouserModifyControl();
        }

        #region Action on load user control

        //After constructor is called this function set combo box data source;
        private void functionStartTrouserModifyControl()
        {

            //Load design part
            _garmentTitle = "Modifica Pantalone";
            _garmentBtnText = "Modifica";

            Trousers sweater = new Trousers();
            trouserCmbType.DataSource = sweater._garmentTypeList;
            trouserCmbTypology.DataSource = sweater._garmentTypologyList;
            trouserCmbSize.DataSource = sweater._garmentSizeList;
            trouserCmbLength.DataSource = sweater._garmentLengthList;
            trouserCmbFit.DataSource = sweater._garmentFitList;

            //Set item from param bag
            trouserCmbType.SelectedItem = trouserMod._garmentType;
            trouserCmbTypology.SelectedItem = trouserMod._garmentTypology;
            trouserCmbSize.SelectedItem = trouserMod._garmentSize;
            trouserCmbLength.SelectedItem = trouserMod._garmentLength;
            trouserCmbFit.SelectedItem = trouserMod._garmentFit;
            _garmentTxtBrand = trouserMod._garmentBrand;
            _garmentTxtColor = trouserMod._garmentColor;
            _garmentTxtMaterial = trouserMod._garmentMaterial;
            _garmentTxtPrice = trouserMod._garmentPrice.ToString();
        }

        #endregion

        //Button insert click
        protected override void garmentBtnInsert_Click(object sender, EventArgs e)
        {
            bool FieldsAreOk = funCheckFields();

            if (FieldsAreOk)
            {
                Trousers trouserObject = new Trousers();
                bool loadIsOk = funLoadBagData(trouserObject);

                if (loadIsOk)
                {
                    bool modIsCompleted = ClassData.modifyGarmentStock(trouserObject);
                }

                this.Controls.Clear();
                this.Controls.Add(new WorkArea());
            }
        }

        //Function for load data in the object
        private bool funLoadBagData(Trousers trouserObject)
        {
            bool loadComplete = true;

            try
            {
                trouserObject._garmentId = trouserMod._garmentId;
                trouserObject._garmentBrand = _garmentTxtBrand;
                trouserObject._garmentPrice = Convert.ToDouble(_garmentTxtPrice);
                trouserObject._garmentColor = _garmentTxtColor;
                trouserObject._garmentMaterial = _garmentTxtMaterial;
                trouserObject._garmentType = trouserCmbType.SelectedItem.ToString();
                trouserObject._garmentTypology = trouserCmbTypology.SelectedItem.ToString();
                trouserObject._garmentSize = Convert.ToInt16(trouserCmbSize.SelectedItem);
                trouserObject._garmentFit = trouserCmbFit.SelectedItem.ToString();
                trouserObject._garmentLength = trouserCmbLength.SelectedItem.ToString();
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
