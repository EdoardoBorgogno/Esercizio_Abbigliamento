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
        /// 
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
    }
}
