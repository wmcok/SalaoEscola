Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools

Public Class frmLogin
    Inherits Office2010Form

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SfSkinManager1.ThemeName = "Office2010Blue"
        Me.SfSkinManager1.Controls = Me
        lblMSGError.Visible = False
    End Sub

    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        Try
            If LOGAR(txtUsuario.Text, txtSenha.Text) Then
                lblMSGError.Visible = False
                Me.Visible = False
                frnPrincipal.Show()
                frnPrincipal.Focus()
            Else
                lblMSGError.Visible = True
                txtUsuario.Focus()
                txtUsuario.SelectAll()
            End If
        Catch ex As Exception
            Dim erro As String = ""
            Dim Exc As Exception = ex
            While Not IsNothing(Exc)
                erro &= Exc.Message & vbCrLf
                Exc = Exc.InnerException
            End While
            MsgBox(erro, MsgBoxStyle.OkOnly, "Solutions Salão Escola")
        End Try


    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub txtSenha_Enter(sender As Object, e As EventArgs) Handles txtSenha.Enter
        txtSenha.SelectAll()
    End Sub

    Private Sub txtUsuario_Enter(sender As Object, e As EventArgs) Handles txtUsuario.Enter
        txtUsuario.SelectAll()
    End Sub
End Class