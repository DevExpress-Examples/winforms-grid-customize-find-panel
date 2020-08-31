Imports System

Namespace MyXtraGrid

    <System.ComponentModel.DesignerCategory("")> _
    Public Class MyGridView
        Inherits DevExpress.XtraGrid.Views.Grid.GridView

        Public Sub New()
            Me.New(Nothing)
        End Sub
        Public Sub New(ByVal grid As DevExpress.XtraGrid.GridControl)
            MyBase.New(grid)
            ' put your initialization code here
        End Sub
        Protected Overrides ReadOnly Property ViewName() As String
            Get
                Return "MyGridView"
            End Get
        End Property

        Protected Overrides Function CreateFindPanel(ByVal findPanelProperties As Object) As DevExpress.XtraGrid.Controls.FindControl
            Return New MyFindControl(Me, findPanelProperties)
        End Function
    End Class
End Namespace
