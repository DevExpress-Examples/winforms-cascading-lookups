Imports DevExpress.XtraEditors

Namespace DXApplication1

    Public Partial Class Main
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
            lookUpEdit1.Properties.PopupFilterMode = PopupFilterMode.Contains
            SetupLookUpEditor(gridLookUpEdit1, DataProvider.GetCategoryList(), "ID", "CategoryName")
            SetupLookUpEditor(lookUpEdit1, DataProvider.GetProductList(), "ID", "ProductName", gridLookUpEdit1)
            SetupLookUpEditor(searchLookUpEdit1, DataProvider.GetOrderList(), "ID", "OrderNumber", lookUpEdit1)
        End Sub

        Private Sub SetupLookUpEditor(ByVal lookup As LookUpEditBase, ByVal dataSource As Object, ByVal valueMember As String, ByVal displayMember As String, ByVal Optional lookupOwner As LookUpEditBase = Nothing)
            lookup.Properties.DataSource = dataSource
            lookup.Properties.ValueMember = valueMember
            lookup.Properties.DisplayMember = displayMember
            lookup.CascadingOwner = lookupOwner
        End Sub
    End Class
End Namespace
