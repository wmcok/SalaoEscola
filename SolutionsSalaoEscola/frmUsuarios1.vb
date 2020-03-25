﻿Imports Microsoft.VisualBasic.ApplicationServices
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools

Public Class frmUsuarios1
    Inherits Office2010Form
    Dim Acao As String = ""
    Dim DSet As New DataSet
    Private Sub frmUsuarios1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SfSkinManager1 = frmLogin.SfSkinManager1
        Me.Icon = frnPrincipal.Icon
    End Sub
    Private Sub frmUsuarios1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Icon = frnPrincipal.Icon
        msgAguarde.Visible = True
        PREENCHE_DG()
        CONTROLE_GRUD("INICIO", btnInserir, btnAlterar, btnExcluir, btnCancelar, btnGravar)
        msgAguarde.Visible = False
    End Sub



    Private Sub PREENCHE_DG()
        DSet.Clear()
        DSet.Tables.Clear()
        Using BASE As New AplicationContext()
            DSet.Tables.Add(ConverterListParaDataTable(BASE.Usuarios.OrderBy(Function(n) n.Codigo).ToList()))
        End Using

        dgUsuarios.DataSource = Nothing
        dgUsuarios.Refresh()

        If DSet.Tables(0).Rows.Count > 0 Then
            dgUsuarios.DataSource = DSet.Tables(0).DefaultView
            dgUsuarios.Columns("CODIGO").Width = 50
            dgUsuarios.Columns("NOME").Width = 150
            dgUsuarios.Columns("SENHA").Visible = False

        End If
        COLORIRGRD(dgUsuarios)

    End Sub
    Private Sub SALVAR(TIPO As String)
        If Acao = "INSERIR" Then
            Using BASE As New AplicationContext()
                Dim usuario As New Usuario() With {
                     .Nome = txtNome.Text,
                    .Senha = txtSenha.Text
                }
                BASE.Usuarios.Add(usuario)
                BASE.SaveChanges()
            End Using
            MsgBox("Novo Usuário Inserido com Sucesso!", MsgBoxStyle.Information, "Solutions Salão Escola")
        ElseIf Acao = "ALTERAR" Then
            Using BASE As New AplicationContext()
                Dim usuario As Usuario = BASE.Usuarios.First(Function(M) M.Codigo = txtCodigo.Text)
                usuario.Codigo = txtCodigo.Text
                usuario.Nome = txtNome.Text
                usuario.Senha = txtSenha.Text
                BASE.SaveChanges()
            End Using
            MsgBox("Usuário Atualizado com Sucesso!", MsgBoxStyle.Information, "Solutions Salão Escola")
        ElseIf Acao = "EXCLUIR" Then
            If MsgBox("Tem Certeza que deseja Excluir Este Registro?" & vbCrLf & txtCodigo.Text & " - " & txtNome.Text, MsgBoxStyle.OkCancel, "Solutions Salão Escola") = MsgBoxResult.Ok Then
                Using BASE As New AplicationContext()
                    Dim usuario As Usuario = BASE.Usuarios.First(Function(M) M.Codigo = txtCodigo.Text)
                    BASE.Usuarios.Attach(usuario)
                    BASE.Entry(usuario).State = Entity.EntityState.Deleted
                    BASE.SaveChanges()
                End Using
            End If

        End If
        Acao = ""
        dgUsuarios.Enabled = True
        txtPesquisar.Enabled = True
        PREENCHE_DG()

    End Sub



    Private Sub btnInserir_Click(sender As Object, e As EventArgs) Handles btnInserir.Click
        Acao = "INSERIR"
        CONTROLE_GRUD(Acao, btnInserir, btnAlterar, btnExcluir, btnCancelar, btnGravar)
        txtCodigo.Text = ""
        txtNome.Text = ""
        txtSenha.Text = ""

        dgUsuarios.Enabled = False
        txtPesquisar.Enabled = False
        txtNome.Focus()
    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        Acao = "ALTERAR"
        CONTROLE_GRUD(Acao, btnInserir, btnAlterar, btnExcluir, btnCancelar, btnGravar)
        dgUsuarios.Enabled = False
        txtPesquisar.Enabled = False
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Acao = "EXCLUIR"
        CONTROLE_GRUD("EXCLUIR", btnInserir, btnAlterar, btnExcluir, btnCancelar, btnGravar)
        SALVAR("EXCLUIR")
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Acao = "CANCELAR"
        CONTROLE_GRUD(Acao, btnInserir, btnAlterar, btnExcluir, btnCancelar, btnGravar)
        dgUsuarios.Enabled = True
        txtPesquisar.Enabled = True
        PREENCHE_DG()
    End Sub

    Private Sub btnGravar_Click(sender As Object, e As EventArgs) Handles btnGravar.Click

        CONTROLE_GRUD("GRAVAR", btnInserir, btnAlterar, btnExcluir, btnCancelar, btnGravar)
        SALVAR(Acao)
    End Sub

    Private Sub dgUsuarios_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgUsuarios.CellEnter
        txtCodigo.Text = dgUsuarios.CurrentRow.Cells(0).Value
        txtNome.Text = dgUsuarios.CurrentRow.Cells(1).Value
        txtSenha.Text = dgUsuarios.CurrentRow.Cells(2).Value
    End Sub

    Private Sub txtPesquisar_TextChanged(sender As Object, e As EventArgs) Handles txtPesquisar.TextChanged
        If DSet.Tables(0).Rows.Count >= 1 And txtPesquisar.TextLength >= 1 Then
            DSet.Tables(0).DefaultView.RowFilter = " Nome LIKE '%" + RTrim(txtPesquisar.Text) + "%'"
        ElseIf txtPesquisar.TextLength < 1 Then
            DSet.Tables(0).DefaultView.RowFilter = " NOME like '%'"
        End If
    End Sub


End Class