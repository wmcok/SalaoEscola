<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmControleLancamentos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmControleLancamentos))
        Me.GradientPanel1 = New Syncfusion.Windows.Forms.Tools.GradientPanel()
        Me.AutoLabel3 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.txtCodLancamento = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.AutoLabel2 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.AutoLabel1 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.cboxNatureza = New System.Windows.Forms.ComboBox()
        Me.cboxFilial = New System.Windows.Forms.ComboBox()
        Me.dtFinal = New Syncfusion.WinForms.Input.SfDateTimeEdit()
        Me.dtInicio = New Syncfusion.WinForms.Input.SfDateTimeEdit()
        Me.GradientPanel2 = New Syncfusion.Windows.Forms.Tools.GradientPanel()
        Me.msgAguarde = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgResultado = New System.Windows.Forms.DataGridView()
        Me.txtPesquisarGrid = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.SfSkinManager1 = New Syncfusion.WinForms.Controls.SfSkinManager(Me.components)
        Me.SfButton1 = New Syncfusion.WinForms.Controls.SfButton()
        Me.btnNovoLancamento = New Syncfusion.WinForms.Controls.SfButton()
        Me.btnPesquisar = New Syncfusion.WinForms.Controls.SfButton()
        CType(Me.GradientPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GradientPanel1.SuspendLayout()
        CType(Me.txtCodLancamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GradientPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GradientPanel2.SuspendLayout()
        Me.msgAguarde.SuspendLayout()
        CType(Me.dgResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPesquisarGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GradientPanel1
        '
        Me.GradientPanel1.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.GradientPanel1.Controls.Add(Me.SfButton1)
        Me.GradientPanel1.Controls.Add(Me.AutoLabel3)
        Me.GradientPanel1.Controls.Add(Me.txtCodLancamento)
        Me.GradientPanel1.Controls.Add(Me.btnNovoLancamento)
        Me.GradientPanel1.Controls.Add(Me.btnPesquisar)
        Me.GradientPanel1.Controls.Add(Me.AutoLabel2)
        Me.GradientPanel1.Controls.Add(Me.AutoLabel1)
        Me.GradientPanel1.Controls.Add(Me.cboxNatureza)
        Me.GradientPanel1.Controls.Add(Me.cboxFilial)
        Me.GradientPanel1.Controls.Add(Me.dtFinal)
        Me.GradientPanel1.Controls.Add(Me.dtInicio)
        Me.GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GradientPanel1.Name = "GradientPanel1"
        Me.GradientPanel1.Size = New System.Drawing.Size(788, 69)
        Me.GradientPanel1.TabIndex = 0
        '
        'AutoLabel3
        '
        Me.AutoLabel3.Location = New System.Drawing.Point(450, 17)
        Me.AutoLabel3.Name = "AutoLabel3"
        Me.AutoLabel3.Size = New System.Drawing.Size(91, 13)
        Me.AutoLabel3.TabIndex = 44
        Me.AutoLabel3.Text = "Cod. Lancamento"
        '
        'txtCodLancamento
        '
        Me.txtCodLancamento.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.txtCodLancamento.BeforeTouchSize = New System.Drawing.Size(784, 27)
        Me.txtCodLancamento.BorderColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.txtCodLancamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodLancamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodLancamento.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.txtCodLancamento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtCodLancamento.Location = New System.Drawing.Point(450, 33)
        Me.txtCodLancamento.Name = "txtCodLancamento"
        Me.txtCodLancamento.Size = New System.Drawing.Size(91, 24)
        Me.txtCodLancamento.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2010
        Me.txtCodLancamento.TabIndex = 4
        Me.txtCodLancamento.ThemeName = "Office2010"
        '
        'AutoLabel2
        '
        Me.AutoLabel2.Location = New System.Drawing.Point(114, 43)
        Me.AutoLabel2.Name = "AutoLabel2"
        Me.AutoLabel2.Size = New System.Drawing.Size(50, 13)
        Me.AutoLabel2.TabIndex = 40
        Me.AutoLabel2.Text = "Natureza"
        '
        'AutoLabel1
        '
        Me.AutoLabel1.Location = New System.Drawing.Point(137, 15)
        Me.AutoLabel1.Name = "AutoLabel1"
        Me.AutoLabel1.Size = New System.Drawing.Size(27, 13)
        Me.AutoLabel1.TabIndex = 39
        Me.AutoLabel1.Text = "Filial"
        '
        'cboxNatureza
        '
        Me.cboxNatureza.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.cboxNatureza.FormattingEnabled = True
        Me.cboxNatureza.Location = New System.Drawing.Point(170, 34)
        Me.cboxNatureza.Name = "cboxNatureza"
        Me.cboxNatureza.Size = New System.Drawing.Size(274, 23)
        Me.cboxNatureza.TabIndex = 3
        '
        'cboxFilial
        '
        Me.cboxFilial.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.cboxFilial.FormattingEnabled = True
        Me.cboxFilial.Location = New System.Drawing.Point(170, 6)
        Me.cboxFilial.Name = "cboxFilial"
        Me.cboxFilial.Size = New System.Drawing.Size(274, 23)
        Me.cboxFilial.TabIndex = 2
        '
        'dtFinal
        '
        Me.dtFinal.Cursor = System.Windows.Forms.Cursors.Default
        Me.dtFinal.DateTimeEditingMode = Syncfusion.WinForms.Input.Enums.DateTimeEditingMode.Mask
        Me.dtFinal.Location = New System.Drawing.Point(6, 34)
        Me.dtFinal.Name = "dtFinal"
        Me.dtFinal.Size = New System.Drawing.Size(102, 22)
        Me.dtFinal.TabIndex = 1
        '
        'dtInicio
        '
        Me.dtInicio.Cursor = System.Windows.Forms.Cursors.Default
        Me.dtInicio.DateTimeEditingMode = Syncfusion.WinForms.Input.Enums.DateTimeEditingMode.Mask
        Me.dtInicio.Location = New System.Drawing.Point(6, 6)
        Me.dtInicio.Name = "dtInicio"
        Me.dtInicio.Size = New System.Drawing.Size(102, 22)
        Me.dtInicio.TabIndex = 0
        '
        'GradientPanel2
        '
        Me.GradientPanel2.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.GradientPanel2.Controls.Add(Me.msgAguarde)
        Me.GradientPanel2.Controls.Add(Me.dgResultado)
        Me.GradientPanel2.Controls.Add(Me.txtPesquisarGrid)
        Me.GradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GradientPanel2.Location = New System.Drawing.Point(0, 69)
        Me.GradientPanel2.Name = "GradientPanel2"
        Me.GradientPanel2.Size = New System.Drawing.Size(788, 494)
        Me.GradientPanel2.TabIndex = 1
        '
        'msgAguarde
        '
        Me.msgAguarde.Controls.Add(Me.Label1)
        Me.msgAguarde.Location = New System.Drawing.Point(211, 134)
        Me.msgAguarde.Name = "msgAguarde"
        Me.msgAguarde.Size = New System.Drawing.Size(338, 152)
        Me.msgAguarde.TabIndex = 42
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
        Me.dgResultado.Size = New System.Drawing.Size(784, 463)
        Me.dgResultado.TabIndex = 1
        '
        'txtPesquisarGrid
        '
        Me.txtPesquisarGrid.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPesquisarGrid.BeforeTouchSize = New System.Drawing.Size(784, 27)
        Me.txtPesquisarGrid.BorderColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.txtPesquisarGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPesquisarGrid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPesquisarGrid.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtPesquisarGrid.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPesquisarGrid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtPesquisarGrid.Location = New System.Drawing.Point(0, 463)
        Me.txtPesquisarGrid.Name = "txtPesquisarGrid"
        Me.txtPesquisarGrid.Size = New System.Drawing.Size(784, 27)
        Me.txtPesquisarGrid.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful
        Me.txtPesquisarGrid.TabIndex = 0
        Me.txtPesquisarGrid.ThemeName = "Office2016Colorful"
        '
        'SfSkinManager1
        '
        Me.SfSkinManager1.Component = Nothing
        Me.SfSkinManager1.Controls = Nothing
        Me.SfSkinManager1.ThemeName = Nothing
        Me.SfSkinManager1.VisualTheme = Syncfusion.Windows.Forms.VisualTheme.Managed
        '
        'SfButton1
        '
        Me.SfButton1.AccessibleName = "Button"
        Me.SfButton1.BackColor = System.Drawing.Color.White
        Me.SfButton1.FocusRectangleVisible = True
        Me.SfButton1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.SfButton1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.SfButton1.ImageSize = New System.Drawing.Size(30, 25)
        Me.SfButton1.Location = New System.Drawing.Point(624, 4)
        Me.SfButton1.Name = "SfButton1"
        Me.SfButton1.Size = New System.Drawing.Size(71, 54)
        Me.SfButton1.Style.BackColor = System.Drawing.Color.White
        Me.SfButton1.Style.Image = Global.SolutionsSalaoEscola.My.Resources.Resources.print_icon
        Me.SfButton1.TabIndex = 45
        Me.SfButton1.Text = "Imprimir"
        Me.SfButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SfButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.SfButton1.ThemeName = ""
        Me.SfButton1.UseVisualStyleBackColor = False
        '
        'btnNovoLancamento
        '
        Me.btnNovoLancamento.AccessibleName = "Button"
        Me.btnNovoLancamento.BackColor = System.Drawing.Color.White
        Me.btnNovoLancamento.FocusRectangleVisible = True
        Me.btnNovoLancamento.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.btnNovoLancamento.ImageSize = New System.Drawing.Size(30, 25)
        Me.btnNovoLancamento.Location = New System.Drawing.Point(701, 4)
        Me.btnNovoLancamento.Name = "btnNovoLancamento"
        Me.btnNovoLancamento.Size = New System.Drawing.Size(71, 54)
        Me.btnNovoLancamento.Style.BackColor = System.Drawing.Color.White
        Me.btnNovoLancamento.Style.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.btnNovoLancamento.TabIndex = 6
        Me.btnNovoLancamento.Text = "Novo"
        Me.btnNovoLancamento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnNovoLancamento.ThemeName = ""
        Me.btnNovoLancamento.UseVisualStyleBackColor = False
        '
        'btnPesquisar
        '
        Me.btnPesquisar.AccessibleName = "Button"
        Me.btnPesquisar.BackColor = System.Drawing.Color.White
        Me.btnPesquisar.FocusRectangleVisible = True
        Me.btnPesquisar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.btnPesquisar.ImageSize = New System.Drawing.Size(30, 25)
        Me.btnPesquisar.Location = New System.Drawing.Point(547, 4)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(71, 53)
        Me.btnPesquisar.Style.BackColor = System.Drawing.Color.White
        Me.btnPesquisar.Style.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        Me.btnPesquisar.TabIndex = 5
        Me.btnPesquisar.Text = "Pesquisar"
        Me.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnPesquisar.ThemeName = ""
        Me.btnPesquisar.UseVisualStyleBackColor = False
        '
        'frmControleLancamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(788, 563)
        Me.Controls.Add(Me.GradientPanel2)
        Me.Controls.Add(Me.GradientPanel1)
        Me.Name = "frmControleLancamentos"
        Me.Text = "Controle de Lançamentos"
        CType(Me.GradientPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GradientPanel1.ResumeLayout(False)
        Me.GradientPanel1.PerformLayout()
        CType(Me.txtCodLancamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GradientPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GradientPanel2.ResumeLayout(False)
        Me.GradientPanel2.PerformLayout()
        Me.msgAguarde.ResumeLayout(False)
        Me.msgAguarde.PerformLayout()
        CType(Me.dgResultado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPesquisarGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GradientPanel1 As Syncfusion.Windows.Forms.Tools.GradientPanel
    Friend WithEvents dtInicio As Syncfusion.WinForms.Input.SfDateTimeEdit
    Friend WithEvents dtFinal As Syncfusion.WinForms.Input.SfDateTimeEdit
    Friend WithEvents cboxFilial As ComboBox
    Friend WithEvents cboxNatureza As ComboBox
    Friend WithEvents AutoLabel2 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents AutoLabel1 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents btnPesquisar As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents GradientPanel2 As Syncfusion.Windows.Forms.Tools.GradientPanel
    Friend WithEvents txtPesquisarGrid As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents dgResultado As DataGridView
    Friend WithEvents msgAguarde As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnNovoLancamento As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents AutoLabel3 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents txtCodLancamento As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents SfSkinManager1 As Syncfusion.WinForms.Controls.SfSkinManager
    Friend WithEvents SfButton1 As Syncfusion.WinForms.Controls.SfButton
End Class
