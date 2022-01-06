using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using Es_abbigliamento.UserControlsManageForm;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es_abbigliamento.UserControlsGarment
{
    /// <summary>
    /// User control bag -> user control for insert new bag.
    /// </summary>
    public partial class BagControl : BaseControl
    {
        //==> Bags user control

        //properties
        public ComboBox _bagCmbType
        {
            get {  return bagCmbType; }
            set { bagCmbType = value; }
        }
        public ComboBox _bagCmbTypology
        {
            get {  return bagCmbTypology;}
            set { bagCmbTypology = value; }
        }
        public ComboBox _bagCmbSize
        {
            get { return bagCmbSize; }
            set {  bagCmbSize = value; }
        }
        public ComboBox _bagCmbSeason
        {
            get { return bagCmbSeason; }
            set { bagCmbSeason = value; }
        }

        //Constructor
        public BagControl()
        {
            InitializeComponent();

            //prepare user control
            functionStartBagControl();
        }

        #region Action on load user control

        //After constructor is called this function set combo box data source;
        private void functionStartBagControl()
        {

            //Load design part
            _garmentTitle = "Inserisci Borsa";

            Bag bag = new Bag();
            bagCmbType.DataSource = bag._garmentTypeList;
            bagCmbTypology.DataSource = bag._garmentTypologyList;
            bagCmbSize.DataSource = bag._garmentSizeList;
            bagCmbSeason.DataSource = bag._garmentSeasonList;
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
                    Bag bagObject = new Bag();
                    bool loadIsOk = funLoadBagData(bagObject);

                    if (loadIsOk)
                    {
                        fileStock.WriteLine(bagObject.viewDataOfGfarmentClass());

                        fileStock.Close();
                    }

                    //Manage user controls
                    this.Controls.Clear();
                    this.Controls.Add(new InsertComplete());
                }

            }
        }

        //Function for load data in the object
        private bool funLoadBagData(Bag bagObject)
        {
            bool loadComplete = true;

            try
            {
                bagObject._garmentId = ClassData.funLastIdInfoFile();
                bagObject._garmentBrand = _garmentTxtBrand;
                bagObject._garmentPrice = Convert.ToDouble(_garmentTxtPrice);
                bagObject._garmentColor = _garmentTxtColor;
                bagObject._garmentMaterial = _garmentTxtMaterial;
                bagObject._garmentType = bagCmbType.SelectedItem.ToString();
                bagObject._garmentTypology = bagCmbTypology.SelectedItem.ToString();
                bagObject._garmentSize = bagCmbSize.SelectedItem.ToString();
                bagObject._garmentSeason = bagCmbSeason.SelectedItem.ToString();
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
