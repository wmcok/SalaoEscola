<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRelatorios
    Inherits Syncfusion.Windows.Forms.Office2010Form

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
        Me.panelTopo = New System.Windows.Forms.Panel()
        Me.lblNomeRelatorio = New System.Windows.Forms.Label()
        Me.panelRodape = New System.Windows.Forms.Panel()
        Me.panelCorpo = New System.Windows.Forms.Panel()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.panelTopo.SuspendLayout()
        Me.panelCorpo.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelTopo
        '
        Me.panelTopo.Controls.Add(Me.lblNomeRelatorio)
        Me.panelTopo.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTopo.Location = New System.Drawing.Point(0, 0)
        Me.panelTopo.Name = "panelTopo"
        Me.panelTopo.Size = New System.Drawing.Size(923, 37)
        Me.panelTopo.TabIndex = 0
        '
        'lblNomeRelatorio
        '
        Me.lblNomeRelatorio.AutoSize = True
        Me.lblNomeRelatorio.Font = New System.Drawing.Font("Calibri", 12.25!)
        Me.lblNomeRelatorio.Location = New System.Drawing.Point(6, 6)
        Me.lblNomeRelatorio.Name = "lblNomeRelatorio"
        Me.lblNomeRelatorio.Size = New System.Drawing.Size(126, 21)
        Me.lblNomeRelatorio.TabIndex = 0
        Me.lblNomeRelatorio.Text = "Relatório Padrão"
        '
        'panelRodape
        '
        Me.panelRodape.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelRodape.Location = New System.Drawing.Point(0, 605)
        Me.panelRodape.Name = "panelRodape"
        Me.panelRodape.Size = New System.Drawing.Size(923, 39)
        Me.panelRodape.TabIndex = 1
        '
        'panelCorpo
        '
        Me.panelCorpo.Controls.Add(Me.ReportViewer1)
        Me.panelCorpo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelCorpo.Location = New System.Drawing.Point(0, 37)
        Me.panelCorpo.Name = "panelCorpo"
        Me.panelCorpo.Size = New System.Drawing.Size(923, 568)
        Me.panelCorpo.TabIndex = 2
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(923, 568)
        Me.ReportViewer1.TabIndex = 0
        '
        'frmRelatorios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(923, 644)
        Me.Controls.Add(Me.panelCorpo)
        Me.Controls.Add(Me.panelRodape)
        Me.Controls.Add(Me.panelTopo)
        Me.Name = "frmRelatorios"
        Me.Text = "Relatorios"
        Me.panelTopo.ResumeLayout(False)
        Me.panelTopo.PerformLayout()
        Me.panelCorpo.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelTopo As Panel
    Friend WithEvents panelRodape As Panel
    Friend WithEvents panelCorpo As Panel
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents lblNomeRelatorio As Label
End Class
