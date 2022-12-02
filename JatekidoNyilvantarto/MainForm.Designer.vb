<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.P_Main = New System.Windows.Forms.Panel()
        Me.P_ClientArea = New System.Windows.Forms.Panel()
        Me.Ss_StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.Ms_Menu = New System.Windows.Forms.MenuStrip()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tsmi_About = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tsmi_Exit = New System.Windows.Forms.ToolStripMenuItem()
        Me.P_Main.SuspendLayout()
        Me.Ms_Menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'P_Main
        '
        Me.P_Main.Controls.Add(Me.P_ClientArea)
        Me.P_Main.Controls.Add(Me.Ss_StatusStrip)
        Me.P_Main.Controls.Add(Me.Ms_Menu)
        Me.P_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.P_Main.Location = New System.Drawing.Point(0, 0)
        Me.P_Main.Name = "P_Main"
        Me.P_Main.Size = New System.Drawing.Size(994, 696)
        Me.P_Main.TabIndex = 0
        '
        'P_ClientArea
        '
        Me.P_ClientArea.Dock = System.Windows.Forms.DockStyle.Fill
        Me.P_ClientArea.Location = New System.Drawing.Point(0, 24)
        Me.P_ClientArea.Name = "P_ClientArea"
        Me.P_ClientArea.Size = New System.Drawing.Size(994, 650)
        Me.P_ClientArea.TabIndex = 2
        '
        'Ss_StatusStrip
        '
        Me.Ss_StatusStrip.Location = New System.Drawing.Point(0, 674)
        Me.Ss_StatusStrip.Name = "Ss_StatusStrip"
        Me.Ss_StatusStrip.Size = New System.Drawing.Size(994, 22)
        Me.Ss_StatusStrip.TabIndex = 1
        Me.Ss_StatusStrip.Text = "StatusStrip1"
        '
        'Ms_Menu
        '
        Me.Ms_Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.Tsmi_About, Me.Tsmi_Exit})
        Me.Ms_Menu.Location = New System.Drawing.Point(0, 0)
        Me.Ms_Menu.Name = "Ms_Menu"
        Me.Ms_Menu.Size = New System.Drawing.Size(994, 24)
        Me.Ms_Menu.TabIndex = 0
        Me.Ms_Menu.Text = "MenuStrip1"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TableToolStripMenuItem})
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(29, 20)
        Me.NewToolStripMenuItem.Text = "Új"
        '
        'TableToolStripMenuItem
        '
        Me.TableToolStripMenuItem.Name = "TableToolStripMenuItem"
        Me.TableToolStripMenuItem.ShortcutKeyDisplayString = "F2"
        Me.TableToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.TableToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.TableToolStripMenuItem.Text = "Asztal"
        '
        'Tsmi_About
        '
        Me.Tsmi_About.Name = "Tsmi_About"
        Me.Tsmi_About.Size = New System.Drawing.Size(59, 20)
        Me.Tsmi_About.Text = "Névjegy"
        '
        'Tsmi_Exit
        '
        Me.Tsmi_Exit.Name = "Tsmi_Exit"
        Me.Tsmi_Exit.Size = New System.Drawing.Size(52, 20)
        Me.Tsmi_Exit.Text = "Kilépés"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(994, 696)
        Me.Controls.Add(Me.P_Main)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.Ms_Menu
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Játékidő nyilvántartó"
        Me.P_Main.ResumeLayout(False)
        Me.P_Main.PerformLayout()
        Me.Ms_Menu.ResumeLayout(False)
        Me.Ms_Menu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents P_Main As System.Windows.Forms.Panel
    Friend WithEvents P_ClientArea As System.Windows.Forms.Panel
    Friend WithEvents Ss_StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents Ms_Menu As System.Windows.Forms.MenuStrip
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Tsmi_Exit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Tsmi_About As System.Windows.Forms.ToolStripMenuItem

End Class
