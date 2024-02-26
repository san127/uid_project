<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class viewMedsForm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.viewmed_datagrid = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.viewMed_back = New System.Windows.Forms.Button()
        Me.PharmaDataSet = New WindowsApp1.pharmaDataSet()
        Me.Meds_inventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Meds_inventoryTableAdapter = New WindowsApp1.pharmaDataSetTableAdapters.meds_inventoryTableAdapter()
        Me.TableAdapterManager = New WindowsApp1.pharmaDataSetTableAdapters.TableAdapterManager()
        Me.MedIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicineDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpirationdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.viewmed_datagrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PharmaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Meds_inventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Panel1.TabIndex = 83
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(286, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(124, 19)
        Me.Label8.TabIndex = 85
        Me.Label8.Text = "VIEW MEDICINES"
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
        'viewmed_datagrid
        '
        Me.viewmed_datagrid.AutoGenerateColumns = False
        Me.viewmed_datagrid.BackgroundColor = System.Drawing.Color.LightCyan
        Me.viewmed_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.viewmed_datagrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MedIDDataGridViewTextBoxColumn, Me.MedicineDataGridViewTextBoxColumn, Me.CategoryDataGridViewTextBoxColumn, Me.ExpirationdateDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.QtyDataGridViewTextBoxColumn})
        Me.viewmed_datagrid.DataSource = Me.Meds_inventoryBindingSource
        Me.viewmed_datagrid.Location = New System.Drawing.Point(12, 93)
        Me.viewmed_datagrid.Name = "viewmed_datagrid"
        Me.viewmed_datagrid.Size = New System.Drawing.Size(667, 424)
        Me.viewmed_datagrid.TabIndex = 85
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.viewMed_back)
        Me.Panel2.Location = New System.Drawing.Point(-1, 533)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(692, 22)
        Me.Panel2.TabIndex = 84
        '
        'viewMed_back
        '
        Me.viewMed_back.BackColor = System.Drawing.Color.SkyBlue
        Me.viewMed_back.Location = New System.Drawing.Point(309, -2)
        Me.viewMed_back.Name = "viewMed_back"
        Me.viewMed_back.Size = New System.Drawing.Size(75, 22)
        Me.viewMed_back.TabIndex = 24
        Me.viewMed_back.Text = "Back"
        Me.viewMed_back.UseVisualStyleBackColor = False
        '
        'PharmaDataSet
        '
        Me.PharmaDataSet.DataSetName = "pharmaDataSet"
        Me.PharmaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Meds_inventoryBindingSource
        '
        Me.Meds_inventoryBindingSource.DataMember = "meds_inventory"
        Me.Meds_inventoryBindingSource.DataSource = Me.PharmaDataSet
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
        'viewMedsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(690, 561)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.viewmed_datagrid)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "viewMedsForm"
        Me.Text = "viewMedsForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.viewmed_datagrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PharmaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Meds_inventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents viewmed_datagrid As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents viewMed_back As Button
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
End Class
