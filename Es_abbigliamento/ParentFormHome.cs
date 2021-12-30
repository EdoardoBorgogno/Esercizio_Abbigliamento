using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using Es_abbigliamento.UserControlsManageForm;
using System.IO;
using System.Windows.Forms;

namespace Es_abbigliamento
{
    //ParentFormHome ==> Form parent of All item.
    public partial class ParentFormHome : Form
    {
        //ParentFormHome

        //Constructor
        public ParentFormHome()
        {
            InitializeComponent();
        }

        #region Design Element

        //
        //DESIGN ELEMENTS ==> all methods for change behaviors of items.
        //



        #endregion

        #region ParentFormHome Methods

        //
        // All Methods of form class
        //

        //On Load Form set view Control to HOME.
        private void ParentFormHome_Load(object sender, EventArgs e)
        {
            //File where save data
            bool fileStockExits = File.Exists(ClassData._fileStockSave);
            if (!fileStockExits)
            {
                StreamWriter sw = new StreamWriter(ClassData._fileStockSave);
                sw.Close();
            }

            //InfoFile where save info for app
            bool fileInfoExits = File.Exists(ClassData._fileInfoSave);
            FileInfo fileInfoCheckEmpty = new FileInfo(ClassData._fileInfoSave);

            if (!fileInfoExits || fileInfoCheckEmpty.Length == 0)
            {
                StreamWriter writerInfoFile = new StreamWriter(ClassData._fileInfoSave);

                writerInfoFile.WriteLine("# NON CANCELLARE #");
                writerInfoFile.WriteLine();
                writerInfoFile.WriteLine("LASTID:" + ClassData.funLastIdStockFile());

                writerInfoFile.Close();

                File.SetAttributes(ClassData._fileInfoSave, FileAttributes.Hidden);
            }

            //Show home control
            containerPanel.Controls.Add(new Home());
        }

        //Exit from application
        private void ParentFormHome_exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region Left Menu btn

        //
        // Manage left side menu
        //

        //Home Btn
        private void leftSidePanel_buttonHome_Click(object sender, EventArgs e)
        {
            containerPanel.Controls.Clear();
            containerPanel.Controls.Add(new Home());
        }

        //WorkArea btn
        private void leftSidePanel_buttonWorkArea_Click(object sender, EventArgs e)
        {
            containerPanel.Controls.Clear();
            containerPanel.Controls.Add(new WorkArea());
        }

        //Indumenti btn
        private void leftSidePanel_buttonIndumenti_Click(object sender, EventArgs e)
        {
            containerPanel.Controls.Clear();
            containerPanel.Controls.Add(new IndumentiPanel());
        }

        #endregion

        #endregion

        #region Drag Form

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        //Start drag
        private void ParentFormHome_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = Location;
        }

        //Function for set the new form position
        private void ParentFormHome_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point sub = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(sub));
            }
        }

        //end drag
        private void ParentFormHome_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        #endregion
    }
}
