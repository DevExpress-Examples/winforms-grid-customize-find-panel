Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid

Namespace MyXtraGrid
	Public Class MyGridHandler
		Inherits DevExpress.XtraGrid.Views.Grid.Handler.GridHandler
		Public Sub New(ByVal gridView As GridView)
			MyBase.New(gridView)
		End Sub


	End Class
End Namespace
