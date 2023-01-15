<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLaporan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CR = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'CR
        '
        Me.CR.ActiveViewIndex = -1
        Me.CR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CR.DisplayGroupTree = False
        Me.CR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CR.Location = New System.Drawing.Point(0, 0)
        Me.CR.Name = "CR"
        Me.CR.SelectionFormula = ""
        Me.CR.Size = New System.Drawing.Size(649, 451)
        Me.CR.TabIndex = 0
        Me.CR.ViewTimeSelectionFormula = ""
        '
        'frmLaporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 451)
        Me.Controls.Add(Me.CR)
        Me.Name = "frmLaporan"
        Me.Text = "Laporan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CR As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
