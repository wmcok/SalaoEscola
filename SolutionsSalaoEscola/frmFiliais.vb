Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools

Public Class frmFiliais
    Inherits Office2010Form
    Dim Acao As String = ""
    Dim DSet As New DataSet
    Private Sub frmFiliais_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SfSkinManager1 = frmLogin.SfSkinManager1
        Me.SfSkinManager1.Controls = Me
    End Sub
    Private Sub frmFiliais_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.Icon = frnPrincipal.Icon
        msgAguarde.Visible = True
        PREENCHE_DG()
        CONTROLE_GRUD("INICIO", btnInserir, btnAlterar, btnExcluir, btnCancelar, btnGravar)
        msgAguarde.Visible = False
    End Sub



    Private Sub PREENCHE_DG()
        DSet.Clear()
        DSet.Tables.Clear()
        Using BASE As New AplicationContext()
            DSet.Tables.Add(ConverterListParaDataTable(BASE.Filiais.OrderBy(Function(n) n.Codigo).ToList()))
        End Using

        dgFiliais.DataSource = Nothing
        dgFiliais.Refresh()

        If DSet.Tables(0).Rows.Count > 0 Then
            dgFiliais.DataSource = DSet.Tables(0).DefaultView
            dgFiliais.Columns("CODIGO").Width = 50
            dgFiliais.Columns("NOME").Width = 150
            dgFiliais.Columns("ENDERECO").Visible = False

        End If
        COLORIRGRD(dgFiliais)

    End Sub
    Private Sub SALVAR(TIPO As String)
        If Acao = "INSERIR" Then
            Using BASE As New AplicationContext()
                Dim Filial As New Filial() With {
                     .Nome = txtNome.Text,
                    .Endereco = txtEndereco.Text
                }
                BASE.Filiais.Add(Filial)
                BASE.SaveChanges()
            End Using
            MsgBox("Nova Filial Inserida com Sucesso!", MsgBoxStyle.Information, "Solutions Salão Escola")
        ElseIf Acao = "ALTERAR" Then
            Using BASE As New AplicationContext()
                Dim filial As Filial = BASE.Filiais.First(Function(M) M.Codigo = txtCodigo.Text)
                filial.Codigo = txtCodigo.Text
                filial.Nome = txtNome.Text
                filial.endereco = txtEndereco.Text
                BASE.SaveChanges()
            End Using
            MsgBox("Filial Atualizada com Sucesso!", MsgBoxStyle.Information, "Solutions Salão Escola")
        ElseIf Acao = "EXCLUIR" Then
            If MsgBox("Tem Certeza que deseja Excluir Este Registro?" & vbCrLf & txtCodigo.Text & " - " & txtNome.Text, MsgBoxStyle.OkCancel, "Solutions Salão Escola") = MsgBoxResult.Ok Then
                Using BASE As New AplicationContext()
                    Dim filial As Filial = BASE.Filiais.First(Function(M) M.Codigo = txtCodigo.Text)
                    BASE.Filiais.Attach(filial)
                    BASE.Entry(filial).State = Entity.EntityState.Deleted
                    BASE.SaveChanges()
                End Using
            End If

        End If
        Acao = ""
        dgFiliais.Enabled = True
        txtPesquisar.Enabled = True
        PREENCHE_DG()

    End Sub



    Private Sub btnInserir_Click(sender As Object, e As EventArgs) Handles btnInserir.Click
        Acao = "INSERIR"
        CONTROLE_GRUD(Acao, btnInserir, btnAlterar, btnExcluir, btnCancelar, btnGravar)
        txtCodigo.Text = ""
        txtNome.Text = ""
        txtEndereco.Text = ""

        dgFiliais.Enabled = False
        txtPesquisar.Enabled = False
        txtNome.Focus()
    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        Acao = "ALTERAR"
        CONTROLE_GRUD(Acao, btnInserir, btnAlterar, btnExcluir, btnCancelar, btnGravar)
        dgFiliais.Enabled = False
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
        dgFiliais.Enabled = True
        txtPesquisar.Enabled = True
        PREENCHE_DG()
    End Sub

    Private Sub btnGravar_Click(sender As Object, e As EventArgs) Handles btnGravar.Click

        CONTROLE_GRUD("GRAVAR", btnInserir, btnAlterar, btnExcluir, btnCancelar, btnGravar)
        SALVAR(Acao)
    End Sub

    Private Sub dgUsuarios_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgFiliais.CellEnter
        txtCodigo.Text = dgFiliais.CurrentRow.Cells(0).Value
        txtNome.Text = dgFiliais.CurrentRow.Cells(1).Value
        txtEndereco.Text = dgFiliais.CurrentRow.Cells(2).Value
    End Sub

    Private Sub txtPesquisar_TextChanged(sender As Object, e As EventArgs) Handles txtPesquisar.TextChanged
        If DSet.Tables(0).Rows.Count >= 1 And txtPesquisar.TextLength >= 1 Then
            DSet.Tables(0).DefaultView.RowFilter = " Nome LIKE '%" + RTrim(txtPesquisar.Text) + "%'"
        ElseIf txtPesquisar.TextLength < 1 Then
            DSet.Tables(0).DefaultView.RowFilter = " NOME like '%'"
        End If
    End Sub

End Class