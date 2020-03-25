<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLancamentosProdutos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLancamentosProdutos))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.msgAguarde = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AutoLabel1 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.txtPesquisarGrid = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.GradientPanel1 = New Syncfusion.Windows.Forms.Tools.GradientPanel()
        Me.btnGravar = New Syncfusion.WinForms.Controls.SfButton()
        Me.btnCancelar = New Syncfusion.WinForms.Controls.SfButton()
        Me.btnExcluir = New Syncfusion.WinForms.Controls.SfButton()
        Me.btnAlterar = New Syncfusion.WinForms.Controls.SfButton()
        Me.btnInserir = New Syncfusion.WinForms.Controls.SfButton()
        Me.txtCodigo = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.dgResultado = New System.Windows.Forms.DataGridView()
        Me.cboxProdutos = New System.Windows.Forms.ComboBox()
        Me.AutoLabel3 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.txtCodLancamento = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.AutoLabel4 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.txtQtde = New Syncfusion.Windows.Forms.Tools.DoubleTextBox()
        Me.txtValorTotal = New Syncfusion.Windows.Forms.Tools.DoubleTextBox()
        Me.AutoLabel5 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.AutoLabel6 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.txtPreco = New Syncfusion.Windows.Forms.Tools.DoubleTextBox()
        Me.AutoLabel7 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.btnFinalizarLanc = New Syncfusion.WinForms.Controls.SfButton()
        Me.GradientPanel2 = New Syncfusion.Windows.Forms.Tools.GradientPanel()
        Me.lblValorTotal = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.AutoLabel2 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.skinfrmLancamentosProdutos = New Syncfusion.WinForms.Controls.SfSkinManager(Me.components)
        Me.AutoLabel8 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.txtPrVendido = New Syncfusion.Windows.Forms.Tools.DoubleTextBox()
        Me.msgAguarde.SuspendLayout()
        CType(Me.txtPesquisarGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GradientPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GradientPanel1.SuspendLayout()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodLancamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQtde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValorTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPreco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GradientPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GradientPanel2.SuspendLayout()
        CType(Me.txtPrVendido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'msgAguarde
        '
        Me.msgAguarde.Controls.Add(Me.Label1)
        Me.msgAguarde.Location = New System.Drawing.Point(100, 240)
        Me.msgAguarde.Name = "msgAguarde"
        Me.msgAguarde.Size = New System.Drawing.Size(338, 152)
        Me.msgAguarde.TabIndex = 49
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
        'AutoLabel1
        '
        Me.AutoLabel1.Location = New System.Drawing.Point(82, 13)
        Me.AutoLabel1.Name = "AutoLabel1"
        Me.AutoLabel1.Size = New System.Drawing.Size(89, 13)
        Me.AutoLabel1.TabIndex = 47
        Me.AutoLabel1.Text = "Item Lancamento"
        '
        'txtPesquisarGrid
        '
        Me.txtPesquisarGrid.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPesquisarGrid.BeforeTouchSize = New System.Drawing.Size(76, 27)
        Me.txtPesquisarGrid.BorderColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.txtPesquisarGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPesquisarGrid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPesquisarGrid.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPesquisarGrid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtPesquisarGrid.Location = New System.Drawing.Point(7, 436)
        Me.txtPesquisarGrid.Name = "txtPesquisarGrid"
        Me.txtPesquisarGrid.Size = New System.Drawing.Size(566, 27)
        Me.txtPesquisarGrid.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful
        Me.txtPesquisarGrid.TabIndex = 6
        Me.txtPesquisarGrid.ThemeName = "Office2016Colorful"
        '
        'GradientPanel1
        '
        Me.GradientPanel1.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.GradientPanel1.Controls.Add(Me.btnGravar)
        Me.GradientPanel1.Controls.Add(Me.btnCancelar)
        Me.GradientPanel1.Controls.Add(Me.btnExcluir)
        Me.GradientPanel1.Controls.Add(Me.btnAlterar)
        Me.GradientPanel1.Controls.Add(Me.btnInserir)
        Me.GradientPanel1.Location = New System.Drawing.Point(15, 152)
        Me.GradientPanel1.Name = "GradientPanel1"
        Me.GradientPanel1.Size = New System.Drawing.Size(548, 45)
        Me.GradientPanel1.TabIndex = 5
        '
        'btnGravar
        '
        Me.btnGravar.AccessibleName = "Button"
        Me.btnGravar.BackColor = System.Drawing.Color.White
        Me.btnGravar.FocusRectangleVisible = True
        Me.btnGravar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.btnGravar.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnGravar.Location = New System.Drawing.Point(404, 3)
        Me.btnGravar.Name = "btnGravar"
        Me.btnGravar.Size = New System.Drawing.Size(137, 36)
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
        Me.btnCancelar.Location = New System.Drawing.Point(304, 3)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(94, 36)
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
        Me.btnExcluir.Location = New System.Drawing.Point(204, 3)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(94, 36)
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
        Me.btnAlterar.Location = New System.Drawing.Point(104, 3)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(94, 36)
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
        Me.btnInserir.Size = New System.Drawing.Size(94, 36)
        Me.btnInserir.Style.BackColor = System.Drawing.Color.White
        Me.btnInserir.Style.Image = CType(resources.GetObject("resource.Image4"), System.Drawing.Image)
        Me.btnInserir.TabIndex = 0
        Me.btnInserir.Text = "Inserir"
        Me.btnInserir.ThemeName = ""
        Me.btnInserir.UseVisualStyleBackColor = False
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.txtCodigo.BeforeTouchSize = New System.Drawing.Size(76, 27)
        Me.txtCodigo.BorderColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtCodigo.Location = New System.Drawing.Point(82, 28)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(89, 27)
        Me.txtCodigo.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2010
        Me.txtCodigo.TabIndex = 1
        Me.txtCodigo.ThemeName = "Office2010"
        '
        'dgResultado
        '
        Me.dgResultado.AllowUserToAddRows = False
        Me.dgResultado.AllowUserToDeleteRows = False
        Me.dgResultado.AllowUserToOrderColumns = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgResultado.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgResultado.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgResultado.Location = New System.Drawing.Point(7, 224)
        Me.dgResultado.Name = "dgResultado"
        Me.dgResultado.ReadOnly = True
        Me.dgResultado.ShowCellErrors = False
        Me.dgResultado.ShowCellToolTips = False
        Me.dgResultado.ShowEditingIcon = False
        Me.dgResultado.ShowRowErrors = False
        Me.dgResultado.Size = New System.Drawing.Size(566, 206)
        Me.dgResultado.TabIndex = 9
        '
        'cboxProdutos
        '
        Me.cboxProdutos.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.cboxProdutos.FormattingEnabled = True
        Me.cboxProdutos.Items.AddRange(New Object() {"Curso", "Aplicação", "Tratamento", "Produto"})
        Me.cboxProdutos.Location = New System.Drawing.Point(10, 74)
        Me.cboxProdutos.Name = "cboxProdutos"
        Me.cboxProdutos.Size = New System.Drawing.Size(553, 23)
        Me.cboxProdutos.TabIndex = 2
        '
        'AutoLabel3
        '
        Me.AutoLabel3.Location = New System.Drawing.Point(10, 13)
        Me.AutoLabel3.Name = "AutoLabel3"
        Me.AutoLabel3.Size = New System.Drawing.Size(66, 13)
        Me.AutoLabel3.TabIndex = 52
        Me.AutoLabel3.Text = "Lancamento"
        '
        'txtCodLancamento
        '
        Me.txtCodLancamento.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.txtCodLancamento.BeforeTouchSize = New System.Drawing.Size(76, 27)
        Me.txtCodLancamento.BorderColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.txtCodLancamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodLancamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodLancamento.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodLancamento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtCodLancamento.Location = New System.Drawing.Point(7, 28)
        Me.txtCodLancamento.Name = "txtCodLancamento"
        Me.txtCodLancamento.ReadOnly = True
        Me.txtCodLancamento.Size = New System.Drawing.Size(69, 27)
        Me.txtCodLancamento.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2010
        Me.txtCodLancamento.TabIndex = 0
        Me.txtCodLancamento.ThemeName = "Office2010"
        '
        'AutoLabel4
        '
        Me.AutoLabel4.Location = New System.Drawing.Point(13, 58)
        Me.AutoLabel4.Name = "AutoLabel4"
        Me.AutoLabel4.Size = New System.Drawing.Size(44, 13)
        Me.AutoLabel4.TabIndex = 53
        Me.AutoLabel4.Text = "Produto"
        '
        'txtQtde
        '
        Me.txtQtde.BackGroundColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.txtQtde.BeforeTouchSize = New System.Drawing.Size(76, 27)
        Me.txtQtde.BorderColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.txtQtde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQtde.DoubleValue = 1.0R
        Me.txtQtde.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtQtde.Location = New System.Drawing.Point(91, 119)
        Me.txtQtde.Name = "txtQtde"
        Me.txtQtde.Size = New System.Drawing.Size(65, 27)
        Me.txtQtde.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2010
        Me.txtQtde.TabIndex = 3
        Me.txtQtde.Text = "1,00"
        Me.txtQtde.ThemeName = "Office2010"
        '
        'txtValorTotal
        '
        Me.txtValorTotal.BackGroundColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.txtValorTotal.BeforeTouchSize = New System.Drawing.Size(76, 27)
        Me.txtValorTotal.BorderColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.txtValorTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtValorTotal.DoubleValue = 1.0R
        Me.txtValorTotal.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtValorTotal.Location = New System.Drawing.Point(244, 119)
        Me.txtValorTotal.Name = "txtValorTotal"
        Me.txtValorTotal.Size = New System.Drawing.Size(106, 27)
        Me.txtValorTotal.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2010
        Me.txtValorTotal.TabIndex = 4
        Me.txtValorTotal.Text = "1,00"
        Me.txtValorTotal.ThemeName = "Office2010"
        '
        'AutoLabel5
        '
        Me.AutoLabel5.Location = New System.Drawing.Point(94, 103)
        Me.AutoLabel5.Name = "AutoLabel5"
        Me.AutoLabel5.Size = New System.Drawing.Size(62, 13)
        Me.AutoLabel5.TabIndex = 56
        Me.AutoLabel5.Text = "Quantidade"
        '
        'AutoLabel6
        '
        Me.AutoLabel6.Location = New System.Drawing.Point(244, 103)
        Me.AutoLabel6.Name = "AutoLabel6"
        Me.AutoLabel6.Size = New System.Drawing.Size(58, 13)
        Me.AutoLabel6.TabIndex = 57
        Me.AutoLabel6.Text = "Valor Total"
        '
        'txtPreco
        '
        Me.txtPreco.BeforeTouchSize = New System.Drawing.Size(76, 27)
        Me.txtPreco.DoubleValue = 1.0R
        Me.txtPreco.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtPreco.Location = New System.Drawing.Point(15, 119)
        Me.txtPreco.Name = "txtPreco"
        Me.txtPreco.ReadOnly = True
        Me.txtPreco.Size = New System.Drawing.Size(69, 27)
        Me.txtPreco.TabIndex = 8
        Me.txtPreco.Text = "1,00"
        '
        'AutoLabel7
        '
        Me.AutoLabel7.Location = New System.Drawing.Point(15, 103)
        Me.AutoLabel7.Name = "AutoLabel7"
        Me.AutoLabel7.Size = New System.Drawing.Size(57, 13)
        Me.AutoLabel7.TabIndex = 59
        Me.AutoLabel7.Text = "Preço Unit"
        '
        'btnFinalizarLanc
        '
        Me.btnFinalizarLanc.AccessibleName = "Button"
        Me.btnFinalizarLanc.BackColor = System.Drawing.Color.Aquamarine
        Me.btnFinalizarLanc.FocusRectangleVisible = True
        Me.btnFinalizarLanc.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.btnFinalizarLanc.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnFinalizarLanc.Location = New System.Drawing.Point(7, 469)
        Me.btnFinalizarLanc.Name = "btnFinalizarLanc"
        Me.btnFinalizarLanc.Size = New System.Drawing.Size(566, 39)
        Me.btnFinalizarLanc.Style.BackColor = System.Drawing.Color.Aquamarine
        Me.btnFinalizarLanc.Style.Image = CType(resources.GetObject("resource.Image5"), System.Drawing.Image)
        Me.btnFinalizarLanc.TabIndex = 7
        Me.btnFinalizarLanc.Text = "Finalizar Lançamento"
        Me.btnFinalizarLanc.ThemeName = ""
        Me.btnFinalizarLanc.UseVisualStyleBackColor = False
        '
        'GradientPanel2
        '
        Me.GradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GradientPanel2.Controls.Add(Me.lblValorTotal)
        Me.GradientPanel2.Controls.Add(Me.AutoLabel2)
        Me.GradientPanel2.Location = New System.Drawing.Point(359, 6)
        Me.GradientPanel2.Name = "GradientPanel2"
        Me.GradientPanel2.Size = New System.Drawing.Size(204, 63)
        Me.GradientPanel2.TabIndex = 61
        '
        'lblValorTotal
        '
        Me.lblValorTotal.Font = New System.Drawing.Font("Calibri", 25.25!)
        Me.lblValorTotal.ForeColor = System.Drawing.Color.DarkRed
        Me.lblValorTotal.Location = New System.Drawing.Point(45, 17)
        Me.lblValorTotal.Name = "lblValorTotal"
        Me.lblValorTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblValorTotal.Size = New System.Drawing.Size(154, 41)
        Me.lblValorTotal.TabIndex = 59
        Me.lblValorTotal.Text = "R$ 000,00"
        '
        'AutoLabel2
        '
        Me.AutoLabel2.Font = New System.Drawing.Font("Calibri", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AutoLabel2.Location = New System.Drawing.Point(3, 3)
        Me.AutoLabel2.Name = "AutoLabel2"
        Me.AutoLabel2.Size = New System.Drawing.Size(71, 17)
        Me.AutoLabel2.TabIndex = 58
        Me.AutoLabel2.Text = "Valor Total "
        '
        'skinfrmLancamentosProdutos
        '
        Me.skinfrmLancamentosProdutos.Component = Nothing
        Me.skinfrmLancamentosProdutos.Controls = Nothing
        Me.skinfrmLancamentosProdutos.ThemeName = Nothing
        Me.skinfrmLancamentosProdutos.VisualTheme = Syncfusion.Windows.Forms.VisualTheme.Managed
        '
        'AutoLabel8
        '
        Me.AutoLabel8.Location = New System.Drawing.Point(162, 103)
        Me.AutoLabel8.Name = "AutoLabel8"
        Me.AutoLabel8.Size = New System.Drawing.Size(62, 13)
        Me.AutoLabel8.TabIndex = 63
        Me.AutoLabel8.Text = "Pr. Vendido"
        '
        'txtPrVendido
        '
        Me.txtPrVendido.BackGroundColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.txtPrVendido.BeforeTouchSize = New System.Drawing.Size(76, 27)
        Me.txtPrVendido.BorderColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.txtPrVendido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrVendido.DoubleValue = 1.0R
        Me.txtPrVendido.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtPrVendido.Location = New System.Drawing.Point(162, 119)
        Me.txtPrVendido.Name = "txtPrVendido"
        Me.txtPrVendido.ReadOnly = True
        Me.txtPrVendido.Size = New System.Drawing.Size(76, 27)
        Me.txtPrVendido.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2010
        Me.txtPrVendido.TabIndex = 9
        Me.txtPrVendido.Text = "1,00"
        Me.txtPrVendido.ThemeName = "Office2010"
        '
        'frmLancamentosProdutos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 517)
        Me.ControlBox = False
        Me.Controls.Add(Me.AutoLabel8)
        Me.Controls.Add(Me.txtPrVendido)
        Me.Controls.Add(Me.GradientPanel2)
        Me.Controls.Add(Me.btnFinalizarLanc)
        Me.Controls.Add(Me.AutoLabel7)
        Me.Controls.Add(Me.txtPreco)
        Me.Controls.Add(Me.AutoLabel6)
        Me.Controls.Add(Me.AutoLabel5)
        Me.Controls.Add(Me.txtValorTotal)
        Me.Controls.Add(Me.txtQtde)
        Me.Controls.Add(Me.AutoLabel4)
        Me.Controls.Add(Me.AutoLabel3)
        Me.Controls.Add(Me.txtCodLancamento)
        Me.Controls.Add(Me.cboxProdutos)
        Me.Controls.Add(Me.msgAguarde)
        Me.Controls.Add(Me.AutoLabel1)
        Me.Controls.Add(Me.txtPesquisarGrid)
        Me.Controls.Add(Me.GradientPanel1)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.dgResultado)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLancamentosProdutos"
        Me.Text = "Lancamentos de Itens"
        Me.msgAguarde.ResumeLayout(False)
        Me.msgAguarde.PerformLayout()
        CType(Me.txtPesquisarGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GradientPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GradientPanel1.ResumeLayout(False)
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgResultado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodLancamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQtde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValorTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPreco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GradientPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GradientPanel2.ResumeLayout(False)
        Me.GradientPanel2.PerformLayout()
        CType(Me.txtPrVendido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents msgAguarde As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents AutoLabel1 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents txtPesquisarGrid As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents GradientPanel1 As Syncfusion.Windows.Forms.Tools.GradientPanel
    Friend WithEvents btnGravar As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents btnCancelar As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents btnExcluir As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents btnAlterar As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents btnInserir As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents txtCodigo As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents dgResultado As DataGridView
    Friend WithEvents cboxProdutos As ComboBox
    Friend WithEvents AutoLabel3 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents txtCodLancamento As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents AutoLabel4 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents txtQtde As Syncfusion.Windows.Forms.Tools.DoubleTextBox
    Friend WithEvents txtValorTotal As Syncfusion.Windows.Forms.Tools.DoubleTextBox
    Friend WithEvents AutoLabel5 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents AutoLabel6 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents txtPreco As Syncfusion.Windows.Forms.Tools.DoubleTextBox
    Friend WithEvents AutoLabel7 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents btnFinalizarLanc As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents GradientPanel2 As Syncfusion.Windows.Forms.Tools.GradientPanel
    Friend WithEvents lblValorTotal As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents AutoLabel2 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents skinfrmLancamentosProdutos As Syncfusion.WinForms.Controls.SfSkinManager
    Friend WithEvents AutoLabel8 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents txtPrVendido As Syncfusion.Windows.Forms.Tools.DoubleTextBox
End Class
