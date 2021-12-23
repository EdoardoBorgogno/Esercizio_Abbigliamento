using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_abbigliamento
{
    /// <summary>
    /// Jackets Class.
    /// </summary>
    internal class Jackets : Garment
    {
        //Jackets class ==> inheritance Garment base class

        //Fields
        private string garmentTypology;
        private string garmentSize;
        private string garmentSeason;

        //Constructor
        public Jackets() : base()
        {
            garmentTypology = String.Empty;
            garmentSize = String.Empty;
            garmentSeason = String.Empty;
            _garmentClassType = typeof(Jackets);
        }

        #region Garment element list

        //List with garment typology

        private List<string> garmentTypologyList = new List<string>()
        {
            "impermeabile",
            "piumino",
            "giacca",
            "kway",
            "giubbotto",
            "cappotto"
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
        private List<string> garmentSeasonList = new List<string>()
        {
            "estate",
            "inverno"
        };

        #endregion

        #region Properties

        /// <summary>
        /// Property typology, get/set the typology of the Jacket (piumino, kway, cappotto).
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
        /// Property size, get/set the size of the jacket (XS, S, M, L...).
        /// </summary>
        public string _garmentSize
        {
            get
            {
                return garmentSize;
            }
            set
            {
                if (garmentSizeList.Contains(value.ToUpper()))
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
        /// Property season, get/set the season of the jacket (inverno, estate).
        /// </summary>
        public string _garmentSeason
        {
            get 
            {
                return garmentSeason; 
            }
            set
            {
                if (garmentSeasonList.Contains(value.ToLower()))
                {
                    garmentSeason = value.ToLower();
                }
                else
                {
                    throw new Exception("Error with your season input");
                }
            }
        }

        /// <summary>
        /// Get garmentTypologyList, this list contains all possibility for set the jacket type.
        /// </summary>
        public List<string> _garmentTypologyList
        {
            get 
            {  
                return garmentTypologyList;
            }
        }

        /// <summary>
        /// Get garmentSizeList, this list contains all possibility for set the jacket size.
        /// </summary>
        public List<string> _garmentSizeList
        {
            get
            {
                return garmentSizeList;
            }
        }

        /// <summary>
        /// Get garmentSeasonList, this list contains all possibility for set the jacket season.
        /// </summary>
        public List<string> _garmentSeasonList
        {
            get
            {
                return garmentSeasonList;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Method for optain garment properties.
        /// </summary>
        /// <returns>String with all data of jacket + base class, separated by semicolon.</returns>
        public override string viewDataOfGfarmentClass()
        {
            string stringData = base.viewDataOfGfarmentClass() + ";";

            stringData += garmentTypology + ";";
            stringData += garmentSize + ";";
            stringData += garmentSeason;

            return stringData; //==> return string with jacket + base class data
        }

        #endregion
    }
}
