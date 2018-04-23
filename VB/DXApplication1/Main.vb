Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraEditors

Namespace DXApplication1
    Partial Public Class Main
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            InitializeComponent()
            lookUpEdit1.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains

            SetupLookUpEditor(gridLookUpEdit1, DataProvider.GetCategoryList(), "ID", "CategoryName")
            SetupLookUpEditor(lookUpEdit1, DataProvider.GetProductList(), "ID", "ProductName", gridLookUpEdit1)
            SetupLookUpEditor(searchLookUpEdit1, DataProvider.GetOrderList(), "ID", "OrderNumber", lookUpEdit1)
        End Sub

        Private Sub SetupLookUpEditor(ByVal lookup As LookUpEditBase, ByVal dataSource As Object, ByVal valueMember As String, ByVal displayMember As String, Optional ByVal lookupOwner As LookUpEditBase = Nothing)
            lookup.Properties.DataSource = dataSource
            lookup.Properties.ValueMember = valueMember
            lookup.Properties.DisplayMember = displayMember
            lookup.CascadingOwner = lookupOwner
        End Sub
    End Class
End Namespace
