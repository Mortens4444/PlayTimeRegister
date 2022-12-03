<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PoolTable
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.P_Middle = New System.Windows.Forms.Panel()
        Me.Cms_ContentMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Tsmi_SetPrice = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tsmi_ClearTimer = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tsmi_DeleteTable = New System.Windows.Forms.ToolStripMenuItem()
        Me.Btn_StartStop = New System.Windows.Forms.Button()
        Me.T_Counter = New System.Windows.Forms.Timer(Me.components)
        Me.P_Middle.SuspendLayout()
        Me.Cms_ContentMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'P_Middle
        '
        Me.P_Middle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.P_Middle.BackColor = Color.ForestGreen
        Me.P_Middle.ContextMenuStrip = Me.Cms_ContentMenu
        Me.P_Middle.Controls.Add(Me.Btn_StartStop)
        Me.P_Middle.Location = New System.Drawing.Point(3, 3)
        Me.P_Middle.Name = "P_Middle"
        Me.P_Middle.Size = New System.Drawing.Size(120, 189)
        Me.P_Middle.TabIndex = 0
        '
        'Cms_ContentMenu
        '
        Me.Cms_ContentMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tsmi_SetPrice, Me.Tsmi_ClearTimer, Me.ToolStripSeparator1, Me.Tsmi_DeleteTable})
        Me.Cms_ContentMenu.Name = "Cms_ContentMenu"
        Me.Cms_ContentMenu.Size = New System.Drawing.Size(163, 98)
        '
        'Tsmi_SetPrice
        '
        Me.Tsmi_SetPrice.Name = "Tsmi_SetPrice"
        Me.Tsmi_SetPrice.Size = New System.Drawing.Size(162, 22)
        Me.Tsmi_SetPrice.Text = "Set price"
        '
        'Tsmi_ClearTimer
        '
        Me.Tsmi_ClearTimer.Name = "Tsmi_ClearTimer"
        Me.Tsmi_ClearTimer.Size = New System.Drawing.Size(162, 22)
        Me.Tsmi_ClearTimer.Text = "Clear timer"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(159, 6)
        '
        'Tsmi_DeleteTable
        '
        Me.Tsmi_DeleteTable.Name = "Tsmi_DeleteTable"
        Me.Tsmi_DeleteTable.Size = New System.Drawing.Size(162, 22)
        Me.Tsmi_DeleteTable.Text = "Delete table"
        '
        'Btn_StartStop
        '
        Me.Btn_StartStop.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_StartStop.Location = New System.Drawing.Point(17, 163)
        Me.Btn_StartStop.Name = "Btn_StartStop"
        Me.Btn_StartStop.Size = New System.Drawing.Size(87, 23)
        Me.Btn_StartStop.TabIndex = 0
        Me.Btn_StartStop.Text = "Start"
        Me.Btn_StartStop.UseVisualStyleBackColor = True
        '
        'T_Counter
        '
        Me.T_Counter.Interval = 1000
        '
        'PoolTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Controls.Add(Me.P_Middle)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Name = "PoolTable"
        Me.Size = New System.Drawing.Size(131, 199)
        Me.P_Middle.ResumeLayout(False)
        Me.Cms_ContentMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents P_Middle As System.Windows.Forms.Panel
    Friend WithEvents Btn_StartStop As System.Windows.Forms.Button
    Friend WithEvents T_Counter As System.Windows.Forms.Timer
    Friend WithEvents Cms_ContentMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents Tsmi_SetPrice As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Tsmi_ClearTimer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Tsmi_DeleteTable As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator

End Class
