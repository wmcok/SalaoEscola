<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmControleFinanceiro
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmControleFinanceiro))
        Me.GradientPanel1 = New Syncfusion.Windows.Forms.Tools.GradientPanel()
        Me.cboxTipo = New System.Windows.Forms.ComboBox()
        Me.AutoLabel4 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.txtCodFinanceiro = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.checkPagamento = New System.Windows.Forms.CheckBox()
        Me.checkVencimento = New System.Windows.Forms.CheckBox()
        Me.panelPagamento = New Syncfusion.Windows.Forms.Tools.GradientPanel()
        Me.dtFinalPG = New Syncfusion.WinForms.Input.SfDateTimeEdit()
        Me.dtInicioPG = New Syncfusion.WinForms.Input.SfDateTimeEdit()
        Me.panelVencimento = New Syncfusion.Windows.Forms.Tools.GradientPanel()
        Me.dtFinalVenc = New Syncfusion.WinForms.Input.SfDateTimeEdit()
        Me.dtInicioVenc = New Syncfusion.WinForms.Input.SfDateTimeEdit()
        Me.AutoLabel3 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.txtCodLancamento = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.AutoLabel2 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.AutoLabel1 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.cboxNatureza = New System.Windows.Forms.ComboBox()
        Me.cboxFilial = New System.Windows.Forms.ComboBox()
        Me.txtPesquisarGrid = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.msgAguarde = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgResultado = New System.Windows.Forms.DataGridView()
        Me.btnPrint = New Syncfusion.WinForms.Controls.SfButton()
        Me.btnNovoFinanceiro = New Syncfusion.WinForms.Controls.SfButton()
        Me.btnPesquisar = New Syncfusion.WinForms.Controls.SfButton()
        Me.btnPrintNatureza = New Syncfusion.WinForms.Controls.SfButton()
        CType(Me.GradientPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GradientPanel1.SuspendLayout()
        CType(Me.txtCodFinanceiro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelPagamento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelPagamento.SuspendLayout()
        CType(Me.panelVencimento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelVencimento.SuspendLayout()
        CType(Me.txtCodLancamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPesquisarGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.msgAguarde.SuspendLayout()
        CType(Me.dgResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GradientPanel1
        '
        Me.GradientPanel1.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.GradientPanel1.Controls.Add(Me.btnPrintNatureza)
        Me.GradientPanel1.Controls.Add(Me.btnPrint)
        Me.GradientPanel1.Controls.Add(Me.cboxTipo)
        Me.GradientPanel1.Controls.Add(Me.AutoLabel4)
        Me.GradientPanel1.Controls.Add(Me.txtCodFinanceiro)
        Me.GradientPanel1.Controls.Add(Me.checkPagamento)
        Me.GradientPanel1.Controls.Add(Me.checkVencimento)
        Me.GradientPanel1.Controls.Add(Me.panelPagamento)
        Me.GradientPanel1.Controls.Add(Me.panelVencimento)
        Me.GradientPanel1.Controls.Add(Me.AutoLabel3)
        Me.GradientPanel1.Controls.Add(Me.txtCodLancamento)
        Me.GradientPanel1.Controls.Add(Me.btnNovoFinanceiro)
        Me.GradientPanel1.Controls.Add(Me.btnPesquisar)
        Me.GradientPanel1.Controls.Add(Me.AutoLabel2)
        Me.GradientPanel1.Controls.Add(Me.AutoLabel1)
        Me.GradientPanel1.Controls.Add(Me.cboxNatureza)
        Me.GradientPanel1.Controls.Add(Me.cboxFilial)
        Me.GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GradientPanel1.Name = "GradientPanel1"
        Me.GradientPanel1.Size = New System.Drawing.Size(712, 135)
        Me.GradientPanel1.TabIndex = 1
        '
        'cboxTipo
        '
        Me.cboxTipo.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.cboxTipo.FormattingEnabled = True
        Me.cboxTipo.Items.AddRange(New Object() {"TODOS", "RECEBER", "PAGAR"})
        Me.cboxTipo.Location = New System.Drawing.Point(598, 2)
        Me.cboxTipo.Name = "cboxTipo"
        Me.cboxTipo.Size = New System.Drawing.Size(105, 23)
        Me.cboxTipo.TabIndex = 51
        '
        'AutoLabel4
        '
        Me.AutoLabel4.Location = New System.Drawing.Point(417, 68)
        Me.AutoLabel4.Name = "AutoLabel4"
        Me.AutoLabel4.Size = New System.Drawing.Size(56, 13)
        Me.AutoLabel4.TabIndex = 50
        Me.AutoLabel4.Text = "Financeiro"
        '
        'txtCodFinanceiro
        '
        Me.txtCodFinanceiro.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.txtCodFinanceiro.BeforeTouchSize = New System.Drawing.Size(712, 27)
        Me.txtCodFinanceiro.BorderColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.txtCodFinanceiro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodFinanceiro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodFinanceiro.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.txtCodFinanceiro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtCodFinanceiro.Location = New System.Drawing.Point(481, 60)
        Me.txtCodFinanceiro.Name = "txtCodFinanceiro"
        Me.txtCodFinanceiro.Size = New System.Drawing.Size(111, 24)
        Me.txtCodFinanceiro.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2010
        Me.txtCodFinanceiro.TabIndex = 49
        Me.txtCodFinanceiro.ThemeName = "Office2010"
        '
        'checkPagamento
        '
        Me.checkPagamento.AutoSize = True
        Me.checkPagamento.Location = New System.Drawing.Point(125, 6)
        Me.checkPagamento.Name = "checkPagamento"
        Me.checkPagamento.Size = New System.Drawing.Size(98, 17)
        Me.checkPagamento.TabIndex = 48
        Me.checkPagamento.Text = "DT Pagamento"
        Me.checkPagamento.UseVisualStyleBackColor = True
        '
        'checkVencimento
        '
        Me.checkVencimento.AutoSize = True
        Me.checkVencimento.Checked = True
        Me.checkVencimento.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkVencimento.Location = New System.Drawing.Point(8, 6)
        Me.checkVencimento.Name = "checkVencimento"
        Me.checkVencimento.Size = New System.Drawing.Size(100, 17)
        Me.checkVencimento.TabIndex = 47
        Me.checkVencimento.Text = "DT Vencimento"
        Me.checkVencimento.UseVisualStyleBackColor = True
        '
        'panelPagamento
        '
        Me.panelPagamento.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.panelPagamento.Controls.Add(Me.dtFinalPG)
        Me.panelPagamento.Controls.Add(Me.dtInicioPG)
        Me.panelPagamento.Location = New System.Drawing.Point(122, 24)
        Me.panelPagamento.Name = "panelPagamento"
        Me.panelPagamento.Size = New System.Drawing.Size(111, 59)
        Me.panelPagamento.TabIndex = 46
        '
        'dtFinalPG
        '
        Me.dtFinalPG.Cursor = System.Windows.Forms.Cursors.Default
        Me.dtFinalPG.DateTimeEditingMode = Syncfusion.WinForms.Input.Enums.DateTimeEditingMode.Mask
        Me.dtFinalPG.Location = New System.Drawing.Point(1, 31)
        Me.dtFinalPG.Name = "dtFinalPG"
        Me.dtFinalPG.Size = New System.Drawing.Size(102, 22)
        Me.dtFinalPG.TabIndex = 3
        '
        'dtInicioPG
        '
        Me.dtInicioPG.Cursor = System.Windows.Forms.Cursors.Default
        Me.dtInicioPG.DateTimeEditingMode = Syncfusion.WinForms.Input.Enums.DateTimeEditingMode.Mask
        Me.dtInicioPG.Location = New System.Drawing.Point(1, 3)
        Me.dtInicioPG.Name = "dtInicioPG"
        Me.dtInicioPG.Size = New System.Drawing.Size(102, 22)
        Me.dtInicioPG.TabIndex = 2
        '
        'panelVencimento
        '
        Me.panelVencimento.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.panelVencimento.Controls.Add(Me.dtFinalVenc)
        Me.panelVencimento.Controls.Add(Me.dtInicioVenc)
        Me.panelVencimento.Location = New System.Drawing.Point(5, 24)
        Me.panelVencimento.Name = "panelVencimento"
        Me.panelVencimento.Size = New System.Drawing.Size(111, 59)
        Me.panelVencimento.TabIndex = 45
        '
        'dtFinalVenc
        '
        Me.dtFinalVenc.Cursor = System.Windows.Forms.Cursors.Default
        Me.dtFinalVenc.DateTimeEditingMode = Syncfusion.WinForms.Input.Enums.DateTimeEditingMode.Mask
        Me.dtFinalVenc.Location = New System.Drawing.Point(1, 31)
        Me.dtFinalVenc.Name = "dtFinalVenc"
        Me.dtFinalVenc.Size = New System.Drawing.Size(102, 22)
        Me.dtFinalVenc.TabIndex = 3
        '
        'dtInicioVenc
        '
        Me.dtInicioVenc.Cursor = System.Windows.Forms.Cursors.Default
        Me.dtInicioVenc.DateTimeEditingMode = Syncfusion.WinForms.Input.Enums.DateTimeEditingMode.Mask
        Me.dtInicioVenc.Location = New System.Drawing.Point(1, 3)
        Me.dtInicioVenc.Name = "dtInicioVenc"
        Me.dtInicioVenc.Size = New System.Drawing.Size(102, 22)
        Me.dtInicioVenc.TabIndex = 2
        '
        'AutoLabel3
        '
        Me.AutoLabel3.Location = New System.Drawing.Point(239, 66)
        Me.AutoLabel3.Name = "AutoLabel3"
        Me.AutoLabel3.Size = New System.Drawing.Size(66, 13)
        Me.AutoLabel3.TabIndex = 44
        Me.AutoLabel3.Text = "Lancamento"
        '
        'txtCodLancamento
        '
        Me.txtCodLancamento.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.txtCodLancamento.BeforeTouchSize = New System.Drawing.Size(712, 27)
        Me.txtCodLancamento.BorderColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.txtCodLancamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodLancamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodLancamento.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.txtCodLancamento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtCodLancamento.Location = New System.Drawing.Point(310, 59)
        Me.txtCodLancamento.Name = "txtCodLancamento"
        Me.txtCodLancamento.Size = New System.Drawing.Size(94, 24)
        Me.txtCodLancamento.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2010
        Me.txtCodLancamento.TabIndex = 4
        Me.txtCodLancamento.ThemeName = "Office2010"
        '
        'AutoLabel2
        '
        Me.AutoLabel2.Location = New System.Drawing.Point(242, 38)
        Me.AutoLabel2.Name = "AutoLabel2"
        Me.AutoLabel2.Size = New System.Drawing.Size(50, 13)
        Me.AutoLabel2.TabIndex = 40
        Me.AutoLabel2.Text = "Natureza"
        '
        'AutoLabel1
        '
        Me.AutoLabel1.Location = New System.Drawing.Point(265, 10)
        Me.AutoLabel1.Name = "AutoLabel1"
        Me.AutoLabel1.Size = New System.Drawing.Size(27, 13)
        Me.AutoLabel1.TabIndex = 39
        Me.AutoLabel1.Text = "Filial"
        '
        'cboxNatureza
        '
        Me.cboxNatureza.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.cboxNatureza.FormattingEnabled = True
        Me.cboxNatureza.Location = New System.Drawing.Point(310, 32)
        Me.cboxNatureza.Name = "cboxNatureza"
        Me.cboxNatureza.Size = New System.Drawing.Size(282, 23)
        Me.cboxNatureza.TabIndex = 3
        '
        'cboxFilial
        '
        Me.cboxFilial.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.cboxFilial.FormattingEnabled = True
        Me.cboxFilial.Location = New System.Drawing.Point(310, 2)
        Me.cboxFilial.Name = "cboxFilial"
        Me.cboxFilial.Size = New System.Drawing.Size(282, 23)
        Me.cboxFilial.TabIndex = 2
        '
        'txtPesquisarGrid
        '
        Me.txtPesquisarGrid.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPesquisarGrid.BeforeTouchSize = New System.Drawing.Size(712, 27)
        Me.txtPesquisarGrid.BorderColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.txtPesquisarGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPesquisarGrid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPesquisarGrid.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtPesquisarGrid.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPesquisarGrid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtPesquisarGrid.Location = New System.Drawing.Point(0, 562)
        Me.txtPesquisarGrid.Name = "txtPesquisarGrid"
        Me.txtPesquisarGrid.Size = New System.Drawing.Size(712, 27)
        Me.txtPesquisarGrid.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful
        Me.txtPesquisarGrid.TabIndex = 2
        Me.txtPesquisarGrid.ThemeName = "Office2016Colorful"
        '
        'msgAguarde
        '
        Me.msgAguarde.Controls.Add(Me.Label1)
        Me.msgAguarde.Location = New System.Drawing.Point(213, 233)
        Me.msgAguarde.Name = "msgAguarde"
        Me.msgAguarde.Size = New System.Drawing.Size(338, 152)
        Me.msgAguarde.TabIndex = 44
        Me.msgAguarde.Visible = False
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
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Calibri", 8.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgResultado.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Calibri", 8.0!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgResultado.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgResultado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgResultado.Location = New System.Drawing.Point(0, 135)
        Me.dgResultado.Name = "dgResultado"
        Me.dgResultado.ReadOnly = True
        Me.dgResultado.ShowCellErrors = False
        Me.dgResultado.ShowCellToolTips = False
        Me.dgResultado.ShowEditingIcon = False
        Me.dgResultado.ShowRowErrors = False
        Me.dgResultado.Size = New System.Drawing.Size(712, 427)
        Me.dgResultado.TabIndex = 43
        '
        'btnPrint
        '
        Me.btnPrint.AccessibleName = "Button"
        Me.btnPrint.AutoEllipsis = True
        Me.btnPrint.BackColor = System.Drawing.Color.White
        Me.btnPrint.FocusRectangleVisible = True
        Me.btnPrint.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.btnPrint.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnPrint.Location = New System.Drawing.Point(5, 89)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(181, 37)
        Me.btnPrint.Style.BackColor = System.Drawing.Color.White
        Me.btnPrint.Style.Image = Global.SolutionsSalaoEscola.My.Resources.Resources.print_icon1
        Me.btnPrint.TabIndex = 52
        Me.btnPrint.Text = "Relatório Geral"
        Me.btnPrint.TextMargin = New System.Windows.Forms.Padding(1)
        Me.btnPrint.ThemeName = ""
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnNovoFinanceiro
        '
        Me.btnNovoFinanceiro.AccessibleName = "Button"
        Me.btnNovoFinanceiro.BackColor = System.Drawing.Color.White
        Me.btnNovoFinanceiro.FocusRectangleVisible = True
        Me.btnNovoFinanceiro.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.btnNovoFinanceiro.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnNovoFinanceiro.Location = New System.Drawing.Point(435, 90)
        Me.btnNovoFinanceiro.Name = "btnNovoFinanceiro"
        Me.btnNovoFinanceiro.Size = New System.Drawing.Size(157, 37)
        Me.btnNovoFinanceiro.Style.BackColor = System.Drawing.Color.White
        Me.btnNovoFinanceiro.Style.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.btnNovoFinanceiro.TabIndex = 6
        Me.btnNovoFinanceiro.Text = "Inserir Financeiro"
        Me.btnNovoFinanceiro.ThemeName = ""
        Me.btnNovoFinanceiro.UseVisualStyleBackColor = False
        '
        'btnPesquisar
        '
        Me.btnPesquisar.AccessibleName = "Button"
        Me.btnPesquisar.BackColor = System.Drawing.Color.White
        Me.btnPesquisar.FocusRectangleVisible = True
        Me.btnPesquisar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.btnPesquisar.ImageSize = New System.Drawing.Size(30, 35)
        Me.btnPesquisar.Location = New System.Drawing.Point(598, 29)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(105, 97)
        Me.btnPesquisar.Style.BackColor = System.Drawing.Color.White
        Me.btnPesquisar.Style.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        Me.btnPesquisar.TabIndex = 5
        Me.btnPesquisar.Text = "Pesquisar"
        Me.btnPesquisar.ThemeName = ""
        Me.btnPesquisar.UseVisualStyleBackColor = False
        '
        'btnPrintNatureza
        '
        Me.btnPrintNatureza.AccessibleName = "Button"
        Me.btnPrintNatureza.AutoEllipsis = True
        Me.btnPrintNatureza.BackColor = System.Drawing.Color.White
        Me.btnPrintNatureza.FocusRectangleVisible = True
        Me.btnPrintNatureza.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.btnPrintNatureza.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnPrintNatureza.Location = New System.Drawing.Point(223, 89)
        Me.btnPrintNatureza.Name = "btnPrintNatureza"
        Me.btnPrintNatureza.Size = New System.Drawing.Size(181, 37)
        Me.btnPrintNatureza.Style.BackColor = System.Drawing.Color.White
        Me.btnPrintNatureza.Style.Image = Global.SolutionsSalaoEscola.My.Resources.Resources.print_icon1
        Me.btnPrintNatureza.TabIndex = 53
        Me.btnPrintNatureza.Text = "Relatório Natureza"
        Me.btnPrintNatureza.TextMargin = New System.Windows.Forms.Padding(1)
        Me.btnPrintNatureza.ThemeName = ""
        Me.btnPrintNatureza.UseVisualStyleBackColor = False
        '
        'frmControleFinanceiro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 589)
        Me.Controls.Add(Me.msgAguarde)
        Me.Controls.Add(Me.dgResultado)
        Me.Controls.Add(Me.txtPesquisarGrid)
        Me.Controls.Add(Me.GradientPanel1)
        Me.Name = "frmControleFinanceiro"
        Me.Text = "Controle Financeiro"
        CType(Me.GradientPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GradientPanel1.ResumeLayout(False)
        Me.GradientPanel1.PerformLayout()
        CType(Me.txtCodFinanceiro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelPagamento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelPagamento.ResumeLayout(False)
        CType(Me.panelVencimento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelVencimento.ResumeLayout(False)
        CType(Me.txtCodLancamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPesquisarGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.msgAguarde.ResumeLayout(False)
        Me.msgAguarde.PerformLayout()
        CType(Me.dgResultado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GradientPanel1 As Syncfusion.Windows.Forms.Tools.GradientPanel
    Friend WithEvents AutoLabel3 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents txtCodLancamento As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents btnNovoFinanceiro As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents btnPesquisar As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents AutoLabel2 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents AutoLabel1 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents cboxNatureza As ComboBox
    Friend WithEvents cboxFilial As ComboBox
    Friend WithEvents txtPesquisarGrid As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents msgAguarde As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents dgResultado As DataGridView
    Friend WithEvents checkPagamento As CheckBox
    Friend WithEvents checkVencimento As CheckBox
    Friend WithEvents panelPagamento As Syncfusion.Windows.Forms.Tools.GradientPanel
    Friend WithEvents dtFinalPG As Syncfusion.WinForms.Input.SfDateTimeEdit
    Friend WithEvents dtInicioPG As Syncfusion.WinForms.Input.SfDateTimeEdit
    Friend WithEvents panelVencimento As Syncfusion.Windows.Forms.Tools.GradientPanel
    Friend WithEvents dtFinalVenc As Syncfusion.WinForms.Input.SfDateTimeEdit
    Friend WithEvents dtInicioVenc As Syncfusion.WinForms.Input.SfDateTimeEdit
    Friend WithEvents cboxTipo As ComboBox
    Friend WithEvents AutoLabel4 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents txtCodFinanceiro As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents btnPrint As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents btnPrintNatureza As Syncfusion.WinForms.Controls.SfButton
End Class
