Imports Microsoft.Reporting.WinForms
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools

Public Class frmRelatorios
    Inherits Office2010Form

    Private Sub frmRelatorios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = frnPrincipal.Icon
    End Sub


    Public Sub GerarRelatorio(RELATORIO As String, DATTASETNOME As String, DATASETDADOS As DataTable, Optional DT_IN As String = "", Optional DT_OUT As String = "", Optional TITULO As String = "RELATÓRIO PADRÃO")
        With Me.ReportViewer1.LocalReport
            ' Caminho para o relatório 
            .ReportPath = Application.StartupPath & "\" & RELATORIO
            .DataSources.Clear()
            'MsgBox(.ReportPath.ToString)
            If DT_IN.Length > 2 Then
                Dim parameters(1) As ReportParameter
                parameters(0) = New ReportParameter("DT_IN", DT_IN)
                parameters(1) = New ReportParameter("DT_OUT", DT_OUT)

                .SetParameters(parameters)
            End If

        End With
        'Using ds As New DataSet
        '    Dim rptDataSource As New ReportDataSource(DATTASET, ds.Tables(0))
        '    Me.ReportViewer1.LocalReport.DataSources.Add(rptDataSource)
        'End Using

        lblNomeRelatorio.Text = TITULO

        Dim rptDataSource As New ReportDataSource(DATTASETNOME, DATASETDADOS)
        Me.ReportViewer1.LocalReport.DataSources.Add(rptDataSource)


        ReportViewer1.RefreshReport()


        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        ReportViewer1.ZoomMode = ZoomMode.Percent
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class