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
using System.IO;

namespace Es_abbigliamento.UserControlsGarment
{
    /// <summary>
    /// User control jacket -> user contro for insert new jacket
    /// </summary>
    public partial class JacketControl : BaseControl
    {
        //==> Jacket user control

        //Constructor
        public JacketControl()
        {
            InitializeComponent();

            //prepare user control
            functionStartJacketControl();
        }

        #region Action on load user control

        //After constructor is called this function set combo box data source;
        private void functionStartJacketControl()
        {

            //Load design part
            _garmentTitle = "Inserisci Maglia";

            Jackets jackets = new Jackets();

            jacketCmbType.DataSource = jackets._garmentTypeList;
            jacketCmbSeason.DataSource = jackets._garmentSeasonList;
            jacketCmbSize.DataSource = jackets._garmentSizeList;
            jacketCmbTypology.DataSource = jackets._garmentTypologyList;
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
                    Jackets jacketsObject = new Jackets();
                    bool loadIsOk = funLoadJacketData(jacketsObject);

                    if (loadIsOk)
                    {
                        fileStock.WriteLine(jacketsObject.viewDataOfGfarmentClass());

                        fileStock.Close();
                    }

                    //Manage user controls
                    this.Controls.Clear();
                    this.Controls.Add(new InsertComplete());
                }

            }
        }

        //Function for load data in the object
        private bool funLoadJacketData(Jackets jacketsObject)
        {
            bool loadComplete = true;

            try
            {
                jacketsObject._garmentId = ClassData.funLastIdInfoFile();
                jacketsObject._garmentBrand = _garmentTxtBrand;
                jacketsObject._garmentPrice = Convert.ToDouble(_garmentTxtPrice);
                jacketsObject._garmentColor = _garmentTxtColor;
                jacketsObject._garmentMaterial = _garmentTxtMaterial;
                jacketsObject._garmentType = jacketCmbType.SelectedItem.ToString();
                jacketsObject._garmentTypology = jacketCmbTypology.SelectedItem.ToString();
                jacketsObject._garmentSize = jacketCmbSize.SelectedItem.ToString();
                jacketsObject._garmentSeason = jacketCmbSeason.SelectedItem.ToString();
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
