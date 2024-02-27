Public Class orderMgmtForm
    Private Sub orderMgmtForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PharmaDataSet.meds_order' table. You can move, or remove it, as needed.
        Me.Meds_orderTableAdapter.Fill(Me.PharmaDataSet.meds_order)

    End Sub

    Private Sub order_addBtn_Click(sender As Object, e As EventArgs) Handles order_addBtn.Click

    End Sub
End Class