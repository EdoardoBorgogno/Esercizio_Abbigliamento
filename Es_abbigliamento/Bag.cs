using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_abbigliamento
{
    /// <summary>
    /// Bag Class.
    /// </summary>
    internal class Bag : Garment
    {
        //Bag class ==> inheritance Garment base class

        //Fields
        private string garmentTypology;
        private string garmentSize;
        private string garmentSeason;

        #region Garment element list

        //List with garment typology

        private List<string> garmentTypologyList = new List<string>()
        {
            "tracolla",
            "zainetto",
            "marsupio",
            "pochette"
        };
        private List<string> garmentSizeList = new List<string>()
        {
            "piccola",
            "media",
            "grande"
        };
        private List<string> garmentSeasonList = new List<string>()
        {
            "estate",
            "inverno"
        };

        #endregion

        #region Properties

        /// <summary>
        /// Property typology, get/set the typology of the bag (marsupio, zainetto).
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
        /// Property size, get/set the size of the bag (media, grande).
        /// </summary>
        public string _garmentSize
        {
            get
            {
                return garmentSize;
            }
            set
            {
                if (garmentSizeList.Contains(value.ToLower()))
                {
                    garmentSize = value.ToLower();
                }
                else
                {
                    throw new Exception("Error with your size input");
                }
            }
        }

        /// <summary>
        /// Property season, get/set the season of the bag (inverno, estate).
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
        /// Get garmentTypologyList, this list contains all possibility for set the bag type.
        /// </summary>
        public List<string> _garmentTypologyList
        {
            get
            {
                return garmentTypologyList;
            }
        }

        /// <summary>
        /// Get garmentSizeList, this list contains all possibility for set the bag size.
        /// </summary>
        public List<string> _garmentSizeList
        {
            get
            {
                return garmentSizeList;
            }
        }

        /// <summary>
        /// Get garmentSeasonList, this list contains all possibility for set the bag season.
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
        /// <returns>String with all data of bag + base class, separated by semicolon.</returns>
        public override string viewDataOfGfarmentClass()
        {
            string stringData = base.viewDataOfGfarmentClass() + ";";

            stringData += garmentTypology + ";";
            stringData += garmentSize + ";";
            stringData += garmentSeason;

            return stringData; //==> return string with bag + base class data
        }

        #endregion
    }
}
