using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using Es_abbigliamento.UserControlsManageForm;
using Es_abbigliamento.UserControlsGarment;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es_abbigliamento.UserControlsGarment
{
    /// <summary>
    /// User control sweter -> user contro for insert new sweater
    /// </summary>
    public partial class SweterControl : BaseControl
    {
        //==> Sweter user control

        //Constructor
        public SweterControl()
        {
            InitializeComponent();

            //prepare user control
            functionStartSweaterControl();
        }

        #region Action on load user control

        //After constructor is called this function set combo box data source;
        private void functionStartSweaterControl()
        {

            //Load design part
            _garmentTitle = "Inserisci Maglia";

            Sweater sweater = new Sweater();

            sweaterCmbOpeningMode.DataSource = sweater._garmentOpeningModeList;
            sweaterCmbSize.DataSource = sweater._garmentSizeList;
            sweaterCmbSleeve.DataSource = sweater._garmentSleeveList;
            sweaterCmbType.DataSource = sweater._garmentTypeList;
            sweaterCmbTypology.DataSource = sweater._garmentTypologyList;
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
                    Sweater sweaterObject = new Sweater();
                    bool loadIsOk = funLoadSweaterData(sweaterObject);

                    if(loadIsOk)
                    {
                        fileStock.WriteLine(sweaterObject.viewDataOfGfarmentClass());

                        fileStock.Close();
                    }

                    //Manage user controls
                    this.Controls.Clear();
                    this.Controls.Add(new InsertComplete());
                }

            }
        }

        //Function for load data in the object
        private bool funLoadSweaterData(Sweater sweaterObject)
        {
            bool loadComplete = true;

            try
            {
                sweaterObject._garmentId = ClassData.funLastIdInfoFile();
                sweaterObject._garmentBrand = _garmentTxtBrand;
                sweaterObject._garmentPrice = Convert.ToDouble(_garmentTxtPrice);
                sweaterObject._garmentColor = _garmentTxtColor;
                sweaterObject._garmentMaterial = _garmentTxtMaterial;
                sweaterObject._garmentType = sweaterCmbType.SelectedItem.ToString();
                sweaterObject._garmentTypology = sweaterCmbTypology.SelectedItem.ToString();
                sweaterObject._garmentSize = sweaterCmbSize.SelectedItem.ToString();
                sweaterObject._garmentSleeve = sweaterCmbSleeve.SelectedItem.ToString();
                sweaterObject._garmentOpeningMode = sweaterCmbOpeningMode.SelectedItem.ToString();
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
