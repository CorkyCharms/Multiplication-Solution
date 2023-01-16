' Name:         Multiplication Project
' Purpose:      Displays a multiplication table that shows the multiplicand, multiplier, and product.
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnDoLoop_Click(sender As Object, e As EventArgs) Handles btnDoLoop.Click
        ' Displays a multiplication table.
        Dim txtNumber2 As Integer = 1
        lbMain.Items.Clear()
        lbMain.Refresh()

        Do While (txtNumber2 <= 9)
            lbMain.Items.Add(Val(txtNumber.Text) & " x " & txtNumber2 & " = " & txtNumber2 * Val(txtNumber.Text))
            txtNumber2 += 1

        Loop

    End Sub

    Private Sub btnForNext_Click(sender As Object, e As EventArgs) Handles btnForNext.Click
        ' Displays a multiplication table.
        Dim i As Integer
        lbMain.Items.Clear()
        lbMain.Refresh()

        For i = 1 To 9
            lbMain.Items.Add(Val(txtNumber.Text) & " x " & i & " = " & i * Val(txtNumber.Text))

        Next

    End Sub

    Private Sub txtNumber_Enter(sender As Object, e As EventArgs) Handles txtNumber.Enter
        txtNumber.SelectAll()
    End Sub

    Private Sub txtNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumber.KeyPress
        ' Allow only numbers and the Backspace key.

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNumber_TextChanged(sender As Object, e As EventArgs) Handles txtNumber.TextChanged
        lbMain.Text = String.Empty
        lbMain.Items.Clear()
        lbMain.Refresh()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblNameTitle.Click

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
