using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Controls;

namespace MyXtraGrid {
    public partial class Form1 : Form {

        private DataTable CreateTable(int RowCount)
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add("Name", typeof(string));
            tbl.Columns.Add("ID", typeof(int));
            tbl.Columns.Add("Number", typeof(int));
            tbl.Columns.Add("Date", typeof(DateTime));
            for (int i = 0; i < RowCount; i++)
                tbl.Rows.Add(new object[] { String.Format("Name{0}", i), i, 3 - i, DateTime.Now.AddDays(i) });
            return tbl;
        }
        

        public Form1() {
            InitializeComponent();
            myGridControl1.DataSource = CreateTable(20);

            CheckButton showCustomButton = myGridView1.FindPanelItems.AddCheckButton("test", true);
            showCustomButton.ImageOptions.ImageUri.Uri = "Filter;Size16x16;Svg";
            showCustomButton.CheckedChanged += ShowCustomButton_CheckedChanged;
        }

        private void ShowCustomButton_CheckedChanged(object sender, EventArgs e)
        {
              MessageBox.Show("CheckButton is clicked");
        }

    }
}
