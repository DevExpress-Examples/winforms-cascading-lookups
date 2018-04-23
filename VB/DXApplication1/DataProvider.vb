Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace DXApplication1
    Public Class DataProvider
        Public Shared Function GetCategoryList(Optional ByVal recordCount As Integer = 10) As BindingList(Of Category)
            Dim list As New BindingList(Of Category)()
            For i As Integer = 0 To recordCount - 1
                list.Add(New Category(i) With {.CategoryName = String.Format("Text {0}", i)})
            Next i
            Return list
        End Function
        Public Shared Function GetProductList(Optional ByVal recordCount As Integer = 15) As BindingList(Of Product)
            Dim list As New BindingList(Of Product)()
            For i As Integer = 0 To recordCount - 1
                list.Add(New Product(i) With {.CategoryID = i Mod 5, .Description = String.Format("Description {0}", i), .ProductName = String.Format("Product {0}", i)})
            Next i
            Return list
        End Function
        Public Shared Function GetOrderList(Optional ByVal recordCount As Integer = 25) As BindingList(Of Order)
            Dim list As New BindingList(Of Order)()
            For i As Integer = 0 To recordCount - 1
                list.Add(New Order(i) With {.ProductID = i Mod 15, .OrderNumber = 1000 + i})
            Next i
            Return list
        End Function
    End Class
    Public Class Category
        Public Sub New(ByVal id As Integer)
            Me.ID = id
        End Sub
        Private privateID As Integer
        Public Property ID() As Integer
            Get
                Return privateID
            End Get
            Private Set(ByVal value As Integer)
                privateID = value
            End Set
        End Property
        Public Property CategoryName() As String
    End Class
    Public Class Product
        Public Sub New(ByVal id As Integer)
            Me.ID = id
        End Sub
        Private privateID As Integer
        Public Property ID() As Integer
            Get
                Return privateID
            End Get
            Private Set(ByVal value As Integer)
                privateID = value
            End Set
        End Property
        Public Property CategoryID() As Integer
        Public Property ProductName() As String
        Public Property Description() As String
    End Class
    Public Class Order
        Public Sub New(ByVal id As Integer)
            Me.ID = id
        End Sub
        Private privateID As Integer
        Public Property ID() As Integer
            Get
                Return privateID
            End Get
            Private Set(ByVal value As Integer)
                privateID = value
            End Set
        End Property
        Public Property ProductID() As Integer
        Public Property OrderNumber() As Integer
    End Class
End Namespace
