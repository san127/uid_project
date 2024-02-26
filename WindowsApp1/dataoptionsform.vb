Public Class dataoptionsform
    Private Sub addstDBpic_Click(sender As Object, e As EventArgs)
        Me.Hide()
        pharmacistMenu1.Show()
    End Sub

    Private Sub delStDbpic_Click(sender As Object, e As EventArgs)
        Me.Hide()
        deleteMedForm.Show()
    End Sub

    Private Sub viewdbPic_Click(sender As Object, e As EventArgs) Handles viewdbPic.Click
        Me.Close()
        viewMedsForm.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
        supplierMgmtForm.Show()
    End Sub

    Private Sub ordMgmtPic_Click(sender As Object, e As EventArgs) Handles ordMgmtPic.Click
        Me.Close()
        orderMgmtForm.Show()
    End Sub
End Class