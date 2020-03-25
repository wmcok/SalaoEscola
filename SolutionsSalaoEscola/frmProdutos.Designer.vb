<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProdutos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProdutos))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtPesquisar = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.AutoLabel3 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.AutoLabel2 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.AutoLabel1 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.GradientPanel1 = New Syncfusion.Windows.Forms.Tools.GradientPanel()
        Me.btnGravar = New Syncfusion.WinForms.Controls.SfButton()
        Me.btnCancelar = New Syncfusion.WinForms.Controls.SfButton()
        Me.btnExcluir = New Syncfusion.WinForms.Controls.SfButton()
        Me.btnAlterar = New Syncfusion.WinForms.Controls.SfButton()
        Me.btnInserir = New Syncfusion.WinForms.Controls.SfButton()
        Me.txtNome = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.txtCodigo = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.dgProdutos = New System.Windows.Forms.DataGridView()
        Me.txtPreco = New Syncfusion.Windows.Forms.Tools.DoubleTextBox()
        Me.msgAguarde = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboxTipoProduto = New System.Windows.Forms.ComboBox()
        Me.SfSkinManager1 = New Syncfusion.WinForms.Controls.SfSkinManager(Me.components)
        CType(Me.txtPesquisar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GradientPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GradientPanel1.SuspendLayout()
        CType(Me.txtNome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgProdutos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPreco, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.msgAguarde.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtPesquisar
        '
        Me.txtPesquisar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPesquisar.BeforeTouchSize = New System.Drawing.Size(87, 27)
        Me.txtPesquisar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.txtPesquisar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPesquisar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPesquisar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPesquisar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtPesquisar.Location = New System.Drawing.Point(7, 364)
        Me.txtPesquisar.Name = "txtPesquisar"
        Me.txtPesquisar.Size = New System.Drawing.Size(540, 27)
        Me.txtPesquisar.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful
        Me.txtPesquisar.TabIndex = 5
        Me.txtPesquisar.ThemeName = "Office2016Colorful"
        '
        'AutoLabel3
        '
        Me.AutoLabel3.Location = New System.Drawing.Point(272, 75)
        Me.AutoLabel3.Name = "AutoLabel3"
        Me.AutoLabel3.Size = New System.Drawing.Size(35, 13)
        Me.AutoLabel3.TabIndex = 29
        Me.AutoLabel3.Text = "Preço"
        '
        'AutoLabel2
        '
        Me.AutoLabel2.Location = New System.Drawing.Point(6, 75)
        Me.AutoLabel2.Name = "AutoLabel2"
        Me.AutoLabel2.Size = New System.Drawing.Size(44, 13)
        Me.AutoLabel2.TabIndex = 28
        Me.AutoLabel2.Text = "Produto"
        '
        'AutoLabel1
        '
        Me.AutoLabel1.Location = New System.Drawing.Point(7, 24)
        Me.AutoLabel1.Name = "AutoLabel1"
        Me.AutoLabel1.Size = New System.Drawing.Size(40, 13)
        Me.AutoLabel1.TabIndex = 27
        Me.AutoLabel1.Text = "Código"
        '
        'GradientPanel1
        '
        Me.GradientPanel1.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.GradientPanel1.Controls.Add(Me.btnGravar)
        Me.GradientPanel1.Controls.Add(Me.btnCancelar)
        Me.GradientPanel1.Controls.Add(Me.btnExcluir)
        Me.GradientPanel1.Controls.Add(Me.btnAlterar)
        Me.GradientPanel1.Controls.Add(Me.btnInserir)
        Me.GradientPanel1.Location = New System.Drawing.Point(365, 12)
        Me.GradientPanel1.Name = "GradientPanel1"
        Me.GradientPanel1.Size = New System.Drawing.Size(182, 106)
        Me.GradientPanel1.TabIndex = 4
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
        Me.btnGravar.ThemeName = ""
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
        Me.btnCancelar.ThemeName = ""
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
        Me.btnExcluir.ThemeName = ""
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
        Me.btnAlterar.ThemeName = ""
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
        Me.btnInserir.ThemeName = ""
        Me.btnInserir.UseVisualStyleBackColor = False
        '
        'txtNome
        '
        Me.txtNome.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNome.BeforeTouchSize = New System.Drawing.Size(87, 27)
        Me.txtNome.BorderColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNome.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtNome.Location = New System.Drawing.Point(6, 91)
        Me.txtNome.MaxLength = 60
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(260, 27)
        Me.txtNome.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful
        Me.txtNome.TabIndex = 2
        Me.txtNome.ThemeName = "Office2016Colorful"
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCodigo.BeforeTouchSize = New System.Drawing.Size(87, 27)
        Me.txtCodigo.BorderColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtCodigo.Location = New System.Drawing.Point(7, 40)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(142, 27)
        Me.txtCodigo.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful
        Me.txtCodigo.TabIndex = 0
        Me.txtCodigo.ThemeName = "Office2016Colorful"
        '
        'dgProdutos
        '
        Me.dgProdutos.AllowUserToAddRows = False
        Me.dgProdutos.AllowUserToDeleteRows = False
        Me.dgProdutos.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgProdutos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgProdutos.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgProdutos.Location = New System.Drawing.Point(7, 124)
        Me.dgProdutos.Name = "dgProdutos"
        Me.dgProdutos.ReadOnly = True
        Me.dgProdutos.ShowCellErrors = False
        Me.dgProdutos.ShowCellToolTips = False
        Me.dgProdutos.ShowEditingIcon = False
        Me.dgProdutos.ShowRowErrors = False
        Me.dgProdutos.Size = New System.Drawing.Size(540, 234)
        Me.dgProdutos.TabIndex = 6
        '
        'txtPreco
        '
        Me.txtPreco.BeforeTouchSize = New System.Drawing.Size(87, 27)
        Me.txtPreco.DoubleValue = 1.0R
        Me.txtPreco.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtPreco.Location = New System.Drawing.Point(272, 91)
        Me.txtPreco.Name = "txtPreco"
        Me.txtPreco.Size = New System.Drawing.Size(87, 27)
        Me.txtPreco.TabIndex = 3
        Me.txtPreco.Text = "1,00"
        '
        'msgAguarde
        '
        Me.msgAguarde.Controls.Add(Me.Label1)
        Me.msgAguarde.Location = New System.Drawing.Point(100, 101)
        Me.msgAguarde.Name = "msgAguarde"
        Me.msgAguarde.Size = New System.Drawing.Size(338, 152)
        Me.msgAguarde.TabIndex = 33
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
        'cboxTipoProduto
        '
        Me.cboxTipoProduto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboxTipoProduto.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.cboxTipoProduto.FormattingEnabled = True
        Me.cboxTipoProduto.Items.AddRange(New Object() {"Curso", "Aplicação", "Tratamento", "Produto"})
        Me.cboxTipoProduto.Location = New System.Drawing.Point(155, 40)
        Me.cboxTipoProduto.Name = "cboxTipoProduto"
        Me.cboxTipoProduto.Size = New System.Drawing.Size(204, 27)
        Me.cboxTipoProduto.TabIndex = 1
        '
        'SfSkinManager1
        '
        Me.SfSkinManager1.Component = Nothing
        Me.SfSkinManager1.Controls = Nothing
        Me.SfSkinManager1.ThemeName = Nothing
        Me.SfSkinManager1.VisualTheme = Syncfusion.Windows.Forms.VisualTheme.Managed
        '
        'frmProdutos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 403)
        Me.Controls.Add(Me.cboxTipoProduto)
        Me.Controls.Add(Me.msgAguarde)
        Me.Controls.Add(Me.txtPreco)
        Me.Controls.Add(Me.txtPesquisar)
        Me.Controls.Add(Me.AutoLabel3)
        Me.Controls.Add(Me.AutoLabel2)
        Me.Controls.Add(Me.AutoLabel1)
        Me.Controls.Add(Me.GradientPanel1)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.dgProdutos)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(565, 440)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(565, 440)
        Me.Name = "frmProdutos"
        Me.Text = "Controle de Produtos"
        CType(Me.txtPesquisar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GradientPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GradientPanel1.ResumeLayout(False)
        CType(Me.txtNome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgProdutos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPreco, System.ComponentModel.ISupportInitialize).EndInit()
        Me.msgAguarde.ResumeLayout(False)
        Me.msgAguarde.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPesquisar As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents AutoLabel3 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents AutoLabel2 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents AutoLabel1 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents GradientPanel1 As Syncfusion.Windows.Forms.Tools.GradientPanel
    Friend WithEvents btnGravar As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents btnCancelar As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents btnExcluir As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents btnAlterar As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents btnInserir As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents txtNome As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents txtCodigo As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents dgProdutos As DataGridView
    Friend WithEvents txtPreco As Syncfusion.Windows.Forms.Tools.DoubleTextBox
    Friend WithEvents msgAguarde As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents cboxTipoProduto As ComboBox
    Friend WithEvents SfSkinManager1 As Syncfusion.WinForms.Controls.SfSkinManager
End Class
