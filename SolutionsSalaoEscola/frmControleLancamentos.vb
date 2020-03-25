Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools

Public Class frmControleLancamentos
    Inherits Office2010Form
    Dim DSet As New DataSet
    Dim DSet2 As New DataSet
    Private Sub frmControleLancamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SfSkinManager1 = frmLogin.SfSkinManager1
        Me.SfSkinManager1.Controls = Me
        Me.Icon = frnPrincipal.Icon
        dtInicio.Value = DateAdd(DateInterval.Month, 0, Now).AddDays(-(Now.Day - 1))
        dtFinal.Value = DateAdd(DateInterval.Month, +1, Now).AddDays(-(Now.Day))
    End Sub

    Private Sub frmControleLancamentos_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        PREENCHE_CBOX_FILIAL(cboxFilial, True)
        PREENCHE_CBOX_NATUREZA(cboxNatureza, True)
        'PREENCHE_DG()
    End Sub
    Private Sub PREENCHE_DG()
        msgAguarde.Visible = True
        DSet.Clear()
        DSet.Tables.Clear()
        Dim CodFilial() As String = Split(cboxFilial.Text, "-")
        Dim CodNatureza() As String = Split(cboxNatureza.Text, "-")
        Dim dtin As Date = dtInicio.Value
        Dim dtout As Date = dtFinal.Value
        dtin = dtin.AddDays(-120)
        dtout = dtout.AddDays(120)
        Dim LLancamentos As List(Of Lancamento)

        Using BASE As New AplicationContext()


            Dim CodLanc As String = ""
            Dim DATA As String = ""
            Dim Filial As String = ""
            Dim Natureza As String = ""

            If txtCodLancamento.TextLength > 0 Then
                CodLanc = " Where L.Codigo = '" & txtCodLancamento.Text & "' "
            Else
                DATA = " WHERE L.DATA BETWEEN '" & CDate(dtInicio.Value).Date.ToString("yyyy-MM-dd") & "' AND  '" & CDate(dtFinal.Value).Date.ToString("yyyy-MM-dd") & "' "
                If cboxFilial.SelectedIndex = 0 Then
                    Filial = " "
                Else
                    Filial = " AND FI.CodFilial = '" & Split(cboxFilial.Text, "-")(0) & "' "
                End If
                If cboxNatureza.SelectedIndex = 0 Then
                    Natureza = " "
                Else
                    Natureza = " AND N.CodFilial = '" & Split(cboxNatureza.Text, "-")(0) & "' "
                End If
            End If



            LLancamentos = New List(Of Lancamento)

            LLancamentos = BASE.Database.SqlQuery(Of Lancamento)("SELECT L.CODIGO,L.DATA,L.VALOR,L.CODUSUARIO,L.CODFILIAL,L.CODNATUREZA,L.OBSERVACAO FROM Lancamentos L
                                                                    INNER JOIN NATUREZAS N ON N.Codigo=L.CodNatureza
                                                                    INNER JOIN FILIAL FI ON FI.Codigo=L.CodFilial " & CodLanc & DATA & Filial & Natureza).OrderBy(Function(m) m.Data).OrderBy(Function(m) m.Codigo).ToList

            Dim TESTE = From L In LLancamentos
                        Join F In BASE.Filiais On F.Codigo Equals L.CodFilial
                        Join N In BASE.Naturezas On N.Codigo Equals L.CodNatureza
                        Join U In BASE.Usuarios On U.Codigo Equals L.CodUsuario
                        Order By L.Data, L.Codigo Descending
                        Select Codigo = L.Codigo,
                        EMISSAO = L.Data,
                        IDNATUREZA = L.CodNatureza & "-" & N.Nome,
                        NOME_NATUREZA = N.Nome,
                        VALOR = L.Valor,
                        DESCRICAO = L.Observacao,
                        IDUSUARIO = L.CodUsuario,
                        NOME_USUARIO = U.Nome,
                        IDFILIAL = L.CodFilial & "-" & F.Nome,
                        NOME_FILIAL = F.Nome



            'DSet.Tables.Add(ConvertToDataTable(LFinanceiro.ToList))
            DSet.Tables.Add(ConverterListParaDataTable(TESTE.ToList))
        End Using

        dgResultado.DataSource = Nothing
        dgResultado.Refresh()

        If DSet.Tables(0).Rows.Count > 0 Then
            dgResultado.DataSource = DSet.Tables(0).DefaultView
            dgResultado.Columns("CODIGO").Width = 50
            dgResultado.Columns("EMISSAO").Width = 75
            dgResultado.Columns("IDNATUREZA").Width = 120
            dgResultado.Columns("NOME_NATUREZA").Visible = False
            dgResultado.Columns("VALOR").Width = 70
            dgResultado.Columns("IDFilial").Width = 120
            dgResultado.Columns("NOME_FILIAL").Visible = False
            dgResultado.Columns("DESCRICAO").Width = 300
            dgResultado.Columns("IDUSUARIO").Visible = False
            dgResultado.Columns("NOME_USUARIO").Visible = False
        End If
        COLORIRGRD(dgResultado)
        msgAguarde.Visible = False
    End Sub
    Private Sub txtPesquisarGrid_TextChanged(sender As Object, e As EventArgs) Handles txtPesquisarGrid.TextChanged
        If DSet.Tables(0).Rows.Count >= 1 And txtPesquisarGrid.TextLength >= 1 Then
            DSet.Tables(0).DefaultView.RowFilter = " DESCRICAO LIKE '%" + RTrim(txtPesquisarGrid.Text) + "%'"
        ElseIf txtPesquisarGrid.TextLength < 1 Then
            DSet.Tables(0).DefaultView.RowFilter = " DESCRICAO like '%'"
        End If
        COLORIRGRD(dgResultado)
    End Sub

    Private Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
        PREENCHE_DG()
    End Sub

    Private Sub btnNovoLancamento_Click(sender As Object, e As EventArgs) Handles btnNovoLancamento.Click
        Form1.MdiParent = frnPrincipal
        Form1.Acao = "INSERIR"
        Form1.Show()
        Form1.Location = New System.Drawing.Point(3, 2)
        Form1.Focus()
    End Sub

    Private Sub dgResultado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgResultado.CellDoubleClick
        'MsgBox(dgResultado.CurrentRow.Cells(0).Value)
        frmLancamentos.MdiParent = frnPrincipal
        frmLancamentos.CodProd = dgResultado.CurrentRow.Cells(0).Value
        frmLancamentos.Acao = "ALTERAR"
        frmLancamentos.Show()
        frmLancamentos.Location = New System.Drawing.Point(3, 2)
        frmLancamentos.Focus()
    End Sub

    Private Sub SfButton1_Click(sender As Object, e As EventArgs) Handles SfButton1.Click
        AbreRelatorio()
    End Sub


    Private Sub AbreRelatorio()
        Dim CodFilial() As String = Split(cboxFilial.Text, "-")
        Dim CodNatureza() As String = Split(cboxNatureza.Text, "-")
        Dim dtin As Date = dtInicio.Value
        Dim dtout As Date = dtFinal.Value
        dtin = dtin.AddDays(-120)
        dtout = dtout.AddDays(120)
        Dim LLancamentos As List(Of ReportLancamento)

        Using BASE As New AplicationContext()


            Dim CodLanc As String = ""
            Dim DATA As String = ""
            Dim Filial As String = ""
            Dim Natureza As String = ""

            If txtCodLancamento.TextLength > 0 Then
                CodLanc = " Where L.Codigo = '" & txtCodLancamento.Text & "' "
            Else
                DATA = " WHERE L.DATA BETWEEN '" & CDate(dtInicio.Value).Date.ToString("yyyy-MM-dd") & "' AND  '" & CDate(dtFinal.Value).Date.ToString("yyyy-MM-dd") & "' "
                If cboxFilial.SelectedIndex = 0 Then
                    Filial = " "
                Else
                    Filial = " AND FI.CodFilial = '" & Split(cboxFilial.Text, "-")(0) & "' "
                End If
                If cboxNatureza.SelectedIndex = 0 Then
                    Natureza = " "
                Else
                    Natureza = " AND N.CodFilial = '" & Split(cboxNatureza.Text, "-")(0) & "' "
                End If
            End If



            LLancamentos = New List(Of ReportLancamento)

            LLancamentos = BASE.Database.SqlQuery(Of ReportLancamento)("SELECT L.Codigo IDLANCAMENTO,CONVERT(DATE,L.Data,23) EMISSAO,L.VALOR VL_TOTAL,L.CodUsuario IDUSUARIO,U.Nome USUARIO,
                                                                        L.CODFILIAL IDFILIAL,F.Nome FILIAL,L.CODNATUREZA IDNATUREZA,N.Nome NATUREZA,L.OBSERVACAO, 
                                                                        LP.Codigo SEQIDPRODUTO,P.Codigo IDPRODUTO,P.Nome PRODUTO,CONVERT(NUMERIC(16,2),LP.Valor/LP.Quantidade) VL_UNIT,
                                                                        LP.Quantidade,LP.Valor VL_TT_PROD
                                                                        FROM Lancamentos L
                                                                        INNER JOIN LancamentosProdutos LP ON LP.CODLANCAMENTO=L.CODIGO
                                                                        INNER JOIN Produtos P ON P.Codigo=LP.CodProduto
                                                                        INNER JOIN NATUREZAS N ON N.Codigo=L.CodNatureza
                                                                        INNER JOIN FILIAL F ON F.Codigo=L.CodFilial
                                                                        INNER JOIN Usuarios U ON U.Codigo=L.CodUsuario " & CodLanc & DATA & Filial & Natureza).OrderBy(Function(m) m.EMISSAO).OrderBy(Function(m) m.IDLANCAMENTO).OrderBy(Function(m) m.SEQIDPRODUTO).ToList



            frmRelatorios.MdiParent = frnPrincipal

            frmRelatorios.GerarRelatorio("rptRelLancamentos.rdlc", "DataSet1", ConverterListParaDataTable(LLancamentos.ToList()), CDate(dtInicio.Value).Date.ToString("dd-MM-yyyy"), CDate(dtFinal.Value).Date.ToString("dd-MM-yyyy"), "RELATÓRIO DE LANCAMENTOS")



            'FORM.child()
            frmRelatorios.Show()
            frmRelatorios.Location = New System.Drawing.Point(35, 2)
            frmRelatorios.Focus()


        End Using
    End Sub

    Private Sub dgResultado_Sorted(sender As Object, e As EventArgs) Handles dgResultado.Sorted
        COLORIRGRD(dgResultado)
    End Sub
End Class