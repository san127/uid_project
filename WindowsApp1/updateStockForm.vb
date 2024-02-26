Imports System.Data.SqlClient
Imports Devart.Data.MySql

Public Class updateStockForm
    Dim MedIdValue As Integer

    Private Sub CheckMedicineExists(medicineName As Integer)
        Using connection As New MySqlConnection("Data Source=localhost;Database=pharma;UserId=root;Password=MER@sql69420;")
            connection.Open()
            Dim query As String = "SELECT COUNT(*) FROM meds_inventory WHERE Med_ID = @MedicineName"
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@MedicineName", medicineName)
                Dim itemCount As Integer = Convert.ToInt32(command.ExecuteScalar())

                If itemCount > 0 Then
                    MessageBox.Show("Medicine exists in the medicine table.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    MedIdValue = medicineName
                Else
                    MessageBox.Show("Medicine does not exist in the medicine table.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        End Using
    End Sub

    Private Sub updateStockForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Meds_inventoryTableAdapter.Fill(Me.PharmaDataSet.meds_inventory)

    End Sub


    Private Sub MnameUpd_btn_Click(sender As Object, e As EventArgs) Handles MnameUpd_btn.Click
        If (medName_txbx.Text.Length.Equals(0) = True) Then
            MessageBox.Show("Please provide values", "information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim Query As String
            Query = "UPDATE meds_inventory SET Medicine = @Mname WHERE Med_ID=@Med_ID;"
            Dim Connec As MySqlConnection = New MySqlConnection("Data Source=localhost;Database=pharma;UserId=root;Password=MER@sql69420;")

            Dim cmd As MySqlCommand = New MySqlCommand(Query, Connec)
            cmd.Parameters.AddWithValue("@Mname", medName_txbx.Text)
            cmd.Parameters.AddWithValue("@Med_ID", MedIdValue)

            Try
                Connec.Open()
                cmd.ExecuteNonQuery()
                MsgBox("Medicine named successfully")
                Me.Meds_inventoryTableAdapter.Fill(Me.PharmaDataSet.meds_inventory)
            Catch ex As Exception
                MsgBox("Error : " & ex.Message)
            Finally
                Connec.Close()
            End Try
        End If
    End Sub

    Private Sub medCheck_btn_Click(sender As Object, e As EventArgs) Handles medCheck_btn.Click
        CheckMedicineExists(Val(medId_txbx.Text))
    End Sub

    Private Sub McatUpd_btn_Click(sender As Object, e As EventArgs) Handles McatUpd_btn.Click
        If (medCategory_combx.Text.Length.Equals(0) = True) Then
            MessageBox.Show("Please provide values", "information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Dim Query As String
            Query = "UPDATE meds_inventory SET Category = @Mcat WHERE Med_ID=@Med_ID;"
            Dim Connec As MySqlConnection = New MySqlConnection("Data Source=localhost;Database=pharma;UserId=root;Password=MER@sql69420;")

            Dim cmd As MySqlCommand = New MySqlCommand(Query, Connec)
            cmd.Parameters.AddWithValue("@Mcat", medCategory_combx.Text)
            cmd.Parameters.AddWithValue("@Med_ID", MedIdValue)

            Try
                Connec.Open()
                cmd.ExecuteNonQuery()
                MsgBox("Medicine category updated successfully")
                Me.Meds_inventoryTableAdapter.Fill(Me.PharmaDataSet.meds_inventory)
            Catch ex As Exception
                MsgBox("Error : " & ex.Message)
            Finally
                Connec.Close()
            End Try
        End If
    End Sub

    Private Sub MexpdtUpd_btn_Click(sender As Object, e As EventArgs) Handles MexpdtUpd_btn.Click
        If (expDate_txbx.Text.Length.Equals(0) = True) Then
            MessageBox.Show("Please provide values", "information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Dim Query As String
            Query = "UPDATE meds_inventory SET expiration_date = @MexpDate WHERE Med_ID=@Med_ID;"
            Dim Connec As MySqlConnection = New MySqlConnection("Data Source=localhost;Database=pharma;UserId=root;Password=MER@sql69420;")

            Dim cmd As MySqlCommand = New MySqlCommand(Query, Connec)
            cmd.Parameters.AddWithValue("@MexpDate", expDate_txbx.Text)
            cmd.Parameters.AddWithValue("@Med_ID", MedIdValue)

            Try
                Connec.Open()
                cmd.ExecuteNonQuery()
                MsgBox("Medicine exprity date updated successfully")
                Me.Meds_inventoryTableAdapter.Fill(Me.PharmaDataSet.meds_inventory)
            Catch ex As Exception
                MsgBox("Error : " & ex.Message)
            Finally
                Connec.Close()
            End Try
        End If
    End Sub

    Private Sub MpriceUpd_btn_Click(sender As Object, e As EventArgs) Handles MpriceUpd_btn.Click
        If (medPrice_txbx.Text.Length.Equals(0) = True) Then
            MessageBox.Show("Please provide values", "information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Dim Query As String
            Query = "UPDATE meds_inventory SET Price = @Mprice WHERE Med_ID=@Med_ID;"
            Dim Connec As MySqlConnection = New MySqlConnection("Data Source=localhost;Database=pharma;UserId=root;Password=MER@sql69420;")

            Dim cmd As MySqlCommand = New MySqlCommand(Query, Connec)
            cmd.Parameters.AddWithValue("@Mprice", medPrice_txbx.Text)
            cmd.Parameters.AddWithValue("@Med_ID", MedIdValue)

            Try
                Connec.Open()
                cmd.ExecuteNonQuery()
                MsgBox("Medicine price updated successfully")
                Me.Meds_inventoryTableAdapter.Fill(Me.PharmaDataSet.meds_inventory)
            Catch ex As Exception
                MsgBox("Error : " & ex.Message)
            Finally
                Connec.Close()
            End Try
        End If
    End Sub

    Private Sub MqtyUpd_btn_Click(sender As Object, e As EventArgs) Handles MqtyUpd_btn.Click
        If (medQty_txbx.Text.Length.Equals(0) = True) Then
            MessageBox.Show("Please provide values", "information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Dim Query As String
            Query = "UPDATE meds_inventory SET Qty = @Mqty WHERE Med_ID=@Med_ID;"
            Dim Connec As MySqlConnection = New MySqlConnection("Data Source=localhost;Database=pharma;UserId=root;Password=MER@sql69420;")

            Dim cmd As MySqlCommand = New MySqlCommand(Query, Connec)
            cmd.Parameters.AddWithValue("@Mqty", medQty_txbx.Text)
            cmd.Parameters.AddWithValue("@Med_ID", MedIdValue)

            Try
                Connec.Open()
                cmd.ExecuteNonQuery()
                MsgBox("Medicine quantity updated successfully")

                Me.Meds_inventoryTableAdapter.Fill(Me.PharmaDataSet.meds_inventory)
            Catch ex As Exception
                MsgBox("Error : " & ex.Message)
            Finally
                Connec.Close()
            End Try
        End If
    End Sub
End Class