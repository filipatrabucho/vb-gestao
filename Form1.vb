Public Class Form1
    Private Sub btnCalculo_Click(sender As Object, e As EventArgs) Handles btnCalculo.Click
        Const Valor_hora As Double = 35.0
        Dim horas As Double = CDbl(txtHoras.Text)
        Dim MObra As Double = Valor_hora * horas
        Dim partes As Double = CDbl(txtCusto.Text)
        Dim CustoTotal As Double = MObra + partes

        ListBox1.Items.Clear()
        ListBox1.Items.Add("Nome Cliente: " & txtCliente.Text)
        ListBox1.Items.Add("Mão de Obra: " & MObra.ToString("C"))
        ListBox1.Items.Add("Valor Peças: " & partes.ToString("C"))
        ListBox1.Items.Add("Total a pagar: " & CustoTotal.ToString("C"))



    End Sub
End Class
