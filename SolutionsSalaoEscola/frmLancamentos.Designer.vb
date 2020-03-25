<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLancamentos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLancamentos))
        Me.GradientPanel2 = New Syncfusion.Windows.Forms.Tools.GradientPanel()
        Me.msgAguarde = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgResultado = New System.Windows.Forms.DataGridView()
        Me.txtPesquisarGrid = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.GradientPanel1 = New Syncfusion.Windows.Forms.Tools.GradientPanel()
        Me.AutoLabel7 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.AutoLabel6 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.AutoLabel5 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.AutoLabel4 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.cboxNatureza = New System.Windows.Forms.ComboBox()
        Me.cboxFilial = New System.Windows.Forms.ComboBox()
        Me.dtInicio = New Syncfusion.WinForms.Input.SfDateTimeEdit()
        Me.txtPreco = New Syncfusion.Windows.Forms.Tools.DoubleTextBox()
        Me.AutoLabel3 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.AutoLabel1 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.GradientPanel3 = New Syncfusion.Windows.Forms.Tools.GradientPanel()
        Me.btnGravar = New Syncfusion.WinForms.Controls.SfButton()
        Me.btnCancelar = New Syncfusion.WinForms.Controls.SfButton()
        Me.btnExcluir = New Syncfusion.WinForms.Controls.SfButton()
        Me.btnAlterar = New Syncfusion.WinForms.Controls.SfButton()
        Me.btnInserir = New Syncfusion.WinForms.Controls.SfButton()
        Me.txtObservacao = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.txtCodigo = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.FilialBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SfSkinManager1 = New Syncfusion.WinForms.Controls.SfSkinManager(Me.components)
        CType(Me.GradientPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GradientPanel2.SuspendLayout()
        Me.msgAguarde.SuspendLayout()
        CType(Me.dgResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPesquisarGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GradientPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GradientPanel1.SuspendLayout()
        CType(Me.txtPreco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GradientPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GradientPanel3.SuspendLayout()
        CType(Me.txtObservacao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FilialBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GradientPanel2
        '
        Me.GradientPanel2.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.GradientPanel2.Controls.Add(Me.msgAguarde)
        Me.GradientPanel2.Controls.Add(Me.dgResultado)
        Me.GradientPanel2.Controls.Add(Me.txtPesquisarGrid)
        Me.GradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GradientPanel2.Location = New System.Drawing.Point(0, 218)
        Me.GradientPanel2.Name = "GradientPanel2"
        Me.GradientPanel2.Size = New System.Drawing.Size(519, 260)
        Me.GradientPanel2.TabIndex = 3
        '
        'msgAguarde
        '
        Me.msgAguarde.Controls.Add(Me.Label1)
        Me.msgAguarde.Location = New System.Drawing.Point(105, 38)
        Me.msgAguarde.Name = "msgAguarde"
        Me.msgAguarde.Size = New System.Drawing.Size(338, 152)
        Me.msgAguarde.TabIndex = 42
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
        'dgResultado
        '
        Me.dgResultado.AllowUserToAddRows = False
        Me.dgResultado.AllowUserToDeleteRows = False
        Me.dgResultado.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgResultado.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgResultado.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgResultado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgResultado.Location = New System.Drawing.Point(0, 0)
        Me.dgResultado.Name = "dgResultado"
        Me.dgResultado.ReadOnly = True
        Me.dgResultado.ShowCellErrors = False
        Me.dgResultado.ShowCellToolTips = False
        Me.dgResultado.ShowEditingIcon = False
        Me.dgResultado.ShowRowErrors = False
        Me.dgResultado.Size = New System.Drawing.Size(515, 229)
        Me.dgResultado.TabIndex = 1
        '
        'txtPesquisarGrid
        '
        Me.txtPesquisarGrid.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPesquisarGrid.BeforeTouchSize = New System.Drawing.Size(182, 27)
        Me.txtPesquisarGrid.BorderColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.txtPesquisarGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPesquisarGrid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPesquisarGrid.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtPesquisarGrid.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPesquisarGrid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtPesquisarGrid.Location = New System.Drawing.Point(0, 229)
        Me.txtPesquisarGrid.Name = "txtPesquisarGrid"
        Me.txtPesquisarGrid.Size = New System.Drawing.Size(515, 27)
        Me.txtPesquisarGrid.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful
        Me.txtPesquisarGrid.TabIndex = 0
        Me.txtPesquisarGrid.ThemeName = "Office2016Colorful"
        '
        'GradientPanel1
        '
        Me.GradientPanel1.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.GradientPanel1.Controls.Add(Me.AutoLabel7)
        Me.GradientPanel1.Controls.Add(Me.AutoLabel6)
        Me.GradientPanel1.Controls.Add(Me.AutoLabel5)
        Me.GradientPanel1.Controls.Add(Me.AutoLabel4)
        Me.GradientPanel1.Controls.Add(Me.cboxNatureza)
        Me.GradientPanel1.Controls.Add(Me.cboxFilial)
        Me.GradientPanel1.Controls.Add(Me.dtInicio)
        Me.GradientPanel1.Controls.Add(Me.txtPreco)
        Me.GradientPanel1.Controls.Add(Me.AutoLabel3)
        Me.GradientPanel1.Controls.Add(Me.AutoLabel1)
        Me.GradientPanel1.Controls.Add(Me.GradientPanel3)
        Me.GradientPanel1.Controls.Add(Me.txtObservacao)
        Me.GradientPanel1.Controls.Add(Me.txtCodigo)
        Me.GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GradientPanel1.Name = "GradientPanel1"
        Me.GradientPanel1.Size = New System.Drawing.Size(519, 218)
        Me.GradientPanel1.TabIndex = 0
        '
        'AutoLabel7
        '
        Me.AutoLabel7.Location = New System.Drawing.Point(268, 87)
        Me.AutoLabel7.Name = "AutoLabel7"
        Me.AutoLabel7.Size = New System.Drawing.Size(58, 13)
        Me.AutoLabel7.TabIndex = 50
        Me.AutoLabel7.Text = "Valor Total"
        '
        'AutoLabel6
        '
        Me.AutoLabel6.Location = New System.Drawing.Point(17, 45)
        Me.AutoLabel6.Name = "AutoLabel6"
        Me.AutoLabel6.Size = New System.Drawing.Size(50, 13)
        Me.AutoLabel6.TabIndex = 49
        Me.AutoLabel6.Text = "Natureza"
        '
        'AutoLabel5
        '
        Me.AutoLabel5.Location = New System.Drawing.Point(18, 3)
        Me.AutoLabel5.Name = "AutoLabel5"
        Me.AutoLabel5.Size = New System.Drawing.Size(27, 13)
        Me.AutoLabel5.TabIndex = 48
        Me.AutoLabel5.Text = "Filial"
        '
        'AutoLabel4
        '
        Me.AutoLabel4.Location = New System.Drawing.Point(22, 134)
        Me.AutoLabel4.Name = "AutoLabel4"
        Me.AutoLabel4.Size = New System.Drawing.Size(65, 13)
        Me.AutoLabel4.TabIndex = 47
        Me.AutoLabel4.Text = "Observação"
        '
        'cboxNatureza
        '
        Me.cboxNatureza.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.cboxNatureza.FormattingEnabled = True
        Me.cboxNatureza.Location = New System.Drawing.Point(17, 60)
        Me.cboxNatureza.Name = "cboxNatureza"
        Me.cboxNatureza.Size = New System.Drawing.Size(357, 23)
        Me.cboxNatureza.TabIndex = 1
        '
        'cboxFilial
        '
        Me.cboxFilial.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.cboxFilial.FormattingEnabled = True
        Me.cboxFilial.Location = New System.Drawing.Point(18, 18)
        Me.cboxFilial.Name = "cboxFilial"
        Me.cboxFilial.Size = New System.Drawing.Size(356, 23)
        Me.cboxFilial.TabIndex = 0
        '
        'dtInicio
        '
        Me.dtInicio.Cursor = System.Windows.Forms.Cursors.Default
        Me.dtInicio.DateTimeEditingMode = Syncfusion.WinForms.Input.Enums.DateTimeEditingMode.Mask
        Me.dtInicio.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtInicio.Location = New System.Drawing.Point(141, 108)
        Me.dtInicio.Name = "dtInicio"
        Me.dtInicio.Size = New System.Drawing.Size(121, 22)
        Me.dtInicio.TabIndex = 3
        '
        'txtPreco
        '
        Me.txtPreco.BeforeTouchSize = New System.Drawing.Size(182, 27)
        Me.txtPreco.BorderColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.txtPreco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPreco.DoubleValue = 1.0R
        Me.txtPreco.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtPreco.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtPreco.Location = New System.Drawing.Point(268, 103)
        Me.txtPreco.Name = "txtPreco"
        Me.txtPreco.PositiveColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtPreco.ReadOnly = True
        Me.txtPreco.Size = New System.Drawing.Size(106, 27)
        Me.txtPreco.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2010
        Me.txtPreco.TabIndex = 4
        Me.txtPreco.Text = "1,00"
        Me.txtPreco.ThemeName = "Office2010"
        Me.txtPreco.ZeroColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        '
        'AutoLabel3
        '
        Me.AutoLabel3.Location = New System.Drawing.Point(141, 88)
        Me.AutoLabel3.Name = "AutoLabel3"
        Me.AutoLabel3.Size = New System.Drawing.Size(30, 13)
        Me.AutoLabel3.TabIndex = 41
        Me.AutoLabel3.Text = "Data"
        '
        'AutoLabel1
        '
        Me.AutoLabel1.Location = New System.Drawing.Point(18, 87)
        Me.AutoLabel1.Name = "AutoLabel1"
        Me.AutoLabel1.Size = New System.Drawing.Size(117, 13)
        Me.AutoLabel1.TabIndex = 39
        Me.AutoLabel1.Text = "Código de Lançamento"
        '
        'GradientPanel3
        '
        Me.GradientPanel3.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.GradientPanel3.Controls.Add(Me.btnGravar)
        Me.GradientPanel3.Controls.Add(Me.btnCancelar)
        Me.GradientPanel3.Controls.Add(Me.btnExcluir)
        Me.GradientPanel3.Controls.Add(Me.btnAlterar)
        Me.GradientPanel3.Controls.Add(Me.btnInserir)
        Me.GradientPanel3.Location = New System.Drawing.Point(397, 4)
        Me.GradientPanel3.Name = "GradientPanel3"
        Me.GradientPanel3.Size = New System.Drawing.Size(113, 206)
        Me.GradientPanel3.TabIndex = 38
        '
        'btnGravar
        '
        Me.btnGravar.AccessibleName = "Button"
        Me.btnGravar.BackColor = System.Drawing.Color.White
        Me.btnGravar.FocusRectangleVisible = True
        Me.btnGravar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.btnGravar.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnGravar.Location = New System.Drawing.Point(4, 137)
        Me.btnGravar.Name = "btnGravar"
        Me.btnGravar.Size = New System.Drawing.Size(102, 61)
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
        Me.btnCancelar.Location = New System.Drawing.Point(4, 103)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(102, 28)
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
        Me.btnExcluir.Size = New System.Drawing.Size(102, 28)
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
        Me.btnAlterar.Size = New System.Drawing.Size(102, 28)
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
        Me.btnInserir.Size = New System.Drawing.Size(102, 28)
        Me.btnInserir.Style.BackColor = System.Drawing.Color.White
        Me.btnInserir.Style.Image = CType(resources.GetObject("resource.Image4"), System.Drawing.Image)
        Me.btnInserir.TabIndex = 0
        Me.btnInserir.Text = "Inserir"
        Me.btnInserir.ThemeName = ""
        Me.btnInserir.UseVisualStyleBackColor = False
        '
        'txtObservacao
        '
        Me.txtObservacao.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.txtObservacao.BeforeTouchSize = New System.Drawing.Size(182, 27)
        Me.txtObservacao.BorderColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.txtObservacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservacao.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacao.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtObservacao.Location = New System.Drawing.Point(17, 150)
        Me.txtObservacao.MaxLength = 200
        Me.txtObservacao.Multiline = True
        Me.txtObservacao.Name = "txtObservacao"
        Me.txtObservacao.Size = New System.Drawing.Size(374, 59)
        Me.txtObservacao.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2010
        Me.txtObservacao.TabIndex = 5
        Me.txtObservacao.ThemeName = "Office2010"
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtCodigo.BeforeTouchSize = New System.Drawing.Size(182, 27)
        Me.txtCodigo.BorderColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.txtCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.txtCodigo.Location = New System.Drawing.Point(18, 106)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(117, 24)
        Me.txtCodigo.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2007
        Me.txtCodigo.TabIndex = 2
        Me.txtCodigo.ThemeName = "Office2007"
        '
        'FilialBindingSource
        '
        Me.FilialBindingSource.DataSource = GetType(SolutionsSalaoEscola.Filial)
        '
        'SfSkinManager1
        '
        Me.SfSkinManager1.Component = Nothing
        Me.SfSkinManager1.Controls = Nothing
        Me.SfSkinManager1.ThemeName = Nothing
        Me.SfSkinManager1.VisualTheme = Syncfusion.Windows.Forms.VisualTheme.Managed
        '
        'frmLancamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 478)
        Me.Controls.Add(Me.GradientPanel2)
        Me.Controls.Add(Me.GradientPanel1)
        Me.Name = "frmLancamentos"
        Me.Text = "Cadastro de Lançamentos"
        CType(Me.GradientPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GradientPanel2.ResumeLayout(False)
        Me.GradientPanel2.PerformLayout()
        Me.msgAguarde.ResumeLayout(False)
        Me.msgAguarde.PerformLayout()
        CType(Me.dgResultado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPesquisarGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GradientPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GradientPanel1.ResumeLayout(False)
        Me.GradientPanel1.PerformLayout()
        CType(Me.txtPreco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GradientPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GradientPanel3.ResumeLayout(False)
        CType(Me.txtObservacao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FilialBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GradientPanel2 As Syncfusion.Windows.Forms.Tools.GradientPanel
    Friend WithEvents msgAguarde As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents dgResultado As DataGridView
    Friend WithEvents txtPesquisarGrid As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents GradientPanel1 As Syncfusion.Windows.Forms.Tools.GradientPanel
    Friend WithEvents txtPreco As Syncfusion.Windows.Forms.Tools.DoubleTextBox
    Friend WithEvents AutoLabel3 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents AutoLabel1 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents GradientPanel3 As Syncfusion.Windows.Forms.Tools.GradientPanel
    Friend WithEvents btnGravar As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents btnCancelar As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents btnExcluir As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents btnAlterar As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents btnInserir As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents txtObservacao As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents txtCodigo As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents dtInicio As Syncfusion.WinForms.Input.SfDateTimeEdit
    Friend WithEvents AutoLabel7 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents AutoLabel6 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents AutoLabel5 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents AutoLabel4 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents cboxNatureza As ComboBox
    Friend WithEvents cboxFilial As ComboBox
    Friend WithEvents FilialBindingSource As BindingSource
    Friend WithEvents SfSkinManager1 As Syncfusion.WinForms.Controls.SfSkinManager
End Class
