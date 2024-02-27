Imports Devart.Data.MySql

Public Class orderMgmtForm
    Private Sub orderMgmtForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PharmaDataSet.meds_order' table. You can move, or remove it, as needed.
        Me.Meds_orderTableAdapter.Fill(Me.PharmaDataSet.meds_order)

    End Sub

    Private Sub order_addBtn_Click(sender As Object, e As EventArgs) Handles order_addBtn.Click
        Dim Query As String
        Query = "INSERT INTO meds_order VALUES (@Ord_ID,@m_name,@ord_qty,@sup_ID);"
        Dim Connec As MySqlConnection = New MySqlConnection("Data Source=localhost;Database=pharma;UserId=root;Password=MER@sql69420;")

        Dim cmd As MySqlCommand = New MySqlCommand(Query, Connec)
        cmd.Parameters.AddWithValue("@Ord_ID", ordId_txbx.Text)
        cmd.Parameters.AddWithValue("@m_name", medName_txbx.Text)
        cmd.Parameters.AddWithValue("@ord_qty", ordqty_txbx.Text)
        cmd.Parameters.AddWithValue("@sup_ID", ordSup_txbx.Text)

        Try
            Connec.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Supplier added successfully")
            Me.Meds_orderTableAdapter.Fill(Me.PharmaDataSet.meds_order)
        Catch ex As Exception
            MsgBox("Error : " & ex.Message)
        Finally
            Connec.Close()
        End Try
    End Sub
End Class