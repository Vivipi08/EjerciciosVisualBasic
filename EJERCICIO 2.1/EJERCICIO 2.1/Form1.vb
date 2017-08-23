Public Class CONTROLES

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles ctdato.TextChanged
        ctdato.Text = "programacion de software"
        Dim sTexto As String = ctdato.Text


    End Sub

    Private Sub BtAñadir_Click(sender As Object, e As EventArgs) Handles BtAñadir.Click
        If (ctdato.Text <> "") Then IsLista.Items.Add(ctdato.Text)
    End Sub

    Private Sub CVCURSIVA_CheckedChanged(sender As Object, e As EventArgs) Handles CVCURSIVA.CheckedChanged
        If (CVCURSIVA.Checked) Then
            ctdato.Font = New Font("microsoft sans serif", 8.25!, FontStyle.Italic)

        Else

            ctdato.Font = New Font("microsoft sans serif", 8.25!, FontStyle.Regular)

        End If
    End Sub

    Private Sub BoLectura_CheckedChanged(sender As Object, e As EventArgs) Handles BoLectura.CheckedChanged
        If (BoLectura.Checked) Then ctdato.ReadOnly = False
        If (BoEscritura.Checked) Then ctdato.ReadOnly = True
    End Sub



    Private Sub HScrollBar1_Scroll_1(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        ctdato.ForeColor = Color.FromArgb(HScrollBar1.Value, HScrollBar1.Value, HScrollBar1.Value)
    End Sub

    Private Sub IsLista_SelectedIndexChanged(sender As Object, e As EventArgs) Handles IsLista.SelectedIndexChanged
        ctdato.Text = IsLista.SelectedItem
    End Sub

    Private Sub itOpcionesSalir_Click(sender As Object, e As EventArgs) Handles itOpcionesSalir.Click
        Close()
    End Sub

    Private Sub itOpcionesColor_Click(sender As Object, e As EventArgs) Handles itOpcionesColor.Click
        dlgcolor.Color = ctdato.BackColor

        If (dlgcolor.ShowDialog() = DialogResult.OK) Then

            ctdato.BackColor = dlgcolor.Color

        End If
    End Sub

    Private Sub itAyudaAcercaDe_Click(sender As Object, e As EventArgs) Handles itAyudaAcercaDe.Click
        MessageBox.Show("Aplicacion Saludo Version 1.0" + Environment.NewLine + "Copyright(c)Fco Natalia Camargo,2017", "acerca del saludo", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
