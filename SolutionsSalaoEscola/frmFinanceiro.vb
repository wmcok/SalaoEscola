Imports Syncfusion.Windows.Forms
Imports Syncfusion.WinForms.Controls

Public Class frmFinanceiro
    Inherits Office2010Form
    Public Acao As String = "INICIO"
    Dim Acao2 As String = ""
    Dim DSet As New DataSet
    Dim db As New AplicationContext()
    Dim UltimoCodigo As Integer
    Public CodFin As Integer = 0

    Private Sub PREENCHE_DG(Optional CODIGO As Integer = 0)
        msgAguarde.Visible = True
        DSet.Clear()
        DSet.Tables.Clear()
        Using BASE As New AplicationContext()
            If CODIGO = 0 Then
                Dim Res = From F In BASE.Financeiros
                          Join FI In BASE.Filiais On FI.Codigo Equals F.CodFilial
                          Join N In BASE.Naturezas On N.Codigo Equals F.CodNatureza
                          Order By F.Vencimento Descending, F.Codigo Descending
                          Select IDFINANC = F.Codigo,
                                    TIPO = F.Tipo,
                                    NATUREZA = F.CodNatureza & "-" & N.Nome,
                                    CODLANCAMENTO = F.CodLancamento,
                                     DESCRICAO = F.Descricao,
                                    VENCIMENTO = F.Vencimento,
                                    VALOR = F.Valor,
                                    DT_PAGAMENTO = F.DataPagamento,
                                    VL_PAGO = F.ValorPago,
                                    CODUSUARIO = F.CodUsuario,
                                    CODFILIAL = F.CodFilial & "-" & FI.Nome


                DSet.Tables.Add(ConverterListParaDataTable(Res.Take(25).ToList()))
            Else
                Dim Res = From F In BASE.Financeiros
                          Join FI In BASE.Filiais On FI.Codigo Equals F.CodFilial
                          Join N In BASE.Naturezas On N.Codigo Equals F.CodNatureza
                          Order By F.Vencimento Descending, F.Codigo Descending
                          Where F.Codigo = CODIGO
                          Select IDFINANC = F.Codigo,
                                    TIPO = F.Tipo,
                                    NATUREZA = F.CodNatureza & "-" & N.Nome,
                                    CODLANCAMENTO = F.CodLancamento,
                                     DESCRICAO = F.Descricao,
                                    VENCIMENTO = F.Vencimento,
                                    VALOR = F.Valor,
                                    DT_PAGAMENTO = F.DataPagamento,
                                    VL_PAGO = F.ValorPago,
                                    CODUSUARIO = F.CodUsuario,
                                    CODFILIAL = F.CodFilial & "-" & FI.Nome


                DSet.Tables.Add(ConverterListParaDataTable(Res.Take(25).ToList()))
            End If

            'End If


        End Using

        dgResultado.DataSource = Nothing
        dgResultado.Refresh()

        If DSet.Tables(0).Rows.Count > 0 Then
            dgResultado.DataSource = DSet.Tables(0).DefaultView
            dgResultado.Columns("IDFINANC").Width = 50
            dgResultado.Columns("TIPO").Width = 60
            dgResultado.Columns("NATUREZA").Width = 150
            dgResultado.Columns("CODLANCAMENTO").Width = 50
            dgResultado.Columns("DESCRICAO").Width = 180
            dgResultado.Columns("VENCIMENTO").Width = 75
            dgResultado.Columns("VALOR").Width = 50
            dgResultado.Columns("DT_PAGAMENTO").Width = 75
            dgResultado.Columns("VL_PAGO").Width = 50
            dgResultado.Columns("CODUSUARIO").Visible = False
            dgResultado.Columns("CODFILIAL").Width = 100

        End If
        COLORIRGRD(dgResultado)
        msgAguarde.Visible = False
    End Sub
    Private Sub SALVAR(TIPO As String)
        Dim CodFilial() As String = Split(cboxFilial.Text, "-")
        Dim CodNatureza() As String = Split(cboxNatureza.Text, "-")
        Dim Codigofilial As Integer = CodFilial(0)
        Dim CodigoNatu As Integer = CodNatureza(0)
        'MsgBox(codfil)
        Dim filial As Filial = db.Filiais.First(Function(M) M.Codigo = CInt(Codigofilial))
        Dim natureza As Natureza = db.Naturezas.First(Function(M) M.Codigo = CInt(CodigoNatu))
        If Acao = "INSERIR" Then
            Using BASE As New AplicationContext()
                If (checkPago.CheckState = CheckState.Checked) And txtCodigoLancamento.TextLength > 0 Then
                    Dim fFinanceiro As New Financeiro() With {
                        .Tipo = cboxTipoFinanceiro.SelectedIndex,
                        .CodNatureza = natureza.Codigo,
                        .CodLancamento = txtCodigoLancamento.Text,
                        .Descricao = txtObservacao.Text,
                        .Vencimento = dtVencimento.Value,
                        .Valor = txtValor.Text,
                        .DataPagamento = dtDataPagamento.Value,
                        .ValorPago = txtValorPago.Text,
                        .CodUsuario = VariaveisGlobais.UsuarioLogado.Codigo,
                        .CodFilial = filial.Codigo
                        }
                    BASE.Financeiros.Add(fFinanceiro)
                    BASE.SaveChanges()
                ElseIf (checkPago.CheckState = CheckState.Checked) And txtCodigoLancamento.TextLength < 1 Then
                    Dim fFinanceiro As New Financeiro() With {
                           .Tipo = cboxTipoFinanceiro.SelectedIndex,
                           .CodNatureza = natureza.Codigo,
                           .CodLancamento = Nothing,
                           .Descricao = txtObservacao.Text,
                           .Vencimento = dtVencimento.Value,
                           .Valor = txtValor.Text,
                           .DataPagamento = dtDataPagamento.Value,
                           .ValorPago = txtValorPago.Text,
                           .CodUsuario = VariaveisGlobais.UsuarioLogado.Codigo,
                           .CodFilial = filial.Codigo
                           }
                    BASE.Financeiros.Add(fFinanceiro)
                    BASE.SaveChanges()
                ElseIf (checkPago.CheckState = CheckState.Unchecked) And txtCodigoLancamento.TextLength > 0 Then
                    Dim fFinanceiro As New Financeiro() With {
                        .Tipo = cboxTipoFinanceiro.SelectedIndex,
                        .CodNatureza = natureza.Codigo,
                        .CodLancamento = txtCodigoLancamento.Text,
                        .Descricao = txtObservacao.Text,
                        .Vencimento = dtVencimento.Value,
                        .Valor = txtValor.Text,
                        .DataPagamento = Nothing,
                        .ValorPago = Nothing,
                        .CodUsuario = VariaveisGlobais.UsuarioLogado.Codigo,
                        .CodFilial = filial.Codigo
                        }
                    BASE.Financeiros.Add(fFinanceiro)
                    BASE.SaveChanges()
                ElseIf (checkPago.CheckState = CheckState.Unchecked) And txtCodigoLancamento.TextLength < 1 Then
                    Dim fFinanceiro As New Financeiro() With {
                        .Tipo = cboxTipoFinanceiro.SelectedIndex,
                        .CodNatureza = natureza.Codigo,
                        .CodLancamento = Nothing,
                        .Descricao = txtObservacao.Text,
                        .Vencimento = dtVencimento.Value,
                        .Valor = txtValor.Text,
                        .DataPagamento = Nothing,
                        .ValorPago = Nothing,
                        .CodUsuario = VariaveisGlobais.UsuarioLogado.Codigo,
                        .CodFilial = filial.Codigo
                        }
                    BASE.Financeiros.Add(fFinanceiro)
                    BASE.SaveChanges()
                End If


                'UltimoCodigo = BASE.Lancamentos.Max(Function(n) n.Codigo)
                'MsgBox(UltimoCodigo)
            End Using
            'MsgBox("Novo Lancamento Inserido com Sucesso!" & vbCrLf & "Agora Informe os Itens/Produtos Deste Lancamento.", MsgBoxStyle.Information, "Solutions Salão Escola")
        ElseIf Acao = "ALTERAR" Then
            Using BASE As New AplicationContext()

                Dim fFinanceiro As Financeiro = BASE.Financeiros.First(Function(M) M.Codigo = txtCodigoFinanceiro.Text)
                fFinanceiro.Codigo = txtCodigoFinanceiro.Text
                fFinanceiro.CodNatureza = natureza.Codigo
                If (txtCodigoLancamento.TextLength < 1) Then
                    fFinanceiro.CodLancamento = Nothing
                Else
                    fFinanceiro.CodLancamento = txtCodigoLancamento.Text
                End If
                fFinanceiro.Descricao = txtObservacao.Text
                fFinanceiro.Vencimento = dtVencimento.Value
                fFinanceiro.Valor = txtValor.Text
                If checkPago.CheckState = CheckState.Checked Then
                    fFinanceiro.DataPagamento = dtDataPagamento.Value
                    fFinanceiro.ValorPago = txtValorPago.Text
                Else
                    fFinanceiro.DataPagamento = Nothing
                    fFinanceiro.ValorPago = Nothing
                End If
                fFinanceiro.CodUsuario = VariaveisGlobais.UsuarioLogado.Codigo
                fFinanceiro.CodFilial = filial.Codigo

                BASE.SaveChanges()
                UltimoCodigo = fFinanceiro.Codigo
            End Using
            'MsgBox("Lancamento Atualizado com Sucesso!", MsgBoxStyle.Information, "Solutions Salão Escola")
        ElseIf Acao = "EXCLUIR" Then
            If MsgBox("Tem Certeza que deseja Excluir Este Registro?" & vbCrLf & txtCodigoFinanceiro.Text & " - " & txtObservacao.Text, MsgBoxStyle.OkCancel, "Solutions Salão Escola") = MsgBoxResult.Ok Then
                Using BASE As New AplicationContext()
                    Dim fFinanceiro As Financeiro = BASE.Financeiros.First(Function(M) M.Codigo = txtCodigoFinanceiro.Text)
                    BASE.Financeiros.Attach(fFinanceiro)
                    BASE.Entry(fFinanceiro).State = Entity.EntityState.Deleted
                    BASE.SaveChanges()
                End Using
            End If

        End If
        Acao = ""
        dgResultado.Enabled = True
        txtPesquisarGrid.Enabled = True
        PREENCHE_DG()

    End Sub
    Private Sub frmFinanceiro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = frnPrincipal.Icon


    End Sub

    Private Sub frmFinanceiro_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        PREENCHE_CBOX_FILIAL(cboxFilial, False)
        PREENCHE_CBOX_NATUREZA(cboxNatureza, False)

        If (CodFin <> 0) Then
            CONTROLE_GRUD(Acao, btnInserir, btnAlterar, btnExcluir, btnCancelar, btnGravar)
            PREENCHE_DG(CodFin)
        Else
            CONTROLE_GRUD(Acao, btnInserir, btnAlterar, btnExcluir, btnCancelar, btnGravar)
            PREENCHE_DG()
        End If
        checkPago.CheckState = CheckState.Checked

    End Sub

    Private Sub dgResultado_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgResultado.CellEnter
        If dgResultado.Rows.Count > 0 Then
            txtCodigoFinanceiro.Text = dgResultado.CurrentRow.Cells(0).Value
            cboxTipoFinanceiro.Text = dgResultado.CurrentRow.Cells(1).Value
            cboxNatureza.Text = dgResultado.CurrentRow.Cells(2).Value
            If IsDBNull(dgResultado.CurrentRow.Cells(3).Value) Then
                txtCodigoLancamento.Text = ""
            Else
                txtCodigoLancamento.Text = dgResultado.CurrentRow.Cells(3).Value
            End If
            txtObservacao.Text = dgResultado.CurrentRow.Cells(4).Value
                dtVencimento.Text = dgResultado.CurrentRow.Cells(5).Value
            txtValor.Text = dgResultado.CurrentRow.Cells(6).Value
            If IsDBNull(dgResultado.CurrentRow.Cells(7).Value) Then
                checkPago.CheckState = CheckState.Unchecked
                'panelPagamento.Visible = False
                dtDataPagamento.Text = ""
                txtValorPago.Text = 0
            Else
                checkPago.CheckState = CheckState.Checked
                'panelPagamento.Visible = True
                dtDataPagamento.Text = dgResultado.CurrentRow.Cells(7).Value
                txtValorPago.Text = dgResultado.CurrentRow.Cells(8).Value
            End If
            cboxFilial.Text = dgResultado.CurrentRow.Cells(10).Value
            End If
    End Sub

    Private Sub checkPago_CheckStateChanged(sender As Object, e As EventArgs) Handles checkPago.CheckStateChanged
        If checkPago.CheckState = CheckState.Checked Then
            panelPagamento.Visible = True
            dtDataPagamento.Value = dtVencimento.Value
            txtValorPago.Text = txtValor.Text
        Else
            dtDataPagamento.Value = Nothing
            txtValorPago.Text = 0
            panelPagamento.Visible = False
        End If
    End Sub

    Private Sub txtPesquisarGrid_TextChanged(sender As Object, e As EventArgs) Handles txtPesquisarGrid.TextChanged
        If txtPesquisarGrid.Text.Length > 1 Then
            DSet.Tables(0).DefaultView.RowFilter = "DESCRICAO like '%" + txtPesquisarGrid.Text + "%'"
        Else
            DSet.Tables(0).DefaultView.RowFilter = "DESCRICAO like '%%'"
        End If
    End Sub

    Private Sub txtPesquisarGrid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPesquisarGrid.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            If IsNumeric(txtPesquisarGrid.Text) Then
                PREENCHE_DG(CInt(txtPesquisarGrid.Text))
            ElseIf txtPesquisarGrid.TextLength < 1 Then
                PREENCHE_DG()
            End If
        End If
    End Sub

    Private Sub btnInserir_Click(sender As Object, e As EventArgs) Handles btnInserir.Click
        Acao = "INSERIR"
        CONTROLE_GRUD(Acao, btnInserir, btnAlterar, btnExcluir, btnCancelar, btnGravar)
        txtCodigoFinanceiro.Text = ""
        txtCodigoLancamento.Text = ""
        dtVencimento.Value = Now
        dtDataPagamento.Value = Now
        dgResultado.Enabled = False
        cboxTipoFinanceiro.SelectedIndex = 0
        cboxTipoFinanceiro.Focus()

    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        Acao = "ALTERAR"
        CONTROLE_GRUD(Acao, btnInserir, btnAlterar, btnExcluir, btnCancelar, btnGravar)
        dgResultado.Enabled = False
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Acao = "CANCELAR"
        CONTROLE_GRUD(Acao, btnInserir, btnAlterar, btnExcluir, btnCancelar, btnGravar)
        dgResultado.Enabled = True
    End Sub

    Private Sub btnGravar_Click(sender As Object, e As EventArgs) Handles btnGravar.Click
        ' Acao = "GRAVAR"
        CONTROLE_GRUD("GRAVAR", btnInserir, btnAlterar, btnExcluir, btnCancelar, btnGravar)
        dgResultado.Enabled = True
        SALVAR(Acao)
    End Sub

    Private Sub dtDataPagamento_ValueChanged(sender As Object, e As EventArgs) Handles dtDataPagamento.ValueChanged
        If checkPago.CheckState = CheckState.Checked And dtDataPagamento.Value < dtVencimento.Value Then
            dtDataPagamento.Value = dtVencimento.Value
        End If
    End Sub
End Class
