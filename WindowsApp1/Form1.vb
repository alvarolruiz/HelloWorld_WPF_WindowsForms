Public Class Form1
    ''' <summary>
    ''' // Evento asociado al click del botón saludr que muestra un mensaje de texto
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles btnClickThis.Click

        Dim nombre As String
        nombre = TextBox1.Text
        MessageBox.Show("Hola mundo " + nombre, "Saludo", MessageBoxButtons.OKCancel)



    End Sub
End Class
