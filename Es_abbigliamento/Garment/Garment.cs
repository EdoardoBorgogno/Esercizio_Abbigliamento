using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Es_abbigliamento
{
    /// <summary>
    /// Base Class garment.
    /// </summary>
    public class Garment
    {
        //Base class garment, use this class for create all different type of garment.

        //Fields of base class
        private int garmentId;
        private Type garmentClassType;
        private string garmentBrand;
        private double garmentPrice;
        private string garmentColor;
        private string garmentMaterial;
        private string garmentType;

        #region List Garment

        List<string> garmentTypeList = new List<string>()
        {
            "uomo",
            "donna",
            "bambino",
            "bambina"
        };

        #endregion

        #region Properties

        //Properties of base class

        /// <summary>
        /// Property id, get/set the id of the garment.
        /// </summary>
        public int _garmentId
        {
            get
            {
                return garmentId;
            }
            set
            {
                garmentId = value;
            }
        }

        [Browsable(false)]
        /// <summary>
        /// Property garmentClassType, get/set the property class type.
        /// </summary>
        public Type _garmentClassType
        {
            get { return garmentClassType; }
            set { garmentClassType = value; }
        }

        /// <summary>
        /// Property garmentClassTypeString, get the property class type in string (Bag, Sweater...).
        /// </summary>
        public string garmentClassTypeString
        {
            get { return garmentClassType.ToString().Remove(0, "Es_abbigliamento.".Length); }
        }

        /// <summary>
        /// Property brand, get/set the brand of the garment.
        /// </summary>
        public string _garmentBrand
        {
            get
            {
                return garmentBrand;
            }
            set
            {
                if(value != string.Empty)
                {
                    garmentBrand = value;
                }
                else
                {
                    throw new Exception("garment Brand must not be empty");
                }
            }
        }

        /// <summary>
        /// Property price, get/set the price of the garment.
        /// </summary>
        public virtual double _garmentPrice 
        {
            get
            {
                return garmentPrice;
            }
            set
            {
                if (value > 0.0)
                {
                    garmentPrice = value;
                }
                else
                {
                    throw new Exception("garment Price must not be 0.0");
                }
            }
        }

        [Browsable(false)]
        /// <summary>
        /// Property color, get/set the color of the garment.
        /// </summary>
        public string _garmentColor
        {
            get
            {
                return garmentColor;
            }
            set
            {
                if (value != String.Empty)
                {
                    garmentColor = value;
                }
                else
                {
                    throw new Exception("garment Color must not be empty");
                }
            }
        }

        [Browsable(false)]
        /// <summary>
        /// Property material, get/set the material of the garment.
        /// </summary>
        public string _garmentMaterial
        {
            get
            {
                return garmentMaterial;
            }
            set
            {
                if (value != String.Empty)
                {
                    garmentMaterial = value;
                }
                else
                {
                    throw new Exception("garment Material must not be empty");
                }
            }
        }
      
        /// <summary>
        /// Property type, get/set the type of the garment (Uomo, Donna, Bambino, Bambina).
        /// </summary>
        public string _garmentType
        {
            get
            {
                return garmentType;
            }
            set
            {
                if (value != string.Empty)
                {
                    garmentType = value;
                }
                else
                {
                    throw new Exception("garment Type must not be empty");
                }
            }
        }

        /// <summary>
        /// Get garmentTypeList, this list contains all possibility for set the type of the garment.
        /// </summary>
        public List<string> _garmentTypeList
        {
            get
            {
                return garmentTypeList;
            }
        }

        #endregion

        #region Constructors

        //Constructors of the base class

        //Base Constructor
        public Garment()
        {
            garmentBrand = string.Empty;
            garmentPrice = 0.0;
            garmentColor = string.Empty;
            garmentMaterial = string.Empty;
            garmentId = 0;
            garmentType = string.Empty;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Method for optain garment properties.
        /// </summary>
        /// <returns>String with all data of base class, separated by semicolon.</returns>
        public virtual string viewDataOfGfarmentClass()
        {
            string stringData = string.Empty;

            stringData = garmentId.ToString() + ";" + garmentClassType.ToString().Remove(0, "Es_abbigliamento.".Length) + ";" + garmentBrand.ToString() + ";" + garmentPrice.ToString() + ";" + garmentColor.ToString() + ";" + garmentMaterial.ToString() + ";" + garmentType.ToString();

            return stringData;  //==> return string with base class data
        }

        #endregion
    }
}
