Imports Syncfusion.Windows.Forms.Tools
Imports Syncfusion.Windows.Forms.Tools.Win32API

Public Class Form1
    Dim db As New AplicationContext()
    Dim DSet As New DataSet
    Public Acao As String = "INICIO"
    Dim CodigoLancamento As Integer
    Dim Estatus As Boolean = False
    Dim ProdutosItens As New List(Of LancamentoProduto)
    Dim IndexProduto As Integer = 0
    Dim TOTAL As Decimal = 0

    Public Sub ATUALIZA_DG()
        dgResultado.DataSource = Nothing
        dgResultado.Refresh()

        dgResultado.DataSource = ProdutosItens

        'If DSet.Tables(0).Rows.Count > 0 Then
        '    dgResultado.DataSource = DSet.Tables(0).DefaultView
        dgResultado.Columns("CODIGO").Width = 50
        dgResultado.Columns("CodLancamento").Width = 50
        dgResultado.Columns("CodLancamento").Visible = False
        dgResultado.Columns("Lancamento").Width = 80
        dgResultado.Columns("Lancamento").Visible = False
        dgResultado.Columns("CodProduto").Width = 70
        dgResultado.Columns("Produto").Width = 80
        dgResultado.Columns("Produto").Visible = False
        dgResultado.Columns("Valor").Width = 80
        dgResultado.Columns("Quantidade").Width = 80
        'End If
        dgResultado.Refresh()
        COLORIRGRD(dgResultado)
        'lblValorTotal.Text = "R$ " & ProdutosItens.Where(Function(m) m.CodLancamento = CodigoLancamento).Sum(Function(n) n.Valor)
        ATUALIZATOTAL(False)
    End Sub
    Private Sub INSERIRITEM()
        Dim Lancamentosprod As New LancamentoProduto() With {
                        .Codigo = IndexProduto + 1,
                        .CodLancamento = CodigoLancamento,
                        .Lancamento = db.Lancamentos.Find(CodigoLancamento),
                        .CodProduto = CInt(Split(cboxProdutos.Text, "-")(0)),
                        .Produto = db.Produtos.Find(CInt(Split(cboxProdutos.Text, "-")(0))),
                        .Valor = txtValorTotal.Text,
                        .Quantidade = txtQtde.Text
                        }
        ProdutosItens.Add(Lancamentosprod)
        IndexProduto = Lancamentosprod.Codigo
        ' DSet.Tables.Add(ConverterListParaDataTable(ProdutosItens.ToList))
        ATUALIZA_DG()
    End Sub
    Private Sub ALTERARITEM()
        Dim Cod As Integer = CInt(TextBoxExt1.Text)
        Dim codPr As Integer = CInt(Split(cboxProdutos.Text, "-")(0))

        ProdutosItens.Find(Function(m) m.Codigo = Cod).CodProduto = codPr
        ProdutosItens.Find(Function(m) m.Codigo = Cod).Valor = txtValorTotal.Text
        ProdutosItens.Find(Function(m) m.Codigo = Cod).Quantidade = txtQtde.Text

        ATUALIZA_DG()
    End Sub
    Private Sub EXCLUIRITEM()
        Dim Cod As Integer = CInt(TextBoxExt1.Text)
        ProdutosItens.Remove(ProdutosItens.Find(Function(m) m.Codigo = Cod))
        'ProdutosItens.Remove(ProdutosItens.Find(Function(m) m.Codigo = CInt(TextBoxExt1.Text) And m.CodLancamento = CodigoLancamento And m.CodProduto = CInt(Split(cboxProdutos.Text, "-")(0)) And m.Valor = txtValorTotal.Text And m.Quantidade = txtQtde.Text))
        ATUALIZA_DG()
    End Sub

    Private Sub VerItem()
        Dim TXT As String = ""
        For Each item In ProdutosItens
            TXT &= item.CodProduto & vbCrLf
        Next
        MsgBox(TXT)
    End Sub

    Private Function GravarNovo() As Boolean
        Try

            '================================================================================================
            'GRAVA LANCAMENTOS
            Dim CodFilial() As String = Split(cboxFilial.Text, "-")
            Dim CodNatureza() As String = Split(cboxNatureza.Text, "-")
            Dim Codigofilial As Integer = CodFilial(0)
            Dim CodigoNatu As Integer = CodNatureza(0)
            'MsgBox(codfil)
            Dim filial As Filial = db.Filiais.First(Function(M) M.Codigo = CInt(Codigofilial))
            Dim natureza As Natureza = db.Naturezas.First(Function(M) M.Codigo = CInt(CodigoNatu))
            Using BASE As New AplicationContext()

                Dim lancamentos As New Lancamento() With {
                     .Data = dtInicio.Value,
                     .Valor = txtValorTotalLanc.Text,
                     .CodUsuario = VariaveisGlobais.UsuarioLogado.Codigo,
                     .CodFilial = filial.Codigo,
                     .CodNatureza = natureza.Codigo,
                     .Observacao = txtObservacao.Text
                     }
                BASE.Lancamentos.Add(lancamentos)
                BASE.SaveChanges()
                CodigoLancamento = lancamentos.Codigo
                txtCodigo.Text = CodigoLancamento
                PgLancamento.Enabled = False
                'MsgBox(UltimoCodigo)
            End Using
            '================================================================================================
            'GRAVAR OS ITENS / PRODUTOS

            Dim CodProd() As String = Split(cboxProdutos.Text, "-")
            Dim CodigoProduto As Integer = CInt(CodProd(0))

            'MsgBox(codfil)
            Dim Produtos As Produto = db.Produtos.First(Function(M) M.Codigo = CInt(CodigoProduto))
            Using BASE As New AplicationContext()
                For Each ITEM In ProdutosItens
                    'MsgBox(ITEM.Valor)
                    Dim Lancamentosprod As New LancamentoProduto() With {
                        .CodLancamento = CodigoLancamento,
                        .CodProduto = ITEM.CodProduto,
                        .Valor = ITEM.Valor,
                        .Quantidade = ITEM.Quantidade
                        }
                    BASE.LancamentosProdutos.Add(Lancamentosprod)
                    BASE.SaveChanges()
                Next
                'Dim Lancamentosprod As New LancamentoProduto() With {
                '     .CodLancamento = CodigoLancamento,
                '     .CodProduto = Produtos.Codigo,
                '     .Valor = txtValorTotal.Text,
                '     .Quantidade = txtQtde.Text
                '     }
                'BASE.LancamentosProdutos.Add(Lancamentosprod)
                'BASE.SaveChanges()

            End Using
            ATUALIZATOTAL(True)

            '================================================================================================
            'GRAVAR FINANCEIRO DO LANCAMENTO
            If checkGerarFinanceiro.CheckState = CheckState.Checked And checkBaixarFinanceiro.CheckState = CheckState.Checked Then

                Using BASE As New AplicationContext()
                    Dim FINANCEIRO As New Financeiro() With {
                        .Tipo = TipoFinanceiro.Receber,
                        .CodNatureza = CodigoNatu,
                        .CodLancamento = CodigoLancamento,
                        .Descricao = "Lanc.: " & CodigoLancamento.ToString & " - " & txtObservacao.Text,
                        .Vencimento = dtDataVencimento.Value,
                        .Valor = txtValorVenc.Text,
                        .DataPagamento = dtDataPagamento.Value,
                        .ValorPago = txtValorPago.Text,
                        .CodUsuario = VariaveisGlobais.UsuarioLogado.Codigo,
                        .CodFilial = Codigofilial
                         }
                    BASE.Financeiros.Add(FINANCEIRO)
                    MsgBox(FINANCEIRO.DataPagamento)
                    BASE.SaveChanges()
                End Using
            ElseIf checkGerarFinanceiro.CheckState = CheckState.Checked And checkBaixarFinanceiro.CheckState = CheckState.Unchecked Then

                Using BASE As New AplicationContext()
                    Dim FINANCEIRO As New Financeiro() With {
                        .Tipo = TipoFinanceiro.Receber,
                        .CodNatureza = CodigoNatu,
                        .CodLancamento = CodigoLancamento,
                        .Descricao = "Lanc.: " & CodigoLancamento.ToString & " - " & txtObservacao.Text,
                        .Vencimento = dtDataVencimento.Value,
                        .Valor = txtValorVenc.Text,
                        .DataPagamento = Nothing,
                        .ValorPago = Nothing,
                        .CodUsuario = VariaveisGlobais.UsuarioLogado.Codigo,
                        .CodFilial = Codigofilial
                         }
                    BASE.Financeiros.Add(FINANCEIRO)
                    MsgBox(FINANCEIRO.DataPagamento)
                    BASE.SaveChanges()
                End Using
            End If



        Catch ex As Exception
            MsgBox(ex.Message)
        Return False
        Exit Function
        End Try
        Return True
    End Function


    Private Function ATUALIZATOTAL(Atualizar As Boolean) As Decimal
        Dim N1 As Integer = ProdutosItens.Where(Function(m) m.CodLancamento = CodigoLancamento).ToList.Count
        If N1 < 1 Then
            TOTAL = 0
        Else
            TOTAL = ProdutosItens.Where(Function(m) m.CodLancamento = CodigoLancamento).Sum(Function(n) n.Valor)
        End If

        lblValorTotal.Text = "R$ " & TOTAL.ToString
        txtValorTotalLanc.Text = TOTAL
        txtValorVenc.Text = TOTAL
        txtValorPago.Text = TOTAL


        If Atualizar = True Then
            Using BASE As New AplicationContext()
                Dim Lancamentos As Lancamento = BASE.Lancamentos.First(Function(M) M.Codigo = CodigoLancamento)
                Lancamentos.Valor = TOTAL
                BASE.SaveChanges()
            End Using
        End If


    End Function

    Private Sub VericaCancelar()
        If Estatus = False Then

            Dim QtLancamento As Integer = db.Lancamentos.Where(Function(m) m.Codigo = CodigoLancamento).Count
        Dim QtLancItens As Integer = db.LancamentosProdutos.Where(Function(m) m.CodLancamento = CodigoLancamento).Count
            If MsgBox("Tem Certeza que deseja Cancelar?", MsgBoxStyle.OkCancel, "Solutions Salão Escola") = MsgBoxResult.Ok Then
                Using BASE As New AplicationContext()
                    If QtLancItens > 0 Then
                        Dim lancitens As LancamentoProduto = BASE.LancamentosProdutos.First(Function(M) M.CodLancamento = CodigoLancamento)
                        BASE.LancamentosProdutos.Attach(lancitens)
                        BASE.Entry(lancitens).State = Entity.EntityState.Deleted
                        BASE.SaveChanges()
                    End If

                    If QtLancamento > 0 Then
                        Dim lancamentos As Lancamento = BASE.Lancamentos.First(Function(M) M.Codigo = CodigoLancamento)
                        BASE.Lancamentos.Attach(lancamentos)
                        BASE.Entry(lancamentos).State = Entity.EntityState.Deleted
                        BASE.SaveChanges()
                    End If
                End Using
            End If

        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SfSkinManager1 = frmLogin.SfSkinManager1
        Me.SfSkinManager1.Controls = Me
        Me.Icon = frnPrincipal.Icon
        dtInicio.Value = Now.Date


        PgLancamento.FinishVisible = False
        PgLancamento.FinishEnabled = False
        Pg2Produto.FinishVisible = False
        Pg2Produto.FinishEnabled = False
        Pg3Gravar.FinishEnabled = False
        Pg3Gravar.FinishVisible = False

        PREENCHE_CBOX_FILIAL(cboxFilial, False)
        PREENCHE_CBOX_NATUREZA(cboxNatureza, False)
        PREENCHE_CBOX_PRODUTO(cboxProdutos, False)


        'CONTROLE_GRUD(Acao, btnInserir, btnAlterar, btnExcluir, btnCancelar, btnGravar)
        btnCancelar.Visible = False
        btnGravar.Visible = False

    End Sub

    Private Sub WizardControl1_CancelButton_Click(sender As Object, e As EventArgs) Handles WizardControl1.CancelButton.Click
        VericaCancelar()
        Me.Close()
    End Sub


    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        If Not IsNothing(CodigoLancamento) Then
            'PREENCHE_DG()
            btnCancelar.Visible = False
            btnGravar.Visible = False
        Else
            btnCancelar.Visible = False
            btnGravar.Visible = False
        End If

    End Sub

    Private Sub btnInserir_Click(sender As Object, e As EventArgs) Handles btnInserir.Click
        If txtQtde.Text > 0 Then
            INSERIRITEM()
        Else
            MsgBox("Favor digitar uma Quantidade Válida!", MsgBoxStyle.OkOnly, "Solutions Salão Escola")
        End If

    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        If txtQtde.Text > 0 Then
            ALTERARITEM()
        Else
            MsgBox("Favor digitar uma Quantidade Válida!", MsgBoxStyle.OkOnly, "Solutions Salão Escola")
        End If

    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        If dgResultado.Rows.Count > 0 Then
            EXCLUIRITEM()
        Else
            MsgBox("Não existe Item para Ser Excluído!", MsgBoxStyle.OkOnly, "Solutions Salão Escola")
        End If

    End Sub



    Private Sub txtQtde_TextChanged(sender As Object, e As EventArgs) Handles txtQtde.TextChanged
        'txtValorTotal.Text = CDec(txtPreco.Text) * CDec(txtQtde.Text)
    End Sub

    Private Sub Pg2Produto_NextClick(sender As Object, e As EventArgs) Handles Pg2Produto.NextClick
        If ProdutosItens.Count > 0 Then
            checkList.SetItemCheckState(3, CheckState.Checked)
        Else
            checkList.SetItemCheckState(3, CheckState.Unchecked)
        End If

        'AtualizaEstatus()
    End Sub

    Private Sub btnGravarLancamento_Click(sender As Object, e As EventArgs) Handles btnGravarLancamento.Click

        Dim Checar As Boolean = True
        For i = 0 To checkList.Items.Count - 1
            If checkList.GetItemCheckState(i) = CheckState.Unchecked Then

                Checar = False

            End If
        Next

        If Checar = False Then
            If MsgBox("Não foi preenchido todos os Dados necessários para Gravar." & vbCrLf & "Tem Certeza que deseja sair sem Incluir um produto válido?" & vbCrLf & "Esta ação vai Cancelar o Lancamento.", MsgBoxStyle.OkCancel, "Solutions Salão Escola") = MsgBoxResult.Ok Then
                Me.Close()
            Else
                Exit Sub
            End If
        Else
            If GravarNovo() = True Then
                MsgBox("Lançamento Gravado com Sucesso!", MsgBoxStyle.OkOnly, "Solutions Salão Escola")
                Me.Close()
            Else
                MsgBox("Nõ foi possível concluir a gravação dos Dados." & vbCrLf & "Tente Novamente.", MsgBoxStyle.Exclamation, "Solutions Salão Escola")
                Me.Close()
            End If
        End If

    End Sub

    Private Sub cboxProdutos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxProdutos.SelectedIndexChanged
        If cboxProdutos.Items.Count > 0 Then
            'Dim CodProd() As String = Split(cboxProdutos.Text, "-")
            'Dim CodigoProduto As Integer = CInt(CodProd(0))
            txtPreco.Text = db.Produtos.Find(CInt(Split(cboxProdutos.Text, "-")(0))).Preco
            'txtValorTotal.Text = CDec(txtPreco.Text) * CDec(txtQtde.Text)
        End If

    End Sub

    Private Sub dgResultado_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgResultado.CellEnter
        If dgResultado.Rows.Count < 1 Then
            TextBoxExt1.Text = CodigoLancamento
            txtCodigo.Text = ""
            cboxProdutos.SelectedIndex = 0
        Else
            Dim CodigoProd As Integer = If(IsDBNull(dgResultado.CurrentRow.Cells(3).Value), 0, CInt(dgResultado.CurrentRow.Cells(3).Value))
            Dim produtos As Produto = db.Produtos.First(Function(M) M.Codigo = CInt(CodigoProd))
            TextBoxExt1.Text = dgResultado.CurrentRow.Cells(0).Value
            txtCodigo.Text = dgResultado.CurrentRow.Cells(1).Value
            cboxProdutos.Text = produtos.Codigo & "-" & produtos.Nome
            txtValorTotal.Text = dgResultado.CurrentRow.Cells(5).Value
            txtQtde.Text = dgResultado.CurrentRow.Cells(6).Value
            txtPrVendido.Text = dgResultado.CurrentRow.Cells(5).Value / dgResultado.CurrentRow.Cells(6).Value
        End If

    End Sub

    Private Sub PgLancamento_NextClick(sender As Object, e As EventArgs) Handles PgLancamento.NextClick
        If cboxFilial.Text.Length > 1 Then
            checkList.SetItemCheckState(0, CheckState.Checked)
        Else
            checkList.SetItemCheckState(0, CheckState.Unchecked)
        End If
        If cboxNatureza.Text.Length > 1 Then
            checkList.SetItemCheckState(1, CheckState.Checked)
        Else
            checkList.SetItemCheckState(1, CheckState.Unchecked)
        End If
        If txtObservacao.Text.Length > 2 Then
            checkList.SetItemCheckState(2, CheckState.Checked)
        Else
            checkList.SetItemCheckState(2, CheckState.Unchecked)
        End If

    End Sub

    Private Sub txtValorTotal_TextChanged(sender As Object, e As EventArgs) Handles txtValorTotal.TextChanged
        txtPrVendido.Text = txtValorTotal.Text / txtQtde.Text
    End Sub

    Private Sub WizardControl1_Load(sender As Object, e As EventArgs) Handles WizardControl1.Load

    End Sub

    Private Sub txtQtde_Leave(sender As Object, e As EventArgs) Handles txtQtde.Leave
        txtValorTotal.Text = CDec(txtPreco.Text) * CDec(txtQtde.Text)
    End Sub

    Private Sub checkGerarFinanceiro_CheckStateChanged(sender As Object, e As EventArgs) Handles checkGerarFinanceiro.CheckStateChanged
        If checkGerarFinanceiro.CheckState = CheckState.Checked Then
            panelFinVencimento.Visible = True
            dtDataVencimento.Value = dtInicio.Value
            txtValorVenc.Text = txtValorTotalLanc.Text

        Else
            dtDataPagamento.Value = Nothing
            txtValorVenc.Text = 0
            panelFinVencimento.Visible = False
            checkBaixarFinanceiro.CheckState = CheckState.Unchecked
        End If
    End Sub

    Private Sub checkBaixarFinanceiro_CheckStateChanged(sender As Object, e As EventArgs) Handles checkBaixarFinanceiro.CheckStateChanged
        If checkBaixarFinanceiro.CheckState = CheckState.Checked Then
            panelFinPagamento.Visible = True
            dtDataPagamento.Value = dtDataVencimento.Value
            txtValorPago.Text = txtValorVenc.Text

        Else
            dtDataPagamento.Value = Nothing
            txtValorPago.Text = 0
            panelFinPagamento.Visible = False

        End If
    End Sub
End Class