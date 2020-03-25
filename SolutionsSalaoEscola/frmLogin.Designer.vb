<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
    Inherits Syncfusion.Windows.Forms.Office2010Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.AutoLabel1 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.txtUsuario = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.txtSenha = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.btnEntrar = New Syncfusion.WinForms.Controls.SfButton()
        Me.btnCancelar = New Syncfusion.WinForms.Controls.SfButton()
        Me.AutoLabel2 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.AutoLabel3 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.lblMSGError = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.SfSkinManager1 = New Syncfusion.WinForms.Controls.SfSkinManager(Me.components)
        CType(Me.txtUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSenha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AutoLabel1
        '
        Me.AutoLabel1.Font = New System.Drawing.Font("Constantia", 23.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AutoLabel1.Location = New System.Drawing.Point(87, 63)
        Me.AutoLabel1.Name = "AutoLabel1"
        Me.AutoLabel1.Size = New System.Drawing.Size(340, 38)
        Me.AutoLabel1.TabIndex = 0
        Me.AutoLabel1.Text = "Solutions Salão Escola"
        Me.AutoLabel1.ThemeName = "Office2010Blue"
        '
        'txtUsuario
        '
        Me.txtUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.txtUsuario.BeforeTouchSize = New System.Drawing.Size(187, 25)
        Me.txtUsuario.BorderColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUsuario.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtUsuario.Location = New System.Drawing.Point(287, 153)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed
        Me.txtUsuario.Size = New System.Drawing.Size(187, 25)
        Me.txtUsuario.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2010
        Me.txtUsuario.TabIndex = 1
        Me.txtUsuario.ThemeName = "Office2010"
        '
        'txtSenha
        '
        Me.txtSenha.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.txtSenha.BeforeTouchSize = New System.Drawing.Size(187, 25)
        Me.txtSenha.BorderColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSenha.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.txtSenha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtSenha.Location = New System.Drawing.Point(287, 195)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.txtSenha.Size = New System.Drawing.Size(187, 25)
        Me.txtSenha.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2010
        Me.txtSenha.TabIndex = 2
        Me.txtSenha.ThemeName = "Office2010"
        '
        'btnEntrar
        '
        Me.btnEntrar.AccessibleName = "Button"
        Me.btnEntrar.BackColor = System.Drawing.Color.LightCyan
        Me.btnEntrar.FocusRectangleVisible = True
        Me.btnEntrar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.btnEntrar.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnEntrar.Location = New System.Drawing.Point(351, 250)
        Me.btnEntrar.Name = "btnEntrar"
        Me.btnEntrar.Size = New System.Drawing.Size(122, 38)
        Me.btnEntrar.Style.BackColor = System.Drawing.Color.LightCyan
        Me.btnEntrar.Style.Image = Global.SolutionsSalaoEscola.My.Resources.Resources.sign_check_icon
        Me.btnEntrar.TabIndex = 3
        Me.btnEntrar.Text = "Entrar"
        Me.btnEntrar.ThemeName = "Office2010Blue"
        Me.btnEntrar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.AccessibleName = "Button"
        Me.btnCancelar.BackColor = System.Drawing.Color.LavenderBlush
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.FocusRectangleVisible = True
        Me.btnCancelar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.btnCancelar.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnCancelar.Location = New System.Drawing.Point(210, 250)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(122, 38)
        Me.btnCancelar.Style.BackColor = System.Drawing.Color.LavenderBlush
        Me.btnCancelar.Style.Image = Global.SolutionsSalaoEscola.My.Resources.Resources.sign_ban_icon
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.ThemeName = "Office2010Blue"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'AutoLabel2
        '
        Me.AutoLabel2.Font = New System.Drawing.Font("Constantia", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AutoLabel2.Location = New System.Drawing.Point(204, 153)
        Me.AutoLabel2.Name = "AutoLabel2"
        Me.AutoLabel2.Size = New System.Drawing.Size(77, 21)
        Me.AutoLabel2.TabIndex = 5
        Me.AutoLabel2.Text = "Usuário :"
        Me.AutoLabel2.ThemeName = "Office2010Blue"
        '
        'AutoLabel3
        '
        Me.AutoLabel3.Font = New System.Drawing.Font("Constantia", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AutoLabel3.Location = New System.Drawing.Point(218, 195)
        Me.AutoLabel3.Name = "AutoLabel3"
        Me.AutoLabel3.Size = New System.Drawing.Size(63, 21)
        Me.AutoLabel3.TabIndex = 6
        Me.AutoLabel3.Text = "Senha :"
        Me.AutoLabel3.ThemeName = "Office2010Blue"
        '
        'lblMSGError
        '
        Me.lblMSGError.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMSGError.ForeColor = System.Drawing.Color.DarkRed
        Me.lblMSGError.Location = New System.Drawing.Point(138, 227)
        Me.lblMSGError.Name = "lblMSGError"
        Me.lblMSGError.Size = New System.Drawing.Size(338, 19)
        Me.lblMSGError.TabIndex = 7
        Me.lblMSGError.Text = "Usuário ou Senha incorretos, Tente Novamente!"
        Me.lblMSGError.ThemeName = "Office2010Blue"
        Me.lblMSGError.Visible = False
        '
        'SfSkinManager1
        '
        Me.SfSkinManager1.Component = Nothing
        Me.SfSkinManager1.Controls = Me
        Me.SfSkinManager1.ThemeName = Nothing
        Me.SfSkinManager1.VisualTheme = Syncfusion.Windows.Forms.VisualTheme.Office2010Blue
        '
        'frmLogin
        '
        Me.AcceptButton = Me.btnEntrar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(507, 300)
        Me.ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Blue
        Me.Controls.Add(Me.lblMSGError)
        Me.Controls.Add(Me.AutoLabel3)
        Me.Controls.Add(Me.AutoLabel2)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnEntrar)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.AutoLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Solutions Salão Escola"
        CType(Me.txtUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSenha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AutoLabel1 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents txtUsuario As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents txtSenha As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents btnEntrar As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents btnCancelar As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents AutoLabel2 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents AutoLabel3 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents lblMSGError As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents SfSkinManager1 As Syncfusion.WinForms.Controls.SfSkinManager
End Class
