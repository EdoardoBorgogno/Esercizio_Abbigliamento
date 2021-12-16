using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_abbigliamento
{
    /// <summary>
    /// Class Shoe.
    /// </summary>
    internal class Shoe : Garment
    {
        //Shoe class ==> inheritance Garment base class

        //Fields
        private string garmentTypology;
        private short garmentSize;
        private string garmentOpeningMode;
        private string garmentSole;

        #region Garment element list

        //List with garment typology
        private List<string> garmentTypologyList = new List<string>()
        {
            "sandali",
            "ginnastica",
            "mocassini",
            "stivali",
            "ciabatte"
        };
        private List<string> garmentOpeningModeList = new List<string>()
        {
            "lacci",
            "velcro",
            "zip",
            "aperte"
        };
        private List<string> garmentSoleList = new List<string>()
        {
            "cuoio",
            "gomma",
            "plastica",
            "legno"
        };

        #endregion

        #region Properties

        /// <summary>
        /// Property typology, get/set the typology of the Shoe (sandali, mocassini, stivali).
        /// </summary>
        public string _garmentTypology
        {
            get
            {
                return garmentTypology;
            }
            set
            {
                if (garmentTypologyList.Contains(value.ToLower()))
                {
                    garmentTypology = value.ToLower();
                }
                else
                {
                    throw new Exception("Error with your typology input");
                }
            }
        }

        /// <summary>
        /// Property size, get/set the size of the Shoe. Input >= 18 and Input <= 50
        /// </summary>
        public short _garmentSize
        {
            get
            {
                return garmentSize;
            }
            set
            {
                if(value >= 18 && value <= 50)
                {
                    garmentSize = value;
                }
                else
                {
                    throw new Exception("Error with your size input");
                }
            }
        }

        /// <summary>
        /// Property size, get/set the opening mode of the Shoe (lacci, velcro, ...).
        /// </summary>
        public string _garmentOpeningMode
        {
            get 
            {
                return garmentOpeningMode; 
            }
            set
            {
                if (garmentOpeningModeList.Contains(value.ToLower()))
                {
                    garmentOpeningMode = value.ToLower();
                }
                else
                {
                    throw new Exception("Error with your opening mode input");
                }
            }
        }

        /// <summary>
        /// Property sole, get/set the sole type of the Shoe (cuoio, plastica, ...).
        /// </summary>
        public string _garmentSole
        {
            get
            {
                return garmentSole;
            }
            set
            {
                if (garmentSoleList.Contains(value.ToLower()))
                {
                    garmentSole = value.ToLower();
                }
                else
                {
                    throw new Exception("Error with your sole input");
                }
            }
        }

        /// <summary>
        /// Get garmentTypologyList, this list contains all possibility for set the type of the shoe.
        /// </summary>
        public List<string> _garmentTypologyList
        {
            get
            {
                return garmentTypologyList;
            }
        }

        /// <summary>
        /// Get garmentOpeningModeList, this list contains all possibility for set the opening mode of the shoe.
        /// </summary>
        public List<string> _garmentOpeningModeList
        {
            get
            {
                return _garmentOpeningModeList;
            }
        }

        /// <summary>
        /// Get garmentSoleList, this list contains all possibility for set the sole of the shoe.
        /// </summary>
        public List<string> _garmentSoleList
        {
            get
            {
                return garmentSoleList;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Method for optain garment properties.
        /// </summary>
        /// <returns>String with all data of shoe + base class, separated by semicolon.</returns>
        public override string viewDataOfGfarmentClass()
        {
            string stringData = base.viewDataOfGfarmentClass() + ";";

            stringData += garmentTypology + ";";
            stringData += garmentSize + ";";
            stringData += garmentOpeningMode + ";";
            stringData += garmentSole;

            return stringData; //==> return string with shoe + base class data
        }

        #endregion
    }
}
