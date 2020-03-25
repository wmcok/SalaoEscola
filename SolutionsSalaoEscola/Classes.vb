
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Module VariaveisGlobais
    Public UsuarioLogado As New Usuario
End Module




<Table("Usuarios")>
Public Class Usuario
    <DatabaseGenerated(DatabaseGeneratedOption.Identity)>
    <Key>
    Public Property Codigo As Integer
    <MaxLength(40)>
    Public Property Nome As String

    <MaxLength(40)>
    Public Property Senha As String

    Public Sub ExecutarLogin(Nome As String, Senha As String)

    End Sub

End Class

<Table("Naturezas")>
Public Class Natureza
    <DatabaseGenerated(DatabaseGeneratedOption.Identity)>
    <Key>
    Public Property Codigo As Integer
    <MaxLength(60)>
    Public Property Nome As String

End Class

<Table("Produtos")>
Public Class Produto
    <DatabaseGenerated(DatabaseGeneratedOption.Identity)>
    <Key>
    Public Property Codigo As Integer
    <MaxLength(60)>
    Public Property Nome As String
    Public Property Preco As Decimal

    Public Property Tipo As TipoProduto
End Class

Public Enum TipoProduto
    Curso
    Aplicação
    Tratamento
    Produto
End Enum
<Table("Filial")>
Public Class Filial
    <DatabaseGenerated(DatabaseGeneratedOption.Identity)>
    <Key>
    Public Property Codigo As Integer
    <MaxLength(60)>
    Public Property Nome As String
    <MaxLength(100)>
    Public Property Endereco As String
End Class
<Table("Lancamentos")>
Public Class Lancamento
    <DatabaseGenerated(DatabaseGeneratedOption.Identity)>
    <Key>
    Public Property Codigo As Integer
    <DataType(DataType.Date)>
    Public Property Data As DateTime

    Public Property Valor As Decimal

    Public Property CodUsuario As Integer
    <ForeignKey("CodUsuario")>
    Public Property Usuario As Usuario

    Public Property CodFilial As Integer
    <ForeignKey("CodFilial")>
    Public Property Filial As Filial

    Public Property CodNatureza As Integer
    <ForeignKey("CodNatureza")>
    Public Property Natureza As Natureza

    <MaxLength(200)>
    Public Property Observacao As String
End Class

<Table("LancamentosProdutos")>
Public Class LancamentoProduto
    <DatabaseGenerated(DatabaseGeneratedOption.Identity)>
    <Key>
    Public Property Codigo As Integer

    Public Property CodLancamento As Integer
    <ForeignKey("CodLancamento")>
    Public Property Lancamento As Lancamento

    Public Property CodProduto As Integer
    <ForeignKey("CodProduto")>
    Public Property Produto As Produto

    Public Property Valor As Decimal
    Public Property Quantidade As Decimal
End Class

<Table("Financeiro")>
Public Class Financeiro
    <DatabaseGenerated(DatabaseGeneratedOption.Identity)>
    <Key>
    Public Property Codigo As Integer

    Public Property Tipo As TipoFinanceiro

    Public Property CodNatureza As Integer
    <ForeignKey("CodNatureza")>
    Public Property Natureza As Natureza


    Public Property CodLancamento As Integer?

    <MaxLength(300)>
    Public Property Descricao As String
    <DataType(DataType.Date)>
    Public Property Vencimento As Date

    Public Property Valor As Decimal
    <DataType(DataType.Date)>
    Public Property DataPagamento As Nullable(Of Date)

    Public Property ValorPago As Nullable(Of Decimal)

    Public Property CodUsuario As Integer
    <ForeignKey("CodUsuario")>
    Public Property Usuario As Usuario

    Public Property CodFilial As Integer
    <ForeignKey("CodFilial")>
    Public Property Filial As Filial


End Class

Public Enum TipoFinanceiro
    Pagar
    Receber
End Enum


Public Class ReportLancamento
    Public Property IDLANCAMENTO As Integer
    <DataType(DataType.Date)>
    Public Property EMISSAO As DateTime
    Public Property VL_TOTAL As Decimal
    Public Property IDUSUARIO As Integer
    Public Property USUARIO As String
    Public Property IDFILIAL As Integer
    Public Property FILIAL As String
    Public Property IDNATUREZA As Integer
    Public Property NATUREZA As String
    Public Property OBSERVACAO As String
    Public Property SEQIDPRODUTO As Integer
    Public Property IDPRODUTO As Integer
    Public Property PRODUTO As String
    Public Property VL_UNIT As Decimal
    Public Property QUANTIDADE As Decimal
    Public Property VL_TT_PROD As Decimal

End Class

Public Class ReportFinanceiro
    Public Property IDFINANCEIRO As Integer
    Public Property TIPO As String
    Public Property IDNATUREZA As Integer
    Public Property NATUREZA As String
    Public Property IDLANCAMENTO As Integer?
    Public Property DESCRICAO As String
    <DataType(DataType.Date)>
    Public Property DT_VENCIMENTO As Date
    Public Property VALOR As Decimal
    <DataType(DataType.Date)>
    Public Property DT_PAGAMENTO As Nullable(Of Date)
    Public Property VL_PAGO As Nullable(Of Decimal)
    Public Property IDUSUARIO As Integer
    Public Property USUARIO As String
    Public Property IDFILIAL As Integer
    Public Property FILIAL As String

End Class
