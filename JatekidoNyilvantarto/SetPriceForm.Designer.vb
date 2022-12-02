<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SetPriceForm
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
        Me.P_Main = New System.Windows.Forms.Panel()
        Me.Lbl_Price = New System.Windows.Forms.Label()
        Me.Nud_Price = New System.Windows.Forms.NumericUpDown()
        Me.Btn_OK = New System.Windows.Forms.Button()
        Me.Btn_Cancel = New System.Windows.Forms.Button()
        Me.P_Main.SuspendLayout()
        CType(Me.Nud_Price, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'P_Main
        '
        Me.P_Main.Controls.Add(Me.Btn_Cancel)
        Me.P_Main.Controls.Add(Me.Btn_OK)
        Me.P_Main.Controls.Add(Me.Nud_Price)
        Me.P_Main.Controls.Add(Me.Lbl_Price)
        Me.P_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.P_Main.Location = New System.Drawing.Point(0, 0)
        Me.P_Main.Name = "P_Main"
        Me.P_Main.Size = New System.Drawing.Size(199, 79)
        Me.P_Main.TabIndex = 0
        '
        'Lbl_Price
        '
        Me.Lbl_Price.AutoSize = True
        Me.Lbl_Price.Location = New System.Drawing.Point(12, 9)
        Me.Lbl_Price.Name = "Lbl_Price"
        Me.Lbl_Price.Size = New System.Drawing.Size(29, 13)
        Me.Lbl_Price.TabIndex = 0
        Me.Lbl_Price.Text = "Új ár"
        '
        'Nud_Price
        '
        Me.Nud_Price.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Nud_Price.DecimalPlaces = 2
        Me.Nud_Price.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.Nud_Price.Location = New System.Drawing.Point(47, 7)
        Me.Nud_Price.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.Nud_Price.Name = "Nud_Price"
        Me.Nud_Price.Size = New System.Drawing.Size(140, 20)
        Me.Nud_Price.TabIndex = 1
        Me.Nud_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Nud_Price.ThousandsSeparator = True
        '
        'Btn_OK
        '
        Me.Btn_OK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Btn_OK.Location = New System.Drawing.Point(12, 44)
        Me.Btn_OK.Name = "Btn_OK"
        Me.Btn_OK.Size = New System.Drawing.Size(83, 23)
        Me.Btn_OK.TabIndex = 2
        Me.Btn_OK.Text = "OK"
        Me.Btn_OK.UseVisualStyleBackColor = True
        '
        'Btn_Cancel
        '
        Me.Btn_Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Btn_Cancel.Location = New System.Drawing.Point(104, 44)
        Me.Btn_Cancel.Name = "Btn_Cancel"
        Me.Btn_Cancel.Size = New System.Drawing.Size(83, 23)
        Me.Btn_Cancel.TabIndex = 3
        Me.Btn_Cancel.Text = "Mégse"
        Me.Btn_Cancel.UseVisualStyleBackColor = True
        '
        'SetPriceForm
        '
        Me.AcceptButton = Me.Btn_OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Btn_Cancel
        Me.ClientSize = New System.Drawing.Size(199, 79)
        Me.Controls.Add(Me.P_Main)
        Me.Name = "SetPriceForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ár megadása"
        Me.P_Main.ResumeLayout(False)
        Me.P_Main.PerformLayout()
        CType(Me.Nud_Price, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents P_Main As System.Windows.Forms.Panel
    Friend WithEvents Btn_Cancel As System.Windows.Forms.Button
    Friend WithEvents Btn_OK As System.Windows.Forms.Button
    Friend WithEvents Nud_Price As System.Windows.Forms.NumericUpDown
    Friend WithEvents Lbl_Price As System.Windows.Forms.Label
End Class
