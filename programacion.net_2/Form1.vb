Public Class Form1
    Private Sub txtproducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtproducto.KeyPress
        'MsgBox(e.KeyChar.ToString) 'CADA QUE SE INGRESA UN DATO MUESTRA VENTANA EMERGENTE'

        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            txtvalor.Focus()
        Else
            e.Handled = True
        End If

    End Sub
    Private Sub txtvalor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtvalor.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = ChrW(8) Then
            e.Handled = False
        ElseIf e.KeyChar = ChrW(13) Then
            txtcantidad.Focus()
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtcantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcantidad.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            txtsubtotal.Text = Val(txtvalor.Text) * Val(txtcantidad.Text)
            txtdescuento.Text = Val(txtsubtotal.Text) * 20 / 100
            txtneto.Text = Val(txtsubtotal.Text) - Val(txtdescuento.Text)
        Else
            e.Handled = True
        End If
    End Sub
End Class
