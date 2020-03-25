Imports System.ComponentModel.DataAnnotations
Imports System.Data.Entity.Core.Common.EntitySql
Imports System.Linq.Expressions
Imports System.Runtime.InteropServices
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools
Imports Syncfusion.Windows.Forms.Tools.Win32API
Imports Syncfusion.WinForms.DataGrid.Enums

Public Class frmControleFinanceiro
    Inherits Office2010Form
    Dim DSet As New DataSet
    Private Sub frmControleFinanceiro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = frnPrincipal.Icon
        dtInicioVenc.Value = DateAdd(DateInterval.Month, 0, Now).AddDays(-(Now.Day - 1))
        dtFinalVenc.Value = DateAdd(DateInterval.Month, +1, Now).AddDays(-(Now.Day))
        dtInicioPG.Value = DateAdd(DateInterval.Month, 0, Now).AddDays(-(Now.Day - 1))
        dtFinalPG.Value = DateAdd(DateInterval.Month, +1, Now).AddDays(-(Now.Day))
        cboxTipo.SelectedIndex = 0
        PREENCHE_CBOX_FILIAL(cboxFilial, True)
        PREENCHE_CBOX_NATUREZA(cboxNatureza, True)

        'PREENCHE_DG()
    End Sub
    Private Sub PREENCHE_DG()
        msgAguarde.Visible = True
        DSet.Clear()
        DSet.Tables.Clear()

        Dim Filial As String = ""
        Dim Natureza As String = ""
        Dim CodLancamento As String = ""
        Dim CodFinanceiro As String = ""
        Dim Tipo As String = ""
        Dim Vencimento As String = ""
        Dim Pagamento As String = ""

        If cboxFilial.SelectedIndex = 0 Then
            Filial = " "
        Else
            Dim CodFilial() As String = Split(cboxFilial.Text, "-")
            Filial = " AND F.CodFilial = '" & CodFilial(0) & "' "
        End If

        If cboxNatureza.SelectedIndex = 0 Then
            Natureza = " "
        Else
            Dim CodNatureza() As String = Split(cboxNatureza.Text, "-")
            Natureza = " AND F.CodFilial = '" & CodNatureza(0) & "' "
        End If

        If cboxTipo.SelectedIndex = 0 Then
            Tipo = " "
        ElseIf cboxTipo.SelectedIndex = 1 Then
            Tipo = " and F.Tipo IN (1)"
        ElseIf cboxTipo.SelectedIndex = 2 Then
            Tipo = " and F.Tipo IN (0)"
        End If

        If checkVencimento.CheckState = CheckState.Checked Then
            Dim dtin As Date = dtInicioVenc.Value
            Dim dtout As Date = dtFinalVenc.Value
            Vencimento = " F.Vencimento BETWEEN '" & dtin.Date.ToString("yyyy-MM-dd") & "' AND  '" & dtout.Date.ToString("yyyy-MM-dd") & "' "
        End If
        If checkPagamento.CheckState = CheckState.Checked And checkVencimento.CheckState = CheckState.Checked Then
            Dim dtin As Date = dtInicioPG.Value
            Dim dtout As Date = dtFinalPG.Value
            Pagamento = " and  F.Vencimento BETWEEN '" & dtin.Date.ToString("yyyy-MM-dd") & "' AND  '" & dtout.Date.ToString("yyyy-MM-dd") & "' "
        ElseIf checkPagamento.CheckState = CheckState.Checked And checkVencimento.CheckState = CheckState.Unchecked Then
            Dim dtin As Date = dtInicioPG.Value
            Dim dtout As Date = dtFinalPG.Value
            Pagamento = " F.Vencimento BETWEEN '" & dtin.Date.ToString("yyyy-MM-dd") & "' AND  '" & dtout.Date.ToString("yyyy-MM-dd") & "' "
        End If

        If txtCodLancamento.TextLength > 0 Then
            CodLancamento = " AND F.CodLancamento = '" & txtCodLancamento.Text & "'"
        End If

        If txtCodFinanceiro.TextLength > 0 Then
            CodFinanceiro = " AND F.Codigo = '" & txtCodFinanceiro.Text & "'"
        End If

        Dim LFinanceiro As List(Of Financeiro)
        Using BASE As New AplicationContext()

            'Dim Res = From L In BASE.Financeiros
            '          Join F In BASE.Filiais On F.Codigo Equals L.CodFilial
            '          Join N In BASE.Naturezas On N.Codigo Equals L.CodNatureza
            '          Where L.Vencimento <= dtFinalVenc.Value And L.Vencimento >= dtInicioVenc.Value
            '          Order By L.Vencimento, L.Tipo, L.Codigo Descending
            '          Select CODIGO = L.Codigo, TPO = L.Tipo, VENCIMENTO = L.Vencimento, VALOR = L.Valor, VL_PAGO = L.ValorPago, IDFILIAL = L.CodFilial, FILIAL = F.Nome, IDNATUREZA = L.CodNatureza, NATUREZA = N.Nome, DESCRICAO = L.Descricao

            ' F.Vencimento BETWEEN '2020-01-01' AND  '2020-03-31' 
            'AND F.DataPagamento  BETWEEN '2020-01-01' AND  '2020-03-31'
            'AND F.CodLancamento = ''
            'AND F.Codigo = ''
            'AND F.CodNatureza = ''

            LFinanceiro = New List(Of Financeiro)
            'LFinanceiro = BASE.Database.SqlQuery(Of Financeiro)("SELECT Codigo,Tipo,CodNatureza,CodLancamento,Descricao,Vencimento,Valor,DataPagamento,ValorPago,CodUsuario,CodFilial FROM Financeiro F WHERE 
            '                                                        F.Tipo IN (0,1)").OrderBy(Function(m) m.Vencimento).OrderBy(Function(m) m.Tipo).OrderBy(Function(m) m.Codigo).ToList

            LFinanceiro = BASE.Database.SqlQuery(Of Financeiro)("SELECT F.Codigo,F.Tipo,F.CodNatureza,CONVERT(VARCHAR,N.Codigo) +'-'+ N.NOME NATUREZA,F.CodLancamento,F.Descricao,F.Vencimento Vencimento,F.Valor,F.DataPagamento DataPagamento,F.ValorPago,F.CodUsuario,F.CodFilial,CONVERT(VARCHAR,FI.Codigo) +'-'+ FI.Nome FILIAL 
                                                                    FROM Financeiro F 
                                                                    INNER JOIN NATUREZAS N ON N.Codigo=F.CodNatureza
                                                                    INNER JOIN FILIAL FI ON FI.Codigo=F.CodFilial
                                                                    WHERE " & Vencimento & Pagamento & Tipo & Filial & Natureza & CodLancamento & CodFinanceiro).OrderBy(Function(m) m.Vencimento).OrderBy(Function(m) m.Tipo).OrderBy(Function(m) m.Codigo).ToList

            Dim TESTE = From L In LFinanceiro
                        Join F In BASE.Filiais On F.Codigo Equals L.CodFilial
                        Join N In BASE.Naturezas On N.Codigo Equals L.CodNatureza
                        Join U In BASE.Usuarios On U.Codigo Equals L.CodUsuario
                        Order By L.Vencimento, L.Tipo, L.Codigo Descending
                        Select Codigo = L.Codigo,
                        Tipo_Financ = L.Tipo,
                        IDNATUREZA = L.CodNatureza & "-" & N.Nome,
                        NOME_NATUREZA = N.Nome,
                        IDLancamento = L.CodLancamento,
                        DESCRICAO = L.Descricao,
                        DT_VENCIMENTO = L.Vencimento,
                        VALOR = L.Valor,
                        DT_PAGAMENTO = L.DataPagamento,
                        VL_PAGO = L.ValorPago,
                        IDUSUARIO = L.CodUsuario,
                        NOME_USUARIO = U.Nome,
                        IDFILIAL = L.CodFilial & "-" & F.Nome,
                        NOME_FILIAL = F.Nome



            'DSet.Tables.Add(ConvertToDataTable(LFinanceiro.ToList))
            DSet.Tables.Add(ConverterListParaDataTable(TESTE.ToList))

        End Using
        dgResultado.DataSource = Nothing
        dgResultado.Refresh()
        If DSet.Tables(0).Rows.Count > 0 Then
            dgResultado.DataSource = DSet.Tables(0).DefaultView
            dgResultado.Columns("Codigo").Width = 40
            dgResultado.Columns("Tipo_Financ").Width = 60
            dgResultado.Columns("IDNATUREZA").Width = 120
            dgResultado.Columns("NOME_NATUREZA").Visible = False
            dgResultado.Columns("NOME_NATUREZA").Width = 70
            dgResultado.Columns("IDLancamento").Width = 70
            dgResultado.Columns("Descricao").Width = 120
            dgResultado.Columns("DT_VENCIMENTO").Width = 80
            dgResultado.Columns("Valor").Width = 60
            dgResultado.Columns("DT_PAGAMENTO").Width = 80
            dgResultado.Columns("VL_PAGO").Width = 60
            dgResultado.Columns("IDUSUARIO").Visible = False
            dgResultado.Columns("NOME_USUARIO").Visible = False
            dgResultado.Columns("IDFILIAL").Width = 120
            dgResultado.Columns("NOME_FILIAL").Width = 120
            dgResultado.Columns("NOME_FILIAL").Visible = False
        End If
        COLORIRGRD(dgResultado)
        msgAguarde.Visible = False
    End Sub
    Private Sub AbreRelatorio()
        Dim Filial As String = ""
        Dim Natureza As String = ""
        Dim CodLancamento As String = ""
        Dim CodFinanceiro As String = ""
        Dim Tipo As String = ""
        Dim Vencimento As String = ""
        Dim Pagamento As String = ""

        If cboxFilial.SelectedIndex = 0 Then
            Filial = " "
        Else
            Dim CodFilial() As String = Split(cboxFilial.Text, "-")
            Filial = " AND F.CodFilial = '" & CodFilial(0) & "' "
        End If

        If cboxNatureza.SelectedIndex = 0 Then
            Natureza = " "
        Else
            Dim CodNatureza() As String = Split(cboxNatureza.Text, "-")
            Natureza = " AND F.CodFilial = '" & CodNatureza(0) & "' "
        End If

        If cboxTipo.SelectedIndex = 0 Then
            Tipo = " "
        ElseIf cboxTipo.SelectedIndex = 1 Then
            Tipo = " and F.Tipo IN (1)"
        ElseIf cboxTipo.SelectedIndex = 2 Then
            Tipo = " and F.Tipo IN (0)"
        End If

        If checkVencimento.CheckState = CheckState.Checked Then
            Dim dtin As Date = dtInicioVenc.Value
            Dim dtout As Date = dtFinalVenc.Value
            Vencimento = " F.Vencimento BETWEEN '" & dtin.Date.ToString("yyyy-MM-dd") & "' AND  '" & dtout.Date.ToString("yyyy-MM-dd") & "' "
        End If
        If checkPagamento.CheckState = CheckState.Checked And checkVencimento.CheckState = CheckState.Checked Then
            Dim dtin As Date = dtInicioPG.Value
            Dim dtout As Date = dtFinalPG.Value
            Pagamento = " and  F.Vencimento BETWEEN '" & dtin.Date.ToString("yyyy-MM-dd") & "' AND  '" & dtout.Date.ToString("yyyy-MM-dd") & "' "
        ElseIf checkPagamento.CheckState = CheckState.Checked And checkVencimento.CheckState = CheckState.Unchecked Then
            Dim dtin As Date = dtInicioPG.Value
            Dim dtout As Date = dtFinalPG.Value
            Pagamento = " F.Vencimento BETWEEN '" & dtin.Date.ToString("yyyy-MM-dd") & "' AND  '" & dtout.Date.ToString("yyyy-MM-dd") & "' "
        End If

        If txtCodLancamento.TextLength > 0 Then
            CodLancamento = " AND F.CodLancamento = '" & txtCodLancamento.Text & "'"
        End If

        If txtCodFinanceiro.TextLength > 0 Then
            CodFinanceiro = " AND F.Codigo = '" & txtCodFinanceiro.Text & "'"
        End If

        Dim LFinanceiro As List(Of ReportFinanceiro)
        Using BASE As New AplicationContext()



            LFinanceiro = New List(Of ReportFinanceiro)

            LFinanceiro = BASE.Database.SqlQuery(Of ReportFinanceiro)("SELECT F.Codigo IDFINANCEIRO,CASE F.TIPO WHEN 0 THEN 'PAGAR' WHEN 1 THEN 'RECEBER' END TIPO,F.CodNatureza IDNATUREZA,N.NOME NATUREZA,F.CodLancamento IDLANCAMENTO,F.Descricao DESCRICAO,
                                                                    F.Vencimento DT_VENCIMENTO,F.Valor VALOR,F.DataPagamento DT_PAGAMENTO,F.ValorPago VL_PAGO,F.CodUsuario IDUSUARIO,U.NOME USUARIO,F.CodFilial IDFILIAL,FI.Nome FILIAL 
                                                                    FROM Financeiro F 
                                                                    INNER JOIN NATUREZAS N ON N.Codigo=F.CodNatureza
                                                                    INNER JOIN FILIAL FI ON FI.Codigo=F.CodFilial
                                                                    INNER JOIN USUARIOS U ON U.CODIGO = F.CodUsuario
                                                                    WHERE " & Vencimento & Pagamento & Tipo & Filial & Natureza & CodLancamento & CodFinanceiro).OrderBy(Function(m) m.DT_VENCIMENTO).OrderBy(Function(m) m.TIPO).OrderBy(Function(m) m.IDFINANCEIRO).ToList


            frmRelatorios.MdiParent = frnPrincipal

            frmRelatorios.GerarRelatorio("rptRelFinanceiro.rdlc", "ReportFinanceiro", ConverterListParaDataTable(LFinanceiro.ToList()), "", "", "RELATÓRIO FINANCEIRO")



            'FORM.child()
            frmRelatorios.Show()
            frmRelatorios.Location = New System.Drawing.Point(35, 2)
            frmRelatorios.Focus()


        End Using
    End Sub
    Private Sub AbreRelatorio2()
        Dim Filial As String = ""
        Dim Natureza As String = ""
        Dim CodLancamento As String = ""
        Dim CodFinanceiro As String = ""
        Dim Tipo As String = ""
        Dim Vencimento As String = ""
        Dim Pagamento As String = ""

        If cboxFilial.SelectedIndex = 0 Then
            Filial = " "
        Else
            Dim CodFilial() As String = Split(cboxFilial.Text, "-")
            Filial = " AND F.CodFilial = '" & CodFilial(0) & "' "
        End If

        If cboxNatureza.SelectedIndex = 0 Then
            Natureza = " "
        Else
            Dim CodNatureza() As String = Split(cboxNatureza.Text, "-")
            Natureza = " AND F.CodFilial = '" & CodNatureza(0) & "' "
        End If

        If cboxTipo.SelectedIndex = 0 Then
            Tipo = " "
        ElseIf cboxTipo.SelectedIndex = 1 Then
            Tipo = " and F.Tipo IN (1)"
        ElseIf cboxTipo.SelectedIndex = 2 Then
            Tipo = " and F.Tipo IN (0)"
        End If

        If checkVencimento.CheckState = CheckState.Checked Then
            Dim dtin As Date = dtInicioVenc.Value
            Dim dtout As Date = dtFinalVenc.Value
            Vencimento = " F.Vencimento BETWEEN '" & dtin.Date.ToString("yyyy-MM-dd") & "' AND  '" & dtout.Date.ToString("yyyy-MM-dd") & "' "
        End If
        If checkPagamento.CheckState = CheckState.Checked And checkVencimento.CheckState = CheckState.Checked Then
            Dim dtin As Date = dtInicioPG.Value
            Dim dtout As Date = dtFinalPG.Value
            Pagamento = " and  F.Vencimento BETWEEN '" & dtin.Date.ToString("yyyy-MM-dd") & "' AND  '" & dtout.Date.ToString("yyyy-MM-dd") & "' "
        ElseIf checkPagamento.CheckState = CheckState.Checked And checkVencimento.CheckState = CheckState.Unchecked Then
            Dim dtin As Date = dtInicioPG.Value
            Dim dtout As Date = dtFinalPG.Value
            Pagamento = " F.Vencimento BETWEEN '" & dtin.Date.ToString("yyyy-MM-dd") & "' AND  '" & dtout.Date.ToString("yyyy-MM-dd") & "' "
        End If

        If txtCodLancamento.TextLength > 0 Then
            CodLancamento = " AND F.CodLancamento = '" & txtCodLancamento.Text & "'"
        End If

        If txtCodFinanceiro.TextLength > 0 Then
            CodFinanceiro = " AND F.Codigo = '" & txtCodFinanceiro.Text & "'"
        End If

        Dim LFinanceiro As List(Of ReportFinanceiro)
        Using BASE As New AplicationContext()



            LFinanceiro = New List(Of ReportFinanceiro)

            LFinanceiro = BASE.Database.SqlQuery(Of ReportFinanceiro)("SELECT F.Codigo IDFINANCEIRO,CASE F.TIPO WHEN 0 THEN 'PAGAR' WHEN 1 THEN 'RECEBER' END TIPO,F.CodNatureza IDNATUREZA,N.NOME NATUREZA,F.CodLancamento IDLANCAMENTO,F.Descricao DESCRICAO,
                                                                    F.Vencimento DT_VENCIMENTO,F.Valor VALOR,F.DataPagamento DT_PAGAMENTO,F.ValorPago VL_PAGO,F.CodUsuario IDUSUARIO,U.NOME USUARIO,F.CodFilial IDFILIAL,FI.Nome FILIAL 
                                                                    FROM Financeiro F 
                                                                    INNER JOIN NATUREZAS N ON N.Codigo=F.CodNatureza
                                                                    INNER JOIN FILIAL FI ON FI.Codigo=F.CodFilial
                                                                    INNER JOIN USUARIOS U ON U.CODIGO = F.CodUsuario
                                                                    WHERE " & Vencimento & Pagamento & Tipo & Filial & Natureza & CodLancamento & CodFinanceiro).OrderBy(Function(m) m.DT_VENCIMENTO).OrderBy(Function(m) m.TIPO).OrderBy(Function(m) m.IDFINANCEIRO).ToList


            frmRelatorios.MdiParent = frnPrincipal

            frmRelatorios.GerarRelatorio("rptRelNatureza.rdlc", "RelNatureza", ConverterListParaDataTable(LFinanceiro.ToList()), "", "", "RELATÓRIO POR NATUREZA")



            'FORM.child()
            frmRelatorios.Show()
            frmRelatorios.Location = New System.Drawing.Point(35, 2)
            frmRelatorios.Focus()


        End Using
    End Sub
    Private Sub checkVencimento_CheckedChanged(sender As Object, e As EventArgs) Handles checkVencimento.CheckedChanged
        If checkVencimento.CheckState = CheckState.Checked Then
            panelVencimento.Enabled = True
        Else
            panelVencimento.Enabled = False
            checkPagamento.CheckState = CheckState.Checked
        End If
    End Sub

    Private Sub checkPagamento_CheckedChanged(sender As Object, e As EventArgs) Handles checkPagamento.CheckedChanged
        If checkPagamento.CheckState = CheckState.Checked Then
            panelPagamento.Enabled = True
        Else
            panelPagamento.Enabled = False
            checkVencimento.CheckState = CheckState.Checked
        End If
    End Sub

    Private Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
        PREENCHE_DG()
    End Sub

    Private Sub dgResultado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgResultado.CellDoubleClick
        If dgResultado.CurrentCell.ColumnIndex = 4 And Not IsDBNull(dgResultado.CurrentRow.Cells(4).Value) Then
            'ABRE A TELA DE LANCAMENTOS
            frmLancamentos.MdiParent = frnPrincipal
            frmLancamentos.CodProd = dgResultado.CurrentRow.Cells(4).Value
            frmLancamentos.Acao = "INICIO"
            frmLancamentos.Show()
            frmLancamentos.Location = New System.Drawing.Point(3, 2)
            frmLancamentos.Focus()

        Else
            'ABRE A TELA DE EDIÇÃO DE FINANCEIRO
            frmFinanceiro.MdiParent = frnPrincipal
            frmFinanceiro.Acao = "INICIO"
            frmFinanceiro.CodFin = dgResultado.CurrentRow.Cells(0).Value
            frmFinanceiro.Show()
            frmFinanceiro.Location = New System.Drawing.Point(3, 2)
            frmFinanceiro.Focus()
        End If

    End Sub

    Private Sub btnNovoFinanceiro_Click(sender As Object, e As EventArgs) Handles btnNovoFinanceiro.Click
        frmFinanceiro.MdiParent = frnPrincipal
        frmFinanceiro.Acao = "INSERIR"
        frmFinanceiro.Show()
        frmFinanceiro.Location = New System.Drawing.Point(3, 2)
        frmFinanceiro.Focus()
    End Sub

    Private Sub dgResultado_Sorted(sender As Object, e As EventArgs) Handles dgResultado.Sorted
        COLORIRGRD(dgResultado)
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        AbreRelatorio()
    End Sub

    Private Sub AutoLabel2_Click(sender As Object, e As EventArgs) Handles AutoLabel2.Click

    End Sub

    Private Sub btnPrintNatureza_Click(sender As Object, e As EventArgs) Handles btnPrintNatureza.Click
        AbreRelatorio2()
    End Sub
End Class