Public Class phamacistOptsform
    Private Sub addstDBpic_Click(sender As Object, e As EventArgs) Handles addstDBpic.Click
        Me.Hide()
        pharmacistMenu1.Show()
    End Sub

    Private Sub delStDbpic_Click(sender As Object, e As EventArgs) Handles delStDbpic.Click
        Me.Hide()
        deleteMedForm.Show()
    End Sub

    Private Sub viewdbPic_Click(sender As Object, e As EventArgs) Handles viewdbPic.Click
        Me.Hide()
        viewMedsForm.Show()
    End Sub

    Private Sub updDBpic_Click(sender As Object, e As EventArgs) Handles updDBpic.Click
        Me.Hide()
        updateStockForm.Show()
    End Sub

End Class