Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Controls

Namespace MyXtraGrid

    Partial Public Class Form1
        Inherits Form

        Private Function CreateTable(ByVal RowCount As Integer) As DataTable
            Dim tbl As DataTable = New DataTable()
            tbl.Columns.Add("Name", GetType(String))
            tbl.Columns.Add("ID", GetType(Integer))
            tbl.Columns.Add("Number", GetType(Integer))
            tbl.Columns.Add("Date", GetType(Date))
            For i As Integer = 0 To RowCount - 1
                tbl.Rows.Add(New Object() {String.Format("Name{0}", i), i, 3 - i, Date.Now.AddDays(i)})
            Next

            Return tbl
        End Function

        Public Sub New()
            InitializeComponent()
            myGridControl1.DataSource = CreateTable(20)

            Dim showCustomButton As CheckButton = myGridView1.FindPanelItems.AddCheckButton("test", True)
            showCustomButton.ImageOptions.ImageUri.Uri = "Filter;Size16x16;Svg"
            AddHandler showCustomButton.CheckedChanged, AddressOf ShowCustomButton_CheckedChanged
        End Sub

        Private Sub ShowCustomButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            MessageBox.Show("CheckButton is clicked")
        End Sub

    End Class
End Namespace
