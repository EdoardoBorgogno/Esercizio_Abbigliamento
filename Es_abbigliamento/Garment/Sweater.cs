using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_abbigliamento
{
    /// <summary>
    /// Class Sweater.
    /// </summary>
    internal class Sweater : Garment
    {
        //Sweater class ==> inheritance Garment base class

        //Fields
        private string garmentTypology;
        private string garmentSize;
        private string garmentSleeve;
        private string garmentOpeningMode;

        //Constructor
        public Sweater() : base()
        {
            garmentTypology = String.Empty;
            garmentSize = String.Empty;
            garmentSleeve = String.Empty;
            garmentOpeningMode = String.Empty;
            _garmentClassType = typeof(Sweater);
        }

        #region Garment element list

        //List with garment typology
        private List<string> garmentTypologyList = new List<string>()
        {
            "felpa",
            "t-shirt",
            "polo",
            "canotta"
        };
        private List<string> garmentSizeList = new List<string>()
        {
            "XS",
            "S",
            "M",
            "L",
            "XL",
            "XXL",
            "XXXL"
        };
        private List<string> garmentSleeveList = new List<string>()
        {
            "lunga",
            "corta",
            "mezzamanica",
            "smanicata"
        };
        private List<string> garmentOpeningModeList = new List<string>()
        {
            "zip",
            "bottoni",
            "velcro",
            "senza"
        };

        #endregion

        #region Properties

        //Properties of Sweater class

        /// <summary>
        /// Property typology, get/set the typology of the sweater (felpa, t-shirt, polo, canotta).
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
        /// Property size, get/set the size of the sweater (XS, S, M, L...).
        /// </summary>
        public string _garmentSize
        {
            get
            {
                return garmentSize;
            }
            set
            {
                if(garmentSizeList.Contains(value.ToUpper()))
                {
                    garmentSize = value.ToUpper();
                }
                else
                {
                    throw new Exception("Error with your size input");
                }
            }
        }

        /// <summary>
        /// Property sleeve, get/set the sleeve typology of the garment (Lunga, Corta, Mezza Manica...).
        /// </summary>
        public string _garmentSleeve
        {
            get
            {
                return garmentSleeve;
            }
            set
            {
                if (garmentSleeveList.Contains(value.ToLower()))
                {
                    garmentSleeve = value.ToLower();
                }
                else
                {
                    throw new Exception("Error with your sleeve input");
                }
            }
        }

        /// <summary>
        /// Property opening Mode, get/set the opening mode of the garment (zip, bottoni, senza...).
        /// </summary>
        public string _garmentOpeningMode
        {
            get 
            {
                return garmentOpeningMode; 
            }
            set
            {
                if(garmentOpeningModeList.Contains(value.ToLower()))
                {
                    garmentOpeningMode = value.ToLower();
                }
                else
                {
                    throw new Exception("Error with your opening mode input");
                }
            }
        }


        //Properties GET from sweater Lists (garmentOpeningModeList, ...)

        /// <summary>
        /// Get garmentTypologyList, this list contains all possibility for set the sweater type.
        /// </summary>
        public List<string> _garmentTypologyList
        {
            get
            {
                return garmentTypologyList;
            }
        }

        /// <summary>
        /// Get garmentSizeList, this list contains all possibility for set the sweater size.
        /// </summary>
        public List<string> _garmentSizeList
        {
            get
            {
                return garmentSizeList;
            }
        }

        /// <summary>
        /// Get garmentSleeveList, this list contains all possibility for set the sweater sleeve type.
        /// </summary>
        public List<string> _garmentSleeveList
        {
            get
            {
                return garmentSleeveList;
            }
        }

        /// <summary>
        /// Get garmentOpeningModeList, this list contains all possibility for set the sweater opening mode type.
        /// </summary>
        public List<string> _garmentOpeningModeList
        {
            get 
            {  
                return garmentOpeningModeList; 
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Method for optain garment properties.
        /// </summary>
        /// <returns>String with all data of sweater + base class, separated by semicolon.</returns>
        public override string viewDataOfGfarmentClass()
        {
            string stringData = base.viewDataOfGfarmentClass() + ";";

            stringData += garmentTypology + ";";
            stringData += garmentSize + ";";
            stringData += garmentSleeve + ";";
            stringData += garmentOpeningMode;

            return stringData; //==> return string with sweater + base class data
        }

        #endregion
    }
}
