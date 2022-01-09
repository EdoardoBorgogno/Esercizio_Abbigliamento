using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_abbigliamento
{
    /// <summary>
    /// Class Trousers.
    /// </summary>
    public class Trousers : Garment
    {
        //Trousers class ==> inheritance Garment base class

        //Fields
        private string garmentTypology;
        private short garmentSize;
        private string garmentLength;
        private string garmentFit;

        //Constructor
        public Trousers() : base()
        {
            garmentTypology = String.Empty;
            garmentSize = 0;
            garmentLength = String.Empty;
            garmentFit = String.Empty;
            _garmentClassType = typeof(Trousers);
        }

        #region Garment element list

        //List with garment typology
        private List<string> garmentTypologyList = new List<string>()
        {
            "jeans",
            "felpati",
            "leggins",
            "classici"
        };
        private List<short> garmentSizeList = new List<short>()
        {
            44,
            46,
            48,
            50,
            52,
            54,
            56,
            58,
            60
        };
        private List<string> garmentLengthList = new List<string>()
        {
            "lunghi",
            "corti",
            "pinocchietti"
        };
        private List<string> garmentFitList = new List<string>()
        {
            "slim",
            "skinny",
            "regular",
            "original"
        };

        #endregion

        #region Properties

        //Properties of Trousers class

        /// <summary>
        /// Property typology, get/set the typology of the Trousers (jeans, felpati, leggins).
        /// </summary>
        public string _garmentTypology
        {
            get
            {
                return garmentTypology;
            }
            set
            {
                if(garmentTypologyList.Contains(value.ToLower()))
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
        /// Property size, get/set the size of the Trousers (44, 46, 48...).
        /// </summary>
        public short _garmentSize
        {
            get
            {
                return garmentSize;
            }
            set
            {
                if(garmentSizeList.Contains(value))
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
        /// Property length, get/set the length of the Trousers (lunghi, corti ...).
        /// </summary>
        public string _garmentLength
        {
            get
            {
                return garmentLength;
            }
            set
            {
                if (garmentLengthList.Contains(value.ToLower()))
                {
                    garmentLength = value.ToLower();
                }
                else
                {
                    throw new Exception("Error with your length input");
                }
            }
        }

        /// <summary>
        /// Property fit, get/set the fit of the Trousers (slim, skinny ...).
        /// </summary>
        public string _garmentFit
        {
            get
            {
                return garmentFit;
            }
            set
            {
                if (garmentFitList.Contains(value.ToLower()))
                {
                    garmentFit = value.ToLower();
                }
                else
                {
                    throw new Exception("Error with your fit input");
                }
            }
        }

        /// <summary>
        /// Get garmentTypologyList, this list contains all possibility for set the Trousers type.
        /// </summary>
        public List<string> _garmentTypologyList
        {
            get
            {
                return garmentTypologyList;
            }
        }

        /// <summary>
        /// Get garmentSizeList, this list contains all possibility for set the size of the trousers.
        /// </summary>
        public List<short> _garmentSizeList
        {
            get
            {
                return garmentSizeList; 
            }
        }

        /// <summary>
        /// Get garmentLengthList, this list contains all possibility for set the length of the trousers.
        /// </summary>
        public List<string> _garmentLengthList
        {
            get
            {
                return garmentLengthList;
            }
        }

        /// <summary>
        /// Get garmentFitList, this list contains all possibility for set the fit of the trousers.
        /// </summary>
        public List<string> _garmentFitList
        {
            get
            {
                return garmentFitList;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Method for optain garment properties.
        /// </summary>
        /// <returns>String with all data of Trousers + base class, separated by semicolon.</returns>
        public override string viewDataOfGfarmentClass()
        {
            string stringData = base.viewDataOfGfarmentClass() + ";";

            stringData += garmentTypology + ";";
            stringData += garmentSize + ";";
            stringData += garmentLength + ";";
            stringData += garmentFit;

            return stringData; //==> return string with Trousers + base class data
        }

        #endregion
    }
}
