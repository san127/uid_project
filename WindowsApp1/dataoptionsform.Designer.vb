<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dataoptionsform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dataoptionsform))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.viewdbPic = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.ordMgmtPic = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.purchMenu_back = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.viewdbPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ordMgmtPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(557, 75)
        Me.Panel1.TabIndex = 85
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FloralWhite
        Me.Label1.Location = New System.Drawing.Point(151, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PharmExcel"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.purchMenu_back)
        Me.Panel2.Location = New System.Drawing.Point(-1, 478)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(557, 22)
        Me.Panel2.TabIndex = 86
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(194, 294)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(152, 130)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 87
        Me.PictureBox2.TabStop = False
        '
        'viewdbPic
        '
        Me.viewdbPic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.viewdbPic.Image = CType(resources.GetObject("viewdbPic.Image"), System.Drawing.Image)
        Me.viewdbPic.Location = New System.Drawing.Point(30, 125)
        Me.viewdbPic.Name = "viewdbPic"
        Me.viewdbPic.Size = New System.Drawing.Size(82, 86)
        Me.viewdbPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.viewdbPic.TabIndex = 88
        Me.viewdbPic.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label4.Location = New System.Drawing.Point(15, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 25)
        Me.Label4.TabIndex = 92
        Me.Label4.Text = "View Stock"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.label6.Location = New System.Drawing.Point(387, 214)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(152, 25)
        Me.label6.TabIndex = 97
        Me.label6.Text = "Manage orders"
        '
        'ordMgmtPic
        '
        Me.ordMgmtPic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ordMgmtPic.Image = CType(resources.GetObject("ordMgmtPic.Image"), System.Drawing.Image)
        Me.ordMgmtPic.Location = New System.Drawing.Point(414, 125)
        Me.ordMgmtPic.Name = "ordMgmtPic"
        Me.ordMgmtPic.Size = New System.Drawing.Size(98, 86)
        Me.ordMgmtPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ordMgmtPic.TabIndex = 96
        Me.ordMgmtPic.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label7.Location = New System.Drawing.Point(181, 214)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(178, 25)
        Me.Label7.TabIndex = 99
        Me.Label7.Text = "Manage Suppliers"
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(221, 125)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(99, 86)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 98
        Me.PictureBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label8.Location = New System.Drawing.Point(154, 439)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(233, 24)
        Me.Label8.TabIndex = 100
        Me.Label8.Text = "PURCHASING MANAGER"
        '
        'purchMenu_back
        '
        Me.purchMenu_back.BackColor = System.Drawing.Color.SkyBlue
        Me.purchMenu_back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.purchMenu_back.Location = New System.Drawing.Point(231, -2)
        Me.purchMenu_back.Name = "purchMenu_back"
        Me.purchMenu_back.Size = New System.Drawing.Size(75, 22)
        Me.purchMenu_back.TabIndex = 101
        Me.purchMenu_back.Text = "Back"
        Me.purchMenu_back.UseVisualStyleBackColor = False
        '
        'dataoptionsform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(555, 512)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.ordMgmtPic)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.viewdbPic)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "dataoptionsform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "dataoptionsform"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.viewdbPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ordMgmtPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents viewdbPic As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents label6 As Label
    Friend WithEvents ordMgmtPic As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents purchMenu_back As Button
End Class
