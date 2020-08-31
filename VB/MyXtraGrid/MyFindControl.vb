Imports System
Imports DevExpress.XtraGrid.Controls
Imports System.Drawing
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports System.Windows.Forms
Imports DevExpress.XtraLayout
Imports DevExpress.Utils

Namespace MyXtraGrid
    Public Class MyFindControl
        Inherits FindControl

        Public Sub New(ByVal view As ColumnView, ByVal properties As Object)
            MyBase.New(view, properties)
            CustomizeControl()
        End Sub


        Private Sub CustomizeControl()
            CustomizeButtons()
            CustomizeEditor()
            CustomizeLayoutControl()
        End Sub
        Private Function FindControl(ByVal controlName As String) As Control
            Return findLayoutControl.GetControlByName(controlName)
        End Function
        Private Sub CustomizeButtons()
            FindControl("btClear").MinimumSize = New Size(100, 0)
            FindControl("btClear").Font = New Font(AppearanceObject.DefaultFont, FontStyle.Strikeout)
            FindControl("btFind").MinimumSize = New Size(100, 0)
            FindControl("btFind").Font = New Font(AppearanceObject.DefaultFont, FontStyle.Bold)
        End Sub
        Private Sub CustomizeEditor()
            Dim be As ButtonEdit = TryCast(FindControl("teFind"), ButtonEdit)
            be.Properties.Buttons.Add(New EditorButton(ButtonPredefines.Ellipsis))
            AddHandler be.ButtonClick, AddressOf be_ButtonClick
            be.Properties.NullValuePrompt = "MyCustomPanel"
            be.Properties.NullValuePromptShowForEmptyValue = True
        End Sub

        Private Sub be_ButtonClick(ByVal sender As Object, ByVal e As ButtonPressedEventArgs)
            If e.Button.Kind = ButtonPredefines.Ellipsis Then
                Using form As New Form()
                    form.ShowDialog()
                End Using
            End If
        End Sub
        Private Sub CustomizeLayoutControl()
            findLayoutControl.AllowCustomizationMenu = True
        End Sub
    End Class
End Namespace
