<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class updateStockForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.adminMenu_back = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.updateMeds_DG = New System.Windows.Forms.DataGridView()
        Me.MedIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicineDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpirationdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Meds_inventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PharmaDataSet = New WindowsApp1.pharmaDataSet()
        Me.medCategory_combx = New System.Windows.Forms.ComboBox()
        Me.MedsinventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PharmaDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.medQty_txbx = New System.Windows.Forms.TextBox()
        Me.medPrice_txbx = New System.Windows.Forms.TextBox()
        Me.expDate_txbx = New System.Windows.Forms.TextBox()
        Me.medName_txbx = New System.Windows.Forms.TextBox()
        Me.medId_txbx = New System.Windows.Forms.TextBox()
        Me.Meds_inventoryTableAdapter = New WindowsApp1.pharmaDataSetTableAdapters.meds_inventoryTableAdapter()
        Me.medCheck_btn = New System.Windows.Forms.Button()
        Me.MnameUpd_btn = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.McatUpd_btn = New System.Windows.Forms.Button()
        Me.MexpdtUpd_btn = New System.Windows.Forms.Button()
        Me.MpriceUpd_btn = New System.Windows.Forms.Button()
        Me.MqtyUpd_btn = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.updateMeds_DG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Meds_inventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PharmaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedsinventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PharmaDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(274, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 19)
        Me.Label8.TabIndex = 85
        Me.Label8.Text = "UPDATE MEDICINES"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FloralWhite
        Me.Label1.Location = New System.Drawing.Point(227, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PharmExcel"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.adminMenu_back)
        Me.Panel2.Location = New System.Drawing.Point(-1, 590)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(692, 22)
        Me.Panel2.TabIndex = 46
        '
        'adminMenu_back
        '
        Me.adminMenu_back.BackColor = System.Drawing.Color.SkyBlue
        Me.adminMenu_back.Location = New System.Drawing.Point(309, -2)
        Me.adminMenu_back.Name = "adminMenu_back"
        Me.adminMenu_back.Size = New System.Drawing.Size(75, 22)
        Me.adminMenu_back.TabIndex = 24
        Me.adminMenu_back.Text = "Back"
        Me.adminMenu_back.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(692, 75)
        Me.Panel1.TabIndex = 45
        '
        'updateMeds_DG
        '
        Me.updateMeds_DG.AutoGenerateColumns = False
        Me.updateMeds_DG.BackgroundColor = System.Drawing.Color.LightCyan
        Me.updateMeds_DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.updateMeds_DG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MedIDDataGridViewTextBoxColumn, Me.MedicineDataGridViewTextBoxColumn, Me.CategoryDataGridViewTextBoxColumn, Me.ExpirationdateDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.QtyDataGridViewTextBoxColumn})
        Me.updateMeds_DG.DataSource = Me.Meds_inventoryBindingSource
        Me.updateMeds_DG.Location = New System.Drawing.Point(12, 89)
        Me.updateMeds_DG.Name = "updateMeds_DG"
        Me.updateMeds_DG.Size = New System.Drawing.Size(666, 209)
        Me.updateMeds_DG.TabIndex = 47
        '
        'MedIDDataGridViewTextBoxColumn
        '
        Me.MedIDDataGridViewTextBoxColumn.DataPropertyName = "Med_ID"
        Me.MedIDDataGridViewTextBoxColumn.HeaderText = "Med_ID"
        Me.MedIDDataGridViewTextBoxColumn.Name = "MedIDDataGridViewTextBoxColumn"
        '
        'MedicineDataGridViewTextBoxColumn
        '
        Me.MedicineDataGridViewTextBoxColumn.DataPropertyName = "Medicine"
        Me.MedicineDataGridViewTextBoxColumn.HeaderText = "Medicine"
        Me.MedicineDataGridViewTextBoxColumn.Name = "MedicineDataGridViewTextBoxColumn"
        '
        'CategoryDataGridViewTextBoxColumn
        '
        Me.CategoryDataGridViewTextBoxColumn.DataPropertyName = "category"
        Me.CategoryDataGridViewTextBoxColumn.HeaderText = "category"
        Me.CategoryDataGridViewTextBoxColumn.Name = "CategoryDataGridViewTextBoxColumn"
        '
        'ExpirationdateDataGridViewTextBoxColumn
        '
        Me.ExpirationdateDataGridViewTextBoxColumn.DataPropertyName = "expiration_date"
        Me.ExpirationdateDataGridViewTextBoxColumn.HeaderText = "expiration_date"
        Me.ExpirationdateDataGridViewTextBoxColumn.Name = "ExpirationdateDataGridViewTextBoxColumn"
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        '
        'QtyDataGridViewTextBoxColumn
        '
        Me.QtyDataGridViewTextBoxColumn.DataPropertyName = "Qty"
        Me.QtyDataGridViewTextBoxColumn.HeaderText = "Qty"
        Me.QtyDataGridViewTextBoxColumn.Name = "QtyDataGridViewTextBoxColumn"
        '
        'Meds_inventoryBindingSource
        '
        Me.Meds_inventoryBindingSource.DataMember = "meds_inventory"
        Me.Meds_inventoryBindingSource.DataSource = Me.PharmaDataSet
        '
        'PharmaDataSet
        '
        Me.PharmaDataSet.DataSetName = "pharmaDataSet"
        Me.PharmaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'medCategory_combx
        '
        Me.medCategory_combx.FormattingEnabled = True
        Me.medCategory_combx.Items.AddRange(New Object() {"Pain Killer", "Anti-depression", "Paracetamol", "Lozenges", "Anti-Anxiety", "Anti-Allergy", "anti-Biotic"})
        Me.medCategory_combx.Location = New System.Drawing.Point(222, 428)
        Me.medCategory_combx.Name = "medCategory_combx"
        Me.medCategory_combx.Size = New System.Drawing.Size(227, 21)
        Me.medCategory_combx.TabIndex = 93
        '
        'MedsinventoryBindingSource
        '
        Me.MedsinventoryBindingSource.DataMember = "meds_inventory"
        Me.MedsinventoryBindingSource.DataSource = Me.PharmaDataSetBindingSource
        '
        'PharmaDataSetBindingSource
        '
        Me.PharmaDataSetBindingSource.DataSource = Me.PharmaDataSet
        Me.PharmaDataSetBindingSource.Position = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(151, 555)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 16)
        Me.Label7.TabIndex = 92
        Me.Label7.Text = "Quantity : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(168, 513)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 16)
        Me.Label6.TabIndex = 91
        Me.Label6.Text = "Price : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(130, 471)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 16)
        Me.Label5.TabIndex = 90
        Me.Label5.Text = "Expiry Date : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(144, 429)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 16)
        Me.Label4.TabIndex = 89
        Me.Label4.Text = "Category : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(104, 387)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 16)
        Me.Label3.TabIndex = 88
        Me.Label3.Text = "Medicine Name : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(110, 313)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 20)
        Me.Label2.TabIndex = 87
        Me.Label2.Text = "Medicine ID : "
        '
        'medQty_txbx
        '
        Me.medQty_txbx.Location = New System.Drawing.Point(222, 555)
        Me.medQty_txbx.Name = "medQty_txbx"
        Me.medQty_txbx.Size = New System.Drawing.Size(228, 20)
        Me.medQty_txbx.TabIndex = 86
        '
        'medPrice_txbx
        '
        Me.medPrice_txbx.Location = New System.Drawing.Point(222, 513)
        Me.medPrice_txbx.Name = "medPrice_txbx"
        Me.medPrice_txbx.Size = New System.Drawing.Size(228, 20)
        Me.medPrice_txbx.TabIndex = 85
        '
        'expDate_txbx
        '
        Me.expDate_txbx.Location = New System.Drawing.Point(222, 471)
        Me.expDate_txbx.Name = "expDate_txbx"
        Me.expDate_txbx.Size = New System.Drawing.Size(228, 20)
        Me.expDate_txbx.TabIndex = 84
        '
        'medName_txbx
        '
        Me.medName_txbx.Location = New System.Drawing.Point(222, 386)
        Me.medName_txbx.Name = "medName_txbx"
        Me.medName_txbx.Size = New System.Drawing.Size(228, 20)
        Me.medName_txbx.TabIndex = 83
        '
        'medId_txbx
        '
        Me.medId_txbx.BackColor = System.Drawing.Color.MistyRose
        Me.medId_txbx.Location = New System.Drawing.Point(222, 313)
        Me.medId_txbx.Name = "medId_txbx"
        Me.medId_txbx.Size = New System.Drawing.Size(228, 20)
        Me.medId_txbx.TabIndex = 82
        '
        'Meds_inventoryTableAdapter
        '
        Me.Meds_inventoryTableAdapter.ClearBeforeFill = True
        '
        'medCheck_btn
        '
        Me.medCheck_btn.BackColor = System.Drawing.Color.LightSkyBlue
        Me.medCheck_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.medCheck_btn.Location = New System.Drawing.Point(466, 308)
        Me.medCheck_btn.Name = "medCheck_btn"
        Me.medCheck_btn.Size = New System.Drawing.Size(84, 35)
        Me.medCheck_btn.TabIndex = 94
        Me.medCheck_btn.Text = "CHECK"
        Me.medCheck_btn.UseVisualStyleBackColor = False
        '
        'MnameUpd_btn
        '
        Me.MnameUpd_btn.BackColor = System.Drawing.Color.LightSkyBlue
        Me.MnameUpd_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MnameUpd_btn.Location = New System.Drawing.Point(466, 381)
        Me.MnameUpd_btn.Name = "MnameUpd_btn"
        Me.MnameUpd_btn.Size = New System.Drawing.Size(84, 29)
        Me.MnameUpd_btn.TabIndex = 95
        Me.MnameUpd_btn.Text = "UPDATE"
        Me.MnameUpd_btn.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(154, 346)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(350, 27)
        Me.Label9.TabIndex = 100
        Me.Label9.Text = "**UPDATE INFO ONE AT A TIME**"
        '
        'McatUpd_btn
        '
        Me.McatUpd_btn.BackColor = System.Drawing.Color.LightSkyBlue
        Me.McatUpd_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.McatUpd_btn.Location = New System.Drawing.Point(466, 423)
        Me.McatUpd_btn.Name = "McatUpd_btn"
        Me.McatUpd_btn.Size = New System.Drawing.Size(84, 29)
        Me.McatUpd_btn.TabIndex = 101
        Me.McatUpd_btn.Text = "UPDATE"
        Me.McatUpd_btn.UseVisualStyleBackColor = False
        '
        'MexpdtUpd_btn
        '
        Me.MexpdtUpd_btn.BackColor = System.Drawing.Color.LightSkyBlue
        Me.MexpdtUpd_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MexpdtUpd_btn.Location = New System.Drawing.Point(466, 465)
        Me.MexpdtUpd_btn.Name = "MexpdtUpd_btn"
        Me.MexpdtUpd_btn.Size = New System.Drawing.Size(84, 29)
        Me.MexpdtUpd_btn.TabIndex = 102
        Me.MexpdtUpd_btn.Text = "UPDATE"
        Me.MexpdtUpd_btn.UseVisualStyleBackColor = False
        '
        'MpriceUpd_btn
        '
        Me.MpriceUpd_btn.BackColor = System.Drawing.Color.LightSkyBlue
        Me.MpriceUpd_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MpriceUpd_btn.Location = New System.Drawing.Point(466, 507)
        Me.MpriceUpd_btn.Name = "MpriceUpd_btn"
        Me.MpriceUpd_btn.Size = New System.Drawing.Size(84, 29)
        Me.MpriceUpd_btn.TabIndex = 103
        Me.MpriceUpd_btn.Text = "UPDATE"
        Me.MpriceUpd_btn.UseVisualStyleBackColor = False
        '
        'MqtyUpd_btn
        '
        Me.MqtyUpd_btn.BackColor = System.Drawing.Color.LightSkyBlue
        Me.MqtyUpd_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MqtyUpd_btn.Location = New System.Drawing.Point(466, 549)
        Me.MqtyUpd_btn.Name = "MqtyUpd_btn"
        Me.MqtyUpd_btn.Size = New System.Drawing.Size(84, 29)
        Me.MqtyUpd_btn.TabIndex = 104
        Me.MqtyUpd_btn.Text = "UPDATE"
        Me.MqtyUpd_btn.UseVisualStyleBackColor = False
        '
        'updateStockForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(688, 632)
        Me.Controls.Add(Me.MqtyUpd_btn)
        Me.Controls.Add(Me.MpriceUpd_btn)
        Me.Controls.Add(Me.MexpdtUpd_btn)
        Me.Controls.Add(Me.McatUpd_btn)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.MnameUpd_btn)
        Me.Controls.Add(Me.medCheck_btn)
        Me.Controls.Add(Me.medCategory_combx)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.medQty_txbx)
        Me.Controls.Add(Me.medPrice_txbx)
        Me.Controls.Add(Me.expDate_txbx)
        Me.Controls.Add(Me.medName_txbx)
        Me.Controls.Add(Me.medId_txbx)
        Me.Controls.Add(Me.updateMeds_DG)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "updateStockForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "updateStockForm"
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.updateMeds_DG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Meds_inventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PharmaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedsinventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PharmaDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents adminMenu_back As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents updateMeds_DG As DataGridView
    Friend WithEvents medCategory_combx As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents medQty_txbx As TextBox
    Friend WithEvents medPrice_txbx As TextBox
    Friend WithEvents expDate_txbx As TextBox
    Friend WithEvents medName_txbx As TextBox
    Friend WithEvents medId_txbx As TextBox
    Friend WithEvents PharmaDataSetBindingSource As BindingSource
    Friend WithEvents PharmaDataSet As pharmaDataSet
    Friend WithEvents MedsinventoryBindingSource As BindingSource
    Friend WithEvents Meds_inventoryTableAdapter As pharmaDataSetTableAdapters.meds_inventoryTableAdapter
    Friend WithEvents medCheck_btn As Button
    Friend WithEvents MnameUpd_btn As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents McatUpd_btn As Button
    Friend WithEvents MexpdtUpd_btn As Button
    Friend WithEvents MpriceUpd_btn As Button
    Friend WithEvents MqtyUpd_btn As Button
    Friend WithEvents MedIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MedicineDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExpirationdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QtyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Meds_inventoryBindingSource As BindingSource
End Class
