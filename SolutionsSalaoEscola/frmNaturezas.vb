Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools

Public Class frmNaturezas
    Inherits Office2010Form

    Dim Acao As String = ""
    Dim DSet As New DataSet
    Private Sub frmUsuarios1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SfSkinManager1 = frmLogin.SfSkinManager1
        Me.SfSkinManager1.Controls = Me
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
            DSet.Tables.Add(ConverterListParaDataTable(BASE.Naturezas.OrderBy(Function(n) n.Codigo).ToList()))
        End Using

        dgNaturezas.DataSource = Nothing
        dgNaturezas.Refresh()

        If DSet.Tables(0).Rows.Count > 0 Then
            dgNaturezas.DataSource = DSet.Tables(0).DefaultView
            dgNaturezas.Columns("CODIGO").Width = 50
            dgNaturezas.Columns("NOME").Width = 150


        End If
        COLORIRGRD(dgNaturezas)

    End Sub
    Private Sub SALVAR(TIPO As String)
        If Acao = "INSERIR" Then
            Using BASE As New AplicationContext()
                Dim natureza As New Natureza() With {
                     .Nome = txtNome.Text
                     }
                BASE.Naturezas.Add(natureza)
                BASE.SaveChanges()
            End Using
            MsgBox("Nova Natureza Inserida com Sucesso!", MsgBoxStyle.Information, "Solutions Salão Escola")
        ElseIf Acao = "ALTERAR" Then
            Using BASE As New AplicationContext()
                Dim natureza As Natureza = BASE.Naturezas.First(Function(M) M.Codigo = txtCodigo.Text)
                natureza.Codigo = txtCodigo.Text
                natureza.Nome = txtNome.Text
                BASE.SaveChanges()
            End Using
            MsgBox("Natureza Atualizada com Sucesso!", MsgBoxStyle.Information, "Solutions Salão Escola")
        ElseIf Acao = "EXCLUIR" Then
            If MsgBox("Tem Certeza que deseja Excluir Este Registro?" & vbCrLf & txtCodigo.Text & " - " & txtNome.Text, MsgBoxStyle.OkCancel, "Solutions Salão Escola") = MsgBoxResult.Ok Then
                Using BASE As New AplicationContext()
                    Dim natureza As Natureza = BASE.Naturezas.First(Function(M) M.Codigo = txtCodigo.Text)
                    BASE.Naturezas.Attach(natureza)
                    BASE.Entry(natureza).State = Entity.EntityState.Deleted
                    BASE.SaveChanges()
                End Using
            End If

        End If
        Acao = ""
        dgNaturezas.Enabled = True
        txtPesquisar.Enabled = True
        PREENCHE_DG()

    End Sub



    Private Sub btnInserir_Click(sender As Object, e As EventArgs) Handles btnInserir.Click
        Acao = "INSERIR"
        CONTROLE_GRUD(Acao, btnInserir, btnAlterar, btnExcluir, btnCancelar, btnGravar)
        txtCodigo.Text = ""
        txtNome.Text = ""


        dgNaturezas.Enabled = False
        txtPesquisar.Enabled = False
        txtNome.Focus()
    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        Acao = "ALTERAR"
        CONTROLE_GRUD(Acao, btnInserir, btnAlterar, btnExcluir, btnCancelar, btnGravar)
        dgNaturezas.Enabled = False
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
        dgNaturezas.Enabled = True
        txtPesquisar.Enabled = True
        PREENCHE_DG()
    End Sub

    Private Sub btnGravar_Click(sender As Object, e As EventArgs) Handles btnGravar.Click

        CONTROLE_GRUD("GRAVAR", btnInserir, btnAlterar, btnExcluir, btnCancelar, btnGravar)
        SALVAR(Acao)
    End Sub

    Private Sub dgUsuarios_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgNaturezas.CellEnter
        txtCodigo.Text = dgNaturezas.CurrentRow.Cells(0).Value
        txtNome.Text = dgNaturezas.CurrentRow.Cells(1).Value

    End Sub

    Private Sub txtPesquisar_TextChanged(sender As Object, e As EventArgs) Handles txtPesquisar.TextChanged
        If DSet.Tables(0).Rows.Count >= 1 And txtPesquisar.TextLength >= 1 Then
            DSet.Tables(0).DefaultView.RowFilter = " Nome LIKE '%" + RTrim(txtPesquisar.Text) + "%'"
        ElseIf txtPesquisar.TextLength < 1 Then
            DSet.Tables(0).DefaultView.RowFilter = " NOME like '%'"
        End If
    End Sub

End Class