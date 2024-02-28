Imports Devart.Data.MySql

Public Class POSform

    Dim MedIdValue As String
    Dim count, medamt, medqty, ID As Integer
    Dim total As Integer = 0

    Private Sub CheckMedicineExists(medicineName As String)
        Using connection As New MySqlConnection("Data Source=localhost;Database=pharma;UserId=root;Password=MER@sql69420;")
            connection.Open()

            ' First, check if the medicine exists
            Dim queryExists As String = "SELECT COUNT(*) FROM meds_inventory WHERE Medicine = @MedicineName"
            Using commandExists As New MySqlCommand(queryExists, connection)
                commandExists.Parameters.AddWithValue("@MedicineName", medicineName)
                Dim itemCount As Integer = Convert.ToInt32(commandExists.ExecuteScalar())

                If itemCount > 0 Then
                    ' If the medicine exists, retrieve the Med_ID
                    Dim queryGetMedId As String = "SELECT Med_ID FROM meds_inventory WHERE Medicine = @MedicineName"
                    Using commandGetMedId As New MySqlCommand(queryGetMedId, connection)
                        commandGetMedId.Parameters.AddWithValue("@MedicineName", medicineName)
                        Dim medId As Integer = Convert.ToInt32(commandGetMedId.ExecuteScalar())

                        ' Display information or use the medId as needed
                        MessageBox.Show($"Medicine available. Med_ID: {medId}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        MedIdValue = medId
                    End Using
                Else
                    MessageBox.Show("Medicine not available", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        End Using
    End Sub


    Private Sub POSform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PharmaDataSet.meds_inventory' table. You can move, or remove it, as needed.
        Me.Meds_inventoryTableAdapter.Fill(Me.PharmaDataSet.meds_inventory)

    End Sub

    Private Sub searchMed_btn_Click(sender As Object, e As EventArgs) Handles searchMed_btn.Click
        CheckMedicineExists(searchMed_txbx.Text)
        searchMed_txbx.Clear()
    End Sub

    Private Sub add_billBTN_Click(sender As Object, e As EventArgs) Handles add_billBTN.Click
        ' Add connections
        Dim Query As String
        Query = "SELECT Medicine, Price FROM meds_inventory WHERE Med_ID = @Med_ID;"
        Dim Connec As MySqlConnection = New MySqlConnection("Data Source=localhost;Database=pharma;UserId=root;Password=MER@sql69420;")

        Try
            Connec.Open()

            Dim cmd As MySqlCommand = New MySqlCommand(Query, Connec)
            cmd.Parameters.AddWithValue("@Med_ID", Val(MedIdValue))

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                ' Read the medicine information
                Dim medName As String = reader("Medicine")
                Dim medPrice As Integer = Convert.ToInt32(reader("Price"))

                ' Get quantity from the TextBox
                Dim medQty As Integer = Val(medqty_txbx.Text)

                ' Calculate the amount for the current medicine
                Dim medAmt As Integer = medPrice * medQty

                ' Update the billing information in the TextBox
                bill_txbx.Text = $"{medName} ----- {medPrice} x {medQty} = {medAmt} {Environment.NewLine}{bill_txbx.Text}"

                ' Update the total amount
                tot_label.Text = (Val(tot_label.Text) + medAmt).ToString()
            Else
                MessageBox.Show("Medicine information not found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
                searchMed_txbx.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close the connection
            Connec.Close()
        End Try

    End Sub

End Class