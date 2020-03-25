<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFinanceiro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFinanceiro))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.panelPagamento = New System.Windows.Forms.Panel()
        Me.AutoLabel9 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.dtDataPagamento = New Syncfusion.WinForms.Input.SfDateTimeEdit()
        Me.txtValorPago = New Syncfusion.Windows.Forms.Tools.DoubleTextBox()
        Me.AutoLabel10 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.checkPago = New System.Windows.Forms.CheckBox()
        Me.AutoLabel7 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.dtVencimento = New Syncfusion.WinForms.Input.SfDateTimeEdit()
        Me.txtValor = New Syncfusion.Windows.Forms.Tools.DoubleTextBox()
        Me.AutoLabel8 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.AutoLabel4 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.txtObservacao = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.AutoLabel3 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.txtCodigoFinanceiro = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.AutoLabel2 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.txtCodigoLancamento = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.AutoLabel1 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.AutoLabel6 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.AutoLabel5 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.cboxNatureza = New System.Windows.Forms.ComboBox()
        Me.cboxFilial = New System.Windows.Forms.ComboBox()
        Me.cboxTipoFinanceiro = New System.Windows.Forms.ComboBox()
        Me.GradientPanel3 = New Syncfusion.Windows.Forms.Tools.GradientPanel()
        Me.btnGravar = New Syncfusion.WinForms.Controls.SfButton()
        Me.btnCancelar = New Syncfusion.WinForms.Controls.SfButton()
        Me.btnExcluir = New Syncfusion.WinForms.Controls.SfButton()
        Me.btnAlterar = New Syncfusion.WinForms.Controls.SfButton()
        Me.btnInserir = New Syncfusion.WinForms.Controls.SfButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.msgAguarde = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgResultado = New System.Windows.Forms.DataGridView()
        Me.txtPesquisarGrid = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.Panel1.SuspendLayout()
        Me.panelPagamento.SuspendLayout()
        CType(Me.txtValorPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtObservacao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoFinanceiro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoLancamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GradientPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GradientPanel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.msgAguarde.SuspendLayout()
        CType(Me.dgResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPesquisarGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.panelPagamento)
        Me.Panel1.Controls.Add(Me.checkPago)
        Me.Panel1.Controls.Add(Me.AutoLabel7)
        Me.Panel1.Controls.Add(Me.dtVencimento)
        Me.Panel1.Controls.Add(Me.txtValor)
        Me.Panel1.Controls.Add(Me.AutoLabel8)
        Me.Panel1.Controls.Add(Me.AutoLabel4)
        Me.Panel1.Controls.Add(Me.txtObservacao)
        Me.Panel1.Controls.Add(Me.AutoLabel3)
        Me.Panel1.Controls.Add(Me.txtCodigoFinanceiro)
        Me.Panel1.Controls.Add(Me.AutoLabel2)
        Me.Panel1.Controls.Add(Me.txtCodigoLancamento)
        Me.Panel1.Controls.Add(Me.AutoLabel1)
        Me.Panel1.Controls.Add(Me.AutoLabel6)
        Me.Panel1.Controls.Add(Me.AutoLabel5)
        Me.Panel1.Controls.Add(Me.cboxNatureza)
        Me.Panel1.Controls.Add(Me.cboxFilial)
        Me.Panel1.Controls.Add(Me.cboxTipoFinanceiro)
        Me.Panel1.Controls.Add(Me.GradientPanel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 219)
        Me.Panel1.TabIndex = 0
        '
        'panelPagamento
        '
        Me.panelPagamento.Controls.Add(Me.AutoLabel9)
        Me.panelPagamento.Controls.Add(Me.dtDataPagamento)
        Me.panelPagamento.Controls.Add(Me.txtValorPago)
        Me.panelPagamento.Controls.Add(Me.AutoLabel10)
        Me.panelPagamento.Location = New System.Drawing.Point(428, 92)
        Me.panelPagamento.Name = "panelPagamento"
        Me.panelPagamento.Size = New System.Drawing.Size(248, 53)
        Me.panelPagamento.TabIndex = 70
        '
        'AutoLabel9
        '
        Me.AutoLabel9.Location = New System.Drawing.Point(135, 7)
        Me.AutoLabel9.Name = "AutoLabel9"
        Me.AutoLabel9.Size = New System.Drawing.Size(59, 13)
        Me.AutoLabel9.TabIndex = 72
        Me.AutoLabel9.Text = "Valor Pago"
        '
        'dtDataPagamento
        '
        Me.dtDataPagamento.Cursor = System.Windows.Forms.Cursors.Default
        Me.dtDataPagamento.DateTimeEditingMode = Syncfusion.WinForms.Input.Enums.DateTimeEditingMode.Mask
        Me.dtDataPagamento.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.dtDataPagamento.Location = New System.Drawing.Point(8, 25)
        Me.dtDataPagamento.Name = "dtDataPagamento"
        Me.dtDataPagamento.Size = New System.Drawing.Size(121, 22)
        Me.dtDataPagamento.TabIndex = 0
        '
        'txtValorPago
        '
        Me.txtValorPago.BackGroundColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.txtValorPago.BeforeTouchSize = New System.Drawing.Size(87, 27)
        Me.txtValorPago.BorderColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.txtValorPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtValorPago.DoubleValue = 1.0R
        Me.txtValorPago.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.txtValorPago.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtValorPago.Location = New System.Drawing.Point(135, 23)
        Me.txtValorPago.Name = "txtValorPago"
        Me.txtValorPago.PositiveColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtValorPago.Size = New System.Drawing.Size(106, 24)
        Me.txtValorPago.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2010
        Me.txtValorPago.TabIndex = 1
        Me.txtValorPago.Text = "1,00"
        Me.txtValorPago.ThemeName = "Office2010"
        Me.txtValorPago.ZeroColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        '
        'AutoLabel10
        '
        Me.AutoLabel10.Location = New System.Drawing.Point(8, 7)
        Me.AutoLabel10.Name = "AutoLabel10"
        Me.AutoLabel10.Size = New System.Drawing.Size(102, 13)
        Me.AutoLabel10.TabIndex = 71
        Me.AutoLabel10.Text = "Data de Pagamento"
        '
        'checkPago
        '
        Me.checkPago.AutoSize = True
        Me.checkPago.Location = New System.Drawing.Point(362, 108)
        Me.checkPago.Name = "checkPago"
        Me.checkPago.Size = New System.Drawing.Size(60, 17)
        Me.checkPago.TabIndex = 7
        Me.checkPago.Text = "Pago ?"
        Me.checkPago.UseVisualStyleBackColor = True
        '
        'AutoLabel7
        '
        Me.AutoLabel7.Location = New System.Drawing.Point(134, 94)
        Me.AutoLabel7.Name = "AutoLabel7"
        Me.AutoLabel7.Size = New System.Drawing.Size(31, 13)
        Me.AutoLabel7.TabIndex = 64
        Me.AutoLabel7.Text = "Valor"
        '
        'dtVencimento
        '
        Me.dtVencimento.Cursor = System.Windows.Forms.Cursors.Default
        Me.dtVencimento.DateTimeEditingMode = Syncfusion.WinForms.Input.Enums.DateTimeEditingMode.Mask
        Me.dtVencimento.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.dtVencimento.Location = New System.Drawing.Point(7, 110)
        Me.dtVencimento.Name = "dtVencimento"
        Me.dtVencimento.Size = New System.Drawing.Size(121, 22)
        Me.dtVencimento.TabIndex = 5
        '
        'txtValor
        '
        Me.txtValor.BackGroundColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.txtValor.BeforeTouchSize = New System.Drawing.Size(87, 27)
        Me.txtValor.BorderColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtValor.DoubleValue = 1.0R
        Me.txtValor.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.txtValor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtValor.Location = New System.Drawing.Point(134, 110)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.PositiveColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtValor.Size = New System.Drawing.Size(106, 24)
        Me.txtValor.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2010
        Me.txtValor.TabIndex = 6
        Me.txtValor.Text = "1,00"
        Me.txtValor.ThemeName = "Office2010"
        Me.txtValor.ZeroColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        '
        'AutoLabel8
        '
        Me.AutoLabel8.Location = New System.Drawing.Point(7, 94)
        Me.AutoLabel8.Name = "AutoLabel8"
        Me.AutoLabel8.Size = New System.Drawing.Size(63, 13)
        Me.AutoLabel8.TabIndex = 63
        Me.AutoLabel8.Text = "Vencimento"
        '
        'AutoLabel4
        '
        Me.AutoLabel4.Location = New System.Drawing.Point(8, 135)
        Me.AutoLabel4.Name = "AutoLabel4"
        Me.AutoLabel4.Size = New System.Drawing.Size(55, 13)
        Me.AutoLabel4.TabIndex = 60
        Me.AutoLabel4.Text = "Descrição"
        '
        'txtObservacao
        '
        Me.txtObservacao.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.txtObservacao.BeforeTouchSize = New System.Drawing.Size(87, 27)
        Me.txtObservacao.BorderColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.txtObservacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservacao.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacao.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtObservacao.Location = New System.Drawing.Point(7, 151)
        Me.txtObservacao.MaxLength = 300
        Me.txtObservacao.Multiline = True
        Me.txtObservacao.Name = "txtObservacao"
        Me.txtObservacao.Size = New System.Drawing.Size(669, 59)
        Me.txtObservacao.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2010
        Me.txtObservacao.TabIndex = 8
        Me.txtObservacao.ThemeName = "Office2010"
        '
        'AutoLabel3
        '
        Me.AutoLabel3.Location = New System.Drawing.Point(164, 4)
        Me.AutoLabel3.Name = "AutoLabel3"
        Me.AutoLabel3.Size = New System.Drawing.Size(107, 13)
        Me.AutoLabel3.TabIndex = 58
        Me.AutoLabel3.Text = "Código do Financeiro"
        '
        'txtCodigoFinanceiro
        '
        Me.txtCodigoFinanceiro.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtCodigoFinanceiro.BeforeTouchSize = New System.Drawing.Size(87, 27)
        Me.txtCodigoFinanceiro.BorderColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.txtCodigoFinanceiro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigoFinanceiro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoFinanceiro.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.txtCodigoFinanceiro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.txtCodigoFinanceiro.Location = New System.Drawing.Point(164, 23)
        Me.txtCodigoFinanceiro.Name = "txtCodigoFinanceiro"
        Me.txtCodigoFinanceiro.Size = New System.Drawing.Size(117, 24)
        Me.txtCodigoFinanceiro.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2007
        Me.txtCodigoFinanceiro.TabIndex = 1
        Me.txtCodigoFinanceiro.ThemeName = "Office2007"
        '
        'AutoLabel2
        '
        Me.AutoLabel2.Location = New System.Drawing.Point(287, 4)
        Me.AutoLabel2.Name = "AutoLabel2"
        Me.AutoLabel2.Size = New System.Drawing.Size(117, 13)
        Me.AutoLabel2.TabIndex = 56
        Me.AutoLabel2.Text = "Código de Lançamento"
        '
        'txtCodigoLancamento
        '
        Me.txtCodigoLancamento.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtCodigoLancamento.BeforeTouchSize = New System.Drawing.Size(87, 27)
        Me.txtCodigoLancamento.BorderColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.txtCodigoLancamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigoLancamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoLancamento.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.txtCodigoLancamento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.txtCodigoLancamento.Location = New System.Drawing.Point(287, 23)
        Me.txtCodigoLancamento.Name = "txtCodigoLancamento"
        Me.txtCodigoLancamento.Size = New System.Drawing.Size(117, 24)
        Me.txtCodigoLancamento.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2007
        Me.txtCodigoLancamento.TabIndex = 2
        Me.txtCodigoLancamento.ThemeName = "Office2007"
        '
        'AutoLabel1
        '
        Me.AutoLabel1.Location = New System.Drawing.Point(7, 3)
        Me.AutoLabel1.Name = "AutoLabel1"
        Me.AutoLabel1.Size = New System.Drawing.Size(80, 13)
        Me.AutoLabel1.TabIndex = 54
        Me.AutoLabel1.Text = "Tipo Financeiro"
        '
        'AutoLabel6
        '
        Me.AutoLabel6.Location = New System.Drawing.Point(319, 49)
        Me.AutoLabel6.Name = "AutoLabel6"
        Me.AutoLabel6.Size = New System.Drawing.Size(50, 13)
        Me.AutoLabel6.TabIndex = 53
        Me.AutoLabel6.Text = "Natureza"
        '
        'AutoLabel5
        '
        Me.AutoLabel5.Location = New System.Drawing.Point(7, 49)
        Me.AutoLabel5.Name = "AutoLabel5"
        Me.AutoLabel5.Size = New System.Drawing.Size(27, 13)
        Me.AutoLabel5.TabIndex = 52
        Me.AutoLabel5.Text = "Filial"
        '
        'cboxNatureza
        '
        Me.cboxNatureza.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.cboxNatureza.FormattingEnabled = True
        Me.cboxNatureza.Location = New System.Drawing.Point(319, 64)
        Me.cboxNatureza.Name = "cboxNatureza"
        Me.cboxNatureza.Size = New System.Drawing.Size(357, 23)
        Me.cboxNatureza.TabIndex = 4
        '
        'cboxFilial
        '
        Me.cboxFilial.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.cboxFilial.FormattingEnabled = True
        Me.cboxFilial.Location = New System.Drawing.Point(7, 64)
        Me.cboxFilial.Name = "cboxFilial"
        Me.cboxFilial.Size = New System.Drawing.Size(306, 23)
        Me.cboxFilial.TabIndex = 3
        '
        'cboxTipoFinanceiro
        '
        Me.cboxTipoFinanceiro.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.cboxTipoFinanceiro.FormattingEnabled = True
        Me.cboxTipoFinanceiro.Items.AddRange(New Object() {"Pagar", "Receber"})
        Me.cboxTipoFinanceiro.Location = New System.Drawing.Point(7, 23)
        Me.cboxTipoFinanceiro.Name = "cboxTipoFinanceiro"
        Me.cboxTipoFinanceiro.Size = New System.Drawing.Size(151, 23)
        Me.cboxTipoFinanceiro.TabIndex = 0
        '
        'GradientPanel3
        '
        Me.GradientPanel3.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.GradientPanel3.Controls.Add(Me.btnGravar)
        Me.GradientPanel3.Controls.Add(Me.btnCancelar)
        Me.GradientPanel3.Controls.Add(Me.btnExcluir)
        Me.GradientPanel3.Controls.Add(Me.btnAlterar)
        Me.GradientPanel3.Controls.Add(Me.btnInserir)
        Me.GradientPanel3.Location = New System.Drawing.Point(682, 3)
        Me.GradientPanel3.Name = "GradientPanel3"
        Me.GradientPanel3.Size = New System.Drawing.Size(113, 206)
        Me.GradientPanel3.TabIndex = 39
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
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.msgAguarde)
        Me.Panel2.Controls.Add(Me.dgResultado)
        Me.Panel2.Controls.Add(Me.txtPesquisarGrid)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 219)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 308)
        Me.Panel2.TabIndex = 1
        '
        'msgAguarde
        '
        Me.msgAguarde.Controls.Add(Me.Label1)
        Me.msgAguarde.Location = New System.Drawing.Point(252, 63)
        Me.msgAguarde.Name = "msgAguarde"
        Me.msgAguarde.Size = New System.Drawing.Size(338, 152)
        Me.msgAguarde.TabIndex = 45
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
        Me.dgResultado.Size = New System.Drawing.Size(800, 281)
        Me.dgResultado.TabIndex = 1
        '
        'txtPesquisarGrid
        '
        Me.txtPesquisarGrid.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPesquisarGrid.BeforeTouchSize = New System.Drawing.Size(87, 27)
        Me.txtPesquisarGrid.BorderColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.txtPesquisarGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPesquisarGrid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPesquisarGrid.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtPesquisarGrid.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPesquisarGrid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtPesquisarGrid.Location = New System.Drawing.Point(0, 281)
        Me.txtPesquisarGrid.Name = "txtPesquisarGrid"
        Me.txtPesquisarGrid.Size = New System.Drawing.Size(800, 27)
        Me.txtPesquisarGrid.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful
        Me.txtPesquisarGrid.TabIndex = 0
        Me.txtPesquisarGrid.ThemeName = "Office2016Colorful"
        '
        'frmFinanceiro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 527)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmFinanceiro"
        Me.Text = "Cadastro Financeiro"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.panelPagamento.ResumeLayout(False)
        Me.panelPagamento.PerformLayout()
        CType(Me.txtValorPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtObservacao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoFinanceiro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoLancamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GradientPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GradientPanel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.msgAguarde.ResumeLayout(False)
        Me.msgAguarde.PerformLayout()
        CType(Me.dgResultado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPesquisarGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents msgAguarde As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents dgResultado As DataGridView
    Friend WithEvents txtPesquisarGrid As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents GradientPanel3 As Syncfusion.Windows.Forms.Tools.GradientPanel
    Friend WithEvents btnGravar As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents btnCancelar As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents btnExcluir As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents btnAlterar As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents btnInserir As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents cboxTipoFinanceiro As ComboBox
    Friend WithEvents AutoLabel1 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents AutoLabel6 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents AutoLabel5 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents cboxNatureza As ComboBox
    Friend WithEvents cboxFilial As ComboBox
    Friend WithEvents AutoLabel2 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents txtCodigoLancamento As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents AutoLabel3 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents txtCodigoFinanceiro As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents AutoLabel4 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents txtObservacao As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents AutoLabel7 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents dtVencimento As Syncfusion.WinForms.Input.SfDateTimeEdit
    Friend WithEvents txtValor As Syncfusion.Windows.Forms.Tools.DoubleTextBox
    Friend WithEvents AutoLabel8 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents panelPagamento As Panel
    Friend WithEvents AutoLabel9 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents dtDataPagamento As Syncfusion.WinForms.Input.SfDateTimeEdit
    Friend WithEvents txtValorPago As Syncfusion.Windows.Forms.Tools.DoubleTextBox
    Friend WithEvents AutoLabel10 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents checkPago As CheckBox
End Class
