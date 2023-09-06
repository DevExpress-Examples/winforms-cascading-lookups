Imports System.ComponentModel
Imports System.Drawing

Namespace DXApplication1

    Public Class DataProvider

        Public Shared Function GetCategoryList(ByVal Optional recordCount As Integer = 10) As BindingList(Of Category)
            Dim list As BindingList(Of Category) = New BindingList(Of Category)()
            For i As Integer = 0 To recordCount - 1
                list.Add(New Category(i) With {.CategoryName = String.Format("Text {0}", i)})
            Next

            Return list
        End Function

        Public Shared Function GetProductList(ByVal Optional recordCount As Integer = 15) As BindingList(Of Product)
            Dim list As BindingList(Of Product) = New BindingList(Of Product)()
            For i As Integer = 0 To recordCount - 1
                list.Add(New Product(i) With {.CategoryID = i Mod 5, .Description = String.Format("Description {0}", i), .ProductName = String.Format("Product {0}", i)})
            Next

            Return list
        End Function

        Public Shared Function GetOrderList(ByVal Optional recordCount As Integer = 25) As BindingList(Of Order)
            Dim list As BindingList(Of Order) = New BindingList(Of Order)()
            For i As Integer = 0 To recordCount - 1
                list.Add(New Order(i) With {.ProductID = i Mod 15, .OrderNumber = 1000 + i})
            Next

            Return list
        End Function
    End Class

    Public Class Category

        Private _ID As Integer

        Public Sub New(ByVal id As Integer)
            Me.ID = id
        End Sub

        Public Property ID As Integer
            Get
                Return _ID
            End Get

            Private Set(ByVal value As Integer)
                _ID = value
            End Set
        End Property

        Public Property CategoryName As String
    End Class

    Public Class Product

        Private _ID As Integer

        Public Sub New(ByVal id As Integer)
            Me.ID = id
        End Sub

        Public Property ID As Integer
            Get
                Return _ID
            End Get

            Private Set(ByVal value As Integer)
                _ID = value
            End Set
        End Property

        Public Property CategoryID As Integer

        Public Property ProductName As String

        Public Property Description As String
    End Class

    Public Class Order

        Private _ID As Integer

        Public Sub New(ByVal id As Integer)
            Me.ID = id
        End Sub

        Public Property ID As Integer
            Get
                Return _ID
            End Get

            Private Set(ByVal value As Integer)
                _ID = value
            End Set
        End Property

        Public Property ProductID As Integer

        Public Property OrderNumber As Integer
    End Class
End Namespace
