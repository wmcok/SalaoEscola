Imports System.Data.Entity
Public Class AplicationContext
    Inherits DbContext
    Public Property Usuarios() As DbSet(Of Usuario)
    Public Property Naturezas() As DbSet(Of Natureza)
    Public Property Produtos() As DbSet(Of Produto)
    Public Property Filiais() As DbSet(Of Filial)
    Public Property Lancamentos() As DbSet(Of Lancamento)
    Public Property LancamentosProdutos() As DbSet(Of LancamentoProduto)
    Public Property Financeiros() As DbSet(Of Financeiro)
End Class



