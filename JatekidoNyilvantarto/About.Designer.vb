<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(About))
        Me.P_Main = New System.Windows.Forms.Panel()
        Me.P_Image = New System.Windows.Forms.Panel()
        Me.P_Information = New System.Windows.Forms.Panel()
        Me.Lbl_Product = New System.Windows.Forms.Label()
        Me.Lbl_CreatedBy = New System.Windows.Forms.Label()
        Me.LLbl_SendMail = New System.Windows.Forms.LinkLabel()
        Me.Pb_Image = New System.Windows.Forms.PictureBox()
        Me.P_Main.SuspendLayout()
        Me.P_Image.SuspendLayout()
        Me.P_Information.SuspendLayout()
        CType(Me.Pb_Image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'P_Main
        '
        Me.P_Main.Controls.Add(Me.P_Information)
        Me.P_Main.Controls.Add(Me.P_Image)
        Me.P_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.P_Main.Location = New System.Drawing.Point(0, 0)
        Me.P_Main.Name = "P_Main"
        Me.P_Main.Size = New System.Drawing.Size(292, 83)
        Me.P_Main.TabIndex = 0
        '
        'P_Image
        '
        Me.P_Image.Controls.Add(Me.Pb_Image)
        Me.P_Image.Dock = System.Windows.Forms.DockStyle.Top
        Me.P_Image.Location = New System.Drawing.Point(0, 0)
        Me.P_Image.Name = "P_Image"
        Me.P_Image.Size = New System.Drawing.Size(292, 10)
        Me.P_Image.TabIndex = 0
        '
        'P_Information
        '
        Me.P_Information.Controls.Add(Me.LLbl_SendMail)
        Me.P_Information.Controls.Add(Me.Lbl_CreatedBy)
        Me.P_Information.Controls.Add(Me.Lbl_Product)
        Me.P_Information.Dock = System.Windows.Forms.DockStyle.Fill
        Me.P_Information.Location = New System.Drawing.Point(0, 10)
        Me.P_Information.Name = "P_Information"
        Me.P_Information.Size = New System.Drawing.Size(292, 73)
        Me.P_Information.TabIndex = 1
        '
        'Lbl_Product
        '
        Me.Lbl_Product.AutoSize = True
        Me.Lbl_Product.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Product.Location = New System.Drawing.Point(12, 12)
        Me.Lbl_Product.Name = "Lbl_Product"
        Me.Lbl_Product.Size = New System.Drawing.Size(200, 24)
        Me.Lbl_Product.TabIndex = 0
        Me.Lbl_Product.Text = "Játékidő nyilvántartó"
        '
        'Lbl_CreatedBy
        '
        Me.Lbl_CreatedBy.AutoSize = True
        Me.Lbl_CreatedBy.Location = New System.Drawing.Point(12, 43)
        Me.Lbl_CreatedBy.Name = "Lbl_CreatedBy"
        Me.Lbl_CreatedBy.Size = New System.Drawing.Size(58, 13)
        Me.Lbl_CreatedBy.TabIndex = 1
        Me.Lbl_CreatedBy.Text = "Created by"
        '
        'LLbl_SendMail
        '
        Me.LLbl_SendMail.AutoSize = True
        Me.LLbl_SendMail.Location = New System.Drawing.Point(70, 43)
        Me.LLbl_SendMail.Name = "LLbl_SendMail"
        Me.LLbl_SendMail.Size = New System.Drawing.Size(45, 13)
        Me.LLbl_SendMail.TabIndex = 2
        Me.LLbl_SendMail.TabStop = True
        Me.LLbl_SendMail.Text = "Mortens"
        '
        'Pb_Image
        '
        Me.Pb_Image.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pb_Image.Location = New System.Drawing.Point(0, 0)
        Me.Pb_Image.Name = "Pb_Image"
        Me.Pb_Image.Size = New System.Drawing.Size(292, 10)
        Me.Pb_Image.TabIndex = 0
        Me.Pb_Image.TabStop = False
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 83)
        Me.Controls.Add(Me.P_Main)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "About"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Névjegy"
        Me.P_Main.ResumeLayout(False)
        Me.P_Image.ResumeLayout(False)
        Me.P_Information.ResumeLayout(False)
        Me.P_Information.PerformLayout()
        CType(Me.Pb_Image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents P_Main As System.Windows.Forms.Panel
    Friend WithEvents P_Information As System.Windows.Forms.Panel
    Friend WithEvents LLbl_SendMail As System.Windows.Forms.LinkLabel
    Friend WithEvents Lbl_CreatedBy As System.Windows.Forms.Label
    Friend WithEvents Lbl_Product As System.Windows.Forms.Label
    Friend WithEvents P_Image As System.Windows.Forms.Panel
    Friend WithEvents Pb_Image As System.Windows.Forms.PictureBox
End Class
