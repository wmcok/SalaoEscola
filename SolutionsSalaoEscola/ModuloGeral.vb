Imports System.Reflection
Imports System.Reflection.Emit
Imports System.Runtime.InteropServices.ComTypes
Imports System.Security.AccessControl
Imports Syncfusion.Diagnostics
Imports Syncfusion.WinForms.Controls

Module ModuloGeral
    Public Trocausuario As String = "SAIR"

    Public Function LOGAR(USER As String, PASS As String) As Boolean
        Dim LOGADO As List(Of Usuario)
        Using db As New AplicationContext
            LOGADO = db.Usuarios.Where(Function(m) m.Nome = USER And m.Senha = PASS).ToList
        End Using
        If LOGADO.Count > 0 Then
            UsuarioLogado.Codigo = LOGADO.Item(0).Codigo
            UsuarioLogado.Nome = LOGADO.Item(0).Nome

            Return True
        Else
            Return False
        End If
    End Function
    'Public Function ConvertToDataTable(Of t)(ByVal list As IList(Of t)) As DataTable
    '    Dim table As New DataTable()
    '    If Not list.Any Then
    '        'don't know schema ....
    '        Return table
    '    End If
    '    Dim fields() = list.First.GetType.GetProperties
    '    For Each field In fields
    '        table.Columns.Add(field.Name, Nullable.GetUnderlyingType(field.PropertyType))
    '    Next
    '    For Each item In list
    '        Dim row As DataRow = table.NewRow()
    '        For Each field In fields
    '            Dim p = item.GetType.GetProperty(field.Name)
    '            row(field.Name) = p.GetValue(item, Nothing)
    '        Next
    '        table.Rows.Add(row)
    '    Next
    '    Return table
    'End Function
    Public Function ConverterListParaDataTable(Of T)(ByVal list As IList(Of T)) As DataTable
        Dim table As New DataTable()
        Dim fields() As FieldInfo = GetType(T).GetFields()
        For Each field As FieldInfo In fields
            table.Columns.Add(field.Name, field.FieldType)
        Next
        For Each item As T In list
            Dim row As DataRow = table.NewRow()
            For Each field As FieldInfo In fields
                row(field.Name) = field.GetValue(item)
            Next
            table.Rows.Add(row)
        Next
        Return table
    End Function

    Public Function ConverterListParaDataTable(Of T)(items As List(Of T)) As DataTable

        Try
            Dim dataTable As New DataTable(GetType(T).Name)
            'Pega todas as propriedades
            Dim Propriedades As PropertyInfo() = GetType(T).GetProperties(BindingFlags.[Public] Or BindingFlags.Instance)
            For Each _propriedade As PropertyInfo In Propriedades
                'Define os nomes das colunas como os nomes das propriedades
                dataTable.Columns.Add(_propriedade.Name)
            Next
            For Each item As T In items
                Dim valores = New Object(Propriedades.Length - 1) {}
                For i As Integer = 0 To Propriedades.Length - 1
                    'inclui os valores das propriedades nas linhas do datatable
                    valores(i) = Propriedades(i).GetValue(item, Nothing)
                Next
                dataTable.Rows.Add(valores)
            Next
            Return dataTable
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function PREENCHE_CBOX_FILIAL(CBOX As ComboBox, PESQUISAR As Boolean)
        Dim TABELA As List(Of Filial)
        Using db As New AplicationContext
            TABELA = db.Filiais.OrderBy(Function(m) m.Codigo).ToList
        End Using

        CBOX.Items.Clear()
        If PESQUISAR = True Then
            CBOX.Items.Add("TODOS")
        End If
        For Each ITEM In TABELA
            CBOX.Items.Add(ITEM.Codigo & "-" & ITEM.Nome)
        Next

        CBOX.Refresh()
        CBOX.SelectedIndex = 0
    End Function

    Public Sub PREENCHE_CBOX_NATUREZA(CBOX As ComboBox, PESQUISAR As Boolean)
        Dim TABELA As List(Of Natureza)
        Using db As New AplicationContext
            TABELA = db.Naturezas.OrderBy(Function(m) m.Codigo).ToList
        End Using

        CBOX.Items.Clear()
        If PESQUISAR = True Then
            CBOX.Items.Add("TODOS")
        End If

        For Each ITEM In TABELA
            CBOX.Items.Add(ITEM.Codigo & "-" & ITEM.Nome)
        Next

        CBOX.Refresh()
        CBOX.SelectedIndex = 0
    End Sub

    Public Sub PREENCHE_CBOX_PRODUTO(CBOX As ComboBox, PESQUISAR As Boolean)
        Dim TABELA As List(Of Produto)
        Using db As New AplicationContext
            TABELA = db.Produtos.OrderBy(Function(m) m.Codigo).ToList
        End Using

        CBOX.Items.Clear()
        If PESQUISAR = True Then
            CBOX.Items.Add("TODOS")
        End If

        For Each ITEM In TABELA
            CBOX.Items.Add(ITEM.Codigo & "-" & ITEM.Nome)
        Next

        CBOX.Refresh()
        CBOX.SelectedIndex = 0
    End Sub

    Public Function CONTROLE_GRUD(ACAO As String, INS As SfButton, ALT As SfButton, DEL As SfButton, CAN As SfButton, GRA As SfButton) As String
        Dim T As String = ACAO.ToString.Substring(0, 3)
        If ACAO = "INSERIR" Then
            INS.Enabled = False
            ALT.Enabled = False
            DEL.Enabled = False
            CAN.Enabled = True
            GRA.Enabled = True
            Return T
        ElseIf ACAO = "ALTERAR" Then
            INS.Enabled = False
            ALT.Enabled = False
            DEL.Enabled = False
            CAN.Enabled = True
            GRA.Enabled = True
            Return T
        ElseIf ACAO = "EXCLUIR" Then
            Return ""
        ElseIf ACAO = "CANCELAR" Then
            INS.Enabled = True
            ALT.Enabled = True
            DEL.Enabled = True
            CAN.Enabled = False
            GRA.Enabled = False
            Return ""
        ElseIf ACAO = "GRAVAR" Then
            INS.Enabled = True
            ALT.Enabled = True
            DEL.Enabled = True
            CAN.Enabled = False
            GRA.Enabled = False
            Return ""
        ElseIf ACAO = "INICIO" Or ACAO = "" Then
            INS.Enabled = True
            ALT.Enabled = True
            DEL.Enabled = True
            CAN.Enabled = False
            GRA.Enabled = False
            Return ""
        End If
    End Function


    Public Sub COLORIRGRD(GRID As DataGridView)
        If GRID.Rows.Count > 1 Then
            For x As Integer = 1 To GRID.Rows.Count Step 1
                If x Mod 2 = 0 Then
                    GRID.Rows(x - 1).DefaultCellStyle.BackColor = Color.PowderBlue
                Else
                    GRID.Rows(x - 1).DefaultCellStyle.BackColor = Color.White
                End If
            Next
        End If
    End Sub



End Module
