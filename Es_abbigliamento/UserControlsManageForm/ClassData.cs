using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Es_abbigliamento.UserControlsManageForm
{
    /// <summary>
    /// Static class with fields, properties and methods for manage data(file: .txt, .xml).
    /// </summary>
    internal static class ClassData
    {
        //fields
        private static readonly string fileStockSave = "fileStock.txt";  //==> file where save data
        private static readonly string fileInfoSave = "fileInfo.txt";  //==> file where save info

        //properties

        /// <summary>
        /// Get the path of the file where data is saved.
        /// </summary>
        public static string _fileStockSave
        {
            get { return fileStockSave; }
        }

        /// <summary>
        /// Get the path of file where info is saved.
        /// </summary>
        public static string _fileInfoSave
        {
            get { return fileInfoSave; }
        }

        //
        //Methods
        //

        /// <summary>
        /// Function for get the last id from fileInfo.txt.
        /// </summary>
        /// <returns>The last id</returns>
        public static int funLastIdInfoFile()
        {
            File.SetAttributes(fileInfoSave, FileAttributes.Normal);

            int lastId = 0;

            string[] linesCollection = File.ReadAllLines(fileInfoSave);

            for(int i=0; i<linesCollection.Length; i++)
            {
                string line = linesCollection[i];
                string[] lineArraySplit = line.Split(':');

                if(lineArraySplit[0] == "LASTID")
                {
                    lastId = Convert.ToInt32(lineArraySplit[1]);
                    lastId += 1;

                    linesCollection[i] = "LASTID:" + lastId.ToString();
                }
                
            }

            File.WriteAllLines(fileInfoSave, linesCollection);

            File.SetAttributes(fileInfoSave, FileAttributes.Hidden);

            return lastId;
        }

        /// <summary>
        /// Function for get the last id from fileStock.txt.
        /// </summary>
        /// <returns>The last id</returns>
        public static int funLastIdStockFile()
        {
            int lastId = -1;

            FileInfo infoOfFileStock = new FileInfo(fileStockSave);
            if(infoOfFileStock.Length > 0)
            {
                var lines = File.ReadLines(fileStockSave).Last();
                string[] lastLine = lines.Split(';');

                lastId = Convert.ToInt32(lastLine[0]);
            }

            return lastId;
        }
    
        /// <summary>
        /// Modify the data in filestock.
        /// </summary>
        /// <param name="garment"></param>
        /// <returns></returns>
        public static bool modifyGarmentStock(Garment garment)
        {
            bool modify = true;

            var fileLines = File.ReadLines(fileStockSave).ToList();

            for (int i = 0; i < fileLines.Count(); i++)
            {
                string[] arraySplitLine = fileLines[i].Split(';');

                if (Convert.ToInt32(arraySplitLine[0]) == garment._garmentId)
                {
                    try
                    {
                        fileLines.RemoveAt(i);

                        switch (garment.garmentClassTypeString)
                        {
                            case "Bag":
                                fileLines.Insert(i, (garment as Bag).viewDataOfGfarmentClass());
                                break;
                            case "Jackets":
                                fileLines.Insert(i, (garment as Jackets).viewDataOfGfarmentClass());
                                break;
                            case "Shoe":
                                fileLines.Insert(i, (garment as Shoe).viewDataOfGfarmentClass());
                                break;
                            case "Sweater":
                                fileLines.Insert(i, (garment as Sweater).viewDataOfGfarmentClass());
                                break;
                            case "Trousers":
                                fileLines.Insert(i, (garment as Trousers).viewDataOfGfarmentClass());
                                break;
                        }
                    }
                    catch(Exception ex)
                    {
                        modify = false;
                    }


                    break;
                }
            }

            File.WriteAllLines(fileStockSave, fileLines);

            return modify;
        }

        /// <summary>
        /// Delete line from stock file;
        /// </summary>
        /// <param name="garmentId"></param>
        /// <returns></returns>
        public static bool deleteGarmentFromStock(int garmentId)
        {
            bool deleteIsCompleted = false;

            var fileLines = File.ReadLines(fileStockSave).ToList();

            for(int i = 0; i < fileLines.Count(); i++)
            {
                string[] arraySplitLine = fileLines[i].Split(';');

                if(Convert.ToInt32(arraySplitLine[0]) == garmentId)
                {
                    fileLines.RemoveAt(i);

                    deleteIsCompleted = true;

                    break;
                }
            }

            File.WriteAllLines(fileStockSave, fileLines);

            return deleteIsCompleted;
        }
    
        /// <summary>
        /// Read all line from stockFile
        /// </summary>
        /// <returns></returns>
        public static List<Garment> readGarmentDataFromStock()
        {
            List<Garment> garmentsList = new List<Garment>();

            foreach(string garment in File.ReadLines(fileStockSave))
            {
                garmentsList.Add(identifyGarmentType(garment));
            }

            return garmentsList;
        }

        /// <summary>
        /// Read last 10 line from stockFile.
        /// </summary>
        /// <returns></returns>
        public static List<Garment> readLastGarmentFromStock(int countLastLine)
        {
            List<Garment> garmentsList = new List<Garment>();

            var fileLines = File.ReadLines(fileStockSave).Reverse();

            foreach (string garment in fileLines)
            {
                if(countLastLine > 0)
                {
                    garmentsList.Add(identifyGarmentType(garment));

                    countLastLine--;
                }
                else
                {
                    break;
                }
            }

            return garmentsList;
        }

        /// <summary>
        /// Get the number of garment in your stock file.
        /// </summary>
        /// <returns></returns>
        public static int getNumberOfGarment()
        {
            int count;

            count = File.ReadLines(fileStockSave).Count();

            return count;
        }

        /// <summary>
        /// Return garment object, execute downcast for optaine shoe, jacket, sweater.. .
        /// </summary>
        /// <param name="garmentDataString"></param>
        /// <returns></returns>
        public static Garment identifyGarmentType(string garmentDataString)
        {
            Garment garmentObject = new Garment();

            string[] arrayGarmentData = garmentDataString.Split(';');

            switch (arrayGarmentData[1])
            {
                case "Bag":

                    Bag bag = new Bag();

                    setBasePropertiesGarment((Garment)bag, arrayGarmentData);
                    bag._garmentClassType = typeof(Bag);

                    bag._garmentTypology = arrayGarmentData[7];
                    bag._garmentSize = arrayGarmentData[8];
                    bag._garmentSeason = arrayGarmentData[9];

                    garmentObject = bag;

                    break;
                case "Jackets":

                    Jackets jackets = new Jackets();

                    setBasePropertiesGarment((Garment)jackets, arrayGarmentData);
                    jackets._garmentClassType = typeof(Jackets);

                    jackets._garmentTypology = arrayGarmentData[7];
                    jackets._garmentSize = arrayGarmentData[8];
                    jackets._garmentSeason = arrayGarmentData[9];

                    garmentObject = jackets;

                    break;
                case "Shoe":

                    Shoe shoe = new Shoe();

                    setBasePropertiesGarment((Garment)shoe, arrayGarmentData);
                    shoe._garmentClassType = typeof(Shoe);

                    shoe._garmentTypology = arrayGarmentData[7];
                    shoe._garmentSize = Convert.ToInt16(arrayGarmentData[8]);
                    shoe._garmentOpeningMode = arrayGarmentData[9];
                    shoe._garmentSole = arrayGarmentData[10];

                    garmentObject = shoe;

                    break;
                case "Sweater":

                    Sweater sweater = new Sweater();

                    setBasePropertiesGarment((Garment)sweater, arrayGarmentData);
                    sweater._garmentClassType = typeof(Sweater);

                    sweater._garmentTypology = arrayGarmentData[7];
                    sweater._garmentSize = arrayGarmentData[8];
                    sweater._garmentSleeve = arrayGarmentData[9];
                    sweater._garmentOpeningMode = arrayGarmentData[10];

                    garmentObject = sweater;

                    break;
                case "Trousers":

                    Trousers trousers = new Trousers();

                    setBasePropertiesGarment((Garment)trousers, arrayGarmentData);
                    trousers._garmentClassType = typeof(Trousers);

                    trousers._garmentTypology = arrayGarmentData[7];
                    trousers._garmentSize = Convert.ToInt16(arrayGarmentData[8]);
                    trousers._garmentLength = arrayGarmentData[9];
                    trousers._garmentFit = arrayGarmentData[10];

                    garmentObject = trousers;

                    break;
            }

            return garmentObject;
        }

        /// <summary>
        /// Call this function for set base properties of garment. 
        /// </summary>
        /// <param name="garmentObj"></param>
        /// <param name="arrayData"></param>
        private static void setBasePropertiesGarment(Garment garmentObj, string[] arrayData)
        {
            garmentObj._garmentId = Convert.ToInt32(arrayData[0]);
            garmentObj._garmentBrand = arrayData[2];
            garmentObj._garmentPrice = Convert.ToDouble(arrayData[3]);
            garmentObj._garmentColor = arrayData[4];            
            garmentObj._garmentMaterial = arrayData[5];
            garmentObj._garmentType = arrayData[6];
        }
    }
}
