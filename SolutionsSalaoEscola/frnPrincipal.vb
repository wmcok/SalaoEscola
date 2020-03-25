Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools

Public Class frnPrincipal
    Inherits RibbonForm

    Private Sub frnPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SfSkinManager1 = frmLogin.SfSkinManager1
        RibbonControlAdv1.SelectedTab = ToolStripTabItem1

        StatusBarAdvPanel1.Text = "Usuário: " & UsuarioLogado.Codigo & " - " & UsuarioLogado.Nome & "            :: " & My.Application.Info.Copyright
    End Sub

    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        frmUsuarios1.MdiParent = Me
        frmUsuarios1.Show()
        frmUsuarios1.Location = New System.Drawing.Point(3, 2)
        frmUsuarios1.Focus()
    End Sub


    Private Sub frnPrincipal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If ModuloGeral.Trocausuario = "SAIR" Then
            frmLogin.Close()
        ElseIf ModuloGeral.Trocausuario = "LOGOFF" Then
            frmLogin.Show()
            frmLogin.txtUsuario.Clear()
            frmLogin.txtSenha.Clear()
            frmLogin.txtUsuario.Focus()
            Me.Dispose()
        End If
    End Sub

    Private Sub btnLogoff_Click(sender As Object, e As EventArgs) Handles btnLogoff.Click
        ModuloGeral.Trocausuario = "LOGOFF"
        Me.Close()
    End Sub

    Private Sub btnFiliais_Click(sender As Object, e As EventArgs) Handles btnFiliais.Click
        frmFiliais.MdiParent = Me
        frmFiliais.Show()
        frmFiliais.Location = New System.Drawing.Point(3, 2)
        frmFiliais.Focus()
    End Sub

    Private Sub btnNaturezas_Click(sender As Object, e As EventArgs) Handles btnNaturezas.Click
        frmNaturezas.MdiParent = Me
        frmNaturezas.Show()
        frmNaturezas.Location = New System.Drawing.Point(3, 2)
        frmNaturezas.Focus()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        frmProdutos.MdiParent = Me
        frmProdutos.Show()
        frmProdutos.Location = New System.Drawing.Point(3, 2)
        frmProdutos.Focus()
    End Sub

    Private Sub btnControleLancamentos_Click(sender As Object, e As EventArgs) Handles btnControleLancamentos.Click
        frmControleLancamentos.MdiParent = Me
        frmControleLancamentos.Show()
        frmControleLancamentos.Location = New System.Drawing.Point(3, 2)
        frmControleLancamentos.Focus()
    End Sub

    Private Sub btnCadastrarLancamento_Click(sender As Object, e As EventArgs) Handles btnCadastrarLancamento.Click
        Form1.MdiParent = Me
        Form1.Show()
        Form1.Location = New System.Drawing.Point(3, 2)
        Form1.Focus()
    End Sub
    'ToolStripButton2
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        frmLancamentos.MdiParent = Me
        frmLancamentos.Show()
        frmLancamentos.Location = New System.Drawing.Point(3, 2)
        frmLancamentos.Focus()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        frmControleFinanceiro.MdiParent = Me
        frmControleFinanceiro.Show()
        frmControleFinanceiro.Location = New System.Drawing.Point(3, 2)
        frmControleFinanceiro.Focus()
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        frmFinanceiro.MdiParent = Me
        frmFinanceiro.Show()
        frmFinanceiro.Location = New System.Drawing.Point(3, 2)
        frmFinanceiro.Focus()
    End Sub
End Class


