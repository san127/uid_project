<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class POSform
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MedIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicineDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpirationdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Meds_inventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PharmaDataSet = New WindowsApp1.pharmaDataSet()
        Me.Meds_inventoryTableAdapter = New WindowsApp1.pharmaDataSetTableAdapters.meds_inventoryTableAdapter()
        Me.TableAdapterManager = New WindowsApp1.pharmaDataSetTableAdapters.TableAdapterManager()
        Me.searchMed_btn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.searchMed_txbx = New System.Windows.Forms.TextBox()
        Me.bill_txbx = New System.Windows.Forms.TextBox()
        Me.add_billBTN = New System.Windows.Forms.Button()
        Me.medqty_txbx = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tot_label = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Meds_inventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PharmaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(692, 75)
        Me.Panel1.TabIndex = 45
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(316, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 19)
        Me.Label8.TabIndex = 85
        Me.Label8.Text = "BILLING"
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
        Me.Panel2.Location = New System.Drawing.Point(0, 527)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(692, 22)
        Me.Panel2.TabIndex = 46
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.LightCyan
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MedIDDataGridViewTextBoxColumn, Me.MedicineDataGridViewTextBoxColumn, Me.CategoryDataGridViewTextBoxColumn, Me.ExpirationdateDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.QtyDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Meds_inventoryBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(11, 163)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(669, 78)
        Me.DataGridView1.TabIndex = 47
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
        'Meds_inventoryTableAdapter
        '
        Me.Meds_inventoryTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.meds_inventoryTableAdapter = Me.Meds_inventoryTableAdapter
        Me.TableAdapterManager.meds_orderTableAdapter = Nothing
        Me.TableAdapterManager.meds_supplierTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApp1.pharmaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'searchMed_btn
        '
        Me.searchMed_btn.BackColor = System.Drawing.Color.LightSkyBlue
        Me.searchMed_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.searchMed_btn.Location = New System.Drawing.Point(311, 120)
        Me.searchMed_btn.Name = "searchMed_btn"
        Me.searchMed_btn.Size = New System.Drawing.Size(84, 28)
        Me.searchMed_btn.TabIndex = 91
        Me.searchMed_btn.Text = "SEARCH"
        Me.searchMed_btn.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(77, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 24)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "Medicine name : "
        '
        'searchMed_txbx
        '
        Me.searchMed_txbx.Location = New System.Drawing.Point(239, 94)
        Me.searchMed_txbx.Name = "searchMed_txbx"
        Me.searchMed_txbx.Size = New System.Drawing.Size(228, 20)
        Me.searchMed_txbx.TabIndex = 89
        '
        'bill_txbx
        '
        Me.bill_txbx.BackColor = System.Drawing.Color.LightYellow
        Me.bill_txbx.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bill_txbx.Location = New System.Drawing.Point(12, 318)
        Me.bill_txbx.Multiline = True
        Me.bill_txbx.Name = "bill_txbx"
        Me.bill_txbx.Size = New System.Drawing.Size(668, 157)
        Me.bill_txbx.TabIndex = 92
        '
        'add_billBTN
        '
        Me.add_billBTN.BackColor = System.Drawing.Color.LightSkyBlue
        Me.add_billBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.add_billBTN.Location = New System.Drawing.Point(460, 266)
        Me.add_billBTN.Name = "add_billBTN"
        Me.add_billBTN.Size = New System.Drawing.Size(84, 28)
        Me.add_billBTN.TabIndex = 93
        Me.add_billBTN.Text = "ADD"
        Me.add_billBTN.UseVisualStyleBackColor = False
        '
        'medqty_txbx
        '
        Me.medqty_txbx.Location = New System.Drawing.Point(277, 270)
        Me.medqty_txbx.Name = "medqty_txbx"
        Me.medqty_txbx.Size = New System.Drawing.Size(140, 20)
        Me.medqty_txbx.TabIndex = 96
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(178, 266)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 24)
        Me.Label4.TabIndex = 97
        Me.Label4.Text = "Quantity : "
        '
        'tot_label
        '
        Me.tot_label.AutoSize = True
        Me.tot_label.Font = New System.Drawing.Font("Microsoft Tai Le", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tot_label.Location = New System.Drawing.Point(565, 485)
        Me.tot_label.Name = "tot_label"
        Me.tot_label.Size = New System.Drawing.Size(31, 34)
        Me.tot_label.TabIndex = 95
        Me.tot_label.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(345, 485)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(214, 34)
        Me.Label3.TabIndex = 94
        Me.Label3.Text = "Total Amount : "
        '
        'POSform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(689, 553)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.medqty_txbx)
        Me.Controls.Add(Me.tot_label)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.add_billBTN)
        Me.Controls.Add(Me.bill_txbx)
        Me.Controls.Add(Me.searchMed_btn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.searchMed_txbx)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "POSform"
        Me.Text = "POSform"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Meds_inventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PharmaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PharmaDataSet As pharmaDataSet
    Friend WithEvents Meds_inventoryBindingSource As BindingSource
    Friend WithEvents Meds_inventoryTableAdapter As pharmaDataSetTableAdapters.meds_inventoryTableAdapter
    Friend WithEvents TableAdapterManager As pharmaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MedIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MedicineDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExpirationdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QtyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents searchMed_btn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents searchMed_txbx As TextBox
    Friend WithEvents bill_txbx As TextBox
    Friend WithEvents add_billBTN As Button
    Friend WithEvents medqty_txbx As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tot_label As Label
    Friend WithEvents Label3 As Label
End Class
