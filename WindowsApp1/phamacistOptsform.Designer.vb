<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class phamacistOptsform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(phamacistOptsform))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.updDBpic = New System.Windows.Forms.PictureBox()
        Me.delStDbpic = New System.Windows.Forms.PictureBox()
        Me.addstDBpic = New System.Windows.Forms.PictureBox()
        Me.viewdbPic = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.updDBpic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.delStDbpic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.addstDBpic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.viewdbPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Location = New System.Drawing.Point(-1, 350)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(557, 22)
        Me.Panel2.TabIndex = 88
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FloralWhite
        Me.Label1.Location = New System.Drawing.Point(158, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PharmExcel"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(557, 75)
        Me.Panel1.TabIndex = 87
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(197, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(160, 19)
        Me.Label8.TabIndex = 105
        Me.Label8.Text = "STOCK MANAGEMENT"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label5.Location = New System.Drawing.Point(410, 313)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 25)
        Me.Label5.TabIndex = 103
        Me.Label5.Text = "Update Stock"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Location = New System.Drawing.Point(277, 313)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 25)
        Me.Label3.TabIndex = 102
        Me.Label3.Text = "Delete Stock"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(151, 313)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 25)
        Me.Label2.TabIndex = 101
        Me.Label2.Text = "Add Stock"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label4.Location = New System.Drawing.Point(10, 313)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 25)
        Me.Label4.TabIndex = 100
        Me.Label4.Text = "View Stock"
        '
        'updDBpic
        '
        Me.updDBpic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.updDBpic.Image = CType(resources.GetObject("updDBpic.Image"), System.Drawing.Image)
        Me.updDBpic.Location = New System.Drawing.Point(436, 207)
        Me.updDBpic.Name = "updDBpic"
        Me.updDBpic.Size = New System.Drawing.Size(82, 86)
        Me.updDBpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.updDBpic.TabIndex = 99
        Me.updDBpic.TabStop = False
        '
        'delStDbpic
        '
        Me.delStDbpic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.delStDbpic.Image = CType(resources.GetObject("delStDbpic.Image"), System.Drawing.Image)
        Me.delStDbpic.Location = New System.Drawing.Point(299, 207)
        Me.delStDbpic.Name = "delStDbpic"
        Me.delStDbpic.Size = New System.Drawing.Size(82, 86)
        Me.delStDbpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.delStDbpic.TabIndex = 98
        Me.delStDbpic.TabStop = False
        '
        'addstDBpic
        '
        Me.addstDBpic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addstDBpic.Image = CType(resources.GetObject("addstDBpic.Image"), System.Drawing.Image)
        Me.addstDBpic.Location = New System.Drawing.Point(162, 207)
        Me.addstDBpic.Name = "addstDBpic"
        Me.addstDBpic.Size = New System.Drawing.Size(82, 86)
        Me.addstDBpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.addstDBpic.TabIndex = 97
        Me.addstDBpic.TabStop = False
        '
        'viewdbPic
        '
        Me.viewdbPic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.viewdbPic.Image = CType(resources.GetObject("viewdbPic.Image"), System.Drawing.Image)
        Me.viewdbPic.Location = New System.Drawing.Point(25, 207)
        Me.viewdbPic.Name = "viewdbPic"
        Me.viewdbPic.Size = New System.Drawing.Size(82, 86)
        Me.viewdbPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.viewdbPic.TabIndex = 96
        Me.viewdbPic.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(214, 81)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(134, 111)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 104
        Me.PictureBox2.TabStop = False
        '
        'phamacistOptsform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(555, 376)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.updDBpic)
        Me.Controls.Add(Me.delStDbpic)
        Me.Controls.Add(Me.addstDBpic)
        Me.Controls.Add(Me.viewdbPic)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "phamacistOptsform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "phamacistOptsform"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.updDBpic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.delStDbpic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.addstDBpic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.viewdbPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents updDBpic As PictureBox
    Friend WithEvents delStDbpic As PictureBox
    Friend WithEvents addstDBpic As PictureBox
    Friend WithEvents viewdbPic As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
