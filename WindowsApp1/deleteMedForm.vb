Imports Devart.Data.MySql

Public Class deleteMedForm
    Private Sub deleteMedForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PharmaDataSet.meds_inventory' table. You can move, or remove it, as needed.
        Me.Meds_inventoryTableAdapter.Fill(Me.PharmaDataSet.meds_inventory)

    End Sub

    Private Sub deleteMed_btn_Click(sender As Object, e As EventArgs) Handles deleteMed_btn.Click
        If (delMed_txbx.Text.Length.Equals(0) = True) Then
            MessageBox.Show("Please provide Medicine ID", "information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Dim Query As String
        Query = "DELETE FROM meds_inventory WHERE Med_ID=@Med_ID;"
        Dim Connec As MySqlConnection = New MySqlConnection("Data Source=localhost;Database=pharma;UserId=root;Password=MER@sql69420;")

        Dim cmd As MySqlCommand = New MySqlCommand(Query, Connec)
        cmd.Parameters.AddWithValue("@Med_ID", Val(delMed_txbx.Text))

        Try
            Connec.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Medicine removed successfully")
            Me.Meds_inventoryTableAdapter.Fill(Me.PharmaDataSet.meds_inventory)
        Catch ex As Exception
            MsgBox("Error : " & ex.Message)
        Finally
            Connec.Close()
        End Try
        End If
    End Sub

    Private Sub adminMenu_back_Click(sender As Object, e As EventArgs) Handles adminMenu_back.Click
        Me.Close()
        phamacistOptsform.Show()
    End Sub
End Class