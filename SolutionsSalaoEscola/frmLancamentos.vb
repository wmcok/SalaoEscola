Imports System.Runtime.InteropServices
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools
Imports Syncfusion.Windows.Forms.Tools.Win32API

Public Class frmLancamentos
    Inherits Office2010Form
    Public Acao As String = "INICIO"
    Dim Acao2 As String = ""
    Dim DSet As New DataSet
    Dim db As New AplicationContext()
    Dim UltimoCodigo As Integer
    Public CodProd As Integer = 0
    'Dim FL As Filial

    Private Sub frmLancamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SfSkinManager1 = frmLogin.SfSkinManager1
        Me.SfSkinManager1.Controls = Me
        Icon = frnPrincipal.Icon
    End Sub

    Private Sub frmLancamentos_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        msgAguarde.Visible = True
        PREENCHE_CBOX_FILIAL(cboxFilial, False)
        PREENCHE_CBOX_NATUREZA(cboxNatureza, False)
        If (CodProd = 0) And Acao = "INSERIR" Then

            CONTROLE_GRUD("INSERIR", btnInserir, btnAlterar, btnExcluir, btnCancelar, btnGravar)
            dgResultado.Enabled = False
            txtPesquisarGrid.Enabled = False
            txtCodigo.Text = ""
            txtCodigo.ReadOnly = True
            txtObservacao.Text = ""

            cboxFilial.Focus()
            PREENCHE_DG()
        ElseIf (CodProd <> 0) Then

            PREENCHE_DG(CodProd)
            CONTROLE_GRUD(Acao, btnInserir, btnAlterar, btnExcluir, btnCancelar, btnGravar)
            cboxFilial.Enabled = False
        Else
            PREENCHE_DG()
            CONTROLE_GRUD(Acao, btnInserir, btnAlterar, btnExcluir, btnCancelar, btnGravar)
        End If

        msgAguarde.Visible = False
        'MsgBox(Acao & " - " & Acao2)
    End Sub

    Private Sub PREENCHE_DG(Optional CODIGO As Integer = 0)
        DSet.Clear()
        DSet.Tables.Clear()
        Using BASE As New AplicationContext()

            'Dim Res = From L In BASE.Lancamentos
            '          From LP In BASE.LancamentosProdutos
            '          From P In BASE.Produtos
            '          From F In BASE.Filiais
            '          From N In BASE.Naturezas
            '          Select New With {
            '                       .IDLANC = L.Codigo,
            '                       .DATA = L.Data,
            '                       .PRODUTO = LP.CodProduto & "-" & P.Nome,
            '                       .QTDE = LP.Quantidade,
            '                       .VALOR = L.Valor,
            '                       .CODUSUARIO = L.CodUsuario,
            '                       .USUARIO = L.Usuario,
            '                       .CODFILIAL = L.CodFilial & "-" & F.Nome,
            '                        .CODNATUREZA = L.CodNatureza & "-" & N.Nome,
            '                        .OBSERVACAO = L.Observacao
            '                       }


            'If (CODIGO < 1) Then
            '    Dim Res = From L In BASE.Lancamentos
            '              Join LP In BASE.LancamentosProdutos On LP.CodLancamento Equals L.Codigo
            '              Join P In BASE.Produtos On P.Codigo Equals LP.CodProduto
            '              Join F In BASE.Filiais On F.Codigo Equals L.CodFilial
            '              Join N In BASE.Naturezas On N.Codigo Equals L.CodNatureza
            '              Order By P.Codigo
            '              Select IDLANC = L.Codigo,
            '                    DATA = L.Data,
            '                    PRODUTO = LP.CodProduto & "-" & P.Nome,
            '                    QTDE = LP.Quantidade,
            '                    VALOR = L.Valor,
            '                    CODUSUARIO = L.CodUsuario,
            '                    USUARIO = L.Usuario,
            '                    CODFILIAL = L.CodFilial & "-" & F.Nome,
            '                    CODNATUREZA = L.CodNatureza & "-" & N.Nome,
            '                    OBSERVACAO = L.Observacao


            '    DSet.Tables.Add(ConverterListParaDataTable(Res.Take(20).ToList))
            'Else
            Dim Res = From L In BASE.Lancamentos
                      Join LP In BASE.LancamentosProdutos On LP.CodLancamento Equals L.Codigo
                      Join P In BASE.Produtos On P.Codigo Equals LP.CodProduto
                      Join F In BASE.Filiais On F.Codigo Equals L.CodFilial
                      Join N In BASE.Naturezas On N.Codigo Equals L.CodNatureza
                      Where L.Codigo = CODIGO
                      Order By P.Codigo
                      Select IDLANC = L.Codigo,
                                DATA = L.Data,
                                PRODUTO = LP.CodProduto & "-" & P.Nome,
                                QTDE = LP.Quantidade,
                                VALOR = LP.Valor,
                                CODUSUARIO = L.CodUsuario,
                                USUARIO = L.Usuario,
                                CODFILIAL = L.CodFilial & "-" & F.Nome,
                                CODNATUREZA = L.CodNatureza & "-" & N.Nome,
                                OBSERVACAO = L.Observacao

            DSet.Tables.Add(ConverterListParaDataTable(Res.Take(50).ToList()))
            'End If


        End Using

        dgResultado.DataSource = Nothing
        dgResultado.Refresh()

        If DSet.Tables(0).Rows.Count > 0 Then
            dgResultado.DataSource = DSet.Tables(0).DefaultView
            dgResultado.Columns("IDLANC").Width = 50
            dgResultado.Columns("DATA").Width = 75
            dgResultado.Columns("PRODUTO").Width = 120
            dgResultado.Columns("QTDE").Width = 50
            dgResultado.Columns("VALOR").Width = 50
            dgResultado.Columns("CODUSUARIO").Visible = False
            dgResultado.Columns("USUARIO").Visible = False
            dgResultado.Columns("CODFILIAL").Width = 100
            dgResultado.Columns("CODNATUREZA").Width = 80
            dgResultado.Columns("Observacao").Width = 200

        End If
        COLORIRGRD(dgResultado)

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

                Dim lancamentos As New Lancamento() With {
                     .Data = dtInicio.Value,
                     .Valor = txtPreco.Text,
                     .CodUsuario = VariaveisGlobais.UsuarioLogado.Codigo,
                     .CodFilial = filial.Codigo,
                     .CodNatureza = natureza.Codigo,
                     .Observacao = txtObservacao.Text
                     }
                BASE.Lancamentos.Add(lancamentos)
                BASE.SaveChanges()
                UltimoCodigo = BASE.Lancamentos.Max(Function(n) n.Codigo)
                'MsgBox(UltimoCodigo)
            End Using
            'MsgBox("Novo Lancamento Inserido com Sucesso!" & vbCrLf & "Agora Informe os Itens/Produtos Deste Lancamento.", MsgBoxStyle.Information, "Solutions Salão Escola")
        ElseIf Acao = "ALTERAR" Then
            Using BASE As New AplicationContext()

                Dim lancamentos As Lancamento = BASE.Lancamentos.First(Function(M) M.Codigo = txtCodigo.Text)
                lancamentos.Codigo = txtCodigo.Text
                lancamentos.Data = dtInicio.Value
                lancamentos.Valor = txtPreco.Text
                lancamentos.CodUsuario = VariaveisGlobais.UsuarioLogado.Codigo
                lancamentos.CodFilial = filial.Codigo
                'lancamentos.Filial = filial
                lancamentos.CodNatureza = natureza.Codigo
                'lancamentos.Natureza = natureza
                lancamentos.Observacao = txtObservacao.Text
                BASE.SaveChanges()
                UltimoCodigo = lancamentos.Codigo
            End Using
            'MsgBox("Lancamento Atualizado com Sucesso!", MsgBoxStyle.Information, "Solutions Salão Escola")
        ElseIf Acao = "EXCLUIR" Then
            If MsgBox("Tem Certeza que deseja Excluir Este Registro?" & vbCrLf & txtCodigo.Text & " - " & txtObservacao.Text, MsgBoxStyle.OkCancel, "Solutions Salão Escola") = MsgBoxResult.Ok Then
                Using BASE As New AplicationContext()
                    Dim lancamentos As Lancamento = BASE.Lancamentos.First(Function(M) M.Codigo = txtCodigo.Text)
                    BASE.Lancamentos.Attach(lancamentos)
                    BASE.Entry(lancamentos).State = Entity.EntityState.Deleted
                    BASE.SaveChanges()
                End Using
            End If

        End If
        Acao = ""
        dgResultado.Enabled = True
        txtPesquisarGrid.Enabled = True
        PREENCHE_DG(UltimoCodigo)

    End Sub
    Private Sub btnInserir_Click(sender As Object, e As EventArgs) Handles btnInserir.Click
        Acao = "INSERIR"
        CONTROLE_GRUD(Acao, btnInserir, btnAlterar, btnExcluir, btnCancelar, btnGravar)
        dgResultado.Enabled = False
        txtPesquisarGrid.Enabled = False
        txtCodigo.Text = ""
        txtCodigo.ReadOnly = True
        txtObservacao.Text = ""

        cboxFilial.Focus()
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
        PREENCHE_DG(CodProd)
    End Sub

    Private Sub btnGravar_Click(sender As Object, e As EventArgs) Handles btnGravar.Click

        CONTROLE_GRUD("GRAVAR", btnInserir, btnAlterar, btnExcluir, btnCancelar, btnGravar)
        Acao2 = Acao
        SALVAR(Acao)
        txtCodigo.ReadOnly = False
        Me.Close()
        If Acao2 = "INSERIR" Then
            frmLancamentosProdutos.MdiParent = frnPrincipal
            frmLancamentosProdutos.CodLancamento = UltimoCodigo
            frmLancamentosProdutos.Acao = Acao2
            frmLancamentosProdutos.Show()
            frmLancamentosProdutos.Location = New System.Drawing.Point(3, 2)
            frmLancamentosProdutos.Focus()
        ElseIf Acao2 = "ALTERAR" Then
            frmLancamentosProdutos.MdiParent = frnPrincipal
            frmLancamentosProdutos.CodLancamento = UltimoCodigo
            frmLancamentosProdutos.Acao = "INICIO"
            frmLancamentosProdutos.Show()
            frmLancamentosProdutos.Location = New System.Drawing.Point(3, 2)
            frmLancamentosProdutos.Focus()
        End If

    End Sub

    Private Sub dgResultado_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgResultado.CellEnter

        'Dim Codigofilial As Integer = If(IsDBNull(dgResultado.CurrentRow.Cells(5).Value), 0, CInt(dgResultado.CurrentRow.Cells(5).Value))
        'Dim CodigoNatu As Integer = If(IsDBNull(dgResultado.CurrentRow.Cells(7).Value), 0, CInt(dgResultado.CurrentRow.Cells(7).Value))
        'Dim Codigofilial As Integer = CInt(Split(dgResultado.CurrentRow.Cells(7).Value, "-")(0))
        'Dim CodigoNatu As Integer = CInt(Split(dgResultado.CurrentRow.Cells(8).Value, "-")(0))
        'Dim filial As Filial = db.Filiais.First(Function(M) M.Codigo = CInt(Codigofilial))
        'Dim natureza As Natureza = db.Naturezas.First(Function(M) M.Codigo = CInt(CodigoNatu))


        txtCodigo.Text = dgResultado.CurrentRow.Cells(0).Value
        dtInicio.Text = dgResultado.CurrentRow.Cells(1).Value
        txtPreco.Text = dgResultado.CurrentRow.Cells(4).Value
        cboxFilial.Text = dgResultado.CurrentRow.Cells(7).Value
        cboxNatureza.Text = dgResultado.CurrentRow.Cells(8).Value
        txtObservacao.Text = dgResultado.CurrentRow.Cells(9).Value

        '.IDLANC = L.Codigo,
        '.DATA = L.Data,
        '.PRODUTO = LP.CodProduto & "-" & P.Nome,
        '.QTDE = LP.Quantidade,
        '.VALOR = L.Valor,
        '.CODUSUARIO = L.CodUsuario,
        '.USUARIO = L.Usuario,
        '.CODFILIAL = L.CodFilial & "-" & F.Nome,
        '.CODNATUREZA = L.CodNatureza & "-" & N.Nome,
        '.OBSERVACAO = L.Observacao

    End Sub

    Private Sub txtCodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigo.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            PREENCHE_DG(txtCodigo.Text)
        End If
    End Sub
End Class