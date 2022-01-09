using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Xml.Serialization;


namespace Es_abbigliamento.UserControlsManageForm
{
    /// <summary>
    /// Class for use xml.
    /// </summary>
    internal static class ManageXml
    {
        //
        // XML
        //

        /// <summary>
        /// Download the data of garmentParam. Data is downloaded in xml format.
        /// </summary>
        /// <param name="garmentParam"></param>
        /// <returns></returns>
        public static bool garmentDataXML(Garment garmentParam)
        {
            bool downloadComplete = true;

            XmlTextWriter xmlWrt = new XmlTextWriter("indumento.Id." + garmentParam._garmentId.ToString() + ".xml", null);

            xmlWrt.WriteStartDocument();
            xmlWrt.Formatting = Formatting.Indented;
            xmlWrt.Indentation = 2;

            xmlWrt.WriteStartElement("Indumento");

            #region Create XML

            try
            {
                switch (garmentParam.garmentClassTypeString)
                {
                    case "Bag":
                        xmlWrt.WriteStartElement("Borsa");
                        xmlWrt.WriteElementString("Id", garmentParam._garmentId.ToString());
                        xmlWrt.WriteElementString("Brand", garmentParam._garmentBrand.ToString());
                        xmlWrt.WriteElementString("Price", garmentParam._garmentPrice.ToString());
                        xmlWrt.WriteElementString("Id", garmentParam._garmentId.ToString());
                        xmlWrt.WriteElementString("Id", garmentParam._garmentId.ToString());
                        xmlWrt.WriteElementString("Type", garmentParam._garmentType.ToString());
                        xmlWrt.WriteElementString("Class", garmentParam.garmentClassTypeString.ToString());

                        Bag bag = garmentParam as Bag;

                        xmlWrt.WriteElementString("Typology", bag._garmentTypology);
                        xmlWrt.WriteElementString("Size", bag._garmentSize);
                        xmlWrt.WriteElementString("Season", bag._garmentSeason);
                        xmlWrt.WriteEndElement();
                        break;
                    case "Jackets":
                        xmlWrt.WriteStartElement("Giacca");
                        xmlWrt.WriteElementString("Id", garmentParam._garmentId.ToString());
                        xmlWrt.WriteElementString("Brand", garmentParam._garmentBrand.ToString());
                        xmlWrt.WriteElementString("Price", garmentParam._garmentPrice.ToString());
                        xmlWrt.WriteElementString("Id", garmentParam._garmentId.ToString());
                        xmlWrt.WriteElementString("Id", garmentParam._garmentId.ToString());
                        xmlWrt.WriteElementString("Type", garmentParam._garmentType.ToString());
                        xmlWrt.WriteElementString("Class", garmentParam.garmentClassTypeString.ToString());

                        Jackets jackets = garmentParam as Jackets;

                        xmlWrt.WriteElementString("Typology", jackets._garmentTypology);
                        xmlWrt.WriteElementString("Size", jackets._garmentSize);
                        xmlWrt.WriteElementString("Season", jackets._garmentSeason);
                        xmlWrt.WriteEndElement();
                        break;
                    case "Shoe":
                        xmlWrt.WriteStartElement("Scarpe");
                        xmlWrt.WriteElementString("Id", garmentParam._garmentId.ToString());
                        xmlWrt.WriteElementString("Brand", garmentParam._garmentBrand.ToString());
                        xmlWrt.WriteElementString("Price", garmentParam._garmentPrice.ToString());
                        xmlWrt.WriteElementString("Id", garmentParam._garmentId.ToString());
                        xmlWrt.WriteElementString("Id", garmentParam._garmentId.ToString());
                        xmlWrt.WriteElementString("Type", garmentParam._garmentType.ToString());
                        xmlWrt.WriteElementString("Class", garmentParam.garmentClassTypeString.ToString());

                        Shoe shoe = garmentParam as Shoe;

                        xmlWrt.WriteElementString("Typology", shoe._garmentTypology);
                        xmlWrt.WriteElementString("Size", shoe._garmentSize.ToString());
                        xmlWrt.WriteElementString("Opening Mode", shoe._garmentOpeningMode);
                        xmlWrt.WriteElementString("Sole", shoe._garmentSole);
                        xmlWrt.WriteEndElement();
                        break;
                    case "Sweater":
                        xmlWrt.WriteStartElement("Maglia");
                        xmlWrt.WriteElementString("Id", garmentParam._garmentId.ToString());
                        xmlWrt.WriteElementString("Brand", garmentParam._garmentBrand.ToString());
                        xmlWrt.WriteElementString("Price", garmentParam._garmentPrice.ToString());
                        xmlWrt.WriteElementString("Id", garmentParam._garmentId.ToString());
                        xmlWrt.WriteElementString("Id", garmentParam._garmentId.ToString());
                        xmlWrt.WriteElementString("Type", garmentParam._garmentType.ToString());
                        xmlWrt.WriteElementString("Class", garmentParam.garmentClassTypeString.ToString());

                        Sweater sweater = garmentParam as Sweater;

                        xmlWrt.WriteElementString("Typology", sweater._garmentTypology);
                        xmlWrt.WriteElementString("Size", sweater._garmentSize.ToString());
                        xmlWrt.WriteElementString("Manica", sweater._garmentSleeve);
                        xmlWrt.WriteElementString("Opening Mode", sweater._garmentOpeningMode);
                        xmlWrt.WriteEndElement();
                        break;
                    case "Trousers":
                        xmlWrt.WriteStartElement("Borsa");
                        xmlWrt.WriteElementString("Id", garmentParam._garmentId.ToString());
                        xmlWrt.WriteElementString("Brand", garmentParam._garmentBrand.ToString());
                        xmlWrt.WriteElementString("Price", garmentParam._garmentPrice.ToString());
                        xmlWrt.WriteElementString("Id", garmentParam._garmentId.ToString());
                        xmlWrt.WriteElementString("Id", garmentParam._garmentId.ToString());
                        xmlWrt.WriteElementString("Type", garmentParam._garmentType.ToString());
                        xmlWrt.WriteElementString("Class", garmentParam.garmentClassTypeString.ToString());

                        Trousers trousers = garmentParam as Trousers;

                        xmlWrt.WriteElementString("Typology", trousers._garmentTypology);
                        xmlWrt.WriteElementString("Size", trousers._garmentSize.ToString());
                        xmlWrt.WriteElementString("Lunghezza", trousers._garmentLength);
                        xmlWrt.WriteElementString("Vestibilità", trousers._garmentFit);
                        xmlWrt.WriteEndElement();
                        break;
                }
            }
            catch (Exception)
            {
                downloadComplete = false;
            }

            xmlWrt.WriteEndElement();
            xmlWrt.Close();

            #endregion

            return downloadComplete;
        }
    }
}
