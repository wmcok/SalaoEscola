<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuarios1
    Inherits Syncfusion.Windows.Forms.Office2010Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsuarios1))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.AutoLabel3 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.AutoLabel2 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.AutoLabel1 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.GradientPanel1 = New Syncfusion.Windows.Forms.Tools.GradientPanel()
        Me.btnGravar = New Syncfusion.WinForms.Controls.SfButton()
        Me.btnCancelar = New Syncfusion.WinForms.Controls.SfButton()
        Me.btnExcluir = New Syncfusion.WinForms.Controls.SfButton()
        Me.btnAlterar = New Syncfusion.WinForms.Controls.SfButton()
        Me.btnInserir = New Syncfusion.WinForms.Controls.SfButton()
        Me.txtSenha = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.txtNome = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.txtCodigo = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.dgUsuarios = New System.Windows.Forms.DataGridView()
        Me.txtPesquisar = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.msgAguarde = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SfSkinManager1 = New Syncfusion.WinForms.Controls.SfSkinManager(Me.components)
        CType(Me.GradientPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GradientPanel1.SuspendLayout()
        CType(Me.txtSenha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPesquisar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.msgAguarde.SuspendLayout()
        Me.SuspendLayout()
        '
        'AutoLabel3
        '
        Me.AutoLabel3.Location = New System.Drawing.Point(5, 105)
        Me.AutoLabel3.Name = "AutoLabel3"
        Me.AutoLabel3.Size = New System.Drawing.Size(38, 13)
        Me.AutoLabel3.TabIndex = 18
        Me.AutoLabel3.Text = "Senha"
        Me.AutoLabel3.ThemeName = "Managed"
        '
        'AutoLabel2
        '
        Me.AutoLabel2.Location = New System.Drawing.Point(5, 60)
        Me.AutoLabel2.Name = "AutoLabel2"
        Me.AutoLabel2.Size = New System.Drawing.Size(43, 13)
        Me.AutoLabel2.TabIndex = 17
        Me.AutoLabel2.Text = "Usuário"
        Me.AutoLabel2.ThemeName = "Managed"
        '
        'AutoLabel1
        '
        Me.AutoLabel1.Location = New System.Drawing.Point(5, 15)
        Me.AutoLabel1.Name = "AutoLabel1"
        Me.AutoLabel1.Size = New System.Drawing.Size(40, 13)
        Me.AutoLabel1.TabIndex = 16
        Me.AutoLabel1.Text = "Código"
        Me.AutoLabel1.ThemeName = "Managed"
        '
        'GradientPanel1
        '
        Me.GradientPanel1.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.GradientPanel1.Controls.Add(Me.btnGravar)
        Me.GradientPanel1.Controls.Add(Me.btnCancelar)
        Me.GradientPanel1.Controls.Add(Me.btnExcluir)
        Me.GradientPanel1.Controls.Add(Me.btnAlterar)
        Me.GradientPanel1.Controls.Add(Me.btnInserir)
        Me.GradientPanel1.Location = New System.Drawing.Point(5, 163)
        Me.GradientPanel1.Name = "GradientPanel1"
        Me.GradientPanel1.Size = New System.Drawing.Size(182, 106)
        Me.GradientPanel1.TabIndex = 3
        Me.GradientPanel1.ThemeName = "Managed"
        '
        'btnGravar
        '
        Me.btnGravar.AccessibleName = "Button"
        Me.btnGravar.BackColor = System.Drawing.Color.White
        Me.btnGravar.FocusRectangleVisible = True
        Me.btnGravar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.btnGravar.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnGravar.Location = New System.Drawing.Point(91, 36)
        Me.btnGravar.Name = "btnGravar"
        Me.btnGravar.Size = New System.Drawing.Size(81, 61)
        Me.btnGravar.Style.BackColor = System.Drawing.Color.White
        Me.btnGravar.Style.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.btnGravar.TabIndex = 4
        Me.btnGravar.Text = "Gravar"
        Me.btnGravar.ThemeName = "Managed"
        Me.btnGravar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.AccessibleName = "Button"
        Me.btnCancelar.BackColor = System.Drawing.Color.White
        Me.btnCancelar.FocusRectangleVisible = True
        Me.btnCancelar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.btnCancelar.ImageSize = New System.Drawing.Size(23, 23)
        Me.btnCancelar.Location = New System.Drawing.Point(91, 3)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(81, 28)
        Me.btnCancelar.Style.BackColor = System.Drawing.Color.White
        Me.btnCancelar.Style.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.ThemeName = "Managed"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnExcluir
        '
        Me.btnExcluir.AccessibleName = "Button"
        Me.btnExcluir.BackColor = System.Drawing.Color.White
        Me.btnExcluir.FocusRectangleVisible = True
        Me.btnExcluir.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.btnExcluir.ImageSize = New System.Drawing.Size(23, 23)
        Me.btnExcluir.Location = New System.Drawing.Point(4, 69)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(81, 28)
        Me.btnExcluir.Style.BackColor = System.Drawing.Color.White
        Me.btnExcluir.Style.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
        Me.btnExcluir.TabIndex = 2
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.ThemeName = "Managed"
        Me.btnExcluir.UseVisualStyleBackColor = False
        '
        'btnAlterar
        '
        Me.btnAlterar.AccessibleName = "Button"
        Me.btnAlterar.BackColor = System.Drawing.Color.White
        Me.btnAlterar.FocusRectangleVisible = True
        Me.btnAlterar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.btnAlterar.ImageSize = New System.Drawing.Size(23, 23)
        Me.btnAlterar.Location = New System.Drawing.Point(4, 36)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(81, 28)
        Me.btnAlterar.Style.BackColor = System.Drawing.Color.White
        Me.btnAlterar.Style.Image = CType(resources.GetObject("resource.Image3"), System.Drawing.Image)
        Me.btnAlterar.TabIndex = 1
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.ThemeName = "Managed"
        Me.btnAlterar.UseVisualStyleBackColor = False
        '
        'btnInserir
        '
        Me.btnInserir.AccessibleName = "Button"
        Me.btnInserir.BackColor = System.Drawing.Color.White
        Me.btnInserir.FocusRectangleVisible = True
        Me.btnInserir.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.btnInserir.ImageSize = New System.Drawing.Size(23, 23)
        Me.btnInserir.Location = New System.Drawing.Point(4, 3)
        Me.btnInserir.Name = "btnInserir"
        Me.btnInserir.Size = New System.Drawing.Size(81, 28)
        Me.btnInserir.Style.BackColor = System.Drawing.Color.White
        Me.btnInserir.Style.Image = CType(resources.GetObject("resource.Image4"), System.Drawing.Image)
        Me.btnInserir.TabIndex = 0
        Me.btnInserir.Text = "Inserir"
        Me.btnInserir.ThemeName = "Managed"
        Me.btnInserir.UseVisualStyleBackColor = False
        '
        'txtSenha
        '
        Me.txtSenha.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtSenha.BeforeTouchSize = New System.Drawing.Size(271, 27)
        Me.txtSenha.BorderColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSenha.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSenha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtSenha.Location = New System.Drawing.Point(5, 121)
        Me.txtSenha.MaxLength = 40
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed
        Me.txtSenha.Size = New System.Drawing.Size(182, 27)
        Me.txtSenha.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2007
        Me.txtSenha.TabIndex = 2
        Me.txtSenha.ThemeName = "Office2007"
        '
        'txtNome
        '
        Me.txtNome.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtNome.BeforeTouchSize = New System.Drawing.Size(271, 27)
        Me.txtNome.BorderColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNome.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtNome.Location = New System.Drawing.Point(5, 76)
        Me.txtNome.MaxLength = 40
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed
        Me.txtNome.Size = New System.Drawing.Size(182, 27)
        Me.txtNome.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2007
        Me.txtNome.TabIndex = 1
        Me.txtNome.ThemeName = "Office2007"
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtCodigo.BeforeTouchSize = New System.Drawing.Size(271, 27)
        Me.txtCodigo.BorderColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtCodigo.Location = New System.Drawing.Point(5, 31)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(182, 27)
        Me.txtCodigo.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2007
        Me.txtCodigo.TabIndex = 0
        Me.txtCodigo.ThemeName = "Office2007"
        '
        'dgUsuarios
        '
        Me.dgUsuarios.AllowUserToAddRows = False
        Me.dgUsuarios.AllowUserToDeleteRows = False
        Me.dgUsuarios.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgUsuarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgUsuarios.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgUsuarios.Location = New System.Drawing.Point(193, 3)
        Me.dgUsuarios.Name = "dgUsuarios"
        Me.dgUsuarios.ReadOnly = True
        Me.dgUsuarios.ShowCellErrors = False
        Me.dgUsuarios.ShowCellToolTips = False
        Me.dgUsuarios.ShowEditingIcon = False
        Me.dgUsuarios.ShowRowErrors = False
        Me.dgUsuarios.Size = New System.Drawing.Size(271, 234)
        Me.dgUsuarios.TabIndex = 5
        '
        'txtPesquisar
        '
        Me.txtPesquisar.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtPesquisar.BeforeTouchSize = New System.Drawing.Size(271, 27)
        Me.txtPesquisar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.txtPesquisar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPesquisar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPesquisar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPesquisar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtPesquisar.Location = New System.Drawing.Point(193, 243)
        Me.txtPesquisar.Name = "txtPesquisar"
        Me.txtPesquisar.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed
        Me.txtPesquisar.Size = New System.Drawing.Size(271, 27)
        Me.txtPesquisar.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2007
        Me.txtPesquisar.TabIndex = 4
        Me.txtPesquisar.ThemeName = "Office2007"
        '
        'msgAguarde
        '
        Me.msgAguarde.Controls.Add(Me.Label1)
        Me.msgAguarde.Location = New System.Drawing.Point(69, 50)
        Me.msgAguarde.Name = "msgAguarde"
        Me.msgAguarde.Size = New System.Drawing.Size(338, 152)
        Me.msgAguarde.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(50, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(257, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Aguarde! Carregando . . ."
        '
        'SfSkinManager1
        '
        Me.SfSkinManager1.Component = Nothing
        Me.SfSkinManager1.Controls = Me
        Me.SfSkinManager1.ThemeName = Nothing
        Me.SfSkinManager1.VisualTheme = Syncfusion.Windows.Forms.VisualTheme.Managed
        '
        'frmUsuarios1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 273)
        Me.Controls.Add(Me.msgAguarde)
        Me.Controls.Add(Me.txtPesquisar)
        Me.Controls.Add(Me.AutoLabel3)
        Me.Controls.Add(Me.AutoLabel2)
        Me.Controls.Add(Me.AutoLabel1)
        Me.Controls.Add(Me.GradientPanel1)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.dgUsuarios)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(480, 310)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(480, 310)
        Me.Name = "frmUsuarios1"
        Me.Text = "Gerenciamento de Usuários"
        CType(Me.GradientPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GradientPanel1.ResumeLayout(False)
        CType(Me.txtSenha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPesquisar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.msgAguarde.ResumeLayout(False)
        Me.msgAguarde.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AutoLabel3 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents AutoLabel2 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents AutoLabel1 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents GradientPanel1 As Syncfusion.Windows.Forms.Tools.GradientPanel
    Friend WithEvents btnGravar As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents btnCancelar As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents btnExcluir As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents btnAlterar As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents btnInserir As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents txtSenha As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents txtNome As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents txtCodigo As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents dgUsuarios As DataGridView
    Friend WithEvents txtPesquisar As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents msgAguarde As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents SfSkinManager1 As Syncfusion.WinForms.Controls.SfSkinManager
End Class
