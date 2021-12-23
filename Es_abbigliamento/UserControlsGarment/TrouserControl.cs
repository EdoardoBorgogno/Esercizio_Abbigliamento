using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Es_abbigliamento.UserControlsManageForm;
using Es_abbigliamento.UserControlsGarment;
using System.Windows.Forms;
using System.IO;

namespace Es_abbigliamento.UserControlsGarment
{
    /// <summary>
    /// User control trouser -> user control for insert new trousers
    /// </summary>
    public partial class TrouserControl : BaseControl
    {
        //==> Trouser user control

        //Constructor
        public TrouserControl()
        {
            InitializeComponent();

            //prepare user control
            functionStartTrouserControl();
        }

        #region Action on load user control

        //After constructor is called this function set combo box data source;
        private void functionStartTrouserControl()
        {

            //Load design part
            _garmentTitle = "Inserisci Pantaloni";

            Trousers trousers = new Trousers();

            trouserCmbType.DataSource = trousers._garmentTypeList;
            trouserCmbTypology.DataSource = trousers._garmentTypologyList;
            trouserCmbSize.DataSource = trousers._garmentSizeList;
            trouserCmbLength.DataSource = trousers._garmentLengthList;
            trouserCmbFit.DataSource = trousers._garmentFitList;
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
                    Trousers trousersObject = new Trousers();

                    bool loadIsOk = funLoadTrouser(trousersObject);

                    if (loadIsOk)
                    {
                        fileStock.WriteLine(trousersObject.viewDataOfGfarmentClass());

                        fileStock.Close();
                    }

                    //Manage user controls
                    this.Controls.Clear();
                    this.Controls.Add(new InsertComplete());

                }
            }
        }

        //Function for load data in the object
        private bool funLoadTrouser(Trousers trousers)
        {
            bool loadComplete = true;

            try
            {
                trousers._garmentId = ClassData.funLastIdInfoFile();
                trousers._garmentBrand = _garmentTxtBrand;
                trousers._garmentPrice = Convert.ToDouble(_garmentTxtPrice);
                trousers._garmentColor = _garmentTxtColor;
                trousers._garmentMaterial = _garmentTxtMaterial;
                trousers._garmentType = trouserCmbType.SelectedItem.ToString();
                trousers._garmentTypology = trouserCmbTypology.SelectedItem.ToString();
                trousers._garmentSize = (short)trouserCmbSize.SelectedItem;
                trousers._garmentLength = trouserCmbLength.SelectedItem.ToString();
                trousers._garmentFit = trouserCmbFit.SelectedItem.ToString();
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
