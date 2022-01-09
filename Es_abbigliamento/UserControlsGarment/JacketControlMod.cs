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
    /// User control jacket mod -> user control for modify jacket.
    /// </summary>
    public partial class JacketControlMod : Es_abbigliamento.UserControlsGarment.JacketControl
    {
        //==> Jacket modify user control

        private Jackets jacketMod;

        public JacketControlMod(Garment paramJacket)
        {
            InitializeComponent();

            jacketMod = (Jackets)paramJacket;

            //prepare user control
            functionStartJacketModifyControl();
        }

        #region Action on load user control

        //After constructor is called this function set combo box data source;
        private void functionStartJacketModifyControl()
        {

            //Load design part
            _garmentTitle = "Modifica Giacca";
            _garmentBtnText = "Modifica";

            Jackets jackets = new Jackets();
            jacketCmbType.DataSource = jackets._garmentTypeList;
            jacketCmbTypology.DataSource = jackets._garmentTypologyList;
            jacketCmbSize.DataSource = jackets._garmentSizeList;
            jacketCmbSeason.DataSource = jackets._garmentSeasonList;

            //Set item from param bag
            jacketCmbType.SelectedItem = jacketMod._garmentType;
            jacketCmbTypology.SelectedItem = jacketMod._garmentTypology;
            jacketCmbSize.SelectedItem = jacketMod._garmentSize;
            jacketCmbSeason.SelectedItem = jacketMod._garmentSeason;
            _garmentTxtBrand = jacketMod._garmentBrand;
            _garmentTxtColor = jacketMod._garmentColor;
            _garmentTxtMaterial = jacketMod._garmentMaterial;
            _garmentTxtPrice = jacketMod._garmentPrice.ToString();
        }

        #endregion

        //Button insert click
        protected override void garmentBtnInsert_Click(object sender, EventArgs e)
        {
            bool FieldsAreOk = funCheckFields();

            if (FieldsAreOk)
            {
                Jackets jacketObject = new Jackets();
                bool loadIsOk = funLoadBagData(jacketObject);

                if (loadIsOk)
                {
                    bool modIsCompleted = ClassData.modifyGarmentStock(jacketObject);
                }

                this.Controls.Clear();
                this.Controls.Add(new WorkArea());
            }
        }

        //Function for load data in the object
        private bool funLoadBagData(Jackets jacketObject)
        {
            bool loadComplete = true;

            try
            {
                jacketObject._garmentId = jacketMod._garmentId;
                jacketObject._garmentBrand = _garmentTxtBrand;
                jacketObject._garmentPrice = Convert.ToDouble(_garmentTxtPrice);
                jacketObject._garmentColor = _garmentTxtColor;
                jacketObject._garmentMaterial = _garmentTxtMaterial;
                jacketObject._garmentType = jacketCmbType.SelectedItem.ToString();
                jacketObject._garmentTypology = jacketCmbTypology.SelectedItem.ToString();
                jacketObject._garmentSize = jacketCmbSize.SelectedItem.ToString();
                jacketObject._garmentSeason = jacketCmbSeason.SelectedItem.ToString();
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
