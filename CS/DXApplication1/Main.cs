using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraEditors;

namespace DXApplication1 {
    public partial class Main : DevExpress.XtraEditors.XtraForm {
        public Main() {
            InitializeComponent();
            lookUpEdit1.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;

            SetupLookUpEditor(gridLookUpEdit1, DataProvider.GetCategoryList(), "ID", "CategoryName");
            SetupLookUpEditor(lookUpEdit1, DataProvider.GetProductList(), "ID", "ProductName", gridLookUpEdit1);
            SetupLookUpEditor(searchLookUpEdit1, DataProvider.GetOrderList(), "ID", "OrderNumber", lookUpEdit1);
        }

        private void SetupLookUpEditor(LookUpEditBase lookup, object dataSource, string valueMember, string displayMember, LookUpEditBase lookupOwner = null) {
            lookup.Properties.DataSource = dataSource;
            lookup.Properties.ValueMember = valueMember;
            lookup.Properties.DisplayMember = displayMember;
            lookup.CascadingOwner = lookupOwner;
        }
    }
}
