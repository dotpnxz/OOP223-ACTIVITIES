<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbltuition = New System.Windows.Forms.Label()
        Me.txtunits = New System.Windows.Forms.TextBox()
        Me.txtamount = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.txtlabfee = New System.Windows.Forms.TextBox()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.rdDL = New System.Windows.Forms.RadioButton()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnForm2 = New System.Windows.Forms.Button()
        Me.rdalumni = New System.Windows.Forms.RadioButton()
        Me.rdsiblings = New System.Windows.Forms.RadioButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbldiscount = New System.Windows.Forms.Label()
        Me.lbldiscfee = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(69, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tuition Fee Discount"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(49, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Total Units:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(122, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Amount Per Unit:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Mscellaneious:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(65, 230)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Lab Fee:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(46, 280)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Tuition Fee:"
        '
        'lbltuition
        '
        Me.lbltuition.AutoSize = True
        Me.lbltuition.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltuition.Location = New System.Drawing.Point(142, 280)
        Me.lbltuition.Name = "lbltuition"
        Me.lbltuition.Size = New System.Drawing.Size(55, 16)
        Me.lbltuition.TabIndex = 6
        Me.lbltuition.Text = "Label7"
        '
        'txtunits
        '
        Me.txtunits.Location = New System.Drawing.Point(142, 84)
        Me.txtunits.Name = "txtunits"
        Me.txtunits.Size = New System.Drawing.Size(100, 20)
        Me.txtunits.TabIndex = 7
        '
        'txtamount
        '
        Me.txtamount.Location = New System.Drawing.Point(142, 136)
        Me.txtamount.Name = "txtamount"
        Me.txtamount.Size = New System.Drawing.Size(100, 20)
        Me.txtamount.TabIndex = 8
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(142, 182)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 9
        '
        'txtlabfee
        '
        Me.txtlabfee.Location = New System.Drawing.Point(142, 226)
        Me.txtlabfee.Name = "txtlabfee"
        Me.txtlabfee.Size = New System.Drawing.Size(100, 20)
        Me.txtlabfee.TabIndex = 10
        '
        'btnCompute
        '
        Me.btnCompute.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompute.Location = New System.Drawing.Point(287, 223)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(85, 23)
        Me.btnCompute.TabIndex = 11
        Me.btnCompute.Text = "Compute"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(273, 84)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 16)
        Me.Label8.TabIndex = 14
        '
        'rdDL
        '
        Me.rdDL.AutoSize = True
        Me.rdDL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdDL.Location = New System.Drawing.Point(11, 21)
        Me.rdDL.Name = "rdDL"
        Me.rdDL.Size = New System.Drawing.Size(117, 20)
        Me.rdDL.TabIndex = 15
        Me.rdDL.TabStop = True
        Me.rdDL.Text = "Dean's Lister"
        Me.rdDL.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(287, 261)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(85, 23)
        Me.btnExit.TabIndex = 18
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnForm2
        '
        Me.btnForm2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnForm2.Location = New System.Drawing.Point(287, 301)
        Me.btnForm2.Name = "btnForm2"
        Me.btnForm2.Size = New System.Drawing.Size(85, 23)
        Me.btnForm2.TabIndex = 19
        Me.btnForm2.Text = "Form 2"
        Me.btnForm2.UseVisualStyleBackColor = True
        '
        'rdalumni
        '
        Me.rdalumni.AutoSize = True
        Me.rdalumni.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdalumni.Location = New System.Drawing.Point(11, 48)
        Me.rdalumni.Name = "rdalumni"
        Me.rdalumni.Size = New System.Drawing.Size(72, 20)
        Me.rdalumni.TabIndex = 20
        Me.rdalumni.TabStop = True
        Me.rdalumni.Text = "Alumni"
        Me.rdalumni.UseVisualStyleBackColor = True
        '
        'rdsiblings
        '
        Me.rdsiblings.AutoSize = True
        Me.rdsiblings.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdsiblings.Location = New System.Drawing.Point(11, 74)
        Me.rdsiblings.Name = "rdsiblings"
        Me.rdsiblings.Size = New System.Drawing.Size(82, 20)
        Me.rdsiblings.TabIndex = 21
        Me.rdsiblings.TabStop = True
        Me.rdsiblings.Text = "Siblings"
        Me.rdsiblings.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(62, 308)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 16)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Discount:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(15, 341)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(121, 16)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Discounted Fee:"
        '
        'lbldiscount
        '
        Me.lbldiscount.AutoSize = True
        Me.lbldiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldiscount.Location = New System.Drawing.Point(140, 308)
        Me.lbldiscount.Name = "lbldiscount"
        Me.lbldiscount.Size = New System.Drawing.Size(63, 16)
        Me.lbldiscount.TabIndex = 24
        Me.lbldiscount.Text = "Label11"
        '
        'lbldiscfee
        '
        Me.lbldiscfee.AutoSize = True
        Me.lbldiscfee.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldiscfee.Location = New System.Drawing.Point(139, 341)
        Me.lbldiscfee.Name = "lbldiscfee"
        Me.lbldiscfee.Size = New System.Drawing.Size(63, 16)
        Me.lbldiscfee.TabIndex = 25
        Me.lbldiscfee.Text = "Label12"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdsiblings)
        Me.GroupBox1.Controls.Add(Me.rdalumni)
        Me.GroupBox1.Controls.Add(Me.rdDL)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(279, 84)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(144, 114)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Discount Type"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 407)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbldiscfee)
        Me.Controls.Add(Me.lbldiscount)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnForm2)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.txtlabfee)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.txtamount)
        Me.Controls.Add(Me.txtunits)
        Me.Controls.Add(Me.lbltuition)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Tuition Fee Discount Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtunits As TextBox
    Friend WithEvents txtamount As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents txtlabfee As TextBox
    Friend WithEvents btnCompute As Button
    Friend WithEvents lbltuition As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents rdDL As RadioButton
    Friend WithEvents btnExit As Button
    Friend WithEvents btnForm2 As Button
    Friend WithEvents rdalumni As RadioButton
    Friend WithEvents rdsiblings As RadioButton
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lbldiscount As Label
    Friend WithEvents lbldiscfee As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
