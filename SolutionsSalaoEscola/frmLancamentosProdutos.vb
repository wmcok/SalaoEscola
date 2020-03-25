Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools

Public Class frmLancamentosProdutos
    Inherits Office2010Form
    Public CodLancamento As Integer
    Public Acao As String = "INICIO"
    Dim DSet As New DataSet
    Dim db As New AplicationContext()
    Dim Estatus As Boolean = False

    Private Sub frmLancamentosProdutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.skinfrmLancamentosProdutos = frmLogin.SfSkinManager1
        Me.skinfrmLancamentosProdutos.Controls = Me
        Me.Icon = frnPrincipal.Icon
    End Sub

    Private Sub frmLancamentosProdutos_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        'MsgBox(CodLancamento)

        PREENCHE_CBOX_PRODUTO(cboxProdutos, False)
        If Not IsNothing(CodLancamento) Then
            txtCodLancamento.Text = CodLancamento
            PREENCHE_DG()
            CONTROLE_GRUD(Acao, btnInserir, btnAlterar, btnExcluir, btnCancelar, btnGravar)
        Else
            CONTROLE_GRUD(Acao, btnInserir, btnAlterar, btnExcluir, btnCancelar, btnGravar)
        End If
        ATUALIZATOTAL(False)
        AtualizaEstatus()
    End Sub
    Private Sub AtualizaEstatus()
        If db.LancamentosProdutos.Where(Function(m) m.CodLancamento = CodLancamento).Count > 0 Then
            Estatus = True
            btnFinalizarLanc.Text = "Finalizar Lançamento"
            btnFinalizarLanc.BackColor = Color.Aquamarine
        Else
            Estatus = False
            btnFinalizarLanc.Text = "Fechar / Cancelar"
            btnFinalizarLanc.BackColor = Color.Coral
        End If
        'MsgBox(Estatus)
    End Sub

    Private Sub PREENCHE_DG()
        msgAguarde.Visible = True
        DSet.Clear()
        DSet.Tables.Clear()


        Using BASE As New AplicationContext()
            Dim Res = From LP In BASE.LancamentosProdutos
                      Join L In BASE.Lancamentos On L.Codigo Equals LP.CodLancamento
                      Join P In BASE.Produtos On P.Codigo Equals LP.CodProduto
                      Where LP.CodLancamento = CodLancamento
                      Order By LP.Codigo Descending
                      Select CODIGO = LP.Codigo, CODLANCAMENTO = L.Codigo, LANCAMENTO = L.Observacao, CODPRODUTO = P.Codigo, PRODUTO = P.Nome, VL_TOTAL = LP.Valor, QTDE = LP.Quantidade
            DSet.Tables.Add(ConverterListParaDataTable(Res.ToList))

            'From L In BASE.Lancamentos
            'From P In BASE.Produtos
            'Select Case New With {
            '.CODIGO = LP.Codigo,
            '           .CODLANCAMENTO = L.Codigo,
            '           .LANCAMENTO = L.Observacao,
            '           .CODPRODUTO = P.Codigo,
            '           .PRODUTO = P.Nome,
            '           .VALOR = LP.Valor,
            '           .QUANTIDADE = LP.Quantidade
            '           }

            ' DSet.Tables.Add(ConvertToDataTable(Res.Where(Function(n) n.CODLANCAMENTO = CodLancamento).OrderByDescending(Function(n) n.CODIGO).ToList()))
        End Using

        dgResultado.DataSource = Nothing
        dgResultado.Refresh()

        If DSet.Tables(0).Rows.Count > 0 Then
            dgResultado.DataSource = DSet.Tables(0).DefaultView
            dgResultado.Columns("CODIGO").Width = 50
            dgResultado.Columns("CodLancamento").Width = 50
            dgResultado.Columns("Lancamento").Width = 120
            dgResultado.Columns("CodProduto").Width = 30
            dgResultado.Columns("Produto").Width = 120
            dgResultado.Columns("VL_TOTAL").Width = 75
            dgResultado.Columns("QTDE").Width = 50
        End If
        COLORIRGRD(dgResultado)
        msgAguarde.Visible = False
    End Sub

    Private Sub SALVAR(TIPO As String)
        Dim CodProd() As String = Split(cboxProdutos.Text, "-")
        Dim CodigoProduto As Integer = CInt(CodProd(0))

        'MsgBox(codfil)
        Dim Produtos As Produto = db.Produtos.First(Function(M) M.Codigo = CInt(CodigoProduto))

        If Acao = "INSERIR" Then
            Using BASE As New AplicationContext()

                Dim Lancamentosprod As New LancamentoProduto() With {
                     .CodLancamento = CodLancamento,
                     .CodProduto = Produtos.Codigo,
                     .Valor = txtValorTotal.Text,
                     .Quantidade = txtQtde.Text
                     }
                BASE.LancamentosProdutos.Add(Lancamentosprod)
                BASE.SaveChanges()

            End Using

            'CONTAR REGISTROS
            'Dim TOTAL As Decimal = (From LANC In db.LancamentosProdutos
            '                        Where LANC.CodLancamento = CodLancamento
            '                        Select LANC.Valor).Sum()

            'SOMAR REGISTROS
            ATUALIZATOTAL(True)

            MsgBox("Novo Lancamento Inserido com Sucesso!", MsgBoxStyle.Information, "Solutions Salão Escola")
        ElseIf Acao = "ALTERAR" Then
            Using BASE As New AplicationContext()

                Dim Lancamentosprod As LancamentoProduto = BASE.LancamentosProdutos.First(Function(M) M.Codigo = txtCodigo.Text)
                Lancamentosprod.Codigo = txtCodigo.Text
                Lancamentosprod.CodLancamento = txtCodLancamento.Text
                Lancamentosprod.CodProduto = Produtos.Codigo
                Lancamentosprod.Valor = txtValorTotal.Text
                Lancamentosprod.Quantidade = txtQtde.Text

                BASE.SaveChanges()

            End Using

            ATUALIZATOTAL(True)


            MsgBox("Lancamentos Atualizado com Sucesso!", MsgBoxStyle.Information, "Solutions Salão Escola")
        ElseIf Acao = "EXCLUIR" Then
            If MsgBox("Tem Certeza que deseja Excluir Este Registro?" & vbCrLf & txtCodigo.Text & " - " & cboxProdutos.Text, MsgBoxStyle.OkCancel, "Solutions Salão Escola") = MsgBoxResult.Ok Then
                Using BASE As New AplicationContext()
                    Dim Lancamentosprod As LancamentoProduto = BASE.LancamentosProdutos.First(Function(M) M.Codigo = txtCodigo.Text)
                    BASE.LancamentosProdutos.Attach(Lancamentosprod)
                    BASE.Entry(Lancamentosprod).State = Entity.EntityState.Deleted
                    BASE.SaveChanges()
                End Using

                ATUALIZATOTAL(True)
            End If

        End If
        Acao = ""
        dgResultado.Enabled = True
        txtPesquisarGrid.Enabled = True
        PREENCHE_DG()
        AtualizaEstatus()
    End Sub

    Private Function ATUALIZATOTAL(Atualizar As Boolean) As Decimal
        Dim TOTAL As Decimal = If(db.LancamentosProdutos.Where(Function(m) m.CodLancamento = CodLancamento).ToList.Count < 1, 0, db.LancamentosProdutos.Where(Function(m) m.CodLancamento = CodLancamento).Sum(Function(n) n.Valor))


        If Atualizar = True Then
            Using BASE As New AplicationContext()
                Dim Lancamentos As Lancamento = BASE.Lancamentos.First(Function(M) M.Codigo = CodLancamento)
                Lancamentos.Valor = TOTAL
                BASE.SaveChanges()
            End Using
        End If

        lblValorTotal.Text = "R$ " & TOTAL.ToString
    End Function
    Private Sub btnInserir_Click(sender As Object, e As EventArgs) Handles btnInserir.Click
        Acao = "INSERIR"
        CONTROLE_GRUD(Acao, btnInserir, btnAlterar, btnExcluir, btnCancelar, btnGravar)
        txtCodigo.Text = ""
        txtCodigo.ReadOnly = True
        txtQtde.Text = 1

        dgResultado.Enabled = False
        txtPesquisarGrid.Enabled = False

    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        Acao = "ALTERAR"
        CONTROLE_GRUD(Acao, btnInserir, btnAlterar, btnExcluir, btnCancelar, btnGravar)
        txtCodigo.ReadOnly = True
        dgResultado.Enabled = False
        txtPesquisarGrid.Enabled = False
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Acao = "EXCLUIR"
        CONTROLE_GRUD("EXCLUIR", btnInserir, btnAlterar, btnExcluir, btnCancelar, btnGravar)
        SALVAR("EXCLUIR")
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Acao = "CANCELAR"
        CONTROLE_GRUD(Acao, btnInserir, btnAlterar, btnExcluir, btnCancelar, btnGravar)
        dgResultado.Enabled = True
        txtPesquisarGrid.Enabled = True
        txtCodigo.ReadOnly = False
        PREENCHE_DG()
    End Sub

    Private Sub btnGravar_Click(sender As Object, e As EventArgs) Handles btnGravar.Click

        CONTROLE_GRUD("GRAVAR", btnInserir, btnAlterar, btnExcluir, btnCancelar, btnGravar)
        SALVAR(Acao)
        txtCodigo.ReadOnly = False



    End Sub

    Private Sub cboxProdutos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxProdutos.SelectedIndexChanged
        Dim CodProd() As String = Split(cboxProdutos.Text, "-")
        Dim CodigoProduto As Integer = CInt(CodProd(0))
        Dim Produtos As Produto = db.Produtos.First(Function(M) M.Codigo = CInt(CodigoProduto))
        If Acao = "INICIO" Then
            txtPreco.Text = Produtos.Preco
        Else

            txtPreco.Text = Produtos.Preco
            txtValorTotal.Text = txtPreco.Text * txtQtde.Text
        End If
    End Sub

    Private Sub txtQtde_TextChanged(sender As Object, e As EventArgs) Handles txtQtde.TextChanged
        If Acao = "INICIO" Then
        Else
            txtValorTotal.Text = txtPreco.Text * txtQtde.Text
        End If

    End Sub

    Private Sub btnFinalizarLanc_Click(sender As Object, e As EventArgs) Handles btnFinalizarLanc.Click
        'If Estatus = False Then
        '    If MsgBox("Tem Certeza que deseja sair sem Incluir um produto valido?" & vbCrLf & "Esta ação vai Cancelado o Lancament.", MsgBoxStyle.OkCancel, "Solutions Salão Escola") = MsgBoxResult.Ok Then
        '        Using BASE As New AplicationContext()
        '            Dim lancamentos As Lancamento = BASE.Lancamentos.First(Function(M) M.Codigo = CInt(CodLancamento))
        '            BASE.Lancamentos.Attach(lancamentos)
        '            BASE.Entry(lancamentos).State = Entity.EntityState.Deleted
        '            BASE.SaveChanges()
        '        End Using
        '    End If
        'End If

        Me.Close()
        'frmLancamentos.MdiParent = frnPrincipal
        'frmLancamentos.CodProd = CInt(CodLancamento)
        'frmLancamentos.Show()
        'frmLancamentos.Location = New System.Drawing.Point(3, 2)
        'frmLancamentos.Focus()

    End Sub

    Private Sub dgResultado_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgResultado.CellEnter
        Dim CodigoProd As Integer = If(IsDBNull(dgResultado.CurrentRow.Cells(3).Value), 0, CInt(dgResultado.CurrentRow.Cells(3).Value))
        Dim produtos As Produto = db.Produtos.First(Function(M) M.Codigo = CInt(CodigoProd))
        'MsgBox(CodigoProd)
        txtCodigo.Text = dgResultado.CurrentRow.Cells(0).Value
        cboxProdutos.Text = produtos.Codigo & "-" & produtos.Nome
        txtValorTotal.Text = dgResultado.CurrentRow.Cells(5).Value
        txtQtde.Text = dgResultado.CurrentRow.Cells(6).Value
        'CodLancamento = dgResultado.CurrentRow.Cells(1).Value
        txtPrVendido.Text = dgResultado.CurrentRow.Cells(5).Value / dgResultado.CurrentRow.Cells(6).Value
        txtCodLancamento.Text = CodLancamento
    End Sub

    Private Sub txtValorTotal_TextChanged(sender As Object, e As EventArgs) Handles txtValorTotal.TextChanged
        txtPrVendido.Text = txtValorTotal.Text / txtQtde.Text
    End Sub
End Class